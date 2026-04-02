# Protobuf IPC Patterns for Game AI Proxy

## Message Framing

Protobuf messages are **not self-delimiting**. The wire format does not encode message boundaries.

### Recommended: 4-Byte Length-Prefixed Framing

```
[4 bytes: uint32 little-endian message length] [N bytes: serialized protobuf]
```

- **Universally standard**: gRPC uses this pattern (with an extra compression flag byte)
- **Efficient**: No scanning/escaping. Reader knows exact byte count.
- **Library support**: C++ protobuf has `CodedOutputStream::WriteVarint32` / `CodedInputStream::ReadVarint32`; Java/Python have `writeDelimitedTo` / `parseDelimitedFrom`
- **Little-endian**: Matches x86 native order for zero-cost reads on same machine

### Alternatives (Not Recommended)
- **Delimiter-based** (newline/null): Requires escaping binary protobuf content
- **Fixed-size**: Wasteful and inflexible
- **Varint prefix**: Slightly more compact but harder to implement/debug

## Communication Patterns

### Pattern A: Synchronous Request/Response (Lock-Step)
Engine sends state, blocks waiting for commands. Simple, deterministic.
- **This is what Spring's native AI interface does**: `handleEvent()` is synchronous
- Downside: IPC latency on critical path

### Pattern B: Async Event Streaming (Two Streams)
Two unidirectional channels. Engine streams events, AI streams commands.
- Decouples timing but introduces state staleness

### Pattern C: Hybrid Frame-Synchronous (Recommended)
```
Engine: FrameUpdate{frame=N, events=[...], state=...} -->
                                                       <-- AI: CommandBatch{frame=N, commands=[...]}
Engine: FrameUpdate{frame=N+1, ...} -->
                                     <-- AI: CommandBatch{frame=N+1, ...}
```
- Engine sends `FrameUpdate` with all events for current frame
- AI responds with `CommandBatch` before frame deadline
- Mirrors Spring's existing `handleEvent -> return commands` flow
- Preserves determinism while batching efficiently

## Message Multiplexing

### Recommended: Protobuf `oneof` Envelope

```protobuf
message Envelope {
  uint64 sequence_id = 1;
  uint32 frame = 2;
  
  oneof payload {
    FrameUpdate frame_update = 10;
    CommandBatch command_batch = 11;
    CallbackRequest callback_request = 12;
    CallbackResponse callback_response = 13;
    Handshake handshake = 14;
    Shutdown shutdown = 15;
  }
}
```

- Type-safe, single `ParseFromArray` handles dispatch
- `oneof` generates `payload_case()` enum for efficient switching
- Used by SC2API, TensorFlow Serving, many production systems

### Alternative: Type Tag in Header
```
[4 bytes: length] [2 bytes: message type ID] [N bytes: protobuf]
```
- More flexible for adding types without recompile
- Less type-safe

### Not Recommended: `google.protobuf.Any`
- Runtime type URL resolution, slower, overkill for closed system

## Transport Comparison

| Mechanism | Latency | Bidirectional | Cross-Platform | Notes |
|-----------|---------|---------------|----------------|-------|
| Unix Domain Socket | ~5-20us | Native (SOCK_STREAM) | Unix only | **Best for Linux** |
| Named Pipe (FIFO) | ~5-20us | Need 2 pipes | Different APIs | Awkward open/close semantics |
| Windows Named Pipe | ~5-20us | Native (duplex) | Windows only | Best for Windows |
| TCP Loopback | ~20-50us | Native | Both | SC2API uses this |
| Shared Memory | ~1-5us | Manual | Different APIs | Overkill complexity |
| gRPC (over UDS) | ~100-500us | Native | Both | Framework overhead |

### Recommendation
- **Linux (primary)**: Unix domain sockets (SOCK_STREAM)
- **Windows**: Windows named pipes or TCP loopback fallback
- **Cross-platform simple**: TCP loopback 127.0.0.1 (what SC2API does)
- Keep protobuf layer completely transport-agnostic

## Performance Budget

- Spring runs at ~30 sim frames/second (33ms per frame)
- Named pipe/UDS round-trip: ~5-50us for < 4KB messages (negligible)
- Protobuf ser/deser: ~1-10us for < 1KB messages (negligible)
- **Bottleneck is AI computation, not transport**

### Optimization Techniques
- **Batch events per frame**: Single `FrameUpdate` with `repeated Event` field, not individual messages per event
- **Arena allocation**: Reuse protobuf memory across frames (C++ `Arena` class)
- **Pre-sized buffers**: Allocate read/write buffers once
- **Integer IDs everywhere**: Unit IDs, command types, player IDs as uint32, never strings on hot path
- **Delta updates**: Send only what changed each frame (with full snapshot mechanism for reconnection)
- **Pipe buffer sizing**: Linux default 64KB, increase to 1MB via `fcntl(F_SETPIPE_SZ)` for large states

## Error Handling

### Failure Modes
1. **AI process crash**: Pipe read returns EOF / broken pipe
2. **AI process hang**: No response within frame deadline
3. **Malformed message**: Length prefix mismatch or protobuf parse failure
4. **Buffer full**: Writer blocks if reader is slow

### Strategies
- **Frame timeout**: 25ms deadline for 33ms frame. Skip AI commands if missed, log warning
- **SIGPIPE handling**: `signal(SIGPIPE, SIG_IGN)`, handle `EPIPE` errors instead
- **Message validation**: Reject length prefix > max size (e.g., 16MB)
- **Graceful shutdown**: Define `Shutdown` message type, engine sends before closing
- **Failure recovery**: Detect broken pipe immediately, pause game or remove AI player

## Threading Model

### Engine Side (C/C++ Proxy Library)
1. Main game thread calls `handleEvent()` on the proxy
2. Proxy serializes event to protobuf
3. Writes to pipe (can be inline if fast enough, or dedicated I/O thread)
4. Waits for response with timeout
5. Deserializes `CommandBatch`, calls `Engine_handleCommand()` for each command

### AI Side (Any Language)
- **Simple**: Single-threaded event loop: read FrameUpdate -> process -> write CommandBatch
- **Advanced**: I/O thread + processing threads with SPSC ring buffer

### Lock-Free Communication
- SPSC ring buffer between game thread and I/O thread avoids locks
- Libraries: `folly::ProducerConsumerQueue`, `boost::lockfree::spsc_queue`

## Reference Architecture: SC2API

StarCraft II's API is the closest production precedent:
- Protobuf over WebSocket (TCP) for AI communication
- `Request` and `Response` messages with `oneof` for ~30 types
- Synchronous request/response per game step
- Full game state observation as large protobuf message each frame
- Actions batched into single `RequestAction`
- Open-source `.proto` files from Blizzard

Key adaptation for Spring: replace WebSocket with Unix domain socket and adopt the synchronous frame-lock-step pattern that Spring's `handleEvent` expects.
