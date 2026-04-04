namespace HighBar.GameRunner

open System

module Program =
    [<EntryPoint>]
    let main argv =
        printfn "HighBar Game Runner"
        printfn "Usage: game-runner [run|report] [options]"
        printfn ""
        printfn "Commands:"
        printfn "  run    - Run AI-vs-AI games"
        printfn "  report - Generate report from game results"
        printfn ""
        printfn "Options:"
        printfn "  --games N    Number of games to run (default: 1)"
        printfn "  --map NAME   Map name (default: Comet Catcher Remake)"
        printfn "  --opponent NAME  Opponent AI (default: NullAI)"
        0
