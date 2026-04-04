# Quickstart: 013-diagnose-fix-test-gaps

## Prerequisites

- .NET 8.0 SDK
- CMake + C compiler
- Spring headless engine (`spring-headless`) in PATH
- BAR game content installed (`test-29833-ee0f96a`)

## Build

```bash
# Rebuild proxy after callback dispatch changes
cmake -B build -DCMAKE_BUILD_TYPE=Debug proxy/ && cmake --build build

# Regenerate proto if callbacks.proto changed
cd proto && buf lint && buf generate && cd ..

# Build F# client + tests
cd clients/fsharp && dotnet build
cd tests/persistent/fsharp && dotnet build
```

## Run Tests

```bash
# Kill any stale engine processes first
pkill -9 -x spring-headless 2>/dev/null || true

# Run all persistent tests
cd tests/persistent/fsharp && dotnet test --logger "console;verbosity=detailed"

# Run specific test tier
dotnet test --filter "FullyQualifiedName~T4_CombatTests"
```

## Debug Event Delivery

```bash
# Enable debug logging on proxy
export HIGHBAR_LOG_LEVEL=3

# Check engine log after test
cat /tmp/highbar-persistent-*/infolog.txt | grep -i "event\|damage\|LOS\|destroy"

# Check proxy stderr
cat /tmp/highbar-persistent-*/engine-stderr.log
```

## Key Files

| File | Purpose |
|------|---------|
| `proxy/src/callbacks.c` | Callback dispatch — add new cases here |
| `proxy/src/proxy.c` | Event handling, `handleEvent`, init sequence |
| `proxy/src/serialize.c` | Event serialization (all 28 types) |
| `proto/highbar/callbacks.proto` | Callback ID enum and message types |
| `clients/fsharp/src/Client.fs` | F# client — add callback query helpers |
| `tests/persistent/fsharp/PersistentHarness.fs` | Test fixture — update discovery logic |
| `tests/persistent/fsharp/T3_BuildTests.fs` | Build tests to strengthen |
| `tests/persistent/fsharp/T4_CombatTests.fs` | Combat tests to strengthen |
| `tests/persistent/fsharp/T7_ExhaustiveSpawn.fs` | Exhaustive spawn test |
| `tests/persistent/fsharp/T8_LargeScaleCombat.fs` | Large-scale combat test |
