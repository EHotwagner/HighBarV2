# Tasks: Flat Per-Unit BAR Type Definitions

**Input**: Design documents from `/specs/007-flat-bar-types/`
**Prerequisites**: plan.md, spec.md, research.md, data-model.md, quickstart.md

**Tests**: Included — success criteria SC-003, SC-005, SC-006 require verification tests.

**Organization**: Tasks are grouped by user story to enable independent implementation and testing of each story.

## Format: `[ID] [P?] [Story] Description`

- **[P]**: Can run in parallel (different files, no dependencies)
- **[Story]**: Which user story this task belongs to (e.g., US1, US2, US3)
- Include exact file paths in descriptions

---

## Phase 1: User Story 2 - Archive Previous Representation (Priority: P1)

**Goal**: Rename existing data/bar to data/bar-v1 so both representations coexist without conflicts

**Independent Test**: `dotnet build data/bar-v1/BarData.fsproj` and `dotnet test data/bar-v1.tests/BarData.Tests.fsproj` both pass

- [X] T001 [US2] Rename data/bar/ directory to data/bar-v1/ and data/bar.tests/ to data/bar-v1.tests/
- [X] T002 [US2] Update data/bar-v1/BarData.fsproj: change RootNamespace to BarData.V1 and AssemblyName to BarData.V1
- [X] T003 [US2] Update all .fs files in data/bar-v1/src/ to use namespace BarData.V1 and BarData.V1.Units (replace `namespace BarData` with `namespace BarData.V1` and `open BarData` with `open BarData.V1`)
- [X] T004 [US2] Update data/bar-v1.tests/BarData.Tests.fsproj: change ProjectReference to ../bar-v1/BarData.fsproj
- [X] T005 [US2] Update all test .fs files in data/bar-v1.tests/Tests/ to use `open BarData.V1` and `open BarData.V1.Units`
- [X] T006 [US2] Verify archived projects compile: run `dotnet build data/bar-v1/BarData.fsproj` and `dotnet test data/bar-v1.tests/BarData.Tests.fsproj`

**Checkpoint**: Archived v1 library compiles and tests pass independently. data/bar path is free for new project.

---

## Phase 2: Setup (Shared Infrastructure)

**Purpose**: Create the new generator script with Lua parsing and shared type definitions

**⚠️ CRITICAL**: Phase 1 (Archive) MUST complete before this phase — data/bar/ path must be free

- [X] T007 Create tools/generate-bar-data-flat.fsx by copying Lua parsing phases (XParsec parser, LVal AST, expression fallback, file discovery) from tools/generate-bar-data.fsx — remove all v1 code emission functions
- [X] T008 Create data/bar/BarData.fsproj targeting net8.0 with RootNamespace BarData, matching compiler flags from data/bar-v1/BarData.fsproj (--strict-indentation-)
- [X] T009 [P] Create data/bar/src/Types.fs with shared sub-types: ValueOrExpr<'T>, SoundDef, FeatureDef, WeaponDef — copy from data/bar-v1/src/Types.fs but remove UnitDef, MovementDef, BuilderDef, EconomyDef, and BuildingDef records (movement/builder/economy/building fields are flattened into per-unit types)
- [X] T010 [P] Copy data/bar-v1/src/Commands.fs to data/bar/src/Commands.fs
- [X] T011 Verify data/bar/BarData.fsproj compiles with Types.fs and Commands.fs only via `dotnet build data/bar/BarData.fsproj`

**Checkpoint**: Generator script has working Lua parser, new project skeleton compiles with shared types

---

## Phase 3: User Story 1 - Access Unit Data Through Dedicated Per-Unit Types (Priority: P1) 🎯 MVP

**Goal**: Generate a unique F# record type per BAR unit with only the fields that unit actually has — no option wrapping for present capabilities

**Independent Test**: `dotnet build data/bar/BarData.fsproj` compiles with zero errors/warnings; spot-check field values on armck, armham, armsolar match Lua source

### Implementation for User Story 1

