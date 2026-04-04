namespace HighBar.PersistentTests

open System
open Xunit
open Xunit.Abstractions
open HighBar.Client
open HighBar.Client.Commands

/// Simple test: spawn commander, check position, send MoveCommand, check position changed.
[<Collection("PersistentEngine")>]
[<TestCaseOrderer("HighBar.PersistentTests.PriorityOrderer", "HighBar.PersistentTests")>]
type T2b_MoveVerifyTest(engine: PersistentEngineFixture, output: ITestOutputHelper) =

    [<Fact>]
    [<Priority(99)>]
    member _.``Move verification - commander position actually changes after MoveCommand``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        // Step 1: Spawn a mobile unit
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

        Assert.True(unitId.IsSome, "Should have spawned a unit")
        let uid = unitId.Value
        output.WriteLine($"Spawned unit {uid}")

        // Step 2: Get initial position
        let (x0, y0, z0) = engine.Client.GetUnitPos(uid)
        output.WriteLine($"Initial position: ({x0}, {y0}, {z0})")

        // Step 3: Send MoveCommand to a distant location
        let targetX = 4096.0f
        let targetZ = 2048.0f
        output.WriteLine($"Sending MoveCommand to ({targetX}, 100, {targetZ})")

        let mutable moveSent = false
        engine.RunFrames(120, fun _ idx ->
            if idx = 0 && not moveSent then
                moveSent <- true
                [ MoveCommand uid targetX 100.0f targetZ ]
            else
                []
        ) |> ignore

        // Step 4: Get position after 120 frames (~4 seconds at 30fps)
        let (x1, y1, z1) = engine.Client.GetUnitPos(uid)
        output.WriteLine($"Position after move: ({x1}, {y1}, {z1})")

        let dx = x1 - x0
        let dz = z1 - z0
        let distance = MathF.Sqrt(dx * dx + dz * dz)
        output.WriteLine($"Distance moved: {distance}")

        // Step 5: Assert the unit actually moved
        Assert.True(distance > 10.0f, $"Unit should have moved significantly. Start=({x0},{z0}) End=({x1},{z1}) Distance={distance}")
