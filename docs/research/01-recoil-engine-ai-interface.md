# RecoilEngine AI Interface -- Complete Technical Reference

## Architecture Overview

The BAR (Beyond All Reason) game uses the **Recoil engine**, a hard fork of the Spring RTS engine. The AI system has a three-layer plugin architecture:

1. **Engine Core** (`rts/ExternalAI/`) -- manages AI lifecycle and dispatches events
2. **AI Interface Layer** (`AI/Interfaces/C/`) -- shared-library plugin that bridges engine to AI implementations
3. **Skirmish AI Libraries** (`AI/Skirmish/`) -- actual AI implementations (e.g., CircuitAI, NullAI)

All communication is **in-process** via direct function calls through loaded shared libraries. There is **no existing out-of-process IPC mechanism**.

---

## AI Loading Sequence

1. Engine scans `AI/Interfaces/` for interface shared libraries
2. Loads the C interface (`libAIInterface.so`) and calls `initStatic()`
3. `SkirmishAIHandler::LoadFromSetup()` processes game config for AI assignments
4. Interface's `loadSkirmishAILibrary()` loads the AI `.so`/`.dll` via `dlopen`/`LoadLibrary`
5. Resolves exported symbols into `SSkirmishAILibrary` struct
6. `CSkirmishAIWrapper` creates `SSkirmishAICallback` and calls `init()` + `EVENT_INIT`

### Minimal AI Export Requirements

```c
// Required
EXPORT(int) handleEvent(int skirmishAIId, int topic, const void* data);

// Optional
EXPORT(int) init(int skirmishAIId, const struct SSkirmishAICallback* callback);
EXPORT(int) release(int skirmishAIId);
EXPORT(int) getLevelOfSupportFor(const char* engineVersion, int engineAIVersion, const char* aiInterfaceShortName, const char* aiInterfaceVersion);
```

### Lifecycle

```
init() -> EVENT_INIT -> [EVENT_UPDATE + other events per frame] -> EVENT_RELEASE -> release()
```

### File System Layout

```
AI/
  Interfaces/
    C/0.1/
      libAIInterface.so
  Skirmish/
    MyAI/0.1/
      libSkirmishAI.so
      AIInfo.lua          # metadata (name, version, description)
      AIOptions.lua       # configurable options
```

---

## The Callback Interface (SSkirmishAICallback)

Defined in `rts/ExternalAI/Interface/SSkirmishAICallback.h` (2265 lines). A C struct of function pointers passed to the AI at initialization. All functions take `int skirmishAIId` as first parameter. **Read-only** -- queries game state but never modifies it.

### Engine Info
- `Engine_handleCommand`, `Engine_executeCommand`
- `Engine_Version_getMajor/getHash/getBranch/getFull`

### Game State
- `Game_getCurrentFrame`, `Game_getMyTeam`, `Game_getMyAllyTeam`
- `Game_getTeams`, `Game_getTeamSide`, `Game_getTeamColor`
- `Game_getTeamResourceCurrent/Income/Usage/Storage`
- `Game_isAllied`, `Game_isPaused`, `Game_getSpeedFactor`
- `Game_getSetupScript`, `Game_getRulesParamFloat/String`
- `Game_getCategoryFlag/getCategoriesFlag`

### Economy
- `Economy_getCurrent/getIncome/getUsage/getStorage`
- `Economy_getPull/getShare/getSent/getReceived/getExcess` (all per-resource)

### Unit Definitions (Static Data)
- `getUnitDefs`, `getUnitDefByName` -- enumerate all unit types
- `UnitDef_getName/getHumanName/getHealth/getSpeed/getCost/getBuildTime/getMass`
- `UnitDef_isBuilder/isAbleToFly/isAbleToMove/isAbleToAttack/isAbleToCloak`
- `UnitDef_getLosRadius/getRadarRadius/getSonarRadius`
- `UnitDef_getBuildOptions` -- what this unit can build
- `UnitDef_getWeaponMounts`, `UnitDef_WeaponMount_*`
- `UnitDef_MoveData_*` -- pathfinding properties
- `UnitDef_FlankingBonus_*`, `UnitDef_getCustomParams`

