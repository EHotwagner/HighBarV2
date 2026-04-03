# Feature Specification: Live Headless Engine Test Suite

**Feature Branch**: `004-live-headless-testsuite`  
**Created**: 2026-04-03  
**Status**: Draft  
**Input**: User description: "run the testsuite against a live/real bar headless environment"

## User Scenarios & Testing *(mandatory)*

### User Story 1 - Run Integration Tests Against Live Engine (Priority: P1)

A developer wants to run the existing integration test suite (F# and Python) against a real `spring-headless` engine instance running Beyond All Reason, rather than relying on mocked or simulated engine behavior. The developer installs the engine binary and game content, then executes the test suite with a single command. The test harness automatically launches the headless engine, establishes communication via the proxy, runs all test categories, and reports pass/fail results.

**Why this priority**: This is the core value proposition — proving that the proxy, clients, and engine work together end-to-end in a real environment. Without this, all other stories are moot.

**Independent Test**: Can be fully tested by a developer with `spring-headless` installed running `dotnet test` or `pytest` and observing that tests execute against a live engine process.

**Acceptance Scenarios**:

1. **Given** a developer has `spring-headless` on PATH and BAR game content available, **When** they run the F# integration test suite, **Then** the harness launches a real headless engine, the proxy connects, and all connection/event/command tests execute against the live engine with pass/fail results reported.
2. **Given** a developer has `spring-headless` on PATH and BAR game content available, **When** they run the Python integration test suite, **Then** the same live engine lifecycle applies and all Python tests execute with pass/fail results reported.
3. **Given** a developer does not have `spring-headless` available, **When** they attempt to run the integration tests, **Then** the harness reports a clear, actionable error message indicating what is missing and how to install it.

---

### User Story 2 - Automated Engine Content Provisioning (Priority: P2)

A developer setting up their environment for the first time wants to acquire the necessary engine binary, game archive, and map files without manually hunting for download links. A setup workflow checks for required content and either downloads it automatically or provides step-by-step instructions for acquisition.

**Why this priority**: Reduces onboarding friction. Without game content and engine binary, no tests can run. This removes the biggest barrier to entry for new contributors.

**Independent Test**: Can be tested by a new developer following the setup workflow on a clean machine and ending up with all prerequisites in place to run Story 1.

**Acceptance Scenarios**:

1. **Given** a developer has no engine binary installed, **When** they run the prerequisites check, **Then** the system identifies the missing binary and provides a download location or automated download for the correct engine version.
2. **Given** a developer has the engine but is missing the BAR game archive or maps, **When** they run the prerequisites check, **Then** the system identifies exactly which game content is missing and provides instructions or automated download to acquire it.
3. **Given** a developer has all prerequisites already installed, **When** they run the prerequisites check, **Then** the system confirms everything is in place and no action is needed.

---

### User Story 3 - Test Result Reporting and Diagnostics (Priority: P3)

After running the test suite against a live engine, a developer wants clear visibility into what happened: which tests passed, which failed, and for failures, enough diagnostic information (engine logs, proxy logs, socket state) to debug the issue without re-running.

**Why this priority**: Live engine tests are slower and more complex than unit tests. Good diagnostics prevent expensive re-run cycles and make failures actionable.

**Independent Test**: Can be tested by intentionally causing a test failure (e.g., wrong map name) and verifying the output includes engine log excerpts and socket state information alongside the test failure message.

**Acceptance Scenarios**:

1. **Given** a test run completes with all tests passing, **When** the developer reviews the output, **Then** they see a summary of passed tests by category with total execution time.
2. **Given** a test run completes with failures, **When** the developer reviews the output, **Then** each failure includes the test name, assertion details, and relevant engine/proxy log excerpts.
3. **Given** the engine crashes during a test run, **When** the developer reviews the output, **Then** the crash is detected, remaining tests are marked as skipped with an explanation, and the engine's stderr output is captured and displayed.

---

### Edge Cases

- What happens when the engine binary exists but is the wrong version (sync mismatch with game archive)?
- How does the system handle the engine process hanging and not producing a socket within the timeout period?
- What happens when multiple test runs are launched concurrently on the same machine?
- How does the system behave when disk space is insufficient for game content or replay recording?
- What happens when the engine exits mid-test (crash or game-over condition reached before all tests complete)? → Fail fast: detect crash, skip remaining tests with explanation, report engine stderr, exit with failure status. No automatic retry.

## Requirements *(mandatory)*

### Functional Requirements

- **FR-001**: The test harness MUST launch a real `spring-headless` process with the correct game scenario when integration tests are invoked.
- **FR-002**: The test harness MUST verify that the engine binary, game archive, and map files are present before attempting to launch the engine, and MUST report specific missing items if prerequisites are not met.
- **FR-003**: The test harness MUST support configuring the engine binary path via the `HIGHBAR_TEST_ENGINE` environment variable, falling back to `spring-headless` on PATH.
- **FR-004**: The test harness MUST support configuring the game content directory via the `SPRING_DATADIR` environment variable.
- **FR-005**: The test harness MUST wait for the engine's proxy socket to become available before running tests, with a configurable timeout (default 30 seconds, configurable via `HIGHBAR_TEST_TIMEOUT`).
- **FR-006**: The test harness MUST cleanly shut down the engine process after all tests complete, including force-termination if graceful shutdown fails within 5 seconds.
- **FR-007**: The test harness MUST support concurrent test runs on the same machine by using unique socket paths per test session.
- **FR-008**: The test harness MUST capture engine stdout/stderr output and make it available in test failure diagnostics.
- **FR-009**: The prerequisites check MUST validate that the installed engine version exactly matches the pinned version in the project configuration file (via `--sync-version` output comparison). A version mismatch MUST be reported as a failure with the expected and actual versions displayed.
- **FR-010**: The test suite MUST support running individual test categories (connection, events, commands, callbacks, scenarios) independently against the live engine.
- **FR-011**: The test suite MUST support both F# (xUnit) and Python (pytest) test runners, each launching and managing its own independent engine instance.
- **FR-012**: The project MUST maintain a configuration file specifying the exact pinned engine version and game archive version required for testing, updated manually when new versions are validated.
- **FR-013**: The test harness MUST detect engine process termination during a test run, immediately skip all remaining tests, and exit with a failure status including engine stderr output. No automatic retry is attempted.
- **FR-014**: The test game scenario MUST disable victory conditions so that the game remains alive indefinitely until the harness terminates the engine process.

### Key Entities

- **Engine Instance**: A running `spring-headless` process with a specific game scenario, identified by its PID and socket path.
- **Game Content**: The collection of engine binary, game archive (BAR mod), and map files required to run a headless game.
- **Test Session**: A single invocation of the test suite, encompassing engine lifecycle (start → test → stop) and result collection.

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: A developer with prerequisites installed can run the full integration test suite against a live headless engine with a single command.
- **SC-002**: The prerequisites check identifies all missing components within 5 seconds and provides actionable resolution steps.
- **SC-003**: 100% of existing integration tests (connection, events, commands, callbacks, scenarios) execute successfully against a live headless engine without modification to test logic.
- **SC-004**: Test failures against a live engine include sufficient diagnostic information (engine logs, socket state) that a developer can identify the root cause without re-running 80% of the time.
- **SC-005**: Concurrent test runs on the same machine do not interfere with each other.
- **SC-006**: Engine startup and teardown add no more than 15 seconds of overhead to a test run beyond the test execution time itself.

## Clarifications

### Session 2026-04-03

- Q: How are target engine and game versions determined? → A: Pin specific engine + game versions in a project configuration file, updated manually when validated.
- Q: What should happen when the engine crashes mid-test? → A: Fail fast — detect crash, skip remaining tests, report diagnostic info, exit with failure. No retry.
- Q: Should F# and Python test runners share a single engine instance? → A: Independent — each test runner launches and manages its own engine instance.
- Q: How should the test game scenario prevent premature game-over? → A: Disable victory conditions in the test scenario so the game never ends on its own; the harness terminates it.

## Assumptions

- Developers have a Linux environment (the primary supported platform for `spring-headless`).
- The `spring-headless` binary is available either via direct download from the Recoil engine releases or extracted from a BAR installation — bundling the binary in the repository is out of scope.
- Game content (mod archives, maps) is available via `pr-downloader` or direct download — the project does not host or redistribute these files.
- The existing test harness scripts (`start-headless.sh`, `stop-headless.sh`) and fixtures (`game-setup.lua`) provide the foundation and will be extended rather than replaced.
- The existing F# and Python integration tests are designed to work against a live engine and require no fundamental changes to test logic — only harness and environment improvements are in scope.
- CI/CD pipeline integration is a follow-on concern and not in scope for this feature (local developer workflow is the primary target).
