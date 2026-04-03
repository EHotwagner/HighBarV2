// Auto-generated BAR unit data: Legion/Bots
namespace BarData.V1.Units

open BarData.V1

module Legion_Bots =

    let legaabot : UnitDef =
        { name = "legaabot"
          subfolder = "Legion/Bots"
          metalCost = ValueOrExpr.Concrete 120.0
          energyCost = ValueOrExpr.Concrete 950.0
          buildTime = ValueOrExpr.Concrete 1800.0
          health = ValueOrExpr.Concrete 610.0
          sightDistance = ValueOrExpr.Concrete 379.60001
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/legaabot.s3o"
          buildPic = Some "legaabot.DDS"
          script = Some "Units/legaabot.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallexplosiongeneric-phib"
          selfDestructAs = Some "smallExplosionGenericSelfd-phib"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "20 28 18"
          collisionVolumeType = Some "CYLY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 55.0
              maxAcc = 0.138
              maxDec = 0.6486
              turnRate = 1278.79993
              movementClass = Some "ABOT3"
              maxSlope = Some 15.0
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.17678
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "light_antiair_missile"
                displayName = Some "Advanced g2a Salvo Missile Launcher"
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
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR LIGHTAIRSCOUT"
                    "mount_onlytargetcategory", "VTOL"
                    "mount_fastautoretargeting", "true"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "burst", "3.0"
                    "burstrate", "0.005"
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
                    "weaponacceleration", "300.0"
                    "weapontimer", "2.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "20 28 18"
                collisionVolumeType = Some "CYLY"
                damage = Some 448.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 75.0
                object_ = Some "Units/legaabot_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 274.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 30.0
                object_ = Some "Units/cor2X2A.s3o"
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
              ok = ["kbcormov"]
              select = ["kbcorsel"] })
          customParams = Map.ofList [
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Bots"
              "unitgroup", "aa"
          ]
          extras = Map.ofList [
              "airsightdistance", "800.0"
              "movestate", "0.0"
              "nochasecategory", "NOTAIR"
              "upright", "true"
          ] }

    let legbal : UnitDef =
        { name = "legbal"
          subfolder = "Legion/Bots"
          metalCost = ValueOrExpr.Concrete 160.0
          energyCost = ValueOrExpr.Concrete 1920.0
          buildTime = ValueOrExpr.Concrete 2400.0
          health = ValueOrExpr.Concrete 900.0
          sightDistance = ValueOrExpr.Concrete 344.5
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/LEGBAL.s3o"
          buildPic = Some "LEGBAL.DDS"
          script = Some "Units/LEGBAL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallexplosiongeneric"
          selfDestructAs = Some "smallExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -2 -1"
          collisionVolumeScales = Some "26 36 20"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 43.5
              maxAcc = 0.11
              maxDec = 0.6
              turnRate = 1268.44995
              movementClass = Some "BOT2"
              maxSlope = Some 14.0
              maxWaterDepth = Some 21.0
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
              { name = "leg_bot_rocket"
                displayName = Some "Rockets"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 250.0
                ]
                range = Some (ValueOrExpr.Concrete 460.0)
                reloadTime = Some (ValueOrExpr.Concrete 5.5)
                weaponVelocity = Some 230.0
                areaOfEffect = Some 70.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "rocklit1"
                soundHit = Some "xplosml2"
                explosiongenerator = Some "custom:genericshellexplosion-medium"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "projectile_destruction_method", "descend"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "cegtag", "missiletrailsmall-simple"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "70.0"
                    "intensity", "1.5"
                    "metalpershot", "0.0"
                    "model", "leglargerocket.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "11.0"
                    "smoketime", "28.0"
                    "smokesize", "3.3"
                    "smokecolor", "1.0"
                    "smokeTrailCastShadow", "false"
                    "castshadow", "true"
                    "soundhitwet", "splshbig"
                    "startvelocity", "230.0"
                    "texture1", "null"
                    "texture2", "smoketraildark"
                    "weaponacceleration", "120.0"
                    "weapontimer", "2.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -4 2"
                collisionVolumeScales = Some "22 13 30"
                collisionVolumeType = Some "Box"
                damage = Some 600.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 100.0
                object_ = Some "Units/legbal_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 251.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 40.0
                object_ = Some "Units/cor2X2C.s3o"
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
              ok = ["kbcormov"]
              select = ["kbcorsel"] })
          customParams = Map.ofList [
              "unitgroup", "weapon"
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "CorBots"
          ]
          extras = Map.ofList [
              "nochasecategory", "VTOL"
              "upright", "true"
          ] }

    let legcen : UnitDef =
        { name = "legcen"
          subfolder = "Legion/Bots"
          metalCost = ValueOrExpr.Concrete 140.0
          energyCost = ValueOrExpr.Concrete 2200.0
          buildTime = ValueOrExpr.Concrete 2800.0
          health = ValueOrExpr.Concrete 800.0
          sightDistance = ValueOrExpr.Concrete 400.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/LEGCEN.s3o"
          buildPic = Some "LEGCEN.DDS"
          script = Some "Units/LEGCEN.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumExplosionGeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -6 1"
          collisionVolumeScales = Some "24 24 32"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 90.0
              maxAcc = 0.25
              maxDec = 1.29375
              turnRate = 720.0
              movementClass = Some "BOT2"
              maxSlope = Some 14.0
              maxWaterDepth = Some 12.0
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
              { name = "gauss"
                displayName = Some "Close-quarters g2g gauss-cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 75.0
                    "vtol", 25.0
                ]
                range = Some (ValueOrExpr.Concrete 180.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.4)
                weaponVelocity = Some 550.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = Some 7000.0
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
                    "mount_burstControlWhenOutOfArc", "2.0"
                    "avoidfeature", "false"
                    "burst", "2.0"
                    "burstrate", "0.1"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "fireTolerance", "7000.0"
                    "impactonly", "1.0"
                    "predictboost", "1.0"
                    "size", "2.0"
                    "soundhitwet", "splsmed"
                    "soundstartvolume", "2.0"
                    "sprayangle", "1000.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0 6.0 0.0"
                collisionVolumeScales = Some "32.0 20.0 36.0"
                collisionVolumeType = Some "Box"
                damage = Some 500.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 100.0
                object_ = Some "Units/legcen_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 600.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 40.0
                object_ = Some "Units/arm2X2A.s3o"
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
              "firingceg", "barrelshot-tiny"
              "unitgroup", "weapon"
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "ArmBots"
          ]
          extras = Map.ofList [
              "nochasecategory", "VTOL"
          ] }

    let leggob : UnitDef =
        { name = "leggob"
          subfolder = "Legion/Bots"
          metalCost = ValueOrExpr.Concrete 25.0
          energyCost = ValueOrExpr.Concrete 500.0
          buildTime = ValueOrExpr.Concrete 900.0
          health = ValueOrExpr.Concrete 200.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/LEGGOB.s3o"
          buildPic = Some "LEGGOB.DDS"
          script = Some "Units/LEGGOB.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallexplosiongeneric"
          selfDestructAs = Some "smallExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -2 0"
          collisionVolumeScales = Some "18 22 18"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 75.0
              maxAcc = 0.36
              maxDec = 0.72
              turnRate = 1391.5
              movementClass = Some "BOT2"
              maxSlope = Some 17.0
              maxWaterDepth = Some 25.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.848
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "semiauto"
                displayName = Some "Rapid-fire a2g machine guns"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 12.0
                    "vtol", 4.0
                ]
                range = Some (ValueOrExpr.Concrete 261.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.9)
                weaponVelocity = Some 975.0
                areaOfEffect = Some 16.0
                accuracy = Some 7.0
                turret = Some true
                tolerance = Some 6000.0
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "mgun2"
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
                    "burst", "2.0"
                    "burstrate", "0.1"
                    "burnblow", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.03"
                    "fallOffRate", "0.2"
                    "firestarter", "0.0"
                    "intensity", "0.8"
                    "ownerExpAccWeight", "4.0"
                    "predictboost", "0.5"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "3.0"
                    "soundtrigger", "true"
                    "sprayangle", "1000.0"
                    "texture1", "shot"
                    "texture2", "empty"
                    "thickness", "2.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.114540100098 -2.64214854004 2.11838531494"
                collisionVolumeScales = Some "32.2373809814 13.5927429199 29.8415679932"
                collisionVolumeType = Some "Box"
                damage = Some 120.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 18.0
                object_ = Some "Units/leggob_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 83.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 9.0
                object_ = Some "Units/cor2X2C.s3o"
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
              ok = ["servtny1"]
              select = ["servtny1"] })
          customParams = Map.ofList [
              "unitgroup", "weapon"
              "model_author", "Odin"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "CorBots"
              "weapon1turretx", "300.0"
              "weapon1turrety", "300.0"
          ]
          extras = Map.ofList [
              "nochasecategory", "VTOL"
              "upright", "true"
          ] }

    let legkark : UnitDef =
        { name = "legkark"
          subfolder = "Legion/Bots"
          metalCost = ValueOrExpr.Concrete 330.0
          energyCost = ValueOrExpr.Concrete 2600.0
          buildTime = ValueOrExpr.Concrete 4400.0
          health = ValueOrExpr.Concrete 1725.0
          sightDistance = ValueOrExpr.Concrete 400.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/LEGKARK.s3o"
          buildPic = Some "LEGKARK.DDS"
          script = Some "Units/LEGKARK.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallExplosionGeneric"
          selfDestructAs = Some "smallExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "30 34 30"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 42.0
              maxAcc = 0.095
              maxDec = 0.8211
              turnRate = 900.0
              movementClass = Some "BOT2"
              maxSlope = Some 17.0
              maxWaterDepth = Some 12.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 0.99
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "heat_ray"
                displayName = Some "Light g2g Heat Ray"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 160.0
                    "vtol", 25.0
                ]
                range = Some (ValueOrExpr.Concrete 360.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.0)
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
              { name = "legion_shotgun"
                displayName = Some "Dual-Feed Medium Shotgun"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 20.0
                    "vtol", 6.0
                ]
                range = Some (ValueOrExpr.Concrete 241.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.0)
                weaponVelocity = Some 800.0
                areaOfEffect = Some 16.0
                accuracy = Some 7.0
                turret = Some true
                tolerance = Some 6000.0
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 2.246
                noSelfDamage = Some true
                soundStart = Some "kroggie2xs"
                soundHit = Some "bimpact3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "1 0.95 0.4"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE VTOL"
                    "avoidfeature", "false"
                    "projectiles", "5.0"
                    "burnblow", "false"
                    "burst", "2.0"
                    "burstrate", "0.4"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.015"
                    "fallOffRate", "0.2"
                    "firestarter", "0.0"
                    "intensity", "1.0"
                    "ownerExpAccWeight", "4.0"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "3.0"
                    "sprayangle", "1680.0"
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
                collisionVolumeOffsets = Some "-3.1 1.1 -1.5"
                collisionVolumeScales = Some "33.3 20.0 35.5"
                collisionVolumeType = Some "Box"
                damage = Some 880.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 161.0
                object_ = Some "Units/legkark_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 490.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 64.0
                object_ = Some "Units/arm2X2A.s3o"
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
              "unitgroup", "weapon"
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Bots"
              "weapon1turretx", "200.0"
              "weapon1turrety", "200.0"
              "reactive_armor_health", "300.0"
              "reactive_armor_restore", "15.0"
          ]
          extras = Map.ofList [
              "damagemodifier", "0.5"
              "mass", "210.0"
              "nochasecategory", "VTOL"
          ] }

    let leglob : UnitDef =
        { name = "leglob"
          subfolder = "Legion/Bots"
          metalCost = ValueOrExpr.Concrete 60.0
          energyCost = ValueOrExpr.Concrete 400.0
          buildTime = ValueOrExpr.Concrete 1100.0
          health = ValueOrExpr.Concrete 550.0
          sightDistance = ValueOrExpr.Concrete 380.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/leglob.s3o"
          buildPic = Some "LEGLOB.DDS"
          script = Some "Units/leglob.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallExplosionGeneric"
          selfDestructAs = Some "smallExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "20 18 20"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = Some "BOT MOBILE WEAPON ALL NOTSUB NOTSHIP NOTAIR NOTHOVER SURFACE EMPABLE"
          movement = Some (
            { speed = ValueOrExpr.Concrete 51.0
              maxAcc = 0.12995
              maxDec = 0.77625
              turnRate = 1263.84998
              movementClass = Some "BOT2"
              maxSlope = Some 14.0
              maxWaterDepth = Some 12.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 0.99
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "close_plasma"
                displayName = Some "Forwards Plasma Cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 75.0
                    "vtol", 21.0
                ]
                range = Some (ValueOrExpr.Concrete 400.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.5)
                weaponVelocity = Some 220.0
                areaOfEffect = Some 24.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "cannon1"
                soundHit = Some "xplomed3"
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
                    "mygravity", "0.1"
                    "predictboost", "0.6"
                    "size", "1.8"
                    "soundhitwet", "splshbig"
                ] }
              { name = "far_plasma"
                displayName = Some "Vertical Plasma Cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 75.0
                    "vtol", 21.0
                ]
                range = Some (ValueOrExpr.Concrete 400.0)
                reloadTime = Some (ValueOrExpr.Concrete 5.0)
                weaponVelocity = Some 500.0
                areaOfEffect = Some 48.0
                accuracy = Some 275.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "cannon2"
                soundHit = Some "tawf113a"
                explosiongenerator = Some "custom:genericshellexplosion-small"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "cegtag", "arty-small"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "hightrajectory", "1.0"
                    "mygravity", "0.276"
                    "soundhitwet", "splsmed"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "-1.26663208008 -3.12783955078 2.54402923584"
                collisionVolumeScales = Some "27.809387207 16.8939208984 40.2852935791"
                collisionVolumeType = Some "Box"
                damage = Some 200.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 48.0
                object_ = Some "Units/leglob_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 100.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 24.0
                object_ = Some "Units/cor2X2D.s3o"
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
              ok = ["kbcormov"]
              select = ["kbcorsel"] })
          customParams = Map.ofList [
              "unitgroup", "weapon"
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "CorBots"
          ]
          extras = Map.ofList [
              "leavetracks", "true"
              "mass", "150.0"
              "nochasecategory", "VTOL"
              "upright", "true"
          ] }

    let legrezbot : UnitDef =
        { name = "legrezbot"
          subfolder = "Legion/Bots"
          metalCost = ValueOrExpr.Concrete 130.0
          energyCost = ValueOrExpr.Concrete 1400.0
          buildTime = ValueOrExpr.Concrete 2800.0
          health = ValueOrExpr.Concrete 220.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/legrezbot.s3o"
          buildPic = Some "legrezbot.DDS"
          script = Some "Units/legrezbot.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallbuilder"
          selfDestructAs = Some "smallbuilderSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "18 31 17"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 78.0
              maxAcc = 0.23
              maxDec = 0.8625
              turnRate = 1285.69995
              movementClass = Some "BOT2"
              maxSlope = Some 14.0
              maxWaterDepth = Some 22.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.716
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "18 15 17"
                collisionVolumeType = Some "Box"
                damage = Some 794.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 72.0
                object_ = Some "Units/legrezbot_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 394.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 26.0
                object_ = Some "Units/cor2X2D.s3o"
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
              ok = ["necrok2"]
              select = ["necrsel2"] })
          customParams = Map.ofList [
              "model_author", "ZephyrSkies, Zecrus (Concept)"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Bots"
              "unitgroup", "builder"
          ]
          extras = Map.ofList [
              "autoheal", "5.0"
              "canassist", "false"
              "canresurrect", "true"
              "radardistance", "50.0"
              "stealth", "true"
              "upright", "true"
          ] }

    let all : (string * UnitDef) list =
        [
            "legaabot", legaabot
            "legbal", legbal
            "legcen", legcen
            "leggob", leggob
            "legkark", legkark
            "leglob", leglob
            "legrezbot", legrezbot
        ]
