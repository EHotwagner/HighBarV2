// Auto-generated BAR unit data: Scavengers/Boss (unified)
namespace BarData.Units

open BarData

module Scavengers_Boss =

    type Armcomboss =
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
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          energyMake: ValueOrExpr<float>
          metalMake: ValueOrExpr<float>
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armcomboss : Armcomboss =
        { name = "armcomboss"
          subfolder = "Scavengers/Boss"
          metalCost = ValueOrExpr.Concrete 10000000.0
          energyCost = ValueOrExpr.Concrete 10000000.0
          buildTime = ValueOrExpr.Concrete 750000000000.0
          health = ValueOrExpr.Concrete 2800000.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/scavboss/ARMCOMBOSS.s3o"
          buildPic = Some "scavengers/ARMCOMBOSS.DDS"
          script = Some "Units/ARMCOMBOSS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "ScavComBossExplo"
          selfDestructAs = Some "ScavComBossExplo"
          collisionVolumeOffsets = Some "0 7 0"
          collisionVolumeScales = Some "75 160 75"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 15.0
          maxAcc = 0.18
          maxDec = 0.6
          turnRate = 500.0
          movementClass = "SCAVCOMMANDERBOT"
          maxSlope = 25.0
          maxWaterDepth = 200.0
          canMove = true
          turnInPlaceAngleLimit = 140.0
          turnInPlaceSpeedLimit = 0.825
          workerTime = ValueOrExpr.Concrete 2000.0
          buildDistance = 750.0
          buildOptions = ["armbanth"; "corkorg"]
          terraformSpeed = 10000.0
          energyMake = ValueOrExpr.Concrete 250.0
          metalMake = ValueOrExpr.Concrete 5.0
          weapons = [
                { name = "armcomlaserboss"
                  displayName = "J8Laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 1000.0
                      "vtol", 4000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1250.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.0)
                  weaponVelocity = Some 900.0
                  areaOfEffect = Some 25.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "xplomas2"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-large-red"
                  rgbColor = Some "0.7 0.3 1"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "avoidfeature", "false"
                      "beamtime", "0.3"
                      "corethickness", "0.22"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "70.0"
                      "impactonly", "1.0"
                      "laserflaresize", "5.0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "12.0"
                  ] }
                { name = "armcomsealaserboss"
                  displayName = "J8NSLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 1000.0
                      "vtol", 4000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1250.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.0)
                  weaponVelocity = Some 1500.0
                  areaOfEffect = Some 35.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "xplomas2"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-large-blue"
                  rgbColor = Some "0.7 0.3 0.4"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "avoidfeature", "false"
                      "beamtime", "0.3"
                      "corethickness", "0.22"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "35.0"
                      "firesubmersed", "true"
                      "impactonly", "1.0"
                      "intensity", "0.3"
                      "laserflaresize", "5.0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "12.0"
                      "waterweapon", "true"
                  ] }
                { name = "disintegratorxl"
                  displayName = "Darkmatter Photon-Disruptor"
                  weaponType = Some "DGun"
                  damage = Map.ofList [
                      "default", 999999.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1250.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.0)
                  weaponVelocity = Some 375.0
                  areaOfEffect = Some 65.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "disigun1"
                  soundHit = Some "xplomas2"
                  explosiongenerator = Some "custom:burnblackbiggest"
                  rgbColor = Some "0.7 0.3 1.0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "avoidground", "false"
                      "bouncerebound", "0.0"
                      "cameraShake", "500.0"
                      "cegtag", "gausscannonprojectilexl"
                      "commandfire", "true"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "0.0"
                      "firestarter", "100.0"
                      "firesubmersed", "false"
                      "gravityaffected", "true"
                      "intensity", "4.0"
                      "noexplode", "true"
                      "size", "8.5"
                      "soundhitwet", "sizzlexs"
                      "soundtrigger", "true"
                      "waterweapon", "false"
                      "weapontimer", "4.2"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "110 28 110"
                  collisionVolumeType = Some "CylY"
                  damage = Some 10000.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 55.0
                  metal = Some 2500.0
                  object_ = Some "Units/scavboss/armcomboss_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 5000.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 1250.0
                  object_ = Some "Units/arm2X2F.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = Some "nanlath1"
                repair = Some "repair1"
                working = Some "reclaim1"
                underAttack = Some "warning2"
                cancelDestruct = Some "cancel2"
                capture = Some "capture1"
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["kcarmmov"]
                select = ["kcarmsel"] }
          customParams = Map.ofList [
                "unitgroup", "buildert4"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "paralyzemultiplier", "0.01"
                "subfolder", ""
                "techlevel", "4.0"
            ]
          extras = Map.ofList [
                "autoheal", "2000.0"
                "cancapture", "true"
                "canmanualfire", "true"
                "canresurrect", "true"
                "capturable", "false"
                "capturespeed", "6000.0"
                "hidedamage", "true"
                "sightemitheight", "100.0"
                "mass", "500000.0"
                "nochasecategory", "ALL"
                "radardistance", "2000.0"
                "radaremitheight", "100.0"
                "reclaimable", "false"
                "selfdestructcountdown", "5.0"
                "showplayername", "false"
                "sonardistance", "1000.0"
                "upright", "true"
            ] }

    let armcombossDef : UnitDef =
        { name = "armcomboss"
          subfolder = "Scavengers/Boss"
          metalCost = ValueOrExpr.Concrete 10000000.0
          energyCost = ValueOrExpr.Concrete 10000000.0
          buildTime = ValueOrExpr.Concrete 750000000000.0
          health = ValueOrExpr.Concrete 2800000.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/scavboss/ARMCOMBOSS.s3o"
          buildPic = Some "scavengers/ARMCOMBOSS.DDS"
          script = Some "Units/ARMCOMBOSS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "ScavComBossExplo"
          selfDestructAs = Some "ScavComBossExplo"
          collisionVolumeOffsets = Some "0 7 0"
          collisionVolumeScales = Some "75 160 75"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 15.0
              maxAcc = 0.18
              maxDec = 0.6
              turnRate = 500.0
              movementClass = Some "SCAVCOMMANDERBOT"
              maxSlope = Some 25.0
              maxWaterDepth = Some 200.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 140.0
              turnInPlaceSpeedLimit = Some 0.825
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 2000.0
              buildDistance = Some 750.0
              buildOptions = ["armbanth"; "corkorg"]
              terraformSpeed = Some 10000.0 })
          weapons = Some [
              { name = "armcomlaserboss"
                displayName = "J8Laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 1000.0
                    "vtol", 4000.0
                ]
                range = Some (ValueOrExpr.Concrete 1250.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.0)
                weaponVelocity = Some 900.0
                areaOfEffect = Some 25.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 1.0
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "xplomas2"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-large-red"
                rgbColor = Some "0.7 0.3 1"
                customParams = Map.empty
                extras = Map.ofList [
                    "avoidfeature", "false"
                    "beamtime", "0.3"
                    "corethickness", "0.22"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "firestarter", "70.0"
                    "impactonly", "1.0"
                    "laserflaresize", "5.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "12.0"
                ] }
              { name = "armcomsealaserboss"
                displayName = "J8NSLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 1000.0
                    "vtol", 4000.0
                ]
                range = Some (ValueOrExpr.Concrete 1250.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.0)
                weaponVelocity = Some 1500.0
                areaOfEffect = Some 35.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 1.0
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "xplomas2"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-large-blue"
                rgbColor = Some "0.7 0.3 0.4"
                customParams = Map.empty
                extras = Map.ofList [
                    "avoidfeature", "false"
                    "beamtime", "0.3"
                    "corethickness", "0.22"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "firestarter", "35.0"
                    "firesubmersed", "true"
                    "impactonly", "1.0"
                    "intensity", "0.3"
                    "laserflaresize", "5.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "12.0"
                    "waterweapon", "true"
                ] }
              { name = "disintegratorxl"
                displayName = "Darkmatter Photon-Disruptor"
                weaponType = Some "DGun"
                damage = Map.ofList [
                    "default", 999999.0
                ]
                range = Some (ValueOrExpr.Concrete 1250.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.0)
                weaponVelocity = Some 375.0
                areaOfEffect = Some 65.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 1.0
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "disigun1"
                soundHit = Some "xplomas2"
                explosiongenerator = Some "custom:burnblackbiggest"
                rgbColor = Some "0.7 0.3 1.0"
                customParams = Map.empty
                extras = Map.ofList [
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "avoidground", "false"
                    "bouncerebound", "0.0"
                    "cameraShake", "500.0"
                    "cegtag", "gausscannonprojectilexl"
                    "commandfire", "true"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "0.0"
                    "firestarter", "100.0"
                    "firesubmersed", "false"
                    "gravityaffected", "true"
                    "intensity", "4.0"
                    "noexplode", "true"
                    "size", "8.5"
                    "soundhitwet", "sizzlexs"
                    "soundtrigger", "true"
                    "waterweapon", "false"
                    "weapontimer", "4.2"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 250.0)
              metalMake = Some (ValueOrExpr.Concrete 5.0)
              energyStorage = None
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "110 28 110"
                collisionVolumeType = Some "CylY"
                damage = Some 10000.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 55.0
                metal = Some 2500.0
                object_ = Some "Units/scavboss/armcomboss_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 5000.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 1250.0
                object_ = Some "Units/arm2X2F.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = Some "nanlath1"
              repair = Some "repair1"
              working = Some "reclaim1"
              underAttack = Some "warning2"
              cancelDestruct = Some "cancel2"
              capture = Some "capture1"
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["kcarmmov"]
              select = ["kcarmsel"] })
          customParams = Map.ofList [
              "unitgroup", "buildert4"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "paralyzemultiplier", "0.01"
              "subfolder", ""
              "techlevel", "4.0"
          ]
          extras = Map.ofList [
              "autoheal", "2000.0"
              "cancapture", "true"
              "canmanualfire", "true"
              "canresurrect", "true"
              "capturable", "false"
              "capturespeed", "6000.0"
              "hidedamage", "true"
              "sightemitheight", "100.0"
              "mass", "500000.0"
              "nochasecategory", "ALL"
              "radardistance", "2000.0"
              "radaremitheight", "100.0"
              "reclaimable", "false"
              "selfdestructcountdown", "5.0"
              "showplayername", "false"
              "sonardistance", "1000.0"
              "upright", "true"
          ] }

    let armcombossToFlat (def: UnitDef) : Armcomboss =
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
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          workerTime = def.builder.Value.workerTime
          buildDistance = def.builder.Value.buildDistance.Value
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyMake = def.economy.Value.energyMake.Value
          metalMake = def.economy.Value.metalMake.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armcombossToUnitDef (flat: Armcomboss) : UnitDef =
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
              turnInPlace = None
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
          weapons = Some flat.weapons
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = Some flat.metalMake
              energyStorage = None
              metalStorage = None
              extractsMetal = None
            }
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corcomboss =
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
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          energyMake: ValueOrExpr<float>
          metalMake: ValueOrExpr<float>
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corcomboss : Corcomboss =
        { name = "corcomboss"
          subfolder = "Scavengers/Boss"
          metalCost = ValueOrExpr.Concrete 300000.0
          energyCost = ValueOrExpr.Concrete 3000000.0
          buildTime = ValueOrExpr.Concrete 300000.0
          health = ValueOrExpr.Concrete 300000.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/scavboss/CORCOMBOSS.s3o"
          buildPic = Some "scavengers/CORCOMBOSS.DDS"
          script = Some "Units/CORCOMBOSS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "ScavComBossExplo"
          selfDestructAs = Some "ScavComBossExplo"
          collisionVolumeOffsets = Some "0 7 0"
          collisionVolumeScales = Some "75 160 75"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 15.0
          maxAcc = 0.18
          maxDec = 0.6
          turnRate = 500.0
          movementClass = "SCAVCOMMANDERBOT"
          maxSlope = 25.0
          maxWaterDepth = 200.0
          canMove = true
          turnInPlaceAngleLimit = 140.0
          turnInPlaceSpeedLimit = 0.825
          workerTime = ValueOrExpr.Concrete 500.0
          buildDistance = 750.0
          buildOptions = ["armbanth"; "corkorg"]
          terraformSpeed = 10000.0
          energyMake = ValueOrExpr.Concrete 250.0
          metalMake = ValueOrExpr.Concrete 5.0
          weapons = [
                { name = "corcomlaserboss"
                  displayName = "J8Laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 200.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1250.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.0)
                  weaponVelocity = Some 900.0
                  areaOfEffect = Some 35.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "xplomas2"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-large-red"
                  rgbColor = Some "0.7 0.3 1"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfeature", "false"
                      "beamtime", "0.3"
                      "corethickness", "0.22"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "70.0"
                      "impactonly", "1.0"
                      "laserflaresize", "5.0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "12.0"
                  ] }
                { name = "corcomsealaserboss"
                  displayName = "J8NSLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 200.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1250.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.0)
                  weaponVelocity = Some 1500.0
                  areaOfEffect = Some 25.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "xplomas2"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-large-blue"
                  rgbColor = Some "0.7 0.3 1"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfeature", "false"
                      "beamtime", "0.3"
                      "corethickness", "0.22"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "35.0"
                      "firesubmersed", "true"
                      "impactonly", "1.0"
                      "intensity", "0.3"
                      "laserflaresize", "5.0"
                      "rgbcolor2", "0.7 0.3 0.4"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "12.0"
                      "waterweapon", "true"
                  ] }
                { name = "disintegratorxl"
                  displayName = "Darkmatter Photon-Disruptor"
                  weaponType = Some "DGun"
                  damage = Map.ofList [
                      "default", 999999.0
                  ]
                  range = Some (ValueOrExpr.Concrete 750.0)
                  reloadTime = Some (ValueOrExpr.Concrete 5.0)
                  weaponVelocity = Some 375.0
                  areaOfEffect = Some 65.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "disigun1"
                  soundHit = Some "xplomas2"
                  explosiongenerator = Some "custom:burnblackbiggest"
                  rgbColor = Some "0.7 0.3 1.0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "avoidground", "false"
                      "bouncerebound", "0.0"
                      "cameraShake", "500.0"
                      "cegtag", "gausscannonprojectilexl"
                      "commandfire", "true"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "0.0"
                      "firestarter", "100.0"
                      "firesubmersed", "false"
                      "gravityaffected", "true"
                      "intensity", "4.0"
                      "noexplode", "true"
                      "size", "8.5"
                      "soundhitwet", "sizzlexs"
                      "soundtrigger", "true"
                      "waterweapon", "false"
                      "weapontimer", "4.2"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "85 33 100"
                  collisionVolumeType = Some "cylY"
                  damage = Some 10000.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 55.0
                  metal = Some 150000.0
                  object_ = Some "Units/scavboss/corcomboss_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 5000.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 75000.0
                  object_ = Some "Units/cor2X2C.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = Some "nanlath2"
                repair = Some "repair2"
                working = Some "reclaim1"
                underAttack = Some "warning2"
                cancelDestruct = Some "cancel2"
                capture = Some "capture2"
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["kcormov"]
                select = ["kccorsel"] }
          customParams = Map.ofList [
                "unitgroup", "buildert4"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "paralyzemultiplier", "0.01"
                "subfolder", ""
                "techlevel", "4.0"
            ]
          extras = Map.ofList [
                "autoheal", "0.0"
                "cancapture", "true"
                "canmanualfire", "true"
                "canresurrect", "true"
                "capturable", "false"
                "capturespeed", "6000.0"
                "hidedamage", "true"
                "sightemitheight", "100.0"
                "mass", "500000.0"
                "nochasecategory", "ALL"
                "radardistance", "2000.0"
                "radaremitheight", "100.0"
                "reclaimable", "false"
                "selfdestructcountdown", "5.0"
                "showplayername", "false"
                "sonardistance", "1000.0"
                "upright", "true"
            ] }

    let corcombossDef : UnitDef =
        { name = "corcomboss"
          subfolder = "Scavengers/Boss"
          metalCost = ValueOrExpr.Concrete 300000.0
          energyCost = ValueOrExpr.Concrete 3000000.0
          buildTime = ValueOrExpr.Concrete 300000.0
          health = ValueOrExpr.Concrete 300000.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/scavboss/CORCOMBOSS.s3o"
          buildPic = Some "scavengers/CORCOMBOSS.DDS"
          script = Some "Units/CORCOMBOSS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "ScavComBossExplo"
          selfDestructAs = Some "ScavComBossExplo"
          collisionVolumeOffsets = Some "0 7 0"
          collisionVolumeScales = Some "75 160 75"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 15.0
              maxAcc = 0.18
              maxDec = 0.6
              turnRate = 500.0
              movementClass = Some "SCAVCOMMANDERBOT"
              maxSlope = Some 25.0
              maxWaterDepth = Some 200.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 140.0
              turnInPlaceSpeedLimit = Some 0.825
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 500.0
              buildDistance = Some 750.0
              buildOptions = ["armbanth"; "corkorg"]
              terraformSpeed = Some 10000.0 })
          weapons = Some [
              { name = "corcomlaserboss"
                displayName = "J8Laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 200.0
                ]
                range = Some (ValueOrExpr.Concrete 1250.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.0)
                weaponVelocity = Some 900.0
                areaOfEffect = Some 35.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 1.0
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "xplomas2"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-large-red"
                rgbColor = Some "0.7 0.3 1"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "beamtime", "0.3"
                    "corethickness", "0.22"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "firestarter", "70.0"
                    "impactonly", "1.0"
                    "laserflaresize", "5.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "12.0"
                ] }
              { name = "corcomsealaserboss"
                displayName = "J8NSLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 200.0
                ]
                range = Some (ValueOrExpr.Concrete 1250.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.0)
                weaponVelocity = Some 1500.0
                areaOfEffect = Some 25.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 1.0
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "xplomas2"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-large-blue"
                rgbColor = Some "0.7 0.3 1"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "beamtime", "0.3"
                    "corethickness", "0.22"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "firestarter", "35.0"
                    "firesubmersed", "true"
                    "impactonly", "1.0"
                    "intensity", "0.3"
                    "laserflaresize", "5.0"
                    "rgbcolor2", "0.7 0.3 0.4"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "12.0"
                    "waterweapon", "true"
                ] }
              { name = "disintegratorxl"
                displayName = "Darkmatter Photon-Disruptor"
                weaponType = Some "DGun"
                damage = Map.ofList [
                    "default", 999999.0
                ]
                range = Some (ValueOrExpr.Concrete 750.0)
                reloadTime = Some (ValueOrExpr.Concrete 5.0)
                weaponVelocity = Some 375.0
                areaOfEffect = Some 65.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 1.0
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "disigun1"
                soundHit = Some "xplomas2"
                explosiongenerator = Some "custom:burnblackbiggest"
                rgbColor = Some "0.7 0.3 1.0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "avoidground", "false"
                    "bouncerebound", "0.0"
                    "cameraShake", "500.0"
                    "cegtag", "gausscannonprojectilexl"
                    "commandfire", "true"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "0.0"
                    "firestarter", "100.0"
                    "firesubmersed", "false"
                    "gravityaffected", "true"
                    "intensity", "4.0"
                    "noexplode", "true"
                    "size", "8.5"
                    "soundhitwet", "sizzlexs"
                    "soundtrigger", "true"
                    "waterweapon", "false"
                    "weapontimer", "4.2"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 250.0)
              metalMake = Some (ValueOrExpr.Concrete 5.0)
              energyStorage = None
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "85 33 100"
                collisionVolumeType = Some "cylY"
                damage = Some 10000.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 55.0
                metal = Some 150000.0
                object_ = Some "Units/scavboss/corcomboss_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 5000.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 75000.0
                object_ = Some "Units/cor2X2C.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = Some "nanlath2"
              repair = Some "repair2"
              working = Some "reclaim1"
              underAttack = Some "warning2"
              cancelDestruct = Some "cancel2"
              capture = Some "capture2"
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["kcormov"]
              select = ["kccorsel"] })
          customParams = Map.ofList [
              "unitgroup", "buildert4"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "paralyzemultiplier", "0.01"
              "subfolder", ""
              "techlevel", "4.0"
          ]
          extras = Map.ofList [
              "autoheal", "0.0"
              "cancapture", "true"
              "canmanualfire", "true"
              "canresurrect", "true"
              "capturable", "false"
              "capturespeed", "6000.0"
              "hidedamage", "true"
              "sightemitheight", "100.0"
              "mass", "500000.0"
              "nochasecategory", "ALL"
              "radardistance", "2000.0"
              "radaremitheight", "100.0"
              "reclaimable", "false"
              "selfdestructcountdown", "5.0"
              "showplayername", "false"
              "sonardistance", "1000.0"
              "upright", "true"
          ] }

    let corcombossToFlat (def: UnitDef) : Corcomboss =
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
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          workerTime = def.builder.Value.workerTime
          buildDistance = def.builder.Value.buildDistance.Value
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyMake = def.economy.Value.energyMake.Value
          metalMake = def.economy.Value.metalMake.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corcombossToUnitDef (flat: Corcomboss) : UnitDef =
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
              turnInPlace = None
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
          weapons = Some flat.weapons
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = Some flat.metalMake
              energyStorage = None
              metalStorage = None
              extractsMetal = None
            }
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

