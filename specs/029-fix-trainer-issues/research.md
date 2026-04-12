# Research: Fix Five Proxy Issues from FSBarV1 Trainer Session

**Feature**: 029-fix-trainer-issues
**Date**: 2026-04-12
**Related history**: feature 017-fix-unit-commands (squashed merge `dce4e42`) is the prior fix that made `MoveCommand` work end-to-end. That fix solved the `commandId` parameter (`-1` for untracked → routes through GameServer's `NETMSG_AICOMMAND` handler) but only verified its effect for `MoveCommand`. T008 in `017/tasks.md` ("Install proxy to BAR and verify unit commands work in a live game") was never checked off, and the live test `T6.11 AttackCommand` in `tests/persistent/fsharp/T6_CommandCoverage.fs:269-290` only asserts the engine survives the command — it does NOT assert that the attacker moved or that the target's health decreased. The FSBarV1 trainer is the first observation that `Attack/Fight/Patrol/etc.` are silently no-op despite the 017 fix.

---

## Issue 2 — Economy callbacks return 0.0f

### Decision: Add four switch cases in `proxy/src/callbacks.c` calling `callback->Economy_get*`

### Root cause

`proxy/src/callbacks.c:154-462` has the `hb_callback_dispatch` switch. It has cases for Game/Map/Unit/UnitDef callbacks but **zero cases for `CALLBACK_ECONOMY_GET_*`**. Requests for callback IDs 61–64 fall through to the `default:` at line 457:

```c
default:
    return make_error_response(req_id, "Unknown callback ID", alloc);
```

The F# client at `clients/fsharp/src/Client.fs:400-433` sees `success=false` and silently maps it to `0.0f` in the fallback branch:

```fsharp
if resp.Success && ... ValueOneofCase.FloatValue then resp.Result.FloatValue
else 0.0f
```

That is exactly the symptom in the FSBarV1 findings: always 0.0, no exception.

### Engine API

`proxy/include/AI/SSkirmishAICallback.h:454-470` defines:

| Line | Function | Signature |
|---|---|---|
| 454 | `Economy_getCurrent` | `float (int skirmishAIId, int resourceId)` |
| 456 | `Economy_getIncome` | `float (int skirmishAIId, int resourceId)` |
| 458 | `Economy_getUsage` | `float (int skirmishAIId, int resourceId)` |
| 460 | `Economy_getStorage` | `float (int skirmishAIId, int resourceId)` |

`resourceId`: `0=metal`, `1=energy`. All return `float`.

### Proto schema impact

None. `proto/highbar/callbacks.proto:109-112` already declares the four enum values. The generic `CallbackResult.float_value` oneof case is what the F# client decodes via `ValueOneofCase.FloatValue`. The existing helper `make_float_response` (`callbacks.c:25-40`) builds exactly that shape. **No `buf generate`, no proto edits.**

### Invalid resource id (US2 acceptance #4)

The clarifications say proto changes ARE permitted now. Two equivalent options:

- **Option A — NaN sentinel via `make_float_response`**: zero proto change. `callback->Economy_getCurrent(skirmishAIId, 99)` likely already returns 0 or NaN itself; if not, the proxy can detect `resourceId < 0 || resourceId > 1` and respond `make_float_response(req_id, NAN, alloc)`. The F# client checks `Single.IsNaN` to distinguish.
- **Option B — `make_error_response`**: out-of-range ids fall through to the existing error path. The F# fallback already returns `0.0f` for `success=false`, so this is the SAME silent-zero failure mode the bug is about — bad UX without an F# client change.

**Decision**: Option A (NaN sentinel) for callbacks.c. The F# client (`Client.fs:400-433`) gets a tiny patch: add a `Single.IsNaN(resp.Result.FloatValue)` check that surfaces an explicit `Single.NaN` to callers, and the bot can `if Single.IsNaN x then ...`. No proto change.

### Alternatives considered & rejected

- **Add a typed `EconomyResponse` message** (proto edit). Rejected: every other callback returns via the generic `CallbackResult` oneof, so introducing a typed response just for economy is inconsistent and forces an `if oneof case == FloatValue else if oneof case == EconomyResponse` branch on the client.
- **Have the F# client throw on `success=false`**. Rejected: would regress every other callsite that today silently tolerates an unknown-callback response. Out of scope for this feature.

### Estimated change

- `proxy/src/callbacks.c`: +4 cases (~24 lines), inserted before `default:` at line 457.
- `clients/fsharp/src/Client.fs`: +1 NaN-aware branch in the economy callback wrappers (~6 lines).
- Proto: no change.

---

## Issue 3 — No Shutdown event when surviving team's enemy dies (`Spring.GameOver`)

### Decision: Add an `EVENT_RELEASE` branch to `handleEvent` in `proxy/src/proxy.c`

### Root cause

`proxy/include/AI/AISEvents.h:31-58` lists every Skirmish AI event topic. There is no `EVENT_GAME_OVER`. The relevant topic is **`EVENT_RELEASE = 2`** with the `SReleaseEvent.reason` field documented at lines 104-120:

```c
/* reason values:
 * 0: unspecified
 * 1: game ended       <-- Spring.GameOver path; sent to ALL surviving AIs
 * 2: team died        <-- only the killed team's AI
 * 3: AI killed
 * 4: AI crashed
 * 5: AI failed to init
 * 6: connection lost
 * 7: other reason
 */
struct SReleaseEvent { int reason; };
```

`proxy/include/AI/SSkirmishAILibrary.h:167-195` documents the call ordering: the engine fires `handleEvent(EVENT_RELEASE, ReleaseEvent(reason))` BEFORE calling the top-level `release(skirmishAIId)` library export. Both fire for every AI instance at game end, including survivors. The `release()` export already sends a `Highbar__Shutdown` (proxy.c lines 315-342) with `SHUTDOWN_REASON_GAME_OVER` — but only when the engine eventually tears down the AI on autoquit, which the FSBarV1 findings show happens too late (the bot hits its frame limit first).

### The bug

`proxy/src/proxy.c` `handleEvent` (around lines 346-448) special-cases `EVENT_UPDATE`, `EVENT_SAVE`, `EVENT_LOAD`, but has **no `EVENT_RELEASE` branch**. It falls through to `hb_serialize_event(topicId, data, ...)`, which serializes the event topic generically — apparently without producing any client-visible terminal signal. The surviving AI's external bot keeps reading frames.

### Fix

Add an `EVENT_RELEASE` branch in `handleEvent` adjacent to the existing `EVENT_SAVE`/`EVENT_LOAD` branches that:

1. Casts `data` to `const struct SReleaseEvent*` and reads `reason`.
2. Maps `reason` to `Highbar__ShutdownReason`:
    - `1 → SHUTDOWN_REASON_GAME_OVER`
    - `2,3,4 → SHUTDOWN_REASON_GAME_OVER` (still terminal — bot just needs to stop; could expose finer mapping later)
    - `0,5,6,7 → SHUTDOWN_REASON_UNKNOWN`
3. Builds and sends a `Highbar__ProxyMessage` with `MESSAGE_SHUTDOWN`, exactly as `release()` already does at lines 320-336.
4. Calls `hb_conn_close(&g_state->conn)` so the bot's next `receiveFrame` observes EOF and the existing `EngineDisconnectedException` path (per clarification Q5) terminates the loop.
5. Sets `g_state->conn.connected = false` so subsequent `handleEvent` calls (the engine may still call a few more before `release()`) become no-ops via the existing guard at line 348.

### Proto schema impact

Possibly none. `proto/highbar/messages.proto:79-86` already has:
```
SHUTDOWN_REASON_UNKNOWN = 0;
SHUTDOWN_REASON_GAME_OVER = 1;
SHUTDOWN_REASON_DISCONNECT = 2;
SHUTDOWN_REASON_ERROR = 3;
```

Optional follow-up: add `SHUTDOWN_REASON_TEAM_DIED = 4` and `SHUTDOWN_REASON_AI_KILLED = 5` so the bot can tell game-over from being-killed. Not required for the spec's acceptance criteria; deferred unless quickstart finds a need.

### Alternatives considered & rejected

- **Poll `Game_getRulesParamFloat(skirmishAIId, "GameOver", -1)` per frame**: requires per-frame polling on the hot path, depends on a BAR-specific Lua key, and fires strictly later than `EVENT_RELEASE`.
- **Listen for `EVENT_LUA_MESSAGE = 27` with a `gameOver` payload**: would require BAR's `game_end.lua` to broadcast such a message, which it currently does not. Adding BAR-side coupling is out of scope.
- **Assume the engine eventually calls `release()` and rely on existing path**: this IS what happens today, but `<autoquit>` adds 12+ seconds and the bot hits its own frame limit first. The findings document confirms this is too late.

### Estimated change

- `proxy/src/proxy.c`: +1 branch in `handleEvent` (~30 lines including the message construction).
- Proto: 0 lines (or +2 enum values if we want finer reason mapping — deferred).

---

## Issue 5 — Misleading `CMD_DETAIL enum_move=42` debug log

### Decision: Gate per-command tracing behind a `verbose_commands` config flag (default OFF) and remove the misleading `enum_move` field

### Root cause

`proxy/src/proxy.c:218-223` unconditionally emits:

```c
char any_dbg[128];
snprintf(any_dbg, sizeof(any_dbg), "CMD_DETAIL case=%d enum_move=%d",
    (int)c->command_case, (int)HIGHBAR__AICOMMAND__COMMAND_MOVE_UNIT);
proxy_log(HB_LOG_INFO, any_dbg);
```

`HIGHBAR__AICOMMAND__COMMAND_MOVE_UNIT` is a compile-time constant `42`, hardcoded as the second `%d`. So every line reads `enum_move=42` regardless of the actual command. Bot authors reading the infolog reasonably interpret `enum_move=42` as "this command was dispatched as MOVE", which is wrong.

In addition to the misleading field, every command also produces:
- `Cmd N: case=K` (line 215)
- `MOVE uid=...` for MoveUnit (lines 224-235) and a leftover `[HB] MOVE uid=...` from `deserialize.c:120-123` written via `fprintf(stderr, ...)`.
- `Cmd N: rc=K` (line 242)

That's 3-4 lines per command at minimum, every frame. At 60-70 MB infolog per 18000-frame run, this is the dominant noise source.

### Fix

1. Add a `verbose_commands` boolean to `ProxyConfig` (in `proxy/src/config.c` and `proxy/include/highbar/config.h`), defaulting to `false`. Set via `AIOptions.lua` key `verbose_commands` and env var `HIGHBAR_VERBOSE_COMMANDS=1` (consistent with the existing `Explicit Over Implicit` constitution principle).
2. Wrap `proxy.c:208-245` per-command tracing (the `Executing N commands`, `Cmd N: case=`, `CMD_DETAIL`, `MOVE uid=`, `Cmd N: rc=`) behind `if (state->config.verbose_commands)`.
3. Inside the wrapper, delete the `CMD_DETAIL` line entirely (it adds nothing the `Cmd N: case=` line doesn't already say). The `MOVE uid=...` line is useful when debugging movement and stays inside the verbose block.
4. Remove the orphan `fprintf(stderr, "[HB] MOVE uid=...")` at `deserialize.c:120-123` — it bypasses the verbosity gate and dumps to stderr. Replace with nothing; the proxy.c wrapper already prints the same data.

### Proto schema impact

None.

### Estimated change

- `proxy/include/highbar/config.h` (or `config.c`): +1 field.
- `proxy/src/config.c`: +2 lines to read the key.
- `proxy/src/proxy.c`: wrap ~30 lines in an `if`. Delete one `snprintf` block.
- `proxy/src/deserialize.c`: delete the stderr `fprintf`.

---

## Issue 1 — Only `MoveUnit` actually moves a unit (Fight/Attack/Patrol no-op)

### Decision: NEEDS DIAGNOSTIC RESOLUTION — root cause not yet known from headers alone

### What is known

- `proxy/src/deserialize.c` dispatches every in-scope command type (Move, Fight, Attack, Patrol, Guard, Repair, ReclaimUnit, Stop, SetWantedMaxSpeed, SelfDestruct, Build, GiveMe, GiveMeNewUnit) through the same code path: `handle_command(skirmish_ai_id, -1, COMMAND_ID_UNTRACKED, COMMAND_<TYPE>, &s)`. Every call passes `toId=-1`, `commandId=-1`, struct on the stack.
- The structs `SMoveUnitCommand`, `SFightUnitCommand`, `SAttackUnitCommand`, `SPatrolUnitCommand` (`AISCommands.h:751-820`) have **identical layouts** for the unit-id-bearing prefix: `int unitId; int groupId; short options; int timeOut;`. They differ only in the trailing payload (`toPos_posF3` vs `toAttackUnitId`).
- The F# client (`clients/fsharp/src/Commands.fs:18-117`) builds protobuf messages identically across these command types: same `INTERNAL_ORDER` flag (8), same `Timeout = MAX_INT`, same `unit_id` set explicitly. So the protobuf wire format is symmetrical.
- The 017-fix-unit-commands feature applied the `commandId=-1` fix uniformly to all 35+ `handle_command` calls. The fix is present and correct in current `master`.
- Live test `T6.11` (`tests/persistent/fsharp/T6_CommandCoverage.fs:269-290`) only asserts the engine survives an AttackCommand (`Assert.True(frames.Length >= 30, "Engine should survive AttackCommand")`). It does NOT poll the attacker's position or the target's health. So nobody has actually verified Attack moves a unit until the FSBarV1 trainer ran on 2026-04-12.
- The Recoil engine source is **not available locally** (only the headless binary at `~/.local/state/Beyond All Reason/engine/recoil_2025.06.19/`), so the internal `SSkirmishAICallbackImpl::handleCommand_default` and `AISCommands.cpp:newCommand` implementations cannot be inspected directly. The 017 research has the prior cited line numbers but those refer to the engine source tree.

### Hypotheses (in order of likelihood)

1. **`groupId` mismatch.** F# client emits `groupId=0` (proto3 default — never set explicitly in `Commands.fs`). The engine may interpret `groupId=0` as "unit group #0" rather than "no group", and dispatch the Command into a non-existent group queue that silently swallows it. MOVE may bypass this path. **Test**: send the same `AttackCommand` with `groupId=-1` and observe.
2. **`Engine_handleCommand`'s `toId` arg is the unit ID for SOME command types.** The header doc says `toId` is the unit ID; the proxy passes `-1` (broadcast) for all. Move may have a struct-internal fallback that the other handlers don't. **Test**: pass `s.unitId` as the `toId` arg for one command type and observe.
3. **`Engine_handleCommand` requires the engine-side `Spring.GiveOrderToUnit` semantics**, which need a unit selection mask the AI hasn't set. Cheats-enabled mode should bypass this; the proxy already calls `Cheats_setEnabled(true)`. **Test**: confirm the cheats flag is still set when `AttackCommand` reaches the engine.
4. **The `SAttackUnitCommand.toAttackUnitId` field is being read from the wrong offset.** The proto F# `target_unit_id` field maps to `s.toAttackUnitId`, and the deserialize.c code at line 156 sets it correctly. But if the proxy is built against a stale `AISCommands.h` whose struct layout doesn't match the engine's runtime ABI, the engine reads garbage. The trainer's commander commander-id `25947` is in the field where the engine expects `toPos_posF3->x` (a float pointer). **Test**: print the struct layout sizes from the proxy at runtime and compare to engine ABI sizes.
5. **Spring's network message format for AICOMMAND drops `params[]` payloads above a certain length** for command topics not in a whitelist. **Test**: inspect raw NETMSG_AICOMMAND bytes via `tcpdump`-style on the engine's loopback or via engine debug logging.

### Diagnostic plan (to be executed during the implementation phase)

The plan must include a **diagnostic spike** before any fix is committed:

1. **Step 1 — Build a focused live test** in `tests/persistent/fsharp/` (e.g., `T029_NonMoveCommandEffect.fs`) that:
    - Spawns a known-mobile unit at position A.
    - Issues `AttackCommand uid targetId` against a freshly spawned dummy target at position B (within attack range).
    - Polls `getUnitPos(uid)` every frame for 600 frames.
    - Asserts position changes by at least 50 elmos AND target's health decreases.
    - Repeats for `FightCommand`, `PatrolCommand`, `GuardCommand`, `RepairCommand`, `StopCommand` (with unit pre-set in motion).
2. **Step 2 — Confirm the failure mode** by running the test and comparing the engine `infolog.txt` lines before and after each command. Note whether the engine emits any `[GiveOrder]`, `[Sim::Cmd]`, or similar trace lines.
3. **Step 3 — Test Hypothesis 1 (groupId)** by patching `clients/fsharp/src/Commands.fs` to set `m.GroupId <- -1` for one non-Move command type, rebuilding, and re-running the test. If the unit responds, root cause is groupId.
4. **Step 4 — If H1 fails, test Hypothesis 2 (toId)** by patching `proxy/src/deserialize.c` `case ATTACK` to call `handle_command(skirmish_ai_id, c->unit_id, COMMAND_ID_UNTRACKED, COMMAND_ATTACK, &s)`. Rebuild, re-run.
5. **Step 5 — If H2 fails, test Hypothesis 4 (struct layout)** by writing a tiny C program that prints `sizeof(struct SAttackUnitCommand)` and offsetof for each field, comparing to the proxy's deserialize code's assumed offsets.
6. **Step 6 — If all four hypotheses fail**, escalate by patching a Lua `gadget` into BAR's mod that intercepts `gadget:AllowCommand` and logs every AI-issued command with full param dump. Re-run the trainer scenario once and read what the engine actually receives. (This violates "Zero Engine Modifications" if treated as a permanent patch, but a temporary diagnostic gadget loaded only in the test scenario is acceptable.)

### Once root cause is known

The fix is most likely a 1-line change in `deserialize.c` (groupId or toId) that applies uniformly to all 12 in-scope command types. If the fix is per-command-type (e.g., struct layout drift), the change is larger but still local to deserialize.c.

### Estimated change

Unknown until diagnostic completes. Bracket: 1 line (groupId/toId fix) to ~50 lines (per-command struct layout corrections).

---

## Issue 4 — `GiveMe` cheat command has no effect

### Decision: Re-test after Issue 2 lands; no separate fix anticipated unless retest fails

### Reasoning

The FSBarV1 findings explicitly note: "This could be a consequence of Issue 2 (the economy is actually updated but the query is broken) — we did NOT rule that out this session." Once `getEconomyCurrent` returns real values (Issue 2 fixed), re-running `client.Reset()` and observing the metal/energy delta will tell us whether `GiveMeCommand` actually reaches the engine.

`COMMAND_CHEATS_GIVE_ME_RESOURCE = 20` is dispatched in `deserialize.c:469-475` through the same `handle_command` path as the broken Fight/Attack commands. So the GiveMe symptom may actually be a consequence of either Issue 1 OR Issue 2 — the fix order matters:

1. Fix Issue 2 first (cheap, well understood).
2. Diagnose and fix Issue 1.
3. Re-test GiveMe in a live scenario:
   - Read `getEconomyCurrent(0)`.
   - Send `GiveMeResourceCommand 0 1000.0f`.
   - Read `getEconomyCurrent(0)` again on the next frame.
4. If the delta is ~+1000, GiveMe was always working and the original symptom was caused by Issue 2 alone. Mark Issue 4 closed-already-fixed.
5. If the delta is 0, GiveMe is genuinely broken at the proxy/engine boundary. Treat as a separate diagnostic spike (probably the same root cause as Issue 1, since both go through `handle_command`).

### Estimated change

0 lines if Issue 4 is a phantom of Issue 2. Otherwise inherits Issue 1's fix.

---

## Cross-cutting decisions

### Test harness

All four issues (1, 2, 3, 5) are verifiable via the existing `tests/persistent/fsharp/` harness against `spring-headless` from `~/.local/state/Beyond All Reason/engine/recoil_2025.06.19/`. The 028-adapt-test-harness feature (recently merged) provides the session/process-management infrastructure. New live tests for this feature go in `tests/persistent/fsharp/` and are exercised via `./tests/run-all.sh --category persistent`.

### Constitution alignment

| Principle | Compliance |
|---|---|
| I. Zero Engine Modifications | ✅ All fixes are in C proxy + F# client + proto. No engine source patches. (Diagnostic gadget in step 6 of Issue 1 plan is temporary and scenario-local.) |
| II. Binary Protocol First | ✅ Protobuf-only. The optional NaN sentinel is in-band on the existing float wire type. |
| III. Correctness Over Cleverness | ✅ Each fix is a direct mapping to the documented engine API. No clever transformations. |
| IV. Test at the Boundary | ✅ All fixes get round-trip tests (mock engine, C proxy tests) AND live-engine assertions in `tests/persistent/`. |
| V. Latency Budget Discipline | ✅ Adding 4 economy callback cases and 1 EVENT_RELEASE branch is O(constant) work, well within the 1ms hot-path budget. The verbose_commands gate REDUCES default-mode latency by removing per-command snprintf. |
| VI. Language-Agnostic by Default | ✅ No F#-specific protocol behavior. The NaN sentinel is reproducible in any client language. |
| VII. Explicit Over Implicit | ✅ The new `verbose_commands` config flag is explicit, defaults to OFF, documented in `AIOptions.lua`, env-overridable. |

### Commit ordering

Issues are independent at the file level except (4 ⇐ 2) and (4 ⇐ 1). Suggested commit order:

1. Issue 5 (debug log gate) — smallest, no functional risk.
2. Issue 2 (economy callbacks) — small, well understood, unblocks Issue 4 testing.
3. Issue 3 (GameOver shutdown) — small, well understood, removes biggest trainer wart.
4. Issue 1 diagnostic + fix — bulk of the work and risk.
5. Issue 4 retest — likely a no-op closure once 1+2 land.
