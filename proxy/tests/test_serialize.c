#include "highbar/serialize.h"
#include "highbar/engine_types.h"
#include "highbar/arena.h"
#include "highbar/events.pb-c.h"
#include <assert.h>
#include <stdio.h>
#include <string.h>
#include <math.h>

static HB_Arena arena;

static void setup(void) {
    hb_arena_init(&arena, 1024 * 64);
}

static void teardown(void) {
    hb_arena_destroy(&arena);
}

static void reset(void) {
    hb_arena_reset(&arena);
}

#define TEST(name) static void name(void)
#define RUN(name) do { \
    printf("  " #name "..."); \
    reset(); \
    name(); \
    printf(" OK\n"); \
} while(0)

// -- Round-trip serialization tests for all 28 event types --

TEST(test_init_event) {
    struct SInitEvent e = { .skirmishAIId = 5 };
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__EngineEvent *ev = hb_serialize_event(EVENT_INIT, &e, &alloc);
    assert(ev != NULL);
    assert(ev->event_case == HIGHBAR__ENGINE_EVENT__EVENT_INIT);
    assert(ev->init->team_id == 5);

    // Serialize to bytes and back
    size_t len = highbar__engine_event__get_packed_size(ev);
    uint8_t buf[4096];
    highbar__engine_event__pack(ev, buf);
    Highbar__EngineEvent *ev2 = highbar__engine_event__unpack(NULL, len, buf);
    assert(ev2 != NULL);
    assert(ev2->init->team_id == 5);
    highbar__engine_event__free_unpacked(ev2, NULL);
}

TEST(test_release_event) {
    struct SReleaseEvent e = { .reason = 0 };
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__EngineEvent *ev = hb_serialize_event(EVENT_RELEASE, &e, &alloc);
    assert(ev != NULL);
    assert(ev->event_case == HIGHBAR__ENGINE_EVENT__EVENT_RELEASE);

    size_t len = highbar__engine_event__get_packed_size(ev);
    uint8_t buf[4096];
    highbar__engine_event__pack(ev, buf);
    Highbar__EngineEvent *ev2 = highbar__engine_event__unpack(NULL, len, buf);
    assert(ev2 != NULL);
    assert(ev2->event_case == HIGHBAR__ENGINE_EVENT__EVENT_RELEASE);
    highbar__engine_event__free_unpacked(ev2, NULL);
}

TEST(test_update_event) {
    struct SUpdateEvent e = { .frame = 42 };
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__EngineEvent *ev = hb_serialize_event(EVENT_UPDATE, &e, &alloc);
    assert(ev != NULL);
    assert(ev->update->frame == 42);

    size_t len = highbar__engine_event__get_packed_size(ev);
    uint8_t buf[4096];
    highbar__engine_event__pack(ev, buf);
    Highbar__EngineEvent *ev2 = highbar__engine_event__unpack(NULL, len, buf);
    assert(ev2->update->frame == 42);
    highbar__engine_event__free_unpacked(ev2, NULL);
}

TEST(test_message_event) {
    struct SMessageEvent e = { .player = 3, .message = "hello" };
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__EngineEvent *ev = hb_serialize_event(EVENT_MESSAGE, &e, &alloc);
    assert(ev != NULL);
    assert(ev->message->player == 3);
    assert(strcmp(ev->message->message, "hello") == 0);

    size_t len = highbar__engine_event__get_packed_size(ev);
    uint8_t buf[4096];
    highbar__engine_event__pack(ev, buf);
    Highbar__EngineEvent *ev2 = highbar__engine_event__unpack(NULL, len, buf);
    assert(ev2->message->player == 3);
    assert(strcmp(ev2->message->message, "hello") == 0);
    highbar__engine_event__free_unpacked(ev2, NULL);
}

