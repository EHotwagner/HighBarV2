# Quickstart: Flat Per-Unit BAR Type Definitions

**Feature**: 007-flat-bar-types | **Date**: 2026-04-03

## Access a Specific Unit

Each unit is a dedicated type with only the fields it actually has:

```fsharp
open BarData.Units

// Combat bot — has movement and weapons, no builder fields
let ham = ArmBots.armham
printfn "Health: %A" ham.health        // ValueOrExpr.Concrete 1000.0
printfn "Speed: %A" ham.speed          // ValueOrExpr.Concrete 46.2 (direct, not option)
printfn "Weapons: %d" ham.weapons.Length  // Direct access, no IsSome check

// Builder bot — has movement and builder fields, no weapons
let ck = ArmBots.armck
printfn "Worker time: %A" ck.workerTime  // ValueOrExpr.Concrete 80.0 (direct field)
printfn "Build options: %d" ck.buildOptions.Length  // 29 buildable units

// Static building — no movement fields exist on this type at all
let solar = ArmBuildings_LandEconomy.armsolar
printfn "Energy: %A" solar.energyMake  // ValueOrExpr.Concrete 20.0 (direct)
// solar.speed  ← compile error! Field doesn't exist on this type
```

## Query Units by Capability

Use the shared `UnitSummary` for discovery:

```fsharp
open BarData

// Find all builders
let builders = AllUnits.builders()
printfn "Found %d builders" builders.Length

// Find all flying units
let flyers = AllUnits.flying()

// Find a specific unit summary
match AllUnits.tryFind "armcom" with
| Some summary ->
    printfn "%s: builder=%b armed=%b mobile=%b" 
        summary.name summary.isBuilder summary.isArmed summary.isMobile
| None -> printfn "Not found"

// Custom queries
let expensiveBuilders =
    AllUnits.all
    |> List.filter (fun u -> u.isBuilder && u.metalCost = ValueOrExpr.Concrete 500.0)
```

## Compare with Archived v1 (Composable Approach)

```fsharp
// v1 (archived in data/bar-v1): must check option for every capability
open BarData.V1
let hamV1 = AllUnits.tryFind "armham" |> Option.get
match hamV1.movement with
| Some m -> printfn "Speed: %A" m.speed  // Must unwrap option first
| None -> ()

// v2 (flat types): direct field access, no option checking
open BarData.Units
let hamV2 = ArmBots.armham
printfn "Speed: %A" hamV2.speed  // Direct access
```

## Generate the Library

```bash
# Generate flat types from BAR Lua source
dotnet fsi tools/generate-bar-data-flat.fsx

# Build the library
cd data/bar && dotnet build

# Run tests
cd data/bar.tests && dotnet test
```

## Project References

```xml
<!-- Reference the flat type library -->
<ProjectReference Include="../data/bar/BarData.fsproj" />

<!-- Or reference the archived v1 composable library -->
<ProjectReference Include="../data/bar-v1/BarData.fsproj" />
```
