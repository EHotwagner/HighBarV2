# Protocol Reference

HighBar V2 uses a binary protocol based on Protocol Buffers 3 for all communication between the C proxy (running inside the Recoil engine) and external AI processes.

## Wire Format

All messages use **length-prefixed framing**:

```
┌──────────────┬──────────────────────┐
│ Length (4B)   │ Protobuf payload     │
│ Little-endian │ (variable length)    │
│ uint32        │                      │
└──────────────┴──────────────────────┘
```

- Length prefix is a 4-byte little-endian unsigned integer
- Maximum message size is configurable (default 8MB, range 64KB-16MB)
- Messages exceeding the limit are rejected with a logged error

## Transport

Two transport modes are supported:

| Transport | Default | Socket Path |
|-----------|---------|-------------|
| Unix domain socket | Yes | `/tmp/highbar.sock` |
| TCP loopback | No | `127.0.0.1:17432` |

The proxy is the **client** — it connects to the AI process's listening socket. The AI process must create and listen on the socket before the game starts.

## Message Types

### Envelope Messages

The protocol uses two top-level envelope types:

**`ProxyMessage`** (proxy → AI):

| Variant | Description |
|---------|-------------|
| `Handshake` | Protocol negotiation at connection start |
| `Frame` | Game frame with events |
| `CallbackResponse` | Response to an AI callback query |
| `SaveRequest` | Engine requests AI state serialization |
| `LoadRequest` | Engine provides saved state for deserialization |
| `Shutdown` | Game ending (reason: game_over, disconnect, error) |

**`AIMessage`** (AI → proxy):

| Variant | Description |
|---------|-------------|
| `HandshakeResponse` | Accept/reject handshake |
| `FrameResponse` | Commands for the current frame |
| `CallbackRequest` | Query engine state mid-frame |
| `SaveResponse` | Serialized AI state blob |

### Connection Lifecycle

```
Proxy                          AI Client
  │                               │
  │── Handshake ─────────────────→│  protocol_version, engine_version,
  │                               │  game, map, mod, team_id, player_count
  │◄── HandshakeResponse ────────│  accepted, protocol_version
  │                               │
  │── Frame (events) ────────────→│
  │◄── FrameResponse (commands) ──│
  │    ... repeats per frame ...   │
  │                               │
  │── Shutdown ──────────────────→│  reason
  │                               │
```

### Handshake

```protobuf
message Handshake {
  uint32 protocol_version = 1;
  string engine_version = 2;
  string game = 3;
  string map = 4;
  string mod = 5;
  int32 team_id = 6;
  int32 ally_team_id = 7;
  int32 player_count = 8;
}

message HandshakeResponse {
  bool accepted = 1;
  uint32 protocol_version = 2;
}
```

The current protocol version is **1**. If versions don't match, the AI should reject the handshake.

### Frame / FrameResponse

```protobuf
message Frame {
  uint32 frame_number = 1;
  repeated EngineEvent events = 2;
  int32 team_id = 3;
}

message FrameResponse {
  repeated AICommand commands = 1;
  int32 team_id = 2;
}
```

In **BATCHED** mode (default), all events within a game frame are collected and sent as a single `Frame` message when the `UPDATE` event fires. The AI responds with zero or more commands.

## Events (28 types)

Events are delivered as an `EngineEvent` oneof message. All 28 engine event types are supported:

### Lifecycle Events

| Event | Fields | Description |
|-------|--------|-------------|
| `InitEvent` | `team_id` | AI initialized, provides team assignment |
| `ReleaseEvent` | — | AI being removed from game |
| `UpdateEvent` | `frame` | New game frame tick |
| `MessageEvent` | `player`, `message` | Chat message received |
| `LoadEvent` | — | Engine requests state load |
| `SaveEvent` | — | Engine requests state save |

### Friendly Unit Events

