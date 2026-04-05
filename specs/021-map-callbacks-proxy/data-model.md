# Data Model: 021-map-callbacks-proxy

**Date**: 2026-04-05

## Entities

### CallbackRequest (existing, unchanged)

Sent by the AI client to request data from the engine.

| Field | Type | Description |
|-------|------|-------------|
| request_id | uint32 | Unique request identifier |
| callback_id | enum CallbackId | Which callback to invoke (52-58 for map data) |
| params | CallbackParam[] | Optional parameters (e.g., resource ID for callback 56) |

### CallbackResponse (existing, unchanged)

Returned by the proxy after querying the engine.

| Field | Type | Description |
|-------|------|-------------|
| request_id | uint32 | Matches the request |
| success | bool | True if engine call succeeded |
| result | CallbackResult | Oneof containing the return value |
| error_message | string | Populated on failure |

### CallbackResult — New Value Types Used

| Value Case | Proto Type | Used By Callbacks |
|------------|-----------|-------------------|
| float_array_value | FloatArray | 52 (heightmap), 53 (slopemap), 58 (metal spots) |
| int_array_value | IntArray | 54 (LOS map), 55 (radar map), 56 (resource map) |
| vector_value | Vector3 | 57 (start position) |

### Map Data Array Dimensions

| Callback ID | Name | Element Type | Array Size Formula |
|-------------|------|-------------|-------------------|
| 52 | HeightMap | float | W × H |
| 53 | SlopeMap | float | (W/2) × (H/2) |
| 54 | LosMap | int32 | varies by mip level (upper bound: W × H) |
| 55 | RadarMap | int32 | varies by mip level (upper bound: W × H) |
| 56 | ResourceMap | int32 (widened from short) | (W/2) × (H/2) |

W = Map_getWidth(), H = Map_getHeight()

### Metal Spot (packed in FloatArray)

Callback 58 returns a FloatArray with 4 floats per spot:

| Offset | Field | Description |
|--------|-------|-------------|
| i*4 + 0 | x | World X coordinate |
| i*4 + 1 | y | World Y coordinate (elevation) |
| i*4 + 2 | z | World Z coordinate |
| i*4 + 3 | avgIncome | Average metal income per spot |

### Callback Parameters

| Callback ID | Parameter Index | Type | Description | Default |
|-------------|----------------|------|-------------|---------|
| 56 | 0 | int | Resource ID (0=metal, 1=energy) | 0 |

All other callbacks (52-55, 57-58) take no parameters.

## State Transitions

None — map data callbacks are stateless read-only queries. Each request is independent.

## Validation Rules

- Callback IDs 52-58 must match the proto enum values exactly.
- Array sizes must match engine-reported dimensions (not hardcoded).
- Resource ID for callback 56 must be passed through to engine without validation (engine handles unknown IDs).
- Null function pointers result in error response, not crash.
