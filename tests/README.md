# HighBarV2 Integration Test Suite

End-to-end integration tests that exercise the full HighBarV2 stack: F# and Python clients connecting through the C proxy plugin running inside a real headless BAR (Recoil) engine instance.

## Prerequisites

1. **Headless BAR engine** (`spring-headless`) installed and on PATH
2. **HighBarV2 proxy plugin** compiled and installed:
   ```bash
   cmake -B build -DCMAKE_BUILD_TYPE=Release proxy/
   cmake --build build
   mkdir -p ~/.spring/AI/Skirmish/HighBarV2/0.1/
   cp build/SkirmishAI.so ~/.spring/AI/Skirmish/HighBarV2/0.1/
   cp proxy/data/AIInfo.lua ~/.spring/AI/Skirmish/HighBarV2/0.1/
   cp proxy/data/AIOptions.lua ~/.spring/AI/Skirmish/HighBarV2/0.1/
   ```
3. **Protobuf code generation** completed: `buf generate proto/`
4. **.NET 8 SDK** (for F# tests): `dotnet --version` must be 8.0+
5. **Python 3.10+** with client installed (for Python tests): `cd clients/python && pip install -e .`

## Running F# Tests

```bash
# Full suite
dotnet test tests/integration/fsharp/

# By category
dotnet test tests/integration/fsharp/ --filter "Category=Harness"
dotnet test tests/integration/fsharp/ --filter "Category=Connection"
dotnet test tests/integration/fsharp/ --filter "Category=Events"
dotnet test tests/integration/fsharp/ --filter "Category=Commands"
dotnet test tests/integration/fsharp/ --filter "Category=Callbacks"
dotnet test tests/integration/fsharp/ --filter "Category=Scenarios"
```

## Running Python Tests

```bash
cd tests/integration/python/
pytest
pytest test_connection.py
pytest test_events.py
pytest test_commands.py
pytest test_callbacks.py
```

## Configuration

| Variable | Default | Description |
| -------- | ------- | ----------- |
| `HIGHBAR_TEST_ENGINE` | `spring-headless` | Path to headless engine binary |
| `HIGHBAR_TEST_TIMEOUT` | `30` | Engine startup timeout in seconds |
| `HIGHBAR_TEST_MAP` | `Comet Catcher Remake 1.8` | Map to use for test scenarios |
| `HIGHBAR_LOG_LEVEL` | `3` | Proxy log level (0=OFF, 1=ERROR, 2=INFO, 3=DEBUG) |
| `HIGHBAR_SOCKET_PATH` | (auto-generated) | Override socket path (normally auto-generated per run) |

## How It Works

The test harness automatically:
1. Creates a unique socket path (`/tmp/highbar-test-{guid}.sock`)
2. Launches `spring-headless` with a minimal game scenario (`tests/fixtures/game-setup.lua`)
3. Waits for the proxy socket to become ready (configurable timeout)
4. Runs the tests against the live engine
5. Shuts down the engine and cleans up socket/PID files

## Troubleshooting

**Engine fails to start**: Verify `spring-headless` is installed and game content (maps, units) is available. Check `~/.spring/infolog.txt` for engine errors.

**Socket timeout**: Engine may take longer on first run (downloading content). Increase `HIGHBAR_TEST_TIMEOUT`.

**Stale socket**: If a previous test crashed, the harness auto-cleans stale sockets. Manual cleanup: `rm /tmp/highbar-test-*.sock`

**Plugin not found**: Verify `SkirmishAI.so`, `AIInfo.lua`, and `AIOptions.lua` are in `~/.spring/AI/Skirmish/HighBarV2/0.1/`.

**Build errors**: Ensure `buf generate proto/` has been run and `clients/fsharp/` builds successfully.

## Test Categories

| Category | Phase | Description |
| -------- | ----- | ----------- |
| Harness | P1 | Engine lifecycle smoke test |
| Connection | P1 | Socket connect, handshake, frame loop |
| Events | P2 | Event delivery and parsing |
| Commands | P2 | Command execution verification |
| Callbacks | P2 | Callback query validation |
| Scenarios | P2+ | Multi-step integration scenarios |

## CI Integration

To run the test suite in a CI environment:

1. **Install spring-headless**: Download the BAR headless engine binary for your CI platform (Linux x64). Add to PATH.
2. **Install game content**: The engine needs maps and unit definitions. Either pre-install BAR game content or provide a minimal content pack.
3. **Build and install the proxy plugin**:
   ```bash
   cmake -B build -DCMAKE_BUILD_TYPE=Release proxy/
   cmake --build build
   mkdir -p ~/.spring/AI/Skirmish/HighBarV2/0.1/
   cp build/SkirmishAI.so ~/.spring/AI/Skirmish/HighBarV2/0.1/
   cp proxy/data/AIInfo.lua ~/.spring/AI/Skirmish/HighBarV2/0.1/
   cp proxy/data/AIOptions.lua ~/.spring/AI/Skirmish/HighBarV2/0.1/
   ```
4. **Generate protobuf code**: `buf generate proto/`
5. **Set timeouts**: CI environments may be slower. Set `HIGHBAR_TEST_TIMEOUT=60` for generous engine startup time.
6. **Run F# tests**: `dotnet test tests/integration/fsharp/ --logger "console;verbosity=normal"`
7. **Run Python tests**: `cd tests/integration/python && pytest -v`

**CI-specific concerns**:
- Ensure `/tmp` is writable for Unix domain sockets
- If running in containers, the engine may need `--headless` flag compatibility with the container's graphics stack (no GPU required)
- Parallel CI jobs must not share socket paths (the test harness uses unique paths by default)
- Set `HIGHBAR_LOG_LEVEL=1` in CI to reduce log noise

## Reports

Iteration reports are written to `/reports/` at the repository root during test development. Each captures problems, investigations, and lessons learned.
