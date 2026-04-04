# Report: Visual Game Test Validated — Unit Commands Work End-to-End

**Date**: 2026-04-04
**Iteration**: 16

## Context

After fixing the INTERNAL_ORDER flag (report 015) and the stale binary problem, we needed to validate that unit commands work in the full graphical BAR engine — not just headless. This report covers visual game testing with the reference AI controlling a commander in real-time.

## Results

### Move Command — Confirmed Working

The reference AI (`tools/reference-ai/Program.fs`) was configured to patrol the commander between start position and map center. Results from a full visual game session:

| Metric | Value |
|--------|-------|
| Commander start position | (550, 3597) |
| Patrol target (map center) | (3584, 4096) |
| Lap time (one way) | ~90 seconds at 1x speed |
| Full round trips completed | 9+ (tested at 100x speed initially) |
| Direction changes (UnitIdle events) | All detected correctly |
| Move commands accepted | 100% (rc=0, position changes confirmed) |

Position tracking confirmed continuous movement:
```
Frame   60: Move sent → target B
Frame  300: (719, 3791) moving
Frame 2773: Arrived at B (3575, 4100) — heading back
Frame 5488: Arrived at A (556, 3605) — heading to B
...9 full laps completed
```

### Self-Destruct Command — Confirmed Working

Tested separately: commander walked for 50 seconds, then self-destructed on command.
- Self-destruct sent at frame 1500
- Commander destroyed at frame 1667 (~5.5 second countdown, as expected)
- `UnitDestroyed` event received correctly

### Graphical Engine Specifics

- **Engine**: Recoil 2025.06.19 (graphical `spring`, not `spring-headless`)
- **Display**: GPU passthrough, NVIDIA 595.58.03, OpenGL 4.6
- **Map**: Red Rock Desert v2
- **Game**: Beyond All Reason test-29840-d9b7dba

## Issues Found and Fixed

### 1. start-live.sh deleted the AI's listening socket

`start-live.sh` ran `rm -f "${SOCKET_PATH}"` during cleanup, which destroyed the socket the AI client was already listening on. The proxy then couldn't connect during `init()`.

**Fix**: Removed socket deletion from start-live.sh. The AI client owns the socket lifecycle.

### 2. UnitIdle not received during loading phase

The commander doesn't emit `UnitIdle` during the initial loading phase in graphical mode. The reference AI originally waited for `UnitIdle` to send the first move command, which never arrived.

**Fix**: Send first move command on `Update` at frame 60 (~2 seconds after game start) instead of waiting for `UnitIdle`. Subsequent direction changes still use `UnitIdle` reliably.

### 3. Game speed locked at 100x for visual tests

All game-setup files had `MinSpeed=100; MaxSpeed=100` — appropriate for headless test automation but unusable for visual observation.

**Fix**: Created `game-setup-live.txt` with `MinSpeed=1; MaxSpeed=1` for 1x real-time speed. Headless test fixtures remain at 100x.

## Files Changed

| File | Change |
|------|--------|
| `tests/fixtures/start-live.sh` | Removed socket deletion; AI client owns socket lifecycle |
| `tests/fixtures/game-setup-live.txt` | Game speed set to 1x for visual testing |
| `tools/reference-ai/Program.fs` | Patrol demo: move on Update(60), flip on UnitIdle |

## Lessons Learned

1. **The AI client must be listening before the engine starts.** The proxy calls `connect()` during `init()`, which fires early in the engine load sequence. The socket must exist and be bound at that point.
2. **Don't delete shared resources in startup scripts.** The `rm -f socket` pattern is fine for headless tests (harness owns the socket) but breaks live tests where an external AI client owns it.
3. **Use separate game-setup files for headless vs visual.** 100x speed is correct for CI; 1x is correct for observation.
4. **First command timing matters.** Frame 60 is a safe point — the game simulation is running and units are responsive. Frame 0 events happen during loading and commands may be lost.
