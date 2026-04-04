# Quickstart: BAR AI Competitive Assessment

**Feature**: 014-bar-ai-competitive-assessment
**Branch**: `014-bar-ai-competitive-assessment`

## What This Feature Does

Adds a competitive AI brain to HighBarV2 that plays complete BAR games: managing economy, building bases, producing armies, scouting, and fighting. Uses the existing proxy bridge (C proxy + protobuf IPC + F# client).

## Key Design Choices

- **Architecture**: Manager-per-domain (Economy, Build, Production, Military, Scout) + per-unit task system, following CircuitAI's proven pattern
- **Faction**: Armada first, faction-agnostic unit selection by properties (cost, speed, DPS) not names
- **Maps**: Small-to-medium 1v1 land maps only (no naval, no team)
- **Testing**: Headless for economy/building tests, Xvfb + live engine for combat tests
- **Observability**: Structured JSON lines decision logging per game

## Implementation Phases

| Phase | Goal | Key Deliverable |
|-------|------|-----------------|
| 1 | Foundation fixes | Runtime DefId discovery, live test harness, spawn stability |
| 2 | Core architecture | GameState, 5 managers, unit task system, strategy controller |
| 3 | Economy & building | Metal spot analysis, build orders, factory management |
| 4 | Scouting & intel | Map exploration, enemy tracking, threat assessment |
| 5 | Combat AI | Army grouping, attack decisions, tactical micro (live engine) |
| 6 | Competitive testing | Game runner, benchmarking vs BARb, iterative tuning |

## Key Files

**AI Logic** (new, in `clients/fsharp/src/`):
- `GameState.fs` — Root game state model
- `UnitRegistry.fs` — Runtime DefId discovery + unit tracking
- `EconomyModel.fs` — Resource tracking
- `ThreatMap.fs` — Spatial enemy model
- `Managers/*.fs` — Domain managers (Economy, Build, Production, Military, Scout)
- `Tasks/UnitTask.fs` — Per-unit task DU
- `Strategy/StrategyController.fs` — Game phase detection
- `Strategy/BuildOrder.fs` — Opening build sequences
- `Logging/DecisionLog.fs` — Structured decision logging

**Game Runner** (new, in `tools/game-runner/`):
- `GameRunner.fs` — Automated AI-vs-AI launcher with outcome collection

**Tests** (new, in `tests/ai/fsharp/`):
- Economy, build, production, scouting tests (headless)
- Combat and full game tests (live engine + Xvfb)

## Success Targets

- Completes full games without crashing (10 consecutive runs)
- Builds 3 mex + 2 energy within 3 minutes (90% of games)
- Produces combat units within 5 minutes
- Beats do-nothing AI 100%
- Survives 15 minutes vs BARb 80%

## Related Specs

- [spec.md](spec.md) — Full specification with user stories and requirements
- [plan.md](plan.md) — Implementation plan with design decisions
- [research.md](research.md) — Research findings (architecture patterns, headless limitations, BARb analysis)
- [data-model.md](data-model.md) — Entity model with state transitions and relationships
