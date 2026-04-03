# Feature Specification: Fix Remaining Test Failures

**Feature Branch**: `005-fix-test-failures`  
**Created**: 2026-04-03  
**Status**: Draft  
**Input**: User description: "fix the failing tests and write the fixes and failures up in /reports"

## User Scenarios & Testing *(mandatory)*

### User Story 1 - BAR Game Spawns Units in Headless Tests (Priority: P1)

A developer runs the integration test suite against a live `spring-headless` engine with the real BAR game content. The game scenario is configured with the correct modoptions so that BAR's spawn gadget spawns commander units for each team at game start. All 10 unit-dependent tests (UnitCreated, UnitIdle, MoveCommand, StopCommand, BuildCommand, PatrolCommand, Guard/Attack/Repair/Fight, StopAll, unit position query, full AI turn sequence) pass because units exist on the map.

**Why this priority**: 10 of 12 failing tests share this single root cause — no units spawned. Fixing the game configuration unblocks the majority of failures.

**Independent Test**: Run the full F# integration test suite. All tests that depend on unit existence (UnitCreated, MoveCommand, etc.) should pass. The engine infolog should show unit creation events and no "No modoption start position data found" warning.

**Acceptance Scenarios**:

1. **Given** the updated game-setup.txt with BAR-specific modoptions (teamfaction, start positions, StartPosType), **When** the engine launches a headless game, **Then** commander units are spawned for each team within the first 30 game frames.
2. **Given** units are spawned on the map, **When** the test suite issues move/stop/build/patrol commands, **Then** the proxy delivers the commands and returns appropriate event responses.
3. **Given** the updated game configuration, **When** the engine runs with the test harness, **Then** the infolog does not contain "No modoption start position data found" or spawn-related errors.

---

### User Story 2 - Init Event Captured in Tests (Priority: P2)

A developer runs the Init event tests. The test harness captures the Init event that the proxy sends during the very first frame (frame 0), even though the event arrives before the test's `Run()` loop begins. Both Init event tests ("First frame contains Init event" and "Init event received with valid team ID") pass.

**Why this priority**: 2 of 12 failing tests share this root cause. The fix is lower risk and independent of the spawn issue, but affects fewer tests.

**Independent Test**: Run only the two Init event tests. Both should pass, with the Init event visible in the captured frame data containing a valid team ID.

**Acceptance Scenarios**:

1. **Given** the proxy sends an Init event in frame 0 during engine initialization, **When** the test harness captures frames, **Then** the Init event is found in the collected frames regardless of when the frame loop begins.
2. **Given** the Init event is captured, **When** the test inspects the event payload, **Then** it contains a valid team ID (matching the AI's configured team).

---

### User Story 3 - Test Fix Report Written (Priority: P3)

After fixing the test failures, a report is written to `/reports` documenting what was changed, why each fix was needed, the before/after test results, and any remaining issues. This provides a clear audit trail for the project.

**Why this priority**: Documentation is important for continuity but does not unblock any tests. It depends on the fixes being completed first.

**Independent Test**: The report file exists in `/reports`, follows the project's existing report format (numbered iteration, markdown), and accurately describes the changes made and results achieved.

**Acceptance Scenarios**:

1. **Given** test fixes have been applied, **When** the full test suite is run, **Then** a report is generated documenting the before state (11 pass, 12 fail), the fixes applied, and the after state.
2. **Given** any tests still fail after fixes, **When** the report is written, **Then** remaining failures are documented with root cause analysis and next steps.

---

### Edge Cases

- What happens if BAR's spawn gadget requires modoptions not documented in the existing reports (e.g., newer BAR versions changed the spawn logic)?
- How does the system handle the case where the game archive is texture-stripped and the spawn gadget depends on model data?
- What if the Init event arrives in a frame that is consumed during the handshake phase and is not recoverable?

## Requirements *(mandatory)*

### Functional Requirements

- **FR-001**: The game-setup.txt MUST include BAR-specific modoptions for commander spawning (teamfaction, start positions, GameMode).
- **FR-002**: The game-setup.txt MUST use a StartPosType value compatible with BAR's spawn gadget.
- **FR-003**: The game-setup.txt MUST define start boxes or start positions for each ally team so the spawn system knows where to place commanders.
- **FR-004**: The test harness MUST capture the Init event from frame 0 even if it arrives before the test's frame loop begins.
- **FR-005**: The test suite MUST pass all 23 tests when run against a live spring-headless engine with complete BAR game content.
- **FR-006**: A numbered report MUST be written to `/reports` documenting all fixes, their rationale, and before/after test results.
- **FR-007**: The report MUST follow the existing report format and numbering convention established by reports 008-010.

### Key Entities

- **game-setup.txt**: The TDF-format start script template that configures the game scenario for headless testing. Key attributes: MODOPTIONS section, StartPosType, team faction assignments, start box definitions.
- **Init Event**: The first game event sent by the proxy during engine initialization (frame 0). Contains the AI's team ID. Must be captured by the test harness before entering the frame loop.

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: All 23 integration tests pass when run against a live spring-headless engine with BAR game content (up from 11 of 23).
- **SC-002**: The 10 unit-dependent tests pass because commander units are spawned within the first 30 game frames.
- **SC-003**: The 2 Init event tests pass because the Init event is captured and contains a valid team ID.
- **SC-004**: A report exists in `/reports` that documents the root causes, fixes applied, and final test results.

## Clarifications

### Session 2026-04-03

- Q: Is the current game archive complete or still texture-stripped? → A: Full game content is already installed via the BAR launcher, replacing the earlier stripped archive.
- Q: Is updating the Python test harness in scope? → A: No. Only F# tests are in scope; Python harness update is a separate future task.

## Assumptions

- The BAR game content is the full launcher install (Beyond All Reason test-29833-ee0f96a), not the earlier texture-stripped build. The `game_initial_spawn.lua` gadget is fully functional.
- The spring-headless 2025.06.21 engine binary is already installed and functional (proven by the 11 passing tests).
- The proxy shared library is correctly built against real Recoil engine headers (ABI issue already resolved in prior iteration).
- The F# test harness listen-accept architecture is already working (proven by passing connection/event/callback tests).
- The fix for Init event timing can be achieved within the test harness or client code without changes to the proxy itself.
- The recoil-autohost project or BAR game source provides sufficient documentation to determine the correct modoptions for headless AI games.
- Python test harness updates are out of scope; only the F# test suite (23 tests) is targeted.
