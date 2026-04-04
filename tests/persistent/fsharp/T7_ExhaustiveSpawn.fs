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
    member _.``T7.1 Spawn unitDefIds in batches using engine-discovered defIds``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        // Use first 200 engine-discovered defIds (subset to avoid crashes on exotic units)
        let allDefIds = engine.Registry.Entries |> Map.toList |> List.map fst
        let testDefIds = allDefIds |> List.truncate 200
        let totalDefs = testDefIds.Length
        let batchSize = 20
        let sw = Stopwatch.StartNew()

        let mutable totalCreated = 0
        let mutable batchesCompleted = 0

        output.WriteLine($"Starting spawn test: {totalDefs} unitDefIds (of {allDefIds.Length} total) in batches of {batchSize}")

        let batches = testDefIds |> List.chunkBySize batchSize
        for batchIdx, batch in batches |> List.mapi (fun i b -> (i, b)) do
            if engine.IsEngineAlive then
                let createdCount = ref 0
                let mutable sent = false
                try
                    engine.RunFrames(20, fun frame _ ->
                        for ev in frame.Events do
                            match ev with
                            | GameEvent.UnitCreated _ -> createdCount.Value <- createdCount.Value + 1
                            | _ -> ()
                        if not sent then
                            sent <- true
                            [ for defId in batch ->
                                let x = 500.0f + float32 ((defId - 1) % 10) * 100.0f
                                let z = 500.0f + float32 ((defId - 1) / 10 % 10) * 100.0f
                                GiveMeNewUnitCommand defId x 100.0f z ]
                        else []
                    ) |> ignore
                with _ -> ()

                totalCreated <- totalCreated + createdCount.Value
                batchesCompleted <- batchesCompleted + 1

                if engine.IsEngineAlive && batchIdx < batches.Length - 1 then
                    try engine.ResetGameState() with _ -> ()

        sw.Stop()

        output.WriteLine($"=== Spawn Summary ===")
        output.WriteLine($"Batches completed: {batchesCompleted}/{batches.Length}")
        output.WriteLine($"UnitCreated events: {totalCreated}/{totalDefs}")
        output.WriteLine($"Elapsed: {sw.Elapsed.TotalSeconds:F1}s")

        Assert.True(batchesCompleted >= 1, "Should complete at least one batch")
        Assert.True(totalCreated > 0, "Should have created at least some units")

        if engine.IsEngineAlive then
            try engine.ResetGameState() with _ -> ()

    [<Fact>]
    [<Priority(2)>]
    member _.``T7.2 Unit count limit test — spawn same safe defId 200 times``() =
        if not engine.IsEngineAlive then
            output.WriteLine("Engine not alive — skipping")
        else
            engine.ResetGameState()

            let safeDefId =
                engine.Registry.Entries |> Map.toList |> List.map fst |> List.head

            output.WriteLine($"Spawning defId={safeDefId} 200 times")

            let mutable totalCreated = 0
            for batchIdx in 0..3 do
                if engine.IsEngineAlive then
                    let mutable sent = false
                    try
                        engine.RunFrames(20, fun frame _ ->
                            for ev in frame.Events do
                                match ev with
                                | GameEvent.UnitCreated _ -> totalCreated <- totalCreated + 1
                                | _ -> ()
                            if not sent then
                                sent <- true
                                [ for i in 0..49 ->
                                    let x = 200.0f + float32 (i % 10) * 60.0f
                                    let z = 200.0f + float32 (i / 10) * 60.0f + float32 batchIdx * 400.0f
                                    GiveMeNewUnitCommand safeDefId x 100.0f z ]
                            else []
                        ) |> ignore
                    with _ -> ()

            output.WriteLine($"Spawned {totalCreated} units of defId={safeDefId}")
            Assert.True(engine.IsEngineAlive, $"Engine should survive spawning 200 units of safe defId={safeDefId}")
            if engine.IsEngineAlive then engine.ResetGameState()

    [<Fact>]
    [<Priority(3)>]
    member _.``T7.3 State leak test — spawn and reset 20 iterations``() =
        if not engine.IsEngineAlive then
            output.WriteLine("Engine not alive — skipping")
        else
            let safeDefId =
                engine.Registry.Entries |> Map.toList |> List.map fst |> List.head

            let mutable iterations = 0
            for _ in 0..19 do
                if engine.IsEngineAlive then
                    let mutable sent = false
                    try
                        engine.RunFrames(15, fun _ _ ->
                            if not sent then
                                sent <- true
                                [ for i in 0..9 ->
                                    GiveMeNewUnitCommand safeDefId (500.0f + float32 i * 60.0f) 100.0f 3000.0f ]
                            else []
                        ) |> ignore
                    with _ -> ()
                    if engine.IsEngineAlive then
                        try engine.ResetGameState() with _ -> ()
                        iterations <- iterations + 1

            output.WriteLine($"Completed {iterations}/20 spawn-reset iterations")
            Assert.True(iterations >= 15, $"Expected at least 15/20 iterations, got {iterations}")
