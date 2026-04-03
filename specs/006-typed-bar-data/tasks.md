# Tasks: Typed BAR Data Records

**Input**: Design documents from `/specs/006-typed-bar-data/`
**Prerequisites**: plan.md, spec.md, research.md, data-model.md, quickstart.md

**Tests**: Included — FR-009 explicitly requires a test suite for completeness and correctness.

**Organization**: Tasks are grouped by user story to enable independent implementation and testing of each story.

## Format: `[ID] [P?] [Story] Description`

- **[P]**: Can run in parallel (different files, no dependencies)
- **[Story]**: Which user story this task belongs to (e.g., US1, US2, US3)
- Include exact file paths in descriptions

---

## Phase 1: Setup

**Purpose**: Project initialization and test project scaffolding

- [x] T001 Create test project directory and initialize xUnit project at data/bar.tests/BarData.Tests.fsproj with references to data/bar/BarData.fsproj
- [x] T002 Verify bar-repo/ exists with unit Lua files; if missing, run `dotnet fsi tools/generate-bar-data.fsx` (clone only) or instruct user to clone

---

## Phase 2: Foundational (Type Definitions)

**Purpose**: Define the record types that ALL generated unit modules and tests depend on. MUST complete before any user story work.

**CRITICAL**: No user story work can begin until this phase is complete.

