# Feature Specification: Native C Proxy Bridge for Recoil Engine AI

**Feature Branch**: `001-native-proxy-bridge`
**Created**: 2026-04-02
**Status**: Draft
**Input**: User description: "Build a native C proxy shared library for the Recoil engine (Beyond All Reason) that forwards AI events and commands over protobuf-serialized Unix domain sockets to an external process, enabling AI development in any language."

## User Scenarios & Testing *(mandatory)*

### User Story 1 - External AI Receives Game Events (Priority: P1)

An AI developer starts their external AI process, launches a Beyond All Reason game with HighBar V2 selected as the AI opponent. The engine loads the proxy, connects to the external process, and begins forwarding all game events (unit created, unit destroyed, enemy spotted, frame updates, etc.) to the external process in real time. The developer sees structured, typed game events arriving at their process and can inspect game state as the match progresses.

**Why this priority**: Without event delivery, no external AI logic is possible. This is the foundational data pipeline that everything else depends on.

**Independent Test**: Start an external process that logs all received events, launch a BAR game with HighBar AI, and verify that all 28 event types arrive with correct data matching what happens in-game.

**Acceptance Scenarios**:

1. **Given** an external AI process is listening on a Unix domain socket, **When** the engine loads the HighBar proxy and a game begins, **Then** the proxy connects to the socket, completes a handshake (exchanging protocol version, game info, team assignment), and begins streaming game events.
2. **Given** a connected game session, **When** any of the 28 engine event types fires (unit created, unit destroyed, enemy enters LOS, etc.), **Then** the external process receives a correctly serialized protobuf message containing all fields from the corresponding engine C struct within the frame budget.
3. **Given** a connected game session using batched frame mode, **When** multiple events occur in a single frame, **Then** all events for that frame are batched into a single `FrameUpdate` message and delivered together.
4. **Given** a connected game session, **When** the external process is not running or crashes, **Then** the proxy detects the broken connection, logs an error, and returns an error code from `handleEvent()` so the engine can cleanly remove the AI.

---

### User Story 2 - External AI Issues Commands (Priority: P1)

An AI developer writes logic that responds to game events by issuing commands — ordering units to move, attack, build, patrol, etc. The external process sends command batches back through the socket, and the proxy deserializes and executes them via the engine's command interface. Units in-game respond to the AI's orders.

**Why this priority**: Receiving events without being able to act on them provides no value. Command execution is equally fundamental to event delivery.

**Independent Test**: Write a simple AI that builds a factory on game start and orders the first unit to patrol. Verify in-game that the factory is built and the unit patrols.

**Acceptance Scenarios**:

