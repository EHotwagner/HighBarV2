#include "highbar/proxy.h"
#include "highbar/engine_types.h"
#include "highbar/arena.h"
#include "highbar/config.h"
#include "highbar/connection.h"
#include "highbar/serialize.h"
#include "highbar/deserialize.h"
#include "highbar/callbacks.h"

#include "highbar/messages.pb-c.h"

#include <stdlib.h>
#include <stdio.h>
#include <string.h>

#define HIGHBAR_PROTOCOL_VERSION 1
#define ARENA_DEFAULT_CAPACITY (1024 * 1024) // 1MB
#define MAX_EVENTS_PER_FRAME 256

// Proxy singleton state
typedef struct {
    int skirmish_ai_id;
    const struct SSkirmishAICallback *callback;
    HB_Config config;
    HB_Arena arena;
    HB_Connection conn;
    uint32_t frame_number;

    // Frame batching: accumulate events until UPDATE triggers send
    Highbar__EngineEvent *pending_events[MAX_EVENTS_PER_FRAME];
    int pending_event_count;
} ProxyState;

static ProxyState *g_state = NULL;

// Log via engine callback
static void proxy_log(int level, const char *msg) {
    if (g_state && g_state->callback && g_state->callback->Log_log
        && level <= (int)g_state->config.log_level) {
        g_state->callback->Log_log(g_state->skirmish_ai_id, msg);
    }
}

// Perform handshake with AI process
static int do_handshake(ProxyState *state) {
    Highbar__Handshake hs = HIGHBAR__HANDSHAKE__INIT;
    hs.protocol_version = HIGHBAR_PROTOCOL_VERSION;
    hs.engine_version = ""; // filled from callback if available
    hs.game_id = "";
    hs.map_name = "";
    hs.mod_name = "";
    hs.team_id = 0;
    hs.ally_team_id = 0;
    hs.player_count = 0;

    if (state->callback->Game_getMyTeam) {
        hs.team_id = state->callback->Game_getMyTeam(state->skirmish_ai_id);
    }
    if (state->callback->Game_getMyAllyTeam) {
        hs.ally_team_id = state->callback->Game_getMyAllyTeam(state->skirmish_ai_id);
    }

    // Wrap in ProxyMessage
    Highbar__ProxyMessage msg = HIGHBAR__PROXY_MESSAGE__INIT;
    msg.message_case = HIGHBAR__PROXY_MESSAGE__MESSAGE_HANDSHAKE;
    msg.handshake = &hs;

    size_t len = highbar__proxy_message__get_packed_size(&msg);
    uint8_t *buf = malloc(len);
    if (!buf) return -1;
    highbar__proxy_message__pack(&msg, buf);

    int rc = hb_conn_send(&state->conn, buf, (uint32_t)len);
    free(buf);
    if (rc != 0) {
        proxy_log(HB_LOG_ERROR, "Failed to send handshake");
        return -1;
    }

    // Receive HandshakeResponse
    uint8_t *resp_data = NULL;
    uint32_t resp_len = 0;
    rc = hb_conn_recv(&state->conn, &resp_data, &resp_len, 5000); // 5s handshake timeout
    if (rc != 0) {
        proxy_log(HB_LOG_ERROR, "Failed to receive handshake response");
        return -1;
    }

    Highbar__AIMessage *ai_msg = highbar__aimessage__unpack(NULL, resp_len, resp_data);
    free(resp_data);
    if (!ai_msg) {
        proxy_log(HB_LOG_ERROR, "Failed to parse handshake response");
        return -1;
    }

    int result = -1;
    if (ai_msg->message_case == HIGHBAR__AIMESSAGE__MESSAGE_HANDSHAKE_RESPONSE
        && ai_msg->handshake_response) {
        if (ai_msg->handshake_response->accepted
            && ai_msg->handshake_response->protocol_version == HIGHBAR_PROTOCOL_VERSION) {
            result = 0;
        } else {
            proxy_log(HB_LOG_ERROR, "Handshake rejected or version mismatch");
        }
    }

    highbar__aimessage__free_unpacked(ai_msg, NULL);
    return result;
}

