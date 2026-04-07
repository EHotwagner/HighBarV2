# Feature Specification: Adapt FSBarV1 Test Harness and Engine Handling

**Feature Branch**: `028-adapt-test-harness`  
**Created**: 2026-04-07  
**Status**: Draft  
**Input**: User description: "the testing and engine handling in fsbarv1 works very well. this repo has several problems. analyze fsbarv1 and adapt that code/structure"

## User Scenarios & Testing *(mandatory)*

### User Story 1 - Unified Engine Lifecycle Management (Priority: P1)

As a test developer, I want a single, shared engine lifecycle abstraction so that all test categories (integration, persistent, AI) use the same reliable code for starting, connecting to, and stopping the headless engine, eliminating duplicated harness code and inconsistent behavior.

**Why this priority**: The current codebase has three separate harness implementations (~600 lines of duplicated code) for socket management, engine startup, and cleanup. Bug fixes must be applied in three places, and each implementation has subtly different error handling. FSBarV1 solves this with a single `BarClient` class that encapsulates the entire session lifecycle. This is the foundation all other improvements depend on.

**Independent Test**: Can be tested by running any existing integration or persistent test suite — if the engine starts, connects, runs frames, and shuts down cleanly using the new unified harness, it delivers value.

**Acceptance Scenarios**:

1. **Given** a test requiring a live engine, **When** the test fixture initializes, **Then** the engine is started, the proxy connects, and the handshake completes using a single shared lifecycle abstraction.
2. **Given** a running engine session, **When** the test fixture disposes, **Then** the engine process is terminated cleanly (SIGTERM with grace period, SIGKILL fallback), the socket file is removed, and the session directory is cleaned up.
3. **Given** the engine process crashes during a test, **When** the harness detects the crash, **Then** an appropriate exception is raised with diagnostic context (last N lines of stdout, stderr, infolog), not silently swallowed.

---

### User Story 2 - Robust Process Cleanup and Orphan Prevention (Priority: P1)

As a developer running tests, I want the test harness to guarantee that no orphaned engine processes are left running after tests complete (whether successfully, with failures, or after crashes), so that system resources are not wasted and subsequent test runs are not affected.

**Why this priority**: Orphaned `spring-headless` processes consuming gigabytes of memory are a known and active problem. FSBarV1 handles this with reliable SIGTERM/SIGKILL sequencing, PID tracking, and session directory management. This is equally critical as Story 1 since leaked processes cause cascading failures.

**Independent Test**: Run a test suite, force-kill the test runner mid-execution, then verify no orphaned engine processes remain.

**Acceptance Scenarios**:

1. **Given** a test run completes normally, **When** all fixtures are disposed, **Then** zero engine processes remain from that run.
2. **Given** a test runner is killed unexpectedly (e.g., timeout, SIGKILL), **When** the next test run begins, **Then** stale engine processes from the previous run are detected and cleaned up before starting new engines.
3. **Given** the engine hangs (not responding but process alive), **When** the socket read times out, **Then** the harness escalates to SIGKILL after a configurable grace period and reports the hang with diagnostic logs.

---

### User Story 3 - Centralized Configuration Management (Priority: P2)

As a test developer, I want all engine and test configuration (timeouts, paths, engine version, map name, game type) managed through a single configuration source with validation, so that I don't need to coordinate changes across multiple scripts and harness files.

**Why this priority**: Configuration is currently fragmented across `engine-version.json`, environment variables, shell script `sed` templates, and F# harness code. FSBarV1 uses a clean `EngineConfig` record with sensible defaults and override chains. Centralizing this prevents misalignment bugs (e.g., client timing out before engine responds).

**Independent Test**: Change a single configuration value (e.g., map name) and verify all test categories pick it up without modifying multiple files.

**Acceptance Scenarios**:

1. **Given** a configuration file with engine version, map name, game type, and timeout values, **When** any test harness initializes, **Then** it reads configuration from the single source and applies it consistently.
2. **Given** an invalid or missing configuration value, **When** the harness initializes, **Then** it reports a clear validation error specifying what is wrong and what valid values look like.
3. **Given** environment variable overrides for configuration values, **When** both the config file and environment variable are present, **Then** the environment variable takes precedence (allowing CI and local customization).

---

### User Story 4 - Proper Error Handling and Diagnostic Reporting (Priority: P2)

As a test developer investigating a test failure, I want the harness to surface meaningful errors and diagnostic context (engine logs, last frame number, session state) rather than silently catching exceptions, so that I can quickly identify the root cause.

**Why this priority**: Current code uses broad catch-all patterns that mask real failures. Engine crashes, protocol errors, and state corruption go undetected. FSBarV1 uses typed exceptions with diagnostic context. This directly reduces debugging time.

**Independent Test**: Simulate an engine crash during a test and verify the test failure message includes engine log excerpts and the last successful frame number.

**Acceptance Scenarios**:

1. **Given** the engine process exits unexpectedly during frame processing, **When** the harness detects the disconnection, **Then** a typed exception is raised containing the last successful frame number and the last 30 lines of engine stdout, stderr, and infolog.
2. **Given** a socket read timeout occurs, **When** the harness reports the failure, **Then** the error message includes the configured timeout value, elapsed time, and whether the engine process is still alive.
3. **Given** a test fails for any reason, **When** the test report is generated, **Then** the session directory path and key log file paths are included in the failure output for post-mortem analysis.

---

