# Contract: Corners Heightmap Callback Protocol

**Date**: 2026-04-06

## Protocol Contract

The corners heightmap callback follows the existing callback request/response protocol over Unix domain sockets with protobuf serialization.

### Request

| Field | Type | Value |
|-------|------|-------|
| request_id | uint32 | Caller-assigned unique ID |
| callback_id | uint32 | 59 (CALLBACK_MAP_GET_CORNERS_HEIGHT_MAP) |
| params | repeated CallbackParam | Empty (no parameters required) |

### Response (success)

| Field | Type | Value |
|-------|------|-------|
| request_id | uint32 | Echoed from request |
| success | bool | true |
| result.float_array_value.values | repeated float | Corner height values, (width+1)×(height+1) elements |

### Response (error)

| Field | Type | Value |
|-------|------|-------|
| request_id | uint32 | Echoed from request |
| success | bool | false |
| error_message | string | Human-readable error description |

### Behavioral Contract

1. The callback takes no parameters.
2. The returned float array contains exactly `(Map_getWidth() + 1) * (Map_getHeight() + 1)` elements on success.
3. Values are in row-major order: `index = z * (width + 1) + x`, where index 0 is the top-left corner.
4. Values are the engine's raw corner heights with no interpolation or transformation applied.
5. If the engine callback is unavailable, the proxy returns an error response (never crashes).
6. If memory allocation fails, the proxy returns an error response.

## F# Client API Contract

### Method Signature

```
GetCornersHeightMap() : float32 array
```

### Behavior

- Returns a `float32 array` of corner heights on success.
- Returns an empty array (`[||]`) on failure (connection error, engine unavailable, callback unsupported).
- Does not throw exceptions for callback failures (consistent with `GetHeightMap()` behavior).
