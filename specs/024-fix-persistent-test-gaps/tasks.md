# Tasks: Fix Persistent Test Remaining Gaps

**Input**: Design documents from `/specs/024-fix-persistent-test-gaps/`
**Prerequisites**: plan.md, spec.md, research.md, data-model.md, quickstart.md

**Tests**: Not explicitly requested in the specification. Test tasks are included only for US2 (engine-kill verification) since the user story IS a test.

**Organization**: Tasks grouped by user story for independent implementation and testing.

## Format: `[ID] [P?] [Story] Description`

- **[P]**: Can run in parallel (different files, no dependencies)
- **[Story]**: Which user story this task belongs to (e.g., US1, US2, US3)
- Include exact file paths in descriptions

---

## Phase 1: Setup (Shared Infrastructure)

**Purpose**: No setup needed — this feature modifies existing test files in an existing project. All dependencies (xUnit 2.9.x, HighBar.Client with EngineDisconnectedException) are already present.

*(No tasks in this phase)*

---

## Phase 2: Foundational (Blocking Prerequisites)

**Purpose**: No foundational tasks needed — all changes are leaf-level modifications to the test harness and test files. No shared infrastructure must be created first.

*(No tasks in this phase)*

---

## Phase 3: User Story 1 — Map Tests Pass Reliably in Full Suite (Priority: P1) 🎯 MVP

**Goal**: T9.3 and T9.4 pass reliably in the full persistent test suite regardless of prior test state.

**Independent Test**: Run `./tests/run-all.sh --category persistent` end-to-end. T9.3 and T9.4 must pass alongside all other tests.

### Implementation for User Story 1

- [x] T001 [US1] Remove silent exception swallow in `queryInFrame` helper — delete the `try/with _ -> ()` wrapper around `engine.RunFrames` so real errors propagate in `tests/persistent/fsharp/T9_MapTests.fs`
- [x] T002 [US1] Add `engine.ResetGameState()` call before height map query in T9.2 in `tests/persistent/fsharp/T9_MapTests.fs`
- [x] T003 [US1] Add `engine.ResetGameState()` call before start position query in T9.3 in `tests/persistent/fsharp/T9_MapTests.fs`
- [x] T004 [US1] Add `engine.ResetGameState()` call before metal spots query in T9.4 in `tests/persistent/fsharp/T9_MapTests.fs`

**Checkpoint**: T9.3 and T9.4 pass in the full persistent suite on 3 consecutive runs. Run `./tests/run-all.sh --category persistent` to validate.

---

## Phase 4: User Story 2 — Automated Engine-Kill Verification (Priority: P2)

**Goal**: Automated proof that the 023 socket disconnect fix works against a real engine kill.

**Independent Test**: Run `dotnet test tests/persistent/fsharp/ --filter "T10"` — all 3 tests pass.

### Implementation for User Story 2

- [x] T005 [US2] Create `EngineKillFixture` class with `IAsyncLifetime` that starts its own engine instance, connects a `HighBarClient`, and provides `KillEngine()` method (sends SIGKILL) in `tests/persistent/fsharp/T10_EngineKillTests.fs`
- [x] T006 [US2] Implement T10.1 test: kill engine during frame loop, assert `EngineDisconnectedException` is thrown within 10s in `tests/persistent/fsharp/T10_EngineKillTests.fs`
- [x] T007 [US2] Implement T10.2 test: after engine kill, verify `ThrowIfEngineCrashed` fires immediately (no hang) in `tests/persistent/fsharp/T10_EngineKillTests.fs`
- [x] T008 [US2] Implement T10.3 test: set `HIGHBAR_CLIENT_TIMEOUT_MS=2000`, kill engine, verify detection within ~3s in `tests/persistent/fsharp/T10_EngineKillTests.fs`
- [x] T009 [US2] Add `T10_EngineKillTests.fs` to the persistent test project file and configure a separate xUnit collection to avoid conflicts with the shared `PersistentEngineFixture`

**Checkpoint**: `dotnet test tests/persistent/fsharp/ --filter "T10"` passes with 3 green tests.

---

## Phase 5: User Story 3 — Graceful Handling of Engine Death During Initialization (Priority: P3)

**Goal**: When engine dies during `InitializeAsync` warm-up, produce a formatted diagnostic error instead of a raw exception.

