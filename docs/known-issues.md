# Known Issues and Limitations

## Not Yet Implemented

| Feature | Location | Notes |
|---------|----------|-------|
| Save state passthrough | `proxy/src/proxy.c:382` | `TODO: pass save data back to engine` — SaveRequest handler sends empty state |
| Load state passthrough | `proxy/src/proxy.c:391` | `TODO: pass saved state blob from engine` — LoadRequest handler is a stub |

These are architectural placeholders for persistent game state serialization. The proxy currently sends an empty `SaveResponse` and ignores `LoadRequest` data. This does not affect normal gameplay.

## Engine Header Quirks

| Issue | Location | Impact |
|-------|----------|--------|
| Command versioning gap | `proxy/include/AI/AISCommands.h:263` | `FIXME: the +16 is because stuff got removed` — vendored engine header has a known versioning scheme limitation |
| Missing documentation | `proxy/include/AI/AISCommands.h:1445` | `TODO: add docu` — undocumented command handler in vendored header |
| Legacy callback deprecation | `proxy/include/AI/SSkirmishAICallback.h:1918` | `TODO: Deprecate the following function` — legacy C++ AI callback marked for potential removal |
| X11 build check | `proxy/include/System/MainDefines.h:21` | `FIXME: move this check to cmake` — X11 presence check should use FindX11.cmake |
| pthread alignment workaround | `proxy/include/System/MainDefines.h:173` | `WORKAROUND (2013)` — mingw-32 pthread stack alignment fix for SSE code |

All engine header issues are in vendored files from the Recoil engine and do not affect HighBar V2 functionality.

## Limitations

### Headless Engine Combat

The `spring-headless` engine binary does not fully simulate weapon physics. Combat tests using the headless engine may not produce `WeaponFired`, `UnitDamaged`, or `EnemyDamaged` events. This was verified in Feature 016 (headless combat verification).

**Workaround:** Use the graphical engine (`spring` / BAR AppImage) for combat testing:

```bash
./tests/run-all.sh --category ai --graphical
```

### AI Callback Coverage

The proxy implements the most commonly needed callbacks (unit queries, map data, economy, cheats). The full `SSkirmishAICallback` table has 135+ callbacks, of which a subset is currently dispatched. Unsupported callbacks return an error response.

### Single Connection

The proxy supports one AI client connection at a time. If the AI process disconnects, the proxy will report an error to the engine on the next frame. There is no automatic reconnection.

### Frame Budget

The default timeout is 25ms. If the AI consistently exceeds this budget, the engine may remove the AI. The `GameState.processFrame` function enforces a 20ms internal budget for manager evaluation and logs warnings when frames exceed 25ms.

### BarData Expression Values

Some unit stats in BAR are defined as Lua expressions rather than concrete numbers (e.g., `tonumber(128)`). These are preserved as `Expr` values in the `BarData` library. Code that needs numeric values must handle the `ValueOrExpr` type:

```fsharp
match unitDef.health with
| Concrete value -> value  // Direct numeric access
| Expr text -> 0           // Fallback for expression values
```

## Resolved Issues

Issues from previous features that have been addressed:

- **Python client removed** (Feature 019) — All Python code and references cleaned up
- **Repository consolidated** (Feature 020) — Stale docs removed, CLAUDE.md unified, spec artifacts archived
- **.NET 10.0 upgrade** (Feature 019) — All projects migrated from .NET 8.0
- **Unit command INTERNAL_ORDER flag** (Feature 017) — All command builders now set the flag correctly
- **Test framework unified** (Feature 018) — Single `run-all.sh` runner with category support

See also: [Testing](testing.md) | [Architecture](architecture.md)
