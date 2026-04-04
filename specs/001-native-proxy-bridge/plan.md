# Implementation Plan: Native C Proxy Bridge

**Branch**: `001-native-proxy-bridge` | **Date**: 2026-04-02 | **Spec**: [spec.md](spec.md)
**Input**: Feature specification from `/specs/001-native-proxy-bridge/spec.md`

## Summary

Build a native C shared library that plugs into the Recoil engine's Skirmish AI interface, serializes all 28 game event types to protobuf, forwards them over Unix domain sockets to an external AI process, and deserializes command responses for execution. Includes protobuf schema definitions, F# and Python client libraries, and development tooling (replay, echo-test).

## Technical Context

**Language/Version**: C11 (proxy shared library), F# / .NET 10.0 (primary client)
**Primary Dependencies**: protobuf-c (C runtime + codegen), Google.Protobuf (NuGet, .NET), buf (proto tooling)
**Storage**: N/A (filesystem for config only — AIOptions.lua, environment variables)
**Testing**: Mock engine harness (C), round-trip serialization property tests, integration tests via echo-test AI
**Target Platform**: Linux (.so) primary, Windows (.dll) cross-platform via CMake
**Project Type**: Shared library (engine plugin) + protocol schema + client libraries
**Performance Goals**: <1ms total proxy overhead per frame, <100us event serialization, <500us socket round-trip
**Constraints**: Single-threaded, arena allocation (no hot-path heap alloc), 8MB max message size, 25ms default frame timeout
**Scale/Scope**: 28 event types, 97 command types, 200+ callback functions, 1 client language (F#)

## Constitution Check

*GATE: Must pass before Phase 0 research. Re-check after Phase 1 design.*

| Principle | Pre-Design | Post-Design | Evidence |
|-----------|-----------|-------------|----------|
| I. Zero Engine Modifications | PASS | PASS | Standard SSkirmishAILibrary interface only; install as AI/Skirmish/HighBarV2/ |
| II. Binary Protocol First | PASS | PASS | protobuf + UDS wire format; no JSON/text on hot path |
| III. Correctness Over Cleverness | PASS | PASS | 1:1 struct-to-proto field mapping; optional fields for sentinel values |
| IV. Test at the Boundary | PASS | PASS | Round-trip serialization tests for all 28+97 types; mock engine harness |
| V. Latency Budget Discipline | PASS | PASS | Arena allocation, per-frame reset, non-blocking I/O with configurable timeout |
| VI. Language-Agnostic by Default | PASS | PASS | .proto schema is source of truth; thin typed wrappers per language |
| VII. Explicit Over Implicit | PASS | PASS | All config in AIOptions.lua with env var overrides; engine logger for all output |

**Performance & Safety Constraints**: All met — C proxy, single-threaded, non-blocking sockets, arena allocation, 8MB message cap (configurable, constitution default was 4MB — raised per clarification, still bounded and configurable), SIGPIPE handled.

**Development Workflow**: buf lint for protos, generated code not in VCS, CMake build, conventional commits.

## Project Structure

### Documentation (this feature)

```text
specs/001-native-proxy-bridge/
├── plan.md              # This file
├── spec.md              # Feature specification
├── research.md          # Phase 0: technology research
├── data-model.md        # Phase 1: entity & protocol model
├── quickstart.md        # Phase 1: developer quickstart guide
├── contracts/
│   ├── protocol.md      # IPC protocol contract
│   └── plugin-interface.md  # Engine plugin interface contract
└── tasks.md             # Phase 2 output (via /speckit.tasks)
```

### Source Code (repository root)

```text
proto/                           # Protocol buffer definitions (source of truth)
├── buf.yaml                     # buf module config + lint rules
├── buf.gen.yaml                 # Code generation config (C, C#, Python)
└── highbar/
    ├── common.proto             # Shared types: Vector3, UnitRef, etc.
    ├── events.proto             # 28 EngineEvent variants (oneof)
    ├── commands.proto           # 97 AICommand variants (oneof)
    ├── callbacks.proto          # CallbackRequest/Response + callback ID enum
    └── messages.proto           # Envelope: Handshake, Frame, FrameResponse, Shutdown, Save/Load

proxy/                           # C shared library (engine plugin)
├── CMakeLists.txt
├── data/
│   ├── AIInfo.lua               # Plugin metadata
│   └── AIOptions.lua            # Configurable options
├── include/highbar/
│   ├── proxy.h                  # Public: init/release/handleEvent
│   ├── connection.h             # Socket connection management
│   ├── serialize.h              # Event struct → protobuf
│   ├── deserialize.h            # Protobuf → command struct
│   ├── callbacks.h              # Callback query dispatch
│   ├── config.h                 # Configuration loading
│   └── arena.h                  # Per-frame bump allocator
├── src/
│   ├── proxy.c                  # Entry points + frame loop orchestration
│   ├── connection.c             # UDS/TCP connect, send, recv, timeout
│   ├── serialize.c              # All 28 event serializers
│   ├── deserialize.c            # All 97 command deserializers
│   ├── callbacks.c              # 200+ callback dispatch
│   ├── config.c                 # AIOptions + env var parsing
│   └── arena.c                  # Bump allocator impl
└── tests/
    ├── mock_engine.c            # Mock SSkirmishAICallback for testing
    ├── test_serialize.c         # Event serialization tests
    ├── test_deserialize.c       # Command deserialization tests
    ├── test_roundtrip.c         # Serialize→deserialize identity property tests
    └── test_connection.c        # Socket connection + timeout tests

clients/
├── fsharp/                      # F# client library
│   ├── HighBar.Client.fsproj
│   ├── src/
│   │   ├── Client.fs            # Connection management, frame loop
│   │   ├── Events.fs            # Discriminated union wrappers for events
│   │   └── Commands.fs          # Typed command builder functions
│   └── tests/
│       └── Tests.fsproj
└── python/                      # Python client library
    ├── pyproject.toml
    ├── highbar/
    │   ├── __init__.py
    │   ├── client.py            # Connection management, frame loop (sync + async)
    │   ├── events.py            # Typed event wrappers
    │   └── commands.py          # Typed command builders
    └── tests/

tools/
├── echo-ai/                     # Test AI that logs all events (F#)
└── replay/                      # P3: Session recording and playback
```

**Structure Decision**: Multi-component layout reflecting the three distinct build targets (C proxy, .NET client, Python client) with shared proto schema. Each component uses its language-native build system per constitution mandate (CMake, dotnet, pip). Proto schemas live at repo root as the single source of truth.

## Complexity Tracking

| Deviation | Why Needed | Simpler Alternative Rejected Because |
|-----------|------------|-------------------------------------|
| 8MB default message cap (constitution says 4MB) | Large BAR maps may produce heightmap callback responses approaching 4MB; 8MB provides safety margin | 4MB would require chunking large map data callbacks, adding protocol complexity for marginal memory savings |
