# Feature Specification: Unified BAR Data Generators with Cross-Conversion

**Feature Branch**: `008-unified-bar-generators`  
**Created**: 2026-04-03  
**Status**: Draft  
**Input**: User description: "both v1 and new flat representation of unit types are useful views, change the script to create both with a conversion function in both."

## User Scenarios & Testing

### User Story 1 - Generate a Unified Library with Both Representations (Priority: P1)

A developer runs one generator script and gets a single library (`data/bar/`) containing both the composable-capability types (UnitDef with optional sub-records) and the flat per-unit types (unique record per unit), generated from the same BAR Lua source data in a single pass.

**Why this priority**: Eliminates the maintenance burden of two separate generators and two separate libraries. A single source of truth for parsing and a single project avoids drift between representations.

**Independent Test**: Running the unified generator produces `data/bar/` with both UnitDef-based and flat per-unit generated source files. `dotnet build` and `dotnet test` pass.

**Acceptance Scenarios**:

1. **Given** a cloned BAR repo with Lua unit definitions, **When** the developer runs the unified generator script, **Then** `data/bar/` is populated with generated F# source files for both representations, and the project compiles with zero errors.
2. **Given** the library has not been generated yet, **When** the developer runs the unified generator script, **Then** the library is created from scratch and its test suite passes.
3. **Given** a previously generated library exists, **When** the developer re-runs the unified generator script, **Then** the library is regenerated (old generated files cleaned, new ones written) and compiles and passes tests.

---

### User Story 2 - Convert from UnitDef to Flat Per-Unit Type (Priority: P2)

A developer working with the composable-capability representation (UnitDef) wants to obtain the flat per-unit representation for a specific unit. They call a conversion function that produces a record with only the fields that unit actually has.

**Why this priority**: Cross-conversion enables interoperability — developers can start with whichever representation suits their task and convert when needed.

**Independent Test**: Calling `toFlat` on a `UnitDef` for a known unit (e.g., armck) returns a record whose field values match the corresponding flat type singleton.

**Acceptance Scenarios**:

1. **Given** a `UnitDef` for a builder unit (armck), **When** the developer calls the UnitDef-to-flat conversion function, **Then** the result contains direct `workerTime`, `speed`, and `buildOptions` fields (not option-wrapped) with values matching the flat singleton `ArmBots.armck`.
2. **Given** a `UnitDef` for a static building (armsolar), **When** the developer calls the UnitDef-to-flat conversion function, **Then** the result contains `yardMap` and `energyStorage` fields but no movement fields.
3. **Given** a `UnitDef` with Lua expression fields (Expr values), **When** the developer calls the conversion function, **Then** expression values are preserved as-is in the output.

---

### User Story 3 - Convert from Flat Per-Unit Type to UnitDef (Priority: P2)

A developer working with a flat per-unit type wants to obtain the composable `UnitDef` representation. They call a conversion function that wraps the flat fields back into the sub-record structure (`MovementDef option`, `BuilderDef option`, etc.).

**Why this priority**: Same interoperability rationale as US2, but in the reverse direction. Both conversions together make the two representations fully interchangeable.

**Independent Test**: Calling `toUnitDef` on a flat per-unit instance (e.g., `ArmBots.armck`) returns a `UnitDef` whose field values match the composable representation.

**Acceptance Scenarios**:

1. **Given** a flat per-unit instance for a combat unit (armham), **When** the developer calls the flat-to-UnitDef conversion function, **Then** the result is a `UnitDef` with `movement = Some { speed = Concrete 46.2; ... }` and `weapons = Some [...]`.
2. **Given** a flat per-unit instance for a building (armsolar), **When** the developer calls the flat-to-UnitDef conversion function, **Then** the result is a `UnitDef` with `movement = None` and `building = Some { yardMap = Some "..."; ... }`.
3. **Given** a flat per-unit instance with extras and custom params, **When** the developer calls the conversion function, **Then** all `extras` and `customParams` entries are preserved in the resulting `UnitDef`.

---

