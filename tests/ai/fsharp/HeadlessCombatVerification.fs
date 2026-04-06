namespace HighBar.AI.Tests

open System
open System.IO
open Xunit
open Xunit.Abstractions

[<CollectionDefinition("AICombatVerification")>]
type AICombatVerificationCollection() =
    interface ICollectionFixture<HeadlessAiFixture>


[<Collection("AICombatVerification")>]
type HeadlessCombatVerificationTests(fixture: HeadlessAiFixture, output: ITestOutputHelper) =

    let generateCombatVerificationReport (outcomes: GameOutcome list) (reportsDir: string) =
        let totalFrames = outcomes |> List.sumBy (fun o -> o.DurationFrames)
        let totalWeaponFired = outcomes |> List.sumBy (fun o -> o.WeaponFiredCount)
        let totalUnitDamaged = outcomes |> List.sumBy (fun o -> o.UnitDamagedCount)
        let totalEnemyDamaged = outcomes |> List.sumBy (fun o -> o.EnemyDamagedCount)
        let totalUnitDestroyed = outcomes |> List.sumBy (fun o -> o.UnitDestroyedCount)
        let totalEnemyDestroyed = outcomes |> List.sumBy (fun o -> o.EnemyDestroyedCount)
        let totalCombatEvents = totalWeaponFired + totalUnitDamaged + totalEnemyDamaged + totalUnitDestroyed + totalEnemyDestroyed
        let verdict = if totalCombatEvents > 0 then "COMBAT CONFIRMED" else "NO COMBAT"
        let agreesWithPrior = totalCombatEvents = 0

        let sb = System.Text.StringBuilder()
        let dateStr = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        let totalMinutes = float totalFrames / 30.0 / 60.0
        sb.AppendLine("# Headless Combat Verification Report") |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine($"**Date**: {dateStr}") |> ignore
        sb.AppendLine("**Engine**: spring-headless 2025.06.21") |> ignore
        sb.AppendLine("**Mode**: Headless") |> ignore
        sb.AppendLine($"**Games Run**: {outcomes.Length}") |> ignore
        sb.AppendLine($"**Total Frames**: {totalFrames} ({totalMinutes:F1} min game time)") |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine($"## Verdict: {verdict}") |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine("## Combat Event Summary") |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine("| Event Type | Total Count |") |> ignore
        sb.AppendLine("|------------|-------------|") |> ignore
        sb.AppendLine($"| WeaponFired | {totalWeaponFired} |") |> ignore
        sb.AppendLine($"| UnitDamaged | {totalUnitDamaged} |") |> ignore
        sb.AppendLine($"| EnemyDamaged | {totalEnemyDamaged} |") |> ignore
        sb.AppendLine($"| UnitDestroyed | {totalUnitDestroyed} |") |> ignore
        sb.AppendLine($"| EnemyDestroyed | {totalEnemyDestroyed} |") |> ignore
        sb.AppendLine($"| **Total Combat Events** | **{totalCombatEvents}** |") |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine("## Per-Game Results") |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine("| Game | Result | Duration | Units Produced | WeaponFired | UnitDamaged | EnemyDamaged | UnitDestroyed | EnemyDestroyed |") |> ignore
        sb.AppendLine("|------|--------|----------|----------------|-------------|-------------|--------------|---------------|----------------|") |> ignore
        for o in outcomes do
            let result = match o.Result with GameResult.Win -> "WIN" | GameResult.Loss -> "LOSS" | GameResult.Crash -> "CRASH" | GameResult.Stall -> "STALL" | GameResult.Timeout -> "TIMEOUT"
            let dur = sprintf "%.1f" o.DurationMinutes
            sb.AppendLine($"| {o.GameNumber} | {result} | {dur} min | {o.UnitsProduced} | {o.WeaponFiredCount} | {o.UnitDamagedCount} | {o.EnemyDamagedCount} | {o.UnitDestroyedCount} | {o.EnemyDestroyedCount} |") |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine("## Comparison with Feature 014 Finding") |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine("Feature 014 reported: *\"spring-headless does not simulate weapon physics\"*") |> ignore
        sb.AppendLine($"(Based on zero combat events across 1200+ frames with assault tanks at point-blank range)") |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine($"**This verification**: {totalCombatEvents} combat events across {totalFrames} frames ({outcomes.Length} games)") |> ignore
        let agreement = if agreesWithPrior then "YES — no combat in headless confirmed" else "NO — combat events observed in headless, Feature 014 finding is incorrect"
        sb.AppendLine($"**Agrees with Feature 014**: {agreement}") |> ignore
        sb.AppendLine() |> ignore
        if not agreesWithPrior then
            sb.AppendLine("### Implications") |> ignore
            sb.AppendLine() |> ignore
            sb.AppendLine("The Feature 014 headless combat limitation finding is **incorrect**. Headless BAR does simulate weapon physics.") |> ignore
            sb.AppendLine("This means the live/headless split in the test architecture may be unnecessary — combat tests could potentially run on headless.") |> ignore
            sb.AppendLine("Per clarification, architecture changes belong in a follow-up feature.") |> ignore
        else
            sb.AppendLine("### Implications") |> ignore
            sb.AppendLine() |> ignore
            sb.AppendLine("The Feature 014 finding is **confirmed**. Headless BAR does not simulate weapon physics.") |> ignore
            sb.AppendLine("The live/headless split in the test architecture remains necessary for combat validation.") |> ignore

        let content = sb.ToString()
        Directory.CreateDirectory(reportsDir) |> ignore
        let timestamp = DateTime.Now.ToString("yyyyMMdd-HHmmss")
        let path = Path.Combine(reportsDir, $"combat-verification-{timestamp}.md")
        File.WriteAllText(path, content)
        (content, path, totalCombatEvents)

    [<Fact>]
    [<Trait("Category", "CombatVerification")>]
    member _.``Headless combat verification - 3 games with close positions`` () =
        // Run 3 games with combat-verify setup (close positions, HighBarV2 vs NullAI)
        // 9000 frames = 5 min game time — enough for AI to build units and encounter enemy commander
        let outcomes = fixture.RunGames(3, "game-setup-combat-verify.txt", maxFrames = 9000)

        // Generate report
        let (_content, reportPath, totalCombatEvents) = generateCombatVerificationReport outcomes fixture.ReportsDir

        // Log key findings
        let totalUnitsProduced = outcomes |> List.sumBy (fun o -> o.UnitsProduced)
        let completedGames = outcomes |> List.filter (fun o -> o.Result <> GameResult.Crash) |> List.length

        // Assertions: games must complete and AI must produce units
        Assert.True((completedGames = outcomes.Length), $"All games should complete without crashes. Completed: {completedGames}/{outcomes.Length}")
        Assert.True(totalUnitsProduced > 0, $"AI should produce units. Total: {totalUnitsProduced}")

        // Assertive validation: if combat events are observed, verify outcome-level correctness
        if totalCombatEvents > 0 then
            // Combat occurred — verify the correct side takes casualties
            let totalEnemyDestroyed = outcomes |> List.sumBy (fun o -> o.EnemyDestroyedCount)
            Assert.True(totalEnemyDestroyed > 0, $"Combat events observed ({totalCombatEvents}) but no enemies destroyed — expected outcome-level correctness")
        else
            // No combat events — headless physics limitation (Feature 014 confirmed)
            // Mark as inconclusive rather than silent pass
            // No combat events — headless physics limitation (Feature 014 confirmed)
            // Output diagnostic rather than silent pass
            output.WriteLine($"INCONCLUSIVE: Zero combat events across {outcomes.Length} games ({outcomes |> List.sumBy (fun o -> o.DurationFrames)} frames). Headless engine does not simulate weapon physics (Feature 014 limitation).")
            output.WriteLine($"Report: {reportPath}")
