#include "highbar/callbacks.h"
#include "highbar/engine_types.h"
#include "highbar/callbacks.pb-c.h"

#include <string.h>
#include <stdlib.h>

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

// Helper to create a success response with a FloatArray result
static Highbar__CallbackResponse *make_float_array_response(
    uint32_t request_id, const float *values, size_t count, ProtobufCAllocator *alloc) {
    Highbar__CallbackResponse *resp = alloc->alloc(alloc->allocator_data, sizeof(Highbar__CallbackResponse));
    if (!resp) return NULL;
    highbar__callback_response__init(resp);
    resp->request_id = request_id;
    resp->success = 1;
    Highbar__CallbackResult *result = alloc->alloc(alloc->allocator_data, sizeof(Highbar__CallbackResult));
    if (!result) return resp;
    highbar__callback_result__init(result);
    result->value_case = HIGHBAR__CALLBACK_RESULT__VALUE_FLOAT_ARRAY_VALUE;
    Highbar__FloatArray *arr = alloc->alloc(alloc->allocator_data, sizeof(Highbar__FloatArray));
    if (!arr) return resp;
    highbar__float_array__init(arr);
    arr->n_values = count;
    if (count > 0) {
        arr->values = alloc->alloc(alloc->allocator_data, count * sizeof(float));
        if (arr->values) {
            memcpy(arr->values, values, count * sizeof(float));
        }
    }
    result->float_array_value = arr;
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

    // Map data array callbacks (IDs 52-56)
    case HIGHBAR__CALLBACK_ID__CALLBACK_MAP_GET_HEIGHT_MAP: {
        if (callback->Map_getHeightMap && callback->Map_getWidth && callback->Map_getHeight) {
            int w = callback->Map_getWidth(skirmish_ai_id);
            int h = callback->Map_getHeight(skirmish_ai_id);
            int array_size = w * h;
            float *heights = malloc(array_size * sizeof(float));
            if (!heights) return make_error_response(req_id, "Alloc failed for heightmap", alloc);
            int returned = callback->Map_getHeightMap(skirmish_ai_id, heights, array_size);
            Highbar__CallbackResponse *resp = make_float_array_response(
                req_id, heights, (size_t)(returned > 0 ? returned : 0), alloc);
            free(heights);
            return resp;
        }
        break;
    }
    case HIGHBAR__CALLBACK_ID__CALLBACK_MAP_GET_SLOPE_MAP: {
        if (callback->Map_getSlopeMap && callback->Map_getWidth && callback->Map_getHeight) {
            int w = callback->Map_getWidth(skirmish_ai_id);
            int h = callback->Map_getHeight(skirmish_ai_id);
            int array_size = (w / 2) * (h / 2);
            float *slopes = malloc(array_size * sizeof(float));
            if (!slopes) return make_error_response(req_id, "Alloc failed for slopemap", alloc);
            int returned = callback->Map_getSlopeMap(skirmish_ai_id, slopes, array_size);
            Highbar__CallbackResponse *resp = make_float_array_response(
                req_id, slopes, (size_t)(returned > 0 ? returned : 0), alloc);
            free(slopes);
            return resp;
        }
        break;
    }
    case HIGHBAR__CALLBACK_ID__CALLBACK_MAP_GET_LOS_MAP: {
        if (callback->Map_getLosMap && callback->Map_getWidth && callback->Map_getHeight) {
            int w = callback->Map_getWidth(skirmish_ai_id);
            int h = callback->Map_getHeight(skirmish_ai_id);
            int array_size = w * h; // upper bound; actual may be smaller
            int *los = malloc(array_size * sizeof(int));
            if (!los) return make_error_response(req_id, "Alloc failed for losmap", alloc);
            int returned = callback->Map_getLosMap(skirmish_ai_id, los, array_size);
            Highbar__CallbackResponse *resp = make_int_array_response(
                req_id, los, (size_t)(returned > 0 ? returned : 0), alloc);
            free(los);
            return resp;
        }
        break;
    }
    case HIGHBAR__CALLBACK_ID__CALLBACK_MAP_GET_RADAR_MAP: {
        if (callback->Map_getRadarMap && callback->Map_getWidth && callback->Map_getHeight) {
            int w = callback->Map_getWidth(skirmish_ai_id);
            int h = callback->Map_getHeight(skirmish_ai_id);
            int array_size = w * h; // upper bound
            int *radar = malloc(array_size * sizeof(int));
            if (!radar) return make_error_response(req_id, "Alloc failed for radarmap", alloc);
            int returned = callback->Map_getRadarMap(skirmish_ai_id, radar, array_size);
            Highbar__CallbackResponse *resp = make_int_array_response(
                req_id, radar, (size_t)(returned > 0 ? returned : 0), alloc);
            free(radar);
            return resp;
        }
        break;
    }
    case HIGHBAR__CALLBACK_ID__CALLBACK_MAP_GET_RESOURCE_MAP: {
        if (callback->Map_getResourceMapRaw && callback->Map_getWidth && callback->Map_getHeight) {
            int w = callback->Map_getWidth(skirmish_ai_id);
            int h = callback->Map_getHeight(skirmish_ai_id);
            int array_size = (w / 2) * (h / 2);
            int resourceId = get_int_param(request, 0, 0); // default to metal (0)
            short *raw = malloc(array_size * sizeof(short));
            if (!raw) return make_error_response(req_id, "Alloc failed for resourcemap", alloc);
            int returned = callback->Map_getResourceMapRaw(skirmish_ai_id, resourceId, raw, array_size);
            if (returned < 0) returned = 0;
            // Widen short -> int32
            int32_t *widened = malloc(returned * sizeof(int32_t));
            if (!widened) { free(raw); return make_error_response(req_id, "Alloc failed for resourcemap widen", alloc); }
            for (int i = 0; i < returned; i++) {
                widened[i] = (int32_t)raw[i];
            }
            Highbar__CallbackResponse *resp = make_int_array_response(
                req_id, widened, (size_t)returned, alloc);
            free(raw);
            free(widened);
            return resp;
        }
        break;
    }

    // Map feature callbacks (IDs 57-58)
    case HIGHBAR__CALLBACK_ID__CALLBACK_MAP_GET_START_POS: {
        if (callback->Map_getStartPos) {
            float pos[3] = {0};
            callback->Map_getStartPos(skirmish_ai_id, pos);
            return make_vec3_response(req_id, pos[0], pos[1], pos[2], alloc);
        }
        break;
    }
    case HIGHBAR__CALLBACK_ID__CALLBACK_MAP_GET_METAL_SPOTS: {
        if (callback->Map_getResourceMapSpotsPositions) {
            int resourceId = 0; // metal
            int max_spots = 256;
            float *positions = malloc(max_spots * 3 * sizeof(float));
            if (!positions) return make_error_response(req_id, "Alloc failed for metal spots", alloc);
            int count = callback->Map_getResourceMapSpotsPositions(
                skirmish_ai_id, resourceId, positions, max_spots * 3);
            if (count < 0) count = 0;
            int spot_count = count / 3; // each spot is 3 floats (x, y, z)

            float avg_income = 0.0f;
            if (callback->Map_getResourceMapSpotsAverageIncome) {
                avg_income = callback->Map_getResourceMapSpotsAverageIncome(skirmish_ai_id, resourceId);
            }

            size_t out_count = (size_t)spot_count * 4;
            float *packed = alloc->alloc(alloc->allocator_data, out_count * sizeof(float));
            if (!packed) { free(positions); return make_error_response(req_id, "Alloc failed", alloc); }
            for (int i = 0; i < spot_count; i++) {
                packed[i * 4 + 0] = positions[i * 3 + 0]; // x
                packed[i * 4 + 1] = positions[i * 3 + 1]; // y
                packed[i * 4 + 2] = positions[i * 3 + 2]; // z
                packed[i * 4 + 3] = avg_income;            // value
            }
            free(positions);
            return make_float_array_response(req_id, packed, out_count, alloc);
        }
        break;
    }

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
