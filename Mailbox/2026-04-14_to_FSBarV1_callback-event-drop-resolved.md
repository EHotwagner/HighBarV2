# Mid-game callback event drop — RESOLVED in HighBar.Client 0.1.3

**Date**: 2026-04-14
**From**: HighBarV2 maintainer
**To**: FSBarV1 trainer maintainer (feature 024 tactical-map-primitives)
**In reply to**: `Mailbox/2026-04-14_from_FSBarV1_mid-game-callback-event-drop.md`
**Ships in**: `HighBar.Client` 0.1.3

## TL;DR

Root cause confirmed: the proxy does interleave `Frame` messages between a
client's `CallbackRequest` and the matching `CallbackResponse` on the same
socket, and the reference F# client's `readUntilCallback` loop silently
dropped the events on interleaved frames. HighBarV2 has adopted **mailbox
Option C** — the client now buffers interleaved frames in a per-instance FIFO
and drains them from the next `Run`/`StepFrame` call. No proxy or wire-format
change was required: `CallbackRequest.request_id` / `CallbackResponse.request_id`
are already populated by the proxy on every response path.

The fix ships in `HighBar.Client` version **0.1.3**. Pin to that version and
you can remove the FSBarV1 `Protocol.sendCallback` drop stopgap commented in
`775c73f` — HighBar.Client will no longer lose events under callback waits.

## What changed in HighBar.Client

- `SendCallback`'s `readUntilCallback` helper now decodes every interleaved
  `Frame` via `Events.fromProto`, enqueues it into a `Queue<PendingFrame>`
  owned by the `HighBarClient` instance, and sends the existing empty
  `FrameResponse` so the proxy does not stall.
- `Run` and `StepFrame` drain the replay buffer FIFO-first on every iteration
  of their frame-read loops, invoking the bot's frame handler on each drained
  frame with its original `frame_number` and full event list. The socket is
  only touched when the buffer is empty.
- `CallbackResponse.request_id` is now verified against the outgoing
  `CallbackRequest.request_id` inside `SendCallback`. On mismatch, a new
  `HighBarProtocolException` is raised — distinct from the existing
  `EngineDisconnectedException` so callers can tell "proxy sent the wrong
  response" apart from "socket went away".
- The 100-attempt cap on `readUntilCallback` is preserved unchanged; it is
  the hard upper bound on replay buffer size under pathological interleaving.

All of this is in-process client state. The proxy (`proxy/src/*`) and the
protobuf schema (`proto/highbar/*.proto`) are untouched.

## Why Option C (and not A/B/D)

- **Option A** (second socket for `PROXY_CALLBACK`) added two connection
  lifecycles and new cross-socket ordering edge cases at shutdown — violates
  Constitution VII (Explicit Over Implicit).
- **Option B** (`FrameWithResponses` envelope) required a wire-format version
  bump and a coordinated proxy+every-client rollout.
- **Option D** (proxy serialises streams — holds frames until the pending
  callback is answered) adds ≤33 ms per callback at 30 fps in the
  single-threaded proxy hot path. Fails Constitution V (Latency Budget).
- **Option C** reuses the already-populated `request_id` field, keeps the
  single-socket architecture, adds O(1) overhead on only the already-racing
  path, and matches the preference stated in §"Possible fixes — proxy side"
  of the inbound mailbox.

## FSBarV1 stopgap

Your `Protocol.sendCallback` drop-and-continue stopgap (FSBarV1 commit
`775c73f`) is **acceptable in the meantime** — it's a correct defensive
behaviour when paired with a non-conforming counterpart, and it kept the
trainer from deadlocking. Once FSBarV1 pins to `HighBar.Client` 0.1.3 you can
remove the comment and the wildcard `| Frame _ ->` branch in
`Protocol.fs:143-169`, replacing them with the buffer-and-replay pattern the
contract now specifies. The HighBar reference client's `SendCallback` is the
canonical implementation you can mirror.

## The new normative contract

The interleaving contract is now documented at

- [`specs/031-fix-callback-event-drop/contracts/callback-frame-interleaving.md`](../specs/031-fix-callback-event-drop/contracts/callback-frame-interleaving.md)

and linked from `docs/protocol.md § Callbacks → Callback/Frame Interleaving`.
It describes the wire shape, the ordering rule, the `request_id` correlation
rule, the six-step conforming-client procedure, error handling for
`Shutdown` and `SaveRequest` during a callback wait, and the deterministic +
live-engine tests that enforce it.

Any new client (Python, Rust, etc.) that follows this contract will be
conforming on day one.

## Test coverage

Two new tests land under feature 031:

- **Deterministic** —
  `tests/integration/fsharp/CallbackFrameInterleavingTests.fs` scripts a
  `ProxyMessage` byte stream through the client's decode path and asserts
  that (a) the main `[Frame, Frame, CallbackResponse]` interleave path
  drains both frames with their original events and numbers, (b)
  `request_id` mismatch raises `HighBarProtocolException`, (c) an
  interleaved `SaveRequest` is acknowledged with an empty `SaveResponse`
  without losing the surrounding frames, and (d) the 100-attempt cap fires
  with a clear error message when frames never stop interleaving. All four
  tests run in well under 100 ms combined, with no engine required.
- **Live-engine** — `tests/integration/fsharp/CallbackEventLossTests.fs`
  runs a bot that issues `MapGetWidth` on every frame for ≥1 000
  simulation frames against live spring-headless and reconciles
  bot-observed events against the proxy's `engine.infolog` per-topic
  counters over the test window. Any delta fails the test.

The revert-sensitivity of the deterministic tests is verified: stashing the
buffer-and-replay implementation causes two of the four tests to fail
deterministically, so the tests actually guard the behaviour they claim to
guard.

## Next steps for FSBarV1

1. Pin to `HighBar.Client` 0.1.3 when it lands on the HighBarV2 NuGet feed.
2. Remove the `775c73f` drop-and-continue stopgap in `Protocol.sendCallback`
   and mirror the `HighBarClient.SendCallback` buffer-and-replay pattern.
3. Re-run the `024-macro-smoke` live iteration — SC-002 (never-stuck opening
   in a 24 000-frame run) and SC-005 (bot handles bursts of callbacks without
   deadlock) are expected to pass on the fixed client.
4. Let me know if anything surprises you — the normative contract is the
   single source of truth; if the reference client diverges from it in any
   edge case that bites FSBarV1, that's a HighBarV2 bug, not yours.

Thanks for the detailed root-cause report — the reproduction table at §5 and
the `engine.infolog` topic-counter evidence at §3.1 made the diagnosis almost
trivial.
