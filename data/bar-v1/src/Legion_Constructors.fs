// Auto-generated BAR unit data: Legion/Constructors
namespace BarData.V1.Units

open BarData.V1

module Legion_Constructors =

    let legaca : UnitDef =
        { name = "legaca"
          subfolder = "Legion/Constructors"
          metalCost = ValueOrExpr.Concrete 330.0
          energyCost = ValueOrExpr.Concrete 11000.0
          buildTime = ValueOrExpr.Concrete 17500.0
          health = ValueOrExpr.Concrete 195.0
          sightDistance = ValueOrExpr.Concrete 383.5
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/legaca.s3o"
          buildPic = Some "LEGACA.DDS"
          script = Some "Units/legaca.cob"
          corpse = None
          explodeAs = Some "smallexplosiongeneric-builder"
          selfDestructAs = Some "smallExplosionGenericSelfd-builder"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 203.0
              maxAcc = 0.075
              maxDec = 0.4275
              turnRate = 240.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 360.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 70.0
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 115.0
              buildDistance = Some 136.0
              buildOptions = []
              terraformSpeed = Some 650.0 })
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 10.0)
              metalMake = None
              energyStorage = Some 50.0
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = None
          sounds = Some (
            { build = Some "nanlath2"
              repair = Some "repair2"
              working = Some "reclaim1"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["vtolcrmv"]
              select = ["vtolcrac"] })
          customParams = Map.ofList [
              "unitgroup", "buildert2"
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Constructors"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "collide", "true"
              "hoverattack", "true"
              "radardistance", "50.0"
          ] }

    let legaceb : UnitDef =
        { name = "legaceb"
          subfolder = "Legion/Constructors"
          metalCost = ValueOrExpr.Concrete 310.0
          energyCost = ValueOrExpr.Concrete 5600.0
          buildTime = ValueOrExpr.Concrete 9500.0
          health = ValueOrExpr.Concrete 830.0
          sightDistance = ValueOrExpr.Concrete 520.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/legaceb.s3o"
          buildPic = Some "LEGACEB.DDS"
          script = Some "Units/legaceb.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallbuilder"
          selfDestructAs = Some "smallbuilderSelfd"
          collisionVolumeOffsets = Some "0 1 0"
          collisionVolumeScales = Some "30 26 30"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 75.0
              maxAcc = 0.2
              maxDec = 1.45
              turnRate = 640.0
              movementClass = Some "TBOT3"
              maxSlope = Some 50.0
              maxWaterDepth = Some 22.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 2.0
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 125.0
              buildDistance = Some 136.0
              buildOptions = []
              terraformSpeed = Some 750.0 })
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 15.0)
              metalMake = None
              energyStorage = Some 100.0
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "26 16 26"
                collisionVolumeType = Some "Cyly"
                damage = Some 600.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 125.0
                object_ = Some "Units/legaceb_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 500.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 50.0
                object_ = Some "Units/cor2X2D.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = Some "nanlath2"
              repair = Some "repair2"
              working = Some "reclaim1"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = Some "capture2"
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["kbcormov"]
              select = ["kbcorsel"] })
          customParams = Map.ofList [
              "unitgroup", "buildert2"
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/constructors"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "upright", "false"
          ] }

    let legack : UnitDef =
        { name = "legack"
          subfolder = "Legion/Constructors"
          metalCost = ValueOrExpr.Concrete 410.0
          energyCost = ValueOrExpr.Concrete 6900.0
          buildTime = ValueOrExpr.Concrete 9300.0
          health = ValueOrExpr.Concrete 860.0
          sightDistance = ValueOrExpr.Concrete 318.5
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/legack.s3o"
          buildPic = Some "LEGACK.DDS"
          script = Some "Units/LEGACK.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric-builder"
          selfDestructAs = Some "smallExplosionGenericSelfd-builder"
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "25 38 28"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 36.0
              maxAcc = 0.4692
              maxDec = 2.9325
              turnRate = 1075.25
              movementClass = Some "BOT2"
              maxSlope = Some 20.0
              maxWaterDepth = Some 25.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 0.726
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 195.0
              buildDistance = Some 136.0
              buildOptions = []
              terraformSpeed = Some 900.0 })
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 14.0)
              metalMake = None
              energyStorage = Some 100.0
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0 -1.31450195313e-05 -8.2949829102"
                collisionVolumeScales = Some "25.0 26.11277771 27.3265991211"
                collisionVolumeType = Some "Box"
                damage = Some 800.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 207.0
                object_ = Some "Units/legack_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 600.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 83.0
                object_ = Some "Units/cor2X2B.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = Some "nanlath2"
              repair = Some "repair2"
              working = Some "reclaim1"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = Some "capture2"
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["kbcormov"]
              select = ["kbcorsel"] })
          customParams = Map.ofList [
              "unitgroup", "buildert2"
              "area_mex_def", "legmoho"
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "CorBots/T2"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "radardistance", "50.0"
              "upright", "false"
          ] }

    let legacv : UnitDef =
        { name = "legacv"
          subfolder = "Legion/Constructors"
          metalCost = ValueOrExpr.Concrete 530.0
          energyCost = ValueOrExpr.Concrete 6600.0
          buildTime = ValueOrExpr.Concrete 11900.0
          health = ValueOrExpr.Concrete 1950.0
          sightDistance = ValueOrExpr.Concrete 295.10001
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/legacv.s3o"
          buildPic = Some "LEGACV.DDS"
          script = Some "Units/legacv.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric-builder"
          selfDestructAs = Some "mediumExplosionGenericSelfd-builder"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "40 24 55"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 55.5
              maxAcc = 0.02547
              maxDec = 0.05093
              turnRate = 363.0
              movementClass = Some "TANK3"
              maxSlope = Some 16.0
              maxWaterDepth = Some 18.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.1616
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 270.0
              buildDistance = Some 136.0
              buildOptions = []
              terraformSpeed = Some 1250.0 })
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 20.0)
              metalMake = None
              energyStorage = Some 100.0
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "36 22 55"
                collisionVolumeType = Some "Box"
                damage = Some 1500.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 294.0
                object_ = Some "Units/legacv_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 1000.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 118.0
                object_ = Some "Units/cor3X3A.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
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
              "unitgroup", "buildert2"
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Constructors"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "leavetracks", "true"
              "radardistance", "50.0"
              "trackstrength", "6.0"
              "tracktype", "corwidetracks"
              "trackwidth", "28.0"
          ] }

    let legafcv : UnitDef =
        { name = "legafcv"
          subfolder = "Legion/Constructors"
          metalCost = ValueOrExpr.Concrete 200.0
          energyCost = ValueOrExpr.Concrete 2900.0
          buildTime = ValueOrExpr.Concrete 4000.0
          health = ValueOrExpr.Concrete 450.0
          sightDistance = ValueOrExpr.Concrete 400.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/legafcv.s3o"
          buildPic = Some "legafcv.DDS"
          script = Some "Units/legafcv.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallexplosiongeneric-builder"
          selfDestructAs = Some "smallExplosionGenericSelfd-builder"
          collisionVolumeOffsets = Some "0 -3 0"
          collisionVolumeScales = Some "20 17 30"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 110.0
              maxAcc = 0.07029
              maxDec = 0.14059
              turnRate = 635.0
              movementClass = Some "TANK2"
              maxSlope = Some 18.0
              maxWaterDepth = Some 18.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.83678
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 120.0
              buildDistance = Some 110.0
              buildOptions = []
              terraformSpeed = Some 750.0 })
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 10.0)
              metalMake = None
              energyStorage = Some 50.0
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "20 17 30"
                collisionVolumeType = Some "Box"
                damage = Some 800.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 80.0
                object_ = Some "Units/legafcv_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 700.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 45.0
                object_ = Some "Units/arm3X3A.s3o"
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
              ok = ["tarmmove"]
              select = ["tarmsel"] })
          customParams = Map.ofList [
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Constructors"
              "techlevel", "2.0"
              "unitgroup", "buildert2"
          ]
          extras = Map.ofList [
              "leavetracks", "true"
              "trackoffset", "10.0"
              "trackstrength", "5.0"
              "tracktype", "armgremlin_tracks"
              "trackwidth", "35.0"
          ] }

    let leganavyconsub : UnitDef =
        { name = "leganavyconsub"
          subfolder = "Legion/Constructors"
          metalCost = ValueOrExpr.Concrete 700.0
          energyCost = ValueOrExpr.Concrete 9000.0
          buildTime = ValueOrExpr.Concrete 18000.0
          health = ValueOrExpr.Concrete 1110.0
          sightDistance = ValueOrExpr.Concrete 156.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/leganavyconsub.s3o"
          buildPic = Some "leganavyconsub.DDS"
          script = Some "Units/leganavyconsub.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric-uw"
          selfDestructAs = Some "mediumexplosiongenericSelfd-uw"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "30 30 71"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 64.8
              maxAcc = 0.042
              maxDec = 0.042
              turnRate = 385.5
              movementClass = Some "UBOAT4"
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 20.0
              waterline = Some 80.0 })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 345.0
              buildDistance = Some 180.0
              buildOptions = []
              terraformSpeed = Some 1500.0 })
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 30.0)
              metalMake = None
              energyStorage = Some 150.0
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "30 30 71"
                collisionVolumeType = Some "Box"
                damage = Some 444.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 350.0
                object_ = Some "Units/leganavyconsub_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 1432.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 175.0
                object_ = Some "Units/cor4X4C.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = Some "nanlath1"
              repair = Some "repair1"
              working = Some "reclaim1"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = Some "capture1"
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["sucormov"]
              select = ["sucorsel"] })
          customParams = Map.ofList [
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Constructors"
              "techlevel", "2.0"
              "unitgroup", "buildert2"
          ]
          extras = Map.ofList [
              "radardistance", "50.0"
          ] }

    let leganavyengineer : UnitDef =
        { name = "leganavyengineer"
          subfolder = "Legion/Constructors"
          metalCost = ValueOrExpr.Concrete 200.0
          energyCost = ValueOrExpr.Concrete 3300.0
          buildTime = ValueOrExpr.Concrete 4800.0
          health = ValueOrExpr.Concrete 1600.0
          sightDistance = ValueOrExpr.Concrete 300.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/leganavyengineer.s3o"
          buildPic = Some "leganavyengineer.DDS"
          script = Some "Units/leganavyengineer.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumexplosiongenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "30 30 49"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 57.75
              maxAcc = 0.03446
              maxDec = 0.03446
              turnRate = 393.0
              movementClass = Some "BOAT3"
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = true
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 15.0
              waterline = Some 0.0 })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 200.0
              buildDistance = Some 250.0
              buildOptions = []
              terraformSpeed = Some 2000.0 })
          weapons = None
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "30 25 49"
                collisionVolumeType = Some "Box"
                damage = Some 1726.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 100.0
                object_ = Some "Units/leganavyengineer_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 4032.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 50.0
                object_ = Some "Units/cor4X4A.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = Some "nanlath2"
              repair = Some "repair2"
              working = Some "reclaim1"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["shcormov"]
              select = ["shcorsel"] })
          customParams = Map.ofList [
              "minesweeper", "600.0"
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Constructors"
              "techlevel", "2.0"
              "unitgroup", "buildert2"
          ]
          extras = Map.ofList [
              "movestate", "0.0"
          ] }

    let legca : UnitDef =
        { name = "legca"
          subfolder = "Legion/Constructors"
          metalCost = ValueOrExpr.Concrete 105.0
          energyCost = ValueOrExpr.Concrete 3200.0
          buildTime = ValueOrExpr.Concrete 7560.0
          health = ValueOrExpr.Concrete 151.0
          sightDistance = ValueOrExpr.Concrete 351.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/LEGCA.s3o"
          buildPic = Some "LEGCA.DDS"
          script = Some "Units/LEGCA.cob"
          corpse = None
          explodeAs = Some "smallexplosiongeneric"
          selfDestructAs = Some "smallExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 215.0
              maxAcc = 0.07
              maxDec = 0.4275
              turnRate = 240.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 360.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 75.0
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 55.0
              buildDistance = Some 136.0
              buildOptions = []
              terraformSpeed = Some 225.0 })
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 5.0)
              metalMake = None
              energyStorage = Some 25.0
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = None
          sounds = Some (
            { build = Some "nanlath2"
              repair = Some "repair2"
              working = Some "reclaim1"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["vtolcrmv"]
              select = ["vtolcrac"] })
          customParams = Map.ofList [
              "unitgroup", "builder"
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "CorAircraft"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "collide", "true"
              "hoverattack", "true"
              "radardistance", "50.0"
          ] }

    let legch : UnitDef =
        { name = "legch"
          subfolder = "Legion/Constructors"
          metalCost = ValueOrExpr.Concrete 185.0
          energyCost = ValueOrExpr.Concrete 2600.0
          buildTime = ValueOrExpr.Concrete 4360.0
          health = ValueOrExpr.Concrete 1390.0
          sightDistance = ValueOrExpr.Concrete 338.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/LEGCH.s3o"
          buildPic = Some "LEGCH.DDS"
          script = Some "Units/LEGCH_CLEAN.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallexplosiongeneric-builder"
          selfDestructAs = Some "smallExplosionGenericSelfd-builder"
          collisionVolumeOffsets = Some "0 1 0"
          collisionVolumeScales = Some "27 18 38"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 72.9
              maxAcc = 0.049
              maxDec = 0.11
              turnRate = 410.0
              movementClass = Some "HOVER3"
              maxSlope = Some 16.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.518
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 105.0
              buildDistance = Some 150.0
              buildOptions = ["legsolar"; "legadvsol"; "legwin"; "leggeo"; "legmstor"; "legestor"; "legmex"; "legmext15"; "legeconv"; "leglab"; "legvp"; "legap"; "leghp"; "legavp"; "legnanotc"; "legnanotcplat"; "legeyes"; "legrad"; "legdrag"; "legdtr"; "leglht"; "legmg"; "legcluster"; "legrl"; "legrhapsis"; "leglupara"; "legjuno"; "legctl"; "legjam"; "legfhp"; "legamphlab"; "legsplab"; "legsy"; "legtide"; "legfeconv"; "leguwmstore"; "leguwestore"; "legfdrag"; "legfrad"; "legfmg"; "legfrl"; "legtl"; "leguwgeo"; "legadvshipyard"; "leghive"; "legfhive"]
              terraformSpeed = Some 550.0 })
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 11.0)
              metalMake = None
              energyStorage = Some 75.0
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "27 18 38"
                collisionVolumeType = Some "Box"
                damage = Some 805.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 100.0
                object_ = Some "Units/legch_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 403.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 40.0
                object_ = Some "Units/cor3X3D.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = Some "nanlath1"
              repair = Some "repair1"
              working = Some "reclaim1"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["hovmdok2"]
              select = ["hovmdsl2"] })
          customParams = Map.ofList [
              "unitgroup", "builder"
              "model_author", "EnderRobo"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "CorHovercraft"
          ]
          extras = Map.ofList [
              "radardistance", "50.0"
          ] }

    let legck : UnitDef =
        { name = "legck"
          subfolder = "Legion/Constructors"
          metalCost = ValueOrExpr.Concrete 100.0
          energyCost = ValueOrExpr.Concrete 1600.0
          buildTime = ValueOrExpr.Concrete 3250.0
          health = ValueOrExpr.Concrete 630.0
          sightDistance = ValueOrExpr.Concrete 299.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/LEGCK.s3o"
          buildPic = Some "LEGCK.DDS"
          script = Some "Units/LEGCK.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallexplosiongeneric-builder"
          selfDestructAs = Some "smallExplosionGenericSelfd-builder"
          collisionVolumeOffsets = Some "0 0 -1"
          collisionVolumeScales = Some "22 27 22"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 39.0
              maxAcc = 0.58
              maxDec = 3.6
              turnRate = 1300.0
              movementClass = Some "BOT2"
              maxSlope = Some 20.0
              maxWaterDepth = Some 25.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 0.759
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 75.0
              buildDistance = Some 130.0
              buildOptions = []
              terraformSpeed = Some 450.0 })
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 5.0)
              metalMake = None
              energyStorage = Some 50.0
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "-0.363754272461 2.60498046867e-05 -3.5"
                collisionVolumeScales = Some "20 26 26"
                collisionVolumeType = Some "Box"
                damage = Some 454.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 73.0
                object_ = Some "Units/legck_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 277.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 29.0
                object_ = Some "Units/cor2X2F.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = Some "nanlath2"
              repair = Some "repair2"
              working = Some "reclaim1"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = Some "capture2"
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["kbcormov"]
              select = ["kbcorsel"] })
          customParams = Map.ofList [
              "unitgroup", "builder"
              "area_mexT15_def", "legmext15"
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "CorBots"
          ]
          extras = Map.ofList [
              "upright", "false"
          ] }

    let legcv : UnitDef =
        { name = "legcv"
          subfolder = "Legion/Constructors"
          metalCost = ValueOrExpr.Concrete 125.0
          energyCost = ValueOrExpr.Concrete 2100.0
          buildTime = ValueOrExpr.Concrete 3900.0
          health = ValueOrExpr.Concrete 1330.0
          sightDistance = ValueOrExpr.Concrete 260.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/LEGCV.s3o"
          buildPic = Some "LEGCV.DDS"
          script = Some "Units/LEGCV.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric-builder"
          selfDestructAs = Some "mediumExplosionGenericSelfd-builder"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "32 21 45"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 57.0
              maxAcc = 0.036
              maxDec = 0.14
              turnRate = 445.0
              movementClass = Some "TANK3"
              maxSlope = Some 16.0
              maxWaterDepth = Some 19.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.1979
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 85.0
              buildDistance = Some 130.0
              buildOptions = []
              terraformSpeed = Some 450.0 })
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 7.0)
              metalMake = None
              energyStorage = Some 50.0
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.31364440918 1.09863281317e-06 0.657264709473"
                collisionVolumeScales = Some "32.9147644043 17.5585021973 49.4168548584"
                collisionVolumeType = Some "Box"
                damage = Some 874.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 87.0
                object_ = Some "Units/legcv_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 487.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 35.0
                object_ = Some "Units/cor3X3D.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
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
              "unitgroup", "builder"
              "area_mexT15_def", "legmext15"
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "CorVehicles"
          ]
          extras = Map.ofList [
              "leavetracks", "true"
              "radardistance", "50.0"
              "trackoffset", "3.0"
              "trackstrength", "6.0"
              "tracktype", "corwidetracks"
              "trackwidth", "32.0"
          ] }

    let leghack : UnitDef =
        { name = "leghack"
          subfolder = "Legion/Constructors"
          metalCost = ValueOrExpr.Concrete 1240.0
          energyCost = ValueOrExpr.Concrete 22400.0
          buildTime = ValueOrExpr.Concrete 38000.0
          health = ValueOrExpr.Concrete 830.0
          sightDistance = ValueOrExpr.Concrete 520.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/legaceb.s3o"
          buildPic = Some "LEGACEB.DDS"
          script = Some "Units/legaceb.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallbuilder"
          selfDestructAs = Some "smallbuilderSelfd"
          collisionVolumeOffsets = Some "0 1 0"
          collisionVolumeScales = Some "30 26 30"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 75.0
              maxAcc = 0.2
              maxDec = 1.45
              turnRate = 640.0
              movementClass = Some "TBOT3"
              maxSlope = Some 50.0
              maxWaterDepth = Some 22.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 2.0
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 600.0
              buildDistance = Some 136.0
              buildOptions = ["legafus"; "leggant"; "legageo"; "legrampart"; "legmoho"; "legadveconv"; "legadvestore"; "legamstor"; "legforti"; "legtarg"; "legdeflector"; "legacluster"; "legapopupdef"; "legbastion"; "legflak"; "leglraa"; "legperdition"; "legabm"; "legsilo"; "leglrpc"; "legstarfall"; "legalab"; "leghalab"; "legvp"; "legap"; "legsy"; "legnanotc"; "legfus"; "legsd"; "leglab"; "legeheatraymech"; "legelrpcmech"]
              terraformSpeed = Some 750.0 })
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 15.0)
              metalMake = None
              energyStorage = Some 100.0
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "26 16 26"
                collisionVolumeType = Some "Cyly"
                damage = Some 600.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 125.0
                object_ = Some "Units/legaceb_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 500.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 50.0
                object_ = Some "Units/cor2X2D.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = Some "nanlath2"
              repair = Some "repair2"
              working = Some "reclaim1"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = Some "capture2"
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["kbcormov"]
              select = ["kbcorsel"] })
          customParams = Map.ofList [
              "unitgroup", "buildert2"
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/constructors"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "upright", "false"
          ] }

    let leghacv : UnitDef =
        { name = "leghacv"
          subfolder = "Legion/Constructors"
          metalCost = ValueOrExpr.Concrete 800.0
          energyCost = ValueOrExpr.Concrete 9400.0
          buildTime = ValueOrExpr.Concrete 16800.0
          health = ValueOrExpr.Concrete 450.0
          sightDistance = ValueOrExpr.Concrete 400.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/legafcv.s3o"
          buildPic = Some "legafcv.DDS"
          script = Some "Units/legafcv.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallexplosiongeneric-builder"
          selfDestructAs = Some "smallExplosionGenericSelfd-builder"
          collisionVolumeOffsets = Some "0 -3 0"
          collisionVolumeScales = Some "20 17 30"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 110.0
              maxAcc = 0.07029
              maxDec = 0.14059
              turnRate = 635.0
              movementClass = Some "TANK2"
              maxSlope = Some 18.0
              maxWaterDepth = Some 18.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.83678
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 400.0
              buildDistance = Some 110.0
              buildOptions = ["legafus"; "leggant"; "legageo"; "legrampart"; "legmoho"; "legadveconv"; "legadvestore"; "legamstor"; "legforti"; "legtarg"; "legdeflector"; "legacluster"; "legapopupdef"; "legbastion"; "legflak"; "leglraa"; "legperdition"; "legabm"; "legsilo"; "leglrpc"; "legstarfall"; "legavp"; "leghavp"; "legvp"; "legap"; "legsy"; "legnanotc"; "legfus"; "legsd"; "leglab"; "legeheatraymech"; "legelrpcmech"]
              terraformSpeed = Some 750.0 })
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 10.0)
              metalMake = None
              energyStorage = Some 50.0
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "20 17 30"
                collisionVolumeType = Some "Box"
                damage = Some 800.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 80.0
                object_ = Some "Units/legafcv_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 700.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 45.0
                object_ = Some "Units/arm3X3A.s3o"
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
              ok = ["tarmmove"]
              select = ["tarmsel"] })
          customParams = Map.ofList [
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Constructors"
              "techlevel", "2.0"
              "unitgroup", "buildert2"
          ]
          extras = Map.ofList [
              "leavetracks", "true"
              "trackoffset", "10.0"
              "trackstrength", "5.0"
              "tracktype", "armgremlin_tracks"
              "trackwidth", "35.0"
          ] }

    let legnavyconship : UnitDef =
        { name = "legnavyconship"
          subfolder = "Legion/Constructors"
          metalCost = ValueOrExpr.Concrete 180.0
          energyCost = ValueOrExpr.Concrete 2000.0
          buildTime = ValueOrExpr.Concrete 3500.0
          health = ValueOrExpr.Concrete 1080.0
          sightDistance = ValueOrExpr.Concrete 400.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/legnavyconship.s3o"
          buildPic = Some "legnavyconship.DDS"
          script = Some "Units/legnavyconship.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric-builder"
          selfDestructAs = Some "mediumexplosiongenericSelfd-builder"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "42 33 50"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 71.0
              maxAcc = 0.03567
              maxDec = 0.03567
              turnRate = 391.5
              movementClass = Some "BOAT3"
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = true
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 15.0
              waterline = Some 0.0 })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 115.0
              buildDistance = Some 200.0
              buildOptions = []
              terraformSpeed = Some 1250.0 })
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 5.0)
              metalMake = None
              energyStorage = Some 50.0
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "42 30 50"
                collisionVolumeType = Some "Box"
                damage = Some 1380.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 4.0
                metal = Some 100.0
                object_ = Some "Units/legnavyconship_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 4032.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 50.0
                object_ = Some "Units/cor5X5C.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = Some "nanlath2"
              repair = Some "repair2"
              working = Some "reclaim1"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["shcormov"]
              select = ["shcorsel"] })
          customParams = Map.ofList [
              "model_author", "ZephyrSkies (Model), Phill-Arts (Concept Art)"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Constructors"
              "unitgroup", "builder"
          ]
          extras = Map.empty }

    let legotter : UnitDef =
        { name = "legotter"
          subfolder = "Legion/Constructors"
          metalCost = ValueOrExpr.Concrete 150.0
          energyCost = ValueOrExpr.Concrete 3100.0
          buildTime = ValueOrExpr.Concrete 6540.0
          health = ValueOrExpr.Concrete 950.0
          sightDistance = ValueOrExpr.Concrete 260.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/LEGOTTER.s3o"
          buildPic = Some "LEGOTTER.DDS"
          script = Some "Units/LEGOTTER.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric-phib"
          selfDestructAs = Some "mediumExplosionGenericSelfd-phib"
          collisionVolumeOffsets = Some "0 -1 1"
          collisionVolumeScales = Some "22 16 41"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 43.5
              maxAcc = 0.01722
              maxDec = 0.10332
              turnRate = 300.0
              movementClass = Some "ATANK3"
              maxSlope = Some 16.0
              maxWaterDepth = Some 255.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 0.9504
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 75.0
              buildDistance = Some 110.0
              buildOptions = []
              terraformSpeed = Some 400.0 })
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 8.0)
              metalMake = None
              energyStorage = None
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "-1.3500289917 4.80712890649e-06 3.49253082275"
                collisionVolumeScales = Some "25.27003479 12.0197296143 44.3021697998"
                collisionVolumeType = Some "Box"
                damage = Some 697.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 105.0
                object_ = Some "Units/legotter_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 299.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 42.0
                object_ = Some "Units/cor3X3C.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
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
              "unitgroup", "builder"
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "CorVehicles"
          ]
          extras = Map.ofList [
              "leavetracks", "true"
              "trackoffset", "8.0"
              "trackstrength", "5.0"
              "tracktype", "corwidetracks"
              "trackwidth", "24.0"
          ] }

    let legspcon : UnitDef =
        { name = "legspcon"
          subfolder = "Legion/Constructors"
          metalCost = ValueOrExpr.Concrete 150.0
          energyCost = ValueOrExpr.Concrete 7800.0
          buildTime = ValueOrExpr.Concrete 12000.0
          health = ValueOrExpr.Concrete 405.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/legspcon.s3o"
          buildPic = Some "legspcon.DDS"
          script = Some "Units/legspcon.cob"
          corpse = None
          explodeAs = Some "smallexplosiongeneric-builder"
          selfDestructAs = Some "smallExplosionGenericSelfd-builder"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 192.0
              maxAcc = 0.07
              maxDec = 0.4275
              turnRate = 240.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 255.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 360.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 50.0
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 75.0
              buildDistance = Some 136.0
              buildOptions = []
              terraformSpeed = Some 300.0 })
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 20.0)
              metalMake = None
              energyStorage = Some 75.0
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = None
          sounds = Some (
            { build = Some "nanlath1"
              repair = Some "repair1"
              working = Some "reclaim1"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["vtolcrmv"]
              select = ["seapsel1"] })
          customParams = Map.ofList [
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Constructors"
              "unitgroup", "builder"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "cansubmerge", "true"
              "collide", "true"
              "hoverattack", "true"
          ] }

    let all : (string * UnitDef) list =
        [
            "legaca", legaca
            "legaceb", legaceb
            "legack", legack
            "legacv", legacv
            "legafcv", legafcv
            "leganavyconsub", leganavyconsub
            "leganavyengineer", leganavyengineer
            "legca", legca
            "legch", legch
            "legck", legck
            "legcv", legcv
            "leghack", leghack
            "leghacv", leghacv
            "legnavyconship", legnavyconship
            "legotter", legotter
            "legspcon", legspcon
        ]
