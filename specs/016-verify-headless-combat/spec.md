# Feature Specification: Verify Headless Combat and Fix Test Errors

**Feature Branch**: `016-verify-headless-combat`  
**Created**: 2026-04-04  
**Status**: Draft  
**Input**: User description: "run the tests for the last feature, fix any errors. check if there really is no combat in headless, which i doubt."

## Clarifications

### Session 2026-04-04

- Q: If headless combat is confirmed working, should this feature restructure the test architecture or just document the finding? → A: Document finding only — restructure test architecture in a follow-up feature.

## User Scenarios & Testing *(mandatory)*

### User Story 1 - Run Feature 015 Test Suite and Fix Errors (Priority: P1)

A developer runs the full AI validation test suite from Feature 015 (end-to-end, non-combat, competitive, and combat tests) and identifies all compilation errors, missing dependencies, and runtime failures. Each error is diagnosed and fixed so the test suite compiles and executes without infrastructure failures.

**Why this priority**: The test suite must compile and run before any validation or combat investigation can proceed. Broken tests block all other work.

**Independent Test**: Can be fully tested by running `dotnet build` on the AI test project and verifying zero compilation errors and no infrastructure-level failures (test logic failures are acceptable at this stage).

**Acceptance Scenarios**:

1. **Given** the AI test project at `tests/ai/fsharp/`, **When** a developer runs `dotnet build`, **Then** the project compiles with zero errors.
2. **Given** a compiled test project, **When** a developer runs `dotnet test`, **Then** all tests execute (pass, fail, or skip) without crashes or unhandled exceptions.
3. **Given** test failures due to missing fixtures or configuration, **When** the developer reviews the error output, **Then** each failure has a clear root cause and is fixed or documented.

---

### User Story 2 - Empirically Verify Headless Combat Capability (Priority: P1)

A developer runs a controlled headless BAR game with two opposing teams of combat units placed at close range and monitors for combat-related events (WeaponFired, UnitDamaged, UnitDestroyed). The goal is to independently verify or refute the prior finding (from Feature 014) that headless BAR does not simulate weapon physics.

**Why this priority**: The headless combat limitation claim from Feature 014 directly shapes the entire test architecture (headless vs. live engine split). If the claim is wrong, the test infrastructure can be significantly simplified. This environment has GPU passthrough and a full BAR installation, making live verification possible.

**Independent Test**: Can be tested by spawning assault units for opposing teams in a headless game, advancing 2000+ frames, and checking whether any WeaponFired/UnitDamaged/UnitDestroyed events are received by the AI callback.

**Acceptance Scenarios**:

1. **Given** a headless BAR engine with two AI-controlled teams, **When** combat units from opposing teams are placed within weapon range, **Then** the test records whether WeaponFired events are generated within 2000 frames.
2. **Given** the headless combat test completes, **When** results are analyzed, **Then** a clear determination is made: either combat events occur (refuting the prior finding) or they do not (confirming it).
3. **Given** the combat verification result, **When** it differs from the Feature 014 finding, **Then** the implications for test architecture are documented as recommendations for a follow-up feature (no architectural changes are made within this feature).

---

### User Story 3 - Validate Test Results Against Success Criteria (Priority: P2)

After fixing errors and verifying combat capability, a developer runs the full test suite and evaluates results against the success criteria defined in Feature 015 (SC-001 through SC-008). A validation report is generated summarizing pass/fail status for each criterion.

**Why this priority**: Once tests run and combat capability is understood, the actual validation results matter for assessing AI quality. This depends on US1 and US2 being complete.

**Independent Test**: Can be tested by running the full suite and checking the generated markdown report for completeness and accuracy of pass/fail determinations.

**Acceptance Scenarios**:

1. **Given** a working test suite and known combat capability, **When** the full test suite runs, **Then** a markdown validation report is generated with pass/fail for each success criterion.
2. **Given** the validation report, **When** a developer reviews it, **Then** each criterion has supporting evidence (game counts, percentages, timestamps).

---

### Edge Cases

- What happens when the headless engine crashes during the combat verification test?
- How does the system handle partially completed game runs where some games succeed and others fail?
- What if the headless engine supports combat in newer versions but not older ones (version-dependent behavior)?
- What happens when the test suite has interdependent failures (one fix cascades into other test changes)?

## Requirements *(mandatory)*

### Functional Requirements

- **FR-001**: The AI test project MUST compile without errors using `dotnet build`.
- **FR-002**: All test fixtures and configuration files referenced by tests MUST exist and be correctly formatted.
- **FR-003**: The test harness MUST successfully launch a headless BAR game session and receive AI callbacks.
- **FR-004**: A dedicated combat verification test MUST spawn opposing combat units and monitor for WeaponFired, UnitDamaged, and UnitDestroyed events over a sufficient number of frames.
- **FR-005**: The combat verification test MUST produce a clear, unambiguous result indicating whether headless combat events are generated.
- **FR-006**: All test error fixes MUST be backward-compatible with the existing test infrastructure from Feature 015.
- **FR-007**: A validation report MUST be generated summarizing test outcomes and success criteria pass/fail status.

### Key Entities

- **GameOutcome**: Record of a single game's results including milestones, frame counts, and combat event counts.
- **CombatVerificationResult**: Summary of whether headless engine produces combat events, including event counts and frame ranges tested.
- **ValidationReport**: Markdown document with per-criterion pass/fail and supporting evidence.

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: The AI test project compiles with zero errors and zero warnings related to test code.
- **SC-002**: 100% of tests execute without infrastructure failures (compilation errors, missing files, unhandled exceptions).
- **SC-003**: The headless combat verification test runs at least one game with opposing combat units for 2000+ frames and produces a definitive yes/no answer on combat event generation.
- **SC-004**: If headless combat works, at least one WeaponFired event is recorded; if it does not work, zero combat events are recorded across all test frames.
- **SC-005**: A validation report is produced covering all Feature 015 success criteria (SC-001 through SC-008) with pass/fail determinations.
- **SC-006**: All test fixes are documented with root cause and resolution.

## Out of Scope

- Restructuring the Feature 015 test architecture (live vs. headless split) — even if headless combat is confirmed working, architecture changes belong in a follow-up feature.
- Adding new AI behaviors or strategies beyond what Feature 015 already implements.
- Modifying the proxy shared library or engine configuration beyond what is needed to run existing tests.

## Assumptions

- The headless BAR installation in this environment uses spring-headless 2025.06.21 (same version referenced in Feature 005).
- The full BAR installation with GPU passthrough can run the live graphical engine if needed for comparison testing.
- The Feature 015 test code exists in `tests/ai/fsharp/` and follows the architecture documented in the 015 spec and plan.
- The proxy shared library is already built and functional from prior features.
- Game setup fixtures (`game-setup-e2e.txt`, `game-setup-barb.txt`) exist in `tests/fixtures/`.
- The BarData library and HighBar.Client are built and available as in-repo dependencies.
