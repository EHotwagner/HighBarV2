# Tasks: Persistent Engine Test Suite

**Input**: Design documents from `/specs/011-persistent-engine-tests/`
**Prerequisites**: plan.md (required), spec.md (required), research.md, data-model.md

**Tests**: This feature IS a test suite, so test files are the primary deliverables. No separate test tasks needed.

**Organization**: Tasks are grouped by user story to enable independent implementation and testing of each story.

## Format: `[ID] [P?] [Story] Description`

- **[P]**: Can run in parallel (different files, no dependencies)
- **[Story]**: Which user story this task belongs to (e.g., US1, US2, US3)
- Include exact file paths in descriptions

## Phase 1: Setup (Shared Infrastructure)

**Purpose**: Create the new test project with dependencies and build configuration

- [x] T001 Create project directory at tests/persistent/fsharp/
- [x] T002 Create HighBar.PersistentTests.fsproj at tests/persistent/fsharp/HighBar.PersistentTests.fsproj with .NET 10.0 target, xUnit 2.x dependencies, and project references to HighBar.Client and BarData
- [x] T003 Verify the project builds with `dotnet build` in tests/persistent/fsharp/

---

## Phase 2: Foundational (Blocking Prerequisites)

**Purpose**: Test ordering infrastructure and persistent engine fixture that ALL user stories depend on

**CRITICAL**: No test tier work can begin until this phase is complete

- [x] T004 [P] Implement priority attribute and custom ITestCaseOrderer in tests/persistent/fsharp/TestPriority.fs — define `[<Priority(n)>]` attribute and `PriorityOrderer` class that sorts test cases by priority value ascending
- [x] T005 [P] Implement PersistentEngineFixture in tests/persistent/fsharp/PersistentHarness.fs — adapt existing Harness.fs pattern with these changes: (1) IAsyncLifetime for engine startup/shutdown, (2) ResetGameState() method using CallLuaRulesCommand to destroy all units and GiveMeResourceCommand to reset resources, (3) RunFrames helper that runs N frames and collects events/returns commands, (4) engine crash detection with ThrowIfEngineCrashed(), (5) diagnostic log capture to session directory. Reference existing tests/integration/fsharp/Harness.fs for socket setup, engine launch, and client connection patterns. Use existing tests/fixtures/start-headless.sh and tests/fixtures/stop-headless.sh scripts.
- [x] T006 Add collection definition to tests/persistent/fsharp/PersistentHarness.fs — define `[<CollectionDefinition("PersistentEngine")>]` type implementing `ICollectionFixture<PersistentEngineFixture>`
- [x] T007 Update compile order in tests/persistent/fsharp/HighBar.PersistentTests.fsproj to list files in execution order: TestPriority.fs, PersistentHarness.fs, then test tier files (T0 through T5) as they are created

**Checkpoint**: Foundation ready — fixture starts engine, resets state, and shuts down cleanly

---

## Phase 3: User Story 1 + User Story 2 — Persistent Engine & Smoke Tests (Priority: P1) MVP

**Goal**: Prove the persistent engine fixture works: engine starts once, cheat-based reset clears state between tests, and smoke tests validate the reset mechanism

**Independent Test**: Run `dotnet test` in tests/persistent/fsharp/ and verify: (1) only one engine process starts, (2) all smoke tests pass, (3) each test sees clean state after reset

### Implementation

- [x] T008 [US1] [US2] Create T0_SmokeTests.fs at tests/persistent/fsharp/T0_SmokeTests.fs with `[<Collection("PersistentEngine")>]` and `[<TestCaseOrderer>]` attributes. Implement these initial smoke tests: (1) engine is alive after fixture init, (2) client is connected and can run frames, (3) initial warm-up events contain Init and UnitCreated events, (4) fixture records InitializeAsync elapsed time and exposes it as a property; assert startup completed in under 30 seconds
- [x] T009 [US1] [US2] Add reset validation tests to tests/persistent/fsharp/T0_SmokeTests.fs: (1) after spawning a unit via GiveMeNewUnitCommand then calling ResetGameState(), verify no spawned units remain, (2) after modifying resources via GiveMeResourceCommand then calling ResetGameState(), verify resources return to baseline, (3) verify game frame number continues incrementing after reset (does not reset to zero), (4) time the ResetGameState() call and assert it completes in under 5 seconds
- [x] T010 [US1] [US2] Run the suite with `dotnet test` in tests/persistent/fsharp/, diagnose and fix any failures in PersistentHarness.fs or T0_SmokeTests.fs. Iterate until all smoke tests pass reliably. Record total execution time.