### User Story 5 - Reliable Game State Reset for Persistent Tests (Priority: P3)

As a test developer writing persistent engine tests, I want the game state reset mechanism to be atomic and verified, so that each test starts from a known clean state regardless of what previous tests did.

**Why this priority**: The current `ResetGameState()` sends cheat commands but doesn't verify success and can fail silently. FSBarV1's approach of tracking initial state during warm-up provides a clear reset contract. This is P3 because it only affects persistent tests.

**Independent Test**: Run the persistent test suite twice in sequence and verify identical results both times, proving no state leaks between runs.

**Acceptance Scenarios**:

1. **Given** a persistent test has spawned units and issued commands, **When** the state is reset for the next test, **Then** the reset completes only after verifying all non-initial units are destroyed and the unit count matches the initial count.
2. **Given** the reset command fails (e.g., cheats not enabled), **When** the harness detects the failure, **Then** it raises an explicit error rather than continuing with corrupted state.
3. **Given** the reset is in progress, **When** the verification step times out, **Then** the harness reports which units remain and their states, enabling debugging.

---

### Edge Cases

- What happens when the engine binary doesn't exist or is the wrong version?
- How does the system handle socket path collisions if a previous session's socket file was not cleaned up?
- What happens when the engine starts but the proxy AI plugin fails to load?
- What happens if the prerequisite check passes but the engine crashes immediately on startup?
- How does the harness behave when multiple test runs execute concurrently on the same machine?

## Requirements *(mandatory)*

### Functional Requirements

- **FR-001**: System MUST provide a single engine lifecycle abstraction that encapsulates engine process spawning, socket creation, proxy connection acceptance, handshake, frame stepping, and graceful shutdown.
- **FR-002**: System MUST track engine process PID and write it to a known location so that orphan detection can find and terminate stale processes.
- **FR-003**: System MUST implement a two-phase shutdown sequence: SIGTERM with configurable grace period followed by SIGKILL if the process does not exit.
- **FR-004**: System MUST generate unique session directories (using GUID or similar) to prevent collisions between concurrent test runs.
- **FR-005**: System MUST auto-detect the BAR data directory by walking up from the engine binary location, falling back to standard paths, and supporting environment variable override.
- **FR-006**: System MUST provide a typed exception for engine disconnection that carries the last successful frame number and diagnostic context.
- **FR-007**: System MUST consolidate all configuration (engine path, data directory, timeouts, map name, game type, opponent AI) into a single configuration record with validation and environment variable overrides.
- **FR-008**: System MUST validate configuration at harness initialization time, failing fast with clear error messages for invalid or missing values.
- **FR-009**: System MUST capture and make available engine diagnostic logs (stdout, stderr, infolog) for test failure reporting. Session directories MUST be preserved on disk when tests fail (for post-mortem inspection) and cleaned up automatically when tests pass.
- **FR-010**: System MUST detect and clean up stale engine processes from previous runs before starting new engines. Cleanup MUST be scoped to processes tracked via PID files written by the harness (FR-002). If untracked engine processes are detected, the system MUST log a warning but MUST NOT terminate them.
- **FR-011**: System MUST implement a verified game state reset for persistent tests that confirms the reset completed successfully before proceeding.
- **FR-012**: System MUST generate the game setup script programmatically from configuration rather than using shell `sed` templates.

### Key Entities

- **EngineSession**: Represents a single engine lifecycle from process spawn to termination. Tracks process ID, socket path, session directory, and current state (Idle, Starting, Connected, Running, Stopped, Error).
- **EngineConfig**: Configuration record for an engine session including engine binary path, data directory, map name, game type, timeouts, opponent AI, and game speed.
- **GameFrame**: A single frame of game state received from the proxy, containing events, unit updates, and resource information.
- **SessionDiagnostics**: Collection of log excerpts and state information for post-mortem analysis of failures.

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: All test categories (integration, persistent, AI) use the same engine lifecycle abstraction with zero duplicated harness code for engine management.
- **SC-002**: After any test run (pass, fail, or crash), zero orphaned engine processes remain within 10 seconds of completion.
- **SC-003**: Engine configuration changes require editing exactly one file with no multi-file coordination needed.
- **SC-004**: Test failure messages include engine diagnostic context (log excerpts, frame number) in 100% of engine-related failures.
- **SC-005**: Persistent test suite produces identical results when run twice consecutively, demonstrating reliable state reset.
- **SC-006**: Existing test pass rate is maintained or improved with no regressions from harness refactoring.
- **SC-007**: Engine startup and teardown time per test fixture is within 10% of current performance.

## Clarifications

### Session 2026-04-07

- Q: Should session directories be preserved on disk after test failure or always cleaned up? → A: Preserve on failure for post-mortem inspection, clean up on success.
- Q: Should stale process cleanup kill all spring-headless processes or only those tracked by the harness? → A: Only kill processes matching PID files written by the harness; log a warning if untracked spring-headless processes are detected.

## Assumptions

- FSBarV1 source code at `/home/developer/projects/FSBarV1/` is the reference implementation for patterns to adopt.
- The existing HighBarV2 protobuf protocol and message format remain unchanged — this feature only refactors the test harness and engine lifecycle management.
- The xUnit test framework and F# language continue to be used for tests.
- The `spring-headless` engine binary and BAR data directory layout are stable.
- All existing tests will continue to work after refactoring — this is a structural improvement, not a behavior change.
- The C proxy tests (CTest) are out of scope since they use a completely different test framework.
