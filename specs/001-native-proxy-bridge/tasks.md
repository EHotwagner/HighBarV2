# Tasks: Native C Proxy Bridge

**Input**: Design documents from `/specs/001-native-proxy-bridge/`
**Prerequisites**: plan.md, spec.md, data-model.md, contracts/, research.md, quickstart.md

**Tests**: Included — the specification (SC-001, SC-002) and constitution (Principle IV: Test at the Boundary) explicitly require round-trip serialization tests and mock engine integration tests.

**Organization**: Tasks are grouped by user story to enable independent implementation and testing of each story.

## Format: `[ID] [P?] [Story] Description`

- **[P]**: Can run in parallel (different files, no dependencies)
- **[Story]**: Which user story this task belongs to (e.g., US1, US2, US3)
- Include exact file paths in descriptions

---

## Phase 1: Setup (Shared Infrastructure)

**Purpose**: Project initialization, build system, proto tooling

- [X] T001 Create project directory structure per plan.md: proto/, proxy/, clients/fsharp/, clients/python/, tools/echo-ai/, tools/replay/
- [X] T002 [P] Create CMakeLists.txt for proxy shared library with protobuf-c dependency, C11 standard, and shared library output named SkirmishAI in proxy/CMakeLists.txt
- [X] T003 [P] Create buf.yaml with PACKAGE and FIELD lint rules and buf.gen.yaml with protoc-gen-c, protoc-gen-csharp, and betterproto plugins in proto/buf.yaml and proto/buf.gen.yaml
- [X] T004 [P] Create AIInfo.lua with shortName=HighBarV2, interfaceShortName=C, interfaceVersion=0.1 in proxy/data/AIInfo.lua
- [X] T005 [P] Create AIOptions.lua with all configurable options (socket_path, timeout_ms, log_level, frame_mode, push_state, max_message_size, transport, tcp_port) per data-model.md ProxyConfig entity in proxy/data/AIOptions.lua
- [X] T006 [P] Create .gitignore entries for generated protobuf code (proto/gen/), build artifacts (build/), and .so/.dll files

**Checkpoint**: Build system configured, proto tooling ready, plugin metadata in place

---

## Phase 2: Foundational (Blocking Prerequisites)

**Purpose**: Core infrastructure that MUST be complete before ANY user story can be implemented

**⚠️ CRITICAL**: No user story work can begin until this phase is complete

- [X] T007 [P] Define common.proto with shared types: Vector3 (float x/y/z), UnitRef (int32 unit_id), CommandOptions (uint32 bitfield) in proto/highbar/common.proto
- [X] T008 [P] Define events.proto with EngineEvent oneof containing all 28 event variant messages with 1:1 field mapping to engine structs (use optional for sentinel fields like attacker_id) in proto/highbar/events.proto
- [X] T009 [P] Define commands.proto with AICommand oneof containing all 97 command variant messages with common base fields (unit_id, group_id, options, timeout) in proto/highbar/commands.proto
- [X] T010 [P] Define callbacks.proto with CallbackRequest/CallbackResponse messages, callback_id enum for 200+ engine callbacks, and typed CallbackParam/CallbackResult in proto/highbar/callbacks.proto
- [X] T011 [P] Define messages.proto with envelope messages: Handshake, HandshakeResponse, Frame (frame_number + repeated EngineEvent), FrameResponse (repeated AICommand), CallbackRequest/Response wrappers, Shutdown, SaveRequest/SaveResponse, LoadRequest per protocol contract in proto/highbar/messages.proto
- [X] T012 Run buf lint and buf generate to validate proto schemas and produce generated code for C, C#, and Python
- [X] T013 [P] Implement arena bump allocator (alloc, reset, destroy) with configurable capacity (default 1MB) using ProtobufCAllocator interface in proxy/include/highbar/arena.h and proxy/src/arena.c
- [X] T014 [P] Implement configuration loader that reads AIOptions from engine callback (Info_getValueByKey) with environment variable overrides for all ProxyConfig fields in proxy/include/highbar/config.h and proxy/src/config.c
- [X] T015 [P] Implement connection manager with Unix domain socket transport, non-blocking connect, length-prefixed send/recv (4-byte LE header), configurable timeout, message size validation (8MB cap), and SIGPIPE handling in proxy/include/highbar/connection.h and proxy/src/connection.c
- [X] T016 Implement proxy skeleton with init() (store callback, load config, create arena, connect socket, perform handshake with strict version match), release() (close socket, destroy arena), and handleEvent() dispatch stub in proxy/include/highbar/proxy.h and proxy/src/proxy.c
- [X] T017 [P] Implement mock engine harness providing a fake SSkirmishAICallback with controllable return values for unit positions, map data, and command execution in proxy/tests/mock_engine.c