TEST(test_unit_created_event) {
    struct SUnitCreatedEvent e = { .unit = 10, .builder = 5 };
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__EngineEvent *ev = hb_serialize_event(EVENT_UNIT_CREATED, &e, &alloc);
    assert(ev->unit_created->unit_id == 10);
    assert(ev->unit_created->builder_id == 5);

    size_t len = highbar__engine_event__get_packed_size(ev);
    uint8_t buf[4096];
    highbar__engine_event__pack(ev, buf);
    Highbar__EngineEvent *ev2 = highbar__engine_event__unpack(NULL, len, buf);
    assert(ev2->unit_created->unit_id == 10);
    assert(ev2->unit_created->builder_id == 5);
    highbar__engine_event__free_unpacked(ev2, NULL);
}

TEST(test_unit_finished_event) {
    struct SUnitFinishedEvent e = { .unit = 7 };
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__EngineEvent *ev = hb_serialize_event(EVENT_UNIT_FINISHED, &e, &alloc);
    assert(ev->unit_finished->unit_id == 7);
}

TEST(test_unit_idle_event) {
    struct SUnitIdleEvent e = { .unit = 8 };
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__EngineEvent *ev = hb_serialize_event(EVENT_UNIT_IDLE, &e, &alloc);
    assert(ev->unit_idle->unit_id == 8);
}

TEST(test_unit_move_failed_event) {
    struct SUnitMoveFailedEvent e = { .unit = 9 };
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__EngineEvent *ev = hb_serialize_event(EVENT_UNIT_MOVE_FAILED, &e, &alloc);
    assert(ev->unit_move_failed->unit_id == 9);
}

TEST(test_unit_damaged_event) {
    float dir1[3] = {1.0f, 0.0f, 0.0f};
    struct SUnitDamagedEvent e = {
        .unit = 1, .attacker = 2, .damage = 50.5f,
        .dir_posF3 = dir1,
        .weaponDefId = 3, .paralyzer = 1
    };
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__EngineEvent *ev = hb_serialize_event(EVENT_UNIT_DAMAGED, &e, &alloc);
    assert(ev->unit_damaged->unit_id == 1);
    assert(ev->unit_damaged->_attacker_id_case == HIGHBAR__UNIT_DAMAGED_EVENT___ATTACKER_ID_ATTACKER_ID);
    assert(ev->unit_damaged->attacker_id == 2);
    assert(fabsf(ev->unit_damaged->damage - 50.5f) < 0.01f);
    assert(ev->unit_damaged->is_paralyzer == 1);

    size_t len = highbar__engine_event__get_packed_size(ev);
    uint8_t buf[4096];
    highbar__engine_event__pack(ev, buf);
    Highbar__EngineEvent *ev2 = highbar__engine_event__unpack(NULL, len, buf);
    assert(ev2->unit_damaged->attacker_id == 2);
    assert(fabsf(ev2->unit_damaged->damage - 50.5f) < 0.01f);
    highbar__engine_event__free_unpacked(ev2, NULL);
}

TEST(test_unit_damaged_no_attacker) {
    float dir2[3] = {0, 0, 0};
    struct SUnitDamagedEvent e = {
        .unit = 1, .attacker = -1, .damage = 10.0f,
        .dir_posF3 = dir2,
        .weaponDefId = 0, .paralyzer = 0
    };
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__EngineEvent *ev = hb_serialize_event(EVENT_UNIT_DAMAGED, &e, &alloc);
    assert(ev->unit_damaged->_attacker_id_case == HIGHBAR__UNIT_DAMAGED_EVENT___ATTACKER_ID__NOT_SET);
}

TEST(test_unit_destroyed_event) {
    struct SUnitDestroyedEvent e = { .unit = 4, .attacker = 6 };
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__EngineEvent *ev = hb_serialize_event(EVENT_UNIT_DESTROYED, &e, &alloc);
    assert(ev->unit_destroyed->unit_id == 4);
    assert(ev->unit_destroyed->attacker_id == 6);
}