- [X] T012 [US1] In tools/generate-bar-data-flat.fsx, implement field analysis function that inspects a parsed LVal table and returns the list of fields present (universal fields always included; conditional fields flattened from Lua sub-tables: movement fields like speed/maxAcc/turnRate when canmove/canfly, builder fields like workerTime/buildOptions when builder=true, economy fields like energyMake/metalMake when present, building fields like yardMap when present, plus weapons as WeaponDef list, featureDefs, sounds, customParams, extras)
- [X] T013 [US1] In tools/generate-bar-data-flat.fsx, implement per-unit type emitter: given a unit name and its analyzed field list, emit an F# record type definition (PascalCase name, e.g., `type Armck = { ... }`) with all detected fields as direct non-optional members — movement/builder/economy/building fields are flattened (e.g., `speed: ValueOrExpr<float>` not `movement: MovementDef option`)
- [X] T014 [US1] In tools/generate-bar-data-flat.fsx, implement per-unit instance emitter: given a unit name, its type, and parsed LVal data, emit a singleton `let armck : Armck = { ... }` with concrete values populated from the Lua data (reuse value emission helpers from v1: emitValueOrExprFloat, emitSoundDef, emitFeatureDef, emitWeaponDef; flatten movement/builder/economy/building sub-table values into top-level fields)
- [X] T015 [US1] In tools/generate-bar-data-flat.fsx, implement module emitter: group units by subfolder, emit one F# module per subfolder (e.g., `module ArmBots`) containing all per-unit types and singletons for that subfolder
- [X] T016 [US1] In tools/generate-bar-data-flat.fsx, implement CustomCommands.fs generation (copy logic from v1 generator for parsing modules/customcommands.lua)
- [X] T017 [US1] In tools/generate-bar-data-flat.fsx, implement .fsproj updater: generate Compile items in correct order (Types.fs → Commands.fs → CustomCommands.fs → UnitSummary.fs → sorted unit modules → AllUnits.fs). UnitSummary.fs and AllUnits.fs are placeholders until Phase 4 populates them.
- [X] T018 [US1] Run the generator: `dotnet fsi tools/generate-bar-data-flat.fsx` and verify it produces all module files in data/bar/src/
- [X] T019 [US1] Verify compilation: `dotnet build data/bar/BarData.fsproj` passes with zero errors and zero warnings
- [X] T020 [US1] Create data/bar.tests/BarData.Tests.fsproj with ProjectReference to ../bar/BarData.fsproj and xUnit dependencies (match structure from data/bar-v1.tests/BarData.Tests.fsproj)
- [X] T021 [US1] Create data/bar.tests/Tests/CorrectnessTests.fs: spot-check at least 20 field values — armham.health=1000, armham.speed=46.2, armck.workerTime=80, armck.buildDistance=130, armflea.speed=132, armsolar.energyMake=20 (verify fields are direct, not option-wrapped)
- [X] T022 [US1] Create data/bar.tests/Tests/StructuralTests.fs: verify no unit has 0 health (allow ~20 edge cases), no negative metalCost, builders have non-empty buildOptions, armed units have non-empty damage maps, all names non-empty and unique
- [X] T023 [US1] Run tests: `dotnet test data/bar.tests/BarData.Tests.fsproj` — all pass

**Checkpoint**: 953 per-unit types generated, library compiles, spot-check tests pass. Each unit's fields are directly accessible without option checks.

---

## Phase 4: User Story 3 - Query Units by Capability (Priority: P2)

**Goal**: Provide a shared UnitSummary record and capability query functions for filtering all units

**Independent Test**: `AllUnits.builders()` returns list including armck/armcom; `AllUnits.flying()` returns only flying units; `AllUnits.tryFind "armham"` returns correct summary

### Implementation for User Story 3

- [X] T024 [US3] Create data/bar/src/UnitSummary.fs with UnitSummary record: name (string), subfolder (string), metalCost (ValueOrExpr<float>), energyCost (ValueOrExpr<float>), health (ValueOrExpr<float>), isBuilder (bool), isArmed (bool), isMobile (bool), canFly (bool), hasEconomy (bool), isBuilding (bool)
- [X] T025 [US3] In tools/generate-bar-data-flat.fsx, implement UnitSummary emitter: for each parsed unit, derive capability flags from Lua data (isBuilder = builder=true AND buildoptions present; isArmed = weapondefs present; isMobile = canmove=true; canFly = canfly=true; hasEconomy = energymake>0 OR metalmake>0; isBuilding = yardmap present)
- [X] T026 [US3] In tools/generate-bar-data-flat.fsx, implement AllUnits.fs generation: emit `all: UnitSummary list`, `tryFind: string -> UnitSummary option`, and capability query functions `builders()`, `armed()`, `mobile()`, `flying()`, `economy()`, `buildings()` — each filters the `all` list
- [X] T027 [US3] Re-run generator: `dotnet fsi tools/generate-bar-data-flat.fsx` and verify AllUnits.fs is generated with UnitSummary entries and query functions
- [X] T028 [US3] Verify compilation: `dotnet build data/bar/BarData.fsproj` passes
- [X] T029 [US3] Create data/bar.tests/Tests/CompletenessTests.fs: verify >= 950 units in AllUnits.all, faction counts (Arm >= 200, Cor >= 200, Legion >= 220, Scav >= 80), tryFind works for known units and returns None for unknown
- [X] T030 [US3] Create data/bar.tests/Tests/CapabilityTests.fs: verify builders() includes armck/armcom/armlab, armed() includes armham, flying() includes armfig/armbrawl, mobile() includes armck (not armsolar), economy() includes armsolar, buildings() includes armsolar/armlab
- [X] T031 [US3] Run all tests: `dotnet test data/bar.tests/BarData.Tests.fsproj` — all pass including completeness and capability tests

