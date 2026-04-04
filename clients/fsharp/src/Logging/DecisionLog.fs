namespace HighBar.Client.Logging

open System
open System.IO
open System.Text.Json

/// A single structured decision log entry.
type DecisionLogEntry = {
    Frame: uint32
    Manager: string
    Type: string
    UnitId: int option
    Details: string
    Context: Map<string, string>
}

/// JSON lines writer for structured AI decision logging.
type DecisionLog(logPath: string) =
    let mutable writer: StreamWriter option = None

    member _.Open() =
        let dir = Path.GetDirectoryName(logPath)
        if not (String.IsNullOrEmpty(dir)) && not (Directory.Exists(dir)) then
            Directory.CreateDirectory(dir) |> ignore
        writer <- Some(new StreamWriter(logPath, append = true))

    member _.Log(entry: DecisionLogEntry) =
        match writer with
        | Some w ->
            let json = JsonSerializer.Serialize(entry)
            w.WriteLine(json)
            w.Flush()
        | None -> ()

    member _.Close() =
        match writer with
        | Some w ->
            w.Flush()
            w.Dispose()
            writer <- None
        | None -> ()

    interface IDisposable with
        member this.Dispose() = this.Close()
