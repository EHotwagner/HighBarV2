# Tasks: Map Data Callbacks & Proxy Protocol Fixes

**Input**: Design documents from `/specs/021-map-callbacks-proxy/`
**Prerequisites**: plan.md, spec.md, research.md, data-model.md

**Tests**: Included — FR-009 in the spec requires test coverage for all new callback handlers.

**Organization**: Tasks grouped by user story. Each story adds independent callback handlers that can be tested in isolation.

## Format: `[ID] [P?] [Story] Description`

- **[P]**: Can run in parallel (different files or non-overlapping code sections)
- **[Story]**: Which user story this task belongs to (US1-US5)
- All file paths relative to repository root

---

## Phase 1: Setup

**Purpose**: No project setup needed — existing proxy project and build system are in place.

*No tasks — project structure, CMake build, and proto codegen already exist.*

---

## Phase 2: Foundational (Blocking Prerequisites)

**Purpose**: Helper function and mock infrastructure that ALL user stories depend on.

**⚠️ CRITICAL**: No user story work can begin until this phase is complete.

- [x] T001 Implement `make_float_array_response` helper function in `proxy/src/callbacks.c`, mirroring the existing `make_int_array_response` pattern (lines 80-104). Must allocate `Highbar__FloatArray` via arena, set `value_case = HIGHBAR__CALLBACK_RESULT__VALUE_FLOAT_ARRAY_VALUE`, and `memcpy` source float data into arena-allocated array.
- [x] T002 [P] Add mock Map data function implementations in `proxy/tests/mock_engine.c` and declarations in `proxy/tests/mock_engine.h`. Add static arrays for mock heightmap, slopemap, LOS, radar, resource map data (small 4x4 grids = 16 elements). Add mock implementations for: `Map_getHeightMap`, `Map_getSlopeMap`, `Map_getLosMap`, `Map_getRadarMap`, `Map_getResourceMapRaw`, `Map_getStartPos`, `Map_getResourceMapSpotsPositions`, `Map_getResourceMapSpotsAverageIncome`. Wire all into `mock_engine_create()` struct initialization. Follow existing pattern of `mock_map_get_width`/`mock_map_get_height`.
- [x] T003 [P] Add `RUN(test_*)` entries for all 10 new test functions (T007-T009, T012-T013, T016-T020) in the `main()` function of `proxy/tests/test_callbacks.c`. This prepares the test runner to execute the tests as they are added in subsequent phases.

**Checkpoint**: `make_float_array_response` compiles, mock engine has all Map function pointers populated, test runner is prepared.

---

## Phase 3: User Story 1 — AI Reads Map Terrain Data (Priority: P1) 🎯 MVP

**Goal**: Callbacks 52 (heightmap), 53 (slopemap), and 56 (resource map) return correct data arrays from the engine.

**Independent Test**: Request each map data type through proxy dispatch with mock engine and verify returned arrays have correct dimensions and values.

### Implementation for User Story 1

