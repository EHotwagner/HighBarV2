# Data Model: 023-fix-client-socket-hang

**Date**: 2026-04-06

This feature is a bug fix — no new data entities are introduced. The key entities are existing code artifacts being modified.

## Modified Entities

### HighBarClient (Client.fs)

| Attribute | Change | Description |
|-----------|--------|-------------|
| recvBytes | FIX | Check Read() return value for 0 (peer closed); throw EngineDisconnectedException |
| stream timeout | ADD | Set NetworkStream.ReadTimeout on connection establishment |
| timeout config | ADD | Read HIGHBAR_CLIENT_TIMEOUT_MS env var, accept constructor parameter |

### PersistentEngineFixture (PersistentHarness.fs)

| Attribute | Change | Description |
|-----------|--------|-------------|
| RunFrames | FIX | Catch EngineDisconnectedException; propagate as engine crash with diagnostics |
| ResetGameState | HARDEN | Check IsEngineAlive before attempting socket operations |

## New Types

### EngineDisconnectedException

| Attribute | Description |
|-----------|-------------|
| Inherits from | IOException |
| Message | Describes whether peer closed connection or read timed out |
| LastFrameNumber | Optional: the last successfully received frame number |

## State Transitions

```text
Connected → [Read returns 0] → Disconnected (peer closed)
Connected → [Read times out] → Disconnected (timeout)
Disconnected → [ThrowIfEngineCrashed] → Test fails with diagnostic info
Disconnected → [Next test starts] → Test skips via ThrowIfEngineCrashed
```
