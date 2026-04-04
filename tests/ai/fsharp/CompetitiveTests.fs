namespace HighBar.AI.Tests

open System
open Xunit

module CompetitiveCriteria =

    /// SC-005: 80%+ games survive ≥15 minutes.
    let sc005 : ValidationCriterion =
        { Id = "SC-005"
          Description = "80%+ games survive ≥15 minutes"
          Evaluate = fun outcomes ->
            let validGames =
                outcomes |> List.filter (fun o ->
                    o.Result <> GameResult.Crash && o.Result <> GameResult.Stall)
            let surviving =
                validGames |> List.filter (fun o -> o.DurationMinutes >= 15.0)
            float surviving.Length / float (max 1 validGames.Length) >= 0.8 }

    /// Infrastructure: 100% games launch without crashes.
    let infrastructure : ValidationCriterion =
        { Id = "SC-INFRA"
          Description = "100% games launch without infrastructure failures"
          Evaluate = fun outcomes ->
            outcomes |> List.forall (fun o -> o.Result <> GameResult.Crash) }

    let all = [ sc005; infrastructure ]


[<Collection("AICompetitive")>]
type CompetitiveValidationTests(fixture: LiveAiFixture) =

    [<Fact(Skip = "Requires DISPLAY and BARb installed")>]
    [<Trait("Category", "Competitive")>]
    member _.``Single game competitive smoke test`` () =
        if not fixture.IsAvailable then
            Assert.Fail("Live engine tests require DISPLAY (run Xvfb or set DISPLAY)")
        let outcomes = fixture.RunGames(1, "game-setup-barb.txt")
        Assert.Single(outcomes) |> ignore
        let o = outcomes.Head
        Assert.NotEqual(GameResult.Crash, o.Result)

    [<Fact(Skip = "Requires DISPLAY and BARb installed")>]
    [<Trait("Category", "Competitive")>]
    member _.``10-game competitive validation vs BARb`` () =
        if not fixture.IsAvailable then
            Assert.Fail("Live engine tests require DISPLAY (run Xvfb or set DISPLAY)")
        let outcomes = fixture.RunGames(10, "game-setup-barb.txt")
        let report = ValidationReportGen.buildValidationReport "Competitive vs BARb" outcomes CompetitiveCriteria.all
        let content = ValidationReportGen.generateValidationReport report
        ValidationReportGen.writeReport fixture.ReportsDir "competitive-validation" content |> ignore
        Assert.True(report.OverallPass, "Competitive validation failed. See report for details.")
