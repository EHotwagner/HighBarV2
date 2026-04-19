# Tasks: Comprehensive Gamestate Snapshot

**Input**: Design documents from `/specs/032-batch-callback-rpcs/`
**Prerequisites**: plan.md, spec.md, research.md, data-model.md, contracts/gamestate-snapshot.md, quickstart.md

**Tests**: Included — spec lists test targets (SC-001..SC-005) and plan.md explicitly calls for CTest round-trip, xUnit unit, and live-engine integration tests.

**Organization**: One user story in scope (US1 — per-tick gamestate snapshot). Setup + Foundational (proto schema) are shared prerequisites.

## Format: `[ID] [P?] [Story] Description`

---

## Phase 1: Setup (Shared Infrastructure)

**Purpose**: Ensure codegen + build prerequisites are available for new proto messages.

- [X] T001 Verify `buf` CLI and `protobuf-c` are available, and baseline `cmake -B build -S proxy && cmake --build build` and `cd clients/fsharp && dotnet build` succeed on the 032 branch (no code changes, just a clean baseline before schema edits)

---

## Phase 2: Foundational (Blocking Prerequisites)

**Purpose**: Add wire-level protobuf entities that every subsequent proxy/client task consumes. MUST complete before US1 implementation begins.

- [X] T002 Add `CALLBACK_GAME_GET_STATE = 15` to the `CallbackId` enum in `proto/highbar/callbacks.proto` (Game range 10..19) per contracts/gamestate-snapshot.md
- [X] T003 Add `FriendlyUnit`, `LosEnemyUnit`, `RadarOnlyEnemyUnit`, `EconomyRecord`, and `GameStateSnapshot` messages to `proto/highbar/callbacks.proto` per data-model.md (radar-only MUST NOT declare a `health` field)
- [X] T004 Add `GameStateSnapshot snapshot_value = 8;` to the `CallbackResult` oneof in `proto/highbar/callbacks.proto`
- [X] T005 From `proto/`, run `buf lint && buf generate` to regenerate C (protobuf-c) and F# (Google.Protobuf) bindings; verify generated output is NOT checked into git
- [X] T006 Rebuild proxy (`cmake -B build -S proxy && cmake --build build`) and F# client (`cd clients/fsharp && dotnet build`) to confirm the regenerated bindings compile against current proxy and client source before any handler code is added

**Checkpoint**: Proto schema and generated bindings are in place; proxy + client still build. US1 work can start.

---

## Phase 3: User Story 1 — One-call per-tick gamestate snapshot (Priority: P1) 🎯 MVP

**Goal**: A single `client.GetGameState()` call returns every friendly, every LOS enemy, every radar-only enemy, and the economy record in one IPC round-trip, enumerated by the proxy.

**Independent Test**: Against a live (or mock) proxy with N friendlies and M visible enemies, one `GetGameState()` call returns the complete snapshot in a single round-trip and well under 33 ms at the reference load (200 + 50).

### Tests for User Story 1

> Write failing tests first, then implement.

