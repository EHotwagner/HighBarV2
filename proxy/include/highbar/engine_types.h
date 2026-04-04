#ifndef HIGHBAR_ENGINE_TYPES_H
#define HIGHBAR_ENGINE_TYPES_H

// Use the real engine AI interface headers for correct ABI compatibility.
// These are sourced from the Recoil engine (beyond-all-reason/spring).

#include "AI/AISEvents.h"
#include "AI/AISCommands.h"
#include "AI/SSkirmishAICallback.h"

// ============================================================================
// Command ID constants
// ============================================================================
// Pass COMMAND_ID_UNTRACKED (-1) as the commandId parameter to
// Engine_handleCommand so the engine sends NETMSG_AICOMMAND packets
// (handled by GameServer) instead of NETMSG_AICOMMAND_TRACKED packets
// (silently dropped by GameServer).
#define COMMAND_ID_UNTRACKED (-1)

// ============================================================================
// Compatibility aliases
// ============================================================================
// Our proxy code was written against stub headers with shorter names.
// These macros map the old names to the real engine names.

// -- Callback field aliases --
#define Info_getValueByKey SkirmishAI_Info_getValueByKey
#define Game_getTeamCount Game_getTeams

// ============================================================================
// Command topic aliases (old short names -> real engine enum values)
// ============================================================================

// Unit commands
#define COMMAND_BUILD_UNIT               COMMAND_UNIT_BUILD
#define COMMAND_STOP                     COMMAND_UNIT_STOP
#define COMMAND_WAIT                     COMMAND_UNIT_WAIT
#define COMMAND_TIMED_WAIT               COMMAND_UNIT_WAIT_TIME
#define COMMAND_SQUAD_WAIT               COMMAND_UNIT_WAIT_SQUAD
#define COMMAND_DEATH_WAIT               COMMAND_UNIT_WAIT_DEATH
#define COMMAND_GATHER_WAIT              COMMAND_UNIT_WAIT_GATHER
#define COMMAND_MOVE_UNIT                COMMAND_UNIT_MOVE
#define COMMAND_PATROL                   COMMAND_UNIT_PATROL
#define COMMAND_FIGHT                    COMMAND_UNIT_FIGHT
#define COMMAND_ATTACK                   COMMAND_UNIT_ATTACK
#define COMMAND_ATTACK_AREA              COMMAND_UNIT_ATTACK_AREA
#define COMMAND_GUARD                    COMMAND_UNIT_GUARD
#define COMMAND_REPAIR                   COMMAND_UNIT_REPAIR
#define COMMAND_RECLAIM_UNIT             COMMAND_UNIT_RECLAIM_UNIT
#define COMMAND_RECLAIM_AREA             COMMAND_UNIT_RECLAIM_AREA
#define COMMAND_RECLAIM_IN_AREA          COMMAND_UNIT_RECLAIM_AREA
#define COMMAND_RECLAIM_FEATURE          COMMAND_UNIT_RECLAIM_FEATURE
#define COMMAND_RESTORE_AREA             COMMAND_UNIT_RESTORE_AREA
#define COMMAND_RESURRECT                COMMAND_UNIT_RESURRECT
#define COMMAND_RESURRECT_IN_AREA        COMMAND_UNIT_RESURRECT_AREA
#define COMMAND_CAPTURE                  COMMAND_UNIT_CAPTURE
#define COMMAND_CAPTURE_AREA             COMMAND_UNIT_CAPTURE_AREA
#define COMMAND_SET_BASE                 COMMAND_UNIT_SET_BASE
#define COMMAND_SELF_DESTRUCT            COMMAND_UNIT_SELF_DESTROY
#define COMMAND_LOAD_ONTO                COMMAND_UNIT_LOAD_ONTO
#define COMMAND_UNLOAD_UNIT              COMMAND_UNIT_UNLOAD_UNIT
#define COMMAND_UNLOAD_UNITS_AREA        COMMAND_UNIT_UNLOAD_UNITS_AREA
#define COMMAND_SET_WANTED_MAX_SPEED     COMMAND_UNIT_SET_WANTED_MAX_SPEED
#define COMMAND_STOCKPILE                COMMAND_UNIT_STOCKPILE
#define COMMAND_DGUN                     COMMAND_UNIT_D_GUN
#define COMMAND_CUSTOM                   COMMAND_UNIT_CUSTOM
#define COMMAND_SET_ON_OFF               COMMAND_UNIT_SET_ON_OFF
#define COMMAND_SET_REPEAT               COMMAND_UNIT_SET_REPEAT
#define COMMAND_SET_MOVE_STATE            COMMAND_UNIT_SET_MOVE_STATE
#define COMMAND_SET_FIRE_STATE            COMMAND_UNIT_SET_FIRE_STATE
#define COMMAND_SET_TRAJECTORY            COMMAND_UNIT_SET_TRAJECTORY
#define COMMAND_SET_AUTO_REPAIR_LEVEL     COMMAND_UNIT_SET_AUTO_REPAIR_LEVEL
#define COMMAND_SET_IDLE_MODE             COMMAND_UNIT_SET_IDLE_MODE
#define COMMAND_LOAD_UNITS_AREA          COMMAND_UNIT_LOAD_UNITS_AREA

// Cheat commands
#define COMMAND_GIVE_ME                  COMMAND_CHEATS_GIVE_ME_RESOURCE
#define COMMAND_GIVE_ME_NEW_UNIT         COMMAND_CHEATS_GIVE_ME_NEW_UNIT

