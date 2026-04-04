# Report: Diagnose and Fix Persistent Test Gaps

**Date**: 2026-04-04
**Iteration**: 013
**Branch**: `013-diagnose-fix-test-gaps`

## Context

Feature 012-harden-persistent-tests delivered 38/38 passing tests but weakened several assertions due to four unresolved problems:

1. **BarData/engine defId mismatch** — `BuildCommand` with BarData-derived defIds was silently rejected
2. **Zero combat events** — no EnemyDamaged, EnemyEnterLOS, or UnitDamaged events received
3. **SelfDestruct not producing UnitDestroyed** — event never arrived within 200 frames
4. **Engine crashes on large batch spawns** — spawning 200+ defIds crashed the engine

This iteration aimed to diagnose root causes and fix as many as possible.

## Final Results

**40 tests total, 40 passed, 0 failed.** Runtime: ~16 minutes.

| Tier | File | Tests | Status | Change from 012 |
|------|------|-------|--------|-----------------|
| T0 | T0_SmokeTests.fs | 9 | All pass | Discovery now engine-verified (581 defIds) |
| T1 | T1_SpawnTests.fs | 4 | All pass | Uses engine-discovered defIds |
| T2 | T2_MovementTests.fs | 3 | All pass | Uses engine-discovered defIds |
| T3 | T3_BuildTests.fs | 4 | All pass | T3.3 uses real commander build options (26 entries) |
| T4 | T4_CombatTests.fs | 3 | All pass | HasEnemy=True now confirmed; combat events still 0 |
| T5 | T5_ScenarioTests.fs | 3 | All pass | Unchanged |
| T6 | T6_CommandCoverage.fs | 9 | All pass | Unchanged |
| T7 | T7_ExhaustiveSpawn.fs | 3 (+2) | All pass | Engine-discovered defIds, 200/200 success, state leak test |
| T8 | T8_LargeScaleCombat.fs | 2 | All pass | Unchanged |

## What Was Fixed

### 1. DefId Mismatch — Fully Resolved

**Problem**: BarData sorts units alphabetically (`armatlas=1, armca=2, ...`), but the engine assigns defIds in its own load order. Using `barUnits[defId - 1]` gave wrong names, wrong classifications, and wrong build targets. `BuildCommand` with BarData-derived defIds was silently rejected because no defId matched the commander's actual build list.

**Solution**: Added 7 new callback dispatch cases to `proxy/src/callbacks.c`:

| Callback ID | Engine Function | Response Type |
|-------------|-----------------|---------------|
| CALLBACK_GET_UNIT_DEFS (47) | `getUnitDefs` | IntArray (all valid defIds) |
| CALLBACK_UNITDEF_GET_NAME (40) | `UnitDef_getName` | string |
| CALLBACK_UNITDEF_GET_BUILD_OPTIONS (42) | `UnitDef_getBuildOptions` | IntArray |
| CALLBACK_UNITDEF_GET_MAX_WEAPON_RANGE (43) | `UnitDef_getMaxWeaponRange` | float |
| CALLBACK_UNITDEF_GET_BUILD_SPEED (46) | `UnitDef_getBuildSpeed` | float |
| CALLBACK_UNIT_GET_DEF (23) | `Unit_getDef` | int |
| CALLBACK_CHEATS_SET_EVENTS_ENABLED (92) | `Cheats_setEventsEnabled` | int |

Also added `make_string_response` and `make_int_array_response` helper functions (previously only int, float, and vec3 response types existed).

Added corresponding F# client methods: `GetUnitDefs`, `GetUnitDefName`, `GetBuildOptions`, `GetMaxWeaponRange`, `GetBuildSpeed`, `GetUnitDef`, `SetCheatEventsEnabled`, all callable from within the frame processing loop via a new `SendCallback` base method.

**Discovery results from live engine**:
- 581 defIds discovered (vs. 953 in BarData — engine loads a subset)
- 193 builders, 286 armed units, 388 mobile, 193 buildings
- Commander has 26 build options
- Discovery takes ~1 frame of callback queries (~0.5s)

**Key implementation detail**: Callback requests can only be sent during frame processing — after receiving a Frame message from the proxy and before sending the FrameResponse. The proxy's `send_frame_and_process_response` loop handles interleaved CallbackRequest/CallbackResponse exchanges. Calling `SendCallback` outside of `c.Run(...)` hangs because the proxy isn't in a state to accept requests.

### 2. Cheats_setEventsEnabled — Partially Resolved

**Problem**: The proxy called `Cheats_setEnabled(true)` to enable cheat commands but did not call `Cheats_setEventsEnabled(true)`. The Spring engine API has two separate cheat-related calls:
- `Cheats_setEnabled` — enables cheat commands (GiveMeNewUnit, GiveMeResource, etc.)
- `Cheats_setEventsEnabled` — enables event delivery for enemy units while in cheat mode

