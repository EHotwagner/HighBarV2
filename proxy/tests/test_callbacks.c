#include "highbar/callbacks.h"
#include "highbar/engine_types.h"
#include "highbar/arena.h"
#include "highbar/callbacks.pb-c.h"
#include "mock_engine.h"
#include <assert.h>
#include <stdio.h>
#include <math.h>

static HB_Arena arena;
static struct SSkirmishAICallback *cb;

#define TEST(name) static void name(void)
#define RUN(name) do { \
    printf("  " #name "..."); \
    hb_arena_reset(&arena); \
    name(); \
    printf(" OK\n"); \
} while(0)

TEST(test_get_my_team) {
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__CallbackRequest req = HIGHBAR__CALLBACK_REQUEST__INIT;
    req.request_id = 1;
    req.callback_id = HIGHBAR__CALLBACK_ID__CALLBACK_GAME_GET_MY_TEAM;

    Highbar__CallbackResponse *resp = hb_callback_dispatch(&req, 0, cb, &alloc);
    assert(resp != NULL);
    assert(resp->success == 1);
    assert(resp->result->value_case == HIGHBAR__CALLBACK_RESULT__VALUE_INT_VALUE);
    assert(resp->result->int_value == 1); // mock returns 1
}

TEST(test_get_map_width) {
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__CallbackRequest req = HIGHBAR__CALLBACK_REQUEST__INIT;
    req.request_id = 2;
    req.callback_id = HIGHBAR__CALLBACK_ID__CALLBACK_MAP_GET_WIDTH;

    Highbar__CallbackResponse *resp = hb_callback_dispatch(&req, 0, cb, &alloc);
    assert(resp->success == 1);
    assert(resp->result->int_value == 512); // mock map width
}

TEST(test_get_map_height) {
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__CallbackRequest req = HIGHBAR__CALLBACK_REQUEST__INIT;
    req.request_id = 3;
    req.callback_id = HIGHBAR__CALLBACK_ID__CALLBACK_MAP_GET_HEIGHT;

    Highbar__CallbackResponse *resp = hb_callback_dispatch(&req, 0, cb, &alloc);
    assert(resp->success == 1);
    assert(resp->result->int_value == 512);
}

TEST(test_get_unit_pos) {
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__CallbackRequest req = HIGHBAR__CALLBACK_REQUEST__INIT;
    req.request_id = 4;
    req.callback_id = HIGHBAR__CALLBACK_ID__CALLBACK_UNIT_GET_POS;

    // Create param for unit_id = 5
    Highbar__CallbackParam param = HIGHBAR__CALLBACK_PARAM__INIT;
    param.value_case = HIGHBAR__CALLBACK_PARAM__VALUE_INT_VALUE;
    param.int_value = 5;
    Highbar__CallbackParam *params[] = { &param };
    req.params = params;
    req.n_params = 1;

    Highbar__CallbackResponse *resp = hb_callback_dispatch(&req, 0, cb, &alloc);
    assert(resp->success == 1);
    assert(resp->result->value_case == HIGHBAR__CALLBACK_RESULT__VALUE_VECTOR_VALUE);
    // Mock: pos[0] = unitId * 100 = 500, pos[1] = 50, pos[2] = unitId * 200 = 1000
    assert(fabsf(resp->result->vector_value->x - 500.0f) < 0.01f);
    assert(fabsf(resp->result->vector_value->y - 50.0f) < 0.01f);
    assert(fabsf(resp->result->vector_value->z - 1000.0f) < 0.01f);
}

TEST(test_get_unit_health) {
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__CallbackRequest req = HIGHBAR__CALLBACK_REQUEST__INIT;
    req.request_id = 5;
    req.callback_id = HIGHBAR__CALLBACK_ID__CALLBACK_UNIT_GET_HEALTH;

    Highbar__CallbackParam param = HIGHBAR__CALLBACK_PARAM__INIT;
    param.value_case = HIGHBAR__CALLBACK_PARAM__VALUE_INT_VALUE;
    param.int_value = 3;
    Highbar__CallbackParam *params[] = { &param };
    req.params = params;
    req.n_params = 1;

    Highbar__CallbackResponse *resp = hb_callback_dispatch(&req, 0, cb, &alloc);
    assert(resp->success == 1);
    assert(resp->result->value_case == HIGHBAR__CALLBACK_RESULT__VALUE_FLOAT_VALUE);
    assert(fabsf(resp->result->float_value - 300.0f) < 0.01f); // mock: unitId * 100
}

TEST(test_unknown_callback) {
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__CallbackRequest req = HIGHBAR__CALLBACK_REQUEST__INIT;
    req.request_id = 99;
    req.callback_id = 9999; // nonexistent

    Highbar__CallbackResponse *resp = hb_callback_dispatch(&req, 0, cb, &alloc);
    assert(resp != NULL);
    assert(resp->success == 0);
}

TEST(test_unit_pos_no_param) {
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__CallbackRequest req = HIGHBAR__CALLBACK_REQUEST__INIT;
    req.request_id = 6;
    req.callback_id = HIGHBAR__CALLBACK_ID__CALLBACK_UNIT_GET_POS;
    req.n_params = 0;

    Highbar__CallbackResponse *resp = hb_callback_dispatch(&req, 0, cb, &alloc);
    assert(resp->success == 0); // Should fail — no unit_id param
}

int main(void) {
    cb = mock_engine_create();
    hb_arena_init(&arena, 1024 * 64);
    printf("Running callback tests...\n");

    RUN(test_get_my_team);
    RUN(test_get_map_width);
    RUN(test_get_map_height);
    RUN(test_get_unit_pos);
    RUN(test_get_unit_health);
    RUN(test_unknown_callback);
    RUN(test_unit_pos_no_param);

    printf("All %d callback tests passed!\n", 7);
    hb_arena_destroy(&arena);
    return 0;
}
