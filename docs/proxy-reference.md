# C Proxy Reference

The HighBar V2 proxy is a C11 shared library (`libSkirmishAI.so`) that implements the Recoil engine's Skirmish AI plugin interface. It serializes engine events to protobuf, sends them over a socket to an external AI process, and deserializes the AI's command responses back into engine command structs.

## Plugin Interface

The proxy exports three functions matching the `SSkirmishAILibrary` interface:

```c
int init(int skirmishAIId, const struct SSkirmishAICallback* callback);
int release(int skirmishAIId);
int handleEvent(int skirmishAIId, int topicId, const void* data);
```

### `init()`

1. Stores the engine callback function table
2. Loads configuration from engine info and environment variables
3. Creates the memory arena (bump allocator)
4. Connects to the AI process socket
5. Performs protocol handshake
6. Enables cheat events via callback
7. Returns 0 on success

### `handleEvent()`

1. Casts `data` to the appropriate engine struct based on `topicId`
2. Serializes the event to a protobuf `EngineEvent` message
3. In BATCHED mode: accumulates events until `UPDATE`, then sends a `Frame`
4. In INDIVIDUAL mode: sends each event immediately
5. Receives `FrameResponse` with commands
6. Deserializes and executes each command via `handleCommand()`
7. Processes any callback requests inline

### `release()`

1. Sends `Shutdown` message to the AI process
2. Closes the socket connection
3. Destroys the memory arena
4. Frees configuration state

## Source Files

| File | Lines | Responsibility |
|------|-------|---------------|
| `proxy.c` | 449 | Plugin lifecycle, frame batching, handshake |
| `connection.c` | 211 | Socket I/O with length-prefixed framing, recording |
| `serialize.c` | 337 | Engine event structs → protobuf (28 types) |
| `deserialize.c` | 711 | Protobuf → engine command structs (97 types) |
| `callbacks.c` | 294 | Callback dispatch to engine |
| `arena.c` | 52 | Bump allocator |
| `config.c` | 86 | Configuration loading |

## Memory Model

### Arena Allocator (`arena.c`)

All protobuf message allocation on the hot path uses a bump allocator:

```c
typedef struct {
    uint8_t* buffer;    // Backing memory
    size_t capacity;    // Total size
    size_t offset;      // Current allocation point
} HB_Arena;
```

- `hb_arena_init(arena, capacity)` — Allocate backing buffer
- `hb_arena_reset(arena)` — Reset offset to 0 (called at start of each frame)
- `hb_arena_destroy(arena)` — Free backing buffer
- `hb_arena_allocator(arena)` — Return `ProtobufCAllocator` for protobuf-c

Allocations are 8-byte aligned. The `free` function is a no-op — memory is reclaimed in bulk when the arena resets. This eliminates per-message heap allocation on the hot path.

### Position Buffer Pool (`deserialize.c`)

Command deserialization uses a circular buffer pool of 4 `float[3]` arrays for position data:

```c
static float pos_buf[4][3];
static int pos_idx = 0;
```

This avoids allocating position arrays for each command while ensuring the engine can safely dereference position pointers from the most recent commands.

## Connection (`connection.c`)

### Transport Modes

| Mode | Socket Type | Default |
|------|-------------|---------|
| Unix domain socket | `AF_UNIX` | Yes (`/tmp/highbar.sock`) |
| TCP loopback | `AF_INET` `127.0.0.1` | No (port 17432) |

### Wire Protocol

Messages use length-prefixed framing:

```c
// Send: 4-byte LE length + payload
int hb_conn_send(HB_Connection* conn, const uint8_t* data, size_t len);

// Receive: read 4-byte header, then payload (with poll timeout)
int hb_conn_recv(HB_Connection* conn, uint8_t** out_data, size_t* out_len,
                 ProtobufCAllocator* alloc);
```

- `write_all()` handles partial writes and `EINTR`
- `read_all()` uses `poll()` with configurable timeout
- `SIGPIPE` is handled — a crashed AI process results in clean error return

### Recording

Connections support optional recording for replay:

```c
void hb_conn_enable_recording(HB_Connection* conn, const char* path);
void hb_conn_disable_recording(HB_Connection* conn);
```

When enabled, all sent and received messages are written to a binary file for later replay analysis.

## Serialization (`serialize.c`)

`hb_serialize_event()` converts engine event structs to protobuf `EngineEvent` messages. It handles all 28 event types with correct field mapping:

- Unit events: map `unitId`, `builderId`, positions
- Damage events: include `attackerId`, `damage`, `weaponDefId`, `isParalyzer`
- Enemy events: mirror friendly unit events with `enemyId`
- Player command events: copy variable-length unit ID arrays

All messages are allocated from the frame arena.

## Deserialization (`deserialize.c`)

`hb_deserialize_and_execute()` converts protobuf `AICommand` messages to engine command structs and executes them via `handleCommand()`. It handles all 97 command types including:

- Unit movement commands (move, patrol, fight, attack, guard)
- Build commands (build unit, repair, reclaim, resurrect, capture)
- State commands (on/off, repeat, move state, fire state, trajectory)
- Cheat commands (give resources, spawn units)
- Drawing commands (add point, add line, draw figures)
- Path commands (init path, get waypoint, free path)
- Lua commands (call rules, call UI)
- Group commands (add/remove from group)

## Callback Dispatch (`callbacks.c`)

`hb_callback_dispatch()` routes callback requests to the engine's `SSkirmishAICallback` function table. Currently implemented callbacks:

- **Game:** team ID, ally team ID
- **Map:** width, height, start positions, metal spots
- **Unit:** position, health, max health, def ID, team, max speed
- **UnitDef:** name, build options, max weapon range, build speed, cost, build time
- **Economy:** current, income, usage, storage (for metal and energy)
- **Cheats:** enable/disable cheat events
- **Bulk:** get all unit def IDs

## Building

```bash
cmake -B build -DCMAKE_BUILD_TYPE=Release proxy/
cmake --build build
```

The CMake configuration:
- Requires C11 standard
- Links `protobuf-c` via pkg-config
- Compiles with `-Wall -Wextra -Wpedantic -Werror`
- Produces `libSkirmishAI.so` shared library
- Auto-deploys to BAR engine AI directories post-build
- Builds 4 test executables (`test_serialize`, `test_deserialize`, `test_roundtrip`, `test_callbacks`)

### Running C Tests

```bash
cd build && ctest
```

Or via the unified test runner:

```bash
./tests/run-all.sh --category proxy
```

## Engine Headers

The proxy includes Recoil engine headers (vendored in `proxy/include/AI/` and `proxy/include/System/`):

| Header | Purpose |
|--------|---------|
| `SSkirmishAILibrary.h` | Plugin function signatures |
| `SSkirmishAICallback.h` | Engine callback function table (1900+ lines) |
| `AISEvents.h` | Event topic IDs and struct definitions |
| `AISCommands.h` | Command IDs and struct definitions |
| `aidefines.h` | AI system constants |

The proxy also defines compatibility types in `engine_types.h` for commands not present in the standard engine headers (e.g., `SSetWantedMaxSpeedCommand`, `SPauseTeamCommand`).

See also: [Architecture](architecture.md) | [Protocol](protocol.md) | [Configuration](configuration.md)
