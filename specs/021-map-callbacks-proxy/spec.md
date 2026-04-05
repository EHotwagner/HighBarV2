# Feature Specification: Map Data Callbacks & Proxy Protocol Fixes

**Feature Branch**: `021-map-callbacks-proxy`  
**Created**: 2026-04-05  
**Status**: Draft  
**Input**: Mailbox item 004 — Missing map data callbacks (IDs 52-58) and protocol frame-interleaving issue

## Clarifications

### Session 2026-04-05

- Q: Should the proxy-side frame interleaving fix (Story 5) be in scope, or descoped to documentation? → A: Descope to documentation-only. Document the known issue and client workaround; defer the proxy-side protocol fix to a future feature.

## User Scenarios & Testing *(mandatory)*

### User Story 1 - AI Reads Map Terrain Data (Priority: P1)

An AI developer builds a bot that needs to analyze the game map's terrain — height values, slope gradients, and resource density — to make strategic decisions (e.g., where to build, which paths are passable). The AI requests this data through the proxy during gameplay and receives accurate, complete arrays matching the actual map.

**Why this priority**: Without terrain data, AI bots cannot make any map-aware decisions. This is the foundational capability that all map-based AI features depend on.

**Independent Test**: Can be tested by requesting each map data type (heightmap, slopemap, resource map) through the proxy during a live game session and verifying the returned arrays have the correct dimensions and contain non-default values.

**Acceptance Scenarios**:

1. **Given** a running game on any map size, **When** the AI requests the heightmap, **Then** the proxy returns a float array whose length equals map width multiplied by map height, containing actual terrain elevation values.
2. **Given** a running game on any map size, **When** the AI requests the slope map, **Then** the proxy returns a float array whose length equals (width/2) * (height/2), containing slope gradient values.
3. **Given** a running game on a map with metal deposits, **When** the AI requests the resource map for metal, **Then** the proxy returns an integer array of (width/2) * (height/2) values representing metal density at each grid cell.
4. **Given** a running game on a map with metal deposits, **When** the AI requests the resource map for energy, **Then** the proxy returns the energy density array using resource ID 1.

---

### User Story 2 - AI Reads Visibility and Radar Data (Priority: P1)

An AI developer builds a bot that needs to know which areas of the map are currently visible (line-of-sight) and which are covered by radar. The AI queries this data each frame or on demand to make tactical decisions about scouting, attacking, or defending.

**Why this priority**: LOS and radar data are critical for any tactical AI — without them the bot is effectively blind to fog of war.

**Independent Test**: Can be tested by requesting LOS map and radar map through the proxy during a live game and verifying the returned arrays contain non-zero values in areas where the AI has units with vision or radar.

**Acceptance Scenarios**:

1. **Given** a running game where the AI has units on the map, **When** the AI requests the LOS map, **Then** the proxy returns an integer array with non-zero values in areas covered by the AI's unit vision.
2. **Given** a running game where the AI has radar-equipped units, **When** the AI requests the radar map, **Then** the proxy returns an integer array with non-zero values in areas covered by radar.
3. **Given** a running game, **When** the AI requests the LOS or radar map, **Then** the returned array size matches the engine's mip-level-dependent resolution (not necessarily full map resolution).

---

### User Story 3 - AI Queries Start Position and Metal Spots (Priority: P1)

An AI developer needs to know where its team starts on the map and where metal extraction points are located so it can begin building immediately. The AI queries these during initialization and receives correct coordinates.

**Why this priority**: Start position and metal spot locations are essential for any AI's opening build order. Without them, the AI cannot plan its economy.

**Independent Test**: Can be tested by querying start position and metal spots during game initialization and verifying the start position is a valid map coordinate and metal spots are non-empty on maps known to have metal deposits.

**Acceptance Scenarios**:

1. **Given** a running game, **When** the AI requests its start position, **Then** the proxy returns a 3D coordinate (x, y, z) that matches the AI's actual spawn location on the map.
2. **Given** a running game on a map with metal deposits, **When** the AI requests metal spot positions, **Then** the proxy returns a list of 3D coordinates with associated income values, and the list is non-empty.
3. **Given** a running game on a map with no metal deposits, **When** the AI requests metal spot positions, **Then** the proxy returns an empty list (not an error).

---

### User Story 4 - AI Queries Map Data on Large Maps Without Crashes (Priority: P2)

An AI developer runs their bot on large maps (up to 32x32 SMU). When the AI requests bulk map data such as the full heightmap, the proxy handles the large data transfer without crashing or returning truncated results.

**Why this priority**: Large maps produce arrays up to 16 MB. If the proxy cannot handle these, AI developers are limited to small maps only.

**Independent Test**: Can be tested by running a game on the largest supported map size and requesting all map data types, verifying complete arrays are returned without proxy crashes or memory errors.

