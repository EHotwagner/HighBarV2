# Phase 1 Data Model: GameState Snapshot

Wire-level protobuf entities. All additions live in `proto/highbar/callbacks.proto` (or `common.proto` for reused primitives). No persistent storage — the snapshot is transient per-tick data.

## Reused types

- `Vector3` (from `common.proto`) — `{ float x; float y; float z; }`.

## New entities

### `FriendlyUnit`

A unit owned by the AI's own team.

| Field | Type | Notes |
|---|---|---|
| `unit_id` | `int32` | Engine unit id. Correlates across snapshots. |
| `position` | `Vector3` | From `Unit_getPos`. |
| `health` | `float` | From `Unit_getHealth`. Always present. |
| `unit_def_id` | `int32` | From `Unit_getDef`. |
| `team` | `int32` | From `Unit_getTeam`. Redundant with "owned by me" but kept for symmetry with enemy entries. |

Validation: `unit_id > 0`. No other fields are validated — values are pass-through from the engine (Principle III).

### `LosEnemyUnit`

An enemy unit currently visible in LOS.

| Field | Type | Notes |
|---|---|---|
| `unit_id` | `int32` | Engine unit id. |
| `position` | `Vector3` | From `Unit_getPos`. |
| `health` | `float` | From `Unit_getHealth`. |
| `unit_def_id` | `int32` | From `Unit_getDef`. |
| `team` | `int32` | From `Unit_getTeam`. |

### `RadarOnlyEnemyUnit`

An enemy unit detected on radar but not in LOS. **No `health` field** — the engine does not expose health for radar-only contacts, and fabricating zero would be ambiguous.

| Field | Type | Notes |
|---|---|---|
| `unit_id` | `int32` | Engine unit id. |
| `position` | `Vector3` | From `Unit_getPos`. |
| `unit_def_id` | `int32` | May be 0 / "unknown" sentinel from the engine; passed through as-is. |
| `team` | `int32` | From `Unit_getTeam`. |

### `EconomyRecord`

Snapshot of per-tick economy for the AI's team. Mirrors the 4 existing economy callbacks.

| Field | Type | Notes |
|---|---|---|
| `metal_current` | `float` | `Economy_getCurrent(metal)`. |
| `metal_income` | `float` | `Economy_getIncome(metal)`. |
| `metal_usage` | `float` | `Economy_getUsage(metal)`. |
| `metal_storage` | `float` | `Economy_getStorage(metal)`. |
| `energy_current` | `float` | `Economy_getCurrent(energy)`. |
| `energy_income` | `float` | `Economy_getIncome(energy)`. |
| `energy_usage` | `float` | `Economy_getUsage(energy)`. |
| `energy_storage` | `float` | `Economy_getStorage(energy)`. |

(8 values rather than 4: the spec's "4 economy callbacks" refers to *callback types* (current/income/usage/storage), each queried for both resources.)

### `GameStateSnapshot`

The top-level response payload. Returned as a new variant on `CallbackResult`.

| Field | Type | Notes |
|---|---|---|
| `frame` | `int32` | Engine frame the snapshot reflects (from `Game_getCurrentFrame`). |
| `friendlies` | `repeated FriendlyUnit` | All units owned by the AI's team. Order follows `getTeamUnits`. |
| `los_enemies` | `repeated LosEnemyUnit` | All enemies currently in LOS. |
| `radar_only_enemies` | `repeated RadarOnlyEnemyUnit` | All enemies currently in radar range but not in LOS. |
| `economy` | `EconomyRecord` | Present on every snapshot. |

Internal consistency (FR-012): all collections reflect the same engine frame. The proxy reads `frame` first, then enumerates; the read is non-reentrant because the proxy is single-threaded (Constitution).

## Entity relationships

```text
GameStateSnapshot
├── frame
├── friendlies          : FriendlyUnit[]
├── los_enemies         : LosEnemyUnit[]
├── radar_only_enemies  : RadarOnlyEnemyUnit[]
└── economy             : EconomyRecord
```

No cross-entity references beyond containment. `unit_id` values are not guaranteed globally unique across friendly/enemy collections in the same snapshot — engine ids are unique, but callers should not rely on joining by id across team boundaries.

## State transitions

None at the snapshot level — each snapshot is a point-in-time read. Lifecycle (unit appears / dies / transitions LOS↔radar) is observed by diffing successive snapshots; no explicit transition fields are emitted by this feature.
