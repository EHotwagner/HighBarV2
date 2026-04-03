// Auto-generated BAR unit data: Scavengers/Vehicles (unified)
namespace BarData.Units

open BarData

module Scavengers_Vehicles =

    type Armdronecarryland =
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
          energyMake: ValueOrExpr<float>
          energyStorage: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armdronecarryland : Armdronecarryland =
        { name = "armdronecarryland"
          subfolder = "Scavengers/Vehicles"
          metalCost = ValueOrExpr.Concrete 1700.0
          energyCost = ValueOrExpr.Concrete 17000.0
          buildTime = ValueOrExpr.Concrete 24000.0
          health = ValueOrExpr.Concrete 3500.0
          sightDistance = ValueOrExpr.Concrete 700.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/ARMDRONECARRYLAND.s3o"
          buildPic = Some "ARMDRONECARRY.DDS"
          script = Some "Units/ARMDRONECARRYLAND.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeexplosiongeneric"
          selfDestructAs = Some "hugeexplosiongenericSelfD"
          collisionVolumeOffsets = Some "0 25 -3"
          collisionVolumeScales = Some "48 57 142"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 30.0
          maxAcc = 0.007
          maxDec = 0.022
          turnRate = 120.0
          movementClass = "HTANK7"
          maxSlope = 12.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.0
          energyMake = ValueOrExpr.Concrete 25.0
          energyStorage = 1500.0
          weapons = [
                { name = "plasma"
                  displayName = "HeavyCannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 0.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1200.0)
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
                  customParams = Map.ofList [
                      "carried_unit", "armdrone"
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
                      "metalpershot", "30.0"
                      "energypershot", "750.0"
                      "size", "0.0"
                      "soundhitwet", ""
                      "stockpile", "true"
                      "stockpiletime", "4.0"
                  ] }
            ]
          featureDefs = Map.ofList [
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
                "model_author", "Odin"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "Scavengers/vehicles"
                "techlevel", "3.0"
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
            ] }

    let armdronecarrylandDef : UnitDef =
        { name = "armdronecarryland"
          subfolder = "Scavengers/Vehicles"
          metalCost = ValueOrExpr.Concrete 1700.0
          energyCost = ValueOrExpr.Concrete 17000.0
          buildTime = ValueOrExpr.Concrete 24000.0
          health = ValueOrExpr.Concrete 3500.0
          sightDistance = ValueOrExpr.Concrete 700.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/ARMDRONECARRYLAND.s3o"
          buildPic = Some "ARMDRONECARRY.DDS"
          script = Some "Units/ARMDRONECARRYLAND.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeexplosiongeneric"
          selfDestructAs = Some "hugeexplosiongenericSelfD"
          collisionVolumeOffsets = Some "0 25 -3"
          collisionVolumeScales = Some "48 57 142"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 30.0
              maxAcc = 0.007
              maxDec = 0.022
              turnRate = 120.0
              movementClass = Some "HTANK7"
              maxSlope = Some 12.0
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.0
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "plasma"
                displayName = "HeavyCannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = Some (ValueOrExpr.Concrete 1200.0)
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
                customParams = Map.ofList [
                    "carried_unit", "armdrone"
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
                    "metalpershot", "30.0"
                    "energypershot", "750.0"
                    "size", "0.0"
                    "soundhitwet", ""
                    "stockpile", "true"
                    "stockpiletime", "4.0"
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
              "subfolder", "Scavengers/vehicles"
              "techlevel", "3.0"
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
          ] }

    let armdronecarrylandToFlat (def: UnitDef) : Armdronecarryland =
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
          energyMake = def.economy.Value.energyMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armdronecarrylandToUnitDef (flat: Armdronecarryland) : UnitDef =
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

    type Armrattet4 =
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

    let armrattet4 : Armrattet4 =
        { name = "armrattet4"
          subfolder = "Scavengers/Vehicles"
          metalCost = ValueOrExpr.Concrete 25000.0
          energyCost = ValueOrExpr.Concrete 250000.0
          buildTime = ValueOrExpr.Concrete 250000.0
          health = ValueOrExpr.Concrete 83000.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/scavboss/armrattet4.s3o"
          buildPic = Some "scavengers/armrattet4.DDS"
          script = Some "Units/scavboss/armrattet4.cob"
          corpse = Some "DEAD"
          explodeAs = Some "bantha"
          selfDestructAs = Some "banthaSelfd"
          collisionVolumeOffsets = Some "0 0 -2"
          collisionVolumeScales = Some "80 51 98"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 24.0
          maxAcc = 0.0138
          maxDec = 0.08759
          turnRate = 150.0
          movementClass = "EPICVEH"
          maxSlope = 10.0
          maxWaterDepth = 12.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 360.0
          turnInPlaceSpeedLimit = 1.0
          weapons = [
                { name = "arm_bosscannon"
                  displayName = "Huge g2g plasma cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "commanders", 400.0
                      "default", 1200.0
                      "shields", 400.0
                      "subs", 50.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1000.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.5)
                  weaponVelocity = Some 450.0
                  areaOfEffect = Some 292.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.18
                  noSelfDamage = Some true
                  soundStart = Some "shotgunbig"
                  soundHit = Some "xplonuk2xs"
                  explosiongenerator = Some "custom:genericshellexplosion-large-aoe"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTSUB"
                      "burst", "1.0"
                      "sprayAngle", "3000.0"
                      "projectiles", "5.0"
                      "avoidfeature", "false"
                      "craterareaofeffect", "292.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "0.0"
                      "firestarter", "100.0"
                      "gravityaffected", "true"
                      "leadlimit", "64.0"
                      "proximitypriority", "-1.0"
                      "size", "4.0"
                      "soundhitwet", "splslrg"
                      "targetmoveerror", "0.5"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-0.0399932861328 0.00128356933594 -0.564636230469"
                  collisionVolumeScales = Some "75.7996826172 57.2875671387 87.4318847656"
                  collisionVolumeType = Some "Box"
                  damage = Some 60000.0
                  featureDead = None
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 60.0
                  metal = Some 12500.0
                  object_ = Some "Units/scavboss/armrattet4_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
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
                ok = ["tarmmove"]
                select = ["tarmsel"] }
          customParams = Map.ofList [
                "unitgroup", "weapon"
                "basename", "base"
                "firingceg", "barrelshot-large"
                "kickback", "-0.4"
                "lumamult", "1.2"
                "model_author", "Flaka"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "other/scavengers"
                "techlevel", "3.0"
                "weapon1turretx", "45.0"
                "weapon1turrety", "80.0"
            ]
          extras = Map.ofList [
                "leavetracks", "true"
                "mass", "1000000.0"
                "nochasecategory", "VTOL"
                "trackoffset", "3.0"
                "trackstrength", "64.0"
                "tracktype", "armstump_tracks"
                "trackwidth", "104.0"
            ] }

    let armrattet4Def : UnitDef =
        { name = "armrattet4"
          subfolder = "Scavengers/Vehicles"
          metalCost = ValueOrExpr.Concrete 25000.0
          energyCost = ValueOrExpr.Concrete 250000.0
          buildTime = ValueOrExpr.Concrete 250000.0
          health = ValueOrExpr.Concrete 83000.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/scavboss/armrattet4.s3o"
          buildPic = Some "scavengers/armrattet4.DDS"
          script = Some "Units/scavboss/armrattet4.cob"
          corpse = Some "DEAD"
          explodeAs = Some "bantha"
          selfDestructAs = Some "banthaSelfd"
          collisionVolumeOffsets = Some "0 0 -2"
          collisionVolumeScales = Some "80 51 98"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 24.0
              maxAcc = 0.0138
              maxDec = 0.08759
              turnRate = 150.0
              movementClass = Some "EPICVEH"
              maxSlope = Some 10.0
              maxWaterDepth = Some 12.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 360.0
              turnInPlaceSpeedLimit = Some 1.0
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "arm_bosscannon"
                displayName = "Huge g2g plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "commanders", 400.0
                    "default", 1200.0
                    "shields", 400.0
                    "subs", 50.0
                ]
                range = Some (ValueOrExpr.Concrete 1000.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.5)
                weaponVelocity = Some 450.0
                areaOfEffect = Some 292.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.18
                noSelfDamage = Some true
                soundStart = Some "shotgunbig"
                soundHit = Some "xplonuk2xs"
                explosiongenerator = Some "custom:genericshellexplosion-large-aoe"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTSUB"
                    "burst", "1.0"
                    "sprayAngle", "3000.0"
                    "projectiles", "5.0"
                    "avoidfeature", "false"
                    "craterareaofeffect", "292.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "0.0"
                    "firestarter", "100.0"
                    "gravityaffected", "true"
                    "leadlimit", "64.0"
                    "proximitypriority", "-1.0"
                    "size", "4.0"
                    "soundhitwet", "splslrg"
                    "targetmoveerror", "0.5"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "-0.0399932861328 0.00128356933594 -0.564636230469"
                collisionVolumeScales = Some "75.7996826172 57.2875671387 87.4318847656"
                collisionVolumeType = Some "Box"
                damage = Some 60000.0
                featureDead = None
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 60.0
                metal = Some 12500.0
                object_ = Some "Units/scavboss/armrattet4_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
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
              "unitgroup", "weapon"
              "basename", "base"
              "firingceg", "barrelshot-large"
              "kickback", "-0.4"
              "lumamult", "1.2"
              "model_author", "Flaka"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "other/scavengers"
              "techlevel", "3.0"
              "weapon1turretx", "45.0"
              "weapon1turrety", "80.0"
          ]
          extras = Map.ofList [
              "leavetracks", "true"
              "mass", "1000000.0"
              "nochasecategory", "VTOL"
              "trackoffset", "3.0"
              "trackstrength", "64.0"
              "tracktype", "armstump_tracks"
              "trackwidth", "104.0"
          ] }

    let armrattet4ToFlat (def: UnitDef) : Armrattet4 =
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

    let armrattet4ToUnitDef (flat: Armrattet4) : UnitDef =
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

    type Armvadert4 =
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
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armvadert4 : Armvadert4 =
        { name = "armvadert4"
          subfolder = "Scavengers/Vehicles"
          metalCost = ValueOrExpr.Concrete 15000.0
          energyCost = ValueOrExpr.Concrete 150000.0
          buildTime = ValueOrExpr.Concrete 150000.0
          health = ValueOrExpr.Concrete 67000.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/scavboss/armvadert4.s3o"
          buildPic = Some "scavengers/armvadert4.DDS"
          script = Some "Units/scavboss/armvadert4.cob"
          corpse = None
          explodeAs = Some "crawl_blastsmlscavboss"
          selfDestructAs = Some "crawl_blastsmlscavboss"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "91 91 91"
          collisionVolumeType = Some "sphere"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 20.1
          maxAcc = 0.1518
          maxDec = 0.5589
          turnRate = 100.0
          movementClass = "EPICALLTERRAIN"
          maxSlope = 32.0
          maxWaterDepth = 112.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.848
          weapons = [
                { name = "crawl_dummy"
                  displayName = "Crawlingbomb Dummy Weapon"
                  weaponType = Some "Melee"
                  damage = Map.ofList [
                      "default", 20000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 47.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.1)
                  weaponVelocity = Some 100000.0
                  areaOfEffect = Some 0.0
                  accuracy = None
                  turret = None
                  tolerance = Some 100000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = None
                  soundStart = None
                  soundHit = None
                  explosiongenerator = Some ""
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "avoidground", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firesubmersed", "true"
                      "soundhitwet", "sizzle"
                      "waterweapon", "true"
                  ] }
                { name = "crawl_detonator"
                  displayName = "Self-destruction"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "crawlingbombs", 2000.0
                      "default", 2000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.1)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 5.0
                  accuracy = None
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = None
                  soundStart = None
                  soundHit = None
                  explosiongenerator = Some ""
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firesubmersed", "true"
                      "gravityaffected", "true"
                      "soundhitwet", "splshbig"
                  ] }
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
                ok = ["servsml5"]
                select = ["servsml5"] }
          customParams = Map.ofList [
                "unitgroup", "explo"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "other/scavengers"
                "techlevel", "3.0"
            ]
          extras = Map.ofList [
                "firestate", "0.0"
                "mass", "1500000.0"
                "nochasecategory", "VTOL"
                "selfdestructcountdown", "10.0"
                "upright", "false"
            ] }

    let armvadert4Def : UnitDef =
        { name = "armvadert4"
          subfolder = "Scavengers/Vehicles"
          metalCost = ValueOrExpr.Concrete 15000.0
          energyCost = ValueOrExpr.Concrete 150000.0
          buildTime = ValueOrExpr.Concrete 150000.0
          health = ValueOrExpr.Concrete 67000.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/scavboss/armvadert4.s3o"
          buildPic = Some "scavengers/armvadert4.DDS"
          script = Some "Units/scavboss/armvadert4.cob"
          corpse = None
          explodeAs = Some "crawl_blastsmlscavboss"
          selfDestructAs = Some "crawl_blastsmlscavboss"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "91 91 91"
          collisionVolumeType = Some "sphere"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 20.1
              maxAcc = 0.1518
              maxDec = 0.5589
              turnRate = 100.0
              movementClass = Some "EPICALLTERRAIN"
              maxSlope = Some 32.0
              maxWaterDepth = Some 112.0
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
              { name = "crawl_dummy"
                displayName = "Crawlingbomb Dummy Weapon"
                weaponType = Some "Melee"
                damage = Map.ofList [
                    "default", 20000.0
                ]
                range = Some (ValueOrExpr.Concrete 47.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.1)
                weaponVelocity = Some 100000.0
                areaOfEffect = Some 0.0
                accuracy = None
                turret = None
                tolerance = Some 100000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = None
                soundStart = None
                soundHit = None
                explosiongenerator = Some ""
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "avoidground", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firesubmersed", "true"
                    "soundhitwet", "sizzle"
                    "waterweapon", "true"
                ] }
              { name = "crawl_detonator"
                displayName = "Self-destruction"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "crawlingbombs", 2000.0
                    "default", 2000.0
                ]
                range = Some (ValueOrExpr.Concrete 1.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.1)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 5.0
                accuracy = None
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = None
                soundStart = None
                soundHit = None
                explosiongenerator = Some ""
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firesubmersed", "true"
                    "gravityaffected", "true"
                    "soundhitwet", "splshbig"
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
              ok = ["servsml5"]
              select = ["servsml5"] })
          customParams = Map.ofList [
              "unitgroup", "explo"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "other/scavengers"
              "techlevel", "3.0"
          ]
          extras = Map.ofList [
              "firestate", "0.0"
              "mass", "1500000.0"
              "nochasecategory", "VTOL"
              "selfdestructcountdown", "10.0"
              "upright", "false"
          ] }

    let armvadert4ToFlat (def: UnitDef) : Armvadert4 =
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
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armvadert4ToUnitDef (flat: Armvadert4) : UnitDef =
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
          featureDefs = None
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armzapper =
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

    let armzapper : Armzapper =
        { name = "armzapper"
          subfolder = "Scavengers/Vehicles"
          metalCost = ValueOrExpr.Concrete 80.0
          energyCost = ValueOrExpr.Concrete 1200.0
          buildTime = ValueOrExpr.Concrete 1200.0
          health = ValueOrExpr.Concrete 150.0
          sightDistance = ValueOrExpr.Concrete 260.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/armzapper.s3o"
          buildPic = Some "armzapper.DDS"
          script = Some "Units/armzapper.cob"
          corpse = Some "DEAD"
          explodeAs = Some "tinyExplosionGeneric"
          selfDestructAs = Some "tinyExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "21 15 26"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = Some "GROUNDSCOUT"
          speed = ValueOrExpr.Concrete 168.0
          maxAcc = 0.3
          maxDec = 0.5
          turnRate = 800.0
          movementClass = "TANK2"
          maxSlope = 26.0
          maxWaterDepth = 12.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 180.0
          turnInPlaceSpeedLimit = 0.0
          weapons = [
                { name = "bladewing_lyzer"
                  displayName = "Light EMP laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 800.0
                  ]
                  range = Some (ValueOrExpr.Concrete 220.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.2)
                  weaponVelocity = Some 800.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "hackshot"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-emp"
                  rgbColor = Some "0.7 0.7 1"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "90.0"
                      "mount_onlytargetcategory", "EMPABLE"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "beamdecay", "0.5"
                      "beamtime", "0.1"
                      "beamttl", "1.0"
                      "collidefriendly", "false"
                      "corethickness", "0.12"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "duration", "0.01"
                      "impactonly", "1.0"
                      "laserflaresize", "6.6"
                      "paralyzer", "true"
                      "paralyzetime", "7.0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "1.4"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.351249694824 -0.179103781738 -0.672737121582"
                  collisionVolumeScales = Some "23 13 25"
                  collisionVolumeType = Some "Box"
                  damage = Some 111.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 15.0
                  object_ = Some "Units/armfav_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 56.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 6.0
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
                ok = ["veht1buggyok"]
                select = ["veht1buggysel"] }
          customParams = Map.ofList [
                "unitgroup", "weapon"
                "basename", "base"
                "firingceg", ""
                "kickback", "0"
                "lumamult", "1.3"
                "model_author", "Flaka"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmVehicles"
                "weapon1turretx", "300.0"
                "weapon1turrety", "300.0"
            ]
          extras = Map.ofList [
                "leavetracks", "false"
                "nochasecategory", "VTOL"
                "trackoffset", "-2.0"
                "trackstrength", "5.0"
                "tracktype", "armstump_tracks"
                "trackwidth", "20.0"
            ] }

    let armzapperDef : UnitDef =
        { name = "armzapper"
          subfolder = "Scavengers/Vehicles"
          metalCost = ValueOrExpr.Concrete 80.0
          energyCost = ValueOrExpr.Concrete 1200.0
          buildTime = ValueOrExpr.Concrete 1200.0
          health = ValueOrExpr.Concrete 150.0
          sightDistance = ValueOrExpr.Concrete 260.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/armzapper.s3o"
          buildPic = Some "armzapper.DDS"
          script = Some "Units/armzapper.cob"
          corpse = Some "DEAD"
          explodeAs = Some "tinyExplosionGeneric"
          selfDestructAs = Some "tinyExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "21 15 26"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = Some "GROUNDSCOUT"
          movement = Some (
            { speed = ValueOrExpr.Concrete 168.0
              maxAcc = 0.3
              maxDec = 0.5
              turnRate = 800.0
              movementClass = Some "TANK2"
              maxSlope = Some 26.0
              maxWaterDepth = Some 12.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 180.0
              turnInPlaceSpeedLimit = Some 0.0
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "bladewing_lyzer"
                displayName = "Light EMP laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 800.0
                ]
                range = Some (ValueOrExpr.Concrete 220.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.2)
                weaponVelocity = Some 800.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "hackshot"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-emp"
                rgbColor = Some "0.7 0.7 1"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "90.0"
                    "mount_onlytargetcategory", "EMPABLE"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "beamdecay", "0.5"
                    "beamtime", "0.1"
                    "beamttl", "1.0"
                    "collidefriendly", "false"
                    "corethickness", "0.12"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "duration", "0.01"
                    "impactonly", "1.0"
                    "laserflaresize", "6.6"
                    "paralyzer", "true"
                    "paralyzetime", "7.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "1.4"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.351249694824 -0.179103781738 -0.672737121582"
                collisionVolumeScales = Some "23 13 25"
                collisionVolumeType = Some "Box"
                damage = Some 111.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 15.0
                object_ = Some "Units/armfav_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 56.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 6.0
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
              ok = ["veht1buggyok"]
              select = ["veht1buggysel"] })
          customParams = Map.ofList [
              "unitgroup", "weapon"
              "basename", "base"
              "firingceg", ""
              "kickback", "0"
              "lumamult", "1.3"
              "model_author", "Flaka"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmVehicles"
              "weapon1turretx", "300.0"
              "weapon1turrety", "300.0"
          ]
          extras = Map.ofList [
              "leavetracks", "false"
              "nochasecategory", "VTOL"
              "trackoffset", "-2.0"
              "trackstrength", "5.0"
              "tracktype", "armstump_tracks"
              "trackwidth", "20.0"
          ] }

    let armzapperToFlat (def: UnitDef) : Armzapper =
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

    let armzapperToUnitDef (flat: Armzapper) : UnitDef =
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

    type Corforge =
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
          maxWaterDepth: float
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corforge : Corforge =
        { name = "corforge"
          subfolder = "Scavengers/Vehicles"
          metalCost = ValueOrExpr.Concrete 330.0
          energyCost = ValueOrExpr.Concrete 4700.0
          buildTime = ValueOrExpr.Concrete 7200.0
          health = ValueOrExpr.Concrete 2000.0
          sightDistance = ValueOrExpr.Concrete 451.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/scavboss/CORFORGE.s3o"
          buildPic = Some "CORFORGE.DDS"
          script = Some "Units/scavboss/CORFORGE.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "36 22 38"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 49.5
          maxAcc = 0.02547
          maxDec = 0.05093
          turnRate = 363.0
          movementClass = "TANK3"
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.287
          workerTime = ValueOrExpr.Concrete 140.0
          buildDistance = 136.0
          buildOptions = ["corsolar"; "corwin"; "cormex"; "cormakr"; "coreyes"; "corvoyr"; "corspec"]
          terraformSpeed = 1250.0
          weapons = [
                { name = "flamethrower_ce"
                  displayName = "FlameThrower"
                  weaponType = Some "Flame"
                  damage = Map.ofList [
                      "default", 5.25
                  ]
                  range = Some (ValueOrExpr.Concrete 410.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.1)
                  weaponVelocity = Some 600.0
                  areaOfEffect = Some 128.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 2500.0
                  edgeEffectiveness = Some 0.6
                  impulseFactor = None
                  noSelfDamage = Some true
                  soundStart = Some "flamhvy1"
                  soundHit = None
                  explosiongenerator = Some "custom:burnblack"
                  rgbColor = Some "1 0.94 0.88"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "burst", "33.0"
                      "burstrate", "0.034"
                      "collisionSize", "0.05"
                      "cegtag", "burnflame-anim"
                      "colormap", "1 0.95 0.9 0.032   0.55 0.55 0.40 0.028   0.40 0.28 0.19 0.024   0.033 0.018 0.011 0.04   0.0 0.0 0.0 0.01"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "100.0"
                      "flamegfxtime", "1.0"
                      "intensity", "0.6"
                      "rgbcolor2", "0.9 0.84 0.8"
                      "sizegrowth", "0.8"
                      "soundhitdry", "flamhit1"
                      "soundhitwet", "sizzle"
                      "soundhitvolume", "7.5"
                      "soundstartvolume", "5.3"
                      "soundtrigger", "false"
                      "sprayangle", "9600.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-2.2791595459 -0.365720275879 -0.110244750977"
                  collisionVolumeScales = Some "41.4731445313 24.6765594482 38.8007202148"
                  collisionVolumeType = Some "Box"
                  damage = Some 450.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 138.0
                  object_ = Some "Units/scavboss/CORFORGE_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 350.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 55.0
                  object_ = Some "Units/cor2X2B.s3o"
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
                ok = ["tcormove"]
                select = ["tcorsel"] }
          customParams = Map.ofList [
                "unitgroup", "buildert2"
                "model_author", "MASHUP"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorVehicles/T2"
                "paralyzemultiplier", "0.04"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "leavetracks", "true"
                "nochasecategory", "NOTLAND VTOL"
                "trackoffset", "8.0"
                "trackstrength", "8.0"
                "tracktype", "corwidetracks"
                "trackwidth", "31.0"
            ] }

    let corforgeDef : UnitDef =
        { name = "corforge"
          subfolder = "Scavengers/Vehicles"
          metalCost = ValueOrExpr.Concrete 330.0
          energyCost = ValueOrExpr.Concrete 4700.0
          buildTime = ValueOrExpr.Concrete 7200.0
          health = ValueOrExpr.Concrete 2000.0
          sightDistance = ValueOrExpr.Concrete 451.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/scavboss/CORFORGE.s3o"
          buildPic = Some "CORFORGE.DDS"
          script = Some "Units/scavboss/CORFORGE.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "36 22 38"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 49.5
              maxAcc = 0.02547
              maxDec = 0.05093
              turnRate = 363.0
              movementClass = Some "TANK3"
              maxSlope = None
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.287
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 140.0
              buildDistance = Some 136.0
              buildOptions = ["corsolar"; "corwin"; "cormex"; "cormakr"; "coreyes"; "corvoyr"; "corspec"]
              terraformSpeed = Some 1250.0 })
          weapons = Some [
              { name = "flamethrower_ce"
                displayName = "FlameThrower"
                weaponType = Some "Flame"
                damage = Map.ofList [
                    "default", 5.25
                ]
                range = Some (ValueOrExpr.Concrete 410.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.1)
                weaponVelocity = Some 600.0
                areaOfEffect = Some 128.0
                accuracy = None
                turret = Some true
                tolerance = Some 2500.0
                edgeEffectiveness = Some 0.6
                impulseFactor = None
                noSelfDamage = Some true
                soundStart = Some "flamhvy1"
                soundHit = None
                explosiongenerator = Some "custom:burnblack"
                rgbColor = Some "1 0.94 0.88"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "burst", "33.0"
                    "burstrate", "0.034"
                    "collisionSize", "0.05"
                    "cegtag", "burnflame-anim"
                    "colormap", "1 0.95 0.9 0.032   0.55 0.55 0.40 0.028   0.40 0.28 0.19 0.024   0.033 0.018 0.011 0.04   0.0 0.0 0.0 0.01"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "100.0"
                    "flamegfxtime", "1.0"
                    "intensity", "0.6"
                    "rgbcolor2", "0.9 0.84 0.8"
                    "sizegrowth", "0.8"
                    "soundhitdry", "flamhit1"
                    "soundhitwet", "sizzle"
                    "soundhitvolume", "7.5"
                    "soundstartvolume", "5.3"
                    "soundtrigger", "false"
                    "sprayangle", "9600.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "-2.2791595459 -0.365720275879 -0.110244750977"
                collisionVolumeScales = Some "41.4731445313 24.6765594482 38.8007202148"
                collisionVolumeType = Some "Box"
                damage = Some 450.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 138.0
                object_ = Some "Units/scavboss/CORFORGE_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 350.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 55.0
                object_ = Some "Units/cor2X2B.s3o"
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
              ok = ["tcormove"]
              select = ["tcorsel"] })
          customParams = Map.ofList [
              "unitgroup", "buildert2"
              "model_author", "MASHUP"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorVehicles/T2"
              "paralyzemultiplier", "0.04"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "leavetracks", "true"
              "nochasecategory", "NOTLAND VTOL"
              "trackoffset", "8.0"
              "trackstrength", "8.0"
              "tracktype", "corwidetracks"
              "trackwidth", "31.0"
          ] }

    let corforgeToFlat (def: UnitDef) : Corforge =
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
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          workerTime = def.builder.Value.workerTime
          buildDistance = def.builder.Value.buildDistance.Value
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corforgeToUnitDef (flat: Corforge) : UnitDef =
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
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corftiger =
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

    let corftiger : Corftiger =
        { name = "corftiger"
          subfolder = "Scavengers/Vehicles"
          metalCost = ValueOrExpr.Concrete 665.0
          energyCost = ValueOrExpr.Concrete 10000.0
          buildTime = ValueOrExpr.Concrete 11500.0
          health = ValueOrExpr.Concrete 5300.0
          sightDistance = ValueOrExpr.Concrete 462.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/scavboss/CORFTIGER.s3o"
          buildPic = Some "CORFTIGER.DDS"
          script = Some "Units/scavboss/CORFTIGER.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -6 0"
          collisionVolumeScales = Some "34 34 38"
          collisionVolumeType = Some "BOX"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 70.5
          maxAcc = 0.0362
          maxDec = 0.0724
          turnRate = 347.0
          movementClass = "MTANK3"
          maxSlope = 12.0
          maxWaterDepth = 100.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.72656
          weapons = [
                { name = "cor_tiger_laser"
                  displayName = "HeatRay"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 14.5
                      "vtol", 4.7
                  ]
                  range = Some (ValueOrExpr.Concrete 410.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.7)
                  weaponVelocity = None
                  areaOfEffect = Some 42.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "heatray1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-medium-yellow"
                  rgbColor = Some "1 0.8 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "beamburst", "true"
                      "burst", "10.0"
                      "burstrate", "0.03"
                      "beamTTL", "6.0"
                      "beamdecay", "0.7"
                      "corethickness", "0.2"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "90.0"
                      "rgbcolor2", "0.8 0 0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "true"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-0.042236328125 -0.00674871826172 -0.122863769531"
                  collisionVolumeScales = Some "37.7348022461 25.9745025635 40.3383178711"
                  collisionVolumeType = Some "Box"
                  damage = Some 3000.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 350.0
                  object_ = Some "Units/scavboss/corftiger_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 2500.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 150.0
                  object_ = Some "Units/cor3X3C.s3o"
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
                ok = ["tcormove"]
                select = ["tcorsel"] }
          customParams = Map.ofList [
                "unitgroup", "weapon"
                "basename", "base"
                "firingceg", "barrelshot-medium"
                "kickback", "-2.4"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorVehicles/T2"
                "techlevel", "2.0"
                "weapon1turretx", "65.0"
                "weapon1turrety", "105.0"
            ]
          extras = Map.ofList [
                "leavetracks", "true"
                "nochasecategory", "VTOL"
                "trackoffset", "8.0"
                "trackstrength", "8.0"
                "tracktype", "corwidetracks"
                "trackwidth", "33.0"
            ] }

    let corftigerDef : UnitDef =
        { name = "corftiger"
          subfolder = "Scavengers/Vehicles"
          metalCost = ValueOrExpr.Concrete 665.0
          energyCost = ValueOrExpr.Concrete 10000.0
          buildTime = ValueOrExpr.Concrete 11500.0
          health = ValueOrExpr.Concrete 5300.0
          sightDistance = ValueOrExpr.Concrete 462.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/scavboss/CORFTIGER.s3o"
          buildPic = Some "CORFTIGER.DDS"
          script = Some "Units/scavboss/CORFTIGER.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -6 0"
          collisionVolumeScales = Some "34 34 38"
          collisionVolumeType = Some "BOX"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 70.5
              maxAcc = 0.0362
              maxDec = 0.0724
              turnRate = 347.0
              movementClass = Some "MTANK3"
              maxSlope = Some 12.0
              maxWaterDepth = Some 100.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.72656
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "cor_tiger_laser"
                displayName = "HeatRay"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 14.5
                    "vtol", 4.7
                ]
                range = Some (ValueOrExpr.Concrete 410.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.7)
                weaponVelocity = None
                areaOfEffect = Some 42.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "heatray1"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-medium-yellow"
                rgbColor = Some "1 0.8 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "beamburst", "true"
                    "burst", "10.0"
                    "burstrate", "0.03"
                    "beamTTL", "6.0"
                    "beamdecay", "0.7"
                    "corethickness", "0.2"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "90.0"
                    "rgbcolor2", "0.8 0 0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "true"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "-0.042236328125 -0.00674871826172 -0.122863769531"
                collisionVolumeScales = Some "37.7348022461 25.9745025635 40.3383178711"
                collisionVolumeType = Some "Box"
                damage = Some 3000.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 350.0
                object_ = Some "Units/scavboss/corftiger_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 2500.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 150.0
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
              ok = ["tcormove"]
              select = ["tcorsel"] })
          customParams = Map.ofList [
              "unitgroup", "weapon"
              "basename", "base"
              "firingceg", "barrelshot-medium"
              "kickback", "-2.4"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorVehicles/T2"
              "techlevel", "2.0"
              "weapon1turretx", "65.0"
              "weapon1turrety", "105.0"
          ]
          extras = Map.ofList [
              "leavetracks", "true"
              "nochasecategory", "VTOL"
              "trackoffset", "8.0"
              "trackstrength", "8.0"
              "tracktype", "corwidetracks"
              "trackwidth", "33.0"
          ] }

    let corftigerToFlat (def: UnitDef) : Corftiger =
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

    let corftigerToUnitDef (flat: Corftiger) : UnitDef =
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

    type Corgatreap =
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

    let corgatreap : Corgatreap =
        { name = "corgatreap"
          subfolder = "Scavengers/Vehicles"
          metalCost = ValueOrExpr.Concrete 1400.0
          energyCost = ValueOrExpr.Concrete 17000.0
          buildTime = ValueOrExpr.Concrete 14500.0
          health = ValueOrExpr.Concrete 5000.0
          sightDistance = ValueOrExpr.Concrete 462.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/scavboss/CORGATREAP.s3o"
          buildPic = Some "CORGATREAP.DDS"
          script = Some "Units/scavboss/CORGATREAP.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -6 0"
          collisionVolumeScales = Some "34 34 38"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 69.0
          maxAcc = 0.0362
          maxDec = 0.0724
          turnRate = 325.0
          movementClass = "MTANK3"
          maxSlope = 12.0
          maxWaterDepth = 100.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.72656
          weapons = [
                { name = "cor_laserh1"
                  displayName = "High energy g2g laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 261.0
                      "vtol", 35.0
                  ]
                  range = Some (ValueOrExpr.Concrete 620.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.8)
                  weaponVelocity = Some 2250.0
                  areaOfEffect = Some 14.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "Lasrmas2"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-medium-green"
                  rgbColor = Some "0 1 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "beamtime", "0.15"
                      "corethickness", "0.2"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "75.0"
                      "firestarter", "90.0"
                      "impactonly", "1.0"
                      "laserflaresize", "8.8"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "2.7"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-0.042236328125 -0.00674871826172 -0.122863769531"
                  collisionVolumeScales = Some "37.7348022461 25.9745025635 40.3383178711"
                  collisionVolumeType = Some "Box"
                  damage = Some 3000.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 600.0
                  object_ = Some "Units/scavboss/corgatreap_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 2500.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 300.0
                  object_ = Some "Units/cor3X3C.s3o"
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
                ok = ["tcormove"]
                select = ["tcorsel"] }
          customParams = Map.ofList [
                "unitgroup", "weapon"
                "basename", "base"
                "firingceg", "barrelshot-medium"
                "kickback", "-2.4"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorVehicles/T2"
                "techlevel", "2.0"
                "weapon1turretx", "65.0"
                "weapon1turrety", "105.0"
            ]
          extras = Map.ofList [
                "leavetracks", "true"
                "mass", "5000.0"
                "nochasecategory", "VTOL"
                "trackoffset", "8.0"
                "trackstrength", "8.0"
                "tracktype", "corwidetracks"
                "trackwidth", "33.0"
            ] }

    let corgatreapDef : UnitDef =
        { name = "corgatreap"
          subfolder = "Scavengers/Vehicles"
          metalCost = ValueOrExpr.Concrete 1400.0
          energyCost = ValueOrExpr.Concrete 17000.0
          buildTime = ValueOrExpr.Concrete 14500.0
          health = ValueOrExpr.Concrete 5000.0
          sightDistance = ValueOrExpr.Concrete 462.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/scavboss/CORGATREAP.s3o"
          buildPic = Some "CORGATREAP.DDS"
          script = Some "Units/scavboss/CORGATREAP.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -6 0"
          collisionVolumeScales = Some "34 34 38"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 69.0
              maxAcc = 0.0362
              maxDec = 0.0724
              turnRate = 325.0
              movementClass = Some "MTANK3"
              maxSlope = Some 12.0
              maxWaterDepth = Some 100.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.72656
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "cor_laserh1"
                displayName = "High energy g2g laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 261.0
                    "vtol", 35.0
                ]
                range = Some (ValueOrExpr.Concrete 620.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.8)
                weaponVelocity = Some 2250.0
                areaOfEffect = Some 14.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "Lasrmas2"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-medium-green"
                rgbColor = Some "0 1 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "beamtime", "0.15"
                    "corethickness", "0.2"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "75.0"
                    "firestarter", "90.0"
                    "impactonly", "1.0"
                    "laserflaresize", "8.8"
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
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "-0.042236328125 -0.00674871826172 -0.122863769531"
                collisionVolumeScales = Some "37.7348022461 25.9745025635 40.3383178711"
                collisionVolumeType = Some "Box"
                damage = Some 3000.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 600.0
                object_ = Some "Units/scavboss/corgatreap_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 2500.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 300.0
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
              ok = ["tcormove"]
              select = ["tcorsel"] })
          customParams = Map.ofList [
              "unitgroup", "weapon"
              "basename", "base"
              "firingceg", "barrelshot-medium"
              "kickback", "-2.4"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorVehicles/T2"
              "techlevel", "2.0"
              "weapon1turretx", "65.0"
              "weapon1turrety", "105.0"
          ]
          extras = Map.ofList [
              "leavetracks", "true"
              "mass", "5000.0"
              "nochasecategory", "VTOL"
              "trackoffset", "8.0"
              "trackstrength", "8.0"
              "tracktype", "corwidetracks"
              "trackwidth", "33.0"
          ] }

    let corgatreapToFlat (def: UnitDef) : Corgatreap =
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

    let corgatreapToUnitDef (flat: Corgatreap) : UnitDef =
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

    type Corgolt4 =
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

    let corgolt4 : Corgolt4 =
        { name = "corgolt4"
          subfolder = "Scavengers/Vehicles"
          metalCost = ValueOrExpr.Concrete 25000.0
          energyCost = ValueOrExpr.Concrete 250000.0
          buildTime = ValueOrExpr.Concrete 250000.0
          health = ValueOrExpr.Concrete 83000.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/scavboss/corgolt4.s3o"
          buildPic = Some "CORGOLT4.DDS"
          script = Some "Units/scavboss/corgolt4.cob"
          corpse = Some "DEAD"
          explodeAs = Some "bantha"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "61 48 67"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 24.0
          maxAcc = 0.0138
          maxDec = 0.08759
          turnRate = 150.0
          movementClass = "EPICVEH"
          maxSlope = 10.0
          maxWaterDepth = 12.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 360.0
          turnInPlaceSpeedLimit = 1.0
          weapons = [
                { name = "corlevlr_weapon"
                  displayName = "Huge g2g plasma cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "commanders", 1500.0
                      "default", 8000.0
                      "shields", 1500.0
                      "subs", 500.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1000.0)
                  reloadTime = Some (ValueOrExpr.Concrete 4.5)
                  weaponVelocity = Some 450.0
                  areaOfEffect = Some 350.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.4
                  impulseFactor = Some 1.8
                  noSelfDamage = Some true
                  soundStart = Some "krogun1"
                  soundHit = Some "xplonuk2"
                  explosiongenerator = Some "custom:newnuketac"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_weaponAimAdjustPriority", "9.0"
                      "avoidfeature", "false"
                      "craterareaofeffect", "350.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "1500.0"
                      "firestarter", "100.0"
                      "gravityaffected", "true"
                      "leadlimit", "64.0"
                      "proximitypriority", "-1.0"
                      "predictBoost", "0.8"
                      "size", "9.0"
                      "soundhitwet", "splslrg"
                      "targetmoveerror", "0.5"
                  ] }
                { name = "corgol_sidelaser"
                  displayName = "HighEnergyLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 750.0
                      "vtol", 125.0
                  ]
                  range = Some (ValueOrExpr.Concrete 475.0)
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
                  rgbColor = Some "0.027 0.40 0.027"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_maindir", "-1 0 0"
                      "mount_maxangledif", "180.0"
                      "avoidfeature", "false"
                      "beamtime", "0.16"
                      "beamttl", "2.4"
                      "corethickness", "0.21"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "75.0"
                      "firestarter", "90.0"
                      "impactonly", "1.0"
                      "laserflaresize", "5.5"
                      "proximitypriority", "1.0"
                      "rgbcolor2", "0.9 1 0.9"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "4.0"
                  ] }
                { name = "corgol_sidelaser"
                  displayName = "HighEnergyLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 750.0
                      "vtol", 125.0
                  ]
                  range = Some (ValueOrExpr.Concrete 475.0)
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
                  rgbColor = Some "0.027 0.40 0.027"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_maindir", "1 0 0"
                      "mount_maxangledif", "180.0"
                      "avoidfeature", "false"
                      "beamtime", "0.16"
                      "beamttl", "2.4"
                      "corethickness", "0.21"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "75.0"
                      "firestarter", "90.0"
                      "impactonly", "1.0"
                      "laserflaresize", "5.5"
                      "proximitypriority", "1.0"
                      "rgbcolor2", "0.9 1 0.9"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "4.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -10 3"
                  collisionVolumeScales = Some "70 63 70"
                  collisionVolumeType = Some "Box"
                  damage = Some 100000.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 20.0
                  metal = Some 12500.0
                  object_ = Some "Units/scavboss/corgolt4_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 10000.0
                  featureDead = None
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 4.0
                  metal = Some 2750.0
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
                ok = ["tcormove"]
                select = ["tcorsel"] }
          customParams = Map.ofList [
                "unitgroup", "weapon"
                "basename", "base"
                "firingceg", "barrelshot-tiny"
                "kickback", "-4"
                "model_author", "Mr Bob, Hornet"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorVehicles"
                "techlevel", "3.0"
                "weapon1turretx", "20.0"
                "weapon1turrety", "170.0"
            ]
          extras = Map.ofList [
                "leavetracks", "true"
                "mass", "1000000.0"
                "nochasecategory", "VTOL"
                "trackoffset", "3.0"
                "trackstrength", "64.0"
                "tracktype", "armstump_tracks"
                "trackwidth", "104.0"
            ] }

    let corgolt4Def : UnitDef =
        { name = "corgolt4"
          subfolder = "Scavengers/Vehicles"
          metalCost = ValueOrExpr.Concrete 25000.0
          energyCost = ValueOrExpr.Concrete 250000.0
          buildTime = ValueOrExpr.Concrete 250000.0
          health = ValueOrExpr.Concrete 83000.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/scavboss/corgolt4.s3o"
          buildPic = Some "CORGOLT4.DDS"
          script = Some "Units/scavboss/corgolt4.cob"
          corpse = Some "DEAD"
          explodeAs = Some "bantha"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "61 48 67"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 24.0
              maxAcc = 0.0138
              maxDec = 0.08759
              turnRate = 150.0
              movementClass = Some "EPICVEH"
              maxSlope = Some 10.0
              maxWaterDepth = Some 12.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 360.0
              turnInPlaceSpeedLimit = Some 1.0
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "corlevlr_weapon"
                displayName = "Huge g2g plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "commanders", 1500.0
                    "default", 8000.0
                    "shields", 1500.0
                    "subs", 500.0
                ]
                range = Some (ValueOrExpr.Concrete 1000.0)
                reloadTime = Some (ValueOrExpr.Concrete 4.5)
                weaponVelocity = Some 450.0
                areaOfEffect = Some 350.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.4
                impulseFactor = Some 1.8
                noSelfDamage = Some true
                soundStart = Some "krogun1"
                soundHit = Some "xplonuk2"
                explosiongenerator = Some "custom:newnuketac"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_weaponAimAdjustPriority", "9.0"
                    "avoidfeature", "false"
                    "craterareaofeffect", "350.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "1500.0"
                    "firestarter", "100.0"
                    "gravityaffected", "true"
                    "leadlimit", "64.0"
                    "proximitypriority", "-1.0"
                    "predictBoost", "0.8"
                    "size", "9.0"
                    "soundhitwet", "splslrg"
                    "targetmoveerror", "0.5"
                ] }
              { name = "corgol_sidelaser"
                displayName = "HighEnergyLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 750.0
                    "vtol", 125.0
                ]
                range = Some (ValueOrExpr.Concrete 475.0)
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
                rgbColor = Some "0.027 0.40 0.027"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_maindir", "-1 0 0"
                    "mount_maxangledif", "180.0"
                    "avoidfeature", "false"
                    "beamtime", "0.16"
                    "beamttl", "2.4"
                    "corethickness", "0.21"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "75.0"
                    "firestarter", "90.0"
                    "impactonly", "1.0"
                    "laserflaresize", "5.5"
                    "proximitypriority", "1.0"
                    "rgbcolor2", "0.9 1 0.9"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "4.0"
                ] }
              { name = "corgol_sidelaser"
                displayName = "HighEnergyLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 750.0
                    "vtol", 125.0
                ]
                range = Some (ValueOrExpr.Concrete 475.0)
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
                rgbColor = Some "0.027 0.40 0.027"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_maindir", "1 0 0"
                    "mount_maxangledif", "180.0"
                    "avoidfeature", "false"
                    "beamtime", "0.16"
                    "beamttl", "2.4"
                    "corethickness", "0.21"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "75.0"
                    "firestarter", "90.0"
                    "impactonly", "1.0"
                    "laserflaresize", "5.5"
                    "proximitypriority", "1.0"
                    "rgbcolor2", "0.9 1 0.9"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "4.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -10 3"
                collisionVolumeScales = Some "70 63 70"
                collisionVolumeType = Some "Box"
                damage = Some 100000.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 20.0
                metal = Some 12500.0
                object_ = Some "Units/scavboss/corgolt4_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 10000.0
                featureDead = None
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 4.0
                metal = Some 2750.0
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
              ok = ["tcormove"]
              select = ["tcorsel"] })
          customParams = Map.ofList [
              "unitgroup", "weapon"
              "basename", "base"
              "firingceg", "barrelshot-tiny"
              "kickback", "-4"
              "model_author", "Mr Bob, Hornet"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorVehicles"
              "techlevel", "3.0"
              "weapon1turretx", "20.0"
              "weapon1turrety", "170.0"
          ]
          extras = Map.ofList [
              "leavetracks", "true"
              "mass", "1000000.0"
              "nochasecategory", "VTOL"
              "trackoffset", "3.0"
              "trackstrength", "64.0"
              "tracktype", "armstump_tracks"
              "trackwidth", "104.0"
          ] }

    let corgolt4ToFlat (def: UnitDef) : Corgolt4 =
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

    let corgolt4ToUnitDef (flat: Corgolt4) : UnitDef =
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

    type Cortorch =
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
          turnInPlaceSpeedLimit: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let cortorch : Cortorch =
        { name = "cortorch"
          subfolder = "Scavengers/Vehicles"
          metalCost = ValueOrExpr.Concrete 220.0
          energyCost = ValueOrExpr.Concrete 4400.0
          buildTime = ValueOrExpr.Concrete 4150.0
          health = ValueOrExpr.Concrete 650.0
          sightDistance = ValueOrExpr.Concrete 308.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/scavboss/CORTORCH.s3o"
          buildPic = Some "CORTORCH.DDS"
          script = Some "Units/scavboss/CORTORCH.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallexplosiongeneric"
          selfDestructAs = Some "pyroselfd"
          collisionVolumeOffsets = Some "0 -3 0"
          collisionVolumeScales = Some "30 21 36"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 141.0
          maxAcc = 0.005
          maxDec = 0.12
          turnRate = 364.0
          movementClass = "TANK2"
          maxSlope = 12.0
          maxWaterDepth = 200.0
          canMove = true
          turnInPlace = false
          turnInPlaceSpeedLimit = 4.7
          weapons = [
                { name = "flame_thrower"
                  displayName = "Flamethrower"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "default", 85.0
                  ]
                  range = Some (ValueOrExpr.Concrete 280.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.733)
                  weaponVelocity = Some 450.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "flamhvy1"
                  soundHit = None
                  explosiongenerator = Some "custom:blank"
                  rgbColor = Some "1 0.94 0.88"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "cameraShake", "0.0"
                      "cegtag", "burnflame-anim-x2"
                      "colormap", "1 0.95 0.9 0.032   0.55 0.55 0.40 0.028   0.40 0.28 0.19 0.024   0.033 0.018 0.011 0.04   0.0 0.0 0.0 0.01"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "70.0"
                      "intensity", "1.0"
                      "metalpershot", "0.0"
                      "rgbcolor2", "0.9 0.84 0.8"
                      "smokeTrailCastShadow", "false"
                      "castshadow", "true"
                      "soundhitdry", "flamhit1"
                      "soundhitwet", "sizzle"
                      "soundhitvolume", "7.5"
                      "soundstartvolume", "5.3"
                      "startvelocity", "450.0"
                      "texture1", "null"
                      "texture2", "smoketraildark"
                      "trajectoryheight", "0.26"
                      "turnrate", "10000.0"
                      "tracks", "true"
                      "flightTime", "2.7"
                      "burnblow", "true"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -3 0"
                  collisionVolumeScales = Some "30 21 36"
                  collisionVolumeType = Some "Box"
                  damage = Some 731.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 9.0
                  metal = Some 134.0
                  object_ = Some "Units/scavboss/cortorch_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 488.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 67.0
                  object_ = Some "Units/cor2X2E.s3o"
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
                ok = ["tcormove"]
                select = ["tcorsel"] }
          customParams = Map.ofList [
                "unitgroup", "weapon"
                "model_author", "Flaka, Itanthias kitbash"
                "normaltex", "unittextures/cor_normal.dds"
                "paralyzemultiplier", "0.013"
                "subfolder", "CorVehicles"
            ]
          extras = Map.ofList [
                "leavetracks", "true"
                "nochasecategory", "VTOL"
                "selfdestructcountdown", "1.0"
                "trackoffset", "0.0"
                "trackstrength", "6.0"
                "tracktype", "corparrowtracks"
                "trackwidth", "22.0"
            ] }

    let cortorchDef : UnitDef =
        { name = "cortorch"
          subfolder = "Scavengers/Vehicles"
          metalCost = ValueOrExpr.Concrete 220.0
          energyCost = ValueOrExpr.Concrete 4400.0
          buildTime = ValueOrExpr.Concrete 4150.0
          health = ValueOrExpr.Concrete 650.0
          sightDistance = ValueOrExpr.Concrete 308.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/scavboss/CORTORCH.s3o"
          buildPic = Some "CORTORCH.DDS"
          script = Some "Units/scavboss/CORTORCH.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallexplosiongeneric"
          selfDestructAs = Some "pyroselfd"
          collisionVolumeOffsets = Some "0 -3 0"
          collisionVolumeScales = Some "30 21 36"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 141.0
              maxAcc = 0.005
              maxDec = 0.12
              turnRate = 364.0
              movementClass = Some "TANK2"
              maxSlope = Some 12.0
              maxWaterDepth = Some 200.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some false
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = Some 4.7
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "flame_thrower"
                displayName = "Flamethrower"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 85.0
                ]
                range = Some (ValueOrExpr.Concrete 280.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.733)
                weaponVelocity = Some 450.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "flamhvy1"
                soundHit = None
                explosiongenerator = Some "custom:blank"
                rgbColor = Some "1 0.94 0.88"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "cameraShake", "0.0"
                    "cegtag", "burnflame-anim-x2"
                    "colormap", "1 0.95 0.9 0.032   0.55 0.55 0.40 0.028   0.40 0.28 0.19 0.024   0.033 0.018 0.011 0.04   0.0 0.0 0.0 0.01"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "70.0"
                    "intensity", "1.0"
                    "metalpershot", "0.0"
                    "rgbcolor2", "0.9 0.84 0.8"
                    "smokeTrailCastShadow", "false"
                    "castshadow", "true"
                    "soundhitdry", "flamhit1"
                    "soundhitwet", "sizzle"
                    "soundhitvolume", "7.5"
                    "soundstartvolume", "5.3"
                    "startvelocity", "450.0"
                    "texture1", "null"
                    "texture2", "smoketraildark"
                    "trajectoryheight", "0.26"
                    "turnrate", "10000.0"
                    "tracks", "true"
                    "flightTime", "2.7"
                    "burnblow", "true"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -3 0"
                collisionVolumeScales = Some "30 21 36"
                collisionVolumeType = Some "Box"
                damage = Some 731.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 9.0
                metal = Some 134.0
                object_ = Some "Units/scavboss/cortorch_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 488.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 67.0
                object_ = Some "Units/cor2X2E.s3o"
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
              ok = ["tcormove"]
              select = ["tcorsel"] })
          customParams = Map.ofList [
              "unitgroup", "weapon"
              "model_author", "Flaka, Itanthias kitbash"
              "normaltex", "unittextures/cor_normal.dds"
              "paralyzemultiplier", "0.013"
              "subfolder", "CorVehicles"
          ]
          extras = Map.ofList [
              "leavetracks", "true"
              "nochasecategory", "VTOL"
              "selfdestructcountdown", "1.0"
              "trackoffset", "0.0"
              "trackstrength", "6.0"
              "tracktype", "corparrowtracks"
              "trackwidth", "22.0"
          ] }

    let cortorchToFlat (def: UnitDef) : Cortorch =
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
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let cortorchToUnitDef (flat: Cortorch) : UnitDef =
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
              turnInPlaceAngleLimit = None
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

