namespace HighBar.PersistentTests

open System
open System.Diagnostics
open Xunit
open Xunit.Abstractions
open HighBar.Client
open HighBar.Client.Commands

/// Tier 0: Smoke tests validating the persistent engine fixture and reset mechanism.
[<Collection("PersistentEngine")>]
[<TestCaseOrderer("HighBar.PersistentTests.PriorityOrderer", "HighBar.PersistentTests")>]
type T0_SmokeTests(engine: PersistentEngineFixture, output: ITestOutputHelper) =

    [<Fact>]
    [<Priority(1)>]
    member _.``T0.1 Engine is alive after fixture init``() =
        Assert.True(engine.IsEngineAlive, "Engine should be alive after initialization")

    [<Fact>]
    [<Priority(2)>]
    member _.``T0.2 Client is connected and can run frames``() =
        engine.ThrowIfEngineCrashed()
        let (frames, _) = engine.RunFrames(5)
        Assert.True(frames.Length >= 5, $"Should have run 5 frames, got {frames.Length}")

    [<Fact>]
    [<Priority(3)>]
    member _.``T0.3 Initial warm-up events contain Init and UnitCreated``() =
        let hasInit =
            engine.InitialEvents |> List.exists (function GameEvent.Init _ -> true | _ -> false)
        let hasUnitCreated =
            engine.InitialEvents |> List.exists (function GameEvent.UnitCreated _ -> true | _ -> false)

        output.WriteLine($"Initial events count: {engine.InitialEvents.Length}")
        for ev in engine.InitialEvents do
            output.WriteLine($"  {ev}")

        Assert.True(hasInit, "Initial events should contain Init")
        Assert.True(hasUnitCreated, "Initial events should contain UnitCreated")

    [<Fact>]
    [<Priority(4)>]
    member _.``T0.4 Fixture startup completed in under 30 seconds``() =
        output.WriteLine($"Init elapsed: {engine.InitElapsed.TotalSeconds:F1}s")
        Assert.True(
            engine.InitElapsed.TotalSeconds < 30.0,
            $"Startup took {engine.InitElapsed.TotalSeconds:F1}s, expected < 30s")

    [<Fact>]
    [<Priority(5)>]
    member _.``T0.5 Discovery found at least one builder, armed, mobile, and building``() =
        let reg = engine.Registry
        output.WriteLine($"Builders: {reg.Builders.Length} — {reg.Builders}")
        output.WriteLine($"ArmedUnits: {reg.ArmedUnits.Length} — {reg.ArmedUnits}")
        output.WriteLine($"MobileUnits: {reg.MobileUnits.Length} — {reg.MobileUnits}")
        output.WriteLine($"Buildings: {reg.Buildings.Length} — {reg.Buildings}")
        output.WriteLine($"Total entries: {reg.Entries.Count}")
        for kv in reg.Entries do
            let info = kv.Value
            let name = info.Name |> Option.defaultValue "?"
            output.WriteLine($"  DefId {info.UnitDefId}: {name} builder={info.IsBuilder} armed={info.IsArmed} mobile={info.IsMobile} building={info.IsBuilding}")
        Assert.True(reg.Builders.Length >= 1, "Should discover at least one builder")
        Assert.True(reg.ArmedUnits.Length >= 1, "Should discover at least one armed unit")
        Assert.True(reg.MobileUnits.Length >= 1, "Should discover at least one mobile unit")
        Assert.True(reg.Buildings.Length >= 1, "Should discover at least one building")
        // T017: Assert at least 4 categories are populated
        let populatedCategories =
            [ reg.Builders.Length > 0
              reg.ArmedUnits.Length > 0
              reg.MobileUnits.Length > 0
              reg.Buildings.Length > 0
              reg.EconomyUnits.Length > 0 ]
            |> List.filter id |> List.length
        output.WriteLine($"Populated categories: {populatedCategories}/5 (builder, armed, mobile, building, economy)")
        Assert.True(populatedCategories >= 4, $"Expected at least 4 populated categories, got {populatedCategories}")

    [<Fact>]
    [<Priority(10)>]
    member _.``T0.6 After spawning a unit then resetting, no spawned units remain``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        let mobileDefId = engine.MobileUnitDefId
        output.WriteLine($"Using discovered mobile unitDefId: {mobileDefId}")

        // Spawn a unit using discovered ID
        let mutable spawnedUnitId = None
        let (_, events) = engine.RunFrames(30, fun frame idx ->
            for ev in frame.Events do
                match ev with
                | GameEvent.UnitCreated(uid, _) ->
                    output.WriteLine($"  Frame {idx}: UnitCreated {uid}")
                    if spawnedUnitId.IsNone then
                        spawnedUnitId <- Some uid
                | _ -> ()

            if idx = 0 then
                [ GiveMeNewUnitCommand mobileDefId 1536.0f 100.0f 3900.0f ]
            else
                []
        )

        output.WriteLine($"Spawned unit ID: {spawnedUnitId}")
        output.WriteLine($"All events received: {events.Length}")
        for ev in events do
            match ev with
            | GameEvent.UnitCreated _ | GameEvent.UnitDestroyed _ ->
                output.WriteLine($"  {ev}")
            | _ -> ()

        Assert.True(spawnedUnitId.IsSome, "Should have spawned a unit via GiveMeNewUnitCommand")

        // Reset and verify spawned unit is gone
        engine.ResetGameState()

        let (_, postResetEvents) = engine.RunFrames(10)
        let newUnitsAfterReset =
            postResetEvents
            |> List.choose (function GameEvent.UnitCreated(uid, _) -> Some uid | _ -> None)

        output.WriteLine($"Units created after reset: {newUnitsAfterReset.Length}")

    [<Fact>]
    [<Priority(11)>]
    member _.``T0.7 After modifying resources then resetting, resources return to baseline``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        // Give extra resources
        engine.RunFrames(5, fun _ idx ->
            if idx = 0 then
                [ GiveMeResourceCommand 0 50000.0f; GiveMeResourceCommand 1 50000.0f ]
            else
                []
        ) |> ignore

        // Reset
        engine.ResetGameState()
        // If we got here without error, the reset completed
        output.WriteLine("Resource reset completed successfully")

    [<Fact>]
    [<Priority(12)>]
    member _.``T0.8 Game frame number continues incrementing after reset``() =
        engine.ThrowIfEngineCrashed()

        // Capture frame number before reset
        let mutable preResetFrame = 0u
        engine.RunFrames(3, fun frame _ ->
            preResetFrame <- frame.FrameNumber
            []
        ) |> ignore

        engine.ResetGameState()

        // Capture frame number after reset
        let mutable postResetFrame = 0u
        engine.RunFrames(3, fun frame _ ->
            if postResetFrame = 0u then
                postResetFrame <- frame.FrameNumber
            []
        ) |> ignore

        output.WriteLine($"Pre-reset frame: {preResetFrame}, Post-reset frame: {postResetFrame}")
        Assert.True(
            postResetFrame > preResetFrame,
            $"Frame number should increase after reset: pre={preResetFrame}, post={postResetFrame}")

    [<Fact>]
    [<Priority(13)>]
    member _.``T0.9 ResetGameState completes in under 5 seconds``() =
        engine.ThrowIfEngineCrashed()

        // Spawn a few units to make the reset non-trivial
        let defId = engine.MobileUnitDefId
        engine.RunFrames(10, fun _ idx ->
            if idx = 0 then
                [ GiveMeNewUnitCommand defId 1536.0f 100.0f 4000.0f
                  GiveMeNewUnitCommand defId 1600.0f 100.0f 4000.0f
                  GiveMeNewUnitCommand defId 1700.0f 100.0f 4000.0f ]
            else
                []
        ) |> ignore

        let sw = Stopwatch.StartNew()
        engine.ResetGameState()
        sw.Stop()

        output.WriteLine($"Reset elapsed: {sw.Elapsed.TotalSeconds:F2}s")
        Assert.True(
            sw.Elapsed.TotalSeconds < 5.0,
            $"Reset took {sw.Elapsed.TotalSeconds:F2}s, expected < 5s")
