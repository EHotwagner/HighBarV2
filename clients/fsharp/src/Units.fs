namespace HighBar.Client

open BarData

module Units =

    /// All 953 unit summaries.
    let all : UnitSummary list = AllUnits.all

    /// Look up a unit summary by name.
    let tryFind (name: string) : UnitSummary option =
        AllUnits.tryFind name

    /// Look up a full unit definition by name.
    let findDef (name: string) : UnitDef option =
        AllUnitDefs.tryFind name

    /// All builder units.
    let builders : UnitSummary list = AllUnits.builders ()

    /// All armed units.
    let armedUnits : UnitSummary list = AllUnits.armed ()

    /// All mobile units.
    let mobileUnits : UnitSummary list = AllUnits.mobile ()

    /// All flying units.
    let flyingUnits : UnitSummary list = AllUnits.flying ()

    /// All economy units.
    let economyUnits : UnitSummary list = AllUnits.economy ()

    /// All buildings.
    let buildings : UnitSummary list = AllUnits.buildings ()
