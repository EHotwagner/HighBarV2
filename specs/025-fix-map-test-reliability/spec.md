# Feature Specification: Fix Map Test Reliability

**Feature Branch**: `025-fix-map-test-reliability`  
**Created**: 2026-04-06  
**Status**: Draft  
**Input**: User description: "Fix map test reliability: add missing F# client map wrappers, replace silent skip patterns with real assertions, fix always-true assertions"

## User Scenarios & Testing *(mandatory)*

### User Story 1 - Complete F# Client Map Data Access (Priority: P1)

A developer using the HighBar F# client library needs access to all map data that the proxy already supports. Currently only 1 of 5 map data callbacks (HeightMap) has an F# wrapper, despite the proxy fully implementing slope map, LOS map, radar map, and resource map callbacks (IDs 53-56). The missing wrappers prevent both application code and tests from using this data.

**Why this priority**: This is the foundational blocker. Without client wrappers, map tests cannot query the data they need, and the silent-skip pattern persists by necessity.

**Independent Test**: Can be verified by calling each new method against a live engine and confirming non-empty, correctly-typed return values.

**Acceptance Scenarios**:

1. **Given** a connected HighBarClient with a running engine, **When** `GetSlopeMap()` is called, **Then** a non-empty float array is returned with values in range [0, 1]
2. **Given** a connected HighBarClient with a running engine, **When** `GetLosMap()` is called, **Then** a non-empty int array is returned
3. **Given** a connected HighBarClient with a running engine, **When** `GetRadarMap()` is called, **Then** a non-empty int array is returned
4. **Given** a connected HighBarClient with a running engine, **When** `GetResourceMap(0)` is called (metal), **Then** a non-empty int array is returned with non-negative values

---

### User Story 2 - Map Tests Validate Real Data (Priority: P2)

When persistent map tests run against a live engine, they should execute real assertions against actual map data. Currently all 4 tests in T9_MapTests silently skip when the callback fails, printing "SKIP:" to output but reporting as passed. Since the proxy now supports these callbacks, the tests should assert on real data.

**Why this priority**: The silent-skip pattern gives false confidence — CI reports 4/4 green while 0/4 actually validate anything. Replacing skips with real assertions catches regressions in map loading and query logic.

**Independent Test**: Run the persistent test suite against a live engine. All T9 map tests must execute their assertion branches (not the skip branches). The test output must show actual map data values, not SKIP messages.

**Acceptance Scenarios**:

1. **Given** a running engine with a loaded map, **When** T9.1 (Map dimensions) runs, **Then** it asserts width and height are positive integers
2. **Given** a running engine with a loaded map, **When** T9.2 (Height map) runs, **Then** it asserts the height map array is non-empty with values in a reasonable range
3. **Given** a running engine, **When** new slope/LOS/radar/resource map tests run, **Then** they assert on real data from the engine
4. **Given** the proxy does not support a callback (future regression), **When** a map test runs, **Then** it fails with a clear error message rather than silently passing

---

### User Story 3 - Always-True Assertions Are Meaningful (Priority: P3)

A test assertion that can never fail provides no value and masks regressions. The always-true assertion `Assert.True(losEvents.Length >= 0)` in EventTests should be replaced with a meaningful check, or removed if no meaningful assertion exists.

**Why this priority**: Lower impact than the map test issues — this is a single assertion in one test — but still a false-confidence problem worth fixing alongside the other reliability improvements.

**Independent Test**: Review the assertion and confirm it can actually fail when conditions are wrong.

**Acceptance Scenarios**:

1. **Given** the EventTests LOS event check, **When** reviewed, **Then** the assertion either validates a meaningful property or is removed with a comment explaining why LOS events are optional

---

### Edge Cases

- What happens when the engine returns an empty map data array (e.g., zero-size map)? Tests should fail with a clear message, not silently skip.
- What if the resource map callback is called with an invalid resource ID? The client wrapper should handle the error gracefully (return empty array, matching the existing pattern for other wrappers).
- What if map dimensions don't match expected array sizes (e.g., height map length != width * height)? Tests should validate array size consistency.

## Requirements *(mandatory)*

### Functional Requirements

- **FR-001**: The F# client library MUST expose a `GetSlopeMap()` method returning a float array from callback ID 53
- **FR-002**: The F# client library MUST expose a `GetLosMap()` method returning an int array from callback ID 54
- **FR-003**: The F# client library MUST expose a `GetRadarMap()` method returning an int array from callback ID 55
- **FR-004**: The F# client library MUST expose a `GetResourceMap(resourceId)` method returning an int array from callback ID 56, accepting a resource ID parameter (0=metal, 1=energy)
- **FR-005**: All new client methods MUST follow the same error-handling pattern as existing methods (return empty array on failure)
- **FR-006**: T9_MapTests MUST replace silent-skip branches with assertions that fail when the proxy doesn't return data, since the proxy now supports all map callbacks
- **FR-007**: T9_MapTests MUST include new test cases for slope map, LOS map, radar map, and resource map data
- **FR-008**: The always-true assertion `Assert.True(losEvents.Length >= 0)` in EventTests MUST be replaced with a meaningful assertion or removed
- **FR-009**: Map test array-size assertions MUST validate consistency with map dimensions (e.g., height map length matches width * height)

### Key Entities

- **Map Data Arrays**: Float arrays (height map, slope map) and int arrays (LOS map, radar map, resource map) returned by proxy callbacks 52-56
- **Callback IDs**: Proxy-defined identifiers (52-56) mapping to specific engine API calls for map data retrieval

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: All 5 map data types (height, slope, LOS, radar, resource) are queryable from the F# client library
- **SC-002**: All persistent map tests execute real assertions against live engine data — zero tests pass via silent skip
- **SC-003**: The persistent test suite reports accurate pass/fail status — a broken proxy callback causes a test failure, not a silent pass
- **SC-004**: No test assertion in the codebase is tautological (always true regardless of input)

## Assumptions

- The proxy correctly implements callbacks 52-56 as verified by existing CTest mock tests — no proxy-side changes are needed
- The protobuf schema already defines all necessary callback IDs and response types (FloatArray, IntArray) — no proto changes needed
- The persistent test harness can execute map callbacks within a running frame via the existing `queryInFrame` helper
- The `GetResourceMap` method needs a resource ID parameter (unlike slope/LOS/radar which take no parameters), matching the proxy's `get_int_param(request, 0, 0)` pattern
- The live test environment has a real map loaded with meaningful map data (non-trivial height variation, metal spots, etc.)
