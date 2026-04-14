---

description: "Task list for feature 031-fix-callback-event-drop"
---

# Tasks: Fix Mid-Game Callback Event Drop

**Input**: Design documents from `/specs/031-fix-callback-event-drop/`
**Prerequisites**: plan.md, spec.md, research.md, data-model.md, contracts/callback-frame-interleaving.md, quickstart.md

**Tests**: INCLUDED. The spec explicitly requires both a deterministic (FR-009, SC-003) and a live-engine (FR-008, SC-001, SC-002) test. Test tasks appear in the user story that owns them.

**Organization**: Tasks are grouped by user story to enable independent implementation and testing.

## Format: `[ID] [P?] [Story] Description`

- **[P]**: Can run in parallel (different files, no dependencies on incomplete tasks)
- **[Story]**: Which user story this task belongs to (US1, US2, US3). Setup, Foundational, and Polish tasks do NOT carry a story label.

## Path Conventions

Repository uses the layout documented in `plan.md § Project Structure`:

- Client library: `clients/fsharp/src/Client.fs` (single file — all edits land here)
- Client project file: `clients/fsharp/HighBar.Client.fsproj`
- Test project: `tests/integration/fsharp/HighBar.Tests.fsproj`
- Test files: `tests/integration/fsharp/*.fs`
- Docs: `docs/protocol.md`
- Contracts: `specs/031-fix-callback-event-drop/contracts/`
- Mailbox: repository-root `Mailbox/`

---

## Phase 1: Setup (Shared Infrastructure)

**Purpose**: Tiny — the repo, the branch, and the build already exist. The only setup items are sanity-checks that the toolchain and prerequisites are in place before any implementation starts.

- [X] T001 Confirm `031-fix-callback-event-drop` is the current branch and that `git status` is clean apart from this feature's own spec/plan/research/data-model/contracts/quickstart files (run `git status` and `git branch --show-current`).
- [X] T002 Run `./tests/check-prerequisites.sh` and confirm the F# SDK, spring-headless engine, and engine content versions listed in `CLAUDE.md § Environment` are all present. If any item fails, stop and fix before proceeding — US1 and its verification cannot run without them.
- [X] T003 Run `./tests/run-all.sh --category integration` once on the current branch to capture a **pre-fix baseline**: expected result is that all existing integration tests pass, including `tests/integration/fsharp/CallbackTests.fs`, because the current bug only manifests under the specific race described in the FSBarV1 mailbox, not in any existing automated test. Record the pass/fail output so later tasks can compare.

---

## Phase 2: Foundational (Blocking Prerequisites)

**Purpose**: Introduce the tiny shared type surface (new exception, new internal record) that all three user stories reference. Keeping these in a foundational phase lets US1, US2, and US3 all reference them by name without waiting on each other.

**⚠️ CRITICAL**: No user-story work can begin until this phase is complete.

- [X] T004 Add a new F# exception type `HighBarProtocolException` to `clients/fsharp/src/Client.fs` (near the top of the file, alongside the existing `EngineDisconnectedException` from feature 023). Constructor takes a `string` message. No other members. This is the type `SendCallback` will raise on `request_id` mismatch (data-model.md Entity 4).
- [X] T005 Add a private internal record `PendingFrame` to `clients/fsharp/src/Client.fs` with fields `FrameNumber: int` and `Events: GameEvent list` (data-model.md Entity 1). Place it near the existing `GameFrame` definition so both types are co-located. The record must NOT appear in any exported module surface — it is client-internal state only.
- [X] T006 [P] Add `[<assembly: System.Runtime.CompilerServices.InternalsVisibleTo("HighBar.Tests")>]` to the top of `clients/fsharp/src/Client.fs`. (The project has no `AssemblyInfo.fs` under `clients/fsharp/src/`, verified 2026-04-14, so the attribute goes into `Client.fs` directly.) This is the hook US3's deterministic test relies on to access the test-only constructor added in T022. Verify by running `dotnet build clients/fsharp/HighBar.Client.fsproj` and confirming zero errors.

