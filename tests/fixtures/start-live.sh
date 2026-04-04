#!/usr/bin/env bash
# Start a graphical BAR engine instance with the HighBarV2 proxy plugin.
# Usage: start-live.sh [socket_path] [pid_file] [session_dir]
#
# Launches the full graphical spring client with our AI vs NullAI.

set -euo pipefail

SOCKET_PATH="${1:-/tmp/highbar-live-test.sock}"
PID_FILE="${2:-${SOCKET_PATH}.pid}"
SESSION_DIR="${3:-/tmp/highbar-live-session}"

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
REPO_ROOT="$(cd "${SCRIPT_DIR}/../.." && pwd)"
TESTS_DIR="$(cd "${SCRIPT_DIR}/.." && pwd)"
ENGINE_VERSION_FILE="${TESTS_DIR}/engine-version.json"

# Auto-detect graphical engine binary (spring, not spring-headless)
if [ -n "${HIGHBAR_TEST_ENGINE:-}" ]; then
    # If headless was specified, try to find the graphical counterpart
    ENGINE_BIN="${HIGHBAR_TEST_ENGINE/spring-headless/spring}"
    [ ! -x "$ENGINE_BIN" ] && ENGINE_BIN="${HIGHBAR_TEST_ENGINE}"
else
    # Search standard BAR AppImage locations for graphical spring
    ENGINE_BIN=""
    for candidate in \
        "${HOME}/.local/state/Beyond All Reason/engine"/*/spring; do
        if [ -x "$candidate" ] && [[ "$candidate" != *"spring-headless"* ]]; then
            ENGINE_BIN="$candidate"
            break
        fi
    done
    [ -z "$ENGINE_BIN" ] && ENGINE_BIN="spring"
fi

# Read config from engine-version.json
if [ -f "${ENGINE_VERSION_FILE}" ] && command -v jq &>/dev/null; then
    MAP_NAME="${HIGHBAR_TEST_MAP:-$(jq -r '.map.name' "${ENGINE_VERSION_FILE}")}"
    GAME_TYPE="$(jq -r '.game.name' "${ENGINE_VERSION_FILE}")"
else
    MAP_NAME="${HIGHBAR_TEST_MAP:-Red Rock Desert v2}"
    GAME_TYPE="Beyond All Reason test-29840-d9b7dba"
fi
STARTSCRIPT_TEMPLATE="${HIGHBAR_GAME_SETUP:-${SCRIPT_DIR}/game-setup-live.txt}"

# Auto-detect SPRING_DATADIR from the engine binary location if not set.
if [ -z "${SPRING_DATADIR:-}" ]; then
    ENGINE_DIR="$(dirname "$(readlink -f "${ENGINE_BIN}")")"
    CANDIDATE="$(dirname "$(dirname "${ENGINE_DIR}")")"
    if [ -d "${CANDIDATE}/maps" ] && [ -d "${CANDIDATE}/packages" ]; then
        export SPRING_DATADIR="${CANDIDATE}"
    fi
fi

echo "=== HighBarV2 Live Engine Test ==="
echo "Engine:  ${ENGINE_BIN}"
echo "Map:     ${MAP_NAME}"
echo "Game:    ${GAME_TYPE}"
echo "Socket:  ${SOCKET_PATH}"
echo "Session: ${SESSION_DIR}"
echo ""

# Clean up (don't remove socket — the AI client may already be listening on it)
rm -f "${PID_FILE}"
rm -rf "${SESSION_DIR}"
mkdir -p "${SESSION_DIR}"

# Copy archive cache for fast startup
if [ -n "${SPRING_DATADIR:-}" ] && [ -f "${SPRING_DATADIR}/cache/ArchiveCache20.lua" ]; then
    mkdir -p "${SESSION_DIR}/cache"
    cp "${SPRING_DATADIR}/cache/ArchiveCache20.lua" "${SESSION_DIR}/cache/"
fi

# Install AI into engine's AI directory
GRAPHICAL_AI_DIR="$(dirname "$(readlink -f "${ENGINE_BIN}")")/AI/Skirmish/HighBarV2/stable"
if [ -d "$(dirname "$(readlink -f "${ENGINE_BIN}")")/AI/Skirmish" ] && [ -f "${REPO_ROOT}/build/libSkirmishAI.so" ]; then
    mkdir -p "${GRAPHICAL_AI_DIR}"
    cp "${REPO_ROOT}/build/libSkirmishAI.so" "${GRAPHICAL_AI_DIR}/"
    cp "${REPO_ROOT}/proxy/data/AIInfo.lua" "${GRAPHICAL_AI_DIR}/"
    cp "${REPO_ROOT}/proxy/data/AIOptions.lua" "${GRAPHICAL_AI_DIR}/"
    echo "Installed AI to: ${GRAPHICAL_AI_DIR}"
fi

# Generate start script with all template variables substituted
STARTSCRIPT="${SESSION_DIR}/script.txt"
sed -e "s|__SOCKET_PATH__|${SOCKET_PATH}|g" \
    -e "s|__MAP_NAME__|${MAP_NAME}|g" \
    -e "s|__GAME_TYPE__|${GAME_TYPE}|g" \
    "${STARTSCRIPT_TEMPLATE}" > "${STARTSCRIPT}"

export HIGHBAR_SOCKET_PATH="${SOCKET_PATH}"
export SPRING_WRITEDIR="${SESSION_DIR}"
export DISPLAY="${DISPLAY:-:0}"

echo ""
echo "Starting engine..."
echo "Logs will be at: ${SESSION_DIR}/infolog.txt"
echo ""

# Launch the engine
"${ENGINE_BIN}" "${STARTSCRIPT}" \
    >"${SESSION_DIR}/engine-stdout.log" \
    2>"${SESSION_DIR}/engine-stderr.log" &

ENGINE_PID=$!
echo "${ENGINE_PID}" > "${PID_FILE}"
echo "Engine PID: ${ENGINE_PID}"
echo ""
echo "Press Ctrl+C to stop."
echo ""

# Wait for engine to exit
wait ${ENGINE_PID} 2>/dev/null || true
echo ""
echo "Engine exited."
