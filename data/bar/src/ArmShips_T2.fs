// Auto-generated BAR unit data: ArmShips/T2
namespace BarData.Units

open BarData

module ArmShips_T2 =

    let armaas : UnitDef =
        { name = "armaas"
          subfolder = "ArmShips/T2"
          metalCost = ValueOrExpr.Concrete 1000.0
          energyCost = ValueOrExpr.Concrete 12000.0
          buildTime = ValueOrExpr.Concrete 21000.0
          health = ValueOrExpr.Concrete 3900.0
          sightDistance = ValueOrExpr.Concrete 475.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMAAS.s3o"
          buildPic = Some "ARMAAS.DDS"
          script = Some "Units/ARMAAS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeExplosionGeneric-uw"
          selfDestructAs = Some "largeExplosionGenericSelfd-uw"
          collisionVolumeOffsets = Some "0 -5 -1"
          collisionVolumeScales = Some "31 31 74"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 63.0
              maxAcc = 0.03875
              maxDec = 0.03875
              turnRate = 405.0
              movementClass = Some "BOAT4"
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = true
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.344
              cruiseAltitude = None
              minWaterDepth = Some 30.0
              waterline = Some 0.0 })
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
                    "turnrate", "49500.0"
                    "weaponacceleration", "101.0"
                    "weapontimer", "0.1"
                ] }
              { name = "ga2"
                displayName = Some "Long-range g2a guided missile launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 63.0
                ]
                range = Some (ValueOrExpr.Concrete 840.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.8)
                weaponVelocity = Some 880.0
                areaOfEffect = Some 64.0
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
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "burst", "2.0"
                    "burstrate", "0.4"
                    "canattackground", "false"
                    "castshadow", "false"
                    "cegtag", "missiletrailaa"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "0.0"
                    "firestarter", "72.0"
                    "flighttime", "1.75"
                    "metalpershot", "0.0"
                    "model", "cormissile.s3o"
                    "smokecolor", "0.95"
                    "smokeperiod", "6.0"
                    "smokesize", "4.2"
                    "smoketime", "11.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splssml"
                    "soundtrigger", "true"
                    "startvelocity", "200.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa"
                    "tracks", "true"
                    "turnrate", "68000.0"
                    "weaponacceleration", "500.0"
                    "weapontimer", "5.0"
                ] }
              { name = "mobileflak"
                displayName = Some "Heavy g2a flak cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "vtol", 200.0
                ]
                range = Some (ValueOrExpr.Concrete 790.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.73333)
                weaponVelocity = Some 1300.0
                areaOfEffect = Some 140.0
                accuracy = Some 1000.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 1.0
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "flakfire"
                soundHit = Some "flakhit"
                explosiongenerator = Some "custom:flak"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR LIGHTAIRSCOUT"
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "cegtag", "flaktrailaa"
                    "craterareaofeffect", "140.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splsmed"
                    "stages", "0.0"
                    "weapontimer", "1.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "-1.40724182129 -7.7758789061e-06 -0.172019958496"
                collisionVolumeScales = Some "36.1561584473 29.9421844482 83.5312347412"
                collisionVolumeType = Some "Box"
                damage = Some 8320.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 500.0
                object_ = Some "Units/armaas_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 4032.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 250.0
                object_ = Some "Units/arm2X2B.s3o"
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
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmShips/T2"
              "techlevel", "2.0"
              "unitgroup", "aa"
          ]
          extras = Map.ofList [
              "airsightdistance", "900.0"
              "buildangle", "16384.0"
              "movestate", "0.0"
              "nochasecategory", "NOTAIR"
          ] }

    let armacsub : UnitDef =
        { name = "armacsub"
          subfolder = "ArmShips/T2"
          metalCost = ValueOrExpr.Concrete 700.0
          energyCost = ValueOrExpr.Concrete 9000.0
          buildTime = ValueOrExpr.Concrete 23000.0
          health = ValueOrExpr.Concrete 1110.0
          sightDistance = ValueOrExpr.Concrete 156.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMACSUB.s3o"
          buildPic = Some "ARMACSUB.DDS"
          script = Some "Units/ARMACSUB.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallExplosionGeneric-uw"
          selfDestructAs = Some "smallExplosionGenericSelfd-uw"
          collisionVolumeOffsets = Some "0 0 -1"
          collisionVolumeScales = Some "38 38 63"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 72.0
              maxAcc = 0.04428
              maxDec = 0.04428
              turnRate = 405.0
              movementClass = Some "UBOAT4"
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 20.0
              waterline = Some 80.0 })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 350.0
              buildDistance = Some 180.0
              buildOptions = ["armuwfus"; "armuwmmm"; "armuwmme"; "armuwadves"; "armuwadvms"; "armshltxuw"; "armasy"; "armsy"; "armason"; "armfatf"; "armatl"; "armfflak"; "armkraken"; "armuwageo"]
              terraformSpeed = Some 1500.0 })
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 30.0)
              metalMake = None
              energyStorage = Some 150.0
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0 2.5122070312e-05 0.236854553223"
                collisionVolumeScales = Some "49.0049743652 25.7252502441 71.2612762451"
                collisionVolumeType = Some "Box"
                damage = Some 432.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 350.0
                object_ = Some "Units/armacsub_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 4032.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 175.0
                object_ = Some "Units/arm2X2A.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = Some "nanlath1"
              repair = Some "repair1"
              working = Some "reclaim1"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = Some "capture1"
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["suarmmov"]
              select = ["suarmsel"] })
          customParams = Map.ofList [
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmShips/T2"
              "techlevel", "2.0"
              "unitgroup", "buildert2"
          ]
          extras = Map.ofList [
              "radardistance", "50.0"
          ] }

    let armantiship : UnitDef =
        { name = "armantiship"
          subfolder = "ArmShips/T2"
          metalCost = ValueOrExpr.Concrete 1400.0
          energyCost = ValueOrExpr.Concrete 12000.0
          buildTime = ValueOrExpr.Concrete 27000.0
          health = ValueOrExpr.Concrete 5000.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 7.0
          footprintZ = 7.0
          objectName = Some "Units/ARMANTISHIP.s3o"
          buildPic = Some "ARMANTISHIP.DDS"
          script = Some "Units/ARMANTISHIP.cob"
          corpse = Some "DEAD"
          explodeAs = Some "minifusionExplosion"
          selfDestructAs = Some "minifusionExplosion"
          collisionVolumeOffsets = Some "0 0 2"
          collisionVolumeScales = Some "48 48 140"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 63.0
              maxAcc = 0.01722
              maxDec = 0.01722
              turnRate = 180.0
              movementClass = Some "BOAT5"
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = true
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 15.0
              waterline = Some 0.0 })
          builder = None
          weapons = Some [
              { name = "amd_rocket"
                displayName = Some "ICBM intercepting missile launcher"
                weaponType = Some "StarburstLauncher"
                damage = Map.ofList [
                    "default", 1500.0
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
                    "coverage", "1600.0"
                    "craterareaofeffect", "420.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "7500.0"
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
                    "weapontimer", "2.5"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 300.0)
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
                object_ = Some "Units/armantiship_dead.s3o"
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
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmShips/T2"
              "techlevel", "2.0"
              "unitgroup", "antinuke"
              "restrictions_exclusion", "_noantinuke_"
          ]
          extras = Map.ofList [
              "buildangle", "16384.0"
              "canassist", "false"
              "canattack", "false"
              "canreclaim", "false"
              "canrepair", "false"
              "canrestore", "false"
              "energypershot", "7500.0"
              "mass", "10000.0"
              "movestate", "0.0"
              "nochasecategory", "ALL"
              "radardistance", "2950.0"
              "radaremitheight", "56.0"
              "sightemitheight", "56.0"
              "sonardistance", "760.0"
          ] }

    let armbats : UnitDef =
        { name = "armbats"
          subfolder = "ArmShips/T2"
          metalCost = ValueOrExpr.Concrete 3300.0
          energyCost = ValueOrExpr.Concrete 22000.0
          buildTime = ValueOrExpr.Concrete 50000.0
          health = ValueOrExpr.Concrete 9800.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/ARMBATS.s3o"
          buildPic = Some "ARMBATS.DDS"
          script = Some "Units/ARMBATS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeexplosiongeneric"
          selfDestructAs = Some "hugeexplosiongenericSelfd"
          collisionVolumeOffsets = Some "-1 -10 4"
          collisionVolumeScales = Some "63 63 144"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 57.9
              maxAcc = 0.01583
              maxDec = 0.01583
              turnRate = 180.0
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
              minWaterDepth = Some 15.0
              waterline = Some 0.0 })
          builder = None
          weapons = Some [
              { name = "arm_bats"
                displayName = Some "Heavy long-range g2g plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 300.0
                    "vtol", 65.0
                ]
                range = Some (ValueOrExpr.Concrete 880.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
                weaponVelocity = Some 470.0
                areaOfEffect = Some 140.0
                accuracy = Some 350.0
                turret = Some true
                tolerance = Some 5000.0
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
                    "mount_badtargetcategory", "VTOL"
                    "mount_fastautoretargeting", "true"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splsmed"
                ] }
              { name = "arm_bats"
                displayName = Some "Heavy long-range g2g plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 300.0
                    "vtol", 65.0
                ]
                range = Some (ValueOrExpr.Concrete 880.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
                weaponVelocity = Some 470.0
                areaOfEffect = Some 140.0
                accuracy = Some 350.0
                turret = Some true
                tolerance = Some 5000.0
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
                    "mount_fastautoretargeting", "true"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "270.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splsmed"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "-16.0281448364 -3.59007536621 -2.5637588501"
                collisionVolumeScales = Some "74.9459686279 67.6992492676 151.322341919"
                collisionVolumeType = Some "Box"
                damage = Some 12972.0
                featureDead = Some "HEAP"
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 4.0
                metal = Some 1650.0
                object_ = Some "Units/armbats_dead.s3o"
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
                metal = Some 825.0
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
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmShips/T2"
              "techlevel", "2.0"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "buildangle", "16384.0"
              "movestate", "0.0"
              "nochasecategory", "VTOL"
          ] }

    let armcarry : UnitDef =
        { name = "armcarry"
          subfolder = "ArmShips/T2"
          metalCost = ValueOrExpr.Concrete 1400.0
          energyCost = ValueOrExpr.Concrete 12000.0
          buildTime = ValueOrExpr.Concrete 27000.0
          health = ValueOrExpr.Concrete 5000.0
          sightDistance = ValueOrExpr.Concrete 1105.0
          footprintX = 7.0
          footprintZ = 7.0
          objectName = Some "Units/ARMCARRY.s3o"
          buildPic = Some "ARMCARRY.DDS"
          script = Some "Units/ARMCARRY.cob"
          corpse = Some "DEAD"
          explodeAs = Some "minifusionExplosion"
          selfDestructAs = Some "minifusionExplosion"
          collisionVolumeOffsets = Some "-1 -7 2"
          collisionVolumeScales = Some "64 64 159"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 63.0
              maxAcc = 0.01722
              maxDec = 0.01722
              turnRate = 180.0
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
              minWaterDepth = Some 15.0
              waterline = Some 0.0 })
          builder = None
          weapons = Some [
              { name = "amd_rocket"
                displayName = Some "ICBM intercepting missile launcher"
                weaponType = Some "StarburstLauncher"
                damage = Map.ofList [
                    "default", 1500.0
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
                    "coverage", "1600.0"
                    "craterareaofeffect", "420.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "7500.0"
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
                    "weapontimer", "2.5"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 300.0)
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
                object_ = Some "Units/armcarry_dead.s3o"
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
              "isairbase", "true"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmShips/T2"
              "techlevel", "2.0"
              "unitgroup", "antinuke"
          ]
          extras = Map.ofList [
              "buildangle", "16384.0"
              "canassist", "false"
              "canattack", "false"
              "canreclaim", "false"
              "canrepair", "false"
              "canrestore", "false"
              "energypershot", "7500.0"
              "energyupkeep", "25.0"
              "mass", "10000.0"
              "movestate", "0.0"
              "nochasecategory", "ALL"
              "radardistance", "2950.0"
              "radaremitheight", "56.0"
              "sightemitheight", "56.0"
              "sonardistance", "760.0"
          ] }

    let armcrus : UnitDef =
        { name = "armcrus"
          subfolder = "ArmShips/T2"
          metalCost = ValueOrExpr.Concrete 1000.0
          energyCost = ValueOrExpr.Concrete 12000.0
          buildTime = ValueOrExpr.Concrete 23000.0
          health = ValueOrExpr.Concrete 5600.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/ARMCRUS.s3o"
          buildPic = Some "ARMCRUS.DDS"
          script = Some "Units/ARMCRUS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeexplosiongeneric"
          selfDestructAs = Some "largeexplosiongenericSelfd"
          collisionVolumeOffsets = Some "0 -8 0"
          collisionVolumeScales = Some "32 32 112"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 60.0
              maxAcc = 0.02952
              maxDec = 0.02952
              turnRate = 270.0
              movementClass = Some "BOAT5"
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = true
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 30.0
              waterline = Some 0.0 })
          builder = None
          weapons = Some [
              { name = "gauss"
                displayName = Some "Long-range g2g gauss cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 220.0
                    "subs", 220.0
                    "vtol", 40.0
                ]
                range = Some (ValueOrExpr.Concrete 500.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.666)
                weaponVelocity = Some 550.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = None
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
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splshbig"
                    "targetmoveerror", "0.1"
                ] }
              { name = "laser"
                displayName = Some "Light close-quarters g2g laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 75.0
                    "vtol", 8.0
                ]
                range = Some (ValueOrExpr.Concrete 430.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.333)
                weaponVelocity = Some 800.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrfir3"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-small-red"
                rgbColor = Some "1 0 0"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamtime", "0.15"
                    "corethickness", "0.175"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "15.0"
                    "firestarter", "30.0"
                    "impactonly", "1.0"
                    "laserflaresize", "9.35"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.5"
                ] }
              { name = "depthcharge"
                displayName = Some "Medium depthcharge launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 225.0
                ]
                range = Some (ValueOrExpr.Concrete 450.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.8)
                weaponVelocity = Some 225.0
                areaOfEffect = Some 32.0
                accuracy = None
                turret = Some false
                tolerance = Some 32767.0
                edgeEffectiveness = Some 0.95
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "torpedo1"
                soundHit = Some "xplodep2"
                explosiongenerator = Some "custom:genericshellexplosion-medium-uw"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "CANBEUW UNDERWATER"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "model", "cordepthcharge.s3o"
                    "startvelocity", "150.0"
                    "tracks", "true"
                    "turnrate", "9800.0"
                    "waterweapon", "true"
                    "weaponacceleration", "25.0"
                    "weapontimer", "10.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "-3.49415588379 -0.469155969238 -4.06915588379"
                collisionVolumeScales = Some "48.6282958984 40.4258880615 146.154632568"
                collisionVolumeType = Some "Box"
                damage = Some 5408.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 4.0
                metal = Some 500.0
                object_ = Some "Units/armcrus_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 4032.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 250.0
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
              ok = ["sharmmov"]
              select = ["sharmsel"] })
          customParams = Map.ofList [
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmShips/T2"
              "techlevel", "2.0"
              "unitgroup", "weaponsub"
          ]
          extras = Map.ofList [
              "buildangle", "16384.0"
              "nochasecategory", "VTOL"
              "sonardistance", "375.0"
          ] }

    let armdronecarry : UnitDef =
        { name = "armdronecarry"
          subfolder = "ArmShips/T2"
          metalCost = ValueOrExpr.Concrete 1700.0
          energyCost = ValueOrExpr.Concrete 17000.0
          buildTime = ValueOrExpr.Concrete 24000.0
          health = ValueOrExpr.Concrete 3500.0
          sightDistance = ValueOrExpr.Concrete 700.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/ARMDRONECARRY.s3o"
          buildPic = Some "ARMDRONECARRY.DDS"
          script = Some "Units/ARMDRONECARRY.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeexplosiongeneric"
          selfDestructAs = Some "hugeexplosiongenericSelfD"
          collisionVolumeOffsets = Some "3 -7 -3"
          collisionVolumeScales = Some "48 48 140"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 63.0
              maxAcc = 0.01722
              maxDec = 0.01722
              turnRate = 180.0
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
              minWaterDepth = Some 15.0
              waterline = Some 0.0 })
          builder = None
          weapons = Some [
              { name = "plasma"
                displayName = Some "HeavyCannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = Some (ValueOrExpr.Concrete 1300.0)
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
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "carried_unit", "armdrone"
                    "spawns_surface", "SEA"
                    "carrierdeaththroe", "release"
                    "dockingpieces", "11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27"
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
                    "metalpershot", "25.0"
                    "energypershot", "600.0"
                    "size", "0.0"
                    "soundhitwet", ""
                    "stockpile", "true"
                    "stockpiletime", "4.0"
                ] }
              { name = "aamissile"
                displayName = Some "Missiles"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 138.0
                ]
                range = Some (ValueOrExpr.Concrete 710.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.0)
                weaponVelocity = Some 450.0
                areaOfEffect = Some 48.0
                accuracy = None
                turret = Some true
                tolerance = Some 8000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "rockhvy2"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:genericshellexplosion-medium-air"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "cegtag", "missiletrailaa"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "70.0"
                    "flighttime", "1.75"
                    "metalpershot", "0.0"
                    "model", "cormissile.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "7.0"
                    "smoketime", "13.0"
                    "smokesize", "5.4"
                    "smokecolor", "0.95"
                    "smokeTrailCastShadow", "false"
                    "castshadow", "false"
                    "soundhitwet", "splshbig"
                    "startvelocity", "430.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa3"
                    "tracks", "true"
                    "turnrate", "30000.0"
                    "weaponacceleration", "90.0"
                    "weapontimer", "5.0"
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
                object_ = Some "Units/armdronecarry_dead.s3o"
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
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmShips/T2"
              "techlevel", "2.0"
              "inheritxpratemultiplier", "1.0"
              "childreninheritxp", "DRONE"
              "parentsinheritxp", "DRONE"
              "restrictions_inclusion", "_noair_"
          ]
          extras = Map.ofList [
              "buildangle", "16384.0"
              "canreclaim", "false"
              "canrepair", "false"
              "canrestore", "false"
              "energyupkeep", "25.0"
              "sightemitheight", "56.0"
              "mass", "10000.0"
              "nochasecategory", "VTOL"
              "radardistance", "1500.0"
              "radaremitheight", "56.0"
              "sonardistance", "700.0"
          ] }

    let armepoch : UnitDef =
        { name = "armepoch"
          subfolder = "ArmShips/T2"
          metalCost = ValueOrExpr.Concrete 20000.0
          energyCost = ValueOrExpr.Concrete 190000.0
          buildTime = ValueOrExpr.Concrete 290000.0
          health = ValueOrExpr.Concrete 50000.0
          sightDistance = ValueOrExpr.Concrete 689.0
          footprintX = 8.0
          footprintZ = 8.0
          objectName = Some "Units/ARMEPOCH.s3o"
          buildPic = Some "ARMEPOCH.DDS"
          script = Some "Units/ARMEPOCH.cob"
          corpse = Some "DEAD"
          explodeAs = Some "flagshipExplosion"
          selfDestructAs = Some "flagshipExplosionSelfd"
          collisionVolumeOffsets = Some "0 -6 3"
          collisionVolumeScales = Some "71 71 180"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 53.85
              maxAcc = 0.01104
              maxDec = 0.01104
              turnRate = 135.0
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
              minWaterDepth = Some 15.0
              waterline = Some 0.0 })
          builder = None
          weapons = Some [
              { name = "heavyplasma"
                displayName = Some "Primary rapid-fire heavy long-range plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 500.0
                    "subs", 100.0
                    "vtol", 200.0
                ]
                range = Some (ValueOrExpr.Concrete 2450.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.5)
                weaponVelocity = Some 600.0
                areaOfEffect = Some 160.0
                accuracy = Some 600.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 1.0
                noSelfDamage = Some true
                soundStart = Some "BERTHA1"
                soundHit = Some "bertha6"
                explosiongenerator = Some "custom:genericshellexplosion-large-aoe"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "burst", "2.0"
                    "burstrate", "0.8"
                    "cegtag", "arty-heavy"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splslrg"
                    "sprayangle", "650.0"
                ] }
              { name = "mediumplasma"
                displayName = Some "Secondary rapid-fire heavy plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 270.0
                    "vtol", 65.0
                ]
                range = Some (ValueOrExpr.Concrete 830.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.2)
                weaponVelocity = Some 570.0
                areaOfEffect = Some 128.0
                accuracy = Some 350.0
                turret = Some true
                tolerance = Some 5000.0
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
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "320.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "cegtag", "arty-fast"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splsmed"
                ] }
              { name = "heavyplasma"
                displayName = Some "Primary rapid-fire heavy long-range plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 500.0
                    "subs", 100.0
                    "vtol", 200.0
                ]
                range = Some (ValueOrExpr.Concrete 2450.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.5)
                weaponVelocity = Some 600.0
                areaOfEffect = Some 160.0
                accuracy = Some 600.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 1.0
                noSelfDamage = Some true
                soundStart = Some "BERTHA1"
                soundHit = Some "bertha6"
                explosiongenerator = Some "custom:genericshellexplosion-large-aoe"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "240.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "burst", "2.0"
                    "burstrate", "0.8"
                    "cegtag", "arty-heavy"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splslrg"
                    "sprayangle", "650.0"
                ] }
              { name = "mediumplasma"
                displayName = Some "Secondary rapid-fire heavy plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 270.0
                    "vtol", 65.0
                ]
                range = Some (ValueOrExpr.Concrete 830.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.2)
                weaponVelocity = Some 570.0
                areaOfEffect = Some 128.0
                accuracy = Some 350.0
                turret = Some true
                tolerance = Some 5000.0
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
                    "mount_maindir", "-4 0 1"
                    "mount_maxangledif", "180.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "cegtag", "arty-fast"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splsmed"
                ] }
              { name = "mediumplasma"
                displayName = Some "Secondary rapid-fire heavy plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 270.0
                    "vtol", 65.0
                ]
                range = Some (ValueOrExpr.Concrete 830.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.2)
                weaponVelocity = Some 570.0
                areaOfEffect = Some 128.0
                accuracy = Some 350.0
                turret = Some true
                tolerance = Some 5000.0
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
                    "mount_maindir", "4 0 1"
                    "mount_maxangledif", "180.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "cegtag", "arty-fast"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splsmed"
                ] }
              { name = "ferret_missile"
                displayName = Some "Pop-up rapid-fire g2a missile launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "commanders", 1.0
                    "vtol", 150.0
                ]
                range = Some (ValueOrExpr.Concrete 840.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.7)
                weaponVelocity = Some 1000.0
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
                    "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                    "mount_maindir", "0 -1 -2"
                    "mount_maxangledif", "270.0"
                    "mount_onlytargetcategory", "VTOL T4AIR"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "burst", "2.0"
                    "burstrate", "0.2"
                    "canattackground", "false"
                    "castshadow", "false"
                    "cegtag", "missiletrailaa"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "0.0"
                    "firestarter", "72.0"
                    "flighttime", "2.5"
                    "metalpershot", "0.0"
                    "model", "cormissile.s3o"
                    "smokecolor", "0.95"
                    "smokeperiod", "6.0"
                    "smokesize", "4.6"
                    "smoketime", "12.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splshbig"
                    "soundtrigger", "true"
                    "startvelocity", "1.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa3"
                    "tracks", "true"
                    "turnrate", "68000.0"
                    "weaponacceleration", "1200.0"
                    "weapontimer", "2.0"
                ] }
              { name = "ferret_missile"
                displayName = Some "Pop-up rapid-fire g2a missile launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "commanders", 1.0
                    "vtol", 150.0
                ]
                range = Some (ValueOrExpr.Concrete 840.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.7)
                weaponVelocity = Some 1000.0
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
                    "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                    "mount_onlytargetcategory", "VTOL T4AIR"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "burst", "2.0"
                    "burstrate", "0.2"
                    "canattackground", "false"
                    "castshadow", "false"
                    "cegtag", "missiletrailaa"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "0.0"
                    "firestarter", "72.0"
                    "flighttime", "2.5"
                    "metalpershot", "0.0"
                    "model", "cormissile.s3o"
                    "smokecolor", "0.95"
                    "smokeperiod", "6.0"
                    "smokesize", "4.6"
                    "smoketime", "12.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splshbig"
                    "soundtrigger", "true"
                    "startvelocity", "1.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa3"
                    "tracks", "true"
                    "turnrate", "68000.0"
                    "weaponacceleration", "1200.0"
                    "weapontimer", "2.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.439918518066 -4.07348632798e-05 0.367340087891"
                collisionVolumeScales = Some "75.0081939697 51.5621185303 178.425750732"
                collisionVolumeType = Some "Box"
                damage = Some 85500.0
                featureDead = Some "HEAP"
                footprintX = Some 6.0
                footprintZ = Some 18.0
                height = Some 4.0
                metal = Some 8500.0
                object_ = Some "Units/armepoch_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 40032.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 4250.0
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
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "paralyzemultiplier", "0.0"
              "subfolder", "ArmShips/T2"
              "techlevel", "2.0"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "buildangle", "16384.0"
              "canattackground", "true"
              "mass", "9999999.0"
              "movestate", "0.0"
              "radardistance", "1530.0"
              "radaremitheight", "52.0"
              "sightemitheight", "52.0"
          ] }

    let armexcalibur : UnitDef =
        { name = "armexcalibur"
          subfolder = "ArmShips/T2"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 0.0
          buildTime = ValueOrExpr.Concrete 18000.0
          health = ValueOrExpr.Concrete 1200.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/armexcalibur.s3o"
          buildPic = Some "armexcalibur.DDS"
          script = Some "Units/armexcalibur.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumExplosionGeneric-uw"
          selfDestructAs = Some "mediumExplosionGenericSelfd-uw"
          collisionVolumeOffsets = Some "0 1 -4"
          collisionVolumeScales = Some "20 15 52"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 60.0
              maxAcc = 0.03
              maxDec = 0.05
              turnRate = 540.0
              movementClass = Some "BOAT3"
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 15.0
              waterline = Some 25.0 })
          builder = None
          weapons = Some [
              { name = "exata"
                displayName = Some "Caliburn s2g tachyon accelerator beam"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 400.0
                    "default", 800.0
                ]
                range = Some (ValueOrExpr.Concrete 600.0)
                reloadTime = Some (ValueOrExpr.Concrete 6.0)
                weaponVelocity = Some 1400.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "annigun1"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-large-blue"
                rgbColor = Some "0 0 1"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "UNDERWATER"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "beamtime", "1.0"
                    "collidefriendly", "false"
                    "corethickness", "0.15"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "400.0"
                    "firestarter", "45.0"
                    "firetolerance", "1000.0"
                    "largebeamlaser", "true"
                    "laserflaresize", "3.5"
                    "scrollspeed", "5.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "texture3", "largebeam"
                    "thickness", "1.5"
                    "tilelength", "150.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 -4"
                collisionVolumeScales = Some "20 15 52"
                collisionVolumeType = Some "Box"
                damage = Some 1362.0
                featureDead = Some "HEAP"
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 4.0
                metal = Some 375.0
                object_ = Some "Units/armexcalibur_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 4032.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 187.0
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
              ok = ["sucormov"]
              select = ["sucorsel"] })
          customParams = Map.ofList [
              "model_author", "Hornet"
              "normaltex", "unittextures/arm_normal.dds"
              "subfolder", "ArmShips/T2"
              "techlevel", "2.0"
              "unitgroup", "sub"
          ]
          extras = Map.ofList [
              "buildcostenergy", "16000.0"
              "buildcostmetal", "900.0"
              "collide", "true"
              "nochasecategory", "VTOL"
              "sonardistance", "200.0"
              "upright", "true"
          ] }

    let armhacs : UnitDef =
        { name = "armhacs"
          subfolder = "ArmShips/T2"
          metalCost = ValueOrExpr.Concrete 1140.0
          energyCost = ValueOrExpr.Concrete 25600.0
          buildTime = ValueOrExpr.Concrete 60000.0
          health = ValueOrExpr.Concrete 2460.0
          sightDistance = ValueOrExpr.Concrete 300.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMMLS.s3o"
          buildPic = Some "ARMMLS.DDS"
          script = Some "Units/ARMMLS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumexplosiongenericSelfd"
          collisionVolumeOffsets = Some "0 -7 2"
          collisionVolumeScales = Some "25 25 70"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 66.0
              maxAcc = 0.04059
              maxDec = 0.04059
              turnRate = 405.0
              movementClass = Some "BOAT4"
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = true
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 15.0
              waterline = Some 2.0 })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 600.0
              buildDistance = Some 250.0
              buildOptions = ["armuwfus"; "armuwmmm"; "armuwmme"; "armuwadves"; "armuwadvms"; "armasy"; "armhasy"; "armfatf"; "armatl"; "armfflak"; "armkraken"; "armuwageo"; "armbanth"; "armafus"; "armtide"; "armanni"; "armpb"; "armmercury"; "armfdrag"; "armgate"; "armsd"; "armlab"; "armvp"; "armap"; "armsy"; "armbrtha"; "armsilo"; "armvulc"; "armshltxuw"]
              terraformSpeed = Some 2000.0 })
          weapons = None
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0 -1.85327148436e-05 2.73946380615"
                collisionVolumeScales = Some "37.140838623 18.7893829346 66.6114349365"
                collisionVolumeType = Some "Box"
                damage = Some 1576.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 95.0
                object_ = Some "Units/armmls_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 4032.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 47.5
                object_ = Some "Units/arm4X4A.s3o"
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
              ok = ["sharmmov"]
              select = ["sharmsel"] })
          customParams = Map.ofList [
              "minesweeper", "600.0"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmShips/T2"
              "techlevel", "3.0"
              "unitgroup", "buildert2"
          ]
          extras = Map.ofList [
              "mass", "2700.0"
              "movestate", "0.0"
          ] }

    let armlship : UnitDef =
        { name = "armlship"
          subfolder = "ArmShips/T2"
          metalCost = ValueOrExpr.Concrete 570.0
          energyCost = ValueOrExpr.Concrete 11400.0
          buildTime = ValueOrExpr.Concrete 15000.0
          health = ValueOrExpr.Concrete 2200.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMLSHIP.s3o"
          buildPic = Some "ARMLSHIP.DDS"
          script = Some "Units/ARMLSHIP.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumExplosionGeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 4"
          collisionVolumeScales = Some "28 30 82"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 99.0
              maxAcc = 0.065
              maxDec = 0.065
              turnRate = 450.0
              movementClass = Some "BOAT4"
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
              { name = "lightning"
                displayName = Some "Close-quarters lightning turret"
                weaponType = Some "LightningCannon"
                damage = Map.ofList [
                    "default", 35.0
                    "subs", 10.0
                ]
                range = Some (ValueOrExpr.Concrete 400.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.4)
                weaponVelocity = Some 400.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lghthvy1"
                soundHit = Some "lashit"
                explosiongenerator = Some "custom:genericshellexplosion-medium-lightning2"
                rgbColor = Some "0.5 0.5 1"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "spark_ceg", "genericshellexplosion-splash-lightning"
                    "spark_forkdamage", "0.5"
                    "spark_maxunits", "2"
                    "spark_range", "100"
                ]
                extras = Map.ofList [
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "330.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "beamttl", "1.0"
                    "burst", "10.0"
                    "burstrate", "0.03333"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "1.0"
                    "energypershot", "10.0"
                    "firestarter", "50.0"
                    "impactonly", "1.0"
                    "intensity", "24.0"
                    "laserflaresize", "5.0"
                    "soundhitwet", "sizzle"
                    "soundtrigger", "true"
                    "thickness", "2.0"
                ] }
              { name = "armamph_missile"
                displayName = Some "Light g2a missile launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 138.0
                ]
                range = Some (ValueOrExpr.Concrete 710.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.0)
                weaponVelocity = Some 850.0
                areaOfEffect = Some 48.0
                accuracy = None
                turret = Some true
                tolerance = Some 9000.0
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
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "castshadow", "false"
                    "cegtag", "missiletrailaa"
                    "collidefriendly", "false"
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
                    "startvelocity", "430.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa3"
                    "tracks", "true"
                    "turnrate", "48000.0"
                    "weaponacceleration", "90.0"
                    "weapontimer", "5.0"
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
                damage = Some 500.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 390.0
                object_ = Some "Units/armlship_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 1032.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 195.0
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
              "model_author", "mightyodin01"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmShips/T2"
              "techlevel", "2.0"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "blocking", "true"
              "nochasecategory", "VTOL UNDERWATER"
              "radardistance", "750.0"
              "radaremitheight", "52.0"
          ] }

    let armmls : UnitDef =
        { name = "armmls"
          subfolder = "ArmShips/T2"
          metalCost = ValueOrExpr.Concrete 190.0
          energyCost = ValueOrExpr.Concrete 3200.0
          buildTime = ValueOrExpr.Concrete 6000.0
          health = ValueOrExpr.Concrete 1460.0
          sightDistance = ValueOrExpr.Concrete 300.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMMLS.s3o"
          buildPic = Some "ARMMLS.DDS"
          script = Some "Units/ARMMLS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumexplosiongenericSelfd"
          collisionVolumeOffsets = Some "0 -7 2"
          collisionVolumeScales = Some "25 25 70"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 66.0
              maxAcc = 0.04059
              maxDec = 0.04059
              turnRate = 405.0
              movementClass = Some "BOAT4"
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = true
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 15.0
              waterline = Some 2.0 })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 200.0
              buildDistance = Some 250.0
              buildOptions = ["armtide"; "armmex"; "armfrad"; "armarad"; "armnanotcplat"; "armsy"; "armcs"; "armtl"; "armfhlt"; "armfflak"; "armpt"; "armdecade"; "armroy"; "armamph"; "armfmine3"; "armamb"; "armkraken"; "armfdrag"]
              terraformSpeed = Some 2000.0 })
          weapons = None
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0 -1.85327148436e-05 2.73946380615"
                collisionVolumeScales = Some "37.140838623 18.7893829346 66.6114349365"
                collisionVolumeType = Some "Box"
                damage = Some 1576.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 95.0
                object_ = Some "Units/armmls_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 4032.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 47.5
                object_ = Some "Units/arm4X4A.s3o"
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
              ok = ["sharmmov"]
              select = ["sharmsel"] })
          customParams = Map.ofList [
              "minesweeper", "600.0"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmShips/T2"
              "techlevel", "2.0"
              "unitgroup", "buildert2"
          ]
          extras = Map.ofList [
              "movestate", "0.0"
          ] }

    let armmship : UnitDef =
        { name = "armmship"
          subfolder = "ArmShips/T2"
          metalCost = ValueOrExpr.Concrete 2000.0
          energyCost = ValueOrExpr.Concrete 10000.0
          buildTime = ValueOrExpr.Concrete 24000.0
          health = ValueOrExpr.Concrete 3350.0
          sightDistance = ValueOrExpr.Concrete 318.5
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/ARMMSHIP.s3o"
          buildPic = Some "ARMMSHIP.DDS"
          script = Some "Units/ARMMSHIP.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeExplosionGeneric"
          selfDestructAs = Some "largeExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -5 0"
          collisionVolumeScales = Some "44 44 80"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 63.0
              maxAcc = 0.0287
              maxDec = 0.0387
              turnRate = 350.0
              movementClass = Some "BOAT5"
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
              { name = "rocket"
                displayName = Some "Heavy long-range g2g starburst rocket launcher"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "commanders", 350.0
                    "default", 650.0
                    "subs", 5.0
                ]
                range = Some (ValueOrExpr.Concrete 1550.0)
                reloadTime = Some (ValueOrExpr.Concrete 6.0)
                weaponVelocity = Some 450.0
                areaOfEffect = Some 300.0
                accuracy = None
                turret = Some true
                tolerance = Some 4000.0
                edgeEffectiveness = Some 0.65
                impulseFactor = Some 1.4
                noSelfDamage = Some true
                soundStart = Some "Rockhvy1"
                soundHit = Some "xplomed4"
                explosiongenerator = Some "custom:genericshellexplosion-large-bomb"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "cegtag", "missiletrailcorroyspecial"
                    "model", "airbomb"
                    "number", "6"
                    "speceffect", "split"
                    "speceffect_def", "armmship_rocket_split"
                    "splitexplosionceg", "genericshellexplosion-medium"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_maindir", "0 .5 1"
                    "mount_maxangledif", "60.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "cegtag", "missiletrailmship"
                    "craterareaofeffect", "300.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "100.0"
                    "flighttime", "15.0"
                    "gravityaffected", "true"
                    "hightrajectory", "1.0"
                    "interceptedbyshieldtype", "1024.0"
                    "metalpershot", "0.0"
                    "model", "corshiprocket.s3o"
                    "smoketrail", "false"
                    "soundhitwet", "splsmed"
                    "texture1", "null"
                    "texture2", "smoketrailbar"
                    "texture3", "null"
                    "turnrate", "24384.0"
                    "weaponacceleration", "80.0"
                    "weapontimer", "5.0"
                ] }
              { name = "missile"
                displayName = Some "Medium Range g2a AA Missiles"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 138.0
                ]
                range = Some (ValueOrExpr.Concrete 710.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.0)
                weaponVelocity = Some 450.0
                areaOfEffect = Some 48.0
                accuracy = None
                turret = Some true
                tolerance = Some 8000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "rockhvy2"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:genericshellexplosion-medium-air"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "burnblow", "true"
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
                    "smokeperiod", "7.0"
                    "smokesize", "5.4"
                    "smoketime", "13.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splshbig"
                    "startvelocity", "430.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa3"
                    "tracks", "true"
                    "turnrate", "30000.0"
                    "weaponacceleration", "90.0"
                    "weapontimer", "5.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "-1.52864837646 2.44506835934e-05 -1.26249694824"
                collisionVolumeScales = Some "46.7322845459 37.6582489014 110.324981689"
                collisionVolumeType = Some "Box"
                damage = Some 2640.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 4.0
                metal = Some 1000.0
                object_ = Some "Units/armmship_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 4032.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 500.0
                object_ = Some "Units/arm4X4B.s3o"
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
              "maxrange", "1650"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmShips/T2"
              "techlevel", "2.0"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "movestate", "0.0"
              "nochasecategory", "VTOL"
              "radardistance", "1000.0"
          ] }

    let armsacsub : UnitDef =
        { name = "armsacsub"
          subfolder = "ArmShips/T2"
          metalCost = ValueOrExpr.Concrete 500.0
          energyCost = ValueOrExpr.Concrete 9000.0
          buildTime = ValueOrExpr.Concrete 22000.0
          health = ValueOrExpr.Concrete 1110.0
          sightDistance = ValueOrExpr.Concrete 156.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMACSUB.s3o"
          buildPic = Some "ARMACSUB.DDS"
          script = Some "Units/ARMACSUB.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallExplosionGeneric-uw"
          selfDestructAs = Some "smallExplosionGenericSelfd-uw"
          collisionVolumeOffsets = Some "0 0 -1"
          collisionVolumeScales = Some "38 38 63"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 72.0
              maxAcc = 0.04428
              maxDec = 0.04428
              turnRate = 405.0
              movementClass = Some "UBOAT4"
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 20.0
              waterline = Some 80.0 })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 300.0
              buildDistance = Some 180.0
              buildOptions = ["armuwmmm"; "armshltxuw"; "armatl"; "armasy"; "armsy"; "armuwageo"; "armsasy"]
              terraformSpeed = Some 1500.0 })
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 30.0)
              metalMake = None
              energyStorage = Some 150.0
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0 2.5122070312e-05 0.236854553223"
                collisionVolumeScales = Some "49.0049743652 25.7252502441 71.2612762451"
                collisionVolumeType = Some "Box"
                damage = Some 432.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 350.0
                object_ = Some "Units/armacsub_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 4032.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 175.0
                object_ = Some "Units/arm2X2A.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = Some "nanlath1"
              repair = Some "repair1"
              working = Some "reclaim1"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = Some "capture1"
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["suarmmov"]
              select = ["suarmsel"] })
          customParams = Map.ofList [
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmShips/T2"
              "techlevel", "2.0"
              "unitgroup", "buildert2"
          ]
          extras = Map.ofList [
              "radardistance", "50.0"
          ] }

    let armseadragon : UnitDef =
        { name = "armseadragon"
          subfolder = "ArmShips/T2"
          metalCost = ValueOrExpr.Concrete 8000.0
          energyCost = ValueOrExpr.Concrete 85000.0
          buildTime = ValueOrExpr.Concrete 190000.0
          health = ValueOrExpr.Concrete 2400.0
          sightDistance = ValueOrExpr.Concrete 400.0
          footprintX = 7.0
          footprintZ = 7.0
          objectName = Some "Units/armseadragon.s3o"
          buildPic = Some "armseadragon.DDS"
          script = Some "Units/armseadragon.cob"
          corpse = Some "DEAD"
          explodeAs = Some "nukeSub"
          selfDestructAs = Some "nukeBuildingSelfd"
          collisionVolumeOffsets = Some "0 -3 -5"
          collisionVolumeScales = Some "32 29 110"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 48.0
              maxAcc = 0.03
              maxDec = 0.05
              turnRate = 340.0
              movementClass = Some "UBOAT4"
              maxSlope = Some 10.0
              maxWaterDepth = Some 9999.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 20.0
              waterline = Some 40.0 })
          builder = None
          weapons = Some [
              { name = "waterballon"
                displayName = Some "Torpedo launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "commanders", 340.0
                    "default", 800.0
                    "subs", 500.0
                ]
                range = Some (ValueOrExpr.Concrete 720.0)
                reloadTime = Some (ValueOrExpr.Concrete 8.0)
                weaponVelocity = Some 290.0
                areaOfEffect = Some 12.0
                accuracy = None
                turret = Some true
                tolerance = Some 8000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "torpedo1"
                soundHit = Some "xplodep1"
                explosiongenerator = Some "custom:genericshellexplosion-medium-uw"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "HOVER NOTSHIP"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "35.0"
                    "mount_onlytargetcategory", "NOTHOVER"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "cegtag", "torpedotrail-small"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "model", "torpedo.s3o"
                    "soundhitvolume", "22.0"
                    "startvelocity", "150.0"
                    "tracks", "true"
                    "turnrate", "2250.0"
                    "waterweapon", "true"
                    "weaponacceleration", "20.0"
                    "weapontimer", "3.0"
                ] }
              { name = "sdmssl"
                displayName = Some "Intercontinental ballistic nuclear warhead"
                weaponType = Some "StarburstLauncher"
                damage = Map.ofList [
                    "commanders", 2500.0
                    "default", 9500.0
                ]
                range = Some (ValueOrExpr.Concrete 72000.0)
                reloadTime = Some (ValueOrExpr.Concrete 30.0)
                weaponVelocity = Some 1600.0
                areaOfEffect = Some 1280.0
                accuracy = None
                turret = None
                tolerance = Some 4000.0
                edgeEffectiveness = Some 0.45
                impulseFactor = Some 0.5
                noSelfDamage = None
                soundStart = Some "nukelaunch"
                soundHit = Some "nukearm"
                explosiongenerator = Some "custom:newnuke"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "place_target_on_ground", "true"
                ]
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "cegtag", "NUKETRAIL"
                    "collideenemy", "false"
                    "collidefeature", "false"
                    "collidefriendly", "false"
                    "commandfire", "true"
                    "craterareaofeffect", "1280.0"
                    "craterboost", "2.4"
                    "cratermult", "1.2"
                    "energypershot", "125000.0"
                    "firestarter", "100.0"
                    "flighttime", "400.0"
                    "metalpershot", "1000.0"
                    "model", "cortronmissile.s3o"
                    "smokecolor", "0.85"
                    "smokeperiod", "10.0"
                    "smokesize", "28.0"
                    "smoketime", "130.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "true"
                    "soundhitwet", "nukewater"
                    "soundhitwetvolume", "53.0"
                    "soundstartvolume", "20.0"
                    "stockpile", "true"
                    "stockpiletime", "140.0"
                    "targetable", "1.0"
                    "texture1", "null"
                    "texture2", "railguntrail"
                    "texture3", "null"
                    "turnrate", "5500.0"
                    "waterweapon", "1.0"
                    "weaponacceleration", "100.0"
                    "weapontimer", "5.5"
                ] }
              { name = "nuclear_launch"
                displayName = Some "Nuclear Launch"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = Some (ValueOrExpr.Concrete 0.0)
                reloadTime = Some (ValueOrExpr.Concrete 30.0)
                weaponVelocity = Some 100.0
                areaOfEffect = Some 0.0
                accuracy = None
                turret = None
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.0
                impulseFactor = Some 0.0
                noSelfDamage = None
                soundStart = None
                soundHit = Some "nukelaunchalarm"
                explosiongenerator = None
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "commandfire", "true"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "metalpershot", "0.0"
                    "soundhitvolume", "50.0"
                    "turnrate", "10000.0"
                    "weaponacceleration", "101.0"
                    "weapontimer", "0.1"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -3 -5"
                collisionVolumeScales = Some "34 31 110"
                collisionVolumeType = Some "Box"
                damage = Some 1362.0
                featureDead = Some "HEAP"
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 4.0
                metal = Some 375.0
                object_ = Some "Units/armseadragon_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 4032.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 187.0
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
              ok = ["servroc1"]
              select = ["servroc1"] })
          customParams = Map.ofList [
              "maxrange", "720"
              "model_author", "Hornet"
              "normaltex", "unittextures/arm_normal.dds"
              "removewait", "true"
              "subfolder", "ArmShips/T2"
              "techlevel", "2.0"
              "unitgroup", "nuke"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
              "canmanualfire", "true"
              "firestate", "2.0"
              "radardistance", "50.0"
              "sonardistance", "1000.0"
              "upright", "true"
          ] }

    let armserp : UnitDef =
        { name = "armserp"
          subfolder = "ArmShips/T2"
          metalCost = ValueOrExpr.Concrete 1800.0
          energyCost = ValueOrExpr.Concrete 27000.0
          buildTime = ValueOrExpr.Concrete 32000.0
          health = ValueOrExpr.Concrete 3550.0
          sightDistance = ValueOrExpr.Concrete 550.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMSERP.s3o"
          buildPic = Some "ARMSERP.DDS"
          script = Some "Units/ARMSERP.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumExplosionGeneric-uw"
          selfDestructAs = Some "mediumExplosionGenericSelfd-uw"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "52 30 57"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 45.0
              maxAcc = 0.02
              maxDec = 0.02
              turnRate = 400.0
              movementClass = Some "UBOAT4"
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 20.0
              waterline = Some 80.0 })
          builder = None
          weapons = Some [
              { name = "armserp_weapon"
                displayName = Some "Heavy guided torpedo launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "commanders", 375.0
                    "default", 825.0
                    "subs", 555.0
                ]
                range = Some (ValueOrExpr.Concrete 800.0)
                reloadTime = Some (ValueOrExpr.Concrete 8.0)
                weaponVelocity = Some 220.0
                areaOfEffect = Some 120.0
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
                    "mount_maxangledif", "80.0"
                    "mount_onlytargetcategory", "NOTHOVER"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "cegtag", "torpedotrail-large"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "model", "torpedo.s3o"
                    "soundhitvolume", "14.0"
                    "startvelocity", "150.0"
                    "tracks", "true"
                    "turnrate", "1750.0"
                    "waterweapon", "true"
                    "weaponacceleration", "25.0"
                    "weapontimer", "3.0"
                ] }
              { name = "armserp_weapon"
                displayName = Some "Heavy guided torpedo launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "commanders", 375.0
                    "default", 825.0
                    "subs", 555.0
                ]
                range = Some (ValueOrExpr.Concrete 800.0)
                reloadTime = Some (ValueOrExpr.Concrete 8.0)
                weaponVelocity = Some 220.0
                areaOfEffect = Some 120.0
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
                    "mount_maxangledif", "80.0"
                    "mount_onlytargetcategory", "NOTHOVER"
                    "mount_slaveto", "1.0"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "cegtag", "torpedotrail-large"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "model", "torpedo.s3o"
                    "soundhitvolume", "14.0"
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
                damage = Some 2000.0
                featureDead = Some "HEAP"
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 10.0
                metal = Some 1000.0
                object_ = Some "Units/armserp_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 4000.0
                featureDead = None
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 4.0
                metal = Some 505.0
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
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmShips/T2"
              "techlevel", "2.0"
              "unitgroup", "sub"
          ]
          extras = Map.ofList [
              "movestate", "0.0"
              "nochasecategory", "VTOL"
              "sonardistance", "400.0"
              "stealth", "true"
              "upright", "true"
          ] }

    let armsjam : UnitDef =
        { name = "armsjam"
          subfolder = "ArmShips/T2"
          metalCost = ValueOrExpr.Concrete 310.0
          energyCost = ValueOrExpr.Concrete 5000.0
          buildTime = ValueOrExpr.Concrete 20000.0
          health = ValueOrExpr.Concrete 1350.0
          sightDistance = ValueOrExpr.Concrete 390.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMSJAM.s3o"
          buildPic = Some "ARMSJAM.DDS"
          script = Some "Units/ARMSJAM.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumexplosiongenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "28 32 64"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 45.0
              maxAcc = 0.04059
              maxDec = 0.04059
              turnRate = 405.0
              movementClass = Some "BOAT3"
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
          weapons = None
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "-0.304229736328 -7.05566407078e-07 -0.0"
                collisionVolumeScales = Some "28.1084594727 19.4736785889 64.0"
                collisionVolumeType = Some "Box"
                damage = Some 612.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 40.0
                metal = Some 55.0
                object_ = Some "Units/armsjam_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 4032.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 27.5
                object_ = Some "Units/arm4X4A.s3o"
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
              select = ["radjam1"] })
          customParams = Map.ofList [
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "off_on_stun", "true"
              "subfolder", "ArmShips/T2"
              "techlevel", "2.0"
              "unitgroup", "util"
          ]
          extras = Map.ofList [
              "energyupkeep", "90.0"
              "nochasecategory", "MOBILE"
              "onoffable", "true"
              "radardistancejam", "980.0"
          ] }

    let armsubk : UnitDef =
        { name = "armsubk"
          subfolder = "ArmShips/T2"
          metalCost = ValueOrExpr.Concrete 950.0
          energyCost = ValueOrExpr.Concrete 17000.0
          buildTime = ValueOrExpr.Concrete 28000.0
          health = ValueOrExpr.Concrete 2350.0
          sightDistance = ValueOrExpr.Concrete 390.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMSUBK.s3o"
          buildPic = Some "ARMSUBK.DDS"
          script = Some "Units/ARMSUBK.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumExplosionGeneric-uw"
          selfDestructAs = Some "mediumExplosionGenericSelfd-uw"
          collisionVolumeOffsets = Some "0 5 0"
          collisionVolumeScales = Some "30 30 64"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 81.0
              maxAcc = 0.05
              maxDec = 0.05
              turnRate = 540.0
              movementClass = Some "UBOAT4"
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 15.0
              waterline = Some 40.0 })
          builder = None
          weapons = Some [
              { name = "armsmart_torpedo"
                displayName = Some "Rapid armor-piercing torpedoes"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 350.0
                ]
                range = Some (ValueOrExpr.Concrete 400.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.0)
                weaponVelocity = Some 200.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some false
                tolerance = Some 9000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "torpedo1"
                soundHit = Some "xplodep1"
                explosiongenerator = Some "custom:genericshellexplosion-medium-uw"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "HOVER NOTSHIP"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "180.0"
                    "mount_onlytargetcategory", "NOTHOVER"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "cegtag", "torpedotrail-small"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "model", "torpedo.s3o"
                    "soundhitvolume", "18.0"
                    "startvelocity", "150.0"
                    "tracks", "true"
                    "turnrate", "1000.0"
                    "waterweapon", "true"
                    "weaponacceleration", "10.0"
                    "weapontimer", "3.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.712867736816 -4.88281237665e-09 -0.00479125976563"
                collisionVolumeScales = Some "19.7231903076 16.8272399902 61.3809509277"
                collisionVolumeType = Some "Box"
                damage = Some 1434.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 475.0
                object_ = Some "Units/armsubk_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 4032.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 240.0
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
              ok = ["suarmmov"]
              select = ["suarmsel"] })
          customParams = Map.ofList [
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmShips/T2"
              "techlevel", "2.0"
              "unitgroup", "sub"
          ]
          extras = Map.ofList [
              "nochasecategory", "VTOL"
              "sonardistance", "525.0"
              "upright", "true"
          ] }

    let armtdrone : UnitDef =
        { name = "armtdrone"
          subfolder = "ArmShips/T2"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 0.0
          buildTime = ValueOrExpr.Concrete 1500.0
          health = ValueOrExpr.Concrete 0.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Units/ARMDRONE.s3o"
          buildPic = Some "ARMKAM.DDS"
          script = Some "Units/ARMDRONE.cob"
          corpse = None
          explodeAs = Some "smallExplosionGeneric"
          selfDestructAs = Some "smallExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.0
              maxAcc = 0.0
              maxDec = 0.0
              turnRate = 1000.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 360.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "td_depthcharge"
                displayName = Some "Depthcharge launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 215.0
                ]
                range = Some (ValueOrExpr.Concrete 200.0)
                reloadTime = Some (ValueOrExpr.Concrete 6.0)
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
                    "mount_maindir", "0 -2 1"
                    "mount_maxangledif", "120.0"
                    "mount_onlytargetcategory", "CANBEUW UNDERWATER"
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
                    "soundhitvolume", "3.0"
                    "soundhitwet", "splsmed"
                    "soundhitwetvolume", "12.0"
                    "startvelocity", "150.0"
                    "tracks", "true"
                    "turnrate", "64000.0"
                    "waterweapon", "true"
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
              "drone", "1.0"
              "model_author", "FireStorm"
              "nohealthbars", "1.0"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmShips/T2"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "acceleration", "0.22"
              "blocking", "false"
              "brakerate", "0.5"
              "buildcostenergy", "750.0"
              "buildcostmetal", "30.0"
              "collide", "true"
              "cruisealt", "40.0"
              "hoverattack", "true"
              "maxdamage", "300.0"
              "maxvelocity", "11.0"
              "nochasecategory", "VTOL"
              "sonardistance", "400.0"
          ] }

    let armtrident : UnitDef =
        { name = "armtrident"
          subfolder = "ArmShips/T2"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 0.0
          buildTime = ValueOrExpr.Concrete 18000.0
          health = ValueOrExpr.Concrete 0.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/armtrident.s3o"
          buildPic = Some "armtrident.dds"
          script = Some "Units/armtrident_clean.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeexplosiongeneric"
          selfDestructAs = Some "hugeexplosiongenericSelfD"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "42 42 84"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.0
              maxAcc = 0.0
              maxDec = 0.0
              turnRate = 180.0
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
              minWaterDepth = Some 15.0
              waterline = Some 0.0 })
          builder = None
          weapons = Some [
              { name = "plasma"
                displayName = Some "Depth Charge Drones"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = Some (ValueOrExpr.Concrete 1300.0)
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
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "carried_unit", "armtdrone"
                    "spawns_surface", "SEA"
                    "carrierdeaththroe", "release"
                    "dockingpieces", "10 11 12 13 14"
                ]
                extras = Map.ofList [
                    "mount_onlytargetcategory", "CANBEUW UNDERWATER"
                    "avoidfeature", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "hightrajectory", "1.0"
                    "metalpershot", "30.0"
                    "energypershot", "750.0"
                    "size", "0.0"
                    "soundhitwet", ""
                    "stockpile", "true"
                    "stockpiletime", "5.0"
                    "waterweapon", "true"
                ] }
              { name = "trident_depthcharge"
                displayName = Some "Depthcharge launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 255.0
                ]
                range = Some (ValueOrExpr.Concrete 600.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.5)
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
                    "mount_onlytargetcategory", "CANBEUW UNDERWATER"
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
                    "soundhitwet", "splsmed"
                    "soundhitvolume", "3.0"
                    "soundhitwetvolume", "12.0"
                    "startvelocity", "300.0"
                    "tracks", "true"
                    "turnrate", "64000.0"
                    "waterweapon", "true"
                ] }
          ]
          economy = None
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
                object_ = Some "Units/armtrident_dead.s3o"
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
              "model_author", "Odin, Hornet"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmShips/T2"
              "techlevel", "2.0"
              "inheritxpratemultiplier", "1.0"
              "childreninheritxp", "DRONE"
              "parentsinheritxp", "DRONE"
          ]
          extras = Map.ofList [
              "acceleration", "0.01722"
              "brakerate", "0.01722"
              "buildangle", "16384.0"
              "buildcostenergy", "10500.0"
              "buildcostmetal", "1050.0"
              "canreclaim", "false"
              "canrepair", "false"
              "canrestore", "false"
              "losemitheight", "56.0"
              "mass", "10000.0"
              "maxdamage", "3400.0"
              "maxvelocity", "2.25"
              "nochasecategory", "VTOL"
              "sonardistance", "620.0"
          ] }

    let all : (string * UnitDef) list =
        [
            "armaas", armaas
            "armacsub", armacsub
            "armantiship", armantiship
            "armbats", armbats
            "armcarry", armcarry
            "armcrus", armcrus
            "armdronecarry", armdronecarry
            "armepoch", armepoch
            "armexcalibur", armexcalibur
            "armhacs", armhacs
            "armlship", armlship
            "armmls", armmls
            "armmship", armmship
            "armsacsub", armsacsub
            "armseadragon", armseadragon
            "armserp", armserp
            "armsjam", armsjam
            "armsubk", armsubk
            "armtdrone", armtdrone
            "armtrident", armtrident
        ]
