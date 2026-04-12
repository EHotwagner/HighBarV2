# Research: Proxy Contract Documentation

**Feature**: 030-proxy-contract-docs
**Date**: 2026-04-12

## R1: Shutdown Wire Shape — Source Verification

**Question**: What is the exact wire shape of the Shutdown message? Is it a top-level `ProxyMessage` envelope or embedded inside a Frame?

**Finding**: Shutdown is a **top-level `ProxyMessage` envelope**, confirmed at `proxy/src/proxy.c` lines 382-399:

```c
Highbar__ProxyMessage msg = HIGHBAR__PROXY_MESSAGE__INIT;
msg.message_case = HIGHBAR__PROXY_MESSAGE__MESSAGE_SHUTDOWN;
msg.shutdown = &shutdown;
// ... pack and send via hb_conn_send
```

The handler is in the `EVENT_RELEASE` branch of `handleEvent()` (lines 351-406). After sending the Shutdown envelope, the proxy calls `hb_conn_close()` and sets `conn.connected = false`.

**Message sequencing**: The engine fires `EVENT_RELEASE` after `Spring.GameOver` resolves but before calling `release()`. Between the last `send_frame` and `EVENT_RELEASE`, the engine may process additional frames (observed: 29 frames in FSBarV1's smoke run). During this window, the proxy is NOT emitting further Frame messages because it only sends frames during `handleEvent(EVENT_UPDATE)`, and the engine is processing the game-over sequence. So the Shutdown envelope follows the last Frame with a gap, not immediately.

**Decision**: Document as a standalone top-level `ProxyMessage.Shutdown` envelope, sent after the final Frame, before socket close.

## R2: ShutdownReason Mapping — Source Verification

**Question**: What `SReleaseEvent.reason` values map to what `ShutdownReason` proto enum values?

**Finding**: Confirmed at `proxy/src/proxy.c` lines 358-372:

| `SReleaseEvent.reason` | Engine meaning | Proto `ShutdownReason` |
|---|---|---|
| 1 | Game ended (Spring.GameOver) | `SHUTDOWN_REASON_GAME_OVER` (1) |
| 2 | Team died (allyteam wiped) | `SHUTDOWN_REASON_GAME_OVER` (1) |
| 3 | AI killed (`.kickai` or engine destroy) | `SHUTDOWN_REASON_GAME_OVER` (1) |
| 4 | AI crashed (runtime error) | `SHUTDOWN_REASON_ERROR` (3) |
| 5 | Init failed (AI init returned non-zero) | `SHUTDOWN_REASON_ERROR` (3) |
| 6 | Connection lost (host disconnect) | `SHUTDOWN_REASON_DISCONNECT` (2) |
| Other | Unknown/undocumented | `SHUTDOWN_REASON_UNKNOWN` (0) |

**Note on reason 3**: The proxy maps "AI killed" to `GAME_OVER`, not `ERROR`. This is a deliberate choice — `.kickai` from a host is an operational action, not a crash. Clients that want to distinguish "game naturally ended" from "AI was kicked" cannot do so at the `ShutdownReason` level; they'd need to inspect the infolog.

**Decision**: Document the full mapping table. Note the reason-3 grouping choice explicitly.

## R3: Unwired Command Log Format — Source Verification

**Question**: What is the exact format, output stream, and semantics of the `rc=-2` log line?

**Finding**: Two distinct log paths exist:

### Path 1: `deserialize.c` default branch (line 708-712)
```c
fprintf(stderr,
    "[HB] unsupported command oneof case=%d (proxy switch table miss)\n",
    (int)cmd->command_case);
return HB_DESERIALIZE_RC_UNSUPPORTED;  // -2
```
- **Stream**: stderr (via `fprintf(stderr, ...)`)
- **Format**: `[HB] unsupported command oneof case=%d (proxy switch table miss)`
- **Case value**: Integer protobuf oneof enum value, NOT the string name
- **Always emitted**: Not gated behind `verbose_commands`

### Path 2: `proxy.c` verbose command logging (lines 216, 235-238)
```c
// Before dispatch (verbose_commands only):
snprintf(cmd_dbg, sizeof(cmd_dbg), "Cmd %zu: case=%d", i, (int)c->command_case);
proxy_log(HB_LOG_INFO, cmd_dbg);

// After dispatch (verbose_commands only):
snprintf(rc_buf, sizeof(rc_buf), "Cmd %zu: rc=%d", i, cmd_rc);
proxy_log(HB_LOG_INFO, rc_buf);
```
- **Stream**: Engine infolog (via `proxy_log`)
- **Format**: `Cmd <index>: case=<int>` then `Cmd <index>: rc=<int>`
- **Gated**: Only emitted when `verbose_commands=true`

**Critical finding for FSBarV1**: Their parser greps for `rc=-2` and extracts `case=<name>`. But:
1. The `case=` token in both log paths uses an **integer**, not a string name.
2. The unconditional stderr line uses the format `[HB] unsupported command oneof case=%d`, which has the case value but NOT in the `Cmd N: case=N` format their parser expects.
3. The `Cmd N: case=N` / `Cmd N: rc=-2` format only appears with `verbose_commands=true`, and the case and rc are on **separate lines**, meaning their parser's assumption that `rc=-2` and `case=<name>` are on the same line is wrong.

**Decision**: Document both log paths. Note that the case value is an integer, not a string. Flag the FSBarV1 parser assumptions in the mailbox response.

## R4: AttackCommand Dispatch — Source Verification

**Question**: Is AttackCommand wired? What could explain the stationary-unit behavior?

**Finding**: AttackCommand is fully wired at `proxy/src/deserialize.c` lines 149-158:

```c
case HIGHBAR__AICOMMAND__COMMAND_ATTACK: {
    const Highbar__AttackCommand *c = cmd->attack;
    struct SAttackUnitCommand s;
    memset(&s, 0, sizeof(s));
    s.unitId = c->unit_id;
    s.groupId = c->group_id;
    s.options = (short)c->options;
    s.timeOut = c->timeout;
    s.toAttackUnitId = c->target_unit_id;
    return handle_command(skirmish_ai_id, -1, COMMAND_ID_UNTRACKED, COMMAND_ATTACK, &s);
}
```

The command maps to `COMMAND_ATTACK` with `COMMAND_ID_UNTRACKED` (-1). The engine callback `Engine_handleCommand` is invoked.

**Possible explanations for stationary behavior** (from proxy side):
1. **`options=0` issue**: `memset` zeros the struct, so `options=0` unless the client sends a non-zero value. The engine may interpret `options=0` differently from `options=8` (which includes `UNIT_COMMAND_OPTION_SHIFT_KEY` or other flags). FSBarV1's probe log mentions `options=8` in the 029 contract doc test spec, but we don't know what their actual probe used.
2. **`groupId=0` vs `-1`**: The struct is zeroed, so `groupId=0` unless set. The engine may require `groupId=-1` for individual unit commands (this was identified as a hypothesis in 029's command-dispatch contract). However, the 029 fix was merged and this should be resolved.
3. **30-frame observation window**: FSBarV1's probe checked `pos_before` and `pos_after` over a short window. If the unit's pathfinding hadn't started or the target was unreachable, the unit might not have moved yet.
4. **Target out of LOS**: The engine may silently ignore attack commands targeting units not in the AI's line-of-sight.

**Decision**: A verbose-mode run with `verbose_commands=true` would show the engine's return code for the AttackCommand. If `rc=0`, the engine accepted the command and the issue is game-logic (pathing, LOS, timing). If `rc!=0`, the engine rejected it. Recommend this in the mailbox response, along with a suggested probe shape that uses a longer observation window (600+ frames) and a nearby visible target.

## R5: Proto Schema Reference

**Question**: What are the exact proto definitions for Shutdown-related messages?

**Finding**: From `proto/highbar/messages.proto` lines 78-87:

```protobuf
message Shutdown {
  ShutdownReason reason = 1;
}

enum ShutdownReason {
  SHUTDOWN_REASON_UNKNOWN = 0;
  SHUTDOWN_REASON_GAME_OVER = 1;
  SHUTDOWN_REASON_DISCONNECT = 2;
  SHUTDOWN_REASON_ERROR = 3;
}
```

And `Shutdown` is a case in the `ProxyMessage.message` oneof (verified in the generated C code and proxy source).

**Decision**: Include the proto definitions verbatim in the contract document for reference.
