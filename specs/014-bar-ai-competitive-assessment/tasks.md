# Tasks: BAR AI Competitive Assessment

**Input**: Design documents from `/specs/014-bar-ai-competitive-assessment/`
**Prerequisites**: plan.md (required), spec.md (required for user stories), research.md, data-model.md

**Tests**: Not explicitly requested. Test tasks omitted. Tests can be added later via the existing test infrastructure (headless for non-combat, Xvfb+live for combat).

**Organization**: Tasks are grouped by user story to enable independent implementation and testing of each story. US1 (Competitive AI Game Loop) is the capstone integration story that depends on US2-US6 capabilities.

## Format: `[ID] [P?] [Story] Description`

- **[P]**: Can run in parallel (different files, no dependencies)
- **[Story]**: Which user story this task belongs to (e.g., US1, US2, US3)
- Include exact file paths in descriptions

---

## Phase 1: Setup (Shared Infrastructure)

**Purpose**: Create project structure for AI modules and game runner tool

- [X] T001 Create Managers/ subdirectory and module structure in clients/fsharp/src/Managers/
- [X] T002 Create Tasks/ subdirectory and module structure in clients/fsharp/src/Tasks/
- [X] T003 Create Strategy/ subdirectory and module structure in clients/fsharp/src/Strategy/
- [X] T004 Create Logging/ subdirectory in clients/fsharp/src/Logging/
- [X] T005 Create game runner project scaffold in tools/game-runner/ with GameRunner.fsproj and Program.fs
- [X] T006 Create AI test project scaffold in tests/ai/fsharp/ with HighBar.AI.Tests.fsproj referencing HighBar.Client and BarData
- [X] T007 Update clients/fsharp/HighBar.Client.fsproj to include new source files and subdirectories in compilation order

---

## Phase 2: Foundational (Blocking Prerequisites)

**Purpose**: Core infrastructure that MUST be complete before ANY user story can be implemented. Includes DefId discovery (from Feature 013 gap), game state model, manager framework, and decision logging.

**CRITICAL**: No user story work can begin until this phase is complete

- [X] T008 Implement runtime DefId discovery by querying engine GetUnitDefs callback at init, mapping engine DefIds to unit names and properties in clients/fsharp/src/UnitRegistry.fs
- [X] T009 Implement UnitClass classification logic (Commander, Builder, Factory, MobileArmed, StaticDefense, Scout, Economy, Radar) based on unit definition properties in clients/fsharp/src/UnitRegistry.fs
- [X] T010 [P] Implement GameState root model with frameNumber, teamId, allyTeamId, phase tracking, and references to sub-models in clients/fsharp/src/GameState.fs
- [X] T011 [P] Implement GamePhase discriminated union (Opening, Expansion, MidGame, LateGame) with milestone-based transition logic in clients/fsharp/src/Strategy/StrategyController.fs
- [X] T012 [P] Implement UnitRecord type with unitId, defId, team, position, health, isAlive, lastSeenFrame, classification, and lifecycle state machine (Alive, Ready, Dead, LastKnown, Forgotten) in clients/fsharp/src/UnitRegistry.fs
- [X] T013 [P] Implement UnitTask discriminated union (Idle, BuildMex, BuildEnergy, BuildFactory, BuildStructure, Produce, Scout, Attack, Defend, Retreat, Guard, Reclaim, Repair) in clients/fsharp/src/Tasks/UnitTask.fs
- [X] T014 [P] Implement DecisionLog module with JSON lines writer for structured decision entries (frame, manager, type, unitId, details, context) in clients/fsharp/src/Logging/DecisionLog.fs
- [X] T015 Implement base Manager interface/pattern with per-frame evaluate method that reads GameState and returns command proposals as a shared type in clients/fsharp/src/Managers/ManagerBase.fs
- [X] T016 Implement TaskAssigner module that assigns/reassigns UnitTask to friendly units based on manager proposals, ensuring each unit has exactly one task in clients/fsharp/src/Tasks/TaskAssigner.fs
- [X] T017 Implement GameState event processing for all 28 engine event types — handle UnitCreated, UnitFinished, UnitIdle, UnitMoveFailed, UnitDamaged, UnitDestroyed, UnitGiven, UnitCaptured, EnemyCreated, EnemyFinished, EnemyEnterLOS, EnemyLeaveLOS, EnemyEnterRadar, EnemyLeaveRadar, EnemyDamaged, EnemyDestroyed, WeaponFired, CommandFinished, PlayerCommand, SeismicPing, LuaMessage; log-and-skip Init, Release, Update, Message, Load, Save in clients/fsharp/src/GameState.fs
- [X] T018 Implement main AI frame loop that wires GameState update, manager evaluations, task assignment, command generation, and decision logging into the HighBarClient.Run callback in clients/fsharp/src/GameState.fs
- [X] T019 Create live engine test fixture that launches spring binary with Xvfb for combat testing, sharing config with existing headless fixture in tests/fixtures/start-live.sh
- [X] T020 Create live engine game setup config with standard modoptions (cheat, globallos, deathmode=neverend, FixedRNGSeed=1) for deterministic live tests in tests/fixtures/game-setup-live.txt
- [X] T020a Investigate and document large spawn instability — identify which DefIds cause engine crashes at high unit counts, build a safe-spawn exclusion list for stress testing in clients/fsharp/src/UnitRegistry.fs

