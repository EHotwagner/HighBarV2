# Feature Specification: Diagnose and Fix Persistent Test Gaps

**Feature Branch**: `013-diagnose-fix-test-gaps`  
**Created**: 2026-04-04  
**Status**: Draft  
**Input**: User description: "Diagnose and fix all problems encountered in 012-harden-persistent-tests: DefId mismatch, zero combat events, SelfDestruct event gaps, engine crashes on large spawns. Investigate root causes via engine internals and CircuitAI reference implementation."

## User Scenarios & Testing *(mandatory)*

### User Story 1 - Engine DefId Discovery (Priority: P1)

As a test author, I need the test harness to know the engine's actual unitDefId-to-unitName mapping so that BuildCommand and other defId-dependent commands work correctly, rather than relying on BarData's alphabetical ordering which diverges from the engine's internal assignment.

**Why this priority**: This is the root cause of BuildCommand failures and incorrect unit classification in the discovery registry. Every test that relies on knowing *which* unit it spawned is affected. Without this, the test suite cannot verify build workflows or targeted unit interactions.

**Independent Test**: Can be validated by spawning a unit by defId, querying its name via engine Lua, and confirming the name matches the registry entry.

**Acceptance Scenarios**:

1. **Given** the engine is running with BAR game content, **When** the harness initializes, **Then** it retrieves a complete defId-to-unitName mapping from the engine (covering all valid defIds).
2. **Given** a defId-to-unitName mapping exists, **When** the harness classifies units (builder, armed, mobile, building, economy), **Then** classifications match the actual engine unit properties rather than BarData index assumptions.
3. **Given** the correct defId mapping is available, **When** a test issues a BuildCommand with a builder's actual buildable defId, **Then** the engine produces a UnitCreated event for the nanoframe.
4. **Given** a commander unit exists, **When** the harness queries its build options, **Then** it receives the list of defIds the commander can actually build.

---

### User Story 2 - Combat Event Delivery (Priority: P1)

As a test author, I need the test harness to reliably receive combat events (EnemyEnterLOS, UnitDamaged, EnemyDamaged, UnitDestroyed, EnemyDestroyed) so that combat tests can assert on actual outcomes rather than just engine survival.

**Why this priority**: Combat event assertions are the second largest gap in test coverage. Without them, combat tests are reduced to "engine didn't crash" checks, which provide minimal confidence in game logic correctness.

**Independent Test**: Can be validated by spawning armed units near an enemy, issuing FightCommand, and observing at least one damage or LOS event within a reasonable frame window.

**Acceptance Scenarios**:

1. **Given** a friendly armed unit is spawned within weapon range of an enemy unit, **When** the engine runs for sufficient frames, **Then** at least one UnitDamaged or EnemyDamaged event is received.
2. **Given** a friendly unit is moved toward an enemy position, **When** the unit enters visual range, **Then** an EnemyEnterLOS event is received.
3. **Given** a friendly armed unit attacks a weak enemy, **When** the enemy's health reaches zero, **Then** a UnitDestroyed or EnemyDestroyed event is received.
4. **Given** the investigation identifies a root cause (proxy event filtering, team ownership of cheat-spawned units, LOS configuration, or enemy commander already dead), **When** the fix is applied, **Then** all three event categories (LOS, damage, destroy) are observable.

---

### User Story 3 - SelfDestruct Event Verification (Priority: P2)

As a test author, I need SelfDestructCommand to produce observable UnitDestroyed events so that the self-destruct test can assert on the actual outcome.

**Why this priority**: SelfDestruct is a single command with a known countdown timer. The fix is likely straightforward once the frame budget or event delivery path is understood.

**Independent Test**: Can be validated by spawning a unit, issuing SelfDestructCommand, running sufficient frames, and checking for UnitDestroyed.

**Acceptance Scenarios**:

1. **Given** a unit is spawned, **When** SelfDestructCommand is issued and the engine runs for at least 300 frames (10 seconds at 30fps), **Then** a UnitDestroyed event is received for that unit.
2. **Given** the self-destruct countdown is game-speed-dependent, **When** the test accounts for the actual game speed of the headless engine, **Then** the frame budget is sufficient for the countdown to complete.

---

### User Story 4 - Reliable Large-Scale Spawn Tests (Priority: P2)

As a test author, I need to spawn large numbers of units (up to all valid defIds) without engine crashes, so that the exhaustive spawn test achieves its intended coverage.

**Why this priority**: The exhaustive spawn test was reduced from 953 to 200 defIds due to crashes. Understanding whether the crashes are caused by unit count limits, specific bugged defIds, or incomplete state cleanup is necessary to maximize spawn coverage.

**Independent Test**: Can be validated by systematically binary-searching for crash-causing defId ranges and isolating whether specific defIds or total unit count triggers the crash.

**Acceptance Scenarios**:

1. **Given** the engine has a maximum unit count, **When** spawns approach that limit, **Then** the harness detects the limit and works within it (e.g., resetting between batches at a safe threshold).
2. **Given** some defIds may reference invalid or problematic unit definitions, **When** those defIds are spawned, **Then** the harness identifies which specific defIds cause crashes and excludes them.
3. **Given** ResetGameState may not fully clean engine state, **When** multiple batches are spawned with resets between them, **Then** cumulative state does not cause instability.
4. **Given** the root cause is identified (unit count limit vs. bugged defIds vs. incomplete reset), **When** the fix is applied, **Then** at least 90% of all valid defIds can be spawned successfully across batches.