### Live Units
- `getTeamUnits`, `getFriendlyUnits`, `getEnemyUnits`, `getNeutralUnits`
- `getEnemyUnitsIn`, `getFriendlyUnitsIn` -- spatial queries
- `Unit_getDef`, `Unit_getTeam`, `Unit_getAllyTeam`
- `Unit_getHealth/getMaxHealth/getSpeed/getMaxRange/getExperience/getPower`
- `Unit_getPos/getVel` -- position and velocity (float3)
- `Unit_isActivated/isBeingBuilt/isCloaked/isParalyzed`
- `Unit_getCurrentCommands`, `Unit_getSupportedCommands`
- `Unit_getRulesParamFloat/String`
- `Unit_getWeapons`, `Unit_Weapon_getDef/getReloadFrame/getRange/getShieldPower`

### Map
- `Map_getWidth/getHeight`
- `Map_getHeightMap/getCornersHeightMap/getSlopeMap`
- `Map_getLosMap/getAirLosMap/getRadarMap/getSonarMap/getSeismicMap/getJammerMap`
- `Map_getResourceMapRaw/getResourceMapSpotsPositions/getResourceMapSpotsAverageIncome`
- `Map_getElevationAt`, `Map_isPossibleToBuildAt`, `Map_findClosestBuildSite`
- `Map_getMinWind/getMaxWind/getCurWind/getTidalStrength/getGravity`
- `Map_getSpeedModMap/getHardnessModMap`

### Features (Map Objects/Wrecks)
- `getFeatures/getFeaturesIn`
- `Feature_getDef/getHealth/getReclaimLeft/getPosition/getResurrectDef`

### Weapon Definitions
- `WeaponDef_getName/getType/getRange/getAccuracy/getReload/getAreaOfEffect`
- Damage types, shield properties, projectile properties, custom params

### Pathfinding
- `COMMAND_PATH_INIT` (returns pathId)
- `COMMAND_PATH_GET_APPROXIMATE_LENGTH`
- `COMMAND_PATH_GET_NEXT_WAYPOINT`
- `COMMAND_PATH_FREE`

### Data/Logging
- `DataDirs_getConfigDir/getWriteableDir/locatePath`
- `Log_log`, `Log_exception`
- `Cheats_isEnabled/setEnabled/setEventsEnabled/isOnlyPassive`

---

## Event System (Engine -> AI)

Defined in `rts/ExternalAI/Interface/AISEvents.h`. Events are delivered through `handleEvent(skirmishAIId, topicId, data)` where `data` is a pointer to an event-specific C struct. **28 event topics:**

| ID | Event | Struct | Key Fields |
|----|-------|--------|------------|
| 1 | EVENT_INIT | SInitEvent | skirmishAIId, callback pointer, savedGame flag |
| 2 | EVENT_RELEASE | SReleaseEvent | reason (0-7: unspecified, game ended, team died, AI killed, crashed, failed init, connection lost, other) |
| 3 | EVENT_UPDATE | SUpdateEvent | frame number |
| 4 | EVENT_MESSAGE | SMessageEvent | player, message string |
| 5 | EVENT_UNIT_CREATED | SUnitCreatedEvent | unit, builder |
| 6 | EVENT_UNIT_FINISHED | SUnitFinishedEvent | unit |
| 7 | EVENT_UNIT_IDLE | SUnitIdleEvent | unit |
| 8 | EVENT_UNIT_MOVE_FAILED | SUnitMoveFailedEvent | unit |
| 9 | EVENT_UNIT_DAMAGED | SUnitDamagedEvent | unit, attacker (-1 if unknown), damage, dir_posF3, weaponDefId, paralyzer |
| 10 | EVENT_UNIT_DESTROYED | SUnitDestroyedEvent | unit, attacker, weaponDefID |
| 11 | EVENT_UNIT_GIVEN | SUnitGivenEvent | unit, oldTeamId, newTeamId |
| 12 | EVENT_UNIT_CAPTURED | SUnitCapturedEvent | unit, oldTeamId, newTeamId |
| 13 | EVENT_ENEMY_ENTER_LOS | SEnemyEnterLOSEvent | enemy |
| 14 | EVENT_ENEMY_LEAVE_LOS | SEnemyLeaveLOSEvent | enemy |
| 15 | EVENT_ENEMY_ENTER_RADAR | SEnemyEnterRadarEvent | enemy |
| 16 | EVENT_ENEMY_LEAVE_RADAR | SEnemyLeaveRadarEvent | enemy |
| 17 | EVENT_ENEMY_DAMAGED | SEnemyDamagedEvent | enemy, attacker, damage, dir, weaponDefId |
| 18 | EVENT_ENEMY_DESTROYED | SEnemyDestroyedEvent | enemy, attacker |
| 19 | EVENT_WEAPON_FIRED | SWeaponFiredEvent | unit, weaponDefId |
| 20 | EVENT_PLAYER_COMMAND | SPlayerCommandEvent | unitIds array, commandTopicId, playerId |
| 21 | EVENT_SEISMIC_PING | SSeismicPingEvent | position, strength |
| 22 | EVENT_COMMAND_FINISHED | SCommandFinishedEvent | unit, commandId, commandTopicId |
| 23 | EVENT_LOAD | SLoadEvent | file path |
| 24 | EVENT_SAVE | SSaveEvent | file path |
| 25 | EVENT_ENEMY_CREATED | SEnemyCreatedEvent | enemy |
| 26 | EVENT_ENEMY_FINISHED | SEnemyFinishedEvent | enemy |
| 27 | EVENT_LUA_MESSAGE | SLuaMessageEvent | inData string |

