# Implementation Plan: Proxy Contract Documentation

**Branch**: `030-proxy-contract-docs` | **Date**: 2026-04-12 | **Spec**: [spec.md](spec.md)
**Input**: Feature specification from `/specs/030-proxy-contract-docs/spec.md`

## Summary

Document three under-specified proxy contract surfaces identified during FSBarV1's 021 integration: (1) the Shutdown wire shape as a top-level `ProxyMessage` envelope with full reason-mapping table, (2) the `rc=-2` unwired-command log line format with a stability promise, and (3) trigger conditions for all `ShutdownReason` enum values. Additionally, investigate and respond to the FSBarV1 AttackCommand stationary-unit probe. This is a documentation-only feature with no code changes.

## Technical Context

**Language/Version**: N/A (documentation-only feature; references C11 proxy and protobuf3 schema)
**Primary Dependencies**: Existing proxy source (`proxy/src/proxy.c`, `proxy/src/deserialize.c`), protobuf schema (`proto/highbar/messages.proto`)
**Storage**: Filesystem only (markdown contract documents)
**Testing**: Manual review — contract documents are verified by inspection against proxy source
**Target Platform**: N/A (documentation consumed by humans)
**Project Type**: Documentation patch to existing proxy project
**Performance Goals**: N/A
**Constraints**: Zero code changes; documents must be accurate against current proxy source
**Scale/Scope**: 2 contract documents + 1 mailbox response + 1 update to existing contract doc

## Constitution Check

*GATE: Must pass before Phase 0 research. Re-check after Phase 1 design.*

| Principle | Status | Notes |
|-----------|--------|-------|
| I. Zero Engine Modifications | PASS | No engine changes. Documentation only. |
| II. Binary Protocol First | PASS | No protocol changes. Documents existing protobuf wire format. |
| III. Correctness Over Cleverness | PASS | Documents are 1:1 descriptions of actual proxy behavior verified against source. |
| IV. Test at the Boundary | N/A | No testable code changes. Contract docs describe the boundary for future test authors. |
| V. Latency Budget Discipline | N/A | No hot-path changes. |
| VI. Language-Agnostic by Default | PASS | Contract docs describe wire-level behavior, not language-specific client patterns. |
| VII. Explicit Over Implicit | PASS | This feature IS about making implicit contracts explicit. Core alignment. |

No violations. Gate passes.

## Project Structure

### Documentation (this feature)

```text
specs/030-proxy-contract-docs/
├── plan.md              # This file
├── research.md          # Phase 0: source verification findings
├── data-model.md        # Phase 1: entity reference (ShutdownReason enum, log format)
├── quickstart.md        # Phase 1: implementation quickstart
├── contracts/
│   ├── shutdown-wire-shape.md     # FR-001, FR-002, FR-003, FR-006 (new)
│   └── unwired-command-log.md     # FR-004, FR-005 (new)
└── tasks.md             # Phase 2 output (/speckit.tasks)
```

### Source Code (repository root)

```text
# Existing files to update (029 contract doc) — NO new source files
specs/029-fix-trainer-issues/contracts/shutdown-event.md  # Add cross-reference to 030

# New deliverables under this feature's specs dir
specs/030-proxy-contract-docs/contracts/shutdown-wire-shape.md
specs/030-proxy-contract-docs/contracts/unwired-command-log.md

# Mailbox response
Mailbox/2026-04-12_from_HighBarV2_contract-docs-response.md
```

**Structure Decision**: All deliverables are markdown documents. The contract docs live under this feature's `specs/030-proxy-contract-docs/contracts/` directory. The mailbox response goes in the project-root `Mailbox/` directory following existing convention.
