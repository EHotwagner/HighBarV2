# Tasks: Live Headless Engine Test Suite

**Input**: Design documents from `/specs/004-live-headless-testsuite/`
**Prerequisites**: plan.md (required), spec.md (required for user stories), research.md, data-model.md, contracts/

**Tests**: No test tasks generated — this feature IS test infrastructure. Validation is performed by running the existing test suite against a live engine.

**Organization**: Tasks are grouped by user story to enable independent implementation and testing of each story.

## Format: `[ID] [P?] [Story] Description`

- **[P]**: Can run in parallel (different files, no dependencies)
- **[Story]**: Which user story this task belongs to (e.g., US1, US2, US3)
- Include exact file paths in descriptions

---

## Phase 1: Setup (Shared Infrastructure)

**Purpose**: Create the version pinning configuration that all stories depend on

- [x] T001 Create engine version configuration file at tests/engine-version.json with pinned engine version, game archive name, rapid tag, map name, and download URL per the engine-version-schema contract

---

## Phase 2: Foundational (Blocking Prerequisites)

**Purpose**: Modify existing fixture scripts to support live engine testing with log capture and stable game scenarios

**⚠️ CRITICAL**: No user story work can begin until this phase is complete

- [x] T002 [P] Modify tests/fixtures/game-setup.lua to add GameMode=3 in the MODOPTIONS section to disable victory conditions, ensuring the game stays alive indefinitely until the harness terminates it
- [x] T003 [P] Modify tests/fixtures/start-headless.sh to accept a session directory parameter, redirect engine stdout/stderr to engine-stdout.log and engine-stderr.log in that directory, and pass --write-dir to the engine so infolog.txt lands in the session directory

**Checkpoint**: Foundation ready — fixture scripts support log capture and stable game scenarios

---

## Phase 3: User Story 1 - Run Integration Tests Against Live Engine (Priority: P1) 🎯 MVP

**Goal**: Developers can run the existing F# and Python integration test suites against a real `spring-headless` engine with a single command, getting clear errors when prerequisites are missing

**Independent Test**: Run `dotnet test tests/integration/fsharp/` with `spring-headless` installed and verify all tests execute against a live engine process. Repeat with `pytest` for Python.

### Implementation for User Story 1

- [x] T004 [US1] Create tests/check-prerequisites.sh implementing the check-prerequisites-cli contract: check engine binary existence (via HIGHBAR_TEST_ENGINE or PATH), report human-readable pass/fail with actionable error messages, exit code 0 on success and 1 on failure. Read engine.binary from tests/engine-version.json using jq. Support --json flag for machine-parseable output. (This implements the engine_binary check only; T011 extends this script with version validation, game archive, and map checks to complete the full contract)
- [x] T005 [P] [US1] Extend tests/integration/fsharp/Harness.fs InitializeAsync to: create a per-session temp directory, call check-prerequisites.sh before engine launch (fail with descriptive xUnit skip/error if prerequisites missing), pass session directory to start-headless.sh, and store the session directory path for diagnostics
- [x] T006 [P] [US1] Extend tests/integration/python/conftest.py engine_socket fixture to: create a per-session temp directory, call check-prerequisites.sh before engine launch (pytest.skip with descriptive message if prerequisites missing), pass session directory to start-headless.sh, and store the session directory path for diagnostics
- [x] T007 [P] [US1] Add engine crash detection to tests/integration/fsharp/Harness.fs: store the engine Process object, add an IsEngineAlive property that checks Process.HasExited, add a ThrowIfEngineCrashed method that reads engine-stderr.log and throws with diagnostic info, call it in a test collection-level check or expose it for individual tests
- [x] T008 [P] [US1] Add engine crash detection to tests/integration/python/conftest.py: store the engine PID, add an is_engine_alive() helper using os.kill(pid, 0), add a check_engine_alive() function that reads engine-stderr.log and raises with diagnostic info on crash, call it before yielding the socket fixture or expose it via a separate fixture
- [x] T009 [US1] Validate all existing F# integration tests (ConnectionTests, EventTests, CommandTests, CallbackTests, ScenarioTests) pass against the live headless engine by running dotnet test tests/integration/fsharp/ and fixing any harness issues that surface
- [x] T010 [US1] Validate all existing Python integration tests (test_connection, test_events, test_commands, test_callbacks) pass against the live headless engine by running pytest tests/integration/python/ and fixing any harness issues that surface

**Checkpoint**: At this point, User Story 1 should be fully functional — developers can run the full test suite against a live engine with clear prerequisite errors

---

## Phase 4: User Story 2 - Automated Engine Content Provisioning (Priority: P2)

**Goal**: New developers can set up their environment with all required engine binary, game archive, and map files through an automated workflow

**Independent Test**: Run `./tests/check-prerequisites.sh` on a machine missing game content and verify it identifies all missing components. Run `./tests/setup-engine.sh` and verify it downloads the missing components successfully.

### Implementation for User Story 2

- [x] T011 [US2] Extend tests/check-prerequisites.sh to add: engine version validation (run engine --sync-version and compare against pinned version in tests/engine-version.json), game archive existence check (scan SPRING_DATADIR for the pinned game archive), map file existence check (scan SPRING_DATADIR/maps/ for the pinned map), and actionable resolution messages with download URLs for each failing check
- [x] T012 [US2] Create tests/setup-engine.sh that reads tests/engine-version.json: checks for engine binary and downloads from the pinned downloadUrl if missing, checks for game archive and runs pr-downloader with the pinned rapidTag if missing, checks for map and prints download instructions if missing (maps hosted externally on Google Drive), reports summary of actions taken

