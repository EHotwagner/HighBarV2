#ifndef HIGHBAR_ARENA_H
#define HIGHBAR_ARENA_H

#include <stddef.h>
#include <protobuf-c/protobuf-c.h>

// Per-frame bump allocator for protobuf messages.
// Allocated once at init, reset (offset=0) each frame, freed at release.
typedef struct {
    unsigned char *buffer;
    size_t capacity;
    size_t offset;
} HB_Arena;

// Create arena with given capacity (bytes). Returns 0 on success.
int hb_arena_init(HB_Arena *arena, size_t capacity);

// Reset allocation offset to 0 (call at start of each frame).
void hb_arena_reset(HB_Arena *arena);

// Free the arena's backing buffer.
void hb_arena_destroy(HB_Arena *arena);

// Get a ProtobufCAllocator that allocates from this arena.
// The returned allocator's allocator_data points to the arena.
ProtobufCAllocator hb_arena_allocator(HB_Arena *arena);

#endif // HIGHBAR_ARENA_H
