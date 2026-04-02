# Protobuf Schema Design for HighBar V2

## Design Principles

1. **Integer IDs everywhere** -- unit IDs, command types, player IDs as uint32/int32, never strings on hot path
2. **Delta updates over full state** -- send only what changed each frame, with full snapshot mechanism
3. **Separate schema from wire format** -- `.proto` files define schema; framing (length prefix) is outside protobuf
4. **Version the protocol** -- handshake with protocol version, game version, capabilities
5. **Reserve field numbers** -- use ranges (10-99 events, 100-199 commands) to avoid renumbering
6. **Match engine C structs** -- each protobuf message maps 1:1 to an engine C struct where possible

---

## Common Types

```protobuf
syntax = "proto3";
package highbar.v2;

// 3D position (maps to Spring's float3)
message Position {
  float x = 1;
  float y = 2;  // vertical (up)
  float z = 3;
}

// RGBA color
message Color {
  float r = 1;
  float g = 2;
  float b = 3;
  float a = 4;
}

// Command options bitfield
message CommandOptions {
  bool shift_key = 1;    // queue command
  bool control_key = 2;
  bool alt_key = 3;
  bool right_mouse_key = 4;
  bool internal_order = 5;
  int32 timeout = 6;     // auto-expire frame
}

// Key-value pair for custom parameters
message KeyValue {
  string key = 1;
  string value = 2;
}

// Resource amounts
message Resources {
  float metal = 1;
  float energy = 2;
}

// Resource state (current, income, usage, storage, etc.)
message ResourceState {
  float current = 1;
  float income = 2;
  float usage = 3;
  float storage = 4;
  float pull = 5;
  float share = 6;
  float sent = 7;
  float received = 8;
  float excess = 9;
}
```

---

## Events (Engine -> AI)

```protobuf
syntax = "proto3";
package highbar.v2;

import "highbar/v2/types.proto";

// EVENT_INIT (1)
message InitEvent {
  int32 skirmish_ai_id = 1;
  bool is_saved_game = 2;
}

// EVENT_RELEASE (2)
message ReleaseEvent {
  enum Reason {
    UNSPECIFIED = 0;
    GAME_ENDED = 1;
    TEAM_DIED = 2;
    AI_KILLED = 3;
    AI_CRASHED = 4;
    AI_FAILED_INIT = 5;
    CONNECTION_LOST = 6;
    OTHER = 7;
  }
  Reason reason = 1;
}

// EVENT_UPDATE (3)
message UpdateEvent {
  int32 frame = 1;
}

// EVENT_MESSAGE (4)
message MessageEvent {
  int32 player = 1;
  string message = 2;
}

// EVENT_UNIT_CREATED (5)
message UnitCreatedEvent {
  int32 unit_id = 1;
  int32 builder_id = 2;  // -1 if no builder
}

// EVENT_UNIT_FINISHED (6)
message UnitFinishedEvent {
  int32 unit_id = 1;
}

// EVENT_UNIT_IDLE (7)
message UnitIdleEvent {
  int32 unit_id = 1;
}

// EVENT_UNIT_MOVE_FAILED (8)
message UnitMoveFailedEvent {
  int32 unit_id = 1;
}

// EVENT_UNIT_DAMAGED (9)
message UnitDamagedEvent {
  int32 unit_id = 1;
  int32 attacker_id = 2;    // -1 if unknown
  float damage = 3;
  Position direction = 4;
  int32 weapon_def_id = 5;
  bool paralyzer = 6;
}

// EVENT_UNIT_DESTROYED (10)
message UnitDestroyedEvent {
  int32 unit_id = 1;
  int32 attacker_id = 2;    // -1 if unknown
  int32 weapon_def_id = 3;
}

// EVENT_UNIT_GIVEN (11)
message UnitGivenEvent {
  int32 unit_id = 1;
  int32 old_team_id = 2;
  int32 new_team_id = 3;
}

// EVENT_UNIT_CAPTURED (12)
message UnitCapturedEvent {
  int32 unit_id = 1;
  int32 old_team_id = 2;
  int32 new_team_id = 3;
}

// EVENT_ENEMY_ENTER_LOS (13)
message EnemyEnterLosEvent {
  int32 enemy_id = 1;
}

// EVENT_ENEMY_LEAVE_LOS (14)
message EnemyLeaveLosEvent {
  int32 enemy_id = 1;
}

// EVENT_ENEMY_ENTER_RADAR (15)
message EnemyEnterRadarEvent {
  int32 enemy_id = 1;
}

// EVENT_ENEMY_LEAVE_RADAR (16)
message EnemyLeaveRadarEvent {
  int32 enemy_id = 1;
}

// EVENT_ENEMY_DAMAGED (17)
message EnemyDamagedEvent {
  int32 enemy_id = 1;
  int32 attacker_id = 2;
  float damage = 3;
  Position direction = 4;
  int32 weapon_def_id = 5;
  bool paralyzer = 6;
}

// EVENT_ENEMY_DESTROYED (18)
message EnemyDestroyedEvent {
  int32 enemy_id = 1;
  int32 attacker_id = 2;
  int32 weapon_def_id = 3;
}

// EVENT_WEAPON_FIRED (19)
message WeaponFiredEvent {
  int32 unit_id = 1;
  int32 weapon_def_id = 2;
}

// EVENT_PLAYER_COMMAND (20)
message PlayerCommandEvent {
  repeated int32 unit_ids = 1;
  int32 command_topic_id = 2;
  int32 player_id = 3;
}

// EVENT_SEISMIC_PING (21)
message SeismicPingEvent {
  Position position = 1;
  float strength = 2;
}

// EVENT_COMMAND_FINISHED (22)
message CommandFinishedEvent {
  int32 unit_id = 1;
  int32 command_id = 2;
  int32 command_topic_id = 3;
}

// EVENT_LOAD (23)
message LoadEvent {
  string file_path = 1;
}

// EVENT_SAVE (24)
message SaveEvent {
  string file_path = 1;
}

// EVENT_ENEMY_CREATED (25)
message EnemyCreatedEvent {
  int32 enemy_id = 1;
}

// EVENT_ENEMY_FINISHED (26)
message EnemyFinishedEvent {
  int32 enemy_id = 1;
}

// EVENT_LUA_MESSAGE (27)
message LuaMessageEvent {
  string data = 1;
}
```

