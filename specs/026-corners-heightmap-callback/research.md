# Research: 026-corners-heightmap-callback

**Date**: 2026-04-06

## Research Tasks

### RT-1: Callback ID Assignment

**Decision**: Use callback ID `59` for `CALLBACK_MAP_GET_CORNERS_HEIGHT_MAP`.

**Rationale**: The map callback range spans IDs 50-58. The next sequential ID is 59. No gaps exist in the range. The highest ID in the file is 110 (`CALLBACK_INFO_GET_VALUE_BY_KEY`), but map callbacks are grouped in the 50s block.

**Alternatives considered**:
- Placing it at a higher ID range (e.g., 110+) — rejected because it breaks the logical grouping of map callbacks.
- Using a gap elsewhere — none exists in the map range.

### RT-2: Engine API Availability

**Decision**: The engine already exposes `Map_getCornersHeightMap` in the `SSkirmishAICallback` function table (`proxy/include/AI/SSkirmishAICallback.h:1554`).

**Rationale**: The function pointer signature is `int (CALLING_CONV *Map_getCornersHeightMap)(int skirmishAIId, float* cornerHeights, int cornerHeights_sizeMax)`. It returns the count of values written. Array size is `(Map_getWidth() + 1) * (Map_getHeight() + 1)`.

**Alternatives considered**: None — the engine API is a fixed interface. No workaround needed.

### RT-3: Buffer Size Calculation

**Decision**: Allocate `(w + 1) * (h + 1) * sizeof(float)` bytes for the corners heightmap buffer.

**Rationale**: The engine documentation states corners heightmap is "one unit wider and one unit higher" than the center heightmap. For a 4×4 map, center = 16 floats, corners = 25 floats. The existing heightmap handler (`callbacks.c:198-211`) allocates `w * h`; the new handler must use `(w+1) * (h+1)`.

**Alternatives considered**:
- Using the center heightmap size — rejected because it would truncate corner data.
- Querying the engine for the exact count first — rejected because the size formula is documented and deterministic.

### RT-4: Existing Pattern Reuse

**Decision**: Follow the exact pattern of `CALLBACK_MAP_GET_HEIGHT_MAP` (callbacks.c:198-211) with only the buffer size formula changed.

**Rationale**: The proxy uses a consistent handler pattern for all map data callbacks:
1. Check callback function pointers exist.
2. Query map dimensions via `Map_getWidth()` / `Map_getHeight()`.
3. Malloc a raw buffer for the data.
4. Call the engine callback to fill the buffer.
5. Create a protobuf `FloatArray` response via `make_float_array_response()`.
6. Free the malloc'd buffer.

This pattern is well-tested and handles memory management correctly (malloc for raw data, arena for protobuf structs).

**Alternatives considered**:
- Arena allocation for the raw buffer — rejected because large map data can exceed the 1MB arena (documented concern in existing code).
- A new helper function — rejected because the pattern is identical and adding abstraction for two call sites is premature.

### RT-5: Protobuf Message Type

**Decision**: Reuse existing `FloatArray` message type (`callbacks.proto:46-48`). No new message types needed.

**Rationale**: The corners heightmap is a flat array of floats, identical in structure to the center heightmap. The `CallbackResult.float_array_value` oneof field supports this directly.

**Alternatives considered**:
- A new `CornersHeightMap` message with width/height metadata — rejected per Constitution III (Correctness Over Cleverness) and VI (Language-Agnostic). The raw float array maps 1:1 to the engine output. Clients can derive dimensions from `Map_getWidth` / `Map_getHeight`.

### RT-6: F# Client Method Design

**Decision**: Add `GetCornersHeightMap() : float32 array` following the `GetHeightMap()` pattern (Client.fs:270-274).

**Rationale**: The existing pattern is simple, consistent, and handles errors gracefully (returns empty array on failure). The auto-generated `CallbackId` enum in C# will automatically include the new callback ID after `buf generate`.

**Alternatives considered**:
- Returning a 2D array — rejected because all existing map methods return flat arrays. Dimension awareness is the caller's responsibility.
- Throwing on failure — rejected because existing methods use graceful degradation (empty array).

### RT-7: Test Strategy

**Decision**: Add both mock-based proxy tests (CTest) and live engine integration tests (F# xUnit).

**Rationale**:
- Mock tests (`test_callbacks.c`): Fast feedback during development. Use a 4×4 mock map → 5×5 = 25 corner values. Follow the `test_get_height_map` pattern.
- Live engine tests (`T9_MapTests.fs`): Authoritative validation against real engine. Follow the heightmap test pattern (range checking, non-empty verification).
- Per Constitution IV (Test at the Boundary), serialization round-trip tests are highest priority.

**Alternatives considered**:
- Mock-only testing — rejected per project testing philosophy: "Prefer live engine tests over mocks wherever possible."
- Live-only testing — rejected because mock tests provide fast CI feedback without engine dependency.
