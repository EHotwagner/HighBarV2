namespace HighBar.Tests

open Xunit
open HighBar.Client

/// T008: Pure unit tests for the GameStateSnapshot F# types and fromProto
/// converter. No live engine required — exercises the wire → record mapping
/// and the "radar-only has no Health" structural contract (Decision 4).
module GameStateSnapshotUnitTests =

    [<Fact>]
    let ``fromProto maps friendlies, los, radar-only, economy correctly`` () =
        let p = Highbar.GameStateSnapshot()
        p.Frame <- 42

        let fpos = Highbar.Vector3(X = 1.0f, Y = 2.0f, Z = 3.0f)
        let f = Highbar.FriendlyUnit(UnitId = 10, Position = fpos, Health = 100.0f, UnitDefId = 5, Team = 0)
        p.Friendlies.Add(f)

        let lpos = Highbar.Vector3(X = 10.0f, Y = 20.0f, Z = 30.0f)
        let los = Highbar.LosEnemyUnit(UnitId = 20, Position = lpos, Health = 200.0f, UnitDefId = 6, Team = 1)
        p.LosEnemies.Add(los)

        let rpos = Highbar.Vector3(X = 100.0f, Y = 200.0f, Z = 300.0f)
        let rad = Highbar.RadarOnlyEnemyUnit(UnitId = 30, Position = rpos, UnitDefId = 7, Team = 1)
        p.RadarOnlyEnemies.Add(rad)

        let econ = Highbar.EconomyRecord(
            MetalCurrent = 500.0f, MetalIncome = 10.0f, MetalUsage = 5.0f, MetalStorage = 1000.0f,
            EnergyCurrent = 800.0f, EnergyIncome = 20.0f, EnergyUsage = 8.0f, EnergyStorage = 2000.0f)
        p.Economy <- econ

        let snap = GameStateSnapshot.fromProto p

        Assert.Equal(42, snap.Frame)
        Assert.Equal(1, snap.Friendlies.Length)
        Assert.Equal(10, snap.Friendlies.[0].UnitId)
        Assert.Equal(100.0f, snap.Friendlies.[0].Health)
        Assert.Equal(1, snap.LosEnemies.Length)
        Assert.Equal(200.0f, snap.LosEnemies.[0].Health)
        Assert.Equal(1, snap.RadarOnlyEnemies.Length)
        Assert.Equal(30, snap.RadarOnlyEnemies.[0].UnitId)
        Assert.Equal(500.0f, snap.Economy.MetalCurrent)
        Assert.Equal(2000.0f, snap.Economy.EnergyStorage)

    /// Structural "no Health" contract: RadarOnlyEnemyUnit must have no Health
    /// member exposed at the type level. Verified via reflection — if someone
    /// adds a Health field, this test fails.
    [<Fact>]
    let ``RadarOnlyEnemyUnit has no Health field`` () =
        let t = typeof<RadarOnlyEnemyUnit>
        let hasHealth =
            Microsoft.FSharp.Reflection.FSharpType.GetRecordFields(t)
            |> Array.exists (fun p -> p.Name = "Health")
        Assert.False(hasHealth, "RadarOnlyEnemyUnit must not expose a Health field")

    /// By contrast, LosEnemyUnit and FriendlyUnit MUST expose Health.
    [<Fact>]
    let ``LosEnemyUnit and FriendlyUnit expose Health`` () =
        let hasHealth (t: System.Type) =
            Microsoft.FSharp.Reflection.FSharpType.GetRecordFields(t)
            |> Array.exists (fun p -> p.Name = "Health")
        Assert.True(hasHealth typeof<FriendlyUnit>)
        Assert.True(hasHealth typeof<LosEnemyUnit>)
