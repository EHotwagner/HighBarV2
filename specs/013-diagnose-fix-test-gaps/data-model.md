# Data Model: Diagnose and Fix Persistent Test Gaps

**Date**: 2026-04-04  
**Feature**: 013-diagnose-fix-test-gaps

## Entities

### EngineDefIdMapping

Runtime mapping between engine-internal unitDefId and unit metadata, discovered via callback queries during harness initialization.

| Field | Type | Source | Description |
|-------|------|--------|-------------|
| DefId | int | `getUnitDefs` callback | Engine-assigned unit definition ID |
| Name | string | `UnitDef_getName` callback | Internal unit name (e.g., "armcom", "armsolar") |
| IsBuilder | bool | `UnitDef_getBuildSpeed > 0` | Whether the unit can construct other units |
| IsArmed | bool | `UnitDef_getMaxWeaponRange > 0` | Whether the unit has weapons |
| BuildOptions | int list | `UnitDef_getBuildOptions` callback | DefIds this unit can build (empty if not builder) |

**Identity**: DefId is unique within a game session. Name is unique across all defIds.  
**Lifecycle**: Created once during harness fixture init. Immutable for the session.  
**Relationship**: Replaces current `UnitDefInfo` which incorrectly cross-references BarData indices.

### SpawnResult

Per-defId spawn outcome from exhaustive testing.

| Field | Type | Description |
|-------|------|-------------|
| DefId | int | Attempted defId |
| Success | bool | Whether engine spawned the unit without crashing |
| UnitId | int option | Engine-assigned unit ID if successful |
| FailureReason | string option | Crash, timeout, or invalid defId |

**Identity**: DefId per test run.  
**Lifecycle**: Created during exhaustive spawn test, discarded after.

### CombatEventLog

Diagnostic record of all combat-related events received during a test.

| Field | Type | Description |
|-------|------|-------------|
| FrameNumber | int | Game frame when event occurred |
| EventType | enum | LOS, Damage, Destroy, WeaponFired |
| SubjectId | int | Unit or enemy ID the event is about |
| AttackerId | int option | Who caused the event (-1 = unknown) |
| DamageAmount | float option | For damage events |

**Lifecycle**: Created during combat test, used for assertions, logged on failure.

## Callback Extensions

New proxy callback dispatch entries needed in `proxy/src/callbacks.c`:

| Callback ID | Engine Function | Request Params | Response Type |
|-------------|-----------------|----------------|---------------|
| `CALLBACK_GET_UNIT_DEFS` | `getUnitDefs` | max_count: int | int_array |
| `CALLBACK_UNITDEF_GET_NAME` | `UnitDef_getName` | def_id: int | string |
| `CALLBACK_UNITDEF_GET_BUILD_OPTIONS` | `UnitDef_getBuildOptions` | def_id: int, max_count: int | int_array |
| `CALLBACK_UNIT_GET_DEF` | `Unit_getDef` | unit_id: int | int |
| `CALLBACK_UNITDEF_GET_BUILD_SPEED` | `UnitDef_getBuildSpeed` | def_id: int | float |
| `CALLBACK_UNITDEF_GET_MAX_WEAPON_RANGE` | `UnitDef_getMaxWeaponRange` | def_id: int | float |

These extend the existing dispatch mechanism — no new protocol patterns needed.
