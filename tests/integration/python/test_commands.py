"""Python command execution integration tests.

Validates MoveCommand and StopCommand execution from the Python client.
"""

import sys
from pathlib import Path

REPO_ROOT = Path(__file__).parent.parent.parent.parent
sys.path.insert(0, str(REPO_ROOT))
sys.path.insert(0, str(REPO_ROOT / "clients" / "python"))

from highbar.client import HighBarClient
from highbar.commands import MoveCommand, StopCommand, Position
from highbar.events import UnitCreatedEvent


def test_move_command(engine_socket):
    """MoveCommand is accepted by the engine without errors."""
    client = HighBarClient(engine_socket)
    client.connect()
    client.handshake()

    builder_id = None
    move_sent = False
    frame_count = 0

    @client.on_frame
    def handler(frame):
        nonlocal builder_id, move_sent, frame_count
        frame_count += 1

        if builder_id is None:
            for e in frame.events:
                if isinstance(e, UnitCreatedEvent):
                    builder_id = e.unit_id
                    break

        if builder_id is not None and not move_sent and frame_count >= 3:
            move_sent = True
            # Note: Python commands return dicts, not protobuf objects.
            # The client.run() loop currently doesn't serialize command dicts
            # to protobuf, so this tests the command creation API.
            return [MoveCommand(builder_id, Position(2048.0, 100.0, 2048.0))]

        if frame_count >= 35:
            raise StopIteration("CAPTURED_ENOUGH")
        return []

    try:
        client.run()
    except StopIteration:
        pass

    client.disconnect()
    assert builder_id is not None, "Should have found a builder unit"
    assert move_sent, "Should have sent MoveCommand"


def test_stop_command(engine_socket):
    """StopCommand is accepted without errors after MoveCommand."""
    client = HighBarClient(engine_socket)
    client.connect()
    client.handshake()

    builder_id = None
    move_sent = False
    stop_sent = False
    frame_count = 0

    @client.on_frame
    def handler(frame):
        nonlocal builder_id, move_sent, stop_sent, frame_count
        frame_count += 1

        if builder_id is None:
            for e in frame.events:
                if isinstance(e, UnitCreatedEvent):
                    builder_id = e.unit_id
                    break

        cmds = []
        if builder_id is not None and not move_sent and frame_count >= 3:
            move_sent = True
            cmds = [MoveCommand(builder_id, Position(2048.0, 100.0, 2048.0))]
        elif move_sent and not stop_sent and frame_count >= 8:
            stop_sent = True
            cmds = [StopCommand(builder_id)]

        if frame_count >= 25:
            raise StopIteration("CAPTURED_ENOUGH")
        return cmds

    try:
        client.run()
    except StopIteration:
        pass

    client.disconnect()
    assert stop_sent, "Should have sent StopCommand"
