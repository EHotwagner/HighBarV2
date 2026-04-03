// Auto-generated BAR unit data: ArmBots (unified)
namespace BarData.Units

open BarData

module ArmBots =

    type Armck =
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
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          energyMake: ValueOrExpr<float>
          energyStorage: float
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armck : Armck =
        { name = "armck"
          subfolder = "ArmBots"
          metalCost = ValueOrExpr.Concrete 110.0
          energyCost = ValueOrExpr.Concrete 1600.0
          buildTime = ValueOrExpr.Concrete 3450.0
          health = ValueOrExpr.Concrete 690.0
          sightDistance = ValueOrExpr.Concrete 305.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMCK.s3o"
          buildPic = Some "ARMCK.DDS"
          script = Some "Units/ARMCK.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallexplosiongeneric-builder"
          selfDestructAs = Some "smallExplosionGenericSelfd-builder"
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "27 30 27"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 36.0
          maxAcc = 0.552
          maxDec = 3.45
          turnRate = 1265.0
          movementClass = "BOT2"
          maxSlope = 20.0
          maxWaterDepth = 25.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 0.792
          workerTime = ValueOrExpr.Concrete 80.0
          buildDistance = 130.0
          buildOptions = ["armsolar"; "armadvsol"; "armwin"; "armgeo"; "armmstor"; "armestor"; "armmex"; "armamex"; "armmakr"; "armalab"; "armlab"; "armvp"; "armap"; "armhp"; "armnanotc"; "armeyes"; "armrad"; "armdrag"; "armclaw"; "armllt"; "armbeamer"; "armhlt"; "armguard"; "armrl"; "armferret"; "armcir"; "armdl"; "armjamt"; "armjuno"; "armsy"]
          terraformSpeed = 450.0
          energyMake = ValueOrExpr.Concrete 7.0
          energyStorage = 50.0
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "1.68473052979 1.77978515623e-05 -1.12860870361"
                  collisionVolumeScales = Some "28.1473846436 25.0852355957 27.3032073975"
                  collisionVolumeType = Some "Box"
                  damage = Some 424.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 40.0
                  metal = Some 66.0
                  object_ = Some "Units/armck_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 262.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 26.0
                  object_ = Some "Units/arm2X2D.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = Some "nanlath1"
                repair = Some "repair1"
                working = Some "reclaim1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = Some "capture1"
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["kbarmmov"]
                select = ["kbarmsel"] }
          customParams = Map.ofList [
                "model_author", "Kaiser"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBots"
                "unitgroup", "builder"
            ]
          extras = Map.ofList [
                "upright", "true"
            ] }

    let armckDef : UnitDef =
        { name = "armck"
          subfolder = "ArmBots"
          metalCost = ValueOrExpr.Concrete 110.0
          energyCost = ValueOrExpr.Concrete 1600.0
          buildTime = ValueOrExpr.Concrete 3450.0
          health = ValueOrExpr.Concrete 690.0
          sightDistance = ValueOrExpr.Concrete 305.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMCK.s3o"
          buildPic = Some "ARMCK.DDS"
          script = Some "Units/ARMCK.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallexplosiongeneric-builder"
          selfDestructAs = Some "smallExplosionGenericSelfd-builder"
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "27 30 27"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 36.0
              maxAcc = 0.552
              maxDec = 3.45
              turnRate = 1265.0
              movementClass = Some "BOT2"
              maxSlope = Some 20.0
              maxWaterDepth = Some 25.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 0.792
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 80.0
              buildDistance = Some 130.0
              buildOptions = ["armsolar"; "armadvsol"; "armwin"; "armgeo"; "armmstor"; "armestor"; "armmex"; "armamex"; "armmakr"; "armalab"; "armlab"; "armvp"; "armap"; "armhp"; "armnanotc"; "armeyes"; "armrad"; "armdrag"; "armclaw"; "armllt"; "armbeamer"; "armhlt"; "armguard"; "armrl"; "armferret"; "armcir"; "armdl"; "armjamt"; "armjuno"; "armsy"]
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
                collisionVolumeOffsets = Some "1.68473052979 1.77978515623e-05 -1.12860870361"
                collisionVolumeScales = Some "28.1473846436 25.0852355957 27.3032073975"
                collisionVolumeType = Some "Box"
                damage = Some 424.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 40.0
                metal = Some 66.0
                object_ = Some "Units/armck_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 262.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 26.0
                object_ = Some "Units/arm2X2D.s3o"
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
              ok = ["kbarmmov"]
              select = ["kbarmsel"] })
          customParams = Map.ofList [
              "model_author", "Kaiser"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmBots"
              "unitgroup", "builder"
          ]
          extras = Map.ofList [
              "upright", "true"
          ] }

    let armckToFlat (def: UnitDef) : Armck =
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
          workerTime = def.builder.Value.workerTime
          buildDistance = def.builder.Value.buildDistance.Value
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyMake = def.economy.Value.energyMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armckToUnitDef (flat: Armck) : UnitDef =
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
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = Some flat.buildDistance
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = None
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

    type Armflea =
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

    let armflea : Armflea =
        { name = "armflea"
          subfolder = "ArmBots"
          metalCost = ValueOrExpr.Concrete 21.0
          energyCost = ValueOrExpr.Concrete 300.0
          buildTime = ValueOrExpr.Concrete 800.0
          health = ValueOrExpr.Concrete 60.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Units/ARMFLEA.s3o"
          buildPic = Some "ARMFLEA.DDS"
          script = Some "Units/ARMFLEA.cob"
          corpse = Some "DEAD"
          explodeAs = Some "tinyexplosiongeneric"
          selfDestructAs = Some "tinyexplosiongenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "20 12 20"
          collisionVolumeType = Some "cylY"
          seismicSignature = Some 0.0
          category = Some "GROUNDSCOUT"
          speed = ValueOrExpr.Concrete 132.0
          maxAcc = 0.575
          maxDec = 1.725
          turnRate = 1807.0
          movementClass = "SBOT2"
          maxSlope = 255.0
          maxWaterDepth = 16.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 2.904
          weapons = [
                { name = "flea_laser"
                  displayName = "Light Close-Quarters Fast-Firing g2g Laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 24.0
                      "vtol", 2.0
                  ]
                  range = Some (ValueOrExpr.Concrete 140.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.6)
                  weaponVelocity = Some 600.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrfir1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-tiny-yellow"
                  rgbColor = Some "1 1 0.4"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "beamtime", "0.1"
                      "beamttl", "1.0"
                      "burstrate", "0.2"
                      "corethickness", "0.1"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "0.0"
                      "firestarter", "50.0"
                      "impactonly", "1.0"
                      "laserflaresize", "1.65"
                      "rgbcolor2", "1 0.55 0.3"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "0.9"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.00276184082031 -0.139985849609 -0.0299072265625"
                  collisionVolumeScales = Some "18.3164367676 15.4085083008 17.7548828125"
                  collisionVolumeType = Some "Box"
                  damage = Some 30.0
                  featureDead = Some "HEAP"
                  footprintX = Some 1.0
                  footprintZ = Some 1.0
                  height = Some 20.0
                  metal = Some 9.0
                  object_ = Some "Units/armflea_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "21.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 15.0
                  featureDead = None
                  footprintX = Some 1.0
                  footprintZ = Some 1.0
                  height = Some 4.0
                  metal = Some 4.0
                  object_ = Some "Units/arm1X1A.s3o"
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
                ok = ["servtny2"]
                select = ["servtny2"] }
          customParams = Map.ofList [
                "model_author", "Kaiser"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBots"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "movestate", "0.0"
                "nochasecategory", "VTOL"
            ] }

    let armfleaDef : UnitDef =
        { name = "armflea"
          subfolder = "ArmBots"
          metalCost = ValueOrExpr.Concrete 21.0
          energyCost = ValueOrExpr.Concrete 300.0
          buildTime = ValueOrExpr.Concrete 800.0
          health = ValueOrExpr.Concrete 60.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Units/ARMFLEA.s3o"
          buildPic = Some "ARMFLEA.DDS"
          script = Some "Units/ARMFLEA.cob"
          corpse = Some "DEAD"
          explodeAs = Some "tinyexplosiongeneric"
          selfDestructAs = Some "tinyexplosiongenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "20 12 20"
          collisionVolumeType = Some "cylY"
          seismicSignature = Some 0.0
          category = Some "GROUNDSCOUT"
          movement = Some (
            { speed = ValueOrExpr.Concrete 132.0
              maxAcc = 0.575
              maxDec = 1.725
              turnRate = 1807.0
              movementClass = Some "SBOT2"
              maxSlope = Some 255.0
              maxWaterDepth = Some 16.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 2.904
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "flea_laser"
                displayName = "Light Close-Quarters Fast-Firing g2g Laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 24.0
                    "vtol", 2.0
                ]
                range = Some (ValueOrExpr.Concrete 140.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.6)
                weaponVelocity = Some 600.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrfir1"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-tiny-yellow"
                rgbColor = Some "1 1 0.4"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamtime", "0.1"
                    "beamttl", "1.0"
                    "burstrate", "0.2"
                    "corethickness", "0.1"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "0.0"
                    "firestarter", "50.0"
                    "impactonly", "1.0"
                    "laserflaresize", "1.65"
                    "rgbcolor2", "1 0.55 0.3"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "0.9"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.00276184082031 -0.139985849609 -0.0299072265625"
                collisionVolumeScales = Some "18.3164367676 15.4085083008 17.7548828125"
                collisionVolumeType = Some "Box"
                damage = Some 30.0
                featureDead = Some "HEAP"
                footprintX = Some 1.0
                footprintZ = Some 1.0
                height = Some 20.0
                metal = Some 9.0
                object_ = Some "Units/armflea_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "21.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 15.0
                featureDead = None
                footprintX = Some 1.0
                footprintZ = Some 1.0
                height = Some 4.0
                metal = Some 4.0
                object_ = Some "Units/arm1X1A.s3o"
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
              ok = ["servtny2"]
              select = ["servtny2"] })
          customParams = Map.ofList [
              "model_author", "Kaiser"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmBots"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "movestate", "0.0"
              "nochasecategory", "VTOL"
          ] }

    let armfleaToFlat (def: UnitDef) : Armflea =
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

    let armfleaToUnitDef (flat: Armflea) : UnitDef =
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

    type Armham =
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

    let armham : Armham =
        { name = "armham"
          subfolder = "ArmBots"
          metalCost = ValueOrExpr.Concrete 130.0
          energyCost = ValueOrExpr.Concrete 1300.0
          buildTime = ValueOrExpr.Concrete 2200.0
          health = ValueOrExpr.Concrete 1000.0
          sightDistance = ValueOrExpr.Concrete 380.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMHAM.s3o"
          buildPic = Some "ARMHAM.DDS"
          script = Some "Units/ARMHAM.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallexplosiongeneric"
          selfDestructAs = Some "smallExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -2 0"
          collisionVolumeScales = Some "29 30 29"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 46.2
          maxAcc = 0.138
          maxDec = 0.77625
          turnRate = 1258.09998
          movementClass = "BOT3"
          maxSlope = 14.0
          maxWaterDepth = 12.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.0164
          weapons = [
                { name = "arm_ham"
                  displayName = "Light g2g plasma cannon (low trajectory)"
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
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "1.85908508301 -3.40689422363 2.59911346436"
                  collisionVolumeScales = Some "31.0182495117 8.18759155273 36.3284454346"
                  collisionVolumeType = Some "Box"
                  damage = Some 586.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 40.0
                  metal = Some 79.0
                  object_ = Some "Units/armham_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 343.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 32.0
                  object_ = Some "Units/arm2X2E.s3o"
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
                "model_author", "Kaiser"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBots"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "mass", "300.0"
                "movestate", "0.0"
                "nochasecategory", "VTOL"
                "upright", "true"
            ] }

    let armhamDef : UnitDef =
        { name = "armham"
          subfolder = "ArmBots"
          metalCost = ValueOrExpr.Concrete 130.0
          energyCost = ValueOrExpr.Concrete 1300.0
          buildTime = ValueOrExpr.Concrete 2200.0
          health = ValueOrExpr.Concrete 1000.0
          sightDistance = ValueOrExpr.Concrete 380.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMHAM.s3o"
          buildPic = Some "ARMHAM.DDS"
          script = Some "Units/ARMHAM.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallexplosiongeneric"
          selfDestructAs = Some "smallExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -2 0"
          collisionVolumeScales = Some "29 30 29"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 46.2
              maxAcc = 0.138
              maxDec = 0.77625
              turnRate = 1258.09998
              movementClass = Some "BOT3"
              maxSlope = Some 14.0
              maxWaterDepth = Some 12.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.0164
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "arm_ham"
                displayName = "Light g2g plasma cannon (low trajectory)"
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
                collisionVolumeOffsets = Some "1.85908508301 -3.40689422363 2.59911346436"
                collisionVolumeScales = Some "31.0182495117 8.18759155273 36.3284454346"
                collisionVolumeType = Some "Box"
                damage = Some 586.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 40.0
                metal = Some 79.0
                object_ = Some "Units/armham_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 343.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 32.0
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
              ok = ["kbarmmov"]
              select = ["kbarmsel"] })
          customParams = Map.ofList [
              "model_author", "Kaiser"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmBots"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "mass", "300.0"
              "movestate", "0.0"
              "nochasecategory", "VTOL"
              "upright", "true"
          ] }

    let armhamToFlat (def: UnitDef) : Armham =
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

    let armhamToUnitDef (flat: Armham) : UnitDef =
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

    type Armjeth =
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
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armjeth : Armjeth =
        { name = "armjeth"
          subfolder = "ArmBots"
          metalCost = ValueOrExpr.Concrete 125.0
          energyCost = ValueOrExpr.Concrete 1100.0
          buildTime = ValueOrExpr.Concrete 1830.0
          health = ValueOrExpr.Concrete 630.0
          sightDistance = ValueOrExpr.Concrete 377.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMJETH.s3o"
          buildPic = Some "ARMJETH.DDS"
          script = Some "Units/ARMJETH.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallExplosionGeneric-phib"
          selfDestructAs = Some "smallExplosionGenericSelfd-phib"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "28 30 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 56.25
          maxAcc = 0.138
          maxDec = 0.6486
          turnRate = 1285.69995
          movementClass = "ABOT3"
          maxSlope = 15.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.2375
          weapons = [
                { name = "bogus_missile"
                  displayName = "Missiles"
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
                { name = "armbot_missile"
                  displayName = "Light g2a missile launcher"
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
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "NOTAIR LIGHTAIRSCOUT"
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
                      "turnrate", "63000.0"
                      "weaponacceleration", "141.0"
                      "weapontimer", "5.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "5.17987060547 -4.3375112793 -4.29997253418"
                  collisionVolumeScales = Some "29.3736572266 14.4243774414 27.4587402344"
                  collisionVolumeType = Some "Box"
                  damage = Some 442.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 40.0
                  metal = Some 75.0
                  object_ = Some "Units/armjeth_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 271.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 30.0
                  object_ = Some "Units/arm2X2C.s3o"
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
                "model_author", "Kaiser, PtaQ"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBots"
                "unitgroup", "aa"
            ]
          extras = Map.ofList [
                "airsightdistance", "800.0"
                "movestate", "0.0"
                "nochasecategory", "NOTAIR"
                "upright", "true"
            ] }

    let armjethDef : UnitDef =
        { name = "armjeth"
          subfolder = "ArmBots"
          metalCost = ValueOrExpr.Concrete 125.0
          energyCost = ValueOrExpr.Concrete 1100.0
          buildTime = ValueOrExpr.Concrete 1830.0
          health = ValueOrExpr.Concrete 630.0
          sightDistance = ValueOrExpr.Concrete 377.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMJETH.s3o"
          buildPic = Some "ARMJETH.DDS"
          script = Some "Units/ARMJETH.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallExplosionGeneric-phib"
          selfDestructAs = Some "smallExplosionGenericSelfd-phib"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "28 30 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 56.25
              maxAcc = 0.138
              maxDec = 0.6486
              turnRate = 1285.69995
              movementClass = Some "ABOT3"
              maxSlope = Some 15.0
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.2375
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "bogus_missile"
                displayName = "Missiles"
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
              { name = "armbot_missile"
                displayName = "Light g2a missile launcher"
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
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR LIGHTAIRSCOUT"
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
                collisionVolumeOffsets = Some "5.17987060547 -4.3375112793 -4.29997253418"
                collisionVolumeScales = Some "29.3736572266 14.4243774414 27.4587402344"
                collisionVolumeType = Some "Box"
                damage = Some 442.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 40.0
                metal = Some 75.0
                object_ = Some "Units/armjeth_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 271.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 30.0
                object_ = Some "Units/arm2X2C.s3o"
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
              "model_author", "Kaiser, PtaQ"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmBots"
              "unitgroup", "aa"
          ]
          extras = Map.ofList [
              "airsightdistance", "800.0"
              "movestate", "0.0"
              "nochasecategory", "NOTAIR"
              "upright", "true"
          ] }

    let armjethToFlat (def: UnitDef) : Armjeth =
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
          canMove = def.movement.Value.canMove
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armjethToUnitDef (flat: Armjeth) : UnitDef =
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
              maxWaterDepth = None
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

    type Armpw =
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

    let armpw : Armpw =
        { name = "armpw"
          subfolder = "ArmBots"
          metalCost = ValueOrExpr.Concrete 54.0
          energyCost = ValueOrExpr.Concrete 900.0
          buildTime = ValueOrExpr.Concrete 1650.0
          health = ValueOrExpr.Concrete 370.0
          sightDistance = ValueOrExpr.Concrete 429.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMPW.s3o"
          buildPic = Some "ARMPW.DDS"
          script = Some "Units/ARMPW.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallExplosionGeneric"
          selfDestructAs = Some "smallExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "22 30 22"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 87.0
          maxAcc = 0.414
          maxDec = 0.69
          turnRate = 1214.40002
          movementClass = "BOT2"
          maxSlope = 17.0
          maxWaterDepth = 12.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.848
          weapons = [
                { name = "emg"
                  displayName = "Rapid-fire close-quarters g2g plasma guns"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 9.0
                      "vtol", 3.0
                  ]
                  range = Some (ValueOrExpr.Concrete 180.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.3)
                  weaponVelocity = Some 600.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "flashemg"
                  soundHit = None
                  explosiongenerator = Some "custom:plasmahit-small"
                  rgbColor = Some "1 0.95 0.4"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "burst", "3.0"
                      "burstrate", "0.1"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "100.0"
                      "flighttime", "0.4"
                      "gravityaffected", "true"
                      "intensity", "0.7"
                      "size", "1.75"
                      "soundhitwet", "splshbig"
                      "sprayangle", "1180.0"
                      "weapontimer", "0.1"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.979118347168 -0.453806965332 -0.796119689941"
                  collisionVolumeScales = Some "30.1392364502 18.4953460693 29.797164917"
                  collisionVolumeType = Some "Box"
                  damage = Some 192.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 40.0
                  metal = Some 29.0
                  object_ = Some "Units/armpw_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 96.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 12.0
                  object_ = Some "Units/arm2X2F.s3o"
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
                ok = ["servtny2"]
                select = ["servtny2"] }
          customParams = Map.ofList [
                "model_author", "Kaiser"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBots"
                "unitgroup", "weapon"
                "weapon1turretx", "300.0"
                "weapon1turrety", "300.0"
            ]
          extras = Map.ofList [
                "nochasecategory", "VTOL"
                "upright", "true"
            ] }

    let armpwDef : UnitDef =
        { name = "armpw"
          subfolder = "ArmBots"
          metalCost = ValueOrExpr.Concrete 54.0
          energyCost = ValueOrExpr.Concrete 900.0
          buildTime = ValueOrExpr.Concrete 1650.0
          health = ValueOrExpr.Concrete 370.0
          sightDistance = ValueOrExpr.Concrete 429.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMPW.s3o"
          buildPic = Some "ARMPW.DDS"
          script = Some "Units/ARMPW.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallExplosionGeneric"
          selfDestructAs = Some "smallExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "22 30 22"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 87.0
              maxAcc = 0.414
              maxDec = 0.69
              turnRate = 1214.40002
              movementClass = Some "BOT2"
              maxSlope = Some 17.0
              maxWaterDepth = Some 12.0
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
              { name = "emg"
                displayName = "Rapid-fire close-quarters g2g plasma guns"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 9.0
                    "vtol", 3.0
                ]
                range = Some (ValueOrExpr.Concrete 180.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.3)
                weaponVelocity = Some 600.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "flashemg"
                soundHit = None
                explosiongenerator = Some "custom:plasmahit-small"
                rgbColor = Some "1 0.95 0.4"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "burst", "3.0"
                    "burstrate", "0.1"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "firestarter", "100.0"
                    "flighttime", "0.4"
                    "gravityaffected", "true"
                    "intensity", "0.7"
                    "size", "1.75"
                    "soundhitwet", "splshbig"
                    "sprayangle", "1180.0"
                    "weapontimer", "0.1"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.979118347168 -0.453806965332 -0.796119689941"
                collisionVolumeScales = Some "30.1392364502 18.4953460693 29.797164917"
                collisionVolumeType = Some "Box"
                damage = Some 192.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 40.0
                metal = Some 29.0
                object_ = Some "Units/armpw_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 96.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 12.0
                object_ = Some "Units/arm2X2F.s3o"
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
              ok = ["servtny2"]
              select = ["servtny2"] })
          customParams = Map.ofList [
              "model_author", "Kaiser"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmBots"
              "unitgroup", "weapon"
              "weapon1turretx", "300.0"
              "weapon1turrety", "300.0"
          ]
          extras = Map.ofList [
              "nochasecategory", "VTOL"
              "upright", "true"
          ] }

    let armpwToFlat (def: UnitDef) : Armpw =
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

    let armpwToUnitDef (flat: Armpw) : UnitDef =
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

    type Armrectr =
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
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armrectr : Armrectr =
        { name = "armrectr"
          subfolder = "ArmBots"
          metalCost = ValueOrExpr.Concrete 130.0
          energyCost = ValueOrExpr.Concrete 1400.0
          buildTime = ValueOrExpr.Concrete 2800.0
          health = ValueOrExpr.Concrete 220.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMRECTR.s3o"
          buildPic = Some "ARMRECTR.DDS"
          script = Some "Units/ARMRECTR.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallbuilder"
          selfDestructAs = Some "smallbuilderSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "24 32 24"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 78.0
          maxAcc = 0.23
          maxDec = 0.8625
          turnRate = 1290.29993
          movementClass = "BOT2"
          maxSlope = 14.0
          maxWaterDepth = 22.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.716
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 -5.0193 1.03799438477"
                  collisionVolumeScales = Some "20.0 11.0 10.0759887695"
                  collisionVolumeType = Some "Box"
                  damage = Some 764.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 72.0
                  object_ = Some "Units/armrectr_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 344.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 36.0
                  object_ = Some "Units/arm2X2D.s3o"
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
                ok = ["necrok1"]
                select = ["necrsel1"] }
          customParams = Map.ofList [
                "model_author", "Kaiser"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBots"
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

    let armrectrDef : UnitDef =
        { name = "armrectr"
          subfolder = "ArmBots"
          metalCost = ValueOrExpr.Concrete 130.0
          energyCost = ValueOrExpr.Concrete 1400.0
          buildTime = ValueOrExpr.Concrete 2800.0
          health = ValueOrExpr.Concrete 220.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMRECTR.s3o"
          buildPic = Some "ARMRECTR.DDS"
          script = Some "Units/ARMRECTR.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallbuilder"
          selfDestructAs = Some "smallbuilderSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "24 32 24"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 78.0
              maxAcc = 0.23
              maxDec = 0.8625
              turnRate = 1290.29993
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
                collisionVolumeOffsets = Some "0.0 -5.0193 1.03799438477"
                collisionVolumeScales = Some "20.0 11.0 10.0759887695"
                collisionVolumeType = Some "Box"
                damage = Some 764.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 72.0
                object_ = Some "Units/armrectr_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 344.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 36.0
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
              ok = ["necrok1"]
              select = ["necrsel1"] })
          customParams = Map.ofList [
              "model_author", "Kaiser"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmBots"
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

    let armrectrToFlat (def: UnitDef) : Armrectr =
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
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armrectrToUnitDef (flat: Armrectr) : UnitDef =
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
          weapons = None
          economy = None
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armrock =
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

    let armrock : Armrock =
        { name = "armrock"
          subfolder = "ArmBots"
          metalCost = ValueOrExpr.Concrete 120.0
          energyCost = ValueOrExpr.Concrete 1000.0
          buildTime = ValueOrExpr.Concrete 2010.0
          health = ValueOrExpr.Concrete 720.0
          sightDistance = ValueOrExpr.Concrete 338.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMROCK.s3o"
          buildPic = Some "ARMROCK.DDS"
          script = Some "Units/ARMROCK.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallExplosionGeneric"
          selfDestructAs = Some "smallExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 2"
          collisionVolumeScales = Some "24 28 24"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 50.7
          maxAcc = 0.138
          maxDec = 0.6486
          turnRate = 1271.90002
          movementClass = "BOT2"
          maxSlope = 14.0
          maxWaterDepth = 12.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.1484
          weapons = [
                { name = "arm_bot_rocket"
                  displayName = "Medium g2g rocket launcher"
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
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "29.8971862793 8.38395690918 32.6823883057"
                  collisionVolumeType = Some "Box"
                  damage = Some 490.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 40.0
                  metal = Some 63.0
                  object_ = Some "Units/armrock_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 295.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 25.0
                  object_ = Some "Units/arm2X2B.s3o"
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
                "model_author", "Kaiser"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBots"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "movestate", "0.0"
                "nochasecategory", "VTOL"
                "upright", "true"
            ] }

    let armrockDef : UnitDef =
        { name = "armrock"
          subfolder = "ArmBots"
          metalCost = ValueOrExpr.Concrete 120.0
          energyCost = ValueOrExpr.Concrete 1000.0
          buildTime = ValueOrExpr.Concrete 2010.0
          health = ValueOrExpr.Concrete 720.0
          sightDistance = ValueOrExpr.Concrete 338.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMROCK.s3o"
          buildPic = Some "ARMROCK.DDS"
          script = Some "Units/ARMROCK.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallExplosionGeneric"
          selfDestructAs = Some "smallExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 2"
          collisionVolumeScales = Some "24 28 24"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 50.7
              maxAcc = 0.138
              maxDec = 0.6486
              turnRate = 1271.90002
              movementClass = Some "BOT2"
              maxSlope = Some 14.0
              maxWaterDepth = Some 12.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.1484
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "arm_bot_rocket"
                displayName = "Medium g2g rocket launcher"
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
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "29.8971862793 8.38395690918 32.6823883057"
                collisionVolumeType = Some "Box"
                damage = Some 490.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 40.0
                metal = Some 63.0
                object_ = Some "Units/armrock_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 295.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 25.0
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
              ok = ["kbarmmov"]
              select = ["kbarmsel"] })
          customParams = Map.ofList [
              "model_author", "Kaiser"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmBots"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "movestate", "0.0"
              "nochasecategory", "VTOL"
              "upright", "true"
          ] }

    let armrockToFlat (def: UnitDef) : Armrock =
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

    let armrockToUnitDef (flat: Armrock) : UnitDef =
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

    type Armwar =
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

    let armwar : Armwar =
        { name = "armwar"
          subfolder = "ArmBots"
          metalCost = ValueOrExpr.Concrete 270.0
          energyCost = ValueOrExpr.Concrete 3100.0
          buildTime = ValueOrExpr.Concrete 4200.0
          health = ValueOrExpr.Concrete 1590.0
          sightDistance = ValueOrExpr.Concrete 350.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMWAR.s3o"
          buildPic = Some "ARMWAR.DDS"
          script = Some "Units/ARMWAR.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallExplosionGeneric"
          selfDestructAs = Some "smallExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 1"
          collisionVolumeScales = Some "30 32 30"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 45.0
          maxAcc = 0.0828
          maxDec = 0.8211
          turnRate = 885.5
          movementClass = "BOT3"
          maxSlope = 17.0
          maxWaterDepth = 12.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 0.99
          weapons = [
                { name = "armwar_laser"
                  displayName = "Dual close-quarters g2g laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 55.0
                      "vtol", 9.0
                  ]
                  range = Some (ValueOrExpr.Concrete 325.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.3)
                  weaponVelocity = Some 950.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrfir3"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small-red"
                  rgbColor = Some "1 0 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_fastautoretargeting", "true"
                      "mount_fastquerypointupdate", "true"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "beamtime", "0.12"
                      "corethickness", "0.155"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "30.0"
                      "firetolerance", "4500.0"
                      "impactonly", "1.0"
                      "laserflaresize", "7.7"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "1.85"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-0.527076721191 -5.09926749023 6.06378173828"
                  collisionVolumeScales = Some "37.3442840576 10.0486450195 42.9995422363"
                  collisionVolumeType = Some "Box"
                  damage = Some 880.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 161.0
                  object_ = Some "Units/armwar_dead.s3o"
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
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 64.0
                  object_ = Some "Units/arm2X2A.s3o"
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
                "model_author", "Kaiser"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBots"
                "unitgroup", "weapon"
                "weapon1turretx", "200.0"
                "weapon1turrety", "200.0"
            ]
          extras = Map.ofList [
                "nochasecategory", "VTOL"
                "upright", "true"
            ] }

    let armwarDef : UnitDef =
        { name = "armwar"
          subfolder = "ArmBots"
          metalCost = ValueOrExpr.Concrete 270.0
          energyCost = ValueOrExpr.Concrete 3100.0
          buildTime = ValueOrExpr.Concrete 4200.0
          health = ValueOrExpr.Concrete 1590.0
          sightDistance = ValueOrExpr.Concrete 350.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMWAR.s3o"
          buildPic = Some "ARMWAR.DDS"
          script = Some "Units/ARMWAR.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallExplosionGeneric"
          selfDestructAs = Some "smallExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 1"
          collisionVolumeScales = Some "30 32 30"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 45.0
              maxAcc = 0.0828
              maxDec = 0.8211
              turnRate = 885.5
              movementClass = Some "BOT3"
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
              { name = "armwar_laser"
                displayName = "Dual close-quarters g2g laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 55.0
                    "vtol", 9.0
                ]
                range = Some (ValueOrExpr.Concrete 325.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.3)
                weaponVelocity = Some 950.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrfir3"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-small-red"
                rgbColor = Some "1 0 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_fastautoretargeting", "true"
                    "mount_fastquerypointupdate", "true"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamtime", "0.12"
                    "corethickness", "0.155"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "30.0"
                    "firetolerance", "4500.0"
                    "impactonly", "1.0"
                    "laserflaresize", "7.7"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "1.85"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "-0.527076721191 -5.09926749023 6.06378173828"
                collisionVolumeScales = Some "37.3442840576 10.0486450195 42.9995422363"
                collisionVolumeType = Some "Box"
                damage = Some 880.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 161.0
                object_ = Some "Units/armwar_dead.s3o"
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
                footprintX = Some 3.0
                footprintZ = Some 3.0
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
              "model_author", "Kaiser"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmBots"
              "unitgroup", "weapon"
              "weapon1turretx", "200.0"
              "weapon1turrety", "200.0"
          ]
          extras = Map.ofList [
              "nochasecategory", "VTOL"
              "upright", "true"
          ] }

    let armwarToFlat (def: UnitDef) : Armwar =
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

    let armwarToUnitDef (flat: Armwar) : UnitDef =
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

