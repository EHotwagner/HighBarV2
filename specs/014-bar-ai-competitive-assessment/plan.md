# Implementation Plan: BAR AI Competitive Assessment

**Branch**: `014-bar-ai-competitive-assessment` | **Date**: 2026-04-04 | **Spec**: [spec.md](spec.md)
**Input**: Feature specification from `/specs/014-bar-ai-competitive-assessment/spec.md`

## Summary

Build a competitive AI for Beyond All Reason (BAR) that plays complete games — managing economy, constructing bases, producing armies, scouting, and engaging in combat. The AI uses the existing HighBarV2 proxy bridge architecture (C proxy + protobuf IPC + F# client) and follows CircuitAI's proven manager/task pattern adapted for our cross-process architecture. Implementation is phased: foundation fixes first (DefId discovery, live test harness), then core AI architecture (game state, managers, unit tasks), then domain-specific logic (economy, building, scouting, combat), and finally competitive testing against BARbarianAI. Initial scope: Armada faction, small-to-medium 1v1 land maps.

## Technical Context

**Language/Version**: F# / .NET 8.0 (AI logic + tests), C11 (existing proxy — no changes needed)
**Primary Dependencies**: HighBar.Client (in-repo), BarData (in-repo), Google.Protobuf 3.28, xUnit 2.x
**Storage**: Filesystem only (structured decision logs as JSON lines, game outcome reports as markdown)
**Testing**: xUnit (F# tests), headless engine for non-combat tests, Xvfb + live engine for combat tests
**Target Platform**: Linux (primary), cross-platform via .NET 8.0
**Project Type**: Library (AI decision engine) + executable (game runner)
**Performance Goals**: AI frame response < 25ms (within proxy's 33ms frame budget at 30fps)
**Constraints**: < 1ms proxy overhead (per constitution), AI decision logic gets remaining ~25ms budget. No heap allocation in proxy hot path (existing constraint). AI client-side allocations are unconstrained.
**Scale/Scope**: Single AI instance per game, tracking up to ~500 units (friendly + enemy), ~50 metal spots per map, ~30fps frame rate

## Constitution Check

*GATE: Must pass before Phase 0 research. Re-check after Phase 1 design.*

| Principle | Status | Notes |
|-----------|--------|-------|
| I. Zero Engine Modifications | PASS | AI logic runs entirely in the F# client process. No engine changes. Uses standard Skirmish AI callback interface via existing proxy. |
| II. Binary Protocol First | PASS | All IPC remains protobuf over Unix domain sockets. AI logic adds no new IPC protocols. Decision logs use JSON lines for human-readable debug output only (not on hot path). |
| III. Correctness Over Cleverness | PASS | AI modules use straightforward manager/task patterns. No "smart" proxy transformations. All engine interaction goes through existing typed command builders and event parsers. |
| IV. Test at the Boundary | PASS | Existing proxy boundary tests remain. New AI tests focus on integration boundary: does the AI issue correct commands given specific game states? Tests use live engine to validate end-to-end behavior. |
| V. Latency Budget Discipline | PASS | AI decision logic targets < 25ms per frame. Manager evaluations are designed to be incremental (process only changed state per frame, not full recomputation). Frame budget monitored via structured logging. |
| VI. Language-Agnostic by Default | PASS | AI logic is client-side F# only. No protocol-level changes. The .proto schema remains untouched. A Python AI could be built using the same protocol. |
| VII. Explicit Over Implicit | PASS | AI configuration (build order parameters, phase thresholds, production ratios) will be explicit and documented. Decision logs provide full transparency into AI reasoning. |

No constitution violations. No complexity tracking entries needed.

## Project Structure

### Documentation (this feature)

```text
specs/014-bar-ai-competitive-assessment/
├── plan.md              # This file
├── spec.md              # Feature specification
├── research.md          # Phase 0: research findings
├── data-model.md        # Phase 1: entity model
├── quickstart.md        # Phase 1: quick reference
├── checklists/
│   └── requirements.md  # Spec quality checklist
└── tasks.md             # Phase 2: task breakdown (via /speckit.tasks)
```

### Source Code (repository root)

```text
clients/fsharp/
├── src/
│   ├── Client.fs              # Existing: connection, handshake, frame loop
│   ├── Commands.fs            # Existing: typed command builders (97 types)
│   ├── Events.fs              # Existing: GameEvent DU, event parsing
│   ├── Units.fs               # Existing: unit metadata types
│   ├── GameState.fs           # NEW: persistent game state model
│   ├── UnitRegistry.fs        # NEW: runtime DefId discovery + unit tracking
│   ├── EconomyModel.fs        # NEW: resource tracking, income/expenditure
│   ├── ThreatMap.fs           # NEW: spatial enemy force model
│   ├── Managers/
│   │   ├── ManagerBase.fs     # NEW: shared manager interface/pattern
│   │   ├── EconomyManager.fs  # NEW: resource monitoring, build priorities
│   │   ├── BuildManager.fs    # NEW: structure placement, build orders
│   │   ├── ProductionManager.fs # NEW: factory queue management
│   │   ├── MilitaryManager.fs # NEW: combat coordination, army grouping
│   │   └── ScoutManager.fs    # NEW: map exploration, enemy tracking
│   ├── Tasks/
│   │   ├── UnitTask.fs        # NEW: task DU (BuildMex, BuildEnergy, Scout, Attack, Idle, etc.)
│   │   └── TaskAssigner.fs    # NEW: task assignment/reassignment logic
│   ├── Strategy/
│   │   ├── StrategyController.fs # NEW: game phase detection, milestone evaluation
│   │   ├── BuildOrder.fs      # NEW: opening build order sequences
│   │   └── MapAnalysis.fs     # NEW: metal spot ranking, terrain evaluation
│   └── Logging/
│       └── DecisionLog.fs     # NEW: structured decision logging (JSON lines)
├── proto-gen/                 # Existing: generated protobuf F# classes
└── HighBar.Client.fsproj      # Updated: new source files added

tools/
├── game-runner/               # NEW: automated AI-vs-AI game launcher
│   ├── Program.fs             # Game runner CLI
│   ├── GameRunner.fs          # Engine lifecycle, outcome collection
│   └── GameRunner.fsproj
├── echo-ai/                   # Existing: reference AI
├── replay/                    # Existing: replay tool
└── generate-bar-data.fsx      # Existing: BarData generator

tests/
├── integration/fsharp/        # Existing: live engine integration tests
├── persistent/fsharp/         # Existing: persistent engine tests
├── ai/fsharp/                 # NEW: AI decision tests
│   ├── EconomyManagerTests.fs # Economy logic tests (headless)
│   ├── BuildManagerTests.fs   # Build order tests (headless)
│   ├── ProductionManagerTests.fs # Factory queue tests (headless)
│   ├── ScoutManagerTests.fs   # Scouting tests (headless)
│   ├── CombatTests.fs         # Combat tests (live engine + Xvfb)
│   ├── FullGameTests.fs       # End-to-end game tests (live engine)
│   └── HighBar.AI.Tests.fsproj
├── fixtures/
│   ├── game-setup.txt         # Existing: headless game config
│   ├── start-headless.sh      # Existing: headless launcher
│   ├── start-live.sh          # Updated: Xvfb + live engine launcher
│   └── game-setup-live.txt    # NEW: live engine game config
└── check-prerequisites.sh     # Existing: prerequisite validation
```

**Structure Decision**: AI logic lives inside the existing `clients/fsharp/` project as new modules under `src/`. This avoids a separate project/assembly while keeping clear module boundaries via subdirectories (Managers/, Tasks/, Strategy/, Logging/). A new `tools/game-runner/` project provides the automated game launcher. A new `tests/ai/fsharp/` test project covers AI-specific behavior.

## Design Decisions

### D1: Manager + Task Architecture (following CircuitAI pattern)

**Decision**: Use a manager-per-domain architecture with a per-unit task system.

**Rationale**: CircuitAI has proven this pattern works for BAR AI. Five managers (Economy, Build, Production, Military, Scout) each evaluate their domain independently per frame and propose commands. A StrategyController sets the current game phase and priority weights. Each unit is assigned a task (BuildMex, Scout, Attack, Idle, etc.) that translates to specific engine commands.

**Alternatives considered**:
- Behavior tree: More flexible but harder to debug and tune; overkill for initial implementation
- Utility AI (score-based): Better for complex decision spaces but adds latency from scoring all options every frame
- Finite state machine: Too rigid for the dynamic nature of RTS gameplay

### D2: Incremental Frame Processing

**Decision**: Managers process only changed state per frame, not full recomputation.

**Rationale**: With 30fps frame rate and 25ms AI budget, full game state recomputation every frame is wasteful. Instead: EconomyManager recalculates only when resource callbacks return changed values. BuildManager re-evaluates only when a builder becomes idle or a build completes. MilitaryManager re-evaluates only on new enemy sightings or unit losses. This keeps per-frame cost low.

### D3: Runtime DefId Discovery via Engine Callbacks

**Decision**: Query engine for all unit definitions at init time, build a runtime registry mapping engine DefIds to unit properties.

**Rationale**: Static BarData indices don't match engine DefId assignments (581 engine defIds vs 953 in BarData). The engine's `GetUnitDefs` callback returns the actual runtime mapping. The AI will query this at init, classify units by properties (isBuilder, isFactory, isMobile, isArmed, costTier), and use this classification for all subsequent decisions. This also makes the system faction-agnostic — unit selection is driven by properties, not hardcoded names.

### D4: Headless for Economy/Build Tests, Live for Combat Tests

**Decision**: Split test suite by engine capability — headless for non-combat, Xvfb+live for combat.

**Rationale**: Headless mode confirmed to lack weapon physics (0 combat events across 1200+ test frames). Economy, building, movement, and scouting all work in headless and are faster to test. Combat tests require the full graphical engine via Xvfb (virtual framebuffer) for CI compatibility. The test harness will support both modes via a shared fixture with a `--live` flag.

### D5: Structured JSON Lines Decision Logging

**Decision**: Log AI decisions as JSON lines to a per-game log file.

**Rationale**: JSON lines format is grep-friendly, parseable by standard tools (jq), and can be correlated with game replays by frame number. Each log entry includes: frame number, manager name, decision type, decision details, and reasoning context. This enables post-game analysis without runtime visualization complexity.

### D6: Armada First, Property-Driven Unit Selection

**Decision**: Start with Armada faction. Unit selection logic uses unit properties (cost, speed, damage, buildOptions) rather than hardcoded unit names.

**Rationale**: Armada is the most commonly tested faction. By selecting units based on properties (e.g., "cheapest armed mobile unit", "fastest scout", "highest DPS factory output"), the same logic will work for Cortex and Legion once their unit data is loaded. The BarData library already provides all needed properties.

## Phase Implementation Overview

### Phase 1: Foundation Fixes (Prerequisites)

**Goal**: Resolve blocking issues before building AI logic

1. Runtime DefId discovery — query engine at init, build unit registry
2. Live test harness — Xvfb + spring binary fixture for combat testing
3. Large spawn stability — identify and exclude crash-causing DefIds

### Phase 2: AI Core Architecture

**Goal**: Build the decision-making framework

4. GameState model — persistent tracking of units, economy, map
5. Manager framework — 5 managers with per-frame evaluation
6. Unit task system — task assignment/reassignment per unit
7. StrategyController — game phase detection via milestones

### Phase 3: Economy & Building AI

**Goal**: AI bootstraps economy and builds a functional base

8. Metal spot analysis — map query, ranking, assignment
9. Build order engine — opening sequence for Armada
10. Structure placement — footprint-aware, path-preserving
11. Factory management — production queues, unit mix

### Phase 4: Scouting & Intelligence

**Goal**: AI maintains map awareness

12. Map exploration — scout dispatch, fog-of-war model
13. Enemy tracking — LOS/radar event processing
14. Threat assessment — spatial threat model

### Phase 5: Combat AI (requires live engine)

**Goal**: AI engages tactically

15. Army grouping — squad formation by unit type
16. Attack decisions — when/where to attack
17. Tactical micro — focus fire, retreat, engagement rules
18. Defense response — reactive defense coordination

### Phase 6: Integration & Competitive Testing

**Goal**: Full games against BARb

19. Game runner tool — automated AI-vs-AI launcher
20. Performance benchmarking — win rate, economy efficiency, game duration
21. Iterative tuning — parameter optimization from game outcomes
