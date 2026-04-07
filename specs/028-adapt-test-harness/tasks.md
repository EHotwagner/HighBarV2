# Tasks: Adapt FSBarV1 Test Harness and Engine Handling

**Input**: Design documents from `/specs/028-adapt-test-harness/`
**Prerequisites**: plan.md (required), spec.md (required for user stories), research.md, data-model.md, quickstart.md

**Tests**: Not explicitly requested. Test validation uses existing test suites (`./tests/run-all.sh`).

**Organization**: Tasks are grouped by user story to enable independent implementation and testing of each story.

## Format: `[ID] [P?] [Story] Description`

- **[P]**: Can run in parallel (different files, no dependencies)
- **[Story]**: Which user story this task belongs to (e.g., US1, US2, US3)
- Include exact file paths in descriptions

---

## Phase 1: Setup (Shared Infrastructure)

**Purpose**: Add new source files to the client project and prepare the build

- [x] T001 Add new F# source file entries to `clients/fsharp/src/Client.fsproj` for: EngineConfig.fs, EngineLauncher.fs, ScriptGenerator.fs, EngineSession.fs, SessionDiagnostics.fs, EngineDisconnectedException.fs (order matters for F# compilation — these must appear before existing files that will depend on them, but after Client.fs and protocol files they depend on)

---

## Phase 2: Foundational (Blocking Prerequisites)

**Purpose**: Create the core modules that all user stories depend on. These modules replace duplicated code across three harnesses and eliminate shell script dependencies.

**CRITICAL**: No user story integration work can begin until this phase is complete.

- [x] T002 [P] [US3] Create `EngineConfig` record type in `clients/fsharp/src/EngineConfig.fs` — define `EngineMode` DU (Headless/Graphical), `EngineConfig` record with all fields (Mode, SocketPath, MapName, GameType, EngineBin, DataDir, OpponentAI, OpponentSide, OurSide, AcceptTimeoutMs, ReadTimeoutMs, GameSpeed, ShutdownGraceMs), `defaultConfig()` factory generating unique GUID-based socket path, `fromVersionFile(path)` factory that reads `tests/engine-version.json` and applies env var overrides (`HIGHBAR_TEST_ENGINE`, `HIGHBAR_TEST_MAP`, `HIGHBAR_TEST_TIMEOUT`, `HIGHBAR_CLIENT_TIMEOUT_MS`, `SPRING_DATADIR`), and `validate()` function that fails fast on invalid values. Reference: FSBarV1 `src/FSBar.Client/EngineConfig.fs`

- [x] T003 [P] [US4] Create `EngineDisconnectedException` in `clients/fsharp/src/EngineDisconnectedException.fs` — custom exception extending `System.IO.IOException` with optional `LastFrameNumber: int option` and optional `Diagnostics` field. Include factory functions: `fromTimeout(timeoutMs, elapsed, engineAlive)`, `fromDisconnect(lastFrame, message)`. Reference: FSBarV1 `src/FSBar.Client/Connection.fs` (EngineDisconnectedException type)

- [x] T004 [P] [US4] Create `SessionDiagnostics` module in `clients/fsharp/src/SessionDiagnostics.fs` — define `SessionDiagnostics` record (SessionDir, SocketPath, LastFrameNumber, EngineExitCode option, StdoutTail, StderrTail, InfologTail as string lists), implement `collect(sessionDir, socketPath, lastFrame, engineProcess)` function that reads last 50 lines from stdout.log, stderr.log, infolog.txt in the session directory, and `formatReport(diag)` that produces a human-readable multi-line diagnostic string. Reference: current `ThrowIfEngineCrashed()` in `tests/integration/fsharp/Harness.fs` and `tests/persistent/fsharp/PersistentHarness.fs`

- [x] T005 [P] [US1] Create `ScriptGenerator` module in `clients/fsharp/src/ScriptGenerator.fs` — implement `generate(config: EngineConfig) -> string` that produces a complete Spring engine TDF-format startup script from EngineConfig fields. Must include [GAME] section (MapName, GameType, mod options), [MODOPTIONS] (faction selection, game speed), [PLAYER0]+[AI0] for the HighBar client (with socket path in AI OPTIONS), [AI1] for opponent, [TEAM0]+[TEAM1] with sides, and cheat commands enablement (debugcommands). Use fixed RNG seed for reproducibility. Reference: FSBarV1 `src/FSBar.Client/ScriptGenerator.fs` and current `tests/fixtures/game-setup.txt` template

