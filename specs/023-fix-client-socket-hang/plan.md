# Implementation Plan: Fix Client Socket Handling Bug

**Branch**: `023-fix-client-socket-hang` | **Date**: 2026-04-06 | **Spec**: [spec.md](spec.md)
**Input**: Feature specification from `/specs/023-fix-client-socket-hang/spec.md`

## Summary

Fix the F# HighBarClient's socket read loop that spins at 87% CPU when the engine dies. The `recvBytes` function ignores zero-byte reads (socket closed by peer) and has no timeout, causing infinite loops. The fix adds disconnection detection, configurable read timeouts, and test harness recovery so that engine death during testing results in clean test failures instead of hung processes.

## Technical Context

**Language/Version**: F# / .NET 10.0 (client library and test harness)
**Primary Dependencies**: Google.Protobuf 3.28, xUnit 2.9.x, System.Net.Sockets
**Storage**: Filesystem only (Unix domain sockets)
**Testing**: xUnit (persistent/integration tiers), manual engine-kill verification
**Target Platform**: Linux (headless BAR engine)
**Project Type**: Client library bug fix + test harness hardening
**Performance Goals**: Disconnection detection within configured timeout (default 10s); no CPU spin-wait on dead socket
**Constraints**: Must not introduce false timeouts during normal operation; must preserve existing test behavior
**Scale/Scope**: 2 files modified (Client.fs, PersistentHarness.fs), 1 new exception type

## Constitution Check

*GATE: Must pass before Phase 0 research. Re-check after Phase 1 design.*

| Principle | Status | Notes |
|-----------|--------|-------|
| I. Zero Engine Modifications | PASS | No engine changes; fix is entirely in F# client |
| II. Binary Protocol First | PASS | No protocol changes; fix is in socket I/O layer below protobuf |
| III. Correctness Over Cleverness | PASS | Straightforward fix: check read return value, set timeout property |
| IV. Test at the Boundary | PASS | Fix is in the transport layer that serves boundary tests |
| V. Latency Budget Discipline | PASS | No hot-path changes; timeout only triggers on dead connections |
| VI. Language-Agnostic by Default | PASS | No protocol-level changes; F# client-only fix |
| VII. Explicit Over Implicit | PASS | Timeout is configurable via env var with documented default |

**Post-Phase 1 Re-check**: All gates remain PASS. No violations introduced.

## Project Structure

### Documentation (this feature)

```text
specs/023-fix-client-socket-hang/
├── plan.md              # This file
├── spec.md              # Feature specification
├── research.md          # Phase 0 research decisions
├── data-model.md        # Phase 1 entity model
└── quickstart.md        # Development workflow guide
```

### Source Code (repository root)

```text
# Files to MODIFY
clients/fsharp/src/Client.fs              # Fix recvBytes, add timeout, add disconnect detection
tests/persistent/fsharp/PersistentHarness.fs  # Catch disconnect errors in RunFrames, track liveness

# No new files needed — fix is contained in existing files
```

**Structure Decision**: Minimal change set — the bug is in 2 functions (`recvBytes` and `RunFrames`). No new files, directories, or architectural changes needed.

## Complexity Tracking

No constitution violations to justify. All changes align with existing architecture.

## Implementation Phases

### Phase 1: Fix recvBytes Disconnection Detection (P1)

**Goal**: Eliminate the infinite loop when socket peer closes connection.

**Steps**:
1. In `recvBytes`, check the return value of `NetworkStream.Read()` — if it returns 0, the peer has closed the connection. Throw a specific `EngineDisconnectedException` instead of spinning.
2. Set `NetworkStream.ReadTimeout` to a configurable value (default 10000ms) in `AcceptFrom`, `Connect`, and `WrapSocket` methods.
3. Catch `IOException` (timeout) in `recvBytes` and re-throw as `EngineDisconnectedException`.
4. Add `HIGHBAR_CLIENT_TIMEOUT_MS` environment variable support for configuring the timeout.

**Validation**: Kill engine during `dotnet test` run — client should throw exception within timeout period, not hang.

### Phase 2: Test Harness Recovery (P2)

**Goal**: When RunFrames encounters a disconnect, fail the current test and skip remaining tests.

**Steps**:
1. In `PersistentHarness.RunFrames`, catch `EngineDisconnectedException` alongside the existing `"CAPTURED_ENOUGH"` exception handling.
2. When disconnection is caught, set engine liveness state to false (the existing `IsEngineAlive` / `ThrowIfEngineCrashed` mechanism).
3. Ensure `ResetGameState` and other harness methods check liveness before attempting socket communication.

**Validation**: Run persistent test suite, kill engine mid-test — remaining tests should skip with "engine crashed" message.

### Phase 3: Configurable Timeout (P3)

**Goal**: Allow different timeout values per test tier.

**Steps**:
1. Read `HIGHBAR_CLIENT_TIMEOUT_MS` env var in client constructor (default: 10000ms).
2. Allow constructor parameter override for programmatic control.
3. Document the env var in quickstart.md.

**Validation**: Set timeout to 2s, kill engine, verify detection within 2s.

## Risk Register

| Risk | Impact | Mitigation |
|------|--------|------------|
| False timeouts during slow callback responses | Tests fail incorrectly | Default timeout of 10s is generous; env var allows tuning per tier |
| Partial read leaves socket in inconsistent state | Subsequent reads corrupted | Disconnect exception marks socket as dead; no subsequent reads attempted |
| Test harness doesn't properly propagate disconnect | Tests hang instead of failing | Explicit catch in RunFrames with engine liveness tracking |