**Checkpoint**: Proto schemas validated, generated code available, proxy skeleton connects and handshakes. Foundation ready — user story implementation can now begin.

---

## Phase 3: User Story 1 — External AI Receives Game Events (Priority: P1) 🎯 MVP

**Goal**: Forward all 28 engine event types from the proxy to the external AI process as protobuf messages over UDS

**Independent Test**: Start an external process that logs all received events, launch a BAR game with HighBar AI, and verify that all 28 event types arrive with correct data matching what happens in-game.

### Tests for User Story 1

- [X] T018 [P] [US1] Write round-trip serialization tests for all 28 event types: for each event, create an engine struct with known values, serialize to protobuf, deserialize back, and assert field equality including optional sentinel fields in proxy/tests/test_serialize.c
- [X] T019 [P] [US1] Write integration test that loads proxy via mock engine, sends a sequence of events covering all 28 types, connects a test socket client, and verifies each event arrives correctly serialized with frame batching in proxy/tests/test_roundtrip.c

### Implementation for User Story 1

- [X] T020 [US1] Implement event serialization for all 28 event types: for each EventTopic, cast void* data to the correct S*Event struct and populate the corresponding protobuf EngineEvent variant using arena allocation, mapping engine sentinel -1 to unset optional fields in proxy/include/highbar/serialize.h and proxy/src/serialize.c
- [X] T021 [US1] Implement frame batching in handleEvent(): accumulate serialized events per frame, on EVENT_UPDATE serialize Frame message (frame_number + repeated events), send over socket via length-prefixed write, reset arena after send in proxy/src/proxy.c
- [X] T022 [US1] Implement frame timeout handling: after sending Frame, wait for FrameResponse with non-blocking read and configurable timeout (default 25ms); on timeout log warning via engine logger and continue; on socket error return non-zero to trigger AI removal in proxy/src/proxy.c
- [X] T023 [US1] Implement backpressure handling: before socket write, check if socket is writable (non-blocking); if buffer full, drop frame events, log warning via engine logger callback, and continue to next frame in proxy/src/connection.c
- [X] T024 [US1] Implement disconnection detection: on send/recv failure (EPIPE, ECONNRESET, etc.), set connected=false, log error via engine logger, return non-zero from handleEvent() for one-shot AI removal in proxy/src/proxy.c
- [X] T025 [US1] Implement save/load protocol: on EVENT_LOAD, send LoadRequest with saved state blob to external process; on EVENT_SAVE, send SaveRequest, receive SaveResponse with serialized AI state, return to engine via handleEvent in proxy/src/proxy.c

**Checkpoint**: Proxy serializes and forwards all 28 event types (including save/load) to external AI process. Round-trip tests pass for all types. MVP functional — external process can observe the full game state.

---

## Phase 4: User Story 2 — External AI Issues Commands (Priority: P1)

**Goal**: Deserialize command batches from the external AI process and execute them via the engine's command interface

**Independent Test**: Write a simple AI that builds a factory on game start and orders the first unit to patrol. Verify in-game that the factory is built and the unit patrols.

**Dependencies**: Requires US1 (frame loop and socket communication must be working)

### Tests for User Story 2

- [X] T026 [P] [US2] Write deserialization tests for all 97 command types: for each command, create a protobuf AICommand with known values, deserialize to engine struct, and assert all fields match including options bitfield and timeout in proxy/tests/test_deserialize.c
- [X] T027 [US2] Write integration test using mock engine: send a FrameResponse with a batch of commands (move, build, patrol, attack) over test socket, verify proxy calls Engine_handleCommand with correct commandTopic and populated command structs in proxy/tests/test_roundtrip_commands.c

### Implementation for User Story 2

- [X] T028 [US2] Implement command deserialization for all 97 command types: for each AICommand oneof variant, extract fields and populate the corresponding engine command struct (SBuildUnitCommand, SMoveUnitCommand, etc.) with correct options bitfield and timeout in proxy/include/highbar/deserialize.h and proxy/src/deserialize.c
- [X] T029 [US2] Implement command execution in frame loop: after receiving FrameResponse, iterate over command batch, deserialize each AICommand, call Engine_handleCommand(skirmishAIId, -1, commandId, commandTopic, &commandStruct) for each; log warning and continue batch on individual command failure in proxy/src/proxy.c
- [X] T030 [US2] Implement frame timeout command skipping: when AI response exceeds timeout_ms, skip command processing for that frame entirely, log warning with frame number and elapsed time via engine logger in proxy/src/proxy.c

