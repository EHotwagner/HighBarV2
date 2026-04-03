# Quickstart: Live Headless Engine Test Suite

**Branch**: `004-live-headless-testsuite` | **Date**: 2026-04-03

## What This Feature Does

Enables running the HighBarV2 integration test suite against a real Beyond All Reason headless engine, proving end-to-end correctness of the proxy, clients, and protocol.

## Developer Workflow (After Implementation)

### First-Time Setup

```bash
# 1. Check what you need
./tests/check-prerequisites.sh

# 2. Install missing components (automated)
./tests/setup-engine.sh

# 3. Or install manually following the check output
```

### Running Tests

```bash
# F# integration tests (launches own engine instance)
dotnet test tests/integration/fsharp/

# Python integration tests (launches own engine instance)
cd tests/integration/python && pytest

# Run a specific test category
dotnet test tests/integration/fsharp/ --filter "Category=Connection"
```

### When Tests Fail

- Check the test output for engine log excerpts
- Engine logs are saved in the session temp directory (path shown in output)
- Run `./tests/check-prerequisites.sh` to verify your environment

## Key Files

| File | Purpose |
|------|---------|
| `tests/engine-version.json` | Pinned engine + game versions |
| `tests/check-prerequisites.sh` | Validate environment before testing |
| `tests/setup-engine.sh` | Automated content provisioning |
| `tests/fixtures/start-headless.sh` | Launch engine for tests |
| `tests/fixtures/stop-headless.sh` | Clean engine shutdown |
| `tests/fixtures/game-setup.lua` | Test game scenario configuration |
