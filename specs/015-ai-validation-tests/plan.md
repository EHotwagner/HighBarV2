# Implementation Plan: AI Validation and Competitive Testing

**Branch**: `015-ai-validation-tests` | **Date**: 2026-04-04 | **Spec**: [spec.md](spec.md)
**Input**: Feature specification from `/specs/015-ai-validation-tests/spec.md`

## Summary

Implement deferred validation tasks from feature 014: end-to-end game testing against NullAI (10 games, headless), competitive benchmarking against BARbarianAI (10 games, live engine via Xvfb), and comprehensive test suites for non-combat (headless, 20 runs) and combat (live, 10 runs) scenarios. The approach builds on the existing `PersistentEngineFixture` harness, `GameState` AI brain, and `GameRunner` scaffold, extending them with multi-game orchestration, outcome tracking, and markdown report generation.

## Technical Context

**Language/Version**: F# / .NET 8.0  
**Primary Dependencies**: HighBar.Client (in-repo), BarData (in-repo), Google.Protobuf 3.28, xUnit 2.9.x  
**Storage**: Filesystem only (markdown reports, JSON lines decision logs, temp directories)  
**Testing**: xUnit (F# test framework), `spring-headless` (headless engine), `spring` (live graphical engine via Xvfb)  
**Target Platform**: Linux (x86_64)  
**Project Type**: Test suite + validation tooling  
**Performance Goals**: 10 games in < 5 minutes (headless at 100x speed, ~17s per game); 10 live games in < 30 minutes  
**Constraints**: Headless engine cannot simulate weapon physics (zero WeaponFired/UnitDamaged/UnitDestroyed events); combat tests require live engine + Xvfb  
**Scale/Scope**: 4 test suites (end-to-end, competitive, non-combat, combat), ~50 game runs total per full validation

## Constitution Check

*GATE: Must pass before Phase 0 research. Re-check after Phase 1 design.*

| Principle | Status | Notes |
|-----------|--------|-------|
| I. Zero Engine Modifications | **PASS** | Tests use standard engine via existing AI plugin interface; no engine patches |
| II. Binary Protocol First | **PASS** | All IPC uses existing protobuf over Unix domain sockets; tests validate AI behavior, not protocol |
| III. Correctness Over Cleverness | **PASS** | Test outcomes map directly to observable engine events and game results |
| IV. Test at the Boundary | **PASS** | This feature IS the boundary testing — validating AI behavior through the real engine |
| V. Latency Budget Discipline | **N/A** | No hot-path changes; tests run at 100x game speed with no real-time constraint |
| VI. Language-Agnostic by Default | **PASS** | Tests exercise the F# client through the proto-defined protocol; no protocol-level additions |
| VII. Explicit Over Implicit | **PASS** | All configuration via game-setup.txt templates, environment variables, and explicit test parameters |

**Gate result**: PASS — no violations.

## Project Structure

### Documentation (this feature)

```text
specs/015-ai-validation-tests/
├── plan.md              # This file
├── research.md          # Phase 0 output
├── data-model.md        # Phase 1 output
├── quickstart.md        # Phase 1 output
├── contracts/           # Phase 1 output
└── tasks.md             # Phase 2 output (via /speckit.tasks)
```

### Source Code (repository root)

```text
tests/ai/fsharp/                    # AI validation test project (existing, empty)
├── HighBar.AI.Tests.fsproj         # Existing project file
├── AiTestTypes.fs                  # Shared types: GameResult, GameOutcome, ValidationReport, etc.
├── AiTestHarness.fs                # Multi-game orchestration + outcome collection
├── ValidationReport.fs             # Markdown report generation
├── EndToEndTests.fs                # US1: 10 games vs NullAI (headless)
├── CompetitiveTests.fs             # US2: 10 games vs BARb (live + Xvfb)
├── NonCombatTests.fs               # US3: 20-run headless test suite
└── CombatTests.fs                  # US4: 10-run live combat test suite

tests/fixtures/
├── game-setup.txt                  # Existing: headless config (AI0=HighBarV2, AI1=NullAI, deathmode=neverend)
├── game-setup-e2e.txt              # NEW: end-to-end config (same as game-setup.txt, deathmode=neverend)
├── game-setup-live.txt             # Existing: live engine config
├── game-setup-barb.txt             # NEW: config with AI1=BARbarianAI, deathmode removed (natural ending)
├── start-headless.sh               # Existing: launches headless engine
└── start-live.sh                   # Existing: launches live graphical engine

tools/game-runner/
├── GameRunner.fsproj               # Existing project
├── GameRunner.fs                   # Existing: GameOutcome type + report generation
└── Program.fs                      # Existing: CLI scaffold (may extend)
```

**Structure Decision**: Tests live in `tests/ai/fsharp/` (existing empty project). The `AiTestHarness` module handles multi-game orchestration — launching engine, connecting AI brain, running N frames, collecting outcomes. Each test file is a separate xUnit test class. The `GameRunner` tool's `GameOutcome` type and `generateReport` function are reused for report generation.

## Post-Design Constitution Re-Check

*Re-evaluated after Phase 1 design completion.*

| Principle | Status | Notes |
|-----------|--------|-------|
| I. Zero Engine Modifications | **PASS** | No engine changes. New game-setup fixtures use only standard modoptions. |
| II. Binary Protocol First | **PASS** | No protocol changes. Tests use existing protobuf IPC via `HighBarClient`. |
| III. Correctness Over Cleverness | **PASS** | `GameOutcome` fields map 1:1 to observable events. No inferred or derived win conditions — uses engine's native `Shutdown(GAME_OVER)`. |
| IV. Test at the Boundary | **PASS** | All 4 test suites exercise the full stack: engine → proxy → client → AI brain → commands → engine. |
| V. Latency Budget Discipline | **N/A** | Tests measure AI behavior, not latency. No hot-path code added. |
| VI. Language-Agnostic by Default | **PASS** | No `.proto` changes. `GameOutcome`/`ValidationReport` are F#-only test types, not protocol types. |
| VII. Explicit Over Implicit | **PASS** | Separate fixture files for each opponent (NullAI, BARb). Environment variables for engine paths and DISPLAY. Fail-fast on missing prerequisites. |

**Post-design gate result**: PASS — no new violations introduced.

## Complexity Tracking

> No constitution violations to justify.
