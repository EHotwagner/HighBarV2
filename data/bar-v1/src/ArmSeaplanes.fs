// Auto-generated BAR unit data: ArmSeaplanes
namespace BarData.V1.Units

open BarData.V1

module ArmSeaplanes =

    let armcsa : UnitDef =
        { name = "armcsa"
          subfolder = "ArmSeaplanes"
          metalCost = ValueOrExpr.Concrete 150.0
          energyCost = ValueOrExpr.Concrete 7800.0
          buildTime = ValueOrExpr.Concrete 14500.0
          health = ValueOrExpr.Concrete 405.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMCSA.s3o"
          buildPic = Some "ARMCSA.DDS"
          script = Some "Units/ARMCSA.cob"
          corpse = None
          explodeAs = Some "smallexplosiongeneric-builder"
          selfDestructAs = Some "smallExplosionGenericSelfd-builder"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 192.0
              maxAcc = 0.07
              maxDec = 0.4275
              turnRate = 240.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 255.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 360.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 50.0
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 75.0
              buildDistance = Some 136.0
              buildOptions = ["armsolar"; "armadvsol"; "armwin"; "armgeo"; "armmstor"; "armestor"; "armmex"; "armamex"; "armmakr"; "armlab"; "armvp"; "armap"; "armhp"; "armnanotc"; "armnanotcplat"; "armeyes"; "armrad"; "armdrag"; "armclaw"; "armllt"; "armbeamer"; "armhlt"; "armguard"; "armrl"; "armferret"; "armcir"; "armdl"; "armjamt"; "armjuno"; "armfhp"; "armsy"; "armamsub"; "armplat"; "armaap"; "armtide"; "armfmkr"; "armuwms"; "armuwes"; "armfdrag"; "armfrad"; "armfhlt"; "armfrt"; "armtl"; "armuwgeo"]
              terraformSpeed = Some 300.0 })
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 20.0)
              metalMake = None
              energyStorage = Some 75.0
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = None
          sounds = Some (
            { build = Some "nanlath1"
              repair = Some "repair1"
              working = Some "reclaim1"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["vtolcrmv"]
              select = ["seapsel1"] })
          customParams = Map.ofList [
              "model_author", "Flaka"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmSeaplanes"
              "unitgroup", "builder"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "cansubmerge", "true"
              "collide", "true"
              "hoverattack", "true"
          ] }

    let armhaca : UnitDef =
        { name = "armhaca"
          subfolder = "ArmSeaplanes"
          metalCost = ValueOrExpr.Concrete 1000.0
          energyCost = ValueOrExpr.Concrete 31200.0
          buildTime = ValueOrExpr.Concrete 58000.0
          health = ValueOrExpr.Concrete 1405.0
          sightDistance = ValueOrExpr.Concrete 364.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMACA.s3o"
          buildPic = Some "ARMACA.DDS"
          script = Some "Units/ARMACA.cob"
          corpse = None
          explodeAs = Some "smallexplosiongeneric-builder"
          selfDestructAs = Some "smallExplosionGenericSelfd-builder"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 192.0
              maxAcc = 0.07
              maxDec = 0.4275
              turnRate = 240.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 255.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 360.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 50.0
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 400.0
              buildDistance = Some 136.0
              buildOptions = ["armafus"; "armfus"; "armckfus"; "armageo"; "armgmm"; "armmoho"; "armmmkr"; "armuwadves"; "armuwadvms"; "armfort"; "armtarg"; "armgate"; "armamb"; "armpb"; "armanni"; "armflak"; "armmercury"; "armemp"; "armamd"; "armsilo"; "armbrtha"; "armvulc"; "armdf"; "armbanth"; "armaap"; "armhaap"; "armlab"; "armvp"; "armap"; "armsy"; "armsd"; "armshltx"]
              terraformSpeed = Some 300.0 })
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 20.0)
              metalMake = None
              energyStorage = Some 75.0
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = None
          sounds = Some (
            { build = Some "nanlath1"
              repair = Some "repair1"
              working = Some "reclaim1"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["vtolcrmv"]
              select = ["seapsel1"] })
          customParams = Map.ofList [
              "model_author", "Flaka"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmSeaplanes"
              "techlevel", "3.0"
              "unitgroup", "builder"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "cansubmerge", "true"
              "collide", "true"
              "hoverattack", "true"
          ] }

    let armsaber : UnitDef =
        { name = "armsaber"
          subfolder = "ArmSeaplanes"
          metalCost = ValueOrExpr.Concrete 210.0
          energyCost = ValueOrExpr.Concrete 6400.0
          buildTime = ValueOrExpr.Concrete 11000.0
          health = ValueOrExpr.Concrete 1010.0
          sightDistance = ValueOrExpr.Concrete 595.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMSABER.s3o"
          buildPic = Some "ARMSABER.DDS"
          script = Some "Units/ARMSABER.cob"
          corpse = None
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 156.89999
              maxAcc = 0.24
              maxDec = 0.46
              turnRate = 720.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 255.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 360.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 85.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "vtol_emg2"
                displayName = Some "Light a2g discharge blaster"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 60.0
                    "vtol", 10.0
                ]
                range = Some (ValueOrExpr.Concrete 425.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.9)
                weaponVelocity = Some 980.0
                areaOfEffect = Some 20.0
                accuracy = Some 100.0
                turret = Some false
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrhvy3"
                soundHit = Some "xplosml3"
                explosiongenerator = Some "custom:genericshellexplosion-small"
                rgbColor = Some "0.05 0.05 1"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "burnblow", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.05"
                    "energypershot", "15.0"
                    "intensity", "4.0"
                    "proximitypriority", "1.0"
                    "soundhitwet", "sizzle"
                    "thickness", "4.0"
                    "weapontimer", "1.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = Some (
            { build = Some "nanlath1"
              repair = Some "repair1"
              working = Some "reclaim1"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["vtolcrmv"]
              select = ["seapsel1"] })
          customParams = Map.ofList [
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmSeaplanes"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "cansubmerge", "true"
              "collide", "true"
              "hoverattack", "true"
              "nochasecategory", "VTOL"
          ] }

    let armsb : UnitDef =
        { name = "armsb"
          subfolder = "ArmSeaplanes"
          metalCost = ValueOrExpr.Concrete 240.0
          energyCost = ValueOrExpr.Concrete 7500.0
          buildTime = ValueOrExpr.Concrete 10000.0
          health = ValueOrExpr.Concrete 1170.0
          sightDistance = ValueOrExpr.Concrete 455.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMSB.s3o"
          buildPic = Some "ARMSB.DDS"
          script = Some "Units/ARMSB.cob"
          corpse = None
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 267.29999
              maxAcc = 0.06
              maxDec = 0.045
              turnRate = 0.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 255.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 210.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "arm_seaadvbomb"
                displayName = Some "Medium a2g impulse warheads"
                weaponType = Some "AircraftBomb"
                damage = Map.ofList [
                    "default", 200.0
                    "subs", 70.0
                ]
                range = Some (ValueOrExpr.Concrete 1280.0)
                reloadTime = Some (ValueOrExpr.Concrete 7.0)
                weaponVelocity = None
                areaOfEffect = Some 128.0
                accuracy = None
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "bombrel"
                soundHit = Some "bombsmed2"
                explosiongenerator = Some "custom:genericshellexplosion-medium-bomb"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "burst", "5.0"
                    "burstrate", "0.16667"
                    "collidefriendly", "false"
                    "commandfire", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "model", "airbombsea.s3o"
                    "mygravity", "0.4"
                    "soundhitwet", "splslrg"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = Some (
            { build = Some "nanlath1"
              repair = Some "repair1"
              working = Some "reclaim1"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["vtolcrmv"]
              select = ["seapsel1"] })
          customParams = Map.ofList [
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmSeaplanes"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "cansubmerge", "true"
              "collide", "false"
              "maxaileron", "0.01347"
              "maxbank", "0.8"
              "maxelevator", "0.00972"
              "maxpitch", "0.625"
              "maxrudder", "0.00522"
              "noautofire", "true"
              "nochasecategory", "VTOL"
              "speedtofront", "0.07"
              "turnradius", "64.0"
              "usesmoothmesh", "true"
              "wingangle", "0.06222"
              "wingdrag", "3.035"
          ] }

    let armseap : UnitDef =
        { name = "armseap"
          subfolder = "ArmSeaplanes"
          metalCost = ValueOrExpr.Concrete 290.0
          energyCost = ValueOrExpr.Concrete 6500.0
          buildTime = ValueOrExpr.Concrete 18000.0
          health = ValueOrExpr.Concrete 1380.0
          sightDistance = ValueOrExpr.Concrete 535.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMSEAP.s3o"
          buildPic = Some "ARMSEAP.DDS"
          script = Some "Units/ARMSEAP.cob"
          corpse = None
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 271.20001
              maxAcc = 0.2
              maxDec = 0.375
              turnRate = 720.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 255.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 100.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "armseap_weapon1"
                displayName = Some "Homing torpedo launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "commanders", 150.0
                    "default", 342.0
                    "vtol", 15.0
                ]
                range = Some (ValueOrExpr.Concrete 600.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.0)
                weaponVelocity = Some 200.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = Some 12000.0
                edgeEffectiveness = Some 0.25
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "bombrel"
                soundHit = Some "xplodep1"
                explosiongenerator = Some "custom:genericshellexplosion-small-uw"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "speceffect", "torpwaterpen"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTSHIP"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "40.0"
                    "mount_onlytargetcategory", "NOTHOVER"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "cegtag", "torpedotrail-tiny"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "flighttime", "3.0"
                    "model", "torpedo.s3o"
                    "predictboost", "1.0"
                    "soundhitvolume", "3.0"
                    "soundhitwet", "splsmed"
                    "soundhitwetvolume", "12.0"
                    "startvelocity", "130.0"
                    "tracks", "true"
                    "turnrate", "7000.0"
                    "waterweapon", "true"
                    "weaponacceleration", "15.0"
                    "weapontimer", "4.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = Some (
            { build = Some "nanlath1"
              repair = Some "repair1"
              working = Some "reclaim1"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["vtolcrmv"]
              select = ["seapsel1"] })
          customParams = Map.ofList [
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmSeaplanes"
              "unitgroup", "sub"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "cansubmerge", "true"
              "collide", "true"
              "hoverattack", "true"
              "nochasecategory", "VTOL"
              "sonardistance", "535.0"
          ] }

    let armsehak : UnitDef =
        { name = "armsehak"
          subfolder = "ArmSeaplanes"
          metalCost = ValueOrExpr.Concrete 125.0
          energyCost = ValueOrExpr.Concrete 7000.0
          buildTime = ValueOrExpr.Concrete 11000.0
          health = ValueOrExpr.Concrete 580.0
          sightDistance = ValueOrExpr.Concrete 1100.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMSEHAK.s3o"
          buildPic = Some "ARMSEHAK.DDS"
          script = Some "Units/ARMSEHAK.cob"
          corpse = None
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 338.10001
              maxAcc = 0.1325
              maxDec = 0.05
              turnRate = 0.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 255.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 220.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = Some (
            { build = Some "nanlath1"
              repair = Some "repair1"
              working = Some "reclaim1"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["vtolarmv"]
              select = ["seasonr2"] })
          customParams = Map.ofList [
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmSeaplanes"
              "unitgroup", "util"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "cansubmerge", "true"
              "collide", "false"
              "maxaileron", "0.01403"
              "maxbank", "0.8"
              "maxelevator", "0.01028"
              "maxpitch", "0.625"
              "maxrudder", "0.00578"
              "radardistance", "2250.0"
              "sonardistance", "900.0"
              "speedtofront", "0.07"
              "turnradius", "64.0"
              "usesmoothmesh", "true"
              "wingangle", "0.06278"
              "wingdrag", "0.135"
          ] }

    let armsfig : UnitDef =
        { name = "armsfig"
          subfolder = "ArmSeaplanes"
          metalCost = ValueOrExpr.Concrete 90.0
          energyCost = ValueOrExpr.Concrete 4500.0
          buildTime = ValueOrExpr.Concrete 7000.0
          health = ValueOrExpr.Concrete 220.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMSFIG.s3o"
          buildPic = Some "ARMSFIG.DDS"
          script = Some "Units/ARMSFIG.cob"
          corpse = None
          explodeAs = Some "smallExplosionGenericAir"
          selfDestructAs = Some "smallExplosionGenericAir"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 310.79999
              maxAcc = 0.2075
              maxDec = 0.1
              turnRate = 0.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 255.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 140.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "armsfig_weapon"
                displayName = Some "Guided a2a missile launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "commanders", 4.0
                    "default", 12.0
                    "vtol", 210.0
                ]
                range = Some (ValueOrExpr.Concrete 710.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.83333)
                weaponVelocity = Some 900.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = None
                tolerance = Some 8000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "Rocklit3"
                soundHit = Some "xplosml2"
                explosiongenerator = Some "custom:genericshellexplosion-tiny-air"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR"
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "castshadow", "false"
                    "cegtag", "missiletrailfighter"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "0.0"
                    "flighttime", "1.3"
                    "metalpershot", "0.0"
                    "model", "cormissile.s3o"
                    "smokecolor", "0.55"
                    "smokeperiod", "4.0"
                    "smokesize", "1.8"
                    "smoketime", "8.0"
                    "smoketrail", "false"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splshbig"
                    "startvelocity", "480.0"
                    "texture1", "null"
                    "texture2", "smoketrail"
                    "tracks", "true"
                    "turnrate", "22000.0"
                    "weaponacceleration", "425.0"
                    "weapontimer", "5.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = Some (
            { build = Some "nanlath1"
              repair = Some "repair1"
              working = Some "reclaim1"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["vtolcrmv"]
              select = ["seapsel1"] })
          customParams = Map.ofList [
              "attacksafetydistance", "300.0"
              "fighter", "1.0"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmSeaplanes"
              "unitgroup", "aa"
          ]
          extras = Map.ofList [
              "airsightdistance", "950.0"
              "blocking", "false"
              "cansubmerge", "true"
              "collide", "false"
              "maxaileron", "0.01403"
              "maxbank", "0.8"
              "maxelevator", "0.01028"
              "maxpitch", "0.625"
              "maxrudder", "0.00578"
              "nochasecategory", "NOTAIR"
              "speedtofront", "0.07"
              "turnradius", "64.0"
              "usesmoothmesh", "true"
              "wingangle", "0.06278"
              "wingdrag", "0.235"
          ] }

    let armsfig2 : UnitDef =
        { name = "armsfig2"
          subfolder = "ArmSeaplanes"
          metalCost = ValueOrExpr.Concrete 90.0
          energyCost = ValueOrExpr.Concrete 4500.0
          buildTime = ValueOrExpr.Concrete 7000.0
          health = ValueOrExpr.Concrete 220.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMSFIG2.s3o"
          buildPic = Some "ARMSFIG2.DDS"
          script = Some "Units/ARMSFIG2.cob"
          corpse = None
          explodeAs = Some "smallExplosionGenericAir"
          selfDestructAs = Some "smallExplosionGenericAir"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 310.79999
              maxAcc = 0.2075
              maxDec = 0.1
              turnRate = 0.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 255.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 140.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "armsfig_weapon"
                displayName = Some "Guided a2a missile launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "commanders", 4.0
                    "default", 12.0
                    "vtol", 210.0
                ]
                range = Some (ValueOrExpr.Concrete 710.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.83333)
                weaponVelocity = Some 900.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = Some 8000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "Rocklit3"
                soundHit = Some "xplosml2"
                explosiongenerator = Some "custom:genericshellexplosion-tiny-air"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR"
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "castshadow", "false"
                    "cegtag", "missiletrailfighter"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "0.0"
                    "flighttime", "1.3"
                    "metalpershot", "0.0"
                    "model", "cormissile.s3o"
                    "smokecolor", "0.55"
                    "smokeperiod", "4.0"
                    "smokesize", "1.8"
                    "smoketime", "8.0"
                    "smoketrail", "false"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splshbig"
                    "startvelocity", "480.0"
                    "texture1", "null"
                    "texture2", "smoketrail"
                    "tracks", "true"
                    "turnrate", "22000.0"
                    "weaponacceleration", "425.0"
                    "weapontimer", "5.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = Some (
            { build = Some "nanlath1"
              repair = Some "repair1"
              working = Some "reclaim1"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["vtolcrmv"]
              select = ["seapsel1"] })
          customParams = Map.ofList [
              "attacksafetydistance", "300.0"
              "fighter", "1.0"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmSeaplanes"
              "unitgroup", "aa"
          ]
          extras = Map.ofList [
              "airsightdistance", "950.0"
              "blocking", "false"
              "cansubmerge", "true"
              "collide", "false"
              "maxaileron", "0.01403"
              "maxbank", "0.8"
              "maxelevator", "0.01028"
              "maxpitch", "0.625"
              "maxrudder", "0.00578"
              "nochasecategory", "NOTAIR"
              "speedtofront", "0.07"
              "turnradius", "64.0"
              "usesmoothmesh", "true"
              "wingangle", "0.06278"
              "wingdrag", "0.235"
          ] }

    let all : (string * UnitDef) list =
        [
            "armcsa", armcsa
            "armhaca", armhaca
            "armsaber", armsaber
            "armsb", armsb
            "armseap", armseap
            "armsehak", armsehak
            "armsfig", armsfig
            "armsfig2", armsfig2
        ]
