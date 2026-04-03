// Auto-generated BAR unit data: ArmShips (unified)
namespace BarData.Units

open BarData

module ArmShips =

    type Armcs =
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
          canMove: bool
          floater: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          minWaterDepth: float
          waterline: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          energyMake: ValueOrExpr<float>
          energyStorage: float
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string> }

    let armcs : Armcs =
        { name = "armcs"
          subfolder = "ArmShips"
          metalCost = ValueOrExpr.Concrete 200.0
          energyCost = ValueOrExpr.Concrete 2000.0
          buildTime = ValueOrExpr.Concrete 3460.0
          health = ValueOrExpr.Concrete 1040.0
          sightDistance = ValueOrExpr.Concrete 400.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMCS.s3o"
          buildPic = Some "ARMCS.DDS"
          script = Some "Units/ARMCS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric-builder"
          selfDestructAs = Some "mediumexplosiongenericSelfd-builder"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "30 30 50"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 65.4
          maxAcc = 0.04022
          maxDec = 0.04022
          turnRate = 405.0
          movementClass = "BOAT3"
          canMove = true
          floater = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          minWaterDepth = 15.0
          waterline = 0.0
          workerTime = ValueOrExpr.Concrete 125.0
          buildDistance = 200.0
          buildOptions = ["armmex"; "armvp"; "armap"; "armlab"; "armeyes"; "armdl"; "armdrag"; "armclaw"; "armguard"; "armtide"; "armgeo"; "armuwgeo"; "armfmkr"; "armuwms"; "armuwes"; "armsy"; "armasy"; "armnanotcplat"; "armfhp"; "armamsub"; "armplat"; "armfrad"; "armfdrag"; "armtl"; "armfrt"; "armfhlt"]
          terraformSpeed = 1250.0
          energyMake = ValueOrExpr.Concrete 7.0
          energyStorage = 50.0
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.322250366211 4.26757812502e-05 -0.458877563477"
                  collisionVolumeScales = Some "30.6897277832 28.4224853516 48.3307495117"
                  collisionVolumeType = Some "Box"
                  damage = Some 1326.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 4.0
                  metal = Some 100.0
                  object_ = Some "Units/armcs_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 1432.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 50.0
                  object_ = Some "Units/arm5X5A.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = Some "nanlath1"
                repair = Some "repair1"
                working = Some "reclaim1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["sharmmov"]
                select = ["sharmsel"] }
          customParams = Map.ofList [
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmShips"
                "unitgroup", "builder"
            ] }

    let armcsDef : UnitDef =
        { name = "armcs"
          subfolder = "ArmShips"
          metalCost = ValueOrExpr.Concrete 200.0
          energyCost = ValueOrExpr.Concrete 2000.0
          buildTime = ValueOrExpr.Concrete 3460.0
          health = ValueOrExpr.Concrete 1040.0
          sightDistance = ValueOrExpr.Concrete 400.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMCS.s3o"
          buildPic = Some "ARMCS.DDS"
          script = Some "Units/ARMCS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric-builder"
          selfDestructAs = Some "mediumexplosiongenericSelfd-builder"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "30 30 50"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 65.4
              maxAcc = 0.04022
              maxDec = 0.04022
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
              minWaterDepth = Some 15.0
              waterline = Some 0.0 })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 125.0
              buildDistance = Some 200.0
              buildOptions = ["armmex"; "armvp"; "armap"; "armlab"; "armeyes"; "armdl"; "armdrag"; "armclaw"; "armguard"; "armtide"; "armgeo"; "armuwgeo"; "armfmkr"; "armuwms"; "armuwes"; "armsy"; "armasy"; "armnanotcplat"; "armfhp"; "armamsub"; "armplat"; "armfrad"; "armfdrag"; "armtl"; "armfrt"; "armfhlt"]
              terraformSpeed = Some 1250.0 })
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
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.322250366211 4.26757812502e-05 -0.458877563477"
                collisionVolumeScales = Some "30.6897277832 28.4224853516 48.3307495117"
                collisionVolumeType = Some "Box"
                damage = Some 1326.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 4.0
                metal = Some 100.0
                object_ = Some "Units/armcs_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 1432.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 50.0
                object_ = Some "Units/arm5X5A.s3o"
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
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmShips"
              "unitgroup", "builder"
          ]
          extras = Map.empty }

    let armcsToFlat (def: UnitDef) : Armcs =
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
          canMove = def.movement.Value.canMove
          floater = def.movement.Value.floater
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          minWaterDepth = def.movement.Value.minWaterDepth.Value
          waterline = def.movement.Value.waterline.Value
          workerTime = def.builder.Value.workerTime
          buildDistance = def.builder.Value.buildDistance.Value
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyMake = def.economy.Value.energyMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams }

    let armcsToUnitDef (flat: Armcs) : UnitDef =
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
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = flat.canMove
              floater = flat.floater
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some flat.minWaterDepth
              waterline = Some flat.waterline
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
          extras = Map.empty }

    type Armdecade =
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
          canMove: bool
          floater: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          minWaterDepth: float
          waterline: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armdecade : Armdecade =
        { name = "armdecade"
          subfolder = "ArmShips"
          metalCost = ValueOrExpr.Concrete 175.0
          energyCost = ValueOrExpr.Concrete 1500.0
          buildTime = ValueOrExpr.Concrete 2450.0
          health = ValueOrExpr.Concrete 970.0
          sightDistance = ValueOrExpr.Concrete 375.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMDECADE.s3o"
          buildPic = Some "ARMDECADE.DDS"
          script = Some "Units/ARMDECADE.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumexplosiongenericSelfd"
          collisionVolumeOffsets = Some "0 -7 -1"
          collisionVolumeScales = Some "21 25 62"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 104.7
          maxAcc = 0.1004
          maxDec = 0.1004
          turnRate = 450.0
          movementClass = "BOAT3"
          canMove = true
          floater = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          minWaterDepth = 12.0
          waterline = 0.0
          weapons = [
                { name = "emg"
                  displayName = "Rapid-fire close-quarters plasma turret"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 9.0
                      "vtol", 2.0
                  ]
                  range = Some (ValueOrExpr.Concrete 280.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.4)
                  weaponVelocity = Some 500.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "flashemg"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small-yellow"
                  rgbColor = Some "1 0.95 0.4"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "285.0"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "burst", "3.0"
                      "burstrate", "0.1"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "intensity", "0.7"
                      "size", "1.75"
                      "soundhitwet", "splshbig"
                      "sprayangle", "900.0"
                      "weapontimer", "0.1"
                  ] }
                { name = "emg"
                  displayName = "Rapid-fire close-quarters plasma turret"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 9.0
                      "vtol", 2.0
                  ]
                  range = Some (ValueOrExpr.Concrete 280.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.4)
                  weaponVelocity = Some 500.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "flashemg"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small-yellow"
                  rgbColor = Some "1 0.95 0.4"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "0 0 -1"
                      "mount_maxangledif", "285.0"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "burst", "3.0"
                      "burstrate", "0.1"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "intensity", "0.7"
                      "size", "1.75"
                      "soundhitwet", "splshbig"
                      "sprayangle", "900.0"
                      "weapontimer", "0.1"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-4.64749145508 -7.42665378418 -1.15311431885"
                  collisionVolumeScales = Some "32.7630615234 17.5484924316 65.1112213135"
                  collisionVolumeType = Some "Box"
                  damage = Some 300.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 82.5
                  object_ = Some "Units/armdecade_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 500.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 41.25
                  object_ = Some "Units/arm4X4B.s3o"
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
                ok = ["sharmmov"]
                select = ["sharmsel"] }
          customParams = Map.ofList [
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmShips"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "buildangle", "16384.0"
                "nochasecategory", "UNDERWATER VTOL"
            ] }

    let armdecadeDef : UnitDef =
        { name = "armdecade"
          subfolder = "ArmShips"
          metalCost = ValueOrExpr.Concrete 175.0
          energyCost = ValueOrExpr.Concrete 1500.0
          buildTime = ValueOrExpr.Concrete 2450.0
          health = ValueOrExpr.Concrete 970.0
          sightDistance = ValueOrExpr.Concrete 375.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMDECADE.s3o"
          buildPic = Some "ARMDECADE.DDS"
          script = Some "Units/ARMDECADE.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumexplosiongenericSelfd"
          collisionVolumeOffsets = Some "0 -7 -1"
          collisionVolumeScales = Some "21 25 62"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 104.7
              maxAcc = 0.1004
              maxDec = 0.1004
              turnRate = 450.0
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
              minWaterDepth = Some 12.0
              waterline = Some 0.0 })
          builder = None
          weapons = Some [
              { name = "emg"
                displayName = "Rapid-fire close-quarters plasma turret"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 9.0
                    "vtol", 2.0
                ]
                range = Some (ValueOrExpr.Concrete 280.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.4)
                weaponVelocity = Some 500.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "flashemg"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-small-yellow"
                rgbColor = Some "1 0.95 0.4"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "285.0"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "burst", "3.0"
                    "burstrate", "0.1"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "intensity", "0.7"
                    "size", "1.75"
                    "soundhitwet", "splshbig"
                    "sprayangle", "900.0"
                    "weapontimer", "0.1"
                ] }
              { name = "emg"
                displayName = "Rapid-fire close-quarters plasma turret"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 9.0
                    "vtol", 2.0
                ]
                range = Some (ValueOrExpr.Concrete 280.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.4)
                weaponVelocity = Some 500.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "flashemg"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-small-yellow"
                rgbColor = Some "1 0.95 0.4"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "0 0 -1"
                    "mount_maxangledif", "285.0"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "burst", "3.0"
                    "burstrate", "0.1"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "intensity", "0.7"
                    "size", "1.75"
                    "soundhitwet", "splshbig"
                    "sprayangle", "900.0"
                    "weapontimer", "0.1"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "-4.64749145508 -7.42665378418 -1.15311431885"
                collisionVolumeScales = Some "32.7630615234 17.5484924316 65.1112213135"
                collisionVolumeType = Some "Box"
                damage = Some 300.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 82.5
                object_ = Some "Units/armdecade_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 500.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 41.25
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
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmShips"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "buildangle", "16384.0"
              "nochasecategory", "UNDERWATER VTOL"
          ] }

    let armdecadeToFlat (def: UnitDef) : Armdecade =
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
          canMove = def.movement.Value.canMove
          floater = def.movement.Value.floater
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          minWaterDepth = def.movement.Value.minWaterDepth.Value
          waterline = def.movement.Value.waterline.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armdecadeToUnitDef (flat: Armdecade) : UnitDef =
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
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = flat.canMove
              floater = flat.floater
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some flat.minWaterDepth
              waterline = Some flat.waterline
            }
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armpship =
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
          canMove: bool
          floater: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          minWaterDepth: float
          waterline: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armpship : Armpship =
        { name = "armpship"
          subfolder = "ArmShips"
          metalCost = ValueOrExpr.Concrete 380.0
          energyCost = ValueOrExpr.Concrete 2550.0
          buildTime = ValueOrExpr.Concrete 4250.0
          health = ValueOrExpr.Concrete 2150.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMPSHIP.s3o"
          buildPic = Some "ARMPSHIP.DDS"
          script = Some "Units/ARMPSHIP.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumExplosionGeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -4 1"
          collisionVolumeScales = Some "26 26 76"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 81.0
          maxAcc = 0.04771
          maxDec = 0.04771
          turnRate = 375.0
          movementClass = "BOAT4"
          canMove = true
          floater = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          minWaterDepth = 6.0
          waterline = 0.0
          weapons = [
                { name = "plasma"
                  displayName = "Light long-range plasma cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 70.0
                      "subs", 70.0
                      "vtol", 37.0
                  ]
                  range = Some (ValueOrExpr.Concrete 470.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.2)
                  weaponVelocity = Some 290.0
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
                      "mount_badtargetcategory", "LIGHTAIRSCOUT UNDERWATER"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "predictboost", "0.4"
                      "size", "2.0"
                      "soundhitwet", "splshbig"
                  ] }
                { name = "plasma"
                  displayName = "Light long-range plasma cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 70.0
                      "subs", 70.0
                      "vtol", 37.0
                  ]
                  range = Some (ValueOrExpr.Concrete 470.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.2)
                  weaponVelocity = Some 290.0
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
                      "mount_badtargetcategory", "LIGHTAIRSCOUT UNDERWATER"
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "290.0"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "predictboost", "0.4"
                      "size", "2.0"
                      "soundhitwet", "splshbig"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.255500793457 0.0 -1.26264953613"
                  collisionVolumeScales = Some "20.0704803467 16.0 67.0992736816"
                  collisionVolumeType = Some "Box"
                  damage = Some 500.0
                  featureDead = Some "HEAP"
                  footprintX = Some 1.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 195.0
                  object_ = Some "Units/armpship_dead.s3o"
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
                  metal = Some 97.5
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
                ok = ["sharmmov"]
                select = ["sharmsel"] }
          customParams = Map.ofList [
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmShips"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "nochasecategory", "VTOL UNDERWATER"
            ] }

    let armpshipDef : UnitDef =
        { name = "armpship"
          subfolder = "ArmShips"
          metalCost = ValueOrExpr.Concrete 380.0
          energyCost = ValueOrExpr.Concrete 2550.0
          buildTime = ValueOrExpr.Concrete 4250.0
          health = ValueOrExpr.Concrete 2150.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMPSHIP.s3o"
          buildPic = Some "ARMPSHIP.DDS"
          script = Some "Units/ARMPSHIP.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumExplosionGeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -4 1"
          collisionVolumeScales = Some "26 26 76"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 81.0
              maxAcc = 0.04771
              maxDec = 0.04771
              turnRate = 375.0
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
              { name = "plasma"
                displayName = "Light long-range plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 70.0
                    "subs", 70.0
                    "vtol", 37.0
                ]
                range = Some (ValueOrExpr.Concrete 470.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.2)
                weaponVelocity = Some 290.0
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
                    "mount_badtargetcategory", "LIGHTAIRSCOUT UNDERWATER"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "predictboost", "0.4"
                    "size", "2.0"
                    "soundhitwet", "splshbig"
                ] }
              { name = "plasma"
                displayName = "Light long-range plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 70.0
                    "subs", 70.0
                    "vtol", 37.0
                ]
                range = Some (ValueOrExpr.Concrete 470.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.2)
                weaponVelocity = Some 290.0
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
                    "mount_badtargetcategory", "LIGHTAIRSCOUT UNDERWATER"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "290.0"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "predictboost", "0.4"
                    "size", "2.0"
                    "soundhitwet", "splshbig"
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
                footprintX = Some 1.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 195.0
                object_ = Some "Units/armpship_dead.s3o"
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
                metal = Some 97.5
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
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmShips"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "blocking", "true"
              "nochasecategory", "VTOL UNDERWATER"
          ] }

    let armpshipToFlat (def: UnitDef) : Armpship =
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
          canMove = def.movement.Value.canMove
          floater = def.movement.Value.floater
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          minWaterDepth = def.movement.Value.minWaterDepth.Value
          waterline = def.movement.Value.waterline.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armpshipToUnitDef (flat: Armpship) : UnitDef =
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
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = flat.canMove
              floater = flat.floater
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some flat.minWaterDepth
              waterline = Some flat.waterline
            }
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armpt =
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
          canMove: bool
          floater: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          minWaterDepth: float
          waterline: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armpt : Armpt =
        { name = "armpt"
          subfolder = "ArmShips"
          metalCost = ValueOrExpr.Concrete 150.0
          energyCost = ValueOrExpr.Concrete 1000.0
          buildTime = ValueOrExpr.Concrete 2700.0
          health = ValueOrExpr.Concrete 780.0
          sightDistance = ValueOrExpr.Concrete 750.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMPT.s3o"
          buildPic = Some "ARMPT.DDS"
          script = Some "Units/ARMPT.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumExplosionGeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -5 0"
          collisionVolumeScales = Some "24 24 48"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 93.0
          maxAcc = 0.07011
          maxDec = 0.07011
          turnRate = 540.0
          movementClass = "BOAT3"
          canMove = true
          floater = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          minWaterDepth = 6.0
          waterline = 0.0
          weapons = [
                { name = "laser"
                  displayName = "Light close-quarters laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 24.0
                      "vtol", 5.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.36667)
                  weaponVelocity = Some 750.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrfir1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small-yellow"
                  rgbColor = Some "1 1 0.3"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "LIGHTAIRSCOUT"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "beamtime", "0.1"
                      "corethickness", "0.1"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "0.02"
                      "energypershot", "0.0"
                      "firestarter", "50.0"
                      "impactonly", "1.0"
                      "laserflaresize", "3.3"
                      "rgbcolor2", "1 0.55 0.3"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "1.0"
                  ] }
                { name = "aamissile"
                  displayName = "Light g2a missile launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "vtol", 80.0
                  ]
                  range = Some (ValueOrExpr.Concrete 760.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.4)
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
                  explosiongenerator = Some "custom:genericshellexplosion-small-air"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "LIGHTAIRSCOUT"
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
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.255500793457 0.0 -1.26264953613"
                  collisionVolumeScales = Some "20.0704803467 16.0 67.0992736816"
                  collisionVolumeType = Some "Box"
                  damage = Some 500.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 95.0
                  object_ = Some "Units/armpt_dead.s3o"
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
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 47.5
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
                ok = ["sharmmov"]
                select = ["sharmsel"] }
          customParams = Map.ofList [
                "maxrange", "260"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "paralyzemultiplier", "1.0"
                "subfolder", "ArmShips"
                "unitgroup", "weaponaa"
            ]
          extras = Map.ofList [
                "airsightdistance", "800.0"
                "movestate", "0.0"
                "nochasecategory", "VTOL UNDERWATER"
                "radardistance", "1000.0"
                "radaremitheight", "15.0"
                "sonardistance", "400.0"
                "stealth", "true"
            ] }

    let armptDef : UnitDef =
        { name = "armpt"
          subfolder = "ArmShips"
          metalCost = ValueOrExpr.Concrete 150.0
          energyCost = ValueOrExpr.Concrete 1000.0
          buildTime = ValueOrExpr.Concrete 2700.0
          health = ValueOrExpr.Concrete 780.0
          sightDistance = ValueOrExpr.Concrete 750.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMPT.s3o"
          buildPic = Some "ARMPT.DDS"
          script = Some "Units/ARMPT.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumExplosionGeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -5 0"
          collisionVolumeScales = Some "24 24 48"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 93.0
              maxAcc = 0.07011
              maxDec = 0.07011
              turnRate = 540.0
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
          weapons = Some [
              { name = "laser"
                displayName = "Light close-quarters laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 24.0
                    "vtol", 5.0
                ]
                range = Some (ValueOrExpr.Concrete 300.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.36667)
                weaponVelocity = Some 750.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrfir1"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-small-yellow"
                rgbColor = Some "1 1 0.3"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "LIGHTAIRSCOUT"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamtime", "0.1"
                    "corethickness", "0.1"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.02"
                    "energypershot", "0.0"
                    "firestarter", "50.0"
                    "impactonly", "1.0"
                    "laserflaresize", "3.3"
                    "rgbcolor2", "1 0.55 0.3"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "1.0"
                ] }
              { name = "aamissile"
                displayName = "Light g2a missile launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 80.0
                ]
                range = Some (ValueOrExpr.Concrete 760.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.4)
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
                explosiongenerator = Some "custom:genericshellexplosion-small-air"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "LIGHTAIRSCOUT"
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
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.255500793457 0.0 -1.26264953613"
                collisionVolumeScales = Some "20.0704803467 16.0 67.0992736816"
                collisionVolumeType = Some "Box"
                damage = Some 500.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 95.0
                object_ = Some "Units/armpt_dead.s3o"
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
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 47.5
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
              "maxrange", "260"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "paralyzemultiplier", "1.0"
              "subfolder", "ArmShips"
              "unitgroup", "weaponaa"
          ]
          extras = Map.ofList [
              "airsightdistance", "800.0"
              "movestate", "0.0"
              "nochasecategory", "VTOL UNDERWATER"
              "radardistance", "1000.0"
              "radaremitheight", "15.0"
              "sonardistance", "400.0"
              "stealth", "true"
          ] }

    let armptToFlat (def: UnitDef) : Armpt =
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
          canMove = def.movement.Value.canMove
          floater = def.movement.Value.floater
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          minWaterDepth = def.movement.Value.minWaterDepth.Value
          waterline = def.movement.Value.waterline.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armptToUnitDef (flat: Armpt) : UnitDef =
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
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = flat.canMove
              floater = flat.floater
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some flat.minWaterDepth
              waterline = Some flat.waterline
            }
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armrecl =
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
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          minWaterDepth: float
          waterline: float
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armrecl : Armrecl =
        { name = "armrecl"
          subfolder = "ArmShips"
          metalCost = ValueOrExpr.Concrete 240.0
          energyCost = ValueOrExpr.Concrete 3500.0
          buildTime = ValueOrExpr.Concrete 6200.0
          health = ValueOrExpr.Concrete 420.0
          sightDistance = ValueOrExpr.Concrete 300.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMRECL.s3o"
          buildPic = Some "ARMRECL.DDS"
          script = Some "Units/ARMRECL.cob"
          corpse = None
          explodeAs = Some "smallexplosiongeneric-uw"
          selfDestructAs = Some "smallexplosiongenericSelfd-uw"
          collisionVolumeOffsets = Some "0 0 -5"
          collisionVolumeScales = Some "38 20 65"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 66.0
          maxAcc = 0.05262
          maxDec = 0.05262
          turnRate = 525.0
          movementClass = "UBOAT4"
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          minWaterDepth = 15.0
          waterline = 80.0
          sounds =
              { build = Some "nanlath1"
                repair = Some "repair1"
                working = Some "reclaim1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = Some "capture1"
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["sucormov"]
                select = ["sucorsel"] }
          customParams = Map.ofList [
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmShips"
                "unitgroup", "builder"
            ]
          extras = Map.ofList [
                "autoheal", "5.0"
                "canassist", "false"
                "canresurrect", "true"
                "sonardistance", "150.0"
            ] }

    let armreclDef : UnitDef =
        { name = "armrecl"
          subfolder = "ArmShips"
          metalCost = ValueOrExpr.Concrete 240.0
          energyCost = ValueOrExpr.Concrete 3500.0
          buildTime = ValueOrExpr.Concrete 6200.0
          health = ValueOrExpr.Concrete 420.0
          sightDistance = ValueOrExpr.Concrete 300.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMRECL.s3o"
          buildPic = Some "ARMRECL.DDS"
          script = Some "Units/ARMRECL.cob"
          corpse = None
          explodeAs = Some "smallexplosiongeneric-uw"
          selfDestructAs = Some "smallexplosiongenericSelfd-uw"
          collisionVolumeOffsets = Some "0 0 -5"
          collisionVolumeScales = Some "38 20 65"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 66.0
              maxAcc = 0.05262
              maxDec = 0.05262
              turnRate = 525.0
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
              waterline = Some 80.0 })
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
              capture = Some "capture1"
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["sucormov"]
              select = ["sucorsel"] })
          customParams = Map.ofList [
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmShips"
              "unitgroup", "builder"
          ]
          extras = Map.ofList [
              "autoheal", "5.0"
              "canassist", "false"
              "canresurrect", "true"
              "sonardistance", "150.0"
          ] }

    let armreclToFlat (def: UnitDef) : Armrecl =
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
          canMove = def.movement.Value.canMove
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          minWaterDepth = def.movement.Value.minWaterDepth.Value
          waterline = def.movement.Value.waterline.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armreclToUnitDef (flat: Armrecl) : UnitDef =
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
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some flat.minWaterDepth
              waterline = Some flat.waterline
            }
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armroy =
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
          canMove: bool
          floater: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          minWaterDepth: float
          waterline: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armroy : Armroy =
        { name = "armroy"
          subfolder = "ArmShips"
          metalCost = ValueOrExpr.Concrete 880.0
          energyCost = ValueOrExpr.Concrete 6600.0
          buildTime = ValueOrExpr.Concrete 10200.0
          health = ValueOrExpr.Concrete 3700.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMROY.s3o"
          buildPic = Some "ARMROY.DDS"
          script = Some "Units/ARMROY.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumExplosionGeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -10 1"
          collisionVolumeScales = Some "35 35 83"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 67.2
          maxAcc = 0.03061
          maxDec = 0.03061
          turnRate = 300.0
          movementClass = "BOAT4"
          canMove = true
          floater = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          minWaterDepth = 12.0
          waterline = 0.0
          weapons = [
                { name = "plasma"
                  displayName = "Heavy long-range plasma cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 235.0
                      "vtol", 55.0
                  ]
                  range = Some (ValueOrExpr.Concrete 700.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.6)
                  weaponVelocity = Some 325.5
                  areaOfEffect = Some 48.0
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
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_fastautoretargeting", "true"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "soundhitwet", "splshbig"
                  ] }
                { name = "depthcharge"
                  displayName = "Depthcharge launcher"
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
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "300.0"
                      "mount_onlytargetcategory", "CANBEUW UNDERWATER"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "burnblow", "true"
                      "collidefriendly", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "flighttime", "3.0"
                      "model", "cordepthcharge.s3o"
                      "predictboost", "0.0"
                      "startvelocity", "120.0"
                      "tracks", "true"
                      "turnrate", "9000.0"
                      "waterweapon", "true"
                      "weaponacceleration", "20.0"
                      "weapontimer", "3.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.164245605469 8.02001953204e-06 -0.56591796875"
                  collisionVolumeScales = Some "31.5542297363 37.44581604 80.6425476074"
                  collisionVolumeType = Some "Box"
                  damage = Some 3090.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 4.0
                  metal = Some 440.0
                  object_ = Some "Units/armroy_dead.s3o"
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
                  metal = Some 220.0
                  object_ = Some "Units/arm5X5B.s3o"
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
                ok = ["sharmmov"]
                select = ["sharmsel"] }
          customParams = Map.ofList [
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmShips"
                "unitgroup", "weaponsub"
            ]
          extras = Map.ofList [
                "buildangle", "16384.0"
                "movestate", "0.0"
                "nochasecategory", "VTOL"
                "sonardistance", "375.0"
            ] }

    let armroyDef : UnitDef =
        { name = "armroy"
          subfolder = "ArmShips"
          metalCost = ValueOrExpr.Concrete 880.0
          energyCost = ValueOrExpr.Concrete 6600.0
          buildTime = ValueOrExpr.Concrete 10200.0
          health = ValueOrExpr.Concrete 3700.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMROY.s3o"
          buildPic = Some "ARMROY.DDS"
          script = Some "Units/ARMROY.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumExplosionGeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -10 1"
          collisionVolumeScales = Some "35 35 83"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 67.2
              maxAcc = 0.03061
              maxDec = 0.03061
              turnRate = 300.0
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
              minWaterDepth = Some 12.0
              waterline = Some 0.0 })
          builder = None
          weapons = Some [
              { name = "plasma"
                displayName = "Heavy long-range plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 235.0
                    "vtol", 55.0
                ]
                range = Some (ValueOrExpr.Concrete 700.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.6)
                weaponVelocity = Some 325.5
                areaOfEffect = Some 48.0
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
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_fastautoretargeting", "true"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splshbig"
                ] }
              { name = "depthcharge"
                displayName = "Depthcharge launcher"
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
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "300.0"
                    "mount_onlytargetcategory", "CANBEUW UNDERWATER"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "flighttime", "3.0"
                    "model", "cordepthcharge.s3o"
                    "predictboost", "0.0"
                    "startvelocity", "120.0"
                    "tracks", "true"
                    "turnrate", "9000.0"
                    "waterweapon", "true"
                    "weaponacceleration", "20.0"
                    "weapontimer", "3.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.164245605469 8.02001953204e-06 -0.56591796875"
                collisionVolumeScales = Some "31.5542297363 37.44581604 80.6425476074"
                collisionVolumeType = Some "Box"
                damage = Some 3090.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 4.0
                metal = Some 440.0
                object_ = Some "Units/armroy_dead.s3o"
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
                metal = Some 220.0
                object_ = Some "Units/arm5X5B.s3o"
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
              "subfolder", "ArmShips"
              "unitgroup", "weaponsub"
          ]
          extras = Map.ofList [
              "buildangle", "16384.0"
              "movestate", "0.0"
              "nochasecategory", "VTOL"
              "sonardistance", "375.0"
          ] }

    let armroyToFlat (def: UnitDef) : Armroy =
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
          canMove = def.movement.Value.canMove
          floater = def.movement.Value.floater
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          minWaterDepth = def.movement.Value.minWaterDepth.Value
          waterline = def.movement.Value.waterline.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armroyToUnitDef (flat: Armroy) : UnitDef =
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
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = flat.canMove
              floater = flat.floater
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some flat.minWaterDepth
              waterline = Some flat.waterline
            }
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armsub =
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
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          minWaterDepth: float
          waterline: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armsub : Armsub =
        { name = "armsub"
          subfolder = "ArmShips"
          metalCost = ValueOrExpr.Concrete 440.0
          energyCost = ValueOrExpr.Concrete 3100.0
          buildTime = ValueOrExpr.Concrete 5800.0
          health = ValueOrExpr.Concrete 840.0
          sightDistance = ValueOrExpr.Concrete 400.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMSUB.s3o"
          buildPic = Some "ARMSUB.DDS"
          script = Some "Units/ARMSUB.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallExplosionGeneric-uw"
          selfDestructAs = Some "smallExplosionGenericSelfd-uw"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "30 20 43"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 66.0
          maxAcc = 0.04592
          maxDec = 0.04592
          turnRate = 480.0
          movementClass = "UBOAT4"
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          minWaterDepth = 15.0
          waterline = 45.0
          weapons = [
                { name = "torpedo"
                  displayName = "Light torpedo launcher"
                  weaponType = Some "TorpedoLauncher"
                  damage = Map.ofList [
                      "default", 342.0
                  ]
                  range = Some (ValueOrExpr.Concrete 500.0)
                  reloadTime = Some (ValueOrExpr.Concrete 4.0)
                  weaponVelocity = Some 200.0
                  areaOfEffect = Some 64.0
                  accuracy = None
                  turret = Some false
                  tolerance = Some 12000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "torpedo1"
                  soundHit = Some "xplodep1"
                  explosiongenerator = Some "custom:genericshellexplosion-small-uw"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "HOVER NOTSHIP"
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "110.0"
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
                      "soundhitvolume", "15.0"
                      "startvelocity", "130.0"
                      "turnrate", "12000.0"
                      "waterweapon", "true"
                      "weaponacceleration", "15.0"
                      "weapontimer", "3.25"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-1.03743743896 -3.82080078154e-06 -0.269828796387"
                  collisionVolumeScales = Some "40.4452667236 15.0652923584 47.2016448975"
                  collisionVolumeType = Some "Box"
                  damage = Some 1002.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 200.0
                  object_ = Some "Units/armsub_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 4032.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 125.0
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
                ok = ["suarmmov"]
                select = ["suarmsel"] }
          customParams = Map.ofList [
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmShips"
                "unitgroup", "sub"
            ]
          extras = Map.ofList [
                "nochasecategory", "VTOL"
                "sonardistance", "400.0"
                "upright", "true"
            ] }

    let armsubDef : UnitDef =
        { name = "armsub"
          subfolder = "ArmShips"
          metalCost = ValueOrExpr.Concrete 440.0
          energyCost = ValueOrExpr.Concrete 3100.0
          buildTime = ValueOrExpr.Concrete 5800.0
          health = ValueOrExpr.Concrete 840.0
          sightDistance = ValueOrExpr.Concrete 400.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMSUB.s3o"
          buildPic = Some "ARMSUB.DDS"
          script = Some "Units/ARMSUB.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallExplosionGeneric-uw"
          selfDestructAs = Some "smallExplosionGenericSelfd-uw"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "30 20 43"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 66.0
              maxAcc = 0.04592
              maxDec = 0.04592
              turnRate = 480.0
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
              waterline = Some 45.0 })
          builder = None
          weapons = Some [
              { name = "torpedo"
                displayName = "Light torpedo launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 342.0
                ]
                range = Some (ValueOrExpr.Concrete 500.0)
                reloadTime = Some (ValueOrExpr.Concrete 4.0)
                weaponVelocity = Some 200.0
                areaOfEffect = Some 64.0
                accuracy = None
                turret = Some false
                tolerance = Some 12000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "torpedo1"
                soundHit = Some "xplodep1"
                explosiongenerator = Some "custom:genericshellexplosion-small-uw"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "HOVER NOTSHIP"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "110.0"
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
                    "soundhitvolume", "15.0"
                    "startvelocity", "130.0"
                    "turnrate", "12000.0"
                    "waterweapon", "true"
                    "weaponacceleration", "15.0"
                    "weapontimer", "3.25"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "-1.03743743896 -3.82080078154e-06 -0.269828796387"
                collisionVolumeScales = Some "40.4452667236 15.0652923584 47.2016448975"
                collisionVolumeType = Some "Box"
                damage = Some 1002.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 200.0
                object_ = Some "Units/armsub_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 4032.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 125.0
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
              ok = ["suarmmov"]
              select = ["suarmsel"] })
          customParams = Map.ofList [
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmShips"
              "unitgroup", "sub"
          ]
          extras = Map.ofList [
              "nochasecategory", "VTOL"
              "sonardistance", "400.0"
              "upright", "true"
          ] }

    let armsubToFlat (def: UnitDef) : Armsub =
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
          canMove = def.movement.Value.canMove
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          minWaterDepth = def.movement.Value.minWaterDepth.Value
          waterline = def.movement.Value.waterline.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armsubToUnitDef (flat: Armsub) : UnitDef =
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
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some flat.minWaterDepth
              waterline = Some flat.waterline
            }
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armtorps =
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
          canMove: bool
          floater: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          minWaterDepth: float
          waterline: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armtorps : Armtorps =
        { name = "armtorps"
          subfolder = "ArmShips"
          metalCost = ValueOrExpr.Concrete 300.0
          energyCost = ValueOrExpr.Concrete 3000.0
          buildTime = ValueOrExpr.Concrete 2350.0
          health = ValueOrExpr.Concrete 940.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMMLS.s3o"
          buildPic = Some "ARMMLS.DDS"
          script = Some "Units/ARMTORPS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumexplosiongenericSelfd"
          collisionVolumeOffsets = Some "-2 -3 -5"
          collisionVolumeScales = Some "24 24 62"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 90.0
          maxAcc = 0.07
          maxDec = 0.07
          turnRate = 330.0
          movementClass = "BOAT3"
          canMove = true
          floater = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          minWaterDepth = 12.0
          waterline = 0.0
          weapons = [
                { name = "torpedo"
                  displayName = "Torpedo"
                  weaponType = Some "TorpedoLauncher"
                  damage = Map.ofList [
                      "commanders", 420.0
                      "default", 455.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 10.0)
                  weaponVelocity = Some 250.0
                  areaOfEffect = Some 64.0
                  accuracy = None
                  turret = Some false
                  tolerance = Some 12000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "torpedo1"
                  soundHit = Some "xplodep1"
                  explosiongenerator = Some "custom:genericshellexplosion-small-uw"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "HOVER NOTSHIP"
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "60.0"
                      "mount_onlytargetcategory", "NOTHOVER"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "burnblow", "true"
                      "collidefriendly", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "flighttime", "3.0"
                      "model", "torpedo.s3o"
                      "predictboost", "0.7"
                      "startvelocity", "100.0"
                      "tracks", "true"
                      "turnrate", "12000.0"
                      "waterweapon", "true"
                      "weaponacceleration", "25.0"
                      "weapontimer", "3.25"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-0.0500030517578 -0.0636029345703 -0.0"
                  collisionVolumeScales = Some "33.75 14.0462341309 88.0440979004"
                  collisionVolumeType = Some "Box"
                  damage = Some 1726.0
                  featureDead = Some "HEAP"
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 20.0
                  metal = Some 100.0
                  object_ = Some "Units/cormls_dead.s3o"
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
                  metal = Some 50.0
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
                ok = ["shcormov"]
                select = ["shcorsel"] }
          customParams = Map.ofList [
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "ArmShips"
                "unitgroup", "sub"
            ]
          extras = Map.ofList [
                "buildangle", "16384.0"
                "nochasecategory", "UNDERWATER VTOL"
                "sonardistance", "500.0"
            ] }

    let armtorpsDef : UnitDef =
        { name = "armtorps"
          subfolder = "ArmShips"
          metalCost = ValueOrExpr.Concrete 300.0
          energyCost = ValueOrExpr.Concrete 3000.0
          buildTime = ValueOrExpr.Concrete 2350.0
          health = ValueOrExpr.Concrete 940.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMMLS.s3o"
          buildPic = Some "ARMMLS.DDS"
          script = Some "Units/ARMTORPS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumexplosiongenericSelfd"
          collisionVolumeOffsets = Some "-2 -3 -5"
          collisionVolumeScales = Some "24 24 62"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 90.0
              maxAcc = 0.07
              maxDec = 0.07
              turnRate = 330.0
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
              minWaterDepth = Some 12.0
              waterline = Some 0.0 })
          builder = None
          weapons = Some [
              { name = "torpedo"
                displayName = "Torpedo"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "commanders", 420.0
                    "default", 455.0
                ]
                range = Some (ValueOrExpr.Concrete 300.0)
                reloadTime = Some (ValueOrExpr.Concrete 10.0)
                weaponVelocity = Some 250.0
                areaOfEffect = Some 64.0
                accuracy = None
                turret = Some false
                tolerance = Some 12000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "torpedo1"
                soundHit = Some "xplodep1"
                explosiongenerator = Some "custom:genericshellexplosion-small-uw"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "HOVER NOTSHIP"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "60.0"
                    "mount_onlytargetcategory", "NOTHOVER"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "flighttime", "3.0"
                    "model", "torpedo.s3o"
                    "predictboost", "0.7"
                    "startvelocity", "100.0"
                    "tracks", "true"
                    "turnrate", "12000.0"
                    "waterweapon", "true"
                    "weaponacceleration", "25.0"
                    "weapontimer", "3.25"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "-0.0500030517578 -0.0636029345703 -0.0"
                collisionVolumeScales = Some "33.75 14.0462341309 88.0440979004"
                collisionVolumeType = Some "Box"
                damage = Some 1726.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 100.0
                object_ = Some "Units/cormls_dead.s3o"
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
                metal = Some 50.0
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
              ok = ["shcormov"]
              select = ["shcorsel"] })
          customParams = Map.ofList [
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "ArmShips"
              "unitgroup", "sub"
          ]
          extras = Map.ofList [
              "buildangle", "16384.0"
              "nochasecategory", "UNDERWATER VTOL"
              "sonardistance", "500.0"
          ] }

    let armtorpsToFlat (def: UnitDef) : Armtorps =
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
          canMove = def.movement.Value.canMove
          floater = def.movement.Value.floater
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          minWaterDepth = def.movement.Value.minWaterDepth.Value
          waterline = def.movement.Value.waterline.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armtorpsToUnitDef (flat: Armtorps) : UnitDef =
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
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = flat.canMove
              floater = flat.floater
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some flat.minWaterDepth
              waterline = Some flat.waterline
            }
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

