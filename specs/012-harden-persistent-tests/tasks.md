# Tasks: Harden Persistent Engine Tests

**Input**: Design documents from `/specs/012-harden-persistent-tests/`
**Prerequisites**: plan.md, spec.md, research.md, data-model.md, quickstart.md

**Tests**: This feature IS the test suite — all tasks produce tests. No separate "write tests first" phase needed.

**Organization**: Tasks are grouped by user story to enable independent implementation and testing of each story.

## Format: `[ID] [P?] [Story] Description`

- **[P]**: Can run in parallel (different files, no dependencies)
- **[Story]**: Which user story this task belongs to (e.g., US1, US2, US3)
- Include exact file paths in descriptions

---

## Phase 1: Setup

**Purpose**: Project structure and shared infrastructure updates

- [X] T001 Add UnitDefInfo and UnitDefRegistry record types to `tests/persistent/fsharp/PersistentHarness.fs`
- [X] T002 Add BatchResult record type to `tests/persistent/fsharp/PersistentHarness.fs`
- [X] T003 Add BattleMetrics record type to `tests/persistent/fsharp/PersistentHarness.fs`

---

## Phase 2: Foundational (Blocking Prerequisites)

**Purpose**: UnitDefId discovery in the shared fixture — MUST be complete before any user story work

**⚠️ CRITICAL**: No user story work can begin until this phase is complete

- [X] T004 [US4] Implement UnitDefId discovery logic in `PersistentEngineFixture.InitializeAsync()` in `tests/persistent/fsharp/PersistentHarness.fs` — probe unitDefIds 1-20 (if any category is missing after 20, extend to 1-50), spawn each via GiveMeNewUnitCommand, collect UnitCreated events, cross-reference with BarData AllUnits to classify as builder/armed/mobile/building, store results as public properties (BuilderDefId, ArmedUnitDefId, MobileUnitDefId, BuildingDefId, BuildableStructureDefId) on the fixture
- [X] T005 [US4] Add a discovery validation test in `tests/persistent/fsharp/T0_SmokeTests.fs` that asserts the fixture discovered at least one builder, one armed unit, one mobile unit, and one building; log all discovered IDs with categories
- [X] T006 Update `tests/persistent/fsharp/T0_SmokeTests.fs` to use discovered unitDefIds from the fixture instead of hardcoded values
- [X] T007 [P] Update `tests/persistent/fsharp/T1_SpawnTests.fs` to use discovered unitDefIds from the fixture instead of hardcoded values
- [X] T008 [P] Update `tests/persistent/fsharp/T2_MovementTests.fs` to use discovered mobile unit unitDefId from the fixture instead of hardcoded values
- [X] T009 [P] Update `tests/persistent/fsharp/T5_ScenarioTests.fs` to use discovered unitDefIds from the fixture instead of hardcoded values

**Checkpoint**: All existing tests use discovered unitDefIds; fixture provides builder, armed, mobile, building IDs

---

## Phase 3: User Story 1 — Fix Observational Tests to Assert Real Events (Priority: P1) 🎯 MVP

**Goal**: Rewrite T3 (Build) and T4 (Combat) tests so every test contains hard assertions on engine events, not just logged counts

**Independent Test**: `dotnet test --filter "FullyQualifiedName~T3_"` and `dotnet test --filter "FullyQualifiedName~T4_"` — every test must contain at least one `Assert` on an engine event

### Implementation for User Story 1

