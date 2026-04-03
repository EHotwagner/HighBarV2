// Auto-generated BAR unit data: ArmBuildings/SeaFactories (flat per-unit types)
namespace BarData.Units

open BarData

module ArmBuildings_SeaFactories =

    type Armamsub =
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
          yardMap: string
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string> }

    let armamsub : Armamsub =
        { name = "armamsub"
          subfolder = "ArmBuildings/SeaFactories"
          metalCost = ValueOrExpr.Concrete 1200.0
          energyCost = ValueOrExpr.Concrete 5500.0
          buildTime = ValueOrExpr.Concrete 11100.0
          health = ValueOrExpr.Concrete 2650.0
          sightDistance = ValueOrExpr.Concrete 234.0
          footprintX = 6.0
          footprintZ = 6.0
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          maxSlope = 10.0
          canMove = true
          minWaterDepth = 25.0
          workerTime = ValueOrExpr.Concrete 300.0
          buildOptions = ["armbeaver"; "armpincer"; "armcroc"; "armjeth"; "armaak"; "armdecom"]
          terraformSpeed = 750.0
          energyStorage = 150.0
          yardMap = "oooooo oooooo oeeeeo oeeeeo oeeeeo oeeeeo"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 2"
                  collisionVolumeScales = Some "118 35 107"
                  collisionVolumeType = Some "Box"
                  damage = Some 1440.0
                  featureDead = None
                  footprintX = Some 7.0
                  footprintZ = Some 7.0
                  height = Some 5.0
                  metal = Some 800.0
                  object_ = Some "Units/armamsub_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
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
                "buildinggrounddecalsizex", "11.0"
                "buildinggrounddecalsizey", "11.0"
                "buildinggrounddecaltype", "decals/armamsub_aoplane.dds"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBuildings/SeaFactories"
                "unitgroup", "builder"
                "usebuildinggrounddecal", "true"
                "techlevel", "1.5"
            ] }

    type Armasy =
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
          canMove: bool
          minWaterDepth: float
          waterline: float
          workerTime: ValueOrExpr<float>
          buildOptions: string list
          terraformSpeed: float
          energyStorage: float
          metalStorage: float
          yardMap: string
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string> }

    let armasy : Armasy =
        { name = "armasy"
          subfolder = "ArmBuildings/SeaFactories"
          metalCost = ValueOrExpr.Concrete 2900.0
          energyCost = ValueOrExpr.Concrete 9700.0
          buildTime = ValueOrExpr.Concrete 24000.0
          health = ValueOrExpr.Concrete 6000.0
          sightDistance = ValueOrExpr.Concrete 299.0
          footprintX = 12.0
          footprintZ = 12.0
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          canMove = true
          minWaterDepth = 30.0
          waterline = 1.5
          workerTime = ValueOrExpr.Concrete 600.0
          buildOptions = ["armacsub"; "armmls"; "armcrus"; "armsubk"; "armserp"; "armaas"; "armsjam"; "armantiship"; "armbats"; "armmship"; "armepoch"; "armlship"]
          terraformSpeed = 1000.0
          energyStorage = 200.0
          metalStorage = 200.0
          yardMap = "weeeeeeeeeew eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee weeeeeeeeeew"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -9 -2"
                  collisionVolumeScales = Some "180 60 176"
                  collisionVolumeType = Some "Box"
                  damage = Some 2707.0
                  featureDead = None
                  footprintX = Some 12.0
                  footprintZ = Some 12.0
                  height = Some 4.0
                  metal = Some 2232.0
                  object_ = Some "Units/armasy_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
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
                select = ["pshpactv"] }
          customParams = Map.ofList [
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBuildings/SeaFactories"
                "techlevel", "2.0"
                "unitgroup", "buildert2"
            ] }

    type Armfhp =
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
          canMove: bool
          minWaterDepth: float
          waterline: float
          workerTime: ValueOrExpr<float>
          buildOptions: string list
          terraformSpeed: float
          energyStorage: float
          metalStorage: float
          yardMap: string
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string> }

    let armfhp : Armfhp =
        { name = "armfhp"
          subfolder = "ArmBuildings/SeaFactories"
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
          canMove = true
          minWaterDepth = 5.0
          waterline = 4.0
          workerTime = ValueOrExpr.Concrete 150.0
          buildOptions = ["armch"; "armsh"; "armanac"; "armah"; "armmh"]
          terraformSpeed = 1000.0
          energyStorage = 200.0
          metalStorage = 200.0
          yardMap = "weeeew weeeew weeeew weeeew weeeew weeeew"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "116 20 104"
                  collisionVolumeType = Some "Box"
                  damage = Some 1803.0
                  featureDead = None
                  footprintX = Some 8.0
                  footprintZ = Some 7.0
                  height = Some 20.0
                  metal = Some 670.0
                  object_ = Some "Units/armfhp_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
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
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBuildings/SeaFactories"
                "unitgroup", "builder"
                "techlevel", "1.5"
            ] }

    type Armhasy =
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
          waterline: float
          workerTime: ValueOrExpr<float>
          buildOptions: string list
          terraformSpeed: float
          energyStorage: float
          metalStorage: float
          yardMap: string
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string> }

    let armhasy : Armhasy =
        { name = "armhasy"
          subfolder = "ArmBuildings/SeaFactories"
          metalCost = ValueOrExpr.Concrete 5000.0
          energyCost = ValueOrExpr.Concrete 44000.0
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
          canMove = true
          minWaterDepth = 30.0
          waterline = 1.5
          workerTime = ValueOrExpr.Concrete 600.0
          buildOptions = ["armhacs"; "armserp"; "armbats"; "armepoch"; "armantiship"; "armlship"; "armlun"; "armaas"; "armmship"]
          terraformSpeed = 3000.0
          energyStorage = 1400.0
          metalStorage = 800.0
          yardMap = "weeeeeeeeeeeeew eeeeeeeeeeeeeee eeeeeeeeeeeeeee eeeeeeeeeeeeeee eeeeeeeeeeeeeee eeeeeeeeeeeeeee eeeeeeeeeeeeeee eeeeeeeeeeeeeee eeeeeeeeeeeeeee eeeeeeeeeeeeeee eeeeeeeeeeeeeee eeeeeeeeeeeeeee eeeeeeeeeeeeeee eeeeeeeeeeeeeee weeeeeeeeeeeeew"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-2 -2 -3"
                  collisionVolumeScales = Some "116 52 116"
                  collisionVolumeType = Some "Box"
                  damage = Some 8640.0
                  featureDead = Some "HEAP"
                  footprintX = Some 15.0
                  footprintZ = Some 15.0
                  height = Some 20.0
                  metal = Some 4807.0
                  object_ = Some "Units/armhasy_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
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
                select = ["pshpactv"] }
          customParams = Map.ofList [
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBuildings/SeaFactories"
                "techlevel", "3.0"
                "unitgroup", "buildert3"
            ] }

    type Armplat =
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
          canMove: bool
          minWaterDepth: float
          waterline: float
          workerTime: ValueOrExpr<float>
          buildOptions: string list
          terraformSpeed: float
          energyStorage: float
          yardMap: string
          activateWhenBuilt: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armplat : Armplat =
        { name = "armplat"
          subfolder = "ArmBuildings/SeaFactories"
          metalCost = ValueOrExpr.Concrete 1450.0
          energyCost = ValueOrExpr.Concrete 5000.0
          buildTime = ValueOrExpr.Concrete 12000.0
          health = ValueOrExpr.Concrete 2000.0
          sightDistance = ValueOrExpr.Concrete 169.0
          footprintX = 6.0
          footprintZ = 6.0
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          canMove = true
          minWaterDepth = 30.0
          waterline = 39.0
          workerTime = ValueOrExpr.Concrete 300.0
          buildOptions = ["armcsa"; "armsaber"; "armsb"; "armseap"; "armsfig"; "armsehak"]
          terraformSpeed = 1000.0
          energyStorage = 200.0
          yardMap = "wwwwww weeeew weeeew weeeew weeeew wwwwww"
          activateWhenBuilt = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "1.25 -7.62939453125e-06 -0.375"
                  collisionVolumeScales = Some "108.669647217 46.9999847412 117.478393555"
                  collisionVolumeType = Some "Box"
                  damage = Some 1092.0
                  featureDead = None
                  footprintX = Some 7.0
                  footprintZ = Some 7.0
                  height = Some 20.0
                  metal = Some 975.0
                  object_ = Some "Units/armplat_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
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
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBuildings/SeaFactories"
                "unitgroup", "builder"
                "restrictions_inclusion", "_noair_"
                "techlevel", "1.5"
            ]
          extras = Map.ofList [
                "onoffable", "true"
                "radardistance", "750.0"
                "sonardistance", "600.0"
            ] }

    type Armsasy =
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
          canMove: bool
          minWaterDepth: float
          waterline: float
          workerTime: ValueOrExpr<float>
          buildOptions: string list
          terraformSpeed: float
          energyStorage: float
          metalStorage: float
          yardMap: string
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string> }

    let armsasy : Armsasy =
        { name = "armsasy"
          subfolder = "ArmBuildings/SeaFactories"
          metalCost = ValueOrExpr.Concrete 3500.0
          energyCost = ValueOrExpr.Concrete 35000.0
          buildTime = ValueOrExpr.Concrete 30000.0
          health = ValueOrExpr.Concrete 6000.0
          sightDistance = ValueOrExpr.Concrete 299.0
          footprintX = 12.0
          footprintZ = 12.0
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          canMove = true
          minWaterDepth = 30.0
          waterline = 1.5
          workerTime = ValueOrExpr.Concrete 300.0
          buildOptions = ["armsacsub"; "armserp"; "armsjam"; "armbats"; "armmship"; "armepoch"]
          terraformSpeed = 1000.0
          energyStorage = 200.0
          metalStorage = 200.0
          yardMap = "weeeeeeeeeew eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee weeeeeeeeeew"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -9 -2"
                  collisionVolumeScales = Some "180 60 176"
                  collisionVolumeType = Some "Box"
                  damage = Some 2707.0
                  featureDead = None
                  footprintX = Some 12.0
                  footprintZ = Some 12.0
                  height = Some 4.0
                  metal = Some 2232.0
                  object_ = Some "Units/armasy_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
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
                select = ["pshpactv"] }
          customParams = Map.ofList [
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBuildings/SeaFactories"
                "techlevel", "2.0"
                "unitgroup", "buildert2"
            ] }

    type Armshltxuw =
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
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string> }

    let armshltxuw : Armshltxuw =
        { name = "armshltxuw"
          subfolder = "ArmBuildings/SeaFactories"
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
          canMove = true
          minWaterDepth = 30.0
          workerTime = ValueOrExpr.Concrete 1800.0
          buildOptions = ["armbanth"; "armmar"; "armcroc"; "armlun"]
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
                "buildinggrounddecalsizex", "10.0"
                "buildinggrounddecalsizey", "10.0"
                "buildinggrounddecaltype", "decals/armshltx_aoplane.dds"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBuildings/SeaFactories"
                "techlevel", "3.0"
                "unitgroup", "buildert3"
                "usebuildinggrounddecal", "true"
            ] }

    type Armsy =
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
          canMove: bool
          minWaterDepth: float
          waterline: float
          workerTime: ValueOrExpr<float>
          buildOptions: string list
          terraformSpeed: float
          energyStorage: float
          metalStorage: float
          yardMap: string
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string> }

    let armsy : Armsy =
        { name = "armsy"
          subfolder = "ArmBuildings/SeaFactories"
          metalCost = ValueOrExpr.Concrete 450.0
          energyCost = ValueOrExpr.Concrete 950.0
          buildTime = ValueOrExpr.Concrete 5160.0
          health = ValueOrExpr.Concrete 4100.0
          sightDistance = ValueOrExpr.Concrete 340.0
          footprintX = 6.0
          footprintZ = 6.0
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          canMove = true
          minWaterDepth = 30.0
          waterline = 1.0
          workerTime = ValueOrExpr.Concrete 150.0
          buildOptions = ["armcs"; "armrecl"; "armdecade"; "armpt"; "armpship"; "armroy"; "armsub"]
          terraformSpeed = 500.0
          energyStorage = 100.0
          metalStorage = 100.0
          yardMap = "oyyyyo yeeeey yeeeey yeeeey yeeeey oyyyyo"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-2 -2 -3"
                  collisionVolumeScales = Some "116 52 116"
                  collisionVolumeType = Some "Box"
                  damage = Some 1794.0
                  featureDead = None
                  footprintX = Some 7.0
                  footprintZ = Some 7.0
                  height = Some 4.0
                  metal = Some 400.0
                  object_ = Some "Units/armsy_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
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
                select = ["pshpactv"] }
          customParams = Map.ofList [
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBuildings/SeaFactories"
                "unitgroup", "builder"
            ] }

