// Auto-generated BAR unit data: other/raptors/Swarmer/AllTerrain
namespace BarData.V1.Units

open BarData.V1

module other_raptors_Swarmer_AllTerrain =

    let raptor_6legged_l : UnitDef =
        { name = "raptor_6legged_l"
          subfolder = "other/raptors/Swarmer/AllTerrain"
          metalCost = ValueOrExpr.Concrete 99.0
          energyCost = ValueOrExpr.Concrete 5280.0
          buildTime = ValueOrExpr.Concrete 1875.0
          health = ValueOrExpr.Concrete 2650.0
          sightDistance = ValueOrExpr.Concrete 200.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Raptors/raptor_6legged_l.s3o"
          buildPic = Some "raptors/raptorc3c.DDS"
          script = Some "Raptors/raptor_6legged_l.cob"
          corpse = None
          explodeAs = Some "BUG_DEATH"
          selfDestructAs = Some "BIGBUG_DEATH"
          collisionVolumeOffsets = Some "0 -3 -3"
          collisionVolumeScales = Some "18 28 40"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 63.0
              maxAcc = 1.4375
              maxDec = 2.3
              turnRate = 1840.0
              movementClass = Some "RAPTORALLTERRAINHOVER"
              maxSlope = Some 18.0
              maxWaterDepth = Some 15.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 16.0 })
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = Some "Claws"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 700.0
                ]
                range = Some (ValueOrExpr.Concrete 200.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
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
                explosiongenerator = Some "custom:raptorspike-small-sparks-burn"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "110.0"
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
              "model_author", "Kremenchuk, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_l_normals.png"
          ]
          extras = Map.ofList [
              "canattack", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canstop", "1"
              "capturable", "false"
              "defaultmissiontype", "Standby"
              "leavetracks", "true"
              "maneuverleashlength", "640"
              "mass", "89.0"
              "maxreversevelocity", "3.0"
              "noautofire", "false"
              "nochasecategory", "VTOL"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "sonardistance", "450.0"
              "trackoffset", "0.5"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrackPointy"
              "trackwidth", "35.0"
              "unitname", "raptor_6legged_l"
              "upright", "false"
          ] }

    let raptor_allterrain_swarmer_basic_t2_v1 : UnitDef =
        { name = "raptor_allterrain_swarmer_basic_t2_v1"
          subfolder = "other/raptors/Swarmer/AllTerrain"
          metalCost = ValueOrExpr.Concrete 99.0
          energyCost = ValueOrExpr.Concrete 5280.0
          buildTime = ValueOrExpr.Concrete 2250.0
          health = ValueOrExpr.Concrete 890.0
          sightDistance = ValueOrExpr.Concrete 200.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Raptors/raptorc3.s3o"
          buildPic = Some "raptors/raptorc3.DDS"
          script = Some "Raptors/raptorc3.cob"
          corpse = None
          explodeAs = Some "BUG_DEATH"
          selfDestructAs = Some "BIGBUG_DEATH"
          collisionVolumeOffsets = Some "0 -3 -3"
          collisionVolumeScales = Some "18 28 40"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 97.5
              maxAcc = 1.4375
              maxDec = 2.3
              turnRate = 1840.0
              movementClass = Some "RAPTORALLTERRAINHOVER"
              maxSlope = Some 18.0
              maxWaterDepth = Some 15.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 10.0 })
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = Some "Claws"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 150.0
                ]
                range = Some (ValueOrExpr.Concrete 200.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
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
                explosiongenerator = Some "custom:raptorspike-small-sparks-burn"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "110.0"
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
              "normaltex", "unittextures/chicken_s_normals.png"
          ]
          extras = Map.ofList [
              "canattack", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canstop", "1"
              "capturable", "false"
              "defaultmissiontype", "Standby"
              "leavetracks", "true"
              "maneuverleashlength", "640"
              "mass", "89.0"
              "maxreversevelocity", "3.0"
              "noautofire", "false"
              "nochasecategory", "VTOL"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "sonardistance", "450.0"
              "trackoffset", "0.5"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrackPointy"
              "trackwidth", "35.0"
              "unitname", "raptor_allterrain_swarmer_basic_t2_v1"
              "upright", "false"
          ] }

    let raptor_allterrain_swarmer_basic_t3_v1 : UnitDef =
        { name = "raptor_allterrain_swarmer_basic_t3_v1"
          subfolder = "other/raptors/Swarmer/AllTerrain"
          metalCost = ValueOrExpr.Concrete 99.0
          energyCost = ValueOrExpr.Concrete 5280.0
          buildTime = ValueOrExpr.Concrete 2625.0
          health = ValueOrExpr.Concrete 1780.0
          sightDistance = ValueOrExpr.Concrete 200.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Raptors/raptorc3b.s3o"
          buildPic = Some "raptors/raptorc3b.DDS"
          script = Some "Raptors/raptorc3b.cob"
          corpse = None
          explodeAs = Some "BUG_DEATH"
          selfDestructAs = Some "BIGBUG_DEATH"
          collisionVolumeOffsets = Some "0 -3 -3"
          collisionVolumeScales = Some "18 28 40"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 105.0
              maxAcc = 1.4375
              maxDec = 2.3
              turnRate = 1840.0
              movementClass = Some "RAPTORALLTERRAINHOVER"
              maxSlope = Some 18.0
              maxWaterDepth = Some 15.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 13.0 })
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = Some "Claws"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 250.0
                ]
                range = Some (ValueOrExpr.Concrete 200.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
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
                explosiongenerator = Some "custom:raptorspike-small-sparks-burn"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "110.0"
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
              "normaltex", "unittextures/chicken_s_normals.png"
          ]
          extras = Map.ofList [
              "canattack", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canstop", "1"
              "capturable", "false"
              "defaultmissiontype", "Standby"
              "leavetracks", "true"
              "maneuverleashlength", "640"
              "mass", "89.0"
              "maxreversevelocity", "3.0"
              "noautofire", "false"
              "nochasecategory", "VTOL"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "sonardistance", "450.0"
              "trackoffset", "0.5"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrackPointy"
              "trackwidth", "35.0"
              "unitname", "raptor_allterrain_swarmer_basic_t3_v1"
              "upright", "false"
          ] }

    let raptor_allterrain_swarmer_basic_t4_v1 : UnitDef =
        { name = "raptor_allterrain_swarmer_basic_t4_v1"
          subfolder = "other/raptors/Swarmer/AllTerrain"
          metalCost = ValueOrExpr.Concrete 99.0
          energyCost = ValueOrExpr.Concrete 5280.0
          buildTime = ValueOrExpr.Concrete 1875.0
          health = ValueOrExpr.Concrete 2650.0
          sightDistance = ValueOrExpr.Concrete 200.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Raptors/raptorc3c.s3o"
          buildPic = Some "raptors/raptorc3c.DDS"
          script = Some "Raptors/raptorc3c.cob"
          corpse = None
          explodeAs = Some "BUG_DEATH"
          selfDestructAs = Some "BIGBUG_DEATH"
          collisionVolumeOffsets = Some "0 -3 -3"
          collisionVolumeScales = Some "18 28 40"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 96.0
              maxAcc = 1.4375
              maxDec = 2.3
              turnRate = 1840.0
              movementClass = Some "RAPTORALLTERRAINHOVER"
              maxSlope = Some 18.0
              maxWaterDepth = Some 15.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 16.0 })
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = Some "Claws"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 350.0
                ]
                range = Some (ValueOrExpr.Concrete 200.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
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
                explosiongenerator = Some "custom:raptorspike-small-sparks-burn"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "110.0"
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
              "normaltex", "unittextures/chicken_s_normals.png"
          ]
          extras = Map.ofList [
              "canattack", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canstop", "1"
              "capturable", "false"
              "defaultmissiontype", "Standby"
              "leavetracks", "true"
              "maneuverleashlength", "640"
              "mass", "89.0"
              "maxreversevelocity", "3.0"
              "noautofire", "false"
              "nochasecategory", "VTOL"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "sonardistance", "450.0"
              "trackoffset", "0.5"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrackPointy"
              "trackwidth", "35.0"
              "unitname", "raptor_allterrain_swarmer_basic_t4_v1"
              "upright", "false"
          ] }

    let all : (string * UnitDef) list =
        [
            "raptor_6legged_l", raptor_6legged_l
            "raptor_allterrain_swarmer_basic_t2_v1", raptor_allterrain_swarmer_basic_t2_v1
            "raptor_allterrain_swarmer_basic_t3_v1", raptor_allterrain_swarmer_basic_t3_v1
            "raptor_allterrain_swarmer_basic_t4_v1", raptor_allterrain_swarmer_basic_t4_v1
        ]
