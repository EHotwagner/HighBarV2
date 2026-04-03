# Feature Specification: Integrate BAR Unit Types into F# Client

**Feature Branch**: `009-client-unit-types`  
**Created**: 2026-04-03  
**Status**: Draft  
**Input**: User description: "incorporate the new fsharp unit types of the last few features in the fsharp client and run a few tests."

## User Scenarios & Testing *(mandatory)*

### User Story 1 - Access Unit Data from Client Code (Priority: P1)

An AI bot developer using the HighBar F# client wants to look up BAR unit definitions (costs, health, weapons, capabilities) while writing game AI logic, so they can make informed decisions about unit production, combat, and economy.

**Why this priority**: Without access to unit data, AI bots cannot make intelligent decisions about which units to build, what threats they face, or how to allocate resources. This is the foundational integration that enables all higher-level AI logic.

**Independent Test**: Can be fully tested by adding a project reference from the client to the BAR data library, creating a helper module that exposes unit lookup functions, and verifying that unit data is accessible from client code through a set of unit tests.

**Acceptance Scenarios**:

1. **Given** the F# client project, **When** a developer references the client library, **Then** they can access all 953 BAR unit definitions through the client's public API.
2. **Given** a unit name string (e.g., "armham"), **When** queried through the client, **Then** the full unit definition including costs, health, weapons, and capabilities is returned.
3. **Given** the client library is built, **When** a developer opens a unit data module, **Then** IDE autocompletion provides typed access to all unit fields.

---

### User Story 2 - Query Units by Capability (Priority: P2)

An AI bot developer wants to filter and query units by their capabilities (builders, armed, mobile, flying, economy) so they can quickly find relevant units for specific strategic decisions.

**Why this priority**: Capability-based queries are the primary way AI logic interacts with unit data -- e.g., "find all builders I can produce" or "what armed units are available." This builds directly on the data access from P1.

**Independent Test**: Can be tested by writing queries against the unit data and verifying the results match expected capability classifications for known units.

**Acceptance Scenarios**:

1. **Given** the client library, **When** querying for all builder units, **Then** a list of units with construction capability is returned.
2. **Given** the client library, **When** querying for armed mobile units in a specific faction, **Then** only units matching all criteria are returned.
3. **Given** a specific unit name, **When** checking its capabilities, **Then** boolean flags (isBuilder, isArmed, isMobile, canFly, hasEconomy, isBuilding) accurately reflect the unit's properties.

---

### User Story 3 - Validate Integration with Existing Tests (Priority: P3)

A developer wants confidence that the BAR data integration does not break existing client functionality and that the new unit data access layer works correctly, verified through automated tests.

**Why this priority**: Tests ensure the integration is correct and maintainable. Without them, future changes could silently break unit data access.

**Independent Test**: Can be tested by running the full test suite -- both existing client tests and new integration tests -- and verifying all pass.

**Acceptance Scenarios**:

1. **Given** the integrated client library, **When** running all existing tests, **Then** all previously passing tests continue to pass.
2. **Given** new unit data integration tests, **When** run against the client, **Then** they verify correct data access for representative units across factions and capabilities.
3. **Given** the test suite, **When** a developer adds a new unit data query, **Then** the test patterns are clear enough to follow for writing additional tests.

---

### Edge Cases

- What happens when looking up a unit name that doesn't exist? The lookup should return None (option type).
- How does the system handle units with ValueOrExpr fields containing runtime expressions? The Expr variant should be preserved and accessible, not silently discarded.
- What happens if the BAR data library is updated with new units? The client integration should work without modification since it delegates to the data library's public API.

## Requirements *(mandatory)*

### Functional Requirements

- **FR-001**: The F# client project MUST reference the BAR data library as a project dependency.
- **FR-002**: The client MUST expose a module that provides typed access to all 953 BAR unit definitions.
- **FR-003**: The client MUST support looking up individual units by name, returning an option type for safe handling of missing units.
- **FR-004**: The client MUST support querying units by capability (builder, armed, mobile, flying, economy, building).
- **FR-005**: The client MUST preserve access to both composable (UnitDef) and flat (per-unit type) representations.
- **FR-006**: A new test project MUST verify the integration with tests covering data access, capability queries, and representative unit spot-checks.

### Key Entities

- **UnitDef**: Composable unit definition with optional capability sub-records (movement, builder, weapons, economy, building).
- **UnitSummary**: Lightweight index record with capability flags for efficient querying.
- **Per-unit types**: Flat, fully-typed representations for individual units (e.g., Armck, Armham) with no option wrappers on fields that are always present.

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: All 953 BAR unit definitions are accessible through the F# client without any data loss compared to the standalone data library.
- **SC-002**: Unit lookups by name complete correctly for all known unit names.
- **SC-003**: Capability queries (builders, armed, mobile, flying, economy, buildings) return correct subsets as validated by spot-check tests.
- **SC-004**: All existing tests continue to pass after integration.
- **SC-005**: New integration tests cover at least 3 representative units from different factions and capability categories.

## Assumptions

- The BAR data library generated by features 006-008 is stable and its public API will not change during this integration.
- The F# client project is the correct integration target; no changes to the protobuf communication layer are needed.
- The integration is additive -- it exposes unit data alongside existing client functionality without modifying existing behavior.
- Test coverage focuses on integration correctness (data accessible, queries work) rather than re-testing the data library's internal correctness (already covered by 135 existing tests).