1. **Given** a connected game session, **When** the external AI sends a `CommandBatch` containing unit movement/combat commands, **Then** the proxy deserializes each command and executes it via `Engine_handleCommand()`, and the corresponding units visibly respond in-game.
2. **Given** a `CommandBatch` with command options (shift-queue, timeout), **When** the proxy executes the commands, **Then** the engine receives the correct command options and queues/executes commands accordingly.
3. **Given** the external AI sends an invalid command (e.g., commanding a unit that doesn't exist), **When** the proxy attempts execution, **Then** the engine returns an error code, the proxy logs a warning, and processing of remaining commands in the batch continues.
4. **Given** a frame update with a 25ms AI response budget, **When** the AI responds within budget, **Then** all commands execute in the same frame. **When** the AI exceeds the timeout, **Then** the proxy skips commands for that frame, logs a warning, and continues to the next frame.

---

### User Story 3 - External AI Queries Game State (Priority: P2)

An AI developer needs to query detailed game state that is not included in the pushed event stream — specific unit positions, map elevation data, pathfinding, unit definition lookups, build site validation. The external process sends callback query requests through the socket, and the proxy invokes the corresponding engine callback function and returns the result.

**Why this priority**: While a basic AI can operate on pushed events alone, competitive AI requires on-demand access to the full engine callback interface (200+ functions) for tactical decision-making.

**Independent Test**: Write an AI that queries unit positions, map size, and resource spots on each frame, and verify the returned values match the in-game state.

**Acceptance Scenarios**:

1. **Given** a connected game session, **When** the external AI sends a `CallbackRequest` for unit position, **Then** the proxy calls the corresponding callback and returns a `CallbackResponse` with the correct 3D coordinates.
2. **Given** a callback request for map data (heightmap, LOS map, resource map), **When** the proxy processes the request, **Then** it returns the map data as a byte array with correct dimensions, and the data matches the current in-game state.
3. **Given** multiple callback requests within a single frame's processing window, **When** the AI sends them sequentially, **Then** each request-response round-trip completes within the frame budget without blocking event delivery.
4. **Given** a callback request for a non-existent entity (e.g., destroyed unit), **When** the proxy calls the engine callback, **Then** it returns a `CallbackResponse` with `success=false` and a descriptive error message.

---

### User Story 4 - Client Library for AI Development (Priority: P2)

An AI developer installs a typed client library for their language of choice (F# as primary target, Python as secondary). The library handles connection management, protobuf deserialization, and provides a high-level frame loop abstraction so the developer can focus on AI logic rather than IPC plumbing.

**Why this priority**: While technically an AI can be built by reading/writing raw protobuf over a socket, a typed client library dramatically reduces the barrier to entry and development time.

**Independent Test**: Using the F# client library, connect to a running game, receive typed events via pattern matching, issue typed commands via builder functions, and verify the AI controls units in-game.

**Acceptance Scenarios**:

1. **Given** a developer with the F# client library installed, **When** they create a client, call connect, and enter the frame loop, **Then** they receive strongly-typed events and can return typed command responses using language-native constructs (discriminated unions, pattern matching).
2. **Given** a developer with the Python client library installed, **When** they use the client in a standard Python script, **Then** they can receive events and issue commands with the same capabilities as the F# client, with both synchronous and async API variants.
3. **Given** a connected client, **When** the game ends or the external process shuts down, **Then** the client handles disconnection gracefully, cleaning up socket resources and providing clear lifecycle callbacks.
4. **Given** a new version of the protobuf schema, **When** client libraries are regenerated from the `.proto` files, **Then** all typed wrappers automatically reflect the updated schema without manual code changes.

---

### User Story 5 - Replay Recording and Playback (Priority: P3)

An AI developer wants to record all protobuf messages exchanged during a game session to a file, then replay them to test AI logic without needing the engine running. This enables offline debugging, regression testing, and training data collection for machine learning.

**Why this priority**: This is a productivity multiplier but not required for core functionality. AI development and testing can proceed without replay capability.

**Independent Test**: Record a game session to file, then feed the recorded messages to an AI process without the engine running, and verify the AI receives identical events.

**Acceptance Scenarios**:

1. **Given** a game session with recording enabled, **When** protobuf messages are exchanged between proxy and AI, **Then** all messages (both directions) are written to a timestamped file in their serialized form with frame markers.
2. **Given** a recorded session file, **When** an AI developer starts the replay tool, **Then** the recorded events are fed to the AI process in the original frame order and timing, and the AI can respond with commands (which are captured but not executed).
3. **Given** a recorded session, **When** the developer uses the replay tool in fast-forward mode, **Then** frames are delivered as fast as the AI can process them without real-time pacing constraints.

---

### User Story 6 - Multi-AI Team Control (Priority: P3)

An AI developer wants a single external process to control multiple AI teams in the same game (e.g., for self-play training or allied AI coordination). The proxy supports multiplexed connections where messages are tagged with team IDs and routed to the appropriate AI instance.

**Why this priority**: Single-team AI is the baseline. Multi-team support is an advanced capability primarily needed for reinforcement learning self-play scenarios.

**Independent Test**: Start a game with two HighBar AI teams, connect a single external process, and verify that events from both teams arrive with correct team routing and commands can be issued to units of either team.

**Acceptance Scenarios**:

1. **Given** a game with multiple AI teams using HighBar, **When** a single external process connects, **Then** it receives events from all teams with clear team identification, and can issue commands targeting units on any of its controlled teams.
2. **Given** a multi-team session, **When** one team's AI logic takes longer to respond, **Then** other teams' frame processing is not blocked.

---

### Edge Cases

- What happens when the socket path specified in configuration is invalid or the directory does not exist?
- When a protobuf message exceeds the maximum message size (8MB), the proxy drops the message, logs an error, and continues processing. No disconnection or truncation.
- When the engine sends events faster than the external process can consume them (socket buffer full), the proxy drops that frame's events, logs a warning, and continues with the next frame. No blocking or unbounded buffering.
- How does the system handle the transition between load/save events where the external process needs to serialize/restore its own state?
- What happens when the proxy receives a protobuf message with unknown field numbers (forward compatibility)?

## Requirements *(mandatory)*

### Functional Requirements

- **FR-001**: System MUST implement a shared library exporting `init()`, `release()`, and `handleEvent()` conforming to the Recoil engine's Skirmish AI plugin interface.
- **FR-002**: System MUST serialize all 28 engine event types from their native struct representations to protobuf messages with 1:1 field mapping.
- **FR-003**: System MUST deserialize all 97 command types from protobuf messages back to the engine's command struct format and execute them via the engine's command execution interface.
- **FR-004**: System MUST communicate with external processes over Unix domain sockets using 4-byte little-endian length-prefixed protobuf framing. Maximum message size is 8MB; oversized messages are rejected and logged.
- **FR-005**: System MUST support a connection handshake exchanging protocol version, engine version, game metadata, and team assignment before any game events are sent. If the protocol versions do not match exactly, the proxy MUST refuse the connection with a clear error message.
- **FR-006**: System MUST support batched frame mode where all events for a single frame are aggregated into one message and the AI responds with commands for that frame.
- **FR-007**: System MUST support callback queries allowing the external process to invoke any of the 200+ engine callback functions and receive typed responses.
- **FR-008**: System MUST handle external process disconnection gracefully — detecting broken connections, logging the error, and returning an appropriate error code to the engine. The connection model is one-shot: if the external process crashes or disconnects, the AI is permanently removed from the game with no reconnection attempts.
- **FR-009**: System MUST enforce configurable frame timeouts (default 25ms) — if the AI does not respond in time, skip commands for that frame and continue.
- **FR-010**: System MUST read configuration from game configuration files (socket path, timeout, log level, frame mode, push-state options) with environment variable overrides. All proxy logging MUST use the engine's logging callback (infolog.txt) so output appears alongside standard engine diagnostics.
- **FR-011**: System MUST provide client libraries generated from protocol schema files for F# (.NET) and Python, with typed event/command abstractions and frame loop helpers.
- **FR-012**: System MUST provide a TCP loopback transport as a cross-platform fallback when Unix domain sockets are unavailable.
- **FR-013**: System MUST support optional push-state configuration where common game state (own unit positions, resources, visible enemies) is automatically included with frame updates.
- **FR-014**: System MUST handle load and save events by forwarding them to the external process so it can serialize/restore its own AI state.

### Key Entities

- **Proxy Library**: The shared library loaded by the engine as a Skirmish AI plugin. Manages socket connection, serialization, and command execution.
- **External AI Process**: Any process that connects via Unix socket, receives protobuf events, and returns protobuf commands. Language-agnostic.
- **Protocol Schema**: The message definition files defining all message types — the single source of truth for the protocol contract.
- **Client Library**: Language-specific thin wrapper over generated protocol code providing ergonomic APIs for AI developers.
- **Frame**: A single engine simulation tick (~33ms at 30fps). The fundamental unit of event batching and command execution.

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: All 28 event types are correctly forwarded from the engine to the external process with zero data loss or corruption, verified by round-trip serialization tests.
- **SC-002**: All 97 command types issued by the external process result in the correct in-game unit/engine behavior, verified by integration tests against a mock engine harness.
- **SC-003**: End-to-end proxy overhead (serialize + transport + deserialize + execute) adds less than 1ms per frame to game loop latency.
- **SC-004**: An AI developer can go from installing the client library to receiving game events and issuing commands in under 30 minutes, following the quickstart guide.
- **SC-005**: A simple reference AI (build a factory, produce units, attack) runs successfully in a live BAR game using both primary and secondary client libraries.
- **SC-006**: The proxy handles external process crashes gracefully in 100% of test cases — no engine crashes, no hangs, clean AI removal.
- **SC-007**: The system operates with zero engine source modifications — installable as a standard AI plugin into any BAR installation.

## Clarifications

### Session 2026-04-02

- Q: If the external AI process crashes mid-game and restarts, should the proxy attempt to reconnect? → A: One-shot connection — crash removes AI from game cleanly, no reconnection.
- Q: What happens when the engine sends events faster than the external process can consume them? → A: Drop that frame's events, log warning, continue next frame. No blocking or unbounded buffering.
- Q: What happens when protocol versions mismatch at handshake? → A: Strict match — connection refused with clear error message. No best-effort or partial compatibility.
- Q: Where does the proxy write log output? → A: Engine's logging callback (infolog.txt), alongside standard engine diagnostics.
- Q: How to handle protobuf messages exceeding the maximum size? → A: Reject (drop message, log error, continue). Maximum size is 8MB (raised from 4MB default).

## Assumptions

- The Recoil engine's Skirmish AI plugin interface remains stable across BAR engine updates.
- The engine calls event handlers synchronously and sequentially — no concurrent calls from multiple threads.
- Unix domain sockets are available on the primary target platform (Linux). TCP loopback provides Windows fallback.
- The external AI process is started before the game loads the proxy. The proxy connects to an already-listening socket.
- F# / .NET is the primary client language. Python is the secondary client language.
- Protocol buffer zero-default semantics are acceptable. The proxy translates engine sentinel values (e.g., -1 for "no attacker") to 0 in the protocol and documents this convention.
- Performance targets (< 1ms proxy overhead) are achievable with arena allocation and non-blocking I/O on modern hardware.
- Save/load support requires the external AI process to handle its own state serialization when notified via load/save events.
