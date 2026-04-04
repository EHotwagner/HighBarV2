# Feature Specification: AI Validation and Competitive Testing

**Feature Branch**: `015-ai-validation-tests`  
**Created**: 2026-04-04  
**Status**: Draft  
**Input**: User description: "Implement deferred validation tasks from 014: end-to-end game testing (T063/T064), competitive benchmarking against BARb, and full test suite runs (T068a/T068b) using available headless and live graphical engines."

## User Scenarios & Testing *(mandatory)*

### User Story 1 - End-to-End Game Validation Against Do-Nothing AI (Priority: P1)

A developer wants to verify that the AI brain plays complete games without crashing. The system runs 10 consecutive AI-vs-do-nothing-AI games using the headless engine, collects game outcomes (duration, units built, economy milestones), and produces a pass/fail report verifying the AI meets basic competency criteria: builds extractors, produces energy, builds factories, produces combat units, scouts, and wins every game.

**Why this priority**: This is the most fundamental validation — if the AI crashes or stalls, nothing else matters. It also validates the core success criteria (crash-free operation, economy bootstrap, army production, and beating NullAI).

**Independent Test**: Run the validation suite with the headless engine. All 10 games complete without crashes. The report shows pass/fail for each success criterion.

**Acceptance Scenarios**:

1. **Given** the AI code is compiled and headless engine is available, **When** the validation suite runs 10 consecutive games against NullAI, **Then** all 10 games complete without crashes or stalls
2. **Given** a completed game run, **When** the game outcome is analyzed, **Then** the AI has built at least 3 metal extractors and 2 energy structures within 3 minutes in 90% of games
3. **Given** a completed game run, **When** the game outcome is analyzed, **Then** the AI has produced combat units from a factory within 5 minutes in 90% of games
4. **Given** a completed game run, **When** the game outcome is analyzed, **Then** the AI demonstrates combat readiness in 100% of games (army produced, attack commands issued). Note: actual win/loss requires live engine with weapon physics; headless validates competency milestones only.

---

### User Story 2 - Competitive Validation Against BARbarianAI (Priority: P2)

A developer wants to measure the AI's competitive strength by running it against BAR's standard AI opponent (BARbarianAI/BARb). The system runs 10 games using the live graphical engine (via Xvfb), measures survival time, and reports win/loss rates, survival duration, and key metrics. The target is surviving at least 15 minutes in 80% of games.

**Why this priority**: Competitive benchmarking is the ultimate quality gate — it shows whether the AI is useful as an opponent, but it depends on the basic game loop working first (US1).

**Independent Test**: Run 10 games against BARb using Xvfb + live engine. The report shows survival time per game and overall pass/fail for the 15-minute / 80% threshold.

**Acceptance Scenarios**:

1. **Given** a live graphical engine is available via Xvfb, **When** the competitive suite runs 10 games against BARb, **Then** all 10 games launch and complete without infrastructure failures
2. **Given** 10 completed games against BARb, **When** results are analyzed, **Then** the AI survives for at least 15 minutes in at least 8 of 10 games
3. **Given** a completed competitive run, **When** the report is generated, **Then** it shows per-game survival time, win/loss, units produced, and units lost

---

### User Story 3 - Headless Non-Combat Test Suite (Priority: P1)

A developer wants to run a comprehensive non-combat test suite that validates economy management, build orders, unit movement, and scouting in headless mode. The suite runs 20 games and verifies that these systems work reliably (95%+ pass rate).

**Why this priority**: These are fast, headless tests that catch regressions early without needing a graphical engine. They validate the core AI behaviors that don't require weapon physics.

**Independent Test**: Run the headless AI test suite. 95% or more of test assertions pass across 20 game runs.

**Acceptance Scenarios**:

1. **Given** the headless engine is available, **When** the non-combat test suite runs, **Then** economy tests verify the AI achieves positive income within 2 minutes
2. **Given** the headless engine is available, **When** the non-combat test suite runs, **Then** build order tests verify the AI follows the opening sequence (mex, energy, factory)
3. **Given** 20 completed test runs, **When** results are aggregated, **Then** the overall pass rate is 95% or higher

---

### User Story 4 - Live Combat Test Suite (Priority: P2)

