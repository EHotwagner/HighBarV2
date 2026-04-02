# Feature Specification: Headless Test Suite

**Feature Branch**: `002-headless-test-suite`  
**Created**: 2026-04-02  
**Status**: Draft  
**Input**: User description: "create iteratively a comprehensive test suite for highBarV2 using a headless bar server. test basic functionality and branch from there when everything works. create a /reports folder where you create reports describing problems encountered, solved, hypothesis and general important relevant knowledge."

## Clarifications

### Session 2026-04-02

- Q: Is the headless server a new mock to build, or the real BAR engine? → A: The real BAR engine running in headless mode. These are live integration tests against the actual game engine and C proxy plugin.
- Q: Does the test suite manage the engine lifecycle or expect it pre-running? → A: The test suite starts/stops the headless engine automatically (self-contained and reproducible).
- Q: Which client language to start with? → A: F# first, add Python tests after F# basics work.

## User Scenarios & Testing *(mandatory)*

### User Story 1 - Connection and Handshake Smoke Tests (Priority: P1)

A developer runs the test suite, which automatically launches a headless BAR engine instance with the HighBarV2 proxy plugin loaded. The suite validates the most fundamental operations: the proxy opens a Unix domain socket, an F# test client connects, completes a handshake with correct protocol version exchange, receives a single frame of events (Init + Update), and sends back an empty command response. If this works, the full stack -- engine, proxy, socket, client -- is proven sound.

**Why this priority**: Without a working connection through the real engine, no other test can execute. This proves the entire communication chain end-to-end.

**Independent Test**: Can be fully tested by launching the headless engine, connecting the F# client, performing a handshake, receiving one frame, and verifying the round-trip completes without error.

**Acceptance Scenarios**:

1. **Given** the test suite is invoked, **When** it launches the headless BAR engine, **Then** the engine starts, loads the proxy plugin, and opens a socket within a configurable startup timeout.
2. **Given** the engine is running, **When** the F# test client connects to the proxy socket, **Then** the connection is established successfully.
3. **Given** a connected client, **When** it sends a HandshakeResponse with matching protocol version, **Then** the proxy accepts the handshake and returns game metadata (engine version, map name, team ID, ally team ID).
4. **Given** a handshake is complete, **When** the proxy sends a Frame containing an Init event followed by an Update event, **Then** the client receives and can parse both events correctly.
5. **Given** a received frame, **When** the client sends a FrameResponse with zero commands, **Then** the proxy accepts the response and the game advances to the next frame.
6. **Given** tests complete (pass or fail), **When** the suite finishes, **Then** the headless engine process is cleanly shut down and the socket is removed.

---

### User Story 2 - Event Delivery Tests (Priority: P2)

A developer runs event delivery tests to verify that the real engine produces the expected event types during gameplay and that the F# client correctly parses them. The test suite sets up game scenarios (e.g., spawning units, triggering combat) that cause the engine to emit specific event types, then validates the client receives correctly typed events with populated fields.

**Why this priority**: Event delivery is the core inbound data path. Once the connection works, validating that real engine events arrive correctly through the proxy serialization layer is the next critical step.

**Independent Test**: Can be tested by running targeted game scenarios in the headless engine and verifying the F# client receives the expected event types with correct field values.

**Acceptance Scenarios**:

1. **Given** a running headless game, **When** the engine emits Init, Update, and UnitCreated events during normal startup, **Then** the F# client receives each as its correctly typed representation with all fields populated.
2. **Given** units exist in the game, **When** gameplay causes UnitDamaged, UnitDestroyed, or EnemyEnterLOS events, **Then** the client receives them with correct unit IDs, damage values, and attacker references.
3. **Given** the engine produces events the client does not explicitly handle, **When** the client receives them, **Then** they are captured as Unknown events without crashing.

---

### User Story 3 - Command Execution Tests (Priority: P2)

A developer runs command tests to verify that commands sent from the F# client are correctly received and executed by the real engine through the proxy. The test validates that units actually move, build, attack, and perform other actions in response to commands.

