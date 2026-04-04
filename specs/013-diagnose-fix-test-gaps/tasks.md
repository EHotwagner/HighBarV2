# Tasks: Diagnose and Fix Persistent Test Gaps

**Input**: Design documents from `/specs/013-diagnose-fix-test-gaps/`
**Prerequisites**: plan.md (required), spec.md (required), research.md, data-model.md, contracts/

**Organization**: Tasks are grouped by user story to enable independent implementation and testing of each story.

## Format: `[ID] [P?] [Story] Description`

- **[P]**: Can run in parallel (different files, no dependencies)
- **[Story]**: Which user story this task belongs to (e.g., US1, US2, US3)
- Include exact file paths in descriptions

## Phase 1: Setup (Proto & Build)

**Purpose**: Extend the protobuf schema and verify builds before touching proxy or client code.

- [X] T001 Add `CALLBACK_GET_UNIT_DEFS = 47` and `CALLBACK_CHEATS_SET_EVENTS_ENABLED = 92` to `CallbackId` enum in `proto/highbar/callbacks.proto`
- [X] T002 Run `cd proto && buf lint && buf generate` to regenerate code from updated callbacks.proto
- [X] T003 Verify proxy builds cleanly: `cmake -B build -DCMAKE_BUILD_TYPE=Debug proxy/ && cmake --build build`
- [X] T004 Verify F# client builds cleanly: `cd clients/fsharp && dotnet build`

---

## Phase 2: Foundational (Proxy Callback Dispatch + Cheat Events)

**Purpose**: Add missing callback dispatch cases to the proxy C code and enable cheat events. BLOCKS all user stories.

**CRITICAL**: No user story work can begin until this phase is complete.

- [X] T005 Add 7 new dispatch cases to `hb_callback_dispatch()` in `proxy/src/callbacks.c`: CALLBACK_GET_UNIT_DEFS (47) → `getUnitDefs` returning IntArray, CALLBACK_UNITDEF_GET_NAME (40) → `UnitDef_getName` returning string, CALLBACK_UNITDEF_GET_BUILD_OPTIONS (42) → `UnitDef_getBuildOptions` returning IntArray, CALLBACK_UNITDEF_GET_MAX_WEAPON_RANGE (43) → `UnitDef_getMaxWeaponRange` returning float, CALLBACK_UNITDEF_GET_BUILD_SPEED (46) → `UnitDef_getBuildSpeed` returning float, CALLBACK_UNIT_GET_DEF (23) → `Unit_getDef` returning int, CALLBACK_CHEATS_SET_EVENTS_ENABLED (92) → `Cheats_setEventsEnabled` returning int
- [X] T006 Add `Cheats_setEventsEnabled(skirmishAIId, true)` call in `proxy/src/proxy.c` init sequence immediately after the existing `Cheats_setEnabled(true)` call
- [X] T007 Rebuild proxy and run C tests: `cmake --build build && cd build && ctest`
- [X] T008 [P] Add F# callback query helper `GetUnitDefs(maxCount: int) : int array` to `clients/fsharp/src/Client.fs` — sends `CallbackRequest` with `CALLBACK_GET_UNIT_DEFS`, parses `IntArray` response
- [X] T009 [P] Add F# callback query helper `GetUnitDefName(defId: int) : string` to `clients/fsharp/src/Client.fs` — sends `CallbackRequest` with `CALLBACK_UNITDEF_GET_NAME`
- [X] T010 [P] Add F# callback query helper `GetBuildOptions(defId: int) : int array` to `clients/fsharp/src/Client.fs` — sends `CallbackRequest` with `CALLBACK_UNITDEF_GET_BUILD_OPTIONS`
- [X] T011 [P] Add F# callback query helpers `GetMaxWeaponRange(defId)`, `GetBuildSpeed(defId)`, `GetUnitDef(unitId)`, `SetCheatEventsEnabled(enabled)` to `clients/fsharp/src/Client.fs`
- [X] T012 Build F# client: `cd clients/fsharp && dotnet build`

**Checkpoint**: Proxy dispatches all UnitDef callbacks and enables cheat events. F# client has typed helpers for all queries.

---

## Phase 3: User Story 1 — Engine DefId Discovery (Priority: P1) MVP

**Goal**: Replace BarData-based discovery with callback-based discovery so the harness knows the engine's actual defId-to-unitName mapping.

**Independent Test**: Run T0 smoke tests — registry should contain correct unit names from engine (not BarData alphabetical order). A BuildCommand with the commander's actual buildable defId should produce a UnitCreated event.

### Implementation for User Story 1

