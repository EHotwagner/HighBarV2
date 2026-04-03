# Data Model: Flat Per-Unit BAR Type Definitions

**Feature**: 007-flat-bar-types | **Date**: 2026-04-03

## Entity Overview

```
┌─────────────────────┐     ┌──────────────────┐
│   Per-Unit Type     │     │   UnitSummary     │
│   (e.g., Armck)     │     │   (shared record) │
├─────────────────────┤     ├──────────────────┤
│ metalCost           │     │ name             │
│ energyCost          │     │ subfolder        │
│ health              │     │ metalCost        │
│ speed (if mobile)   │     │ energyCost       │
│ workerTime (if bldr)│     │ health           │
│ weapons (if armed)  │     │ isBuilder        │
│ ...only present flds│     │ isArmed          │
└─────────────────────┘     │ isMobile         │
        │                   │ canFly           │
        │ 1:1               │ hasEconomy       │
        ▼                   │ isBuilding       │
  ┌─────────────┐          └──────────────────┘
  │  Singleton  │                  │
  │  Instance   │                  │ 953 entries
  │  (let val)  │                  ▼
  └─────────────┘          ┌──────────────────┐
                           │   AllUnits       │
                           │   (module)       │
                           ├──────────────────┤
                           │ all: list        │
                           │ tryFind(name)    │
                           │ builders()       │
                           │ armed()          │
                           │ mobile()         │
                           │ flying()         │
                           │ economy()        │
                           │ buildings()      │
                           └──────────────────┘
```

## Entities

### Per-Unit Record Type (generated, ~953 unique types)

Each BAR unit class generates a unique F# record type named in PascalCase (e.g., `Armck`, `Armham`, `Armsolar`). Fields are included **only if present** in the unit's Lua source definition.

**Universal fields** (present on all units):
| Field | Type | Source |
|-------|------|--------|
| name | string | Lua unit ID |
| subfolder | string | Directory path in BAR repo |
| metalCost | ValueOrExpr\<float\> | Lua `metalcost` |
| energyCost | ValueOrExpr\<float\> | Lua `energycost` |
| buildTime | ValueOrExpr\<float\> | Lua `buildtime` |
| health | ValueOrExpr\<float\> | Lua `health` |
| sightDistance | ValueOrExpr\<float\> | Lua `sightdistance` |
| footprintX | float | Lua `footprintx` |
| footprintZ | float | Lua `footprintz` |

**Conditional fields** (included only when present in Lua source):

*Movement fields* (when `canmove=true` or `canfly=true`):
| Field | Type |
|-------|------|
| speed | ValueOrExpr\<float\> |
| maxAcc | float |
| maxDec | float |
| turnRate | float |
| movementClass | string |
| canFly | bool |
| cruiseAltitude | float |
| (+ other movement fields as present) | |

*Builder fields* (when `builder=true` and `buildoptions` present):
| Field | Type |
|-------|------|
| workerTime | ValueOrExpr\<float\> |
| buildDistance | float |
| buildOptions | string list |
| terraformSpeed | float |

*Weapon fields* (when `weapondefs` present):
| Field | Type |
|-------|------|
| weapons | WeaponDef list |

*Economy fields* (when energy/metal production present):
| Field | Type |
|-------|------|
| energyMake | ValueOrExpr\<float\> |
| metalMake | ValueOrExpr\<float\> |
| energyStorage | float |
| metalStorage | float |
| extractsMetal | float |

*Building fields* (when `yardmap` present):
| Field | Type |
|-------|------|
| yardMap | string |
| activateWhenBuilt | bool |
| canRepeat | bool |

*Other conditional fields*:
| Field | Type | Condition |
|-------|------|-----------|
| featureDefs | Map\<string, FeatureDef\> | When wreckage defined |
| sounds | SoundDef | When sounds defined |
| customParams | Map\<string, string\> | When custom params present |
| extras | Map\<string, string\> | When unmapped fields exist |

### UnitSummary (shared record, single definition)

| Field | Type | Description |
|-------|------|-------------|
| name | string | Unit identifier |
| subfolder | string | BAR repo directory |
| metalCost | ValueOrExpr\<float\> | Metal cost |
| energyCost | ValueOrExpr\<float\> | Energy cost |
| health | ValueOrExpr\<float\> | Max health |
| isBuilder | bool | Has builder capability |
| isArmed | bool | Has weapons |
| isMobile | bool | Can move (ground/water) |
| canFly | bool | Has flight capability |
| hasEconomy | bool | Produces resources |
| isBuilding | bool | Static structure |

### WeaponDef (shared sub-record, unchanged from v1)

| Field | Type |
|-------|------|
| name | string |
| displayName | string option |
| weaponType | string option |
| damage | Map\<string, float\> |
| range | ValueOrExpr\<float\> option |
| reloadTime | ValueOrExpr\<float\> option |
| weaponVelocity | float option |
| areaOfEffect | float option |
| customParams | Map\<string, string\> |
| extras | Map\<string, string\> |

### FeatureDef (shared sub-record, unchanged from v1)

| Field | Type |
|-------|------|
| blocking | bool option |
| category | string option |
| damage | float option |
| metal | float option |
| object_ | string option |
| (+ collision/footprint fields) | |

### SoundDef (shared sub-record, unchanged from v1)

| Field | Type |
|-------|------|
| build | string option |
| repair | string option |
| working | string option |
| ok | string list |
| select | string list |
| (+ other sound fields) | |

## Relationships

- Each **Per-Unit Type** has exactly one **UnitSummary** counterpart (1:1)
- Each **Per-Unit Type** may contain 0..N **WeaponDef** entries
- Each **Per-Unit Type** may contain 0..N **FeatureDef** entries (keyed by name in a Map)
- Each **Per-Unit Type** may contain 0..1 **SoundDef**
- **AllUnits** aggregates all **UnitSummary** entries into a queryable list

## Uniqueness Rules

- Unit `name` is globally unique across all modules (enforced by BAR game data)
- Per-unit type names are unique within their module (PascalCase of unit ID)
- Module names correspond 1:1 to BAR subfolder paths

## State Transitions

None — this is a static, compile-time data library with no mutable state.
