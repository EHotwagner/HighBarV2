# Phase 1 Data Model: Fix Mid-Game Callback Event Drop

**Feature**: 031-fix-callback-event-drop
**Date**: 2026-04-14

This feature adds no wire-protocol types and no persisted entities. All "data" lives
inside one client instance for the duration of one match. The entities below describe
that in-memory state.

## Entity 1 — PendingFrame (new, client-internal)

A decoded frame that was received during a `SendCallback` wait and is waiting to be
replayed to the bot's frame handler.

| Field | Type | Notes |
|---|---|---|
| `FrameNumber` | `int32` (from proto `Frame.frame_number`) | The engine frame at which these events fired. Preserved exactly as delivered. |
| `Events` | `GameEvent list` (already decoded via `Events.fromProto`) | Decoded at stash time, not at drain time, so the drain path is identical to the socket path. |

**Lifetime**: Created by `SendCallback`'s interleaving branch. Consumed by the next
call into `Run` or `StepFrame`. Never escapes the owning `HighBarClient` instance.

**Identity**: Value-typed record. No identity field; FIFO order is the only ordering
signal.

**Validation**: None — the data has already been validated at decode time. If
`Events.fromProto` would fail, the failure surfaces inside `SendCallback` as it does
today, not inside the replay path.

## Entity 2 — ReplayBuffer (new, client-internal)

A single `System.Collections.Generic.Queue<PendingFrame>` field on
`HighBarClient`. Initialised empty in the constructor. Mutated only by
`SendCallback` (enqueue) and by `Run`/`StepFrame` (dequeue).

**State transitions**:

```
            enqueue (SendCallback sees interleaved Frame)
            ───────────────────────────────────────────►
Empty ───────────────────────────────────────────────── NonEmpty
       ◄───────────────────────────────────────────────
            dequeue (Run/StepFrame drains before socket read)
```

**Invariants**:

- Size ≤ 100 at all times, because the existing `readUntilCallback` attempt cap is
  100 and each stash consumes exactly one attempt. This is the bound justified in
  research.md R3.
- FIFO order is preserved — `Queue<T>.Dequeue()` returns entries in enqueue order.
- The buffer is single-threaded: all callers operate inside `HighBarClient`'s
  non-reentrant API surface. No locking.

**Non-invariants**:

- The buffer may contain entries from multiple distinct `SendCallback` calls if two
  callbacks are made between frame reads — each enqueue just appends to the queue
  and the FIFO ordering across calls is preserved because they happen sequentially.

## Entity 3 — CallbackCorrelation (new semantics for an existing field)

A conceptual entity capturing how the client pairs a `CallbackResponse` to its
originating `CallbackRequest`.

| Element | Value |
|---|---|
| **Field** | `CallbackRequest.request_id` / `CallbackResponse.request_id` (`uint32`) |
| **Populated by** | Client on request send (`nextRequestId` monotonic counter, already present on line 212 of `Client.fs`). Proxy on response send (already done, verified in research.md R2). |
| **Checked by** | `SendCallback` after receiving a `CallbackResponse`. If the response's `request_id` does not equal the outgoing request's id, the client throws a `HighBarProtocolException` (new — see Entity 4). |
| **Cardinality** | 1:1 — the client's single-in-flight model means there is at most one request awaiting a response at any time. |
| **Wraparound** | `uint32` gives 4 billion requests per connection, far beyond any realistic match length. Wraparound handling is out of scope. |

**Why this is a separate entity**: The proto field already exists and is populated;
the feature change is that the client starts *using* it as a correlation key rather
than ignoring it. Calling this out makes the contract-level behaviour explicit and
lets the contract doc (see contracts/callback-frame-interleaving.md) reference it by
name.

## Entity 4 — HighBarProtocolException (new exception type)

Thrown when the proxy sends a message that violates the documented interleaving
contract during a `SendCallback` wait — specifically, a `CallbackResponse` whose
`request_id` does not match the in-flight request.

| Field | Value |
|---|---|
| `Message` | `"CallbackResponse request_id mismatch: expected {expected}, got {actual}"` |
| **Extends** | `System.Exception` |
| **Not caught by** | `SendCallback` itself — it propagates to the caller. |
| **Relationship to** `EngineDisconnectedException` | Distinct. `EngineDisconnectedException` (from feature 023) means the socket went away. `HighBarProtocolException` means the proxy is still there but sent something that violates the contract. |

**Why a new type**: The existing `failwith` calls in `Client.fs` raise a base
`System.Exception`, which makes a correlation-mismatch indistinguishable from any
other unexpected case. A typed exception lets tests (and future callers) assert on
the specific condition without brittle message matching.

## Entity 5 — Contract document (new, file-system artifact)

`specs/031-fix-callback-event-drop/contracts/callback-frame-interleaving.md` — the
normative description of the interleaving contract. Schema-shaped for easy future
linting, with sections:

- **Wire shape**: states that `Frame` and `CallbackResponse` are both top-level
  `ProxyMessage` envelopes and the proxy MAY interleave `Frame` messages between a
  `CallbackRequest` and its `CallbackResponse`.
- **Correlation**: states that `CallbackResponse.request_id` echoes the originating
  request's id and is the only correlation mechanism.
- **Conforming client behaviour**: states the buffer-and-replay pattern verbatim,
  marks "drop frame events" as non-conforming, and gives a minimal pseudo-code
  sketch.
- **Error handling**: covers shutdown during wait, request_id mismatch, and save
  request during wait.
- **Test references**: links to the deterministic and live tests that enforce the
  contract.

This file is created in Phase 1 (`/speckit.plan`'s contracts output) and linked from
`docs/protocol.md`'s new "Callback/Frame Interleaving" subsection.

## What is NOT in the data model

- No wire-protocol changes. `proto/highbar/*.proto` is untouched.
- No new persisted storage. The replay buffer is in-memory, match-scoped.
- No new config surface. The buffer has no tunables; the existing 100-attempt cap on
  `readUntilCallback` is the only knob and it is unchanged.
- No new public API on `HighBarClient` beyond the test-only constructor (Phase 1
  contracts §R5) — existing `Run`, `StepFrame`, `SendCallback`, and every typed
  callback wrapper keep their current signatures.
