#include "highbar/arena.h"
#include <stdlib.h>
#include <string.h>

static void *arena_alloc(void *allocator_data, size_t size) {
    HB_Arena *arena = (HB_Arena *)allocator_data;
    // Align to 8 bytes
    size_t aligned_offset = (arena->offset + 7) & ~(size_t)7;
    if (aligned_offset + size > arena->capacity) {
        return NULL;
    }
    void *ptr = arena->buffer + aligned_offset;
    arena->offset = aligned_offset + size;
    return ptr;
}

static void arena_free(void *allocator_data, void *ptr) {
    (void)allocator_data;
    (void)ptr;
    // No-op: arena memory is freed all at once via reset/destroy
}

int hb_arena_init(HB_Arena *arena, size_t capacity) {
    arena->buffer = (unsigned char *)malloc(capacity);
    if (!arena->buffer) {
        return -1;
    }
    arena->capacity = capacity;
    arena->offset = 0;
    return 0;
}

void hb_arena_reset(HB_Arena *arena) {
    arena->offset = 0;
}

void hb_arena_destroy(HB_Arena *arena) {
    free(arena->buffer);
    arena->buffer = NULL;
    arena->capacity = 0;
    arena->offset = 0;
}

ProtobufCAllocator hb_arena_allocator(HB_Arena *arena) {
    ProtobufCAllocator alloc = {
        .alloc = arena_alloc,
        .free = arena_free,
        .allocator_data = arena
    };
    return alloc;
}
