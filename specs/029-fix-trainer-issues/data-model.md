# Data Model: Fix Five Proxy Issues

**Feature**: 029-fix-trainer-issues
**Date**: 2026-04-12

This feature does not introduce new persistent data entities. The "data model" is the set of protobuf messages and engine structs that cross the proxy ↔ client boundary, and the configuration surface that controls proxy behavior. Three categories are touched:

## 1. Engine command structs (read-only reference)

These structs are defined in `proxy/include/AI/AISCommands.h` and read by the proxy's `deserialize.c` to fill the `commandData` argument to `Engine_handleCommand`. **No changes to these structs** — they belong to the engine ABI. Listed here for the in-scope FR-002 set so the Issue 1 diagnostic and fix can reference them.

| Engine struct | Engine topic | Proto oneof case | Header line |
|---|---|---|---|
| `SMoveUnitCommand` | `COMMAND_UNIT_MOVE` (42) | `move_unit` | AISCommands.h:751 |
| `SFightUnitCommand` | `COMMAND_UNIT_FIGHT` (44) | `fight` | AISCommands.h:787 |
| `SAttackUnitCommand` | `COMMAND_UNIT_ATTACK` (45) | `attack` | AISCommands.h:805 |
| `SPatrolUnitCommand` | `COMMAND_UNIT_PATROL` (43) | `patrol` | AISCommands.h:769 |
| `SGuardUnitCommand` | `COMMAND_UNIT_GUARD` (47) | `guard` | AISCommands.h |
| `SRepairUnitCommand` | `COMMAND_UNIT_REPAIR` (51) | `repair` | AISCommands.h |
| `SReclaimUnitUnitCommand` | `COMMAND_UNIT_RECLAIM_UNIT` (63) | `reclaim_unit` | AISCommands.h |
| `SStopUnitCommand` | `COMMAND_UNIT_STOP` (36) | `stop` | AISCommands.h:611 |
| ~~`SSetWantedMaxSpeedCommand` (stub)~~ | ~~`COMMAND_UNIT_SET_WANTED_MAX_SPEED` (56)~~ | ~~`set_wanted_max_speed`~~ | ~~engine_types.h:163~~ — **EXCLUDED per FR-002 update; engine marks unused, falls under FR-003 (rc=-2)** |
| `SSelfDestroyUnitCommand` | `COMMAND_UNIT_SELF_DESTROY` (55) | `self_destruct` | AISCommands.h |
| `SBuildUnitCommand` | `COMMAND_UNIT_BUILD` (35) | `build_unit` | AISCommands.h:590 |
| `SGiveMeResourceCheatCommand` | `COMMAND_CHEATS_GIVE_ME_RESOURCE` (20) | `give_me` | AISCommands.h:281 |
| `SGiveMeNewUnitCheatCommand` | `COMMAND_CHEATS_GIVE_ME_NEW_UNIT` (79) | `give_me_new_unit` | AISCommands.h:290 |

**Common prefix** for all `S*UnitCommand` structs: `int unitId; int groupId; short options; int timeOut;` followed by command-specific payload. The Issue 1 diagnostic must verify that each in-scope struct is being filled with values that the engine accepts (`unitId` valid, `groupId` non-collision, `options` containing the correct flags).

**Engine call signature**: `int Engine_handleCommand(int skirmishAIId, int toId, int commandId, int commandTopic, void* commandData)` (`SSkirmishAICallback.h:49`). The proxy currently passes `(skirmish_ai_id, -1, COMMAND_ID_UNTRACKED=-1, COMMAND_<TYPE>, &s)` for every command. The Issue 1 fix MAY change one of the `-1` arguments per the diagnostic outcome.

## 2. Economy callback wire shape (US2)

### Existing protobuf surface (no schema change)

`proto/highbar/callbacks.proto` already declares all four enum values:

```proto
// Resource / Economy
CALLBACK_ECONOMY_GET_CURRENT = 61;
CALLBACK_ECONOMY_GET_INCOME  = 62;
CALLBACK_ECONOMY_GET_USAGE   = 63;
CALLBACK_ECONOMY_GET_STORAGE = 64;
```

