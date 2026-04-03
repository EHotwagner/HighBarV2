"""Pytest fixtures for HighBar integration tests.

Provides a session-scoped engine fixture that launches and manages
the headless BAR engine for the duration of the test session.
"""

import json
import os
import signal
import subprocess
import time
from pathlib import Path

import pytest

TESTS_DIR = Path(__file__).parent.parent.parent
FIXTURES_DIR = TESTS_DIR / "fixtures"
START_SCRIPT = FIXTURES_DIR / "start-headless.sh"
STOP_SCRIPT = FIXTURES_DIR / "stop-headless.sh"
CHECK_PREREQ_SCRIPT = TESTS_DIR / "check-prerequisites.sh"

DEFAULT_TIMEOUT = 30


def _check_prerequisites():
    """Run prerequisites check and skip tests if not met."""
    result = subprocess.run(
        ["bash", str(CHECK_PREREQ_SCRIPT), "--json"],
        capture_output=True,
        text=True,
    )
    if result.returncode == 2:
        pytest.fail(f"Prerequisites check script error: {result.stderr}{result.stdout}")
    elif result.returncode != 0:
        pytest.skip(f"Prerequisites not met — skipping live engine tests.\n{result.stdout}")


def _read_log_tail(path, max_lines=50):
    """Read the last max_lines from a log file."""
    if not os.path.exists(path):
        return None
    with open(path) as f:
        lines = f.readlines()
    tail = lines[-max_lines:]
    return "".join(tail)


def _get_diagnostic_logs(session_dir, socket_path, engine_pid):
    """Collect diagnostic logs from the session directory."""
    output = f"Session directory: {session_dir}\nSocket: {socket_path}\n"
    if engine_pid:
        output += f"Engine PID: {engine_pid}\n"

    for log_file in ["engine-stdout.log", "engine-stderr.log", "infolog.txt"]:
        path = os.path.join(session_dir, log_file)
        tail = _read_log_tail(path)
        if tail is not None:
            lines_count = tail.count("\n")
            output += f"\n--- {log_file} (last {lines_count} lines) ---\n{tail}"

    return output


def _is_engine_alive(pid):
    """Check if the engine process is still running."""
    if pid is None:
        return False
    try:
        os.kill(pid, 0)
        return True
    except (OSError, ProcessLookupError):
        return False


def _check_engine_alive(pid, session_dir, socket_path):
    """Raise with diagnostic info if engine has crashed."""
    if not _is_engine_alive(pid):
        diag = f"Engine process (PID {pid}) has exited unexpectedly.\n"
        diag += _get_diagnostic_logs(session_dir, socket_path, pid)
        raise RuntimeError(diag)


@pytest.fixture(scope="session")
def engine_socket(tmp_path_factory):
    """Session-scoped fixture that starts the headless engine and yields the socket path.

    Launches start-headless.sh, waits for the socket to become available,
    runs all tests, then invokes stop-headless.sh for cleanup.
    """
    import uuid
    import socket as socket_mod

    # Check prerequisites before attempting engine launch
    _check_prerequisites()

    socket_name = f"highbar-test-{uuid.uuid4().hex[:8]}.sock"
    socket_path = f"/tmp/{socket_name}"
    pid_file = f"{socket_path}.pid"

    # Create per-session temp directory
    session_dir = str(tmp_path_factory.mktemp("highbar-session"))

    timeout = int(os.environ.get("HIGHBAR_TEST_TIMEOUT", str(DEFAULT_TIMEOUT)))

    # Clean up stale socket
    if os.path.exists(socket_path):
        os.unlink(socket_path)

    # Launch engine with session directory
    env = os.environ.copy()
    env["HIGHBAR_SOCKET_PATH"] = socket_path

    result = subprocess.run(
        ["bash", str(START_SCRIPT), socket_path, pid_file, session_dir],
        env=env,
        capture_output=True,
        text=True,
    )
    if result.returncode != 0:
        pytest.fail(f"start-headless.sh failed: {result.stderr}")

    # Read engine PID
    engine_pid = None
    if os.path.exists(pid_file):
        engine_pid = int(Path(pid_file).read_text().strip())

    # Wait for socket to become available
    deadline = time.monotonic() + timeout
    ready = False
    while time.monotonic() < deadline:
        # Check engine hasn't crashed during startup
        if not _is_engine_alive(engine_pid):
            diag = _get_diagnostic_logs(session_dir, socket_path, engine_pid)
            pytest.fail(f"Engine crashed during startup.\n{diag}")

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
        diag = _get_diagnostic_logs(session_dir, socket_path, engine_pid)
        pytest.fail(f"Engine socket not ready after {timeout}s at {socket_path}\n{diag}")

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


@pytest.fixture(scope="session")
def engine_session_dir(engine_socket, tmp_path_factory):
    """Expose the session directory path for diagnostics."""
    # The session dir was created by engine_socket; find it from tmp_path_factory
    # This is a convenience fixture for tests that need diagnostic access
    basetemp = tmp_path_factory.getbasetemp()
    session_dirs = list(basetemp.glob("highbar-session*"))
    if session_dirs:
        return str(session_dirs[0])
    return None


@pytest.fixture(autouse=True)
def _check_engine_before_test(engine_socket, request):
    """Auto-use fixture that verifies engine is alive before each test."""
    # Read PID from the pid file
    pid_file = f"{engine_socket}.pid"
    if os.path.exists(pid_file):
        pid = int(Path(pid_file).read_text().strip())
        # Find session dir
        basetemp = request.config._tmp_path_factory.getbasetemp()
        session_dirs = list(basetemp.glob("highbar-session*"))
        session_dir = str(session_dirs[0]) if session_dirs else ""
        _check_engine_alive(pid, session_dir, engine_socket)
