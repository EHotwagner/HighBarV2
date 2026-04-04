# Data Model: 018-consolidate-test-framework

**Date**: 2026-04-04

## Entities

### Test Environment Configuration

Single source of truth for engine and game settings used by all test tiers.

- **engine_version**: Pinned engine version string (e.g., "2025.06.19")
- **engine_binary**: Binary name (e.g., "spring-headless")
- **game_name**: Full game archive name (e.g., "Beyond All Reason test-29840-d9b7dba")
- **rapid_tag**: Rapid download tag (e.g., "byar:test")
- **map_name**: Map to use for tests (e.g., "Red Rock Desert v2")

**Location**: `tests/engine-version.json`  
**Consumers**: All test scripts, harnesses, and the unified runner

### Test Report

Structured output document generated per test run.

- **timestamp**: ISO 8601 run start time
- **category**: Which test tiers were executed (e.g., "all", "unit", "integration")
- **environment**: Engine version, game version, map, platform
- **results**: List of (suite_name, test_name, status [pass/fail/skip], duration_ms, error_message?)
- **summary**: Total passed, failed, skipped counts and total duration
- **diagnostics**: For failed engine tests: last N lines of engine logs

**Format**: Markdown  
**Location**: `reports/testreports/YYYY-MM-DD_HH-MM-SS_{category}.md`  
**Lifecycle**: Created at end of test run, never auto-deleted

### Test Category Registry

Defines the ordered list of test tiers the unified runner knows about.

| Category | Framework | Directory | Engine Required | Order |
|----------|-----------|-----------|-----------------|-------|
| proxy | ctest | build/ | No | 1 |
| unit | dotnet test | tests/unit/fsharp/ | No | 2 |
| data | dotnet test | data/bar.tests/ | No | 3 |
| integration | dotnet test | tests/integration/fsharp/ | Yes | 4 |
| persistent | dotnet test | tests/persistent/fsharp/ | Yes | 5 |
| python | pytest | tests/integration/python/ | Yes | 6 |
| ai | dotnet test | tests/ai/fsharp/ | Yes | 7 |

## Relationships

- **Test Environment Configuration** → consumed by all Engine-Required categories
- **Test Report** → produced once per unified runner invocation
- **Test Category Registry** → used by unified runner to discover and order test execution

## State Transitions

### Test Run Lifecycle

```
NOT_STARTED → PREREQUISITES_CHECK → EXECUTING → REPORT_GENERATION → COMPLETE
                    ↓                    ↓
              SKIP (no engine)    PARTIAL (crash/interrupt)
```

- `PREREQUISITES_CHECK`: Runs check-prerequisites.sh, decides which categories to execute
- `SKIP`: Engine-dependent categories skipped, non-engine categories still run
- `PARTIAL`: On interrupt or engine crash, save partial report with "interrupted" marker
