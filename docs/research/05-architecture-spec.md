# HighBar V2 Architecture Specification

## Overview

HighBar V2 is a **native C shared library** that acts as a proxy between the Recoil engine's Skirmish AI interface and an external process. Communication uses **protobuf over Unix domain sockets** (with named pipe fallback on Windows).

## System Architecture

```
┌─────────────────────────────────────────────────────────────────┐
│                     Recoil Engine Process                       │
│                                                                 │
│  ┌──────────────┐     ┌─────────────────────────────────────┐   │
│  │ EngineOut     │────>│ HighBar Proxy (libSkirmishAI.so)    │   │
│  │ Handler       │     │                                     │   │
│  │               │     │  handleEvent() ──> serialize event  │   │
│  │ SSkirmishAI   │     │                    write to socket  │   │
│  │ Callback      │<────│  Engine_handleCommand() <── deser   │   │
│  │ (200+ funcs)  │     │                    read from socket │   │
│  └──────────────┘     └──────────────┬──────────────────────┘   │
│                                      │ Unix Domain Socket       │
│                                      │ /tmp/highbar-{pid}.sock  │
└──────────────────────────────────────┼──────────────────────────┘
                                       │
                                       │ Length-prefixed protobuf
                                       │
┌──────────────────────────────────────┼──────────────────────────┐
│              External AI Process     │                          │
│                                      │                          │
│  ┌───────────────────────────────────┴─────────────────────┐    │
│  │  HighBar Client Library (F# / Python / C++ / any lang)  │    │
│  │                                                          │    │
│  │  - Deserialize FrameUpdate events                        │    │
│  │  - Serialize CommandBatch responses                      │    │
│  │  - Query game state via CallbackRequest/Response         │    │
│  │  - Implement AI logic                                    │    │
│  └──────────────────────────────────────────────────────────┘    │
│                                                                  │
│  ┌──────────────────────────────────────────────────────────┐    │
│  │  User AI Implementation                                   │    │
│  │  (Any language that can read/write protobuf over socket)  │    │
│  └──────────────────────────────────────────────────────────┘    │
└──────────────────────────────────────────────────────────────────┘
```

## Component Design

### 1. Proxy Shared Library (C/C++)

**Purpose**: Native Skirmish AI that forwards all engine interactions to an external process.

**Exports**:
```c
EXPORT(int) init(int skirmishAIId, const struct SSkirmishAICallback* callback);
EXPORT(int) release(int skirmishAIId);
EXPORT(int) handleEvent(int skirmishAIId, int topic, const void* data);
```

**Responsibilities**:
- Store the `SSkirmishAICallback` pointer on `init()`
- On each `handleEvent()`:
  1. Serialize the event (topic + struct) to protobuf
  2. Send to external process via socket
  3. Wait for response (with timeout)
  4. Deserialize response commands
  5. Execute each command via `callback->Engine_handleCommand()`
- Handle callback queries from external process:
  - Receive `CallbackRequest` messages
  - Call the corresponding callback function
  - Return `CallbackResponse` with results

**Configuration**:
- Socket path from `AIOptions.lua` or environment variable
- Frame timeout (default 25ms)
- Log level

### 2. Protobuf Protocol

**Wire Format**: 4-byte little-endian length prefix + protobuf payload

