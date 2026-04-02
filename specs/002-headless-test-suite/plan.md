# Implementation Plan: Headless Test Suite

**Branch**: `002-headless-test-suite` | **Date**: 2026-04-02 | **Spec**: [spec.md](spec.md)
**Input**: Feature specification from `/specs/002-headless-test-suite/spec.md`

## Summary

Build an iterative, layered integration test suite that exercises the full HighBarV2 stack -- F# and Python clients connecting through the C proxy plugin running inside a real headless BAR (Recoil) engine instance. The test harness manages the engine lifecycle (start, wait-for-socket, test, shutdown), validates event delivery, command execution, and callback queries against live game state, and produces structured reports in `/reports`. F# tests are built first; Python tests follow once F# basics are stable.

## Technical Context

**Language/Version**: F# / .NET 8.0 (primary test language), Python 3.10+ (secondary), C11 (proxy under test)
**Primary Dependencies**: Google.Protobuf (F#), betterproto (Python), xUnit (F# test framework), pytest (Python test framework)
**Storage**: Filesystem only (reports as markdown, no database)
**Testing**: xUnit for F# tests, pytest for Python tests, run via `dotnet test` and `pytest`
**Target Platform**: Linux (headless BAR engine requires Linux for CI; developer machines)
**Project Type**: Test suite + test harness
**Performance Goals**: Full F# suite completes in < 60 seconds including engine startup/shutdown
**Constraints**: Engine startup latency (5-15s typical), 25ms per-frame timeout, proxy uses Unix domain sockets by default
**Scale/Scope**: ~28 event types to validate, ~10 core command types, ~10 callback types, 2 client languages

## Constitution Check

*GATE: Must pass before Phase 0 research. Re-check after Phase 1 design.*

| Principle | Status | Notes |
| --------- | ------ | ----- |
| I. Zero Engine Modifications | PASS | Tests use the standard plugin interface; no engine patches |
| II. Binary Protocol First | PASS | Tests validate protobuf/socket protocol end-to-end; no JSON on hot path |
| III. Correctness Over Cleverness | PASS | Tests verify 1:1 struct mapping by checking field values through the full stack |
| IV. Test at the Boundary | PASS | This feature IS boundary testing -- engine struct → proto → wire → client struct |
| V. Latency Budget Discipline | PASS | Tests can measure round-trip timing but do not add overhead to the proxy |
| VI. Language-Agnostic by Default | PASS | Tests validate both F# and Python clients against the same proto schema |
| VII. Explicit Over Implicit | PASS | Test harness uses explicit config (socket path, timeouts) via environment variables |

No violations. Gate passes.

## Project Structure

### Documentation (this feature)

```text
specs/002-headless-test-suite/
├── plan.md              # This file
├── research.md          # Phase 0: headless engine setup, test frameworks
├── data-model.md        # Phase 1: test entities and state model
├── quickstart.md        # Phase 1: how to run the test suite
└── tasks.md             # Phase 2 output (created by /speckit.tasks)
```

### Source Code (repository root)

```text
tests/
├── integration/
│   ├── fsharp/
│   │   ├── HighBar.Tests.fsproj     # xUnit test project
│   │   ├── Harness.fs               # Engine lifecycle (start/stop/wait)
│   │   ├── ConnectionTests.fs       # P1: socket connect + handshake
│   │   ├── EventTests.fs            # P2: event delivery validation
│   │   ├── CommandTests.fs          # P2: command execution validation
│   │   ├── CallbackTests.fs         # P2: callback query validation
│   │   └── ScenarioTests.fs         # P2+: multi-step integration scenarios
│   └── python/
│       ├── conftest.py              # pytest fixtures (engine harness)
│       ├── test_connection.py       # P3: socket connect + handshake
│       ├── test_events.py           # P3: event delivery
│       ├── test_commands.py         # P3: command execution
│       └── test_callbacks.py        # P3: callback queries
├── fixtures/
│   ├── start-headless.sh           # Script to launch headless BAR + proxy
│   ├── stop-headless.sh            # Script to cleanly stop engine
│   └── game-setup.lua              # Minimal game scenario (map, teams, units)
└── README.md                        # Test suite documentation

reports/                              # Root-level reports directory
├── 001-initial-setup.md             # First iteration report
└── ...                              # Subsequent iteration reports
```

**Structure Decision**: Tests live in a top-level `tests/` directory (not under `proxy/tests/` which is C-only unit tests). The `tests/integration/` subdirectory separates integration tests from any future unit tests. The harness scripts in `tests/fixtures/` manage the headless engine lifecycle. Reports live at root level per spec requirement.

## Complexity Tracking

No constitution violations to justify.

## Implementation Phases

### Phase 1: Engine Harness + Smoke Tests (P1)

**Goal**: Get a headless BAR engine running as a subprocess, connect an F# client, complete a handshake, receive one frame, and shut down cleanly.

**Artifacts**:
- `tests/fixtures/start-headless.sh` -- launches `spring-headless` with minimal game config, waits for socket
- `tests/fixtures/stop-headless.sh` -- sends SIGTERM, waits for exit, cleans up stale socket
- `tests/fixtures/game-setup.lua` -- minimal startscript: small map, 2 teams, 1 builder unit per team
- `tests/integration/fsharp/Harness.fs` -- F# wrapper that calls start/stop scripts, polls for socket readiness
- `tests/integration/fsharp/ConnectionTests.fs` -- xUnit tests: connect, handshake, receive frame, disconnect

**Key decisions**:
- Engine startup is async; harness polls for socket existence with configurable timeout (default 30s)
- Each test class gets its own engine instance (test isolation) OR share one instance per test run (speed). Start with shared instance via xUnit `IClassFixture`.
- Socket path uses temp directory with random suffix to avoid conflicts: `/tmp/highbar-test-{guid}.sock`
- Engine process is tracked by PID; harness kills it in `Dispose()` even on test failure

**Exit criteria**: `dotnet test` starts engine, runs 1 handshake test, shuts down engine -- passes 10/10 times.

### Phase 2: Event Delivery Tests (P2)

**Goal**: Validate that events produced by the real engine arrive correctly in the F# client with all fields populated.

**Artifacts**:
- `tests/integration/fsharp/EventTests.fs` -- tests for Init, Update, UnitCreated, and other events that occur naturally in a minimal game

**Approach**:
- The minimal game scenario (builder unit on small map) naturally produces: Init, Update, UnitCreated, UnitFinished, UnitIdle
- More events require game manipulation via Lua commands or callback-triggered actions
- Start with events that occur naturally; expand coverage iteratively
- Each test asserts: event type matches expected, key fields are non-zero/non-null, field values are within plausible ranges

**Exit criteria**: Init, Update, UnitCreated, UnitIdle events received and parsed correctly.

### Phase 3: Command Execution Tests (P2)

**Goal**: Send commands from the F# client and verify the engine executes them (observable via subsequent events or callbacks).

**Artifacts**:
- `tests/integration/fsharp/CommandTests.fs` -- tests for Move, Stop, Build, Attack, Guard, Patrol

**Approach**:
- Send MoveCommand to builder unit, verify position changes via callback queries over subsequent frames
- Send StopCommand, verify unit stops moving
- Send BuildCommand, verify UnitCreated event for the building
- Commands that require enemy units (Attack, Guard) need the game scenario to include opposing teams
- Each test: send command → wait N frames → assert state change

**Exit criteria**: MoveCommand changes unit position; StopCommand halts unit; at least 4 command types verified.

### Phase 4: Callback Query Tests (P2)

**Goal**: Verify that callback queries return correct live game state.

**Artifacts**:
- `tests/integration/fsharp/CallbackTests.fs` -- tests for unit position, team resources, game frame number

**Approach**:
- Query unit position via callback, compare to position received in events
- Query team resources (metal, energy), verify non-negative numbers
- Query game frame number, verify it advances each frame
- Test invalid callback ID returns error response

**Exit criteria**: Unit position, resource, and frame queries return plausible values consistently.

### Phase 5: Python Client Tests (P3)

**Goal**: Port core test scenarios to Python, validating cross-language compatibility.

**Artifacts**:
- `tests/integration/python/conftest.py` -- pytest fixtures wrapping the same shell harness
- `tests/integration/python/test_connection.py`, `test_events.py`, `test_commands.py`, `test_callbacks.py`

**Approach**:
- Reuse the same `start-headless.sh`/`stop-headless.sh` scripts
- Python tests can share the engine instance with F# tests or run independently
- Focus on verifying protocol compatibility, not re-testing engine behavior

**Exit criteria**: Python client connects, handshakes, receives events, sends commands -- matching F# behavior.

### Phase 6: Reports and Iteration (P3)

**Goal**: Establish the `/reports` folder with structured iteration reports.

**Artifacts**:
- `reports/` directory with template and initial reports

**Report template**:
```markdown
# Report: [Title]
**Date**: YYYY-MM-DD
**Iteration**: N

## Context
[What was being worked on]

## Problem
[What went wrong or was unexpected]

## Investigation
[Steps taken to diagnose]

## Root Cause
[What was actually wrong]

## Solution
[What fixed it]

## Hypotheses
[Theories formed during investigation]

## Lessons Learned
[Knowledge gained that applies beyond this specific issue]
```

**Approach**: Reports are written during development, not generated automatically. Each significant problem or discovery gets its own report.

## Risk Register

| Risk | Impact | Mitigation |
| ---- | ------ | ---------- |
| Headless BAR engine not available on dev machine | Blocks all tests | Document installation steps in quickstart.md; provide skip-engine test mode using replay tool |
| Engine startup too slow (>30s) | Test suite exceeds 60s target | Share engine instance across test classes; increase timeout budget |
| Engine produces non-deterministic events | Flaky tests | Use range-based assertions (plausible values) not exact equality; retry logic for timing-sensitive tests |
| Socket cleanup fails on crash | Stale socket blocks next run | Harness checks for and removes stale sockets at startup |
| Game scenario doesn't produce needed events | Incomplete coverage | Iteratively expand game-setup.lua with more units, teams, and triggers |

## Dependencies

- **Headless BAR engine binary** (`spring-headless`): Must be installed and on PATH
- **HighBarV2 proxy plugin** (`SkirmishAI.so`): Must be compiled and installed to `~/.spring/AI/Skirmish/HighBarV2/0.1/`
- **F# client library** (`clients/fsharp/`): Must build successfully
- **Python client library** (`clients/python/`): Must be installable via `pip install -e .`
- **protobuf code generation**: `buf generate` must have been run
