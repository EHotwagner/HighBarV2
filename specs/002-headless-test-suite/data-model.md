# Data Model: Headless Test Suite

**Feature**: 002-headless-test-suite | **Date**: 2026-04-02

## Entities

### EngineInstance

Represents a running headless BAR engine process managed by the test harness.

| Field | Type | Description |
| ----- | ---- | ----------- |
| processId | int | OS process ID of the `spring-headless` process |
| socketPath | string | Unix domain socket path for this instance |
| pidFilePath | string | Path to PID file for cleanup |
| startTime | DateTime | When the engine was launched |
| state | EngineState | Current lifecycle state |

**States**: `Starting` → `WaitingForSocket` → `Ready` → `Running` → `ShuttingDown` → `Stopped`

**Transitions**:
- `Starting → WaitingForSocket`: Process spawned, waiting for socket to appear
- `WaitingForSocket → Ready`: Socket exists and accepts connections
- `Ready → Running`: Client connected and handshake complete
- `Running → ShuttingDown`: Test complete or failure, SIGTERM sent
- `ShuttingDown → Stopped`: Process exited, resources cleaned up
- Any → `Stopped`: On timeout or fatal error (SIGKILL + cleanup)

### TestScenario

Defines the game configuration for a set of tests.

| Field | Type | Description |
| ----- | ---- | ----------- |
| name | string | Scenario identifier (e.g., "minimal-builder") |
| mapName | string | BAR map to load |
| teams | Team list | Team definitions |
| aiAssignment | int | Which team index gets the HighBarV2 AI |
| startScript | string | Path to Lua startscript |

### TestReport

A structured document capturing development iteration knowledge.

| Field | Type | Description |
| ----- | ---- | ----------- |
| id | string | Sequential number (e.g., "001") |
| title | string | Short description of the report topic |
| date | date | When the report was written |
| iteration | int | Development iteration number |
| sections | ReportSection list | Structured content sections |

**Report sections**: Context, Problem, Investigation, Root Cause, Solution, Hypotheses, Lessons Learned

### GameFrame

A single frame of data received from the engine (existing protocol entity, referenced here for test assertions).

| Field | Type | Description |
| ----- | ---- | ----------- |
| frameNumber | uint32 | Engine frame counter |
| events | EngineEvent list | Events in this frame |

### TestAssertion

Represents a single verification within a test.

| Field | Type | Description |
| ----- | ---- | ----------- |
| description | string | What is being checked |
| expected | string | Expected value or condition |
| actual | string | Observed value |
| passed | bool | Whether assertion passed |

## Relationships

```
EngineInstance 1──* TestScenario     (engine runs one scenario at a time)
TestScenario   1──* GameFrame        (scenario produces frames over its lifetime)
GameFrame      1──* EngineEvent      (each frame contains batched events)
TestReport     *──* TestScenario     (reports may reference multiple scenarios)
```

## Validation Rules

- `EngineInstance.socketPath` must not already exist when starting (or must be cleaned up first)
- `EngineInstance.processId` must correspond to a running process while state is `Ready` or `Running`
- `TestScenario.mapName` must be a valid installed BAR map
- `TestReport.id` must be unique and sequential
- `GameFrame.frameNumber` must increase monotonically across received frames