// Send accumulated frame events and process response
static int send_frame_and_process_response(ProxyState *state) {
    ProtobufCAllocator alloc = hb_arena_allocator(&state->arena);

    // Build Frame message
    Highbar__Frame frame = HIGHBAR__FRAME__INIT;
    frame.frame_number = state->frame_number;
    frame.n_events = (size_t)state->pending_event_count;
    frame.events = state->pending_events;

    // Wrap in ProxyMessage
    Highbar__ProxyMessage msg = HIGHBAR__PROXY_MESSAGE__INIT;
    msg.message_case = HIGHBAR__PROXY_MESSAGE__MESSAGE_FRAME;
    msg.frame = &frame;

    size_t len = highbar__proxy_message__get_packed_size(&msg);

    // Check backpressure before writing
    if (!hb_conn_is_writable(&state->conn)) {
        proxy_log(HB_LOG_WARN, "Socket not writable, dropping frame");
        state->pending_event_count = 0;
        return 0;
    }

    uint8_t *buf = malloc(len);
    if (!buf) return -1;
    highbar__proxy_message__pack(&msg, buf);

    int rc = hb_conn_send(&state->conn, buf, (uint32_t)len);
    free(buf);
    state->pending_event_count = 0;

    if (rc != 0) {
        proxy_log(HB_LOG_ERROR, "Send failed, connection lost");
        state->conn.connected = false;
        return -1;
    }

    // Receive response (may be CallbackRequests followed by FrameResponse)
    for (;;) {
        uint8_t *resp_data = NULL;
        uint32_t resp_len = 0;
        rc = hb_conn_recv(&state->conn, &resp_data, &resp_len, state->config.timeout_ms);
        if (rc == -2) {
            // Timeout — skip commands this frame
            proxy_log(HB_LOG_WARN, "Frame response timeout, skipping commands");
            return 0;
        }
        if (rc != 0) {
            proxy_log(HB_LOG_ERROR, "Recv failed, connection lost");
            state->conn.connected = false;
            return -1;
        }

        Highbar__AIMessage *ai_msg = highbar__aimessage__unpack(NULL, resp_len, resp_data);
        free(resp_data);
        if (!ai_msg) {
            proxy_log(HB_LOG_WARN, "Failed to parse AI response");
            return 0;
        }

        if (ai_msg->message_case == HIGHBAR__AIMESSAGE__MESSAGE_CALLBACK_REQUEST) {
            // Dispatch callback and send response
            Highbar__CallbackResponse *cb_resp = hb_callback_dispatch(
                ai_msg->callback_request,
                state->skirmish_ai_id,
                state->callback,
                &alloc);

            if (cb_resp) {
                Highbar__ProxyMessage cb_msg = HIGHBAR__PROXY_MESSAGE__INIT;
                cb_msg.message_case = HIGHBAR__PROXY_MESSAGE__MESSAGE_CALLBACK_RESPONSE;
                cb_msg.callback_response = cb_resp;

                size_t cb_len = highbar__proxy_message__get_packed_size(&cb_msg);
                uint8_t *cb_buf = malloc(cb_len);
                if (cb_buf) {
                    highbar__proxy_message__pack(&cb_msg, cb_buf);
                    hb_conn_send(&state->conn, cb_buf, (uint32_t)cb_len);
                    free(cb_buf);
                }
            }
            highbar__aimessage__free_unpacked(ai_msg, NULL);
            continue; // Wait for more callbacks or FrameResponse
        }

        if (ai_msg->message_case == HIGHBAR__AIMESSAGE__MESSAGE_FRAME_RESPONSE
            && ai_msg->frame_response) {
            // Execute command batch
            Highbar__FrameResponse *fr = ai_msg->frame_response;
            for (size_t i = 0; i < fr->n_commands; i++) {
                int cmd_rc = hb_deserialize_and_execute(
                    fr->commands[i],
                    state->skirmish_ai_id,
                    state->callback->Engine_handleCommand);
                if (cmd_rc != 0) {
                    proxy_log(HB_LOG_WARN, "Command execution failed, continuing batch");
                }
            }
            highbar__aimessage__free_unpacked(ai_msg, NULL);
            return 0;
        }

        // Unexpected message type
        highbar__aimessage__free_unpacked(ai_msg, NULL);
        return 0;
    }
}

int init(int skirmishAIId, const struct SSkirmishAICallback *callback) {
    g_state = (ProxyState *)calloc(1, sizeof(ProxyState));
    if (!g_state) return -1;

    g_state->skirmish_ai_id = skirmishAIId;
    g_state->callback = callback;
    g_state->pending_event_count = 0;

    // Load config from engine options + env vars
    hb_config_load(&g_state->config, skirmishAIId,
                   callback ? callback->Info_getValueByKey : NULL);

    // Initialize arena
    if (hb_arena_init(&g_state->arena, ARENA_DEFAULT_CAPACITY) != 0) {
        proxy_log(HB_LOG_ERROR, "Failed to allocate arena");
        free(g_state);
        g_state = NULL;
        return -1;
    }

    // Connect to AI process
    hb_conn_init(&g_state->conn, &g_state->config);
    if (hb_conn_connect(&g_state->conn) != 0) {
        proxy_log(HB_LOG_ERROR, "Failed to connect to AI process");
        hb_arena_destroy(&g_state->arena);
        free(g_state);
        g_state = NULL;
        return -1;
    }

    proxy_log(HB_LOG_INFO, "Connected to AI process");

    // Perform handshake
    if (do_handshake(g_state) != 0) {
        proxy_log(HB_LOG_ERROR, "Handshake failed");
        hb_conn_close(&g_state->conn);
        hb_arena_destroy(&g_state->arena);
        free(g_state);
        g_state = NULL;
        return -1;
    }

    proxy_log(HB_LOG_INFO, "Handshake complete");

    // Enable cheats so cheat commands (GiveMeNewUnit, GiveMeResource) work
    if (callback && callback->Cheats_setEnabled) {
        callback->Cheats_setEnabled(skirmishAIId, true);
        proxy_log(HB_LOG_INFO, "Cheats enabled");
    }

    return 0;
}

