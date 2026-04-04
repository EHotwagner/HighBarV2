# Tasks: AI Validation and Competitive Testing

**Input**: Design documents from `/specs/015-ai-validation-tests/`
**Prerequisites**: plan.md (required), spec.md (required), research.md, data-model.md, contracts/

**Tests**: Test tasks are included as this feature IS a test suite — all user stories produce xUnit tests.

**Organization**: Tasks are grouped by user story to enable independent implementation and testing of each story.

## Format: `[ID] [P?] [Story] Description`

- **[P]**: Can run in parallel (different files, no dependencies)
- **[Story]**: Which user story this task belongs to (e.g., US1, US2, US3)
- Include exact file paths in descriptions

---

## Phase 1: Setup (Shared Infrastructure)

**Purpose**: Project initialization, game setup fixtures, and shared types

- [X] T001 Update project file to include all new source files in compilation order in `tests/ai/fsharp/HighBar.AI.Tests.fsproj` — add `<Compile Include>` entries for: `AiTestTypes.fs`, `AiTestHarness.fs`, `ValidationReport.fs`, `EndToEndTests.fs`, `CompetitiveTests.fs`, `NonCombatTests.fs`, `CombatTests.fs`. Also add `<ProjectReference>` to `tools/game-runner/GameRunner.fsproj` for reusing the `GameOutcome` base type and report generation
- [X] T002 [P] Create `game-setup-e2e.txt` in `tests/fixtures/game-setup-e2e.txt` — copy from `tests/fixtures/game-setup.txt`, keep `deathmode=neverend;` (headless engine cannot simulate weapon physics, so games cannot end via combat — the harness uses a frame timeout instead). Keep all other settings (FixedRNGSeed=1, MinSpeed=100, MaxSpeed=100, AI0=HighBarV2, AI1=NullAI, globallos, cheat)
- [X] T003 [P] Create `game-setup-barb.txt` in `tests/fixtures/game-setup-barb.txt` — copy from `tests/fixtures/game-setup.txt`, change `[AI1]` section to `Name=BARbarianAI; ShortName=BARb; Version=<default>;`, remove `deathmode=neverend;` line, keep all other settings
- [X] T004 [P] Create reports output directory structure: add `.gitkeep` to `tests/ai/fsharp/reports/.gitkeep` so the reports directory exists in version control but generated reports are gitignored. Add `tests/ai/fsharp/reports/*.md` to `.gitignore` if not already present

---

## Phase 2: Foundational (Blocking Prerequisites)

**Purpose**: Core types, multi-game harness, and report generation that ALL user stories depend on

**⚠️ CRITICAL**: No user story work can begin until this phase is complete

