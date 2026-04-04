#!/usr/bin/env bash
# Automated content provisioning for HighBarV2 integration tests.
# Usage: setup-engine.sh
#
# Reads tests/engine-version.json and downloads missing components:
#   - Engine binary (from GitHub releases)
#   - Game archive (via pr-downloader)
#   - Map (prints download instructions — maps are hosted externally)

set -euo pipefail

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
CONFIG_FILE="${SCRIPT_DIR}/engine-version.json"

# Verify config file exists
if [ ! -f "${CONFIG_FILE}" ]; then
    echo "ERROR: ${CONFIG_FILE} not found" >&2
    exit 2
fi

# Verify jq is available
if ! command -v jq &>/dev/null; then
    echo "ERROR: jq is required but not found. Install with: apt install jq" >&2
    exit 2
fi

# Read config
ENGINE_BINARY=$(jq -r '.engine.binary' "${CONFIG_FILE}")
ENGINE_VERSION=$(jq -r '.engine.version' "${CONFIG_FILE}")
DOWNLOAD_URL=$(jq -r '.engine.downloadUrl' "${CONFIG_FILE}")
GAME_NAME=$(jq -r '.game.name' "${CONFIG_FILE}")
RAPID_TAG=$(jq -r '.game.rapidTag' "${CONFIG_FILE}")
MAP_NAME=$(jq -r '.map.name' "${CONFIG_FILE}")

# Determine data directory — auto-detect from engine binary location if not set
DATA_DIR="${SPRING_DATADIR:-}"
if [ -z "${DATA_DIR}" ]; then
    _ENGINE_PATH="${HIGHBAR_TEST_ENGINE:-$(command -v "${ENGINE_BINARY}" 2>/dev/null || true)}"
    if [ -n "${_ENGINE_PATH}" ] && [ -x "${_ENGINE_PATH}" ]; then
        _ENGINE_DIR="$(dirname "$(readlink -f "${_ENGINE_PATH}")")"
        _CANDIDATE="$(dirname "$(dirname "${_ENGINE_DIR}")")"
        if [ -d "${_CANDIDATE}/maps" ] && [ -d "${_CANDIDATE}/packages" ]; then
            DATA_DIR="${_CANDIDATE}"
        fi
    fi
    DATA_DIR="${DATA_DIR:-${HOME}/.spring}"
fi
ACTIONS_TAKEN=0

echo "=== HighBarV2 Engine Setup ==="
echo "Config: ${CONFIG_FILE}"
echo "Data directory: ${DATA_DIR}"
echo ""

# 1. Check engine binary
echo "--- Engine Binary ---"
ENGINE_PATH="${HIGHBAR_TEST_ENGINE:-}"
if [ -n "${ENGINE_PATH}" ] && [ -x "${ENGINE_PATH}" ]; then
    echo "[✓] Engine found at ${ENGINE_PATH} (via HIGHBAR_TEST_ENGINE)"
elif command -v "${ENGINE_BINARY}" &>/dev/null; then
    echo "[✓] Engine found at $(command -v "${ENGINE_BINARY}")"
else
    echo "[✗] Engine binary '${ENGINE_BINARY}' not found"
    echo "    Please download from: ${DOWNLOAD_URL}"
    echo "    Expected version: ${ENGINE_VERSION}"
    echo "    Install to a directory on your PATH, or set HIGHBAR_TEST_ENGINE=/path/to/${ENGINE_BINARY}"
    echo ""
    ACTIONS_TAKEN=$((ACTIONS_TAKEN + 1))
fi

# 2. Check game archive
echo ""
echo "--- Game Archive ---"
GAME_FOUND=false
for search_dir in "${DATA_DIR}/games" "${DATA_DIR}/packages"; do
    if [ -d "${search_dir}" ]; then
        if find "${search_dir}" -maxdepth 2 -name "*${GAME_NAME}*" 2>/dev/null | grep -q .; then
            GAME_FOUND=true
            break
        fi
    fi
done

if ${GAME_FOUND}; then
    echo "[✓] Game archive '${GAME_NAME}' found"
else
    echo "[✗] Game archive '${GAME_NAME}' not found"
    if command -v pr-downloader &>/dev/null; then
        echo "    Downloading via pr-downloader..."
        if pr-downloader --download-game "${RAPID_TAG}"; then
            echo "    [✓] Game archive downloaded successfully"
        else
            echo "    [✗] pr-downloader failed. Try manually: pr-downloader --download-game '${RAPID_TAG}'"
        fi
    else
        echo "    pr-downloader not found. Install it, then run:"
        echo "    pr-downloader --download-game '${RAPID_TAG}'"
    fi
    ACTIONS_TAKEN=$((ACTIONS_TAKEN + 1))
fi

# 3. Check map
echo ""
echo "--- Map ---"
MAP_DIR="${DATA_DIR}/maps"
MAP_FOUND=false
if [ -d "${MAP_DIR}" ]; then
    if find "${MAP_DIR}" -maxdepth 1 -iname "*$(echo "${MAP_NAME}" | tr ' ' '*')*" 2>/dev/null | grep -q .; then
        MAP_FOUND=true
    fi
fi

if ${MAP_FOUND}; then
    echo "[✓] Map '${MAP_NAME}' found"
else
    echo "[✗] Map '${MAP_NAME}' not found"
    echo "    Maps are hosted externally (Google Drive) and must be downloaded manually."
    echo "    Download '${MAP_NAME}' and place it in: ${MAP_DIR}/"
    mkdir -p "${MAP_DIR}"
    ACTIONS_TAKEN=$((ACTIONS_TAKEN + 1))
fi

# Summary
echo ""
echo "=== Summary ==="
if [ ${ACTIONS_TAKEN} -eq 0 ]; then
    echo "All components are present. Ready to run tests!"
    echo ""
    echo "  dotnet test tests/integration/fsharp/"
else
    echo "${ACTIONS_TAKEN} component(s) need attention. See above for details."
    echo "After resolving, run: ./tests/check-prerequisites.sh"
fi
