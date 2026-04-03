// Auto-generated BAR unit data: CorBots
namespace BarData.V1.Units

open BarData.V1

module CorBots =

    let corak : UnitDef =
        { name = "corak"
          subfolder = "CorBots"
          metalCost = ValueOrExpr.Concrete 42.0
          energyCost = ValueOrExpr.Concrete 820.0
          buildTime = ValueOrExpr.Concrete 1250.0
          health = ValueOrExpr.Concrete 280.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORAK.s3o"
          buildPic = Some "CORAK.DDS"
          script = Some "Units/CORAK.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallexplosiongeneric"
          selfDestructAs = Some "smallExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -2 0"
          collisionVolumeScales = Some "24 32 24"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 81.0
              maxAcc = 0.4
              maxDec = 0.7
              turnRate = 1200.0
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
              { name = "gator_laser"
                displayName = Some "Laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 37.0
                    "vtol", 7.0
                ]
                range = Some (ValueOrExpr.Concrete 215.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.5)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrlit3"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-small-red"
                rgbColor = Some "1 0 0"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_fastquerypointupdate", "true"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamtime", "0.1"
                    "beamttl", "1.0"
                    "corethickness", "0.14"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "0.0"
                    "firestarter", "50.0"
                    "impactonly", "1.0"
                    "laserflaresize", "4.4"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "1.7"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -2 0"
                collisionVolumeScales = Some "28 24 24"
                collisionVolumeType = Some "Box"
                damage = Some 156.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 22.0
                object_ = Some "Units/corak_dead.s3o"
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
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorBots"
              "unitgroup", "weapon"
              "weapon1turretx", "300.0"
              "weapon1turrety", "300.0"
          ]
          extras = Map.ofList [
              "nochasecategory", "VTOL"
              "upright", "true"
          ] }

    let corck : UnitDef =
        { name = "corck"
          subfolder = "CorBots"
          metalCost = ValueOrExpr.Concrete 120.0
          energyCost = ValueOrExpr.Concrete 1750.0
          buildTime = ValueOrExpr.Concrete 3550.0
          health = ValueOrExpr.Concrete 750.0
          sightDistance = ValueOrExpr.Concrete 299.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORCK.s3o"
          buildPic = Some "CORCK.DDS"
          script = Some "Units/CORCK.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallexplosiongeneric-builder"
          selfDestructAs = Some "smallExplosionGenericSelfd-builder"
          collisionVolumeOffsets = Some "0 0 -1"
          collisionVolumeScales = Some "25 31 25"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 34.5
              maxAcc = 0.5244
              maxDec = 3.2775
              turnRate = 1201.75
              movementClass = Some "BOT2"
              maxSlope = Some 20.0
              maxWaterDepth = Some 25.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 0.759
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 85.0
              buildDistance = Some 130.0
              buildOptions = ["corsolar"; "coradvsol"; "corwin"; "corgeo"; "cormstor"; "corestor"; "cormex"; "corexp"; "cormakr"; "coralab"; "corlab"; "corvp"; "corap"; "corhp"; "cornanotc"; "coreyes"; "corrad"; "cordrag"; "cormaw"; "corllt"; "corhllt"; "corhlt"; "corpun"; "corrl"; "cormadsam"; "corerad"; "cordl"; "corjamt"; "corjuno"; "corsy"]
              terraformSpeed = Some 450.0 })
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 7.0)
              metalMake = None
              energyStorage = Some 50.0
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "30 15 30"
                collisionVolumeType = Some "Box"
                damage = Some 454.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 73.0
                object_ = Some "Units/corck_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 277.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 29.0
                object_ = Some "Units/cor2X2F.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = Some "nanlath2"
              repair = Some "repair2"
              working = Some "reclaim1"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = Some "capture2"
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["kbcormov"]
              select = ["kbcorsel"] })
          customParams = Map.ofList [
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorBots"
              "unitgroup", "builder"
          ]
          extras = Map.ofList [
              "upright", "true"
          ] }

    let corcrash : UnitDef =
        { name = "corcrash"
          subfolder = "CorBots"
          metalCost = ValueOrExpr.Concrete 125.0
          energyCost = ValueOrExpr.Concrete 1100.0
          buildTime = ValueOrExpr.Concrete 1900.0
          health = ValueOrExpr.Concrete 640.0
          sightDistance = ValueOrExpr.Concrete 379.60001
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORCRASH.s3o"
          buildPic = Some "CORCRASH.DDS"
          script = Some "Units/CORCRASH.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallexplosiongeneric-phib"
          selfDestructAs = Some "smallExplosionGenericSelfd-phib"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "30 32 30"
          collisionVolumeType = Some "CYLY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 53.49
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
                    "mount_badtargetcategory", "NOTAIR LIGHTAIRSCOUT"
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
              { name = "corbot_missile"
                displayName = Some "Missiles"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 110.0
                ]
                range = Some (ValueOrExpr.Concrete 760.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.0)
                weaponVelocity = Some 850.0
                areaOfEffect = Some 48.0
                accuracy = None
                turret = Some true
                tolerance = Some 9000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "rocklit1"
                soundHit = Some "xplosml2"
                explosiongenerator = Some "custom:genericshellexplosion-tiny-aa"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR LIGHTAIRSCOUT"
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
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
                    "smokeperiod", "5.0"
                    "smokesize", "4.4"
                    "smoketime", "12.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splshbig"
                    "startvelocity", "650.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa"
                    "tracks", "true"
                    "turnrate", "63000.0"
                    "weaponacceleration", "141.0"
                    "weapontimer", "5.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "30 28 30"
                collisionVolumeType = Some "CYLY"
                damage = Some 448.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 75.0
                object_ = Some "Units/corcrash_dead.s3o"
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
              "model_author", "Beherith"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorBots"
              "unitgroup", "aa"
          ]
          extras = Map.ofList [
              "airsightdistance", "800.0"
              "movestate", "0.0"
              "nochasecategory", "NOTAIR"
              "upright", "true"
          ] }

    let cornecro : UnitDef =
        { name = "cornecro"
          subfolder = "CorBots"
          metalCost = ValueOrExpr.Concrete 130.0
          energyCost = ValueOrExpr.Concrete 1400.0
          buildTime = ValueOrExpr.Concrete 2800.0
          health = ValueOrExpr.Concrete 220.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORNECRO.s3o"
          buildPic = Some "CORNECRO.DDS"
          script = Some "Units/CORNECRO.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallbuilder"
          selfDestructAs = Some "smallbuilderSelfd"
          collisionVolumeOffsets = Some "0 -2 1"
          collisionVolumeScales = Some "28 34 28"
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
                collisionVolumeOffsets = Some "0 -2 0"
                collisionVolumeScales = Some "28 24 28"
                collisionVolumeType = Some "Box"
                damage = Some 794.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 72.0
                object_ = Some "Units/cornecro_dead.s3o"
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
              "model_author", "Beherith"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorBots"
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

    let corstorm : UnitDef =
        { name = "corstorm"
          subfolder = "CorBots"
          metalCost = ValueOrExpr.Concrete 110.0
          energyCost = ValueOrExpr.Concrete 1150.0
          buildTime = ValueOrExpr.Concrete 1950.0
          health = ValueOrExpr.Concrete 740.0
          sightDistance = ValueOrExpr.Concrete 344.5
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORSTORM.s3o"
          buildPic = Some "CORSTORM.DDS"
          script = Some "Units/CORSTORM.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallexplosiongeneric"
          selfDestructAs = Some "smallExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 -2"
          collisionVolumeScales = Some "22 28 22"
          collisionVolumeType = Some "cylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 47.7
              maxAcc = 0.1242
              maxDec = 0.6486
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
              { name = "cor_bot_rocket"
                displayName = Some "Rockets"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 157.0
                ]
                range = Some (ValueOrExpr.Concrete 475.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.8)
                weaponVelocity = Some 190.0
                areaOfEffect = Some 48.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "rocklit1"
                soundHit = Some "xplosml2"
                explosiongenerator = Some "custom:genericshellexplosion-small"
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
                    "castshadow", "true"
                    "cegtag", "missiletrailsmall-simple"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "70.0"
                    "intensity", "1.0"
                    "metalpershot", "0.0"
                    "model", "cormissile2.s3o"
                    "smokecolor", "1.0"
                    "smokeperiod", "11.0"
                    "smokesize", "3.3"
                    "smoketime", "28.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splshbig"
                    "startvelocity", "190.0"
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
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "20 18 30"
                collisionVolumeType = Some "box"
                damage = Some 402.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 55.0
                object_ = Some "Units/corstorm_dead.s3o"
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
                metal = Some 22.0
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
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorBots"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "movestate", "0.0"
              "nochasecategory", "VTOL"
              "upright", "true"
          ] }

    let corthud : UnitDef =
        { name = "corthud"
          subfolder = "CorBots"
          metalCost = ValueOrExpr.Concrete 140.0
          energyCost = ValueOrExpr.Concrete 1150.0
          buildTime = ValueOrExpr.Concrete 2100.0
          health = ValueOrExpr.Concrete 1100.0
          sightDistance = ValueOrExpr.Concrete 380.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORTHUD.s3o"
          buildPic = Some "CORTHUD.DDS"
          script = Some "Units/CORTHUD.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallExplosionGeneric"
          selfDestructAs = Some "smallExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "29 32 29"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 45.0
              maxAcc = 0.12995
              maxDec = 0.77625
              turnRate = 1263.84998
              movementClass = Some "BOT3"
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
              { name = "arm_ham"
                displayName = Some "PlasmaCannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 104.0
                    "vtol", 21.0
                ]
                range = Some (ValueOrExpr.Concrete 380.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.73333)
                weaponVelocity = Some 286.0
                areaOfEffect = Some 36.0
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
                    "predictboost", "0.4"
                    "soundhitwet", "splshbig"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "25 18 35"
                collisionVolumeType = Some "Box"
                damage = Some 640.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 96.0
                object_ = Some "Units/corthud_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 370.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 38.0
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
              "model_author", "jjackVII"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorBots"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "mass", "300.0"
              "nochasecategory", "VTOL"
              "upright", "true"
          ] }

    let all : (string * UnitDef) list =
        [
            "corak", corak
            "corck", corck
            "corcrash", corcrash
            "cornecro", cornecro
            "corstorm", corstorm
            "corthud", corthud
        ]
