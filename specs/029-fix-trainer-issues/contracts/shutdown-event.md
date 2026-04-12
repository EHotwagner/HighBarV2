# Contract: Shutdown Event on GameOver

**Feature**: 029-fix-trainer-issues
**User Story**: US3 — Proxy notifies surviving AI clients when the game ends
**Affected Requirements**: FR-009, FR-010, FR-011, FR-012, FR-018

## Surface

The proxy ↔ client wire surface for terminal session events. The protobuf message and reason enum are unchanged. The proxy adds a new code path that emits the existing `Shutdown` message in a previously-unhandled scenario.

## Before / After

### Before (broken)

```
Engine: Spring.GameOver fires (BAR's game_end.lua, allyteam wiped)
Engine → handleEvent(skirmishAIId, EVENT_RELEASE=2, &SReleaseEvent{reason=1})
Proxy   handleEvent: no EVENT_RELEASE branch → falls through to hb_serialize_event(...)
Client: receives an unrecognized serialized event, then continues normal frame loop
Bot:    keeps issuing commands until self-imposed frame limit (~30 seconds wall clock)
```

### After (fixed)

```
Engine: Spring.GameOver fires
Engine → handleEvent(skirmishAIId, EVENT_RELEASE=2, &SReleaseEvent{reason=1})
Proxy   handleEvent: EVENT_RELEASE branch → maps reason → builds Highbar__Shutdown
                  → sends ProxyMessage{ shutdown: { reason: GAME_OVER } }
                  → calls hb_conn_close(); state->conn.connected = false
Client: receives Shutdown message from socket buffer, then EOF on next read
        → existing EngineDisconnectedException path triggers
Bot:    receiveFrame loop terminates within ~1 frame of Spring.GameOver
```

## API Contract — wire (unchanged)

```proto
// proto/highbar/messages.proto
message Shutdown {
  ShutdownReason reason = 1;
}

enum ShutdownReason {
  SHUTDOWN_REASON_UNKNOWN    = 0;
  SHUTDOWN_REASON_GAME_OVER  = 1;
  SHUTDOWN_REASON_DISCONNECT = 2;
  SHUTDOWN_REASON_ERROR      = 3;
}

message ProxyMessage {
  oneof message {
    ...
    Shutdown shutdown = N;
  }
}
```

No schema change. The proxy reuses `SHUTDOWN_REASON_GAME_OVER` for all `EVENT_RELEASE` reasons in the terminal class (1, 2, 3 — game ended / team died / AI killed).

## API Contract — proxy (`proxy/src/proxy.c`)

### New `EVENT_RELEASE` branch in `handleEvent`

Inserted alongside the existing `EVENT_UPDATE` / `EVENT_SAVE` / `EVENT_LOAD` branches around lines 346-448:

```c
if (topicId == EVENT_RELEASE) {
    const struct SReleaseEvent *ev = (const struct SReleaseEvent *)data;
    int engine_reason = ev ? ev->reason : 0;

    Highbar__ShutdownReason proto_reason;
    switch (engine_reason) {
    case 1: case 2: case 3:
        proto_reason = HIGHBAR__SHUTDOWN_REASON__SHUTDOWN_REASON_GAME_OVER;
        break;
    case 4: case 5:
        proto_reason = HIGHBAR__SHUTDOWN_REASON__SHUTDOWN_REASON_ERROR;
        break;
    case 6:
        proto_reason = HIGHBAR__SHUTDOWN_REASON__SHUTDOWN_REASON_DISCONNECT;
        break;
    default:
        proto_reason = HIGHBAR__SHUTDOWN_REASON__SHUTDOWN_REASON_UNKNOWN;
    }

    if (g_state->conn.connected) {
        Highbar__Shutdown shutdown = HIGHBAR__SHUTDOWN__INIT;
        shutdown.reason = proto_reason;

        Highbar__ProxyMessage msg = HIGHBAR__PROXY_MESSAGE__INIT;
        msg.message_case = HIGHBAR__PROXY_MESSAGE__MESSAGE_SHUTDOWN;
        msg.shutdown = &shutdown;

        size_t len = highbar__proxy_message__get_packed_size(&msg);
        uint8_t *buf = malloc(len);
        if (buf) {
            highbar__proxy_message__pack(&msg, buf);
            hb_conn_send(&g_state->conn, buf, (uint32_t)len);
            free(buf);
        }
        hb_conn_close(&g_state->conn);
        g_state->conn.connected = false;
    }
    return 0;
}
```

