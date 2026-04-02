"""Typed command builders for HighBar AI commands."""

# These factory functions create protobuf AICommand messages.
# They depend on generated protobuf code in proto/gen/python/.
# For now, they return plain dicts that can be converted to protobuf.

from dataclasses import dataclass, field
from typing import Optional


@dataclass
class Position:
    x: float
    y: float
    z: float


@dataclass
class CommandBase:
    """Common fields for unit commands."""
    unit_id: int = 0
    group_id: int = 0
    options: int = 0
    timeout: int = -1


def MoveCommand(unit_id: int, position: Position, **kwargs) -> dict:
    return {
        "type": "move_unit",
        "unit_id": unit_id,
        "to_position": {"x": position.x, "y": position.y, "z": position.z},
        "timeout": kwargs.get("timeout", -1),
        "options": kwargs.get("options", 0),
    }


def BuildCommand(unit_id: int, unit_def_id: int, position: Position,
                 facing: int = 0, **kwargs) -> dict:
    return {
        "type": "build_unit",
        "unit_id": unit_id,
        "to_build_unit_def_id": unit_def_id,
        "build_position": {"x": position.x, "y": position.y, "z": position.z},
        "facing": facing,
        "timeout": kwargs.get("timeout", -1),
        "options": kwargs.get("options", 0),
    }


def PatrolCommand(unit_id: int, position: Position, **kwargs) -> dict:
    return {
        "type": "patrol",
        "unit_id": unit_id,
        "to_position": {"x": position.x, "y": position.y, "z": position.z},
        "timeout": kwargs.get("timeout", -1),
        "options": kwargs.get("options", 0),
    }


def AttackCommand(unit_id: int, target_unit_id: int, **kwargs) -> dict:
    return {
        "type": "attack",
        "unit_id": unit_id,
        "target_unit_id": target_unit_id,
        "timeout": kwargs.get("timeout", -1),
        "options": kwargs.get("options", 0),
    }


def GuardCommand(unit_id: int, guard_unit_id: int, **kwargs) -> dict:
    return {
        "type": "guard",
        "unit_id": unit_id,
        "guard_unit_id": guard_unit_id,
        "timeout": kwargs.get("timeout", -1),
        "options": kwargs.get("options", 0),
    }


def StopCommand(unit_id: int, **kwargs) -> dict:
    return {
        "type": "stop",
        "unit_id": unit_id,
        "timeout": kwargs.get("timeout", -1),
        "options": kwargs.get("options", 0),
    }


def RepairCommand(unit_id: int, repair_unit_id: int, **kwargs) -> dict:
    return {
        "type": "repair",
        "unit_id": unit_id,
        "repair_unit_id": repair_unit_id,
        "timeout": kwargs.get("timeout", -1),
        "options": kwargs.get("options", 0),
    }


def FightCommand(unit_id: int, position: Position, **kwargs) -> dict:
    return {
        "type": "fight",
        "unit_id": unit_id,
        "to_position": {"x": position.x, "y": position.y, "z": position.z},
        "timeout": kwargs.get("timeout", -1),
        "options": kwargs.get("options", 0),
    }


def CustomCommand(unit_id: int, command_id: int,
                  params: Optional[list[float]] = None, **kwargs) -> dict:
    return {
        "type": "custom",
        "unit_id": unit_id,
        "command_id": command_id,
        "params": params or [],
        "timeout": kwargs.get("timeout", -1),
        "options": kwargs.get("options", 0),
    }


def SendTextMessageCommand(text: str, zone: int = 0) -> dict:
    return {
        "type": "send_text_message",
        "text": text,
        "zone": zone,
    }