**Checkpoint**: Full bidirectional communication working. AI receives events and issues commands. Both P1 user stories complete — this is the core proxy loop.

---

## Phase 5: User Story 3 — External AI Queries Game State (Priority: P2)

**Goal**: Support callback queries allowing the external AI to invoke engine callback functions and receive typed responses within the frame window

**Independent Test**: Write an AI that queries unit positions, map size, and resource spots on each frame, and verify the returned values match the in-game state.

**Dependencies**: Requires US1 (connection + frame communication)

### Tests for User Story 3

- [X] T031 [P] [US3] Write callback dispatch tests using mock engine: send CallbackRequests for Unit_getPos, Map_getWidth, Map_getHeightMap, verify CallbackResponses contain correct typed results and that non-existent entity queries return success=false in proxy/tests/test_callbacks.c

### Implementation for User Story 3

- [X] T032 [US3] Implement callback dispatch table mapping callback_id enum values to corresponding SSkirmishAICallback function pointers, with parameter marshaling (int, float, string params to C function args) and result marshaling (int, float, float[3], const char*, byte array results to CallbackResult) in proxy/include/highbar/callbacks.h and proxy/src/callbacks.c
- [X] T033 [US3] Implement callback request handling in frame loop: after sending Frame and before reading final FrameResponse, support a request-response sub-loop where incoming CallbackRequests are dispatched, results sent as CallbackResponses, until the AI sends FrameResponse to signal end of frame in proxy/src/proxy.c
- [X] T034 [US3] Handle callback errors: when engine callback returns error or entity does not exist, return CallbackResponse with success=false and descriptive error_message; log at DEBUG level via engine logger in proxy/src/callbacks.c

**Checkpoint**: External AI can query any engine callback within the frame window. All P1+P2 core proxy functionality complete.

---

## Phase 6: User Story 4 — Client Library for AI Development (Priority: P2)

**Goal**: Provide typed client libraries for F# and Python with connection management, protobuf handling, and frame loop abstraction

**Independent Test**: Using the F# client library, connect to a running game, receive typed events via pattern matching, issue typed commands via builder functions, and verify the AI controls units in-game.

**Dependencies**: Requires proto schema (Phase 2). Integration testing requires US1+US2.

### Implementation for User Story 4

- [X] T035 [P] [US4] Create F# project with Google.Protobuf NuGet dependency and reference to generated C# protobuf code in clients/fsharp/HighBar.Client.fsproj
- [X] T036 [P] [US4] Create Python package with betterproto dependency and generated Python protobuf code in clients/python/pyproject.toml and clients/python/highbar/__init__.py
- [X] T037 [US4] Implement F# client connection manager: Unix socket connect, length-prefixed send/recv, handshake exchange, protocol version validation, graceful disconnect with lifecycle callbacks in clients/fsharp/src/Client.fs
- [X] T038 [US4] Implement F# typed event wrappers as discriminated unions mapping each EngineEvent oneof variant to an F# case with strongly-typed fields, plus pattern matching helpers in clients/fsharp/src/Events.fs
- [X] T039 [US4] Implement F# typed command builders as functions returning AICommand protobuf messages (MoveCommand, BuildCommand, PatrolCommand, AttackCommand, etc.) with named parameters in clients/fsharp/src/Commands.fs
- [X] T040 [US4] Implement F# frame loop abstraction: OnFrame callback receiving typed Frame with events, returning list of typed commands; handles recv/send/timeout/disconnect lifecycle in clients/fsharp/src/Client.fs
- [X] T041 [US4] Implement Python client connection manager: Unix socket connect (sync), length-prefixed send/recv, handshake, protocol version validation, graceful disconnect in clients/python/highbar/client.py
- [X] T042 [US4] Implement Python typed event wrappers with dataclass-style access to event fields from betterproto generated code, plus convenience which_event() helper in clients/python/highbar/events.py
- [X] T043 [US4] Implement Python typed command builders (MoveCommand, BuildCommand, PatrolCommand, etc.) as factory functions returning AICommand protobuf messages in clients/python/highbar/commands.py
- [X] T044 [US4] Implement Python async client variant with asyncio socket support and async frame loop (async for frame in client) in clients/python/highbar/client.py
- [X] T045 [US4] Create echo-ai test tool in F# that connects to proxy, logs all received events with types and field values, and responds with empty command batches — used for quickstart validation in tools/echo-ai/
- [X] T046 [US4] Create reference AI in F# that builds a factory on game start, produces units, and attacks nearest enemy — validates SC-005 end-to-end; include a Python port in tools/reference-ai/

