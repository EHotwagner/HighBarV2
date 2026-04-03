// Auto-generated BAR unit data: Legion/SeaUtility
namespace BarData.V1.Units

open BarData.V1

module Legion_SeaUtility =

    let legfrad : UnitDef =
        { name = "legfrad"
          subfolder = "Legion/SeaUtility"
          metalCost = ValueOrExpr.Concrete 130.0
          energyCost = ValueOrExpr.Concrete 1000.0
          buildTime = ValueOrExpr.Concrete 1800.0
          health = ValueOrExpr.Concrete 110.0
          sightDistance = ValueOrExpr.Concrete 760.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/legfrad.s3o"
          buildPic = Some "legfrad.DDS"
          script = Some "Units/legfrad.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingexplosiongeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -12 0"
          collisionVolumeScales = Some "32 99 32"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "wwwwwwwww"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
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
          ])
          sounds = Some (
            { build = None
              repair = None
              working = Some "cmd-on"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = []
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = []
              select = ["radarselect"] })
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

    let all : (string * UnitDef) list =
        [
            "legfrad", legfrad
        ]
