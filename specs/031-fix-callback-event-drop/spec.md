# Feature Specification: Fix Mid-Game Callback Event Drop

**Feature Branch**: `031-fix-callback-event-drop`
**Created**: 2026-04-14
**Status**: Draft
**Input**: User description: "@Mailbox/2026-04-14_from_FSBarV1_mid-game-callback-event-drop.md fix that"

## Background

FSBarV1's trainer maintainer filed `Mailbox/2026-04-14_from_FSBarV1_mid-game-callback-event-drop.md`
reporting that any mid-game callback RPC silently drops engine events (including the
critical `UnitFinished` event) whenever the proxy interleaves a `Frame` message with the
pending `CallbackResponse` on the same socket. The reference F# client (HighBar.Client,
`clients/fsharp/src/Client.fs:229–236`) contains the same defect that FSBarV1 copied —
when `SendCallback` observes a `Frame` while waiting for `CallbackResponse`, it replies
with an empty `FrameResponse` and **never parses the frame's events**. Any callback
issued during an active match is therefore a gamble that races the event stream; in the
failing repro (FSBarV1 iter `024-baseline-pre-us5`) a single `Callbacks.getUnitPos` probe
dropped a `UnitFinished` event and stalled a macro bot for 35 000 frames.

The proxy's wire format already carries a `request_id` on both `CallbackRequest` and
`CallbackResponse` (see `proto/highbar/callbacks.proto:9,16`) and the C proxy populates
it on every response path (`proxy/src/callbacks.c:15,32,49,70,87,114,140`). The
multiplexing capability is therefore available on the wire — the only thing missing is
the client-side buffering that lets a consumer preserve interleaved frames across a
callback wait.

## User Scenarios & Testing *(mandatory)*

### User Story 1 - Mid-game callback no longer drops engine events (Priority: P1)

A bot author using HighBar.Client issues a callback (e.g. `GetUnitPos`,
`GetResourceUsage`, `MapGetLosMap`) from inside their frame handler. The engine happens
to emit one or more `Frame` messages before the proxy answers the callback. The bot's
next frame read must observe every event that those interleaved frames carried, in
their original order, with their original frame numbers.

**Why this priority**: This is the reported production defect. Until it is fixed, every
mid-game callback call is a correctness hazard, every BarData consumer that relies on
`UnitFinished`/`UnitDestroyed`/`UnitDamaged` can silently stall, and downstream projects
(FSBarV1 feature 024) are blocked from live validation.

**Independent Test**: A live-engine test calls a callback during a frame in which the
engine is known to emit a `UnitFinished` (or a scripted proxy harness that guarantees
interleaving), then advances one frame and asserts that the event is delivered to the
bot's frame handler. Passes only if zero events are dropped.

**Acceptance Scenarios**:

1. **Given** a live BAR match with a bot that issues one callback per frame, **When** the
   proxy interleaves a `Frame` carrying a `UnitFinished` event between the
   `CallbackRequest` and its `CallbackResponse`, **Then** the bot's next frame-handler
   invocation observes the `UnitFinished` event with its original frame number and
   event payload.
2. **Given** a bot that issues the same callback on every frame for 1 000 frames, **When**
   the engine emits 500 events across those frames, **Then** the bot observes all 500
   events across its frame handlers with no gaps and in frame order.
3. **Given** a test harness that crafts a controlled interleaving of N frames followed
   by a `CallbackResponse`, **When** the client receives them, **Then** the client
   returns the `CallbackResponse` from `SendCallback` **and** replays all N frames to
   the next `StepFrame`/`Run` iteration before consulting the socket again.

---

### User Story 2 - Proxy contract documents the interleaving guarantee (Priority: P2)

A future client implementer (or a downstream consumer like FSBarV1) reads the proxy
contract documentation and learns (a) that `Frame` messages may be interleaved with a
pending `CallbackResponse` on the primary socket, (b) that `request_id` on
`CallbackResponse` is the authoritative correlation key, and (c) what a conforming
client must do with interleaved frames (stash and replay — never drop).

**Why this priority**: The 030-proxy-contract-docs feature just shipped and the mailbox
explicitly asked HighBarV2 to confirm or reject the interleaving behaviour. Documenting
it prevents the next client from repeating FSBarV1's shortcut and re-introducing the
drop.

**Independent Test**: Review the contract doc diff; it must state the interleaving
rule, reference `request_id`, and show the required client-side buffer-and-replay
pattern. A follow-up conformance checklist item can be satisfied by pointing at the
new section.

**Acceptance Scenarios**:

