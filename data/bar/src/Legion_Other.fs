// Auto-generated BAR unit data: Legion/Other
namespace BarData.Units

open BarData

module Legion_Other =

    let legvision : UnitDef =
        { name = "legvision"
          subfolder = "Legion/Other"
          metalCost = ValueOrExpr.Concrete 1.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 750.0
          health = ValueOrExpr.Concrete 1.0
          sightDistance = ValueOrExpr.Concrete 300.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Units/LEGVISION.s3o"
          buildPic = Some "COREYES.DDS"
          script = Some "Units/COREYES.cob"
          corpse = Some "CDRAGONSEYES_DEAD"
          explodeAs = None
          selfDestructAs = None
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "20 24 20"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "o"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "cdragonseyes_dead",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = Some "-0.0323944091797 0.0 0.00588226318359"
                collisionVolumeScales = Some "21.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 120.0
                featureDead = None
                footprintX = Some 1.0
                footprintZ = Some 1.0
                height = Some 4.0
                metal = Some 12.0
                object_ = Some "Units/cor1X1A.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = None
              repair = None
              working = None
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["servsml6"]
              select = ["minesel2"] })
          customParams = Map.ofList [
              "unitgroup", "util"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "CorBuildings/LandUtil"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
              "cloakcost", "0.001"
              "cloakcostmoving", "0.0"
              "energyupkeep", "0.0"
              "initcloaked", "true"
              "levelground", "false"
              "mincloakdistance", "0.0"
              "stealth", "true"
          ] }

    let all : (string * UnitDef) list =
        [
            "legvision", legvision
        ]