---

## Commands (AI -> Engine)

```protobuf
syntax = "proto3";
package highbar.v2;

import "highbar/v2/types.proto";

// Batch of commands to execute in a single frame
message CommandBatch {
  int32 frame = 1;
  repeated UnitCommand commands = 2;
  repeated EngineCommand engine_commands = 3;
}

// A command directed at a specific unit
message UnitCommand {
  int32 unit_id = 1;
  CommandOptions options = 2;
  
  oneof command {
    // Movement & Combat
    MoveCommand move = 10;
    PatrolCommand patrol = 11;
    FightCommand fight = 12;
    AttackUnitCommand attack_unit = 13;
    AttackAreaCommand attack_area = 14;
    GuardCommand guard = 15;
    StopCommand stop = 16;
    
    // Construction
    BuildCommand build = 20;
    RepairCommand repair = 21;
    ReclaimUnitCommand reclaim_unit = 22;
    ReclaimAreaCommand reclaim_area = 23;
    ReclaimFeatureCommand reclaim_feature = 24;
    ResurrectCommand resurrect = 25;
    ResurrectAreaCommand resurrect_area = 26;
    RestoreAreaCommand restore_area = 27;
    CaptureUnitCommand capture_unit = 28;
    CaptureAreaCommand capture_area = 29;
    
    // Transport
    LoadUnitsCommand load_units = 30;
    LoadUnitsAreaCommand load_units_area = 31;
    LoadOntoCommand load_onto = 32;
    UnloadUnitCommand unload_unit = 33;
    UnloadUnitsAreaCommand unload_units_area = 34;
    
    // State
    SetFireStateCommand set_fire_state = 40;
    SetMoveStateCommand set_move_state = 41;
    SetOnOffCommand set_on_off = 42;
    CloakCommand cloak = 43;
    StockpileCommand stockpile = 44;
    DGunCommand dgun = 45;
    DGunPosCommand dgun_pos = 46;
    SelfDestroyCommand self_destroy = 47;
    SetRepeatCommand set_repeat = 48;
    SetIdleModeCommand set_idle_mode = 49;
    SetAutoRepairLevelCommand set_auto_repair = 50;
    SetTrajectoryCommand set_trajectory = 51;
    
    // Wait
    WaitCommand wait = 55;
    TimeWaitCommand time_wait = 56;
    DeathWaitCommand death_wait = 57;
    SquadWaitCommand squad_wait = 58;
    GatherWaitCommand gather_wait = 59;
    
    // Custom
    CustomCommand custom = 60;
  }
}

// Non-unit-specific engine commands
message EngineCommand {
  oneof command {
    SendTextMessageCommand send_text = 10;
    CallLuaRulesCommand call_lua_rules = 11;
    CallLuaUICommand call_lua_ui = 12;
    SendResourcesCommand send_resources = 13;
    SendUnitsCommand send_units = 14;
    PauseCommand pause = 15;
    
    // Drawing
    DrawPointCommand draw_point = 20;
    DrawLineCommand draw_line = 21;
    RemovePointCommand remove_point = 22;
    
    // Cheats
    CheatGiveResourceCommand cheat_give_resource = 30;
    CheatGiveUnitCommand cheat_give_unit = 31;
    CheatSetIncomeMultiplierCommand cheat_set_income = 32;
  }
}

// --- Individual command messages ---

message MoveCommand {
  Position target = 1;
}

message PatrolCommand {
  Position target = 1;
}

message FightCommand {
  Position target = 1;
}

message AttackUnitCommand {
  int32 target_unit_id = 1;
}

message AttackAreaCommand {
  Position target = 1;
  float radius = 2;
}

message GuardCommand {
  int32 target_unit_id = 1;
}

message StopCommand {}

message BuildCommand {
  int32 unit_def_id = 1;   // what to build
  Position position = 2;
  int32 facing = 3;        // 0=south, 1=east, 2=north, 3=west
}

message RepairCommand {
  int32 target_unit_id = 1;
}

message ReclaimUnitCommand {
  int32 target_unit_id = 1;
}

message ReclaimAreaCommand {
  Position target = 1;
  float radius = 2;
}

message ReclaimFeatureCommand {
  int32 feature_id = 1;
}

message ResurrectCommand {
  int32 feature_id = 1;
}

message ResurrectAreaCommand {
  Position target = 1;
  float radius = 2;
}

message RestoreAreaCommand {
  Position target = 1;
  float radius = 2;
}

message CaptureUnitCommand {
  int32 target_unit_id = 1;
}

message CaptureAreaCommand {
  Position target = 1;
  float radius = 2;
}

message LoadUnitsCommand {
  repeated int32 unit_ids = 1;
}

message LoadUnitsAreaCommand {
  Position target = 1;
  float radius = 2;
}

message LoadOntoCommand {
  int32 transport_id = 1;
}

message UnloadUnitCommand {
  Position target = 1;
  int32 unit_id = 2;
}

message UnloadUnitsAreaCommand {
  Position target = 1;
  float radius = 2;
}

message SetFireStateCommand {
  int32 state = 1;  // 0=hold, 1=return, 2=fire at will
}

message SetMoveStateCommand {
  int32 state = 1;  // 0=hold, 1=maneuver, 2=roam
}

message SetOnOffCommand {
  bool on = 1;
}

message CloakCommand {
  bool cloak = 1;
}

message StockpileCommand {}

message DGunCommand {
  int32 target_unit_id = 1;
}

message DGunPosCommand {
  Position target = 1;
}

message SelfDestroyCommand {}

message SetRepeatCommand {
  bool repeat = 1;
}

message SetIdleModeCommand {
  int32 mode = 1;
}

message SetAutoRepairLevelCommand {
  int32 level = 1;
}

message SetTrajectoryCommand {
  int32 trajectory = 1;
}

message WaitCommand {}

message TimeWaitCommand {
  int32 time = 1;  // in frames
}

message DeathWaitCommand {
  int32 unit_id = 1;  // wait until this unit dies
}

message SquadWaitCommand {
  int32 num_units = 1;
}

message GatherWaitCommand {}

message CustomCommand {
  int32 cmd_id = 1;
  repeated float params = 2;
}

// --- Engine commands ---

message SendTextMessageCommand {
  string text = 1;
  int32 zone = 2;
}

message CallLuaRulesCommand {
  string data = 1;
}

message CallLuaUICommand {
  string data = 1;
}

message SendResourcesCommand {
  int32 to_team = 1;
  float metal = 2;
  float energy = 3;
}

message SendUnitsCommand {
  repeated int32 unit_ids = 1;
  int32 to_team = 2;
}

message PauseCommand {
  bool pause = 1;
}

message DrawPointCommand {
  Position position = 1;
  string label = 2;
}

message DrawLineCommand {
  Position from = 1;
  Position to = 2;
}

message RemovePointCommand {
  Position position = 1;
}

message CheatGiveResourceCommand {
  int32 resource_id = 1;
  float amount = 2;
}

message CheatGiveUnitCommand {
  int32 unit_def_id = 1;
  Position position = 2;
}

message CheatSetIncomeMultiplierCommand {
  float multiplier = 1;
}
```

