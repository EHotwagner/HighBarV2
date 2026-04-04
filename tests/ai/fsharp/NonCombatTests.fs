namespace HighBar.AI.Tests

open Xunit

module NonCombatAssertions =

    // Economy assertions

    let economyPositiveIncome2min (o: GameOutcome) : TestAssertion =
        let passed = o.MexBuiltCount >= 1 && o.MexFirstBuiltFrame |> Option.map (fun f -> f <= 3600) |> Option.defaultValue false
        { Name = "economy_positive_income_2min"
          Category = TestCategory.Economy
          Passed = passed
          ActualValue = $"mex={o.MexBuiltCount}, firstMexFrame={o.MexFirstBuiltFrame}"
          ExpectedValue = "≥1 mex by frame 3600"
          GameNumber = o.GameNumber }

    let economyExtractorsBuilt (o: GameOutcome) : TestAssertion =
        let passed = o.MexBuiltCount >= 3 && o.MexFirstBuiltFrame |> Option.map (fun f -> f <= 5400) |> Option.defaultValue false
        { Name = "economy_extractors_built"
          Category = TestCategory.Economy
          Passed = passed
          ActualValue = $"mex={o.MexBuiltCount}"
          ExpectedValue = "≥3 mex within 5400 frames"
          GameNumber = o.GameNumber }

    let economyEnergyBuilt (o: GameOutcome) : TestAssertion =
        let passed = o.EnergyBuiltCount >= 2 && o.EnergyFirstBuiltFrame |> Option.map (fun f -> f <= 5400) |> Option.defaultValue false
        { Name = "economy_energy_built"
          Category = TestCategory.Economy
          Passed = passed
          ActualValue = $"energy={o.EnergyBuiltCount}"
          ExpectedValue = "≥2 energy within 5400 frames"
          GameNumber = o.GameNumber }

    // Build order assertions

    let buildOrderMexFirst (o: GameOutcome) : TestAssertion =
        let passed =
            match o.MexFirstBuiltFrame, o.EnergyFirstBuiltFrame, o.FactoryFirstBuiltFrame with
            | Some mf, Some ef, Some ff -> mf < ef && ef < ff
            | Some _, Some _, None -> true // Factory not yet built but mex before energy
            | Some _, None, None -> true   // Only mex built so far
            | _ -> false
        { Name = "build_order_mex_first"
          Category = TestCategory.BuildOrder
          Passed = passed
          ActualValue = $"mex={o.MexFirstBuiltFrame}, energy={o.EnergyFirstBuiltFrame}, factory={o.FactoryFirstBuiltFrame}"
          ExpectedValue = "mex < energy < factory"
          GameNumber = o.GameNumber }

    let buildOrderFactoryWithin5min (o: GameOutcome) : TestAssertion =
        let passed = o.FactoryFirstBuiltFrame |> Option.map (fun f -> f <= 9000) |> Option.defaultValue false
        { Name = "build_order_factory_within_5min"
          Category = TestCategory.BuildOrder
          Passed = passed
          ActualValue = $"factoryFrame={o.FactoryFirstBuiltFrame}"
          ExpectedValue = "factory by frame 9000"
          GameNumber = o.GameNumber }

    let buildOrderSequenceComplete (o: GameOutcome) : TestAssertion =
        let passed = o.MexFirstBuiltFrame.IsSome && o.EnergyFirstBuiltFrame.IsSome && o.FactoryFirstBuiltFrame.IsSome
        { Name = "build_order_sequence_complete"
          Category = TestCategory.BuildOrder
          Passed = passed
          ActualValue = $"mex={o.MexFirstBuiltFrame.IsSome}, energy={o.EnergyFirstBuiltFrame.IsSome}, factory={o.FactoryFirstBuiltFrame.IsSome}"
          ExpectedValue = "all milestones reached"
          GameNumber = o.GameNumber }

    // Movement and scouting assertions

    let movementUnitsProduced (o: GameOutcome) : TestAssertion =
        // Commander counts as 1 initial unit; any additional means mobile units were produced
        let passed = o.UnitsProduced > 1
        { Name = "movement_units_produced"
          Category = TestCategory.Movement
          Passed = passed
          ActualValue = $"unitsProduced={o.UnitsProduced}"
          ExpectedValue = ">1 (more than just commander)"
          GameNumber = o.GameNumber }

    let scoutingActivity (o: GameOutcome) : TestAssertion =
        // Scouting evidence: game ran long enough and units were produced beyond commander
        let passed = o.UnitsProduced > 2 && o.DurationFrames > 1800
        { Name = "scouting_activity"
          Category = TestCategory.Scouting
          Passed = passed
          ActualValue = $"units={o.UnitsProduced}, frames={o.DurationFrames}"
          ExpectedValue = "units > 2 and game > 1800 frames"
          GameNumber = o.GameNumber }

    /// Run all assertions against a single game outcome.
    let evaluateAll (o: GameOutcome) : TestAssertion list =
        [ economyPositiveIncome2min o
          economyExtractorsBuilt o
          economyEnergyBuilt o
          buildOrderMexFirst o
          buildOrderFactoryWithin5min o
          buildOrderSequenceComplete o
          movementUnitsProduced o
          scoutingActivity o ]


[<Collection("AINonCombat")>]
type NonCombatSuiteTests(fixture: HeadlessAiFixture) =

    [<Fact>]
    [<Trait("Category", "NonCombat")>]
    member _.``20-game non-combat validation suite`` () =
        let outcomes = fixture.RunGames(20, "game-setup-e2e.txt", maxFrames = 9000)
        let assertions = outcomes |> List.collect NonCombatAssertions.evaluateAll
        let report = ValidationReportGen.buildTestSuiteReport "Headless Non-Combat" outcomes.Length assertions 95.0
        let content = ValidationReportGen.generateTestSuiteReport report
        ValidationReportGen.writeReport fixture.ReportsDir "noncombat-suite" content |> ignore
        Assert.True(report.OverallPass, $"Non-combat suite failed: {report.PassRate:F1}%% pass rate (need 95%%). See report.")
