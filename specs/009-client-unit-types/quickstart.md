# Quickstart: Integrate BAR Unit Types into F# Client

**Feature**: 009-client-unit-types  
**Date**: 2026-04-03

## Prerequisites

- .NET 8.0 SDK installed
- Repository cloned and on branch `009-client-unit-types`

## Build

```bash
# Build the client (includes BarData dependency)
cd clients/fsharp && dotnet build

# Build and run tests
cd tests/integration/fsharp && dotnet test
```

## Usage

After integration, AI bot code can access unit data through the client:

```fsharp
open HighBar.Client

// Look up a specific unit
let hammerBot = Units.tryFind "armham"

// Get all builders
let builders = Units.builders

// Get all armed mobile units
let fighters =
    Units.all
    |> List.filter (fun u -> u.isArmed && u.isMobile)

// Access full unit definition
let armhamDef = Units.findDef "armham"
```

## Key Files

| File | Purpose |
|------|---------|
| `clients/fsharp/src/Units.fs` | Unit data access module |
| `clients/fsharp/HighBar.Client.fsproj` | Client project (references BarData) |
| `tests/integration/fsharp/UnitDataTests.fs` | Integration tests |
| `data/bar/BarData.fsproj` | BAR data library (953 units) |
