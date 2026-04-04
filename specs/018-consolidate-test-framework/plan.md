# Implementation Plan: Consolidate Test Framework

**Branch**: `018-consolidate-test-framework` | **Date**: 2026-04-04 | **Spec**: [spec.md](spec.md)
**Input**: Feature specification from `/specs/018-consolidate-test-framework/spec.md`

## Summary

Consolidate the fragmented test infrastructure into a unified system with a single entry point (`tests/run-all.sh`), standardized configuration (all game/map/engine settings from `engine-version.json`), removal of stale tests and duplicate coverage, and automated Markdown report generation to `/reports/testreports/`. Supports both headless and graphical test modes with engine auto-detection.

## Technical Context

**Language/Version**: Bash (test runner scripts), F# / .NET 8.0 (primary test code), Python 3.10+ (secondary tests), C11 (proxy tests)
**Primary Dependencies**: xUnit 2.9.x (F# tests), pytest (Python tests), CTest/CMake (C tests), jq (JSON parsing in scripts)
**Storage**: Filesystem (Markdown reports, JSON config, temp directories)
**Testing**: dotnet test (F#), pytest (Python), ctest (C proxy)
**Target Platform**: Linux (Arch-based dev workstation, CI)
**Project Type**: Test infrastructure / tooling
**Performance Goals**: Full headless test suite completes in < 10 minutes
**Constraints**: Engine binary must be pre-installed; no network downloads during test runs
**Scale/Scope**: ~120 tests across 7 categories, 5 test projects

## Constitution Check

*GATE: Must pass before Phase 0 research. Re-check after Phase 1 design.*

| Principle | Status | Notes |
|-----------|--------|-------|
| I. Zero Engine Modifications | ✅ Pass | No engine changes — tests use standard AI plugin interface |
| II. Binary Protocol First | ✅ Pass | No protocol changes — tests exercise existing protobuf protocol |
| III. Correctness Over Cleverness | ✅ Pass | Straightforward bash orchestration, no clever abstractions |
| IV. Test at the Boundary | ✅ Pass | This feature improves test infrastructure for boundary testing |
| V. Latency Budget Discipline | ✅ N/A | No hot-path changes |
| VI. Language-Agnostic by Default | ✅ Pass | Retains Python tests for cross-language validation |
| VII. Explicit Over Implicit | ✅ Pass | All config in engine-version.json, auto-detection documented |

**Post-Phase 1 Re-check**: All gates still pass. No protocol, engine, or architectural changes introduced.

## Project Structure

### Documentation (this feature)

```text
specs/018-consolidate-test-framework/
├── spec.md              # Feature specification
├── plan.md              # This file
├── research.md          # Phase 0 research findings
├── data-model.md        # Entity definitions
├── quickstart.md        # Usage guide
└── checklists/
    └── requirements.md  # Spec quality checklist
```

### Source Code (repository root)

```text
tests/
├── run-all.sh                    # NEW: Unified test runner entry point
├── engine-version.json           # UPDATED: Single source of truth for all config
├── check-prerequisites.sh        # UPDATED: Auto-detection logic standardized
├── setup-engine.sh               # UPDATED: Auto-detection logic standardized
├── README.md                     # UPDATED: Consolidated documentation
│
├── unit/fsharp/                  # KEPT: 6 unit tests (no engine)
│   ├── CommandBuilderTests.fs
│   └── HighBar.Unit.Tests.fsproj
│
├── integration/fsharp/           # UPDATED: Remove ScenarioTests.fs (duplicate of persistent T5)
│   ├── Harness.fs
│   ├── ConnectionTests.fs
│   ├── EventTests.fs
│   ├── CommandTests.fs
│   ├── CallbackTests.fs
│   ├── UnitDataTests.fs
│   └── HighBar.Tests.fsproj
│
├── integration/python/           # KEPT: Cross-language validation tests
│   ├── conftest.py               # UPDATED: Auto-detection for SPRING_DATADIR
│   └── test_*.py
│
├── persistent/fsharp/            # KEPT: 40 persistent engine tests (primary engine test suite)
│   └── [T0-T8 tiers, unchanged]
│
├── ai/fsharp/                    # KEPT: AI validation tests
│   └── [unchanged]
│
├── fixtures/
│   ├── game-setup.txt            # UPDATED: Templatize GameType (add __GAME_TYPE__)
│   ├── game-setup-e2e.txt        # UPDATED: Same templatization
│   ├── game-setup-combat-verify.txt  # UPDATED: Same templatization
│   ├── game-setup-live.txt       # UPDATED: Same templatization
│   ├── start-headless.sh         # UPDATED: Read game type from engine-version.json
│   ├── start-live.sh             # UPDATED: Remove absolute paths, use auto-detection
│   ├── stop-headless.sh          # KEPT
│   └── run-tests.sh              # KEPT (used by run-all.sh internally)
│
data/bar.tests/                   # KEPT: BarData library tests (no engine)
│   └── [unchanged]

reports/
└── testreports/                  # NEW: Auto-created directory for test reports
```

**Structure Decision**: Preserve the existing multi-tier test structure. The consolidation adds a unified runner on top without restructuring directories. The key change is removing duplicates, fixing configuration, and adding report generation.

## Complexity Tracking

No constitution violations. No complexity tracking needed.
