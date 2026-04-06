namespace HighBar.PersistentTests

open Xunit
open Xunit.Abstractions

/// Tier 9: Map query tests — adopted from FSBarV1 patterns.
/// Uses graceful skip if proxy doesn't support map callbacks.
[<Collection("PersistentEngine")>]
[<TestCaseOrderer("HighBar.PersistentTests.PriorityOrderer", "HighBar.PersistentTests")>]
type T9_MapTests(engine: PersistentEngineFixture, output: ITestOutputHelper) =

    /// Run a single frame and execute a callback query inside it.
    /// Returns None if the query fails (proxy doesn't support the callback).
    let queryInFrame (query: HighBar.Client.HighBarClient -> 'a) =
        let mutable result = None
        let mutable queried = false
        try
            engine.RunFrames(2, fun _ _ ->
                if not queried then
                    queried <- true
                    try
                        result <- Some (query engine.Client)
                    with ex ->
                        output.WriteLine($"Map callback not supported: {ex.Message}")
                []
            ) |> ignore
        with
        | :? HighBar.Client.EngineDisconnectedException ->
            output.WriteLine("Map query caused proxy disconnect — callback not supported")
        | :? System.IO.IOException ->
            output.WriteLine("Map query caused connection error — callback not supported")
        | ex when ex.Message.Contains("Engine disconnected") ->
            output.WriteLine($"Map query caused engine disconnect: {ex.Message}")
        result

    [<Fact>]
    [<Priority(1)>]
    member _.``T9.1 Map dimensions — width and height are positive``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        let width = queryInFrame (fun c -> c.GetMapWidth())
        let height = queryInFrame (fun c -> c.GetMapHeight())

        match width, height with
        | Some w, Some h ->
            output.WriteLine($"Map dimensions: {w} x {h}")
            Assert.True(w > 0, $"Map width should be positive, got {w}")
            Assert.True(h > 0, $"Map height should be positive, got {h}")
        | _ ->
            Assert.Fail("Map dimension callbacks should be supported by proxy")

    [<Fact>]
    [<Priority(4)>]
    member _.``T9.2 Height map — non-empty array with valid float values``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        let heightMap = queryInFrame (fun c -> c.GetHeightMap())

        match heightMap with
        | Some hm when hm.Length > 0 ->
            output.WriteLine($"Height map: {hm.Length} values, range [{hm |> Array.min:F1}, {hm |> Array.max:F1}]")
            Assert.True(hm.Length > 0, "Height map should be non-empty")
            // Height values should be within reasonable range (-500 to 5000 elmos)
            for h in hm do
                Assert.True(h > -5000.0f && h < 50000.0f, $"Height value {h} out of expected range")
        | Some _ ->
            Assert.Fail("Height map returned empty — proxy should return data")
        | None ->
            Assert.Fail("Height map callback should be supported by proxy")

    [<Fact>]
    [<Priority(2)>]
    member _.``T9.3 Start position — valid coordinates within map bounds``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        let width = queryInFrame (fun c -> c.GetMapWidth())
        let height = queryInFrame (fun c -> c.GetMapHeight())
        let startPos = queryInFrame (fun c -> c.GetStartPos(0))

        match startPos, width, height with
        | Some (sx, sy, sz), Some w, Some h ->
            output.WriteLine($"Start position: ({sx:F0}, {sy:F0}, {sz:F0}), map: {w}x{h}")
            // Start position should be within map bounds (elmo coordinates)
            let mapWidthElmos = float32 w * 8.0f
            let mapHeightElmos = float32 h * 8.0f
            Assert.True(sx >= 0.0f && sx <= mapWidthElmos, $"Start X={sx} should be within [0, {mapWidthElmos}]")
            Assert.True(sz >= 0.0f && sz <= mapHeightElmos, $"Start Z={sz} should be within [0, {mapHeightElmos}]")
        | _ ->
            Assert.Fail("Start position and map dimension callbacks should be supported by proxy")

    [<Fact>]
    [<Priority(3)>]
    member _.``T9.4 Metal spots — at least 1 spot with positive income``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        let spots = queryInFrame (fun c -> c.GetMetalSpots())

        match spots with
        | Some s when s.Length > 0 ->
            output.WriteLine($"Metal spots: {s.Length} found")
            // At least 1 spot should exist on a real map
            Assert.True(s.Length >= 1, $"Expected at least 1 metal spot, got {s.Length}")
            // Each spot should have positive coordinates and income
            for (x, y, z, income) in s do
                Assert.True(x >= 0.0f, $"Metal spot X={x} should be non-negative")
                Assert.True(z >= 0.0f, $"Metal spot Z={z} should be non-negative")
                Assert.True(income > 0.0f, $"Metal spot income={income} should be positive")
                output.WriteLine($"  Spot: ({x:F0}, {y:F0}, {z:F0}) income={income:F2}")
        | Some _ ->
            Assert.Fail("Metal spots should be non-empty on a real map")
        | None ->
            Assert.Fail("Metal spots callback should be supported by proxy")

    [<Fact>]
    [<Priority(5)>]
    member _.``T9.9 Corners height map — non-empty array with valid float values and correct dimensions``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        let width = queryInFrame (fun c -> c.GetMapWidth())
        let height = queryInFrame (fun c -> c.GetMapHeight())
        let cornersMap = queryInFrame (fun c -> c.GetCornersHeightMap())

        match cornersMap, width, height with
        | Some cm, Some w, Some h when cm.Length > 0 ->
            let expectedSize = (w + 1) * (h + 1)
            output.WriteLine($"Corners height map: {cm.Length} values (expected {expectedSize}), range [{cm |> Array.min:F1}, {cm |> Array.max:F1}]")
            Assert.Equal(expectedSize, cm.Length)
            for v in cm do
                Assert.True(v > -5000.0f && v < 50000.0f, $"Corner height value {v} out of expected range")
        | Some _, _, _ ->
            Assert.Fail("Corners height map returned empty — proxy should return data")
        | None, _, _ ->
            Assert.Fail("Corners height map callback should be supported by proxy")

    [<Fact>]
    [<Priority(5)>]
    member _.``T9.5 Slope map — non-empty array with values in [0, 1]``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        let slopeMap = queryInFrame (fun c -> c.GetSlopeMap())

        match slopeMap with
        | Some sm when sm.Length > 0 ->
            output.WriteLine($"Slope map: {sm.Length} values, range [{sm |> Array.min:F3}, {sm |> Array.max:F3}]")
            for v in sm do
                Assert.True(v >= 0.0f && v <= 1.0f, $"Slope value {v} should be in [0, 1]")
        | Some _ ->
            Assert.Fail("Slope map returned empty — proxy should return data")
        | None ->
            Assert.Fail("Slope map callback should be supported by proxy")

    [<Fact>]
    [<Priority(6)>]
    member _.``T9.6 LOS map — non-empty int array``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        let losMap = queryInFrame (fun c -> c.GetLosMap())

        match losMap with
        | Some lm when lm.Length > 0 ->
            output.WriteLine($"LOS map: {lm.Length} values, range [{lm |> Array.min}, {lm |> Array.max}]")
            for v in lm do
                Assert.True(v >= 0, $"LOS value {v} should be non-negative")
        | Some _ ->
            Assert.Fail("LOS map returned empty — proxy should return data")
        | None ->
            Assert.Fail("LOS map callback should be supported by proxy")

    [<Fact>]
    [<Priority(7)>]
    member _.``T9.7 Radar map — non-empty int array``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        let radarMap = queryInFrame (fun c -> c.GetRadarMap())

        match radarMap with
        | Some rm when rm.Length > 0 ->
            output.WriteLine($"Radar map: {rm.Length} values, range [{rm |> Array.min}, {rm |> Array.max}]")
            for v in rm do
                Assert.True(v >= 0, $"Radar value {v} should be non-negative")
        | Some _ ->
            Assert.Fail("Radar map returned empty — proxy should return data")
        | None ->
            Assert.Fail("Radar map callback should be supported by proxy")

    [<Fact>]
    [<Priority(8)>]
    member _.``T9.8 Resource map — metal density non-empty with non-negative values``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        let resourceMap = queryInFrame (fun c -> c.GetResourceMap(0))

        match resourceMap with
        | Some rm when rm.Length > 0 ->
            output.WriteLine($"Resource map (metal): {rm.Length} values, range [{rm |> Array.min}, {rm |> Array.max}]")
            for v in rm do
                Assert.True(v >= 0, $"Resource value {v} should be non-negative")
        | Some _ ->
            Assert.Fail("Resource map returned empty — proxy should return data")
        | None ->
            Assert.Fail("Resource map callback should be supported by proxy")
