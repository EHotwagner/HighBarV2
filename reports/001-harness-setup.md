# Report: Engine Harness Setup

**Date**: 2026-04-02
**Iteration**: 1

## Context

Setting up the headless BAR engine test harness -- the foundation for all integration tests. This includes shell scripts for engine lifecycle management, an F# xUnit fixture for automated start/stop, and a minimal Lua startscript for the game scenario.

## Problem

The engine harness must handle several edge cases: stale sockets from crashed test runs, variable engine startup times (5-15s), and clean shutdown even when tests fail mid-execution.

## Investigation

- Researched xUnit's `IAsyncLifetime` for async fixture setup/teardown
- Determined `ICollectionFixture<EngineFixture>` is the correct sharing pattern to serialize all engine-dependent tests against a single engine instance
- Verified that `spring-headless` accepts startscripts and the `HIGHBAR_SOCKET_PATH` environment variable

## Root Cause

N/A -- initial setup, no bugs encountered.

## Solution

- `start-headless.sh`: Launches engine, writes PID, exits immediately. Handles stale socket detection.
- `stop-headless.sh`: SIGTERM with 5s grace period, escalates to SIGKILL, cleans up files.
- `Harness.fs`: `EngineFixture` implements `IAsyncLifetime`, polls for socket readiness with configurable timeout (default 30s from `HIGHBAR_TEST_TIMEOUT`).
- Socket path uses `/tmp/highbar-test-{guid}.sock` pattern for test isolation.

## Hypotheses

- Engine startup time will be the dominant factor in test suite duration
- Sharing one engine instance across all test classes (via collection fixture) is necessary to meet the 60s target
- Stale socket cleanup at startup should handle most crash recovery scenarios

## Lessons Learned

- xUnit's `ICollectionFixture<T>` serializes all tests in the collection against a single fixture instance, which is exactly what we need for expensive engine startup
- The `[Collection("Engine")]` attribute must be on every test class that depends on the engine fixture
- F# `task {}` computation expressions return `Task<unit>`, which is compatible with `IAsyncLifetime.InitializeAsync()` but `DisposeAsync()` needs `Task` (not `ValueTask`)