**Checkpoint**: Foundation ready — GameState model, UnitRegistry with runtime DefId discovery, manager framework, task system, decision logging, and live test fixture all operational. User story implementation can now begin.

---

## Phase 3: User Story 2 — Economy Management (Priority: P1)

**Goal**: The AI efficiently manages its metal and energy economy — identifying metal spots, building extractors and energy, monitoring income/expenditure, and expanding to new resource locations.

**Independent Test**: Launch a headless game, observe the AI builds on metal spots within 2 minutes, maintains positive income, and expands when nearby spots are claimed.

### Implementation for User Story 2

- [X] T021 [US2] Implement EconomyModel with metal/energy current, income, usage, storage, stall detection, and surplus calculation in clients/fsharp/src/EconomyModel.fs
- [X] T022 [US2] Implement EconomyModel update logic querying Economy callbacks (GetCurrent, GetIncome, GetUsage, GetStorage) per frame in clients/fsharp/src/EconomyModel.fs
- [X] T023 [US2] Implement MapModel with map dimensions, metal spot locations (via GetMetalSpots callback), and start positions in clients/fsharp/src/Strategy/MapAnalysis.fs
- [X] T024 [US2] Implement metal spot ranking by distance from start position and strategic value in clients/fsharp/src/Strategy/MapAnalysis.fs
- [X] T025 [US2] Implement EconomyManager that monitors resource state and sets build priorities (metal extractors when metal-stalled, energy when energy-stalled, balanced when healthy) in clients/fsharp/src/Managers/EconomyManager.fs
- [X] T026 [US2] Implement EconomyManager expansion logic — detect when nearby metal spots are occupied and prioritize claiming distant spots via new builders in clients/fsharp/src/Managers/EconomyManager.fs
- [X] T027 [US2] Wire EconomyModel updates into GameState frame processing and connect EconomyManager output to TaskAssigner for builder task assignment in clients/fsharp/src/GameState.fs

**Checkpoint**: AI identifies metal spots, builds extractors in priority order, builds energy when needed, detects stalls, and expands. Testable independently in headless mode.

---

## Phase 4: User Story 3 — Build Order and Base Layout (Priority: P1)

**Goal**: The AI follows sensible build orders and places structures in valid, functional locations with proper sequencing (metal before factories).

**Independent Test**: Launch a headless game, observe the first 5 minutes — commander builds mex on nearest spots, then energy, then factory, with no overlapping structures.

### Implementation for User Story 3

