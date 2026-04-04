# Implementation Plan: F# Cheat Command Builders

**Branch**: `010-cheat-command-builders` | **Date**: 2026-04-03 | **Spec**: [spec.md](spec.md)
**Input**: Feature specification from `/specs/010-cheat-command-builders/spec.md`

## Summary

Add four missing builder functions to the F# Commands module: `GiveMeResourceCommand` (resource cheat), `GiveMeNewUnitCommand` (unit spawn cheat), `CallLuaRulesCommand` (Lua rules bridge), and `CallLuaUICommand` (Lua UI bridge). These follow the identical pattern used by the 13 existing builders — construct the inner protobuf message, set fields, assign it to the AICommand oneof, and return.

## Technical Context

**Language/Version**: F# / .NET 10.0  
**Primary Dependencies**: Google.Protobuf (generated types from `proto/highbar/commands.proto`)  
**Storage**: N/A  
**Testing**: xUnit (integration tests against headless engine), plus new unit-level tests for field population  
**Target Platform**: Linux (headless engine testing)  
**Project Type**: Library (F# client library for AI engine integration)  
**Performance Goals**: N/A (builder functions are stateless constructors, not hot-path)  
**Constraints**: Builders must return `Highbar.AICommand` type; must follow existing naming/parameter conventions  
**Scale/Scope**: 4 new functions, ~40 lines of code + tests

## Constitution Check

*GATE: Must pass before Phase 0 research. Re-check after Phase 1 design.*

| Principle | Status | Notes |
|-----------|--------|-------|
| I. Zero Engine Modifications | PASS | No engine changes; uses existing cheat command interface |
| II. Binary Protocol First | PASS | Builders produce protobuf messages; no new wire format |
| III. Correctness Over Cleverness | PASS | 1:1 mapping to documented engine structs (SGiveMeResourceCheatCommand, SGiveMeNewUnitCheatCommand, SCallLuaRulesCommand, SCallLuaUICommand) |
| IV. Test at the Boundary | PASS | Tests verify protobuf field population; integration tests confirm engine execution |
| V. Latency Budget Discipline | PASS | Not hot-path code; stateless constructors |
| VI. Language-Agnostic by Default | PASS | Builders are a thin typed wrapper above generated protobuf code; no protocol-level behavior added |
| VII. Explicit Over Implicit | PASS | All parameters explicit; no hidden defaults |

## Project Structure

### Documentation (this feature)

```text
specs/010-cheat-command-builders/
├── plan.md              # This file
├── research.md          # Phase 0 output
├── data-model.md        # Phase 1 output
└── tasks.md             # Phase 2 output (/speckit.tasks)
```

### Source Code (repository root)

```text
clients/fsharp/
├── src/
│   └── Commands.fs          # Add 4 new builder functions here
└── HighBar.Client.fsproj

tests/
├── unit/fsharp/             # New: unit tests for command builders
│   ├── CommandBuilderTests.fs
│   └── HighBar.Unit.Tests.fsproj
└── integration/fsharp/
    └── CommandTests.fs      # Existing integration tests (optional cheat command tests)
```

**Structure Decision**: New builder functions go in the existing `Commands.fs` file. A new unit test project is created since the existing tests are all integration tests requiring the engine — builder field-population tests need no engine.

## Complexity Tracking

No constitution violations. Table not required.
