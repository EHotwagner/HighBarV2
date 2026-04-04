namespace HighBar.Client

open System
open System.IO
open System.Net.Sockets
open Google.Protobuf
open Highbar

/// Typed frame received from the proxy, containing parsed events.
type GameFrame = {
    FrameNumber: uint32
    Events: GameEvent list
}

/// Client connection to the HighBar proxy.
type HighBarClient(socketPath: string) =
    let mutable socket: Socket option = None
    let mutable stream: NetworkStream option = None
    let protocolVersion = 1u
    let mutable nextRequestId = 1u

    let sendMessage (s: NetworkStream) (msg: IMessage) =
        let data = msg.ToByteArray()
        let len = BitConverter.GetBytes(uint32 data.Length)
        if not BitConverter.IsLittleEndian then Array.Reverse(len)
        s.Write(len, 0, 4)
        s.Write(data, 0, data.Length)
        s.Flush()

    let recvBytes (s: NetworkStream) : byte[] =
        let headerBuf = Array.zeroCreate<byte> 4
        let mutable read = 0
        while read < 4 do
            read <- read + s.Read(headerBuf, read, 4 - read)
        if not BitConverter.IsLittleEndian then Array.Reverse(headerBuf)
        let len = BitConverter.ToInt32(headerBuf, 0)
        let dataBuf = Array.zeroCreate<byte> len
        read <- 0
        while read < len do
            read <- read + s.Read(dataBuf, read, len - read)
        dataBuf

    /// Connect to the proxy Unix domain socket (proxy is the client connecting to us).
    member _.Connect() =
        let endpoint = UnixDomainSocketEndPoint(socketPath)
        let sock = new Socket(AddressFamily.Unix, SocketType.Stream, ProtocolType.Unspecified)
        sock.Connect(endpoint)
        socket <- Some sock
        stream <- Some(new NetworkStream(sock, true))

    /// Accept a connection from the proxy on a pre-created listening socket.
    member _.AcceptFrom(listener: Socket) =
        let accepted = listener.Accept()
        socket <- Some accepted
        stream <- Some(new NetworkStream(accepted, true))

    /// Wrap an already-connected socket (e.g. accepted by the harness).
    member _.WrapSocket(connectedSocket: Socket) =
        socket <- Some connectedSocket
        stream <- Some(new NetworkStream(connectedSocket, false))

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
                let proxyMsg = ProxyMessage.Parser.ParseFrom(recvBytes s)
                match proxyMsg.MessageCase with
                | ProxyMessage.MessageOneofCase.Frame ->
                    let frame = proxyMsg.Frame
                    let events =
                        frame.Events
                        |> Seq.map Events.fromProto
                        |> Seq.toList
                    let gameFrame = {
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

    /// Send a callback request and receive the response.
    /// Must be called when the client has an active stream (during frame processing or init).
    member _.SendCallback(callbackId: uint32, callbackParams: CallbackParam list) : CallbackResponse =
        match stream with
        | None -> failwith "Not connected"
        | Some s ->
            let req = CallbackRequest()
            req.RequestId <- nextRequestId
            nextRequestId <- nextRequestId + 1u
            req.CallbackId <- callbackId
            for p in callbackParams do
                req.Params.Add(p)
            let msg = AIMessage()
            msg.CallbackRequest <- req
            sendMessage s msg

            let respBytes = recvBytes s
            let proxyMsg = ProxyMessage.Parser.ParseFrom(respBytes)
            match proxyMsg.MessageCase with
            | ProxyMessage.MessageOneofCase.CallbackResponse ->
                proxyMsg.CallbackResponse
            | other -> failwith $"Expected CallbackResponse, got {other}"

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
