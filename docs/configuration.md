# Configuration Reference

The HighBar V2 proxy is configured through Lua options (visible in the game lobby) and environment variables. Environment variables take precedence over Lua-defined values.

## Proxy Options (`AIOptions.lua`)

These options appear in the BAR game lobby when selecting the HighBar V2 AI:

| Option | Type | Default | Range | Description |
|--------|------|---------|-------|-------------|
| `socket_path` | string | `/tmp/highbar.sock` | — | Unix domain socket path for AI communication |
| `timeout_ms` | number | 25 | 1–1000 | Max time (ms) to wait for AI response per frame |
| `log_level` | number | 2 | 0–3 | Logging verbosity: 0=ERROR, 1=WARN, 2=INFO, 3=DEBUG |
| `frame_mode` | number | 1 | 0–1 | Event delivery: 0=INDIVIDUAL, 1=BATCHED |
| `push_state` | bool | false | — | Include game state snapshot with frame updates |
| `max_message_size` | number | 8388608 | 64KB–16MB | Maximum protobuf message size in bytes |
| `transport` | number | 0 | 0–1 | Transport type: 0=UNIX socket, 1=TCP loopback |
| `tcp_port` | number | 17432 | 1024–65535 | TCP port for loopback transport |

## Environment Variables

All options can be overridden via environment variables prefixed with `HIGHBAR_`:

| Variable | Overrides | Example |
|----------|-----------|---------|
| `HIGHBAR_SOCKET_PATH` | `socket_path` | `/tmp/my-ai.sock` |
| `HIGHBAR_TIMEOUT_MS` | `timeout_ms` | `100` |
| `HIGHBAR_LOG_LEVEL` | `log_level` | `3` (DEBUG) |
| `HIGHBAR_FRAME_MODE` | `frame_mode` | `0` (INDIVIDUAL) |
| `HIGHBAR_PUSH_STATE` | `push_state` | `true` |
| `HIGHBAR_MAX_MESSAGE_SIZE` | `max_message_size` | `4194304` |
| `HIGHBAR_TRANSPORT` | `transport` | `1` (TCP) |
| `HIGHBAR_TCP_PORT` | `tcp_port` | `9999` |

## Frame Modes

### BATCHED (default, `frame_mode=1`)

Events accumulate within a game frame. When the `UPDATE` event fires, all accumulated events are sent as a single `Frame` message. The AI responds once per game frame.

```
Engine frame:
  UnitCreated → accumulate
  UnitFinished → accumulate
  UPDATE → send Frame{events=[UnitCreated, UnitFinished, Update]}
  ← receive FrameResponse{commands=[...]}
```

This is the recommended mode. It reduces socket round-trips and allows the AI to see all events before deciding.

### INDIVIDUAL (`frame_mode=0`)

Each event is sent immediately as its own `Frame` message. The AI responds to each event independently.

This mode has higher socket overhead but may be useful for latency-sensitive applications or debugging.

## Transport Modes

### Unix Domain Socket (default, `transport=0`)

The proxy connects to a Unix domain socket at the configured path. This is the fastest option on Linux — no TCP overhead, no network stack.

The AI process must create and listen on the socket before the game starts:

```fsharp
let client = HighBarClient.AcceptFromProxy("/tmp/highbar.sock", 30000)
```

### TCP Loopback (`transport=1`)

The proxy connects to `127.0.0.1` on the configured TCP port. This is the cross-platform fallback — works on Windows where Unix sockets may not be available.

```bash
export HIGHBAR_TRANSPORT=1
export HIGHBAR_TCP_PORT=17432
```

## Log Levels

| Level | Value | Output |
|-------|-------|--------|
| ERROR | 0 | Critical failures only |
| WARN | 1 | Warnings and errors |
| INFO | 2 | Connection lifecycle, handshake, frame mode (default) |
| DEBUG | 3 | Per-frame details, command execution, position data |

Logs are written to the engine's AI log directory.

## Timeout Behavior

The `timeout_ms` setting controls how long the proxy waits for the AI process to respond to each frame:

- If the AI responds within the timeout: normal operation
- If the timeout expires: the proxy returns an error from `handleEvent`, and the engine may remove the AI

The default of 25ms leaves headroom within the 33ms frame budget (30fps).

## Config Loading Order

1. `hb_config_defaults()` sets compiled defaults
2. Engine info callback provides Lua-configured values
3. Environment variables override everything (`HIGHBAR_*`)

## Test Configuration

Tests use environment variables to configure engine and socket paths:

| Variable | Purpose | Default |
|----------|---------|---------|
| `HIGHBAR_TEST_ENGINE` | Path to engine binary | Auto-detected |
| `HIGHBAR_SOCKET_PATH` | Socket path for test games | `/tmp/highbar-test-{pid}.sock` |
| `HIGHBAR_TEST_MAP` | Map for test scenarios | `Comet Catcher Remake` |
| `SPRING_DATADIR` | Engine data directory | Auto-detected from engine path |

See also: [Proxy Reference](proxy-reference.md) | [Getting Started](getting-started.md)
