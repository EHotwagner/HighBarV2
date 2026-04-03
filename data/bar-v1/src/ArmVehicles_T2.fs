// Auto-generated BAR unit data: ArmVehicles/T2
namespace BarData.V1.Units

open BarData.V1

module ArmVehicles_T2 =

    let armacv : UnitDef =
        { name = "armacv"
          subfolder = "ArmVehicles/T2"
          metalCost = ValueOrExpr.Concrete 550.0
          energyCost = ValueOrExpr.Concrete 6800.0
          buildTime = ValueOrExpr.Concrete 16000.0
          health = ValueOrExpr.Concrete 2050.0
          sightDistance = ValueOrExpr.Concrete 289.89999
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMACV.s3o"
          buildPic = Some "ARMACV.DDS"
          script = Some "Units/ARMACV.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric-builder"
          selfDestructAs = Some "mediumExplosionGenericSelfd-builder"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "36 43 42"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 52.5
              maxAcc = 0.02963
              maxDec = 0.11852
              turnRate = 399.0
              movementClass = Some "TANK3"
              maxSlope = Some 16.0
              maxWaterDepth = Some 18.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.2342
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 290.0
              buildDistance = Some 136.0
              buildOptions = ["armfus"; "armckfus"; "armafus"; "armageo"; "armgmm"; "armmoho"; "armmmkr"; "armuwadves"; "armuwadvms"; "armarad"; "armveil"; "armfort"; "armtarg"; "armsd"; "armgate"; "armamb"; "armpb"; "armanni"; "armflak"; "armmercury"; "armemp"; "armamd"; "armsilo"; "armbrtha"; "armvulc"; "armdf"; "armvp"; "armavp"; "armshltx"]
              terraformSpeed = Some 1250.0 })
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 20.0)
              metalMake = None
              energyStorage = Some 100.0
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "36 43 42"
                collisionVolumeType = Some "Box"
                damage = Some 1500.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 280.0
                object_ = Some "Units/armacv_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 1000.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 112.0
                object_ = Some "Units/arm3X3A.s3o"
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
              ok = ["varmmove"]
              select = ["varmsel"] })
          customParams = Map.ofList [
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmVehicles/T2"
              "techlevel", "2.0"
              "unitgroup", "buildert2"
          ]
          extras = Map.ofList [
              "leavetracks", "true"
              "radardistance", "50.0"
              "trackstrength", "6.0"
              "tracktype", "arm_acv_tracks_2"
              "trackwidth", "36.0"
          ] }

    let armbull : UnitDef =
        { name = "armbull"
          subfolder = "ArmVehicles/T2"
          metalCost = ValueOrExpr.Concrete 950.0
          energyCost = ValueOrExpr.Concrete 13000.0
          buildTime = ValueOrExpr.Concrete 23000.0
          health = ValueOrExpr.Concrete 4650.0
          sightDistance = ValueOrExpr.Concrete 494.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMBULL.s3o"
          buildPic = Some "ARMBULL.DDS"
          script = Some "Units/ARMBULL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeexplosiongeneric"
          selfDestructAs = Some "largeExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 2"
          collisionVolumeScales = Some "44 23 52"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 62.0
              maxAcc = 0.03542
              maxDec = 0.07083
              turnRate = 365.0
              movementClass = Some "HTANK4"
              maxSlope = Some 12.0
              maxWaterDepth = Some 15.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.6104
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "arm_bull"
                displayName = Some "Heavy g2g plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 270.0
                    "subs", 100.0
                    "vtol", 30.0
                ]
                range = Some (ValueOrExpr.Concrete 460.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.1)
                weaponVelocity = Some 300.0
                areaOfEffect = Some 130.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "cannon3"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:genericshellexplosion-medium"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
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
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 2"
                collisionVolumeScales = Some "44 23 52"
                collisionVolumeType = Some "Box"
                damage = Some 3000.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 549.0
                object_ = Some "Units/armbull_dead.s3o"
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
                metal = Some 220.0
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
              ok = ["tarmmove"]
              select = ["tarmsel"] })
          customParams = Map.ofList [
              "basename", "base"
              "firingceg", "barrelshot-medium"
              "kickback", "-2.4"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmVehicles/T2"
              "techlevel", "2.0"
              "unitgroup", "weapon"
              "weapon1turretx", "65.0"
              "weapon1turrety", "105.0"
          ]
          extras = Map.ofList [
              "leavetracks", "true"
              "nochasecategory", "VTOL"
              "trackoffset", "8.0"
              "trackstrength", "10.0"
              "tracktype", "armbull_tracks"
              "trackwidth", "44.0"
              "usepiececollisionvolumes", "1.0"
          ] }

    let armconsul : UnitDef =
        { name = "armconsul"
          subfolder = "ArmVehicles/T2"
          metalCost = ValueOrExpr.Concrete 250.0
          energyCost = ValueOrExpr.Concrete 4300.0
          buildTime = ValueOrExpr.Concrete 8500.0
          health = ValueOrExpr.Concrete 1080.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMCONSUL.s3o"
          buildPic = Some "ARMCONSUL.DDS"
          script = Some "Units/ARMCONSUL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallexplosiongeneric-builder"
          selfDestructAs = Some "smallExplosionGenericSelfd-builder"
          collisionVolumeOffsets = Some "0 0 -3"
          collisionVolumeScales = Some "32 30 30"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 78.0
              maxAcc = 0.07029
              maxDec = 0.14059
              turnRate = 635.0
              movementClass = Some "TANK2"
              maxSlope = Some 18.0
              maxWaterDepth = Some 18.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.83678
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 150.0
              buildDistance = Some 136.0
              buildOptions = ["armsolar"; "armmex"; "armvp"; "armnanotc"; "armeyes"; "armveil"; "armfort"; "armarad"; "armmine2"; "armdl"; "armbeamer"; "armamb"; "armferret"; "armflak"; "armcv"; "armpw"; "armjeth"; "armspid"; "armfast"; "armmav"; "armcs"; "armroy"; "armamph"]
              terraformSpeed = Some 750.0 })
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 15.0)
              metalMake = None
              energyStorage = Some 100.0
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 -3"
                collisionVolumeScales = Some "32 30 30"
                collisionVolumeType = Some "Box"
                damage = Some 800.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 153.0
                object_ = Some "Units/armconsul_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 700.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 61.0
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
              ok = ["tarmmove"]
              select = ["tarmsel"] })
          customParams = Map.ofList [
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmVehicles/T2"
              "techlevel", "2.0"
              "unitgroup", "buildert2"
          ]
          extras = Map.ofList [
              "leavetracks", "true"
              "trackoffset", "10.0"
              "trackstrength", "5.0"
              "tracktype", "armgremlin_tracks"
              "trackwidth", "35.0"
          ] }

    let armcroc : UnitDef =
        { name = "armcroc"
          subfolder = "ArmVehicles/T2"
          metalCost = ValueOrExpr.Concrete 750.0
          energyCost = ValueOrExpr.Concrete 15000.0
          buildTime = ValueOrExpr.Concrete 21000.0
          health = ValueOrExpr.Concrete 5000.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMCROC.s3o"
          buildPic = Some "ARMCROC.DDS"
          script = Some "Units/ARMCROC.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeExplosionGeneric-phib"
          selfDestructAs = Some "largeExplosionGenericSelfd-phib"
          collisionVolumeOffsets = Some "0 0 -3"
          collisionVolumeScales = Some "40 30 56"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 54.0
              maxAcc = 0.03252
              maxDec = 0.06504
              turnRate = 360.0
              movementClass = Some "ATANK3"
              maxSlope = Some 12.0
              maxWaterDepth = Some 255.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.35
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "arm_triton"
                displayName = Some "Medium g2g gauss-cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 225.0
                    "subs", 100.0
                    "vtol", 40.0
                ]
                range = Some (ValueOrExpr.Concrete 480.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.6)
                weaponVelocity = Some 450.0
                areaOfEffect = Some 64.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "cannon2"
                soundHit = Some "xplomed4"
                explosiongenerator = Some "custom:genericshellexplosion-medium"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "craterareaofeffect", "64.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "gravityaffected", "true"
                    "predictboost", "1.0"
                    "soundhitwet", "splsmed"
                ] }
              { name = "armcl_missile"
                displayName = Some "Light g2a missile launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 60.0
                ]
                range = Some (ValueOrExpr.Concrete 765.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.7)
                weaponVelocity = Some 800.0
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
                    "mount_badtargetcategory", "NOTAIR LIGHTAIRSCOUT"
                    "mount_fastautoretargeting", "true"
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
                    "fixedlauncher", "true"
                    "flighttime", "1.9"
                    "metalpershot", "0.0"
                    "model", "cormissile.s3o"
                    "smokecolor", "0.95"
                    "smokeperiod", "6.0"
                    "smokesize", "4.8"
                    "smoketime", "12.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splshbig"
                    "startvelocity", "300.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa"
                    "tracks", "true"
                    "turnrate", "63000.0"
                    "weaponacceleration", "200.0"
                    "weapontimer", "5.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 -3"
                collisionVolumeScales = Some "40 30 56"
                collisionVolumeType = Some "Box"
                damage = Some 2000.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 400.0
                object_ = Some "Units/armcroc_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 1500.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 200.0
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
              ok = ["tarmmove"]
              select = ["tarmsel"] })
          customParams = Map.ofList [
              "basename", "base"
              "firingceg", "barrelshot-medium"
              "kickback", "-2.4"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "paralyzemultiplier", "0.2"
              "subfolder", "ArmVehicles/T2"
              "techlevel", "2.0"
              "unitgroup", "weapon"
              "weapon1turretx", "45.0"
              "weapon1turrety", "75.0"
          ]
          extras = Map.ofList [
              "leavetracks", "true"
              "nochasecategory", "VTOL"
              "sonardistance", "279.0"
              "trackoffset", "16.0"
              "trackstrength", "5.0"
              "tracktype", "armcroc_tracks"
              "trackwidth", "44.0"
          ] }

    let armgremlin : UnitDef =
        { name = "armgremlin"
          subfolder = "ArmVehicles/T2"
          metalCost = ValueOrExpr.Concrete 230.0
          energyCost = ValueOrExpr.Concrete 3700.0
          buildTime = ValueOrExpr.Concrete 8500.0
          health = ValueOrExpr.Concrete 1060.0
          sightDistance = ValueOrExpr.Concrete 494.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMGREMLIN.s3o"
          buildPic = Some "ARMGREMLIN.DDS"
          script = Some "Units/ARMGREMLIN.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallexplosiongeneric"
          selfDestructAs = Some "smallExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 1 0"
          collisionVolumeScales = Some "24 13 39"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 4.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 70.5
              maxAcc = 0.0697
              maxDec = 0.13939
              turnRate = 701.79999
              movementClass = Some "TANK3"
              maxSlope = Some 12.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.64802
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "armgremlin_gauss"
                displayName = Some "Light close-quarters gauss cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 262.5
                    "vtol", 24.0
                ]
                range = Some (ValueOrExpr.Concrete 220.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.0)
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
                explosiongenerator = Some "custom:genericshellexplosion-medium"
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
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 1 0"
                collisionVolumeScales = Some "24 13 39"
                collisionVolumeType = Some "Box"
                damage = Some 800.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 15.0
                metal = Some 138.0
                object_ = Some "Units/armgremlin_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 700.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 55.0
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
              ok = ["tarmmove"]
              select = ["tarmsel"] })
          customParams = Map.ofList [
              "basename", "base"
              "firingceg", "barrelshot-small"
              "kickback", "-0.65"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "paralyzemultiplier", "0.2"
              "subfolder", "ArmVehicles/T2"
              "techlevel", "2.0"
              "unitgroup", "weapon"
              "weapon1turretx", "200.0"
              "weapon1turrety", "200.0"
          ]
          extras = Map.ofList [
              "cloakcost", "5.0"
              "cloakcostmoving", "20.0"
              "firestate", "0.0"
              "leavetracks", "false"
              "mincloakdistance", "65.0"
              "movestate", "0.0"
              "nochasecategory", "VTOL"
              "stealth", "true"
              "trackstrength", "6.0"
              "tracktype", "armgremlin_tracks"
              "trackwidth", "29.0"
          ] }

    let armhacv : UnitDef =
        { name = "armhacv"
          subfolder = "ArmVehicles/T2"
          metalCost = ValueOrExpr.Concrete 1300.0
          energyCost = ValueOrExpr.Concrete 18800.0
          buildTime = ValueOrExpr.Concrete 42000.0
          health = ValueOrExpr.Concrete 2080.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMCONSUL.s3o"
          buildPic = Some "ARMCONSUL.DDS"
          script = Some "Units/ARMCONSUL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallexplosiongeneric-builder"
          selfDestructAs = Some "smallExplosionGenericSelfd-builder"
          collisionVolumeOffsets = Some "0 0 -3"
          collisionVolumeScales = Some "32 30 30"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 85.0
              maxAcc = 0.07029
              maxDec = 0.14059
              turnRate = 635.0
              movementClass = Some "TANK2"
              maxSlope = Some 18.0
              maxWaterDepth = Some 18.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.83678
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 600.0
              buildDistance = Some 136.0
              buildOptions = ["armafus"; "armfus"; "armckfus"; "armageo"; "armgmm"; "armmoho"; "armmmkr"; "armuwadves"; "armuwadvms"; "armfort"; "armtarg"; "armgate"; "armamb"; "armpb"; "armanni"; "armflak"; "armmercury"; "armemp"; "armamd"; "armsilo"; "armbrtha"; "armvulc"; "armdf"; "armbanth"; "armavp"; "armhavp"; "armlab"; "armvp"; "armap"; "armsy"; "armsd"; "armshltx"]
              terraformSpeed = Some 750.0 })
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 15.0)
              metalMake = None
              energyStorage = Some 100.0
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 -3"
                collisionVolumeScales = Some "32 30 30"
                collisionVolumeType = Some "Box"
                damage = Some 800.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 153.0
                object_ = Some "Units/armconsul_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 700.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 61.0
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
              ok = ["tarmmove"]
              select = ["tarmsel"] })
          customParams = Map.ofList [
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmVehicles/T2"
              "techlevel", "3.0"
              "unitgroup", "buildert2"
          ]
          extras = Map.ofList [
              "leavetracks", "true"
              "mass", "2700.0"
              "trackoffset", "10.0"
              "trackstrength", "5.0"
              "tracktype", "armgremlin_tracks"
              "trackwidth", "35.0"
          ] }

    let armjam : UnitDef =
        { name = "armjam"
          subfolder = "ArmVehicles/T2"
          metalCost = ValueOrExpr.Concrete 105.0
          energyCost = ValueOrExpr.Concrete 1700.0
          buildTime = ValueOrExpr.Concrete 7000.0
          health = ValueOrExpr.Concrete 510.0
          sightDistance = ValueOrExpr.Concrete 300.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMJAM.s3o"
          buildPic = Some "ARMJAM.DDS"
          script = Some "Units/ARMJAM.cob"
          corpse = Some "dead"
          explodeAs = Some "smallexplosiongeneric"
          selfDestructAs = Some "smallExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "23 28 33"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 33.0
              maxAcc = 0.02416
              maxDec = 0.04831
              turnRate = 505.0
              movementClass = Some "TANK3"
              maxSlope = Some 16.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 0.792
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
                collisionVolumeScales = Some "23 28 33"
                collisionVolumeType = Some "Box"
                damage = Some 400.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 78.0
                object_ = Some "Units/armjam_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 368.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 39.0
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
              ok = ["varmmove"]
              select = ["radjam1"] })
          customParams = Map.ofList [
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "off_on_stun", "true"
              "subfolder", "ArmVehicles/T2"
              "techlevel", "2.0"
              "unitgroup", "util"
          ]
          extras = Map.ofList [
              "canattack", "false"
              "energyupkeep", "80.0"
              "leavetracks", "false"
              "movestate", "0.0"
              "nochasecategory", "MOBILE"
              "onoffable", "true"
              "radardistance", "0.0"
              "radardistancejam", "450.0"
              "trackoffset", "8.0"
              "trackstrength", "10.0"
              "tracktype", "StdTank"
              "trackwidth", "22.0"
          ] }

    let armlatnk : UnitDef =
        { name = "armlatnk"
          subfolder = "ArmVehicles/T2"
          metalCost = ValueOrExpr.Concrete 330.0
          energyCost = ValueOrExpr.Concrete 6400.0
          buildTime = ValueOrExpr.Concrete 8000.0
          health = ValueOrExpr.Concrete 1060.0
          sightDistance = ValueOrExpr.Concrete 390.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMLATNK.s3o"
          buildPic = Some "ARMLATNK.DDS"
          script = Some "Units/ARMLATNK.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallExplosionGeneric"
          selfDestructAs = Some "smallExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "30 26 34"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 90.0
              maxAcc = 0.05833
              maxDec = 0.11666
              turnRate = 440.0
              movementClass = Some "TANK3"
              maxSlope = Some 10.0
              maxWaterDepth = Some 12.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 2.19516
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "lightning"
                displayName = Some "Close-quarters lightning turret"
                weaponType = Some "LightningCannon"
                damage = Map.ofList [
                    "default", 22.0
                ]
                range = Some (ValueOrExpr.Concrete 300.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.5)
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
                    "spark_forkdamage", "0.33"
                    "spark_maxunits", "2"
                    "spark_range", "60"
                ]
                extras = Map.ofList [
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
                    "soundhitwet", "sizzle"
                    "soundtrigger", "true"
                    "thickness", "1.5"
                ] }
              { name = "armamph_missile"
                displayName = Some "Light g2a missile launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 90.0
                ]
                range = Some (ValueOrExpr.Concrete 600.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.1)
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
                    "turnrate", "48000.0"
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
                collisionVolumeScales = Some "30 26 34"
                collisionVolumeType = Some "Box"
                damage = Some 800.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 200.0
                object_ = Some "Units/armlatnk_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 500.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 80.0
                object_ = Some "Units/arm2X2D.s3o"
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
              ok = ["tarmmove"]
              select = ["tarmsel"] })
          customParams = Map.ofList [
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmVehicles/T2"
              "techlevel", "2.0"
              "unitgroup", "weaponaa"
          ]
          extras = Map.ofList [
              "leavetracks", "true"
              "nochasecategory", "VTOL"
              "trackoffset", "6.0"
              "trackstrength", "5.0"
              "tracktype", "armacv_tracks"
              "trackwidth", "36.0"
              "usepiececollisionvolumes", "1.0"
          ] }

    let armmanni : UnitDef =
        { name = "armmanni"
          subfolder = "ArmVehicles/T2"
          metalCost = ValueOrExpr.Concrete 1200.0
          energyCost = ValueOrExpr.Concrete 18500.0
          buildTime = ValueOrExpr.Concrete 33000.0
          health = ValueOrExpr.Concrete 2800.0
          sightDistance = ValueOrExpr.Concrete 650.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMMANNI.s3o"
          buildPic = Some "ARMMANNI.DDS"
          script = Some "Units/ARMMANNI.cob"
          corpse = Some "DEAD"
          explodeAs = Some "penetrator"
          selfDestructAs = Some "penetrator"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "39 49 39"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 42.0
              maxAcc = 0.00715
              maxDec = 0.01431
              turnRate = 120.8
              movementClass = Some "HTANK4"
              maxSlope = Some 12.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.00188
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "atam"
                displayName = Some "Heavy long-range g2g tachyon beam"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 1000.0
                    "default", 2500.0
                ]
                range = Some (ValueOrExpr.Concrete 950.0)
                reloadTime = Some (ValueOrExpr.Concrete 4.7)
                weaponVelocity = Some 1500.0
                areaOfEffect = Some 12.0
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
                    "mount_badtargetcategory", "VTOL"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "180.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "beamtime", "0.3"
                    "corethickness", "0.23"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "1000.0"
                    "largebeamlaser", "true"
                    "laserflaresize", "6.05"
                    "scrollspeed", "5.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "texture3", "largebeam"
                    "thickness", "4.5"
                    "tilelength", "150.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "39 49 39"
                collisionVolumeType = Some "box"
                damage = Some 2000.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 734.0
                object_ = Some "Units/armmanni_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 1500.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 294.0
                object_ = Some "Units/arm3X3C.s3o"
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
              ok = ["tarmmove"]
              select = ["tarmsel"] })
          customParams = Map.ofList [
              "basename", "base"
              "firingceg", "barrelshot-small"
              "kickback", "-2"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmVehicles/T2"
              "techlevel", "2.0"
              "unitgroup", "weapon"
              "weapon1turretx", "50.0"
              "weapon1turrety", "50.0"
          ]
          extras = Map.ofList [
              "leavetracks", "true"
              "movestate", "0.0"
              "nochasecategory", "VTOL"
              "trackoffset", "6.0"
              "trackstrength", "10.0"
              "tracktype", "armacv_tracks"
              "trackwidth", "46.0"
              "usepiececollisionvolumes", "1.0"
          ] }

    let armmart : UnitDef =
        { name = "armmart"
          subfolder = "ArmVehicles/T2"
          metalCost = ValueOrExpr.Concrete 320.0
          energyCost = ValueOrExpr.Concrete 4900.0
          buildTime = ValueOrExpr.Concrete 8500.0
          health = ValueOrExpr.Concrete 1070.0
          sightDistance = ValueOrExpr.Concrete 286.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMMART.s3o"
          buildPic = Some "ARMMART.DDS"
          script = Some "Units/ARMMART.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumExplosionGeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 -2"
          collisionVolumeScales = Some "36 20 38"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 60.0
              maxAcc = 0.033
              maxDec = 0.066
              turnRate = 270.0
              movementClass = Some "TANK3"
              maxSlope = Some 12.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.1946
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "arm_artillery"
                displayName = Some "Long-range g2g plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 260.0
                    "subs", 65.0
                    "vtol", 26.0
                ]
                range = Some (ValueOrExpr.Concrete 820.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.05)
                weaponVelocity = Some 355.0
                areaOfEffect = Some 120.0
                accuracy = Some 600.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.65
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "cannhvy2"
                soundHit = Some "xplomed4"
                explosiongenerator = Some "custom:genericshellexplosion-medium-bomb"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTLAND"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "180.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "cegtag", "arty-medium"
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
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 -2"
                collisionVolumeScales = Some "36 20 38"
                collisionVolumeType = Some "Box"
                damage = Some 500.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 198.0
                object_ = Some "Units/armmart_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 400.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 79.0
                object_ = Some "Units/arm2X2E.s3o"
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
              ok = ["tarmmove"]
              select = ["tarmsel"] })
          customParams = Map.ofList [
              "basename", "base"
              "canareaattack", "1.0"
              "firingceg", "barrelshot-medium"
              "kickback", "-6"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmVehicles/T2"
              "techlevel", "2.0"
              "unitgroup", "weapon"
              "weapon1turretx", "35.0"
              "weapon1turrety", "35.0"
          ]
          extras = Map.ofList [
              "leavetracks", "true"
              "movestate", "0.0"
              "nochasecategory", "VTOL"
              "trackoffset", "-8.0"
              "trackstrength", "8.0"
              "tracktype", "armbull_tracks"
              "trackwidth", "40.0"
              "usepiececollisionvolumes", "1.0"
          ] }

    let armmerl : UnitDef =
        { name = "armmerl"
          subfolder = "ArmVehicles/T2"
          metalCost = ValueOrExpr.Concrete 920.0
          energyCost = ValueOrExpr.Concrete 6500.0
          buildTime = ValueOrExpr.Concrete 21000.0
          health = ValueOrExpr.Concrete 1220.0
          sightDistance = ValueOrExpr.Concrete 247.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMMERL.s3o"
          buildPic = Some "ARMMERL.DDS"
          script = Some "Units/ARMMERL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largexplosiongeneric"
          selfDestructAs = Some "largeExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "46 30 54"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 33.0
              maxAcc = 0.02489
              maxDec = 0.04978
              turnRate = 520.29999
              movementClass = Some "HTANK4"
              maxSlope = Some 16.0
              maxWaterDepth = Some 12.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 0.792
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "armtruck_rocket"
                displayName = Some "Heavy long-range g2g high-trajectory starburst rocket launcher"
                weaponType = Some "StarburstLauncher"
                damage = Map.ofList [
                    "commanders", 625.0
                    "default", 1900.0
                    "subs", 500.0
                ]
                range = Some (ValueOrExpr.Concrete 1300.0)
                reloadTime = Some (ValueOrExpr.Concrete 18.0)
                weaponVelocity = Some 380.0
                areaOfEffect = Some 150.0
                accuracy = None
                turret = None
                tolerance = Some 4000.0
                edgeEffectiveness = Some 0.65
                impulseFactor = Some 0.8
                noSelfDamage = Some true
                soundStart = Some "Rockhvy1"
                soundHit = Some "xplomed4"
                explosiongenerator = Some "custom:genericshellexplosion-large-bomb"
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
                    "cegtag", "missiletrailmedium-starburst"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "100.0"
                    "flighttime", "10.0"
                    "metalpershot", "0.0"
                    "model", "corshiprocket.s3o"
                    "smokecolor", "0.7"
                    "smokeperiod", "9.0"
                    "smokesize", "16.0"
                    "smoketime", "45.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splslrg"
                    "texture1", "null"
                    "texture2", "smoketrailbar"
                    "texture3", "null"
                    "turnrate", "15000.0"
                    "weaponacceleration", "100.0"
                    "weapontimer", "3.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "46 30 54"
                collisionVolumeType = Some "Box"
                damage = Some 1812.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 560.0
                object_ = Some "Units/armmerl_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 906.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 224.0
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
              ok = ["varmmove"]
              select = ["varmsel"] })
          customParams = Map.ofList [
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmVehicles/T2"
              "techlevel", "2.0"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "leavetracks", "true"
              "movestate", "0.0"
              "nochasecategory", "MOBILE VTOL"
              "stealth", "true"
              "trackoffset", "15.0"
              "trackstrength", "8.0"
              "tracktype", "armcroc_tracks"
              "trackwidth", "44.0"
          ] }

    let armsacv : UnitDef =
        { name = "armsacv"
          subfolder = "ArmVehicles/T2"
          metalCost = ValueOrExpr.Concrete 450.0
          energyCost = ValueOrExpr.Concrete 6800.0
          buildTime = ValueOrExpr.Concrete 16000.0
          health = ValueOrExpr.Concrete 2050.0
          sightDistance = ValueOrExpr.Concrete 289.89999
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/LEGACV.s3o"
          buildPic = Some "LEGACV.DDS"
          script = Some "Units/LEGACV.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric-builder"
          selfDestructAs = Some "mediumExplosionGenericSelfd-builder"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "36 43 42"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 52.5
              maxAcc = 0.02963
              maxDec = 0.11852
              turnRate = 399.0
              movementClass = Some "TANK3"
              maxSlope = Some 16.0
              maxWaterDepth = Some 18.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.2342
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 250.0
              buildDistance = Some 136.0
              buildOptions = ["armafus"; "armageo"; "armmoho"; "armmmkr"; "armanni"; "armmercury"; "armsilo"; "armbrtha"; "armvulc"; "armvp"; "armavp"; "armsavp"; "armshltx"]
              terraformSpeed = Some 1250.0 })
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 20.0)
              metalMake = None
              energyStorage = Some 100.0
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "36 43 42"
                collisionVolumeType = Some "Box"
                damage = Some 1500.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 280.0
                object_ = Some "Units/legacv_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 1000.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 112.0
                object_ = Some "Units/arm3X3A.s3o"
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
              ok = ["varmmove"]
              select = ["varmsel"] })
          customParams = Map.ofList [
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmVehicles/T2"
              "techlevel", "2.0"
              "unitgroup", "buildert2"
          ]
          extras = Map.ofList [
              "leavetracks", "true"
              "radardistance", "50.0"
              "trackstrength", "6.0"
              "tracktype", "arm_acv_tracks_2"
              "trackwidth", "36.0"
          ] }

    let armseer : UnitDef =
        { name = "armseer"
          subfolder = "ArmVehicles/T2"
          metalCost = ValueOrExpr.Concrete 125.0
          energyCost = ValueOrExpr.Concrete 2000.0
          buildTime = ValueOrExpr.Concrete 7500.0
          health = ValueOrExpr.Concrete 980.0
          sightDistance = ValueOrExpr.Concrete 900.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMSEER.s3o"
          buildPic = Some "ARMSEER.DDS"
          script = Some "Units/ARMSEER.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallexplosiongeneric"
          selfDestructAs = Some "smallExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -4 0"
          collisionVolumeScales = Some "28 30 34"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 57.0
              maxAcc = 0.04878
              maxDec = 0.09757
              turnRate = 605.0
              movementClass = Some "TANK3"
              maxSlope = Some 16.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.33584
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
                collisionVolumeOffsets = Some "0 -4 0"
                collisionVolumeScales = Some "28 30 34"
                collisionVolumeType = Some "Box"
                damage = Some 700.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 80.0
                object_ = Some "Units/armseer_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 500.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 48.0
                object_ = Some "Units/arm3X3E.s3o"
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
              ok = ["varmmove"]
              select = ["avradsel"] })
          customParams = Map.ofList [
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmVehicles/T2"
              "techlevel", "2.0"
              "unitgroup", "util"
          ]
          extras = Map.ofList [
              "canattack", "false"
              "leavetracks", "true"
              "movestate", "0.0"
              "onoffable", "false"
              "radardistance", "2300.0"
              "trackoffset", "5.0"
              "trackstrength", "5.0"
              "tracktype", "armseer_tracks"
              "trackwidth", "24.0"
          ] }

    let armyork : UnitDef =
        { name = "armyork"
          subfolder = "ArmVehicles/T2"
          metalCost = ValueOrExpr.Concrete 450.0
          energyCost = ValueOrExpr.Concrete 9100.0
          buildTime = ValueOrExpr.Concrete 13000.0
          health = ValueOrExpr.Concrete 2600.0
          sightDistance = ValueOrExpr.Concrete 390.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMYORK.s3o"
          buildPic = Some "ARMYORK.DDS"
          script = Some "Units/ARMYORK.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -10 -2"
          collisionVolumeScales = Some "31 31 38"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 70.5
              maxAcc = 0.06111
              maxDec = 0.12223
              turnRate = 618.20001
              movementClass = Some "TANK3"
              maxSlope = Some 16.0
              maxWaterDepth = Some 12.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.63786
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
                range = Some (ValueOrExpr.Concrete 775.0)
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
              { name = "mobileflak"
                displayName = Some "Heavy g2a flak cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "vtol", 200.0
                ]
                range = Some (ValueOrExpr.Concrete 775.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.73333)
                weaponVelocity = Some 1550.0
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
                    "cylindertargeting", "2.0"
                    "mygravity", "0.01"
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
                collisionVolumeOffsets = Some "0 -10 -2"
                collisionVolumeScales = Some "31 31 38"
                collisionVolumeType = Some "box"
                damage = Some 1900.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 276.0
                object_ = Some "Units/armyork_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 1500.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 110.0
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
              ok = ["varmmove"]
              select = ["varmsel"] })
          customParams = Map.ofList [
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmVehicles/T2"
              "techlevel", "2.0"
              "unitgroup", "aa"
          ]
          extras = Map.ofList [
              "airsightdistance", "900.0"
              "leavetracks", "true"
              "movestate", "0.0"
              "nochasecategory", "NOTAIR"
              "trackoffset", "6.0"
              "trackstrength", "5.0"
              "tracktype", "armyork_tracks"
              "trackwidth", "33.0"
          ] }

    let all : (string * UnitDef) list =
        [
            "armacv", armacv
            "armbull", armbull
            "armconsul", armconsul
            "armcroc", armcroc
            "armgremlin", armgremlin
            "armhacv", armhacv
            "armjam", armjam
            "armlatnk", armlatnk
            "armmanni", armmanni
            "armmart", armmart
            "armmerl", armmerl
            "armsacv", armsacv
            "armseer", armseer
            "armyork", armyork
        ]