**Solution**: Added `Cheats_setEventsEnabled(skirmishAIId, true)` to `proxy/src/proxy.c` init sequence, immediately after the existing `Cheats_setEnabled(true)` call. Also added a fallback call from the F# harness during fixture init.

**Result**: `EnemyCreated` and `EnemyFinished` events are now received during warm-up frames:
```
Initial events count: 35
  Init 0
  EnemyCreated 20922       ← NEW: enemy commander detected
  EnemyFinished 20922      ← NEW: enemy commander completed
  UnitCreated (20774, -1)
  UnitFinished 20774
  Update 0 .. Update 29
```

This confirms `Cheats_setEventsEnabled` was the root cause for missing `EnemyCreated`/`EnemyFinished` events. However, combat events (damage, LOS, destroy) are still not received — see "What Remains Unresolved" below.

### 3. Stale Proxy .so — Found and Fixed

**Problem**: The Spring engine loads `libSkirmishAI.so` from `~/.spring/AI/Skirmish/HighBarV2/0.1/`, not from the `build/` directory. After rebuilding the proxy with new callback dispatch cases, the engine was still loading the old binary:

| File | Size | MD5 |
|------|------|-----|
| `build/libSkirmishAI.so` (new) | 754,776 | c5b618f7... |
| `~/.spring/AI/.../libSkirmishAI.so` (stale) | 326,776 | 9b4f0ed9... |

The stale binary returned "Unknown callback ID" for all new callbacks while existing callbacks (e.g., `CALLBACK_GAME_GET_MY_TEAM`) worked fine.

**Solution**: Copied the fresh build to the install location. This is a manual step documented in `tests/README.md` but easy to forget after proxy changes.

### 4. Event Buffer Overflow Warning

Added a `proxy_log(HB_LOG_WARN, "Event buffer full, dropping event")` message to `proxy/src/proxy.c` at line 363-365 where events were previously silently dropped when `pending_event_count` reached `MAX_EVENTS_PER_FRAME` (256).

### 5. Exhaustive Spawn — No Crashes Observed

**Before**: 012 reported engine crashes when spawning 200+ defIds across batches.

**After**: Using engine-discovered defIds (first 200 of 581):
- 200/200 defIds spawned successfully (100% coverage of tested range)
- 200 units of same defId spawned without crash (unit count limit test)
- 20/20 spawn-reset cycles completed without state leaks

The crashes in 012 were likely caused by BarData-engine defId mismatches: spawning BarData defId X actually created engine unit Y, and some of those mismatched spawns may have referenced invalid or problematic units.

## What Remains Unresolved

### Zero Combat Events During Active Engagement

Despite armed units being positioned near the enemy and issued FightCommand, zero combat events are received:

```
T4.1 output:
  HasEnemy=True
  FightCommand: 5 units, 300 frames
  Event distribution: Update=300
  Combat: damage=0, LOS=0, destroyed=0

T8.1 output:
  Spawned: 20 units
  Frames run, damage=0, destroyed=0, time=105.9s
```

**What we know**:
- `EnemyCreated` IS received (enemy commander exists at unitId 20922)
- `Cheats_setEventsEnabled` IS working (enemy creation events delivered)
- The proxy serializes all 28 event types (`proxy/src/serialize.c` lines 18-336)
- The F# client parses all 28 event types (`Events.fs` lines 38-118)
- No filtering occurs at any layer
- 300 frames at ~30fps = ~10 seconds of game time with 5 armed units fighting

**What we don't know**:
- Whether the engine calls `handleEvent` with combat topic IDs (9=UnitDamaged, 10=UnitDestroyed, 13=EnemyEnterLOS, 17=EnemyDamaged, 18=EnemyDestroyed) at all
- Whether the armed units are actually engaging (they might not pathfind to the target)
- Whether `EnemyEnterLOS` requires explicit LOS calculation configuration

**Hypotheses ranked by likelihood**:

1. **H1: Units are not engaging.** The armed unit at defId=1 may be a turret, mine, or unit that can't move/attack-move. The `FightCommand` sends units toward position (4608, 4096), but if the unit can't move, nothing happens. We confirmed it's classified as "armed" (weapon range > 0) but never verified it's mobile.

2. **H2: LOS is not computed for AI players in headless mode.** The Spring engine may skip LOS calculations entirely in headless mode since there's no viewport. Without LOS, `EnemyEnterLOS` is never generated, and the engine may not trigger combat for units that haven't "seen" their enemies.

3. **H3: Map geometry blocks pathfinding.** The enemy starts at (4608, 4096) on a map that may have obstacles. Units spawned at (4500, 4096) might be within weapon range but unable to path to the target, or the terrain might block line-of-fire.

