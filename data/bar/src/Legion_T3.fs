// Auto-generated BAR unit data: Legion/T3 (unified)
namespace BarData.Units

open BarData

module Legion_T3 =

    type Leegmech =
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

    let leegmech : Leegmech =
        { name = "leegmech"
          subfolder = "Legion/T3"
          metalCost = ValueOrExpr.Concrete 10000.0
          energyCost = ValueOrExpr.Concrete 200000.0
          buildTime = ValueOrExpr.Concrete 260000.0
          health = ValueOrExpr.Concrete 60000.0
          sightDistance = ValueOrExpr.Concrete 617.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/LEGMECH.s3o"
          buildPic = Some "LEGMECH.DDS"
          script = Some "Units/LEGMECH.cob"
          corpse = Some "DEAD"
          explodeAs = Some "bantha"
          selfDestructAs = Some "banthaSelfd"
          collisionVolumeOffsets = Some "0 -11 0"
          collisionVolumeScales = Some "66 86 66"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 40.5
          maxAcc = 0.11845
          maxDec = 0.7521
          turnRate = 450.0
          movementClass = "HBOT4"
          maxSlope = 17.0
          maxWaterDepth = 12.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.089
          weapons = [
                { name = "aimhull"
                  displayName = "Parabolic trajectory g2g multi-rocket launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "default", 30.0
                      "subs", 15.0
                  ]
                  range = Some (ValueOrExpr.Concrete 700.0)
                  reloadTime = Some (ValueOrExpr.Concrete 8.0)
                  weaponVelocity = Some 600.0
                  areaOfEffect = Some 70.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.65
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "rocksalvo"
                  soundHit = None
                  explosiongenerator = Some "custom:burnfire-xs"
                  rgbColor = None
                  customParams = Map.ofList [
                      "area_onhit_ceg", "fire-area-75-repeat"
                      "area_onhit_damageCeg", "burnflamexl-gen"
                      "area_onhit_resistance", "fire"
                      "projectile_destruction_method", "descend"
                  ]
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "burst", "16.0"
                      "burstrate", "0.2"
                      "collidefriendly", "false"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "70.0"
                      "flighttime", "4.0"
                      "model", "artshell-large.s3o"
                      "smoketrail", "true"
                      "smokePeriod", "7.0"
                      "smoketime", "21.0"
                      "smokesize", "6.5"
                      "smokecolor", "0.5"
                      "smokeTrailCastShadow", "false"
                      "castshadow", "true"
                      "soundhitdry", "flamhit1"
                      "soundhitwet", "splssml"
                      "soundtrigger", "true"
                      "startvelocity", "160.0"
                      "targetmoveerror", "0.2"
                      "texture1", "null"
                      "texture2", "smoketraildark"
                      "trajectoryheight", "1.5"
                      "turnrate", "4000.0"
                      "weaponacceleration", "100.0"
                      "weapontimer", "6.0"
                      "wobble", "10000.0"
                  ] }
                { name = "shotgun"
                  displayName = "Shotgun"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 125.0
                  ]
                  range = Some (ValueOrExpr.Concrete 550.0)
                  reloadTime = Some (ValueOrExpr.Concrete 3.0)
                  weaponVelocity = Some 600.0
                  areaOfEffect = Some 50.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 6000.0
                  edgeEffectiveness = Some 0.65
                  impulseFactor = Some 0.2
                  noSelfDamage = Some true
                  soundStart = Some "kroggie2xs"
                  soundHit = Some "xplomed2xs"
                  explosiongenerator = Some "custom:genericshellexplosion-small"
                  rgbColor = Some "1 0.75 0.25"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_maindir", "1 0 0"
                      "mount_maxangledif", "270.0"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "intensity", "3.0"
                      "predictboost", "1.0"
                      "projectiles", "9.0"
                      "size", "2.0"
                      "soundhitwet", "splsmed"
                      "soundstartvolume", "12.0"
                      "sprayangle", "1500.0"
                      "weapontimer", "1.0"
                  ] }
                { name = "railgunt3"
                  displayName = "Railgun"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "commanders", 250.0
                      "default", 500.0
                  ]
                  range = Some (ValueOrExpr.Concrete 850.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.25)
                  weaponVelocity = Some 3180.0
                  areaOfEffect = Some 24.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 6000.0
                  edgeEffectiveness = Some 0.85
                  impulseFactor = Some 1.0
                  noSelfDamage = Some true
                  soundStart = Some "railgun3"
                  soundHit = Some "mavgun3"
                  explosiongenerator = Some "custom:plasmahit-sparkonly"
                  rgbColor = Some "0.74 0.64 0.94"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "-1 0 0"
                      "mount_maxangledif", "270.0"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "cegtag", "railgun"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "0.12"
                      "energypershot", "1000.0"
                      "firestarter", "0.0"
                      "hardstop", "true"
                      "impactonly", "true"
                      "intensity", "0.8"
                      "noexplode", "true"
                      "ownerExpAccWeight", "4.0"
                      "proximitypriority", "1.0"
                      "soundhitwet", "splshbig"
                      "soundstartvolume", "26.0"
                      "thickness", "3.0"
                  ] }
                { name = "frontgun"
                  displayName = "Rapid-fire short range machine guns"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "commanders", 33.0
                      "default", 33.0
                      "vtol", 33.0
                  ]
                  range = Some (ValueOrExpr.Concrete 400.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.4)
                  weaponVelocity = Some 921.0
                  areaOfEffect = Some 16.0
                  accuracy = Some 7.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.85
                  impulseFactor = Some 1.5
                  noSelfDamage = Some true
                  soundStart = Some "minigun3"
                  soundHit = Some "bimpact3"
                  explosiongenerator = Some "custom:plasmahit-sparkonly"
                  rgbColor = Some "1 0.95 0.4"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "270.0"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "burst", "6.0"
                      "burstrate", "0.0675"
                      "burnblow", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "0.04"
                      "fallOffRate", "0.2"
                      "firestarter", "0.0"
                      "intensity", "0.8"
                      "ownerExpAccWeight", "4.0"
                      "proximitypriority", "1.0"
                      "soundhitwet", "splshbig"
                      "soundstartvolume", "7.5"
                      "sprayangle", "968.0"
                      "thickness", "1.4"
                  ] }
                { name = "topgunaa"
                  displayName = "Rapid-fire anti-air machine guns"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "default", 75.0
                  ]
                  range = Some (ValueOrExpr.Concrete 651.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.0)
                  weaponVelocity = Some 975.0
                  areaOfEffect = Some 16.0
                  accuracy = Some 7.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.85
                  impulseFactor = Some 1.5
                  noSelfDamage = Some true
                  soundStart = Some "minigun3"
                  soundHit = Some "bimpact3"
                  explosiongenerator = Some "custom:plasmahit-sparkonly"
                  rgbColor = Some "1 0.4 0.95"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfeature", "false"
                      "burst", "4.0"
                      "burstrate", "0.1"
                      "burnblow", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "0.045"
                      "fallOffRate", "0.2"
                      "firestarter", "0.0"
                      "intensity", "0.8"
                      "ownerExpAccWeight", "4.0"
                      "proximitypriority", "1.0"
                      "soundhitwet", "splshbig"
                      "soundstartvolume", "12.0"
                      "sprayangle", "1000.0"
                      "thickness", "1.1"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "5 -2 0"
                  collisionVolumeScales = Some "73 24 87"
                  collisionVolumeType = Some "Box"
                  damage = Some 30000.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 6350.0
                  object_ = Some "Units/legmech_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 10500.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 3300.0
                  object_ = Some "Units/arm3X3A.s3o"
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
                ok = ["krogok1"]
                select = ["krogsel1"] }
          customParams = Map.ofList [
                "unitgroup", "weapon"
                "customrange", "400.0"
                "model_author", "Kremenchuk"
                "normaltex", "unittextures/leegmech_normal.dds"
                "subfolder", "leggantry"
                "techlevel", "3.0"
            ]
          extras = Map.ofList [
                "airsightdistance", "1100.0"
                "mass", "200000.0"
                "nochasecategory", "VTOL"
                "selfdestructcountdown", "10.0"
                "upright", "true"
            ] }

    let leegmechDef : UnitDef =
        { name = "leegmech"
          subfolder = "Legion/T3"
          metalCost = ValueOrExpr.Concrete 10000.0
          energyCost = ValueOrExpr.Concrete 200000.0
          buildTime = ValueOrExpr.Concrete 260000.0
          health = ValueOrExpr.Concrete 60000.0
          sightDistance = ValueOrExpr.Concrete 617.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/LEGMECH.s3o"
          buildPic = Some "LEGMECH.DDS"
          script = Some "Units/LEGMECH.cob"
          corpse = Some "DEAD"
          explodeAs = Some "bantha"
          selfDestructAs = Some "banthaSelfd"
          collisionVolumeOffsets = Some "0 -11 0"
          collisionVolumeScales = Some "66 86 66"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 40.5
              maxAcc = 0.11845
              maxDec = 0.7521
              turnRate = 450.0
              movementClass = Some "HBOT4"
              maxSlope = Some 17.0
              maxWaterDepth = Some 12.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.089
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "aimhull"
                displayName = "Parabolic trajectory g2g multi-rocket launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 30.0
                    "subs", 15.0
                ]
                range = Some (ValueOrExpr.Concrete 700.0)
                reloadTime = Some (ValueOrExpr.Concrete 8.0)
                weaponVelocity = Some 600.0
                areaOfEffect = Some 70.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.65
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "rocksalvo"
                soundHit = None
                explosiongenerator = Some "custom:burnfire-xs"
                rgbColor = None
                customParams = Map.ofList [
                    "area_onhit_ceg", "fire-area-75-repeat"
                    "area_onhit_damageCeg", "burnflamexl-gen"
                    "area_onhit_resistance", "fire"
                    "projectile_destruction_method", "descend"
                ]
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "burst", "16.0"
                    "burstrate", "0.2"
                    "collidefriendly", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "70.0"
                    "flighttime", "4.0"
                    "model", "artshell-large.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "7.0"
                    "smoketime", "21.0"
                    "smokesize", "6.5"
                    "smokecolor", "0.5"
                    "smokeTrailCastShadow", "false"
                    "castshadow", "true"
                    "soundhitdry", "flamhit1"
                    "soundhitwet", "splssml"
                    "soundtrigger", "true"
                    "startvelocity", "160.0"
                    "targetmoveerror", "0.2"
                    "texture1", "null"
                    "texture2", "smoketraildark"
                    "trajectoryheight", "1.5"
                    "turnrate", "4000.0"
                    "weaponacceleration", "100.0"
                    "weapontimer", "6.0"
                    "wobble", "10000.0"
                ] }
              { name = "shotgun"
                displayName = "Shotgun"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 125.0
                ]
                range = Some (ValueOrExpr.Concrete 550.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.0)
                weaponVelocity = Some 600.0
                areaOfEffect = Some 50.0
                accuracy = None
                turret = Some true
                tolerance = Some 6000.0
                edgeEffectiveness = Some 0.65
                impulseFactor = Some 0.2
                noSelfDamage = Some true
                soundStart = Some "kroggie2xs"
                soundHit = Some "xplomed2xs"
                explosiongenerator = Some "custom:genericshellexplosion-small"
                rgbColor = Some "1 0.75 0.25"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_maindir", "1 0 0"
                    "mount_maxangledif", "270.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "intensity", "3.0"
                    "predictboost", "1.0"
                    "projectiles", "9.0"
                    "size", "2.0"
                    "soundhitwet", "splsmed"
                    "soundstartvolume", "12.0"
                    "sprayangle", "1500.0"
                    "weapontimer", "1.0"
                ] }
              { name = "railgunt3"
                displayName = "Railgun"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "commanders", 250.0
                    "default", 500.0
                ]
                range = Some (ValueOrExpr.Concrete 850.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.25)
                weaponVelocity = Some 3180.0
                areaOfEffect = Some 24.0
                accuracy = None
                turret = Some true
                tolerance = Some 6000.0
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 1.0
                noSelfDamage = Some true
                soundStart = Some "railgun3"
                soundHit = Some "mavgun3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "0.74 0.64 0.94"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "-1 0 0"
                    "mount_maxangledif", "270.0"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "cegtag", "railgun"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.12"
                    "energypershot", "1000.0"
                    "firestarter", "0.0"
                    "hardstop", "true"
                    "impactonly", "true"
                    "intensity", "0.8"
                    "noexplode", "true"
                    "ownerExpAccWeight", "4.0"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "26.0"
                    "thickness", "3.0"
                ] }
              { name = "frontgun"
                displayName = "Rapid-fire short range machine guns"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "commanders", 33.0
                    "default", 33.0
                    "vtol", 33.0
                ]
                range = Some (ValueOrExpr.Concrete 400.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.4)
                weaponVelocity = Some 921.0
                areaOfEffect = Some 16.0
                accuracy = Some 7.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 1.5
                noSelfDamage = Some true
                soundStart = Some "minigun3"
                soundHit = Some "bimpact3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "1 0.95 0.4"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "270.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "burst", "6.0"
                    "burstrate", "0.0675"
                    "burnblow", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.04"
                    "fallOffRate", "0.2"
                    "firestarter", "0.0"
                    "intensity", "0.8"
                    "ownerExpAccWeight", "4.0"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "7.5"
                    "sprayangle", "968.0"
                    "thickness", "1.4"
                ] }
              { name = "topgunaa"
                displayName = "Rapid-fire anti-air machine guns"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 75.0
                ]
                range = Some (ValueOrExpr.Concrete 651.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
                weaponVelocity = Some 975.0
                areaOfEffect = Some 16.0
                accuracy = Some 7.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 1.5
                noSelfDamage = Some true
                soundStart = Some "minigun3"
                soundHit = Some "bimpact3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "1 0.4 0.95"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "burst", "4.0"
                    "burstrate", "0.1"
                    "burnblow", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.045"
                    "fallOffRate", "0.2"
                    "firestarter", "0.0"
                    "intensity", "0.8"
                    "ownerExpAccWeight", "4.0"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "12.0"
                    "sprayangle", "1000.0"
                    "thickness", "1.1"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "5 -2 0"
                collisionVolumeScales = Some "73 24 87"
                collisionVolumeType = Some "Box"
                damage = Some 30000.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 6350.0
                object_ = Some "Units/legmech_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 10500.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 3300.0
                object_ = Some "Units/arm3X3A.s3o"
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
              ok = ["krogok1"]
              select = ["krogsel1"] })
          customParams = Map.ofList [
              "unitgroup", "weapon"
              "customrange", "400.0"
              "model_author", "Kremenchuk"
              "normaltex", "unittextures/leegmech_normal.dds"
              "subfolder", "leggantry"
              "techlevel", "3.0"
          ]
          extras = Map.ofList [
              "airsightdistance", "1100.0"
              "mass", "200000.0"
              "nochasecategory", "VTOL"
              "selfdestructcountdown", "10.0"
              "upright", "true"
          ] }

    let leegmechToFlat (def: UnitDef) : Leegmech =
        { name = def.name
          subfolder = def.subfolder
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
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let leegmechToUnitDef (flat: Leegmech) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
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
              movementClass = Some flat.movementClass
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit
              cruiseAltitude = None
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

    type Legbunk =
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

    let legbunk : Legbunk =
        { name = "legbunk"
          subfolder = "Legion/T3"
          metalCost = ValueOrExpr.Concrete 1850.0
          energyCost = ValueOrExpr.Concrete 42000.0
          buildTime = ValueOrExpr.Concrete 46430.0
          health = ValueOrExpr.Concrete 9400.0
          sightDistance = ValueOrExpr.Concrete 375.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/legbunk.s3o"
          buildPic = Some "legbunk.dds"
          script = Some "Units/legbunk.cob"
          corpse = Some "DEAD"
          explodeAs = Some "explosiont3"
          selfDestructAs = Some "explosiont3xl"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "55 80 55"
          collisionVolumeType = Some "CYLY"
          seismicSignature = None
          category = Some "BOT MOBILE WEAPON ALL NOTSUB NOTAIR NOTHOVER SURFACE EMPABLE"
          speed = ValueOrExpr.Concrete 82.0
          maxAcc = 0.253
          maxDec = 0.8211
          turnRate = 1214.0
          movementClass = "HBOT4"
          maxSlope = 17.0
          maxWaterDepth = 22.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.518
          weapons = [
                { name = "aimhull"
                  displayName = "Targeting System"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 0.0
                  ]
                  range = Some (ValueOrExpr.Concrete 650.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.1)
                  weaponVelocity = Some 360.0
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
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "340.0"
                      "avoidfeature", "false"
                      "canattackground", "true"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "gravityaffected", "true"
                      "hightrajectory", "1.0"
                      "size", "0.0"
                      "soundhitwet", ""
                  ] }
                { name = "piledriver"
                  displayName = "Hard-Plasma Mining Tool"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "commanders", 500.0
                      "default", 1500.0
                  ]
                  range = Some (ValueOrExpr.Concrete 150.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.0)
                  weaponVelocity = Some 600.0
                  areaOfEffect = Some 144.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.8
                  impulseFactor = Some 1.0
                  noSelfDamage = Some true
                  soundStart = Some "packolau"
                  soundHit = Some "xplomed2"
                  explosiongenerator = Some "custom:barrelshot-large"
                  rgbColor = Some "1 0.8 0.17"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "GROUNDSCOUT"
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_fastautoretargeting", "false"
                      "avoidfeature", "false"
                      "cegtag", "gausscannonprojectile"
                      "craterboost", "0.5"
                      "cratermult", "0.5"
                      "damagemodifier", "0.33"
                      "gravityaffected", "false"
                      "impulseboost", "10.0"
                      "intensity", "4.0"
                      "noexplode", "true"
                      "size", "0.0"
                      "soundhitwet", "sizzlexs"
                      "soundstartvolume", "26.0"
                      "soundtrigger", "true"
                      "thickness", "24.0"
                      "waterweapon", "true"
                  ] }
                { name = "railgunt2"
                  displayName = "Snub-Nose Railgun"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "commanders", 250.0
                      "default", 475.0
                  ]
                  range = Some (ValueOrExpr.Concrete 650.0)
                  reloadTime = Some (ValueOrExpr.Concrete 3.0)
                  weaponVelocity = Some 3180.0
                  areaOfEffect = Some 32.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 3000.0
                  edgeEffectiveness = Some 0.85
                  impulseFactor = Some 1.0
                  noSelfDamage = Some true
                  soundStart = Some "railgunxl"
                  soundHit = Some "mavgun3"
                  explosiongenerator = Some "custom:plasmahit-sparkonly"
                  rgbColor = Some "0.34 0.64 0.94"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "GROUNDSCOUT"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "canattackground", "true"
                      "cegtag", "railgun"
                      "collisionSize", "0.667"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "0.0"
                      "duration", "0.12"
                      "energypershot", "250.0"
                      "firestarter", "0.0"
                      "hardstop", "true"
                      "impactonly", "false"
                      "intensity", "0.8"
                      "noexplode", "true"
                      "ownerExpAccWeight", "4.0"
                      "proximitypriority", "1.0"
                      "soundhitwet", "splshbig"
                      "soundstartvolume", "26.0"
                      "thickness", "3.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "61.6002807617 54.8114776611 71.5794219971"
                  collisionVolumeType = Some "Box"
                  damage = Some 1500.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 15.0
                  metal = Some 1130.0
                  object_ = Some "Units/legbunk_dead.s3o"
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
                  metal = Some 450.0
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
                ok = ["mavbok1"]
                select = ["mavbsel1"] }
          customParams = Map.ofList [
                "maxrange", "10"
                "unitgroup", "weapon"
                "model_author", "Johanthan Crimson, Tuerk"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "leggantry"
                "techlevel", "3.0"
                "weapon1turretx", "200.0"
                "weapon1turrety", "200.0"
            ]
          extras = Map.ofList [
                "cantbetransported", "true"
                "nochasecategory", "VTOL"
                "onoffable", "false"
                "strafetoattack", "true"
                "upright", "true"
            ] }

    let legbunkDef : UnitDef =
        { name = "legbunk"
          subfolder = "Legion/T3"
          metalCost = ValueOrExpr.Concrete 1850.0
          energyCost = ValueOrExpr.Concrete 42000.0
          buildTime = ValueOrExpr.Concrete 46430.0
          health = ValueOrExpr.Concrete 9400.0
          sightDistance = ValueOrExpr.Concrete 375.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/legbunk.s3o"
          buildPic = Some "legbunk.dds"
          script = Some "Units/legbunk.cob"
          corpse = Some "DEAD"
          explodeAs = Some "explosiont3"
          selfDestructAs = Some "explosiont3xl"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "55 80 55"
          collisionVolumeType = Some "CYLY"
          seismicSignature = None
          category = Some "BOT MOBILE WEAPON ALL NOTSUB NOTAIR NOTHOVER SURFACE EMPABLE"
          movement = Some (
            { speed = ValueOrExpr.Concrete 82.0
              maxAcc = 0.253
              maxDec = 0.8211
              turnRate = 1214.0
              movementClass = Some "HBOT4"
              maxSlope = Some 17.0
              maxWaterDepth = Some 22.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.518
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "aimhull"
                displayName = "Targeting System"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = Some (ValueOrExpr.Concrete 650.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.1)
                weaponVelocity = Some 360.0
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
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "340.0"
                    "avoidfeature", "false"
                    "canattackground", "true"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "gravityaffected", "true"
                    "hightrajectory", "1.0"
                    "size", "0.0"
                    "soundhitwet", ""
                ] }
              { name = "piledriver"
                displayName = "Hard-Plasma Mining Tool"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "commanders", 500.0
                    "default", 1500.0
                ]
                range = Some (ValueOrExpr.Concrete 150.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.0)
                weaponVelocity = Some 600.0
                areaOfEffect = Some 144.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.8
                impulseFactor = Some 1.0
                noSelfDamage = Some true
                soundStart = Some "packolau"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:barrelshot-large"
                rgbColor = Some "1 0.8 0.17"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "GROUNDSCOUT"
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_fastautoretargeting", "false"
                    "avoidfeature", "false"
                    "cegtag", "gausscannonprojectile"
                    "craterboost", "0.5"
                    "cratermult", "0.5"
                    "damagemodifier", "0.33"
                    "gravityaffected", "false"
                    "impulseboost", "10.0"
                    "intensity", "4.0"
                    "noexplode", "true"
                    "size", "0.0"
                    "soundhitwet", "sizzlexs"
                    "soundstartvolume", "26.0"
                    "soundtrigger", "true"
                    "thickness", "24.0"
                    "waterweapon", "true"
                ] }
              { name = "railgunt2"
                displayName = "Snub-Nose Railgun"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "commanders", 250.0
                    "default", 475.0
                ]
                range = Some (ValueOrExpr.Concrete 650.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.0)
                weaponVelocity = Some 3180.0
                areaOfEffect = Some 32.0
                accuracy = None
                turret = Some true
                tolerance = Some 3000.0
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 1.0
                noSelfDamage = Some true
                soundStart = Some "railgunxl"
                soundHit = Some "mavgun3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "0.34 0.64 0.94"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "GROUNDSCOUT"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "canattackground", "true"
                    "cegtag", "railgun"
                    "collisionSize", "0.667"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "0.0"
                    "duration", "0.12"
                    "energypershot", "250.0"
                    "firestarter", "0.0"
                    "hardstop", "true"
                    "impactonly", "false"
                    "intensity", "0.8"
                    "noexplode", "true"
                    "ownerExpAccWeight", "4.0"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "26.0"
                    "thickness", "3.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "61.6002807617 54.8114776611 71.5794219971"
                collisionVolumeType = Some "Box"
                damage = Some 1500.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 15.0
                metal = Some 1130.0
                object_ = Some "Units/legbunk_dead.s3o"
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
                metal = Some 450.0
                object_ = Some "Units/arm3X3B.s3o"
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
              ok = ["mavbok1"]
              select = ["mavbsel1"] })
          customParams = Map.ofList [
              "maxrange", "10"
              "unitgroup", "weapon"
              "model_author", "Johanthan Crimson, Tuerk"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "leggantry"
              "techlevel", "3.0"
              "weapon1turretx", "200.0"
              "weapon1turrety", "200.0"
          ]
          extras = Map.ofList [
              "cantbetransported", "true"
              "nochasecategory", "VTOL"
              "onoffable", "false"
              "strafetoattack", "true"
              "upright", "true"
          ] }

    let legbunkToFlat (def: UnitDef) : Legbunk =
        { name = def.name
          subfolder = def.subfolder
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
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let legbunkToUnitDef (flat: Legbunk) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
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
              movementClass = Some flat.movementClass
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit
              cruiseAltitude = None
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

    type Legeallterrainmech =
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

    let legeallterrainmech : Legeallterrainmech =
        { name = "legeallterrainmech"
          subfolder = "Legion/T3"
          metalCost = ValueOrExpr.Concrete 3950.0
          energyCost = ValueOrExpr.Concrete 78000.0
          buildTime = ValueOrExpr.Concrete 120250.0
          health = ValueOrExpr.Concrete 9200.0
          sightDistance = ValueOrExpr.Concrete 625.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/legeallterrainmech.s3o"
          buildPic = Some "legeallterrainmech.DDS"
          script = Some "Units/legeallterrainmech.cob"
          corpse = Some "DEAD"
          explodeAs = Some "explosiont3"
          selfDestructAs = Some "explosiont3xl"
          collisionVolumeOffsets = Some "0 -20 0"
          collisionVolumeScales = Some "93 53 75"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 33.0
          maxAcc = 0.02645
          maxDec = 0.345
          turnRate = 265.64999
          movementClass = "HTBOT6"
          maxSlope = 17.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 0.726
          weapons = [
                { name = "plasma_low"
                  displayName = "Heavy Long-Range Cluster Plasma Cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 345.0
                      "lboats", 345.0
                      "subs", 110.0
                      "vtol", 110.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1100.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.3)
                  weaponVelocity = Some 450.0
                  areaOfEffect = Some 120.0
                  accuracy = Some 50.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.4
                  impulseFactor = Some 0.5
                  noSelfDamage = Some true
                  soundStart = Some "cannhvy5"
                  soundHit = Some "xplomed2"
                  explosiongenerator = Some "custom:ministarfire-explosion"
                  rgbColor = Some "0.7 0.7 1.0"
                  customParams = Map.ofList [
                      "cluster_def", "cluster_munition"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "avoidneutral", "true"
                      "avoidfriendly", "false"
                      "cegtag", "starfire_arty"
                      "collidefriendly", "false"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "soundhitwet", "splsmed"
                  ] }
                { name = "plasma_high"
                  displayName = "Heavy Long-Range High-Trajectory Cluster Plasma Cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 345.0
                      "lboats", 345.0
                      "subs", 110.0
                      "vtol", 110.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1100.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.3)
                  weaponVelocity = Some 450.0
                  areaOfEffect = Some 120.0
                  accuracy = Some 50.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.4
                  impulseFactor = Some 0.5
                  noSelfDamage = Some true
                  soundStart = Some "cannhvy5"
                  soundHit = Some "xplomed2"
                  explosiongenerator = Some "custom:ministarfire-explosion"
                  rgbColor = Some "0.7 0.7 1.0"
                  customParams = Map.ofList [
                      "cluster_def", "cluster_munition"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "avoidneutral", "true"
                      "avoidfriendly", "false"
                      "cegtag", "starfire_arty"
                      "collidefriendly", "false"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "hightrajectory", "1.0"
                      "soundhitwet", "splsmed"
                  ] }
                { name = "smart_trajectory_dummy"
                  displayName = "Smart Artillery Targeting System"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 0.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1380.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.6)
                  weaponVelocity = Some 450.0
                  areaOfEffect = Some 120.0
                  accuracy = Some 50.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.4
                  impulseFactor = Some 0.5
                  noSelfDamage = Some true
                  soundStart = Some "cannhvy5"
                  soundHit = Some "xplomed2"
                  explosiongenerator = Some "custom:ministarfire-explosion"
                  rgbColor = Some "0.7 0.7 1.0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "cegtag", "starfire_arty"
                      "collidefriendly", "false"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "soundhitwet", "splsmed"
                  ] }
                { name = "light_antiair_missile"
                  displayName = "Advanced g2a Salvo Missile Launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "vtol", 37.0
                  ]
                  range = Some (ValueOrExpr.Concrete 760.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.0)
                  weaponVelocity = Some 2500.0
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
                      "mount_badtargetcategory", "SURFACE LIGHTAIRSCOUT"
                      "mount_onlytargetcategory", "VTOL"
                      "mount_fastautoretargeting", "true"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "canattackground", "false"
                      "avoidfriendly", "false"
                      "burst", "3.0"
                      "burstrate", "0.005"
                      "collidefriendly", "false"
                      "dance", "150.0"
                      "cegtag", "missiletrailaa"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "72.0"
                      "flighttime", "2.5"
                      "model", "legsmallrocket.s3o"
                      "smoketrail", "true"
                      "smokecolor", "0.95"
                      "smokeperiod", "5.0"
                      "smokesize", "0.5"
                      "smoketime", "5.0"
                      "smokeTrailCastShadow", "false"
                      "castshadow", "false"
                      "soundhitwet", "splshbig"
                      "soundtrigger", "true"
                      "startvelocity", "800.0"
                      "texture1", "null"
                      "texture2", "smoketrailaa"
                      "tracks", "true"
                      "turnrate", "68000.0"
                      "fixedlauncher", "true"
                      "weaponacceleration", "300.0"
                      "weapontimer", "2.0"
                  ] }
                { name = "drone_controller"
                  displayName = "Dual-Unit Heatray-Drone Control Matrix"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 0.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1300.0)
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
                  customParams = Map.ofList [
                      "carried_unit", "legheavydronesmall"
                      "spawns_surface", "LAND"
                      "carrierdeaththroe", "release"
                      "dockingpieces", "32 33"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "craterareaofeffect", "0.0"
                      "collidefriendly", "false"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "hightrajectory", "1.0"
                      "metalpershot", "90.0"
                      "energypershot", "1000.0"
                      "size", "0.0"
                      "soundhitwet", ""
                      "stockpile", "true"
                      "stockpiletime", "8.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -30 0"
                  collisionVolumeScales = Some "93 33 75"
                  collisionVolumeType = Some "Box"
                  damage = Some 3000.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 2028.0
                  object_ = Some "Units/legeallterrainmech_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 3015.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 811.0
                  object_ = Some "Units/arm4X4D.s3o"
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
                ok = ["kbarmmov"]
                select = ["kbarmsel"] }
          customParams = Map.ofList [
                "model_author", "ZephyrSkies (model), Johnathan Crimson, Darth Mikey, Protar (Concept Art)"
                "maxrange", "1300"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/T3"
                "techlevel", "3.0"
                "unitgroup", "weapon"
                "inheritxpratemultiplier", "1.0"
                "childreninheritxp", "DRONE"
                "parentsinheritxp", "DRONE"
                "restrictions_inclusion", "_noair_"
            ]
          extras = Map.ofList [
                "cantbetransported", "true"
                "mass", "3300.0"
                "movestate", "0.0"
                "nochasecategory", "VTOL"
            ] }

    let legeallterrainmechDef : UnitDef =
        { name = "legeallterrainmech"
          subfolder = "Legion/T3"
          metalCost = ValueOrExpr.Concrete 3950.0
          energyCost = ValueOrExpr.Concrete 78000.0
          buildTime = ValueOrExpr.Concrete 120250.0
          health = ValueOrExpr.Concrete 9200.0
          sightDistance = ValueOrExpr.Concrete 625.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/legeallterrainmech.s3o"
          buildPic = Some "legeallterrainmech.DDS"
          script = Some "Units/legeallterrainmech.cob"
          corpse = Some "DEAD"
          explodeAs = Some "explosiont3"
          selfDestructAs = Some "explosiont3xl"
          collisionVolumeOffsets = Some "0 -20 0"
          collisionVolumeScales = Some "93 53 75"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 33.0
              maxAcc = 0.02645
              maxDec = 0.345
              turnRate = 265.64999
              movementClass = Some "HTBOT6"
              maxSlope = Some 17.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 0.726
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "plasma_low"
                displayName = "Heavy Long-Range Cluster Plasma Cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 345.0
                    "lboats", 345.0
                    "subs", 110.0
                    "vtol", 110.0
                ]
                range = Some (ValueOrExpr.Concrete 1100.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.3)
                weaponVelocity = Some 450.0
                areaOfEffect = Some 120.0
                accuracy = Some 50.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.4
                impulseFactor = Some 0.5
                noSelfDamage = Some true
                soundStart = Some "cannhvy5"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:ministarfire-explosion"
                rgbColor = Some "0.7 0.7 1.0"
                customParams = Map.ofList [
                    "cluster_def", "cluster_munition"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "avoidneutral", "true"
                    "avoidfriendly", "false"
                    "cegtag", "starfire_arty"
                    "collidefriendly", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splsmed"
                ] }
              { name = "plasma_high"
                displayName = "Heavy Long-Range High-Trajectory Cluster Plasma Cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 345.0
                    "lboats", 345.0
                    "subs", 110.0
                    "vtol", 110.0
                ]
                range = Some (ValueOrExpr.Concrete 1100.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.3)
                weaponVelocity = Some 450.0
                areaOfEffect = Some 120.0
                accuracy = Some 50.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.4
                impulseFactor = Some 0.5
                noSelfDamage = Some true
                soundStart = Some "cannhvy5"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:ministarfire-explosion"
                rgbColor = Some "0.7 0.7 1.0"
                customParams = Map.ofList [
                    "cluster_def", "cluster_munition"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "avoidneutral", "true"
                    "avoidfriendly", "false"
                    "cegtag", "starfire_arty"
                    "collidefriendly", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "hightrajectory", "1.0"
                    "soundhitwet", "splsmed"
                ] }
              { name = "smart_trajectory_dummy"
                displayName = "Smart Artillery Targeting System"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = Some (ValueOrExpr.Concrete 1380.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.6)
                weaponVelocity = Some 450.0
                areaOfEffect = Some 120.0
                accuracy = Some 50.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.4
                impulseFactor = Some 0.5
                noSelfDamage = Some true
                soundStart = Some "cannhvy5"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:ministarfire-explosion"
                rgbColor = Some "0.7 0.7 1.0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "cegtag", "starfire_arty"
                    "collidefriendly", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splsmed"
                ] }
              { name = "light_antiair_missile"
                displayName = "Advanced g2a Salvo Missile Launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 37.0
                ]
                range = Some (ValueOrExpr.Concrete 760.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.0)
                weaponVelocity = Some 2500.0
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
                    "mount_badtargetcategory", "SURFACE LIGHTAIRSCOUT"
                    "mount_onlytargetcategory", "VTOL"
                    "mount_fastautoretargeting", "true"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "avoidfriendly", "false"
                    "burst", "3.0"
                    "burstrate", "0.005"
                    "collidefriendly", "false"
                    "dance", "150.0"
                    "cegtag", "missiletrailaa"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "72.0"
                    "flighttime", "2.5"
                    "model", "legsmallrocket.s3o"
                    "smoketrail", "true"
                    "smokecolor", "0.95"
                    "smokeperiod", "5.0"
                    "smokesize", "0.5"
                    "smoketime", "5.0"
                    "smokeTrailCastShadow", "false"
                    "castshadow", "false"
                    "soundhitwet", "splshbig"
                    "soundtrigger", "true"
                    "startvelocity", "800.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa"
                    "tracks", "true"
                    "turnrate", "68000.0"
                    "fixedlauncher", "true"
                    "weaponacceleration", "300.0"
                    "weapontimer", "2.0"
                ] }
              { name = "drone_controller"
                displayName = "Dual-Unit Heatray-Drone Control Matrix"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = Some (ValueOrExpr.Concrete 1300.0)
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
                customParams = Map.ofList [
                    "carried_unit", "legheavydronesmall"
                    "spawns_surface", "LAND"
                    "carrierdeaththroe", "release"
                    "dockingpieces", "32 33"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "craterareaofeffect", "0.0"
                    "collidefriendly", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "hightrajectory", "1.0"
                    "metalpershot", "90.0"
                    "energypershot", "1000.0"
                    "size", "0.0"
                    "soundhitwet", ""
                    "stockpile", "true"
                    "stockpiletime", "8.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -30 0"
                collisionVolumeScales = Some "93 33 75"
                collisionVolumeType = Some "Box"
                damage = Some 3000.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 2028.0
                object_ = Some "Units/legeallterrainmech_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 3015.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 811.0
                object_ = Some "Units/arm4X4D.s3o"
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
              ok = ["kbarmmov"]
              select = ["kbarmsel"] })
          customParams = Map.ofList [
              "model_author", "ZephyrSkies (model), Johnathan Crimson, Darth Mikey, Protar (Concept Art)"
              "maxrange", "1300"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/T3"
              "techlevel", "3.0"
              "unitgroup", "weapon"
              "inheritxpratemultiplier", "1.0"
              "childreninheritxp", "DRONE"
              "parentsinheritxp", "DRONE"
              "restrictions_inclusion", "_noair_"
          ]
          extras = Map.ofList [
              "cantbetransported", "true"
              "mass", "3300.0"
              "movestate", "0.0"
              "nochasecategory", "VTOL"
          ] }

    let legeallterrainmechToFlat (def: UnitDef) : Legeallterrainmech =
        { name = def.name
          subfolder = def.subfolder
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
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let legeallterrainmechToUnitDef (flat: Legeallterrainmech) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
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
              movementClass = Some flat.movementClass
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit
              cruiseAltitude = None
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

    type Legeheatraymech =
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
          energyMake: ValueOrExpr<float>
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legeheatraymech : Legeheatraymech =
        { name = "legeheatraymech"
          subfolder = "Legion/T3"
          metalCost = ValueOrExpr.Concrete 23500.0
          energyCost = ValueOrExpr.Concrete 615000.0
          buildTime = ValueOrExpr.Concrete 585250.0
          health = ValueOrExpr.Concrete 110000.0
          sightDistance = ValueOrExpr.Concrete 845.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/legeheatraymech.s3o"
          buildPic = Some "legeheatraymech.DDS"
          script = Some "Units/legeheatraymech.cob"
          corpse = Some "DEAD"
          explodeAs = Some "banthaSelfd"
          selfDestructAs = Some "korgExplosion"
          collisionVolumeOffsets = Some "0 -10 0"
          collisionVolumeScales = Some "98 135 75"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 40.0
          maxAcc = 0.175
          maxDec = 0.75
          turnRate = 360.0
          movementClass = "VBOT6"
          maxSlope = 17.0
          maxWaterDepth = 32.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.089
          energyMake = ValueOrExpr.Concrete 500.0
          weapons = [
                { name = "aimhull"
                  displayName = "Targeting System"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 0.0
                  ]
                  range = Some (ValueOrExpr.Concrete 700.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.5)
                  weaponVelocity = Some 360.0
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
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "hightrajectory", "1.0"
                      "size", "0.0"
                      "soundhitwet", ""
                  ] }
                { name = "heatray1"
                  displayName = "Experimental Thermal Ordnance Generators"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "commanders", 17.0
                      "default", 33.0
                      "vtol", 14.0
                  ]
                  range = Some (ValueOrExpr.Concrete 800.0)
                  reloadTime = Some (ValueOrExpr.Expr ".033")
                  weaponVelocity = None
                  areaOfEffect = Some 90.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "heatray4burn"
                  soundHit = None
                  explosiongenerator = Some "custom:heatray-large"
                  rgbColor = Some "1 0.3 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_fastautoretargeting", "true"
                      "mount_burstControlWhenOutOfArc", "2.0"
                      "avoidfeature", "false"
                      "beamtime", "0.033"
                      "beamttl", "0.033"
                      "camerashake", "0.1"
                      "corethickness", "0.3"
                      "craterareaofeffect", "72.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "17.0"
                      "firestarter", "90.0"
                      "firetolerance", "750.0"
                      "largebeamlaser", "true"
                      "intensity", "5.0"
                      "laserflaresize", "6.5"
                      "predictboost", "0.0"
                      "rgbcolor2", "1 0.8 0.5"
                      "soundhitdry", "flamhit1"
                      "soundhitwet", "sizzle"
                      "scrollspeed", "5.0"
                      "soundstartvolume", "11.0"
                      "soundtrigger", "1.0"
                      "texture3", "largebeam"
                      "thickness", "6.5"
                      "tilelength", "500.0"
                  ] }
                { name = "heatray1"
                  displayName = "Experimental Thermal Ordnance Generators"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "commanders", 17.0
                      "default", 33.0
                      "vtol", 14.0
                  ]
                  range = Some (ValueOrExpr.Concrete 800.0)
                  reloadTime = Some (ValueOrExpr.Expr ".033")
                  weaponVelocity = None
                  areaOfEffect = Some 90.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "heatray4burn"
                  soundHit = None
                  explosiongenerator = Some "custom:heatray-large"
                  rgbColor = Some "1 0.3 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_fastautoretargeting", "true"
                      "mount_burstControlWhenOutOfArc", "2.0"
                      "avoidfeature", "false"
                      "beamtime", "0.033"
                      "beamttl", "0.033"
                      "camerashake", "0.1"
                      "corethickness", "0.3"
                      "craterareaofeffect", "72.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "17.0"
                      "firestarter", "90.0"
                      "firetolerance", "750.0"
                      "largebeamlaser", "true"
                      "intensity", "5.0"
                      "laserflaresize", "6.5"
                      "predictboost", "0.0"
                      "rgbcolor2", "1 0.8 0.5"
                      "soundhitdry", "flamhit1"
                      "soundhitwet", "sizzle"
                      "scrollspeed", "5.0"
                      "soundstartvolume", "11.0"
                      "soundtrigger", "1.0"
                      "texture3", "largebeam"
                      "thickness", "6.5"
                      "tilelength", "500.0"
                  ] }
                { name = "ultraheavyriotcannon"
                  displayName = "Ultra Heavy Riot Autocannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "bombers", 52.0
                      "default", 420.0
                      "fighters", 52.0
                      "subs", 160.0
                      "vtol", 52.0
                  ]
                  range = Some (ValueOrExpr.Concrete 550.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.2)
                  weaponVelocity = Some 750.0
                  areaOfEffect = Some 160.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.9
                  impulseFactor = Some 2.4
                  noSelfDamage = Some true
                  soundStart = Some "krogun1"
                  soundHit = Some "xplonuk2"
                  explosiongenerator = Some "custom:genericshellexplosion-large"
                  rgbColor = Some "1 0.7 0.25"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_fastautoretargeting", "true"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firetolerance", "5000.0"
                      "soundhitwet", "splslrg"
                      "soundhitvolume", "14.0"
                      "soundstartvolume", "13.0"
                      "separation", "2.0"
                      "nogap", "false"
                      "size", "9.0"
                      "sizeDecay", "0.06"
                      "stages", "9.0"
                      "alphaDecay", "0.1"
                  ] }
                { name = "ultraheavyriotcannon"
                  displayName = "Ultra Heavy Riot Autocannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "bombers", 52.0
                      "default", 420.0
                      "fighters", 52.0
                      "subs", 160.0
                      "vtol", 52.0
                  ]
                  range = Some (ValueOrExpr.Concrete 550.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.2)
                  weaponVelocity = Some 750.0
                  areaOfEffect = Some 160.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.9
                  impulseFactor = Some 2.4
                  noSelfDamage = Some true
                  soundStart = Some "krogun1"
                  soundHit = Some "xplonuk2"
                  explosiongenerator = Some "custom:genericshellexplosion-large"
                  rgbColor = Some "1 0.7 0.25"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_fastautoretargeting", "true"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firetolerance", "5000.0"
                      "soundhitwet", "splslrg"
                      "soundhitvolume", "14.0"
                      "soundstartvolume", "13.0"
                      "separation", "2.0"
                      "nogap", "false"
                      "size", "9.0"
                      "sizeDecay", "0.06"
                      "stages", "9.0"
                      "alphaDecay", "0.1"
                  ] }
                { name = "legflak_gun"
                  displayName = "Anti-Air Flak Cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "vtol", 190.0
                  ]
                  range = Some (ValueOrExpr.Concrete 700.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.8)
                  weaponVelocity = Some 1600.0
                  areaOfEffect = Some 150.0
                  accuracy = Some 1000.0
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "flakfire"
                  soundHit = Some "flakhit2"
                  explosiongenerator = Some "custom:flak"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "NOTAIR LIGHTAIRSCOUT"
                      "mount_onlytargetcategory", "VTOL"
                      "sprayangle", "200.0"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "burnblow", "true"
                      "canattackground", "false"
                      "projectiles", "2.0"
                      "cegtag", "flaktrailaa"
                      "collidefriendly", "false"
                      "craterareaofeffect", "192.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "gravityaffected", "true"
                      "mygravity", "0.01"
                      "predictboost", "1.0"
                      "soundhitwet", "splslrg"
                      "soundhitvolume", "7.5"
                      "soundstartvolume", "9.0"
                      "stages", "0.0"
                      "weapontimer", "1.0"
                  ] }
                { name = "bigfootstep"
                  displayName = "Footsteps"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 0.0
                  ]
                  range = Some (ValueOrExpr.Concrete 0.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.5)
                  weaponVelocity = None
                  areaOfEffect = Some 128.0
                  accuracy = None
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.0
                  impulseFactor = None
                  noSelfDamage = Some true
                  soundStart = None
                  soundHit = Some "banthstep"
                  explosiongenerator = Some "custom:footstep-huge"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "avoidfeature", "false"
                      "camerashake", "300.0"
                      "canattackground", "false"
                      "collidefriendly", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "impactonly", "1.0"
                      "soundhitvolume", "35.0"
                      "soundhitwet", "splssml"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 10"
                  collisionVolumeScales = Some "85 50 120"
                  collisionVolumeType = Some "box"
                  damage = Some 57600.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 17668.0
                  object_ = Some "Units/legeheatraymech_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 28800.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 15067.0
                  object_ = Some "Units/cor4X4A.s3o"
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
                ok = ["krogok1"]
                select = ["krogsel1"] }
          customParams = Map.ofList [
                "maxrange", "450"
                "paralyzemultiplier", "0.0"
                "model_author", "Protar & ZephyrSkies"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/T3"
                "techlevel", "3.0"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "cantbetransported", "true"
                "mass", "27000.0"
                "nochasecategory", "VTOL GROUNDSCOUT"
                "selfdestructcountdown", "10.0"
                "upright", "true"
            ] }

    let legeheatraymechDef : UnitDef =
        { name = "legeheatraymech"
          subfolder = "Legion/T3"
          metalCost = ValueOrExpr.Concrete 23500.0
          energyCost = ValueOrExpr.Concrete 615000.0
          buildTime = ValueOrExpr.Concrete 585250.0
          health = ValueOrExpr.Concrete 110000.0
          sightDistance = ValueOrExpr.Concrete 845.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/legeheatraymech.s3o"
          buildPic = Some "legeheatraymech.DDS"
          script = Some "Units/legeheatraymech.cob"
          corpse = Some "DEAD"
          explodeAs = Some "banthaSelfd"
          selfDestructAs = Some "korgExplosion"
          collisionVolumeOffsets = Some "0 -10 0"
          collisionVolumeScales = Some "98 135 75"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 40.0
              maxAcc = 0.175
              maxDec = 0.75
              turnRate = 360.0
              movementClass = Some "VBOT6"
              maxSlope = Some 17.0
              maxWaterDepth = Some 32.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.089
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "aimhull"
                displayName = "Targeting System"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = Some (ValueOrExpr.Concrete 700.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.5)
                weaponVelocity = Some 360.0
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
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "hightrajectory", "1.0"
                    "size", "0.0"
                    "soundhitwet", ""
                ] }
              { name = "heatray1"
                displayName = "Experimental Thermal Ordnance Generators"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 17.0
                    "default", 33.0
                    "vtol", 14.0
                ]
                range = Some (ValueOrExpr.Concrete 800.0)
                reloadTime = Some (ValueOrExpr.Expr ".033")
                weaponVelocity = None
                areaOfEffect = Some 90.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "heatray4burn"
                soundHit = None
                explosiongenerator = Some "custom:heatray-large"
                rgbColor = Some "1 0.3 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_fastautoretargeting", "true"
                    "mount_burstControlWhenOutOfArc", "2.0"
                    "avoidfeature", "false"
                    "beamtime", "0.033"
                    "beamttl", "0.033"
                    "camerashake", "0.1"
                    "corethickness", "0.3"
                    "craterareaofeffect", "72.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "17.0"
                    "firestarter", "90.0"
                    "firetolerance", "750.0"
                    "largebeamlaser", "true"
                    "intensity", "5.0"
                    "laserflaresize", "6.5"
                    "predictboost", "0.0"
                    "rgbcolor2", "1 0.8 0.5"
                    "soundhitdry", "flamhit1"
                    "soundhitwet", "sizzle"
                    "scrollspeed", "5.0"
                    "soundstartvolume", "11.0"
                    "soundtrigger", "1.0"
                    "texture3", "largebeam"
                    "thickness", "6.5"
                    "tilelength", "500.0"
                ] }
              { name = "heatray1"
                displayName = "Experimental Thermal Ordnance Generators"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 17.0
                    "default", 33.0
                    "vtol", 14.0
                ]
                range = Some (ValueOrExpr.Concrete 800.0)
                reloadTime = Some (ValueOrExpr.Expr ".033")
                weaponVelocity = None
                areaOfEffect = Some 90.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "heatray4burn"
                soundHit = None
                explosiongenerator = Some "custom:heatray-large"
                rgbColor = Some "1 0.3 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_fastautoretargeting", "true"
                    "mount_burstControlWhenOutOfArc", "2.0"
                    "avoidfeature", "false"
                    "beamtime", "0.033"
                    "beamttl", "0.033"
                    "camerashake", "0.1"
                    "corethickness", "0.3"
                    "craterareaofeffect", "72.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "17.0"
                    "firestarter", "90.0"
                    "firetolerance", "750.0"
                    "largebeamlaser", "true"
                    "intensity", "5.0"
                    "laserflaresize", "6.5"
                    "predictboost", "0.0"
                    "rgbcolor2", "1 0.8 0.5"
                    "soundhitdry", "flamhit1"
                    "soundhitwet", "sizzle"
                    "scrollspeed", "5.0"
                    "soundstartvolume", "11.0"
                    "soundtrigger", "1.0"
                    "texture3", "largebeam"
                    "thickness", "6.5"
                    "tilelength", "500.0"
                ] }
              { name = "ultraheavyriotcannon"
                displayName = "Ultra Heavy Riot Autocannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "bombers", 52.0
                    "default", 420.0
                    "fighters", 52.0
                    "subs", 160.0
                    "vtol", 52.0
                ]
                range = Some (ValueOrExpr.Concrete 550.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.2)
                weaponVelocity = Some 750.0
                areaOfEffect = Some 160.0
                accuracy = None
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.9
                impulseFactor = Some 2.4
                noSelfDamage = Some true
                soundStart = Some "krogun1"
                soundHit = Some "xplonuk2"
                explosiongenerator = Some "custom:genericshellexplosion-large"
                rgbColor = Some "1 0.7 0.25"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_fastautoretargeting", "true"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firetolerance", "5000.0"
                    "soundhitwet", "splslrg"
                    "soundhitvolume", "14.0"
                    "soundstartvolume", "13.0"
                    "separation", "2.0"
                    "nogap", "false"
                    "size", "9.0"
                    "sizeDecay", "0.06"
                    "stages", "9.0"
                    "alphaDecay", "0.1"
                ] }
              { name = "ultraheavyriotcannon"
                displayName = "Ultra Heavy Riot Autocannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "bombers", 52.0
                    "default", 420.0
                    "fighters", 52.0
                    "subs", 160.0
                    "vtol", 52.0
                ]
                range = Some (ValueOrExpr.Concrete 550.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.2)
                weaponVelocity = Some 750.0
                areaOfEffect = Some 160.0
                accuracy = None
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.9
                impulseFactor = Some 2.4
                noSelfDamage = Some true
                soundStart = Some "krogun1"
                soundHit = Some "xplonuk2"
                explosiongenerator = Some "custom:genericshellexplosion-large"
                rgbColor = Some "1 0.7 0.25"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_fastautoretargeting", "true"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firetolerance", "5000.0"
                    "soundhitwet", "splslrg"
                    "soundhitvolume", "14.0"
                    "soundstartvolume", "13.0"
                    "separation", "2.0"
                    "nogap", "false"
                    "size", "9.0"
                    "sizeDecay", "0.06"
                    "stages", "9.0"
                    "alphaDecay", "0.1"
                ] }
              { name = "legflak_gun"
                displayName = "Anti-Air Flak Cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "vtol", 190.0
                ]
                range = Some (ValueOrExpr.Concrete 700.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.8)
                weaponVelocity = Some 1600.0
                areaOfEffect = Some 150.0
                accuracy = Some 1000.0
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 1.0
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "flakfire"
                soundHit = Some "flakhit2"
                explosiongenerator = Some "custom:flak"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR LIGHTAIRSCOUT"
                    "mount_onlytargetcategory", "VTOL"
                    "sprayangle", "200.0"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "projectiles", "2.0"
                    "cegtag", "flaktrailaa"
                    "collidefriendly", "false"
                    "craterareaofeffect", "192.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "gravityaffected", "true"
                    "mygravity", "0.01"
                    "predictboost", "1.0"
                    "soundhitwet", "splslrg"
                    "soundhitvolume", "7.5"
                    "soundstartvolume", "9.0"
                    "stages", "0.0"
                    "weapontimer", "1.0"
                ] }
              { name = "bigfootstep"
                displayName = "Footsteps"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = Some (ValueOrExpr.Concrete 0.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.5)
                weaponVelocity = None
                areaOfEffect = Some 128.0
                accuracy = None
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.0
                impulseFactor = None
                noSelfDamage = Some true
                soundStart = None
                soundHit = Some "banthstep"
                explosiongenerator = Some "custom:footstep-huge"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "avoidfeature", "false"
                    "camerashake", "300.0"
                    "canattackground", "false"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "impactonly", "1.0"
                    "soundhitvolume", "35.0"
                    "soundhitwet", "splssml"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 500.0)
              metalMake = None
              energyStorage = None
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 10"
                collisionVolumeScales = Some "85 50 120"
                collisionVolumeType = Some "box"
                damage = Some 57600.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 17668.0
                object_ = Some "Units/legeheatraymech_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 28800.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 15067.0
                object_ = Some "Units/cor4X4A.s3o"
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
              ok = ["krogok1"]
              select = ["krogsel1"] })
          customParams = Map.ofList [
              "maxrange", "450"
              "paralyzemultiplier", "0.0"
              "model_author", "Protar & ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/T3"
              "techlevel", "3.0"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "cantbetransported", "true"
              "mass", "27000.0"
              "nochasecategory", "VTOL GROUNDSCOUT"
              "selfdestructcountdown", "10.0"
              "upright", "true"
          ] }

    let legeheatraymechToFlat (def: UnitDef) : Legeheatraymech =
        { name = def.name
          subfolder = def.subfolder
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
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          energyMake = def.economy.Value.energyMake.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let legeheatraymechToUnitDef (flat: Legeheatraymech) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
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
              movementClass = Some flat.movementClass
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = None
          weapons = Some flat.weapons
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = None
              energyStorage = None
              metalStorage = None
              extractsMetal = None
            }
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Legeheatraymech_old =
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
          energyMake: ValueOrExpr<float>
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legeheatraymech_old : Legeheatraymech_old =
        { name = "legeheatraymech_old"
          subfolder = "Legion/T3"
          metalCost = ValueOrExpr.Concrete 27000.0
          energyCost = ValueOrExpr.Concrete 705000.0
          buildTime = ValueOrExpr.Concrete 666250.0
          health = ValueOrExpr.Concrete 110000.0
          sightDistance = ValueOrExpr.Concrete 850.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/legeheatraymech_old.s3o"
          buildPic = Some "legeheatraymech_old.DDS"
          script = Some "Units/legeheatraymech_old.cob"
          corpse = Some "DEAD"
          explodeAs = Some "banthaSelfd"
          selfDestructAs = Some "korgExplosion"
          collisionVolumeOffsets = Some "0 -10 0"
          collisionVolumeScales = Some "98 135 75"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 40.0
          maxAcc = 0.175
          maxDec = 0.75
          turnRate = 360.0
          movementClass = "VBOT6"
          maxSlope = 17.0
          maxWaterDepth = 32.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.089
          energyMake = ValueOrExpr.Concrete 1000.0
          weapons = [
                { name = "aimhull"
                  displayName = "Targeting System"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 0.0
                  ]
                  range = Some (ValueOrExpr.Concrete 750.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.5)
                  weaponVelocity = Some 360.0
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
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "hightrajectory", "1.0"
                      "size", "0.0"
                      "soundhitwet", ""
                  ] }
                { name = "heatray1"
                  displayName = "Experimental Thermal Ordnance Generators"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "commanders", 17.0
                      "default", 33.0
                      "vtol", 14.0
                  ]
                  range = Some (ValueOrExpr.Concrete 800.0)
                  reloadTime = Some (ValueOrExpr.Expr ".033")
                  weaponVelocity = None
                  areaOfEffect = Some 90.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "heatray4burn"
                  soundHit = None
                  explosiongenerator = Some "custom:heatray-large"
                  rgbColor = Some "1 0.3 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_fastautoretargeting", "true"
                      "mount_burstControlWhenOutOfArc", "2.0"
                      "avoidfeature", "false"
                      "beamtime", "0.033"
                      "beamttl", "0.033"
                      "camerashake", "0.1"
                      "corethickness", "0.3"
                      "craterareaofeffect", "72.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "17.0"
                      "firestarter", "90.0"
                      "firetolerance", "750.0"
                      "largebeamlaser", "true"
                      "intensity", "5.0"
                      "laserflaresize", "6.5"
                      "predictboost", "0.0"
                      "rgbcolor2", "1 0.8 0.5"
                      "soundhitdry", "flamhit1"
                      "soundhitwet", "sizzle"
                      "scrollspeed", "5.0"
                      "soundstartvolume", "11.0"
                      "soundtrigger", "1.0"
                      "texture3", "largebeam"
                      "thickness", "6.5"
                      "tilelength", "500.0"
                  ] }
                { name = "heatray1"
                  displayName = "Experimental Thermal Ordnance Generators"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "commanders", 17.0
                      "default", 33.0
                      "vtol", 14.0
                  ]
                  range = Some (ValueOrExpr.Concrete 800.0)
                  reloadTime = Some (ValueOrExpr.Expr ".033")
                  weaponVelocity = None
                  areaOfEffect = Some 90.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "heatray4burn"
                  soundHit = None
                  explosiongenerator = Some "custom:heatray-large"
                  rgbColor = Some "1 0.3 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_fastautoretargeting", "true"
                      "mount_burstControlWhenOutOfArc", "2.0"
                      "avoidfeature", "false"
                      "beamtime", "0.033"
                      "beamttl", "0.033"
                      "camerashake", "0.1"
                      "corethickness", "0.3"
                      "craterareaofeffect", "72.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "17.0"
                      "firestarter", "90.0"
                      "firetolerance", "750.0"
                      "largebeamlaser", "true"
                      "intensity", "5.0"
                      "laserflaresize", "6.5"
                      "predictboost", "0.0"
                      "rgbcolor2", "1 0.8 0.5"
                      "soundhitdry", "flamhit1"
                      "soundhitwet", "sizzle"
                      "scrollspeed", "5.0"
                      "soundstartvolume", "11.0"
                      "soundtrigger", "1.0"
                      "texture3", "largebeam"
                      "thickness", "6.5"
                      "tilelength", "500.0"
                  ] }
                { name = "heatray1"
                  displayName = "Experimental Thermal Ordnance Generators"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "commanders", 17.0
                      "default", 33.0
                      "vtol", 14.0
                  ]
                  range = Some (ValueOrExpr.Concrete 800.0)
                  reloadTime = Some (ValueOrExpr.Expr ".033")
                  weaponVelocity = None
                  areaOfEffect = Some 90.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "heatray4burn"
                  soundHit = None
                  explosiongenerator = Some "custom:heatray-large"
                  rgbColor = Some "1 0.3 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_fastautoretargeting", "true"
                      "mount_burstControlWhenOutOfArc", "2.0"
                      "avoidfeature", "false"
                      "beamtime", "0.033"
                      "beamttl", "0.033"
                      "camerashake", "0.1"
                      "corethickness", "0.3"
                      "craterareaofeffect", "72.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "17.0"
                      "firestarter", "90.0"
                      "firetolerance", "750.0"
                      "largebeamlaser", "true"
                      "intensity", "5.0"
                      "laserflaresize", "6.5"
                      "predictboost", "0.0"
                      "rgbcolor2", "1 0.8 0.5"
                      "soundhitdry", "flamhit1"
                      "soundhitwet", "sizzle"
                      "scrollspeed", "5.0"
                      "soundstartvolume", "11.0"
                      "soundtrigger", "1.0"
                      "texture3", "largebeam"
                      "thickness", "6.5"
                      "tilelength", "500.0"
                  ] }
                { name = "heatray1"
                  displayName = "Experimental Thermal Ordnance Generators"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "commanders", 17.0
                      "default", 33.0
                      "vtol", 14.0
                  ]
                  range = Some (ValueOrExpr.Concrete 800.0)
                  reloadTime = Some (ValueOrExpr.Expr ".033")
                  weaponVelocity = None
                  areaOfEffect = Some 90.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "heatray4burn"
                  soundHit = None
                  explosiongenerator = Some "custom:heatray-large"
                  rgbColor = Some "1 0.3 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_fastautoretargeting", "true"
                      "mount_burstControlWhenOutOfArc", "2.0"
                      "avoidfeature", "false"
                      "beamtime", "0.033"
                      "beamttl", "0.033"
                      "camerashake", "0.1"
                      "corethickness", "0.3"
                      "craterareaofeffect", "72.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "17.0"
                      "firestarter", "90.0"
                      "firetolerance", "750.0"
                      "largebeamlaser", "true"
                      "intensity", "5.0"
                      "laserflaresize", "6.5"
                      "predictboost", "0.0"
                      "rgbcolor2", "1 0.8 0.5"
                      "soundhitdry", "flamhit1"
                      "soundhitwet", "sizzle"
                      "scrollspeed", "5.0"
                      "soundstartvolume", "11.0"
                      "soundtrigger", "1.0"
                      "texture3", "largebeam"
                      "thickness", "6.5"
                      "tilelength", "500.0"
                  ] }
                { name = "legflak_gun"
                  displayName = "Anti-Air Flak Cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "vtol", 190.0
                  ]
                  range = Some (ValueOrExpr.Concrete 700.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.9)
                  weaponVelocity = Some 1600.0
                  areaOfEffect = Some 150.0
                  accuracy = Some 1000.0
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "flakfire"
                  soundHit = Some "flakhit2"
                  explosiongenerator = Some "custom:flak"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "NOTAIR LIGHTAIRSCOUT"
                      "mount_onlytargetcategory", "VTOL"
                      "sprayangle", "200.0"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "burnblow", "true"
                      "canattackground", "false"
                      "cegtag", "flaktrailaa"
                      "collidefriendly", "false"
                      "craterareaofeffect", "192.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "gravityaffected", "true"
                      "mygravity", "0.01"
                      "predictboost", "1.0"
                      "soundhitwet", "splslrg"
                      "soundhitvolume", "7.5"
                      "soundstartvolume", "9.0"
                      "stages", "0.0"
                      "weapontimer", "1.0"
                  ] }
                { name = "bigfootstep"
                  displayName = "Footsteps"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 0.0
                  ]
                  range = Some (ValueOrExpr.Concrete 0.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.5)
                  weaponVelocity = None
                  areaOfEffect = Some 128.0
                  accuracy = None
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.0
                  impulseFactor = None
                  noSelfDamage = Some true
                  soundStart = None
                  soundHit = Some "banthstep"
                  explosiongenerator = Some "custom:footstep-huge"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "avoidfeature", "false"
                      "camerashake", "300.0"
                      "canattackground", "false"
                      "collidefriendly", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "impactonly", "1.0"
                      "soundhitvolume", "35.0"
                      "soundhitwet", "splssml"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -5 0"
                  collisionVolumeScales = Some "110 45 130"
                  collisionVolumeType = Some "box"
                  damage = Some 57600.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 17668.0
                  object_ = Some "Units/legeheatraymech_old_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 28800.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 15067.0
                  object_ = Some "Units/cor4X4A.s3o"
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
                ok = ["krogok1"]
                select = ["krogsel1"] }
          customParams = Map.ofList [
                "maxrange", "650"
                "paralyzemultiplier", "0.0"
                "model_author", "Protar & ZephyrSkies"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/T3"
                "techlevel", "3.0"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "cantbetransported", "true"
                "mass", "27000.0"
                "nochasecategory", "VTOL GROUNDSCOUT"
                "selfdestructcountdown", "10.0"
                "upright", "true"
            ] }

    let legeheatraymech_oldDef : UnitDef =
        { name = "legeheatraymech_old"
          subfolder = "Legion/T3"
          metalCost = ValueOrExpr.Concrete 27000.0
          energyCost = ValueOrExpr.Concrete 705000.0
          buildTime = ValueOrExpr.Concrete 666250.0
          health = ValueOrExpr.Concrete 110000.0
          sightDistance = ValueOrExpr.Concrete 850.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/legeheatraymech_old.s3o"
          buildPic = Some "legeheatraymech_old.DDS"
          script = Some "Units/legeheatraymech_old.cob"
          corpse = Some "DEAD"
          explodeAs = Some "banthaSelfd"
          selfDestructAs = Some "korgExplosion"
          collisionVolumeOffsets = Some "0 -10 0"
          collisionVolumeScales = Some "98 135 75"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 40.0
              maxAcc = 0.175
              maxDec = 0.75
              turnRate = 360.0
              movementClass = Some "VBOT6"
              maxSlope = Some 17.0
              maxWaterDepth = Some 32.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.089
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "aimhull"
                displayName = "Targeting System"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = Some (ValueOrExpr.Concrete 750.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.5)
                weaponVelocity = Some 360.0
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
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "hightrajectory", "1.0"
                    "size", "0.0"
                    "soundhitwet", ""
                ] }
              { name = "heatray1"
                displayName = "Experimental Thermal Ordnance Generators"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 17.0
                    "default", 33.0
                    "vtol", 14.0
                ]
                range = Some (ValueOrExpr.Concrete 800.0)
                reloadTime = Some (ValueOrExpr.Expr ".033")
                weaponVelocity = None
                areaOfEffect = Some 90.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "heatray4burn"
                soundHit = None
                explosiongenerator = Some "custom:heatray-large"
                rgbColor = Some "1 0.3 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_fastautoretargeting", "true"
                    "mount_burstControlWhenOutOfArc", "2.0"
                    "avoidfeature", "false"
                    "beamtime", "0.033"
                    "beamttl", "0.033"
                    "camerashake", "0.1"
                    "corethickness", "0.3"
                    "craterareaofeffect", "72.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "17.0"
                    "firestarter", "90.0"
                    "firetolerance", "750.0"
                    "largebeamlaser", "true"
                    "intensity", "5.0"
                    "laserflaresize", "6.5"
                    "predictboost", "0.0"
                    "rgbcolor2", "1 0.8 0.5"
                    "soundhitdry", "flamhit1"
                    "soundhitwet", "sizzle"
                    "scrollspeed", "5.0"
                    "soundstartvolume", "11.0"
                    "soundtrigger", "1.0"
                    "texture3", "largebeam"
                    "thickness", "6.5"
                    "tilelength", "500.0"
                ] }
              { name = "heatray1"
                displayName = "Experimental Thermal Ordnance Generators"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 17.0
                    "default", 33.0
                    "vtol", 14.0
                ]
                range = Some (ValueOrExpr.Concrete 800.0)
                reloadTime = Some (ValueOrExpr.Expr ".033")
                weaponVelocity = None
                areaOfEffect = Some 90.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "heatray4burn"
                soundHit = None
                explosiongenerator = Some "custom:heatray-large"
                rgbColor = Some "1 0.3 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_fastautoretargeting", "true"
                    "mount_burstControlWhenOutOfArc", "2.0"
                    "avoidfeature", "false"
                    "beamtime", "0.033"
                    "beamttl", "0.033"
                    "camerashake", "0.1"
                    "corethickness", "0.3"
                    "craterareaofeffect", "72.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "17.0"
                    "firestarter", "90.0"
                    "firetolerance", "750.0"
                    "largebeamlaser", "true"
                    "intensity", "5.0"
                    "laserflaresize", "6.5"
                    "predictboost", "0.0"
                    "rgbcolor2", "1 0.8 0.5"
                    "soundhitdry", "flamhit1"
                    "soundhitwet", "sizzle"
                    "scrollspeed", "5.0"
                    "soundstartvolume", "11.0"
                    "soundtrigger", "1.0"
                    "texture3", "largebeam"
                    "thickness", "6.5"
                    "tilelength", "500.0"
                ] }
              { name = "heatray1"
                displayName = "Experimental Thermal Ordnance Generators"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 17.0
                    "default", 33.0
                    "vtol", 14.0
                ]
                range = Some (ValueOrExpr.Concrete 800.0)
                reloadTime = Some (ValueOrExpr.Expr ".033")
                weaponVelocity = None
                areaOfEffect = Some 90.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "heatray4burn"
                soundHit = None
                explosiongenerator = Some "custom:heatray-large"
                rgbColor = Some "1 0.3 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_fastautoretargeting", "true"
                    "mount_burstControlWhenOutOfArc", "2.0"
                    "avoidfeature", "false"
                    "beamtime", "0.033"
                    "beamttl", "0.033"
                    "camerashake", "0.1"
                    "corethickness", "0.3"
                    "craterareaofeffect", "72.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "17.0"
                    "firestarter", "90.0"
                    "firetolerance", "750.0"
                    "largebeamlaser", "true"
                    "intensity", "5.0"
                    "laserflaresize", "6.5"
                    "predictboost", "0.0"
                    "rgbcolor2", "1 0.8 0.5"
                    "soundhitdry", "flamhit1"
                    "soundhitwet", "sizzle"
                    "scrollspeed", "5.0"
                    "soundstartvolume", "11.0"
                    "soundtrigger", "1.0"
                    "texture3", "largebeam"
                    "thickness", "6.5"
                    "tilelength", "500.0"
                ] }
              { name = "heatray1"
                displayName = "Experimental Thermal Ordnance Generators"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 17.0
                    "default", 33.0
                    "vtol", 14.0
                ]
                range = Some (ValueOrExpr.Concrete 800.0)
                reloadTime = Some (ValueOrExpr.Expr ".033")
                weaponVelocity = None
                areaOfEffect = Some 90.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "heatray4burn"
                soundHit = None
                explosiongenerator = Some "custom:heatray-large"
                rgbColor = Some "1 0.3 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_fastautoretargeting", "true"
                    "mount_burstControlWhenOutOfArc", "2.0"
                    "avoidfeature", "false"
                    "beamtime", "0.033"
                    "beamttl", "0.033"
                    "camerashake", "0.1"
                    "corethickness", "0.3"
                    "craterareaofeffect", "72.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "17.0"
                    "firestarter", "90.0"
                    "firetolerance", "750.0"
                    "largebeamlaser", "true"
                    "intensity", "5.0"
                    "laserflaresize", "6.5"
                    "predictboost", "0.0"
                    "rgbcolor2", "1 0.8 0.5"
                    "soundhitdry", "flamhit1"
                    "soundhitwet", "sizzle"
                    "scrollspeed", "5.0"
                    "soundstartvolume", "11.0"
                    "soundtrigger", "1.0"
                    "texture3", "largebeam"
                    "thickness", "6.5"
                    "tilelength", "500.0"
                ] }
              { name = "legflak_gun"
                displayName = "Anti-Air Flak Cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "vtol", 190.0
                ]
                range = Some (ValueOrExpr.Concrete 700.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.9)
                weaponVelocity = Some 1600.0
                areaOfEffect = Some 150.0
                accuracy = Some 1000.0
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 1.0
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "flakfire"
                soundHit = Some "flakhit2"
                explosiongenerator = Some "custom:flak"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR LIGHTAIRSCOUT"
                    "mount_onlytargetcategory", "VTOL"
                    "sprayangle", "200.0"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "cegtag", "flaktrailaa"
                    "collidefriendly", "false"
                    "craterareaofeffect", "192.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "gravityaffected", "true"
                    "mygravity", "0.01"
                    "predictboost", "1.0"
                    "soundhitwet", "splslrg"
                    "soundhitvolume", "7.5"
                    "soundstartvolume", "9.0"
                    "stages", "0.0"
                    "weapontimer", "1.0"
                ] }
              { name = "bigfootstep"
                displayName = "Footsteps"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = Some (ValueOrExpr.Concrete 0.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.5)
                weaponVelocity = None
                areaOfEffect = Some 128.0
                accuracy = None
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.0
                impulseFactor = None
                noSelfDamage = Some true
                soundStart = None
                soundHit = Some "banthstep"
                explosiongenerator = Some "custom:footstep-huge"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "avoidfeature", "false"
                    "camerashake", "300.0"
                    "canattackground", "false"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "impactonly", "1.0"
                    "soundhitvolume", "35.0"
                    "soundhitwet", "splssml"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 1000.0)
              metalMake = None
              energyStorage = None
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -5 0"
                collisionVolumeScales = Some "110 45 130"
                collisionVolumeType = Some "box"
                damage = Some 57600.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 17668.0
                object_ = Some "Units/legeheatraymech_old_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 28800.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 15067.0
                object_ = Some "Units/cor4X4A.s3o"
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
              ok = ["krogok1"]
              select = ["krogsel1"] })
          customParams = Map.ofList [
              "maxrange", "650"
              "paralyzemultiplier", "0.0"
              "model_author", "Protar & ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/T3"
              "techlevel", "3.0"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "cantbetransported", "true"
              "mass", "27000.0"
              "nochasecategory", "VTOL GROUNDSCOUT"
              "selfdestructcountdown", "10.0"
              "upright", "true"
          ] }

    let legeheatraymech_oldToFlat (def: UnitDef) : Legeheatraymech_old =
        { name = def.name
          subfolder = def.subfolder
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
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          energyMake = def.economy.Value.energyMake.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let legeheatraymech_oldToUnitDef (flat: Legeheatraymech_old) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
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
              movementClass = Some flat.movementClass
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = None
          weapons = Some flat.weapons
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = None
              energyStorage = None
              metalStorage = None
              extractsMetal = None
            }
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Legehovertank =
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

    let legehovertank : Legehovertank =
        { name = "legehovertank"
          subfolder = "Legion/T3"
          metalCost = ValueOrExpr.Concrete 1350.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 41600.0
          health = ValueOrExpr.Concrete 4900.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/legehovertank.s3o"
          buildPic = Some "legehovertank.DDS"
          script = Some "Units/legehovertank.cob"
          corpse = Some "dead"
          explodeAs = Some "largeexplosiongeneric"
          selfDestructAs = Some "largeExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -15 0"
          collisionVolumeScales = Some "63 32 63"
          collisionVolumeType = Some "cylY"
          seismicSignature = None
          category = None
          speed = ValueOrExpr.Concrete 63.0
          maxAcc = 0.022
          maxDec = 0.022
          turnRate = 300.0
          movementClass = "HHOVER4"
          maxSlope = 16.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.122
          weapons = [
                { name = "heat_ray"
                  displayName = "Heavy Sweepfire Heatray"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 25.0
                      "vtol", 7.0
                  ]
                  range = Some (ValueOrExpr.Concrete 425.0)
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
                { name = "depthcharge"
                  displayName = "Depthcharge Launcher"
                  weaponType = Some "TorpedoLauncher"
                  damage = Map.ofList [
                      "default", 225.0
                  ]
                  range = Some (ValueOrExpr.Concrete 400.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.0)
                  weaponVelocity = Some 140.0
                  areaOfEffect = Some 24.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 1000.0
                  edgeEffectiveness = Some 0.9
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "torpedo1"
                  soundHit = Some "xplodep2"
                  explosiongenerator = Some "custom:genericshellexplosion-medium-uw"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "NOTSUB"
                      "mount_maindir", "0 -1 0"
                      "mount_maxangledif", "180.0"
                      "mount_onlytargetcategory", "CANBEUW UNDERWATER"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "collidefriendly", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "flighttime", "3.0"
                      "model", "legbasictorpedo.s3o"
                      "predictboost", "0.0"
                      "startvelocity", "120.0"
                      "tracks", "true"
                      "turnrate", "6000.0"
                      "waterweapon", "true"
                      "weaponacceleration", "20.0"
                      "weapontimer", "3.0"
                  ] }
                { name = "parabolic_rockets"
                  displayName = "Parabolic Trajectory Multi-Rocket Launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "default", 100.0
                      "subs", 50.0
                  ]
                  range = Some (ValueOrExpr.Concrete 500.0)
                  reloadTime = Some (ValueOrExpr.Concrete 6.0)
                  weaponVelocity = Some 650.0
                  areaOfEffect = Some 100.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.65
                  impulseFactor = Some 0.6
                  noSelfDamage = Some true
                  soundStart = Some "rocksalvo"
                  soundHit = Some "rockhit"
                  explosiongenerator = Some "custom:genericshellexplosion-catapult"
                  rgbColor = None
                  customParams = Map.ofList [
                      "projectile_destruction_method", "descend"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "90.0"
                      "avoidfeature", "false"
                      "burst", "3.0"
                      "burstrate", "0.3"
                      "castshadow", "true"
                      "cegtag", "missiletrailsmall-simple"
                      "collidefriendly", "false"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "dance", "48.0"
                      "firestarter", "70.0"
                      "flighttime", "2.0"
                      "model", "legsmallrocket.s3o"
                      "proximitypriority", "-1.0"
                      "smokecolor", "0.5"
                      "smokeperiod", "7.0"
                      "smokesize", "6.5"
                      "smoketime", "21.0"
                      "smoketrail", "true"
                      "smoketrailcastshadow", "false"
                      "soundhitwet", "splssml"
                      "soundtrigger", "true"
                      "startvelocity", "185.0"
                      "targetmoveerror", "0.2"
                      "texture1", "null"
                      "texture2", "smoketrailbar"
                      "trajectoryheight", "0.5"
                      "turnrate", "8500.0"
                      "weaponacceleration", "100.0"
                      "weapontimer", "0.75"
                      "wobble", "12000.0"
                      "trajectoryheight", "0.66"
                      "fixedLauncher", "true"
                      "fireTolerance", "11000.0"
                  ] }
                { name = "parabolic_rockets"
                  displayName = "Parabolic Trajectory Multi-Rocket Launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "default", 100.0
                      "subs", 50.0
                  ]
                  range = Some (ValueOrExpr.Concrete 500.0)
                  reloadTime = Some (ValueOrExpr.Concrete 6.0)
                  weaponVelocity = Some 650.0
                  areaOfEffect = Some 100.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.65
                  impulseFactor = Some 0.6
                  noSelfDamage = Some true
                  soundStart = Some "rocksalvo"
                  soundHit = Some "rockhit"
                  explosiongenerator = Some "custom:genericshellexplosion-catapult"
                  rgbColor = None
                  customParams = Map.ofList [
                      "projectile_destruction_method", "descend"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "90.0"
                      "avoidfeature", "false"
                      "burst", "3.0"
                      "burstrate", "0.3"
                      "castshadow", "true"
                      "cegtag", "missiletrailsmall-simple"
                      "collidefriendly", "false"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "dance", "48.0"
                      "firestarter", "70.0"
                      "flighttime", "2.0"
                      "model", "legsmallrocket.s3o"
                      "proximitypriority", "-1.0"
                      "smokecolor", "0.5"
                      "smokeperiod", "7.0"
                      "smokesize", "6.5"
                      "smoketime", "21.0"
                      "smoketrail", "true"
                      "smoketrailcastshadow", "false"
                      "soundhitwet", "splssml"
                      "soundtrigger", "true"
                      "startvelocity", "185.0"
                      "targetmoveerror", "0.2"
                      "texture1", "null"
                      "texture2", "smoketrailbar"
                      "trajectoryheight", "0.5"
                      "turnrate", "8500.0"
                      "weaponacceleration", "100.0"
                      "weapontimer", "0.75"
                      "wobble", "12000.0"
                      "trajectoryheight", "0.66"
                      "fixedLauncher", "true"
                      "fireTolerance", "11000.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "63 22 62"
                  collisionVolumeType = Some "cylY"
                  damage = Some 7000.0
                  featureDead = Some "heap"
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 15.0
                  metal = Some 514.0
                  object_ = Some "Units/legehovertank_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 3500.0
                  featureDead = None
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 4.0
                  metal = Some 188.0
                  object_ = Some "Units/arm4x4d.s3o"
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
                ok = ["hovt2lasok"]
                select = ["hovt2lassel"] }
          customParams = Map.ofList [
                "model_author", "Gabs/ShadowsAIT & ZephyrSkies (Model), Protar (Concept Art)"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/T3"
                "techlevel", "3.0"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "usepiececollisionvolumes", "1.0"
                "canattack", "true"
                "canguard", "true"
                "canpatrol", "true"
                "canstop", "1.0"
                "cantbetransported", "true"
                "nochasecategory", "VTOL"
                "radardistance", "0.0"
                "sonardistance", "550.0"
            ] }

    let legehovertankDef : UnitDef =
        { name = "legehovertank"
          subfolder = "Legion/T3"
          metalCost = ValueOrExpr.Concrete 1350.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 41600.0
          health = ValueOrExpr.Concrete 4900.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/legehovertank.s3o"
          buildPic = Some "legehovertank.DDS"
          script = Some "Units/legehovertank.cob"
          corpse = Some "dead"
          explodeAs = Some "largeexplosiongeneric"
          selfDestructAs = Some "largeExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -15 0"
          collisionVolumeScales = Some "63 32 63"
          collisionVolumeType = Some "cylY"
          seismicSignature = None
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 63.0
              maxAcc = 0.022
              maxDec = 0.022
              turnRate = 300.0
              movementClass = Some "HHOVER4"
              maxSlope = Some 16.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.122
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "heat_ray"
                displayName = "Heavy Sweepfire Heatray"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 25.0
                    "vtol", 7.0
                ]
                range = Some (ValueOrExpr.Concrete 425.0)
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
              { name = "depthcharge"
                displayName = "Depthcharge Launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 225.0
                ]
                range = Some (ValueOrExpr.Concrete 400.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.0)
                weaponVelocity = Some 140.0
                areaOfEffect = Some 24.0
                accuracy = None
                turret = Some true
                tolerance = Some 1000.0
                edgeEffectiveness = Some 0.9
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "torpedo1"
                soundHit = Some "xplodep2"
                explosiongenerator = Some "custom:genericshellexplosion-medium-uw"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTSUB"
                    "mount_maindir", "0 -1 0"
                    "mount_maxangledif", "180.0"
                    "mount_onlytargetcategory", "CANBEUW UNDERWATER"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "flighttime", "3.0"
                    "model", "legbasictorpedo.s3o"
                    "predictboost", "0.0"
                    "startvelocity", "120.0"
                    "tracks", "true"
                    "turnrate", "6000.0"
                    "waterweapon", "true"
                    "weaponacceleration", "20.0"
                    "weapontimer", "3.0"
                ] }
              { name = "parabolic_rockets"
                displayName = "Parabolic Trajectory Multi-Rocket Launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 100.0
                    "subs", 50.0
                ]
                range = Some (ValueOrExpr.Concrete 500.0)
                reloadTime = Some (ValueOrExpr.Concrete 6.0)
                weaponVelocity = Some 650.0
                areaOfEffect = Some 100.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.65
                impulseFactor = Some 0.6
                noSelfDamage = Some true
                soundStart = Some "rocksalvo"
                soundHit = Some "rockhit"
                explosiongenerator = Some "custom:genericshellexplosion-catapult"
                rgbColor = None
                customParams = Map.ofList [
                    "projectile_destruction_method", "descend"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "90.0"
                    "avoidfeature", "false"
                    "burst", "3.0"
                    "burstrate", "0.3"
                    "castshadow", "true"
                    "cegtag", "missiletrailsmall-simple"
                    "collidefriendly", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "dance", "48.0"
                    "firestarter", "70.0"
                    "flighttime", "2.0"
                    "model", "legsmallrocket.s3o"
                    "proximitypriority", "-1.0"
                    "smokecolor", "0.5"
                    "smokeperiod", "7.0"
                    "smokesize", "6.5"
                    "smoketime", "21.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splssml"
                    "soundtrigger", "true"
                    "startvelocity", "185.0"
                    "targetmoveerror", "0.2"
                    "texture1", "null"
                    "texture2", "smoketrailbar"
                    "trajectoryheight", "0.5"
                    "turnrate", "8500.0"
                    "weaponacceleration", "100.0"
                    "weapontimer", "0.75"
                    "wobble", "12000.0"
                    "trajectoryheight", "0.66"
                    "fixedLauncher", "true"
                    "fireTolerance", "11000.0"
                ] }
              { name = "parabolic_rockets"
                displayName = "Parabolic Trajectory Multi-Rocket Launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 100.0
                    "subs", 50.0
                ]
                range = Some (ValueOrExpr.Concrete 500.0)
                reloadTime = Some (ValueOrExpr.Concrete 6.0)
                weaponVelocity = Some 650.0
                areaOfEffect = Some 100.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.65
                impulseFactor = Some 0.6
                noSelfDamage = Some true
                soundStart = Some "rocksalvo"
                soundHit = Some "rockhit"
                explosiongenerator = Some "custom:genericshellexplosion-catapult"
                rgbColor = None
                customParams = Map.ofList [
                    "projectile_destruction_method", "descend"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "90.0"
                    "avoidfeature", "false"
                    "burst", "3.0"
                    "burstrate", "0.3"
                    "castshadow", "true"
                    "cegtag", "missiletrailsmall-simple"
                    "collidefriendly", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "dance", "48.0"
                    "firestarter", "70.0"
                    "flighttime", "2.0"
                    "model", "legsmallrocket.s3o"
                    "proximitypriority", "-1.0"
                    "smokecolor", "0.5"
                    "smokeperiod", "7.0"
                    "smokesize", "6.5"
                    "smoketime", "21.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splssml"
                    "soundtrigger", "true"
                    "startvelocity", "185.0"
                    "targetmoveerror", "0.2"
                    "texture1", "null"
                    "texture2", "smoketrailbar"
                    "trajectoryheight", "0.5"
                    "turnrate", "8500.0"
                    "weaponacceleration", "100.0"
                    "weapontimer", "0.75"
                    "wobble", "12000.0"
                    "trajectoryheight", "0.66"
                    "fixedLauncher", "true"
                    "fireTolerance", "11000.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "63 22 62"
                collisionVolumeType = Some "cylY"
                damage = Some 7000.0
                featureDead = Some "heap"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 15.0
                metal = Some 514.0
                object_ = Some "Units/legehovertank_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 3500.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 4.0
                metal = Some 188.0
                object_ = Some "Units/arm4x4d.s3o"
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
              ok = ["hovt2lasok"]
              select = ["hovt2lassel"] })
          customParams = Map.ofList [
              "model_author", "Gabs/ShadowsAIT & ZephyrSkies (Model), Protar (Concept Art)"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/T3"
              "techlevel", "3.0"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "usepiececollisionvolumes", "1.0"
              "canattack", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canstop", "1.0"
              "cantbetransported", "true"
              "nochasecategory", "VTOL"
              "radardistance", "0.0"
              "sonardistance", "550.0"
          ] }

    let legehovertankToFlat (def: UnitDef) : Legehovertank =
        { name = def.name
          subfolder = def.subfolder
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
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let legehovertankToUnitDef (flat: Legehovertank) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
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
              movementClass = Some flat.movementClass
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit
              cruiseAltitude = None
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

    type Legelrpcmech =
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

    let legelrpcmech : Legelrpcmech =
        { name = "legelrpcmech"
          subfolder = "Legion/T3"
          metalCost = ValueOrExpr.Concrete 11000.0
          energyCost = ValueOrExpr.Concrete 150000.0
          buildTime = ValueOrExpr.Concrete 178000.0
          health = ValueOrExpr.Concrete 17000.0
          sightDistance = ValueOrExpr.Concrete 625.0
          footprintX = 7.0
          footprintZ = 7.0
          objectName = Some "Units/LEGELRPCMECH.s3o"
          buildPic = Some "LEGELRPCMECH.DDS"
          script = Some "Units/LEGELRPCMECH.cob"
          corpse = Some "DEAD"
          explodeAs = Some "explosiont3"
          selfDestructAs = Some "explosiont3xl"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "110 70 110"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 25.0
          maxAcc = 0.02645
          maxDec = 0.345
          turnRate = 265.64999
          movementClass = "HBOT7"
          maxSlope = 17.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 0.726
          weapons = [
                { name = "shocker_low"
                  displayName = "Long-Range g2g Heavy Cluster Plasma Cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 600.0
                      "shields", 300.0
                      "subs", 120.0
                  ]
                  range = Some (ValueOrExpr.Concrete 3100.0)
                  reloadTime = Some (ValueOrExpr.Concrete 14.4)
                  weaponVelocity = Some 800.0
                  areaOfEffect = Some 150.0
                  accuracy = Some 300.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.5
                  noSelfDamage = Some true
                  soundStart = Some "lrpcshot3"
                  soundHit = Some "lrpcexplo"
                  explosiongenerator = Some "custom:starfire-explosion"
                  rgbColor = None
                  customParams = Map.ofList [
                      "cluster_def", "cluster_munition"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                      "mount_onlytargetcategory", "SURFACE"
                      "sprayangle", "300.0"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "cegtag", "starfire-small"
                      "collidefriendly", "false"
                      "craterareaofeffect", "116.0"
                      "craterboost", "0.1"
                      "cratermult", "0.1"
                      "burst", "4.0"
                      "burstrate", "0.06"
                      "energypershot", "6000.0"
                      "gravityaffected", "true"
                      "heightboostfactor", "8.0"
                      "leadbonus", "0.0"
                      "model", "legbomb.s3o"
                      "soundhitwet", "splshbig"
                      "soundhitvolume", "38.0"
                      "soundstartvolume", "24.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "130 60 100"
                  collisionVolumeType = Some "Box"
                  damage = Some 8500.0
                  featureDead = Some "HEAP"
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 20.0
                  metal = Some 5500.0
                  object_ = Some "Units/legelrpcmech_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 4250.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 2250.0
                  object_ = Some "Units/arm4X4D.s3o"
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
                ok = ["kbarmmov"]
                select = ["kbarmsel"] }
          customParams = Map.ofList [
                "model_author", "ZephyrSkies (Model), Phill-Art (Concept Art)"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/T3"
                "techlevel", "3.0"
                "unitgroup", "weapon"
                "restrictions_inclusion", "_nolrpc_"
            ]
          extras = Map.ofList [
                "cantbetransported", "true"
                "mass", "4300.0"
                "movestate", "0.0"
                "nochasecategory", "VTOL"
            ] }

    let legelrpcmechDef : UnitDef =
        { name = "legelrpcmech"
          subfolder = "Legion/T3"
          metalCost = ValueOrExpr.Concrete 11000.0
          energyCost = ValueOrExpr.Concrete 150000.0
          buildTime = ValueOrExpr.Concrete 178000.0
          health = ValueOrExpr.Concrete 17000.0
          sightDistance = ValueOrExpr.Concrete 625.0
          footprintX = 7.0
          footprintZ = 7.0
          objectName = Some "Units/LEGELRPCMECH.s3o"
          buildPic = Some "LEGELRPCMECH.DDS"
          script = Some "Units/LEGELRPCMECH.cob"
          corpse = Some "DEAD"
          explodeAs = Some "explosiont3"
          selfDestructAs = Some "explosiont3xl"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "110 70 110"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 25.0
              maxAcc = 0.02645
              maxDec = 0.345
              turnRate = 265.64999
              movementClass = Some "HBOT7"
              maxSlope = Some 17.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 0.726
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "shocker_low"
                displayName = "Long-Range g2g Heavy Cluster Plasma Cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 600.0
                    "shields", 300.0
                    "subs", 120.0
                ]
                range = Some (ValueOrExpr.Concrete 3100.0)
                reloadTime = Some (ValueOrExpr.Concrete 14.4)
                weaponVelocity = Some 800.0
                areaOfEffect = Some 150.0
                accuracy = Some 300.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.5
                noSelfDamage = Some true
                soundStart = Some "lrpcshot3"
                soundHit = Some "lrpcexplo"
                explosiongenerator = Some "custom:starfire-explosion"
                rgbColor = None
                customParams = Map.ofList [
                    "cluster_def", "cluster_munition"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                    "mount_onlytargetcategory", "SURFACE"
                    "sprayangle", "300.0"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "cegtag", "starfire-small"
                    "collidefriendly", "false"
                    "craterareaofeffect", "116.0"
                    "craterboost", "0.1"
                    "cratermult", "0.1"
                    "burst", "4.0"
                    "burstrate", "0.06"
                    "energypershot", "6000.0"
                    "gravityaffected", "true"
                    "heightboostfactor", "8.0"
                    "leadbonus", "0.0"
                    "model", "legbomb.s3o"
                    "soundhitwet", "splshbig"
                    "soundhitvolume", "38.0"
                    "soundstartvolume", "24.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "130 60 100"
                collisionVolumeType = Some "Box"
                damage = Some 8500.0
                featureDead = Some "HEAP"
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 20.0
                metal = Some 5500.0
                object_ = Some "Units/legelrpcmech_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 4250.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 2250.0
                object_ = Some "Units/arm4X4D.s3o"
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
              ok = ["kbarmmov"]
              select = ["kbarmsel"] })
          customParams = Map.ofList [
              "model_author", "ZephyrSkies (Model), Phill-Art (Concept Art)"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/T3"
              "techlevel", "3.0"
              "unitgroup", "weapon"
              "restrictions_inclusion", "_nolrpc_"
          ]
          extras = Map.ofList [
              "cantbetransported", "true"
              "mass", "4300.0"
              "movestate", "0.0"
              "nochasecategory", "VTOL"
          ] }

    let legelrpcmechToFlat (def: UnitDef) : Legelrpcmech =
        { name = def.name
          subfolder = def.subfolder
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
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let legelrpcmechToUnitDef (flat: Legelrpcmech) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
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
              movementClass = Some flat.movementClass
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit
              cruiseAltitude = None
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

    type Legerailtank =
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

    let legerailtank : Legerailtank =
        { name = "legerailtank"
          subfolder = "Legion/T3"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 0.0
          buildTime = ValueOrExpr.Concrete 125000.0
          health = ValueOrExpr.Concrete 0.0
          sightDistance = ValueOrExpr.Concrete 750.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/legerailtank.s3o"
          buildPic = Some "LEGERAILTANK.DDS"
          script = Some "Units/legerailtank.cob"
          corpse = Some "DEAD"
          explodeAs = Some "explosiont3"
          selfDestructAs = Some "explosiont3xl"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "65 42 75"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 61.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 235.0
          movementClass = "HTANK7"
          maxSlope = 16.0
          maxWaterDepth = 20.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.7
          weapons = [
                { name = "t3_rail_accelerator"
                  displayName = "Siege Rail Accelerator"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "commanders", 300.0
                      "default", 800.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1000.0)
                  reloadTime = Some (ValueOrExpr.Concrete 3.0)
                  weaponVelocity = Some 2850.0
                  areaOfEffect = Some 80.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 7000.0
                  edgeEffectiveness = Some 0.9
                  impulseFactor = Some 1.0
                  noSelfDamage = Some true
                  soundStart = Some "railgunxl"
                  soundHit = Some "mavgun3"
                  explosiongenerator = Some "custom:plasmahit-sparkonly"
                  rgbColor = Some "0.34 0.64 0.94"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "burst", "1.0"
                      "burstrate", "0.33"
                      "burnblow", "false"
                      "cegtag", "railgun"
                      "collisionSize", "0.667"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "0.12"
                      "energypershot", "600.0"
                      "firestarter", "1.0"
                      "hardstop", "true"
                      "impactonly", "true"
                      "intensity", "0.8"
                      "noexplode", "true"
                      "ownerExpAccWeight", "4.0"
                      "soundhitwet", "splshbig"
                      "soundstartvolume", "30.0"
                      "thickness", "4.0"
                      "firetolerance", "7000.0"
                  ] }
                { name = "t3_rail_accelerator"
                  displayName = "Siege Rail Accelerator"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "commanders", 300.0
                      "default", 800.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1000.0)
                  reloadTime = Some (ValueOrExpr.Concrete 3.0)
                  weaponVelocity = Some 2850.0
                  areaOfEffect = Some 80.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 7000.0
                  edgeEffectiveness = Some 0.9
                  impulseFactor = Some 1.0
                  noSelfDamage = Some true
                  soundStart = Some "railgunxl"
                  soundHit = Some "mavgun3"
                  explosiongenerator = Some "custom:plasmahit-sparkonly"
                  rgbColor = Some "0.34 0.64 0.94"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "mount_slaveTo", "1.0"
                      "avoidfeature", "false"
                      "burst", "1.0"
                      "burstrate", "0.33"
                      "burnblow", "false"
                      "cegtag", "railgun"
                      "collisionSize", "0.667"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "0.12"
                      "energypershot", "600.0"
                      "firestarter", "1.0"
                      "hardstop", "true"
                      "impactonly", "true"
                      "intensity", "0.8"
                      "noexplode", "true"
                      "ownerExpAccWeight", "4.0"
                      "soundhitwet", "splshbig"
                      "soundstartvolume", "30.0"
                      "thickness", "4.0"
                      "firetolerance", "7000.0"
                  ] }
                { name = "t3_rail_accelerator"
                  displayName = "Siege Rail Accelerator"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "commanders", 300.0
                      "default", 800.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1000.0)
                  reloadTime = Some (ValueOrExpr.Concrete 3.0)
                  weaponVelocity = Some 2850.0
                  areaOfEffect = Some 80.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 7000.0
                  edgeEffectiveness = Some 0.9
                  impulseFactor = Some 1.0
                  noSelfDamage = Some true
                  soundStart = Some "railgunxl"
                  soundHit = Some "mavgun3"
                  explosiongenerator = Some "custom:plasmahit-sparkonly"
                  rgbColor = Some "0.34 0.64 0.94"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "mount_slaveTo", "1.0"
                      "avoidfeature", "false"
                      "burst", "1.0"
                      "burstrate", "0.33"
                      "burnblow", "false"
                      "cegtag", "railgun"
                      "collisionSize", "0.667"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "0.12"
                      "energypershot", "600.0"
                      "firestarter", "1.0"
                      "hardstop", "true"
                      "impactonly", "true"
                      "intensity", "0.8"
                      "noexplode", "true"
                      "ownerExpAccWeight", "4.0"
                      "soundhitwet", "splshbig"
                      "soundstartvolume", "30.0"
                      "thickness", "4.0"
                      "firetolerance", "7000.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "67 38 75"
                  collisionVolumeType = Some "Box"
                  damage = Some 10000.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 25.0
                  metal = Some 3250.0
                  object_ = Some "Units/legerailtank_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = Some "-1.01699066162 -0.66435255127 0.0775146484375"
                  collisionVolumeScales = Some "23.8865509033 22.2328948975 29.3510131836"
                  collisionVolumeType = Some "Box"
                  damage = Some 4000.0
                  featureDead = None
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 4.0
                  metal = Some 1625.0
                  object_ = Some "Units/cor4X4C.s3o"
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
                "normaltex", "unittextures/leg_normal.dds"
                "paralyzemultiplier", "0.5"
                "model_author", "ZephyrSkies"
                "techlevel", "3.0"
            ]
          extras = Map.ofList [
                "acceleration", "0.035"
                "brakerate", "0.055"
                "buildcostenergy", "165000.0"
                "buildcostmetal", "6500.0"
                "usepiececollisionvolumes", "1.0"
                "leavetracks", "true"
                "maxdamage", "16500.0"
                "nochasecategory", "VTOL"
                "trackoffset", "16.0"
                "trackstrength", "12.0"
                "tracktype", "armbull_tracks"
                "trackwidth", "70.0"
            ] }

    let legerailtankDef : UnitDef =
        { name = "legerailtank"
          subfolder = "Legion/T3"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 0.0
          buildTime = ValueOrExpr.Concrete 125000.0
          health = ValueOrExpr.Concrete 0.0
          sightDistance = ValueOrExpr.Concrete 750.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/legerailtank.s3o"
          buildPic = Some "LEGERAILTANK.DDS"
          script = Some "Units/legerailtank.cob"
          corpse = Some "DEAD"
          explodeAs = Some "explosiont3"
          selfDestructAs = Some "explosiont3xl"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "65 42 75"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 61.0
              maxAcc = 0.0
              maxDec = 0.0
              turnRate = 235.0
              movementClass = Some "HTANK7"
              maxSlope = Some 16.0
              maxWaterDepth = Some 20.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.7
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "t3_rail_accelerator"
                displayName = "Siege Rail Accelerator"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "commanders", 300.0
                    "default", 800.0
                ]
                range = Some (ValueOrExpr.Concrete 1000.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.0)
                weaponVelocity = Some 2850.0
                areaOfEffect = Some 80.0
                accuracy = None
                turret = Some true
                tolerance = Some 7000.0
                edgeEffectiveness = Some 0.9
                impulseFactor = Some 1.0
                noSelfDamage = Some true
                soundStart = Some "railgunxl"
                soundHit = Some "mavgun3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "0.34 0.64 0.94"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "burst", "1.0"
                    "burstrate", "0.33"
                    "burnblow", "false"
                    "cegtag", "railgun"
                    "collisionSize", "0.667"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.12"
                    "energypershot", "600.0"
                    "firestarter", "1.0"
                    "hardstop", "true"
                    "impactonly", "true"
                    "intensity", "0.8"
                    "noexplode", "true"
                    "ownerExpAccWeight", "4.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "30.0"
                    "thickness", "4.0"
                    "firetolerance", "7000.0"
                ] }
              { name = "t3_rail_accelerator"
                displayName = "Siege Rail Accelerator"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "commanders", 300.0
                    "default", 800.0
                ]
                range = Some (ValueOrExpr.Concrete 1000.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.0)
                weaponVelocity = Some 2850.0
                areaOfEffect = Some 80.0
                accuracy = None
                turret = Some true
                tolerance = Some 7000.0
                edgeEffectiveness = Some 0.9
                impulseFactor = Some 1.0
                noSelfDamage = Some true
                soundStart = Some "railgunxl"
                soundHit = Some "mavgun3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "0.34 0.64 0.94"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "mount_slaveTo", "1.0"
                    "avoidfeature", "false"
                    "burst", "1.0"
                    "burstrate", "0.33"
                    "burnblow", "false"
                    "cegtag", "railgun"
                    "collisionSize", "0.667"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.12"
                    "energypershot", "600.0"
                    "firestarter", "1.0"
                    "hardstop", "true"
                    "impactonly", "true"
                    "intensity", "0.8"
                    "noexplode", "true"
                    "ownerExpAccWeight", "4.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "30.0"
                    "thickness", "4.0"
                    "firetolerance", "7000.0"
                ] }
              { name = "t3_rail_accelerator"
                displayName = "Siege Rail Accelerator"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "commanders", 300.0
                    "default", 800.0
                ]
                range = Some (ValueOrExpr.Concrete 1000.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.0)
                weaponVelocity = Some 2850.0
                areaOfEffect = Some 80.0
                accuracy = None
                turret = Some true
                tolerance = Some 7000.0
                edgeEffectiveness = Some 0.9
                impulseFactor = Some 1.0
                noSelfDamage = Some true
                soundStart = Some "railgunxl"
                soundHit = Some "mavgun3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "0.34 0.64 0.94"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "mount_slaveTo", "1.0"
                    "avoidfeature", "false"
                    "burst", "1.0"
                    "burstrate", "0.33"
                    "burnblow", "false"
                    "cegtag", "railgun"
                    "collisionSize", "0.667"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.12"
                    "energypershot", "600.0"
                    "firestarter", "1.0"
                    "hardstop", "true"
                    "impactonly", "true"
                    "intensity", "0.8"
                    "noexplode", "true"
                    "ownerExpAccWeight", "4.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "30.0"
                    "thickness", "4.0"
                    "firetolerance", "7000.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "67 38 75"
                collisionVolumeType = Some "Box"
                damage = Some 10000.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 25.0
                metal = Some 3250.0
                object_ = Some "Units/legerailtank_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = Some "-1.01699066162 -0.66435255127 0.0775146484375"
                collisionVolumeScales = Some "23.8865509033 22.2328948975 29.3510131836"
                collisionVolumeType = Some "Box"
                damage = Some 4000.0
                featureDead = None
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 4.0
                metal = Some 1625.0
                object_ = Some "Units/cor4X4C.s3o"
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
              ok = ["tcormove"]
              select = ["tcorsel"] })
          customParams = Map.ofList [
              "unitgroup", "weapon"
              "normaltex", "unittextures/leg_normal.dds"
              "paralyzemultiplier", "0.5"
              "model_author", "ZephyrSkies"
              "techlevel", "3.0"
          ]
          extras = Map.ofList [
              "acceleration", "0.035"
              "brakerate", "0.055"
              "buildcostenergy", "165000.0"
              "buildcostmetal", "6500.0"
              "usepiececollisionvolumes", "1.0"
              "leavetracks", "true"
              "maxdamage", "16500.0"
              "nochasecategory", "VTOL"
              "trackoffset", "16.0"
              "trackstrength", "12.0"
              "tracktype", "armbull_tracks"
              "trackwidth", "70.0"
          ] }

    let legerailtankToFlat (def: UnitDef) : Legerailtank =
        { name = def.name
          subfolder = def.subfolder
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
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let legerailtankToUnitDef (flat: Legerailtank) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
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
              movementClass = Some flat.movementClass
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit
              cruiseAltitude = None
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

    type Legeshotgunmech =
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

    let legeshotgunmech : Legeshotgunmech =
        { name = "legeshotgunmech"
          subfolder = "Legion/T3"
          metalCost = ValueOrExpr.Concrete 7000.0
          energyCost = ValueOrExpr.Concrete 120000.0
          buildTime = ValueOrExpr.Concrete 159000.0
          health = ValueOrExpr.Concrete 25000.0
          sightDistance = ValueOrExpr.Concrete 617.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/legeshotgunmech.s3o"
          buildPic = Some "legeshotgunmech.DDS"
          script = Some "Units/legeshotgunmech.cob"
          corpse = Some "DEAD"
          explodeAs = Some "explosiont3"
          selfDestructAs = Some "explosiont3xl"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "63 105 52"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 63.0
          maxAcc = 0.18
          maxDec = 0.9
          turnRate = 600.0
          movementClass = "HBOT4"
          maxSlope = 17.0
          maxWaterDepth = 12.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.089
          weapons = [
                { name = "aimhull"
                  displayName = "Targeting System"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 0.0
                  ]
                  range = Some (ValueOrExpr.Concrete 420.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.5)
                  weaponVelocity = Some 360.0
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
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "hightrajectory", "1.0"
                      "size", "0.0"
                      "soundhitwet", ""
                  ] }
                { name = "shotgun"
                  displayName = "Dual Heavy Assault Kinetic Shotgun"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "default", 60.0
                      "vtol", 25.0
                  ]
                  range = Some (ValueOrExpr.Concrete 420.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.9)
                  weaponVelocity = Some 969.0
                  areaOfEffect = Some 16.0
                  accuracy = Some 7.0
                  turret = Some true
                  tolerance = Some 6000.0
                  edgeEffectiveness = Some 0.85
                  impulseFactor = Some 1.5
                  noSelfDamage = Some true
                  soundStart = Some "kroggie2xs"
                  soundHit = Some "bimpact3"
                  explosiongenerator = Some "custom:plasmahit-sparkonly"
                  rgbColor = Some "1 0.95 0.4"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_slaveto", "1.0"
                      "avoidfeature", "false"
                      "projectiles", "14.0"
                      "burnblow", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "0.015"
                      "fallOffRate", "0.2"
                      "firestarter", "0.0"
                      "intensity", "0.8"
                      "ownerExpAccWeight", "4.0"
                      "proximitypriority", "10.0"
                      "soundhitwet", "splshbig"
                      "soundstartvolume", "3.0"
                      "sprayangle", "1400.0"
                      "thickness", "0.6"
                      "firetolerance", "6000.0"
                  ] }
                { name = "clusterplasma"
                  displayName = "Long-Range Cluster Plasma Cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 300.0
                      "lboats", 300.0
                      "subs", 90.0
                      "vtol", 90.0
                  ]
                  range = Some (ValueOrExpr.Concrete 850.0)
                  reloadTime = Some (ValueOrExpr.Concrete 5.5)
                  weaponVelocity = Some 350.0
                  areaOfEffect = Some 135.0
                  accuracy = Some 50.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.4
                  impulseFactor = Some 0.5
                  noSelfDamage = Some true
                  soundStart = Some "cannhvy5"
                  soundHit = Some "xplomed2"
                  explosiongenerator = Some "custom:ministarfire-explosion"
                  rgbColor = Some "0.7 0.7 1.0"
                  customParams = Map.ofList [
                      "cluster_def", "cluster_munition"
                  ]
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "avoidneutral", "true"
                      "cegtag", "starfire_arty"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "soundhitwet", "splsmed"
                  ] }
                { name = "adv_rocket"
                  displayName = "Parabolic Trajectory Multi-Rocket Launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "default", 200.0
                      "subs", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 650.0)
                  reloadTime = Some (ValueOrExpr.Concrete 6.0)
                  weaponVelocity = Some 650.0
                  areaOfEffect = Some 100.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.65
                  impulseFactor = Some 0.6
                  noSelfDamage = Some true
                  soundStart = Some "rocksalvo"
                  soundHit = Some "rockhit"
                  explosiongenerator = Some "custom:genericshellexplosion-catapult"
                  rgbColor = None
                  customParams = Map.ofList [
                      "cruise_max_height", "20"
                      "cruise_min_height", "15"
                      "lockon_dist", "150"
                      "speceffect", "cruise"
                      "projectile_destruction_method", "descend"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_slaveto", "1.0"
                      "avoidfeature", "false"
                      "burst", "3.0"
                      "burstrate", "0.3"
                      "castshadow", "true"
                      "cegtag", "missiletrailsmall-simple"
                      "collidefriendly", "false"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "dance", "24.0"
                      "firestarter", "70.0"
                      "flighttime", "2.0"
                      "model", "legsmallrocket.s3o"
                      "proximitypriority", "-1.0"
                      "smokecolor", "0.5"
                      "smokeperiod", "7.0"
                      "smokesize", "6.5"
                      "smoketime", "21.0"
                      "smoketrail", "true"
                      "smoketrailcastshadow", "false"
                      "soundhitwet", "splssml"
                      "soundtrigger", "true"
                      "startvelocity", "185.0"
                      "targetmoveerror", "0.2"
                      "texture1", "null"
                      "texture2", "smoketrailbar"
                      "trajectoryheight", "0.5"
                      "turnrate", "0.0"
                      "weaponacceleration", "100.0"
                      "weapontimer", "1.5"
                      "wobble", "5000.0"
                  ] }
                { name = "leg_t2_microflak_mobile"
                  displayName = "Rotary Microflak Cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "vtol", 40.0
                  ]
                  range = Some (ValueOrExpr.Concrete 800.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.237)
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
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "103 35 107"
                  collisionVolumeType = Some "Box"
                  damage = Some 30000.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 6350.0
                  object_ = Some "Units/legeshotgunmech_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 10500.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 3300.0
                  object_ = Some "Units/arm3X3A.s3o"
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
                ok = ["krogok1"]
                select = ["krogsel1"] }
          customParams = Map.ofList [
                "unitgroup", "weapon"
                "maxrange", "315"
                "model_author", "Ghoulish & ZephyrSkies"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "leggantry"
                "techlevel", "3.0"
            ]
          extras = Map.ofList [
                "airsightdistance", "1100.0"
                "mass", "200000.0"
                "nochasecategory", "VTOL"
                "upright", "true"
            ] }

    let legeshotgunmechDef : UnitDef =
        { name = "legeshotgunmech"
          subfolder = "Legion/T3"
          metalCost = ValueOrExpr.Concrete 7000.0
          energyCost = ValueOrExpr.Concrete 120000.0
          buildTime = ValueOrExpr.Concrete 159000.0
          health = ValueOrExpr.Concrete 25000.0
          sightDistance = ValueOrExpr.Concrete 617.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/legeshotgunmech.s3o"
          buildPic = Some "legeshotgunmech.DDS"
          script = Some "Units/legeshotgunmech.cob"
          corpse = Some "DEAD"
          explodeAs = Some "explosiont3"
          selfDestructAs = Some "explosiont3xl"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "63 105 52"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 63.0
              maxAcc = 0.18
              maxDec = 0.9
              turnRate = 600.0
              movementClass = Some "HBOT4"
              maxSlope = Some 17.0
              maxWaterDepth = Some 12.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.089
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "aimhull"
                displayName = "Targeting System"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = Some (ValueOrExpr.Concrete 420.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.5)
                weaponVelocity = Some 360.0
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
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "hightrajectory", "1.0"
                    "size", "0.0"
                    "soundhitwet", ""
                ] }
              { name = "shotgun"
                displayName = "Dual Heavy Assault Kinetic Shotgun"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 60.0
                    "vtol", 25.0
                ]
                range = Some (ValueOrExpr.Concrete 420.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.9)
                weaponVelocity = Some 969.0
                areaOfEffect = Some 16.0
                accuracy = Some 7.0
                turret = Some true
                tolerance = Some 6000.0
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 1.5
                noSelfDamage = Some true
                soundStart = Some "kroggie2xs"
                soundHit = Some "bimpact3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "1 0.95 0.4"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_slaveto", "1.0"
                    "avoidfeature", "false"
                    "projectiles", "14.0"
                    "burnblow", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.015"
                    "fallOffRate", "0.2"
                    "firestarter", "0.0"
                    "intensity", "0.8"
                    "ownerExpAccWeight", "4.0"
                    "proximitypriority", "10.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "3.0"
                    "sprayangle", "1400.0"
                    "thickness", "0.6"
                    "firetolerance", "6000.0"
                ] }
              { name = "clusterplasma"
                displayName = "Long-Range Cluster Plasma Cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 300.0
                    "lboats", 300.0
                    "subs", 90.0
                    "vtol", 90.0
                ]
                range = Some (ValueOrExpr.Concrete 850.0)
                reloadTime = Some (ValueOrExpr.Concrete 5.5)
                weaponVelocity = Some 350.0
                areaOfEffect = Some 135.0
                accuracy = Some 50.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.4
                impulseFactor = Some 0.5
                noSelfDamage = Some true
                soundStart = Some "cannhvy5"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:ministarfire-explosion"
                rgbColor = Some "0.7 0.7 1.0"
                customParams = Map.ofList [
                    "cluster_def", "cluster_munition"
                ]
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "avoidneutral", "true"
                    "cegtag", "starfire_arty"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splsmed"
                ] }
              { name = "adv_rocket"
                displayName = "Parabolic Trajectory Multi-Rocket Launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 200.0
                    "subs", 100.0
                ]
                range = Some (ValueOrExpr.Concrete 650.0)
                reloadTime = Some (ValueOrExpr.Concrete 6.0)
                weaponVelocity = Some 650.0
                areaOfEffect = Some 100.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.65
                impulseFactor = Some 0.6
                noSelfDamage = Some true
                soundStart = Some "rocksalvo"
                soundHit = Some "rockhit"
                explosiongenerator = Some "custom:genericshellexplosion-catapult"
                rgbColor = None
                customParams = Map.ofList [
                    "cruise_max_height", "20"
                    "cruise_min_height", "15"
                    "lockon_dist", "150"
                    "speceffect", "cruise"
                    "projectile_destruction_method", "descend"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_slaveto", "1.0"
                    "avoidfeature", "false"
                    "burst", "3.0"
                    "burstrate", "0.3"
                    "castshadow", "true"
                    "cegtag", "missiletrailsmall-simple"
                    "collidefriendly", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "dance", "24.0"
                    "firestarter", "70.0"
                    "flighttime", "2.0"
                    "model", "legsmallrocket.s3o"
                    "proximitypriority", "-1.0"
                    "smokecolor", "0.5"
                    "smokeperiod", "7.0"
                    "smokesize", "6.5"
                    "smoketime", "21.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splssml"
                    "soundtrigger", "true"
                    "startvelocity", "185.0"
                    "targetmoveerror", "0.2"
                    "texture1", "null"
                    "texture2", "smoketrailbar"
                    "trajectoryheight", "0.5"
                    "turnrate", "0.0"
                    "weaponacceleration", "100.0"
                    "weapontimer", "1.5"
                    "wobble", "5000.0"
                ] }
              { name = "leg_t2_microflak_mobile"
                displayName = "Rotary Microflak Cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "vtol", 40.0
                ]
                range = Some (ValueOrExpr.Concrete 800.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.237)
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
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "103 35 107"
                collisionVolumeType = Some "Box"
                damage = Some 30000.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 6350.0
                object_ = Some "Units/legeshotgunmech_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 10500.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 3300.0
                object_ = Some "Units/arm3X3A.s3o"
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
              ok = ["krogok1"]
              select = ["krogsel1"] })
          customParams = Map.ofList [
              "unitgroup", "weapon"
              "maxrange", "315"
              "model_author", "Ghoulish & ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "leggantry"
              "techlevel", "3.0"
          ]
          extras = Map.ofList [
              "airsightdistance", "1100.0"
              "mass", "200000.0"
              "nochasecategory", "VTOL"
              "upright", "true"
          ] }

    let legeshotgunmechToFlat (def: UnitDef) : Legeshotgunmech =
        { name = def.name
          subfolder = def.subfolder
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
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let legeshotgunmechToUnitDef (flat: Legeshotgunmech) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
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
              movementClass = Some flat.movementClass
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit
              cruiseAltitude = None
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

    type Legjav =
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

    let legjav : Legjav =
        { name = "legjav"
          subfolder = "Legion/T3"
          metalCost = ValueOrExpr.Concrete 1200.0
          energyCost = ValueOrExpr.Concrete 21000.0
          buildTime = ValueOrExpr.Concrete 39850.0
          health = ValueOrExpr.Concrete 7200.0
          sightDistance = ValueOrExpr.Concrete 455.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/legjav.s3o"
          buildPic = Some "legjav.DDS"
          script = Some "Units/legjav.cob"
          corpse = Some "DEAD"
          explodeAs = Some "explosiont3med"
          selfDestructAs = Some "explosiont3"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "50 72 50"
          collisionVolumeType = Some "CYLY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 68.0
          maxAcc = 0.185
          maxDec = 0.775
          turnRate = 600.0
          movementClass = "HABOT5"
          maxSlope = 17.0
          maxWaterDepth = 32.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.98
          weapons = [
                { name = "mg_guns"
                  displayName = "Twin Rapid-fire Machine Guns"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "default", 12.0
                  ]
                  range = Some (ValueOrExpr.Concrete 450.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.4)
                  weaponVelocity = Some 964.0
                  areaOfEffect = Some 32.0
                  accuracy = Some 7.0
                  turret = Some true
                  tolerance = Some 16000.0
                  edgeEffectiveness = Some 0.5
                  impulseFactor = Some 1.5
                  noSelfDamage = Some true
                  soundStart = Some "mgun12"
                  soundHit = Some "bimpact3"
                  explosiongenerator = Some "custom:plasmahit-sparkonly"
                  rgbColor = Some "1 0.95 0.4"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_burstcontrolwhenoutofarc", "2.0"
                      "mount_fastautoretargeting", "true"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "burst", "12.0"
                      "burstrate", "0.033"
                      "burnblow", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "0.05"
                      "fallOffRate", "0.2"
                      "firestarter", "0.0"
                      "intensity", "0.8"
                      "ownerExpAccWeight", "4.0"
                      "proximitypriority", "1.0"
                      "soundhitwet", "splshbig"
                      "soundstartvolume", "6.0"
                      "soundtrigger", "true"
                      "sprayangle", "1024.0"
                      "texture1", "shot"
                      "texture2", "empty"
                      "thickness", "3.0"
                  ] }
                { name = "aa_gun"
                  displayName = "Light AA Rotary Gun"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "default", 0.0
                      "vtol", 10.0
                  ]
                  range = Some (ValueOrExpr.Concrete 700.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.4)
                  weaponVelocity = Some 950.0
                  areaOfEffect = Some 16.0
                  accuracy = Some 100.0
                  turret = Some true
                  tolerance = Some 12000.0
                  edgeEffectiveness = Some 0.85
                  impulseFactor = Some 1.5
                  noSelfDamage = Some true
                  soundStart = Some "minigun3"
                  soundHit = Some "bimpact3"
                  explosiongenerator = Some "custom:plasmahit-sparkonly"
                  rgbColor = Some "1 0.33 0.7"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfeature", "false"
                      "burst", "6.0"
                      "burstrate", "0.075"
                      "burnblow", "false"
                      "canattackground", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "0.05"
                      "fallOffRate", "0.2"
                      "firestarter", "0.0"
                      "firetolerance", "12000.0"
                      "intensity", "0.8"
                      "ownerExpAccWeight", "4.0"
                      "predictboost", "0.5"
                      "proximitypriority", "1.0"
                      "soundhitwet", "splshbig"
                      "soundstartvolume", "3.0"
                      "sprayangle", "900.0"
                      "texture1", "shot"
                      "texture2", "empty"
                      "thickness", "3.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -2 0"
                  collisionVolumeScales = Some "54 24 54"
                  collisionVolumeType = Some "Box"
                  damage = Some 2400.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 860.0
                  object_ = Some "Units/legjav_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "40 40 40"
                  collisionVolumeType = Some "Sphere"
                  damage = Some 1200.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 280.0
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
                ok = ["mavbok1"]
                select = ["mavbsel1"] }
          customParams = Map.ofList [
                "maxrange", "450"
                "model_author", "Tharsis"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/T3"
                "techlevel", "3.0"
                "unitgroup", "weapon"
                "weapon1turretx", "90.0"
                "weapon1turrety", "150.0"
            ]
          extras = Map.ofList [
                "cantbetransported", "true"
                "mass", "1200.0"
                "nochasecategory", "VTOL"
                "upright", "true"
            ] }

    let legjavDef : UnitDef =
        { name = "legjav"
          subfolder = "Legion/T3"
          metalCost = ValueOrExpr.Concrete 1200.0
          energyCost = ValueOrExpr.Concrete 21000.0
          buildTime = ValueOrExpr.Concrete 39850.0
          health = ValueOrExpr.Concrete 7200.0
          sightDistance = ValueOrExpr.Concrete 455.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/legjav.s3o"
          buildPic = Some "legjav.DDS"
          script = Some "Units/legjav.cob"
          corpse = Some "DEAD"
          explodeAs = Some "explosiont3med"
          selfDestructAs = Some "explosiont3"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "50 72 50"
          collisionVolumeType = Some "CYLY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 68.0
              maxAcc = 0.185
              maxDec = 0.775
              turnRate = 600.0
              movementClass = Some "HABOT5"
              maxSlope = Some 17.0
              maxWaterDepth = Some 32.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.98
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "mg_guns"
                displayName = "Twin Rapid-fire Machine Guns"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 12.0
                ]
                range = Some (ValueOrExpr.Concrete 450.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.4)
                weaponVelocity = Some 964.0
                areaOfEffect = Some 32.0
                accuracy = Some 7.0
                turret = Some true
                tolerance = Some 16000.0
                edgeEffectiveness = Some 0.5
                impulseFactor = Some 1.5
                noSelfDamage = Some true
                soundStart = Some "mgun12"
                soundHit = Some "bimpact3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "1 0.95 0.4"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_burstcontrolwhenoutofarc", "2.0"
                    "mount_fastautoretargeting", "true"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "burst", "12.0"
                    "burstrate", "0.033"
                    "burnblow", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.05"
                    "fallOffRate", "0.2"
                    "firestarter", "0.0"
                    "intensity", "0.8"
                    "ownerExpAccWeight", "4.0"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "6.0"
                    "soundtrigger", "true"
                    "sprayangle", "1024.0"
                    "texture1", "shot"
                    "texture2", "empty"
                    "thickness", "3.0"
                ] }
              { name = "aa_gun"
                displayName = "Light AA Rotary Gun"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 0.0
                    "vtol", 10.0
                ]
                range = Some (ValueOrExpr.Concrete 700.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.4)
                weaponVelocity = Some 950.0
                areaOfEffect = Some 16.0
                accuracy = Some 100.0
                turret = Some true
                tolerance = Some 12000.0
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 1.5
                noSelfDamage = Some true
                soundStart = Some "minigun3"
                soundHit = Some "bimpact3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "1 0.33 0.7"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "burst", "6.0"
                    "burstrate", "0.075"
                    "burnblow", "false"
                    "canattackground", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.05"
                    "fallOffRate", "0.2"
                    "firestarter", "0.0"
                    "firetolerance", "12000.0"
                    "intensity", "0.8"
                    "ownerExpAccWeight", "4.0"
                    "predictboost", "0.5"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "3.0"
                    "sprayangle", "900.0"
                    "texture1", "shot"
                    "texture2", "empty"
                    "thickness", "3.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -2 0"
                collisionVolumeScales = Some "54 24 54"
                collisionVolumeType = Some "Box"
                damage = Some 2400.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 860.0
                object_ = Some "Units/legjav_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "40 40 40"
                collisionVolumeType = Some "Sphere"
                damage = Some 1200.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 280.0
                object_ = Some "Units/arm3X3F.s3o"
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
              ok = ["mavbok1"]
              select = ["mavbsel1"] })
          customParams = Map.ofList [
              "maxrange", "450"
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/T3"
              "techlevel", "3.0"
              "unitgroup", "weapon"
              "weapon1turretx", "90.0"
              "weapon1turrety", "150.0"
          ]
          extras = Map.ofList [
              "cantbetransported", "true"
              "mass", "1200.0"
              "nochasecategory", "VTOL"
              "upright", "true"
          ] }

    let legjavToFlat (def: UnitDef) : Legjav =
        { name = def.name
          subfolder = def.subfolder
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
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let legjavToUnitDef (flat: Legjav) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
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
              movementClass = Some flat.movementClass
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit
              cruiseAltitude = None
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

    type Legkeres =
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

    let legkeres : Legkeres =
        { name = "legkeres"
          subfolder = "Legion/T3"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 0.0
          buildTime = ValueOrExpr.Concrete 60000.0
          health = ValueOrExpr.Concrete 0.0
          sightDistance = ValueOrExpr.Concrete 650.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/LEGKERES.s3o"
          buildPic = Some "LEGKERES.DDS"
          script = Some "Units/LEGKERES.cob"
          corpse = Some "DEAD"
          explodeAs = Some "explosiont3"
          selfDestructAs = Some "explosiont3xl"
          collisionVolumeOffsets = Some "0 -2 0"
          collisionVolumeScales = Some "52 34 64"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 48.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 220.0
          movementClass = "HTANK4"
          maxSlope = 16.0
          maxWaterDepth = 20.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.7
          weapons = [
                { name = "legkeres_cannon"
                  displayName = "Heavy riot cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "bombers", 50.0
                      "default", 400.0
                      "fighters", 50.0
                      "subs", 150.0
                      "vtol", 50.0
                  ]
                  range = Some (ValueOrExpr.Concrete 450.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.7)
                  weaponVelocity = Some 650.0
                  areaOfEffect = Some 200.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.9
                  impulseFactor = Some 2.4
                  noSelfDamage = Some true
                  soundStart = Some "largegun"
                  soundHit = Some "xplomed1"
                  explosiongenerator = Some "custom:genericshellexplosion-large"
                  rgbColor = Some "1 0.7 0.25"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "soundhitwet", "splslrg"
                      "soundhitvolume", "14.0"
                      "soundstartvolume", "13.0"
                      "separation", "2.0"
                      "nogap", "false"
                      "size", "4.0"
                      "sizeDecay", "0.06"
                      "stages", "9.0"
                      "alphaDecay", "0.1"
                  ] }
                { name = "legkeres_gatling"
                  displayName = "Heavy rotary cannon"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "default", 10.0
                  ]
                  range = Some (ValueOrExpr.Concrete 481.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.4)
                  weaponVelocity = Some 900.0
                  areaOfEffect = Some 16.0
                  accuracy = Some 2.0
                  turret = Some true
                  tolerance = Some 6000.0
                  edgeEffectiveness = Some 0.85
                  impulseFactor = Some 1.5
                  noSelfDamage = Some true
                  soundStart = Some "mgun6"
                  soundHit = Some "bimpact3"
                  explosiongenerator = Some "custom:plasmahit-sparkonly"
                  rgbColor = Some "1 0.95 0.4"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "NOTSUB"
                      "mount_burstcontrolwhenoutofarc", "2.0"
                      "mount_fastautoretargeting", "true"
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_slaveTo", "1.0"
                      "avoidfeature", "false"
                      "burst", "6.0"
                      "burstrate", "0.066"
                      "burnblow", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "0.038"
                      "fallOffRate", "0.2"
                      "firestarter", "0.0"
                      "intensity", "0.8"
                      "ownerExpAccWeight", "4.0"
                      "proximitypriority", "1.0"
                      "soundhitwet", "splshbig"
                      "soundstartvolume", "4.5"
                      "soundtrigger", "true"
                      "sprayangle", "1200.0"
                      "texture1", "shot"
                      "texture2", "empty"
                      "thickness", "2.0"
                  ] }
                { name = "legkeres_gatling"
                  displayName = "Heavy rotary cannon"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "default", 10.0
                  ]
                  range = Some (ValueOrExpr.Concrete 481.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.4)
                  weaponVelocity = Some 900.0
                  areaOfEffect = Some 16.0
                  accuracy = Some 2.0
                  turret = Some true
                  tolerance = Some 6000.0
                  edgeEffectiveness = Some 0.85
                  impulseFactor = Some 1.5
                  noSelfDamage = Some true
                  soundStart = Some "mgun6"
                  soundHit = Some "bimpact3"
                  explosiongenerator = Some "custom:plasmahit-sparkonly"
                  rgbColor = Some "1 0.95 0.4"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "NOTSUB"
                      "mount_burstcontrolwhenoutofarc", "2.0"
                      "mount_fastautoretargeting", "true"
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_slaveTo", "1.0"
                      "avoidfeature", "false"
                      "burst", "6.0"
                      "burstrate", "0.066"
                      "burnblow", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "0.038"
                      "fallOffRate", "0.2"
                      "firestarter", "0.0"
                      "intensity", "0.8"
                      "ownerExpAccWeight", "4.0"
                      "proximitypriority", "1.0"
                      "soundhitwet", "splshbig"
                      "soundstartvolume", "4.5"
                      "soundtrigger", "true"
                      "sprayangle", "1200.0"
                      "texture1", "shot"
                      "texture2", "empty"
                      "thickness", "2.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "52 30 64"
                  collisionVolumeType = Some "Box"
                  damage = Some 20000.0
                  featureDead = Some "HEAP"
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 25.0
                  metal = Some 1500.0
                  object_ = Some "Units/legkeres_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = Some "-1.01699066162 -0.66435255127 0.0775146484375"
                  collisionVolumeScales = Some "23.8865509033 22.2328948975 29.3510131836"
                  collisionVolumeType = Some "Box"
                  damage = Some 8000.0
                  featureDead = None
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 4.0
                  metal = Some 800.0
                  object_ = Some "Units/cor4X4C.s3o"
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
                "normaltex", "unittextures/leg_normal.dds"
                "paralyzemultiplier", "0.5"
                "model_author", "EnderRobo"
                "techlevel", "3.0"
            ]
          extras = Map.ofList [
                "acceleration", "0.02"
                "brakerate", "0.04"
                "buildcostenergy", "57000.0"
                "buildcostmetal", "2600.0"
                "cantbetransported", "true"
                "leavetracks", "true"
                "maxdamage", "21000.0"
                "nochasecategory", "VTOL"
                "trackoffset", "16.0"
                "trackstrength", "7.0"
                "tracktype", "armacv_tracks"
                "trackwidth", "70.0"
            ] }

    let legkeresDef : UnitDef =
        { name = "legkeres"
          subfolder = "Legion/T3"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 0.0
          buildTime = ValueOrExpr.Concrete 60000.0
          health = ValueOrExpr.Concrete 0.0
          sightDistance = ValueOrExpr.Concrete 650.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/LEGKERES.s3o"
          buildPic = Some "LEGKERES.DDS"
          script = Some "Units/LEGKERES.cob"
          corpse = Some "DEAD"
          explodeAs = Some "explosiont3"
          selfDestructAs = Some "explosiont3xl"
          collisionVolumeOffsets = Some "0 -2 0"
          collisionVolumeScales = Some "52 34 64"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 48.0
              maxAcc = 0.0
              maxDec = 0.0
              turnRate = 220.0
              movementClass = Some "HTANK4"
              maxSlope = Some 16.0
              maxWaterDepth = Some 20.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.7
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "legkeres_cannon"
                displayName = "Heavy riot cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "bombers", 50.0
                    "default", 400.0
                    "fighters", 50.0
                    "subs", 150.0
                    "vtol", 50.0
                ]
                range = Some (ValueOrExpr.Concrete 450.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.7)
                weaponVelocity = Some 650.0
                areaOfEffect = Some 200.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.9
                impulseFactor = Some 2.4
                noSelfDamage = Some true
                soundStart = Some "largegun"
                soundHit = Some "xplomed1"
                explosiongenerator = Some "custom:genericshellexplosion-large"
                rgbColor = Some "1 0.7 0.25"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "soundhitwet", "splslrg"
                    "soundhitvolume", "14.0"
                    "soundstartvolume", "13.0"
                    "separation", "2.0"
                    "nogap", "false"
                    "size", "4.0"
                    "sizeDecay", "0.06"
                    "stages", "9.0"
                    "alphaDecay", "0.1"
                ] }
              { name = "legkeres_gatling"
                displayName = "Heavy rotary cannon"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 10.0
                ]
                range = Some (ValueOrExpr.Concrete 481.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.4)
                weaponVelocity = Some 900.0
                areaOfEffect = Some 16.0
                accuracy = Some 2.0
                turret = Some true
                tolerance = Some 6000.0
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 1.5
                noSelfDamage = Some true
                soundStart = Some "mgun6"
                soundHit = Some "bimpact3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "1 0.95 0.4"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTSUB"
                    "mount_burstcontrolwhenoutofarc", "2.0"
                    "mount_fastautoretargeting", "true"
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_slaveTo", "1.0"
                    "avoidfeature", "false"
                    "burst", "6.0"
                    "burstrate", "0.066"
                    "burnblow", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.038"
                    "fallOffRate", "0.2"
                    "firestarter", "0.0"
                    "intensity", "0.8"
                    "ownerExpAccWeight", "4.0"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "4.5"
                    "soundtrigger", "true"
                    "sprayangle", "1200.0"
                    "texture1", "shot"
                    "texture2", "empty"
                    "thickness", "2.0"
                ] }
              { name = "legkeres_gatling"
                displayName = "Heavy rotary cannon"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 10.0
                ]
                range = Some (ValueOrExpr.Concrete 481.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.4)
                weaponVelocity = Some 900.0
                areaOfEffect = Some 16.0
                accuracy = Some 2.0
                turret = Some true
                tolerance = Some 6000.0
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 1.5
                noSelfDamage = Some true
                soundStart = Some "mgun6"
                soundHit = Some "bimpact3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "1 0.95 0.4"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTSUB"
                    "mount_burstcontrolwhenoutofarc", "2.0"
                    "mount_fastautoretargeting", "true"
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_slaveTo", "1.0"
                    "avoidfeature", "false"
                    "burst", "6.0"
                    "burstrate", "0.066"
                    "burnblow", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.038"
                    "fallOffRate", "0.2"
                    "firestarter", "0.0"
                    "intensity", "0.8"
                    "ownerExpAccWeight", "4.0"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "4.5"
                    "soundtrigger", "true"
                    "sprayangle", "1200.0"
                    "texture1", "shot"
                    "texture2", "empty"
                    "thickness", "2.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "52 30 64"
                collisionVolumeType = Some "Box"
                damage = Some 20000.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 25.0
                metal = Some 1500.0
                object_ = Some "Units/legkeres_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = Some "-1.01699066162 -0.66435255127 0.0775146484375"
                collisionVolumeScales = Some "23.8865509033 22.2328948975 29.3510131836"
                collisionVolumeType = Some "Box"
                damage = Some 8000.0
                featureDead = None
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 4.0
                metal = Some 800.0
                object_ = Some "Units/cor4X4C.s3o"
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
              ok = ["tcormove"]
              select = ["tcorsel"] })
          customParams = Map.ofList [
              "unitgroup", "weapon"
              "normaltex", "unittextures/leg_normal.dds"
              "paralyzemultiplier", "0.5"
              "model_author", "EnderRobo"
              "techlevel", "3.0"
          ]
          extras = Map.ofList [
              "acceleration", "0.02"
              "brakerate", "0.04"
              "buildcostenergy", "57000.0"
              "buildcostmetal", "2600.0"
              "cantbetransported", "true"
              "leavetracks", "true"
              "maxdamage", "21000.0"
              "nochasecategory", "VTOL"
              "trackoffset", "16.0"
              "trackstrength", "7.0"
              "tracktype", "armacv_tracks"
              "trackwidth", "70.0"
          ] }

    let legkeresToFlat (def: UnitDef) : Legkeres =
        { name = def.name
          subfolder = def.subfolder
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
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let legkeresToUnitDef (flat: Legkeres) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
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
              movementClass = Some flat.movementClass
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit
              cruiseAltitude = None
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

