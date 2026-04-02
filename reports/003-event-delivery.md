# Report: Event Delivery Tests

**Date**: 2026-04-02
**Iteration**: 3

## Context

Implementing US2: validating that real engine events arrive correctly in the F# client with properly populated fields. Testing Init, Update, UnitCreated, UnitIdle, Unknown event resilience, and combat events.

## Problem

Determining which events occur naturally (without sending commands) in the minimal game scenario, and how many frames are needed before each event type appears.

## Investigation

- The minimal scenario (builder unit on small map) should naturally produce: Init (frame 0), Update (every frame), UnitCreated (early frames), UnitFinished (shortly after created), UnitIdle (after unit finishes spawning)
- Combat events (UnitDamaged, EnemyEnterLOS) require opposing units within engagement range
- Expanded the game-setup.lua to place teams closer together (1024,1024 vs 1536,1536) so armed units can engage

## Root Cause

N/A -- design phase determining event timing requirements.

## Solution

- Init event: tested in first frame (1 frame needed)
- Update event: tested across 5 frames (every frame after init)
- UnitCreated: tested within 10 frames (builder spawns early)
- UnitIdle: tested within 20 frames (builder goes idle after spawn)
- Combat events: tested within 60 frames with close spawn positions
- Unknown resilience: verified 10-frame run completes without crash regardless of unknown events

## Hypotheses

- Builder units appear as UnitCreated within the first 3-5 frames
- UnitIdle fires within 10 frames of UnitCreated for a builder with no orders
- Combat events require armed units, not just builders -- the expanded scenario may need further tuning if builders don't engage
- The `Unknown` event variant in the F# discriminated union gracefully handles any future event types added to the protobuf schema

## Lessons Learned

- Range-based assertions are better than exact values for timing-dependent tests (e.g., "within 20 frames" rather than "at frame 7")
- The game scenario directly controls which events are testable -- expanding it is key to increasing test coverage
- Combat events may not fire if only builder units are present (they may not be armed)
