# Implementation Plan: Remove Python and Upgrade to .NET 10

**Branch**: `019-remove-python-dotnet10` | **Date**: 2026-04-04 | **Spec**: [spec.md](spec.md)
**Input**: Feature specification from `/specs/019-remove-python-dotnet10/spec.md`

## Summary

Remove all Python code, tooling, and references from the HighBarV2 repository and upgrade all F# projects from .NET 8.0 to .NET 10. This simplifies the project to two languages (F# and C), eliminates the unused secondary Python client, and moves to the current .NET release. The `patch-chobby-ai.py` script will be rewritten in Bash, and the `dummy-client.py` test fixture will be rewritten in F#.

## Technical Context

**Language/Version**: F# / .NET 10.0 (upgrade from .NET 8.0), C11 (unchanged)
**Primary Dependencies**: Google.Protobuf 3.28.*, xUnit 2.9.x, Microsoft.NET.Test.Sdk 17.x, System.Text.Json 8.x
**Storage**: Filesystem only (config files, reports, Unix domain sockets)
**Testing**: xUnit (F#), CTest/CMake (C proxy)
**Target Platform**: Linux (primary development and deployment platform)
**Project Type**: Library + CLI tools + test harnesses
**Performance Goals**: Proxy overhead < 1ms per frame (unchanged)
**Constraints**: Must maintain all existing F# and C test coverage; no regressions
**Scale/Scope**: 11 .fsproj files to upgrade, 2 Python scripts to rewrite, ~15 files with Python references to clean up

## Constitution Check

*GATE: Must pass before Phase 0 research. Re-check after Phase 1 design.*

| Principle | Status | Notes |
|-----------|--------|-------|
| I. Zero Engine Modifications | PASS | No engine changes; proxy plugin interface unchanged |
| II. Binary Protocol First | PASS | Protobuf/UDS protocol unchanged; only removing Python betterproto generation |
| III. Correctness Over Cleverness | PASS | Straightforward removal and version bump; no "smart" transformations |
| IV. Test at the Boundary | PASS | All boundary tests preserved in F# and C; Python tests were secondary duplicates |
| V. Latency Budget Discipline | PASS | No hot-path changes; .NET 10 may improve performance |
| VI. Language-Agnostic by Default | NOTE | Removing Python client reduces language coverage, but the .proto schema remains the contract. Any future Python client can be regenerated from schemas. |
| VII. Explicit Over Implicit | PASS | No configuration behavior changes |

**Gate result**: PASS. Principle VI is acknowledged — the proto schema remains language-agnostic; only the pre-built Python client is removed.

## Project Structure

### Documentation (this feature)

```text
specs/019-remove-python-dotnet10/
├── plan.md              # This file
├── research.md          # Phase 0 output
├── data-model.md        # Phase 1 output (minimal — no new data entities)
├── quickstart.md        # Phase 1 output
└── tasks.md             # Phase 2 output (/speckit.tasks command)
```

### Source Code (repository root)

```text
# Files/directories to DELETE
clients/python/                    # Entire Python client library
tests/integration/python/          # Python integration tests
tests/fixtures/dummy-client.py     # Python test fixture
scripts/patch-chobby-ai.py         # Python deployment script
proto/gen/python/                  # Generated Python protobuf bindings (if tracked)

# Files to MODIFY
clients/fsharp/HighBar.Client.fsproj          # net8.0 → net10.0
data/bar/BarData.fsproj                        # net8.0 → net10.0
data/bar.tests/BarData.Tests.fsproj            # net8.0 → net10.0
tests/ai/fsharp/HighBar.AI.Tests.fsproj        # net8.0 → net10.0
tests/unit/fsharp/HighBar.Unit.Tests.fsproj    # net8.0 → net10.0
tests/integration/fsharp/HighBar.Tests.fsproj  # net8.0 → net10.0
tests/persistent/fsharp/HighBar.PersistentTests.fsproj # net8.0 → net10.0
tools/echo-ai/EchoAI.fsproj                   # net8.0 → net10.0
tools/game-runner/GameRunner.fsproj            # net8.0 → net10.0
tools/reference-ai/ReferenceAI.fsproj          # net8.0 → net10.0
tools/replay/Replay.fsproj                     # net8.0 → net10.0
proto/buf.gen.yaml                             # Remove betterproto plugin
tests/run-all.sh                               # Remove python test category
scripts/install-ai.sh                          # Replace python3 call with bash equivalent
CLAUDE.md                                      # Remove Python refs, update .NET version
specs/*/plan.md, specs/*/spec.md               # Remove Python from technology sections

# Files to CREATE
scripts/patch-chobby-ai.sh                    # Bash rewrite of patch-chobby-ai.py
tests/fixtures/DummyClient/                    # F# rewrite of dummy-client.py (if needed)
```

**Structure Decision**: No new directories or structural changes. This is a subtraction (remove Python) plus an in-place upgrade (.NET 10). The `patch-chobby-ai.py` becomes `patch-chobby-ai.sh` in the same location.

## Complexity Tracking

> No constitution violations. Table not required.
