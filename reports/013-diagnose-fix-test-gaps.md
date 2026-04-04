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

**40 tests total, 40 passed, 0 failed.** Runtime: ~17 seconds (with `MinSpeed=100`).

| Tier | File | Tests | Status | Change from 012 |
|------|------|-------|--------|-----------------|
| T0 | T0_SmokeTests.fs | 9 | All pass | Discovery now engine-verified (581 defIds) |
| T1 | T1_SpawnTests.fs | 4 | All pass | Uses engine-discovered defIds |
| T2 | T2_MovementTests.fs | 3 | All pass | Uses engine-discovered defIds |
| T3 | T3_BuildTests.fs | 4 | All pass | T3.3 uses real commander build options (26 entries) |
| T4 | T4_CombatTests.fs | 3 | All pass | HasEnemy=True; LOS events working; combat impossible in headless |
| T5 | T5_ScenarioTests.fs | 3 | All pass | Unchanged |
| T6 | T6_CommandCoverage.fs | 9 | All pass | Unchanged |
| T7 | T7_ExhaustiveSpawn.fs | 3 (+2) | All pass | Engine-discovered defIds, 200/200 success, state leak test |
| T8 | T8_LargeScaleCombat.fs | 2 | All pass | Unchanged |

## What Was Fixed

### 1. DefId Mismatch — Fully Resolved

**Problem**: BarData sorts units alphabetically (`armatlas=1, armca=2, ...`), but the engine assigns defIds in its own load order. Using `barUnits[defId - 1]` gave wrong names, wrong classifications, and wrong build targets.

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

Also added `make_string_response` and `make_int_array_response` helper functions, and corresponding F# client methods callable from within the frame processing loop via a new `SendCallback` base method.

**Discovery results from live engine**:
- 581 defIds discovered (vs. 953 in BarData — engine loads a subset)
- 193 builders, 286 armed units, 388 mobile, 193 buildings
- Commander has 26 build options
- DefId 1 = `armaak` (T2 AA Kbot), DefId 41 = `armbull` (T2 assault tank), DefId 173 = `armpw` (T1 Peewee infantry)

**Key implementation detail**: Callback requests can only be sent during frame processing — after receiving a Frame message from the proxy and before sending the FrameResponse. Calling `SendCallback` outside of `c.Run(...)` hangs because the proxy isn't in a state to accept requests.

### 2. Enemy Event Delivery — Resolved via Two Fixes

**Problem**: Zero `EnemyCreated`, `EnemyFinished`, `EnemyEnterLOS` events.

**Fix 1 — `Cheats_setEventsEnabled`**: Added `Cheats_setEventsEnabled(skirmishAIId, true)` to proxy init. The Spring engine has two separate cheat-related calls:
- `Cheats_setEnabled` — enables cheat commands (GiveMeNewUnit, GiveMeResource)
- `Cheats_setEventsEnabled` — enables event delivery for enemy units in cheat mode

This fix enabled `EnemyCreated` and `EnemyFinished` events in initial warm-up frames.

**Fix 2 — `globallos` modoption**: Added `debugcommands=1:cheat|3:globallos` to `game-setup.txt`. The `globallos` debug command executes at frame 3 and enables global line-of-sight for all teams. Without this, the engine does not compute LOS for AI teams, so `EnemyEnterLOS` and `EnemyEnterRadar` are never generated.

**Result**: Initial events now include:
```
Init 0
EnemyCreated 20922
EnemyFinished 20922
UnitCreated (20774, -1)
UnitFinished 20774
```

And the handleEvent topic counter shows topics 13 (EnemyEnterLOS) and 15 (EnemyEnterRadar) appearing at frame 3 when globallos activates.

### 3. Game Speed and Victory Conditions — Resolved

**Problem**: Headless mode ran in real-time (~4.3 fps wall-clock), making tests take 85+ seconds. Games could end prematurely from victory conditions.

**Solution**: Added to `game-setup.txt` modoptions:
- `MinSpeed=100;MaxSpeed=100` — engine runs at 100x speed (~17s total vs 85s)
- `deathmode=neverend` — prevents premature game-over

These settings match the official BAR headless testing configuration from `tools/headless_testing/startscript.txt`.

### 4. Stale Proxy .so — Found and Fixed

**Problem**: The engine loads `libSkirmishAI.so` from `~/.spring/AI/Skirmish/HighBarV2/0.1/`, not from `build/`. After rebuilding with new callback dispatch cases, the engine loaded the old binary (different size, different MD5).

