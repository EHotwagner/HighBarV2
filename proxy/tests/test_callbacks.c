#include "highbar/callbacks.h"
#include "highbar/engine_types.h"
#include "highbar/arena.h"
#include "highbar/callbacks.pb-c.h"
#include "mock_engine.h"
#include <assert.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
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

// -- Map data callback tests (T007-T009, T012-T013, T016-T017, T018-T020) --

TEST(test_get_height_map) {
    mock_engine_set_map_size(4, 4);
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__CallbackRequest req = HIGHBAR__CALLBACK_REQUEST__INIT;
    req.request_id = 100;
    req.callback_id = HIGHBAR__CALLBACK_ID__CALLBACK_MAP_GET_HEIGHT_MAP;

    Highbar__CallbackResponse *resp = hb_callback_dispatch(&req, 0, cb, &alloc);
    assert(resp != NULL);
    assert(resp->success == 1);
    assert(resp->result->value_case == HIGHBAR__CALLBACK_RESULT__VALUE_FLOAT_ARRAY_VALUE);
    assert(resp->result->float_array_value->n_values == 16);
    assert(fabsf(resp->result->float_array_value->values[0] - 1.0f) < 0.01f);
    assert(fabsf(resp->result->float_array_value->values[15] - 16.0f) < 0.01f);
}

TEST(test_get_corners_height_map) {
    mock_engine_set_map_size(4, 4);
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__CallbackRequest req = HIGHBAR__CALLBACK_REQUEST__INIT;
    req.request_id = 120;
    req.callback_id = HIGHBAR__CALLBACK_ID__CALLBACK_MAP_GET_CORNERS_HEIGHT_MAP;

    Highbar__CallbackResponse *resp = hb_callback_dispatch(&req, 0, cb, &alloc);
    assert(resp != NULL);
    assert(resp->success == 1);
    assert(resp->result->value_case == HIGHBAR__CALLBACK_RESULT__VALUE_FLOAT_ARRAY_VALUE);
    assert(resp->result->float_array_value->n_values == 25); // (4+1)*(4+1)
    assert(fabsf(resp->result->float_array_value->values[0] - 1.0f) < 0.01f);
    assert(fabsf(resp->result->float_array_value->values[24] - 25.0f) < 0.01f);
}

TEST(test_get_slope_map) {
    mock_engine_set_map_size(4, 4);
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__CallbackRequest req = HIGHBAR__CALLBACK_REQUEST__INIT;
    req.request_id = 101;
    req.callback_id = HIGHBAR__CALLBACK_ID__CALLBACK_MAP_GET_SLOPE_MAP;

    Highbar__CallbackResponse *resp = hb_callback_dispatch(&req, 0, cb, &alloc);
    assert(resp != NULL);
    assert(resp->success == 1);
    assert(resp->result->value_case == HIGHBAR__CALLBACK_RESULT__VALUE_FLOAT_ARRAY_VALUE);
    assert(resp->result->float_array_value->n_values == 4); // (4/2)*(4/2)
    assert(fabsf(resp->result->float_array_value->values[0] - 0.1f) < 0.01f);
    assert(fabsf(resp->result->float_array_value->values[3] - 0.4f) < 0.01f);
}

TEST(test_get_resource_map) {
    mock_engine_set_map_size(4, 4);
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__CallbackRequest req = HIGHBAR__CALLBACK_REQUEST__INIT;
    req.request_id = 102;
    req.callback_id = HIGHBAR__CALLBACK_ID__CALLBACK_MAP_GET_RESOURCE_MAP;

    // Param: resource ID = 0 (metal)
    Highbar__CallbackParam param = HIGHBAR__CALLBACK_PARAM__INIT;
    param.value_case = HIGHBAR__CALLBACK_PARAM__VALUE_INT_VALUE;
    param.int_value = 0;
    Highbar__CallbackParam *params[] = { &param };
    req.params = params;
    req.n_params = 1;

    Highbar__CallbackResponse *resp = hb_callback_dispatch(&req, 0, cb, &alloc);
    assert(resp != NULL);
    assert(resp->success == 1);
    assert(resp->result->value_case == HIGHBAR__CALLBACK_RESULT__VALUE_INT_ARRAY_VALUE);
    assert(resp->result->int_array_value->n_values == 4); // (4/2)*(4/2)
    // Verify short->int widening: mock_resourcemap = {100, 200, 0, 150}
    assert(resp->result->int_array_value->values[0] == 100);
    assert(resp->result->int_array_value->values[1] == 200);
    assert(resp->result->int_array_value->values[2] == 0);
    assert(resp->result->int_array_value->values[3] == 150);
}

