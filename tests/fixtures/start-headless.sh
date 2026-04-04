#!/usr/bin/env bash
# Start a dedicated BAR engine instance with the HighBarV2 proxy plugin.
# Usage: start-headless.sh <socket_path> [pid_file] [session_dir]
#
# The script launches spring-dedicated with a minimal game scenario,
# writes the PID to a file, and exits immediately.
# If session_dir is provided, engine stdout/stderr are redirected to log
# files in that directory.

set -euo pipefail

SOCKET_PATH="${1:?Usage: start-headless.sh <socket_path> [pid_file] [session_dir]}"
PID_FILE="${2:-${SOCKET_PATH}.pid}"
SESSION_DIR="${3:-}"

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
STARTSCRIPT_TEMPLATE="${HIGHBAR_GAME_SETUP:-${SCRIPT_DIR}/game-setup.txt}"

ENGINE_BIN="${HIGHBAR_TEST_ENGINE:-spring-headless}"
MAP_NAME="${HIGHBAR_TEST_MAP:-Comet Catcher Remake}"

# Export socket path for the AI plugin (read via AIOptions or env var)
export HIGHBAR_SOCKET_PATH="${SOCKET_PATH}"

# Check if engine is already running
if [ -f "${PID_FILE}" ] && kill -0 "$(cat "${PID_FILE}")" 2>/dev/null; then
    echo "ERROR: Engine already running (PID $(cat "${PID_FILE}"))" >&2
    exit 1
fi

# Set up the instance directory (engine write dir)
if [ -n "${SESSION_DIR}" ]; then
    INSTANCE_DIR="${SESSION_DIR}"
else
    INSTANCE_DIR=$(mktemp -d /tmp/highbar-instance-XXXXXX)
fi
mkdir -p "${INSTANCE_DIR}"

# Generate per-run start script with socket path and map name substituted
STARTSCRIPT="${INSTANCE_DIR}/script.txt"
sed -e "s|__SOCKET_PATH__|${SOCKET_PATH}|g" \
    -e "s|__MAP_NAME__|${MAP_NAME}|g" \
    "${STARTSCRIPT_TEMPLATE}" > "${STARTSCRIPT}"

# Set SPRING_WRITEDIR so engine writes logs to instance dir
export SPRING_WRITEDIR="${INSTANCE_DIR}"

# Launch the engine in the background
if [ -n "${SESSION_DIR}" ]; then
    "${ENGINE_BIN}" \
        "${STARTSCRIPT}" \
        >"${SESSION_DIR}/engine-stdout.log" \
        2>"${SESSION_DIR}/engine-stderr.log" \
        &
else
    "${ENGINE_BIN}" \
        "${STARTSCRIPT}" \
        &
fi

ENGINE_PID=$!
echo "${ENGINE_PID}" > "${PID_FILE}"
echo "Engine started with PID ${ENGINE_PID}, socket: ${SOCKET_PATH}"