A developer wants to validate that combat events (WeaponFired, UnitDamaged, UnitDestroyed) are properly handled by running combat-specific tests using the live graphical engine via Xvfb. The suite runs 10 games and verifies 90%+ pass rate.

**Why this priority**: Combat tests require the full graphical engine and are slower to run, but they validate the only AI behaviors that headless mode cannot test.

**Independent Test**: Run combat tests via Xvfb + live engine. 90% or more of combat test assertions pass across 10 game runs.

**Acceptance Scenarios**:

1. **Given** a live engine via Xvfb, **When** combat tests spawn opposing units, **Then** WeaponFired and UnitDamaged events are received within expected frame windows
2. **Given** a live engine via Xvfb, **When** the MilitaryManager is active with enemy units nearby, **Then** the AI issues attack commands and engages
3. **Given** 10 completed combat test runs, **When** results are aggregated, **Then** the overall pass rate is 90% or higher

---

### Edge Cases

- What happens when the engine crashes mid-game? The test harness detects the crash, logs it as a failure, and continues with remaining games.
- What happens when the AI produces zero commands for an extended period? This counts as a "stall" failure for that game.
- What happens when BARb is not installed or unavailable? The competitive suite reports a clear error rather than hanging.
- What happens when Xvfb is not available? Live tests fail fast with a descriptive error message.

## Requirements *(mandatory)*

### Functional Requirements

- **FR-001**: The validation system MUST run N consecutive games against a configurable opponent (NullAI or BARb) and collect per-game outcomes
- **FR-002**: The validation system MUST detect and report game crashes, AI stalls (zero commands for 60+ seconds), and timeouts
- **FR-003**: Each game outcome MUST include: game number, result (win/loss/crash/stall), duration in frames and minutes, units produced, units lost, enemy units destroyed
- **FR-004**: The validation system MUST produce a markdown report summarizing all game outcomes with aggregate statistics (win rate, average duration, pass/fail per success criterion)
- **FR-005**: The headless test suite MUST validate economy (income, extractors, energy), build order (mex-energy-factory sequence), movement (units reach target positions), and scouting (units explore map regions)
- **FR-006**: The live combat test suite MUST validate weapon fire events, damage events, unit destruction events, and coordinated attack behavior
- **FR-007**: Both test suites MUST be runnable via standard test commands with clear pass/fail results
- **FR-008**: The competitive validation MUST use the live graphical engine via Xvfb for combat fidelity
- **FR-009**: Test results MUST be reproducible when using the fixed RNG seed

### Key Entities

- **GameOutcome**: Represents the result of a single game run — includes game number, result, duration, unit counts, and milestone achievement timestamps
- **ValidationReport**: Aggregated results across multiple game runs — includes per-criterion pass/fail, overall statistics, and individual game outcomes
- **TestAssertion**: A single verifiable condition within a test run — e.g., "3 mex built within 3 minutes"

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: 10 consecutive end-to-end games against NullAI all complete without crashes — 100% completion rate
- **SC-002**: The AI builds at least 3 metal extractors and 2 energy structures within 3 minutes in 90%+ of NullAI games
- **SC-003**: The AI produces combat units from a factory within 5 minutes in 90%+ of NullAI games
- **SC-004**: The AI demonstrates combat readiness in 100% of NullAI games: army produced from factory + attack commands issued (headless engine cannot simulate weapon physics, so actual win/loss is validated in US2/US4 via live engine)
- **SC-005**: The AI survives at least 15 minutes against BARb in 80%+ of games (8 of 10)
- **SC-006**: Non-combat headless test suite passes with 95%+ success rate across 20 game runs
- **SC-007**: Live combat test suite passes with 90%+ success rate across 10 game runs
- **SC-008**: Validation reports are generated as readable markdown with per-game and aggregate statistics

## Assumptions

- The headless engine (`spring-headless`) is installed and available at the path specified by `HIGHBAR_TEST_ENGINE` or at the default location
- The live graphical engine (`spring`) is installed at the path used by the existing live test fixture
- Xvfb is installed and available for headless display rendering during live engine tests
- BARbarianAI (BARb) is available as an opponent AI in the engine's AI directory
- The BAR game content and map (Comet Catcher Remake) are installed
- The AI code from feature 014 is compiled and functional
- The proxy shared library is built and installed in the appropriate engine directories
- Game configuration uses fixed RNG seed for reproducibility