- [X] T013 [US1] Rewrite `UnitDefRegistry` initialization in `tests/persistent/fsharp/PersistentHarness.fs` — replace BarData cross-reference probe with `client.GetUnitDefs()` to get all valid defIds from engine
- [X] T014 [US1] For each discovered defId in `tests/persistent/fsharp/PersistentHarness.fs`, call `client.GetUnitDefName(defId)` to populate `UnitDefInfo.Name` with engine-verified names
- [X] T015 [US1] Classify units in `tests/persistent/fsharp/PersistentHarness.fs` using `client.GetBuildSpeed(defId)` for IsBuilder and `client.GetMaxWeaponRange(defId)` for IsArmed instead of BarData category lookups
- [X] T016 [US1] Add commander build options discovery in `tests/persistent/fsharp/PersistentHarness.fs` — after initial events, call `client.GetBuildOptions(commanderDefId)` and store as `CommanderBuildOptions: int array` property on fixture
- [X] T017 [US1] Update `BuilderDefId`, `ArmedUnitDefId`, `MobileUnitDefId`, `BuildingDefId`, `BuildableStructureDefId` properties in `tests/persistent/fsharp/PersistentHarness.fs` to use engine-verified classifications
- [X] T018 [US1] Run T0 smoke tests to verify registry populated with correct engine names: `cd tests/persistent/fsharp && dotnet test --filter "FullyQualifiedName~T0_SmokeTests"`

**Checkpoint**: DefId discovery uses engine callbacks. Unit classifications are accurate. Commander build options are known.

---

## Phase 4: User Story 2 — Combat Event Delivery (Priority: P1)

**Goal**: Diagnose and fix zero combat events so EnemyEnterLOS, UnitDamaged, EnemyDamaged, UnitDestroyed, EnemyDestroyed are received.

**Independent Test**: Spawn one armed unit near enemy position, run 300 frames, observe at least one combat event.

### Implementation for User Story 2

- [X] T019 [US2] Add diagnostic event logging in `tests/persistent/fsharp/PersistentHarness.fs` — add a `RunFramesWithEventLog(n)` helper that counts events by type and logs the distribution after completion
- [X] T020 [US2] Verify cheat events are enabled during fixture init in `tests/persistent/fsharp/PersistentHarness.fs` — after warm-up frames, check that initial events include `EnemyCreated` or `EnemyFinished` (confirms `Cheats_setEventsEnabled` from T006 is working); if absent, call `client.SetCheatEventsEnabled(true)` as fallback
- [X] T021 [US2] Add enemy existence verification in `tests/persistent/fsharp/PersistentHarness.fs` — scan initial events for `EnemyCreated` or `EnemyFinished`; if no enemy exists, log warning and store `HasEnemy: bool` property
- [X] T022 [US2] Write a minimal combat diagnostic test in `tests/persistent/fsharp/T4_CombatTests.fs` — first assert `fixture.HasEnemy` is true (fail-fast with "No enemy units detected — NullAI commander may not have spawned" if false); then spawn one armed unit at (4500, 100, 4096) near enemy start (4608, 4096), issue FightCommand toward enemy, run 300 frames, assert at least one combat event (UnitDamaged OR EnemyDamaged OR EnemyEnterLOS) is received
- [X] T023 [US2] Run the diagnostic test: `cd tests/persistent/fsharp && dotnet test --filter "FullyQualifiedName~T4_CombatTests"` — if combat events now appear, root cause confirmed. If still zero, check engine logs at `/tmp/highbar-persistent-*/infolog.txt` and investigate H2-H4 from research.md
- [X] T024 [US2] If T023 fails (still zero events): add `HIGHBAR_LOG_LEVEL=3` debug logging, re-run, and inspect proxy output for "Failed to serialize event" or "Socket not writable" warnings. Check if `handleEvent` is being called with topic IDs 9/10/13/17/18 at all.

**Checkpoint**: Combat events flow from engine → proxy → client. At least one event from each category (LOS, damage, destroy) is observable.

---

## Phase 5: User Story 3 — SelfDestruct Event Verification (Priority: P2)

**Goal**: SelfDestructCommand produces observable UnitDestroyed event.

**Independent Test**: Spawn a unit, issue SelfDestructCommand, run 500 frames, assert UnitDestroyed received.

### Implementation for User Story 3

- [X] T025 [US3] Update SelfDestruct test in `tests/persistent/fsharp/T6_CommandCoverage.fs` (T6.2) — increase frame budget from 200 to 500 frames after SelfDestructCommand
- [X] T026 [US3] Assert `UnitDestroyed` event is received for the self-destructed unit in `tests/persistent/fsharp/T6_CommandCoverage.fs` — replace engine-survival-only assertion with hard event assertion
- [X] T027 [US3] [CONDITIONAL] If T026 fails: use `client.GetUnitHealth(unitId)` callback (already dispatched as CALLBACK_UNIT_GET_HEALTH) to poll health during frames after SelfDestructCommand in `tests/persistent/fsharp/T6_CommandCoverage.fs` — verify health drops to zero (confirms self-destruct is working but event may not be delivered)
- [X] T028 [US3] Run SelfDestruct test: `cd tests/persistent/fsharp && dotnet test --filter "FullyQualifiedName~T6_CommandCoverage"`