**Checkpoint**: Both F# and Python developers can install client library, connect to a running game, receive typed events, and issue typed commands. Echo-AI tool validates end-to-end connectivity.

---

## Phase 7: User Story 5 — Replay Recording and Playback (Priority: P3)

**Goal**: Record all protobuf messages exchanged during a game session to a file for offline replay

**Independent Test**: Record a game session to file, then feed the recorded messages to an AI process without the engine running, and verify the AI receives identical events.

**Dependencies**: Requires US1+US2 (working protocol to record)

### Implementation for User Story 5

- [X] T047 [P] [US5] Define replay file format: header (protocol version, game metadata, timestamp), followed by sequence of records (frame_number, direction enum, message_length, serialized protobuf bytes) — document in a comment at top of replay module
- [X] T048 [US5] Implement replay recorder as an optional interceptor in the proxy connection layer: when recording is enabled via config, write all sent/received messages to a timestamped file with frame markers in proxy/src/connection.c (add recording hooks)
- [X] T049 [US5] Implement replay playback tool in F# that reads a recorded session file, connects to an AI process as if it were the proxy, and feeds events in original frame order with configurable pacing (real-time or fast-forward) in tools/replay/

**Checkpoint**: Game sessions can be recorded and replayed for offline AI development and debugging.

---

## Phase 8: User Story 6 — Multi-AI Team Control (Priority: P3)

**Goal**: Support a single external process controlling multiple AI teams via multiplexed connections with team ID routing

**Independent Test**: Start a game with two HighBar AI teams, connect a single external process, and verify that events from both teams arrive with correct team routing.

**Dependencies**: Requires US1+US2 (single-team working first)

### Implementation for User Story 6

- [X] T050 [US6] Extend Frame and FrameResponse messages in proto/highbar/messages.proto to include team_id field for message routing
- [X] T051 [US6] Implement multi-team socket multiplexing: when multiple proxy instances are loaded (one per team), they connect to the same socket path with team_id identification; the external process receives/sends messages tagged with team_id in proxy/src/connection.c and proxy/src/proxy.c
- [X] T052 [US6] Extend F# and Python client libraries to support multi-team mode: receive events tagged with team_id, dispatch to team-specific handlers, send commands with team routing in clients/fsharp/src/Client.fs and clients/python/highbar/client.py

**Checkpoint**: Single external process controls multiple AI teams. All user stories complete.

---

## Phase 9: Polish & Cross-Cutting Concerns

**Purpose**: Final validation, performance, and documentation

- [X] T053 [P] Add edge case handling for invalid socket path (check directory exists at init, return clear error), unknown protobuf fields (rely on protobuf-c default forward-compat behavior) in proxy/src/proxy.c and proxy/src/connection.c
- [X] T054 [P] Add TCP loopback fallback transport: when config transport=TCP, connect to 127.0.0.1:tcp_port instead of Unix socket; share all framing/protocol logic in proxy/src/connection.c
- [X] T055 [P] Add push-state support: when config push_state=true, query common game state (own unit positions, resources, visible enemies) via callbacks and include as additional fields in Frame message in proxy/src/proxy.c
- [X] T056 Run quickstart.md validation end-to-end: build proxy, install into BAR, generate client code, run echo-ai, verify events stream correctly
- [X] T057 Performance benchmarking: measure event serialization time, socket round-trip latency, command deserialization time, and total per-frame overhead against targets (<100us, <500us, <1ms total) using mock engine harness

---

## Dependencies & Execution Order

### Phase Dependencies

- **Setup (Phase 1)**: No dependencies — can start immediately
- **Foundational (Phase 2)**: Depends on Setup completion — BLOCKS all user stories
- **US1 (Phase 3)**: Depends on Foundational (Phase 2)
- **US2 (Phase 4)**: Depends on US1 (Phase 3) — needs working frame loop
- **US3 (Phase 5)**: Depends on US1 (Phase 3) — needs connection + frame communication
- **US4 (Phase 6)**: Depends on proto schema (Phase 2) for codegen; integration testing needs US1+US2
- **US5 (Phase 7)**: Depends on US1+US2 (Phase 3+4) — needs working protocol
- **US6 (Phase 8)**: Depends on US1+US2 (Phase 3+4) — needs single-team working
- **Polish (Phase 9)**: Depends on US1+US2 minimum; ideally all stories

### User Story Dependencies

