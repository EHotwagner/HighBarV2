# Feature Specification: Repository Cleanup

**Feature Branch**: `020-repo-cleanup`  
**Created**: 2026-04-04  
**Status**: Draft  
**Input**: User description: "clean up the repository. search for out of date code/documentation. unused items. create a clean and lean structure."

## User Scenarios & Testing *(mandatory)*

### User Story 1 - Remove Outdated Documentation (Priority: P1)

A developer opens the repository and finds only accurate, current documentation. Reports that reference removed components (e.g., Python client removed in feature 019) are either updated or archived, so no one follows stale instructions.

**Why this priority**: Outdated docs actively mislead developers — they waste time following dead-end instructions and erode trust in the repository's documentation.

**Independent Test**: Review every tracked markdown file for references to removed components (Python client, pre-.NET 10 targets). Confirm no stale instructions remain.

**Acceptance Scenarios**:

1. **Given** the Python client was removed in feature 019, **When** a developer reads any report or doc, **Then** they find no instructions to install, configure, or run Python-based tests
2. **Given** all projects now target .NET 10.0, **When** a developer reads CLAUDE.md or project docs, **Then** they see only current technology references without duplicated or contradictory entries

---

### User Story 2 - Consolidate CLAUDE.md (Priority: P1)

A developer reads CLAUDE.md and finds a concise, non-repetitive summary of the project's technologies, structure, and commands. The "Active Technologies" section lists each technology once rather than repeating it per-feature.

**Why this priority**: CLAUDE.md is the primary onboarding document and AI context file. Its current format lists every feature's tech stack separately, creating 40+ redundant bullet points that obscure the actual technology footprint.

**Independent Test**: Compare the current CLAUDE.md (40+ technology lines) against a consolidated version. Verify that every unique technology is still represented and no feature-specific duplication remains.

**Acceptance Scenarios**:

1. **Given** the current CLAUDE.md has duplicate technology entries per feature, **When** CLAUDE.md is consolidated, **Then** each technology appears at most once with its purpose
2. **Given** CLAUDE.md lists commands and project structure, **When** a developer reads it, **Then** they can build and test the project without consulting other files

---

### User Story 3 - Archive Completed Spec Artifacts (Priority: P2)

A developer browsing the specs/ directory can quickly distinguish active/in-progress features from completed historical ones. Completed features have their verbose planning artifacts (research notes, data models, quickstarts) consolidated or archived so the specs/ directory is leaner.

**Why this priority**: 139 files across 19 completed specs create noise. Active development doesn't need quick-start guides or research notes for features shipped months ago.

**Independent Test**: Count files in specs/ before and after cleanup. Verify that essential artifacts (spec.md, plan.md, tasks.md) are preserved for all features while verbose artifacts are consolidated.

**Acceptance Scenarios**:

1. **Given** 19 completed features each have 6-9 files, **When** completed spec artifacts are consolidated, **Then** each completed feature retains spec.md (as the authoritative record) and optionally plan.md
2. **Given** the specs/ directory previously held 139+ files, **When** cleanup is complete, **Then** the file count is reduced by at least 40%

---

### User Story 4 - Clean Up Stale Report Content (Priority: P2)

A developer reading the reports/ directory finds that each report accurately reflects the current state of the project. Reports about removed functionality are clearly marked as historical or removed.

**Why this priority**: Report 006 documents Python client tests that no longer exist. Multiple other reports reference Python. These create confusion about what's current.

**Independent Test**: Audit all 16 tracked reports for references to removed components. Confirm each report is either current or clearly marked as historical.

**Acceptance Scenarios**:

1. **Given** report 006 documents Python tests removed in feature 019, **When** reports are cleaned up, **Then** report 006 is either removed or clearly marked as historical
2. **Given** 8 reports reference Python, **When** cleanup is complete, **Then** remaining reports either have Python references removed (if incidental) or are marked historical (if Python was the primary subject)

---

### User Story 5 - Streamline Repository Root Structure (Priority: P3)

A new contributor cloning the repository sees a clean, logical top-level layout with no orphaned files, unnecessary directories, or unclear purpose items.

**Why this priority**: The current structure is already fairly clean, but a review pass ensures nothing has drifted as 19 features were developed.

**Independent Test**: List all tracked root-level files and directories. Verify each has a clear purpose and is referenced by at least one active component.

**Acceptance Scenarios**:

1. **Given** the repository has been through 19 feature iterations, **When** the root structure is audited, **Then** every tracked file and directory serves a documented, active purpose
2. **Given** the .gitignore excludes build artifacts, **When** .gitignore is reviewed, **Then** all entries correspond to artifacts that are actually generated by current build processes

---

### Edge Cases

- What happens when a report references both current and removed components (e.g., report 007 covers both Python and F# test suites)?
- How are spec artifacts handled if a future feature needs to reference a completed feature's research or contracts?
- What if consolidating CLAUDE.md removes context that was feature-specific but still relevant?

## Requirements *(mandatory)*

### Functional Requirements

- **FR-001**: CLAUDE.md MUST be consolidated to list each technology, command, and structural element exactly once, eliminating per-feature duplication
- **FR-002**: All reports referencing removed components (Python client) MUST be either updated to remove stale references or clearly marked as historical
- **FR-003**: Completed feature specs MUST retain at minimum their spec.md as a permanent record; verbose artifacts (research.md, data-model.md, quickstart.md) from completed features MAY be removed
- **FR-004**: The .gitignore MUST be reviewed to ensure all entries correspond to artifacts generated by current build processes (no entries for removed tools or workflows)
- **FR-005**: All tracked documentation MUST accurately reflect the current state of the project (no references to Python client, pre-.NET 10 targets, or other removed components)
- **FR-006**: The reports/ TEMPLATE.md and README.md MUST be updated to reflect only current report categories and workflows

### Key Entities

- **Spec Artifact**: A file within a feature's specs/ directory (spec.md, plan.md, tasks.md, research.md, data-model.md, quickstart.md, checklists/, contracts/)
- **Report**: A numbered markdown file in reports/ documenting a completed investigation or test result
- **CLAUDE.md**: The auto-generated project context file used by developers and AI tools for onboarding

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: CLAUDE.md "Active Technologies" section reduced from 40+ lines to 15 or fewer, with no information loss
- **SC-002**: Zero tracked files contain instructions to install, configure, or run the removed Python client without a "historical" marker
- **SC-003**: Total tracked file count in specs/ reduced by at least 40% (from 139 to under 85)
- **SC-004**: A new contributor can understand the project's technology stack, build process, and test commands by reading only CLAUDE.md
- **SC-005**: Every tracked markdown file passes a staleness audit — no references to removed components without historical context

## Assumptions

- All 19 features (001-019) are considered completed and merged; none are in active development
- The speckit tooling (.specify/ directory) is still actively used and should not be cleaned up
- Build artifacts (bin/, obj/, build/) are already excluded by .gitignore and do not need source-level cleanup
- The data/bar/ generated source files are actively used and should not be touched
- Research documents in docs/research/ represent foundational architecture decisions and should be preserved
- Report content is primarily historical reference; removing or archiving stale reports does not break any automated workflows
