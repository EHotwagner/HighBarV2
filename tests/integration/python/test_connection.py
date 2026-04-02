"""Python connection and handshake integration tests.

Mirrors the F# ConnectionTests to validate cross-language protocol compatibility.
"""

import sys
from pathlib import Path

# Ensure the repo root is on the Python path for imports
REPO_ROOT = Path(__file__).parent.parent.parent.parent
sys.path.insert(0, str(REPO_ROOT))
sys.path.insert(0, str(REPO_ROOT / "clients" / "python"))

from highbar.client import HighBarClient
from highbar.events import InitEvent


def test_client_connects(engine_socket):
    """Test that the Python client connects to the engine proxy socket."""
    client = HighBarClient(engine_socket)
    client.connect()
    client.disconnect()


def test_handshake_returns_valid_metadata(engine_socket):
    """Test that handshake completes and returns valid protocol metadata."""
    client = HighBarClient(engine_socket)
    client.connect()
    info = client.handshake()

    assert "engine_version" in info
    assert len(info["engine_version"]) > 0, "Engine version should be non-empty"
    assert "map_name" in info
    assert len(info["map_name"]) > 0, "Map name should be non-empty"
    assert "team_id" in info
    assert info["team_id"] >= 0, f"Team ID should be >= 0, got {info['team_id']}"

    client.disconnect()


def test_first_frame_received(engine_socket):
    """Test that after handshake, the first frame is received with Init event."""
    client = HighBarClient(engine_socket)
    client.connect()
    client.handshake()

    frames_received = []

    @client.on_frame
    def handler(frame):
        frames_received.append(frame)
        if len(frames_received) >= 1:
            raise StopIteration("CAPTURED_ENOUGH")
        return []

    try:
        client.run()
    except StopIteration:
        pass

    assert len(frames_received) >= 1, "Should have received at least 1 frame"

    first = frames_received[0]
    has_init = any(isinstance(e, InitEvent) for e in first.events)
    assert has_init, "First frame should contain an Init event"

    client.disconnect()


def test_consecutive_frames_with_incrementing_numbers(engine_socket):
    """Test that empty responses work for consecutive frames with incrementing numbers."""
    client = HighBarClient(engine_socket)
    client.connect()
    client.handshake()

    frame_numbers = []

    @client.on_frame
    def handler(frame):
        frame_numbers.append(frame.frame_number)
        if len(frame_numbers) >= 3:
            raise StopIteration("CAPTURED_ENOUGH")
        return []

    try:
        client.run()
    except StopIteration:
        pass

    assert len(frame_numbers) >= 3, f"Should have 3+ frames, got {len(frame_numbers)}"
    for i in range(1, len(frame_numbers)):
        assert frame_numbers[i] > frame_numbers[i - 1], (
            f"Frame numbers should increment: {frame_numbers[i-1]} -> {frame_numbers[i]}"
        )

    client.disconnect()


def test_graceful_disconnect(engine_socket):
    """Test that disconnecting after receiving frames completes without error."""
    client = HighBarClient(engine_socket)
    client.connect()
    client.handshake()

    count = 0

    @client.on_frame
    def handler(frame):
        nonlocal count
        count += 1
        if count >= 3:
            raise StopIteration("CAPTURED_ENOUGH")
        return []

    try:
        client.run()
    except StopIteration:
        pass

    # Disconnect should complete without error
    client.disconnect()
    assert count >= 3
