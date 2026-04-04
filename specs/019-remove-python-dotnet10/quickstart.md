# Quickstart: Remove Python and Upgrade to .NET 10

**Feature**: 019-remove-python-dotnet10 | **Date**: 2026-04-04

## Prerequisites

- .NET 10 SDK installed (`dotnet --version` should show 10.x)
- CMake (for C proxy build — unchanged)
- buf CLI (for proto linting/generation — unchanged)

## After This Feature

### Build commands (updated)

```bash
# F# client (now targets net10.0)
cd clients/fsharp && dotnet build

# Run all tests (no python category)
./tests/run-all.sh

# Run specific categories
./tests/run-all.sh --category unit        # F# unit tests
./tests/run-all.sh --category proxy       # C proxy tests
./tests/run-all.sh --category integration # F# integration tests
./tests/run-all.sh --category persistent  # Persistent engine tests
./tests/run-all.sh --category ai          # AI tests

# Proto generation (no betterproto output)
cd proto && buf lint && buf generate && cd ..
```

### What's removed

- `clients/python/` — Python client library (use F# client instead)
- `tests/integration/python/` — Python integration tests
- `tests/fixtures/dummy-client.py` — Python test fixture
- `scripts/patch-chobby-ai.py` — replaced by `scripts/patch-chobby-ai.sh`
- `proto/gen/python/` — generated Python protobuf bindings
- `pytest` and `pip` are no longer project dependencies

### What's changed

- All `.fsproj` files target `net10.0` instead of `net8.0`
- `scripts/install-ai.sh` calls `patch-chobby-ai.sh` instead of `patch-chobby-ai.py`
- `tests/run-all.sh` no longer has a `python` test category
- `proto/buf.gen.yaml` no longer generates Python bindings

## Verification

```bash
# Confirm no Python files remain
find . -name "*.py" -not -path "./.specify/*" | wc -l  # Should be 0

# Confirm .NET 10 targeting
grep -r "net8.0" --include="*.fsproj" .  # Should return nothing

# Build and test
dotnet build clients/fsharp/HighBar.Client.fsproj
./tests/run-all.sh --category unit
```
