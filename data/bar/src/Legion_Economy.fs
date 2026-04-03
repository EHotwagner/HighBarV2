// Auto-generated BAR unit data: Legion/Economy
namespace BarData.Units

open BarData

module Legion_Economy =

    let legadveconv : UnitDef =
        { name = "legadveconv"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 370.0
          energyCost = ValueOrExpr.Concrete 21000.0
          buildTime = ValueOrExpr.Concrete 31300.0
          health = ValueOrExpr.Concrete 560.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/LEGADVECONV.s3o"
          buildPic = Some "LEGADVECONV.DDS"
          script = Some "Units/LEGADVECONV.cob"
          corpse = Some "DEAD"
          explodeAs = Some "advmetalmaker"
          selfDestructAs = Some "advmetalmakerSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "71 30 61"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "oooooooooooooooo"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "71 30 61"
                collisionVolumeType = Some "CylY"
                damage = Some 300.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 228.0
                object_ = Some "Units/legadveconv_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 150.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 4.0
                metal = Some 91.0
                object_ = Some "Units/cor4X4A.s3o"
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
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "6.0"
              "buildinggrounddecalsizey", "6.0"
              "buildinggrounddecaltype", "decals/legadveconv_aoplane.dds"
              "energyconv_capacity", "600.0"
              "energyconv_efficiency", "0.01724"
              "flashlightmin", "0.8"
              "model_author", "Protar"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "Legion/Economy"
              "techlevel", "2.0"
              "unitgroup", "metal"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
          ] }

    let legadvestore : UnitDef =
        { name = "legadvestore"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 840.0
          energyCost = ValueOrExpr.Concrete 11000.0
          buildTime = ValueOrExpr.Concrete 20400.0
          health = ValueOrExpr.Concrete 12700.0
          sightDistance = ValueOrExpr.Concrete 192.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/LEGADVESTORE.s3o"
          buildPic = Some "LEGADVESTORE.DDS"
          script = Some "Units/LEGADVESTORE.cob"
          corpse = Some "DEAD"
          explodeAs = Some "advenergystorage"
          selfDestructAs = Some "advenergystorageSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "83 55 74"
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
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "83 55 74"
                collisionVolumeType = Some "CylY"
                damage = Some 4560.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 9.0
                metal = Some 514.0
                object_ = Some "Units/legadvestore_dead.s3o"
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
              "buildinggrounddecaltype", "decals/legadvestore_aoplane.dds"
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "Legion/Economy"
              "techlevel", "2.0"
              "unitgroup", "energy"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "7822.0"
          ] }

    let legadvsol : UnitDef =
        { name = "legadvsol"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 465.0
          energyCost = ValueOrExpr.Concrete 4080.0
          buildTime = ValueOrExpr.Concrete 13580.0
          health = ValueOrExpr.Concrete 1100.0
          sightDistance = ValueOrExpr.Concrete 280.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/LEGADVSOL.s3o"
          buildPic = Some "LEGADVSOL.DDS"
          script = Some "Units/LEGADVSOL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingexplosiongeneric"
          selfDestructAs = Some "smallBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "60 44 60"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 100.0)
              metalMake = None
              energyStorage = Some 150.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "ooooo ooooo ooooo ooooo ooooo"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -9 0"
                collisionVolumeScales = Some "70 36 70"
                collisionVolumeType = Some "Ell"
                damage = Some 450.0
                featureDead = Some "HEAP"
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 20.0
                metal = Some 320.0
                object_ = Some "Units/legadvsol_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 225.0
                featureDead = None
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 4.0
                metal = Some 140.0
                object_ = Some "Units/cor5X5C.s3o"
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
              select = ["solar2"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/legadvsol_aoplane.dds"
              "buildinggrounddecalsizey", "7.0"
              "buildinggrounddecalsizex", "7.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "energy"
              "model_author", "EnderRobo"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "solar", "true"
              "subfolder", "Legion/economy"
          ]
          extras = Map.ofList [
              "buildangle", "33000.0"
          ] }

    let legafus : UnitDef =
        { name = "legafus"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 10500.0
          energyCost = ValueOrExpr.Concrete 69000.0
          buildTime = ValueOrExpr.Concrete 340000.0
          health = ValueOrExpr.Concrete 9400.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/LEGAFUS.s3o"
          buildPic = Some "LEGAFUS.DDS"
          script = Some "Units/LEGAFUS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "customfusionexplo"
          selfDestructAs = Some "advancedFusionExplosionSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "111 103 110"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 3300.0)
              metalMake = None
              energyStorage = Some 9000.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooooooooooooooooooooooooooooooooooo"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "111 103 110"
                collisionVolumeType = Some "Box"
                damage = Some 16290.0
                featureDead = Some "HEAP"
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 40.0
                metal = Some 6441.0
                object_ = Some "Units/legafus_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "96.0 14.0 6.0"
                collisionVolumeType = Some "box"
                damage = Some 8145.0
                featureDead = None
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 4.0
                metal = Some 2576.0
                object_ = Some "Units/arm4X4A.s3o"
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
              select = ["fusion1"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "10.0"
              "buildinggrounddecalsizey", "10.0"
              "buildinggrounddecaltype", "decals/legafus_aoplane.dds"
              "model_author", "Protar/Ghoulish"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "Legion/Economy"
              "techlevel", "2.0"
              "unitgroup", "energy"
              "restrictions_inclusion", "_nofusion_"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "4096.0"
              "damagemodifier", "0.95"
          ] }

    let legageo : UnitDef =
        { name = "legageo"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 1600.0
          energyCost = ValueOrExpr.Concrete 27000.0
          buildTime = ValueOrExpr.Concrete 49950.0
          health = ValueOrExpr.Concrete 4150.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/LEGAGEO.s3o"
          buildPic = Some "LEGAGEO.DDS"
          script = Some "Units/LEGAGEO.cob"
          corpse = None
          explodeAs = Some "customfusionexplo"
          selfDestructAs = Some "advgeo"
          collisionVolumeOffsets = Some "0 0 0"
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
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/legageo_aoplane.dds"
              "buildinggrounddecalsizey", "10.0"
              "buildinggrounddecalsizex", "10.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "energy"
              "cvbuildable", "true"
              "geothermal", "1.0"
              "model_author", "Tharsis"
              "normaltex", "unittextures/LEG_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "CorBuildings/LandEconomy"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "buildangle", "0.0"
          ] }

    let legamstor : UnitDef =
        { name = "legamstor"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 760.0
          energyCost = ValueOrExpr.Concrete 11000.0
          buildTime = ValueOrExpr.Concrete 20500.0
          health = ValueOrExpr.Concrete 11200.0
          sightDistance = ValueOrExpr.Concrete 182.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/legamstor.s3o"
          buildPic = Some "legamstor.DDS"
          script = Some "Units/legamstor.cob"
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
                object_ = Some "Units/legamstor_dead.s3o"
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
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/legamstor_aoplane.dds"
              "buildinggrounddecalsizey", "6.0"
              "buildinggrounddecalsizex", "6.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "metal"
              "model_author", "Protar"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "CorBuildings/SeaEconomy"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "buildangle", "6093.0"
          ] }

    let legeconv : UnitDef =
        { name = "legeconv"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 1.0
          energyCost = ValueOrExpr.Concrete 1150.0
          buildTime = ValueOrExpr.Concrete 2600.0
          health = ValueOrExpr.Concrete 167.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/legeconv.s3o"
          buildPic = Some "legeconv.DDS"
          script = Some "Units/legeconv.cob"
          corpse = None
          explodeAs = Some "metalmaker"
          selfDestructAs = Some "metalmakerSelfd"
          collisionVolumeOffsets = Some "0 -3 0"
          collisionVolumeScales = Some "40 40 40"
          collisionVolumeType = Some "CYLY"
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
              select = ["metlon1"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/legeconv_aoplane.dds"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "metal"
              "energyconv_capacity", "70.0"
              "model_author", "Protar"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/LandEconomy"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
          ] }

    let legestor : UnitDef =
        { name = "legestor"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 175.0
          energyCost = ValueOrExpr.Concrete 1800.0
          buildTime = ValueOrExpr.Concrete 4260.0
          health = ValueOrExpr.Concrete 2000.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/LEGESTOR.s3o"
          buildPic = Some "LEGESTOR.DDS"
          script = Some "Units/LEGESTOR.cob"
          corpse = Some "DEAD"
          explodeAs = Some "energystorage"
          selfDestructAs = Some "energystorageSelfd"
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "60 35 60"
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
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "-1.1330871582 -3.52050781238e-05 -0.0"
                collisionVolumeScales = Some "61.5478820801 36.5253295898 59.2817077637"
                collisionVolumeType = Some "Box"
                damage = Some 1080.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 108.0
                object_ = Some "Units/legestor_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 540.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 4.0
                metal = Some 43.0
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
              select = ["storngy2"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/legestor_aoplane.dds"
              "buildinggrounddecalsizey", "6.0"
              "buildinggrounddecalsizex", "6.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "energy"
              "model_author", "Protar"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "Legion/economy"
          ]
          extras = Map.ofList [
              "buildangle", "8196.0"
          ] }

    let legfus : UnitDef =
        { name = "legfus"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 4000.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 66000.0
          health = ValueOrExpr.Concrete 4600.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 6.0
          footprintZ = 5.0
          objectName = Some "Units/LEGFUS.s3o"
          buildPic = Some "LEGFUS.DDS"
          script = Some "Units/LEGFUS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "fusionExplosion"
          selfDestructAs = Some "fusionExplosionSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "101 67 69"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 950.0)
              metalMake = None
              energyStorage = Some 2500.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooooo oooooo oooooo oooooo oooooo"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "101 67 69"
                collisionVolumeType = Some "Box"
                damage = Some 2700.0
                featureDead = Some "HEAP"
                footprintX = Some 6.0
                footprintZ = Some 5.0
                height = Some 40.0
                metal = Some 2603.0
                object_ = Some "Units/legfus_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 1350.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 4.0
                metal = Some 1041.0
                object_ = Some "Units/arm4X4A.s3o"
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
              select = ["fusion1"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "10.0"
              "buildinggrounddecalsizey", "10.0"
              "buildinggrounddecaltype", "decals/legfus_aoplane.dds"
              "model_author", "Protar"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "Legion/Economy"
              "techlevel", "2.0"
              "unitgroup", "energy"
              "restrictions_inclusion", "_nofusion_"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "4096.0"
              "hidedamage", "true"
          ] }

    let leggeo : UnitDef =
        { name = "leggeo"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 560.0
          energyCost = ValueOrExpr.Concrete 13000.0
          buildTime = ValueOrExpr.Concrete 12900.0
          health = ValueOrExpr.Concrete 2050.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/LEGGEO.s3o"
          buildPic = Some "LEGGEO.DDS"
          script = Some "Units/LEGGEO.cob"
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
                object_ = Some "Units/leggeo_dead.s3o"
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
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/leggeo_aoplane.dds"
              "buildinggrounddecalsizey", "8.0"
              "buildinggrounddecalsizex", "8.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "energy"
              "cvbuildable", "true"
              "geothermal", "1.0"
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "Legion/Economy"
          ]
          extras = Map.ofList [
              "buildangle", "4096.0"
          ] }

    let legmex : UnitDef =
        { name = "legmex"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 50.0
          energyCost = ValueOrExpr.Concrete 500.0
          buildTime = ValueOrExpr.Concrete 1880.0
          health = ValueOrExpr.Concrete 275.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/LEGMEX.s3o"
          buildPic = Some "LEGMEX.DDS"
          script = Some "Units/LEGMEX.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallBuildingexplosiongeneric"
          selfDestructAs = Some "smallMex"
          collisionVolumeOffsets = Some "0 -3 0"
          collisionVolumeScales = Some "48 30 48"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = Some "CANBEUW"
          movement = None
          builder = None
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = None
              metalStorage = Some 50.0
              extractsMetal = Some 0.0008 })
          building = Some (
            { yardMap = Some "h cbbbbbbc bsbssbsb bbobbobb bsbbbbsb bsbbbbsb bbobbobb bsbssbsb cbbbbbbc"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "-3.07257080078 -0.112374182129 0.00819396972656"
                collisionVolumeScales = Some "61.0307312012 23.0310516357 47.5323181152"
                collisionVolumeType = Some "Box"
                damage = Some 105.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 33.0
                object_ = Some "Units/legmex_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 53.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 13.0
                object_ = Some "Units/cor3X3E.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = None
              repair = None
              working = Some "mexworking"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = []
              select = ["mexselect"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/legmex_aoplane.dds"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "metal"
              "cvbuildable", "true"
              "metal_extractor", "1.0"
              "model_author", "Protar"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "CorBuildings/LandEconomy"
          ]
          extras = Map.ofList [
              "buildangle", "2048.0"
              "energyupkeep", "-7.0"
              "onoffable", "true"
              "selfdestructcountdown", "1.0"
          ] }

    let legmext15 : UnitDef =
        { name = "legmext15"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 250.0
          energyCost = ValueOrExpr.Concrete 5000.0
          buildTime = ValueOrExpr.Concrete 5000.0
          health = ValueOrExpr.Concrete 1110.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/LEGMEXT15.s3o"
          buildPic = Some "LEGMEXT15.DDS"
          script = Some "Units/LEGMEXT15.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingexplosiongeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -3 0"
          collisionVolumeScales = Some "48 30 48"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = Some "CANBEUW"
          movement = None
          builder = None
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = None
              metalStorage = Some 150.0
              extractsMetal = Some 0.002 })
          building = Some (
            { yardMap = Some "h cbbbbbbc bssssssb bssobssb bsbbbosb bsobbbsb bssbossb bssssssb cbbbbbbc"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "-3.07257080078 -0.112374182129 0.00819396972656"
                collisionVolumeScales = Some "61.0307312012 23.0310516357 47.5323181152"
                collisionVolumeType = Some "Box"
                damage = Some 105.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 150.0
                object_ = Some "Units/LEGMEXT15_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 53.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 75.0
                object_ = Some "Units/cor3X3E.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = None
              repair = None
              working = Some "mexworking"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = []
              select = ["mexselect"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/legmext15_aoplane.dds"
              "buildinggrounddecalsizey", "6.0"
              "buildinggrounddecalsizex", "6.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "metal"
              "cvbuildable", "true"
              "metal_extractor", "1.0"
              "model_author", "Protar"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "CorBuildings/LandEconomy"
          ]
          extras = Map.ofList [
              "buildangle", "2048.0"
              "energyupkeep", "30.0"
              "onoffable", "true"
              "selfdestructcountdown", "1.0"
          ] }

    let legmoho : UnitDef =
        { name = "legmoho"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 640.0
          energyCost = ValueOrExpr.Concrete 8100.0
          buildTime = ValueOrExpr.Concrete 14100.0
          health = ValueOrExpr.Concrete 3900.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/legmoho.s3o"
          buildPic = Some "legmoho.DDS"
          script = Some "Units/legmoho.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "70 40 70"
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
                collisionVolumeOffsets = Some "0.0 0.0263531005859 -0.0"
                collisionVolumeScales = Some "85.8415527344 30.0151062012 74.3409423828"
                collisionVolumeType = Some "Box"
                damage = Some 2100.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 20.0
                metal = Some 318.0
                object_ = Some "Units/legmoho_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 1050.0
                featureDead = None
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 4.0
                metal = Some 137.0
                object_ = Some "Units/cor5X5A.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = None
              repair = None
              working = Some "mohorun2"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = []
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["twractv3"]
              select = ["mohoon2"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/legmoho_aoplane.dds"
              "buildinggrounddecalsizey", "8.0"
              "buildinggrounddecalsizex", "8.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "metal"
              "cvbuildable", "true"
              "metal_extractor", "4.0"
              "model_author", "Protar"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "CorBuildings/LandEconomy"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "buildangle", "2048.0"
              "energyupkeep", "20.0"
              "onoffable", "true"
          ] }

    let legmohobp : UnitDef =
        { name = "legmohobp"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 640.0
          energyCost = ValueOrExpr.Concrete 8100.0
          buildTime = ValueOrExpr.Concrete 14100.0
          health = ValueOrExpr.Concrete 3900.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/legmohobp.s3o"
          buildPic = Some "LEGMOHOBP.DDS"
          script = Some "Units/legmohobp.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "70 40 70"
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
                collisionVolumeOffsets = Some "0.0 0.0263531005859 -0.0"
                collisionVolumeScales = Some "85.8415527344 30.0151062012 74.3409423828"
                collisionVolumeType = Some "Box"
                damage = Some 2100.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 20.0
                metal = Some 318.0
                object_ = Some "Units/legmoho_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 1050.0
                featureDead = None
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 4.0
                metal = Some 137.0
                object_ = Some "Units/cor5X5A.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = None
              repair = None
              working = Some "mohorun2"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = []
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["twractv3"]
              select = ["mohoon2"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/legmohobp_aoplane.dds"
              "buildinggrounddecalsizey", "8.0"
              "buildinggrounddecalsizex", "8.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "metal"
              "cvbuildable", "true"
              "metal_extractor", "4.0"
              "model_author", "Protar"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "CorBuildings/LandEconomy"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "buildangle", "2048.0"
              "energyupkeep", "20.0"
              "onoffable", "true"
          ] }

    let legmohobpct : UnitDef =
        { name = "legmohobpct"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 1.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 10.0
          health = ValueOrExpr.Concrete 5125.0
          sightDistance = ValueOrExpr.Concrete 380.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/LEGMOHOBPCT.s3o"
          buildPic = Some "LEGMOHOBP.DDS"
          script = Some "Units/LEGMOHOBPCT.cob"
          corpse = None
          explodeAs = Some ""
          selfDestructAs = Some ""
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "0 0 0"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          movement = None
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = Some (
            { build = None
              repair = None
              working = None
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["vcormove"]
              select = ["vcorsel"] })
          customParams = Map.ofList [
              "unitgroup", "builder"
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "paralyzemultiplier", "0.1"
              "subfolder", "CorBuildings/LandUtil"
          ]
          extras = Map.ofList [
              "damagemodifier", "0.0"
              "reclaimable", "false"
              "capturable", "false"
              "stealth", "true"
              "upright", "true"
          ] }

    let legmohocon : UnitDef =
        { name = "legmohocon"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 1060.0
          energyCost = ValueOrExpr.Concrete 14500.0
          buildTime = ValueOrExpr.Concrete 19400.0
          health = ValueOrExpr.Concrete 3900.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/legmohocon.s3o"
          buildPic = Some "LEGMOHOCON.DDS"
          script = Some "Units/legmohocon.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "70 40 70"
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
              metalStorage = Some 600.0
              extractsMetal = Some 0.004 })
          building = Some (
            { yardMap = Some "h oooooooo osssssso osssssso ossoosso ossoosso osssssso osssssso oooooooo"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0 0.0263531005859 -0.0"
                collisionVolumeScales = Some "85.8415527344 30.0151062012 74.3409423828"
                collisionVolumeType = Some "Box"
                damage = Some 2100.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 20.0
                metal = Some 318.0
                object_ = Some "Units/legmohocon_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 1050.0
                featureDead = None
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 4.0
                metal = Some 137.0
                object_ = Some "Units/cor5X5A.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = None
              repair = None
              working = Some "mohorun2"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = []
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["twractv3"]
              select = ["mohoon2"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/legmohocon_aoplane.dds"
              "buildinggrounddecalsizey", "7.0"
              "buildinggrounddecalsizex", "7.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "metal"
              "cvbuildable", "true"
              "metal_extractor", "4.0"
              "model_author", "Tharsis and Protar"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "scav_swap_override_created", "null"
              "scav_swap_override_captured", "null"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "buildangle", "2048.0"
              "energyupkeep", "20.0"
              "onoffable", "true"
          ] }

    let legmohoconct : UnitDef =
        { name = "legmohoconct"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 1060.0
          energyCost = ValueOrExpr.Concrete 14500.0
          buildTime = ValueOrExpr.Concrete 19400.0
          health = ValueOrExpr.Concrete 3900.0
          sightDistance = ValueOrExpr.Concrete 380.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/LEGMOHOCON.s3o"
          buildPic = Some "LEGMOHOCON.DDS"
          script = Some "Units/legmohoconct.cob"
          corpse = None
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "31 32 31"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = Some (
            { build = Some "nanlath2"
              repair = Some "repair2"
              working = Some "reclaim1"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = Some "capture1"
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["vcormove"]
              select = ["vcorsel"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/legmohocon_aoplane.dds"
              "buildinggrounddecalsizey", "7.0"
              "buildinggrounddecalsizex", "7.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "builder"
              "model_author", "Tharsis and Protar"
              "normaltex", "unittextures/leg_normal.dds"
              "scav_swap_override_created", "delete"
              "scav_swap_override_captured", "legmohocon"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "canassist", "true"
              "canfight", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canreclaim", "true"
              "canstop", "true"
              "cantbetransported", "true"
              "usePieceCollisionVolumes", "true"
              "mass", "700.0"
              "onoffable", "true"
              "upright", "true"
              "icontype", "legmohocon"
          ] }

    let legmohoconin : UnitDef =
        { name = "legmohoconin"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 1060.0
          energyCost = ValueOrExpr.Concrete 14500.0
          buildTime = ValueOrExpr.Concrete 19400.0
          health = ValueOrExpr.Concrete 3900.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/legmohocon.s3o"
          buildPic = Some "LEGMOHOCON.DDS"
          script = Some "Units/legmohoconin.cob"
          corpse = Some "DEAD"
          explodeAs = Some ""
          selfDestructAs = Some ""
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "7 4 7"
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
              metalStorage = Some 600.0
              extractsMetal = Some 0.004 })
          building = Some (
            { yardMap = Some "h oooooooo osssssso osssssso ossoosso ossoosso osssssso osssssso oooooooo"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = None
          sounds = Some (
            { build = None
              repair = None
              working = Some "mohorun2"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = []
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["twractv3"]
              select = ["mohoon2"] })
          customParams = Map.ofList [
              "unitgroup", "metal"
              "cvbuildable", "true"
              "metal_extractor", "4.0"
              "model_author", "Tharsis and Protar"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "scav_swap_override_created", "delete"
              "scav_swap_override_captured", "delete"
              "subfolder", "CorBuildings/LandEconomy"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "buildangle", "2048.0"
              "energyupkeep", "20.0"
              "onoffable", "true"
              "icontype", "legmohocon"
          ] }

    let legmstor : UnitDef =
        { name = "legmstor"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 340.0
          energyCost = ValueOrExpr.Concrete 590.0
          buildTime = ValueOrExpr.Concrete 2920.0
          health = ValueOrExpr.Concrete 2100.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/legmstor.s3o"
          buildPic = Some "LEGMSTOR.DDS"
          script = Some "Units/legmstor.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingexplosiongeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -10 0"
          collisionVolumeScales = Some "64 60 64"
          collisionVolumeType = Some "Box"
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
            { yardMap = Some "oooo oooo oooo oooo"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "80 40 80"
                collisionVolumeType = Some "Box"
                damage = Some 1567.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 20.0
                metal = Some 208.0
                object_ = Some "Units/legmstor_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 784.0
                featureDead = None
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 4.0
                metal = Some 83.0
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
              select = ["stormtl2"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/legmstor_aoplane.dds"
              "buildinggrounddecalsizey", "6.0"
              "buildinggrounddecalsizex", "6.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "metal"
              "model_author", "Protar"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "CorBuildings/LandEconomy"
          ]
          extras = Map.empty }

    let legrampart : UnitDef =
        { name = "legrampart"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 2600.0
          energyCost = ValueOrExpr.Concrete 38000.0
          buildTime = ValueOrExpr.Concrete 36000.0
          health = ValueOrExpr.Concrete 8600.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/legrampart.s3o"
          buildPic = Some "legrampart.DDS"
          script = Some "Units/legrampart.cob"
          corpse = None
          explodeAs = Some "advenergystorage"
          selfDestructAs = Some "advenergystorageSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "96 86 96"
          collisionVolumeType = Some "cylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.0
              maxAcc = 0.0
              maxDec = 4.5
              turnRate = 1.0
              movementClass = None
              maxSlope = Some 20.0
              maxWaterDepth = Some 5.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "fmd_rocket"
                displayName = Some "ICBM intercepting missile launcher"
                weaponType = Some "StarburstLauncher"
                damage = Map.ofList [
                    "default", 1500.0
                ]
                range = Some (ValueOrExpr.Concrete 72000.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.0)
                weaponVelocity = Some 6000.0
                areaOfEffect = Some 420.0
                accuracy = None
                turret = None
                tolerance = Some 7000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "antinukelaunch"
                soundHit = Some "xplomed4"
                explosiongenerator = Some "custom:antinuke"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "ALL"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "cegtag", "antimissiletrail"
                    "collideenemy", "false"
                    "collidefeature", "false"
                    "collidefriendly", "false"
                    "coverage", "1600.0"
                    "craterareaofeffect", "420.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "7500.0"
                    "firestarter", "100.0"
                    "flighttime", "20.0"
                    "interceptor", "1.0"
                    "metalpershot", "150.0"
                    "model", "leghomingmissile.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "10.0"
                    "smoketime", "110.0"
                    "smokesize", "27.0"
                    "smokecolor", "0.7"
                    "smokeTrailCastShadow", "true"
                    "soundhitwet", "splslrg"
                    "stockpile", "true"
                    "stockpiletime", "90.0"
                    "texture1", "bluenovaexplo"
                    "texture2", "smoketrailbar"
                    "texture3", "null"
                    "tracks", "true"
                    "turnrate", "10000.0"
                    "weaponacceleration", "150.0"
                    "weapontimer", "2.5"
                ] }
              { name = "plasma"
                displayName = Some "HeavyCannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = Some (ValueOrExpr.Concrete 1600.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.5)
                weaponVelocity = Some 360.0
                areaOfEffect = Some 4.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some ""
                soundHit = Some ""
                explosiongenerator = Some ""
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "carried_unit", "legheavydrone"
                    "spawns_surface", "LAND"
                    "carrierdeaththroe", "release"
                    "dockingpieces", "10 11 12"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "hightrajectory", "1.0"
                    "size", "0.0"
                    "soundhitwet", ""
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 600.0)
              metalMake = None
              energyStorage = Some 4000.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "h cbyybsygbc bsbssbbssb gsbsbssbby ybsssbsssy sbsbsssbsb bsbsssbsbs ysssbsssby ybbssbsbsg bssbbssbsb cbgysbyybc"
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
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/legrampart_aoplane.dds"
              "buildinggrounddecalsizey", "10.0"
              "buildinggrounddecalsizex", "10.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "energy"
              "restrictions_exclusion", "_noantinuke_"
              "cvbuildable", "true"
              "geothermal", "1.0"
              "model_author", "Tharsis"
              "normaltex", "unittextures/LEG_normal.dds"
              "removewait", "true"
              "subfolder", "CorBuildings/LandEconomy"
              "techlevel", "2.0"
              "inheritxpratemultiplier", "1.0"
              "childreninheritxp", "DRONE"
              "parentsinheritxp", "DRONE"
          ]
          extras = Map.ofList [
              "buildangle", "4096.0"
              "radardistancejam", "500.0"
              "radardistance", "2100.0"
              "radaremitheight", "72.0"
              "mass", "20000.0"
              "nochasecategory", "VTOL"
              "upright", "true"
          ] }

    let legsolar : UnitDef =
        { name = "legsolar"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 155.0
          energyCost = ValueOrExpr.Concrete 0.0
          buildTime = ValueOrExpr.Concrete 2800.0
          health = ValueOrExpr.Concrete 340.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/LEGSOLAR.s3o"
          buildPic = Some "LEGSOLAR.DDS"
          script = Some "Units/LEGSOLAR.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallBuildingexplosiongeneric"
          selfDestructAs = Some "smallBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0.0 -18.0 1.0"
          collisionVolumeScales = Some "50.0 76.0 50.0"
          collisionVolumeType = Some "Ell"
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
            { yardMap = Some "yoooyoooooooooooooooyoooy"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -10 1"
                collisionVolumeScales = Some "40 76 40"
                collisionVolumeType = Some "Ell"
                damage = Some 184.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 20.0
                metal = Some 75.0
                object_ = Some "Units/legsolar_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 92.0
                featureDead = None
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 4.0
                metal = Some 30.0
                object_ = Some "Units/arm5X5B.s3o"
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
              select = ["solar1"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/legsolar_aoplane.dds"
              "buildinggrounddecalsizey", "8.0"
              "buildinggrounddecalsizex", "8.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "energy"
              "model_author", "Hornet"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "solar", "true"
              "subfolder", "Legion/economy"
          ]
          extras = Map.ofList [
              "buildangle", "4000.0"
              "damagemodifier", "0.5"
              "energyupkeep", "-20.0"
              "onoffable", "true"
          ] }

    let legwin : UnitDef =
        { name = "legwin"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 45.0
          energyCost = ValueOrExpr.Concrete 175.0
          buildTime = ValueOrExpr.Concrete 1680.0
          health = ValueOrExpr.Concrete 230.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/LEGWIN.s3o"
          buildPic = Some "LEGWIN.DDS"
          script = Some "Units/LEGWIN.cob"
          corpse = Some "DEAD"
          explodeAs = Some "windboom"
          selfDestructAs = Some "windboom"
          collisionVolumeOffsets = Some "0 2 0"
          collisionVolumeScales = Some "34 89 34"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 0.5
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "ooo ooo ooo"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "34 89 34"
                collisionVolumeType = Some "cylY"
                damage = Some 107.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 27.0
                object_ = Some "Units/legwin_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 54.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 11.0
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
              select = ["windgen"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/legwin_aoplane.dds"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "energy"
              "model_author", "Yzch"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "CorBuildings/LandEconomy"
          ]
          extras = Map.ofList [
              "windgenerator", "25.0"
          ] }

    let all : (string * UnitDef) list =
        [
            "legadveconv", legadveconv
            "legadvestore", legadvestore
            "legadvsol", legadvsol
            "legafus", legafus
            "legageo", legageo
            "legamstor", legamstor
            "legeconv", legeconv
            "legestor", legestor
            "legfus", legfus
            "leggeo", leggeo
            "legmex", legmex
            "legmext15", legmext15
            "legmoho", legmoho
            "legmohobp", legmohobp
            "legmohobpct", legmohobpct
            "legmohocon", legmohocon
            "legmohoconct", legmohoconct
            "legmohoconin", legmohoconin
            "legmstor", legmstor
            "legrampart", legrampart
            "legsolar", legsolar
            "legwin", legwin
        ]
