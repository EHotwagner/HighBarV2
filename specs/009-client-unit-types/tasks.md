# Tasks: Integrate BAR Unit Types into F# Client

**Input**: Design documents from `/specs/009-client-unit-types/`
**Prerequisites**: plan.md (required), spec.md (required for user stories), research.md, data-model.md, quickstart.md

**Tests**: Integration tests are explicitly requested in the feature spec (FR-006, US3).

**Organization**: Tasks are grouped by user story to enable independent implementation and testing of each story.

## Format: `[ID] [P?] [Story] Description`

- **[P]**: Can run in parallel (different files, no dependencies)
- **[Story]**: Which user story this task belongs to (e.g., US1, US2, US3)
- Include exact file paths in descriptions

---

## Phase 1: Setup

**Purpose**: Add BarData project reference to client and test projects

- [X] T001 Add ProjectReference to BarData.fsproj in clients/fsharp/HighBar.Client.fsproj
- [X] T002 [P] Add ProjectReference to BarData.fsproj in tests/integration/fsharp/HighBar.Tests.fsproj
- [X] T003 Verify both projects build successfully with `dotnet build` from clients/fsharp/ and tests/integration/fsharp/

---

## Phase 2: Foundational

**Purpose**: Create the Units convenience module that all user stories depend on

- [X] T004 Create Units module with tryFind, findDef lookup functions and capability filter lists (builders, armedUnits, mobileUnits, flyingUnits, economyUnits, buildings, all) in clients/fsharp/src/Units.fs
- [X] T005 Add Units.fs to the Compile item list in clients/fsharp/HighBar.Client.fsproj (before Client.fs so it is available to downstream modules)
- [X] T006 Verify client builds and Units module is accessible with `dotnet build` from clients/fsharp/

**Checkpoint**: Foundation ready - Units module compiles and exposes BarData through client namespace

---

## Phase 3: User Story 1 - Access Unit Data from Client Code (Priority: P1) MVP

**Goal**: AI bot developers can look up any BAR unit definition by name through the client's Units module

**Independent Test**: Query a known unit (e.g., "armham") through Units.tryFind and Units.findDef, verify fields match expected values

### Tests for User Story 1

- [X] T007 [US1] Create UnitDataTests.fs test file with test module structure in tests/integration/fsharp/UnitDataTests.fs
- [X] T008 [US1] Add UnitDataTests.fs to the Compile item list in tests/integration/fsharp/HighBar.Tests.fsproj
- [X] T009 [P] [US1] Write test: tryFind returns Some for known unit "armham" with correct metalCost and health values in tests/integration/fsharp/UnitDataTests.fs
- [X] T010 [P] [US1] Write test: tryFind returns None for nonexistent unit "doesnotexist" in tests/integration/fsharp/UnitDataTests.fs
- [X] T011 [P] [US1] Write test: findDef returns Some for known unit "armham" with correct UnitDef fields in tests/integration/fsharp/UnitDataTests.fs
- [X] T011b [P] [US1] Write test: flat per-unit type ArmBots.armham is accessible and has matching name field in tests/integration/fsharp/UnitDataTests.fs
- [X] T012 [US1] Run tests with `dotnet test` from tests/integration/fsharp/ and verify all pass

**Checkpoint**: Unit data lookup works end-to-end through client module

---

## Phase 4: User Story 2 - Query Units by Capability (Priority: P2)

**Goal**: AI bot developers can filter units by capability flags (builder, armed, mobile, flying, economy, building)

**Independent Test**: Query builders list and verify known builder units are present; query armed+mobile and verify combat units appear

### Tests for User Story 2

- [X] T013 [P] [US2] Write test: Units.builders contains known builder "armck" in tests/integration/fsharp/UnitDataTests.fs
- [X] T014 [P] [US2] Write test: Units.armedUnits contains known combat unit "armham" in tests/integration/fsharp/UnitDataTests.fs
- [X] T015 [P] [US2] Write test: Units.mobileUnits does not contain known building "armsolar" in tests/integration/fsharp/UnitDataTests.fs
- [X] T016 [P] [US2] Write test: combined filter for armed+mobile units from Arm faction returns expected subset in tests/integration/fsharp/UnitDataTests.fs
- [X] T016b [P] [US2] Write test: Units.flyingUnits contains known air unit "armatlas" in tests/integration/fsharp/UnitDataTests.fs
- [X] T016c [P] [US2] Write test: Units.economyUnits contains known economy building "armsolar" in tests/integration/fsharp/UnitDataTests.fs
- [X] T017 [US2] Run tests with `dotnet test` from tests/integration/fsharp/ and verify all pass

