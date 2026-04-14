# Phase 0 Research: Fix Mid-Game Callback Event Drop

**Feature**: 031-fix-callback-event-drop
**Date**: 2026-04-14

This document resolves every "NEEDS CLARIFICATION" item from plan.md's Technical
Context section and records the supporting evidence for the chosen approach.

## R1 — Which fix option (A/B/C/D) should HighBarV2 adopt?

**Decision**: Option C — the F# client buffers interleaved `Frame` messages in a
per-instance FIFO and replays them to the next frame-consuming API. The proxy is
unchanged.

**Rationale**:

- The proto schema already carries `request_id` on both `CallbackRequest` and
  `CallbackResponse` (`proto/highbar/callbacks.proto:9,16`), and the C proxy populates
  it on every response path
  (`proxy/src/callbacks.c:15,32,49,70,87,114,140`). Option C requires zero proxy
  changes for correlation.
- Option A (second socket) would add a `PROXY_CALLBACK` Unix socket and a second
  lifecycle. It is the largest architectural change in the mailbox's list and violates
  **Constitution VII (Explicit Over Implicit)** by introducing two connection phases
  with new edge cases around ordering between the two sockets at shutdown.
- Option B (new `FrameWithResponses` envelope) requires a protocol-version bump,
  simultaneous coordinated rollout of the proxy and every client, and forces callers
  into an async future/await model. That is a significant rewrite and inconsistent
  with how the rest of the protocol is shaped.