**Independent Test**: Visual inspection of the catch block; T10 engine-kill tests provide confidence that `EngineDisconnectedException` propagates correctly.

### Implementation for User Story 3

- [x] T010 [US3] Wrap the three `c.Run(...)` warm-up loops in `InitializeAsync` with a catch for `EngineDisconnectedException` that delegates to `ThrowIfEngineCrashed()` for formatted diagnostics in `tests/persistent/fsharp/PersistentHarness.fs`
- [x] T011 [US3] Ensure that when `ThrowIfEngineCrashed()` cannot find the engine process (already exited), construct a manual diagnostic message with PID, exit code, and socket path in `tests/persistent/fsharp/PersistentHarness.fs`

**Checkpoint**: Code review confirms the catch block delegates to `ThrowIfEngineCrashed()` and produces a diagnostic message with PID, exit code, and socket path.

---

## Phase 6: Polish & Cross-Cutting Concerns

**Purpose**: Final validation across all user stories

- [x] T012 Run full persistent test suite 3 times via `./tests/run-all.sh --category persistent` — all tests pass each run (47+ tests green, 0 failures)
- [x] T013 Run engine-kill tests via `dotnet test tests/persistent/fsharp/ --filter "T10"` — all 3 pass
- [x] T014 Verify no regressions in existing T0-T8 tests after T9 `queryInFrame` exception handling change

---

## Dependencies & Execution Order

### Phase Dependencies

- **Setup (Phase 1)**: Skipped — nothing to set up
- **Foundational (Phase 2)**: Skipped — no blocking prerequisites
- **US1 (Phase 3)**: Can start immediately — modifies only `T9_MapTests.fs`
- **US2 (Phase 4)**: Can start immediately — creates new `T10_EngineKillTests.fs` (no dependency on US1)
- **US3 (Phase 5)**: Can start immediately — modifies only `PersistentHarness.fs` (no dependency on US1 or US2)
- **Polish (Phase 6)**: Depends on all user stories being complete

### User Story Dependencies

- **User Story 1 (P1)**: No dependencies — modifies `T9_MapTests.fs` only
- **User Story 2 (P2)**: No dependencies on other stories — creates new `T10_EngineKillTests.fs` with standalone fixture
- **User Story 3 (P3)**: No dependencies on other stories — modifies `PersistentHarness.fs` only

### Parallel Opportunities

- **US1 and US2 and US3 can ALL run in parallel** — they touch different files with no overlap:
  - US1: `T9_MapTests.fs` only
  - US2: `T10_EngineKillTests.fs` (new file)
  - US3: `PersistentHarness.fs` only
- Within US1: T002, T003, T004 can run in parallel (same file but different test methods — in practice sequential since same file)
- Within US2: T006, T007, T008 are sequential (same file, each builds on fixture from T005)

---

## Parallel Example: All User Stories

```bash
# All three user stories can be launched simultaneously:
# Worker A (US1): Fix T9 map tests in tests/persistent/fsharp/T9_MapTests.fs
# Worker B (US2): Create engine-kill tests in tests/persistent/fsharp/T10_EngineKillTests.fs
# Worker C (US3): Harden init disconnect handling in tests/persistent/fsharp/PersistentHarness.fs
```

---

## Implementation Strategy

### MVP First (User Story 1 Only)

1. Complete Phase 3: User Story 1 (fix T9 map tests)
2. **STOP and VALIDATE**: Run `./tests/run-all.sh --category persistent` — T9.3 and T9.4 must pass
3. This alone resolves the 2 currently failing tests

### Incremental Delivery

1. US1 → Fix flaky map tests → Validate persistent suite → 47/47 pass (MVP!)
2. US2 → Add engine-kill verification → Validate T10 tests → Regression guard for 023 fix
3. US3 → Harden init error handling → Code review → Developer experience polish
4. Polish → Full suite validation across all stories

---

## Notes

- T001 is the most impactful single change — removing the silent exception swallow will reveal any hidden failures in T9
- US2 requires engine start/stop during tests (adds ~30s to test suite runtime)
- US3 is hard to test automatically (engine must die during ~1s warm-up window) — T10 provides indirect confidence
- All 3 user stories are fully independent — no cross-story dependencies
