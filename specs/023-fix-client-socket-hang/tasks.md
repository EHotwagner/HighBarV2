# Tasks: Fix Client Socket Handling Bug

**Input**: Design documents from `/specs/023-fix-client-socket-hang/`
**Prerequisites**: plan.md (required), spec.md (required for user stories), research.md, data-model.md

**Tests**: Not separately generated — this is a bug fix. Verification is done by running existing test tiers and manual engine-kill testing.

**Organization**: Tasks are grouped by user story to enable independent implementation and validation of each story.

## Format: `[ID] [P?] [Story] Description`

- **[P]**: Can run in parallel (different files, no dependencies)
- **[Story]**: Which user story this task belongs to (e.g., US1, US2, US3)

---

## Phase 1: Setup

**Purpose**: Verify current behavior and establish baseline

- [X] T001 Build F# client and persistent tests to confirm clean build: `dotnet build clients/fsharp/ && dotnet build tests/persistent/fsharp/`
- [X] T002 Reproduce the bug: start persistent tests, kill engine mid-run, confirm client hangs at high CPU instead of failing cleanly

---

## Phase 2: Foundational (Blocking Prerequisites)

**Purpose**: Create the exception type needed by all user stories

- [X] T003 Add `EngineDisconnectedException` exception type to `clients/fsharp/src/Client.fs` — inherit from `System.IO.IOException`, include a message distinguishing peer-closed vs timeout, and an optional `LastFrameNumber` property

**Checkpoint**: Exception type available for US1-US3

---

## Phase 3: User Story 1 — Client Detects Engine Disconnection (Priority: P1) MVP

**Goal**: Eliminate the infinite loop in `recvBytes` when the engine dies. The client throws `EngineDisconnectedException` instead of spinning.

**Independent Test**: Kill the engine process during `dotnet test tests/persistent/fsharp/` and verify the test process fails cleanly within 10 seconds instead of hanging.

### Implementation for User Story 1

- [X] T004 [US1] Fix `recvBytes` in `clients/fsharp/src/Client.fs` — after each `s.Read()` call, check if return value is 0 (peer closed connection). If so, throw `EngineDisconnectedException` with message "Engine proxy closed connection" and the bytes-read-so-far context.
- [X] T005 [US1] Set `NetworkStream.ReadTimeout` to default 10000ms in `AcceptFrom`, `Connect`, and `WrapSocket` methods in `clients/fsharp/src/Client.fs`. Wrap the `IOException` from timeout in `EngineDisconnectedException` with message "Engine proxy read timeout".
- [X] T006 [US1] Build and verify: `dotnet build clients/fsharp/` — no compile errors
- [X] T007 [US1] Verify fix: start persistent tests, kill engine mid-run, confirm client throws exception within 10s and test process exits (not hangs)

**Checkpoint**: Core bug fixed. Client no longer hangs when engine dies.

---

## Phase 4: User Story 2 — Test Harness Recovers from Engine Death (Priority: P2)

**Goal**: When `RunFrames` encounters a disconnection, the current test fails with diagnostics and subsequent tests skip immediately.

**Independent Test**: Run persistent test suite, kill engine during an early test (e.g., T4), verify later tests (T5, T6, etc.) skip with "engine crashed" message rather than hanging.

### Implementation for User Story 2

- [X] T008 [US2] Update `RunFrames` in `tests/persistent/fsharp/PersistentHarness.fs` — catch `EngineDisconnectedException` alongside the existing `"CAPTURED_ENOUGH"` exception handler. When caught, log the last frame number and elapsed time, then re-throw as a test failure with diagnostic info.
- [X] T009 [US2] Update `ResetGameState` in `tests/persistent/fsharp/PersistentHarness.fs` — check `IsEngineAlive` at the start before attempting any socket operations. If engine is dead, return immediately (no-op).
- [X] T010 [US2] Update `RunFramesWithEventLog` in `tests/persistent/fsharp/PersistentHarness.fs` — same disconnect handling as `RunFrames` (T008).
- [X] T011 [US2] Build and verify: `dotnet build tests/persistent/fsharp/` — no compile errors
- [X] T012 [US2] Verify fix: run persistent tests, kill engine during T4 combat test, confirm remaining tests skip with "engine crashed" message

