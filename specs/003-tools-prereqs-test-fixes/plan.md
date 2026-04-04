# Implementation Plan: Build Tools, Install Prerequisites, and Validate Test Suite

**Branch**: `003-tools-prereqs-test-fixes` | **Date**: 2026-04-02 | **Spec**: [spec.md](spec.md)
**Input**: Feature specification from `/specs/003-tools-prereqs-test-fixes/spec.md`

## Summary

Build all HighBarV2 project components (C proxy, F# client, Python client, developer tools) from a clean state, run all test suites (C unit tests, F# integration tests, Python integration tests), and fix or document every failure encountered. This is an operational validation task, not new feature development.

## Technical Context

**Language/Version**: C11 (proxy), F# / .NET 10.0 (client + tools + tests)
**Primary Dependencies**: protobuf-c (C proxy), Google.Protobuf 3.28 (F#), buf CLI (proto generation)
**Storage**: Filesystem only (reports as markdown)
**Testing**: ctest (C unit tests), xUnit via `dotnet test` (F# integration)
**Target Platform**: Linux (primary)
**Project Type**: Multi-language library + development tools
**Performance Goals**: N/A (build/test task, not hot-path work)
**Constraints**: Headless BAR engine may not be available; integration tests require it
**Scale/Scope**: 4 C unit tests, 22 F# integration tests, 3 developer tools

## Constitution Check

*GATE: Must pass before Phase 0 research. Re-check after Phase 1 design.*

| Principle | Applies | Status | Notes |
|-----------|---------|--------|-------|
| I. Zero Engine Modifications | No | Pass | No engine changes; building existing plugin code |
| II. Binary Protocol First | No | Pass | No protocol changes; using existing protobuf schema |
| III. Correctness Over Cleverness | Yes | Pass | Any fixes must maintain 1:1 struct mapping; no clever workarounds |
| IV. Test at the Boundary | Yes | Pass | Running existing boundary tests (round-trip, event/command serialization) |
| V. Latency Budget Discipline | No | Pass | No hot-path code changes expected |
| VI. Language-Agnostic by Default | No | Pass | No schema modifications |
| VII. Explicit Over Implicit | Yes | Pass | All failures must be explicitly documented with remediation steps |

**Gate result**: PASS - no violations.

## Project Structure

### Documentation (this feature)

```text
specs/003-tools-prereqs-test-fixes/
├── plan.md              # This file
├── research.md          # Phase 0 output
├── data-model.md        # Phase 1 output
├── quickstart.md        # Phase 1 output
└── tasks.md             # Phase 2 output (created by /speckit.tasks)
```

### Source Code (repository root)

```text
proto/                          # Protobuf schema (source of truth)
├── buf.yaml                    # buf lint config
├── buf.gen.yaml                # Code generation config (C, C#, Python)
└── gen/                        # Generated code (not checked in)
    ├── c/                      # protobuf-c output
    ├── csharp/                 # C# output (used by F# client)
    └── python/                 # betterproto output

proxy/                          # C11 shared library (SkirmishAI.so)
├── CMakeLists.txt              # CMake build + 4 unit tests
├── include/highbar/            # Public headers
├── src/                        # Implementation
└── tests/                      # C unit test sources

clients/fsharp/                 # F# client library
├── HighBar.Client.fsproj
├── Client.fs, Events.fs, Commands.fs

clients/python/                 # Python client package
├── pyproject.toml
└── highbar/

tools/                          # Developer utilities (F# executables)
├── echo-ai/EchoAI.fsproj      # Debug echo client
├── reference-ai/ReferenceAI.fsproj  # Demo tactical AI
└── replay/Replay.fsproj        # Session replay tool

tests/                          # Integration test suite
├── fixtures/                   # Engine lifecycle scripts
│   ├── game-setup.lua
│   ├── start-headless.sh
│   └── stop-headless.sh
└── integration/
    ├── fsharp/                 # 22 xUnit tests (5 test files)
    │   └── HighBar.Tests.fsproj
    └── python/                 # 12 pytest tests
```

**Structure Decision**: Existing multi-language structure with shared proto schemas. No structural changes needed — this feature operates within the existing layout.

## Complexity Tracking

No constitution violations to justify.
