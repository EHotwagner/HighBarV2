/*
 * C proxy deserialization tests.
 *
 * RETAINED edge-case tests (2):
 *   - test_unknown_command: validates error path for unset command_case
 *   - test_multiple_commands: validates batch ordering of sequential commands
 *   These exercise defensive code paths that cannot be triggered via live engine.
 *
 * SUPPLEMENTED standard command tests (15):
 *   MoveUnit, BuildUnit, Patrol, Attack, Stop, Guard, Repair, Custom,
 *   SetOnOff, DrawAddPoint, SendTextMessage, Fight, SelfDestruct,
 *   GiveMeNewUnit, GiveMe
 *   These are retained here for fast feedback during proxy development. Live
 *   engine validation in persistent tier (T2, T3, T4, T5, T6) provides
 *   authoritative coverage.
 */
#include "highbar/deserialize.h"
#include "highbar/engine_types.h"
#include "highbar/commands.pb-c.h"
#include "mock_engine.h"
#include <assert.h>
#include <stdio.h>
#include <string.h>
#include <math.h>

#define TEST(name) static void name(void)
#define RUN(name) do { \
    printf("  " #name "..."); \
    mock_engine_reset(); \
    name(); \
    printf(" OK\n"); \
} while(0)

static struct SSkirmishAICallback *cb;

TEST(test_move_command) {
    Highbar__AICommand cmd = HIGHBAR__AICOMMAND__INIT;
    Highbar__MoveUnitCommand move = HIGHBAR__MOVE_UNIT_COMMAND__INIT;
    Highbar__Vector3 pos = HIGHBAR__VECTOR3__INIT;
    pos.x = 100; pos.y = 0; pos.z = 200;
    move.unit_id = 5;
    move.group_id = 0;
    move.options = 0;
    move.timeout = -1;
    move.to_position = &pos;
    cmd.command_case = HIGHBAR__AICOMMAND__COMMAND_MOVE_UNIT;
    cmd.move_unit = &move;

    int rc = hb_deserialize_and_execute(&cmd, 0, cb->Engine_handleCommand);
    assert(rc == 0);
    assert(mock_engine_get_command_count() == 1);
    assert(mock_engine_get_last_command_topic() == COMMAND_MOVE_UNIT);
    assert(mock_engine_get_last_command_id() == -1);
}

TEST(test_build_command) {
    Highbar__AICommand cmd = HIGHBAR__AICOMMAND__INIT;
    Highbar__BuildUnitCommand build = HIGHBAR__BUILD_UNIT_COMMAND__INIT;
    Highbar__Vector3 pos = HIGHBAR__VECTOR3__INIT;
    pos.x = 50; pos.y = 0; pos.z = 50;
    build.unit_id = 1;
    build.to_build_unit_def_id = 42;
    build.build_position = &pos;
    build.facing = 2;
    cmd.command_case = HIGHBAR__AICOMMAND__COMMAND_BUILD_UNIT;
    cmd.build_unit = &build;

    int rc = hb_deserialize_and_execute(&cmd, 0, cb->Engine_handleCommand);
    assert(rc == 0);
    assert(mock_engine_get_last_command_topic() == COMMAND_BUILD_UNIT);
}

TEST(test_patrol_command) {
    Highbar__AICommand cmd = HIGHBAR__AICOMMAND__INIT;
    Highbar__PatrolCommand patrol = HIGHBAR__PATROL_COMMAND__INIT;
    Highbar__Vector3 pos = HIGHBAR__VECTOR3__INIT;
    pos.x = 300; pos.y = 0; pos.z = 400;
    patrol.unit_id = 3;
    patrol.to_position = &pos;
    cmd.command_case = HIGHBAR__AICOMMAND__COMMAND_PATROL;
    cmd.patrol = &patrol;

    int rc = hb_deserialize_and_execute(&cmd, 0, cb->Engine_handleCommand);
    assert(rc == 0);
    assert(mock_engine_get_last_command_topic() == COMMAND_PATROL);
    assert(mock_engine_get_last_command_id() == -1);
}

