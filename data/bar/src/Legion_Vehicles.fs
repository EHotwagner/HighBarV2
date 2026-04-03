// Auto-generated BAR unit data: Legion/Vehicles (flat per-unit types)
namespace BarData.Units

open BarData

module Legion_Vehicles =

    type Legamphtank =
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

    let legamphtank : Legamphtank =
        { name = "legamphtank"
          subfolder = "Legion/Vehicles"
          metalCost = ValueOrExpr.Concrete 200.0
          energyCost = ValueOrExpr.Concrete 2000.0
          buildTime = ValueOrExpr.Concrete 2610.0
          health = ValueOrExpr.Concrete 1340.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 63.0
          maxAcc = 0.03572
          maxDec = 0.07144
          turnRate = 398.0
          movementClass = "ATANK3"
          maxSlope = 15.0
          maxWaterDepth = 125.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.485
          weapons = [
                { name = "leg_amph_gauss"
                  displayName = Some "Light Close-quarters Gauss Cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 116.0
                      "vtol", 25.0
                  ]
                  range = Some (ValueOrExpr.Concrete 305.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.5)
                  weaponVelocity = Some 450.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "cannhvy1"
                  soundHit = Some "xplomed2"
                  explosiongenerator = Some "custom:genericshellexplosion-small"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "soundhitwet", "splshbig"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 -1.0267456543 -0.357666015625"
                  collisionVolumeScales = Some "29.7029724121 10.5689086914 32.8999633789"
                  collisionVolumeType = Some "Box"
                  damage = Some 689.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 9.0
                  metal = Some 122.0
                  object_ = Some "Units/legamphtank_dead.s3o"
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
                  metal = Some 61.0
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
                ok = ["tnkt1canamphok"]
                select = ["tnkt1canamphsel"] }
          customParams = Map.ofList [
                "unitgroup", "weapon"
                "basename", "base"
                "firingceg", "barrelshot-small"
                "kickback", "-2.7"
                "model_author", "ZephyrSkies"
                "normaltex", "unittextures/leg_normal.dds"
                "paralyzemultiplier", "0.125"
                "subfolder", "Legion/Vehicles"
                "weapon1turretx", "130.0"
                "weapon1turrety", "130.0"
            ]
          extras = Map.ofList [
                "usepiececollisionvolumes", "1.0"
                "leavetracks", "true"
                "nochasecategory", "VTOL"
                "sonardistance", "180.0"
                "trackoffset", "3.0"
                "trackstrength", "6.0"
                "tracktype", "armpincer_tracks"
                "trackwidth", "28.0"
            ] }

    type Legbar =
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

    let legbar : Legbar =
        { name = "legbar"
          subfolder = "Legion/Vehicles"
          metalCost = ValueOrExpr.Concrete 250.0
          energyCost = ValueOrExpr.Concrete 3200.0
          buildTime = ValueOrExpr.Concrete 3600.0
          health = ValueOrExpr.Concrete 1500.0
          sightDistance = ValueOrExpr.Concrete 400.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 40.5
          maxAcc = 0.01654
          maxDec = 0.054
          turnRate = 240.0
          movementClass = "TANK3"
          maxSlope = 17.0
          maxWaterDepth = 12.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 0.957
          weapons = [
                { name = "clusternapalm"
                  displayName = Some "Napalm Launcher"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 60.0
                      "subs", 10.0
                      "vtol", 10.0
                  ]
                  range = Some (ValueOrExpr.Concrete 535.0)
                  reloadTime = Some (ValueOrExpr.Concrete 5.0)
                  weaponVelocity = Some 250.0
                  areaOfEffect = Some 120.0
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
                      "area_onhit_ceg", "fire-area-60-repeat"
                      "area_onhit_damageCeg", "burnflamel-gen"
                      "area_onhit_resistance", "fire"
                  ]
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "cegtag", "burnflame"
                      "colormap", "0.75 0.73 0.67 0.024   0.37 0.4 0.30 0.021   0.22 0.21 0.14 0.018  0.024 0.014 0.009 0.03   0.0 0.0 0.0 0.008"
                      "craterareaofeffect", "90.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "flamegfxtime", "1.0"
                      "gravityaffected", "true"
                      "leadlimit", "0.0"
                      "mygravity", "0.1"
                      "projectiles", "1.0"
                      "size", "6.0"
                      "soundhitdry", "flamhit1"
                      "soundhitwet", "sizzle"
                      "sprayangle", "600.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "33 18 33"
                  collisionVolumeType = Some "Box"
                  damage = Some 650.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 15.0
                  metal = Some 192.0
                  object_ = Some "Units/legbar_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 325.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 96.0
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
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/corgol_aoplane.dds"
                "buildinggrounddecalsizey", "4.0"
                "buildinggrounddecalsizex", "4.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalalpha", "0.5"
                "unitgroup", "weapon"
                "basename", "base"
                "firingceg", "barrelshot-medium"
                "kickback", "-2.4"
                "model_author", "Tharsis"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "CorVehicles/T2"
                "weapon1turretx", "30.0"
                "weapon1turrety", "40.0"
            ]
          extras = Map.ofList [
                "leavetracks", "true"
                "nochasecategory", "VTOL"
                "trackoffset", "8.0"
                "trackstrength", "7.0"
                "tracktype", "corwidetracks"
                "trackwidth", "32.0"
            ] }

    type Leggat =
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

    let leggat : Leggat =
        { name = "leggat"
          subfolder = "Legion/Vehicles"
          metalCost = ValueOrExpr.Concrete 300.0
          energyCost = ValueOrExpr.Concrete 3600.0
          buildTime = ValueOrExpr.Concrete 4800.0
          health = ValueOrExpr.Concrete 2550.0
          sightDistance = ValueOrExpr.Concrete 400.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 45.0
          maxAcc = 0.02
          maxDec = 0.04
          turnRate = 300.0
          movementClass = "TANK3"
          maxSlope = 10.0
          maxWaterDepth = 12.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.952
          weapons = [
                { name = "armmg_weapon"
                  displayName = Some "Rapid-fire Machine Gun"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "default", 12.0
                      "vtol", 3.0
                  ]
                  range = Some (ValueOrExpr.Concrete 361.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.4)
                  weaponVelocity = Some 900.0
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
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTSUB"
                      "mount_burstControlWhenOutOfArc", "2.0"
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
                      "sprayangle", "1600.0"
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
                  collisionVolumeOffsets = Some "0 -2 0"
                  collisionVolumeScales = Some "34 16 40"
                  collisionVolumeType = Some "Box"
                  damage = Some 1056.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 200.0
                  object_ = Some "Units/leggat_dead.s3o"
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
                "model_author", "Protar"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Vehicles"
                "weapon1turretx", "45.0"
                "weapon1turrety", "80.0"
            ]
          extras = Map.ofList [
                "leavetracks", "true"
                "nochasecategory", "VTOL"
                "trackoffset", "3.0"
                "trackstrength", "6.0"
                "tracktype", "armstump_tracks"
                "trackwidth", "38.0"
            ] }

    type Leghades =
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

    let leghades : Leghades =
        { name = "leghades"
          subfolder = "Legion/Vehicles"
          metalCost = ValueOrExpr.Concrete 65.0
          energyCost = ValueOrExpr.Concrete 850.0
          buildTime = ValueOrExpr.Concrete 1650.0
          health = ValueOrExpr.Concrete 425.0
          sightDistance = ValueOrExpr.Concrete 300.0
          footprintX = 1.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 102.0
          maxAcc = 0.06788
          maxDec = 0.13575
          turnRate = 544.0
          movementClass = "TANK2"
          maxSlope = 10.0
          maxWaterDepth = 12.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 2.424
          weapons = [
                { name = "gauss"
                  displayName = Some "Close-quarters g2g gauss-cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 75.0
                      "vtol", 25.0
                  ]
                  range = Some (ValueOrExpr.Concrete 210.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.3)
                  weaponVelocity = Some 550.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "cannhvy1"
                  soundHit = Some "xplomed1"
                  explosiongenerator = Some "custom:genericshellexplosion-small"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "impactonly", "1.0"
                      "predictboost", "1.0"
                      "size", "2.0"
                      "soundhitwet", "splsmed"
                      "soundstartvolume", "2.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -1 0"
                  collisionVolumeScales = Some "16 10 23"
                  collisionVolumeType = Some "Box"
                  damage = Some 250.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 40.0
                  object_ = Some "Units/leghades_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 193.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 20.0
                  object_ = Some "Units/arm2X2C.s3o"
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
                ok = ["veht1emgok"]
                select = ["veht1emgsel"] }
          customParams = Map.ofList [
                "unitgroup", "weapon"
                "basename", "base"
                "firingceg", "barrelshot-tiny"
                "kickback", "-2"
                "model_author", "Tharsis"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "ArmVehicles"
                "weapon1turretx", "240.0"
                "weapon1turrety", "240.0"
            ]
          extras = Map.ofList [
                "leavetracks", "true"
                "nochasecategory", "VTOL"
                "trackoffset", "5.0"
                "trackstrength", "4.0"
                "tracktype", "armpincer_tracks"
                "trackwidth", "22.0"
            ] }

    type Leghelios =
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

    let leghelios : Leghelios =
        { name = "leghelios"
          subfolder = "Legion/Vehicles"
          metalCost = ValueOrExpr.Concrete 160.0
          energyCost = ValueOrExpr.Concrete 2400.0
          buildTime = ValueOrExpr.Concrete 2600.0
          health = ValueOrExpr.Concrete 800.0
          sightDistance = ValueOrExpr.Concrete 360.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 69.0
          maxAcc = 0.05
          maxDec = 0.1
          turnRate = 400.0
          movementClass = "TANK3"
          maxSlope = 10.0
          maxWaterDepth = 12.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.96
          weapons = [
                { name = "heat_ray"
                  displayName = Some "Light g2g Heat Ray"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 160.0
                      "vtol", 25.0
                  ]
                  range = Some (ValueOrExpr.Concrete 330.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.3)
                  weaponVelocity = Some 950.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "heliosfire"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small"
                  rgbColor = Some "1 0.55 0"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "beamtime", "0.5"
                      "corethickness", "0.23"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "30.0"
                      "impactonly", "1.0"
                      "laserflaresize", "5.0"
                      "leadlimit", "0.0"
                      "rgbcolor2", "0.9 1.0 0.5"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "2.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -4 1"
                  collisionVolumeScales = Some "30 12 28"
                  collisionVolumeType = Some "Box"
                  damage = Some 550.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 105.0
                  object_ = Some "Units/leghelios_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 225.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 45.0
                  object_ = Some "units/cor2x2f.s3o"
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
                "cannon1name", "barrel"
                "driftratio", "0.6"
                "firingceg", "barrelshot-tiny"
                "flare1name", "flare"
                "kickback", "-2.0"
                "model_author", "ZephyrSkies"
                "normaltex", "unittextures/leg_normal.dds"
                "restoretime", "3000"
                "rockstrength", "0"
                "sleevename", "turret"
                "subfolder", "CorVehicles"
                "turretname", "turret"
                "wpn1turretx", "192.5"
                "wpn1turrety", "192.5"
            ]
          extras = Map.ofList [
                "usepiececollisionvolumes", "1.0"
                "leavetracks", "true"
                "nochasecategory", "VTOL"
                "trackoffset", "14.0"
                "trackstrength", "5.0"
                "tracktype", "corwidetracks"
                "trackwidth", "28.0"
            ] }

    type Legmlv =
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
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legmlv : Legmlv =
        { name = "legmlv"
          subfolder = "Legion/Vehicles"
          metalCost = ValueOrExpr.Concrete 52.0
          energyCost = ValueOrExpr.Concrete 900.0
          buildTime = ValueOrExpr.Concrete 3640.0
          health = ValueOrExpr.Concrete 210.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 69.0
          maxAcc = 0.06681
          maxDec = 0.1327
          turnRate = 580.0
          movementClass = "TANK2"
          maxSlope = 16.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.62228
          workerTime = ValueOrExpr.Concrete 40.0
          buildDistance = 96.0
          buildOptions = ["legmine1"; "legmine2"; "legmine3"; "legdrag"; "legeyes"]
          terraformSpeed = 120.0
          weapons = [
                { name = "minesweep"
                  displayName = Some "Seismic charge"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 15.0
                  ]
                  range = Some (ValueOrExpr.Concrete 220.0)
                  reloadTime = Some (ValueOrExpr.Concrete 3.0)
                  weaponVelocity = Some 275.0
                  areaOfEffect = Some 48.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 3000.0
                  edgeEffectiveness = Some 0.4
                  impulseFactor = None
                  noSelfDamage = Some true
                  soundStart = None
                  soundHit = None
                  explosiongenerator = Some "custom:MINESWEEP"
                  rgbColor = Some "0.2 0.6 0.2"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "MINE"
                      "avoidfeature", "false"
                      "collidefriendly", "false"
                      "craterareaofeffect", "48.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firetolerance", "3000.0"
                      "weapontimer", "0.1"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -1 0"
                  collisionVolumeScales = Some "22 10 25"
                  collisionVolumeType = Some "Box"
                  damage = Some 133.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 37.0
                  object_ = Some "Units/legmlv_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 60.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 15.0
                  object_ = Some "Units/cor3X3F.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = Some "nanlath2"
                repair = Some "repair2"
                working = Some "reclaim1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = Some "capture1"
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["vcormove"]
                select = ["vcorsel"] }
          customParams = Map.ofList [
                "minesweeper", "450.0"
                "model_author", "Tharsis"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Vehicles"
                "unitgroup", "builder"
            ]
          extras = Map.ofList [
                "canassist", "false"
                "canreclaim", "false"
                "canrepair", "true"
                "canrestore", "false"
                "leavetracks", "true"
                "mass", "740.0"
                "nochasecategory", "VTOL"
                "radardistancejam", "64.0"
                "stealth", "true"
                "trackoffset", "12.0"
                "trackstrength", "5.0"
                "tracktype", "corwidetracks"
                "trackwidth", "17.0"
            ] }

    type Legrail =
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

    let legrail : Legrail =
        { name = "legrail"
          subfolder = "Legion/Vehicles"
          metalCost = ValueOrExpr.Concrete 240.0
          energyCost = ValueOrExpr.Concrete 3800.0
          buildTime = ValueOrExpr.Concrete 3800.0
          health = ValueOrExpr.Concrete 1100.0
          sightDistance = ValueOrExpr.Concrete 525.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 46.5
          maxAcc = 0.0236
          maxDec = 0.08
          turnRate = 250.0
          movementClass = "TANK3"
          maxSlope = 16.0
          maxWaterDepth = 12.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.056
          weapons = [
                { name = "railgun"
                  displayName = Some "Railgun"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "commanders", 100.0
                      "default", 200.0
                  ]
                  range = Some (ValueOrExpr.Concrete 650.0)
                  reloadTime = Some (ValueOrExpr.Concrete 7.5)
                  weaponVelocity = Some 3240.0
                  areaOfEffect = Some 16.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 6000.0
                  edgeEffectiveness = Some 0.85
                  impulseFactor = Some 1.0
                  noSelfDamage = Some true
                  soundStart = Some "lancefire"
                  soundHit = Some "mavgun3"
                  explosiongenerator = Some "custom:plasmahit-sparkonly"
                  rgbColor = Some "0.34 0.64 0.94"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "210.0"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "true"
                      "burnblow", "false"
                      "cegtag", "railgun"
                      "collisionsize", "0.7"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "0.12"
                      "firestarter", "0.0"
                      "hardstop", "true"
                      "impactonly", "true"
                      "intensity", "0.8"
                      "noexplode", "true"
                      "ownerExpAccWeight", "4.0"
                      "proximitypriority", "1.0"
                      "soundhitwet", "splshbig"
                      "soundstartvolume", "13.0"
                      "texture1", "shot"
                      "texture2", "empty"
                      "thickness", "3.0"
                  ] }
                { name = "aa_railgun"
                  displayName = Some "Railgun"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "default", 1.0
                      "vtol", 300.0
                  ]
                  range = Some (ValueOrExpr.Concrete 750.0)
                  reloadTime = Some (ValueOrExpr.Concrete 4.0)
                  weaponVelocity = Some 3214.0
                  areaOfEffect = Some 16.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 6000.0
                  edgeEffectiveness = Some 0.85
                  impulseFactor = Some 1.0
                  noSelfDamage = Some true
                  soundStart = Some "lancefire"
                  soundHit = Some "mavgun3"
                  explosiongenerator = Some "custom:plasmahit-sparkonly"
                  rgbColor = Some "1 0.33 0.7"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "NOTAIR"
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfeature", "true"
                      "burnblow", "false"
                      "canattackground", "false"
                      "cegtag", "railgun"
                      "collisionsize", "0.7"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "0.12"
                      "firestarter", "0.0"
                      "hardstop", "true"
                      "impactonly", "true"
                      "intensity", "0.8"
                      "noexplode", "true"
                      "ownerExpAccWeight", "4.0"
                      "proximitypriority", "1.0"
                      "soundhitwet", "splshbig"
                      "soundstartvolume", "13.0"
                      "texture1", "shot"
                      "texture2", "empty"
                      "thickness", "3.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "1.01370239258 -1.0546875e-05 -0.0623321533203"
                  collisionVolumeScales = Some "34.0520019531 26.7133789063 42.7676696777"
                  collisionVolumeType = Some "Box"
                  damage = Some 639.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 180.0
                  object_ = Some "Units/legrail_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 320.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 80.0
                  object_ = Some "Units/arm3X3D.s3o"
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
                ok = ["veht1aaok"]
                select = ["veht1aasel"] }
          customParams = Map.ofList [
                "maxrange", "625.0"
                "unitgroup", "weaponaa"
                "model_author", "Tharsis"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "ArmVehicles"
            ]
          extras = Map.ofList [
                "airsightdistance", "900.0"
                "leavetracks", "true"
                "trackoffset", "6.0"
                "trackstrength", "5.0"
                "tracktype", "armbull_tracks"
                "trackwidth", "32.0"
                "usepiececollisionvolumes", "1.0"
            ] }

    type Legscout =
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

    let legscout : Legscout =
        { name = "legscout"
          subfolder = "Legion/Vehicles"
          metalCost = ValueOrExpr.Concrete 23.0
          energyCost = ValueOrExpr.Concrete 350.0
          buildTime = ValueOrExpr.Concrete 900.0
          health = ValueOrExpr.Concrete 75.0
          sightDistance = ValueOrExpr.Concrete 635.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 160.0
          maxAcc = 0.16659
          maxDec = 0.33318
          turnRate = 750.0
          movementClass = "TANK2"
          maxSlope = 26.0
          maxWaterDepth = 12.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 4.224
          weapons = [
                { name = "gun"
                  displayName = Some "Burst-fire Machine Gun"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "default", 11.0
                      "vtol", 1.0
                  ]
                  range = Some (ValueOrExpr.Concrete 169.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.4)
                  weaponVelocity = Some 720.0
                  areaOfEffect = Some 16.0
                  accuracy = Some 13.0
                  turret = Some true
                  tolerance = Some 6000.0
                  edgeEffectiveness = Some 0.5
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "mgun3"
                  soundHit = Some "bimpact3"
                  explosiongenerator = Some "custom:plasmahit-sparkonly"
                  rgbColor = Some "1 0.95 0.4"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "burst", "3.0"
                      "burstrate", "0.066"
                      "burnblow", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "0.04"
                      "intensity", "0.8"
                      "ownerExpAccWeight", "2.0"
                      "soundhitwet", "splshbig"
                      "soundtrigger", "true"
                      "sprayangle", "1024.0"
                      "texture1", "shot"
                      "texture2", "empty"
                      "thickness", "2.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -3 0"
                  collisionVolumeScales = Some "14 16 14"
                  collisionVolumeType = Some "Box"
                  damage = Some 111.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 15.0
                  object_ = Some "Units/legscout_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 56.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 6.0
                  object_ = Some "Units/arm2X2F.s3o"
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
                ok = ["veht1buggyok"]
                select = ["veht1buggysel"] }
          customParams = Map.ofList [
                "unitgroup", "weapon"
                "basename", "body"
                "firingceg", "barrelshot-small"
                "kickback", "0"
                "lumamult", "1.3"
                "model_author", "Flaka"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion"
            ]
          extras = Map.ofList [
                "leavetracks", "false"
                "nochasecategory", "VTOL"
                "trackoffset", "-2.0"
                "trackstrength", "5.0"
                "tracktype", "armstump_tracks"
                "trackwidth", "20.0"
            ] }

