#ifndef HIGHBAR_DESERIALIZE_H
#define HIGHBAR_DESERIALIZE_H

#include <protobuf-c/protobuf-c.h>

// Forward declare generated types
typedef struct Highbar__AICommand Highbar__AICommand;

// Command execution callback type (maps to Engine_handleCommand)
typedef int (*HB_HandleCommandFn)(int skirmish_ai_id, int to_id,
                                   int command_id, int command_topic,
                                   void *command_data);

// Deserialize and execute a protobuf AICommand via the engine callback.
// Returns 0 on success, -1 on unknown command, positive value from engine on error.
int hb_deserialize_and_execute(const Highbar__AICommand *cmd,
                                int skirmish_ai_id,
                                HB_HandleCommandFn handle_command);

// Return UPPER_SNAKE name of the oneof case (e.g. "BUILD_UNIT") for the
// [HB] dispatch log line. Returns a pointer into a static buffer for
// UNKNOWN(<n>) fallbacks; callers must use the return value before the
// next call on the same thread. Thread-unsafe by design (proxy is
// single-threaded on the engine tick).
const char *hb_aicommand_case_name(int command_case);

// Return the per-command unit_id for unit-bearing AICommand cases, or -1
// for team-wide / unit-less ones (PAUSE_TEAM, SEND_TEXT_MESSAGE,
// SEND_RESOURCES, GIVE_ME, GIVE_ME_NEW_UNIT, draw/figure, path queries).
int hb_aicommand_unit_id(const Highbar__AICommand *cmd);

#endif // HIGHBAR_DESERIALIZE_H
