namespace HighBar.Client

open System
open System.Diagnostics
open System.IO

/// Diagnostic information collected from an engine session for post-mortem analysis.
type SessionDiagnostics = {
    SessionDir: string
    SocketPath: string
    LastFrameNumber: uint32
    EngineExitCode: int option
    StdoutTail: string list
    StderrTail: string list
    InfologTail: string list
}

module SessionDiagnostics =

    let private readTail (path: string) (maxLines: int) : string list =
        if File.Exists(path) then
            try
                let lines = File.ReadAllLines(path)
                let skip = max 0 (lines.Length - maxLines)
                lines |> Array.skip skip |> Array.toList
            with _ -> []
        else []

    /// Collect diagnostics from a session directory and engine process.
    let collect (sessionDir: string) (socketPath: string) (lastFrame: uint32) (engineProcess: Process option) : SessionDiagnostics =
        let exitCode =
            engineProcess |> Option.bind (fun p ->
                try
                    if p.HasExited then Some p.ExitCode else None
                with :? InvalidOperationException -> None)

        { SessionDir = sessionDir
          SocketPath = socketPath
          LastFrameNumber = lastFrame
          EngineExitCode = exitCode
          StdoutTail = readTail (Path.Combine(sessionDir, "engine-stdout.log")) 50
          StderrTail = readTail (Path.Combine(sessionDir, "engine-stderr.log")) 50
          InfologTail = readTail (Path.Combine(sessionDir, "infolog.txt")) 50 }

    /// Format diagnostics as a human-readable multi-line string.
    let formatReport (diag: SessionDiagnostics) : string =
        let sb = System.Text.StringBuilder()
        sb.AppendLine($"Session directory: {diag.SessionDir}") |> ignore
        sb.AppendLine($"Socket: {diag.SocketPath}") |> ignore
        sb.AppendLine($"Last frame: {diag.LastFrameNumber}") |> ignore

        match diag.EngineExitCode with
        | Some code -> sb.AppendLine($"Engine exit code: {code}") |> ignore
        | None -> sb.AppendLine("Engine exit code: unknown (still running or not owned)") |> ignore

        let appendLog (name: string) (lines: string list) =
            if not lines.IsEmpty then
                sb.AppendLine($"\n--- {name} (last {lines.Length} lines) ---") |> ignore
                for line in lines do
                    sb.AppendLine(line) |> ignore

        appendLog "engine-stdout.log" diag.StdoutTail
        appendLog "engine-stderr.log" diag.StderrTail
        appendLog "infolog.txt" diag.InfologTail

        sb.ToString()
