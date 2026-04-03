# Data Model: Unified BAR Data Generators with Cross-Conversion

**Feature**: 008-unified-bar-generators | **Date**: 2026-04-03

## Entity Overview

```
┌─────────────────────┐     ┌──────────────────┐     ┌──────────────────┐
│   Per-Unit Type     │     │   UnitDef         │     │   UnitSummary    │
│   (e.g., Armck)     │◄───►│   (composable)    │     │   (shared record)│
├─────────────────────┤     ├──────────────────┤     ├──────────────────┤
│ name                │     │ name             │     │ name             │
│ subfolder           │     │ subfolder        │     │ subfolder        │
│ metalCost           │     │ metalCost        │     │ metalCost        │
│ objectName (opt)    │     │ objectName (opt) │     │ energyCost       │
│ speed (if mobile)   │     │ movement (opt)   │     │ health           │
│ workerTime (if bldr)│     │ builder (opt)    │     │ isBuilder        │
│ weapons (if armed)  │     │ weapons (opt)    │     │ isArmed          │
│ ...only present flds│     │ economy (opt)    │     │ isMobile, canFly │
└─────────────────────┘     │ building (opt)   │     │ hasEconomy       │
    toUnitDef() ──────►     │ ...all fields    │     │ isBuilding       │
    ◄────── toFlat()        └──────────────────┘     └──────────────────┘
                                    │                        │
                                    │ 953 entries            │ 953 entries
                                    ▼                        ▼
                            ┌──────────────────┐     ┌──────────────────┐
                            │  AllUnitDefs     │     │  AllUnits        │
                            │  (module)        │     │  (module)        │
                            ├──────────────────┤     ├──────────────────┤
                            │ all: list        │     │ all: list        │
                            │ tryFind(name)    │     │ tryFind(name)    │
                            └──────────────────┘     │ builders()       │
                                                     │ armed(), etc.    │
                                                     └──────────────────┘
```

## Entities

### Per-Unit Record Type (flat, ~953 unique types)

Each BAR unit generates a unique F# record type. Fields included **only if present** in the unit's Lua source, except for universal fields which are always present.

**Universal fields** (present on all units):

| Field | Type | Source |
|-------|------|--------|
| name | string | Lua unit ID |
| subfolder | string | Directory path |
| metalCost | ValueOrExpr\<float\> | Lua `metalcost` |
| energyCost | ValueOrExpr\<float\> | Lua `energycost` |
| buildTime | ValueOrExpr\<float\> | Lua `buildtime` |
| health | ValueOrExpr\<float\> | Lua `health` |
| sightDistance | ValueOrExpr\<float\> | Lua `sightdistance` |
| footprintX | float | Lua `footprintx` |
| footprintZ | float | Lua `footprintz` |

**Universal optional fields** (present on all flat types, option-wrapped since not all units have them):

| Field | Type | Source |
|-------|------|--------|
| objectName | string option | Lua `objectname` |
| buildPic | string option | Lua `buildpic` |
| script | string option | Lua `script` |
| corpse | string option | Lua `corpse` |
| explodeAs | string option | Lua `explodeas` |
| selfDestructAs | string option | Lua `selfdestructas` |
| collisionVolumeOffsets | string option | Lua `collisionvolumeoffsets` |
| collisionVolumeScales | string option | Lua `collisionvolumescales` |
| collisionVolumeType | string option | Lua `collisionvolumetype` |
| seismicSignature | float option | Lua `seismicsignature` |
| category | string option | Lua `category` |

**Conditional fields** (same as feature 007): movement, builder, economy, building, weapons, featureDefs, sounds, customParams, extras.

### UnitDef (composable, single definition)

Same structure as the former v1 UnitDef — all fields present, capabilities as optional sub-records. Lives in `BarData` namespace.

### Conversion Functions (per unit, generated)

Each unit module contains:
- `toUnitDef`: flat per-unit record → UnitDef (wraps flat fields into sub-records)
- `toFlat`: UnitDef → flat per-unit record (extracts sub-record fields into direct fields)

### UnitSummary, AllUnits, AllUnitDefs

Same as feature 007, plus AllUnitDefs for composable UnitDef index.

## Relationships

- Each **Per-Unit Type** has exactly one **UnitDef** counterpart (1:1, bidirectional conversion)
- Each **Per-Unit Type** has exactly one **UnitSummary** counterpart (1:1)
- **AllUnits** aggregates all **UnitSummary** entries
- **AllUnitDefs** aggregates all **UnitDef** entries

## State Transitions

None — this is a static, compile-time data library with no mutable state.