- Option D (proxy serialises streams — stops emitting frames until a pending callback
  is answered) adds engine-side latency (≤ 33 ms per pending callback at 30 fps). It
  is the simplest client model but has the highest performance risk and puts the
  serialisation burden in the single-threaded hot path
  (`proxy/src/proxy.c`'s `handleEvent` loop), which is exactly where the constitution
  requires allocation and latency discipline.
- Option C keeps the single-socket architecture, reuses an existing proto field, adds
  **O(1) per interleaved frame** of overhead on only the already-racing path, and is
  the option FSBarV1 explicitly said they prefer in §"Possible fixes — proxy side".

**Alternatives considered**: A, B, D — all documented in the mailbox, all rejected
above for concrete reasons.

## R2 — Is `CallbackResponse.request_id` populated on every response path in the current proxy?

**Decision**: Yes, on every path in `proxy/src/callbacks.c`:
- `make_int_response` — line 15 sets `resp->request_id = request_id;`
- `make_float_response` — line 32
- `make_vec3_response` — line 49
- `make_string_response` — line 70
- `make_int_array_response` — line 87
- `make_float_array_response` — line 114
- `make_error_response` — line 140

**Rationale**: This was verified by `Grep request_id` over `proxy/src` during spec
authoring. Every helper that the dispatcher in `hb_callback_dispatch` can call
populates the field. There is no code path that returns a `Highbar__CallbackResponse`
without writing `request_id`. That means the client can correlate immediately; no
proxy change is required before the client fix ships.

**Alternatives considered**: Audit the generated proto default (0) as a sentinel and
require the proxy to explicitly set `request_id`. Rejected because the audit confirms
the explicit set is already in place and a belt-and-braces sentinel check would only
obscure protocol errors.

## R3 — Where does the replay buffer live, and who owns its lifetime?

**Decision**: A `System.Collections.Generic.Queue<PendingFrame>` field on the
`HighBarClient` class, initialised empty in the constructor and never externally
exposed. `PendingFrame` carries exactly the data we already compute today
(`FrameNumber` + `Events` list), so its lifetime matches the client instance.

**Rationale**:

- Keeping the buffer inside `HighBarClient` makes it owned by the same object that
  owns the socket, so there is no cross-object lifetime question and no need for
  locking (the client is single-threaded per the constitution — engine calls
  `handleEvent` sequentially and the proxy is single-threaded; client-side callers
  likewise work one call at a time).
- The buffer must be drained by *every* frame-consuming API (`Run`, `StepFrame`), so
  it cannot live inside `SendCallback`'s closure — it must survive between calls.
- `Queue<T>` gives O(1) enqueue/dequeue and constant-factor fast because it is a
  ring-buffer backed by an array. No per-frame allocation once the queue has grown to
  its steady-state size.
- Bound: the existing 100-attempt cap on `readUntilCallback` limits the buffer to at
  most 100 entries in the worst case. At a typical 1–2 KB per frame that is under 200
  KB — small enough to be a non-issue for any sane bot.

**Alternatives considered**:
- A concurrent queue (`ConcurrentQueue<T>`) — rejected because the constitution
  commits to a single-threaded model; adding lock-free primitives would imply a
  threading model we explicitly do not have.
- A typed record carrying the raw `Highbar.Frame` proto object — rejected because
  callers downstream work on the decoded `GameFrame`/`GameEvent` types; pre-decoding
  at stash time keeps the drain path identical to the socket path.

## R4 — Which F# test project hosts the new deterministic and live tests?

**Decision**: Both tests live under `tests/integration/fsharp/` in the existing
`HighBar.Tests.fsproj`.

- **Deterministic test** → new file `CallbackFrameInterleavingTests.fs` in that
  project, using an xUnit collection that does NOT use the `"Engine"` collection (no
  live engine required — uses a scripted in-memory `Stream`).
- **Live integration test** → new file `CallbackEventLossTests.fs` in the same
  project, using the existing `[<Collection("Engine")>]` fixture (`EngineFixture`
  exposed by `Harness.fs`).

**Rationale**:

- A directory-level `ls` of the repo-root `tests/` tree confirms only two F# test
  projects exist under the current layout: `tests/integration/fsharp/HighBar.Tests.fsproj`
  and `tests/persistent/fsharp/HighBar.PersistentTests.fsproj` (plus `BarData.Tests.fsproj`
  under `data/bar.tests/` which is out of scope here).
- `tests/integration/fsharp/CallbackTests.fs` already contains live-engine callback
  coverage using the same `EngineFixture` pattern our live test needs
  (see its `runWithCallbackQuery` helper) — landing alongside it keeps the test
  surface coherent.
- Creating a new project for a single deterministic test would violate the CLAUDE.md
  guidance against unnecessary test scaffolding.
- The deterministic test does not need the engine fixture because it injects a
  pre-recorded stream through a test-only constructor path (see data-model.md
  "Injectable stream" discussion).

**Alternatives considered**:
- New `HighBar.Client.UnitTests` project — rejected as unnecessary scaffolding for one
  file.
- `tests/persistent/fsharp/` — rejected because that project is for long-running
  engine-backed scenarios, not deterministic unit tests.

## R5 — How does the deterministic test inject a scripted `ProxyMessage` stream without opening a real socket?

**Decision**: Add a test-only constructor (or `internal` factory) on `HighBarClient`
that accepts an arbitrary `System.IO.Stream` in place of the socket. The deterministic
test constructs a `MemoryStream` containing length-prefixed `ProxyMessage` bytes for
`[Frame(f=100, events=[UnitCreated]); Frame(f=110, events=[UnitFinished]);
CallbackResponse(request_id=1)]`, wraps it in a bidirectional harness (reads from the
memory stream, writes to a throwaway sink), and drives `SendCallback` then two frame
reads.

**Rationale**:

- The existing client already layers `recvBytes`/`sendMessage` on a
  `NetworkStream`. Swapping in a `MemoryStream`-backed duplex is a localised change:
  the recv path reads bytes as before and the send path writes to a sink the test
  can inspect for empty `FrameResponse` messages.
- This is a single-seam test, which is the kind the constitution's "Test at the
  Boundary" principle encourages — it exercises the exact decode/encode boundary
  the bug lives behind, without faking any downstream dependency.
- `InternalsVisibleTo` (or a `[<TestHook>]` attribute) exposes the constructor only to
  the test project; it is not part of the public API surface that downstream clients
  like FSBarV1 see.

**Alternatives considered**:
- Stand up a loopback Unix socket and write scripted bytes into it. Rejected because
  it adds OS-level state and slows the test beyond the 100 ms SC-003 budget.
- Use reflection to swap the `stream` field. Rejected as fragile and less auditable
  than an explicit constructor.

## R6 — How does the live-engine test measure "no events dropped"?

**Decision**: Enable the proxy's existing `engine.infolog` event-topic counters
(already emitted per frame — see the mailbox §3.1 `Event topics at frame N` lines)
and compare them to a counter the bot accumulates inside its frame handler over a
fixed window.

- The bot runs for ≥ 1 000 simulation frames with a `SendCallback` issued on every
  frame (using a cheap callback like `CallbackMapGetWidth`).
- The bot tallies events per type from its frame handler.
- After the run, the test reads `engine.infolog` and parses the per-frame topic
  counters.
- The assertion is: for every topic id in the overlap, the bot's tally equals the
  infolog delta (start-of-run minus end-of-run). Any delta means a drop.

**Rationale**:

- The infolog counters are the proxy's own view of what it emitted, so a match
  against the bot's tally is a true end-to-end reconciliation — it is the exact
  comparison FSBarV1's mailbox §3 demonstrates is missing today (their tally was
  zero where the proxy said it emitted one).
