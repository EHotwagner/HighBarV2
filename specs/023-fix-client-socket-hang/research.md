# Research: 023-fix-client-socket-hang

**Date**: 2026-04-06

## Decision 1: Socket Read Zero-Byte Detection

**Decision**: Check `NetworkStream.Read()` return value. When it returns 0, throw `EngineDisconnectedException` immediately.

**Rationale**: Per .NET documentation, `NetworkStream.Read()` returns 0 when the remote end has closed the connection. The current code adds the 0 return value to the `read` counter and loops forever (`0 + 0 + 0...`), consuming 87% CPU. This is the root cause of the hang.

**Alternatives considered**:
- Use `Socket.Poll()` before each read: Rejected — adds complexity. The zero-byte check is simpler and sufficient.
- Use `Socket.Available` property: Rejected — doesn't distinguish between "no data yet" and "connection closed".

## Decision 2: Timeout Mechanism

**Decision**: Set `NetworkStream.ReadTimeout` property to a configurable value (default 10000ms). This causes `Read()` to throw `IOException` when the timeout is exceeded.

**Rationale**: `NetworkStream.ReadTimeout` is the standard .NET mechanism for socket read timeouts. It uses the underlying `Socket.ReceiveTimeout` which is implemented via OS-level `SO_RCVTIMEO`. This is reliable, zero-overhead during normal operation (only triggers when data stops flowing), and doesn't require threading or async patterns.

**Alternatives considered**:
- Async reads with `CancellationToken` timeout: Rejected — requires converting the entire frame loop to async, which is a much larger change. The current sync loop is fine for the test harness use case.
- `Task.WaitAsync` wrapper around sync reads: Rejected — requires a background thread per read, adds complexity for no benefit over `ReadTimeout`.
- Application-level heartbeat with timer: Rejected — over-engineered for this use case. The proxy already has frame-level timeouts.

## Decision 3: Exception Type Design

**Decision**: Create a single `EngineDisconnectedException` type (inheriting from `IOException`) that covers both "peer closed" and "read timeout" scenarios. The exception message distinguishes the two cases.

**Rationale**: Callers (test harness) need to know "the engine is gone" — they don't need to distinguish between "engine closed socket cleanly" vs "engine stopped responding". Both result in the same recovery action: mark engine as dead, skip remaining tests.

**Alternatives considered**:
- Separate exception types for disconnect vs timeout: Rejected — callers would need to catch both; single type is simpler.
- Use existing `SocketException`: Rejected — too generic; callers can't distinguish engine disconnect from other socket errors.
- F# discriminated union Result type: Rejected — would require changing the entire API surface; exception is the established pattern in this codebase.

## Decision 4: Default Timeout Value

**Decision**: 10 seconds default, configurable via `HIGHBAR_CLIENT_TIMEOUT_MS` environment variable.

**Rationale**: 
- The proxy has a 500ms frame response timeout. If the engine is alive, frames arrive every ~33ms (30fps). A 10s timeout means ~300 missed frames before detection — extremely conservative.
- Callback responses may take longer during heavy scenarios (e.g., GetUnitDefs with 500+ defs). 10s covers these cases.
- The AI tier runs multi-minute games; 10s avoids false timeouts while still detecting actual disconnects promptly.

**Alternatives considered**:
- 5 seconds: Rejected — might false-trigger during expensive callbacks or game loading.
- 30 seconds: Rejected — too long to wait when engine has clearly died.
- 60 seconds: Rejected — defeats the purpose of prompt detection.

## Decision 5: Harness Recovery Strategy

**Decision**: Catch `EngineDisconnectedException` in `RunFrames`, set engine process to dead (which makes `IsEngineAlive` return false and `ThrowIfEngineCrashed()` throw on subsequent tests). No new mechanism needed — the existing liveness check infrastructure is sufficient.

**Rationale**: The `PersistentEngineFixture` already has `IsEngineAlive` (checks process status) and `ThrowIfEngineCrashed()` (throws with diagnostics). When the client detects disconnection, we just need to ensure `engineProcess` reflects the dead state. Since the engine process actually died (that's what caused the socket close), `Process.HasExited` should already be true — we just need to not hang in `RunFrames` before checking it.

**Alternatives considered**:
- Add a new `clientDisconnected` flag to the harness: Rejected — redundant with `IsEngineAlive` since the engine process is already dead.
- Add a watchdog timer in the harness: Rejected — the client-level timeout handles this; adding a second timer adds complexity.
