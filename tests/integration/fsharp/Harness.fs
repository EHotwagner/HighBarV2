namespace HighBar.Tests

open System
open System.IO
open System.Threading.Tasks
open Xunit
open HighBar.Client

/// Manages the lifecycle of a headless BAR engine instance for integration tests.
/// Thin wrapper around EngineSession that handles warm-up frame capture.
type EngineFixture() =
    let mutable session: EngineSession option = None
    let mutable initialFrames: GameFrame list = []
    let mutable initialEvents: GameEvent list = []

    let configPath =
        let assemblyDir = Path.GetDirectoryName(typeof<EngineFixture>.Assembly.Location)
        let testProjectDir = Path.GetFullPath(Path.Combine(assemblyDir, "..", "..", ".."))
        let testsDir = Path.GetFullPath(Path.Combine(testProjectDir, "..", ".."))
        Path.Combine(testsDir, "engine-version.json")

    let checkPrerequisites () =
        let testsDir =
            let assemblyDir = Path.GetDirectoryName(typeof<EngineFixture>.Assembly.Location)
            let testProjectDir = Path.GetFullPath(Path.Combine(assemblyDir, "..", "..", ".."))
            Path.GetFullPath(Path.Combine(testProjectDir, "..", ".."))
        let checkPrereqScript = Path.Combine(testsDir, "check-prerequisites.sh")
        let psi = Diagnostics.ProcessStartInfo()
        psi.FileName <- "/usr/bin/env"
        psi.ArgumentList.Add("bash")
        psi.ArgumentList.Add(checkPrereqScript)
        psi.ArgumentList.Add("--json")
        psi.UseShellExecute <- false
        psi.RedirectStandardOutput <- true
        psi.RedirectStandardError <- true
        let proc = Diagnostics.Process.Start(psi)
        let stdout = proc.StandardOutput.ReadToEnd()
        let stderr = proc.StandardError.ReadToEnd()
        proc.WaitForExit()
        if proc.ExitCode = 2 then
            failwith $"Prerequisites check script error: {stderr}{stdout}"
        elif proc.ExitCode <> 0 then
            failwith $"Prerequisites not met — skipping live engine tests.\n{stdout}"

    /// The socket path for this engine instance.
    member _.SocketPath =
        match session with
        | Some s -> s.Config.SocketPath
        | None -> ""

    /// The shared client connected to the proxy. Use this in tests.
    member _.Client =
        match session with
        | Some s -> s.Client
        | None -> failwith "Client not initialized"

    /// Frames captured during initial warm-up (first ~30 frames after handshake).
    member _.InitialFrames = initialFrames

    /// All events from the initial warm-up frames (Init, UnitCreated, etc.).
    member _.InitialEvents = initialEvents

    /// The session directory containing engine logs.
    member _.SessionDir =
        match session with
        | Some s -> s.SessionDir
        | None -> ""

    /// Check if the engine process is still alive.
    member _.IsEngineAlive =
        match session with
        | Some s -> s.IsEngineAlive
        | None -> false

    member _.ThrowIfEngineCrashed() =
        match session with
        | Some s -> s.ThrowIfEngineCrashed()
        | None -> failwith "Session not initialized"

    member _.GetDiagnosticLogs() =
        match session with
        | Some s -> SessionDiagnostics.formatReport (s.GetDiagnostics())
        | None -> "No session available."

    interface IAsyncLifetime with
        member _.InitializeAsync() = task {
            EngineLauncher.cleanupStaleProcesses()
            checkPrerequisites()

            let config = EngineConfig.fromVersionFile configPath |> EngineConfig.validate
            let s = new EngineSession(config)
            s.Start()
            session <- Some s

            // Warm-up: capture initial 30 frames
            let warmupFrames = s.Run(30, fun _ -> [])
            initialFrames <- warmupFrames
            initialEvents <- warmupFrames |> List.collect (fun f -> f.Events)
        }

        member _.DisposeAsync() =
            session |> Option.iter (fun s ->
                let keepLogs = Environment.GetEnvironmentVariable("HIGHBAR_KEEP_LOGS")
                let preserve = not (String.IsNullOrEmpty(keepLogs))
                s.Stop(preserve))
            session <- None
            Task.CompletedTask


/// xUnit collection definition that serializes all engine-dependent tests
/// against a single shared EngineFixture instance.
[<CollectionDefinition("Engine")>]
type EngineCollection() =
    interface ICollectionFixture<EngineFixture>
