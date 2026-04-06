# Research: Extract and Save Map Data

## R1: Persistent Test Pattern for Map Data Queries

**Decision**: Follow the established T9_MapTests.fs pattern — use `engine.RunFrames(2, ...)` with a callback closure to issue map queries during frame processing.

**Rationale**: All callback queries in HighBar must execute inside `engine.RunFrames()` because the proxy only processes callbacks during the frame response cycle. T9 proves this pattern works for all 9 map data types. The new T11 test class will use the same `queryInFrame` helper pattern.

**Alternatives considered**:
- Direct client calls outside frame loop: Not possible — callbacks are only serviced during `c.Run()`.
- Separate test harness: Unnecessary complexity — PersistentEngineFixture already manages engine lifecycle.

## R2: Output Format for Map Data

**Decision**: Binary files (`.bin`) for large array data, CSV for structured records, JSON for the summary report.

**Rationale**:
- Binary preserves exact float32/int32 representation without precision loss from text conversion.
- Array data (heightmap: width×height floats) can be hundreds of KB — binary is 3-5x smaller than CSV.
- CSV for metal spots and start positions (small, human-readable, spreadsheet-compatible).
- JSON for the summary report (structured, parseable, human-readable).

**Alternatives considered**:
- All CSV: Precision loss for float32, large files for heightmaps.
- All JSON: Excessive overhead for array data, harder to load in analysis tools.
- Protobuf: Would add dependency for test output; binary is simpler for raw arrays.

## R3: Output Location Strategy

**Decision**: Write to `reports/map-data/{map-name}/` under the repo root for persistent artifacts. Also write to `engine.SessionDir` for ephemeral per-run copies available to the test report.

**Rationale**: Session directories (`/tmp/highbar-persistent-*`) are deleted after test runs unless `HIGHBAR_KEEP_LOGS` is set. For the purpose of this feature (save data for inspection), files must survive test cleanup. The `reports/` directory already exists for test reports and is gitignored.

**Alternatives considered**:
- Session dir only: Files lost on cleanup.
- Custom env var path: Adds configuration complexity for a test feature.

## R4: Null/Empty Validation Strategy

**Decision**: The F# client returns empty arrays `[||]` (not null) when a callback fails. Validation must check `Array.length > 0` for arrays, `> 0` for dimensions, and valid coordinate ranges for positions. Primary data types (dimensions, heightmap, corners heightmap) cause hard test failure; secondary types (LOS, radar) produce warnings via `output.WriteLine`.

**Rationale**: Client.fs lines 256-331 show that failed callbacks return `[||]` for arrays, `0` for dimensions, `(0.0f, 0.0f, 0.0f)` for positions. A zero-dimension return means the engine didn't provide the data. T9 uses `Option` wrapping to gracefully skip; T11 must assert instead.

**Alternatives considered**:
- Skip pattern (like T9): Doesn't meet the spec requirement to "MUST check that the data is not actually null."
- Null checks: Not applicable — F# client never returns null for these types.

## R5: Which Map to Test

**Decision**: Use the default map from `engine-version.json` — currently "Red Rock Desert v2". This map is already used by all persistent tests and is confirmed downloaded.

**Rationale**: No need to select a different map. Red Rock Desert v2 is a standard BAR map with metal spots, varied terrain, and multiple start positions — sufficient to exercise all map data types.

**Alternatives considered**:
- Parameterized multi-map: Out of scope per spec; adds significant test time.
- Specific map selection: No advantage over the default.
