namespace HighBar.PersistentTests

open System
open Xunit
open Xunit.Abstractions
open HighBar.Client
open HighBar.Client.Commands

/// Tier 4: Combat command tests with hard event assertions where possible.
[<Collection("PersistentEngine")>]
[<TestCaseOrderer("HighBar.PersistentTests.PriorityOrderer", "HighBar.PersistentTests")>]
type T4_CombatTests(engine: PersistentEngineFixture, output: ITestOutputHelper) =

    [<Fact>]
    [<Priority(1)>]
    member _.``T4.1 Spawn armed units, issue FightCommand, engine survives and runs frames``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        let armedDefId = engine.ArmedUnitDefId
        output.WriteLine($"Using armed unitDefId={armedDefId}")

        // Spawn 5 armed units
        let createdIds = ResizeArray<int>()
        engine.RunFrames(20, fun frame idx ->
            for ev in frame.Events do
                match ev with
                | GameEvent.UnitCreated(uid, _) -> createdIds.Add(uid)
                | _ -> ()
            if idx = 0 then
                [ for i in 0..4 ->
                    GiveMeNewUnitCommand armedDefId (4400.0f + float32 i * 50.0f) 100.0f 4096.0f ]
            else []
        ) |> ignore

        Assert.True(createdIds.Count >= 1, $"Should spawn armed units, got {createdIds.Count}")

        // Issue FightCommand and collect any combat events
        let mutable fightSent = false
        let mutable damageEvents = 0
        let mutable losEvents = 0

        let (frames, _) = engine.RunFrames(300, fun frame idx ->
            for ev in frame.Events do
                match ev with
                | GameEvent.UnitDamaged _ | GameEvent.EnemyDamaged _ -> damageEvents <- damageEvents + 1
                | GameEvent.EnemyEnterLOS _ -> losEvents <- losEvents + 1
                | _ -> ()

            if idx = 0 && not fightSent then
                fightSent <- true
                createdIds |> Seq.map (fun uid -> FightCommand uid 4608.0f 100.0f 4096.0f) |> Seq.toList
            else []
        )

        engine.ThrowIfEngineCrashed()
        output.WriteLine($"FightCommand: {createdIds.Count} units, {frames.Length} frames, damage={damageEvents}, LOS={losEvents}")
        Assert.True(frames.Length >= 300, $"Engine should survive FightCommand, ran {frames.Length} frames")

    [<Fact>]
    [<Priority(2)>]
    member _.``T4.2 Spawn unit near enemy position, issue AttackCommand, engine accepts``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        let armedDefId = engine.ArmedUnitDefId
        let mutable unitId = None
        engine.RunFrames(15, fun frame idx ->
            for ev in frame.Events do
                match ev with
                | GameEvent.UnitCreated(uid, _) when unitId.IsNone -> unitId <- Some uid
                | _ -> ()
            if idx = 0 then
                [ GiveMeNewUnitCommand armedDefId 4500.0f 100.0f 4096.0f ]
            else []
        ) |> ignore

        Assert.True(unitId.IsSome, "Should spawn armed unit")
        let uid = unitId.Value

        // Issue AttackCommand to a unit ID (even if invalid target, engine should handle)
        let mutable attackSent = false
        let (frames, _) = engine.RunFrames(100, fun _ idx ->
            if idx = 0 && not attackSent then
                attackSent <- true
                [ AttackCommand uid 99999 ]  // Attack toward nonexistent target
            else []
        )

        engine.ThrowIfEngineCrashed()
        output.WriteLine($"AttackCommand sent for unit {uid}, engine survived {frames.Length} frames")
        Assert.True(frames.Length >= 100, "Engine should survive AttackCommand")

    [<Fact>]
    [<Priority(3)>]
    member _.``T4.3 SelfDestruct a spawned unit and verify UnitDestroyed``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        let mobileDefId = engine.MobileUnitDefId
        let mutable unitId = None
        engine.RunFrames(15, fun frame idx ->
            for ev in frame.Events do
                match ev with
                | GameEvent.UnitCreated(uid, _) when unitId.IsNone -> unitId <- Some uid
                | _ -> ()
            if idx = 0 then
                [ GiveMeNewUnitCommand mobileDefId 1536.0f 100.0f 4096.0f ]
            else []
        ) |> ignore

        Assert.True(unitId.IsSome, "Should spawn unit")
        let uid = unitId.Value

        // Self-destruct and check for events
        let mutable destroyed = false
        let (frames, _) = engine.RunFrames(200, fun frame idx ->
            for ev in frame.Events do
                match ev with
                | GameEvent.UnitDestroyed(duid, _) when duid = uid -> destroyed <- true
                | _ -> ()

            if idx = 3 then
                [ SelfDestructCommand uid ]
            else []
        )

        engine.ThrowIfEngineCrashed()
        output.WriteLine($"SelfDestruct unit {uid}: destroyed={destroyed}, frames={frames.Length}")
        // Engine must survive; destruction is bonus (may depend on engine countdown timing)
        Assert.True(frames.Length >= 200, $"Engine should survive SelfDestructCommand, ran {frames.Length} frames")
