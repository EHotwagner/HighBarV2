# Data Model: 028-adapt-test-harness

**Date**: 2026-04-07

## Entities

### SessionState (Discriminated Union)

Tracks the lifecycle stage of an engine session.

| State | Description | Valid transitions to |
|-------|-------------|---------------------|
| Idle | Initial state, no resources allocated | Starting |
| Starting | Engine launching, socket binding | Connected, Error |
| Connected | Handshake complete, ready for frame stepping | Running, Stopped |
| Running | Currently processing a frame | Connected, Stopped, Error |
| Stopped | All resources released | Idle |
| Error | Unrecoverable failure with diagnostic message | Stopped |

**Identity**: Singleton per EngineSession instance (mutable field).

### EngineConfig (Record)

Single source of truth for engine session configuration.

| Field | Type | Default | Override (env var) |
|-------|------|---------|-------------------|
| Mode | EngineMode (Headless/Graphical) | Headless | — |
| SocketPath | string | `/tmp/highbar-{guid}.sock` | — |
| MapName | string | from engine-version.json | `HIGHBAR_TEST_MAP` |
| GameType | string | from engine-version.json | — |
| EngineBin | string | `spring-headless` | `HIGHBAR_TEST_ENGINE` |
| DataDir | string option | auto-detected | `SPRING_DATADIR` |
| OpponentAI | string | `NullAI` | — |
| OpponentSide | string | `Cortex` | — |
| OurSide | string | `Armada` | — |
| AcceptTimeoutMs | int | 30000 | `HIGHBAR_TEST_TIMEOUT` (seconds × 1000) |
| ReadTimeoutMs | int | 10000 | `HIGHBAR_CLIENT_TIMEOUT_MS` |
| GameSpeed | int | 100 | — |
| ShutdownGraceMs | int | 5000 | — |

**Identity**: Value type (immutable record). New instance per session.
**Validation**: EngineBin must be non-empty. AcceptTimeoutMs and ReadTimeoutMs must be positive. MapName and GameType must be non-empty.
**Factory**: `EngineConfig.fromVersionFile(path)` loads defaults from `engine-version.json`, then applies environment variable overrides.

### EngineSession (Class — replaces duplicated harness state)

Encapsulates the full engine lifecycle.

| Field | Type | Mutability |
|-------|------|-----------|
| Config | EngineConfig | Immutable |
| State | SessionState | Mutable |
| EngineProcess | Process option | Mutable |
| ListenerSocket | Socket option | Mutable |
| ClientSocket | Socket option | Mutable |
| Stream | NetworkStream option | Mutable |
| SessionDir | string | Immutable (derived from Config.SocketPath) |
| PidFile | string | Immutable (derived from Config.SocketPath) |
| HandshakeInfo | HandshakeInfo option | Mutable |
| LastFrameNumber | int | Mutable (updated each frame) |

**Identity**: Reference type. One instance per engine lifecycle.
**Lifecycle**: Idle → Start() → [Connected] → Step()/Run() → Stop()
**Implements**: IDisposable (delegates to Stop())

### SessionDiagnostics (Record)

Collected when an error occurs or on demand.

| Field | Type | Description |
|-------|------|-------------|
| SessionDir | string | Path to session directory |
| SocketPath | string | Unix socket path |
| LastFrameNumber | int | Last successfully received frame |
| EngineExitCode | int option | Engine process exit code if exited |
| StdoutTail | string list | Last 50 lines of stdout.log |
| StderrTail | string list | Last 50 lines of stderr.log |
| InfologTail | string list | Last 50 lines of infolog.txt |

**Identity**: Value type (immutable record). Created on demand.

### EngineDisconnectedException (Exception)

Custom exception for engine communication failures.

| Field | Type | Description |
|-------|------|-------------|
| Message | string | Human-readable error description |
| LastFrameNumber | int option | Last successful frame number |
| Diagnostics | SessionDiagnostics option | Full diagnostic context |
| InnerException | exn option | Original exception if wrapping |

## Relationships

```
EngineConfig ──creates──> EngineSession
EngineSession ──tracks──> SessionState
EngineSession ──owns──> Process, Socket, NetworkStream
EngineSession ──produces──> SessionDiagnostics (on error)
EngineSession ──throws──> EngineDisconnectedException (on disconnect)

EngineFixture ──wraps──> EngineSession (thin adapter for xUnit IAsyncLifetime)
PersistentEngineFixture ──wraps──> EngineSession (adds state reset logic)
GameOrchestrator ──creates──> EngineSession (per-game lifecycle)
```
