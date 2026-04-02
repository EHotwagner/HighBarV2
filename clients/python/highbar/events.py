"""Typed event wrappers for HighBar engine events."""

from dataclasses import dataclass, field
from typing import Optional


@dataclass
class GameEvent:
    """Base class for all game events."""
    event_type: str


@dataclass
class InitEvent(GameEvent):
    team_id: int
    event_type: str = "init"


@dataclass
class ReleaseEvent(GameEvent):
    event_type: str = "release"


@dataclass
class UpdateEvent(GameEvent):
    frame: int
    event_type: str = "update"


@dataclass
class MessageEvent(GameEvent):
    player: int
    message: str
    event_type: str = "message"


@dataclass
class UnitCreatedEvent(GameEvent):
    unit_id: int
    builder_id: int
    event_type: str = "unit_created"


@dataclass
class UnitFinishedEvent(GameEvent):
    unit_id: int
    event_type: str = "unit_finished"


@dataclass
class UnitIdleEvent(GameEvent):
    unit_id: int
    event_type: str = "unit_idle"


@dataclass
class UnitMoveFailedEvent(GameEvent):
    unit_id: int
    event_type: str = "unit_move_failed"


@dataclass
class UnitDamagedEvent(GameEvent):
    unit_id: int
    attacker_id: Optional[int]
    damage: float
    weapon_def_id: int
    is_paralyzer: bool
    event_type: str = "unit_damaged"


@dataclass
class UnitDestroyedEvent(GameEvent):
    unit_id: int
    attacker_id: Optional[int]
    event_type: str = "unit_destroyed"


@dataclass
class UnitGivenEvent(GameEvent):
    unit_id: int
    old_team_id: int
    new_team_id: int
    event_type: str = "unit_given"


@dataclass
class UnitCapturedEvent(GameEvent):
    unit_id: int
    old_team_id: int
    new_team_id: int
    event_type: str = "unit_captured"


@dataclass
class EnemyEnterLOSEvent(GameEvent):
    enemy_id: int
    event_type: str = "enemy_enter_los"


@dataclass
class EnemyLeaveLOSEvent(GameEvent):
    enemy_id: int
    event_type: str = "enemy_leave_los"


@dataclass
class EnemyEnterRadarEvent(GameEvent):
    enemy_id: int
    event_type: str = "enemy_enter_radar"


@dataclass
class EnemyLeaveRadarEvent(GameEvent):
    enemy_id: int
    event_type: str = "enemy_leave_radar"


@dataclass
class EnemyDamagedEvent(GameEvent):
    enemy_id: int
    attacker_id: Optional[int]
    damage: float
    weapon_def_id: int
    event_type: str = "enemy_damaged"


@dataclass
class EnemyDestroyedEvent(GameEvent):
    enemy_id: int
    attacker_id: Optional[int]
    event_type: str = "enemy_destroyed"


@dataclass
class WeaponFiredEvent(GameEvent):
    unit_id: int
    weapon_def_id: int
    event_type: str = "weapon_fired"


@dataclass
class PlayerCommandEvent(GameEvent):
    units: list[int]
    command_topic_id: int
    command_id: int
    event_type: str = "player_command"


@dataclass
class SeismicPingEvent(GameEvent):
    x: float
    y: float
    z: float
    strength: float
    event_type: str = "seismic_ping"


@dataclass
class CommandFinishedEvent(GameEvent):
    unit_id: int
    command_id: int
    command_topic_id: int
    event_type: str = "command_finished"


@dataclass
class LoadEvent(GameEvent):
    event_type: str = "load"


@dataclass
class SaveEvent(GameEvent):
    event_type: str = "save"


@dataclass
class EnemyCreatedEvent(GameEvent):
    enemy_id: int
    event_type: str = "enemy_created"


@dataclass
class EnemyFinishedEvent(GameEvent):
    enemy_id: int
    event_type: str = "enemy_finished"


@dataclass
class LuaMessageEvent(GameEvent):
    data: str
    in_message_id: int
    event_type: str = "lua_message"


@dataclass
class UnknownEvent(GameEvent):
    event_type: str = "unknown"


def which_event(engine_event) -> str:
    """Return the name of the active event field in an EngineEvent."""
    return engine_event.WhichOneof("event") or "unknown"


