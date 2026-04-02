open System
open System.IO
open System.Net.Sockets
open System.Threading
open Google.Protobuf
open Highbar
open HighBar.Replay

/// Replay playback tool: reads a recorded session file and feeds events
/// to an AI process as if it were the proxy.
[<EntryPoint>]
let main argv =
    let usage () =
        printfn "Usage: replay <file.hbrp> [--socket <path>] [--speed <multiplier>]"
        printfn "  file.hbrp      Recorded session file"
        printfn "  --socket       AI socket path (default: /tmp/highbar.sock)"
        printfn "  --speed        Playback speed multiplier (default: 0 = max speed)"
        1

    if argv.Length < 1 then
        usage() |> ignore
        exit 1

    let replayFile = argv[0]
    let mutable socketPath = "/tmp/highbar.sock"
    let mutable speed = 0.0

    let mutable i = 1
    while i < argv.Length do
        match argv[i] with
        | "--socket" when i + 1 < argv.Length ->
            socketPath <- argv[i + 1]
            i <- i + 2
        | "--speed" when i + 1 < argv.Length ->
            speed <- Double.Parse(argv[i + 1])
            i <- i + 2
        | _ -> i <- i + 1

    printfn "Replaying %s to %s (speed: %s)" replayFile socketPath
        (if speed = 0.0 then "max" else $"{speed}x")

    use fileStream = File.OpenRead(replayFile)
    use reader = new BinaryReader(fileStream)

    let header = ReplayFormat.readHeader reader
    printfn "Replay version %d, recorded at %O" header.Version header.Timestamp

    // Connect to AI process
    let endpoint = Net.UnixDomainSocketEndPoint(socketPath)
    use sock = new Socket(AddressFamily.Unix, SocketType.Stream, ProtocolType.Unspecified)
    sock.Connect(endpoint)
    use stream = new NetworkStream(sock, true)

    let sendMsg (data: byte[]) =
        let header = BitConverter.GetBytes(uint32 data.Length)
        stream.Write(header, 0, 4)
        stream.Write(data, 0, data.Length)
        stream.Flush()

    let recvMsg () =
        let headerBuf = Array.zeroCreate<byte> 4
        let mutable read = 0
        while read < 4 do
            read <- read + stream.Read(headerBuf, read, 4 - read)
        let len = BitConverter.ToInt32(headerBuf, 0)
        let buf = Array.zeroCreate<byte> len
        read <- 0
        while read < len do
            read <- read + stream.Read(buf, read, len - read)
        buf

    let mutable lastFrame = 0u
    let mutable recordCount = 0

    let mutable keepReading = true
    while keepReading do
        match ReplayFormat.readRecord reader with
        | None -> keepReading <- false
        | Some record ->
            recordCount <- recordCount + 1

            // Add delay between frames for paced playback
            if speed > 0.0 && record.FrameNumber > lastFrame then
                let frameDelta = record.FrameNumber - lastFrame
                let delayMs = float frameDelta * (1000.0 / 30.0) / speed
                Thread.Sleep(int delayMs)

            lastFrame <- record.FrameNumber

            if record.Direction = 0uy then
                // Proxy → AI: send to AI
                sendMsg record.Data
            else
                // AI → Proxy: receive and discard (we're replaying, not the AI)
                let _ = recvMsg()
                ()

    printfn "Replay complete: %d records played" recordCount
    0
