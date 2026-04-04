#!/usr/bin/env python3
"""Patch Chobby rapid pool files to register HighBarV2 AI in the lobby."""

import gzip
import os
import sys

def find_pool_file(bar_data_dir, sdp_name, target_filename):
    """Find the pool file path for a given filename inside an SDP package."""
    packages_dir = os.path.join(bar_data_dir, "packages")
    pool_dir = os.path.join(bar_data_dir, "pool")

    # Find chobby SDP (the one with chobby configs)
    for sdp_file in os.listdir(packages_dir):
        if not sdp_file.endswith(".sdp"):
            continue
        sdp_path = os.path.join(packages_dir, sdp_file)
        with gzip.open(sdp_path, "rb") as f:
            data = f.read()

        pos = 0
        while pos < len(data):
            name_len = data[pos]
            pos += 1
            name = data[pos : pos + name_len].decode("utf-8", errors="replace")
            pos += name_len
            md5 = data[pos : pos + 16].hex()
            pos += 16
            pos += 4  # crc
            pos += 4  # size

            if target_filename in name and "byar/" in name and "byar-dev" not in name:
                pool_file = os.path.join(pool_dir, md5[:2], md5[2:]) + ".gz"
                if os.path.exists(pool_file):
                    return pool_file

    return None


def patch_aisimplename(bar_data_dir):
    pool_file = find_pool_file(bar_data_dir, "chobby", "aisimplename.lua")
    if not pool_file:
        print("WARNING: Could not find aisimplename.lua in pool")
        return False

    content = (
        'local subnameMap = {\n'
        '\t[\'BARb stable\'] = "BARbarian AI",\n'
        '\t[\'NullAI 0.1\'] = "Inactive AI",\n'
        '\t[\'HighBarV2 0.1\'] = "HighBar V2 AI",\n'
        '\t[\'ScavengersAI\'] = "ScavengersDefense AI",\n'
        '\t[\'RaptorsAI\'] = "RaptorsDefense AI",\n'
        '\t[\'SimpleAI\'] = "SimpleAI",\n'
        '\t[\'SimpleDefenderAI\'] = "SimpleDefenderAI",\n'
        '\t[\'SimpleConstructorAI\'] = "SimpleConstructorAI",\n'
        '}\n'
        '\n'
        'local function GetAiSimpleName(name)\n'
        '\treturn subnameMap[name]\n'
        'end\n'
        '\n'
        'local simpleAiOrder = {\n'
        '\t[\'BARb stable\'] = 01,\n'
        '\t[\'STAI\'] = 02,\n'
        '\t[\'HighBarV2 0.1\'] = 03,\n'
        '\t[\'SimpleAI\'] = 11,\n'
        '\t[\'SimpleDefenderAI\'] = 13,\n'
        '\t[\'SimpleConstructorAI\'] = 14,\n'
        '\t[\'ScavengersAI\'] = 31,\n'
        '\t[\'RaptorsAI\'] = 41,\n'
        '\t[\'NullAI 0.1\'] = 51,\n'
        '}\n'
        '\n'
        'local aiTooltip = {\n'
        '\t[\'SimpleAI\'] = "A simple easy playing beginner AI",\n'
        '\t[\'SimpleDefenderAI\'] = "An easy AI that mostly defends",\n'
        '\t[\'SimpleConstructorAI\'] = "A simple passive AI that builds constructors and turrets",\n'
        '\t[\'ScavengersAI\'] = "PvE game mode with increasing difficulty waves. Only add 1 per game.",\n'
        '\t[\'STAI\'] = "A medium to hard difficulty experimental non cheating AI.",\n'
        '\t[\'NullAI 0.1\'] = "A game-testing AI. Literally does nothing.",\n'
        '\t[\'BARb stable\'] = "Excellent performance adjustable difficulty non-cheating AI.",\n'
        '\t[\'HighBarV2 0.1\'] = "Custom HighBar proxy bridge AI. Requires external F# client.",\n'
        '\t[\'RaptorsAI\'] = "PvE game mode where alien creatures attack. Only add 1 per game.",\n'
        '}\n'
        '\n'
        'return {\n'
        '\tGetAiSimpleName = GetAiSimpleName,\n'
        '\tsimpleAiOrder = simpleAiOrder,\n'
        '\taiTooltip = aiTooltip,\n'
        '}\n'
    )
    with gzip.open(pool_file, "wb") as f:
        f.write(content.encode("utf-8"))
    print(f"  Patched aisimplename.lua -> {pool_file}")
    return True


if __name__ == "__main__":
    bar_data_dir = sys.argv[1] if len(sys.argv) > 1 else os.path.expanduser(
        "~/.local/state/Beyond All Reason"
    )
    if not os.path.isdir(bar_data_dir):
        print(f"ERROR: BAR data directory not found: {bar_data_dir}")
        sys.exit(1)

    ok = patch_aisimplename(bar_data_dir)
    if ok:
        print("  Chobby AI registration complete.")
    else:
        print("  WARNING: Failed to patch Chobby configs.")
        sys.exit(1)