### Invariants

- **Idempotent with existing `release()`**: when the engine subsequently calls `release(skirmishAIId)`, the existing path at lines 315-342 sees `g_state->conn.connected == false` and skips the duplicate Shutdown send. No double-emit. (Verify by reading `release()` and confirming it guards on `g_state->conn.connected`.)
- **Does not regress engine-AI-destroy path** (FR-011): when our own AI is destroyed (`reason = 3`), the engine still calls `release()` after the EVENT_RELEASE, and the existing socket-close-driven shutdown path remains the canonical signal for "our team died." The pre-fix behavior is preserved.
- **Single-threaded**: `handleEvent` is called sequentially by the engine per Constitution. No locking needed.
- **No heap allocation on the hot path**: `EVENT_RELEASE` fires once per session, not per frame, so `malloc` is acceptable here (matches the existing pattern in `release()`).

## API Contract — F# client (no change)

The bot's `Protocol.receiveFrame` already handles socket close cleanly via `EngineDisconnectedException`. The bot's frame loop simply needs to catch the exception and exit. No new client API surface required.

Optional ergonomic helper (deferred):

```fsharp
// Could add to BarClient.fs if convenient
type SessionEndReason =
    | GameOver
    | EngineDestroy
    | Crash

// catch EngineDisconnectedException, inspect last received Shutdown.reason if any
```

This is NOT required by FR-010 — the bot can already distinguish "got Shutdown then EOF" from "got EOF without Shutdown" by inspecting the message buffer.

## Test Contract

### C unit test (`proxy/tests/test_proxy.c` or extension of test_handle_event)

```c
TEST(test_handle_event_release_emits_shutdown) {
    setup_proxy_with_mock_socket();
    struct SReleaseEvent ev = { .reason = 1 };  // game ended
    int rc = handleEvent(0, EVENT_RELEASE, &ev);
    ASSERT_EQ(rc, 0);
    ASSERT_TRUE(mock_socket_received_shutdown());
    ASSERT_EQ(mock_socket_last_shutdown_reason(), SHUTDOWN_REASON_GAME_OVER);
    ASSERT_FALSE(g_state->conn.connected);
}

TEST(test_handle_event_release_does_not_double_emit) {
    setup_proxy_with_mock_socket();
    struct SReleaseEvent ev = { .reason = 1 };
    handleEvent(0, EVENT_RELEASE, &ev);  // emits once
    release(0);                            // existing path, must NOT re-emit
    ASSERT_EQ(mock_socket_shutdown_count(), 1);
}
```

### Live engine test (`tests/persistent/fsharp/T029_GameOverShutdown.fs`)

```fsharp
[<Fact>]
member _.``T029.3 GameOver fires Shutdown to surviving AI``() =
    // Setup: 1v1 headless, our team gets cheats, kill enemy commander
    engine.ResetGameState()
    let enemyCommanderId = engine.FindEnemyCommander()
    Cheats.killUnit client.Stream enemyCommanderId

    // Run frames; the bot should observe an EngineDisconnectedException
    // within ~300 frames (per SC-003)
    let mutable terminated = false
    let mutable frameCount = 0
    try
        engine.RunFrames(600, fun _ idx ->
            frameCount <- idx
            []
        ) |> ignore
    with
    | :? EngineDisconnectedException -> terminated <- true

    Assert.True(terminated, "bot should have observed termination")
    Assert.True(frameCount < 300, $"should have terminated within 300 frames, got {frameCount}")
```

This satisfies FR-018 and SC-003.

## See Also

For the complete Shutdown wire shape documentation — including message sequencing, all `ShutdownReason` trigger conditions, and recommended client handling patterns — see [030-proxy-contract-docs/contracts/shutdown-wire-shape.md](../../030-proxy-contract-docs/contracts/shutdown-wire-shape.md).
