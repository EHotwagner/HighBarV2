namespace HighBar.GameRunner

open System
open System.IO

/// Result of a single AI game.
type GameOutcome = {
    GameNumber: int
    Won: bool
    DurationFrames: int
    DurationMinutes: float
    UnitsProduced: int
    UnitsLost: int
    EnemyUnitsDestroyed: int
}

/// Launches AI-vs-AI games and collects outcomes.
module GameRunner =
    /// Generate a markdown report from game outcomes.
    let generateReport (outcomes: GameOutcome list) : string =
        let sb = System.Text.StringBuilder()
        sb.AppendLine("# Game Outcome Report") |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine($"**Total Games**: {outcomes.Length}") |> ignore
        let wins = outcomes |> List.filter (fun o -> o.Won) |> List.length
        sb.AppendLine($"**Win Rate**: {wins}/{outcomes.Length} ({float wins / float outcomes.Length * 100.0:F1}%%)") |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine("| Game | Result | Duration | Units Produced | Units Lost | Enemy Destroyed |") |> ignore
        sb.AppendLine("|------|--------|----------|----------------|------------|-----------------|") |> ignore
        for o in outcomes do
            let result = if o.Won then "WIN" else "LOSS"
            sb.AppendLine($"| {o.GameNumber} | {result} | {o.DurationMinutes:F1}min | {o.UnitsProduced} | {o.UnitsLost} | {o.EnemyUnitsDestroyed} |") |> ignore
        sb.ToString()
