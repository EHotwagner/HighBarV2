// Auto-generated BAR unit data: Legion/Vehicles/T2 Vehicles (flat per-unit types)
namespace BarData.Units

open BarData

module Legion_Vehicles_T2_Vehicles =

    type Legaheattank =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legaheattank : Legaheattank =
        { name = "legaheattank"
          subfolder = "Legion/Vehicles/T2 Vehicles"
          metalCost = ValueOrExpr.Concrete 1250.0
          energyCost = ValueOrExpr.Concrete 19000.0
          buildTime = ValueOrExpr.Concrete 25600.0
          health = ValueOrExpr.Concrete 7700.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 4.0
          footprintZ = 4.0
          speed = ValueOrExpr.Concrete 52.0
          maxAcc = 0.02
          maxDec = 0.04
          turnRate = 300.0
          movementClass = "HTANK4"
          maxSlope = 12.0
          maxWaterDepth = 15.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.6104
          weapons = [
                { name = "heat_ray"
                  displayName = Some "Heavy g2g Cleansing Heat Ray"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 33.0
                      "vtol", 10.0
                  ]
                  range = Some (ValueOrExpr.Concrete 450.0)
                  reloadTime = Some (ValueOrExpr.Concrete 3.0)
                  weaponVelocity = Some 950.0
                  areaOfEffect = Some 64.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "heatray3"
                  soundHit = None
                  explosiongenerator = Some "custom:heatray-large"
                  rgbColor = Some "1 0.5 0"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_fastautoretargeting", "true"
                      "mount_burstControlWhenOutOfArc", "2.0"
                      "avoidfeature", "false"
                      "avoidfriendly", "true"
                      "beamtime", "0.033"
                      "corethickness", "0.5"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "300.0"
                      "firestarter", "30.0"
                      "firetolerance", "5000.0"
                      "laserflaresize", "6.0"
                      "predictboost", "0.3"
                      "proximitypriority", "1.0"
                      "rgbcolor2", "0.8 1.0 0.3"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundstartvolume", "11.0"
                      "soundtrigger", "1.0"
                      "thickness", "4.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-0.291641235352 0.00484669189453 0.383178710938"
                  collisionVolumeScales = Some "43.0491943359 23.8300933838 46.0147399902"
                  collisionVolumeType = Some "Box"
                  damage = Some 3100.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 600.0
                  object_ = Some "Units/legaheattank_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 2050.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 210.0
                  object_ = Some "Units/arm3X3F.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["tarmmove"]
                select = ["tarmsel"] }
          customParams = Map.ofList [
                "unitgroup", "weapon"
                "basename", "base"
                "firingceg", "barrelshot-medium"
                "kickback", "-2.4"
                "model_author", "ZephyrSkies"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Vehicles/T2 Vehicles"
                "techlevel", "2.0"
                "weapon1turretx", "65.0"
                "weapon1turrety", "105.0"
            ]
          extras = Map.ofList [
                "leavetracks", "true"
                "nochasecategory", "VTOL"
                "trackoffset", "8.0"
                "trackstrength", "10.0"
                "tracktype", "corwidetracks"
                "trackwidth", "44.0"
            ] }

    type Legamcluster =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legamcluster : Legamcluster =
        { name = "legamcluster"
          subfolder = "Legion/Vehicles/T2 Vehicles"
          metalCost = ValueOrExpr.Concrete 460.0
          energyCost = ValueOrExpr.Concrete 5500.0
          buildTime = ValueOrExpr.Concrete 10450.0
          health = ValueOrExpr.Concrete 1250.0
          sightDistance = ValueOrExpr.Concrete 300.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 44.0
          maxAcc = 0.018
          maxDec = 0.036
          turnRate = 180.0
          movementClass = "TANK3"
          maxSlope = 12.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.15
          weapons = [
                { name = "cluster_artillery"
                  displayName = Some "Long-range g2g plasma cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 300.0
                      "subs", 75.0
                      "vtol", 75.0
                  ]
                  range = Some (ValueOrExpr.Concrete 930.0)
                  reloadTime = Some (ValueOrExpr.Concrete 7.2)
                  weaponVelocity = Some 345.0
                  areaOfEffect = Some 130.0
                  accuracy = Some 400.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.4
                  impulseFactor = Some 0.5
                  noSelfDamage = Some true
                  soundStart = Some "cannhvy2"
                  soundHit = Some "xplomed4"
                  explosiongenerator = Some "custom:ministarfire-explosion"
                  rgbColor = Some "0.7 0.7 1.0 1.0 1.0 1.0 1.0 1.0"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.ofList [
                      "cluster_def", "cluster_munition"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "NOTLAND"
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "180.0"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "cegtag", "starfire_arty"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "soundhitwet", "splsmed"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 -2"
                  collisionVolumeScales = Some "36 20 38"
                  collisionVolumeType = Some "Box"
                  damage = Some 625.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 230.0
                  object_ = Some "Units/legamcluster_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 400.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 115.0
                  object_ = Some "Units/arm2X2E.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["tarmmove"]
                select = ["tarmsel"] }
          customParams = Map.ofList [
                "unitgroup", "weapon"
                "basename", "base"
                "canareaattack", "1.0"
                "firingceg", "barrelshot-medium"
                "kickback", "-6"
                "model_author", "ZephyrSkies"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Vehicles"
                "techlevel", "2.0"
                "weapon1turretx", "35.0"
                "weapon1turrety", "35.0"
            ]
          extras = Map.ofList [
                "leavetracks", "true"
                "movestate", "0.0"
                "nochasecategory", "VTOL"
                "trackoffset", "0.0"
                "trackstrength", "6.0"
                "tracktype", "corwidetracks"
                "trackwidth", "36.0"
            ] }

    type Legaskirmtank =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legaskirmtank : Legaskirmtank =
        { name = "legaskirmtank"
          subfolder = "Legion/Vehicles/T2 Vehicles"
          metalCost = ValueOrExpr.Concrete 450.0
          energyCost = ValueOrExpr.Concrete 6800.0
          buildTime = ValueOrExpr.Concrete 10490.0
          health = ValueOrExpr.Concrete 2500.0
          sightDistance = ValueOrExpr.Concrete 440.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 65.0
          maxAcc = 0.05
          maxDec = 0.1
          turnRate = 450.0
          movementClass = "MTANK3"
          maxSlope = 12.0
          maxWaterDepth = 15.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.72656
          weapons = [
                { name = "legmgplasma"
                  displayName = Some "Heavy Rotary Plasma Cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 70.0
                      "vtol", 20.0
                  ]
                  range = Some (ValueOrExpr.Concrete 600.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.0)
                  weaponVelocity = Some 360.0
                  areaOfEffect = Some 64.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 7000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "corraid"
                  soundHit = Some "xplosml3"
                  explosiongenerator = Some "custom:genericshellexplosion-small-t2"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_fastautoretargeting", "true"
                      "mount_burstControlWhenOutOfArc", "2.0"
                      "burstrate", "0.2"
                      "burst", "3.0"
                      "sprayangle", "600.0"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "100.0"
                      "fireTolerance", "7000.0"
                      "gravityaffected", "true"
                      "predictboost", "0.5"
                      "size", "2.0"
                      "soundhitwet", "splshbig"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-0.291641235352 0.00484669189453 0.383178710938"
                  collisionVolumeScales = Some "43.0491943359 23.8300933838 46.0147399902"
                  collisionVolumeType = Some "Box"
                  damage = Some 3000.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 225.0
                  object_ = Some "Units/legaskirmtank_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 2000.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 105.0
                  object_ = Some "Units/arm3X3F.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["tarmmove"]
                select = ["tarmsel"] }
          customParams = Map.ofList [
                "unitgroup", "weapon"
                "basename", "base"
                "firingceg", "barrelshot-medium"
                "kickback", "-2.4"
                "model_author", "ZephyrSkies"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Vehicles/T2 Vehicles"
                "techlevel", "2.0"
                "weapon1turretx", "65.0"
                "weapon1turrety", "105.0"
            ]
          extras = Map.ofList [
                "leavetracks", "true"
                "nochasecategory", "VTOL"
                "trackoffset", "4.0"
                "trackstrength", "10.0"
                "tracktype", "armbull_tracks"
                "trackwidth", "44.0"
            ] }

    type Legavantinuke =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legavantinuke : Legavantinuke =
        { name = "legavantinuke"
          subfolder = "Legion/Vehicles/T2 Vehicles"
          metalCost = ValueOrExpr.Concrete 1100.0
          energyCost = ValueOrExpr.Concrete 36000.0
          buildTime = ValueOrExpr.Concrete 51300.0
          health = ValueOrExpr.Concrete 720.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 58.0
          maxAcc = 0.05721
          maxDec = 0.10443
          turnRate = 550.29999
          movementClass = "TANK3"
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.188
          weapons = [
                { name = "legavantinuke_weapon"
                  displayName = Some "ICBM Interceptor Missile Launcher"
                  weaponType = Some "StarburstLauncher"
                  damage = Map.ofList [
                      "default", 500.0
                  ]
                  range = Some (ValueOrExpr.Concrete 72000.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.0)
                  weaponVelocity = Some 6000.0
                  areaOfEffect = Some 420.0
                  accuracy = None
                  turret = None
                  tolerance = Some 7000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "antinukelaunch"
                  soundHit = Some "xplomed4"
                  explosiongenerator = Some "custom:antinuke"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "ALL"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "burnblow", "true"
                      "cegtag", "antimissiletrail"
                      "collideenemy", "false"
                      "collidefeature", "false"
                      "collidefriendly", "false"
                      "coverage", "1575.0"
                      "craterareaofeffect", "420.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "6500.0"
                      "firestarter", "100.0"
                      "flighttime", "20.0"
                      "interceptor", "1.0"
                      "metalpershot", "150.0"
                      "model", "fmdmissile.s3o"
                      "smokecolor", "0.7"
                      "smokeperiod", "10.0"
                      "smokesize", "27.0"
                      "smoketime", "110.0"
                      "smoketrail", "true"
                      "smoketrailcastshadow", "true"
                      "soundhitwet", "splslrg"
                      "stockpile", "true"
                      "stockpiletime", "90.0"
                      "texture1", "bluenovaexplo"
                      "texture2", "smoketrailbar"
                      "texture3", "null"
                      "tracks", "true"
                      "turnrate", "10000.0"
                      "weaponacceleration", "150.0"
                      "weapontimer", "2.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "42 28 65"
                  collisionVolumeType = Some "Box"
                  damage = Some 650.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 980.0
                  object_ = Some "Units/legavantinuke_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 550.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 392.0
                  object_ = Some "Units/cor3X3D.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["tcormove"]
                select = ["tcorsel"] }
          customParams = Map.ofList [
                "model_author", "ZephyrSkies"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Vehicles/T2 Vehicles"
                "techlevel", "2.0"
                "unitgroup", "antinuke"
            ]
          extras = Map.ofList [
                "canattack", "false"
                "damagemodifier", "0.5"
                "leavetracks", "true"
                "movestate", "0.0"
                "noautofire", "true"
                "nochasecategory", "ALL"
                "radardistance", "50.0"
                "trackoffset", "6.0"
                "trackstrength", "5.0"
                "tracktype", "corwidetracks"
                "trackwidth", "34.0"
            ] }

    type Legavjam =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legavjam : Legavjam =
        { name = "legavjam"
          subfolder = "Legion/Vehicles/T2 Vehicles"
          metalCost = ValueOrExpr.Concrete 105.0
          energyCost = ValueOrExpr.Concrete 1900.0
          buildTime = ValueOrExpr.Concrete 6930.0
          health = ValueOrExpr.Concrete 510.0
          sightDistance = ValueOrExpr.Concrete 300.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 41.0
          maxAcc = 0.02416
          maxDec = 0.04831
          turnRate = 505.0
          movementClass = "TANK3"
          maxSlope = 16.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 0.792
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "23 28 33"
                  collisionVolumeType = Some "Box"
                  damage = Some 400.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 78.0
                  object_ = Some "Units/legavjam_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 368.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 39.0
                  object_ = Some "Units/arm3X3B.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["varmmove"]
                select = ["radjam1"] }
          customParams = Map.ofList [
                "model_author", "ZephyrSkies"
                "normaltex", "unittextures/leg_normal.dds"
                "off_on_stun", "true"
                "subfolder", "Legion/Vehicles/T2 Vehicles"
                "techlevel", "2.0"
                "unitgroup", "util"
            ]
          extras = Map.ofList [
                "canattack", "false"
                "energyupkeep", "80.0"
                "leavetracks", "false"
                "movestate", "0.0"
                "nochasecategory", "MOBILE"
                "onoffable", "true"
                "radardistance", "0.0"
                "radardistancejam", "450.0"
                "trackoffset", "8.0"
                "trackstrength", "10.0"
                "tracktype", "StdTank"
                "trackwidth", "22.0"
            ] }

    type Legavrad =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legavrad : Legavrad =
        { name = "legavrad"
          subfolder = "Legion/Vehicles/T2 Vehicles"
          metalCost = ValueOrExpr.Concrete 125.0
          energyCost = ValueOrExpr.Concrete 2000.0
          buildTime = ValueOrExpr.Concrete 7290.0
          health = ValueOrExpr.Concrete 980.0
          sightDistance = ValueOrExpr.Concrete 900.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 57.0
          maxAcc = 0.04878
          maxDec = 0.09757
          turnRate = 605.0
          movementClass = "TANK3"
          maxSlope = 16.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.33584
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -4 0"
                  collisionVolumeScales = Some "28 30 34"
                  collisionVolumeType = Some "Box"
                  damage = Some 700.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 80.0
                  object_ = Some "Units/legavrad_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 500.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 48.0
                  object_ = Some "Units/arm3X3E.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["varmmove"]
                select = ["avradsel"] }
          customParams = Map.ofList [
                "model_author", "ZephyrSkies"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Vehicles/T2 Vehicles"
                "techlevel", "2.0"
                "unitgroup", "util"
            ]
          extras = Map.ofList [
                "canattack", "false"
                "leavetracks", "true"
                "movestate", "0.0"
                "onoffable", "false"
                "radardistance", "2300.0"
                "trackoffset", "5.0"
                "trackstrength", "5.0"
                "tracktype", "armseer_tracks"
                "trackwidth", "24.0"
            ] }

    type Legavroc =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legavroc : Legavroc =
        { name = "legavroc"
          subfolder = "Legion/Vehicles/T2 Vehicles"
          metalCost = ValueOrExpr.Concrete 920.0
          energyCost = ValueOrExpr.Concrete 6500.0
          buildTime = ValueOrExpr.Concrete 20130.0
          health = ValueOrExpr.Concrete 1220.0
          sightDistance = ValueOrExpr.Concrete 247.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 33.0
          maxAcc = 0.02489
          maxDec = 0.04978
          turnRate = 520.29999
          movementClass = "HTANK4"
          maxSlope = 16.0
          maxWaterDepth = 12.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 0.792
          weapons = [
                { name = "armtruck_rocket"
                  displayName = Some "Heavy Long-Range g2g High-Trajectory Starburst Rocket Launcher"
                  weaponType = Some "StarburstLauncher"
                  damage = Map.ofList [
                      "commanders", 625.0
                      "default", 1900.0
                      "subs", 500.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 18.0)
                  weaponVelocity = Some 380.0
                  areaOfEffect = Some 150.0
                  accuracy = None
                  turret = None
                  tolerance = Some 4000.0
                  edgeEffectiveness = Some 0.65
                  impulseFactor = Some 0.2
                  noSelfDamage = Some true
                  soundStart = Some "Rockhvy1"
                  soundHit = Some "xplomed4"
                  explosiongenerator = Some "custom:genericshellexplosion-large-bomb"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.ofList [
                      "projectile_destruction_method", "descend"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "MOBILE"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "cegtag", "missiletrailmedium-starburst"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "100.0"
                      "flighttime", "10.0"
                      "metalpershot", "0.0"
                      "model", "leglargerocket.s3o"
                      "soundhitwet", "splslrg"
                      "smoketrail", "true"
                      "smokePeriod", "9.0"
                      "smoketime", "45.0"
                      "smokesize", "16.0"
                      "smokecolor", "0.7"
                      "smokeTrailCastShadow", "false"
                      "castshadow", "true"
                      "texture1", "null"
                      "texture2", "smoketrailbar"
                      "texture3", "null"
                      "turnrate", "15000.0"
                      "weaponacceleration", "100.0"
                      "weapontimer", "3.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "46 30 54"
                  collisionVolumeType = Some "Box"
                  damage = Some 1812.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 560.0
                  object_ = Some "Units/legavroc_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 906.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 224.0
                  object_ = Some "Units/arm3X3F.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["varmmove"]
                select = ["varmsel"] }
          customParams = Map.ofList [
                "unitgroup", "weapon"
                "model_author", "ZephyrSkies"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "ArmVehicles/T2"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "leavetracks", "true"
                "movestate", "0.0"
                "nochasecategory", "MOBILE VTOL"
                "stealth", "true"
                "trackoffset", "0.0"
                "trackstrength", "8.0"
                "tracktype", "armcroc_tracks"
                "trackwidth", "50.0"
            ] }

    type Legfloat =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          waterline: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legfloat : Legfloat =
        { name = "legfloat"
          subfolder = "Legion/Vehicles/T2 Vehicles"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 0.0
          buildTime = ValueOrExpr.Concrete 12000.0
          health = ValueOrExpr.Concrete 0.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 55.0
          maxAcc = 0.034
          maxDec = 0.068
          turnRate = 350.0
          movementClass = "HOVER3"
          maxSlope = 10.0
          maxWaterDepth = 12.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.8
          waterline = 7.5
          weapons = [
                { name = "legfloat_gauss"
                  displayName = Some "Medium g2g gauss cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 250.0
                  ]
                  range = Some (ValueOrExpr.Concrete 550.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.5)
                  weaponVelocity = Some 550.0
                  areaOfEffect = Some 32.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 8000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "cannhvy1"
                  soundHit = Some "xplomed2"
                  explosiongenerator = Some "custom:genericshellexplosion-medium"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "separation", "1.8"
                      "nogap", "false"
                      "sizeDecay", "0.06"
                      "stages", "14.0"
                      "alphaDecay", "0.08"
                      "soundhitwet", "splshbig"
                      "targetmoveerror", "0.2"
                  ] }
                { name = "legfloat_gatling"
                  displayName = Some "Rapid-fire machine gun"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "default", 7.0
                      "vtol", 7.0
                  ]
                  range = Some (ValueOrExpr.Concrete 400.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.4)
                  weaponVelocity = Some 950.0
                  areaOfEffect = Some 16.0
                  accuracy = Some 7.0
                  turret = Some true
                  tolerance = Some 12000.0
                  edgeEffectiveness = Some 0.85
                  impulseFactor = Some 1.5
                  noSelfDamage = Some true
                  soundStart = Some "mgun6"
                  soundHit = Some "bimpact3"
                  explosiongenerator = Some "custom:plasmahit-sparkonly"
                  rgbColor = Some "1 0.95 0.4"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "mount_badTargetCategory", "SURFACE NOTAIR"
                      "avoidfeature", "false"
                      "burst", "6.0"
                      "burstrate", "0.066"
                      "burnblow", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "0.03"
                      "fallOffRate", "0.2"
                      "firestarter", "0.0"
                      "intensity", "0.8"
                      "ownerExpAccWeight", "4.0"
                      "proximitypriority", "1.0"
                      "soundhitwet", "splshbig"
                      "soundstartvolume", "3.0"
                      "soundtrigger", "true"
                      "sprayangle", "968.0"
                      "texture1", "shot"
                      "texture2", "empty"
                      "thickness", "2.0"
                      "fireTolerance", "6000.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 -0.5"
                  collisionVolumeScales = Some "40 27 60"
                  collisionVolumeType = Some "Box"
                  damage = Some 1800.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 400.0
                  object_ = Some "Units/legfloat_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 1300.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 160.0
                  object_ = Some "Units/cor2X2D.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["tarmmove"]
                select = ["tarmsel"] }
          customParams = Map.ofList [
                "model_author", "EnderRobo"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "legvehicles/T2"
                "techlevel", "2.0"
                "restrictions_exclusion", "_nosea_"
                "speedfactorinwater", "1.3"
            ]
          extras = Map.ofList [
                "buildcostenergy", "12000.0"
                "buildcostmetal", "650.0"
                "description", "Floating Tank"
                "usepiececollisionvolumes", "1.0"
                "leavetracks", "true"
                "maxdamage", "3500.0"
                "nochasecategory", "VTOL"
                "trackoffset", "6.0"
                "trackstrength", "5.0"
                "tracktype", "armacv_tracks"
                "trackwidth", "36.0"
            ] }

    type Leginf =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let leginf : Leginf =
        { name = "leginf"
          subfolder = "Legion/Vehicles/T2 Vehicles"
          metalCost = ValueOrExpr.Concrete 1700.0
          energyCost = ValueOrExpr.Concrete 30000.0
          buildTime = ValueOrExpr.Concrete 42900.0
          health = ValueOrExpr.Concrete 3650.0
          sightDistance = ValueOrExpr.Concrete 351.0
          footprintX = 4.0
          footprintZ = 4.0
          speed = ValueOrExpr.Concrete 37.5
          maxAcc = 0.0098
          maxDec = 0.0196
          turnRate = 169.39999
          movementClass = "HTANK4"
          maxSlope = 14.0
          maxWaterDepth = 15.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 0.95832
          weapons = [
                { name = "rapidnapalm"
                  displayName = Some "Heavy Burst-Fire Napalm Artillery Tri-Cannons"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 60.0
                      "subs", 15.0
                      "vtol", 15.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1100.0)
                  reloadTime = Some (ValueOrExpr.Concrete 7.0)
                  weaponVelocity = Some 400.0
                  areaOfEffect = Some 150.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "cannhvy2"
                  soundHit = None
                  explosiongenerator = Some "custom:fire-explosion-small"
                  rgbColor = Some "1 0.25 0.1"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.ofList [
                      "area_onhit_ceg", "fire-area-75-repeat"
                      "area_onhit_damageCeg", "burnflamexl-gen"
                      "area_onhit_resistance", "fire"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "180.0"
                      "mount_onlytargetcategory", "SURFACE"
                      "burst", "6.0"
                      "burstrate", "0.15"
                      "avoidfeature", "false"
                      "cegtag", "burnflame-xs"
                      "collidefriendly", "false"
                      "colormap", "0.75 0.73 0.67 0.024   0.37 0.4 0.30 0.021   0.22 0.21 0.14 0.018  0.024 0.014 0.009 0.03   0.0 0.0 0.0 0.008"
                      "craterareaofeffect", "90.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "flamegfxtime", "1.0"
                      "gravityaffected", "true"
                      "leadlimit", "0.0"
                      "mygravity", "0.08"
                      "projectiles", "1.0"
                      "size", "6.0"
                      "soundhitdry", "flamhit1"
                      "soundhitwet", "sizzle"
                      "sprayangle", "1500.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "54 49 88"
                  collisionVolumeType = Some "Box"
                  damage = Some 2000.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 8.0
                  metal = Some 1200.0
                  object_ = Some "Units/leginf_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 1500.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 2.0
                  metal = Some 550.0
                  object_ = Some "Units/cor2X2B.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["tcormove"]
                select = ["tcorsel"] }
          customParams = Map.ofList [
                "unitgroup", "weapon"
                "model_author", "ZephyrSkies (model), Phill-Art (concept art)"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Vehicles/T2 Vehicles"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "airsightdistance", "1050.0"
                "usepiececollisionvolumes", "1.0"
                "leavetracks", "true"
                "mass", "5001.0"
                "nochasecategory", "VTOL"
                "trackoffset", "-8.0"
                "trackstrength", "8.0"
                "tracktype", "corparrowtracks"
                "trackwidth", "50.0"
            ] }

    type Legmed =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legmed : Legmed =
        { name = "legmed"
          subfolder = "Legion/Vehicles/T2 Vehicles"
          metalCost = ValueOrExpr.Concrete 1500.0
          energyCost = ValueOrExpr.Concrete 22500.0
          buildTime = ValueOrExpr.Concrete 30370.0
          health = ValueOrExpr.Concrete 3000.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 4.0
          footprintZ = 4.0
          speed = ValueOrExpr.Concrete 39.0
          maxAcc = 0.01
          maxDec = 0.02
          turnRate = 220.0
          movementClass = "HTANK4"
          maxSlope = 16.0
          maxWaterDepth = 12.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 0.792
          weapons = [
                { name = "laser"
                  displayName = Some "Targeting System"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 0.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1000.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.1)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "beamershot2"
                  soundHit = None
                  explosiongenerator = Some ""
                  rgbColor = Some "2 0 0"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "270.0"
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_fastautoretargeting", "true"
                      "mount_fastquerypointupdate", "true"
                      "avoidfeature", "false"
                      "beamdecay", "0.05"
                      "beamtime", "0.1"
                      "beamttl", "1.0"
                      "corethickness", "0.1"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "0.0"
                      "impactonly", "1.0"
                      "laserflaresize", "8.0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "1.4"
                  ] }
                { name = "legmed_missile"
                  displayName = Some "Hexaburst Homing Siege Rockets"
                  weaponType = Some "StarburstLauncher"
                  damage = Map.ofList [
                      "commanders", 200.0
                      "default", 500.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1000.0)
                  reloadTime = Some (ValueOrExpr.Concrete 12.0)
                  weaponVelocity = Some 550.0
                  areaOfEffect = Some 50.0
                  accuracy = None
                  turret = None
                  tolerance = Some 4000.0
                  edgeEffectiveness = Some 0.65
                  impulseFactor = Some 0.2
                  noSelfDamage = Some true
                  soundStart = Some "Rockhvy1"
                  soundHit = Some "xplomed4"
                  explosiongenerator = Some "custom:genericshellexplosion-medium-bomb"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.ofList [
                      "projectile_destruction_method", "descend"
                      "speceffect", "guidance"
                  ]
                  extras = Map.ofList [
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "270.0"
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_fastautoretargeting", "true"
                      "mount_fastquerypointupdate", "true"
                      "mount_slaveto", "1.0"
                      "avoidfeature", "false"
                      "cegtag", "missiletrailmedium-starburst"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "100.0"
                      "flighttime", "5.0"
                      "metalpershot", "0.0"
                      "model", "leghomingmissile.s3o"
                      "smoketrail", "true"
                      "smokePeriod", "9.0"
                      "smoketime", "45.0"
                      "smokesize", "16.0"
                      "smokecolor", "0.7"
                      "smokeTrailCastShadow", "false"
                      "castshadow", "true"
                      "soundhitwet", "splslrg"
                      "texture1", "null"
                      "texture2", "smoketrailbar"
                      "texture3", "null"
                      "turnrate", "15000.0"
                      "tracks", "true"
                      "weaponacceleration", "300.0"
                      "weapontimer", "0.2"
                      "startvelocity", "80.0"
                      "burst", "6.0"
                      "burstrate", "0.25"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -10 0"
                  collisionVolumeScales = Some "46 31 65"
                  collisionVolumeType = Some "Box"
                  damage = Some 1897.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 538.0
                  object_ = Some "Units/legmed_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 1500.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 215.0
                  object_ = Some "Units/cor3X3E.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["vcormove"]
                select = ["vcorsel"] }
          customParams = Map.ofList [
                "unitgroup", "weapon"
                "model_author", "ZephyrSkies, EnderRobo"
                "normaltex", "unittextures/leg_normal.dds"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "usepiececollisionvolumes", "1.0"
                "leavetracks", "true"
                "nochasecategory", "VTOL"
                "trackstrength", "8.0"
                "tracktype", "corwidetracks"
                "trackwidth", "52.0"
            ] }

    type Legmrv =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legmrv : Legmrv =
        { name = "legmrv"
          subfolder = "Legion/Vehicles/T2 Vehicles"
          metalCost = ValueOrExpr.Concrete 250.0
          energyCost = ValueOrExpr.Concrete 4100.0
          buildTime = ValueOrExpr.Concrete 5900.0
          health = ValueOrExpr.Concrete 970.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 135.0
          maxAcc = 0.09
          maxDec = 0.14
          turnRate = 600.0
          movementClass = "TANK2"
          maxSlope = 12.0
          maxWaterDepth = 100.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.72656
          weapons = [
                { name = "quickshot_cannon"
                  displayName = Some "Two-Round Burst Fire Plasma Cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 120.0
                      "vtol", 30.0
                  ]
                  range = Some (ValueOrExpr.Concrete 240.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.0)
                  weaponVelocity = Some 450.0
                  areaOfEffect = Some 32.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 3640.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "cannon3"
                  soundHit = Some "xplomed2"
                  explosiongenerator = Some "custom:genericshellexplosion-small-t2"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_burstControlWhenOutOfArc", "2.0"
                      "avoidfeature", "false"
                      "burst", "2.0"
                      "burstrate", "0.15"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "fireTolerance", "3640.0"
                      "soundhitwet", "splssml"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-0.042236328125 -0.00674871826172 -0.122863769531"
                  collisionVolumeScales = Some "37.7348022461 25.9745025635 40.3383178711"
                  collisionVolumeType = Some "Box"
                  damage = Some 1500.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 95.0
                  object_ = Some "Units/legmrv_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 1000.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 45.0
                  object_ = Some "Units/cor3X3C.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["tcormove"]
                select = ["tcorsel"] }
          customParams = Map.ofList [
                "unitgroup", "weapon"
                "basename", "base"
                "firingceg", "barrelshot-medium"
                "kickback", "-2.4"
                "model_author", "ZephyrSkies"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "CorVehicles/T2"
                "techlevel", "2.0"
                "weapon1turretx", "65.0"
                "weapon1turrety", "105.0"
            ]
          extras = Map.ofList [
                "leavetracks", "true"
                "nochasecategory", "VTOL"
                "trackoffset", "0.0"
                "trackstrength", "6.0"
                "tracktype", "corwidetracks"
                "trackwidth", "30.0"
            ] }

    type Legvcarry =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legvcarry : Legvcarry =
        { name = "legvcarry"
          subfolder = "Legion/Vehicles/T2 Vehicles"
          metalCost = ValueOrExpr.Concrete 450.0
          energyCost = ValueOrExpr.Concrete 9000.0
          buildTime = ValueOrExpr.Concrete 11550.0
          health = ValueOrExpr.Concrete 1400.0
          sightDistance = ValueOrExpr.Concrete 400.0
          footprintX = 4.0
          footprintZ = 4.0
          speed = ValueOrExpr.Concrete 45.0
          maxAcc = 0.02
          maxDec = 0.04
          turnRate = 360.0
          movementClass = "HTANK4"
          maxSlope = 10.0
          maxWaterDepth = 12.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.952
          weapons = [
                { name = "targeting"
                  displayName = Some "Drone Targeting System"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 0.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1000.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.5)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 4.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some ""
                  soundHit = Some ""
                  explosiongenerator = Some ""
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.ofList [
                      "carried_unit", "legdrone"
                      "spawns_surface", "LAND"
                      "carrierdeaththroe", "release"
                      "dockingpieces", "8 10 12 14 16 18"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "hightrajectory", "1.0"
                      "metalpershot", "15.0"
                      "energypershot", "500.0"
                      "size", "0.0"
                      "soundhitwet", ""
                      "stockpile", "true"
                      "stockpiletime", "10.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "55 37 67"
                  collisionVolumeType = Some "Box"
                  damage = Some 1056.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 210.0
                  object_ = Some "Units/legvcarry_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 528.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 80.0
                  object_ = Some "Units/arm2X2D.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["tnkt1canok"]
                select = ["tnkt1cansel"] }
          customParams = Map.ofList [
                "unitgroup", "weapon"
                "basename", "base"
                "firingceg", "barrelshot-small"
                "kickback", "-2.4"
                "lumamult", "1.2"
                "model_author", "ZephyrSkies (model), Johnathan Crimson (concept)"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Vehicles/T2 Vehicles"
                "weapon1turretx", "45.0"
                "weapon1turrety", "80.0"
                "inheritxpratemultiplier", "1.0"
                "childreninheritxp", "DRONE"
                "parentsinheritxp", "DRONE"
                "restrictions_inclusion", "_noair_"
            ]
          extras = Map.ofList [
                "leavetracks", "true"
                "nochasecategory", "VTOL"
                "trackoffset", "6.0"
                "trackstrength", "6.0"
                "tracktype", "armstump_tracks"
                "trackwidth", "56.0"
            ] }

    type Legvflak =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legvflak : Legvflak =
        { name = "legvflak"
          subfolder = "Legion/Vehicles/T2 Vehicles"
          metalCost = ValueOrExpr.Concrete 470.0
          energyCost = ValueOrExpr.Concrete 10500.0
          buildTime = ValueOrExpr.Concrete 15130.0
          health = ValueOrExpr.Concrete 2700.0
          sightDistance = ValueOrExpr.Concrete 338.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 70.0
          maxAcc = 0.05823
          maxDec = 0.11647
          turnRate = 591.79999
          movementClass = "TANK3"
          maxSlope = 14.0
          maxWaterDepth = 12.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.6335
          weapons = [
                { name = "leg_t2_microflak_mobile"
                  displayName = Some "Dual Rotary Microflak Cannons"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "vtol", 40.0
                  ]
                  range = Some (ValueOrExpr.Concrete 800.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.166)
                  weaponVelocity = Some 1900.0
                  areaOfEffect = Some 35.0
                  accuracy = Some 1000.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "flakfire"
                  soundHit = Some "flakhit"
                  explosiongenerator = Some "custom:flakshard"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "LIGHTAIRSCOUT"
                      "mount_burstcontrolwhenoutofarc", "2.0"
                      "mount_fastautoretargeting", "true"
                      "mount_onlytargetcategory", "VTOL"
                      "burst", "3.0"
                      "burstrate", "0.02"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "canattackground", "false"
                      "cegtag", "flaktrailaamg"
                      "craterareaofeffect", "35.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "collidefriendly", "false"
                      "gravityaffected", "true"
                      "size", "0.0"
                      "sizedecay", "0.08"
                      "soundhitwet", "splsmed"
                      "stages", "0.0"
                      "weapontimer", "1.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.2 -7 1.5"
                  collisionVolumeScales = Some "32.4 21.8 34.3"
                  collisionVolumeType = Some "Box"
                  damage = Some 2000.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 288.0
                  object_ = Some "Units/legvflak_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 1500.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 115.0
                  object_ = Some "Units/cor2X2A.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["tcormove"]
                select = ["tcorsel"] }
          customParams = Map.ofList [
                "model_author", "Tharsis"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Vehicles/T2 Vehicles"
                "techlevel", "2.0"
                "unitgroup", "aa"
            ]
          extras = Map.ofList [
                "airsightdistance", "900.0"
                "leavetracks", "true"
                "movestate", "0.0"
                "nochasecategory", "NOTAIR"
                "trackoffset", "-5.0"
                "trackstrength", "5.0"
                "tracktype", "armcroc_tracks"
                "trackwidth", "41.0"
            ] }

