# Implementation Plan: Persistent Engine Test Suite

**Branch**: `011-persistent-engine-tests` | **Date**: 2026-04-03 | **Spec**: [spec.md](spec.md)
**Input**: Feature specification from `/specs/011-persistent-engine-tests/spec.md`

## Summary

Create a new F# xUnit test suite that runs against a single persistent game engine instance, using cheat commands (CallLuaRulesCommand, GiveMeResourceCommand) to reset game state between tests instead of restarting the engine. Tests are organized in tiers of increasing complexity (smoke → spawn → movement → build → combat → scenario) with deterministic ordering. The entire suite must complete within 10 minutes.

## Technical Context

**Language/Version**: F# / .NET 10.0  
**Primary Dependencies**: xUnit 2.x, HighBar.Client (in-repo), BarData (in-repo), Google.Protobuf 3.28  
**Storage**: Filesystem (session logs, temp directories)  
**Testing**: xUnit with custom test case orderer  
**Target Platform**: Linux (spring-headless engine)  
**Project Type**: Integration test suite  
**Performance Goals**: Full suite under 10 minutes; individual reset under 5 seconds; startup under 30 seconds  
**Constraints**: Single engine process for entire suite; cheat-based reset only; no engine modifications  
**Scale/Scope**: ~20-40 tests across 6 tiers, growing until 10-minute budget is consumed

## Constitution Check

*GATE: Must pass before Phase 0 research. Re-check after Phase 1 design.*

| Principle | Status | Notes |
|-----------|--------|-------|
| I. Zero Engine Modifications | PASS | Tests use engine as-is via standard AI plugin interface |
| II. Binary Protocol First | PASS | Uses existing protobuf client library; no new protocols |
| III. Correctness Over Cleverness | PASS | Straightforward test fixture with explicit reset sequence |
| IV. Test at the Boundary | PASS | Tests exercise the full serialization boundary through a real engine |
| V. Latency Budget Discipline | N/A | Test suite, not production proxy code |
| VI. Language-Agnostic by Default | PASS | No protocol changes; tests consume existing F# client |
| VII. Explicit Over Implicit | PASS | Reset sequence is explicit; test ordering is deterministic via compile order and priority attributes |

**Post-Phase 1 re-check**: All principles remain satisfied. No violations.

## Project Structure

### Documentation (this feature)

```text
specs/011-persistent-engine-tests/
├── plan.md              # This file
├── research.md          # Phase 0 output
├── data-model.md        # Phase 1 output
├── quickstart.md        # Phase 1 output
└── tasks.md             # Phase 2 output (created by /speckit.tasks)
```

### Source Code (repository root)

```text
tests/persistent/fsharp/
├── HighBar.PersistentTests.fsproj   # New test project
├── PersistentHarness.fs             # Engine fixture with cheat-based reset
├── TestPriority.fs                  # Priority attribute + custom orderer
├── T0_SmokeTests.fs                 # Reset validation, engine health
├── T1_SpawnTests.fs                 # Unit creation via GiveMeNewUnit
├── T2_MovementTests.fs              # Move commands, position verification
├── T3_BuildTests.fs                 # Build commands, UnitCreated events
├── T4_CombatTests.fs                # Attack, damage, destruction events
└── T5_ScenarioTests.fs              # Multi-step AI sequences

tests/fixtures/                       # Existing (shared with integration tests)
├── start-headless.sh
├── stop-headless.sh
└── game-setup.txt
```

**Structure Decision**: New test project under `tests/persistent/fsharp/` parallel to existing `tests/integration/fsharp/`. Shares the existing fixtures (start/stop scripts, game-setup.txt) but has its own harness with reset semantics. This avoids any interference with the existing integration test lifecycle.

## Key Design Decisions

### D1: Persistent Fixture with Reset Helper

The `PersistentEngineFixture` class extends the existing harness pattern but adds a `ResetGameState()` method that:
1. Sends `CallLuaRulesCommand` to destroy all units via Lua (`Spring.DestroyUnit`)
2. Sends `GiveMeResourceCommand` to zero out and then set baseline resources
3. Runs a brief verification loop (5-10 frames) to confirm clean state

Each test calls `ResetGameState()` in its setup (or the fixture provides it via a shared pattern). This keeps each test isolated without engine restart.

### D2: Test Ordering via Compile Order + Priority

F# xUnit respects `<Compile>` order in the .fsproj for test class execution within a collection. Combined with a simple `[<Priority(N)>]` attribute and custom `ITestCaseOrderer`, this gives fully deterministic execution: T0 smoke tests run first, T5 scenarios run last.

### D3: Frame Loop Adaptation

The existing integration tests use a "run N frames and collect events" pattern with exception-based termination (`"CAPTURED_ENOUGH"`). The persistent suite uses the same pattern but must handle the fact that frame numbers continue across tests (they don't reset to 0). Tests should track relative frame counts, not absolute ones.

### D4: Incremental Test Growth

Start with T0 (smoke: 3-5 tests) and T1 (spawn: 3-5 tests). Run the suite, measure timing. Add T2-T5 incrementally, checking total runtime after each tier. Stop adding tests when approaching the 10-minute budget.

## Complexity Tracking

> No constitution violations to justify.

| Violation | Why Needed | Simpler Alternative Rejected Because |
|-----------|------------|-------------------------------------|
| *(none)* | | |
