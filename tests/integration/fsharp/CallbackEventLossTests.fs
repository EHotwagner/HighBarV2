namespace HighBar.Tests

open System
open System.Collections.Generic
open System.IO
open System.Text.RegularExpressions
open Xunit
open HighBar.Client
open Highbar

/// Live-engine reconciliation test for feature 031: verifies that issuing a
/// callback on every frame does not drop any engine events. The bot runs for
/// ≥ 1000 simulation frames with SendCallback(MapGetWidth) on each frame,
/// tallies observed events, and reconciles against the proxy's cumulative
/// "Event topics at frame N" counters emitted to the engine's infolog every
/// 50 frames.
[<Collection("Engine")>]
type CallbackEventLossTests(engine: EngineFixture) =

    // Map a GameEvent to its proto/Spring engine topic id (they match).
    static let gameEventTopic (ev: GameEvent) : int =
        match ev with
        | GameEvent.Init _ -> 1
        | GameEvent.Release -> 2
        | GameEvent.Update _ -> 3
        | GameEvent.Message _ -> 4
        | GameEvent.UnitCreated _ -> 5
        | GameEvent.UnitFinished _ -> 6
        | GameEvent.UnitIdle _ -> 7
        | GameEvent.UnitMoveFailed _ -> 8
        | GameEvent.UnitDamaged _ -> 9
        | GameEvent.UnitDestroyed _ -> 10
        | GameEvent.UnitGiven _ -> 11
        | GameEvent.UnitCaptured _ -> 12
        | GameEvent.EnemyEnterLOS _ -> 13
        | GameEvent.EnemyLeaveLOS _ -> 14
        | GameEvent.EnemyEnterRadar _ -> 15
        | GameEvent.EnemyLeaveRadar _ -> 16
        | GameEvent.EnemyDamaged _ -> 17
        | GameEvent.EnemyDestroyed _ -> 18
        | GameEvent.WeaponFired _ -> 19
        | GameEvent.PlayerCommand _ -> 20
        | GameEvent.SeismicPing _ -> 21
        | GameEvent.CommandFinished _ -> 22
        | GameEvent.Load -> 23
        | GameEvent.Save -> 24
        | GameEvent.EnemyCreated _ -> 25
        | GameEvent.EnemyFinished _ -> 26
        | GameEvent.LuaMessage _ -> 27
        | GameEvent.Unknown -> 0

    /// Parse every "Event topics at frame N: 1=A 3=B ..." line found in the
    /// engine infolog file, returning a list of (frameNumber, topic->count) pairs
    /// in the order they appear in the file.
    static let parseEngineInfologEventCounters (infologPath: string) : (int * Map<int, int>) list =
        if not (File.Exists(infologPath)) then []
        else
            let frameRegex = Regex(@"Event topics at frame (\d+):\s*(.*)$")
            let pairRegex = Regex(@"(\d+)=(\d+)")
            File.ReadAllLines(infologPath)
            |> Array.choose (fun line ->
                let m = frameRegex.Match(line)
                if m.Success then
                    let frame = Int32.Parse(m.Groups.[1].Value)
                    let tail = m.Groups.[2].Value
                    let counts =
                        pairRegex.Matches(tail)
                        |> Seq.cast<Match>
                        |> Seq.map (fun pm ->
                            Int32.Parse(pm.Groups.[1].Value),
                            Int32.Parse(pm.Groups.[2].Value))
                        |> Map.ofSeq
                    Some (frame, counts)
                else None)
            |> Array.toList

    /// Sum a list of GameEvents into a topic->count map.
    static let tallyBotEventsByTopic (events: GameEvent seq) : Map<int, int> =
        events
        |> Seq.fold (fun acc ev ->
            let topic = gameEventTopic ev
            let current = Map.tryFind topic acc |> Option.defaultValue 0
            Map.add topic (current + 1) acc) Map.empty

    // ---- Unit tests for the helpers (no engine required) ----

    [<Fact>]
    [<Trait("Category", "Unit")>]
    member _.``parseEngineInfologEventCounters extracts frame and topic counts``() =
        let tmp = Path.GetTempFileName()
        try
            File.WriteAllText(
                tmp,
                "[t=00:00:50.000][f=0001000] Skirmish AI <HighBar V2>: Event topics at frame 1000: 1=1 3=1001 5=2 6=1 13=8 15=8 25=8 26=8\n")
            let result = parseEngineInfologEventCounters tmp
            Assert.Equal(1, List.length result)
            let (frame, counts) = result.[0]
            Assert.Equal(1000, frame)
            Assert.Equal(1, Map.find 1 counts)
            Assert.Equal(1001, Map.find 3 counts)
            Assert.Equal(2, Map.find 5 counts)
            Assert.Equal(1, Map.find 6 counts)
            Assert.Equal(8, Map.find 26 counts)
        finally
            File.Delete(tmp)

    [<Fact>]
    [<Trait("Category", "Unit")>]
    member _.``tallyBotEventsByTopic counts events by topic id``() =
        let events =
            [ GameEvent.Init 0
              GameEvent.Update 1
              GameEvent.Update 2
              GameEvent.UnitCreated(100, 0)
              GameEvent.UnitFinished(100) ]
        let tally = tallyBotEventsByTopic events
        Assert.Equal(1, Map.find 1 tally)
        Assert.Equal(2, Map.find 3 tally)
        Assert.Equal(1, Map.find 5 tally)
        Assert.Equal(1, Map.find 6 tally)

    // ---- Main live-engine reconciliation test ----

    /// Run for ≥1000 frames issuing a MapGetWidth callback every frame, then
    /// reconcile the bot-observed event counts against the proxy's infolog
    /// topic counters over the test window. Zero deltas required.
    [<Fact>]
    [<Trait("Category", "Callbacks")>]
    member _.``Callback-per-frame run preserves every engine event``() =
        let client = engine.Client
        let sessionDir = engine.SessionDir
        let infologPath = Path.Combine(sessionDir, "infolog.txt")

        // Tally events per-frame so we can filter to the reconciled window.
        let eventsByFrame = Dictionary<int, ResizeArray<GameEvent>>()
        let mutable firstFrame = -1
        let mutable frameCount = 0
        let targetFrames = 1100

        try
            client.Run(fun frame ->
                let fNum = int frame.FrameNumber
                if firstFrame < 0 then firstFrame <- fNum
                let bucket =
                    match eventsByFrame.TryGetValue(fNum) with
                    | true, v -> v
                    | false, _ ->
                        let v = ResizeArray()
                        eventsByFrame.[fNum] <- v
                        v
                for ev in frame.Events do bucket.Add(ev)

                // Issue the callback under test on every frame.
                client.GetMapWidth() |> ignore

                frameCount <- frameCount + 1
                if frameCount >= targetFrames then
                    failwith "CAPTURED_ENOUGH"
                [])
        with
        | ex when ex.Message = "CAPTURED_ENOUGH" -> ()

        // Sanity: we actually ran as many frames as we intended.
        Assert.True(
            frameCount >= 1000,
            $"expected ≥1000 frames captured, got {frameCount}")

        let lastFrame =
            eventsByFrame.Keys |> Seq.max

        // Parse all topic lines from the infolog, then pick the start/end
        // bracketing our test window.
        let lines = parseEngineInfologEventCounters infologPath
        Assert.True(
            List.length lines >= 2,
            $"expected ≥2 'Event topics at frame N' lines in {infologPath}, got {List.length lines}")

        // Earliest infolog snapshot at or after firstFrame; latest at or before lastFrame.
        let startSnap =
            lines
            |> List.filter (fun (n, _) -> n >= firstFrame)
            |> List.tryHead
        let endSnap =
            lines
            |> List.filter (fun (n, _) -> n <= lastFrame)
            |> List.tryLast

        match startSnap, endSnap with
        | Some (fStart, cStart), Some (fEnd, cEnd) when fEnd > fStart ->
            // Infolog delta over (fStart, fEnd].
            let infologDelta =
                let allTopics =
                    Set.union
                        (cStart |> Map.toSeq |> Seq.map fst |> Set.ofSeq)
                        (cEnd |> Map.toSeq |> Seq.map fst |> Set.ofSeq)
                allTopics
                |> Seq.map (fun t ->
                    let a = Map.tryFind t cStart |> Option.defaultValue 0
                    let b = Map.tryFind t cEnd |> Option.defaultValue 0
                    t, b - a)
                |> Seq.filter (fun (_, d) -> d <> 0)
                |> Map.ofSeq

            // Bot-observed delta over exactly (fStart, fEnd].
            let windowEvents =
                [ for KeyValue(f, evs) in eventsByFrame do
                    if f > fStart && f <= fEnd then yield! evs ]
            let botDelta = tallyBotEventsByTopic windowEvents

            // Sanity: the bot did non-trivial work in the window — catches
            // silent empty-tally regressions where the reconciliation would
            // otherwise trivially succeed.
            let updateCount = Map.tryFind 3 botDelta |> Option.defaultValue 0
            Assert.True(
                updateCount > 0,
                $"bot saw no Update events in window ({fStart}, {fEnd}] — test is not exercising the callback-per-frame path")

            // Reconcile: every topic in the infolog delta must be present in
            // the bot delta with exactly the same count. Any missing or short
            // count means the client dropped events while waiting on a callback.
            let mismatches =
                infologDelta
                |> Map.toList
                |> List.choose (fun (topic, expected) ->
                    let observed = Map.tryFind topic botDelta |> Option.defaultValue 0
                    if observed = expected then None
                    else Some (topic, expected, observed))

            if not (List.isEmpty mismatches) then
                let detail =
                    mismatches
                    |> List.map (fun (t, e, o) -> $"topic {t}: infolog={e} bot={o}")
                    |> String.concat "; "
                Assert.Fail(
                    $"event reconciliation failed over window ({fStart}, {fEnd}]: {detail}")
        | _ ->
            Assert.Fail(
                $"not enough infolog topic snapshots bracketing the test window [{firstFrame}, {lastFrame}]; parsed {List.length lines} total lines")
