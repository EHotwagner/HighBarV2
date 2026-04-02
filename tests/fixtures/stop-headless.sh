#!/usr/bin/env bash
# Stop a headless BAR engine instance.
# Usage: stop-headless.sh <socket_path> [pid_file]
#
# Reads PID file, sends SIGTERM, waits 5s, sends SIGKILL if needed,
# cleans up socket and PID files.

set -euo pipefail

SOCKET_PATH="${1:?Usage: stop-headless.sh <socket_path> [pid_file]}"
PID_FILE="${2:-${SOCKET_PATH}.pid}"

WAIT_SECONDS=5

if [ ! -f "${PID_FILE}" ]; then
    echo "No PID file found at ${PID_FILE}, nothing to stop"
    rm -f "${SOCKET_PATH}"
    exit 0
fi

ENGINE_PID="$(cat "${PID_FILE}")"

if ! kill -0 "${ENGINE_PID}" 2>/dev/null; then
    echo "Process ${ENGINE_PID} not running, cleaning up"
    rm -f "${PID_FILE}" "${SOCKET_PATH}"
    exit 0
fi

# Send SIGTERM for graceful shutdown
echo "Sending SIGTERM to engine PID ${ENGINE_PID}..."
kill -TERM "${ENGINE_PID}" 2>/dev/null || true

# Wait for process to exit
for i in $(seq 1 "${WAIT_SECONDS}"); do
    if ! kill -0 "${ENGINE_PID}" 2>/dev/null; then
        echo "Engine stopped gracefully after ${i}s"
        rm -f "${PID_FILE}" "${SOCKET_PATH}"
        exit 0
    fi
    sleep 1
done

# Force kill if still running
echo "Engine did not stop gracefully, sending SIGKILL..."
kill -KILL "${ENGINE_PID}" 2>/dev/null || true
sleep 1

rm -f "${PID_FILE}" "${SOCKET_PATH}"
echo "Engine force-killed and cleaned up"
