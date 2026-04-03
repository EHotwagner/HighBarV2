namespace BarData

/// Shared summary record for indexing and capability queries across all units.
type UnitSummary =
    { name: string
      subfolder: string
      metalCost: ValueOrExpr<float>
      energyCost: ValueOrExpr<float>
      health: ValueOrExpr<float>
      isBuilder: bool
      isArmed: bool
      isMobile: bool
      canFly: bool
      hasEconomy: bool
      isBuilding: bool }