1. **Given** the updated contract docs, **When** a reader searches for "callback" and
   "frame", **Then** they find a normative section stating that the proxy MAY emit
   `Frame` messages while a `CallbackRequest` is in flight and that conforming clients
   MUST preserve and replay those frames' events.
2. **Given** the updated contract docs, **When** a reader searches for "request_id",
   **Then** they find an explicit statement that `CallbackResponse.request_id` echoes
   the originating `CallbackRequest.request_id` and is the only correlation mechanism.

---

### User Story 3 - Reference client exposes a deterministic test hook for interleaving (Priority: P3)

A test author can construct a scenario where the interleaving happens on demand —
either by driving a scripted proxy or by a test-only API on `HighBar.Client` that
injects a recorded `ProxyMessage` stream. Without this, the fix is only exercised by
luck under live conditions and regressions can ship undetected.

**Why this priority**: A deterministic test is the only way to guarantee the fix
survives future refactors. It is P3 rather than P1 because the live-engine test from
US1 already catches regressions; this user story adds a fast, hermetic second line of
defence.

**Acceptance Scenarios**:

1. **Given** a test harness that injects `[Frame(f=100, events=[UnitCreated]);
   Frame(f=110, events=[UnitFinished]); CallbackResponse(request_id=1)]`, **When** the
   test calls `SendCallback` followed by two frame reads, **Then** the first read
   returns the frame at f=100 with its `UnitCreated`, the second returns the frame at
   f=110 with its `UnitFinished`, and no events are lost.

---

### Edge Cases

- **Callback issued from inside a frame handler**: The frame handler is itself invoked
  between a `Frame` being read and a `FrameResponse` being sent. A callback issued from
  that handler must still observe correctly — the client must not re-enter the frame
  handler while a `SendCallback` is mid-flight.
- **Shutdown during callback wait**: If the proxy sends a `Shutdown` message while the
  client is inside `SendCallback`, the callback must fail cleanly (existing
  `EngineDisconnectedException` semantics from feature 023) rather than hang.
- **SaveRequest during callback wait**: Already handled by auto-responding with an
  empty `SaveResponse`. The same frame-preservation rules apply — any `Frame` received
  before a `SaveRequest` must still be replayable.
- **Response out of order**: The wire format does not currently guarantee FIFO ordering
  of callback responses vs. the responses of concurrent callbacks. The fix MUST either
  (a) demonstrate that the single-client architecture makes concurrent callbacks
  impossible, or (b) honour `request_id` for correlation so that an early response to a
  later request is handled safely.
- **Replay buffer unbounded growth**: If a bot issues a callback while the proxy is
  producing frames faster than the bot consumes them, the stash could grow without
  bound. The design must either bound the buffer or demonstrate why an unbounded buffer
  is safe within the 100-attempt cap that already exists.
- **Unknown `ProxyMessage` case during wait**: The current code fails the callback on
  any message case other than `Frame | CallbackResponse | SaveRequest`. That behaviour
  must be preserved.

## Requirements *(mandatory)*

### Functional Requirements

- **FR-001**: HighBar.Client's `SendCallback` MUST NOT discard any events from `Frame`
  messages received while waiting for a `CallbackResponse`. The client MUST preserve
  each interleaved frame (frame number, events, any other frame-scoped fields) in a
  FIFO replay buffer on the client instance.
- **FR-002**: The next successful frame read (via `Run`, `StepFrame`, or any other
  frame-consuming API) MUST drain the replay buffer FIFO before reading from the socket.
  Each drained entry MUST invoke the bot's frame handler exactly once, in original
  arrival order, with the original frame number, and the handler's returned commands
  MUST be sent back to the proxy in a `FrameResponse` just as they would for a
  socket-sourced frame.
- **FR-003**: HighBar.Client MUST continue to auto-respond to interleaved `Frame`
  messages with an empty `FrameResponse` while inside `SendCallback` so that the proxy
  does not stall waiting for commands.
- **FR-004**: HighBar.Client MUST correlate `CallbackResponse` with its originating
  `CallbackRequest` using `CallbackResponse.request_id`. A response whose `request_id`
  does not match the in-flight request MUST be treated as a protocol error (the
  existing single-in-flight assumption is preserved).
- **FR-005**: The existing 100-attempt cap on `readUntilCallback` MUST be preserved.
  Stashing a frame counts as one attempt, matching today's behaviour.
- **FR-006**: HighBar.Client's `Shutdown` and `SaveRequest` handling inside the callback
  wait MUST remain semantically unchanged from today, including the frame-preservation
  contract (any frames received before a `SaveRequest` during a callback wait MUST
  still be replayed to the bot).
