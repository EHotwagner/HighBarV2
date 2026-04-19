# Contract: `getGameState()` Callback

## Wire contract

Extends existing `CallbackRequest` / `CallbackResponse` framing (`proto/highbar/callbacks.proto`). No new transport messages.

### Request

```protobuf
CallbackRequest {
  uint32 request_id    = <monotonic>;
  uint32 callback_id   = CALLBACK_GAME_GET_STATE;   // new enum value = 15
  repeated CallbackParam params = [];               // empty — snapshot has no arguments
}
```

### Response — success

```protobuf
CallbackResponse {
  uint32 request_id     = <matches request>;
  bool   success        = true;
  CallbackResult result = { snapshot_value: <GameStateSnapshot> };  // new oneof variant, field number 8
  string error_message  = "";
}
```

### Response — failure

`success = false` with `error_message` populated. The client surfaces failures through the existing disconnected-engine / callback-error path (FR-011). No partial snapshot is ever returned.

## New proto additions (delta)

```protobuf
// proto/highbar/callbacks.proto

enum CallbackId {
  // ... existing values ...
  CALLBACK_GAME_GET_STATE = 15;   // NEW — in Game range (10..19)
}

message CallbackResult {
  oneof value {
    // ... existing 1..7 ...
    GameStateSnapshot snapshot_value = 8;   // NEW
  }
}

message FriendlyUnit {
  int32   unit_id     = 1;
  Vector3 position    = 2;
  float   health      = 3;
  int32   unit_def_id = 4;
  int32   team        = 5;
}

message LosEnemyUnit {
  int32   unit_id     = 1;
  Vector3 position    = 2;
  float   health      = 3;
  int32   unit_def_id = 4;
  int32   team        = 5;
}

message RadarOnlyEnemyUnit {
  int32   unit_id     = 1;
  Vector3 position    = 2;
  int32   unit_def_id = 3;
  int32   team        = 4;
}

message EconomyRecord {
  float metal_current   = 1;
  float metal_income    = 2;
  float metal_usage     = 3;
  float metal_storage   = 4;
  float energy_current  = 5;
  float energy_income   = 6;
  float energy_usage    = 7;
  float energy_storage  = 8;
}

message GameStateSnapshot {
  int32                       frame              = 1;
  repeated FriendlyUnit       friendlies         = 2;
  repeated LosEnemyUnit       los_enemies        = 3;
  repeated RadarOnlyEnemyUnit radar_only_enemies = 4;
  EconomyRecord               economy            = 5;
}
```

## Client-facing API

F# client (`clients/fsharp/src/Client.fs`):

```fsharp
type Client with
    /// One-call per-tick gamestate snapshot. Replaces the sequential refreshUnit loop
    /// for callers that need the full picture. Existing per-unit callbacks are unchanged.
    member Client.GetGameState : unit -> Async<GameStateSnapshot>
```

Shape of `GameStateSnapshot` (`clients/fsharp/src/GameState.fs`) mirrors the proto message field-for-field. Radar-only entries are a distinct F# record with no `Health` field — the "no health" contract is expressed structurally in the type system, matching the proto design (Decision 4 in research).

## Proxy-side behavior

On `CALLBACK_GAME_GET_STATE`:

1. Read `Game_getCurrentFrame` → snapshot `frame`.
2. `getTeamUnits(myTeam)` → iterate, populate `friendlies` from `Unit_getPos`, `Unit_getHealth`, `Unit_getDef`, `Unit_getTeam`.
3. `getEnemyUnitsInRadarAndLos(buf, max)` → for each id, test `Unit_isInLos`; route to `los_enemies` (with health) or `radar_only_enemies` (without health).
4. Populate `economy` from the 8 `Economy_*` calls.
5. Serialize into the per-frame arena; return as `CallbackResult.snapshot_value`.

All enumerations occur in one `handleEvent` call — the proxy remains single-threaded per constitution. No heap allocation; all repeated fields allocated from the arena.

## Failure modes

| Condition | Behavior |
|---|---|
| Engine returns error on any sub-callback | `success = false`; `error_message` carries the failing sub-call name; no partial snapshot emitted. |
| Unit set exceeds `HIGHBAR_SNAPSHOT_MAX_UNITS` (friendlies + enemies) | Log + fail the snapshot; `success=false`, `error_message="snapshot cap exceeded: N > MAX"`. Default 4096; overridable via env var `HIGHBAR_SNAPSHOT_MAX_UNITS`. |
| Client socket disconnected mid-write | Existing disconnected-engine semantics (feature 023). |
| `Unit_getDef` returns 0 for radar-only contact | Pass through unchanged (contract allows "unknown" sentinel). |

## Backward compatibility

- Existing `CALLBACK_UNIT_GET_POS`, `CALLBACK_UNIT_GET_HEALTH`, etc. remain unchanged (FR-009).
- Clients that receive a `CallbackResult` with a `snapshot_value` they don't know fall through protobuf's unknown-field handling (existing behavior).
- No breaking change to any existing wire contract.