- [x] T004 [P] [US1] Implement case handler for `CALLBACK_MAP_GET_HEIGHT_MAP` (ID 52) in `proxy/src/callbacks.c`, after the existing `CALLBACK_MAP_GET_HEIGHT` case (line 167). Use `malloc` for raw float buffer (size = `Map_getWidth * Map_getHeight * sizeof(float)`), call `callback->Map_getHeightMap`, pass to `make_float_array_response`, then `free` the raw buffer. Check `Map_getHeightMap`, `Map_getWidth`, and `Map_getHeight` function pointers before calling.
- [x] T005 [P] [US1] Implement case handler for `CALLBACK_MAP_GET_SLOPE_MAP` (ID 53) in `proxy/src/callbacks.c`. Use `malloc` for raw float buffer (size = `(w/2) * (h/2) * sizeof(float)`), call `callback->Map_getSlopeMap`, pass to `make_float_array_response`, then `free`.
- [x] T006 [P] [US1] Implement case handler for `CALLBACK_MAP_GET_RESOURCE_MAP` (ID 56) in `proxy/src/callbacks.c`. Extract resource ID parameter via `get_int_param(request, 0, 0)` (default metal=0). Allocate `short*` buffer via `malloc` (size = `(w/2) * (h/2) * sizeof(short)`), call `callback->Map_getResourceMapRaw`. Widen `short` → `int32_t` in a loop into a second `malloc`'d buffer. Pass widened buffer to `make_int_array_response`. Free both buffers.
- [x] T007 [P] [US1] Add test `test_get_height_map` in `proxy/tests/test_callbacks.c`. Create `CallbackRequest` with `CALLBACK_MAP_GET_HEIGHT_MAP`, dispatch with mock engine (4x4 = 16 floats), assert response `success == 1`, `value_case == FLOAT_ARRAY_VALUE`, `n_values == 16`, verify values match mock data.
- [x] T008 [P] [US1] Add test `test_get_slope_map` in `proxy/tests/test_callbacks.c`. Create request with `CALLBACK_MAP_GET_SLOPE_MAP`, dispatch with mock engine (2x2 = 4 floats for 4x4 map), assert `n_values == 4` and values match mock data.
- [x] T009 [P] [US1] Add test `test_get_resource_map` in `proxy/tests/test_callbacks.c`. Create request with `CALLBACK_MAP_GET_RESOURCE_MAP` and int param `0` (metal). Assert response is `INT_ARRAY_VALUE`, `n_values == 4` (for 4x4 map → 2x2 resource grid), values match mock short data widened to int32.

**Checkpoint**: `cmake --build build && cd build && ctest` — tests for callbacks 52, 53, 56 pass. MVP terrain data is functional.

---

## Phase 4: User Story 2 — AI Reads Visibility and Radar Data (Priority: P1)

**Goal**: Callbacks 54 (LOS map) and 55 (radar map) return correct integer arrays from the engine.

**Independent Test**: Request LOS and radar maps through proxy dispatch with mock engine and verify returned integer arrays have correct values.

### Implementation for User Story 2

- [x] T010 [P] [US2] Implement case handler for `CALLBACK_MAP_GET_LOS_MAP` (ID 54) in `proxy/src/callbacks.c`. Use `malloc` for raw int buffer (upper bound size = `w * h * sizeof(int)`), call `callback->Map_getLosMap`, pass to `make_int_array_response` with actual returned count, then `free`.
- [x] T011 [P] [US2] Implement case handler for `CALLBACK_MAP_GET_RADAR_MAP` (ID 55) in `proxy/src/callbacks.c`. Same pattern as LOS map — `malloc`, call `callback->Map_getRadarMap`, `make_int_array_response`, `free`.
- [x] T012 [P] [US2] Add test `test_get_los_map` in `proxy/tests/test_callbacks.c`. Create request with `CALLBACK_MAP_GET_LOS_MAP`, dispatch with mock engine, assert `INT_ARRAY_VALUE` with correct count and values.
- [x] T013 [P] [US2] Add test `test_get_radar_map` in `proxy/tests/test_callbacks.c`. Same pattern as LOS test with `CALLBACK_MAP_GET_RADAR_MAP`.

**Checkpoint**: Tests for callbacks 54, 55 pass. Visibility data is functional.

---

## Phase 5: User Story 3 — AI Queries Start Position and Metal Spots (Priority: P1)

**Goal**: Callback 57 (start position) returns a Vector3 and callback 58 (metal spots) returns a packed FloatArray of positions with income values.

**Independent Test**: Request start position and metal spots through proxy dispatch with mock engine and verify Vector3 coordinates and packed float4 array layout.

### Implementation for User Story 3

