# Feature Specification: Typed BAR Data Records

**Feature Branch**: `006-typed-bar-data`  
**Created**: 2026-04-03  
**Status**: Draft  
**Input**: User description: "Change BAR data generator to emit idiomatic F# records and DUs with simple .NET types, then create and run a test suite for completeness and correctness."

## Clarifications

### Session 2026-04-03

- Q: Should UnitDef be one flat record, a mutually-exclusive DU by mobility, composable capability sub-records, or a focused base + extras map? → A: Option C — Shared base record with universal fields (cost, health, model) plus optional composable capability sub-records: `movement: MovementDef option`, `builder: BuilderDef option`, `weapons: WeaponDef list option`, `economy: EconomyDef option`, `building: BuildingDef option`. Units gain capabilities by having `Some` for each applicable sub-record (e.g., a commander gets movement + builder + weapons; a solar gets economy + building).
- Q: How should weapon damage tables (varying armor class names to damage values) be represented? → A: `Map<string, float>` — flexible, handles any armor class, easy to query.
- Q: How should the SoundDef be modeled (mix of single named sounds and indexed sound lists)? → A: Typed record with known fields: `build: string option`, `repair: string option`, `ok: string list`, `select: string list`, `count: string list`, etc.
- Q: Should `LuaValue.fs` be kept, removed, or deprecated? → A: Remove entirely — typed records are the only public API.
- Q: How should typed record fields handle Lua runtime expressions where a concrete value was expected? → A: `ValueOrExpr<'T>` DU with cases `Concrete of 'T | Expr of string`. Investigation found ~35 files with expressions: ~20 are truly runtime-dependent (`Spring.GetModOptions()`, `Spring.GetTeamList()`), ~15 are semi-static (loop-generated variants, `VFS.Include`), ~2 are trivially evaluable (`1/70`). Only trivial arithmetic should be evaluated at generation time; all others use `Expr`.

## User Scenarios & Testing *(mandatory)*

### User Story 1 - Access Unit Stats via Typed Records (Priority: P1)

An AI developer references a unit definition and gets strongly-typed access to its stats — metal cost, energy cost, health, speed, sight distance, etc. — as native .NET numeric/boolean/string values, without having to call `LuaValue.getNumber` or pattern-match on discriminated unions wrapping Lua concepts. Capability-specific fields are accessed through composable sub-records (e.g., `unit.movement.Value.speed` for mobile units, `unit.weapons.Value` for armed units).

**Why this priority**: This is the core value proposition. Every downstream consumer of BAR data benefits from compile-time type safety and IntelliSense/autocomplete on unit fields.

**Independent Test**: Can be tested by referencing any generated unit record (e.g., `ArmBots.armham.metalCost`) and verifying the value is a `ValueOrExpr<float>` (typically `Concrete 130.0`) matching the original Lua source.

**Acceptance Scenarios**:

1. **Given** a generated unit definition, **When** a developer accesses `unit.metalCost`, **Then** they get a `ValueOrExpr<float>` value (e.g., `Concrete 130.0` for literal values, `Expr "..."` for runtime expressions) — no `LuaValue` helper functions needed.
2. **Given** a unit with weapon definitions, **When** a developer accesses `unit.weapons`, **Then** they get `Some` of a list of typed weapon records with fields like `damage`, `range`, `reloadTime`.
3. **Given** a unit with build options, **When** a developer accesses `unit.builder`, **Then** they get `Some` of a `BuilderDef` record containing a `buildOptions: string list`.
4. **Given** a commander unit, **When** a developer inspects its capabilities, **Then** `unit.movement`, `unit.builder`, and `unit.weapons` are all `Some`, reflecting that commanders can move, build, and fight.
5. **Given** a static economy building (e.g., solar), **When** a developer inspects its capabilities, **Then** `unit.movement` is `None`, `unit.building` is `Some`, and `unit.economy` is `Some`.
6. **Given** a unit with a runtime expression field (e.g., assist drone workertime depending on mod options), **When** a developer accesses that field, **Then** they get `ValueOrExpr.Expr "Spring.GetModOptions().assistdronesbuildpowermultiplier"` preserving the original expression.

---

### User Story 2 - Regenerate Data from BAR Repo (Priority: P1)

A developer runs the generator script against the BAR repo and it produces the new typed F# records instead of the old `LuaValue.Table` literals.

**Why this priority**: Without the generator producing the new format, no typed data exists. This is the means of producing Story 1's output.

**Independent Test**: Run `dotnet fsi tools/generate-bar-data.fsx --skip-clone` and verify the output files contain F# record definitions, the project builds, and unit counts match.

