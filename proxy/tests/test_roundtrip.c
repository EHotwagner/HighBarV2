#include "highbar/serialize.h"
#include "highbar/deserialize.h"
#include "highbar/engine_types.h"
#include "highbar/arena.h"
#include "highbar/events.pb-c.h"
#include "highbar/messages.pb-c.h"
#include "mock_engine.h"
#include <assert.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <math.h>

static HB_Arena arena;

#define TEST(name) static void name(void)
#define RUN(name) do { \
    printf("  " #name "..."); \
    hb_arena_reset(&arena); \
    name(); \
    printf(" OK\n"); \
} while(0)

// Test that serializing events into a Frame, packing, unpacking, and reading
// back produces identical data
TEST(test_frame_roundtrip) {
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);

    // Create a few events
    struct SUnitCreatedEvent e1 = { .unit = 10, .builder = 5 };
    struct SUnitDamagedEvent e2 = {
        .unit = 1, .attacker = 2, .damage = 50.5f,
        .dir_x = 1.0f, .dir_y = 0.0f, .dir_z = 0.0f,
        .weaponDefId = 3, .paralyzer = 0
    };
    struct SUpdateEvent e3 = { .frame = 100 };

    Highbar__EngineEvent *ev1 = hb_serialize_event(EVENT_UNIT_CREATED, &e1, &alloc);
    Highbar__EngineEvent *ev2 = hb_serialize_event(EVENT_UNIT_DAMAGED, &e2, &alloc);
    Highbar__EngineEvent *ev3 = hb_serialize_event(EVENT_UPDATE, &e3, &alloc);
    assert(ev1 && ev2 && ev3);

    // Build Frame
    Highbar__Frame frame = HIGHBAR__FRAME__INIT;
    frame.frame_number = 100;
    Highbar__EngineEvent *events[] = { ev1, ev2, ev3 };
    frame.events = events;
    frame.n_events = 3;

    // Wrap in ProxyMessage
    Highbar__ProxyMessage msg = HIGHBAR__PROXY_MESSAGE__INIT;
    msg.message_case = HIGHBAR__PROXY_MESSAGE__MESSAGE_FRAME;
    msg.frame = &frame;

    // Pack
    size_t len = highbar__proxy_message__get_packed_size(&msg);
    uint8_t *buf = malloc(len);
    assert(buf);
    highbar__proxy_message__pack(&msg, buf);

    // Unpack
    Highbar__ProxyMessage *msg2 = highbar__proxy_message__unpack(NULL, len, buf);
    assert(msg2);
    assert(msg2->message_case == HIGHBAR__PROXY_MESSAGE__MESSAGE_FRAME);
    assert(msg2->frame->frame_number == 100);
    assert(msg2->frame->n_events == 3);

    // Verify events
    assert(msg2->frame->events[0]->event_case == HIGHBAR__ENGINE_EVENT__EVENT_UNIT_CREATED);
    assert(msg2->frame->events[0]->unit_created->unit_id == 10);
    assert(msg2->frame->events[0]->unit_created->builder_id == 5);

    assert(msg2->frame->events[1]->event_case == HIGHBAR__ENGINE_EVENT__EVENT_UNIT_DAMAGED);
    assert(msg2->frame->events[1]->unit_damaged->unit_id == 1);
    assert(msg2->frame->events[1]->unit_damaged->attacker_id == 2);
    assert(fabsf(msg2->frame->events[1]->unit_damaged->damage - 50.5f) < 0.01f);

    assert(msg2->frame->events[2]->event_case == HIGHBAR__ENGINE_EVENT__EVENT_UPDATE);
    assert(msg2->frame->events[2]->update->frame == 100);

    highbar__proxy_message__free_unpacked(msg2, NULL);
    free(buf);
}

TEST(test_handshake_roundtrip) {
    Highbar__Handshake hs = HIGHBAR__HANDSHAKE__INIT;
    hs.protocol_version = 1;
    hs.engine_version = "104.0";
    hs.game_id = "test-game";
    hs.map_name = "SmallDivide";
    hs.mod_name = "BAR";
    hs.team_id = 1;
    hs.ally_team_id = 0;
    hs.player_count = 2;

    Highbar__ProxyMessage msg = HIGHBAR__PROXY_MESSAGE__INIT;
    msg.message_case = HIGHBAR__PROXY_MESSAGE__MESSAGE_HANDSHAKE;
    msg.handshake = &hs;

    size_t len = highbar__proxy_message__get_packed_size(&msg);
    uint8_t *buf = malloc(len);
    highbar__proxy_message__pack(&msg, buf);

    Highbar__ProxyMessage *msg2 = highbar__proxy_message__unpack(NULL, len, buf);
    assert(msg2->handshake->protocol_version == 1);
    assert(strcmp(msg2->handshake->map_name, "SmallDivide") == 0);
    assert(msg2->handshake->team_id == 1);

    highbar__proxy_message__free_unpacked(msg2, NULL);
    free(buf);
}

TEST(test_frame_response_roundtrip) {
    Highbar__FrameResponse fr = HIGHBAR__FRAME_RESPONSE__INIT;
    Highbar__AICommand cmd1 = HIGHBAR__AICOMMAND__INIT;
    Highbar__MoveUnitCommand move = HIGHBAR__MOVE_UNIT_COMMAND__INIT;
    Highbar__Vector3 pos = HIGHBAR__VECTOR3__INIT;
    pos.x = 100; pos.y = 0; pos.z = 200;
    move.unit_id = 5;
    move.to_position = &pos;
    cmd1.command_case = HIGHBAR__AICOMMAND__COMMAND_MOVE_UNIT;
    cmd1.move_unit = &move;

    Highbar__AICommand *cmds[] = { &cmd1 };
    fr.commands = cmds;
    fr.n_commands = 1;

    Highbar__AIMessage msg = HIGHBAR__AIMESSAGE__INIT;
    msg.message_case = HIGHBAR__AIMESSAGE__MESSAGE_FRAME_RESPONSE;
    msg.frame_response = &fr;

    size_t len = highbar__aimessage__get_packed_size(&msg);
    uint8_t *buf = malloc(len);
    highbar__aimessage__pack(&msg, buf);

    Highbar__AIMessage *msg2 = highbar__aimessage__unpack(NULL, len, buf);
    assert(msg2->frame_response->n_commands == 1);
    assert(msg2->frame_response->commands[0]->command_case == HIGHBAR__AICOMMAND__COMMAND_MOVE_UNIT);
    assert(msg2->frame_response->commands[0]->move_unit->unit_id == 5);

    highbar__aimessage__free_unpacked(msg2, NULL);
    free(buf);
}

int main(void) {
    hb_arena_init(&arena, 1024 * 64);
    printf("Running round-trip tests...\n");

    RUN(test_frame_roundtrip);
    RUN(test_handshake_roundtrip);
    RUN(test_frame_response_roundtrip);

    printf("All %d round-trip tests passed!\n", 3);
    hb_arena_destroy(&arena);
    return 0;
}