**Top-Level Envelope**:
```protobuf
syntax = "proto3";
package highbar.v2;

message Envelope {
  uint64 sequence_id = 1;
  
  oneof payload {
    // Connection lifecycle
    Handshake handshake = 5;
    HandshakeAck handshake_ack = 6;
    Shutdown shutdown = 7;
    Heartbeat heartbeat = 8;
    
    // Engine -> AI (events)
    InitEvent init_event = 10;
    ReleaseEvent release_event = 11;
    UpdateEvent update_event = 12;
    UnitCreatedEvent unit_created = 13;
    UnitFinishedEvent unit_finished = 14;
    UnitIdleEvent unit_idle = 15;
    UnitMoveFailedEvent unit_move_failed = 16;
    UnitDamagedEvent unit_damaged = 17;
    UnitDestroyedEvent unit_destroyed = 18;
    UnitGivenEvent unit_given = 19;
    UnitCapturedEvent unit_captured = 20;
    EnemyEnterLosEvent enemy_enter_los = 21;
    EnemyLeaveLosEvent enemy_leave_los = 22;
    EnemyEnterRadarEvent enemy_enter_radar = 23;
    EnemyLeaveRadarEvent enemy_leave_radar = 24;
    EnemyDamagedEvent enemy_damaged = 25;
    EnemyDestroyedEvent enemy_destroyed = 26;
    WeaponFiredEvent weapon_fired = 27;
    PlayerCommandEvent player_command = 28;
    SeismicPingEvent seismic_ping = 29;
    CommandFinishedEvent command_finished = 30;
    LoadEvent load_event = 31;
    SaveEvent save_event = 32;
    EnemyCreatedEvent enemy_created = 33;
    EnemyFinishedEvent enemy_finished = 34;
    LuaMessageEvent lua_message = 35;
    MessageEvent message_event = 36;
    
    // AI -> Engine (commands)
    CommandBatch command_batch = 50;
    
    // Bidirectional (callback queries)
    CallbackRequest callback_request = 60;
    CallbackResponse callback_response = 61;
    
    // Frame synchronization
    FrameUpdate frame_update = 70;
    FrameAck frame_ack = 71;
  }
}
```

### 3. Frame Synchronization Protocol

Two modes of operation:

#### Mode A: Event-Per-Message (Low Latency)
Each engine event is sent individually as it occurs. The AI responds with commands at any time.
```
Engine: Envelope{unit_created=...}
Engine: Envelope{unit_finished=...}
Engine: Envelope{enemy_enter_los=...}
Engine: Envelope{update_event={frame=N}}  // frame tick
AI:     Envelope{command_batch={frame=N, commands=[...]}}
```

#### Mode B: Batched Frame Updates (Simpler, Recommended)
All events for a frame are batched into a single `FrameUpdate` message.
```
Engine: Envelope{frame_update={frame=N, events=[...], state_snapshot=...}}
AI:     Envelope{frame_ack={frame=N, commands=[...]}}
```

### 4. Callback Query Protocol

The external process can query game state at any time (during its frame processing):

```
AI:     Envelope{callback_request={id=1, get_unit_pos={unit_id=42}}}
Engine: Envelope{callback_response={id=1, unit_pos={x=100.0, y=50.0, z=200.0}}}
```

This allows the AI to access the full `SSkirmishAICallback` interface without the proxy pre-sending all game state every frame.

**Two strategies for state access**:
1. **Push model**: Proxy sends full/delta game state with each `FrameUpdate`. Simpler for AI, higher bandwidth.
2. **Pull model**: AI queries specific data via `CallbackRequest`. Lower bandwidth, higher latency per query. 
3. **Hybrid** (recommended): Push common state (unit positions, resources, events) with frame update. Pull for rare queries (map data, unit defs, weapon defs).

### 5. Client Libraries

Thin wrappers around socket I/O + protobuf deserialization. Generated from `.proto` files.

**Primary target**: F# / .NET
**Secondary targets**: Python, C++, Rust

Each client library provides:
- Connection management (connect, reconnect, shutdown)
- Frame loop abstraction (receive FrameUpdate, return commands)
- Typed access to all events and commands
- Optional callback query helpers
- Async/sync API variants

## Connection Lifecycle

```
1. External AI process starts, creates Unix domain socket, listens
2. Engine loads HighBar proxy (libSkirmishAI.so)
3. Proxy init() connects to socket (path from config)
4. Handshake exchange (protocol version, game info, AI team)
5. Game loop:
   a. Engine calls handleEvent() on proxy
   b. Proxy serializes and sends events
   c. On UPDATE event: proxy sends FrameUpdate, waits for FrameAck
   d. Proxy executes returned commands via Engine_handleCommand()
6. On RELEASE event: proxy sends Shutdown, closes socket
```

