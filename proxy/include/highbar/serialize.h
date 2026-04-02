#ifndef HIGHBAR_SERIALIZE_H
#define HIGHBAR_SERIALIZE_H

#include <protobuf-c/protobuf-c.h>
#include "highbar/arena.h"

// Forward declare generated types
typedef struct Highbar__EngineEvent Highbar__EngineEvent;

// Serialize an engine event struct to a protobuf EngineEvent.
// topicId: the EventTopic enum value from the engine
// data: pointer to the engine event struct (cast based on topicId)
// alloc: arena allocator for protobuf message allocation
// Returns allocated EngineEvent or NULL on error.
Highbar__EngineEvent *hb_serialize_event(int topic_id, const void *data,
                                          ProtobufCAllocator *alloc);

#endif // HIGHBAR_SERIALIZE_H