- [X] T005 Add xUnit collection definitions in `tests/ai/fsharp/AiTestHarness.fs` — define `[<CollectionDefinition("AIEndToEnd")>]`, `[<CollectionDefinition("AINonCombat")>]`, `[<CollectionDefinition("AICompetitive")>]`, `[<CollectionDefinition("AICombat")>]` types associated with their respective fixtures (`HeadlessAiFixture` for EndToEnd/NonCombat, `LiveAiFixture` for Competitive/Combat) to ensure xUnit shares fixture instances within collections and runs collections sequentially. These MUST exist before any test class references them
- [X] T006 Implement `GameResult` discriminated union and extended `GameOutcome` record in `tests/ai/fsharp/AiTestTypes.fs` — define `GameResult` (Win | Loss | Crash | Stall | Timeout), `GameOutcome` record with all fields from data-model.md (GameNumber, Result, DurationFrames, DurationMinutes, UnitsProduced, UnitsLost, EnemyUnitsDestroyed, MexBuiltCount, MexFirstBuiltFrame, EnergyBuiltCount, EnergyFirstBuiltFrame, FactoryBuiltCount, FactoryFirstBuiltFrame, FirstCombatUnitFrame, CrashMessage, WeaponFiredCount, UnitDamagedCount, EnemyDamagedCount, UnitDestroyedCount, EnemyDestroyedCount), `ValidationCriterion` record (Id, Description, Evaluate function), `ValidationReport` record (SuiteName, RunDate, TotalGames, Outcomes, Criteria with pass/fail, OverallPass), `TestAssertion` record, `TestCategory` DU, and `TestSuiteReport` record per data-model.md
- [X] T007 Implement headless multi-game orchestration in `tests/ai/fsharp/AiTestHarness.fs` — create `HeadlessAiFixture` class where `InitializeAsync`/`DisposeAsync` handle one-time setup (prerequisite checks, report directory creation) and `RunGames` manages per-game engine lifecycle: (1) for each game, creates a listening socket, (2) launches `start-headless.sh` with a game-setup template path parameter, (3) accepts proxy connection, (4) creates `HighBarClient`, (5) initializes `GameState` via `GameState.init`, (6) runs frames using `GameState.createFrameHandler` as the onFrame callback, (7) tracks game events to build `GameOutcome` (count UnitCreated/UnitFinished/UnitDestroyed/WeaponFired/UnitDamaged/EnemyDamaged/EnemyDestroyed events, detect mex/energy/factory milestones by matching unitDefId from `UnitRegistry` classification), (8) detects game end via `Shutdown(GAME_OVER)` message or frame timeout (configurable, default 18000 frames for headless), (9) detects stalls (zero commands for 1800 consecutive frames), (10) detects crashes (socket error), (11) cleans up engine process. `RunGames(n: int, setupFile: string, ?maxFrames: int) -> GameOutcome list` launches N sequential games, each with fresh engine + fresh GameState. Reference existing patterns from `tests/persistent/fsharp/PersistentHarness.fs` for engine lifecycle and `tests/integration/fsharp/Harness.fs` for socket setup
- [X] T008 Implement live engine multi-game orchestration in `tests/ai/fsharp/AiTestHarness.fs` — add `LiveAiFixture` class (same file as T007) that extends the headless pattern but: (1) validates `DISPLAY` environment variable is set (fail fast with descriptive error if missing), (2) uses `start-live.sh` instead of `start-headless.sh`, (3) uses `game-setup-live.txt` or `game-setup-barb.txt` as template, (4) longer default frame timeout for live games (108000 frames = 60 min). Share common game-running logic with `HeadlessAiFixture` via a private module or base helper
- [X] T009 Implement markdown report generation in `tests/ai/fsharp/ValidationReport.fs` — create `generateValidationReport(report: ValidationReport) -> string` that produces markdown with: (1) header with suite name, date, game count, overall PASS/FAIL, (2) success criteria table (ID, criterion, result, details), (3) per-game results table (game number, result, duration, units produced/lost, enemy destroyed), (4) aggregate statistics (win rate, avg duration, completion rate). Also create `generateTestSuiteReport(report: TestSuiteReport) -> string` for non-combat/combat suite reports with: results by category table, failed assertions detail table, overall pass rate. Write reports to `tests/ai/fsharp/reports/` with timestamped filenames

**Checkpoint**: Foundation ready — multi-game orchestration, outcome tracking, and report generation are functional. User story implementation can begin.

---

## Phase 3: User Story 1 — End-to-End Game Validation Against NullAI (Priority: P1) 🎯 MVP

**Goal**: Run 10 consecutive AI-vs-NullAI games using headless engine, verify crash-free operation, economy bootstrap, army production, and combat readiness (headless cannot produce actual wins — see C1 remediation).

**Independent Test**: `dotnet test tests/ai/fsharp/ --filter "Category=EndToEnd"` — all 10 games complete, report shows pass/fail per criterion.

### Implementation for User Story 1

- [X] T010 [US1] Define success criteria functions in `tests/ai/fsharp/EndToEndTests.fs` — implement `ValidationCriterion` instances for: SC-001 (100% completion rate — no crashes/stalls, games run to frame timeout without errors), SC-002 (90%+ games have ≥3 mex and ≥2 energy within 5400 frames = 3 min), SC-003 (90%+ games produce combat units from factory within 9000 frames = 5 min), SC-004 (100% combat readiness — all games have FirstCombatUnitFrame.IsSome, meaning army was produced from factory; headless cannot simulate actual wins). Each criterion's `Evaluate` function takes `GameOutcome list` and returns bool
- [X] T011 [US1] Implement end-to-end validation test class in `tests/ai/fsharp/EndToEndTests.fs` — create `EndToEndValidationTests` class with `[<Collection("AIEndToEnd")>]` attribute, inject `HeadlessAiFixture`. Single test method `[<Fact>] [<Trait("Category", "EndToEnd")>]` that: (1) calls `fixture.RunGames(10, "game-setup-e2e.txt", maxFrames=18000)` (10 min at 30fps — sufficient for economy + army milestones), (2) evaluates all 4 success criteria against outcomes (note: games end via Timeout since headless has no combat — SC-001 checks for no Crash/Stall, not Win), (3) generates `ValidationReport`, (4) writes markdown report via `generateValidationReport`, (5) asserts `report.OverallPass` is true. On failure, the report contains per-game details for debugging
- [X] T012 [US1] Smoke-test the end-to-end suite with a single game — add `[<Fact>] [<Trait("Category", "EndToEnd")>]` method `SingleGameSmokeTest` that runs 1 game against NullAI, verifies game completes without crash, and produces a valid `GameOutcome` with `Result = Timeout` (expected in headless — no combat means no natural ending). This catches harness bugs before running the full 10-game suite

