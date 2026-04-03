# Tasks: Unified BAR Data Generators with Cross-Conversion

**Input**: Design documents from `/specs/008-unified-bar-generators/`
**Prerequisites**: plan.md, spec.md, research.md, data-model.md, quickstart.md

**Tests**: Included — success criteria SC-002, SC-003, SC-004 require verification tests.

**Organization**: Tasks are grouped by user story to enable independent implementation and testing of each story.

## Format: `[ID] [P?] [Story] Description`

- **[P]**: Can run in parallel (different files, no dependencies)
- **[Story]**: Which user story this task belongs to (e.g., US1, US2, US3)
- Include exact file paths in descriptions

---

## Phase 1: Setup (Prepare Unified Project Types)

**Purpose**: Merge v1 composable types into the existing bar project and verify compilation. Bar-v1 directories are kept until Phase 2 test merge completes.

- [X] T001 Move composable types (UnitDef, MovementDef, BuilderDef, EconomyDef, BuildingDef) from data/bar-v1/src/Types.fs into a new data/bar/src/ComposableTypes.fs under namespace BarData — keep shared types (ValueOrExpr, SoundDef, FeatureDef, WeaponDef) in data/bar/src/Types.fs
- [X] T002 Add data/bar/src/ComposableTypes.fs to data/bar/BarData.fsproj Compile items (after Types.fs, before Commands.fs)
- [X] T003 Verify data/bar/BarData.fsproj compiles with shared types + composable types via `dotnet build data/bar/BarData.fsproj`

**Checkpoint**: Unified project has both shared types and composable types. Compiles successfully.

---

## Phase 2: User Story 1 - Unified Generator (Priority: P1) 🎯 MVP

**Goal**: A single generator script produces both composable UnitDef instances and flat per-unit types in one pass

**Independent Test**: `dotnet fsi tools/generate-bar-data.fsx --skip-clone` produces all generated files in data/bar/src/; `dotnet build data/bar/BarData.fsproj` passes; `dotnet test data/bar.tests/BarData.Tests.fsproj` passes

### Implementation for User Story 1

- [X] T004 [US1] Refactor tools/generate-bar-data.fsx: restructure CodeGen module to contain two sub-sections — `Composable` (existing v1 emitters for UnitDef instances) and `Flat` (flat per-unit type + instance emitters from generate-bar-data-flat.fsx)
- [X] T005 [US1] In tools/generate-bar-data.fsx, add the 11 universal optional fields (objectName, buildPic, script, corpse, explodeAs, selfDestructAs, collisionVolumeOffsets, collisionVolumeScales, collisionVolumeType, seismicSignature, category) to the flat type buildFieldDefs function and the flat instance emitter
- [X] T006 [US1] In tools/generate-bar-data.fsx, update the UnitSummary emitter and AllUnits.fs generation (copy from generate-bar-data-flat.fsx)
- [X] T007 [US1] In tools/generate-bar-data.fsx, implement AllUnitDefs.fs generation: emit `all: (string * string * UnitDef) list` and `tryFind: string -> UnitDef option` referencing composable UnitDef instances from each module
- [X] T008 [US1] In tools/generate-bar-data.fsx, update the per-module emitter to produce both: (a) flat per-unit type + singleton, (b) composable UnitDef singleton (e.g., `let armckDef : UnitDef = { ... }`) — reusing existing v1 emitUnitDef logic
- [X] T009 [US1] In tools/generate-bar-data.fsx, update the .fsproj updater to include ComposableTypes.fs and AllUnitDefs.fs in correct compile order (Types.fs → ComposableTypes.fs → Commands.fs → CustomCommands.fs → UnitSummary.fs → sorted unit modules → AllUnits.fs → AllUnitDefs.fs)
- [X] T010 [US1] Run the unified generator: `dotnet fsi tools/generate-bar-data.fsx --skip-clone` and verify it produces all module files with both flat types and UnitDef instances
- [X] T011 [US1] Verify compilation: `dotnet build data/bar/BarData.fsproj` passes with zero errors
- [X] T012 [US1] Update existing flat tests in data/bar.tests/ to work with the unified library (adjust any imports or references that changed)
- [X] T013 [US1] Merge data/bar-v1.tests/ test files into data/bar.tests/Tests/ — adapt v1 tests to use BarData namespace (not BarData.V1), rename to avoid conflicts (e.g., v1 CorrectnessTests → ComposableCorrectnessTests.fs, v1 CapabilityTests → ComposableCapabilityTests.fs). Update data/bar.tests/BarData.Tests.fsproj to include the merged test files.
- [X] T014 [US1] Run all tests: `dotnet test data/bar.tests/BarData.Tests.fsproj` — all pass (both flat and composable tests)
- [X] T015 [US1] Delete data/bar-v1/ and data/bar-v1.tests/ directories
- [X] T016 [US1] Delete tools/generate-bar-data-flat.fsx (the flat-only generator)

**Checkpoint**: Single generator produces unified library with both representations. All tests pass. Old v1 directories and flat script removed.

---

## Phase 3: User Story 2 - UnitDef to Flat Conversion (Priority: P2)

**Goal**: Generated `toFlat` conversion functions transform any UnitDef into the corresponding flat per-unit record

**Independent Test**: Calling `ArmBots.armckToFlat ArmBots.armckDef` returns a record matching `ArmBots.armck`

### Implementation for User Story 2

