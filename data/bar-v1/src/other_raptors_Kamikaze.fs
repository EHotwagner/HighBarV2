// Auto-generated BAR unit data: other/raptors/Kamikaze
namespace BarData.V1.Units

open BarData.V1

module other_raptors_Kamikaze =

    let raptor_air_kamikaze_basic_t2_v1 : UnitDef =
        { name = "raptor_air_kamikaze_basic_t2_v1"
          subfolder = "other/raptors/Kamikaze"
          metalCost = ValueOrExpr.Concrete 212.0
          energyCost = ValueOrExpr.Concrete 4550.0
          buildTime = ValueOrExpr.Concrete 9375.0
          health = ValueOrExpr.Concrete 1330.0
          sightDistance = ValueOrExpr.Concrete 100.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Raptors/raptor_dodo_air.s3o"
          buildPic = Some "raptors/raptor_dodoair.DDS"
          script = Some "Raptors/raptorf1.cob"
          corpse = None
          explodeAs = Some "DODO_DEATHAIR"
          selfDestructAs = Some "DODO_DEATHAIR"
          collisionVolumeOffsets = Some "0 8 -2"
          collisionVolumeScales = Some "35 7 24"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 450.0
              maxAcc = 0.25
              maxDec = 0.1
              turnRate = 3200.0
              movementClass = None
              maxSlope = None
              maxWaterDepth = None
              canFly = true
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 30.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = None
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
              "acceleration", "0.8"
              "airhoverfactor", "0.0"
              "attackrunlength", "32.0"
              "canattack", "true"
              "canguard", "true"
              "canland", "true"
              "canpatrol", "true"
              "canstop", "1"
              "cansubmerge", "true"
              "capturable", "false"
              "collide", "false"
              "defaultmissiontype", "Standby"
              "hidedamage", "1.0"
              "maneuverleashlength", "20000"
              "mass", "227.5"
              "maxaileron", "0.025"
              "maxbank", "0.8"
              "maxelevator", "0.025"
              "maxpitch", "1.0"
              "maxrudder", "0.025"
              "moverate1", "32"
              "noautofire", "false"
              "nochasecategory", "VTOL"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "speedtofront", "0.07"
              "turnradius", "32.0"
              "unitname", "raptorf1"
              "usesmoothmesh", "true"
              "wingangle", "0.06593"
              "wingdrag", "0.835"
              "kamikaze", "true"
              "kamikazedistance", "128.0"
          ] }

    let raptor_land_kamikaze_basic_t2_v1 : UnitDef =
        { name = "raptor_land_kamikaze_basic_t2_v1"
          subfolder = "other/raptors/Kamikaze"
          metalCost = ValueOrExpr.Concrete 128.0
          energyCost = ValueOrExpr.Concrete 3000.0
          buildTime = ValueOrExpr.Concrete 4500.0
          health = ValueOrExpr.Concrete 890.0
          sightDistance = ValueOrExpr.Concrete 50.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Raptors/raptor_dodo.s3o"
          buildPic = Some "raptors/raptor_dodo1.DDS"
          script = Some "Raptors/raptor_dodo1.cob"
          corpse = None
          explodeAs = Some "DODO_DEATH1"
          selfDestructAs = Some "DODO_DEATH1"
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "10 14 22"
          collisionVolumeType = Some "box"
          seismicSignature = Some 2.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 210.0
              maxAcc = 6.9
              maxDec = 0.23
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
              waterline = Some 13.0 })
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_s_normals.png"
              "instantselfd", "true"
          ]
          extras = Map.ofList [
              "autoheal", "50.0"
              "canguard", "true"
              "canhover", "1"
              "canpatrol", "true"
              "canstop", "1"
              "capturable", "false"
              "collide", "false"
              "defaultmissiontype", "Standby"
              "hidedamage", "1.0"
              "kamikaze", "true"
              "kamikazedistance", "40.0"
              "leavetracks", "true"
              "maneuverleashlength", "640"
              "mass", "50.0"
              "noautofire", "false"
              "nochasecategory", "VTOL HOVER"
              "selfdestructcountdown", "0.0"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "stealth", "1.0"
              "trackoffset", "1.0"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrack"
              "trackwidth", "10.0"
              "unitname", "raptor_land_kamikaze_basic_t2_v1"
              "upright", "false"
          ] }

    let raptor_land_kamikaze_basic_t4_v1 : UnitDef =
        { name = "raptor_land_kamikaze_basic_t4_v1"
          subfolder = "other/raptors/Kamikaze"
          metalCost = ValueOrExpr.Concrete 350.0
          energyCost = ValueOrExpr.Concrete 9000.0
          buildTime = ValueOrExpr.Concrete 22500.0
          health = ValueOrExpr.Concrete 4450.0
          sightDistance = ValueOrExpr.Concrete 100.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Raptors/big_raptor_dodo.s3o"
          buildPic = Some "raptors/raptor_dodo2.DDS"
          script = Some "Raptors/raptor_dodo2.cob"
          corpse = None
          explodeAs = Some "DODO_DEATH2"
          selfDestructAs = Some "DODO_DEATH2"
          collisionVolumeOffsets = Some "0 -3 0"
          collisionVolumeScales = Some "18 35 41"
          collisionVolumeType = Some "box"
          seismicSignature = Some 4.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 240.0
              maxAcc = 6.9
              maxDec = 0.23
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
              waterline = Some 21.0 })
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_m_normals.png"
              "instantselfd", "true"
          ]
          extras = Map.ofList [
              "autoheal", "135.0"
              "canguard", "true"
              "canhover", "1"
              "canpatrol", "true"
              "canstop", "1"
              "capturable", "false"
              "collide", "0.0"
              "defaultmissiontype", "Standby"
              "hidedamage", "1.0"
              "kamikaze", "true"
              "kamikazedistance", "72.0"
              "leavetracks", "true"
              "maneuverleashlength", "640"
              "mass", "100.0"
              "noautofire", "false"
              "nochasecategory", "VTOL HOVER"
              "selfdestructcountdown", "0.0"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "stealth", "1.0"
              "trackoffset", "1.0"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrack"
              "trackwidth", "10.0"
              "unitname", "raptor_land_kamikaze_basic_t4_v1"
              "upright", "false"
          ] }

    let all : (string * UnitDef) list =
        [
            "raptor_air_kamikaze_basic_t2_v1", raptor_air_kamikaze_basic_t2_v1
            "raptor_land_kamikaze_basic_t2_v1", raptor_land_kamikaze_basic_t2_v1
            "raptor_land_kamikaze_basic_t4_v1", raptor_land_kamikaze_basic_t4_v1
        ]
