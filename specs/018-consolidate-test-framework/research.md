# Research: 018-consolidate-test-framework

**Date**: 2026-04-04

## Decision 1: Test Directory Consolidation Strategy

**Decision**: Keep the existing four-tier test structure (unit, integration, persistent, ai) but consolidate configuration, remove duplicates, and add a unified runner script.

**Rationale**: The four tiers serve genuinely different purposes with different execution characteristics (no engine → shared engine → ephemeral engine → full game). Merging them would conflate concerns. The problem isn't the structure — it's the fragmented configuration and lack of a unified entry point.

**Alternatives considered**:
- Merge all into a single xUnit project: Rejected — different test categories have fundamentally different lifecycle requirements (persistent shares one engine, integration restarts per suite).
- Remove Python tests entirely: Rejected — they validate cross-language protocol compatibility, which is a core project goal.

## Decision 2: Handling the ScenarioTests Overlap

**Decision**: Remove the integration `ScenarioTests.fs` (1 test) since the persistent `T5_ScenarioTests.fs` provides strictly superior coverage with the same scenario patterns plus resource tracking, multi-unit coordination, and state accumulation.

**Rationale**: The integration scenario test (1 test, ~68 lines) is a subset of what persistent T5 covers (multiple scenarios, ~200 lines). The integration test also has a known bug (waits for UnitCreated events that already fired during warm-up). The persistent test suite is faster (shared engine) and more comprehensive.

**Alternatives considered**:
- Fix the integration scenario test: Rejected — the persistent suite already covers this with better assertions.
- Parameterize both: Over-engineering for 1 overlapping test.

## Decision 3: Hardcoded Game Version in game-setup.txt

**Decision**: Templatize `game-setup.txt` so that `GameType` is substituted from `engine-version.json` at runtime via `start-headless.sh`, just as `__MAP_NAME__` already is.

**Rationale**: Currently `game-setup.txt` hardcodes `GameType=Beyond All Reason test-29840-d9b7dba` while `engine-version.json` is the canonical source. The map name is already templated (`__MAP_NAME__`), so adding `__GAME_TYPE__` follows the established pattern.

**Alternatives considered**:
- Generate game-setup.txt from engine-version.json at build time: Over-engineering — runtime substitution via sed is already the pattern.

## Decision 4: Report Format and Location

**Decision**: Use Markdown reports saved to `/reports/testreports/` with filename pattern `YYYY-MM-DD_HH-MM-SS_{category}.md`. Reuse the existing `ValidationReport.fs` patterns for structure.

**Rationale**: The project already uses Markdown reports extensively in `/reports/`. The AI test suite already has a `ValidationReport.fs` module that generates structured markdown. Extending this pattern to the unified runner is natural. The `/reports/testreports/` directory (as requested by user) keeps test reports separate from the hand-written analysis reports in `/reports/`.

**Alternatives considered**:
- JUnit XML: Would enable CI tooling integration but adds complexity. Can be added later if needed.
- JSON: Machine-readable but less useful for developer review. Markdown is the project standard.

## Decision 5: Unified Test Runner Implementation

**Decision**: Single bash script `tests/run-all.sh` that orchestrates all test tiers in order: C proxy (ctest) → F# unit → F# integration → F# persistent → Python integration → AI (optional). Generates a combined Markdown report.

**Rationale**: Bash is already the scripting language for all test infrastructure (start-headless.sh, check-prerequisites.sh, run-tests.sh). A single bash script can invoke `ctest`, `dotnet test`, and `pytest` with consistent output formatting and report generation. The existing `run-tests.sh` already does live progress tracking for F# tests.

**Alternatives considered**:
- F# test orchestrator: Would require building a separate project just to run tests. Over-engineering.
- Makefile: Less flexible for conditional execution and report generation.
- GitHub Actions only: Not usable locally.

## Decision 6: Python Test Retention

**Decision**: Retain Python integration tests but update `conftest.py` to use the same auto-detection logic as the F# harness (derive SPRING_DATADIR from engine path).

**Rationale**: Python tests validate the cross-language contract (Constitution principle VI: Language-Agnostic by Default). They're a small, focused set (12 tests, 5 files) and share the same start-headless.sh script.

## Decision 7: Data Tests (data/bar.tests/)

**Decision**: Include `data/bar.tests/` in the unified runner as the "data" category. These are standalone xUnit tests that validate the BarData library without any engine dependency.

**Rationale**: These tests are current, compile independently, and validate an important component. They should be discoverable through the unified runner.

## Decision 8: Engine Auto-Detection

**Decision**: Standardize the auto-detection logic already added to `start-headless.sh` and `check-prerequisites.sh` (derive SPRING_DATADIR from engine binary location by traversing up to the BAR state directory). Make `check-prerequisites.sh` the single source of truth for environment detection.

**Rationale**: The auto-detection logic was added during the earlier session and works correctly. Centralizing it prevents drift between scripts.