TEST(test_get_los_map) {
    mock_engine_set_map_size(4, 4);
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__CallbackRequest req = HIGHBAR__CALLBACK_REQUEST__INIT;
    req.request_id = 103;
    req.callback_id = HIGHBAR__CALLBACK_ID__CALLBACK_MAP_GET_LOS_MAP;

    Highbar__CallbackResponse *resp = hb_callback_dispatch(&req, 0, cb, &alloc);
    assert(resp != NULL);
    assert(resp->success == 1);
    assert(resp->result->value_case == HIGHBAR__CALLBACK_RESULT__VALUE_INT_ARRAY_VALUE);
    assert(resp->result->int_array_value->n_values == 16);
    // mock_losmap[0] = 1, [1] = 0
    assert(resp->result->int_array_value->values[0] == 1);
    assert(resp->result->int_array_value->values[1] == 0);
}

TEST(test_get_radar_map) {
    mock_engine_set_map_size(4, 4);
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__CallbackRequest req = HIGHBAR__CALLBACK_REQUEST__INIT;
    req.request_id = 104;
    req.callback_id = HIGHBAR__CALLBACK_ID__CALLBACK_MAP_GET_RADAR_MAP;

    Highbar__CallbackResponse *resp = hb_callback_dispatch(&req, 0, cb, &alloc);
    assert(resp != NULL);
    assert(resp->success == 1);
    assert(resp->result->value_case == HIGHBAR__CALLBACK_RESULT__VALUE_INT_ARRAY_VALUE);
    assert(resp->result->int_array_value->n_values == 16);
    // mock_radarmap[0] = 0, [1] = 1
    assert(resp->result->int_array_value->values[0] == 0);
    assert(resp->result->int_array_value->values[1] == 1);
}

TEST(test_get_start_pos) {
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__CallbackRequest req = HIGHBAR__CALLBACK_REQUEST__INIT;
    req.request_id = 105;
    req.callback_id = HIGHBAR__CALLBACK_ID__CALLBACK_MAP_GET_START_POS;

    Highbar__CallbackResponse *resp = hb_callback_dispatch(&req, 0, cb, &alloc);
    assert(resp != NULL);
    assert(resp->success == 1);
    assert(resp->result->value_case == HIGHBAR__CALLBACK_RESULT__VALUE_VECTOR_VALUE);
    assert(fabsf(resp->result->vector_value->x - 1024.0f) < 0.01f);
    assert(fabsf(resp->result->vector_value->y - 80.0f) < 0.01f);
    assert(fabsf(resp->result->vector_value->z - 2048.0f) < 0.01f);
}

TEST(test_get_metal_spots) {
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__CallbackRequest req = HIGHBAR__CALLBACK_REQUEST__INIT;
    req.request_id = 106;
    req.callback_id = HIGHBAR__CALLBACK_ID__CALLBACK_MAP_GET_METAL_SPOTS;

    Highbar__CallbackResponse *resp = hb_callback_dispatch(&req, 0, cb, &alloc);
    assert(resp != NULL);
    assert(resp->success == 1);
    assert(resp->result->value_case == HIGHBAR__CALLBACK_RESULT__VALUE_FLOAT_ARRAY_VALUE);
    // 2 spots * 4 floats (x,y,z,income) = 8
    assert(resp->result->float_array_value->n_values == 8);
    // Spot 0: x=512, y=40, z=768, income=2.5
    assert(fabsf(resp->result->float_array_value->values[0] - 512.0f) < 0.01f);
    assert(fabsf(resp->result->float_array_value->values[1] - 40.0f) < 0.01f);
    assert(fabsf(resp->result->float_array_value->values[2] - 768.0f) < 0.01f);
    assert(fabsf(resp->result->float_array_value->values[3] - 2.5f) < 0.01f);
    // Spot 1: x=1536, y=60, z=1280, income=2.5
    assert(fabsf(resp->result->float_array_value->values[4] - 1536.0f) < 0.01f);
    assert(fabsf(resp->result->float_array_value->values[7] - 2.5f) < 0.01f);
}

