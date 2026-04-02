namespace HighBar.Tests

open System
open Xunit
open HighBar.Client
open HighBar.Client.Commands

/// Multi-step integration scenario tests.
/// Validates full AI turn sequences combining connection, events, and commands.
[<Collection("Engine")>]
type ScenarioTests(engine: EngineFixture) =

    /// T030B: Full AI turn sequence -- connect, handshake, receive UnitCreated for builder,
    /// send MoveCommand to a location, send BuildCommand for a structure, verify events,
    /// send StopCommand. Validates the "integration scenarios" layer.
    [<Fact>]
    [<Trait("Category", "Scenarios")>]
    member _.``Full AI turn sequence - move build stop``() =
        use client = new HighBarClient(engine.SocketPath)
        client.Connect()
        let hs = client.Handshake()

        // Track scenario state
        let mutable builderUnitId = None
        let mutable phase = 0 // 0=wait for unit, 1=move, 2=build, 3=stop, 4=done
        let mutable stepsCompleted = ResizeArray<string>()
        let mutable frameIdx = 0

        try
            client.Run(fun frame ->
                frameIdx <- frameIdx + 1

                // Phase 0: Wait for builder unit
                if builderUnitId.IsNone then
                    match frame.Events |> List.tryPick (function
                        | GameEvent.UnitCreated(uid, _) -> Some uid
                        | _ -> None) with
                    | Some uid ->
                        builderUnitId <- Some uid
                        stepsCompleted.Add("unit_found")
                        phase <- 1
                    | None -> ()

                let cmds =
                    match builderUnitId, phase with
                    // Phase 1: Move to build location
                    | Some uid, 1 ->
                        phase <- 2
                        stepsCompleted.Add("move_sent")
                        [ MoveCommand uid 800.0f 100.0f 800.0f ]

                    // Phase 2: Wait a few frames, then send build command
                    | Some uid, 2 when frameIdx >= 15 ->
                        phase <- 3
                        stepsCompleted.Add("build_sent")
                        [ BuildCommand uid 1 800.0f 100.0f 800.0f 0 ]

                    // Phase 3: Wait a few frames, then stop
                    | Some uid, 3 when frameIdx >= 25 ->
                        phase <- 4
                        stepsCompleted.Add("stop_sent")
                        [ Commands.StopCommand uid ]

                    // Phase 4: Done
                    | _, 4 when frameIdx >= 30 ->
                        stepsCompleted.Add("scenario_complete")
                        failwith "CAPTURED_ENOUGH"

                    | _ -> []

                cmds
            )
        with
        | ex when ex.Message = "CAPTURED_ENOUGH" -> ()

        client.Disconnect()

        // Verify all steps completed
        Assert.True(stepsCompleted.Contains("unit_found"),
            "Should have found a builder unit")
        Assert.True(stepsCompleted.Contains("move_sent"),
            "Should have sent MoveCommand")
        Assert.True(stepsCompleted.Contains("build_sent"),
            "Should have sent BuildCommand")
        Assert.True(stepsCompleted.Contains("stop_sent"),
            "Should have sent StopCommand")
        Assert.True(stepsCompleted.Contains("scenario_complete"),
            "Scenario should have completed all phases")

        // Verify handshake was valid
        Assert.Equal(1u, hs.ProtocolVersion)
        Assert.True(hs.TeamId >= 0)
