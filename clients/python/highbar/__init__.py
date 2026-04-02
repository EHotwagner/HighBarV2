"""HighBar V2 client library for AI development."""

from highbar.client import HighBarClient
from highbar.events import GameEvent, parse_event
from highbar.commands import (
    MoveCommand,
    BuildCommand,
    PatrolCommand,
    AttackCommand,
    GuardCommand,
    StopCommand,
    RepairCommand,
    FightCommand,
    CustomCommand,
    SendTextMessageCommand,
)

__all__ = [
    "HighBarClient",
    "GameEvent",
    "parse_event",
    "MoveCommand",
    "BuildCommand",
    "PatrolCommand",
    "AttackCommand",
    "GuardCommand",
    "StopCommand",
    "RepairCommand",
    "FightCommand",
    "CustomCommand",
    "SendTextMessageCommand",
]