**Why this priority**: Command execution is the core outbound control path. An AI that can receive events but not issue commands is useless.

**Independent Test**: Can be tested by sending specific commands (move, build, attack, stop) and observing the resulting engine events that confirm the commands were executed (e.g., unit position changes, CommandFinished events).

**Acceptance Scenarios**:

1. **Given** a unit exists in the headless game, **When** the client sends a MoveCommand with target coordinates, **Then** subsequent frames show the unit's position changing toward the target (observable via callbacks or events).
2. **Given** a builder unit exists, **When** the client sends a BuildCommand, **Then** the engine emits a UnitCreated event for the new structure or a CommandFinished event.
3. **Given** a unit exists, **When** the client sends a StopCommand, **Then** the unit ceases its current activity.
4. **Given** the client sends each of the core command types (move, build, patrol, attack, guard, stop, repair, fight), **Then** no command produces a protocol error or crash.

---

### User Story 4 - Callback Query Tests (Priority: P2)

A developer runs callback tests to verify that the F# client can query live game state from the engine -- unit positions, resource levels, map data -- via the callback mechanism, and receives correct values reflecting actual game state.

**Why this priority**: Callbacks are essential for AI decision-making. An AI that cannot query game state is blind.

**Independent Test**: Can be tested by issuing callback requests for known game state and verifying the returned values match the actual state of the headless game.

**Acceptance Scenarios**:

1. **Given** a unit exists at a known position, **When** the client queries its position via callback, **Then** the returned Vector3 matches the unit's actual coordinates in the engine.
2. **Given** the game is running, **When** the client queries team resource levels, **Then** the returned values reflect actual metal and energy amounts.
3. **Given** the client issues a callback with an invalid callback ID, **Then** the response indicates an error without crashing the proxy or engine.

---

### User Story 5 - Python Client Tests (Priority: P3)

After the F# test suite is stable, a developer adds equivalent Python client tests running against the same headless engine. The same scenarios (connect, handshake, events, commands, callbacks) are validated through the Python client to ensure cross-language compatibility.

**Why this priority**: Python is the secondary client. Verifying it works against the real engine catches language-specific serialization bugs that unit tests might miss.

**Independent Test**: Can be tested by running the Python test suite against the headless engine and comparing results to the established F# baselines.

**Acceptance Scenarios**:

1. **Given** the headless engine is running, **When** the Python client connects and handshakes, **Then** it succeeds with the same protocol exchange as the F# client.
2. **Given** identical game scenarios, **When** both F# and Python clients receive the same events, **Then** both produce equivalent typed representations.
3. **Given** identical commands sent from both clients, **When** the engine processes them, **Then** both produce equivalent results.

---

### User Story 6 - Test Reports and Knowledge Base (Priority: P3)

A developer reviews the `/reports` folder after test development iterations to understand what problems were encountered, how they were resolved, what hypotheses were formed, and what knowledge was gained. Reports are structured documents that accumulate over the iterative development process.

**Why this priority**: The reports folder serves as institutional memory for the test development process, capturing debugging context, edge cases discovered, and lessons learned.

**Independent Test**: Can be verified by confirming that after each significant test development iteration, a report file exists with structured sections for problems, solutions, hypotheses, and knowledge.

**Acceptance Scenarios**:

1. **Given** a test development iteration encounters a problem, **When** the issue is investigated and resolved, **Then** a report is created documenting the problem, root cause, solution, and broader implications.
2. **Given** the reports folder, **When** a new developer reads it, **Then** they can understand the history of test development decisions and known edge cases without reading git history.

---

### Edge Cases

- What happens when the headless BAR engine fails to start within the startup timeout?
- How does the system handle the engine crashing mid-test?
- What happens when the proxy socket path already exists from a previous unclean shutdown?
- How does the system handle a client that sends a malformed handshake (wrong protocol version)?
- What happens when a frame response exceeds the maximum message size?
- How does the system handle timeout expiry during a callback request?
- What happens when the engine produces events faster than the client can process them?
- How does the test suite handle flaky failures caused by engine timing or load?

