# Data Model: Repository Cleanup

**Feature**: 020-repo-cleanup | **Date**: 2026-04-04

## Overview

This feature involves no runtime data models. The "data" is the repository's file inventory — what stays, what goes, and what gets edited.

## File Inventory: Removal Targets

### Spec Artifacts to Remove (from features 001-019)

| Feature | research.md | data-model.md | quickstart.md | contracts/ | test-report.md |
|---------|:-----------:|:-------------:|:-------------:|:----------:|:--------------:|
| 001 | ✓ | ✓ | ✓ | 2 files | — |
| 002 | ✓ | ✓ | ✓ | — | — |
| 003 | ✓ | ✓ | ✓ | — | 1 file |
| 004 | ✓ | ✓ | ✓ | 2 files | — |
| 005 | ✓ | ✓ | ✓ | — | — |
| 006 | ✓ | ✓ | ✓ | — | — |
| 007 | ✓ | ✓ | ✓ | — | — |
| 008 | ✓ | ✓ | ✓ | — | — |
| 009 | ✓ | ✓ | ✓ | — | — |
| 010 | ✓ | ✓ | — | — | — |
| 011 | ✓ | ✓ | ✓ | — | — |
| 012 | ✓ | ✓ | ✓ | — | — |
| 013 | ✓ | ✓ | ✓ | 1 file | — |
| 014 | ✓ | ✓ | ✓ | — | — |
| 015 | ✓ | ✓ | ✓ | — | — |
| 016 | ✓ | ✓ | ✓ | — | — |
| 017 | ✓ | ✓ | ✓ | — | — |
| 018 | ✓ | ✓ | ✓ | 1 file | — |
| 019 | ✓ | ✓ | ✓ | — | — |

**Totals**: 19 research.md + 19 data-model.md + 18 quickstart.md + 6 contract files + 1 test-report = **63 files to remove**

### Reports to Remove

| File | Reason |
|------|--------|
| reports/006-python-tests.md | Entire content is about removed Python client |

### Reports to Edit (remove stale Python references)

| File | Stale Lines | Action |
|------|-------------|--------|
| reports/007-test-suite-overview.md | 24, 38, 42, 44, 49 | Remove Python test rows/references |
| reports/009-live-engine-integration.md | 8, 147 | Update to F#-only harness |
| reports/010-remaining-test-failures.md | 148 | Remove "Update Python harness" task |
| reports/011-test-fix-results.md | 104 | Remove Python harness note |
| reports/013-diagnose-fix-test-gaps.md | 183 | Remove dummy-client.py reference (if file removed) |
| reports/README.md | 14 | Remove report 006 index entry |

### Documentation to Edit

| File | Action |
|------|--------|
| docs/bar-data-reference.md | Remove "Python Client Bindings" section (lines 151-153, 227) |
| docs/research/05-architecture-spec.md | Add note: Python support removed in 019 |
| docs/research/07-implementation-roadmap.md | Add note: Python support removed in 019 |
| tests/README.md | Remove Python test category, pytest instructions |
| CLAUDE.md | Consolidate Active Technologies to ~15 lines |
| .gitignore | Remove Python section (lines 25-31) |

## File Inventory: What Stays

### Per completed feature (001-019), retained files:
- `spec.md` — Feature specification (authoritative record)
- `plan.md` — Design decisions and rationale
- `tasks.md` — Implementation breakdown
- `checklists/requirements.md` — Acceptance verification

### Expected post-cleanup file counts:
- **specs/**: 139 → ~76 files (19 features × 4 files + feature 020 files)
- **reports/**: 18 → 17 files (remove 006)
- **Total tracked files**: 435 → ~370 files
