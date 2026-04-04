namespace HighBar.Client

open System
open System.Diagnostics
open Highbar
open HighBar.Client.Tasks
open HighBar.Client.Managers
open HighBar.Client.Strategy
open HighBar.Client.Logging

/// Root game state for a single AI game session.
type GameState = {
    mutable FrameNumber: uint32
    TeamId: int
    AllyTeamId: int
    mutable Phase: GamePhase
    UnitRegistry: UnitRegistry
    Economy: EconomyModel
    ThreatMap: ThreatMap
    MapModel: MapModel
    TaskAssigner: TaskAssigner
    DecisionLog: DecisionLog
    Client: HighBarClient
}

module GameState =
    /// Initialize game state from engine queries.
    let init (client: HighBarClient) (teamId: int) (logPath: string) =
        let allyTeamId = client.GetMyAllyTeam()

        // Query map
        let mapWidth = client.GetMapWidth()
        let mapHeight = client.GetMapHeight()

        // Get start position
        let (sx, sy, sz) = client.GetStartPos(teamId)

        // Get metal spots
        let rawSpots = client.GetMetalSpots()
        let metalSpots =
            rawSpots
            |> Array.map (fun (x, y, z, v) -> MapAnalysis.createSpot sx sz x y z v)
            |> Array.toList

        // Get all start positions (we know there are at least 2 teams)
        let startPositions = [
            for t in 0 .. 1 do
                yield client.GetStartPos(t)
        ]

        let mapModel = {
            Width = mapWidth
            Height = mapHeight
            MetalSpots = metalSpots
            StartPositions = startPositions
            OurStartX = sx
            OurStartY = sy
            OurStartZ = sz
        }

        // Initialize unit registry from engine
        let registry = UnitRegistry()
        registry.DiscoverFromEngine(client)

        let decisionLog = DecisionLog(logPath)
        decisionLog.Open()

        // ThreatMap: cell size 512 elmos
        let threatMap = ThreatMap(mapWidth * 8, mapHeight * 8, 512)

        {
            FrameNumber = 0u
            TeamId = teamId
            AllyTeamId = allyTeamId
            Phase = GamePhase.Opening
            UnitRegistry = registry
            Economy = EconomyModel.create()
            ThreatMap = threatMap
            MapModel = mapModel
            TaskAssigner = TaskAssigner()
            DecisionLog = decisionLog
            Client = client
        }

    /// Process a single game event and update state.
    let processEvent (gs: GameState) (event: GameEvent) =
        let frame = gs.FrameNumber
        let client = gs.Client
        match event with
        | GameEvent.Init _ -> ()
        | GameEvent.Release -> ()
        | GameEvent.Update _ -> ()
        | GameEvent.Message _ -> ()
        | GameEvent.Load -> ()
        | GameEvent.Save -> ()

        | GameEvent.UnitCreated(unitId, _builderId) ->
            let defId = client.GetUnitDef(unitId)
            let name = client.GetUnitDefName(defId)
            let team = client.GetUnitTeam(unitId)
            gs.UnitRegistry.TrackFriendly(unitId, defId, team, name)
            let (x, y, z) = client.GetUnitPos(unitId)
            gs.UnitRegistry.UpdatePosition(unitId, x, y, z, frame)
            let health = client.GetUnitHealth(unitId)
            let maxHealth = client.GetUnitMaxHealth(unitId)
            gs.UnitRegistry.UpdateHealth(unitId, health, maxHealth)

        | GameEvent.UnitFinished unitId ->
            gs.UnitRegistry.MarkFinished(unitId)
            let (x, y, z) = client.GetUnitPos(unitId)
            gs.UnitRegistry.UpdatePosition(unitId, x, y, z, frame)

        | GameEvent.UnitIdle unitId ->
            // Unit is idle — managers will assign new tasks
            let (x, y, z) = client.GetUnitPos(unitId)
            gs.UnitRegistry.UpdatePosition(unitId, x, y, z, frame)

        | GameEvent.UnitMoveFailed unitId ->
            let (x, y, z) = client.GetUnitPos(unitId)
            gs.UnitRegistry.UpdatePosition(unitId, x, y, z, frame)

        | GameEvent.UnitDamaged(unitId, _attacker, _damage, _weaponDefId, _isParalyzer) ->
            let health = client.GetUnitHealth(unitId)
            let maxHealth = client.GetUnitMaxHealth(unitId)
            gs.UnitRegistry.UpdateHealth(unitId, health, maxHealth)

        | GameEvent.UnitDestroyed(unitId, _attacker) ->
            gs.UnitRegistry.MarkDestroyed(unitId)
            gs.TaskAssigner.Remove(unitId)

        | GameEvent.UnitGiven(unitId, _oldTeam, newTeam) ->
            if newTeam = gs.TeamId then
                let defId = client.GetUnitDef(unitId)
                let name = client.GetUnitDefName(defId)
                gs.UnitRegistry.TrackFriendly(unitId, defId, newTeam, name)

        | GameEvent.UnitCaptured(unitId, _oldTeam, newTeam) ->
            if newTeam <> gs.TeamId then
                gs.UnitRegistry.MarkDestroyed(unitId)
                gs.TaskAssigner.Remove(unitId)

        | GameEvent.EnemyCreated enemyId ->
            let defId = client.GetUnitDef(enemyId)
            let name = client.GetUnitDefName(defId)
            let team = client.GetUnitTeam(enemyId)
            gs.UnitRegistry.TrackEnemy(enemyId, defId, team, name)

        | GameEvent.EnemyFinished enemyId ->
            gs.UnitRegistry.MarkFinished(enemyId)

        | GameEvent.EnemyEnterLOS enemyId ->
            gs.UnitRegistry.MarkInLOS(enemyId, frame)
            let (x, y, z) = client.GetUnitPos(enemyId)
            gs.UnitRegistry.UpdatePosition(enemyId, x, y, z, frame)
            let health = client.GetUnitHealth(enemyId)
            let maxHealth = client.GetUnitMaxHealth(enemyId)
            gs.UnitRegistry.UpdateHealth(enemyId, health, maxHealth)

        | GameEvent.EnemyLeaveLOS enemyId ->
            gs.UnitRegistry.MarkLastKnown(enemyId)

        | GameEvent.EnemyEnterRadar enemyId ->
            let (x, y, z) = client.GetUnitPos(enemyId)
            gs.UnitRegistry.UpdatePosition(enemyId, x, y, z, frame)

        | GameEvent.EnemyLeaveRadar _ -> ()

        | GameEvent.EnemyDamaged(enemyId, _attacker, _damage, _weaponDefId) ->
            let health = client.GetUnitHealth(enemyId)
            let maxHealth = client.GetUnitMaxHealth(enemyId)
            gs.UnitRegistry.UpdateHealth(enemyId, health, maxHealth)

        | GameEvent.EnemyDestroyed(enemyId, _attacker) ->
            gs.UnitRegistry.MarkDestroyed(enemyId)

        | GameEvent.WeaponFired _ -> ()
        | GameEvent.PlayerCommand _ -> ()
        | GameEvent.SeismicPing _ -> ()
        | GameEvent.CommandFinished _ -> ()
        | GameEvent.LuaMessage _ -> ()
        | GameEvent.Unknown -> ()

    /// Generate engine commands from current task assignments.
    let generateCommands (gs: GameState) : AICommand list =
        let registry = gs.UnitRegistry
        let commands = System.Collections.Generic.List<AICommand>()

        for (unitId, task) in gs.TaskAssigner.AllAssignments do
            match registry.TryGet(unitId) with
            | Some u when u.Lifecycle = UnitLifecycle.Ready || u.Lifecycle = UnitLifecycle.Alive ->
                match task with
                | UnitTask.Idle -> ()
                | UnitTask.BuildMex(x, y, z) ->
                    // Find mex defId from build options
                    match registry.TryGetDef(u.DefId) with
                    | Some def ->
                        let mexDefId =
                            def.BuildOptions
                            |> Array.tryFind (fun bid ->
                                match registry.TryGetDef(bid) with
                                | Some d -> d.Name.Contains("mex")
                                | None -> false)
                        match mexDefId with
                        | Some did -> commands.Add(Commands.BuildCommand unitId did x y z 0)
                        | None -> ()
                    | None -> ()
                | UnitTask.BuildEnergy(x, y, z) ->
                    match registry.TryGetDef(u.DefId) with
                    | Some def ->
                        let energyDefId =
                            def.BuildOptions
                            |> Array.tryFind (fun bid ->
                                match registry.TryGetDef(bid) with
                                | Some d -> d.Name.Contains("solar") || d.Name.Contains("wind")
                                | None -> false)
                        match energyDefId with
                        | Some did -> commands.Add(Commands.BuildCommand unitId did x y z 0)
                        | None -> ()
                    | None -> ()
                | UnitTask.BuildFactory(defId, x, y, z) ->
                    commands.Add(Commands.BuildCommand unitId defId x y z 0)
                | UnitTask.BuildStructure(defId, x, y, z) ->
                    commands.Add(Commands.BuildCommand unitId defId x y z 0)
                | UnitTask.Produce defId ->
                    commands.Add(Commands.BuildCommand unitId defId u.PosX u.PosY u.PosZ 0)
                | UnitTask.Scout(x, y, z) ->
                    commands.Add(Commands.MoveCommand unitId x y z)
                | UnitTask.Attack(x, y, z) ->
                    commands.Add(Commands.FightCommand unitId x y z)
                | UnitTask.Defend(x, y, z) ->
                    commands.Add(Commands.PatrolCommand unitId x y z)
                | UnitTask.Retreat(x, y, z) ->
                    commands.Add(Commands.MoveCommand unitId x y z)
                | UnitTask.Guard targetId ->
                    commands.Add(Commands.GuardCommand unitId targetId)
                | UnitTask.Reclaim targetId ->
                    commands.Add(Commands.ReclaimUnitCommand unitId targetId)
                | UnitTask.Repair targetId ->
                    commands.Add(Commands.RepairCommand unitId targetId)
            | _ -> ()

        commands |> Seq.toList

    /// Evaluate game phase transitions.
    let updatePhase (gs: GameState) =
        let factoryCount =
            gs.UnitRegistry.GetFriendlyByClass(UnitClass.Factory)
            |> List.filter (fun u -> u.Lifecycle = UnitLifecycle.Ready)
            |> List.length

        let armyValue =
            gs.UnitRegistry.GetFriendlyByClass(UnitClass.MobileArmed)
            |> List.filter (fun u ->
                u.Lifecycle = UnitLifecycle.Ready &&
                not (u.Classification.HasFlag(UnitClass.Builder)))
            |> List.sumBy (fun u ->
                match gs.UnitRegistry.TryGetDef(u.DefId) with
                | Some d -> d.Cost
                | None -> 0.0f)

        // Check for T2 factory (a factory that can build units which themselves can build)
        let hasT2Factory =
            gs.UnitRegistry.GetFriendlyByClass(UnitClass.Factory)
            |> List.exists (fun u ->
                match gs.UnitRegistry.TryGetDef(u.DefId) with
                | Some d -> d.Cost > 2000.0f
                | None -> false)

        let newPhase = StrategyController.evaluatePhase gs.Phase factoryCount armyValue hasT2Factory
        if newPhase <> gs.Phase then
            gs.DecisionLog.Log({
                Frame = gs.FrameNumber; Manager = "Strategy"; Type = "phase_change"
                UnitId = None; Details = $"Phase: {gs.Phase} → {newPhase}"
                Context = Map.ofList ["factories", string factoryCount; "armyValue", string armyValue]
            })
            gs.Phase <- newPhase

    /// Process a complete frame: update state, run managers, generate commands.
    let processFrame (gs: GameState)
                     (economyMgr: EconomyManager)
                     (buildMgr: BuildManager)
                     (productionMgr: ProductionManager)
                     (militaryMgr: MilitaryManager)
                     (scoutMgr: ScoutManager)
                     (frame: GameFrame) : AICommand list =
        let sw = Stopwatch.StartNew()
        gs.FrameNumber <- frame.FrameNumber

        // Process events
        for event in frame.Events do
            try processEvent gs event
            with ex ->
                gs.DecisionLog.Log({ Frame = gs.FrameNumber; Manager = "EventProcessor"; Type = "error"; UnitId = None; Details = ex.Message; Context = Map.empty })

        // Update economy (every 8 frames to reduce callback overhead)
        if frame.FrameNumber % 8u = 0u then
            try EconomyModel.update gs.Client gs.Economy
            with _ -> ()

        // Evaluate phase transitions (every 30 frames)
        if frame.FrameNumber % 30u = 0u then
            try updatePhase gs
            with _ -> ()

        // Apply ThreatMap decay (every 60 frames)
        if frame.FrameNumber % 60u = 0u then
            gs.ThreatMap.Decay(gs.FrameNumber, 0.95f)

        // Collect proposals from all managers with frame budget awareness
        let proposals = System.Collections.Generic.List<CommandProposal>()
        let weights = StrategyController.getWeights gs.Phase

        let inline runManager name weight (evaluate: unit -> CommandProposal list) =
            if sw.ElapsedMilliseconds < 20L then
                try
                    let p = evaluate()
                    // Apply phase weight as priority boost
                    for proposal in p do
                        proposals.Add({ proposal with Priority = proposal.Priority + weight })
                with ex ->
                    gs.DecisionLog.Log({ Frame = gs.FrameNumber; Manager = name; Type = "error"; UnitId = None; Details = ex.Message; Context = Map.empty })

        runManager "Build" weights.Build (fun () ->
            buildMgr.EvaluateBuild(gs.Economy, gs.MapModel, gs.UnitRegistry, gs.TaskAssigner, gs.FrameNumber))

        runManager "Economy" weights.Economy (fun () ->
            economyMgr.EvaluateEconomy(gs.Economy, gs.MapModel, gs.UnitRegistry, gs.TaskAssigner))

        runManager "Production" weights.Production (fun () ->
            productionMgr.EvaluateProduction(gs.UnitRegistry, gs.TaskAssigner, gs.Phase, gs.Economy))

        runManager "Scout" weights.Scout (fun () ->
            scoutMgr.EvaluateScout(gs.UnitRegistry, gs.TaskAssigner, gs.MapModel, gs.FrameNumber))

        runManager "Military" weights.Military (fun () ->
            militaryMgr.EvaluateMilitary(gs.UnitRegistry, gs.TaskAssigner, gs.ThreatMap, gs.MapModel, gs.FrameNumber))

        // Log frame budget warning
        if sw.ElapsedMilliseconds > 25L then
            gs.DecisionLog.Log({
                Frame = gs.FrameNumber; Manager = "FrameBudget"; Type = "warning"
                UnitId = None; Details = $"Frame took {sw.ElapsedMilliseconds}ms (budget: 25ms)"
                Context = Map.empty
            })

        // Assign tasks
        gs.TaskAssigner.ProcessProposals(proposals |> Seq.toList)

        // Generate commands
        generateCommands gs

    /// Create the onFrame callback for HighBarClient.Run.
    let createFrameHandler (gs: GameState) =
        let economyMgr = EconomyManager()
        let buildMgr = BuildManager()
        let productionMgr = ProductionManager()
        let militaryMgr = MilitaryManager()
        let scoutMgr = ScoutManager()
        fun (frame: GameFrame) ->
            processFrame gs economyMgr buildMgr productionMgr militaryMgr scoutMgr frame
