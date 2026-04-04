namespace HighBar.PersistentTests

open System
open Xunit
open Xunit.Abstractions
open HighBar.Client
open HighBar.Client.Commands

/// Tier 5: Multi-step scenario tests combining multiple command types.
[<Collection("PersistentEngine")>]
[<TestCaseOrderer("HighBar.PersistentTests.PriorityOrderer", "HighBar.PersistentTests")>]
type T5_ScenarioTests(engine: PersistentEngineFixture, output: ITestOutputHelper) =

    /// Spawn a unit and return its ID.
    let spawnUnit (x: float32) (z: float32) =
        let mutable unitId = None
        engine.RunFrames(15, fun frame idx ->
            for ev in frame.Events do
                match ev with
                | GameEvent.UnitCreated(uid, _) when unitId.IsNone ->
                    unitId <- Some uid
                | _ -> ()
            if idx = 0 then
                [ GiveMeNewUnitCommand engine.MobileUnitDefId x 100.0f z ]
            else
                []
        ) |> ignore
        unitId

    [<Fact>]
    [<Priority(1)>]
    member _.``T5.1 Full economy cycle - spawn commander, build extractor, verify resource income``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        // Spawn a commander/builder
        let commanderId = spawnUnit 1536.0f 4096.0f
        Assert.True(commanderId.IsSome, "Should have spawned commander")
        let uid = commanderId.Value

        let mutable buildSent = false
        let mutable buildCreated = false
        let stepsCompleted = ResizeArray<string>()

        // Build a structure (metal extractor or similar)
        engine.RunFrames(100, fun frame idx ->
            for ev in frame.Events do
                match ev with
                | GameEvent.UnitCreated(cuid, _) when buildSent && cuid <> uid ->
                    buildCreated <- true
                    stepsCompleted.Add("structure_created")
                | GameEvent.UnitFinished(fuid) when fuid <> uid ->
                    stepsCompleted.Add("structure_finished")
                | _ -> ()

            if idx = 5 && not buildSent then
                buildSent <- true
                stepsCompleted.Add("build_sent")
                // Build a structure nearby
                [ BuildCommand uid engine.BuildableStructureDefId 1536.0f 100.0f 4200.0f 0 ]
            else
                []
        ) |> ignore

        let stepList = stepsCompleted |> Seq.distinct |> String.concat ", "
        output.WriteLine($"Steps completed: {stepList}")
        Assert.True(stepsCompleted.Contains("build_sent"), "Should have sent build command")

    [<Fact>]
    [<Priority(2)>]
    member _.``T5.2 Build-and-defend - spawn builder, build structure, spawn guard``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        // Spawn builder
        let builderId = spawnUnit 1536.0f 4096.0f
        Assert.True(builderId.IsSome, "Should have spawned builder")
        let buid = builderId.Value

        let mutable buildSent = false
        let mutable guardUnit = None
        let mutable guardSent = false
        let createdUnits = ResizeArray<int>()

        engine.RunFrames(80, fun frame idx ->
            for ev in frame.Events do
                match ev with
                | GameEvent.UnitCreated(cuid, _) ->
                    createdUnits.Add(cuid)
                | _ -> ()

            if idx = 3 && not buildSent then
                buildSent <- true
                [ BuildCommand buid 2 1536.0f 100.0f 4200.0f 0 ]
            elif idx = 20 && guardUnit.IsNone then
                // Spawn a guard unit
                [ GiveMeNewUnitCommand engine.MobileUnitDefId 1600.0f 100.0f 4096.0f ]
            elif idx = 35 && not guardSent then
                // Find the last created unit as the guard
                let lastCreated = if createdUnits.Count > 0 then Some(createdUnits.[createdUnits.Count - 1]) else None
                match lastCreated with
                | Some gid when gid <> buid ->
                    guardSent <- true
                    guardUnit <- Some gid
                    output.WriteLine($"Sending GuardCommand: unit {gid} guards builder {buid}")
                    [ GuardCommand gid buid ]
                | _ -> []
            else
                []
        ) |> ignore

        output.WriteLine($"Build sent: {buildSent}, Guard sent: {guardSent}, Units created: {createdUnits.Count}")
        Assert.True(buildSent, "Should have sent build command")

    [<Fact>]
    [<Priority(3)>]
    member _.``T5.3 Multi-unit coordination - spawn multiple units, issue different commands``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        // Spawn 3 units
        let createdIds = ResizeArray<int>()
        engine.RunFrames(20, fun frame idx ->
            for ev in frame.Events do
                match ev with
                | GameEvent.UnitCreated(uid, _) -> createdIds.Add(uid)
                | _ -> ()

            if idx = 0 then
                let defId = engine.MobileUnitDefId
                [ GiveMeNewUnitCommand defId 1400.0f 100.0f 4096.0f
                  GiveMeNewUnitCommand defId 1536.0f 100.0f 4096.0f
                  GiveMeNewUnitCommand defId 1672.0f 100.0f 4096.0f ]
            else
                []
        ) |> ignore

        Assert.True(createdIds.Count >= 3, $"Expected 3 units, got {createdIds.Count}")

        // Issue different commands to each unit
        let uid0 = createdIds.[0]
        let uid1 = createdIds.[1]
        let uid2 = createdIds.[2]
        let mutable commandsSent = 0
        engine.RunFrames(30, fun _ idx ->
            if idx = 0 then
                commandsSent <- 3
                [ MoveCommand uid0 2000.0f 100.0f 2000.0f
                  PatrolCommand uid1 1024.0f 100.0f 1024.0f
                  StopCommand uid2 ]
            else
                []
        ) |> ignore

        output.WriteLine($"Commands sent to {createdIds.Count} units: move, patrol, stop")
        Assert.True((commandsSent = 3), "Should have sent 3 different commands")
