namespace HighBar.PersistentTests

open System
open System.Diagnostics
open System.IO
open System.Net.Sockets
open System.Threading.Tasks
open Xunit
open Xunit.Abstractions
open HighBar.Client

/// Standalone fixture for engine-kill tests.
/// Starts its own engine instance (separate from PersistentEngineFixture)
/// so that killing the engine doesn't affect other tests.
type EngineKillFixture() =
    let guid = Guid.NewGuid().ToString("N")[..7]
    let socketPath = $"/tmp/highbar-kill-{guid}.sock"
    let pidFile = $"{socketPath}.pid"
    let mutable engineProcess: Process option = None
    let mutable sessionDir: string = ""
    let mutable listener: Socket option = None
    let mutable client: HighBarClient option = None

    let testsDir =
        let assemblyDir = Path.GetDirectoryName(typeof<EngineKillFixture>.Assembly.Location)
        let testProjectDir = Path.GetFullPath(Path.Combine(assemblyDir, "..", "..", ".."))
        Path.GetFullPath(Path.Combine(testProjectDir, "..", ".."))

    let fixturesDir = Path.Combine(testsDir, "fixtures")
    let startScript = Path.Combine(fixturesDir, "start-headless.sh")
    let stopScript = Path.Combine(fixturesDir, "stop-headless.sh")
    let checkPrereqScript = Path.Combine(testsDir, "check-prerequisites.sh")

    let timeoutSeconds =
        match Environment.GetEnvironmentVariable("HIGHBAR_TEST_TIMEOUT") with
        | null | "" -> 30
        | v -> Int32.Parse(v)

    /// Resolve the engine binary path for environment setup.
    /// start-headless.sh needs HIGHBAR_TEST_ENGINE to correctly auto-detect SPRING_DATADIR.
    let resolveEnginePath () =
        match Environment.GetEnvironmentVariable("HIGHBAR_TEST_ENGINE") with
        | null | "" ->
            // Search standard BAR AppImage locations
            let pattern = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "state", "Beyond All Reason", "engine", "*", "spring-headless")
            let candidates = Directory.GetFiles(Path.GetDirectoryName(Path.GetDirectoryName(pattern)), "spring-headless", SearchOption.AllDirectories)
            candidates |> Array.tryHead
        | v -> Some v

    member _.Client = client |> Option.defaultWith (fun () -> failwith "Client not initialized")
    member _.SocketPath = socketPath

    member _.IsEngineAlive =
        match engineProcess with
        | Some p -> not p.HasExited
        | None -> false

    /// Kill the engine process with SIGKILL.
    member _.KillEngine() =
        match engineProcess with
        | Some p when not p.HasExited ->
            p.Kill(true)  // entireProcessTree = true
        | _ -> failwith "Engine process is not running"

    interface IAsyncLifetime with
        member _.InitializeAsync() = task {
            sessionDir <- Path.Combine(Path.GetTempPath(), $"highbar-kill-{guid}")
            Directory.CreateDirectory(sessionDir) |> ignore

            // Check prerequisites
            let psi = ProcessStartInfo()
            psi.FileName <- "/usr/bin/env"
            psi.ArgumentList.Add("bash")
            psi.ArgumentList.Add(checkPrereqScript)
            psi.ArgumentList.Add("--json")
            psi.UseShellExecute <- false
            psi.RedirectStandardOutput <- true
            psi.RedirectStandardError <- true
            let proc = Process.Start(psi)
            let stdout = proc.StandardOutput.ReadToEnd()
            let stderr = proc.StandardError.ReadToEnd()
            proc.WaitForExit()
            if proc.ExitCode = 2 then
                failwith $"Prerequisites check error: {stderr}{stdout}"
            elif proc.ExitCode <> 0 then
                failwith $"Prerequisites not met — skipping engine-kill tests.\n{stdout}"

            if File.Exists(socketPath) then
                File.Delete(socketPath)

            let listenSock = new Socket(AddressFamily.Unix, SocketType.Stream, ProtocolType.Unspecified)
            let endpoint = UnixDomainSocketEndPoint(socketPath)
            listenSock.Bind(endpoint)
            listenSock.Listen(1)
            listener <- Some listenSock

            // Start engine
            let startPsi = ProcessStartInfo()
            startPsi.FileName <- "/usr/bin/env"
            startPsi.ArgumentList.Add("bash")
            startPsi.ArgumentList.Add(startScript)
            startPsi.ArgumentList.Add(socketPath)
            startPsi.ArgumentList.Add(pidFile)
            startPsi.ArgumentList.Add(sessionDir)
            startPsi.UseShellExecute <- false
            startPsi.RedirectStandardOutput <- true
            startPsi.RedirectStandardError <- true
            startPsi.Environment.["HIGHBAR_SOCKET_PATH"] <- socketPath
            match resolveEnginePath() with
            | Some enginePath -> startPsi.Environment.["HIGHBAR_TEST_ENGINE"] <- enginePath
            | None -> ()

            let startProc = Process.Start(startPsi)
            startProc.WaitForExit()
            if startProc.ExitCode <> 0 then
                let stderrOut = startProc.StandardError.ReadToEnd()
                listenSock.Close()
                failwith $"start-headless.sh failed (exit {startProc.ExitCode}): {stderrOut}"

            if File.Exists(pidFile) then
                let pid = File.ReadAllText(pidFile).Trim() |> Int32.Parse
                try
                    engineProcess <- Some(Process.GetProcessById(pid))
                with
                | :? ArgumentException ->
                    listenSock.Close()
                    failwith $"Engine process {pid} not found after start"

            let timeoutUs = timeoutSeconds * 1_000_000
            if not (listenSock.Poll(timeoutUs, SelectMode.SelectRead)) then
                listenSock.Close()
                failwith $"Proxy did not connect within {timeoutSeconds}s at {socketPath}"

            let c = new HighBarClient(socketPath)
            c.AcceptFrom(listenSock)
            listenSock.Close()
            listener <- None

            c.Handshake() |> ignore

            // Warm-up: run a few frames to ensure stable connection
            let mutable warmup = 0
            try
                c.Run(fun _ ->
                    warmup <- warmup + 1
                    if warmup >= 10 then failwith "CAPTURED_ENOUGH"
                    []
                )
            with
            | ex when ex.Message = "CAPTURED_ENOUGH" -> ()

            client <- Some c
        }

        member this.DisposeAsync() =
            client |> Option.iter (fun c -> try c.Disconnect() with _ -> ())
            client <- None

            listener |> Option.iter (fun l -> try l.Close() with _ -> ())
            listener <- None

            // Try graceful stop first
            let psi = ProcessStartInfo()
            psi.FileName <- "/usr/bin/env"
            psi.ArgumentList.Add("bash")
            psi.ArgumentList.Add(stopScript)
            psi.ArgumentList.Add(socketPath)
            psi.ArgumentList.Add(pidFile)
            psi.UseShellExecute <- false
            psi.RedirectStandardOutput <- true
            psi.RedirectStandardError <- true
            let proc = Process.Start(psi)
            proc.WaitForExit(10_000) |> ignore

            engineProcess |> Option.iter (fun p ->
                if not p.HasExited then
                    try p.Kill() with _ -> ()
            )
            engineProcess <- None

            if File.Exists(socketPath) then File.Delete(socketPath)
            if File.Exists(pidFile) then File.Delete(pidFile)

            let keepLogs = Environment.GetEnvironmentVariable("HIGHBAR_KEEP_LOGS")
            if String.IsNullOrEmpty(keepLogs) then
                if not (String.IsNullOrEmpty(sessionDir)) && Directory.Exists(sessionDir) then
                    try Directory.Delete(sessionDir, true) with _ -> ()

            Task.CompletedTask