```
Phase 1 (Setup)
    │
Phase 2 (Foundational) ─── BLOCKS ALL ───┐
    │                                      │
Phase 3 (US1: Events) ◄───────────────────┘
    │         │
    │         ├──► Phase 5 (US3: Callbacks)
    │         │
    │         ├──► Phase 6 (US4: Client Libs) [proto schema from Phase 2]
    │         │
Phase 4 (US2: Commands)
    │         │
    │         ├──► Phase 7 (US5: Replay)
    │         ├──► Phase 8 (US6: Multi-AI)
    │         │
Phase 9 (Polish)
```

### Within Each User Story

- Tests written first, verified to fail
- Core implementation (serialization/deserialization)
- Integration into frame loop
- Error handling and edge cases
- Checkpoint validation

### Parallel Opportunities

- **Phase 1**: T002, T003, T004, T005, T006 all parallel (different files)
- **Phase 2**: T007-T011 all parallel (different .proto files); T013-T015, T017 all parallel (different .c files)
- **Phase 3**: T018, T019 parallel (different test files); T023, T024 parallel after T020-T022
- **Phase 4**: T026, T027 parallel (different test files)
- **Phase 5**: US3 can start in parallel with US2 (both depend on US1 only)
- **Phase 6**: T035, T036 parallel (F# and Python setup); US4 proto-dependent work can start in parallel with US3
- **Phase 9**: T053-T055 all parallel (different concerns, different files)

---

## Parallel Example: User Story 1

```
# After Phase 2 completes, launch tests in parallel:
Task T018: "Round-trip serialization tests for all 28 events in proxy/tests/test_serialize.c"
Task T019: "Integration test with mock engine in proxy/tests/test_roundtrip.c"

# Then implement serialization (sequential — same files):
Task T020: "Event serialization for all 28 types in proxy/src/serialize.c"
Task T021: "Frame batching in proxy/src/proxy.c"

# Then error handling and save/load in parallel (different concerns):
Task T023: "Backpressure handling in proxy/src/connection.c"
Task T024: "Disconnection detection in proxy/src/proxy.c"
Task T025: "Save/load protocol in proxy/src/proxy.c"
```

## Parallel Example: User Story 4

```
# F# and Python setup can run in parallel:
Task T035: "F# project setup in clients/fsharp/HighBar.Client.fsproj"
Task T036: "Python package setup in clients/python/pyproject.toml"

# Then language-specific work can proceed in parallel:
  # F# track: T037 → T038 → T039 → T040
  # Python track: T041 → T042 → T043 → T044
```

---

## Implementation Strategy

### MVP First (User Stories 1+2 Only)

1. Complete Phase 1: Setup
2. Complete Phase 2: Foundational (CRITICAL — blocks all stories)
3. Complete Phase 3: User Story 1 (event forwarding)
4. **STOP and VALIDATE**: External process receives all 28 event types correctly
5. Complete Phase 4: User Story 2 (command execution)
6. **STOP and VALIDATE**: Bidirectional proxy loop working — AI can observe and act
7. Deploy/demo with raw protobuf client if ready

### Incremental Delivery

1. Setup + Foundational → Proto schema validated, build system working
2. US1 (Events) → AI can observe game state (first real value)
3. US2 (Commands) → AI can control units (core loop complete — **MVP!**)
4. US3 (Callbacks) → AI can query detailed state (competitive AI enabled)
5. US4 (Client Libs) → Developer experience dramatically improved
6. US5 (Replay) → Offline development and debugging
7. US6 (Multi-AI) → Self-play and RL training scenarios
8. Polish → Performance validated, edge cases hardened

### Parallel Team Strategy

With multiple developers:

1. Team completes Setup + Foundational together
2. Once Foundational is done:
   - Developer A: US1 → US2 (core proxy, sequential dependency)
   - Developer B: US4 client lib scaffolding (can start from proto schema)
3. Once US1 completes:
   - Developer A continues: US2
   - Developer C: US3 (callbacks — parallel with US2)
4. Once US1+US2 complete:
   - Developer A: US5 (replay)
   - Developer B: US4 integration testing
   - Developer C: US6 (multi-AI)

---

## Notes

- [P] tasks = different files, no dependencies on incomplete tasks
- [Story] label maps task to specific user story for traceability
- Each user story should be independently testable at its checkpoint
- Constitution mandates round-trip tests for all 28 event + 97 command types (Principle IV)
- Generated protobuf code MUST NOT be committed to version control (constitution)
- Conventional Commits format required for all commits (constitution)
- All proxy logging via engine logger callback — no stderr/stdout (clarification)
- Commit after each task or logical group
- Stop at any checkpoint to validate story independently