### Edge Cases

- What happens when a flat per-unit type has fields not representable in v1 (e.g., future flat-only fields)? — Extra fields are placed in the `extras` map of the v1 `UnitDef`.
- How does conversion handle units with zero weapons but a `weapondefs` table in Lua? — Same as current behavior: `weapons = None` in v1, no `weapons` field on the flat type.
- How does round-trip conversion preserve fidelity? — All UnitDef fields are represented in the flat types (universal fields added for objectName, buildPic, etc.), so converting UnitDef → flat → UnitDef produces an equivalent result with no data loss.

## Requirements

### Functional Requirements

- **FR-001**: The system MUST provide a single generator script that produces a unified library containing both the composable-capability types and the flat per-unit types from the same Lua source data.
- **FR-002**: The unified generator MUST share the Lua parsing phase between both output representations — parsing each unit file exactly once.
- **FR-003**: The unified library MUST include a generated conversion function per unit that transforms a `UnitDef` into the corresponding flat per-unit record type.
- **FR-004**: The unified library MUST include a generated conversion function per unit that transforms a flat per-unit instance into a `UnitDef`.
- **FR-005**: Conversion functions MUST preserve all field values including `ValueOrExpr.Expr` expressions, `extras` maps, `customParams`, weapon definitions, feature definitions, and sound definitions.
- **FR-008**: Flat per-unit types MUST include all fields present on the v1 `UnitDef` as universal fields — specifically `objectName`, `buildPic`, `script`, `corpse`, `explodeAs`, `selfDestructAs`, `collisionVolumeOffsets`, `collisionVolumeScales`, `collisionVolumeType`, `seismicSignature`, and `category` — so that round-trip conversion is lossless.
- **FR-006**: The unified library MUST compile with zero errors after generation.
- **FR-007**: The existing test functionality from both the former v1 and v2 test suites MUST be preserved in a single unified test project.

### Key Entities

- **UnitDef**: Composable-capability representation with optional sub-records (`MovementDef option`, `BuilderDef option`, `EconomyDef option`, `BuildingDef option`). Lives in `BarData` namespace alongside all other types.
- **Per-Unit Type**: Flat record type unique to each unit, containing only fields that unit actually has. Lives in `BarData.Units` namespace.
- **Conversion Functions**: Generated functions that transform between the two representations — one `toFlat` and one `toUnitDef` per unit, living in the same library.

## Success Criteria

### Measurable Outcomes

- **SC-001**: Running the unified generator produces the single library in one invocation — no need to run two separate scripts.
- **SC-002**: The unified library compiles with zero errors and the consolidated test suite passes all existing tests.
- **SC-003**: Round-trip conversion (UnitDef → flat → UnitDef) produces equivalent field values for at least 20 spot-checked units across all factions.
- **SC-004**: Conversion functions handle all 953 units without errors.

## Clarifications

### Session 2026-04-03

- Q: Where do conversion functions live? → A: Option B — both directions in a single library. Additionally, v1 composable types are incorporated into the same library as the flat types. There is no reason to maintain two separate libraries.
- Q: How should conversion handle v1 fields missing from flat types? → A: Option A — add the ~10 missing fields (objectName, buildPic, script, corpse, explodeAs, selfDestructAs, collisionVolumeOffsets/Scales/Type, seismicSignature, category) as universal fields on every flat per-unit type. This makes round-trip conversion lossless.

## Assumptions

- The two separate generator scripts (`generate-bar-data.fsx` and `generate-bar-data-flat.fsx`) will be replaced by a single unified script.
- The v1 and v2 representations are merged into a single library at `data/bar/` under the `BarData` namespace. The separate `data/bar-v1/` project is eliminated.
- Both the composable-capability types (UnitDef, MovementDef, BuilderDef, etc.) and flat per-unit types coexist in the same project and namespace.
- Conversion functions are generated (not hand-written) since they need per-unit knowledge of which fields are present.
- Both conversion directions (UnitDef→flat and flat→UnitDef) live in the same library alongside both type representations.
