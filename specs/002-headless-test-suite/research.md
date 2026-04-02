# Research: Headless Test Suite

**Feature**: 002-headless-test-suite | **Date**: 2026-04-02

## R1: Headless BAR Engine Launching

**Decision**: Use `spring-headless` binary with a Lua startscript to configure the game scenario.

**Rationale**: The Recoil/BAR engine supports a headless mode (`spring-headless` or `spring --headless`) that runs the full game simulation without rendering. This is the standard approach for dedicated servers and automated testing. The startscript (Lua) defines map, teams, AI assignments, and initial units.

**Alternatives considered**:
- **Replay tool as proxy substitute**: The existing `tools/replay/` can replay recorded `.hbrp` sessions, simulating the proxy side. This is useful for offline testing but does not exercise the real C proxy or engine, so it cannot serve as the primary test target. It could serve as a fallback when the engine is unavailable.
- **Mock server in F#/Python**: Would reimplement the protocol server-side. Rejected because the spec explicitly requires live integration tests against the real engine.

**Key findings**:
- The engine loads AI plugins from `~/.spring/AI/Skirmish/{AIName}/{Version}/`
- Plugin requires `SkirmishAI.so` + `AIInfo.lua` + `AIOptions.lua` in that directory
- Socket path is configured via `AIOptions.lua` (`socket_path` key) or `HIGHBAR_SOCKET_PATH` env var
- Engine startup takes 5-15 seconds depending on map size and system
- The `spring-headless` binary must be installed separately (BAR launcher or manual build)

## R2: F# Test Framework

**Decision**: Use xUnit with `IClassFixture<T>` for shared engine lifecycle management.

**Rationale**: xUnit is the standard .NET test framework, well-supported by `dotnet test`, and provides class fixtures for expensive shared setup (engine startup). NUnit and MSTest are viable alternatives but xUnit's fixture model maps naturally to "one engine instance per test class."

**Alternatives considered**:
- **NUnit**: Similar capabilities. xUnit preferred because the existing F# ecosystem leans toward xUnit.
- **Expecto**: F# native test framework. More idiomatic but less tooling integration with standard `dotnet test` pipeline.
- **Custom runner**: Unnecessary given xUnit's flexibility.

**Key findings**:
- `IClassFixture<EngineFixture>` starts engine once per test class, tears down after all tests in that class
- `ICollectionFixture<EngineFixture>` could share across multiple test classes (single engine for entire suite)
- xUnit runs test classes in parallel by default; use `[Collection("Engine")]` to serialize engine-dependent tests
- F# test methods use `[<Fact>]` or `[<Theory>]` attributes

## R3: Engine Lifecycle Management

**Decision**: Shell scripts (`start-headless.sh`, `stop-headless.sh`) managed by an F# `EngineFixture` class.

**Rationale**: Shell scripts are the simplest way to manage process lifecycle on Linux. The F# fixture wraps them, handles socket polling, and ensures cleanup on test failure. This separation means scripts can be reused by Python tests.

**Key details**:
- `start-headless.sh`: Accepts socket path as argument, starts `spring-headless` with startscript, writes PID to file, returns immediately
- Socket readiness polling: F# fixture checks for socket file existence + successful TCP/Unix connect, with configurable timeout (default 30s)
- `stop-headless.sh`: Reads PID file, sends SIGTERM, waits 5s, sends SIGKILL if needed, removes socket and PID files
- Stale socket cleanup: Harness removes existing socket file at startup if no process holds it

## R4: Game Scenario Configuration

**Decision**: Minimal Lua startscript defining a small map, 2 teams, and 1 builder unit per team.

**Rationale**: The smallest possible game that produces useful events. A builder unit naturally generates Init, Update, UnitCreated, UnitFinished, and UnitIdle events without any AI commands. More complex scenarios (combat, construction) are added iteratively as tests expand.

**Key details**:
- BAR startscripts are Lua files that configure `Spring.GetModOptions()`, teams, AI assignments, and map
- The startscript assigns the HighBarV2 AI to one team; the other team can be a passive/null AI
- Map: smallest available BAR map to minimize load time
- The startscript must specify `socket_path` in AI options to match the test harness

## R5: Python Test Framework

**Decision**: Use pytest with session-scoped fixtures for engine lifecycle.

**Rationale**: pytest is the standard Python test framework. Session-scoped fixtures provide the same shared-engine lifecycle as xUnit's class fixtures. The conftest.py pattern naturally shares the engine harness across all test files.

**Alternatives considered**:
- **unittest**: Standard library but less ergonomic. pytest preferred for fixture system and assertion introspection.

## R6: Test Isolation and Socket Management

**Decision**: Unique socket path per test run using temp directory + UUID suffix.

**Rationale**: Prevents test runs from interfering with each other or with a running game. If a previous test crashed without cleanup, the new test run creates a fresh socket path rather than fighting over the old one.

**Key details**:
- Socket path pattern: `/tmp/highbar-test-{uuid}.sock`
- Set via `HIGHBAR_SOCKET_PATH` environment variable before launching engine
- Both engine and client read from the same env var
- Harness cleans up socket and PID file in `finally`/`Dispose` block
