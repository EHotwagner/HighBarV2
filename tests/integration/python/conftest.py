"""Pytest fixtures for HighBar integration tests.

Provides a session-scoped engine fixture that launches and manages
the headless BAR engine for the duration of the test session.
"""

import os
import signal
import subprocess
import time
from pathlib import Path

import pytest

FIXTURES_DIR = Path(__file__).parent.parent.parent / "fixtures"
START_SCRIPT = FIXTURES_DIR / "start-headless.sh"
STOP_SCRIPT = FIXTURES_DIR / "stop-headless.sh"

DEFAULT_TIMEOUT = 30


@pytest.fixture(scope="session")
def engine_socket(tmp_path_factory):
    """Session-scoped fixture that starts the headless engine and yields the socket path.

    Launches start-headless.sh, waits for the socket to become available,
    runs all tests, then invokes stop-headless.sh for cleanup.
    """
    import uuid
    import socket as socket_mod

    socket_name = f"highbar-test-{uuid.uuid4().hex[:8]}.sock"
    socket_path = f"/tmp/{socket_name}"
    pid_file = f"{socket_path}.pid"

    timeout = int(os.environ.get("HIGHBAR_TEST_TIMEOUT", str(DEFAULT_TIMEOUT)))

    # Clean up stale socket
    if os.path.exists(socket_path):
        os.unlink(socket_path)

    # Launch engine
    env = os.environ.copy()
    env["HIGHBAR_SOCKET_PATH"] = socket_path

    result = subprocess.run(
        ["bash", str(START_SCRIPT), socket_path, pid_file],
        env=env,
        capture_output=True,
        text=True,
    )
    if result.returncode != 0:
        pytest.fail(f"start-headless.sh failed: {result.stderr}")

    # Wait for socket to become available
    deadline = time.monotonic() + timeout
    ready = False
    while time.monotonic() < deadline:
        if os.path.exists(socket_path):
            try:
                sock = socket_mod.socket(socket_mod.AF_UNIX, socket_mod.SOCK_STREAM)
                sock.connect(socket_path)
                sock.close()
                ready = True
                break
            except OSError:
                time.sleep(0.25)
        else:
            time.sleep(0.25)

    if not ready:
        pytest.fail(f"Engine socket not ready after {timeout}s at {socket_path}")

    yield socket_path

    # Teardown: stop the engine
    subprocess.run(
        ["bash", str(STOP_SCRIPT), socket_path, pid_file],
        capture_output=True,
        text=True,
        timeout=15,
    )

    # Final cleanup
    for f in [socket_path, pid_file]:
        if os.path.exists(f):
            os.unlink(f)
