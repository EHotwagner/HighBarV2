# Quickstart: Harden Persistent Engine Tests

## Prerequisites

Same as feature 011 — run the prerequisite checker:

```bash
tests/check-prerequisites.sh
```

## Build

```bash
cd clients/fsharp && dotnet build && cd ../..
cd tests/persistent/fsharp && dotnet build && cd ../../..
```

## Run Tests

```bash
# Run the full persistent test suite (all tiers)
cd tests/persistent/fsharp && dotnet test

# Run smoke tests (includes discovery validation)
cd tests/persistent/fsharp && dotnet test --filter "FullyQualifiedName~T0_"

# Run spawn tests
cd tests/persistent/fsharp && dotnet test --filter "FullyQualifiedName~T1_"

# Run movement tests
cd tests/persistent/fsharp && dotnet test --filter "FullyQualifiedName~T2_"

# Run build tests (hard assertions on UnitCreated, UnitFinished, UnitIdle)
cd tests/persistent/fsharp && dotnet test --filter "FullyQualifiedName~T3_"

# Run combat tests (hard assertions on damage, destroy, EnemyEnterLOS)
cd tests/persistent/fsharp && dotnet test --filter "FullyQualifiedName~T4_"

# Run scenario tests
cd tests/persistent/fsharp && dotnet test --filter "FullyQualifiedName~T5_"

# Run command coverage tests (all 17 command types)
cd tests/persistent/fsharp && dotnet test --filter "FullyQualifiedName~T6_CommandCoverage"

# Run exhaustive unitDef spawn test (all 953 unitDefs)
cd tests/persistent/fsharp && dotnet test --filter "FullyQualifiedName~T7_ExhaustiveSpawn"

# Run large-scale combat scenarios (100+ units)
cd tests/persistent/fsharp && dotnet test --filter "FullyQualifiedName~T8_"

# Run with verbose output for debugging
cd tests/persistent/fsharp && dotnet test --logger "console;verbosity=detailed"
```

## Expected Behavior

1. Engine starts once (~17s startup)
2. UnitDefId discovery runs during fixture init (probes IDs 1-20, extends to 1-50 if needed)
3. Tests run in tier order: T0 → T1 → T2 → T3 → T4 → T5 → T6 → T7 → T8
4. T3 tests assert on real events (UnitCreated, UnitFinished, UnitIdle) with 500-frame runs
5. T4 tests assert on real events (UnitDamaged, EnemyDamaged, EnemyEnterLOS, UnitDestroyed) with 200-400 frame runs
6. T6 tests cover all 17 command types with 60s timeouts
7. T7 exhaustive spawn test processes 953 unitDefs in ~19 batches of 50
8. T8 large-scale combat spawns 100+ armed units with 180s timeouts
9. Total runtime: under 10 minutes

## Test Tiers

| Tier | File | Description |
|------|------|-------------|
| T0 | T0_SmokeTests.fs | Smoke tests, discovery validation |
| T1 | T1_SpawnTests.fs | Unit spawning via discovered IDs |
| T2 | T2_MovementTests.fs | Movement commands |
| T3 | T3_BuildTests.fs | Build tests with hard event assertions |
| T4 | T4_CombatTests.fs | Combat tests with hard event assertions |
| T5 | T5_ScenarioTests.fs | Multi-step scenarios |
| T6 | T6_CommandCoverage.fs | All 17 command types |
| T7 | T7_ExhaustiveSpawn.fs | 953 unitDef spawn test |
| T8 | T8_LargeScaleCombat.fs | 100+ unit stress test |

## Troubleshooting

- **UnitFinished not received**: Ensure builder has enough resources (test sends GiveMeResourceCommand 10000 metal+energy before building). Increase frame count beyond 500.
- **EnemyEnterLOS not received**: Move friendly unit closer to enemy start position (4608, 4096). Increase frame count beyond 200.
- **Exhaustive spawn batch failure**: Check engine logs in session directory for the specific unitDefId range that failed.
- **Large-scale combat timeout**: Reduce unit count or frame count if engine is too slow.
- **Discovery finds no buildings**: The first 20 BarData entries may all be aircraft/mobile. Discovery auto-extends to 50 IDs in this case.
