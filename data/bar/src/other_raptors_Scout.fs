// Auto-generated BAR unit data: other/raptors/Scout (flat per-unit types)
namespace BarData.Units

open BarData

module other_raptors_Scout =

    type Raptor_air_scout_basic_t2_v1 =
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

    let raptor_air_scout_basic_t2_v1 : Raptor_air_scout_basic_t2_v1 =
        { name = "raptor_air_scout_basic_t2_v1"
          subfolder = "other/raptors/Scout"
          metalCost = ValueOrExpr.Concrete 50.0
          energyCost = ValueOrExpr.Concrete 50.0
          buildTime = ValueOrExpr.Concrete 6000.0
          health = ValueOrExpr.Concrete 500.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 450.0
          maxAcc = 0.25
          maxDec = 0.4
          turnRate = 1600.0
          canFly = true
          canMove = true
          turnInPlace = true
          cruiseAltitude = 220.0
          customParams = Map.ofList [
                "subfolder", "other/raptors"
                "model_author", "KDR_11k, Beherith"
                "normalmaps", "yes"
                "normaltex", "unittextures/chicken_m_normals.png"
            ]
          extras = Map.ofList [
                "acceleration", "2.0"
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
                "maxpitch", "0.75"
                "maxrudder", "0.025"
                "moverate1", "32"
                "noautofire", "false"
                "nochasecategory", "VTOL"
                "radardistance", "1000.0"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "speedtofront", "0.07"
                "turnradius", "64.0"
                "unitname", "raptor_air_scout_basic_t2_v1"
                "usesmoothmesh", "true"
                "wingangle", "0.06593"
                "wingdrag", "0.835"
            ] }

    type Raptor_air_scout_basic_t3_v1 =
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

    let raptor_air_scout_basic_t3_v1 : Raptor_air_scout_basic_t3_v1 =
        { name = "raptor_air_scout_basic_t3_v1"
          subfolder = "other/raptors/Scout"
          metalCost = ValueOrExpr.Concrete 50.0
          energyCost = ValueOrExpr.Concrete 50.0
          buildTime = ValueOrExpr.Concrete 6000.0
          health = ValueOrExpr.Concrete 1500.0
          sightDistance = ValueOrExpr.Concrete 2000.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 525.0
          maxAcc = 0.25
          maxDec = 0.4
          turnRate = 1600.0
          canFly = true
          canMove = true
          turnInPlace = true
          cruiseAltitude = 220.0
          customParams = Map.ofList [
                "subfolder", "other/raptors"
                "model_author", "KDR_11k, Beherith"
                "normalmaps", "yes"
                "normaltex", "unittextures/chicken_m_normals.png"
            ]
          extras = Map.ofList [
                "acceleration", "2.0"
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
                "maxpitch", "0.75"
                "maxrudder", "0.025"
                "moverate1", "32"
                "noautofire", "false"
                "nochasecategory", "VTOL"
                "radardistance", "2000.0"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "speedtofront", "0.07"
                "turnradius", "64.0"
                "unitname", "raptor_air_scout_basic_t3_v1"
                "usesmoothmesh", "true"
                "wingangle", "0.06593"
                "wingdrag", "0.835"
            ] }

    type Raptor_air_scout_basic_t4_v1 =
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

    let raptor_air_scout_basic_t4_v1 : Raptor_air_scout_basic_t4_v1 =
        { name = "raptor_air_scout_basic_t4_v1"
          subfolder = "other/raptors/Scout"
          metalCost = ValueOrExpr.Concrete 50.0
          energyCost = ValueOrExpr.Concrete 50.0
          buildTime = ValueOrExpr.Concrete 6000.0
          health = ValueOrExpr.Concrete 5000.0
          sightDistance = ValueOrExpr.Concrete 3000.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 600.0
          maxAcc = 0.25
          maxDec = 0.4
          turnRate = 1600.0
          canFly = true
          canMove = true
          turnInPlace = true
          cruiseAltitude = 220.0
          customParams = Map.ofList [
                "subfolder", "other/raptors"
                "model_author", "KDR_11k, Beherith"
                "normalmaps", "yes"
                "normaltex", "unittextures/chicken_m_normals.png"
            ]
          extras = Map.ofList [
                "acceleration", "2.0"
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
                "maxpitch", "0.75"
                "maxrudder", "0.025"
                "moverate1", "32"
                "noautofire", "false"
                "nochasecategory", "VTOL"
                "radardistance", "3000.0"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "speedtofront", "0.07"
                "turnradius", "64.0"
                "unitname", "raptor_air_scout_basic_t4_v1"
                "usesmoothmesh", "true"
                "wingangle", "0.06593"
                "wingdrag", "0.835"
            ] }

