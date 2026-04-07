# Implementation Plan: Adapt FSBarV1 Test Harness and Engine Handling

**Branch**: `028-adapt-test-harness` | **Date**: 2026-04-07 | **Spec**: [spec.md](spec.md)
**Input**: Feature specification from `/specs/028-adapt-test-harness/spec.md`

## Summary

Replace three duplicated F# test harness implementations (integration, persistent, AI — ~1,259 lines total, ~250 lines duplicated) with a single `EngineSession` abstraction in the `HighBar.Client` library. Adapts FSBarV1's proven `BarClient` pattern: unified engine lifecycle with state machine, programmatic game script generation, typed exceptions with diagnostics, PID-based orphan tracking, and centralized configuration from `engine-version.json` with environment variable overrides. Shell-based engine start/stop scripts replaced by F# `EngineLauncher` module.

## Technical Context

**Language/Version**: F# / .NET 10.0
**Primary Dependencies**: HighBar.Client, Google.Protobuf 3.28, xUnit 2.9.x, System.Diagnostics.Process, System.Net.Sockets
**Storage**: Filesystem (Unix domain sockets, session directories in /tmp, PID files)
**Testing**: xUnit 2.9.x with IAsyncLifetime fixtures, `./tests/run-all.sh` runner
**Target Platform**: Linux (headless and graphical engine modes)
**Project Type**: Library extension (HighBar.Client) + test harness refactoring
**Performance Goals**: Engine startup/teardown within 10% of current; zero process leaks
**Constraints**: Must not change protobuf protocol or HighBarClient wire-level behavior
**Scale/Scope**: 3 harness files to refactor, 6 new modules to create, 3 shell scripts to remove

## Constitution Check

*GATE: Must pass before Phase 0 research. Re-check after Phase 1 design.*

| Principle | Status | Notes |
|-----------|--------|-------|
| I. Zero Engine Modifications | PASS | No engine changes — only test infrastructure |
| II. Binary Protocol First | PASS | Protobuf protocol unchanged; no new wire formats |
| III. Correctness Over Cleverness | PASS | Direct port of proven FSBarV1 patterns; 1:1 state mapping |
| IV. Test at the Boundary | PASS | Improves test infrastructure; boundary tests unchanged |
| V. Latency Budget Discipline | PASS | No hot-path changes; engine lifecycle is cold path |
| VI. Language-Agnostic by Default | PASS | No protocol changes; engine lifecycle is F#-only (client-side) |
| VII. Explicit Over Implicit | PASS | Centralizes configuration with documented defaults and env var overrides; connection lifecycle logged |

**Post-Phase 1 re-check**: All gates still pass. The design adds no protocol-level behavior, no engine modifications, and no implicit defaults. Configuration is more explicit than before (single source vs scattered).

## Project Structure

### Documentation (this feature)

```text
specs/028-adapt-test-harness/
├── plan.md              # This file
├── spec.md              # Feature specification
├── research.md          # Phase 0 research decisions
├── data-model.md        # Entity definitions
├── quickstart.md        # Architecture overview
└── tasks.md             # Phase 2 output (created by /speckit.tasks)
```

### Source Code (repository root)

```text
clients/fsharp/src/
├── Client.fs                    # Existing — unchanged (protocol/connection)
├── EngineConfig.fs              # NEW — configuration record + factory
├── EngineLauncher.fs            # NEW — process spawn, data dir detection, shutdown
├── ScriptGenerator.fs           # NEW — TDF game script generation
├── EngineSession.fs             # NEW — lifecycle state machine (main abstraction)
├── SessionDiagnostics.fs        # NEW — log extraction for error reporting
├── EngineDisconnectedException.fs # NEW — typed exception
└── Client.fsproj                # MODIFIED — add new source files

tests/
├── engine-version.json          # Existing — now read by EngineConfig.fromVersionFile()
├── check-prerequisites.sh       # Existing — unchanged (standalone CLI tool)
├── run-all.sh                   # Existing — unchanged
├── integration/fsharp/
│   └── Harness.fs               # MODIFIED — thin wrapper around EngineSession
├── persistent/fsharp/
│   └── PersistentHarness.fs     # MODIFIED — thin wrapper + verified state reset
└── ai/fsharp/
    └── AiTestHarness.fs         # MODIFIED — GameOrchestrator uses EngineSession

tests/fixtures/
├── start-headless.sh            # REMOVED — replaced by EngineLauncher
├── stop-headless.sh             # REMOVED — replaced by EngineLauncher
└── game-setup.txt               # REMOVED — replaced by ScriptGenerator
```

**Structure Decision**: Extend existing `clients/fsharp/src/` with new modules, matching FSBarV1's `FSBar.Client` architecture. No new projects needed — the client library is the natural home for engine lifecycle management.

## Complexity Tracking

No constitution violations. No complexity justifications needed.
