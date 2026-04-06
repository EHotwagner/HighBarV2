# Feature Specification: Replace Mock Tests with Live Headless Engine Tests

**Feature Branch**: `022-live-headless-tests`  
**Created**: 2026-04-05  
**Status**: Draft  
**Input**: User description: "remove as many mockup tests as possible and replace them with live headless ones. take a look at how FSBarV1 handles live headless testing. headless tests also simulate faithfully combat."

## User Scenarios & Testing *(mandatory)*

### User Story 1 - Convert F# Unit Tests to Live Engine Tests (Priority: P1)

A developer runs the test suite and gets confidence that command builders, event parsing, and client state transitions work correctly against the real engine rather than fabricated mock data. Tests that previously validated command serialization and event handling in isolation now run against a live headless engine instance, catching integration mismatches that mocks would miss.

**Why this priority**: The F# unit tests in `tests/unit/fsharp/` test command building and protocol handling with no engine interaction. These are the most straightforward candidates for conversion since HighBarV2 already has a working persistent engine fixture that can validate the same behaviors against the real engine. Converting these first delivers the highest confidence gain.

**Independent Test**: Can be fully tested by running `dotnet test tests/persistent/fsharp/` and verifying that equivalent coverage exists for every scenario currently in `tests/unit/fsharp/CommandBuilderTests.fs`.

**Acceptance Scenarios**:

1. **Given** command builder tests exist in the unit tier, **When** equivalent live-engine tests are added to the persistent tier, **Then** all command builder behaviors are validated against the real engine with identical pass/fail outcomes.
2. **Given** a developer runs the persistent test tier, **When** tests execute against the headless engine, **Then** command construction, dispatch, and response handling are verified end-to-end.

---

### User Story 2 - Convert C Proxy Mock Tests to Live Engine Validation (Priority: P2)

A developer validates that the C proxy correctly serializes, deserializes, and dispatches callbacks by running tests against a live headless engine instance. The proxy's protocol conformance is verified against actual engine callback data rather than hand-crafted mock responses, catching discrepancies between mock behavior and real engine behavior.

**Why this priority**: The C proxy tests in `proxy/tests/` use `mock_engine.c` to simulate engine callbacks. While some low-level serialization tests are inherently unit-level (and should remain), callback dispatch and roundtrip tests benefit from live engine validation. This is P2 because the proxy layer is lower-level and some mock tests may need to remain for fast feedback on protocol changes.

**Independent Test**: Can be tested by running live engine integration tests that exercise the proxy's callback dispatch path and comparing results against the existing mock test expectations.

**Acceptance Scenarios**:

1. **Given** mock callback dispatch tests exist in CTest, **When** live engine equivalents are added to the integration or persistent tier, **Then** callback dispatch behavior is validated against real engine data.
2. **Given** serialization roundtrip tests exist with mock data, **When** live engine tests capture real protobuf messages, **Then** roundtrip fidelity is confirmed against actual engine payloads.

---

### User Story 3 - Validate Combat Simulation Fidelity in Headless Mode (Priority: P2)

A developer confirms that headless engine tests faithfully simulate combat mechanics (weapon physics, damage, unit destruction) by running combat-focused tests and comparing outcomes against expected game behavior. This ensures the headless test infrastructure is trustworthy for validating AI combat logic.

**Why this priority**: The user explicitly stated that "headless tests also simulate faithfully combat." Combat fidelity validation is essential for the test suite to be a reliable replacement for mock tests. HighBarV2 already has `T4_CombatTests.fs`, `T8_LargeScaleCombat.fs`, and `HeadlessCombatVerification.fs` as starting points.

**Independent Test**: Can be tested by running combat scenarios in the persistent tier and verifying that unit damage, destruction, and weapon mechanics produce expected outcomes.

**Acceptance Scenarios**:

1. **Given** a combat scenario with known unit matchups, **When** run in headless mode, **Then** damage values, unit destruction timing, and combat outcomes match expected game mechanics.
2. **Given** the existing headless combat verification tests, **When** the test suite runs, **Then** all combat fidelity checks pass confirming headless mode accurately simulates weapon physics.

---

### User Story 4 - Adopt FSBarV1 Headless Testing Patterns (Priority: P3)

A developer benefits from proven headless testing patterns established in the FSBarV1 project, including the EngineFixture lifecycle pattern, frame-based test execution via `client.Run(frameCount, handler)`, and stateless test design. Patterns that HighBarV2 has not yet adopted are identified and incorporated where they improve test reliability or coverage.

