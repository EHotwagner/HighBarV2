# Tasks: Consolidate Test Framework

**Input**: Design documents from `/specs/018-consolidate-test-framework/`
**Prerequisites**: plan.md (required), spec.md (required for user stories), research.md, data-model.md, quickstart.md

**Tests**: No separate test tasks generated — this feature IS test infrastructure. Validation is done by running the unified runner itself.

**Organization**: Tasks are grouped by user story to enable independent implementation and testing of each story.

## Format: `[ID] [P?] [Story] Description`

- **[P]**: Can run in parallel (different files, no dependencies)
- **[Story]**: Which user story this task belongs to (e.g., US1, US2, US3)
- Include exact file paths in descriptions

## Phase 1: Setup

**Purpose**: Create the reports directory and establish the unified runner skeleton

- [x] T001 Create reports output directory at reports/testreports/.gitkeep
- [x] T002 Create unified test runner script skeleton at tests/run-all.sh with argument parsing (--category, --graphical, --help), signal trapping (SIGINT/SIGTERM for cleanup), and report output path logic

---

## Phase 2: Foundational (Blocking Prerequisites)

**Purpose**: Fix all configuration drift and templatize game setup files so every test tier uses engine-version.json as the single source of truth

**⚠️ CRITICAL**: No user story work can begin until this phase is complete

- [x] T003 Templatize game-setup.txt: replace hardcoded `GameType=Beyond All Reason test-29840-d9b7dba` with `GameType=__GAME_TYPE__` in tests/fixtures/game-setup.txt
- [x] T004 [P] Templatize game-setup-e2e.txt: replace hardcoded GameType with `__GAME_TYPE__` in tests/fixtures/game-setup-e2e.txt
- [x] T005 [P] Templatize game-setup-combat-verify.txt: replace hardcoded GameType with `__GAME_TYPE__` in tests/fixtures/game-setup-combat-verify.txt
- [x] T006 [P] Templatize game-setup-live.txt: replace hardcoded GameType with `__GAME_TYPE__` in tests/fixtures/game-setup-live.txt
- [x] T007 [P] Templatize game-setup-barb.txt: replace hardcoded GameType with `__GAME_TYPE__` if present in tests/fixtures/game-setup-barb.txt
- [x] T008 Update start-headless.sh to read game type from engine-version.json via jq and substitute `__GAME_TYPE__` in addition to existing `__MAP_NAME__` and `__SOCKET_PATH__` in tests/fixtures/start-headless.sh
- [x] T009 Update start-live.sh to remove absolute engine paths, use HIGHBAR_TEST_ENGINE or auto-detection, read game type/map from engine-version.json, and substitute all template variables in tests/fixtures/start-live.sh
- [x] T010 Update Python conftest.py to use the same auto-detection logic for SPRING_DATADIR (derive from engine binary path) in tests/integration/python/conftest.py

**Checkpoint**: All test configuration reads from engine-version.json. No hardcoded game versions remain in any fixture file.

---

## Phase 3: User Story 5 - Remove Outdated Tests and Consolidate (Priority: P1) 🎯 MVP

**Goal**: Clean the test suite so every test compiles, runs, and belongs to a clear category with no stale references.

**Independent Test**: Run `dotnet build` on all test projects and verify zero compilation errors. Run `dotnet test` on non-engine projects and verify all pass.

### Implementation

- [x] T011 [US5] Remove tests/integration/fsharp/ScenarioTests.fs (duplicate of persistent T5, known bug with warm-up UnitCreated events) and remove its entry from HighBar.Tests.fsproj file ordering in tests/integration/fsharp/HighBar.Tests.fsproj
- [x] T012 [US5] Verify all F# test projects compile cleanly by running `dotnet build` on tests/unit/fsharp/, tests/integration/fsharp/, tests/persistent/fsharp/, tests/ai/fsharp/, and data/bar.tests/
- [x] T013 [US5] Verify C proxy tests compile and pass by running `cmake --build build && cd build && ctest` from project root
- [x] T014 [US5] Update tests/README.md to reflect current directory structure, correct map name (Red Rock Desert v2), correct game version (test-29840-d9b7dba), and document all test categories in tests/README.md

**Checkpoint**: All tests compile. No stale references. README matches reality.

---

## Phase 4: User Story 1 - Run All Tests with One Command (Priority: P1)

**Goal**: The unified runner discovers and executes all test tiers, producing a combined summary.

**Independent Test**: Run `./tests/run-all.sh` and verify it executes proxy, unit, data, and (if engine available) integration, persistent, and python test suites in order with a final pass/fail/skip summary.

### Implementation