- [x] T014 [P] [US3] Implement case handler for `CALLBACK_MAP_GET_START_POS` (ID 57) in `proxy/src/callbacks.c`. Check `callback->Map_getStartPos` pointer, call with `float pos[3]` stack buffer, return via existing `make_vec3_response(req_id, pos[0], pos[1], pos[2], alloc)`.
- [x] T015 [P] [US3] Implement case handler for `CALLBACK_MAP_GET_METAL_SPOTS` (ID 58) in `proxy/src/callbacks.c`. Allocate `float*` positions buffer via `malloc` (max 256 spots × 3 floats). Call `callback->Map_getResourceMapSpotsPositions(skirmish_ai_id, 0, positions, max*3)`. Get `avg_income` from `Map_getResourceMapSpotsAverageIncome` if available. Pack into float4 array (x,y,z,income per spot) via arena allocation. Free positions buffer. Return via `make_float_array_response`.
- [x] T016 [P] [US3] Add test `test_get_start_pos` in `proxy/tests/test_callbacks.c`. Create request with `CALLBACK_MAP_GET_START_POS`, dispatch with mock engine that returns known coordinates, assert `VECTOR_VALUE` with correct x, y, z.
- [x] T017 [P] [US3] Add test `test_get_metal_spots` in `proxy/tests/test_callbacks.c`. Create request with `CALLBACK_MAP_GET_METAL_SPOTS`, dispatch with mock engine returning 2 spots (6 position floats + avg income). Assert `FLOAT_ARRAY_VALUE` with `n_values == 8` (2 spots × 4 floats), verify packed layout: x,y,z,income for each spot.

**Checkpoint**: Tests for callbacks 57, 58 pass. Start position and metal spots are functional.

---

## Phase 6: User Story 4 — Large Map Support (Priority: P2)

**Goal**: Verify that the malloc-based allocation strategy works correctly for large map data without arena overflow.

**Independent Test**: Run callback tests with mock data simulating large map dimensions and verify no crashes or truncation.

### Implementation for User Story 4

- [x] T018 [US4] Add test `test_large_heightmap` in `proxy/tests/test_callbacks.c`. Configure mock engine with larger map dimensions (e.g., 64x64 = 4096 floats). Request heightmap callback, assert response contains all 4096 values without crash. This validates the malloc/free pattern works for buffers larger than the arena.
- [x] T019 [US4] Add test `test_null_function_pointer` in `proxy/tests/test_callbacks.c`. Create a callback struct with `Map_getHeightMap = NULL`, dispatch callback 52, assert response has `success == 0` and error message. Validates FR-007 (explicit error on null function pointer).
- [x] T020 [US4] Add test `test_zero_count_response` in `proxy/tests/test_callbacks.c`. Configure mock engine's `Map_getLosMap` to return 0 count. Dispatch callback 54, assert response has `success == 1` with empty array (`n_values == 0`). Validates FR-008.

**Checkpoint**: Edge case tests pass. Large map and error handling behaviors verified.

---

## Phase 7: User Story 5 — Frame Interleaving Documentation (Priority: P3)

**Goal**: Document the known frame-interleaving issue and client-side workaround for developer awareness.

**Independent Test**: Verify `docs/known-issues.md` exists and contains the frame-interleaving description.

### Implementation for User Story 5

- [x] T021 [US5] Create or update `docs/known-issues.md` with a section documenting the frame-interleaving issue during callback sequences. Include: problem description (callback responses interleaved with frame messages when querying outside frame window), root cause (proxy sends next frame before AI processes callback response), client-side workaround pattern (loop reading until CallbackResponse, auto-responding to interleaved Frame messages with empty commands), and note that a proxy-side fix is deferred to a future feature.

**Checkpoint**: Known issues documentation is complete and accurate.

---

## Phase 8: Polish & Cross-Cutting Concerns

**Purpose**: Final verification and documentation updates.

- [x] T022 Build proxy and run full CTest suite: `cmake -B build -DCMAKE_BUILD_TYPE=Release proxy/ && cmake --build build && cd build && ctest --output-on-failure`. Verify all existing and new tests pass.
- [x] T023 [P] Add a note to `docs/known-issues.md` or configuration documentation about `max_message_size` requirements for large maps (32x32 SMU): users must set `HIGHBAR_MAX_MSG_SIZE=16777216` or `max_message_size = 16777216` in `AIOptions.lua` for maps producing arrays larger than 8MB.
- [x] T024 [P] Run quickstart.md validation: execute all commands listed in `specs/021-map-callbacks-proxy/quickstart.md` and verify they succeed.

---

## Dependencies & Execution Order

### Phase Dependencies

