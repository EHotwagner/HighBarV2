# Feature Specification: Remove Python and Upgrade to .NET 10

**Feature Branch**: `019-remove-python-dotnet10`  
**Created**: 2026-04-04  
**Status**: Draft  
**Input**: User description: "remove all python parts and references and upgrade to dotnet10"

## User Scenarios & Testing *(mandatory)*

### User Story 1 - Remove Python Client and Tests (Priority: P1)

A developer working on the HighBarV2 project should find no Python code, configuration, or test infrastructure remaining in the repository. The Python client library, Python integration tests, Python scripts, and all references to Python tooling (betterproto, pytest, pip) are fully removed. The project is F#/.NET and C only.

**Why this priority**: Eliminating dead code and an unused secondary language reduces maintenance burden, simplifies onboarding, and removes confusion about which client is canonical.

**Independent Test**: After removal, searching the entire repository for Python-specific artifacts (`.py` files, `pyproject.toml`, pytest references, betterproto references, Python mentions in build/test scripts) returns zero results. The remaining F# and C test suites pass without modification.

**Acceptance Scenarios**:

1. **Given** the repository contains `clients/python/` directory, **When** the removal is complete, **Then** the `clients/python/` directory no longer exists
2. **Given** the test runner (`tests/run-all.sh`) includes a "python" test category, **When** the removal is complete, **Then** the python category is removed and the script runs only F# and C test categories
3. **Given** Python integration tests exist under `tests/integration/python/`, **When** the removal is complete, **Then** the `tests/integration/python/` directory no longer exists
4. **Given** standalone Python scripts exist (e.g., `scripts/patch-chobby-ai.py`), **When** the removal is complete, **Then** they are either removed or rewritten in an existing project language
5. **Given** `proto/buf.gen.yaml` contains betterproto generation config, **When** the removal is complete, **Then** the betterproto plugin entry is removed
6. **Given** documentation (CLAUDE.md, spec files) references Python, **When** the removal is complete, **Then** all Python references are removed or updated

---

### User Story 2 - Upgrade F# Projects to .NET 10 (Priority: P1)

A developer building any F# project in the repository uses .NET 10 as the target framework. All project files, build scripts, and CI configuration reflect the .NET 10 target. The codebase compiles and all tests pass under .NET 10.

**Why this priority**: Upgrading to the latest .NET LTS release ensures access to current language features, performance improvements, and continued support.

**Independent Test**: After upgrading, running `dotnet build` on every F# project succeeds with `net10.0` as the target framework. Running all F# tests via `dotnet test` passes. No references to `net8.0` remain in project files.

**Acceptance Scenarios**:

1. **Given** F# project files target `net8.0`, **When** the upgrade is complete, **Then** all `.fsproj` files target `net10.0`
2. **Given** the build instructions reference .NET 8.0, **When** the upgrade is complete, **Then** all documentation references are updated to .NET 10
3. **Given** the project has NuGet package dependencies, **When** the upgrade is complete, **Then** all packages are compatible with .NET 10 and updated if necessary
4. **Given** the .NET 10 SDK is installed, **When** a developer runs `dotnet build` on any project, **Then** the build succeeds without warnings related to framework targeting

---

### User Story 3 - Update Project Documentation (Priority: P2)

All project documentation accurately reflects the new state: F#/.NET 10 and C only, with no Python references. A new developer reading the docs gets an accurate picture of the technology stack.

**Why this priority**: Documentation accuracy prevents confusion but is secondary to the actual code changes.

**Independent Test**: Reading CLAUDE.md, README files, and spec references shows only F#/.NET 10 and C as project languages. No mentions of Python, betterproto, pytest, or pip remain in active documentation.

**Acceptance Scenarios**:

1. **Given** CLAUDE.md lists Python 3.10+ as a secondary language, **When** the update is complete, **Then** Python is no longer listed as a project language
2. **Given** the Commands section references pip and pytest, **When** the update is complete, **Then** those references are removed
3. **Given** the Active Technologies section mentions betterproto, **When** the update is complete, **Then** betterproto is no longer mentioned
4. **Given** .NET 8.0 is referenced throughout documentation, **When** the update is complete, **Then** all references say .NET 10

---

### Edge Cases

- What happens if a Python script (e.g., `patch-chobby-ai.py`) has no equivalent in F# or Bash? It must be rewritten or its functionality documented as removed.
- What happens if a NuGet package is not yet compatible with .NET 10? The incompatible package must be identified and either updated, replaced, or pinned with a compatibility note.
- What happens if `buf.gen.yaml` betterproto removal breaks the proto generation pipeline? The remaining F# and C generation targets must still work correctly.
- What happens if test fixture files reference Python (e.g., `tests/fixtures/dummy-client.py`)? All Python fixture files are removed and any tests depending on them are updated.

## Requirements *(mandatory)*

### Functional Requirements

- **FR-001**: All Python source files (`.py`) MUST be removed from the repository
- **FR-002**: The `clients/python/` directory and all its contents MUST be deleted
- **FR-003**: The `tests/integration/python/` directory and all its contents MUST be deleted
- **FR-004**: All Python test fixtures (e.g., `tests/fixtures/dummy-client.py`) MUST be removed
- **FR-005**: The test runner script (`tests/run-all.sh`) MUST remove the "python" test category and all pytest invocations
- **FR-006**: The `proto/buf.gen.yaml` MUST remove the betterproto plugin configuration
- **FR-007**: All standalone Python scripts MUST be removed or rewritten in Bash or F#
- **FR-008**: All `.fsproj` files MUST target `net10.0` instead of `net8.0`
- **FR-009**: All documentation MUST be updated to remove Python references and reflect .NET 10
- **FR-010**: The F# codebase MUST build successfully under .NET 10
- **FR-011**: All F# and C tests MUST pass after the changes
- **FR-012**: References to Python in shell scripts (e.g., `setup-engine.sh`, `install-ai.sh`) MUST be removed or updated

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: Zero `.py` files exist anywhere in the repository
- **SC-002**: Zero references to "python", "pytest", "betterproto", or "pip" remain in active scripts and configuration files
- **SC-003**: All F# projects build successfully targeting `net10.0`
- **SC-004**: All existing F# and C tests pass without regression
- **SC-005**: A full-text search for "net8.0" in project files (`.fsproj`, `.md`, `.sh`) returns zero results
- **SC-006**: The unified test runner (`tests/run-all.sh`) executes successfully with only F# and C test categories

## Assumptions

- .NET 10 SDK is available and installed in the development environment
- All current NuGet package dependencies have .NET 10-compatible versions
- The Python client was a secondary/unused client; no external systems depend on it
- The `patch-chobby-ai.py` script can be rewritten in Bash or its functionality is no longer needed
- Historical spec files (in `specs/` subdirectories) will have Python references removed from their technology sections but their content will otherwise be preserved
- Proto generation for F# and C continues to work after removing the betterproto plugin from `buf.gen.yaml`
