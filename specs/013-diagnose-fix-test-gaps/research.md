# Research: Diagnose and Fix Persistent Test Gaps

**Date**: 2026-04-04  
**Feature**: 013-diagnose-fix-test-gaps

## R1: Why Are Zero Combat Events Received?

### Decision: The proxy serializes all 28 event types correctly. The root cause is NOT proxy filtering.

### Evidence

1. **All 28 events are handled** in `proxy/src/serialize.c` (lines 18-336). `EVENT_UNIT_DAMAGED` (9), `EVENT_UNIT_DESTROYED` (10), `EVENT_ENEMY_ENTER_LOS` (13), `EVENT_ENEMY_DAMAGED` (17), `EVENT_ENEMY_DESTROYED` (18) all have complete serialization implementations.

2. **F# client parses all 28 event types** in `clients/fsharp/src/Events.fs` (lines 38-118). No filtering occurs.

3. **Potential proxy-level event loss mechanisms** (none explain ZERO events):
   - `MAX_EVENTS_PER_FRAME = 256` buffer overflow: silently drops excess events (`proxy/src/proxy.c:363-365`). However, this would still deliver the first 256 events per frame, not zero.
   - Socket backpressure: drops entire frame if socket not writable (`proxy/src/proxy.c:129-133`). Would affect all events, not just combat.
   - Arena serialization failure: drops individual events. Would log warnings.

4. **Most likely root cause: The engine is not generating combat events.** Since the proxy faithfully forwards everything it receives, the problem is upstream. Hypotheses ranked by likelihood:
   - **H1: Cheat-spawned units have wrong team ownership.** `GiveMeNewUnitCommand` spawns units for our team, but the engine may not generate `EnemyDamaged`/`EnemyEnterLOS` for the NullAI's units if LOS is not computed for our team.
   - **H2: The NullAI commander is already dead** by the time combat tests run (destroyed during discovery probes or prior test resets).
   - **H3: Units are not actually engaging.** The map geometry, unit pathing, or weapon range may prevent actual combat despite proximity.
   - **H4: `Cheats_setEventsEnabled` is not called.** The callback `Cheats_setEventsEnabled(skirmishAIId, true)` may be needed to receive enemy visibility events when cheats are active. The proxy calls `Cheats_setEnabled` but may not call `Cheats_setEventsEnabled`.

### Investigation Plan
- Check if `Cheats_setEventsEnabled` is called in `proxy/src/proxy.c` init sequence
- Add DEBUG logging to `handleEvent` to count all events by topic per frame
- Verify enemy commander alive by checking for `EVENT_ENEMY_CREATED` or `EVENT_ENEMY_ENTER_LOS` in initial events
- Run a minimal repro: spawn one armed unit at enemy position, run 300 frames, log all events

### Alternatives Considered
- Switching to INDIVIDUAL frame mode: Would not help if engine isn't generating events
- Increasing MAX_EVENTS_PER_FRAME: Would not help for zero events
- Adding LOS config to game-setup.txt: No such config exists in Spring — LOS is automatic

---

## R2: How To Discover Engine DefId-to-UnitName Mapping?

### Decision: Use the existing callback request-response mechanism to add UnitDef query dispatches to the proxy.

### Rationale

The proxy already stores the `SSkirmishAICallback` pointer (`proxy/src/proxy.c:24`) and has a working callback dispatch mechanism (`proxy/src/callbacks.c`). The F# client already supports sending `CallbackRequest` messages. Only 8 of 53+ defined callback types are currently dispatched. Adding UnitDef queries requires only new `case` statements in `hb_callback_dispatch()`.

### Required Callbacks (from `proxy/include/AI/SSkirmishAICallback.h`)

| Callback | Purpose | Priority |
|----------|---------|----------|
| `getUnitDefs` | Get all valid defId values | P1 |
| `UnitDef_getName` | Map defId to unit name | P1 |
| `UnitDef_getBuildOptions` | Get a unit's build list | P1 |
| `Unit_getDef` | Get defId for a specific unit instance | P1 |
| `UnitDef_isBuilder` | Check if unit is a builder | P2 |
| `UnitDef_getMaxWeaponRange` | Check if unit is armed | P2 |
| `UnitDef_getBuildSpeed` | Builder classification | P2 |

### Alternatives Considered
- **Lua-based discovery via `CallLuaRulesCommand`**: Requires a custom Lua gadget in the BAR mod. Fragile — depends on mod version. Rejected.
- **Empirical spawn-and-check**: Spawn each defId, observe UnitCreated, cross-reference. Already tried in 012 — unreliable without knowing the name. Rejected as primary method (useful as validation).
- **Parse engine data files directly**: Engine loads units in its own order which isn't documented. Not feasible.

---

## R3: Why Does SelfDestruct Not Produce UnitDestroyed?

### Decision: Likely same root cause as combat events (event delivery issue) OR insufficient frame budget.

### Evidence
- BAR self-destruct countdown is 5 seconds. At 30fps, that's 150 frames. At headless speed (potentially faster), it could be fewer frames.
- The test ran only 200 frames (~6.7s at 30fps). If headless runs at real-time speed, this should be sufficient.
- However, if `UnitDestroyed` events are not being delivered (same root cause as combat events), increasing frames won't help.

### Investigation Plan
- Fix combat event delivery first (R1)
- Retest SelfDestruct with 500 frames
- If still no event, add `Unit_getHealth` callback queries to check if unit health drops to zero

---

## R4: Why Does The Engine Crash On Large Batch Spawns?

### Decision: Binary search needed to isolate crash cause — unit count limit vs. bugged defIds vs. state leaks.

### Evidence
- Engine crashed when spawning 200+ defIds across batches with `ResetGameState` between them
- `ResetGameState` uses `.destroy` text commands + resource reset — may not fully clean engine state
- Spring engine has a configurable max unit limit (typically 10000 per team, 32000 total)
- Some defIds may reference units with invalid models, missing textures, or circular dependencies that crash the engine during instantiation

### Investigation Plan
1. Test unit count limit: spawn same safe defId (e.g., defId=1) 500 times without reset — does it crash?
2. Test defId isolation: spawn defIds 1-50 in one batch, 51-100 in next, etc. — which range crashes?
3. Binary search within crashing range to find specific defIds
4. Test reset completeness: spawn 50, reset, spawn 50, repeat 20 times — does cumulative state crash?

---

## R5: `Cheats_setEventsEnabled` — Critical Discovery

### Decision: This is the most likely root cause of zero combat events.

### Evidence from `proxy/include/AI/SSkirmishAICallback.h`:

```c
bool (CALLING_CONV *Cheats_setEventsEnabled)(int skirmishAIId, bool enabled);
```

The proxy calls `Cheats_setEnabled(true)` to enable cheat commands (GiveMeNewUnit, GiveMeResource), but **may not call `Cheats_setEventsEnabled(true)`**. Per the Spring engine documentation and CircuitAI's behavior:

- When cheats are enabled, the engine may suppress certain enemy-related events by default
- `Cheats_setEventsEnabled(true)` explicitly requests that the engine continue sending all events even in cheat mode
- This would explain why the proxy receives UnitCreated/UnitFinished (own team events) but zero EnemyEnterLOS/EnemyDamaged (enemy events)

### Verification
- Check if `Cheats_setEventsEnabled` is called in `proxy/src/proxy.c` init sequence
- If not called, add the call immediately after `Cheats_setEnabled(true)`
- Rerun combat tests to verify event delivery
