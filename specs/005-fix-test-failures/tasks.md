# Tasks: Fix Remaining Test Failures

**Input**: Design documents from `/specs/005-fix-test-failures/`
**Prerequisites**: plan.md (required), spec.md (required for user stories), research.md, data-model.md

## Format: `[ID] [P?] [Story] Description`

- **[P]**: Can run in parallel (different files, no dependencies)
- **[Story]**: Which user story this task belongs to (e.g., US1, US2, US3)
- Include exact file paths in descriptions

---

## Phase 1: Foundational (Research Validation)

**Purpose**: Validate that the BAR game content and engine are ready before making changes

- [X] T001 Verify full BAR game archive is installed by checking for game content under ~/.spring/games/
- [X] T002 Read BAR's `game_initial_spawn.lua` from the installed game archive to confirm required modoptions (teamfaction, startboxes, StartPosType)

**Checkpoint**: Game content confirmed present; modoption requirements validated against actual source

---

## Phase 2: User Story 1 - BAR Game Spawns Units in Headless Tests (Priority: P1) MVP

**Goal**: Update game-setup.txt so BAR's spawn gadget creates commander units, fixing 10 unit-dependent tests

**Independent Test**: Run `cd tests/integration/fsharp && dotnet test --filter "UnitCreated"` — should pass with units spawning within first 30 frames

### Implementation for User Story 1

- [X] T003 [US1] Change `StartPosType=0` to `StartPosType=2` in tests/fixtures/game-setup.txt
- [X] T004 [US1] Add `startboxes=return { [0] = { 0, 0, 0.5, 1 }, [1] = { 0.5, 0, 1, 1 } };` to [MODOPTIONS] section in tests/fixtures/game-setup.txt
- [X] T005 [US1] Add `teamfaction_0=armada;` and `teamfaction_1=cortex;` to [MODOPTIONS] section in tests/fixtures/game-setup.txt
- [X] T006 [US1] Add `Side=Armada;` to [TEAM0] and `Side=Cortex;` to [TEAM1] sections in tests/fixtures/game-setup.txt
- [X] T007 [US1] Run full F# test suite (`cd tests/integration/fsharp && dotnet test`) and verify the 10 unit-dependent tests now pass. Check engine infolog for unit creation events and absence of "No modoption start position data found" warning.

**Checkpoint**: 10 unit-dependent tests pass. Engine infolog shows commander spawning. Total should be 21/23 or better.

---

## Phase 3: User Story 2 - Init Event Captured in Tests (Priority: P2)

**Goal**: Fix Init event test expectations so both Init tests pass regardless of timing

**Independent Test**: Run `cd tests/integration/fsharp && dotnet test --filter "Init"` — both Init event tests should pass

### Implementation for User Story 2

- [X] T008 [US2] Read tests/integration/fsharp/ConnectionTests.fs to find the "First frame contains Init event" test and understand current frame collection logic
- [X] T009 [US2] Read tests/integration/fsharp/EventTests.fs to find the "Init event received with valid team ID" test and understand current frame collection logic
- [X] T010 [US2] Update "First frame contains Init event" test in tests/integration/fsharp/ConnectionTests.fs to collect multiple frames (e.g., 5) and scan all for Init event instead of checking only the first frame
- [X] T011 [US2] Update "Init event received with valid team ID" test in tests/integration/fsharp/EventTests.fs to collect multiple frames and scan all for Init event with valid team ID
- [X] T012 [US2] Run full F# test suite (`cd tests/integration/fsharp && dotnet test`) and verify all 22 tests pass

**Checkpoint**: All 23 integration tests pass (up from 11/23)

---

## Phase 4: User Story 3 - Test Fix Report (Priority: P3)

**Goal**: Document fixes, root cause confirmation, and final test results

**Independent Test**: Report file exists at reports/011-test-fix-results.md with correct format and accurate content

### Implementation for User Story 3

- [X] T013 [US3] Read reports/TEMPLATE.md (if exists) or reports/010-remaining-test-failures.md to understand the report format and numbering convention
- [X] T014 [US3] Create reports/011-test-fix-results.md documenting: before state (11 pass, 12 fail), root cause 1 (missing spawn modoptions — config fix), root cause 2 (Init event timing — test fix), exact changes made with file paths, after state (full test results), and any remaining issues or follow-up items (e.g., Python harness update)

**Checkpoint**: Report written and follows project conventions

---

## Dependencies & Execution Order

### Phase Dependencies

- **Phase 1 (Foundational)**: No dependencies — start immediately
- **Phase 2 (US1 - Spawn Config)**: Depends on Phase 1 for modoption validation
- **Phase 3 (US2 - Init Event)**: Can start after Phase 1; independent of Phase 2
- **Phase 4 (US3 - Report)**: Depends on Phase 2 and Phase 3 completion (needs final test results)

### User Story Dependencies

- **User Story 1 (P1)**: Independent — config-only change
- **User Story 2 (P2)**: Independent — test code-only change. Can run in parallel with US1.
- **User Story 3 (P3)**: Depends on US1 and US2 being complete (report documents final results)

### Parallel Opportunities

- T003, T004, T005, T006 are all edits to the same file (game-setup.txt) — execute sequentially or as a single edit batch
- T008 and T009 are reads of different files — can run in parallel
- T010 and T011 are edits to different files — can run in parallel [P]
- US1 and US2 implementation can proceed in parallel after Phase 1

---

## Parallel Example: User Story 2

```bash
# Read both test files in parallel:
Task: "Read ConnectionTests.fs for Init event test" (T008)
Task: "Read EventTests.fs for Init event test" (T009)

# Then edit both in parallel:
Task: "Update Init test in ConnectionTests.fs" (T010)
Task: "Update Init test in EventTests.fs" (T011)
```

---

## Implementation Strategy

### MVP First (User Story 1 Only)

1. Complete Phase 1: Validate game content
2. Complete Phase 2: Update game-setup.txt modoptions
3. **STOP and VALIDATE**: Run test suite — 21/23 should pass
4. This alone fixes 10 of 12 failures

### Incremental Delivery

1. Phase 1 → Validate prerequisites
2. Phase 2 (US1) → Config fix → 10 tests fixed → Validate
3. Phase 3 (US2) → Init event fix → 2 more tests fixed → Validate (23/23)
4. Phase 4 (US3) → Write report → Complete

---

## Notes

- T003-T006 are logically one change (update game-setup.txt) but listed separately for traceability to specific modoption requirements
- No proxy source code changes in any task
- No Python harness changes (out of scope per clarification)
- Commit after each phase checkpoint
