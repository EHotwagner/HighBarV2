#!/usr/bin/env bash
# Start a headless BAR engine instance with the HighBarV2 proxy plugin.
# Usage: start-headless.sh <socket_path> [pid_file]
#
# The script launches spring-headless with a minimal game scenario,
# writes the PID to a file, and exits immediately.

set -euo pipefail

SOCKET_PATH="${1:?Usage: start-headless.sh <socket_path> [pid_file]}"
PID_FILE="${2:-${SOCKET_PATH}.pid}"

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
STARTSCRIPT="${SCRIPT_DIR}/game-setup.lua"

ENGINE_BIN="${HIGHBAR_TEST_ENGINE:-spring-headless}"
LOG_LEVEL="${HIGHBAR_LOG_LEVEL:-3}"

# Export socket path for the AI plugin (read via AIOptions or env var)
export HIGHBAR_SOCKET_PATH="${SOCKET_PATH}"

# Remove stale socket if no process holds it
if [ -e "${SOCKET_PATH}" ]; then
    if [ -f "${PID_FILE}" ] && kill -0 "$(cat "${PID_FILE}")" 2>/dev/null; then
        echo "ERROR: Engine already running (PID $(cat "${PID_FILE}"))" >&2
        exit 1
    fi
    rm -f "${SOCKET_PATH}"
fi

# Launch the engine in the background
"${ENGINE_BIN}" \
    --headless \
    "${STARTSCRIPT}" \
    &

ENGINE_PID=$!
echo "${ENGINE_PID}" > "${PID_FILE}"
echo "Engine started with PID ${ENGINE_PID}, socket: ${SOCKET_PATH}"