- [x] T015 [US1] Implement proxy test tier in tests/run-all.sh: run `cd build && ctest --output-on-failure` (or skip if build/ doesn't exist), capture results (pass/fail/skip counts, output)
- [x] T016 [US1] Implement unit test tier in tests/run-all.sh: run `dotnet test tests/unit/fsharp/ --logger "trx"`, capture results
- [x] T017 [US1] Implement data test tier in tests/run-all.sh: run `dotnet test data/bar.tests/ --logger "trx"`, capture results
- [x] T018 [US1] Implement prerequisite check gate in tests/run-all.sh: call tests/check-prerequisites.sh --json, parse result, set ENGINE_AVAILABLE flag, skip engine-dependent tiers if prerequisites fail
- [x] T019 [US1] Implement integration test tier in tests/run-all.sh: run `dotnet test tests/integration/fsharp/` with HIGHBAR_TEST_ENGINE and HIGHBAR_TEST_MAP env vars set from auto-detection, capture results (skip if ENGINE_AVAILABLE=false)
- [x] T020 [US1] Implement persistent test tier in tests/run-all.sh: run `dotnet test tests/persistent/fsharp/` with same env vars, capture results (skip if ENGINE_AVAILABLE=false)
- [x] T021 [US1] Implement python test tier in tests/run-all.sh: run `pytest tests/integration/python/ -v` with same env vars, capture results (skip if ENGINE_AVAILABLE=false or pytest not installed)
- [x] T022 [US1] Implement ai test tier in tests/run-all.sh: run `dotnet test tests/ai/fsharp/` with same env vars, capture results (skip if ENGINE_AVAILABLE=false). This tier is opt-in only when --category ai is explicitly passed (long-running)
- [x] T023 [US1] Implement category filter in tests/run-all.sh: --category flag accepts one or more of (proxy, unit, data, integration, persistent, python, ai, all) and only runs matching tiers
- [x] T024 [US1] Implement summary output in tests/run-all.sh: after all tiers complete, print combined totals (Total passed: N, failed: N, skipped: N) with per-tier breakdown and overall exit code (0 if no failures, 1 if any)

**Checkpoint**: `./tests/run-all.sh` runs all non-engine tests. With engine available, engine-dependent tests also run. Category filter works.

---

## Phase 5: User Story 2 - Headless Engine Test Mode (Priority: P1)

**Goal**: Engine auto-detection works seamlessly — no manual env vars needed for standard BAR installations.

**Independent Test**: Run `./tests/run-all.sh --category integration` on a machine with the BAR AppImage installed (no HIGHBAR_TEST_ENGINE set manually) and verify tests execute against the headless engine.

### Implementation

- [x] T025 [US2] Centralize auto-detection logic into a shared function in tests/check-prerequisites.sh (or a new tests/lib/detect-engine.sh sourced by all scripts): given no env vars, find spring-headless binary in standard BAR AppImage locations (~/.local/state/Beyond All Reason/engine/*/spring-headless), derive SPRING_DATADIR, and export HIGHBAR_TEST_ENGINE, SPRING_DATADIR, HIGHBAR_TEST_MAP (from engine-version.json)
- [x] T026 [US2] Update tests/run-all.sh to source the shared auto-detection function and set engine env vars before running engine-dependent tiers
- [x] T027 [US2] Add engine log capture to tests/run-all.sh: for failed engine-dependent tests, find the session directory (from /tmp/highbar-test-*) and include last 30 lines of infolog.txt in the console output
- [x] T028 [US2] Add engine process cleanup to tests/run-all.sh signal trap: on SIGINT/SIGTERM, kill any running spring-headless processes spawned by this test run (using PID files), then continue to report generation

**Checkpoint**: `./tests/run-all.sh` auto-detects engine and runs headless tests with zero manual configuration on standard BAR installations.

---

## Phase 6: User Story 4 - Standardized Test Reports (Priority: P2)

**Goal**: Every test run produces a Markdown report at reports/testreports/.

**Independent Test**: Run `./tests/run-all.sh --category unit` and verify a report file is created at reports/testreports/YYYY-MM-DD_HH-MM-SS_unit.md with correct sections.

### Implementation

- [x] T029 [US4] Add report generation function to tests/run-all.sh: at end of run, generate a Markdown report with sections for: run timestamp, environment (engine version, game version, map, platform from uname), per-tier results table (test name, status, duration), failure details (error messages, stack traces), and summary totals
- [x] T030 [US4] Implement report file naming in tests/run-all.sh: filename format YYYY-MM-DD_HH-MM-SS_{category}.md where category is "all" or the specific --category value. Auto-create reports/testreports/ directory if missing
- [x] T031 [US4] For failed engine tests, include engine log excerpts (last 30 lines of infolog.txt and engine-stderr.log from session directory) in the failure details section of the report
- [x] T032 [US4] On interrupted runs (SIGINT), generate a partial report with an "Interrupted" status marker and whatever results were collected before interruption

**Checkpoint**: Every test run produces a report at reports/testreports/. Failed test reports include diagnostics.

---

## Phase 7: User Story 3 - Live Graphical Test Mode (Priority: P2)

**Goal**: Developer can launch a graphical BAR game with HighBarV2 AI connected for visual validation.

**Independent Test**: Run `./tests/run-all.sh --graphical` on a machine with display and BAR AppImage, verify game launches and AI connects.

### Implementation

- [x] T033 [US3] Implement --graphical flag in tests/run-all.sh: check for DISPLAY env var (fail with message if not set), locate BAR AppImage or spring binary (not spring-headless), and launch the game using tests/fixtures/start-live.sh
- [x] T034 [US3] Update tests/fixtures/start-live.sh to use auto-detection for engine path and game content, substitute all template variables (__GAME_TYPE__, __MAP_NAME__, __SOCKET_PATH__) from engine-version.json, and launch in windowed mode
- [x] T035 [US3] Add graphical mode report generation: when the graphical session ends (engine exits or user stops), generate a report with session duration, AI connection status, and any errors from engine logs

**Checkpoint**: `./tests/run-all.sh --graphical` launches the game with AI connected. Report saved on exit.

---

## Phase 8: Polish & Cross-Cutting Concerns

**Purpose**: Final documentation and cleanup

- [x] T036 [P] Update CLAUDE.md test commands section to reference `./tests/run-all.sh` as the primary test entry point
- [x] T037 [P] Add reports/testreports/ to .gitignore (test reports are local, not committed)
- [x] T038 Validate quickstart.md scenarios: run each command from specs/018-consolidate-test-framework/quickstart.md and verify they work as documented

---

## Dependencies & Execution Order

### Phase Dependencies

- **Setup (Phase 1)**: No dependencies — can start immediately
- **Foundational (Phase 2)**: Depends on Setup completion — BLOCKS all user stories
- **US5 (Phase 3)**: Depends on Foundational — test cleanup must happen before runner references tests
- **US1 (Phase 4)**: Depends on US5 — runner needs clean test suite to produce meaningful results
- **US2 (Phase 5)**: Depends on US1 — auto-detection enhances the runner built in US1
- **US4 (Phase 6)**: Depends on US1 — report generation wraps the runner output from US1
- **US3 (Phase 7)**: Depends on Foundational (Phase 2) — can run in parallel with US1/US2/US4
- **Polish (Phase 8)**: Depends on all user stories being complete

### User Story Dependencies

- **US5 (P1 - Cleanup)**: After Foundational → independent
- **US1 (P1 - Unified Runner)**: After US5 → needs clean test suite
- **US2 (P1 - Headless Auto-detect)**: After US1 → enhances runner
- **US4 (P2 - Reports)**: After US1 → wraps runner output
- **US3 (P2 - Graphical)**: After Foundational → mostly independent (can parallel with US1)

### Within Each User Story

- Tasks within a phase are sequential unless marked [P]
- Complete each phase before moving to the next

### Parallel Opportunities

- T004, T005, T006, T007 can all run in parallel (different fixture files)
- T036, T037 can run in parallel (different files)
- US3 (graphical mode) can be developed in parallel with US1/US2/US4 after Foundational completes

---

## Parallel Example: Phase 2 (Foundational)

```bash
# These fixture file updates can all happen in parallel:
Task: "T004 Templatize game-setup-e2e.txt"
Task: "T005 Templatize game-setup-combat-verify.txt"
Task: "T006 Templatize game-setup-live.txt"
Task: "T007 Templatize game-setup-barb.txt"
```

---

## Implementation Strategy

### MVP First (US5 + US1)

1. Complete Phase 1: Setup (T001-T002)
2. Complete Phase 2: Foundational — fix all config drift (T003-T010)
3. Complete Phase 3: US5 — remove stale tests (T011-T014)
4. Complete Phase 4: US1 — unified runner (T015-T024)
5. **STOP and VALIDATE**: Run `./tests/run-all.sh` and verify all tests pass
6. This is a usable, valuable deliverable

### Incremental Delivery

1. Setup + Foundational → Config is clean
2. Add US5 (cleanup) → All tests compile and pass
3. Add US1 (unified runner) → Single command runs everything (MVP!)
4. Add US2 (auto-detect) → Zero-config engine setup
5. Add US4 (reports) → Persistent test reports
6. Add US3 (graphical) → Visual validation mode
7. Polish → Documentation, gitignore

---

## Notes

- [P] tasks = different files, no dependencies
- [Story] label maps task to specific user story for traceability
- AI test tier (T022) is opt-in only — it runs full games that take minutes
- The scenario test removal (T011) eliminates the known failing test from the earlier session
- Commit after each task or logical group
