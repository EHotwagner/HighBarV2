// Auto-generated BAR unit data: Legion/SeaUtility (flat per-unit types)
namespace BarData.Units

open BarData

module Legion_SeaUtility =

    type Legfrad =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          yardMap: string
          activateWhenBuilt: bool
          canRepeat: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legfrad : Legfrad =
        { name = "legfrad"
          subfolder = "Legion/SeaUtility"
          metalCost = ValueOrExpr.Concrete 130.0
          energyCost = ValueOrExpr.Concrete 1000.0
          buildTime = ValueOrExpr.Concrete 1800.0
          health = ValueOrExpr.Concrete 110.0
          sightDistance = ValueOrExpr.Concrete 760.0
          footprintX = 3.0
          footprintZ = 3.0
          yardMap = "wwwwwwwww"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 -14.8080587891 -0.125"
                  collisionVolumeScales = Some "45.9999694824 25.4694824219 42.75"
                  collisionVolumeType = Some "Box"
                  damage = Some 59.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 40.0
                  metal = Some 83.0
                  object_ = Some "Units/legfrad_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
            ]
          sounds =
              { build = None
                repair = None
                working = Some "cmd-on"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["radarselect"] }
          customParams = Map.ofList [
                "model_author", "ZephyrSkies"
                "normaltex", "unittextures/leg_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "ArmBuildings/SeaUtil"
                "unitgroup", "util"
            ]
          extras = Map.ofList [
                "buildangle", "16384.0"
                "canattack", "false"
                "onoffable", "false"
                "radardistance", "2100.0"
                "radaremitheight", "52.0"
                "sightemitheight", "52.0"
                "sonardistance", "900.0"
            ] }

