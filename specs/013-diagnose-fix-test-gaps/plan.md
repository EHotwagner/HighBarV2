# Implementation Plan: Diagnose and Fix Persistent Test Gaps

**Branch**: `013-diagnose-fix-test-gaps` | **Date**: 2026-04-04 | **Spec**: [spec.md](spec.md)  
**Input**: Feature specification from `/specs/013-diagnose-fix-test-gaps/spec.md`

## Summary

Fix the 4 root causes that prevented 012-harden-persistent-tests from achieving full assertion strength: (1) BarData/engine defId mismatch — solved by adding UnitDef callback dispatches to the proxy, (2) zero combat events — most likely caused by missing `Cheats_setEventsEnabled` call, (3) SelfDestruct not producing events — likely same root cause as #2 or insufficient frame budget, (4) engine crashes on large spawns — requires empirical isolation of bugged defIds vs. unit count limits. Once root causes are fixed, restore all weakened test assertions to original spec.

## Technical Context

**Language/Version**: C11 (proxy), F# / .NET 8.0 (client + tests)  
**Primary Dependencies**: protobuf-c (C proxy), Google.Protobuf 3.28 (F#), xUnit 2.x (tests), BarData (in-repo)  
**Storage**: Filesystem (Unix domain sockets, log files, temp directories)  
**Testing**: xUnit (F# persistent engine tests), Spring headless engine  
**Target Platform**: Linux (headless engine)  
**Project Type**: AI bridge (proxy shared library + client libraries + test harness)  
**Performance Goals**: < 1ms proxy overhead per frame (existing constraint)  
**Constraints**: Zero engine modifications (Constitution I), binary protocol only (Constitution II)  
**Scale/Scope**: 953 unitDefIds, 38 existing tests, 28 event types

## Constitution Check

*GATE: Must pass before Phase 0 research. Re-check after Phase 1 design.*

| Principle | Status | Notes |
|-----------|--------|-------|
| I. Zero Engine Modifications | **PASS** | All changes through standard Skirmish AI interface. Callback queries use existing `SSkirmishAICallback`. `Cheats_setEventsEnabled` is part of the published API. |
| II. Binary Protocol First | **PASS** | New callbacks use existing protobuf CallbackRequest/Response. No new wire formats. |
| III. Correctness Over Cleverness | **PASS** | Callback dispatch is 1:1 mapping to engine functions. No transformations. |
| IV. Test at the Boundary | **PASS** | Feature literally strengthens boundary tests (engine→proxy→client event assertions). |
| V. Latency Budget Discipline | **PASS** | Callback queries occur during init only, not on hot path. No per-frame overhead added. |
| VI. Language-Agnostic by Default | **PASS** | New callbacks defined in .proto schema. F# helpers are thin wrappers. |
| VII. Explicit Over Implicit | **PASS** | `Cheats_setEventsEnabled(true)` is explicit. DefId discovery replaces implicit BarData assumptions. |

No violations. No complexity tracking needed.

## Project Structure

### Documentation (this feature)

```text
specs/013-diagnose-fix-test-gaps/
├── plan.md              # This file
├── research.md          # Phase 0 output — root cause analysis
├── data-model.md        # Phase 1 output — entities and callback extensions
├── quickstart.md        # Phase 1 output — build and debug guide
├── contracts/           # Phase 1 output — callback dispatch contracts
│   └── callback-extensions.md
└── tasks.md             # Phase 2 output (created by /speckit.tasks)
```

### Source Code (repository root)

```text
proxy/
├── src/
│   ├── proxy.c          # MODIFY: Add Cheats_setEventsEnabled in init, add event logging
│   ├── callbacks.c      # MODIFY: Add 7 new dispatch cases (UnitDef queries + cheats events)
│   └── serialize.c      # NO CHANGE (all 28 events already serialized)
├── include/
│   └── AI/              # NO CHANGE (engine headers, read-only)
└── data/
    └── AIOptions.lua    # NO CHANGE

proto/
└── highbar/
    └── callbacks.proto  # MODIFY: Add CALLBACK_GET_UNIT_DEFS and CALLBACK_CHEATS_SET_EVENTS_ENABLED

clients/fsharp/
└── src/
    └── Client.fs        # MODIFY: Add callback query helper methods

tests/persistent/fsharp/
├── PersistentHarness.fs # MODIFY: Replace BarData-based discovery with callback-based discovery
├── T3_BuildTests.fs     # MODIFY: Restore full BuildCommand assertions
├── T4_CombatTests.fs    # MODIFY: Restore full combat event assertions
├── T6_CommandCoverage.fs # MODIFY: Restore SelfDestruct UnitDestroyed assertion
├── T7_ExhaustiveSpawn.fs # MODIFY: Expand to all valid defIds with blacklist
└── T8_LargeScaleCombat.fs # MODIFY: Restore 100+ units with event assertions
```

**Structure Decision**: No new files or directories. All changes are extensions to existing proxy dispatch, client helpers, and test assertions.

## Implementation Phases

### Phase A: Diagnose Combat Events (Investigation)

**Goal**: Confirm root cause of zero combat events.

1. **Check `Cheats_setEventsEnabled` in proxy init** (`proxy/src/proxy.c`):
   - Search for `Cheats_setEventsEnabled` — if absent, this is the root cause
   - If absent, add call immediately after `Cheats_setEnabled(true)` in init sequence

2. **Add diagnostic event counter** to `handleEvent`:
   - Temporary: log event topic distribution per frame at DEBUG level
   - Verify engine is actually calling handleEvent with combat topic IDs

3. **Verify enemy commander exists**:
   - Check initial events for `EVENT_ENEMY_CREATED` (topic 25)
   - If no enemy created event, the NullAI may not be spawning correctly

4. **Minimal combat repro test**:
   - Spawn one armed unit at (4500, 4096) — near enemy start (4608, 4096)
   - Run 300 frames
   - Log all events received
   - If combat events now appear: root cause confirmed (Cheats_setEventsEnabled)
   - If still zero: investigate H2-H4 from research.md

### Phase B: Add UnitDef Callback Dispatches (Proxy + Proto)

**Goal**: Enable F# client to query engine for defId→name mapping and build options.

1. **Extend `callbacks.proto`**:
   - Add `CALLBACK_GET_UNIT_DEFS = 47`
   - Add `CALLBACK_CHEATS_SET_EVENTS_ENABLED = 92`
   - Run `buf lint && buf generate`

2. **Add dispatch cases in `proxy/src/callbacks.c`**:
   - `CALLBACK_GET_UNIT_DEFS`: Call `callback->getUnitDefs()`, return IntArray
   - `CALLBACK_UNITDEF_GET_NAME` (40): Call `callback->UnitDef_getName()`, return string
   - `CALLBACK_UNITDEF_GET_BUILD_OPTIONS` (42): Call `callback->UnitDef_getBuildOptions()`, return IntArray
   - `CALLBACK_UNITDEF_GET_MAX_WEAPON_RANGE` (43): Call `callback->UnitDef_getMaxWeaponRange()`, return float
   - `CALLBACK_UNITDEF_GET_BUILD_SPEED` (46): Call `callback->UnitDef_getBuildSpeed()`, return float
   - `CALLBACK_UNIT_GET_DEF` (23): Call `callback->Unit_getDef()`, return int
   - `CALLBACK_CHEATS_SET_EVENTS_ENABLED` (92): Call `callback->Cheats_setEventsEnabled()`, return int

3. **Build and test proxy**: `cmake --build build && cd build && ctest`

### Phase C: Add F# Client Callback Helpers

**Goal**: Provide typed F# methods for the test harness to call.

1. **Add callback query methods to `Client.fs`**:
   - `GetUnitDefs(maxCount)` → sends CallbackRequest, parses IntArray response
   - `GetUnitDefName(defId)` → string response
   - `GetBuildOptions(defId)` → int array response
   - `GetMaxWeaponRange(defId)` → float response
   - `GetBuildSpeed(defId)` → float response
   - `GetUnitDef(unitId)` → int response
   - `SetCheatEventsEnabled(enabled)` → bool response

2. **Build F# client**: `dotnet build`

### Phase D: Replace Harness Discovery with Callback-Based Discovery

**Goal**: `UnitDefRegistry` uses engine callbacks instead of BarData cross-reference.

1. **Rewrite discovery in `PersistentHarness.fs`**:
   - Call `GetUnitDefs(1024)` to get all valid defIds
   - For each defId: call `GetUnitDefName`, `GetBuildSpeed`, `GetMaxWeaponRange`
   - Build `UnitDefRegistry` with engine-verified names and classifications
   - For the commander (from initial events): call `GetBuildOptions` to get buildable defIds

2. **Call `SetCheatEventsEnabled(true)` during fixture init** after cheats are enabled

3. **Validate**: Run T0 smoke tests to verify registry is populated correctly

### Phase E: Diagnose Exhaustive Spawn Crashes

**Goal**: Identify whether crashes are from unit count, bugged defIds, or state leaks.

1. **Unit count test**: Spawn same safe defId (first from registry) 500 times without reset
2. **DefId range isolation**: Spawn defIds in ranges of 50, identify crashing range
3. **Binary search**: Within crashing range, narrow to specific defIds
4. **Build `SpawnBlacklist`**: Record defIds that crash the engine
5. **State leak test**: Spawn 50 + reset × 20 iterations with safe defIds
6. **Update T7**: Use full defId list minus blacklist, with appropriate batch sizes

### Phase F: Restore Weakened Test Assertions

**Goal**: All T3/T4/T6.2/T7/T8 tests use full-strength assertions.

1. **T3 Build Tests**: Use discovered commander build options + real BuildCommand → assert UnitCreated for nanoframe, UnitFinished for completion
2. **T4 Combat Tests**: Assert EnemyEnterLOS, UnitDamaged/EnemyDamaged, UnitDestroyed/EnemyDestroyed from actual combat engagements
3. **T6.2 SelfDestruct**: Assert UnitDestroyed within 500 frames after SelfDestructCommand
4. **T7 Exhaustive Spawn**: Cover all valid defIds (minus blacklist) across batches
5. **T8 Large-Scale Combat**: 100+ armed units, assert DamageEvents > 0 and DestroyedEvents > 0

### Phase G: Documentation and Report

1. **Write `reports/013-diagnose-fix-test-gaps.md`**: Document confirmed root causes, fixes applied, and remaining limitations
2. **Update CLAUDE.md**: Add new callback types to active technologies
3. **Run full suite**: All 38+ tests pass with strengthened assertions

## Risk Analysis

| Risk | Likelihood | Impact | Mitigation |
|------|-----------|--------|------------|
| `Cheats_setEventsEnabled` is NOT the combat event root cause | Medium | High | Phase A investigates systematically with 4 hypotheses ranked by likelihood |
| Some UnitDef callbacks return unexpected data | Low | Medium | Validate each callback individually before building full registry |
| Engine unit count limit is lower than expected | Medium | Medium | Phase E empirically discovers the limit; harness adapts batch sizes |
| Specific defIds crash engine on spawn (not fixable) | High | Low | Blacklist mechanism isolates and documents them |
| `getUnitDefs` callback doesn't work in headless mode | Low | High | Fallback: empirical probe defIds 1-1000 with spawn+getName |

## Complexity Tracking

> No constitution violations. No complexity justifications needed.
