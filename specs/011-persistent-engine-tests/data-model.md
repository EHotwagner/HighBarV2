# Data Model: Persistent Engine Test Suite

## Entities

### PersistentEngineFixture

The long-lived test fixture managing engine lifecycle for the entire suite run.

| Field | Type | Description |
|-------|------|-------------|
| Client | HighBarClient | Shared client connection to engine |
| SocketPath | string | Unix domain socket path (GUID-based) |
| EngineProcess | Process | The single engine process |
| SessionDir | string | Temp directory for logs/diagnostics |
| IsEngineAlive | bool | Health check flag |
| BaselineResourceMetal | float32 | Expected metal after reset |
| BaselineResourceEnergy | float32 | Expected energy after reset |

**Lifecycle**: Created once at suite start (InitializeAsync), destroyed once at suite end (DisposeAsync). Never recreated between tests.

### ResetState

Represents the expected clean state after a reset cycle.

| Field | Type | Description |
|-------|------|-------------|
| ExpectedUnitCount | int | Number of units expected post-reset (0 or commander-only) |
| MetalAmount | float32 | Baseline metal level |
| EnergyAmount | float32 | Baseline energy level |
| VerificationFrames | int | Frames to wait for reset to take effect |

### TestTier

Logical grouping for execution ordering.

| Tier | Name | Purpose |
|------|------|---------|
| T0 | Smoke | Validate reset mechanism and engine health |
| T1 | Spawn | Unit creation via cheat commands |
| T2 | Movement | Unit movement and position verification |
| T3 | Build | Construction and UnitCreated events |
| T4 | Combat | Damage, destruction, LOS events |
| T5 | Scenario | Multi-step AI sequences |

## State Transitions

```
Suite Start → Engine Running → [Test N] → Reset → [Test N+1] → ... → Engine Shutdown
                                  ↓
                            Engine Crashed → Skip Remaining → Diagnostic Output
```

## Relationships

- PersistentEngineFixture 1:1 HighBarClient (existing type, no modification)
- PersistentEngineFixture 1:N TestTier (fixture shared across all tiers)
- Each test implicitly depends on ResetState being valid before execution
