# HighBar V2 Implementation Roadmap

## Phase 1: Foundation

### 1.1 Protobuf Schema
- Define `.proto` files for all 28 events, 97 commands, and common types
- Set up buf.build for linting and code generation
- Generate C++ and F# bindings (Python support removed in feature 019)
- Write schema validation tests

### 1.2 Transport Layer
- Implement length-prefixed message framing (4-byte LE header)
- Unix domain socket transport (Linux)
- TCP loopback fallback (cross-platform)
- Connection lifecycle: listen, accept, handshake, shutdown
- Read/write with configurable timeouts

### 1.3 Minimal Proxy Library
- C/C++ shared library exporting `init`, `release`, `handleEvent`
- Serialize `EVENT_INIT`, `EVENT_UPDATE`, `EVENT_RELEASE` only
- Forward to external process, receive empty acknowledgment
- Validate end-to-end: engine loads proxy -> proxy connects to external process -> events flow

**Deliverable**: Engine loads HighBar proxy, connects to external process, sends frame updates.

## Phase 2: Core Events & Commands

### 2.1 Full Event Serialization
- Implement serialization for all 28 event types
- Map each engine C struct to corresponding protobuf message
- Handle all field types: int, float, float3 -> Position, arrays, strings

### 2.2 Command Deserialization & Execution
- Implement deserialization for all unit commands
- Map protobuf commands to `Engine_handleCommand()` calls with correct structs
- Handle `CommandOptions` (shift/queue, timeout, etc.)
- Implement engine commands (text, Lua calls, resources, drawing)

### 2.3 Frame Synchronization
- Implement batched `FrameUpdate` mode
- Collect all events per frame, send as single message on `EVENT_UPDATE`
- Wait for `CommandBatch` response with timeout
- Execute all commands, return control to engine

**Deliverable**: External process receives all game events and can issue all commands.

## Phase 3: Callback Queries

### 3.1 Priority Callbacks
- Unit queries: position, health, def, velocity, commands, state flags
- Team queries: own units, enemy units, friendly units
- Economy queries: resource state
- Map queries: size, elevation, build site validation

### 3.2 Extended Callbacks
- Map data: heightmap, slopemap, LOS, radar, resource maps (as byte arrays)
- Unit definitions: full UnitDef properties
- Weapon definitions
- Feature queries
- Pathfinding: init, waypoints, length, free

### 3.3 State Push Optimization
- Configure which state to push automatically with frame updates
- Default: own unit positions/health, resource state, visible enemy positions
- Reduce callback round-trips for common queries

**Deliverable**: External process can query any game state via callbacks, with common state pushed automatically.

## Phase 4: Client Libraries

### 4.1 F# Client
- Generated protobuf bindings via `Grpc.Tools` or `protobuf-net`
- `HighBarClient` class with connect/disconnect/frame loop
- Typed event handlers (pattern matching on discriminated unions)
- Typed command builders
- Async frame processing with `Async<CommandBatch>`

### 4.2 Example AI
- Simple economy/build order AI as reference implementation
- Demonstrates event handling, state queries, command issuance
- F# implementation

**Deliverable**: Ready-to-use client libraries with example AIs.

## Phase 5: Production Hardening

### 5.1 Performance
- Protobuf arena allocation for hot-path messages
- Pre-sized I/O buffers
- Benchmark: events/sec, commands/sec, round-trip latency
- Profile and optimize bottlenecks

### 5.2 Robustness
- Graceful handling of external process crash
- Frame timeout with configurable behavior (skip/pause/remove AI)
- Message size limits and validation
- SIGPIPE handling
- Reconnection support (optional)

### 5.3 Configuration
- `AIOptions.lua` for in-game configuration
- Socket path, timeout, log level, push state options
- Environment variable overrides

### 5.4 Packaging
- Build system (CMake) for proxy library
- Cross-compilation support (Linux .so, Windows .dll)
- Installation script (copy to BAR AI directory)
- NuGet package for F# client

**Deliverable**: Production-ready proxy with client packages.

## Phase 6: Advanced Features

### 6.1 Multi-AI Support
- Multiple AI teams controlled by single external process
- Multiplexed messages with team ID routing
- Shared state optimization (one map query for all teams)

### 6.2 Replay & Recording
- Record all protobuf messages to file for replay
- Replay mode: feed recorded messages to AI without engine
- Useful for debugging and training data

### 6.3 RL Training Integration
- Stepped mode: AI controls frame advancement
- Faster-than-realtime support
- Gym/Gymnasium environment wrapper
- Batch environment support (multiple games in parallel)

### 6.4 Spectator/Debug Tools
- Web dashboard for real-time AI state visualization
- Command history and replay
- Performance metrics and profiling

---

## Key Dependencies

| Dependency | Purpose | Version |
|------------|---------|---------|
| protobuf (libprotobuf) | C++ serialization | 3.21+ |
| protoc | Code generation | 3.21+ |
| CMake | C++ build system | 3.16+ |
| .NET SDK | F# client | 10.0+ |
| protobuf-net / Google.Protobuf | F# protobuf | Latest |
| Recoil Engine headers | AI interface definitions | BAR release |

## Risk Assessment

| Risk | Likelihood | Impact | Mitigation |
|------|-----------|--------|------------|
| Engine API changes in Recoil fork | Medium | High | Pin to specific engine version, abstract interface |
| Protobuf overhead too high for RL training | Low | Medium | Benchmark early, consider FlatBuffers fallback |
| Windows named pipe differences | Medium | Medium | TCP loopback fallback, test on both platforms |
| Thread safety in proxy | Medium | High | Single-threaded proxy (engine calls are sequential) |
| AI process startup timing | Medium | Low | Proxy waits with timeout on init(), configurable |
