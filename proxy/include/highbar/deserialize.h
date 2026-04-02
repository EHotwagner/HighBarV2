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

#endif // HIGHBAR_DESERIALIZE_H
