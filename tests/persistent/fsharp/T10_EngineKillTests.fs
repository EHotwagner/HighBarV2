namespace HighBar.PersistentTests

open System
open System.Diagnostics
open System.IO
open System.Threading.Tasks
open Xunit
open Xunit.Abstractions
open HighBar.Client

/// Standalone fixture for engine-kill tests.
/// Starts its own engine instance (separate from PersistentEngineFixture)
/// so that killing the engine doesn't affect other tests.
type EngineKillFixture() =
    let mutable session: EngineSession option = None
    let mutable engineProcess: Process option = None

    let configPath =
        let assemblyDir = Path.GetDirectoryName(typeof<EngineKillFixture>.Assembly.Location)
        let testProjectDir = Path.GetFullPath(Path.Combine(assemblyDir, "..", "..", ".."))
        let testsDir = Path.GetFullPath(Path.Combine(testProjectDir, "..", ".."))
        Path.Combine(testsDir, "engine-version.json")

    let checkPrerequisites () =
        let testsDir =
            let assemblyDir = Path.GetDirectoryName(typeof<EngineKillFixture>.Assembly.Location)
            let testProjectDir = Path.GetFullPath(Path.Combine(assemblyDir, "..", "..", ".."))
            Path.GetFullPath(Path.Combine(testProjectDir, "..", ".."))
        let checkPrereqScript = Path.Combine(testsDir, "check-prerequisites.sh")
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

    member _.Client =
        match session with
        | Some s -> s.Client
        | None -> failwith "Client not initialized"

    member _.SocketPath =
        match session with
        | Some s -> s.Config.SocketPath
        | None -> ""

    member _.IsEngineAlive =
        match session with
        | Some s -> s.IsEngineAlive
        | None -> false

    /// Kill the engine process with SIGKILL.
    member _.KillEngine() =
        match engineProcess with
        | Some p when not p.HasExited ->
            p.Kill(true)  // entireProcessTree = true
        | _ -> failwith "Engine process is not running"

    interface IAsyncLifetime with
        member _.InitializeAsync() = task {
            checkPrerequisites()

            let config = EngineConfig.fromVersionFile configPath |> EngineConfig.validate
            let s = new EngineSession(config)
            s.Start()
            session <- Some s

            // Capture the engine process for kill testing
            // We need to get the PID from the PID file
            let pidFile = $"{config.SocketPath}.pid"
            if File.Exists(pidFile) then
                let pid = File.ReadAllText(pidFile).Trim() |> Int32.Parse
                try engineProcess <- Some(Process.GetProcessById(pid))
                with :? ArgumentException -> ()

            // Warm-up: run a few frames to ensure stable connection
            let mutable warmup = 0
            try
                s.Client.Run(fun _ ->
                    warmup <- warmup + 1
                    if warmup >= 10 then failwith "CAPTURED_ENOUGH"
                    []
                )
            with
            | ex when ex.Message = "CAPTURED_ENOUGH" -> ()
        }

        member _.DisposeAsync() =
            session |> Option.iter (fun s ->
                let keepLogs = Environment.GetEnvironmentVariable("HIGHBAR_KEEP_LOGS")
                let preserve = not (String.IsNullOrEmpty(keepLogs))
                s.Stop(preserve))
            session <- None
            engineProcess <- None
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
