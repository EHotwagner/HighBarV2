// Auto-generated BAR unit data: Scavengers/Bots (unified)
namespace BarData.Units

open BarData

module Scavengers_Bots =

    type Armassimilator =
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

    let armassimilator : Armassimilator =
        { name = "armassimilator"
          subfolder = "Scavengers/Bots"
          metalCost = ValueOrExpr.Concrete 2500.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 25000.0
          health = ValueOrExpr.Concrete 7500.0
          sightDistance = ValueOrExpr.Concrete 800.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/scavboss/armassimilator.s3o"
          buildPic = Some "ARMASSIMILATOR.DDS"
          script = Some "Units/scavboss/armassimilator.cob"
          corpse = Some "DEAD"
          explodeAs = Some "explosiont3"
          selfDestructAs = Some "explosiont3xl"
          collisionVolumeOffsets = Some "0.0 -2.0 -5"
          collisionVolumeScales = Some "50.0 60.0 50.0"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 60.0
          maxAcc = 0.2369
          maxDec = 0.9039
          turnRate = 768.20001
          movementClass = "EPICBOT"
          maxSlope = 15.0
          maxWaterDepth = 22.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.518
          weapons = [
                { name = "machinegun"
                  displayName = "scav rapid fire plasma gun"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "default", 33.0
                      "vtol", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 800.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.1)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 25.0
                  accuracy = Some 50.0
                  turret = Some true
                  tolerance = Some 1000.0
                  edgeEffectiveness = None
                  impulseFactor = None
                  noSelfDamage = None
                  soundStart = Some "tgunshipfire"
                  soundHit = None
                  explosiongenerator = Some "custom:genericshellexplosion-tiny-aa"
                  rgbColor = Some "1 0 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfriendly", "false"
                      "avoidfeature", "false"
                      "collidefriendly", "false"
                      "collidefeature", "true"
                      "beamtime", "0.09"
                      "corethickness", "0.45"
                      "duration", "0.09"
                      "energypershot", "0.0"
                      "falloffrate", "0.0"
                      "firestarter", "50.0"
                      "interceptedbyshieldtype", "4.0"
                      "minintensity", "1"
                      "rgbcolor2", "1 1 1"
                      "soundtrigger", "true"
                      "texture1", "shot"
                      "texture2", "empty"
                      "thickness", "7.5"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-1.43661499023 -1.36986116943 12.126411438"
                  collisionVolumeScales = Some "61.6002807617 54.8114776611 71.5794219971"
                  collisionVolumeType = Some "Box"
                  damage = Some 1500.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 2325.0
                  object_ = Some "Units/scavboss/armassimilator_dead.s3o"
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
                  metal = Some 930.0
                  object_ = Some "Units/arm3X3B.s3o"
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
                ok = ["mavbok1"]
                select = ["mavbsel1"] }
          customParams = Map.ofList [
                "unitgroup", "weapon"
                "model_author", "PtaQ"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmGantry"
                "techlevel", "3.0"
                "weapon1turretx", "200.0"
                "weapon1turrety", "200.0"
            ]
          extras = Map.ofList [
                "mass", "200000.0"
                "strafetoattack", "true"
                "upright", "true"
            ] }

    let armassimilatorDef : UnitDef =
        { name = "armassimilator"
          subfolder = "Scavengers/Bots"
          metalCost = ValueOrExpr.Concrete 2500.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 25000.0
          health = ValueOrExpr.Concrete 7500.0
          sightDistance = ValueOrExpr.Concrete 800.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/scavboss/armassimilator.s3o"
          buildPic = Some "ARMASSIMILATOR.DDS"
          script = Some "Units/scavboss/armassimilator.cob"
          corpse = Some "DEAD"
          explodeAs = Some "explosiont3"
          selfDestructAs = Some "explosiont3xl"
          collisionVolumeOffsets = Some "0.0 -2.0 -5"
          collisionVolumeScales = Some "50.0 60.0 50.0"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 60.0
              maxAcc = 0.2369
              maxDec = 0.9039
              turnRate = 768.20001
              movementClass = Some "EPICBOT"
              maxSlope = Some 15.0
              maxWaterDepth = Some 22.0
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
              { name = "machinegun"
                displayName = "scav rapid fire plasma gun"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 33.0
                    "vtol", 100.0
                ]
                range = Some (ValueOrExpr.Concrete 800.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.1)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 25.0
                accuracy = Some 50.0
                turret = Some true
                tolerance = Some 1000.0
                edgeEffectiveness = None
                impulseFactor = None
                noSelfDamage = None
                soundStart = Some "tgunshipfire"
                soundHit = None
                explosiongenerator = Some "custom:genericshellexplosion-tiny-aa"
                rgbColor = Some "1 0 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfriendly", "false"
                    "avoidfeature", "false"
                    "collidefriendly", "false"
                    "collidefeature", "true"
                    "beamtime", "0.09"
                    "corethickness", "0.45"
                    "duration", "0.09"
                    "energypershot", "0.0"
                    "falloffrate", "0.0"
                    "firestarter", "50.0"
                    "interceptedbyshieldtype", "4.0"
                    "minintensity", "1"
                    "rgbcolor2", "1 1 1"
                    "soundtrigger", "true"
                    "texture1", "shot"
                    "texture2", "empty"
                    "thickness", "7.5"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "-1.43661499023 -1.36986116943 12.126411438"
                collisionVolumeScales = Some "61.6002807617 54.8114776611 71.5794219971"
                collisionVolumeType = Some "Box"
                damage = Some 1500.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 2325.0
                object_ = Some "Units/scavboss/armassimilator_dead.s3o"
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
                metal = Some 930.0
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
              ok = ["mavbok1"]
              select = ["mavbsel1"] })
          customParams = Map.ofList [
              "unitgroup", "weapon"
              "model_author", "PtaQ"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmGantry"
              "techlevel", "3.0"
              "weapon1turretx", "200.0"
              "weapon1turrety", "200.0"
          ]
          extras = Map.ofList [
              "mass", "200000.0"
              "strafetoattack", "true"
              "upright", "true"
          ] }

    let armassimilatorToFlat (def: UnitDef) : Armassimilator =
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

    let armassimilatorToUnitDef (flat: Armassimilator) : UnitDef =
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

    type Armlunchbox =
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

    let armlunchbox : Armlunchbox =
        { name = "armlunchbox"
          subfolder = "Scavengers/Bots"
          metalCost = ValueOrExpr.Concrete 3300.0
          energyCost = ValueOrExpr.Concrete 71000.0
          buildTime = ValueOrExpr.Concrete 71000.0
          health = ValueOrExpr.Concrete 10000.0
          sightDistance = ValueOrExpr.Concrete 625.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/scavboss/armlunchbox.s3o"
          buildPic = Some "ARMLUNCHBOX.DDS"
          script = Some "Units/scavboss/armlunchbox.cob"
          corpse = Some "DEAD"
          explodeAs = Some "explosiont3"
          selfDestructAs = Some "explosiont3xl"
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "65 60 65"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 33.0
          maxAcc = 0.02645
          maxDec = 0.345
          turnRate = 265.64999
          movementClass = "EPICBOT"
          maxSlope = 17.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 0.726
          weapons = [
                { name = "shocker"
                  displayName = "Heavy long-range g2g plasma cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "commanders", 1100.0
                      "default", 1265.0
                      "shields", 765.0
                      "subs", 400.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1325.0)
                  reloadTime = Some (ValueOrExpr.Concrete 8.0)
                  weaponVelocity = Some 500.0
                  areaOfEffect = Some 192.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.65
                  impulseFactor = Some 0.5
                  noSelfDamage = Some true
                  soundStart = Some "cannhvy5"
                  soundHit = Some "xplomed2"
                  explosiongenerator = Some "custom:genericshellexplosion-huge"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "avoidfriendly", "true"
                      "cegtag", "arty-huge"
                      "collidefriendly", "false"
                      "craterareaofeffect", "192.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firetolerance", "5000.0"
                      "gravityaffected", "true"
                      "heightboostfactor", "2.8"
                      "predictboost", "0.25"
                      "soundhitwet", "splslrg"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-3.37104034424 -1.05229058838 1.8899307251"
                  collisionVolumeScales = Some "64.0154266357 41.4324188232 55.433883667"
                  collisionVolumeType = Some "Box"
                  damage = Some 3000.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 2028.0
                  object_ = Some "Units/scavboss/armlunchbox_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 3015.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 811.0
                  object_ = Some "Units/arm4X4D.s3o"
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
                "unitgroup", "weapon"
                "model_author", "Flaka"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmGantry"
                "techlevel", "3.0"
            ]
          extras = Map.ofList [
                "hightrajectory", "2.0"
                "mass", "200000.0"
                "nochasecategory", "VTOL"
            ] }

    let armlunchboxDef : UnitDef =
        { name = "armlunchbox"
          subfolder = "Scavengers/Bots"
          metalCost = ValueOrExpr.Concrete 3300.0
          energyCost = ValueOrExpr.Concrete 71000.0
          buildTime = ValueOrExpr.Concrete 71000.0
          health = ValueOrExpr.Concrete 10000.0
          sightDistance = ValueOrExpr.Concrete 625.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/scavboss/armlunchbox.s3o"
          buildPic = Some "ARMLUNCHBOX.DDS"
          script = Some "Units/scavboss/armlunchbox.cob"
          corpse = Some "DEAD"
          explodeAs = Some "explosiont3"
          selfDestructAs = Some "explosiont3xl"
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "65 60 65"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 33.0
              maxAcc = 0.02645
              maxDec = 0.345
              turnRate = 265.64999
              movementClass = Some "EPICBOT"
              maxSlope = Some 17.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 0.726
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "shocker"
                displayName = "Heavy long-range g2g plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "commanders", 1100.0
                    "default", 1265.0
                    "shields", 765.0
                    "subs", 400.0
                ]
                range = Some (ValueOrExpr.Concrete 1325.0)
                reloadTime = Some (ValueOrExpr.Concrete 8.0)
                weaponVelocity = Some 500.0
                areaOfEffect = Some 192.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.65
                impulseFactor = Some 0.5
                noSelfDamage = Some true
                soundStart = Some "cannhvy5"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:genericshellexplosion-huge"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "avoidfriendly", "true"
                    "cegtag", "arty-huge"
                    "collidefriendly", "false"
                    "craterareaofeffect", "192.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firetolerance", "5000.0"
                    "gravityaffected", "true"
                    "heightboostfactor", "2.8"
                    "predictboost", "0.25"
                    "soundhitwet", "splslrg"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "-3.37104034424 -1.05229058838 1.8899307251"
                collisionVolumeScales = Some "64.0154266357 41.4324188232 55.433883667"
                collisionVolumeType = Some "Box"
                damage = Some 3000.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 2028.0
                object_ = Some "Units/scavboss/armlunchbox_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 3015.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 811.0
                object_ = Some "Units/arm4X4D.s3o"
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
              "model_author", "Flaka"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmGantry"
              "techlevel", "3.0"
          ]
          extras = Map.ofList [
              "hightrajectory", "2.0"
              "mass", "200000.0"
              "nochasecategory", "VTOL"
          ] }

    let armlunchboxToFlat (def: UnitDef) : Armlunchbox =
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

    let armlunchboxToUnitDef (flat: Armlunchbox) : UnitDef =
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

    type Armmeatball =
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

    let armmeatball : Armmeatball =
        { name = "armmeatball"
          subfolder = "Scavengers/Bots"
          metalCost = ValueOrExpr.Concrete 3000.0
          energyCost = ValueOrExpr.Concrete 30000.0
          buildTime = ValueOrExpr.Concrete 30000.0
          health = ValueOrExpr.Concrete 8000.0
          sightDistance = ValueOrExpr.Concrete 800.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/scavboss/ARMMEATBALL.s3o"
          buildPic = Some "ARMMEATBALL.DDS"
          script = Some "Units/scavboss/armmeatball.cob"
          corpse = Some "DEAD"
          explodeAs = Some "explosiont3med"
          selfDestructAs = Some "explosiont3"
          collisionVolumeOffsets = Some "0 -2 -1"
          collisionVolumeScales = Some "34 68 38"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 30.0
          maxAcc = 0.253
          maxDec = 0.8211
          turnRate = 1214.40002
          movementClass = "EPICBOT"
          maxSlope = 17.0
          maxWaterDepth = 32.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.98
          weapons = [
                { name = "lrpc"
                  displayName = "Long range g2g plasma cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 200.0
                  ]
                  range = Some (ValueOrExpr.Concrete 800.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.3)
                  weaponVelocity = Some 400.0
                  areaOfEffect = Some 75.0
                  accuracy = Some 1500.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.5
                  noSelfDamage = Some true
                  soundStart = Some "KroGun1"
                  soundHit = Some "xplomed2"
                  explosiongenerator = Some "custom:genericshellexplosion-medium"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "GROUNDSCOUT"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "cegtag", "arty-large"
                      "collidefriendly", "false"
                      "craterareaofeffect", "116.0"
                      "craterboost", "0.1"
                      "cratermult", "0.1"
                      "gravityaffected", "true"
                      "heightboostfactor", "8.0"
                      "leadbonus", "0.0"
                      "model", "artshell-large.s3o"
                      "soundhitwet", "splshbig"
                      "soundhitvolume", "38.0"
                      "soundstartvolume", "24.0"
                  ] }
                { name = "armamph_missile"
                  displayName = "Guided g2a missile launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "vtol", 85.0
                  ]
                  range = Some (ValueOrExpr.Concrete 600.0)
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
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "canattackground", "false"
                      "cegtag", "missiletrailaa"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "70.0"
                      "flighttime", "1.75"
                      "metalpershot", "0.0"
                      "model", "cormissile.s3o"
                      "smoketrail", "true"
                      "smokePeriod", "5.0"
                      "smoketime", "12.0"
                      "smokesize", "4.4"
                      "smokecolor", "0.95"
                      "smokeTrailCastShadow", "false"
                      "castshadow", "false"
                      "soundhitwet", "splshbig"
                      "startvelocity", "650.0"
                      "texture1", "null"
                      "texture2", "smoketrailaa"
                      "tracks", "true"
                      "turnrate", "48000.0"
                      "weaponacceleration", "200.0"
                      "weapontimer", "5.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.882118225098 0.0283161499023 6.0887298584"
                  collisionVolumeScales = Some "32.1447906494 31.2162322998 37.0860900879"
                  collisionVolumeType = Some "Box"
                  damage = Some 2400.0
                  featureDead = Some "HEAP"
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 20.0
                  metal = Some 592.0
                  object_ = Some "Units/scavboss/armmeatball_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 1200.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 237.0
                  object_ = Some "Units/arm3X3F.s3o"
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
                ok = ["mavbok1"]
                select = ["mavbsel1"] }
          customParams = Map.ofList [
                "unitgroup", "weapon"
                "model_author", "PtaQ"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmGantry"
                "techlevel", "3.0"
                "weapon1turretx", "90.0"
                "weapon1turrety", "150.0"
            ]
          extras = Map.ofList [
                "mass", "200000.0"
                "nochasecategory", "VTOL"
                "upright", "true"
            ] }

    let armmeatballDef : UnitDef =
        { name = "armmeatball"
          subfolder = "Scavengers/Bots"
          metalCost = ValueOrExpr.Concrete 3000.0
          energyCost = ValueOrExpr.Concrete 30000.0
          buildTime = ValueOrExpr.Concrete 30000.0
          health = ValueOrExpr.Concrete 8000.0
          sightDistance = ValueOrExpr.Concrete 800.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/scavboss/ARMMEATBALL.s3o"
          buildPic = Some "ARMMEATBALL.DDS"
          script = Some "Units/scavboss/armmeatball.cob"
          corpse = Some "DEAD"
          explodeAs = Some "explosiont3med"
          selfDestructAs = Some "explosiont3"
          collisionVolumeOffsets = Some "0 -2 -1"
          collisionVolumeScales = Some "34 68 38"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 30.0
              maxAcc = 0.253
              maxDec = 0.8211
              turnRate = 1214.40002
              movementClass = Some "EPICBOT"
              maxSlope = Some 17.0
              maxWaterDepth = Some 32.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.98
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "lrpc"
                displayName = "Long range g2g plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 200.0
                ]
                range = Some (ValueOrExpr.Concrete 800.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.3)
                weaponVelocity = Some 400.0
                areaOfEffect = Some 75.0
                accuracy = Some 1500.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.5
                noSelfDamage = Some true
                soundStart = Some "KroGun1"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:genericshellexplosion-medium"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "GROUNDSCOUT"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "cegtag", "arty-large"
                    "collidefriendly", "false"
                    "craterareaofeffect", "116.0"
                    "craterboost", "0.1"
                    "cratermult", "0.1"
                    "gravityaffected", "true"
                    "heightboostfactor", "8.0"
                    "leadbonus", "0.0"
                    "model", "artshell-large.s3o"
                    "soundhitwet", "splshbig"
                    "soundhitvolume", "38.0"
                    "soundstartvolume", "24.0"
                ] }
              { name = "armamph_missile"
                displayName = "Guided g2a missile launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 85.0
                ]
                range = Some (ValueOrExpr.Concrete 600.0)
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
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "cegtag", "missiletrailaa"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "70.0"
                    "flighttime", "1.75"
                    "metalpershot", "0.0"
                    "model", "cormissile.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "5.0"
                    "smoketime", "12.0"
                    "smokesize", "4.4"
                    "smokecolor", "0.95"
                    "smokeTrailCastShadow", "false"
                    "castshadow", "false"
                    "soundhitwet", "splshbig"
                    "startvelocity", "650.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa"
                    "tracks", "true"
                    "turnrate", "48000.0"
                    "weaponacceleration", "200.0"
                    "weapontimer", "5.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.882118225098 0.0283161499023 6.0887298584"
                collisionVolumeScales = Some "32.1447906494 31.2162322998 37.0860900879"
                collisionVolumeType = Some "Box"
                damage = Some 2400.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 592.0
                object_ = Some "Units/scavboss/armmeatball_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 1200.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 237.0
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
              ok = ["mavbok1"]
              select = ["mavbsel1"] })
          customParams = Map.ofList [
              "unitgroup", "weapon"
              "model_author", "PtaQ"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmGantry"
              "techlevel", "3.0"
              "weapon1turretx", "90.0"
              "weapon1turrety", "150.0"
          ]
          extras = Map.ofList [
              "mass", "200000.0"
              "nochasecategory", "VTOL"
              "upright", "true"
          ] }

    let armmeatballToFlat (def: UnitDef) : Armmeatball =
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

    let armmeatballToUnitDef (flat: Armmeatball) : UnitDef =
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

    type Armpwt4 =
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

    let armpwt4 : Armpwt4 =
        { name = "armpwt4"
          subfolder = "Scavengers/Bots"
          metalCost = ValueOrExpr.Concrete 8000.0
          energyCost = ValueOrExpr.Concrete 150000.0
          buildTime = ValueOrExpr.Concrete 150000.0
          health = ValueOrExpr.Concrete 16700.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/scavboss/armpwt4.s3o"
          buildPic = Some "scavengers/armpwt4.DDS"
          script = Some "Units/scavboss/armpwt4.cob"
          corpse = Some "DEAD"
          explodeAs = Some "bantha"
          selfDestructAs = Some "banthaSelfd"
          collisionVolumeOffsets = Some "0 -1 -5"
          collisionVolumeScales = Some "55 80 55"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 84.0
          maxAcc = 0.414
          maxDec = 0.69
          turnRate = 1200.44
          movementClass = "EPICBOT"
          maxSlope = 17.0
          maxWaterDepth = 25.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 2.0
          weapons = [
                { name = "emg"
                  displayName = "Rapid-fire huge g2g plasma guns"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "commanders", 50.0
                      "default", 200.0
                      "shields", 87.0
                      "vtol", 50.0
                  ]
                  range = Some (ValueOrExpr.Concrete 450.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.16667)
                  weaponVelocity = Some 800.0
                  areaOfEffect = Some 10.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "flashemgxl"
                  soundHit = Some "flashemgxlhit2"
                  explosiongenerator = Some "custom:plasmahit-huge"
                  rgbColor = Some "1 0.95 0.4"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "100.0"
                      "intensity", "1.4"
                      "proximitypriority", "-1.0"
                      "size", "5.1"
                      "soundhitwet", "splshbig"
                      "sprayangle", "200.0"
                      "targetmoveerror", "0.5"
                      "weapontimer", "0.1"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.979118347168 -0.453806965332 -0.796119689941"
                  collisionVolumeScales = Some "60.1392364502 36.4953460693 58.797164917"
                  collisionVolumeType = Some "Box"
                  damage = Some 7500.0
                  featureDead = None
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 40.0
                  metal = Some 4000.0
                  object_ = Some "Units/scavboss/armpwt4_dead.s3o"
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
                ok = ["servtny2"]
                select = ["servtny2"] }
          customParams = Map.ofList [
                "unitgroup", "weapon"
                "model_author", "Kaiser"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "other/scavengers"
                "techlevel", "3.0"
                "weapon1turretx", "300.0"
                "weapon1turrety", "300.0"
            ]
          extras = Map.ofList [
                "mass", "1000000.0"
                "nochasecategory", "VTOL"
                "upright", "true"
            ] }

    let armpwt4Def : UnitDef =
        { name = "armpwt4"
          subfolder = "Scavengers/Bots"
          metalCost = ValueOrExpr.Concrete 8000.0
          energyCost = ValueOrExpr.Concrete 150000.0
          buildTime = ValueOrExpr.Concrete 150000.0
          health = ValueOrExpr.Concrete 16700.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/scavboss/armpwt4.s3o"
          buildPic = Some "scavengers/armpwt4.DDS"
          script = Some "Units/scavboss/armpwt4.cob"
          corpse = Some "DEAD"
          explodeAs = Some "bantha"
          selfDestructAs = Some "banthaSelfd"
          collisionVolumeOffsets = Some "0 -1 -5"
          collisionVolumeScales = Some "55 80 55"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 84.0
              maxAcc = 0.414
              maxDec = 0.69
              turnRate = 1200.44
              movementClass = Some "EPICBOT"
              maxSlope = Some 17.0
              maxWaterDepth = Some 25.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 2.0
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "emg"
                displayName = "Rapid-fire huge g2g plasma guns"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "commanders", 50.0
                    "default", 200.0
                    "shields", 87.0
                    "vtol", 50.0
                ]
                range = Some (ValueOrExpr.Concrete 450.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.16667)
                weaponVelocity = Some 800.0
                areaOfEffect = Some 10.0
                accuracy = None
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "flashemgxl"
                soundHit = Some "flashemgxlhit2"
                explosiongenerator = Some "custom:plasmahit-huge"
                rgbColor = Some "1 0.95 0.4"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "100.0"
                    "intensity", "1.4"
                    "proximitypriority", "-1.0"
                    "size", "5.1"
                    "soundhitwet", "splshbig"
                    "sprayangle", "200.0"
                    "targetmoveerror", "0.5"
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
                collisionVolumeScales = Some "60.1392364502 36.4953460693 58.797164917"
                collisionVolumeType = Some "Box"
                damage = Some 7500.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 40.0
                metal = Some 4000.0
                object_ = Some "Units/scavboss/armpwt4_dead.s3o"
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
              ok = ["servtny2"]
              select = ["servtny2"] })
          customParams = Map.ofList [
              "unitgroup", "weapon"
              "model_author", "Kaiser"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "other/scavengers"
              "techlevel", "3.0"
              "weapon1turretx", "300.0"
              "weapon1turrety", "300.0"
          ]
          extras = Map.ofList [
              "mass", "1000000.0"
              "nochasecategory", "VTOL"
              "upright", "true"
          ] }

    let armpwt4ToFlat (def: UnitDef) : Armpwt4 =
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

    let armpwt4ToUnitDef (flat: Armpwt4) : UnitDef =
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

    type Armsptkt4 =
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
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armsptkt4 : Armsptkt4 =
        { name = "armsptkt4"
          subfolder = "Scavengers/Bots"
          metalCost = ValueOrExpr.Concrete 7500.0
          energyCost = ValueOrExpr.Concrete 75000.0
          buildTime = ValueOrExpr.Concrete 75000.0
          health = ValueOrExpr.Concrete 28000.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/scavboss/armsptkt4.s3o"
          buildPic = Some "scavengers/armsptkt4.DDS"
          script = Some "Units/scavboss/armsptkt4.cob"
          corpse = Some "DEAD"
          explodeAs = Some "empblast"
          selfDestructAs = Some "empblast"
          collisionVolumeOffsets = Some "0 -4 0"
          collisionVolumeScales = Some "75 50 75"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 36.0
          maxAcc = 0.207
          maxDec = 0.6486
          turnRate = 650.0
          movementClass = "EPICALLTERRAIN"
          maxWaterDepth = 12.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 350.0
          weapons = [
                { name = "adv_rocket"
                  displayName = "Parabolic trajectory g2g multi-rocket launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "default", 500.0
                      "subs", 200.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1000.0)
                  reloadTime = Some (ValueOrExpr.Concrete 10.0)
                  weaponVelocity = Some 900.0
                  areaOfEffect = Some 100.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.65
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "rocksalvo"
                  soundHit = Some "rockhit"
                  explosiongenerator = Some "custom:genericshellexplosion-catapult"
                  rgbColor = None
                  customParams = Map.ofList [
                      "projectile_destruction_method", "descend"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "burst", "6.0"
                      "burstrate", "0.2"
                      "cegtag", "missiletrailsmall"
                      "collidefriendly", "false"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "dance", "16.0"
                      "firestarter", "70.0"
                      "flighttime", "4.0"
                      "model", "catapultmissile.s3o"
                      "movingaccuracy", "450.0"
                      "smoketrail", "false"
                      "soundhitwet", "splssml"
                      "soundtrigger", "true"
                      "startvelocity", "80.0"
                      "targetmoveerror", "0.2"
                      "texture1", "null"
                      "texture2", "smoketrailbar"
                      "trajectoryheight", "1.0"
                      "turnrate", "2000.0"
                      "weaponacceleration", "75.0"
                      "weapontimer", "7.0"
                      "wobble", "2000.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.13973236084 -4.67773437585e-06 -1.37111663818"
                  collisionVolumeScales = Some "47.3038787842 18.2459106445 47.0814971924"
                  collisionVolumeType = Some "Box"
                  damage = Some 12500.0
                  featureDead = Some "HEAP"
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 40.0
                  metal = Some 3750.0
                  object_ = Some "Units/scavboss/armsptkt4_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 6250.0
                  featureDead = None
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 4.0
                  metal = Some 1875.0
                  object_ = Some "Units/arm4X4A.s3o"
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
                ok = ["spider2"]
                select = ["spider3"] }
          customParams = Map.ofList [
                "unitgroup", "weapon"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "paralyzemultiplier", "0.125"
                "subfolder", "ArmBots/T2"
                "techlevel", "3.0"
            ]
          extras = Map.ofList [
                "mass", "5000.0"
                "mygravity", "10000.0"
                "nochasecategory", "VTOL"
            ] }

    let armsptkt4Def : UnitDef =
        { name = "armsptkt4"
          subfolder = "Scavengers/Bots"
          metalCost = ValueOrExpr.Concrete 7500.0
          energyCost = ValueOrExpr.Concrete 75000.0
          buildTime = ValueOrExpr.Concrete 75000.0
          health = ValueOrExpr.Concrete 28000.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/scavboss/armsptkt4.s3o"
          buildPic = Some "scavengers/armsptkt4.DDS"
          script = Some "Units/scavboss/armsptkt4.cob"
          corpse = Some "DEAD"
          explodeAs = Some "empblast"
          selfDestructAs = Some "empblast"
          collisionVolumeOffsets = Some "0 -4 0"
          collisionVolumeScales = Some "75 50 75"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 36.0
              maxAcc = 0.207
              maxDec = 0.6486
              turnRate = 650.0
              movementClass = Some "EPICALLTERRAIN"
              maxSlope = None
              maxWaterDepth = Some 12.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 350.0
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "adv_rocket"
                displayName = "Parabolic trajectory g2g multi-rocket launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 500.0
                    "subs", 200.0
                ]
                range = Some (ValueOrExpr.Concrete 1000.0)
                reloadTime = Some (ValueOrExpr.Concrete 10.0)
                weaponVelocity = Some 900.0
                areaOfEffect = Some 100.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.65
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "rocksalvo"
                soundHit = Some "rockhit"
                explosiongenerator = Some "custom:genericshellexplosion-catapult"
                rgbColor = None
                customParams = Map.ofList [
                    "projectile_destruction_method", "descend"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "burst", "6.0"
                    "burstrate", "0.2"
                    "cegtag", "missiletrailsmall"
                    "collidefriendly", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "dance", "16.0"
                    "firestarter", "70.0"
                    "flighttime", "4.0"
                    "model", "catapultmissile.s3o"
                    "movingaccuracy", "450.0"
                    "smoketrail", "false"
                    "soundhitwet", "splssml"
                    "soundtrigger", "true"
                    "startvelocity", "80.0"
                    "targetmoveerror", "0.2"
                    "texture1", "null"
                    "texture2", "smoketrailbar"
                    "trajectoryheight", "1.0"
                    "turnrate", "2000.0"
                    "weaponacceleration", "75.0"
                    "weapontimer", "7.0"
                    "wobble", "2000.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.13973236084 -4.67773437585e-06 -1.37111663818"
                collisionVolumeScales = Some "47.3038787842 18.2459106445 47.0814971924"
                collisionVolumeType = Some "Box"
                damage = Some 12500.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 40.0
                metal = Some 3750.0
                object_ = Some "Units/scavboss/armsptkt4_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 6250.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 4.0
                metal = Some 1875.0
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
              ok = ["spider2"]
              select = ["spider3"] })
          customParams = Map.ofList [
              "unitgroup", "weapon"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "paralyzemultiplier", "0.125"
              "subfolder", "ArmBots/T2"
              "techlevel", "3.0"
          ]
          extras = Map.ofList [
              "mass", "5000.0"
              "mygravity", "10000.0"
              "nochasecategory", "VTOL"
          ] }

    let armsptkt4ToFlat (def: UnitDef) : Armsptkt4 =
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
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armsptkt4ToUnitDef (flat: Armsptkt4) : UnitDef =
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
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corakt4 =
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

    let corakt4 : Corakt4 =
        { name = "corakt4"
          subfolder = "Scavengers/Bots"
          metalCost = ValueOrExpr.Concrete 6000.0
          energyCost = ValueOrExpr.Concrete 120000.0
          buildTime = ValueOrExpr.Concrete 120000.0
          health = ValueOrExpr.Concrete 11100.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/scavboss/CORAKT4.s3o"
          buildPic = Some "CORAKT4.DDS"
          script = Some "Units/scavboss/CORAKT4.cob"
          corpse = Some "DEAD"
          explodeAs = Some "explosiont3"
          selfDestructAs = Some "explosiont3xl"
          collisionVolumeOffsets = Some "0 -2 -3"
          collisionVolumeScales = Some "49 56 49"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 84.0
          maxAcc = 0.4416
          maxDec = 0.8625
          turnRate = 1391.5
          movementClass = "EPICBOT"
          maxSlope = 17.0
          maxWaterDepth = 25.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.848
          weapons = [
                { name = "gator_laser"
                  displayName = "Laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 100.0
                      "vtol", 20.0
                  ]
                  range = Some (ValueOrExpr.Concrete 600.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.1)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 17.0
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
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "beamtime", "0.1"
                      "beamttl", "1.0"
                      "corethickness", "0.315"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "0.0"
                      "firestarter", "50.0"
                      "impactonly", "1.0"
                      "laserflaresize", "8.0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "2.25"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.114540100098 -2.64214854004 2.11838531494"
                  collisionVolumeScales = Some "32.2373809814 13.5927429199 29.8415679932"
                  collisionVolumeType = Some "Box"
                  damage = Some 15000.0
                  featureDead = Some "HEAP"
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 20.0
                  metal = Some 3500.0
                  object_ = Some "Units/scavboss/corakt4_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 7500.0
                  featureDead = None
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 4.0
                  metal = Some 1750.0
                  object_ = Some "Units/cor4X4C.s3o"
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
                ok = ["servtny1"]
                select = ["servtny1"] }
          customParams = Map.ofList [
                "unitgroup", "weapon"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBots"
                "weapon1turretx", "300.0"
                "weapon1turrety", "300.0"
            ]
          extras = Map.ofList [
                "mass", "1000000.0"
                "nochasecategory", "VTOL"
                "upright", "true"
            ] }

    let corakt4Def : UnitDef =
        { name = "corakt4"
          subfolder = "Scavengers/Bots"
          metalCost = ValueOrExpr.Concrete 6000.0
          energyCost = ValueOrExpr.Concrete 120000.0
          buildTime = ValueOrExpr.Concrete 120000.0
          health = ValueOrExpr.Concrete 11100.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/scavboss/CORAKT4.s3o"
          buildPic = Some "CORAKT4.DDS"
          script = Some "Units/scavboss/CORAKT4.cob"
          corpse = Some "DEAD"
          explodeAs = Some "explosiont3"
          selfDestructAs = Some "explosiont3xl"
          collisionVolumeOffsets = Some "0 -2 -3"
          collisionVolumeScales = Some "49 56 49"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 84.0
              maxAcc = 0.4416
              maxDec = 0.8625
              turnRate = 1391.5
              movementClass = Some "EPICBOT"
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
                displayName = "Laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 100.0
                    "vtol", 20.0
                ]
                range = Some (ValueOrExpr.Concrete 600.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.1)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 17.0
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
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamtime", "0.1"
                    "beamttl", "1.0"
                    "corethickness", "0.315"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "0.0"
                    "firestarter", "50.0"
                    "impactonly", "1.0"
                    "laserflaresize", "8.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.25"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.114540100098 -2.64214854004 2.11838531494"
                collisionVolumeScales = Some "32.2373809814 13.5927429199 29.8415679932"
                collisionVolumeType = Some "Box"
                damage = Some 15000.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 3500.0
                object_ = Some "Units/scavboss/corakt4_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 7500.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 4.0
                metal = Some 1750.0
                object_ = Some "Units/cor4X4C.s3o"
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
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorBots"
              "weapon1turretx", "300.0"
              "weapon1turrety", "300.0"
          ]
          extras = Map.ofList [
              "mass", "1000000.0"
              "nochasecategory", "VTOL"
              "upright", "true"
          ] }

    let corakt4ToFlat (def: UnitDef) : Corakt4 =
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

    let corakt4ToUnitDef (flat: Corakt4) : UnitDef =
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

    type Cordeadeye =
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

    let cordeadeye : Cordeadeye =
        { name = "cordeadeye"
          subfolder = "Scavengers/Bots"
          metalCost = ValueOrExpr.Concrete 1050.0
          energyCost = ValueOrExpr.Concrete 27500.0
          buildTime = ValueOrExpr.Concrete 32000.0
          health = ValueOrExpr.Concrete 2700.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/cordeadeye.s3o"
          buildPic = Some "cordeadeye.DDS"
          script = Some "scavs/cordeadeye.COB"
          corpse = Some "DEAD"
          explodeAs = Some "penetrator"
          selfDestructAs = Some "deadeyeSelfd"
          collisionVolumeOffsets = Some "0 0 -2"
          collisionVolumeScales = Some "32 34 30"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 40.0
          maxAcc = 0.138
          maxDec = 0.6486
          turnRate = 400.0
          movementClass = "HBOT4"
          maxSlope = 16.0
          maxWaterDepth = 22.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 0.65
          weapons = [
                { name = "cor_burst_laser"
                  displayName = "HeavyBlaster"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "default", 834.0
                      "commanders", 342.0
                  ]
                  range = Some (ValueOrExpr.Concrete 850.0)
                  reloadTime = Some (ValueOrExpr.Concrete 12.0)
                  weaponVelocity = Some 1821.0
                  areaOfEffect = Some 20.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.85
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrfir5"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-large-aqua"
                  rgbColor = Some "0.0 0.5 0.8"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_burstControlWhenOutOfArc", "2.0"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "collideenemy", "true"
                      "burst", "3.0"
                      "burstrate", "0.5"
                      "corethickness", "1.0"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "800.0"
                      "firestarter", "30.0"
                      "impactonly", "0.0"
                      "impulseboost", "0.0"
                      "intensity", "2.2"
                      "rgbcolor2", "0.2 0.8 1.0"
                      "soundhitdry", "xplosml5"
                      "soundhitwet", "sizzle"
                      "soundtrigger", "false"
                      "targetmoveerror", "0.0"
                      "thickness", "2.0"
                      "duration", "0.05"
                      "sprayAngle", "0.1"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.220962524414 -3.57609763184 -0.162803649902"
                  collisionVolumeScales = Some "39.2589111328 21.1636047363 24.3341522217"
                  collisionVolumeType = Some "Box"
                  damage = Some 1800.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 339.0
                  object_ = Some "Units/cordeadeye_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 1250.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 136.0
                  object_ = Some "Units/cor3X3A.s3o"
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
                ok = ["kbcormov"]
                select = ["kbcorsel"] }
          customParams = Map.ofList [
                "unitgroup", "weapon"
                "model_author", "Kaludjo"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBots/t2"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "nochasecategory", "VTOL"
                "selfdestructcountdown", "3.0"
                "upright", "false"
            ] }

    let cordeadeyeDef : UnitDef =
        { name = "cordeadeye"
          subfolder = "Scavengers/Bots"
          metalCost = ValueOrExpr.Concrete 1050.0
          energyCost = ValueOrExpr.Concrete 27500.0
          buildTime = ValueOrExpr.Concrete 32000.0
          health = ValueOrExpr.Concrete 2700.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/cordeadeye.s3o"
          buildPic = Some "cordeadeye.DDS"
          script = Some "scavs/cordeadeye.COB"
          corpse = Some "DEAD"
          explodeAs = Some "penetrator"
          selfDestructAs = Some "deadeyeSelfd"
          collisionVolumeOffsets = Some "0 0 -2"
          collisionVolumeScales = Some "32 34 30"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 40.0
              maxAcc = 0.138
              maxDec = 0.6486
              turnRate = 400.0
              movementClass = Some "HBOT4"
              maxSlope = Some 16.0
              maxWaterDepth = Some 22.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 0.65
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "cor_burst_laser"
                displayName = "HeavyBlaster"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 834.0
                    "commanders", 342.0
                ]
                range = Some (ValueOrExpr.Concrete 850.0)
                reloadTime = Some (ValueOrExpr.Concrete 12.0)
                weaponVelocity = Some 1821.0
                areaOfEffect = Some 20.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrfir5"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-large-aqua"
                rgbColor = Some "0.0 0.5 0.8"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_burstControlWhenOutOfArc", "2.0"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "collideenemy", "true"
                    "burst", "3.0"
                    "burstrate", "0.5"
                    "corethickness", "1.0"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "800.0"
                    "firestarter", "30.0"
                    "impactonly", "0.0"
                    "impulseboost", "0.0"
                    "intensity", "2.2"
                    "rgbcolor2", "0.2 0.8 1.0"
                    "soundhitdry", "xplosml5"
                    "soundhitwet", "sizzle"
                    "soundtrigger", "false"
                    "targetmoveerror", "0.0"
                    "thickness", "2.0"
                    "duration", "0.05"
                    "sprayAngle", "0.1"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.220962524414 -3.57609763184 -0.162803649902"
                collisionVolumeScales = Some "39.2589111328 21.1636047363 24.3341522217"
                collisionVolumeType = Some "Box"
                damage = Some 1800.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 339.0
                object_ = Some "Units/cordeadeye_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 1250.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 136.0
                object_ = Some "Units/cor3X3A.s3o"
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
              "model_author", "Kaludjo"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorBots/t2"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "nochasecategory", "VTOL"
              "selfdestructcountdown", "3.0"
              "upright", "false"
          ] }

    let cordeadeyeToFlat (def: UnitDef) : Cordeadeye =
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

    let cordeadeyeToUnitDef (flat: Cordeadeye) : UnitDef =
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

    type Corkark =
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

    let corkark : Corkark =
        { name = "corkark"
          subfolder = "Scavengers/Bots"
          metalCost = ValueOrExpr.Concrete 280.0
          energyCost = ValueOrExpr.Concrete 2400.0
          buildTime = ValueOrExpr.Concrete 4000.0
          health = ValueOrExpr.Concrete 1280.0
          sightDistance = ValueOrExpr.Concrete 400.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/corkark.s3o"
          buildPic = Some "corkark.DDS"
          script = Some "Units/corkark.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallExplosionGeneric"
          selfDestructAs = Some "smallExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 1"
          collisionVolumeScales = Some "29 35 29"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 42.0
          maxAcc = 0.0828
          maxDec = 0.8211
          turnRate = 885.5
          movementClass = "BOT2"
          maxSlope = 17.0
          maxWaterDepth = 12.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 0.99
          weapons = [
                { name = "corwar_laser"
                  displayName = "Light g2g Heat Ray"
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
                  soundStart = Some "lasrfir3"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small"
                  rgbColor = Some "1 0.55 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "beamtime", "0.2"
                      "corethickness", "0.2"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "30.0"
                      "impactonly", "1.0"
                      "laserflaresize", "6.0"
                      "leadlimit", "0.0"
                      "rgbcolor2", "0.9 1.0 0.5"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "1.6625"
                  ] }
                { name = "corlevlr_weapon"
                  displayName = "RiotCannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 190.0
                      "subs", 70.0
                      "vtol", 27.0
                  ]
                  range = Some (ValueOrExpr.Concrete 220.0)
                  reloadTime = Some (ValueOrExpr.Concrete 5.0)
                  weaponVelocity = Some 550.0
                  areaOfEffect = Some 144.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.9
                  impulseFactor = Some 3.0
                  noSelfDamage = Some true
                  soundStart = Some "corlevlr"
                  soundHit = Some "corlevlrhit"
                  explosiongenerator = Some "custom:genericshellexplosion-medium"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "SURFACE"
                      "alphadecay", "0.1"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "nogap", "false"
                      "separation", "2.0"
                      "sizedecay", "0.08"
                      "soundhitvolume", "11.5"
                      "soundhitwet", "splsmed"
                      "soundstartvolume", "13.0"
                      "stages", "12.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-0.527076721191 -15.09926749023 6.06378173828"
                  collisionVolumeScales = Some "37.3442840576 10.0486450195 42.9995422363"
                  collisionVolumeType = Some "Box"
                  damage = Some 880.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 161.0
                  object_ = Some "Units/corkark_dead.s3o"
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
                "unitgroup", "weapon"
                "model_author", "Firestorm"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "Scavengers/Bots"
                "weapon1turretx", "200.0"
                "weapon1turrety", "200.0"
            ]
          extras = Map.ofList [
                "damagemodifier", "0.5"
                "nochasecategory", "VTOL"
                "upright", "true"
            ] }

    let corkarkDef : UnitDef =
        { name = "corkark"
          subfolder = "Scavengers/Bots"
          metalCost = ValueOrExpr.Concrete 280.0
          energyCost = ValueOrExpr.Concrete 2400.0
          buildTime = ValueOrExpr.Concrete 4000.0
          health = ValueOrExpr.Concrete 1280.0
          sightDistance = ValueOrExpr.Concrete 400.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/corkark.s3o"
          buildPic = Some "corkark.DDS"
          script = Some "Units/corkark.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallExplosionGeneric"
          selfDestructAs = Some "smallExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 1"
          collisionVolumeScales = Some "29 35 29"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 42.0
              maxAcc = 0.0828
              maxDec = 0.8211
              turnRate = 885.5
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
              { name = "corwar_laser"
                displayName = "Light g2g Heat Ray"
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
                soundStart = Some "lasrfir3"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-small"
                rgbColor = Some "1 0.55 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamtime", "0.2"
                    "corethickness", "0.2"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "30.0"
                    "impactonly", "1.0"
                    "laserflaresize", "6.0"
                    "leadlimit", "0.0"
                    "rgbcolor2", "0.9 1.0 0.5"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "1.6625"
                ] }
              { name = "corlevlr_weapon"
                displayName = "RiotCannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 190.0
                    "subs", 70.0
                    "vtol", 27.0
                ]
                range = Some (ValueOrExpr.Concrete 220.0)
                reloadTime = Some (ValueOrExpr.Concrete 5.0)
                weaponVelocity = Some 550.0
                areaOfEffect = Some 144.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.9
                impulseFactor = Some 3.0
                noSelfDamage = Some true
                soundStart = Some "corlevlr"
                soundHit = Some "corlevlrhit"
                explosiongenerator = Some "custom:genericshellexplosion-medium"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "alphadecay", "0.1"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "nogap", "false"
                    "separation", "2.0"
                    "sizedecay", "0.08"
                    "soundhitvolume", "11.5"
                    "soundhitwet", "splsmed"
                    "soundstartvolume", "13.0"
                    "stages", "12.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "-0.527076721191 -15.09926749023 6.06378173828"
                collisionVolumeScales = Some "37.3442840576 10.0486450195 42.9995422363"
                collisionVolumeType = Some "Box"
                damage = Some 880.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 161.0
                object_ = Some "Units/corkark_dead.s3o"
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
              "model_author", "Firestorm"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "Scavengers/Bots"
              "weapon1turretx", "200.0"
              "weapon1turrety", "200.0"
          ]
          extras = Map.ofList [
              "damagemodifier", "0.5"
              "nochasecategory", "VTOL"
              "upright", "true"
          ] }

    let corkarkToFlat (def: UnitDef) : Corkark =
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

    let corkarkToUnitDef (flat: Corkark) : UnitDef =
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

    type Cormandot4 =
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
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          energyMake: ValueOrExpr<float>
          energyStorage: float
          weapons: WeaponDef list
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let cormandot4 : Cormandot4 =
        { name = "cormandot4"
          subfolder = "Scavengers/Bots"
          metalCost = ValueOrExpr.Concrete 6700.0
          energyCost = ValueOrExpr.Concrete 90000.0
          buildTime = ValueOrExpr.Concrete 17100.0
          health = ValueOrExpr.Concrete 9600.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "scavs/cormandot4.s3o"
          buildPic = Some "CORMANDO.DDS"
          script = Some "Scavs/CORMANDOT4.cob"
          corpse = None
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "38 50 22"
          collisionVolumeType = Some "box"
          seismicSignature = Some 4.0
          category = None
          speed = ValueOrExpr.Concrete 60.0
          maxAcc = 0.4025
          maxDec = 1.725
          turnRate = 1168.40002
          movementClass = "ABOT3"
          maxSlope = 20.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.65
          workerTime = ValueOrExpr.Concrete 600.0
          buildDistance = 200.0
          buildOptions = ["corape"; "cormine3"; "cormwall"; "corfort"; "cortron"]
          energyMake = ValueOrExpr.Concrete 50.0
          energyStorage = 100.0
          weapons = [
                { name = "commando_stunner"
                  displayName = "Close-quarters EMP Scattergun"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 2000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 250.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.2)
                  weaponVelocity = Some 1200.0
                  areaOfEffect = Some 75.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasfirerb"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-emp"
                  rgbColor = Some "0.7 0.7 1"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "GROUNDSCOUT"
                      "mount_onlytargetcategory", "WEAPON"
                      "avoidfeature", "false"
                      "beamdecay", "0.5"
                      "beamtime", "0.1"
                      "beamttl", "0.2"
                      "collideenemy", "false"
                      "collidefriendly", "false"
                      "collidefeature", "false"
                      "corethickness", "0.5"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "0.01"
                      "laserflaresize", "8.0"
                      "paralyzer", "true"
                      "paralyzetime", "7.0"
                      "projectiles", "10.0"
                      "sprayangle", "8000.0"
                      "soundhitdry", "flashemgxlhit"
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "10.0"
                  ] }
                { name = "commando_back_cannon"
                  displayName = "Disintegrator"
                  weaponType = Some "DGun"
                  damage = Map.ofList [
                      "commanders", 200.0
                      "default", 2400.0
                  ]
                  range = Some (ValueOrExpr.Concrete 250.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.9)
                  weaponVelocity = Some 300.0
                  areaOfEffect = Some 36.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "disigun1"
                  soundHit = Some "xplomas2s"
                  explosiongenerator = Some "custom:expldgun"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "WEAPON"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "avoidground", "false"
                      "bouncerebound", "0.0"
                      "cegtag", "dgunprojectile"
                      "craterboost", "0.0"
                      "cratermult", "0.15"
                      "energypershot", "500.0"
                      "explosionscar", "false"
                      "firestarter", "100.0"
                      "firesubmersed", "false"
                      "noexplode", "true"
                      "soundhitwet", "sizzlexs"
                      "soundhitvolume", "36.0"
                      "soundstartvolume", "96.0"
                      "soundtrigger", "true"
                      "waterweapon", "true"
                      "weapontimer", "4.2"
                  ] }
            ]
          sounds =
              { build = Some "nanlath2"
                repair = Some "repair2"
                working = Some "reclaim1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = Some "capture2"
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["kbcormov"]
                select = ["kbcorsel"] }
          customParams = Map.ofList [
                "unitgroup", "buildert2"
                "model_author", "FireStorm"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBots/T2"
                "techlevel", "2.0"
                "paratrooper", "true"
                "water_fall_damage_multiplier", "0.0"
                "fall_damage_multiplier", "0.0"
                "nopvebuilder", "true"
            ]
          extras = Map.ofList [
                "autoheal", "9.0"
                "cancloak", "true"
                "cloakcost", "100.0"
                "cloakcostmoving", "1000.0"
                "canassist", "true"
                "canreclaim", "true"
                "canrepair", "true"
                "canrestore", "false"
                "mincloakdistance", "50.0"
                "nochasecategory", "VTOL"
                "radardistance", "900.0"
                "radardistancejam", "200.0"
                "upright", "true"
            ] }

    let cormandot4Def : UnitDef =
        { name = "cormandot4"
          subfolder = "Scavengers/Bots"
          metalCost = ValueOrExpr.Concrete 6700.0
          energyCost = ValueOrExpr.Concrete 90000.0
          buildTime = ValueOrExpr.Concrete 17100.0
          health = ValueOrExpr.Concrete 9600.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "scavs/cormandot4.s3o"
          buildPic = Some "CORMANDO.DDS"
          script = Some "Scavs/CORMANDOT4.cob"
          corpse = None
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "38 50 22"
          collisionVolumeType = Some "box"
          seismicSignature = Some 4.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 60.0
              maxAcc = 0.4025
              maxDec = 1.725
              turnRate = 1168.40002
              movementClass = Some "ABOT3"
              maxSlope = Some 20.0
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.65
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 600.0
              buildDistance = Some 200.0
              buildOptions = ["corape"; "cormine3"; "cormwall"; "corfort"; "cortron"]
              terraformSpeed = None })
          weapons = Some [
              { name = "commando_stunner"
                displayName = "Close-quarters EMP Scattergun"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 2000.0
                ]
                range = Some (ValueOrExpr.Concrete 250.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.2)
                weaponVelocity = Some 1200.0
                areaOfEffect = Some 75.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 1.0
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasfirerb"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-emp"
                rgbColor = Some "0.7 0.7 1"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "GROUNDSCOUT"
                    "mount_onlytargetcategory", "WEAPON"
                    "avoidfeature", "false"
                    "beamdecay", "0.5"
                    "beamtime", "0.1"
                    "beamttl", "0.2"
                    "collideenemy", "false"
                    "collidefriendly", "false"
                    "collidefeature", "false"
                    "corethickness", "0.5"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.01"
                    "laserflaresize", "8.0"
                    "paralyzer", "true"
                    "paralyzetime", "7.0"
                    "projectiles", "10.0"
                    "sprayangle", "8000.0"
                    "soundhitdry", "flashemgxlhit"
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "10.0"
                ] }
              { name = "commando_back_cannon"
                displayName = "Disintegrator"
                weaponType = Some "DGun"
                damage = Map.ofList [
                    "commanders", 200.0
                    "default", 2400.0
                ]
                range = Some (ValueOrExpr.Concrete 250.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.9)
                weaponVelocity = Some 300.0
                areaOfEffect = Some 36.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "disigun1"
                soundHit = Some "xplomas2s"
                explosiongenerator = Some "custom:expldgun"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "WEAPON"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "avoidground", "false"
                    "bouncerebound", "0.0"
                    "cegtag", "dgunprojectile"
                    "craterboost", "0.0"
                    "cratermult", "0.15"
                    "energypershot", "500.0"
                    "explosionscar", "false"
                    "firestarter", "100.0"
                    "firesubmersed", "false"
                    "noexplode", "true"
                    "soundhitwet", "sizzlexs"
                    "soundhitvolume", "36.0"
                    "soundstartvolume", "96.0"
                    "soundtrigger", "true"
                    "waterweapon", "true"
                    "weapontimer", "4.2"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 50.0)
              metalMake = None
              energyStorage = Some 100.0
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = None
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
              "unitgroup", "buildert2"
              "model_author", "FireStorm"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorBots/T2"
              "techlevel", "2.0"
              "paratrooper", "true"
              "water_fall_damage_multiplier", "0.0"
              "fall_damage_multiplier", "0.0"
              "nopvebuilder", "true"
          ]
          extras = Map.ofList [
              "autoheal", "9.0"
              "cancloak", "true"
              "cloakcost", "100.0"
              "cloakcostmoving", "1000.0"
              "canassist", "true"
              "canreclaim", "true"
              "canrepair", "true"
              "canrestore", "false"
              "mincloakdistance", "50.0"
              "nochasecategory", "VTOL"
              "radardistance", "900.0"
              "radardistancejam", "200.0"
              "upright", "true"
          ] }

    let cormandot4ToFlat (def: UnitDef) : Cormandot4 =
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
          workerTime = def.builder.Value.workerTime
          buildDistance = def.builder.Value.buildDistance.Value
          buildOptions = def.builder.Value.buildOptions
          energyMake = def.economy.Value.energyMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          weapons = def.weapons.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let cormandot4ToUnitDef (flat: Cormandot4) : UnitDef =
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
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = Some flat.buildDistance
              buildOptions = flat.buildOptions
              terraformSpeed = None
            }
          weapons = Some flat.weapons
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = None
              energyStorage = Some flat.energyStorage
              metalStorage = None
              extractsMetal = None
            }
          building = None
          featureDefs = None
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corthermite =
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

    let corthermite : Corthermite =
        { name = "corthermite"
          subfolder = "Scavengers/Bots"
          metalCost = ValueOrExpr.Concrete 3500.0
          energyCost = ValueOrExpr.Concrete 60000.0
          buildTime = ValueOrExpr.Concrete 188000.0
          health = ValueOrExpr.Concrete 15000.0
          sightDistance = ValueOrExpr.Concrete 480.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/scavboss/CORTHERMITE.s3o"
          buildPic = Some "CORTHERMITE.DDS"
          script = Some "Units/scavboss/CORTHERMITE.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "80 50 98"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 42.3
          maxAcc = 0.19665
          maxDec = 0.60375
          turnRate = 1214.40002
          movementClass = "HTBOT6"
          maxSlope = 50.0
          maxWaterDepth = 60.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.0626
          weapons = [
                { name = "thermite_laser"
                  displayName = "Thermite Heatray"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 2000.0
                      "vtol", 550.0
                  ]
                  range = Some (ValueOrExpr.Concrete 900.0)
                  reloadTime = Some (ValueOrExpr.Concrete 4.0)
                  weaponVelocity = Some 1500.0
                  areaOfEffect = Some 72.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "heatray1s"
                  soundHit = None
                  explosiongenerator = Some "custom:genericshellexplosion-medium-beam"
                  rgbColor = Some "1 0.8 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "avoidfriendly", "true"
                      "beamtime", "0.6"
                      "camerashake", "0.1"
                      "corethickness", "0.35"
                      "craterareaofeffect", "72.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "350.0"
                      "firestarter", "90.0"
                      "laserflaresize", "8.25"
                      "proximitypriority", "-1.0"
                      "rgbcolor2", "0.8 0 0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundstartvolume", "70.0"
                      "soundtrigger", "1.0"
                      "thickness", "6.0"
                  ] }
                { name = "tmaw"
                  displayName = "Thermite heavy medium range AoE flamethrower"
                  weaponType = Some "Flame"
                  damage = Map.ofList [
                      "default", 30.0
                      "subs", 10.0
                  ]
                  range = Some (ValueOrExpr.Concrete 350.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.39996)
                  weaponVelocity = Some 500.0
                  areaOfEffect = Some 128.0
                  accuracy = Some 700.0
                  turret = Some true
                  tolerance = Some 20000.0
                  edgeEffectiveness = Some 0.01
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "Flamhvy1"
                  soundHit = None
                  explosiongenerator = Some "custom:burnthermite"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "avoidfriendly", "true"
                      "avoidground", "false"
                      "burst", "12.0"
                      "burstrate", "0.03333"
                      "bouncerebound", "1.0"
                      "burnblow", "true"
                      "cegtag", "burnflamethermite"
                      "colormap", "1 0.95 0.9 0.032   0.55 0.55 0.40 0.028   0.40 0.28 0.19 0.024   0.033 0.018 0.011 0.04   0.0 0.0 0.0 0.01"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "bounceSlip", "1.0"
                      "firestarter", "100.0"
                      "firesubmersed", "false"
                      "flameGFXTime", "1.0"
                      "intensity", "0.85"
                      "noexplode", "false"
                      "predictboost", "1.0"
                      "sizegrowth", "3.0"
                      "soundhitwet", "sizzle"
                      "soundtrigger", "true"
                      "sprayangle", "700.0"
                      "waterweapon", "false"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 -1.81045331299 4.38243865967"
                  collisionVolumeScales = Some "64.3684997559 30.844833374 66.5386505127"
                  collisionVolumeType = Some "Box"
                  damage = Some 10000.0
                  featureDead = Some "HEAP"
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 10.0
                  metal = Some 1523.0
                  object_ = Some "Units/scavboss/corthermite_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 5000.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = None
                  metal = Some 909.0
                  object_ = Some "Units/cor3X3A.s3o"
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
                ok = ["spider2"]
                select = ["spider"] }
          customParams = Map.ofList [
                "unitgroup", "weapon"
                "model_author", "Beherith, Hornet"
                "normaltex", "unittextures/cor_normal.dds"
                "paralyzemultiplier", "0.125"
                "subfolder", "CorBots/T2"
                "techlevel", "3.0"
            ]
          extras = Map.ofList [
                "mass", "150000.0"
                "mygravity", "10000.0"
                "nochasecategory", "VTOL"
                "strafetoattack", "true"
            ] }

    let corthermiteDef : UnitDef =
        { name = "corthermite"
          subfolder = "Scavengers/Bots"
          metalCost = ValueOrExpr.Concrete 3500.0
          energyCost = ValueOrExpr.Concrete 60000.0
          buildTime = ValueOrExpr.Concrete 188000.0
          health = ValueOrExpr.Concrete 15000.0
          sightDistance = ValueOrExpr.Concrete 480.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/scavboss/CORTHERMITE.s3o"
          buildPic = Some "CORTHERMITE.DDS"
          script = Some "Units/scavboss/CORTHERMITE.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "80 50 98"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 42.3
              maxAcc = 0.19665
              maxDec = 0.60375
              turnRate = 1214.40002
              movementClass = Some "HTBOT6"
              maxSlope = Some 50.0
              maxWaterDepth = Some 60.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.0626
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "thermite_laser"
                displayName = "Thermite Heatray"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 2000.0
                    "vtol", 550.0
                ]
                range = Some (ValueOrExpr.Concrete 900.0)
                reloadTime = Some (ValueOrExpr.Concrete 4.0)
                weaponVelocity = Some 1500.0
                areaOfEffect = Some 72.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "heatray1s"
                soundHit = None
                explosiongenerator = Some "custom:genericshellexplosion-medium-beam"
                rgbColor = Some "1 0.8 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "avoidfriendly", "true"
                    "beamtime", "0.6"
                    "camerashake", "0.1"
                    "corethickness", "0.35"
                    "craterareaofeffect", "72.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "350.0"
                    "firestarter", "90.0"
                    "laserflaresize", "8.25"
                    "proximitypriority", "-1.0"
                    "rgbcolor2", "0.8 0 0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundstartvolume", "70.0"
                    "soundtrigger", "1.0"
                    "thickness", "6.0"
                ] }
              { name = "tmaw"
                displayName = "Thermite heavy medium range AoE flamethrower"
                weaponType = Some "Flame"
                damage = Map.ofList [
                    "default", 30.0
                    "subs", 10.0
                ]
                range = Some (ValueOrExpr.Concrete 350.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.39996)
                weaponVelocity = Some 500.0
                areaOfEffect = Some 128.0
                accuracy = Some 700.0
                turret = Some true
                tolerance = Some 20000.0
                edgeEffectiveness = Some 0.01
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "Flamhvy1"
                soundHit = None
                explosiongenerator = Some "custom:burnthermite"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "avoidfriendly", "true"
                    "avoidground", "false"
                    "burst", "12.0"
                    "burstrate", "0.03333"
                    "bouncerebound", "1.0"
                    "burnblow", "true"
                    "cegtag", "burnflamethermite"
                    "colormap", "1 0.95 0.9 0.032   0.55 0.55 0.40 0.028   0.40 0.28 0.19 0.024   0.033 0.018 0.011 0.04   0.0 0.0 0.0 0.01"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "bounceSlip", "1.0"
                    "firestarter", "100.0"
                    "firesubmersed", "false"
                    "flameGFXTime", "1.0"
                    "intensity", "0.85"
                    "noexplode", "false"
                    "predictboost", "1.0"
                    "sizegrowth", "3.0"
                    "soundhitwet", "sizzle"
                    "soundtrigger", "true"
                    "sprayangle", "700.0"
                    "waterweapon", "false"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0 -1.81045331299 4.38243865967"
                collisionVolumeScales = Some "64.3684997559 30.844833374 66.5386505127"
                collisionVolumeType = Some "Box"
                damage = Some 10000.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 10.0
                metal = Some 1523.0
                object_ = Some "Units/scavboss/corthermite_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 5000.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = None
                metal = Some 909.0
                object_ = Some "Units/cor3X3A.s3o"
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
              ok = ["spider2"]
              select = ["spider"] })
          customParams = Map.ofList [
              "unitgroup", "weapon"
              "model_author", "Beherith, Hornet"
              "normaltex", "unittextures/cor_normal.dds"
              "paralyzemultiplier", "0.125"
              "subfolder", "CorBots/T2"
              "techlevel", "3.0"
          ]
          extras = Map.ofList [
              "mass", "150000.0"
              "mygravity", "10000.0"
              "nochasecategory", "VTOL"
              "strafetoattack", "true"
          ] }

    let corthermiteToFlat (def: UnitDef) : Corthermite =
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

    let corthermiteToUnitDef (flat: Corthermite) : UnitDef =
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

    type Leggobt3 =
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

    let leggobt3 : Leggobt3 =
        { name = "leggobt3"
          subfolder = "Scavengers/Bots"
          metalCost = ValueOrExpr.Concrete 6000.0
          energyCost = ValueOrExpr.Concrete 120000.0
          buildTime = ValueOrExpr.Concrete 120000.0
          health = ValueOrExpr.Concrete 14000.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/scavboss/LEGGOBT3.s3o"
          buildPic = Some "LEGGOB.DDS"
          script = Some "Units/scavboss/LEGGOBT3.cob"
          corpse = Some "DEAD"
          explodeAs = Some "explosiont3med"
          selfDestructAs = Some "explosiont3med"
          collisionVolumeOffsets = Some "0 -7 0"
          collisionVolumeScales = Some "63 77 63"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 60.0
          maxAcc = 0.18
          maxDec = 0.36
          turnRate = 650.0
          movementClass = "HBOT4"
          maxSlope = 17.0
          maxWaterDepth = 25.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.848
          weapons = [
                { name = "semiauto"
                  displayName = "Medium Shotgun"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "default", 40.0
                      "vtol", 13.0
                  ]
                  range = Some (ValueOrExpr.Concrete 800.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.0)
                  weaponVelocity = Some 960.0
                  areaOfEffect = Some 16.0
                  accuracy = Some 7.0
                  turret = Some true
                  tolerance = Some 6000.0
                  edgeEffectiveness = Some 0.85
                  impulseFactor = Some 1.5
                  noSelfDamage = Some true
                  soundStart = Some "kroggie2xs"
                  soundHit = Some "bimpact3"
                  explosiongenerator = Some "custom:plasmahit-sparkonly"
                  rgbColor = Some "1 0.95 0.4"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "burst", "2.0"
                      "burstrate", "0.3"
                      "projectiles", "18.0"
                      "burnblow", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "0.015"
                      "fallOffRate", "0.2"
                      "firestarter", "0.0"
                      "impulseboost", "0.4"
                      "intensity", "0.8"
                      "ownerExpAccWeight", "4.0"
                      "proximitypriority", "1.0"
                      "soundhitwet", "splshbig"
                      "soundstartvolume", "3.0"
                      "sprayangle", "900.0"
                      "thickness", "0.6"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.4 -8 7"
                  collisionVolumeScales = Some "96 40 90"
                  collisionVolumeType = Some "Box"
                  damage = Some 120.0
                  featureDead = Some "HEAP"
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 20.0
                  metal = Some 18.0
                  object_ = Some "Units/scavboss/leggobt3_dead.s3o"
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
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 4.0
                  metal = Some 9.0
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
                ok = ["servtny1"]
                select = ["servtny1"] }
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

    let leggobt3Def : UnitDef =
        { name = "leggobt3"
          subfolder = "Scavengers/Bots"
          metalCost = ValueOrExpr.Concrete 6000.0
          energyCost = ValueOrExpr.Concrete 120000.0
          buildTime = ValueOrExpr.Concrete 120000.0
          health = ValueOrExpr.Concrete 14000.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/scavboss/LEGGOBT3.s3o"
          buildPic = Some "LEGGOB.DDS"
          script = Some "Units/scavboss/LEGGOBT3.cob"
          corpse = Some "DEAD"
          explodeAs = Some "explosiont3med"
          selfDestructAs = Some "explosiont3med"
          collisionVolumeOffsets = Some "0 -7 0"
          collisionVolumeScales = Some "63 77 63"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 60.0
              maxAcc = 0.18
              maxDec = 0.36
              turnRate = 650.0
              movementClass = Some "HBOT4"
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
                displayName = "Medium Shotgun"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 40.0
                    "vtol", 13.0
                ]
                range = Some (ValueOrExpr.Concrete 800.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.0)
                weaponVelocity = Some 960.0
                areaOfEffect = Some 16.0
                accuracy = Some 7.0
                turret = Some true
                tolerance = Some 6000.0
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 1.5
                noSelfDamage = Some true
                soundStart = Some "kroggie2xs"
                soundHit = Some "bimpact3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "1 0.95 0.4"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "burst", "2.0"
                    "burstrate", "0.3"
                    "projectiles", "18.0"
                    "burnblow", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.015"
                    "fallOffRate", "0.2"
                    "firestarter", "0.0"
                    "impulseboost", "0.4"
                    "intensity", "0.8"
                    "ownerExpAccWeight", "4.0"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "3.0"
                    "sprayangle", "900.0"
                    "thickness", "0.6"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.4 -8 7"
                collisionVolumeScales = Some "96 40 90"
                collisionVolumeType = Some "Box"
                damage = Some 120.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 18.0
                object_ = Some "Units/scavboss/leggobt3_dead.s3o"
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
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 4.0
                metal = Some 9.0
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

    let leggobt3ToFlat (def: UnitDef) : Leggobt3 =
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

    let leggobt3ToUnitDef (flat: Leggobt3) : UnitDef =
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

    type Legpede =
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
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legpede : Legpede =
        { name = "legpede"
          subfolder = "Scavengers/Bots"
          metalCost = ValueOrExpr.Concrete 5500.0
          energyCost = ValueOrExpr.Concrete 80000.0
          buildTime = ValueOrExpr.Concrete 110000.0
          health = ValueOrExpr.Concrete 28000.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/LEGPEDE.s3o"
          buildPic = Some "LEGPEDE.DDS"
          script = Some "Units/LEGPEDE.cob"
          corpse = Some "DEAD"
          explodeAs = Some "explosiont3med"
          selfDestructAs = Some "explosiont3"
          collisionVolumeOffsets = Some "0 5 -6"
          collisionVolumeScales = Some "26 28 144"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 51.0
          maxAcc = 0.03
          maxDec = 0.1
          turnRate = 200.0
          movementClass = "HBOT4"
          maxWaterDepth = 12.0
          canMove = true
          turnInPlace = false
          turnInPlaceAngleLimit = 0.0
          turnInPlaceSpeedLimit = 1.3
          weapons = [
                { name = "armmg_weapon"
                  displayName = "Rapid-fire a2g machine guns"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "commanders", 5.0
                      "default", 21.0
                      "vtol", 21.0
                  ]
                  range = Some (ValueOrExpr.Concrete 575.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.4)
                  weaponVelocity = Some 958.0
                  areaOfEffect = Some 16.0
                  accuracy = Some 7.0
                  turret = Some true
                  tolerance = Some 6000.0
                  edgeEffectiveness = Some 0.85
                  impulseFactor = Some 1.5
                  noSelfDamage = Some true
                  soundStart = Some "minigun3"
                  soundHit = Some "bimpact3"
                  explosiongenerator = Some "custom:plasmahit-sparkonly"
                  rgbColor = Some "1 0.95 0.4"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "270.0"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "burst", "6.0"
                      "burstrate", "0.0675"
                      "burnblow", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "0.038"
                      "fallOffRate", "0.2"
                      "firestarter", "0.0"
                      "intensity", "0.8"
                      "ownerExpAccWeight", "4.0"
                      "proximitypriority", "1.0"
                      "soundhitwet", "splshbig"
                      "soundstartvolume", "4.5"
                      "sprayangle", "968.0"
                      "thickness", "0.91"
                  ] }
                { name = "railgunt2"
                  displayName = "Railgun"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "commanders", 250.0
                      "default", 500.0
                  ]
                  range = Some (ValueOrExpr.Concrete 850.0)
                  reloadTime = Some (ValueOrExpr.Concrete 4.5)
                  weaponVelocity = Some 3180.0
                  areaOfEffect = Some 16.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 6000.0
                  edgeEffectiveness = Some 0.85
                  impulseFactor = Some 1.0
                  noSelfDamage = Some true
                  soundStart = Some "heavyrailgun"
                  soundHit = Some "mavgun3"
                  explosiongenerator = Some "custom:plasmahit-sparkonly"
                  rgbColor = Some "0.74 0.64 0.94"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "cegtag", "railgun"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "0.12"
                      "energypershot", "400.0"
                      "firestarter", "0.0"
                      "hardstop", "true"
                      "impactonly", "true"
                      "intensity", "0.8"
                      "noexplode", "true"
                      "ownerExpAccWeight", "4.0"
                      "proximitypriority", "1.0"
                      "soundhitwet", "splshbig"
                      "soundstartvolume", "26.0"
                      "thickness", "3.0"
                  ] }
                { name = "adv_rocket"
                  displayName = "Parabolic trajectory g2g multi-rocket launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "default", 200.0
                      "subs", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 600.0)
                  reloadTime = Some (ValueOrExpr.Concrete 3.75)
                  weaponVelocity = Some 450.0
                  areaOfEffect = Some 90.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.65
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "rocksalvo"
                  soundHit = Some "rockhit3"
                  explosiongenerator = Some "custom:genericshellexplosion-small-bomb"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "burst", "3.0"
                      "burstrate", "0.3"
                      "cegtag", "missiletrailsmall-simple"
                      "collidefriendly", "false"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "70.0"
                      "flighttime", "3.0"
                      "model", "cormissile2.s3o"
                      "smoketrail", "true"
                      "smokePeriod", "7.0"
                      "smoketime", "21.0"
                      "smokesize", "6.5"
                      "smokecolor", "0.5"
                      "smokeTrailCastShadow", "false"
                      "castshadow", "true"
                      "soundhitwet", "splssml"
                      "soundtrigger", "true"
                      "startvelocity", "80.0"
                      "targetmoveerror", "0.2"
                      "texture1", "null"
                      "texture2", "smoketrailbar"
                      "trajectoryheight", "1.0"
                      "turnrate", "2000.0"
                      "weaponacceleration", "70.0"
                      "weapontimer", "6.0"
                      "wobble", "2500.0"
                  ] }
                { name = "adv_rocket"
                  displayName = "Parabolic trajectory g2g multi-rocket launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "default", 200.0
                      "subs", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 600.0)
                  reloadTime = Some (ValueOrExpr.Concrete 3.75)
                  weaponVelocity = Some 450.0
                  areaOfEffect = Some 90.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.65
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "rocksalvo"
                  soundHit = Some "rockhit3"
                  explosiongenerator = Some "custom:genericshellexplosion-small-bomb"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "burst", "3.0"
                      "burstrate", "0.3"
                      "cegtag", "missiletrailsmall-simple"
                      "collidefriendly", "false"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "70.0"
                      "flighttime", "3.0"
                      "model", "cormissile2.s3o"
                      "smoketrail", "true"
                      "smokePeriod", "7.0"
                      "smoketime", "21.0"
                      "smokesize", "6.5"
                      "smokecolor", "0.5"
                      "smokeTrailCastShadow", "false"
                      "castshadow", "true"
                      "soundhitwet", "splssml"
                      "soundtrigger", "true"
                      "startvelocity", "80.0"
                      "targetmoveerror", "0.2"
                      "texture1", "null"
                      "texture2", "smoketrailbar"
                      "trajectoryheight", "1.0"
                      "turnrate", "2000.0"
                      "weaponacceleration", "70.0"
                      "weapontimer", "6.0"
                      "wobble", "2500.0"
                  ] }
                { name = "railgunt2"
                  displayName = "Railgun"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "commanders", 250.0
                      "default", 500.0
                  ]
                  range = Some (ValueOrExpr.Concrete 850.0)
                  reloadTime = Some (ValueOrExpr.Concrete 4.5)
                  weaponVelocity = Some 3180.0
                  areaOfEffect = Some 16.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 6000.0
                  edgeEffectiveness = Some 0.85
                  impulseFactor = Some 1.0
                  noSelfDamage = Some true
                  soundStart = Some "heavyrailgun"
                  soundHit = Some "mavgun3"
                  explosiongenerator = Some "custom:plasmahit-sparkonly"
                  rgbColor = Some "0.74 0.64 0.94"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "cegtag", "railgun"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "0.12"
                      "energypershot", "400.0"
                      "firestarter", "0.0"
                      "hardstop", "true"
                      "impactonly", "true"
                      "intensity", "0.8"
                      "noexplode", "true"
                      "ownerExpAccWeight", "4.0"
                      "proximitypriority", "1.0"
                      "soundhitwet", "splshbig"
                      "soundstartvolume", "26.0"
                      "thickness", "3.0"
                  ] }
                { name = "armmg_weapon"
                  displayName = "Rapid-fire a2g machine guns"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "commanders", 5.0
                      "default", 21.0
                      "vtol", 21.0
                  ]
                  range = Some (ValueOrExpr.Concrete 575.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.4)
                  weaponVelocity = Some 958.0
                  areaOfEffect = Some 16.0
                  accuracy = Some 7.0
                  turret = Some true
                  tolerance = Some 6000.0
                  edgeEffectiveness = Some 0.85
                  impulseFactor = Some 1.5
                  noSelfDamage = Some true
                  soundStart = Some "minigun3"
                  soundHit = Some "bimpact3"
                  explosiongenerator = Some "custom:plasmahit-sparkonly"
                  rgbColor = Some "1 0.95 0.4"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_maindir", "0 0 -1"
                      "mount_maxangledif", "270.0"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "burst", "6.0"
                      "burstrate", "0.0675"
                      "burnblow", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "0.038"
                      "fallOffRate", "0.2"
                      "firestarter", "0.0"
                      "intensity", "0.8"
                      "ownerExpAccWeight", "4.0"
                      "proximitypriority", "1.0"
                      "soundhitwet", "splshbig"
                      "soundstartvolume", "4.5"
                      "sprayangle", "968.0"
                      "thickness", "0.91"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.13973236084 -4.67773437585e-06 -1.37111663818"
                  collisionVolumeScales = Some "47.3038787842 18.2459106445 47.0814971924"
                  collisionVolumeType = Some "Box"
                  damage = Some 10000.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 40.0
                  metal = Some 3600.0
                  object_ = Some "Units/legpede_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 5000.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 1800.0
                  object_ = Some "Units/arm4X4A.s3o"
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
                ok = ["spider2"]
                select = ["spider3"] }
          customParams = Map.ofList [
                "unitgroup", "weapon"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBots/T2"
                "techlevel", "3.0"
            ]
          extras = Map.ofList [
                "canattack", "false"
                "mass", "200000.0"
                "mygravity", "10000.0"
                "nochasecategory", "VTOL"
                "usepiececollisionvolumes", "1.0"
            ] }

    let legpedeDef : UnitDef =
        { name = "legpede"
          subfolder = "Scavengers/Bots"
          metalCost = ValueOrExpr.Concrete 5500.0
          energyCost = ValueOrExpr.Concrete 80000.0
          buildTime = ValueOrExpr.Concrete 110000.0
          health = ValueOrExpr.Concrete 28000.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/LEGPEDE.s3o"
          buildPic = Some "LEGPEDE.DDS"
          script = Some "Units/LEGPEDE.cob"
          corpse = Some "DEAD"
          explodeAs = Some "explosiont3med"
          selfDestructAs = Some "explosiont3"
          collisionVolumeOffsets = Some "0 5 -6"
          collisionVolumeScales = Some "26 28 144"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 51.0
              maxAcc = 0.03
              maxDec = 0.1
              turnRate = 200.0
              movementClass = Some "HBOT4"
              maxSlope = None
              maxWaterDepth = Some 12.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some false
              turnInPlaceAngleLimit = Some 0.0
              turnInPlaceSpeedLimit = Some 1.3
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "armmg_weapon"
                displayName = "Rapid-fire a2g machine guns"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "commanders", 5.0
                    "default", 21.0
                    "vtol", 21.0
                ]
                range = Some (ValueOrExpr.Concrete 575.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.4)
                weaponVelocity = Some 958.0
                areaOfEffect = Some 16.0
                accuracy = Some 7.0
                turret = Some true
                tolerance = Some 6000.0
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 1.5
                noSelfDamage = Some true
                soundStart = Some "minigun3"
                soundHit = Some "bimpact3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "1 0.95 0.4"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "270.0"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "burst", "6.0"
                    "burstrate", "0.0675"
                    "burnblow", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.038"
                    "fallOffRate", "0.2"
                    "firestarter", "0.0"
                    "intensity", "0.8"
                    "ownerExpAccWeight", "4.0"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "4.5"
                    "sprayangle", "968.0"
                    "thickness", "0.91"
                ] }
              { name = "railgunt2"
                displayName = "Railgun"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "commanders", 250.0
                    "default", 500.0
                ]
                range = Some (ValueOrExpr.Concrete 850.0)
                reloadTime = Some (ValueOrExpr.Concrete 4.5)
                weaponVelocity = Some 3180.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = Some 6000.0
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 1.0
                noSelfDamage = Some true
                soundStart = Some "heavyrailgun"
                soundHit = Some "mavgun3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "0.74 0.64 0.94"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "cegtag", "railgun"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.12"
                    "energypershot", "400.0"
                    "firestarter", "0.0"
                    "hardstop", "true"
                    "impactonly", "true"
                    "intensity", "0.8"
                    "noexplode", "true"
                    "ownerExpAccWeight", "4.0"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "26.0"
                    "thickness", "3.0"
                ] }
              { name = "adv_rocket"
                displayName = "Parabolic trajectory g2g multi-rocket launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 200.0
                    "subs", 100.0
                ]
                range = Some (ValueOrExpr.Concrete 600.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.75)
                weaponVelocity = Some 450.0
                areaOfEffect = Some 90.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.65
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "rocksalvo"
                soundHit = Some "rockhit3"
                explosiongenerator = Some "custom:genericshellexplosion-small-bomb"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "burst", "3.0"
                    "burstrate", "0.3"
                    "cegtag", "missiletrailsmall-simple"
                    "collidefriendly", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "70.0"
                    "flighttime", "3.0"
                    "model", "cormissile2.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "7.0"
                    "smoketime", "21.0"
                    "smokesize", "6.5"
                    "smokecolor", "0.5"
                    "smokeTrailCastShadow", "false"
                    "castshadow", "true"
                    "soundhitwet", "splssml"
                    "soundtrigger", "true"
                    "startvelocity", "80.0"
                    "targetmoveerror", "0.2"
                    "texture1", "null"
                    "texture2", "smoketrailbar"
                    "trajectoryheight", "1.0"
                    "turnrate", "2000.0"
                    "weaponacceleration", "70.0"
                    "weapontimer", "6.0"
                    "wobble", "2500.0"
                ] }
              { name = "adv_rocket"
                displayName = "Parabolic trajectory g2g multi-rocket launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 200.0
                    "subs", 100.0
                ]
                range = Some (ValueOrExpr.Concrete 600.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.75)
                weaponVelocity = Some 450.0
                areaOfEffect = Some 90.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.65
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "rocksalvo"
                soundHit = Some "rockhit3"
                explosiongenerator = Some "custom:genericshellexplosion-small-bomb"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "burst", "3.0"
                    "burstrate", "0.3"
                    "cegtag", "missiletrailsmall-simple"
                    "collidefriendly", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "70.0"
                    "flighttime", "3.0"
                    "model", "cormissile2.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "7.0"
                    "smoketime", "21.0"
                    "smokesize", "6.5"
                    "smokecolor", "0.5"
                    "smokeTrailCastShadow", "false"
                    "castshadow", "true"
                    "soundhitwet", "splssml"
                    "soundtrigger", "true"
                    "startvelocity", "80.0"
                    "targetmoveerror", "0.2"
                    "texture1", "null"
                    "texture2", "smoketrailbar"
                    "trajectoryheight", "1.0"
                    "turnrate", "2000.0"
                    "weaponacceleration", "70.0"
                    "weapontimer", "6.0"
                    "wobble", "2500.0"
                ] }
              { name = "railgunt2"
                displayName = "Railgun"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "commanders", 250.0
                    "default", 500.0
                ]
                range = Some (ValueOrExpr.Concrete 850.0)
                reloadTime = Some (ValueOrExpr.Concrete 4.5)
                weaponVelocity = Some 3180.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = Some 6000.0
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 1.0
                noSelfDamage = Some true
                soundStart = Some "heavyrailgun"
                soundHit = Some "mavgun3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "0.74 0.64 0.94"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "cegtag", "railgun"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.12"
                    "energypershot", "400.0"
                    "firestarter", "0.0"
                    "hardstop", "true"
                    "impactonly", "true"
                    "intensity", "0.8"
                    "noexplode", "true"
                    "ownerExpAccWeight", "4.0"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "26.0"
                    "thickness", "3.0"
                ] }
              { name = "armmg_weapon"
                displayName = "Rapid-fire a2g machine guns"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "commanders", 5.0
                    "default", 21.0
                    "vtol", 21.0
                ]
                range = Some (ValueOrExpr.Concrete 575.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.4)
                weaponVelocity = Some 958.0
                areaOfEffect = Some 16.0
                accuracy = Some 7.0
                turret = Some true
                tolerance = Some 6000.0
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 1.5
                noSelfDamage = Some true
                soundStart = Some "minigun3"
                soundHit = Some "bimpact3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "1 0.95 0.4"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_maindir", "0 0 -1"
                    "mount_maxangledif", "270.0"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "burst", "6.0"
                    "burstrate", "0.0675"
                    "burnblow", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.038"
                    "fallOffRate", "0.2"
                    "firestarter", "0.0"
                    "intensity", "0.8"
                    "ownerExpAccWeight", "4.0"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "4.5"
                    "sprayangle", "968.0"
                    "thickness", "0.91"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.13973236084 -4.67773437585e-06 -1.37111663818"
                collisionVolumeScales = Some "47.3038787842 18.2459106445 47.0814971924"
                collisionVolumeType = Some "Box"
                damage = Some 10000.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 40.0
                metal = Some 3600.0
                object_ = Some "Units/legpede_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 5000.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 1800.0
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
              ok = ["spider2"]
              select = ["spider3"] })
          customParams = Map.ofList [
              "unitgroup", "weapon"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmBots/T2"
              "techlevel", "3.0"
          ]
          extras = Map.ofList [
              "canattack", "false"
              "mass", "200000.0"
              "mygravity", "10000.0"
              "nochasecategory", "VTOL"
              "usepiececollisionvolumes", "1.0"
          ] }

    let legpedeToFlat (def: UnitDef) : Legpede =
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
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let legpedeToUnitDef (flat: Legpede) : UnitDef =
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
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Legsrailt4 =
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

    let legsrailt4 : Legsrailt4 =
        { name = "legsrailt4"
          subfolder = "Scavengers/Bots"
          metalCost = ValueOrExpr.Concrete 15000.0
          energyCost = ValueOrExpr.Concrete 300000.0
          buildTime = ValueOrExpr.Concrete 300000.0
          health = ValueOrExpr.Concrete 40000.0
          sightDistance = ValueOrExpr.Concrete 1200.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/scavboss/LEGSRAILT4.s3o"
          buildPic = Some "LEGSRAIL.DDS"
          script = Some "Units/scavboss/LEGSRAILT4.cob"
          corpse = Some "DEAD"
          explodeAs = Some "explosiont3"
          selfDestructAs = Some "explosiont3xl"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "99 88 99"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 21.0
          maxAcc = 0.04
          maxDec = 0.15
          turnRate = 100.0
          movementClass = "EPICALLTERRAIN"
          maxSlope = 17.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.0
          weapons = [
                { name = "railgunt2"
                  displayName = "Railgun"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "commanders", 1000.0
                      "default", 6000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1600.0)
                  reloadTime = Some (ValueOrExpr.Concrete 4.0)
                  weaponVelocity = Some 3180.0
                  areaOfEffect = Some 16.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 6000.0
                  edgeEffectiveness = Some 0.85
                  impulseFactor = Some 1.0
                  noSelfDamage = Some true
                  soundStart = Some "railgunxl"
                  soundHit = Some "mavgun3"
                  explosiongenerator = Some "custom:starfire-explosion"
                  rgbColor = Some "0.74 0.64 0.94"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "cegtag", "ministarfire"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "0.02"
                      "energypershot", "3000.0"
                      "fallOffRate", "0.2"
                      "firestarter", "0.0"
                      "hardstop", "true"
                      "impactonly", "true"
                      "intensity", "0.8"
                      "noexplode", "true"
                      "ownerExpAccWeight", "4.0"
                      "proximitypriority", "1.0"
                      "soundhitwet", "splshbig"
                      "soundstartvolume", "50.0"
                      "stockpile", "true"
                      "stockpiletime", "12.0"
                      "thickness", "4.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-3.37104034424 -1.05229058838 1.8899307251"
                  collisionVolumeScales = Some "83 55 73"
                  collisionVolumeType = Some "Box"
                  damage = Some 3000.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 40.0
                  metal = Some 7500.0
                  object_ = Some "Units/scavboss/legsrailt4_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 3015.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 3750.0
                  object_ = Some "Units/arm3X3D.s3o"
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
                "unitgroup", "weapon"
                "model_author", "Tharsis"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/gantry"
                "techlevel", "3.0"
            ]
          extras = Map.ofList [
                "mygravity", "10000.0"
                "nochasecategory", "VTOL"
                "usepiececollisionvolumes", "0.0"
            ] }

    let legsrailt4Def : UnitDef =
        { name = "legsrailt4"
          subfolder = "Scavengers/Bots"
          metalCost = ValueOrExpr.Concrete 15000.0
          energyCost = ValueOrExpr.Concrete 300000.0
          buildTime = ValueOrExpr.Concrete 300000.0
          health = ValueOrExpr.Concrete 40000.0
          sightDistance = ValueOrExpr.Concrete 1200.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/scavboss/LEGSRAILT4.s3o"
          buildPic = Some "LEGSRAIL.DDS"
          script = Some "Units/scavboss/LEGSRAILT4.cob"
          corpse = Some "DEAD"
          explodeAs = Some "explosiont3"
          selfDestructAs = Some "explosiont3xl"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "99 88 99"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 21.0
              maxAcc = 0.04
              maxDec = 0.15
              turnRate = 100.0
              movementClass = Some "EPICALLTERRAIN"
              maxSlope = Some 17.0
              maxWaterDepth = Some 0.0
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
              { name = "railgunt2"
                displayName = "Railgun"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "commanders", 1000.0
                    "default", 6000.0
                ]
                range = Some (ValueOrExpr.Concrete 1600.0)
                reloadTime = Some (ValueOrExpr.Concrete 4.0)
                weaponVelocity = Some 3180.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = Some 6000.0
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 1.0
                noSelfDamage = Some true
                soundStart = Some "railgunxl"
                soundHit = Some "mavgun3"
                explosiongenerator = Some "custom:starfire-explosion"
                rgbColor = Some "0.74 0.64 0.94"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "cegtag", "ministarfire"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.02"
                    "energypershot", "3000.0"
                    "fallOffRate", "0.2"
                    "firestarter", "0.0"
                    "hardstop", "true"
                    "impactonly", "true"
                    "intensity", "0.8"
                    "noexplode", "true"
                    "ownerExpAccWeight", "4.0"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "50.0"
                    "stockpile", "true"
                    "stockpiletime", "12.0"
                    "thickness", "4.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "-3.37104034424 -1.05229058838 1.8899307251"
                collisionVolumeScales = Some "83 55 73"
                collisionVolumeType = Some "Box"
                damage = Some 3000.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 40.0
                metal = Some 7500.0
                object_ = Some "Units/scavboss/legsrailt4_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 3015.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 3750.0
                object_ = Some "Units/arm3X3D.s3o"
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
              "subfolder", "Legion/gantry"
              "techlevel", "3.0"
          ]
          extras = Map.ofList [
              "mygravity", "10000.0"
              "nochasecategory", "VTOL"
              "usepiececollisionvolumes", "0.0"
          ] }

    let legsrailt4ToFlat (def: UnitDef) : Legsrailt4 =
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

    let legsrailt4ToUnitDef (flat: Legsrailt4) : UnitDef =
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

