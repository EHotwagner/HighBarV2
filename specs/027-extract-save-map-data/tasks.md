# Tasks: Extract and Save Map Data

**Input**: Design documents from `/specs/027-extract-save-map-data/`
**Prerequisites**: plan.md (required), spec.md (required for user stories), research.md, data-model.md

**Organization**: Tasks are grouped by user story to enable independent implementation and testing of each story.

## Format: `[ID] [P?] [Story] Description`

- **[P]**: Can run in parallel (different files, no dependencies)
- **[Story]**: Which user story this task belongs to (e.g., US1, US2, US3)
- Include exact file paths in descriptions

---

## Phase 1: Setup (Shared Infrastructure)

**Purpose**: Project structure and output directory setup

- [x] T001 Create output directory `reports/map-data/` and ensure it is gitignored (check `reports/` in `.gitignore`)
- [x] T002 Add `T11_MapDataExport.fs` compile entry to `tests/persistent/fsharp/HighBar.PersistentTests.fsproj` between T10_EngineKillTests.fs and the closing `</ItemGroup>` tag

---

## Phase 2: Foundational (Blocking Prerequisites)

**Purpose**: Core test scaffolding that all user stories depend on

**CRITICAL**: No user story work can begin until this phase is complete

- [x] T003 Create `tests/persistent/fsharp/T11_MapDataExport.fs` with module declaration, xUnit imports, Collection("PersistentEngine") attribute, PriorityOrderer, constructor taking `PersistentEngineFixture` and `ITestOutputHelper`, and a `queryInFrame` helper function that wraps `engine.RunFrames(2, ...)` to execute a callback query and return the result
- [x] T004 Add a smoke test `T11.0 Engine is alive and map dimensions are non-zero` in `tests/persistent/fsharp/T11_MapDataExport.fs` (Priority 0) that calls `engine.ThrowIfEngineCrashed()`, queries `GetMapWidth()` and `GetMapHeight()` via `queryInFrame`, asserts both > 0, and logs the values via `output.WriteLine`

**Checkpoint**: `dotnet test tests/persistent/fsharp/ --filter "FullyQualifiedName~T11"` should pass T11.0

---

## Phase 3: User Story 1 - Extract and Validate All Map Data Types (Priority: P1) MVP

**Goal**: Extract every map data type from the live engine and assert each is non-null/non-empty with correct dimensions and value ranges.

**Independent Test**: Run persistent tests filtered to T11; all extraction tests pass with non-empty validated data.

### Implementation for User Story 1

- [x] T005 [P] [US1] Add test `T11.1 Heightmap is non-empty and has width*height elements` in `tests/persistent/fsharp/T11_MapDataExport.fs` (Priority 1): query `GetHeightMap()` via `queryInFrame`, assert `Array.length > 0`, assert length = width * height, assert all values in range [-5000f, 50000f], log element count and min/max values
- [x] T006 [P] [US1] Add test `T11.2 Corners heightmap is non-empty and has (width+1)*(height+1) elements` in `tests/persistent/fsharp/T11_MapDataExport.fs` (Priority 2): query `GetCornersHeightMap()` via `queryInFrame`, assert `Array.length > 0`, assert length = (width+1)*(height+1), assert values in range [-5000f, 50000f], log element count
- [x] T007 [P] [US1] Add test `T11.3 Slope map is non-empty with values in [0,1]` in `tests/persistent/fsharp/T11_MapDataExport.fs` (Priority 3): query `GetSlopeMap()` via `queryInFrame`, assert `Array.length > 0`, assert length = (width/2) * (height/2), assert all values >= 0.0f and <= 1.0f, log element count
- [x] T008 [P] [US1] Add test `T11.4 Metal spots has at least one spot with positive income` in `tests/persistent/fsharp/T11_MapDataExport.fs` (Priority 4): query `GetMetalSpots()` via `queryInFrame`, assert `Array.length > 0`, assert each spot has income > 0.0f, log spot count and first spot coordinates
- [x] T009 [P] [US1] Add test `T11.5 Start position is within map bounds` in `tests/persistent/fsharp/T11_MapDataExport.fs` (Priority 5): query `GetStartPos(0)` via `queryInFrame`, assert x >= 0 and x <= width*8, assert z >= 0 and z <= height*8 (elmos conversion), log coordinates
- [x] T010 [P] [US1] Add test `T11.6 LOS map is non-empty with non-negative values` in `tests/persistent/fsharp/T11_MapDataExport.fs` (Priority 6): query `GetLosMap()` via `queryInFrame`, if array is empty log warning via `output.WriteLine` (secondary data type, do not hard-fail), otherwise assert length = width * height and all values >= 0. If the client throws an exception (not just empty array), catch and log as "unsupported callback" distinct from "empty result" warning
- [x] T011 [P] [US1] Add test `T11.7 Radar map is non-empty with non-negative values` in `tests/persistent/fsharp/T11_MapDataExport.fs` (Priority 7): query `GetRadarMap()` via `queryInFrame`, if array is empty log warning (secondary), otherwise assert length = width * height and all values >= 0. If the client throws an exception (not just empty array), catch and log as "unsupported callback" distinct from "empty result" warning
- [x] T012 [P] [US1] Add test `T11.8 Resource map (metal) is non-empty with non-negative values` in `tests/persistent/fsharp/T11_MapDataExport.fs` (Priority 8): query `GetResourceMap(0)` via `queryInFrame`, assert `Array.length > 0`, assert all values >= 0, log element count

