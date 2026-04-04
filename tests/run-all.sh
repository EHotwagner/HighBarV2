#!/usr/bin/env bash
# Unified test runner for HighBarV2.
# Usage: run-all.sh [--category CATEGORY] [--graphical] [--help]
#
# Categories: proxy, unit, data, integration, persistent, ai, all (default)
# AI tests are opt-in only (must explicitly pass --category ai).

set -euo pipefail

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
REPO_ROOT="$(cd "${SCRIPT_DIR}/.." && pwd)"
REPORT_DIR="${REPO_ROOT}/reports/testreports"
ENGINE_VERSION_FILE="${SCRIPT_DIR}/engine-version.json"

# Defaults
CATEGORY="all"
GRAPHICAL=false
ENGINE_AVAILABLE=false
RUN_START=""
INTERRUPTED=false

# Per-tier results
declare -A TIER_PASSED TIER_FAILED TIER_SKIPPED TIER_OUTPUT TIER_STATUS

# Engine env vars (populated by auto-detection)
RESOLVED_ENGINE=""
RESOLVED_DATADIR=""
RESOLVED_MAP=""
RESOLVED_GAME=""

# ─── Argument parsing ───────────────────────────────────────────────

usage() {
    cat <<'EOF'
Usage: run-all.sh [OPTIONS]

Options:
  --category CAT   Run only tests in category CAT
                   Categories: proxy, unit, data, integration, persistent, ai, all
                   Default: all (excludes ai — ai must be requested explicitly)
  --graphical      Launch full graphical BAR game with AI for visual validation
  --help           Show this help

Examples:
  ./tests/run-all.sh                       # Run all non-AI tests
  ./tests/run-all.sh --category unit       # Unit tests only
  ./tests/run-all.sh --category integration # Integration tests (needs engine)
  ./tests/run-all.sh --category ai         # AI validation tests (long-running)
  ./tests/run-all.sh --graphical           # Launch graphical game
EOF
    exit 0
}

while [[ $# -gt 0 ]]; do
    case "$1" in
        --category) CATEGORY="${2:?--category requires a value}"; shift 2 ;;
        --graphical) GRAPHICAL=true; shift ;;
        --help|-h) usage ;;
        *) echo "Unknown option: $1" >&2; usage ;;
    esac
done

# ─── Signal trapping ────────────────────────────────────────────────

cleanup() {
    INTERRUPTED=true
    echo ""
    echo "=== Interrupted — cleaning up ==="

    # Kill any engine processes we spawned
    for pidfile in /tmp/highbar-test-*.sock.pid; do
        if [ -f "$pidfile" ]; then
            local pid
            pid=$(cat "$pidfile" 2>/dev/null || true)
            if [ -n "$pid" ] && kill -0 "$pid" 2>/dev/null; then
                kill "$pid" 2>/dev/null || true
                echo "Killed engine PID $pid"
            fi
            rm -f "$pidfile"
        fi
    done

    generate_report
    print_summary
    exit 1
}

trap cleanup SIGINT SIGTERM

# ─── Auto-detection ─────────────────────────────────────────────────

