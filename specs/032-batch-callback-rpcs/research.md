# Phase 0 Research: Comprehensive Gamestate Snapshot

All Technical Context values are concrete; no `NEEDS CLARIFICATION` markers
remain from the spec. Research below documents the decisions that back the
plan and records alternatives considered.

## Decision 1: Batched query vs. async pipelining

- **Decision**: Batched query — one `getGameState()` request, one response, one snapshot message.
- **Rationale**: User explicitly chose "use batched queries" for this feature. Matches the existing synchronous `CallbackRequest`/`CallbackResponse` contract (no new transport semantics). Eliminates ~500 sequential RPCs per tick with a single round-trip, comfortably under the constitution's 1 ms overhead budget at the reference load.
- **Alternatives considered**:
  - *Async pipelining over the same per-unit callbacks*: would require a non-blocking request path on the proxy socket and out-of-order response correlation. Higher complexity, marginal win over batching.
  - *Push-based snapshot event*: would couple snapshot cadence to engine frames and bypass the caller's control over when to fetch. Rejected in `/speckit.clarify` Q1.

## Decision 2: Proxy-side enumeration sources

- **Decision**: Use `getTeamUnits(myTeam)` for friendlies; `getEnemyUnitsInRadarAndLos(...)` for enemies, then classify each enemy with `Unit_isInLos` (or an equivalent visibility query) to split LOS from radar-only.
- **Rationale**: These are documented `SSkirmishAICallback` entry points already used elsewhere in the proxy. No engine modifications (Principle I). Returns the full currently-visible set without caller-supplied ids (spec Q4/Q5).
- **Alternatives considered**:
  - Caller-supplied id lists: rejected in clarifications; forces the caller to reimplement enemy discovery.
  - Two separate engine queries (`getEnemyUnitsInLos` + `getEnemyUnitsInRadar`): more calls, requires dedup; single `InRadarAndLos` call + per-unit LOS classification is simpler.

## Decision 3: Per-unit field set

- **Decision**: `position`, `health`, `unitDefId`, `team` for friendlies and LOS enemies; `position`, `unitDefId`, `team` (no `health`) for radar-only enemies. Velocity, maxHealth, experience, isBeingBuilt are out of scope (still accessible via existing per-unit callbacks).
- **Rationale**: Matches spec clarification Q3. Keeps the snapshot proportional to the motivating hotspot (what `refreshUnit` and economy fetch today). Prevents scope creep.
- **Alternatives considered**: richer state (velocity, maxHealth, experience) — deferred; add in a follow-up if a concrete caller needs it.

## Decision 4: Representing "health omitted" for radar-only

- **Decision**: Two distinct proto messages — `FriendlyOrLosUnit` (has `health`) and `RadarOnlyUnit` (no `health` field) — held in separate `repeated` collections inside `GameStateSnapshot`. Visibility class is structural, not a flag.
- **Rationale**: Proto3 zero-value ambiguity (Principle III): if `health` were a bare `float` on a shared message, radar entries would be indistinguishable from "dead but visible" entries. Two message types make the contract explicit (Principle VII) and avoid needing a wrapper type.
- **Alternatives considered**:
  - Single `UnitEntry` with `google.protobuf.FloatValue health` — works but introduces wrapper-type handling in C (protobuf-c does not generate ergonomic wrappers).
  - `oneof` — heavier than needed; classification is already carried by which collection the entry is in.

## Decision 5: Wire encoding — new CallbackResult variant

- **Decision**: Add `GameStateSnapshot snapshot_value = 8;` to the existing `CallbackResult` `oneof`. Add `CALLBACK_GAME_GET_STATE = 15;` (next free id in the Game range) to `CallbackId`. Reuse the existing `CallbackRequest`/`CallbackResponse` framing.
- **Rationale**: Binary Protocol First (Principle II). No new message type at the transport layer; the snapshot is just another shape of callback result. Clients that don't know the new variant fall through the existing unknown-variant path without crashing.
- **Alternatives considered**:
  - Dedicated top-level request/response pair outside `CallbackRequest/Response`: more duplication, no upside.

## Decision 6: Memory allocation on the proxy hot path

- **Decision**: Build the `GameStateSnapshot` using the existing per-frame protobuf arena. All `repeated` entries allocated from the arena; reset with the rest of the frame state.
- **Rationale**: Constitution V (no heap allocation per event in steady state; arena reset per frame). The snapshot is a large message — arena allocation is the only viable path at the reference load.
- **Alternatives considered**: heap-allocated builder — violates Principle V.

## Decision 7: Enumeration correctness testing

- **Decision**: A live-engine integration test spawns a spring-headless match at the reference load (200 friendlies + 50 enemies via cheat spawns) and asserts the snapshot's friendly count, enemy-LOS count, and radar-only count match the counts produced by the per-unit callback path.
- **Rationale**: Principle IV — test at the boundary. Catches classification bugs (LOS vs radar) that a proxy-only mock cannot exercise. Aligns with the repo's existing persistent/integration test runner.
- **Alternatives considered**: Proxy-only mock with synthetic callback table — used for round-trip tests, but insufficient alone for enumeration/classification correctness.
