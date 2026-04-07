# Research: 028-adapt-test-harness

**Date**: 2026-04-07

## R1: Where to place the shared engine lifecycle code

**Decision**: Expand `HighBar.Client` library (`clients/fsharp/`) to include engine lifecycle management (EngineConfig, EngineLauncher, ScriptGenerator, SessionDiagnostics), matching FSBarV1's proven `FSBar.Client` architecture.

**Rationale**: FSBarV1 demonstrated that the client library is the natural home for engine lifecycle code — the client needs to know how to start, connect to, and stop the engine. Separating into a test-only project would create an artificial boundary since the AI harness (production use case) also needs engine lifecycle management.

**Alternatives considered**:
- New `HighBar.TestInfra` project — rejected because it creates a false test/production split; AI games in production also need engine lifecycle
- Keep shell scripts and share only F# helper functions — rejected because this preserves the fragile sed-template pattern and doesn't solve the configuration fragmentation

## R2: Whether to eliminate shell scripts (start-headless.sh, stop-headless.sh)

**Decision**: Replace `start-headless.sh` and `stop-headless.sh` with F# code in `EngineLauncher` module. Retain `check-prerequisites.sh` as a standalone validation tool (also useful outside test context).

**Rationale**: FSBarV1 manages the entire engine lifecycle in F# (EngineLauncher.fs) without shell scripts. This eliminates the sed-template fragility, the ProcessStartInfo boilerplate for script invocation, and the indirection of shelling out just to spawn another process. The prerequisite check script is different — it's a standalone diagnostic tool useful from the command line.

**Alternatives considered**:
- Keep shell scripts as-is, only share F# wrappers — rejected because it preserves the root cause (shell-based lifecycle) and adds a layer instead of removing one
- Replace all shell scripts including check-prerequisites.sh — rejected because the prereq script has independent value as a CLI diagnostic tool

## R3: How to handle the game-setup.txt template replacement

**Decision**: Implement a `ScriptGenerator` module (like FSBarV1) that generates Spring engine TDF-format scripts programmatically from `EngineConfig` fields. Remove `game-setup.txt` template and its `sed` substitution pattern.

**Rationale**: FSBarV1's ScriptGenerator produces the complete startup script from config record fields. This eliminates the sed metacharacter vulnerability, makes configuration changes type-safe, and allows per-fixture customization (e.g., different opponent AI for AI tests vs integration tests) without multiple template files.

**Alternatives considered**:
- Keep template but add escaping — rejected because it doesn't solve the type-safety or per-fixture customization problem
- Use a JSON/TOML intermediate format — rejected as unnecessary indirection; the TDF format is simple enough to generate directly

## R4: Migration strategy (incremental vs big-bang)

**Decision**: Incremental migration. Build the shared modules first, then migrate each harness one at a time (integration → persistent → AI), validating tests pass at each step.

**Rationale**: The three harnesses are independent — each can be migrated without affecting the others. Incremental migration provides a safe rollback point at each step and validates the shared modules against progressively more complex use cases.

**Alternatives considered**:
- Big-bang rewrite — rejected due to risk of cascading failures across all test categories simultaneously

## R5: PID file location for orphan tracking

**Decision**: Write PID files to `/tmp/highbar-{guid}.pid` (adjacent to the socket file), matching the current convention. Additionally, write a session manifest to a well-known directory (`/tmp/highbar-sessions/`) listing all active session GUIDs, enabling stale session discovery.

**Rationale**: PID files adjacent to sockets are already the convention. The session manifest directory provides the missing piece — a way to enumerate all sessions and check for orphans. FSBarV1 uses a similar pattern with `{socketPath}.pid`.

**Alternatives considered**:
- PID files inside session directories only — rejected because if the session dir is deleted, the PID reference is lost and the process becomes untrackable
- System-level process scanning — rejected per clarification (only track our own processes)

## R6: Session directory retention implementation

**Decision**: Per clarification, preserve session directories on test failure (for post-mortem), clean up on success. Implementation: the `EngineSession.Stop()` method accepts a `preserveSession: bool` parameter. Test fixtures set this based on test outcome. Default is `false` (clean up).

**Rationale**: Directly implements the clarified requirement. The parameter-based approach lets each fixture decide based on its context (xUnit test result, `HIGHBAR_KEEP_LOGS` env var override).

**Alternatives considered**:
- Always preserve, rely on external cleanup — rejected per clarification
- Config-file-based retention policy — over-engineered for a binary decision
