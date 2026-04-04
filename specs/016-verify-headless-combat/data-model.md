# Data Model: Verify Headless Combat and Fix Test Errors

**Feature**: 016-verify-headless-combat  
**Date**: 2026-04-04

## Existing Entities (from Feature 015, no changes)

### GameResult (DU)

```
Win | Loss | Crash | Stall | Timeout
```

### GameOutcome (record)

Already tracks all combat events needed for verification:

| Field | Type | Purpose |
|-------|------|---------|
| GameNumber | int | Sequential game identifier |
| Result | GameResult | How the game ended |
| DurationFrames | int | Total frames elapsed |
| DurationMinutes | float | Duration in minutes |
| UnitsProduced | int | Total friendly units built |
| UnitsLost | int | Total friendly units lost |
| EnemyUnitsDestroyed | int | Total enemy units destroyed |
| MexBuiltCount | int | Metal extractors built |
| MexFirstBuiltFrame | int option | Frame of first mex |
| EnergyBuiltCount | int | Energy structures built |
| EnergyFirstBuiltFrame | int option | Frame of first energy |
| FactoryBuiltCount | int | Factories built |
| FactoryFirstBuiltFrame | int option | Frame of first factory |
| FirstCombatUnitFrame | int option | Frame of first combat unit |
| CrashMessage | string option | Error message if crashed |
| WeaponFiredCount | int | WeaponFired events received |
| UnitDamagedCount | int | UnitDamaged events received |
| EnemyDamagedCount | int | EnemyDamaged events received |
| UnitDestroyedCount | int | UnitDestroyed events received |
| EnemyDestroyedCount | int | EnemyDestroyed events received |

### ValidationCriterion / ValidationReport / TestAssertion / TestSuiteReport

No changes needed — existing types from Feature 015 are sufficient for all reporting needs.

## New Entity

### CombatVerificationSummary

Not a new F# type — this is a section in the generated markdown report. Produced by the combat verification test after analyzing `GameOutcome` combat event fields.

| Field | Source | Purpose |
|-------|--------|---------|
| Engine version | `tests/engine-version.json` | Which engine was tested |
| Engine mode | "headless" or "live" | Which binary was used |
| Games run | count of GameOutcome list | How many games were tested |
| Total frames | sum of DurationFrames | Total simulation time |
| WeaponFired total | sum of WeaponFiredCount | Key combat indicator |
| UnitDamaged total | sum of UnitDamagedCount | Damage event indicator |
| EnemyDamaged total | sum of EnemyDamagedCount | Damage event indicator |
| UnitDestroyed total | sum of UnitDestroyedCount | Destruction indicator |
| EnemyDestroyed total | sum of EnemyDestroyedCount | Destruction indicator |
| Verdict | "COMBAT CONFIRMED" or "NO COMBAT" | Definitive finding |
| Prior finding (014) | "No combat in headless" | Reference baseline |
| Agrees with prior | bool | Whether this confirms or refutes 014 |

## State Transitions

No new state transitions. Games follow the existing lifecycle:
`Launch → Handshake → Frame Loop → (Release | Stall | Timeout | Crash)`

## Data Volume

- 1-3 games for combat verification (lightweight)
- 10-20 games for full validation suite (existing)
- Reports: ~1-5KB markdown each
