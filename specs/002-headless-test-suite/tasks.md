# Tasks: Headless Test Suite

**Input**: Design documents from `/specs/002-headless-test-suite/`
**Prerequisites**: plan.md (required), spec.md (required for user stories), research.md, data-model.md, quickstart.md

**Tests**: This feature IS a test suite. Tasks create tests as their primary output -- no separate "test tasks" needed.

**Organization**: Tasks are grouped by user story to enable independent implementation and testing of each story.

## Format: `[ID] [P?] [Story] Description`

- **[P]**: Can run in parallel (different files, no dependencies)
- **[Story]**: Which user story this task belongs to (e.g., US1, US2, US3)
- Include exact file paths in descriptions

## Phase 1: Setup (Shared Infrastructure)

**Purpose**: Create the test project structure, build scripts, and shared configuration

- [X] T001 Create F# xUnit test project at tests/integration/fsharp/HighBar.Tests.fsproj with dependencies: xUnit, xUnit.runner.visualstudio, Microsoft.NET.Test.Sdk, and project reference to clients/fsharp/HighBar.Client.fsproj
- [X] T002 [P] Create engine lifecycle shell script at tests/fixtures/start-headless.sh that accepts socket path as argument, launches spring-headless with a startscript, writes PID to a file, and exits. Script must set HIGHBAR_SOCKET_PATH env var for the engine.
- [X] T003 [P] Create engine shutdown shell script at tests/fixtures/stop-headless.sh that reads PID file, sends SIGTERM, waits 5s, sends SIGKILL if needed, removes socket file and PID file
- [X] T004 [P] Create minimal Lua startscript at tests/fixtures/game-setup.lua that defines a small map, 2 teams (HighBarV2 AI on team 0, null/passive AI on team 1), and 1 builder unit per team
- [X] T005 Create reports directory at reports/ with a report template file at reports/TEMPLATE.md containing sections: Date, Iteration, Context, Problem, Investigation, Root Cause, Solution, Hypotheses, Lessons Learned
- [X] T006 [P] Create test suite README at tests/README.md documenting prerequisites (spring-headless, proxy plugin, .NET 10, protobuf codegen), how to run tests, configuration env vars, and troubleshooting tips per quickstart.md

---

## Phase 2: Foundational (Blocking Prerequisites)

**Purpose**: Engine harness that ALL test stories depend on -- must work before any tests can run

**CRITICAL**: No user story work can begin until this phase is complete

- [X] T007 Implement F# EngineFixture class at tests/integration/fsharp/Harness.fs implementing IAsyncLifetime (xUnit). Constructor: generate unique socket path (/tmp/highbar-test-{guid}.sock). InitializeAsync: check for and remove stale socket, invoke start-headless.sh via System.Diagnostics.Process, poll for socket file existence with configurable timeout (default 30s from HIGHBAR_TEST_TIMEOUT env var), then verify socket accepts connection. DisposeAsync: invoke stop-headless.sh, verify process exited and socket removed.
- [X] T008 Implement xUnit collection definition at tests/integration/fsharp/Harness.fs (same file) that uses [Collection("Engine")] to serialize all engine-dependent test classes against a single shared EngineFixture via ICollectionFixture<EngineFixture>
- [X] T009 Write a single smoke test at tests/integration/fsharp/ConnectionTests.fs that only verifies the engine starts and the socket becomes available within timeout. This validates the harness itself before any protocol tests. Mark with [Trait("Category", "Harness")].
- [X] T010 Write first iteration report at reports/001-harness-setup.md documenting: what engine binary was used, how the startscript was configured, any issues with socket timing, how stale socket cleanup works, and any environment-specific adjustments needed

**Checkpoint**: `dotnet test tests/integration/fsharp/ --filter "Category=Harness"` starts engine, verifies socket ready, shuts down cleanly -- passes reliably

---

## Phase 3: User Story 1 - Connection and Handshake Smoke Tests (Priority: P1) MVP

**Goal**: Prove the full communication chain: engine → proxy → socket → F# client → handshake → frame → response

