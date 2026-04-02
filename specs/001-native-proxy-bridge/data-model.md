# Data Model: Native C Proxy Bridge

**Feature**: 001-native-proxy-bridge | **Date**: 2026-04-02

## Entities

### ProxyState (runtime, in-memory)

The singleton state maintained by the proxy shared library across its lifetime.

| Field | Type | Description |
|-------|------|-------------|
| skirmish_ai_id | int | Engine-assigned AI identifier |
| callback | SSkirmishAICallback* | Engine callback function table (stored at init) |
| socket_fd | int | Connected Unix domain socket file descriptor (-1 if disconnected) |
| connected | bool | Whether handshake completed successfully |
| config | ProxyConfig | Loaded configuration |
| arena | Arena | Per-frame bump allocator for protobuf messages |
| frame_number | uint32 | Current game frame counter |

**Lifecycle**: Created in `init()`, used throughout `handleEvent()` calls, destroyed in `release()`.

### ProxyConfig

| Field | Type | Default | Source |
|-------|------|---------|--------|
| socket_path | string | "/tmp/highbar.sock" | AIOptions.lua / env HIGHBAR_SOCKET_PATH |
| timeout_ms | uint32 | 25 | AIOptions.lua / env HIGHBAR_TIMEOUT_MS |
| log_level | enum(ERROR,WARN,INFO,DEBUG) | INFO | AIOptions.lua / env HIGHBAR_LOG_LEVEL |
| frame_mode | enum(INDIVIDUAL,BATCHED) | BATCHED | AIOptions.lua / env HIGHBAR_FRAME_MODE |
| push_state | bool | false | AIOptions.lua / env HIGHBAR_PUSH_STATE |
| max_message_size | uint32 | 8388608 (8MB) | AIOptions.lua / env HIGHBAR_MAX_MSG_SIZE |
| transport | enum(UNIX,TCP) | UNIX | AIOptions.lua / env HIGHBAR_TRANSPORT |
| tcp_port | uint16 | 17432 | AIOptions.lua / env HIGHBAR_TCP_PORT |

### Arena (per-frame bump allocator)

| Field | Type | Description |
|-------|------|-------------|
| buffer | uint8* | Pre-allocated memory block |
| capacity | size_t | Total arena size (default 1MB) |
| offset | size_t | Current allocation offset (reset to 0 each frame) |

**Lifecycle**: Allocated once at init. Reset (offset=0) at start of each frame's handleEvent. Never freed until release.

## Protocol Messages (protobuf)

### Wire Envelope

All messages on the wire use 4-byte little-endian length prefix + serialized protobuf:

```
[4 bytes: message length (LE)] [N bytes: serialized protobuf]
```

### Top-Level Direction Messages

| Message | Direction | Purpose |
|---------|-----------|---------|
| Handshake | Bidirectional | Protocol version exchange, game info, team assignment |
| HandshakeResponse | AI → Proxy | Acceptance/rejection of handshake |
| Frame | Proxy → AI | Batched events for a single frame |
| FrameResponse | AI → Proxy | Command batch response to a frame |
| CallbackRequest | AI → Proxy | Engine callback query |
| CallbackResponse | Proxy → AI | Engine callback result |
| Shutdown | Proxy → AI | Game end / AI removal notification |
| SaveRequest | Proxy → AI | Engine requests AI state serialization |
| SaveResponse | AI → Proxy | Serialized AI state blob |
| LoadRequest | Proxy → AI | Engine provides saved AI state to restore |

### EngineEvent (oneof with 28 variants)

Each variant maps 1:1 to an engine `S*Event` struct:

