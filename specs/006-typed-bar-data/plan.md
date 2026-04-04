# Implementation Plan: Typed BAR Data Records

**Branch**: `006-typed-bar-data` | **Date**: 2026-04-03 | **Spec**: [spec.md](spec.md)
**Input**: Feature specification from `/specs/006-typed-bar-data/spec.md`

## Summary

Replace the `LuaValue.Table`-based BAR unit data representation with idiomatic F# records using composable capability sub-records. Modify `tools/generate-bar-data.fsx` to emit typed record instances. Add a `ValueOrExpr<'T>` DU for handling runtime Lua expressions. Create an xUnit test suite validating completeness, correctness, and capability assignment across all 953 unit definitions.

## Technical Context

**Language/Version**: F# / .NET 10.0 (generator script, data library, tests)
**Primary Dependencies**: XParsec (Lua parser in generator), xUnit (test framework)
**Storage**: Filesystem only (generated .fs source files)
**Testing**: xUnit via `dotnet test`
**Target Platform**: .NET 10.0 class library (cross-platform)
**Project Type**: Code generator + data library + test suite
**Performance Goals**: N/A (compile-time generated static data, no runtime performance concerns)
**Constraints**: Generated code must compile; generator must handle ~953 unit files without failure
**Scale/Scope**: 953 unit definitions, ~102 generated source files, ~9 record type definitions

## Constitution Check

*GATE: Must pass before Phase 0 research. Re-check after Phase 1 design.*

| Principle | Status | Notes |
|-----------|--------|-------|
| I. Zero Engine Modifications | N/A | Data library only — no engine interaction |
| II. Binary Protocol First | N/A | No IPC — static data consumed at compile time |
| III. Correctness Over Cleverness | PASS | 1:1 mapping from Lua source fields to typed record fields. No transformations beyond type coercion. `ValueOrExpr` preserves unevaluable expressions verbatim. |
| IV. Test at the Boundary | PASS | Tests validate the Lua→F# boundary: parsed Lua values match generated typed records. Spot-check assertions verify field values against known Lua source. |
| V. Latency Budget Discipline | N/A | No hot path — data is compile-time static |
| VI. Language-Agnostic by Default | PASS | This library is F#-specific by design (it generates F# source code), but does not affect the proto schema contract. The proto schema remains the language-agnostic IPC contract per Principle VI. |
| VII. Explicit Over Implicit | PASS | All fields explicitly typed. Optional capabilities use `option`. Runtime expressions explicitly marked via `ValueOrExpr.Expr`. No implicit defaults or conversions. |

**Gate result**: PASS — no violations.

## Project Structure

### Documentation (this feature)

```text
specs/006-typed-bar-data/
├── plan.md              # This file
├── research.md          # Phase 0 output
├── data-model.md        # Phase 1 output
├── quickstart.md        # Phase 1 output
└── tasks.md             # Phase 2 output (created by /speckit.tasks)
```

### Source Code (repository root)

```text
tools/
└── generate-bar-data.fsx    # Modified: emit typed records instead of LuaValue.Table

data/bar/
├── BarData.fsproj            # Updated: new file references
└── src/
    ├── Types.fs              # NEW: ValueOrExpr<'T>, UnitDef, MovementDef, BuilderDef,
    │                         #       WeaponDef, EconomyDef, BuildingDef, FeatureDef, SoundDef
    ├── Commands.fs           # UNCHANGED
    ├── CustomCommands.fs     # UNCHANGED
    ├── ArmBots.fs            # REGENERATED: typed record instances
    ├── ...                   # (all ~100 unit module files regenerated)
    └── AllUnits.fs           # REGENERATED: index using UnitDef type

data/bar.tests/
├── BarData.Tests.fsproj      # NEW: xUnit test project
└── Tests/
    ├── CompletenessTests.fs  # NEW: unit count per faction, all units present
    ├── CorrectnessTests.fs   # NEW: spot-check field values against known Lua values
    ├── CapabilityTests.fs    # NEW: verify capability sub-record assignment
    └── StructuralTests.fs    # NEW: no zero health, no negative costs, etc.
```

**Structure Decision**: Follows the existing `data/bar/` layout. `LuaValue.fs` is removed and replaced by `Types.fs` (must be first in compile order). Test project added as a sibling `data/bar.tests/` directory following .NET conventions.
