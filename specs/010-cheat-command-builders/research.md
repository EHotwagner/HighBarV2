# Research: F# Cheat Command Builders

**Date**: 2026-04-03 | **Branch**: `010-cheat-command-builders`

## R1: Existing Builder Pattern

**Decision**: Follow the exact pattern used by the 13 existing builder functions in `clients/fsharp/src/Commands.fs`.

**Rationale**: All existing builders follow the same structure:
1. Create an `AICommand()` instance
2. Create the specific inner command message
3. Set fields on the inner message
4. Assign the inner message to the appropriate AICommand oneof field
5. Return the AICommand

This pattern is consistent, readable, and type-safe. No reason to deviate.

**Alternatives considered**:
- Fluent/chainable builder API — rejected: inconsistent with existing codebase, adds complexity for no benefit in simple constructors.

## R2: Protobuf Message Field Mapping

**Decision**: Map builder parameters directly to protobuf fields with no transformation.

| Builder | Proto Message | Fields |
|---------|--------------|--------|
| GiveMeResourceCommand | `GiveMeCommand` | `resource_id: int32`, `amount: float` |
| GiveMeNewUnitCommand | `GiveMeNewUnitCommand` | `unit_def_id: int32`, `position: Vector3` |
| CallLuaRulesCommand | `CallLuaRulesCommand` | `data: string` |
| CallLuaUICommand | `CallLuaUICommand` | `data: string` |

**Rationale**: Principle III (Correctness Over Cleverness) — 1:1 mapping to engine structs, no implicit conversions.

**Alternatives considered**:
- Adding convenience overloads (e.g., named resource constants for metal=0/energy=1) — rejected: would add protocol-level behavior that other language clients cannot replicate (Principle VI).

## R3: Test Strategy

**Decision**: Create a new unit test project (`tests/unit/fsharp/`) with xUnit tests that verify protobuf field population without requiring an engine.

**Rationale**: 
- Existing integration tests require a running headless engine (heavy, slow)
- Builder functions are pure constructors — testing field population is a unit-level concern
- Principle IV (Test at the Boundary) is satisfied: we test the protobuf message construction boundary

**Alternatives considered**:
- Adding to integration test project only — rejected: would make these tests depend on engine availability
- Skipping tests — rejected: SC-004 requires 100% test coverage of new builders

## R4: Naming Convention

**Decision**: Use `XxxCommand` naming matching the protobuf message name, consistent with existing builders.

| Builder Function | Matches Existing Pattern |
|-----------------|------------------------|
| `GiveMeResourceCommand` | Yes (like `MoveCommand`, `BuildCommand`) |
| `GiveMeNewUnitCommand` | Yes (like `SelfDestructCommand`) |
| `CallLuaRulesCommand` | Yes (like `SendTextMessageCommand`) |
| `CallLuaUICommand` | Yes |

**Rationale**: Naming consistency with the 13 existing builders.

## Open Items

None. All questions resolved.