- [x] T006 [US1] [US2] Create `EngineLauncher` module in `clients/fsharp/src/EngineLauncher.fs` — implement: (1) `detectDataDir(engineBinPath) -> string option` that walks up from engine binary looking for maps/ + packages/ dirs, falls back to `~/.local/state/Beyond All Reason/`, supports `SPRING_DATADIR` env override; (2) `getSessionDir(config) -> string` deriving `/tmp/highbar-{guid}/` from socket path; (3) `launch(config, scriptContent) -> Process` that creates session dir, writes script.txt, writes springsettings.cfg, redirects stdout/stderr to session dir files, sets HIGHBAR_SOCKET_PATH + SPRING_WRITEDIR + SPRING_DATADIR env vars, spawns process, writes PID to `{socketPath}.pid`; (4) `stop(socketPath, proc, graceMs) -> unit` with SIGTERM → wait → SIGKILL sequence, PID file and socket file cleanup. Reference: FSBarV1 `src/FSBar.Client/EngineLauncher.fs` and current `tests/fixtures/start-headless.sh` + `tests/fixtures/stop-headless.sh`

- [x] T007 [US1] [US2] Create `EngineSession` class in `clients/fsharp/src/EngineSession.fs` — the main unified lifecycle abstraction. Define `SessionState` DU (Idle, Starting, Connected, Running, Stopped, Error of string). Implement class with: (1) constructor taking `EngineConfig`; (2) `Start()` method orchestrating: state→Starting, create listener socket (Connection.createListener), generate script (ScriptGenerator.generate), launch engine (EngineLauncher.launch), poll/accept proxy connection with timeout, handshake via HighBarClient, state→Connected; (3) `Step() -> GameFrame` for passive observation; (4) `StepWith(handler) -> GameFrame` for AI-controlled frames; (5) `Run(count, handler) -> GameFrame list` loop; (6) `RunUntil(predicate, handler) -> GameFrame list`; (7) `Stop(preserveSession: bool)` safe from any state — disconnect client, close sockets, stop engine via EngineLauncher.stop, conditionally delete session dir; (8) `GetDiagnostics() -> SessionDiagnostics`; (9) `CleanupStaleProcesses()` static method that scans `/tmp/highbar-*.pid` files, checks if referenced processes are alive, kills stale ones via PID, logs warnings for untracked spring-headless processes; (10) IDisposable implementation. Track `LastFrameNumber` and raise `EngineDisconnectedException` with diagnostics on disconnect/timeout. Reference: FSBarV1 `src/FSBar.Client/BarClient.fs`

**Checkpoint**: All 6 new modules compile. `dotnet build` in `clients/fsharp/` succeeds. No harness changes yet.

---

## Phase 3: User Story 1+2 - Unified Engine Lifecycle + Orphan Prevention (Priority: P1)

**Goal**: Migrate all three test harnesses to use EngineSession, eliminating duplicated code. Remove shell-based engine lifecycle scripts.

**Independent Test**: Run `./tests/run-all.sh --category integration` and `./tests/run-all.sh --category persistent` — all existing tests pass using the new unified harness.

### Implementation for User Stories 1+2

- [x] T008 [US1] [US2] Migrate integration test harness in `tests/integration/fsharp/Harness.fs` — replace the ~245-line implementation with a thin wrapper around EngineSession: (1) `EngineFixture` constructor creates EngineConfig via `fromVersionFile()`, (2) `InitializeAsync()` calls `EngineSession.CleanupStaleProcesses()` then creates and starts EngineSession, runs 30 warm-up frames via `session.Run(30, fun _ -> [])`, stores InitialFrames and InitialEvents, (3) `DisposeAsync()` calls `session.Stop(preserveSession = testFailed)`, (4) remove all duplicated socket creation, process spawning, PID reading, stop script invocation, and cleanup code. Preserve `EngineCollection` collection definition unchanged. Target: ~50-60 lines.

- [x] T009 [US1] [US2] Migrate AI test harness in `tests/ai/fsharp/AiTestHarness.fs` — refactor `GameOrchestrator.runSingleGame` to: (1) create EngineConfig with appropriate overrides (opponent AI, game speed), (2) create EngineSession, call Start(), (3) run frame loop via session.StepWith/RunUntil, (4) call Stop(preserveSession) based on game result and HIGHBAR_KEEP_LOGS env var. Remove duplicated socket creation, process spawning, stop script invocation, and cleanup code. Keep GameResult DU, BattleMetrics, and game-specific logic unchanged. Keep fixture types (HeadlessAiFixture, LiveAiFixture) as thin wrappers.

