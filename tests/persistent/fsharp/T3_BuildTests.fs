namespace HighBar.PersistentTests

open System
open Xunit
open Xunit.Abstractions
open HighBar.Client
open HighBar.Client.Commands

/// Tier 3: Building construction and lifecycle tests with hard event assertions.
[<Collection("PersistentEngine")>]
[<TestCaseOrderer("HighBar.PersistentTests.PriorityOrderer", "HighBar.PersistentTests")>]
type T3_BuildTests(engine: PersistentEngineFixture, output: ITestOutputHelper) =

    /// Get the initial commander's unit ID from warm-up events.
    let getCommanderId () =
        engine.InitialEvents
        |> List.tryPick (function GameEvent.UnitCreated(uid, _) -> Some uid | _ -> None)
        |> Option.defaultWith (fun () -> failwith "No initial commander found")

    [<Fact>]
    [<Priority(1)>]
    member _.``T3.1 Spawn building via GiveMeNewUnitCommand, assert UnitCreated``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        let buildingDefId = engine.BuildingDefId
        output.WriteLine($"Using building defId={buildingDefId}")

        let createdIds = ResizeArray<int>()
        engine.RunFrames(20, fun frame idx ->
            for ev in frame.Events do
                match ev with
                | GameEvent.UnitCreated(cuid, _) -> createdIds.Add(cuid)
                | _ -> ()

            if idx = 0 then
                [ GiveMeResourceCommand 0 100000.0f
                  GiveMeResourceCommand 1 100000.0f
                  GiveMeNewUnitCommand buildingDefId 1536.0f 100.0f 4096.0f ]
            else []
        ) |> ignore

        output.WriteLine($"UnitCreated events for building: {createdIds.Count}")
        Assert.True(createdIds.Count >= 1, $"Expected UnitCreated for building defId={buildingDefId}, got {createdIds.Count}")

    [<Fact>]
    [<Priority(2)>]
    member _.``T3.2 Spawn building and assert UnitFinished event``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        let buildingDefId = engine.BuildingDefId
        let finishedIds = ResizeArray<int>()
        let createdIds = ResizeArray<int>()

        engine.RunFrames(20, fun frame idx ->
            for ev in frame.Events do
                match ev with
                | GameEvent.UnitCreated(cuid, _) -> createdIds.Add(cuid)
                | GameEvent.UnitFinished(fuid) -> finishedIds.Add(fuid)
                | _ -> ()

            if idx = 0 then
                [ GiveMeResourceCommand 0 100000.0f
                  GiveMeResourceCommand 1 100000.0f
                  GiveMeNewUnitCommand buildingDefId 1536.0f 100.0f 4096.0f ]
            else []
        ) |> ignore

        output.WriteLine($"Created: {createdIds.Count}, Finished: {finishedIds.Count}")
        Assert.True(finishedIds.Count >= 1, $"Expected UnitFinished for spawned building, got {finishedIds.Count}")

    [<Fact>]
    [<Priority(3)>]
    member _.``T3.3 Commander issues BuildCommand and engine accepts without crash``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        engine.RunFrames(5, fun _ idx ->
            if idx = 0 then
                [ GiveMeResourceCommand 0 100000.0f; GiveMeResourceCommand 1 100000.0f ]
            else []
        ) |> ignore

        let cmdId = getCommanderId()
        output.WriteLine($"Commander unitId={cmdId}")

        // Send build commands for a range of defIds — engine must not crash
        let mutable buildSent = false
        let mutable anyCreated = false
        let (frames, _) = engine.RunFrames(100, fun frame idx ->
            for ev in frame.Events do
                match ev with
                | GameEvent.UnitCreated(cuid, _) when cuid <> cmdId ->
                    anyCreated <- true
                    output.WriteLine($"  BuildCommand produced UnitCreated: {cuid}")
                | _ -> ()

            if idx = 0 && not buildSent then
                buildSent <- true
                [ for defId in 1..50 ->
                    BuildCommand cmdId defId 1536.0f 0.0f (4096.0f + float32 defId * 32.0f) 0 ]
            else
                []
        )

        engine.ThrowIfEngineCrashed()
        output.WriteLine($"BuildCommand sent for 50 defIds, engine survived {frames.Length} frames, anyCreated={anyCreated}")
        Assert.True(frames.Length >= 100, $"Engine should survive BuildCommand, ran {frames.Length} frames")

    [<Fact>]
    [<Priority(4)>]
    member _.``T3.4 Spawn builder then issue RepairCommand on building, verify acceptance``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        // Spawn a builder and a building
        let builderDefId = engine.BuilderDefId
        let buildingDefId = engine.BuildingDefId
        let createdIds = ResizeArray<int>()

        engine.RunFrames(20, fun frame idx ->
            for ev in frame.Events do
                match ev with
                | GameEvent.UnitCreated(cuid, _) -> createdIds.Add(cuid)
                | _ -> ()

            if idx = 0 then
                [ GiveMeNewUnitCommand builderDefId 1536.0f 100.0f 4096.0f
                  GiveMeNewUnitCommand buildingDefId 1536.0f 100.0f 4200.0f ]
            else []
        ) |> ignore

        Assert.True(createdIds.Count >= 2, $"Expected 2 units (builder + building), got {createdIds.Count}")

        let builderId = createdIds.[0]
        let buildingId = createdIds.[1]

        // Issue RepairCommand from builder to building
        let (frames, _) = engine.RunFrames(50, fun _ idx ->
            if idx = 0 then
                [ RepairCommand builderId buildingId ]
            else []
        )

        engine.ThrowIfEngineCrashed()
        output.WriteLine($"RepairCommand: builder={builderId} → building={buildingId}, ran {frames.Length} frames")
        Assert.True(frames.Length >= 50, "Engine should survive RepairCommand")
