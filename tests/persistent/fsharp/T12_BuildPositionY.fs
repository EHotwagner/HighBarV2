namespace HighBar.PersistentTests

open System
open System.IO
open System.Text.RegularExpressions
open Xunit
open Xunit.Abstractions
open HighBar.Client
open HighBar.Client.Commands

/// Feature 033 — Q4 resolution: does `BuildPosition.Y` matter?
/// Runs two BuildCommands for the same buildable at the same (x,z), once
/// with Y=0 (ground-like) and once with Y=1989 (mailbox value, well above
/// plausible ground), and compares engine-rc from the `[HB] dispatch` log
/// plus whether a nanoframe is observed within 300 frames.
[<Collection("PersistentEngine")>]
[<TestCaseOrderer("HighBar.PersistentTests.PriorityOrderer", "HighBar.PersistentTests")>]
type T12_BuildPositionY(engine: PersistentEngineFixture, output: ITestOutputHelper) =

    let getCommanderId () =
        engine.InitialEvents
        |> List.tryPick (function GameEvent.UnitCreated(uid, _) -> Some uid | _ -> None)
        |> Option.defaultWith (fun () -> failwith "No initial commander found")

    let dispatchRegex =
        Regex(@"\[HB\] dispatch frame=(\d+) case=BUILD_UNIT unit=(\d+) engine_rc=(-?\d+)",
              RegexOptions.Compiled)

    /// Read infolog.txt from the session dir. Returns the list of BUILD_UNIT
    /// dispatch matches (frame, unit, rc).
    let readDispatches () =
        let infoPath = Path.Combine(engine.SessionDir, "infolog.txt")
        if not (File.Exists infoPath) then []
        else
            use fs = new FileStream(infoPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
            use sr = new StreamReader(fs)
            [ while not sr.EndOfStream do
                let line = sr.ReadLine()
                let m = dispatchRegex.Match(line)
                if m.Success then
                    yield (int m.Groups.[1].Value,
                           int m.Groups.[2].Value,
                           int m.Groups.[3].Value) ]

    let runOneBuild (label: string) (x: float32) (y: float32) (z: float32) =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        engine.RunFrames(5, fun _ idx ->
            if idx = 0 then
                [ GiveMeResourceCommand 0 100000.0f; GiveMeResourceCommand 1 100000.0f ]
            else []) |> ignore

        let cmdId = getCommanderId()
        let buildOptions = engine.CommanderBuildOptions
        if buildOptions.Length = 0 then
            output.WriteLine($"[{label}] no commander build options — SKIP")
            None
        else
            let buildDefId = buildOptions.[0]
            let before = readDispatches().Length
            let mutable nano = false
            engine.RunFrames(300, fun frame idx ->
                for ev in frame.Events do
                    match ev with
                    | GameEvent.UnitCreated(_, bid) when bid = cmdId -> nano <- true
                    | _ -> ()
                if idx = 0 then
                    [ BuildCommand cmdId buildDefId x y z 0 ]
                else []
            ) |> ignore

            // Give the engine a beat to flush its infolog buffer.
            System.Threading.Thread.Sleep(200)
            let after = readDispatches()
            let newDispatches = after |> List.skip (min before after.Length)
            let ourLine =
                newDispatches
                |> List.tryFind (fun (_, u, _) -> u = cmdId)
            output.WriteLine($"[{label}] x={x} y={y} z={z} defId={buildDefId} nanoframe={nano} dispatch={ourLine}")
            Some (nano, ourLine)

    [<Fact>]
    [<Priority(1)>]
    member _.``T12.1 BuildPosition.Y=0 (ground-like)``() =
        let result = runOneBuild "Y=0" 1536.0f 0.0f 4200.0f
        Assert.True(result.IsSome, "must have build options")

    [<Fact>]
    [<Priority(2)>]
    member _.``T12.2 BuildPosition.Y=1989 (mailbox value)``() =
        let result = runOneBuild "Y=1989" 1536.0f 1989.0f 4200.0f
        Assert.True(result.IsSome, "must have build options")
