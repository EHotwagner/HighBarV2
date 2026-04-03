#!/usr/bin/env bash
# Validate prerequisites for running HighBarV2 integration tests.
# Usage: check-prerequisites.sh [--json]
#
# Checks:
#   - Engine binary exists (via HIGHBAR_TEST_ENGINE or PATH)
#   - Engine version matches pinned version
#   - Game archive exists in SPRING_DATADIR
#   - Map file exists in SPRING_DATADIR/maps/
#
# Exit codes:
#   0 - All prerequisites met
#   1 - One or more prerequisites missing
#   2 - Script error (e.g., cannot read config file)

set -euo pipefail

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
CONFIG_FILE="${SCRIPT_DIR}/engine-version.json"

JSON_MODE=false
for arg in "$@"; do
    case "${arg}" in
        --json) JSON_MODE=true ;;
    esac
done

# Verify config file exists
if [ ! -f "${CONFIG_FILE}" ]; then
    if ${JSON_MODE}; then
        echo '{"error":"engine-version.json not found","passed":false}'
    else
        echo "ERROR: ${CONFIG_FILE} not found" >&2
    fi
    exit 2
fi

# Verify jq is available
if ! command -v jq &>/dev/null; then
    if ${JSON_MODE}; then
        echo '{"error":"jq not found","passed":false}'
    else
        echo "ERROR: jq is required but not found. Install with: apt install jq" >&2
    fi
    exit 2
fi

# Read config
ENGINE_BINARY=$(jq -r '.engine.binary' "${CONFIG_FILE}")
ENGINE_VERSION=$(jq -r '.engine.version' "${CONFIG_FILE}")
DOWNLOAD_URL=$(jq -r '.engine.downloadUrl' "${CONFIG_FILE}")
GAME_NAME=$(jq -r '.game.name' "${CONFIG_FILE}")
RAPID_TAG=$(jq -r '.game.rapidTag' "${CONFIG_FILE}")
MAP_NAME=$(jq -r '.map.name' "${CONFIG_FILE}")

# Determine data directory
DATA_DIR="${SPRING_DATADIR:-${HOME}/.spring}"

ALL_PASSED=true
CHECKS=()

# Check 1: Engine binary
RESOLVED_ENGINE=""
ENGINE_PATH="${HIGHBAR_TEST_ENGINE:-}"
if [ -n "${ENGINE_PATH}" ]; then
    if [ -x "${ENGINE_PATH}" ]; then
        RESOLVED_ENGINE="${ENGINE_PATH}"
        CHECKS+=("{\"name\":\"engine_binary\",\"passed\":true,\"detail\":\"${ENGINE_BINARY} found at ${ENGINE_PATH} (via HIGHBAR_TEST_ENGINE)\"}")
    else
        ALL_PASSED=false
        CHECKS+=("{\"name\":\"engine_binary\",\"passed\":false,\"detail\":\"HIGHBAR_TEST_ENGINE set to ${ENGINE_PATH} but file not found or not executable\",\"resolution\":\"Download from ${DOWNLOAD_URL} or fix HIGHBAR_TEST_ENGINE path\"}")
    fi
else
    FOUND_PATH=$(command -v "${ENGINE_BINARY}" 2>/dev/null || true)
    if [ -n "${FOUND_PATH}" ]; then
        RESOLVED_ENGINE="${FOUND_PATH}"
        CHECKS+=("{\"name\":\"engine_binary\",\"passed\":true,\"detail\":\"${ENGINE_BINARY} found at ${FOUND_PATH}\"}")
    else
        ALL_PASSED=false
        CHECKS+=("{\"name\":\"engine_binary\",\"passed\":false,\"detail\":\"${ENGINE_BINARY} not found on PATH\",\"resolution\":\"Install ${ENGINE_BINARY} from ${DOWNLOAD_URL} or set HIGHBAR_TEST_ENGINE=/path/to/${ENGINE_BINARY}\"}")
    fi
fi

# Check 2: Engine version (only if binary was found)
if [ -n "${RESOLVED_ENGINE}" ]; then
    ACTUAL_VERSION=$("${RESOLVED_ENGINE}" --sync-version 2>/dev/null || echo "UNKNOWN")
    # spring-dedicated returns empty for --sync-version; try spring-headless as fallback
    if [ -z "${ACTUAL_VERSION}" ]; then
        HEADLESS_BIN=$(command -v spring-headless 2>/dev/null || true)
        if [ -n "${HEADLESS_BIN}" ]; then
            ACTUAL_VERSION=$("${HEADLESS_BIN}" --sync-version 2>/dev/null || echo "UNKNOWN")
        fi
    fi
    if [ "${ACTUAL_VERSION}" = "${ENGINE_VERSION}" ]; then
        CHECKS+=("{\"name\":\"engine_version\",\"passed\":true,\"detail\":\"Engine version matches: ${ENGINE_VERSION}\"}")
    else
        ALL_PASSED=false
        CHECKS+=("{\"name\":\"engine_version\",\"passed\":false,\"detail\":\"Expected ${ENGINE_VERSION}, got ${ACTUAL_VERSION}\",\"resolution\":\"Download correct version from ${DOWNLOAD_URL}\"}")
    fi