- [x] T010 [US1] [US2] Migrate persistent test harness in `tests/persistent/fsharp/PersistentHarness.fs` — replace engine lifecycle code with EngineSession: (1) `PersistentEngineFixture` creates EngineConfig via `fromVersionFile()`, (2) `InitializeAsync()` calls `EngineSession.CleanupStaleProcesses()`, creates and starts EngineSession, runs warm-up and UnitDef discovery using `session.Step()`/`session.StepWith()`, (3) `DisposeAsync()` calls `session.Stop(preserveSession = testFailed)`. Keep ALL persistent-specific logic unchanged: UnitDefInfo, UnitDefRegistry, BatchResult, BattleMetrics, ResetGameState(), RunFrames(), SpawnUnit(), discovery logic, test ordering. Only replace the duplicated infrastructure (socket creation, process spawning, PID management, stop script, cleanup).

- [x] T011 [US1] Verify integration tests pass with `./tests/run-all.sh --category integration` — run the full integration test suite and confirm all tests pass with the new harness. Fix any issues.

- [x] T012 [US1] Verify persistent tests pass with `./tests/run-all.sh --category persistent` — run the full persistent test suite and confirm test results match or improve compared to pre-refactor baseline. Fix any issues.

- [x] T013 [US1] Remove replaced shell scripts: delete `tests/fixtures/start-headless.sh`, `tests/fixtures/stop-headless.sh`, and `tests/fixtures/game-setup.txt`. Verify no remaining references to these files in the codebase (grep for filenames). Update `tests/run-all.sh` if it references these scripts directly.

**Checkpoint**: All integration and persistent tests pass. Shell scripts removed. Each harness is a thin wrapper around EngineSession.

---

## Phase 4: User Story 3+4 - Configuration Centralization + Error Handling Validation (Priority: P2)

**Goal**: Verify that centralized configuration and improved error handling are working correctly across all test categories.

**Independent Test**: Change the map name in `tests/engine-version.json`, run tests, and confirm the new map is used. Simulate an engine crash and verify diagnostic output includes frame numbers and log excerpts.

### Implementation for User Stories 3+4

- [x] T014 [US3] Verify single-source configuration in `tests/engine-version.json` — confirm that all three migrated harnesses read their engine path, map name, game type, and version from `EngineConfig.fromVersionFile()`. Change the map name temporarily and run one test from each category to verify the change propagates. Revert after verification.

- [x] T015 [US3] Verify environment variable overrides work — set `HIGHBAR_TEST_ENGINE`, `HIGHBAR_TEST_MAP`, and `HIGHBAR_CLIENT_TIMEOUT_MS` environment variables, run a test, and confirm the overrides take precedence over `engine-version.json` values. Verify that `EngineConfig.validate()` catches invalid values (e.g., negative timeout).

- [x] T016 [US4] Verify error diagnostics in integration harness — confirm that when the engine crashes or disconnects during a test, the `EngineDisconnectedException` includes: last frame number, engine exit code, and tail of stdout/stderr/infolog. Check that session directories are preserved on failure and cleaned up on success (per clarification).

- [x] T017 [US4] Verify error diagnostics in persistent harness — same verification as T016 but for persistent tests. Confirm that `GetDiagnostics()` output appears in xUnit test failure messages.

**Checkpoint**: Configuration is single-source. Error reporting includes full diagnostics.

---

## Phase 5: User Story 5 - Reliable Game State Reset (Priority: P3)

**Goal**: Make the persistent test state reset mechanism atomic and verified, ensuring each test starts from a known clean state.

**Independent Test**: Run the persistent test suite twice consecutively and verify identical results both times.

### Implementation for User Story 5

- [x] T018 [US5] Improve `ResetGameState()` in `tests/persistent/fsharp/PersistentHarness.fs` — refactor to: (1) send `.destroy` cheat commands for all non-initial units (existing behavior), (2) run verification frames (up to 60) checking that `knownUnitIds` count returns to `initialUnitIds` count, (3) if verification times out, raise explicit error listing remaining unit IDs and their states instead of silently continuing, (4) if cheats are not enabled (destroy commands have no effect), detect via unit count not decreasing and raise explicit error. Use `session.StepWith()` for the verification loop.

- [x] T019 [US5] Verify persistent test determinism — run `./tests/run-all.sh --category persistent` twice consecutively and compare results. Confirm identical pass/fail outcomes. If T2b_MoveVerifyTest or other tests remain flaky, investigate whether the verified reset resolves the flakiness.

**Checkpoint**: Persistent tests produce identical results on consecutive runs.

