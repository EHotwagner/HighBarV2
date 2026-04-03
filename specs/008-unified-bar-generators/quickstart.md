# Quickstart: Unified BAR Data Library

**Feature**: 008-unified-bar-generators | **Date**: 2026-04-03

## Access a Specific Unit (Flat Type)

Each unit is a dedicated type with only the fields it actually has:

```fsharp
open BarData.Units

// Combat bot — has movement and weapons, no builder fields
let ham = ArmBots.armham
printfn "Health: %A" ham.health        // ValueOrExpr.Concrete 1000.0
printfn "Speed: %A" ham.speed          // Direct access, not option-wrapped
printfn "Weapons: %d" ham.weapons.Length

// Builder bot — has movement and builder fields
let ck = ArmBots.armck
printfn "Worker time: %A" ck.workerTime  // Direct field
printfn "Build options: %d" ck.buildOptions.Length
```

## Access a Specific Unit (Composable UnitDef)

The composable representation uses optional sub-records:

```fsharp
open BarData
open BarData.Units

// Same unit, composable view
let ckDef = ArmBots.armckDef
match ckDef.builder with
| Some b -> printfn "Worker time: %A" b.workerTime
| None -> ()

match ckDef.movement with
| Some m -> printfn "Speed: %A" m.speed
| None -> ()
```

## Convert Between Representations

```fsharp
open BarData
open BarData.Units

// Flat → UnitDef
let hamDef : UnitDef = ArmBots.armhamToUnitDef ArmBots.armham
printfn "Movement: %A" hamDef.movement  // Some { speed = Concrete 46.2; ... }

// UnitDef → Flat
let hamFlat : ArmBots.Armham = ArmBots.armhamToFlat hamDef
printfn "Speed: %A" hamFlat.speed  // Concrete 46.2

// Round-trip preserves values
assert (hamFlat.health = ArmBots.armham.health)
assert (hamFlat.speed = ArmBots.armham.speed)
```

## Query Units by Capability

```fsharp
open BarData

// Using UnitSummary (lightweight)
let builders = AllUnits.builders()
let flyers = AllUnits.flying()

// Using UnitDef (full access)
match AllUnitDefs.tryFind "armcom" with
| Some def -> printfn "Commander weapons: %A" def.weapons
| None -> ()
```

## Generate the Library

```bash
# Generate unified library from BAR Lua source
dotnet fsi tools/generate-bar-data.fsx

# Build
cd data/bar && dotnet build

# Run tests
cd data/bar.tests && dotnet test
```

## Project Reference

```xml
<!-- Single reference gets both representations -->
<ProjectReference Include="../data/bar/BarData.fsproj" />
```