TEST(test_attack_command) {
    Highbar__AICommand cmd = HIGHBAR__AICOMMAND__INIT;
    Highbar__AttackCommand attack = HIGHBAR__ATTACK_COMMAND__INIT;
    attack.unit_id = 1;
    attack.target_unit_id = 10;
    cmd.command_case = HIGHBAR__AICOMMAND__COMMAND_ATTACK;
    cmd.attack = &attack;

    int rc = hb_deserialize_and_execute(&cmd, 0, cb->Engine_handleCommand);
    assert(rc == 0);
    assert(mock_engine_get_last_command_topic() == COMMAND_ATTACK);
    assert(mock_engine_get_last_command_id() == -1);
}

TEST(test_stop_command) {
    Highbar__AICommand cmd = HIGHBAR__AICOMMAND__INIT;
    Highbar__StopCommand stop = HIGHBAR__STOP_COMMAND__INIT;
    stop.unit_id = 7;
    cmd.command_case = HIGHBAR__AICOMMAND__COMMAND_STOP;
    cmd.stop = &stop;

    int rc = hb_deserialize_and_execute(&cmd, 0, cb->Engine_handleCommand);
    assert(rc == 0);
    assert(mock_engine_get_last_command_topic() == COMMAND_STOP);
}

TEST(test_guard_command) {
    Highbar__AICommand cmd = HIGHBAR__AICOMMAND__INIT;
    Highbar__GuardCommand guard = HIGHBAR__GUARD_COMMAND__INIT;
    guard.unit_id = 2;
    guard.guard_unit_id = 8;
    cmd.command_case = HIGHBAR__AICOMMAND__COMMAND_GUARD;
    cmd.guard = &guard;

    int rc = hb_deserialize_and_execute(&cmd, 0, cb->Engine_handleCommand);
    assert(rc == 0);
    assert(mock_engine_get_last_command_topic() == COMMAND_GUARD);
}

TEST(test_repair_command) {
    Highbar__AICommand cmd = HIGHBAR__AICOMMAND__INIT;
    Highbar__RepairCommand repair = HIGHBAR__REPAIR_COMMAND__INIT;
    repair.unit_id = 3;
    repair.repair_unit_id = 9;
    cmd.command_case = HIGHBAR__AICOMMAND__COMMAND_REPAIR;
    cmd.repair = &repair;

    int rc = hb_deserialize_and_execute(&cmd, 0, cb->Engine_handleCommand);
    assert(rc == 0);
    assert(mock_engine_get_last_command_topic() == COMMAND_REPAIR);
}

TEST(test_custom_command) {
    Highbar__AICommand cmd = HIGHBAR__AICOMMAND__INIT;
    Highbar__CustomCommand custom = HIGHBAR__CUSTOM_COMMAND__INIT;
    custom.unit_id = 1;
    custom.command_id = 999;
    float params[] = {1.0f, 2.0f, 3.0f};
    custom.params = params;
    custom.n_params = 3;
    cmd.command_case = HIGHBAR__AICOMMAND__COMMAND_CUSTOM;
    cmd.custom = &custom;

    int rc = hb_deserialize_and_execute(&cmd, 0, cb->Engine_handleCommand);
    assert(rc == 0);
    assert(mock_engine_get_last_command_topic() == COMMAND_CUSTOM);
}

TEST(test_set_on_off_command) {
    Highbar__AICommand cmd = HIGHBAR__AICOMMAND__INIT;
    Highbar__SetOnOffCommand on_off = HIGHBAR__SET_ON_OFF_COMMAND__INIT;
    on_off.unit_id = 5;
    on_off.on = 1;
    cmd.command_case = HIGHBAR__AICOMMAND__COMMAND_SET_ON_OFF;
    cmd.set_on_off = &on_off;

    int rc = hb_deserialize_and_execute(&cmd, 0, cb->Engine_handleCommand);
    assert(rc == 0);
    assert(mock_engine_get_last_command_topic() == COMMAND_SET_ON_OFF);
}