TEST(test_large_heightmap) {
    mock_engine_set_map_size(64, 64);
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__CallbackRequest req = HIGHBAR__CALLBACK_REQUEST__INIT;
    req.request_id = 107;
    req.callback_id = HIGHBAR__CALLBACK_ID__CALLBACK_MAP_GET_HEIGHT_MAP;

    Highbar__CallbackResponse *resp = hb_callback_dispatch(&req, 0, cb, &alloc);
    assert(resp != NULL);
    assert(resp->success == 1);
    assert(resp->result->value_case == HIGHBAR__CALLBACK_RESULT__VALUE_FLOAT_ARRAY_VALUE);
    assert(resp->result->float_array_value->n_values == 4096); // 64*64
    // First 16 values should match mock_heightmap, rest are index values
    assert(fabsf(resp->result->float_array_value->values[0] - 1.0f) < 0.01f);
    assert(fabsf(resp->result->float_array_value->values[16] - 16.0f) < 0.01f);
    mock_engine_set_map_size(4, 4); // restore
}

TEST(test_null_function_pointer) {
    // Create a callback struct with Map_getHeightMap = NULL
    struct SSkirmishAICallback null_cb;
    memset(&null_cb, 0, sizeof(null_cb));
    null_cb.Map_getWidth = cb->Map_getWidth;
    null_cb.Map_getHeight = cb->Map_getHeight;
    // Map_getHeightMap is NULL

    mock_engine_set_map_size(4, 4);
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__CallbackRequest req = HIGHBAR__CALLBACK_REQUEST__INIT;
    req.request_id = 108;
    req.callback_id = HIGHBAR__CALLBACK_ID__CALLBACK_MAP_GET_HEIGHT_MAP;

    Highbar__CallbackResponse *resp = hb_callback_dispatch(&req, 0, &null_cb, &alloc);
    assert(resp != NULL);
    assert(resp->success == 0); // Error — callback not available
}

TEST(test_get_corners_height_map_unavailable) {
    // Create a callback struct with Map_getCornersHeightMap = NULL
    struct SSkirmishAICallback null_cb;
    memset(&null_cb, 0, sizeof(null_cb));
    null_cb.Map_getWidth = cb->Map_getWidth;
    null_cb.Map_getHeight = cb->Map_getHeight;
    // Map_getCornersHeightMap is NULL

    mock_engine_set_map_size(4, 4);
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__CallbackRequest req = HIGHBAR__CALLBACK_REQUEST__INIT;
    req.request_id = 121;
    req.callback_id = HIGHBAR__CALLBACK_ID__CALLBACK_MAP_GET_CORNERS_HEIGHT_MAP;

    Highbar__CallbackResponse *resp = hb_callback_dispatch(&req, 0, &null_cb, &alloc);
    assert(resp != NULL);
    assert(resp->success == 0); // Error — callback not available
}

// -- Economy callback tests (029-fix-trainer-issues Issue 2) --

TEST(test_economy_get_current_returns_value) {
    mock_engine_reset();
    mock_engine_set_economy_current(0, 123.5f);
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__CallbackRequest req = HIGHBAR__CALLBACK_REQUEST__INIT;
    req.request_id = 200;
    req.callback_id = HIGHBAR__CALLBACK_ID__CALLBACK_ECONOMY_GET_CURRENT;
    Highbar__CallbackParam param = HIGHBAR__CALLBACK_PARAM__INIT;
    param.value_case = HIGHBAR__CALLBACK_PARAM__VALUE_INT_VALUE;
    param.int_value = 0;
    Highbar__CallbackParam *params[] = { &param };
    req.params = params;
    req.n_params = 1;

    Highbar__CallbackResponse *resp = hb_callback_dispatch(&req, 0, cb, &alloc);
    assert(resp != NULL);
    assert(resp->success == 1);
    assert(resp->result->value_case == HIGHBAR__CALLBACK_RESULT__VALUE_FLOAT_VALUE);
    assert(fabsf(resp->result->float_value - 123.5f) < 0.01f);
}

TEST(test_economy_get_current_invalid_id_returns_nan) {
    mock_engine_reset();
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__CallbackRequest req = HIGHBAR__CALLBACK_REQUEST__INIT;
    req.request_id = 201;
    req.callback_id = HIGHBAR__CALLBACK_ID__CALLBACK_ECONOMY_GET_CURRENT;
    Highbar__CallbackParam param = HIGHBAR__CALLBACK_PARAM__INIT;
    param.value_case = HIGHBAR__CALLBACK_PARAM__VALUE_INT_VALUE;
    param.int_value = 99;
    Highbar__CallbackParam *params[] = { &param };
    req.params = params;
    req.n_params = 1;

    Highbar__CallbackResponse *resp = hb_callback_dispatch(&req, 0, cb, &alloc);
    assert(resp != NULL);
    assert(resp->success == 1);
    assert(resp->result->value_case == HIGHBAR__CALLBACK_RESULT__VALUE_FLOAT_VALUE);
    assert(isnan(resp->result->float_value));
}

