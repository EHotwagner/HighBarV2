<!--
  Sync Impact Report
  Version change: 0.0.0 → 1.0.0 (initial ratification)
  Added principles:
    - I. Zero Engine Modifications
    - II. Binary Protocol First
    - III. Correctness Over Cleverness
    - IV. Test at the Boundary
    - V. Latency Budget Discipline
    - VI. Language-Agnostic by Default
    - VII. Explicit Over Implicit
  Added sections:
    - Performance & Safety Constraints
    - Development Workflow
  Templates requiring updates:
    - .specify/templates/plan-template.md — ✅ no updates needed (Constitution Check is dynamic)
    - .specify/templates/spec-template.md — ✅ no updates needed (generic template)
    - .specify/templates/tasks-template.md — ✅ no updates needed (generic template)
  Follow-up TODOs: none
-->

# HighBar V2 Constitution

## Core Principles

### I. Zero Engine Modifications

HighBar V2 MUST integrate with the Recoil engine exclusively through
the standard Skirmish AI plugin interface (`init`, `release`,
`handleEvent`). No engine source patches, no custom builds, no forked
engine headers. If a capability cannot be achieved through the
published AI interface and the `SSkirmishAICallback` function table,
it is out of scope.

**Rationale**: Engine-independence is the project's survival guarantee.
BAR ships engine updates frequently; any fork diverges and dies.
V1 proved that zero-mod integration is viable and maintainable.

### II. Binary Protocol First

All IPC between the proxy and external AI processes MUST use protobuf
serialization with length-prefixed framing over Unix domain sockets
(TCP loopback as cross-platform fallback). No JSON, no text protocols,
no NDJSON on the hot path. Human-readable formats are permitted only
in configuration files (`AIOptions.lua`, `.env`) and debug logging.

**Rationale**: V1's JSON/TCP overhead (~1-5ms per frame) consumed a
significant fraction of the 33ms frame budget. Protobuf + Unix sockets
target < 500us round-trip — a 10x improvement that makes real-time
AI and RL training viable.

### III. Correctness Over Cleverness

Prefer straightforward, auditable implementations. Every struct
serialization MUST map 1:1 to a documented engine struct. Every
command deserialization MUST produce exactly the `SCommand` struct
the engine expects. No "smart" transformations, no implicit
conversions, no lossy mappings. When proto3 zero-value semantics
conflict with engine semantics (e.g., 0 is a meaningful health
value), use wrapper types or explicit has-field tracking.

**Rationale**: This is a bridge — its job is to be invisible. Bugs
in serialization are silent data corruption that manifests as
nonsensical AI behavior, making them extremely hard to diagnose.

### IV. Test at the Boundary

Testing MUST focus on the serialization/deserialization boundary:
engine struct -> protobuf -> wire -> protobuf -> client struct,
and the reverse for commands. Round-trip property tests (serialize
then deserialize equals identity) are the highest-value tests in
this project. Integration tests against a mock engine harness are
preferred over unit tests of internal helper functions. Tests MUST
cover all 28 event types and all 97 command types.

**Rationale**: The proxy has minimal internal logic — it is
essentially a codec + transport. Testing the codec boundary
catches the bugs that matter; testing internal plumbing does not.

### V. Latency Budget Discipline

The proxy MUST complete event serialization + socket write + read
response + command deserialization + execution within the frame
budget. Concrete targets:

- Event serialization: < 100us per frame (all events batched)
- Socket round-trip: < 500us per frame
- Total proxy overhead: < 1ms per frame
- AI response budget: < 25ms of 33ms frame time (30fps)

Any feature or abstraction that adds measurable latency to the
hot path MUST justify itself with benchmarks. Memory allocations
on the hot path MUST use arena/pool allocation. No heap allocation
per event or per command in steady state.

**Rationale**: The entire value proposition of V2 over V1 is
performance. If the proxy is slow, there is no reason to use it
over the simpler Lua bridge.

### VI. Language-Agnostic by Default

The `.proto` schema is the single source of truth for the protocol.
Client libraries in any language MUST be generated from these schemas
and MUST NOT add protocol-level behavior that other languages cannot
replicate. Language-specific ergonomics (F# discriminated unions,
Python async iterators) belong in a thin typed wrapper above the
generated code, never in the schema itself.

**Rationale**: The explicit goal is to enable AI development in any
language. If the F# client adds protocol features the Python client
lacks, the schema is no longer the contract.

### VII. Explicit Over Implicit

Configuration MUST be explicit: socket paths, timeouts, frame mode
(event-per-message vs batched), push-state subscriptions. No magic
defaults that silently change behavior. Every configurable value
MUST have a documented default in `AIOptions.lua` and be overridable
via environment variable. Connection lifecycle events (handshake,
shutdown, reconnect) MUST be logged at INFO level.

**Rationale**: Debugging a multi-process system across an IPC
boundary is inherently difficult. Implicit behavior multiplies
the diagnostic surface area.

## Performance & Safety Constraints

- The proxy shared library MUST be written in C or C++ to meet
  Recoil's Skirmish AI ABI requirements.
- The proxy MUST be single-threaded. The engine calls `handleEvent`
  sequentially; threading adds complexity with no benefit.
- Socket I/O MUST use non-blocking reads with configurable timeouts.
  A hung external process MUST NOT block the engine indefinitely.
- Protobuf arena allocation MUST be used for all hot-path message
  construction. The arena MUST be reset per frame, not per message.
- Maximum message size MUST be bounded and configurable (default 4MB).
  Messages exceeding the limit MUST be rejected with a logged error,
  never silently truncated.
- SIGPIPE MUST be handled. A crashed external process MUST result in
  a clean error return from `handleEvent`, allowing the engine to
  remove the AI gracefully.

## Development Workflow

- All `.proto` files MUST pass `buf lint` before merge.
- Generated code MUST NOT be checked into version control. Proto
  code generation is a build step.
- Every PR that modifies `.proto` schemas MUST include updated
  round-trip tests for affected message types.
- Commit messages MUST follow Conventional Commits format
  (`feat:`, `fix:`, `docs:`, `perf:`, `test:`, `build:`).
- The proxy MUST build with CMake. Client libraries use their
  language-native build tools (dotnet, pip, cargo).
- Cross-platform builds (Linux `.so`, Windows `.dll`) MUST be
  validated in CI before release.

## Governance

This constitution defines the non-negotiable design constraints for
HighBar V2. All implementation decisions, PRs, and design documents
MUST comply with these principles.

**Amendment procedure**:
1. Propose amendment with rationale in a dedicated PR.
2. Amendment MUST document what changes, why, and migration impact.
3. Version bump follows semantic versioning (see below).
4. All dependent specifications and plans MUST be reviewed for
   consistency after amendment.

**Versioning policy**:
- MAJOR: Principle removed, redefined, or made backward-incompatible.
- MINOR: New principle added or existing principle materially expanded.
- PATCH: Wording clarification, typo fix, non-semantic refinement.

**Compliance**: Every spec and plan produced by the project MUST
include a Constitution Check section verifying alignment with these
principles. Violations MUST be explicitly justified in a Complexity
Tracking table.

**Version**: 1.0.0 | **Ratified**: 2026-04-02 | **Last Amended**: 2026-04-02
