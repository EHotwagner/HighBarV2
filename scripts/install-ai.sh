#!/usr/bin/env bash
# Install HighBarV2 AI into the live BAR game engine.
# Builds the proxy from source and copies all files to the Skirmish AI directory.
# Overwrites any previous installation.

set -euo pipefail

REPO_ROOT="$(cd "$(dirname "$0")/.." && pwd)"
BAR_DATA_DIR="$HOME/.local/state/Beyond All Reason"
ENGINE_AI_DIR="$BAR_DATA_DIR/engine/recoil_2025.06.19/AI/Skirmish"
INSTALL_DIR="$ENGINE_AI_DIR/HighBarV2/0.1"

# Verify engine directory exists
if [ ! -d "$ENGINE_AI_DIR" ]; then
    echo "ERROR: Engine AI directory not found: $ENGINE_AI_DIR"
    echo "Is BAR installed?"
    exit 1
fi

# Enable developer mode in Chobby (required to see custom AIs in lobby)
if [ ! -f "$BAR_DATA_DIR/devmode.txt" ]; then
    echo "==> Enabling developer mode..."
    touch "$BAR_DATA_DIR/devmode.txt"
fi

# Generate protobuf C sources (required for build)
echo "==> Generating protobuf sources..."
(cd "$REPO_ROOT/proto" && buf generate --path highbar --template '{"version":"v2","plugins":[{"local":"protoc-gen-c","out":"gen/c"}]}')

# Build proxy
echo "==> Building proxy..."
cmake -B "$REPO_ROOT/build" -DCMAKE_BUILD_TYPE=Release "$REPO_ROOT/proxy/"
cmake --build "$REPO_ROOT/build" --parallel

# Verify build output
if [ ! -f "$REPO_ROOT/build/libSkirmishAI.so" ]; then
    echo "ERROR: Build succeeded but libSkirmishAI.so not found"
    exit 1
fi

# Remove old installation if present
if [ -d "$INSTALL_DIR" ]; then
    echo "==> Removing old installation..."
    rm -rf "$INSTALL_DIR"
fi

# Install
echo "==> Installing to $INSTALL_DIR"
mkdir -p "$INSTALL_DIR"
cp "$REPO_ROOT/build/libSkirmishAI.so" "$INSTALL_DIR/"
cp "$REPO_ROOT/proxy/data/AIInfo.lua"   "$INSTALL_DIR/"
cp "$REPO_ROOT/proxy/data/AIOptions.lua" "$INSTALL_DIR/"

# Register AI in Chobby lobby config (patch rapid pool files)
echo "==> Registering AI in Chobby lobby..."
"$REPO_ROOT/scripts/patch-chobby-ai.sh" "$BAR_DATA_DIR"

echo "==> Done. HighBarV2 AI installed."
echo ""
echo "To use:"
echo "  1. Start the F# client:  cd $REPO_ROOT/tools/reference-ai && dotnet run"
echo "  2. Launch BAR (windowed): $HOME/applications/squashfs-root/beyond-all-reason --no-sandbox"
echo "  3. In lobby: Add Bot -> select 'HighBar V2 AI'"
