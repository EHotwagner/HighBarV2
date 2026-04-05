# Quickstart: 021-map-callbacks-proxy

## Prerequisites

- CMake build environment (see CLAUDE.md)
- Proxy builds successfully: `cmake -B build -DCMAKE_BUILD_TYPE=Release proxy/ && cmake --build build`
- Proto generated code up to date: `cd proto && buf generate`

## Development Workflow

### Build & Test Cycle

```bash
# Build proxy
cmake -B build -DCMAKE_BUILD_TYPE=Release proxy/ && cmake --build build

# Run C proxy tests
cd build && ctest --output-on-failure

# Run all tests (if engine available)
./tests/run-all.sh --category proxy
```

### Key Files to Modify

| File | Change |
|------|--------|
| `proxy/src/callbacks.c` | Add `make_float_array_response` helper; add case handlers for IDs 52-58 |
| `proxy/tests/mock_engine.c` | Add mock implementations for Map_getHeightMap, Map_getSlopeMap, etc. |
| `proxy/tests/mock_engine.h` | Declare new mock configuration functions |
| `proxy/tests/test_callbacks.c` | Add test cases for all 7 new callbacks |

### Files for Reference (read-only)

| File | Purpose |
|------|---------|
| `proxy/include/AI/SSkirmishAICallback.h` | Engine function pointer signatures |
| `proto/gen/c/highbar/callbacks.pb-c.h` | Generated C types for callbacks |
| `proxy/src/callbacks.c:80-104` | `make_int_array_response` — template for float version |
| `proxy/tests/test_callbacks.c:56-77` | Existing test pattern to follow |

### Verification

```bash
# After implementation, run proxy tests
cd build && ctest --output-on-failure

# With engine available, run integration tests
./tests/run-all.sh --category integration
```
