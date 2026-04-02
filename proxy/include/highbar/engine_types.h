#ifndef HIGHBAR_ENGINE_TYPES_H
#define HIGHBAR_ENGINE_TYPES_H

// Minimal definitions of Recoil engine types needed by the proxy.
// These mirror the engine's AISEvents.h, AISCommands.h, and SSkirmishAICallback.h.

#include <stdint.h>

// -- Event Topics (from AISEvents.h) --
enum EventTopic {
    EVENT_NULL            = 0,
    EVENT_INIT            = 1,
    EVENT_RELEASE         = 2,
    EVENT_UPDATE          = 3,
    EVENT_MESSAGE         = 4,
    EVENT_UNIT_CREATED    = 5,
    EVENT_UNIT_FINISHED   = 6,
    EVENT_UNIT_IDLE       = 7,
    EVENT_UNIT_MOVE_FAILED = 8,
    EVENT_UNIT_DAMAGED    = 9,
    EVENT_UNIT_DESTROYED  = 10,
    EVENT_UNIT_GIVEN      = 11,
    EVENT_UNIT_CAPTURED   = 12,
    EVENT_ENEMY_ENTER_LOS = 13,
    EVENT_ENEMY_LEAVE_LOS = 14,
    EVENT_ENEMY_ENTER_RADAR = 15,
    EVENT_ENEMY_LEAVE_RADAR = 16,
    EVENT_ENEMY_DAMAGED   = 17,
    EVENT_ENEMY_DESTROYED = 18,
    EVENT_WEAPON_FIRED    = 19,
    EVENT_PLAYER_COMMAND  = 20,
    EVENT_SEISMIC_PING    = 21,
    EVENT_COMMAND_FINISHED = 22,
    EVENT_LOAD            = 23,
    EVENT_SAVE            = 24,
    EVENT_ENEMY_CREATED   = 25,
    EVENT_ENEMY_FINISHED  = 26,
    EVENT_LUA_MESSAGE     = 27,
    EVENT_COUNT           = 28
};

// -- Event Structs (from AISEvents.h) --

struct SInitEvent {
    int team;
};

struct SReleaseEvent {
    int reason;
};

struct SUpdateEvent {
    int frame;
};

struct SMessageEvent {
    int player;
    const char *message;
};

struct SUnitCreatedEvent {
    int unit;
    int builder;
};

struct SUnitFinishedEvent {
    int unit;
};

struct SUnitIdleEvent {
    int unit;
};

struct SUnitMoveFailedEvent {
    int unit;
};

struct SUnitDamagedEvent {
    int unit;
    int attacker;    // -1 if no attacker
    float damage;
    float dir_x, dir_y, dir_z;
    int weaponDefId;
    int paralyzer;
};

struct SUnitDestroyedEvent {
    int unit;
    int attacker;    // -1 if no attacker
};

struct SUnitGivenEvent {
    int unit;
    int oldTeamId;
    int newTeamId;
};

struct SUnitCapturedEvent {
    int unit;
    int oldTeamId;
    int newTeamId;
};

struct SEnemyEnterLOSEvent {
    int enemy;
};

struct SEnemyLeaveLOSEvent {
    int enemy;
};

struct SEnemyEnterRadarEvent {
    int enemy;
};

struct SEnemyLeaveRadarEvent {
    int enemy;
};

struct SEnemyDamagedEvent {
    int enemy;
    int attacker;    // -1 if no attacker
    float damage;
    float dir_x, dir_y, dir_z;
    int weaponDefId;
};

struct SEnemyDestroyedEvent {
    int enemy;
    int attacker;    // -1 if no attacker
};

struct SWeaponFiredEvent {
    int unitId;
    int weaponDefId;
};

struct SPlayerCommandEvent {
    int *unitIds;
    int numUnitIds;
    int commandTopicId;
    int commandId;
};

struct SSeismicPingEvent {
    float pos_posF3[3];
    float strength;
};

struct SCommandFinishedEvent {
    int unitId;
    int commandId;
    int commandTopicId;
};

struct SLoadEvent {
    int placeholder;
};

struct SSaveEvent {
    int placeholder;
};

struct SEnemyCreatedEvent {
    int enemy;
};

struct SEnemyFinishedEvent {
    int enemy;
};

struct SLuaMessageEvent {
    const char *inData;
    int inMessageId;
};