**Checkpoint**: Persistent engine with cheat-based reset is proven working. All smoke tests pass. This is the MVP.

---

## Phase 4: User Story 3 — Progressive Test Complexity (Priority: P2)

**Goal**: Add test tiers of increasing complexity, each validating more demanding game interactions through the persistent engine. Add one tier at a time, run the suite, fix errors, measure timing, then proceed to the next tier.

**Independent Test**: After adding each tier, run `dotnet test` and verify all tests (including previous tiers) pass and total time remains under 10 minutes.

### Tier 1: Unit Spawning

- [x] T011 [US3] Create T1_SpawnTests.fs at tests/persistent/fsharp/T1_SpawnTests.fs with `[<Collection("PersistentEngine")>]`. Implement tests: (1) spawn a unit via GiveMeNewUnitCommand and verify UnitCreated event received, (2) spawn multiple units and verify correct count, (3) spawn units at specific positions and verify position via callbacks, (4) spawn different unit types (use BarData unit definitions for valid unitDefIds). Each test calls ResetGameState() before its test logic.
- [x] T012 [US3] Run the suite with `dotnet test`, diagnose and fix any failures in T1_SpawnTests.fs. Ensure all T0 and T1 tests pass. Record cumulative execution time.

### Tier 2: Movement

- [x] T013 [US3] Create T2_MovementTests.fs at tests/persistent/fsharp/T2_MovementTests.fs with `[<Collection("PersistentEngine")>]`. Implement tests: (1) spawn a mobile unit, issue MoveCommand, verify position changes over subsequent frames, (2) issue StopCommand and verify unit stops moving, (3) issue PatrolCommand and verify unit responds. Each test calls ResetGameState() first, then spawns needed units via GiveMeNewUnitCommand.
- [x] T014 [US3] Run the suite with `dotnet test`, diagnose and fix any failures. Ensure all T0-T2 tests pass. Record cumulative execution time.

### Tier 3: Building

- [x] T015 [US3] Create T3_BuildTests.fs at tests/persistent/fsharp/T3_BuildTests.fs with `[<Collection("PersistentEngine")>]`. Implement tests: (1) spawn a builder unit, issue BuildCommand for a valid structure, verify UnitCreated event for the new structure, (2) verify UnitFinished event when construction completes, (3) verify builder becomes UnitIdle after finishing. Each test calls ResetGameState() first.
- [x] T016 [US3] Run the suite with `dotnet test`, diagnose and fix any failures. Ensure all T0-T3 tests pass. Record cumulative execution time.

### Tier 4: Combat

- [x] T017 [US3] Create T4_CombatTests.fs at tests/persistent/fsharp/T4_CombatTests.fs with `[<Collection("PersistentEngine")>]`. Implement tests: (1) spawn an armed unit and an enemy unit (for opponent team), issue AttackCommand, verify UnitDamaged or EnemyDamaged events, (2) verify UnitDestroyed or EnemyDestroyed event when target dies, (3) verify EnemyEnterLOS event when enemy comes into range. Each test calls ResetGameState() first.
- [x] T018 [US3] Run the suite with `dotnet test`, diagnose and fix any failures. Ensure all T0-T4 tests pass. Record cumulative execution time.

### Tier 5: Multi-Step Scenarios

- [x] T019 [US3] Create T5_ScenarioTests.fs at tests/persistent/fsharp/T5_ScenarioTests.fs with `[<Collection("PersistentEngine")>]`. Implement tests: (1) full economy cycle — spawn commander, build metal extractor, verify resource income increases, (2) build-and-defend — spawn builder, build structure, spawn guard unit, verify GuardCommand accepted, (3) multi-unit coordination — spawn multiple units, issue different commands to each, verify all respond. Each test calls ResetGameState() first.
- [x] T020 [US3] Run the suite with `dotnet test`, diagnose and fix any failures. Ensure all T0-T5 tests pass. Record cumulative execution time.

