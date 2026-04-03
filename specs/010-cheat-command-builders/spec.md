# Feature Specification: F# Cheat Command Builders

**Feature Branch**: `010-cheat-command-builders`  
**Created**: 2026-04-03  
**Status**: Draft  
**Input**: User description: "implement the missing fsharp cheat command builder."

## User Scenarios & Testing *(mandatory)*

### User Story 1 - Spawn Units in Tests (Priority: P1)

A test author writing integration tests needs to spawn specific units at known positions on the map so they can test AI behaviors against a controlled setup. They call a cheat command builder to create a unit and receive it as a standard AICommand that flows through the existing command pipeline.

**Why this priority**: Spawning units is the most commonly needed cheat for testing — it enables scenario setup (e.g., placing defenders, creating attack groups) without waiting for the economy and build pipeline.

**Independent Test**: Can be fully tested by calling the builder function with a unit definition ID and position, verifying the returned AICommand has the correct protobuf fields populated.

**Acceptance Scenarios**:

1. **Given** a unit definition ID and a map position, **When** the test author calls the spawn-unit builder, **Then** a valid AICommand is returned with the correct unit definition and position encoded.
2. **Given** the spawn-unit builder is called, **When** the resulting command is sent to the engine with cheats enabled, **Then** the unit appears at the specified position on the map.

---

### User Story 2 - Grant Resources in Tests (Priority: P1)

A test author needs to give their AI team metal or energy so they can test building and production flows without waiting for resource gathering. They call a cheat command builder specifying the resource type and amount.

**Why this priority**: Resource injection is essential for testing economy-dependent behaviors (building, upgrades) in isolation from resource gathering.

**Independent Test**: Can be fully tested by calling the builder function with a resource ID and amount, verifying the returned AICommand has the correct protobuf fields populated.

**Acceptance Scenarios**:

1. **Given** a resource ID and an amount, **When** the test author calls the give-resource builder, **Then** a valid AICommand is returned with the correct resource ID and amount encoded.
2. **Given** the give-resource builder is called, **When** the resulting command is sent to the engine with cheats enabled, **Then** the AI team's resource balance increases by the specified amount.

---

### User Story 3 - Send Lua Rules Messages in Tests (Priority: P2)

A test author needs to invoke game-side Lua gadgets (e.g., to teleport units, modify terrain, or trigger custom game logic) by sending a string message through the Lua rules bridge.

**Why this priority**: The Lua bridge is the most powerful and flexible cheat mechanism, but it depends on gadget-side support and is less commonly needed than direct unit spawning or resource injection.

**Independent Test**: Can be fully tested by calling the builder with a string payload and verifying the returned AICommand has the correct data field set.

**Acceptance Scenarios**:

1. **Given** a string payload, **When** the test author calls the Lua rules builder, **Then** a valid AICommand is returned with the data field set to the provided string.
2. **Given** the Lua rules builder is called, **When** the resulting command is sent to the engine, **Then** the payload is delivered to LuaRules gadgets.

---

### User Story 4 - Send Lua UI Messages in Tests (Priority: P3)

A test author needs to send messages to LuaUI widgets for display or widget-side logic during test execution.

**Why this priority**: LuaUI messaging is less commonly needed in headless AI testing but completes the set of missing command builders.

**Independent Test**: Can be fully tested by calling the builder with a string payload and verifying the returned AICommand has the correct data field set.

**Acceptance Scenarios**:

1. **Given** a string payload, **When** the test author calls the Lua UI builder, **Then** a valid AICommand is returned with the data field set to the provided string.

---

### Edge Cases

- What happens when a negative resource amount is passed to the give-resource builder? The builder should still produce a valid command (the engine decides how to handle negative values).
- What happens when an empty string is passed to the Lua builders? The builder should produce a valid command with an empty data field.
- What happens when cheat commands are sent to an engine that has cheats disabled? This is an engine-level concern outside the builder's scope — the builder produces the command regardless.

## Requirements *(mandatory)*

### Functional Requirements

- **FR-001**: The client library MUST provide a builder function that creates a "give me resource" cheat command from a resource ID and amount.
- **FR-002**: The client library MUST provide a builder function that creates a "give me new unit" cheat command from a unit definition ID and a map position (x, y, z).
- **FR-003**: The client library MUST provide a builder function that creates a "call Lua rules" command from a string payload.
- **FR-004**: The client library MUST provide a builder function that creates a "call Lua UI" command from a string payload.
- **FR-005**: All new builders MUST return the same AICommand type used by existing builders so they can be mixed freely in command lists.
- **FR-006**: All new builders MUST follow the same naming convention and parameter style as existing builders in the Commands module.

### Key Entities

- **AICommand**: The wrapper message that holds any single command variant. All builders produce this type.
- **GiveMeCommand**: Message for the resource cheat (resource_id, amount).
- **GiveMeNewUnitCommand**: Message for the unit spawn cheat (unit_def_id, position).
- **CallLuaRulesCommand**: Message for Lua rules bridge (data string).
- **CallLuaUICommand**: Message for Lua UI bridge (data string).

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: All four new builder functions are callable from test code and return valid AICommand instances.
- **SC-002**: Test authors can set up a test scenario (spawn units, grant resources) using only the new builders, without needing to construct protocol messages manually.
- **SC-003**: The new builders integrate seamlessly with the existing command list pattern — they can be mixed with existing move, build, and other commands in the same frame response.
- **SC-004**: 100% of new builder functions have corresponding unit tests verifying correct field population.

## Assumptions

- The existing generated message types for all four commands are already available in the client project from prior code generation.
- The proxy layer already supports deserializing and executing these four command types.
- Cheats must be enabled in the engine configuration for cheat commands to take effect at runtime; the builders themselves do not check or enforce this.
- The builders are stateless convenience functions, consistent with the existing pattern in the Commands module.
