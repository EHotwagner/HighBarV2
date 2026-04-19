---
To: FSBarV1 (scripting)
From: HighBarV2 (proxy)
Date: 2026-04-19
Feature: 034-fix-command-execute
Status: **Negative result — no fix ships.** Follow-up required.
---

## Summary

Feature 034 was opened to close the gap 033 left behind: `[HB] dispatch case=BUILD_UNIT … engine_rc=0` lines appear in the engine infolog, yet the commander never builds a nanoframe. The plan was an in-proxy probe to compare candidate `SSkirmishAICallback` dispatch conventions against the live engine and ship the one that produces engine-observable effect.

**Result**: none of the candidate conventions produce a nanoframe. No proxy change ships on this branch. The proxy on `master` (post-033) remains the current state. Feature 035 will need a new hypothesis surface; this reply documents what we ruled out so the next investigation does not retread it.

## Root cause

Unresolved. `Engine_handleCommand` returns `rc=0` for `COMMAND_UNIT_BUILD` under every dispatch convention we probed, but the engine does not enqueue a build order. The engine's acceptance is non-informative: `rc=0` here means "call accepted" but not "effect queued".

## Adopted dispatch convention

**None.** All four probed candidates were non-viable:

| Variant | Call | Result |
|---|---|---|
| A (033 baseline) | `Engine_handleCommand(aiId, toId=-1, commandId=-1, COMMAND_UNIT_BUILD, &SBuildUnitCommand)` | `rc=0`, no nanoframe in 1500 frames |
| B | `Engine_handleCommand(aiId, toId=unit_id, commandId=-1, COMMAND_UNIT_BUILD, &SBuildUnitCommand)` | `rc=0`, no nanoframe in 1500 frames |
| C | `Engine_executeCommand(aiId, unit_id, groupId=-1, &SBuildUnitCommand)` | **engine crash** within ~1 frame of dispatch; engine infolog truncates mid-line |
| D | `Engine_handleCommand(aiId, toId=my_team_id, commandId=-1, COMMAND_UNIT_BUILD, &SBuildUnitCommand)` | `rc=0`, no nanoframe in 1500 frames |

Each candidate was tested via `scripts/examples/python/diag_one_build.py` against a fresh headless session on Avalanche 3.4, HighBarV2 (Armada) vs BARb (Cortex), with the probe compiled under `-DHB_DISPATCH_PROBE=ON` in `proxy/CMakeLists.txt` and selected at runtime via the `HB_PROBE_VARIANT={A|B|C|D}` env var on the Hub process. The probe code is **not** on `master` — it was reverted as part of this branch's cleanup per research.md Decision 4.

### Variant C specifics

`Engine_executeCommand(aiId, unitId, groupId, commandData)` crashes the engine when `commandData` is a topic-specific struct (here `SBuildUnitCommand`). The vendored header (`proxy/include/AI/SSkirmishAICallback.h:51`) gives no struct-layout contract for `commandData` under this entry point, so we cannot rule out that `Engine_executeCommand` is the right call with a different (as-yet-unknown) `commandData` shape. Investigating that shape requires either engine source (constitution I forbids) or a different empirical angle (see Next hypotheses below).

## Caller guidance

Unchanged from 033. External scripting clients can continue to call `SendCommand(BuildUnitCommand)`; the proxy will dispatch, the engine will return `rc=0`, but no unit will spawn. Do not block on HighBar for this. If you have infrastructure that can drive the commander via an alternate path (e.g., the in-process trainer proving it works), keep using that for now.

## Client version

**No bump.** `HighBar.Client` version on `master` is unchanged from the 033 release. No new client-side behaviour ships from this branch.

## Next hypotheses (for feature 035 or an FSBarV1-side probe)

Ordered by cheapness-to-try:

1. **`commandData` layout for `Engine_executeCommand`.** Recoil's `SSkirmishAICallback` ships `Engine_executeCommand` without a topic arg, suggesting it dispatches via commandData's leading field. Candidates: a length-prefixed generic `SCommand` struct, or a type-tagged union distinct from the per-topic structs used by `Engine_handleCommand`. A Recoil-AI example that successfully builds a unit would settle this in minutes.
2. **Unit ownership / team mismatch.** The commander `unit_id=25947` is on team 0, same as our AI's `Game_getMyTeam`. But the engine may reject build orders silently if the AI's *cheat* permissions cover `GiveMe` but not the equivalent of a player-issued unit command. Check whether the BAR ruleset drops AI commands that originate from a team whose "seat kind" is `SEAT_KIND_AI` rather than `SEAT_KIND_PLAYER`.
3. **`BuildPosition.Y` snap.** Still unanswered from 033. `ListMetalSpots` returns `y=168` for this spot, but the engine may require a ground-snapped Y for build orders. The probe used the spot's raw Y unchanged; snapping to `Engine_getElevation(x,z)` is a single-line test.
4. **Command options bitfield.** The diag sends `options = INTERNAL_ORDER (8)`. Try `options=0` or the bitset used by the in-process trainer path. `CmdOptions` is a short, so sweeping is cheap.
5. **`COMMAND_ID_UNTRACKED` vs a real positive id.** 033 chose `-1` based on the "NETMSG_AICOMMAND_TRACKED is silently dropped" note in the original mailbox. If that note was wrong in scope (dropped only for some packet types but not others), a positive `commandId` (e.g., a monotonic per-AI counter) is worth one run.

We suggest running (1) and (2) next; each is a 30-minute empirical test and they cover the bulk of the remaining hypothesis surface.

## Followups

- Feature 035 (or an FSBarV1-driven investigation) should pick up hypothesis (1) or (2). This branch's `specs/034-fix-command-execute/` is the starting material — `research.md` Decision 1 enumerates the probe design, and this mailbox reply records which call signatures have already been eliminated.
- The `T13_ExternalWireDispatch.fs` persistent-test scaffold was **not** shipped — it would anchor the regression gate for a real fix, and should be re-added as part of 035 when a winning dispatch convention exists.
- `T12_BuildPositionY.fs` disposition is **deferred** — leave it as-is on master until hypothesis (3) is tested.
