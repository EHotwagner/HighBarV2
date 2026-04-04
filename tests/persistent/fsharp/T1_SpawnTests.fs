namespace HighBar.PersistentTests

open System
open Xunit
open Xunit.Abstractions
open HighBar.Client
open HighBar.Client.Commands

/// Tier 1: Unit spawning tests via GiveMeNewUnitCommand.
[<Collection("PersistentEngine")>]
[<TestCaseOrderer("HighBar.PersistentTests.PriorityOrderer", "HighBar.PersistentTests")>]
type T1_SpawnTests(engine: PersistentEngineFixture, output: ITestOutputHelper) =

    [<Fact>]
    [<Priority(1)>]
    member _.``T1.1 Spawn a unit and verify UnitCreated event``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        let mutable createdUnitId = None
        let (_, events) = engine.RunFrames(20, fun frame idx ->
            if idx = 0 then
                [ GiveMeNewUnitCommand engine.MobileUnitDefId 1536.0f 100.0f 4096.0f ]
            else
                for ev in frame.Events do
                    match ev with
                    | GameEvent.UnitCreated(uid, _) when createdUnitId.IsNone ->
                        createdUnitId <- Some uid
                    | _ -> ()
                []
        )

        output.WriteLine($"Created unit ID: {createdUnitId}")
        Assert.True(createdUnitId.IsSome, "Should have received UnitCreated event after spawning")

    [<Fact>]
    [<Priority(2)>]
    member _.``T1.2 Spawn multiple units and verify correct count``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        let spawnCount = 3
        let createdIds = ResizeArray<int>()

        engine.RunFrames(30, fun frame idx ->
            for ev in frame.Events do
                match ev with
                | GameEvent.UnitCreated(uid, _) -> createdIds.Add(uid)
                | _ -> ()

            if idx = 0 then
                let defId = engine.MobileUnitDefId
                [ for i in 0..spawnCount-1 ->
                    GiveMeNewUnitCommand defId (1536.0f + float32 i * 100.0f) 100.0f 4096.0f ]
            else
                []
        ) |> ignore

        let idList = createdIds |> Seq.map string |> String.concat ", "
        output.WriteLine($"Spawned {createdIds.Count} units: {idList}")
        Assert.True(
            createdIds.Count >= spawnCount,
            $"Expected at least {spawnCount} UnitCreated events, got {createdIds.Count}")

    [<Fact>]
    [<Priority(3)>]
    member _.``T1.3 Spawn units at specific positions``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        // Spawn at two different positions
        let mutable created = 0
        engine.RunFrames(20, fun frame idx ->
            for ev in frame.Events do
                match ev with
                | GameEvent.UnitCreated _ -> created <- created + 1
                | _ -> ()

            if idx = 0 then
                let defId = engine.MobileUnitDefId
                [ GiveMeNewUnitCommand defId 500.0f 100.0f 500.0f
                  GiveMeNewUnitCommand defId 4000.0f 100.0f 4000.0f ]
            else
                []
        ) |> ignore

        output.WriteLine($"Units created at different positions: {created}")
        Assert.True(created >= 2, $"Expected at least 2 units created, got {created}")

    [<Fact>]
    [<Priority(4)>]
    member _.``T1.4 Spawn different unit types``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        // Try spawning with different unitDefIds
        let mutable created = 0
        engine.RunFrames(20, fun frame idx ->
            for ev in frame.Events do
                match ev with
                | GameEvent.UnitCreated _ -> created <- created + 1
                | _ -> ()

            if idx = 0 then
                [ GiveMeNewUnitCommand engine.MobileUnitDefId 1536.0f 100.0f 4000.0f
                  GiveMeNewUnitCommand engine.BuilderDefId 1636.0f 100.0f 4000.0f ]
            else
                []
        ) |> ignore

        output.WriteLine($"Different unit types created: {created}")
        Assert.True(created >= 1, $"Expected at least 1 unit created, got {created}")
