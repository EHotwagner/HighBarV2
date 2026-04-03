# Research: Build Tools, Install Prerequisites, and Validate Test Suite

**Feature**: 003-tools-prereqs-test-fixes
**Date**: 2026-04-02

## Research Summary

No NEEDS CLARIFICATION items were identified in the Technical Context. All technologies, dependencies, and build tooling are well-documented in the existing project. Research focused on confirming build dependency order and identifying potential failure points.

## Build Dependency Order

**Decision**: Components must be built in this strict order due to compile-time dependencies.

**Rationale**: Each downstream component depends on artifacts from upstream steps. Protobuf generation must happen first because both the C proxy and client libraries consume generated code.

**Build sequence**:

1. **Proto generation** (`buf generate proto/`) — produces C, C#, and Python generated code in `proto/gen/`
2. **C proxy** (`cmake -B build -DCMAKE_BUILD_TYPE=Release proxy/ && cmake --build build`) — consumes `proto/gen/c/` sources
3. **F# client** (`cd clients/fsharp && dotnet build`) — consumes `proto/gen/csharp/` via HighBar.Proto.csproj
4. **Python client** (`cd clients/python && pip install -e .`) — consumes `proto/gen/python/`
5. **Developer tools** (`dotnet build` for each of: echo-ai, reference-ai, replay) — depend on F# client library
6. **F# integration tests** (`cd tests/integration/fsharp && dotnet build`) — depends on F# client

**Alternatives considered**: Parallel builds of F# and Python clients (possible since they don't depend on each other), but sequential is simpler and build times are short.

## Test Execution Strategy

**Decision**: Run test suites in order of dependency depth and isolation level.

**Rationale**: C unit tests have no external dependencies and validate the foundation. F# and Python integration tests require the headless engine and are more fragile.

**Test execution order**:
1. C unit tests via `ctest` (4 tests, no external deps)
2. F# integration tests via `dotnet test` (22 tests, requires headless engine)
3. Python integration tests via `pytest` (12 tests, requires headless engine)

## Headless Engine Availability

**Decision**: If the headless BAR engine (`spring-headless`) is not available, integration tests will be skipped and documented rather than failing with cryptic errors.

**Rationale**: The engine is a large external binary (~500MB+) that may not be installed in all development environments. Tests already have environment variable configuration (`HIGHBAR_TEST_ENGINE`) for engine path.

**Detection**: Check if `spring-headless` is on PATH or `HIGHBAR_TEST_ENGINE` environment variable is set.

## Failure Documentation Format

**Decision**: Failures will be documented in a structured markdown report within the feature spec directory.

**Rationale**: Consistent with project convention of filesystem-only reporting (no database).

**Format**: Each failure documented with: test name, test suite, error output, root cause analysis, fix applied or remediation steps.
