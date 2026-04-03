#!/usr/bin/env bash
# Run F# integration tests with live progress feedback.
# Usage: ./tests/fixtures/run-tests.sh [dotnet-test-args...]
#
# Automatically kills stale processes and cleans up before running.
# Prints a running tally as each test completes:
#   [ 3] PASS  ConnectionTests.Client connects ... [< 1 ms]
#   [ 4] FAIL  EventTests.Init event received ... [1 s]

set -uo pipefail

SCRIPT_DIR="$(cd "$(dirname "$0")" && pwd)"
TEST_PROJECT="${SCRIPT_DIR}/../integration/fsharp"
OUTFILE=$(mktemp /tmp/highbar-test-run-XXXXXX.log)

cleanup() {
    # Kill any processes we spawned
    [ -n "${TEST_PID:-}" ] && kill -9 "$TEST_PID" 2>/dev/null || true
    # Kill orphaned dotnet test children
    pgrep -f "vstest.console.dll.*HighBar|testhost.dll.*HighBar" | xargs -r kill -9 2>/dev/null || true
    rm -f "$OUTFILE"
}
trap cleanup EXIT

# ---------------------------------------------------------------
# Step 0: Kill stale processes and free resources
# ---------------------------------------------------------------
echo "--- Cleaning up stale processes ---"

# Engine processes
STALE_ENGINES=$(pgrep -f "spring-headless|spring-dedicated|recoil-main" 2>/dev/null | wc -l)
pkill -9 -f "spring-headless|spring-dedicated|recoil-main" 2>/dev/null || true

# Stale dotnet test / vstest / testhost from previous runs
STALE_DOTNET=$(pgrep -f "vstest.console.dll.*HighBar|testhost.dll.*HighBar|dotnet test tests/integration" 2>/dev/null | wc -l)
pgrep -f "vstest.console.dll.*HighBar|testhost.dll.*HighBar" | xargs -r kill -9 2>/dev/null || true
pgrep -f "dotnet test tests/integration" | xargs -r kill -9 2>/dev/null || true

# Port 8452 (engine autohost)
PORT_PID=$(ss -ulnp 2>/dev/null | grep 8452 | grep -oP 'pid=\K\d+' || true)
if [ -n "$PORT_PID" ]; then
    kill -9 "$PORT_PID" 2>/dev/null || true
fi

# Stale sockets
rm -f /tmp/highbar-test-*.sock /tmp/highbar-test-*.sock.pid 2>/dev/null
rm -f /tmp/hb-test*.sock /tmp/hb*.sock 2>/dev/null

# Brief pause for OS to reclaim resources
if [ "$STALE_ENGINES" -gt 0 ] || [ "$STALE_DOTNET" -gt 0 ] || [ -n "$PORT_PID" ]; then
    echo "  Killed: ${STALE_ENGINES} engine, ${STALE_DOTNET} dotnet test, port-holder: ${PORT_PID:-none}"
    sleep 1
else
    echo "  No stale processes found"
fi

# Verify clean state
if pgrep -f "spring-headless" >/dev/null 2>&1; then
    echo "ERROR: Could not kill stale spring-headless. Aborting."
    exit 1
fi

# ---------------------------------------------------------------
# Step 1: Run tests
# ---------------------------------------------------------------
echo "--- Running tests ---"
dotnet test "$TEST_PROJECT" --logger "console;verbosity=normal" "$@" > "$OUTFILE" 2>&1 &
TEST_PID=$!
disown "$TEST_PID"

PASSED=0
FAILED=0
TOTAL=0
LAST_LINE=0

FINISHED=false
IDLE_SECS=0
MAX_IDLE=15  # exit if no new results for 15s after first result

while ! $FINISHED; do
    sleep 1

    CURRENT_LINES=$(wc -l < "$OUTFILE")
    if [ "$CURRENT_LINES" -le "$LAST_LINE" ]; then
        # No new output — count idle time if we've already seen results
        if [ "$TOTAL" -gt 0 ]; then
            IDLE_SECS=$((IDLE_SECS + 1))
            if [ "$IDLE_SECS" -ge "$MAX_IDLE" ]; then
                FINISHED=true
            fi
        fi
        continue
    fi
    IDLE_SECS=0

    while IFS= read -r line; do
        if [[ "$line" =~ ^[[:space:]]+Passed\  ]]; then
            TOTAL=$((TOTAL + 1))
            PASSED=$((PASSED + 1))
            TEST_NAME=$(echo "$line" | sed 's/^\s*Passed //' | sed 's/ \[.*$//')
            TIME=$(echo "$line" | grep -oP '\[.*?\]$')
            printf "[%2d] PASS  %s %s\n" "$TOTAL" "$TEST_NAME" "$TIME"
        elif [[ "$line" =~ ^[[:space:]]+Failed\  ]]; then
            TOTAL=$((TOTAL + 1))
            FAILED=$((FAILED + 1))
            TEST_NAME=$(echo "$line" | sed 's/^\s*Failed //' | sed 's/ \[.*$//')
            TIME=$(echo "$line" | grep -oP '\[.*?\]$')
            printf "[%2d] FAIL  %s %s\n" "$TOTAL" "$TEST_NAME" "$TIME"
        elif [[ "$line" =~ "Starting test execution" ]]; then
            echo "--- Engine starting (this takes ~15s) ---"
        fi
    done < <(tail -n +"$((LAST_LINE + 1))" "$OUTFILE")

    LAST_LINE=$CURRENT_LINES

    # Also finish if process is dead
    if ! kill -0 "$TEST_PID" 2>/dev/null; then
        FINISHED=true
    fi
done

# ---------------------------------------------------------------
# Step 2: Force-kill dotnet test (it lingers after xUnit finishes)
# ---------------------------------------------------------------
kill -9 "$TEST_PID" 2>/dev/null || true

# ---------------------------------------------------------------
# Step 3: Summary
# ---------------------------------------------------------------
echo ""
if [ "$FAILED" -eq 0 ] && [ "$TOTAL" -gt 0 ]; then
    echo "=== ALL ${TOTAL} TESTS PASSED ==="
    exit 0
elif [ "$TOTAL" -eq 0 ]; then
    echo "=== NO TESTS RAN ==="
    echo "Check output: $OUTFILE"
    trap - EXIT  # preserve log for debugging
    exit 1
else
    echo "=== ${PASSED} passed, ${FAILED} failed (${TOTAL} total) ==="
    echo ""
    echo "Failures:"
    grep '^\s*Failed ' "$OUTFILE" | sed 's/^\s*/  /'
    exit 1
fi
