# Implementation Plan: Fix Mid-Game Callback Event Drop

**Branch**: `031-fix-callback-event-drop` | **Date**: 2026-04-14 | **Spec**: [spec.md](./spec.md)
**Input**: Feature specification from `/specs/031-fix-callback-event-drop/spec.md`

## Summary

The HighBar.Client F# reference client's `SendCallback` silently discards events from
`Frame` messages that the proxy interleaves before a pending `CallbackResponse`. This
is the bug FSBarV1 reported in `Mailbox/2026-04-14_from_FSBarV1_mid-game-callback-event-drop.md`
and its root cause is a wildcard `| Frame _ ->` branch in `readUntilCallback`
(`clients/fsharp/src/Client.fs:229–236`) that sends an empty `FrameResponse` without
calling `Events.fromProto` on the frame.

The fix is the mailbox's **Option C**: the client buffers interleaved frames in a
per-instance FIFO and drains the buffer from the next frame-consuming API
(`Run`/`StepFrame`) before touching the socket. The proxy already populates
`CallbackResponse.request_id` (verified in `proxy/src/callbacks.c` and the proto
schema) so no C-code change is needed for correlation — the client just compares the
incoming `request_id` to the outgoing one and treats a mismatch as a protocol error.

Deliverables: (1) the client fix with preserved commands responses, (2) a deterministic
unit test driving a scripted `ProxyMessage` stream, (3) a live-engine integration test
that counts events over ≥1 000 frames of a callback-per-frame run and asserts zero
deltas against the proxy's `handleEvent` counters, (4) a new contract document under
`specs/031-fix-callback-event-drop/contracts/` plus an interleaving section added to
`docs/protocol.md`, and (5) a `Mailbox/` reply to FSBarV1.

## Technical Context

