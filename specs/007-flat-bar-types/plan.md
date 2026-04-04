# Implementation Plan: Flat Per-Unit BAR Type Definitions

**Branch**: `007-flat-bar-types` | **Date**: 2026-04-03 | **Spec**: [spec.md](spec.md)
**Input**: Feature specification from `/specs/007-flat-bar-types/spec.md`

## Summary

Generate an alternative F# representation of all 953 BAR unit definitions where each unit gets its own dedicated record type containing only the fields it actually possesses — no `option` wrapping for present capabilities. Archive the existing composable-capability library (`data/bar` → `data/bar-v1`) and create a new `data/bar` project with flat per-unit types plus a shared `UnitSummary` record for indexing and capability queries. A new generator script (`tools/generate-bar-data-flat.fsx`) produces the flat types from the same Lua source data.

## Technical Context

**Language/Version**: F# / .NET 10.0 (generator script, data library, tests)
**Primary Dependencies**: XParsec (Lua parser in generator), xUnit (test framework)
**Storage**: Filesystem only (generated .fs source files)
**Testing**: xUnit (F# test framework), `dotnet test`
**Target Platform**: .NET 10.0 (cross-platform library)
**Project Type**: Library (code-generated F# data library)
**Performance Goals**: N/A (compile-time data, no runtime hot path)
**Constraints**: Must compile with zero errors/warnings; ~953 unit types to generate
**Scale/Scope**: ~953 unit type definitions, ~87 module files, one generator script

## Constitution Check

*GATE: Must pass before Phase 0 research. Re-check after Phase 1 design.*

| Principle | Status | Notes |
|-----------|--------|-------|
| I. Zero Engine Modifications | **PASS** | No engine modifications — this is a data library |
| II. Binary Protocol First | **N/A** | No IPC or protocol involved — static data library |
| III. Correctness Over Cleverness | **PASS** | 1:1 mapping from Lua source fields to F# record fields; no transformations |
| IV. Test at the Boundary | **PASS** | Tests validate generated data against Lua source (the boundary) |
| V. Latency Budget Discipline | **N/A** | Compile-time data, no runtime hot path |
| VI. Language-Agnostic by Default | **PASS** | F#-specific representation is explicitly the goal; proto schema is unaffected |
| VII. Explicit Over Implicit | **PASS** | Each unit type explicitly declares only its actual fields — maximally explicit |

All gates pass. No violations requiring justification.

## Project Structure

### Documentation (this feature)

```text
specs/007-flat-bar-types/
├── plan.md              # This file
├── research.md          # Phase 0 output
├── data-model.md        # Phase 1 output
├── quickstart.md        # Phase 1 output
└── tasks.md             # Phase 2 output (created by /speckit.tasks)
```

### Source Code (repository root)

```text
data/bar-v1/                 # Archived feature-006 composable-capability library
├── BarData.fsproj
└── src/
    ├── Types.fs             # Shared UnitDef record (archived)
    ├── Commands.fs
    ├── CustomCommands.fs
    ├── ArmBots.fs ... (87 module files)
    └── AllUnits.fs

data/bar-v1.tests/           # Archived tests
├── BarData.Tests.fsproj
└── Tests/ (4 test files)

data/bar/                    # NEW flat per-unit type library
├── BarData.fsproj
└── src/
    ├── Types.fs             # ValueOrExpr<'T>, SoundDef, FeatureDef, WeaponDef (shared sub-types)
    ├── UnitSummary.fs       # Shared UnitSummary record + capability flags
    ├── Commands.fs          # Engine command constants (copied from v1)
    ├── CustomCommands.fs    # Custom command IDs (generated)
    ├── ArmBots.fs           # Module with per-unit types + instances
    ├── ArmBots_T2.fs
    ├── ... (one module per subfolder, ~87 files)
    └── AllUnits.fs          # Master index: UnitSummary list + tryFind + capability queries

data/bar.tests/              # NEW tests for flat types
├── BarData.Tests.fsproj
└── Tests/
    ├── CompletenessTests.fs
    ├── CorrectnessTests.fs
    ├── CapabilityTests.fs
    └── StructuralTests.fs

tools/generate-bar-data-flat.fsx  # NEW generator (copies Lua parsing from generate-bar-data.fsx)
```

**Structure Decision**: The archive renames `data/bar` → `data/bar-v1` and `data/bar.tests` → `data/bar-v1.tests`. The new flat types take over `data/bar` and `data/bar.tests`. The generator is a new script that copies the Lua parsing phase from the original and replaces the code emission phase.

## Complexity Tracking

No constitution violations — table not needed.
