namespace BarData

/// Sub-record for mobile units.
type MovementDef =
    { speed: ValueOrExpr<float>
      maxAcc: float
      maxDec: float
      turnRate: float
      movementClass: string option
      maxSlope: float option
      maxWaterDepth: float option
      canFly: bool
      canMove: bool
      floater: bool
      turnInPlace: bool option
      turnInPlaceAngleLimit: float option
      turnInPlaceSpeedLimit: float option
      cruiseAltitude: float option
      minWaterDepth: float option
      waterline: float option }

/// Sub-record for constructors.
type BuilderDef =
    { workerTime: ValueOrExpr<float>
      buildDistance: float option
      buildOptions: string list
      terraformSpeed: float option }

/// Sub-record for resource production.
type EconomyDef =
    { energyMake: ValueOrExpr<float> option
      metalMake: ValueOrExpr<float> option
      energyStorage: float option
      metalStorage: float option
      extractsMetal: float option }

/// Sub-record for static structures.
type BuildingDef =
    { yardMap: string option
      activateWhenBuilt: bool option
      canRepeat: bool option }

/// Core unit definition with universal fields and optional capability sub-records.
type UnitDef =
    { name: string
      subfolder: string
      printableName: string option
      metalCost: ValueOrExpr<float>
      energyCost: ValueOrExpr<float>
      buildTime: ValueOrExpr<float>
      health: ValueOrExpr<float>
      sightDistance: ValueOrExpr<float>
      footprintX: float
      footprintZ: float
      objectName: string option
      buildPic: string option
      script: string option
      corpse: string option
      explodeAs: string option
      selfDestructAs: string option
      collisionVolumeOffsets: string option
      collisionVolumeScales: string option
      collisionVolumeType: string option
      seismicSignature: float option
      category: string option
      movement: MovementDef option
      builder: BuilderDef option
      weapons: WeaponDef list option
      economy: EconomyDef option
      building: BuildingDef option
      featureDefs: Map<string, FeatureDef> option
      sounds: SoundDef option
      customParams: Map<string, string>
      extras: Map<string, string> }
