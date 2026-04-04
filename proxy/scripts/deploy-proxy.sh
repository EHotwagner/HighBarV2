#!/usr/bin/env bash
# Deploy proxy .so and data files to all engine AI directories.
# Called automatically by CMake post-build, or manually:
#   bash proxy/scripts/deploy-proxy.sh build/libSkirmishAI.so proxy/
#
# Finds all HighBarV2 version directories under known engine locations
# and copies the binary + AIInfo.lua + AIOptions.lua to each one.
# This prevents stale binaries in directories like 0.1/ when only
# stable/ was updated.

set -euo pipefail

SO_PATH="${1:?Usage: deploy-proxy.sh <path/to/libSkirmishAI.so> <proxy-source-dir>}"
PROXY_DIR="${2:?Usage: deploy-proxy.sh <path/to/libSkirmishAI.so> <proxy-source-dir>}"

DEPLOYED=0

for engine_dir in \
    "${HOME}/.local/state/Beyond All Reason/engine"/*/AI/Skirmish \
    "${HOME}/.spring/AI/Skirmish"; do
    [ -d "$engine_dir" ] || continue

    for ver_dir in "$engine_dir/HighBarV2"/*/; do
        [ -d "$ver_dir" ] || continue
        cp -f "$SO_PATH" "$ver_dir/libSkirmishAI.so"
        cp -f "$PROXY_DIR/data/AIInfo.lua" "$ver_dir/"
        cp -f "$PROXY_DIR/data/AIOptions.lua" "$ver_dir/"
        echo "  Deployed to: $ver_dir"
        DEPLOYED=$((DEPLOYED + 1))
    done
done

if [ $DEPLOYED -eq 0 ]; then
    echo "  No engine AI directories found (install BAR first)"
else
    echo "  Deployed to $DEPLOYED directory(ies)"
fi
