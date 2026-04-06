# Quickstart: 026-corners-heightmap-callback

**Date**: 2026-04-06

## Overview

Add `CALLBACK_MAP_GET_CORNERS_HEIGHT_MAP` (ID 59) to the HighBar protocol and proxy, exposing the engine's native `Map_getCornersHeightMap` API. This provides AI players with ground-truth terrain elevation data at grid square corners, which is more precise than the existing center heightmap.

## Key Files to Modify

| File | Change |
|------|--------|
| `proto/highbar/callbacks.proto` | Add enum value `CALLBACK_MAP_GET_CORNERS_HEIGHT_MAP = 59` |
| `proxy/src/callbacks.c` | Add case handler in `hb_callback_dispatch()` switch |
| `clients/fsharp/src/Client.fs` | Add `GetCornersHeightMap()` method |
| `proxy/tests/mock_engine.c` | Add mock corners heightmap data and function |
| `proxy/tests/test_callbacks.c` | Add `test_get_corners_height_map` test |
| `tests/persistent/fsharp/T9_MapTests.fs` | Add live engine corners heightmap test |

## Build & Test Commands

```bash
# Regenerate protobuf code after proto change
cd proto && buf lint && buf generate && cd ..

# Build proxy
cmake -B build -DCMAKE_BUILD_TYPE=Release proxy/ && cmake --build build

# Run C proxy tests
cd build && ctest

# Build F# client (picks up generated C# protobuf)
cd clients/fsharp && dotnet build

# Run live engine tests
./tests/run-all.sh --category persistent
```

## Critical Difference from Center Heightmap

- Center heightmap: `width × height` elements (lossy center-of-square values)
- Corners heightmap: `(width+1) × (height+1)` elements (ground-truth corner values)

The buffer allocation in the proxy handler MUST use `(w+1) * (h+1)`, not `w * h`.