**Checkpoint**: All T11.0-T11.8 pass. Every primary data type returns non-empty validated data.

---

## Phase 4: User Story 2 - Save Extracted Map Data to Disk (Priority: P2)

**Goal**: Save all validated map data to persistent files in `reports/map-data/{map-name}/`.

**Independent Test**: After running T11 tests, output files exist at `reports/map-data/Red_Rock_Desert_v2/` and are non-empty.

### Implementation for User Story 2

- [x] T013 [US2] Add private helper functions in `tests/persistent/fsharp/T11_MapDataExport.fs`: `saveFloatArray` that writes a `float32[]` to a `.bin` file using `BinaryWriter` (4 bytes per float, little-endian), creating parent directories if needed; `saveIntArray` for `int[]` data; and `extractAllMapData` that queries all data types via `queryInFrame` and returns a record/tuple with all results (dimensions, heightmap, corners, slope, LOS, radar, resource, metal spots, start positions). This shared helper will be called by both T015 (save) and T016 (report) to avoid duplicating extraction logic.
- [x] T014 [US2] Add a private helper function `mapOutputDir` in `tests/persistent/fsharp/T11_MapDataExport.fs` that computes the output path as `{repoRoot}/reports/map-data/{sanitizedMapName}/` where `sanitizedMapName` replaces spaces with underscores. Determine `repoRoot` by walking up from the test assembly location to find the directory containing `.gitignore` or `CLAUDE.md`.
- [x] T015 [US2] Add test `T11.9 Save all map data to disk` in `tests/persistent/fsharp/T11_MapDataExport.fs` (Priority 9): call `extractAllMapData` to get all data types, create the output directory, save heightmap/corners/slope as `.bin` files via `saveFloatArray`, save LOS/radar/resource-map as `.bin` via `saveIntArray`, save metal spots as `metal-spots.csv` (header: x,y,z,income), save start positions as `start-positions.csv` (header: teamId,x,y,z) by querying GetStartPos for team IDs 0 and 1 (the two teams in default game setup), assert each output file exists and has size > 0. After saving, read back the heightmap `.bin` file, deserialize to `float32[]`, and assert the array length matches the original extraction (validates SC-002). Log all file paths and sizes via `output.WriteLine`

**Checkpoint**: Files exist at `reports/map-data/Red_Rock_Desert_v2/` with non-zero sizes.

---

## Phase 5: User Story 3 - Report Extraction Results (Priority: P3)

**Goal**: Produce a JSON summary report of all extraction results.

**Independent Test**: After running T11 tests, `reports/map-data/Red_Rock_Desert_v2/summary.json` exists and contains valid JSON with entries for all data types.

### Implementation for User Story 3