---

### User Story 5 - Strengthen Weakened Test Assertions (Priority: P3)

As a test author, once the root causes above are fixed, I need the weakened T3, T4, T6.2, T7, and T8 tests restored to their original spec-level assertions so the test suite provides meaningful coverage guarantees.

**Why this priority**: This is the payoff story. It depends on the diagnostic and fix work from P1/P2 stories and converts "engine didn't crash" tests back into "correct behavior was observed" tests.

**Independent Test**: Can be validated by running the full T0-T8 suite and confirming all originally-specified assertions now pass.

**Acceptance Scenarios**:

1. **Given** DefId mapping is resolved, **When** T3 build tests run, **Then** they assert UnitCreated for nanoframes and UnitFinished for completed buildings using real BuildCommand.
2. **Given** combat events are flowing, **When** T4 combat tests run, **Then** they assert UnitDamaged, EnemyDamaged, and UnitDestroyed from actual combat.
3. **Given** SelfDestruct events work, **When** T6.2 runs, **Then** it asserts UnitDestroyed after SelfDestructCommand.
4. **Given** spawn crashes are resolved, **When** T7 runs, **Then** it covers all valid defIds (or documents exactly which are invalid).
5. **Given** combat events and large spawns work, **When** T8 runs, **Then** it uses 100+ units and asserts DamageEvents > 0 and DestroyedEvents > 0.

### Edge Cases

- What happens if the engine's Lua environment does not have a handler for CallLuaRulesCommand queries? The defId discovery must fall back gracefully.
- What happens if the enemy NullAI commander is destroyed before combat tests run? The harness must verify enemy existence or spawn enemy units explicitly.
- What happens if certain defIds are valid but represent units that cannot exist on the current map (e.g., naval units on a land map)? These should be categorized separately, not treated as failures.
- What happens if the headless engine runs at a different game speed than expected, affecting frame-to-time calculations for SelfDestruct and combat?

## Requirements *(mandatory)*

### Functional Requirements

- **FR-001**: The harness MUST discover the engine's actual defId-to-unitName mapping at initialization, independent of BarData's index ordering.
- **FR-002**: The harness MUST determine each commander's actual build options (list of buildable defIds) from the engine.
- **FR-003**: The harness MUST receive and surface combat events (EnemyEnterLOS, UnitDamaged, EnemyDamaged, UnitDestroyed, EnemyDestroyed) to test code.
- **FR-004**: The harness MUST verify that the enemy team has at least one living unit before running combat tests.
- **FR-005**: SelfDestructCommand MUST produce an observable UnitDestroyed event within a known frame budget.
- **FR-006**: The exhaustive spawn test MUST identify the root cause of engine crashes (unit count limit vs. specific defIds vs. incomplete reset) and handle it appropriately.
- **FR-007**: All weakened test assertions (T3, T4, T6.2, T7, T8) MUST be restored to their original specification-level assertions once root causes are fixed.
- **FR-008**: The harness MUST capture and surface engine log output (infolog.txt, stderr) on test failure for diagnostic purposes.

### Key Entities

- **DefIdMapping**: A verified mapping from engine-internal unitDefId to unit name, properties, and build options.
- **CombatEventStream**: The pipeline through which combat events flow from engine to AI callback to proxy to client to test assertions.
- **SpawnBlacklist**: A set of defIds known to crash or destabilize the engine, discovered empirically.

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: BuildCommand tests produce UnitCreated events for nanoframes using engine-verified defIds.
- **SC-002**: Combat tests observe at least one event from each category (LOS, damage, destroy) within 600 frames of engagement.
- **SC-003**: SelfDestructCommand produces a UnitDestroyed event within 500 frames.
- **SC-004**: The exhaustive spawn test covers at least 90% of all valid engine defIds without crashes.
- **SC-005**: All 38 existing tests continue to pass, with weakened assertions restored to full strength where root causes are fixed.
- **SC-006**: Root cause for each of the 4 problems is documented with evidence, not just hypothesized.

## Clarifications

### Session 2026-04-04

- Q: If the proxy C code is filtering/dropping combat events, are proxy modifications in scope? → A: Yes — proxy C code changes are in scope. Fix event forwarding at the source, since the proxy is the engine's AI interface and combat events are fundamental to any AI, not just tests.

## Assumptions

- The Spring headless engine supports querying unit definitions and build options via the AI callback interface or Lua, as demonstrated by CircuitAI's use of `UnitDef->GetUnitDefId()` and `GetUnitDefs()`.
- The proxy (C shared library) is in scope for modifications. If it filters or drops engine callback events, the proxy C code will be fixed to forward them correctly.
- The NullAI opponent produces a commander unit at game start that persists unless explicitly destroyed.
- The headless engine game speed is deterministic and can be accounted for in frame budget calculations.
- CircuitAI's approach to callback registration and event handling (standard `handleEvent` dispatch, no special LOS setup) applies to our proxy architecture as well, meaning combat events should flow automatically without special configuration.
