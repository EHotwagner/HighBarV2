# Research: Unified BAR Data Generators with Cross-Conversion

**Feature**: 008-unified-bar-generators | **Date**: 2026-04-03

## R1: Unified Generator Architecture

**Decision**: Merge `tools/generate-bar-data.fsx` and `tools/generate-bar-data-flat.fsx` into a single `tools/generate-bar-data.fsx`. The script clones/parses Lua data once, then runs two emission passes: one for composable UnitDef instances and one for flat per-unit types+instances, plus a conversion emission pass.

**Rationale**: The two scripts share ~80% of their code (Lua parser, helpers, sub-record emitters). Merging eliminates duplication and ensures both representations are always generated from identical parsed data. A single script is easier to maintain and reduces the risk of drift.

**Alternatives considered**:
- **Shared parsing library**: Over-engineering for an F# script — would require a separate project/nuget package for code shared between two .fsx files.
- **Keep two scripts, extract common module**: F# scripts don't support project references well; `#load` directives are fragile with NuGet dependencies like XParsec.

## R2: Single Library Structure

**Decision**: Merge v1 composable types and v2 flat types into a single `data/bar/` project. The `BarData` namespace contains shared types (ValueOrExpr, WeaponDef, SoundDef, FeatureDef) and composable types (UnitDef, MovementDef, etc.). The `BarData.Units` namespace contains per-unit flat types and instances. Each unit module also contains the composable UnitDef instance and conversion functions.

**Rationale**: Two separate libraries with identical shared types creates unnecessary complexity. A single library allows conversion functions to reference both type representations directly without circular dependencies.

**Alternatives considered**:
- **Keep two libraries, v2 depends on v1**: Adds a project dependency, complicates builds, and means v1 types live in `BarData.V1` namespace which is confusing when there's only one library users should reference.
- **Three projects (shared + v1 + v2)**: Maximum complexity for minimal benefit.

## R3: Conversion Function Placement

**Decision**: Each unit module (e.g., `ArmBots.fs`) contains:
1. The flat per-unit type definition (e.g., `type Armck = { ... }`)
2. The flat singleton instance (e.g., `let armck : Armck = { ... }`)
3. The composable UnitDef instance (e.g., `let armckDef : UnitDef = { ... }`)
4. A `toUnitDef` function (e.g., `let armckToUnitDef (flat: Armck) : UnitDef = ...`)
5. A `toFlat` function (e.g., `let armckToFlat (def: UnitDef) : Armck = ...`)

**Rationale**: Co-locating both representations and conversions per unit keeps related code together. The generator already iterates per unit, so emitting both representations and conversions in the same pass is natural. Conversion functions are per-unit because each flat type has a unique field set.

**Alternatives considered**:
- **Separate Conversions.fs file**: Would be massive (953 * 2 functions) and harder to navigate. Per-module is more cohesive.
- **Generic conversion via reflection**: Violates "Correctness Over Cleverness" — runtime reflection is slow, fragile, and hard to debug.

## R4: Additional Universal Fields for Flat Types

**Decision**: Add 11 fields to every flat per-unit type that were previously only in the v1 UnitDef: `objectName` (string option), `buildPic` (string option), `script` (string option), `corpse` (string option), `explodeAs` (string option), `selfDestructAs` (string option), `collisionVolumeOffsets` (string option), `collisionVolumeScales` (string option), `collisionVolumeType` (string option), `seismicSignature` (float option), `category` (string option).

**Rationale**: These fields exist on the v1 UnitDef and are present in the Lua source for most units. Adding them to flat types enables lossless round-trip conversion. They remain `option` because not every unit has every one of these (unlike the mandatory universal fields like name, health, metalCost).

**Alternatives considered**:
- **Non-option with defaults**: Would require arbitrary default values (empty string, 0.0) that don't faithfully represent "field not present in Lua source."
- **Put in extras map**: Technically lossless but loses type safety — these are well-known engine fields, not arbitrary extras.

## R5: AllUnitDefs Module

**Decision**: Generate an `AllUnitDefs.fs` module containing `all: (string * string * UnitDef) list`, `tryFind: string -> UnitDef option` — mirroring the v1 AllUnits pattern. The existing `AllUnits.fs` continues to provide UnitSummary-based queries.

**Rationale**: Users of the composable representation need the same discovery/query capabilities that v1 AllUnits provided. Keeping AllUnits.fs for UnitSummary queries and AllUnitDefs.fs for UnitDef queries avoids overloading one module with two different index types.

**Alternatives considered**:
- **Merge into AllUnits.fs**: Would make the file even larger and mix UnitSummary (lightweight) with UnitDef (heavyweight) access patterns.
- **Drop composable index entirely**: Users could construct UnitDef via toUnitDef from flat types, but having pre-built instances is more ergonomic.

## R6: Eliminating data/bar-v1

**Decision**: Delete `data/bar-v1/`, `data/bar-v1.tests/`, and `tools/generate-bar-data-flat.fsx`. The unified library at `data/bar/` replaces both. The unified generator at `tools/generate-bar-data.fsx` replaces both scripts.

**Rationale**: With both representations in one library, the archived v1 project serves no purpose. Keeping it creates confusion about which library to reference.

**Alternatives considered**:
- **Keep v1 as deprecated archive**: Adds maintenance burden with no value once the unified library exists.
