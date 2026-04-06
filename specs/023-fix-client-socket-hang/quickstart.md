# Quickstart: 023-fix-client-socket-hang

## Prerequisites

- .NET 10.0 SDK
- F# client builds: `cd clients/fsharp && dotnet build`
- Persistent tests build: `cd tests/persistent/fsharp && dotnet build`

## Key Files

| Purpose | Path |
|---------|------|
| Client socket handling (bug location) | `clients/fsharp/src/Client.fs` |
| Test harness (recovery integration) | `tests/persistent/fsharp/PersistentHarness.fs` |

## The Bug

In `Client.fs`, the `recvBytes` function:
```
while read < 4 do
    read <- read + s.Read(headerBuf, read, 4 - read)
```
When `s.Read()` returns 0 (socket closed by peer), `read` stays at 0 and the loop runs forever at 87% CPU.

## The Fix

1. Check `Read()` return value — 0 means peer closed, throw exception
2. Set `NetworkStream.ReadTimeout` for bounded waits
3. Catch timeout/disconnect in `RunFrames`

## Testing the Fix

```bash
# Build client
cd clients/fsharp && dotnet build

# Run persistent tests (engine auto-starts)
./tests/run-all.sh --category persistent

# Manual verification: start tests, then kill engine mid-run
# The test process should fail cleanly, not hang
```

## Configuration

| Env Var | Default | Description |
|---------|---------|-------------|
| HIGHBAR_CLIENT_TIMEOUT_MS | 10000 | Socket read timeout in milliseconds |
