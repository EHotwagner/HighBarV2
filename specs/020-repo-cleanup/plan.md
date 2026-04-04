# Implementation Plan: Repository Cleanup

**Branch**: `020-repo-cleanup` | **Date**: 2026-04-04 | **Spec**: [spec.md](spec.md)
**Input**: Feature specification from `/specs/020-repo-cleanup/spec.md`

## Summary

Clean up the HighBarV2 repository by consolidating the bloated CLAUDE.md (40+ duplicate tech lines), removing or marking stale documentation that references the removed Python client, archiving verbose spec artifacts from 19 completed features, and auditing the root structure for orphaned items. This is a pure documentation and file-management task — no source code changes.

## Technical Context

**Language/Version**: N/A (documentation and file management only)  
**Primary Dependencies**: Git (file removal/tracking), Markdown  
**Storage**: Filesystem only (tracked markdown files)  
**Testing**: Manual audit — grep for stale references, file count verification  
**Target Platform**: Repository (GitHub-hosted)  
**Project Type**: Repository maintenance / documentation cleanup  
**Performance Goals**: N/A  
**Constraints**: Must not break any build, test, or deployment workflows  
**Scale/Scope**: ~435 tracked files, targeting removal/consolidation of ~60-80 files

## Constitution Check

*GATE: Must pass before Phase 0 research. Re-check after Phase 1 design.*

| Principle | Applies? | Status |
|-----------|----------|--------|
| I. Zero Engine Modifications | No — no engine or code changes | PASS |
| II. Binary Protocol First | No — no protocol changes | PASS |
| III. Correctness Over Cleverness | No — no code changes | PASS |
| IV. Test at the Boundary | No — no test code changes | PASS |
| V. Latency Budget Discipline | No — no runtime changes | PASS |
| VI. Language-Agnostic by Default | No — no schema changes | PASS |
| VII. Explicit Over Implicit | Yes — CLAUDE.md must remain explicit about project capabilities | PASS — consolidation preserves all information |
| Development Workflow | Yes — conventional commits, no generated code checked in | PASS |

No violations. No complexity tracking needed.

## Project Structure

### Documentation (this feature)

```text
specs/020-repo-cleanup/
├── plan.md              # This file
├── research.md          # Audit findings and decisions
├── data-model.md        # File inventory and cleanup targets
└── quickstart.md        # Execution guide
```

### Source Code (repository root)

No source code changes. This feature modifies only:

```text
CLAUDE.md                    # Consolidate Active Technologies section
.gitignore                   # Audit for stale entries
reports/                     # Update or remove stale reports
  ├── 006-python-tests.md    # Primary target (Python-only content)
  ├── README.md              # Update categories
  └── TEMPLATE.md            # Review for currency
specs/001-019/               # Remove verbose artifacts from completed features
  ├── research.md            # REMOVE from each completed feature
  ├── data-model.md          # REMOVE from each completed feature  
  ├── quickstart.md          # REMOVE from each completed feature
  └── checklists/            # REMOVE from each completed feature
```

**Structure Decision**: No new directories or files created. This is purely subtractive — removing tracked files and editing existing markdown documents.

## Complexity Tracking

No constitution violations to justify.

## Constitution Re-Check (Post Phase 1 Design)

All gates still pass after research and design phases. Key observations:

- **Principle VII (Explicit Over Implicit)**: Confirmed — the consolidated CLAUDE.md preserves all technology, command, and structural information. No information loss from consolidation.
- **Development Workflow**: Confirmed — all changes will use conventional commits. No generated code is affected. File removals are tracked through git.
- **No new violations** introduced by the design decisions in research.md.