---

## Phase 6: Polish & Cross-Cutting Concerns

**Purpose**: Final cleanup and validation

- [x] T020 [P] Run full test suite regression with `./tests/run-all.sh` — confirm all categories (unit, proxy, integration, persistent) pass. Compare total pass count to pre-refactor baseline.
- [x] T021 [P] Verify no orphaned processes after test run — after `./tests/run-all.sh` completes, check `pgrep spring-headless` returns no results. Also test: start a test run, kill the test runner mid-execution with SIGKILL, start another run, and verify `CleanupStaleProcesses()` cleans up the orphan.
- [x] T022 Remove any dead code from `tests/check-prerequisites.sh` that referenced the removed shell scripts (start-headless.sh, stop-headless.sh). Keep the script functional as a standalone prerequisite checker.
- [x] T023 Verify `clients/fsharp/` builds cleanly with `dotnet build` and has no compiler warnings in new modules.

---

## Dependencies & Execution Order

### Phase Dependencies

- **Setup (Phase 1)**: No dependencies — can start immediately
- **Foundational (Phase 2)**: Depends on Setup — BLOCKS all user stories
- **US1+US2 (Phase 3)**: Depends on all Foundational modules (T002-T007)
- **US3+US4 (Phase 4)**: Depends on Phase 3 harness migrations (T008-T010)
- **US5 (Phase 5)**: Depends on Phase 3 persistent harness migration (T010)
- **Polish (Phase 6)**: Depends on all previous phases

### User Story Dependencies

- **US1+US2 (P1)**: Depends on Foundational phase — core deliverable
- **US3 (P2)**: Delivered by T002 (EngineConfig) + validated in T014-T015
- **US4 (P2)**: Delivered by T003-T004 (exceptions + diagnostics) + validated in T016-T017
- **US5 (P3)**: Depends on US1 persistent harness migration (T010)

### Within Phase 2 (Foundational)

- T002, T003, T004, T005 are parallelizable (independent files, no cross-dependencies)
- T006 depends on T002 (uses EngineConfig) and T005 (writes script from ScriptGenerator)
- T007 depends on T002, T003, T004, T005, T006 (uses all other modules)

### Within Phase 3 (US1+US2)

- T008, T009 are parallelizable (different harness files)
- T010 can run in parallel with T008/T009 but is more complex
- T011 depends on T008
- T012 depends on T010
- T013 depends on T008, T009, T010

---

## Parallel Example: Phase 2 (Foundational)

```
# These 4 tasks can run in parallel (different files, no dependencies):
T002: EngineConfig.fs
T003: EngineDisconnectedException.fs
T004: SessionDiagnostics.fs
T005: ScriptGenerator.fs

# Then sequentially:
T006: EngineLauncher.fs (depends on T002, T005)
T007: EngineSession.fs (depends on T002-T006)
```

## Parallel Example: Phase 3 (US1+US2 Harness Migration)

```
# These 3 tasks can run in parallel (different harness files):
T008: Migrate integration/fsharp/Harness.fs
T009: Migrate ai/fsharp/AiTestHarness.fs
T010: Migrate persistent/fsharp/PersistentHarness.fs

# Then sequentially:
T011: Verify integration tests
T012: Verify persistent tests
T013: Remove shell scripts
```

---

## Implementation Strategy

### MVP First (User Stories 1+2 Only)

1. Complete Phase 1: Setup (T001)
2. Complete Phase 2: Foundational (T002-T007)
3. Complete Phase 3: US1+US2 — migrate harnesses, verify, remove scripts (T008-T013)
4. **STOP and VALIDATE**: Run `./tests/run-all.sh` — all tests pass with unified harness

### Incremental Delivery

1. Setup + Foundational → Core modules ready
2. US1+US2 → Test harnesses unified, shell scripts eliminated (MVP!)
3. US3+US4 → Config centralization and error handling validated
4. US5 → Persistent test determinism improved
5. Polish → Full regression, orphan prevention verified

---

## Notes

- [P] tasks = different files, no dependencies
- [Story] label maps task to specific user story for traceability
- US3 and US4 modules are built in Phase 2 (Foundational) because they are prerequisites for US1/US2, but validated separately in Phase 4
- The persistent harness (T010) is the most complex migration — it has ~619 lines of domain-specific logic (UnitDef discovery, spawn testing, battle metrics) that must be preserved unchanged
- Reference implementation: FSBarV1 at `/home/developer/projects/FSBarV1/src/FSBar.Client/`
- Commit after each task or logical group
