# Data Model: BAR AI Competitive Assessment

**Feature**: 014-bar-ai-competitive-assessment
**Date**: 2026-04-04

## Entity Overview

```
GameState (1)
├── UnitRegistry (1) ── UnitRecord (0..*)
├── EconomyModel (1)
├── ThreatMap (1) ── ThreatCell (N*M grid)
├── MapModel (1) ── MetalSpot (0..*)
├── StrategyController (1)
├── Managers (5)
│   ├── EconomyManager (1)
│   ├── BuildManager (1)
│   ├── ProductionManager (1)
│   ├── MilitaryManager (1)
│   └── ScoutManager (1)
└── UnitTaskMap (1) ── UnitTask (0..* per unit)
```

## Core Entities

### GameState

The root entity holding all AI state for a single game session.

| Field | Type | Description |
|-------|------|-------------|
| frameNumber | uint32 | Current game frame |
| teamId | int | Our team ID (from handshake) |
| allyTeamId | int | Our ally team ID |
| phase | GamePhase | Current strategic phase |
| unitRegistry | UnitRegistry | All known units |
| economy | EconomyModel | Resource state |
| threatMap | ThreatMap | Enemy force model |
| mapModel | MapModel | Map knowledge |

**State transitions** (GamePhase):
```
Opening ──(first factory built)──▶ Expansion
Expansion ──(factory count >= 2 AND army value > threshold)──▶ MidGame
MidGame ──(T2 factory built OR army value > late threshold)──▶ LateGame
```

Phase transitions are triggered by economy and military milestones, not time.

### UnitRecord

Represents a single known unit (friendly or enemy).

| Field | Type | Description |
|-------|------|-------------|
| unitId | int | Engine-assigned unit ID |
| defId | int | Unit definition ID (engine runtime) |
| team | int | Owning team |
| isFriendly | bool | Whether unit belongs to our team |
| unitName | string | Unit type name (e.g., "armcom") |
| position | Vector3 | Last known position |
| health | float | Current health (friendly: live, enemy: last seen) |
| maxHealth | float | Maximum health |
| isAlive | bool | Whether unit is believed alive |
| lastSeenFrame | uint32 | Frame when last observed |
| currentTask | UnitTask option | Assigned task (friendly only) |
| classification | UnitClass | Classified role |

**Identity**: Unique by `unitId` within a game session.

**Lifecycle**:
```
[not exists] ──(UnitCreated/EnemyCreated)──▶ Alive
Alive ──(UnitFinished/EnemyFinished)──▶ Ready
Ready ──(UnitDestroyed/EnemyDestroyed)──▶ Dead
Ready ──(EnemyLeaveLOS)──▶ LastKnown
LastKnown ──(EnemyEnterLOS)──▶ Ready
LastKnown ──(staleness timeout)──▶ Forgotten
```

### UnitClass (classification)

Derived from unit definition properties at init time. A unit may have multiple classifications.

| Classification | Criteria |
|---------------|----------|
| Commander | Has special commander properties |
| Builder | workerTime > 0 |
| Factory | Has buildOptions AND isBuilding |
| MobileArmed | canMove AND hasWeapons |
| StaticDefense | isBuilding AND hasWeapons |
| Scout | canMove AND high speed AND low cost |
| Economy | Produces metal or energy (extractor, solar, fusion, etc.) |
| Radar | Has radar range |
| Transport | Can load units |

### EconomyModel

Tracks resource state and flow.

| Field | Type | Description |
|-------|------|-------------|
| metalCurrent | float | Current metal stockpile |
| metalIncome | float | Metal income per second |
| metalUsage | float | Metal expenditure per second |
| metalStorage | float | Maximum metal storage |
| energyCurrent | float | Current energy stockpile |
| energyIncome | float | Energy income per second |
| energyUsage | float | Energy expenditure per second |
| energyStorage | float | Maximum energy storage |
| isMetalStalled | bool | Metal at zero with positive demand |
| isEnergyStalled | bool | Energy at zero with positive demand |
| metalSurplus | float | metalIncome - metalUsage |
| energySurplus | float | energyIncome - energyUsage |

**Update frequency**: Every frame via Economy callbacks (GetCurrent, GetIncome, GetUsage, GetStorage).

