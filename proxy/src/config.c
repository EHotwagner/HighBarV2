#include "highbar/config.h"
#include <stdlib.h>
#include <string.h>

void hb_config_defaults(HB_Config *config) {
    strncpy(config->socket_path, "/tmp/highbar.sock", sizeof(config->socket_path) - 1);
    config->socket_path[sizeof(config->socket_path) - 1] = '\0';
    config->timeout_ms = 500;
    config->log_level = HB_LOG_INFO;
    config->frame_mode = HB_FRAME_BATCHED;
    config->push_state = false;
    config->max_message_size = 8388608; // 8MB
    config->transport = HB_TRANSPORT_UNIX;
    config->tcp_port = 17432;
}

static const char *get_info_or_env(int skirmish_ai_id, HB_InfoGetValueFn info_fn,
                                    const char *key, const char *env_var) {
    // Environment variable takes precedence
    const char *env_val = getenv(env_var);
    if (env_val && env_val[0] != '\0') {
        return env_val;
    }
    // Then try engine callback
    if (info_fn) {
        const char *val = info_fn(skirmish_ai_id, key);
        if (val && val[0] != '\0') {
            return val;
        }
    }
    return NULL;
}

void hb_config_load(HB_Config *config, int skirmish_ai_id, HB_InfoGetValueFn info_fn) {
    hb_config_defaults(config);

    const char *val;

    val = get_info_or_env(skirmish_ai_id, info_fn, "socket_path", "HIGHBAR_SOCKET_PATH");
    if (val) {
        strncpy(config->socket_path, val, sizeof(config->socket_path) - 1);
        config->socket_path[sizeof(config->socket_path) - 1] = '\0';
    }

    val = get_info_or_env(skirmish_ai_id, info_fn, "timeout_ms", "HIGHBAR_TIMEOUT_MS");
    if (val) {
        int v = atoi(val);
        if (v > 0) config->timeout_ms = (uint32_t)v;
    }

    val = get_info_or_env(skirmish_ai_id, info_fn, "log_level", "HIGHBAR_LOG_LEVEL");
    if (val) {
        int v = atoi(val);
        if (v >= 0 && v <= 3) config->log_level = (HB_LogLevel)v;
    }

    val = get_info_or_env(skirmish_ai_id, info_fn, "frame_mode", "HIGHBAR_FRAME_MODE");
    if (val) {
        int v = atoi(val);
        if (v == 0 || v == 1) config->frame_mode = (HB_FrameMode)v;
    }

    val = get_info_or_env(skirmish_ai_id, info_fn, "push_state", "HIGHBAR_PUSH_STATE");
    if (val) {
        config->push_state = (strcmp(val, "true") == 0 || strcmp(val, "1") == 0);
    }

    val = get_info_or_env(skirmish_ai_id, info_fn, "max_message_size", "HIGHBAR_MAX_MSG_SIZE");
    if (val) {
        int v = atoi(val);
        if (v >= 65536) config->max_message_size = (uint32_t)v;
    }

    val = get_info_or_env(skirmish_ai_id, info_fn, "transport", "HIGHBAR_TRANSPORT");
    if (val) {
        int v = atoi(val);
        if (v == 0 || v == 1) config->transport = (HB_Transport)v;
    }

    val = get_info_or_env(skirmish_ai_id, info_fn, "tcp_port", "HIGHBAR_TCP_PORT");
    if (val) {
        int v = atoi(val);
        if (v >= 1024 && v <= 65535) config->tcp_port = (uint16_t)v;
    }
}
