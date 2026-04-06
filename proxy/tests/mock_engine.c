#include "highbar/engine_types.h"
#include <string.h>
#include <stdio.h>

// Mock engine state
static int mock_handle_command_call_count = 0;
static int mock_last_command_topic = -1;
static int mock_last_command_id = 0;
static int mock_my_team = 1;
static int mock_my_ally_team = 0;
static int mock_team_count = 2;
static int mock_map_width = 512;
static int mock_map_height = 512;

// Mock map data arrays (4x4 grids for testing)
static float mock_heightmap[16] = {
    1.0f, 2.0f, 3.0f, 4.0f,
    5.0f, 6.0f, 7.0f, 8.0f,
    9.0f, 10.0f, 11.0f, 12.0f,
    13.0f, 14.0f, 15.0f, 16.0f
};
static float mock_slopemap[4] = { 0.1f, 0.2f, 0.3f, 0.4f };
static int mock_losmap[16] = { 1, 0, 1, 0, 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 1, 1 };
static int mock_radarmap[16] = { 0, 1, 0, 1, 1, 0, 1, 0, 0, 0, 1, 1, 1, 1, 0, 0 };
static short mock_resourcemap[4] = { 100, 200, 0, 150 };
static float mock_corners_heightmap[25] = {
    1.0f, 2.0f, 3.0f, 4.0f, 5.0f,
    6.0f, 7.0f, 8.0f, 9.0f, 10.0f,
    11.0f, 12.0f, 13.0f, 14.0f, 15.0f,
    16.0f, 17.0f, 18.0f, 19.0f, 20.0f,
    21.0f, 22.0f, 23.0f, 24.0f, 25.0f
};
static float mock_start_pos[3] = { 1024.0f, 80.0f, 2048.0f };
static float mock_metal_spot_positions[6] = {
    512.0f, 40.0f, 768.0f,   // spot 0
    1536.0f, 60.0f, 1280.0f  // spot 1
};
static float mock_metal_avg_income = 2.5f;
static int mock_los_return_count = -1; // -1 = use default (w*h)

// Tracking for command verification
#define MAX_RECORDED_COMMANDS 64
static struct {
    int command_topic;
    int unit_id;
    int command_id;
} mock_recorded_commands[MAX_RECORDED_COMMANDS];
static int mock_recorded_count = 0;

// -- Mock callback implementations --

static int mock_engine_handle_command(int skirmishAIId, int toId,
                                       int commandId, int commandTopic,
                                       void *commandData) {
    (void)skirmishAIId;
    (void)toId;
    (void)commandData;
    mock_handle_command_call_count++;
    mock_last_command_topic = commandTopic;
    mock_last_command_id = commandId;

    if (mock_recorded_count < MAX_RECORDED_COMMANDS) {
        mock_recorded_commands[mock_recorded_count].command_topic = commandTopic;
        mock_recorded_commands[mock_recorded_count].command_id = commandId;
        // Extract unit_id from first field of most command structs
        if (commandData) {
            mock_recorded_commands[mock_recorded_count].unit_id = *(int *)commandData;
        }
        mock_recorded_count++;
    }
    return 0;
}

static const char *mock_info_get_value_by_key(int skirmishAIId, const char *key) {
    (void)skirmishAIId;
    if (strcmp(key, "socket_path") == 0) return "/tmp/highbar-test.sock";
    if (strcmp(key, "timeout_ms") == 0) return "100";
    if (strcmp(key, "log_level") == 0) return "3";
    return NULL;
}

static void mock_log(int skirmishAIId, const char *msg) {
    (void)skirmishAIId;
    fprintf(stderr, "[MOCK] %s\n", msg);
}

static int mock_game_get_my_team(int skirmishAIId) {
    (void)skirmishAIId;
    return mock_my_team;
}

static int mock_game_get_my_ally_team(int skirmishAIId) {
    (void)skirmishAIId;
    return mock_my_ally_team;
}

static int mock_game_get_team_count(int skirmishAIId) {
    (void)skirmishAIId;
    return mock_team_count;
}

static int mock_map_get_width(int skirmishAIId) {
    (void)skirmishAIId;
    return mock_map_width;
}

static int mock_map_get_height(int skirmishAIId) {
    (void)skirmishAIId;
    return mock_map_height;
}

static void mock_unit_get_pos(int skirmishAIId, int unitId, float *pos) {
    (void)skirmishAIId;
    pos[0] = (float)(unitId * 100);
    pos[1] = 50.0f;
    pos[2] = (float)(unitId * 200);
}

static float mock_unit_get_health(int skirmishAIId, int unitId) {
    (void)skirmishAIId;
    return (float)(unitId * 100);
}

static float mock_unit_get_max_health(int skirmishAIId, int unitId) {
    (void)skirmishAIId;
    return (float)(unitId * 100);
}

// -- Mock map data callbacks --

static int mock_map_get_height_map(int skirmishAIId, float *heights, int heights_sizeMax) {
    (void)skirmishAIId;
    int count = mock_map_width * mock_map_height;
    if (count > heights_sizeMax) count = heights_sizeMax;
    // For small test maps (4x4=16), copy mock data; for larger, fill with index values
    for (int i = 0; i < count; i++) {
        heights[i] = (i < 16) ? mock_heightmap[i] : (float)i;
    }
    return count;
}

static int mock_map_get_corners_height_map(int skirmishAIId, float *cornerHeights, int cornerHeights_sizeMax) {
    (void)skirmishAIId;
    int count = (mock_map_width + 1) * (mock_map_height + 1);
    if (count > cornerHeights_sizeMax) count = cornerHeights_sizeMax;
    for (int i = 0; i < count; i++) {
        cornerHeights[i] = (i < 25) ? mock_corners_heightmap[i] : (float)i;
    }
    return count;
}