| Event | Fields | Description |
|-------|--------|-------------|
| `UnitCreatedEvent` | `unit_id`, `builder_id` | New unit started building |
| `UnitFinishedEvent` | `unit_id` | Unit construction complete |
| `UnitIdleEvent` | `unit_id` | Unit has no orders |
| `UnitMoveFailedEvent` | `unit_id` | Unit cannot reach destination |
| `UnitDamagedEvent` | `unit_id`, `attacker_id`?, `damage`, `weapon_def_id`, `is_paralyzer` | Unit took damage |
| `UnitDestroyedEvent` | `unit_id`, `attacker_id`? | Unit destroyed |
| `UnitGivenEvent` | `unit_id`, `old_team_id`, `new_team_id` | Unit transferred to another team |
| `UnitCapturedEvent` | `unit_id`, `old_team_id`, `new_team_id` | Unit captured by enemy |

### Enemy Unit Events

| Event | Fields | Description |
|-------|--------|-------------|
| `EnemyCreatedEvent` | `enemy_id` | Enemy unit spotted (created) |
| `EnemyFinishedEvent` | `enemy_id` | Enemy unit finished building |
| `EnemyEnterLOSEvent` | `enemy_id` | Enemy entered line of sight |
| `EnemyLeaveLOSEvent` | `enemy_id` | Enemy left line of sight |
| `EnemyEnterRadarEvent` | `enemy_id` | Enemy entered radar range |
| `EnemyLeaveRadarEvent` | `enemy_id` | Enemy left radar range |
| `EnemyDamagedEvent` | `enemy_id`, `attacker_id`?, `damage`, `weapon_def_id` | Enemy took damage |
| `EnemyDestroyedEvent` | `enemy_id`, `attacker_id`? | Enemy destroyed |

### Other Events

| Event | Fields | Description |
|-------|--------|-------------|
| `WeaponFiredEvent` | `unit_id`, `weapon_def_id` | Friendly unit fired a weapon |
| `PlayerCommandEvent` | `units[]`, `command_topic_id`, `command_id` | Player issued a command |
| `SeismicPingEvent` | `position`, `strength` | Seismic activity detected |
| `CommandFinishedEvent` | `unit_id`, `command_id`, `command_topic_id` | Unit completed a command |
| `LuaMessageEvent` | `data`, `in_message_id` | Message from Lua game rules |

## Commands (97 types)

Commands are sent as `AICommand` oneof messages in the `FrameResponse`. The most commonly used commands:

### Unit Commands

| Command | Key Fields | Description |
|---------|-----------|-------------|
| `MoveUnitCommand` | `unit_id`, `to_position` | Move unit to position |
| `PatrolCommand` | `unit_id`, `to_position` | Patrol to waypoint |
| `FightCommand` | `unit_id`, `to_position` | Attack-move to position |
| `AttackCommand` | `unit_id`, `target_unit_id` | Attack specific unit |
| `GuardCommand` | `unit_id`, `guard_unit_id` | Guard another unit |
| `StopCommand` | `unit_id` | Cancel all orders |
| `BuildUnitCommand` | `unit_id`, `to_build_unit_def_id`, `build_position`, `facing` | Build a structure |
| `RepairCommand` | `unit_id`, `repair_unit_id` | Repair a unit |
| `ReclaimUnitCommand` | `unit_id`, `reclaim_unit_id` | Reclaim a unit |
| `SelfDestructCommand` | `unit_id` | Self-destruct |
| `SetWantedMaxSpeedCommand` | `unit_id`, `wanted_max_speed` | Limit movement speed |
| `CustomCommand` | `unit_id`, `command_id`, `params[]` | Engine-specific custom command |

### Chat / Resource Commands

| Command | Key Fields | Description |
|---------|-----------|-------------|
| `SendTextMessageCommand` | `text`, `zone` | Send chat message |
| `GiveMeCommand` | `resource_id`, `amount` | Cheat: give resources (0=metal, 1=energy) |
| `GiveMeNewUnitCommand` | `unit_def_id`, `position` | Cheat: spawn a unit |

### Lua Commands

| Command | Key Fields | Description |
|---------|-----------|-------------|
| `CallLuaRulesCommand` | `data` | Call into Lua game rules |
| `CallLuaUICommand` | `data` | Call into Lua UI |

### Command Options

