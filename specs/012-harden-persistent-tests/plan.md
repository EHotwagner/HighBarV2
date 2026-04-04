# Implementation Plan: Harden Persistent Engine Tests

**Branch**: `012-harden-persistent-tests` | **Date**: 2026-04-04 | **Spec**: [spec.md](spec.md)
**Input**: Feature specification from `/specs/012-harden-persistent-tests/spec.md`

## Summary

Fix the existing persistent engine tests (T3 build, T4 combat) that pass silently without asserting on engine events, add runtime unitDefId discovery so tests use correct IDs, add command coverage tests for all 17 command types, add an exhaustive unitDef spawn test (953 IDs in batches of 50), and add large-scale combat scenarios (100+ units). The full suite must remain under 10 minutes.

## Technical Context

**Language/Version**: F# / .NET 10.0  
**Primary Dependencies**: xUnit 2.x, HighBar.Client (in-repo), BarData (in-repo), Google.Protobuf 3.28  
**Storage**: Filesystem (session logs, temp directories)  
**Testing**: xUnit with custom test case orderer (PriorityOrderer from feature 011)  
**Target Platform**: Linux (spring-headless engine)  
**Project Type**: Integration test suite  
**Performance Goals**: Full suite under 10 minutes; exhaustive spawn under 2 minutes; large-scale scenarios under 3 minutes each  
**Constraints**: Single engine process for entire suite; cheat-based reset only; no engine modifications  
**Scale/Scope**: ~40-50 tests across 8+ tiers, 953 unitDefs probed

## Constitution Check

*GATE: Must pass before Phase 0 research. Re-check after Phase 1 design.*

| Principle | Status | Notes |
|-----------|--------|-------|
| I. Zero Engine Modifications | PASS | Tests use engine as-is via existing AI plugin interface |
| II. Binary Protocol First | PASS | Uses existing protobuf client library; no new protocols |
| III. Correctness Over Cleverness | PASS | Straightforward test fixes with explicit assertions |
| IV. Test at the Boundary | PASS | Tests exercise full serialization boundary through real engine |
| V. Latency Budget Discipline | N/A | Test suite, not production proxy code |
| VI. Language-Agnostic by Default | PASS | No protocol changes; tests consume existing F# client |
| VII. Explicit Over Implicit | PASS | UnitDefId discovery replaces implicit hardcoded guesses |

**Post-Phase 1 re-check**: All principles remain satisfied. No violations.

## Project Structure

### Documentation (this feature)

```text
specs/012-harden-persistent-tests/
├── plan.md              # This file
├── research.md          # Phase 0 output
├── data-model.md        # Phase 1 output
├── quickstart.md        # Phase 1 output
└── tasks.md             # Phase 2 output (created by /speckit.tasks)
```

### Source Code (repository root)

```text
tests/persistent/fsharp/
├── HighBar.PersistentTests.fsproj   # Updated compile order
├── PersistentHarness.fs             # Updated: UnitDefId discovery added to fixture
├── TestPriority.fs                  # Unchanged
├── T0_SmokeTests.fs                 # Minor: use discovered IDs
├── T1_SpawnTests.fs                 # Updated: use discovered IDs
├── T2_MovementTests.fs              # Updated: use discovered mobile unit IDs
├── T3_BuildTests.fs                 # REWRITTEN: real assertions on UnitFinished, UnitIdle
├── T4_CombatTests.fs                # REWRITTEN: real assertions on UnitDamaged, EnemyEnterLOS
├── T5_ScenarioTests.fs              # Updated: use discovered IDs
├── T6_CommandCoverage.fs            # NEW: all 17 command types tested
├── T7_ExhaustiveSpawn.fs            # NEW: 953 unitDefs in batches of 50
└── T8_LargeScaleCombat.fs           # NEW: 100+ units, 60s+ combat scenarios
```

**Structure Decision**: Add 3 new test files (T6, T7, T8) to the existing project. Rewrite T3/T4 in place. Update T0-T2, T5 to use discovered unitDefIds. The UnitDefId discovery logic lives in PersistentHarness.fs as part of the shared fixture.

## Key Design Decisions

### D1: UnitDefId Discovery in Fixture Init

During `PersistentEngineFixture.InitializeAsync()`, after warm-up, probe a small set of unitDefIds (e.g., 1-20) to find at least one builder, one armed unit, one mobile unit, and one building. Store results in the fixture as public properties. Tests access `engine.BuilderDefId`, `engine.ArmedUnitDefId`, etc.

For the exhaustive spawn test (T7), discovery of all 953 IDs is done within the test itself, not during fixture init (to keep startup fast).

### D2: Build Tests with Resource Boost

T3 build tests were failing because the builder had insufficient resources or too few frames. Fix: (1) send GiveMeResourceCommand to give 10000 metal + 10000 energy before building, (2) increase frame count to 500, (3) use a discovered builder unitDefId and a discovered buildable structure unitDefId.

### D3: Combat Tests with Positioned Units

T4 combat tests need units within weapon range. Fix: (1) spawn an armed friendly unit near the enemy commander's position (4608, 4096 from game-setup.txt), (2) use FightCommand to engage, (3) increase frame count to 200 for damage events, 400 for destruction.

### D4: Large-Scale Combat Approach

Spawn 100+ armed units at friendly position, then use FightCommand towards enemy base. Also spawn additional enemy-adjacent units if needed. Run for 1000+ frames (~60s game time at 30fps). Collect BattleMetrics during the run.

## Complexity Tracking

> No constitution violations to justify.

| Violation | Why Needed | Simpler Alternative Rejected Because |
|-----------|------------|-------------------------------------|
| *(none)* | | |
