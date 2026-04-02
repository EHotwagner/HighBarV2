# Protocol Contract: HighBar V2 IPC Protocol

**Version**: 1 (strict match required at handshake)

## Wire Format

All messages use 4-byte little-endian length-prefixed protobuf framing:

```
┌─────────────────┬──────────────────────────┐
│ 4 bytes (LE)    │ N bytes                  │
│ message length  │ serialized protobuf      │
└─────────────────┴──────────────────────────┘
```

- Maximum message size: 8MB (8,388,608 bytes)
- Messages exceeding this limit are dropped with a logged error

## Transport

- **Primary**: Unix domain socket (stream mode)
- **Fallback**: TCP loopback (127.0.0.1, configurable port, default 17432)
- Connection model: **one-shot** — no reconnection after disconnect

## Connection Sequence

```
AI Process                          Proxy (Engine)
    │                                    │
    │◄──────── TCP/UDS connect ──────────│  (proxy connects to listening AI)
    │                                    │
    │◄──────── Handshake ────────────────│  {protocol_version, engine_version,
    │                                    │   game_id, map_name, team_id, ally_team_id}
    │                                    │
    │────────► HandshakeResponse ────────►│  {accepted: bool, protocol_version}
    │                                    │   (rejected if version mismatch)
    │                                    │
    │◄──────── Frame ────────────────────│  (repeated per game frame)
    │────────► FrameResponse ────────────►│
    │                                    │
    │  (optional, within frame window)   │
    │────────► CallbackRequest ──────────►│
    │◄──────── CallbackResponse ─────────│
    │                                    │
    │◄──────── Shutdown ─────────────────│  (game end)
    │                                    │
```

## Message Types

### Direction: Proxy → AI

| Message | When | Contents |
|---------|------|----------|
| Handshake | On connection | protocol_version, engine_version, game_id, map_name, mod_name, team_id, ally_team_id, player_count |
| Frame | Each game frame | frame_number, repeated EngineEvent (oneof, 28 variants) |
| CallbackResponse | After CallbackRequest | request_id, success, result (typed), error_message |
| SaveRequest | Engine save event | (empty — AI should serialize its state) |
| LoadRequest | Engine load event | state_data (bytes — previously saved AI state) |
| Shutdown | Game end / AI removal | reason (enum: GAME_OVER, DISCONNECT, ERROR) |

### Direction: AI → Proxy

| Message | When | Contents |
|---------|------|----------|
| HandshakeResponse | After Handshake | accepted (bool), protocol_version |
| FrameResponse | After Frame | repeated AICommand (oneof, 97 variants) |
| CallbackRequest | During frame window | request_id, callback_id, repeated params |
| SaveResponse | After SaveRequest | state_data (bytes — serialized AI state) |

## Timeout Behavior

- **Frame timeout**: Configurable (default 25ms). If AI does not respond within timeout, proxy skips commands for that frame and continues.
- **Backpressure**: If socket buffer is full (AI too slow), proxy drops that frame's events, logs warning, continues next frame.

## EngineEvent Variants (28)

```protobuf
oneof event {
  InitEvent init = 1;
  ReleaseEvent release = 2;
  UpdateEvent update = 3;
  MessageEvent message = 4;
  UnitCreatedEvent unit_created = 5;
  UnitFinishedEvent unit_finished = 6;
  UnitIdleEvent unit_idle = 7;
  UnitMoveFailedEvent unit_move_failed = 8;
  UnitDamagedEvent unit_damaged = 9;
  UnitDestroyedEvent unit_destroyed = 10;
  UnitGivenEvent unit_given = 11;
  UnitCapturedEvent unit_captured = 12;
  EnemyEnterLOSEvent enemy_enter_los = 13;
  EnemyLeaveLOSEvent enemy_leave_los = 14;
  EnemyEnterRadarEvent enemy_enter_radar = 15;
  EnemyLeaveRadarEvent enemy_leave_radar = 16;
  EnemyDamagedEvent enemy_damaged = 17;
  EnemyDestroyedEvent enemy_destroyed = 18;
  WeaponFiredEvent weapon_fired = 19;
  PlayerCommandEvent player_command = 20;
  SeismicPingEvent seismic_ping = 21;
  CommandFinishedEvent command_finished = 22;
  LoadEvent load = 23;
  SaveEvent save = 24;
  EnemyCreatedEvent enemy_created = 25;
  EnemyFinishedEvent enemy_finished = 26;
  LuaMessageEvent lua_message = 27;
}
```

## AICommand Variants (97 categories)

Commands organized by category:

| Range | Category | Examples |
|-------|----------|----------|
| 1-3 | Drawing | AddPoint, AddLine, RemovePoint |
| 4-9 | Chat/Resources | SendTextMessage, SetLastPosMessage, SendResources, SetMyIncomeShareDirect, SetShareLevel, PauseTeam |
| 12-15 | Groups | AddUnit, RemoveUnit, GetMembers |
| 16-19 | Pathfinding | InitPath, GetApproxLength, GetNextWaypoint, FreePath |
| 20, 79 | Cheats | GiveMe, GiveMeNewUnit |
| 21, 96 | Lua | CallLuaRules, CallLuaUI |
| 22-34 | Drawer Figures | CreateSplineFigure, CreateLineFigure, SetPosition, SetColor, Remove, DrawUnit |
| 35-78 | Unit Commands | Build, Stop, Wait, Move, Patrol, Fight, Attack, Guard, Repair, Reclaim, Restore, Resurrect, Capture, SetBase, SelfDestruct, LoadUnits, UnloadUnits, SetWantedMaxSpeed, Stockpile, DGun, Custom, and more |

All unit commands share a common base: `unit_id`, `group_id`, `options` (bitfield), `timeout`.

## Sentinel Value Convention

Engine uses -1 for "no value" (e.g., no attacker). Proto3 uses `optional` fields:
- `optional int32 attacker_id` — presence check via `has_attacker_id`
- Not set = engine sentinel (-1)
- Set to 0 = actual unit/enemy with ID 0

## Error Handling

| Scenario | Proxy Behavior |
|----------|---------------|
| AI process not listening | init() returns error, engine removes AI |
| Connection lost mid-game | handleEvent() returns error, engine removes AI (one-shot) |
| Protocol version mismatch | Refuse connection, log error |
| Frame timeout exceeded | Skip commands, log warning, continue |
| Socket buffer full | Drop frame events, log warning, continue |
| Oversized message (>8MB) | Drop message, log error, continue |
| Invalid command from AI | Log warning, skip command, continue batch |
| Unknown protobuf fields | Silently ignored (standard protobuf forward compatibility) |