**Language/Version**: F# / .NET 10.0 (client library and tests); C11 (proxy, verified read-only)
**Primary Dependencies**: HighBar.Client (this project), Google.Protobuf 3.28, xUnit 2.9.x, protobuf-c (proxy, read-only)
**Storage**: N/A — the fix is in-process state (a FIFO queue on the client instance). No persistence.
**Testing**: xUnit 2.9.x for unit + integration tests, live spring-headless 2025.06.19 for the integration test, CTest (unchanged — proxy is read-only for this feature)
**Target Platform**: Linux (headless test env). The client is cross-platform and nothing in the fix is platform-specific.
**Project Type**: Library fix inside a multi-component repo (C proxy + F# client + F# tests)
**Performance Goals**: Zero additional hot-path allocations per frame in steady state. When no callback is in flight the fast path is unchanged from today. When a callback races the frame stream, one queue enqueue per interleaved frame and one queue dequeue per drained frame — both O(1) and bounded by the existing 100-attempt cap in `readUntilCallback`.
**Constraints**: Constitution V (latency budget) — buffer drain MUST NOT add measurable latency to `StepFrame`/`Run` on the happy path (empty queue case). Constitution III (correctness over cleverness) — prefer a straight FIFO; no reordering, no collapsing, no "smart" merging of stashed frames.
**Scale/Scope**: Fix is scoped to `clients/fsharp/src/Client.fs` (three call sites: `Run`, `StepFrame`, `SendCallback`), one new test file in `clients/fsharp/tests/` (or the existing test project for this component), one new live-engine test, one new contract doc, one edit to `docs/protocol.md`, one mailbox reply.

## Constitution Check

*GATE: Must pass before Phase 0 research. Re-check after Phase 1 design.*

| Principle | Check | Status |
|---|---|---|
| I. Zero Engine Modifications | No engine patch; the fix is in the F# client. The proxy is read only for this feature. | PASS |
| II. Binary Protocol First | No new wire format; the fix reuses the existing `request_id` field on `CallbackRequest`/`CallbackResponse`. No JSON, no text protocol, no new envelope. | PASS |
| III. Correctness Over Cleverness | The fix is a straight FIFO buffer-and-replay — the simplest change that unambiguously restores 1:1 event delivery. No reordering, no implicit drops, no "smart" transformations. | PASS |
| IV. Test at the Boundary | The deterministic test drives a scripted `ProxyMessage` stream through the client's decode path and asserts on the `GameFrame`/`Events.fromProto` boundary. The live-engine test reconciles bot-observed events against proxy-emitted events — i.e. the serialization boundary end-to-end. | PASS |
| V. Latency Budget Discipline | On the no-callback-in-flight path the buffer is empty and the drain is a single `Queue<T>.Count == 0` check — well under the sub-microsecond noise floor. No per-frame heap allocation is added. Queue instance lives for the lifetime of `HighBarClient`. | PASS |
| VI. Language-Agnostic by Default | The fix does not touch `.proto` schemas. Any other client language will need the same buffer-and-replay pattern; the new protocol docs spell it out as a normative client requirement so Python/Rust clients can implement identically. | PASS |
| VII. Explicit Over Implicit | Request-id mismatches become an explicit protocol error (log + throw) instead of a silent drop. Shutdown-during-callback keeps existing `EngineDisconnectedException` semantics. Contract doc is explicit about the interleaving rule rather than leaving it implicit. | PASS |

All gates pass. No complexity tracking entries required.

## Project Structure

### Documentation (this feature)

```text
specs/031-fix-callback-event-drop/
├── plan.md              # This file
├── research.md          # Phase 0: option comparison, correlation semantics, buffer bound justification
├── data-model.md        # Phase 1: ReplayBuffer, CallbackCorrelation, ProtocolError taxonomy
├── quickstart.md        # Phase 1: how to consume the fixed client + verify no drops
├── contracts/
│   └── callback-frame-interleaving.md   # Phase 1: normative interleaving contract
└── tasks.md             # /speckit.tasks output (NOT produced by /speckit.plan)
```

### Source Code (repository root)

This feature touches only the F# client library and its tests, plus documentation. The
surrounding repo layout is unchanged from the CLAUDE.md description.

```text
clients/fsharp/
├── src/
│   └── Client.fs                        # EDIT: SendCallback, Run, StepFrame, add replay queue field
├── HighBar.Client.fsproj                # no edit expected (dep set unchanged)
└── proto-gen/                           # generated — no edit

tests/                                   # repo-root test projects
├── HighBar.Client.UnitTests/
│   └── CallbackFrameInterleavingTests.fs   # NEW: deterministic scripted-stream test
└── HighBar.Client.Integration/
    └── CallbackEventLossTests.fs           # NEW: live-engine callback-per-frame test

docs/
└── protocol.md                          # EDIT: add "Callback/Frame Interleaving" section

specs/031-fix-callback-event-drop/
└── contracts/
    └── callback-frame-interleaving.md   # NEW: contract doc linked from docs/protocol.md

Mailbox/
└── 2026-04-14_to_FSBarV1_callback-event-drop-resolved.md   # NEW: reply per FR-010
```

The exact test project paths (`HighBar.Client.UnitTests`, `HighBar.Client.Integration`)
are placeholders to be confirmed in Phase 0 research by listing the actual test project
names — see research.md item R4. If the existing test layout uses different project
names, the new test files land in the matching existing project rather than creating
new ones (aligned with the CLAUDE.md testing guidance that discourages new test
scaffolding where existing projects suffice).

**Structure Decision**: Single-project layout — the fix lives inside the existing
`clients/fsharp/` F# component and the repo-root `tests/` tree. No new top-level
directory is created. No proxy (C) source changes; the proxy is read-only for this
feature (confirmed during spec authoring by inspection of `proxy/src/callbacks.c`).

## Complexity Tracking

> No constitution violations — this section is intentionally empty.

| Violation | Why Needed | Simpler Alternative Rejected Because |
|-----------|------------|-------------------------------------|
| — | — | — |