// -- Command Topics (subset, from AISCommands.h) --
enum CommandTopic {
    COMMAND_NULL = 0,
    COMMAND_DRAW_ADD_POINT = 1,
    COMMAND_DRAW_ADD_LINE = 2,
    COMMAND_DRAW_REMOVE_POINT = 3,
    COMMAND_SEND_TEXT_MESSAGE = 4,
    COMMAND_SET_LAST_POS_MESSAGE = 5,
    COMMAND_SEND_RESOURCES = 6,
    COMMAND_SET_MY_INCOME_SHARE_DIRECT = 7,
    COMMAND_SET_SHARE_LEVEL = 8,
    COMMAND_PAUSE_TEAM = 9,
    COMMAND_GROUP_ADD_UNIT = 12,
    COMMAND_GROUP_REMOVE_UNIT = 13,
    COMMAND_INIT_PATH = 16,
    COMMAND_GET_APPROX_LENGTH = 17,
    COMMAND_GET_NEXT_WAYPOINT = 18,
    COMMAND_FREE_PATH = 19,
    COMMAND_GIVE_ME = 20,
    COMMAND_CALL_LUA_RULES = 21,
    COMMAND_CREATE_SPLINE_FIGURE = 22,
    COMMAND_CREATE_LINE_FIGURE = 23,
    COMMAND_SET_FIGURE_POSITION = 24,
    COMMAND_SET_FIGURE_COLOR = 25,
    COMMAND_REMOVE_FIGURE = 26,
    COMMAND_DRAW_UNIT = 27,
    COMMAND_BUILD_UNIT = 35,
    COMMAND_STOP = 36,
    COMMAND_WAIT = 37,
    COMMAND_TIMED_WAIT = 38,
    COMMAND_SQUAD_WAIT = 39,
    COMMAND_DEATH_WAIT = 40,
    COMMAND_GATHER_WAIT = 41,
    COMMAND_MOVE_UNIT = 42,
    COMMAND_PATROL = 43,
    COMMAND_FIGHT = 44,
    COMMAND_ATTACK = 45,
    COMMAND_ATTACK_AREA = 46,
    COMMAND_GUARD = 47,
    COMMAND_REPAIR = 48,
    COMMAND_RECLAIM_UNIT = 49,
    COMMAND_RECLAIM_AREA = 50,
    COMMAND_RECLAIM_IN_AREA = 51,
    COMMAND_RECLAIM_FEATURE = 52,
    COMMAND_RESTORE_AREA = 53,
    COMMAND_RESURRECT = 54,
    COMMAND_RESURRECT_IN_AREA = 55,
    COMMAND_CAPTURE = 56,
    COMMAND_CAPTURE_AREA = 57,
    COMMAND_SET_BASE = 58,
    COMMAND_SELF_DESTRUCT = 59,
    COMMAND_LOAD_UNITS = 60,
    COMMAND_LOAD_UNITS_AREA = 61,
    COMMAND_LOAD_ONTO = 62,
    COMMAND_UNLOAD_UNIT = 63,
    COMMAND_UNLOAD_UNITS_AREA = 64,
    COMMAND_SET_WANTED_MAX_SPEED = 65,
    COMMAND_STOCKPILE = 66,
    COMMAND_DGUN = 67,
    COMMAND_CUSTOM = 68,
    COMMAND_SET_ON_OFF = 69,
    COMMAND_SET_REPEAT = 70,
    COMMAND_SET_MOVE_STATE = 71,
    COMMAND_SET_FIRE_STATE = 72,
    COMMAND_SET_TRAJECTORY = 73,
    COMMAND_SET_AUTO_REPAIR_LEVEL = 74,
    COMMAND_SET_IDLE_MODE = 75,
    COMMAND_GIVE_ME_NEW_UNIT = 79,
    COMMAND_CALL_LUA_UI = 96,
};

// -- Command Structs (subset from AISCommands.h) --

struct SBuildUnitCommand {
    int unitId;
    int groupId;
    short options;
    int timeOut;
    int toBuildUnitDefId;
    float buildPos_posF3[3];
    int facing;
};

struct SStopCommand {
    int unitId;
    int groupId;
    short options;
    int timeOut;
};

struct SMoveUnitCommand {
    int unitId;
    int groupId;
    short options;
    int timeOut;
    float toPos_posF3[3];
};

struct SPatrolUnitCommand {
    int unitId;
    int groupId;
    short options;
    int timeOut;
    float toPos_posF3[3];
};

struct SFightUnitCommand {
    int unitId;
    int groupId;
    short options;
    int timeOut;
    float toPos_posF3[3];
};

struct SAttackUnitCommand {
    int unitId;
    int groupId;
    short options;
    int timeOut;
    int toAttackUnitId;
};