**Checkpoint**: All test tiers implemented and passing. Suite exercises spawning, movement, building, combat, and multi-step scenarios.

---

## Phase 5: User Story 4 — Time Budget Validation (Priority: P2)

**Goal**: Confirm the full suite completes within 10 minutes and document timing

- [x] T021 [US4] Run the full suite with timing: `time dotnet test` in tests/persistent/fsharp/. If total time exceeds 10 minutes, identify and remove or optimize the slowest tests until under budget. Document final test count and execution time in a comment at the top of HighBar.PersistentTests.fsproj.
- [x] T022 [US4] Run the full suite 3 times consecutively to verify timing is consistent and no flaky tests exist. Fix any intermittent failures.

**Checkpoint**: Suite reliably completes under 10 minutes with all tests passing.

---

## Phase 6: Polish & Cross-Cutting Concerns

**Purpose**: Final cleanup and documentation

- [x] T023 [P] Ensure all test files have consistent structure: collection attribute, orderer attribute, ResetGameState() call pattern, and diagnostic output on failure
- [x] T024 [P] Validate quickstart.md instructions at specs/011-persistent-engine-tests/quickstart.md by following them from scratch
- [x] T025 Review and clean up PersistentHarness.fs — remove any debug logging or temporary workarounds added during development

---

## Dependencies & Execution Order

### Phase Dependencies

- **Setup (Phase 1)**: No dependencies — can start immediately
- **Foundational (Phase 2)**: Depends on Setup completion — BLOCKS all user stories
- **US1+US2 (Phase 3)**: Depends on Foundational — establishes the MVP
- **US3 (Phase 4)**: Depends on US1+US2 being proven working — adds tiers incrementally
- **US4 (Phase 5)**: Depends on US3 — validates total timing after all tiers are in
- **Polish (Phase 6)**: Depends on US4 — final cleanup

### User Story Dependencies

- **US1 + US2 (P1)**: Combined because the persistent engine (US1) is validated by smoke tests (US2). Cannot be meaningfully separated.
- **US3 (P2)**: Depends on US1+US2 being stable. Each tier within US3 depends on the previous tier passing.
- **US4 (P2)**: Depends on US3 completion. Cross-cutting timing validation.

### Within Each Tier (US3)

Each tier follows the same cycle:
1. Create test file with tests
2. Run full suite
3. Diagnose and fix failures
4. Record timing
5. Proceed to next tier only if under 10-minute budget

### Parallel Opportunities

- T004 and T005 can run in parallel (TestPriority.fs and PersistentHarness.fs are independent files)
- T023 and T024 can run in parallel (cleanup and validation are independent)
- Within Phase 4, tiers are SEQUENTIAL (each depends on previous passing)

---

## Parallel Example: Phase 2

```bash
# Launch foundational tasks in parallel:
Task: "Implement priority attribute and orderer in tests/persistent/fsharp/TestPriority.fs"
Task: "Implement PersistentEngineFixture in tests/persistent/fsharp/PersistentHarness.fs"
```

---

## Implementation Strategy

### MVP First (US1 + US2)

1. Complete Phase 1: Setup (project creation)
2. Complete Phase 2: Foundational (fixture + ordering)
3. Complete Phase 3: Smoke tests proving persistent engine + reset
4. **STOP and VALIDATE**: All smoke tests pass, engine starts once, resets work
5. This is the minimum viable persistent engine test suite

### Incremental Delivery

1. Setup + Foundational → Project builds
2. Add US1+US2 → Smoke tests pass → MVP!
3. Add T1 (spawn) → Run, fix, measure timing
4. Add T2 (movement) → Run, fix, measure timing
5. Add T3 (build) → Run, fix, measure timing
6. Add T4 (combat) → Run, fix, measure timing
7. Add T5 (scenarios) → Run, fix, measure timing
8. Validate under 10 minutes → Done
9. Each tier adds value without breaking previous tiers

---

## Notes

- [P] tasks = different files, no dependencies
- [Story] label maps task to specific user story for traceability
- The iterative "run, diagnose, fix" cycle (T010, T012, T014, T016, T018, T020) is critical — expect the reset mechanism and engine interaction to require debugging
- Commit after each tier is green
- Stop adding tiers if approaching 10-minute budget
- The existing integration tests in tests/integration/fsharp/ must not be affected
