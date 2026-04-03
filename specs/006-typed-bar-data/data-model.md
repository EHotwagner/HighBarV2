# Data Model: Typed BAR Data Records

**Feature**: 006-typed-bar-data | **Date**: 2026-04-03

## Entity Definitions

### ValueOrExpr<'T>

Generic wrapper for fields that may contain runtime Lua expressions.

| Field | Type | Description |
|-------|------|-------------|
| (case) Concrete | `'T` | Statically evaluated value |
| (case) Expr | `string` | Unevaluated Lua expression text |

### UnitDef

Core record with universal fields plus optional capability sub-records.

**Universal Fields** (present in all units):

| Field | Type | Lua Source Key | Description |
|-------|------|----------------|-------------|
| name | `string` | (table key) | Unit identifier (e.g., "armham") |
| subfolder | `string` | (file path) | Source subfolder (e.g., "ArmBots") |
| metalCost | `ValueOrExpr<float>` | metalcost | Metal cost to build |
| energyCost | `ValueOrExpr<float>` | energycost | Energy cost to build |
| buildTime | `ValueOrExpr<float>` | buildtime | Build time |
| health | `ValueOrExpr<float>` | health | Maximum hit points |
| sightDistance | `ValueOrExpr<float>` | sightdistance | Vision range |
| footprintX | `float` | footprintx | X collision footprint |
| footprintZ | `float` | footprintz | Z collision footprint |
| objectName | `string option` | objectname | 3D model file path |
| buildPic | `string option` | buildpic | UI icon filename |
| script | `string option` | script | Animation/behavior script |
| corpse | `string option` | corpse | Wreckage unit name |
| explodeAs | `string option` | explodeas | Explosion type on death |
| selfDestructAs | `string option` | selfdestructas | Self-destruct explosion type |
| collisionVolumeOffsets | `string option` | collisionvolumeoffsets | Collision box offsets |
| collisionVolumeScales | `string option` | collisionvolumescales | Collision box dimensions |
| collisionVolumeType | `string option` | collisionvolumetype | Collision shape type |
| seismicSignature | `float option` | seismicsignature | Sonar signature |
| category | `string option` | category | Unit category tag |

**Capability Sub-Records** (optional):

| Field | Type | Description |
|-------|------|-------------|
| movement | `MovementDef option` | Present for mobile units |
| builder | `BuilderDef option` | Present for constructors |
| weapons | `WeaponDef list option` | Present for armed units |
| economy | `EconomyDef option` | Present for resource producers |
| building | `BuildingDef option` | Present for static structures |
| featureDefs | `Map<string, FeatureDef> option` | Wreckage definitions (dead, heap) |
| sounds | `SoundDef option` | Sound definitions |
| customParams | `Map<string, string>` | Custom parameters |
| extras | `Map<string, string>` | Remaining untyped fields |

### MovementDef

Sub-record for mobile units (canmove=true OR canfly=true).

| Field | Type | Lua Source Key | Description |
|-------|------|----------------|-------------|
| speed | `ValueOrExpr<float>` | speed | Movement speed |
| maxAcc | `float` | maxacc | Maximum acceleration |
| maxDec | `float` | maxdec | Maximum deceleration |
| turnRate | `float` | turnrate | Rotation speed |
| movementClass | `string option` | movementclass | Movement type (BOT2, TANK3, BOAT3) |
| maxSlope | `float option` | maxslope | Max terrain slope |
| maxWaterDepth | `float option` | maxwaterdepth | Max traversable water depth |
| canFly | `bool` | canfly | Is aircraft |
| canMove | `bool` | canmove | Can move on ground |
| floater | `bool` | floater | Floats on water |
| turnInPlace | `bool option` | turninplace | Can rotate without moving |
| turnInPlaceAngleLimit | `float option` | turninplaceanglelimit | Max turn angle |
| turnInPlaceSpeedLimit | `float option` | turninplacespeedlimit | Speed threshold |
| cruiseAltitude | `float option` | cruisealtitude | Aircraft altitude |
| minWaterDepth | `float option` | minwaterdepth | Min water depth (ships) |
| waterline | `float option` | waterline | Visual water position |

### BuilderDef

Sub-record for constructors (builder=true).

| Field | Type | Lua Source Key | Description |
|-------|------|----------------|-------------|
| workerTime | `ValueOrExpr<float>` | workertime | Build speed multiplier |
| buildDistance | `float option` | builddistance | Construction range |
| buildOptions | `string list` | buildoptions | Buildable unit names |
| terraformSpeed | `float option` | terraformspeed | Terrain deformation speed |

### WeaponDef

Record for weapon definitions.

**Core Fields** (~20 typed):

