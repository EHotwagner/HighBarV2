# Feature Specification: Persistent Engine Test Suite

**Feature Branch**: `011-persistent-engine-tests`  
**Created**: 2026-04-03  
**Status**: Draft  
**Input**: User description: "create a new testsuite that works with a single permanent engine that does not get restarted between test. use the cheat functions to reset between tests. start with a few simple tests, diagnose and fix any errors and get more complex/comprehensive over time. stop when a testrun takes more than 10mins."

## User Scenarios & Testing *(mandatory)*

### User Story 1 - Run Tests Against a Single Persistent Engine (Priority: P1)

A developer runs a test suite that launches the game engine once at the start and keeps it running for the entire duration of all tests. Between each test, cheat commands reset the game state (destroy units, reset resources) so each test begins from a clean slate without the overhead of restarting the engine process. This dramatically reduces total test execution time compared to the existing suite which restarts the engine per test collection.

**Why this priority**: The persistent engine is the core architectural change that enables everything else. Without it, cheat-based resets have no purpose.

**Independent Test**: Can be verified by running the suite and observing that only one engine process is started, all tests pass, and the total wall-clock time is significantly less than restarting the engine for each test group.

**Acceptance Scenarios**:

1. **Given** no engine is running, **When** the test suite starts, **Then** exactly one engine process is launched and remains running until all tests complete.
2. **Given** a test has just finished and modified game state, **When** the next test begins, **Then** cheat commands reset the game state so the new test starts from a known clean baseline.
3. **Given** the engine crashes mid-suite, **When** the crash is detected, **Then** remaining tests are skipped with a clear diagnostic message including engine logs.

---

### User Story 2 - Simple Smoke Tests Validate Reset Mechanism (Priority: P1)

The suite starts with a few simple tests that verify the reset mechanism itself works correctly: after reset, no leftover units exist, resources are at expected starting values, and the game frame counter continues (since the engine was never restarted).

**Why this priority**: If the reset mechanism doesn't work reliably, no subsequent tests can be trusted. This must be validated first.

**Independent Test**: Run only the smoke tests and verify that each one sees a clean game state despite sharing a single engine instance.

**Acceptance Scenarios**:

1. **Given** units were spawned in a previous test, **When** the reset runs before the next test, **Then** no units from the previous test remain.
2. **Given** resources were modified in a previous test, **When** the reset runs before the next test, **Then** resources are at the expected baseline values.
3. **Given** the engine has been running since suite start, **When** a reset occurs, **Then** the game frame number continues incrementing (it does not reset to zero).

---

### User Story 3 - Progressive Test Complexity (Priority: P2)

After smoke tests pass, additional tests exercise increasingly complex scenarios: spawning and moving units, building structures, combat interactions, resource management, and multi-step AI sequences. Tests are added incrementally, with each new tier building confidence that the persistent engine and reset mechanism handle more demanding workloads.

**Why this priority**: Once the foundation is proven reliable (P1 stories), progressively harder tests catch regressions in game logic and the client library under sustained engine operation.

**Independent Test**: Each complexity tier can be run independently (though all share the persistent engine). A failing complex test does not invalidate simpler tests.

**Acceptance Scenarios**:

1. **Given** a clean reset state, **When** a unit spawn test runs, **Then** the spawned unit appears and can be queried.
2. **Given** a clean reset state, **When** a movement test runs, **Then** unit position changes are observed within expected frame count.
3. **Given** a clean reset state, **When** a build test runs, **Then** a UnitCreated event fires for the new structure.
4. **Given** a clean reset state, **When** a combat test runs, **Then** UnitDamaged and/or UnitDestroyed events are observed.

---

### User Story 4 - Suite Completes Within Time Budget (Priority: P2)

The entire test suite completes within 10 minutes. If adding more tests would push the total run time beyond 10 minutes, the suite stops growing at that point. This ensures the suite remains practical for regular developer use.

**Why this priority**: A test suite that takes too long gets skipped by developers. The 10-minute cap keeps it usable as part of the development workflow.

**Independent Test**: Run the full suite with a timer and verify total elapsed time is under 10 minutes.

**Acceptance Scenarios**:

1. **Given** all tests in the suite, **When** the full suite is executed, **Then** total wall-clock time is under 10 minutes.
2. **Given** the suite is at the 10-minute boundary, **When** a developer considers adding more tests, **Then** the existing test count and execution time provide clear guidance on remaining budget.

---

### Edge Cases

- What happens if the engine becomes unresponsive but doesn't crash (hung process)?
- What happens if a cheat reset command fails or is only partially applied?
- What happens if a test leaves the game in an unrecoverable state that the reset mechanism cannot fix?
- What happens if the engine runs out of memory after many test cycles without restart?

## Requirements *(mandatory)*

### Functional Requirements

- **FR-001**: The test suite MUST launch exactly one engine process for the entire test run.
- **FR-002**: Between each test, the suite MUST reset game state using cheat commands (unit destruction, resource reset) rather than restarting the engine.
- **FR-003**: The reset mechanism MUST remove all units created during the previous test.
- **FR-004**: The reset mechanism MUST restore resources to a known baseline value.
- **FR-005**: The suite MUST detect engine crashes and skip remaining tests with diagnostic output.
- **FR-006**: The suite MUST include smoke tests that validate the reset mechanism itself before running more complex tests.
- **FR-007**: The suite MUST include tests of increasing complexity: unit spawning, movement, building, combat, and multi-step scenarios.
- **FR-008**: The suite MUST complete all tests within 10 minutes of wall-clock time.
- **FR-009**: Test ordering MUST be deterministic (simple tests first, complex tests later) to support incremental debugging.
- **FR-010**: Each test MUST be independently meaningful - a failure in one test MUST NOT cause cascading failures in subsequent tests (assuming reset works correctly).
- **FR-011**: The suite MUST reuse the existing client library, command builders, and event types without modification.

### Key Entities

- **Persistent Engine**: A single game engine process that lives for the entire test suite run, accepting commands and emitting events continuously.
- **Reset Cycle**: The sequence of cheat commands executed between tests to return the game to a clean baseline state.
- **Test Tier**: A grouping of tests by complexity level (smoke, basic, intermediate, advanced) that determines execution order.

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: The full test suite executes in under 10 minutes wall-clock time.
- **SC-002**: Only one engine process is started per suite run (verified by process count or log inspection).
- **SC-003**: All tests pass reliably when run in sequence with cheat-based resets between them.
- **SC-004**: Each test begins with a verifiably clean game state (no leftover units, baseline resources).
- **SC-005**: Suite startup time (engine launch to first test) is under 30 seconds.
- **SC-006**: Individual test reset time (between tests) is under 5 seconds.

## Assumptions

- The existing cheat commands (GiveMeNewUnit, GiveMeResource, CallLuaRules) are sufficient to implement a full game state reset, potentially supplemented by SendTextMessage with cheat-mode commands.
- The engine is stable enough to run continuously for 10+ minutes without memory leaks or crashes under normal test workloads.
- The existing game configuration (game-setup.txt template) works for persistent engine operation without modification beyond what's needed for the new harness.
- The existing HighBarClient can maintain a connection for the full duration of the test suite without reconnection.
- xUnit test ordering can be controlled sufficiently to enforce the simple-to-complex execution sequence.
- The engine's cheat mode is enabled by default in the test configuration (spectator mode with AI players).
