# HighBarV2 Development Guidelines

Auto-generated from all feature plans. Last updated: 2026-04-12

## Active Technologies
- C11 + protobuf-c, engine SSkirmishAICallback API (021-map-callbacks-proxy)
- F# / .NET 10.0 (test projects), C11 (proxy tests) + xUnit 2.9.x, CTest/CMake, spring-headless engine (022-live-headless-tests)
- Filesystem only (Unix domain sockets, temp dirs) (022-live-headless-tests)
- F# / .NET 10.0 (client library and test harness) + Google.Protobuf 3.28, xUnit 2.9.x, System.Net.Sockets (023-fix-client-socket-hang)
- Filesystem only (Unix domain sockets) (023-fix-client-socket-hang)
- F# / .NET 10.0 (test projects) + xUnit 2.9.x, HighBar.Client (with EngineDisconnectedException from 023) (024-fix-persistent-test-gaps)
- F# / .NET 10.0 + HighBar.Client, Google.Protobuf 3.28, xUnit 2.9.x (025-fix-map-test-reliability)
- C11 (proxy), F# / .NET 10.0 (client, tests), Protobuf (proto schema) + protobuf-c (C proxy), Google.Protobuf 3.28 (F# client), buf CLI (proto linting/codegen) (026-corners-heightmap-callback)
- N/A (read-only engine query, no persistence) (026-corners-heightmap-callback)
- F# / .NET 10.0 (test project), leveraging existing HighBar.Client + HighBar.Client, xUnit 2.9.x, Google.Protobuf 3.28, System.IO (027-extract-save-map-data)
- Filesystem — output files written to session directory and a persistent reports directory (027-extract-save-map-data)
- F# / .NET 10.0 + HighBar.Client, Google.Protobuf 3.28, xUnit 2.9.x, System.Diagnostics.Process, System.Net.Sockets (028-adapt-test-harness)
- Filesystem (Unix domain sockets, session directories in /tmp, PID files) (028-adapt-test-harness)
- C11 (proxy), F# / .NET 10.0 (client and live tests), Protobuf3 (proto schema) + protobuf-c (C proxy serialization), Google.Protobuf 3.28 (F# client), Recoil engine SSkirmishAI plugin interface (vendored headers in `proxy/include/AI/`), spring-headless 2025.06.19 (live tests) (029-fix-trainer-issues)
- Filesystem only — Unix domain sockets for IPC, session directories under `/tmp` for live tests, `engine.infolog` files for trainer sessions (029-fix-trainer-issues)
- N/A (documentation-only feature; references C11 proxy and protobuf3 schema) + Existing proxy source (`proxy/src/proxy.c`, `proxy/src/deserialize.c`), protobuf schema (`proto/highbar/messages.proto`) (030-proxy-contract-docs)
- Filesystem only (markdown contract documents) (030-proxy-contract-docs)

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
# Build proxy (auto-deploys to engine AI directories via post-build script)
# Prerequisites: cmake, protobuf-c, buf
cmake -B build -DCMAKE_BUILD_TYPE=Release -S proxy && cmake --build build

# Proto linting and code generation (run from proto/ directory, required before first proxy build)
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
- If a test cannot pass due to an out-of-scope issue (e.g. a bug in another component, missing infrastructure), it must be reported as skipped or have its assertion relaxed — never silently marked as passing or worked around by fixing out-of-scope code.

## Code Style

- C: C11 standard, no heap allocation on hot path, arena allocation for protobuf
- Proto: buf lint enforced, PACKAGE + FIELD rules
- Commits: Conventional Commits format (feat:, fix:, docs:, perf:, test:, build:)
- Generated code MUST NOT be checked into version control

## Recent Changes
- 030-proxy-contract-docs: Added N/A (documentation-only feature; references C11 proxy and protobuf3 schema) + Existing proxy source (`proxy/src/proxy.c`, `proxy/src/deserialize.c`), protobuf schema (`proto/highbar/messages.proto`)
- 029-fix-trainer-issues: Added C11 (proxy), F# / .NET 10.0 (client and live tests), Protobuf3 (proto schema) + protobuf-c (C proxy serialization), Google.Protobuf 3.28 (F# client), Recoil engine SSkirmishAI plugin interface (vendored headers in `proxy/include/AI/`), spring-headless 2025.06.19 (live tests)
- 028-adapt-test-harness: Added F# / .NET 10.0 + HighBar.Client, Google.Protobuf 3.28, xUnit 2.9.x, System.Diagnostics.Process, System.Net.Sockets


<!-- MANUAL ADDITIONS START -->

## Environment

- This environment has a full BAR (Beyond All Reason) installation.
- GPU passthrough is enabled.
- A headless BAR installation is available for running tests without a display.
- BAR AppImage: `/home/developer/.local/bin/beyond-all-reason` (bind-mounted from host `~/.local/bin/beyond-all-reason`, ~117MB)
  - Dependencies: All installed (sdl2, fuse2, openal, gtk3, alsa-lib, nss, binutils)
  - Launch: `beyond-all-reason --appimage-extract-and-run --no-sandbox` (FUSE unavailable in rootless container)
  - **MUST be started in windowed mode** (not fullscreen)
- BAR data directory: `~/.local/state/Beyond All Reason/`
  - Engine: `~/.local/state/Beyond All Reason/engine/recoil_2025.06.19/`
  - spring-headless: `~/.local/state/Beyond All Reason/engine/recoil_2025.06.19/spring-headless` (v2025.06.19)
  - Game packages (rapid/pool): `~/.local/state/Beyond All Reason/packages/`
- AI registration: `devmode.txt` + `simpleAiList = false` in `IGL_data.lua` (see `docs/bar-info.md` for details)
- **Do NOT patch rapid pool files** — it crashes Chobby

<!-- MANUAL ADDITIONS END -->
