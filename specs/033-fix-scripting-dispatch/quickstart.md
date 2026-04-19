# Quickstart — Reproducing & Verifying the Scripting Dispatch Fix

**Feature**: 033-fix-scripting-dispatch

## Prerequisites

```bash
./tests/check-prerequisites.sh   # confirms BAR install + headless engine
```

## 1. Compare bundled-proxy SHA (Q1 from research)

```bash
# In HighBarV2:
cd /home/developer/projects/HighBarV2
cmake -B build -DCMAKE_BUILD_TYPE=Release -S proxy && cmake --build build
sha256sum build/libhighbar.so

# In FSBarV1:
grep -E '(SHA|hash|checksum)' /home/developer/projects/FSBarV1/src/FSBar.Hub/BundledProxy.fs
```

If the SHAs differ: bump the FSBarV1 bundle and re-run the Python repro before any further work — the fix may already be in `master`.

## 2. Build proxy with always-on dispatch logging

After the proxy/src changes from FR-002/003 land:

```bash
cmake --build build
ls -la build/libhighbar.so   # post-build script auto-deploys to engine AI dir
```

## 3. Run the new HighBarV2 regression test

```bash
./tests/run-all.sh --category persistent --filter ScriptingDispatchTests
```

Expected output: a single `[HB] dispatch frame=<n> case=BUILD_UNIT unit=<id> engine_rc=0` line in the proxy log, and the test's `GameStateSnapshot` poll observes a new friendly armmex within 1500 frames.

## 4. End-to-end verification with FSBarV1 Python repro

```bash
cd /home/developer/projects/FSBarV1
XDG_RUNTIME_DIR=/tmp/runtime-developer DISPLAY=:0 \
  dotnet run --project src/FSBar.Hub.App &

# Once "gRPC scripting service listening on http://127.0.0.1:5021":
cd scripts/examples/python
.venv/bin/python diag_one_build.py
```

Expected `diag_one_build.py` tail:

```
[order] SendCommand unary → forwarded_at_frame=76 ...
f=76 friendlies=[(25947, 49, True, False, '500,397')]
...
f=~150 friendlies=[(25947, 49, True, False, '...'), (NEW, 77, ..., ...)]
```

Expected proxy log tail (in the engine infolog):

```
[HB] dispatch frame=76 case=BUILD_UNIT unit=25947 engine_rc=0
```

Run 3× to satisfy SC-001.

## 5. Answer the `BuildPosition.Y` question (Q4)

A small CTest harness (added under `proxy/tests/test_dispatch_y.c`) issues two synthetic build orders against the live engine — one with the mailbox's Y=1989, one with Y from `Map_getElevationAt`. Compare `engine_rc` and resulting `GameStateSnapshot`. Document the conclusion in the eventual mailbox reply.

```bash
cd build && ctest -R dispatch_y -V
```

## 6. Mailbox reply

Once SC-001 through SC-004 pass:

```bash
# Edit Mailbox/2026-04-19_to_FSBarV1_scripting-dispatch-fixed.md with:
# - Root cause (one paragraph)
# - HighBar.Client / proxy version that contains the fix
# - The Y answer
# - Pointer to the new regression test
```

## Rollback

The dispatch logging change is observability-only and safe. If a behavioural fix turns out to regress trainer scenarios, revert the single feature commit (`033-*`) and the proxy returns to the pre-fix state. No protocol or schema changes — no client recompiles required for rollback.