- [X] T028 [US3] Implement Armada opening build order sequence (commander: 2-3 mex → energy → factory → more mex) as a configurable data structure in clients/fsharp/src/Strategy/BuildOrder.fs
- [X] T029 [US3] Implement BuildManager that reads current build order step, checks economy readiness, and proposes build commands for idle builders in clients/fsharp/src/Managers/BuildManager.fs
- [X] T030 [US3] Implement structure placement logic — query unit footprints from UnitDef callbacks, check for terrain validity, avoid overlaps with existing structures, preserve pathing corridors in clients/fsharp/src/Managers/BuildManager.fs
- [X] T031 [US3] Implement build command generation — translate BuildMex/BuildEnergy/BuildFactory/BuildStructure tasks into engine Build commands with valid positions and facing in clients/fsharp/src/Managers/BuildManager.fs
- [X] T032 [US3] Handle build completion and failure — process UnitFinished events to advance build order, process UnitMoveFailed to retry placement, reassign idle builders in clients/fsharp/src/Managers/BuildManager.fs
- [X] T033 [US3] Wire BuildManager into GameState frame loop and connect to TaskAssigner for builder unit task assignment in clients/fsharp/src/GameState.fs

**Checkpoint**: AI follows Armada opening build order, places structures at valid positions, handles build completion, and retries on failure. Testable independently in headless mode.

---

## Phase 5: User Story 4 — Unit Production and Army Composition (Priority: P2)

**Goal**: The AI produces a balanced army from factories, keeping factories busy and selecting appropriate unit types.

**Independent Test**: Launch a headless game, observe that factories continuously produce units after being built, with a mix of unit types (not exclusively one type).

### Implementation for User Story 4

- [X] T034 [P] [US4] Implement ProductionManager that tracks all friendly factories, their build options, and current production state in clients/fsharp/src/Managers/ProductionManager.fs
- [X] T035 [US4] Implement unit type selection logic — classify available build options by role (assault, raider, scout, anti-air, builder) using UnitDef properties (speed, cost, damage, range) in clients/fsharp/src/Managers/ProductionManager.fs
- [X] T036 [US4] Implement production ratio system — configurable ratios (e.g., 60% combat, 20% scouts, 20% builders) that adjust based on game phase and economy state in clients/fsharp/src/Managers/ProductionManager.fs
- [X] T037 [US4] Implement idle factory detection and automatic queue replenishment — detect factory UnitIdle events, assign next unit to produce based on current ratios in clients/fsharp/src/Managers/ProductionManager.fs
- [X] T038 [US4] Wire ProductionManager into GameState frame loop and connect factory Produce tasks to engine Build commands in clients/fsharp/src/GameState.fs

**Checkpoint**: Factories continuously produce units with a balanced mix of types. Production adjusts based on game phase. Testable independently in headless mode.

---

## Phase 6: User Story 5 — Scouting and Map Awareness (Priority: P2)

**Goal**: The AI actively scouts the map, discovers enemy positions, maintains situational awareness via a threat model.

**Independent Test**: Launch a headless game with globallos, observe the AI sends scout units to enemy start positions and updates tracking when enemies are detected.

### Implementation for User Story 5

- [X] T039 [P] [US5] Implement ThreatMap with grid-based spatial model (configurable cell size), threat cells tracking ground/air DPS, and time-based decay in clients/fsharp/src/ThreatMap.fs
- [X] T040 [P] [US5] Implement ScoutManager that identifies unexplored map regions and assigns scout tasks to fast, cheap mobile units in clients/fsharp/src/Managers/ScoutManager.fs
- [X] T041 [US5] Implement enemy tracking — process EnemyEnterLOS, EnemyLeaveLOS, EnemyEnterRadar, EnemyLeaveRadar events to maintain enemy unit records with last-known positions in clients/fsharp/src/UnitRegistry.fs
- [X] T042 [US5] Implement ThreatMap update from enemy observations — query enemy unit DPS/range when in LOS, update threat cells, apply decay when out of sight in clients/fsharp/src/ThreatMap.fs
- [X] T043 [US5] Implement ScoutManager patrol logic — after initial scout of enemy start positions, maintain periodic scouting of key map areas (metal spot clusters, chokepoints) in clients/fsharp/src/Managers/ScoutManager.fs
- [X] T044 [US5] Wire ScoutManager and ThreatMap into GameState frame loop and connect scout tasks to engine Move/Patrol commands in clients/fsharp/src/GameState.fs

**Checkpoint**: AI sends scouts to explore, tracks enemy units via LOS/radar events, maintains spatial threat model with decay. Testable in headless mode (LOS events work with globallos cheat).

---

