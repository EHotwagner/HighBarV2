# Research: Integrate BAR Unit Types into F# Client

**Feature**: 009-client-unit-types  
**Date**: 2026-04-03

## Research Tasks

### 1. Integration Pattern: Direct Reference vs Re-export

**Decision**: Direct project reference with a thin convenience module.

**Rationale**: The BAR data library (`BarData.fsproj`) already exposes a clean public API through `AllUnits`, `AllUnitDefs`, and per-subfolder modules. Adding a project reference from `HighBar.Client.fsproj` to `BarData.fsproj` makes all types available to consumers. A thin `Units` module in the client provides convenience functions (lookup by name, filter by capability) without duplicating or wrapping the underlying data.

**Alternatives considered**:
- **Full re-export/wrapper**: Would duplicate the existing API surface with no added value. Rejected because the data library's API is already well-designed.
- **NuGet package**: Premature for an in-repo library. Can be added later if the data library needs independent versioning.
- **Merge into client**: Would bloat the client with 109 generated source files. The separation of concerns (protocol client vs game data) is intentional and correct.

### 2. Test Strategy: New Test File vs New Test Project

**Decision**: Add a new test file (`UnitDataTests.fs`) to the existing `HighBar.Tests.fsproj` integration test project.

**Rationale**: The existing integration test project already references the client. Adding a BarData reference and a new test file keeps tests co-located. A separate test project would add unnecessary build complexity for ~5-10 tests.

**Alternatives considered**:
- **Separate test project**: Overkill for a handful of integration tests. Would require a new .fsproj and add CI build time.
- **Add to BarData.Tests**: Those tests validate the data library in isolation; integration tests belong with the client.

### 3. Module Design: Units.fs API Surface

**Decision**: Single `Units` module exposing:
- `tryFind : string -> UnitSummary option` — lookup by name
- `findDef : string -> UnitDef option` — full definition lookup
- `builders`, `armedUnits`, `mobileUnits`, `flyingUnits`, `economyUnits`, `buildings` — pre-filtered lists
- `all` — full list of UnitSummary records
- Re-export of `BarData.AllUnits` and `BarData.AllUnitDefs` for advanced access

**Rationale**: Follows the existing pattern in `AllUnits.fs` which already provides `tryFind`, `builders`, `armedUnits`, `mobileUnits`. The client module delegates to these directly, adding only the convenience of a single import point within the `HighBar.Client` namespace.

**Alternatives considered**:
- **No convenience module**: Consumers would need `open BarData` and `open BarData.Units.*` directly. Works but loses discoverability within the client namespace.
- **Rich query builder**: Over-engineering for static data; F# list operations already provide powerful filtering.

### 4. Constitution Compliance: Language-Agnostic Principle

**Decision**: Unit data integration is explicitly an F#-specific ergonomic layer, which the constitution allows.

**Rationale**: Principle VI states "Language-specific ergonomics (F# discriminated unions, Python async iterators) belong in a thin typed wrapper above the generated code." The BAR data library is exactly this — typed F# records providing game data. It does not add protocol-level behavior that other languages cannot replicate. The Python client could have its own equivalent data library.

**Alternatives considered**: None needed; the constitution explicitly permits this pattern.