- [X] T010 [US1] Rewrite build tests in `tests/persistent/fsharp/T3_BuildTests.fs` — before each build test, send GiveMeResourceCommand (10000 metal + 10000 energy), use fixture's discovered BuilderDefId and BuildableStructureDefId, issue BuildCommand, run 500 frames, assert UnitCreated event for the structure is received, assert UnitFinished event is received, assert UnitIdle event for the builder is received
- [X] T011 [US1] Rewrite combat tests in `tests/persistent/fsharp/T4_CombatTests.fs` — spawn an armed unit (fixture's ArmedUnitDefId) near enemy commander position (4608, 4096), use AttackCommand or FightCommand, run 200 frames, assert UnitDamaged or EnemyDamaged events are received; add a destruction test running 400 frames asserting UnitDestroyed or EnemyDestroyed
- [X] T012 [US1] Add EnemyEnterLOS test in `tests/persistent/fsharp/T4_CombatTests.fs` — spawn a mobile unit far from enemy, issue MoveCommand toward enemy base (4608, 4096), run 200 frames, assert EnemyEnterLOS event is received
- [X] T013 [US1] Ensure all T3/T4 tests output diagnostic info (event counts, unitDefIds used, frame count) via `ITestOutputHelper` on failure

**Checkpoint**: T3 and T4 tests assert on real engine events; zero observational-only tests remain

---

## Phase 4: User Story 2 — Quick Unit/Command Coverage Tests (Priority: P1)

**Goal**: Every command type in the client library has at least one live engine test verifying engine acceptance

**Independent Test**: `dotnet test --filter "FullyQualifiedName~T6_CommandCoverage"` — each test class completes in under 60 seconds

### Implementation for User Story 2

- [X] T014 [US2] Create `tests/persistent/fsharp/T6_CommandCoverage.fs` with tier 6 priority and test class structure using PersistentEngineFixture
- [X] T015 [US2] Add command coverage tests for untested commands in `tests/persistent/fsharp/T6_CommandCoverage.fs`: SetWantedMaxSpeedCommand (set speed on a mobile unit, run frames, assert no crash), SelfDestructCommand (spawn unit, self-destruct, run frames, assert UnitDestroyed), ReclaimUnitCommand (spawn unit, reclaim with builder, run frames), CustomCommand (send a custom command ID, run frames, assert no crash), SendTextMessageCommand (send a text message, run frames), GiveMeResourceCommand (give resources, run frames, verify no error), GiveMeNewUnitCommand (spawn unit, run frames, assert UnitCreated), CallLuaRulesCommand (send Lua rules message, run frames), CallLuaUICommand (send Lua UI message, run frames); apply [Fact(Timeout = 60000)] to each test method
- [X] T016 [US2] Add `T6_CommandCoverage.fs` to compile order in `tests/persistent/fsharp/HighBar.PersistentTests.fsproj` after T5_ScenarioTests.fs

**Checkpoint**: All 17 command types have at least one live engine test

---

## Phase 5: User Story 4 — UnitDefId Discovery (Priority: P1)

**Goal**: Dedicated discovery validation — confirm fixture discovery works and log full category breakdown

**Independent Test**: `dotnet test --filter "FullyQualifiedName~Discovery"` — logs all discovered unitDefIds with categories

**Note**: Core discovery logic was implemented in Phase 2 (T004). This phase adds a dedicated validation test with richer diagnostics.

### Implementation for User Story 4

- [X] T017 [US4] Add a dedicated discovery diagnostics test in `tests/persistent/fsharp/T0_SmokeTests.fs` that logs the full UnitDefRegistry (all probed IDs with categories: builder, armed, mobile, building) and asserts at least 4 categories are populated

**Checkpoint**: UnitDefId discovery is validated with rich diagnostic output

---

## Phase 6: User Story 5 — Exhaustive UnitDef Spawn Test (Priority: P2)

**Goal**: Verify all 953 unitDefs can be spawned without crashing the engine, in batches of 50 with reset between batches

**Independent Test**: `dotnet test --filter "FullyQualifiedName~T7_ExhaustiveSpawn"` — completes in under 2 minutes

### Implementation for User Story 5

- [X] T018 [US5] Create `tests/persistent/fsharp/T7_ExhaustiveSpawn.fs` with tier 7 priority — implement batch spawning of all 953 unitDefIds in batches of 50: for each batch, send 50 GiveMeNewUnitCommand, run 20 frames, count UnitCreated events, record success/failure per unitDefId in BatchResult, call ResetGameState, repeat for all ~19 batches
- [X] T019 [US5] Add summary reporting in `tests/persistent/fsharp/T7_ExhaustiveSpawn.fs` — after all batches, log total success/failure counts, list problematic unitDefIds, assert engine remained alive throughout, assert total time under 2 minutes
- [X] T020 [US5] Add `T7_ExhaustiveSpawn.fs` to compile order in `tests/persistent/fsharp/HighBar.PersistentTests.fsproj` after T6_CommandCoverage.fs

**Checkpoint**: All 953 unitDefs tested; compatibility report produced

---

## Phase 7: User Story 3 — Large-Scale Combat Scenarios (Priority: P2)

**Goal**: Stress-test the engine with 100+ units in active combat over 60+ seconds of game time

**Independent Test**: `dotnet test --filter "FullyQualifiedName~T8_LargeScaleCombat"` — each scenario completes in 1-3 minutes

### Implementation for User Story 3

- [X] T021 [US3] Create `tests/persistent/fsharp/T8_LargeScaleCombat.fs` with tier 8 priority — implement a large battle test: spawn 100+ armed units (using fixture's ArmedUnitDefId) at friendly position, issue FightCommand toward enemy base (4608, 4096), run 1000+ frames (~60s game time at 30fps), collect BattleMetrics (UnitsSpawned, DamageEvents, DestroyedEvents, LosEvents, ElapsedSeconds), assert engine remains alive, assert DamageEvents > 0 and DestroyedEvents > 0; apply [Fact(Timeout = 180000)] to each test method
- [X] T022 [US3] Add post-battle reset validation test in `tests/persistent/fsharp/T8_LargeScaleCombat.fs` — after the large battle, call ResetGameState, assert reset completes in under 30 seconds, assert engine is ready for next test by running a simple spawn+frames
- [X] T023 [US3] Add `T8_LargeScaleCombat.fs` to compile order in `tests/persistent/fsharp/HighBar.PersistentTests.fsproj` after T7_ExhaustiveSpawn.fs

**Checkpoint**: Large-scale combat scenarios pass; engine survives 100+ unit battles

---

## Phase 8: Polish & Cross-Cutting Concerns

**Purpose**: Suite-wide validation and diagnostics

- [X] T024 [P] Verify full test suite completes within 10 minutes by running `cd tests/persistent/fsharp && dotnet test` end-to-end
- [X] T025 [P] Run full suite 3 times consecutively to verify no flaky tests (SC-007)
- [X] T026 Update `specs/012-harden-persistent-tests/quickstart.md` with final test filter commands and expected behavior

---

## Dependencies & Execution Order

### Phase Dependencies

- **Setup (Phase 1)**: No dependencies — can start immediately
- **Foundational (Phase 2)**: Depends on Phase 1 — BLOCKS all user stories
- **User Story 1 (Phase 3)**: Depends on Phase 2 (needs discovered unitDefIds)
- **User Story 2 (Phase 4)**: Depends on Phase 2 (needs discovered unitDefIds and fixture)
- **User Story 4 (Phase 5)**: Depends on Phase 2 (validates discovery)
- **User Story 5 (Phase 6)**: Depends on Phase 2 (needs fixture and BatchResult type)
- **User Story 3 (Phase 7)**: Depends on Phase 2 (needs fixture and BattleMetrics type)
- **Polish (Phase 8)**: Depends on all user stories being complete

### User Story Dependencies

- **US1 (Fix Observational Tests)**: Depends on Phase 2 only — can run in parallel with US2, US4
- **US2 (Command Coverage)**: Depends on Phase 2 only — can run in parallel with US1, US4
- **US4 (Discovery Validation)**: Depends on Phase 2 only — can run in parallel with US1, US2
- **US5 (Exhaustive Spawn)**: Depends on Phase 2 only — can run in parallel with US3
- **US3 (Large-Scale Combat)**: Depends on Phase 2 only — can run in parallel with US5

### Within Each User Story

- All tests in a story depend on the shared fixture (Phase 2)
- T3/T4 rewrites (US1) are independent of each other
- New files (T6, T7, T8) are independent of each other
- .fsproj updates must follow file creation

### Parallel Opportunities

- T001, T002, T003 can be done together (same file, but sequential additions)
- T007, T008, T009 can run in parallel (different files)
- Phase 3, Phase 4, Phase 5 can run in parallel after Phase 2
- Phase 6 and Phase 7 can run in parallel after Phase 2
- T024, T025, T026 can run in parallel

---

## Parallel Example: After Phase 2

```bash
# Launch US1, US2, US4 in parallel (independent files):
Task: "Rewrite build tests in T3_BuildTests.fs"          # US1
Task: "Rewrite combat tests in T4_CombatTests.fs"        # US1
Task: "Create T6_CommandCoverage.fs"                       # US2
Task: "Add discovery diagnostics test in T0_SmokeTests.fs" # US4

# Launch US5 and US3 in parallel (independent files):
Task: "Create T7_ExhaustiveSpawn.fs"                       # US5
Task: "Create T8_LargeScaleCombat.fs"                      # US3
```

---

## Implementation Strategy

### MVP First (User Story 1 Only)

1. Complete Phase 1: Setup (data types)
2. Complete Phase 2: Foundational (discovery + existing test updates)
3. Complete Phase 3: User Story 1 (fix T3/T4 assertions)
4. **STOP and VALIDATE**: Run `dotnet test --filter "FullyQualifiedName~T3_"` and `dotnet test --filter "FullyQualifiedName~T4_"` — all tests must assert on real events
5. Commit and verify no regressions

### Incremental Delivery

1. Setup + Foundational → Discovery works, existing tests use correct IDs
2. Add US1 (T3/T4 rewrites) → Test independently → Hard assertions pass (MVP!)
3. Add US2 (command coverage) → Test independently → All 17 commands covered
4. Add US4 (discovery validation) → Rich diagnostics available
5. Add US5 (exhaustive spawn) → 953 unitDefs tested
6. Add US3 (large-scale combat) → Stress tests pass
7. Polish → Full suite under 10 minutes, no flaky tests

---

## Notes

- [P] tasks = different files, no dependencies
- [Story] label maps task to specific user story for traceability
- All tasks modify files in `tests/persistent/fsharp/`
- The feature adds 3 new .fs files (T6, T7, T8) and rewrites 2 existing (T3, T4)
- PersistentHarness.fs gets the most changes (data types + discovery logic)
- The .fsproj compile order must list new files in tier order
