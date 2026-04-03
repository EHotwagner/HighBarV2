# Data Model: Integrate BAR Unit Types into F# Client

**Feature**: 009-client-unit-types  
**Date**: 2026-04-03

## Entities

This feature does not introduce new entities. It integrates existing entities from the BAR data library into the client. The canonical definitions live in `data/bar/src/`.

### Existing Entities (from BarData)

| Entity | Location | Purpose |
|--------|----------|---------|
| `UnitDef` | `ComposableTypes.fs` | Composable unit definition with optional capability sub-records |
| `UnitSummary` | `UnitSummary.fs` | Lightweight index record with capability flags |
| `WeaponDef` | `Types.fs` | Weapon stats (damage, range, reload, etc.) |
| `MovementDef` | `ComposableTypes.fs` | Mobile unit movement stats |
| `BuilderDef` | `ComposableTypes.fs` | Constructor unit stats |
| `EconomyDef` | `ComposableTypes.fs` | Resource production stats |
| `BuildingDef` | `ComposableTypes.fs` | Static structure stats |
| `SoundDef` | `Types.fs` | Unit sound assignments |
| `FeatureDef` | `Types.fs` | Wreckage/corpse definitions |
| `ValueOrExpr<'T>` | `Types.fs` | Generic DU for concrete values vs Lua runtime expressions |
| Per-unit types | Per-subfolder .fs files | Flat, fully-typed per-unit records (e.g., `Armck`, `Armham`) |

### New Module (in client)

| Module | Location | Purpose |
|--------|----------|---------|
| `HighBar.Client.Units` | `clients/fsharp/src/Units.fs` | Convenience access point for unit data within client namespace |

### Relationships

```text
HighBar.Client.Units
  ├── delegates to → BarData.AllUnits (UnitSummary queries)
  └── delegates to → BarData.AllUnitDefs (UnitDef queries)

BarData.AllUnits
  └── aggregates → 953 UnitSummary records from per-subfolder modules

BarData.AllUnitDefs
  └── aggregates → 953 (name, subfolder, UnitDef) tuples from per-subfolder modules
```

### Data Characteristics

- **Volume**: 953 unit definitions (static, immutable)
- **Lifecycle**: Loaded once at application startup; no state transitions
- **Identity**: Units identified by unique string name (e.g., "armham", "cormex")
- **Validation**: Already validated by 135 existing tests in BarData.Tests
