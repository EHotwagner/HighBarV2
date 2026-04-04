# Test Documentation

HighBar V2 uses a multi-tier test strategy with xUnit (F#) and CTest (C). Tests are organized by what they exercise and whether they require a running game engine.

## Running Tests

```bash
# All tests (auto-detects engine)
./tests/run-all.sh

# Specific categories
./tests/run-all.sh --category proxy       # C proxy tests (no engine)
./tests/run-all.sh --category unit        # F# unit tests (no engine)
./tests/run-all.sh --category data        # BarData validation (no engine)
./tests/run-all.sh --category integration # Integration (needs engine)
./tests/run-all.sh --category persistent  # Persistent engine (needs engine)
./tests/run-all.sh --category ai          # AI validation (needs engine)

# Graphical mode (live engine with display)
./tests/run-all.sh --category ai --graphical

# Check prerequisites
./tests/check-prerequisites.sh
```

The unified test runner (`tests/run-all.sh`) auto-detects the engine, parses test output, and generates markdown reports to `reports/testreports/`.

## Test Tiers

| Tier | Project | Engine | Count | Purpose |
|------|---------|--------|-------|---------|
| Proxy | CTest (`proxy/tests/`) | No | 4 | C serialization/deserialization round-trips |
| Unit | `tests/unit/fsharp/` | No | 6 | F# command builder correctness |
| Data | `data/bar.tests/` | No | 60+ | BarData integrity and completeness |
| Integration | `tests/integration/fsharp/` | Yes | 35+ | Connection, events, commands, callbacks |
| Persistent | `tests/persistent/fsharp/` | Yes | 40+ | Multi-step scenarios with persistent engine |
| AI | `tests/ai/fsharp/` | Yes | 4 suites | End-to-end AI behavior validation |

---

## Proxy Tests (C)

**Location:** `proxy/tests/` | **Framework:** CTest/CMake

Four test executables that validate the serialization boundary:

### test_serialize

Verifies that engine event structs serialize correctly to protobuf `EngineEvent` messages. Tests all 28 event types by constructing engine structs with known values, serializing, and checking the protobuf output fields.

### test_deserialize

Verifies that protobuf `AICommand` messages deserialize into the correct engine command structs. Tests all 97 command types by constructing protobuf messages, deserializing, and verifying the resulting struct fields and command IDs.

### test_roundtrip

Round-trip tests: serialize an engine event, then verify the protobuf output can be parsed and matches the original. Also tests command round-trips: construct a protobuf command, deserialize to engine struct, and verify field preservation.

### test_callbacks

Tests callback dispatch: constructs `CallbackRequest` messages and verifies the proxy correctly routes them to mock engine callbacks and builds proper `CallbackResponse` messages.

**Mock Engine:** `mock_engine.c` / `mock_engine.h` provide a test double for `SSkirmishAICallback`.

---

## Unit Tests (F#)

**Location:** `tests/unit/fsharp/CommandBuilderTests.fs` | **Framework:** xUnit

### CommandBuilderTests (6 tests)

| Test | System Under Test | What It Verifies |
|------|------------------|-----------------|
| `GiveMeNewUnitCommand sets unit_def_id and position` | `Commands.GiveMeNewUnitCommand` | Creates an AICommand with UnitDefId=42 and position (1024, 200, 2048) |
| `GiveMeResourceCommand sets resource_id and amount` | `Commands.GiveMeResourceCommand` | Creates an AICommand with ResourceId=0, Amount=500.0 |
| `CallLuaRulesCommand sets data field` | `Commands.CallLuaRulesCommand` | Creates an AICommand with Data="spawn_unit armcom 1024 200 2048" |
| `CallLuaRulesCommand handles empty string` | `Commands.CallLuaRulesCommand` | Empty string data does not throw |
| `CallLuaUICommand sets data field` | `Commands.CallLuaUICommand` | Creates an AICommand with Data="show_debug_overlay" |
| `Cheat builders compatible with existing builders` | `Commands` module | Creates a list of 6 different commands (Move, Build, GiveMeResource, GiveMeNewUnit, CallLuaRules, CallLuaUI) as valid AICommand list |

---

## Data Tests (BarData)

**Location:** `data/bar.tests/Tests/` | **Framework:** xUnit

### CapabilityTests.fs (9 tests)

Validates the `AllUnits` filter functions return correct results:
- `builders` includes armck, armcom, armlab
- `armed` includes armham
- `flyingUnits` includes armfig, armbrawl
- `mobileUnits` includes armck but excludes armsolar
- `buildings` includes armsolar, armlab
- `economyUnits` is non-empty

### CompletenessTests.fs (7 tests)

Validates unit counts and lookup functions:
- Total units >= 950
- Arm >= 200, Cor >= 200, Legion >= 220, Scavengers >= 80
- `tryFind "armck"` returns Some, `tryFind "doesnotexist"` returns None

### ComposableCapabilityTests.fs

Tests the structured UnitDef capability sub-records:
- armck: has builder (Some), no weapons, has movement
- armham: has weapons (Some), no builder, has movement
- armcom: has movement, builder, and weapons (commander)
- armsolar: has economy (Some), building (Some), no movement
- armlab: has building (Some), builder (Some), has build options
- AllUnitDefs: >= 950 entries, no duplicates

### ComposableCorrectnessTests.fs

Spot-checks concrete field values against known BAR data:
- armham: metalCost=130, health=1000, speed=46.2
- armck: workerTime=80, buildDistance=130
- armflea: speed=132, health=60, cost=21
- armsolar: cost=155, health=340
- corck: cost=120, health=750, workerTime=85, speed=34.5
- legbal: cost=160, health=900, speed=43.5
- armcom: cost=2700, health=3700

### ComposableStructuralTests.fs (8 tests)

Holistic validation of UnitDef data quality:
- < 20 units have Concrete 0 for health
- No UnitDef has negative metalCost
- > 50% of builders have non-empty buildOptions
- > 90% of armed units have non-empty damage maps
- Expr values preserve expression text
- All names non-empty, no duplicates

### ConversionTests.fs

Tests round-trip conversions between flat records and composable UnitDef:
- `toFlat` and `toUnitDef` produce matching field values for armck, armham, armsolar, armcom, corck, legbal
- Round-trips (flat→def→flat and def→flat→def) preserve data for 19 units
- AllUnitDefs and AllUnits have matching counts and names

### CorrectnessTests.fs

Tests flat UnitSummary field values directly (same spot-checks as ComposableCorrectnessTests but against the flat type system).

### StructuralTests.fs (9 tests)

Validates flat record data quality:
- Most units have positive health
- No negative metalCost
- Builder units (armck, corck) have non-empty buildOptions
- Armed units (armham) have weapons with non-empty damage maps
- All names non-empty and unique
- At least one unit has non-empty extras

---

## Integration Tests

**Location:** `tests/integration/fsharp/` | **Framework:** xUnit | **Requires:** Engine

### Test Fixture: EngineFixture

Creates a listening Unix domain socket, launches the engine (which connects the proxy), accepts the connection, handshakes, and warms up for 30 frames. All integration tests share this single engine instance.

### ConnectionTests.fs (7 tests)

| Test | What It Verifies |
|------|-----------------|
| Harness smoke test | Socket is available, engine is running |
| Client connects to engine proxy socket | Valid client object after connection |
| Handshake completes with valid protocol metadata | Handshake succeeds, engine still alive |
| First frame contains Init event | Init event present in initial events |
| Empty command responses work for consecutive frames | 3+ frames with incrementing frame numbers |
| Graceful disconnect after receiving frames | Disconnect after 3+ frames without error |

### EventTests.fs (6 tests)

| Test | What It Verifies |
|------|-----------------|
| T018: Init event | Init with valid teamId >= 0 |
| T019: Update events | Every frame (except first) has >= 1 Update event with matching frame number |
| T020: UnitCreated | >= 1 UnitCreated in initial frames with unitId > 0 |
| T021: UnitIdle/UnitFinished | UnitFinished received for spawned commander, finished unitId matches created unit |
| T022: Unknown events | 10 frames process without crash, counts unknowns |
| T022C: Combat events | 60 frames, optionally captures UnitDamaged events |

### CommandTests.fs (6 tests)

| Test | What It Verifies |
|------|-----------------|
| T025: MoveCommand | Send MoveCommand at frame 3, position changes |
| T026: StopCommand | MoveCommand at frame 3, StopCommand at frame 8, 25 frames complete |
| T027: BuildCommand | Builder builds at frame 5, track UnitCreated after build over 70 frames |
| T028: PatrolCommand | PatrolCommand at frame 3, 25+ frames without error |
| T029: Guard/Attack/Repair/Fight | Four commands issued at frames 5/10/15/20, 30 frames complete |
| T030: StopCommand for all units | StopCommand to all initial units at frame 5, 20 frames complete |

### CallbackTests.fs (5 tests)

| Test | What It Verifies |
|------|-----------------|
| T033: Unit position | Query unit positions from initial events, IDs > 0 |
| T034: Team resources | Run 10 frames successfully (valid resource state) |
| T035: Game frame numbers | Update event frame numbers <= message frame + 1 |
| T036: Invalid callback resilience | CustomCommand with id -1 at frame 5, 15 frames without proxy crash |

### UnitDataTests.fs (10 tests)

Integration between BarData library and live engine:
- `tryFind "armham"` returns Some with cost 130, health 1000
- Unknown unit returns None
- `findDef` for armham matches expected fields
- Direct flat access works (ArmBots.armham)
- Filter queries: builders contains "armck", armed contains "armham", mobile excludes "armsolar"
- Combined filter: Arm + armed + mobile includes "armham"
- AllUnits.all has exactly 953 entries
- Spot-checks for Cor and Legion units

---

## Persistent Tests

**Location:** `tests/persistent/fsharp/` | **Framework:** xUnit with Priority ordering | **Requires:** Engine

### Test Fixture: PersistentEngineFixture

Starts one engine instance shared across all persistent tests. Provides:
- Unit definition discovery (builders, armed, mobile, buildings, economy)
- Reset mechanism (destroys units, restores resources between tests)
- Frame runner with event logging

Tests execute in priority order (lower priority number runs first).

### T0: Smoke Tests (9 tests)

| Test | Priority | What It Verifies |
|------|----------|-----------------|
| T0.1 | 1 | Engine alive after fixture init |
| T0.2 | 2 | Client connected, runs 5+ frames |
| T0.3 | 3 | Initial events contain Init and UnitCreated |
| T0.4 | 5 | Fixture startup < 30 seconds |
| T0.5 | 7 | Discovery finds >= 1 each: builder, armed, mobile, building |
| T0.6 | 9 | Spawn unit, reset clears spawned units |
| T0.7 | 10 | Give resources then reset returns to baseline |
| T0.8 | 11 | Frame numbers continue incrementing after reset |
| T0.9 | 13 | ResetGameState completes < 5 seconds |

### T1: Spawn Tests (4 tests)

| Test | What It Verifies |
|------|-----------------|
| T1.1 | Spawn mobile unit → UnitCreated event |
| T1.2 | Spawn 3 units → count >= 3 |
| T1.3 | Spawn at two positions → both created |
| T1.4 | Spawn different types (mobile + builder) → >= 1 created |

### T2: Movement Tests (3 tests)

| Test | What It Verifies |
|------|-----------------|
| T2.1 | MoveCommand on spawned unit, 40 frames without crash |
| T2.2 | MoveCommand then StopCommand (move at frame 0, stop at 10) |
| T2.3 | PatrolCommand with waypoint, 25+ frames |

### T2b: Move Verification (1 test)

Spawns a unit, records initial position, sends MoveCommand to distant location, runs 120 frames, and verifies the unit moved > 10 distance units.

### T3: Build Tests (4 tests)

| Test | What It Verifies |
|------|-----------------|
| T3.1 | Spawn building via cheat → UnitCreated |
| T3.2 | Spawn building → UnitFinished event |
| T3.3 | Commander issues BuildCommand, 300 frames (engine survives) |
| T3.4 | Builder issues RepairCommand on building, 50+ frames |

### T4: Combat Tests (3 tests)

| Test | What It Verifies |
|------|-----------------|
| T4.1 | Spawn 5 armed units at enemy start, FightCommand, 900 frames |
| T4.2 | Spawn armed unit near enemy, FightCommand, 100+ frames |
| T4.3 | SelfDestructCommand at frame 3, 500 frames, check UnitDestroyed |

### T5: Scenario Tests (3 tests)

| Test | What It Verifies |
|------|-----------------|
| T5.1 | Economy cycle: spawn commander, build extractor, track creation/finishing |
| T5.2 | Build-and-defend: spawn builder, build structure, spawn guard, GuardCommand |
| T5.3 | Multi-unit coordination: spawn 3 units, Move/Patrol/Stop at frame 0 |

### T6: Command Coverage (9 tests)

Every command type has at least one test:

| Test | Command | What It Verifies |
|------|---------|-----------------|
| T6.1 | SetWantedMaxSpeedCommand | Mobile unit, 20 frames |
| T6.2 | SelfDestructCommand | 500 frames, check UnitDestroyed |
| T6.3 | ReclaimUnitCommand | Builder reclaims mobile unit, 100 frames |
| T6.4 | CustomCommand | 20 frames without error |
| T6.5 | SendTextMessageCommand | 20 frames without error |
| T6.6 | GiveMeResourceCommand | Metal(0) and Energy(1), 20 frames |
| T6.7 | GiveMeNewUnitCommand | Verify UnitCreated, 20 frames |
| T6.8 | CallLuaRulesCommand | 20 frames without error |
| T6.9 | CallLuaUICommand | 20 frames without error |

### T7: Exhaustive Spawn (3 tests)

| Test | What It Verifies |
|------|-----------------|
| T7.1 | Spawn first 200 defIds in batches of 20 |
| T7.2 | Spawn same defId 200 times in 4 batches of 50 |
| T7.3 | Spawn-and-reset 20 iterations, >= 15 complete |

### T8: Large Scale Combat (2 tests)

| Test | What It Verifies |
|------|-----------------|
| T8.1 | Spawn 20 armed units in grid, FightCommand, 500 frames |
| T8.2 | Post-combat reset < 30s, verify spawn works after reset |

---

## AI Validation Tests

**Location:** `tests/ai/fsharp/` | **Framework:** xUnit | **Requires:** Engine

These tests run full AI games using the `GameState` framework and evaluate behavioral criteria.

### End-to-End Tests (2 tests)

**Single game smoke test:** Runs 1 game end-to-end, verifies result is not Crash and duration > 0.

**10-game validation:** Runs 10 games and evaluates success criteria:

| Criterion | Threshold | Description |
|-----------|-----------|-------------|
| SC-001 | 100% | No crashes or stalls |
| SC-002 | 90% | Bootstrap economy (>=3 mex, >=2 energy in 3 min) |
| SC-003 | 90% | Produce combat units by 5 minutes |
| SC-004 | 100% | All games produce at least one combat unit |

### Non-Combat Tests (1 test, 8 assertions x 20 games)

Runs 20 games and evaluates non-combat AI behavior with 95% pass rate threshold:

| Assertion | Description |
|-----------|-------------|
| economyPositiveIncome2min | >= 1 mex by frame 3600 |
| economyExtractorsBuilt | >= 3 mex by frame 5400 |
| economyEnergyBuilt | >= 2 energy by frame 5400 |
| buildOrderMexFirst | Mex built before energy before factory |
| buildOrderFactoryWithin5min | Factory by frame 9000 |
| buildOrderSequenceComplete | All three milestones reached |
| movementUnitsProduced | unitsProduced > 1 |
| scoutingActivity | units > 2 and frames > 1800 |

### Combat Tests (1 test, 6 assertions x 10 games)

Requires graphical engine (`DISPLAY` set). Runs 10 games and evaluates combat with 90% pass rate:

| Assertion | Description |
|-----------|-------------|
| combatUnitsDestroyed | enemyDestroyedCount > 0 |
| combatOccurred | Some units destroyed |
| combatGameCompleted | Result is Win or Loss |
| combatWeaponFired | weaponFiredCount > 0 |
| combatDamageEvents | Damage events received |
| combatMilitaryEngagement | Enemy units destroyed |

### Headless Combat Verification (1 test)

Runs 3 games with combat-verify configuration and generates a detailed report comparing results with Feature 014 findings about headless engine combat limitations.

### Competitive Tests (skipped)

Two tests against BARb AI are defined but skipped (require `DISPLAY` and BARb AI installation):
- Single game competitive smoke test
- 10-game competitive validation vs BARb

---

## Test Infrastructure

### Test Harness Pattern

All engine-dependent tests use a shared fixture pattern:
1. Check prerequisites (`check-prerequisites.sh`)
2. Start engine via bash script with game-setup.lua configuration
3. Accept proxy connection on Unix domain socket
4. Handshake and warm up
5. Run test frames
6. Clean up engine process on exit

### Game Setup (`tests/fixtures/game-setup.lua`)

Configures test scenarios:
- Small map with 2 teams (HighBarV2 AI vs NullAI)
- Close spawn positions for combat engagement
- Game mode 3 (disable victory conditions)
- Configurable map and socket path via environment variables

### Report Generation

The test runner generates markdown reports to `reports/testreports/` including:
- Pass/fail counts per category
- Environment details (engine version, map, platform)
- Failure details with engine logs

AI tests generate their own validation reports with per-game outcome tables and success criteria evaluation.

See also: [Getting Started](getting-started.md) | [Known Issues](known-issues.md)
