# Feature Specification: Consolidate Test Framework

**Feature Branch**: `018-consolidate-test-framework`  
**Created**: 2026-04-04  
**Status**: Draft  
**Input**: User description: "consolidate our testing structure/framework to a single system that is up to date. remove out of date tests and create standard ways for headless and full live tests with graphics. also add a standardized report system that saves the testreport to /reports/testreports (to be created)"

## User Scenarios & Testing *(mandatory)*

### User Story 1 - Run All Tests with One Command (Priority: P1)

A developer wants to run the full test suite — unit, integration, and AI tests — using a single, well-documented entry point. Today, tests are scattered across multiple directories with different runners (xUnit, pytest, CTest) and require manual environment setup. The developer needs a unified test runner that discovers all active tests, executes them in the correct order, and reports results consistently.

**Why this priority**: Without a single entry point, developers waste time figuring out which tests to run and how to run them. This is the foundation that all other stories build on.

**Independent Test**: Can be fully tested by invoking the unified test runner and verifying it discovers and executes tests from all active suites, producing a summary of pass/fail results.

**Acceptance Scenarios**:

1. **Given** a developer has the engine prerequisites installed, **When** they invoke the unified test runner, **Then** unit tests, proxy tests, integration tests, and persistent engine tests all execute in order and produce a combined pass/fail summary.
2. **Given** a developer does not have the engine prerequisites installed, **When** they invoke the test runner, **Then** unit and proxy tests still execute, engine-dependent tests are skipped with a clear message, and the summary distinguishes passed, failed, and skipped tests.
3. **Given** a developer wants to run only a specific test category, **When** they pass a category filter (e.g., "unit", "integration", "persistent"), **Then** only tests in that category execute.

---

### User Story 2 - Headless Engine Test Mode (Priority: P1)

A developer wants to run integration and persistent tests against the headless engine (no display required). The test framework must automatically detect available engine prerequisites, configure the engine environment (data directories, archive cache, socket paths), and manage engine lifecycle. This must work in CI environments and developer workstations without manual setup beyond installing the engine binary.

**Why this priority**: Headless tests are the primary feedback mechanism for code changes. They must be reliable, fast, and require zero manual configuration beyond engine installation.

**Independent Test**: Can be tested by running the headless test suite on a machine with the engine installed and verifying all engine-dependent tests execute against the live headless engine.

**Acceptance Scenarios**:

1. **Given** the engine binary is installed at a known path, **When** the headless test suite runs, **Then** the framework auto-detects the engine location, game content directory, and archive cache without manual environment variable configuration.
2. **Given** the engine is running, **When** a test completes (pass or fail), **Then** the framework captures engine logs and includes relevant excerpts in the test report for failed tests.
3. **Given** the engine crashes during a test, **When** the test runner detects the crash, **Then** it reports the failure with diagnostic information and continues executing remaining tests that don't depend on that engine instance.

---

### User Story 3 - Live Graphical Test Mode (Priority: P2)

A developer wants to run tests against the full graphical BAR game (with display) to validate visual behaviors, lobby registration, and UI interactions that cannot be tested headless. The framework provides a standard way to launch the graphical engine, connect the AI, and run a defined test scenario while the developer observes the game visually.

**Why this priority**: Some behaviors (rendering, lobby integration, live game AI control) can only be validated with the full graphical engine. This is needed less frequently than headless tests but is critical for final validation before releases.

**Independent Test**: Can be tested by invoking the graphical test mode on a machine with a display and the BAR AppImage, verifying the game launches, the AI connects, and the test scenario executes visually.

**Acceptance Scenarios**:

1. **Given** the BAR AppImage is installed and a display is available, **When** the developer invokes graphical test mode, **Then** the game launches in windowed mode, the HighBarV2 AI connects as a player, and a predefined test scenario begins.
2. **Given** the graphical test is running, **When** the scenario completes (or the developer manually stops it), **Then** the framework saves a test report with the scenario outcome, duration, and any errors encountered.
3. **Given** no display is available, **When** the developer attempts graphical test mode, **Then** the framework reports that graphical mode requires a display and suggests using headless mode instead.

---

### User Story 4 - Standardized Test Reports (Priority: P2)

A developer or CI system wants every test run to produce a structured, human-readable test report saved to a consistent location (`/reports/testreports/`). Reports must capture test results, timing, environment details, and failure diagnostics in a standard format that can be reviewed after the fact and compared across runs.

**Why this priority**: Without standardized reports, test results are ephemeral console output that gets lost. Persistent reports enable trend analysis, regression detection, and post-mortem debugging.

**Independent Test**: Can be tested by running any test suite and verifying a report file is created at the expected path with all required sections populated.

**Acceptance Scenarios**:

1. **Given** a test suite completes (pass or fail), **When** the test runner finishes, **Then** a report file is created at `/reports/testreports/` with a timestamped filename.
2. **Given** a test fails, **When** the report is generated, **Then** the failure section includes the test name, error message, stack trace, and relevant engine log excerpts.
3. **Given** multiple test runs occur, **When** a developer lists reports, **Then** reports are named with timestamps and test categories so they can be easily sorted and identified.

---

### User Story 5 - Remove Outdated Tests and Consolidate (Priority: P1)

A developer wants the test suite to contain only current, passing tests organized in a clear, discoverable structure. Outdated tests (referencing stale game versions, broken fixtures, or defunct features) must be removed. Duplicate test coverage across suites must be identified and consolidated. The remaining tests must be organized by clear categories with documented purpose.