TEST(test_draw_add_point_command) {
    Highbar__AICommand cmd = HIGHBAR__AICOMMAND__INIT;
    Highbar__DrawAddPointCommand draw = HIGHBAR__DRAW_ADD_POINT_COMMAND__INIT;
    Highbar__Vector3 pos = HIGHBAR__VECTOR3__INIT;
    pos.x = 10; pos.y = 20; pos.z = 30;
    draw.position = &pos;
    draw.label = "marker";
    cmd.command_case = HIGHBAR__AICOMMAND__COMMAND_DRAW_ADD_POINT;
    cmd.draw_add_point = &draw;

    int rc = hb_deserialize_and_execute(&cmd, 0, cb->Engine_handleCommand);
    assert(rc == 0);
    assert(mock_engine_get_last_command_topic() == COMMAND_DRAW_ADD_POINT);
}

TEST(test_send_text_message_command) {
    Highbar__AICommand cmd = HIGHBAR__AICOMMAND__INIT;
    Highbar__SendTextMessageCommand msg = HIGHBAR__SEND_TEXT_MESSAGE_COMMAND__INIT;
    msg.text = "Hello from AI";
    msg.zone = 0;
    cmd.command_case = HIGHBAR__AICOMMAND__COMMAND_SEND_TEXT_MESSAGE;
    cmd.send_text_message = &msg;

    int rc = hb_deserialize_and_execute(&cmd, 0, cb->Engine_handleCommand);
    assert(rc == 0);
    assert(mock_engine_get_last_command_topic() == COMMAND_SEND_TEXT_MESSAGE);
}

TEST(test_fight_command) {
    Highbar__AICommand cmd = HIGHBAR__AICOMMAND__INIT;
    Highbar__FightCommand fight = HIGHBAR__FIGHT_COMMAND__INIT;
    Highbar__Vector3 pos = HIGHBAR__VECTOR3__INIT;
    pos.x = 500; pos.y = 0; pos.z = 600;
    fight.unit_id = 4;
    fight.to_position = &pos;
    cmd.command_case = HIGHBAR__AICOMMAND__COMMAND_FIGHT;
    cmd.fight = &fight;

    int rc = hb_deserialize_and_execute(&cmd, 0, cb->Engine_handleCommand);
    assert(rc == 0);
    assert(mock_engine_get_last_command_topic() == COMMAND_FIGHT);
    assert(mock_engine_get_last_command_id() == -1);
}

TEST(test_self_destruct_command) {
    Highbar__AICommand cmd = HIGHBAR__AICOMMAND__INIT;
    Highbar__SelfDestructCommand sd = HIGHBAR__SELF_DESTRUCT_COMMAND__INIT;
    sd.unit_id = 6;
    cmd.command_case = HIGHBAR__AICOMMAND__COMMAND_SELF_DESTRUCT;
    cmd.self_destruct = &sd;

    int rc = hb_deserialize_and_execute(&cmd, 0, cb->Engine_handleCommand);
    assert(rc == 0);
    assert(mock_engine_get_last_command_topic() == COMMAND_SELF_DESTRUCT);
    assert(mock_engine_get_last_command_id() == -1);
}

TEST(test_give_me_new_unit_command) {
    Highbar__AICommand cmd = HIGHBAR__AICOMMAND__INIT;
    Highbar__GiveMeNewUnitCommand give = HIGHBAR__GIVE_ME_NEW_UNIT_COMMAND__INIT;
    Highbar__Vector3 pos = HIGHBAR__VECTOR3__INIT;
    pos.x = 100; pos.y = 0; pos.z = 100;
    give.unit_def_id = 42;
    give.position = &pos;
    cmd.command_case = HIGHBAR__AICOMMAND__COMMAND_GIVE_ME_NEW_UNIT;
    cmd.give_me_new_unit = &give;

    int rc = hb_deserialize_and_execute(&cmd, 0, cb->Engine_handleCommand);
    assert(rc == 0);
    assert(mock_engine_get_last_command_topic() == COMMAND_GIVE_ME_NEW_UNIT);
    assert(mock_engine_get_last_command_id() == -1);
}

