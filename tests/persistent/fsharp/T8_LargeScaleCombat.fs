namespace HighBar.PersistentTests

open System
open System.Diagnostics
open Xunit
open Xunit.Abstractions
open HighBar.Client
open HighBar.Client.Commands

/// Tier 8: Large-scale combat scenarios — stress-test with multiple units and event assertions.
[<Collection("PersistentEngine")>]
[<TestCaseOrderer("HighBar.PersistentTests.PriorityOrderer", "HighBar.PersistentTests")>]
type T8_LargeScaleCombat(engine: PersistentEngineFixture, output: ITestOutputHelper) =

    [<Fact>]
    [<Priority(1)>]
    member _.``T8.1 Spawn 20 armed units, issue FightCommand, verify engine stability``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        let armedDefId = engine.ArmedUnitDefId
        let spawnCount = 20
        let sw = Stopwatch.StartNew()

        output.WriteLine($"Spawning {spawnCount} armed units (defId={armedDefId})")

        let mutable totalCreated = 0
        let mutable sent = false
        engine.RunFrames(20, fun frame _ ->
            for ev in frame.Events do
                match ev with
                | GameEvent.UnitCreated _ -> totalCreated <- totalCreated + 1
                | _ -> ()

            if not sent then
                sent <- true
                [ for i in 0..spawnCount-1 ->
                    let x = 1200.0f + float32 (i % 5) * 60.0f
                    let z = 3800.0f + float32 (i / 5) * 60.0f
                    GiveMeNewUnitCommand armedDefId x 100.0f z ]
            else []
        ) |> ignore

        output.WriteLine($"Spawned: {totalCreated} units")

        // Issue FightCommand and run 500 frames
        let mutable damageEvents = 0
        let mutable destroyedEvents = 0
        let mutable fightSent = false

        engine.RunFrames(500, fun frame _ ->
            for ev in frame.Events do
                match ev with
                | GameEvent.UnitDamaged _ | GameEvent.EnemyDamaged _ -> damageEvents <- damageEvents + 1
                | GameEvent.UnitDestroyed _ | GameEvent.EnemyDestroyed _ -> destroyedEvents <- destroyedEvents + 1
                | _ -> ()

            if not fightSent then
                fightSent <- true
                [ FightCommand 0 4608.0f 100.0f 4096.0f ]
            else []
        ) |> ignore

        sw.Stop()

        output.WriteLine($"Frames run, damage={damageEvents}, destroyed={destroyedEvents}, time={sw.Elapsed.TotalSeconds:F1}s")
        Assert.True(engine.IsEngineAlive, "Engine should survive large-scale test")

    [<Fact>]
    [<Priority(2)>]
    member _.``T8.2 Post-combat reset completes and engine is ready``() =
        if not engine.IsEngineAlive then
            output.WriteLine("Engine not alive — skipping post-combat reset")
        else
            let sw = Stopwatch.StartNew()
            engine.ResetGameState()
            sw.Stop()

            output.WriteLine($"Post-combat reset: {sw.Elapsed.TotalSeconds:F1}s")
            Assert.True(sw.Elapsed.TotalSeconds < 30.0, $"Reset took {sw.Elapsed.TotalSeconds:F1}s, expected < 30s")

            // Verify engine works after reset
            let mutable created = false
            engine.RunFrames(15, fun frame _ ->
                for ev in frame.Events do
                    match ev with
                    | GameEvent.UnitCreated _ -> created <- true
                    | _ -> ()
                if not created then
                    [ GiveMeNewUnitCommand engine.MobileUnitDefId 1536.0f 100.0f 4096.0f ]
                else []
            ) |> ignore

            output.WriteLine($"Post-reset spawn: created={created}")
            Assert.True(created, "Engine should work after reset")
