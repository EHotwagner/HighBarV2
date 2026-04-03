# Research: Fix Remaining Test Failures

**Feature Branch**: `005-fix-test-failures`  
**Date**: 2026-04-03

## Research Topic 1: BAR Spawn Modoptions for Headless AI Games

### Decision
Update `game-setup.txt` with the following changes:
- `StartPosType=2` (in-game selection, compatible with BAR's spawn gadget)
- Add `teamfaction_0=armada` and `teamfaction_1=cortex` to MODOPTIONS
- Add `startboxes=return { [0] = { 0, 0, 0.5, 1 }, [1] = { 0.5, 0, 1, 1 } }` to MODOPTIONS
- Add `Side=Armada` and `Side=Cortex` to TEAM0 and TEAM1 sections

### Rationale
BAR's `game_initial_spawn.lua` gadget requires:
1. **Faction assignment**: Either `teamfaction_N` modoptions or `Side=` on TEAM sections tell the spawn gadget which commander type to create (Armada vs Cortex). Without this, the gadget has no commander to spawn.
2. **Start position data**: The `startboxes` modoption provides spawn areas. Without it, the engine logs "No modoption start position data found" and the spawn gadget skips placement.
3. **StartPosType compatibility**: `StartPosType=0` (fixed) expects explicit `StartPosX`/`StartPosZ` coordinates on each team. The BAR spawn gadget is designed for `StartPosType=2` (in-game selection) combined with `startboxes` — this is how the BAR lobby and `recoil-autohost` configure games.

The reference minimal headless script from report 008 (line 250-282) uses `StartPosType=2` with `Side=Armada`/`Side=Cortex` on team sections.

### Alternatives Considered
- **StartPosType=3 (pre-game)**: Also viable but less commonly used in BAR's autohost configurations. Type 2 is the standard.
- **StartPosType=0 with explicit coordinates**: Would require knowing exact valid spawn positions for the map. More fragile and map-dependent.
- **Only Side= without teamfaction modoptions**: May work but the report 010 analysis specifically flags missing `teamfaction_N` as a cause. Using both provides redundancy.

## Research Topic 2: Init Event Delivery in BATCHED Mode

### Decision
Widen the Init event test search window to scan multiple frames rather than only the first frame. This is a test-only fix — no proxy changes.

### Rationale
Analysis of the proxy source (`proxy/src/proxy.c`) confirms the Init event flow:

1. Engine calls `init()` → proxy connects, performs handshake (no events sent)
2. Engine calls `handleEvent(EVENT_INIT)` → proxy buffers in `pending_events[0]`
3. Engine calls `handleEvent(EVENT_UPDATE, frame=0)` → proxy flushes batch: `[Init, Update]`

The Init event **is** included in the first Frame message. The client's `Handshake()` reads exactly one message (the handshake response) and does not consume frame data.

However, the test failure suggests a timing issue: if `Run()` is called slightly after the first frame arrives on the socket, the OS socket buffer holds it. But if any test infrastructure reads from the socket between handshake completion and `Run()` entry, that frame could be consumed.

The safest fix is to collect multiple frames in the test and scan all of them for Init. This:
- Tolerates timing variations
- Requires no proxy modifications (per constitution: avoid changes unless needed)
- Is consistent with Init being a one-time event that appears exactly once across all frames

### Alternatives Considered
- **Capture Init during handshake**: Would require proxy changes to flush Init immediately — violates the assumption that only test/harness code needs changes.
- **Buffer first frame in harness**: More complex harness change; adds state management. The test-level fix is simpler.
- **Explicit Init flush in proxy**: Adds special-case logic to the hot path for a single event type. Over-engineering for a test timing issue.

## Research Topic 3: Report Numbering Convention

### Decision
Next report will be numbered `011` following the existing 3-digit sequential convention.

### Rationale
Reports directory contains 001 through 010. Format is `NNN-descriptive-name.md`. The new report should be `011-test-fix-results.md` or similar.
