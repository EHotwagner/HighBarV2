# Feature Specification: Extract and Save Map Data from Headless Test

**Feature Branch**: `027-extract-save-map-data`  
**Created**: 2026-04-06  
**Status**: Draft  
**Input**: User description: "run a headless test and actually extract and save map data. you MUST check that the data is not actually null. are maps already downloaded?"

## User Scenarios & Testing *(mandatory)*

### User Story 1 - Extract and Validate All Map Data Types (Priority: P1)

A developer runs a headless engine test against a real map and the system extracts every available map data type (heightmap, corners heightmap, slope map, LOS map, radar map, resource map, start positions, metal spots, map dimensions). Each data result is validated to be non-null and non-empty before proceeding.

**Why this priority**: This is the core purpose of the feature — proving that the proxy and client can retrieve real map data from a live engine, not just pass mock-based unit tests. Without verified extraction, all downstream uses of map data are untrustworthy.

**Independent Test**: Can be fully tested by launching a headless engine with any downloaded map, connecting the AI client, issuing all map data queries, and asserting each result is populated with valid data.

**Acceptance Scenarios**:

1. **Given** the headless engine is running with a known map loaded, **When** the AI client queries map dimensions, **Then** both width and height are positive integers greater than zero.
2. **Given** the headless engine is running, **When** the AI client queries the heightmap, **Then** the returned array is non-empty and has exactly width × height elements.
3. **Given** the headless engine is running, **When** the AI client queries the corners heightmap, **Then** the returned array is non-empty and has exactly (width+1) × (height+1) elements.
4. **Given** the headless engine is running, **When** the AI client queries the slope map, **Then** the returned array is non-empty and all values fall within the [0, 1] range.
5. **Given** the headless engine is running, **When** the AI client queries metal spots, **Then** at least one metal spot is returned with valid coordinates and positive income.
6. **Given** the headless engine is running, **When** the AI client queries the start position, **Then** coordinates are within map bounds.

---

### User Story 2 - Save Extracted Map Data to Disk (Priority: P2)

After successful extraction and validation, the system persists all map data to files on disk so that the data can be inspected, compared across runs, or used for offline analysis.

**Why this priority**: Saving data proves the extraction pipeline works end-to-end and provides artifacts for debugging and regression testing. It depends on Story 1 succeeding first.

**Independent Test**: Can be tested by running the extraction, then checking that output files exist on disk, are non-empty, and contain parseable data matching expected dimensions.

**Acceptance Scenarios**:

1. **Given** all map data has been successfully extracted, **When** the save operation completes, **Then** output files exist in a designated output directory.
2. **Given** map data has been saved, **When** the output files are read back, **Then** the data dimensions and value ranges match what was extracted.
3. **Given** a save operation is attempted, **When** the output directory does not exist, **Then** the system creates it automatically.

---

### User Story 3 - Report Extraction Results (Priority: P3)

After extraction and save, the system produces a summary report indicating which data types were successfully extracted, their sizes, and any that failed validation.

**Why this priority**: A summary report makes it easy to verify results at a glance without manually inspecting each file.

**Independent Test**: Can be tested by running the full pipeline and verifying the report contains entries for all expected data types with correct sizes.

**Acceptance Scenarios**:

1. **Given** extraction and save have completed, **When** the summary is generated, **Then** it lists every map data type with its extraction status (success/fail), element count, and file path.
2. **Given** one data type fails extraction, **When** the summary is generated, **Then** that data type is marked as failed with the reason.

---

### Edge Cases

- What happens when a map callback is not supported by the engine version? The test should report it as unsupported rather than failing the entire run.
- What happens when the engine returns a zero-length array for a data type? The test must treat this as a failure (data is effectively null/empty).
- What happens when the heightmap contains only zero values? This should be flagged as suspicious but not necessarily a failure (some flat maps may legitimately have uniform elevation).
- What happens when the headless engine crashes mid-extraction? The test should fail with a clear error indicating which data types were already extracted and which were not.

## Requirements *(mandatory)*

### Functional Requirements

- **FR-001**: System MUST launch a headless engine instance with a real downloaded map.
- **FR-002**: System MUST connect an AI client to the running engine and establish a working callback channel.
- **FR-003**: System MUST query all available map data types: dimensions (width, height), heightmap, corners heightmap, slope map, LOS map, radar map, resource map (metal), start positions, and metal spots.
- **FR-004**: System MUST validate each returned data set is non-null and non-empty before considering extraction successful.
- **FR-005**: System MUST validate data dimensions match expected sizes (e.g., heightmap array length equals width × height).
- **FR-006**: System MUST validate data values fall within expected ranges (slope in [0,1], dimensions positive, coordinates within map bounds).
- **FR-007**: System MUST save all validated map data to files in a designated output directory.
- **FR-008**: System MUST produce a summary of extraction results including status, element counts, and file paths for each data type.
- **FR-009**: System MUST fail the test explicitly if any primary data type (dimensions, heightmap, corners heightmap) returns null or empty data.
- **FR-010**: System MUST treat secondary data types (LOS, radar) that return empty data as warnings rather than hard failures, since they may depend on game state timing.

### Key Entities

- **MapData**: The complete set of extracted data for a single map, including all array types, dimensions, positions, and spots.
- **ExtractionResult**: Per-data-type outcome including status (success/warning/fail), element count, value range, and output file path.
- **ExtractionReport**: Summary of all extraction results for a single test run.

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: All primary map data types (dimensions, heightmap, corners heightmap, slope map, metal spots, start position) are successfully extracted with non-null, non-empty results in a single test run.
- **SC-002**: Saved output files are non-empty and contain data that matches the extracted dimensions and value ranges when read back.
- **SC-003**: The extraction and save process completes within the duration of a single headless engine test run (no additional engine restarts required).
- **SC-004**: The test produces a clear pass/fail result with a human-readable summary showing extraction status for each data type.

## Assumptions

- Maps are already downloaded and available in the BAR data directory (confirmed: 10+ maps present).
- The headless engine (`spring-headless`) is available and functional in the test environment.
- The existing proxy and F# client infrastructure supports all map callback types needed for extraction.
- The existing persistent test framework (T9_MapTests.fs) provides a working pattern for map data queries that can be extended.
- Output format for saved data is implementation-specific and not prescribed by this specification.
- A single map is sufficient for validating the extraction pipeline; multi-map testing is out of scope.
