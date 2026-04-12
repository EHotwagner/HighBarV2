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
void mock_engine_set_los_return_count(int count);

// Economy mock — per-resource configurable return values.
void mock_engine_set_economy_current(int resourceId, float value);
void mock_engine_set_economy_income(int resourceId, float value);
void mock_engine_set_economy_usage(int resourceId, float value);
void mock_engine_set_economy_storage(int resourceId, float value);

// Shutdown recording — the proxy's EVENT_RELEASE test uses this to verify
// exactly one Shutdown(reason) message is sent and never duplicated.
// Tests must call mock_engine_reset() to clear state before each run.
int mock_engine_get_shutdown_count(void);
int mock_engine_get_last_shutdown_reason(void);
void mock_engine_record_shutdown(int reason);

#endif // MOCK_ENGINE_H
