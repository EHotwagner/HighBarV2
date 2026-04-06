# Tasks: Replace Mock Tests with Live Headless Engine Tests

**Input**: Design documents from `/specs/022-live-headless-tests/`
**Prerequisites**: plan.md (required), spec.md (required for user stories), research.md, data-model.md

**Tests**: Tests are not separately generated — this feature IS a test migration. Each task involves test files directly.

**Organization**: Tasks are grouped by user story to enable independent implementation and validation of each story.

## Format: `[ID] [P?] [Story] Description`

- **[P]**: Can run in parallel (different files, no dependencies)
- **[Story]**: Which user story this task belongs to (e.g., US1, US2, US3, US4)

---

## Phase 1: Setup (Shared Infrastructure)

**Purpose**: Capture current test baseline and verify environment

- [X] T001 Run current test suite baseline and record pass/fail counts for all tiers: `./tests/run-all.sh`
- [X] T002 Verify headless engine is available by running `./tests/check-prerequisites.sh --json`
- [X] T003 [P] Read and inventory all F# unit tests in `tests/unit/fsharp/CommandBuilderTests.fs` — document each test name and what it validates
- [X] T004 [P] Read and inventory all C proxy tests in `proxy/tests/test_serialize.c`, `proxy/tests/test_deserialize.c`, `proxy/tests/test_roundtrip.c`, `proxy/tests/test_callbacks.c` — document each test function and its disposition (DELETE/RETAIN/SUPPLEMENT per data-model.md)

---

## Phase 2: Foundational (Blocking Prerequisites)

**Purpose**: Verify persistent tier already covers the behaviors that mock tests validate, before any deletions

**CRITICAL**: No deletions can begin until coverage confirmation is complete

- [X] T005 Verify T6_CommandCoverage.fs (in `tests/persistent/fsharp/T6_CommandCoverage.fs`) covers all 5 command types tested by F# unit tests: GiveMeNewUnitCommand (T6.7), GiveMeResourceCommand (T6.6), CallLuaRulesCommand (T6.8), CallLuaUICommand (T6.9). Document any gaps.
- [X] T006 Verify persistent and integration tier tests exercise serialization of all 28+ event types that `proxy/tests/test_serialize.c` covers — list which events fire naturally during spawn, combat, movement, and LOS scenarios in persistent tests
- [X] T006b [P] Verify Constitution IV compliance: (a) confirm persistent tier frame exchange constitutes an implicit roundtrip test for all message types (replacing deleted test_roundtrip.c), (b) audit that all 28 event types and all 97 command types are exercised somewhere in the retained test suite (persistent + proxy tiers combined). Document any gaps and add targeted test scenarios to `tests/persistent/fsharp/T6_CommandCoverage.fs` if command coverage is incomplete.
- [X] T006c Verify persistent tier exercises all 15 standard command deserialization paths from `proxy/tests/test_deserialize.c`: MoveUnit, BuildUnit, Patrol, Attack, Stop, Guard, Repair, Custom, SetOnOff, DrawAddPoint, SendTextMessage, Fight, SelfDestruct, GiveMeNewUnit, GiveMe. Cross-reference against T6_CommandCoverage.fs (T6.1–T6.9) and other persistent tests (T2 movement, T3 build, T4 combat). If any command type is not exercised by a live engine test, add it to `tests/persistent/fsharp/T6_CommandCoverage.fs` before proceeding to US2.
- [X] T007 Run persistent tier to confirm all existing tests pass before modifications: `dotnet test tests/persistent/fsharp/`
- [X] T008 Run proxy tier to confirm all existing CTest tests pass before modifications: `cd build && cmake -B . -DCMAKE_BUILD_TYPE=Release ../proxy && cmake --build . && ctest`

**Checkpoint**: Coverage verified — deletion and migration tasks can now begin

---

## Phase 3: User Story 1 — Convert F# Unit Tests to Live Engine Tests (Priority: P1) MVP

