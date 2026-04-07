namespace HighBar.PersistentTests

open System
open System.Diagnostics
open System.IO
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
    let mutable session: EngineSession option = None
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

    let configPath =
        let assemblyDir = Path.GetDirectoryName(typeof<PersistentEngineFixture>.Assembly.Location)
        let testProjectDir = Path.GetFullPath(Path.Combine(assemblyDir, "..", "..", ".."))
        let testsDir = Path.GetFullPath(Path.Combine(testProjectDir, "..", ".."))
        Path.Combine(testsDir, "engine-version.json")

    let checkPrerequisites () =
        let testsDir =
            let assemblyDir = Path.GetDirectoryName(typeof<PersistentEngineFixture>.Assembly.Location)
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
            failwith $"Prerequisites check script error: {stderr}{stdout}"
        elif proc.ExitCode <> 0 then
            failwith $"Prerequisites not met — skipping live engine tests.\n{stdout}"

    /// The shared client connected to the proxy.
    member _.Client =
        match session with
        | Some s -> s.Client
        | None -> failwith "Client not initialized"

    /// Frames captured during initial warm-up.
    member _.InitialFrames = initialFrames

    /// All events from the initial warm-up frames.
    member _.InitialEvents = initialEvents

    /// The session directory containing engine logs.
    member _.SessionDir =
        match session with
        | Some s -> s.SessionDir
        | None -> ""

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
        match session with
        | Some s -> s.IsEngineAlive
        | None -> false

    member this.ThrowIfEngineCrashed() =
        match session with
        | Some s -> s.ThrowIfEngineCrashed()
        | None -> failwith "Session not initialized"

    /// Run N frames, collecting all events and optionally sending commands.
    /// Uses c.Run internally to support callbacks during frame processing.
    /// Returns (frames, allEvents).
    member _.RunFrames(n: int, ?onFrame: GameFrame -> int -> Highbar.AICommand list) =
        let c = (session |> Option.defaultWith (fun () -> failwith "Session not initialized")).Client
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
    /// 3. Run verification frames and confirm unit count returns to initial
    member this.ResetGameState() =
        this.ThrowIfEngineCrashed()
        if not this.IsEngineAlive then () else

        let s = session |> Option.defaultWith (fun () -> failwith "Session not initialized")

        // Phase 1: Destroy all non-initial units via text commands + reset resources
        let unitsToDestroy =
            knownUnitIds
            |> Seq.filter (fun uid -> not (initialUnitIds.Contains(uid)))
            |> Seq.toList

        let c = s.Client
        let mutable sent = false
        try
            c.Run(fun frame ->
                for ev in frame.Events do
                    match ev with
                    | GameEvent.UnitDestroyed(uid, _) -> knownUnitIds.Remove(uid) |> ignore
                    | GameEvent.UnitCreated(uid, _) -> knownUnitIds.Add(uid) |> ignore
                    | _ -> ()

                if not sent then
                    sent <- true
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

        // Phase 2: Run verification frames to let engine process commands,
        // tracking unit events to confirm reset took effect
        this.RunFrames(10) |> ignore

        // Verify non-initial units were destroyed
        let nonInitialCount =
            knownUnitIds
            |> Seq.filter (fun uid -> not (initialUnitIds.Contains(uid)))
            |> Seq.length

        if nonInitialCount > 0 then
            let remaining =
                knownUnitIds
                |> Seq.filter (fun uid -> not (initialUnitIds.Contains(uid)))
                |> Seq.toList
            eprintfn $"WARNING: ResetGameState: {remaining.Length} non-initial units remain after reset: {remaining |> List.truncate 10}"

    interface IAsyncLifetime with
        member this.InitializeAsync() = task {
            let sw = Stopwatch.StartNew()

            EngineLauncher.cleanupStaleProcesses()
            checkPrerequisites()

            let config = EngineConfig.fromVersionFile configPath |> EngineConfig.validate
            let s = new EngineSession(config)
            s.Start()
            session <- Some s
            let c = s.Client

            // Warm-up: capture initial frames
            let warmupFrames = ResizeArray<GameFrame>()
            try
                try
                    c.Run(fun frame ->
                        warmupFrames.Add(frame)
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
                with ex when ex.Message = "CAPTURED_ENOUGH" -> ()
            with
            | :? EngineDisconnectedException ->
                s.ThrowIfEngineCrashed()
                failwith $"Engine disconnected during warm-up. Socket: {config.SocketPath}"

            initialFrames <- warmupFrames |> Seq.toList
            initialEvents <- initialFrames |> List.collect (fun f -> f.Events)

            // Check for enemy units in initial events
            hasEnemy <-
                initialEvents
                |> List.exists (function
                    | GameEvent.EnemyCreated _ | GameEvent.EnemyFinished _ -> true
                    | _ -> false)

            // UnitDefId discovery via engine callbacks
            let allDefIds = ResizeArray<int>()
            let entries = System.Collections.Generic.Dictionary<int, UnitDefInfo>()
            let builders = ResizeArray<int>()
            let armedUnits = ResizeArray<int>()
            let mobileUnits = ResizeArray<int>()
            let buildings = ResizeArray<int>()
            let economyUnits = ResizeArray<int>()
            let mutable discoveryDone = false

            // Run discovery inside c.Run so callbacks work
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
                                let isBuilding = not isBuilder && not isArmed
                                let info =
                                    { UnitDefId = defId
                                      Name = if String.IsNullOrEmpty(name) then None else Some name
                                      IsBuilder = isBuilder
                                      IsArmed = isArmed
                                      IsMobile = false
                                      IsBuilding = isBuilding
                                      SpawnSuccess = true }
                                entries.[defId] <- info
                                if isBuilder then builders.Add(defId)
                                if isArmed then armedUnits.Add(defId)
                                if isBuilding then buildings.Add(defId)
                                if isBuilding && not isArmed then economyUnits.Add(defId)

                            // Determine mobility for commander
                            let commanderUnitId =
                                initialEvents
                                |> List.tryPick (function GameEvent.UnitCreated(uid, _) -> Some uid | _ -> None)
                            let mutable commanderDefId = 0
                            match commanderUnitId with
                            | Some cmdUid ->
                                let cmdDefId = c.GetUnitDef(cmdUid)
                                if cmdDefId > 0 then
                                    commanderDefId <- cmdDefId
                                    commanderBuildOptions <- c.GetBuildOptions(cmdDefId)
                                    mobileUnits.Insert(0, cmdDefId)
                                    match entries.TryGetValue(cmdDefId) with
                                    | true, info -> entries.[cmdDefId] <- { info with IsMobile = true }
                                    | _ -> ()
                            | None -> ()

                            failwith "CAPTURED_ENOUGH"
                            []
                        else
                            failwith "CAPTURED_ENOUGH"
                            []
                    )
                with ex when ex.Message = "CAPTURED_ENOUGH" -> ()
            with
            | :? EngineDisconnectedException ->
                s.ThrowIfEngineCrashed()
                failwith $"Engine disconnected during UnitDef discovery. Socket: {config.SocketPath}"

            // Spawn-test builder defIds to find additional mobile units
            let commanderDefId =
                entries |> Seq.tryFind (fun kv -> kv.Value.IsMobile && kv.Value.IsBuilder)
                |> Option.map (fun kv -> kv.Key) |> Option.defaultValue 0

            for defId in builders |> Seq.toList do
                if defId <> commanderDefId then
                    let mutable testUid = None
                    try
                        this.RunFrames(10, fun frame _ ->
                            for ev in frame.Events do
                                match ev with
                                | GameEvent.UnitCreated(uid, _) when testUid.IsNone -> testUid <- Some uid
                                | _ -> ()
                            if testUid.IsNone then
                                [ Commands.GiveMeNewUnitCommand defId 1536.0f 100.0f 4096.0f ]
                            else []
                        ) |> ignore
                    with _ -> ()
                    match testUid with
                    | Some uid ->
                        // GetUnitMaxSpeed must be called inside a frame handler (callbacks only work during frame processing)
                        let mutable speed = 0.0f
                        try
                            this.RunFrames(1, fun _ _ ->
                                speed <- c.GetUnitMaxSpeed(uid)
                                [ Commands.SelfDestructCommand uid ]
                            ) |> ignore
                            this.RunFrames(5) |> ignore
                        with _ -> ()
                        if speed > 0.0f then
                            mobileUnits.Add(defId)
                            match entries.TryGetValue(defId) with
                            | true, info -> entries.[defId] <- { info with IsMobile = true }
                            | _ -> ()
                    | None -> ()

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
                    s.ThrowIfEngineCrashed()
                    failwith "Engine disconnected during enemy recheck"

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

        member _.DisposeAsync() =
            session |> Option.iter (fun s ->
                let keepLogs = Environment.GetEnvironmentVariable("HIGHBAR_KEEP_LOGS")
                let preserve = not (String.IsNullOrEmpty(keepLogs))
                s.Stop(preserve))
            session <- None
            Task.CompletedTask


/// xUnit collection definition that serializes all persistent engine tests
/// against a single shared PersistentEngineFixture instance.
[<CollectionDefinition("PersistentEngine")>]
type PersistentEngineCollection() =
    interface ICollectionFixture<PersistentEngineFixture>
