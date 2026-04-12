# Quickstart: Fix Five Proxy Issues

**Feature**: 029-fix-trainer-issues
**Date**: 2026-04-12
**Audience**: Developer implementing this feature, or someone reviewing the fix end-to-end.

## Prerequisites

- BAR + spring-headless installed at `~/.local/state/Beyond All Reason/engine/recoil_2025.06.19/`
- HighBarV2 master branch checked out at `/home/developer/projects/HighBarV2`
- Working `cmake`, `protobuf-c`, `buf`, `dotnet 10.0`
- Branch `029-fix-trainer-issues` checked out
- A working knowledge of `tests/run-all.sh` (see CLAUDE.md § Commands)

## Step 1 — Reproduce the bugs

Before fixing anything, confirm each of the five issues fails today.

### Issue 5 — debug log noise

```bash
./tests/run-all.sh --category persistent
ls -la /tmp/highbar-test-*/engine.infolog | awk '{print $5, $9}' | sort -n | tail -3
grep -c "CMD_DETAIL" /tmp/highbar-test-*/engine.infolog | tail -3
```

Expected: infolog files contain hundreds-to-thousands of `CMD_DETAIL case=N enum_move=42` lines.

### Issue 2 — economy callbacks return zero

Write or use a small live-engine probe:

```fsharp
let metal = Callbacks.getEconomyCurrent client.Stream 0
let energy = Callbacks.getEconomyCurrent client.Stream 1
printfn "metal=%f energy=%f" metal energy
```

Run after frame 400 with cheats enabled. Expected: both print `0.000000` regardless of game state.

### Issue 1 — non-Move commands no-op

Add (or use) `tests/persistent/fsharp/T029_NonMoveCommandEffect.fs` per `contracts/command-dispatch.md`. Run:

```bash
./tests/run-all.sh --category persistent --filter T029_NonMoveCommandEffect
```

Expected: `T029.4 AttackCommand actually moves attacker toward target` FAILS with `attacker should have moved >50 elmos, moved 0.0`.

### Issue 3 — no Shutdown on GameOver

```bash
./tests/run-all.sh --category persistent --filter T029_GameOverShutdown
```

Expected: `T029.3 GameOver fires Shutdown to surviving AI` FAILS — bot runs to the 600-frame timeout instead of disconnecting.

### Issue 4 — GiveMe (depends on Issue 2 to verify cleanly)

Skip standalone repro for now. After Issues 2 + 1 are fixed, return here.

## Step 2 — Fix Issue 5 (debug log gate) — quickest win

1. Add `bool verbose_commands;` to `proxy/include/highbar/config.h` `ProxyConfig`.
2. In `proxy/src/config.c` `hb_config_load`, parse the `"verbose_commands"` AIOptions.lua key (default `false`) and overlay env var `HIGHBAR_VERBOSE_COMMANDS`.
3. In `proxy/src/proxy.c` lines 207-245, wrap the entire per-command tracing block in `if (state->config.verbose_commands) { ... }`.
4. Inside the wrapper, **delete** the `CMD_DETAIL case=%d enum_move=%d` `snprintf` block (lines 218-223). The `Cmd N: case=` line already provides the case.
5. In `proxy/src/deserialize.c` line 120-123, **delete** the orphan `fprintf(stderr, "[HB] MOVE uid=...")` — it bypasses the verbosity gate.
6. Document the new flag in `AIOptions.lua` per `data-model.md § 4`.

```bash
cmake --build build && ./tests/run-all.sh --category persistent
ls -la /tmp/highbar-test-*/engine.infolog | tail -3  # files should be <20 MB now
grep -c "CMD_DETAIL" /tmp/highbar-test-*/engine.infolog | tail -3  # should be 0
```

Commit: `fix(proxy): gate per-command tracing behind verbose_commands flag`

## Step 3 — Fix Issue 2 (economy callbacks)

1. Add four switch cases to `proxy/src/callbacks.c` before `default:` at line 457, per `contracts/economy-callbacks.md § API Contract — C proxy`.
2. Add `Economy_getCurrent`, `Economy_getIncome`, `Economy_getUsage`, `Economy_getStorage` stubs to `proxy/tests/mock_engine.{c,h}` with per-resource setters.
3. Add C round-trip tests in `proxy/tests/test_callbacks.c` (metal returns the configured value, invalid id returns NaN).
4. Add F# wrapper update in `clients/fsharp/src/Client.fs` so `Single.NaN` flows through (or add a `tryGet*` variant).
5. Add live test `tests/persistent/fsharp/T029_EconomyCallbacks.fs` per `contracts/economy-callbacks.md § Test Contract`.

```bash
cmake --build build && cd build && ctest --output-on-failure -R economy
cd .. && ./tests/run-all.sh --category persistent --filter T029_EconomyCallbacks
```

Expected: all green. Commit: `fix(proxy): wire ECONOMY_GET_* callbacks to engine Economy_get* functions`

## Step 4 — Fix Issue 3 (GameOver shutdown)

1. Add the `EVENT_RELEASE` branch to `proxy/src/proxy.c` `handleEvent` per `contracts/shutdown-event.md § API Contract — proxy`.
2. Add C unit tests for the new branch (`test_handle_event_release_emits_shutdown`, `..._does_not_double_emit`).
3. Add live test `tests/persistent/fsharp/T029_GameOverShutdown.fs` per `contracts/shutdown-event.md § Test Contract`.

```bash
cmake --build build && cd build && ctest --output-on-failure -R event_release
cd .. && ./tests/run-all.sh --category persistent --filter T029_GameOverShutdown
```

Expected: all green. Bot terminates within ~300 frames of `Spring.GameOver`. Commit: `fix(proxy): emit Shutdown(GAME_OVER) on EVENT_RELEASE for surviving AIs`

