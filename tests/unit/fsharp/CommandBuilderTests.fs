namespace HighBar.Unit.Tests

open Xunit
open HighBar.Client
open Highbar

type CommandBuilderTests() =

    [<Fact>]
    member _.``GiveMeNewUnitCommand sets unit_def_id and position``() =
        let cmd = Commands.GiveMeNewUnitCommand 42 1024.0f 200.0f 2048.0f
        let inner = cmd.GiveMeNewUnit
        Assert.NotNull(inner)
        Assert.Equal(42, inner.UnitDefId)
        Assert.NotNull(inner.Position)
        Assert.Equal(1024.0f, inner.Position.X)
        Assert.Equal(200.0f, inner.Position.Y)
        Assert.Equal(2048.0f, inner.Position.Z)

    [<Fact>]
    member _.``GiveMeResourceCommand sets resource_id and amount``() =
        let cmd = Commands.GiveMeResourceCommand 0 500.0f
        let inner = cmd.GiveMe
        Assert.NotNull(inner)
        Assert.Equal(0, inner.ResourceId)
        Assert.Equal(500.0f, inner.Amount)

    [<Fact>]
    member _.``CallLuaRulesCommand sets data field``() =
        let cmd = Commands.CallLuaRulesCommand "spawn_unit armcom 1024 200 2048"
        let inner = cmd.CallLuaRules
        Assert.NotNull(inner)
        Assert.Equal("spawn_unit armcom 1024 200 2048", inner.Data)

    [<Fact>]
    member _.``CallLuaRulesCommand handles empty string``() =
        let cmd = Commands.CallLuaRulesCommand ""
        Assert.Equal("", cmd.CallLuaRules.Data)

    [<Fact>]
    member _.``CallLuaUICommand sets data field``() =
        let cmd = Commands.CallLuaUICommand "show_debug_overlay"
        let inner = cmd.CallLuaUi
        Assert.NotNull(inner)
        Assert.Equal("show_debug_overlay", inner.Data)

    [<Fact>]
    member _.``Cheat builders return AICommand compatible with existing builders``() =
        let commands : AICommand list =
            [ Commands.MoveCommand 1 100.0f 0.0f 100.0f
              Commands.BuildCommand 1 2 200.0f 0.0f 200.0f 0
              Commands.GiveMeResourceCommand 0 1000.0f
              Commands.GiveMeNewUnitCommand 5 512.0f 100.0f 512.0f
              Commands.CallLuaRulesCommand "test"
              Commands.CallLuaUICommand "test" ]
        Assert.Equal(6, commands.Length)
