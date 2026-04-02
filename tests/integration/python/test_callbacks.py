"""Python callback query integration tests.

Validates that the game state is accessible without errors.
"""

import sys
from pathlib import Path

REPO_ROOT = Path(__file__).parent.parent.parent.parent
sys.path.insert(0, str(REPO_ROOT))
sys.path.insert(0, str(REPO_ROOT / "clients" / "python"))

from highbar.client import HighBarClient
from highbar.events import UnitCreatedEvent, UpdateEvent


def test_unit_ids_valid(engine_socket):
    """Unit IDs from UnitCreated events are valid positive integers."""
    client = HighBarClient(engine_socket)
    client.connect()
    client.handshake()

    unit_ids = []
    frame_count = 0

    @client.on_frame
    def handler(frame):
        nonlocal frame_count
        frame_count += 1
        for e in frame.events:
            if isinstance(e, UnitCreatedEvent):
                unit_ids.append(e.unit_id)
        if frame_count >= 15:
            raise StopIteration("CAPTURED_ENOUGH")
        return []

    try:
        client.run()
    except StopIteration:
        pass

    client.disconnect()
    assert len(unit_ids) > 0, "Should have received UnitCreated events"
    for uid in unit_ids:
        assert uid > 0, f"Unit ID should be > 0, got {uid}"


def test_frame_numbers_consistent(engine_socket):
    """Frame numbers in Update events are consistent with frame message numbers."""
    client = HighBarClient(engine_socket)
    client.connect()
    client.handshake()

    frames = []
    frame_count = 0

    @client.on_frame
    def handler(frame):
        nonlocal frame_count
        frame_count += 1
        frames.append(frame)
        if frame_count >= 10:
            raise StopIteration("CAPTURED_ENOUGH")
        return []

    try:
        client.run()
    except StopIteration:
        pass

    client.disconnect()
    assert len(frames) >= 10

    for frame in frames:
        update_events = [e for e in frame.events if isinstance(e, UpdateEvent)]
        for ue in update_events:
            assert ue.frame <= frame.frame_number + 1, (
                f"Update frame {ue.frame} should be <= message frame {frame.frame_number} + 1"
            )
