// Auto-generated BAR unit data: ArmAircraft
namespace BarData.V1.Units

open BarData.V1

module ArmAircraft =

    let armatlas : UnitDef =
        { name = "armatlas"
          subfolder = "ArmAircraft"
          metalCost = ValueOrExpr.Concrete 68.0
          energyCost = ValueOrExpr.Concrete 1300.0
          buildTime = ValueOrExpr.Concrete 3850.0
          health = ValueOrExpr.Concrete 265.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 2.0
          footprintZ = 3.0
          objectName = Some "Units/ARMATLAS.s3o"
          buildPic = Some "ARMATLAS.DDS"
          script = Some "Units/ARMATLAS.cob"
          corpse = None
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 207.0
              maxAcc = 0.1
              maxDec = 0.75
              turnRate = 550.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 360.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 100.0
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
              ok = ["vtolarmv"]
              select = ["vtolarac"] })
          customParams = Map.ofList [
              "crashable", "0.0"
              "model_author", "Flaka"
              "normaltex", "unittextures/Arm_normal.dds"
              "paralyzemultiplier", "0.0"
              "subfolder", "ArmAircraft"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "collide", "false"
              "loadingradius", "300.0"
              "releaseheld", "true"
              "transportcapacity", "1.0"
              "transportmass", "750.0"
              "transportsize", "3.0"
              "transportunloadmethod", "0.0"
              "verticalspeed", "3.75"
          ] }

    let armca : UnitDef =
        { name = "armca"
          subfolder = "ArmAircraft"
          metalCost = ValueOrExpr.Concrete 110.0
          energyCost = ValueOrExpr.Concrete 3000.0
          buildTime = ValueOrExpr.Concrete 7960.0
          health = ValueOrExpr.Concrete 156.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMCA.s3o"
          buildPic = Some "ARMCA.DDS"
          script = Some "Units/ARMCA.cob"
          corpse = None
          explodeAs = Some "smallexplosiongeneric-builder"
          selfDestructAs = Some "smallExplosionGenericSelfd-builder"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 208.2
              maxAcc = 0.07
              maxDec = 0.4275
              turnRate = 240.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 360.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 70.0
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 60.0
              buildDistance = Some 136.0
              buildOptions = ["armsolar"; "armadvsol"; "armwin"; "armgeo"; "armmstor"; "armestor"; "armmex"; "armamex"; "armmakr"; "armaap"; "armlab"; "armvp"; "armap"; "armhp"; "armnanotc"; "armeyes"; "armrad"; "armdrag"; "armclaw"; "armllt"; "armbeamer"; "armhlt"; "armguard"; "armrl"; "armferret"; "armcir"; "armdl"; "armjamt"; "armjuno"; "armsy"; "armuwgeo"]
              terraformSpeed = Some 225.0 })
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 5.0)
              metalMake = None
              energyStorage = Some 25.0
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
              ok = ["vtolarmv"]
              select = ["vtolarac"] })
          customParams = Map.ofList [
              "model_author", "FireStorm, Flaka"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmAircraft"
              "unitgroup", "builder"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "collide", "true"
              "hoverattack", "true"
          ] }

    let armdrone : UnitDef =
        { name = "armdrone"
          subfolder = "ArmAircraft"
          metalCost = ValueOrExpr.Concrete 25.0
          energyCost = ValueOrExpr.Concrete 600.0
          buildTime = ValueOrExpr.Concrete 1200.0
          health = ValueOrExpr.Concrete 450.0
          sightDistance = ValueOrExpr.Concrete 600.0
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
            { speed = ValueOrExpr.Concrete 330.0
              maxAcc = 0.22
              maxDec = 0.5
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
              cruiseAltitude = Some 40.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "med_emg"
                displayName = Some "Rapid-fire a2g machine guns"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 11.0
                    "vtol", 3.0
                ]
                range = Some (ValueOrExpr.Concrete 350.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.8)
                weaponVelocity = Some 800.0
                areaOfEffect = Some 16.0
                accuracy = Some 13.0
                turret = Some false
                tolerance = Some 6000.0
                edgeEffectiveness = Some 0.5
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "mgun3"
                soundHit = Some "bimpact3"
                explosiongenerator = Some "custom:laserhit-small-yellow"
                rgbColor = Some "1 0.95 0.4"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "90.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "burnblow", "false"
                    "burst", "3.0"
                    "burstrate", "0.105"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.025"
                    "intensity", "0.8"
                    "ownerexpaccweight", "2.0"
                    "predictboost", "1.0"
                    "soundhitwet", "splshbig"
                    "sprayangle", "1024.0"
                    "thickness", "0.7"
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
              "subfolder", "ArmAircraft"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "collide", "true"
              "hoverattack", "true"
              "nochasecategory", "VTOL"
          ] }

    let armdroneold : UnitDef =
        { name = "armdroneold"
          subfolder = "ArmAircraft"
          metalCost = ValueOrExpr.Concrete 55.0
          energyCost = ValueOrExpr.Concrete 1100.0
          buildTime = ValueOrExpr.Concrete 2200.0
          health = ValueOrExpr.Concrete 400.0
          sightDistance = ValueOrExpr.Concrete 520.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMDRONEOLD.s3o"
          buildPic = Some "ARMKAM.DDS"
          script = Some "Units/ARMDRONEOLD.cob"
          corpse = None
          explodeAs = Some "smallExplosionGeneric"
          selfDestructAs = Some "smallExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 225.0
              maxAcc = 0.2
              maxDec = 0.45
              turnRate = 900.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 360.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 70.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "railgun"
                displayName = Some "Railgun"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 100.0
                ]
                range = Some (ValueOrExpr.Concrete 350.0)
                reloadTime = Some (ValueOrExpr.Concrete 6.0)
                weaponVelocity = Some 2000.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some false
                tolerance = Some 6000.0
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 1.0
                noSelfDamage = Some true
                soundStart = Some "railgun3"
                soundHit = Some "mavgun3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "0.34 0.64 0.94"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "burnblow", "false"
                    "cegtag", "railgun"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.06"
                    "falloffrate", "0.2"
                    "firestarter", "0.0"
                    "intensity", "0.8"
                    "ownerexpaccweight", "4.0"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "13.0"
                    "thickness", "1.5"
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
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmAircraft"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "collide", "true"
              "hoverattack", "true"
              "nochasecategory", "VTOL"
          ] }

    let armfig : UnitDef =
        { name = "armfig"
          subfolder = "ArmAircraft"
          metalCost = ValueOrExpr.Concrete 73.0
          energyCost = ValueOrExpr.Concrete 2900.0
          buildTime = ValueOrExpr.Concrete 3500.0
          health = ValueOrExpr.Concrete 167.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMFIG.s3o"
          buildPic = Some "ARMFIG.DDS"
          script = Some "Units/ARMFIG.cob"
          corpse = None
          explodeAs = Some "smallExplosionGenericAir"
          selfDestructAs = Some "smallExplosionGenericAir"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 289.20001
              maxAcc = 0.1825
              maxDec = 0.075
              turnRate = 0.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 125.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "armvtol_missile"
                displayName = Some "Light a2a missile launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "commanders", 4.0
                    "default", 12.0
                    "vtol", 125.0
                ]
                range = Some (ValueOrExpr.Concrete 680.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.9)
                weaponVelocity = Some 850.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = None
                tolerance = Some 12000.0
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
                    "flighttime", "1.2"
                    "metalpershot", "0.0"
                    "model", "cormissile.s3o"
                    "smokecolor", "0.55"
                    "smokeperiod", "4.0"
                    "smokesize", "1.8"
                    "smoketime", "8.0"
                    "smoketrail", "false"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splshbig"
                    "startvelocity", "450.0"
                    "texture1", "null"
                    "texture2", "smoketrail"
                    "tracks", "true"
                    "turnrate", "20000.0"
                    "weaponacceleration", "400.0"
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
              "attacksafetydistance", "300.0"
              "fighter", "1.0"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmAircraft"
              "unitgroup", "aa"
          ]
          extras = Map.ofList [
              "airsightdistance", "950.0"
              "blocking", "false"
              "collide", "false"
              "maxaileron", "0.0144"
              "maxbank", "0.8"
              "maxelevator", "0.01065"
              "maxpitch", "0.625"
              "maxrudder", "0.00615"
              "nochasecategory", "NOTAIR"
              "speedtofront", "0.06417"
              "turnradius", "64.0"
              "usesmoothmesh", "true"
              "wingangle", "0.06315"
              "wingdrag", "0.185"
          ] }

    let armhvytrans : UnitDef =
        { name = "armhvytrans"
          subfolder = "ArmAircraft"
          metalCost = ValueOrExpr.Concrete 190.0
          energyCost = ValueOrExpr.Concrete 4000.0
          buildTime = ValueOrExpr.Concrete 8500.0
          health = ValueOrExpr.Concrete 630.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 2.0
          footprintZ = 3.0
          objectName = Some "Units/armhvytrans.s3o"
          buildPic = Some "armhvytrans.DDS"
          script = Some "Units/armhvytrans.cob"
          corpse = None
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = Some "ALL MOBILE WEAPON NOTLAND NOTSUB VTOL NOTSHIP NOTHOVER"
          movement = Some (
            { speed = ValueOrExpr.Concrete 110.0
              maxAcc = 0.1
              maxDec = 0.75
              turnRate = 550.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 360.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 100.0
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
              ok = ["vtolarmv"]
              select = ["vtolarac"] })
          customParams = Map.ofList [
              "crashable", "0.0"
              "model_author", "Protar"
              "normaltex", "unittextures/Arm_normal.dds"
              "paralyzemultiplier", "0.0"
              "subfolder", "ArmAircraft"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "collide", "false"
              "loadingradius", "300.0"
              "releaseheld", "true"
              "transportcapacity", "1.0"
              "transportsize", "4.0"
              "transportunloadmethod", "0.0"
              "verticalspeed", "3.75"
          ] }

    let armkam : UnitDef =
        { name = "armkam"
          subfolder = "ArmAircraft"
          metalCost = ValueOrExpr.Concrete 135.0
          energyCost = ValueOrExpr.Concrete 2300.0
          buildTime = ValueOrExpr.Concrete 5050.0
          health = ValueOrExpr.Concrete 560.0
          sightDistance = ValueOrExpr.Concrete 520.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMKAM.s3o"
          buildPic = Some "ARMKAM.DDS"
          script = Some "Units/ARMKAM.cob"
          corpse = None
          explodeAs = Some "smallExplosionGeneric"
          selfDestructAs = Some "smallExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 184.8
              maxAcc = 0.15
              maxDec = 0.375
              turnRate = 1400.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 360.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 70.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "emg"
                displayName = Some "Rapid-fire close-quarters a2g plasma guns"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 9.0
                    "vtol", 3.0
                ]
                range = Some (ValueOrExpr.Concrete 350.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.7)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 40.0
                accuracy = Some 13.0
                turret = None
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.5
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "flashemg"
                soundHit = None
                explosiongenerator = Some "custom:plasmahit-small"
                rgbColor = Some "1 0.95 0.4"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "burst", "3.0"
                    "burstrate", "0.1"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "firestarter", "100.0"
                    "gravityaffected", "true"
                    "intensity", "0.66"
                    "size", "2.0"
                    "soundhitwet", "splshbig"
                    "soundtrigger", "true"
                    "sprayangle", "1024.0"
                    "weapontimer", "0.1"
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
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmAircraft"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "collide", "true"
              "hoverattack", "true"
              "nochasecategory", "VTOL"
          ] }

    let armpeep : UnitDef =
        { name = "armpeep"
          subfolder = "ArmAircraft"
          metalCost = ValueOrExpr.Concrete 52.0
          energyCost = ValueOrExpr.Concrete 1550.0
          buildTime = ValueOrExpr.Concrete 2800.0
          health = ValueOrExpr.Concrete 89.0
          sightDistance = ValueOrExpr.Concrete 865.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMPEEP.s3o"
          buildPic = Some "ARMPEEP.DDS"
          script = Some "Units/ARMPEEP.cob"
          corpse = None
          explodeAs = Some "tinyExplosionGeneric"
          selfDestructAs = Some "tinyExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = Some "LIGHTAIRSCOUT"
          movement = Some (
            { speed = ValueOrExpr.Concrete 375.0
              maxAcc = 0.1825
              maxDec = 0.01125
              turnRate = 0.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 180.0
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
              ok = ["vtolarmv"]
              select = ["vtolarac"] })
          customParams = Map.ofList [
              "crashable", "0.0"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "selectable_as_combat_unit", "true"
              "subfolder", "ArmAircraft"
              "unitgroup", "util"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "collide", "false"
              "maxaileron", "0.0144"
              "maxbank", "0.8"
              "maxelevator", "0.01065"
              "maxpitch", "0.625"
              "maxrudder", "0.00615"
              "radardistance", "1140.0"
              "selfdestructcountdown", "1.0"
              "speedtofront", "0.06417"
              "turnradius", "64.0"
              "usesmoothmesh", "true"
              "wingangle", "0.06315"
              "wingdrag", "0.0575"
          ] }

    let armthund : UnitDef =
        { name = "armthund"
          subfolder = "ArmAircraft"
          metalCost = ValueOrExpr.Concrete 145.0
          energyCost = ValueOrExpr.Concrete 4200.0
          buildTime = ValueOrExpr.Concrete 4780.0
          health = ValueOrExpr.Concrete 670.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMTHUND.s3o"
          buildPic = Some "ARMTHUND.DDS"
          script = Some "Units/ARMTHUND.cob"
          corpse = None
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 250.0
              maxAcc = 0.0575
              maxDec = 0.05
              turnRate = 0.0
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
                displayName = Some "Light a2g impulse warheads"
                weaponType = Some "AircraftBomb"
                damage = Map.ofList [
                    "default", 105.0
                    "subs", 35.0
                ]
                range = Some (ValueOrExpr.Concrete 1280.0)
                reloadTime = Some (ValueOrExpr.Concrete 6.0)
                weaponVelocity = None
                areaOfEffect = Some 144.0
                accuracy = None
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.55
                impulseFactor = Some 0.5
                noSelfDamage = Some true
                soundStart = Some "bombrel"
                soundHit = Some "bombssml1"
                explosiongenerator = Some "custom:genericshellexplosion-medium-bomb"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "burst", "5.0"
                    "burstrate", "0.25"
                    "collidefriendly", "false"
                    "commandfire", "false"
                    "craterareaofeffect", "144.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "model", "airbomb.s3o"
                    "soundhitwet", "splsmed"
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
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmAircraft"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "collide", "false"
              "maxaileron", "0.0144"
              "maxbank", "0.8"
              "maxelevator", "0.01065"
              "maxpitch", "0.625"
              "maxrudder", "0.00615"
              "noautofire", "true"
              "nochasecategory", "VTOL"
              "speedtofront", "0.063"
              "turnradius", "64.0"
              "usesmoothmesh", "true"
              "wingangle", "0.06315"
              "wingdrag", "0.135"
          ] }

    let all : (string * UnitDef) list =
        [
            "armatlas", armatlas
            "armca", armca
            "armdrone", armdrone
            "armdroneold", armdroneold
            "armfig", armfig
            "armhvytrans", armhvytrans
            "armkam", armkam
            "armpeep", armpeep
            "armthund", armthund
        ]
