// Auto-generated BAR unit data: other/raptors/Overseer
namespace BarData.Units

open BarData

module other_raptors_Overseer =

    let raptorh5 : UnitDef =
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
                displayName = Some "Claws"
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
                onlyTargetCategory = None
                badTargetCategory = None
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
                displayName = Some "ControlBlob"
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
                onlyTargetCategory = None
                badTargetCategory = None
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

    let all : (string * UnitDef) list =
        [
            "raptorh5", raptorh5
        ]
