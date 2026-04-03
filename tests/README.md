# HighBarV2 Integration Test Suite

End-to-end integration tests that exercise the full HighBarV2 stack: F# and Python clients connecting through the C proxy plugin running inside a real headless BAR (Recoil) engine instance.

## Quick Start

```bash
# 1. Check prerequisites
./tests/check-prerequisites.sh

# 2. Install missing components (automated)
./tests/setup-engine.sh

# 3. Run tests
dotnet test tests/integration/fsharp/
cd tests/integration/python && pytest
```

## Prerequisites

### Automated Check

Run `tests/check-prerequisites.sh` to validate your environment. It checks:

1. **Engine binary** (`spring-headless`) — on PATH or at `HIGHBAR_TEST_ENGINE`
2. **Engine version** — matches the pinned version in `tests/engine-version.json`
3. **Game archive** — BAR game content in `SPRING_DATADIR`
4. **Map file** — test map in `SPRING_DATADIR/maps/`

```bash
# Human-readable output
./tests/check-prerequisites.sh

# Machine-parseable JSON
./tests/check-prerequisites.sh --json
```

Exit codes: `0` = all passed, `1` = prerequisites missing, `2` = script error.

### Automated Setup

Run `tests/setup-engine.sh` to automatically download missing components:

- Downloads the game archive via `pr-downloader` if missing
- Provides download instructions for engine binary and maps

### Manual Setup

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

## Engine Version Configuration

The file `tests/engine-version.json` pins the exact engine, game, and map versions used by tests:

```json
{
  "engine": { "version": "...", "binary": "spring-headless", "downloadUrl": "..." },
  "game": { "name": "...", "rapidTag": "..." },
  "map": { "name": "..." }
}
```

Both the prerequisite check script and setup script read this file. Update it when validating a new engine version.

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
| `SPRING_DATADIR` | `~/.spring` | Game content directory (maps, game archives) |

## How It Works

The test harness automatically:
1. Runs `check-prerequisites.sh` to validate the environment
2. Creates a unique socket path (`/tmp/highbar-test-{guid}.sock`)
3. Creates a per-session temporary directory for engine logs
4. Launches `spring-headless` with the game scenario (`tests/fixtures/game-setup.lua`)
5. Redirects engine stdout/stderr to log files in the session directory
6. Waits for the proxy socket to become ready (configurable timeout)
7. Monitors engine process health during test execution
8. Runs the tests against the live engine
9. On failure: surfaces engine log excerpts (last 50 lines) in test output
10. Shuts down the engine and cleans up socket/PID/session files

### Session Directory

Each test run creates a temporary session directory containing:
- `engine-stdout.log` — engine standard output
- `engine-stderr.log` — engine standard error
- `infolog.txt` — engine's own log file (via `--write-dir`)

On test failure or engine crash, relevant excerpts are automatically included in the test output.

### Victory Condition Disable

The game scenario (`tests/fixtures/game-setup.lua`) sets `GameMode=3` to disable all victory conditions. This ensures the game stays alive indefinitely until the test harness terminates it, preventing premature game-over events during testing.

## Troubleshooting

**Prerequisites check fails**: Run `./tests/check-prerequisites.sh` for detailed error messages with resolution steps. Run `./tests/setup-engine.sh` to auto-download missing components.

**Engine fails to start**: Verify `spring-headless` is installed and game content (maps, units) is available. Check the session directory logs for engine errors.

**Socket timeout**: Engine may take longer on first run (downloading content). Increase `HIGHBAR_TEST_TIMEOUT`.

**Stale socket**: If a previous test crashed, the harness auto-cleans stale sockets. Manual cleanup: `rm /tmp/highbar-test-*.sock`

**Plugin not found**: Verify `SkirmishAI.so`, `AIInfo.lua`, and `AIOptions.lua` are in `~/.spring/AI/Skirmish/HighBarV2/0.1/`.

**Build errors**: Ensure `buf generate proto/` has been run and `clients/fsharp/` builds successfully.

**Engine crashes mid-test**: Check the diagnostic output in the test failure message — it includes engine-stderr.log and infolog.txt excerpts. Common causes: missing game content, incompatible engine version, missing AI plugin files.

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

1. **Check prerequisites**: `./tests/check-prerequisites.sh --json`
2. **Setup engine**: `./tests/setup-engine.sh`
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