**Checkpoint**: Capability queries work correctly across factions

---

## Phase 5: User Story 3 - Validate Integration (Priority: P3)

**Goal**: All existing client tests still pass and new tests cover representative units across factions

### Tests for User Story 3

- [X] T018 [P] [US3] Write test: Units.all contains exactly 953 entries in tests/integration/fsharp/UnitDataTests.fs
- [X] T019 [P] [US3] Write test: spot-check a Cor faction unit (e.g., "corcom") has expected values in tests/integration/fsharp/UnitDataTests.fs
- [X] T020 [P] [US3] Write test: spot-check a Legion faction unit has expected values in tests/integration/fsharp/UnitDataTests.fs
- [X] T021 [US3] Run full test suite with `dotnet test` from tests/integration/fsharp/ and verify all existing tests still pass alongside new tests

**Checkpoint**: Full integration validated -- all tests pass, no regressions

---

## Phase 6: Polish & Cross-Cutting Concerns

- [X] T022 Run quickstart.md validation: build and execute usage examples from specs/009-client-unit-types/quickstart.md
- [X] T023 Verify `dotnet build` succeeds for all dependent projects (clients/fsharp/, data/bar/, tests/integration/fsharp/, data/bar.tests/)

---

## Dependencies & Execution Order

### Phase Dependencies

- **Setup (Phase 1)**: No dependencies - can start immediately
- **Foundational (Phase 2)**: Depends on Phase 1 (T001-T003)
- **User Stories (Phase 3+)**: All depend on Phase 2 (T004-T006)
  - US1, US2, US3 can proceed sequentially in priority order
  - US2 depends on US1 (test file created in T007-T008)
  - US3 depends on US1 and US2 (validates full suite)
- **Polish (Phase 6)**: Depends on all user stories complete

### User Story Dependencies

- **User Story 1 (P1)**: Can start after Foundational (Phase 2) - creates test file structure
- **User Story 2 (P2)**: Can start after US1 test file exists (T007-T008) - adds tests to same file
- **User Story 3 (P3)**: Can start after US2 - validates full integration

### Parallel Opportunities

- T001 and T002 can run in parallel (different .fsproj files)
- T009, T010, T011 can run in parallel (independent test functions in same file)
- T013, T014, T015, T016 can run in parallel (independent test functions)
- T018, T019, T020 can run in parallel (independent test functions)

---

## Parallel Example: User Story 1

```bash
# After T007-T008 (test file created), launch test-writing tasks in parallel:
Task: "Write test: tryFind returns Some for known unit armham"
Task: "Write test: tryFind returns None for nonexistent unit"
Task: "Write test: findDef returns Some for known unit armham"
```

---

## Implementation Strategy

### MVP First (User Story 1 Only)

1. Complete Phase 1: Setup (T001-T003)
2. Complete Phase 2: Foundational (T004-T006)
3. Complete Phase 3: User Story 1 (T007-T012)
4. **STOP and VALIDATE**: Test unit data lookup independently
5. Proceed to US2 and US3

### Incremental Delivery

1. Setup + Foundational → Project references and Units module ready
2. Add User Story 1 → Unit lookups work → MVP!
3. Add User Story 2 → Capability queries work
4. Add User Story 3 → Full validation across factions
5. Polish → Quickstart validated, all builds green

---

## Notes

- [P] tasks = different files or independent test functions, no dependencies
- [Story] label maps task to specific user story for traceability
- All tests go in a single UnitDataTests.fs file (organized by test module sections)
- The Units.fs module delegates to existing BarData.AllUnits and BarData.AllUnitDefs -- no data duplication
- Commit after each phase checkpoint
