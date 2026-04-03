# Feature Specification: Flat Per-Unit BAR Type Definitions

**Feature Branch**: `007-flat-bar-types`  
**Created**: 2026-04-03  
**Status**: Draft  
**Input**: User description: "I want an additional different representation of BAR types in F#. Archive the one we just did and create a new one where every class is just a separate type with its attributes and actions."

## User Scenarios & Testing *(mandatory)*

### User Story 1 - Access Unit Data Through Dedicated Per-Unit Types (Priority: P1)

An AI developer wants to access BAR unit data where each unit class (e.g., armcom, armham, armck) is represented as its own dedicated F# type with only the attributes and actions that unit actually has — no optional fields, no shared record with `None` values. The developer opens their IDE, types the unit name, and gets IntelliSense showing only the fields that actually exist for that specific unit.

**Why this priority**: This is the core value proposition — a flat, per-unit type system where every unit is self-describing. Unlike the current composable-capability approach (feature 006) where you must check `option` fields, here each type exposes exactly what the unit has.

**Independent Test**: Can be fully tested by instantiating any generated unit type and verifying all fields are non-optional and match the Lua source data. Delivers immediate value: developers see exactly what a unit can do without checking `IsSome`.

**Acceptance Scenarios**:

1. **Given** the generated library is referenced, **When** a developer accesses a combat bot type (e.g., `armham`), **Then** the type has fields like `metalCost`, `health`, `speed`, `weapons` directly — no `option` wrapping for capabilities the unit actually possesses.
2. **Given** a builder unit like `armck`, **When** a developer accesses its type, **Then** fields like `workerTime`, `buildOptions`, and `buildDistance` are directly available as concrete fields, not wrapped in `option`.
3. **Given** a static building like `armsolar`, **When** a developer accesses its type, **Then** movement-related fields do not exist on the type at all (no `movement = None`).

---

### User Story 2 - Archive Previous Representation (Priority: P1)

The existing composable-capability representation from feature 006 must be archived (preserved but clearly separated) so that the new flat representation can coexist without conflict. The archived version remains available for reference or alternative use.

**Why this priority**: Archiving must happen before new code is generated to avoid namespace collisions and ensure a clean separation between the two approaches.

**Independent Test**: Can be tested by verifying the archived code still compiles independently and the new code does not reference or conflict with it.

**Acceptance Scenarios**:

1. **Given** the current `data/bar/` project exists, **When** archiving is performed, **Then** the project is renamed to `data/bar-v1/` (and tests to `data/bar-v1.tests/`) and remains compilable.
2. **Given** the archive is complete, **When** the new flat types are generated, **Then** there are no naming conflicts or ambiguous references between archived and new code.

---

### User Story 3 - Query Units by Capability (Priority: P2)

An AI developer wants to find all units that have a specific capability (e.g., all builders, all armed units, all units that can fly). Even though each unit is its own type, there should be a way to query or filter units by what they can do.

**Why this priority**: Without query capability, the flat type system would lose the discoverability that the composable approach provided. This is secondary because individual unit access (P1) is the primary use case.

**Independent Test**: Can be tested by querying for all builders and verifying the returned list matches known builder units from the Lua source.

**Acceptance Scenarios**:

1. **Given** the generated library is loaded, **When** a developer queries for all units with builder capability, **Then** the result includes `armck`, `armcom`, `armlab` and other known builders.
2. **Given** the generated library is loaded, **When** a developer queries for all flying units, **Then** only units with `canfly = true` in their Lua source are returned.

---

### Edge Cases

- What happens when a unit has a Lua expression instead of a concrete value? The `ValueOrExpr<'T>` pattern from feature 006 is preserved.
- How are units with dynamically generated variants (loop-generated units) handled? Each variant gets its own type if it produces a distinct unit definition.
- What happens with the ~160 rare weapon fields that vary across units? Each unit type includes only the weapon fields present in its Lua source; remaining fields go into an extras mechanism.
- How are wreckage/feature definitions represented per unit type? Included as direct fields on unit types that define wreckage.

## Clarifications

### Session 2026-04-03

- Q: How should index and capability queries work given 953 distinct per-unit types? → A: Generate both unique per-unit types for direct access AND a shared `UnitSummary` record for indexing and capability queries.
- Q: Where should the archived feature-006 code live? → A: Rename `data/bar` to `data/bar-v1`; new flat types go in `data/bar`.
- Q: Should the generator reuse or fork from the existing script? → A: New separate script `tools/generate-bar-data-flat.fsx`; can share/copy the Lua parsing code.

## Requirements *(mandatory)*

### Functional Requirements

- **FR-001**: System MUST generate a dedicated F# type for each BAR unit class (approximately 953 units), where each type contains only the fields that unit actually has.
- **FR-002**: System MUST archive the existing feature-006 composable-capability representation to a separate location so it remains compilable and accessible.
- **FR-003**: Each generated unit type MUST include all attributes from the Lua source for that unit — no data loss (fields not mapped to typed fields must be captured in an extras/overflow mechanism).
- **FR-004**: Each generated unit type MUST include weapon definitions and actions (commands) as direct fields where the unit has them.
- **FR-005**: System MUST provide a shared `UnitSummary` record type for indexing and capability queries, generated alongside the unique per-unit types. The summary record enables filtering all units by capability (e.g., find all builders, all armed units, all flying units).
- **FR-006**: System MUST preserve the `ValueOrExpr<'T>` pattern for fields that may contain Lua runtime expressions.
- **FR-007**: System MUST generate the flat types via a new dedicated generator script (`tools/generate-bar-data-flat.fsx`), reusing the Lua parsing logic from the feature-006 generator, consuming the same BAR Lua source data.
- **FR-008**: The generated library MUST compile without errors or warnings under .NET 8.0.
- **FR-009**: System MUST generate an index or lookup mechanism to access any unit definition by name.

### Key Entities

- **Unit Type**: A dedicated F# type per unit class containing exactly the fields that unit possesses (attributes, movement, weapons, economy, building properties, builder properties, sounds, custom parameters).
- **Unit Summary**: A shared record type containing capability flags and common fields, used for indexing and querying all units by capability. Each unit has both a unique type (for direct access) and a summary entry (for discovery).
- **Weapon**: Per-unit weapon definitions with damage maps, range, reload time, and associated fields.
- **Archive**: The preserved feature-006 representation in a separate namespace/directory.

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: All 953 BAR unit definitions are representable as individual typed records in the generated library.
- **SC-002**: Developers can access any unit's fields without checking option types for capabilities the unit possesses (zero `IsSome` checks needed for present capabilities).
- **SC-003**: At least 20 spot-check assertions confirm generated field values match the Lua source data.
- **SC-004**: The generated library compiles with zero errors and zero warnings.
- **SC-005**: The archived feature-006 code remains independently compilable.
- **SC-006**: Querying units by capability returns correct results for at least 5 different capability types (builder, armed, mobile, flying, economy).
- **SC-007**: No data from the Lua source is silently dropped — all fields are captured either as typed fields or in an overflow mechanism.

## Assumptions

- The same BAR game content repository and Lua parsing pipeline from feature 006 will be reused for data extraction.
- The `ValueOrExpr<'T>` discriminated union pattern is retained as it correctly handles Lua runtime expressions.
- The archive of feature 006 will be a project rename (`data/bar` → `data/bar-v1`, `data/bar.tests` → `data/bar-v1.tests`) — both representations coexist in the repository.
- The flat type approach will generate more F# source code than the composable approach (each unit gets its own type definition rather than sharing a common record shape).
- The `Commands.fs` and `CustomCommands.fs` files are shared between both representations and do not need to be duplicated.
