# Research: Fix Unit Commands

**Feature**: 017-fix-unit-commands
**Date**: 2026-04-04

## Root Cause Analysis

### Decision: Pass `-1` as `commandId` to `Engine_handleCommand`

**Rationale**: The Recoil engine's `SendAICommand` function (in `BaseNetProtocol.cpp:152`) uses the `aiCommandID` parameter to choose the network packet type:

```cpp
const int32_t commandTypeID = (aiCommandID != -1) ? NETMSG_AICOMMAND_TRACKED : NETMSG_AICOMMAND;
```

- `aiCommandID == -1` → `NETMSG_AICOMMAND` (handled by GameServer)
- `aiCommandID != -1` → `NETMSG_AICOMMAND_TRACKED` (**NOT handled by GameServer**)

The GameServer (`GameServer.cpp:1252`) only has `case NETMSG_AICOMMAND:` — there is no `case NETMSG_AICOMMAND_TRACKED:`. The client-side (`NetCommands.cpp:750-751`) handles both, but packets never reach the client because the server drops them.

The `aiCommandID` value originates from the third parameter (`commandId`) passed to `Engine_handleCommand`, which flows through `SSkirmishAICallbackImpl.cpp:1148` → `SetAICmdID(commandId)` → `GetID(true)` → `SendAICommand(..., aiCommandID, ...)`.

**Alternatives considered**:

1. **Patch the Recoil engine to handle `NETMSG_AICOMMAND_TRACKED`**: Violates constitution principle I (Zero Engine Modifications). Also, the tracked command feature appears incomplete/unused in the engine — adding a handler would be speculative.

2. **Use `Engine_executeCommand` API instead**: This uses a `RawCommand` struct which is a different interface. Unnecessary complexity when the fix is a single constant.

3. **Use the C++ AI Wrapper library (like CircuitAI)**: Would add a large C++ dependency and require building against the engine source tree. The wrapper ultimately calls the same `Engine_handleCommand` with the same parameters — the only difference is it passes `-1` as `commandId`.

## Affected Code Paths

### `proxy/src/deserialize.c`

All 35+ calls to `handle_command()` pass `0` as the third argument:
```c
return handle_command(skirmish_ai_id, -1, 0, COMMAND_MOVE_UNIT, &s);
//                                        ^ this must be -1
```

**For unit commands** (MOVE, PATROL, FIGHT, ATTACK, etc.): This is the bug. These commands fall through to the `default:` case in the engine, which calls `GiveOrder()` → `SendAICommand()`, where `commandId = 0` triggers `NETMSG_AICOMMAND_TRACKED`.

**For cheat commands** (GIVE_ME_NEW_UNIT, GIVE_ME, etc.): These are handled synchronously by dedicated cases in the engine's switch and never reach `SendAICommand`. Changing to `-1` has no functional impact but improves consistency.

**For non-network commands** (SEND_TEXT_MESSAGE, DRAW_ADD_POINT, etc.): These call engine functions directly (e.g., `SendTextMsg`, `SetLastMsgPos`) and never reach `SendAICommand`. Same — no impact but consistent.

### `proxy/src/proxy.c`

Direct test code at frame 150 and frame 300 also passes `0`:
```c
g_state->callback->Engine_handleCommand(
    g_state->skirmish_ai_id, -1, 0, COMMAND_MOVE_UNIT, &moveCmd);
```

This debug code should be removed (it was for diagnosing the bug) or updated.

### `clients/fsharp/src/Commands.fs`

The F# client builds protobuf `AICommand` messages. The `commandId` parameter is NOT part of the protobuf protocol — it's hardcoded in the C proxy's `deserialize.c`. No F# changes needed.

## Engine Source References

- `BaseNetProtocol.cpp:140-177` — `SendAICommand()` packet type selection
- `SSkirmishAICallbackImpl.cpp:1143-1160` — `default:` case, `newCommand()` + `GiveOrder()`
- `AISCommands.cpp:463-519` — `newCommand()` struct-to-Command conversion
- `AICallback.cpp:351-371` — `GiveOrder()` validation + network send
- `GameServer.cpp:1252-1270` — `NETMSG_AICOMMAND` handling (no TRACKED case)
- `NetCommands.cpp:750-800` — Client-side handles both AICOMMAND and TRACKED
