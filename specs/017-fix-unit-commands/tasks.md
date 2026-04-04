# Tasks: Fix Unit Commands

**Input**: Design documents from `/specs/017-fix-unit-commands/`
**Prerequisites**: plan.md, spec.md, research.md, data-model.md, quickstart.md

**Tests**: Test enhancement tasks included (mock engine verification of the commandId parameter).

**Organization**: Tasks grouped by user story for independent implementation and testing.

## Format: `[ID] [P?] [Story] Description`

- **[P]**: Can run in parallel (different files, no dependencies)
- **[Story]**: Which user story this task belongs to (e.g., US1, US2)
- Exact file paths included in descriptions

---

## Phase 1: Setup

**Purpose**: Define the named constant and prepare the codebase

- [x] T001 Add `COMMAND_ID_UNTRACKED` constant (`-1`) to `proxy/include/highbar/engine_types.h`

---

## Phase 2: Foundational (Blocking Prerequisites)

**Purpose**: Core fix that all user stories depend on

**CRITICAL**: This phase IS the bug fix. All user stories validate it.

- [x] T002 Replace all `0` with `COMMAND_ID_UNTRACKED` as the third argument to `handle_command()` calls in `proxy/src/deserialize.c` (~35 call sites)
- [x] T003 Remove direct-test debug code (frame 150 spawn+move+self-destruct, frame 300 spawn) from `proxy/src/proxy.c` lines 391-448
- [x] T004 Update direct `Engine_handleCommand` calls in `proxy/src/proxy.c` (if any remain after T003) to use `COMMAND_ID_UNTRACKED`

**Checkpoint**: All command paths now use `-1` as commandId. Build must succeed.

---

## Phase 3: User Story 1 - AI Issues Unit Commands That Execute (Priority: P1) MVP

**Goal**: Unit commands (move, patrol, fight, self-destruct) sent by the proxy are executed by the engine.

**Independent Test**: Build proxy, install to BAR, start a game with HighBarV2 AI. Issue a move command on the starting commander. Commander must visibly move.

### Tests for User Story 1

- [x] T005 [P] [US1] Enhance mock engine to record `commandId` parameter: add `mock_engine_get_last_command_id()` and `mock_engine_get_recorded_command_id(int index)` to `proxy/tests/mock_engine.c` and `proxy/tests/mock_engine.h`
- [x] T006 [US1] Add `commandId == -1` assertions to existing deserialize tests for move, patrol, fight, attack, self-destruct commands in `proxy/tests/test_deserialize.c`

### Verification for User Story 1

- [x] T007 [US1] Build proxy (`cmake -B build -DCMAKE_BUILD_TYPE=Release proxy/ && cmake --build build`) and run C tests (`cd build && ctest --output-on-failure`)
- [ ] T008 [US1] Install proxy to BAR (`scripts/install-ai.sh`) and verify unit commands work in a live game per `specs/017-fix-unit-commands/quickstart.md`

**Checkpoint**: Unit commands execute in live game. Core bug is fixed.

---

## Phase 4: User Story 2 - Existing Cheat Commands Continue Working (Priority: P1)

**Goal**: Cheat commands (spawning units, giving resources) still function after the fix.

**Independent Test**: In a live game with cheats enabled, spawn a unit. It must appear. Then move it. It must move.

### Verification for User Story 2

- [x] T009 [US2] Verify cheat command tests still pass in `proxy/tests/test_deserialize.c` (GIVE_ME_NEW_UNIT, GIVE_ME commands)
- [ ] T010 [US2] In live game: spawn a unit via cheat command, then issue a move command on it — both must work

**Checkpoint**: Cheat commands work and cheat-spawned units respond to move commands.

---

## Phase 5: User Story 3 - Automated Tests Pass (Priority: P2)

**Goal**: Full test suite passes with no regressions.

**Independent Test**: Run `dotnet test` in F# client and `ctest` in proxy build.

### Verification for User Story 3

- [x] T011 [US3] Build F# client (`cd clients/fsharp && dotnet build`) and verify no compilation errors
- [x] T012 [US3] Run full C proxy test suite and confirm all tests pass including new commandId assertions
- [x] T013 [US3] Revert any uncommitted debug changes in `proxy/src/config.c` that are not part of this fix

**Checkpoint**: All automated tests pass with no regressions.

---

## Phase 6: Polish & Cross-Cutting Concerns

**Purpose**: Cleanup and documentation

- [x] T014 [P] Update `reports/014-live-game-ai-installation.md` to document the root cause and solution in the "Root Cause" and "Solution" sections (N/A — report file does not exist)
- [x] T015 Run quickstart.md validation end-to-end (automated steps verified: build + ctest + F# build)

---

## Dependencies & Execution Order

### Phase Dependencies

- **Setup (Phase 1)**: No dependencies — define the constant
- **Foundational (Phase 2)**: Depends on T001 — apply the fix
- **US1 (Phase 3)**: Depends on Phase 2 — verify unit commands work
- **US2 (Phase 4)**: Depends on Phase 2 — verify cheat commands still work
- **US3 (Phase 5)**: Depends on Phases 3+4 — full regression check
- **Polish (Phase 6)**: Depends on all user stories passing

### User Story Dependencies

- **US1 (P1)**: Independent after Phase 2
- **US2 (P1)**: Independent after Phase 2 (can run in parallel with US1)
- **US3 (P2)**: Depends on US1 and US2 tests being added (T005-T006)

### Within Each User Story

- Tests/mock enhancements before verification
- Build before live testing

### Parallel Opportunities

- T005 (mock enhancement) can run in parallel with T002-T004 (the fix itself)
- US1 and US2 verification (Phases 3-4) can run in parallel after Phase 2
- T014 (report update) can run in parallel with any other task

---

## Parallel Example: Foundational + Test Prep

```bash
# These can run in parallel (different files):
Task T002: "Replace 0 with COMMAND_ID_UNTRACKED in proxy/src/deserialize.c"
Task T005: "Enhance mock engine to record commandId in proxy/tests/mock_engine.c"
```

---

## Implementation Strategy

### MVP First (User Story 1 Only)

1. Complete Phase 1: Add constant (T001)
2. Complete Phase 2: Apply fix (T002-T004)
3. Complete Phase 3: Verify unit commands work (T005-T008)
4. **STOP and VALIDATE**: Commander moves when ordered in live game

### Incremental Delivery

1. T001-T004 → Fix applied, proxy builds
2. T005-T008 → Unit commands verified in tests + live game (MVP!)
3. T009-T010 → Cheat commands verified
4. T011-T013 → Full regression check
5. T014-T015 → Documentation and final validation

---

## Notes

- This is a minimal bug fix — the core change is a single constant (`0` → `-1`) across ~35 call sites
- The F# client (`clients/fsharp/src/Commands.fs`) needs NO changes — `commandId` is proxy-internal
- Debug code in `proxy/src/proxy.c` (frames 150/300) should be removed as it was diagnostic
- Other uncommitted changes in `proxy/src/config.c` may contain debug settings that should be reverted