---

## Command System (AI -> Engine)

Defined in `rts/ExternalAI/Interface/AISCommands.h`. All state-changing actions go through:

```c
callback->Engine_handleCommand(skirmishAIId, toId, commandId, commandTopic, commandData);
```

**97 command topics.** All unit commands support `UnitCommandOptions` bitfield: `SHIFT_KEY` (queue), `CONTROL_KEY`, `ALT_KEY`, `RIGHT_MOUSE_KEY`, `INTERNAL_ORDER`. Commands can have a `timeOut` frame for auto-expiry.

### Unit Movement & Combat
| Command | Struct | Description |
|---------|--------|-------------|
| COMMAND_UNIT_MOVE (42) | SMoveUnitCommand | Move to position |
| COMMAND_UNIT_PATROL (43) | SPatrolUnitCommand | Patrol to position |
| COMMAND_UNIT_FIGHT (44) | SFightUnitCommand | Attack-move to position |
| COMMAND_UNIT_ATTACK (45) | SAttackUnitCommand | Attack specific unit |
| COMMAND_UNIT_ATTACK_AREA (46) | SAttackAreaUnitCommand | Attack area (position + radius) |
| COMMAND_UNIT_GUARD (47) | SGuardUnitCommand | Guard another unit |
| COMMAND_UNIT_STOP (36) | SStopUnitCommand | Stop all actions |
| COMMAND_UNIT_SET_FIRE_STATE (52) | SSetFireStateUnitCommand | 0=hold, 1=return, 2=fire at will |
| COMMAND_UNIT_SET_MOVE_STATE (53) | SSetMoveStateUnitCommand | 0=hold, 1=maneuver, 2=roam |

### Construction
| Command | Struct | Description |
|---------|--------|-------------|
| COMMAND_UNIT_BUILD (35) | SBuildUnitCommand | Build unit/structure at position with facing |
| COMMAND_UNIT_REPAIR (51) | SRepairUnitCommand | Repair a unit |
| COMMAND_UNIT_RECLAIM_UNIT (63) | SReclaimUnitUnitCommand | Reclaim a unit |
| COMMAND_UNIT_RECLAIM_FEATURE (82) | SReclaimFeatureUnitCommand | Reclaim a feature (wreckage) |
| COMMAND_UNIT_RECLAIM_AREA (64) | SReclaimAreaUnitCommand | Reclaim in area |
| COMMAND_UNIT_RESTORE_AREA (69) | SRestoreAreaUnitCommand | Restore terrain |
| COMMAND_UNIT_RESURRECT (72) | SResurrectUnitCommand | Resurrect from wreckage |
| COMMAND_UNIT_CAPTURE (74) | SCaptureUnitCommand | Capture enemy unit |

### Transport
| Command | Struct | Description |
|---------|--------|-------------|
| COMMAND_UNIT_LOAD_UNITS (57) | SLoadUnitsUnitCommand | Load units into transport |
| COMMAND_UNIT_LOAD_ONTO (59) | SLoadOntoUnitCommand | Load onto transport |
| COMMAND_UNIT_UNLOAD_UNIT (61) | SUnloadUnitCommand | Unload unit at position |
| COMMAND_UNIT_UNLOAD_UNITS_AREA (60) | SUnloadUnitsAreaUnitCommand | Unload in area |

