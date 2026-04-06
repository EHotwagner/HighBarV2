# Tasks: Add Corners Heightmap Callback

**Input**: Design documents from `/specs/026-corners-heightmap-callback/`
**Prerequisites**: plan.md (required), spec.md (required for user stories), research.md, data-model.md, contracts/

**Tests**: Tests are included per FR-008 and FR-009 in the spec (mock proxy tests and live engine integration tests are explicit requirements).

**Organization**: Tasks are grouped by user story to enable independent implementation and testing of each story.

## Format: `[ID] [P?] [Story] Description`

- **[P]**: Can run in parallel (different files, no dependencies)
- **[Story]**: Which user story this task belongs to (e.g., US1, US2, US3)
- Include exact file paths in descriptions

## Phase 1: Setup (Protocol Definition)

**Purpose**: Define the new callback in the protocol schema and regenerate bindings

- [x] T001 Add `CALLBACK_MAP_GET_CORNERS_HEIGHT_MAP = 59` to CallbackId enum in proto/highbar/callbacks.proto (after CALLBACK_MAP_GET_METAL_SPOTS = 58)
- [x] T002 Run `buf lint` in proto/ directory to validate the schema change
- [x] T003 Run `buf generate` in proto/ directory to regenerate C and C# protobuf bindings

**Checkpoint**: Protocol updated — generated C enum `HIGHBAR__CALLBACK_ID__CALLBACK_MAP_GET_CORNERS_HEIGHT_MAP` and C# `CallbackId.CallbackMapGetCornersHeightMap` are available for downstream code.

---

## Phase 2: Foundational (Mock Engine Infrastructure)

**Purpose**: Add mock corners heightmap data and function to enable proxy testing

**CRITICAL**: Must complete before US1 proxy tests can run

- [x] T004 Add `mock_corners_heightmap[25]` static data array (5x5 values for a 4x4 map) in proxy/tests/mock_engine.c
- [x] T005 Add `mock_map_get_corners_height_map()` function in proxy/tests/mock_engine.c following the `mock_map_get_height_map` pattern (return count, cap at sizeMax, fill from static array)
- [x] T006 Register `mock_map_get_corners_height_map` in `mock_engine_create()` callback table in proxy/tests/mock_engine.c (set `cb.Map_getCornersHeightMap = mock_map_get_corners_height_map`)

**Checkpoint**: Mock engine can serve corners heightmap data — proxy handler and tests can now be built.

---

## Phase 3: User Story 1 - AI Retrieves Corners Heightmap Data (Priority: P1) MVP

**Goal**: The proxy handles CALLBACK_MAP_GET_CORNERS_HEIGHT_MAP requests by querying the engine's native `Map_getCornersHeightMap` API and returning a float array of (width+1)x(height+1) corner heights.

**Independent Test**: Send a corners heightmap callback request through the proxy (mock or live) and verify the returned float array has correct dimensions and values.

### Implementation for User Story 1

- [x] T007 [US1] Add case `HIGHBAR__CALLBACK_ID__CALLBACK_MAP_GET_CORNERS_HEIGHT_MAP` in `hb_callback_dispatch()` switch in proxy/src/callbacks.c — check `callback->Map_getCornersHeightMap && callback->Map_getWidth && callback->Map_getHeight`, allocate `(w+1)*(h+1)` buffer, call engine, return `make_float_array_response()`, free buffer
- [x] T008 [US1] Build proxy with `cmake -B build -DCMAKE_BUILD_TYPE=Release proxy/ && cmake --build build` to verify compilation

### Tests for User Story 1

- [x] T009 [US1] Add `test_get_corners_height_map` test in proxy/tests/test_callbacks.c — set map size 4x4, send request with callback_id 59, assert `n_values == 25`, assert sample values match mock data
- [x] T010 [US1] Run `ctest` in build/ directory to verify proxy test passes (and no regressions in existing tests)

**Checkpoint**: Proxy correctly handles corners heightmap callback with mock engine data. Core protocol → proxy → protobuf response path verified.

---

## Phase 4: User Story 2 - F# Client Exposes Corners Heightmap Method (Priority: P2)

**Goal**: F# client library provides a `GetCornersHeightMap()` method that returns a `float32 array`, following the same pattern as `GetHeightMap()`.

**Independent Test**: Call `GetCornersHeightMap()` from F# code against a live engine and verify the returned array has valid dimensions and data.

### Implementation for User Story 2

- [x] T011 [US2] Add `GetCornersHeightMap() : float32 array` method in clients/fsharp/src/Client.fs after `GetHeightMap()` — use `CallbackId.CallbackMapGetCornersHeightMap`, check `resp.Success` and `resp.Result.ValueCase = CallbackResult.ValueOneofCase.FloatArrayValue`, return `resp.Result.FloatArrayValue.Values |> Seq.toArray` or `[||]` on failure
- [x] T012 [US2] Build F# client with `dotnet build` in clients/fsharp/ to verify compilation

### Tests for User Story 2

- [x] T013 [US2] Add corners heightmap integration test in tests/persistent/fsharp/T9_MapTests.fs — query map dimensions first, call `GetCornersHeightMap()`, assert array length equals `(width+1)*(height+1)`, assert values are in valid range (> -5000, < 50000)
- [x] T014 [US2] Run live engine persistent tests with `./tests/run-all.sh --category persistent` to verify integration test passes and no regressions

