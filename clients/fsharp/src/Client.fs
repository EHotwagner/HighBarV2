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
