# Implementation Plan: Add Corners Heightmap Callback

**Branch**: `026-corners-heightmap-callback` | **Date**: 2026-04-06 | **Spec**: [spec.md](spec.md)
**Input**: Feature specification from `/specs/026-corners-heightmap-callback/spec.md`

## Summary

Add `CALLBACK_MAP_GET_CORNERS_HEIGHT_MAP` (ID 59) to the HighBar protocol and proxy, exposing the engine's native `Map_getCornersHeightMap` API. The implementation follows the established pattern for `CALLBACK_MAP_GET_HEIGHT_MAP` (ID 52) with the key difference being buffer size: `(width+1) × (height+1)` instead of `width × height`. Includes F# client method, mock-based proxy tests, and live engine integration tests.

## Technical Context

**Language/Version**: C11 (proxy), F# / .NET 10.0 (client, tests), Protobuf (proto schema)
**Primary Dependencies**: protobuf-c (C proxy), Google.Protobuf 3.28 (F# client), buf CLI (proto linting/codegen)
**Storage**: N/A (read-only engine query, no persistence)
**Testing**: CTest/CMake (C proxy tests), xUnit 2.9.x (F# integration tests), spring-headless (live engine)
**Target Platform**: Linux (primary), cross-platform via protobuf schema
**Project Type**: Library (proxy shared library + F# client library)
**Performance Goals**: < 100us serialization overhead per callback (within existing latency budget)
**Constraints**: No heap allocation in steady-state hot path (malloc for initial data fetch is acceptable as it follows established pattern); arena allocation for protobuf structs
**Scale/Scope**: Single new callback ID, ~50 lines of C, ~5 lines of F#, ~80 lines of tests

## Constitution Check

*GATE: Must pass before Phase 0 research. Re-check after Phase 1 design.*

| Principle | Status | Notes |
|-----------|--------|-------|
| I. Zero Engine Modifications | PASS | Uses existing `Map_getCornersHeightMap` from `SSkirmishAICallback` function table. No engine changes. |
| II. Binary Protocol First | PASS | All data flows through protobuf over Unix domain sockets. No JSON or text on hot path. |
| III. Correctness Over Cleverness | PASS | 1:1 mapping of engine data to protobuf `FloatArray`. No transformations, no interpolation, no lossy mappings. |
| IV. Test at the Boundary | PASS | Tests cover serialization boundary (engine struct → protobuf → wire → client). Mock proxy tests + live engine integration tests. |
| V. Latency Budget Discipline | PASS | Follows existing `malloc` + `make_float_array_response` pattern. Arena allocation for protobuf structs. Single callback per request. |
| VI. Language-Agnostic by Default | PASS | New callback defined in `.proto` schema. F# client adds only a thin typed wrapper. No protocol-level behavior changes. |
| VII. Explicit Over Implicit | PASS | New callback ID explicitly defined in proto enum. No magic defaults. Follows existing naming convention. |

**Gate result**: ALL PASS. No violations to justify.

### Post-Phase 1 Re-Check

| Principle | Status | Notes |
|-----------|--------|-------|
| I. Zero Engine Modifications | PASS | No changes to design. |
| II. Binary Protocol First | PASS | Reuses existing `FloatArray` message type. |
| III. Correctness Over Cleverness | PASS | Raw float array maps 1:1 to engine output. No metadata wrapper. |
| IV. Test at the Boundary | PASS | Mock tests validate serialization; live tests validate end-to-end. |
| V. Latency Budget Discipline | PASS | Same allocation pattern as existing heightmap. |
| VI. Language-Agnostic by Default | PASS | Schema is the contract. F# method is a thin wrapper. |
| VII. Explicit Over Implicit | PASS | Callback ID 59, explicit enum name, documented dimensions. |

## Project Structure

### Documentation (this feature)

```text
specs/026-corners-heightmap-callback/
├── plan.md              # This file
├── spec.md              # Feature specification
├── research.md          # Phase 0 research findings
├── data-model.md        # Entity definitions
├── quickstart.md        # Build/test quickstart guide
├── contracts/
│   └── callback-protocol.md  # Protocol contract
├── checklists/
│   └── requirements.md       # Spec quality checklist
└── tasks.md             # Phase 2 output (created by /speckit.tasks)
```

### Source Code (repository root)

```text
proto/highbar/
└── callbacks.proto          # Add CALLBACK_MAP_GET_CORNERS_HEIGHT_MAP = 59

proxy/src/
└── callbacks.c              # Add case handler in hb_callback_dispatch()

proxy/tests/
├── mock_engine.c            # Add mock corners heightmap data + function
└── test_callbacks.c         # Add test_get_corners_height_map

clients/fsharp/src/
└── Client.fs                # Add GetCornersHeightMap() method

tests/persistent/fsharp/
└── T9_MapTests.fs           # Add corners heightmap integration test
```

**Structure Decision**: No new files or directories. All changes are additions to existing files following established patterns.

## Complexity Tracking

> No violations to justify. All constitution gates pass.

## Implementation Phases

### Phase 1: Protocol Definition

1. Add `CALLBACK_MAP_GET_CORNERS_HEIGHT_MAP = 59` to the `CallbackId` enum in `proto/highbar/callbacks.proto` (after line 104, `CALLBACK_MAP_GET_METAL_SPOTS = 58`).
2. Run `buf lint` to validate.
3. Run `buf generate` to regenerate C and C# bindings.

### Phase 2: Proxy Handler

1. Add a new case in the `hb_callback_dispatch()` switch statement in `proxy/src/callbacks.c` (after the existing `CALLBACK_MAP_GET_HEIGHT_MAP` handler at line ~211).
2. The handler:
   - Checks `callback->Map_getCornersHeightMap`, `callback->Map_getWidth`, `callback->Map_getHeight`.
   - Gets dimensions: `w = Map_getWidth()`, `h = Map_getHeight()`.
   - Allocates buffer: `(w + 1) * (h + 1) * sizeof(float)`.
   - Calls `callback->Map_getCornersHeightMap(skirmishAIId, buffer, array_size)`.
   - Returns `make_float_array_response()`.
   - Frees buffer.

### Phase 3: Mock Engine & Proxy Tests

1. In `proxy/tests/mock_engine.c`:
   - Add `mock_corners_heightmap[25]` static array (5×5 for a 4×4 map).
   - Add `mock_map_get_corners_height_map()` function following the `mock_map_get_height_map` pattern.
   - Register in `mock_engine_create()`.
2. In `proxy/tests/test_callbacks.c`:
   - Add `test_get_corners_height_map` test:
     - Set map size to 4×4.
     - Send callback request with ID 59.
     - Assert `n_values == 25` (5×5).
     - Assert sample values match mock data.

### Phase 4: F# Client Method

1. In `clients/fsharp/src/Client.fs`:
   - Add `GetCornersHeightMap() : float32 array` method after `GetHeightMap()`.
   - Uses `CallbackId.CallbackMapGetCornersHeightMap` (auto-generated from proto).
   - Same response parsing pattern as `GetHeightMap()`.

### Phase 5: Live Engine Integration Tests

1. In `tests/persistent/fsharp/T9_MapTests.fs`:
   - Add a corners heightmap test following the existing height map test pattern.
   - Verify array is non-empty.
   - Verify array length is `(width+1) * (height+1)` (query dimensions first).
   - Verify values are in valid range (> -5000, < 50000).

### Phase 6: Build & Validate

1. Build proxy: `cmake -B build -DCMAKE_BUILD_TYPE=Release proxy/ && cmake --build build`
2. Run C tests: `cd build && ctest`
3. Build F# client: `cd clients/fsharp && dotnet build`
4. Run live engine tests: `./tests/run-all.sh --category persistent`
5. Verify no regressions in existing heightmap tests.