**Why this priority**: FSBarV1 is the reference implementation for headless testing patterns. While HighBarV2 has already evolved beyond FSBarV1 (persistent fixtures, state reset, AI orchestration), there may be specific patterns (such as stateless single-engine fixtures, map query tests, or scenario test designs) worth adopting. This is P3 because it's about learning from the predecessor rather than converting specific tests.

**Independent Test**: Can be tested by comparing FSBarV1's test patterns against HighBarV2's and verifying that any adopted patterns integrate cleanly with the existing test infrastructure.

**Acceptance Scenarios**:

1. **Given** FSBarV1 has live tests for map queries and grid data, **When** equivalent tests are added to HighBarV2's persistent tier, **Then** map data queries are validated against the live engine.
2. **Given** FSBarV1 uses a stateless EngineFixture pattern, **When** HighBarV2 evaluates its fixture design, **Then** any improvements to fixture reliability or startup time are incorporated.

---

### Edge Cases

- What happens when the headless engine is not available? Tests that require the engine should be skipped gracefully with clear skip messages, not fail.
- How does the test suite handle engine crashes mid-test? The fixture must detect engine process termination and report a clear failure rather than hanging.
- What happens when a mock test covers a scenario that cannot be replicated with a live engine (e.g., deliberate protocol corruption)? These mock tests should be retained and documented as intentionally mock-based.
- How are test execution times managed given that live engine tests are slower than mock tests? The tiered execution model (unit/proxy fast, integration/persistent slower) must be preserved with clear category separation.

## Clarifications

### Session 2026-04-05

- Q: What should happen to mock tests once replaced by live headless equivalents? → A: Delete replaced mock tests entirely.
- Q: How should combat fidelity be measured in headless tests? → A: Outcome-level validation -- correct unit dies, correct side wins, damage is non-zero and directionally correct. No frame-exact matching required.
- Q: Is there a maximum acceptable duration for the full test suite? → A: No hard time limit. The tiered execution model already provides fast feedback via unit/proxy tiers; engine-dependent tiers run on-demand.

## Requirements *(mandatory)*

### Functional Requirements

- **FR-001**: The project MUST identify all mock-based tests that can be replaced with live headless engine equivalents and migrate them.
- **FR-002**: Mock tests that serve a unique purpose not achievable with a live engine (e.g., protocol corruption testing, error injection) MUST be retained and documented.
- **FR-009**: Mock tests that have been successfully replaced by live headless equivalents MUST be deleted from the codebase to avoid duplicate maintenance burden.
- **FR-003**: New live engine tests MUST provide equivalent or greater coverage compared to the mock tests they replace.
- **FR-004**: All live engine tests MUST use the existing headless engine infrastructure (`spring-headless`, Unix domain sockets, frame-based protocol).
- **FR-005**: Combat-focused tests MUST validate that headless mode faithfully simulates weapon physics, damage calculation, and unit destruction.
- **FR-006**: The test runner MUST continue to support tiered execution with clear separation between engine-dependent and engine-independent tests.
- **FR-007**: Tests MUST skip gracefully when the headless engine is not available, providing a clear skip message rather than failing.
- **FR-008**: Applicable patterns from FSBarV1's headless testing approach (EngineFixture lifecycle, map queries, scenario tests) MUST be evaluated and adopted where they improve coverage or reliability.

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: At least 80% of mock-based F# unit tests are replaced with live headless engine equivalents while maintaining full behavioral coverage.
- **SC-002**: At least 50% of mock-based C proxy tests (callback dispatch, roundtrip) are replaced or supplemented with live engine validation tests.
- **SC-003**: All combat-focused tests pass in headless mode with outcome-level validation: the correct unit is destroyed, the correct side wins, and damage values are non-zero and directionally correct. Frame-exact matching is not required.
- **SC-004**: The full test suite (all tiers) completes successfully when the headless engine is available.
- **SC-005**: When the headless engine is unavailable, all engine-dependent tests are skipped with clear messages and no failures.
- **SC-006**: No reduction in overall test coverage compared to the current mock-based test suite.

## Assumptions

- The headless engine (`spring-headless`) is available in the development environment and faithfully simulates game mechanics including combat.
- The existing persistent engine fixture pattern (single engine instance with state reset) is the preferred approach for migrated tests to minimize engine startup overhead.
- Some mock tests (particularly low-level serialization and deliberate error-path tests) will remain as mock-based tests and this is acceptable.
- FSBarV1 is available as a reference at `/home/developer/projects/FSBarV1/` and its patterns can be adapted for HighBarV2's architecture.
- The tiered test execution model (unit, proxy, integration, persistent, ai) will be preserved with engine-dependent tests clearly separated from engine-independent tests.
