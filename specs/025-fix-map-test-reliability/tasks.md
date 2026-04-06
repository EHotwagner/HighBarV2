# Tasks: Fix Map Test Reliability

**Input**: Design documents from `/specs/025-fix-map-test-reliability/`
**Prerequisites**: plan.md, spec.md, research.md, data-model.md, quickstart.md

## Format: `[ID] [P?] [Story] Description`

- **[P]**: Can run in parallel (different files, no dependencies)
- **[Story]**: Which user story this task belongs to (e.g., US1, US2, US3)
- Include exact file paths in descriptions

---

## Phase 1: Foundational (Client Wrappers)

**Purpose**: Add the 4 missing F# client methods that US2 tests depend on

- [X] T001 [P] [US1] Add `GetSlopeMap()` method returning `float32 array` using `CallbackId.CallbackMapGetSlopeMap` (ID 53) and `FloatArrayValue` response pattern in `clients/fsharp/src/Client.fs` (insert after `GetHeightMap` at line 274)
- [X] T002 [P] [US1] Add `GetLosMap()` method returning `int array` using `CallbackId.CallbackMapGetLosMap` (ID 54) and `IntArrayValue` response pattern (with `Seq.map int`) in `clients/fsharp/src/Client.fs`
- [X] T003 [P] [US1] Add `GetRadarMap()` method returning `int array` using `CallbackId.CallbackMapGetRadarMap` (ID 55) and `IntArrayValue` response pattern (with `Seq.map int`) in `clients/fsharp/src/Client.fs`
- [X] T004 [P] [US1] Add `GetResourceMap(resourceId: int)` method returning `int array` using `CallbackId.CallbackMapGetResourceMap` (ID 56), `CallbackParam` with `IntValue`, and `IntArrayValue` response pattern in `clients/fsharp/src/Client.fs`
- [X] T005 [US1] Verify `dotnet build` succeeds in `clients/fsharp/` — confirms all 4 new methods compile and `CallbackId` enum members resolve

**Checkpoint**: All 5 map data types are now queryable from the F# client. US2 can proceed.

---

## Phase 2: User Story 2 — Map Tests Validate Real Data (Priority: P2)

**Goal**: Replace silent-skip patterns in existing T9 tests and add new tests for slope, LOS, radar, and resource map data.

**Independent Test**: Run `./tests/run-all.sh --category persistent` — all T9 tests execute real assertions, zero SKIP messages in output.

### Replace Silent Skips in Existing Tests

- [X] T006 [US2] Replace `| _ -> output.WriteLine("SKIP: ...")` with `| _ -> Assert.Fail("Map dimension callbacks should be supported by proxy")` in T9.1 (line 50-51) of `tests/persistent/fsharp/T9_MapTests.fs`
- [X] T007 [US2] Replace `| Some _ -> output.WriteLine("SKIP: ...")` with `Assert.Fail("Height map returned empty — proxy should return data")` and `| None -> ...` with `Assert.Fail("Height map callback should be supported by proxy")` in T9.2 (lines 68-71) of `tests/persistent/fsharp/T9_MapTests.fs`
- [X] T008 [US2] Replace `| _ -> output.WriteLine("SKIP: ...")` with `| _ -> Assert.Fail("Start position and map dimension callbacks should be supported by proxy")` in T9.3 (lines 91-92) of `tests/persistent/fsharp/T9_MapTests.fs`
- [X] T009 [US2] Replace `| Some _ -> output.WriteLine("SKIP: ...")` with `Assert.Fail("Metal spots should be non-empty on a real map")` and `| None -> ...` with `Assert.Fail("Metal spots callback should be supported by proxy")` in T9.4 (lines 113-116) of `tests/persistent/fsharp/T9_MapTests.fs`

### Add New Map Data Tests

- [X] T010 [P] [US2] Add test `T9.5 Slope map — non-empty array with values in [0, 1]` using `queryInFrame (fun c -> c.GetSlopeMap())`, assert non-empty and all values in [0.0f, 1.0f], `Assert.Fail` on empty/None, in `tests/persistent/fsharp/T9_MapTests.fs`
- [X] T011 [P] [US2] Add test `T9.6 LOS map — non-empty int array` using `queryInFrame (fun c -> c.GetLosMap())`, assert non-empty and all values >= 0, `Assert.Fail` on empty/None, in `tests/persistent/fsharp/T9_MapTests.fs`
- [X] T012 [P] [US2] Add test `T9.7 Radar map — non-empty int array` using `queryInFrame (fun c -> c.GetRadarMap())`, assert non-empty and all values >= 0, `Assert.Fail` on empty/None, in `tests/persistent/fsharp/T9_MapTests.fs`
- [X] T013 [P] [US2] Add test `T9.8 Resource map — metal density non-empty with non-negative values` using `queryInFrame (fun c -> c.GetResourceMap(0))`, assert non-empty and all values >= 0, `Assert.Fail` on empty/None, in `tests/persistent/fsharp/T9_MapTests.fs`
- [X] T014 [US2] Verify `dotnet build` succeeds in `tests/persistent/fsharp/` — confirms all new and modified tests compile

