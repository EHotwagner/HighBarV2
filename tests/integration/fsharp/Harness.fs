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

    let fixturesDir =
        let assemblyDir = Path.GetDirectoryName(typeof<EngineFixture>.Assembly.Location)
        // Walk up from bin/Debug/net8.0 to tests/integration/fsharp, then to tests/fixtures
        let testProjectDir = Path.GetFullPath(Path.Combine(assemblyDir, "..", "..", ".."))
        Path.GetFullPath(Path.Combine(testProjectDir, "..", "..", "fixtures"))

    let startScript = Path.Combine(fixturesDir, "start-headless.sh")
    let stopScript = Path.Combine(fixturesDir, "stop-headless.sh")

    let timeoutSeconds =
        match Environment.GetEnvironmentVariable("HIGHBAR_TEST_TIMEOUT") with
        | null | "" -> 30
        | v -> Int32.Parse(v)

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

    interface IAsyncLifetime with
        member _.InitializeAsync() = task {
            // Clean up stale socket if it exists
            if File.Exists(socketPath) then
                File.Delete(socketPath)

            // Launch the engine via start-headless.sh
            let psi = ProcessStartInfo()
            psi.FileName <- "/usr/bin/env"
            psi.ArgumentList.Add("bash")
            psi.ArgumentList.Add(startScript)
            psi.ArgumentList.Add(socketPath)
            psi.ArgumentList.Add(pidFile)
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

        member _.DisposeAsync() =
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

            Task.CompletedTask


/// xUnit collection definition that serializes all engine-dependent tests
/// against a single shared EngineFixture instance.
[<CollectionDefinition("Engine")>]
type EngineCollection() =
    interface ICollectionFixture<EngineFixture>