| Field | Type | Lua Source Key | Description |
|-------|------|----------------|-------------|
| name | `string` | (table key) | Weapon identifier |
| displayName | `string option` | name | Human-readable name |
| weaponType | `string option` | weapontype | Type (BeamLaser, Cannon, DGun, etc.) |
| damage | `Map<string, float>` | damage | Damage per armor class |
| range | `ValueOrExpr<float> option` | range | Firing range |
| reloadTime | `ValueOrExpr<float> option` | reloadtime | Reload time (seconds) |
| weaponVelocity | `float option` | weaponvelocity | Projectile speed |
| areaOfEffect | `float option` | areaofeffect | Splash damage radius |
| accuracy | `float option` | accuracy | Accuracy factor |
| turret | `bool option` | turret | Is turret-mounted |
| tolerance | `float option` | tolerance | Firing angle tolerance |
| edgeEffectiveness | `float option` | edgeeffectiveness | Damage falloff at splash edge |
| impulseFactor | `float option` | impulsefactor | Knockback force |
| noSelfDamage | `bool option` | noselfdamage | Immune to own splash |
| soundStart | `string option` | soundstart | Firing sound |
| soundHit | `string option` | soundhit | Impact sound |
| explosiongenerator | `string option` | explosiongenerator | Visual effect |
| rgbColor | `string option` | rgbcolor | Projectile color |
| onlyTargetCategory | `string option` | onlytargetcategory | Target filter |
| badTargetCategory | `string option` | badtargetcategory | Deprioritized targets |
| customParams | `Map<string, string>` | customparams | Weapon custom params |
| extras | `Map<string, string>` | (remaining) | Rare weapon fields (~160) |

### EconomyDef

Sub-record for resource production.

| Field | Type | Lua Source Key | Description |
|-------|------|----------------|-------------|
| energyMake | `ValueOrExpr<float> option` | energymake | Energy produced per frame |
| metalMake | `ValueOrExpr<float> option` | metalmake | Metal produced per frame |
| energyStorage | `float option` | energystorage | Energy storage capacity |
| metalStorage | `float option` | metalstorage | Metal storage capacity |
| extractsMetal | `float option` | extractsmetal | Metal extraction rate |

### BuildingDef

Sub-record for static structures.

| Field | Type | Lua Source Key | Description |
|-------|------|----------------|-------------|
| yardMap | `string option` | yardmap | Building footprint pattern |
| activateWhenBuilt | `bool option` | activatewhenbuilt | Auto-activate on completion |
| canRepeat | `bool option` | canrepeat | Factory can repeat builds |

### FeatureDef

Record for wreckage/corpse definitions.

| Field | Type | Lua Source Key | Description |
|-------|------|----------------|-------------|
| blocking | `bool option` | blocking | Blocks movement |
| category | `string option` | category | Feature category |
| collisionVolumeOffsets | `string option` | collisionvolumeoffsets | Collision box offsets |
| collisionVolumeScales | `string option` | collisionvolumescales | Collision box dimensions |
| collisionVolumeType | `string option` | collisionvolumetype | Collision shape |
| damage | `float option` | damage | Health points |
| featureDead | `string option` | featuredead | Next wreckage stage |
| footprintX | `float option` | footprintx | X footprint |
| footprintZ | `float option` | footprintz | Z footprint |
| height | `float option` | height | Render height |
| metal | `float option` | metal | Reclaimable metal |
| object_ | `string option` | object | 3D model file |
| reclaimable | `bool option` | reclaimable | Can be reclaimed |
| resurrectable | `float option` | resurrectable | Can be resurrected (0=no) |

### SoundDef

Typed record for unit sound assignments.

| Field | Type | Lua Source Key | Description |
|-------|------|----------------|-------------|
| build | `string option` | build | Construction sound |
| repair | `string option` | repair | Repair sound |
| working | `string option` | working | Working/reclaim sound |
| underAttack | `string option` | underattack | Taking damage sound |
| cancelDestruct | `string option` | canceldestruct | Cancel self-destruct sound |
| capture | `string option` | capture | Capturing sound |
| cant | `string list` | cant | "Can't do" sounds |
| count | `string list` | count | Countdown sounds |
| ok | `string list` | ok | Acknowledgement sounds |
| select | `string list` | select | Selection sounds |

## Entity Relationships

```text
UnitDef
├── movement: MovementDef option          (1:0..1)
├── builder: BuilderDef option            (1:0..1)
├── weapons: WeaponDef list option        (1:0..*)
│   └── damage: Map<string, float>        (1:*)
├── economy: EconomyDef option            (1:0..1)
├── building: BuildingDef option          (1:0..1)
├── featureDefs: Map<string, FeatureDef>  (1:0..*)
├── sounds: SoundDef option               (1:0..1)
├── customParams: Map<string, string>     (1:*)
└── extras: Map<string, string>           (1:*)
```

## Capability Detection Rules

| Capability | Detection Logic | Example Units |
|------------|----------------|---------------|
| movement | `canmove=true` OR `canfly=true` OR (`speed > 0` AND no `yardmap`) | armham, armca, armcs |
| builder | `builder=true` AND `buildoptions` table exists | armck, armcom, armaap |
| weapons | `weapondefs` table exists AND has entries | armham, armamb, armcom |
| economy | `energymake > 0` OR `metalmake > 0` OR `extractsmetal` present | armadvsol, armmex |
| building | `yardmap` field exists | armaap, armamb, armadvsol |

Note: Capabilities are NOT mutually exclusive. A commander has movement + builder + weapons. A factory has building + builder.

## Weapon Mounting Note

Lua units have two weapon-related tables: `weapondefs` (definitions with damage, range, etc.) and `weapons` (mounting array mapping weapon slots to weapondefs by name). The `WeaponDef list` on `UnitDef` is derived from `weapondefs` entries, ordered by the `weapons` array slot order. The `weapons` array also contains per-slot overrides (e.g., `mainDir`, `maxAngleDif`, `onlyTargetCategory`) — these are merged into the corresponding `WeaponDef.extras` map with a `mount_` prefix to distinguish them from weapon-level fields.