**Checkpoint**: Foundation ready — US1, US2, and US3 can now begin in parallel.

---

## Phase 3: User Story 1 — Mid-game callback no longer drops engine events (Priority: P1) 🎯 MVP

**Goal**: Replace the event-dropping `| Frame _ ->` branch in `SendCallback`'s `readUntilCallback` with a buffer-and-replay implementation. Every engine event that the proxy emits during a callback wait MUST be delivered to the bot's frame handler on a subsequent frame read, with its original frame number and event payload.

**Independent Test**: Run the new live-engine test `CallbackEventLossTests` (added by T010) against spring-headless. The test drives a bot that issues `MapGetWidth` on every frame for at least 1 000 frames and reconciles bot-observed events against the proxy's `engine.infolog` event-topic counters. The test passes iff there are zero deltas.

### Tests for User Story 1 (live-engine reconciliation)

> **NOTE: Write these tests FIRST, ensure they FAIL on the current (unfixed) client, then implement the fix and re-run.**

- [X] T007 [P] [US1] Create `tests/integration/fsharp/CallbackEventLossTests.fs` as a new F# file, added to `tests/integration/fsharp/HighBar.Tests.fsproj`. It must be included in the same `[<Collection("Engine")>]` as the existing `CallbackTests.fs` so it reuses `EngineFixture` without spawning a second engine. The file stub only — no test body yet.
- [X] T008 [US1] Inside `CallbackEventLossTests.fs`, add a helper `parseEngineInfologEventCounters : sessionDir:string -> Map<int,int>` that reads `engine.infolog` from a spring-headless session directory and returns the final per-topic event counter map by parsing lines of the form `[f=NNNNNNN] Event topics at frame N: 1=A 3=B 5=C 6=D ...` (the same line the FSBarV1 mailbox §3.1 quotes). Add a small unit-style test that feeds a captured fixture line into the helper and asserts on the parsed map.
- [X] T009 [US1] Inside `CallbackEventLossTests.fs`, add a helper `tallyBotEventsByTopic : events:GameEvent list -> Map<int,int>` that counts decoded `GameEvent` values by their corresponding proto topic id (the mapping lives in the already-generated proto code — use the enum case number). This is the bot-side tally against which the infolog delta is reconciled.
- [X] T010 [US1] Inside `CallbackEventLossTests.fs`, add the main test `[<Fact>] Callback-per-frame run preserves every engine event`. The test runs the fixture engine, calls `client.Run` for ≥ 1 000 simulation frames, accumulates decoded events via `tallyBotEventsByTopic`, issues `client.MapGetWidth()` on every single frame as the callback under test, parses the fixture's `engine.infolog`, and asserts that every topic id present in the infolog delta is represented in the bot tally with exactly the same count. On the current (unfixed) client this test MUST fail; on the fixed client it MUST pass. Tag the test with `[<Trait("Category", "Callbacks")>]`.

### Implementation for User Story 1