- No new proxy instrumentation is required — the counters are already there.
- 1 000 frames at headless speed completes well inside the test time budget of
  existing integration tests.

**Alternatives considered**:
- Mock the proxy and drive a deterministic event schedule. Rejected because the bug
  is specifically about real interleaving under real engine timing; a mock would
  bypass the thing the test is meant to validate.
- Use `frames.jsonl` output (the trainer mode). Rejected because that is an FSBarV1
  concept, not a HighBarV2 artifact.

## R7 — Should the `docs/protocol.md` edit be a new top-level section or a subsection under "Callbacks"?

**Decision**: A new subsection titled **"Callback/Frame Interleaving"** under the
existing `## Callbacks` section in `docs/protocol.md` (around line 262, after the
"Commonly Used Callbacks" table), plus a new contract document at
`specs/031-fix-callback-event-drop/contracts/callback-frame-interleaving.md` linked
from the docs section.

**Rationale**:

- Feature 030 established the convention of a feature-local contract document under
  `specs/030-proxy-contract-docs/contracts/` linked from `docs/`. We follow the same
  pattern for consistency — the detailed normative text lives in the contract file,
  while `docs/protocol.md` gets a short subsection that cross-links to it.
- Placing the subsection directly after the Callbacks table puts it exactly where a
  reader searching the doc for "callback" will land, satisfying SC-004.

**Alternatives considered**: A new top-level `## Frame/Callback Interleaving` heading
— rejected as unnecessarily prominent for a client-implementation requirement; the
existing Callbacks section is the natural home.

## R8 — What happens if a shutdown is received while inside `SendCallback` and there are buffered frames?

**Decision**: On `Shutdown`, `SendCallback` throws the existing
`EngineDisconnectedException` (introduced in feature 023) exactly as it does today —
the buffered frames are discarded because the session is ending and the bot cannot
process them anyway. This matches the Shutdown wire shape documented in
`specs/030-proxy-contract-docs/contracts/shutdown-wire-shape.md`, where Shutdown
terminates all future message processing.

**Rationale**: The buffered frames can only be delivered to a subsequent frame-read
call, and there is no frame-read call after a shutdown. Preserving them would be
dead state.

**Alternatives considered**: Drain the buffer into a final synthetic frame handler
call before raising the exception. Rejected because it changes the shutdown contract
and the bot is explicitly not supposed to receive more frame-handler invocations
after disconnect.

## R9 — Do we need to bump the `HighBar.Client` NuGet version after this fix?

**Decision**: Yes — patch bump from `0.1.2` → `0.1.3` because the fix changes
observable client behaviour (previously-dropped events now surface) and downstream
consumers (FSBarV1) will key their workaround removal off this version.

**Rationale**: Recent commits already establish the version-bump convention for
`HighBar.Client` (commits `a1916e5` and `32ce22f`). A downstream consumer that pins
to `0.1.2` must be able to opt into the new behaviour explicitly. The fix is
bug-fix-shaped, so a patch bump fits SemVer.

**Alternatives considered**: No bump — rejected because downstream pinning would
then deliver the fix silently with no versioning signal to FSBarV1.

## Unresolved items

None — all NEEDS CLARIFICATION entries from plan.md are resolved above.
