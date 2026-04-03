# Quickstart: Typed BAR Data Records

**Feature**: 006-typed-bar-data | **Date**: 2026-04-03

## Prerequisites

- .NET 8.0 SDK
- BAR repo clone at `bar-repo/` (or run generator without `--skip-clone`)

## Build

```bash
# Regenerate typed data from BAR repo
dotnet fsi tools/generate-bar-data.fsx --skip-clone

# Build the data library
dotnet build data/bar/BarData.fsproj

# Run tests
dotnet test data/bar.tests/BarData.Tests.fsproj
```

## Usage

```fsharp
open BarData
open BarData.Units

// Access a unit directly
let ham = ArmBots.armham
printfn "Metal: %A" ham.metalCost           // Concrete 130.0
printfn "Health: %A" ham.health             // Concrete 1000.0

// Check capabilities
match ham.movement with
| Some m -> printfn "Speed: %A" m.speed    // Concrete 46.2
| None   -> printfn "Immobile"

match ham.weapons with
| Some ws -> printfn "Weapons: %d" ws.Length
| None    -> printfn "Unarmed"

match ham.builder with
| Some b -> printfn "Can build: %A" b.buildOptions
| None   -> printfn "Not a builder"

// Commander has all capabilities
let com = Root.armcom
assert (com.movement.IsSome)
assert (com.builder.IsSome)
assert (com.weapons.IsSome)

// Economy building
let solar = ArmBuildings_LandEconomy.armadvsol
assert (solar.economy.IsSome)
assert (solar.building.IsSome)
assert (solar.movement.IsNone)

// Handle ValueOrExpr
match solar.economy.Value.energyMake with
| Some (Concrete v) -> printfn "Energy: %f" v
| Some (Expr s)     -> printfn "Dynamic: %s" s
| None              -> printfn "No energy production"

// Find units by name
let u = AllUnits.tryFind "armham"

// Browse all units
for (name, sub, def) in AllUnits.all do
    printfn "%s (%s): %A metal" name sub def.metalCost

// Custom params
let group = ham.customParams |> Map.tryFind "unitgroup"
```

## File Layout

| Path | Purpose |
|------|---------|
| `data/bar/src/Types.fs` | Record type definitions (UnitDef, MovementDef, etc.) |
| `data/bar/src/Commands.fs` | Engine command constants (unchanged) |
| `data/bar/src/CustomCommands.fs` | BAR custom command IDs (unchanged) |
| `data/bar/src/<Module>.fs` | Unit definitions per subfolder (~100 files) |
| `data/bar/src/AllUnits.fs` | Master index of all units |
| `data/bar.tests/` | xUnit test project |

## Key Types

- `ValueOrExpr<'T>` — `Concrete of 'T | Expr of string` for fields that may contain runtime Lua expressions
- `UnitDef` — base record with universal fields + optional capability sub-records
- `MovementDef` — speed, acceleration, turn rate, movement class
- `BuilderDef` — worker time, build distance, build options
- `WeaponDef` — damage map, range, reload time, weapon type + extras
- `EconomyDef` — energy/metal production and storage
- `BuildingDef` — yard map, building-specific fields
- `FeatureDef` — wreckage/corpse definitions
- `SoundDef` — typed sound assignments
