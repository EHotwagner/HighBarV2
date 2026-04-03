// Auto-generated BAR unit data: ArmBuildings/LandFactories (flat per-unit types)
namespace BarData.Units

open BarData

module ArmBuildings_LandFactories =

    type Armaap =
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
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          workerTime: ValueOrExpr<float>
          buildOptions: string list
          terraformSpeed: float
          energyStorage: float
          metalStorage: float
          yardMap: string
          activateWhenBuilt: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armaap : Armaap =
        { name = "armaap"
          subfolder = "ArmBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 2900.0
          energyCost = ValueOrExpr.Concrete 29000.0
          buildTime = ValueOrExpr.Concrete 32000.0
          health = ValueOrExpr.Concrete 3750.0
          sightDistance = ValueOrExpr.Concrete 312.0
          footprintX = 9.0
          footprintZ = 9.0
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          maxSlope = 15.0
          maxWaterDepth = 0.0
          canMove = true
          workerTime = ValueOrExpr.Concrete 600.0
          buildOptions = ["armaca"; "armbrawl"; "armpnix"; "armlance"; "armhawk"; "armawac"; "armdfly"; "armblade"; "armstil"; "armliche"]
          terraformSpeed = 1000.0
          energyStorage = 200.0
          metalStorage = 200.0
          yardMap = "ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo"
          activateWhenBuilt = true
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -17 -23"
                  collisionVolumeScales = Some "106 40 48"
                  collisionVolumeType = Some "Box"
                  damage = Some 2016.0
                  featureDead = Some "HEAP"
                  footprintX = Some 7.0
                  footprintZ = Some 6.0
                  height = Some 20.0
                  metal = Some 1953.0
                  object_ = Some "Units/armaap_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 1008.0
                  featureDead = None
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 4.0
                  metal = Some 977.0
                  object_ = Some "Units/arm6X6A.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["pairactv"] }
          customParams = Map.ofList [
                "airfactory", "true"
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "12.0"
                "buildinggrounddecalsizey", "12.0"
                "buildinggrounddecaltype", "decals/armaap_aoplane.dds"
                "model_author", "Cremuss, Tharsis"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBuildings/LandFactories"
                "techlevel", "2.0"
                "unitgroup", "buildert2"
                "restrictions_inclusion", "_noair_"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "radardistance", "1000.0"
                "radaremitheight", "50.0"
            ] }

    type Armalab =
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
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          workerTime: ValueOrExpr<float>
          buildOptions: string list
          terraformSpeed: float
          energyStorage: float
          metalStorage: float
          yardMap: string
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armalab : Armalab =
        { name = "armalab"
          subfolder = "ArmBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 2600.0
          energyCost = ValueOrExpr.Concrete 15000.0
          buildTime = ValueOrExpr.Concrete 25000.0
          health = ValueOrExpr.Concrete 4250.0
          sightDistance = ValueOrExpr.Concrete 286.0
          footprintX = 9.0
          footprintZ = 9.0
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          maxSlope = 15.0
          maxWaterDepth = 0.0
          canMove = true
          workerTime = ValueOrExpr.Concrete 600.0
          buildOptions = ["armack"; "armfark"; "armfast"; "armamph"; "armzeus"; "armmav"; "armsptk"; "armfido"; "armsnipe"; "armfboy"; "armspid"; "armaak"; "armvader"; "armdecom"; "armscab"; "armaser"; "armspy"; "armmark"]
          terraformSpeed = 1000.0
          energyStorage = 200.0
          metalStorage = 200.0
          yardMap = "ooooooooo ooooooooo ooooooooo ooooooooo eeeeeeeee eeeeeeeee eeeeeeeee eeeeeeeee eeeeeeeee"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -17 -1"
                  collisionVolumeScales = Some "73 56 89"
                  collisionVolumeType = Some "CylZ"
                  damage = Some 2285.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 6.0
                  height = Some 20.0
                  metal = Some 1773.0
                  object_ = Some "Units/armalab_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 1143.0
                  featureDead = None
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 4.0
                  metal = Some 887.0
                  object_ = Some "Units/arm5X5A.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["plabactv"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "12.0"
                "buildinggrounddecalsizey", "12.0"
                "buildinggrounddecaltype", "decals/armalab_aoplane.dds"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBuildings/LandFactories"
                "techlevel", "2.0"
                "unitgroup", "buildert2"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "1024.0"
            ] }

    type Armap =
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
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          workerTime: ValueOrExpr<float>
          buildOptions: string list
          terraformSpeed: float
          energyStorage: float
          metalStorage: float
          yardMap: string
          activateWhenBuilt: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armap : Armap =
        { name = "armap"
          subfolder = "ArmBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 650.0
          energyCost = ValueOrExpr.Concrete 1100.0
          buildTime = ValueOrExpr.Concrete 5450.0
          health = ValueOrExpr.Concrete 2050.0
          sightDistance = ValueOrExpr.Concrete 292.0
          footprintX = 9.0
          footprintZ = 6.0
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          maxSlope = 15.0
          maxWaterDepth = 0.0
          canMove = true
          workerTime = ValueOrExpr.Concrete 150.0
          buildOptions = ["armca"; "armpeep"; "armfig"; "armthund"; "armatlas"; "armkam"; "armhvytrans"]
          terraformSpeed = 500.0
          energyStorage = 100.0
          metalStorage = 100.0
          yardMap = "ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo"
          activateWhenBuilt = true
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "11 -17 -23"
                  collisionVolumeScales = Some "85 39 49"
                  collisionVolumeType = Some "Box"
                  damage = Some 1110.0
                  featureDead = Some "HEAP"
                  footprintX = Some 7.0
                  footprintZ = Some 6.0
                  height = Some 40.0
                  metal = Some 553.0
                  object_ = Some "Units/armap_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 555.0
                  featureDead = None
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 4.0
                  metal = Some 221.0
                  object_ = Some "Units/arm6X6B.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["airplantselect"] }
          customParams = Map.ofList [
                "airfactory", "true"
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "12.0"
                "buildinggrounddecalsizey", "9.0"
                "buildinggrounddecaltype", "decals/armap_aoplane.dds"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBuildings/LandFactories"
                "unitgroup", "builder"
                "restrictions_inclusion", "_noair_"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "radardistance", "510.0"
                "radaremitheight", "40.0"
            ] }

    type Armavp =
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
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          workerTime: ValueOrExpr<float>
          buildOptions: string list
          terraformSpeed: float
          energyStorage: float
          metalStorage: float
          yardMap: string
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armavp : Armavp =
        { name = "armavp"
          subfolder = "ArmBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 2600.0
          energyCost = ValueOrExpr.Concrete 14000.0
          buildTime = ValueOrExpr.Concrete 27000.0
          health = ValueOrExpr.Concrete 4750.0
          sightDistance = ValueOrExpr.Concrete 283.39999
          footprintX = 9.0
          footprintZ = 9.0
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          maxSlope = 15.0
          maxWaterDepth = 0.0
          canMove = true
          workerTime = ValueOrExpr.Concrete 600.0
          buildOptions = ["armacv"; "armconsul"; "armcroc"; "armlatnk"; "armbull"; "armgremlin"; "armmart"; "armmerl"; "armmanni"; "armyork"; "armseer"; "armjam"]
          terraformSpeed = 1000.0
          energyStorage = 200.0
          metalStorage = 200.0
          yardMap = "ooooooooo ooooooooo ooooooooo ooooooooo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -1 2"
                  collisionVolumeScales = Some "96 70 96"
                  collisionVolumeType = Some "Box"
                  damage = Some 2578.0
                  featureDead = Some "HEAP"
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 20.0
                  metal = Some 1754.0
                  object_ = Some "Units/armavp_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 1289.0
                  featureDead = None
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 4.0
                  metal = Some 877.0
                  object_ = Some "Units/arm6X6D.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["pvehactv"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "12.0"
                "buildinggrounddecalsizey", "12.0"
                "buildinggrounddecaltype", "decals/armavp_aoplane.dds"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBuildings/LandFactories"
                "techlevel", "2.0"
                "unitgroup", "buildert2"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "1024.0"
                "levelground", "false"
            ] }

    type Armhaap =
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
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          workerTime: ValueOrExpr<float>
          buildOptions: string list
          terraformSpeed: float
          energyStorage: float
          metalStorage: float
          yardMap: string
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armhaap : Armhaap =
        { name = "armhaap"
          subfolder = "ArmBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 4600.0
          energyCost = ValueOrExpr.Concrete 72000.0
          buildTime = ValueOrExpr.Concrete 85000.0
          health = ValueOrExpr.Concrete 16000.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 15.0
          footprintZ = 15.0
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canMove = true
          workerTime = ValueOrExpr.Concrete 1800.0
          buildOptions = ["armhaca"; "armhawk"; "armpnix"; "armlance"; "armawac"; "armdfly"; "armliche"; "armblade"; "armbrawl"; "armstil"]
          terraformSpeed = 3000.0
          energyStorage = 1400.0
          metalStorage = 800.0
          yardMap = "oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "2.5 0 -0.75"
                  collisionVolumeScales = Some "217 94 290"
                  collisionVolumeType = Some "Box"
                  damage = Some 8640.0
                  featureDead = Some "HEAP"
                  footprintX = Some 14.0
                  footprintZ = Some 14.0
                  height = Some 20.0
                  metal = Some 4807.0
                  object_ = Some "Units/armhaap_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 4320.0
                  featureDead = None
                  footprintX = Some 9.0
                  footprintZ = Some 9.0
                  height = Some 4.0
                  metal = Some 1923.0
                  object_ = Some "Units/arm7X7D.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = Some "seaplok1"
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["seaplsl1"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "16.0"
                "buildinggrounddecalsizey", "16.0"
                "buildinggrounddecaltype", "decals/armaap_aoplane.dds"
                "model_author", "Cremuss, Tharsis"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBuildings/LandFactories"
                "techlevel", "3.0"
                "unitgroup", "buildert3"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "radardistance", "750.0"
                "radaremitheight", "50.0"
            ] }

    type Armhaapuw =
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
          maxSlope: float
          canMove: bool
          minWaterDepth: float
          workerTime: ValueOrExpr<float>
          buildOptions: string list
          terraformSpeed: float
          energyStorage: float
          metalStorage: float
          yardMap: string
          activateWhenBuilt: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armhaapuw : Armhaapuw =
        { name = "armhaapuw"
          subfolder = "ArmBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 1900.0
          energyCost = ValueOrExpr.Concrete 24000.0
          buildTime = ValueOrExpr.Concrete 42000.0
          health = ValueOrExpr.Concrete 3750.0
          sightDistance = ValueOrExpr.Concrete 312.0
          footprintX = 9.0
          footprintZ = 9.0
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          maxSlope = 15.0
          canMove = true
          minWaterDepth = 30.0
          workerTime = ValueOrExpr.Concrete 200.0
          buildOptions = ["armaca"; "armseap"; "armsb"; "armsfig"; "armsehak"; "armsaber"; "armhvytrans"]
          terraformSpeed = 1000.0
          energyStorage = 200.0
          metalStorage = 200.0
          yardMap = "ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo"
          activateWhenBuilt = true
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -17 -23"
                  collisionVolumeScales = Some "106 40 48"
                  collisionVolumeType = Some "Box"
                  damage = Some 2016.0
                  featureDead = Some "HEAP"
                  footprintX = Some 7.0
                  footprintZ = Some 6.0
                  height = Some 20.0
                  metal = Some 1953.0
                  object_ = Some "Units/armhaap_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 1008.0
                  featureDead = None
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 4.0
                  metal = Some 977.0
                  object_ = Some "Units/arm6X6A.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = Some "seaplok1"
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["seaplsl1"] }
          customParams = Map.ofList [
                "airfactory", "true"
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "12.0"
                "buildinggrounddecalsizey", "12.0"
                "buildinggrounddecaltype", "decals/armaap_aoplane.dds"
                "model_author", "Cremuss, Tharsis"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBuildings/LandFactories"
                "techlevel", "2.0"
                "unitgroup", "buildert2"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "radardistance", "1000.0"
                "radaremitheight", "50.0"
            ] }

    type Armhalab =
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
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          workerTime: ValueOrExpr<float>
          buildOptions: string list
          terraformSpeed: float
          energyStorage: float
          metalStorage: float
          yardMap: string
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string> }

    let armhalab : Armhalab =
        { name = "armhalab"
          subfolder = "ArmBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 4800.0
          energyCost = ValueOrExpr.Concrete 58000.0
          buildTime = ValueOrExpr.Concrete 85000.0
          health = ValueOrExpr.Concrete 16000.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 12.0
          footprintZ = 12.0
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canMove = true
          workerTime = ValueOrExpr.Concrete 600.0
          buildOptions = ["armhack"; "armsnipe"; "armfboy"; "armaser"; "armdecom"; "armscab"; "armzeus"; "armmar"; "armspy"; "armaak"]
          terraformSpeed = 3000.0
          energyStorage = 1400.0
          metalStorage = 800.0
          yardMap = "oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee"
          featureDefs = Map.ofList [
                "armshlt_dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "125 75 145"
                  collisionVolumeType = Some "Box"
                  damage = Some 8640.0
                  featureDead = Some "ARMSHLT_HEAP"
                  footprintX = Some 9.0
                  footprintZ = Some 9.0
                  height = Some 20.0
                  metal = Some 4807.0
                  object_ = Some "Units/armshltx_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "armshlt_heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 4320.0
                  featureDead = None
                  footprintX = Some 9.0
                  footprintZ = Some 9.0
                  height = Some 4.0
                  metal = Some 1923.0
                  object_ = Some "Units/arm7X7D.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = Some "gantok2"
                repair = Some "lathelrg"
                working = Some "build"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["gantsel1"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "15.0"
                "buildinggrounddecalsizey", "15.0"
                "buildinggrounddecaltype", "decals/armshltx_aoplane.dds"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBuildings/LandFactories"
                "techlevel", "3.0"
                "unitgroup", "buildert3"
                "usebuildinggrounddecal", "true"
            ] }

    type Armhavp =
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
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          workerTime: ValueOrExpr<float>
          buildOptions: string list
          terraformSpeed: float
          energyStorage: float
          metalStorage: float
          yardMap: string
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string> }

    let armhavp : Armhavp =
        { name = "armhavp"
          subfolder = "ArmBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 4900.0
          energyCost = ValueOrExpr.Concrete 51000.0
          buildTime = ValueOrExpr.Concrete 85000.0
          health = ValueOrExpr.Concrete 16000.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 12.0
          footprintZ = 12.0
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canMove = true
          workerTime = ValueOrExpr.Concrete 600.0
          buildOptions = ["armhacv"; "armbull"; "armmerl"; "armmanni"; "armyork"; "armjam"; "armgremlin"; "armlun"; "armlatnk"]
          terraformSpeed = 3000.0
          energyStorage = 1400.0
          metalStorage = 800.0
          yardMap = "oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "125 75 145"
                  collisionVolumeType = Some "Box"
                  damage = Some 8640.0
                  featureDead = Some "HEAP"
                  footprintX = Some 9.0
                  footprintZ = Some 9.0
                  height = Some 20.0
                  metal = Some 4807.0
                  object_ = Some "Units/armamsub_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 4320.0
                  featureDead = None
                  footprintX = Some 9.0
                  footprintZ = Some 9.0
                  height = Some 4.0
                  metal = Some 1923.0
                  object_ = Some "Units/arm7X7D.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["pvehactv"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "19.0"
                "buildinggrounddecalsizey", "19.0"
                "buildinggrounddecaltype", "decals/armamsub_aoplane.dds"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBuildings/LandFactories"
                "techlevel", "3.0"
                "unitgroup", "buildert3"
                "usebuildinggrounddecal", "true"
            ] }

    type Armhp =
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
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          workerTime: ValueOrExpr<float>
          buildOptions: string list
          terraformSpeed: float
          energyStorage: float
          metalStorage: float
          yardMap: string
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string> }

    let armhp : Armhp =
        { name = "armhp"
          subfolder = "ArmBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 670.0
          energyCost = ValueOrExpr.Concrete 2000.0
          buildTime = ValueOrExpr.Concrete 8700.0
          health = ValueOrExpr.Concrete 3350.0
          sightDistance = ValueOrExpr.Concrete 286.0
          footprintX = 6.0
          footprintZ = 6.0
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          maxSlope = 15.0
          maxWaterDepth = 0.0
          canMove = true
          workerTime = ValueOrExpr.Concrete 150.0
          buildOptions = ["armch"; "armsh"; "armanac"; "armah"; "armmh"]
          terraformSpeed = 1000.0
          energyStorage = 200.0
          metalStorage = 200.0
          yardMap = "oeeeeo oeeeeo oeeeeo oeeeeo oeeeeo oeeeeo"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "116 20 104"
                  collisionVolumeType = Some "Box"
                  damage = Some 1803.0
                  featureDead = Some "HEAP"
                  footprintX = Some 8.0
                  footprintZ = Some 7.0
                  height = Some 20.0
                  metal = Some 621.0
                  object_ = Some "Units/armhp_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 902.0
                  featureDead = None
                  footprintX = Some 8.0
                  footprintZ = Some 7.0
                  height = Some 4.0
                  metal = Some 248.0
                  object_ = Some "Units/arm7X7A.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = Some "hoverok1"
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["hoversl1"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "9.0"
                "buildinggrounddecalsizey", "9.0"
                "buildinggrounddecaltype", "decals/armhp_aoplane.dds"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBuildings/LandFactories"
                "unitgroup", "builder"
                "usebuildinggrounddecal", "true"
                "techlevel", "1.5"
            ] }

    type Armlab =
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
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          workerTime: ValueOrExpr<float>
          buildOptions: string list
          terraformSpeed: float
          energyStorage: float
          metalStorage: float
          yardMap: string
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armlab : Armlab =
        { name = "armlab"
          subfolder = "ArmBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 500.0
          energyCost = ValueOrExpr.Concrete 950.0
          buildTime = ValueOrExpr.Concrete 5000.0
          health = ValueOrExpr.Concrete 2900.0
          sightDistance = ValueOrExpr.Concrete 290.0
          footprintX = 6.0
          footprintZ = 6.0
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          maxSlope = 15.0
          maxWaterDepth = 0.0
          canMove = true
          workerTime = ValueOrExpr.Concrete 150.0
          buildOptions = ["armck"; "armpw"; "armrectr"; "armrock"; "armham"; "armjeth"; "armwar"; "armflea"]
          terraformSpeed = 500.0
          energyStorage = 100.0
          metalStorage = 100.0
          yardMap = "ooooooooooooooooooeeeeeeeeeeeeeeeeee"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -7 0"
                  collisionVolumeScales = Some "95 22 95"
                  collisionVolumeType = Some "Box"
                  damage = Some 1614.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 6.0
                  height = Some 40.0
                  metal = Some 458.0
                  object_ = Some "Units/armlab_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 807.0
                  featureDead = None
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 4.0
                  metal = Some 183.0
                  object_ = Some "Units/arm5X5B.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["labselect"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "9.0"
                "buildinggrounddecalsizey", "9.0"
                "buildinggrounddecaltype", "decals/armlab_aoplane.dds"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBuildings/LandFactories"
                "unitgroup", "builder"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "1024.0"
            ] }

    type Armsaap =
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
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          workerTime: ValueOrExpr<float>
          buildOptions: string list
          terraformSpeed: float
          energyStorage: float
          metalStorage: float
          yardMap: string
          activateWhenBuilt: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armsaap : Armsaap =
        { name = "armsaap"
          subfolder = "ArmBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 3500.0
          energyCost = ValueOrExpr.Concrete 35000.0
          buildTime = ValueOrExpr.Concrete 52000.0
          health = ValueOrExpr.Concrete 3750.0
          sightDistance = ValueOrExpr.Concrete 312.0
          footprintX = 9.0
          footprintZ = 9.0
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          maxSlope = 15.0
          maxWaterDepth = 0.0
          canMove = true
          workerTime = ValueOrExpr.Concrete 200.0
          buildOptions = ["armcsa"; "armpnix"; "armlance"; "armhawk"; "armdfly"; "armblade"; "armstil"; "armliche"; "armsehak"]
          terraformSpeed = 1000.0
          energyStorage = 200.0
          metalStorage = 200.0
          yardMap = "ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo"
          activateWhenBuilt = true
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -17 -23"
                  collisionVolumeScales = Some "106 40 48"
                  collisionVolumeType = Some "Box"
                  damage = Some 2016.0
                  featureDead = Some "HEAP"
                  footprintX = Some 7.0
                  footprintZ = Some 6.0
                  height = Some 20.0
                  metal = Some 1953.0
                  object_ = Some "Units/legaap_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 1008.0
                  featureDead = None
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 4.0
                  metal = Some 977.0
                  object_ = Some "Units/arm6X6A.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["pairactv"] }
          customParams = Map.ofList [
                "airfactory", "true"
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "12.0"
                "buildinggrounddecalsizey", "12.0"
                "buildinggrounddecaltype", "decals/laap_aoplane.dds"
                "model_author", "Cremuss, Tharsis"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBuildings/LandFactories"
                "techlevel", "2.0"
                "unitgroup", "buildert2"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "radardistance", "1000.0"
                "radaremitheight", "50.0"
            ] }

    type Armsalab =
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
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          workerTime: ValueOrExpr<float>
          buildOptions: string list
          terraformSpeed: float
          energyStorage: float
          metalStorage: float
          yardMap: string
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armsalab : Armsalab =
        { name = "armsalab"
          subfolder = "ArmBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 3500.0
          energyCost = ValueOrExpr.Concrete 35000.0
          buildTime = ValueOrExpr.Concrete 51000.0
          health = ValueOrExpr.Concrete 4250.0
          sightDistance = ValueOrExpr.Concrete 286.0
          footprintX = 9.0
          footprintZ = 9.0
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          maxSlope = 15.0
          maxWaterDepth = 0.0
          canMove = true
          workerTime = ValueOrExpr.Concrete 300.0
          buildOptions = ["armsack"; "armsnipe"; "armfboy"; "armsptk"; "armscab"; "armaser"; "armmark"]
          terraformSpeed = 1000.0
          energyStorage = 200.0
          metalStorage = 200.0
          yardMap = "ooooooooo ooooooooo ooooooooo ooooooooo eeeeeeeee eeeeeeeee eeeeeeeee eeeeeeeee eeeeeeeee"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -17 -1"
                  collisionVolumeScales = Some "73 56 89"
                  collisionVolumeType = Some "CylZ"
                  damage = Some 2285.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 6.0
                  height = Some 20.0
                  metal = Some 1773.0
                  object_ = Some "Units/legalab_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 1143.0
                  featureDead = None
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 4.0
                  metal = Some 887.0
                  object_ = Some "Units/arm5X5A.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["plabactv"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "12.0"
                "buildinggrounddecalsizey", "12.0"
                "buildinggrounddecaltype", "decals/armalab_aoplane.dds"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBuildings/LandFactories"
                "techlevel", "2.0"
                "unitgroup", "buildert2"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "1024.0"
            ] }

    type Armsavp =
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
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          workerTime: ValueOrExpr<float>
          buildOptions: string list
          terraformSpeed: float
          energyStorage: float
          metalStorage: float
          yardMap: string
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armsavp : Armsavp =
        { name = "armsavp"
          subfolder = "ArmBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 3500.0
          energyCost = ValueOrExpr.Concrete 35000.0
          buildTime = ValueOrExpr.Concrete 51000.0
          health = ValueOrExpr.Concrete 4750.0
          sightDistance = ValueOrExpr.Concrete 283.39999
          footprintX = 9.0
          footprintZ = 9.0
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          maxSlope = 15.0
          maxWaterDepth = 0.0
          canMove = true
          workerTime = ValueOrExpr.Concrete 300.0
          buildOptions = ["armsacv"; "armgremlin"; "armmerl"; "armmanni"; "armseer"; "armjam"]
          terraformSpeed = 1000.0
          energyStorage = 200.0
          metalStorage = 200.0
          yardMap = "ooooooooo ooooooooo ooooooooo ooooooooo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -1 2"
                  collisionVolumeScales = Some "96 70 96"
                  collisionVolumeType = Some "Box"
                  damage = Some 2578.0
                  featureDead = Some "HEAP"
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 20.0
                  metal = Some 1754.0
                  object_ = Some "Units/legavp_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 1289.0
                  featureDead = None
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 4.0
                  metal = Some 877.0
                  object_ = Some "Units/arm6X6D.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["pvehactv"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "12.0"
                "buildinggrounddecalsizey", "12.0"
                "buildinggrounddecaltype", "decals/armavp_aoplane.dds"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBuildings/LandFactories"
                "techlevel", "2.0"
                "unitgroup", "buildert2"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "1024.0"
                "levelground", "false"
            ] }

    type Armshltx =
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
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          workerTime: ValueOrExpr<float>
          buildOptions: string list
          terraformSpeed: float
          energyStorage: float
          metalStorage: float
          yardMap: string
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string> }

    let armshltx : Armshltx =
        { name = "armshltx"
          subfolder = "ArmBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 7900.0
          energyCost = ValueOrExpr.Concrete 58000.0
          buildTime = ValueOrExpr.Concrete 62000.0
          health = ValueOrExpr.Concrete 16000.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 12.0
          footprintZ = 12.0
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canMove = true
          workerTime = ValueOrExpr.Concrete 1800.0
          buildOptions = ["armbanth"; "armraz"; "armmar"; "armvang"; "armlun"; "armthor"]
          terraformSpeed = 3000.0
          energyStorage = 1400.0
          metalStorage = 800.0
          yardMap = "oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee"
          featureDefs = Map.ofList [
                "armshlt_dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "125 75 145"
                  collisionVolumeType = Some "Box"
                  damage = Some 8640.0
                  featureDead = Some "ARMSHLT_HEAP"
                  footprintX = Some 9.0
                  footprintZ = Some 9.0
                  height = Some 20.0
                  metal = Some 4807.0
                  object_ = Some "Units/armshltx_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "armshlt_heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 4320.0
                  featureDead = None
                  footprintX = Some 9.0
                  footprintZ = Some 9.0
                  height = Some 4.0
                  metal = Some 1923.0
                  object_ = Some "Units/arm7X7D.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = Some "gantok2"
                repair = Some "lathelrg"
                working = Some "build"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["gantsel1"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "15.0"
                "buildinggrounddecalsizey", "15.0"
                "buildinggrounddecaltype", "decals/armshltx_aoplane.dds"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBuildings/LandFactories"
                "techlevel", "3.0"
                "unitgroup", "buildert3"
                "usebuildinggrounddecal", "true"
            ] }

    type Armvp =
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
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          workerTime: ValueOrExpr<float>
          buildOptions: string list
          terraformSpeed: float
          energyStorage: float
          metalStorage: float
          yardMap: string
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armvp : Armvp =
        { name = "armvp"
          subfolder = "ArmBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 590.0
          energyCost = ValueOrExpr.Concrete 1550.0
          buildTime = ValueOrExpr.Concrete 5700.0
          health = ValueOrExpr.Concrete 3000.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 6.0
          footprintZ = 6.0
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          maxSlope = 15.0
          maxWaterDepth = 0.0
          canMove = true
          workerTime = ValueOrExpr.Concrete 150.0
          buildOptions = ["armcv"; "armbeaver"; "armmlv"; "armfav"; "armflash"; "armpincer"; "armstump"; "armart"; "armjanus"; "armsam"]
          terraformSpeed = 500.0
          energyStorage = 100.0
          metalStorage = 100.0
          yardMap = "oooooo oooooo oooooo oeeeeo oeeeeo oeeeeo"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-5 0 0"
                  collisionVolumeScales = Some "110 34 92"
                  collisionVolumeType = Some "Box"
                  damage = Some 1668.0
                  featureDead = Some "HEAP"
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 40.0
                  metal = Some 483.0
                  object_ = Some "Units/armvp_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 834.0
                  featureDead = None
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 4.0
                  metal = Some 193.0
                  object_ = Some "Units/arm6X6A.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["vehplantselect"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "9.0"
                "buildinggrounddecalsizey", "9.0"
                "buildinggrounddecaltype", "decals/armvp_aoplane.dds"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBuildings/LandFactories"
                "unitgroup", "builder"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "1024.0"
                "levelground", "false"
            ] }