**Checkpoint**: T9_MapTests now has 8 tests (T9.1-T9.8), all using real assertions. No silent skips remain.

---

## Phase 3: User Story 3 — Fix Always-True Assertion (Priority: P3)

**Goal**: Replace the tautological assertion in EventTests with informational logging.

**Independent Test**: Review `tests/integration/fsharp/EventTests.fs` line 169 — assertion must either be meaningful or replaced with logging.

- [X] T015 [US3] Replace `Assert.True(losEvents.Length >= 0, "LOS events count should be non-negative")` with `output.WriteLine($"LOS events: {losEvents.Length} (optional — depends on map size and unit placement)")` at line 169 of `tests/integration/fsharp/EventTests.fs`
- [X] T016 [US3] Verify `dotnet build` succeeds in `tests/integration/fsharp/` — confirms EventTests still compiles

**Checkpoint**: No tautological assertions remain.

---

## Phase 4: Verification

**Purpose**: End-to-end validation across all changes

- [X] T017 Run `./tests/run-all.sh --category persistent` against live engine — all T9 tests pass with real assertions (no SKIP messages in output)
- [X] T018 Run `./tests/run-all.sh --category integration` — EventTests pass without the always-true assertion
- [X] T019 Verify zero occurrences of `"SKIP:"` pattern remain in `tests/persistent/fsharp/T9_MapTests.fs`

---

## Dependencies & Execution Order

### Phase Dependencies

- **Phase 1 (Client Wrappers)**: No dependencies — start immediately. T001-T004 are parallel (different methods, same file but non-overlapping).
- **Phase 2 (Map Tests)**: Depends on Phase 1 completion (new tests call new client methods). T006-T009 are sequential (same file, same edit regions). T010-T013 are parallel (independent test methods).
- **Phase 3 (EventTests Fix)**: No dependencies on Phase 1 or 2 — can run in parallel with either.
- **Phase 4 (Verification)**: Depends on all previous phases.

### User Story Dependencies

- **US1 (Client Wrappers)**: Independent — can start immediately
- **US2 (Map Tests)**: Depends on US1 (tests call the new client methods)
- **US3 (EventTests Fix)**: Independent of US1 and US2

### Parallel Opportunities

- T001-T004 can run in parallel (4 independent method additions)
- T010-T013 can run in parallel (4 independent test methods)
- US3 (T015-T016) can run in parallel with US1 (different files)

---

## Parallel Example: Phase 1

```text
# Launch all 4 client wrapper tasks together:
Task T001: "Add GetSlopeMap() in clients/fsharp/src/Client.fs"
Task T002: "Add GetLosMap() in clients/fsharp/src/Client.fs"
Task T003: "Add GetRadarMap() in clients/fsharp/src/Client.fs"
Task T004: "Add GetResourceMap(resourceId) in clients/fsharp/src/Client.fs"
```

## Parallel Example: Phase 2 New Tests

```text
# After T006-T009 (skip replacements), launch new tests together:
Task T010: "Add T9.5 slope map test in T9_MapTests.fs"
Task T011: "Add T9.6 LOS map test in T9_MapTests.fs"
Task T012: "Add T9.7 radar map test in T9_MapTests.fs"
Task T013: "Add T9.8 resource map test in T9_MapTests.fs"
```

---

## Implementation Strategy

### MVP First (US1 Only)

1. Complete Phase 1: Client wrappers (T001-T005)
2. **STOP and VALIDATE**: `dotnet build` in `clients/fsharp/`
3. All 5 map data types are now queryable

### Incremental Delivery

1. Phase 1 → Client wrappers available
2. Phase 2 → Map tests validate real data (no more silent skips)
3. Phase 3 → EventTests assertion fixed
4. Phase 4 → Full verification

---

## Notes

- All 4 new client methods follow established patterns exactly — no new patterns introduced
- The `queryInFrame` helper in T9_MapTests already handles all exception cases — new tests reuse it as-is
- T006-T009 modify match arms in existing tests (same file, sequential edits)
- T010-T013 add new test methods (appended to file, no conflicts with T006-T009)
