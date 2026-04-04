# Implementation Plan: Live Headless Engine Test Suite

**Branch**: `004-live-headless-testsuite` | **Date**: 2026-04-03 | **Spec**: [spec.md](spec.md)
**Input**: Feature specification from `/specs/004-live-headless-testsuite/spec.md`

## Summary

Enable the existing HighBarV2 integration test suite (F# xUnit + Python pytest) to run against a real `spring-headless` engine instance. This involves: creating a version pinning configuration, building a prerequisites validation script, extending the test harness for engine log capture and crash detection, disabling victory conditions in the test scenario, and providing automated content provisioning.

## Technical Context

**Language/Version**: Bash (scripts), F# / .NET 10.0 (test harness), Lua (game scenario)
**Primary Dependencies**: xUnit (F# tests), jq (JSON parsing in shell), pr-downloader (game content)
**Storage**: Filesystem only (JSON config, log files, temp directories)
**Testing**: xUnit (F#) against live `spring-headless`
**Target Platform**: Linux (primary); `spring-headless` is Linux-native
**Project Type**: Test infrastructure (scripts + harness extensions)
**Performance Goals**: Prerequisites check < 5s; engine startup overhead < 15s
**Constraints**: No engine modifications (Principle I); no bundled binaries; game content downloaded at setup time
**Scale/Scope**: Single developer machine, 1 concurrent engine instance per test runner

## Constitution Check

*GATE: Must pass before Phase 0 research. Re-check after Phase 1 design.*

| Principle | Status | Notes |
|-----------|--------|-------|
| I. Zero Engine Modifications | ✅ PASS | No engine changes. Uses standard `spring-headless` binary and Skirmish AI interface. |
| II. Binary Protocol First | ✅ PASS | No protocol changes. Tests exercise the existing protobuf/Unix socket protocol. |
| III. Correctness Over Cleverness | ✅ PASS | Straightforward shell scripts and harness extensions. No clever abstractions. |
| IV. Test at the Boundary | ✅ PASS | This feature IS the boundary testing infrastructure — running real engine integration tests. |
| V. Latency Budget Discipline | ✅ N/A | Test infrastructure, not hot-path code. No proxy latency impact. |
| VI. Language-Agnostic by Default | ✅ PASS | Version config is JSON (readable by any language). Both F# and Python harnesses supported independently. |
| VII. Explicit Over Implicit | ✅ PASS | All config via explicit JSON file and environment variables. No magic defaults added. |

**Performance & Safety Constraints**: N/A — this feature adds test infrastructure only, no proxy code changes.

**Development Workflow**:
- No `.proto` changes required.
- Commits follow Conventional Commits (`test:`, `build:`).
- No generated code changes.

**Post-design re-check**: All gates still pass. No violations to justify.

## Project Structure

### Documentation (this feature)

```text
specs/004-live-headless-testsuite/
├── plan.md              # This file
├── research.md          # Phase 0 output
├── data-model.md        # Phase 1 output
├── quickstart.md        # Phase 1 output
├── contracts/           # Phase 1 output
│   ├── engine-version-schema.md
│   └── check-prerequisites-cli.md
└── tasks.md             # Phase 2 output (via /speckit.tasks)
```

### Source Code (repository root)

```text
tests/
├── engine-version.json          # NEW: Pinned engine/game/map versions
├── check-prerequisites.sh       # NEW: Validate environment
├── setup-engine.sh              # NEW: Automated content provisioning
├── README.md                    # MODIFIED: Add prerequisites workflow docs
├── fixtures/
│   ├── start-headless.sh        # MODIFIED: Add log capture, write-dir
│   ├── stop-headless.sh         # EXISTING: No changes needed
│   └── game-setup.lua           # MODIFIED: Add GameMode=3 (disable victory)
└── integration/
    ├── fsharp/
    │   └── Harness.fs           # MODIFIED: Add crash detection, prereq check, diagnostics
    └── python/
        └── conftest.py          # MODIFIED: Add crash detection, prereq check, diagnostics
```

**Structure Decision**: Extends the existing `tests/` directory. All new files are shell scripts or a JSON config file. No new directories created except the contracts folder in specs.

## Complexity Tracking

No constitution violations. No complexity justifications needed.
