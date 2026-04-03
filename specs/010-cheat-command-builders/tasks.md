# Tasks: F# Cheat Command Builders

**Input**: Design documents from `/specs/010-cheat-command-builders/`
**Prerequisites**: plan.md (required), spec.md (required for user stories), research.md, data-model.md

**Tests**: Unit tests are included per SC-004 (spec requires 100% test coverage of new builders).

**Organization**: Tasks are grouped by user story to enable independent implementation and testing of each story.

## Format: `[ID] [P?] [Story] Description`

- **[P]**: Can run in parallel (different files, no dependencies)
- **[Story]**: Which user story this task belongs to (e.g., US1, US2, US3)
- Include exact file paths in descriptions

## Phase 1: Setup

**Purpose**: Create the unit test project so builders can be tested without the engine.

- [x] T001 Create unit test project in tests/unit/fsharp/HighBar.Unit.Tests.fsproj with xUnit 2.9.3 and reference to HighBar.Client

---

## Phase 2: User Story 1 - Spawn Units (Priority: P1) 🎯 MVP

**Goal**: Test authors can spawn units at known positions using a cheat command builder.

**Independent Test**: Call `GiveMeNewUnitCommand` with a unit def ID and position, assert AICommand.GiveMeNewUnit is populated with correct fields.

### Implementation

- [x] T002 [US1] Add `GiveMeNewUnitCommand` builder function in clients/fsharp/src/Commands.fs

### Tests

- [x] T003 [US1] Add unit test verifying GiveMeNewUnitCommand sets unit_def_id and position fields in tests/unit/fsharp/CommandBuilderTests.fs

**Checkpoint**: User Story 1 complete — spawn-unit builder works and is tested.

---

## Phase 3: User Story 2 - Grant Resources (Priority: P1)

**Goal**: Test authors can inject metal/energy using a cheat command builder.

**Independent Test**: Call `GiveMeResourceCommand` with a resource ID and amount, assert AICommand.GiveMe is populated with correct fields.

### Implementation

- [x] T004 [P] [US2] Add `GiveMeResourceCommand` builder function in clients/fsharp/src/Commands.fs

### Tests

- [x] T005 [US2] Add unit test verifying GiveMeResourceCommand sets resource_id and amount fields in tests/unit/fsharp/CommandBuilderTests.fs

**Checkpoint**: User Story 2 complete — resource cheat builder works and is tested.

---

## Phase 4: User Story 3 - Send Lua Rules Messages (Priority: P2)

**Goal**: Test authors can send string payloads to LuaRules gadgets.

**Independent Test**: Call `CallLuaRulesCommand` with a string payload, assert AICommand.CallLuaRules.Data equals the input.

### Implementation

- [x] T006 [P] [US3] Add `CallLuaRulesCommand` builder function in clients/fsharp/src/Commands.fs

### Tests

- [x] T007 [US3] Add unit test verifying CallLuaRulesCommand sets data field in tests/unit/fsharp/CommandBuilderTests.fs

**Checkpoint**: User Story 3 complete — Lua rules bridge builder works and is tested.

---

## Phase 5: User Story 4 - Send Lua UI Messages (Priority: P3)

**Goal**: Test authors can send string payloads to LuaUI widgets.

**Independent Test**: Call `CallLuaUICommand` with a string payload, assert AICommand.CallLuaUi.Data equals the input.

### Implementation

- [x] T008 [P] [US4] Add `CallLuaUICommand` builder function in clients/fsharp/src/Commands.fs

### Tests

- [x] T009 [US4] Add unit test verifying CallLuaUICommand sets data field in tests/unit/fsharp/CommandBuilderTests.fs

**Checkpoint**: User Story 4 complete — Lua UI bridge builder works and is tested.

---

## Phase 6: Polish & Cross-Cutting Concerns

- [x] T010 Verify all 4 builders compile and all unit tests pass via `dotnet test` in tests/unit/fsharp/
- [x] T011 Verify builders can be mixed with existing commands (MoveCommand, BuildCommand, etc.) in a command list in tests/unit/fsharp/CommandBuilderTests.fs

---

## Dependencies & Execution Order

### Phase Dependencies

- **Setup (Phase 1)**: No dependencies — can start immediately
- **User Stories (Phase 2-5)**: All depend on T001 (test project setup)
- **Polish (Phase 6)**: Depends on all user stories being complete

### User Story Dependencies

- **User Story 1 (P1)**: Depends on T001 only
- **User Story 2 (P1)**: Depends on T001 only — can run in parallel with US1
- **User Story 3 (P2)**: Depends on T001 only — can run in parallel with US1/US2
- **User Story 4 (P3)**: Depends on T001 only — can run in parallel with US1/US2/US3

### Parallel Opportunities

- T002, T004, T006, T008 all modify the same file (Commands.fs) but append independent functions — can be done sequentially in one pass
- T003, T005, T007, T009 all modify the same test file — can be done sequentially in one pass
- Implementation tasks and test tasks within different stories marked [P] can be parallelized if separate files are used

---

## Parallel Example: All User Stories

```bash
# Since all 4 builders are independent functions in the same file,
# the most efficient approach is to implement all 4 in a single pass:
# T002 + T004 + T006 + T008 → all in clients/fsharp/src/Commands.fs
# T003 + T005 + T007 + T009 → all in tests/unit/fsharp/CommandBuilderTests.fs
```

---

## Implementation Strategy

### MVP First (User Story 1 Only)

1. Complete T001: Create unit test project
2. Complete T002: Add GiveMeNewUnitCommand builder
3. Complete T003: Test it
4. **STOP and VALIDATE**: `dotnet test` passes

### Incremental Delivery

1. T001 → Test project ready
2. T002-T003 → Spawn units (MVP!)
3. T004-T005 → Grant resources
4. T006-T007 → Lua rules bridge
5. T008-T009 → Lua UI bridge
6. T010-T011 → Final validation

---

## Notes

- All 4 builders follow the identical pattern from existing Commands.fs
- All builders append to the same file — no merge conflicts if done sequentially
- Unit tests verify protobuf field population only; no engine required
- Commit after each user story checkpoint
