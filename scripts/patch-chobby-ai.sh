#!/usr/bin/env bash
# Patch Chobby rapid pool files to register HighBarV2 AI in the lobby.
# Bash rewrite of the former patch-chobby-ai.py.

set -euo pipefail

BAR_DATA_DIR="${1:-$HOME/.local/state/Beyond All Reason}"

if [ ! -d "$BAR_DATA_DIR" ]; then
    echo "ERROR: BAR data directory not found: $BAR_DATA_DIR"
    exit 1
fi

PACKAGES_DIR="$BAR_DATA_DIR/packages"
POOL_DIR="$BAR_DATA_DIR/pool"

# The replacement content for aisimplename.lua
read -r -d '' LUA_CONTENT << 'LUAEOF' || true
local subnameMap = {
	['BARb stable'] = "BARbarian AI",
	['NullAI 0.1'] = "Inactive AI",
	['HighBarV2 0.1'] = "HighBar V2 AI",
	['ScavengersAI'] = "ScavengersDefense AI",
	['RaptorsAI'] = "RaptorsDefense AI",
	['SimpleAI'] = "SimpleAI",
	['SimpleDefenderAI'] = "SimpleDefenderAI",
	['SimpleConstructorAI'] = "SimpleConstructorAI",
}

local function GetAiSimpleName(name)
	return subnameMap[name]
end

local simpleAiOrder = {
	['BARb stable'] = 01,
	['STAI'] = 02,
	['HighBarV2 0.1'] = 03,
	['SimpleAI'] = 11,
	['SimpleDefenderAI'] = 13,
	['SimpleConstructorAI'] = 14,
	['ScavengersAI'] = 31,
	['RaptorsAI'] = 41,
	['NullAI 0.1'] = 51,
}

local aiTooltip = {
	['SimpleAI'] = "A simple easy playing beginner AI",
	['SimpleDefenderAI'] = "An easy AI that mostly defends",
	['SimpleConstructorAI'] = "A simple passive AI that builds constructors and turrets",
	['ScavengersAI'] = "PvE game mode with increasing difficulty waves. Only add 1 per game.",
	['STAI'] = "A medium to hard difficulty experimental non cheating AI.",
	['NullAI 0.1'] = "A game-testing AI. Literally does nothing.",
	['BARb stable'] = "Excellent performance adjustable difficulty non-cheating AI.",
	['HighBarV2 0.1'] = "Custom HighBar proxy bridge AI. Requires external F# client.",
	['RaptorsAI'] = "PvE game mode where alien creatures attack. Only add 1 per game.",
}

return {
	GetAiSimpleName = GetAiSimpleName,
	simpleAiOrder = simpleAiOrder,
	aiTooltip = aiTooltip,
}
LUAEOF

# Parse SDP binary format and find pool file for aisimplename.lua
# SDP format: repeated entries of [1-byte name_len][name_bytes][16-byte MD5][4-byte CRC][4-byte size]
find_pool_file() {
    local target="aisimplename.lua"

    for sdp_file in "$PACKAGES_DIR"/*.sdp; do
        [ -f "$sdp_file" ] || continue

        # Decompress SDP to a temp file for binary parsing
        local tmpfile
        tmpfile=$(mktemp)
        trap "rm -f '$tmpfile'" RETURN
        gzip -dc "$sdp_file" > "$tmpfile" 2>/dev/null || continue

        # Read as hex for binary parsing
        local hex
        hex=$(xxd -p "$tmpfile" | tr -d '\n')
        local hex_len=${#hex}
        local pos=0

        while [ "$pos" -lt "$hex_len" ]; do
            # Read 1-byte name length
            local name_len_hex="${hex:$pos:2}"
            local name_len=$((16#$name_len_hex))
            pos=$((pos + 2))

            # Bounds check
            local needed=$(( (name_len * 2) + 32 + 8 + 8 ))
            if [ $((pos + needed)) -gt "$hex_len" ]; then
                break
            fi

            # Read name bytes and decode from hex
            local name_hex="${hex:$pos:$((name_len * 2))}"
            local name
            name=$(echo "$name_hex" | xxd -r -p 2>/dev/null || true)
            pos=$((pos + name_len * 2))

            # Read 16-byte MD5 as hex
            local md5="${hex:$pos:32}"
            pos=$((pos + 32))

            # Skip CRC (4 bytes) and size (4 bytes)
            pos=$((pos + 16))

            # Check if this is our target in a byar/ (but not byar-dev/) path
            if [[ "$name" == *"$target"* ]] && [[ "$name" == *"byar/"* ]] && [[ "$name" != *"byar-dev"* ]]; then
                local prefix="${md5:0:2}"
                local suffix="${md5:2}"
                local pool_file="$POOL_DIR/$prefix/$suffix.gz"
                if [ -f "$pool_file" ]; then
                    rm -f "$tmpfile"
                    echo "$pool_file"
                    return 0
                fi
            fi
        done

        rm -f "$tmpfile"
    done

    return 1
}

pool_file=$(find_pool_file) || {
    echo "WARNING: Could not find aisimplename.lua in pool"
    exit 1
}

# Write patched content as gzipped file
echo "$LUA_CONTENT" | gzip > "$pool_file"
echo "  Patched aisimplename.lua -> $pool_file"
echo "  Chobby AI registration complete."
