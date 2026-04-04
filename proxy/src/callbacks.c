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

// Helper to create a success response with a string result
static Highbar__CallbackResponse *make_string_response(
    uint32_t request_id, const char *value, ProtobufCAllocator *alloc) {
    Highbar__CallbackResponse *resp = alloc->alloc(alloc->allocator_data, sizeof(Highbar__CallbackResponse));
    if (!resp) return NULL;
    highbar__callback_response__init(resp);
    resp->request_id = request_id;
    resp->success = 1;
    Highbar__CallbackResult *result = alloc->alloc(alloc->allocator_data, sizeof(Highbar__CallbackResult));
    if (!result) return resp;
    highbar__callback_result__init(result);
    result->value_case = HIGHBAR__CALLBACK_RESULT__VALUE_STRING_VALUE;
    result->string_value = (char *)value;
    resp->result = result;
    return resp;
}

// Helper to create a success response with an IntArray result
static Highbar__CallbackResponse *make_int_array_response(
    uint32_t request_id, const int32_t *values, size_t count, ProtobufCAllocator *alloc) {
    Highbar__CallbackResponse *resp = alloc->alloc(alloc->allocator_data, sizeof(Highbar__CallbackResponse));
    if (!resp) return NULL;
    highbar__callback_response__init(resp);
    resp->request_id = request_id;
    resp->success = 1;
    Highbar__CallbackResult *result = alloc->alloc(alloc->allocator_data, sizeof(Highbar__CallbackResult));
    if (!result) return resp;
    highbar__callback_result__init(result);
    result->value_case = HIGHBAR__CALLBACK_RESULT__VALUE_INT_ARRAY_VALUE;
    Highbar__IntArray *arr = alloc->alloc(alloc->allocator_data, sizeof(Highbar__IntArray));
    if (!arr) return resp;
    highbar__int_array__init(arr);
    arr->n_values = count;
    if (count > 0) {
        arr->values = alloc->alloc(alloc->allocator_data, count * sizeof(int32_t));
        if (arr->values) {
            memcpy(arr->values, values, count * sizeof(int32_t));
        }
    }
    result->int_array_value = arr;
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
    case HIGHBAR__CALLBACK_ID__CALLBACK_UNIT_GET_DEF: {
        if (callback->Unit_getDef) {
            int32_t unit_id = get_int_param(request, 0, -1);
            if (unit_id < 0) {
                return make_error_response(req_id, "Unit not found", alloc);
            }
            return make_int_response(req_id,
                callback->Unit_getDef(skirmish_ai_id, unit_id), alloc);
        }
        break;
    }

    // UnitDef callbacks
    case HIGHBAR__CALLBACK_ID__CALLBACK_UNITDEF_GET_NAME: {
        if (callback->UnitDef_getName) {
            int32_t def_id = get_int_param(request, 0, -1);
            if (def_id < 0) {
                return make_error_response(req_id, "Invalid unitDefId", alloc);
            }
            const char *name = callback->UnitDef_getName(skirmish_ai_id, def_id);
            if (!name) name = "";
            return make_string_response(req_id, name, alloc);
        }
        break;
    }
    case HIGHBAR__CALLBACK_ID__CALLBACK_UNITDEF_GET_BUILD_OPTIONS: {
        if (callback->UnitDef_getBuildOptions) {
            int32_t def_id = get_int_param(request, 0, -1);
            int32_t max_count = get_int_param(request, 1, 256);
            if (def_id < 0) {
                return make_error_response(req_id, "Invalid unitDefId", alloc);
            }
            int32_t *ids = alloc->alloc(alloc->allocator_data, max_count * sizeof(int32_t));
            if (!ids) return make_error_response(req_id, "Alloc failed", alloc);
            int count = callback->UnitDef_getBuildOptions(skirmish_ai_id, def_id, ids, max_count);
            if (count < 0) count = 0;
            return make_int_array_response(req_id, ids, (size_t)count, alloc);
        }
        break;
    }
    case HIGHBAR__CALLBACK_ID__CALLBACK_UNITDEF_GET_MAX_WEAPON_RANGE: {
        if (callback->UnitDef_getMaxWeaponRange) {
            int32_t def_id = get_int_param(request, 0, -1);
            if (def_id < 0) {
                return make_error_response(req_id, "Invalid unitDefId", alloc);
            }
            return make_float_response(req_id,
                callback->UnitDef_getMaxWeaponRange(skirmish_ai_id, def_id), alloc);
        }
        break;
    }
    case HIGHBAR__CALLBACK_ID__CALLBACK_UNITDEF_GET_BUILD_SPEED: {
        if (callback->UnitDef_getBuildSpeed) {
            int32_t def_id = get_int_param(request, 0, -1);
            if (def_id < 0) {
                return make_error_response(req_id, "Invalid unitDefId", alloc);
            }
            return make_float_response(req_id,
                callback->UnitDef_getBuildSpeed(skirmish_ai_id, def_id), alloc);
        }
        break;
    }
    case HIGHBAR__CALLBACK_ID__CALLBACK_GET_UNIT_DEFS: {
        if (callback->getUnitDefs) {
            int32_t max_count = get_int_param(request, 0, 1024);
            int32_t *ids = alloc->alloc(alloc->allocator_data, max_count * sizeof(int32_t));
            if (!ids) return make_error_response(req_id, "Alloc failed", alloc);
            int count = callback->getUnitDefs(skirmish_ai_id, ids, max_count);
            if (count < 0) count = 0;
            return make_int_array_response(req_id, ids, (size_t)count, alloc);
        }
        break;
    }

    // Cheats callbacks
    case HIGHBAR__CALLBACK_ID__CALLBACK_CHEATS_SET_EVENTS_ENABLED: {
        if (callback->Cheats_setEventsEnabled) {
            int32_t enabled = get_int_param(request, 0, 1);
            bool result = callback->Cheats_setEventsEnabled(skirmish_ai_id, enabled != 0);
            return make_int_response(req_id, result ? 1 : 0, alloc);
        }
        break;
    }

    default:
        return make_error_response(req_id, "Unknown callback ID", alloc);
    }

    return make_error_response(req_id, "Callback not available", alloc);
}
