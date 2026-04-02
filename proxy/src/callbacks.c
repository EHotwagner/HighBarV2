#include "highbar/callbacks.h"
#include "highbar/engine_types.h"
#include "highbar/callbacks.pb-c.h"

#include <string.h>

// Helper to create a success response with an int result
static Highbar__CallbackResponse *make_int_response(
    uint32_t request_id, int32_t value, ProtobufCAllocator *alloc) {
    Highbar__CallbackResponse *resp = alloc->alloc(alloc->allocator_data, sizeof(Highbar__CallbackResponse));
    if (!resp) return NULL;
    highbar__callback_response__init(resp);
    resp->request_id = request_id;
    resp->success = 1;
    Highbar__CallbackResult *result = alloc->alloc(alloc->allocator_data, sizeof(Highbar__CallbackResult));
    if (!result) return resp;
    highbar__callback_result__init(result);
    result->value_case = HIGHBAR__CALLBACK_RESULT__VALUE_INT_VALUE;
    result->int_value = value;
    resp->result = result;
    return resp;
}

// Helper to create a success response with a float result
static Highbar__CallbackResponse *make_float_response(
    uint32_t request_id, float value, ProtobufCAllocator *alloc) {
    Highbar__CallbackResponse *resp = alloc->alloc(alloc->allocator_data, sizeof(Highbar__CallbackResponse));
    if (!resp) return NULL;
    highbar__callback_response__init(resp);
    resp->request_id = request_id;
    resp->success = 1;
    Highbar__CallbackResult *result = alloc->alloc(alloc->allocator_data, sizeof(Highbar__CallbackResult));
    if (!result) return resp;
    highbar__callback_result__init(result);
    result->value_case = HIGHBAR__CALLBACK_RESULT__VALUE_FLOAT_VALUE;
    result->float_value = value;
    resp->result = result;
    return resp;
}

// Helper to create a success response with a Vector3 result
static Highbar__CallbackResponse *make_vec3_response(
    uint32_t request_id, float x, float y, float z, ProtobufCAllocator *alloc) {
    Highbar__CallbackResponse *resp = alloc->alloc(alloc->allocator_data, sizeof(Highbar__CallbackResponse));
    if (!resp) return NULL;
    highbar__callback_response__init(resp);
    resp->request_id = request_id;
    resp->success = 1;
    Highbar__CallbackResult *result = alloc->alloc(alloc->allocator_data, sizeof(Highbar__CallbackResult));
    if (!result) return resp;
    highbar__callback_result__init(result);
    result->value_case = HIGHBAR__CALLBACK_RESULT__VALUE_VECTOR_VALUE;
    Highbar__Vector3 *v = alloc->alloc(alloc->allocator_data, sizeof(Highbar__Vector3));
    if (!v) return resp;
    highbar__vector3__init(v);
    v->x = x; v->y = y; v->z = z;
    result->vector_value = v;
    resp->result = result;
    return resp;
}

static Highbar__CallbackResponse *make_error_response(
    uint32_t request_id, const char *error_msg, ProtobufCAllocator *alloc) {
    Highbar__CallbackResponse *resp = alloc->alloc(alloc->allocator_data, sizeof(Highbar__CallbackResponse));
    if (!resp) return NULL;
    highbar__callback_response__init(resp);
    resp->request_id = request_id;
    resp->success = 0;
    resp->error_message = (char *)error_msg;
    return resp;
}

// Extract first int param from request, or return default
static int32_t get_int_param(const Highbar__CallbackRequest *req, int index, int32_t def) {
    if ((size_t)index < req->n_params && req->params[index]
        && req->params[index]->value_case == HIGHBAR__CALLBACK_PARAM__VALUE_INT_VALUE) {
        return req->params[index]->int_value;
    }
    return def;
}

Highbar__CallbackResponse *hb_callback_dispatch(
    const Highbar__CallbackRequest *request,
    int skirmish_ai_id,
    const struct SSkirmishAICallback *callback,
    ProtobufCAllocator *alloc) {
    if (!request || !callback) {
        return make_error_response(request ? request->request_id : 0,
                                    "Invalid request or callback", alloc);
    }

    uint32_t cb_id = request->callback_id;
    uint32_t req_id = request->request_id;

    switch (cb_id) {
    // Game callbacks
    case HIGHBAR__CALLBACK_ID__CALLBACK_GAME_GET_MY_TEAM:
        if (callback->Game_getMyTeam) {
            return make_int_response(req_id, callback->Game_getMyTeam(skirmish_ai_id), alloc);
        }
        break;
    case HIGHBAR__CALLBACK_ID__CALLBACK_GAME_GET_MY_ALLY_TEAM:
        if (callback->Game_getMyAllyTeam) {
            return make_int_response(req_id, callback->Game_getMyAllyTeam(skirmish_ai_id), alloc);
        }
        break;
    case HIGHBAR__CALLBACK_ID__CALLBACK_GAME_GET_TEAM_COUNT:
        if (callback->Game_getTeamCount) {
            return make_int_response(req_id, callback->Game_getTeamCount(skirmish_ai_id), alloc);
        }
        break;

    // Map callbacks
    case HIGHBAR__CALLBACK_ID__CALLBACK_MAP_GET_WIDTH:
        if (callback->Map_getWidth) {
            return make_int_response(req_id, callback->Map_getWidth(skirmish_ai_id), alloc);
        }
        break;
    case HIGHBAR__CALLBACK_ID__CALLBACK_MAP_GET_HEIGHT:
        if (callback->Map_getHeight) {
            return make_int_response(req_id, callback->Map_getHeight(skirmish_ai_id), alloc);
        }
        break;

    // Unit callbacks
    case HIGHBAR__CALLBACK_ID__CALLBACK_UNIT_GET_POS: {
        if (callback->Unit_getPos) {
            int32_t unit_id = get_int_param(request, 0, -1);
            if (unit_id < 0) {
                return make_error_response(req_id, "Unit not found", alloc);
            }
            float pos[3];
            callback->Unit_getPos(skirmish_ai_id, unit_id, pos);
            return make_vec3_response(req_id, pos[0], pos[1], pos[2], alloc);
        }
        break;
    }
    case HIGHBAR__CALLBACK_ID__CALLBACK_UNIT_GET_HEALTH: {
        if (callback->Unit_getHealth) {
            int32_t unit_id = get_int_param(request, 0, -1);
            if (unit_id < 0) {
                return make_error_response(req_id, "Unit not found", alloc);
            }
            return make_float_response(req_id,
                callback->Unit_getHealth(skirmish_ai_id, unit_id), alloc);
        }
        break;
    }
    case HIGHBAR__CALLBACK_ID__CALLBACK_UNIT_GET_MAX_HEALTH: {
        if (callback->Unit_getMaxHealth) {
            int32_t unit_id = get_int_param(request, 0, -1);
            if (unit_id < 0) {
                return make_error_response(req_id, "Unit not found", alloc);
            }
            return make_float_response(req_id,
                callback->Unit_getMaxHealth(skirmish_ai_id, unit_id), alloc);
        }
        break;
    }

    default:
        return make_error_response(req_id, "Unknown callback ID", alloc);
    }

    return make_error_response(req_id, "Callback not available", alloc);
}