**Acceptance Scenarios**:

1. **Given** a game running on a 16x16 map (1M floats heightmap), **When** the AI requests the heightmap, **Then** the proxy returns the complete array without truncation or crash.
2. **Given** a game running on a 32x32 map (4M floats heightmap), **When** the AI requests any map data type, **Then** the proxy returns the complete array without memory allocation failures.
3. **Given** a game running on a small 8x8 map, **When** the AI requests map data, **Then** the proxy does not waste excessive memory on the allocation.

---

### User Story 5 - Frame Interleaving Issue Documented (Priority: P3, Documentation Only)

A developer reviewing the proxy protocol understands the known frame-interleaving issue during callback sequences and the existing client-side workaround, so they can account for it when building AI clients.

**Why this priority**: The client-side workaround is already deployed and functional. A proxy-side protocol fix is higher risk and deferred to a future feature. This story ensures the issue is documented for awareness.

**Independent Test**: Can be verified by checking that the known issue and workaround are documented in the project's known-issues documentation.

**Acceptance Scenarios**:

1. **Given** a developer reading the project documentation, **When** they look up known protocol issues, **Then** they find a description of the frame-interleaving issue during callback sequences and the recommended client-side workaround pattern.

---

### Edge Cases

- What happens when the AI requests a map data callback on a map with unusual dimensions (e.g., non-square maps)?
- How does the proxy handle a callback request for a map type that the engine does not support (null function pointer)?
- What happens when the AI sends an invalid resource ID (not 0 or 1) for the resource map callback?
- How does the proxy behave if the engine returns 0 or a negative count from a map data function?

## Requirements *(mandatory)*

### Functional Requirements

- **FR-001**: The proxy MUST handle callback IDs 52-56 (heightmap, slopemap, LOS map, radar map, resource map) and return the correct data arrays from the engine.
- **FR-002**: The proxy MUST handle callback ID 57 (start position) and return the AI's spawn coordinates as a 3D vector.
- **FR-003**: The proxy MUST handle callback ID 58 (metal spots) and return an array of spot positions with associated income values.
- **FR-004**: The proxy MUST support float array responses for callbacks that return floating-point data (heightmap, slopemap, metal spots).
- **FR-005**: The proxy MUST correctly widen short integer data to 32-bit integers when the engine returns short arrays (resource map).
- **FR-006**: The proxy MUST handle bulk data transfers for map arrays up to 16 MB without memory allocation failures or crashes.
- **FR-007**: The proxy MUST return an explicit error response when a requested callback's engine function pointer is null.
- **FR-008**: The proxy MUST return empty arrays (not errors) when the engine returns zero-length results for map data queries.
- **FR-009**: The proxy MUST include test coverage for all new callback handlers, including mock engine implementations.

### Key Entities

- **Map Data Array**: A one-dimensional array of values (float or int) representing a 2D grid of map data at a specific resolution. Dimensions depend on map size and data type.
- **Start Position**: A 3D coordinate (x, y, z) representing where a team spawns on the map.
- **Metal Spot**: A location on the map where resources can be extracted, represented as a 3D coordinate with an associated average income value.
- **Callback**: A request-response message pair where the AI client asks the proxy to query the game engine for specific data.

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: All 7 new callback types (IDs 52-58) return correct, non-default data when queried during a live game session.
- **SC-002**: Existing F# client test suites that currently skip due to missing callbacks begin passing with real data assertions.
- **SC-003**: Map data queries succeed on maps of all supported sizes (8x8, 16x16, 32x32 SMU) without proxy crashes or truncated results.
- **SC-004**: The proxy's C test suite includes test cases for all 7 new callback handlers, and all tests pass.
- **SC-005**: The frame-interleaving issue and client-side workaround are documented in the project's known-issues reference.

## Assumptions

- The engine's callback function pointers for map data are available and functional in the BAR engine version used for testing.
- Map dimensions returned by Map_getWidth and Map_getHeight are reliable and can be used to calculate buffer sizes.
- The F# client's existing extraction helpers will correctly parse the new response types once the proxy returns them — no client-side changes are needed for basic functionality.
- The maximum practical map size is 32x32 SMU (2048x2048 heightmap squares), producing arrays up to approximately 16 MB.
- The resource map callback uses resource ID 0 for metal and 1 for energy, matching engine conventions.
- The frame-interleaving issue is out of scope for this feature. The existing client-side workaround is sufficient. A proxy-side protocol fix will be addressed in a future feature.
- LOS and radar map callbacks (IDs 54-55) are expected to be queried infrequently (at most once per second, not per frame). AI clients that need per-frame visibility data should cache the result client-side. This justifies using malloc for bulk data buffers in these callbacks without violating the latency budget.