**Goal**: Delete 6 F# unit tests and ensure persistent tier has full equivalent coverage. Add T6.10 all-commands smoke test.

**Independent Test**: Run `dotnet test tests/persistent/fsharp/` — T6.6 through T6.10 must all pass, covering every scenario from the deleted unit tests.

### Implementation for User Story 1

- [X] T009 [US1] Add T6.10 all-commands smoke test to `tests/persistent/fsharp/T6_CommandCoverage.fs` — spawn a unit and send all 6 command types (Move, Build, GiveMeResource, GiveMeNewUnit, CallLuaRules, CallLuaUI) in a single test, assert engine survives and processes all commands
- [X] T010 [US1] Run persistent tier to verify T6.10 passes alongside existing T6 tests: `dotnet test tests/persistent/fsharp/ --filter "T6"`
- [X] T011 [US1] Delete `tests/unit/fsharp/CommandBuilderTests.fs` — all 6 tests are now covered by persistent tier
- [X] T012 [US1] Check if `tests/unit/fsharp/HighBar.UnitTests.fsproj` has any remaining test files. If empty, delete the project file. Check for .sln references and remove if found.
- [X] T013 [US1] Update `tests/run-all.sh` to handle empty/missing unit tier gracefully — skip with informational message "No unit tests found, skipping" instead of failing
- [X] T014 [US1] Run full test suite to confirm no regressions: `./tests/run-all.sh`

**Checkpoint**: F# unit tier eliminated. Persistent tier provides full command coverage via live engine.

---

## Phase 4: User Story 2 — Convert C Proxy Mock Tests to Live Engine Validation (Priority: P2)

**Goal**: Delete 32 C proxy tests (test_serialize.c + test_roundtrip.c), retain 19 edge-case tests, document disposition.

**Independent Test**: Run `cd build && cmake .. && ctest` — retained tests (test_callbacks.c, test_deserialize.c) must pass. Run `./tests/run-all.sh --category proxy` to verify reduced test count.

### Implementation for User Story 2

- [X] T015 [US2] Delete `proxy/tests/test_serialize.c` — 29 serialization tests replaced by live engine event exchange in persistent tier
- [X] T016 [P] [US2] Delete `proxy/tests/test_roundtrip.c` — 3 roundtrip tests replaced by live engine frame exchange in persistent tier
- [X] T017 [US2] Update `proxy/tests/CMakeLists.txt` to remove `test_serialize` and `test_roundtrip` test targets and their associated `add_executable` / `add_test` entries
- [X] T018 [US2] Add header comment to `proxy/tests/test_deserialize.c` documenting: (a) 2 retained edge-case tests (test_unknown_command, test_multiple_commands) with rationale, (b) 15 standard command tests that are supplemented by live engine validation in persistent tier
- [X] T019 [US2] Rebuild proxy and run CTest to verify retained tests pass: `cmake -B build -DCMAKE_BUILD_TYPE=Release proxy/ && cmake --build build && cd build && ctest`
- [X] T020 [US2] Run full test suite to confirm no regressions: `./tests/run-all.sh`

**Checkpoint**: C proxy test suite reduced from 66 to 34 tests. Serialize and roundtrip tests eliminated. Edge cases retained.

---

## Phase 5: User Story 3 — Validate Combat Simulation Fidelity in Headless Mode (Priority: P2)

**Goal**: Strengthen combat tests with outcome-level assertions. Change from exploratory (always pass) to assertive validation.

**Independent Test**: Run `dotnet test tests/persistent/fsharp/ --filter "T4"` and `dotnet test tests/ai/fsharp/` — combat tests must pass with strengthened assertions.

### Implementation for User Story 3