TEST(test_unit_destroyed_no_attacker) {
    struct SUnitDestroyedEvent e = { .unit = 4, .attacker = -1 };
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__EngineEvent *ev = hb_serialize_event(EVENT_UNIT_DESTROYED, &e, &alloc);
    assert(ev->unit_destroyed->_attacker_id_case == HIGHBAR__UNIT_DESTROYED_EVENT___ATTACKER_ID__NOT_SET);
}

TEST(test_unit_given_event) {
    struct SUnitGivenEvent e = { .unitId = 1, .oldTeamId = 2, .newTeamId = 3 };
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__EngineEvent *ev = hb_serialize_event(EVENT_UNIT_GIVEN, &e, &alloc);
    assert(ev->unit_given->old_team_id == 2);
    assert(ev->unit_given->new_team_id == 3);
}

TEST(test_unit_captured_event) {
    struct SUnitCapturedEvent e = { .unitId = 1, .oldTeamId = 2, .newTeamId = 3 };
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__EngineEvent *ev = hb_serialize_event(EVENT_UNIT_CAPTURED, &e, &alloc);
    assert(ev->unit_captured->old_team_id == 2);
    assert(ev->unit_captured->new_team_id == 3);
}

TEST(test_enemy_enter_los_event) {
    struct SEnemyEnterLOSEvent e = { .enemy = 99 };
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__EngineEvent *ev = hb_serialize_event(EVENT_ENEMY_ENTER_LOS, &e, &alloc);
    assert(ev->enemy_enter_los->enemy_id == 99);
}

TEST(test_enemy_leave_los_event) {
    struct SEnemyLeaveLOSEvent e = { .enemy = 100 };
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__EngineEvent *ev = hb_serialize_event(EVENT_ENEMY_LEAVE_LOS, &e, &alloc);
    assert(ev->enemy_leave_los->enemy_id == 100);
}

TEST(test_enemy_enter_radar_event) {
    struct SEnemyEnterRadarEvent e = { .enemy = 50 };
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__EngineEvent *ev = hb_serialize_event(EVENT_ENEMY_ENTER_RADAR, &e, &alloc);
    assert(ev->enemy_enter_radar->enemy_id == 50);
}

TEST(test_enemy_leave_radar_event) {
    struct SEnemyLeaveRadarEvent e = { .enemy = 51 };
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__EngineEvent *ev = hb_serialize_event(EVENT_ENEMY_LEAVE_RADAR, &e, &alloc);
    assert(ev->enemy_leave_radar->enemy_id == 51);
}

TEST(test_enemy_damaged_event) {
    float dir3[3] = {0, 1, 0};
    struct SEnemyDamagedEvent e = {
        .enemy = 10, .attacker = 5, .damage = 25.0f,
        .dir_posF3 = dir3, .weaponDefId = 7
    };
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__EngineEvent *ev = hb_serialize_event(EVENT_ENEMY_DAMAGED, &e, &alloc);
    assert(ev->enemy_damaged->enemy_id == 10);
    assert(ev->enemy_damaged->attacker_id == 5);
}

TEST(test_enemy_destroyed_event) {
    struct SEnemyDestroyedEvent e = { .enemy = 11, .attacker = -1 };
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__EngineEvent *ev = hb_serialize_event(EVENT_ENEMY_DESTROYED, &e, &alloc);
    assert(ev->enemy_destroyed->_attacker_id_case == HIGHBAR__ENEMY_DESTROYED_EVENT___ATTACKER_ID__NOT_SET);
}

TEST(test_weapon_fired_event) {
    struct SWeaponFiredEvent e = { .unitId = 1, .weaponDefId = 3 };
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__EngineEvent *ev = hb_serialize_event(EVENT_WEAPON_FIRED, &e, &alloc);
    assert(ev->weapon_fired->unit_id == 1);
    assert(ev->weapon_fired->weapon_def_id == 3);
}

