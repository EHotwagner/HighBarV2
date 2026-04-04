namespace HighBar.AI.Tests

open System
open Xunit

module CombatAssertions =

    let combatUnitsDestroyed (o: GameOutcome) : TestAssertion =
        let passed = o.EnemyDestroyedCount > 0
        { Name = "combat_units_destroyed"
          Category = TestCategory.Combat
          Passed = passed
          ActualValue = $"enemyDestroyed={o.EnemyDestroyedCount}"
          ExpectedValue = ">0"
          GameNumber = o.GameNumber }

    let combatOccurred (o: GameOutcome) : TestAssertion =
        let passed = o.UnitDestroyedCount > 0 || o.EnemyDestroyedCount > 0
        { Name = "combat_units_lost_nonzero"
          Category = TestCategory.Combat
          Passed = passed
          ActualValue = $"ours={o.UnitDestroyedCount}, enemy={o.EnemyDestroyedCount}"
          ExpectedValue = "at least one side took casualties"
          GameNumber = o.GameNumber }

    let combatGameCompleted (o: GameOutcome) : TestAssertion =
        let passed = o.Result = GameResult.Win || o.Result = GameResult.Loss
        { Name = "combat_game_completed"
          Category = TestCategory.Combat
          Passed = passed
          ActualValue = $"{o.Result}"
          ExpectedValue = "Win or Loss"
          GameNumber = o.GameNumber }

    let combatWeaponFired (o: GameOutcome) : TestAssertion =
        let passed = o.WeaponFiredCount > 0
        { Name = "combat_weapon_fired"
          Category = TestCategory.Combat
          Passed = passed
          ActualValue = $"weaponFired={o.WeaponFiredCount}"
          ExpectedValue = ">0"
          GameNumber = o.GameNumber }

    let combatDamageEvents (o: GameOutcome) : TestAssertion =
        let passed = o.UnitDamagedCount > 0 || o.EnemyDamagedCount > 0
        { Name = "combat_damage_events"
          Category = TestCategory.Combat
          Passed = passed
          ActualValue = $"unitDamaged={o.UnitDamagedCount}, enemyDamaged={o.EnemyDamagedCount}"
          ExpectedValue = "damage > 0"
          GameNumber = o.GameNumber }

    let combatMilitaryEngagement (o: GameOutcome) : TestAssertion =
        let passed = o.EnemyDestroyedCount > 0
        { Name = "combat_military_engagement"
          Category = TestCategory.Combat
          Passed = passed
          ActualValue = $"enemyDestroyed={o.EnemyDestroyedCount}"
          ExpectedValue = ">0"
          GameNumber = o.GameNumber }

    /// Run all combat assertions against a single game outcome.
    let evaluateAll (o: GameOutcome) : TestAssertion list =
        [ combatUnitsDestroyed o
          combatOccurred o
          combatGameCompleted o
          combatWeaponFired o
          combatDamageEvents o
          combatMilitaryEngagement o ]


[<Collection("AICombat")>]
type CombatSuiteTests(fixture: LiveAiFixture) =

    [<Fact(Skip = "Requires DISPLAY and BARb installed")>]
    [<Trait("Category", "Combat")>]
    member _.``10-game combat validation suite`` () =
        if not fixture.IsAvailable then
            Assert.Fail("Live engine tests require DISPLAY (run Xvfb or set DISPLAY)")
        let outcomes = fixture.RunGames(10, "game-setup-barb.txt")
        let assertions = outcomes |> List.collect CombatAssertions.evaluateAll
        let report = ValidationReportGen.buildTestSuiteReport "Live Combat" outcomes.Length assertions 90.0
        let content = ValidationReportGen.generateTestSuiteReport report
        ValidationReportGen.writeReport fixture.ReportsDir "combat-suite" content |> ignore
        Assert.True(report.OverallPass, $"Combat suite failed: {report.PassRate:F1}%% pass rate (need 90%%). See report.")
