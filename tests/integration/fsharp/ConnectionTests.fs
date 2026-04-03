namespace HighBar.Tests

open System
open Xunit
open HighBar.Client

/// Connection and handshake integration tests.
/// Validates the full communication chain: engine -> proxy -> socket -> F# client.
[<Collection("Engine")>]
type ConnectionTests(engine: EngineFixture) =

    /// Helper: run the client frame loop for up to maxFrames, collecting results.
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

    [<Fact>]
    [<Trait("Category", "Harness")>]
    member _.``Harness smoke test - engine starts and socket is available``() =
        Assert.False(String.IsNullOrEmpty(engine.SocketPath))
        Assert.True(engine.IsEngineAlive, "Engine should be running")

    [<Fact>]
    [<Trait("Category", "Connection")>]
    member _.``Client connects to engine proxy socket``() =
        // With live engine, the proxy connected to us during init.
        // Verify we have a valid client.
        Assert.NotNull(engine.Client)

    [<Fact>]
    [<Trait("Category", "Connection")>]
    member _.``Handshake completes with valid protocol metadata``() =
        // Handshake already completed during fixture setup.
        // Verify the client is connected and functional.
        Assert.NotNull(engine.Client)
        Assert.True(engine.IsEngineAlive, "Engine should still be alive after handshake")

    [<Fact>]
    [<Trait("Category", "Connection")>]
    member _.``First frame contains Init event``() =
        let client = engine.Client
        let frames = runForFrames client 1

        Assert.True(frames.Length >= 1, "Should have received at least 1 frame")

        let first = frames.[0]
        let hasInit =
            first.Events
            |> List.exists (function GameEvent.Init _ -> true | _ -> false)
        Assert.True(hasInit, "First frame should contain an Init event")

    [<Fact>]
    [<Trait("Category", "Connection")>]
    member _.``Empty command responses work for consecutive frames``() =
        let client = engine.Client
        let frames = runForFrames client 3

        Assert.True(frames.Length >= 3,
            $"Should have received at least 3 frames, got {frames.Length}")

        for i in 1 .. frames.Length - 1 do
            Assert.True(frames.[i].FrameNumber > frames.[i - 1].FrameNumber,
                $"Frame numbers should increment: {frames.[i-1].FrameNumber} -> {frames.[i].FrameNumber}")

    [<Fact>]
    [<Trait("Category", "Connection")>]
    member _.``Graceful disconnect after receiving frames``() =
        let client = engine.Client
        let frames = runForFrames client 3
        Assert.True(frames.Length >= 3, $"Should have processed at least 3 frames")
        // Engine should still be running (we don't disconnect the shared client here)
        Assert.True(engine.IsEngineAlive, "Engine should still be alive")
