/*
 * Tests for feature 032: GameStateSnapshot wire contract.
 *
 * T007: Build a GameStateSnapshot via protobuf-c, serialize via arena,
 *       parse back, and assert field-for-field equality (wire round-trip).
 * T011a: Exercise the handler's max-units cap path — a synthetic
 *        getEnemyUnitsInRadarAndLos returning more than the cap must cause
 *        the handler to return success=false + error_message.
 */

#include "highbar/callbacks.h"
#include "highbar/engine_types.h"
#include "highbar/arena.h"
#include "highbar/callbacks.pb-c.h"
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

TEST(test_snapshot_roundtrip) {
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);

    Highbar__GameStateSnapshot snap = HIGHBAR__GAME_STATE_SNAPSHOT__INIT;
    snap.frame = 12345;

    // One friendly, one LOS enemy, one radar-only, full economy
    Highbar__Vector3 fpos = HIGHBAR__VECTOR3__INIT; fpos.x = 100.0f; fpos.y = 50.0f; fpos.z = 200.0f;
    Highbar__FriendlyUnit f = HIGHBAR__FRIENDLY_UNIT__INIT;
    f.unit_id = 1; f.position = &fpos; f.health = 500.0f; f.unit_def_id = 7; f.team = 0;

    Highbar__Vector3 lpos = HIGHBAR__VECTOR3__INIT; lpos.x = 300.0f; lpos.y = 60.0f; lpos.z = 400.0f;
    Highbar__LosEnemyUnit los = HIGHBAR__LOS_ENEMY_UNIT__INIT;
    los.unit_id = 2; los.position = &lpos; los.health = 300.0f; los.unit_def_id = 11; los.team = 1;

    Highbar__Vector3 rpos = HIGHBAR__VECTOR3__INIT; rpos.x = 500.0f; rpos.y = 70.0f; rpos.z = 600.0f;
    Highbar__RadarOnlyEnemyUnit rad = HIGHBAR__RADAR_ONLY_ENEMY_UNIT__INIT;
    rad.unit_id = 3; rad.position = &rpos; rad.unit_def_id = 13; rad.team = 1;

    Highbar__FriendlyUnit *friendlies[] = { &f };
    Highbar__LosEnemyUnit *loses[] = { &los };
    Highbar__RadarOnlyEnemyUnit *rads[] = { &rad };
    snap.friendlies = friendlies; snap.n_friendlies = 1;
    snap.los_enemies = loses; snap.n_los_enemies = 1;
    snap.radar_only_enemies = rads; snap.n_radar_only_enemies = 1;

    Highbar__EconomyRecord econ = HIGHBAR__ECONOMY_RECORD__INIT;
    econ.metal_current = 1000.0f; econ.metal_income = 10.5f;
    econ.metal_usage = 7.25f; econ.metal_storage = 2000.0f;
    econ.energy_current = 5000.0f; econ.energy_income = 30.0f;
    econ.energy_usage = 15.0f; econ.energy_storage = 10000.0f;
    snap.economy = &econ;

    // Pack + unpack
    size_t sz = highbar__game_state_snapshot__get_packed_size(&snap);
    uint8_t *buf = alloc.alloc(alloc.allocator_data, sz);
    assert(buf);
    size_t written = highbar__game_state_snapshot__pack(&snap, buf);
    assert(written == sz);

    Highbar__GameStateSnapshot *out = highbar__game_state_snapshot__unpack(&alloc, sz, buf);
    assert(out != NULL);
    assert(out->frame == 12345);
    assert(out->n_friendlies == 1);
    assert(out->friendlies[0]->unit_id == 1);
    assert(fabsf(out->friendlies[0]->position->x - 100.0f) < 0.01f);
    assert(fabsf(out->friendlies[0]->health - 500.0f) < 0.01f);
    assert(out->friendlies[0]->unit_def_id == 7);
    assert(out->n_los_enemies == 1);
    assert(out->los_enemies[0]->unit_id == 2);
    assert(fabsf(out->los_enemies[0]->health - 300.0f) < 0.01f);
    assert(out->n_radar_only_enemies == 1);
    assert(out->radar_only_enemies[0]->unit_id == 3);
    assert(fabsf(out->radar_only_enemies[0]->position->z - 600.0f) < 0.01f);
    assert(out->economy != NULL);
    assert(fabsf(out->economy->metal_current - 1000.0f) < 0.01f);
    assert(fabsf(out->economy->energy_storage - 10000.0f) < 0.01f);
}

