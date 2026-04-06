# Data Model: 024-fix-persistent-test-gaps

**Date**: 2026-04-06

This feature is a test fix — no new data entities are introduced. The key entities are existing test artifacts being modified.

## Modified Entities

### T9_MapTests (T9_MapTests.fs)

| Attribute | Change | Description |
|-----------|--------|-------------|
| queryInFrame | FIX | Remove silent exception swallow (`with _ -> ()`); let real errors propagate |
| T9.2 | FIX | Add `engine.ResetGameState()` before height map query |
| T9.3 | FIX | Add `engine.ResetGameState()` before start position query |
| T9.4 | FIX | Add `engine.ResetGameState()` before metal spots query |

### PersistentEngineFixture (PersistentHarness.fs)

| Attribute | Change | Description |
|-----------|--------|-------------|
| InitializeAsync | HARDEN | Catch EngineDisconnectedException in warm-up loops; delegate to ThrowIfEngineCrashed for diagnostics |

## New Entities

### EngineKillFixture (T10_EngineKillTests.fs)

| Attribute | Description |
|-----------|-------------|
| Implements | IAsyncLifetime (start engine on init, stop on dispose) |
| engineProcess | The engine process, publicly killable for test purposes |
| client | HighBarClient connected to the engine |
| KillEngine() | Sends SIGKILL to the engine process |
| socketPath | Unix domain socket path for client-proxy connection |

### T10_EngineKillTests (T10_EngineKillTests.fs)

| Test | Description |
|------|-------------|
| T10.1 | Kill engine during frame loop, assert EngineDisconnectedException within 10s |
| T10.2 | After kill, verify ThrowIfEngineCrashed fires immediately |
| T10.3 | Kill with HIGHBAR_CLIENT_TIMEOUT_MS=2000, verify detection within ~3s |
