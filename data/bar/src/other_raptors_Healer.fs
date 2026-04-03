// Auto-generated BAR unit data: other/raptors/Healer (flat per-unit types)
namespace BarData.Units

open BarData

module other_raptors_Healer =

    type Raptor_land_swarmer_heal_t1_v1 =
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
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          waterline: float
          energyMake: ValueOrExpr<float>
          metalStorage: float
          customParams: Map<string, string>
          extras: Map<string, string> }

    let raptor_land_swarmer_heal_t1_v1 : Raptor_land_swarmer_heal_t1_v1 =
        { name = "raptor_land_swarmer_heal_t1_v1"
          subfolder = "other/raptors/Healer"
          metalCost = ValueOrExpr.Concrete 40.0
          energyCost = ValueOrExpr.Concrete 600.0
          buildTime = ValueOrExpr.Concrete 750.0
          health = ValueOrExpr.Concrete 250.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 1.0
          footprintZ = 1.0
          speed = ValueOrExpr.Concrete 75.0
          maxAcc = 1.0
          maxDec = 1.0
          turnRate = 1840.0
          movementClass = "RAPTORSMALLHOVER"
          maxSlope = 18.0
          maxWaterDepth = 0.0
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 12.0
          energyMake = ValueOrExpr.Concrete 25.0
          metalStorage = 1000.0
          customParams = Map.ofList [
                "subfolder", "other/raptors"
                "model_author", "KDR_11k, Beherith"
                "normalmaps", "yes"
                "normaltex", "unittextures/chicken_s_normals.png"
            ]
          extras = Map.ofList [
                "autoheal", "32.0"
                "canassist", "1.0"
                "canbuild", "1.0"
                "canguard", "1.0"
                "canpatrol", "1.0"
                "canrepair", "1.0"
                "canreclaim", "0.0"
                "canstop", "1.0"
                "capturable", "false"
                "collide", "0.0"
                "defaultmissiontype", "Standby"
                "hidedamage", "1.0"
                "leavetracks", "true"
                "maneuverleashlength", "640.0"
                "mass", "50.0"
                "mobilestandorders", "1.0"
                "noautofire", "0.0"
                "reclaimspeed", "400.0"
                "repairable", "false"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "standingmoveorder", "1.0"
                "stealth", "1.0"
                "trackoffset", "1.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrack"
                "trackwidth", "10.0"
                "unitname", "raptor_land_swarmer_heal_t1_v1"
                "upright", "false"
            ] }

    type Raptor_land_swarmer_heal_t2_v1 =
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
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          waterline: float
          energyMake: ValueOrExpr<float>
          metalStorage: float
          customParams: Map<string, string>
          extras: Map<string, string> }

    let raptor_land_swarmer_heal_t2_v1 : Raptor_land_swarmer_heal_t2_v1 =
        { name = "raptor_land_swarmer_heal_t2_v1"
          subfolder = "other/raptors/Healer"
          metalCost = ValueOrExpr.Concrete 40.0
          energyCost = ValueOrExpr.Concrete 600.0
          buildTime = ValueOrExpr.Concrete 750.0
          health = ValueOrExpr.Concrete 500.0
          sightDistance = ValueOrExpr.Concrete 700.0
          footprintX = 1.0
          footprintZ = 1.0
          speed = ValueOrExpr.Concrete 112.5
          maxAcc = 1.0
          maxDec = 1.0
          turnRate = 1840.0
          movementClass = "RAPTORSMALLHOVER"
          maxSlope = 18.0
          maxWaterDepth = 0.0
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 12.0
          energyMake = ValueOrExpr.Concrete 25.0
          metalStorage = 1000.0
          customParams = Map.ofList [
                "subfolder", "other/raptors"
                "model_author", "KDR_11k, Beherith"
                "normalmaps", "yes"
                "normaltex", "unittextures/chicken_s_normals.png"
            ]
          extras = Map.ofList [
                "autoheal", "32.0"
                "canassist", "1.0"
                "canbuild", "1.0"
                "canguard", "1.0"
                "canpatrol", "1.0"
                "canrepair", "1.0"
                "canreclaim", "0.0"
                "canstop", "1.0"
                "capturable", "false"
                "collide", "0.0"
                "defaultmissiontype", "Standby"
                "hidedamage", "1.0"
                "leavetracks", "true"
                "maneuverleashlength", "640.0"
                "mass", "50.0"
                "mobilestandorders", "1.0"
                "noautofire", "0.0"
                "reclaimspeed", "400.0"
                "repairable", "false"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "standingmoveorder", "1.0"
                "stealth", "1.0"
                "trackoffset", "1.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrack"
                "trackwidth", "10.0"
                "unitname", "raptor_land_swarmer_heal_t2_v1"
                "upright", "false"
            ] }

    type Raptor_land_swarmer_heal_t3_v1 =
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
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          waterline: float
          energyMake: ValueOrExpr<float>
          metalStorage: float
          customParams: Map<string, string>
          extras: Map<string, string> }

    let raptor_land_swarmer_heal_t3_v1 : Raptor_land_swarmer_heal_t3_v1 =
        { name = "raptor_land_swarmer_heal_t3_v1"
          subfolder = "other/raptors/Healer"
          metalCost = ValueOrExpr.Concrete 40.0
          energyCost = ValueOrExpr.Concrete 600.0
          buildTime = ValueOrExpr.Concrete 750.0
          health = ValueOrExpr.Concrete 750.0
          sightDistance = ValueOrExpr.Concrete 800.0
          footprintX = 1.0
          footprintZ = 1.0
          speed = ValueOrExpr.Concrete 150.0
          maxAcc = 1.0
          maxDec = 1.0
          turnRate = 1840.0
          movementClass = "RAPTORSMALLHOVER"
          maxSlope = 18.0
          maxWaterDepth = 0.0
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 12.0
          energyMake = ValueOrExpr.Concrete 25.0
          metalStorage = 1000.0
          customParams = Map.ofList [
                "subfolder", "other/raptors"
                "model_author", "KDR_11k, Beherith"
                "normalmaps", "yes"
                "normaltex", "unittextures/chicken_s_normals.png"
            ]
          extras = Map.ofList [
                "autoheal", "32.0"
                "canassist", "1.0"
                "canbuild", "1.0"
                "canguard", "1.0"
                "canpatrol", "1.0"
                "canrepair", "1.0"
                "canreclaim", "0.0"
                "canstop", "1.0"
                "capturable", "false"
                "collide", "0.0"
                "defaultmissiontype", "Standby"
                "hidedamage", "1.0"
                "leavetracks", "true"
                "maneuverleashlength", "640.0"
                "mass", "50.0"
                "mobilestandorders", "1.0"
                "noautofire", "0.0"
                "reclaimspeed", "400.0"
                "repairable", "false"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "standingmoveorder", "1.0"
                "stealth", "1.0"
                "trackoffset", "1.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrack"
                "trackwidth", "10.0"
                "unitname", "raptor_land_swarmer_heal_t3_v1"
                "upright", "false"
            ] }

    type Raptor_land_swarmer_heal_t4_v1 =
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
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          waterline: float
          energyMake: ValueOrExpr<float>
          metalStorage: float
          customParams: Map<string, string>
          extras: Map<string, string> }

    let raptor_land_swarmer_heal_t4_v1 : Raptor_land_swarmer_heal_t4_v1 =
        { name = "raptor_land_swarmer_heal_t4_v1"
          subfolder = "other/raptors/Healer"
          metalCost = ValueOrExpr.Concrete 40.0
          energyCost = ValueOrExpr.Concrete 600.0
          buildTime = ValueOrExpr.Concrete 750.0
          health = ValueOrExpr.Concrete 1000.0
          sightDistance = ValueOrExpr.Concrete 900.0
          footprintX = 1.0
          footprintZ = 1.0
          speed = ValueOrExpr.Concrete 187.5
          maxAcc = 1.0
          maxDec = 1.0
          turnRate = 1840.0
          movementClass = "RAPTORSMALLHOVER"
          maxSlope = 18.0
          maxWaterDepth = 0.0
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 12.0
          energyMake = ValueOrExpr.Concrete 25.0
          metalStorage = 1000.0
          customParams = Map.ofList [
                "subfolder", "other/raptors"
                "model_author", "KDR_11k, Beherith"
                "normalmaps", "yes"
                "normaltex", "unittextures/chicken_s_normals.png"
            ]
          extras = Map.ofList [
                "autoheal", "32.0"
                "canassist", "1.0"
                "canbuild", "1.0"
                "canguard", "1.0"
                "canpatrol", "1.0"
                "canrepair", "1.0"
                "canreclaim", "0.0"
                "canstop", "1.0"
                "capturable", "false"
                "collide", "0.0"
                "defaultmissiontype", "Standby"
                "hidedamage", "1.0"
                "leavetracks", "true"
                "maneuverleashlength", "640.0"
                "mass", "50.0"
                "mobilestandorders", "1.0"
                "noautofire", "0.0"
                "reclaimspeed", "400.0"
                "repairable", "false"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "standingmoveorder", "1.0"
                "stealth", "1.0"
                "trackoffset", "1.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrack"
                "trackwidth", "10.0"
                "unitname", "raptor_land_swarmer_heal_t4_v1"
                "upright", "false"
            ] }

    type Raptorh1b =
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
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          waterline: float
          energyMake: ValueOrExpr<float>
          metalStorage: float
          customParams: Map<string, string>
          extras: Map<string, string> }

    let raptorh1b : Raptorh1b =
        { name = "raptorh1b"
          subfolder = "other/raptors/Healer"
          metalCost = ValueOrExpr.Concrete 40.0
          energyCost = ValueOrExpr.Concrete 600.0
          buildTime = ValueOrExpr.Concrete 1125.0
          health = ValueOrExpr.Concrete 365.0
          sightDistance = ValueOrExpr.Concrete 50.0
          footprintX = 1.0
          footprintZ = 1.0
          speed = ValueOrExpr.Concrete 150.0
          maxAcc = 1.0
          maxDec = 1.0
          turnRate = 1840.0
          movementClass = "RAPTORSMALLHOVER"
          maxSlope = 18.0
          maxWaterDepth = 0.0
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 13.0
          energyMake = ValueOrExpr.Concrete 15.0
          metalStorage = 1000.0
          customParams = Map.ofList [
                "subfolder", "other/raptors"
                "model_author", "KDR_11k, Beherith"
                "normalmaps", "yes"
                "normaltex", "unittextures/chicken_s_normals.png"
            ]
          extras = Map.ofList [
                "autoheal", "24.0"
                "canassist", "0.0"
                "canbuild", "1.0"
                "canguard", "1.0"
                "canpatrol", "1.0"
                "canrepair", "0.0"
                "canreclaim", "1.0"
                "canstop", "1.0"
                "capturable", "false"
                "collide", "0.0"
                "defaultmissiontype", "Standby"
                "hidedamage", "1.0"
                "leavetracks", "true"
                "maneuverleashlength", "640.0"
                "mass", "60.0"
                "mobilestandorders", "1.0"
                "noautofire", "0.0"
                "reclaimspeed", "400.0"
                "repairable", "false"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "standingmoveorder", "1.0"
                "stealth", "1.0"
                "trackoffset", "1.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrack"
                "trackwidth", "10.0"
                "unitname", "raptorh1b"
                "upright", "false"
            ] }

