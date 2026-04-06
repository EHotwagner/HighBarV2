# Research: 022-live-headless-tests

**Date**: 2026-04-05

## Decision 1: F# Unit Test Disposition

**Decision**: Delete all 6 F# unit tests in `tests/unit/fsharp/CommandBuilderTests.fs` and rely on persistent tier equivalents (T6_CommandCoverage.fs) for live validation.

**Rationale**: The 6 unit tests validate in-memory command builder field population (e.g., "GiveMeNewUnitCommand sets unit_def_id and position"). The persistent tier already tests the same commands against the live engine — T6.6 through T6.9 cover GiveMeResourceCommand, GiveMeNewUnitCommand, CallLuaRulesCommand, and CallLuaUICommand. A live engine test that sends a command and verifies correct behavior implicitly validates the builder. The one unit test without a persistent equivalent (test 6: "Cheat builders return AICommand compatible") can be added as a new persistent tier test.

**Alternatives considered**:
- Keep unit tests alongside persistent tests: Rejected — creates maintenance burden with no additional confidence (clarification: delete replaced mocks entirely).
- Convert unit tests to integration tier: Rejected — persistent tier already has the fixture and coverage.

## Decision 2: C Proxy Test Triage

**Decision**: Triage C proxy tests into three categories: delete (replaced by live), retain (unique mock-only value), and supplement (add live equivalent but keep mock).

**Rationale**: The 66 C proxy tests serve different purposes:
- `test_serialize.c` (29 tests): Pure protobuf marshaling with no mock engine usage. These validate the codec boundary (Constitution IV). Live engine events naturally exercise the same serialization paths. **Delete** — live integration tests + roundtrip tests in persistent tier cover this.
- `test_deserialize.c` (17 tests): Heavy mock usage for command routing. 15 standard command tests can be **supplemented** with live validation; 2 edge cases (unknown command, batch ordering) **retain** as mock.
- `test_roundtrip.c` (3 tests): Pure protobuf pack/unpack. **Delete** — live frame exchange inherently tests roundtrip.
- `test_callbacks.c` (17 tests): Heavy mock usage for callback dispatch. **Retain** — tests NULL pointer handling, zero-count arrays, unknown callback IDs, and configurable map sizes. These edge cases cannot be triggered via a live engine.

**Net result**: Delete 32 tests (serialize + roundtrip), supplement 15 deserialize tests, retain 19 tests (2 deserialize edge + 17 callbacks). Mock conversion rate: ~50% (32+15 supplemented out of 66).

**Alternatives considered**:
- Delete all C proxy tests: Rejected — callback edge cases (NULL pointers, zero-length arrays) are defensive tests that catch real bugs.
- Keep all C proxy tests and only add live tests: Rejected — serialize and roundtrip tests duplicate what live engine tests validate, per clarification to delete replaced mocks.

## Decision 3: Combat Fidelity Validation Approach

**Decision**: Enhance existing combat tests with outcome-level assertions rather than creating new test infrastructure.

**Rationale**: Research reveals a critical gap — existing combat tests (T4, T8, HeadlessCombatVerification) accept zero combat events as valid outcomes. The Feature 014 limitation ("headless has no weapon physics") is documented but not validated. Per clarification, combat fidelity should be validated at outcome level: correct unit dies, correct side wins, damage is non-zero and directionally correct.

The approach:
1. Strengthen T4_CombatTests assertions to require non-zero combat events (UnitDamaged, EnemyDestroyed, WeaponFired).
2. Add explicit "headless combat fidelity" assertions to HeadlessCombatVerification that fail if no combat events occur (replacing the exploratory approach).
3. Use outcome-level checks: did the armed units engage? Did the expected side take casualties?

**Alternatives considered**:
- Frame-exact combat validation: Rejected per clarification — too brittle, breaks on engine updates.
- Tolerance-based damage validation: Rejected — requires reference values that don't exist yet.

## Decision 4: FSBarV1 Pattern Adoption

**Decision**: Adopt two patterns from FSBarV1: (1) map testing suite, (2) graceful feature detection.

**Rationale**:
1. **Map testing**: FSBarV1 has mature MapQueryTests and MapGridTests covering height queries, passability, resource spots, LOS maps, and coordinate conversion. HighBarV2 has callback infrastructure but no systematic map tests. These tests validate tactical AI foundations.
2. **Graceful feature detection**: FSBarV1's try-catch pattern for proxy feature detection allows tests to skip gracefully when proxy doesn't support certain callbacks. This aligns with FR-007 (skip gracefully when engine unavailable).

**Not adopted**:
- BARb opponent AI testing: Requires Spring's BARb AI availability and complex multi-phase state machines. Out of scope for this feature.
- Simpler fixture initialization: HighBarV2's persistent fixture with state reset is superior to FSBarV1's ephemeral pattern.

## Decision 5: Test Runner and Tier Structure

**Decision**: Preserve existing tiered structure. Migrated tests go to the persistent tier. No new tiers created.

**Rationale**: The persistent tier's shared engine fixture with state reset is the natural home for migrated tests. It avoids engine restart overhead and already has infrastructure for command testing (T6), combat (T4, T8), and spawning (T1, T7). Map tests (from FSBarV1) fit naturally as a new tier file (e.g., T9_MapTests.fs).

**Alternatives considered**:
- New "migrated" tier: Rejected — adds complexity to run-all.sh without benefit.
- Integration tier: Rejected — integration tier creates a new engine per test, which is slower than persistent tier's shared engine.
