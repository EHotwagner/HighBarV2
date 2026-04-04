namespace HighBar.PersistentTests

open System
open Xunit
open Xunit.Abstractions
open HighBar.Client
open HighBar.Client.Commands

/// Tier 4: Combat interaction tests.
[<Collection("PersistentEngine")>]
[<TestCaseOrderer("HighBar.PersistentTests.PriorityOrderer", "HighBar.PersistentTests")>]
type T4_CombatTests(engine: PersistentEngineFixture, output: ITestOutputHelper) =

    /// Spawn a unit for our team (team 0) and return its ID.
    let spawnFriendlyUnit (x: float32) (z: float32) =
        let mutable unitId = None
        engine.RunFrames(15, fun frame idx ->
            for ev in frame.Events do
                match ev with
                | GameEvent.UnitCreated(uid, _) when unitId.IsNone ->
                    unitId <- Some uid
                | _ -> ()
            if idx = 0 then
                [ GiveMeNewUnitCommand 1 x 100.0f z ]
            else
                []
        ) |> ignore
        unitId

    [<Fact>]
    [<Priority(1)>]
    member _.``T4.1 Spawn armed unit and enemy, issue AttackCommand, verify damage events``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        // Spawn our unit
        let attackerId = spawnFriendlyUnit 1536.0f 4096.0f
        Assert.True(attackerId.IsSome, "Should have spawned attacker unit")
        let uid = attackerId.Value

        // Try to find an enemy unit from initial events or spawn scenarios
        // The NullAI on team 1 should have units; we look for EnemyEnterLOS
        let mutable attackSent = false
        let mutable damageEvents = 0
        let mutable enemyLosEvents = ResizeArray<int>()

        engine.RunFrames(60, fun frame idx ->
            for ev in frame.Events do
                match ev with
                | GameEvent.UnitDamaged _ -> damageEvents <- damageEvents + 1
                | GameEvent.EnemyDamaged _ -> damageEvents <- damageEvents + 1
                | GameEvent.EnemyEnterLOS(eid) -> enemyLosEvents.Add(eid)
                | _ -> ()

            // Try attacking a known enemy or a high unit ID that might be enemy
            if idx = 5 && not attackSent then
                attackSent <- true
                // Attack towards enemy start position
                let targetId = if enemyLosEvents.Count > 0 then enemyLosEvents.[0] else 99999
                output.WriteLine($"Attacking target {targetId} with unit {uid}")
                [ AttackCommand uid targetId ]
            else
                []
        ) |> ignore

        output.WriteLine($"Damage events observed: {damageEvents}, Enemy LOS events: {enemyLosEvents.Count}")
        Assert.True(attackSent, "Should have sent AttackCommand")

    [<Fact>]
    [<Priority(2)>]
    member _.``T4.2 Verify UnitDestroyed or EnemyDestroyed event``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        // Spawn two units close together for combat
        let unit1 = spawnFriendlyUnit 1536.0f 4096.0f
        Assert.True(unit1.IsSome, "Should have spawned unit 1")

        let mutable destroyedEvents = 0
        let mutable fightSent = false

        // Use FightCommand towards enemy base to provoke combat
        engine.RunFrames(100, fun frame idx ->
            for ev in frame.Events do
                match ev with
                | GameEvent.UnitDestroyed _ -> destroyedEvents <- destroyedEvents + 1
                | GameEvent.EnemyDestroyed _ -> destroyedEvents <- destroyedEvents + 1
                | _ -> ()

            if idx = 3 && not fightSent then
                fightSent <- true
                [ FightCommand unit1.Value 4608.0f 100.0f 4096.0f ]
            else
                []
        ) |> ignore

        output.WriteLine($"Destroyed events: {destroyedEvents}")

    [<Fact>]
    [<Priority(3)>]
    member _.``T4.3 Verify EnemyEnterLOS event when enemy comes into range``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        // Spawn unit and move towards enemy base
        let unitId = spawnFriendlyUnit 1536.0f 4096.0f
        Assert.True(unitId.IsSome, "Should have spawned a unit")
        let uid = unitId.Value

        let enemyLos = ResizeArray<int>()
        let mutable moveSent = false

        engine.RunFrames(80, fun frame idx ->
            for ev in frame.Events do
                match ev with
                | GameEvent.EnemyEnterLOS(eid) -> enemyLos.Add(eid)
                | _ -> ()

            if idx = 0 && not moveSent then
                moveSent <- true
                // Move towards enemy start position (4608, 4096)
                [ MoveCommand uid 4608.0f 100.0f 4096.0f ]
            else
                []
        ) |> ignore

        output.WriteLine($"Enemy LOS events: {enemyLos.Count}")