int release(int skirmishAIId) {
    (void)skirmishAIId;
    if (!g_state) return 0;

    // Send shutdown notification
    if (g_state->conn.connected) {
        Highbar__Shutdown shutdown = HIGHBAR__SHUTDOWN__INIT;
        shutdown.reason = HIGHBAR__SHUTDOWN_REASON__SHUTDOWN_REASON_GAME_OVER;

        Highbar__ProxyMessage msg = HIGHBAR__PROXY_MESSAGE__INIT;
        msg.message_case = HIGHBAR__PROXY_MESSAGE__MESSAGE_SHUTDOWN;
        msg.shutdown = &shutdown;

        size_t len = highbar__proxy_message__get_packed_size(&msg);
        uint8_t *buf = malloc(len);
        if (buf) {
            highbar__proxy_message__pack(&msg, buf);
            hb_conn_send(&g_state->conn, buf, (uint32_t)len);
            free(buf);
        }
    }

    hb_conn_close(&g_state->conn);
    hb_arena_destroy(&g_state->arena);
    free(g_state);
    g_state = NULL;
    return 0;
}

int handleEvent(int skirmishAIId, int topicId, const void *data) {
    (void)skirmishAIId;
    if (!g_state || !g_state->conn.connected) return -1;

    // Handle save/load specially
    if (topicId == EVENT_SAVE) {
        Highbar__ProxyMessage msg = HIGHBAR__PROXY_MESSAGE__INIT;
        Highbar__SaveRequest save_req = HIGHBAR__SAVE_REQUEST__INIT;
        msg.message_case = HIGHBAR__PROXY_MESSAGE__MESSAGE_SAVE_REQUEST;
        msg.save_request = &save_req;

        size_t len = highbar__proxy_message__get_packed_size(&msg);
        uint8_t *buf = malloc(len);
        if (buf) {
            highbar__proxy_message__pack(&msg, buf);
            hb_conn_send(&g_state->conn, buf, (uint32_t)len);
            free(buf);
        }
        // Receive SaveResponse
        uint8_t *resp_data = NULL;
        uint32_t resp_len = 0;
        if (hb_conn_recv(&g_state->conn, &resp_data, &resp_len, 5000) == 0) {
            // TODO: pass save data back to engine
            free(resp_data);
        }
        return 0;
    }

    if (topicId == EVENT_LOAD) {
        Highbar__ProxyMessage msg = HIGHBAR__PROXY_MESSAGE__INIT;
        Highbar__LoadRequest load_req = HIGHBAR__LOAD_REQUEST__INIT;
        // TODO: pass saved state blob from engine
        msg.message_case = HIGHBAR__PROXY_MESSAGE__MESSAGE_LOAD_REQUEST;
        msg.load_request = &load_req;

        size_t len = highbar__proxy_message__get_packed_size(&msg);
        uint8_t *buf = malloc(len);
        if (buf) {
            highbar__proxy_message__pack(&msg, buf);
            hb_conn_send(&g_state->conn, buf, (uint32_t)len);
            free(buf);
        }
        return 0;
    }

    // Reset arena at the start of each frame (on UPDATE event)
    if (topicId == EVENT_UPDATE) {
        const struct SUpdateEvent *update = (const struct SUpdateEvent *)data;
        g_state->frame_number = (uint32_t)update->frame;
    }

    // Serialize event
    ProtobufCAllocator alloc = hb_arena_allocator(&g_state->arena);
    Highbar__EngineEvent *event = hb_serialize_event(topicId, data, &alloc);
    if (!event) {
        proxy_log(HB_LOG_WARN, "Failed to serialize event");
        return 0; // non-fatal
    }

    // In BATCHED mode, accumulate events and send on UPDATE
    if (g_state->config.frame_mode == HB_FRAME_BATCHED) {
        if (g_state->pending_event_count < MAX_EVENTS_PER_FRAME) {
            g_state->pending_events[g_state->pending_event_count++] = event;
        }

        // UPDATE event triggers frame send
        if (topicId == EVENT_UPDATE) {
            int rc = send_frame_and_process_response(g_state);
            hb_arena_reset(&g_state->arena);
            if (rc != 0 && !g_state->conn.connected) {
                return -1; // signal engine to remove AI
            }
        }
    } else {
        // INDIVIDUAL mode: send each event immediately in its own frame
        g_state->pending_events[0] = event;
        g_state->pending_event_count = 1;
        int rc = send_frame_and_process_response(g_state);
        hb_arena_reset(&g_state->arena);
        if (rc != 0 && !g_state->conn.connected) {
            return -1;
        }
    }

    return 0;
}
