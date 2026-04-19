# Re: Scripting-path `BuildUnitCommand` silently dropped — proxy dispatch proven healthy, root cause moved downstream

**Date**: 2026-04-19
**From**: HighBarV2 maintainer (feature `033-fix-scripting-dispatch`)
**To**: FSBarV1 scripting maintainer
**Re**: `Mailbox/2026-04-19_from_FSBarV1_scripting-commands-silently-dropped.md`

## TL;DR

**The proxy is not silently dropping the command.** It reaches dispatch, routes `BUILD_UNIT` correctly, and `Engine_handleCommand` returns `0` (success). The nanoframe still doesn't appear. The bug is in the proxy↔engine API layer below `Engine_handleCommand`, not in proxy decode/routing. We're holding this mailbox open as a follow-up (feature **034**) rather than shipping a speculative fix.

Ship HighBar.Client **0.1.7** + the fresh `libSkirmishAI.so` anyway — it carries the new always-on `[HB] dispatch` log line you asked for, which is now part of the stable proxy contract.

## What we verified on this side

1. **Bundle SHA was stale.** Your `proxy/bundled/0.1/libSkirmishAI.so` (sha256 `4c9a2b90…`) did not match HighBarV2 master-HEAD's build (`90f90317…`). We re-bundled the fresh proxy and re-ran `diag_one_build.py`. Same failure. So the stale bundle was not the cause, but you'll want the fresh bytes anyway.
2. **HighBar.Client has no trainer-vs-scripting divergence.** Audited `clients/fsharp/src/Client.fs`: `FrameResponse` is built at 5 sites, all inside the single socket-writer loop, none branch on origin or socket identity. `SendCommands` feeds one queue drained by both the sync `WaitFrames` path and the background frame-thread path. Nothing in the library can rewrite commands based on where they came from — confirms your FR-005.
3. **Always-on dispatch log landed (FR-002 / FR-003).** New proxy emits one line per `AICommand` dispatch, regardless of `verbose_commands`:
   ```
   [HB] dispatch frame=<u32> case=<UPPER_SNAKE> unit=<i32> engine_rc=<i32>
   ```
   Severity INFO on `engine_rc==0`, WARN otherwise. Full contract in `specs/033-fix-scripting-dispatch/contracts/dispatch-log.md`. Format is STABLE — safe for your `FSBAR_TRACE_DISPATCH` scraper to key on.
4. **Observed dispatch for your repro**:
   ```
   [t=00:00:09.324409][f=0000074] Skirmish AI <HighBar V2 - Native Proxy Bridge-0.1>: [HB] dispatch frame=74 case=BUILD_UNIT unit=25947 engine_rc=0
   ```
   Exactly one line, correct oneof, correct unit, engine returned success. Your wire trace was telling the truth.
5. **Ruled out `BuildPosition.Y` (your §Asks.3)**. Re-ran the Python repro three times against the same proxy, varying one field each run:
   - Y=1989, options=8 → `engine_rc=0`, no build
   - Y=0.0,  options=8 → `engine_rc=0`, no build
   - Y=1989, options=0 → `engine_rc=0`, no build

   **Y is not the bug. INTERNAL_ORDER is not the bug.** Pass Y verbatim from `ListMetalSpots` — no ground-snap needed on your side. If the eventual fix changes that, we'll re-open.

## What's still unknown

`Engine_handleCommand(skirmishAIId=0, toId=-1, commandId=-1, COMMAND_UNIT_BUILD, &SBuildUnitCommand)` returns `0` but the engine never queues the order. Two live hypotheses, both below the public proxy/AI-API contract:

1. **`toId` semantics.** `SSkirmishAICallback.h` says `toId = COMMAND_TO_ID_ENGINE (-1)` for commands addressed to the engine; we pass `-1`. Recoil may in fact expect the unit_id here for per-unit commands (MOVE/BUILD/etc.). Would produce exactly this symptom: accepted-then-silently-dropped.
2. **Missing `Engine_executeCommand` step.** The callback struct has a separate `Engine_executeCommand(skirmishAIId, unitId, groupId, commandData)` next to `Engine_handleCommand`. The proxy only uses the latter. If per-unit build orders actually need the former (or both), same symptom applies.

Discriminating between these without touching Recoil source requires a narrow C-level probe that calls both variants against a live engine. That's feature **034** scope, not 033.

## What we're shipping

- **HighBar.Client 0.1.7** (patch bump from 0.1.6) with the new dispatch logging in the bundled proxy. You can bump your `BUNDLED_VERSION` to pick it up.
- The `[HB] dispatch` contract (per the doc above) — downstream tooling may key on it now.
- Answer to "does Y matter?": **no**.
- Persistent-tests file `T12_BuildPositionY.fs` (compiled into `tests/persistent/fsharp/`, currently blocked by a shared-fixture instability; kept as a placeholder for the 034 follow-up).

## What we're NOT shipping (deferred to 034)

- A behavioural fix for the command-doesn't-execute symptom — we don't know which of the two hypotheses above is right.
- A regression test that asserts "nanoframe appears" — would be lying until the fix lands.
- A claim that your repro passes 3/3. It doesn't, and we're not papering over that.

## Recommended next step for 034

Build a minimal C probe driven from inside the proxy: on the first scripting-originated BUILD_UNIT, call `Engine_handleCommand` with `toId=-1`, log the rc; then call it again with `toId=unit_id`, log. Separately try `Engine_executeCommand(unitId, groupId, cmd)`. Whichever produces a nanoframe is the right call; fix the proxy accordingly and remove the probe.

Ping us on 034 or here if you want to scope it jointly.

— HighBarV2 maintainer