// Drawer commands
#define COMMAND_DRAW_ADD_POINT           COMMAND_DRAWER_POINT_ADD
#define COMMAND_DRAW_ADD_LINE            COMMAND_DRAWER_LINE_ADD
#define COMMAND_DRAW_REMOVE_POINT        COMMAND_DRAWER_POINT_REMOVE
#define COMMAND_DRAW_UNIT                COMMAND_DRAWER_DRAW_UNIT
#define COMMAND_CREATE_SPLINE_FIGURE     COMMAND_DRAWER_FIGURE_CREATE_SPLINE
#define COMMAND_CREATE_LINE_FIGURE       COMMAND_DRAWER_FIGURE_CREATE_LINE
#define COMMAND_SET_FIGURE_COLOR         COMMAND_DRAWER_FIGURE_SET_COLOR
#define COMMAND_REMOVE_FIGURE            COMMAND_DRAWER_FIGURE_DELETE

// Path commands
#define COMMAND_INIT_PATH                COMMAND_PATH_INIT
#define COMMAND_GET_APPROX_LENGTH        COMMAND_PATH_GET_APPROXIMATE_LENGTH
#define COMMAND_GET_NEXT_WAYPOINT        COMMAND_PATH_GET_NEXT_WAYPOINT
#define COMMAND_FREE_PATH                COMMAND_PATH_FREE

// Commands that do not exist in real engine -- define unique values
// above the real enum range (NUM_CMD_TOPICS = 97)
#define COMMAND_SET_MY_INCOME_SHARE_DIRECT  200
#define COMMAND_SET_SHARE_LEVEL             201
#define COMMAND_SET_FIGURE_POSITION         202
#define COMMAND_PAUSE_TEAM                  203

// ============================================================================
// Struct type aliases (old stub names -> real engine struct names)
// ============================================================================

// Unit command structs
#define SStopCommand                     SStopUnitCommand
#define SWaitCommand                     SWaitUnitCommand
#define STimedWaitCommand                STimeWaitUnitCommand
#define SSquadWaitCommand                SSquadWaitUnitCommand
#define SDeathWaitCommand                SDeathWaitUnitCommand
#define SGatherWaitCommand               SGatherWaitUnitCommand
#define SAttackAreaCommand               SAttackAreaUnitCommand
#define SReclaimUnitCommand              SReclaimUnitUnitCommand
#define SReclaimAreaCommand              SReclaimAreaUnitCommand
#define SRestoreAreaCommand              SRestoreAreaUnitCommand
#define SResurrectCommand                SResurrectUnitCommand
#define SResurrectAreaCommand            SResurrectAreaUnitCommand
#define SCaptureAreaCommand              SCaptureAreaUnitCommand
#define SSetBaseCommand                  SSetBaseUnitCommand
#define SSelfDestructUnitCommand         SSelfDestroyUnitCommand
#define SLoadOntoCommand                 SLoadOntoUnitCommand
#define SUnloadUnitsAreaCommand          SUnloadUnitsAreaUnitCommand
#define SStockpileCommand                SStockpileUnitCommand
#define SCustomCommand                   SCustomUnitCommand
#define SSetOnOffCommand                 SSetOnOffUnitCommand
#define SSetRepeatCommand                SSetRepeatUnitCommand
#define SSetMoveStateCommand             SSetMoveStateUnitCommand
#define SSetFireStateCommand             SSetFireStateUnitCommand
#define SSetTrajectoryCommand            SSetTrajectoryUnitCommand
#define SSetAutoRepairLevelCommand       SSetAutoRepairLevelUnitCommand
#define SSetIdleModeCommand              SSetIdleModeUnitCommand
#define SLoadUnitsAreaCommand            SLoadUnitsAreaUnitCommand

// Cheat command structs
#define SGiveMeCommand                   SGiveMeResourceCheatCommand
#define SGiveMeNewUnitCommand            SGiveMeNewUnitCheatCommand

// Drawer command structs
#define SDrawAddPointCommand             SAddPointDrawCommand
#define SDrawAddLineCommand              SAddLineDrawCommand
#define SDrawRemovePointCommand          SRemovePointDrawCommand
#define SDrawUnitCommand                 SDrawUnitDrawerCommand
#define SCreateSplineFigureCommand       SCreateSplineFigureDrawerCommand
#define SCreateLineFigureCommand         SCreateLineFigureDrawerCommand
#define SSetFigureColorCommand           SSetColorFigureDrawerCommand
#define SRemoveFigureCommand             SDeleteFigureDrawerCommand

// Path command structs
#define SGetApproxLengthCommand          SGetApproximateLengthPathCommand
#define SGetNextWaypointCommand          SGetNextWaypointPathCommand

// Group command structs
#define SGroupRemoveUnitCommand          SGroupClearUnitCommand

// ============================================================================
// Stub structs for commands that do not exist in the real engine
// ============================================================================

// SSetWantedMaxSpeedCommand -- COMMAND_UNIT_SET_WANTED_MAX_SPEED exists but
// the struct was removed from the real headers (marked "unused").
struct SSetWantedMaxSpeedCommand {
    int unitId;
    int groupId;
    short options;
    int timeOut;
    float wantedMaxSpeed;
};

// SPauseTeamCommand -- no equivalent in real engine
struct SPauseTeamCommand {
    int enable;
};

// SSetMyIncomeShareDirectCommand -- no equivalent in real engine
struct SSetMyIncomeShareDirectCommand {
    int resourceId;
    float share;
};

// SSetShareLevelCommand -- no equivalent in real engine
struct SSetShareLevelCommand {
    int resourceId;
    float shareLevel;
};

// SSetFigurePositionCommand -- no equivalent in real engine
struct SSetFigurePositionCommand {
    int figureId;
    float *pos_posF3;
};

#endif // HIGHBAR_ENGINE_TYPES_H