The response message is the existing generic `CallbackResponse` containing a `CallbackResult` oneof. The relevant case is:

```proto
oneof value {
  ...
  float float_value = X;
  ...
}
```

The proxy helper `make_float_response(req_id, value, alloc)` (`callbacks.c:25-40`) already constructs that exact shape.

### Request parameters

The `CallbackRequest` message carries an integer parameter list. For economy callbacks, the proxy reads `resourceId` via the existing helper `get_int_param(request, 0, 0)` (already used at `callbacks.c:278` and `:341` for similar callbacks). Resource ids: `0 = metal`, `1 = energy`. Any other value triggers the NaN sentinel.

### Sentinel for invalid `resourceId` (FR-008)

The clarifications permit proto schema changes, but for this case the simpler in-band sentinel is preferred:

- **Wire**: `CallbackResult.float_value = NaN` (IEEE 754 quiet NaN, encoded normally as a 32-bit float).
- **Proxy emission**: when `resourceId < 0 || resourceId > 1`, the proxy returns `make_float_response(req_id, NAN, alloc)` instead of calling the engine. (If the engine itself returns NaN for an unknown id, the proxy can also pass it through unchanged.)
- **F# decode**: `Client.fs` economy wrappers add a `Single.IsNaN` check around the result and surface it to callers as `Single.NaN` (or `ValueOption<float32>.None` if the wrapper signature changes — see `contracts/economy-callbacks.md`).

### Why not a typed `EconomyResponse` message?

Every other callback in the proxy returns via the generic `CallbackResult` oneof. Adding a typed response message just for economy would force `if oneof case == FloatValue else if oneof case == EconomyResponse` branching on the client side and break uniformity. Deferred unless a future feature actually needs structured economy data (e.g., per-resource breakdown).

## 3. Shutdown event (US3)

### Existing protobuf surface (no schema change required)

`proto/highbar/messages.proto:79-86`:

```proto
enum ShutdownReason {
  SHUTDOWN_REASON_UNKNOWN    = 0;
  SHUTDOWN_REASON_GAME_OVER  = 1;
  SHUTDOWN_REASON_DISCONNECT = 2;
  SHUTDOWN_REASON_ERROR      = 3;
}

message Shutdown {
  ShutdownReason reason = 1;
}
```

### Engine event source

`proxy/include/AI/AISEvents.h:104-120`:

```c
struct SReleaseEvent {
    int reason;  // 0=unspecified 1=game ended 2=team died 3=AI killed 4=AI crashed
                 // 5=init failed 6=connection lost 7=other
}; //$ EVENT_RELEASE  (topicId = 2)
```

### Mapping table

| Engine `SReleaseEvent.reason` | Proxy emits `Highbar__ShutdownReason` |
|---|---|
| 0 (unspecified) | `SHUTDOWN_REASON_UNKNOWN` |
| 1 (game ended) | `SHUTDOWN_REASON_GAME_OVER` ← the FR-009 case |
| 2 (team died) | `SHUTDOWN_REASON_GAME_OVER` (still terminal) |
| 3 (AI killed) | `SHUTDOWN_REASON_GAME_OVER` (still terminal) |
| 4 (AI crashed) | `SHUTDOWN_REASON_ERROR` |
| 5 (init failed) | `SHUTDOWN_REASON_ERROR` |
| 6 (connection lost) | `SHUTDOWN_REASON_DISCONNECT` |
| 7 (other) | `SHUTDOWN_REASON_UNKNOWN` |

### Optional schema additions (deferred, NOT in this feature)

If a future feature wants the bot to distinguish "game ended in victory" from "team died in defeat", add:

```proto
SHUTDOWN_REASON_TEAM_DIED = 4;
SHUTDOWN_REASON_AI_KILLED = 5;
```

This is NOT required for the spec's acceptance criteria — the bot only needs to know the session is terminal (per FR-010: "lets the bot tell game-over from a generic disconnect"). Both are satisfied by the existing `SHUTDOWN_REASON_GAME_OVER`.

