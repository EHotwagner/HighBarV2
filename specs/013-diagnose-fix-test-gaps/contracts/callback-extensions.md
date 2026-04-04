# Contract: Callback Dispatch Extensions

## New Proto Enum Values Needed

```protobuf
// Add to CallbackId enum in callbacks.proto:
CALLBACK_GET_UNIT_DEFS = 47;              // Get all valid unitDefId values
CALLBACK_CHEATS_SET_EVENTS_ENABLED = 92;  // Enable/disable events in cheat mode
```

## New Dispatch Cases in `proxy/src/callbacks.c`

Each case maps a `CallbackId` to an `SSkirmishAICallback` function call.

### CALLBACK_GET_UNIT_DEFS (47)
- **Engine function**: `callback->getUnitDefs(skirmishAIId, unitDefIds, maxSize)`
- **Params**: `params[0].int_value` = max_count (default 1024)
- **Response**: `IntArray` of valid defId values
- **Note**: Pre-allocate array on stack/arena, engine fills it

### CALLBACK_UNITDEF_GET_NAME (40)
- **Engine function**: `callback->UnitDef_getName(skirmishAIId, unitDefId)`
- **Params**: `params[0].int_value` = unitDefId
- **Response**: `string_value` = unit name

### CALLBACK_UNITDEF_GET_BUILD_OPTIONS (42)
- **Engine function**: `callback->UnitDef_getBuildOptions(skirmishAIId, unitDefId, ids, maxSize)`
- **Params**: `params[0].int_value` = unitDefId, `params[1].int_value` = max_count
- **Response**: `IntArray` of buildable defIds

### CALLBACK_UNITDEF_GET_MAX_WEAPON_RANGE (43)
- **Engine function**: `callback->UnitDef_getMaxWeaponRange(skirmishAIId, unitDefId)`
- **Params**: `params[0].int_value` = unitDefId
- **Response**: `float_value` = range (0.0 = unarmed)

### CALLBACK_UNITDEF_GET_BUILD_SPEED (46)
- **Engine function**: `callback->UnitDef_getBuildSpeed(skirmishAIId, unitDefId)`
- **Params**: `params[0].int_value` = unitDefId
- **Response**: `float_value` = build speed (0.0 = not a builder)

### CALLBACK_UNIT_GET_DEF (23) — already defined, needs dispatch
- **Engine function**: `callback->Unit_getDef(skirmishAIId, unitId)`
- **Params**: `params[0].int_value` = unitId
- **Response**: `int_value` = unitDefId

### CALLBACK_CHEATS_SET_EVENTS_ENABLED (92)
- **Engine function**: `callback->Cheats_setEventsEnabled(skirmishAIId, enabled)`
- **Params**: `params[0].int_value` = enabled (0 or 1)
- **Response**: `int_value` = previous state (0 or 1)

## F# Client Extensions

New helper methods on the client for the harness to call:

```fsharp
// Query all unit definition IDs from engine
member client.GetUnitDefs(maxCount: int) : int array

// Query unit name by defId
member client.GetUnitDefName(defId: int) : string

// Query build options for a unit definition
member client.GetBuildOptions(defId: int) : int array

// Query weapon range for a unit definition  
member client.GetMaxWeaponRange(defId: int) : float

// Query build speed for a unit definition
member client.GetBuildSpeed(defId: int) : float

// Get the defId for a live unit instance
member client.GetUnitDef(unitId: int) : int

// Enable cheat events (must be called after cheats enabled)
member client.SetCheatEventsEnabled(enabled: bool) : bool
```
