# Data Model: 026-corners-heightmap-callback

**Date**: 2026-04-06

## Entities

### CornersHeightMap (new)

A flat array of 32-bit floating-point values representing terrain elevation at grid square corners.

| Attribute | Type | Description |
|-----------|------|-------------|
| values | float[] | Height values at each grid corner |
| dimensions | (width+1) × (height+1) | One wider and taller than center heightmap |
| ordering | row-major | index = z × (width+1) + x; index 0 = top-left |
| origin | top-left corner | z increases downward, x increases rightward |

**Relationship to existing entities**:
- Derived from `Map_getWidth()` and `Map_getHeight()` (same dimensions source as center heightmap).
- Superset of center heightmap: corner values can derive center values, but not vice versa.
- Uses same `FloatArray` protobuf container as center heightmap, slope map.

### CallbackId Enum (extended)

| Value | ID | Status |
|-------|----|--------|
| CALLBACK_MAP_GET_WIDTH | 50 | Existing |
| CALLBACK_MAP_GET_HEIGHT | 51 | Existing |
| CALLBACK_MAP_GET_HEIGHT_MAP | 52 | Existing |
| CALLBACK_MAP_GET_SLOPE_MAP | 53 | Existing |
| CALLBACK_MAP_GET_LOS_MAP | 54 | Existing |
| CALLBACK_MAP_GET_RADAR_MAP | 55 | Existing |
| CALLBACK_MAP_GET_RESOURCE_MAP | 56 | Existing |
| CALLBACK_MAP_GET_START_POS | 57 | Existing |
| CALLBACK_MAP_GET_METAL_SPOTS | 58 | Existing |
| CALLBACK_MAP_GET_CORNERS_HEIGHT_MAP | 59 | **New** |

### State Transitions

None. The corners heightmap is read-only terrain data queried on demand. No state machine involved.
