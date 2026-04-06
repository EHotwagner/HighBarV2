# Feature Specification: Add Corners Heightmap Callback

**Feature Branch**: `026-corners-heightmap-callback`  
**Created**: 2026-04-06  
**Status**: Draft  
**Input**: User description: "Add a new CALLBACK_MAP_GET_CORNERS_HEIGHT_MAP callback to the proto and proxy, exposing the engine's native Map_getCornersHeightMap API. The center heightmap is a lossy convenience; the corners heightmap is ground truth."

## User Scenarios & Testing *(mandatory)*

### User Story 1 - AI Retrieves Corners Heightmap Data (Priority: P1)

An AI player requests the corners heightmap from the game engine through the proxy. The corners heightmap provides height values at the corners of each 8x8 grid square, yielding a (width+1) x (height+1) array of float values. This is the ground-truth elevation data that matches the rendered terrain, unlike the center heightmap which is a lossy approximation.

**Why this priority**: This is the core capability being added. Without it, AI players cannot access the precise terrain elevation data needed for accurate pathfinding, line-of-sight calculations, and terrain analysis. The corners heightmap is the authoritative elevation source used by the engine's own rendering.

**Independent Test**: Can be fully tested by sending a corners heightmap callback request through the proxy and verifying that the correct float array is returned with dimensions (width+1) x (height+1). Delivers immediate value by providing AI access to ground-truth elevation data.

**Acceptance Scenarios**:

1. **Given** a running game with a loaded map, **When** an AI sends a corners heightmap callback request, **Then** the proxy returns a float array of size (map_width+1) x (map_height+1) containing the terrain corner heights.
2. **Given** a running game with a loaded map, **When** an AI sends a corners heightmap callback request, **Then** the returned heights match the engine's native Map_getCornersHeightMap output exactly (no interpolation or transformation).
3. **Given** a running game, **When** an AI sends a corners heightmap callback request and the engine returns the data successfully, **Then** the response indicates success and contains a valid float array.

---

### User Story 2 - F# Client Exposes Corners Heightmap Method (Priority: P2)

An AI developer using the F# client library calls a dedicated method to retrieve the corners heightmap. The method follows the same pattern as the existing GetHeightMap() method, returning a float32 array. The developer does not need to know callback IDs or protocol details.

**Why this priority**: The F# client is the primary interface AI developers use. Exposing a clean API method makes the new data accessible without requiring protocol-level knowledge. Depends on US1 being complete.

**Independent Test**: Can be tested by calling the new client method against a live engine and verifying the returned array has the expected dimensions and contains valid height data.

**Acceptance Scenarios**:

1. **Given** a connected F# client, **When** the developer calls GetCornersHeightMap(), **Then** a float32 array of corner heights is returned.
2. **Given** a connected F# client, **When** the developer calls GetCornersHeightMap() and the engine is not available, **Then** an empty array is returned (graceful degradation, consistent with existing heightmap method behavior).

---

### User Story 3 - Proxy Handles Corners Heightmap Errors Gracefully (Priority: P3)

When the corners heightmap callback encounters an error condition (e.g., memory allocation failure, engine callback not available), the proxy returns an appropriate error response rather than crashing or hanging.

**Why this priority**: Error resilience is important for production stability but is secondary to core functionality. Follows the existing error handling patterns already established for the center heightmap callback.

**Independent Test**: Can be tested by simulating error conditions (null callback pointer, allocation failure) and verifying the proxy returns an error response without crashing.

**Acceptance Scenarios**:

1. **Given** a proxy where the corners heightmap engine callback is not available, **When** a corners heightmap request is received, **Then** the proxy returns a structured error response (not a crash).
2. **Given** a proxy under memory pressure, **When** a corners heightmap request triggers an allocation failure, **Then** the proxy returns an error response indicating the failure.

---

### Edge Cases

- What happens when the map dimensions are zero or negative? The proxy should handle this gracefully by returning an empty or error response.
- What happens if the corners heightmap data size exceeds the expected (width+1) x (height+1)? The proxy should use the returned count from the engine, capping at the allocated buffer size.
- What happens if the engine returns fewer values than expected? The proxy should return only the values actually written by the engine.

## Requirements *(mandatory)*

### Functional Requirements

- **FR-001**: The protocol MUST define a new callback identifier for retrieving the corners heightmap, distinct from the existing center heightmap callback.
- **FR-002**: The proxy MUST handle the corners heightmap callback by querying the engine's native corners heightmap API and returning the result as a float array.
- **FR-003**: The proxy MUST allocate a buffer of size (map_width+1) x (map_height+1) for the corners heightmap data, reflecting the correct dimensions for corner-based elevation.
- **FR-004**: The proxy MUST return a float array response containing the exact values from the engine with no interpolation or transformation.
- **FR-005**: The F# client library MUST expose a method for retrieving the corners heightmap that returns a float32 array.
- **FR-006**: The F# client MUST return an empty array when the corners heightmap request fails, consistent with existing heightmap method behavior.
- **FR-007**: The proxy MUST return an error response (not crash) when the engine corners heightmap callback is unavailable or memory allocation fails.
- **FR-008**: Mock-based proxy tests MUST verify the corners heightmap callback returns correct data with expected array dimensions.
- **FR-009**: Live engine integration tests MUST verify the corners heightmap callback works end-to-end against a real game engine.

### Key Entities

- **Corners Heightmap**: A 2D grid of float values representing terrain elevation at grid square corners. Dimensions are (map_width+1) x (map_height+1), one unit wider and taller than the center heightmap. Values are in row-major order (index = z * (width+1) + x), with index 0 at the top-left corner.
- **Center Heightmap** (existing): A 2D grid of float values representing terrain elevation at grid square centers. Dimensions are map_width x map_height. The corners heightmap supersedes this for precision-critical use cases.

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: AI players can retrieve corners heightmap data from the engine in a single callback request, with the response containing exactly (map_width+1) x (map_height+1) float values.
- **SC-002**: The corners heightmap values match the engine's ground-truth elevation data exactly (zero loss compared to the engine's native API).
- **SC-003**: All existing heightmap functionality continues to work unchanged (zero regressions in center heightmap, slope map, or other map callbacks).
- **SC-004**: F# client developers can access corners heightmap data through a single method call with no knowledge of protocol internals.
- **SC-005**: The proxy handles error conditions (unavailable callback, allocation failure) without crashing, returning structured error responses instead.

## Assumptions

- The engine's `Map_getCornersHeightMap` C++ API is stable and available in the current BAR engine version (v1.2988.0).
- The corners heightmap follows the same row-major ordering convention as the center heightmap (index 0 = top-left).
- The existing `FloatArray` protobuf message type is sufficient for transmitting corners heightmap data (no new message types needed).
- The existing proxy memory management pattern (malloc for raw buffers, arena for protobuf structs) is appropriate for corners heightmap data sizes.
- The next available callback ID in the protocol will be used; the specific numeric ID is an implementation detail.
- The corners heightmap callback requires no input parameters, consistent with the center heightmap callback pattern.
