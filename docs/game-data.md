# Game Data Reference (BarData)

The `BarData` library is a generated F# library containing complete unit definitions for all Beyond All Reason factions. It provides compile-time access to unit stats, capabilities, and metadata.

**Project:** `data/bar/BarData.fsproj` | **Target:** net10.0 | **Units:** 953

## Overview

BarData is generated from BAR's Lua unit definition files by the `tools/generate-bar-data.fsx` script. It provides two parallel type systems:

1. **Flat records** (`UnitSummary`) — Lightweight index with key stats
2. **Composable records** (`UnitDef`) — Full structured definitions with optional capability sub-records

## Factions

| Faction | Prefix | Count | Description |
|---------|--------|-------|-------------|
| Armada (Arm) | `Arm*` | 200+ | Tech faction emphasizing speed and versatility |
| Cortex (Cor) | `Cor*` | 200+ | Tech faction emphasizing armor and firepower |
| Legion | `Legion_*` | 220+ | Third faction with unique unit designs |
| Scavengers | `Scavengers_*` | 80+ | NPC enemy faction |
| Other | varies | 50+ | Raptors, critters, lootboxes, evocom, etc. |

## Quick Start

### Look Up a Unit

```fsharp
open BarData

// By name (returns option)
let armham = AllUnits.tryFind "armham"
// armham = Some { name = "armham"; metalCost = 130; health = 1000; ... }

// Direct access (by faction/category module)
let ham = BarData.Units.ArmBots.armham
// ham.metalCost = 130, ham.health = 1000
```

### Query by Capability

```fsharp
open BarData

let builders = AllUnits.builders()     // All builder units
let armed = AllUnits.armed()           // All armed units
let mobile = AllUnits.mobileUnits()    // All mobile units
let flyers = AllUnits.flyingUnits()    // All flying units
let economy = AllUnits.economyUnits()  // All economy buildings
let buildings = AllUnits.buildings()   // All structures

// Compose filters
let armMobileArmed =
    AllUnits.all
    |> List.filter (fun u ->
        u.name.StartsWith("arm") && u.isMobile && u.isArmed)
```

### Access Full Definitions

```fsharp
open BarData

// Get composable UnitDef with full stats
let armhamDef = AllUnitDefs.tryFind "armham"

match armhamDef with
| Some def ->
    // Movement capabilities
    match def.movement with
    | Some m -> printfn "Speed: %A" m.speed  // ValueOrExpr<float>
    | None -> printfn "Immobile"

    // Weapons
    match def.weapons with
    | Some weapons ->
        for w in weapons do
            printfn "Weapon: %s, Range: %A" w.name w.range
    | None -> printfn "Unarmed"
| None -> ()
```

## Core Types

### UnitSummary (Flat Index)

```fsharp
type UnitSummary = {
    name: string
    subfolder: string        // e.g., "Armada/Bots"
    metalCost: int
    energyCost: int
    health: int
    isBuilder: bool
    isArmed: bool
    isMobile: bool
    canFly: bool
    hasEconomy: bool
    isBuilding: bool
}
```

### UnitDef (Composable)

```fsharp
type UnitDef = {
    // Core
    name: string
    subfolder: string
    metalCost: ValueOrExpr<int>
    energyCost: ValueOrExpr<int>
    buildTime: ValueOrExpr<int>
    health: ValueOrExpr<int>
    sightDistance: ValueOrExpr<int>

    // Footprint & visuals
    footprintX: ValueOrExpr<int>
    footprintZ: ValueOrExpr<int>
    objectName: string option
    buildPic: string option
    script: string option
    corpse: string option

    // Collision & destruction
    collisionVolumeType: string option
    collisionVolumeScales: string option
    collisionVolumeOffsets: string option
    explodeAs: string option
    selfDestructAs: string option

    // Optional capability sub-records
    movement: MovementDef option
    builder: BuilderDef option
    weapons: WeaponDef list option
    economy: EconomyDef option
    building: BuildingDef option
    featureDefs: FeatureDef list option

    // Metadata
    category: string option
    seismicSignature: ValueOrExpr<int> option
    sounds: SoundDef option
    customParams: Map<string, string>
    extras: Map<string, string>
}
```

### ValueOrExpr

Some unit stats in BAR are defined as Lua expressions rather than concrete values:

```fsharp
type ValueOrExpr<'T> =
    | Concrete of 'T    // A resolved numeric value
    | Expr of string    // A Lua expression (e.g., "tonumber(128)")
```

Use `Concrete` for direct access. `Expr` values preserve the original Lua expression text.

### Capability Sub-Records

**MovementDef:**
```fsharp
type MovementDef = {
    speed: ValueOrExpr<float>
    maxAcc: ValueOrExpr<float>
    maxDec: ValueOrExpr<float>
    turnRate: ValueOrExpr<int>
    movementClass: string option
    canFly: bool
    canMove: bool
    floater: bool
    turnInPlace: bool
}
```

