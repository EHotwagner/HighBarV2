# Research: Flat Per-Unit BAR Type Definitions

**Feature**: 007-flat-bar-types | **Date**: 2026-04-03

## R1: Per-Unit Type Generation Strategy in F#

**Decision**: Generate one F# record type per unit, named with PascalCase unit ID (e.g., `type Armck = { ... }`), each containing only the fields present in that unit's Lua definition. Each module also contains a singleton `let` binding of that type with the actual data.

**Rationale**: F# record types are structural — each unit having its own type means IntelliSense shows only relevant fields. Since each unit has a distinct field set (builders have `workerTime`, flyers have `cruiseAltitude`, etc.), separate types eliminate all `option` wrapping for present capabilities. The singleton pattern (`let armck : Armck = { ... }`) provides both the type definition and the data in one place.

**Alternatives considered**:
- **Anonymous records**: No named type for IntelliSense, can't be used in typed collections.
- **Interfaces per capability**: Heavy boilerplate, poor ergonomics for data access, F# doesn't favor OOP patterns.
- **Single DU with one case per unit**: Would work for pattern matching but doesn't achieve the "only fields that exist" goal — DU cases share a discriminator, not distinct field sets.

## R2: UnitSummary Record for Indexing and Capability Queries

**Decision**: Generate a shared `UnitSummary` record with:
- Common fields: `name`, `subfolder`, `metalCost`, `energyCost`, `health` (as `ValueOrExpr<float>`)
- Capability flags: `isBuilder`, `isArmed`, `isMobile`, `canFly`, `hasEconomy`, `isBuilding`
- A `UnitSummary list` in `AllUnits.fs` for querying

**Rationale**: The summary record bridges the gap between per-unit type safety and collection-level discoverability. Capability flags are derived from the Lua source (e.g., `isBuilder = true` when `builder=true AND buildoptions` exist). The flags are booleans, not `option`, since they describe presence/absence.

**Alternatives considered**:
- **Using feature-006 UnitDef for queries**: Would create a dependency on the archived library, defeating the purpose of separation.
- **Marker interfaces**: F# idiom favors records and modules over interfaces for data.
- **Enum flags**: Less discoverable than named boolean fields.

## R3: Handling Heterogeneous Types in a Single Index

**Decision**: The `AllUnits.fs` module provides:
1. `all: UnitSummary list` — flat list of all summaries for filtering
2. `tryFind: string -> UnitSummary option` — name-based lookup
3. Capability query functions: `builders()`, `armed()`, `mobile()`, `flying()`, `economy()`, `buildings()` — each returns `UnitSummary list`
4. Individual unit data is accessed by importing the specific module (e.g., `ArmBots.armck`)

**Rationale**: The type system can't hold 953 different types in a single typed list. The summary record provides queryability while individual per-unit types provide full field access. This two-level approach matches how developers actually use the data: discover first (summary), then access details (specific type).

## R4: Archive Strategy

**Decision**: Rename `data/bar` → `data/bar-v1`, `data/bar.tests` → `data/bar-v1.tests`. Update internal project references and namespace to `BarData.V1` to avoid conflicts. The new library keeps namespace `BarData`.

**Rationale**: A clean directory rename is simple, reversible, and keeps the archive compilable. Namespace change to `BarData.V1` prevents ambiguity if both are ever referenced from the same solution.

**Alternatives considered**:
- **Subfolder archive**: Muddies the project structure, complicates `.fsproj`.
- **New namespace for new code**: Would break the convention that `data/bar` = `BarData`.
- **Delete old code**: Loses reference material and the ability to compare approaches.

## R5: Generator Script Design

**Decision**: Create `tools/generate-bar-data-flat.fsx` by copying the Lua parsing phases (XParsec parser, LVal AST, expression fallback) from `tools/generate-bar-data.fsx` and replacing the code emission phase entirely. The new emission:
1. Analyzes each unit's parsed `LVal` table to determine which fields are present
2. Generates a unique record type definition per unit with only those fields
3. Generates a singleton instance with the actual values
4. Generates a `UnitSummary` entry per unit
5. Groups units into modules by subfolder (same structure as v1)
6. Generates `AllUnits.fs` with the summary list and query functions

**Rationale**: The Lua parsing logic is battle-tested from feature 006 and handles all edge cases (expressions, comments, nested tables). Only the F# code emission differs between the two approaches.

**Alternatives considered**:
- **Shared parsing library**: Over-engineering for two scripts; copy is simpler and avoids coupling.
- **Modify existing script with a flag**: Complicates the original, risks breaking the archived generator.

## R6: Shared Sub-Types

**Decision**: `ValueOrExpr<'T>`, `SoundDef`, `FeatureDef`, and `WeaponDef` remain shared types defined in `Types.fs`. Per-unit types reference these where applicable. These types are reused because they represent structured sub-records that don't vary in shape per unit — a weapon always has damage/range/reload fields.

**Rationale**: Weapons, sounds, and feature defs have a consistent structure across all units that have them. Making per-unit weapon types would be excessive — the variance is in which weapons a unit has, not in the weapon record shape itself.
