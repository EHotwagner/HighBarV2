module BarData.Tests.CapabilityTests

open Xunit
open BarData

[<Fact>]
let ``builders includes armck and armcom`` () =
    let builders = AllUnits.builders ()
    let names = builders |> List.map (fun u -> u.name)
    Assert.Contains("armck", names)
    Assert.Contains("armcom", names)

[<Fact>]
let ``builders includes armlab`` () =
    let builders = AllUnits.builders ()
    let names = builders |> List.map (fun u -> u.name)
    Assert.Contains("armlab", names)

[<Fact>]
let ``armed includes armham`` () =
    let armed = AllUnits.armed ()
    let names = armed |> List.map (fun u -> u.name)
    Assert.Contains("armham", names)

[<Fact>]
let ``flying includes armfig`` () =
    let flyers = AllUnits.flying ()
    let names = flyers |> List.map (fun u -> u.name)
    Assert.Contains("armfig", names)

[<Fact>]
let ``flying includes armbrawl`` () =
    let flyers = AllUnits.flying ()
    let names = flyers |> List.map (fun u -> u.name)
    Assert.Contains("armbrawl", names)

[<Fact>]
let ``mobile includes armck but not armsolar`` () =
    let mobiles = AllUnits.mobile ()
    let names = mobiles |> List.map (fun u -> u.name)
    Assert.Contains("armck", names)
    Assert.DoesNotContain("armsolar", names)

[<Fact>]
let ``buildings includes armsolar`` () =
    let bldgs = AllUnits.buildings ()
    let names = bldgs |> List.map (fun u -> u.name)
    Assert.Contains("armsolar", names)

[<Fact>]
let ``buildings includes armlab`` () =
    let bldgs = AllUnits.buildings ()
    let names = bldgs |> List.map (fun u -> u.name)
    Assert.Contains("armlab", names)

[<Fact>]
let ``economy has units`` () =
    let econ = AllUnits.economy ()
    Assert.NotEmpty(econ)
