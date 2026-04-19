# Feature Specification: Comprehensive Gamestate Snapshot

**Feature Branch**: `032-batch-callback-rpcs`
**Created**: 2026-04-19
**Status**: Draft
**Input**: User description: "Each Callbacks.getUnitPos / getUnitHealth is a synchronous send+recv round-trip on the TCP stream to the proxy. There's no batching. Per Update tick with 200 units + 50 enemies that's ~500 sequential RPCs per tick. At 30 Hz this can saturate, which is likely why GameEvent.Update is throttled upstream. Fix is either a batched getUnitPositions(ids) callback proto-side, or async pipelining." + follow-up: "create a comprehensive gamestate, enemy units in los and their state."

## Clarifications

### Session 2026-04-19

- Q: Delivery model for the gamestate snapshot (pull vs push vs hybrid)? → A: Pull — single client-initiated `getGameState()` request/response
- Q: Scope of a snapshot? → A: Full per-tick set — friendlies (pos+health), enemies in LOS (pos+health), radar-only enemies (pos), economy snapshot
- Q: Per-unit state fields? → A: position + health + unitDefId + team (health omitted for radar-only)
- Q: Enemy discovery — who enumerates? → A: Proxy enumerates all currently-visible enemies (LOS + radar); caller does not supply enemy ids
- Q: Friendly enumeration — who enumerates? → A: Proxy enumerates all friendly units owned by the AI

## User Scenarios & Testing *(mandatory)*

### User Story 1 - One-call per-tick gamestate snapshot (Priority: P1)

An AI author writing a client against HighBar wants, on every simulation update, to know the state of (a) every friendly unit they own, (b) every enemy unit currently visible via LOS, (c) every enemy unit currently detected via radar only, and (d) the current economy. Today, producing this picture requires the client to issue hundreds of sequential per-unit RPCs (≈500/tick at 200 friendlies + 50 enemies), which saturates the IPC channel and forces upstream throttling of `GameEvent.Update`. The author wants a single call — `getGameState()` — that returns the complete per-tick gamestate in one response, with the proxy enumerating the unit sets itself so the caller does not need to maintain and replay id lists.

**Why this priority**: This is the sole motivating problem. Without it, every callback-heavy AI loop pays a linear-in-units cost that prevents per-tick decision-making at typical army sizes, and the AI author must hand-roll enemy discovery.

**Independent Test**: With the client connected to a live (or mock) proxy and a scene of N friendly and M visible-enemy units, call `getGameState()` once per tick and verify the returned snapshot contains every friendly, every LOS enemy, every radar-only contact, and a current economy record — all in one round-trip — and that per-tick wall-clock time stays well under one simulation frame at 30 Hz.

**Acceptance Scenarios**:

1. **Given** a scene with 200 friendlies and 50 visible enemies, **When** the AI calls `getGameState()` once per tick, **Then** the snapshot contains all 200 friendlies and all 50 enemy contacts with the expected per-class fields, and completes in well under 33 ms.
2. **Given** `GameEvent.Update` is delivered every simulation frame, **When** the AI uses `getGameState()` as its per-tick refresh, **Then** the client keeps up without upstream throttling and without growing IPC backlog.
3. **Given** some enemy contacts are radar-only (position known, health not), **When** the snapshot is produced, **Then** those entries include position + unitDefId + team but omit health, and are distinguishable from LOS contacts.
4. **Given** a unit dies or leaves visibility between two snapshots, **When** the next `getGameState()` is called, **Then** that unit is simply absent from the new snapshot (it is not reported as an error).
5. **Given** no friendlies and no visible enemies, **When** `getGameState()` is called, **Then** it returns promptly with empty friendly and enemy collections and a valid economy record.

### Edge Cases

- Empty scene (no friendlies, no enemies visible): snapshot returns empty unit collections and a valid economy record in one round-trip.
- Very large scenes: the proxy enforces a hard unit-count cap of `HIGHBAR_SNAPSHOT_MAX_UNITS` (default 4096, overridable via environment variable) on (friendlies + enemies). Exceeding the cap fails the snapshot with `success=false` and a descriptive `error_message`; the client surfaces this via the existing error path. No partial or chunked snapshot is emitted.
- Units transitioning LOS → radar-only (or vice versa) between ticks: reflected by class membership in the next snapshot; no explicit transition events required from this feature.
- Proxy/engine disconnects during a snapshot: client surfaces the existing disconnected-engine error semantics; no silent partial snapshot.
- Radar-only contacts with unknown unitDefId (engine reports 0 / unknown): `unitDefId` is returned as-is from the engine (including "unknown" sentinel); the snapshot does not fabricate values.