- [X] T011 [US1] In `clients/fsharp/src/Client.fs`, add a private mutable field `replayBuffer : Queue<PendingFrame>` (using `System.Collections.Generic.Queue<_>`) on `HighBarClient`, initialised empty in the constructor. This is the FIFO described in data-model.md Entity 2.
- [X] T012 [US1] In `clients/fsharp/src/Client.fs`, rewrite the `ProxyMessage.MessageOneofCase.Frame` branch of `SendCallback`'s `readUntilCallback` helper (currently at lines 229–236). The new branch MUST: (a) decode the incoming `Frame` into a `PendingFrame` by calling `Events.fromProto` on each event and capturing `frame.FrameNumber` and the decoded list, (b) enqueue the `PendingFrame` on `replayBuffer`, (c) send the existing empty `FrameResponse` (preserve the proxy-unblocking semantics FR-003 requires), and (d) recurse into `readUntilCallback (attempts + 1)` exactly as today. No events may be lost. No additional allocations beyond the one `PendingFrame` per interleaved frame.
- [X] T013 [US1] In `clients/fsharp/src/Client.fs`, add `request_id` correlation to `SendCallback`: capture the `req.RequestId` value into a local `let` before `sendMessage`, then in the `CallbackResponse` match branch check `proxyMsg.CallbackResponse.RequestId = <captured id>`; on mismatch raise `HighBarProtocolException($"CallbackResponse request_id mismatch: expected {expected}, got {actual}")`. On match, return the response as before. This satisfies FR-004 and data-model.md Entity 3.
- [X] T014 [US1] In `clients/fsharp/src/Client.fs`, update the `Run` member (line 120) so that at the top of each iteration of its `while running do` loop it first attempts to dequeue from `replayBuffer`: if the queue is non-empty, dequeue one `PendingFrame`, synthesize a `GameFrame` (`FrameNumber`, `Events`), invoke the `onFrame` handler, and send a `FrameResponse` carrying the handler's returned commands — exactly as the socket-sourced path already does. Only when the queue is empty does the loop call `recvBytes` against the socket. FIFO order must be preserved (data-model.md Entity 2 invariants). This satisfies FR-002.
- [X] T015 [US1] In `clients/fsharp/src/Client.fs`, apply the same buffer-drain logic to the `StepFrame` member (line 161): at the start of each iteration of its `while keepReading do` loop, drain one `PendingFrame` from `replayBuffer` if any, invoke `onFrame`, send the `FrameResponse`, set `result <- Some gameFrame`, set `keepReading <- false`, and skip the socket read. The behaviour for socket-sourced frames is unchanged. This satisfies FR-002 for the single-step API.
- [X] T016 [US1] In `clients/fsharp/src/Client.fs`, run `dotnet build clients/fsharp/HighBar.Client.fsproj` and confirm zero warnings and zero errors. Fix any F# compiler complaint about redefinitions or unreferenced fields before moving on.
- [X] T017 [US1] Re-run `./tests/run-all.sh --category integration` and confirm every existing integration test still passes. Specifically `tests/integration/fsharp/CallbackTests.fs` must not regress — callbacks that previously worked by luck must still work now.
- [X] T018 [US1] Run only `CallbackEventLossTests` (from T010) against the live engine and confirm it passes — both that every topic delta reconciles and that the bot observes at least one `UnitCreated` event within the 1 000-frame window (sanity check that the bot is actually running, not just silently producing an empty tally). This is the gate that satisfies success criterion SC-001.

**Checkpoint**: At this point, User Story 1 is fully functional. The fix is in the client, the live-engine test passes, and no existing tests have regressed. This alone is a shippable MVP.

---

## Phase 4: User Story 2 — Proxy contract documents the interleaving guarantee (Priority: P2)

**Goal**: Update `docs/protocol.md` with a short subsection pointing at the new normative contract document that Phase 1 of planning already drafted at `specs/031-fix-callback-event-drop/contracts/callback-frame-interleaving.md`. After this phase, a greenfield client author can read the docs alone and build a conforming client.

**Independent Test**: `grep -n "Callback/Frame Interleaving" docs/protocol.md` returns one match under the `## Callbacks` section, the subsection links to `specs/031-fix-callback-event-drop/contracts/callback-frame-interleaving.md`, and a second grep `grep -n "request_id" docs/protocol.md` returns a match inside that subsection. This satisfies SC-004.

### Implementation for User Story 2

