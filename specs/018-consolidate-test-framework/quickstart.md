# Quickstart: 018-consolidate-test-framework

## After Implementation

### Run All Tests
```bash
# Full suite (skips engine tests if prerequisites not met)
./tests/run-all.sh

# With engine path (if not auto-detected)
HIGHBAR_TEST_ENGINE="/path/to/spring-headless" ./tests/run-all.sh
```

### Run Specific Category
```bash
./tests/run-all.sh --category unit        # F# unit tests only
./tests/run-all.sh --category proxy       # C proxy tests only
./tests/run-all.sh --category integration # F# integration tests (needs engine)
./tests/run-all.sh --category persistent  # Persistent engine tests (needs engine)
./tests/run-all.sh --category python      # Python integration tests (needs engine)
./tests/run-all.sh --category ai          # AI validation tests (needs engine)
./tests/run-all.sh --category data        # BarData library tests
```

### Graphical Test Mode
```bash
# Launches full BAR game with HighBarV2 AI (needs display + AppImage)
./tests/run-all.sh --graphical
```

### View Test Reports
```bash
ls reports/testreports/
# Example: 2026-04-04_16-30-00_all.md
```

### Check Prerequisites
```bash
./tests/check-prerequisites.sh
# Or with JSON output for scripting:
./tests/check-prerequisites.sh --json
```

## Development Notes

- All game version/map configuration lives in `tests/engine-version.json`
- Engine auto-detection derives SPRING_DATADIR from the engine binary's parent path
- Reports are saved to `reports/testreports/` (auto-created if missing)
- Each test run uses unique socket paths — safe to run concurrently
