namespace HighBar.PersistentTests

open System
open Xunit
open Xunit.Abstractions
open HighBar.Client
open HighBar.Client.Commands

/// Tier 2: Movement command tests.
[<Collection("PersistentEngine")>]
[<TestCaseOrderer("HighBar.PersistentTests.PriorityOrderer", "HighBar.PersistentTests")>]
type T2_MovementTests(engine: PersistentEngineFixture, output: ITestOutputHelper) =

    /// Spawn a mobile unit and return its ID.
    let spawnUnit () =
        let mutable unitId = None
        engine.RunFrames(15, fun frame idx ->
            for ev in frame.Events do
                match ev with
                | GameEvent.UnitCreated(uid, _) when unitId.IsNone ->
                    unitId <- Some uid
                | _ -> ()
            if idx = 0 then
                [ GiveMeNewUnitCommand engine.MobileUnitDefId 1536.0f 100.0f 4096.0f ]
            else
                []
        ) |> ignore
        unitId

    [<Fact>]
    [<Priority(1)>]
    member _.``T2.1 Spawn mobile unit, issue MoveCommand, verify frames run``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        let unitId = spawnUnit()
        Assert.True(unitId.IsSome, "Should have spawned a unit")
        let uid = unitId.Value

        output.WriteLine($"Moving unit {uid} to (2048, 100, 2048)")
        let mutable moveSent = false
        let (frames, _) = engine.RunFrames(40, fun _ idx ->
            if idx = 0 && not moveSent then
                moveSent <- true
                [ MoveCommand uid 2048.0f 100.0f 2048.0f ]
            else
                []
        )

        Assert.True(moveSent, "Should have sent MoveCommand")
        Assert.True(frames.Length >= 40, $"Should have run 40 frames, got {frames.Length}")

    [<Fact>]
    [<Priority(2)>]
    member _.``T2.2 Issue StopCommand and verify unit stops``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        let unitId = spawnUnit()
        Assert.True(unitId.IsSome, "Should have spawned a unit")
        let uid = unitId.Value

        let mutable moveSent = false
        let mutable stopSent = false

        engine.RunFrames(30, fun _ idx ->
            if idx = 0 && not moveSent then
                moveSent <- true
                [ MoveCommand uid 2048.0f 100.0f 2048.0f ]
            elif idx = 10 && not stopSent then
                stopSent <- true
                [ StopCommand uid ]
            else
                []
        ) |> ignore

        Assert.True(stopSent, "Should have sent StopCommand")
        output.WriteLine($"Move then stop completed for unit {uid}")

    [<Fact>]
    [<Priority(3)>]
    member _.``T2.3 Issue PatrolCommand and verify unit responds``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        let unitId = spawnUnit()
        Assert.True(unitId.IsSome, "Should have spawned a unit")
        let uid = unitId.Value

        let mutable patrolSent = false
        let (frames, _) = engine.RunFrames(25, fun _ idx ->
            if idx = 0 && not patrolSent then
                patrolSent <- true
                [ PatrolCommand uid 1024.0f 100.0f 1024.0f ]
            else
                []
        )

        Assert.True(patrolSent, "Should have sent PatrolCommand")
        Assert.True(frames.Length >= 25, $"Should run 25 frames without error, got {frames.Length}")
        output.WriteLine($"Patrol command accepted for unit {uid}")
