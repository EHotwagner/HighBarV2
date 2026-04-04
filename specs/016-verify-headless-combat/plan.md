# Implementation Plan: Verify Headless Combat and Fix Test Errors

**Branch**: `016-verify-headless-combat` | **Date**: 2026-04-04 | **Spec**: [spec.md](spec.md)
**Input**: Feature specification from `/specs/016-verify-headless-combat/spec.md`

## Summary

Run the Feature 015 AI validation test suite, fix any compilation or runtime errors, and empirically verify whether the headless BAR engine (`spring-headless`) supports weapon physics/combat events. The Feature 014 finding claimed zero combat events in headless mode — this feature independently verifies that claim using controlled tests with opposing combat units, then runs the full validation suite and generates reports.

## Technical Context

**Language/Version**: F# / .NET 10.0  
**Primary Dependencies**: HighBar.Client (in-repo), BarData (in-repo), GameRunner (in-repo), xUnit 2.9.x, Google.Protobuf 3.28  
**Storage**: Filesystem (markdown reports, temp directories, Unix domain sockets)  
**Testing**: xUnit + `dotnet test`, spring-headless 2025.06.21  
**Target Platform**: Linux x86-64 (with GPU passthrough, full BAR installation)  
**Project Type**: Test suite (validation/verification)  
**Performance Goals**: N/A (test infrastructure, not hot-path code)  
**Constraints**: spring-headless binary at `/home/developer/.local/bin/spring-headless`, BAR content in `/home/developer/.spring/`, proxy at `build/libSkirmishAI.so`  
**Scale/Scope**: 10-20 game runs per suite, ~17s per headless game

## Constitution Check

*GATE: Must pass before Phase 0 research. Re-check after Phase 1 design.*

| Principle | Status | Notes |
|-----------|--------|-------|
| I. Zero Engine Modifications | PASS | No engine changes. Uses standard Skirmish AI plugin interface via existing proxy. |
| II. Binary Protocol First | PASS | Uses existing protobuf/Unix socket infrastructure from prior features. |
| III. Correctness Over Cleverness | PASS | Straightforward test verification — no clever transformations. |
| IV. Test at the Boundary | PASS | Tests operate at the engine/AI boundary via proxy callbacks. Combat verification specifically tests event delivery across this boundary. |
| V. Latency Budget Discipline | N/A | Test infrastructure only, no hot-path modifications. |
| VI. Language-Agnostic by Default | N/A | F# test code only, no protocol changes. |
| VII. Explicit Over Implicit | PASS | Explicit game setup configs, explicit event counters, explicit pass/fail criteria. |

**Gate result**: PASS — no violations.

## Project Structure

### Documentation (this feature)

```text
specs/016-verify-headless-combat/
├── plan.md              # This file
├── research.md          # Phase 0 output
├── data-model.md        # Phase 1 output
├── quickstart.md        # Phase 1 output
└── tasks.md             # Phase 2 output (via /speckit.tasks)
```

### Source Code (repository root)

```text
tests/ai/fsharp/
├── HighBar.AI.Tests.fsproj   # Existing test project (modify as needed)
├── AiTestTypes.fs             # Existing types (add CombatVerification types if needed)
├── AiTestHarness.fs           # Existing harness (HeadlessAiFixture, LiveAiFixture)
├── ValidationReport.fs        # Existing report generation
├── EndToEndTests.fs           # Existing — fix errors, run
├── NonCombatTests.fs          # Existing — fix errors, run
├── CombatTests.fs             # Existing — fix errors, run (live engine)
├── CompetitiveTests.fs        # Existing — fix errors, run (live engine)
└── HeadlessCombatVerification.fs  # NEW — dedicated combat verification test

tests/fixtures/
├���─ game-setup-e2e.txt         # Existing headless config
├── game-setup-barb.txt        # Existing competitive config
├── game-setup-combat-verify.txt  # NEW — combat verification config (opposing teams, close range)
├── start-headless.sh          # Existing engine launcher
└── stop-headless.sh           # Existing engine stopper

reports/                       # Generated at runtime (gitignored)
└── *.md                       # Validation and combat verification reports
```

**Structure Decision**: Extends existing `tests/ai/fsharp/` project with one new test file and one new fixture. No new projects needed.

## Complexity Tracking

> No violations — table not needed.
