// Auto-generated BAR unit data: Scavengers/Ships
namespace BarData.Units

open BarData

module Scavengers_Ships =

    let armdecadet3 : UnitDef =
        { name = "armdecadet3"
          subfolder = "Scavengers/Ships"
          metalCost = ValueOrExpr.Concrete 8000.0
          energyCost = ValueOrExpr.Concrete 160000.0
          buildTime = ValueOrExpr.Concrete 90000.0
          health = ValueOrExpr.Concrete 14400.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/scavboss/ARMDECADET3.s3o"
          buildPic = Some "armdecadet3.DDS"
          script = Some "Units/scavboss/ARMDECADET3.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeexplosiongeneric"
          selfDestructAs = Some "hugeexplosiongenericSelfd"
          collisionVolumeOffsets = Some "0 0 -3"
          collisionVolumeScales = Some "52 52 153"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 69.0
              maxAcc = 0.03
              maxDec = 0.03
              turnRate = 180.0
              movementClass = Some "EPICSHIP"
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = true
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 12.0
              waterline = Some 0.0 })
          builder = None
          weapons = Some [
              { name = "armminivulc_weapon"
                displayName = Some "Mini Rapid-fire long-range plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 210.0
                    "shields", 105.0
                ]
                range = Some (ValueOrExpr.Concrete 1300.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.4)
                weaponVelocity = Some 660.0
                areaOfEffect = Some 44.8
                accuracy = Some 700.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.9
                impulseFactor = Some 0.1
                noSelfDamage = Some true
                soundStart = Some "cannon2"
                soundHit = Some "xplomed3"
                explosiongenerator = Some "custom:genericshellexplosion-medium-bomb"
                rgbColor = Some "1, 0.4, 0"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "320.0"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "avoidfriendly", "true"
                    "avoidground", "true"
                    "cegtag", "arty-heavy"
                    "collidefriendly", "false"
                    "craterboost", "0.02"
                    "cratermult", "0.02"
                    "energypershot", "1000.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splshbig"
                    "weapontimer", "14.0"
                ] }
              { name = "armminivulc_weapon"
                displayName = Some "Mini Rapid-fire long-range plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 210.0
                    "shields", 105.0
                ]
                range = Some (ValueOrExpr.Concrete 1300.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.4)
                weaponVelocity = Some 660.0
                areaOfEffect = Some 44.8
                accuracy = Some 700.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.9
                impulseFactor = Some 0.1
                noSelfDamage = Some true
                soundStart = Some "cannon2"
                soundHit = Some "xplomed3"
                explosiongenerator = Some "custom:genericshellexplosion-medium-bomb"
                rgbColor = Some "1, 0.4, 0"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "0 0 -1"
                    "mount_maxangledif", "320.0"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "avoidfriendly", "true"
                    "avoidground", "true"
                    "cegtag", "arty-heavy"
                    "collidefriendly", "false"
                    "craterboost", "0.02"
                    "cratermult", "0.02"
                    "energypershot", "1000.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splshbig"
                    "weapontimer", "14.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -10 -3"
                collisionVolumeScales = Some "52 52 153"
                collisionVolumeType = Some "Box"
                damage = Some 26000.0
                featureDead = Some "HEAP"
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 20.0
                metal = Some 4000.0
                object_ = Some "Units/scavboss/armdecadet3_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 13000.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 2000.0
                object_ = Some "Units/arm6X6D.s3o"
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
              "techlevel", "3.0"
              "subfolder", "ArmShips"
          ]
          extras = Map.ofList [
              "buildangle", "16384.0"
              "nochasecategory", "UNDERWATER VTOL"
          ] }

    let armpshipt3 : UnitDef =
        { name = "armpshipt3"
          subfolder = "Scavengers/Ships"
          metalCost = ValueOrExpr.Concrete 6500.0
          energyCost = ValueOrExpr.Concrete 200000.0
          buildTime = ValueOrExpr.Concrete 70000.0
          health = ValueOrExpr.Concrete 13900.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/scavboss/ARMPSHIPT3.s3o"
          buildPic = Some "armpshipt3.DDS"
          script = Some "Units/scavboss/ARMPSHIPT3.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeexplosiongeneric"
          selfDestructAs = Some "hugeexplosiongenericSelfd"
          collisionVolumeOffsets = Some "0 0 2"
          collisionVolumeScales = Some "52 52 152"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 81.0
              maxAcc = 0.04771
              maxDec = 0.04771
              turnRate = 270.0
              movementClass = Some "EPICSHIP"
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = true
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 6.0
              waterline = Some 0.0 })
          builder = None
          weapons = Some [
              { name = "mech_rapidlaser"
                displayName = Some "Rapid-fire close quarters g2g armor-piercing laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 116.0
                    "vtol", 87.0
                ]
                range = Some (ValueOrExpr.Concrete 475.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.63333)
                weaponVelocity = Some 920.0
                areaOfEffect = Some 32.0
                accuracy = Some 32.0
                turret = Some true
                tolerance = Some 4500.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasfirerc"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-medium-red"
                rgbColor = Some "0.75 0 0"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "LIGHTAIRSCOUT UNDERWATER"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamburst", "true"
                    "beamdecay", "1.0"
                    "beamtime", "0.07"
                    "burst", "6.0"
                    "burstrate", "0.06667"
                    "corethickness", "0.35"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "10.0"
                    "largebeamlaser", "true"
                    "laserflaresize", "8.8"
                    "proximitypriority", "1.0"
                    "pulsespeed", "8.0"
                    "rgbcolor2", "0.9 0.9 0.6"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.4"
                ] }
              { name = "mech_rapidlaser"
                displayName = Some "Rapid-fire close quarters g2g armor-piercing laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 116.0
                    "vtol", 87.0
                ]
                range = Some (ValueOrExpr.Concrete 475.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.63333)
                weaponVelocity = Some 920.0
                areaOfEffect = Some 32.0
                accuracy = Some 32.0
                turret = Some true
                tolerance = Some 4500.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasfirerc"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-medium-red"
                rgbColor = Some "0.75 0 0"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "LIGHTAIRSCOUT UNDERWATER"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "270.0"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamburst", "true"
                    "beamdecay", "1.0"
                    "beamtime", "0.07"
                    "burst", "6.0"
                    "burstrate", "0.06667"
                    "corethickness", "0.35"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "10.0"
                    "largebeamlaser", "true"
                    "laserflaresize", "8.8"
                    "proximitypriority", "1.0"
                    "pulsespeed", "8.0"
                    "rgbcolor2", "0.9 0.9 0.6"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.4"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -8 2"
                collisionVolumeScales = Some "52 52 152"
                collisionVolumeType = Some "Box"
                damage = Some 22000.0
                featureDead = Some "HEAP"
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 4.0
                metal = Some 3750.0
                object_ = Some "Units/scavboss/armpshipt3_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 11000.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 1875.0
                object_ = Some "Units/arm6X6D.s3o"
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
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmShips"
              "techlevel", "3.0"
          ]
          extras = Map.ofList [
              "airsightdistance", "470.0"
              "blocking", "true"
              "nochasecategory", "VTOL UNDERWATER"
          ] }

    let armptt2 : UnitDef =
        { name = "armptt2"
          subfolder = "Scavengers/Ships"
          metalCost = ValueOrExpr.Concrete 2500.0
          energyCost = ValueOrExpr.Concrete 15000.0
          buildTime = ValueOrExpr.Concrete 25000.0
          health = ValueOrExpr.Concrete 6700.0
          sightDistance = ValueOrExpr.Concrete 900.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/scavboss/ARMPTT2.s3o"
          buildPic = Some "armptt2.DDS"
          script = Some "Units/scavboss/ARMPTT2.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeexplosiongeneric"
          selfDestructAs = Some "hugeexplosiongenericSelfd"
          collisionVolumeOffsets = Some "0 -7.5 0"
          collisionVolumeScales = Some "60 60 120"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 72.0
              maxAcc = 0.03
              maxDec = 0.03
              turnRate = 180.0
              movementClass = Some "EPICSHIP"
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = true
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 6.0
              waterline = Some 0.0 })
          builder = None
          weapons = Some [
              { name = "coax_depthcharge"
                displayName = Some "Depthcharge launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 225.0
                ]
                range = Some (ValueOrExpr.Concrete 600.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
                weaponVelocity = Some 200.0
                areaOfEffect = None
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "torpedo1"
                soundHit = Some "xplodep2"
                explosiongenerator = Some "custom:genericshellexplosion-small-uw"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTSUB"
                    "mount_onlytargetcategory", "NOTHOVER"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "bouncerebound", "0.6"
                    "bounceslip", "0.6"
                    "burnblow", "true"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "flighttime", "1.75"
                    "groundbounce", "true"
                    "model", "cordepthcharge.s3o"
                    "numbounce", "1.0"
                    "startvelocity", "300.0"
                    "tracks", "true"
                    "turnrate", "64000.0"
                    "waterweapon", "true"
                ] }
              { name = "coax_depthcharge"
                displayName = Some "Depthcharge launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 225.0
                ]
                range = Some (ValueOrExpr.Concrete 600.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
                weaponVelocity = Some 200.0
                areaOfEffect = None
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "torpedo1"
                soundHit = Some "xplodep2"
                explosiongenerator = Some "custom:genericshellexplosion-small-uw"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTSUB"
                    "mount_onlytargetcategory", "NOTHOVER"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "bouncerebound", "0.6"
                    "bounceslip", "0.6"
                    "burnblow", "true"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "flighttime", "1.75"
                    "groundbounce", "true"
                    "model", "cordepthcharge.s3o"
                    "numbounce", "1.0"
                    "startvelocity", "300.0"
                    "tracks", "true"
                    "turnrate", "64000.0"
                    "waterweapon", "true"
                ] }
              { name = "arm_cir"
                displayName = Some "Rapid-fire long-range g2a missile barrel"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 170.0
                ]
                range = Some (ValueOrExpr.Concrete 1125.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.6)
                weaponVelocity = Some 1300.0
                areaOfEffect = Some 48.0
                accuracy = None
                turret = Some true
                tolerance = Some 100000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "rocklit1"
                soundHit = Some "xplosml2"
                explosiongenerator = Some "custom:genericshellexplosion-tiny-aa"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "LIGHTAIRSCOUT"
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "burst", "4.0"
                    "burstrate", "0.26667"
                    "canattackground", "false"
                    "cegtag", "missiletrailaa"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "20.0"
                    "flighttime", "2.3"
                    "model", "cormissile.s3o"
                    "projectiles", "1.0"
                    "proximitypriority", "-1.0"
                    "smoketrail", "true"
                    "smokePeriod", "5.0"
                    "smoketime", "12.0"
                    "smokesize", "4.8"
                    "smokecolor", "0.95"
                    "smokeTrailCastShadow", "false"
                    "castshadow", "false"
                    "soundhitwet", "splshbig"
                    "soundtrigger", "true"
                    "startvelocity", "250.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa"
                    "tracks", "true"
                    "turnrate", "42000.0"
                    "weaponacceleration", "300.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.255500793457 0.0 -1.26264953613"
                collisionVolumeScales = Some "20.0704803467 16.0 67.0992736816"
                collisionVolumeType = Some "Box"
                damage = Some 12000.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 4.0
                metal = Some 1250.0
                object_ = Some "Units/scavboss/armptt2_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 6000.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 625.0
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
              ok = ["sharmmov"]
              select = ["sharmsel"] })
          customParams = Map.ofList [
              "unitgroup", "weaponaa"
              "maxrange", "260"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "paralyzemultiplier", "0.1"
              "subfolder", "ArmShips"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "airsightdistance", "1200.0"
              "nochasecategory", "VTOL UNDERWATER"
              "stealth", "true"
              "sonardistance", "700.0"
          ] }

    let armserpt3 : UnitDef =
        { name = "armserpt3"
          subfolder = "Scavengers/Ships"
          metalCost = ValueOrExpr.Concrete 15000.0
          energyCost = ValueOrExpr.Concrete 225000.0
          buildTime = ValueOrExpr.Concrete 250000.0
          health = ValueOrExpr.Concrete 26500.0
          sightDistance = ValueOrExpr.Concrete 950.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/scavboss/ARMSERPT3.s3o"
          buildPic = Some "armserpt3.DDS"
          script = Some "Units/scavboss/ARMSERPT3.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumExplosionGeneric-uw"
          selfDestructAs = Some "mediumExplosionGenericSelfd-uw"
          collisionVolumeOffsets = Some "0 -4 0"
          collisionVolumeScales = Some "90 38 114"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 45.0
              maxAcc = 0.02
              maxDec = 0.02
              turnRate = 400.0
              movementClass = Some "EPICSUBMARINE"
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 30.0
              waterline = Some 80.0 })
          builder = None
          weapons = Some [
              { name = "armserp_weapon"
                displayName = Some "Heavy guided torpedo launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 1650.0
                    "subs", 1110.0
                    "commanders", 750.0
                ]
                range = Some (ValueOrExpr.Concrete 800.0)
                reloadTime = Some (ValueOrExpr.Concrete 6.0)
                weaponVelocity = Some 220.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = Some 8000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "torpedo1"
                soundHit = Some "xplodep1"
                explosiongenerator = Some "custom:genericshellexplosion-large-uw"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "HOVER NOTSHIP"
                    "mount_maindir", "0 0.2 1"
                    "mount_maxangledif", "60.0"
                    "mount_onlytargetcategory", "NOTHOVER"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "model", "torpedo.s3o"
                    "startvelocity", "150.0"
                    "tracks", "true"
                    "turnrate", "1750.0"
                    "waterweapon", "true"
                    "weaponacceleration", "25.0"
                    "weapontimer", "3.0"
                ] }
              { name = "armserp_weapon_sub"
                displayName = Some "Heavy guided torpedo launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 1650.0
                    "subs", 1110.0
                    "commanders", 750.0
                ]
                range = Some (ValueOrExpr.Concrete 800.0)
                reloadTime = Some (ValueOrExpr.Concrete 6.0)
                weaponVelocity = Some 220.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = Some 8000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "torpedo1"
                soundHit = Some "xplodep1"
                explosiongenerator = Some "custom:genericshellexplosion-large-uw"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "HOVER NOTSHIP"
                    "mount_maindir", "-0.3826 0.2 0.9238"
                    "mount_maxangledif", "60.0"
                    "mount_onlytargetcategory", "NOTHOVER"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "model", "torpedo.s3o"
                    "startvelocity", "150.0"
                    "tracks", "true"
                    "turnrate", "1750.0"
                    "waterweapon", "true"
                    "weaponacceleration", "25.0"
                    "weapontimer", "3.0"
                ] }
              { name = "armserp_weapon_sub"
                displayName = Some "Heavy guided torpedo launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 1650.0
                    "subs", 1110.0
                    "commanders", 750.0
                ]
                range = Some (ValueOrExpr.Concrete 800.0)
                reloadTime = Some (ValueOrExpr.Concrete 6.0)
                weaponVelocity = Some 220.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = Some 8000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "torpedo1"
                soundHit = Some "xplodep1"
                explosiongenerator = Some "custom:genericshellexplosion-large-uw"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "HOVER NOTSHIP"
                    "mount_maindir", "-0.9238 0.2 0.3826"
                    "mount_maxangledif", "60.0"
                    "mount_onlytargetcategory", "NOTHOVER"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "model", "torpedo.s3o"
                    "startvelocity", "150.0"
                    "tracks", "true"
                    "turnrate", "1750.0"
                    "waterweapon", "true"
                    "weaponacceleration", "25.0"
                    "weapontimer", "3.0"
                ] }
              { name = "armserp_weapon_sub"
                displayName = Some "Heavy guided torpedo launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 1650.0
                    "subs", 1110.0
                    "commanders", 750.0
                ]
                range = Some (ValueOrExpr.Concrete 800.0)
                reloadTime = Some (ValueOrExpr.Concrete 6.0)
                weaponVelocity = Some 220.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = Some 8000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "torpedo1"
                soundHit = Some "xplodep1"
                explosiongenerator = Some "custom:genericshellexplosion-large-uw"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "HOVER NOTSHIP"
                    "mount_maindir", "0.3826 0.2 0.9238"
                    "mount_maxangledif", "60.0"
                    "mount_onlytargetcategory", "NOTHOVER"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "model", "torpedo.s3o"
                    "startvelocity", "150.0"
                    "tracks", "true"
                    "turnrate", "1750.0"
                    "waterweapon", "true"
                    "weaponacceleration", "25.0"
                    "weapontimer", "3.0"
                ] }
              { name = "armserp_weapon_sub"
                displayName = Some "Heavy guided torpedo launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 1650.0
                    "subs", 1110.0
                    "commanders", 750.0
                ]
                range = Some (ValueOrExpr.Concrete 800.0)
                reloadTime = Some (ValueOrExpr.Concrete 6.0)
                weaponVelocity = Some 220.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = Some 8000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "torpedo1"
                soundHit = Some "xplodep1"
                explosiongenerator = Some "custom:genericshellexplosion-large-uw"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "HOVER NOTSHIP"
                    "mount_maindir", "0.9238 0.2 0.3826"
                    "mount_maxangledif", "60.0"
                    "mount_onlytargetcategory", "NOTHOVER"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "model", "torpedo.s3o"
                    "startvelocity", "150.0"
                    "tracks", "true"
                    "turnrate", "1750.0"
                    "waterweapon", "true"
                    "weaponacceleration", "25.0"
                    "weapontimer", "3.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "6.17767333984 -3.80371093733e-06 -10.6119995117"
                collisionVolumeScales = Some "42.614654541 20.1074523926 56.7760009766"
                collisionVolumeType = Some "Box"
                damage = Some 24000.0
                featureDead = Some "HEAP"
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 10.0
                metal = Some 7500.0
                object_ = Some "Units/scavboss/armserpt3_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 12000.0
                featureDead = None
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 4.0
                metal = Some 3750.0
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
              ok = ["suarmmov"]
              select = ["suarmsel"] })
          customParams = Map.ofList [
              "unitgroup", "sub"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmShips/T2"
              "techlevel", "3.0"
          ]
          extras = Map.ofList [
              "nochasecategory", "VTOL"
              "stealth", "true"
              "sonardistance", "800.0"
              "upright", "true"
          ] }

    let coresuppt3 : UnitDef =
        { name = "coresuppt3"
          subfolder = "Scavengers/Ships"
          metalCost = ValueOrExpr.Concrete 30000.0
          energyCost = ValueOrExpr.Concrete 600000.0
          buildTime = ValueOrExpr.Concrete 400000.0
          health = ValueOrExpr.Concrete 89000.0
          sightDistance = ValueOrExpr.Concrete 700.0
          footprintX = 8.0
          footprintZ = 8.0
          objectName = Some "Units/scavboss/CORESUPPT3.s3o"
          buildPic = Some "coresuppt3.DDS"
          script = Some "Units/scavboss/CORESUPPT3.cob"
          corpse = Some "DEAD"
          explodeAs = Some "bantha"
          selfDestructAs = Some "banthaSelfd"
          collisionVolumeOffsets = Some "0 -14 -6"
          collisionVolumeScales = Some "84 84 246"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 75.0
              maxAcc = 0.015
              maxDec = 0.015
              turnRate = 120.0
              movementClass = Some "BOAT9"
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = true
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 12.0
              waterline = Some 0.0 })
          builder = None
          weapons = Some [
              { name = "laser"
                displayName = Some "Ultra Heavy Juggernaut-Spec Heatray"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 1200.0
                    "default", 5500.0
                    "vtol", 2750.0
                ]
                range = Some (ValueOrExpr.Concrete 900.0)
                reloadTime = Some (ValueOrExpr.Concrete 4.0)
                weaponVelocity = Some 1500.0
                areaOfEffect = Some 72.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "heatray2"
                soundHit = None
                explosiongenerator = Some "custom:genericshellexplosion-medium-beam"
                rgbColor = Some "1 0.8 0"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "285.0"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamtime", "0.6"
                    "camerashake", "0.1"
                    "corethickness", "0.35"
                    "craterareaofeffect", "72.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "350.0"
                    "firestarter", "90.0"
                    "laserflaresize", "8.25"
                    "proximitypriority", "-1.0"
                    "rgbcolor2", "0.8 0 0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "6.0"
                ] }
              { name = "laser"
                displayName = Some "Ultra Heavy Juggernaut-Spec Heatray"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 1200.0
                    "default", 5500.0
                    "vtol", 2750.0
                ]
                range = Some (ValueOrExpr.Concrete 900.0)
                reloadTime = Some (ValueOrExpr.Concrete 4.0)
                weaponVelocity = Some 1500.0
                areaOfEffect = Some 72.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "heatray2"
                soundHit = None
                explosiongenerator = Some "custom:genericshellexplosion-medium-beam"
                rgbColor = Some "1 0.8 0"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "0 0 -1"
                    "mount_maxangledif", "285.0"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamtime", "0.6"
                    "camerashake", "0.1"
                    "corethickness", "0.35"
                    "craterareaofeffect", "72.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "350.0"
                    "firestarter", "90.0"
                    "laserflaresize", "8.25"
                    "proximitypriority", "-1.0"
                    "rgbcolor2", "0.8 0 0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "6.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -24 -6"
                collisionVolumeScales = Some "84 84 246"
                collisionVolumeType = Some "Box"
                damage = Some 105000.0
                featureDead = Some "HEAP"
                footprintX = Some 8.0
                footprintZ = Some 8.0
                height = Some 20.0
                metal = Some 15000.0
                object_ = Some "Units/scavboss/coresuppt3_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 50250.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 7500.0
                object_ = Some "Units/cor4X4B.s3o"
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
              ok = ["shcormov"]
              select = ["shcorsel"] })
          customParams = Map.ofList [
              "unitgroup", "weapon"
              "model_author", "ZephyrSkies & Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorShips"
              "techlevel", "3.0"
          ]
          extras = Map.ofList [
              "buildangle", "16384.0"
              "nochasecategory", "UNDERWATER VTOL"
          ] }

    let corslrpc : UnitDef =
        { name = "corslrpc"
          subfolder = "Scavengers/Ships"
          metalCost = ValueOrExpr.Concrete 8000.0
          energyCost = ValueOrExpr.Concrete 80000.0
          buildTime = ValueOrExpr.Concrete 100000.0
          health = ValueOrExpr.Concrete 7200.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 7.0
          footprintZ = 7.0
          objectName = Some "Units/scavboss/CORSLRPC.s3o"
          buildPic = Some "corslrpc.DDS"
          script = Some "Units/scavboss/CORSLRPC.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeBuildingExplosionGeneric"
          selfDestructAs = Some "hugeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 -10"
          collisionVolumeScales = Some "75 75 182"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 33.3
              maxAcc = 0.005
              maxDec = 0.005
              turnRate = 60.0
              movementClass = Some "EPICSHIP"
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = true
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 12.0
              waterline = Some 0.0 })
          builder = None
          weapons = Some [
              { name = "cor_intimidator"
                displayName = Some "Heavy long range g2g AoE plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 2000.0
                    "shields", 1000.0
                    "subs", 300.0
                ]
                range = Some (ValueOrExpr.Concrete 4950.0)
                reloadTime = Some (ValueOrExpr.Concrete 16.0)
                weaponVelocity = Some 1150.0
                areaOfEffect = Some 157.0
                accuracy = Some 335.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.5
                noSelfDamage = Some true
                soundStart = Some "lrpcshot"
                soundHit = Some "xplonuk1xs"
                explosiongenerator = Some "custom:genericshellexplosion-huge"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "cegtag", "arty-huge"
                    "collidefriendly", "false"
                    "craterareaofeffect", "136.0"
                    "craterboost", "0.1"
                    "cratermult", "0.1"
                    "energypershot", "6000.0"
                    "gravityaffected", "true"
                    "heightboostfactor", "6.0"
                    "leadbonus", "0.0"
                    "model", "artshell-large.s3o"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "42.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -11 -10"
                collisionVolumeScales = Some "75 75 182"
                collisionVolumeType = Some "Box"
                damage = Some 13000.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 4.0
                metal = Some 4000.0
                object_ = Some "Units/scavboss/corslrpc_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 6500.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 2000.0
                object_ = Some "Units/cor5X5D.s3o"
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
              ok = ["shcormov"]
              select = ["shcorsel"] })
          customParams = Map.ofList [
              "unitgroup", "weapon"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorShips"
              "techlevel", "3.0"
          ]
          extras = Map.ofList [
              "buildangle", "16384.0"
              "nochasecategory", "VTOL"
              "sonardistance", "400.0"
          ] }

    let all : (string * UnitDef) list =
        [
            "armdecadet3", armdecadet3
            "armpshipt3", armpshipt3
            "armptt2", armptt2
            "armserpt3", armserpt3
            "coresuppt3", coresuppt3
            "corslrpc", corslrpc
        ]