**BuilderDef:**
```fsharp
type BuilderDef = {
    workerTime: ValueOrExpr<int>
    buildDistance: ValueOrExpr<int>
    buildOptions: string list
    terraformSpeed: ValueOrExpr<int> option
}
```

**WeaponDef:**
```fsharp
type WeaponDef = {
    name: string
    displayName: string option
    weaponType: string option
    damage: Map<string, ValueOrExpr<float>>
    range: ValueOrExpr<float>
    reloadTime: ValueOrExpr<float>
    weaponVelocity: ValueOrExpr<float> option
    areaOfEffect: ValueOrExpr<float> option
    accuracy: ValueOrExpr<float> option
    turret: bool
    customParams: Map<string, string>
    extras: Map<string, string>
}
```

**EconomyDef:**
```fsharp
type EconomyDef = {
    energyMake: ValueOrExpr<float> option
    metalMake: ValueOrExpr<float> option
    energyStorage: ValueOrExpr<float> option
    metalStorage: ValueOrExpr<float> option
    extractsMetal: ValueOrExpr<float> option
}
```

**BuildingDef:**
```fsharp
type BuildingDef = {
    yardMap: string option
    activateWhenBuilt: bool
    canRepeat: bool
}
```

## Module Index

### Global Modules

| Module | Description |
|--------|-------------|
| `AllUnits` | All 953 `UnitSummary` records with filter functions |
| `AllUnitDefs` | All 953 composable `UnitDef` records |

### Armada Modules

| Module | Category |
|--------|----------|
| `ArmAircraft` | T1 aircraft |
| `ArmAircraft_T2` | T2 aircraft |
| `ArmBots` | T1 bots |
| `ArmBots_T2` | T2 bots |
| `ArmBuildings_LandDefenceOffence` | Land defenses |
| `ArmBuildings_LandEconomy` | Land economy |
| `ArmBuildings_LandFactories` | Land factories |
| `ArmBuildings_LandUtil` | Land utility |
| `ArmBuildings_SeaDefence` | Sea defenses |
| `ArmBuildings_SeaEconomy` | Sea economy |
| `ArmBuildings_SeaFactories` | Sea factories |
| `ArmBuildings_SeaUtil` | Sea utility |
| `ArmGantry` | Gantry (T3) |
| `ArmHovercraft` | Hovercraft |
| `ArmSeaplanes` | Seaplanes |
| `ArmShips` | T1 ships |
| `ArmShips_T2` | T2 ships |
| `ArmVehicles` | T1 vehicles |
| `ArmVehicles_T2` | T2 vehicles |

### Cortex Modules

Same structure as Armada with `Cor*` prefix.

### Legion Modules

| Module | Category |
|--------|----------|
| `Legion_Air` | T1 air |
| `Legion_Air_T2_Air` | T2 air |
| `Legion_Bots` | T1 bots |
| `Legion_Bots_T2_Bots` | T2 bots |
| `Legion_Constructors` | Constructors |
| `Legion_Defenses` | Defenses |
| `Legion_Economy` | Economy |
| `Legion_Hovercraft` | Hovercraft |
| `Legion_Labs` | Factories |
| `Legion_EvoCom` | Evolving commander |
| `Legion_Other` | Other units |
| `Legion_Other_Commanders` | Commanders |
| `Legion_Ships` / `Legion_Ships_T2` | Ships |
| `Legion_T3` | Tier 3 units |
| `Legion_Vehicles` / `Legion_Vehicles_T2_Vehicles` | Vehicles |

### Scavenger Modules

| Module | Category |
|--------|----------|
| `Scavengers_Air` | Aircraft |
| `Scavengers_Boss` | Boss units |
| `Scavengers_Bots` | Bots |
| `Scavengers_Buildings_*` | Various buildings |
| `Scavengers_Ships` | Ships |
| `Scavengers_Vehicles` | Vehicles |

## Generating the Data

The data library is generated from BAR game files by:

```bash
cd tools && dotnet fsi generate-bar-data.fsx
```

This script:
1. Reads all Lua unit definition files from the BAR game content
2. Parses each file using XParsec (Lua parser)
3. Extracts all unit fields, weapons, economy data, etc.
4. Generates F# source files in `data/bar/src/`
5. Preserves Lua expressions as `Expr` values where numeric parsing fails

## Data Validation

The `BarData.Tests` project validates data integrity:

```bash
./tests/run-all.sh --category data
```

Tests verify:
- Completeness (>= 950 units, faction counts)
- Correctness (spot-check field values for known units)
- Structural integrity (no negative costs, no empty names, no duplicates)
- Round-trip conversion (flat ↔ composable preserves all data)
- Capability classification (builders, armed, mobile, economy, buildings)

See also: [Client API](client-api.md) | [Architecture](architecture.md)
