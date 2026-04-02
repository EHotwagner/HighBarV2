"""Python event delivery integration tests.

Validates that engine events arrive correctly in the Python client.
"""

import sys
from pathlib import Path

REPO_ROOT = Path(__file__).parent.parent.parent.parent
sys.path.insert(0, str(REPO_ROOT))
sys.path.insert(0, str(REPO_ROOT / "clients" / "python"))

from highbar.client import HighBarClient
from highbar.events import (
    InitEvent,
    UpdateEvent,
    UnitCreatedEvent,
    UnitIdleEvent,
    UnknownEvent,
)


def _collect_events(engine_socket, max_frames):
    """Helper: connect, handshake, collect events for N frames."""
    client = HighBarClient(engine_socket)
    client.connect()
    client.handshake()

    all_frames = []
    all_events = []

    @client.on_frame
    def handler(frame):
        all_frames.append(frame)
        all_events.extend(frame.events)
        if len(all_frames) >= max_frames:
            raise StopIteration("CAPTURED_ENOUGH")
        return []

    try:
        client.run()
    except StopIteration:
        pass

    client.disconnect()
    return all_frames, all_events


def test_init_event_received(engine_socket):
    """Init event received with valid team ID."""
    _, events = _collect_events(engine_socket, 1)

    init_events = [e for e in events if isinstance(e, InitEvent)]
    assert len(init_events) >= 1, "Should receive at least one Init event"
    assert init_events[0].team_id >= 0, f"Init teamId should be >= 0"


def test_update_events_received(engine_socket):
    """Update events received with frame numbers."""
    frames, _ = _collect_events(engine_socket, 5)

    assert len(frames) >= 5
    for frame in frames:
        update_events = [e for e in frame.events if isinstance(e, UpdateEvent)]
        if frame.frame_number > 0:
            assert len(update_events) >= 1, (
                f"Frame {frame.frame_number} should have an Update event"
            )


def test_unit_created_event(engine_socket):
    """UnitCreated event received for builder unit."""
    _, events = _collect_events(engine_socket, 10)

    created = [e for e in events if isinstance(e, UnitCreatedEvent)]
    assert len(created) >= 1, "Should receive at least one UnitCreated event"
    assert created[0].unit_id > 0, f"Unit ID should be > 0"