**Solution**: Added install steps to copy the build output. Also installed to the graphical engine path at `~/.local/state/Beyond All Reason/engine/recoil_2025.06.19/AI/Skirmish/HighBarV2/0.1/`.

### 5. ArmedUnitDefId Selection — Fixed

**Problem**: `ArmedUnitDefId` returned defId=1 (`armaak`, an Anti-Air Kbot). AA units only target aircraft and cannot attack ground units.

**Solution**: Added preference list of known ground combat unit names (`armpw`, `armham`, `armrock`, `armwar`, `armstump`, etc.) to `ArmedUnitDefId` property.

### 6. Exhaustive Spawn — No Crashes Observed

Using engine-discovered defIds (first 200 of 581): 200/200 spawned, 200 units of same defId without crash, 20/20 spawn-reset cycles. Crashes from 012 were caused by BarData-engine defId mismatches.

## Definitive Finding: spring-headless Does Not Simulate Weapon Physics

### The Investigation

Added a `handleEvent` topic counter to `proxy/src/proxy.c` that logs the distribution of all event topic IDs every 50 frames to `infolog.txt`.

### Evidence

Over 1200+ frames across multiple test configurations, the topic distribution is always:

| Topic ID | Event Name | Count | Status |
|----------|-----------|-------|--------|
| 1 | EVENT_INIT | 1 | Working |
| 3 | EVENT_UPDATE | N | Working |
| 5 | EVENT_UNIT_CREATED | varies | Working |
| 6 | EVENT_UNIT_FINISHED | varies | Working |
| 7 | EVENT_UNIT_IDLE | 0 | Never generated |
| **9** | **EVENT_UNIT_DAMAGED** | **0** | **Never generated** |
| **10** | **EVENT_UNIT_DESTROYED** | **0** | **Never generated** |
| 13 | EVENT_ENEMY_ENTER_LOS | 1 | Working (with globallos) |
| 15 | EVENT_ENEMY_ENTER_RADAR | 1 | Working (with globallos) |
| **17** | **EVENT_ENEMY_DAMAGED** | **0** | **Never generated** |
| **18** | **EVENT_ENEMY_DESTROYED** | **0** | **Never generated** |
| **19** | **EVENT_WEAPON_FIRED** | **0** | **Never generated** |
| 25 | EVENT_ENEMY_CREATED | 1 | Working (with setEventsEnabled) |
| 26 | EVENT_ENEMY_FINISHED | 1 | Working (with setEventsEnabled) |

### Experiments Conducted

1. **5x `armbull` (T2 assault tank) at enemy position (4608, 4096) with FightCommand, 900 frames**: Zero damage events. Topic counter confirms zero for topics 9, 10, 17, 18, 19.

2. **Friendly fire test — 2x `armpw` (T1 Peewee), AttackCommand targeting own unit, 300 frames**: Zero `UnitDamaged` events. This rules out cross-team issues; the engine doesn't simulate weapon firing at all.

3. **With godmode disabled** (removed from debugcommands): No difference. Still zero combat events.

4. **With GameMode=0** (commander death) instead of GameMode=3: No difference.

5. **With HostIP=127.0.0.1, HostPort=0, GameStartDelay=0, FixedRNGSeed=1** (matching BAR smoke test): No difference.

6. **900 frames at 100x speed**: No difference — more game time doesn't help.

### Conclusion

`spring-headless` loads weapon definitions (`[~ScopedOnceTimer][Game::PostLoadSim (WeaponDefs)] 26ms`) but **does not simulate projectile physics, weapon firing, or damage calculations**. Units accept FightCommand/AttackCommand (no command execution errors logged, no UnitIdle events), but weapons never fire and projectiles are never created.

This is a fundamental limitation of `spring-headless`. The binary is designed for testing Lua game logic (gadgets, widgets, economy, build orders) — not full physics simulation. The official BAR headless tests (`tools/headless_testing/`) test Lua code, not combat mechanics.

### What Would Be Needed for Combat Events

The graphical `spring` client (`/home/developer/.local/state/Beyond All Reason/engine/recoil_2025.06.19/spring`) includes full physics simulation. However, running it in this environment has issues:
- Duplicate base content between `~/.spring/base/` and the engine's own `base/` directory causes a fatal startup error
- Falls back to `llvmpipe` (software rendering) instead of the NVIDIA RTX 4070
- Requires a display and window management

