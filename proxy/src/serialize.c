#include "highbar/serialize.h"
#include "highbar/engine_types.h"
#include "highbar/events.pb-c.h"

#include <string.h>

// Helper to allocate and init a Vector3 message
static Highbar__Vector3 *alloc_vec3(float x, float y, float z, ProtobufCAllocator *alloc) {
    Highbar__Vector3 *v = alloc->alloc(alloc->allocator_data, sizeof(Highbar__Vector3));
    if (!v) return NULL;
    highbar__vector3__init(v);
    v->x = x;
    v->y = y;
    v->z = z;
    return v;
}

Highbar__EngineEvent *hb_serialize_event(int topic_id, const void *data,
                                          ProtobufCAllocator *alloc) {
    Highbar__EngineEvent *event = alloc->alloc(alloc->allocator_data, sizeof(Highbar__EngineEvent));
    if (!event) return NULL;
    highbar__engine_event__init(event);

    switch (topic_id) {
    case EVENT_INIT: {
        const struct SInitEvent *e = (const struct SInitEvent *)data;
        Highbar__InitEvent *m = alloc->alloc(alloc->allocator_data, sizeof(Highbar__InitEvent));
        if (!m) return NULL;
        highbar__init_event__init(m);
        m->team_id = e->team;
        event->event_case = HIGHBAR__ENGINE_EVENT__EVENT_INIT;
        event->init = m;
        break;
    }
    case EVENT_RELEASE: {
        Highbar__ReleaseEvent *m = alloc->alloc(alloc->allocator_data, sizeof(Highbar__ReleaseEvent));
        if (!m) return NULL;
        highbar__release_event__init(m);
        event->event_case = HIGHBAR__ENGINE_EVENT__EVENT_RELEASE;
        event->release = m;
        break;
    }
    case EVENT_UPDATE: {
        const struct SUpdateEvent *e = (const struct SUpdateEvent *)data;
        Highbar__UpdateEvent *m = alloc->alloc(alloc->allocator_data, sizeof(Highbar__UpdateEvent));
        if (!m) return NULL;
        highbar__update_event__init(m);
        m->frame = e->frame;
        event->event_case = HIGHBAR__ENGINE_EVENT__EVENT_UPDATE;
        event->update = m;
        break;
    }
    case EVENT_MESSAGE: {
        const struct SMessageEvent *e = (const struct SMessageEvent *)data;
        Highbar__MessageEvent *m = alloc->alloc(alloc->allocator_data, sizeof(Highbar__MessageEvent));
        if (!m) return NULL;
        highbar__message_event__init(m);
        m->player = e->player;
        m->message = (char *)e->message;
        event->event_case = HIGHBAR__ENGINE_EVENT__EVENT_MESSAGE;
        event->message = m;
        break;
    }
    case EVENT_UNIT_CREATED: {
        const struct SUnitCreatedEvent *e = (const struct SUnitCreatedEvent *)data;
        Highbar__UnitCreatedEvent *m = alloc->alloc(alloc->allocator_data, sizeof(Highbar__UnitCreatedEvent));
        if (!m) return NULL;
        highbar__unit_created_event__init(m);
        m->unit_id = e->unit;
        m->builder_id = e->builder;
        event->event_case = HIGHBAR__ENGINE_EVENT__EVENT_UNIT_CREATED;
        event->unit_created = m;
        break;
    }
    case EVENT_UNIT_FINISHED: {
        const struct SUnitFinishedEvent *e = (const struct SUnitFinishedEvent *)data;
        Highbar__UnitFinishedEvent *m = alloc->alloc(alloc->allocator_data, sizeof(Highbar__UnitFinishedEvent));
        if (!m) return NULL;
        highbar__unit_finished_event__init(m);
        m->unit_id = e->unit;
        event->event_case = HIGHBAR__ENGINE_EVENT__EVENT_UNIT_FINISHED;
        event->unit_finished = m;
        break;
    }
    case EVENT_UNIT_IDLE: {
        const struct SUnitIdleEvent *e = (const struct SUnitIdleEvent *)data;
        Highbar__UnitIdleEvent *m = alloc->alloc(alloc->allocator_data, sizeof(Highbar__UnitIdleEvent));
        if (!m) return NULL;
        highbar__unit_idle_event__init(m);
        m->unit_id = e->unit;
        event->event_case = HIGHBAR__ENGINE_EVENT__EVENT_UNIT_IDLE;
        event->unit_idle = m;
        break;
    }
    case EVENT_UNIT_MOVE_FAILED: {
        const struct SUnitMoveFailedEvent *e = (const struct SUnitMoveFailedEvent *)data;
        Highbar__UnitMoveFailedEvent *m = alloc->alloc(alloc->allocator_data, sizeof(Highbar__UnitMoveFailedEvent));
        if (!m) return NULL;
        highbar__unit_move_failed_event__init(m);
        m->unit_id = e->unit;
        event->event_case = HIGHBAR__ENGINE_EVENT__EVENT_UNIT_MOVE_FAILED;
        event->unit_move_failed = m;
        break;
    }
    case EVENT_UNIT_DAMAGED: {
        const struct SUnitDamagedEvent *e = (const struct SUnitDamagedEvent *)data;
        Highbar__UnitDamagedEvent *m = alloc->alloc(alloc->allocator_data, sizeof(Highbar__UnitDamagedEvent));
        if (!m) return NULL;
        highbar__unit_damaged_event__init(m);
        m->unit_id = e->unit;
        if (e->attacker >= 0) {
            m->_attacker_id_case = HIGHBAR__UNIT_DAMAGED_EVENT___ATTACKER_ID_ATTACKER_ID;
            m->attacker_id = e->attacker;
        }
        m->damage = e->damage;
        m->direction = alloc_vec3(e->dir_x, e->dir_y, e->dir_z, alloc);
        m->weapon_def_id = e->weaponDefId;
        m->is_paralyzer = (e->paralyzer != 0);
        event->event_case = HIGHBAR__ENGINE_EVENT__EVENT_UNIT_DAMAGED;
        event->unit_damaged = m;
        break;
    }
    case EVENT_UNIT_DESTROYED: {
        const struct SUnitDestroyedEvent *e = (const struct SUnitDestroyedEvent *)data;
        Highbar__UnitDestroyedEvent *m = alloc->alloc(alloc->allocator_data, sizeof(Highbar__UnitDestroyedEvent));
        if (!m) return NULL;
        highbar__unit_destroyed_event__init(m);
        m->unit_id = e->unit;
        if (e->attacker >= 0) {
            m->_attacker_id_case = HIGHBAR__UNIT_DESTROYED_EVENT___ATTACKER_ID_ATTACKER_ID;
            m->attacker_id = e->attacker;
        }
        event->event_case = HIGHBAR__ENGINE_EVENT__EVENT_UNIT_DESTROYED;
        event->unit_destroyed = m;
        break;
    }
    case EVENT_UNIT_GIVEN: {
        const struct SUnitGivenEvent *e = (const struct SUnitGivenEvent *)data;
        Highbar__UnitGivenEvent *m = alloc->alloc(alloc->allocator_data, sizeof(Highbar__UnitGivenEvent));
        if (!m) return NULL;
        highbar__unit_given_event__init(m);
        m->unit_id = e->unit;
        m->old_team_id = e->oldTeamId;
        m->new_team_id = e->newTeamId;
        event->event_case = HIGHBAR__ENGINE_EVENT__EVENT_UNIT_GIVEN;
        event->unit_given = m;
        break;
    }
    case EVENT_UNIT_CAPTURED: {
        const struct SUnitCapturedEvent *e = (const struct SUnitCapturedEvent *)data;
        Highbar__UnitCapturedEvent *m = alloc->alloc(alloc->allocator_data, sizeof(Highbar__UnitCapturedEvent));
        if (!m) return NULL;
        highbar__unit_captured_event__init(m);
        m->unit_id = e->unit;
        m->old_team_id = e->oldTeamId;
        m->new_team_id = e->newTeamId;
        event->event_case = HIGHBAR__ENGINE_EVENT__EVENT_UNIT_CAPTURED;
        event->unit_captured = m;
        break;
    }
    case EVENT_ENEMY_ENTER_LOS: {
        const struct SEnemyEnterLOSEvent *e = (const struct SEnemyEnterLOSEvent *)data;
        Highbar__EnemyEnterLOSEvent *m = alloc->alloc(alloc->allocator_data, sizeof(Highbar__EnemyEnterLOSEvent));
        if (!m) return NULL;
        highbar__enemy_enter_losevent__init(m);
        m->enemy_id = e->enemy;
        event->event_case = HIGHBAR__ENGINE_EVENT__EVENT_ENEMY_ENTER_LOS;
        event->enemy_enter_los = m;
        break;
    }
    case EVENT_ENEMY_LEAVE_LOS: {
        const struct SEnemyLeaveLOSEvent *e = (const struct SEnemyLeaveLOSEvent *)data;
        Highbar__EnemyLeaveLOSEvent *m = alloc->alloc(alloc->allocator_data, sizeof(Highbar__EnemyLeaveLOSEvent));
        if (!m) return NULL;
        highbar__enemy_leave_losevent__init(m);
        m->enemy_id = e->enemy;
        event->event_case = HIGHBAR__ENGINE_EVENT__EVENT_ENEMY_LEAVE_LOS;
        event->enemy_leave_los = m;
        break;
    }
    case EVENT_ENEMY_ENTER_RADAR: {
        const struct SEnemyEnterRadarEvent *e = (const struct SEnemyEnterRadarEvent *)data;
        Highbar__EnemyEnterRadarEvent *m = alloc->alloc(alloc->allocator_data, sizeof(Highbar__EnemyEnterRadarEvent));
        if (!m) return NULL;
        highbar__enemy_enter_radar_event__init(m);
        m->enemy_id = e->enemy;
        event->event_case = HIGHBAR__ENGINE_EVENT__EVENT_ENEMY_ENTER_RADAR;
        event->enemy_enter_radar = m;
        break;
    }
    case EVENT_ENEMY_LEAVE_RADAR: {
        const struct SEnemyLeaveRadarEvent *e = (const struct SEnemyLeaveRadarEvent *)data;
        Highbar__EnemyLeaveRadarEvent *m = alloc->alloc(alloc->allocator_data, sizeof(Highbar__EnemyLeaveRadarEvent));
        if (!m) return NULL;
        highbar__enemy_leave_radar_event__init(m);
        m->enemy_id = e->enemy;
        event->event_case = HIGHBAR__ENGINE_EVENT__EVENT_ENEMY_LEAVE_RADAR;
        event->enemy_leave_radar = m;
        break;
    }
    case EVENT_ENEMY_DAMAGED: {
        const struct SEnemyDamagedEvent *e = (const struct SEnemyDamagedEvent *)data;
        Highbar__EnemyDamagedEvent *m = alloc->alloc(alloc->allocator_data, sizeof(Highbar__EnemyDamagedEvent));
        if (!m) return NULL;
        highbar__enemy_damaged_event__init(m);
        m->enemy_id = e->enemy;
        if (e->attacker >= 0) {
            m->_attacker_id_case = HIGHBAR__ENEMY_DAMAGED_EVENT___ATTACKER_ID_ATTACKER_ID;
            m->attacker_id = e->attacker;
        }
        m->damage = e->damage;
        m->direction = alloc_vec3(e->dir_x, e->dir_y, e->dir_z, alloc);
        m->weapon_def_id = e->weaponDefId;
        event->event_case = HIGHBAR__ENGINE_EVENT__EVENT_ENEMY_DAMAGED;
        event->enemy_damaged = m;
        break;
    }
    case EVENT_ENEMY_DESTROYED: {
        const struct SEnemyDestroyedEvent *e = (const struct SEnemyDestroyedEvent *)data;
        Highbar__EnemyDestroyedEvent *m = alloc->alloc(alloc->allocator_data, sizeof(Highbar__EnemyDestroyedEvent));
        if (!m) return NULL;
        highbar__enemy_destroyed_event__init(m);
        m->enemy_id = e->enemy;
        if (e->attacker >= 0) {
            m->_attacker_id_case = HIGHBAR__ENEMY_DESTROYED_EVENT___ATTACKER_ID_ATTACKER_ID;
            m->attacker_id = e->attacker;
        }
        event->event_case = HIGHBAR__ENGINE_EVENT__EVENT_ENEMY_DESTROYED;
        event->enemy_destroyed = m;
        break;
    }
    case EVENT_WEAPON_FIRED: {
        const struct SWeaponFiredEvent *e = (const struct SWeaponFiredEvent *)data;
        Highbar__WeaponFiredEvent *m = alloc->alloc(alloc->allocator_data, sizeof(Highbar__WeaponFiredEvent));
        if (!m) return NULL;
        highbar__weapon_fired_event__init(m);
        m->unit_id = e->unitId;
        m->weapon_def_id = e->weaponDefId;
        event->event_case = HIGHBAR__ENGINE_EVENT__EVENT_WEAPON_FIRED;
        event->weapon_fired = m;
        break;
    }
    case EVENT_PLAYER_COMMAND: {
        const struct SPlayerCommandEvent *e = (const struct SPlayerCommandEvent *)data;
        Highbar__PlayerCommandEvent *m = alloc->alloc(alloc->allocator_data, sizeof(Highbar__PlayerCommandEvent));
        if (!m) return NULL;
        highbar__player_command_event__init(m);
        m->n_units = (size_t)e->numUnitIds;
        m->units = alloc->alloc(alloc->allocator_data, sizeof(int32_t) * m->n_units);
        if (m->units) {
            for (size_t i = 0; i < m->n_units; i++) {
                m->units[i] = e->unitIds[i];
            }
        }
        m->command_topic_id = e->commandTopicId;
        m->command_id = e->commandId;
        event->event_case = HIGHBAR__ENGINE_EVENT__EVENT_PLAYER_COMMAND;
        event->player_command = m;
        break;
    }
    case EVENT_SEISMIC_PING: {
        const struct SSeismicPingEvent *e = (const struct SSeismicPingEvent *)data;
        Highbar__SeismicPingEvent *m = alloc->alloc(alloc->allocator_data, sizeof(Highbar__SeismicPingEvent));
        if (!m) return NULL;
        highbar__seismic_ping_event__init(m);
        m->position = alloc_vec3(e->pos_posF3[0], e->pos_posF3[1], e->pos_posF3[2], alloc);
        m->strength = e->strength;
        event->event_case = HIGHBAR__ENGINE_EVENT__EVENT_SEISMIC_PING;
        event->seismic_ping = m;
        break;
    }
    case EVENT_COMMAND_FINISHED: {
        const struct SCommandFinishedEvent *e = (const struct SCommandFinishedEvent *)data;
        Highbar__CommandFinishedEvent *m = alloc->alloc(alloc->allocator_data, sizeof(Highbar__CommandFinishedEvent));
        if (!m) return NULL;
        highbar__command_finished_event__init(m);
        m->unit_id = e->unitId;
        m->command_id = e->commandId;
        m->command_topic_id = e->commandTopicId;
        event->event_case = HIGHBAR__ENGINE_EVENT__EVENT_COMMAND_FINISHED;
        event->command_finished = m;
        break;
    }
    case EVENT_LOAD: {
        Highbar__LoadEvent *m = alloc->alloc(alloc->allocator_data, sizeof(Highbar__LoadEvent));
        if (!m) return NULL;
        highbar__load_event__init(m);
        event->event_case = HIGHBAR__ENGINE_EVENT__EVENT_LOAD;
        event->load = m;
        break;
    }
    case EVENT_SAVE: {
        Highbar__SaveEvent *m = alloc->alloc(alloc->allocator_data, sizeof(Highbar__SaveEvent));
        if (!m) return NULL;
        highbar__save_event__init(m);
        event->event_case = HIGHBAR__ENGINE_EVENT__EVENT_SAVE;
        event->save = m;
        break;
    }
    case EVENT_ENEMY_CREATED: {
        const struct SEnemyCreatedEvent *e = (const struct SEnemyCreatedEvent *)data;
        Highbar__EnemyCreatedEvent *m = alloc->alloc(alloc->allocator_data, sizeof(Highbar__EnemyCreatedEvent));
        if (!m) return NULL;
        highbar__enemy_created_event__init(m);
        m->enemy_id = e->enemy;
        event->event_case = HIGHBAR__ENGINE_EVENT__EVENT_ENEMY_CREATED;
        event->enemy_created = m;
        break;
    }
    case EVENT_ENEMY_FINISHED: {
        const struct SEnemyFinishedEvent *e = (const struct SEnemyFinishedEvent *)data;
        Highbar__EnemyFinishedEvent *m = alloc->alloc(alloc->allocator_data, sizeof(Highbar__EnemyFinishedEvent));
        if (!m) return NULL;
        highbar__enemy_finished_event__init(m);
        m->enemy_id = e->enemy;
        event->event_case = HIGHBAR__ENGINE_EVENT__EVENT_ENEMY_FINISHED;
        event->enemy_finished = m;
        break;
    }
    case EVENT_LUA_MESSAGE: {
        const struct SLuaMessageEvent *e = (const struct SLuaMessageEvent *)data;
        Highbar__LuaMessageEvent *m = alloc->alloc(alloc->allocator_data, sizeof(Highbar__LuaMessageEvent));
        if (!m) return NULL;
        highbar__lua_message_event__init(m);
        m->data = (char *)e->inData;
        m->in_message_id = e->inMessageId;
        event->event_case = HIGHBAR__ENGINE_EVENT__EVENT_LUA_MESSAGE;
        event->lua_message = m;
        break;
    }
    default:
        return NULL;
    }

    return event;
}
