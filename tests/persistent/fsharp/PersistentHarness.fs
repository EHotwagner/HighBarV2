namespace HighBar.PersistentTests

open System
open System.Diagnostics
open System.IO
open System.Net.Sockets
open System.Threading.Tasks
open Xunit
open HighBar.Client
open HighBar.Client.Commands

/// Per-unitDefId discovery result.
type UnitDefInfo =
    { UnitDefId: int
      Name: string option
      IsBuilder: bool
      IsArmed: bool
      IsMobile: bool
      IsBuilding: bool
      SpawnSuccess: bool }

/// Runtime-discovered mapping built during fixture initialization.
type UnitDefRegistry =
    { Entries: Map<int, UnitDefInfo>
      Builders: int list
      ArmedUnits: int list
      MobileUnits: int list
      Buildings: int list
      EconomyUnits: int list
      FailedIds: int list }

/// Result of one batch in the exhaustive spawn test.
type BatchResult =
    { BatchIndex: int
      StartId: int
      EndId: int
      Expected: int
      Received: int
      FailedIds: int list
      EngineCrashed: bool }

/// Accumulated statistics from large-scale combat scenarios.
type BattleMetrics =
    { UnitsSpawned: int
      FramesRun: int
      DamageEvents: int
      DestroyedEvents: int
      LosEvents: int
      EngineAlive: bool
      ElapsedSeconds: float }

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
    let mutable registry: UnitDefRegistry option = None
    let mutable commanderBuildOptions: int array = [||]
    let mutable hasEnemy: bool = false

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

    /// The discovered UnitDef registry.
    member _.Registry = registry |> Option.defaultWith (fun () -> failwith "Registry not initialized")

    /// Build options discovered for the commander unit.
    member _.CommanderBuildOptions = commanderBuildOptions

    /// Whether an enemy unit was detected during initialization.
    member _.HasEnemy = hasEnemy

    /// UnitDefId for a builder unit.
    member _.BuilderDefId =
        let r = registry |> Option.defaultWith (fun () -> failwith "Registry not initialized")
        r.Builders |> List.tryHead |> Option.defaultWith (fun () -> failwith "No builder discovered")

    /// UnitDefId for a ground-attack armed unit (prefers known assault units over AA).
    member _.ArmedUnitDefId =
        let r = registry |> Option.defaultWith (fun () -> failwith "Registry not initialized")
        // Prefer known ground combat units (tanks, kbots with ground weapons)
        let knownGroundNames = ["armpw"; "corpw"; "armham"; "corham"; "armrock"; "corrock"; "armwar"; "corwar"; "armstump"; "corstump"; "armflash"; "armbull"]
        let groundUnit =
            r.ArmedUnits
            |> List.tryFind (fun defId ->
                match r.Entries |> Map.tryFind defId with
                | Some info ->
                    match info.Name with
                    | Some name -> knownGroundNames |> List.exists (fun gn -> name = gn)
                    | None -> false
                | None -> false)
        groundUnit
        |> Option.orElseWith (fun () -> r.ArmedUnits |> List.tryHead)
        |> Option.defaultWith (fun () -> failwith "No armed unit discovered")

    /// UnitDefId for a mobile unit.
    member _.MobileUnitDefId =
        let r = registry |> Option.defaultWith (fun () -> failwith "Registry not initialized")
        r.MobileUnits |> List.tryHead |> Option.defaultWith (fun () -> failwith "No mobile unit discovered")

    /// UnitDefId for a building.
    member _.BuildingDefId =
        let r = registry |> Option.defaultWith (fun () -> failwith "Registry not initialized")
        r.Buildings |> List.tryHead |> Option.defaultWith (fun () -> failwith "No building discovered")

    /// UnitDefId for a buildable structure (from commander's build options).
    member _.BuildableStructureDefId =
        let r = registry |> Option.defaultWith (fun () -> failwith "Registry not initialized")
        // Prefer a building from commander's build options
        let fromBuildOptions =
            commanderBuildOptions
            |> Array.tryFind (fun defId ->
                match r.Entries |> Map.tryFind defId with
                | Some info -> info.IsBuilding && not info.IsMobile
                | None -> false)
        fromBuildOptions
        |> Option.orElseWith (fun () -> r.Buildings |> List.tryHead)
        |> Option.defaultWith (fun () -> failwith "No buildable structure discovered")

    /// Check if the engine process is still alive.
    member _.IsEngineAlive =
        match engineProcess with
        | Some p -> not p.HasExited
        | None -> false

    member this.ThrowIfEngineCrashed() =
        if not this.IsEngineAlive then
            let mutable diagInfo = $"Engine process has exited unexpectedly.\nSocket: {socketPath}\n"
            match engineProcess with
            | Some p ->
                try
                    diagInfo <- diagInfo + $"PID: {p.Id}, Exit code: {p.ExitCode}\n"
                with
                | :? InvalidOperationException ->
                    diagInfo <- diagInfo + $"PID: {p.Id}, Exit code: unknown (process not owned)\n"
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
        | :? EngineDisconnectedException as ex ->
            let lastFrame = if allFrames.Count > 0 then allFrames.[allFrames.Count - 1].FrameNumber else 0u
            failwith $"Engine disconnected during RunFrames at frame {lastFrame} after {frameIdx} frames: {ex.Message}"

        (allFrames |> Seq.toList, allEvents |> Seq.toList)

    /// Run N frames and return an event type distribution log.
    /// Returns (frames, allEvents, eventCounts) where eventCounts maps event type name to count.
    member this.RunFramesWithEventLog(n: int, ?onFrame: GameFrame -> int -> Highbar.AICommand list) =
        let eventCounts = System.Collections.Generic.Dictionary<string, int>()
        let handler = defaultArg onFrame (fun _ _ -> [])
        let (frames, events) =
            this.RunFrames(n, fun frame idx ->
                for ev in frame.Events do
                    let name =
                        match ev with
                        | GameEvent.Init _ -> "Init"
                        | GameEvent.Update _ -> "Update"
                        | GameEvent.UnitCreated _ -> "UnitCreated"
                        | GameEvent.UnitFinished _ -> "UnitFinished"
                        | GameEvent.UnitIdle _ -> "UnitIdle"
                        | GameEvent.UnitDamaged _ -> "UnitDamaged"
                        | GameEvent.UnitDestroyed _ -> "UnitDestroyed"
                        | GameEvent.EnemyEnterLOS _ -> "EnemyEnterLOS"
                        | GameEvent.EnemyLeaveLOS _ -> "EnemyLeaveLOS"
                        | GameEvent.EnemyDamaged _ -> "EnemyDamaged"
                        | GameEvent.EnemyDestroyed _ -> "EnemyDestroyed"
                        | GameEvent.EnemyCreated _ -> "EnemyCreated"
                        | GameEvent.EnemyFinished _ -> "EnemyFinished"
                        | GameEvent.WeaponFired _ -> "WeaponFired"
                        | _ -> "Other"
                    match eventCounts.TryGetValue(name) with
                    | true, c -> eventCounts.[name] <- c + 1
                    | _ -> eventCounts.[name] <- 1
                handler frame idx
            )
        (frames, events, eventCounts |> Seq.map (fun kv -> kv.Key, kv.Value) |> Map.ofSeq)

    /// Reset game state between tests:
    /// 1. Send destroy text commands for instant unit removal (cheats enabled)
    /// 2. Reset resources via GiveMeResourceCommand
    /// 3. Run verification frames
    member this.ResetGameState() =
        this.ThrowIfEngineCrashed()
        if not this.IsEngineAlive then () else

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
        | :? EngineDisconnectedException ->
            failwith "Engine disconnected during ResetGameState — engine has crashed"

        // Phase 2: Run verification frames to let engine process commands
        this.RunFrames(10) |> ignore

    interface IAsyncLifetime with
        member this.InitializeAsync() = task {
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
            with
            | :? EngineDisconnectedException ->
                this.ThrowIfEngineCrashed()
                failwith $"Engine disconnected during warm-up. Socket: {socketPath}"

            initialFrames <- warmupFrames |> Seq.toList
            initialEvents <- initialFrames |> List.collect (fun f -> f.Events)
            client <- Some c

            // Check for enemy units in initial events (cheat events should be enabled via proxy init)
            hasEnemy <-
                initialEvents
                |> List.exists (function
                    | GameEvent.EnemyCreated _ | GameEvent.EnemyFinished _ -> true
                    | _ -> false)

            // UnitDefId discovery via engine callbacks (must happen INSIDE c.Run frame loop)
            // The proxy only processes CallbackRequests during frame response handling.
            let allDefIds = ResizeArray<int>()
            let entries = System.Collections.Generic.Dictionary<int, UnitDefInfo>()
            let builders = ResizeArray<int>()
            let armedUnits = ResizeArray<int>()
            let mobileUnits = ResizeArray<int>()
            let buildings = ResizeArray<int>()
            let economyUnits = ResizeArray<int>()
            let mutable discoveryDone = false

            try
                try
                    c.Run(fun frame ->
                        // Track events
                        for ev in frame.Events do
                            match ev with
                            | GameEvent.EnemyCreated _ | GameEvent.EnemyFinished _ -> hasEnemy <- true
                            | GameEvent.UnitCreated(uid, _) ->
                                knownUnitIds.Add(uid) |> ignore
                                initialUnitIds.Add(uid) |> ignore
                            | _ -> ()

                        if not discoveryDone then
                            discoveryDone <- true

                            // Enable cheat events from F# side as fallback
                            try c.SetCheatEventsEnabled(true) |> ignore with _ -> ()

                            // Get all valid defIds from engine
                            let ids = c.GetUnitDefs(1024)
                            allDefIds.AddRange(ids)

                            // Query metadata for each defId
                            for defId in ids do
                                let name = c.GetUnitDefName(defId)
                                let buildSpeed = c.GetBuildSpeed(defId)
                                let weaponRange = c.GetMaxWeaponRange(defId)
                                let isBuilder = buildSpeed > 0.0f
                                let isArmed = weaponRange > 0.0f
                                let isMobile = isBuilder || isArmed
                                let isBuilding = not isMobile
                                let info =
                                    { UnitDefId = defId
                                      Name = if String.IsNullOrEmpty(name) then None else Some name
                                      IsBuilder = isBuilder
                                      IsArmed = isArmed
                                      IsMobile = isMobile
                                      IsBuilding = isBuilding
                                      SpawnSuccess = true }
                                entries.[defId] <- info
                                if isBuilder then builders.Add(defId)
                                if isArmed then armedUnits.Add(defId)
                                if isMobile then mobileUnits.Add(defId)
                                if isBuilding then buildings.Add(defId)
                                if isBuilding && not isArmed then economyUnits.Add(defId)

                            // Discover commander build options
                            let commanderUnitId =
                                initialEvents
                                |> List.tryPick (function GameEvent.UnitCreated(uid, _) -> Some uid | _ -> None)
                            match commanderUnitId with
                            | Some cmdUid ->
                                let cmdDefId = c.GetUnitDef(cmdUid)
                                if cmdDefId > 0 then
                                    commanderBuildOptions <- c.GetBuildOptions(cmdDefId)
                            | None -> ()

                            failwith "CAPTURED_ENOUGH"
                            []
                        else
                            failwith "CAPTURED_ENOUGH"
                            []
                    )
                with
                | ex when ex.Message = "CAPTURED_ENOUGH" -> ()
            with
            | :? EngineDisconnectedException ->
                this.ThrowIfEngineCrashed()
                failwith $"Engine disconnected during UnitDef discovery. Socket: {socketPath}"

            // Run a few more frames to check for enemy events if not seen yet
            if not hasEnemy then
                let mutable recheckFrames = 0
                try
                    try
                        c.Run(fun frame ->
                            for ev in frame.Events do
                                match ev with
                                | GameEvent.EnemyCreated _ | GameEvent.EnemyFinished _ -> hasEnemy <- true
                                | GameEvent.UnitCreated(uid, _) ->
                                    knownUnitIds.Add(uid) |> ignore
                                    initialUnitIds.Add(uid) |> ignore
                                | _ -> ()
                            recheckFrames <- recheckFrames + 1
                            if recheckFrames >= 30 then failwith "CAPTURED_ENOUGH"
                            []
                        )
                    with ex when ex.Message = "CAPTURED_ENOUGH" -> ()
                with
                | :? EngineDisconnectedException ->
                    this.ThrowIfEngineCrashed()
                    failwith $"Engine disconnected during enemy recheck. Socket: {socketPath}"

            registry <- Some
                { Entries = entries |> Seq.map (fun kv -> kv.Key, kv.Value) |> Map.ofSeq
                  Builders = builders |> Seq.toList
                  ArmedUnits = armedUnits |> Seq.toList
                  MobileUnits = mobileUnits |> Seq.toList
                  Buildings = buildings |> Seq.toList
                  EconomyUnits = economyUnits |> Seq.toList
                  FailedIds = [] }

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

            // Preserve session dir if HIGHBAR_KEEP_LOGS is set (for debugging)
            let keepLogs = Environment.GetEnvironmentVariable("HIGHBAR_KEEP_LOGS")
            if String.IsNullOrEmpty(keepLogs) then
                if not (String.IsNullOrEmpty(sessionDir)) && Directory.Exists(sessionDir) then
                    try Directory.Delete(sessionDir, true) with _ -> ()
            else
                eprintfn $"Keeping session dir: {sessionDir}"

            Task.CompletedTask


/// xUnit collection definition that serializes all persistent engine tests
/// against a single shared PersistentEngineFixture instance.
[<CollectionDefinition("PersistentEngine")>]
type PersistentEngineCollection() =
    interface ICollectionFixture<PersistentEngineFixture>
