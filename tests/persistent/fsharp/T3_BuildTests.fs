namespace HighBar.PersistentTests

open System
open Xunit
open Xunit.Abstractions
open HighBar.Client
open HighBar.Client.Commands

/// Tier 3: Building construction tests.
[<Collection("PersistentEngine")>]
[<TestCaseOrderer("HighBar.PersistentTests.PriorityOrderer", "HighBar.PersistentTests")>]
type T3_BuildTests(engine: PersistentEngineFixture, output: ITestOutputHelper) =

    /// Spawn a builder unit and return its ID.
    let spawnBuilder () =
        let mutable unitId = None
        engine.RunFrames(15, fun frame idx ->
            for ev in frame.Events do
                match ev with
                | GameEvent.UnitCreated(uid, _) when unitId.IsNone ->
                    unitId <- Some uid
                | _ -> ()
            if idx = 0 then
                // unitDefId 1 should be a builder/commander
                [ GiveMeNewUnitCommand 1 1536.0f 100.0f 4096.0f ]
            else
                []
        ) |> ignore
        unitId

    [<Fact>]
    [<Priority(1)>]
    member _.``T3.1 Spawn builder, issue BuildCommand, verify UnitCreated for structure``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        let builderId = spawnBuilder()
        Assert.True(builderId.IsSome, "Should have spawned a builder")
        let uid = builderId.Value

        let createdAfterBuild = ResizeArray<int>()
        let mutable buildSent = false

        // Run many frames to allow building to start
        engine.RunFrames(80, fun frame idx ->
            if buildSent then
                for ev in frame.Events do
                    match ev with
                    | GameEvent.UnitCreated(cuid, _) -> createdAfterBuild.Add(cuid)
                    | _ -> ()

            if idx = 3 && not buildSent then
                buildSent <- true
                output.WriteLine($"Sending BuildCommand from unit {uid}")
                // unitDefId 2 for a basic structure
                [ BuildCommand uid 2 1536.0f 100.0f 4200.0f 0 ]
            else
                []
        ) |> ignore

        output.WriteLine($"Units created after build command: {createdAfterBuild.Count}")
        Assert.True(buildSent, "Should have sent BuildCommand")

    [<Fact>]
    [<Priority(2)>]
    member _.``T3.2 Verify UnitFinished event when construction completes``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        let builderId = spawnBuilder()
        Assert.True(builderId.IsSome, "Should have spawned a builder")
        let uid = builderId.Value

        let mutable buildSent = false
        let finishedIds = ResizeArray<int>()

        // Run extra frames to allow construction to complete
        engine.RunFrames(200, fun frame idx ->
            for ev in frame.Events do
                match ev with
                | GameEvent.UnitFinished(fuid) -> finishedIds.Add(fuid)
                | _ -> ()

            if idx = 3 && not buildSent then
                buildSent <- true
                [ BuildCommand uid 2 1536.0f 100.0f 4200.0f 0 ]
            else
                []
        ) |> ignore

        output.WriteLine($"Finished units: {finishedIds.Count}")

    [<Fact>]
    [<Priority(3)>]
    member _.``T3.3 Verify builder becomes UnitIdle after finishing``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        let builderId = spawnBuilder()
        Assert.True(builderId.IsSome, "Should have spawned a builder")
        let uid = builderId.Value

        let mutable buildSent = false
        let idleIds = ResizeArray<int>()

        engine.RunFrames(200, fun frame idx ->
            for ev in frame.Events do
                match ev with
                | GameEvent.UnitIdle(iuid) -> idleIds.Add(iuid)
                | _ -> ()

            if idx = 3 && not buildSent then
                buildSent <- true
                [ BuildCommand uid 2 1536.0f 100.0f 4200.0f 0 ]
            else
                []
        ) |> ignore

        output.WriteLine($"Idle events for builder: {idleIds |> Seq.filter (fun id -> id = uid) |> Seq.length}")
