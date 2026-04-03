// Auto-generated BAR unit data: other/raptors/Spiker
namespace BarData.V1.Units

open BarData.V1

module other_raptors_Spiker =

    let raptor_land_spiker_basic_t2_v1 : UnitDef =
        { name = "raptor_land_spiker_basic_t2_v1"
          subfolder = "other/raptors/Spiker"
          metalCost = ValueOrExpr.Concrete 174.0
          energyCost = ValueOrExpr.Concrete 174.0
          buildTime = ValueOrExpr.Concrete 3750.0
          health = ValueOrExpr.Concrete 910.0
          sightDistance = ValueOrExpr.Concrete 525.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Raptors/raptors.s3o"
          buildPic = Some "raptors/raptors1.DDS"
          script = Some "Raptors/raptors1.cob"
          corpse = None
          explodeAs = Some "BUG_DEATH"
          selfDestructAs = Some "BUG_DEATH"
          collisionVolumeOffsets = Some "0 -3 0"
          collisionVolumeScales = Some "21 30 46"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 150.0
              maxAcc = 1.725
              maxDec = 1.4375
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
              waterline = Some 24.0 })
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = Some "Spike"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 325.0
                ]
                range = Some (ValueOrExpr.Concrete 525.0)
                reloadTime = Some (ValueOrExpr.Concrete 4.0)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.3
                impulseFactor = Some 0.4
                noSelfDamage = Some true
                soundStart = Some "smallraptorattack"
                soundHit = None
                explosiongenerator = Some "custom:raptorspike-huge-sparks-burn"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "180.0"
                    "mount_onlytargetcategory", "NOTAIR"
                    "cegtag", "sporetrail-large"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "burnblow", "true"
                    "collidefeature", "true"
                    "collidefriendly", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firesubmersed", "true"
                    "interceptedbyshieldtype", "0.0"
                    "model", "Raptors/spike.s3o"
                    "startvelocity", "600.0"
                    "texture1", ""
                    "texture2", "sporetrail"
                    "waterweapon", "false"
                    "weapontimer", "1.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "maxrange", "375"
              "subfolder", "other/raptors"
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_m_normals.png"
          ]
          extras = Map.ofList [
              "canattack", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canstop", "1"
              "capturable", "false"
              "defaultmissiontype", "Standby"
              "leavetracks", "true"
              "maneuverleashlength", "750"
              "mass", "900.0"
              "noautofire", "false"
              "nochasecategory", "VTOL"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "sonardistance", "720.0"
              "trackoffset", "6.0"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrack"
              "trackwidth", "28.0"
              "unitname", "raptor_land_spiker_basic_t2_v1"
              "upright", "false"
          ] }

    let raptor_land_spiker_basic_t4_v1 : UnitDef =
        { name = "raptor_land_spiker_basic_t4_v1"
          subfolder = "other/raptors/Spiker"
          metalCost = ValueOrExpr.Concrete 174.0
          energyCost = ValueOrExpr.Concrete 174.0
          buildTime = ValueOrExpr.Concrete 10500.0
          health = ValueOrExpr.Concrete 2780.0
          sightDistance = ValueOrExpr.Concrete 950.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Raptors/raptors2.s3o"
          buildPic = Some "raptors/raptors2.DDS"
          script = Some "Raptors/raptors2.cob"
          corpse = None
          explodeAs = Some "BUG_DEATH"
          selfDestructAs = Some "BUG_DEATH"
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "24 34 53"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 270.0
              maxAcc = 3.45
              maxDec = 3.45
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
              waterline = Some 29.0 })
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = Some "Spike"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 600.0
                ]
                range = Some (ValueOrExpr.Concrete 950.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.0)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.3
                impulseFactor = Some 0.4
                noSelfDamage = Some true
                soundStart = Some "smallraptorattack"
                soundHit = None
                explosiongenerator = Some "custom:raptorspike-huge-sparks-burn"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "180.0"
                    "mount_onlytargetcategory", "NOTAIR"
                    "cegtag", "sporetrail-large"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "burnblow", "true"
                    "collidefeature", "true"
                    "collidefriendly", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firesubmersed", "true"
                    "interceptedbyshieldtype", "0.0"
                    "model", "Raptors/spike.s3o"
                    "startvelocity", "600.0"
                    "texture1", ""
                    "texture2", "sporetrail"
                    "waterweapon", "false"
                    "weapontimer", "1.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "maxrange", "375"
              "subfolder", "other/raptors"
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_m_normals.png"
          ]
          extras = Map.ofList [
              "canattack", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canstop", "1"
              "capturable", "false"
              "cloakable", "1.0"
              "cloakcost", "0.0"
              "cloakcostmoving", "0.0"
              "defaultmissiontype", "Standby"
              "initcloaked", "1.0"
              "leavetracks", "true"
              "maneuverleashlength", "750"
              "mass", "300.0"
              "mincloakdistance", "200.0"
              "noautofire", "false"
              "nochasecategory", "VTOL"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "sonardistance", "720.0"
              "trackoffset", "6.0"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrack"
              "trackwidth", "30.0"
              "unitname", "raptor_land_spiker_basic_t4_v1"
              "upright", "false"
          ] }

    let all : (string * UnitDef) list =
        [
            "raptor_land_spiker_basic_t2_v1", raptor_land_spiker_basic_t2_v1
            "raptor_land_spiker_basic_t4_v1", raptor_land_spiker_basic_t4_v1
        ]
