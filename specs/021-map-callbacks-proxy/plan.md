# Implementation Plan: Map Data Callbacks & Proxy Protocol Fixes

**Branch**: `021-map-callbacks-proxy` | **Date**: 2026-04-05 | **Spec**: [spec.md](spec.md)
**Input**: Feature specification from `/specs/021-map-callbacks-proxy/spec.md`

## Summary

Implement proxy-side handlers for map data callbacks (IDs 52-58) that are defined in `callbacks.proto` but missing from the C dispatch in `callbacks.c`. This adds a `make_float_array_response` helper, 7 new case handlers for heightmap/slopemap/LOS/radar/resource map/start position/metal spots, and uses `malloc` for bulk data buffers to avoid arena overflow on large maps. Includes mock engine implementations and C test cases for all new handlers. Frame-interleaving issue documented only (no proxy fix).

## Technical Context

**Language/Version**: C11  
**Primary Dependencies**: protobuf-c, engine SSkirmishAICallback API  
**Storage**: N/A  
**Testing**: CTest / CMake, mock engine harness  
**Target Platform**: Linux `.so` (Recoil engine AI plugin)  
**Project Type**: Shared library (engine plugin)  
**Performance Goals**: < 100us per callback dispatch (arena allocation, memcpy)  
**Constraints**: Arena is 1MB; bulk map data allocated via `malloc` and freed after protobuf copy. Max message size is 8MB default (configurable to 16MB for large maps).  
**Scale/Scope**: 7 new callback handlers, 1 new helper function, ~200 lines of C in callbacks.c, ~150 lines in tests

## Constitution Check

*GATE: Must pass before Phase 0 research. Re-check after Phase 1 design.*

| Principle | Status | Notes |
|-----------|--------|-------|
| I. Zero Engine Modifications | PASS | Uses standard SSkirmishAICallback function pointers only |
| II. Binary Protocol First | PASS | All data flows through protobuf CallbackRequest/Response |
| III. Correctness Over Cleverness | PASS | 1:1 mapping from engine arrays to proto arrays; short→int widening is explicit |
| IV. Test at the Boundary | PASS | Tests exercise dispatch boundary: request → engine mock → response validation |
| V. Latency Budget Discipline | PASS | malloc for bulk data is outside hot path (map queries are init-time, not per-frame); arena used for protobuf structures |
| VI. Language-Agnostic by Default | PASS | No client-side changes; proto schema unchanged; any language client can use IDs 52-58 |
| VII. Explicit Over Implicit | PASS | Null function pointers produce explicit error responses; resource ID is an explicit parameter |
| Performance & Safety | PASS | malloc buffers freed immediately after memcpy; no arena overflow; SIGPIPE handling unchanged |
| Development Workflow | PASS | No proto changes needed; conventional commits; CTest integration |

**Post-Phase 1 Re-check**: All principles still satisfied. malloc usage for bulk data is justified by arena size constraints and documented in research.md (R2).

## Project Structure

### Documentation (this feature)

```text
specs/021-map-callbacks-proxy/
├── plan.md              # This file
├── research.md          # Phase 0 output — allocation strategy, encoding decisions
├── data-model.md        # Phase 1 output — callback data shapes and dimensions
├── quickstart.md        # Phase 1 output — build/test commands
└── tasks.md             # Phase 2 output (created by /speckit.tasks)
```

### Source Code (repository root)

```text
proxy/
├── src/
│   └── callbacks.c          # ADD: make_float_array_response helper + 7 case handlers
├── include/
│   └── AI/
│       └── SSkirmishAICallback.h  # READ-ONLY: engine function pointer signatures
└── tests/
    ├── mock_engine.c        # ADD: mock Map_getHeightMap, Map_getSlopeMap, etc.
    ├── mock_engine.h        # ADD: declare new mock config functions
    └── test_callbacks.c     # ADD: 7+ test cases for new callbacks

docs/
└── known-issues.md          # ADD: frame-interleaving issue documentation
```

**Structure Decision**: All changes are within the existing proxy directory structure. No new directories or projects needed.

## Complexity Tracking

No constitution violations to justify.
