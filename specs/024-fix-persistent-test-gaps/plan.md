# Implementation Plan: Fix Persistent Test Remaining Gaps

**Branch**: `024-fix-persistent-test-gaps` | **Date**: 2026-04-06 | **Spec**: [spec.md](spec.md)
**Input**: Feature specification from `/specs/024-fix-persistent-test-gaps/spec.md`

## Summary

Fix three remaining gaps from the 023 socket hang fix: (1) T9.3/T9.4 map tests fail in the full suite because they don't call `ResetGameState()` and the `queryInFrame` helper silently swallows exceptions, (2) the socket disconnect fix was never verified with a real engine kill, and (3) the fixture's `InitializeAsync` doesn't catch `EngineDisconnectedException` during warm-up, producing raw unformatted errors.

## Technical Context

**Language/Version**: F# / .NET 10.0 (test projects)
**Primary Dependencies**: xUnit 2.9.x, HighBar.Client (with EngineDisconnectedException from 023)
**Storage**: Filesystem only (Unix domain sockets, temp dirs)
**Testing**: xUnit persistent test tier, spring-headless engine
**Target Platform**: Linux (headless BAR engine)
**Project Type**: Test harness bug fix + new verification test
**Performance Goals**: Engine-kill detection within configured timeout (default 10s)
**Constraints**: Must not break existing 45 passing persistent tests; engine-kill test must not corrupt shared fixture
**Scale/Scope**: 2 files modified (T9_MapTests.fs, PersistentHarness.fs), 1 new test file (T10_EngineKillTests.fs)

## Constitution Check

*GATE: Must pass before Phase 0 research. Re-check after Phase 1 design.*

| Principle | Status | Notes |
|-----------|--------|-------|
| I. Zero Engine Modifications | PASS | No engine changes; all changes in F# test code |
| II. Binary Protocol First | PASS | No protocol changes |
| III. Correctness Over Cleverness | PASS | Straightforward fixes: add missing reset calls, remove silent exception swallow, add try/catch in init |
| IV. Test at the Boundary | PASS | These are boundary tests themselves being fixed |
| V. Latency Budget Discipline | PASS | No hot-path changes |
| VI. Language-Agnostic by Default | PASS | No protocol-level changes |
| VII. Explicit Over Implicit | PASS | Removing silent exception swallowing makes failures explicit; adding diagnostic messages improves observability |

**Post-Phase 1 Re-check**: All gates remain PASS. No violations introduced.

## Project Structure

### Documentation (this feature)

```text
specs/024-fix-persistent-test-gaps/
├── plan.md              # This file
├── spec.md              # Feature specification
├── research.md          # Phase 0 research
├── data-model.md        # Phase 1 entity model
└── quickstart.md        # Development workflow guide
```

### Source Code (repository root)

```text
# Files to MODIFY
tests/persistent/fsharp/T9_MapTests.fs              # Add ResetGameState calls, fix queryInFrame exception handling
tests/persistent/fsharp/PersistentHarness.fs         # Add EngineDisconnectedException catch in InitializeAsync, expose KillEngine for testing

# Files to CREATE
tests/persistent/fsharp/T10_EngineKillTests.fs       # New test: engine-kill verification (separate fixture, not shared)
```

**Structure Decision**: Minimal change set. The engine-kill test needs its own fixture instance (cannot share the persistent fixture — killing the engine would break all other tests). T10 uses a standalone `IAsyncLifetime` setup that starts its own engine.

## Complexity Tracking

No constitution violations to justify. All changes align with existing architecture.

## Implementation Phases

### Phase 1: Fix T9 Map Test Failures (P1)

**Goal**: T9.3 and T9.4 pass reliably in the full suite.

**Root Cause**: Two issues combine to cause the failures:
1. T9.3 and T9.4 do not call `ResetGameState()` before querying map callbacks. When run after T8's large-scale combat, the engine has residual units that may affect callback behavior.
2. The `queryInFrame` helper has a catch-all `with _ -> ()` on line 27 that silently swallows all exceptions from `RunFrames`, including `EngineDisconnectedException`. If `RunFrames` fails for any reason, the query returns `None` and the test prints "SKIP" instead of reporting the actual error.

**Steps**:
1. Add `engine.ResetGameState()` call to T9.3 and T9.4 (matching T9.1's pattern).
2. Fix `queryInFrame` to not silently swallow non-control-flow exceptions — let `EngineDisconnectedException` and unexpected errors propagate; only catch the `CAPTURED_ENOUGH` control flow exception.
3. Add `engine.ResetGameState()` to T9.2 as well for consistency.

**Validation**: Run full persistent suite 3 times — T9.3 and T9.4 must pass each time.

### Phase 2: Engine-Kill Verification Test (P2)

**Goal**: Automated proof that the 023 disconnect fix works against a real engine kill.

**Design**: A new test file `T10_EngineKillTests.fs` with its own `EngineKillFixture` that:
- Starts a fresh engine (reuses `start-headless.sh` / `stop-headless.sh`)
- Connects a `HighBarClient`
- Provides a `KillEngine()` method that sends SIGKILL to the engine process
- Cleans up on dispose

The test class contains:
1. **T10.1**: Kill engine during frame loop, assert `EngineDisconnectedException` is thrown within 10s
2. **T10.2**: After engine kill, verify `ThrowIfEngineCrashed` fires immediately
3. **T10.3**: Set `HIGHBAR_CLIENT_TIMEOUT_MS=2000`, kill engine, verify detection within ~3s (2s timeout + margin)

**Key constraint**: T10 tests must NOT use the shared `PersistentEngineFixture` — they need their own engine to kill. Use a separate xUnit collection to avoid conflicts.

**Validation**: `dotnet test --filter T10` passes with all 3 tests green.

### Phase 3: Init Disconnect Handling (P3)

**Goal**: When engine dies during `InitializeAsync` warm-up, produce a formatted diagnostic error.

**Steps**:
1. In `PersistentHarness.fs`, wrap the three `c.Run(...)` warm-up loops in `InitializeAsync` with a catch for `EngineDisconnectedException`.
2. When caught, call `ThrowIfEngineCrashed()` which produces the formatted diagnostic (PID, exit code, log tail). If the engine process is somehow still alive, construct a similar diagnostic message manually.

**Validation**: This is an edge case that's hard to test automatically (engine must die during the ~1s warm-up window). The T10 engine-kill tests provide confidence that the exception type propagates correctly. Visual inspection of the catch block is sufficient.

## Risk Register

| Risk | Impact | Mitigation |
|------|--------|------------|
| Adding ResetGameState to T9 tests increases suite runtime | Suite takes ~5s longer | Acceptable; correctness over speed |
| Engine-kill test is flaky due to timing | T10 tests fail intermittently | Use generous timeout margins (3s for 2s timeout test) |
| Removing queryInFrame exception swallow reveals hidden failures | Other T9 tests start failing | Good — that's the point; fix the revealed issues |
| T10's separate fixture doubles engine startup cost | Test suite takes ~3min instead of ~2.5min | Acceptable for a one-time verification test |
