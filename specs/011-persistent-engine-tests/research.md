# Research: Persistent Engine Test Suite

## R1: Cheat-Based Game State Reset

**Decision**: Use `CallLuaRulesCommand` for unit destruction and `GiveMeResourceCommand` for resource reset.

**Rationale**: The Spring engine exposes `Spring.DestroyUnit(unitId)` through its Lua rules API. Combined with `GiveMeResourceCommand` (which can set negative amounts to drain resources), these two commands provide a complete reset mechanism without engine modifications.

**Reset sequence**:
1. `CallLuaRulesCommand` with Lua code to iterate and destroy all units for the AI's team
2. `GiveMeResourceCommand` with negative amounts to zero out accumulated resources
3. `GiveMeResourceCommand` with positive amounts to set baseline resource levels
4. Wait a few frames for the engine to process all destructions

**Alternatives considered**:
- `SendTextMessageCommand` with console commands: Uncertain whether engine chat commands work through the AI interface; not testable without engine documentation.
- `SelfDestructCommand` per unit: Requires tracking all unit IDs; self-destruct has a delay and produces wreckage; not a clean reset.

## R2: xUnit Fixture Strategy for Persistent Engine

**Decision**: Create a new test project with a single xUnit collection fixture. All test classes join the same collection.

**Rationale**: xUnit's `ICollectionFixture<T>` pattern already used in the existing integration tests shares one fixture across all classes in the collection. The fixture calls `InitializeAsync` once (engine startup) and `DisposeAsync` once (engine shutdown). Between tests, a reset helper is called explicitly.

**Key implementation detail**: xUnit serializes all tests within a collection (runs them one at a time), which is exactly what we need since the tests share a single engine connection.

**Alternatives considered**:
- Adding tests to the existing integration project: Risk of interference with existing test lifecycle. The existing harness expects warm-up buffering which may not work after resets. Clean separation is safer.
- Assembly-level fixture (`IAssemblyFixture`): Not available in standard xUnit 2.x without extensions.

## R3: Test Ordering

**Decision**: Use xUnit `ITestCaseOrderer` with a priority attribute to enforce execution order within classes, and alphabetical class naming (prefixed with tier number) to enforce cross-class ordering.

**Rationale**: xUnit does not provide a built-in cross-collection ordering mechanism. However, within a single collection, test classes run in declaration order (F# compile order in .fsproj). By controlling the `<Compile>` order in the project file and using a priority attribute within classes, we get fully deterministic ordering.

**Ordering scheme**:
- File compile order in .fsproj: `T0_SmokeTests.fs` → `T1_SpawnTests.fs` → `T2_MovementTests.fs` → `T3_BuildTests.fs` → `T4_CombatTests.fs` → `T5_ScenarioTests.fs`
- Within each file: `[<Priority(N)>]` attribute on test methods

**Alternatives considered**:
- Custom `ITestCollectionOrderer`: More complex, requires implementing orderer class. Not needed when compile order suffices.
- Single test class with all tests: Loses logical grouping; harder to maintain.

## R4: Separate Test Project vs Existing

**Decision**: Create a new test project `tests/persistent/fsharp/HighBar.PersistentTests.fsproj` separate from the existing integration tests.

**Rationale**: The persistent engine suite has fundamentally different lifecycle semantics (no restart, cheat-based reset) compared to the existing integration tests (engine restart per fixture). Mixing them in one project would create confusing fixture interactions. A separate project also allows independent execution via `dotnet test`.

**Alternatives considered**:
- Same project, different collection: Risk of xUnit running both collections' fixtures concurrently and starting two engines. Separate projects avoid this entirely.

## R5: Reset Verification Strategy

**Decision**: After each reset, run a brief verification frame loop (5-10 frames) to confirm no leftover units and resources are at baseline before proceeding with the next test.

**Rationale**: Cheat commands are processed asynchronously by the engine. A few frames of delay ensures the engine has fully processed all destruction commands before the next test begins. The verification step catches partial resets early rather than producing confusing test failures downstream.

**Alternatives considered**:
- Fixed frame delay without verification: Simpler but fragile; if the engine is slow to process, tests may still see stale state.
- Retry loop with timeout: Over-engineered for this use case; a fixed small delay should suffice.