**Checkpoint**: SelfDestructCommand produces UnitDestroyed event within 500 frames.

---

## Phase 6: User Story 4 — Reliable Large-Scale Spawn Tests (Priority: P2)

**Goal**: Identify root cause of spawn crashes and expand exhaustive test to cover all valid defIds.

**Independent Test**: Spawn 90%+ of all valid defIds across batches without engine crashes.

### Implementation for User Story 4

- [X] T029 [US4] Unit count limit test in `tests/persistent/fsharp/T7_ExhaustiveSpawn.fs` — spawn same safe defId (first from registry) 500 times consecutively without reset, record when/if engine crashes to determine max unit count
- [X] T030 [US4] DefId range isolation test in `tests/persistent/fsharp/T7_ExhaustiveSpawn.fs` — spawn defIds in ranges of 50 (1-50, 51-100, ...) with reset between each range, identify which range causes engine crash
- [X] T031 [US4] Binary search within crashing range in `tests/persistent/fsharp/T7_ExhaustiveSpawn.fs` — narrow down to specific defIds that crash the engine, build a `SpawnBlacklist` set
- [X] T032 [US4] State leak test in `tests/persistent/fsharp/T7_ExhaustiveSpawn.fs` — spawn 50 safe defIds + reset × 20 iterations, verify engine survives (confirms reset is not leaking state)
- [X] T033 [US4] Update T7 exhaustive spawn test in `tests/persistent/fsharp/T7_ExhaustiveSpawn.fs` — use full defId list from `GetUnitDefs()` minus blacklisted defIds, batch size tuned to safe threshold, assert 90%+ coverage
- [X] T034 [US4] Run exhaustive spawn: `cd tests/persistent/fsharp && dotnet test --filter "FullyQualifiedName~T7_ExhaustiveSpawn"`

**Checkpoint**: Root cause of spawn crashes identified and documented. T7 covers 90%+ of valid defIds.

---

## Phase 7: User Story 5 — Strengthen Weakened Test Assertions (Priority: P3)

**Goal**: Restore T3, T4, T6.2, T7, T8 to original spec-level assertions.

**Independent Test**: Run full T0-T8 suite — all 38+ tests pass with hard event assertions (no engine-survival-only checks remaining).

### Implementation for User Story 5

- [X] T035 [P] [US5] Restore T3.1 and T3.2 in `tests/persistent/fsharp/T3_BuildTests.fs` — use commander's discovered build options to issue real BuildCommand with correct defId, assert UnitCreated for nanoframe and UnitFinished for completed building
- [X] T036 [P] [US5] Restore T3.3 in `tests/persistent/fsharp/T3_BuildTests.fs` — issue BuildCommand with a known-buildable defId (from `CommanderBuildOptions`), assert UnitCreated event rather than engine-survival-only
- [X] T037 [P] [US5] Restore T4.1 in `tests/persistent/fsharp/T4_CombatTests.fs` — first assert `fixture.HasEnemy` (fail-fast if no enemy); spawn 5 armed units near enemy, issue FightCommand, assert `EnemyDamaged` or `UnitDamaged` events received within 300 frames
- [X] T038 [P] [US5] Restore T4.2 in `tests/persistent/fsharp/T4_CombatTests.fs` — assert `fixture.HasEnemy`; spawn armed unit, issue AttackCommand targeting enemy, assert damage events received
- [X] T039 [P] [US5] Restore T4.3 in `tests/persistent/fsharp/T4_CombatTests.fs` — spawn unit, issue SelfDestructCommand, assert UnitDestroyed event received within 500 frames
- [X] T040 [US5] Restore T8.1 and T8.2 in `tests/persistent/fsharp/T8_LargeScaleCombat.fs` — increase to 100+ armed units, run 1000+ frames, assert `DamageEvents > 0` and `DestroyedEvents > 0`
- [X] T041 [US5] Run full test suite: `cd tests/persistent/fsharp && dotnet test --logger "console;verbosity=detailed"` — verify all 38+ tests pass with strengthened assertions

**Checkpoint**: All originally-specified assertions restored. No engine-survival-only checks remain in T3/T4/T6.2/T7/T8.

---

## Phase 8: Polish & Cross-Cutting Concerns

**Purpose**: Documentation, diagnostics, and final validation.