**Independent Test**: `dotnet test tests/integration/fsharp/ --filter "Category=Connection"` passes with engine starting, handshake completing, one frame received, and clean shutdown

### Implementation for User Story 1

- [X] T011 [US1] Add connection test at tests/integration/fsharp/ConnectionTests.fs: test that HighBarClient(socketPath) connects successfully to the running engine's proxy socket. Use the shared EngineFixture for socket path. Mark [Trait("Category", "Connection")].
- [X] T012 [US1] Add handshake test at tests/integration/fsharp/ConnectionTests.fs: test that client.Handshake() completes and returns a Handshake message with protocol version 1, non-empty engine version string, non-empty map name, and valid team ID (>= 0).
- [X] T013 [US1] Add frame reception test at tests/integration/fsharp/ConnectionTests.fs: test that after handshake, calling client.Run() with a handler that captures the first GameFrame succeeds. Assert frame contains at least an Init event and frame number is 0 or 1.
- [X] T014 [US1] Add frame response test at tests/integration/fsharp/ConnectionTests.fs: test that client.Run() with a handler returning an empty command list completes without error for at least 3 consecutive frames. Verify frame numbers increment.
- [X] T015 [US1] Add graceful disconnect test at tests/integration/fsharp/ConnectionTests.fs: test that client.Disconnect() after receiving frames completes without throwing. Verify subsequent frames still flow to engine (engine doesn't crash).
- [X] T016 [US1] Write iteration report at reports/002-connection-tests.md documenting: handshake field values observed, frame timing, any protocol version issues, and whether the Init event contains expected team/map metadata.

**Checkpoint**: All Connection tests pass. The F# client can connect to, handshake with, and receive frames from the real engine. MVP validated.

---

## Phase 4: User Story 2 - Event Delivery Tests (Priority: P2)

**Goal**: Validate that real engine events arrive correctly in the F# client with properly populated fields

**Independent Test**: `dotnet test tests/integration/fsharp/ --filter "Category=Events"` passes with all naturally-occurring event types correctly parsed

### Implementation for User Story 2

- [X] T017 [P] [US2] Create event test file at tests/integration/fsharp/EventTests.fs with shared EngineFixture. Add helper that runs client for N frames and collects all received GameEvents into a list. Mark all tests [Trait("Category", "Events")].
- [X] T018 [US2] Add Init event test at tests/integration/fsharp/EventTests.fs: assert that the first frame contains a GameEvent.Init with a valid teamId (matching handshake team ID).
- [X] T019 [US2] Add Update event test at tests/integration/fsharp/EventTests.fs: run for 5 frames, assert every frame contains at least one GameEvent.Update with a frame number that matches the frame's frameNumber field.
- [X] T020 [US2] Add UnitCreated event test at tests/integration/fsharp/EventTests.fs: run for 10 frames, assert that at least one GameEvent.UnitCreated is received (from the builder unit spawned by game-setup.lua). Verify unitId > 0.
- [X] T021 [US2] Add UnitIdle event test at tests/integration/fsharp/EventTests.fs: run for 20 frames, assert that at least one GameEvent.UnitIdle is received (builder with no orders). Verify unitId matches a previously created unit.
- [X] T022 [US2] Add Unknown event resilience test at tests/integration/fsharp/EventTests.fs: run for 10 frames, verify that any events not explicitly handled by the client's GameEvent union are captured as Unknown without crashing the frame loop.
- [X] T022B [US2] Expand game-setup.lua at tests/fixtures/game-setup.lua to spawn opposing team units near each other so combat occurs naturally within the first 30 frames. Add at least one armed unit per team within engagement range.
- [X] T022C [US2] Add combat event tests at tests/integration/fsharp/EventTests.fs: run for 60+ frames with expanded game scenario, assert at least one GameEvent.UnitDamaged is received (verify unitId, damage > 0, attackerId present). Optionally assert EnemyEnterLOS if enemy units are in detection range. Mark [Trait("Category", "Events")].
- [X] T023 [US2] Write iteration report at reports/003-event-delivery.md documenting: which event types were observed naturally, timing of first UnitCreated event, any events that were expected but missing, and field value ranges observed.

**Checkpoint**: Init, Update, UnitCreated, UnitIdle, and UnitDamaged events all received and parsed correctly from the live engine.

---

## Phase 5: User Story 3 - Command Execution Tests (Priority: P2)

**Goal**: Send commands from F# client and verify the engine executes them via observable state changes

**Independent Test**: `dotnet test tests/integration/fsharp/ --filter "Category=Commands"` passes with at least 4 command types producing observable effects

### Implementation for User Story 3

- [X] T024 [P] [US3] Create command test file at tests/integration/fsharp/CommandTests.fs with shared EngineFixture. Add helper that connects, handshakes, collects the first builder unit ID from UnitCreated events, and provides it for command tests. Mark all tests [Trait("Category", "Commands")].
- [X] T025 [US3] Add MoveCommand test at tests/integration/fsharp/CommandTests.fs: send MoveCommand to the builder unit with target coordinates far from spawn, run for 30+ frames, and verify via callback queries that unit position changes toward the target (at least one coordinate component differs from initial position by > 10 units).
- [X] T026 [US3] Add StopCommand test at tests/integration/fsharp/CommandTests.fs: send MoveCommand to start movement, wait 5 frames, send StopCommand, wait 10 frames, query position twice with a gap and verify position is stable (delta < 1.0).
- [X] T027 [US3] Add BuildCommand test at tests/integration/fsharp/CommandTests.fs: identify a buildable unit def ID (from engine callbacks or hardcoded for test map), send BuildCommand to builder unit. Run for 60+ frames and verify a UnitCreated event for the building appears, or a CommandFinished event.
- [X] T028 [US3] Add PatrolCommand test at tests/integration/fsharp/CommandTests.fs: send PatrolCommand with waypoint coordinates, run 20+ frames, verify unit position changes (unit is moving along patrol route).
- [X] T029 [US3] Add GuardCommand, AttackCommand, RepairCommand, and FightCommand smoke tests at tests/integration/fsharp/CommandTests.fs: send each command targeting an appropriate unit (allied for Guard/Repair, enemy for Attack, area for Fight). Verify no protocol errors or crashes. For RepairCommand, target a damaged allied structure if available; for FightCommand, send with area coordinates.
- [X] T030 [US3] Add StopCommand for all-units test at tests/integration/fsharp/CommandTests.fs: send StopCommand to all known unit IDs, verify no errors.
- [X] T030B [US3] Create multi-step integration scenario test at tests/integration/fsharp/ScenarioTests.fs: test a full AI turn sequence -- connect, handshake, receive UnitCreated for builder, send MoveCommand to resource patch, send BuildCommand for factory, verify UnitCreated for factory, send StopCommand. Mark [Trait("Category", "Scenarios")]. This validates FR-009's "integration scenarios" layer.
- [X] T031 [US3] Write iteration report at reports/004-command-execution.md documenting: which commands produced observable effects, frame counts needed before effects were visible, any commands that failed silently, unit def IDs used for build tests, and whether the game scenario needs expansion.

**Checkpoint**: Move, Stop, Build, Patrol, Guard, Attack, Repair, and Fight commands tested. Multi-step scenario validated. At least 4 command types produce observable effects.

---

## Phase 6: User Story 4 - Callback Query Tests (Priority: P2)

**Goal**: Verify F# client can query live game state through the callback mechanism and receive correct values

**Independent Test**: `dotnet test tests/integration/fsharp/ --filter "Category=Callbacks"` passes with unit position, resource, and frame queries returning valid data

### Implementation for User Story 4

- [X] T032 [P] [US4] Create callback test file at tests/integration/fsharp/CallbackTests.fs with shared EngineFixture. Add helper to connect, handshake, and run through initial frames until a unit exists. Mark all tests [Trait("Category", "Callbacks")].
- [X] T033 [US4] Add unit position callback test at tests/integration/fsharp/CallbackTests.fs: query a known unit's position via callback, verify returned Vector3 has plausible coordinates (within map bounds, non-zero for at least one axis).
- [X] T034 [US4] Add team resources callback test at tests/integration/fsharp/CallbackTests.fs: query team metal and energy via callback, verify returned values are non-negative numbers.
- [X] T035 [US4] Add game frame callback test at tests/integration/fsharp/CallbackTests.fs: query current game frame number via callback, verify it matches or is close to the frame number received in the latest Frame message.
- [X] T036 [US4] Add invalid callback test at tests/integration/fsharp/CallbackTests.fs: issue a callback request with an invalid/unused callback ID, verify the response indicates an error or returns a default value without crashing the proxy or engine.
- [X] T037 [US4] Write iteration report at reports/005-callback-queries.md documenting: which callback IDs were tested, value ranges observed, any callbacks that returned unexpected results, and whether the client library's callback API needs improvements.

**Checkpoint**: Unit position, resource, and frame queries return plausible values. Invalid callback handled gracefully.

---

## Phase 7: User Story 5 - Python Client Tests (Priority: P3)

**Goal**: Port core scenarios to Python, validating cross-language protocol compatibility

**Independent Test**: `cd tests/integration/python && pytest` passes with Python client connecting, handshaking, receiving events, and sending commands against the live engine

### Implementation for User Story 5

- [X] T038 [US5] Create pytest configuration at tests/integration/python/conftest.py with session-scoped fixture that invokes the same start-headless.sh/stop-headless.sh scripts. Fixture yields the socket path and cleans up on teardown.
- [X] T039 [US5] Create Python connection tests at tests/integration/python/test_connection.py: test connect, handshake (verify protocol version, game metadata), receive first frame, send empty response, disconnect. Mirror the F# ConnectionTests.
- [X] T040 [P] [US5] Create Python event tests at tests/integration/python/test_events.py: test that Init, Update, UnitCreated events are received and correctly parsed into Python dataclass types. Verify field values match expectations.
- [X] T041 [P] [US5] Create Python command tests at tests/integration/python/test_commands.py: test MoveCommand and StopCommand execution. Verify unit position changes after MoveCommand (same approach as F# tests).
- [X] T042 [P] [US5] Create Python callback tests at tests/integration/python/test_callbacks.py: test unit position and resource callbacks return valid data.
- [X] T043 [US5] Write iteration report at reports/006-python-tests.md documenting: any differences in behavior between F# and Python clients, protobuf encoding differences if any, async vs sync client behavior, and cross-language compatibility assessment.

**Checkpoint**: Python client passes the same core scenarios as F# client. Both languages produce equivalent results.

---

## Phase 8: User Story 6 - Test Reports and Knowledge Base (Priority: P3)

**Goal**: Ensure the /reports folder is complete, well-organized, and useful as institutional memory

**Independent Test**: A developer can read the reports folder and understand the full history of test development without reading git history

### Implementation for User Story 6

- [X] T044 [US6] Review and consolidate all iteration reports in reports/ -- ensure each follows the template structure, add cross-references between related reports, and create an index at reports/README.md listing all reports with one-line summaries
- [X] T045 [US6] Write a final summary report at reports/007-test-suite-overview.md documenting: total test count, coverage by category (connection, events, commands, callbacks), known limitations, recommended next steps for expanding coverage, and any open questions about engine behavior

**Checkpoint**: Reports folder contains complete documentation of the test development process.

---

## Phase 9: Polish & Cross-Cutting Concerns

**Purpose**: Improvements that affect multiple user stories

- [X] T046 [P] Expand game-setup.lua at tests/fixtures/game-setup.lua to include enemy units and structures if command tests (Phase 5) revealed the need for a richer game scenario
- [X] T047 [P] Add CI integration notes to tests/README.md documenting how to run the test suite in a CI environment (installing spring-headless, proxy plugin setup, timeouts)
- [X] T048 Verify full test suite runs end-to-end in under 60 seconds: `dotnet test tests/integration/fsharp/` and `cd tests/integration/python && pytest`. If over budget, investigate engine startup sharing or test parallelization.
- [X] T049 Run quickstart.md validation: follow specs/002-headless-test-suite/quickstart.md from scratch on a clean environment to verify all instructions are accurate and complete

---

## Dependencies & Execution Order

### Phase Dependencies

- **Setup (Phase 1)**: No dependencies - can start immediately
- **Foundational (Phase 2)**: Depends on T001 (fsproj) and T002-T004 (shell scripts) from Setup
- **US1 Connection (Phase 3)**: Depends on Phase 2 (harness must work)
- **US2 Events (Phase 4)**: Depends on Phase 3 (connection must work to receive events)
- **US3 Commands (Phase 5)**: Depends on Phase 4 (need unit IDs from events to send commands)
- **US4 Callbacks (Phase 6)**: Depends on Phase 4 (need unit IDs from events to query)
- **US5 Python (Phase 7)**: Depends on Phase 3 (F# basics must be stable first); reuses harness from Phase 2
- **US6 Reports (Phase 8)**: Depends on all previous phases (consolidates reports written throughout)
- **Polish (Phase 9)**: Depends on all desired user stories being complete

### User Story Dependencies

- **US1 (P1)**: Can start after Foundational -- no dependencies on other stories
- **US2 (P2)**: Depends on US1 (needs working connection to receive events)
- **US3 (P2)**: Depends on US2 (needs event parsing to detect command effects)
- **US4 (P2)**: Depends on US2 (needs unit IDs from events to query via callbacks)
- **US5 (P3)**: Depends on US1 (F# basics must work first); can parallel with US3/US4
- **US6 (P3)**: Accumulates through all phases; final consolidation after all stories

### Within Each User Story

- Implementation tasks in sequence (each builds on the previous)
- Report task is last in each phase (captures what was learned)

### Parallel Opportunities

- T002, T003, T004, T006 can all run in parallel (Phase 1 setup scripts)
- T017 (EventTests file creation) can parallel with T024 (CommandTests file creation)
- T040, T041, T042 (Python tests) can run in parallel with each other
- US3 (Commands) and US4 (Callbacks) can run in parallel after US2 completes
- US5 (Python) can run in parallel with US3/US4

---

## Parallel Example: Phase 1 Setup

```bash
# Launch all independent setup tasks together:
Task T002: "Create start-headless.sh at tests/fixtures/start-headless.sh"
Task T003: "Create stop-headless.sh at tests/fixtures/stop-headless.sh"
Task T004: "Create game-setup.lua at tests/fixtures/game-setup.lua"
Task T006: "Create README at tests/README.md"
```

## Parallel Example: Phase 7 Python Tests

```bash
# After conftest.py and connection tests are done:
Task T040: "Create Python event tests at tests/integration/python/test_events.py"
Task T041: "Create Python command tests at tests/integration/python/test_commands.py"
Task T042: "Create Python callback tests at tests/integration/python/test_callbacks.py"
```

---

## Implementation Strategy

### MVP First (User Story 1 Only)

1. Complete Phase 1: Setup (project structure, scripts, fixtures)
2. Complete Phase 2: Foundational (engine harness, smoke test)
3. Complete Phase 3: User Story 1 (connection + handshake tests)
4. **STOP and VALIDATE**: `dotnet test --filter "Category=Connection"` passes reliably
5. Write first report documenting what was learned

### Incremental Delivery

1. Setup + Foundational → Engine harness works
2. US1 Connection → Full handshake cycle proven (MVP!)
3. US2 Events → Engine events received correctly
4. US3 Commands + US4 Callbacks (parallel) → Full bidirectional validation
5. US5 Python → Cross-language compatibility proven
6. US6 Reports → Knowledge base consolidated
7. Polish → CI-ready, documented, optimized

---

## Notes

- [P] tasks = different files, no dependencies
- [Story] label maps task to specific user story for traceability
- Each user story is independently testable at its checkpoint
- Reports are written during each phase, not deferred to the end
- The iterative approach means early phases may reveal issues that change later phase plans
- If spring-headless is not available, document the blocker in a report and investigate the replay tool as a partial substitute
- Commit after each task or logical group using conventional commits (test:)