detect_engine() {
    # Already set via env var?
    if [ -n "${HIGHBAR_TEST_ENGINE:-}" ] && [ -x "${HIGHBAR_TEST_ENGINE}" ]; then
        RESOLVED_ENGINE="${HIGHBAR_TEST_ENGINE}"
    else
        # Search standard BAR AppImage locations
        local candidate
        for candidate in \
            "${HOME}/.local/state/Beyond All Reason/engine"/*/spring-headless \
            "$(command -v spring-headless 2>/dev/null || true)"; do
            if [ -n "$candidate" ] && [ -x "$candidate" ]; then
                RESOLVED_ENGINE="$candidate"
                break
            fi
        done
    fi

    if [ -z "$RESOLVED_ENGINE" ]; then
        return 1
    fi

    # Derive SPRING_DATADIR from engine location
    if [ -n "${SPRING_DATADIR:-}" ]; then
        RESOLVED_DATADIR="${SPRING_DATADIR}"
    else
        local engine_dir
        engine_dir="$(dirname "$(readlink -f "$RESOLVED_ENGINE")")"
        local candidate_dir
        candidate_dir="$(dirname "$(dirname "$engine_dir")")"
        if [ -d "${candidate_dir}/maps" ] && [ -d "${candidate_dir}/packages" ]; then
            RESOLVED_DATADIR="$candidate_dir"
        fi
    fi

    # Read map and game from engine-version.json
    if [ -f "$ENGINE_VERSION_FILE" ]; then
        RESOLVED_MAP="${HIGHBAR_TEST_MAP:-$(jq -r '.map.name' "$ENGINE_VERSION_FILE")}"
        RESOLVED_GAME="$(jq -r '.game.name' "$ENGINE_VERSION_FILE")"
    fi

    export HIGHBAR_TEST_ENGINE="$RESOLVED_ENGINE"
    [ -n "$RESOLVED_DATADIR" ] && export SPRING_DATADIR="$RESOLVED_DATADIR"
    [ -n "$RESOLVED_MAP" ] && export HIGHBAR_TEST_MAP="$RESOLVED_MAP"
    return 0
}

check_engine_prereqs() {
    if detect_engine; then
        # Run the full prerequisite check
        local result
        result=$("${SCRIPT_DIR}/check-prerequisites.sh" --json 2>/dev/null || echo '{"passed":false}')
        if echo "$result" | jq -e '.passed' >/dev/null 2>&1; then
            ENGINE_AVAILABLE=true
        fi
    fi
}

# ─── Tier runners ───────────────────────────────────────────────────

should_run() {
    local tier="$1"
    if [ "$CATEGORY" = "all" ]; then
        # "all" runs everything EXCEPT ai (ai is opt-in)
        [ "$tier" != "ai" ]
    else
        [ "$CATEGORY" = "$tier" ]
    fi
}

run_tier() {
    local tier="$1"
    local label="$2"
    shift 2
    local cmd=("$@")

    echo ""
    echo "━━━ ${label} ━━━"

    local output
    local exit_code=0
    output=$("${cmd[@]}" 2>&1) || exit_code=$?

    TIER_OUTPUT[$tier]="$output"

    # Parse pass/fail counts from output (works for dotnet test, ctest)
    local passed=0 failed=0
    # dotnet test format: "Passed: N" / "Failed: N"
    local dp df
    dp=$(echo "$output" | grep -oP 'Passed:\s+\K\d+' | tail -1 || true)
    df=$(echo "$output" | grep -oP 'Failed:\s+\K\d+' | tail -1 || true)
    # ctest format: "100% tests passed, 0 tests failed out of 4"
    local cp cf
    cf=$(echo "$output" | grep -oP '\d+(?= tests failed)' | tail -1 || true)
    local ct
    ct=$(echo "$output" | grep -oP 'out of \K\d+' | tail -1 || true)
    if [ -n "$ct" ] && [ -n "$cf" ]; then
        cp=$((ct - cf))
    else
        cp=""
    fi
    passed=${dp:-${cp:-0}}
    failed=${df:-${cf:-0}}
    [ -z "$passed" ] && passed=0
    [ -z "$failed" ] && failed=0

    TIER_PASSED[$tier]=$passed
    TIER_FAILED[$tier]=$failed
    TIER_SKIPPED[$tier]=0

    if [ $exit_code -eq 0 ]; then
        TIER_STATUS[$tier]="pass"
        echo "  ✓ PASSED (${passed} passed)"
    else
        TIER_STATUS[$tier]="fail"
        echo "  ✗ FAILED (${passed} passed, ${failed} failed)"
        echo "$output" | tail -10 | sed 's/^/    /'
    fi
}

skip_tier() {
    local tier="$1"
    local label="$2"
    local reason="$3"

    echo ""
    echo "━━━ ${label} ━━━"
    echo "  ⊘ SKIPPED: ${reason}"

    TIER_STATUS[$tier]="skip"
    TIER_PASSED[$tier]=0
    TIER_FAILED[$tier]=0
    TIER_SKIPPED[$tier]=1
    TIER_OUTPUT[$tier]=""
}

# ─── Report generation ──────────────────────────────────────────────

generate_report() {
    mkdir -p "$REPORT_DIR"

    local timestamp
    timestamp=$(date '+%Y-%m-%d_%H-%M-%S')
    local report_file="${REPORT_DIR}/${timestamp}_${CATEGORY}.md"

    local total_passed=0 total_failed=0 total_skipped=0
    for tier in "${!TIER_PASSED[@]}"; do
        total_passed=$((total_passed + ${TIER_PASSED[$tier]:-0}))
        total_failed=$((total_failed + ${TIER_FAILED[$tier]:-0}))
        total_skipped=$((total_skipped + ${TIER_SKIPPED[$tier]:-0}))
    done

    local status_emoji="✓"
    [ $total_failed -gt 0 ] && status_emoji="✗"
    $INTERRUPTED && status_emoji="⚠"

    cat > "$report_file" <<EOF
# Test Report: ${CATEGORY}

**Date**: ${timestamp}
**Status**: ${status_emoji} $(if $INTERRUPTED; then echo "INTERRUPTED"; elif [ $total_failed -gt 0 ]; then echo "FAILED"; else echo "PASSED"; fi)

## Environment

| Property | Value |
|----------|-------|
| Engine | ${RESOLVED_ENGINE:-not detected} |
| Engine Version | $([ -f "$ENGINE_VERSION_FILE" ] && jq -r '.engine.version' "$ENGINE_VERSION_FILE" || echo "N/A") |
| Game | ${RESOLVED_GAME:-N/A} |
| Map | ${RESOLVED_MAP:-N/A} |
| Platform | $(uname -srm) |
| Data Dir | ${RESOLVED_DATADIR:-N/A} |

## Results

| Tier | Status | Passed | Failed | Skipped |
|------|--------|--------|--------|---------|
EOF

    for tier in proxy unit data integration persistent ai; do
        if [ -n "${TIER_STATUS[$tier]:-}" ]; then
            local status_mark="✓"
            [ "${TIER_STATUS[$tier]}" = "fail" ] && status_mark="✗"
            [ "${TIER_STATUS[$tier]}" = "skip" ] && status_mark="⊘"
            echo "| ${tier} | ${status_mark} ${TIER_STATUS[$tier]} | ${TIER_PASSED[$tier]:-0} | ${TIER_FAILED[$tier]:-0} | ${TIER_SKIPPED[$tier]:-0} |" >> "$report_file"
        fi
    done

    cat >> "$report_file" <<EOF

## Summary

- **Total Passed**: ${total_passed}
- **Total Failed**: ${total_failed}
- **Total Skipped**: ${total_skipped} tier(s)
EOF

    # Add failure details
    local has_failures=false
    for tier in "${!TIER_STATUS[@]}"; do
        if [ "${TIER_STATUS[$tier]}" = "fail" ]; then
            has_failures=true
            break
        fi
    done

    if $has_failures; then
        echo "" >> "$report_file"
        echo "## Failure Details" >> "$report_file"
        for tier in "${!TIER_STATUS[@]}"; do
            if [ "${TIER_STATUS[$tier]}" = "fail" ]; then
                echo "" >> "$report_file"
                echo "### ${tier}" >> "$report_file"
                echo '```' >> "$report_file"
                echo "${TIER_OUTPUT[$tier]}" | tail -50 >> "$report_file"
                echo '```' >> "$report_file"

                # Include engine logs for engine-dependent tiers
                if [[ "$tier" =~ ^(integration|persistent|ai)$ ]]; then
                    local session_dir
                    session_dir=$(find /tmp -maxdepth 1 -name "highbar-test-*" -type d 2>/dev/null | sort -r | head -1)
                    if [ -n "$session_dir" ] && [ -f "$session_dir/infolog.txt" ]; then
                        echo "" >> "$report_file"
                        echo "#### Engine Log (last 30 lines)" >> "$report_file"
                        echo '```' >> "$report_file"
                        tail -30 "$session_dir/infolog.txt" >> "$report_file" 2>/dev/null || true
                        echo '```' >> "$report_file"
                    fi
                fi
            fi
        done
    fi

    echo "" >> "$report_file"
    echo "---" >> "$report_file"
    echo "*Generated by tests/run-all.sh*" >> "$report_file"

    echo ""
    echo "Report saved: ${report_file}"
}

# ─── Summary ────────────────────────────────────────────────────────

print_summary() {
    local total_passed=0 total_failed=0 total_skipped=0
    for tier in "${!TIER_PASSED[@]}"; do
        total_passed=$((total_passed + ${TIER_PASSED[$tier]:-0}))
        total_failed=$((total_failed + ${TIER_FAILED[$tier]:-0}))
        total_skipped=$((total_skipped + ${TIER_SKIPPED[$tier]:-0}))
    done

    echo ""
    echo "═══════════════════════════════════════"
    if [ $total_failed -gt 0 ]; then
        echo "  RESULT: FAILED"
    else
        echo "  RESULT: PASSED"
    fi
    echo "  Passed: ${total_passed}  Failed: ${total_failed}  Skipped tiers: ${total_skipped}"
    echo "═══════════════════════════════════════"
}

# ─── Main ───────────────────────────────────────────────────────────

main() {
    RUN_START=$(date '+%Y-%m-%d %H:%M:%S')
    echo "=== HighBarV2 Test Runner ==="
    echo "Category: ${CATEGORY}"
    echo "Started: ${RUN_START}"

    # Handle graphical mode separately
    if $GRAPHICAL; then
        if [ -z "${DISPLAY:-}" ]; then
            echo "ERROR: --graphical requires a display (DISPLAY env var not set)."
            echo "Use headless mode instead: ./tests/run-all.sh"
            exit 1
        fi
        detect_engine || true
        echo "Launching graphical test mode..."
        bash "${SCRIPT_DIR}/fixtures/start-live.sh" "/tmp/highbar-graphical-$$.sock" "/tmp/highbar-graphical-$$.pid" ""
        echo "Graphical session ended."
        generate_report
        exit 0
    fi

    # ── Non-engine tiers ──

    if should_run "proxy"; then
        if [ -d "${REPO_ROOT}/build" ]; then
            run_tier "proxy" "C Proxy Tests (ctest)" bash -c "cd '${REPO_ROOT}/build' && ctest --output-on-failure 2>&1"
        else
            skip_tier "proxy" "C Proxy Tests (ctest)" "build/ directory not found — run cmake first"
        fi
    fi

    if should_run "unit"; then
        if [ -f "${REPO_ROOT}/tests/unit/fsharp/HighBar.Unit.Tests.fsproj" ]; then
            run_tier "unit" "F# Unit Tests" dotnet test "${REPO_ROOT}/tests/unit/fsharp/" --verbosity quiet
        else
            skip_tier "unit" "F# Unit Tests" "tests/unit/fsharp/ not found"
        fi
    fi

    if should_run "data"; then
        if [ -f "${REPO_ROOT}/data/bar.tests/BarData.Tests.fsproj" ]; then
            run_tier "data" "BarData Tests" dotnet test "${REPO_ROOT}/data/bar.tests/" --verbosity quiet
        else
            skip_tier "data" "BarData Tests" "data/bar.tests/ not found"
        fi
    fi

    # ── Engine-dependent tiers ──

    local engine_tiers_requested=false
    for t in integration persistent ai; do
        should_run "$t" && engine_tiers_requested=true
    done

    if $engine_tiers_requested; then
        echo ""
        echo "━━━ Engine Prerequisites ━━━"
        check_engine_prereqs
        if $ENGINE_AVAILABLE; then
            echo "  ✓ Engine available: ${RESOLVED_ENGINE}"
        else
            echo "  ⚠ Engine prerequisites not met — engine-dependent tests will be skipped"
        fi
    fi

    if should_run "integration"; then
        if $ENGINE_AVAILABLE; then
            run_tier "integration" "F# Integration Tests" dotnet test "${REPO_ROOT}/tests/integration/fsharp/" --verbosity quiet
        else
            skip_tier "integration" "F# Integration Tests" "Engine prerequisites not met"
        fi
    fi

    if should_run "persistent"; then
        if $ENGINE_AVAILABLE; then
            run_tier "persistent" "F# Persistent Tests" dotnet test "${REPO_ROOT}/tests/persistent/fsharp/" --verbosity quiet
        else
            skip_tier "persistent" "F# Persistent Tests" "Engine prerequisites not met"
        fi
    fi

    if should_run "ai"; then
        if $ENGINE_AVAILABLE; then
            run_tier "ai" "AI Validation Tests" dotnet test "${REPO_ROOT}/tests/ai/fsharp/" --verbosity quiet
        else
            skip_tier "ai" "AI Validation Tests" "Engine prerequisites not met"
        fi
    fi

    # ── Summary & Report ──

    generate_report
    print_summary

    # Exit with failure if any tier failed
    for tier in "${!TIER_STATUS[@]}"; do
        if [ "${TIER_STATUS[$tier]}" = "fail" ]; then
            exit 1
        fi
    done
    exit 0
}

main
