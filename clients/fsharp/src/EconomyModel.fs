namespace HighBar.Client

/// Tracks resource state and flow.
type EconomyModel = {
    mutable MetalCurrent: float32
    mutable MetalIncome: float32
    mutable MetalUsage: float32
    mutable MetalStorage: float32
    mutable EnergyCurrent: float32
    mutable EnergyIncome: float32
    mutable EnergyUsage: float32
    mutable EnergyStorage: float32
}

module EconomyModel =
    let create () = {
        MetalCurrent = 0.0f; MetalIncome = 0.0f; MetalUsage = 0.0f; MetalStorage = 0.0f
        EnergyCurrent = 0.0f; EnergyIncome = 0.0f; EnergyUsage = 0.0f; EnergyStorage = 0.0f
    }

    let isMetalStalled (eco: EconomyModel) =
        eco.MetalCurrent <= 1.0f && eco.MetalUsage > eco.MetalIncome

    let isEnergyStalled (eco: EconomyModel) =
        eco.EnergyCurrent <= 1.0f && eco.EnergyUsage > eco.EnergyIncome

    let metalSurplus (eco: EconomyModel) = eco.MetalIncome - eco.MetalUsage
    let energySurplus (eco: EconomyModel) = eco.EnergyIncome - eco.EnergyUsage

    /// Query economy callbacks and update the model.
    let update (client: HighBarClient) (eco: EconomyModel) =
        // Resource IDs: 0 = metal, 1 = energy
        eco.MetalCurrent <- client.GetEconomyCurrent(0)
        eco.MetalIncome <- client.GetEconomyIncome(0)
        eco.MetalUsage <- client.GetEconomyUsage(0)
        eco.MetalStorage <- client.GetEconomyStorage(0)
        eco.EnergyCurrent <- client.GetEconomyCurrent(1)
        eco.EnergyIncome <- client.GetEconomyIncome(1)
        eco.EnergyUsage <- client.GetEconomyUsage(1)
        eco.EnergyStorage <- client.GetEconomyStorage(1)