// ---- T011a: cap path ----
//
// Synthetic callback table that reports > HIGHBAR_SNAPSHOT_MAX_UNITS enemies.
// The handler must return success=false with a populated error_message and
// MUST NOT emit a snapshot_value.

static int stub_my_team(int ai)             { (void)ai; return 0; }
static int stub_current_frame(int ai)       { (void)ai; return 1; }
static int stub_team_units(int ai, int *ids, int max) {
    (void)ai; (void)ids; (void)max; return 0;
}
static int stub_enemy_units(int ai, int *ids, int max) {
    (void)ai; (void)ids; (void)max; return 0;
}
// Claim 8192 enemies in radar+LOS — above default cap 4096
static int stub_enemy_radar_los(int ai, int *ids, int max) {
    (void)ai;
    int n = max < 8192 ? max : 8192;
    for (int i = 0; i < n; i++) ids[i] = i + 1;
    return n;
}
static void stub_unit_pos(int ai, int uid, float *out) { (void)ai; (void)uid; out[0]=out[1]=out[2]=0.0f; }
static float stub_unit_health(int ai, int uid)         { (void)ai; (void)uid; return 0.0f; }
static int stub_unit_def(int ai, int uid)              { (void)ai; (void)uid; return 1; }
static int stub_unit_team(int ai, int uid)             { (void)ai; (void)uid; return 1; }
static float stub_econ(int ai, int rid)                { (void)ai; (void)rid; return 0.0f; }

TEST(test_snapshot_cap_exceeded) {
    ProtobufCAllocator alloc = hb_arena_allocator(&arena);

    struct SSkirmishAICallback cb;
    memset(&cb, 0, sizeof(cb));
    cb.Game_getMyTeam = stub_my_team;
    cb.Game_getCurrentFrame = stub_current_frame;
    cb.getTeamUnits = stub_team_units;
    cb.getEnemyUnits = stub_enemy_units;
    cb.getEnemyUnitsInRadarAndLos = stub_enemy_radar_los;
    cb.Unit_getPos = stub_unit_pos;
    cb.Unit_getHealth = stub_unit_health;
    cb.Unit_getDef = stub_unit_def;
    cb.Unit_getTeam = stub_unit_team;
    cb.Economy_getCurrent = stub_econ;
    cb.Economy_getIncome = stub_econ;
    cb.Economy_getUsage = stub_econ;
    cb.Economy_getStorage = stub_econ;

    // Force default cap (4096) by unsetting env var
    unsetenv("HIGHBAR_SNAPSHOT_MAX_UNITS");

    Highbar__CallbackRequest req = HIGHBAR__CALLBACK_REQUEST__INIT;
    req.request_id = 99;
    req.callback_id = HIGHBAR__CALLBACK_ID__CALLBACK_GAME_GET_STATE;

    Highbar__CallbackResponse *resp = hb_callback_dispatch(&req, 0, &cb, &alloc);
    assert(resp != NULL);
    assert(resp->success == 0);
    assert(resp->error_message != NULL && resp->error_message[0] != '\0');
    // No snapshot_value emitted (result may be NULL or not set to snapshot variant)
    if (resp->result != NULL) {
        assert(resp->result->value_case != HIGHBAR__CALLBACK_RESULT__VALUE_SNAPSHOT_VALUE);
    }
}

int main(void) {
    printf("test_gamestate_snapshot:\n");
    hb_arena_init(&arena, 1024 * 1024);
    RUN(test_snapshot_roundtrip);
    RUN(test_snapshot_cap_exceeded);
    hb_arena_reset(&arena);
    printf("All gamestate snapshot tests passed.\n");
    return 0;
}
