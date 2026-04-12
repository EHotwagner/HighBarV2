#ifndef HIGHBAR_CONFIG_H
#define HIGHBAR_CONFIG_H

#include <stdint.h>
#include <stdbool.h>

typedef enum {
    HB_LOG_ERROR = 0,
    HB_LOG_WARN  = 1,
    HB_LOG_INFO  = 2,
    HB_LOG_DEBUG = 3
} HB_LogLevel;

typedef enum {
    HB_FRAME_INDIVIDUAL = 0,
    HB_FRAME_BATCHED    = 1
} HB_FrameMode;

typedef enum {
    HB_TRANSPORT_UNIX = 0,
    HB_TRANSPORT_TCP  = 1
} HB_Transport;

typedef struct {
    char socket_path[256];
    uint32_t timeout_ms;
    HB_LogLevel log_level;
    HB_FrameMode frame_mode;
    bool push_state;
    uint32_t max_message_size;
    HB_Transport transport;
    uint16_t tcp_port;
    // Default false. Per-command tracing in proxy.c is gated on this flag.
    bool verbose_commands;
} HB_Config;

// Callback type for reading engine info values (Info_getValueByKey)
typedef const char* (*HB_InfoGetValueFn)(int skirmish_ai_id, const char *key);

// Load configuration from engine callback with environment variable overrides.
// info_fn may be NULL (all defaults + env overrides).
void hb_config_load(HB_Config *config, int skirmish_ai_id, HB_InfoGetValueFn info_fn);

// Set all fields to defaults.
void hb_config_defaults(HB_Config *config);

#endif // HIGHBAR_CONFIG_H