**Checkpoint**: UnitSummary queries work for all 6 capability types. Full library compiles and all tests pass.

---

## Phase 5: Polish & Cross-Cutting Concerns

**Purpose**: Final validation and cleanup

- [X] T032 [P] Verify zero data loss: add test in data/bar.tests/Tests/StructuralTests.fs confirming at least one unit has non-empty extras map (validates unmapped fields are captured)
- [X] T033 [P] Verify expression preservation: add test in data/bar.tests/Tests/StructuralTests.fs confirming Expr values contain original Lua expression text (check a known expression unit like armassistdrone_land)
- [X] T034 Run full validation: `dotnet build data/bar-v1/BarData.fsproj && dotnet test data/bar-v1.tests/BarData.Tests.fsproj && dotnet build data/bar/BarData.fsproj && dotnet test data/bar.tests/BarData.Tests.fsproj` — all pass
- [X] T035 Run quickstart.md validation: verify code examples from specs/007-flat-bar-types/quickstart.md compile and produce expected output

---

## Dependencies & Execution Order

### Phase Dependencies

- **Archive / US2 (Phase 1)**: No dependencies — can start immediately
- **Setup (Phase 2)**: Depends on Phase 1 — data/bar/ path must be free before creating new project there
- **US1 (Phase 3)**: Depends on Phase 2 (generator + project skeleton)
- **US3 (Phase 4)**: Depends on Phase 3 (per-unit types must exist before summaries reference them)
- **Polish (Phase 5)**: Depends on Phase 3 and Phase 4

### User Story Dependencies

- **User Story 2 (P1 - Archive)**: Independent — starts first (Phase 1)
- **User Story 1 (P1 - Flat Types)**: Depends on US2 completion and Setup
- **User Story 3 (P2 - Queries)**: Depends on US1 (needs per-unit types to exist)

### Within Each User Story

- Generator implementation before running generator
- Running generator before compilation check
- Compilation before tests
- Core implementation before integration

### Parallel Opportunities

- T009 and T010 can run in parallel (Types.fs and Commands.fs are independent files)
- T021 and T022 can run in parallel (different test files)
- T029 and T030 can run in parallel (different test files)
- T032 and T033 can run in parallel (different test additions)

---

## Parallel Example: User Story 1

```bash
# After generator runs (T018), create test files in parallel:
Task: "T021 [US1] Create CorrectnessTests.fs in data/bar.tests/Tests/"
Task: "T022 [US1] Create StructuralTests.fs in data/bar.tests/Tests/"
```

---

## Implementation Strategy

### MVP First (User Story 2 + User Story 1)

1. Complete Phase 1: Archive (rename data/bar → data/bar-v1)
2. Complete Phase 2: Setup (generator skeleton + project skeleton)
3. Complete Phase 3: User Story 1 (generate flat types, compile, test)
4. **STOP and VALIDATE**: 953 per-unit types compile, spot-checks pass
5. Deliver MVP

### Incremental Delivery

1. Archive → data/bar path freed
2. Setup → generator + project skeleton ready
3. Add User Story 1 → Per-unit type access works → MVP!
4. Add User Story 3 → Capability queries work → Full feature
5. Polish → Both v1 and v2 verified end-to-end

---

## Notes

- [P] tasks = different files, no dependencies
- [Story] label maps task to specific user story for traceability
- The generator script (tools/generate-bar-data-flat.fsx) is the central artifact — most US1 tasks modify it
- Generator tasks (T012-T017) are sequential within the same file
- Test tasks can be parallelized since they're separate files
- Commit after each phase checkpoint
