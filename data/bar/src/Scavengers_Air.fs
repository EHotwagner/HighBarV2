// Auto-generated BAR unit data: Scavengers/Air (unified)
namespace BarData.Units

open BarData

module Scavengers_Air =

    type Armfepocht4 =
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
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          maxWaterDepth: float
          canFly: bool
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          cruiseAltitude: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armfepocht4 : Armfepocht4 =
        { name = "armfepocht4"
          subfolder = "Scavengers/Air"
          printableName = Some "Flying Epoch"
          metalCost = ValueOrExpr.Concrete 25000.0
          energyCost = ValueOrExpr.Concrete 250000.0
          buildTime = ValueOrExpr.Concrete 250000.0
          health = ValueOrExpr.Concrete 67000.0
          sightDistance = ValueOrExpr.Concrete 689.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/scavboss/armfepocht4.s3o"
          buildPic = Some "armfepocht4.DDS"
          script = Some "Units/scavboss/armfepocht4.cob"
          corpse = Some "DEAD"
          explodeAs = Some "flagshipExplosion"
          selfDestructAs = Some "flagshipExplosionSelfd"
          collisionVolumeOffsets = Some "0 -14 10"
          collisionVolumeScales = Some "70 70 170"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = Some "T4AIR"
          speed = ValueOrExpr.Concrete 36.0
          maxAcc = 0.015
          maxDec = 0.05
          turnRate = 135.0
          maxWaterDepth = 15.0
          canFly = true
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          cruiseAltitude = 100.0
          weapons = [
                { name = "heavyplasma"
                  displayName = "Primary rapid-fire heavy long-range plasma cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 290.0
                      "subs", 100.0
                      "vtol", 130.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1500.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.0)
                  weaponVelocity = Some 600.0
                  areaOfEffect = Some 64.0
                  accuracy = Some 1200.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "cannhvy1"
                  soundHit = Some "xplomed2"
                  explosiongenerator = Some "custom:genericshellexplosion-large"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE T4AIR"
                      "avoidfeature", "false"
                      "cegtag", "arty-heavy"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "soundhitwet", "splssml"
                  ] }
                { name = "mediumplasma"
                  displayName = "Secondary rapid-fire heavy plasma cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 270.0
                      "subs", 65.0
                      "vtol", 65.0
                  ]
                  range = Some (ValueOrExpr.Concrete 830.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.5)
                  weaponVelocity = Some 570.0
                  areaOfEffect = Some 128.0
                  accuracy = Some 500.0
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "cannhvy1"
                  soundHit = Some "xplomed2"
                  explosiongenerator = Some "custom:genericshellexplosion-medium"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "320.0"
                      "mount_onlytargetcategory", "SURFACE T4AIR"
                      "avoidfeature", "false"
                      "cegtag", "arty-fast"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "soundhitwet", "splsmed"
                  ] }
                { name = "heavyplasma"
                  displayName = "Primary rapid-fire heavy long-range plasma cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 290.0
                      "subs", 100.0
                      "vtol", 130.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1500.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.0)
                  weaponVelocity = Some 600.0
                  areaOfEffect = Some 64.0
                  accuracy = Some 1200.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "cannhvy1"
                  soundHit = Some "xplomed2"
                  explosiongenerator = Some "custom:genericshellexplosion-large"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "240.0"
                      "mount_onlytargetcategory", "SURFACE T4AIR"
                      "avoidfeature", "false"
                      "cegtag", "arty-heavy"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "soundhitwet", "splssml"
                  ] }
                { name = "mediumplasma"
                  displayName = "Secondary rapid-fire heavy plasma cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 270.0
                      "subs", 65.0
                      "vtol", 65.0
                  ]
                  range = Some (ValueOrExpr.Concrete 830.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.5)
                  weaponVelocity = Some 570.0
                  areaOfEffect = Some 128.0
                  accuracy = Some 500.0
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "cannhvy1"
                  soundHit = Some "xplomed2"
                  explosiongenerator = Some "custom:genericshellexplosion-medium"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "-4 0 1"
                      "mount_maxangledif", "180.0"
                      "mount_onlytargetcategory", "SURFACE T4AIR"
                      "avoidfeature", "false"
                      "cegtag", "arty-fast"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "soundhitwet", "splsmed"
                  ] }
                { name = "mediumplasma"
                  displayName = "Secondary rapid-fire heavy plasma cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 270.0
                      "subs", 65.0
                      "vtol", 65.0
                  ]
                  range = Some (ValueOrExpr.Concrete 830.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.5)
                  weaponVelocity = Some 570.0
                  areaOfEffect = Some 128.0
                  accuracy = Some 500.0
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "cannhvy1"
                  soundHit = Some "xplomed2"
                  explosiongenerator = Some "custom:genericshellexplosion-medium"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "4 0 1"
                      "mount_maxangledif", "180.0"
                      "mount_onlytargetcategory", "SURFACE T4AIR"
                      "avoidfeature", "false"
                      "cegtag", "arty-fast"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "soundhitwet", "splsmed"
                  ] }
                { name = "ferret_missile"
                  displayName = "Pop-up rapid-fire g2a missile launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "vtol", 50.0
                  ]
                  range = Some (ValueOrExpr.Concrete 840.0)
                  reloadTime = Some (ValueOrExpr.Concrete 3.4)
                  weaponVelocity = Some 1200.0
                  areaOfEffect = Some 16.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 9950.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "packolau"
                  soundHit = Some "packohit"
                  explosiongenerator = Some "custom:genericshellexplosion-tiny-aa"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                      "mount_maindir", "0 -1 -2"
                      "mount_maxangledif", "270.0"
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfeature", "false"
                      "burst", "2.0"
                      "burstrate", "0.2"
                      "burnblow", "true"
                      "canattackground", "false"
                      "cegtag", "missiletrailaa"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "0.0"
                      "firestarter", "72.0"
                      "flighttime", "2.5"
                      "metalpershot", "0.0"
                      "model", "cormissile.s3o"
                      "smoketrail", "true"
                      "smokePeriod", "5.0"
                      "smoketime", "12.0"
                      "smokesize", "4.8"
                      "smokecolor", "0.95"
                      "smokeTrailCastShadow", "false"
                      "castshadow", "false"
                      "soundhitwet", "splshbig"
                      "soundtrigger", "true"
                      "startvelocity", "1.0"
                      "texture1", "null"
                      "texture2", "smoketrailaa"
                      "tracks", "true"
                      "turnrate", "68000.0"
                      "weaponacceleration", "1500.0"
                      "weapontimer", "2.0"
                  ] }
                { name = "ferret_missile"
                  displayName = "Pop-up rapid-fire g2a missile launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "vtol", 50.0
                  ]
                  range = Some (ValueOrExpr.Concrete 840.0)
                  reloadTime = Some (ValueOrExpr.Concrete 3.4)
                  weaponVelocity = Some 1200.0
                  areaOfEffect = Some 16.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 9950.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "packolau"
                  soundHit = Some "packohit"
                  explosiongenerator = Some "custom:genericshellexplosion-tiny-aa"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfeature", "false"
                      "burst", "2.0"
                      "burstrate", "0.2"
                      "burnblow", "true"
                      "canattackground", "false"
                      "cegtag", "missiletrailaa"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "0.0"
                      "firestarter", "72.0"
                      "flighttime", "2.5"
                      "metalpershot", "0.0"
                      "model", "cormissile.s3o"
                      "smoketrail", "true"
                      "smokePeriod", "5.0"
                      "smoketime", "12.0"
                      "smokesize", "4.8"
                      "smokecolor", "0.95"
                      "smokeTrailCastShadow", "false"
                      "castshadow", "false"
                      "soundhitwet", "splshbig"
                      "soundtrigger", "true"
                      "startvelocity", "1.0"
                      "texture1", "null"
                      "texture2", "smoketrailaa"
                      "tracks", "true"
                      "turnrate", "68000.0"
                      "weaponacceleration", "1500.0"
                      "weapontimer", "2.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.439918518066 -4.07348632798e-05 0.367340087891"
                  collisionVolumeScales = Some "75.0081939697 51.5621185303 178.425750732"
                  collisionVolumeType = Some "Box"
                  damage = Some 30000.0
                  featureDead = Some "HEAP"
                  footprintX = Some 6.0
                  footprintZ = Some 18.0
                  height = Some 4.0
                  metal = Some 17000.0
                  object_ = Some "Units/scavboss/armfepocht4_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 15000.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 8500.0
                  object_ = Some "Units/arm6X6A.s3o"
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
                ok = ["sharmmov"]
                select = ["sharmsel"] }
          customParams = Map.ofList [
                "unitgroup", "weapon"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "paralyzemultiplier", "0.0"
                "subfolder", "ArmShips/T2"
                "techlevel", "3.0"
            ]
          extras = Map.ofList [
                "bankingallowed", "false"
                "buildangle", "16384.0"
                "collide", "true"
                "hoverattack", "true"
                "sightemitheight", "52.0"
                "mass", "1000000.0"
                "nochasecategory", "VTOL"
                "radardistance", "1530.0"
                "radaremitheight", "52.0"
                "upright", "true"
            ] }

    let armfepocht4Def : UnitDef =
        { name = "armfepocht4"
          subfolder = "Scavengers/Air"
          printableName = Some "Flying Epoch"
          metalCost = ValueOrExpr.Concrete 25000.0
          energyCost = ValueOrExpr.Concrete 250000.0
          buildTime = ValueOrExpr.Concrete 250000.0
          health = ValueOrExpr.Concrete 67000.0
          sightDistance = ValueOrExpr.Concrete 689.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/scavboss/armfepocht4.s3o"
          buildPic = Some "armfepocht4.DDS"
          script = Some "Units/scavboss/armfepocht4.cob"
          corpse = Some "DEAD"
          explodeAs = Some "flagshipExplosion"
          selfDestructAs = Some "flagshipExplosionSelfd"
          collisionVolumeOffsets = Some "0 -14 10"
          collisionVolumeScales = Some "70 70 170"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = Some "T4AIR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 36.0
              maxAcc = 0.015
              maxDec = 0.05
              turnRate = 135.0
              movementClass = None
              maxSlope = None
              maxWaterDepth = Some 15.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 100.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "heavyplasma"
                displayName = "Primary rapid-fire heavy long-range plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 290.0
                    "subs", 100.0
                    "vtol", 130.0
                ]
                range = Some (ValueOrExpr.Concrete 1500.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
                weaponVelocity = Some 600.0
                areaOfEffect = Some 64.0
                accuracy = Some 1200.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "cannhvy1"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:genericshellexplosion-large"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE T4AIR"
                    "avoidfeature", "false"
                    "cegtag", "arty-heavy"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splssml"
                ] }
              { name = "mediumplasma"
                displayName = "Secondary rapid-fire heavy plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 270.0
                    "subs", 65.0
                    "vtol", 65.0
                ]
                range = Some (ValueOrExpr.Concrete 830.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.5)
                weaponVelocity = Some 570.0
                areaOfEffect = Some 128.0
                accuracy = Some 500.0
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "cannhvy1"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:genericshellexplosion-medium"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "320.0"
                    "mount_onlytargetcategory", "SURFACE T4AIR"
                    "avoidfeature", "false"
                    "cegtag", "arty-fast"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splsmed"
                ] }
              { name = "heavyplasma"
                displayName = "Primary rapid-fire heavy long-range plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 290.0
                    "subs", 100.0
                    "vtol", 130.0
                ]
                range = Some (ValueOrExpr.Concrete 1500.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
                weaponVelocity = Some 600.0
                areaOfEffect = Some 64.0
                accuracy = Some 1200.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "cannhvy1"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:genericshellexplosion-large"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "240.0"
                    "mount_onlytargetcategory", "SURFACE T4AIR"
                    "avoidfeature", "false"
                    "cegtag", "arty-heavy"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splssml"
                ] }
              { name = "mediumplasma"
                displayName = "Secondary rapid-fire heavy plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 270.0
                    "subs", 65.0
                    "vtol", 65.0
                ]
                range = Some (ValueOrExpr.Concrete 830.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.5)
                weaponVelocity = Some 570.0
                areaOfEffect = Some 128.0
                accuracy = Some 500.0
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "cannhvy1"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:genericshellexplosion-medium"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "-4 0 1"
                    "mount_maxangledif", "180.0"
                    "mount_onlytargetcategory", "SURFACE T4AIR"
                    "avoidfeature", "false"
                    "cegtag", "arty-fast"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splsmed"
                ] }
              { name = "mediumplasma"
                displayName = "Secondary rapid-fire heavy plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 270.0
                    "subs", 65.0
                    "vtol", 65.0
                ]
                range = Some (ValueOrExpr.Concrete 830.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.5)
                weaponVelocity = Some 570.0
                areaOfEffect = Some 128.0
                accuracy = Some 500.0
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "cannhvy1"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:genericshellexplosion-medium"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "4 0 1"
                    "mount_maxangledif", "180.0"
                    "mount_onlytargetcategory", "SURFACE T4AIR"
                    "avoidfeature", "false"
                    "cegtag", "arty-fast"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splsmed"
                ] }
              { name = "ferret_missile"
                displayName = "Pop-up rapid-fire g2a missile launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 50.0
                ]
                range = Some (ValueOrExpr.Concrete 840.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.4)
                weaponVelocity = Some 1200.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = Some 9950.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "packolau"
                soundHit = Some "packohit"
                explosiongenerator = Some "custom:genericshellexplosion-tiny-aa"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                    "mount_maindir", "0 -1 -2"
                    "mount_maxangledif", "270.0"
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "burst", "2.0"
                    "burstrate", "0.2"
                    "burnblow", "true"
                    "canattackground", "false"
                    "cegtag", "missiletrailaa"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "0.0"
                    "firestarter", "72.0"
                    "flighttime", "2.5"
                    "metalpershot", "0.0"
                    "model", "cormissile.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "5.0"
                    "smoketime", "12.0"
                    "smokesize", "4.8"
                    "smokecolor", "0.95"
                    "smokeTrailCastShadow", "false"
                    "castshadow", "false"
                    "soundhitwet", "splshbig"
                    "soundtrigger", "true"
                    "startvelocity", "1.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa"
                    "tracks", "true"
                    "turnrate", "68000.0"
                    "weaponacceleration", "1500.0"
                    "weapontimer", "2.0"
                ] }
              { name = "ferret_missile"
                displayName = "Pop-up rapid-fire g2a missile launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 50.0
                ]
                range = Some (ValueOrExpr.Concrete 840.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.4)
                weaponVelocity = Some 1200.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = Some 9950.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "packolau"
                soundHit = Some "packohit"
                explosiongenerator = Some "custom:genericshellexplosion-tiny-aa"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "burst", "2.0"
                    "burstrate", "0.2"
                    "burnblow", "true"
                    "canattackground", "false"
                    "cegtag", "missiletrailaa"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "0.0"
                    "firestarter", "72.0"
                    "flighttime", "2.5"
                    "metalpershot", "0.0"
                    "model", "cormissile.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "5.0"
                    "smoketime", "12.0"
                    "smokesize", "4.8"
                    "smokecolor", "0.95"
                    "smokeTrailCastShadow", "false"
                    "castshadow", "false"
                    "soundhitwet", "splshbig"
                    "soundtrigger", "true"
                    "startvelocity", "1.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa"
                    "tracks", "true"
                    "turnrate", "68000.0"
                    "weaponacceleration", "1500.0"
                    "weapontimer", "2.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.439918518066 -4.07348632798e-05 0.367340087891"
                collisionVolumeScales = Some "75.0081939697 51.5621185303 178.425750732"
                collisionVolumeType = Some "Box"
                damage = Some 30000.0
                featureDead = Some "HEAP"
                footprintX = Some 6.0
                footprintZ = Some 18.0
                height = Some 4.0
                metal = Some 17000.0
                object_ = Some "Units/scavboss/armfepocht4_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 15000.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 8500.0
                object_ = Some "Units/arm6X6A.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = None
              repair = None
              working = None
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["sharmmov"]
              select = ["sharmsel"] })
          customParams = Map.ofList [
              "unitgroup", "weapon"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "paralyzemultiplier", "0.0"
              "subfolder", "ArmShips/T2"
              "techlevel", "3.0"
          ]
          extras = Map.ofList [
              "bankingallowed", "false"
              "buildangle", "16384.0"
              "collide", "true"
              "hoverattack", "true"
              "sightemitheight", "52.0"
              "mass", "1000000.0"
              "nochasecategory", "VTOL"
              "radardistance", "1530.0"
              "radaremitheight", "52.0"
              "upright", "true"
          ] }

    let armfepocht4ToFlat (def: UnitDef) : Armfepocht4 =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canFly = def.movement.Value.canFly
          canMove = def.movement.Value.canMove
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          cruiseAltitude = def.movement.Value.cruiseAltitude.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armfepocht4ToUnitDef (flat: Armfepocht4) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = None
              maxSlope = None
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = flat.canFly
              canMove = flat.canMove
              floater = false
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some flat.cruiseAltitude
              minWaterDepth = None
              waterline = None
            }
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armfify =
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
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          maxSlope: float
          maxWaterDepth: float
          canFly: bool
          canMove: bool
          turnInPlaceAngleLimit: float
          cruiseAltitude: float
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armfify : Armfify =
        { name = "armfify"
          subfolder = "Scavengers/Air"
          printableName = Some "Firefly"
          metalCost = ValueOrExpr.Concrete 58.0
          energyCost = ValueOrExpr.Concrete 2900.0
          buildTime = ValueOrExpr.Concrete 3800.0
          health = ValueOrExpr.Concrete 83.0
          sightDistance = ValueOrExpr.Concrete 364.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMFIFY.s3o"
          buildPic = Some "ARMFIFY.DDS"
          script = Some "Units/ARMFIFY.cob"
          corpse = None
          explodeAs = Some "tinyExplosionGeneric"
          selfDestructAs = Some "tinyExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 208.0
          maxAcc = 0.25
          maxDec = 0.55
          turnRate = 1100.0
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canFly = true
          canMove = true
          turnInPlaceAngleLimit = 360.0
          cruiseAltitude = 78.0
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["vtolcrmv"]
                select = ["vtolcrac"] }
          customParams = Map.ofList [
                "model_author", "Darknagura, Fritman"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmAircraft"
                "unitgroup", "builder"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "canassist", "false"
                "canrepair", "true"
                "canrestore", "true"
                "canresurrect", "true"
                "cantbetransported", "false"
                "collide", "true"
                "hoverattack", "true"
                "nochasecategory", "COMMANDER VTOL"
                "stealth", "true"
                "upright", "true"
                "usesmoothmesh", "0.0"
            ] }

    let armfifyDef : UnitDef =
        { name = "armfify"
          subfolder = "Scavengers/Air"
          printableName = Some "Firefly"
          metalCost = ValueOrExpr.Concrete 58.0
          energyCost = ValueOrExpr.Concrete 2900.0
          buildTime = ValueOrExpr.Concrete 3800.0
          health = ValueOrExpr.Concrete 83.0
          sightDistance = ValueOrExpr.Concrete 364.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMFIFY.s3o"
          buildPic = Some "ARMFIFY.DDS"
          script = Some "Units/ARMFIFY.cob"
          corpse = None
          explodeAs = Some "tinyExplosionGeneric"
          selfDestructAs = Some "tinyExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 208.0
              maxAcc = 0.25
              maxDec = 0.55
              turnRate = 1100.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 360.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 78.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = Some (
            { build = None
              repair = None
              working = None
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["vtolcrmv"]
              select = ["vtolcrac"] })
          customParams = Map.ofList [
              "model_author", "Darknagura, Fritman"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmAircraft"
              "unitgroup", "builder"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "canassist", "false"
              "canrepair", "true"
              "canrestore", "true"
              "canresurrect", "true"
              "cantbetransported", "false"
              "collide", "true"
              "hoverattack", "true"
              "nochasecategory", "COMMANDER VTOL"
              "stealth", "true"
              "upright", "true"
              "usesmoothmesh", "0.0"
          ] }

    let armfifyToFlat (def: UnitDef) : Armfify =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canFly = def.movement.Value.canFly
          canMove = def.movement.Value.canMove
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          cruiseAltitude = def.movement.Value.cruiseAltitude.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armfifyToUnitDef (flat: Armfify) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = None
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = flat.canFly
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some flat.cruiseAltitude
              minWaterDepth = None
              waterline = None
            }
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armlichet4 =
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
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          maxSlope: float
          maxWaterDepth: float
          canFly: bool
          canMove: bool
          cruiseAltitude: float
          weapons: WeaponDef list
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armlichet4 : Armlichet4 =
        { name = "armlichet4"
          subfolder = "Scavengers/Air"
          printableName = Some "Epic Liche"
          metalCost = ValueOrExpr.Concrete 18000.0
          energyCost = ValueOrExpr.Concrete 240000.0
          buildTime = ValueOrExpr.Concrete 240000.0
          health = ValueOrExpr.Concrete 10000.0
          sightDistance = ValueOrExpr.Concrete 455.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/scavboss/ARMLICHET4.s3o"
          buildPic = Some "ARMLICHE.DDS"
          script = Some "Units/ARMLICHE.cob"
          corpse = None
          explodeAs = Some "hugeexplosiongeneric"
          selfDestructAs = Some "hugeExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = Some "T4AIR"
          speed = ValueOrExpr.Concrete 180.0
          maxAcc = 0.1075
          maxDec = 0.05
          turnRate = 256.0
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canFly = true
          canMove = true
          cruiseAltitude = 150.0
          weapons = [
                { name = "nuclear_missile"
                  displayName = "Intercontinental ballistic nuclear warhead"
                  weaponType = Some "AircraftBomb"
                  damage = Map.ofList [
                      "commanders", 2500.0
                      "default", 9500.0
                      "vtol", 2000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 800.0)
                  reloadTime = Some (ValueOrExpr.Concrete 120.0)
                  weaponVelocity = Some 1600.0
                  areaOfEffect = Some 1280.0
                  accuracy = None
                  turret = None
                  tolerance = Some 4000.0
                  edgeEffectiveness = Some 0.45
                  impulseFactor = Some 0.5
                  noSelfDamage = Some true
                  soundStart = Some "nukelaunch"
                  soundHit = Some "nukearm"
                  explosiongenerator = Some "custom:newnuke"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "collideenemy", "false"
                      "collidefeature", "false"
                      "collidefriendly", "false"
                      "craterareaofeffect", "1280.0"
                      "craterboost", "2.4"
                      "cratermult", "1.2"
                      "firestarter", "100.0"
                      "flighttime", "400.0"
                      "model", "crblmssl.s3o"
                      "mygravity", "0.4"
                      "smoketrail", "true"
                      "smokePeriod", "10.0"
                      "smoketime", "130.0"
                      "smokesize", "280.0"
                      "smokecolor", "0.85"
                      "smokeTrailCastShadow", "true"
                      "soundhitwet", "nukewater"
                      "soundhitwetvolume", "53.0"
                      "soundstartvolume", "20.0"
                      "texture1", "null"
                      "texture2", "railguntrail"
                      "texture3", "null"
                      "turnrate", "5500.0"
                      "weaponacceleration", "100.0"
                      "weapontimer", "5.0"
                  ] }
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
                ok = ["vtolarmv"]
                select = ["vtolarac"] }
          customParams = Map.ofList [
                "unitgroup", "weapon"
                "lumamult", "1.7"
                "model_author", "Flaka"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmAircraft/T2"
                "techlevel", "3.0"
                "attacksafetydistance", "20000.0"
            ]
          extras = Map.ofList [
                "acceleration", "0.15"
                "blocking", "false"
                "collide", "false"
                "firestate", "0.0"
                "maxaileron", "0.01325"
                "maxbank", "0.3"
                "maxelevator", "0.0095"
                "maxpitch", "0.3"
                "maxrudder", "0.005"
                "noautofire", "false"
                "nochasecategory", "VTOL"
                "speedtofront", "0.06767"
                "turnradius", "256.0"
                "usesmoothmesh", "true"
                "wingangle", "0.062"
                "wingdrag", "0.135"
            ] }

    let armlichet4Def : UnitDef =
        { name = "armlichet4"
          subfolder = "Scavengers/Air"
          printableName = Some "Epic Liche"
          metalCost = ValueOrExpr.Concrete 18000.0
          energyCost = ValueOrExpr.Concrete 240000.0
          buildTime = ValueOrExpr.Concrete 240000.0
          health = ValueOrExpr.Concrete 10000.0
          sightDistance = ValueOrExpr.Concrete 455.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/scavboss/ARMLICHET4.s3o"
          buildPic = Some "ARMLICHE.DDS"
          script = Some "Units/ARMLICHE.cob"
          corpse = None
          explodeAs = Some "hugeexplosiongeneric"
          selfDestructAs = Some "hugeExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = Some "T4AIR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 180.0
              maxAcc = 0.1075
              maxDec = 0.05
              turnRate = 256.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 150.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "nuclear_missile"
                displayName = "Intercontinental ballistic nuclear warhead"
                weaponType = Some "AircraftBomb"
                damage = Map.ofList [
                    "commanders", 2500.0
                    "default", 9500.0
                    "vtol", 2000.0
                ]
                range = Some (ValueOrExpr.Concrete 800.0)
                reloadTime = Some (ValueOrExpr.Concrete 120.0)
                weaponVelocity = Some 1600.0
                areaOfEffect = Some 1280.0
                accuracy = None
                turret = None
                tolerance = Some 4000.0
                edgeEffectiveness = Some 0.45
                impulseFactor = Some 0.5
                noSelfDamage = Some true
                soundStart = Some "nukelaunch"
                soundHit = Some "nukearm"
                explosiongenerator = Some "custom:newnuke"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "collideenemy", "false"
                    "collidefeature", "false"
                    "collidefriendly", "false"
                    "craterareaofeffect", "1280.0"
                    "craterboost", "2.4"
                    "cratermult", "1.2"
                    "firestarter", "100.0"
                    "flighttime", "400.0"
                    "model", "crblmssl.s3o"
                    "mygravity", "0.4"
                    "smoketrail", "true"
                    "smokePeriod", "10.0"
                    "smoketime", "130.0"
                    "smokesize", "280.0"
                    "smokecolor", "0.85"
                    "smokeTrailCastShadow", "true"
                    "soundhitwet", "nukewater"
                    "soundhitwetvolume", "53.0"
                    "soundstartvolume", "20.0"
                    "texture1", "null"
                    "texture2", "railguntrail"
                    "texture3", "null"
                    "turnrate", "5500.0"
                    "weaponacceleration", "100.0"
                    "weapontimer", "5.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = Some (
            { build = None
              repair = None
              working = None
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["vtolarmv"]
              select = ["vtolarac"] })
          customParams = Map.ofList [
              "unitgroup", "weapon"
              "lumamult", "1.7"
              "model_author", "Flaka"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmAircraft/T2"
              "techlevel", "3.0"
              "attacksafetydistance", "20000.0"
          ]
          extras = Map.ofList [
              "acceleration", "0.15"
              "blocking", "false"
              "collide", "false"
              "firestate", "0.0"
              "maxaileron", "0.01325"
              "maxbank", "0.3"
              "maxelevator", "0.0095"
              "maxpitch", "0.3"
              "maxrudder", "0.005"
              "noautofire", "false"
              "nochasecategory", "VTOL"
              "speedtofront", "0.06767"
              "turnradius", "256.0"
              "usesmoothmesh", "true"
              "wingangle", "0.062"
              "wingdrag", "0.135"
          ] }

    let armlichet4ToFlat (def: UnitDef) : Armlichet4 =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canFly = def.movement.Value.canFly
          canMove = def.movement.Value.canMove
          cruiseAltitude = def.movement.Value.cruiseAltitude.Value
          weapons = def.weapons.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armlichet4ToUnitDef (flat: Armlichet4) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = None
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = flat.canFly
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some flat.cruiseAltitude
              minWaterDepth = None
              waterline = None
            }
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = None
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armminebomber =
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
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          maxSlope: float
          maxWaterDepth: float
          canFly: bool
          canMove: bool
          cruiseAltitude: float
          weapons: WeaponDef list
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armminebomber : Armminebomber =
        { name = "armminebomber"
          subfolder = "Scavengers/Air"
          printableName = None
          metalCost = ValueOrExpr.Concrete 145.0
          energyCost = ValueOrExpr.Concrete 4200.0
          buildTime = ValueOrExpr.Concrete 4800.0
          health = ValueOrExpr.Concrete 670.0
          sightDistance = ValueOrExpr.Concrete 195.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/scavboss/ARMMINEBOMBER.s3o"
          buildPic = Some "ARMTHUND.DDS"
          script = Some "Units/scavboss/ARMMINEBOMBER.cob"
          corpse = None
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 255.0
          maxAcc = 0.0575
          maxDec = 0.05
          turnRate = 850.0
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canFly = true
          canMove = true
          cruiseAltitude = 165.0
          weapons = [
                { name = "armbomb"
                  displayName = "Light a2g impulse warheads"
                  weaponType = Some "AircraftBomb"
                  damage = Map.ofList [
                      "default", 105.0
                      "subs", 35.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1280.0)
                  reloadTime = Some (ValueOrExpr.Concrete 6.0)
                  weaponVelocity = None
                  areaOfEffect = Some 144.0
                  accuracy = Some 500.0
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.55
                  impulseFactor = Some 0.5
                  noSelfDamage = Some true
                  soundStart = Some "bombrel"
                  soundHit = Some "bombssml1"
                  explosiongenerator = Some "custom:genericshellexplosion-medium-bomb"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "MOBILE"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "burst", "5.0"
                      "burstrate", "0.3"
                      "collidefriendly", "false"
                      "commandfire", "false"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "craterareaofeffect", "144.0"
                      "gravityaffected", "true"
                      "model", "airbomb.s3o"
                      "soundhitwet", "splsmed"
                      "sprayangle", "300.0"
                  ] }
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
                ok = ["vtolarmv"]
                select = ["vtolarac"] }
          customParams = Map.ofList [
                "unitgroup", "weapon"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmAircraft"
            ]
          extras = Map.ofList [
                "acceleration", "0.05"
                "collide", "false"
                "maxaileron", "0.0144"
                "maxbank", "0.8"
                "maxelevator", "0.01065"
                "maxpitch", "0.625"
                "maxrudder", "0.00615"
                "noautofire", "true"
                "nochasecategory", "MOBILE"
                "speedtofront", "0.063"
                "turnradius", "64.0"
                "usesmoothmesh", "true"
                "wingangle", "0.06315"
                "wingdrag", "0.135"
            ] }

    let armminebomberDef : UnitDef =
        { name = "armminebomber"
          subfolder = "Scavengers/Air"
          printableName = None
          metalCost = ValueOrExpr.Concrete 145.0
          energyCost = ValueOrExpr.Concrete 4200.0
          buildTime = ValueOrExpr.Concrete 4800.0
          health = ValueOrExpr.Concrete 670.0
          sightDistance = ValueOrExpr.Concrete 195.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/scavboss/ARMMINEBOMBER.s3o"
          buildPic = Some "ARMTHUND.DDS"
          script = Some "Units/scavboss/ARMMINEBOMBER.cob"
          corpse = None
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 255.0
              maxAcc = 0.0575
              maxDec = 0.05
              turnRate = 850.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 165.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "armbomb"
                displayName = "Light a2g impulse warheads"
                weaponType = Some "AircraftBomb"
                damage = Map.ofList [
                    "default", 105.0
                    "subs", 35.0
                ]
                range = Some (ValueOrExpr.Concrete 1280.0)
                reloadTime = Some (ValueOrExpr.Concrete 6.0)
                weaponVelocity = None
                areaOfEffect = Some 144.0
                accuracy = Some 500.0
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.55
                impulseFactor = Some 0.5
                noSelfDamage = Some true
                soundStart = Some "bombrel"
                soundHit = Some "bombssml1"
                explosiongenerator = Some "custom:genericshellexplosion-medium-bomb"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "burst", "5.0"
                    "burstrate", "0.3"
                    "collidefriendly", "false"
                    "commandfire", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "craterareaofeffect", "144.0"
                    "gravityaffected", "true"
                    "model", "airbomb.s3o"
                    "soundhitwet", "splsmed"
                    "sprayangle", "300.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = Some (
            { build = None
              repair = None
              working = None
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["vtolarmv"]
              select = ["vtolarac"] })
          customParams = Map.ofList [
              "unitgroup", "weapon"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmAircraft"
          ]
          extras = Map.ofList [
              "acceleration", "0.05"
              "collide", "false"
              "maxaileron", "0.0144"
              "maxbank", "0.8"
              "maxelevator", "0.01065"
              "maxpitch", "0.625"
              "maxrudder", "0.00615"
              "noautofire", "true"
              "nochasecategory", "MOBILE"
              "speedtofront", "0.063"
              "turnradius", "64.0"
              "usesmoothmesh", "true"
              "wingangle", "0.06315"
              "wingdrag", "0.135"
          ] }

    let armminebomberToFlat (def: UnitDef) : Armminebomber =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canFly = def.movement.Value.canFly
          canMove = def.movement.Value.canMove
          cruiseAltitude = def.movement.Value.cruiseAltitude.Value
          weapons = def.weapons.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armminebomberToUnitDef (flat: Armminebomber) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = None
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = flat.canFly
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some flat.cruiseAltitude
              minWaterDepth = None
              waterline = None
            }
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = None
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armthundt4 =
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
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          maxSlope: float
          maxWaterDepth: float
          canFly: bool
          canMove: bool
          cruiseAltitude: float
          weapons: WeaponDef list
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armthundt4 : Armthundt4 =
        { name = "armthundt4"
          subfolder = "Scavengers/Air"
          printableName = Some "Epic Stormbringer"
          metalCost = ValueOrExpr.Concrete 15000.0
          energyCost = ValueOrExpr.Concrete 150000.0
          buildTime = ValueOrExpr.Concrete 150000.0
          health = ValueOrExpr.Concrete 16700.0
          sightDistance = ValueOrExpr.Concrete 2500.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/scavboss/ARMTHUNDT4.s3o"
          buildPic = Some "ARMTHUNDT4.DDS"
          script = Some "Units/scavboss/ARMTHUNDT4.cob"
          corpse = None
          explodeAs = Some "explosiont3xl"
          selfDestructAs = Some "explosiont3xxl"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = Some "T4AIR"
          speed = ValueOrExpr.Concrete 367.5
          maxAcc = 0.032
          maxDec = 0.01
          turnRate = 212.0
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canFly = true
          canMove = true
          cruiseAltitude = 190.0
          weapons = [
                { name = "armbomb"
                  displayName = "Ultra Heavy Bombs"
                  weaponType = Some "AircraftBomb"
                  damage = Map.ofList [
                      "commanders", 150.0
                      "default", 900.0
                      "subs", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 2480.0)
                  reloadTime = Some (ValueOrExpr.Concrete 4.0)
                  weaponVelocity = None
                  areaOfEffect = Some 280.0
                  accuracy = Some 10000.0
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.75
                  impulseFactor = Some 2.5
                  noSelfDamage = Some true
                  soundStart = Some "bombrelxl"
                  soundHit = Some "xplolrg4"
                  explosiongenerator = Some "custom:genericshellexplosion-huge-bomb"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "MOBILE"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "burst", "28.0"
                      "burstrate", "0.1"
                      "collidefriendly", "false"
                      "commandfire", "false"
                      "craterareaofeffect", "280.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "model", "units/armvader.s3o"
                      "soundhitwet", "splshbig"
                      "sprayangle", "8000.0"
                  ] }
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
                ok = ["vtolarmv"]
                select = ["vtolarac"] }
          customParams = Map.ofList [
                "unitgroup", "weapon"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmAircraft"
                "techlevel", "3.0"
            ]
          extras = Map.ofList [
                "acceleration", "0.02"
                "collide", "false"
                "maxaileron", "0.003"
                "maxbank", "0.33"
                "maxelevator", "0.0033"
                "maxpitch", "0.3"
                "maxrudder", "0.0052"
                "noautofire", "true"
                "nochasecategory", "MOBILE"
                "speedtofront", "0.041"
                "turnradius", "256.0"
                "usesmoothmesh", "true"
                "wingangle", "0.045"
                "wingdrag", "0.135"
            ] }

    let armthundt4Def : UnitDef =
        { name = "armthundt4"
          subfolder = "Scavengers/Air"
          printableName = Some "Epic Stormbringer"
          metalCost = ValueOrExpr.Concrete 15000.0
          energyCost = ValueOrExpr.Concrete 150000.0
          buildTime = ValueOrExpr.Concrete 150000.0
          health = ValueOrExpr.Concrete 16700.0
          sightDistance = ValueOrExpr.Concrete 2500.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/scavboss/ARMTHUNDT4.s3o"
          buildPic = Some "ARMTHUNDT4.DDS"
          script = Some "Units/scavboss/ARMTHUNDT4.cob"
          corpse = None
          explodeAs = Some "explosiont3xl"
          selfDestructAs = Some "explosiont3xxl"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = Some "T4AIR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 367.5
              maxAcc = 0.032
              maxDec = 0.01
              turnRate = 212.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 190.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "armbomb"
                displayName = "Ultra Heavy Bombs"
                weaponType = Some "AircraftBomb"
                damage = Map.ofList [
                    "commanders", 150.0
                    "default", 900.0
                    "subs", 100.0
                ]
                range = Some (ValueOrExpr.Concrete 2480.0)
                reloadTime = Some (ValueOrExpr.Concrete 4.0)
                weaponVelocity = None
                areaOfEffect = Some 280.0
                accuracy = Some 10000.0
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.75
                impulseFactor = Some 2.5
                noSelfDamage = Some true
                soundStart = Some "bombrelxl"
                soundHit = Some "xplolrg4"
                explosiongenerator = Some "custom:genericshellexplosion-huge-bomb"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "burst", "28.0"
                    "burstrate", "0.1"
                    "collidefriendly", "false"
                    "commandfire", "false"
                    "craterareaofeffect", "280.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "model", "units/armvader.s3o"
                    "soundhitwet", "splshbig"
                    "sprayangle", "8000.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = Some (
            { build = None
              repair = None
              working = None
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["vtolarmv"]
              select = ["vtolarac"] })
          customParams = Map.ofList [
              "unitgroup", "weapon"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmAircraft"
              "techlevel", "3.0"
          ]
          extras = Map.ofList [
              "acceleration", "0.02"
              "collide", "false"
              "maxaileron", "0.003"
              "maxbank", "0.33"
              "maxelevator", "0.0033"
              "maxpitch", "0.3"
              "maxrudder", "0.0052"
              "noautofire", "true"
              "nochasecategory", "MOBILE"
              "speedtofront", "0.041"
              "turnradius", "256.0"
              "usesmoothmesh", "true"
              "wingangle", "0.045"
              "wingdrag", "0.135"
          ] }

    let armthundt4ToFlat (def: UnitDef) : Armthundt4 =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canFly = def.movement.Value.canFly
          canMove = def.movement.Value.canMove
          cruiseAltitude = def.movement.Value.cruiseAltitude.Value
          weapons = def.weapons.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armthundt4ToUnitDef (flat: Armthundt4) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = None
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = flat.canFly
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some flat.cruiseAltitude
              minWaterDepth = None
              waterline = None
            }
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = None
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corcrw =
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
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          maxSlope: float
          maxWaterDepth: float
          canFly: bool
          canMove: bool
          turnInPlaceAngleLimit: float
          cruiseAltitude: float
          weapons: WeaponDef list
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corcrw : Corcrw =
        { name = "corcrw"
          subfolder = "Scavengers/Air"
          printableName = Some "Archaic Dragon"
          metalCost = ValueOrExpr.Concrete 5100.0
          energyCost = ValueOrExpr.Concrete 72000.0
          buildTime = ValueOrExpr.Concrete 84200.0
          health = ValueOrExpr.Concrete 16700.0
          sightDistance = ValueOrExpr.Concrete 494.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORCRW.s3o"
          buildPic = Some "CORCRW.DDS"
          script = Some "Units/CORCRW.cob"
          corpse = None
          explodeAs = Some "largeexplosiongeneric"
          selfDestructAs = Some "largeExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 1 0"
          collisionVolumeScales = Some "64 24 64"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 114.9
          maxAcc = 0.15
          maxDec = 0.15
          turnRate = 300.0
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canFly = true
          canMove = true
          turnInPlaceAngleLimit = 360.0
          cruiseAltitude = 75.0
          weapons = [
                { name = "krowlaser2"
                  displayName = "High energy a2g laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 250.0
                  ]
                  range = Some (ValueOrExpr.Concrete 525.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.3)
                  weaponVelocity = Some 800.0
                  areaOfEffect = Some 32.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrcrw2"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-large-green"
                  rgbColor = Some "0 1 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "beamtime", "0.25"
                      "beamttl", "1.0"
                      "corethickness", "0.2"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "energypershot", "100.0"
                      "firestarter", "90.0"
                      "laserflaresize", "7.7"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "2.7"
                  ] }
                { name = "krowlaser"
                  displayName = "HighEnergyLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 90.0
                  ]
                  range = Some (ValueOrExpr.Concrete 575.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.63333)
                  weaponVelocity = Some 800.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrcrw1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small-green"
                  rgbColor = Some "0 1 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "beamtime", "0.1"
                      "beamttl", "1.0"
                      "corethickness", "0.13"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "energypershot", "50.0"
                      "firestarter", "90.0"
                      "laserflaresize", "6.05"
                      "proximitypriority", "1.0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "2.0"
                  ] }
                { name = "krowlaser"
                  displayName = "HighEnergyLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 90.0
                  ]
                  range = Some (ValueOrExpr.Concrete 575.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.63333)
                  weaponVelocity = Some 800.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrcrw1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small-green"
                  rgbColor = Some "0 1 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "beamtime", "0.1"
                      "beamttl", "1.0"
                      "corethickness", "0.13"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "energypershot", "50.0"
                      "firestarter", "90.0"
                      "laserflaresize", "6.05"
                      "proximitypriority", "1.0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "2.0"
                  ] }
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
                ok = ["vtolcrmv"]
                select = ["vtolcrac"] }
          customParams = Map.ofList [
                "unitgroup", "weapon"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorAircraft/T2"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "bankingallowed", "false"
                "collide", "true"
                "hoverattack", "true"
                "nochasecategory", "VTOL"
                "upright", "true"
            ] }

    let corcrwDef : UnitDef =
        { name = "corcrw"
          subfolder = "Scavengers/Air"
          printableName = Some "Archaic Dragon"
          metalCost = ValueOrExpr.Concrete 5100.0
          energyCost = ValueOrExpr.Concrete 72000.0
          buildTime = ValueOrExpr.Concrete 84200.0
          health = ValueOrExpr.Concrete 16700.0
          sightDistance = ValueOrExpr.Concrete 494.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORCRW.s3o"
          buildPic = Some "CORCRW.DDS"
          script = Some "Units/CORCRW.cob"
          corpse = None
          explodeAs = Some "largeexplosiongeneric"
          selfDestructAs = Some "largeExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 1 0"
          collisionVolumeScales = Some "64 24 64"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 114.9
              maxAcc = 0.15
              maxDec = 0.15
              turnRate = 300.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 360.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 75.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "krowlaser2"
                displayName = "High energy a2g laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 250.0
                ]
                range = Some (ValueOrExpr.Concrete 525.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.3)
                weaponVelocity = Some 800.0
                areaOfEffect = Some 32.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrcrw2"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-large-green"
                rgbColor = Some "0 1 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "beamtime", "0.25"
                    "beamttl", "1.0"
                    "corethickness", "0.2"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "energypershot", "100.0"
                    "firestarter", "90.0"
                    "laserflaresize", "7.7"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.7"
                ] }
              { name = "krowlaser"
                displayName = "HighEnergyLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 90.0
                ]
                range = Some (ValueOrExpr.Concrete 575.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.63333)
                weaponVelocity = Some 800.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrcrw1"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-small-green"
                rgbColor = Some "0 1 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "beamtime", "0.1"
                    "beamttl", "1.0"
                    "corethickness", "0.13"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "energypershot", "50.0"
                    "firestarter", "90.0"
                    "laserflaresize", "6.05"
                    "proximitypriority", "1.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.0"
                ] }
              { name = "krowlaser"
                displayName = "HighEnergyLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 90.0
                ]
                range = Some (ValueOrExpr.Concrete 575.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.63333)
                weaponVelocity = Some 800.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrcrw1"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-small-green"
                rgbColor = Some "0 1 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "beamtime", "0.1"
                    "beamttl", "1.0"
                    "corethickness", "0.13"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "energypershot", "50.0"
                    "firestarter", "90.0"
                    "laserflaresize", "6.05"
                    "proximitypriority", "1.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = Some (
            { build = None
              repair = None
              working = None
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["vtolcrmv"]
              select = ["vtolcrac"] })
          customParams = Map.ofList [
              "unitgroup", "weapon"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorAircraft/T2"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "blocking", "true"
              "bankingallowed", "false"
              "collide", "true"
              "hoverattack", "true"
              "nochasecategory", "VTOL"
              "upright", "true"
          ] }

    let corcrwToFlat (def: UnitDef) : Corcrw =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canFly = def.movement.Value.canFly
          canMove = def.movement.Value.canMove
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          cruiseAltitude = def.movement.Value.cruiseAltitude.Value
          weapons = def.weapons.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corcrwToUnitDef (flat: Corcrw) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = None
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = flat.canFly
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some flat.cruiseAltitude
              minWaterDepth = None
              waterline = None
            }
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = None
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corcrwt4 =
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
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          maxSlope: float
          maxWaterDepth: float
          canFly: bool
          canMove: bool
          turnInPlaceAngleLimit: float
          cruiseAltitude: float
          weapons: WeaponDef list
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corcrwt4 : Corcrwt4 =
        { name = "corcrwt4"
          subfolder = "Scavengers/Air"
          printableName = Some "Epic Dragon"
          metalCost = ValueOrExpr.Concrete 15000.0
          energyCost = ValueOrExpr.Concrete 150000.0
          buildTime = ValueOrExpr.Concrete 150000.0
          health = ValueOrExpr.Concrete 22000.0
          sightDistance = ValueOrExpr.Concrete 675.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/scavboss/corcrwt4.s3o"
          buildPic = Some "scavengers/corcrwt4.DDS"
          script = Some "Units/scavboss/corcrwt4.cob"
          corpse = None
          explodeAs = Some "bantha"
          selfDestructAs = Some "bantha"
          collisionVolumeOffsets = Some "0 10 0"
          collisionVolumeScales = Some "80 51 120"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = Some "T4AIR"
          speed = ValueOrExpr.Concrete 114.9
          maxAcc = 0.08
          maxDec = 0.275
          turnRate = 200.0
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canFly = true
          canMove = true
          turnInPlaceAngleLimit = 360.0
          cruiseAltitude = 110.0
          weapons = [
                { name = "kmaw"
                  displayName = "Demon's Maw; Heavy long range AoE flamethrower"
                  weaponType = Some "Flame"
                  damage = Map.ofList [
                      "default", 40.0
                      "subs", 10.0
                  ]
                  range = Some (ValueOrExpr.Concrete 500.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.39996)
                  weaponVelocity = Some 500.0
                  areaOfEffect = Some 128.0
                  accuracy = Some 0.0
                  turret = Some true
                  tolerance = Some 20000.0
                  edgeEffectiveness = Some 0.01
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "Flamhvy1"
                  soundHit = None
                  explosiongenerator = Some "custom:burnthermite"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_maindir", "0 -1 1"
                      "mount_maxangledif", "180.0"
                      "avoidfeature", "false"
                      "avoidfriendly", "true"
                      "avoidground", "false"
                      "burst", "12.0"
                      "burstrate", "0.03333"
                      "burnblow", "true"
                      "bouncerebound", "1.0"
                      "cegtag", "burnflamethermite"
                      "colormap", "1 0.95 0.9 0.032   0.55 0.55 0.40 0.028   0.40 0.28 0.19 0.024   0.033 0.018 0.011 0.04   0.0 0.0 0.0 0.01"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "bounceSlip", "1.0"
                      "firestarter", "100.0"
                      "firesubmersed", "false"
                      "flameGFXTime", "1.0"
                      "intensity", "0.85"
                      "noexplode", "false"
                      "predictboost", "1.0"
                      "sizegrowth", "2.25"
                      "soundhitwet", "sizzle"
                      "soundtrigger", "true"
                      "soundstartvolume", "25.0"
                      "soundhitvolume", "25.0"
                      "soundhitwetvolume", "34.0"
                      "waterweapon", "false"
                  ] }
                { name = "edragon_missile"
                  displayName = "Advanced antiair rapid missile launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "bombers", 400.0
                      "fighters", 400.0
                      "vtol", 400.0
                  ]
                  range = Some (ValueOrExpr.Concrete 840.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.4)
                  weaponVelocity = Some 1250.0
                  areaOfEffect = Some 16.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 9950.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "packolau"
                  soundHit = Some "packohit"
                  explosiongenerator = Some "custom:genericshellexplosion-medium-aa"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "NOTAIR"
                      "mount_onlytargetcategory", "VTOL"
                      "mount_fastautoretargeting", "true"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "canattackground", "false"
                      "cegtag", "missiletrailaa-medium"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "72.0"
                      "flighttime", "2.5"
                      "model", "cormissile.s3o"
                      "smoketrail", "true"
                      "smokePeriod", "7.0"
                      "smoketime", "10.0"
                      "smokesize", "4.2"
                      "smokecolor", "1.0"
                      "smokeTrailCastShadow", "false"
                      "castshadow", "false"
                      "soundhitwet", "splshbig"
                      "soundtrigger", "true"
                      "startvelocity", "800.0"
                      "texture1", "null"
                      "texture2", "smoketrailaa"
                      "tracks", "true"
                      "turnrate", "68000.0"
                      "weaponacceleration", "160.0"
                      "weapontimer", "2.0"
                  ] }
                { name = "krowbosslaser"
                  displayName = "Ultra HighEnergyLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "commanders", 200.0
                      "default", 2000.0
                      "vtol", 200.0
                      "subs", 200.0
                  ]
                  range = Some (ValueOrExpr.Concrete 625.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.5)
                  weaponVelocity = Some 800.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrhvy3"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-large-green"
                  rgbColor = Some "0 1 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_maindir", "1 -1 0"
                      "mount_maxangledif", "180.0"
                      "avoidfeature", "false"
                      "beamtime", "0.25"
                      "beamttl", "1.75"
                      "corethickness", "0.13"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "energypershot", "50.0"
                      "firestarter", "90.0"
                      "laserflaresize", "6.05"
                      "proximitypriority", "1.0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "targetmoveerror", "0.3"
                      "thickness", "4.0"
                  ] }
                { name = "krowbosslaser"
                  displayName = "Ultra HighEnergyLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "commanders", 200.0
                      "default", 2000.0
                      "vtol", 200.0
                      "subs", 200.0
                  ]
                  range = Some (ValueOrExpr.Concrete 625.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.5)
                  weaponVelocity = Some 800.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrhvy3"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-large-green"
                  rgbColor = Some "0 1 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_maindir", "1 -1 0"
                      "mount_maxangledif", "180.0"
                      "avoidfeature", "false"
                      "beamtime", "0.25"
                      "beamttl", "1.75"
                      "corethickness", "0.13"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "energypershot", "50.0"
                      "firestarter", "90.0"
                      "laserflaresize", "6.05"
                      "proximitypriority", "1.0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "targetmoveerror", "0.3"
                      "thickness", "4.0"
                  ] }
                { name = "krowbosslaser"
                  displayName = "Ultra HighEnergyLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "commanders", 200.0
                      "default", 2000.0
                      "vtol", 200.0
                      "subs", 200.0
                  ]
                  range = Some (ValueOrExpr.Concrete 625.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.5)
                  weaponVelocity = Some 800.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrhvy3"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-large-green"
                  rgbColor = Some "0 1 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_maindir", "-1 -1 0"
                      "mount_maxangledif", "180.0"
                      "avoidfeature", "false"
                      "beamtime", "0.25"
                      "beamttl", "1.75"
                      "corethickness", "0.13"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "energypershot", "50.0"
                      "firestarter", "90.0"
                      "laserflaresize", "6.05"
                      "proximitypriority", "1.0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "targetmoveerror", "0.3"
                      "thickness", "4.0"
                  ] }
                { name = "krowbosslaser"
                  displayName = "Ultra HighEnergyLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "commanders", 200.0
                      "default", 2000.0
                      "vtol", 200.0
                      "subs", 200.0
                  ]
                  range = Some (ValueOrExpr.Concrete 625.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.5)
                  weaponVelocity = Some 800.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrhvy3"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-large-green"
                  rgbColor = Some "0 1 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_maindir", "-1 -1 0"
                      "mount_maxangledif", "180.0"
                      "avoidfeature", "false"
                      "beamtime", "0.25"
                      "beamttl", "1.75"
                      "corethickness", "0.13"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "energypershot", "50.0"
                      "firestarter", "90.0"
                      "laserflaresize", "6.05"
                      "proximitypriority", "1.0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "targetmoveerror", "0.3"
                      "thickness", "4.0"
                  ] }
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
                ok = ["vtolcrmv"]
                select = ["vtolcrac"] }
          customParams = Map.ofList [
                "maxrange", "450"
                "unitgroup", "aa"
                "model_author", "Mr Bob, Hornet"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "other/scavengers"
                "techlevel", "3.0"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "bankingallowed", "false"
                "collide", "true"
                "hoverattack", "true"
                "nochasecategory", "VTOL"
                "upright", "true"
            ] }

    let corcrwt4Def : UnitDef =
        { name = "corcrwt4"
          subfolder = "Scavengers/Air"
          printableName = Some "Epic Dragon"
          metalCost = ValueOrExpr.Concrete 15000.0
          energyCost = ValueOrExpr.Concrete 150000.0
          buildTime = ValueOrExpr.Concrete 150000.0
          health = ValueOrExpr.Concrete 22000.0
          sightDistance = ValueOrExpr.Concrete 675.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/scavboss/corcrwt4.s3o"
          buildPic = Some "scavengers/corcrwt4.DDS"
          script = Some "Units/scavboss/corcrwt4.cob"
          corpse = None
          explodeAs = Some "bantha"
          selfDestructAs = Some "bantha"
          collisionVolumeOffsets = Some "0 10 0"
          collisionVolumeScales = Some "80 51 120"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = Some "T4AIR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 114.9
              maxAcc = 0.08
              maxDec = 0.275
              turnRate = 200.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 360.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 110.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "kmaw"
                displayName = "Demon's Maw; Heavy long range AoE flamethrower"
                weaponType = Some "Flame"
                damage = Map.ofList [
                    "default", 40.0
                    "subs", 10.0
                ]
                range = Some (ValueOrExpr.Concrete 500.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.39996)
                weaponVelocity = Some 500.0
                areaOfEffect = Some 128.0
                accuracy = Some 0.0
                turret = Some true
                tolerance = Some 20000.0
                edgeEffectiveness = Some 0.01
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "Flamhvy1"
                soundHit = None
                explosiongenerator = Some "custom:burnthermite"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_maindir", "0 -1 1"
                    "mount_maxangledif", "180.0"
                    "avoidfeature", "false"
                    "avoidfriendly", "true"
                    "avoidground", "false"
                    "burst", "12.0"
                    "burstrate", "0.03333"
                    "burnblow", "true"
                    "bouncerebound", "1.0"
                    "cegtag", "burnflamethermite"
                    "colormap", "1 0.95 0.9 0.032   0.55 0.55 0.40 0.028   0.40 0.28 0.19 0.024   0.033 0.018 0.011 0.04   0.0 0.0 0.0 0.01"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "bounceSlip", "1.0"
                    "firestarter", "100.0"
                    "firesubmersed", "false"
                    "flameGFXTime", "1.0"
                    "intensity", "0.85"
                    "noexplode", "false"
                    "predictboost", "1.0"
                    "sizegrowth", "2.25"
                    "soundhitwet", "sizzle"
                    "soundtrigger", "true"
                    "soundstartvolume", "25.0"
                    "soundhitvolume", "25.0"
                    "soundhitwetvolume", "34.0"
                    "waterweapon", "false"
                ] }
              { name = "edragon_missile"
                displayName = "Advanced antiair rapid missile launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "bombers", 400.0
                    "fighters", 400.0
                    "vtol", 400.0
                ]
                range = Some (ValueOrExpr.Concrete 840.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.4)
                weaponVelocity = Some 1250.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = Some 9950.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "packolau"
                soundHit = Some "packohit"
                explosiongenerator = Some "custom:genericshellexplosion-medium-aa"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR"
                    "mount_onlytargetcategory", "VTOL"
                    "mount_fastautoretargeting", "true"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "cegtag", "missiletrailaa-medium"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "72.0"
                    "flighttime", "2.5"
                    "model", "cormissile.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "7.0"
                    "smoketime", "10.0"
                    "smokesize", "4.2"
                    "smokecolor", "1.0"
                    "smokeTrailCastShadow", "false"
                    "castshadow", "false"
                    "soundhitwet", "splshbig"
                    "soundtrigger", "true"
                    "startvelocity", "800.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa"
                    "tracks", "true"
                    "turnrate", "68000.0"
                    "weaponacceleration", "160.0"
                    "weapontimer", "2.0"
                ] }
              { name = "krowbosslaser"
                displayName = "Ultra HighEnergyLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 200.0
                    "default", 2000.0
                    "vtol", 200.0
                    "subs", 200.0
                ]
                range = Some (ValueOrExpr.Concrete 625.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.5)
                weaponVelocity = Some 800.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrhvy3"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-large-green"
                rgbColor = Some "0 1 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_maindir", "1 -1 0"
                    "mount_maxangledif", "180.0"
                    "avoidfeature", "false"
                    "beamtime", "0.25"
                    "beamttl", "1.75"
                    "corethickness", "0.13"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "energypershot", "50.0"
                    "firestarter", "90.0"
                    "laserflaresize", "6.05"
                    "proximitypriority", "1.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "targetmoveerror", "0.3"
                    "thickness", "4.0"
                ] }
              { name = "krowbosslaser"
                displayName = "Ultra HighEnergyLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 200.0
                    "default", 2000.0
                    "vtol", 200.0
                    "subs", 200.0
                ]
                range = Some (ValueOrExpr.Concrete 625.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.5)
                weaponVelocity = Some 800.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrhvy3"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-large-green"
                rgbColor = Some "0 1 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_maindir", "1 -1 0"
                    "mount_maxangledif", "180.0"
                    "avoidfeature", "false"
                    "beamtime", "0.25"
                    "beamttl", "1.75"
                    "corethickness", "0.13"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "energypershot", "50.0"
                    "firestarter", "90.0"
                    "laserflaresize", "6.05"
                    "proximitypriority", "1.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "targetmoveerror", "0.3"
                    "thickness", "4.0"
                ] }
              { name = "krowbosslaser"
                displayName = "Ultra HighEnergyLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 200.0
                    "default", 2000.0
                    "vtol", 200.0
                    "subs", 200.0
                ]
                range = Some (ValueOrExpr.Concrete 625.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.5)
                weaponVelocity = Some 800.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrhvy3"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-large-green"
                rgbColor = Some "0 1 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_maindir", "-1 -1 0"
                    "mount_maxangledif", "180.0"
                    "avoidfeature", "false"
                    "beamtime", "0.25"
                    "beamttl", "1.75"
                    "corethickness", "0.13"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "energypershot", "50.0"
                    "firestarter", "90.0"
                    "laserflaresize", "6.05"
                    "proximitypriority", "1.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "targetmoveerror", "0.3"
                    "thickness", "4.0"
                ] }
              { name = "krowbosslaser"
                displayName = "Ultra HighEnergyLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 200.0
                    "default", 2000.0
                    "vtol", 200.0
                    "subs", 200.0
                ]
                range = Some (ValueOrExpr.Concrete 625.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.5)
                weaponVelocity = Some 800.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrhvy3"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-large-green"
                rgbColor = Some "0 1 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_maindir", "-1 -1 0"
                    "mount_maxangledif", "180.0"
                    "avoidfeature", "false"
                    "beamtime", "0.25"
                    "beamttl", "1.75"
                    "corethickness", "0.13"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "energypershot", "50.0"
                    "firestarter", "90.0"
                    "laserflaresize", "6.05"
                    "proximitypriority", "1.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "targetmoveerror", "0.3"
                    "thickness", "4.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = Some (
            { build = None
              repair = None
              working = None
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["vtolcrmv"]
              select = ["vtolcrac"] })
          customParams = Map.ofList [
              "maxrange", "450"
              "unitgroup", "aa"
              "model_author", "Mr Bob, Hornet"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "other/scavengers"
              "techlevel", "3.0"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "bankingallowed", "false"
              "collide", "true"
              "hoverattack", "true"
              "nochasecategory", "VTOL"
              "upright", "true"
          ] }

    let corcrwt4ToFlat (def: UnitDef) : Corcrwt4 =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canFly = def.movement.Value.canFly
          canMove = def.movement.Value.canMove
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          cruiseAltitude = def.movement.Value.cruiseAltitude.Value
          weapons = def.weapons.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corcrwt4ToUnitDef (flat: Corcrwt4) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = None
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = flat.canFly
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some flat.cruiseAltitude
              minWaterDepth = None
              waterline = None
            }
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = None
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Cordronecarryair =
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
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          maxWaterDepth: float
          canFly: bool
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          cruiseAltitude: float
          energyMake: ValueOrExpr<float>
          energyStorage: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let cordronecarryair : Cordronecarryair =
        { name = "cordronecarryair"
          subfolder = "Scavengers/Air"
          printableName = Some "Disperser Omni"
          metalCost = ValueOrExpr.Concrete 1700.0
          energyCost = ValueOrExpr.Concrete 17000.0
          buildTime = ValueOrExpr.Concrete 24000.0
          health = ValueOrExpr.Concrete 3500.0
          sightDistance = ValueOrExpr.Concrete 700.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/CORDRONECARRYAIR.s3o"
          buildPic = Some "CORDRONECARRY.DDS"
          script = Some "Units/CORDRONECARRYAIR.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeexplosiongeneric"
          selfDestructAs = Some "hugeexplosiongenericSelfD"
          collisionVolumeOffsets = Some "-1 5 2"
          collisionVolumeScales = Some "48 48 136"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 34.5
          maxAcc = 0.018
          maxDec = 0.01722
          turnRate = 135.0
          maxWaterDepth = 15.0
          canFly = true
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          cruiseAltitude = 100.0
          energyMake = ValueOrExpr.Concrete 25.0
          energyStorage = 1500.0
          weapons = [
                { name = "plasma"
                  displayName = "HeavyCannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 0.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1200.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.5)
                  weaponVelocity = Some 800.0
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
                  customParams = Map.ofList [
                      "carried_unit", "cordrone"
                      "carrierdeaththroe", "release"
                      "dockingpieces", "9 10 11 12 13 14 15 16 17 18 19"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "hightrajectory", "1.0"
                      "metalpershot", "40.0"
                      "energypershot", "1000.0"
                      "size", "0.0"
                      "soundhitwet", ""
                      "stockpile", "true"
                      "stockpiletime", "6.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-0.0550308227539 1.52587890767e-06 4.55026245117"
                  collisionVolumeScales = Some "61.8225860596 60.9250030518 154.450805664"
                  collisionVolumeType = Some "Box"
                  damage = Some 9168.0
                  featureDead = Some "HEAP"
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 4.0
                  metal = Some 700.0
                  object_ = Some "Units/cordronecarry_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 4032.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 350.0
                  object_ = Some "Units/arm6X6C.s3o"
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
                ok = ["sharmmov"]
                select = ["sharmsel"] }
          customParams = Map.ofList [
                "model_author", "Odin"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "Scavengers/air"
                "techlevel", "3.0"
                "inheritxpratemultiplier", "1.0"
                "childreninheritxp", "DRONE"
                "parentsinheritxp", "DRONE"
            ]
          extras = Map.ofList [
                "buildangle", "16384.0"
                "canreclaim", "false"
                "canrepair", "false"
                "canrestore", "false"
                "collide", "true"
                "energyupkeep", "25.0"
                "hoverattack", "true"
                "sightemitheight", "56.0"
                "mass", "10000.0"
                "nochasecategory", "VTOL"
                "radardistance", "1500.0"
                "radaremitheight", "56.0"
                "upright", "true"
            ] }

    let cordronecarryairDef : UnitDef =
        { name = "cordronecarryair"
          subfolder = "Scavengers/Air"
          printableName = Some "Disperser Omni"
          metalCost = ValueOrExpr.Concrete 1700.0
          energyCost = ValueOrExpr.Concrete 17000.0
          buildTime = ValueOrExpr.Concrete 24000.0
          health = ValueOrExpr.Concrete 3500.0
          sightDistance = ValueOrExpr.Concrete 700.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/CORDRONECARRYAIR.s3o"
          buildPic = Some "CORDRONECARRY.DDS"
          script = Some "Units/CORDRONECARRYAIR.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeexplosiongeneric"
          selfDestructAs = Some "hugeexplosiongenericSelfD"
          collisionVolumeOffsets = Some "-1 5 2"
          collisionVolumeScales = Some "48 48 136"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 34.5
              maxAcc = 0.018
              maxDec = 0.01722
              turnRate = 135.0
              movementClass = None
              maxSlope = None
              maxWaterDepth = Some 15.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 100.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "plasma"
                displayName = "HeavyCannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = Some (ValueOrExpr.Concrete 1200.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.5)
                weaponVelocity = Some 800.0
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
                customParams = Map.ofList [
                    "carried_unit", "cordrone"
                    "carrierdeaththroe", "release"
                    "dockingpieces", "9 10 11 12 13 14 15 16 17 18 19"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "hightrajectory", "1.0"
                    "metalpershot", "40.0"
                    "energypershot", "1000.0"
                    "size", "0.0"
                    "soundhitwet", ""
                    "stockpile", "true"
                    "stockpiletime", "6.0"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 25.0)
              metalMake = None
              energyStorage = Some 1500.0
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "-0.0550308227539 1.52587890767e-06 4.55026245117"
                collisionVolumeScales = Some "61.8225860596 60.9250030518 154.450805664"
                collisionVolumeType = Some "Box"
                damage = Some 9168.0
                featureDead = Some "HEAP"
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 4.0
                metal = Some 700.0
                object_ = Some "Units/cordronecarry_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 4032.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 350.0
                object_ = Some "Units/arm6X6C.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = None
              repair = None
              working = None
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["sharmmov"]
              select = ["sharmsel"] })
          customParams = Map.ofList [
              "model_author", "Odin"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "Scavengers/air"
              "techlevel", "3.0"
              "inheritxpratemultiplier", "1.0"
              "childreninheritxp", "DRONE"
              "parentsinheritxp", "DRONE"
          ]
          extras = Map.ofList [
              "buildangle", "16384.0"
              "canreclaim", "false"
              "canrepair", "false"
              "canrestore", "false"
              "collide", "true"
              "energyupkeep", "25.0"
              "hoverattack", "true"
              "sightemitheight", "56.0"
              "mass", "10000.0"
              "nochasecategory", "VTOL"
              "radardistance", "1500.0"
              "radaremitheight", "56.0"
              "upright", "true"
          ] }

    let cordronecarryairToFlat (def: UnitDef) : Cordronecarryair =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canFly = def.movement.Value.canFly
          canMove = def.movement.Value.canMove
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          cruiseAltitude = def.movement.Value.cruiseAltitude.Value
          energyMake = def.economy.Value.energyMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let cordronecarryairToUnitDef (flat: Cordronecarryair) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = None
              maxSlope = None
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = flat.canFly
              canMove = flat.canMove
              floater = false
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some flat.cruiseAltitude
              minWaterDepth = None
              waterline = None
            }
          builder = None
          weapons = Some flat.weapons
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = None
              energyStorage = Some flat.energyStorage
              metalStorage = None
              extractsMetal = None
            }
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Cords =
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
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          maxSlope: float
          maxWaterDepth: float
          canFly: bool
          canMove: bool
          cruiseAltitude: float
          weapons: WeaponDef list
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let cords : Cords =
        { name = "cords"
          subfolder = "Scavengers/Air"
          printableName = Some "Disgruntler"
          metalCost = ValueOrExpr.Concrete 1000.0
          energyCost = ValueOrExpr.Concrete 14600.0
          buildTime = ValueOrExpr.Concrete 5000.0
          health = ValueOrExpr.Concrete 680.0
          sightDistance = ValueOrExpr.Concrete 169.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "scavs/CORDS.s3o"
          buildPic = Some "CORSHAD.DDS"
          script = Some "scavs/CORDS.cob"
          corpse = None
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 234.0
          maxAcc = 0.0575
          maxDec = 0.055
          turnRate = 500.0
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canFly = true
          canMove = true
          cruiseAltitude = 165.0
          weapons = [
                { name = "corbomb"
                  displayName = "AK Bomb"
                  weaponType = Some "AircraftBomb"
                  damage = Map.ofList [
                      "default", 100.0
                      "subs", 30.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1280.0)
                  reloadTime = Some (ValueOrExpr.Concrete 10.0)
                  weaponVelocity = None
                  areaOfEffect = Some 100.0
                  accuracy = Some 500.0
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.4
                  impulseFactor = Some 0.3
                  noSelfDamage = Some true
                  soundStart = Some "bombrel"
                  soundHit = Some "bombssml1"
                  explosiongenerator = Some "custom:genericshellexplosion-medium-bomb"
                  rgbColor = None
                  customParams = Map.ofList [
                      "spawns_name", "corak"
                      "spawns_surface", "LAND"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "MOBILE"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "burst", "6.0"
                      "burstrate", "0.26667"
                      "collidefriendly", "false"
                      "commandfire", "false"
                      "craterareaofeffect", "100.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "model", "akbomb.s3o"
                      "soundhitwet", "splslrg"
                      "sprayangle", "300.0"
                  ] }
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
                ok = ["vtolcrmv"]
                select = ["vtolcrac"] }
          customParams = Map.ofList [
                "unitgroup", "weapon"
                "model_author", "FireStorm"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "Scavengers"
            ]
          extras = Map.ofList [
                "acceleration", "0.05"
                "blocking", "false"
                "collide", "true"
                "maxaileron", "0.01421"
                "maxbank", "0.66"
                "maxelevator", "0.01046"
                "maxpitch", "0.625"
                "maxrudder", "0.00596"
                "noautofire", "true"
                "nochasecategory", "VTOL"
                "speedtofront", "0.06183"
                "turnradius", "256.0"
                "usesmoothmesh", "true"
                "wingangle", "0.16296"
                "wingdrag", "0.145"
            ] }

    let cordsDef : UnitDef =
        { name = "cords"
          subfolder = "Scavengers/Air"
          printableName = Some "Disgruntler"
          metalCost = ValueOrExpr.Concrete 1000.0
          energyCost = ValueOrExpr.Concrete 14600.0
          buildTime = ValueOrExpr.Concrete 5000.0
          health = ValueOrExpr.Concrete 680.0
          sightDistance = ValueOrExpr.Concrete 169.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "scavs/CORDS.s3o"
          buildPic = Some "CORSHAD.DDS"
          script = Some "scavs/CORDS.cob"
          corpse = None
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 234.0
              maxAcc = 0.0575
              maxDec = 0.055
              turnRate = 500.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 165.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "corbomb"
                displayName = "AK Bomb"
                weaponType = Some "AircraftBomb"
                damage = Map.ofList [
                    "default", 100.0
                    "subs", 30.0
                ]
                range = Some (ValueOrExpr.Concrete 1280.0)
                reloadTime = Some (ValueOrExpr.Concrete 10.0)
                weaponVelocity = None
                areaOfEffect = Some 100.0
                accuracy = Some 500.0
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.4
                impulseFactor = Some 0.3
                noSelfDamage = Some true
                soundStart = Some "bombrel"
                soundHit = Some "bombssml1"
                explosiongenerator = Some "custom:genericshellexplosion-medium-bomb"
                rgbColor = None
                customParams = Map.ofList [
                    "spawns_name", "corak"
                    "spawns_surface", "LAND"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "burst", "6.0"
                    "burstrate", "0.26667"
                    "collidefriendly", "false"
                    "commandfire", "false"
                    "craterareaofeffect", "100.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "model", "akbomb.s3o"
                    "soundhitwet", "splslrg"
                    "sprayangle", "300.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = Some (
            { build = None
              repair = None
              working = None
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["vtolcrmv"]
              select = ["vtolcrac"] })
          customParams = Map.ofList [
              "unitgroup", "weapon"
              "model_author", "FireStorm"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "Scavengers"
          ]
          extras = Map.ofList [
              "acceleration", "0.05"
              "blocking", "false"
              "collide", "true"
              "maxaileron", "0.01421"
              "maxbank", "0.66"
              "maxelevator", "0.01046"
              "maxpitch", "0.625"
              "maxrudder", "0.00596"
              "noautofire", "true"
              "nochasecategory", "VTOL"
              "speedtofront", "0.06183"
              "turnradius", "256.0"
              "usesmoothmesh", "true"
              "wingangle", "0.16296"
              "wingdrag", "0.145"
          ] }

    let cordsToFlat (def: UnitDef) : Cords =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canFly = def.movement.Value.canFly
          canMove = def.movement.Value.canMove
          cruiseAltitude = def.movement.Value.cruiseAltitude.Value
          weapons = def.weapons.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let cordsToUnitDef (flat: Cords) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = None
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = flat.canFly
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some flat.cruiseAltitude
              minWaterDepth = None
              waterline = None
            }
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = None
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corfblackhyt4 =
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
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          maxWaterDepth: float
          canFly: bool
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          cruiseAltitude: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corfblackhyt4 : Corfblackhyt4 =
        { name = "corfblackhyt4"
          subfolder = "Scavengers/Air"
          printableName = Some "Flying Black Hydra"
          metalCost = ValueOrExpr.Concrete 25000.0
          energyCost = ValueOrExpr.Concrete 250000.0
          buildTime = ValueOrExpr.Concrete 250000.0
          health = ValueOrExpr.Concrete 67000.0
          sightDistance = ValueOrExpr.Concrete 650.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/scavboss/corfblackhyt4.s3o"
          buildPic = Some "corfblackhyt4.DDS"
          script = Some "Units/scavboss/corfblackhyt4.cob"
          corpse = Some "DEAD"
          explodeAs = Some "FlagshipExplosion"
          selfDestructAs = Some "FlagshipExplosionSelfd"
          collisionVolumeOffsets = Some "0 -14 10"
          collisionVolumeScales = Some "70 70 170"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = Some "T4AIR"
          speed = ValueOrExpr.Concrete 36.0
          maxAcc = 0.015
          maxDec = 0.05
          turnRate = 129.0
          maxWaterDepth = 15.0
          canFly = true
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          cruiseAltitude = 100.0
          weapons = [
                { name = "heavyplasma"
                  displayName = "BattleshipCannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 465.0
                      "subs", 100.0
                      "vtol", 130.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1500.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.0)
                  weaponVelocity = Some 600.0
                  areaOfEffect = Some 128.0
                  accuracy = Some 1200.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "cannhvy1"
                  soundHit = Some "xplomed2"
                  explosiongenerator = Some "custom:genericshellexplosion-large"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE T4AIR"
                      "avoidfeature", "false"
                      "cegtag", "arty-heavy"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "intensity", "1.1"
                      "soundhitwet", "splsmed"
                  ] }
                { name = "heavylaser"
                  displayName = "HighEnergyLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 270.0
                      "vtol", 65.0
                  ]
                  range = Some (ValueOrExpr.Concrete 830.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.0)
                  weaponVelocity = Some 700.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "Lasrmas2"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-medium-green"
                  rgbColor = Some "0 1 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "300.0"
                      "mount_onlytargetcategory", "SURFACE T4AIR"
                      "avoidfeature", "false"
                      "beamtime", "0.2"
                      "corethickness", "0.2"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "125.0"
                      "firestarter", "90.0"
                      "impactonly", "1.0"
                      "laserflaresize", "12.1"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "3.0"
                  ] }
                { name = "ferret_missile"
                  displayName = "Pop-up rapid-fire g2a missile launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "vtol", 50.0
                  ]
                  range = Some (ValueOrExpr.Concrete 840.0)
                  reloadTime = Some (ValueOrExpr.Concrete 3.4)
                  weaponVelocity = Some 1200.0
                  areaOfEffect = Some 16.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 9950.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "packolau"
                  soundHit = Some "packohit"
                  explosiongenerator = Some "custom:genericshellexplosion-tiny-aa"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                      "mount_maindir", "-1.5 0 2"
                      "mount_maxangledif", "300.0"
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfeature", "false"
                      "burst", "2.0"
                      "burstrate", "0.2"
                      "burnblow", "true"
                      "canattackground", "false"
                      "cegtag", "missiletrailaa"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "0.0"
                      "firestarter", "72.0"
                      "flighttime", "2.5"
                      "metalpershot", "0.0"
                      "model", "cormissile.s3o"
                      "smoketrail", "true"
                      "smokePeriod", "5.0"
                      "smoketime", "12.0"
                      "smokesize", "4.4"
                      "smokecolor", "0.95"
                      "smokeTrailCastShadow", "false"
                      "castshadow", "false"
                      "soundhitwet", "splshbig"
                      "soundtrigger", "true"
                      "startvelocity", "1.0"
                      "texture1", "null"
                      "texture2", "smoketrailaa"
                      "tracks", "true"
                      "turnrate", "68000.0"
                      "weaponacceleration", "1500.0"
                      "weapontimer", "2.0"
                  ] }
                { name = "heavylaser"
                  displayName = "HighEnergyLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 270.0
                      "vtol", 65.0
                  ]
                  range = Some (ValueOrExpr.Concrete 830.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.0)
                  weaponVelocity = Some 700.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "Lasrmas2"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-medium-green"
                  rgbColor = Some "0 1 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "300.0"
                      "mount_onlytargetcategory", "SURFACE T4AIR"
                      "avoidfeature", "false"
                      "beamtime", "0.2"
                      "corethickness", "0.2"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "125.0"
                      "firestarter", "90.0"
                      "impactonly", "1.0"
                      "laserflaresize", "12.1"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "3.0"
                  ] }
                { name = "heavylaser"
                  displayName = "HighEnergyLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 270.0
                      "vtol", 65.0
                  ]
                  range = Some (ValueOrExpr.Concrete 830.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.0)
                  weaponVelocity = Some 700.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "Lasrmas2"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-medium-green"
                  rgbColor = Some "0 1 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "300.0"
                      "mount_onlytargetcategory", "SURFACE T4AIR"
                      "avoidfeature", "false"
                      "beamtime", "0.2"
                      "corethickness", "0.2"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "125.0"
                      "firestarter", "90.0"
                      "impactonly", "1.0"
                      "laserflaresize", "12.1"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "3.0"
                  ] }
                { name = "ferret_missile"
                  displayName = "Pop-up rapid-fire g2a missile launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "vtol", 50.0
                  ]
                  range = Some (ValueOrExpr.Concrete 840.0)
                  reloadTime = Some (ValueOrExpr.Concrete 3.4)
                  weaponVelocity = Some 1200.0
                  areaOfEffect = Some 16.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 9950.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "packolau"
                  soundHit = Some "packohit"
                  explosiongenerator = Some "custom:genericshellexplosion-tiny-aa"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                      "mount_maindir", "1.5 0 2"
                      "mount_maxangledif", "300.0"
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfeature", "false"
                      "burst", "2.0"
                      "burstrate", "0.2"
                      "burnblow", "true"
                      "canattackground", "false"
                      "cegtag", "missiletrailaa"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "0.0"
                      "firestarter", "72.0"
                      "flighttime", "2.5"
                      "metalpershot", "0.0"
                      "model", "cormissile.s3o"
                      "smoketrail", "true"
                      "smokePeriod", "5.0"
                      "smoketime", "12.0"
                      "smokesize", "4.4"
                      "smokecolor", "0.95"
                      "smokeTrailCastShadow", "false"
                      "castshadow", "false"
                      "soundhitwet", "splshbig"
                      "soundtrigger", "true"
                      "startvelocity", "1.0"
                      "texture1", "null"
                      "texture2", "smoketrailaa"
                      "tracks", "true"
                      "turnrate", "68000.0"
                      "weaponacceleration", "1500.0"
                      "weapontimer", "2.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "17.3217697144 -6.85541303711 2.43087005615"
                  collisionVolumeScales = Some "88.47706604 56.7307739258 178.029220581"
                  collisionVolumeType = Some "Box"
                  damage = Some 30000.0
                  featureDead = None
                  footprintX = Some 6.0
                  footprintZ = Some 18.0
                  height = Some 4.0
                  metal = Some 18000.0
                  object_ = Some "Units/scavboss/corfblackhyt4_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
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
                ok = ["sharmmov"]
                select = ["sharmsel"] }
          customParams = Map.ofList [
                "unitgroup", "weapon"
                "model_author", "Beherith"
                "normaltex", "unittextures/cor_normal.dds"
                "paralyzemultiplier", "0.0"
                "subfolder", "CorShips/T2"
                "techlevel", "3.0"
            ]
          extras = Map.ofList [
                "bankingallowed", "false"
                "buildangle", "16384.0"
                "collide", "true"
                "hoverattack", "true"
                "sightemitheight", "64.0"
                "mass", "1000000.0"
                "radardistance", "1510.0"
                "radaremitheight", "64.0"
                "upright", "true"
            ] }

    let corfblackhyt4Def : UnitDef =
        { name = "corfblackhyt4"
          subfolder = "Scavengers/Air"
          printableName = Some "Flying Black Hydra"
          metalCost = ValueOrExpr.Concrete 25000.0
          energyCost = ValueOrExpr.Concrete 250000.0
          buildTime = ValueOrExpr.Concrete 250000.0
          health = ValueOrExpr.Concrete 67000.0
          sightDistance = ValueOrExpr.Concrete 650.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/scavboss/corfblackhyt4.s3o"
          buildPic = Some "corfblackhyt4.DDS"
          script = Some "Units/scavboss/corfblackhyt4.cob"
          corpse = Some "DEAD"
          explodeAs = Some "FlagshipExplosion"
          selfDestructAs = Some "FlagshipExplosionSelfd"
          collisionVolumeOffsets = Some "0 -14 10"
          collisionVolumeScales = Some "70 70 170"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = Some "T4AIR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 36.0
              maxAcc = 0.015
              maxDec = 0.05
              turnRate = 129.0
              movementClass = None
              maxSlope = None
              maxWaterDepth = Some 15.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 100.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "heavyplasma"
                displayName = "BattleshipCannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 465.0
                    "subs", 100.0
                    "vtol", 130.0
                ]
                range = Some (ValueOrExpr.Concrete 1500.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
                weaponVelocity = Some 600.0
                areaOfEffect = Some 128.0
                accuracy = Some 1200.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "cannhvy1"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:genericshellexplosion-large"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE T4AIR"
                    "avoidfeature", "false"
                    "cegtag", "arty-heavy"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "intensity", "1.1"
                    "soundhitwet", "splsmed"
                ] }
              { name = "heavylaser"
                displayName = "HighEnergyLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 270.0
                    "vtol", 65.0
                ]
                range = Some (ValueOrExpr.Concrete 830.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
                weaponVelocity = Some 700.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "Lasrmas2"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-medium-green"
                rgbColor = Some "0 1 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "300.0"
                    "mount_onlytargetcategory", "SURFACE T4AIR"
                    "avoidfeature", "false"
                    "beamtime", "0.2"
                    "corethickness", "0.2"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "125.0"
                    "firestarter", "90.0"
                    "impactonly", "1.0"
                    "laserflaresize", "12.1"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "3.0"
                ] }
              { name = "ferret_missile"
                displayName = "Pop-up rapid-fire g2a missile launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 50.0
                ]
                range = Some (ValueOrExpr.Concrete 840.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.4)
                weaponVelocity = Some 1200.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = Some 9950.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "packolau"
                soundHit = Some "packohit"
                explosiongenerator = Some "custom:genericshellexplosion-tiny-aa"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                    "mount_maindir", "-1.5 0 2"
                    "mount_maxangledif", "300.0"
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "burst", "2.0"
                    "burstrate", "0.2"
                    "burnblow", "true"
                    "canattackground", "false"
                    "cegtag", "missiletrailaa"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "0.0"
                    "firestarter", "72.0"
                    "flighttime", "2.5"
                    "metalpershot", "0.0"
                    "model", "cormissile.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "5.0"
                    "smoketime", "12.0"
                    "smokesize", "4.4"
                    "smokecolor", "0.95"
                    "smokeTrailCastShadow", "false"
                    "castshadow", "false"
                    "soundhitwet", "splshbig"
                    "soundtrigger", "true"
                    "startvelocity", "1.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa"
                    "tracks", "true"
                    "turnrate", "68000.0"
                    "weaponacceleration", "1500.0"
                    "weapontimer", "2.0"
                ] }
              { name = "heavylaser"
                displayName = "HighEnergyLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 270.0
                    "vtol", 65.0
                ]
                range = Some (ValueOrExpr.Concrete 830.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
                weaponVelocity = Some 700.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "Lasrmas2"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-medium-green"
                rgbColor = Some "0 1 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "300.0"
                    "mount_onlytargetcategory", "SURFACE T4AIR"
                    "avoidfeature", "false"
                    "beamtime", "0.2"
                    "corethickness", "0.2"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "125.0"
                    "firestarter", "90.0"
                    "impactonly", "1.0"
                    "laserflaresize", "12.1"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "3.0"
                ] }
              { name = "heavylaser"
                displayName = "HighEnergyLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 270.0
                    "vtol", 65.0
                ]
                range = Some (ValueOrExpr.Concrete 830.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
                weaponVelocity = Some 700.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "Lasrmas2"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-medium-green"
                rgbColor = Some "0 1 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "300.0"
                    "mount_onlytargetcategory", "SURFACE T4AIR"
                    "avoidfeature", "false"
                    "beamtime", "0.2"
                    "corethickness", "0.2"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "125.0"
                    "firestarter", "90.0"
                    "impactonly", "1.0"
                    "laserflaresize", "12.1"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "3.0"
                ] }
              { name = "ferret_missile"
                displayName = "Pop-up rapid-fire g2a missile launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 50.0
                ]
                range = Some (ValueOrExpr.Concrete 840.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.4)
                weaponVelocity = Some 1200.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = Some 9950.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "packolau"
                soundHit = Some "packohit"
                explosiongenerator = Some "custom:genericshellexplosion-tiny-aa"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                    "mount_maindir", "1.5 0 2"
                    "mount_maxangledif", "300.0"
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "burst", "2.0"
                    "burstrate", "0.2"
                    "burnblow", "true"
                    "canattackground", "false"
                    "cegtag", "missiletrailaa"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "0.0"
                    "firestarter", "72.0"
                    "flighttime", "2.5"
                    "metalpershot", "0.0"
                    "model", "cormissile.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "5.0"
                    "smoketime", "12.0"
                    "smokesize", "4.4"
                    "smokecolor", "0.95"
                    "smokeTrailCastShadow", "false"
                    "castshadow", "false"
                    "soundhitwet", "splshbig"
                    "soundtrigger", "true"
                    "startvelocity", "1.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa"
                    "tracks", "true"
                    "turnrate", "68000.0"
                    "weaponacceleration", "1500.0"
                    "weapontimer", "2.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "17.3217697144 -6.85541303711 2.43087005615"
                collisionVolumeScales = Some "88.47706604 56.7307739258 178.029220581"
                collisionVolumeType = Some "Box"
                damage = Some 30000.0
                featureDead = None
                footprintX = Some 6.0
                footprintZ = Some 18.0
                height = Some 4.0
                metal = Some 18000.0
                object_ = Some "Units/scavboss/corfblackhyt4_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
          ])
          sounds = Some (
            { build = None
              repair = None
              working = None
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["sharmmov"]
              select = ["sharmsel"] })
          customParams = Map.ofList [
              "unitgroup", "weapon"
              "model_author", "Beherith"
              "normaltex", "unittextures/cor_normal.dds"
              "paralyzemultiplier", "0.0"
              "subfolder", "CorShips/T2"
              "techlevel", "3.0"
          ]
          extras = Map.ofList [
              "bankingallowed", "false"
              "buildangle", "16384.0"
              "collide", "true"
              "hoverattack", "true"
              "sightemitheight", "64.0"
              "mass", "1000000.0"
              "radardistance", "1510.0"
              "radaremitheight", "64.0"
              "upright", "true"
          ] }

    let corfblackhyt4ToFlat (def: UnitDef) : Corfblackhyt4 =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canFly = def.movement.Value.canFly
          canMove = def.movement.Value.canMove
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          cruiseAltitude = def.movement.Value.cruiseAltitude.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corfblackhyt4ToUnitDef (flat: Corfblackhyt4) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = None
              maxSlope = None
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = flat.canFly
              canMove = flat.canMove
              floater = false
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some flat.cruiseAltitude
              minWaterDepth = None
              waterline = None
            }
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Legfortt4 =
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
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          maxSlope: float
          maxWaterDepth: float
          canFly: bool
          canMove: bool
          turnInPlaceAngleLimit: float
          cruiseAltitude: float
          weapons: WeaponDef list
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legfortt4 : Legfortt4 =
        { name = "legfortt4"
          subfolder = "Scavengers/Air"
          printableName = Some "Epic Tyrannus"
          metalCost = ValueOrExpr.Concrete 56000.0
          energyCost = ValueOrExpr.Concrete 790000.0
          buildTime = ValueOrExpr.Concrete 900000.0
          health = ValueOrExpr.Concrete 167000.0
          sightDistance = ValueOrExpr.Concrete 1200.0
          footprintX = 8.0
          footprintZ = 8.0
          objectName = Some "Units/scavboss/LEGFORTT4.s3o"
          buildPic = Some "LEGFORT.DDS"
          script = Some "Units/scavboss/legfortt4.cob"
          corpse = None
          explodeAs = Some "korgExplosion"
          selfDestructAs = Some "korgExplosionSelfd"
          collisionVolumeOffsets = Some "0 1 0"
          collisionVolumeScales = Some "140 80 220"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = Some "ALL WEAPON VTOL NOTSUB NOTHOVER"
          speed = ValueOrExpr.Concrete 30.0
          maxAcc = 0.02
          maxDec = 0.02
          turnRate = 120.0
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canFly = true
          canMove = true
          turnInPlaceAngleLimit = 360.0
          cruiseAltitude = 250.0
          weapons = [
                { name = "plasma"
                  displayName = "PlasmaCannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 480.0
                      "subs", 50.0
                      "vtol", 30.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1200.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.0)
                  weaponVelocity = Some 650.0
                  areaOfEffect = Some 160.0
                  accuracy = Some 960.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.65
                  impulseFactor = Some 1.25
                  noSelfDamage = Some true
                  soundStart = Some "cannhvy2"
                  soundHit = Some "xplomed4"
                  explosiongenerator = Some "custom:ministarfire-explosion"
                  rgbColor = Some "0.7 0.7 1.0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "NOTLAND"
                      "mount_maindir", "-1 0 0"
                      "mount_maxangledif", "210.0"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "cegtag", "starfire_arty"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "projectiles", "3.0"
                      "sprayangle", "2500.0"
                      "soundhitwet", "splsmed"
                  ] }
                { name = "plasma"
                  displayName = "PlasmaCannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 480.0
                      "subs", 50.0
                      "vtol", 30.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1200.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.0)
                  weaponVelocity = Some 650.0
                  areaOfEffect = Some 160.0
                  accuracy = Some 960.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.65
                  impulseFactor = Some 1.25
                  noSelfDamage = Some true
                  soundStart = Some "cannhvy2"
                  soundHit = Some "xplomed4"
                  explosiongenerator = Some "custom:ministarfire-explosion"
                  rgbColor = Some "0.7 0.7 1.0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "NOTLAND"
                      "mount_maindir", "1 0 0"
                      "mount_maxangledif", "210.0"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "cegtag", "starfire_arty"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "projectiles", "3.0"
                      "sprayangle", "2500.0"
                      "soundhitwet", "splsmed"
                  ] }
                { name = "semiauto"
                  displayName = "scav rapid fire plasma gun"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "default", 50.0
                      "vtol", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 800.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.1)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 25.0
                  accuracy = Some 250.0
                  turret = Some true
                  tolerance = Some 3000.0
                  edgeEffectiveness = None
                  impulseFactor = None
                  noSelfDamage = None
                  soundStart = Some "tgunshipfire"
                  soundHit = None
                  explosiongenerator = Some "custom:genericshellexplosion-tiny-aa"
                  rgbColor = Some "0.7 0.7 0.0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "240.0"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfriendly", "false"
                      "avoidfeature", "false"
                      "collidefriendly", "false"
                      "collidefeature", "true"
                      "beamtime", "0.07"
                      "corethickness", "0.45"
                      "duration", "0.07"
                      "energypershot", "0.0"
                      "falloffrate", "0.0"
                      "firestarter", "50.0"
                      "interceptedbyshieldtype", "4.0"
                      "minintensity", "1"
                      "rgbcolor2", "1 1 1"
                      "soundtrigger", "true"
                      "texture1", "shot"
                      "texture2", "empty"
                      "thickness", "7.5"
                  ] }
                { name = "semiauto"
                  displayName = "scav rapid fire plasma gun"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "default", 50.0
                      "vtol", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 800.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.1)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 25.0
                  accuracy = Some 250.0
                  turret = Some true
                  tolerance = Some 3000.0
                  edgeEffectiveness = None
                  impulseFactor = None
                  noSelfDamage = None
                  soundStart = Some "tgunshipfire"
                  soundHit = None
                  explosiongenerator = Some "custom:genericshellexplosion-tiny-aa"
                  rgbColor = Some "0.7 0.7 0.0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "-1 0 0"
                      "mount_maxangledif", "190.0"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfriendly", "false"
                      "avoidfeature", "false"
                      "collidefriendly", "false"
                      "collidefeature", "true"
                      "beamtime", "0.07"
                      "corethickness", "0.45"
                      "duration", "0.07"
                      "energypershot", "0.0"
                      "falloffrate", "0.0"
                      "firestarter", "50.0"
                      "interceptedbyshieldtype", "4.0"
                      "minintensity", "1"
                      "rgbcolor2", "1 1 1"
                      "soundtrigger", "true"
                      "texture1", "shot"
                      "texture2", "empty"
                      "thickness", "7.5"
                  ] }
                { name = "semiauto"
                  displayName = "scav rapid fire plasma gun"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "default", 50.0
                      "vtol", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 800.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.1)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 25.0
                  accuracy = Some 250.0
                  turret = Some true
                  tolerance = Some 3000.0
                  edgeEffectiveness = None
                  impulseFactor = None
                  noSelfDamage = None
                  soundStart = Some "tgunshipfire"
                  soundHit = None
                  explosiongenerator = Some "custom:genericshellexplosion-tiny-aa"
                  rgbColor = Some "0.7 0.7 0.0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "1 0 0"
                      "mount_maxangledif", "190.0"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfriendly", "false"
                      "avoidfeature", "false"
                      "collidefriendly", "false"
                      "collidefeature", "true"
                      "beamtime", "0.07"
                      "corethickness", "0.45"
                      "duration", "0.07"
                      "energypershot", "0.0"
                      "falloffrate", "0.0"
                      "firestarter", "50.0"
                      "interceptedbyshieldtype", "4.0"
                      "minintensity", "1"
                      "rgbcolor2", "1 1 1"
                      "soundtrigger", "true"
                      "texture1", "shot"
                      "texture2", "empty"
                      "thickness", "7.5"
                  ] }
                { name = "aa_missiles"
                  displayName = "Advanced d2a rapid missile launcher"
                  weaponType = Some "StarburstLauncher"
                  damage = Map.ofList [
                      "vtol", 154.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1240.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.2)
                  weaponVelocity = Some 1200.0
                  areaOfEffect = Some 16.0
                  accuracy = None
                  turret = None
                  tolerance = Some 9950.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "packolau"
                  soundHit = Some "packohit"
                  explosiongenerator = Some "custom:genericshellexplosion-tiny-aa"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "1 0 0"
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "canattackground", "false"
                      "cegtag", "missiletrailaa"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "72.0"
                      "fixedLauncher", "true"
                      "flighttime", "7.5"
                      "model", "legsmallrocket.s3o"
                      "smoketrail", "true"
                      "smokePeriod", "5.0"
                      "smoketime", "8.0"
                      "smokesize", "4.2"
                      "smokecolor", "1.0"
                      "smokeTrailCastShadow", "false"
                      "castshadow", "false"
                      "startvelocity", "150.0"
                      "soundhitwet", "splshbig"
                      "soundtrigger", "true"
                      "startvelocity", "150.0"
                      "texture1", "null"
                      "texture2", "smoketrailaa"
                      "tracks", "true"
                      "trajectoryHeight", "1.0"
                      "turnrate", "52000.0"
                      "weaponacceleration", "800.0"
                      "weapontimer", "0.32"
                  ] }
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
                ok = ["vtolcrmv"]
                select = ["vtolcrac"] }
          customParams = Map.ofList [
                "unitgroup", "weapon"
                "model_author", "tHARSIS"
                "normaltex", "unittextures/LEG_normal.dds"
                "subfolder", "CorAircraft/T2"
                "techlevel", "3.0"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "bankingallowed", "false"
                "collide", "true"
                "hoverattack", "true"
                "nochasecategory", "VTOL"
                "radardistance", "1000.0"
                "upright", "true"
            ] }

    let legfortt4Def : UnitDef =
        { name = "legfortt4"
          subfolder = "Scavengers/Air"
          printableName = Some "Epic Tyrannus"
          metalCost = ValueOrExpr.Concrete 56000.0
          energyCost = ValueOrExpr.Concrete 790000.0
          buildTime = ValueOrExpr.Concrete 900000.0
          health = ValueOrExpr.Concrete 167000.0
          sightDistance = ValueOrExpr.Concrete 1200.0
          footprintX = 8.0
          footprintZ = 8.0
          objectName = Some "Units/scavboss/LEGFORTT4.s3o"
          buildPic = Some "LEGFORT.DDS"
          script = Some "Units/scavboss/legfortt4.cob"
          corpse = None
          explodeAs = Some "korgExplosion"
          selfDestructAs = Some "korgExplosionSelfd"
          collisionVolumeOffsets = Some "0 1 0"
          collisionVolumeScales = Some "140 80 220"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = Some "ALL WEAPON VTOL NOTSUB NOTHOVER"
          movement = Some (
            { speed = ValueOrExpr.Concrete 30.0
              maxAcc = 0.02
              maxDec = 0.02
              turnRate = 120.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 360.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 250.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "plasma"
                displayName = "PlasmaCannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 480.0
                    "subs", 50.0
                    "vtol", 30.0
                ]
                range = Some (ValueOrExpr.Concrete 1200.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
                weaponVelocity = Some 650.0
                areaOfEffect = Some 160.0
                accuracy = Some 960.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.65
                impulseFactor = Some 1.25
                noSelfDamage = Some true
                soundStart = Some "cannhvy2"
                soundHit = Some "xplomed4"
                explosiongenerator = Some "custom:ministarfire-explosion"
                rgbColor = Some "0.7 0.7 1.0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTLAND"
                    "mount_maindir", "-1 0 0"
                    "mount_maxangledif", "210.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "cegtag", "starfire_arty"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "projectiles", "3.0"
                    "sprayangle", "2500.0"
                    "soundhitwet", "splsmed"
                ] }
              { name = "plasma"
                displayName = "PlasmaCannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 480.0
                    "subs", 50.0
                    "vtol", 30.0
                ]
                range = Some (ValueOrExpr.Concrete 1200.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
                weaponVelocity = Some 650.0
                areaOfEffect = Some 160.0
                accuracy = Some 960.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.65
                impulseFactor = Some 1.25
                noSelfDamage = Some true
                soundStart = Some "cannhvy2"
                soundHit = Some "xplomed4"
                explosiongenerator = Some "custom:ministarfire-explosion"
                rgbColor = Some "0.7 0.7 1.0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTLAND"
                    "mount_maindir", "1 0 0"
                    "mount_maxangledif", "210.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "cegtag", "starfire_arty"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "projectiles", "3.0"
                    "sprayangle", "2500.0"
                    "soundhitwet", "splsmed"
                ] }
              { name = "semiauto"
                displayName = "scav rapid fire plasma gun"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 50.0
                    "vtol", 100.0
                ]
                range = Some (ValueOrExpr.Concrete 800.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.1)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 25.0
                accuracy = Some 250.0
                turret = Some true
                tolerance = Some 3000.0
                edgeEffectiveness = None
                impulseFactor = None
                noSelfDamage = None
                soundStart = Some "tgunshipfire"
                soundHit = None
                explosiongenerator = Some "custom:genericshellexplosion-tiny-aa"
                rgbColor = Some "0.7 0.7 0.0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "240.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfriendly", "false"
                    "avoidfeature", "false"
                    "collidefriendly", "false"
                    "collidefeature", "true"
                    "beamtime", "0.07"
                    "corethickness", "0.45"
                    "duration", "0.07"
                    "energypershot", "0.0"
                    "falloffrate", "0.0"
                    "firestarter", "50.0"
                    "interceptedbyshieldtype", "4.0"
                    "minintensity", "1"
                    "rgbcolor2", "1 1 1"
                    "soundtrigger", "true"
                    "texture1", "shot"
                    "texture2", "empty"
                    "thickness", "7.5"
                ] }
              { name = "semiauto"
                displayName = "scav rapid fire plasma gun"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 50.0
                    "vtol", 100.0
                ]
                range = Some (ValueOrExpr.Concrete 800.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.1)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 25.0
                accuracy = Some 250.0
                turret = Some true
                tolerance = Some 3000.0
                edgeEffectiveness = None
                impulseFactor = None
                noSelfDamage = None
                soundStart = Some "tgunshipfire"
                soundHit = None
                explosiongenerator = Some "custom:genericshellexplosion-tiny-aa"
                rgbColor = Some "0.7 0.7 0.0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "-1 0 0"
                    "mount_maxangledif", "190.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfriendly", "false"
                    "avoidfeature", "false"
                    "collidefriendly", "false"
                    "collidefeature", "true"
                    "beamtime", "0.07"
                    "corethickness", "0.45"
                    "duration", "0.07"
                    "energypershot", "0.0"
                    "falloffrate", "0.0"
                    "firestarter", "50.0"
                    "interceptedbyshieldtype", "4.0"
                    "minintensity", "1"
                    "rgbcolor2", "1 1 1"
                    "soundtrigger", "true"
                    "texture1", "shot"
                    "texture2", "empty"
                    "thickness", "7.5"
                ] }
              { name = "semiauto"
                displayName = "scav rapid fire plasma gun"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 50.0
                    "vtol", 100.0
                ]
                range = Some (ValueOrExpr.Concrete 800.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.1)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 25.0
                accuracy = Some 250.0
                turret = Some true
                tolerance = Some 3000.0
                edgeEffectiveness = None
                impulseFactor = None
                noSelfDamage = None
                soundStart = Some "tgunshipfire"
                soundHit = None
                explosiongenerator = Some "custom:genericshellexplosion-tiny-aa"
                rgbColor = Some "0.7 0.7 0.0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "1 0 0"
                    "mount_maxangledif", "190.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfriendly", "false"
                    "avoidfeature", "false"
                    "collidefriendly", "false"
                    "collidefeature", "true"
                    "beamtime", "0.07"
                    "corethickness", "0.45"
                    "duration", "0.07"
                    "energypershot", "0.0"
                    "falloffrate", "0.0"
                    "firestarter", "50.0"
                    "interceptedbyshieldtype", "4.0"
                    "minintensity", "1"
                    "rgbcolor2", "1 1 1"
                    "soundtrigger", "true"
                    "texture1", "shot"
                    "texture2", "empty"
                    "thickness", "7.5"
                ] }
              { name = "aa_missiles"
                displayName = "Advanced d2a rapid missile launcher"
                weaponType = Some "StarburstLauncher"
                damage = Map.ofList [
                    "vtol", 154.0
                ]
                range = Some (ValueOrExpr.Concrete 1240.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.2)
                weaponVelocity = Some 1200.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = None
                tolerance = Some 9950.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "packolau"
                soundHit = Some "packohit"
                explosiongenerator = Some "custom:genericshellexplosion-tiny-aa"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "1 0 0"
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "cegtag", "missiletrailaa"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "72.0"
                    "fixedLauncher", "true"
                    "flighttime", "7.5"
                    "model", "legsmallrocket.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "5.0"
                    "smoketime", "8.0"
                    "smokesize", "4.2"
                    "smokecolor", "1.0"
                    "smokeTrailCastShadow", "false"
                    "castshadow", "false"
                    "startvelocity", "150.0"
                    "soundhitwet", "splshbig"
                    "soundtrigger", "true"
                    "startvelocity", "150.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa"
                    "tracks", "true"
                    "trajectoryHeight", "1.0"
                    "turnrate", "52000.0"
                    "weaponacceleration", "800.0"
                    "weapontimer", "0.32"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = Some (
            { build = None
              repair = None
              working = None
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["vtolcrmv"]
              select = ["vtolcrac"] })
          customParams = Map.ofList [
              "unitgroup", "weapon"
              "model_author", "tHARSIS"
              "normaltex", "unittextures/LEG_normal.dds"
              "subfolder", "CorAircraft/T2"
              "techlevel", "3.0"
          ]
          extras = Map.ofList [
              "blocking", "true"
              "bankingallowed", "false"
              "collide", "true"
              "hoverattack", "true"
              "nochasecategory", "VTOL"
              "radardistance", "1000.0"
              "upright", "true"
          ] }

    let legfortt4ToFlat (def: UnitDef) : Legfortt4 =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canFly = def.movement.Value.canFly
          canMove = def.movement.Value.canMove
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          cruiseAltitude = def.movement.Value.cruiseAltitude.Value
          weapons = def.weapons.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let legfortt4ToUnitDef (flat: Legfortt4) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = None
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = flat.canFly
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some flat.cruiseAltitude
              minWaterDepth = None
              waterline = None
            }
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = None
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Legmost3 =
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
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          maxSlope: float
          maxWaterDepth: float
          canFly: bool
          canMove: bool
          turnInPlaceAngleLimit: float
          cruiseAltitude: float
          weapons: WeaponDef list
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legmost3 : Legmost3 =
        { name = "legmost3"
          subfolder = "Scavengers/Air"
          printableName = Some "Epic Mosquito"
          metalCost = ValueOrExpr.Concrete 3000.0
          energyCost = ValueOrExpr.Concrete 42000.0
          buildTime = ValueOrExpr.Concrete 42000.0
          health = ValueOrExpr.Concrete 9000.0
          sightDistance = ValueOrExpr.Concrete 800.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/legmost3.s3o"
          buildPic = Some "LEGMOS.DDS"
          script = Some "Units/legmost3.cob"
          corpse = None
          explodeAs = Some "smallExplosionGeneric"
          selfDestructAs = Some "smallExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 130.0
          maxAcc = 0.15
          maxDec = 0.375
          turnRate = 500.0
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canFly = true
          canMove = true
          turnInPlaceAngleLimit = 360.0
          cruiseAltitude = 150.0
          weapons = [
                { name = "exp_heavyrocket"
                  displayName = "CatapultRockets"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "default", 200.0
                  ]
                  range = Some (ValueOrExpr.Concrete 700.0)
                  reloadTime = Some (ValueOrExpr.Concrete 3.0)
                  weaponVelocity = Some 700.0
                  areaOfEffect = Some 96.0
                  accuracy = None
                  turret = None
                  tolerance = Some 4000.0
                  edgeEffectiveness = Some 0.65
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "rapidrocket3"
                  soundHit = Some "rockhit"
                  explosiongenerator = Some "custom:genericshellexplosion-catapult"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "SURFACE"
                      "movingaccuracy", "3000.0"
                      "avoidfeature", "false"
                      "burst", "6.0"
                      "burstrate", "0.2"
                      "cegtag", "missiletrailsmall-simple"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "dance", "25.0"
                      "firestarter", "70.0"
                      "flighttime", "3.2"
                      "impulseboost", "0.123"
                      "metalpershot", "0.0"
                      "model", "legmediumrocket.s3o"
                      "proximitypriority", "-1.0"
                      "smokecolor", "0.5"
                      "smokeperiod", "4.0"
                      "smokesize", "8.5"
                      "smoketime", "16.0"
                      "smoketrail", "true"
                      "smoketrailcastshadow", "false"
                      "soundhitwet", "splsmed"
                      "startvelocity", "300.0"
                      "stockpile", "true"
                      "stockpiletime", "6.0"
                      "texture1", "null"
                      "texture2", "smoketrailbar"
                      "tracks", "true"
                      "turnrate", "5000.0"
                      "weaponacceleration", "200.0"
                      "weapontimer", "6.0"
                  ] }
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
                ok = ["vtolarmv"]
                select = ["vtolarac"] }
          customParams = Map.ofList [
                "unitgroup", "weapon"
                "model_author", "Tharsis"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "ArmAircraft"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "collide", "true"
                "hoverattack", "true"
                "nochasecategory", "VTOL"
            ] }

    let legmost3Def : UnitDef =
        { name = "legmost3"
          subfolder = "Scavengers/Air"
          printableName = Some "Epic Mosquito"
          metalCost = ValueOrExpr.Concrete 3000.0
          energyCost = ValueOrExpr.Concrete 42000.0
          buildTime = ValueOrExpr.Concrete 42000.0
          health = ValueOrExpr.Concrete 9000.0
          sightDistance = ValueOrExpr.Concrete 800.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/legmost3.s3o"
          buildPic = Some "LEGMOS.DDS"
          script = Some "Units/legmost3.cob"
          corpse = None
          explodeAs = Some "smallExplosionGeneric"
          selfDestructAs = Some "smallExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 130.0
              maxAcc = 0.15
              maxDec = 0.375
              turnRate = 500.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 360.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 150.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "exp_heavyrocket"
                displayName = "CatapultRockets"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 200.0
                ]
                range = Some (ValueOrExpr.Concrete 700.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.0)
                weaponVelocity = Some 700.0
                areaOfEffect = Some 96.0
                accuracy = None
                turret = None
                tolerance = Some 4000.0
                edgeEffectiveness = Some 0.65
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "rapidrocket3"
                soundHit = Some "rockhit"
                explosiongenerator = Some "custom:genericshellexplosion-catapult"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "movingaccuracy", "3000.0"
                    "avoidfeature", "false"
                    "burst", "6.0"
                    "burstrate", "0.2"
                    "cegtag", "missiletrailsmall-simple"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "dance", "25.0"
                    "firestarter", "70.0"
                    "flighttime", "3.2"
                    "impulseboost", "0.123"
                    "metalpershot", "0.0"
                    "model", "legmediumrocket.s3o"
                    "proximitypriority", "-1.0"
                    "smokecolor", "0.5"
                    "smokeperiod", "4.0"
                    "smokesize", "8.5"
                    "smoketime", "16.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splsmed"
                    "startvelocity", "300.0"
                    "stockpile", "true"
                    "stockpiletime", "6.0"
                    "texture1", "null"
                    "texture2", "smoketrailbar"
                    "tracks", "true"
                    "turnrate", "5000.0"
                    "weaponacceleration", "200.0"
                    "weapontimer", "6.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = Some (
            { build = None
              repair = None
              working = None
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["vtolarmv"]
              select = ["vtolarac"] })
          customParams = Map.ofList [
              "unitgroup", "weapon"
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "ArmAircraft"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "collide", "true"
              "hoverattack", "true"
              "nochasecategory", "VTOL"
          ] }

    let legmost3ToFlat (def: UnitDef) : Legmost3 =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canFly = def.movement.Value.canFly
          canMove = def.movement.Value.canMove
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          cruiseAltitude = def.movement.Value.cruiseAltitude.Value
          weapons = def.weapons.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let legmost3ToUnitDef (flat: Legmost3) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = None
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = flat.canFly
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some flat.cruiseAltitude
              minWaterDepth = None
              waterline = None
            }
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = None
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