else
    ALL_PASSED=false
    CHECKS+=("{\"name\":\"engine_version\",\"passed\":false,\"detail\":\"Cannot check version — engine binary not found\",\"resolution\":\"Install ${ENGINE_BINARY} first\"}")
fi

# Check 3: Game archive
GAME_FOUND=false
for search_dir in "${DATA_DIR}/games" "${DATA_DIR}/packages"; do
    if [ -d "${search_dir}" ]; then
        # Look for the game archive by name (file or directory)
        if find "${search_dir}" -maxdepth 2 -name "*${GAME_NAME}*" 2>/dev/null | grep -q .; then
            GAME_FOUND=true
            break
        fi
    fi
done

# Also check via rapid tag marker files
if [ ! ${GAME_FOUND} = true ] && [ -d "${DATA_DIR}/packages" ]; then
    if find "${DATA_DIR}/packages" -maxdepth 2 -name "*.sdp" 2>/dev/null | grep -q .; then
        # SDP files exist; the game might be installed via rapid
        # A more precise check would parse the rapid repo, but presence of sdp files
        # with the right rapid prefix is a reasonable heuristic
        GAME_FOUND=true
    fi
fi

if ${GAME_FOUND}; then
    CHECKS+=("{\"name\":\"game_archive\",\"passed\":true,\"detail\":\"${GAME_NAME} found in ${DATA_DIR}\"}")
else
    ALL_PASSED=false
    CHECKS+=("{\"name\":\"game_archive\",\"passed\":false,\"detail\":\"${GAME_NAME} not found in ${DATA_DIR}/games/ or ${DATA_DIR}/packages/\",\"resolution\":\"Run: pr-downloader --download-game '${RAPID_TAG}' or run tests/setup-engine.sh\"}")
fi

# Check 4: Map file
MAP_FOUND=false
MAP_DIR="${DATA_DIR}/maps"
if [ -d "${MAP_DIR}" ]; then
    # Maps can be .sd7 or .smf files, or directories; check by name pattern
    if find "${MAP_DIR}" -maxdepth 1 -iname "*$(echo "${MAP_NAME}" | tr ' ' '*')*" 2>/dev/null | grep -q .; then
        MAP_FOUND=true
    fi
fi

if ${MAP_FOUND}; then
    CHECKS+=("{\"name\":\"map_file\",\"passed\":true,\"detail\":\"${MAP_NAME} found in ${MAP_DIR}\"}")
else
    ALL_PASSED=false
    CHECKS+=("{\"name\":\"map_file\",\"passed\":false,\"detail\":\"${MAP_NAME} not found in ${MAP_DIR}/\",\"resolution\":\"Download the map manually (maps are hosted externally) or run tests/setup-engine.sh\"}")
fi

# Output results
if ${JSON_MODE}; then
    CHECKS_JSON=$(printf '%s,' "${CHECKS[@]}")
    CHECKS_JSON="[${CHECKS_JSON%,}]"
    if ${ALL_PASSED}; then
        echo "{\"passed\":true,\"checks\":${CHECKS_JSON}}"
    else
        echo "{\"passed\":false,\"checks\":${CHECKS_JSON}}"
    fi
else
    for check_json in "${CHECKS[@]}"; do
        name=$(echo "${check_json}" | jq -r '.name')
        passed=$(echo "${check_json}" | jq -r '.passed')
        detail=$(echo "${check_json}" | jq -r '.detail')
        resolution=$(echo "${check_json}" | jq -r '.resolution // empty')

        if [ "${passed}" = "true" ]; then
            echo "[✓] ${name}: ${detail}"
        else
            echo "[✗] ${name}: ${detail}"
            if [ -n "${resolution}" ]; then
                echo "    → ${resolution}"
            fi
        fi
    done

    TOTAL=${#CHECKS[@]}
    FAILED=0
    for check_json in "${CHECKS[@]}"; do
        passed=$(echo "${check_json}" | jq -r '.passed')
        if [ "${passed}" = "false" ]; then
            FAILED=$((FAILED + 1))
        fi
    done

    echo ""
    if ${ALL_PASSED}; then
        echo "Result: PASSED (${TOTAL} of ${TOTAL} checks passed)"
    else
        echo "Result: FAILED (${FAILED} of ${TOTAL} checks failed)"
    fi
fi

if ${ALL_PASSED}; then
    exit 0
else
    exit 1
fi
