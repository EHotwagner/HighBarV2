#ifndef HIGHBAR_CALLBACKS_H
#define HIGHBAR_CALLBACKS_H

#include <protobuf-c/protobuf-c.h>

// Forward declarations
typedef struct Highbar__CallbackRequest Highbar__CallbackRequest;
typedef struct Highbar__CallbackResponse Highbar__CallbackResponse;

// Opaque engine callback table type (from engine headers)
struct SSkirmishAICallback;

// Dispatch a callback request to the engine and build a response.
// alloc: allocator for response message fields
// Returns a CallbackResponse (always non-NULL; check success field).
Highbar__CallbackResponse *hb_callback_dispatch(
    const Highbar__CallbackRequest *request,
    int skirmish_ai_id,
    const struct SSkirmishAICallback *callback,
    ProtobufCAllocator *alloc);

#endif // HIGHBAR_CALLBACKS_H