**Acceptance Scenarios**:

1. **Given** a cloned BAR repo at `bar-repo/`, **When** the generator runs, **Then** it produces F# source files with record type definitions and record instance literals in `data/bar/src/`.
2. **Given** the generator has run, **When** `dotnet build data/bar/BarData.fsproj` is executed, **Then** it compiles without errors.
3. **Given** 953 unit definitions in the BAR repo, **When** the generator runs, **Then** at least 950 units are emitted (allowing for minor parse failures logged as warnings).

---

### User Story 3 - Validate Data Completeness and Correctness (Priority: P2)

A developer runs an automated test suite that verifies the generated typed data is complete (all units present, no missing critical fields) and correct (values match the Lua source).

**Why this priority**: Without tests, there's no confidence that the type conversion preserved data fidelity. This is essential for trusting the generated data.

**Independent Test**: Run `dotnet test` on the test project and see pass/fail results for completeness and correctness checks.

**Acceptance Scenarios**:

1. **Given** the generated data library, **When** the completeness tests run, **Then** they verify all expected units from each faction/subfolder are present.
2. **Given** a representative sample of units, **When** the correctness tests run, **Then** they verify key numeric fields (metalCost, health, speed) match known values from the Lua source.
3. **Given** the generated data, **When** structural tests run, **Then** they verify no unit has zero health, negative metal cost, or other obviously invalid values.
4. **Given** units of different capability types, **When** capability tests run, **Then** they verify builders have `Some builder`, armed units have `Some weapons`, mobile units have `Some movement`, and static buildings have `None` for movement.

---

### Edge Cases

- What happens when a Lua unit file contains runtime expressions (e.g., `math.ceil(...)`, `Spring.GetModOptions()`)? Fields use `ValueOrExpr<'T>` — truly runtime expressions become `Expr "original lua text"`, trivial arithmetic (e.g., `1/70`) is evaluated at generation time to `Concrete 0.01428...`.
- How does the system handle units with missing optional fields? Optional fields use `Option<T>` with `None` for absent data.
- What happens when weapon definitions contain nested tables with varying structures? The weapon record type has ~20 core typed fields plus a `Map<string, string>` extras map for the remaining ~160 rare weapon fields.
- How are commanders handled, since they are simultaneously builders AND armed combatants? The composable capability model handles this naturally — a commander has `Some movement`, `Some builder`, and `Some weapons` simultaneously.
- How are loop-generated units handled (e.g., `scavengerbossv4.lua` generates multiple difficulty variants in a Lua loop)? These files produce expressions that cannot be statically evaluated; the generator captures what it can parse and marks dynamic values as `Expr`.

## Requirements *(mandatory)*

### Functional Requirements

- **FR-001**: Generator MUST produce a `UnitDef` record type with universal fields (metalCost, energyCost, buildTime, health, sightDistance, footprint, model info, etc.) as typed .NET values.
- **FR-002**: Generator MUST produce composable capability sub-records: `MovementDef` (speed, acceleration, turnRate, movementClass), `BuilderDef` (workerTime, buildDistance, buildOptions), `WeaponDef` (damage as `Map<string, float>`, range, reloadTime, weaponType, areaOfEffect), `EconomyDef` (energyMake, metalMake, storage), `BuildingDef` (yardMap, footprint details), `FeatureDef` (wreckage), `SoundDef` (typed record with known sound fields).
- **FR-003**: Each capability sub-record MUST be an `option` field on `UnitDef`, present (`Some`) only when the unit has that capability.
- **FR-004**: Generator MUST preserve the existing module structure — one module per subfolder, each with individual unit bindings and an `all` list.
- **FR-005**: Generator MUST preserve the `AllUnits` index module with `all` list and `tryFind` function, updated to use the new `UnitDef` record type.
- **FR-006**: Generator MUST preserve `Commands.fs` and `CustomCommands.fs` unchanged (they are already idiomatic).
- **FR-007**: A `ValueOrExpr<'T>` discriminated union MUST be provided with cases `Concrete of 'T` and `Expr of string`. Fields that may contain Lua runtime expressions MUST use this type. Trivial arithmetic expressions (e.g., `1/70`) SHOULD be evaluated to `Concrete` at generation time; all other expressions (Spring API calls, variable references, loop-dependent values) MUST use `Expr`.
- **FR-008**: `LuaValue.fs` MUST be removed from the published library — the new typed records are the only public API.
- **FR-009**: A test project MUST be created that validates generated data completeness (unit count per faction, presence of key fields), correctness (spot-check known values), and capability assignment (builders have `Some builder`, armed units have `Some weapons`, etc.).
- **FR-010**: The generated `.fsproj` MUST be updated to reference the new source files and any new type definition files.
- **FR-011**: Build options MUST be represented as `string list` on the `BuilderDef` sub-record.
- **FR-012**: Custom parameters MUST be represented as `Map<string, string>` on `UnitDef`.
- **FR-013**: WeaponDef MUST have typed fields for the ~20 core weapon fields (range, reloadTime, damage as `Map<string, float>`, weaponType, areaOfEffect, accuracy, weaponVelocity, etc.) plus a `Map<string, string>` for rare/custom weapon fields.
- **FR-014**: SoundDef MUST be a typed record with known fields: single sounds as `string option` (build, repair, working, underattack, canceldestruct, capture) and indexed sound lists as `string list` (ok, select, count, cant).

