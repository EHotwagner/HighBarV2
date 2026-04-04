# Quickstart: Verifying the Unit Command Fix

**Feature**: 017-fix-unit-commands
**Date**: 2026-04-04

## Build and Test

```bash
# 1. Build the proxy
cmake -B build -DCMAKE_BUILD_TYPE=Release proxy/ && cmake --build build

# 2. Run C proxy tests (includes commandId verification)
cd build && ctest --output-on-failure && cd ..

# 3. Build F# client (no changes expected, verify no regressions)
cd clients/fsharp && dotnet build && cd ../..
```

## Install and Live Test

```bash
# 4. Install updated proxy to BAR
scripts/install-ai.sh

# 5. Start F# reference AI listener
cd tools/reference-ai && dotnet run &

# 6. Launch BAR and start a game with HighBarV2 AI
/home/developer/applications/squashfs-root/beyond-all-reason --no-sandbox
```

## Verification Checklist

- [ ] C proxy tests pass (including new commandId assertions)
- [ ] F# client builds without errors
- [ ] In live game: AI commander moves when given a move command
- [ ] In live game: cheat-spawned units appear correctly
- [ ] In live game: cheat-spawned units respond to move commands
- [ ] In live game: self-destruct command destroys the targeted unit

## What Changed

Single constant: `0` → `-1` as the `commandId` parameter in all `Engine_handleCommand` calls. This makes the engine send `NETMSG_AICOMMAND` packets (which the GameServer processes) instead of `NETMSG_AICOMMAND_TRACKED` packets (which the GameServer silently drops).
