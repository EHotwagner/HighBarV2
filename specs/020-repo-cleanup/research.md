# Research: Repository Cleanup

**Feature**: 020-repo-cleanup | **Date**: 2026-04-04

## Decision 1: How to handle report 006 (Python Tests)

**Decision**: Remove report 006 entirely from version control.

**Rationale**: Report 006 documents Python client tests that were completely removed in feature 019. The report has zero ongoing value — the Python client no longer exists, the tests no longer run, and the findings are not transferable to the F# test suite. Keeping it with an "OBSOLETE" marker adds noise without value.

**Alternatives considered**:
- Mark as "HISTORICAL/OBSOLETE" with a banner → Adds clutter; no one will reference Python test findings
- Move to an `archive/` directory → Adds structural complexity for zero benefit; git history preserves it

## Decision 2: How to handle partially stale reports (007, 009, 010, 011)

**Decision**: Edit each report to remove or update stale Python references in-place. Do not archive or delete these reports.

**Rationale**: These reports contain valuable current information (F# test results, engine integration findings) mixed with now-obsolete Python references. Surgical edits preserve the useful content while removing misleading references.

**Alternatives considered**:
- Leave as-is with a blanket "some content may be outdated" note → Too vague; developers would still follow stale Python instructions
- Rewrite reports from scratch → Excessive effort for historical documents

## Decision 3: What spec artifacts to remove from completed features (001-019)

**Decision**: Remove `research.md`, `data-model.md`, and `quickstart.md` from all 19 completed features. Keep `spec.md`, `plan.md`, `tasks.md`, and `checklists/requirements.md`.

**Rationale**: 
- `spec.md` is the authoritative feature record
- `plan.md` captures design decisions and rationale
- `tasks.md` captures the implementation breakdown
- `checklists/requirements.md` captures acceptance verification
- `research.md` contains investigation notes whose conclusions are captured in plan.md
- `data-model.md` contains draft data models whose implementations are in the source code
- `quickstart.md` contains setup instructions that are irrelevant once a feature ships

This removes ~55 files (19 × ~3 files minus a few that don't have all three).

**Alternatives considered**:
- Move to `archive/` subdirectories → Adds 19 new directories; git history already preserves these files
- Keep everything → Contradicts the cleanup goal; 139 files is excessive for historical reference
- Remove everything except spec.md → Loses plan.md design rationale and tasks.md implementation history

## Decision 4: Whether to remove contract files from completed features

**Decision**: Remove contract files (`contracts/*.md`) from completed features.

**Rationale**: Contract files define interface specifications that are now encoded in the actual source code (proto files, C headers, F# types). The source code is the authoritative contract; the markdown files are design drafts.

**Alternatives considered**:
- Keep contracts → They duplicate what's in proto/ and proxy/include/; creates confusion about which is authoritative

## Decision 5: How to consolidate CLAUDE.md

**Decision**: Replace the per-feature "Active Technologies" listing with a single consolidated table organized by category (language, dependencies, testing, tooling). Remove per-feature storage annotations. Keep the "Recent Changes" section but limit it to the last 3 features.

**Rationale**: The current 40+ line format repeats the same 6-7 technologies across 18 features. A consolidated table provides the same information in ~15 lines while being easier to scan and maintain.

**Alternatives considered**:
- Keep per-feature format but deduplicate → Still verbose; the feature attribution adds no value for onboarding
- Auto-generate from feature plans → Over-engineering for a static document

## Decision 6: How to handle .gitignore Python entries

**Decision**: Remove the `# Python` section (6 entries) from .gitignore.

**Rationale**: No Python code exists in the repository. These entries are harmless but misleading — they suggest Python tooling is or was recently used.

## Decision 7: How to handle docs/bar-data-reference.md Python section

**Decision**: Remove the "Python Client Bindings" section entirely.

**Rationale**: The section references `clients/python/` which no longer exists. The document should only reference the F# BarData library.

## Decision 8: How to handle tests/README.md Python references

**Decision**: Update tests/README.md to remove all Python test category references, pytest instructions, and `clients/python` setup instructions.

**Rationale**: The test infrastructure is F#-only since feature 019. The README must reflect current reality.

## Decision 9: How to handle docs/research/ Python references

**Decision**: Leave docs/research/02-highbar-v1-analysis.md as-is (historical V1 analysis). Add a brief note to docs/research/05-architecture-spec.md and 07-implementation-roadmap.md indicating Python support was removed in feature 019.

**Rationale**: The V1 analysis is factual history. The architecture spec and roadmap described planned Python support that was later descoped — a brief note prevents confusion without rewriting historical documents.

## Decision 10: How to handle report 013 reference to dummy-client.py

**Decision**: Check if `tests/fixtures/dummy-client.py` exists. If not, remove the reference from report 013.

**Rationale**: Feature 019 removed Python files. If this fixture was removed, the reference is stale.