**Checkpoint**: At this point, User Stories 1 AND 2 should both work independently — new developers can provision their environment and run tests

---

## Phase 5: User Story 3 - Test Result Reporting and Diagnostics (Priority: P3)

**Goal**: Test failures against the live engine include engine logs, proxy logs, and socket state information so developers can diagnose issues without re-running

**Independent Test**: Intentionally cause a test failure (e.g., configure wrong map name) and verify output includes engine log excerpts alongside the assertion failure.

### Implementation for User Story 3

- [x] T013 [US3] Add diagnostic log surfacing to tests/integration/fsharp/Harness.fs: on test failure or engine crash, read engine-stdout.log, engine-stderr.log, and infolog.txt from the session directory, attach relevant excerpts (last 50 lines) to the xUnit test output via ITestOutputHelper or IMessageSink, include socket path and engine PID in the diagnostic header
- [x] T014 [US3] Add diagnostic log surfacing to tests/integration/python/conftest.py: on test failure or engine crash, read engine-stdout.log, engine-stderr.log, and infolog.txt from the session directory, print relevant excerpts (last 50 lines) to pytest output via capsys or print, include socket path and engine PID in the diagnostic header

**Checkpoint**: All user stories should now be independently functional — full live engine test suite with provisioning and diagnostics

---

## Phase 6: Polish & Cross-Cutting Concerns

**Purpose**: Documentation and validation across all stories

- [x] T015 [P] Update tests/README.md to document: the prerequisites check workflow (tests/check-prerequisites.sh), the setup script (tests/setup-engine.sh), the engine-version.json configuration, the session directory and log capture behavior, and troubleshooting steps for common live engine issues
- [x] T016 Run quickstart.md validation: execute the quickstart workflow end-to-end (check-prerequisites → setup-engine → dotnet test → pytest) and verify all steps work as documented in specs/004-live-headless-testsuite/quickstart.md

---

## Dependencies & Execution Order

### Phase Dependencies

- **Setup (Phase 1)**: No dependencies — can start immediately
- **Foundational (Phase 2)**: Depends on Setup (T001) — T002 and T003 need engine-version.json for map name reference. BLOCKS all user stories.
- **User Story 1 (Phase 3)**: Depends on Foundational (Phase 2) completion
- **User Story 2 (Phase 4)**: Depends on Phase 3 T004 (extends check-prerequisites.sh created in US1)
- **User Story 3 (Phase 5)**: Depends on Phase 3 T005/T006 (extends harness session directory created in US1)
- **Polish (Phase 6)**: Depends on all user stories being complete

### User Story Dependencies

- **User Story 1 (P1)**: Can start after Foundational (Phase 2) — No dependencies on other stories
- **User Story 2 (P2)**: Depends on T004 from US1 (extends the check-prerequisites.sh script)
- **User Story 3 (P3)**: Depends on T005/T006 from US1 (extends the session directory mechanism)

### Within Each User Story

- T004 must complete before T005/T006 (harnesses call the script T004 creates)
- T005 and T006 can run in parallel (different files)
- T007 and T008 can run in parallel (different files)
- T009 depends on T005 + T007 (F# harness must be complete)
- T010 depends on T006 + T008 (Python harness must be complete)
- T013 depends on T005 + T007 (extends F# harness)
- T014 depends on T006 + T008 (extends Python harness)

### Parallel Opportunities

- T002 and T003 can run in parallel (different files)
- T005 and T006 can run in parallel (F# vs Python harness)
- T007 and T008 can run in parallel (F# vs Python crash detection)
- T009 and T010 can run in parallel (independent test runners)
- T013 and T014 can run in parallel (F# vs Python diagnostics)
- T015 can run in parallel with T016

---

## Parallel Example: User Story 1

```bash
# After T004 completes, launch harness extensions in parallel:
Task: "T005 - Extend F# Harness.fs with prerequisites check in tests/integration/fsharp/Harness.fs"
Task: "T006 - Extend Python conftest.py with prerequisites check in tests/integration/python/conftest.py"

# After T005/T006 complete, launch crash detection in parallel:
Task: "T007 - Add crash detection to F# Harness.fs"
Task: "T008 - Add crash detection to Python conftest.py"

# After T007/T008 complete, validate both test suites in parallel:
Task: "T009 - Validate F# tests against live engine"
Task: "T010 - Validate Python tests against live engine"
```

---

## Implementation Strategy

### MVP First (User Story 1 Only)

1. Complete Phase 1: Setup (T001)
2. Complete Phase 2: Foundational (T002, T003)
3. Complete Phase 3: User Story 1 (T004–T010)
4. **STOP and VALIDATE**: Run `dotnet test tests/integration/fsharp/` and `pytest tests/integration/python/` against a live engine
5. All existing tests should pass against the real headless engine

### Incremental Delivery

1. Complete Setup + Foundational → Foundation ready
2. Add User Story 1 → Validate with live engine → MVP complete
3. Add User Story 2 → New developers can self-provision → Onboarding ready
4. Add User Story 3 → Failures include diagnostics → Full feature complete
5. Each story adds value without breaking previous stories

---

## Notes

- [P] tasks = different files, no dependencies
- [Story] label maps task to specific user story for traceability
- Each user story should be independently completable and testable
- Commit after each task or logical group using Conventional Commits (test:, build:)
- Stop at any checkpoint to validate story independently
- T009 and T010 are validation tasks — they may surface harness bugs that require fixing T005–T008
