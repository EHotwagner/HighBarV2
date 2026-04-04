# Feature Specification: Harden Persistent Engine Tests

**Feature Branch**: `012-harden-persistent-tests`  
**Created**: 2026-04-04  
**Status**: Draft  
**Input**: User description: "Fix Build/combat/LOS events not observed. T3-T4 tests pass but don't actually see UnitFinished, UnitDamaged, or EnemyEnterLOS events. Tests are written observationally. Likely needs more frames, correct unitDefIds for buildable structures, or units positioned closer to enemies. Create and run quick tests for all units/commands. Fix errors. Split those tests in units of manageable time. Last create and test bigger/longer combat scenarios of 1-2 minutes with hundreds of units."

## User Scenarios & Testing *(mandatory)*

### User Story 1 - Fix Observational Tests to Assert Real Events (Priority: P1)

A developer running the persistent engine test suite expects T3 (Build) and T4 (Combat) tests to produce hard assertions on engine events, not just log counts. Currently 6 tests only log event counts without asserting, meaning broken behavior passes silently. These tests must be fixed to use correct unitDefIds (discovered at runtime), appropriate frame counts, and proper positioning so that UnitFinished, UnitDamaged, EnemyEnterLOS, and UnitDestroyed events are actually received and asserted.

**Why this priority**: Silent pass on broken behavior undermines test suite trust. Without real assertions, regressions go undetected.

**Independent Test**: Run `dotnet test --filter "FullyQualifiedName~T3_"` and `dotnet test --filter "FullyQualifiedName~T4_"` — every test must contain at least one assertion on an engine event (not just command acceptance).

**Acceptance Scenarios**:

1. **Given** a spawned builder unit and a valid buildable structure unitDefId, **When** a BuildCommand is issued and sufficient frames elapse, **Then** a UnitCreated event for the structure and eventually a UnitFinished event are received and asserted.
2. **Given** a spawned builder that has completed construction, **When** sufficient frames elapse after UnitFinished, **Then** a UnitIdle event for the builder is received and asserted.
3. **Given** an armed friendly unit and an enemy unit positioned within weapon range, **When** an AttackCommand is issued and sufficient frames elapse, **Then** UnitDamaged or EnemyDamaged events are received and asserted.
4. **Given** an armed unit attacking an enemy with low health, **When** sufficient frames elapse, **Then** UnitDestroyed or EnemyDestroyed events are received and asserted.
5. **Given** a friendly unit moving toward the enemy base, **When** the unit approaches enemy positions, **Then** EnemyEnterLOS events are received and asserted.

---

### User Story 2 - Quick Unit/Command Coverage Tests (Priority: P1)

A developer wants confidence that every command type in the client library works against a live engine. Short, focused tests should verify that each command type (Move, Stop, Patrol, Attack, Guard, Repair, Fight, Build, SelfDestruct, SetWantedMaxSpeed, Reclaim, Custom, SendTextMessage, GiveMeResource, GiveMeNewUnit, CallLuaRules) is accepted by the engine without crashing and produces the expected immediate feedback. Tests should be grouped into manageable batches that each complete quickly.

**Why this priority**: Ensures full command surface area is tested, not just the subset used in scenario tests.

**Independent Test**: Run each command coverage test class individually. Each class should complete in under 60 seconds.

**Acceptance Scenarios**:

1. **Given** a freshly reset engine state, **When** each supported command type is sent to a valid unit, **Then** the engine processes the command without crashing and the subsequent frames execute normally.
2. **Given** a unit receiving a GiveMeNewUnit cheat command with a valid unitDefId, **When** sufficient frames elapse, **Then** a UnitCreated event is received.
3. **Given** a unit receiving a GiveMeResource cheat command, **When** sufficient frames elapse, **Then** the command completes without error.

---

### User Story 3 - Large-Scale Combat Scenarios (Priority: P2)

A developer wants to verify the persistent engine can handle stress scenarios: hundreds of units in active combat over 1-2 minutes of game time. These tests validate that the engine remains stable under load, events continue flowing, the client connection stays alive, and the reset mechanism works after a large battle. This exercises the full event pipeline at scale.

**Why this priority**: Validates engine stability beyond small-scale tests. Catches connection drops and event buffer overflows that only appear under load.

**Independent Test**: Run large-scale scenario tests individually. Each scenario should complete in 1-3 minutes and the engine should remain alive afterward.

**Acceptance Scenarios**:

1. **Given** a freshly reset engine, **When** 100+ friendly units are spawned and directed to fight the NullAI commander for 60+ seconds of game time, **Then** the engine remains alive, events continue flowing, and at least some UnitDamaged/UnitDestroyed/EnemyDamaged events are observed.
2. **Given** a large battle has concluded, **When** ResetGameState is called, **Then** the reset completes in under 30 seconds and the engine is ready for the next test.
3. **Given** a scenario with hundreds of units, **When** the test completes, **Then** the total persistent test suite still finishes within 10 minutes.

---

### User Story 4 - UnitDefId Discovery (Priority: P1)

A developer needs tests that use correct unitDefIds for builders, armed units, buildings, and mobile units rather than hardcoded guesses (1, 2, 10). The fixture or a helper should discover valid unitDefIds at runtime by spawning units with different IDs during initialization and recording which ones produce UnitCreated events. This eliminates silent failures from invalid unitDefIds.

**Why this priority**: Root cause of the missing build/combat events. Without valid unitDefIds, BuildCommand targets non-existent structures, and spawn commands may create the wrong unit types.

