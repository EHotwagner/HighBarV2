# HighBarV2 Development Guidelines

Auto-generated from all feature plans. Last updated: 2026-04-04

## Active Technologies
- F# / .NET 8.0 (primary test language), Python 3.10+ (secondary), C11 (proxy under test) + Google.Protobuf (F#), betterproto (Python), xUnit (F# test framework), pytest (Python test framework) (002-headless-test-suite)
- Filesystem only (reports as markdown, no database) (002-headless-test-suite)
- C11 (proxy), F# / .NET 8.0 (client + tools + tests), Python 3.10+ (client + tests) + protobuf-c (C proxy), Google.Protobuf 3.28 (F#), betterproto (Python), buf CLI (proto generation) (003-tools-prereqs-test-fixes)
- Filesystem only (reports as markdown) (003-tools-prereqs-test-fixes)
- Bash (scripts), F# / .NET 8.0 (test harness), Python 3.10+ (test harness), Lua (game scenario) + xUnit (F# tests), pytest (Python tests), jq (JSON parsing in shell), pr-downloader (game content) (004-live-headless-testsuite)
- Filesystem only (JSON config, log files, temp directories) (004-live-headless-testsuite)
- F# / .NET 8.0 (test harness + tests), TDF config format (game-setup.txt) + xUnit (test framework), spring-headless 2025.06.21 (engine), BAR game content (test-29833-ee0f96a) (005-fix-test-failures)
- Filesystem (config files, reports as markdown) (005-fix-test-failures)
- F# / .NET 8.0 (generator script, data library, tests) + XParsec (Lua parser in generator), xUnit (test framework) (006-typed-bar-data)
- Filesystem only (generated .fs source files) (006-typed-bar-data)
- F# / .NET 8.0 + BarData library (in-repo), Google.Protobuf 3.28 (existing client dep), xUnit 2.9.3 (tests) (009-client-unit-types)
- N/A (static in-memory data from generated F# records) (009-client-unit-types)
- F# / .NET 8.0 + Google.Protobuf (generated types from `proto/highbar/commands.proto`) (010-cheat-command-builders)
- F# / .NET 8.0 + xUnit 2.x, HighBar.Client (in-repo), BarData (in-repo), Google.Protobuf 3.28 (011-persistent-engine-tests)
- Filesystem (session logs, temp directories) (011-persistent-engine-tests)
- C11 (proxy), F# / .NET 8.0 (client + tests) + protobuf-c (C proxy), Google.Protobuf 3.28 (F#), xUnit 2.x (tests), BarData (in-repo) (013-diagnose-fix-test-gaps)
- Filesystem (Unix domain sockets, log files, temp directories) (013-diagnose-fix-test-gaps)
- F# / .NET 8.0 (AI logic + tests), C11 (existing proxy — no changes needed) + HighBar.Client (in-repo), BarData (in-repo), Google.Protobuf 3.28, xUnit 2.x (014-bar-ai-competitive-assessment)
- Filesystem only (structured decision logs as JSON lines, game outcome reports as markdown) (014-bar-ai-competitive-assessment)
- F# / .NET 8.0 + HighBar.Client (in-repo), BarData (in-repo), Google.Protobuf 3.28, xUnit 2.9.x (015-ai-validation-tests)
- Filesystem only (markdown reports, JSON lines decision logs, temp directories) (015-ai-validation-tests)
- F# / .NET 8.0 + HighBar.Client (in-repo), BarData (in-repo), GameRunner (in-repo), xUnit 2.9.x, Google.Protobuf 3.28 (016-verify-headless-combat)
- Filesystem (markdown reports, temp directories, Unix domain sockets) (016-verify-headless-combat)

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

# Proto linting and code generation (run from proto/ directory)
cd proto && buf lint && buf generate && cd ..

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
- 016-verify-headless-combat: Added F# / .NET 8.0 + HighBar.Client (in-repo), BarData (in-repo), GameRunner (in-repo), xUnit 2.9.x, Google.Protobuf 3.28
- 015-ai-validation-tests: Added F# / .NET 8.0 + HighBar.Client (in-repo), BarData (in-repo), Google.Protobuf 3.28, xUnit 2.9.x
- 014-bar-ai-competitive-assessment: Added F# / .NET 8.0 (AI logic + tests), C11 (existing proxy — no changes needed) + HighBar.Client (in-repo), BarData (in-repo), Google.Protobuf 3.28, xUnit 2.x


<!-- MANUAL ADDITIONS START -->

## Environment

- This environment has a full BAR (Beyond All Reason) installation.
- GPU passthrough is enabled.
- A headless BAR installation is available for running tests without a display.

<!-- MANUAL ADDITIONS END -->
