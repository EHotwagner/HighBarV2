#ifndef MOCK_ENGINE_H
#define MOCK_ENGINE_H

#include "highbar/engine_types.h"

// Create a mock SSkirmishAICallback with controllable return values.
struct SSkirmishAICallback *mock_engine_create(void);

// Reset all counters and recorded commands.
void mock_engine_reset(void);

// Query recorded state.
int mock_engine_get_command_count(void);
int mock_engine_get_last_command_topic(void);
int mock_engine_get_recorded_count(void);
int mock_engine_get_recorded_topic(int index);
int mock_engine_get_last_command_id(void);
int mock_engine_get_recorded_command_id(int index);

// Configure mock state.
void mock_engine_set_team(int team);
void mock_engine_set_map_size(int width, int height);

#endif // MOCK_ENGINE_H
