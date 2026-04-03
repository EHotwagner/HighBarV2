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

/// Record for weapon definitions.
type WeaponDef =
    { name: string
      displayName: string
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
      customParams: Map<string, string>
      extras: Map<string, string> }
