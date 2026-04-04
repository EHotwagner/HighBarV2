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

# Read defaults from engine-version.json if available
TESTS_DIR="$(cd "${SCRIPT_DIR}/.." && pwd)"
ENGINE_VERSION_FILE="${TESTS_DIR}/engine-version.json"
if [ -f "${ENGINE_VERSION_FILE}" ] && command -v jq &>/dev/null; then
    MAP_NAME="${HIGHBAR_TEST_MAP:-$(jq -r '.map.name' "${ENGINE_VERSION_FILE}")}"
    GAME_TYPE="$(jq -r '.game.name' "${ENGINE_VERSION_FILE}")"
else
    MAP_NAME="${HIGHBAR_TEST_MAP:-Red Rock Desert v2}"
    GAME_TYPE="Beyond All Reason test-29840-d9b7dba"
fi

# Auto-detect SPRING_DATADIR from the engine binary location if not set.
# The BAR AppImage stores game content in the engine's grandparent directory.
if [ -z "${SPRING_DATADIR:-}" ]; then
    ENGINE_DIR="$(dirname "$(readlink -f "${ENGINE_BIN}")")"
    CANDIDATE="$(dirname "$(dirname "${ENGINE_DIR}")")"
    if [ -d "${CANDIDATE}/maps" ] && [ -d "${CANDIDATE}/packages" ]; then
        export SPRING_DATADIR="${CANDIDATE}"
    fi
fi

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

# Copy the archive cache from SPRING_DATADIR (or the engine's data dir) so the
# engine can resolve map/game names without a full re-scan.
if [ -n "${SPRING_DATADIR:-}" ] && [ -f "${SPRING_DATADIR}/cache/ArchiveCache20.lua" ]; then
    mkdir -p "${INSTANCE_DIR}/cache"
    cp "${SPRING_DATADIR}/cache/ArchiveCache20.lua" "${INSTANCE_DIR}/cache/"
fi

# Generate per-run start script with socket path and map name substituted
STARTSCRIPT="${INSTANCE_DIR}/script.txt"
sed -e "s|__SOCKET_PATH__|${SOCKET_PATH}|g" \
    -e "s|__MAP_NAME__|${MAP_NAME}|g" \
    -e "s|__GAME_TYPE__|${GAME_TYPE}|g" \
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