- [x] T003 Define `ValueOrExpr<'T>` DU (`Concrete of 'T | Expr of string`) in data/bar/src/Types.fs
- [x] T004 Define `SoundDef` record with typed fields (build, repair, working, underAttack, cancelDestruct, capture as `string option`; cant, count, ok, select as `string list`) in data/bar/src/Types.fs
- [x] T005 Define `FeatureDef` record (blocking, category, collisionVolume fields, damage, featureDead, footprint, height, metal, object_, reclaimable, resurrectable) in data/bar/src/Types.fs
- [x] T006 Define `MovementDef` record (speed as `ValueOrExpr<float>`, maxAcc, maxDec, turnRate, movementClass, maxSlope, maxWaterDepth, canFly, canMove, floater, turnInPlace fields, cruiseAltitude, minWaterDepth, waterline) in data/bar/src/Types.fs
- [x] T007 Define `BuilderDef` record (workerTime as `ValueOrExpr<float>`, buildDistance, buildOptions as `string list`, terraformSpeed) in data/bar/src/Types.fs
- [x] T008 Define `WeaponDef` record (~20 core fields: name, displayName, weaponType, damage as `Map<string, float>`, range, reloadTime, weaponVelocity, areaOfEffect, accuracy, turret, tolerance, edgeEffectiveness, impulseFactor, noSelfDamage, soundStart, soundHit, explosiongenerator, rgbColor, onlyTargetCategory, badTargetCategory, customParams, extras) in data/bar/src/Types.fs
- [x] T009 Define `EconomyDef` record (energyMake, metalMake as `ValueOrExpr<float> option`, energyStorage, metalStorage, extractsMetal) in data/bar/src/Types.fs
- [x] T010 Define `BuildingDef` record (yardMap, activateWhenBuilt, canRepeat) in data/bar/src/Types.fs
- [x] T011 Define `UnitDef` record with universal fields (name, subfolder, metalCost, energyCost, buildTime, health, sightDistance, footprintX/Z, objectName, buildPic, script, corpse, explodeAs, selfDestructAs, collisionVolume fields, seismicSignature, category) plus optional capability sub-records (movement, builder, weapons, economy, building, featureDefs, sounds, customParams, extras) in data/bar/src/Types.fs
- [x] T012 Update data/bar/BarData.fsproj to include src/Types.fs as the FIRST Compile item (before Commands.fs), remove src/LuaValue.fs entry
- [x] T013 Delete data/bar/src/LuaValue.fs
- [x] T014 Build data/bar/BarData.fsproj to verify type definitions compile (Commands.fs and CustomCommands.fs should still compile; unit modules will fail until regenerated — that's expected)

**Checkpoint**: Type definitions compile. Foundation ready for generator and test work.

---

## Phase 3: User Story 1 — Access Unit Stats via Typed Records (Priority: P1) + User Story 2 — Regenerate Data from BAR Repo (Priority: P1) MVP

**Goal**: Modify the generator to emit typed record instances and produce a compiling data library with all ~953 units as typed records.

**Independent Test**: `dotnet fsi tools/generate-bar-data.fsx --skip-clone && dotnet build data/bar/BarData.fsproj` succeeds. Unit fields accessible as native types.

**Note**: US1 and US2 are merged into one phase because the generator (US2) produces the data that US1 consumes — they cannot be tested independently.

### Implementation

- [x] T015 [US1] [US2] In tools/generate-bar-data.fsx, add `emitValueOrExpr` helper that checks if an `LVal` is `LExpr` and emits `Expr "..."` or `Concrete <value>` accordingly; used by all sub-record emitters for fields typed as `ValueOrExpr<float>`
- [x] T016 [P] [US1] [US2] In tools/generate-bar-data.fsx, add CodeGen function `emitSoundDef` that converts the parsed `LTbl` sounds table into an F# `SoundDef` record literal, mapping single sounds to `Some "value"` and indexed lists to `["val1"; "val2"]`
- [x] T017 [P] [US1] [US2] In tools/generate-bar-data.fsx, add CodeGen function `emitFeatureDef` that converts parsed feature def tables into F# `FeatureDef` record literals
- [x] T018 [P] [US1] [US2] In tools/generate-bar-data.fsx, add CodeGen function `emitWeaponDef` that converts parsed weapon def tables into F# `WeaponDef` record literals, emitting damage as `Map.ofList [...]`, core fields as typed values, remaining fields into `extras` map; merge `weapons` array per-slot overrides with `mount_` prefix
- [x] T019 [P] [US1] [US2] In tools/generate-bar-data.fsx, add CodeGen function `emitMovementDef` that extracts movement fields (speed, maxAcc, maxDec, turnRate, movementClass, etc.) from the parsed unit table and emits a `MovementDef` record literal; return `None` if unit is immobile (per capability detection rules in research.md R7)
- [x] T020 [P] [US1] [US2] In tools/generate-bar-data.fsx, add CodeGen function `emitBuilderDef` that extracts builder fields (workerTime, buildDistance, buildOptions, terraformSpeed) and emits a `BuilderDef` record literal; return `None` if `builder` not true or `buildoptions` missing (per research.md R7)
- [x] T021 [P] [US1] [US2] In tools/generate-bar-data.fsx, add CodeGen function `emitEconomyDef` that extracts economy fields (energyMake, metalMake, energyStorage, metalStorage, extractsMetal) and emits an `EconomyDef` record literal; return `None` if no economy fields present (per research.md R7)
- [x] T022 [P] [US1] [US2] In tools/generate-bar-data.fsx, add CodeGen function `emitBuildingDef` that extracts building fields (yardMap, activateWhenBuilt, canRepeat) and emits a `BuildingDef` record literal; return `None` if no `yardmap` field present (per research.md R7)
- [x] T023 [US1] [US2] In tools/generate-bar-data.fsx, replace `CodeGen.emitUnitsModule` — instead of emitting `LuaValue.Table [...]` per unit, emit a `UnitDef` record literal that: extracts universal fields, calls each capability emitter (movement, builder, weapons, economy, building, featureDefs, sounds), collects customParams into `Map.ofList [...]`, and puts remaining unrecognized fields into `extras` map
- [x] T024 [US1] [US2] In tools/generate-bar-data.fsx, update `CodeGen.emitIndex` (AllUnits module) to use `UnitDef` type in the `all` list signature and `tryFind` return type
- [x] T025 [US1] [US2] In tools/generate-bar-data.fsx, update the `.fsproj` generation to reference `src/Types.fs` as the first Compile item (replacing `src/LuaValue.fs`) and keep `src/Commands.fs`, `src/CustomCommands.fs` unchanged
- [x] T026 [US1] [US2] Run `dotnet fsi tools/generate-bar-data.fsx --skip-clone` and verify it completes without errors, printing unit counts
- [x] T027 [US1] [US2] Run `dotnet build data/bar/BarData.fsproj` and fix any compilation errors in the generated output until it compiles clean (zero errors, zero warnings)

**Checkpoint**: All ~953 units generated as typed records. Library compiles. Fields accessible as native .NET types.

---

## Phase 4: User Story 3 — Validate Data Completeness and Correctness (Priority: P2)

**Goal**: Create an xUnit test suite that validates generated data.

**Independent Test**: `dotnet test data/bar.tests/BarData.Tests.fsproj` passes with all tests green.

### Tests

- [x] T028 [P] [US3] Create CompletenessTests.fs in data/bar.tests/Tests/ — test that AllUnits.all contains at least 950 entries; test unit counts per faction/subfolder (Arm ~214, Cor ~222, Legion ~233, Scavengers ~83, other ~201); test that each subfolder module's `all` list is non-empty
- [x] T029 [P] [US3] Create CorrectnessTests.fs in data/bar.tests/Tests/ — spot-check at least 20 specific unit field values: armham metalCost=130, armham health=1000, armck workerTime=80, armck buildDistance=130, armflea speed=132, armflea health=60, armadvsol energyMake=80, plus similar checks for Cor/Legion/Scavenger units; verify values match known Lua source
- [x] T030 [P] [US3] Create CapabilityTests.fs in data/bar.tests/Tests/ — verify: armck (builder bot) has `Some builder` and `None` for weapons; armham (combat bot) has `Some weapons` and `None` for builder; armcom (commander) has `Some movement`, `Some builder`, AND `Some weapons`; armadvsol (solar) has `Some economy`, `Some building`, `None` movement; armaap (factory) has `Some building` and `Some builder`
- [x] T031 [P] [US3] Create StructuralTests.fs in data/bar.tests/Tests/ — verify: no unit in AllUnits.all has `Concrete 0.0` for health; no unit has negative metalCost; all units with `Some builder` have non-empty buildOptions; all units with `Some weapons` have at least one WeaponDef with non-empty damage map; units with `Expr` values preserve non-empty expression text (spot-check armassistdrone workerTime contains `Spring.GetModOptions`); at least one unit has non-empty `extras` map (validates SC-006 no-data-loss for unrecognized fields)
- [x] T032 [US3] Run `dotnet test data/bar.tests/BarData.Tests.fsproj` and fix any failing tests until all pass

**Checkpoint**: Test suite validates completeness, correctness, capability assignment, and structural integrity. All tests green.

---

## Phase 5: Polish & Cross-Cutting Concerns

**Purpose**: Final validation and documentation updates

- [x] T033 Run full regeneration from scratch: `dotnet fsi tools/generate-bar-data.fsx --skip-clone && dotnet build data/bar/BarData.fsproj && dotnet test data/bar.tests/BarData.Tests.fsproj` — all must pass
- [x] T034 Update docs/bar-data-reference.md to reflect the new typed record API: replace LuaValue usage examples with typed record field access, update the Data Format section, update Key Files table to show Types.fs instead of LuaValue.fs
- [x] T035 Verify quickstart.md examples from specs/006-typed-bar-data/quickstart.md compile and work correctly

---

## Dependencies & Execution Order

### Phase Dependencies

- **Setup (Phase 1)**: No dependencies — can start immediately
- **Foundational (Phase 2)**: Depends on Setup completion — BLOCKS all user stories
- **US1+US2 (Phase 3)**: Depends on Foundational (type definitions must exist before generator can emit them)
- **US3 (Phase 4)**: Depends on Phase 3 (test suite needs compiled data library)
- **Polish (Phase 5)**: Depends on Phases 3 and 4

### User Story Dependencies

- **US1 + US2 (P1)**: Merged — generator produces data that US1 consumes. Can start after Foundational.
- **US3 (P2)**: Depends on US1+US2 — tests validate the generated output.

### Within Each Phase

- Phase 2: T003-T011 can be done as a single file edit (Types.fs). T012-T013 after types written. T014 validates.
- Phase 3: T015 (emitValueOrExpr) first, then T016-T022 (sub-record emitters) in parallel [P] since they touch different functions. T023-T025 depend on all emitters. T026-T027 are sequential validation.
- Phase 4: T028-T031 can all be written in parallel [P] (different test files). T032 validates.

### Parallel Opportunities

```bash
# Phase 2 — all type definitions in one file, sequential but fast
T003 → T004 → T005 → T006 → T007 → T008 → T009 → T010 → T011

# Phase 3 — T015 (emitValueOrExpr) first, then sub-record emitters in parallel
T015 (emitValueOrExpr helper)
# Then in parallel:
Task: T016 emitSoundDef
Task: T017 emitFeatureDef
Task: T018 emitWeaponDef
Task: T019 emitMovementDef
Task: T020 emitBuilderDef
Task: T021 emitEconomyDef
Task: T022 emitBuildingDef
# Then sequentially:
T023 → T024 → T025 → T026 → T027

# Phase 4 — all test files in parallel
Task: T028 CompletenessTests.fs
Task: T029 CorrectnessTests.fs
Task: T030 CapabilityTests.fs
Task: T031 StructuralTests.fs
# Then: T032
```

---

## Implementation Strategy

### MVP First (US1 + US2)

1. Complete Phase 1: Setup
2. Complete Phase 2: Foundational (type definitions)
3. Complete Phase 3: Generator + compilation
4. **STOP and VALIDATE**: `dotnet build data/bar/BarData.fsproj` succeeds, fields accessible as typed values
5. This is the MVP — typed BAR data usable immediately

### Incremental Delivery

1. Setup + Foundational → Types compile
2. US1+US2 (Phase 3) → Generator emits typed records → **MVP deployed**
3. US3 (Phase 4) → Test suite validates data → **Confidence delivered**
4. Polish (Phase 5) → Docs updated → **Feature complete**

---

## Notes

- All generated files in data/bar/src/ (except Types.fs, Commands.fs, CustomCommands.fs) are overwritten on each generator run
- The generator script (tools/generate-bar-data.fsx) is modified in-place — the Lua parser and clone logic are unchanged
- ValueOrExpr<float> is used for fields known to contain runtime expressions in ~35 units; most fields use plain types
- The `extras` map on UnitDef and WeaponDef captures any Lua fields not mapped to typed record fields — ensures zero data loss
