# Edge Case Audit: Fix Mid-Game Callback Event Drop

**Feature**: 031-fix-callback-event-drop
**Date**: 2026-04-14
**Scope**: Walk every edge case enumerated in `spec.md § Edge Cases` and record
the resolution for each. This is a traceability artifact — no new runtime
behaviour is added by this document.

## 1. Callback issued from inside a frame handler

**Spec statement**: The frame handler is itself invoked between a `Frame` being
read and a `FrameResponse` being sent. A callback issued from that handler must
still observe correctly — the client must not re-enter the frame handler while
a `SendCallback` is mid-flight.

**Resolution**: Verified by inspection of the reference client's `Run` and
`StepFrame` call paths. Both members are members of a single-threaded
`HighBarClient` instance, neither method is `async`, and neither invokes the
`onFrame` handler recursively. The `onFrame` handler is called synchronously
from `Run`/`StepFrame`, and any `SendCallback` issued from inside it runs on
the same call stack — it cannot re-enter `onFrame`. The replay buffer drain
logic added in T014/T015 also runs strictly at the top of each iteration of
`Run`/`StepFrame`, *not* inside `onFrame`, so a `PendingFrame` produced during
a nested callback cannot re-enter the handler before the current `onFrame`
returns.

**Evidence**: `clients/fsharp/src/Client.fs` — `Run` loop (replay drain block +
socket block, both linear sequential) and `StepFrame` loop (same structure).
`SendCallback` does not reference the `onFrame` parameter at all.

## 2. Shutdown during callback wait

**Spec statement**: If the proxy sends a `Shutdown` message while the client is
inside `SendCallback`, the callback must fail cleanly (existing
`EngineDisconnectedException` semantics from feature 023) rather than hang.

**Resolution**: `readUntilCallback` only pattern-matches on `CallbackResponse`,
`Frame`, and `SaveRequest`. Any other `ProxyMessage` oneof case falls into the
`other -> failwith $"Expected CallbackResponse, got {other}"` arm. A `Shutdown`
message delivered mid-wait therefore surfaces as an exception that unwinds the
callback stack. If the socket is closed by the proxy instead of sending a
`Shutdown`, `recvBytes` raises `EngineDisconnectedException` via the existing
feature-023 path (see `clients/fsharp/src/Client.fs` `readFully` → `if n = 0 then
raise (EngineDisconnectedException(...))`). In either case the caller gets a
typed exception, not a hang.

**Evidence**: `clients/fsharp/src/Client.fs` — `readUntilCallback`'s fallthrough
arm and `recvBytes`/`readFully` `n = 0` branch.

## 3. SaveRequest during callback wait

**Spec statement**: Already handled by auto-responding with an empty
`SaveResponse`. The same frame-preservation rules apply — any `Frame` received
before a `SaveRequest` must still be replayable.

**Resolution**: Verified by the deterministic test
`SendCallback preserves frames across an interleaved SaveRequest`
(T027 in `CallbackFrameInterleavingTests.fs`). The test scripts
`[Frame(50, [UnitCreated 1]); SaveRequest; Frame(60, [UnitFinished 1]);
CallbackResponse(request_id=1)]`, calls `SendCallback` then `StepFrame` twice,
and asserts: (a) `SendCallback` returns `request_id=1`, (b) the scripted sink
captured exactly one empty `SaveResponse`, (c) the first drain returns
`FrameNumber=50` with `UnitCreated 1`, and (d) the second drain returns
`FrameNumber=60` with `UnitFinished 1`. This directly guards FR-006's
"frame-preservation across SaveRequest" clause.

**Evidence**:
`tests/integration/fsharp/CallbackFrameInterleavingTests.fs` — T027 test body.

## 4. Response out of order

**Spec statement**: The wire format does not currently guarantee FIFO ordering
of callback responses vs. concurrent callbacks. The fix MUST either
(a) demonstrate that the single-client architecture makes concurrent callbacks
impossible, or (b) honour `request_id` for correlation.

**Resolution**: Option (b) — `request_id` correlation is now enforced in
`SendCallback`. T013 captured the outgoing `req.RequestId` into a local
`expectedRequestId` before `sendMessage`; the `CallbackResponse` branch of
`readUntilCallback` now checks `cbResp.RequestId = expectedRequestId` and raises
`HighBarProtocolException` on mismatch. The hermetic test
`SendCallback raises HighBarProtocolException on request_id mismatch`
(T026 in `CallbackFrameInterleavingTests.fs`) scripts a single
`CallbackResponse(request_id=99)` for a client whose first outgoing request
carries `request_id=1`, and asserts the client raises
`HighBarProtocolException` with a message containing `"expected 1"` and
`"got 99"`.

**Evidence**: `clients/fsharp/src/Client.fs` — `SendCallback`'s
`expectedRequestId` local and the `CallbackResponse` branch of
`readUntilCallback`. `tests/integration/fsharp/CallbackFrameInterleavingTests.fs`
— T026 test body.

## 5. Replay buffer unbounded growth

**Spec statement**: If a bot issues a callback while the proxy is producing
frames faster than the bot consumes them, the stash could grow without bound.
The design must either bound the buffer or demonstrate why an unbounded buffer
is safe within the 100-attempt cap.

**Resolution**: The buffer is bounded implicitly by the existing 100-attempt
cap on `readUntilCallback`. Every enqueue consumes exactly one attempt (each
`Frame` observed during the wait calls `readUntilCallback (attempts + 1)`),
so the queue cannot grow beyond 100 entries for a single `SendCallback` call.
The hermetic test
`SendCallback honours the 100-attempt cap when frames never stop interleaving`
(T028 in `CallbackFrameInterleavingTests.fs`) scripts 101 consecutive `Frame`
messages with no `CallbackResponse` and asserts the client raises an exception
whose message contains `"exceeded 100 attempts"`. This proves the cap is a
hard bound on buffer size under pathological interleaving.

**Evidence**: `clients/fsharp/src/Client.fs` — `readUntilCallback` attempt cap
(`if attempts > 100 then failwith "...exceeded 100 attempts..."`).
`tests/integration/fsharp/CallbackFrameInterleavingTests.fs` — T028 test body.

## 6. Unknown `ProxyMessage` case during wait

**Spec statement**: The current code fails the callback on any message case
other than `Frame | CallbackResponse | SaveRequest`. That behaviour must be
preserved.

**Resolution**: Preserved. The `readUntilCallback` pattern match retains its
`other -> failwith $"Expected CallbackResponse, got {other}"` arm, which fires
for any `ProxyMessage` oneof case the client does not explicitly handle
(`Handshake`, `Shutdown`, `LoadRequest`, etc.). No new arm was added and no
existing arm was made more permissive. A defensive `failwith` on an
unrecognised message preserves the fail-fast guarantee the spec requires.

**Evidence**: `clients/fsharp/src/Client.fs` — `readUntilCallback`'s final
`other ->` arm.