**Checkpoint**: End-to-end validation suite runs 10 games against NullAI, produces a markdown report, and verifies SC-001 through SC-004.

---

## Phase 4: User Story 3 — Headless Non-Combat Test Suite (Priority: P1)

**Goal**: Validate economy management, build orders, unit movement, and scouting across 20 headless game runs with 95%+ pass rate.

**Independent Test**: `dotnet test tests/ai/fsharp/ --filter "Category=NonCombat"` — 95%+ of all assertions pass.

### Implementation for User Story 3

- [X] T013 [US3] Implement economy test assertions in `tests/ai/fsharp/NonCombatTests.fs` — define assertion functions that check per-game: (1) `economy_positive_income_2min` — AI has positive metal income by frame 3600 (verify via MexBuiltCount ≥ 1 by that frame), (2) `economy_extractors_built` — AI builds ≥3 metal extractors within 5400 frames, (3) `economy_energy_built` — AI builds ≥2 energy structures within 5400 frames. Each returns a `TestAssertion` record
- [X] T014 [US3] Implement build order test assertions in `tests/ai/fsharp/NonCombatTests.fs` — define assertions: (1) `build_order_mex_first` — first structure built is a mex (MexFirstBuiltFrame < EnergyFirstBuiltFrame < FactoryFirstBuiltFrame when all are Some), (2) `build_order_factory_within_5min` — factory completed within 9000 frames, (3) `build_order_sequence_complete` — mex, energy, and factory all built (all milestone frames are Some)
- [X] T015 [US3] Implement movement and scouting test assertions in `tests/ai/fsharp/NonCombatTests.fs` — define assertions: (1) `movement_units_produced` — AI produces at least 1 mobile unit (UnitsProduced > initial commander count), (2) `scouting_activity` — AI issues commands beyond its start position (observable via non-zero EnemyUnitsDestroyed or game duration indicating exploration happened). Note: precise position tracking requires extending outcome collection — keep assertions achievable with current GameOutcome fields
- [X] T016 [US3] Implement non-combat test suite runner in `tests/ai/fsharp/NonCombatTests.fs` — create `NonCombatSuiteTests` class with `[<Collection("AINonCombat")>]`, inject `HeadlessAiFixture`. Main test `[<Fact>] [<Trait("Category", "NonCombat")>]` that: (1) runs 20 games via `fixture.RunGames(20, "game-setup-e2e.txt", maxFrames=9000)` (5 min per game — sufficient for economy/build milestones; uses deathmode=neverend with fixed frame limit per research R2), (2) evaluates all assertions from T013-T015 against each game's outcome, (3) collects `TestAssertion` list, (4) builds `TestSuiteReport` with 95% threshold, (5) writes report via `generateTestSuiteReport`, (6) asserts `report.OverallPass`

**Checkpoint**: Non-combat suite validates economy, build order, movement, and scouting across 20 runs with 95%+ pass rate.

---

## Phase 5: User Story 2 — Competitive Validation Against BARbarianAI (Priority: P2)

**Goal**: Run 10 games against BARb using live graphical engine via Xvfb, measure survival time, verify 80%+ survive 15+ minutes.

**Independent Test**: `dotnet test tests/ai/fsharp/ --filter "Category=Competitive"` — report shows survival time per game, overall pass/fail.

### Implementation for User Story 2