- [X] T021 [US3] Strengthen T4.1 in `tests/persistent/fsharp/T4_CombatTests.fs` — add assertion that at least 1 EnemyEnterLOS event occurs (armed units must see enemy). Add diagnostic output if combat events (UnitDamaged, WeaponFired) are zero, documenting headless physics limitation.
- [X] T022 [US3] Strengthen T4.2 in `tests/persistent/fsharp/T4_CombatTests.fs` — add assertion that engine survives full frame run without crash and at least 1 LOS event fires for single armed unit near enemy
- [X] T023 [P] [US3] Strengthen T8.1 in `tests/persistent/fsharp/T8_LargeScaleCombat.fs` — add assertion that engine IsEngineAlive after 500-frame large-scale combat. Assert post-combat reset succeeds (ResetGameState completes without timeout).
- [X] T024 [US3] Update `tests/ai/fsharp/HeadlessCombatVerification.fs` — change from exploratory (always pass) to assertive: if headless combat events > 0, assert outcome-level correctness (correct side takes casualties via EnemyDestroyedCount > 0). If combat events = 0, mark test as inconclusive with `Skip` attribute and clear diagnostic message (not failure).
- [X] T025 [US3] Run persistent combat tests: `dotnet test tests/persistent/fsharp/ --filter "T4|T8"`
- [X] T026 [US3] Run AI tier combat verification: `dotnet test tests/ai/fsharp/ --filter "HeadlessCombat"`

**Checkpoint**: Combat tests now validate outcomes rather than just stability. Headless physics limitation is explicitly handled (inconclusive, not silent pass).

---

## Phase 6: User Story 4 — Adopt FSBarV1 Headless Testing Patterns (Priority: P3)

**Goal**: Port FSBarV1's map testing patterns to HighBarV2's persistent tier as T9_MapTests.fs. Add graceful feature detection.

**Independent Test**: Run `dotnet test tests/persistent/fsharp/ --filter "T9"` — map tests must pass or skip gracefully if proxy doesn't support map callbacks.

### Implementation for User Story 4

- [X] T027 [US4] Study FSBarV1 map test patterns in `/home/developer/projects/FSBarV1/tests/FSBar.LiveTests/MapQueryTests.fs` and `MapGridTests.fs` — extract test scenarios and assertion patterns to adapt for HighBarV2's persistent fixture
- [X] T028 [US4] Create `tests/persistent/fsharp/T9_MapTests.fs` with map dimension tests: query map width and height via engine callbacks, assert values are positive and match expected map dimensions. Use graceful skip pattern (try-catch) if proxy doesn't support map callbacks.
- [X] T029 [US4] Add height map test to `tests/persistent/fsharp/T9_MapTests.fs` — retrieve height map data, assert array is non-empty and contains valid float values within expected range
- [X] T030 [US4] Add start position and metal spot tests to `tests/persistent/fsharp/T9_MapTests.fs` — query start position (assert valid coordinates), query metal spot positions (assert at least 1 spot with positive income)
- [X] T031 [US4] Add T9_MapTests.fs to the persistent test project file `tests/persistent/fsharp/HighBar.PersistentTests.fsproj` (add `<Compile Include="T9_MapTests.fs" />`)
- [X] T032 [US4] If PersistentHarness doesn't expose map callback methods, add thin wrappers in `tests/persistent/fsharp/PersistentHarness.fs` for: GetMapWidth, GetMapHeight, GetHeightMap, GetStartPos, GetMetalSpots
- [X] T033 [US4] Run persistent tier to verify T9 map tests pass or skip gracefully: `dotnet test tests/persistent/fsharp/ --filter "T9"`

**Checkpoint**: Map testing infrastructure adopted from FSBarV1. Graceful skip pattern implemented for proxy compatibility.

---

## Phase 7: Polish & Cross-Cutting Concerns

**Purpose**: Final validation, test runner cleanup, and documentation

