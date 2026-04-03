// Auto-generated BAR unit data: other/raptors/Overseer (unified)
namespace BarData.Units

open BarData

module other_raptors_Overseer =

    type Raptorh5 =
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
          waterline: float
          weapons: WeaponDef list
          customParams: Map<string, string>
          extras: Map<string, string> }

    let raptorh5 : Raptorh5 =
        { name = "raptorh5"
          subfolder = "other/raptors/Overseer"
          metalCost = ValueOrExpr.Concrete 251.0
          energyCost = ValueOrExpr.Concrete 5201.0
          buildTime = ValueOrExpr.Concrete 18000.0
          health = ValueOrExpr.Concrete 8900.0
          sightDistance = ValueOrExpr.Concrete 1500.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Raptors/brain_bug.s3o"
          buildPic = Some "raptors/raptorh5.DDS"
          script = Some "Raptors/raptorh5.cob"
          corpse = None
          explodeAs = Some "ROOST_DEATH"
          selfDestructAs = Some "ROOST_DEATH"
          collisionVolumeOffsets = Some "0 -10 2"
          collisionVolumeScales = Some "37 75 90"
          collisionVolumeType = Some "box"
          seismicSignature = None
          category = Some "RAPTOR"
          speed = ValueOrExpr.Concrete 111.0
          maxAcc = 0.92
          maxDec = 0.92
          turnRate = 1840.0
          movementClass = "RAPTORSMALLHOVER"
          maxSlope = 18.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 45.0
          weapons = [
                { name = "weapon"
                  displayName = "Claws"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "raptor", 1.0
                      "default", 1.0
                  ]
                  range = Some (ValueOrExpr.Concrete 200.0)
                  reloadTime = Some (ValueOrExpr.Concrete 3.0)
                  weaponVelocity = Some 500.0
                  areaOfEffect = Some 72.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.3
                  impulseFactor = Some 1.0
                  noSelfDamage = Some true
                  soundStart = Some "smallraptorattack"
                  soundHit = None
                  explosiongenerator = Some "custom:raptorspike-large-sparks-burn"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "180.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "interceptedbyshieldtype", "0.0"
                      "model", "Raptors/spike.s3o"
                      "waterweapon", "true"
                      "weapontimer", "0.1"
                  ] }
                { name = "controlblob"
                  displayName = "ControlBlob"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 1.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1000.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.5)
                  weaponVelocity = Some 10000.0
                  areaOfEffect = Some 120.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.55
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = None
                  soundHit = None
                  explosiongenerator = None
                  rgbColor = Some "0.42 0.07 0.07"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "180.0"
                      "collidefriendly", "0.0"
                      "collidefeature", "0.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "camerashake", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "intensity", "0.85"
                      "interceptedbyshieldtype", "0.0"
                      "predictboost", "1.0"
                      "proximitypriority", "-1.0"
                      "size", "0.0"
                      "sizeDecay", "0.0"
                      "stages", "0.0"
                  ] }
            ]
          customParams = Map.ofList [
                "subfolder", "other/raptors"
                "model_author", "KDR_11k, Beherith"
                "normalmaps", "yes"
                "normaltex", "unittextures/chicken_l_normals.png"
            ]
          extras = Map.ofList [
                "autoheal", "8.0"
                "canattack", "true"
                "canguard", "true"
                "canpatrol", "true"
                "canrepair", "false"
                "canreclaim", "false"
                "canrestore", "false"
                "canstop", "1"
                "capturable", "false"
                "defaultmissiontype", "Standby"
                "hidedamage", "1.0"
                "leavetracks", "true"
                "maneuverleashlength", "640.0"
                "mass", "3000.0"
                "nanocolor", "0.7 0.15 0.15"
                "noautofire", "false"
                "nochasecategory", "VTOL"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "trackoffset", "10.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrack"
                "trackwidth", "35.0"
                "unitname", "raptorh5"
                "upright", "false"
            ] }

    let raptorh5Def : UnitDef =
        { name = "raptorh5"
          subfolder = "other/raptors/Overseer"
          metalCost = ValueOrExpr.Concrete 251.0
          energyCost = ValueOrExpr.Concrete 5201.0
          buildTime = ValueOrExpr.Concrete 18000.0
          health = ValueOrExpr.Concrete 8900.0
          sightDistance = ValueOrExpr.Concrete 1500.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Raptors/brain_bug.s3o"
          buildPic = Some "raptors/raptorh5.DDS"
          script = Some "Raptors/raptorh5.cob"
          corpse = None
          explodeAs = Some "ROOST_DEATH"
          selfDestructAs = Some "ROOST_DEATH"
          collisionVolumeOffsets = Some "0 -10 2"
          collisionVolumeScales = Some "37 75 90"
          collisionVolumeType = Some "box"
          seismicSignature = None
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 111.0
              maxAcc = 0.92
              maxDec = 0.92
              turnRate = 1840.0
              movementClass = Some "RAPTORSMALLHOVER"
              maxSlope = Some 18.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 45.0 })
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = "Claws"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "raptor", 1.0
                    "default", 1.0
                ]
                range = Some (ValueOrExpr.Concrete 200.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.0)
                weaponVelocity = Some 500.0
                areaOfEffect = Some 72.0
                accuracy = None
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.3
                impulseFactor = Some 1.0
                noSelfDamage = Some true
                soundStart = Some "smallraptorattack"
                soundHit = None
                explosiongenerator = Some "custom:raptorspike-large-sparks-burn"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "180.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "interceptedbyshieldtype", "0.0"
                    "model", "Raptors/spike.s3o"
                    "waterweapon", "true"
                    "weapontimer", "0.1"
                ] }
              { name = "controlblob"
                displayName = "ControlBlob"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 1.0
                ]
                range = Some (ValueOrExpr.Concrete 1000.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.5)
                weaponVelocity = Some 10000.0
                areaOfEffect = Some 120.0
                accuracy = None
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.55
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = None
                soundHit = None
                explosiongenerator = None
                rgbColor = Some "0.42 0.07 0.07"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "180.0"
                    "collidefriendly", "0.0"
                    "collidefeature", "0.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "camerashake", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "intensity", "0.85"
                    "interceptedbyshieldtype", "0.0"
                    "predictboost", "1.0"
                    "proximitypriority", "-1.0"
                    "size", "0.0"
                    "sizeDecay", "0.0"
                    "stages", "0.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_l_normals.png"
          ]
          extras = Map.ofList [
              "autoheal", "8.0"
              "canattack", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canrepair", "false"
              "canreclaim", "false"
              "canrestore", "false"
              "canstop", "1"
              "capturable", "false"
              "defaultmissiontype", "Standby"
              "hidedamage", "1.0"
              "leavetracks", "true"
              "maneuverleashlength", "640.0"
              "mass", "3000.0"
              "nanocolor", "0.7 0.15 0.15"
              "noautofire", "false"
              "nochasecategory", "VTOL"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "trackoffset", "10.0"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrack"
              "trackwidth", "35.0"
              "unitname", "raptorh5"
              "upright", "false"
          ] }

    let raptorh5ToFlat (def: UnitDef) : Raptorh5 =
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
          waterline = def.movement.Value.waterline.Value
          weapons = def.weapons.Value
          customParams = def.customParams
          extras = def.extras }

    let raptorh5ToUnitDef (flat: Raptorh5) : UnitDef =
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
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some flat.waterline
            }
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