**Checkpoint**: Test harness recovers gracefully from engine death.

---

## Phase 5: User Story 3 — Configurable Socket Timeout (Priority: P3)

**Goal**: Timeout configurable via environment variable and constructor parameter.

**Independent Test**: Set `HIGHBAR_CLIENT_TIMEOUT_MS=2000`, kill engine, verify detection within ~2 seconds.

### Implementation for User Story 3

- [X] T013 [US3] Add timeout parameter to `HighBarClient` constructor in `clients/fsharp/src/Client.fs` — read `HIGHBAR_CLIENT_TIMEOUT_MS` env var (default 10000ms), allow constructor override. Store as instance field.
- [X] T014 [US3] Use the stored timeout value when setting `NetworkStream.ReadTimeout` in `AcceptFrom`, `Connect`, and `WrapSocket` (update from hardcoded 10000 to the configurable value)
- [X] T015 [US3] Build and verify: `dotnet build clients/fsharp/` — no compile errors
- [X] T016 [US3] Verify fix: set `HIGHBAR_CLIENT_TIMEOUT_MS=2000`, run a persistent test that kills the engine, confirm detection within ~2 seconds

**Checkpoint**: Timeout is fully configurable.

---

## Phase 6: Polish & Cross-Cutting Concerns

**Purpose**: Final validation across all tiers

- [X] T017 Run full test suite to confirm no regressions: `./tests/run-all.sh`
- [X] T018 Run proxy tier to verify no impact: `./tests/run-all.sh --category proxy`
- [X] T019 Run integration tier to verify timeout doesn't cause false failures: `./tests/run-all.sh --category integration`

---

## Dependencies & Execution Order

### Phase Dependencies

- **Setup (Phase 1)**: No dependencies — start immediately
- **Foundational (Phase 2)**: Depends on Setup — BLOCKS all user stories
- **US1 (Phase 3)**: Depends on Foundational — can start first (P1 priority)
- **US2 (Phase 4)**: Depends on US1 (needs EngineDisconnectedException to catch)
- **US3 (Phase 5)**: Depends on US1 (needs timeout mechanism to exist)
- **Polish (Phase 6)**: Depends on ALL user stories complete

### User Story Dependencies

- **US1 (Client disconnect detection)**: Core fix — all other stories depend on this
- **US2 (Harness recovery)**: Depends on US1 exception type being thrown
- **US3 (Configurable timeout)**: Depends on US1 timeout mechanism existing

### Within Each User Story

- Implementation before verification
- Build check before integration test

---

## Implementation Strategy

### MVP First (User Story 1 Only)

1. Complete Phase 1: Setup (baseline)
2. Complete Phase 2: Foundational (exception type)
3. Complete Phase 3: User Story 1 (fix recvBytes + add timeout)
4. **STOP and VALIDATE**: Kill engine during test run — client should fail cleanly
5. This alone eliminates the 87% CPU hang bug (SC-001, SC-002)

### Incremental Delivery

1. Setup + Foundational → Exception type ready
2. US1 → Core hang eliminated → Validate (MVP!)
3. US2 → Test harness recovery → Validate (SC-003, SC-005)
4. US3 → Configurable timeout → Validate (SC-001 with custom values)
5. Polish → Full suite green (SC-004)

---

## Notes

- [P] tasks = different files, no dependencies
- [Story] label maps task to specific user story for traceability
- US2 and US3 are sequential (both depend on US1)
- Verification tasks (T007, T012, T016) require a running engine — use `./tests/run-all.sh --category persistent`
- The fix touches only 2 source files: `Client.fs` and `PersistentHarness.fs`