## Step 5 — Diagnose and fix Issue 1 (non-Move commands)

This is the longest and riskiest step. Follow the diagnostic procedure in `research.md § Issue 1 § Diagnostic plan`.

### Step 5a — Build the regression baseline

Add `tests/persistent/fsharp/T029_NonMoveCommandEffect.fs` per `contracts/command-dispatch.md § Test Contract`. Run it; confirm `T029.4 AttackCommand actually moves attacker toward target` FAILS. This is the regression baseline — no fix is committed until this test passes.

### Step 5b — Test Hypothesis 1 (groupId)

```bash
# Edit clients/fsharp/src/Commands.fs `AttackCommand` builder:
#   a.GroupId <- -1
cd clients/fsharp && dotnet build && cd ../..
./tests/run-all.sh --category persistent --filter "T029.4 AttackCommand"
```

If the test now PASSES, root cause is `groupId=0` colliding with engine group #0. Apply the fix to all in-scope command builders in `Commands.fs` and the `deserialize.c` cases. Skip steps 5c–5e.

### Step 5c — Test Hypothesis 2 (toId arg)

```bash
# Revert the Commands.fs edit. Edit proxy/src/deserialize.c `case ATTACK`:
#   return handle_command(skirmish_ai_id, c->unit_id, COMMAND_ID_UNTRACKED, COMMAND_ATTACK, &s);
cmake --build build
./tests/run-all.sh --category persistent --filter "T029.4 AttackCommand"
```

If the test now PASSES, root cause is the `toId` arg. Apply uniformly to all in-scope commands in `deserialize.c`. Skip 5d–5e.

### Step 5d — Test Hypothesis 4 (struct layout)

Write a tiny C diagnostic in `proxy/tests/`:

```c
#include "highbar/engine_types.h"
#include <stdio.h>
#include <stddef.h>
int main(void) {
    printf("SAttackUnitCommand: size=%zu, unitId@%zu, groupId@%zu, options@%zu, timeOut@%zu, toAttackUnitId@%zu\n",
        sizeof(struct SAttackUnitCommand),
        offsetof(struct SAttackUnitCommand, unitId),
        offsetof(struct SAttackUnitCommand, groupId),
        offsetof(struct SAttackUnitCommand, options),
        offsetof(struct SAttackUnitCommand, timeOut),
        offsetof(struct SAttackUnitCommand, toAttackUnitId));
    // repeat for SMoveUnitCommand
    return 0;
}
```

Compare offsets between `SMoveUnitCommand` and `SAttackUnitCommand`. If they diverge in unexpected ways (e.g., padding inserted in one but not the other), root cause is struct layout.

### Step 5e — Last resort: Lua diagnostic gadget

If hypotheses 1–4 fail, write a temporary Lua gadget for the test scenario only that intercepts `gadget:AllowCommand(unitID, unitDefID, teamID, cmdID, cmdParams, cmdOptions, ...)` and logs every AI-issued command. Place under `tests/persistent/fsharp/test-gadgets/` and load via the engine's `LuaRules` hook for the test session only. **NEVER commit it as part of BAR's distributable mod files.**

Read the gadget log to see what params the engine actually receives. The discrepancy between what the proxy sends and what the engine reads is the bug.

### Step 5f — Apply the fix and verify

Once root cause is identified, apply the minimal fix. Re-run:

```bash
cmake --build build
./tests/run-all.sh --category persistent --filter T029_NonMoveCommandEffect
```

All six T029.4–T029.9 tests must pass. Also extend `tests/persistent/fsharp/T6_CommandCoverage.fs`'s `T6.11` and similar smoke tests to assert effect (not just survival) so this gap cannot reopen.

Commit: `fix(proxy): <root cause one-liner> so non-Move commands take effect`

## Step 6 — Verify Issue 4 (GiveMe phantom)

With Issues 1 and 2 fixed:

```bash
./tests/run-all.sh --category persistent
```

Or write a quick probe:

```fsharp
engine.ResetGameState()
let beforeMetal = Callbacks.getEconomyCurrent client.Stream 0
client.SendCommand(GiveMeResourceCommand 0 1000.0f) |> ignore
engine.RunFrames(2, fun _ _ -> []) |> ignore
let afterMetal = Callbacks.getEconomyCurrent client.Stream 0
printfn "metal: %f → %f (delta %f)" beforeMetal afterMetal (afterMetal - beforeMetal)
```

If `delta ≈ 1000`, Issue 4 is closed-already-fixed by Issues 1+2. Mark in spec or in the commit message. If `delta ≈ 0`, open a residual investigation.

## Step 7 — Full regression

```bash
./tests/run-all.sh
```

All categories must pass: unit, proxy, integration, persistent. No new failures, no regressions in existing tests.

## Step 8 — Update the trainer workaround

The FSBarV1 `botDeclaredVictory` workaround in `tactics.fsx` can now be deleted (per SC-006). This is a downstream cleanup in the FSBarV1 repo, not in HighBarV2 — file an issue or note in the trainer repo's mailbox.

## Done criteria

- [ ] All five issues have a passing live test (or a documented closure)
- [ ] `./tests/run-all.sh` is fully green
- [ ] `engine.infolog` from a default-verbosity 18000-frame run is < 30 MB (SC-005)
- [ ] A bot using only `AttackCommand` wins a 1v1 match against NullAI in ~12 seconds wall (SC-001)
- [ ] `peak_metal` and `peak_energy` in trainer `result.json` are strictly positive (SC-002)
- [ ] Commit history is clean: one commit per issue, in the order Issue 5 → 2 → 3 → 1 → 4-cleanup
- [ ] Branch is ready for `/speckit.tasks` to generate the formal task list, then `/speckit.implement` to execute
