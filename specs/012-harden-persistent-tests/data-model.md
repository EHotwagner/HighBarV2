# Data Model: Harden Persistent Engine Tests

## Entities

### UnitDefRegistry

Runtime-discovered mapping built during fixture initialization or a dedicated discovery test.

| Field | Type | Description |
|-------|------|-------------|
| Entries | map<int, UnitDefInfo> | unitDefId → info for all successfully spawned IDs |
| Builders | int list | unitDefIds that correspond to builder units |
| ArmedUnits | int list | unitDefIds that correspond to armed units |
| MobileUnits | int list | unitDefIds that correspond to mobile units |
| Buildings | int list | unitDefIds that correspond to static buildings |
| EconomyUnits | int list | unitDefIds that correspond to economy structures |
| FailedIds | int list | unitDefIds that did not produce UnitCreated events |

### UnitDefInfo

Per-unitDefId discovery result.

| Field | Type | Description |
|-------|------|-------------|
| UnitDefId | int | Engine-assigned unit definition ID |
| Name | string option | BarData unit name if cross-referenced |
| IsBuilder | bool | Can construct other units |
| IsArmed | bool | Has weapons |
| IsMobile | bool | Can move |
| IsBuilding | bool | Static structure |
| SpawnSuccess | bool | Whether GiveMeNewUnitCommand produced UnitCreated |

### BatchResult

Result of one batch in the exhaustive spawn test.

| Field | Type | Description |
|-------|------|-------------|
| BatchIndex | int | 0-based batch number |
| StartId | int | First unitDefId in this batch |
| EndId | int | Last unitDefId in this batch |
| Expected | int | Number of spawn commands sent |
| Received | int | Number of UnitCreated events received |
| FailedIds | int list | unitDefIds that didn't produce events |
| EngineCrashed | bool | Whether the engine died during this batch |

### BattleMetrics

Accumulated statistics from large-scale combat scenarios.

| Field | Type | Description |
|-------|------|-------------|
| UnitsSpawned | int | Total units created |
| FramesRun | int | Total game frames executed |
| DamageEvents | int | Count of UnitDamaged + EnemyDamaged |
| DestroyedEvents | int | Count of UnitDestroyed + EnemyDestroyed |
| LosEvents | int | Count of EnemyEnterLOS events |
| EngineAlive | bool | Whether engine survived the scenario |
| ElapsedSeconds | float | Wall-clock time for the scenario |

## Relationships

- UnitDefRegistry 1:N UnitDefInfo (one registry, many entries)
- UnitDefRegistry is shared across all test classes via the fixture
- BatchResult is produced per batch in the exhaustive spawn test
- BattleMetrics is produced per large-scale scenario test
