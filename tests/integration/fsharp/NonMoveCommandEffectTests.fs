namespace HighBar.Tests

open System
open Xunit
open HighBar.Client
open HighBar.Client.Commands
open Highbar

/// 029 Issue 1 — FR-016: non-Move commands must produce observable in-engine effect.
/// These tests assert effect (position delta, stop), not just engine survival.
[<Collection("Engine")>]
type NonMoveCommandEffectTests(engine: EngineFixture) =

    let runWithCommands (maxFrames: int) (onFrame: GameFrame -> int -> Highbar.AICommand list) =
        let client = engine.Client
        let mutable frameIdx = 0
        try
            client.Run(fun frame ->
                let cmds = onFrame frame frameIdx
                frameIdx <- frameIdx + 1
                if frameIdx >= maxFrames then failwith "CAPTURED_ENOUGH"
                cmds
            )
        with ex when ex.Message = "CAPTURED_ENOUGH" -> ()

    let getFirstUnitId () =
        engine.InitialEvents
        |> List.tryPick (function
            | GameEvent.UnitCreated(uid, _) -> Some uid
            | _ -> None)

    let distance (x0, _, z0) (x1, _, z1) =
        let dx = x1 - x0
        let dz = z1 - z0
        MathF.Sqrt(dx * dx + dz * dz)

    /// Baseline: MoveCommand is the known-working command. If this fails, the
    /// test infrastructure itself is broken.
    [<Fact>]
    [<Trait("Category", "NonMoveEffect")>]
    member _.``T029.baseline MoveCommand moves unit``() =
        let unitId = getFirstUnitId()
        Assert.True(unitId.IsSome, "Should have found a unit from warm-up events")
        let uid = unitId.Value

        let client = engine.Client
        let posBefore = client.GetUnitPos(uid)
        runWithCommands 60 (fun _ idx ->
            if idx = 0 then [ MoveCommand uid 3500.0f 100.0f 3500.0f ]
            else []
        )
        let posAfter = client.GetUnitPos(uid)
        let d = distance posBefore posAfter
        Assert.True(d > 10.0f,
            $"MoveCommand baseline: expected unit to move >10 elmos, moved {d}. " +
            $"before={posBefore}, after={posAfter}")

    /// FR-016: AttackCommand on a self-target should at minimum not block
    /// the unit from future commands. We first send Attack, then Move, and
    /// verify Move still works. This diagnoses whether AttackCommand corrupts
    /// the unit's command queue (the findings claim it does, silently).
    [<Fact>]
    [<Trait("Category", "NonMoveEffect")>]
    member _.``T029.4a AttackCommand self-target then Move still moves``() =
        let unitId = getFirstUnitId()
        Assert.True(unitId.IsSome, "Should have found a unit from warm-up events")
        let uid = unitId.Value

        let client = engine.Client
        let posBefore = client.GetUnitPos(uid)
        runWithCommands 60 (fun _ idx ->
            if idx = 0 then [ Commands.AttackCommand uid uid ]
            elif idx = 5 then [ MoveCommand uid 3500.0f 100.0f 3500.0f ]
            else []
        )
        let posAfter = client.GetUnitPos(uid)
        let d = distance posBefore posAfter
        Assert.True(d > 10.0f,
            $"After AttackCommand(self) + MoveCommand: expected unit to move >10 elmos, moved {d}. " +
            $"before={posBefore}, after={posAfter}")

    /// FR-016: FightCommand should move the unit toward the destination.
    [<Fact>]
    [<Trait("Category", "NonMoveEffect")>]
    member _.``T029.5 FightCommand moves unit to destination``() =
        let unitId = getFirstUnitId()
        Assert.True(unitId.IsSome, "Should have found a unit from warm-up events")
        let uid = unitId.Value

        let client = engine.Client
        let posBefore = client.GetUnitPos(uid)
        runWithCommands 60 (fun _ idx ->
            if idx = 0 then [ Commands.FightCommand uid 3500.0f 100.0f 3500.0f ]
            else []
        )
        let posAfter = client.GetUnitPos(uid)
        let d = distance posBefore posAfter
        Assert.True(d > 10.0f,
            $"FightCommand: expected unit to move >10 elmos, moved {d}. " +
            $"before={posBefore}, after={posAfter}")

    /// FR-016: PatrolCommand should move the unit toward the patrol point.
    [<Fact>]
    [<Trait("Category", "NonMoveEffect")>]
    member _.``T029.6 PatrolCommand moves unit toward patrol point``() =
        let unitId = getFirstUnitId()
        Assert.True(unitId.IsSome, "Should have found a unit from warm-up events")
        let uid = unitId.Value

        let client = engine.Client
        let posBefore = client.GetUnitPos(uid)
        runWithCommands 60 (fun _ idx ->
            if idx = 0 then [ Commands.PatrolCommand uid 3500.0f 100.0f 3500.0f ]
            else []
        )
        let posAfter = client.GetUnitPos(uid)
        let d = distance posBefore posAfter
        Assert.True(d > 10.0f,
            $"PatrolCommand: expected unit to move >10 elmos, moved {d}. " +
            $"before={posBefore}, after={posAfter}")

    /// FR-016: StopCommand halts a moving unit within a bounded distance.
    [<Fact>]
    [<Trait("Category", "NonMoveEffect")>]
    member _.``T029.9 StopCommand halts a moving unit``() =
        let unitId = getFirstUnitId()
        Assert.True(unitId.IsSome, "Should have found a unit from warm-up events")
        let uid = unitId.Value

        let client = engine.Client
        // Phase 1: start moving
        runWithCommands 20 (fun _ idx ->
            if idx = 0 then [ MoveCommand uid 3500.0f 100.0f 3500.0f ]
            else []
        )
        // Phase 2: stop and measure position stability
        let posAtStop = client.GetUnitPos(uid)
        runWithCommands 80 (fun _ idx ->
            if idx = 0 then [ Commands.StopCommand uid ]
            else []
        )
        let posFinal = client.GetUnitPos(uid)
        let d = distance posAtStop posFinal
        Assert.True(d < 200.0f,
            $"StopCommand: unit should have stopped within ~200 elmos of stop point, " +
            $"moved {d}. stop={posAtStop}, final={posFinal}")
