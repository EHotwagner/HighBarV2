# Quickstart: Headless Test Suite

**Feature**: 002-headless-test-suite | **Date**: 2026-04-02

## Prerequisites

1. **Headless BAR engine** installed and on PATH:
   ```bash
   which spring-headless  # Must resolve
   ```

2. **HighBarV2 proxy plugin** compiled and installed:
   ```bash
   # Build the proxy
   cmake -B build -DCMAKE_BUILD_TYPE=Release proxy/
   cmake --build build

   # Install to engine plugin directory
   mkdir -p ~/.spring/AI/Skirmish/HighBarV2/0.1/
   cp build/SkirmishAI.so ~/.spring/AI/Skirmish/HighBarV2/0.1/
   cp proxy/data/AIInfo.lua ~/.spring/AI/Skirmish/HighBarV2/0.1/
   cp proxy/data/AIOptions.lua ~/.spring/AI/Skirmish/HighBarV2/0.1/
   ```

3. **Proto code generation** completed:
   ```bash
   buf generate proto/
   ```

4. **.NET 8 SDK** installed (for F# tests):
   ```bash
   dotnet --version  # Must be 8.0+
   ```

5. **Python 3.10+** with client installed (for Python tests):
   ```bash
   cd clients/python && pip install -e .
   ```

## Running F# Tests

```bash
# Run full F# integration test suite
dotnet test tests/integration/fsharp/

# Run specific test category
dotnet test tests/integration/fsharp/ --filter "Category=Connection"
dotnet test tests/integration/fsharp/ --filter "Category=Events"
dotnet test tests/integration/fsharp/ --filter "Category=Commands"
dotnet test tests/integration/fsharp/ --filter "Category=Callbacks"
```

The test harness automatically:
1. Creates a unique socket path (`/tmp/highbar-test-{uuid}.sock`)
2. Launches `spring-headless` with the test game scenario
3. Waits for the proxy socket to become ready (up to 30s)
4. Runs the tests
5. Shuts down the engine and cleans up

## Running Python Tests

```bash
# Run full Python integration test suite
cd tests/integration/python/
pytest

# Run specific test file
pytest test_connection.py
pytest test_events.py
```

## Configuration

Override defaults via environment variables:

| Variable | Default | Description |
| -------- | ------- | ----------- |
| `HIGHBAR_TEST_ENGINE` | `spring-headless` | Path to headless engine binary |
| `HIGHBAR_TEST_TIMEOUT` | `30` | Engine startup timeout in seconds |
| `HIGHBAR_TEST_MAP` | (smallest available) | Map to use for test scenarios |
| `HIGHBAR_LOG_LEVEL` | `3` | Proxy log level (0=OFF, 1=ERROR, 2=INFO, 3=DEBUG) |

## Troubleshooting

**Engine fails to start**: Verify `spring-headless` is installed and the game content (maps, units) is available. Check `~/.spring/infolog.txt` for engine errors.

**Socket timeout**: The engine may take longer to start on first run (downloading content). Increase `HIGHBAR_TEST_TIMEOUT`.

**Stale socket error**: If a previous test crashed, the socket file may still exist. The harness automatically cleans stale sockets, but you can manually remove: `rm /tmp/highbar-test-*.sock`

**Plugin not found**: Verify `SkirmishAI.so`, `AIInfo.lua`, and `AIOptions.lua` are in `~/.spring/AI/Skirmish/HighBarV2/0.1/`.

## Reports

Test development reports are written to `/reports/` at the repository root. Each report follows a structured template documenting problems encountered, investigations, solutions, and lessons learned during iterative test development.
