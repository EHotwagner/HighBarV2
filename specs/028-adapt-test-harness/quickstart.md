# Quickstart: 028-adapt-test-harness

**Date**: 2026-04-07

## What this feature does

Replaces three duplicated test harness implementations with a single `EngineSession` abstraction in the `HighBar.Client` library. Adapts proven patterns from FSBarV1's `BarClient` — unified engine lifecycle, programmatic script generation, typed exceptions, PID-based orphan tracking, and centralized configuration.

## Key files to create/modify

### New files (in `clients/fsharp/src/`)
- `EngineConfig.fs` — Configuration record with defaults from `engine-version.json` + env var overrides
- `EngineLauncher.fs` — Process spawning, data dir detection, SIGTERM/SIGKILL shutdown
- `ScriptGenerator.fs` — Programmatic TDF script generation (replaces `game-setup.txt` sed templates)
- `EngineSession.fs` — State machine wrapping socket creation, engine launch, frame loop, cleanup
- `SessionDiagnostics.fs` — Log extraction for post-mortem analysis
- `EngineDisconnectedException.fs` — Typed exception with frame number and diagnostics

### Modified files
- `tests/integration/fsharp/Harness.fs` — Reduce to thin wrapper around `EngineSession`
- `tests/persistent/fsharp/PersistentHarness.fs` — Reduce to thin wrapper + verified state reset
- `tests/ai/fsharp/AiTestHarness.fs` — Reduce `GameOrchestrator` to use `EngineSession`
- `clients/fsharp/src/Client.fsproj` — Add new source files
- `tests/engine-version.json` — Remains as config source, now read by `EngineConfig.fromVersionFile()`

### Files to remove
- `tests/fixtures/start-headless.sh` — Replaced by `EngineLauncher`
- `tests/fixtures/stop-headless.sh` — Replaced by `EngineLauncher`
- `tests/fixtures/game-setup.txt` — Replaced by `ScriptGenerator`

### Files to keep unchanged
- `tests/check-prerequisites.sh` — Still useful as standalone CLI tool
- `tests/run-all.sh` — Test runner unchanged
- `clients/fsharp/src/Client.fs` — Protocol/connection code unchanged

## How to verify

```bash
# After each harness migration, run that category's tests:
./tests/run-all.sh --category integration   # After migrating Harness.fs
./tests/run-all.sh --category persistent    # After migrating PersistentHarness.fs  
./tests/run-all.sh --category ai            # After migrating AiTestHarness.fs (optional)

# Full regression:
./tests/run-all.sh
```

## Architecture sketch

```
EngineConfig (record)
  ├── fromVersionFile() ← tests/engine-version.json
  └── env var overrides ← HIGHBAR_TEST_ENGINE, SPRING_DATADIR, etc.
        │
        ▼
EngineSession (class, IDisposable)
  ├── Start() → EngineLauncher.launch() + socket bind/accept + handshake
  ├── Step() / Run() → frame loop (delegates to HighBarClient)
  ├── GetDiagnostics() → SessionDiagnostics
  └── Stop() → SIGTERM/SIGKILL + cleanup (preserve session dir on failure)
        │
        ▼
Test Fixtures (thin wrappers)
  ├── EngineFixture: IAsyncLifetime → EngineSession + warm-up frames
  ├── PersistentEngineFixture: IAsyncLifetime → EngineSession + reset logic
  └── GameOrchestrator → EngineSession per game + metrics collection
```
