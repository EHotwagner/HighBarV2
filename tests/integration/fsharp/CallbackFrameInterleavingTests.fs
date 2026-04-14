namespace HighBar.Tests

open System
open System.IO
open Xunit
open Google.Protobuf
open HighBar.Client
open Highbar

/// Duplex stream that reads from one MemoryStream (the scripted proxy output)
/// and writes to another (the test sink for inspecting client outbound
/// messages). Used by CallbackFrameInterleavingTests.
type private DuplexStream(readFrom: Stream, writeTo: Stream) =
    inherit Stream()
    override _.CanRead = true
    override _.CanWrite = true
    override _.CanSeek = false
    override _.CanTimeout = false
    override _.Length = readFrom.Length
    override _.Position
        with get () = readFrom.Position
        and set v = readFrom.Position <- v
    override _.Flush() = writeTo.Flush()
    override _.Read(buffer, offset, count) = readFrom.Read(buffer, offset, count)
    override _.Write(buffer, offset, count) = writeTo.Write(buffer, offset, count)
    override _.Seek(_, _) = raise (NotSupportedException())
    override _.SetLength(_) = raise (NotSupportedException())

/// Deterministic hermetic tests for the SendCallback/Frame interleaving contract.
/// These tests drive a scripted ProxyMessage byte stream through the client's
/// decode path via the internal stream-injection constructor — no engine, no
/// socket. They must run in well under 100 ms (SC-003) and they must fail
/// deterministically if the buffer-and-replay fix in Client.fs is reverted.
[<Trait("Category", "Unit")>]
type CallbackFrameInterleavingTests() =

    /// Serialise a list of ProxyMessages with length-prefixed framing into a
    /// MemoryStream. Returns a DuplexStream wrapping that source stream and a
    /// fresh MemoryStream sink, plus the raw sink for post-hoc inspection.
    static let buildScriptedStream (messages: ProxyMessage list) : Stream * MemoryStream =
        let src = new MemoryStream()
        for m in messages do
            let data = m.ToByteArray()
            let len = BitConverter.GetBytes(uint32 data.Length)
            if not BitConverter.IsLittleEndian then Array.Reverse(len)
            src.Write(len, 0, 4)
            src.Write(data, 0, data.Length)
        src.Position <- 0L
        let sink = new MemoryStream()
        (new DuplexStream(src, sink) :> Stream, sink)

    /// Build a Frame ProxyMessage carrying a list of EngineEvents.
    static let makeFrame (frameNumber: uint32) (events: EngineEvent list) : ProxyMessage =
        let frame = Frame()
        frame.FrameNumber <- frameNumber
        for e in events do frame.Events.Add(e)
        let msg = ProxyMessage()
        msg.Frame <- frame
        msg

    static let makeCallbackResponse (requestId: uint32) (success: bool) : ProxyMessage =
        let cbResp = CallbackResponse()
        cbResp.RequestId <- requestId
        cbResp.Success <- success
        let msg = ProxyMessage()
        msg.CallbackResponse <- cbResp
        msg

    static let makeSaveRequest () : ProxyMessage =
        let sr = SaveRequest()
        let msg = ProxyMessage()
        msg.SaveRequest <- sr
        msg

    static let makeUnitCreatedEvent (unitId: int) (builderId: int) : EngineEvent =
        let e = UnitCreatedEvent()
        e.UnitId <- unitId
        e.BuilderId <- builderId
        let ev = EngineEvent()
        ev.UnitCreated <- e
        ev

    static let makeUnitFinishedEvent (unitId: int) : EngineEvent =
        let e = UnitFinishedEvent()
        e.UnitId <- unitId
        let ev = EngineEvent()
        ev.UnitFinished <- e
        ev

    /// Parse all length-prefixed AIMessages written to a sink MemoryStream, in
    /// the order they were written.
    static let parseSinkMessages (sink: MemoryStream) : AIMessage list =
        let buf = sink.ToArray()
        let mutable pos = 0
        let result = ResizeArray<AIMessage>()
        while pos + 4 <= buf.Length do
            let lenBytes = Array.sub buf pos 4
            if not BitConverter.IsLittleEndian then Array.Reverse(lenBytes)
            let len = BitConverter.ToInt32(lenBytes, 0)
            pos <- pos + 4
            if pos + len > buf.Length then
                failwith "truncated AIMessage in sink"
            let msgBytes = Array.sub buf pos len
            pos <- pos + len
            result.Add(AIMessage.Parser.ParseFrom(msgBytes))
        List.ofSeq result

    // ---- T025: interleaved frames are preserved across two drains ----

    [<Fact>]
    member _.``SendCallback preserves interleaved frame events across StepFrame drains``() =
        let scripted =
            [ makeFrame 100u [ makeUnitCreatedEvent 14835 42 ]
              makeFrame 110u [ makeUnitFinishedEvent 14835 ]
              makeCallbackResponse 1u true ]
        let stream, sink = buildScriptedStream scripted
        use client = new HighBarClient(stream)

        let resp = client.SendCallback(uint32 CallbackId.CallbackMapGetWidth, [])
        Assert.True(resp.Success)
        Assert.Equal(1u, resp.RequestId)

        // First drain: frame 100 carrying the UnitCreated.
        let f1 = client.StepFrame(fun _ -> [])
        Assert.True(Option.isSome f1)
        let f1v = Option.get f1
        Assert.Equal(100u, f1v.FrameNumber)
        Assert.Contains(
            f1v.Events,
            (fun e ->
                match e with
                | GameEvent.UnitCreated(uid, _) -> uid = 14835
                | _ -> false))

        // Second drain: frame 110 carrying the UnitFinished.
        let f2 = client.StepFrame(fun _ -> [])
        Assert.True(Option.isSome f2)
        let f2v = Option.get f2
        Assert.Equal(110u, f2v.FrameNumber)
        Assert.Contains(
            f2v.Events,
            (fun e ->
                match e with
                | GameEvent.UnitFinished uid -> uid = 14835
                | _ -> false))

        // Outbound messages: one CallbackRequest, two empty FrameResponses
        // (one ack per interleaved frame), then two FrameResponses from the
        // StepFrame drains. We assert on the kinds in order.
        let outbound = parseSinkMessages sink
        Assert.Equal(5, List.length outbound)
        Assert.Equal(AIMessage.MessageOneofCase.CallbackRequest, outbound.[0].MessageCase)
        Assert.Equal(AIMessage.MessageOneofCase.FrameResponse, outbound.[1].MessageCase)
        Assert.Equal(AIMessage.MessageOneofCase.FrameResponse, outbound.[2].MessageCase)
        Assert.Equal(AIMessage.MessageOneofCase.FrameResponse, outbound.[3].MessageCase)
        Assert.Equal(AIMessage.MessageOneofCase.FrameResponse, outbound.[4].MessageCase)

    // ---- T026: request_id mismatch raises HighBarProtocolException ----

    [<Fact>]
    member _.``SendCallback raises HighBarProtocolException on request_id mismatch``() =
        let scripted = [ makeCallbackResponse 99u true ]
        let stream, _ = buildScriptedStream scripted
        use client = new HighBarClient(stream)

        let ex =
            Assert.Throws<HighBarProtocolException>(fun () ->
                client.SendCallback(uint32 CallbackId.CallbackMapGetWidth, []) |> ignore)
        Assert.Contains("expected 1", ex.Message)
        Assert.Contains("got 99", ex.Message)

    // ---- T027: SaveRequest during callback wait is handled, frames still drain ----

    [<Fact>]
    member _.``SendCallback preserves frames across an interleaved SaveRequest``() =
        let scripted =
            [ makeFrame 50u [ makeUnitCreatedEvent 1 1 ]
              makeSaveRequest ()
              makeFrame 60u [ makeUnitFinishedEvent 1 ]
              makeCallbackResponse 1u true ]
        let stream, sink = buildScriptedStream scripted
        use client = new HighBarClient(stream)

        let resp = client.SendCallback(uint32 CallbackId.CallbackMapGetWidth, [])
        Assert.Equal(1u, resp.RequestId)

        let f1 = client.StepFrame(fun _ -> []) |> Option.get
        Assert.Equal(50u, f1.FrameNumber)
        Assert.Contains(
            f1.Events,
            (fun e ->
                match e with
                | GameEvent.UnitCreated(uid, _) -> uid = 1
                | _ -> false))

        let f2 = client.StepFrame(fun _ -> []) |> Option.get
        Assert.Equal(60u, f2.FrameNumber)
        Assert.Contains(
            f2.Events,
            (fun e ->
                match e with
                | GameEvent.UnitFinished uid -> uid = 1
                | _ -> false))

        // The sink must contain exactly one SaveResponse (empty).
        let outbound = parseSinkMessages sink
        let saveResponses =
            outbound
            |> List.filter (fun m -> m.MessageCase = AIMessage.MessageOneofCase.SaveResponse)
        Assert.Equal(1, List.length saveResponses)

    // ---- T028: 100-attempt cap fires when frames never stop interleaving ----

    [<Fact>]
    member _.``SendCallback honours the 100-attempt cap when frames never stop interleaving``() =
        // 101 Frame messages with no CallbackResponse. The first 100 are
        // consumed by readUntilCallback; the 101st exceeds the cap.
        let scripted =
            [ for i in 1 .. 101 do
                yield makeFrame (uint32 i) [ makeUnitCreatedEvent i 0 ] ]
        let stream, _ = buildScriptedStream scripted
        use client = new HighBarClient(stream)

        let ex =
            Assert.Throws<Exception>(fun () ->
                client.SendCallback(uint32 CallbackId.CallbackMapGetWidth, []) |> ignore)
        Assert.Contains("exceeded 100 attempts", ex.Message)
