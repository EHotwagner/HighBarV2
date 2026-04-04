# Contract: AI Validation Test Runner

**Feature**: 015-ai-validation-tests | **Date**: 2026-04-04

## Interface: xUnit Test Discovery

All validation tests are discovered and executed via `dotnet test` on the `HighBar.AI.Tests.fsproj` project.

### Test Collections

| Collection | Engine | Fixture | Parallel |
|-----------|--------|---------|----------|
| `AIEndToEnd` | Headless | `HeadlessAiFixture` | No (sequential games) |
| `AICompetitive` | Live + Xvfb | `LiveAiFixture` | No (sequential games) |
| `AINonCombat` | Headless | `HeadlessAiFixture` | No (sequential games) |
| `AICombat` | Live + Xvfb | `LiveAiFixture` | No (sequential games) |

### Running Tests

```bash
# All AI validation tests
dotnet test tests/ai/fsharp/ --logger "console;verbosity=normal"

# Specific suite
dotnet test tests/ai/fsharp/ --filter "Category=EndToEnd"
dotnet test tests/ai/fsharp/ --filter "Category=Competitive"
dotnet test tests/ai/fsharp/ --filter "Category=NonCombat"
dotnet test tests/ai/fsharp/ --filter "Category=Combat"
```

### Environment Variables

| Variable | Required | Default | Description |
|----------|----------|---------|-------------|
| `HIGHBAR_TEST_ENGINE` | No | `spring-headless` | Path to headless engine binary |
| `HIGHBAR_LIVE_ENGINE` | For live tests | (from start-live.sh) | Path to graphical engine binary |
| `DISPLAY` | For live tests | `:0` | X11 display for Xvfb |
| `HIGHBAR_KEEP_LOGS` | No | unset | If set, preserve session logs after test |

## Interface: Report Output

Each test suite writes a markdown report to the test output directory.

### Report File Locations

```
tests/ai/fsharp/reports/
├── e2e-validation-YYYYMMDD-HHMMSS.md
├── competitive-validation-YYYYMMDD-HHMMSS.md
├── noncombat-suite-YYYYMMDD-HHMMSS.md
└── combat-suite-YYYYMMDD-HHMMSS.md
```

### Report Format (Validation Reports)

```markdown
# [Suite Name] Validation Report

**Date**: YYYY-MM-DD HH:MM:SS
**Games**: N
**Overall**: PASS / FAIL

## Success Criteria

| ID | Criterion | Result | Details |
|----|-----------|--------|---------|
| SC-001 | 100% completion rate | PASS | 10/10 completed |
| SC-002 | 90%+ mex in 3 min | PASS | 9/10 (90%) |
...

## Per-Game Results

| Game | Result | Duration | Units Produced | Units Lost | Enemy Destroyed |
|------|--------|----------|----------------|------------|-----------------|
| 1 | WIN | 4.2 min | 23 | 0 | 5 |
...
```

### Report Format (Test Suite Reports)

```markdown
# [Suite Name] Test Report

**Date**: YYYY-MM-DD HH:MM:SS
**Runs**: N
**Pass Rate**: XX.X% (M/T assertions)
**Overall**: PASS / FAIL

## Results by Category

| Category | Passed | Failed | Rate |
|----------|--------|--------|------|
| Economy | 18 | 2 | 90% |
...

## Failed Assertions

| Run | Assertion | Expected | Actual |
|-----|-----------|----------|--------|
| 3 | economy_positive_income_2min | income > 0 at 3600f | income = -0.5 |
...
```

## Interface: Game Setup Fixtures

### game-setup-e2e.txt (NEW)

Same as `game-setup.txt` with:
- `deathmode` removed (default = `killall`, allows natural game ending)
- All other settings preserved

### game-setup-barb.txt (NEW)

Same as `game-setup.txt` with:
- `[AI1]` changed to `ShortName=BARb; Version=<default>;`
- `deathmode` removed (default = `killall`, allows natural game ending)
- All other settings preserved