| Event | Key Fields |
|-------|-----------|
| InitEvent | team_id |
| ReleaseEvent | (empty) |
| UpdateEvent | frame |
| MessageEvent | player, message |
| UnitCreatedEvent | unit_id, builder_id |
| UnitFinishedEvent | unit_id |
| UnitIdleEvent | unit_id |
| UnitMoveFailedEvent | unit_id |
| UnitDamagedEvent | unit_id, optional attacker_id, damage, direction, weapon_def_id, is_paralyzer |
| UnitDestroyedEvent | unit_id, optional attacker_id |
| UnitGivenEvent | unit_id, old_team_id, new_team_id |
| UnitCapturedEvent | unit_id, old_team_id, new_team_id |
| EnemyEnterLOSEvent | enemy_id |
| EnemyLeaveLOSEvent | enemy_id |
| EnemyEnterRadarEvent | enemy_id |
| EnemyLeaveRadarEvent | enemy_id |
| EnemyDamagedEvent | enemy_id, optional attacker_id, damage, direction, weapon_def_id |
| EnemyDestroyedEvent | enemy_id, optional attacker_id |
| WeaponFiredEvent | unit_id, weapon_def_id |
| PlayerCommandEvent | units, command_topic_id, command_id |
| SeismicPingEvent | position, strength |
| CommandFinishedEvent | unit_id, command_id, command_topic_id |
| LoadEvent | (empty — triggers AI state restore) |
| SaveEvent | (empty — triggers AI state save) |
| EnemyCreatedEvent | enemy_id |
| EnemyFinishedEvent | enemy_id |
| LuaMessageEvent | data, in_message_id |

**Note**: Fields like `attacker_id` use `optional int32` to distinguish "no attacker" (not set) from "attacker is unit 0". Mapped to/from engine sentinel value -1.

### AICommand (oneof with 97 variants)

Common base fields present in most command types:

| Field | Type | Description |
|-------|------|-------------|
| unit_id | int32 | Unit to command |
| group_id | int32 | Group to command (0 = no group) |
| options | uint32 | Bitfield: SHIFT_KEY, CTRL_KEY, ALT_KEY, META_KEY, INTERNAL_ORDER, RIGHT_MOUSE_KEY |
| timeout | int32 | Frame timeout for command (-1 = infinite) |

97 command variants cover: drawing, chat, resources, groups, pathfinding, cheats, Lua calls, drawer figures, and unit commands (build, stop, wait, move, patrol, fight, attack, guard, repair, reclaim, restore, resurrect, capture, set-base, self-destruct, load/unload units, set-speed, stockpile, dgun, custom).

### CallbackRequest / CallbackResponse

| Field | Type | Description |
|-------|------|-------------|
| request_id | uint32 | Correlation ID for matching request/response |
| callback_id | uint32 | Enum identifying which callback function to invoke |
| params | repeated CallbackParam | Typed parameters for the callback |
| success | bool | (Response only) Whether callback succeeded |
| result | CallbackResult | (Response only) Typed return value |
| error_message | string | (Response only) Error description if !success |

## State Transitions

### Connection Lifecycle

```
DISCONNECTED → CONNECTING → HANDSHAKE → CONNECTED → DISCONNECTED
     │              │           │            │
     │              └── timeout ─┘            │
     │                  → ERROR               │
     │                                        │
     └────────────────────────────────────────┘
                  (one-shot: no reconnect)
```

- **DISCONNECTED**: Initial state. Proxy attempts connection in `init()`.
- **CONNECTING**: Socket connect in progress.
- **HANDSHAKE**: Connected, exchanging protocol version. Strict version match required.
- **CONNECTED**: Handshake complete. Processing events and commands.
- **DISCONNECTED (terminal)**: Connection lost or game ended. No reconnection. Returns error to engine for AI removal.

### Frame Processing Cycle (per handleEvent call)

```
1. Receive event from engine (topicId + data struct)
2. Serialize event to protobuf (arena allocation)
3. If BATCHED mode: accumulate until UPDATE event triggers send
4. Send Frame message over socket
5. Wait for FrameResponse (with timeout_ms)
6. If timeout: log warning, skip commands, continue
7. If response: deserialize CommandBatch, execute each via Engine_handleCommand
8. Reset arena
```

## Relationships

```
ProxyState 1──1 ProxyConfig
ProxyState 1──1 Arena
ProxyState 1──* EngineEvent (per frame, transient)
EngineEvent *──1 Frame (batched)
Frame 1──1 FrameResponse
FrameResponse 1──* AICommand (command batch)
CallbackRequest 1──1 CallbackResponse
```