- [X] T017 [US2] In tools/generate-bar-data.fsx, implement toFlat emitter: for each unit, generate a function `let {name}ToFlat (def: UnitDef) : {TypeName} = { ... }` that extracts fields from UnitDef and its sub-records (movement.Value.speed → speed, builder.Value.workerTime → workerTime, etc.) — only for fields present on that unit's flat type
- [X] T018 [US2] Re-run generator: `dotnet fsi tools/generate-bar-data.fsx --skip-clone`
- [X] T019 [US2] Verify compilation: `dotnet build data/bar/BarData.fsproj` passes
- [X] T020 [US2] Create data/bar.tests/Tests/ConversionTests.fs with toFlat tests: spot-check armck, armham, armsolar, armcom, corck, legbal — verify toFlat(unitDef) produces matching field values against the flat singleton
- [X] T021 [US2] Add ConversionTests.fs to data/bar.tests/BarData.Tests.fsproj
- [X] T022 [US2] Run tests: `dotnet test data/bar.tests/BarData.Tests.fsproj` — all pass

**Checkpoint**: toFlat conversion works for all units. Tests verify field-level equivalence.

---

## Phase 4: User Story 3 - Flat to UnitDef Conversion (Priority: P2)

**Goal**: Generated `toUnitDef` conversion functions transform any flat per-unit instance into a composable UnitDef

**Independent Test**: Calling `ArmBots.armhamToUnitDef ArmBots.armham` returns a UnitDef with `movement = Some { speed = Concrete 46.2; ... }`

### Implementation for User Story 3

- [X] T023 [US3] In tools/generate-bar-data.fsx, implement toUnitDef emitter: for each unit, generate a function `let {name}ToUnitDef (flat: {TypeName}) : UnitDef = { ... }` that wraps flat fields into optional sub-records (speed → movement = Some { speed = ...; ... }, workerTime → builder = Some { ... }, etc.)
- [X] T024 [US3] Re-run generator: `dotnet fsi tools/generate-bar-data.fsx --skip-clone`
- [X] T025 [US3] Verify compilation: `dotnet build data/bar/BarData.fsproj` passes
- [X] T026 [US3] Add toUnitDef tests to data/bar.tests/Tests/ConversionTests.fs: spot-check armham (movement + weapons), armck (movement + builder), armsolar (building + economy, no movement), armcom (movement + builder + weapons)
- [X] T027 [US3] Add round-trip tests to data/bar.tests/Tests/ConversionTests.fs: for at least 20 units across all factions, verify toFlat(toUnitDef(flat)) == flat and toUnitDef(toFlat(def)) has equivalent field values to def
- [X] T028 [US3] Run tests: `dotnet test data/bar.tests/BarData.Tests.fsproj` — all pass

**Checkpoint**: Both conversion directions work. Round-trip tests verify lossless conversion for 20+ units.

---

## Phase 5: Polish & Cross-Cutting Concerns

**Purpose**: Final validation and cleanup

- [X] T029 [P] Verify all 953 units convert without errors: add test in data/bar.tests/Tests/ConversionTests.fs that iterates AllUnitDefs.all, calls each unit's toFlat via a generated registry of (name * (UnitDef -> obj)) pairs, and also verifies toUnitDef round-trips for each entry
- [X] T030 [P] Verify the 11 new universal optional fields are populated: add test checking objectName, buildPic, script, corpse are Some for a known unit (e.g., armck) in the flat representation
- [X] T031 Run quickstart.md validation: verify code examples from specs/008-unified-bar-generators/quickstart.md patterns work correctly
- [X] T032 Clean up: remove any remaining references to BarData.V1 namespace, bar-v1 paths, or generate-bar-data-flat.fsx from CLAUDE.md and other project files

---

## Dependencies & Execution Order

### Phase Dependencies

- **Setup (Phase 1)**: No dependencies — can start immediately
- **US1 (Phase 2)**: Depends on Phase 1 — composable types must be in unified project
- **US2 (Phase 3)**: Depends on Phase 2 (unified generator must produce both representations)
- **US3 (Phase 4)**: Depends on Phase 2 (same reason); can run in parallel with US2
- **Polish (Phase 5)**: Depends on Phase 3 and Phase 4

### User Story Dependencies

- **User Story 1 (P1 - Unified Generator)**: Depends on Setup completion
- **User Story 2 (P2 - toFlat)**: Depends on US1 (needs both representations generated)
- **User Story 3 (P2 - toUnitDef)**: Depends on US1; can run in parallel with US2

### Within Each User Story

- Generator implementation before running generator
- Running generator before compilation check
- Compilation before tests

### Parallel Opportunities

- T017 (toFlat emitter) and T023 (toUnitDef emitter) can be developed in parallel (different emission functions)
- T029 and T030 can run in parallel (different test concerns)
- US2 and US3 can proceed in parallel after US1 completes

---

## Implementation Strategy

### MVP First (User Story 1)

1. Complete Phase 1: Setup (merge v1 into unified project)
2. Complete Phase 2: User Story 1 (unified generator)
3. **STOP and VALIDATE**: Both representations compile, all existing tests pass
4. Deliver MVP

### Incremental Delivery

1. Setup → v1 types in unified project, bar-v1 eliminated
2. Add User Story 1 → Single generator, both representations → MVP!
3. Add User Story 2 → UnitDef→flat conversion
4. Add User Story 3 → flat→UnitDef conversion + round-trip tests
5. Polish → All 953 units validated, quickstart verified

---

## Notes

- [P] tasks = different files, no dependencies
- [Story] label maps task to specific user story for traceability
- The generator script (tools/generate-bar-data.fsx) is the central artifact — most US1/US2/US3 tasks modify it
- Generator modification tasks are sequential within the same file
- Test tasks can be parallelized since they're separate files
- Commit after each phase checkpoint