- [X] T007 [P] [US1] C proxy round-trip test in `tests/proxy/test_gamestate_snapshot.c` — build a `GameStateSnapshot` with representative friendly/LOS/radar entries + economy, serialize via protobuf-c arena, parse back, and assert field-for-field equality (covers FR-001, FR-004..FR-007, data-model.md)
- [X] T008 [P] [US1] F# unit test in `clients/fsharp/tests/unit/GameStateSnapshotTests.fs` — encode a `GameStateSnapshot` proto fixture, decode into the F# `GameStateSnapshot` record, and assert radar-only entries have no `Health` field accessible at the type level (structural "no health" contract, Decision 4)
- [X] T009 [P] [US1] F# integration test in `clients/fsharp/tests/integration/GetGameStateTests.fs` — against the live headless engine, assert `client.GetGameState()` returns counts matching per-unit enumeration, classifies LOS vs radar correctly (SC-004), completes in one round-trip (FR-001..FR-003), asserts exactly one `CallbackRequest`/`CallbackResponse` pair via a socket-level counter or request-id tap (SC-002), and that `snapshot.Frame` is stable — call `Game_getCurrentFrame` immediately before and after the snapshot in the same simulation pause and assert `snapshot.Frame` falls within that window (FR-012)
- [ ] T010 [US1] F# persistent-engine perf test in `clients/fsharp/tests/persistent/GetGameStatePerfTests.fs` — at 200 friendlies + 50 enemies (cheat-spawned), assert wall-clock for a single `GetGameState()` is under 10 ms (SC-001) and no upstream `GameEvent.Update` throttling or drops occur over ≥300 consecutive frames (10 s) (SC-003)
- [X] T011 [US1] F# integration test in `clients/fsharp/tests/integration/GetGameStateDisconnectTests.fs` — mid-call engine disconnect surfaces `EngineDisconnectedException` (from feature 023) with no partial snapshot (FR-011)
- [X] T011a [P] [US1] C proxy test in `tests/proxy/test_gamestate_cap.c` — with a synthetic callback table reporting more than `HIGHBAR_SNAPSHOT_MAX_UNITS` units, assert the handler produces `success=false`, a descriptive `error_message`, and no `snapshot_value` is emitted (Edge Cases, contracts Failure modes)

### Implementation for User Story 1

- [X] T012 [US1] In `proxy/src/callbacks.c`, add a handler for `CALLBACK_GAME_GET_STATE`: read `Game_getCurrentFrame`, enumerate friendlies via `getTeamUnits(myTeam)`, enumerate enemies via `getEnemyUnitsInRadarAndLos(...)`, classify each via `Unit_isInLos`, populate the eight `Economy_*` fields, reject and fail the snapshot (`success=false`, populated `error_message`) if `(friendly_count + enemy_count) > HIGHBAR_SNAPSHOT_MAX_UNITS` (default 4096; read once at `init` from env var `HIGHBAR_SNAPSHOT_MAX_UNITS`), and otherwise return a populated `GameStateSnapshot` as `CallbackResult.snapshot_value` (all allocation from the per-frame arena — Decision 6 / Principle V)
- [X] T013 [US1] In `proxy/src/serialize.c` (or the equivalent encode path for `CallbackResult`), wire the `snapshot_value` variant through the existing `CallbackResponse` serializer; ensure failure on any sub-callback sets `success=false` + `error_message` and emits NO partial snapshot (FR-011, contracts/ Failure modes)
- [X] T014 [P] [US1] Create `clients/fsharp/src/GameState.fs` with F# records `FriendlyUnit`, `LosEnemyUnit`, `RadarOnlyEnemyUnit`, `EconomyRecord`, `GameStateSnapshot`, plus `fromProto` converters from the generated Google.Protobuf types; `RadarOnlyEnemyUnit` MUST NOT expose a `Health` member
- [X] T015 [US1] In `clients/fsharp/src/Client.fs`, add `member Client.GetGameState : unit -> Async<GameStateSnapshot>` that issues one `CallbackRequest` with `CALLBACK_GAME_GET_STATE` and empty params, awaits the matching `CallbackResponse`, and returns `GameState.fromProto` of the `snapshot_value` (surfacing `EngineDisconnectedException` unchanged)
- [ ] T016 [US1] In `clients/fsharp/src/UnitRegistry.fs`, replace the per-unit `refreshUnit` loop with a single `GetGameState()` consumer that rebuilds the registry from the returned friendlies/enemies collections; keep existing per-unit `getUnitPos` / `getUnitHealth` code paths in place untouched (FR-009)
- [X] T017 [US1] Update `clients/fsharp/HighBar.Client.fsproj` `<Compile>` ordering to include `GameState.fs` before `UnitRegistry.fs` and before `Client.fs`, and bump the `<Version>` (e.g. `0.1.5`) so downstream consumers pick up the new API