- [X] T042 [P] Add engine log capture to test output in `tests/persistent/fsharp/PersistentHarness.fs` — on test failure, dump last 50 lines of `infolog.txt` and `engine-stderr.log` to xUnit output (FR-008)
- [X] T043 [P] Write root cause report in `reports/013-diagnose-fix-test-gaps.md` — document confirmed root cause for each of the 4 problems with evidence (SC-006)
- [X] T044 [P] Add event buffer overflow warning in `proxy/src/proxy.c` — log at WARN level when `pending_event_count` reaches `MAX_EVENTS_PER_FRAME` (currently silently drops events at line 363-365)
- [X] T045 Run quickstart.md validation — follow all build/test/debug steps to verify correctness

---

## Dependencies & Execution Order

### Phase Dependencies

- **Setup (Phase 1)**: No dependencies — start immediately
- **Foundational (Phase 2)**: Depends on Phase 1 (proto generation) — BLOCKS all user stories
- **US1 (Phase 3)**: Depends on Phase 2 (callback dispatches + F# helpers)
- **US2 (Phase 4)**: Depends on Phase 2 (Cheats_setEventsEnabled in proxy init via T006)
- **US3 (Phase 5)**: Depends on Phase 4 (combat event delivery fix — same event path)
- **US4 (Phase 6)**: Depends on Phase 2 (GetUnitDefs for full defId list)
- **US5 (Phase 7)**: Depends on US1 + US2 + US3 + US4 (all root causes must be fixed)
- **Polish (Phase 8)**: Depends on all user stories

### User Story Dependencies

- **US1 (DefId Discovery)**: Can start after Phase 2 — independent of US2/US3/US4
- **US2 (Combat Events)**: Can start after Phase 2 — independent of US1/US3/US4
- **US3 (SelfDestruct)**: Should start after US2 (likely same root cause)
- **US4 (Spawn Crashes)**: Can start after Phase 2 — independent of US1/US2/US3
- **US5 (Strengthen Tests)**: Depends on ALL of US1-US4

### Parallel Opportunities

- **Phase 2**: T005 (single task for all proxy dispatch cases). T008-T011 (F# helpers) are all [P] — different methods, same file but non-overlapping.
- **Phases 3, 4, 6**: US1, US2, US4 can execute in parallel after Phase 2
- **Phase 7**: T035-T039 (test assertion restores) are all [P] — different test files
- **Phase 8**: T042-T044 are all [P] — different files

---

## Parallel Example: Foundational Phase

```bash
# T005 adds all 7 proxy dispatch cases in one task (same file, sequential)
Task: T005 "Add 7 dispatch cases to proxy/src/callbacks.c"

# After proxy builds (T007), launch F# helpers in parallel:
Task: T008 "Add GetUnitDefs helper in clients/fsharp/src/Client.fs"
Task: T009 "Add GetUnitDefName helper in clients/fsharp/src/Client.fs"
Task: T010 "Add GetBuildOptions helper in clients/fsharp/src/Client.fs"
Task: T011 "Add remaining helpers in clients/fsharp/src/Client.fs"
```

## Parallel Example: User Stories After Foundational

```bash
# US1, US2, and US4 can proceed in parallel:
Task: T013 "Rewrite UnitDefRegistry in PersistentHarness.fs" (US1)
Task: T019 "Add diagnostic event logging in PersistentHarness.fs" (US2)
Task: T029 "Unit count limit test in T7_ExhaustiveSpawn.fs" (US4)
```

---

## Implementation Strategy

### MVP First (US1 + US2)

1. Complete Phase 1: Setup (proto changes)
2. Complete Phase 2: Foundational (proxy dispatches + cheat events)
3. Complete Phase 3: US1 — DefId Discovery
4. Complete Phase 4: US2 — Combat Events
5. **STOP and VALIDATE**: T0 smoke tests pass with engine-verified names. Combat events are received.
6. This resolves the two P1 blockers from 012-harden-persistent-tests

### Incremental Delivery

1. Setup + Foundational → Proxy and client ready
2. US1 (DefId Discovery) → BuildCommand works correctly → Demo
3. US2 (Combat Events) → Damage/destroy events flow → Demo
4. US3 (SelfDestruct) → Quick win after US2
5. US4 (Spawn Crashes) → Empirical investigation, may take multiple iterations
6. US5 (Strengthen Tests) → Final payoff — all tests at full assertion strength

---

## Notes

- T005 consolidates all 7 proxy dispatch cases into one task (same file, avoids merge conflicts)
- T006 (Cheats_setEventsEnabled in init) is the single most likely fix for zero combat events — validate early
- T027 is [CONDITIONAL] — only execute if T026 fails (diagnostic fallback for SelfDestruct)
- T029-T032 (spawn crash diagnosis) are sequential by design — each test informs the next
- If US2 diagnosis reveals the proxy IS filtering events (contradicting research), escalate and re-plan
- Kill stale engine processes before each test run: `pkill -9 -x spring-headless 2>/dev/null || true`
