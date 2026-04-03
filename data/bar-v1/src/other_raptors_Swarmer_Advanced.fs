// Auto-generated BAR unit data: other/raptors/Swarmer/Advanced
namespace BarData.V1.Units

open BarData.V1

module other_raptors_Swarmer_Advanced =

    let raptor_land_swarmer_basic_t4_v1 : UnitDef =
        { name = "raptor_land_swarmer_basic_t4_v1"
          subfolder = "other/raptors/Swarmer/Advanced"
          metalCost = ValueOrExpr.Concrete 100.0
          energyCost = ValueOrExpr.Concrete 1000.0
          buildTime = ValueOrExpr.Concrete 7500.0
          health = ValueOrExpr.Concrete 1500.0
          sightDistance = ValueOrExpr.Concrete 200.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Raptors/raptor2.s3o"
          buildPic = Some "raptors/raptor2.DDS"
          script = Some "Raptors/raptor2.cob"
          corpse = None
          explodeAs = Some "BUG_DEATH"
          selfDestructAs = Some "BUG_DEATH"
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "20 40 44"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 180.0
              maxAcc = 0.4025
              maxDec = 0.345
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
              waterline = Some 22.0 })
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = Some "Claws"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 300.0
                ]
                range = Some (ValueOrExpr.Concrete 200.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.7)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 24.0
                accuracy = None
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.3
                impulseFactor = Some 1.0
                noSelfDamage = Some true
                soundStart = Some "smallraptorattack"
                soundHit = None
                explosiongenerator = Some "custom:raptorspike-medium-sparks-burn"
                rgbColor = None
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
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firesubmersed", "true"
                    "interceptedbyshieldtype", "0.0"
                    "model", "Raptors/spike.s3o"
                    "waterweapon", "true"
                    "weapontimer", "0.1"
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
              "normaltex", "unittextures/chicken_m_normals.png"
              "treeshader", "yes"
          ]
          extras = Map.ofList [
              "canattack", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canstop", "1"
              "capturable", "false"
              "defaultmissiontype", "Standby"
              "leavetracks", "true"
              "maneuverleashlength", "640.0"
              "mass", "200.0"
              "noautofire", "false"
              "nochasecategory", "VTOL"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "trackoffset", "0.0"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrack"
              "trackwidth", "18.0"
              "unitname", "raptor_land_swarmer_basic_t4_v1"
              "upright", "false"
          ] }

    let raptor_land_swarmer_basic_t4_v2 : UnitDef =
        { name = "raptor_land_swarmer_basic_t4_v2"
          subfolder = "other/raptors/Swarmer/Advanced"
          metalCost = ValueOrExpr.Concrete 150.0
          energyCost = ValueOrExpr.Concrete 1000.0
          buildTime = ValueOrExpr.Concrete 10500.0
          health = ValueOrExpr.Concrete 2000.0
          sightDistance = ValueOrExpr.Concrete 200.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Raptors/raptor2b.s3o"
          buildPic = Some "raptors/raptor2b.DDS"
          script = Some "Raptors/raptor2b.cob"
          corpse = None
          explodeAs = Some "BUG_DEATH"
          selfDestructAs = Some "BUG_DEATH"
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "25 40 70"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 180.0
              maxAcc = 0.805
              maxDec = 5.75
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
              waterline = Some 22.0 })
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = Some "Claws"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 300.0
                ]
                range = Some (ValueOrExpr.Concrete 200.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.5)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 32.0
                accuracy = None
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.3
                impulseFactor = Some 1.0
                noSelfDamage = Some true
                soundStart = Some "smallraptorattack"
                soundHit = None
                explosiongenerator = Some "custom:raptorspike-medium-sparks-burn"
                rgbColor = None
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
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firesubmersed", "true"
                    "interceptedbyshieldtype", "0.0"
                    "model", "Raptors/spike.s3o"
                    "waterweapon", "true"
                    "weapontimer", "0.1"
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
              "normaltex", "unittextures/chicken_m_normals.png"
          ]
          extras = Map.ofList [
              "autoheal", "20.0"
              "canattack", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canstop", "1"
              "capturable", "false"
              "defaultmissiontype", "Standby"
              "leavetracks", "true"
              "maneuverleashlength", "640.0"
              "mass", "1200.0"
              "noautofire", "false"
              "nochasecategory", "VTOL"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "trackoffset", "0.0"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrack"
              "trackwidth", "18.0"
              "unitname", "raptor_land_swarmer_basic_t4_v2"
              "upright", "false"
          ] }

    let all : (string * UnitDef) list =
        [
            "raptor_land_swarmer_basic_t4_v1", raptor_land_swarmer_basic_t4_v1
            "raptor_land_swarmer_basic_t4_v2", raptor_land_swarmer_basic_t4_v2
        ]
