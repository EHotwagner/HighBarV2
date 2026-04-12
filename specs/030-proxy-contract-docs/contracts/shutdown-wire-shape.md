# Contract: Shutdown Message Wire Shape

**Feature**: 030-proxy-contract-docs
**Satisfies**: FR-001, FR-002, FR-003, FR-006
**Supplements**: [029-fix-trainer-issues/contracts/shutdown-event.md](../../029-fix-trainer-issues/contracts/shutdown-event.md)

## Overview

The proxy signals end-of-match to connected clients by sending a `Shutdown` message. This document specifies the wire shape, message sequencing, reason mapping, and recommended client handling.

## Wire Shape

The Shutdown message is a **top-level `ProxyMessage` envelope**. It is NOT embedded as an `EngineEvent` inside a Frame's events list.

```protobuf
// proto/highbar/messages.proto
message ProxyMessage {
  oneof message {
    Frame frame = 1;
    Shutdown shutdown = 2;
    // ... other cases
  }
}

message Shutdown {
  ShutdownReason reason = 1;
}

enum ShutdownReason {
  SHUTDOWN_REASON_UNKNOWN    = 0;
  SHUTDOWN_REASON_GAME_OVER  = 1;
  SHUTDOWN_REASON_DISCONNECT = 2;
  SHUTDOWN_REASON_ERROR      = 3;
}
```

On the wire, a Shutdown message appears as:

```
ProxyMessage {
  message_case = Shutdown
  shutdown {
    reason = <ShutdownReason value>
  }
}
```

## Message Sequencing

The Shutdown message is sent:

1. **After** the final `ProxyMessage.Frame` of the match
2. **Before** the proxy closes the Unix domain socket

Between the last Frame and the Shutdown, the engine may process additional simulation frames (observed: up to ~30 frames in production). During this window the proxy does NOT emit further Frame messages because it only sends frames during `handleEvent(EVENT_UPDATE)`, and the engine is processing the game-over sequence.

The sequence is:

```
[Frame N]          ← last Frame with events (e.g., UnitDestroyed)
  ... engine processes game-over internally (no proxy I/O) ...
[Shutdown]         ← standalone ProxyMessage envelope
[socket close]     ← proxy calls close() on the connection
```

## Reason Mapping

The proxy maps the engine's `SReleaseEvent.reason` integer to a `ShutdownReason` protobuf enum value:

| Engine `SReleaseEvent.reason` | Engine meaning | Proto `ShutdownReason` | Proto int |
|---|---|---|---|
| 1 | Game ended (`Spring.GameOver` resolved) | `SHUTDOWN_REASON_GAME_OVER` | 1 |
| 2 | Team died (allyteam wiped / all units destroyed) | `SHUTDOWN_REASON_GAME_OVER` | 1 |
| 3 | AI killed (`.kickai` command or engine destroy) | `SHUTDOWN_REASON_GAME_OVER` | 1 |
| 4 | AI crashed (runtime error in AI callback) | `SHUTDOWN_REASON_ERROR` | 3 |
| 5 | Init failed (AI `init()` returned non-zero) | `SHUTDOWN_REASON_ERROR` | 3 |
| 6 | Connection lost (host player disconnected) | `SHUTDOWN_REASON_DISCONNECT` | 2 |
| Other | Unknown / undocumented engine reason | `SHUTDOWN_REASON_UNKNOWN` | 0 |

**Note**: Engine reasons 1, 2, and 3 all map to `GAME_OVER`. Clients cannot distinguish "game naturally ended" from "AI was kicked by host" at the `ShutdownReason` level. The engine infolog contains more detail if this distinction is needed.

## Trigger Conditions

### `SHUTDOWN_REASON_GAME_OVER` (reasons 1, 2, 3)

Emitted when the engine fires `EVENT_RELEASE` with reason 1, 2, or 3. This occurs when:

- **Reason 1 — Game ended**: `Spring.GameOver` fires because a win/loss condition resolved (BAR's `game_end.lua` detected allyteam elimination, or a scripted scenario declared a winner).
- **Reason 2 — Team died**: The AI's allyteam was wiped (all units destroyed). The engine fires this when the last unit belonging to the AI's team is destroyed.
- **Reason 3 — AI killed**: The engine destroys the AI instance, either via a host `.kickai` command or an internal engine decision to remove the AI.

In all three cases, the AI's session is over and no further commands will be accepted.

### `SHUTDOWN_REASON_ERROR` (reasons 4, 5)

Emitted when the engine fires `EVENT_RELEASE` with reason 4 or 5. This occurs when:

- **Reason 4 — AI crashed**: An AI callback (`handleEvent`, `update`, etc.) threw an unhandled error or returned a fatal error code. The engine removes the AI to prevent further crashes.
- **Reason 5 — Init failed**: The AI's `init()` callback returned a non-zero value during startup. The engine never ran the AI and is cleaning up.

These indicate a proxy or AI-process fault. The client should log the error and treat the session as failed.

### `SHUTDOWN_REASON_DISCONNECT` (reason 6)

Emitted when the engine fires `EVENT_RELEASE` with reason 6. This occurs when:

- **Reason 6 — Connection lost**: The AI's host player disconnected from the game without triggering `Spring.GameOver`. This can happen on a lobby crash, network drop, host `.quit` from spectator mode, or similar ungraceful exit.

The client should treat this as an abnormal termination where game outcome is indeterminate.

### `SHUTDOWN_REASON_UNKNOWN` (reason 0 / default)

Emitted when the engine fires `EVENT_RELEASE` with a reason value not in the 1-6 range, or when the `SReleaseEvent` pointer is null. This is a defensive fallback. Clients MUST handle this case gracefully (treat as abnormal termination).

## Client Handling

Clients MUST read all `ProxyMessage` envelopes from the socket, not just `Frame` messages. The recommended handling pattern:

1. **Read loop**: Continuously read length-prefixed `ProxyMessage` envelopes from the socket.
2. **Dispatch on `message_case`**:
   - `Frame` → process events, update game state, send commands
   - `Shutdown` → extract `reason`, transition to stopped state, stop sending commands
   - Unknown → log and ignore (forward compatibility)
3. **After receiving `Shutdown`**: The next read will return EOF (socket close). Do NOT rely on the socket close alone as the end-of-match signal — the `Shutdown` message carries the reason, which is lost if you only observe the EOF.

**Anti-pattern**: Do NOT model `Shutdown` as a `GameEvent` inside a `Frame`. The proxy does not embed Shutdown in Frame's event list. A client that only processes Frame events will never see the Shutdown reason and must fall back to detecting the socket close, losing the ability to distinguish GameOver from Error from Disconnect.
