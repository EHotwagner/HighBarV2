#ifndef HIGHBAR_PROXY_H
#define HIGHBAR_PROXY_H

// Public API: the three required engine exports.
// These conform to SSkirmishAILibrary interface.

struct SSkirmishAICallback;

// Initialize AI: store callback, load config, create arena,
// connect socket, perform handshake.
// Returns 0 on success, non-zero on failure (engine removes AI).
int init(int skirmishAIId, const struct SSkirmishAICallback *callback);

// Cleanup: close socket, destroy arena, free state.
// Returns 0 on success.
int release(int skirmishAIId);

// Handle a game event. Cast data based on topicId.
// Returns 0 on success, non-zero signals engine to remove AI.
int handleEvent(int skirmishAIId, int topicId, const void *data);

#endif // HIGHBAR_PROXY_H