- [x] T016 [US3] Add test `T11.10 Generate extraction summary report` in `tests/persistent/fsharp/T11_MapDataExport.fs` (Priority 10): extract all data types, build a JSON summary object (using System.Text.Json) with fields: mapName, timestamp (ISO 8601), width, height, results array (one entry per data type with dataType, status, elementCount, minValue, maxValue, filePath, errorMessage), overallStatus ("pass" if all primary succeed). Write to `{outputDir}/summary.json`. Assert file exists, read it back, assert it contains entries for all 9 data types, assert overallStatus is "pass", log summary contents via `output.WriteLine`.

**Checkpoint**: `summary.json` is valid JSON with all data types reported.

---

## Phase 6: Polish & Cross-Cutting Concerns

**Purpose**: Final validation and cleanup

- [x] T017 Run full persistent test suite via `./tests/run-all.sh --category persistent` and verify T11 tests pass alongside existing T0-T10 tests without regression
- [x] T018 Verify `reports/map-data/` directory is in `.gitignore` (large binary files must not be committed)

---

## Dependencies & Execution Order

### Phase Dependencies

- **Setup (Phase 1)**: No dependencies — start immediately
- **Foundational (Phase 2)**: Depends on Phase 1 (T002 must precede T003)
- **User Story 1 (Phase 3)**: Depends on Phase 2 (T003, T004 must pass)
- **User Story 2 (Phase 4)**: Depends on Phase 3 (extraction logic must work before save)
- **User Story 3 (Phase 5)**: Depends on Phase 4 (save must work before summary)
- **Polish (Phase 6)**: Depends on all phases complete

### User Story Dependencies

- **User Story 1 (P1)**: Can start after Foundational — no cross-story dependencies
- **User Story 2 (P2)**: Depends on US1 data extraction logic being implemented
- **User Story 3 (P3)**: Depends on US2 save logic being implemented (summary references file paths)

### Within Each User Story

- US1: All T11.1-T11.8 tests are independent and marked [P] (different data types, same file but no data dependencies)
- US2: T013 and T014 (helpers) must precede T015 (save test)
- US3: T016 depends on save helpers from US2

### Parallel Opportunities

- T001 and T002 can run in parallel (different files)
- T005-T012 (all US1 extraction tests) can run in parallel — they query independent data types
- T013 and T014 (US2 helpers) can run in parallel

---

## Parallel Example: User Story 1

```bash
# Launch all extraction tests in parallel (different data types, no dependencies):
Task: "T11.1 Heightmap extraction" (T005)
Task: "T11.2 Corners heightmap extraction" (T006)
Task: "T11.3 Slope map extraction" (T007)
Task: "T11.4 Metal spots extraction" (T008)
Task: "T11.5 Start position extraction" (T009)
Task: "T11.6 LOS map extraction" (T010)
Task: "T11.7 Radar map extraction" (T011)
Task: "T11.8 Resource map extraction" (T012)
```

---

## Implementation Strategy

### MVP First (User Story 1 Only)

1. Complete Phase 1: Setup (T001-T002)
2. Complete Phase 2: Foundational (T003-T004)
3. Complete Phase 3: User Story 1 (T005-T012)
4. **STOP and VALIDATE**: Run `dotnet test tests/persistent/fsharp/ --filter "FullyQualifiedName~T11"` — all extraction tests pass with non-empty data
5. This alone proves the proxy+client can extract real map data from the engine

### Incremental Delivery

1. Setup + Foundational → T11.0 smoke test passes
2. Add User Story 1 → All data types validated → Core value delivered (MVP)
3. Add User Story 2 → Data saved to disk → Inspection/analysis enabled
4. Add User Story 3 → Summary report → Easy verification at a glance
5. Each story adds value without breaking previous stories

---

## Notes

- All callback queries MUST execute inside `engine.RunFrames()` — the proxy only processes callbacks during frame response
- F# client returns `[||]` (empty array) on failure, not null — validate with `Array.length > 0`
- Primary data types (dimensions, heightmap, corners) cause hard test failure; secondary (LOS, radar) produce warnings only
- Default test map: "Red Rock Desert v2" from `tests/engine-version.json`
- Output files in `reports/map-data/` must be gitignored (binary data)
- Commit after each phase checkpoint