## Phase 7: User Story 7 — Full Game Testing with Combat Validation (Priority: P3)

**Goal**: Establish live engine testing infrastructure that validates combat events (WeaponFired, UnitDamaged, UnitDestroyed) are delivered, enabling combat AI development.

**Independent Test**: Launch a live engine with Xvfb, place two opposing units, verify combat events are received by the AI client.

**Note**: This is placed before US6 (Combat) because combat AI development requires a working live test environment.

### Implementation for User Story 7

- [X] T045 [US7] Implement live engine test harness in tests/ai/fsharp/ that uses start-live.sh with Xvfb to launch graphical spring binary and verify combat events are delivered
- [X] T046 [US7] Create combat event verification test — spawn two opposing units at close range in live engine, assert WeaponFired, UnitDamaged, UnitDestroyed events arrive within expected frame window in tests/ai/fsharp/CombatTests.fs
- [X] T047 [US7] Implement GameRunner module that launches AI-vs-AI games (HighBarV2 vs BARb), manages engine lifecycle, and collects game outcomes (win/loss, duration, units produced) in tools/game-runner/GameRunner.fs
- [X] T048 [US7] Implement GameRunner CLI with commands: run single game, run N games with summary report, configurable map and opponent in tools/game-runner/Program.fs
- [X] T049 [US7] Create game outcome report format — markdown report with per-game results, aggregate win rate, economy metrics, and combat efficiency in tools/game-runner/GameRunner.fs

**Checkpoint**: Live engine fixture delivers combat events. GameRunner can launch and report on AI-vs-AI games. Combat AI development is unblocked.

---

## Phase 8: User Story 6 — Combat Micro and Tactics (Priority: P2)

**Goal**: The AI coordinates its army in combat — grouping units into squads, engaging enemies at known positions, focus firing, and retreating damaged units.

**Independent Test**: In a live engine game, observe the AI forms squads, attacks enemy positions discovered by scouting, and retreats critically damaged units.

**Depends on**: US5 (Scouting/ThreatMap), US7 (Live test harness)

### Implementation for User Story 6

- [X] T050 [US6] Implement MilitaryManager core — track all friendly combat units, detect idle armed units, maintain army groups/squads by proximity and unit type in clients/fsharp/src/Managers/MilitaryManager.fs
- [X] T051 [US6] Implement army grouping logic — cluster idle combat units into squads when group size reaches threshold, prefer homogeneous squads (assault, raider, anti-air) in clients/fsharp/src/Managers/MilitaryManager.fs
- [X] T052 [US6] Implement attack decision logic — evaluate ThreatMap for low-threat enemy positions, compare own army strength vs estimated enemy strength, decide when to attack in clients/fsharp/src/Managers/MilitaryManager.fs
- [X] T053 [US6] Implement attack execution — issue coordinated Fight commands to squad units targeting selected enemy position, keep squads together via rally points in clients/fsharp/src/Managers/MilitaryManager.fs
- [X] T054 [US6] Implement retreat logic — process UnitDamaged events, when unit health drops below threshold (e.g., 30%), issue Move command to retreat toward base/safe position in clients/fsharp/src/Managers/MilitaryManager.fs
- [X] T055 [US6] Implement defense response — detect enemy units near base (ThreatMap cells near start position above threshold), pull nearby combat units to defend in clients/fsharp/src/Managers/MilitaryManager.fs
- [X] T056 [US6] Wire MilitaryManager into GameState frame loop, connect Attack/Defend/Retreat tasks to engine Fight/Move/Guard commands in clients/fsharp/src/GameState.fs
- [X] T056a [US6] Implement WeaponFired event handling for manual-fire weapons (D-Gun, nukes) — detect WeaponFired events, track cooldowns, and issue DGunCommand/DGunPosCommand when high-value targets are in range in clients/fsharp/src/Managers/MilitaryManager.fs

**Checkpoint**: AI forms squads, makes attack decisions based on threat assessment, executes coordinated attacks, retreats damaged units, and defends base. Must be validated in live engine mode.

---

## Phase 9: User Story 1 — Competitive AI Game Loop (Priority: P1) — Integration

