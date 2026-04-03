module HighBar.Tests.UnitDataTests

open Xunit
open HighBar.Client
open BarData
open BarData.Units

// ── User Story 1: Access Unit Data from Client Code ──

[<Fact>]
let ``tryFind returns Some for known unit armham with correct metalCost and health`` () =
    let unit = Units.tryFind "armham"
    Assert.True(unit.IsSome, "armham should exist")
    let u = unit.Value
    Assert.Equal(ValueOrExpr.Concrete 130.0, u.metalCost)
    Assert.Equal(ValueOrExpr.Concrete 1000.0, u.health)

[<Fact>]
let ``tryFind returns None for nonexistent unit`` () =
    let unit = Units.tryFind "doesnotexist"
    Assert.True(unit.IsNone, "nonexistent unit should return None")

[<Fact>]
let ``findDef returns Some for known unit armham with correct UnitDef fields`` () =
    let def = Units.findDef "armham"
    Assert.True(def.IsSome, "armham UnitDef should exist")
    let d = def.Value
    Assert.Equal("armham", d.name)
    Assert.Equal(ValueOrExpr.Concrete 130.0, d.metalCost)
    Assert.Equal(ValueOrExpr.Concrete 1000.0, d.health)

[<Fact>]
let ``flat per-unit type ArmBots.armham is accessible and has matching name`` () =
    let u = ArmBots.armham
    Assert.Equal("armham", u.name)

// ── User Story 2: Query Units by Capability ──

[<Fact>]
let ``builders contains known builder armck`` () =
    let found = Units.builders |> List.exists (fun u -> u.name = "armck")
    Assert.True(found, "armck should be in builders list")

[<Fact>]
let ``armedUnits contains known combat unit armham`` () =
    let found = Units.armedUnits |> List.exists (fun u -> u.name = "armham")
    Assert.True(found, "armham should be in armedUnits list")

[<Fact>]
let ``mobileUnits does not contain known building armsolar`` () =
    let found = Units.mobileUnits |> List.exists (fun u -> u.name = "armsolar")
    Assert.False(found, "armsolar should not be in mobileUnits list")

[<Fact>]
let ``combined filter for armed and mobile units from Arm faction returns expected subset`` () =
    let armFighters =
        Units.all
        |> List.filter (fun u -> u.isArmed && u.isMobile && u.subfolder.StartsWith("Arm"))
    Assert.True(armFighters.Length > 0, "should have armed mobile Arm units")
    let hasArmham = armFighters |> List.exists (fun u -> u.name = "armham")
    Assert.True(hasArmham, "armham should be in armed+mobile Arm units")

[<Fact>]
let ``flyingUnits contains known air unit armatlas`` () =
    let found = Units.flyingUnits |> List.exists (fun u -> u.name = "armatlas")
    Assert.True(found, "armatlas should be in flyingUnits list")

[<Fact>]
let ``economyUnits contains known economy building armsolar`` () =
    let found = Units.economyUnits |> List.exists (fun u -> u.name = "armsolar")
    Assert.True(found, "armsolar should be in economyUnits list")

// ── User Story 3: Validate Integration ──

[<Fact>]
let ``all contains exactly 953 entries`` () =
    Assert.Equal(953, Units.all.Length)

[<Fact>]
let ``spot-check Cor faction unit corcom has expected values`` () =
    let unit = Units.tryFind "corcom"
    Assert.True(unit.IsSome, "corcom should exist")
    let u = unit.Value
    Assert.Equal(ValueOrExpr.Concrete 2700.0, u.metalCost)
    Assert.Equal(ValueOrExpr.Concrete 3700.0, u.health)
    Assert.True(u.isBuilder)
    Assert.True(u.isArmed)
    Assert.True(u.isMobile)

[<Fact>]
let ``spot-check Legion faction unit legatrans has expected values`` () =
    let unit = Units.tryFind "legatrans"
    Assert.True(unit.IsSome, "legatrans should exist")
    let u = unit.Value
    Assert.Equal("Legion/Air", u.subfolder)
    Assert.Equal(ValueOrExpr.Concrete 190.0, u.metalCost)
    Assert.Equal(ValueOrExpr.Concrete 800.0, u.health)
    Assert.True(u.canFly)
    Assert.True(u.isMobile)