**Extensibility**: Overdrive fields (energyToMetalConversion, pylonConnections, overdriveEfficiency) will be added in Phase 3+ without changing the base model interface.

### MapModel

Static and dynamic map knowledge.

| Field | Type | Description |
|-------|------|-------------|
| width | int | Map width in squares |
| height | int | Map height in squares |
| metalSpots | MetalSpot list | All metal extraction locations |
| startPositions | Vector3 list | Player start positions |
| exploredCells | Set<int*int> | Grid cells with visual history |

### MetalSpot

A single metal extraction location on the map.

| Field | Type | Description |
|-------|------|-------------|
| position | Vector3 | Location on map |
| metalValue | float | Extraction rate |
| isOccupied | bool | Whether a mex is built here |
| occupiedBy | int option | Team that owns the mex (if known) |
| distanceFromBase | float | Distance from our start position |
| strategicValue | float | Computed priority (distance, safety, value) |

### ThreatMap

Grid-based spatial model of enemy force distribution.

| Field | Type | Description |
|-------|------|-------------|
| cellSize | float | Grid cell size (e.g., 128 map units) |
| cells | ThreatCell[,] | 2D grid of threat values |

### ThreatCell

| Field | Type | Description |
|-------|------|-------------|
| groundThreat | float | Estimated ground DPS in this cell |
| airThreat | float | Estimated air DPS in this cell |
| lastUpdatedFrame | uint32 | When this cell was last updated |
| decayFactor | float | How much threat decays per frame when not observed |

**Update rules**:
- EnemyEnterLOS: Set threat based on observed unit DPS
- EnemyLeaveLOS: Begin decay from last known value
- EnemyDestroyed: Remove threat contribution
- Decay: Threat values decrease over time when not recently observed

### UnitTask (Discriminated Union)

Each friendly unit has exactly one assigned task.

```
UnitTask =
  | Idle
  | BuildMex of metalSpot: MetalSpot
  | BuildEnergy of position: Vector3
  | BuildFactory of defId: int * position: Vector3
  | BuildStructure of defId: int * position: Vector3
  | Produce of defId: int                            // Factory producing a unit
  | Scout of target: Vector3
  | Attack of target: Vector3
  | Defend of position: Vector3
  | Retreat of safePosition: Vector3
  | Guard of targetUnitId: int
  | Reclaim of targetId: int
  | Repair of targetUnitId: int
```

**Assignment rules**:
- Commanders start with `BuildMex` for nearest unoccupied metal spot
- New builders get `BuildMex` or `BuildEnergy` based on economy needs
- New combat units get `Idle` until assigned by MilitaryManager
- Factories get `Produce` with the next unit type from ProductionManager
- Scouts get `Scout` with unexplored regions from ScoutManager

### DecisionLogEntry

Structured log entry for AI decision observability.

| Field | Type | Description |
|-------|------|-------------|
| frame | uint32 | Game frame when decision was made |
| manager | string | Which manager made the decision |
| type | string | Decision type (e.g., "build_mex", "attack", "phase_change") |
| unitId | int option | Affected unit (if applicable) |
| details | string | Human-readable decision description |
| context | Map<string,string> | Key-value pairs of supporting data (economy state, threat level, etc.) |

## Relationships

- **GameState** owns exactly one of each: UnitRegistry, EconomyModel, ThreatMap, MapModel, StrategyController
- **UnitRegistry** contains 0..* UnitRecords, indexed by unitId
- **UnitRecord** has 0..1 UnitTask (friendly units only; enemy units have no task)
- **Managers** read from GameState (immutable view) and produce command proposals
- **StrategyController** reads EconomyModel and UnitRegistry to determine GamePhase
- **ThreatMap** is updated by ScoutManager based on LOS/radar events in UnitRegistry
- **MetalSpots** are queried from MapModel by BuildManager and EconomyManager

## Validation Rules

- unitId must be positive and unique within UnitRegistry
- defId must exist in the runtime DefId registry (queried from engine at init)
- metalSpot positions must be within map bounds (0..width, 0..height)
- UnitTask assignment: only friendly, alive units may have tasks
- GamePhase transitions are one-directional (Opening → Expansion → MidGame → LateGame, never backward)
- EconomyModel values must be >= 0 (negative income/usage indicates a query error)
- ThreatMap cell coordinates must be within grid bounds