- [X] T034 Update `tests/run-all.sh` to report correct test counts per tier after all deletions and additions
- [X] T035 Run full end-to-end test suite: `./tests/run-all.sh` — all tiers must report correct status
- [X] T036 [P] Verify engine-unavailable behavior: temporarily rename spring-headless binary, run `./tests/run-all.sh`, confirm engine-dependent tiers skip gracefully with clear messages (FR-007), then restore binary
- [X] T037 Compare final test counts against baseline (T001) and verify: (a) no reduction in overall coverage (SC-006), (b) F# unit tier eliminated or reduced, (c) proxy tier reduced from 66 to 34, (d) persistent tier expanded with T6.10 and T9

---

## Dependencies & Execution Order

### Phase Dependencies

- **Setup (Phase 1)**: No dependencies — start immediately
- **Foundational (Phase 2)**: Depends on Setup — BLOCKS all user stories
- **US1 (Phase 3)**: Depends on Foundational — can start first (P1 priority)
- **US2 (Phase 4)**: Depends on Foundational — can start after or parallel with US1 (different files)
- **US3 (Phase 5)**: Depends on Foundational — can start after or parallel with US1/US2 (different files)
- **US4 (Phase 6)**: Depends on Foundational — can start after or parallel with US1/US2/US3 (new files only)
- **Polish (Phase 7)**: Depends on ALL user stories complete

### User Story Dependencies

- **US1 (F# unit migration)**: Independent — touches `tests/unit/fsharp/` and `T6_CommandCoverage.fs`
- **US2 (C proxy deletion)**: Independent — touches `proxy/tests/` and `CMakeLists.txt`
- **US3 (combat fidelity)**: Independent — touches `T4_CombatTests.fs`, `T8_LargeScaleCombat.fs`, `HeadlessCombatVerification.fs`
- **US4 (FSBarV1 map tests)**: Independent — creates new `T9_MapTests.fs`, may modify `PersistentHarness.fs`

### Within Each User Story

- Verify coverage before deleting (Foundational phase handles this globally)
- Add new tests before deleting old ones
- Run validation after each modification
- Full suite run after story completion

### Parallel Opportunities

- T003 and T004 (inventory tasks) can run in parallel
- T015 and T016 (C proxy deletions) can run in parallel
- T021/T022 and T023 (combat assertion strengthening) can run in parallel
- All four user stories (US1-US4) can run in parallel after Foundational phase since they touch different files

---

## Parallel Example: User Stories After Foundational

```bash
# All four stories can start simultaneously (different file sets):
# US1: tests/unit/fsharp/, tests/persistent/fsharp/T6_CommandCoverage.fs
# US2: proxy/tests/test_serialize.c, test_roundtrip.c, CMakeLists.txt
# US3: tests/persistent/fsharp/T4_CombatTests.fs, T8_LargeScaleCombat.fs, tests/ai/fsharp/HeadlessCombatVerification.fs
# US4: tests/persistent/fsharp/T9_MapTests.fs (new file)
```

---

## Implementation Strategy

### MVP First (User Story 1 Only)

1. Complete Phase 1: Setup (baseline capture)
2. Complete Phase 2: Foundational (coverage verification)
3. Complete Phase 3: User Story 1 (F# unit test migration)
4. **STOP and VALIDATE**: Run `./tests/run-all.sh` — persistent tier covers all former unit tests
5. This alone achieves SC-001 (80%+ F# mock replacement)

### Incremental Delivery

1. Setup + Foundational → Baseline verified
2. US1 → F# unit tier eliminated → Validate (MVP!)
3. US2 → C proxy tests reduced → Validate (SC-002 achieved)
4. US3 → Combat fidelity strengthened → Validate (SC-003 achieved)
5. US4 → Map tests adopted from FSBarV1 → Validate (FR-008 achieved)
6. Polish → Full suite green, documentation updated

---

## Notes

- [P] tasks = different files, no dependencies
- [Story] label maps task to specific user story for traceability
- All deletions happen AFTER live equivalents are confirmed working
- Each user story is independently completable and testable
- Run full suite after each story completion as regression check
- Commit after each completed task or logical group