- [X] T017 [US2] Define competitive success criteria in `tests/ai/fsharp/CompetitiveTests.fs` — implement `ValidationCriterion` instances for: SC-005 (80%+ games survive ≥15 min — `DurationMinutes >= 15.0` in at least 8 of 10 games, counting Win, Loss, and Timeout results but not Crash/Stall), plus infrastructure criterion (100% games launch without infrastructure failures — no Crash results)
- [X] T018 [US2] Implement competitive validation test class in `tests/ai/fsharp/CompetitiveTests.fs` — create `CompetitiveValidationTests` class with `[<Collection("AICompetitive")>]`, inject `LiveAiFixture`. Prerequisite check: skip test with `Skip` message if `DISPLAY` env var is not set or if BARb is not installed. Main test `[<Fact>] [<Trait("Category", "Competitive")>]` that: (1) calls `fixture.RunGames(10, "game-setup-barb.txt")`, (2) evaluates competitive criteria, (3) generates report with per-game survival time, win/loss, units produced/lost, (4) asserts overall pass
- [X] T019 [US2] Add single-game competitive smoke test in `tests/ai/fsharp/CompetitiveTests.fs` — `[<Fact>] [<Trait("Category", "Competitive")>]` method `SingleGameCompetitiveSmokeTest` that runs 1 game vs BARb, verifies game launches and runs without infrastructure crash (engine starts, proxy connects, frames flow). Does not assert win — just validates the harness works with the live engine and BARb opponent

**Checkpoint**: Competitive suite runs 10 games against BARb via live engine, measures survival time, reports SC-005.

---

## Phase 6: User Story 4 — Live Combat Test Suite (Priority: P2)

**Goal**: Validate combat events (WeaponFired, UnitDamaged, UnitDestroyed) using live graphical engine via Xvfb across 10 games with 90%+ pass rate.

**Independent Test**: `dotnet test tests/ai/fsharp/ --filter "Category=Combat"` — 90%+ of combat assertions pass.

### Implementation for User Story 4

- [X] T020 [US4] Implement combat event test assertions in `tests/ai/fsharp/CombatTests.fs` — define assertion functions that check per-game: (1) `combat_units_destroyed` — EnemyDestroyedCount > 0 (AI engages and destroys enemies), (2) `combat_units_lost_nonzero` — UnitDestroyedCount > 0 OR EnemyDestroyedCount > 0 (combat occurred — at least one side took casualties), (3) `combat_game_completed` — Result is Win or Loss (game ran to natural completion with combat). Combat event counters (WeaponFiredCount, UnitDamagedCount, etc.) are already included in `GameOutcome` from T006
- [X] T021 [US4] Implement combat-specific assertions using event counters in `tests/ai/fsharp/CombatTests.fs` — add assertions: (1) `combat_weapon_fired` — WeaponFiredCount > 0 (weapons are firing in the live engine), (2) `combat_damage_events` — UnitDamagedCount > 0 OR EnemyDamagedCount > 0 (damage is being applied), (3) `combat_military_engagement` — AI issues attack commands and engages (EnemyDestroyedCount > 0 within the game). These assertions validate that the live engine correctly delivers combat events that headless cannot
- [X] T022 [US4] Implement combat test suite runner in `tests/ai/fsharp/CombatTests.fs` — create `CombatSuiteTests` class with `[<Collection("AICombat")>]`, inject `LiveAiFixture`. Skip if DISPLAY not set. Main test `[<Fact>] [<Trait("Category", "Combat")>]` that: (1) runs 10 games via `fixture.RunGames(10, "game-setup-barb.txt")` (use BARb as opponent to ensure combat occurs), (2) evaluates all combat assertions from T020/T021 per game, (3) builds `TestSuiteReport` with 90% threshold, (4) writes report, (5) asserts `report.OverallPass`

**Checkpoint**: Combat suite validates weapon fire, damage, and destruction events across 10 live games with 90%+ pass rate.

---

## Phase 7: Polish & Cross-Cutting Concerns

**Purpose**: Improvements that affect multiple user stories

- [X] T023 Verify all test suites build and discover correctly — run `dotnet build tests/ai/fsharp/` and `dotnet test tests/ai/fsharp/ --list-tests` to confirm all test methods are discovered with correct Category traits. Fix any compilation errors or missing references
- [X] T024 Run quickstart.md validation — execute the commands from `specs/015-ai-validation-tests/quickstart.md`: build the test project, run the EndToEnd suite (headless), verify reports are generated. If live engine + Xvfb available, also run Competitive and Combat suites. Document any deviations from expected behavior

