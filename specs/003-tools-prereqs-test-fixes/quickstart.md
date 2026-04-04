# Quickstart: Build Tools, Install Prerequisites, and Validate Test Suite

**Feature**: 003-tools-prereqs-test-fixes
**Date**: 2026-04-02

## Prerequisites

Ensure these are installed:
- CMake 3.20+
- C11 compiler (gcc or clang)
- .NET 10.0 SDK
- Python 3.10+
- protobuf-c library (`pkg-config --exists libprotobuf-c`)
- buf CLI (`buf --version`)

Optional (for integration tests):
- `spring-headless` binary on PATH, or `HIGHBAR_TEST_ENGINE` env var set

## Build (in order)

```bash
# 1. Lint and generate protobuf code (run from proto/ directory)
cd proto && buf lint && buf generate && cd ..

# 2. Build C proxy
cmake -B build -DCMAKE_BUILD_TYPE=Release proxy/ && cmake --build build

# 3. Build F# client
dotnet build clients/fsharp/HighBar.Client.fsproj

# 4. Install Python client (requires a virtual environment)
python3 -m venv .venv
.venv/bin/pip install -e clients/python/

# 5. Build developer tools
dotnet build tools/echo-ai/EchoAI.fsproj
dotnet build tools/reference-ai/ReferenceAI.fsproj
dotnet build tools/replay/Replay.fsproj

# 6. Build F# integration tests
dotnet build tests/integration/fsharp/
```

## Run Tests

```bash
# C unit tests (no engine needed)
cd build && ctest --output-on-failure && cd ..

# F# integration tests (requires headless engine)
dotnet test tests/integration/fsharp/ --logger "console;verbosity=detailed"

# Python integration tests (requires headless engine)
.venv/bin/pytest tests/integration/python/ -v
```

## Environment Variables

| Variable | Default | Description |
|----------|---------|-------------|
| `HIGHBAR_TEST_ENGINE` | `spring-headless` | Path to headless engine binary |
| `HIGHBAR_TEST_TIMEOUT` | `30s` | Test timeout per test case |
| `HIGHBAR_TEST_MAP` | (project default) | Map to use for integration tests |
| `HIGHBAR_LOG_LEVEL` | (not set) | Logging verbosity |
| `HIGHBAR_SOCKET_PATH` | (auto) | Unix socket path for IPC |