TEST(test_player_command_event) {
    int units[] = {1, 2, 3};
    struct SPlayerCommandEvent e = { .unitIds = units, .unitIds_size = 3, .commandTopicId = 42, .playerId = 99 };
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__EngineEvent *ev = hb_serialize_event(EVENT_PLAYER_COMMAND, &e, &alloc);
    assert(ev->player_command->n_units == 3);
    assert(ev->player_command->units[0] == 1);
    assert(ev->player_command->units[2] == 3);
}

TEST(test_seismic_ping_event) {
    float ping_pos[3] = {100, 200, 300};
    struct SSeismicPingEvent e = { .pos_posF3 = ping_pos, .strength = 5.0f };
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__EngineEvent *ev = hb_serialize_event(EVENT_SEISMIC_PING, &e, &alloc);
    assert(fabsf(ev->seismic_ping->position->x - 100.0f) < 0.01f);
    assert(fabsf(ev->seismic_ping->strength - 5.0f) < 0.01f);
}

TEST(test_command_finished_event) {
    struct SCommandFinishedEvent e = { .unitId = 1, .commandId = 2, .commandTopicId = 3 };
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__EngineEvent *ev = hb_serialize_event(EVENT_COMMAND_FINISHED, &e, &alloc);
    assert(ev->command_finished->unit_id == 1);
    assert(ev->command_finished->command_id == 2);
}

TEST(test_load_event) {
    struct SLoadEvent e = { .file = NULL };
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__EngineEvent *ev = hb_serialize_event(EVENT_LOAD, &e, &alloc);
    assert(ev->event_case == HIGHBAR__ENGINE_EVENT__EVENT_LOAD);
}

TEST(test_save_event) {
    struct SSaveEvent e = { .file = NULL };
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__EngineEvent *ev = hb_serialize_event(EVENT_SAVE, &e, &alloc);
    assert(ev->event_case == HIGHBAR__ENGINE_EVENT__EVENT_SAVE);
}

TEST(test_enemy_created_event) {
    struct SEnemyCreatedEvent e = { .enemy = 77 };
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__EngineEvent *ev = hb_serialize_event(EVENT_ENEMY_CREATED, &e, &alloc);
    assert(ev->enemy_created->enemy_id == 77);
}

TEST(test_enemy_finished_event) {
    struct SEnemyFinishedEvent e = { .enemy = 78 };
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__EngineEvent *ev = hb_serialize_event(EVENT_ENEMY_FINISHED, &e, &alloc);
    assert(ev->enemy_finished->enemy_id == 78);
}

TEST(test_lua_message_event) {
    struct SLuaMessageEvent e = { .inData = "test_data" };
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__EngineEvent *ev = hb_serialize_event(EVENT_LUA_MESSAGE, &e, &alloc);
    assert(strcmp(ev->lua_message->data, "test_data") == 0);
}

int main(void) {
    setup();
    printf("Running serialization tests...\n");

    RUN(test_init_event);
    RUN(test_release_event);
    RUN(test_update_event);
    RUN(test_message_event);
    RUN(test_unit_created_event);
    RUN(test_unit_finished_event);
    RUN(test_unit_idle_event);
    RUN(test_unit_move_failed_event);
    RUN(test_unit_damaged_event);
    RUN(test_unit_damaged_no_attacker);
    RUN(test_unit_destroyed_event);
    RUN(test_unit_destroyed_no_attacker);
    RUN(test_unit_given_event);
    RUN(test_unit_captured_event);
    RUN(test_enemy_enter_los_event);
    RUN(test_enemy_leave_los_event);
    RUN(test_enemy_enter_radar_event);
    RUN(test_enemy_leave_radar_event);
    RUN(test_enemy_damaged_event);
    RUN(test_enemy_destroyed_event);
    RUN(test_weapon_fired_event);
    RUN(test_player_command_event);
    RUN(test_seismic_ping_event);
    RUN(test_command_finished_event);
    RUN(test_load_event);
    RUN(test_save_event);
    RUN(test_enemy_created_event);
    RUN(test_enemy_finished_event);
    RUN(test_lua_message_event);

    printf("All %d serialization tests passed!\n", 29);
    teardown();
    return 0;
}