- [X] T019 [US2] Review the already-drafted contract at `specs/031-fix-callback-event-drop/contracts/callback-frame-interleaving.md` against the final client implementation from Phase 3. If any of the six-step conforming-client procedure diverged from what the fixed client actually does (e.g., the error type name, the buffer bound, the `SendCallback` return semantics), update the contract doc to match reality. The contract is normative — it must describe what the reference client does, not an aspirational design.
- [X] T020 [US2] Edit `docs/protocol.md`. Under the existing `## Callbacks` section (after the "Commonly Used Callbacks" table around line 262) insert a new `### Callback/Frame Interleaving` subsection (~15 lines) stating: (a) the proxy may interleave `Frame` messages between a `CallbackRequest` and its `CallbackResponse`; (b) `CallbackResponse.request_id` echoes the originating request's id and is the only correlation mechanism; (c) conforming clients MUST buffer interleaved frames and replay them to the next frame-consuming API call; (d) dropping the events is non-conforming. End with a link to `../specs/031-fix-callback-event-drop/contracts/callback-frame-interleaving.md` for the full normative contract. Do NOT duplicate the full contract into `docs/protocol.md`.
- [X] T021 [US2] Verify both SC-004 grep commands from the "Independent Test" note above return matches. If either returns zero lines, fix the subsection and retry.

**Checkpoint**: The docs now describe the interleaving contract. A reader who never looks at `Client.fs` can still write a conforming client in any language.

---

## Phase 5: User Story 3 — Deterministic interleaving test (Priority: P3)

**Goal**: Add a hermetic, non-live regression test that runs in under 100 ms and exercises the exact `[Frame; Frame; CallbackResponse]` scenario via a scripted `MemoryStream`. This is the fast regression guard that protects the fix against future refactors of `Client.fs`.

**Independent Test**: Run `dotnet test tests/integration/fsharp/HighBar.Tests.fsproj --filter "FullyQualifiedName~CallbackFrameInterleavingTests"` without starting an engine. The test must pass in under 100 ms (SC-003) and must fail if T012's buffer-and-replay implementation is reverted.

### Implementation for User Story 3

- [X] T022 [US3] In `clients/fsharp/src/Client.fs`, add an `internal` secondary constructor on `HighBarClient` that accepts a pre-opened `System.IO.Stream` in place of the Unix socket. The constructor sets the private `stream` field to `Some <given>` and skips the `Connect()` handshake. Everything else (field init, replay buffer, next request id counter) matches the primary constructor. This is the hook described in research.md R5; its access is gated by the `InternalsVisibleTo("HighBar.Tests")` attribute added in T006.
- [X] T023 [P] [US3] Create `tests/integration/fsharp/CallbackFrameInterleavingTests.fs` as a new F# file, added to `tests/integration/fsharp/HighBar.Tests.fsproj`. This test class does NOT carry `[<Collection("Engine")>]` — it is a hermetic test and must not require the live engine fixture. Add a `[<Trait("Category", "Unit")>]` trait so it is easily filtered.
- [X] T024 [US3] In `CallbackFrameInterleavingTests.fs`, add a helper `buildScriptedStream : ProxyMessage list -> Stream` that serialises each `ProxyMessage` with its existing length-prefix framing into a `MemoryStream`, seeks to the start, and returns a duplex wrapper over that `MemoryStream` and a throwaway `MemoryStream` sink for the write direction. The helper must use the exact same framing routine the client uses for `recvBytes`/`sendMessage` so the test exercises the real codec path.
- [X] T025 [US3] In `CallbackFrameInterleavingTests.fs`, add the main test `[<Fact>] SendCallback preserves interleaved frame events across StepFrame drains`. The test: (a) constructs a scripted stream carrying `[Frame(frame_number=100, events=[UnitCreated u=u14835 defId=42]); Frame(frame_number=110, events=[UnitFinished u=u14835]); CallbackResponse(request_id=1, success=true)]`; (b) builds a `HighBarClient` via the internal constructor from T022 with that stream; (c) calls `client.SendCallback(CallbackMapGetWidth, [])` and asserts it returns a successful response with `request_id = 1`; (d) calls `client.StepFrame` twice, once asserting the first drained frame has `FrameNumber = 100` and its events list contains a `UnitCreated` for `u14835`, and once asserting the second has `FrameNumber = 110` and its events list contains a `UnitFinished` for `u14835`. Zero events may be lost; order must match enqueue order.
- [X] T026 [US3] In `CallbackFrameInterleavingTests.fs`, add a second test `[<Fact>] SendCallback raises HighBarProtocolException on request_id mismatch`. The test scripts `[CallbackResponse(request_id=99, success=true)]`, expects the client's outgoing request to use id 1 (the first request on a fresh connection), calls `SendCallback`, and asserts that a `HighBarProtocolException` is raised with a message containing `"expected 1"` and `"got 99"`. This exercises the FR-004 correlation path added in T013.
- [X] T027 [US3] In `CallbackFrameInterleavingTests.fs`, add `[<Fact>] SendCallback preserves frames across an interleaved SaveRequest`. The test scripts `[Frame(frame_number=50, events=[UnitCreated u=u1 defId=1]); SaveRequest(state_data=empty); Frame(frame_number=60, events=[UnitFinished u=u1]); CallbackResponse(request_id=1, success=true)]` through the scripted stream from T024, calls `SendCallback(CallbackMapGetWidth, [])`, then calls `StepFrame` twice. Assertions: (a) `SendCallback` returns a response with `request_id = 1`; (b) the scripted sink captured exactly one empty `SaveResponse`; (c) the first drained frame has `FrameNumber = 50` and includes the `UnitCreated`; (d) the second has `FrameNumber = 60` and includes the `UnitFinished`. This guards FR-006's "any frames received before a SaveRequest during a callback wait MUST still be replayable" clause.
- [X] T028 [US3] In `CallbackFrameInterleavingTests.fs`, add `[<Fact>] SendCallback honours the 100-attempt cap when frames never stop interleaving`. The test scripts 101 `Frame` messages (no `CallbackResponse`), calls `SendCallback(CallbackMapGetWidth, [])`, and asserts that an exception is raised whose message contains `"exceeded 100 attempts"`. This guards FR-005 and proves the cap is a hard bound on the replay buffer size (data-model.md Entity 2 invariant).
- [X] T029 [US3] Run the `CallbackFrameInterleavingTests` filter and confirm all four tests pass in under 100 ms combined (SC-003). Also confirm they fail deterministically if T012 (the buffer enqueue) or T013 (the correlation check) is temporarily reverted — this proves the tests actually guard the behaviour they claim to guard.