**Why this priority**: Outdated tests create noise, slow down test runs, and erode trust in the test suite. Cleaning up is a prerequisite for the unified runner to produce meaningful results.

**Independent Test**: Can be tested by enumerating all test files and verifying each test compiles, executes (with or without engine), and has a clear category assignment. No test should be permanently broken or reference nonexistent dependencies.

**Acceptance Scenarios**:

1. **Given** the consolidated test suite, **When** a developer runs all tests with the engine available, **Then** zero tests fail due to stale configuration, missing fixtures, or outdated game version references.
2. **Given** the consolidated test suite, **When** a developer inspects the test directory structure, **Then** each test file belongs to a clearly labeled category (unit, integration-headless, integration-graphical, persistent, ai) with no orphaned or uncategorized tests.
3. **Given** the test suite was previously using multiple game versions and map names, **When** the consolidation is complete, **Then** all tests use the same pinned game version and map, matching what is locally installed.

---

### Edge Cases

- What happens when the engine binary exists but game archives are missing? The framework skips engine-dependent tests and reports the specific missing prerequisite.
- How does the system handle engine startup timeout in slow environments? Timeout is configurable via environment variable with a reasonable default (90 seconds).
- What happens when the reports directory does not exist at test start time? The framework creates it automatically.
- How does the system handle concurrent test runs? Each run uses unique socket paths and session directories to prevent conflicts.
- What happens when a test run is interrupted (Ctrl+C)? The framework performs best-effort cleanup of engine processes and saves a partial report noting the interruption.

## Requirements *(mandatory)*

### Functional Requirements

- **FR-001**: System MUST provide a single entry point script that discovers and executes all active test suites (unit, proxy, integration, persistent, AI) in a defined order.
- **FR-002**: System MUST support filtering tests by category (unit, proxy, integration, persistent, ai) and by individual test name or pattern.
- **FR-003**: System MUST auto-detect the engine binary location, game content directory, and archive cache from the installed BAR AppImage layout without requiring manual environment variable configuration.
- **FR-004**: System MUST gracefully skip engine-dependent test categories when prerequisites are not met, reporting skipped tests clearly in the output and report.
- **FR-005**: System MUST provide a headless test mode that runs all engine-dependent tests against `spring-headless` without requiring a display.
- **FR-006**: System MUST provide a graphical test mode that launches the full BAR game with a display, connects the HighBarV2 AI, and runs a test scenario.
- **FR-007**: System MUST generate a structured test report for every test run, saved to `/reports/testreports/` with a timestamped filename.
- **FR-008**: Test reports MUST include: run timestamp, environment details (engine version, game version, map), test results (pass/fail/skip per test), timing per test and total, and failure diagnostics (error messages, stack traces, engine log excerpts for failed tests).
- **FR-009**: System MUST remove or update all tests that reference outdated game versions, stale fixtures, or defunct features so that zero tests fail due to configuration drift.
- **FR-010**: System MUST organize all tests into clearly labeled categories with a documented directory structure.
- **FR-011**: System MUST manage engine lifecycle (start, health check, shutdown, cleanup) for headless tests, including handling engine crashes gracefully.
- **FR-012**: System MUST use unique socket paths and session directories per test run to support concurrent execution.
- **FR-013**: System MUST create the reports output directory automatically if it does not exist.
- **FR-014**: System MUST produce a summary line at the end of each test run showing total passed, failed, and skipped counts.

### Key Entities

- **Test Suite**: A collection of related tests sharing a framework and execution context (e.g., "F# Integration", "C Proxy", "Persistent Engine").
- **Test Category**: A logical grouping for filtering (unit, proxy, integration, persistent, ai).
- **Test Report**: A structured document capturing results of a single test run, persisted to disk.
- **Engine Session**: A managed lifecycle of a headless or graphical engine instance used by one or more test suites.
- **Test Environment**: The combination of engine version, game version, map, and system configuration under which tests execute.

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: A developer can run the full test suite with a single command and receive a pass/fail summary within 10 minutes for headless mode.
- **SC-002**: Zero tests fail due to stale configuration, outdated game versions, or missing fixtures after consolidation.
- **SC-003**: Every test run (headless or graphical) produces a report file at `/reports/testreports/` containing all required sections.
- **SC-004**: Test reports are generated even when tests fail, capturing failure diagnostics sufficient to debug the issue without re-running the test.
- **SC-005**: Engine prerequisites are auto-detected from the installed BAR AppImage in at least 90% of standard installations, requiring no manual environment variable configuration.
- **SC-006**: The test directory structure is self-documenting — a new developer can understand what each test category covers by reading directory names and a single README.
- **SC-007**: Graphical test mode launches the game and connects the AI within 30 seconds on standard hardware.

## Assumptions

- The BAR AppImage and headless engine binary are installed by the developer prior to running engine-dependent tests. The framework does not install the engine.
- The primary test language is F# with xUnit. Python tests exist but are secondary. C proxy tests use CTest.
- The project uses `dotnet test` for F# test execution, `pytest` for Python, and `ctest` for C proxy tests.
- Test reports use Markdown format for human readability, consistent with existing project reports.
- The headless engine is the primary test mode; graphical mode is for manual/visual validation and is not expected to run in CI.
- The existing persistent test harness (40 tests, single engine instance) is the preferred pattern for engine-dependent tests going forward, as it is significantly faster than per-test engine restarts.
- Reports directory `/reports/testreports/` is local to the repository and may be gitignored.
