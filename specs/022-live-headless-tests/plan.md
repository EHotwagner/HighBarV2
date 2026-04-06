# Implementation Plan: Replace Mock Tests with Live Headless Engine Tests

**Branch**: `022-live-headless-tests` | **Date**: 2026-04-05 | **Spec**: [spec.md](spec.md)
**Input**: Feature specification from `/specs/022-live-headless-tests/spec.md`

## Summary

Replace mock-based tests with live headless engine equivalents across F# unit and C proxy test tiers. Delete 6 F# unit tests (covered by persistent tier), delete 32 C proxy serialization/roundtrip tests (covered by live engine frame exchange), retain 19 C proxy edge-case tests (NULL pointers, unknown callbacks), and supplement 15 C proxy deserialize tests with live equivalents. Add FSBarV1-style map testing and strengthen combat fidelity assertions with outcome-level validation.

## Technical Context

**Language/Version**: F# / .NET 10.0 (test projects), C11 (proxy tests)
**Primary Dependencies**: xUnit 2.9.x, CTest/CMake, spring-headless engine
**Storage**: Filesystem only (Unix domain sockets, temp dirs)
**Testing**: xUnit (F# persistent/integration/ai tiers), CTest (C proxy tier)
**Target Platform**: Linux (headless BAR engine)
**Project Type**: Test infrastructure migration (no new runtime code)
**Performance Goals**: No hard time limit; tiered model provides fast feedback
**Constraints**: Persistent engine fixture for migrated tests; outcome-level combat validation
**Scale/Scope**: 72 tests affected (6 F# unit + 66 C proxy); ~10 new live tests added

## Constitution Check

*GATE: Must pass before Phase 0 research. Re-check after Phase 1 design.*

| Principle | Status | Notes |
|-----------|--------|-------|
| I. Zero Engine Modifications | PASS | No engine changes; uses standard AI plugin interface |
| II. Binary Protocol First | PASS | All live tests use protobuf over Unix domain sockets |
| III. Correctness Over Cleverness | PASS | Straightforward test migration, no clever abstractions |
| IV. Test at the Boundary | PASS | This feature directly strengthens boundary testing by replacing mocks with real engine validation |
| V. Latency Budget Discipline | N/A | Test infrastructure, not hot-path code |
| VI. Language-Agnostic by Default | PASS | No protocol-level changes; tests validate existing protocol |
| VII. Explicit Over Implicit | PASS | Test skip behavior is explicit (clear messages when engine unavailable) |

**Post-Phase 1 Re-check**: All gates remain PASS. No new violations introduced.

## Project Structure

### Documentation (this feature)

```text
specs/022-live-headless-tests/
├── plan.md              # This file
├── spec.md              # Feature specification
├── research.md          # Phase 0 research decisions
├── data-model.md        # Test disposition registry
├── quickstart.md        # Development workflow guide
└── checklists/
    └── requirements.md  # Spec quality checklist
```

### Source Code (repository root)

```text
# Files to DELETE
tests/unit/fsharp/CommandBuilderTests.fs          # 6 F# unit tests (replaced by persistent tier)
tests/unit/fsharp/HighBar.UnitTests.fsproj         # Project file (if empty after deletion)
proxy/tests/test_serialize.c                       # 29 serialization tests (replaced by live)
proxy/tests/test_roundtrip.c                       # 3 roundtrip tests (replaced by live)

# Files to MODIFY
tests/persistent/fsharp/T6_CommandCoverage.fs      # Add T6.10 all-commands smoke test
tests/persistent/fsharp/T4_CombatTests.fs          # Strengthen combat assertions
tests/persistent/fsharp/T8_LargeScaleCombat.fs     # Strengthen combat assertions
tests/ai/fsharp/HeadlessCombatVerification.fs      # Add combat event assertions
proxy/tests/CMakeLists.txt                         # Remove deleted test targets
proxy/tests/test_deserialize.c                     # Document retained edge cases
tests/run-all.sh                                   # Update unit tier handling

# Files to CREATE
tests/persistent/fsharp/T9_MapTests.fs             # FSBarV1-style map query/grid tests

# Files to RETAIN (no changes)
proxy/tests/mock_engine.c                          # Still needed by retained tests
proxy/tests/test_callbacks.c                       # 17 edge-case tests retained
proxy/tests/test_deserialize.c                     # 2 edge cases + 15 supplemented
tests/persistent/fsharp/PersistentHarness.fs       # Fixture (may need minor additions for map tests)
```

**Structure Decision**: No new directories. Migrated tests go into existing persistent tier. Deleted tests are removed from their current locations. The proxy test directory retains `mock_engine.c`, `test_callbacks.c`, and `test_deserialize.c`.

## Complexity Tracking

No constitution violations to justify. All changes align with existing architecture.

## Implementation Phases

### Phase 1: F# Unit Test Migration (P1)

**Goal**: Delete 6 F# unit tests, ensure persistent tier has full coverage.

**Steps**:
1. Audit T6_CommandCoverage.fs to confirm coverage of all 6 unit test scenarios
2. Add T6.10: all-commands smoke test (replaces unit test 6 "Cheat builders return AICommand compatible") — spawns a unit and sends all 6 command types in a single test
3. Run persistent tier to verify all T6 tests pass
4. Delete `tests/unit/fsharp/CommandBuilderTests.fs`
5. If unit project is now empty, remove `tests/unit/fsharp/HighBar.UnitTests.fsproj` and update `run-all.sh` to skip empty unit tier
6. Run full test suite to confirm no regressions

**Validation**: `./tests/run-all.sh --category persistent` passes with T6.10 included.

### Phase 2: C Proxy Serialization/Roundtrip Deletion (P2)

**Goal**: Delete 32 C proxy tests (29 serialize + 3 roundtrip) that are covered by live engine frame exchange.

**Steps**:
1. Verify persistent tier integration tests exercise all 28+ event types via live engine (events fire naturally during spawn, combat, movement scenarios)
2. Delete `proxy/tests/test_serialize.c`
3. Delete `proxy/tests/test_roundtrip.c`
4. Update `proxy/tests/CMakeLists.txt` to remove deleted test targets
5. Document in `test_deserialize.c` header comment which 2 tests are retained for edge cases (unknown command, batch ordering) and which 15 are supplemented
6. Run CTest to confirm retained proxy tests pass: `cd build && cmake .. && ctest`

**Validation**: `./tests/run-all.sh --category proxy` passes with reduced test count.

### Phase 3: Combat Fidelity Strengthening (P2)

**Goal**: Add outcome-level combat assertions to existing tests.

**Steps**:
1. In T4_CombatTests.fs:
   - T4.1 (five armed units): Assert at least 1 EnemyEnterLOS event (units saw enemy)
   - T4.1: Assert combat ran without engine crash over 900 frames
   - Add assertion comments documenting headless combat limitation if combat events are zero
2. In T8_LargeScaleCombat.fs:
   - Assert engine survives 500-frame large-scale test
   - Assert post-combat reset succeeds
3. In HeadlessCombatVerification.fs:
   - Change from exploratory (always pass) to assertive: if headless combat events > 0, validate outcome-level correctness (correct side takes casualties)
   - If headless combat events = 0, mark test as inconclusive with clear diagnostic message (not failure — headless physics limitation)
4. Run persistent and AI tiers to validate

**Validation**: `./tests/run-all.sh --category persistent` and `--category ai` pass.

### Phase 4: FSBarV1 Map Test Adoption (P3)

**Goal**: Port FSBarV1's map testing patterns to HighBarV2's persistent tier.

**Steps**:
1. Study FSBarV1's `MapQueryTests.fs` and `MapGridTests.fs` for test patterns
2. Create `tests/persistent/fsharp/T9_MapTests.fs` with:
   - Map dimension queries (width, height)
   - Height map data retrieval and basic validation
   - Start position query
   - Metal spot discovery
   - Graceful skip pattern (try-catch) if proxy doesn't support map callbacks
3. Add T9 to the persistent project file
4. Ensure PersistentHarness exposes necessary callback methods (or add thin wrappers)
5. Run persistent tier to validate

**Validation**: `./tests/run-all.sh --category persistent` passes with T9 map tests.

### Phase 5: Test Runner and Documentation Cleanup

**Goal**: Update test runner and documentation to reflect new test landscape.

**Steps**:
1. Update `tests/run-all.sh`:
   - Handle empty/missing unit tier gracefully (skip with message if no unit tests remain)
   - Verify proxy tier reports correct reduced test count
2. Update test count expectations in any CI configuration
3. Run full test suite end-to-end: `./tests/run-all.sh`
4. Generate test report and verify all tiers report correctly

**Validation**: Full `./tests/run-all.sh` completes with all tiers reporting correct status.

## Risk Register

| Risk | Impact | Mitigation |
|------|--------|------------|
| Headless engine doesn't fire combat events | Combat fidelity tests inconclusive | Use inconclusive markers, not failures; document as known limitation |
| Deleted serialize tests miss a marshaling bug | Silent protocol corruption | Persistent tier exercises all event types via live engine; roundtrip is implicitly tested |
| Map callbacks not supported by current proxy | T9 map tests fail | Adopt FSBarV1's graceful skip pattern (try-catch) |
| Unit test project removal breaks solution file | Build failure | Check for .sln references before deleting project |