**Independent Test**: A discovery test that logs all discovered unitDefIds with their characteristics and asserts that at least one of each category was found.

**Acceptance Scenarios**:

1. **Given** the engine has started, **When** the fixture probes a range of unitDefIds, **Then** it identifies at least one valid builder, one armed unit, one mobile unit, and one buildable structure.
2. **Given** discovered unitDefIds, **When** build tests use the discovered structure ID and combat tests use the discovered armed unit ID, **Then** the expected events (UnitFinished, UnitDamaged) are actually received.

---

### User Story 5 - Exhaustive UnitDef Spawn Test (Priority: P2)

A developer wants to verify that every unit definition in the game (all 953 unitDefs) can be spawned without crashing the engine. Units are spawned in batches of 50, with each batch followed by a reset. This catches unitDefIds that cause engine errors, crashes, or unexpected behavior. The test logs which unitDefIds succeeded and which failed, producing a full compatibility report.

**Why this priority**: Provides complete coverage of the unit definition space. Identifies problematic unitDefIds before they cause failures in other tests.

**Independent Test**: Run the exhaustive spawn test individually. It should complete in under 2 minutes and produce a report of pass/fail per unitDefId.

**Acceptance Scenarios**:

1. **Given** the engine is running, **When** all 953 unitDefIds are spawned in batches of 50, **Then** each batch completes without engine crash, and the engine remains alive after all batches.
2. **Given** a batch of 50 units has been spawned, **When** the batch completes, **Then** the test records how many UnitCreated events were received vs expected, identifying any unitDefIds that failed silently.
3. **Given** all batches have completed, **When** the test finishes, **Then** a summary report shows total success/failure counts and lists any problematic unitDefIds.

---

### Edge Cases

- What happens when a spawned unit is immediately destroyed before the test reads events?
- How does the engine behave when 500+ units exist simultaneously — does event flow slow or buffer?
- What happens when two units of the same type attack each other — are both damage events reported?
- What happens when ResetGameState is called during an active battle with hundreds of units?
- What happens if a unitDefId is invalid (out of range) — does the engine silently ignore it or report an error?

## Requirements *(mandatory)*

### Functional Requirements

- **FR-001**: Test suite MUST discover valid unitDefIds at runtime rather than using hardcoded values
- **FR-002**: Every command type available in the client library MUST have at least one test that verifies engine acceptance
- **FR-003**: Build tests MUST assert on UnitCreated, UnitFinished, and UnitIdle events using discovered builder and structure unitDefIds
- **FR-004**: Combat tests MUST assert on UnitDamaged/EnemyDamaged and UnitDestroyed/EnemyDestroyed events using discovered armed unit IDs
- **FR-005**: Combat tests MUST verify EnemyEnterLOS events by positioning friendly units within sensor range of enemy units
- **FR-006**: Each test class MUST complete in a bounded time (quick tests under 60 seconds, combat scenarios under 3 minutes)
- **FR-007**: Large-scale scenarios MUST spawn 100+ friendly units and run for at least 60 seconds of game time against the NullAI opponent
- **FR-008**: The full test suite (all tiers including new tests) MUST complete within 10 minutes
- **FR-009**: Large-scale scenario reset MUST complete in under 30 seconds
- **FR-010**: Tests MUST report diagnostic output (event counts, timing, unitDefIds used) on failure to aid debugging
- **FR-011**: An exhaustive spawn test MUST attempt to create all 953 unitDefs in batches of 50, resetting between batches, and report success/failure per unitDefId

### Key Entities

- **UnitDefRegistry**: Runtime-discovered mapping of unitDefId to unit characteristics (builder, armed, mobile, building)
- **CommandCoverage**: Set of all command types with their test status (tested, untested)
- **BattleMetrics**: Accumulated event counts and timing data from large-scale scenarios

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: Zero observational-only tests remain — every test contains at least one assertion on engine event outcomes
- **SC-002**: All 17 command types in the client library have at least one live engine test
- **SC-003**: Build tests reliably receive UnitFinished events in 3 consecutive runs
- **SC-004**: Combat tests reliably receive UnitDamaged events in 3 consecutive runs
- **SC-005**: Large-scale scenarios successfully spawn 100+ units and observe combat events
- **SC-006**: Full test suite completes within 10 minutes including large-scale scenarios
- **SC-007**: No flaky tests — 3 consecutive full suite runs all pass
- **SC-008**: Runtime unitDefId discovery finds at least 4 unit categories (builder, armed, mobile, building)
- **SC-009**: Exhaustive unitDef spawn test completes all 953 unitDefs in under 2 minutes and reports results

## Clarifications

### Session 2026-04-04

- Q: How large should each batch be when spawning all 953 unitDefs? → A: Batches of 50 units (~19 batches, balanced speed vs debuggability)

## Assumptions

- The existing persistent engine fixture (PersistentEngineFixture) and reset mechanism work correctly and will be reused
- Cheats are enabled in the proxy (done in feature 011) so GiveMeNewUnitCommand and GiveMeResourceCommand work
- The engine can handle 200+ simultaneous units without crashing (standard for Spring engine games)
- UnitDefIds are stable within a single engine session (same game content version produces same ID assignments)
- Enemy units for combat tests may need to be spawned via cheats since NullAI may not produce units autonomously
- The existing 24 tests from feature 011 will be updated in-place where they have observational gaps, not duplicated