## Requirements *(mandatory)*

### Functional Requirements

- **FR-001**: The test suite MUST automatically launch a headless BAR engine instance with the HighBarV2 proxy plugin loaded before running tests.
- **FR-002**: The test suite MUST automatically shut down the headless engine and clean up the socket after tests complete (pass or fail).
- **FR-003**: The test suite MUST detect when the engine and proxy socket are ready before attempting client connections, with a configurable startup timeout.
- **FR-004**: The test suite MUST validate the full handshake protocol against the live engine, including protocol version negotiation and game metadata exchange.
- **FR-005**: The test suite MUST verify that the F# client correctly receives and parses engine events produced during real gameplay scenarios.
- **FR-006**: The test suite MUST verify that commands sent from the F# client are executed by the real engine, confirmed by observable state changes or events.
- **FR-007**: The test suite MUST verify that callback queries return values reflecting actual live game state.
- **FR-008**: The test suite MUST be runnable from a single entry point command.
- **FR-009**: Tests MUST be structured in layers: engine lifecycle tests first, then connection/handshake, then events, then commands, then callbacks, then integration scenarios.
- **FR-010**: Each test MUST produce a clear pass/fail result with descriptive failure messages including expected vs. actual values.
- **FR-011**: The system MUST create a `/reports` folder at the repository root containing structured markdown reports documenting problems, solutions, hypotheses, and knowledge gained during iterative test development.
- **FR-012**: Test reports MUST follow a consistent structure with sections for: date, context, problem description, investigation steps, root cause, solution, hypotheses, and lessons learned.
- **FR-013**: After F# tests are stable, equivalent Python client tests MUST be added covering the same core scenarios.
- **FR-014**: The test suite MUST handle unclean engine state (stale sockets, zombie processes) gracefully at startup.

### Key Entities

- **Headless BAR Engine**: The real Beyond All Reason game engine running in headless mode (no GUI), with the HighBarV2 C proxy plugin loaded. Managed as a subprocess by the test harness.
- **Test Scenario**: A defined game situation (e.g., spawn units, trigger combat) combined with expected protocol interactions and outcomes. Each scenario is independently executable.
- **Test Report**: A structured markdown document in `/reports` that captures the iterative development process, including problems, solutions, and knowledge.

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: The test suite can start a headless BAR engine, run a complete handshake, receive at least one frame, and shut down cleanly -- 100% reliably across 10 consecutive runs.
- **SC-002**: Core engine events (Init, Update, UnitCreated, UnitDestroyed, UnitDamaged) are received and correctly parsed by the F# client in live tests.
- **SC-003**: Core commands (move, build, stop, attack, guard, patrol) sent from the F# client produce observable effects in the engine.
- **SC-004**: Callback queries for unit position and team resources return values consistent with actual game state.
- **SC-005**: The full F# test suite runs to completion in under 60 seconds including engine startup and shutdown.
- **SC-006**: A developer unfamiliar with the project can run the full test suite using a single documented command.
- **SC-007**: The `/reports` folder contains at least one structured report per major test development iteration.

## Assumptions

- A headless BAR engine binary is available on the development machine and can be launched as a subprocess.
- The HighBarV2 proxy plugin (compiled shared library) is available and can be loaded by the headless engine via standard plugin configuration.
- The headless engine supports running scripted game scenarios (spawning units, advancing frames) without human input.
- F# is the primary test language; Python tests are added after F# basics are stable.
- Unix domain sockets are the primary transport for testing.
- Existing C-level unit tests (in `proxy/tests/`) remain the authority for C serialization correctness; this test suite validates the full end-to-end stack.
- The `/reports` folder is a project-level directory at the repository root.
- Test development follows an iterative approach: get basic connection tests working first, then expand coverage based on what's learned.
- Engine startup time may vary; tests must tolerate reasonable startup delays (configurable timeout).
