namespace HighBar.Tests

open System
open Xunit
open HighBar.Client

/// Connection and handshake integration tests.
/// Validates the full communication chain: engine -> proxy -> socket -> F# client.
[<Collection("Engine")>]
type ConnectionTests(engine: EngineFixture) =

    /// Helper: run the client frame loop for up to maxFrames, collecting results.
    /// Returns the list of captured GameFrames.
    let runForFrames (client: HighBarClient) (maxFrames: int) =
        let captured = ResizeArray<GameFrame>()
        try
            client.Run(fun frame ->
                captured.Add(frame)
                if captured.Count >= maxFrames then
                    failwith "CAPTURED_ENOUGH"
                []
            )
        with
        | ex when ex.Message = "CAPTURED_ENOUGH" -> ()
        captured |> Seq.toList

    // ---- Phase 2: Harness Smoke Test (T009) ----

    /// Verify the engine starts and the socket becomes available within timeout.
    [<Fact>]
    [<Trait("Category", "Harness")>]
    member _.``Harness smoke test - engine starts and socket is available``() =
        Assert.False(String.IsNullOrEmpty(engine.SocketPath))
        Assert.True(System.IO.File.Exists(engine.SocketPath),
            $"Socket file should exist at {engine.SocketPath}")

    // ---- Phase 3: US1 Connection Tests (T011-T015) ----

    /// T011: Client connects successfully to the running engine's proxy socket.
    [<Fact>]
    [<Trait("Category", "Connection")>]
    member _.``Client connects to engine proxy socket``() =
        use client = new HighBarClient(engine.SocketPath)
        client.Connect()
        client.Disconnect()

    /// T012: Handshake completes and returns valid protocol metadata.
    [<Fact>]
    [<Trait("Category", "Connection")>]
    member _.``Handshake completes with valid protocol metadata``() =
        use client = new HighBarClient(engine.SocketPath)
        client.Connect()
        let hs = client.Handshake()

        Assert.Equal(1u, hs.ProtocolVersion)
        Assert.False(String.IsNullOrEmpty(hs.EngineVersion),
            "Engine version should be non-empty")
        Assert.False(String.IsNullOrEmpty(hs.MapName),
            "Map name should be non-empty")
        Assert.True(hs.TeamId >= 0, $"Team ID should be >= 0, got {hs.TeamId}")

        client.Disconnect()

    /// T013: First frame contains Init event with valid data.
    [<Fact>]
    [<Trait("Category", "Connection")>]
    member _.``First frame contains Init event``() =
        use client = new HighBarClient(engine.SocketPath)
        client.Connect()
        let _hs = client.Handshake()

        let frames = runForFrames client 1

        Assert.True(frames.Length >= 1, "Should have received at least 1 frame")

        let first = frames.[0]
        let hasInit =
            first.Events
            |> List.exists (function GameEvent.Init _ -> true | _ -> false)
        Assert.True(hasInit, "First frame should contain an Init event")
        Assert.True(first.FrameNumber <= 1u,
            $"First frame number should be 0 or 1, got {first.FrameNumber}")

        client.Disconnect()

    /// T014: Empty command responses work for multiple consecutive frames with incrementing frame numbers.
    [<Fact>]
    [<Trait("Category", "Connection")>]
    member _.``Empty command responses work for consecutive frames``() =
        use client = new HighBarClient(engine.SocketPath)
        client.Connect()
        let _hs = client.Handshake()

        let frames = runForFrames client 3

        Assert.True(frames.Length >= 3,
            $"Should have received at least 3 frames, got {frames.Length}")

        // Verify frame numbers increment
        for i in 1 .. frames.Length - 1 do
            Assert.True(frames.[i].FrameNumber > frames.[i - 1].FrameNumber,
                $"Frame numbers should increment: {frames.[i-1].FrameNumber} -> {frames.[i].FrameNumber}")

        client.Disconnect()

    /// T015: Graceful disconnect after receiving frames completes without error.
    [<Fact>]
    [<Trait("Category", "Connection")>]
    member _.``Graceful disconnect after receiving frames``() =
        use client = new HighBarClient(engine.SocketPath)
        client.Connect()
        let _hs = client.Handshake()

        let frames = runForFrames client 3
        Assert.True(frames.Length >= 3, $"Should have processed at least 3 frames")

        // Disconnect should complete without throwing
        client.Disconnect()