- **Phase 1 (Setup)**: No tasks — skip
- **Phase 2 (Foundational)**: No dependencies — start immediately. T001 (helper) and T002/T003 (mocks/runner) are parallel.
- **Phase 3-5 (US1-US3)**: All depend on Phase 2 completion. Can run in parallel with each other since they modify non-overlapping case blocks in `callbacks.c`.
- **Phase 6 (US4)**: Depends on Phase 3 completion (uses heightmap and LOS callbacks for testing).
- **Phase 7 (US5)**: No code dependencies — can run in parallel with any phase.
- **Phase 8 (Polish)**: Depends on all previous phases.

### User Story Dependencies

- **US1 (Terrain)**: Depends on T001 (make_float_array_response) and T002 (mocks). No cross-story dependencies.
- **US2 (Visibility)**: Depends on T002 (mocks). No dependency on US1 — uses existing `make_int_array_response`.
- **US3 (Start Pos/Metal)**: Depends on T001 (make_float_array_response for metal spots) and T002 (mocks). No dependency on US1/US2.
- **US4 (Large Maps)**: Depends on US1 and US2 implementation being complete (tests exercise those callbacks).
- **US5 (Documentation)**: Independent of all code tasks.

### Within Each User Story

- Implementation tasks (T004-T006, T010-T011, T014-T015) are parallel — they add separate `case` blocks
- Test tasks (T007-T009, T012-T013, T016-T017) are parallel — they add separate test functions
- Tests can be written before or after implementation (same file, non-overlapping functions)

### Parallel Opportunities

- T001, T002, T003 can all run in parallel (Phase 2)
- T004, T005, T006 can all run in parallel (US1 implementation — separate case blocks)
- T007, T008, T009 can all run in parallel (US1 tests — separate functions)
- T010, T011 can run in parallel (US2 implementation)
- T012, T013 can run in parallel (US2 tests)
- T014, T015 can run in parallel (US3 implementation)
- T016, T017 can run in parallel (US3 tests)
- US1, US2, US3 can all run in parallel after Phase 2
- US5 can run in parallel with everything

---

## Parallel Example: User Story 1

```bash
# Launch all US1 implementation tasks together (separate case blocks in callbacks.c):
Task T004: "Implement CALLBACK_MAP_GET_HEIGHT_MAP handler in proxy/src/callbacks.c"
Task T005: "Implement CALLBACK_MAP_GET_SLOPE_MAP handler in proxy/src/callbacks.c"
Task T006: "Implement CALLBACK_MAP_GET_RESOURCE_MAP handler in proxy/src/callbacks.c"

# Launch all US1 test tasks together (separate functions in test_callbacks.c):
Task T007: "Add test_get_height_map in proxy/tests/test_callbacks.c"
Task T008: "Add test_get_slope_map in proxy/tests/test_callbacks.c"
Task T009: "Add test_get_resource_map in proxy/tests/test_callbacks.c"
```

---

## Implementation Strategy

### MVP First (User Story 1 Only)

1. Complete Phase 2: Foundational (T001-T003)
2. Complete Phase 3: User Story 1 (T004-T009)
3. **STOP and VALIDATE**: `cmake --build build && cd build && ctest` — callbacks 52, 53, 56 work
4. Deploy proxy and verify with F# client's MapGridTests

### Incremental Delivery

1. Phase 2 → Foundation ready
2. US1 (terrain data) → MVP — most valuable data for AI
3. US2 (visibility data) → Tactical AI enabled
4. US3 (start pos / metal spots) → Economy AI enabled
5. US4 (large map edge cases) → Robustness hardened
6. US5 (documentation) → Developer experience improved
7. Each story adds independent value without breaking previous stories

---

## Notes

- [P] tasks = different files or non-overlapping sections, no dependencies
- [Story] label maps task to specific user story for traceability
- All callback implementations use `malloc` for raw data buffers from the start (per research R2)
- Mock engine uses small 4x4 grids (16 elements) — large enough to verify correctness, small enough for 64KB test arena
- Commit after each task or logical group
- Stop at any checkpoint to validate independently