Alternative: proxy creates socket and listens, external process connects. Both viable.

## Error Handling

| Scenario | Proxy Behavior |
|----------|---------------|
| External process not running | init() fails, AI not loaded |
| External process crashes mid-game | Detect broken pipe, log error, return error from handleEvent() -> engine removes AI |
| Frame timeout (AI too slow) | Skip commands for this frame, log warning, continue |
| Malformed protobuf | Log error, skip message, continue |
| Socket buffer full | Block briefly, then timeout |

## Performance Targets

| Metric | Target |
|--------|--------|
| Event serialization | < 100us per frame (all events) |
| Round-trip latency | < 500us per frame (socket + ser/deser) |
| AI response budget | < 25ms per frame (of 33ms frame time at 30fps) |
| Memory overhead | < 10MB for proxy (buffers, protobuf arena) |
| Max events per frame | 1000+ (batched in single message) |

## File Layout

```
HighBarV2/
├── docs/
│   └── research/              # This research
├── proto/
│   ├── highbar/v2/
│   │   ├── envelope.proto     # Top-level message envelope
│   │   ├── events.proto       # All 28 engine events
│   │   ├── commands.proto     # All 97 AI commands
│   │   ├── callback.proto     # Callback request/response
│   │   ├── types.proto        # Common types (Position, UnitDef, etc.)
│   │   └── state.proto        # Game state snapshot
│   └── buf.yaml               # Buf schema registry config
├── proxy/                     # C/C++ proxy shared library
│   ├── CMakeLists.txt
│   ├── src/
│   │   ├── main.cpp           # handleEvent/init/release exports
│   │   ├── serializer.cpp     # Event -> protobuf
│   │   ├── deserializer.cpp   # Protobuf -> commands
│   │   ├── transport.cpp      # Socket I/O with framing
│   │   └── callback_handler.cpp # Callback query handling
│   └── include/
├── client/                    # Client libraries
│   ├── fsharp/                # F# client
│   ├── python/                # Python client  
│   └── cpp/                   # C++ client
├── AI/Skirmish/HighBar/       # Installable AI directory
│   ├── AIInfo.lua
│   ├── AIOptions.lua
│   └── 0.1/                   # Version directory for .so/.dll
└── tests/
```

## Comparison with HighBar V1

| Aspect | V1 (Lua Bridge) | V2 (Native Proxy) |
|--------|-----------------|-------------------|
| Integration point | Lua widget/gadget | C AI Interface |
| Protocol | NDJSON over TCP | Protobuf over Unix socket |
| Engine API coverage | Partial (Lua API subset) | Full (28 events, 97 commands, 200+ callbacks) |
| Serialization overhead | JSON + base64 for binary | Protobuf (native binary) |
| Transport overhead | TCP (20-50us) | Unix socket (5-20us) |
| Engine modification | None (pure Lua) | None (standard AI plugin) |
| Latency | ~1-5ms per frame | ~100-500us per frame |
| Binary data | base64 encoded | Native protobuf bytes |
| Client languages | Python only | Any (protobuf codegen) |

## Open Questions

1. **Socket vs pipe direction**: Should proxy listen or connect? Proxy-connects-to-AI is simpler for the AI developer. AI-connects-to-proxy is more standard for server patterns.
2. **Callback caching**: Should proxy cache callback results per frame to reduce round-trips? E.g., cache all unit positions once on first query per frame.
3. **Multi-AI support**: Can one external process control multiple AI teams? Would need multiplexed connections.
4. **Save/Load**: How to handle EVENT_LOAD/EVENT_SAVE? External process needs to serialize its state.
5. **Protobuf version**: proto3 is simpler but loses has-field tracking for scalars. Game state where "0" is meaningful (zero health) may need wrappers or proto2.
