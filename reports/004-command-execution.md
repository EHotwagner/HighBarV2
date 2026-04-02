# Report: Command Execution Tests

**Date**: 2026-04-02
**Iteration**: 4

## Context

Implementing US3: sending commands from the F# client and verifying the engine executes them. Testing Move, Stop, Build, Patrol, Guard, Attack, Repair, and Fight commands, plus a multi-step scenario.

## Problem

Verifying command effects requires observing state changes over multiple frames. Some commands (Build) need valid unit definition IDs, which depend on the game content loaded.

## Investigation

- MoveCommand: send target coordinates far from spawn, observe position change over 30+ frames
- StopCommand: send after MoveCommand, verify position stabilizes
- BuildCommand: needs a valid `unitDefId` -- using 1 as a placeholder; the test verifies the command is accepted without crashing even if the build fails
- Patrol, Guard, Attack, Repair, Fight: smoke tests verifying no protocol errors or crashes

## Root Cause

The main challenge is that command effects are indirect -- we observe events and state changes rather than command acknowledgments. The protocol doesn't have an explicit "command accepted" response; instead, the engine processes commands and emits events.

## Solution

- Commands are sent by returning `AICommand list` from the `onFrame` callback
- Each test runs for enough frames to observe the expected effect
- Smoke tests (Guard, Attack, Repair, Fight) verify the proxy doesn't crash when receiving these commands, even with edge cases (attacking non-existent unit, guarding self)
- The multi-step scenario (ScenarioTests.fs) validates a full AI turn: find unit -> move -> build -> stop

## Hypotheses

- MoveCommand with large coordinate delta should produce observable position change within 30 frames
- BuildCommand with invalid `unitDefId` should fail silently rather than crash the proxy
- Sending commands to non-existent units should not crash the proxy
- The multi-step scenario validates that commands can be sequenced correctly within the frame loop

## Lessons Learned

- Testing command effects is inherently timing-dependent -- tests should assert "effect observed within N frames" rather than "effect at frame N"
- The proxy's robustness to invalid commands (bad unit IDs, invalid defs) is important to test explicitly
- A multi-step scenario test is valuable for catching sequencing issues that individual command tests miss
