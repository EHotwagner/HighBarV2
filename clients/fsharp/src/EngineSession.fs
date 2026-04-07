namespace HighBar.Client

open System
open System.Diagnostics
open System.IO
open System.Net.Sockets
open Highbar

/// Lifecycle state of an engine session.
type SessionState =
    | Idle
    | Starting
    | Connected
    | Running
    | Stopped
    | Error of string

/// Unified engine lifecycle abstraction. Encapsulates engine process spawning,
/// socket creation, proxy connection acceptance, handshake, frame stepping,
/// and graceful shutdown.
type EngineSession(config: EngineConfig) =

    let mutable state = Idle
    let mutable engineProcess: Process option = None
    let mutable listenerSocket: Socket option = None
    let mutable client: HighBarClient option = None
    let mutable lastFrameNumber: uint32 = 0u
    let sessionDir = EngineLauncher.getSessionDir config
    let pidFile = $"{config.SocketPath}.pid"

    /// Current session state.
    member _.State = state

    /// The engine configuration.
    member _.Config = config

    /// The session directory containing engine logs.
    member _.SessionDir = sessionDir

    /// The PID file path.
    member _.PidFile = pidFile

    /// The underlying HighBarClient (for direct access to callbacks, etc.).
    member _.Client =
        client |> Option.defaultWith (fun () -> failwith "Client not initialized — call Start() first")

    /// Last successfully received frame number.
    member _.LastFrameNumber = lastFrameNumber

    /// Whether the engine process is still alive.
    member _.IsEngineAlive =
        match engineProcess with
        | Some p -> not p.HasExited
        | None -> false

    /// Collect diagnostics from the current session.
    member _.GetDiagnostics() : SessionDiagnostics =
        SessionDiagnostics.collect sessionDir config.SocketPath lastFrameNumber engineProcess

    /// Throw EngineDisconnectedException if the engine has crashed.
    member this.ThrowIfEngineCrashed() =
        if not this.IsEngineAlive then
            let diag = this.GetDiagnostics()
            raise (EngineDisconnectedException(
                $"Engine process has exited unexpectedly.\n{SessionDiagnostics.formatReport diag}",
                lastFrameNumber = lastFrameNumber))

    /// Start the engine session: create listener socket, launch engine, accept proxy connection, handshake.
    member this.Start() =
        match state with
        | Idle | Stopped -> ()
        | _ -> failwith $"Cannot start session in state {state}"

        state <- Starting
        try
            // Clean up stale socket
            if File.Exists(config.SocketPath) then
                File.Delete(config.SocketPath)

            // Create listening socket
            let listenSock = new Socket(AddressFamily.Unix, SocketType.Stream, ProtocolType.Unspecified)
            let endpoint = UnixDomainSocketEndPoint(config.SocketPath)
            listenSock.Bind(endpoint)
            listenSock.Listen(1)
            listenerSocket <- Some listenSock

            // Generate and launch engine
            let scriptContent = ScriptGenerator.generate config
            let proc = EngineLauncher.launch config scriptContent
            engineProcess <- Some proc

            // Wait for proxy to connect
            let timeoutUs = config.AcceptTimeoutMs * 1000
            if not (listenSock.Poll(timeoutUs, SelectMode.SelectRead)) then
                listenSock.Close()
                listenerSocket <- None
                let diag = this.GetDiagnostics()
                state <- Error "Proxy connection timeout"
                raise (EngineDisconnectedException(
                    $"Proxy did not connect within {config.AcceptTimeoutMs}ms at {config.SocketPath}\n{SessionDiagnostics.formatReport diag}",
                    lastFrameNumber = 0u))

            // Accept connection and handshake
            let c = new HighBarClient(config.SocketPath, readTimeoutMs = config.ReadTimeoutMs)
            c.AcceptFrom(listenSock)
            listenSock.Close()
            listenerSocket <- None
            c.Handshake() |> ignore
            client <- Some c
            state <- Connected

        with ex ->
            match state with
            | Error _ -> ()
            | _ -> state <- Error ex.Message
            this.CleanupResources(false)
            reraise()

    /// Receive one frame passively (no commands sent).
    member this.Step() : GameFrame =
        this.StepWith(fun _ -> [])

    /// Receive one frame and send commands returned by the handler.
    member this.StepWith(handler: GameFrame -> AICommand list) : GameFrame =
        match state with
        | Connected | Running -> ()
        | _ -> failwith $"Cannot step in state {state}"

        state <- Running
        let c = this.Client

        try
            let result = c.StepFrame(fun frame ->
                lastFrameNumber <- frame.FrameNumber
                handler frame)

            match result with
            | Some frame ->
                state <- Connected
                frame
            | None ->
                state <- Stopped
                failwith "Game ended (shutdown received)"
        with
        | :? EngineDisconnectedException as ex ->
            state <- Error ex.Message
            let diag = this.GetDiagnostics()
            raise (EngineDisconnectedException(
                $"Engine disconnected at frame {lastFrameNumber}: {ex.Message}\n{SessionDiagnostics.formatReport diag}",
                lastFrameNumber = lastFrameNumber,
                innerException = ex))
        | :? IOException as ex ->
            state <- Error ex.Message
            let diag = this.GetDiagnostics()
            raise (EngineDisconnectedException(
                $"I/O error at frame {lastFrameNumber}: {ex.Message}\n{SessionDiagnostics.formatReport diag}",
                lastFrameNumber = lastFrameNumber,
                innerException = ex))

    /// Run N frames, calling handler for each. Returns all frames collected.
    member this.Run(count: int, handler: GameFrame -> AICommand list) : GameFrame list =
        let frames = ResizeArray<GameFrame>()
        for _ in 1..count do
            let frame = this.StepWith(handler)
            frames.Add(frame)
        frames |> Seq.toList

    /// Run frames until predicate returns true, calling handler for each.
    member this.RunUntil(predicate: GameFrame -> bool, handler: GameFrame -> AICommand list) : GameFrame list =
        let frames = ResizeArray<GameFrame>()
        let mutable stop = false
        while not stop do
            let frame = this.StepWith(handler)
            frames.Add(frame)
            if predicate frame then stop <- true
        frames |> Seq.toList

    /// Stop the session. Safe to call from any state.
    /// If preserveSession is true, the session directory is kept for post-mortem analysis.
    member this.Stop(preserveSession: bool) =
        this.CleanupResources(preserveSession)
        state <- Stopped

    /// Internal cleanup of all resources.
    member private _.CleanupResources(preserveSession: bool) =
        // Disconnect client
        client |> Option.iter (fun c -> try c.Disconnect() with _ -> ())
        client <- None

        // Close listener socket
        listenerSocket |> Option.iter (fun l -> try l.Close() with _ -> ())
        listenerSocket <- None

        // Stop engine process
        engineProcess |> Option.iter (fun p ->
            EngineLauncher.stop config.SocketPath p config.ShutdownGraceMs)
        engineProcess <- None

        // Clean up session directory
        if not preserveSession then
            if Directory.Exists(sessionDir) then
                try Directory.Delete(sessionDir, true) with _ -> ()

    interface IDisposable with
        member this.Dispose() = this.Stop(false)
