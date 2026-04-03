// Auto-generated BAR unit data: Legion/SeaEconomy
namespace BarData.V1.Units

open BarData.V1

module Legion_SeaEconomy =

    let legfeconv : UnitDef =
        { name = "legfeconv"
          subfolder = "Legion/SeaEconomy"
          metalCost = ValueOrExpr.Concrete 1.0
          energyCost = ValueOrExpr.Concrete 1250.0
          buildTime = ValueOrExpr.Concrete 2680.0
          health = ValueOrExpr.Concrete 167.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/legfeconv.s3o"
          buildPic = Some "legfeconv.DDS"
          script = Some "Units/legfeconv.cob"
          corpse = None
          explodeAs = Some "largeBuildingExplosionGeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "41 21 43"
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
          featureDefs = None
          sounds = Some (
            { build = None
              repair = None
              working = Some "arm-bld-metalmaker"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = []
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = []
              select = ["metlon2"] })
          customParams = Map.ofList [
              "energyconv_capacity", "70.0"
              "energyconv_efficiency", "0.01429"
              "model_author", "Protar, ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "Legion/SeaEconomy"
              "unitgroup", "metal"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
          ] }

    let legtide : UnitDef =
        { name = "legtide"
          subfolder = "Legion/SeaEconomy"
          metalCost = ValueOrExpr.Concrete 85.0
          energyCost = ValueOrExpr.Concrete 250.0
          buildTime = ValueOrExpr.Concrete 2100.0
          health = ValueOrExpr.Concrete 395.0
          sightDistance = ValueOrExpr.Concrete 130.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/LEGTIDE.s3o"
          buildPic = Some "LEGTIDE.DDS"
          script = Some "Units/LEGTIDE.cob"
          corpse = Some "DEAD"
          explodeAs = Some "tidal"
          selfDestructAs = Some "tidalSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "40 26 36"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 50.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "wwwwwwwww"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0854949951172 0.00585021972656 -1.6875"
                collisionVolumeScales = Some "43.4789733887 28.4617004395 39.825012207"
                collisionVolumeType = Some "Box"
                damage = Some 145.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 4.0
                metal = Some 53.0
                object_ = Some "Units/legtide_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 185.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 17.0
                object_ = Some "Units/cor2X2D.s3o"
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
              cant = []
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = []
              select = ["tidegen2"] })
          customParams = Map.ofList [
              "unitgroup", "energy"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "Legion/SeaEconomy"
          ]
          extras = Map.ofList [
              "buildangle", "4096.0"
              "onoffable", "false"
              "tidalgenerator", "1.0"
          ] }

    let leguwestore : UnitDef =
        { name = "leguwestore"
          subfolder = "Legion/SeaEconomy"
          metalCost = ValueOrExpr.Concrete 175.0
          energyCost = ValueOrExpr.Concrete 1800.0
          buildTime = ValueOrExpr.Concrete 4260.0
          health = ValueOrExpr.Concrete 2000.0
          sightDistance = ValueOrExpr.Concrete 169.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/leguwestore.s3o"
          buildPic = Some "leguwestore.DDS"
          script = Some "Units/leguwestore.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingExplosionGeneric-uw"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd-uw"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "58 42 74"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 6000.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooooooooooooooo"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "58 42 74"
                collisionVolumeType = Some "CylY"
                damage = Some 1825.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 182.0
                object_ = Some "Units/leguwestore_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 913.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 4.0
                metal = Some 73.0
                object_ = Some "Units/cor4X4D.s3o"
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
              cant = []
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = []
              select = ["storngy2"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "6.0"
              "buildinggrounddecalsizey", "6.0"
              "buildinggrounddecaltype", "decals/leguwestore_aoplane.dds"
              "model_author", "Protar, ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "Legion/SeaEconomy"
              "unitgroup", "energy"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
          ] }

    let leguwgeo : UnitDef =
        { name = "leguwgeo"
          subfolder = "Legion/SeaEconomy"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 0.0
          buildTime = ValueOrExpr.Concrete 12900.0
          health = ValueOrExpr.Concrete 0.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/leguwgeo.s3o"
          buildPic = Some "leguwgeo.DDS"
          script = Some "Units/leguwgeo.cob"
          corpse = Some "dead"
          explodeAs = Some "geo"
          selfDestructAs = Some "geo"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "63 45 63"
          collisionVolumeType = Some "cylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 300.0)
              metalMake = None
              energyStorage = Some 1000.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "h cbbbbgbbbc bgbggbbggb bgbgbggbbb bbgggbgggb gbgbgggbgb bgbgggbgbg bgggbgggbb bbbggbgbgb bggbbggbgb cbbbgbbbbc"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "63 45 63"
                collisionVolumeType = Some "cylY"
                damage = Some 1110.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 328.0
                object_ = Some "Units/leguwgeo_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 555.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 4.0
                metal = Some 131.0
                object_ = Some "Units/cor4X4B.s3o"
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
              cant = []
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = []
              select = ["geothrm2"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "6.0"
              "buildinggrounddecalsizey", "6.0"
              "buildinggrounddecaltype", "decals/corgeo_aoplane.dds"
              "cvbuildable", "true"
              "geothermal", "1.0"
              "model_author", "Tharsis, ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "Legion/SeaEconomy"
              "unitgroup", "energy"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "acceleration", "0.0"
              "brakerate", "0.0"
              "buildangle", "4096.0"
              "buildcostenergy", "13000.0"
              "buildcostmetal", "540.0"
              "maxdamage", "2050.0"
          ] }

    let leguwmstore : UnitDef =
        { name = "leguwmstore"
          subfolder = "Legion/SeaEconomy"
          metalCost = ValueOrExpr.Concrete 340.0
          energyCost = ValueOrExpr.Concrete 590.0
          buildTime = ValueOrExpr.Concrete 2920.0
          health = ValueOrExpr.Concrete 2100.0
          sightDistance = ValueOrExpr.Concrete 169.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/leguwmstore.s3o"
          buildPic = Some "leguwmstore.DDS"
          script = Some "Units/leguwmstore.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric-uw"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd-uw"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "58 36 60"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = None
              metalStorage = Some 3000.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooooooooooooooo"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "58 36 60"
                collisionVolumeType = Some "CylY"
                damage = Some 2100.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 228.0
                object_ = Some "Units/leguwmstore_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 1050.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 4.0
                metal = Some 91.0
                object_ = Some "Units/cor4X4D.s3o"
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
              cant = []
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = []
              select = ["stormtl2"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "6.0"
              "buildinggrounddecalsizey", "6.0"
              "buildinggrounddecaltype", "decals/leguwmstore_aoplane.dds"
              "model_author", "Protar, ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "Legion/SeaEconomy"
              "unitgroup", "metal"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
          ] }

    let all : (string * UnitDef) list =
        [
            "legfeconv", legfeconv
            "legtide", legtide
            "leguwestore", leguwestore
            "leguwgeo", leguwgeo
            "leguwmstore", leguwmstore
        ]