## 4. Proxy configuration (US5)

### New `ProxyConfig` field

`proxy/include/highbar/config.h` `ProxyConfig` struct adds:

```c
bool verbose_commands;  // default: false
```

### Population

`proxy/src/config.c` `hb_config_load`:

1. Reads optional `AIOptions.lua` key `"verbose_commands"` via the existing `Info_getValueByKey`-style helper. Accepts `"true"`, `"1"`, `"yes"` → `true`; anything else (including missing) → `false`.
2. Overlays env var `HIGHBAR_VERBOSE_COMMANDS=1` (or `=true`) → `true`.

### Documentation in `AIOptions.lua`

`AIOptions.lua` (in the proxy's `data/` directory or wherever the engine reads it from) gets a new entry documenting the option:

```lua
{
    key  = 'verbose_commands',
    name = 'Verbose Per-Command Logging',
    desc = 'When enabled, the proxy logs every command dispatched to engine.infolog. ' ..
           'Default OFF to avoid bloating infolog files in normal sessions. ' ..
           'Override at runtime with HIGHBAR_VERBOSE_COMMANDS=1.',
    type = 'bool',
    def  = false,
}
```

### Behavior gate

In `proxy/src/proxy.c` (around lines 207-245), the entire per-command tracing block (including `Executing N commands`, `Cmd N: case=`, `MOVE uid=`, `Cmd N: rc=`) is wrapped in:

```c
if (state->config.verbose_commands) {
    // existing snprintf + proxy_log calls
}
```

The misleading `CMD_DETAIL case=%d enum_move=%d` line is **deleted entirely** within the wrapper (the `Cmd N: case=` line already provides the case number). Even with verbose logging enabled, the misleading constant never appears.

## 5. State transitions (informational)

### Bot session lifecycle (existing — clarified by US3 fix)

```
Init → Handshake → [Frame loop with commands + callbacks] → Terminal event → Disconnect
```

The new `EVENT_RELEASE` branch ensures the "Terminal event" step fires for surviving AIs on game-over, which previously only fired on the bot's own AI being destroyed:

| Trigger | Pre-fix behavior | Post-fix behavior |
|---|---|---|
| Engine destroys our AI (`[EOH::DestroySkirmishAI]`) | Socket close → `EngineDisconnectedException` | Unchanged ✅ |
| `Spring.GameOver`, our team survived | No event → bot runs to frame limit | `EVENT_RELEASE(reason=1)` → proxy emits `Shutdown(GAME_OVER)` → close socket → `EngineDisconnectedException` |
| Engine crashes / IPC dies | Socket close mid-frame → `EngineDisconnectedException` | Unchanged ✅ |

### Command dispatch (Issue 1 — to be confirmed)

Today, every command type follows this state path in the proxy:

```
F# client → AICommand protobuf → proxy receive →
deserialize.c switch on command_case →
handle_command(...) → Engine_handleCommand(skirmish_ai_id, -1, -1, topic, &struct) →
return rc → proxy_log
```

For MoveUnit this terminates in observable engine state change (the unit moves). For Fight/Attack/Patrol/etc., the terminal step is missing — the engine accepts the call but produces no visible effect. The Issue 1 fix may add ONE state to this path (e.g., set a struct field, change a `-1` argument) or change WHICH engine API is called. The diagnostic determines which.

## 6. Validation rules summary

| Rule | Source | Enforced where |
|---|---|---|
| `resourceId ∈ {0, 1}` | FR-008 | `proxy/src/callbacks.c` ECONOMY case |
| `verbose_commands` defaults to `false` | FR-014, Constitution VII | `proxy/src/config.c` |
| `EVENT_RELEASE` always emits a Shutdown then closes socket | FR-009, FR-012 | `proxy/src/proxy.c` `handleEvent` |
| Non-Move commands return non-zero `rc` only via switch-table check | FR-003, clarification Q2 | `proxy/src/deserialize.c` `default:` branch |
| In-scope command set is exactly the FR-002 list of 12 | FR-001, FR-002, clarification Q1 | `proxy/src/deserialize.c` switch cases + tests |
