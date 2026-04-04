namespace HighBar.AI.Tests

open Xunit

module EndToEndCriteria =

    /// SC-001: 100% completion rate — no crashes or stalls.
    let sc001 : ValidationCriterion =
        { Id = "SC-001"
          Description = "100% completion rate (no crashes/stalls)"
          Evaluate = fun outcomes ->
            outcomes |> List.forall (fun o ->
                o.Result <> GameResult.Crash && o.Result <> GameResult.Stall) }

    /// SC-002: 90%+ games have ≥3 mex and ≥2 energy within 5400 frames (3 min).
    let sc002 : ValidationCriterion =
        { Id = "SC-002"
          Description = "90%+ games bootstrap economy (≥3 mex, ≥2 energy in 3 min)"
          Evaluate = fun outcomes ->
            let passing =
                outcomes |> List.filter (fun o ->
                    o.MexBuiltCount >= 3 &&
                    o.EnergyBuiltCount >= 2 &&
                    o.MexFirstBuiltFrame |> Option.map (fun f -> f <= 5400) |> Option.defaultValue false)
            float passing.Length / float (max 1 outcomes.Length) >= 0.9 }

    /// SC-003: 90%+ games produce combat units from factory within 9000 frames (5 min).
    let sc003 : ValidationCriterion =
        { Id = "SC-003"
          Description = "90%+ games produce combat units within 5 min"
          Evaluate = fun outcomes ->
            let passing =
                outcomes |> List.filter (fun o ->
                    o.FirstCombatUnitFrame |> Option.map (fun f -> f <= 9000) |> Option.defaultValue false)
            float passing.Length / float (max 1 outcomes.Length) >= 0.9 }

    /// SC-004: 100% combat readiness — all games produce army from factory.
    let sc004 : ValidationCriterion =
        { Id = "SC-004"
          Description = "100% combat readiness (all games produce combat units)"
          Evaluate = fun outcomes ->
            outcomes |> List.forall (fun o -> o.FirstCombatUnitFrame.IsSome) }

    let all = [ sc001; sc002; sc003; sc004 ]


[<Collection("AIEndToEnd")>]
type EndToEndValidationTests(fixture: HeadlessAiFixture) =

    [<Fact>]
    [<Trait("Category", "EndToEnd")>]
    member _.``Single game smoke test`` () =
        let outcomes = fixture.RunGames(1, "game-setup-e2e.txt", maxFrames = 18000)
        Assert.Single(outcomes) |> ignore
        let o = outcomes.Head
        Assert.NotEqual(GameResult.Crash, o.Result)
        Assert.True(o.DurationFrames > 0, "Game should run at least 1 frame")

    [<Fact>]
    [<Trait("Category", "EndToEnd")>]
    member _.``10-game end-to-end validation`` () =
        let outcomes = fixture.RunGames(10, "game-setup-e2e.txt", maxFrames = 18000)
        let report = ValidationReportGen.buildValidationReport "End-to-End vs NullAI" outcomes EndToEndCriteria.all
        let content = ValidationReportGen.generateValidationReport report
        ValidationReportGen.writeReport fixture.ReportsDir "e2e-validation" content |> ignore
        Assert.True(report.OverallPass, $"End-to-end validation failed. See report for details.")
