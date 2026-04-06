# Feature Specification: Fix Persistent Test Remaining Gaps

**Feature Branch**: `024-fix-persistent-test-gaps`
**Created**: 2026-04-06
**Status**: Draft
**Input**: User description: "Fix persistent test remaining issues: map test state pollution, engine-kill verification, and init disconnect handling"

## User Scenarios & Testing *(mandatory)*

### User Story 1 — Map Tests Pass Reliably in Full Suite (Priority: P1)

When a developer runs the full persistent test suite, all map query tests (T9.3 Start Position, T9.4 Metal Spots) must pass regardless of which tests ran before them. Currently these tests pass in isolation but fail when run after 45 other tests due to accumulated game state pollution.

**Why this priority**: Flaky tests erode confidence in the test suite and mask real regressions. Two consistently failing tests in the primary test tier are unacceptable.

**Independent Test**: Run the full persistent test suite end-to-end. T9.3 and T9.4 must pass alongside all other tests. Then run T9.3 and T9.4 in isolation — same results.

**Acceptance Scenarios**:

1. **Given** the full persistent test suite with 47 tests sharing one engine, **When** the suite runs end-to-end, **Then** T9.3 and T9.4 pass with valid map data (positive start coordinates within map bounds, at least 1 metal spot with positive income).
2. **Given** earlier tests have spawned and destroyed hundreds of units, **When** map query tests execute after a state reset, **Then** map callbacks return the same values as they would on a fresh engine.
3. **Given** T9.3 and T9.4 are run in isolation with a fresh engine, **When** compared to full-suite results, **Then** both produce equivalent passing results.

---

### User Story 2 — Automated Engine-Kill Verification (Priority: P2)

A developer needs confidence that the socket disconnect fix (from feature 023) actually works under real conditions. There should be an automated test that starts the engine, kills it mid-run, and verifies the client detects the disconnection cleanly within the configured timeout — rather than hanging.

**Why this priority**: The core socket fix was implemented in feature 023 but never verified against a real engine kill. Without automated proof, the fix is unvalidated. This test also serves as a regression guard.

**Independent Test**: Run the engine-kill verification test. It starts the engine, begins a frame loop, kills the engine process, and asserts the client throws a disconnection error within 10 seconds and the test process exits cleanly.

**Acceptance Scenarios**:

1. **Given** a running engine with an active client connection, **When** the engine process is killed, **Then** the client detects the disconnection and throws a specific disconnection error within 10 seconds.
2. **Given** the engine has been killed during a test, **When** subsequent tests attempt to run frames, **Then** they fail immediately with a diagnostic message indicating the engine has crashed (not hang).
3. **Given** a custom timeout of 2 seconds is configured, **When** the engine is killed, **Then** detection occurs within approximately 2 seconds.

---

### User Story 3 — Graceful Handling of Engine Death During Initialization (Priority: P3)

When the engine dies during the test fixture's warm-up phase (before any tests start), the failure message should clearly indicate what happened rather than surfacing a raw, unformatted exception. All tests should skip with a meaningful message.

**Why this priority**: This is an edge case that rarely occurs, but when it does the raw exception is confusing. Polish for developer experience.

**Independent Test**: Start the test fixture, kill the engine during the warm-up phase (first 30 frames), and verify the error message includes diagnostic information (engine PID, exit code, socket path).

**Acceptance Scenarios**:

1. **Given** the engine is starting up and the fixture is capturing warm-up frames, **When** the engine process dies, **Then** the fixture reports a clear error message with engine PID, exit code, and socket path.
2. **Given** the engine died during initialization, **When** individual tests attempt to run, **Then** they all skip with a message indicating the engine crashed during setup.

---

### Edge Cases

- What happens if the engine dies between `ResetGameState` and the next test's `RunFrames`? The harness should detect this via the existing engine liveness check before attempting socket I/O.
- What happens if map callbacks return different values on a heavily loaded engine vs an idle one? The test assertions should use map-defined bounds, not hardcoded expected values.
- What happens if the state reset itself triggers the engine to crash (e.g., too many destroy commands)? The reset should catch disconnect errors and propagate as engine crash.

## Requirements *(mandatory)*

### Functional Requirements

- **FR-001**: The test state reset mechanism MUST restore game state sufficiently that map query callbacks return consistent values regardless of prior test activity.
- **FR-002**: The test suite MUST include an automated test that verifies client disconnection detection by killing the engine process mid-run.
- **FR-003**: The automated engine-kill test MUST verify that disconnection is detected within the configured timeout period.
- **FR-004**: The automated engine-kill test MUST verify that subsequent operations fail immediately with diagnostic information rather than hanging.
- **FR-005**: The automated engine-kill test MUST verify that a custom timeout value (set via environment variable) is respected.
- **FR-006**: The test fixture initialization MUST catch disconnection errors during warm-up and report them with engine process diagnostics (PID, exit code, socket path, log excerpts).
- **FR-007**: When the engine dies during initialization, all tests in the suite MUST skip with a message indicating the engine crashed during setup.

### Key Entities

- **PersistentEngineFixture**: The shared test fixture managing engine lifecycle and state resets. Modified to improve reset completeness and init error handling.
- **ResetGameState**: The between-test cleanup method. Must be enhanced to fully restore map-queryable state.
- **Engine-Kill Test**: A new test that programmatically kills the engine and asserts correct client behavior.

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: T9.3 and T9.4 pass in the full persistent suite on 5 consecutive runs (0% flake rate, down from 100% current failure rate).
- **SC-002**: Engine-kill verification test detects disconnection within 10 seconds (default timeout) and within 2 seconds when configured with a 2-second timeout.
- **SC-003**: When the engine is killed mid-suite, subsequent tests fail or skip within 1 second each (no hanging).
- **SC-004**: Full persistent test suite passes with 0 failures (up from 2 current failures).
- **SC-005**: Engine death during initialization produces an error message containing PID, exit code, and socket path — not a raw unformatted exception.

## Assumptions

- The map callback values (start position, metal spots) are determined by the map file and do not change based on in-game unit activity. The current test failures are caused by the test harness or client state, not engine-level map data corruption.
- The engine process can be reliably killed via standard process termination from the test harness during a frame loop.
- The `EngineDisconnectedException` type from feature 023 is available and working correctly.
- The existing engine liveness check and crash detection mechanisms in the harness are correct and will detect a killed engine process.
- The persistent test suite runs on a Linux environment with a headless BAR engine available.
