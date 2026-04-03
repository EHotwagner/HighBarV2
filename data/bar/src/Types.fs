namespace BarData

/// Generic wrapper for fields that may contain runtime Lua expressions.
[<RequireQualifiedAccess>]
type ValueOrExpr<'T> =
    | Concrete of 'T
    | Expr of string

/// Typed record for unit sound assignments.
type SoundDef =
    { build: string option
      repair: string option
      working: string option
      underAttack: string option
      cancelDestruct: string option
      capture: string option
      cant: string list
      count: string list
      ok: string list
      select: string list }

/// Record for wreckage/corpse definitions.
type FeatureDef =
    { blocking: bool option
      category: string option
      collisionVolumeOffsets: string option
      collisionVolumeScales: string option
      collisionVolumeType: string option
      damage: float option
      featureDead: string option
      footprintX: float option
      footprintZ: float option
      height: float option
      metal: float option
      object_: string option
      reclaimable: bool option
      resurrectable: float option }

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

/// Record for weapon definitions.
type WeaponDef =
    { name: string
      displayName: string option
      weaponType: string option
      damage: Map<string, float>
      range: ValueOrExpr<float> option
      reloadTime: ValueOrExpr<float> option
      weaponVelocity: float option
      areaOfEffect: float option
      accuracy: float option
      turret: bool option
      tolerance: float option
      edgeEffectiveness: float option
      impulseFactor: float option
      noSelfDamage: bool option
      soundStart: string option
      soundHit: string option
      explosiongenerator: string option
      rgbColor: string option
      onlyTargetCategory: string option
      badTargetCategory: string option
      customParams: Map<string, string>
      extras: Map<string, string> }

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