**Checkpoint**: `client.GetGameState()` is callable end-to-end against the live engine; perf + disconnect tests pass; existing per-unit callback tests are unregressed.

---

## Phase 4: Polish & Cross-Cutting Concerns

- [ ] T018 [P] Update `docs/` (or the proxy contract doc added in 030) to describe `CALLBACK_GAME_GET_STATE` and the `GameStateSnapshot` variant — include the request/response shape from `specs/032-batch-callback-rpcs/contracts/gamestate-snapshot.md`
- [X] T019 [P] Bump `BarData` / `HighBar.Client` versions consistently with prior commits in `clients/fsharp/` and refresh `CLAUDE.md`'s Recent Changes bullet for 032 if needed
- [ ] T020 Run the full suite via `./tests/run-all.sh` (categories: unit, proxy, integration, persistent) and confirm SC-001..SC-005 all pass; explicitly re-run the pre-032 per-unit callback tests (`getUnitPos`, `getUnitHealth`, and the existing `UnitRegistry` tests) and confirm zero regressions (SC-005, FR-009); attach the perf number from T010 to the PR description
- [ ] T021 Walk through `specs/032-batch-callback-rpcs/quickstart.md` manually against a live headless run to validate the "What to verify manually" checklist (round-trip count = 1, radar-only has no `Health`, <10 ms at reference load, existing single-unit callers unregressed)

---

## Dependencies & Execution Order

### Phase Dependencies

- **Setup (Phase 1)**: no dependencies
- **Foundational (Phase 2)**: depends on Phase 1; BLOCKS US1
- **User Story 1 (Phase 3)**: depends on Phase 2
- **Polish (Phase 4)**: depends on US1 completion

### Within User Story 1

- T007–T011 (tests) SHOULD be written and failing before T012–T017 (implementation)
- T012 (proxy handler) and T013 (proxy serialize wiring) precede live-engine tests passing (T009, T010, T011)
- T014 (F# types) precedes T015 (client API) and T016 (registry refactor)
- T015 precedes T016 (registry consumes the client API)
- T017 is last within US1 (version bump / fsproj ordering)

### Parallel Opportunities

- T007, T008, T009 are in different test projects / files and can be authored in parallel
- T014 (F# GameState.fs) can be authored in parallel with T012/T013 (proxy C code)
- Polish tasks T018 and T019 are independent files → parallel

---

## Parallel Example: User Story 1

```bash
# Author failing tests in parallel:
Task: "C proxy round-trip test in tests/proxy/test_gamestate_snapshot.c"
Task: "F# unit test in clients/fsharp/tests/unit/GameStateSnapshotTests.fs"
Task: "F# integration test in clients/fsharp/tests/integration/GetGameStateTests.fs"

# Then, implementation split across proxy and client:
Task: "Proxy handler + serialize wiring (T012, T013) in proxy/src/"
Task: "F# GameState.fs record + converters (T014) in clients/fsharp/src/GameState.fs"
```

---

## Implementation Strategy

### MVP (US1 only — the whole feature)

1. Phase 1 Setup → Phase 2 Foundational (proto schema + codegen) → Phase 3 US1 → Phase 4 Polish.
2. Gate merge on SC-001 (<10 ms at 200+50) and SC-005 (no regression in existing client tests).

### Suggested MVP Scope

- Tasks T001–T017 deliver the full user story. T018–T021 are polish and can land in a follow-up commit on the same branch.

---

## Notes

- Only US1 exists in this spec; there are no US2/US3 phases.
- Generated proto code MUST NOT be committed (repo convention).
- All proxy allocation on the snapshot path goes through the per-frame arena (Decision 6 / Constitution V).
- Radar-only "no health" is expressed structurally in both proto (distinct message) and F# (distinct record) — do NOT collapse into a shared type with optional/zero health.