---

## Callback Queries (Bidirectional)

```protobuf
syntax = "proto3";
package highbar.v2;

import "highbar/v2/types.proto";

message CallbackRequest {
  uint64 request_id = 1;
  
  oneof query {
    // Game state
    GetCurrentFrameQuery get_current_frame = 10;
    GetMyTeamQuery get_my_team = 11;
    GetMyAllyTeamQuery get_my_ally_team = 12;
    GetTeamsQuery get_teams = 13;
    IsAlliedQuery is_allied = 14;
    
    // Economy
    GetResourceStateQuery get_resource_state = 20;
    
    // Units
    GetTeamUnitsQuery get_team_units = 30;
    GetFriendlyUnitsQuery get_friendly_units = 31;
    GetEnemyUnitsQuery get_enemy_units = 32;
    GetNeutralUnitsQuery get_neutral_units = 33;
    GetEnemyUnitsInQuery get_enemy_units_in = 34;
    GetUnitPositionQuery get_unit_position = 35;
    GetUnitHealthQuery get_unit_health = 36;
    GetUnitDefQuery get_unit_def = 37;
    GetUnitVelocityQuery get_unit_velocity = 38;
    GetUnitCommandsQuery get_unit_commands = 39;
    IsUnitActivatedQuery is_unit_activated = 40;
    IsUnitBeingBuiltQuery is_unit_being_built = 41;
    IsUnitCloakedQuery is_unit_cloaked = 42;
    
    // Unit definitions
    GetUnitDefsQuery get_unit_defs = 50;
    GetUnitDefByNameQuery get_unit_def_by_name = 51;
    GetUnitDefDetailsQuery get_unit_def_details = 52;
    GetUnitDefBuildOptionsQuery get_unit_def_build_options = 53;
    
    // Map
    GetMapSizeQuery get_map_size = 60;
    GetHeightMapQuery get_height_map = 61;
    GetSlopeMapQuery get_slope_map = 62;
    GetLosMapQuery get_los_map = 63;
    GetRadarMapQuery get_radar_map = 64;
    GetResourceMapQuery get_resource_map = 65;
    GetResourceSpotsQuery get_resource_spots = 66;
    GetElevationAtQuery get_elevation_at = 67;
    IsPossibleToBuildAtQuery is_possible_to_build_at = 68;
    FindClosestBuildSiteQuery find_closest_build_site = 69;
    
    // Features
    GetFeaturesQuery get_features = 70;
    GetFeaturesInQuery get_features_in = 71;
    GetFeatureDefQuery get_feature_def = 72;
    
    // Weapon definitions
    GetWeaponDefQuery get_weapon_def = 80;
    
    // Pathfinding
    InitPathQuery init_path = 90;
    GetNextWaypointQuery get_next_waypoint = 91;
    GetPathLengthQuery get_path_length = 92;
    FreePathQuery free_path = 93;
  }
}

message CallbackResponse {
  uint64 request_id = 1;
  bool success = 2;
  string error = 3;
  
  oneof result {
    int32 int_value = 10;
    float float_value = 11;
    bool bool_value = 12;
    string string_value = 13;
    Position position_value = 14;
    UnitList unit_list = 15;
    UnitDefInfo unit_def_info = 16;
    UnitDefList unit_def_list = 17;
    MapData map_data = 18;
    ResourceSpotList resource_spots = 19;
    ResourceStateResult resource_state = 20;
    FeatureList feature_list = 21;
    WeaponDefInfo weapon_def_info = 22;
    UnitState unit_state = 23;
    CommandList command_list = 24;
    PathResult path_result = 25;
  }
}

// --- Query parameter messages ---

message GetCurrentFrameQuery {}
message GetMyTeamQuery {}
message GetMyAllyTeamQuery {}
message GetTeamsQuery {}
message IsAlliedQuery { int32 team_a = 1; int32 team_b = 2; }
message GetResourceStateQuery { int32 resource_id = 1; }

message GetTeamUnitsQuery {}
message GetFriendlyUnitsQuery {}
message GetEnemyUnitsQuery {}
message GetNeutralUnitsQuery {}
message GetEnemyUnitsInQuery { Position center = 1; float radius = 2; }
message GetUnitPositionQuery { int32 unit_id = 1; }
message GetUnitHealthQuery { int32 unit_id = 1; }
message GetUnitDefQuery { int32 unit_id = 1; }
message GetUnitVelocityQuery { int32 unit_id = 1; }
message GetUnitCommandsQuery { int32 unit_id = 1; }
message IsUnitActivatedQuery { int32 unit_id = 1; }
message IsUnitBeingBuiltQuery { int32 unit_id = 1; }
message IsUnitCloakedQuery { int32 unit_id = 1; }

message GetUnitDefsQuery {}
message GetUnitDefByNameQuery { string name = 1; }
message GetUnitDefDetailsQuery { int32 unit_def_id = 1; }
message GetUnitDefBuildOptionsQuery { int32 unit_def_id = 1; }

message GetMapSizeQuery {}
message GetHeightMapQuery {}
message GetSlopeMapQuery {}
message GetLosMapQuery {}
message GetRadarMapQuery {}
message GetResourceMapQuery { int32 resource_id = 1; }
message GetResourceSpotsQuery { int32 resource_id = 1; }
message GetElevationAtQuery { float x = 1; float z = 2; }
message IsPossibleToBuildAtQuery { int32 unit_def_id = 1; Position pos = 2; int32 facing = 3; }
message FindClosestBuildSiteQuery { int32 unit_def_id = 1; Position pos = 2; float search_radius = 3; int32 min_dist = 4; int32 facing = 5; }

message GetFeaturesQuery {}
message GetFeaturesInQuery { Position center = 1; float radius = 2; }
message GetFeatureDefQuery { int32 feature_id = 1; }

message GetWeaponDefQuery { int32 weapon_def_id = 1; }

message InitPathQuery { Position start = 1; Position end = 2; int32 path_type = 3; float goal_radius = 4; }
message GetNextWaypointQuery { int32 path_id = 1; }
message GetPathLengthQuery { Position start = 1; Position end = 2; int32 path_type = 3; float goal_radius = 4; }
message FreePathQuery { int32 path_id = 1; }

// --- Response data messages ---

message UnitList { repeated int32 unit_ids = 1; }
message UnitDefList { repeated UnitDefSummary defs = 1; }
message UnitDefSummary { int32 id = 1; string name = 2; string human_name = 3; }

message UnitDefInfo {
  int32 id = 1;
  string name = 2;
  string human_name = 3;
  float health = 4;
  float speed = 5;
  float power = 6;
  float metal_cost = 7;
  float energy_cost = 8;
  float build_time = 9;
  float mass = 10;
  bool is_builder = 11;
  bool can_fly = 12;
  bool can_move = 13;
  bool can_attack = 14;
  bool can_cloak = 15;
  float los_radius = 16;
  float radar_radius = 17;
  float sonar_radius = 18;
  int32 weapon_count = 19;
  repeated int32 build_options = 20;
  repeated KeyValue custom_params = 21;
}

message MapData {
  int32 width = 1;
  int32 height = 2;
  bytes data = 3;     // raw float or int data, format depends on query
}

message ResourceSpotList {
  repeated ResourceSpot spots = 1;
}

message ResourceSpot {
  Position position = 1;
  float income = 2;
}

message ResourceStateResult {
  ResourceState state = 1;
}

message FeatureList {
  repeated int32 feature_ids = 1;
}

message WeaponDefInfo {
  int32 id = 1;
  string name = 2;
  string type = 3;
  float range = 4;
  float accuracy = 5;
  float reload_time = 6;
  float area_of_effect = 7;
  repeated KeyValue custom_params = 8;
}

message UnitState {
  int32 unit_id = 1;
  int32 unit_def_id = 2;
  int32 team = 3;
  float health = 4;
  float max_health = 5;
  float experience = 6;
  float speed = 7;
  float power = 8;
  Position position = 9;
  Position velocity = 10;
  bool activated = 11;
  bool being_built = 12;
  bool cloaked = 13;
  bool paralyzed = 14;
}

message CommandList {
  repeated CurrentCommand commands = 1;
}

message CurrentCommand {
  int32 cmd_id = 1;
  repeated float params = 2;
  int32 tag = 3;
}

message PathResult {
  int32 path_id = 1;
  float length = 2;
  Position next_waypoint = 3;
}
```

