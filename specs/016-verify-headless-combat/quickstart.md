# Quickstart: Verify Headless Combat and Fix Test Errors

**Feature**: 016-verify-headless-combat  
**Date**: 2026-04-04

## Prerequisites

1. **Engine**: `spring-headless` at `/home/developer/.local/bin/spring-headless` (v2025.06.21)
2. **Game content**: BAR `test-29833-ee0f96a` in `/home/developer/.spring/`
3. **Map**: `Comet Catcher Remake` in `/home/developer/.spring/maps/`
4. **Proxy**: `build/libSkirmishAI.so` built
5. **.NET 10.0 SDK** installed

Verify all prerequisites:
```bash
cd /home/developer/projects/HighBarV2
./tests/check-prerequisites.sh
```

## Build

```bash
cd /home/developer/projects/HighBarV2
dotnet build tests/ai/fsharp/HighBar.AI.Tests.fsproj
```

## Run Tests

### Combat Verification Only (US2 — the key question)
```bash
dotnet test tests/ai/fsharp/HighBar.AI.Tests.fsproj --filter "FullyQualifiedName~HeadlessCombatVerification"
```

### End-to-End Tests (US1/US3)
```bash
dotnet test tests/ai/fsharp/HighBar.AI.Tests.fsproj --filter "FullyQualifiedName~EndToEnd"
dotnet test tests/ai/fsharp/HighBar.AI.Tests.fsproj --filter "FullyQualifiedName~NonCombat"
```

### Full Suite (all headless tests)
```bash
dotnet test tests/ai/fsharp/HighBar.AI.Tests.fsproj
```

### Live Engine Tests (requires DISPLAY)
```bash
export DISPLAY=:99
dotnet test tests/ai/fsharp/HighBar.AI.Tests.fsproj --filter "FullyQualifiedName~Combat"
dotnet test tests/ai/fsharp/HighBar.AI.Tests.fsproj --filter "FullyQualifiedName~Competitive"
```

## Reports

Generated reports are written to `/home/developer/projects/HighBarV2/reports/` as timestamped markdown files.

## Key Files

| What | Where |
|------|-------|
| Combat verification test | `tests/ai/fsharp/HeadlessCombatVerification.fs` |
| Combat verification fixture | `tests/fixtures/game-setup-combat-verify.txt` |
| Test harness | `tests/ai/fsharp/AiTestHarness.fs` |
| Game outcome types | `tests/ai/fsharp/AiTestTypes.fs` |
| Report generator | `tests/ai/fsharp/ValidationReport.fs` |
| Engine config | `tests/engine-version.json` |