## Requirements *(mandatory)*

### Functional Requirements

- **FR-001**: The client MUST expose a single `getGameState()` operation that returns a comprehensive per-tick snapshot in one request/response round-trip.
- **FR-002**: The proxy MUST enumerate all friendly units owned by the AI and include each in the snapshot — the caller MUST NOT be required to supply friendly ids.
- **FR-003**: The proxy MUST enumerate all currently-visible enemy units (both LOS and radar-only) and include each in the snapshot — the caller MUST NOT be required to supply enemy ids.
- **FR-004**: Each friendly entry MUST include: unit id, position, health, unitDefId, team.
- **FR-005**: Each enemy-in-LOS entry MUST include: unit id, position, health, unitDefId, team. LOS classification is structural (carried by the collection / message type the entry belongs to), not a per-entry flag.
- **FR-006**: Each radar-only enemy entry MUST include: unit id, position, unitDefId, team. Health MUST be omitted (not fabricated) for radar-only entries. Radar-only classification is structural (distinct collection / message type), not a per-entry flag.
- **FR-007**: The snapshot MUST include an economy record containing the per-tick economy values the AI needs each update (the 4 economy callbacks already used today).
- **FR-008**: The snapshot response MUST preserve per-unit correlation: each returned entry carries its engine unit id so the caller can match it to prior snapshots.
- **FR-009**: The existing per-unit callbacks (e.g. `getUnitPos`, `getUnitHealth`) MUST continue to work unchanged; `getGameState()` is an additive capability.
- **FR-010**: At 200 friendlies + 50 enemies, `getGameState()` MUST complete fast enough that the AI can process `GameEvent.Update` every simulation frame at 30 Hz without upstream throttling.
- **FR-011**: Engine disconnect during a `getGameState()` call MUST surface via the existing disconnected-engine error semantics (not a silent or partial snapshot).
- **FR-012**: The snapshot MUST be internally consistent for a single engine tick as observed by the proxy (all entries reflect one point-in-time read, not a read smeared across unrelated frames).

### Key Entities

- **GameState snapshot**: The single per-tick response containing four collections (friendlies, enemies-in-LOS, enemies-radar-only, economy), enumerated by the proxy. Visibility classification is structural — each entry lives in its own typed collection, not tagged by a flag.
- **Friendly / LOS enemy / radar-only enemy / economy record**: per-entry field lists are defined once, authoritatively, in [`data-model.md`](./data-model.md). This spec defers to that document to avoid drift.

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: At 200 friendlies + 50 enemies, a full `getGameState()` completes in under 10 ms on the reference test environment (vs. the current sequential-RPC baseline, which saturates the channel at this scale).
- **SC-002**: The number of IPC round-trips per tick for the full snapshot is exactly one (or, if transport chunking is needed for very large scenes, a small constant independent of unit count).
- **SC-003**: With `getGameState()` in use, the client sustains one processed `GameEvent.Update` per simulation frame at 30 Hz for at least 300 consecutive frames (10 s) at the reference load (200 friendlies + 50 enemies), with zero dropped or throttled updates observed over that window.
- **SC-004**: In scenes with mixed LOS/radar contacts, 100% of contacts are classified correctly (LOS entries carry health, radar entries do not) across the test suite.
- **SC-005**: Existing single-unit callback callers continue to work unchanged; no regression in the existing client test suite.

## Assumptions

- The motivating hotspot is the per-tick refresh of friendlies, visible enemies, and economy. Other callbacks (map queries, orders, events other than `Update`) are out of scope for this feature.
- The proxy is cooperative: it is acceptable to extend the proxy's callback surface to add a new enumerating snapshot call, since proxy and client are versioned together in this repo.
- The enemy visibility classification (LOS vs. radar-only) is derivable from the engine's existing visibility queries; the feature does not introduce a new visibility model.
- Test targets of 200 friendlies + 50 enemies reflect realistic mid-to-late-game BAR army sizes; performance targets are set against that reference load.
- The existing disconnect/error model (including `EngineDisconnectedException` from feature 023) is the contract for failures during a snapshot.
- Thread-safety/concurrency of the snapshot call follows the existing client's conventions; no new concurrency model is introduced by this spec.
- Static per-unit metadata beyond unitDefId + team (e.g. experience, maxHealth, isBeingBuilt, velocity) is out of scope for this feature and remains available via existing per-unit callbacks if needed.