---

## Frame-Level Messages

```protobuf
syntax = "proto3";
package highbar.v2;

import "highbar/v2/types.proto";
import "highbar/v2/events.proto";

// Handshake (first message after connection)
message Handshake {
  uint32 protocol_version = 1;  // current: 2
  string engine_version = 2;
  string game_name = 3;
  string map_name = 4;
  int32 my_team = 5;
  int32 my_ally_team = 6;
}

message HandshakeAck {
  uint32 protocol_version = 1;
  string client_name = 2;
  string client_version = 3;
}

message Shutdown {
  string reason = 1;
}

message Heartbeat {
  uint64 timestamp = 1;
}

// Batched frame update (all events for one frame)
message FrameUpdate {
  int32 frame = 1;
  repeated GameEvent events = 2;
  
  // Optional pushed state (configurable)
  GameStateSnapshot state = 3;
}

message GameEvent {
  oneof event {
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
    EnemyEnterLosEvent enemy_enter_los = 13;
    EnemyLeaveLosEvent enemy_leave_los = 14;
    EnemyEnterRadarEvent enemy_enter_radar = 15;
    EnemyLeaveRadarEvent enemy_leave_radar = 16;
    EnemyDamagedEvent enemy_damaged = 17;
    EnemyDestroyedEvent enemy_destroyed = 18;
    WeaponFiredEvent weapon_fired = 19;
    PlayerCommandEvent player_command = 20;
    SeismicPingEvent seismic_ping = 21;
    CommandFinishedEvent command_finished = 22;
    EnemyCreatedEvent enemy_created = 25;
    EnemyFinishedEvent enemy_finished = 26;
    LuaMessageEvent lua_message = 27;
  }
}

// Optional game state pushed with frame updates
message GameStateSnapshot {
  Resources resources = 1;
  repeated UnitState own_units = 2;
  repeated UnitState enemy_units = 3;
  repeated UnitState friendly_units = 4;
  repeated UnitState neutral_units = 5;
}
```

---

## Notes

- Field numbers in `GameEvent.oneof` match the engine's topic IDs where possible
- `bytes` fields in `MapData` carry raw float/int arrays for heightmaps, slopemaps, etc. -- avoids repeated float overhead
- `CallbackRequest`/`CallbackResponse` are the escape hatch for any callback function not covered by pushed state
- The schema is designed so that `proto3` works (zero-defaults are acceptable for game state since unit IDs and def IDs are always > 0 for valid entities, and -1 is used for "no attacker" which maps to default 0 in proto3 -- the proxy should translate -1 -> 0 and document this)
