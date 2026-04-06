# Feature Specification: Fix Client Socket Handling Bug

**Feature Branch**: `023-fix-client-socket-hang`  
**Created**: 2026-04-06  
**Status**: Draft  
**Input**: User description: "fix the client socket handling bug"

## User Scenarios & Testing *(mandatory)*

### User Story 1 - Client Detects Engine Disconnection (Priority: P1)

A developer runs live engine tests (persistent or integration tier). The engine process dies unexpectedly mid-test (crash, timeout, watchdog kill). The client library detects the disconnection within a bounded time and raises an error, allowing the test harness to fail the test cleanly and proceed to the next one — rather than hanging indefinitely.

**Why this priority**: This is the core bug. Without this fix, any engine death during testing causes the entire test process to hang at 87% CPU usage, requiring manual process kills and preventing CI/CD automation.

**Independent Test**: Kill the engine process during an active client session and verify the client raises an error within the timeout period.

**Acceptance Scenarios**:

1. **Given** a connected client receiving frames from a running engine, **When** the engine process is killed (SIGKILL), **Then** the client raises a disconnection error within the configured timeout period.
2. **Given** a connected client receiving frames from a running engine, **When** the engine process exits normally, **Then** the client raises a disconnection error within the configured timeout period.
3. **Given** a connected client executing a callback request, **When** the engine process dies before responding, **Then** the callback raises a disconnection error within the configured timeout period.

---

### User Story 2 - Test Harness Recovers from Engine Death (Priority: P2)

When the persistent test harness encounters an engine disconnection during a test, the failing test reports an engine crash error and the harness marks the engine as dead. Subsequent tests in the same run skip immediately with a descriptive message rather than attempting to communicate with the dead engine.

**Why this priority**: Even after the client detects disconnection (US1), the test harness must handle the error gracefully. Without this, a single engine death still blocks the remaining test suite.

**Independent Test**: Run a multi-test persistent suite where the engine dies during an early test, and verify all subsequent tests skip with a clear "engine crashed" message.

**Acceptance Scenarios**:

1. **Given** a persistent test suite is running and the engine dies during test N, **When** test N+1 starts, **Then** it skips immediately with a message indicating the engine is no longer available.
2. **Given** the engine dies mid-frame during `RunFrames`, **When** the `RunFrames` call returns, **Then** it throws an exception that identifies the cause as a disconnection (not a generic I/O error).

---

### User Story 3 - Configurable Socket Timeout (Priority: P3)

A developer configures the socket read timeout to match their test scenario requirements. Fast-running unit-style tests use a short timeout (e.g., 5 seconds). Long-running AI validation tests use a longer timeout (e.g., 60 seconds). The timeout is configurable via environment variable or constructor parameter.

**Why this priority**: Different test tiers have different latency profiles. A one-size-fits-all timeout would either be too aggressive (killing slow but valid tests) or too lenient (delaying failure detection).

**Independent Test**: Set the timeout to 2 seconds, kill the engine, and verify the client detects disconnection within 2 seconds.

**Acceptance Scenarios**:

1. **Given** the socket timeout is set to T seconds, **When** the engine stops responding, **Then** the client raises a timeout error within T seconds (plus reasonable overhead).
2. **Given** no explicit timeout is configured, **When** the client is created, **Then** a reasonable default timeout is used (not infinite).

---

### Edge Cases

- What happens when the engine sends a partial message (e.g., the 4-byte length header but no payload) before dying?
- How does the client handle a socket that becomes half-open (one direction closed, other still appears open)?
- What happens if the engine sends corrupted data (invalid protobuf) — does the client distinguish corruption from disconnection?
- What happens when multiple concurrent callback requests are in flight when the engine dies?

## Requirements *(mandatory)*

### Functional Requirements

- **FR-001**: Client MUST detect when a socket read returns zero bytes (peer closed connection) and raise a disconnection error instead of spinning in an infinite loop.
- **FR-002**: Client MUST enforce a configurable read timeout on all socket operations. Reads that exceed the timeout MUST raise a timeout error.
- **FR-003**: Client MUST handle partial message scenarios (header received but payload missing) by timing out and raising a disconnection error — not blocking forever.
- **FR-004**: The disconnection error MUST be distinguishable from other errors (timeout, protocol error, data corruption) to allow callers to take appropriate action.
- **FR-005**: The test harness MUST catch client disconnection errors during `RunFrames` and propagate them as test failures with diagnostic information (last frame number, elapsed time).
- **FR-006**: The test harness MUST track engine liveness state and skip subsequent tests immediately when the engine has been determined to be dead.
- **FR-007**: The default socket read timeout MUST be bounded (not infinite) and suitable for typical test scenarios.
- **FR-008**: The socket read timeout MUST be configurable via environment variable for test flexibility.

### Key Entities

- **Socket Connection**: The bidirectional communication channel between the client and engine proxy, with associated timeout and liveness state.
- **Disconnection Error**: A specific error type indicating the engine proxy has closed the connection or become unresponsive, distinct from protocol errors or data corruption.

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: Client detects engine disconnection within the configured timeout period (default: no more than 10 seconds) instead of hanging indefinitely.
- **SC-002**: No test process consumes more than 5% CPU while waiting for a dead engine (eliminates the 87% CPU spin-wait bug).
- **SC-003**: When the engine dies mid-suite, the remaining tests complete (skip or fail) within 30 seconds — the suite does not hang.
- **SC-004**: All existing passing tests continue to pass with the socket timeout enabled (no false timeouts during normal operation).
- **SC-005**: The persistent test tier can run its full suite even when the engine dies during a heavy test (e.g., large-scale combat), with the dead-engine tests reporting clear failure messages.

## Assumptions

- The underlying socket transport is Unix domain sockets (the primary transport for test scenarios). TCP transport follows the same patterns and will benefit from the same fix.
- The engine proxy (C side) already handles disconnection correctly — the fix is entirely on the F# client side and test harness.
- The existing test harness pattern (`ThrowIfEngineCrashed`, `IsEngineAlive`) provides the correct hooks for integrating disconnection detection — no new harness architecture is needed.
- Callback requests share the same socket as frame data, so a single timeout mechanism covers both paths.
