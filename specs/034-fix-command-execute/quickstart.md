# Quickstart: Reproducing and Validating the 034 Fix

**Feature**: 034-fix-command-execute
**Audience**: Anyone picking this branch up mid-flight, or FSBarV1 consumers verifying the fix landed.

## Prerequisites

- This dev environment (or equivalent): BAR AppImage, spring-headless `2025.06.19`, `~/.local/state/Beyond All Reason/` populated, `cmake`, `protobuf-c`, `buf`, .NET 10 SDK.
- `./tests/check-prerequisites.sh` returns green.
- Working tree on branch `034-fix-command-execute`, rebased on `master` (which includes 033).

## 1. Reproduce the 033 failure mode (baseline)

```bash
# Build and deploy the proxy (unchanged from 033)
cd proto && buf lint && buf generate && cd ..
cmake -B build -DCMAKE_BUILD_TYPE=Release -S proxy && cmake --build build

# Run the FSBarV1 repro (path per your FSBarV1 checkout)
python /path/to/FSBarV1/diag_one_build.py
```

Expected baseline: `[HB] dispatch … engine_rc=0` appears in the engine infolog, but no nanoframe spawns within 1500 frames. This is the 033 failure signature that 034 exists to fix.

## 2. Enable the probe and identify the right convention

```bash
cmake -B build -DCMAKE_BUILD_TYPE=Release -DHB_DISPATCH_PROBE=ON -S proxy \
  && cmake --build build
```

Run `diag_one_build.py` once. Inspect the engine infolog for `[HB] probe …` lines. The convention whose probe invocation correlates with a nanoframe spawn (observed in the infolog's unit-created events) is the winner.

Record the winning row in `data-model.md`'s decision table (in the mailbox reply, not committed to data-model.md).

## 3. Ship the single chosen convention

Edit `proxy/src/proxy.c` (and/or `deserialize.c`) so the per-unit dispatch branch unconditionally uses the winning convention. Delete the `#ifdef HB_DISPATCH_PROBE` block entirely (FR-008). Rebuild **without** the probe flag:

```bash
cmake -B build -DCMAKE_BUILD_TYPE=Release -S proxy && cmake --build build
```

## 4. Validate

```bash
# End-to-end gate (SC-001): must pass 3/3
for i in 1 2 3; do python /path/to/FSBarV1/diag_one_build.py; done

# New persistent regression covering BUILD, MOVE, STOP, REPAIR (SC-003)
./tests/run-all.sh --category persistent

# Regression for team-wide commands (SC-002 / FR-003)
# — included in the persistent run above; confirm zero failures.
```

Every successful command must still show `[HB] dispatch … engine_rc=0` in the infolog (SC-004).

## 5. Ship artefacts

- Bump `HighBar.Client` patch version (FR-006). The engine AI deploy script picks up the rebuilt `.so` automatically.
- Write the mailbox reply at `Mailbox/2026-04-<dd>-034-fix-command-execute.md` using the schema in `contracts/dispatch-log.md` (FR-005, FR-007).
- Commit with Conventional Commits prefixes (`fix:` for the proxy change, `test:` for the new persistent test, `docs:` for the mailbox reply).

## If no candidate wins (Decision 4 fallback)

Do not ship a proxy change. Skip steps 3–5's version bump. Instead, file the mailbox reply with `adopted_convention: none` and a `## Followups` section naming the next hypothesis surface. Leave the branch in a reviewable state documenting the negative result.
