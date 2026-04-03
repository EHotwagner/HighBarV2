#include "highbar/deserialize.h"
#include "highbar/engine_types.h"
#include "highbar/commands.pb-c.h"

#include <string.h>

// Helper to copy Vector3 to float[3]
static void vec3_to_pos(const Highbar__Vector3 *v, float *pos) {
    if (v) {
        pos[0] = v->x;
        pos[1] = v->y;
        pos[2] = v->z;
    } else {
        pos[0] = pos[1] = pos[2] = 0.0f;
    }
}

int hb_deserialize_and_execute(const Highbar__AICommand *cmd,
                                int skirmish_ai_id,
                                HB_HandleCommandFn handle_command) {
    if (!cmd || !handle_command) return -1;

    switch (cmd->command_case) {
    case HIGHBAR__AICOMMAND__COMMAND_BUILD_UNIT: {
        const Highbar__BuildUnitCommand *c = cmd->build_unit;
        struct SBuildUnitCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        s.options = (short)c->options;
        s.timeOut = c->timeout;
        s.toBuildUnitDefId = c->to_build_unit_def_id;
        float _pos1[3];
        vec3_to_pos(c->build_position, _pos1);
        s.buildPos_posF3 = _pos1;
        s.facing = c->facing;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_BUILD_UNIT, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_STOP: {
        const Highbar__StopCommand *c = cmd->stop;
        struct SStopCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        s.options = (short)c->options;
        s.timeOut = c->timeout;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_STOP, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_WAIT: {
        const Highbar__WaitCommand *c = cmd->wait;
        struct SWaitCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        s.options = (short)c->options;
        s.timeOut = c->timeout;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_WAIT, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_TIMED_WAIT: {
        const Highbar__TimedWaitCommand *c = cmd->timed_wait;
        struct STimedWaitCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        s.options = (short)c->options;
        s.timeOut = c->timeout;
        s.time = c->wait_time;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_TIMED_WAIT, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_SQUAD_WAIT: {
        const Highbar__SquadWaitCommand *c = cmd->squad_wait;
        struct SSquadWaitCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        s.options = (short)c->options;
        s.timeOut = c->timeout;
        s.numUnits = c->num_units;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_SQUAD_WAIT, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_DEATH_WAIT: {
        const Highbar__DeathWaitCommand *c = cmd->death_wait;
        struct SDeathWaitCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        s.options = (short)c->options;
        s.timeOut = c->timeout;
        s.toDieUnitId = c->death_unit_id;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_DEATH_WAIT, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_GATHER_WAIT: {
        const Highbar__GatherWaitCommand *c = cmd->gather_wait;
        struct SGatherWaitCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        s.options = (short)c->options;
        s.timeOut = c->timeout;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_GATHER_WAIT, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_MOVE_UNIT: {
        const Highbar__MoveUnitCommand *c = cmd->move_unit;
        struct SMoveUnitCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        s.options = (short)c->options;
        s.timeOut = c->timeout;
        float _pos2[3];
        vec3_to_pos(c->to_position, _pos2);
        s.toPos_posF3 = _pos2;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_MOVE_UNIT, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_PATROL: {
        const Highbar__PatrolCommand *c = cmd->patrol;
        struct SPatrolUnitCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        s.options = (short)c->options;
        s.timeOut = c->timeout;
        float _pos3[3];
        vec3_to_pos(c->to_position, _pos3);
        s.toPos_posF3 = _pos3;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_PATROL, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_FIGHT: {
        const Highbar__FightCommand *c = cmd->fight;
        struct SFightUnitCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        s.options = (short)c->options;
        s.timeOut = c->timeout;
        float _pos4[3];
        vec3_to_pos(c->to_position, _pos4);
        s.toPos_posF3 = _pos4;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_FIGHT, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_ATTACK: {
        const Highbar__AttackCommand *c = cmd->attack;
        struct SAttackUnitCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        s.options = (short)c->options;
        s.timeOut = c->timeout;
        s.toAttackUnitId = c->target_unit_id;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_ATTACK, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_ATTACK_AREA: {
        const Highbar__AttackAreaCommand *c = cmd->attack_area;
        struct SAttackAreaCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        s.options = (short)c->options;
        s.timeOut = c->timeout;
        float _pos5[3];
        vec3_to_pos(c->attack_position, _pos5);
        s.toAttackPos_posF3 = _pos5;
        s.radius = c->radius;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_ATTACK_AREA, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_GUARD: {
        const Highbar__GuardCommand *c = cmd->guard;
        struct SGuardUnitCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        s.options = (short)c->options;
        s.timeOut = c->timeout;
        s.toGuardUnitId = c->guard_unit_id;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_GUARD, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_REPAIR: {
        const Highbar__RepairCommand *c = cmd->repair;
        struct SRepairUnitCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        s.options = (short)c->options;
        s.timeOut = c->timeout;
        s.toRepairUnitId = c->repair_unit_id;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_REPAIR, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_RECLAIM_UNIT: {
        const Highbar__ReclaimUnitCommand *c = cmd->reclaim_unit;
        struct SReclaimUnitCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        s.options = (short)c->options;
        s.timeOut = c->timeout;
        s.toReclaimUnitId = c->reclaim_unit_id;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_RECLAIM_UNIT, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_RECLAIM_AREA: {
        const Highbar__ReclaimAreaCommand *c = cmd->reclaim_area;
        struct SReclaimAreaCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        s.options = (short)c->options;
        s.timeOut = c->timeout;
        float _pos6[3];
        vec3_to_pos(c->position, _pos6);
        s.pos_posF3 = _pos6;
        s.radius = c->radius;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_RECLAIM_AREA, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_RESTORE_AREA: {
        const Highbar__RestoreAreaCommand *c = cmd->restore_area;
        struct SRestoreAreaCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        s.options = (short)c->options;
        s.timeOut = c->timeout;
        float _pos7[3];
        vec3_to_pos(c->position, _pos7);
        s.pos_posF3 = _pos7;
        s.radius = c->radius;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_RESTORE_AREA, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_RESURRECT: {
        const Highbar__ResurrectCommand *c = cmd->resurrect;
        struct SResurrectCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        s.options = (short)c->options;
        s.timeOut = c->timeout;
        s.toResurrectFeatureId = c->feature_id;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_RESURRECT, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_RESURRECT_IN_AREA: {
        const Highbar__ResurrectInAreaCommand *c = cmd->resurrect_in_area;
        struct SResurrectAreaCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        s.options = (short)c->options;
        s.timeOut = c->timeout;
        float _pos8[3];
        vec3_to_pos(c->position, _pos8);
        s.pos_posF3 = _pos8;
        s.radius = c->radius;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_RESURRECT_IN_AREA, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_CAPTURE: {
        const Highbar__CaptureCommand *c = cmd->capture;
        struct SCaptureUnitCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        s.options = (short)c->options;
        s.timeOut = c->timeout;
        s.toCaptureUnitId = c->target_unit_id;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_CAPTURE, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_CAPTURE_AREA: {
        const Highbar__CaptureAreaCommand *c = cmd->capture_area;
        struct SCaptureAreaCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        s.options = (short)c->options;
        s.timeOut = c->timeout;
        float _pos9[3];
        vec3_to_pos(c->position, _pos9);
        s.pos_posF3 = _pos9;
        s.radius = c->radius;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_CAPTURE_AREA, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_SET_BASE: {
        const Highbar__SetBaseCommand *c = cmd->set_base;
        struct SSetBaseCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        s.options = (short)c->options;
        s.timeOut = c->timeout;
        float _pos10[3];
        vec3_to_pos(c->base_position, _pos10);
        s.basePos_posF3 = _pos10;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_SET_BASE, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_SELF_DESTRUCT: {
        const Highbar__SelfDestructCommand *c = cmd->self_destruct;
        struct SSelfDestructUnitCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        s.options = (short)c->options;
        s.timeOut = c->timeout;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_SELF_DESTRUCT, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_LOAD_ONTO: {
        const Highbar__LoadOntoCommand *c = cmd->load_onto;
        struct SLoadOntoCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        s.options = (short)c->options;
        s.timeOut = c->timeout;
        s.transporterUnitId = c->transport_unit_id;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_LOAD_ONTO, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_UNLOAD_UNIT: {
        const Highbar__UnloadUnitCommand *c = cmd->unload_unit;
        struct SUnloadUnitCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        s.options = (short)c->options;
        s.timeOut = c->timeout;
        float _pos11[3];
        vec3_to_pos(c->to_position, _pos11);
        s.toPos_posF3 = _pos11;
        s.toUnloadUnitId = c->to_unload_unit_id;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_UNLOAD_UNIT, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_UNLOAD_UNITS_AREA: {
        const Highbar__UnloadUnitsAreaCommand *c = cmd->unload_units_area;
        struct SUnloadUnitsAreaCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        s.options = (short)c->options;
        s.timeOut = c->timeout;
        float _pos12[3];
        vec3_to_pos(c->to_position, _pos12);
        s.toPos_posF3 = _pos12;
        s.radius = c->radius;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_UNLOAD_UNITS_AREA, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_SET_WANTED_MAX_SPEED: {
        const Highbar__SetWantedMaxSpeedCommand *c = cmd->set_wanted_max_speed;
        struct SSetWantedMaxSpeedCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        s.options = (short)c->options;
        s.timeOut = c->timeout;
        s.wantedMaxSpeed = c->wanted_max_speed;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_SET_WANTED_MAX_SPEED, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_STOCKPILE: {
        const Highbar__StockpileCommand *c = cmd->stockpile;
        struct SStockpileCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        s.options = (short)c->options;
        s.timeOut = c->timeout;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_STOCKPILE, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_DGUN: {
        const Highbar__DGunCommand *c = cmd->dgun;
        struct SDGunUnitCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        s.options = (short)c->options;
        s.timeOut = c->timeout;
        s.toAttackUnitId = c->target_unit_id;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_DGUN, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_CUSTOM: {
        const Highbar__CustomCommand *c = cmd->custom;
        struct SCustomCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        s.options = (short)c->options;
        s.timeOut = c->timeout;
        s.cmdId = c->command_id;
        s.params = (float *)c->params;
        s.params_size = (int)c->n_params;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_CUSTOM, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_SET_ON_OFF: {
        const Highbar__SetOnOffCommand *c = cmd->set_on_off;
        struct SSetOnOffCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        s.options = (short)c->options;
        s.timeOut = c->timeout;
        s.on = c->on ? 1 : 0;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_SET_ON_OFF, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_SET_REPEAT: {
        const Highbar__SetRepeatCommand *c = cmd->set_repeat;
        struct SSetRepeatCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        s.options = (short)c->options;
        s.timeOut = c->timeout;
        s.repeat = c->repeat ? 1 : 0;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_SET_REPEAT, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_SET_MOVE_STATE: {
        const Highbar__SetMoveStateCommand *c = cmd->set_move_state;
        struct SSetMoveStateCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        s.options = (short)c->options;
        s.timeOut = c->timeout;
        s.moveState = c->move_state;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_SET_MOVE_STATE, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_SET_FIRE_STATE: {
        const Highbar__SetFireStateCommand *c = cmd->set_fire_state;
        struct SSetFireStateCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        s.options = (short)c->options;
        s.timeOut = c->timeout;
        s.fireState = c->fire_state;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_SET_FIRE_STATE, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_SET_TRAJECTORY: {
        const Highbar__SetTrajectoryCommand *c = cmd->set_trajectory;
        struct SSetTrajectoryCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        s.options = (short)c->options;
        s.timeOut = c->timeout;
        s.trajectory = c->trajectory;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_SET_TRAJECTORY, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_SET_AUTO_REPAIR_LEVEL: {
        const Highbar__SetAutoRepairLevelCommand *c = cmd->set_auto_repair_level;
        struct SSetAutoRepairLevelCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        s.options = (short)c->options;
        s.timeOut = c->timeout;
        s.autoRepairLevel = c->auto_repair_level;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_SET_AUTO_REPAIR_LEVEL, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_SET_IDLE_MODE: {
        const Highbar__SetIdleModeCommand *c = cmd->set_idle_mode;
        struct SSetIdleModeCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        s.options = (short)c->options;
        s.timeOut = c->timeout;
        s.idleMode = c->idle_mode;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_SET_IDLE_MODE, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_SEND_TEXT_MESSAGE: {
        const Highbar__SendTextMessageCommand *c = cmd->send_text_message;
        struct SSendTextMessageCommand s;
        memset(&s, 0, sizeof(s));
        s.text = c->text;
        s.zone = c->zone;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_SEND_TEXT_MESSAGE, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_SEND_RESOURCES: {
        const Highbar__SendResourcesCommand *c = cmd->send_resources;
        struct SSendResourcesCommand s;
        memset(&s, 0, sizeof(s));
        s.resourceId = c->resource_id;
        s.amount = c->amount;
        s.receivingTeamId = c->receiving_team_id;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_SEND_RESOURCES, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_GIVE_ME: {
        const Highbar__GiveMeCommand *c = cmd->give_me;
        struct SGiveMeCommand s;
        memset(&s, 0, sizeof(s));
        s.resourceId = c->resource_id;
        s.amount = c->amount;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_GIVE_ME, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_GIVE_ME_NEW_UNIT: {
        const Highbar__GiveMeNewUnitCommand *c = cmd->give_me_new_unit;
        struct SGiveMeNewUnitCommand s;
        memset(&s, 0, sizeof(s));
        s.unitDefId = c->unit_def_id;
        float _pos13[3];
        vec3_to_pos(c->position, _pos13);
        s.pos_posF3 = _pos13;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_GIVE_ME_NEW_UNIT, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_CALL_LUA_RULES: {
        const Highbar__CallLuaRulesCommand *c = cmd->call_lua_rules;
        struct SCallLuaRulesCommand s;
        memset(&s, 0, sizeof(s));
        s.inData = c->data;
        s.inSize = c->data ? (int)strlen(c->data) : 0;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_CALL_LUA_RULES, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_CALL_LUA_UI: {
        const Highbar__CallLuaUICommand *c = cmd->call_lua_ui;
        struct SCallLuaUICommand s;
        memset(&s, 0, sizeof(s));
        s.inData = c->data;
        s.inSize = c->data ? (int)strlen(c->data) : 0;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_CALL_LUA_UI, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_PAUSE_TEAM: {
        const Highbar__PauseTeamCommand *c = cmd->pause_team;
        struct SPauseTeamCommand s;
        memset(&s, 0, sizeof(s));
        s.enable = c->enable ? 1 : 0;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_PAUSE_TEAM, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_RECLAIM_IN_AREA: {
        const Highbar__ReclaimInAreaCommand *c = cmd->reclaim_in_area;
        struct SReclaimAreaCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        s.options = (short)c->options;
        s.timeOut = c->timeout;
        float _pos14[3];
        vec3_to_pos(c->position, _pos14);
        s.pos_posF3 = _pos14;
        s.radius = c->radius;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_RECLAIM_IN_AREA, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_RECLAIM_FEATURE: {
        const Highbar__ReclaimFeatureCommand *c = cmd->reclaim_feature;
        struct SReclaimUnitCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        s.options = (short)c->options;
        s.timeOut = c->timeout;
        s.toReclaimUnitId = c->feature_id;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_RECLAIM_FEATURE, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_LOAD_UNITS_AREA: {
        const Highbar__LoadUnitsAreaCommand *c = cmd->load_units_area;
        struct SLoadUnitsAreaCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        s.options = (short)c->options;
        s.timeOut = c->timeout;
        float _pos15[3];
        vec3_to_pos(c->position, _pos15);
        s.pos_posF3 = _pos15;
        s.radius = c->radius;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_LOAD_UNITS_AREA, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_DRAW_ADD_POINT: {
        const Highbar__DrawAddPointCommand *c = cmd->draw_add_point;
        struct SDrawAddPointCommand s;
        memset(&s, 0, sizeof(s));
        float _pos16[3];
        vec3_to_pos(c->position, _pos16);
        s.pos_posF3 = _pos16;
        s.label = c->label;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_DRAW_ADD_POINT, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_DRAW_ADD_LINE: {
        const Highbar__DrawAddLineCommand *c = cmd->draw_add_line;
        struct SDrawAddLineCommand s;
        memset(&s, 0, sizeof(s));
        float _pos17[3];
        vec3_to_pos(c->from_position, _pos17);
        s.posFrom_posF3 = _pos17;
        float _pos18[3];
        vec3_to_pos(c->to_position, _pos18);
        s.posTo_posF3 = _pos18;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_DRAW_ADD_LINE, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_DRAW_REMOVE_POINT: {
        const Highbar__DrawRemovePointCommand *c = cmd->draw_remove_point;
        struct SDrawRemovePointCommand s;
        memset(&s, 0, sizeof(s));
        float _pos19[3];
        vec3_to_pos(c->position, _pos19);
        s.pos_posF3 = _pos19;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_DRAW_REMOVE_POINT, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_SET_LAST_POS_MESSAGE: {
        const Highbar__SetLastPosMessageCommand *c = cmd->set_last_pos_message;
        struct SSetLastPosMessageCommand s;
        memset(&s, 0, sizeof(s));
        float _pos20[3];
        vec3_to_pos(c->position, _pos20);
        s.pos_posF3 = _pos20;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_SET_LAST_POS_MESSAGE, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_SET_MY_INCOME_SHARE_DIRECT: {
        const Highbar__SetMyIncomeShareDirectCommand *c = cmd->set_my_income_share_direct;
        struct SSetMyIncomeShareDirectCommand s;
        memset(&s, 0, sizeof(s));
        s.resourceId = c->resource_id;
        s.share = c->share;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_SET_MY_INCOME_SHARE_DIRECT, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_SET_SHARE_LEVEL: {
        const Highbar__SetShareLevelCommand *c = cmd->set_share_level;
        struct SSetShareLevelCommand s;
        memset(&s, 0, sizeof(s));
        s.resourceId = c->resource_id;
        s.shareLevel = c->share_level;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_SET_SHARE_LEVEL, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_GROUP_ADD_UNIT: {
        const Highbar__GroupAddUnitCommand *c = cmd->group_add_unit;
        struct SGroupAddUnitCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_GROUP_ADD_UNIT, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_GROUP_REMOVE_UNIT: {
        const Highbar__GroupRemoveUnitCommand *c = cmd->group_remove_unit;
        struct SGroupRemoveUnitCommand s;
        memset(&s, 0, sizeof(s));
        s.unitId = c->unit_id;
        s.groupId = c->group_id;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_GROUP_REMOVE_UNIT, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_INIT_PATH: {
        const Highbar__InitPathCommand *c = cmd->init_path;
        struct SInitPathCommand s;
        memset(&s, 0, sizeof(s));
        float _pos21[3];
        vec3_to_pos(c->start_position, _pos21);
        s.start_posF3 = _pos21;
        float _pos22[3];
        vec3_to_pos(c->end_position, _pos22);
        s.end_posF3 = _pos22;
        s.pathType = c->path_type;
        s.goalRadius = c->goal_radius;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_INIT_PATH, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_GET_APPROX_LENGTH: {
        const Highbar__GetApproxLengthCommand *c = cmd->get_approx_length;
        struct SGetApproxLengthCommand s;
        memset(&s, 0, sizeof(s));
        float _pos23[3];
        vec3_to_pos(c->start_position, _pos23);
        s.start_posF3 = _pos23;
        float _pos24[3];
        vec3_to_pos(c->end_position, _pos24);
        s.end_posF3 = _pos24;
        s.pathType = c->path_type;
        s.goalRadius = c->goal_radius;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_GET_APPROX_LENGTH, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_GET_NEXT_WAYPOINT: {
        const Highbar__GetNextWaypointCommand *c = cmd->get_next_waypoint;
        struct SGetNextWaypointCommand s;
        memset(&s, 0, sizeof(s));
        s.pathId = c->path_id;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_GET_NEXT_WAYPOINT, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_FREE_PATH: {
        const Highbar__FreePathCommand *c = cmd->free_path;
        struct SFreePathCommand s;
        memset(&s, 0, sizeof(s));
        s.pathId = c->path_id;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_FREE_PATH, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_CREATE_SPLINE_FIGURE: {
        const Highbar__CreateSplineFigureCommand *c = cmd->create_spline_figure;
        struct SCreateSplineFigureCommand s;
        memset(&s, 0, sizeof(s));
        float _pos25[3];
        vec3_to_pos(c->position1, _pos25);
        s.pos1_posF3 = _pos25;
        float _pos26[3];
        vec3_to_pos(c->position2, _pos26);
        s.pos2_posF3 = _pos26;
        float _pos27[3];
        vec3_to_pos(c->position3, _pos27);
        s.pos3_posF3 = _pos27;
        float _pos28[3];
        vec3_to_pos(c->position4, _pos28);
        s.pos4_posF3 = _pos28;
        s.width = c->width;
        s.arrow = c->arrow ? 1 : 0;
        s.lifeTime = c->lifespan;
        s.figureGroupId = c->figure_group_id;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_CREATE_SPLINE_FIGURE, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_CREATE_LINE_FIGURE: {
        const Highbar__CreateLineFigureCommand *c = cmd->create_line_figure;
        struct SCreateLineFigureCommand s;
        memset(&s, 0, sizeof(s));
        float _pos29[3];
        vec3_to_pos(c->from_position, _pos29);
        s.pos1_posF3 = _pos29;
        float _pos30[3];
        vec3_to_pos(c->to_position, _pos30);
        s.pos2_posF3 = _pos30;
        s.width = c->width;
        s.arrow = c->arrow ? 1 : 0;
        s.lifeTime = c->lifespan;
        s.figureGroupId = c->figure_group_id;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_CREATE_LINE_FIGURE, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_SET_FIGURE_POSITION: {
        const Highbar__SetFigurePositionCommand *c = cmd->set_figure_position;
        struct SSetFigurePositionCommand s;
        memset(&s, 0, sizeof(s));
        s.figureId = c->figure_id;
        float _pos31[3];
        vec3_to_pos(c->position, _pos31);
        s.pos_posF3 = _pos31;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_SET_FIGURE_POSITION, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_SET_FIGURE_COLOR: {
        const Highbar__SetFigureColorCommand *c = cmd->set_figure_color;
        struct SSetFigureColorCommand s;
        short color[3];
        memset(&s, 0, sizeof(s));
        s.figureGroupId = c->figure_id;
        color[0] = (short)c->r;
        color[1] = (short)c->g;
        color[2] = (short)c->b;
        s.color_colorS3 = color;
        s.alpha = (short)c->a;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_SET_FIGURE_COLOR, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_REMOVE_FIGURE: {
        const Highbar__RemoveFigureCommand *c = cmd->remove_figure;
        struct SRemoveFigureCommand s;
        memset(&s, 0, sizeof(s));
        s.figureGroupId = c->figure_id;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_REMOVE_FIGURE, &s);
    }
    case HIGHBAR__AICOMMAND__COMMAND_DRAW_UNIT: {
        const Highbar__DrawUnitCommand *c = cmd->draw_unit;
        struct SDrawUnitCommand s;
        memset(&s, 0, sizeof(s));
        s.toDrawUnitDefId = c->unit_def_id;
        float _pos32[3];
        vec3_to_pos(c->position, _pos32);
        s.pos_posF3 = _pos32;
        s.rotation = c->rotation;
        s.lifeTime = c->lifespan;
        s.teamId = c->team_id;
        s.transparent = c->transparent ? 1 : 0;
        s.drawBorder = c->draw_border ? 1 : 0;
        s.facing = c->facing;
        return handle_command(skirmish_ai_id, -1, 0, COMMAND_DRAW_UNIT, &s);
    }
    default:
        return -1; // Unknown command
    }
}
