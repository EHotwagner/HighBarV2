# Research: 021-map-callbacks-proxy

**Date**: 2026-04-05

## R1: Float Array Response Helper

**Decision**: Implement `make_float_array_response()` mirroring the existing `make_int_array_response()` pattern.

**Rationale**: The proto schema already defines `FloatArray` in `CallbackResult.float_array_value` (field 6), and the generated C types (`Highbar__FloatArray`) exist. The only missing piece is the C helper in `callbacks.c`. The existing `make_int_array_response()` (lines 80-104) provides the exact template — swap `int32_t` for `float`, `IntArray` for `FloatArray`, and the corresponding value_case enum.

**Alternatives considered**: None — this is a straightforward gap fill.

## R2: Memory Allocation Strategy for Bulk Map Data

**Decision**: Use `malloc` for raw engine data buffers; arena for protobuf response structures. Free raw buffers after `make_*_array_response` copies data into arena.

**Rationale**: The arena is 1MB (`ARENA_DEFAULT_CAPACITY` at `proxy/src/proxy.c:17`). Map data for medium maps (16x16) requires 4MB for heightmaps alone. The `make_*_array_response` helpers already `memcpy` data into arena-allocated protobuf arrays, so the source buffer can be safely freed after the helper returns. This avoids increasing the arena size (which wastes memory for small maps and non-map callbacks).

**Alternatives considered**:
- Increase arena to 16MB: Simpler but wastes memory for all frames, not just map queries. Rejected.
- Dynamically sized arena: Adds complexity to arena lifecycle. Rejected.

## R3: Max Message Size vs Large Map Data

**Decision**: Document that users must increase `max_message_size` (via `AIOptions.lua` or `HIGHBAR_MAX_MSG_SIZE` env var) for 32x32 maps. Default 8MB handles maps up to ~16x16.

**Rationale**: The current default max message size is 8MB (`proxy/src/config.c:12`), configurable up to 16MB. A 32x32 heightmap is ~16MB. Rather than changing the default (which affects all messages), document the configuration requirement for large maps. The proxy already enforces the limit in `connection.c:132` and `connection.c:173`.

**Alternatives considered**:
- Increase default to 16MB: Would work but violates constitution's 4MB default guidance. Rejected.
- Stream/chunk large arrays: Adds protocol complexity for a rare use case. Rejected.

## R4: Resource Map Short-to-Int Widening

**Decision**: Allocate a `short*` buffer via `malloc`, call engine, then widen to `int32_t*` in a loop before passing to `make_int_array_response`.

**Rationale**: The engine's `Map_getResourceMapRaw` returns `short*` but protobuf `IntArray` uses `int32`. The widening must happen before the protobuf helper copies data. Using `malloc` for both the short buffer and the widened int buffer avoids arena overflow.

**Alternatives considered**:
- Add a `make_short_array_response`: Would require proto schema changes. Rejected.
- Cast in place: Unsafe — different sizes. Rejected.

## R5: Metal Spots Encoding

**Decision**: Pack metal spot data as a `FloatArray` with 4 floats per spot: x, y, z, avgIncome.

**Rationale**: The F# client already expects this layout (`Client.fs` — `GetMetalSpots` iterates in steps of 4). The engine provides positions via `Map_getResourceMapSpotsPositions` (packed float[3]) and average income via `Map_getResourceMapSpotsAverageIncome`. Combining into float4 per spot keeps the response as a single array.

**Alternatives considered**:
- Separate position and income arrays: Would require two callback round-trips or a new proto message type. Rejected.

## R6: Null Function Pointer Handling

**Decision**: Check each engine function pointer before calling. If null, fall through to the existing "Callback not available" error at `callbacks.c:292`.

**Rationale**: The existing dispatch pattern already handles this — each case block checks `if (callback->FunctionName)` and falls through on `break` if null. The final `return make_error_response(req_id, "Callback not available", alloc)` at line 292 catches these.

**Alternatives considered**: None — follows existing pattern.

## R7: Test Arena Size

**Decision**: Keep test arena at 64KB (`proxy/tests/test_callbacks.c`). For map array tests, use small mock data (e.g., 4x4 grids = 16 elements).

**Rationale**: Tests don't need real map sizes. Small arrays verify correctness of dispatch, allocation, copying, and response structure. Large-map memory behavior is an integration concern tested via live engine tests.

**Alternatives considered**:
- Large test arena: Unnecessary for correctness testing. Rejected.