static int mock_map_get_slope_map(int skirmishAIId, float *slopes, int slopes_sizeMax) {
    (void)skirmishAIId;
    int count = (mock_map_width / 2) * (mock_map_height / 2);
    if (count > slopes_sizeMax) count = slopes_sizeMax;
    for (int i = 0; i < count; i++) {
        slopes[i] = (i < 4) ? mock_slopemap[i] : 0.5f;
    }
    return count;
}

static int mock_map_get_los_map(int skirmishAIId, int *losValues, int losValues_sizeMax) {
    (void)skirmishAIId;
    int count;
    if (mock_los_return_count >= 0) {
        count = mock_los_return_count;
    } else {
        count = mock_map_width * mock_map_height;
    }
    if (count > losValues_sizeMax) count = losValues_sizeMax;
    for (int i = 0; i < count; i++) {
        losValues[i] = (i < 16) ? mock_losmap[i] : 0;
    }
    return count;
}

static int mock_map_get_radar_map(int skirmishAIId, int *radarValues, int radarValues_sizeMax) {
    (void)skirmishAIId;
    int count = mock_map_width * mock_map_height;
    if (count > radarValues_sizeMax) count = radarValues_sizeMax;
    for (int i = 0; i < count; i++) {
        radarValues[i] = (i < 16) ? mock_radarmap[i] : 0;
    }
    return count;
}

static int mock_map_get_resource_map_raw(int skirmishAIId, int resourceId,
                                          short *resources, int resources_sizeMax) {
    (void)skirmishAIId;
    (void)resourceId;
    int count = (mock_map_width / 2) * (mock_map_height / 2);
    if (count > resources_sizeMax) count = resources_sizeMax;
    for (int i = 0; i < count; i++) {
        resources[i] = (i < 4) ? mock_resourcemap[i] : 0;
    }
    return count;
}

static void mock_map_get_start_pos(int skirmishAIId, float *return_posF3_out) {
    (void)skirmishAIId;
    return_posF3_out[0] = mock_start_pos[0];
    return_posF3_out[1] = mock_start_pos[1];
    return_posF3_out[2] = mock_start_pos[2];
}

static int mock_map_get_resource_spots_positions(int skirmishAIId, int resourceId,
                                                   float *spots_AposF3, int spots_AposF3_sizeMax) {
    (void)skirmishAIId;
    (void)resourceId;
    int count = 6; // 2 spots * 3 floats
    if (count > spots_AposF3_sizeMax) count = spots_AposF3_sizeMax;
    for (int i = 0; i < count; i++) {
        spots_AposF3[i] = mock_metal_spot_positions[i];
    }
    return count;
}

static float mock_map_get_resource_spots_avg_income(int skirmishAIId, int resourceId) {
    (void)skirmishAIId;
    (void)resourceId;
    return mock_metal_avg_income;
}

// -- Public interface --

struct SSkirmishAICallback *mock_engine_create(void) {
    static struct SSkirmishAICallback cb;
    cb.Engine_handleCommand = mock_engine_handle_command;
    cb.Info_getValueByKey = mock_info_get_value_by_key;
    cb.Log_log = mock_log;
    cb.Game_getMyTeam = mock_game_get_my_team;
    cb.Game_getMyAllyTeam = mock_game_get_my_ally_team;
    cb.Game_getTeamCount = mock_game_get_team_count;
    cb.Map_getWidth = mock_map_get_width;
    cb.Map_getHeight = mock_map_get_height;
    cb.Unit_getPos = mock_unit_get_pos;
    cb.Unit_getHealth = mock_unit_get_health;
    cb.Unit_getMaxHealth = mock_unit_get_max_health;
    cb.Map_getHeightMap = mock_map_get_height_map;
    cb.Map_getCornersHeightMap = mock_map_get_corners_height_map;
    cb.Map_getSlopeMap = mock_map_get_slope_map;
    cb.Map_getLosMap = mock_map_get_los_map;
    cb.Map_getRadarMap = mock_map_get_radar_map;
    cb.Map_getResourceMapRaw = mock_map_get_resource_map_raw;
    cb.Map_getStartPos = mock_map_get_start_pos;
    cb.Map_getResourceMapSpotsPositions = mock_map_get_resource_spots_positions;
    cb.Map_getResourceMapSpotsAverageIncome = mock_map_get_resource_spots_avg_income;
    return &cb;
}

void mock_engine_reset(void) {
    mock_handle_command_call_count = 0;
    mock_last_command_topic = -1;
    mock_last_command_id = 0;
    mock_recorded_count = 0;
    mock_los_return_count = -1;
}

int mock_engine_get_command_count(void) {
    return mock_handle_command_call_count;
}

int mock_engine_get_last_command_topic(void) {
    return mock_last_command_topic;
}

int mock_engine_get_recorded_count(void) {
    return mock_recorded_count;
}

int mock_engine_get_recorded_topic(int index) {
    if (index >= 0 && index < mock_recorded_count) {
        return mock_recorded_commands[index].command_topic;
    }
    return -1;
}

int mock_engine_get_last_command_id(void) {
    return mock_last_command_id;
}

int mock_engine_get_recorded_command_id(int index) {
    if (index >= 0 && index < mock_recorded_count) {
        return mock_recorded_commands[index].command_id;
    }
    return 0;
}

void mock_engine_set_team(int team) {
    mock_my_team = team;
}

void mock_engine_set_map_size(int width, int height) {
    mock_map_width = width;
    mock_map_height = height;
}

void mock_engine_set_los_return_count(int count) {
    mock_los_return_count = count;
}
