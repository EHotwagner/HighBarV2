# HighBarV2 Development Guidelines

Auto-generated from all feature plans. Last updated: 2026-04-06

## Active Technologies
- C11 + protobuf-c, engine SSkirmishAICallback API (021-map-callbacks-proxy)
- F# / .NET 10.0 (test projects), C11 (proxy tests) + xUnit 2.9.x, CTest/CMake, spring-headless engine (022-live-headless-tests)
- Filesystem only (Unix domain sockets, temp dirs) (022-live-headless-tests)
- F# / .NET 10.0 (client library and test harness) + Google.Protobuf 3.28, xUnit 2.9.x, System.Net.Sockets (023-fix-client-socket-hang)
- Filesystem only (Unix domain sockets) (023-fix-client-socket-hang)
- F# / .NET 10.0 (test projects) + xUnit 2.9.x, HighBar.Client (with EngineDisconnectedException from 023) (024-fix-persistent-test-gaps)

| Category | Technology | Purpose |
|----------|-----------|---------|
| **Languages** | F# / .NET 10.0 | Primary language (client, tests, tools, data library) |
| | C11 | Proxy shared library (Recoil engine AI plugin) |
| | Bash | Test runner scripts, deployment scripts |
| | Lua | Game scenario config, proxy AI options |
| **Serialization** | Google.Protobuf 3.28 | F# client protobuf bindings |
| | protobuf-c | C proxy protobuf bindings |
| | buf CLI | Proto linting and code generation |
| **Testing** | xUnit 2.9.x | F# test framework (unit, integration, persistent, AI) |
| | CTest / CMake | C proxy test framework and build system |
| | Microsoft.NET.Test.Sdk | .NET test runner integration |
| **In-Repo Libraries** | HighBar.Client | F# client library (`clients/fsharp/`) |
| | BarData | Generated game data library (`data/bar/`) |
| | GameRunner | Engine lifecycle management (`tools/game-runner/`) |
| **Tooling** | jq | JSON parsing in shell scripts |
| | XParsec | Lua parser for data generation script |
| **Game Integration** | spring-headless | Recoil engine for headless testing |
| | BAR game content | Beyond All Reason game data and maps |
| **Storage** | Filesystem only | Config files, reports, Unix domain sockets, temp dirs |

## Project Structure

```text
proto/          # Protobuf schema definitions (source of truth)
proxy/          # C shared library (Recoil engine AI plugin)
clients/fsharp/ # F# client library
tools/          # Development utilities (echo-ai, replay)
specs/          # Feature specifications and plans
```

## Commands

```bash
# Build proxy
cmake -B build -DCMAKE_BUILD_TYPE=Release proxy/ && cmake --build build

# Proto linting and code generation (run from proto/ directory)
cd proto && buf lint && buf generate && cd ..

# F# client
cd clients/fsharp && dotnet build

# Run C tests
cd build && ctest

# Run all tests (unified runner — auto-detects engine)
./tests/run-all.sh

# Run specific test category
./tests/run-all.sh --category unit       # F# unit tests only
./tests/run-all.sh --category proxy      # C proxy tests only
./tests/run-all.sh --category integration # F# integration (needs engine)
./tests/run-all.sh --category persistent  # Persistent engine tests (needs engine)

# Check engine prerequisites
./tests/check-prerequisites.sh
```

## Testing Philosophy

- Prefer live engine tests over mocks wherever possible. This environment has a full BAR installation with headless engine available.
- Use `./tests/run-all.sh --category integration` or `--category persistent` for live engine tests.
- Mock-based C proxy tests (CTest) are acceptable for fast feedback during development, but live engine validation is the authoritative test.

## Code Style

- C: C11 standard, no heap allocation on hot path, arena allocation for protobuf
- Proto: buf lint enforced, PACKAGE + FIELD rules
- Commits: Conventional Commits format (feat:, fix:, docs:, perf:, test:, build:)
- Generated code MUST NOT be checked into version control

## Recent Changes
- 024-fix-persistent-test-gaps: Added F# / .NET 10.0 (test projects) + xUnit 2.9.x, HighBar.Client (with EngineDisconnectedException from 023)
- 023-fix-client-socket-hang: Added F# / .NET 10.0 (client library and test harness) + Google.Protobuf 3.28, xUnit 2.9.x, System.Net.Sockets
- 022-live-headless-tests: Added F# / .NET 10.0 (test projects), C11 (proxy tests) + xUnit 2.9.x, CTest/CMake, spring-headless engine


<!-- MANUAL ADDITIONS START -->

## Environment

- This environment has a full BAR (Beyond All Reason) installation.
- GPU passthrough is enabled.
- A headless BAR installation is available for running tests without a display.
- BAR AppImage: `/home/developer/applications/Beyond-All-Reason-1.2988.0.AppImage` (v1.2988.0, 118MB)
  - Dependencies: All installed (sdl2, fuse2, openal, gtk3, alsa-lib, nss, binutils)
  - Launch: `/home/developer/applications/Beyond-All-Reason-1.2988.0.AppImage`
  - **MUST be started in windowed mode** (not fullscreen)

<!-- MANUAL ADDITIONS END -->
