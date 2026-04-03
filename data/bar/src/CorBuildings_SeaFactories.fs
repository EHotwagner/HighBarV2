// Auto-generated BAR unit data: CorBuildings/SeaFactories (flat per-unit types)
namespace BarData.Units

open BarData

module CorBuildings_SeaFactories =

    type Coramsub =
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

    let coramsub : Coramsub =
        { name = "coramsub"
          subfolder = "CorBuildings/SeaFactories"
          metalCost = ValueOrExpr.Concrete 1200.0
          energyCost = ValueOrExpr.Concrete 5600.0
          buildTime = ValueOrExpr.Concrete 11400.0
          health = ValueOrExpr.Concrete 2800.0
          sightDistance = ValueOrExpr.Concrete 240.0
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
          buildOptions = ["cormuskrat"; "corgarp"; "corsala"; "corparrow"; "corcrash"; "coraak"; "cordecom"]
          terraformSpeed = 750.0
          energyStorage = 160.0
          yardMap = "oooooo oooooo oeeeeo oeeeeo oeeeeo oeeeeo"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 -15"
                  collisionVolumeScales = Some "111 34 86"
                  collisionVolumeType = Some "Box"
                  damage = Some 1500.0
                  featureDead = None
                  footprintX = Some 7.0
                  footprintZ = Some 7.0
                  height = Some 5.0
                  metal = Some 800.0
                  object_ = Some "Units/coramsub_dead.s3o"
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
                "buildinggrounddecalsizex", "9.0"
                "buildinggrounddecalsizey", "9.0"
                "buildinggrounddecaltype", "decals/coramsub_aoplane.dds"
                "model_author", "FireStorm"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBuildings/SeaFactories"
                "unitgroup", "builder"
                "usebuildinggrounddecal", "true"
                "techlevel", "1.5"
            ] }

    type Corasy =
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

    let corasy : Corasy =
        { name = "corasy"
          subfolder = "CorBuildings/SeaFactories"
          metalCost = ValueOrExpr.Concrete 2800.0
          energyCost = ValueOrExpr.Concrete 10000.0
          buildTime = ValueOrExpr.Concrete 24000.0
          health = ValueOrExpr.Concrete 5900.0
          sightDistance = ValueOrExpr.Concrete 301.60001
          footprintX = 12.0
          footprintZ = 12.0
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          canMove = true
          minWaterDepth = 30.0
          waterline = 19.0
          workerTime = ValueOrExpr.Concrete 600.0
          buildOptions = ["coracsub"; "cormls"; "corcrus"; "corshark"; "corssub"; "corarch"; "corsjam"; "corantiship"; "corbats"; "cormship"; "corblackhy"; "corfship"]
          terraformSpeed = 1000.0
          energyStorage = 200.0
          metalStorage = 200.0
          yardMap = "weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -13 -3"
                  collisionVolumeScales = Some "192 61 180"
                  collisionVolumeType = Some "Box"
                  damage = Some 2650.0
                  featureDead = None
                  footprintX = Some 12.0
                  footprintZ = Some 12.0
                  height = Some 4.0
                  metal = Some 2174.0
                  object_ = Some "Units/corasy_dead.s3o"
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
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBuildings/SeaFactories"
                "techlevel", "2.0"
                "unitgroup", "buildert2"
            ] }

    type Corfhp =
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

    let corfhp : Corfhp =
        { name = "corfhp"
          subfolder = "CorBuildings/SeaFactories"
          metalCost = ValueOrExpr.Concrete 670.0
          energyCost = ValueOrExpr.Concrete 2000.0
          buildTime = ValueOrExpr.Concrete 8700.0
          health = ValueOrExpr.Concrete 3750.0
          sightDistance = ValueOrExpr.Concrete 312.0
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
          buildOptions = ["corch"; "corsh"; "corsnap"; "corah"; "cormh"; "corhal"]
          terraformSpeed = 1000.0
          energyStorage = 200.0
          metalStorage = 200.0
          yardMap = "weeeew weeeew weeeew weeeew weeeew weeeew"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "120 26 108"
                  collisionVolumeType = Some "Box"
                  damage = Some 2014.0
                  featureDead = None
                  footprintX = Some 8.0
                  footprintZ = Some 7.0
                  height = Some 20.0
                  metal = Some 715.0
                  object_ = Some "Units/corfhp_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
            ]
          sounds =
              { build = Some "hoverok2"
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["hoversl2"] }
          customParams = Map.ofList [
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBuildings/SeaFactories"
                "unitgroup", "builder"
                "techlevel", "1.5"
            ] }

    type Corgantuw =
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

    let corgantuw : Corgantuw =
        { name = "corgantuw"
          subfolder = "CorBuildings/SeaFactories"
          metalCost = ValueOrExpr.Concrete 8350.0
          energyCost = ValueOrExpr.Concrete 62500.0
          buildTime = ValueOrExpr.Concrete 68000.0
          health = ValueOrExpr.Concrete 17800.0
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
          buildOptions = ["corkorg"; "corshiva"; "corsala"; "corparrow"; "corsok"]
          terraformSpeed = 3000.0
          energyStorage = 1400.0
          metalStorage = 800.0
          yardMap = "oooooooooooo oooooooooooo oooooooooooo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -21 0"
                  collisionVolumeScales = Some "114 74 129"
                  collisionVolumeType = Some "CylZ"
                  damage = Some 9600.0
                  featureDead = Some "HEAP"
                  footprintX = Some 9.0
                  footprintZ = Some 9.0
                  height = Some 20.0
                  metal = Some 5101.0
                  object_ = Some "Units/corgant_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 4800.0
                  featureDead = None
                  footprintX = Some 9.0
                  footprintZ = Some 9.0
                  height = Some 4.0
                  metal = Some 2040.0
                  object_ = Some "Units/cor7X7B.s3o"
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
                "buildinggrounddecaltype", "decals/corgant_aoplane.dds"
                "model_author", "Cremuss"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBuildings/SeaFactories"
                "techlevel", "3.0"
                "unitgroup", "buildert3"
                "usebuildinggrounddecal", "true"
            ] }

    type Corhasy =
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

    let corhasy : Corhasy =
        { name = "corhasy"
          subfolder = "CorBuildings/SeaFactories"
          metalCost = ValueOrExpr.Concrete 5000.0
          energyCost = ValueOrExpr.Concrete 40000.0
          buildTime = ValueOrExpr.Concrete 92000.0
          health = ValueOrExpr.Concrete 17800.0
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
          waterline = 1.0
          workerTime = ValueOrExpr.Concrete 600.0
          buildOptions = ["corhacs"; "corssub"; "corbats"; "corblackhy"; "corarch"; "corfship"; "corsok"; "corantiship"; "cormship"]
          terraformSpeed = 3000.0
          energyStorage = 1400.0
          metalStorage = 800.0
          yardMap = "weeeeeeeeeeeeew weeeeeeeeeeeeew weeeeeeeeeeeeew weeeeeeeeeeeeew weeeeeeeeeeeeew weeeeeeeeeeeeew weeeeeeeeeeeeew weeeeeeeeeeeeew weeeeeeeeeeeeew weeeeeeeeeeeeew weeeeeeeeeeeeew weeeeeeeeeew"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -20 -8"
                  collisionVolumeScales = Some "232 112 240"
                  collisionVolumeType = Some "Box"
                  damage = Some 9600.0
                  featureDead = Some "HEAP"
                  footprintX = Some 9.0
                  footprintZ = Some 9.0
                  height = Some 8.0
                  metal = Some 5101.0
                  object_ = Some "Units/corhasy_dead.s3o"
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
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBuildings/SeaFactories"
                "techlevel", "3.0"
                "unitgroup", "buildert3"
            ] }

    type Corplat =
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

    let corplat : Corplat =
        { name = "corplat"
          subfolder = "CorBuildings/SeaFactories"
          metalCost = ValueOrExpr.Concrete 1400.0
          energyCost = ValueOrExpr.Concrete 5500.0
          buildTime = ValueOrExpr.Concrete 11800.0
          health = ValueOrExpr.Concrete 2200.0
          sightDistance = ValueOrExpr.Concrete 169.0
          footprintX = 6.0
          footprintZ = 6.0
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          canMove = true
          minWaterDepth = 30.0
          waterline = 43.0
          workerTime = ValueOrExpr.Concrete 300.0
          buildOptions = ["corcsa"; "corcut"; "corsb"; "corseap"; "corsfig"; "corhunt"]
          terraformSpeed = 1000.0
          energyStorage = 200.0
          yardMap = "wwwwww weeeew weeeew weeeew weeeew wwwwww"
          activateWhenBuilt = true
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "2.5 0.0 -0.0"
                  collisionVolumeScales = Some "117.5 41.25 112.5"
                  collisionVolumeType = Some "Box"
                  damage = Some 1200.0
                  featureDead = None
                  footprintX = Some 7.0
                  footprintZ = Some 7.0
                  height = Some 20.0
                  metal = Some 930.0
                  object_ = Some "Units/corplat_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
            ]
          sounds =
              { build = Some "seaplok2"
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["seaplsl2"] }
          customParams = Map.ofList [
                "airfactory", "true"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBuildings/SeaFactories"
                "unitgroup", "builder"
                "techlevel", "1.5"
            ]
          extras = Map.ofList [
                "sonardistance", "800.0"
            ] }

    type Corsasy =
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

    let corsasy : Corsasy =
        { name = "corsasy"
          subfolder = "CorBuildings/SeaFactories"
          metalCost = ValueOrExpr.Concrete 3500.0
          energyCost = ValueOrExpr.Concrete 35000.0
          buildTime = ValueOrExpr.Concrete 51000.0
          health = ValueOrExpr.Concrete 5900.0
          sightDistance = ValueOrExpr.Concrete 301.60001
          footprintX = 12.0
          footprintZ = 12.0
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          canMove = true
          minWaterDepth = 30.0
          waterline = 19.0
          workerTime = ValueOrExpr.Concrete 300.0
          buildOptions = ["corsacsub"; "corssub"; "corsjam"; "corbats"; "cormship"; "corblackhy"]
          terraformSpeed = 1000.0
          energyStorage = 200.0
          metalStorage = 200.0
          yardMap = "weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -13 -3"
                  collisionVolumeScales = Some "192 61 180"
                  collisionVolumeType = Some "Box"
                  damage = Some 2650.0
                  featureDead = None
                  footprintX = Some 12.0
                  footprintZ = Some 12.0
                  height = Some 4.0
                  metal = Some 2174.0
                  object_ = Some "Units/corasy_dead.s3o"
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
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBuildings/SeaFactories"
                "techlevel", "2.0"
                "unitgroup", "buildert2"
            ] }

    type Corsy =
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

    let corsy : Corsy =
        { name = "corsy"
          subfolder = "CorBuildings/SeaFactories"
          metalCost = ValueOrExpr.Concrete 450.0
          energyCost = ValueOrExpr.Concrete 950.0
          buildTime = ValueOrExpr.Concrete 5100.0
          health = ValueOrExpr.Concrete 4300.0
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
          buildOptions = ["corcs"; "correcl"; "coresupp"; "corpt"; "corpship"; "corroy"; "corsub"]
          terraformSpeed = 500.0
          energyStorage = 100.0
          metalStorage = 100.0
          yardMap = "oyyyyo oeeeeo oeeeeo oeeeeo oeeeeo oyyyyo"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -10 -4"
                  collisionVolumeScales = Some "116 56 120"
                  collisionVolumeType = Some "Box"
                  damage = Some 1794.0
                  featureDead = None
                  footprintX = Some 7.0
                  footprintZ = Some 7.0
                  height = Some 4.0
                  metal = Some 400.0
                  object_ = Some "Units/corsy_dead.s3o"
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
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBuildings/SeaFactories"
                "unitgroup", "builder"
            ] }

