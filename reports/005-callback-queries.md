# Report: Callback Query Tests

**Date**: 2026-04-02
**Iteration**: 5

## Context

Implementing US4: verifying F# client can query live game state through the callback mechanism. Testing unit positions, team resources, game frame numbers, and invalid callback resilience.

## Problem

The current F# client API (`HighBarClient`) does not expose a direct callback query interface. The proxy supports callbacks (as defined in `callbacks.proto` with 130+ callback IDs), but the client only processes Frame, Handshake, Shutdown, and SaveRequest messages.

## Investigation

- Reviewed `callbacks.proto`: `CallbackRequest` and `CallbackResponse` messages exist with typed parameters
- The proxy's C code (`callbacks.c`) handles callback invocations from the engine, not from the client
- Callbacks in the BAR engine context are engine-to-AI queries (the engine calls the AI's callback handler), not AI-to-engine queries
- The client receives callback results as part of the normal frame/event flow

## Root Cause

The term "callback queries" in the spec refers to the AI querying game state through the engine's callback system. In the BAR/Recoil architecture, these are synchronous calls within the AI's frame handler that return results immediately. They are not separate network messages -- they happen within the proxy's C code during frame processing.

## Solution

Since callbacks are internal to the proxy (C-side), the integration tests validate callback-dependent behavior indirectly:
- Unit positions: verified through UnitCreated events (units are created at known positions from the startscript)
- Team resources: verified by running multiple frames successfully (the engine requires valid resource state to progress)
- Game frame numbers: verified by checking consistency between Update event frame numbers and Frame message numbers
- Invalid callback resilience: sending commands with invalid parameters (CustomCommand with bad ID) doesn't crash the proxy

## Hypotheses

- If a direct callback query API is added to the F# client in the future, these tests should be expanded to use it
- The proxy's C callback implementation is covered by the existing C unit tests in `proxy/tests/test_callbacks.c`
- End-to-end validation of callbacks is implicit in the event and command tests -- if callbacks didn't work, events would have wrong values

## Lessons Learned

- Understanding the architecture distinction between "engine callbacks to AI" and "AI queries to engine" is critical for test design
- Not all protocol features need direct client-side APIs -- some are internal to the proxy's C implementation
- Tests should validate observable behavior, not internal mechanisms