**Checkpoint**: F# developers can retrieve corners heightmap through a single method call. End-to-end path (F# client → proxy → engine → proxy → F# client) verified against live engine.

---

## Phase 5: User Story 3 - Proxy Handles Corners Heightmap Errors Gracefully (Priority: P3)

**Goal**: The proxy returns structured error responses (not crashes) when the corners heightmap callback encounters error conditions.

**Independent Test**: Simulate error conditions (null callback pointer) in mock tests and verify the proxy returns an error response without crashing.

### Implementation for User Story 3

- [x] T015 [US3] Verify error handling in the proxy handler added in T007 — confirm the `if` guard checks all three function pointers (`Map_getCornersHeightMap`, `Map_getWidth`, `Map_getHeight`) and falls through to error path when any is null; confirm malloc failure returns `make_error_response()` in proxy/src/callbacks.c

### Tests for User Story 3

- [x] T016 [US3] Add `test_get_corners_height_map_unavailable` test in proxy/tests/test_callbacks.c — use a callback struct with `Map_getCornersHeightMap` set to NULL, send request, assert response is returned (not crash) with `success == 0`
- [x] T017 [US3] Run `ctest` in build/ directory to verify error handling test passes

**Checkpoint**: Proxy handles all error conditions gracefully. No crash paths exist for the corners heightmap callback.

---

## Phase 6: Polish & Cross-Cutting Concerns

**Purpose**: Final validation across all stories

- [x] T018 Run full test suite with `./tests/run-all.sh` to verify zero regressions across all test categories
- [x] T019 Verify `buf lint` passes in proto/ directory (development workflow requirement)
- [x] T020 Verify no generated code is staged for commit (development workflow requirement — generated code must not be checked in)

---

## Dependencies & Execution Order

### Phase Dependencies

- **Setup (Phase 1)**: No dependencies — start immediately
- **Foundational (Phase 2)**: Depends on Phase 1 (needs generated C enum for mock registration)
- **US1 (Phase 3)**: Depends on Phase 2 (needs mock engine for testing)
- **US2 (Phase 4)**: Depends on Phase 1 (needs generated C# enum) and Phase 3 (proxy must handle callback for live tests)
- **US3 (Phase 5)**: Depends on Phase 3 (handler must exist to test error paths)
- **Polish (Phase 6)**: Depends on all prior phases

### User Story Dependencies

- **User Story 1 (P1)**: After Phase 2 — no dependencies on other stories
- **User Story 2 (P2)**: After US1 — needs proxy handler working for end-to-end live tests
- **User Story 3 (P3)**: After US1 — needs proxy handler to test error paths

### Within Each Phase

- T001 → T002 → T003 (sequential: schema → lint → generate)
- T004, T005 sequential (data before function), T006 depends on T005
- T007 → T008 → T009 → T010 (implement → build → test → verify)
- T011 → T012 → T013 → T014 (implement → build → test → verify)
- T015 → T016 → T017 (verify → test → run)

### Parallel Opportunities

- T004-T006 (mock engine) can be written in a single editing session since they're all in the same file
- T007 (proxy handler) and T011 (F# client method) modify different files and could be written in parallel, but T011's live test (T013) depends on T007 being complete
- T018, T019, T020 in Phase 6 can run in parallel

---

## Parallel Example: Phase 2 + Phase 3

```bash
# All mock engine changes are in the same file (proxy/tests/mock_engine.c):
Task: T004 + T005 + T006 — add mock data, function, and registration together

# After mock engine is ready, proxy handler and test can be sequential:
Task: T007 — implement proxy handler in proxy/src/callbacks.c
Task: T008 — build proxy
Task: T009 — add proxy test in proxy/tests/test_callbacks.c
Task: T010 — run ctest
```

---

## Implementation Strategy

### MVP First (User Story 1 Only)

1. Complete Phase 1: Protocol definition (T001-T003)
2. Complete Phase 2: Mock engine infrastructure (T004-T006)
3. Complete Phase 3: Proxy handler + mock tests (T007-T010)
4. **STOP and VALIDATE**: Proxy correctly returns corners heightmap data via mock engine
5. This delivers the core callback capability — AI processes can request corners heightmap through the protocol

### Incremental Delivery

1. Phase 1 + 2 → Protocol and mock infrastructure ready
2. Add US1 (Phase 3) → Proxy handler works → MVP
3. Add US2 (Phase 4) → F# client method + live engine validation → Full integration
4. Add US3 (Phase 5) → Error handling verified → Production ready
5. Phase 6 → Final validation → Complete

### Sequential Execution (Single Developer)

This feature is small enough for sequential execution by a single developer:
1. T001-T003: Protocol (~5 min)
2. T004-T006: Mock engine (~10 min)
3. T007-T010: Proxy handler + tests (~15 min)
4. T011-T014: F# client + live tests (~15 min)
5. T015-T017: Error handling tests (~10 min)
6. T018-T020: Final validation (~5 min)

---

## Notes

- All changes are additions to existing files — no new files or directories needed
- The critical implementation detail is buffer size: `(w+1) * (h+1)` not `w * h`
- Proto codegen (T003) must complete before any C or F# code can reference the new callback ID
- Live engine tests (T013-T014) require the BAR headless engine — see `./tests/check-prerequisites.sh`
- Commit after each phase checkpoint using conventional commits format