TEST(test_economy_get_income_returns_value) {
    mock_engine_reset();
    mock_engine_set_economy_income(1, 45.25f);
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__CallbackRequest req = HIGHBAR__CALLBACK_REQUEST__INIT;
    req.request_id = 202;
    req.callback_id = HIGHBAR__CALLBACK_ID__CALLBACK_ECONOMY_GET_INCOME;
    Highbar__CallbackParam param = HIGHBAR__CALLBACK_PARAM__INIT;
    param.value_case = HIGHBAR__CALLBACK_PARAM__VALUE_INT_VALUE;
    param.int_value = 1;
    Highbar__CallbackParam *params[] = { &param };
    req.params = params;
    req.n_params = 1;

    Highbar__CallbackResponse *resp = hb_callback_dispatch(&req, 0, cb, &alloc);
    assert(resp->success == 1);
    assert(fabsf(resp->result->float_value - 45.25f) < 0.01f);
}

TEST(test_economy_get_usage_returns_value) {
    mock_engine_reset();
    mock_engine_set_economy_usage(0, 7.75f);
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__CallbackRequest req = HIGHBAR__CALLBACK_REQUEST__INIT;
    req.request_id = 203;
    req.callback_id = HIGHBAR__CALLBACK_ID__CALLBACK_ECONOMY_GET_USAGE;
    Highbar__CallbackParam param = HIGHBAR__CALLBACK_PARAM__INIT;
    param.value_case = HIGHBAR__CALLBACK_PARAM__VALUE_INT_VALUE;
    param.int_value = 0;
    Highbar__CallbackParam *params[] = { &param };
    req.params = params;
    req.n_params = 1;

    Highbar__CallbackResponse *resp = hb_callback_dispatch(&req, 0, cb, &alloc);
    assert(resp->success == 1);
    assert(fabsf(resp->result->float_value - 7.75f) < 0.01f);
}

TEST(test_economy_get_storage_returns_value) {
    mock_engine_reset();
    mock_engine_set_economy_storage(1, 999.0f);
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__CallbackRequest req = HIGHBAR__CALLBACK_REQUEST__INIT;
    req.request_id = 204;
    req.callback_id = HIGHBAR__CALLBACK_ID__CALLBACK_ECONOMY_GET_STORAGE;
    Highbar__CallbackParam param = HIGHBAR__CALLBACK_PARAM__INIT;
    param.value_case = HIGHBAR__CALLBACK_PARAM__VALUE_INT_VALUE;
    param.int_value = 1;
    Highbar__CallbackParam *params[] = { &param };
    req.params = params;
    req.n_params = 1;

    Highbar__CallbackResponse *resp = hb_callback_dispatch(&req, 0, cb, &alloc);
    assert(resp->success == 1);
    assert(fabsf(resp->result->float_value - 999.0f) < 0.01f);
}

TEST(test_zero_count_response) {
    mock_engine_set_map_size(4, 4);
    mock_engine_set_los_return_count(0);
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);
    Highbar__CallbackRequest req = HIGHBAR__CALLBACK_REQUEST__INIT;
    req.request_id = 109;
    req.callback_id = HIGHBAR__CALLBACK_ID__CALLBACK_MAP_GET_LOS_MAP;

    Highbar__CallbackResponse *resp = hb_callback_dispatch(&req, 0, cb, &alloc);
    assert(resp != NULL);
    assert(resp->success == 1);
    assert(resp->result->value_case == HIGHBAR__CALLBACK_RESULT__VALUE_INT_ARRAY_VALUE);
    assert(resp->result->int_array_value->n_values == 0);
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

    // Map data callbacks (021-map-callbacks-proxy, 026-corners-heightmap-callback)
    RUN(test_get_height_map);
    RUN(test_get_corners_height_map);
    RUN(test_get_slope_map);
    RUN(test_get_resource_map);
    RUN(test_get_los_map);
    RUN(test_get_radar_map);
    RUN(test_get_start_pos);
    RUN(test_get_metal_spots);
    RUN(test_large_heightmap);
    RUN(test_null_function_pointer);
    RUN(test_get_corners_height_map_unavailable);
    RUN(test_zero_count_response);

    // Economy callbacks (029 Issue 2)
    RUN(test_economy_get_current_returns_value);
    RUN(test_economy_get_current_invalid_id_returns_nan);
    RUN(test_economy_get_income_returns_value);
    RUN(test_economy_get_usage_returns_value);
    RUN(test_economy_get_storage_returns_value);

    printf("All %d callback tests passed!\n", 24);
    hb_arena_destroy(&arena);
    return 0;
}