**Goal**: All managers work together seamlessly — the AI plays a complete game from start to finish (economy bootstrap → base building → army production → scouting → combat) without crashing or stalling.

**Independent Test**: Run 10 consecutive AI-vs-do-nothing-AI games via GameRunner. All 10 complete without crashes. AI builds mex within 60s, factories within 5min, engages combat when enemies are known.

**Depends on**: US2, US3, US4, US5, US6, US7

### Implementation for User Story 1

- [X] T057 [US1] Implement StrategyController milestone evaluation — detect phase transitions (Opening→Expansion: first factory built; Expansion→MidGame: 2+ factories AND army value threshold; MidGame→LateGame: T2 factory OR high army value) in clients/fsharp/src/Strategy/StrategyController.fs
- [X] T058 [US1] Implement manager priority weighting by game phase — Opening: 80% economy/20% scout; Expansion: 50% economy/30% production/20% scout; MidGame: 30% economy/40% military/30% production; LateGame: 20% economy/50% military/30% production in clients/fsharp/src/Strategy/StrategyController.fs
- [X] T059 [US1] Implement command conflict resolution — when multiple managers propose commands for the same unit, resolve by priority (defense > current task > new assignment) in clients/fsharp/src/Tasks/TaskAssigner.fs
- [X] T060 [US1] Implement frame timeout safety — monitor per-frame processing time, skip non-critical manager evaluations if approaching 25ms budget, log warning when budget exceeded in clients/fsharp/src/GameState.fs
- [X] T061 [US1] Implement graceful error handling — catch exceptions from any manager, log error, continue with remaining managers rather than crashing the AI in clients/fsharp/src/GameState.fs
- [X] T062 [US1] Implement commander death handling — if commander is destroyed, continue playing with remaining units and factories (do not stop issuing commands) in clients/fsharp/src/GameState.fs
- [ ] T063 [US1] Run end-to-end validation: 10 consecutive games via GameRunner against do-nothing AI, verify all complete without crashes, AI achieves SC-001 through SC-007 success criteria
- [ ] T064 [US1] Run competitive validation: 10 games via GameRunner against BARbarianAI, measure survival time, verify SC-008 (survives 15 min in 80% of games)

**Checkpoint**: AI plays complete games autonomously. All managers cooperate without conflicts. Meets success criteria SC-001 through SC-008.

---

## Phase 10: Polish & Cross-Cutting Concerns

**Purpose**: Improvements that affect multiple user stories

- [X] T065 [P] Tune Armada build order timings based on game outcome data from competitive validation runs in clients/fsharp/src/Strategy/BuildOrder.fs
- [X] T066 [P] Tune production ratios and attack timing thresholds based on game outcome data in clients/fsharp/src/Managers/ProductionManager.fs and clients/fsharp/src/Managers/MilitaryManager.fs
- [X] T067 [P] Add economy model extensibility points for future overdrive support (energy surplus tracking, pylon connectivity placeholder) in clients/fsharp/src/EconomyModel.fs
- [X] T068 Code review all manager modules for latency — profile per-frame cost, optimize any manager exceeding 5ms average
- [ ] T068a [P] Run full headless test suite (economy, building, movement, scouting) across 20 game runs and verify SC-009 (95%+ pass rate) in tests/ai/fsharp/
- [ ] T068b [P] Run full live combat test suite across 10 game runs and verify SC-010 (90%+ pass rate) in tests/ai/fsharp/
- [X] T069 Run quickstart.md validation — verify all documented file paths exist and all described behaviors are functional

---

## Dependencies & Execution Order

### Phase Dependencies

- **Setup (Phase 1)**: No dependencies — can start immediately
- **Foundational (Phase 2)**: Depends on Setup completion — BLOCKS all user stories
- **US2 Economy (Phase 3)**: Depends on Foundational (Phase 2)
- **US3 Build Order (Phase 4)**: Depends on Foundational (Phase 2), benefits from US2 (EconomyModel)
- **US4 Production (Phase 5)**: Depends on Foundational (Phase 2), benefits from US3 (BuildManager pattern)
- **US5 Scouting (Phase 6)**: Depends on Foundational (Phase 2), independent of US2-US4
- **US7 Live Testing (Phase 7)**: Depends on Foundational (Phase 2), independent of US2-US6
- **US6 Combat (Phase 8)**: Depends on US5 (ThreatMap) and US7 (live test harness)
- **US1 Integration (Phase 9)**: Depends on US2, US3, US4, US5, US6, US7 — capstone integration
- **Polish (Phase 10)**: Depends on US1 completion

