# Quickstart: Reproducing the 035 Research

**Feature**: 035-research-dispatch-paths
**Audience**: A reviewer or successor engineer who wants to (a) verify citations in `findings.md`, (b) re-run the live probes, or (c) extend the research.

---

## 1. Resolve the pinned SHAs

```bash
# Recoil (authoritative — matches shipping binary)
git ls-remote --tags https://github.com/beyond-all-reason/RecoilEngine 2025.06.19
# Record the 40-char SHA; compare to the SHA at the top of findings.md.

# Shipping CircuitAI (binary present on this machine)
ls ~/.local/state/Beyond\ All\ Reason/engine/recoil_2025.06.19/AI/Skirmish/CircuitAI/
cat ~/.local/state/Beyond\ All\ Reason/engine/recoil_2025.06.19/AI/Skirmish/CircuitAI/*/AIInfo.lua 2>/dev/null | grep -iE 'version|url|fork'
# Resolve the corresponding source SHA in rlcevg/CircuitAI or beyond-all-reason's fork.

# BARb archive
ls ~/.local/state/Beyond\ All\ Reason/packages/ | grep -i bar
# sha256sum the relevant .sdz/.sdp; compare to findings.md top matter.
```

## 2. Fetch a cited Recoil source excerpt

```bash
# Template — substitute the resolved SHA and the file:line from findings.md.
SHA=<recoil-sha-from-findings>
curl -s "https://raw.githubusercontent.com/beyond-all-reason/RecoilEngine/${SHA}/rts/ExternalAI/SSkirmishAICallbackImpl.cpp" \
  | sed -n '<LINE-10>,<LINE+30>p'
```

Compare byte-for-byte against the quoted excerpt in `findings.md`.

## 3. Extract BARb Lua sources

```bash
# .sdz (zip)
BARB=~/.local/state/Beyond\ All\ Reason/packages/<barb>.sdz
unzip -l "$BARB" | grep -iE 'LuaAI|GiveOrder'
unzip -p "$BARB" LuaAI/BARb/<file>.lua

# .sdp (rapid pool) — files are content-addressed; use the rapid index
# or pr-downloader's extract tooling.
```

If BARb is unavailable, `findings.md` should cite the documented fallback (per research.md Decision 4).

## 4. Re-run a live probe (FR-015)

A "live probe" resolves a single field in the dispatch and asserts an engine-observable effect.

```bash
./tests/check-prerequisites.sh
./tests/run-all.sh --category persistent
# Or the specific probe project:
dotnet test tests/Persistent/<probe-project>
```

Inspect the produced `engine.infolog` under `/tmp/highbar-session-*/`:

```bash
grep -E 'Nanoframe|AI command|rc=' /tmp/highbar-session-*/engine.infolog | tail -40
```

The quoted infolog line in `findings.md` §6 (hypothesis with a live-verdict) MUST match an actual line here after a clean run.

## 5. Verify the outcome artefacts

### Outcome (a) — fix shipped

```bash
# Commit series shows pre-fix failure and post-fix success.
git log --oneline master..035-research-dispatch-paths

# The regression test fails when reverted:
git revert <fix-commit> --no-commit
./tests/run-all.sh --category persistent   # expect failure
git revert --abort

# HighBar.Client version bumped:
grep -E '<Version>' clients/fsharp/src/HighBar.Client.fsproj

# Mailbox reply present:
ls Mailbox/2026-04-*_to_FSBarV1_*.md
```

### Outcome (b) / (c) — docs only (+ optional FR-014 cleanup)

```bash
# Non-spec, non-mailbox diff must be empty OR only FR-014 cleanup:
git diff master..035-research-dispatch-paths -- . \
  ':(exclude)specs/035-research-dispatch-paths/' \
  ':(exclude)Mailbox/'
```

If non-empty, the diff should contain only `clients/fsharp/src/Commands.fs` (INTERNAL_ORDER removal) and the `HighBar.Client.fsproj` version bump — matching FR-014.

## 6. Apply the contract checklist

Open `specs/035-research-dispatch-paths/contracts/findings.contract.md` and tick each C-* item against `findings.md`. Any unchecked box is a PR blocker.

---

## Time expectations

- Steps 1–3 (citation verification): ~10 min.
- Step 4 (one live probe): ~5 min per variant.
- Step 5 (outcome verification): ~5 min.
- Step 6 (contract walkthrough): ~15 min.

Total for a full verification pass: ~45 minutes. Matches SC-001 "15 minutes to answer the dispatch question" plus overhead for probe reproduction.