**Checkpoint**: All three user stories are independently functional. The MVP (US1) plus the docs (US2) plus the fast regression guard (US3) — now including SaveRequest-interleave coverage (FR-006) and cap-fires coverage (FR-005) — are in place.

---

## Phase 6: Polish & Cross-Cutting Concerns

**Purpose**: Close the loop on the inbound mailbox, audit edge cases, run full regression, publish the new client version, and walk the quickstart end-to-end.

- [X] T030 [P] Write the reply to FSBarV1 at `Mailbox/2026-04-14_to_FSBarV1_callback-event-drop-resolved.md`. The reply MUST: (a) confirm the root-cause diagnosis from the inbound mailbox (the proxy does interleave Frame with CallbackResponse on the primary socket); (b) state that HighBarV2 chose mailbox Option C — client-side buffer-and-replay — because the proxy already populates `CallbackResponse.request_id` and no wire change is needed; (c) confirm that the HighBar.Client fix ships in version `0.1.3` and that FSBarV1 can remove its "replay instead of drop" stopgap once it pins to that version; (d) acknowledge that FSBarV1's stopgap is acceptable in the meantime; (e) link the new contract doc at `specs/031-fix-callback-event-drop/contracts/callback-frame-interleaving.md`. This satisfies FR-010.
- [X] T031 Walk every edge case enumerated in `spec.md § Edge Cases` and record the resolution for each one in a short `specs/031-fix-callback-event-drop/edge-case-audit.md` file (one section per edge case): (1) callback issued from inside a frame handler — verified by inspection of `Run`/`StepFrame` non-reentrancy; (2) shutdown during callback wait — verified by existing `EngineDisconnectedException` path in `SendCallback`; (3) SaveRequest during callback wait — verified by T027; (4) response out of order — verified by `request_id` correlation in T013 and the test added in T026; (5) replay buffer unbounded growth — verified by the cap test added in T028; (6) unknown `ProxyMessage` case during wait — verified by inspection of the preserved `other -> failwith` arm in `readUntilCallback`. Each section MUST cite the file:line or task id that established the verification. No new runtime behaviour is required — this task closes the traceability gap, it does not add code.
- [X] T032 Run `./tests/run-all.sh` once with no filters and confirm every category passes: unit, proxy, integration, persistent. This is the full regression gate before merge — the fix must not break anything else in the repo.
- [X] T033 Bump `clients/fsharp/HighBar.Client.fsproj` version from `0.1.2` to `0.1.3` (research.md R9). Only run this task AFTER T032 is green — a failing T032 means the fix is not ready and the version bump must wait. If the repo also has a `BarData` version pinned in lockstep from prior commits (see `a1916e5`, `32ce22f`), leave `BarData` unchanged — this fix does not touch `BarData`.
- [X] T034 Walk `specs/031-fix-callback-event-drop/quickstart.md` top to bottom and execute every shell command literally. Every command must succeed, every grep must return the expected match, and every test must pass. If any step diverges from what quickstart says, fix the quickstart or the implementation to match. Additionally note in the walk log that SC-002 and SC-005 require verification in the FSBarV1 repository after it pins to `HighBar.Client` 0.1.3 — those two SCs are outside HighBarV2's automated test surface; their closure signal is the FSBarV1 maintainer reporting a successful `024-macro-smoke` outcome on five consecutive runs. Link the `Mailbox/2026-04-14_to_FSBarV1_callback-event-drop-resolved.md` reply authored in T030 so the traceability is explicit.
- [X] T035 Re-open `specs/031-fix-callback-event-drop/checklists/requirements.md` and re-run the quality checklist against the final spec + plan + tasks. Any item that was PASS at spec-authoring time but now fails (e.g., because an FR-line's acceptance criterion is no longer accurate) must be corrected in the spec or plan before the feature is considered complete.

---

## Dependencies & Execution Order

### Phase Dependencies

- **Phase 1 (Setup)**: No dependencies — start immediately.
- **Phase 2 (Foundational)**: Depends on Phase 1. Blocks all user stories.
- **Phase 3 (US1)**: Depends on Phase 2.
- **Phase 4 (US2)**: Depends on Phase 2 only. Does NOT depend on US1 — the docs describe the contract, not a specific implementation state, so they can be written in parallel with the client fix. However, T019 (the "contract reconciliation against final implementation" task) should wait until T012–T015 are landed; the T020 doc-insertion task can proceed any time after T006.
- **Phase 5 (US3)**: Depends on Phase 3 because T022 adds a constructor to `Client.fs` and T025 asserts on the behaviour the US1 fix introduced. T022 could overlap with T012–T015, but to keep `Client.fs` diffs conflict-free it is cleaner to land US1 first, then US3.
- **Phase 6 (Polish)**: Depends on US1, US2, US3 all complete.

### User Story Dependencies

- **US1 (P1)**: Foundational only. Implements the fix and its live-engine verification.
- **US2 (P2)**: Foundational only. Describes the contract; can run in parallel with US1 after the contract reconciliation moment noted above.
- **US3 (P3)**: Depends on US1 (adds a regression test for US1's behaviour and uses a constructor that touches the same file).

### Within Each User Story

- **US1**: Tests T007–T010 are written first and FAIL on the unfixed client. Then T011–T016 implement the fix. T017 confirms no regression. T018 confirms the failing test now passes.
- **US2**: T019 reviews against the final implementation, T020 edits the public doc, T021 verifies.
- **US3**: T022 adds the test hook, T023–T028 add the four hermetic tests (main interleaving, request_id mismatch, SaveRequest preservation, 100-attempt cap), T029 verifies pass + revert-sensitivity.

### Parallel Opportunities

- **Inside Phase 2**: T004 and T005 touch different parts of the same file but are independent — they can be done by one pass over the file. T006 touches a different file (`AssemblyInfo.fs` or a new attribute line) and is [P] with T004/T005.
- **Inside Phase 3**: T007, T008, T009 are in the same new test file and therefore NOT parallelizable with each other by strict file-ownership rules, but they are the only tasks in that file and can be done in one editing pass. T011–T015 all modify `Client.fs`, so they serialize on that file.
- **Phase 3 vs Phase 4**: US1 implementation (T011–T018) can run in parallel with US2's doc draft review (T019) and edit (T020) as long as T019 waits for a stable US1 build.
- **Polish phase**: T030 (mailbox reply) is `[P]` and touches only `Mailbox/...` — it can run in parallel with any other polish task. T031 (edge-case audit) writes to a new `edge-case-audit.md` file and can overlap with T032's regression run. T033 (version bump) is **gated** on T032 passing — do not bump the version until the full `./tests/run-all.sh` sweep is green.

---

## Parallel Example: Phase 3 test-first flow

```bash
# Step 1: write all US1 test tasks in a single editing pass
#   (they all live in the same new file)
edit: tests/integration/fsharp/CallbackEventLossTests.fs   # T007, T008, T009, T010

# Step 2: confirm baseline failure
dotnet test tests/integration/fsharp/HighBar.Tests.fsproj --filter "FullyQualifiedName~CallbackEventLossTests"
# expected: test from T010 FAILS on current client (demonstrates the bug)

# Step 3: implement the fix across Client.fs (one editor session)
edit: clients/fsharp/src/Client.fs                         # T011, T012, T013, T014, T015

# Step 4: build and re-run
dotnet build clients/fsharp/HighBar.Client.fsproj          # T016
./tests/run-all.sh --category integration                  # T017
dotnet test tests/integration/fsharp/HighBar.Tests.fsproj --filter "FullyQualifiedName~CallbackEventLossTests"   # T018
```

---

## Implementation Strategy

### MVP First (User Story 1 only)

1. Complete Phase 1 (Setup) — T001, T002, T003.
2. Complete Phase 2 (Foundational) — T004, T005, T006.
3. Complete Phase 3 (US1) — T007–T018.
4. **STOP and VALIDATE**: the live test passes; no existing test regresses; the
   FSBarV1 repro scenario (SC-002) no longer races. This alone resolves the
   inbound mailbox.
5. Ship US1 as the MVP — FSBarV1 can then pick up the fix immediately.

### Incremental Delivery

1. Setup + Foundational → foundation ready.
2. Add US1 → live test passes → MVP shippable → can be merged to master.
3. Add US2 → protocol doc now describes the contract.
4. Add US3 → hermetic regression guard in place.
5. Polish phase → mailbox reply out, version bumped, full test sweep green, quickstart walked.

### Parallel Team Strategy

With two developers:

1. Both land Phase 1 + Phase 2 together (trivial, one pass).
2. Developer A: US1 (the actual fix and its live test).
3. Developer B: US2 (doc edit) in parallel, waiting on A for the T019 contract reconciliation moment.
4. Developer A picks up US3 after US1 is green (it touches the same file as US1).
5. Either developer writes the mailbox reply and bumps the version in the polish phase.

---

## Notes

- `[P]` tasks = different files, no dependencies on incomplete tasks.
- `[Story]` label maps a task to its user story for traceability.
- Tests (US1's live test, US3's deterministic test) are written before the
  corresponding implementation task in the same phase and MUST fail on the
  pre-fix client before they can pass on the post-fix client. This is the
  strongest single gate against false positives.
- Stop at any checkpoint to validate a story independently — the phases are
  arranged so each stops at a genuinely shippable increment.
- Avoid: touching `proto/highbar/*.proto` (explicitly out of scope — the
  fix reuses existing fields); editing `proxy/src/*` (explicitly out of scope —
  research R2 verified the proxy already does its part); introducing new test
  projects (research R4 rejected this); writing documentation that duplicates
  the normative contract into `docs/protocol.md` (T020 note — the doc is a
  pointer, the contract file is the source of truth).