### Unit State
| Command | Struct | Description |
|---------|--------|-------------|
| COMMAND_UNIT_SET_ON_OFF (62) | SSetOnOffUnitCommand | Toggle on/off |
| COMMAND_UNIT_CLOAK (65) | SCloakUnitCommand | Toggle cloak |
| COMMAND_UNIT_STOCKPILE (66) | SStockpileUnitCommand | Stockpile production |
| COMMAND_UNIT_D_GUN (67) | SDGunUnitCommand | D-Gun target unit |
| COMMAND_UNIT_D_GUN_POS (68) | SDGunPosUnitCommand | D-Gun target position |
| COMMAND_UNIT_SELF_DESTROY (55) | SSelfDestroyUnitCommand | Self-destruct |
| COMMAND_UNIT_SET_REPEAT (70) | SSetRepeatUnitCommand | Toggle command repeat |
| COMMAND_UNIT_CUSTOM (78) | SCustomUnitCommand | Arbitrary cmd with cmdId and params |

### Wait Commands
- COMMAND_UNIT_WAIT (37), COMMAND_UNIT_WAIT_TIME (38), COMMAND_UNIT_WAIT_DEATH (39)
- COMMAND_UNIT_WAIT_SQUAD (40), COMMAND_UNIT_WAIT_GATHER (41)

### Communication
| Command | Struct | Description |
|---------|--------|-------------|
| COMMAND_SEND_TEXT_MESSAGE | SSendTextMessageCommand | Send chat message |
| COMMAND_CALL_LUA_RULES (21) | SCallLuaRulesCommand | Call LuaRules gadgets (max 10240 byte response) |
| COMMAND_CALL_LUA_UI (96) | SCallLuaUICommand | Call LuaUI widgets |

### Economy & Diplomacy
- COMMAND_SEND_RESOURCES (8) -- transfer resources
- COMMAND_SEND_UNITS (9) -- transfer units to another team
- COMMAND_SEND_START_POS -- send start position

### Debug/Drawing
- COMMAND_DRAWER_POINT_ADD/LINE_ADD/POINT_REMOVE
- Figure drawing (splines, lines), path drawing
- Debug graph/overlay texture drawing

### Cheats (when enabled)
- COMMAND_CHEATS_SET_MY_INCOME_MULTIPLIER (5)
- COMMAND_CHEATS_GIVE_ME_RESOURCE (20)
- COMMAND_CHEATS_GIVE_ME_NEW_UNIT (79)

### Other
- COMMAND_TRACE_RAY/TRACE_RAY_FEATURE -- raycasting
- COMMAND_PAUSE -- pause/unpause game

---

## Key Source Files

| File | Description |
|------|-------------|
| `rts/ExternalAI/Interface/SSkirmishAICallback.h` | Main callback struct (2265 lines, all query functions) |
| `rts/ExternalAI/Interface/AISEvents.h` | All 28 event definitions with structs |
| `rts/ExternalAI/Interface/AISCommands.h` | All 97 command definitions with structs |
| `rts/ExternalAI/Interface/SSkirmishAILibrary.h` | AI library interface (init/release/handleEvent) |
| `rts/ExternalAI/Interface/SAIInterfaceLibrary.h` | AI Interface plugin interface |
| `rts/ExternalAI/Interface/SAIInterfaceCallback.h` | Callback given to AI Interfaces |
| `rts/ExternalAI/Interface/aidefines.h` | ABI versioning, constants |
| `rts/ExternalAI/EngineOutHandler.h` | Engine-side event dispatcher |
| `rts/ExternalAI/SkirmishAIHandler.h` | AI lifecycle management |
| `rts/ExternalAI/SkirmishAIWrapper.h/.cpp` | Per-instance wrapper, event routing |
| `rts/ExternalAI/SkirmishAILibrary.h` | Engine-side wrapper for loaded AI lib |
| `rts/ExternalAI/AIInterfaceLibrary.h` | Engine-side wrapper for loaded interface lib |
| `rts/ExternalAI/SSkirmishAICallbackImpl.h` | Implementation of all callback functions |
| `AI/Interfaces/C/src/Interface.cpp` | C Interface: loads AI shared libraries via dlopen |
| `AI/Skirmish/NullAI/src/AIExport.c` | Minimal example AI (exports handleEvent returning 0) |

---

## Important Notes for Proxy Design

1. **Blocking behavior**: If an AI is slow to respond to `handleEvent()`, the engine blocks and waits. It does not skip frames for native AIs.
2. **No existing IPC**: There are zero pipes, sockets, message queues, or other IPC mechanisms. All AIs must be compiled as native shared libraries loaded into engine process space.
3. **Lua bridge**: `COMMAND_CALL_LUA_RULES` + `EVENT_LUA_MESSAGE` provide bidirectional string-based messaging between native AIs and Lua code, but this is still in-process.
4. **Legacy shared memory**: `CAICallback` had `CreateSharedMemArea()`/`ReleasedSharedMemArea()` but this is deprecated and was only for inter-AI communication.
