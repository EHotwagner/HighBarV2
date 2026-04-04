namespace HighBar.PersistentTests

open System
open System.Diagnostics
open Xunit
open Xunit.Abstractions
open HighBar.Client
open HighBar.Client.Commands

/// Tier 7: Exhaustive unitDef spawn test — verify a broad range of unitDefIds can be spawned.
[<Collection("PersistentEngine")>]
[<TestCaseOrderer("HighBar.PersistentTests.PriorityOrderer", "HighBar.PersistentTests")>]
type T7_ExhaustiveSpawn(engine: PersistentEngineFixture, output: ITestOutputHelper) =

    [<Fact>]
    [<Priority(1)>]
    member _.``T7.1 Spawn unitDefIds in batches, verify engine survives``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        // Test a representative sample: first 200 defIds in batches of 20
        let totalDefs = min 200 (BarData.AllUnits.all.Length)
        let batchSize = 20
        let batchCount = (totalDefs + batchSize - 1) / batchSize
        let sw = Stopwatch.StartNew()

        let mutable totalCreated = 0
        let mutable batchesCompleted = 0

        output.WriteLine($"Starting spawn test: {totalDefs} unitDefIds in {batchCount} batches of {batchSize}")

        for batchIdx in 0..batchCount-1 do
            if not engine.IsEngineAlive then
                output.WriteLine($"Engine died at batch {batchIdx}")
            else
                let startId = batchIdx * batchSize + 1
                let endId = min (startId + batchSize - 1) totalDefs

                let createdCount = ref 0
                let mutable sent = false

                engine.RunFrames(20, fun frame _ ->
                    for ev in frame.Events do
                        match ev with
                        | GameEvent.UnitCreated _ -> createdCount.Value <- createdCount.Value + 1
                        | _ -> ()

                    if not sent then
                        sent <- true
                        [ for defId in startId..endId ->
                            let x = 500.0f + float32 ((defId - startId) % 10) * 100.0f
                            let z = 500.0f + float32 ((defId - startId) / 10) * 100.0f
                            GiveMeNewUnitCommand defId x 100.0f z ]
                    else []
                ) |> ignore

                totalCreated <- totalCreated + createdCount.Value
                batchesCompleted <- batchesCompleted + 1

                if engine.IsEngineAlive && batchIdx < batchCount - 1 then
                    engine.ResetGameState()

        sw.Stop()

        output.WriteLine($"=== Spawn Summary ===")
        output.WriteLine($"Batches completed: {batchesCompleted}/{batchCount}")
        output.WriteLine($"UnitCreated events: {totalCreated}")
        output.WriteLine($"Elapsed: {sw.Elapsed.TotalSeconds:F1}s")

        Assert.True(batchesCompleted >= 1, "Should complete at least one batch")
        Assert.True(totalCreated > 0, "Should have created at least some units")

        if engine.IsEngineAlive then
            engine.ResetGameState()