### Key Entities

- **ValueOrExpr<'T>**: Generic DU wrapping a concrete typed value or an unevaluated Lua expression string. Used on fields where ~35 unit files contain runtime expressions.
- **UnitDef**: Core record with universal fields (costs, health, sightDistance, footprint, model, sounds, customParams) plus optional capability sub-records for movement, building, economy, weapons, and feature defs.
- **MovementDef**: Sub-record for mobile units — speed, maxAcc, maxDec, turnRate, movementClass, maxSlope, maxWaterDepth.
- **BuilderDef**: Sub-record for constructors — workerTime, buildDistance, buildOptions (string list), terraformSpeed.
- **WeaponDef**: Record for weapon definitions — ~20 core typed fields (damage as `Map<string, float>`, range, reloadTime, weaponType, areaOfEffect, accuracy, weaponVelocity) plus extras map for rare fields.
- **EconomyDef**: Sub-record for resource production — energyMake, metalMake, energyStorage, metalStorage.
- **BuildingDef**: Sub-record for static structures — yardMap and building-specific fields.
- **FeatureDef**: Record for wreckage/corpse definitions — metal reclaim value, health/damage, collision volume, model object.
- **SoundDef**: Typed record for unit sound assignments — single sounds as `string option` (build, repair, working, underattack, canceldestruct, capture) and indexed sound lists as `string list` (ok, select, count, cant).

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: All unit fields are accessible as native .NET types without helper functions — verified by the test suite compiling and accessing fields directly.
- **SC-002**: At least 950 of the 953 known unit definitions are present in the generated output.
- **SC-003**: The test suite includes at least 20 spot-check assertions verifying specific unit field values match known Lua source values.
- **SC-004**: The generated library compiles with zero errors and zero warnings on `dotnet build`.
- **SC-005**: The test suite passes with 100% of tests green on a clean build.
- **SC-006**: No data loss — fields present in the old `LuaValue.Table` representation are accessible in the new record types (either as typed fields, capability sub-records, or extras/custom maps).
- **SC-007**: Capability sub-records are correctly assigned — every unit with `builder=true` and `buildoptions` in Lua has `Some builder`, every unit with `weapondefs` entries has `Some weapons`, every mobile unit (`canmove=true` OR `canfly=true` OR `speed > 0` without `yardmap`) has `Some movement`, every unit with `yardmap` has `Some building`, and every unit producing resources (`energymake > 0` OR `metalmake > 0` OR `extractsmetal`) has `Some economy`.
- **SC-008**: Runtime Lua expressions are preserved — units with `Spring.GetModOptions()` or similar expressions have `ValueOrExpr.Expr` values that contain the original expression text.

## Assumptions

- The BAR repo clone at `bar-repo/` is available (or can be re-cloned by the generator) and contains the same ~953 unit definitions as the current generated data.
- `Commands.fs` and `CustomCommands.fs` are already idiomatic and do not need changes — they will be preserved as-is.
- The ~35 units containing Lua runtime expressions will have those expression values stored via `ValueOrExpr.Expr` rather than evaluated (except trivial arithmetic).
- The record type definitions (Types.fs) are hand-authored to define the schema; record *instances* (unit data) are generated by the script to stay in sync with the Lua source.
- The test project will be an xUnit project consistent with the existing test infrastructure in this repo.
- Fields not present in a given unit's Lua source will use F# `option` types (returning `None`) rather than default/sentinel values.
- The `customparams.unitgroup` field from the Lua source can be used to validate capability assignment but is not the sole determinant — field presence (e.g., `builder=true`, `weapondefs` table) is authoritative.
- Loop-generated unit files (scavenger bosses, effigies, lootboxes) that produce multiple variants via Lua loops will have expression-dependent fields captured as `ValueOrExpr.Expr`; the generator does not attempt to interpret Lua control flow.