/// xUnit collection definition for engine-kill tests (separate from PersistentEngine).
[<CollectionDefinition("EngineKill")>]
type EngineKillCollection() =
    interface ICollectionFixture<EngineKillFixture>


/// Tier 10: Engine-kill verification tests.
/// Verifies that the 023 socket disconnect fix works against a real engine kill.
/// Uses its own engine instance (separate fixture) to avoid breaking other tests.
[<Collection("EngineKill")>]
type T10_EngineKillTests(fixture: EngineKillFixture, output: ITestOutputHelper) =

    [<Fact>]
    member _.``T10.1 Kill engine during frame loop — EngineDisconnectedException within 10s``() =
        let sw = Stopwatch.StartNew()
        let mutable framesRun = 0
        let mutable caughtEx: exn option = None

        try
            fixture.Client.Run(fun _ ->
                framesRun <- framesRun + 1
                if framesRun = 5 then
                    output.WriteLine("Killing engine after 5 frames...")
                    fixture.KillEngine()
                []
            )
        with ex ->
            caughtEx <- Some ex

        sw.Stop()

        Assert.True(caughtEx.IsSome, "Expected an exception after killing the engine, but Run completed normally")
        let ex = caughtEx.Value
        output.WriteLine($"Exception after {sw.Elapsed.TotalSeconds:F1}s, {framesRun} frames: {ex.GetType().Name}: {ex.Message}")

        // The exception should be EngineDisconnectedException (or wrap one)
        let isDisconnect =
            ex :? EngineDisconnectedException ||
            (ex.InnerException <> null && ex.InnerException :? EngineDisconnectedException)
        Assert.True(isDisconnect, $"Expected EngineDisconnectedException, got {ex.GetType().Name}: {ex.Message}")
        Assert.True(sw.Elapsed.TotalSeconds < 10.0, $"Detection took {sw.Elapsed.TotalSeconds:F1}s, expected < 10s")

    [<Fact>]
    member _.``T10.2 After engine kill — subsequent Run fails immediately``() =
        // First, kill the engine if still alive
        if fixture.IsEngineAlive then
            let mutable framesRun = 0
            try
                fixture.Client.Run(fun _ ->
                    framesRun <- framesRun + 1
                    if framesRun = 3 then fixture.KillEngine()
                    []
                )
            with _ -> ()

        // Now verify that a subsequent Run fails immediately
        let sw = Stopwatch.StartNew()
        let mutable caughtEx: exn option = None
        try
            fixture.Client.Run(fun _ -> [])
        with ex ->
            caughtEx <- Some ex
        sw.Stop()

        Assert.True(caughtEx.IsSome, "Expected an exception on dead connection, but Run completed normally")
        let ex = caughtEx.Value
        output.WriteLine($"Immediate failure after {sw.Elapsed.TotalSeconds:F1}s: {ex.GetType().Name}: {ex.Message}")
        Assert.True(sw.Elapsed.TotalSeconds < 2.0, $"Subsequent Run took {sw.Elapsed.TotalSeconds:F1}s, expected < 2s (immediate failure)")

    [<Fact>]
    member _.``T10.3 Custom timeout — detection within configured timeout + margin``() =
        // This test uses HIGHBAR_CLIENT_TIMEOUT_MS=2000 (set via environment).
        // If not set, we test with the default timeout and just verify detection happens.
        let timeoutMs =
            match Environment.GetEnvironmentVariable("HIGHBAR_CLIENT_TIMEOUT_MS") with
            | null | "" ->
                output.WriteLine("HIGHBAR_CLIENT_TIMEOUT_MS not set — using default timeout, verifying detection occurs")
                10000
            | v ->
                let t = Int32.Parse(v)
                output.WriteLine($"HIGHBAR_CLIENT_TIMEOUT_MS={t}ms")
                t

        if not fixture.IsEngineAlive then
            output.WriteLine("Engine already dead from prior test — verifying immediate failure")
            let sw = Stopwatch.StartNew()
            let mutable caughtEx: exn option = None
            try
                fixture.Client.Run(fun _ -> [])
            with ex ->
                caughtEx <- Some ex
            sw.Stop()
            Assert.True(caughtEx.IsSome, "Expected an exception on dead connection")
            output.WriteLine($"Failed in {sw.Elapsed.TotalSeconds:F1}s")
            Assert.True(sw.Elapsed.TotalSeconds < 2.0, "Should fail immediately when engine already dead")
        else
            let sw = Stopwatch.StartNew()
            let mutable framesRun = 0
            let mutable caughtEx: exn option = None
            try
                fixture.Client.Run(fun _ ->
                    framesRun <- framesRun + 1
                    if framesRun = 3 then
                        output.WriteLine("Killing engine for timeout test...")
                        fixture.KillEngine()
                    []
                )
            with ex ->
                caughtEx <- Some ex
            sw.Stop()

            Assert.True(caughtEx.IsSome, "Expected an exception after killing the engine")
            let maxSeconds = float timeoutMs / 1000.0 + 3.0 // timeout + 3s margin
            output.WriteLine($"Detection in {sw.Elapsed.TotalSeconds:F1}s (max allowed: {maxSeconds:F1}s): {caughtEx.Value.GetType().Name}")
            Assert.True(sw.Elapsed.TotalSeconds < maxSeconds, $"Detection took {sw.Elapsed.TotalSeconds:F1}s, expected < {maxSeconds:F1}s")
