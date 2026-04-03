# Data Model: F# Cheat Command Builders

**Date**: 2026-04-03 | **Branch**: `010-cheat-command-builders`

## Entities

All entities are existing protobuf-generated types. No new entities are introduced.

### AICommand (existing)

The top-level wrapper with a `oneof command` containing 97 variants. The four relevant oneof fields already exist:
- `give_me` (field 20) → `GiveMeCommand`
- `give_me_new_unit` (field 79) → `GiveMeNewUnitCommand`
- `call_lua_rules` (field 21) → `CallLuaRulesCommand`
- `call_lua_ui` (field 96) → `CallLuaUICommand`

### GiveMeCommand (existing)

| Field | Type | Description |
|-------|------|-------------|
| resource_id | int32 | Engine resource identifier (0=metal, 1=energy) |
| amount | float | Quantity to add |

### GiveMeNewUnitCommand (existing)

| Field | Type | Description |
|-------|------|-------------|
| unit_def_id | int32 | Unit definition identifier |
| position | Vector3 | Map position (x, y, z) to spawn the unit |

### CallLuaRulesCommand (existing)

| Field | Type | Description |
|-------|------|-------------|
| data | string | Payload string delivered to LuaRules gadgets |

### CallLuaUICommand (existing)

| Field | Type | Description |
|-------|------|-------------|
| data | string | Payload string delivered to LuaUI widgets |

### Vector3 (existing)

| Field | Type | Description |
|-------|------|-------------|
| x | float | X coordinate |
| y | float | Y coordinate (height) |
| z | float | Z coordinate |

## Relationships

```
AICommand 1──contains──1 (oneof) ──> GiveMeCommand
                                  ──> GiveMeNewUnitCommand
                                  ──> CallLuaRulesCommand
                                  ──> CallLuaUICommand
GiveMeNewUnitCommand 1──contains──1 Vector3
```

## State Transitions

None. All entities are stateless value objects constructed and sent in a single step.
