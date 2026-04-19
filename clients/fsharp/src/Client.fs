namespace HighBar.Client

open System
open System.Collections.Generic
open System.IO
open System.Net.Sockets
open Google.Protobuf
open Highbar

[<assembly: System.Runtime.CompilerServices.InternalsVisibleTo("HighBar.Tests")>]
do ()

/// Exception thrown when the engine proxy connection is lost.
type EngineDisconnectedException(message: string, ?lastFrameNumber: uint32, ?innerException: exn) =
    inherit IOException(
        message,
        match innerException with Some ex -> ex | None -> null)
    member _.LastFrameNumber = lastFrameNumber

/// Exception thrown when the proxy sends a message that violates the
/// documented callback/frame interleaving contract (e.g. a CallbackResponse
/// whose request_id does not match the in-flight request).
type HighBarProtocolException(message: string) =
    inherit Exception(message)

/// Typed frame received from the proxy, containing parsed events.
type GameFrame = {
    FrameNumber: uint32
    Events: GameEvent list
}

/// A frame decoded while SendCallback was waiting for a CallbackResponse.
/// Held in the client's replay buffer until the next Run/StepFrame drain.
type internal PendingFrame = {
    FrameNumber: uint32
    Events: GameEvent list
}

/// Client connection to the HighBar proxy.
type HighBarClient(socketPath: string, ?readTimeoutMs: int) =
    let mutable socket: Socket option = None
    let mutable stream: Stream option = None
    let protocolVersion = 1u
    let mutable nextRequestId = 1u
    // FIFO of frames decoded while a SendCallback was waiting for its
    // CallbackResponse. Drained by Run/StepFrame before touching the socket
    // so no engine event is ever dropped on the callback path.
    let replayBuffer = Queue<PendingFrame>()
    let timeoutMs =
        match readTimeoutMs with
        | Some t -> t
        | None ->
            match Environment.GetEnvironmentVariable("HIGHBAR_CLIENT_TIMEOUT_MS") with
            | null | "" -> 10000
            | v -> Int32.Parse(v)

    let sendMessage (s: Stream) (msg: IMessage) =
        let data = msg.ToByteArray()
        let len = BitConverter.GetBytes(uint32 data.Length)
        if not BitConverter.IsLittleEndian then Array.Reverse(len)
        s.Write(len, 0, 4)
        s.Write(data, 0, data.Length)
        s.Flush()

    let recvBytes (s: Stream) : byte[] =
        let readFully (buf: byte[]) (offset: int) (count: int) =
            let mutable read = 0
            while read < count do
                let n =
                    try
                        s.Read(buf, offset + read, count - read)
                    with
                    | :? IOException as ex ->
                        raise (EngineDisconnectedException("Engine proxy read timeout", innerException = ex))
                if n = 0 then
                    raise (EngineDisconnectedException("Engine proxy closed connection"))
                read <- read + n

        let headerBuf = Array.zeroCreate<byte> 4
        readFully headerBuf 0 4
        if not BitConverter.IsLittleEndian then Array.Reverse(headerBuf)
        let len = BitConverter.ToInt32(headerBuf, 0)
        let dataBuf = Array.zeroCreate<byte> len
        readFully dataBuf 0 len
        dataBuf

    /// Test-only constructor that swaps the Unix socket for a pre-opened Stream
    /// (typically a duplex wrapper around a MemoryStream). Skips the Connect
    /// handshake. Gated to the HighBar.Tests project via InternalsVisibleTo.
    internal new (injectedStream: Stream) as this =
        new HighBarClient("")
        then
            this.SetStreamForTesting(injectedStream)

    member internal _.SetStreamForTesting(s: Stream) =
        stream <- Some s

    /// Connect to the proxy Unix domain socket (proxy is the client connecting to us).
    member _.Connect() =
        let endpoint = UnixDomainSocketEndPoint(socketPath)
        let sock = new Socket(AddressFamily.Unix, SocketType.Stream, ProtocolType.Unspecified)
        sock.Connect(endpoint)
        socket <- Some sock
        let ns = new NetworkStream(sock, true)
        ns.ReadTimeout <- timeoutMs
        stream <- Some (ns :> Stream)

    /// Accept a connection from the proxy on a pre-created listening socket.
    member _.AcceptFrom(listener: Socket) =
        let accepted = listener.Accept()
        socket <- Some accepted
        let ns = new NetworkStream(accepted, true)
        ns.ReadTimeout <- timeoutMs
        stream <- Some (ns :> Stream)

    /// Wrap an already-connected socket (e.g. accepted by the harness).
    member _.WrapSocket(connectedSocket: Socket) =
        socket <- Some connectedSocket
        let ns = new NetworkStream(connectedSocket, false)
        ns.ReadTimeout <- timeoutMs
        stream <- Some (ns :> Stream)

    /// Perform handshake — wait for Handshake, send HandshakeResponse.
    member _.Handshake() =
        match stream with
        | None -> failwith "Not connected"
        | Some s ->
            let proxyMsg = ProxyMessage.Parser.ParseFrom(recvBytes s)
            match proxyMsg.MessageCase with
            | ProxyMessage.MessageOneofCase.Handshake ->
                let hs = proxyMsg.Handshake
                if hs.ProtocolVersion <> protocolVersion then
                    let resp = AIMessage()
                    let hr = HandshakeResponse()
                    hr.Accepted <- false
                    hr.ProtocolVersion <- protocolVersion
                    resp.HandshakeResponse <- hr
                    sendMessage s resp
                    failwith $"Protocol version mismatch: expected {protocolVersion}, got {hs.ProtocolVersion}"
                else
                    let resp = AIMessage()
                    let hr = HandshakeResponse()
                    hr.Accepted <- true
                    hr.ProtocolVersion <- protocolVersion
                    resp.HandshakeResponse <- hr
                    sendMessage s resp
                    hs
            | _ -> failwith "Expected Handshake message"

    /// Run the frame loop, calling onFrame for each frame received.
    /// onFrame returns a list of commands to send back.
    member _.Run(onFrame: GameFrame -> AICommand list) =
        match stream with
        | None -> failwith "Not connected"
        | Some s ->
            let mutable running = true
            while running do
                // Drain any frames that SendCallback stashed while waiting on
                // a CallbackResponse. FIFO order preserved; the drain is a no-op
                // on the happy path because replayBuffer is empty.
                if replayBuffer.Count > 0 then
                    let pending = replayBuffer.Dequeue()
                    let gameFrame: GameFrame = {
                        FrameNumber = pending.FrameNumber
                        Events = pending.Events
                    }
                    let commands = onFrame gameFrame
                    let resp = AIMessage()
                    let fr = FrameResponse()
                    for cmd in commands do
                        fr.Commands.Add(cmd)
                    resp.FrameResponse <- fr
                    sendMessage s resp
                else
                    let proxyMsg = ProxyMessage.Parser.ParseFrom(recvBytes s)
                    match proxyMsg.MessageCase with
                    | ProxyMessage.MessageOneofCase.Frame ->
                        let frame = proxyMsg.Frame
                        let events =
                            frame.Events
                            |> Seq.map Events.fromProto
                            |> Seq.toList
                        let gameFrame: GameFrame = {
                            FrameNumber = frame.FrameNumber
                            Events = events
                        }
                        let commands = onFrame gameFrame
                        let resp = AIMessage()
                        let fr = FrameResponse()
                        for cmd in commands do
                            fr.Commands.Add(cmd)
                        resp.FrameResponse <- fr
                        sendMessage s resp

                    | ProxyMessage.MessageOneofCase.Shutdown ->
                        running <- false

                    | ProxyMessage.MessageOneofCase.SaveRequest ->
                        let resp = AIMessage()
                        let sr = SaveResponse()
                        sr.StateData <- Google.Protobuf.ByteString.Empty
                        resp.SaveResponse <- sr
                        sendMessage s resp

                    | _ -> ()

    /// Process a single frame: receive one Frame message, call handler, send response.
    /// Returns Some(GameFrame) if a frame was processed, or None if a Shutdown was received.
    /// SaveRequest messages are handled automatically.
    member _.StepFrame(onFrame: GameFrame -> AICommand list) : GameFrame option =
        match stream with
        | None -> failwith "Not connected"
        | Some s ->
            let mutable result: GameFrame option = None
            let mutable keepReading = true
            while keepReading do
                if replayBuffer.Count > 0 then
                    let pending = replayBuffer.Dequeue()
                    let gameFrame: GameFrame = {
                        FrameNumber = pending.FrameNumber
                        Events = pending.Events
                    }
                    let commands = onFrame gameFrame
                    let resp = AIMessage()
                    let fr = FrameResponse()
                    for cmd in commands do
                        fr.Commands.Add(cmd)
                    resp.FrameResponse <- fr
                    sendMessage s resp
                    result <- Some gameFrame
                    keepReading <- false
                else
                    let proxyMsg = ProxyMessage.Parser.ParseFrom(recvBytes s)
                    match proxyMsg.MessageCase with
                    | ProxyMessage.MessageOneofCase.Frame ->
                        let frame = proxyMsg.Frame
                        let events =
                            frame.Events
                            |> Seq.map Events.fromProto
                            |> Seq.toList
                        let gameFrame: GameFrame = {
                            FrameNumber = frame.FrameNumber
                            Events = events
                        }
                        let commands = onFrame gameFrame
                        let resp = AIMessage()
                        let fr = FrameResponse()
                        for cmd in commands do
                            fr.Commands.Add(cmd)
                        resp.FrameResponse <- fr
                        sendMessage s resp
                        result <- Some gameFrame
                        keepReading <- false

                    | ProxyMessage.MessageOneofCase.Shutdown ->
                        keepReading <- false

                    | ProxyMessage.MessageOneofCase.SaveRequest ->
                        let resp = AIMessage()
                        let sr = SaveResponse()
                        sr.StateData <- Google.Protobuf.ByteString.Empty
                        resp.SaveResponse <- sr
                        sendMessage s resp
                        // Continue reading for the next Frame

                    | _ -> ()
            result

    /// Send a callback request and receive the response.
    /// Frames that the proxy interleaves between the request and its response
    /// are decoded, acknowledged with an empty FrameResponse (so the proxy
    /// does not stall), and buffered in replayBuffer for the next Run/StepFrame
    /// call to replay to the bot's frame handler.
    member _.SendCallback(callbackId: uint32, callbackParams: CallbackParam list) : CallbackResponse =
        match stream with
        | None -> failwith "Not connected"
        | Some s ->
            let req = CallbackRequest()
            let expectedRequestId = nextRequestId
            req.RequestId <- expectedRequestId
            nextRequestId <- nextRequestId + 1u
            req.CallbackId <- callbackId
            for p in callbackParams do
                req.Params.Add(p)
            let msg = AIMessage()
            msg.CallbackRequest <- req
            sendMessage s msg

            let rec readUntilCallback (attempts: int) =
                if attempts > 100 then
                    failwith "SendCallback: exceeded 100 attempts waiting for CallbackResponse"
                let respBytes = recvBytes s
                let proxyMsg = ProxyMessage.Parser.ParseFrom(respBytes)
                match proxyMsg.MessageCase with
                | ProxyMessage.MessageOneofCase.CallbackResponse ->
                    let cbResp = proxyMsg.CallbackResponse
                    if cbResp.RequestId <> expectedRequestId then
                        raise (HighBarProtocolException(
                            $"CallbackResponse request_id mismatch: expected {expectedRequestId}, got {cbResp.RequestId}"))
                    cbResp
                | ProxyMessage.MessageOneofCase.Frame ->
                    // Engine pushed a frame while we're waiting for the callback
                    // response. Decode the events, stash the frame in replayBuffer
                    // for the next Run/StepFrame drain, ack with empty commands so
                    // the proxy does not stall, then keep reading.
                    let frame = proxyMsg.Frame
                    let events =
                        frame.Events
                        |> Seq.map Events.fromProto
                        |> Seq.toList
                    let pending: PendingFrame = {
                        FrameNumber = frame.FrameNumber
                        Events = events
                    }
                    replayBuffer.Enqueue(pending)
                    let resp = AIMessage()
                    let fr = FrameResponse()
                    resp.FrameResponse <- fr
                    sendMessage s resp
                    readUntilCallback (attempts + 1)
                | ProxyMessage.MessageOneofCase.SaveRequest ->
                    let resp = AIMessage()
                    let sr = SaveResponse()
                    sr.StateData <- Google.Protobuf.ByteString.Empty
                    resp.SaveResponse <- sr
                    sendMessage s resp
                    readUntilCallback (attempts + 1)
                | other -> failwith $"Expected CallbackResponse, got {other}"
            readUntilCallback 0

    /// Get all valid unitDefId values from the engine.
    member this.GetUnitDefs(maxCount: int) : int array =
        let p = CallbackParam()
        p.IntValue <- maxCount
        let resp = this.SendCallback(uint32 CallbackId.CallbackGetUnitDefs, [p])
        if resp.Success && resp.Result <> null && resp.Result.ValueCase = CallbackResult.ValueOneofCase.IntArrayValue then
            resp.Result.IntArrayValue.Values |> Seq.map int |> Seq.toArray
        else [||]

    /// Get the engine name for a unitDefId.
    member this.GetUnitDefName(defId: int) : string =
        let p = CallbackParam()
        p.IntValue <- defId
        let resp = this.SendCallback(uint32 CallbackId.CallbackUnitdefGetName, [p])
        if resp.Success && resp.Result <> null && resp.Result.ValueCase = CallbackResult.ValueOneofCase.StringValue then
            resp.Result.StringValue
        else ""

    /// Get build options (buildable defIds) for a unitDefId.
    member this.GetBuildOptions(defId: int) : int array =
        let p1 = CallbackParam()
        p1.IntValue <- defId
        let p2 = CallbackParam()
        p2.IntValue <- 256
        let resp = this.SendCallback(uint32 CallbackId.CallbackUnitdefGetBuildOptions, [p1; p2])
        if resp.Success && resp.Result <> null && resp.Result.ValueCase = CallbackResult.ValueOneofCase.IntArrayValue then
            resp.Result.IntArrayValue.Values |> Seq.map int |> Seq.toArray
        else [||]

    /// Get the max weapon range for a unitDefId (0.0 = unarmed).
    member this.GetMaxWeaponRange(defId: int) : float32 =
        let p = CallbackParam()
        p.IntValue <- defId
        let resp = this.SendCallback(uint32 CallbackId.CallbackUnitdefGetMaxWeaponRange, [p])
        if resp.Success && resp.Result <> null && resp.Result.ValueCase = CallbackResult.ValueOneofCase.FloatValue then
            resp.Result.FloatValue
        else 0.0f

    /// Get the build speed for a unitDefId (0.0 = not a builder).
    member this.GetBuildSpeed(defId: int) : float32 =
        let p = CallbackParam()
        p.IntValue <- defId
        let resp = this.SendCallback(uint32 CallbackId.CallbackUnitdefGetBuildSpeed, [p])
        if resp.Success && resp.Result <> null && resp.Result.ValueCase = CallbackResult.ValueOneofCase.FloatValue then
            resp.Result.FloatValue
        else 0.0f

    /// Get the defId for a live unit instance.
    member this.GetUnitDef(unitId: int) : int =
        let p = CallbackParam()
        p.IntValue <- unitId
        let resp = this.SendCallback(uint32 CallbackId.CallbackUnitGetDef, [p])
        if resp.Success && resp.Result <> null && resp.Result.ValueCase = CallbackResult.ValueOneofCase.IntValue then
            resp.Result.IntValue
        else -1

    /// Get the metal cost for a unitDefId.
    member this.GetUnitDefCost(defId: int) : float32 =
        let p = CallbackParam()
        p.IntValue <- defId
        let resp = this.SendCallback(uint32 CallbackId.CallbackUnitdefGetCost, [p])
        if resp.Success && resp.Result <> null && resp.Result.ValueCase = CallbackResult.ValueOneofCase.FloatValue then
            resp.Result.FloatValue
        else 0.0f

    /// Get the build time for a unitDefId.
    member this.GetUnitDefBuildTime(defId: int) : float32 =
        let p = CallbackParam()
        p.IntValue <- defId
        let resp = this.SendCallback(uint32 CallbackId.CallbackUnitdefGetBuildTime, [p])
        if resp.Success && resp.Result <> null && resp.Result.ValueCase = CallbackResult.ValueOneofCase.FloatValue then
            resp.Result.FloatValue
        else 0.0f

    /// Get the map width in elmos.
    member this.GetMapWidth() : int =
        let resp = this.SendCallback(uint32 CallbackId.CallbackMapGetWidth, [])
        if resp.Success && resp.Result <> null && resp.Result.ValueCase = CallbackResult.ValueOneofCase.IntValue then
            resp.Result.IntValue
        else 0

    /// Get the map height in elmos.
    member this.GetMapHeight() : int =
        let resp = this.SendCallback(uint32 CallbackId.CallbackMapGetHeight, [])
        if resp.Success && resp.Result <> null && resp.Result.ValueCase = CallbackResult.ValueOneofCase.IntValue then
            resp.Result.IntValue
        else 0

    /// Get the height map as a flat float array. Returns empty array if not supported.
    member this.GetHeightMap() : float32 array =
        let resp = this.SendCallback(uint32 CallbackId.CallbackMapGetHeightMap, [])
        if resp.Success && resp.Result <> null && resp.Result.ValueCase = CallbackResult.ValueOneofCase.FloatArrayValue then
            resp.Result.FloatArrayValue.Values |> Seq.toArray
        else [||]

    /// Get the corners height map as a flat float array. Size is (width+1)*(height+1). Returns empty array if not supported.
    member this.GetCornersHeightMap() : float32 array =
        let resp = this.SendCallback(uint32 CallbackId.CallbackMapGetCornersHeightMap, [])
        if resp.Success && resp.Result <> null && resp.Result.ValueCase = CallbackResult.ValueOneofCase.FloatArrayValue then
            resp.Result.FloatArrayValue.Values |> Seq.toArray
        else [||]

    /// Get the slope map as a flat float array. Values in [0, 1]. Returns empty array if not supported.
    member this.GetSlopeMap() : float32 array =
        let resp = this.SendCallback(uint32 CallbackId.CallbackMapGetSlopeMap, [])
        if resp.Success && resp.Result <> null && resp.Result.ValueCase = CallbackResult.ValueOneofCase.FloatArrayValue then
            resp.Result.FloatArrayValue.Values |> Seq.toArray
        else [||]

    /// Get the LOS (line-of-sight) map as a flat int array. Returns empty array if not supported.
    member this.GetLosMap() : int array =
        let resp = this.SendCallback(uint32 CallbackId.CallbackMapGetLosMap, [])
        if resp.Success && resp.Result <> null && resp.Result.ValueCase = CallbackResult.ValueOneofCase.IntArrayValue then
            resp.Result.IntArrayValue.Values |> Seq.map int |> Seq.toArray
        else [||]

    /// Get the radar map as a flat int array. Returns empty array if not supported.
    member this.GetRadarMap() : int array =
        let resp = this.SendCallback(uint32 CallbackId.CallbackMapGetRadarMap, [])
        if resp.Success && resp.Result <> null && resp.Result.ValueCase = CallbackResult.ValueOneofCase.IntArrayValue then
            resp.Result.IntArrayValue.Values |> Seq.map int |> Seq.toArray
        else [||]

    /// Get the resource map as a flat int array. resourceId: 0=metal, 1=energy. Returns empty array if not supported.
    member this.GetResourceMap(resourceId: int) : int array =
        let p = CallbackParam()
        p.IntValue <- resourceId
        let resp = this.SendCallback(uint32 CallbackId.CallbackMapGetResourceMap, [p])
        if resp.Success && resp.Result <> null && resp.Result.ValueCase = CallbackResult.ValueOneofCase.IntArrayValue then
            resp.Result.IntArrayValue.Values |> Seq.map int |> Seq.toArray
        else [||]

    /// Get the start position for a team.
    member this.GetStartPos(teamId: int) : (float32 * float32 * float32) =
        let p = CallbackParam()
        p.IntValue <- teamId
        let resp = this.SendCallback(uint32 CallbackId.CallbackMapGetStartPos, [p])
        if resp.Success && resp.Result <> null && resp.Result.ValueCase = CallbackResult.ValueOneofCase.VectorValue then
            let v = resp.Result.VectorValue
            (v.X, v.Y, v.Z)
        else (0.0f, 0.0f, 0.0f)

    /// Get metal spots on the map. Returns array of (x, y, z, value) tuples.
    member this.GetMetalSpots() : (float32 * float32 * float32 * float32) array =
        let resp = this.SendCallback(uint32 CallbackId.CallbackMapGetMetalSpots, [])
        if resp.Success && resp.Result <> null && resp.Result.ValueCase = CallbackResult.ValueOneofCase.FloatArrayValue then
            let vals = resp.Result.FloatArrayValue.Values
            // Metal spots come as groups of 4 floats: x, y, z, value
            [| for i in 0 .. 4 .. vals.Count - 4 do
                yield (vals.[i], vals.[i+1], vals.[i+2], vals.[i+3]) |]
        else [||]

    /// Get the current resource amount. resourceId: 0=metal, 1=energy.
    /// Returns Single.NaN for invalid resourceId; use Single.IsNaN to detect.
    member this.GetEconomyCurrent(resourceId: int) : float32 =
        let p = CallbackParam()
        p.IntValue <- resourceId
        let resp = this.SendCallback(uint32 CallbackId.CallbackEconomyGetCurrent, [p])
        if resp.Success && resp.Result <> null && resp.Result.ValueCase = CallbackResult.ValueOneofCase.FloatValue then
            resp.Result.FloatValue
        else 0.0f

    /// Get the resource income per second. resourceId: 0=metal, 1=energy.
    /// Returns Single.NaN for invalid resourceId; use Single.IsNaN to detect.
    member this.GetEconomyIncome(resourceId: int) : float32 =
        let p = CallbackParam()
        p.IntValue <- resourceId
        let resp = this.SendCallback(uint32 CallbackId.CallbackEconomyGetIncome, [p])
        if resp.Success && resp.Result <> null && resp.Result.ValueCase = CallbackResult.ValueOneofCase.FloatValue then
            resp.Result.FloatValue
        else 0.0f

    /// Get the resource usage per second. resourceId: 0=metal, 1=energy.
    /// Returns Single.NaN for invalid resourceId; use Single.IsNaN to detect.
    member this.GetEconomyUsage(resourceId: int) : float32 =
        let p = CallbackParam()
        p.IntValue <- resourceId
        let resp = this.SendCallback(uint32 CallbackId.CallbackEconomyGetUsage, [p])
        if resp.Success && resp.Result <> null && resp.Result.ValueCase = CallbackResult.ValueOneofCase.FloatValue then
            resp.Result.FloatValue
        else 0.0f

    /// Get the resource storage capacity. resourceId: 0=metal, 1=energy.
    /// Returns Single.NaN for invalid resourceId; use Single.IsNaN to detect.
    member this.GetEconomyStorage(resourceId: int) : float32 =
        let p = CallbackParam()
        p.IntValue <- resourceId
        let resp = this.SendCallback(uint32 CallbackId.CallbackEconomyGetStorage, [p])
        if resp.Success && resp.Result <> null && resp.Result.ValueCase = CallbackResult.ValueOneofCase.FloatValue then
            resp.Result.FloatValue
        else 0.0f

    /// Get position of a live unit. Returns (x, y, z).
    member this.GetUnitPos(unitId: int) : (float32 * float32 * float32) =
        let p = CallbackParam()
        p.IntValue <- unitId
        let resp = this.SendCallback(uint32 CallbackId.CallbackUnitGetPos, [p])
        if resp.Success && resp.Result <> null && resp.Result.ValueCase = CallbackResult.ValueOneofCase.VectorValue then
            let v = resp.Result.VectorValue
            (v.X, v.Y, v.Z)
        else (0.0f, 0.0f, 0.0f)

    /// Get health of a live unit.
    member this.GetUnitHealth(unitId: int) : float32 =
        let p = CallbackParam()
        p.IntValue <- unitId
        let resp = this.SendCallback(uint32 CallbackId.CallbackUnitGetHealth, [p])
        if resp.Success && resp.Result <> null && resp.Result.ValueCase = CallbackResult.ValueOneofCase.FloatValue then
            resp.Result.FloatValue
        else 0.0f

    /// Get max health of a live unit.
    member this.GetUnitMaxHealth(unitId: int) : float32 =
        let p = CallbackParam()
        p.IntValue <- unitId
        let resp = this.SendCallback(uint32 CallbackId.CallbackUnitGetMaxHealth, [p])
        if resp.Success && resp.Result <> null && resp.Result.ValueCase = CallbackResult.ValueOneofCase.FloatValue then
            resp.Result.FloatValue
        else 0.0f

    /// Get the team ID for a unit.
    member this.GetUnitTeam(unitId: int) : int =
        let p = CallbackParam()
        p.IntValue <- unitId
        let resp = this.SendCallback(uint32 CallbackId.CallbackUnitGetTeam, [p])
        if resp.Success && resp.Result <> null && resp.Result.ValueCase = CallbackResult.ValueOneofCase.IntValue then
            resp.Result.IntValue
        else -1

    /// Get the max speed for a unitDefId.
    member this.GetUnitMaxSpeed(unitId: int) : float32 =
        let p = CallbackParam()
        p.IntValue <- unitId
        let resp = this.SendCallback(uint32 CallbackId.CallbackUnitGetMaxSpeed, [p])
        if resp.Success && resp.Result <> null && resp.Result.ValueCase = CallbackResult.ValueOneofCase.FloatValue then
            resp.Result.FloatValue
        else 0.0f

    /// Get our team ID.
    member this.GetMyTeam() : int =
        let resp = this.SendCallback(uint32 CallbackId.CallbackGameGetMyTeam, [])
        if resp.Success && resp.Result <> null && resp.Result.ValueCase = CallbackResult.ValueOneofCase.IntValue then
            resp.Result.IntValue
        else -1

    /// Get our ally team ID.
    member this.GetMyAllyTeam() : int =
        let resp = this.SendCallback(uint32 CallbackId.CallbackGameGetMyAllyTeam, [])
        if resp.Success && resp.Result <> null && resp.Result.ValueCase = CallbackResult.ValueOneofCase.IntValue then
            resp.Result.IntValue
        else -1

    /// One-call per-tick gamestate snapshot. Returns every friendly, every
    /// LOS enemy, every radar-only enemy, plus the economy record — all from a
    /// single CallbackRequest/Response round-trip (feature 032).
    member this.GetGameState() : HighBar.Client.GameStateSnapshot =
        let resp = this.SendCallback(uint32 CallbackId.CallbackGameGetState, [])
        if not resp.Success then
            failwith (if System.String.IsNullOrEmpty(resp.ErrorMessage) then "GetGameState failed" else resp.ErrorMessage)
        if resp.Result = null || resp.Result.ValueCase <> CallbackResult.ValueOneofCase.SnapshotValue then
            failwith "GetGameState: response missing snapshot_value"
        HighBar.Client.GameStateSnapshot.fromProto resp.Result.SnapshotValue

    /// Enable or disable cheat events. Returns previous state.
    member this.SetCheatEventsEnabled(enabled: bool) : bool =
        let p = CallbackParam()
        p.IntValue <- if enabled then 1 else 0
        let resp = this.SendCallback(uint32 CallbackId.CallbackCheatsSetEventsEnabled, [p])
        if resp.Success && resp.Result <> null && resp.Result.ValueCase = CallbackResult.ValueOneofCase.IntValue then
            resp.Result.IntValue <> 0
        else false

    /// Disconnect from the proxy.
    member _.Disconnect() =
        stream |> Option.iter (fun s -> s.Dispose())
        socket |> Option.iter (fun s -> s.Dispose())
        stream <- None
        socket <- None

    interface IDisposable with
        member this.Dispose() = this.Disconnect()

    /// Convenience: connect, handshake, and return the client.
    static member Connect(socketPath: string) =
        let client = new HighBarClient(socketPath)
        client.Connect()
        client.Handshake() |> ignore
        client

    /// Create a listening socket, accept the proxy's connection, handshake, and return the client.
    /// This is the correct flow for live engine testing where the proxy connects to us.
    static member AcceptFromProxy(socketPath: string, timeoutMs: int) =
        // Clean up stale socket
        if File.Exists(socketPath) then File.Delete(socketPath)

        // Create listening socket
        let listener = new Socket(AddressFamily.Unix, SocketType.Stream, ProtocolType.Unspecified)
        let endpoint = UnixDomainSocketEndPoint(socketPath)
        listener.Bind(endpoint)
        listener.Listen(1)

        // Wait for proxy to connect with timeout
        if not (listener.Poll(timeoutMs * 1000, SelectMode.SelectRead)) then
            listener.Close()
            if File.Exists(socketPath) then File.Delete(socketPath)
            failwith $"Proxy did not connect within {timeoutMs}ms"

        let client = new HighBarClient(socketPath)
        client.AcceptFrom(listener)
        listener.Close() // Stop listening, we only need one connection
        client.Handshake() |> ignore
        client
