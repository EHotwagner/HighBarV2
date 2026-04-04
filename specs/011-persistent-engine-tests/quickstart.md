# Quickstart: Persistent Engine Test Suite

## Prerequisites

Run the existing prerequisite checker to verify engine and game content:

```bash
tests/check-prerequisites.sh
```

This validates: engine binary (`spring-headless`), engine version (2025.06.21), BAR game archive, and map file.

## Build

```bash
# Build the client library (dependency)
cd clients/fsharp && dotnet build && cd ../..

# Build the persistent test suite
cd tests/persistent/fsharp && dotnet build && cd ../../..
```

## Run Tests

```bash
# Run the full persistent engine test suite
cd tests/persistent/fsharp && dotnet test

# Run with verbose output to see test ordering and timing
cd tests/persistent/fsharp && dotnet test --logger "console;verbosity=detailed"

# Run only smoke tests (tier 0)
cd tests/persistent/fsharp && dotnet test --filter "FullyQualifiedName~T0_"
```

## Expected Behavior

1. Engine starts once (~10-20s startup)
2. Warm-up frames captured
3. Tests run in tier order: T0 (smoke) → T1 (spawn) → T2 (movement) → T3 (build) → T4 (combat) → T5 (scenario)
4. Between each test: cheat-based reset (~1-3s)
5. Engine shuts down after all tests complete
6. Total runtime: under 10 minutes

## Troubleshooting

- **Engine crash during tests**: Check `session-*/engine-stdout.log` in the test output directory
- **Reset verification failures**: May indicate engine cheat mode not enabled; verify game-setup.txt has spectator mode
- **Timeout failures**: Individual tests have frame-count limits; increase if engine runs slowly on your hardware
