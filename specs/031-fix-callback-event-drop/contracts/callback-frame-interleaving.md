# Contract: Callback/Frame Interleaving

**Feature**: 031-fix-callback-event-drop
**Satisfies**: FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007
**Related**: [030-proxy-contract-docs/contracts/shutdown-wire-shape.md](../../030-proxy-contract-docs/contracts/shutdown-wire-shape.md)

## Overview

The HighBar proxy and its clients communicate over a single Unix domain socket that
carries both streaming `Frame` messages (push) and request/response `CallbackRequest`/
`CallbackResponse` pairs (pull). This document specifies the ordering guarantees the
proxy makes on that socket, the correlation mechanism clients MUST use, and the
required client-side behaviour for preserving event data when the two flows
interleave.

The contract is documented here because the FSBarV1 incident reported in
`Mailbox/2026-04-14_from_FSBarV1_mid-game-callback-event-drop.md` showed that
un-documented interleaving led to silent event loss in a client whose author had
reasonably assumed the proxy would not push a `Frame` during a pending callback.

## Wire Shape

Both `Frame` and `CallbackResponse` are top-level cases of the `ProxyMessage` oneof:

```protobuf
// proto/highbar/messages.proto
message ProxyMessage {
  oneof message {
    Frame frame                       = 1;
    Shutdown shutdown                 = 2;
    CallbackResponse callback_response = 3;
    // ... other cases
  }
}
```

Both messages are delivered as length-prefixed `ProxyMessage` envelopes on the same
socket in the same stream, using the existing framing layer. There is no second
socket, no out-of-band channel, and no envelope multiplexing header beyond the
`ProxyMessage` oneof itself.

## Ordering Rule (normative)

**The proxy MAY emit one or more `Frame` messages between the point at which it
receives a `CallbackRequest` from the client and the point at which it sends the
corresponding `CallbackResponse`.**

Specifically:

1. The client sends `CallbackRequest { request_id = R }`.
2. Before the proxy has enqueued the matching `CallbackResponse { request_id = R }`,
   the engine's `handleEvent(EVENT_UPDATE)` may fire, causing the proxy to emit one
   or more `Frame` messages on the socket.
3. After zero or more such `Frame` messages, the proxy emits
   `CallbackResponse { request_id = R }`.

The proxy does NOT guarantee that a `CallbackResponse` is the next message after its
matching `CallbackRequest`. The proxy DOES guarantee that the `CallbackResponse` for
request id R is sent eventually (unless the match ends first, in which case the
client receives a `Shutdown` — see `shutdown-wire-shape.md`).

## Correlation Rule (normative)

`CallbackResponse.request_id` **echoes** `CallbackRequest.request_id` verbatim. It is
the **only** correlation mechanism between a request and its response. Clients MUST
NOT rely on message ordering to pair requests and responses.

In the current single-client, single-in-flight model there is at most one outstanding
`CallbackRequest` per connection, so the `request_id` in the next `CallbackResponse`
is always the same as the request id the client most recently sent. Clients MUST
still verify the match as a defensive protocol check.

The proxy populates `CallbackResponse.request_id` on every response path (verified
in `proxy/src/callbacks.c` helpers `make_int_response`, `make_float_response`,
`make_vec3_response`, `make_string_response`, `make_int_array_response`,
`make_float_array_response`, `make_error_response`).

## Conforming Client Behaviour (normative)

A conforming client implementing a `SendCallback(request) → response` API MUST:

1. **Send the request** with a unique, monotonically-increasing `request_id`.
2. **Read messages** from the socket until it observes a `CallbackResponse`.
3. For every `Frame` message observed during that wait, the client MUST:
   a. **Acknowledge** the frame by sending a `FrameResponse` with an empty `commands`
      list (so the proxy does not stall).
   b. **Preserve** the frame's `frame_number` and every decoded event in a FIFO
      replay buffer owned by the client instance.
4. For every `SaveRequest` message observed during that wait, the client MUST
   respond with an empty `SaveResponse` as it would outside a callback wait.
5. When a `CallbackResponse` is observed, the client MUST:
   a. **Verify** that `CallbackResponse.request_id` equals the request id sent in
      step 1. If not, raise a protocol error (`HighBarProtocolException` in the F#
      reference client).
   b. Return the response to the caller.
6. On the **next** frame-consuming API call (`Run`, `StepFrame`, or equivalent),
   the client MUST **drain the replay buffer FIFO** before reading from the socket.
   Each drained `PendingFrame` MUST invoke the bot's frame handler exactly once, in
   enqueue order, with the original `frame_number`, and the handler's returned
   commands MUST be transmitted to the proxy in a `FrameResponse`.

### Non-conforming behaviour (explicit)

A client that observes a `Frame` during a callback wait and **discards the frame's
events** without adding them to the replay buffer is **non-conforming**. The FSBarV1
`Protocol.sendCallback` shortcut commented in FSBarV1 commit `775c73f` (2026-04-12)
and the matching HighBar.Client wildcard `| Frame _ ->` branch that existed on
`master` through commit `a1916e5` are both examples of the non-conforming behaviour
this contract forbids going forward.

## Error Handling

### Shutdown during callback wait

If the proxy sends a `Shutdown` message while the client is inside a callback wait,
the client MUST raise its existing disconnection exception
(`EngineDisconnectedException` in the F# reference client) and MAY discard any
buffered `PendingFrame` entries — the session is ending and the bot will not receive
more frame-handler invocations.

### request_id mismatch

If the client receives a `CallbackResponse` whose `request_id` does not match the
in-flight request's id, the client MUST raise a protocol error. Silent acceptance is
non-conforming — it would mask proxy-side bugs and reintroduce the class of silent
data-loss defects this contract exists to prevent.

### SaveRequest during callback wait

A `SaveRequest` received during a callback wait is handled identically to a
`SaveRequest` outside a callback wait: the client responds with an empty
`SaveResponse` and continues waiting. Any `Frame` messages received before the
`SaveRequest` remain in the replay buffer and are drained by the next frame-consuming
API call as usual.

## Buffer Size Bound

The buffer size is bounded implicitly by the `readUntilCallback` attempt cap. The
F# reference client uses 100 attempts, which means at most 100 `PendingFrame` entries
can accumulate for a single callback wait. The contract does not require any specific
cap — implementations SHOULD pick a value large enough to accommodate realistic
callback round-trip times under fast-forward game speeds (100× headless BAR produces
roughly one frame per ~0.5 ms of wall-clock time).

## Test References

This contract is enforced by two tests landing under feature 031:

- **Deterministic** — `tests/integration/fsharp/CallbackFrameInterleavingTests.fs`
  scripts a `ProxyMessage` stream of `[Frame(f=100); Frame(f=110);
  CallbackResponse(request_id=R)]` through a test-only `HighBarClient` constructor
  and asserts that `SendCallback` returns the response while the next two frame
  reads deliver both frames and their events.
- **Live-engine** — `tests/integration/fsharp/CallbackEventLossTests.fs` runs a bot
  that issues a callback on every frame for ≥ 1 000 frames against a live
  spring-headless engine and reconciles bot-observed events against the proxy's
  `engine.infolog` event-topic counters. Any delta fails the test.

## Linked documentation

- Short-form reference: `docs/protocol.md` § Callbacks → Callback/Frame Interleaving
  (subsection added by this feature)
- FSBarV1 incident report:
  `Mailbox/2026-04-14_from_FSBarV1_mid-game-callback-event-drop.md`
- HighBarV2 response:
  `Mailbox/2026-04-14_to_FSBarV1_callback-event-drop-resolved.md` (created by this
  feature)
