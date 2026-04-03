// Auto-generated BAR unit data: other/raptors/Kamikaze (flat per-unit types)
namespace BarData.Units

open BarData

module other_raptors_Kamikaze =

    type Raptor_air_kamikaze_basic_t2_v1 =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          canFly: bool
          canMove: bool
          turnInPlace: bool
          cruiseAltitude: float
          customParams: Map<string, string>
          extras: Map<string, string> }

    let raptor_air_kamikaze_basic_t2_v1 : Raptor_air_kamikaze_basic_t2_v1 =
        { name = "raptor_air_kamikaze_basic_t2_v1"
          subfolder = "other/raptors/Kamikaze"
          metalCost = ValueOrExpr.Concrete 212.0
          energyCost = ValueOrExpr.Concrete 4550.0
          buildTime = ValueOrExpr.Concrete 9375.0
          health = ValueOrExpr.Concrete 1330.0
          sightDistance = ValueOrExpr.Concrete 100.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 450.0
          maxAcc = 0.25
          maxDec = 0.1
          turnRate = 3200.0
          canFly = true
          canMove = true
          turnInPlace = true
          cruiseAltitude = 30.0
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

    type Raptor_land_kamikaze_basic_t2_v1 =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
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
          customParams: Map<string, string>
          extras: Map<string, string> }

    let raptor_land_kamikaze_basic_t2_v1 : Raptor_land_kamikaze_basic_t2_v1 =
        { name = "raptor_land_kamikaze_basic_t2_v1"
          subfolder = "other/raptors/Kamikaze"
          metalCost = ValueOrExpr.Concrete 128.0
          energyCost = ValueOrExpr.Concrete 3000.0
          buildTime = ValueOrExpr.Concrete 4500.0
          health = ValueOrExpr.Concrete 890.0
          sightDistance = ValueOrExpr.Concrete 50.0
          footprintX = 1.0
          footprintZ = 1.0
          speed = ValueOrExpr.Concrete 210.0
          maxAcc = 6.9
          maxDec = 0.23
          turnRate = 1840.0
          movementClass = "RAPTORSMALLHOVER"
          maxSlope = 18.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 13.0
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

    type Raptor_land_kamikaze_basic_t4_v1 =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
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
          customParams: Map<string, string>
          extras: Map<string, string> }

    let raptor_land_kamikaze_basic_t4_v1 : Raptor_land_kamikaze_basic_t4_v1 =
        { name = "raptor_land_kamikaze_basic_t4_v1"
          subfolder = "other/raptors/Kamikaze"
          metalCost = ValueOrExpr.Concrete 350.0
          energyCost = ValueOrExpr.Concrete 9000.0
          buildTime = ValueOrExpr.Concrete 22500.0
          health = ValueOrExpr.Concrete 4450.0
          sightDistance = ValueOrExpr.Concrete 100.0
          footprintX = 1.0
          footprintZ = 1.0
          speed = ValueOrExpr.Concrete 240.0
          maxAcc = 6.9
          maxDec = 0.23
          turnRate = 1840.0
          movementClass = "RAPTORSMALLHOVER"
          maxSlope = 18.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 21.0
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