---

## Dependencies & Execution Order

### Phase Dependencies

- **Setup (Phase 1)**: No dependencies — can start immediately
- **Foundational (Phase 2)**: Depends on T001 (project file setup) — BLOCKS all user stories
- **US1 (Phase 3)**: Depends on Phase 2 (T005-T009) — collection defs, types, harness, reports
- **US3 (Phase 4)**: Depends on Phase 2 (T005-T009) — shares headless fixture with US1
- **US2 (Phase 5)**: Depends on Phase 2 (T005-T009) — live fixture
- **US4 (Phase 6)**: Depends on Phase 2 (T005-T009) — combat event counters already in T006
- **Polish (Phase 7)**: Depends on all user story phases

### User Story Dependencies

- **US1 (P1)**: Can start after Phase 2 — no dependencies on other stories
- **US3 (P1)**: Can start after Phase 2 — no dependencies on other stories (can run in parallel with US1)
- **US2 (P2)**: Can start after Phase 2 — no dependencies on other stories (requires live engine + Xvfb)
- **US4 (P2)**: Can start after Phase 2 — combat event counters are already defined in T006 (GameOutcome includes all fields from the start)

### Within Each User Story

- Success criteria / assertion definitions before test runner
- Test runner integrates criteria into xUnit test methods
- Report generation validates output format

### Parallel Opportunities

- T002, T003, T004 can all run in parallel (different fixture files)
- US1 (Phase 3) and US3 (Phase 4) can run in parallel (both use headless fixture, different test files)
- US2 (Phase 5) and US4 (Phase 6) can run in parallel (both use live fixture, different test files)
- Within each user story, assertion definition tasks are independent of each other

---

## Parallel Example: Phase 1 Setup

```bash
# All setup tasks can run in parallel:
Task: "Create game-setup-e2e.txt in tests/fixtures/game-setup-e2e.txt"
Task: "Create game-setup-barb.txt in tests/fixtures/game-setup-barb.txt"
Task: "Create reports directory with .gitkeep in tests/ai/fsharp/reports/"
```

## Parallel Example: User Stories 1 + 3

```bash
# After Phase 2 completes, both P1 stories can start simultaneously:
# Agent A works on US1:
Task: "T010 [US1] Define success criteria functions in EndToEndTests.fs"
Task: "T011 [US1] Implement end-to-end validation test class"

# Agent B works on US3 (in parallel):
Task: "T013 [US3] Implement economy test assertions in NonCombatTests.fs"
Task: "T014 [US3] Implement build order test assertions"
```

---

## Implementation Strategy

### MVP First (User Story 1 Only)

1. Complete Phase 1: Setup (T001-T004)
2. Complete Phase 2: Foundational (T005-T009) — CRITICAL blocker
3. Complete Phase 3: User Story 1 (T010-T012)
4. **STOP and VALIDATE**: Run `dotnet test tests/ai/fsharp/ --filter "Category=EndToEnd"` — verify 10 games complete, report generated
5. If passing: MVP is done — AI is validated crash-free with basic competency

### Incremental Delivery

1. Setup + Foundational → Foundation ready
2. Add US1 (end-to-end) → Test independently → **MVP!** (AI runs crash-free, meets competency milestones)
3. Add US3 (non-combat) → Test independently → Economy/build/movement validated
4. Add US2 (competitive) → Test independently → BARb benchmarking available
5. Add US4 (combat) → Test independently → Full combat event validation
6. Polish → All suites verified, reports clean

### Parallel Team Strategy

With multiple developers:

1. Team completes Setup + Foundational together
2. Once Foundational is done:
   - Developer A: US1 (end-to-end) + US3 (non-combat) — both headless
   - Developer B: US2 (competitive) + US4 (combat) — both live engine
3. Stories complete and integrate independently

---

## Notes

- [P] tasks = different files, no dependencies
- [Story] label maps task to specific user story for traceability
- Each user story is independently completable and testable via `--filter "Category=..."`
- Headless suites (US1, US3) are fast (~3-6 min) — run these first for quick feedback
- Live suites (US2, US4) require Xvfb — these are slower and have infrastructure dependencies
- Commit after each task or logical group
- Stop at any checkpoint to validate story independently
