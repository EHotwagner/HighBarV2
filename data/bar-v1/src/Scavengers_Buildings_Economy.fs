// Auto-generated BAR unit data: Scavengers/Buildings/Economy
namespace BarData.V1.Units

open BarData.V1

module Scavengers_Buildings_Economy =

    let armafust3 : UnitDef =
        { name = "armafust3"
          subfolder = "Scavengers/Buildings/Economy"
          metalCost = ValueOrExpr.Concrete 90000.0
          energyCost = ValueOrExpr.Concrete 550000.0
          buildTime = ValueOrExpr.Concrete 2500000.0
          health = ValueOrExpr.Concrete 7900.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 12.0
          footprintZ = 12.0
          objectName = Some "Units/ARMAFUST3.s3o"
          buildPic = Some "ARMAFUS.DDS"
          script = Some "Units/ARMAFUS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "ScavComBossExplo"
          selfDestructAs = Some "ScavComBossExplo"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "192 192 192"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 30000.0)
              metalMake = None
              energyStorage = Some 90000.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "192 192 192"
                collisionVolumeType = Some "Box"
                damage = Some 16290.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 4.0
                height = Some 40.0
                metal = Some 64410.0
                object_ = Some "Units/armafust3_dead.s3o"
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
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 4.0
                metal = Some 25760.0
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
              "buildinggrounddecalsizex", "18.0"
              "buildinggrounddecalsizey", "18.0"
              "buildinggrounddecaltype", "decals/armafus_aoplane.dds"
              "model_author", "Cremuss"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/LandEconomy"
              "techlevel", "3.0"
              "unitgroup", "energy"
              "restrictions_inclusion", "_nofusion_"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "4096.0"
              "damagemodifier", "0.95"
          ] }

    let armmmkrt3 : UnitDef =
        { name = "armmmkrt3"
          subfolder = "Scavengers/Buildings/Economy"
          metalCost = ValueOrExpr.Concrete 9000.0
          energyCost = ValueOrExpr.Concrete 550000.0
          buildTime = ValueOrExpr.Concrete 350000.0
          health = ValueOrExpr.Concrete 1500.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 8.0
          footprintZ = 8.0
          objectName = Some "Units/ARMMMKRT3.s3o"
          buildPic = Some "ARMMMKR.DDS"
          script = Some "Units/ARMMMKR.cob"
          corpse = Some "DEAD"
          explodeAs = Some "fusionExplosion"
          selfDestructAs = Some "fusionExplosion"
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
            { yardMap = Some "oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "-0.574371337891 -22.1292811768 1.24842834473"
                collisionVolumeScales = Some "120.6127624512 104.6148376465 120.6127624512"
                collisionVolumeType = Some "Box"
                damage = Some 240.0
                featureDead = Some "HEAP"
                footprintX = Some 8.0
                footprintZ = Some 8.0
                height = Some 20.0
                metal = Some 233.0
                object_ = Some "Units/armmmkrt3_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 120.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 4.0
                metal = Some 93.0
                object_ = Some "Units/arm4X4C.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
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
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "12.0"
              "buildinggrounddecalsizey", "12.0"
              "buildinggrounddecaltype", "decals/armmmkr_aoplane.dds"
              "energyconv_capacity", "6000.0"
              "energyconv_efficiency", "0.02"
              "model_author", "Cremuss"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/LandEconomy"
              "techlevel", "3.0"
              "unitgroup", "metal"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
          ] }

    let armwint2 : UnitDef =
        { name = "armwint2"
          subfolder = "Scavengers/Buildings/Economy"
          metalCost = ValueOrExpr.Concrete 370.0
          energyCost = ValueOrExpr.Concrete 1750.0
          buildTime = ValueOrExpr.Concrete 16000.0
          health = ValueOrExpr.Concrete 1960.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/scavbuildings/ARMWINT2.s3o"
          buildPic = Some "ARMWINT2.DDS"
          script = Some "Units/scavbuildings/ARMWINT2.cob"
          corpse = Some "DEAD"
          explodeAs = Some "windboom"
          selfDestructAs = Some "windboom"
          collisionVolumeOffsets = Some "0 1 0"
          collisionVolumeScales = Some "68 174 68"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 5.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooooo oooooo oooooo oooooo oooooo oooooo"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 1 0"
                collisionVolumeScales = Some "68 174 68"
                collisionVolumeType = Some "CylY"
                damage = Some 1125.0
                featureDead = None
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 40.0
                metal = Some 222.0
                object_ = Some "Units/scavbuildings/armwint2_dead.s3o"
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
              select = ["windgen"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/armwint2_aoplane.dds"
              "buildinggrounddecalsizey", "9.0"
              "buildinggrounddecalsizex", "9.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "energy"
              "energymultiplier", "10.0"
              "model_author", "Cremuss"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/LandEconomy"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "windgenerator", "500.0"
          ] }

    let corafust3 : UnitDef =
        { name = "corafust3"
          subfolder = "Scavengers/Buildings/Economy"
          metalCost = ValueOrExpr.Concrete 90000.0
          energyCost = ValueOrExpr.Concrete 550000.0
          buildTime = ValueOrExpr.Concrete 2500000.0
          health = ValueOrExpr.Concrete 9400.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 12.0
          footprintZ = 12.0
          objectName = Some "Units/CORAFUST3.s3o"
          buildPic = Some "CORAFUS.DDS"
          script = Some "Units/CORAFUS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "ScavComBossExplo"
          selfDestructAs = Some "ScavComBossExplo"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "188 192 188"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 30000.0)
              metalMake = None
              energyStorage = Some 90000.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "188 192 188"
                collisionVolumeType = Some "CylY"
                damage = Some 17100.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 64400.0
                object_ = Some "Units/corafust3_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 8550.0
                featureDead = None
                footprintX = Some 5.0
                footprintZ = Some 4.0
                height = Some 4.0
                metal = Some 2576.0
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
              select = ["fusion2"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "18.0"
              "buildinggrounddecalsizey", "18.0"
              "buildinggrounddecaltype", "decals/corafus_aoplane.dds"
              "model_author", "Cremuss"
              "normaltex", "unittextures/cor_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "CorBuildings/LandEconomy"
              "techlevel", "3.0"
              "unitgroup", "energy"
              "restrictions_inclusion", "_nofusion_"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "4096.0"
              "damagemodifier", "0.95"
          ] }

    let cormmkrt3 : UnitDef =
        { name = "cormmkrt3"
          subfolder = "Scavengers/Buildings/Economy"
          metalCost = ValueOrExpr.Concrete 9000.0
          energyCost = ValueOrExpr.Concrete 550000.0
          buildTime = ValueOrExpr.Concrete 350000.0
          health = ValueOrExpr.Concrete 1500.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 8.0
          footprintZ = 8.0
          objectName = Some "Units/CORMMKRT3.s3o"
          buildPic = Some "CORMMKR.DDS"
          script = Some "Units/CORMMKR.cob"
          corpse = Some "DEAD"
          explodeAs = Some "fusionExplosion"
          selfDestructAs = Some "fusionExplosion"
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
            { yardMap = Some "oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0 -2.96020507804e-05 0.388763427734"
                collisionVolumeScales = Some "122.3712463379 106.8299407959 120.5937194824"
                collisionVolumeType = Some "Box"
                damage = Some 300.0
                featureDead = Some "HEAP"
                footprintX = Some 8.0
                footprintZ = Some 8.0
                height = Some 20.0
                metal = Some 228.0
                object_ = Some "Units/cormmkrt3_dead.s3o"
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
              "buildinggrounddecalsizex", "12.0"
              "buildinggrounddecalsizey", "12.0"
              "buildinggrounddecaltype", "decals/cormmkr_aoplane.dds"
              "energyconv_capacity", "6000.0"
              "energyconv_efficiency", "0.02"
              "flashlightmin", "0.8"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "CorBuildings/LandEconomy"
              "techlevel", "3.0"
              "unitgroup", "metal"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
          ] }

    let corwint2 : UnitDef =
        { name = "corwint2"
          subfolder = "Scavengers/Buildings/Economy"
          metalCost = ValueOrExpr.Concrete 450.0
          energyCost = ValueOrExpr.Concrete 1750.0
          buildTime = ValueOrExpr.Concrete 17000.0
          health = ValueOrExpr.Concrete 1990.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/scavbuildings/CORWINT2.s3o"
          buildPic = Some "CORWINT2.DDS"
          script = Some "Units/scavbuildings/CORWINT2.cob"
          corpse = Some "DEAD"
          explodeAs = Some "windboom"
          selfDestructAs = Some "windboom"
          collisionVolumeOffsets = Some "0 2 0"
          collisionVolumeScales = Some "68 178 68"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 5.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooooo oooooo oooooo oooooo oooooo oooooo"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 2 0"
                collisionVolumeScales = Some "68 178 68"
                collisionVolumeType = Some "CylY"
                damage = Some 1125.0
                featureDead = None
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 20.0
                metal = Some 270.0
                object_ = Some "Units/scavbuildings/CORWINT2_dead.s3o"
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
              select = ["windgen"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/corwint2_aoplane.dds"
              "buildinggrounddecalsizey", "9.0"
              "buildinggrounddecalsizex", "9.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "energy"
              "energymultiplier", "10.0"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "CorBuildings/LandEconomy"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "windgenerator", "500.0"
          ] }

    let legadveconvt3 : UnitDef =
        { name = "legadveconvt3"
          subfolder = "Scavengers/Buildings/Economy"
          metalCost = ValueOrExpr.Concrete 9000.0
          energyCost = ValueOrExpr.Concrete 550000.0
          buildTime = ValueOrExpr.Concrete 350000.0
          health = ValueOrExpr.Concrete 1500.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 8.0
          footprintZ = 8.0
          objectName = Some "Units/LEGADVECONVT3.s3o"
          buildPic = Some "LEGADVECONV.DDS"
          script = Some "Units/LEGADVECONV.cob"
          corpse = Some "DEAD"
          explodeAs = Some "fusionExplosion"
          selfDestructAs = Some "fusionExplosion"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "142 60 122"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "142 60 122"
                collisionVolumeType = Some "CylY"
                damage = Some 300.0
                featureDead = Some "HEAP"
                footprintX = Some 8.0
                footprintZ = Some 8.0
                height = Some 20.0
                metal = Some 228.0
                object_ = Some "Units/legadveconvt3_dead.s3o"
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
              "buildinggrounddecalsizex", "12.0"
              "buildinggrounddecalsizey", "12.0"
              "buildinggrounddecaltype", "decals/cormmkr_aoplane.dds"
              "energyconv_capacity", "6000.0"
              "energyconv_efficiency", "0.02"
              "flashlightmin", "0.8"
              "model_author", "Protar"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "Legion/Economy"
              "techlevel", "3.0"
              "unitgroup", "metal"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
          ] }

    let legafust3 : UnitDef =
        { name = "legafust3"
          subfolder = "Scavengers/Buildings/Economy"
          metalCost = ValueOrExpr.Concrete 90000.0
          energyCost = ValueOrExpr.Concrete 550000.0
          buildTime = ValueOrExpr.Concrete 2500000.0
          health = ValueOrExpr.Concrete 7900.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 12.0
          footprintZ = 12.0
          objectName = Some "Units/LEGAFUST3.s3o"
          buildPic = Some "LEGAFUS.DDS"
          script = Some "Units/LEGAFUS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "ScavComBossExplo"
          selfDestructAs = Some "ScavComBossExplo"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "222 206 220"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 30000.0)
              metalMake = None
              energyStorage = Some 90000.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "222 206 220"
                collisionVolumeType = Some "Box"
                damage = Some 16290.0
                featureDead = Some "HEAP"
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 40.0
                metal = Some 64410.0
                object_ = Some "Units/legafust3_dead.s3o"
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
              "buildinggrounddecalsizex", "20.0"
              "buildinggrounddecalsizey", "20.0"
              "buildinggrounddecaltype", "decals/legafus_aoplane.dds"
              "model_author", "Protar/Ghoulish"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "Legion/Economy"
              "techlevel", "3.0"
              "unitgroup", "energy"
              "restrictions_inclusion", "_nofusion_"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "4096.0"
              "damagemodifier", "0.95"
          ] }

    let legwint2 : UnitDef =
        { name = "legwint2"
          subfolder = "Scavengers/Buildings/Economy"
          metalCost = ValueOrExpr.Concrete 450.0
          energyCost = ValueOrExpr.Concrete 1750.0
          buildTime = ValueOrExpr.Concrete 17000.0
          health = ValueOrExpr.Concrete 1990.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/scavbuildings/LEGWINT2.s3o"
          buildPic = Some "LEGWIN.DDS"
          script = Some "Units/LEGWINT2.cob"
          corpse = Some "DEAD"
          explodeAs = Some "windboom"
          selfDestructAs = Some "windboom"
          collisionVolumeOffsets = Some "0 2 0"
          collisionVolumeScales = Some "68 178 68"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 5.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooooo oooooo oooooo oooooo oooooo oooooo"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 2 0"
                collisionVolumeScales = Some "68 178 68"
                collisionVolumeType = Some "CylY"
                damage = Some 1125.0
                featureDead = None
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 20.0
                metal = Some 270.0
                object_ = Some "Units/scavbuildings/LEGWINT2_dead.s3o"
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
              select = ["windgen"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/legwint2_aoplane.dds"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "energy"
              "energymultiplier", "10.0"
              "model_author", "Yzch"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "CorBuildings/LandEconomy"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "windgenerator", "500.0"
          ] }

    let all : (string * UnitDef) list =
        [
            "armafust3", armafust3
            "armmmkrt3", armmmkrt3
            "armwint2", armwint2
            "corafust3", corafust3
            "cormmkrt3", cormmkrt3
            "corwint2", corwint2
            "legadveconvt3", legadveconvt3
            "legafust3", legafust3
            "legwint2", legwint2
        ]
