# Quickstart: Fix Map Test Reliability

**Feature**: 025-fix-map-test-reliability

## Prerequisites

- .NET 10.0 SDK
- BAR headless engine (for running persistent tests)
- Proxy built with `cmake -B build -DCMAKE_BUILD_TYPE=Release proxy/ && cmake --build build`

## Build

```bash
# Build client library (verifies new methods compile)
cd clients/fsharp && dotnet build

# Build persistent tests
cd tests/persistent/fsharp && dotnet build

# Build integration tests
cd tests/integration/fsharp && dotnet build
```

## Test

```bash
# Run persistent map tests (requires live engine)
./tests/run-all.sh --category persistent

# Run integration tests
./tests/run-all.sh --category integration

# Quick verification: no more silent skips
grep -c "SKIP:" tests/persistent/fsharp/T9_MapTests.fs
# Should return 0 after changes
```

## Key Files

| File | Change |
|------|--------|
| `clients/fsharp/src/Client.fs` | Add `GetSlopeMap`, `GetLosMap`, `GetRadarMap`, `GetResourceMap` |
| `tests/persistent/fsharp/T9_MapTests.fs` | Replace silent skips with `Assert.Fail`, add T9.5-T9.8 |
| `tests/integration/fsharp/EventTests.fs` | Replace always-true assertion with logging |