struct SAttackAreaCommand {
    int unitId;
    int groupId;
    short options;
    int timeOut;
    float toAttackPos_posF3[3];
    float radius;
};

struct SGuardUnitCommand {
    int unitId;
    int groupId;
    short options;
    int timeOut;
    int toGuardUnitId;
};

struct SRepairUnitCommand {
    int unitId;
    int groupId;
    short options;
    int timeOut;
    int toRepairUnitId;
};

struct SReclaimUnitCommand {
    int unitId;
    int groupId;
    short options;
    int timeOut;
    int toReclaimUnitIdOrFeatureId;
};

struct SReclaimAreaCommand {
    int unitId;
    int groupId;
    short options;
    int timeOut;
    float pos_posF3[3];
    float radius;
};

struct SRestoreAreaCommand {
    int unitId;
    int groupId;
    short options;
    int timeOut;
    float pos_posF3[3];
    float radius;
};

struct SResurrectCommand {
    int unitId;
    int groupId;
    short options;
    int timeOut;
    int toResurrectFeatureId;
};

struct SResurrectAreaCommand {
    int unitId;
    int groupId;
    short options;
    int timeOut;
    float pos_posF3[3];
    float radius;
};

struct SCaptureUnitCommand {
    int unitId;
    int groupId;
    short options;
    int timeOut;
    int toCaptureUnitId;
};

struct SCaptureAreaCommand {
    int unitId;
    int groupId;
    short options;
    int timeOut;
    float pos_posF3[3];
    float radius;
};

struct SSetBaseCommand {
    int unitId;
    int groupId;
    short options;
    int timeOut;
    float basePos_posF3[3];
};

struct SSelfDestructUnitCommand {
    int unitId;
    int groupId;
    short options;
    int timeOut;
};

struct SLoadUnitsCommand {
    int unitId;
    int groupId;
    short options;
    int timeOut;
    int *toLoadUnitIds;
    int numToLoadUnitIds;
};

struct SLoadUnitsAreaCommand {
    int unitId;
    int groupId;
    short options;
    int timeOut;
    float pos_posF3[3];
    float radius;
};

struct SLoadOntoCommand {
    int unitId;
    int groupId;
    short options;
    int timeOut;
    int transportUnitId;
};

struct SUnloadUnitCommand {
    int unitId;
    int groupId;
    short options;
    int timeOut;
    float toPos_posF3[3];
    int toUnloadUnitId;
};

struct SUnloadUnitsAreaCommand {
    int unitId;
    int groupId;
    short options;
    int timeOut;
    float toPos_posF3[3];
    float radius;
};

struct SSetWantedMaxSpeedCommand {
    int unitId;
    int groupId;
    short options;
    int timeOut;
    float wantedMaxSpeed;
};

struct SStockpileCommand {
    int unitId;
    int groupId;
    short options;
    int timeOut;
};

struct SDGunUnitCommand {
    int unitId;
    int groupId;
    short options;
    int timeOut;
    int toAttackUnitId;
};

struct SCustomCommand {
    int unitId;
    int groupId;
    short options;
    int timeOut;
    int cmdId;
    float *params;
    int numParams;
};

struct SWaitCommand {
    int unitId;
    int groupId;
    short options;
    int timeOut;
};

struct STimedWaitCommand {
    int unitId;
    int groupId;
    short options;
    int timeOut;
    int time;
};

struct SSquadWaitCommand {
    int unitId;
    int groupId;
    short options;
    int timeOut;
    int numUnits;
};

struct SDeathWaitCommand {
    int unitId;
    int groupId;
    short options;
    int timeOut;
    int unitId2;
};

struct SGatherWaitCommand {
    int unitId;
    int groupId;
    short options;
    int timeOut;
};

struct SSetOnOffCommand {
    int unitId;
    int groupId;
    short options;
    int timeOut;
    int on;
};

struct SSetRepeatCommand {
    int unitId;
    int groupId;
    short options;
    int timeOut;
    int repeat;
};

struct SSetMoveStateCommand {
    int unitId;
    int groupId;
    short options;
    int timeOut;
    int moveState;
};

struct SSetFireStateCommand {
    int unitId;
    int groupId;
    short options;
    int timeOut;
    int fireState;
};

struct SSetTrajectoryCommand {
    int unitId;
    int groupId;
    short options;
    int timeOut;
    int trajectory;
};

struct SSetAutoRepairLevelCommand {
    int unitId;
    int groupId;
    short options;
    int timeOut;
    int autoRepairLevel;
};

