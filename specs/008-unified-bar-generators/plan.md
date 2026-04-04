# Implementation Plan: Unified BAR Data Generators with Cross-Conversion

**Branch**: `008-unified-bar-generators` | **Date**: 2026-04-03 | **Spec**: [spec.md](spec.md)
**Input**: Feature specification from `/specs/008-unified-bar-generators/spec.md`

## Summary

Merge the two separate BAR data generator scripts and two separate F# libraries into a single unified generator and a single library. The unified library at `data/bar/` contains both the composable-capability types (UnitDef with optional sub-records) and flat per-unit types (unique record per unit), plus generated conversion functions between the two representations. The `data/bar-v1/` project is eliminated. Flat per-unit types gain ~10 additional universal fields (objectName, buildPic, etc.) to enable lossless round-trip conversion.

## Technical Context

**Language/Version**: F# / .NET 10.0 (generator script, data library, tests)
**Primary Dependencies**: XParsec (Lua parser in generator), xUnit (test framework)
**Storage**: Filesystem only (generated .fs source files)
**Testing**: xUnit (F# test framework), `dotnet test`
**Target Platform**: .NET 10.0 (cross-platform library)
**Project Type**: Library (code-generated F# data library)
**Performance Goals**: N/A (compile-time data, no runtime hot path)
**Constraints**: Must compile with zero errors/warnings; ~953 unit types to generate; round-trip conversion must be lossless
**Scale/Scope**: ~953 unit type definitions, ~87 module files, one generator script, conversion functions for all 953 units

## Constitution Check

*GATE: Must pass before Phase 0 research. Re-check after Phase 1 design.*

| Principle | Status | Notes |
|-----------|--------|-------|
| I. Zero Engine Modifications | **PASS** | No engine modifications — this is a data library |
| II. Binary Protocol First | **N/A** | No IPC or protocol involved — static data library |
| III. Correctness Over Cleverness | **PASS** | 1:1 mapping from Lua source fields to F# record fields; conversion functions are generated to ensure correctness |
| IV. Test at the Boundary | **PASS** | Tests validate generated data against Lua source (the boundary); round-trip conversion tests verify fidelity |
| V. Latency Budget Discipline | **N/A** | Compile-time data, no runtime hot path |
| VI. Language-Agnostic by Default | **PASS** | F#-specific representation is explicitly the goal; proto schema is unaffected |
| VII. Explicit Over Implicit | **PASS** | Each unit type explicitly declares only its actual fields; conversion functions are explicit per-unit generated code |

All gates pass. No violations requiring justification.

## Project Structure

### Documentation (this feature)

```text
specs/008-unified-bar-generators/
├── plan.md              # This file
├── research.md          # Phase 0 output
├── data-model.md        # Phase 1 output
├── quickstart.md        # Phase 1 output
└── tasks.md             # Phase 2 output (created by /speckit.tasks)
```

### Source Code (repository root)

```text
tools/generate-bar-data.fsx     # Unified generator (replaces both v1 and flat scripts)

data/bar/                        # Unified library (both representations)
├── BarData.fsproj
└── src/
    ├── Types.fs                 # ValueOrExpr<'T>, SoundDef, FeatureDef, WeaponDef
    ├── ComposableTypes.fs       # UnitDef, MovementDef, BuilderDef, EconomyDef, BuildingDef
    ├── Commands.fs              # Engine command constants
    ├── CustomCommands.fs        # Custom command IDs (generated)
    ├── UnitSummary.fs           # Shared UnitSummary record + capability flags
    ├── ArmBots.fs               # Per-unit flat types + instances + composable instances
    ├── ArmBots_T2.fs
    ├── ... (one module per subfolder, ~87+ files)
    ├── AllUnits.fs              # UnitSummary list + tryFind + capability queries
    └── AllUnitDefs.fs           # UnitDef list + tryFind (composable view)

data/bar.tests/                  # Unified tests
├── BarData.Tests.fsproj
└── Tests/
    ├── CompletenessTests.fs
    ├── CorrectnessTests.fs
    ├── CapabilityTests.fs
    ├── StructuralTests.fs
    └── ConversionTests.fs       # NEW: round-trip conversion tests
```

**Structure Decision**: Single project at `data/bar/` replaces both `data/bar-v1/` and former `data/bar/`. The composable types (UnitDef etc.) move from a separate Types.fs into a dedicated `ComposableTypes.fs` to keep shared sub-types (ValueOrExpr, WeaponDef, etc.) in `Types.fs`. Each unit module contains both the flat per-unit type+instance and a composable UnitDef instance, plus `toFlat`/`toUnitDef` conversion functions.

## Complexity Tracking

No constitution violations — table not needed.
