# Quickstart: Repository Cleanup

**Feature**: 020-repo-cleanup | **Date**: 2026-04-04

## Prerequisites

- Git (for file removal and committing)
- Text editor (for markdown edits)
- Working knowledge of the repository structure

## Execution Order

### Step 1: Remove spec artifacts from completed features

```bash
# Remove research.md, data-model.md, quickstart.md from features 001-019
for i in $(seq -w 1 19); do
  dir="specs/0${i}-"*
  rm -f ${dir}/research.md ${dir}/data-model.md ${dir}/quickstart.md
done

# Remove contract directories from features that have them
rm -rf specs/001-*/contracts/ specs/004-*/contracts/ specs/013-*/contracts/ specs/018-*/contracts/

# Remove test-report.md from feature 003
rm -f specs/003-*/test-report.md

# Remove checklists from completed features
for i in $(seq -w 1 19); do
  dir="specs/0${i}-"*
  rm -rf ${dir}/checklists/
done
```

### Step 2: Remove stale report

```bash
git rm reports/006-python-tests.md
```

### Step 3: Edit stale reports (manual — see data-model.md for line references)

Edit these files to remove Python references:
1. `reports/007-test-suite-overview.md`
2. `reports/009-live-engine-integration.md`
3. `reports/010-remaining-test-failures.md`
4. `reports/011-test-fix-results.md`
5. `reports/013-diagnose-fix-test-gaps.md`
6. `reports/README.md`

### Step 4: Edit stale documentation

1. `docs/bar-data-reference.md` — Remove Python Client Bindings section
2. `docs/research/05-architecture-spec.md` — Add removal note
3. `docs/research/07-implementation-roadmap.md` — Add removal note
4. `tests/README.md` — Remove Python test references

### Step 5: Consolidate CLAUDE.md

Replace the per-feature Active Technologies block with a consolidated table.

### Step 6: Clean .gitignore

Remove the `# Python` section (6 entries).

### Step 7: Verify

```bash
# Count tracked spec files (target: ~76)
git ls-files -- specs/ | wc -l

# Check for remaining Python references in active docs
git ls-files -- '*.md' | xargs grep -li 'python' --include='*.md'

# Verify builds still work
cmake -B build -DCMAKE_BUILD_TYPE=Release proxy/ && cmake --build build
cd clients/fsharp && dotnet build && cd ../..
```

## Rollback

All changes are file deletions and markdown edits tracked in git. Rollback via:

```bash
git checkout master -- <any-file>
```

Or revert the entire feature branch merge.