- **FR-007**: The proxy contract documentation authored in feature 030 MUST be updated
  to: (a) state that `Frame` messages MAY be interleaved with a pending
  `CallbackResponse` on the primary socket; (b) state that `CallbackResponse.request_id`
  echoes `CallbackRequest.request_id`; (c) describe the required client-side
  buffer-and-replay pattern; (d) explicitly mark "drop frame events" as non-conforming.
- **FR-008**: A live-engine integration test MUST demonstrate that a bot which issues a
  callback on every frame for at least 1 000 frames of a real match observes every
  engine event that the proxy emits, with zero gaps, verified against the proxy's
  internal event counters.
- **FR-009**: A deterministic (non-live) test MUST demonstrate that when
  `Frame → Frame → CallbackResponse` is presented to the client's receive path, the
  `SendCallback` return and the subsequent two frame reads collectively deliver every
  event in order, as described in US3.
- **FR-010**: A written reply to FSBarV1 (placed in `Mailbox/` per the project's
  inbound/outbound convention) MUST confirm the root-cause diagnosis, state the chosen
  fix path (Option C — client buffers and replays), and acknowledge that FSBarV1's
  "replay instead of drop" stopgap is acceptable while the fix lands.

### Key Entities

- **Replay buffer**: A client-instance FIFO that holds decoded `GameFrame` values (or
  the raw `ProxyMessage.Frame` oneof payloads) received during a callback wait. Owned
  by the same `HighBarClient` instance that owns the socket. Drained by frame-reading
  APIs before they touch the socket.
- **Request correlation id**: The existing `uint32 request_id` on
  `CallbackRequest`/`CallbackResponse`. In the single-in-flight model, the client
  compares the incoming response's `request_id` to the value it sent and fails the
  callback if they disagree.
- **Proxy contract document**: The markdown files added in feature
  `030-proxy-contract-docs`. Updated here with the new interleaving section.

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: In a 1 000-frame live-engine test where a bot issues a callback on every
  frame, the number of events delivered to the bot's frame handler equals the number
  of events the proxy logged as emitted, with zero deltas on a fresh run. Stability is
  separately verified by a five-iteration manual re-run before the feature is
  considered complete (folded into the quickstart walk — see tasks.md T034).
- **SC-002**: The FSBarV1 `024-baseline-pre-us5` repro scenario (macro bot on Avalanche
  vs NullAI, commander issues `Callbacks.getUnitPos` during the `[probe-idle]` window)
  observes its first `UnitFinished` event by frame 2 000 on every one of five
  consecutive runs — i.e. the race documented in the mailbox's §5 can no longer stall
  the bot.
- **SC-003**: The deterministic client-level test (US3) runs in under 100 ms and
  passes on CI without a live engine, so the regression is caught within a normal
  unit-test loop rather than requiring a headless match.
- **SC-004**: The proxy contract document contains a section titled along the lines of
  "Callback/Frame interleaving" that a reader can find by searching for "interleav" or
  "request_id", and the section's guidance is sufficient for a greenfield client to
  avoid the drop without reading the HighBar.Client source.
- **SC-005**: After the fix ships and FSBarV1 integrates the new HighBar.Client
  version, FSBarV1's `024-macro-smoke` iteration reaches a
  `cause=commander-death-win-after-upgrade` outcome (matching 023 iter 026) without
  FSBarV1's "replay instead of drop" stopgap.

## Assumptions

- The proxy's current single-client architecture means at most one `CallbackRequest`
  is in flight at a time. Concurrent callbacks are out of scope for this feature; if
  and when they are added, the `request_id` correlation machinery built here will
  generalise naturally.
- The proxy already populates `CallbackResponse.request_id` on every response path, as
  verified in `proxy/src/callbacks.c`. No proxy C-code change is required for
  correlation.
- FSBarV1 will pick up the fix by consuming the new `HighBar.Client` NuGet package
  (current version `0.1.2`, per the recent `BarData`/`HighBar.Client` bumps) and remove
  its own `sendCallback` drop comment. Coordinating that pickup is the FSBarV1
  maintainer's job; this feature only produces the fixed client and the mailbox reply.
- The existing 100-attempt cap on `readUntilCallback` is a sufficient bound on the
  replay buffer for all realistic bots: at 100× game speed, 100 frames ≈ 3 s of engine
  time, which is far longer than any practical callback round-trip.
- The contract documentation from feature 030 is the correct place for the new
  interleaving section; no new top-level doc is required.
- Options A (second socket), B (FrameWithResponses envelope), and D (proxy-side
  serialisation) from the mailbox are out of scope. Option C (client buffers and
  replays, proxy echoes `request_id`) is the chosen path because (a) the proxy already
  supports it, (b) it requires no protocol-version bump, and (c) it keeps the socket
  architecture simple.
