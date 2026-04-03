#!/usr/bin/env bash
# Start a headless BAR engine instance with the HighBarV2 proxy plugin.
# Usage: start-headless.sh <socket_path> [pid_file] [session_dir]
#
# The script launches spring-headless with a minimal game scenario,
# writes the PID to a file, and exits immediately.
# If session_dir is provided, engine stdout/stderr are redirected to log
# files in that directory and --write-dir is passed to the engine.

set -euo pipefail

SOCKET_PATH="${1:?Usage: start-headless.sh <socket_path> [pid_file] [session_dir]}"
PID_FILE="${2:-${SOCKET_PATH}.pid}"
SESSION_DIR="${3:-}"

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

# Build engine arguments
ENGINE_ARGS=( --headless )

if [ -n "${SESSION_DIR}" ]; then
    mkdir -p "${SESSION_DIR}"
    ENGINE_ARGS+=( --write-dir "${SESSION_DIR}" )
fi

ENGINE_ARGS+=( "${STARTSCRIPT}" )

# Launch the engine in the background
if [ -n "${SESSION_DIR}" ]; then
    "${ENGINE_BIN}" "${ENGINE_ARGS[@]}" \
        >"${SESSION_DIR}/engine-stdout.log" \
        2>"${SESSION_DIR}/engine-stderr.log" \
        &
else
    "${ENGINE_BIN}" "${ENGINE_ARGS[@]}" &
fi

ENGINE_PID=$!
echo "${ENGINE_PID}" > "${PID_FILE}"
echo "Engine started with PID ${ENGINE_PID}, socket: ${SOCKET_PATH}"
