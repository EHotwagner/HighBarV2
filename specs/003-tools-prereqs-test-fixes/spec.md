# Feature Specification: Build Tools, Install Prerequisites, and Validate Test Suite

**Feature Branch**: `003-tools-prereqs-test-fixes`  
**Created**: 2026-04-02  
**Status**: Draft  
**Input**: User description: "create the tools and prerequisites then run the tests and fix/document any failures."

## User Scenarios & Testing *(mandatory)*

### User Story 1 - Build All Project Components from Clean Checkout (Priority: P1)

A developer clones the HighBarV2 repository onto a fresh machine and wants to build every component (proxy shared library, F# client, Python client, and developer tools) in the correct dependency order so they can begin working on the project.

**Why this priority**: Without a successful build of all components, no tests can run and no development tools can be used. This is the foundational prerequisite for everything else.

**Independent Test**: Can be tested by running the full build sequence on a clean checkout and verifying that all build artifacts are produced without errors.

**Acceptance Scenarios**:

1. **Given** a clean repository checkout with required system dependencies installed (CMake 3.20+, .NET 10.0 SDK, Python 3.10+, C11 compiler, protobuf-c, buf CLI), **When** the developer follows the documented build steps, **Then** the proxy shared library (libSkirmishAI.so), F# client library, Python client package, and all three tools (EchoAI, ReferenceAI, Replay) are built successfully.
2. **Given** a clean checkout, **When** generated protobuf code is missing, **Then** running `buf generate` produces the required generated sources for both C and Python before downstream builds proceed.
3. **Given** all components are built, **When** the developer lists the build artifacts, **Then** each artifact exists at its expected output path and is non-empty.

---

### User Story 2 - Run the Full Test Suite and Get a Clear Pass/Fail Report (Priority: P2)

A developer who has completed the build wants to run all tests (C unit tests via ctest, F# integration tests via xUnit, Python integration tests via pytest) and receive a clear report showing which tests pass and which fail.

**Why this priority**: Running the test suite validates the build and reveals any regressions or environment issues. This is the primary feedback loop for project health.

**Independent Test**: Can be tested by executing each test runner (ctest, dotnet test, pytest) and verifying that results are reported with pass/fail status for each test case.

**Acceptance Scenarios**:

1. **Given** the proxy library is built, **When** the developer runs `ctest` in the build directory, **Then** all C unit tests (serialize, deserialize, roundtrip, callbacks) execute and report individual pass/fail results.
2. **Given** the F# client and proxy are built and the headless engine is available, **When** the developer runs `dotnet test` on the integration test project, **Then** all 22 F# integration tests execute and report individual pass/fail results.
3. **Given** the Python client is installed and the headless engine is available, **When** the developer runs `pytest` on the Python integration tests, **Then** all 12 Python integration tests execute and report individual pass/fail results.
4. **Given** the headless engine is not available, **When** integration tests are run, **Then** tests fail gracefully with a clear error message indicating the missing engine rather than cryptic crashes.

---

### User Story 3 - Fix or Document Failing Tests (Priority: P3)

After running the test suite, any test failures are either fixed (if the issue is a bug in test code or production code) or documented (if the failure is due to an environment constraint, known limitation, or external dependency).

**Why this priority**: Resolving or documenting failures ensures the test suite provides reliable signal. Undocumented failures erode trust in the test results.

**Independent Test**: Can be tested by reviewing the failure documentation or re-running previously failing tests to confirm fixes.

**Acceptance Scenarios**:

1. **Given** a test failure caused by a code bug, **When** the developer applies the fix, **Then** the test passes on re-run.
2. **Given** a test failure caused by a missing external dependency (e.g., headless engine not installed), **When** the failure is documented, **Then** the documentation includes the failure reason, affected tests, and steps to resolve the dependency.
3. **Given** all test failures have been addressed, **When** the developer reviews the test results summary, **Then** every test is either passing or has a documented reason for failure with a clear remediation path.

---

### Edge Cases

- What happens when protobuf schema changes but generated code is stale? Build should fail with a clear error pointing to `buf generate`.
- How does the build behave when only some system dependencies are installed (e.g., .NET present but not CMake)? Each component build should fail independently without blocking other components.
- What happens when tests are run before building? Test runners should report a missing dependency error, not silently skip tests.
- How are intermittent test failures (e.g., timing-sensitive integration tests) handled? Flaky tests should be documented with their flakiness pattern and any mitigation applied.

## Requirements *(mandatory)*

### Functional Requirements

- **FR-001**: All project components MUST build successfully in dependency order: protobuf generation, proxy library, F# client, Python client, developer tools.
- **FR-002**: The C proxy unit tests (serialize, deserialize, roundtrip, callbacks) MUST execute via ctest and report individual results.
- **FR-003**: The F# integration tests MUST execute via `dotnet test` and report individual results when the headless engine is available.
- **FR-004**: The Python integration tests MUST execute via pytest and report individual results when the headless engine is available.
- **FR-005**: Each test failure MUST be either fixed with a verified passing re-run or documented with the failure reason, affected test names, and remediation steps.
- **FR-006**: The developer tools (EchoAI, ReferenceAI, Replay) MUST build successfully as part of the overall build process.
- **FR-007**: Build and test failures MUST produce error output that includes the failed component name and a suggested remediation step (e.g., missing dependency name, command to re-run, or link to relevant documentation).

### Key Entities

- **Build Artifact**: A compiled output (shared library, executable, package) produced by a build step, identified by its output path and component name.
- **Test Result**: An individual test case outcome (pass/fail/skip) with associated diagnostic output, belonging to a test suite (C/F#/Python).
- **Failure Report**: A documented test failure including test name, failure reason, error output, and remediation guidance.

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: All project components build from a clean checkout with zero build errors when system dependencies are present.
- **SC-002**: 100% of C unit tests pass after a successful build.
- **SC-003**: The full F# and Python integration test suites run to completion with each test reporting a clear pass, fail, or skip status.
- **SC-004**: Every failing test has either a committed fix or a documented explanation with remediation steps.
- **SC-005**: A developer can go from clean checkout to running all tests in under 10 minutes of manual effort (excluding dependency installation and engine download time).
- **SC-006**: All three developer tools (EchoAI, ReferenceAI, Replay) build and produce runnable executables.

## Assumptions

- The developer machine has the required system-level dependencies installed: CMake 3.20+, a C11 compiler, .NET 10.0 SDK, Python 3.10+, protobuf-c library, and buf CLI.
- The headless BAR engine binary may not be available in all environments; integration tests that require it will be skipped or documented when absent.
- Generated protobuf code is not checked into version control and must be regenerated as part of the build process.
- The focus is on building existing code and running existing tests, not writing new tests or new tools.
- Fixes are limited to what is necessary to make the build and tests pass; no refactoring or feature additions are in scope.
