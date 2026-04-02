# HighBarV2 Development Guidelines

Auto-generated from all feature plans. Last updated: 2026-04-02

## Active Technologies

- C11, protobuf-c, CMake (proxy shared library) (001-native-proxy-bridge)
- F# / .NET 8, Google.Protobuf (primary client) (001-native-proxy-bridge)
- Python 3.10+, betterproto (secondary client) (001-native-proxy-bridge)
- buf (proto linting + code generation) (001-native-proxy-bridge)

## Project Structure

```text
proto/          # Protobuf schema definitions (source of truth)
proxy/          # C shared library (Recoil engine AI plugin)
clients/fsharp/ # F# client library
clients/python/ # Python client library
tools/          # Development utilities (echo-ai, replay)
specs/          # Feature specifications and plans
```

## Commands

```bash
# Build proxy
cmake -B build -DCMAKE_BUILD_TYPE=Release proxy/ && cmake --build build

# Proto linting and code generation
buf lint proto/ && buf generate proto/

# F# client
cd clients/fsharp && dotnet build

# Python client
cd clients/python && pip install -e .

# Run C tests
cd build && ctest
```

## Code Style

- C: C11 standard, no heap allocation on hot path, arena allocation for protobuf
- Proto: buf lint enforced, PACKAGE + FIELD rules
- Commits: Conventional Commits format (feat:, fix:, docs:, perf:, test:, build:)
- Generated code MUST NOT be checked into version control

## Recent Changes

- 001-native-proxy-bridge: Added

<!-- MANUAL ADDITIONS START -->
<!-- MANUAL ADDITIONS END -->