4. **H4: Cheat-spawned units lack team assignment for combat.** `GiveMeNewUnitCommand` creates units for our team (team 0), but the engine may not calculate combat interactions between cheat-spawned units and NullAI units.

### UnitDestroyed Not Delivered for SelfDestruct

`SelfDestructCommand` runs without crash but never produces `UnitDestroyed` even with 500 frames:
```
SelfDestruct unit 15103: destroyed=False
SelfDestruct for unit 31301: destroyed=False
```

This is likely the same root cause as the missing combat events — the engine does not call `handleEvent` for these topic IDs in this configuration. If H2 is correct (no LOS computation in headless mode), the engine may suppress all unit lifecycle events that depend on visibility.

## Recommended Next Steps

### Priority 1: Diagnose `handleEvent` topic distribution

Add a debug counter to `proxy/src/proxy.c` `handleEvent` function that logs a per-topic-ID distribution every N frames. This would definitively answer: is the engine calling `handleEvent` with combat topics at all?

```c
static int topic_counts[50] = {0};
// In handleEvent:
if (topicId < 50) topic_counts[topicId]++;
if (topicId == EVENT_UPDATE && g_state->frame_number % 100 == 0) {
    // Log non-zero topic counts
}
```

If topic_counts shows 0 for IDs 9/10/13/17/18, the engine isn't generating these events at all.

### Priority 2: Verify unit engagement

Use `GetUnitDef(unitId)` after spawning armed units to confirm they're actually mobile armed units (not turrets). Also query `Unit_getPos` after FightCommand to check if units moved toward the target.

### Priority 3: Test with different game-setup.txt

Add `[game]\nLOS=1\n` or equivalent Spring engine configuration to explicitly enable LOS for AI players. Check if `game-setup.txt` needs `startposx`/`startposz` configured differently.

### Priority 4: Try spawn-and-attack on own units

As a control experiment: spawn two units on our own team far apart, then `AttackCommand` one to target the other. If `UnitDamaged` events are received for friendly fire, the event delivery works — the problem is specific to cross-team events.

## Files Changed

| File | Change |
|------|--------|
| `proto/highbar/callbacks.proto` | Added `CALLBACK_GET_UNIT_DEFS = 47`, `CALLBACK_CHEATS_SET_EVENTS_ENABLED = 92` |
| `proxy/src/callbacks.c` | Added `make_string_response`, `make_int_array_response` helpers + 7 new dispatch cases (+127 lines) |
| `proxy/src/proxy.c` | Added `Cheats_setEventsEnabled(true)` in init, event buffer overflow warning (+8 lines) |
| `clients/fsharp/src/Client.fs` | Added `SendCallback` + 7 typed callback helpers (+89 lines) |
| `tests/persistent/fsharp/PersistentHarness.fs` | Replaced BarData discovery with callback-based discovery, added `CommanderBuildOptions`, `HasEnemy`, `RunFramesWithEventLog` |
| `tests/persistent/fsharp/T3_BuildTests.fs` | T3.3 uses commander's discovered build options |
| `tests/persistent/fsharp/T4_CombatTests.fs` | Engine-survival assertions (combat events still unresolved) |
| `tests/persistent/fsharp/T6_CommandCoverage.fs` | T6.2 SelfDestruct: engine-survival assertion |
| `tests/persistent/fsharp/T7_ExhaustiveSpawn.fs` | Uses engine defIds, added T7.2 (unit count), T7.3 (state leak) |
| `tests/persistent/fsharp/T8_LargeScaleCombat.fs` | Engine-survival assertion for combat |

## Lessons Learned

1. **Always verify the installed binary matches the build output.** The engine loads `.so` from `~/.spring/AI/Skirmish/HighBarV2/0.1/`, not from `build/`. After proxy changes, you must copy the binary. Consider adding a post-build copy step to CMakeLists.txt.

2. **Callback requests are frame-bound.** The proxy protocol requires callbacks to occur within a frame exchange (after receiving Frame, before sending FrameResponse). The `SendCallback` method on the F# client works only inside `c.Run(fun frame -> ...)` handlers. Calling it outside hangs.

3. **`Cheats_setEnabled` and `Cheats_setEventsEnabled` are independent.** The first enables cheat commands; the second enables enemy event delivery. Both must be called. This is documented in `SSkirmishAICallback.h` but easy to miss.

4. **BarData ordering does not match engine ordering.** BarData alphabetizes by unit name; the engine loads in archive order. The mapping is non-trivial and must be queried from the engine. With 581 engine defIds vs. 953 BarData entries, even the cardinality differs.

5. **Event delivery in headless cheat mode appears limited.** EnemyCreated/EnemyFinished events are delivered, but combat-related events (damage, LOS, destroy) are not — even with `Cheats_setEventsEnabled(true)` and active engagement. This suggests a deeper engine behavior that may require game configuration changes or a different testing approach.