struct SSetIdleModeCommand {
    int unitId;
    int groupId;
    short options;
    int timeOut;
    int idleMode;
};

struct SSendTextMessageCommand {
    const char *text;
    int zone;
};

struct SSetLastPosMessageCommand {
    float pos_posF3[3];
};

struct SSendResourcesCommand {
    int resourceId;
    float amount;
    int receivingTeamId;
};

struct SSetMyIncomeShareDirectCommand {
    int resourceId;
    float share;
};

struct SSetShareLevelCommand {
    int resourceId;
    float shareLevel;
};

struct SPauseTeamCommand {
    int enable;
};

struct SGroupAddUnitCommand {
    int unitId;
    int groupId;
};

struct SGroupRemoveUnitCommand {
    int unitId;
    int groupId;
};

struct SInitPathCommand {
    float startPos_posF3[3];
    float endPos_posF3[3];
    int pathType;
    float goalRadius;
};

struct SGetApproxLengthCommand {
    float startPos_posF3[3];
    float endPos_posF3[3];
    int pathType;
    float goalRadius;
};

struct SGetNextWaypointCommand {
    int pathId;
};

struct SFreePathCommand {
    int pathId;
};

struct SGiveMeCommand {
    int resourceId;
    float amount;
};

struct SGiveMeNewUnitCommand {
    int unitDefId;
    float pos_posF3[3];
};

struct SCallLuaRulesCommand {
    const char *inData;
    int inSize;
};

struct SCallLuaUICommand {
    const char *inData;
    int inSize;
};

struct SCreateSplineFigureCommand {
    float pos1_posF3[3];
    float pos2_posF3[3];
    float pos3_posF3[3];
    float pos4_posF3[3];
    float width;
    int arrow;
    int lifeTime;
    int figureGroupId;
};

struct SCreateLineFigureCommand {
    float pos1_posF3[3];
    float pos2_posF3[3];
    float width;
    int arrow;
    int lifeTime;
    int figureGroupId;
};

struct SSetFigurePositionCommand {
    int figureId;
    float pos_posF3[3];
};

struct SSetFigureColorCommand {
    int figureId;
    float r, g, b, a;
};

struct SRemoveFigureCommand {
    int figureId;
};

struct SDrawUnitCommand {
    int unitDefId;
    float pos_posF3[3];
    float rotation;
    int lifeTime;
    int teamId;
    int transparent;
    int drawBorder;
    int facing;
};

struct SDrawAddPointCommand {
    float pos_posF3[3];
    const char *label;
};

struct SDrawAddLineCommand {
    float posFrom_posF3[3];
    float posTo_posF3[3];
};

struct SDrawRemovePointCommand {
    float pos_posF3[3];
};

// -- Engine Callback Table --

typedef int (*Clb_Engine_handleCommand)(int skirmishAIId, int toId,
                                        int commandId, int commandTopic,
                                        void *commandData);

typedef const char* (*Clb_Info_getValueByKey)(int skirmishAIId, const char *key);

typedef void (*Clb_Log_log)(int skirmishAIId, const char *msg);

typedef int (*Clb_Game_getMyTeam)(int skirmishAIId);
typedef int (*Clb_Game_getMyAllyTeam)(int skirmishAIId);
typedef int (*Clb_Game_getTeamCount)(int skirmishAIId);
typedef int (*Clb_Map_getWidth)(int skirmishAIId);
typedef int (*Clb_Map_getHeight)(int skirmishAIId);
typedef void (*Clb_Unit_getPos)(int skirmishAIId, int unitId, float *pos);
typedef float (*Clb_Unit_getHealth)(int skirmishAIId, int unitId);
typedef float (*Clb_Unit_getMaxHealth)(int skirmishAIId, int unitId);

struct SSkirmishAICallback {
    Clb_Engine_handleCommand Engine_handleCommand;
    Clb_Info_getValueByKey Info_getValueByKey;
    Clb_Log_log Log_log;
    Clb_Game_getMyTeam Game_getMyTeam;
    Clb_Game_getMyAllyTeam Game_getMyAllyTeam;
    Clb_Game_getTeamCount Game_getTeamCount;
    Clb_Map_getWidth Map_getWidth;
    Clb_Map_getHeight Map_getHeight;
    Clb_Unit_getPos Unit_getPos;
    Clb_Unit_getHealth Unit_getHealth;
    Clb_Unit_getMaxHealth Unit_getMaxHealth;
};

#endif // HIGHBAR_ENGINE_TYPES_H
