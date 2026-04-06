# Implementation Plan: Extract and Save Map Data

**Branch**: `027-extract-save-map-data` | **Date**: 2026-04-06 | **Spec**: [spec.md](spec.md)
**Input**: Feature specification from `/specs/027-extract-save-map-data/spec.md`

## Summary

Add a new persistent test class (T11_MapDataExport) that extracts all map data types from a live headless engine, validates each result is non-null and non-empty with correct dimensions and value ranges, saves all validated data to files on disk, and produces a summary report. This extends the existing persistent test infrastructure following the established T9_MapTests pattern but with stricter assertions and file output.

## Technical Context

**Language/Version**: F# / .NET 10.0 (test project), leveraging existing HighBar.Client  
**Primary Dependencies**: HighBar.Client, xUnit 2.9.x, Google.Protobuf 3.28, System.IO  
**Storage**: Filesystem — output files written to session directory and a persistent reports directory  
**Testing**: xUnit with PersistentEngineFixture, run via `./tests/run-all.sh --category persistent`  
**Target Platform**: Linux (headless engine test environment)  
**Project Type**: Test suite extension (persistent integration tests)  
**Performance Goals**: N/A — test-time extraction, not hot-path  
**Constraints**: Callback queries must execute inside `engine.RunFrames()` callback; single-threaded engine interaction  
**Scale/Scope**: Single map (Red Rock Desert v2 default), all 10 map data types

## Constitution Check

*GATE: Must pass before Phase 0 research. Re-check after Phase 1 design.*

| Principle | Status | Notes |
|-----------|--------|-------|
| I. Zero Engine Modifications | PASS | Uses standard SSkirmishAICallback queries only |
| II. Binary Protocol First | PASS | All queries go through existing protobuf/UDS pipeline |
| III. Correctness Over Cleverness | PASS | Direct 1:1 extraction and validation, no transformations |
| IV. Test at the Boundary | PASS | Tests the full proxy→client deserialization boundary with live engine data |
| V. Latency Budget Discipline | N/A | Test-time only, not hot-path |
| VI. Language-Agnostic by Default | PASS | Uses existing proto-generated client, no protocol changes |
| VII. Explicit Over Implicit | PASS | All validation thresholds explicit, output paths documented |

No violations. No complexity tracking needed.

## Project Structure

### Documentation (this feature)

```text
specs/027-extract-save-map-data/
├── plan.md              # This file
├── research.md          # Phase 0 output
├── data-model.md        # Phase 1 output
├── quickstart.md        # Phase 1 output
└── tasks.md             # Phase 2 output (via /speckit.tasks)
```

### Source Code (repository root)

```text
tests/persistent/fsharp/
├── T11_MapDataExport.fs          # NEW: Main test class
└── HighBar.PersistentTests.fsproj # MODIFIED: Add T11 to compile order

reports/
└── map-data/                      # NEW: Persistent output directory for saved map data
    └── {map-name}/                # Per-map subdirectory
        ├── heightmap.bin          # Raw float32 array
        ├── corners-heightmap.bin  # Raw float32 array
        ├── slope-map.bin          # Raw float32 array
        ├── los-map.bin            # Raw int array
        ├── radar-map.bin          # Raw int array
        ├── resource-map-metal.bin # Raw int array
        ├── metal-spots.csv        # x,y,z,income per line
        ├── start-positions.csv    # teamId,x,y,z per line
        └── summary.json           # Extraction report
```

**Structure Decision**: Extends existing persistent test directory. New test file follows T{N} naming convention (T11). Output saved to `reports/map-data/` for persistence across test runs (session dirs are ephemeral). Binary format for array data (compact, exact representation); CSV for human-readable structured data; JSON for the summary report.
