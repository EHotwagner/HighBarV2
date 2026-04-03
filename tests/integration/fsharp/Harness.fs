namespace HighBar.Tests

open System
open System.Diagnostics
open System.IO
open System.Net.Sockets
open System.Threading
open System.Threading.Tasks
open Xunit
open HighBar.Client

/// Manages the lifecycle of a headless BAR engine instance for integration tests.
/// Creates a listening socket, starts the engine (proxy connects to us),
/// accepts the connection, and provides a shared HighBarClient.
type EngineFixture() =
    let guid = Guid.NewGuid().ToString("N")[..7]
    let socketPath = $"/tmp/highbar-test-{guid}.sock"
    let pidFile = $"{socketPath}.pid"
    let mutable engineProcess: Process option = None
    let mutable sessionDir: string = ""
    let mutable listener: Socket option = None
    let mutable client: HighBarClient option = None
    let mutable initialFrames: GameFrame list = []
    let mutable initialEvents: GameEvent list = []

    let testsDir =
        let assemblyDir = Path.GetDirectoryName(typeof<EngineFixture>.Assembly.Location)
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

    let checkPrerequisites () =
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
            failwith $"Prerequisites check script error: {stderr}{stdout}"
        elif proc.ExitCode <> 0 then
            failwith $"Prerequisites not met — skipping live engine tests.\n{stdout}"

    /// The socket path for this engine instance.
    member _.SocketPath = socketPath

    /// The shared client connected to the proxy. Use this in tests.
    member _.Client = client |> Option.defaultWith (fun () -> failwith "Client not initialized")

    /// Frames captured during initial warm-up (first ~30 frames after handshake).
    /// Contains one-time events like Init and UnitCreated that won't appear again.
    member _.InitialFrames = initialFrames

    /// All events from the initial warm-up frames (Init, UnitCreated, etc.).
    member _.InitialEvents = initialEvents

    /// The session directory containing engine logs.
    member _.SessionDir = sessionDir

    /// Check if the engine process is still alive.
    member _.IsEngineAlive =
        match engineProcess with
        | Some p -> not p.HasExited
        | None -> false

    member this.ThrowIfEngineCrashed() =
        if not this.IsEngineAlive then
            let mutable diagInfo = $"Engine process has exited unexpectedly.\nSocket: {socketPath}\n"
            match engineProcess with
            | Some p -> diagInfo <- diagInfo + $"PID: {p.Id}, Exit code: {p.ExitCode}\n"
            | None -> ()

            if not (String.IsNullOrEmpty(sessionDir)) then
                for logFile in ["engine-stderr.log"; "infolog.txt"] do
                    let path = Path.Combine(sessionDir, logFile)
                    if File.Exists(path) then
                        let lines = File.ReadAllLines(path)
                        let tail = lines |> Array.skip (max 0 (lines.Length - 50))
                        diagInfo <- diagInfo + $"\n--- {logFile} (last {tail.Length} lines) ---\n"
                        diagInfo <- diagInfo + (String.Join("\n", tail)) + "\n"

            failwith diagInfo

    member _.GetDiagnosticLogs() =
        if String.IsNullOrEmpty(sessionDir) then
            "No session directory available."
        else
            let mutable output = $"Session directory: {sessionDir}\nSocket: {socketPath}\n"
            match engineProcess with
            | Some p -> output <- output + $"Engine PID: {p.Id}\n"
            | None -> ()

            for logFile in ["engine-stdout.log"; "engine-stderr.log"; "infolog.txt"] do
                let path = Path.Combine(sessionDir, logFile)
                if File.Exists(path) then
                    let lines = File.ReadAllLines(path)
                    let tail = lines |> Array.skip (max 0 (lines.Length - 50))
                    output <- output + $"\n--- {logFile} (last {tail.Length} lines) ---\n"
                    output <- output + (String.Join("\n", tail)) + "\n"

            output

    interface IAsyncLifetime with
        member _.InitializeAsync() = task {
            sessionDir <- Path.Combine(Path.GetTempPath(), $"highbar-test-{guid}")
            Directory.CreateDirectory(sessionDir) |> ignore

            checkPrerequisites()

            // Clean up stale socket
            if File.Exists(socketPath) then
                File.Delete(socketPath)

            // Step 1: Create a listening socket BEFORE starting the engine.
            // The proxy plugin will connect() to this socket during its init().
            let listenSock = new Socket(AddressFamily.Unix, SocketType.Stream, ProtocolType.Unspecified)
            let endpoint = UnixDomainSocketEndPoint(socketPath)
            listenSock.Bind(endpoint)
            listenSock.Listen(1)
            listener <- Some listenSock

            // Step 2: Launch the engine (background process)
            let psi = ProcessStartInfo()
            psi.FileName <- "/usr/bin/env"
            psi.ArgumentList.Add("bash")
            psi.ArgumentList.Add(startScript)
            psi.ArgumentList.Add(socketPath)
            psi.ArgumentList.Add(pidFile)
            psi.ArgumentList.Add(sessionDir)
            psi.UseShellExecute <- false
            psi.RedirectStandardOutput <- true
            psi.RedirectStandardError <- true
            psi.Environment.["HIGHBAR_SOCKET_PATH"] <- socketPath

            let proc = Process.Start(psi)
            proc.WaitForExit()

            if proc.ExitCode <> 0 then
                let stderr = proc.StandardError.ReadToEnd()
                listenSock.Close()
                failwith $"start-headless.sh failed (exit {proc.ExitCode}): {stderr}"

            // Read PID from file
            if File.Exists(pidFile) then
                let pid = File.ReadAllText(pidFile).Trim() |> Int32.Parse
                try
                    engineProcess <- Some(Process.GetProcessById(pid))
                with
                | :? ArgumentException ->
                    listenSock.Close()
                    failwith $"Engine process {pid} not found after start"

            // Step 3: Wait for proxy to connect (with timeout)
            let timeoutUs = timeoutSeconds * 1_000_000
            if not (listenSock.Poll(timeoutUs, SelectMode.SelectRead)) then
                listenSock.Close()
                failwith $"Proxy did not connect within {timeoutSeconds}s at {socketPath}"

            // Step 4: Accept the proxy connection and create the client
            let c = new HighBarClient(socketPath)
            c.AcceptFrom(listenSock)
            listenSock.Close()
            listener <- None

            // Step 5: Handshake
            c.Handshake() |> ignore

            // Step 6: Warm-up — capture initial frames to buffer one-time events
            // (Init, UnitCreated, etc.) that all tests may need to reference.
            let warmupFrames = ResizeArray<GameFrame>()
            try
                c.Run(fun frame ->
                    warmupFrames.Add(frame)
                    if warmupFrames.Count >= 30 then
                        failwith "CAPTURED_ENOUGH"
                    []
                )
            with
            | ex when ex.Message = "CAPTURED_ENOUGH" -> ()

            initialFrames <- warmupFrames |> Seq.toList
            initialEvents <- initialFrames |> List.collect (fun f -> f.Events)
            client <- Some c
        }

        member this.DisposeAsync() =
            // Disconnect client
            client |> Option.iter (fun c -> c.Disconnect())
            client <- None

            // Close listener if still open
            listener |> Option.iter (fun l -> try l.Close() with _ -> ())
            listener <- None

            // Shut down the engine
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

            if not (String.IsNullOrEmpty(sessionDir)) && Directory.Exists(sessionDir) then
                try Directory.Delete(sessionDir, true) with _ -> ()

            Task.CompletedTask


/// xUnit collection definition that serializes all engine-dependent tests
/// against a single shared EngineFixture instance.
[<CollectionDefinition("Engine")>]
type EngineCollection() =
    interface ICollectionFixture<EngineFixture>