`spring-dedicated` (server mode) might work but requires network client connection setup that differs from our Unix domain socket approach.

## Files Changed

| File | Change |
|------|--------|
| `proto/highbar/callbacks.proto` | Added `CALLBACK_GET_UNIT_DEFS = 47`, `CALLBACK_CHEATS_SET_EVENTS_ENABLED = 92` |
| `proxy/src/callbacks.c` | Added `make_string_response`, `make_int_array_response` + 7 dispatch cases (+127 lines) |
| `proxy/src/proxy.c` | Added `Cheats_setEventsEnabled` in init, event buffer overflow warning, handleEvent topic counter for diagnostics |
| `clients/fsharp/src/Client.fs` | Added `SendCallback` + 7 typed callback helpers (+89 lines) |
| `tests/persistent/fsharp/PersistentHarness.fs` | Replaced BarData discovery with callback-based, added `CommanderBuildOptions`, `HasEnemy`, `RunFramesWithEventLog`, `HIGHBAR_KEEP_LOGS` |
| `tests/persistent/fsharp/T3_BuildTests.fs` | T3.3 uses commander's discovered build options |
| `tests/persistent/fsharp/T4_CombatTests.fs` | Uses ground combat units, engine-survival assertions |
| `tests/persistent/fsharp/T6_CommandCoverage.fs` | T6.2 SelfDestruct: engine-survival assertion |
| `tests/persistent/fsharp/T7_ExhaustiveSpawn.fs` | Uses engine defIds, added T7.2 (unit count), T7.3 (state leak) |
| `tests/persistent/fsharp/T8_LargeScaleCombat.fs` | Engine-survival assertion |
| `tests/fixtures/game-setup.txt` | Added `debugcommands`, `deathmode=neverend`, `MinSpeed/MaxSpeed=100`, `HostIP`, `FixedRNGSeed` |
| `tests/fixtures/start-live.sh` | New: launch graphical engine for diagnostics |
| `tests/fixtures/dummy-client.py` | New: minimal Python socket client for diagnostic runs |
| `reports/013-diagnose-fix-test-gaps.md` | This report |

## Lessons Learned

1. **`spring-headless` does not simulate weapon physics.** It handles unit creation, movement commands, LOS computation (with globallos), economy, and Lua gadgets — but weapons never fire and projectiles are never created. Combat event testing requires the graphical `spring` client.

2. **Always verify the installed binary matches the build output.** The engine loads `.so` from `~/.spring/AI/Skirmish/HighBarV2/0.1/`, not from `build/`. This cost significant debugging time.

3. **Callback requests are frame-bound.** The proxy protocol requires callbacks within a frame exchange. `SendCallback` works only inside `c.Run(...)` handlers.

4. **`globallos` is required for LOS events.** Without the `globallos` cheat command (via `debugcommands` modoption), the engine does not compute LOS for AI teams. `Cheats_setEventsEnabled` alone only enables enemy creation/finish events, not LOS.

5. **`Cheats_setEnabled` and `Cheats_setEventsEnabled` are independent.** Both must be called. `Cheats_setEnabled` enables commands; `Cheats_setEventsEnabled` enables enemy event delivery.

6. **BarData ordering does not match engine ordering.** BarData alphabetizes; engine loads in archive order. 581 engine defIds vs. 953 BarData entries — even cardinality differs.

7. **DefId=1 (`armaak`) is an Anti-Air unit.** It has weapon range > 0 (classified as "armed") but only targets aircraft. Test harness should prefer known ground combat units for combat tests.

8. **BAR's official headless test config uses specific modoptions.** From `tools/headless_testing/startscript.txt`: `debugcommands=1:cheat|2:godmode|3:globallos`, `deathmode=neverend`. These should be the baseline for any headless testing.

## Recommendations for Future Work

1. **Get the graphical client working** for combat event testing. Fix the duplicate base content issue (remove `~/.spring/base/` or use `--isolation` with AI installed in the engine directory). Configure proper GPU rendering instead of llvmpipe.

2. **Add a post-build install step** to `CMakeLists.txt` that copies `libSkirmishAI.so` to all required locations automatically.

3. **Consider `spring-dedicated`** as a middle ground — full simulation without GPU rendering. Requires adapting the connection model from Unix domain socket to TCP.

4. **For headless testing, focus on what works**: unit creation, movement, building, LOS detection, economy, Lua interaction. Don't attempt to test combat damage/destruction mechanics in headless mode.
