namespace HighBar.PersistentTests

open System
open System.Diagnostics
open System.IO
open System.Net.Sockets
open System.Threading.Tasks
open Xunit
open HighBar.Client
open HighBar.Client.Commands

/// Persistent engine fixture that starts the engine once and resets state between tests.
/// Uses cheat commands (SendTextMessageCommand ".destroy", GiveMeResourceCommand) to
/// reset game state without restarting the engine process.
type PersistentEngineFixture() =
    let guid = Guid.NewGuid().ToString("N")[..7]
    let socketPath = $"/tmp/highbar-persistent-{guid}.sock"
    let pidFile = $"{socketPath}.pid"
    let mutable engineProcess: Process option = None
    let mutable sessionDir: string = ""
    let mutable listener: Socket option = None
    let mutable client: HighBarClient option = None
    let mutable initialFrames: GameFrame list = []
    let mutable initialEvents: GameEvent list = []
    let mutable initElapsed: TimeSpan = TimeSpan.Zero

    // Track all unit IDs we know about from events
    let knownUnitIds = System.Collections.Generic.HashSet<int>()
    // Track the initial commander unit IDs (from warm-up) so we know baseline
    let initialUnitIds = System.Collections.Generic.HashSet<int>()

    let testsDir =
        let assemblyDir = Path.GetDirectoryName(typeof<PersistentEngineFixture>.Assembly.Location)
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

    /// The shared client connected to the proxy.
    member _.Client = client |> Option.defaultWith (fun () -> failwith "Client not initialized")

    /// Frames captured during initial warm-up.
    member _.InitialFrames = initialFrames

    /// All events from the initial warm-up frames.
    member _.InitialEvents = initialEvents

    /// The session directory containing engine logs.
    member _.SessionDir = sessionDir

    /// How long InitializeAsync took.
    member _.InitElapsed = initElapsed

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

    /// Run N frames, collecting all events and optionally sending commands.
    /// Returns (frames, allEvents).
    member _.RunFrames(n: int, ?onFrame: GameFrame -> int -> Highbar.AICommand list) =
        let c = client |> Option.defaultWith (fun () -> failwith "Client not initialized")
        let allFrames = ResizeArray<GameFrame>()
        let allEvents = ResizeArray<GameEvent>()
        let mutable frameIdx = 0
        let handler = defaultArg onFrame (fun _ _ -> [])

        try
            c.Run(fun frame ->
                allFrames.Add(frame)
                allEvents.AddRange(frame.Events)

                // Track unit IDs from events
                for ev in frame.Events do
                    match ev with
                    | GameEvent.UnitCreated(uid, _) -> knownUnitIds.Add(uid) |> ignore
                    | GameEvent.UnitDestroyed(uid, _) -> knownUnitIds.Remove(uid) |> ignore
                    | _ -> ()

                let cmds = handler frame frameIdx
                frameIdx <- frameIdx + 1
                if frameIdx >= n then
                    failwith "CAPTURED_ENOUGH"
                cmds
            )
        with
        | ex when ex.Message = "CAPTURED_ENOUGH" -> ()

        (allFrames |> Seq.toList, allEvents |> Seq.toList)

    /// Reset game state between tests:
    /// 1. Send destroy text commands for instant unit removal (cheats enabled)
    /// 2. Reset resources via GiveMeResourceCommand
    /// 3. Run verification frames
    member this.ResetGameState() =
        this.ThrowIfEngineCrashed()

        // Phase 1: Destroy all non-initial units via text commands + reset resources
        let unitsToDestroy =
            knownUnitIds
            |> Seq.filter (fun uid -> not (initialUnitIds.Contains(uid)))
            |> Seq.toList

        let mutable sent = false
        try
            let c = client |> Option.defaultWith (fun () -> failwith "Client not initialized")
            c.Run(fun frame ->
                for ev in frame.Events do
                    match ev with
                    | GameEvent.UnitDestroyed(uid, _) -> knownUnitIds.Remove(uid) |> ignore
                    | GameEvent.UnitCreated(uid, _) -> knownUnitIds.Add(uid) |> ignore
                    | _ -> ()

                if not sent then
                    sent <- true
                    // Use SendTextMessageCommand to instantly destroy units via engine cheat
                    let destroyCmds =
                        unitsToDestroy
                        |> List.map (fun uid -> SendTextMessageCommand $".destroy {uid}" 0)
                    let resourceCmds = [
                        GiveMeResourceCommand 0 -1000000.0f
                        GiveMeResourceCommand 1 -1000000.0f
                        GiveMeResourceCommand 0 1000.0f
                        GiveMeResourceCommand 1 1000.0f
                    ]
                    destroyCmds @ resourceCmds
                else
                    failwith "CAPTURED_ENOUGH"
                    []
            )
        with
        | ex when ex.Message = "CAPTURED_ENOUGH" -> ()

        // Phase 2: Run verification frames to let engine process commands
        this.RunFrames(10) |> ignore

    interface IAsyncLifetime with
        member _.InitializeAsync() = task {
            let sw = Stopwatch.StartNew()
            sessionDir <- Path.Combine(Path.GetTempPath(), $"highbar-persistent-{guid}")
            Directory.CreateDirectory(sessionDir) |> ignore

            checkPrerequisites()

            if File.Exists(socketPath) then
                File.Delete(socketPath)

            let listenSock = new Socket(AddressFamily.Unix, SocketType.Stream, ProtocolType.Unspecified)
            let endpoint = UnixDomainSocketEndPoint(socketPath)
            listenSock.Bind(endpoint)
            listenSock.Listen(1)
            listener <- Some listenSock

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

            // Warm-up: capture initial frames
            let warmupFrames = ResizeArray<GameFrame>()
            try
                c.Run(fun frame ->
                    warmupFrames.Add(frame)
                    // Track initial unit IDs
                    for ev in frame.Events do
                        match ev with
                        | GameEvent.UnitCreated(uid, _) ->
                            knownUnitIds.Add(uid) |> ignore
                            initialUnitIds.Add(uid) |> ignore
                        | _ -> ()
                    if warmupFrames.Count >= 30 then
                        failwith "CAPTURED_ENOUGH"
                    []
                )
            with
            | ex when ex.Message = "CAPTURED_ENOUGH" -> ()

            initialFrames <- warmupFrames |> Seq.toList
            initialEvents <- initialFrames |> List.collect (fun f -> f.Events)
            client <- Some c

            sw.Stop()
            initElapsed <- sw.Elapsed
        }

        member this.DisposeAsync() =
            client |> Option.iter (fun c -> c.Disconnect())
            client <- None

            listener |> Option.iter (fun l -> try l.Close() with _ -> ())
            listener <- None

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


/// xUnit collection definition that serializes all persistent engine tests
/// against a single shared PersistentEngineFixture instance.
[<CollectionDefinition("PersistentEngine")>]
type PersistentEngineCollection() =
    interface ICollectionFixture<PersistentEngineFixture>
