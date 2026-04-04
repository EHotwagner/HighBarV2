#!/usr/bin/env bash
# Start a graphical BAR engine instance with the HighBarV2 proxy plugin.
# Usage: start-live.sh [socket_path]
#
# Launches the full graphical spring client with our AI vs NullAI.
# A minimal F# event logger connects to the socket and prints all events.

set -euo pipefail

SOCKET_PATH="${1:-/tmp/highbar-live-test.sock}"
SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
REPO_ROOT="$(cd "${SCRIPT_DIR}/../.." && pwd)"

ENGINE_BIN="${HIGHBAR_TEST_ENGINE:-/home/developer/.local/state/Beyond All Reason/engine/recoil_2025.06.19/spring}"
MAP_NAME="${HIGHBAR_TEST_MAP:-Comet Catcher Remake}"
SESSION_DIR="/tmp/highbar-live-session"

echo "=== HighBarV2 Live Engine Test ==="
echo "Engine:  ${ENGINE_BIN}"
echo "Map:     ${MAP_NAME}"
echo "Socket:  ${SOCKET_PATH}"
echo "Session: ${SESSION_DIR}"
echo ""

# Clean up
rm -f "${SOCKET_PATH}" "${SOCKET_PATH}.pid"
rm -rf "${SESSION_DIR}"
mkdir -p "${SESSION_DIR}"

# Install AI into graphical engine (in case it's not there)
GRAPHICAL_AI_DIR="$(dirname "${ENGINE_BIN}")/AI/Skirmish/HighBarV2/0.1"
if [ -d "$(dirname "${ENGINE_BIN}")/AI/Skirmish" ]; then
    mkdir -p "${GRAPHICAL_AI_DIR}"
    cp "${REPO_ROOT}/build/libSkirmishAI.so" "${GRAPHICAL_AI_DIR}/"
    cp "${REPO_ROOT}/proxy/data/AIInfo.lua" "${GRAPHICAL_AI_DIR}/"
    cp "${REPO_ROOT}/proxy/data/AIOptions.lua" "${GRAPHICAL_AI_DIR}/"
    echo "Installed AI to: ${GRAPHICAL_AI_DIR}"
fi

# Also install to ~/.spring for headless
mkdir -p "${HOME}/.spring/AI/Skirmish/HighBarV2/0.1"
cp "${REPO_ROOT}/build/libSkirmishAI.so" "${HOME}/.spring/AI/Skirmish/HighBarV2/0.1/"
cp "${REPO_ROOT}/proxy/data/AIInfo.lua" "${HOME}/.spring/AI/Skirmish/HighBarV2/0.1/"
cp "${REPO_ROOT}/proxy/data/AIOptions.lua" "${HOME}/.spring/AI/Skirmish/HighBarV2/0.1/"

# Generate start script
STARTSCRIPT="${SESSION_DIR}/script.txt"
sed -e "s|__SOCKET_PATH__|${SOCKET_PATH}|g" \
    -e "s|__MAP_NAME__|${MAP_NAME}|g" \
    "${SCRIPT_DIR}/game-setup.txt" > "${STARTSCRIPT}"

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
echo "Engine PID: ${ENGINE_PID}"
echo ""
echo "Press Ctrl+C to stop. Check ${SESSION_DIR}/infolog.txt for event topics."
echo ""

# Wait for engine to exit
wait ${ENGINE_PID} 2>/dev/null || true
echo ""
echo "Engine exited."
echo ""

# Show event topic distribution from logs
if [ -f "${SESSION_DIR}/infolog.txt" ]; then
    echo "=== Event Topic Distribution ==="
    grep "Event topics" "${SESSION_DIR}/infolog.txt" | tail -10
    echo ""
    echo "=== Key: Topic IDs ==="
    echo "  1=Init 3=Update 5=UnitCreated 6=UnitFinished 7=UnitIdle"
    echo "  9=UnitDamaged 10=UnitDestroyed 13=EnemyEnterLOS 14=EnemyLeaveLOS"
    echo "  17=EnemyDamaged 18=EnemyDestroyed 19=WeaponFired"
    echo "  25=EnemyCreated 26=EnemyFinished"
fi
