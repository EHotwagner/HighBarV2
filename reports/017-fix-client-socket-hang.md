# Report: Fix Client Socket Hang on Engine Death

**Date**: 2026-04-06
**Iteration**: 023
**Branch**: `023-fix-client-socket-hang`

## Context

The F# `HighBarClient` would hang indefinitely at 87% CPU when the engine process died during a test run. The `recvBytes` function in `Client.fs` loops on `NetworkStream.Read()`, which returns 0 when the peer closes the connection. Since the return value was added to a counter without checking for zero, the loop became infinite: `0 + 0 + 0...`.

## Problem

Two symptoms:
1. **Client hangs forever**: `recvBytes` spins in a tight loop consuming 87% CPU when the engine proxy closes the socket.
2. **Test process never exits**: The persistent test harness (`PersistentHarness.fs`) has no mechanism to detect or recover from client disconnection, so `RunFrames` blocks indefinitely.

## Investigation

### Root cause in Client.fs (lines 33-40, before fix)

```fsharp
let recvBytes (s: NetworkStream) : byte[] =
    let headerBuf = Array.zeroCreate<byte> 4
    let mutable read = 0
    while read < 4 do
        read <- read + s.Read(headerBuf, read, 4 - read)  // Returns 0 on peer close
    // ... same pattern for data buffer
```

Per .NET documentation, `NetworkStream.Read()` returns 0 when the remote end closes the connection. The code adds 0 to `read` and loops forever.

### No timeout mechanism

The `NetworkStream` had no `ReadTimeout` set, so even if the engine stalled (rather than dying), the read would block indefinitely with no upper bound.

## Solution

### 1. Zero-byte detection in `recvBytes` (Client.fs)

Extracted a `readFully` helper that checks the return value of each `Read()` call:
- Returns 0 -> throw `EngineDisconnectedException("Engine proxy closed connection")`
- Throws `IOException` (timeout) -> wrap as `EngineDisconnectedException("Engine proxy read timeout")`

### 2. New exception type: `EngineDisconnectedException`

- Inherits from `System.IO.IOException`
- Carries an optional `LastFrameNumber` property for diagnostics
- Message distinguishes peer-closed vs timeout scenarios
- Single type simplifies caller logic (both cases mean "engine is gone")

### 3. Configurable read timeout

- `NetworkStream.ReadTimeout` set in `Connect`, `AcceptFrom`, and `WrapSocket`
- Default: 10000ms (conservative; frames normally arrive every ~33ms)
- Configurable via `HIGHBAR_CLIENT_TIMEOUT_MS` environment variable
- Overridable via optional `readTimeoutMs` constructor parameter

### 4. Test harness recovery (PersistentHarness.fs)

- `RunFrames`: catches `EngineDisconnectedException`, fails with diagnostic message including last frame number and frame count
- `ResetGameState`: checks `IsEngineAlive` before attempting socket operations; catches `EngineDisconnectedException`
- `RunFramesWithEventLog`: inherits protection via delegation to `RunFrames`

## Files Modified

| File | Changes |
|------|---------|
| `clients/fsharp/src/Client.fs` | Added `EngineDisconnectedException` type, fixed `recvBytes`, added timeout to all connection methods, added configurable timeout via env var + constructor param |
| `tests/persistent/fsharp/PersistentHarness.fs` | Added disconnect catch in `RunFrames`, added liveness guard in `ResetGameState` |

## Test Results

| Tier | Result | Notes |
|------|--------|-------|
| C Proxy (ctest) | 2/2 passed | No impact |
| BarData | 135/135 passed | No impact |
| F# Integration | 35/35 passed | Timeout does not cause false failures |
| F# Persistent | 45/47 passed | 2 pre-existing failures (see below) |

### Pre-existing failures: T9.3, T9.4

Two map tests (`T9.3 Start position`, `T9.4 Metal spots`) fail when run as part of the full persistent suite but **pass when run in isolation** with a fresh engine. This confirms a test state pollution issue unrelated to this fix:

- The persistent test suite shares one engine instance across 47 tests
- Earlier tests (combat spawning, unit destruction) leave game state that affects map callback results
- `ResetGameState` cleans up units and resources but may not fully restore map query state
- The map callbacks themselves work correctly (proven by isolated pass)

This is a candidate for a future fix (improved test isolation or test ordering) but is out of scope for this bug fix.

## Hypotheses

1. **Zero-byte read is the sole root cause** -- Confirmed. The `while read < 4` loop with `read <- read + s.Read(...)` spins when `Read()` returns 0.
2. **Timeout alone would fix it** -- Partially. Timeout handles the "engine stalled" case, but zero-byte detection is needed for the "engine died cleanly" case (socket closed, `Read()` returns 0 immediately without waiting for timeout).
3. **T9 map test failures are state pollution** -- Confirmed. They pass in isolation with a fresh engine, fail only after 45 other tests run against the same engine instance.

## Lessons Learned

1. **Always check `Read()` return value for 0** in socket loops. This is a well-known .NET pattern but easy to miss. The zero return is not an error -- it's the standard EOF signal.
2. **`NetworkStream.ReadTimeout` is low-cost insurance.** It uses OS-level `SO_RCVTIMEO`, adds zero overhead during normal operation, and provides a bounded wait for any unexpected stall.
3. **Persistent test fixtures need careful state management.** Sharing one engine across many tests is efficient but fragile. Map query state may not be fully reset by the current `ResetGameState` implementation.
