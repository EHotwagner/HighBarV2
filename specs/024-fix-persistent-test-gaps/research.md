# Research: 024-fix-persistent-test-gaps

**Date**: 2026-04-06

## Decision 1: T9 Map Test Root Cause

**Decision**: The T9.3/T9.4 failures are caused by missing `ResetGameState()` calls and a silent exception swallow in `queryInFrame`.

**Rationale**: 
- T9.1 (Priority 1) calls `ResetGameState()` before map queries and passes. T9.3 (Priority 3) and T9.4 (Priority 4) do not call `ResetGameState()` and fail in the full suite.
- The `queryInFrame` helper catches ALL exceptions with `with _ -> ()` (line 27 of T9_MapTests.fs), silently swallowing errors from `RunFrames`. If the engine state causes a callback failure, the query returns `None` and the test prints "SKIP" instead of the actual error.
- When run in isolation (fresh engine, no prior tests), both T9.3 and T9.4 pass because there's no accumulated state to cause problems.
- The xUnit `PriorityOrderer` orders tests within a class (not across classes), so T8's large-scale combat may run before T9, leaving hundreds of unit events in the engine's tracking state.

**Alternatives considered**:
- Engine-level map data corruption: Rejected — map callbacks (GetStartPos, GetMetalSpots) return static map data that doesn't depend on unit state. The issue is in the test harness, not the engine.
- xUnit parallel execution interference: Rejected — all persistent tests are in the same `[<Collection("PersistentEngine")>]` which serializes them.

## Decision 2: Engine-Kill Test Architecture

**Decision**: Create a standalone test file (`T10_EngineKillTests.fs`) with its own fixture that starts and owns a separate engine instance. Do NOT use the shared `PersistentEngineFixture`.

**Rationale**: The engine-kill test must kill the engine process to verify disconnect detection. If it used the shared `PersistentEngineFixture`, killing the engine would break all subsequent persistent tests (T0-T9). A separate fixture with its own engine instance isolates the destructive operation.

**Alternatives considered**:
- Run engine-kill test last in the shared fixture (highest priority number): Rejected — xUnit doesn't guarantee class ordering, so "last" isn't reliable. Also, the shared fixture's `DisposeAsync` would fail trying to stop an already-dead engine.
- Add a `KillEngine()` method to the shared fixture: Rejected — even if run last, this couples the destructive test to the shared lifecycle and makes the test order-dependent.
- Mock the socket instead of killing the real engine: Rejected — the whole point is to verify the fix works against a real engine death, not a simulated one.

## Decision 3: Init Disconnect Handling Approach

**Decision**: Wrap the warm-up `c.Run(...)` loops in `InitializeAsync` with a catch for `EngineDisconnectedException`, then delegate to `ThrowIfEngineCrashed()` for formatted diagnostics.

**Rationale**: `ThrowIfEngineCrashed()` already formats engine PID, exit code, and log tail excerpts. Since `EngineDisconnectedException` means the socket is dead (implying the engine process died), the existing diagnostic method provides exactly the right output. No new formatting code needed.

**Alternatives considered**:
- Catch and format manually in each warm-up loop: Rejected — duplicates the logic already in `ThrowIfEngineCrashed()`.
- Add a wrapper method for all `c.Run()` calls in init: Rejected — over-engineering for 3 call sites; a simple try/catch is clearer.

## Decision 4: queryInFrame Exception Handling Fix

**Decision**: Replace the catch-all `with _ -> ()` with specific handling: catch `CAPTURED_ENOUGH` control flow, let all other exceptions (including `EngineDisconnectedException`) propagate.

**Rationale**: The current `with _ -> ()` masks real failures. The only expected exception from `RunFrames` in the context of `queryInFrame` is the `CAPTURED_ENOUGH` sentinel (though `queryInFrame` uses frame count 2, so `RunFrames` handles the sentinel internally). The outer catch is unnecessary and harmful.

**Alternatives considered**:
- Log but swallow exceptions: Rejected — logging without failing still produces misleading "SKIP" results when the actual problem is a crash or disconnect.
- Remove the outer try/catch entirely: This is the chosen approach — `queryInFrame` should not catch exceptions from `RunFrames` since `RunFrames` already handles the `CAPTURED_ENOUGH` sentinel internally.
