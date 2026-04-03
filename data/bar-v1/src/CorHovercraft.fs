// Auto-generated BAR unit data: CorHovercraft
namespace BarData.V1.Units

open BarData.V1

module CorHovercraft =

    let corah : UnitDef =
        { name = "corah"
          subfolder = "CorHovercraft"
          metalCost = ValueOrExpr.Concrete 250.0
          energyCost = ValueOrExpr.Concrete 4700.0
          buildTime = ValueOrExpr.Concrete 3650.0
          health = ValueOrExpr.Concrete 1120.0
          sightDistance = ValueOrExpr.Concrete 509.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORAH.s3o"
          buildPic = Some "CORAH.DDS"
          script = Some "Units/CORAH.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallexplosiongeneric"
          selfDestructAs = Some "smallExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "28 16 35"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 88.5
              maxAcc = 0.06316
              maxDec = 0.06316
              turnRate = 470.0
              movementClass = Some "HOVER3"
              maxSlope = Some 16.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 2.2044
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "bogus_missile"
                displayName = Some "Missiles"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = Some (ValueOrExpr.Concrete 800.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.5)
                weaponVelocity = Some 650.0
                areaOfEffect = Some 48.0
                accuracy = None
                turret = Some true
                tolerance = Some 9000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = None
                soundStart = None
                soundHit = None
                explosiongenerator = None
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "LIGHTAIRSCOUT"
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "canattackground", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "metalpershot", "0.0"
                    "soundhitwet", "splshbig"
                    "startvelocity", "450.0"
                    "turnrate", "33000.0"
                    "weaponacceleration", "101.0"
                    "weapontimer", "0.1"
                ] }
              { name = "corah_weapon"
                displayName = Some "Missiles"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 62.0
                ]
                range = Some (ValueOrExpr.Concrete 700.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.2)
                weaponVelocity = Some 670.0
                areaOfEffect = Some 48.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "rockhvy2"
                soundHit = Some "xplomed2"
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
                    "burst", "3.0"
                    "burstrate", "0.2"
                    "canattackground", "false"
                    "castshadow", "false"
                    "cegtag", "missiletrailaa"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "70.0"
                    "flighttime", "1.75"
                    "metalpershot", "0.0"
                    "model", "cormissile.s3o"
                    "smokecolor", "0.95"
                    "smokeperiod", "6.0"
                    "smokesize", "4.2"
                    "smoketime", "11.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splshbig"
                    "startvelocity", "450.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa"
                    "tracks", "true"
                    "turnrate", "63000.0"
                    "weaponacceleration", "164.0"
                    "weapontimer", "5.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -1 0"
                collisionVolumeScales = Some "28 18 35"
                collisionVolumeType = Some "Box"
                damage = Some 605.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 154.0
                object_ = Some "Units/corah_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 303.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 62.0
                object_ = Some "Units/cor3X3B.s3o"
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
              ok = ["hovmdok2"]
              select = ["hovmdsl2"] })
          customParams = Map.ofList [
              "model_author", "Beherith"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorHovercraft"
              "unitgroup", "aa"
          ]
          extras = Map.ofList [
              "airsightdistance", "800.0"
              "movestate", "0.0"
              "nochasecategory", "NOTAIR"
              "sonardistance", "350.0"
              "usepiececollisionvolumes", "1.0"
          ] }

    let corch : UnitDef =
        { name = "corch"
          subfolder = "CorHovercraft"
          metalCost = ValueOrExpr.Concrete 190.0
          energyCost = ValueOrExpr.Concrete 3000.0
          buildTime = ValueOrExpr.Concrete 4580.0
          health = ValueOrExpr.Concrete 1490.0
          sightDistance = ValueOrExpr.Concrete 338.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORCH.s3o"
          buildPic = Some "CORCH.DDS"
          script = Some "Units/CORCH.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallexplosiongeneric-builder"
          selfDestructAs = Some "smallExplosionGenericSelfd-builder"
          collisionVolumeOffsets = Some "0 1 0"
          collisionVolumeScales = Some "27 26 40"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 60.899
              maxAcc = 0.03792
              maxDec = 0.11
              turnRate = 410.0
              movementClass = Some "HOVER3"
              maxSlope = Some 16.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.518
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 115.0
              buildDistance = Some 150.0
              buildOptions = ["corsolar"; "coradvsol"; "corwin"; "corgeo"; "cormstor"; "corestor"; "cormex"; "corexp"; "cormakr"; "corlab"; "corvp"; "corap"; "corhp"; "cornanotc"; "cornanotcplat"; "coreyes"; "corrad"; "cordrag"; "cormaw"; "corllt"; "corhllt"; "corhlt"; "corpun"; "corrl"; "cormadsam"; "corerad"; "cordl"; "corjamt"; "corjuno"; "corfhp"; "corsy"; "coramsub"; "corplat"; "cortide"; "corfmkr"; "coruwms"; "coruwes"; "corfdrag"; "corfrad"; "corfhlt"; "corfrt"; "cortl"; "coravp"; "corasy"; "coruwgeo"]
              terraformSpeed = Some 550.0 })
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 11.0)
              metalMake = None
              energyStorage = Some 75.0
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "27 18 38"
                collisionVolumeType = Some "Box"
                damage = Some 805.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 100.0
                object_ = Some "Units/corch_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 403.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 40.0
                object_ = Some "Units/cor3X3D.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = Some "nanlath1"
              repair = Some "repair1"
              working = Some "reclaim1"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["hovmdok2"]
              select = ["hovmdsl2"] })
          customParams = Map.ofList [
              "model_author", "Beherith"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorHovercraft"
              "unitgroup", "builder"
          ]
          extras = Map.ofList [
              "radardistance", "50.0"
          ] }

    let corhal : UnitDef =
        { name = "corhal"
          subfolder = "CorHovercraft"
          metalCost = ValueOrExpr.Concrete 640.0
          energyCost = ValueOrExpr.Concrete 13000.0
          buildTime = ValueOrExpr.Concrete 12900.0
          health = ValueOrExpr.Concrete 4350.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORHAL.s3o"
          buildPic = Some "CORHAL.DDS"
          script = Some "Units/CORHAL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumExplosionGeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 1 0"
          collisionVolumeScales = Some "42 12 42"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 45.3
              maxAcc = 0.02428
              maxDec = 0.02428
              turnRate = 410.0
              movementClass = Some "HOVER3"
              maxSlope = Some 16.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 0.9768
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "cor_canlaser"
                displayName = Some "HighEnergyLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 275.0
                    "vtol", 25.0
                ]
                range = Some (ValueOrExpr.Concrete 300.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.8)
                weaponVelocity = Some 700.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrhvy3"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-medium-green"
                rgbColor = Some "0 1 0"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamtime", "0.15"
                    "corethickness", "0.2"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "45.0"
                    "firestarter", "90.0"
                    "impactonly", "1.0"
                    "laserflaresize", "7.7"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.7"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 1 0"
                collisionVolumeScales = Some "42 18 42"
                collisionVolumeType = Some "Box"
                damage = Some 2079.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 390.0
                object_ = Some "Units/corhal_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 1040.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = None
                metal = Some 156.0
                object_ = Some "Units/cor3X3A.s3o"
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
              ok = ["hovlgok2"]
              select = ["hovlgsl2"] })
          customParams = Map.ofList [
              "model_author", "Beherith"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorHovercraft"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "nochasecategory", "VTOL"
              "usepiececollisionvolumes", "1.0"
          ] }

    let cormh : UnitDef =
        { name = "cormh"
          subfolder = "CorHovercraft"
          metalCost = ValueOrExpr.Concrete 200.0
          energyCost = ValueOrExpr.Concrete 3300.0
          buildTime = ValueOrExpr.Concrete 3500.0
          health = ValueOrExpr.Concrete 550.0
          sightDistance = ValueOrExpr.Concrete 509.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORMH.s3o"
          buildPic = Some "CORMH.DDS"
          script = Some "Units/CORMH.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -3 0"
          collisionVolumeScales = Some "38 20 38"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 63.9
              maxAcc = 0.04415
              maxDec = 0.04415
              turnRate = 455.0
              movementClass = Some "HOVER3"
              maxSlope = Some 16.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.5972
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "cormh_weapon"
                displayName = Some "Rocket"
                weaponType = Some "StarburstLauncher"
                damage = Map.ofList [
                    "default", 550.0
                    "subs", 250.0
                ]
                range = Some (ValueOrExpr.Concrete 700.0)
                reloadTime = Some (ValueOrExpr.Concrete 9.0)
                weaponVelocity = Some 480.0
                areaOfEffect = Some 80.0
                accuracy = None
                turret = None
                tolerance = Some 4000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "Rockhvy1"
                soundHit = Some "xplomed4"
                explosiongenerator = Some "custom:genericshellexplosion-medium-bomb"
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
                    "castshadow", "true"
                    "cegtag", "missiletrailsmall-starburst"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "100.0"
                    "firesubmersed", "true"
                    "flighttime", "10.0"
                    "metalpershot", "0.0"
                    "model", "corkbmissl1.s3o"
                    "smokecolor", "0.7"
                    "smokeperiod", "9.0"
                    "smokesize", "10.0"
                    "smoketime", "28.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splssml"
                    "texture1", "null"
                    "texture2", "smoketrailbar"
                    "texture3", "null"
                    "turnrate", "15000.0"
                    "weaponacceleration", "70.0"
                    "weapontimer", "2.9"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 1 0"
                collisionVolumeScales = Some "38 17 38"
                collisionVolumeType = Some "Box"
                damage = Some 297.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 119.0
                object_ = Some "Units/cormh_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 149.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 48.0
                object_ = Some "Units/cor3X3C.s3o"
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
              ok = ["hovmdok2"]
              select = ["hovmdsl2"] })
          customParams = Map.ofList [
              "model_author", "Beherith"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorHovercraft"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "movestate", "0.0"
              "nochasecategory", "VTOL"
          ] }

    let corsh : UnitDef =
        { name = "corsh"
          subfolder = "CorHovercraft"
          metalCost = ValueOrExpr.Concrete 75.0
          energyCost = ValueOrExpr.Concrete 1500.0
          buildTime = ValueOrExpr.Concrete 1500.0
          health = ValueOrExpr.Concrete 255.0
          sightDistance = ValueOrExpr.Concrete 550.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORSH.s3o"
          buildPic = Some "CORSH.DDS"
          script = Some "Units/CORSH.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallExplosionGeneric"
          selfDestructAs = Some "smallExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -3 0"
          collisionVolumeScales = Some "18 15 30"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 109.5
              maxAcc = 0.10226
              maxDec = 0.10226
              turnRate = 615.0
              movementClass = Some "HOVER2"
              maxSlope = Some 16.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 2.8116
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "armsh_weapon"
                displayName = Some "Light Close-Quarters Fast-Firing g2g Laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 36.0
                    "vtol", 7.0
                ]
                range = Some (ValueOrExpr.Concrete 230.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.6)
                weaponVelocity = Some 450.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrfast"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-small-yellow"
                rgbColor = Some "1 1 0.3"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamtime", "0.1"
                    "burstrate", "0.2"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.02"
                    "energypershot", "0.0"
                    "firestarter", "50.0"
                    "impactonly", "1.0"
                    "laserflaresize", "4.5"
                    "rgbcolor2", "1 0.55 0.3"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "1.25"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 1 0"
                collisionVolumeScales = Some "18 16 30"
                collisionVolumeType = Some "Box"
                damage = Some 162.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 40.0
                object_ = Some "Units/corsh_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 81.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 16.0
                object_ = Some "Units/cor3X3A.s3o"
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
              ok = ["hovsmok2"]
              select = ["hovsmsl2"] })
          customParams = Map.ofList [
              "model_author", "Beherith"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorHovercraft"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "nochasecategory", "VTOL"
          ] }

    let corsnap : UnitDef =
        { name = "corsnap"
          subfolder = "CorHovercraft"
          metalCost = ValueOrExpr.Concrete 300.0
          energyCost = ValueOrExpr.Concrete 3100.0
          buildTime = ValueOrExpr.Concrete 3500.0
          health = ValueOrExpr.Concrete 1720.0
          sightDistance = ValueOrExpr.Concrete 491.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORSNAP.s3o"
          buildPic = Some "CORSNAP.DDS"
          script = Some "Units/CORSNAP.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 1 0"
          collisionVolumeScales = Some "32 16 38"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 66.99
              maxAcc = 0.04624
              maxDec = 0.04624
              turnRate = 500.0
              movementClass = Some "HOVER3"
              maxSlope = Some 16.0
              maxWaterDepth = Some 0.0
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
              { name = "armanac_weapon"
                displayName = Some "MediumPlasmaCannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 98.0
                    "vtol", 29.0
                ]
                range = Some (ValueOrExpr.Concrete 370.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.4)
                weaponVelocity = Some 260.0
                areaOfEffect = Some 32.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "canlite3"
                soundHit = Some "xplosml3"
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
                    "gravityaffected", "true"
                    "soundhitwet", "splshbig"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 1 0"
                collisionVolumeScales = Some "32 16 38"
                collisionVolumeType = Some "Box"
                damage = Some 877.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 192.0
                object_ = Some "Units/corsnap_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 439.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 77.0
                object_ = Some "Units/cor3X3D.s3o"
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
              ok = ["hovmdok2"]
              select = ["hovmdsl2"] })
          customParams = Map.ofList [
              "model_author", "Beherith"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorHovercraft"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "nochasecategory", "VTOL"
              "usepiececollisionvolumes", "1.0"
          ] }

    let all : (string * UnitDef) list =
        [
            "corah", corah
            "corch", corch
            "corhal", corhal
            "cormh", cormh
            "corsh", corsh
            "corsnap", corsnap
        ]
