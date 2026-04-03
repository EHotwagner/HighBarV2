namespace HighBar.Tests

open System
open System.Diagnostics
open System.IO
open System.Net.Sockets
open System.Threading
open System.Threading.Tasks
open Xunit

/// Manages the lifecycle of a headless BAR engine instance for integration tests.
/// Implements IAsyncLifetime so xUnit starts/stops the engine around the test collection.
type EngineFixture() =
    let guid = Guid.NewGuid().ToString("N")[..7]
    let socketPath = $"/tmp/highbar-test-{guid}.sock"
    let pidFile = $"{socketPath}.pid"
    let mutable engineProcess: Process option = None
    let mutable sessionDir: string = ""

    let testsDir =
        let assemblyDir = Path.GetDirectoryName(typeof<EngineFixture>.Assembly.Location)
        // Walk up from bin/Debug/net8.0 to tests/integration/fsharp, then to tests/
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

    /// Run prerequisites check and fail with descriptive message if missing.
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

    /// Poll for socket file existence, then verify it accepts a connection.
    let waitForSocket () = task {
        let deadline = DateTime.UtcNow.AddSeconds(float timeoutSeconds)
        let mutable ready = false

        while not ready && DateTime.UtcNow < deadline do
            if File.Exists(socketPath) then
                try
                    use testSock = new Socket(AddressFamily.Unix, SocketType.Stream, ProtocolType.Unspecified)
                    let endpoint = UnixDomainSocketEndPoint(socketPath)
                    testSock.Connect(endpoint)
                    testSock.Close()
                    ready <- true
                with
                | :? SocketException ->
                    do! Task.Delay(250)
            else
                do! Task.Delay(250)

        if not ready then
            failwith $"Engine socket not ready after {timeoutSeconds}s at {socketPath}"
    }

    /// The socket path for this engine instance.
    member _.SocketPath = socketPath

    /// The session directory containing engine logs.
    member _.SessionDir = sessionDir

    /// Check if the engine process is still alive.
    member _.IsEngineAlive =
        match engineProcess with
        | Some p -> not p.HasExited
        | None -> false

    /// Throw with diagnostic info if the engine has crashed.
    member this.ThrowIfEngineCrashed() =
        if not this.IsEngineAlive then
            let mutable diagInfo = $"Engine process has exited unexpectedly.\nSocket: {socketPath}\n"
            match engineProcess with
            | Some p -> diagInfo <- diagInfo + $"PID: {p.Id}, Exit code: {p.ExitCode}\n"
            | None -> ()

            if not (String.IsNullOrEmpty(sessionDir)) then
                let stderrLog = Path.Combine(sessionDir, "engine-stderr.log")
                let infolog = Path.Combine(sessionDir, "infolog.txt")

                if File.Exists(stderrLog) then
                    let lines = File.ReadAllLines(stderrLog)
                    let tail = lines |> Array.skip (max 0 (lines.Length - 50))
                    diagInfo <- diagInfo + $"\n--- engine-stderr.log (last {tail.Length} lines) ---\n"
                    diagInfo <- diagInfo + (String.Join("\n", tail)) + "\n"

                if File.Exists(infolog) then
                    let lines = File.ReadAllLines(infolog)
                    let tail = lines |> Array.skip (max 0 (lines.Length - 50))
                    diagInfo <- diagInfo + $"\n--- infolog.txt (last {tail.Length} lines) ---\n"
                    diagInfo <- diagInfo + (String.Join("\n", tail)) + "\n"

            failwith diagInfo

    /// Read diagnostic logs from the session directory.
    member _.GetDiagnosticLogs() =
        if String.IsNullOrEmpty(sessionDir) then
            "No session directory available."
        else
            let mutable output = $"Session directory: {sessionDir}\nSocket: {socketPath}\n"
            match engineProcess with
            | Some p -> output <- output + $"Engine PID: {p.Id}\n"
            | None -> ()

            let logFiles = [
                "engine-stdout.log"
                "engine-stderr.log"
                "infolog.txt"
            ]
            for logFile in logFiles do
                let path = Path.Combine(sessionDir, logFile)
                if File.Exists(path) then
                    let lines = File.ReadAllLines(path)
                    let tail = lines |> Array.skip (max 0 (lines.Length - 50))
                    output <- output + $"\n--- {logFile} (last {tail.Length} lines) ---\n"
                    output <- output + (String.Join("\n", tail)) + "\n"

            output

    interface IAsyncLifetime with
        member _.InitializeAsync() = task {
            // Create per-session temp directory
            sessionDir <- Path.Combine(Path.GetTempPath(), $"highbar-test-{guid}")
            Directory.CreateDirectory(sessionDir) |> ignore

            // Check prerequisites before launching engine
            checkPrerequisites()

            // Clean up stale socket if it exists
            if File.Exists(socketPath) then
                File.Delete(socketPath)

            // Launch the engine via start-headless.sh with session directory
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
                failwith $"start-headless.sh failed (exit {proc.ExitCode}): {stderr}"

            // Read PID from file to track the engine process
            if File.Exists(pidFile) then
                let pid = File.ReadAllText(pidFile).Trim() |> Int32.Parse
                try
                    engineProcess <- Some(Process.GetProcessById(pid))
                with
                | :? ArgumentException ->
                    failwith $"Engine process {pid} not found after start"

            // Wait for socket to become available
            do! waitForSocket()
        }

        member this.DisposeAsync() =
            // Shut down the engine via stop-headless.sh
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

            // Verify cleanup
            engineProcess |> Option.iter (fun p ->
                if not p.HasExited then
                    try p.Kill() with _ -> ()
            )
            engineProcess <- None

            // Clean up any remaining files
            if File.Exists(socketPath) then File.Delete(socketPath)
            if File.Exists(pidFile) then File.Delete(pidFile)

            // Clean up session directory
            if not (String.IsNullOrEmpty(sessionDir)) && Directory.Exists(sessionDir) then
                try Directory.Delete(sessionDir, true) with _ -> ()

            Task.CompletedTask


/// xUnit collection definition that serializes all engine-dependent tests
/// against a single shared EngineFixture instance.
[<CollectionDefinition("Engine")>]
type EngineCollection() =
    interface ICollectionFixture<EngineFixture>