All unit commands include an `options` bitfield and `timeout`:

| Flag | Value | Meaning |
|------|-------|---------|
| `META_KEY` | 1 | Meta key modifier |
| `INTERNAL_ORDER` | 8 | Programmatic AI order (used by default) |
| `RIGHT_MOUSE_KEY` | 16 | Right-click context |
| `SHIFT_KEY` | 32 | Queue command |
| `CTRL_KEY` | 64 | Control modifier |
| `ALT_KEY` | 128 | Alt modifier |

The F# client sets `INTERNAL_ORDER` (8) on all commands by default.

## Callbacks (135 types)

Callbacks allow the AI to query engine state mid-frame. The AI sends a `CallbackRequest`, and the proxy dispatches it to the engine's `SSkirmishAICallback` function table, returning a `CallbackResponse`.

```protobuf
message CallbackRequest {
  uint32 request_id = 1;
  uint32 callback_id = 2;
  repeated CallbackParam params = 3;
}

message CallbackResponse {
  uint32 request_id = 1;
  bool success = 2;
  CallbackResult result = 3;
}
```

### Commonly Used Callbacks

| Callback | Params | Returns | Description |
|----------|--------|---------|-------------|
| `CALLBACK_GET_UNIT_DEFS` | max_count | int array | All valid unitDefId values |
| `CALLBACK_UNITDEF_GET_NAME` | def_id | string | Unit type name |
| `CALLBACK_UNITDEF_GET_BUILD_OPTIONS` | def_id, max | int array | Buildable unit def IDs |
| `CALLBACK_UNITDEF_GET_MAX_WEAPON_RANGE` | def_id | float | Weapon range (0 = unarmed) |
| `CALLBACK_UNITDEF_GET_BUILD_SPEED` | def_id | float | Build speed (0 = not builder) |
| `CALLBACK_UNITDEF_GET_COST` | def_id | float | Metal cost |
| `CALLBACK_UNITDEF_GET_BUILD_TIME` | def_id | float | Build time |
| `CALLBACK_UNIT_GET_POS` | unit_id | Vector3 | Unit position |
| `CALLBACK_UNIT_GET_HEALTH` | unit_id | float | Current health |
| `CALLBACK_UNIT_GET_MAX_HEALTH` | unit_id | float | Maximum health |
| `CALLBACK_UNIT_GET_DEF` | unit_id | int | Unit's defId |
| `CALLBACK_UNIT_GET_TEAM` | unit_id | int | Unit's team ID |
| `CALLBACK_UNIT_GET_MAX_SPEED` | unit_id | float | Maximum movement speed |
| `CALLBACK_MAP_GET_WIDTH` | — | int | Map width (in map squares) |
| `CALLBACK_MAP_GET_HEIGHT` | — | int | Map height (in map squares) |
| `CALLBACK_MAP_GET_START_POS` | team_id | Vector3 | Team start position |
| `CALLBACK_MAP_GET_METAL_SPOTS` | — | float array | Metal spots (x,y,z,value groups) |
| `CALLBACK_ECONOMY_GET_CURRENT` | resource_id | float | Current resource amount |
| `CALLBACK_ECONOMY_GET_INCOME` | resource_id | float | Resource income/sec |
| `CALLBACK_ECONOMY_GET_USAGE` | resource_id | float | Resource usage/sec |
| `CALLBACK_ECONOMY_GET_STORAGE` | resource_id | float | Storage capacity |
| `CALLBACK_GAME_GET_MY_TEAM` | — | int | Our team ID |
| `CALLBACK_GAME_GET_MY_ALLY_TEAM` | — | int | Our ally team ID |
| `CALLBACK_CHEATS_SET_EVENTS_ENABLED` | enabled | int | Enable cheat events |

## Schema Files

The proto source files are in `proto/highbar/` and are linted with `buf lint`. Generated code must not be checked into version control.

```bash
# Lint protos
cd proto && buf lint

# Generate code
cd proto && buf generate
```

See also: [Architecture](architecture.md) | [Client API](client-api.md) | [Configuration](configuration.md)
