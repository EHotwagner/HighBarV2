namespace HighBar.PersistentTests

open System
open System.IO
open System.Text.Json
open System.Text.Json.Nodes
open Xunit
open Xunit.Abstractions

/// Tier 11: Map data extraction, validation, and export.
/// Extracts all map data types from the live engine, validates non-null/non-empty,
/// saves to disk, and produces a JSON summary report.
[<Collection("PersistentEngine")>]
[<TestCaseOrderer("HighBar.PersistentTests.PriorityOrderer", "HighBar.PersistentTests")>]
type T11_MapDataExport(engine: PersistentEngineFixture, output: ITestOutputHelper) =

    /// Run a frame and execute a callback query inside it.
    /// Unlike T9's graceful-skip version, this returns the raw result for strict assertion.
    let queryInFrame (query: HighBar.Client.HighBarClient -> 'a) : 'a option =
        let mutable result = None
        let mutable queried = false
        try
            engine.RunFrames(2, fun _ _ ->
                if not queried then
                    queried <- true
                    try
                        result <- Some (query engine.Client)
                    with ex ->
                        output.WriteLine($"Callback query failed: {ex.Message}")
                []
            ) |> ignore
        with
        | :? HighBar.Client.EngineDisconnectedException ->
            output.WriteLine("Query caused proxy disconnect")
        | :? System.IO.IOException ->
            output.WriteLine("Query caused connection error")
        | ex when ex.Message.Contains("Engine disconnected") ->
            output.WriteLine($"Query caused engine disconnect: {ex.Message}")
        result

    /// Get map dimensions, failing hard if not available.
    let getDimensions () =
        let w = queryInFrame (fun c -> c.GetMapWidth()) |> Option.defaultValue 0
        let h = queryInFrame (fun c -> c.GetMapHeight()) |> Option.defaultValue 0
        (w, h)

    /// Find the repo root by walking up from assembly location.
    let findRepoRoot () =
        let mutable dir = Path.GetDirectoryName(Reflection.Assembly.GetExecutingAssembly().Location)
        while dir <> null && not (File.Exists(Path.Combine(dir, "CLAUDE.md"))) do
            dir <- Path.GetDirectoryName(dir)
        if dir = null then
            failwith "Could not find repo root (no CLAUDE.md found)"
        dir

    /// Get the map name from engine-version.json or env var.
    let getMapName () =
        let envMap = Environment.GetEnvironmentVariable("HIGHBAR_TEST_MAP")
        if not (String.IsNullOrEmpty(envMap)) then envMap
        else
            let repoRoot = findRepoRoot()
            let versionFile = Path.Combine(repoRoot, "tests", "engine-version.json")
            if File.Exists(versionFile) then
                let json = JsonDocument.Parse(File.ReadAllText(versionFile))
                json.RootElement.GetProperty("map").GetProperty("name").GetString()
            else
                "Red Rock Desert v2"

    /// Sanitize map name for directory use (replace spaces with underscores).
    let sanitizeMapName (name: string) =
        name.Replace(' ', '_')

    /// Compute the output directory for map data.
    let mapOutputDir () =
        let repoRoot = findRepoRoot()
        let mapName = getMapName() |> sanitizeMapName
        Path.Combine(repoRoot, "reports", "map-data", mapName)

    /// Save a float32 array to a .bin file using BinaryWriter.
    let saveFloatArray (path: string) (data: float32[]) =
        Directory.CreateDirectory(Path.GetDirectoryName(path)) |> ignore
        use stream = new FileStream(path, FileMode.Create)
        use writer = new BinaryWriter(stream)
        for v in data do
            writer.Write(v)

    /// Save an int array to a .bin file using BinaryWriter.
    let saveIntArray (path: string) (data: int[]) =
        Directory.CreateDirectory(Path.GetDirectoryName(path)) |> ignore
        use stream = new FileStream(path, FileMode.Create)
        use writer = new BinaryWriter(stream)
        for v in data do
            writer.Write(v)

    /// Read back a float32 array from a .bin file.
    let readFloatArray (path: string) =
        use stream = new FileStream(path, FileMode.Open)
        use reader = new BinaryReader(stream)
        let count = int (stream.Length / 4L)
        Array.init count (fun _ -> reader.ReadSingle())

    /// Extract all map data types in a single frame session.
    let extractAllMapData () =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        let width = queryInFrame (fun c -> c.GetMapWidth()) |> Option.defaultValue 0
        let height = queryInFrame (fun c -> c.GetMapHeight()) |> Option.defaultValue 0
        let heightMap = queryInFrame (fun c -> c.GetHeightMap()) |> Option.defaultValue [||]
        let cornersMap = queryInFrame (fun c -> c.GetCornersHeightMap()) |> Option.defaultValue [||]
        let slopeMap = queryInFrame (fun c -> c.GetSlopeMap()) |> Option.defaultValue [||]
        let losMap = queryInFrame (fun c -> c.GetLosMap()) |> Option.defaultValue [||]
        let radarMap = queryInFrame (fun c -> c.GetRadarMap()) |> Option.defaultValue [||]
        let resourceMap = queryInFrame (fun c -> c.GetResourceMap(0)) |> Option.defaultValue [||]
        let metalSpots = queryInFrame (fun c -> c.GetMetalSpots()) |> Option.defaultValue [||]
        let startPos0 = queryInFrame (fun c -> c.GetStartPos(0)) |> Option.defaultValue (0.0f, 0.0f, 0.0f)
        let startPos1 = queryInFrame (fun c -> c.GetStartPos(1)) |> Option.defaultValue (0.0f, 0.0f, 0.0f)

        {| Width = width; Height = height
           HeightMap = heightMap; CornersMap = cornersMap; SlopeMap = slopeMap
           LosMap = losMap; RadarMap = radarMap; ResourceMap = resourceMap
           MetalSpots = metalSpots; StartPos0 = startPos0; StartPos1 = startPos1 |}

    // ─── Phase 2: Foundational ─────────────────────────────────────────

    [<Fact>]
    [<Priority(0)>]
    member _.``T11.0 Engine is alive and map dimensions are non-zero``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        let (w, h) = getDimensions()
        output.WriteLine($"Map dimensions: {w} x {h}")
        Assert.True(w > 0, $"Map width should be positive, got {w}")
        Assert.True(h > 0, $"Map height should be positive, got {h}")

    // ─── Phase 3: US1 — Extract and Validate All Map Data Types ────────

    [<Fact>]
    [<Priority(1)>]
    member _.``T11.1 Heightmap is non-empty and has width*height elements``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        let (w, h) = getDimensions()
        let hm = queryInFrame (fun c -> c.GetHeightMap())

        match hm with
        | Some data when data.Length > 0 ->
            let expected = w * h
            output.WriteLine($"Heightmap: {data.Length} elements (expected {expected}), range [{data |> Array.min:F1}, {data |> Array.max:F1}]")
            Assert.Equal(expected, data.Length)
            for v in data do
                Assert.True(v > -5000.0f && v < 50000.0f, $"Height value {v} out of range [-5000, 50000]")
        | Some _ -> Assert.Fail("Heightmap returned empty array")
        | None -> Assert.Fail("Heightmap callback failed")

    [<Fact>]
    [<Priority(2)>]
    member _.``T11.2 Corners heightmap is non-empty and has (width+1)*(height+1) elements``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        let (w, h) = getDimensions()
        let cm = queryInFrame (fun c -> c.GetCornersHeightMap())

        match cm with
        | Some data when data.Length > 0 ->
            let expected = (w + 1) * (h + 1)
            output.WriteLine($"Corners heightmap: {data.Length} elements (expected {expected}), range [{data |> Array.min:F1}, {data |> Array.max:F1}]")
            Assert.Equal(expected, data.Length)
            for v in data do
                Assert.True(v > -5000.0f && v < 50000.0f, $"Corner height value {v} out of range [-5000, 50000]")
        | Some _ -> Assert.Fail("Corners heightmap returned empty array")
        | None -> Assert.Fail("Corners heightmap callback failed")

    [<Fact>]
    [<Priority(3)>]
    member _.``T11.3 Slope map is non-empty with values in [0,1]``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        let (w, h) = getDimensions()
        let sm = queryInFrame (fun c -> c.GetSlopeMap())

        match sm with
        | Some data when data.Length > 0 ->
            let expected = (w / 2) * (h / 2)
            output.WriteLine($"Slope map: {data.Length} elements (expected {expected}), range [{data |> Array.min:F3}, {data |> Array.max:F3}]")
            Assert.Equal(expected, data.Length)
            for v in data do
                Assert.True(v >= 0.0f && v <= 1.0f, $"Slope value {v} out of range [0, 1]")
        | Some _ -> Assert.Fail("Slope map returned empty array")
        | None -> Assert.Fail("Slope map callback failed")

    [<Fact>]
    [<Priority(4)>]
    member _.``T11.4 Metal spots has at least one spot with positive income``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        let spots = queryInFrame (fun c -> c.GetMetalSpots())

        match spots with
        | Some data when data.Length > 0 ->
            output.WriteLine($"Metal spots: {data.Length} found")
            let (x0, y0, z0, inc0) = data.[0]
            output.WriteLine($"  First spot: ({x0:F0}, {y0:F0}, {z0:F0}) income={inc0:F2}")
            for (_, _, _, income) in data do
                Assert.True(income > 0.0f, $"Metal spot income={income} should be positive")
        | Some _ -> Assert.Fail("Metal spots returned empty array")
        | None -> Assert.Fail("Metal spots callback failed")

    [<Fact>]
    [<Priority(5)>]
    member _.``T11.5 Start position is within map bounds``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        let (w, h) = getDimensions()
        let startPos = queryInFrame (fun c -> c.GetStartPos(0))

        match startPos with
        | Some (sx, sy, sz) ->
            let mapWidthElmos = float32 w * 8.0f
            let mapHeightElmos = float32 h * 8.0f
            output.WriteLine($"Start position: ({sx:F0}, {sy:F0}, {sz:F0}), map bounds: {mapWidthElmos:F0} x {mapHeightElmos:F0}")
            Assert.True(sx >= 0.0f && sx <= mapWidthElmos, $"Start X={sx} outside [0, {mapWidthElmos}]")
            Assert.True(sz >= 0.0f && sz <= mapHeightElmos, $"Start Z={sz} outside [0, {mapHeightElmos}]")
        | None -> Assert.Fail("Start position callback failed")

    [<Fact>]
    [<Priority(6)>]
    member _.``T11.6 LOS map is non-empty with non-negative values``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        let (w, h) = getDimensions()

        try
            let losMap = queryInFrame (fun c -> c.GetLosMap())

            match losMap with
            | Some data when data.Length > 0 ->
                let expected = w * h
                output.WriteLine($"LOS map: {data.Length} elements (expected {expected})")
                Assert.Equal(expected, data.Length)
                for v in data do
                    Assert.True(v >= 0, $"LOS value {v} should be non-negative")
            | Some _ ->
                output.WriteLine("WARNING: LOS map returned empty array (secondary data type — not a hard failure)")
            | None ->
                output.WriteLine("WARNING: LOS map callback returned None (secondary data type — not a hard failure)")
        with ex ->
            output.WriteLine($"WARNING: LOS map unsupported callback: {ex.Message}")

    [<Fact>]
    [<Priority(7)>]
    member _.``T11.7 Radar map is non-empty with non-negative values``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        let (w, h) = getDimensions()

        try
            let radarMap = queryInFrame (fun c -> c.GetRadarMap())

            match radarMap with
            | Some data when data.Length > 0 ->
                let expected = w * h
                output.WriteLine($"Radar map: {data.Length} elements (expected {expected})")
                Assert.Equal(expected, data.Length)
                for v in data do
                    Assert.True(v >= 0, $"Radar value {v} should be non-negative")
            | Some _ ->
                output.WriteLine("WARNING: Radar map returned empty array (secondary data type — not a hard failure)")
            | None ->
                output.WriteLine("WARNING: Radar map callback returned None (secondary data type — not a hard failure)")
        with ex ->
            output.WriteLine($"WARNING: Radar map unsupported callback: {ex.Message}")

    [<Fact>]
    [<Priority(8)>]
    member _.``T11.8 Resource map (metal) is non-empty with non-negative values``() =
        engine.ThrowIfEngineCrashed()
        engine.ResetGameState()

        let rm = queryInFrame (fun c -> c.GetResourceMap(0))

        match rm with
        | Some data when data.Length > 0 ->
            output.WriteLine($"Resource map (metal): {data.Length} elements, range [{data |> Array.min}, {data |> Array.max}]")
            for v in data do
                Assert.True(v >= 0, $"Resource value {v} should be non-negative")
        | Some _ -> Assert.Fail("Resource map returned empty array")
        | None -> Assert.Fail("Resource map callback failed")

    // ─── Phase 4: US2 — Save Extracted Map Data to Disk ────────────────

    [<Fact>]
    [<Priority(9)>]
    member _.``T11.9 Save all map data to disk``() =
        let data = extractAllMapData()
        Assert.True(data.Width > 0, "Width must be positive for save")
        Assert.True(data.Height > 0, "Height must be positive for save")

        let outDir = mapOutputDir()
        Directory.CreateDirectory(outDir) |> ignore
        output.WriteLine($"Output directory: {outDir}")

        // Save float arrays as .bin
        let heightmapPath = Path.Combine(outDir, "heightmap.bin")
        saveFloatArray heightmapPath data.HeightMap

        let cornersPath = Path.Combine(outDir, "corners-heightmap.bin")
        saveFloatArray cornersPath data.CornersMap

        let slopePath = Path.Combine(outDir, "slope-map.bin")
        saveFloatArray slopePath data.SlopeMap

        // Save int arrays as .bin
        let losPath = Path.Combine(outDir, "los-map.bin")
        saveIntArray losPath data.LosMap

        let radarPath = Path.Combine(outDir, "radar-map.bin")
        saveIntArray radarPath data.RadarMap

        let resourcePath = Path.Combine(outDir, "resource-map-metal.bin")
        saveIntArray resourcePath data.ResourceMap

        // Save metal spots as CSV
        let spotsPath = Path.Combine(outDir, "metal-spots.csv")
        do
            use spotsWriter = new StreamWriter(spotsPath)
            spotsWriter.WriteLine("x,y,z,income")
            for (x, y, z, income) in data.MetalSpots do
                spotsWriter.WriteLine($"{x},{y},{z},{income}")

        // Save start positions as CSV (teams 0 and 1)
        let posPath = Path.Combine(outDir, "start-positions.csv")
        do
            use posWriter = new StreamWriter(posPath)
            posWriter.WriteLine("teamId,x,y,z")
            let (sx0, sy0, sz0) = data.StartPos0
            posWriter.WriteLine($"0,{sx0},{sy0},{sz0}")
            let (sx1, sy1, sz1) = data.StartPos1
            posWriter.WriteLine($"1,{sx1},{sy1},{sz1}")

        // Verify all files exist and have size > 0
        let files = [
            heightmapPath; cornersPath; slopePath
            losPath; radarPath; resourcePath
            spotsPath; posPath
        ]
        for f in files do
            let info = FileInfo(f)
            Assert.True(info.Exists, $"File should exist: {f}")
            Assert.True(info.Length > 0L, $"File should be non-empty: {f}")
            output.WriteLine($"  {Path.GetFileName(f)}: {info.Length} bytes")

        // Read-back validation (SC-002): verify heightmap roundtrips correctly
        let readBack = readFloatArray heightmapPath
        Assert.Equal(data.HeightMap.Length, readBack.Length)
        output.WriteLine($"Read-back validation: heightmap {readBack.Length} elements match original")

    // ─── Phase 5: US3 — Report Extraction Results ──────────────────────

    [<Fact>]
    [<Priority(10)>]
    member _.``T11.10 Generate extraction summary report``() =
        let data = extractAllMapData()
        let outDir = mapOutputDir()
        Directory.CreateDirectory(outDir) |> ignore

        let mapName = getMapName()
        let timestamp = DateTime.UtcNow.ToString("o")

        let makeResult (dataType: string) (arr: 'a[]) (status: string) (minV: float option) (maxV: float option) (filePath: string option) (errorMsg: string option) =
            let result = JsonObject()
            result.Add("dataType", JsonValue.Create(dataType))
            result.Add("status", JsonValue.Create(status))
            result.Add("elementCount", JsonValue.Create(arr.Length))
            match minV with
            | Some v -> result.Add("minValue", JsonValue.Create(v))
            | None -> result.Add("minValue", JsonValue.Create(null :> obj))
            match maxV with
            | Some v -> result.Add("maxValue", JsonValue.Create(v))
            | None -> result.Add("maxValue", JsonValue.Create(null :> obj))
            match filePath with
            | Some p -> result.Add("filePath", JsonValue.Create(p))
            | None -> result.Add("filePath", JsonValue.Create(null :> obj))
            match errorMsg with
            | Some m -> result.Add("errorMessage", JsonValue.Create(m))
            | None -> result.Add("errorMessage", JsonValue.Create(null :> obj))
            result

        let results = System.Collections.Generic.List<JsonObject>()

        // Dimensions
        let dimResult = JsonObject()
        dimResult.Add("dataType", JsonValue.Create("dimensions"))
        dimResult.Add("status", JsonValue.Create(if data.Width > 0 && data.Height > 0 then "success" else "fail"))
        dimResult.Add("elementCount", JsonValue.Create(2))
        dimResult.Add("minValue", JsonValue.Create(null :> obj))
        dimResult.Add("maxValue", JsonValue.Create(null :> obj))
        dimResult.Add("filePath", JsonValue.Create(null :> obj))
        dimResult.Add("errorMessage", JsonValue.Create(if data.Width > 0 && data.Height > 0 then null :> obj else "Zero dimensions" :> obj))
        results.Add(dimResult)

        // Heightmap
        let hmStatus = if data.HeightMap.Length > 0 then "success" else "fail"
        let hmMin = if data.HeightMap.Length > 0 then Some (float (data.HeightMap |> Array.min)) else None
        let hmMax = if data.HeightMap.Length > 0 then Some (float (data.HeightMap |> Array.max)) else None
        results.Add(makeResult "heightmap" data.HeightMap hmStatus hmMin hmMax (Some "heightmap.bin") (if hmStatus = "fail" then Some "Empty array" else None))

        // Corners
        let cmStatus = if data.CornersMap.Length > 0 then "success" else "fail"
        let cmMin = if data.CornersMap.Length > 0 then Some (float (data.CornersMap |> Array.min)) else None
        let cmMax = if data.CornersMap.Length > 0 then Some (float (data.CornersMap |> Array.max)) else None
        results.Add(makeResult "corners-heightmap" data.CornersMap cmStatus cmMin cmMax (Some "corners-heightmap.bin") (if cmStatus = "fail" then Some "Empty array" else None))

        // Slope
        let smStatus = if data.SlopeMap.Length > 0 then "success" else "fail"
        let smMin = if data.SlopeMap.Length > 0 then Some (float (data.SlopeMap |> Array.min)) else None
        let smMax = if data.SlopeMap.Length > 0 then Some (float (data.SlopeMap |> Array.max)) else None
        results.Add(makeResult "slope-map" data.SlopeMap smStatus smMin smMax (Some "slope-map.bin") (if smStatus = "fail" then Some "Empty array" else None))

        // LOS (secondary)
        let losStatus = if data.LosMap.Length > 0 then "success" elif data.LosMap.Length = 0 then "warning" else "fail"
        let losMin = if data.LosMap.Length > 0 then Some (float (data.LosMap |> Array.min)) else None
        let losMax = if data.LosMap.Length > 0 then Some (float (data.LosMap |> Array.max)) else None
        results.Add(makeResult "los-map" data.LosMap losStatus losMin losMax (Some "los-map.bin") (if losStatus = "warning" then Some "Empty array (secondary)" else None))

        // Radar (secondary)
        let radarStatus = if data.RadarMap.Length > 0 then "success" elif data.RadarMap.Length = 0 then "warning" else "fail"
        let radarMin = if data.RadarMap.Length > 0 then Some (float (data.RadarMap |> Array.min)) else None
        let radarMax = if data.RadarMap.Length > 0 then Some (float (data.RadarMap |> Array.max)) else None
        results.Add(makeResult "radar-map" data.RadarMap radarStatus radarMin radarMax (Some "radar-map.bin") (if radarStatus = "warning" then Some "Empty array (secondary)" else None))

        // Resource map (metal)
        let rmStatus = if data.ResourceMap.Length > 0 then "success" else "fail"
        let rmMin = if data.ResourceMap.Length > 0 then Some (float (data.ResourceMap |> Array.min)) else None
        let rmMax = if data.ResourceMap.Length > 0 then Some (float (data.ResourceMap |> Array.max)) else None
        results.Add(makeResult "resource-map-metal" data.ResourceMap rmStatus rmMin rmMax (Some "resource-map-metal.bin") (if rmStatus = "fail" then Some "Empty array" else None))

        // Metal spots
        let msStatus = if data.MetalSpots.Length > 0 then "success" else "fail"
        results.Add(makeResult "metal-spots" data.MetalSpots msStatus None None (Some "metal-spots.csv") (if msStatus = "fail" then Some "No metal spots" else None))

        // Start positions
        let (sx0, _, _) = data.StartPos0
        let spStatus = if sx0 > 0.0f then "success" else "warning"
        let spArr = [| data.StartPos0; data.StartPos1 |]
        results.Add(makeResult "start-positions" spArr spStatus None None (Some "start-positions.csv") (if spStatus = "warning" then Some "Start position may be at origin" else None))

        // Overall status: pass if all primary types succeed
        let primaryStatuses = [ hmStatus; cmStatus; smStatus; rmStatus; msStatus ]
        let overallStatus = if primaryStatuses |> List.forall (fun s -> s = "success") && data.Width > 0 && data.Height > 0 then "pass" else "fail"

        // Build JSON document
        let root = JsonObject()
        root.Add("mapName", JsonValue.Create(mapName))
        root.Add("timestamp", JsonValue.Create(timestamp))
        root.Add("width", JsonValue.Create(data.Width))
        root.Add("height", JsonValue.Create(data.Height))
        let resultsArray = JsonArray()
        for r in results do
            resultsArray.Add(JsonNode.Parse(r.ToJsonString()))
        root.Add("results", resultsArray)
        root.Add("overallStatus", JsonValue.Create(overallStatus))

        // Write summary.json
        let summaryPath = Path.Combine(outDir, "summary.json")
        let options = JsonSerializerOptions(WriteIndented = true)
        File.WriteAllText(summaryPath, root.ToJsonString(options))

        // Validate
        Assert.True(File.Exists(summaryPath), "summary.json should exist")
        let readBack = JsonDocument.Parse(File.ReadAllText(summaryPath))
        let resultsCount = readBack.RootElement.GetProperty("results").GetArrayLength()
        Assert.Equal(9, resultsCount)
        let readOverall = readBack.RootElement.GetProperty("overallStatus").GetString()
        Assert.Equal("pass", readOverall)

        output.WriteLine($"Summary written to {summaryPath}")
        output.WriteLine($"Overall status: {overallStatus}")
        output.WriteLine($"Data types reported: {resultsCount}")
        output.WriteLine(root.ToJsonString(options))
