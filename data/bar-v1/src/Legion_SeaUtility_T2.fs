// Auto-generated BAR unit data: Legion/SeaUtility/T2
namespace BarData.V1.Units

open BarData.V1

module Legion_SeaUtility_T2 =

    let leganavalpinpointer : UnitDef =
        { name = "leganavalpinpointer"
          subfolder = "Legion/SeaUtility/T2"
          metalCost = ValueOrExpr.Concrete 800.0
          energyCost = ValueOrExpr.Concrete 7500.0
          buildTime = ValueOrExpr.Concrete 10300.0
          health = ValueOrExpr.Concrete 1530.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/leganavalpinpointer.s3o"
          buildPic = Some "leganavalpinpointer.DDS"
          script = Some "Units/leganavalpinpointer.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "69 95 58"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "wwwwwwwwwwwwwwww"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "69 85 58"
                collisionVolumeType = Some "Box"
                damage = Some 825.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 447.0
                object_ = Some "Units/leganavalpinpointer_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 413.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 4.0
                metal = Some 179.0
                object_ = Some "Units/cor4X4D.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = None
              repair = None
              working = Some "targsel2"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = []
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = []
              select = ["targsel2"] })
          customParams = Map.ofList [
              "model_author", "Protar, ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "Legion/SeaUtility/T2"
              "techlevel", "2.0"
              "unitgroup", "util"
          ]
          extras = Map.ofList [
              "buildangle", "16384.0"
              "energyupkeep", "150.0"
              "istargetingupgrade", "true"
              "onoffable", "true"
          ] }

    let leganavalsonarstation : UnitDef =
        { name = "leganavalsonarstation"
          subfolder = "Legion/SeaUtility/T2"
          metalCost = ValueOrExpr.Concrete 160.0
          energyCost = ValueOrExpr.Concrete 2400.0
          buildTime = ValueOrExpr.Concrete 6100.0
          health = ValueOrExpr.Concrete 2400.0
          sightDistance = ValueOrExpr.Concrete 210.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/leganavalsonarstation.s3o"
          buildPic = Some "leganavalsonarstation.DDS"
          script = Some "Units/leganavalsonarstation.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingexplosiongeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 30 0"
          collisionVolumeScales = Some "59 48 32"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "ooooooooo"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 30 0"
                collisionVolumeScales = Some "59 38 32"
                collisionVolumeType = Some "Box"
                damage = Some 1284.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 99.0
                object_ = Some "Units/leganavalsonarstation_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
          ])
          sounds = Some (
            { build = None
              repair = None
              working = None
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = []
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = []
              select = ["sonar2"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecaltype", "decals/leganavalsonarstation_aoplane.dds"
              "model_author", "ZephyrSkies (Model), JjackVII (Concept Art)"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "Legion/SeaUtility/T2"
              "techlevel", "2.0"
              "unitgroup", "util"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
              "canattack", "false"
              "onoffable", "false"
              "sonardistance", "1600.0"
          ] }

    let all : (string * UnitDef) list =
        [
            "leganavalpinpointer", leganavalpinpointer
            "leganavalsonarstation", leganavalsonarstation
        ]