TEST(test_give_me_command) {
    Highbar__AICommand cmd = HIGHBAR__AICOMMAND__INIT;
    Highbar__GiveMeCommand give = HIGHBAR__GIVE_ME_COMMAND__INIT;
    give.resource_id = 0;
    give.amount = 1000.0f;
    cmd.command_case = HIGHBAR__AICOMMAND__COMMAND_GIVE_ME;
    cmd.give_me = &give;

    int rc = hb_deserialize_and_execute(&cmd, 0, cb->Engine_handleCommand);
    assert(rc == 0);
    assert(mock_engine_get_last_command_topic() == COMMAND_GIVE_ME);
    assert(mock_engine_get_last_command_id() == -1);
}

TEST(test_multiple_commands) {
    // Test batch of commands
    Highbar__AICommand cmd1 = HIGHBAR__AICOMMAND__INIT;
    Highbar__StopCommand stop = HIGHBAR__STOP_COMMAND__INIT;
    stop.unit_id = 1;
    cmd1.command_case = HIGHBAR__AICOMMAND__COMMAND_STOP;
    cmd1.stop = &stop;

    Highbar__AICommand cmd2 = HIGHBAR__AICOMMAND__INIT;
    Highbar__MoveUnitCommand move = HIGHBAR__MOVE_UNIT_COMMAND__INIT;
    Highbar__Vector3 pos = HIGHBAR__VECTOR3__INIT;
    pos.x = 100; pos.y = 0; pos.z = 100;
    move.unit_id = 2;
    move.to_position = &pos;
    cmd2.command_case = HIGHBAR__AICOMMAND__COMMAND_MOVE_UNIT;
    cmd2.move_unit = &move;

    hb_deserialize_and_execute(&cmd1, 0, cb->Engine_handleCommand);
    hb_deserialize_and_execute(&cmd2, 0, cb->Engine_handleCommand);
    assert(mock_engine_get_command_count() == 2);
    assert(mock_engine_get_recorded_topic(0) == COMMAND_STOP);
    assert(mock_engine_get_recorded_topic(1) == COMMAND_MOVE_UNIT);
    assert(mock_engine_get_recorded_command_id(0) == -1);
    assert(mock_engine_get_recorded_command_id(1) == -1);
}

TEST(test_unknown_command) {
    Highbar__AICommand cmd = HIGHBAR__AICOMMAND__INIT;
    cmd.command_case = HIGHBAR__AICOMMAND__COMMAND__NOT_SET;
    int rc = hb_deserialize_and_execute(&cmd, 0, cb->Engine_handleCommand);
    assert(rc == -1); // Unknown command
    assert(mock_engine_get_command_count() == 0);
}

int main(void) {
    cb = mock_engine_create();
    printf("Running deserialization tests...\n");

    RUN(test_move_command);
    RUN(test_build_command);
    RUN(test_patrol_command);
    RUN(test_attack_command);
    RUN(test_stop_command);
    RUN(test_guard_command);
    RUN(test_repair_command);
    RUN(test_custom_command);
    RUN(test_set_on_off_command);
    RUN(test_draw_add_point_command);
    RUN(test_send_text_message_command);
    RUN(test_fight_command);
    RUN(test_self_destruct_command);
    RUN(test_give_me_new_unit_command);
    RUN(test_give_me_command);
    RUN(test_multiple_commands);
    RUN(test_unknown_command);

    printf("All %d deserialization tests passed!\n", 17);
    return 0;
}
