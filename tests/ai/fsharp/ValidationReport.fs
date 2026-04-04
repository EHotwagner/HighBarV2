namespace HighBar.AI.Tests

open System
open System.IO
open System.Text

module ValidationReportGen =

    /// Generate a markdown validation report (for end-to-end and competitive suites).
    let generateValidationReport (report: ValidationReport) : string =
        let sb = StringBuilder()
        let overall = if report.OverallPass then "PASS" else "FAIL"
        let dateStr = report.RunDate.ToString("yyyy-MM-dd HH:mm:ss")
        sb.AppendLine($"# {report.SuiteName} Validation Report") |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine($"**Date**: {dateStr}") |> ignore
        sb.AppendLine($"**Games**: {report.TotalGames}") |> ignore
        sb.AppendLine($"**Overall**: {overall}") |> ignore
        sb.AppendLine() |> ignore

        // Success criteria table
        sb.AppendLine("## Success Criteria") |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine("| ID | Criterion | Result | Details |") |> ignore
        sb.AppendLine("|----|-----------|--------|---------|") |> ignore
        for (criterion, passed) in report.Criteria do
            let result = if passed then "PASS" else "FAIL"
            sb.AppendLine($"| {criterion.Id} | {criterion.Description} | {result} | |") |> ignore
        sb.AppendLine() |> ignore

        // Per-game results table
        sb.AppendLine("## Per-Game Results") |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine("| Game | Result | Duration | Units Produced | Units Lost | Enemy Destroyed |") |> ignore
        sb.AppendLine("|------|--------|----------|----------------|------------|-----------------|") |> ignore
        for o in report.Outcomes do
            let result =
                match o.Result with
                | GameResult.Win -> "WIN"
                | GameResult.Loss -> "LOSS"
                | GameResult.Crash -> "CRASH"
                | GameResult.Stall -> "STALL"
                | GameResult.Timeout -> "TIMEOUT"
            sb.AppendLine($"| {o.GameNumber} | {result} | {o.DurationMinutes:F1} min | {o.UnitsProduced} | {o.UnitsLost} | {o.EnemyUnitsDestroyed} |") |> ignore
        sb.AppendLine() |> ignore

        // Aggregate statistics
        let wins = report.Outcomes |> List.filter (fun o -> o.Result = GameResult.Win) |> List.length
        let completions = report.Outcomes |> List.filter (fun o -> o.Result <> GameResult.Crash && o.Result <> GameResult.Stall) |> List.length
        let avgDuration = if report.Outcomes.IsEmpty then 0.0 else report.Outcomes |> List.averageBy (fun o -> o.DurationMinutes)
        sb.AppendLine("## Statistics") |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine($"- **Win Rate**: {wins}/{report.TotalGames} ({float wins / float (max 1 report.TotalGames) * 100.0:F1}%%)") |> ignore
        sb.AppendLine($"- **Completion Rate**: {completions}/{report.TotalGames} ({float completions / float (max 1 report.TotalGames) * 100.0:F1}%%)") |> ignore
        sb.AppendLine($"- **Avg Duration**: {avgDuration:F1} min") |> ignore

        sb.ToString()

    /// Generate a markdown test suite report (for non-combat and combat suites).
    let generateTestSuiteReport (report: TestSuiteReport) : string =
        let sb = StringBuilder()
        let overall = if report.OverallPass then "PASS" else "FAIL"
        let dateStr = report.RunDate.ToString("yyyy-MM-dd HH:mm:ss")
        sb.AppendLine($"# {report.SuiteName} Test Report") |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine($"**Date**: {dateStr}") |> ignore
        sb.AppendLine($"**Runs**: {report.TotalRuns}") |> ignore
        sb.AppendLine($"**Pass Rate**: {report.PassRate:F1}%% ({report.PassedCount}/{report.PassedCount + report.FailedCount} assertions)") |> ignore
        sb.AppendLine($"**Overall**: {overall}") |> ignore
        sb.AppendLine() |> ignore

        // Results by category
        sb.AppendLine("## Results by Category") |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine("| Category | Passed | Failed | Rate |") |> ignore
        sb.AppendLine("|----------|--------|--------|------|") |> ignore
        let byCategory =
            report.Assertions
            |> List.groupBy (fun a -> a.Category)
            |> List.sortBy fst
        for (category, assertions) in byCategory do
            let passed = assertions |> List.filter (fun a -> a.Passed) |> List.length
            let failed = assertions |> List.filter (fun a -> not a.Passed) |> List.length
            let total = passed + failed
            let rate = if total > 0 then float passed / float total * 100.0 else 0.0
            let catName =
                match category with
                | TestCategory.Economy -> "Economy"
                | TestCategory.BuildOrder -> "BuildOrder"
                | TestCategory.Movement -> "Movement"
                | TestCategory.Scouting -> "Scouting"
                | TestCategory.Combat -> "Combat"
            sb.AppendLine($"| {catName} | {passed} | {failed} | {rate:F0}%% |") |> ignore
        sb.AppendLine() |> ignore

        // Failed assertions
        let failed = report.Assertions |> List.filter (fun a -> not a.Passed)
        if not failed.IsEmpty then
            sb.AppendLine("## Failed Assertions") |> ignore
            sb.AppendLine() |> ignore
            sb.AppendLine("| Run | Assertion | Expected | Actual |") |> ignore
            sb.AppendLine("|-----|-----------|----------|--------|") |> ignore
            for a in failed do
                sb.AppendLine($"| {a.GameNumber} | {a.Name} | {a.ExpectedValue} | {a.ActualValue} |") |> ignore

        sb.ToString()

    /// Write a report to the reports directory with a timestamped filename.
    let writeReport (reportsDir: string) (prefix: string) (content: string) =
        Directory.CreateDirectory(reportsDir) |> ignore
        let timestamp = DateTime.Now.ToString("yyyyMMdd-HHmmss")
        let path = Path.Combine(reportsDir, $"{prefix}-{timestamp}.md")
        File.WriteAllText(path, content)
        path

    /// Build a ValidationReport from outcomes and criteria.
    let buildValidationReport (suiteName: string) (outcomes: GameOutcome list) (criteria: ValidationCriterion list) : ValidationReport =
        let evaluated = criteria |> List.map (fun c -> (c, c.Evaluate outcomes))
        { SuiteName = suiteName
          RunDate = DateTime.Now
          TotalGames = outcomes.Length
          Outcomes = outcomes
          Criteria = evaluated
          OverallPass = evaluated |> List.forall snd }

    /// Build a TestSuiteReport from assertions with a pass rate threshold.
    let buildTestSuiteReport (suiteName: string) (totalRuns: int) (assertions: TestAssertion list) (threshold: float) : TestSuiteReport =
        let passed = assertions |> List.filter (fun a -> a.Passed) |> List.length
        let failed = assertions |> List.filter (fun a -> not a.Passed) |> List.length
        let total = passed + failed
        let rate = if total > 0 then float passed / float total * 100.0 else 0.0
        { SuiteName = suiteName
          RunDate = DateTime.Now
          TotalRuns = totalRuns
          Assertions = assertions
          PassRate = rate
          PassedCount = passed
          FailedCount = failed
          OverallPass = rate >= threshold }
