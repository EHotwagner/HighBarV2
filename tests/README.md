# HighBarV2 Test Suite

Comprehensive test infrastructure for the HighBarV2 AI proxy bridge. Tests exercise the full stack: C proxy plugin, F# and Python clients, and live headless BAR (Recoil) engine integration.

## Quick Start

```bash
# Run all tests (auto-detects engine, skips engine tests if not available)
./tests/run-all.sh

# Run specific category
./tests/run-all.sh --category unit
./tests/run-all.sh --category integration

# Check prerequisites
./tests/check-prerequisites.sh

# Launch graphical test mode (needs display)
./tests/run-all.sh --graphical
```

## Test Categories

| Category | Directory | Engine Required | Framework | Description |
|----------|-----------|-----------------|-----------|-------------|
| **proxy** | `build/` (via ctest) | No | CTest | C proxy serialization/deserialization |
| **unit** | `tests/unit/fsharp/` | No | xUnit | F# command builder unit tests |
| **data** | `data/bar.tests/` | No | xUnit | BarData library validation |
| **integration** | `tests/integration/fsharp/` | Yes | xUnit | Connection, events, commands, callbacks |
| **persistent** | `tests/persistent/fsharp/` | Yes | xUnit | 40 tests sharing one engine (T0-T8 tiers) |
| **python** | `tests/integration/python/` | Yes | pytest | Cross-language protocol validation |
| **ai** | `tests/ai/fsharp/` | Yes | xUnit | AI validation (opt-in, long-running) |

## Configuration

All engine/game configuration is centralized in `tests/engine-version.json`:

```json
{
  "engine": { "version": "2025.06.19", "binary": "spring-headless" },
  "game": { "name": "Beyond All Reason test-29840-d9b7dba", "rapidTag": "byar:test" },
  "map": { "name": "Red Rock Desert v2" }
}
```

### Environment Variables

| Variable | Default | Description |
|----------|---------|-------------|
| `HIGHBAR_TEST_ENGINE` | (auto-detected) | Path to headless engine binary |
| `HIGHBAR_TEST_TIMEOUT` | `30` | Engine startup timeout in seconds |
| `HIGHBAR_TEST_MAP` | From engine-version.json | Map for test scenarios |
| `HIGHBAR_LOG_LEVEL` | `3` | Proxy log level (0=OFF, 3=DEBUG) |
| `SPRING_DATADIR` | (auto-detected) | Game content directory |

### Engine Auto-Detection

The test framework auto-detects the engine from standard BAR AppImage installations:
- Searches `~/.local/state/Beyond All Reason/engine/*/spring-headless`
- Derives `SPRING_DATADIR` from the engine's parent directory structure
- Copies archive cache for fast engine startup
- No manual configuration needed for standard installations

## Test Reports

Every test run generates a Markdown report at `reports/testreports/`:

```
reports/testreports/2026-04-04_16-30-00_all.md
```

Reports include environment details, per-tier results, failure diagnostics, and engine log excerpts.

## Prerequisites

1. **Headless BAR engine** (`spring-headless`) — auto-detected or set `HIGHBAR_TEST_ENGINE`
2. **HighBarV2 proxy plugin** compiled:
   ```bash
   cmake -B build -DCMAKE_BUILD_TYPE=Release proxy/
   cmake --build build
   ```
3. **Game content** — maps and game archives in the BAR data directory
4. **.NET 8 SDK** (for F# tests)
5. **Python 3.10+** with client installed (for Python tests): `cd clients/python && pip install -e .`

## How It Works

The test harness:
1. Validates prerequisites via `check-prerequisites.sh`
2. Creates unique socket paths per run (concurrent-safe)
3. Launches `spring-headless` with game scenario from `tests/fixtures/`
4. Manages engine lifecycle (start, health check, shutdown, cleanup)
5. Captures engine logs; surfaces excerpts on failure
6. Generates Markdown test report

### Game Setup Templates

Game scenarios in `tests/fixtures/game-setup*.txt` use template variables:
- `__GAME_TYPE__` — substituted from `engine-version.json`
- `__MAP_NAME__` — substituted from `engine-version.json` or `HIGHBAR_TEST_MAP`
- `__SOCKET_PATH__` — substituted with the unique socket path per run

## Troubleshooting

**Prerequisites check fails**: Run `./tests/check-prerequisites.sh` for detailed messages. Run `./tests/setup-engine.sh` to auto-download missing components.

**Engine fails to start**: Check session directory logs. Common causes: missing game content, wrong engine version, archive cache not found.

**Socket timeout**: Increase `HIGHBAR_TEST_TIMEOUT=90` for slow environments.

**Plugin not found**: Verify `libSkirmishAI.so`, `AIInfo.lua`, `AIOptions.lua` are in the engine's `AI/Skirmish/HighBarV2/stable/` directory.
