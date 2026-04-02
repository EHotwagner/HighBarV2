#include "highbar/engine_types.h"
#include <string.h>
#include <stdio.h>

// Mock engine state
static int mock_handle_command_call_count = 0;
static int mock_last_command_topic = -1;
static int mock_my_team = 1;
static int mock_my_ally_team = 0;
static int mock_team_count = 2;
static int mock_map_width = 512;
static int mock_map_height = 512;

// Tracking for command verification
#define MAX_RECORDED_COMMANDS 64
static struct {
    int command_topic;
    int unit_id;
} mock_recorded_commands[MAX_RECORDED_COMMANDS];
static int mock_recorded_count = 0;

// -- Mock callback implementations --

static int mock_engine_handle_command(int skirmishAIId, int toId,
                                       int commandId, int commandTopic,
                                       void *commandData) {
    (void)skirmishAIId;
    (void)toId;
    (void)commandId;
    (void)commandData;
    mock_handle_command_call_count++;
    mock_last_command_topic = commandTopic;

    if (mock_recorded_count < MAX_RECORDED_COMMANDS) {
        mock_recorded_commands[mock_recorded_count].command_topic = commandTopic;
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
    return &cb;
}

void mock_engine_reset(void) {
    mock_handle_command_call_count = 0;
    mock_last_command_topic = -1;
    mock_recorded_count = 0;
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

void mock_engine_set_team(int team) {
    mock_my_team = team;
}

void mock_engine_set_map_size(int width, int height) {
    mock_map_width = width;
    mock_map_height = height;
}
