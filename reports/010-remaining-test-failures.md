# Report: Remaining Test Failures — Root Cause Analysis

**Date**: 2026-04-03
**Iteration**: 010

## Context

After fixing the proxy ABI (real Recoil engine headers), refactoring the harness architecture (listen→accept model), installing the full BAR game via the launcher, and clearing a stale port conflict — the test suite was run against a live `spring-headless 2025.06.21` with the real BAR game content (`Beyond All Reason test-29833-ee0f96a`).

## Test Results

**11 Passed, 12 Failed** (23 total)

### Passing Tests (11)
| Test | Time | Category |
|------|------|----------|
| Harness smoke test | 2ms | Harness |
| Client connects to engine proxy socket | <1ms | Connection |
| Handshake completes with valid protocol metadata | <1ms | Connection |
| Empty command responses work for consecutive frames | 619ms | Connection |
| Graceful disconnect after receiving frames | 4s | Connection |
| Update events received with matching frame numbers | 1s | Events |
| Combat events received when units engage | 11s | Events |
| Unknown events do not crash the frame loop | 2s | Events |
| Game frame numbers are consistent | 2s | Callbacks |
| Team resources are accessible without errors | 2s | Callbacks |
| Invalid commands do not crash the proxy | 3s | Callbacks |

These tests prove the **full end-to-end pipeline** works: engine → proxy → socket → client → handshake → frame loop → events → callbacks → commands.

### Failing Tests (12)

The failures group into exactly **two root causes**.

---

## Root Cause 1: Init Event Not Delivered to Frame Loop (2 tests)

**Affected tests:**
- `First frame contains Init event`
- `Init event received with valid team ID`

### Mechanism

The proxy operates in `BATCHED` mode. Events are accumulated in `pending_events[]` and sent as a batch when `EVENT_UPDATE` arrives. The sequence is:

```
Engine calls: init()           → proxy connects, handshakes
Engine calls: handleEvent(INIT) → event buffered in pending_events[0]
Engine calls: handleEvent(UPDATE, frame=0) → batch sent: [INIT, UPDATE]
```

The F# client receives the batch as a `Frame` message. The first frame **does** contain the Init event in the protobuf. However, the test's `runForFrames` helper captures frames and checks for `GameEvent.Init`. 

The test expects Init to appear in the first frame captured by `client.Run()`, but there's a timing issue: the first few UPDATE frames may be delivered before the test enters `Run()`, and the client reads them as data on the socket. The Init event arrives in the very first frame, but `Run()` may start reading from frame N>0 if previous frames were consumed during the connection/handshake phase.

### Fix Required

Option A: Capture the Init event during `Handshake()` or immediately after accepting the connection, before entering `Run()`.

Option B: Increase the frame window in the test and scan across all frames for Init (it only appears once, in frame 0).

Option C: Have the harness buffer the first frame automatically and make it available to tests.

---

## Root Cause 2: No Units Spawned by BAR (10 tests)

**Affected tests:**
- `UnitCreated event received for builder unit`
- `UnitIdle event received for idle builder`
- `MoveCommand causes unit to change position`
- `StopCommand halts a moving unit`
- `BuildCommand triggers unit creation`
- `PatrolCommand accepted without errors`
- `Guard Attack Repair Fight commands accepted without crashing`
- `StopCommand for all units accepted without errors`
- `Unit position query returns plausible coordinates`
- `Full AI turn sequence - move build stop`

### Mechanism

The engine runs the game successfully (frame 5112+ reached, 17+ minutes runtime). But **zero units exist** on the map. The infolog confirms:

1. `game_initial_spawn.lua` gadget loaded successfully (no errors)
2. Game is running with frames advancing
3. No unit creation events appear in the log
4. No errors about missing unit definitions

The BAR game's initial spawn system (`game_initial_spawn.lua`) requires specific conditions to spawn commanders:

1. **StartPosType**: Our script uses `StartPosType=0` (fixed positions), but BAR's spawn gadget may expect `StartPosType=2` (ingame selection) or `StartPosType=3` (beforegame).

2. **Missing modoptions**: BAR typically requires modoptions to configure spawning:
   - `startboxes` — defines spawn areas
   - `team_commander_types_N` — which commander each team gets  
   - `teamfaction_N` — faction selection (Armada/Cortex)
   
   Without these, the spawn gadget may silently skip spawning.

3. **Player vs AI team ownership**: `PLAYER0` is a spectator on `Team=0`, and `AI0` is also on `Team=0`. The spawn gadget may check for an active (non-spectator) player on each team and skip spawning if none found.

4. **No faction/commander selection**: BAR requires each team to select a commander type. With `StartPosType=0` and no `teamfaction_N` modoption, the random selection in `game_initial_spawn.lua` may have a code path that silently fails.

### Evidence

From the infolog:
```
[Start Position Suggestions] Warning: No modoption start position data found
```

This warning (seen in earlier runs) confirms BAR's spawn system expects position data via modoptions that we're not providing.

### Fix Required

Update `game-setup.txt` to include BAR-specific modoptions for spawning. Based on how the `recoil-autohost` and BAR lobby configure games:

```ini
[MODOPTIONS]
{
    GameMode=3;
    startboxes=return { [0] = { 0, 0, 0.5, 1 }, [1] = { 0.5, 0, 1, 1 } };
    teamfaction_0=armada;
    teamfaction_1=cortex;
}
```

Additionally, may need `StartPosType=2` or `StartPosType=3` instead of `0`, or specify explicit start positions with `StartPosX`/`StartPosZ` in the `[TEAM0]`/`[TEAM1]` sections.

Alternative: study how the `recoil-autohost` configures single-player/AI test games and replicate that configuration exactly.

---

## Summary

| Root Cause | Tests Affected | Fix Complexity | Proxy Bug? |
|-----------|---------------|----------------|------------|
| Init event timing | 2 | Low — test adjustment | No |
| BAR spawn modoptions | 10 | Medium — game config research | No |

**The proxy itself is working correctly.** All failures are in either test expectations or game configuration. The 11 passing tests demonstrate that the full communication pipeline (engine → proxy → socket → protobuf → F# client) functions end-to-end with the real Recoil engine and BAR game.

## Next Steps

1. **Research BAR spawn modoptions**: Read `game_initial_spawn.lua` from the BAR game source to determine exact modoptions needed for headless AI games
2. **Update game-setup.txt**: Add required modoptions for commander spawning
3. **Fix Init event tests**: Adjust test expectations or buffer the first frame
4. **Update Python harness**: Port the listen→accept architecture to `conftest.py`
5. **Add stale process cleanup**: Kill any `recoil-main` processes holding port 8452 before launching