### User Story Dependencies

```
Phase 1: Setup
    │
Phase 2: Foundational (BLOCKS ALL)
    │
    ├── Phase 3: US2 Economy ──────────────┐
    ├── Phase 4: US3 Build Order ──────────┤
    ├── Phase 5: US4 Production ───────────┤
    ├── Phase 6: US5 Scouting ─────┐       │
    │                               │       │
    └── Phase 7: US7 Live Testing ──┤       │
                                    │       │
                        Phase 8: US6 Combat │
                                    │       │
                        Phase 9: US1 Integration (all above)
                                    │
                        Phase 10: Polish
```

### Within Each User Story

- Models/data structures first
- Manager logic second
- Wiring into GameState frame loop last
- Each story independently testable at its checkpoint

### Parallel Opportunities

- **Phase 2**: T010, T011, T012, T013, T014 can run in parallel (different files)
- **Phase 3-6**: US2, US3, US4, US5 can all start after Foundational completes (different manager files)
- **Phase 6-7**: US5 (Scouting) and US7 (Live Testing) are fully independent, can run in parallel
- **Phase 5**: T034 can run in parallel with other US4 tasks (different concerns)
- **Phase 6**: T039, T040 can run in parallel (ThreatMap and ScoutManager are separate files)

---

## Parallel Example: After Foundational Phase

```bash
# These four user stories can start in parallel (different files, no cross-dependencies):
# Developer A: US2 Economy (T021-T027) in EconomyModel.fs, EconomyManager.fs, MapAnalysis.fs
# Developer B: US3 Build Order (T028-T033) in BuildOrder.fs, BuildManager.fs
# Developer C: US5 Scouting (T039-T044) in ThreatMap.fs, ScoutManager.fs
# Developer D: US7 Live Testing (T045-T049) in start-live.sh, CombatTests.fs, GameRunner.fs
```

---

## Implementation Strategy

### MVP First (US2 + US3 = Economy + Building)

1. Complete Phase 1: Setup
2. Complete Phase 2: Foundational (CRITICAL — blocks all stories)
3. Complete Phase 3: US2 Economy — AI manages resources
4. Complete Phase 4: US3 Build Order — AI builds base
5. **STOP and VALIDATE**: AI bootstraps economy and builds a functional base in headless mode
6. This is the minimum viable AI — it does *something* even if it can't fight

### Incremental Delivery

1. Setup + Foundational → Framework ready
2. US2 Economy → AI manages resources (headless testable)
3. US3 Build Order → AI builds base (headless testable)
4. US4 Production → Factories produce armies (headless testable)
5. US5 Scouting → AI knows where enemy is (headless testable)
6. US7 Live Testing → Combat validation infrastructure
7. US6 Combat → AI fights (live engine only)
8. US1 Integration → Complete game loop, competitive testing
9. Polish → Tuning, optimization

### Key Milestone Gates

| Milestone | Criteria | Test Mode |
|-----------|----------|-----------|
| Economy works | 3 mex + 2 energy within 3 min | Headless |
| Base builds | Factory built within 5 min | Headless |
| Army produced | Combat units from factory | Headless |
| Scouting works | Scout sent to 2+ map regions | Headless |
| Combat works | Units engage and damage enemies | Live (Xvfb) |
| Full game | 10 games without crash | Live (Xvfb) |
| Competitive | Survives 15 min vs BARb 80% | Live (Xvfb) |

---

## Notes

- [P] tasks = different files, no dependencies
- [Story] label maps task to specific user story for traceability
- Each user story is independently testable at its checkpoint
- Commit after each task or logical group
- Headless mode covers US2, US3, US4, US5 — fast iteration
- Live engine (Xvfb) required for US6, US7, US1 integration — slower but necessary for combat
- DefId discovery (T008-T009) is the single most critical foundational task — everything else depends on correct unit identification