def parse_event(engine_event) -> GameEvent:
    """Convert a protobuf EngineEvent to a typed Python GameEvent."""
    event_name = which_event(engine_event)

    match event_name:
        case "init":
            return InitEvent(team_id=engine_event.init.team_id)
        case "release":
            return ReleaseEvent()
        case "update":
            return UpdateEvent(frame=engine_event.update.frame)
        case "message":
            return MessageEvent(player=engine_event.message.player,
                                message=engine_event.message.message)
        case "unit_created":
            e = engine_event.unit_created
            return UnitCreatedEvent(unit_id=e.unit_id, builder_id=e.builder_id)
        case "unit_finished":
            return UnitFinishedEvent(unit_id=engine_event.unit_finished.unit_id)
        case "unit_idle":
            return UnitIdleEvent(unit_id=engine_event.unit_idle.unit_id)
        case "unit_move_failed":
            return UnitMoveFailedEvent(unit_id=engine_event.unit_move_failed.unit_id)
        case "unit_damaged":
            e = engine_event.unit_damaged
            attacker = e.attacker_id if e.HasField("attacker_id") else None
            return UnitDamagedEvent(
                unit_id=e.unit_id, attacker_id=attacker,
                damage=e.damage, weapon_def_id=e.weapon_def_id,
                is_paralyzer=e.is_paralyzer)
        case "unit_destroyed":
            e = engine_event.unit_destroyed
            attacker = e.attacker_id if e.HasField("attacker_id") else None
            return UnitDestroyedEvent(unit_id=e.unit_id, attacker_id=attacker)
        case "unit_given":
            e = engine_event.unit_given
            return UnitGivenEvent(unit_id=e.unit_id, old_team_id=e.old_team_id, new_team_id=e.new_team_id)
        case "unit_captured":
            e = engine_event.unit_captured
            return UnitCapturedEvent(unit_id=e.unit_id, old_team_id=e.old_team_id, new_team_id=e.new_team_id)
        case "enemy_enter_los":
            return EnemyEnterLOSEvent(enemy_id=engine_event.enemy_enter_los.enemy_id)
        case "enemy_leave_los":
            return EnemyLeaveLOSEvent(enemy_id=engine_event.enemy_leave_los.enemy_id)
        case "enemy_enter_radar":
            return EnemyEnterRadarEvent(enemy_id=engine_event.enemy_enter_radar.enemy_id)
        case "enemy_leave_radar":
            return EnemyLeaveRadarEvent(enemy_id=engine_event.enemy_leave_radar.enemy_id)
        case "enemy_damaged":
            e = engine_event.enemy_damaged
            attacker = e.attacker_id if e.HasField("attacker_id") else None
            return EnemyDamagedEvent(enemy_id=e.enemy_id, attacker_id=attacker,
                                     damage=e.damage, weapon_def_id=e.weapon_def_id)
        case "enemy_destroyed":
            e = engine_event.enemy_destroyed
            attacker = e.attacker_id if e.HasField("attacker_id") else None
            return EnemyDestroyedEvent(enemy_id=e.enemy_id, attacker_id=attacker)
        case "weapon_fired":
            return WeaponFiredEvent(unit_id=engine_event.weapon_fired.unit_id,
                                    weapon_def_id=engine_event.weapon_fired.weapon_def_id)
        case "player_command":
            e = engine_event.player_command
            return PlayerCommandEvent(units=list(e.units),
                                      command_topic_id=e.command_topic_id,
                                      command_id=e.command_id)
        case "seismic_ping":
            e = engine_event.seismic_ping
            p = e.position
            return SeismicPingEvent(x=p.x, y=p.y, z=p.z, strength=e.strength)
        case "command_finished":
            e = engine_event.command_finished
            return CommandFinishedEvent(unit_id=e.unit_id, command_id=e.command_id,
                                        command_topic_id=e.command_topic_id)
        case "load":
            return LoadEvent()
        case "save":
            return SaveEvent()
        case "enemy_created":
            return EnemyCreatedEvent(enemy_id=engine_event.enemy_created.enemy_id)
        case "enemy_finished":
            return EnemyFinishedEvent(enemy_id=engine_event.enemy_finished.enemy_id)
        case "lua_message":
            e = engine_event.lua_message
            return LuaMessageEvent(data=e.data, in_message_id=e.in_message_id)
        case _:
            return UnknownEvent()
