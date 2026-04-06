# Quickstart: 022-live-headless-tests

## Prerequisites

- Headless engine available: `~/.local/state/Beyond All Reason/engine/*/spring-headless`
- Proxy built: `cmake -B build -DCMAKE_BUILD_TYPE=Release proxy/ && cmake --build build`
- F# client built: `cd clients/fsharp && dotnet build`

## Verify Current Test Baseline

Before making changes, capture the current test state:

```bash
# Run all non-engine tests (should all pass)
./tests/run-all.sh --category unit
./tests/run-all.sh --category proxy

# Run engine tests (captures current pass/fail baseline)
./tests/run-all.sh --category persistent
```

## Development Workflow

1. **Add new persistent tier test** → Run: `dotnet test tests/persistent/fsharp/`
2. **Verify live equivalent covers mock** → Compare test assertions side-by-side
3. **Delete mock test** → Rebuild proxy tests: `cd build && cmake .. && ctest`
4. **Run full suite** → `./tests/run-all.sh`

## Key Files

| Purpose | Path |
|---------|------|
| F# unit tests (to delete) | `tests/unit/fsharp/CommandBuilderTests.fs` |
| C proxy mocks (to triage) | `proxy/tests/test_serialize.c`, `test_deserialize.c`, `test_roundtrip.c`, `test_callbacks.c` |
| Mock engine (partial retain) | `proxy/tests/mock_engine.c` |
| Persistent fixture | `tests/persistent/fsharp/PersistentHarness.fs` |
| Command coverage | `tests/persistent/fsharp/T6_CommandCoverage.fs` |
| Combat tests | `tests/persistent/fsharp/T4_CombatTests.fs`, `T8_LargeScaleCombat.fs` |
| Combat verification | `tests/ai/fsharp/HeadlessCombatVerification.fs` |
| FSBarV1 reference (map tests) | `/home/developer/projects/FSBarV1/tests/FSBar.LiveTests/MapQueryTests.fs`, `MapGridTests.fs` |
| Test runner | `tests/run-all.sh` |

## Validation

After all changes:

```bash
# Full suite must pass with engine
./tests/run-all.sh

# Proxy tests must pass (retained mocks only)
./tests/run-all.sh --category proxy

# Verify no unit tier tests remain (or only non-mock ones)
./tests/run-all.sh --category unit
```
