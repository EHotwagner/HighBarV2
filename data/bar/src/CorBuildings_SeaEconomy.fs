// Auto-generated BAR unit data: CorBuildings/SeaEconomy
namespace BarData.Units

open BarData

module CorBuildings_SeaEconomy =

    let corfmkr : UnitDef =
        { name = "corfmkr"
          subfolder = "CorBuildings/SeaEconomy"
          metalCost = ValueOrExpr.Concrete 1.0
          energyCost = ValueOrExpr.Concrete 1250.0
          buildTime = ValueOrExpr.Concrete 2680.0
          health = ValueOrExpr.Concrete 167.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORFMKR.s3o"
          buildPic = Some "CORFMKR.DDS"
          script = Some "Units/CORFMKR.cob"
          corpse = None
          explodeAs = Some "largeBuildingExplosionGeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
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
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "CorBuildings/SeaEconomy"
              "unitgroup", "metal"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
          ] }

    let cortide : UnitDef =
        { name = "cortide"
          subfolder = "CorBuildings/SeaEconomy"
          metalCost = ValueOrExpr.Concrete 85.0
          energyCost = ValueOrExpr.Concrete 250.0
          buildTime = ValueOrExpr.Concrete 2100.0
          health = ValueOrExpr.Concrete 395.0
          sightDistance = ValueOrExpr.Concrete 130.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORTIDE.s3o"
          buildPic = Some "CORTIDE.DDS"
          script = Some "Units/CORTIDE.cob"
          corpse = Some "DEAD"
          explodeAs = Some "tidal"
          selfDestructAs = Some "tidalSelfd"
          collisionVolumeOffsets = Some "-3 2 -1"
          collisionVolumeScales = Some "28 30 33"
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
                object_ = Some "Units/cortide_dead.s3o"
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
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "CorBuildings/SeaEconomy"
              "unitgroup", "energy"
          ]
          extras = Map.ofList [
              "buildangle", "4096.0"
              "onoffable", "false"
              "tidalgenerator", "1.0"
          ] }

    let coruwadves : UnitDef =
        { name = "coruwadves"
          subfolder = "CorBuildings/SeaEconomy"
          metalCost = ValueOrExpr.Concrete 840.0
          energyCost = ValueOrExpr.Concrete 11000.0
          buildTime = ValueOrExpr.Concrete 20400.0
          health = ValueOrExpr.Concrete 12700.0
          sightDistance = ValueOrExpr.Concrete 192.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/CORUWADVES.s3o"
          buildPic = Some "CORUWADVES.DDS"
          script = Some "Units/CORUWADVES.cob"
          corpse = Some "DEAD"
          explodeAs = Some "advenergystorage"
          selfDestructAs = Some "advenergystorageSelfd"
          collisionVolumeOffsets = Some "0 -16 0"
          collisionVolumeScales = Some "90 65 90"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = Some "CANBEUW"
          movement = None
          builder = None
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 40000.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "ooooooooooooooooooooooooo"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "-2.07458496094 4.21508789046e-05 -0.501388549805"
                collisionVolumeScales = Some "87.0777893066 35.5382843018 90.1298522949"
                collisionVolumeType = Some "Box"
                damage = Some 4560.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 9.0
                metal = Some 514.0
                object_ = Some "Units/coruwadves_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 2280.0
                featureDead = None
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = None
                metal = Some 206.0
                object_ = Some "Units/cor5X5A.s3o"
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
              "buildinggrounddecalsizex", "8.0"
              "buildinggrounddecalsizey", "8.0"
              "buildinggrounddecaltype", "decals/coruwadves_aoplane.dds"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "CorBuildings/SeaEconomy"
              "techlevel", "2.0"
              "unitgroup", "energy"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "7822.0"
          ] }

    let coruwadvms : UnitDef =
        { name = "coruwadvms"
          subfolder = "CorBuildings/SeaEconomy"
          metalCost = ValueOrExpr.Concrete 760.0
          energyCost = ValueOrExpr.Concrete 11000.0
          buildTime = ValueOrExpr.Concrete 20500.0
          health = ValueOrExpr.Concrete 11200.0
          sightDistance = ValueOrExpr.Concrete 182.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/CORUWADVMS.s3o"
          buildPic = Some "CORUWADVMS.DDS"
          script = Some "Units/CORUWADVMS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingexplosiongeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "-6 0 0"
          collisionVolumeScales = Some "46 40 58"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = Some "CANBEUW"
          movement = None
          builder = None
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = None
              metalStorage = Some 10000.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooooooooooooooo"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "-8.0463180542 -4.28710937506e-05 2.1676940918"
                collisionVolumeScales = Some "49.8645172119 42.9171142578 64.3353881836"
                collisionVolumeType = Some "Box"
                damage = Some 4020.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 9.0
                metal = Some 462.0
                object_ = Some "Units/coruwadvms_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 2010.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = None
                metal = Some 185.0
                object_ = Some "Units/cor4X4A.s3o"
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
              "buildinggrounddecaltype", "decals/coruwadvms_aoplane.dds"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "CorBuildings/SeaEconomy"
              "techlevel", "2.0"
              "unitgroup", "metal"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "6093.0"
          ] }

    let coruwageo : UnitDef =
        { name = "coruwageo"
          subfolder = "CorBuildings/SeaEconomy"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 0.0
          buildTime = ValueOrExpr.Concrete 48000.0
          health = ValueOrExpr.Concrete 0.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/CORUWAGEO.s3o"
          buildPic = Some "CORUWAGEO.DDS"
          script = Some "Units/CORUWAGEO.cob"
          corpse = None
          explodeAs = Some "customfusionexplo"
          selfDestructAs = Some "advgeo"
          collisionVolumeOffsets = Some "0 5 0"
          collisionVolumeScales = Some "96 86 96"
          collisionVolumeType = Some "cylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 1250.0)
              metalMake = None
              energyStorage = Some 12000.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "h cbgybsyybc bsbssbbssb ysbsbssbbg ybsssbsssy sbsbsssbsb bsbsssbsbs ysssbsssby gbbssbsbsy bssbbssbsb cbyysbygbc"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = None
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
              "buildinggrounddecalsizex", "8.0"
              "buildinggrounddecalsizey", "8.0"
              "buildinggrounddecaltype", "decals/corageo_aoplane.dds"
              "cvbuildable", "true"
              "geothermal", "1.0"
              "model_author", "Cremuss, Hornet"
              "normaltex", "unittextures/cor_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "CorBuildings/SeaEconomy"
              "techlevel", "2.0"
              "unitgroup", "energy"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "acceleration", "0.0"
              "brakerate", "0.0"
              "buildangle", "0.0"
              "buildcostenergy", "27000.0"
              "buildcostmetal", "1500.0"
              "maxdamage", "4150.0"
          ] }

    let coruwes : UnitDef =
        { name = "coruwes"
          subfolder = "CorBuildings/SeaEconomy"
          metalCost = ValueOrExpr.Concrete 175.0
          energyCost = ValueOrExpr.Concrete 1800.0
          buildTime = ValueOrExpr.Concrete 4260.0
          health = ValueOrExpr.Concrete 2000.0
          sightDistance = ValueOrExpr.Concrete 169.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/CORUWES.s3o"
          buildPic = Some "CORUWES.DDS"
          script = Some "Units/CORUWES.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingExplosionGeneric-uw"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd-uw"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
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
                collisionVolumeOffsets = Some "5.91815185547 -0.0585083374023 -0.949203491211"
                collisionVolumeScales = Some "57.7583618164 50.6997833252 64.7775878906"
                collisionVolumeType = Some "Box"
                damage = Some 1825.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 182.0
                object_ = Some "Units/coruwes_dead.s3o"
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
              "buildinggrounddecaltype", "decals/coruwes_aoplane.dds"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "CorBuildings/SeaEconomy"
              "unitgroup", "energy"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
          ] }

    let coruwfus : UnitDef =
        { name = "coruwfus"
          subfolder = "CorBuildings/SeaEconomy"
          metalCost = ValueOrExpr.Concrete 5400.0
          energyCost = ValueOrExpr.Concrete 34000.0
          buildTime = ValueOrExpr.Concrete 105000.0
          health = ValueOrExpr.Concrete 5900.0
          sightDistance = ValueOrExpr.Concrete 143.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/CORUWFUS.s3o"
          buildPic = Some "CORUWFUS.DDS"
          script = Some "Units/CORUWFUS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "fusionExplosion-uw"
          selfDestructAs = Some "fusionExplosionSelfd-uw"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 1220.0)
              metalMake = None
              energyStorage = Some 2500.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "ooooooooooooooooooooooooo"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "1.8653717041 -0.0807505981445 0.994560241699"
                collisionVolumeScales = Some "89.9762878418 27.3368988037 72.5986480713"
                collisionVolumeType = Some "Box"
                damage = Some 3210.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 20.0
                metal = Some 3099.0
                object_ = Some "Units/coruwfus_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 1605.0
                featureDead = None
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 4.0
                metal = Some 1240.0
                object_ = Some "Units/cor5X5A.s3o"
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
              select = ["watfusn2"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "8.0"
              "buildinggrounddecalsizey", "8.0"
              "buildinggrounddecaltype", "decals/coruwfus_aoplane.dds"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "CorBuildings/SeaEconomy"
              "techlevel", "2.0"
              "unitgroup", "energy"
              "restrictions_inclusion", "_nofusion_"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
              "hidedamage", "true"
          ] }

    let coruwgeo : UnitDef =
        { name = "coruwgeo"
          subfolder = "CorBuildings/SeaEconomy"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 0.0
          buildTime = ValueOrExpr.Concrete 12900.0
          health = ValueOrExpr.Concrete 0.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/CORUWGEO.s3o"
          buildPic = Some "CORUWGEO.DDS"
          script = Some "Units/CORUWGEO.cob"
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
                object_ = Some "Units/corgeo_dead.s3o"
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
              "model_author", "Cremuss, Hornet"
              "normaltex", "unittextures/cor_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "CorBuildings/SeaEconomy"
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

    let coruwmme : UnitDef =
        { name = "coruwmme"
          subfolder = "CorBuildings/SeaEconomy"
          metalCost = ValueOrExpr.Concrete 640.0
          energyCost = ValueOrExpr.Concrete 8100.0
          buildTime = ValueOrExpr.Concrete 14100.0
          health = ValueOrExpr.Concrete 3900.0
          sightDistance = ValueOrExpr.Concrete 169.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/CORUWMME.s3o"
          buildPic = Some "CORUWMME.DDS"
          script = Some "Units/CORUWMME.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingexplosiongeneric-uw"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd-uw"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = None
              metalStorage = Some 600.0
              extractsMetal = Some 0.004 })
          building = Some (
            { yardMap = Some "h cbbbbbbc bssssssb bsssossb bsobbssb bssbbosb bssosssb bssssssb cbbbbbbc"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0 -4.8856736084 -0.0"
                collisionVolumeScales = Some "80.0 29.6428527832 80.0"
                collisionVolumeType = Some "Box"
                damage = Some 1243.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 150.0
                metal = Some 550.0
                object_ = Some "Units/coruwmme_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 622.0
                featureDead = None
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 5.0
                metal = Some 220.0
                object_ = Some "Units/cor5X5C.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = None
              repair = None
              working = Some "waterex2"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = []
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = []
              select = ["waterex2"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "7.7"
              "buildinggrounddecalsizey", "7.7"
              "buildinggrounddecaltype", "decals/coruwmme_aoplane.dds"
              "cvbuildable", "true"
              "metal_extractor", "4.0"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "CorBuildings/SeaEconomy"
              "techlevel", "2.0"
              "unitgroup", "metal"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "32768.0"
              "damagemodifier", "0.5"
              "energyupkeep", "20.0"
              "onoffable", "true"
          ] }

    let coruwmmm : UnitDef =
        { name = "coruwmmm"
          subfolder = "CorBuildings/SeaEconomy"
          metalCost = ValueOrExpr.Concrete 370.0
          energyCost = ValueOrExpr.Concrete 21000.0
          buildTime = ValueOrExpr.Concrete 31300.0
          health = ValueOrExpr.Concrete 560.0
          sightDistance = ValueOrExpr.Concrete 143.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/CORUWMMM.s3o"
          buildPic = Some "CORUWMMM.DDS"
          script = Some "Units/coruwmmm.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeBuildingExplosionGeneric"
          selfDestructAs = Some "hugeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "120 120 120"
          collisionVolumeType = Some "Ell"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "ooooooooooooooooooooooooo"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0 -2.2497558593e-05 -0.0"
                collisionVolumeScales = Some "60.0 29.4457550049 60.0"
                collisionVolumeType = Some "Box"
                damage = Some 300.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 20.0
                metal = Some 242.0
                object_ = Some "Units/coruwmmm_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 150.0
                featureDead = None
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 4.0
                metal = Some 97.0
                object_ = Some "Units/cor5X5A.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = None
              repair = None
              working = Some "metlrun2"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = []
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = []
              select = ["metlon2"] })
          customParams = Map.ofList [
              "energyconv_capacity", "600.0"
              "energyconv_efficiency", "0.01724"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "CorBuildings/SeaEconomy"
              "techlevel", "2.0"
              "unitgroup", "metal"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
          ] }

    let coruwms : UnitDef =
        { name = "coruwms"
          subfolder = "CorBuildings/SeaEconomy"
          metalCost = ValueOrExpr.Concrete 340.0
          energyCost = ValueOrExpr.Concrete 590.0
          buildTime = ValueOrExpr.Concrete 2920.0
          health = ValueOrExpr.Concrete 2100.0
          sightDistance = ValueOrExpr.Concrete 169.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/CORUWMS.s3o"
          buildPic = Some "CORUWMS.DDS"
          script = Some "Units/CORUWMS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric-uw"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd-uw"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
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
                collisionVolumeOffsets = Some "0.0 8.00781250021e-06 -0.0"
                collisionVolumeScales = Some "80.0 48.7014160156 80.0"
                collisionVolumeType = Some "Box"
                damage = Some 2100.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 228.0
                object_ = Some "Units/coruwms_dead.s3o"
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
              "buildinggrounddecaltype", "decals/coruwms_aoplane.dds"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "CorBuildings/SeaEconomy"
              "unitgroup", "metal"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
          ] }

    let all : (string * UnitDef) list =
        [
            "corfmkr", corfmkr
            "cortide", cortide
            "coruwadves", coruwadves
            "coruwadvms", coruwadvms
            "coruwageo", coruwageo
            "coruwes", coruwes
            "coruwfus", coruwfus
            "coruwgeo", coruwgeo
            "coruwmme", coruwmme
            "coruwmmm", coruwmmm
            "coruwms", coruwms
        ]
