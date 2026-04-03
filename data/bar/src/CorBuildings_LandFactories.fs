// Auto-generated BAR unit data: CorBuildings/LandFactories (flat per-unit types)
namespace BarData.Units

open BarData

module CorBuildings_LandFactories =

    type Coraap =
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

    let coraap : Coraap =
        { name = "coraap"
          subfolder = "CorBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 2900.0
          energyCost = ValueOrExpr.Concrete 28000.0
          buildTime = ValueOrExpr.Concrete 32000.0
          health = ValueOrExpr.Concrete 3900.0
          sightDistance = ValueOrExpr.Concrete 305.5
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
          buildOptions = ["coraca"; "corape"; "corhurc"; "cortitan"; "corvamp"; "corawac"; "corseah"; "corcrwh"]
          terraformSpeed = 1000.0
          energyStorage = 200.0
          metalStorage = 200.0
          yardMap = "ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo"
          activateWhenBuilt = true
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -12 -22"
                  collisionVolumeScales = Some "98 32 52"
                  collisionVolumeType = Some "Box"
                  damage = Some 2112.0
                  featureDead = Some "HEAP"
                  footprintX = Some 9.0
                  footprintZ = Some 9.0
                  height = Some 20.0
                  metal = Some 1936.0
                  object_ = Some "Units/coraap_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 1056.0
                  featureDead = None
                  footprintX = Some 9.0
                  footprintZ = Some 9.0
                  height = Some 4.0
                  metal = Some 968.0
                  object_ = Some "Units/cor6X6A.s3o"
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
                "buildinggrounddecaltype", "decals/coraap_aoplane.dds"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBuildings/LandFactories"
                "techlevel", "2.0"
                "unitgroup", "buildert2"
                "restrictions_inclusion", "_noair_"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "radardistance", "1000.0"
                "radaremitheight", "50.0"
            ] }

    type Coralab =
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

    let coralab : Coralab =
        { name = "coralab"
          subfolder = "CorBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 2600.0
          energyCost = ValueOrExpr.Concrete 16000.0
          buildTime = ValueOrExpr.Concrete 26000.0
          health = ValueOrExpr.Concrete 4500.0
          sightDistance = ValueOrExpr.Concrete 288.60001
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
          buildOptions = ["corack"; "corfast"; "corpyro"; "coramph"; "corcan"; "corsumo"; "cortermite"; "cormort"; "corhrk"; "coraak"; "corroach"; "corsktl"; "cordecom"; "corvoyr"; "corspy"; "corspec"; "cormando"]
          terraformSpeed = 1000.0
          energyStorage = 200.0
          metalStorage = 200.0
          yardMap = "ooooooooo ooooooooo oooeeeooo oooeeeooo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -16 0"
                  collisionVolumeScales = Some "100 34 90"
                  collisionVolumeType = Some "Box"
                  damage = Some 2443.0
                  featureDead = Some "HEAP"
                  footprintX = Some 9.0
                  footprintZ = Some 9.0
                  height = Some 20.0
                  metal = Some 1743.0
                  object_ = Some "Units/coralab_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 1222.0
                  featureDead = None
                  footprintX = Some 9.0
                  footprintZ = Some 9.0
                  height = Some 4.0
                  metal = Some 872.0
                  object_ = Some "Units/cor5X5A.s3o"
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
                "buildinggrounddecaltype", "decals/coralab_aoplane.dds"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBuildings/LandFactories"
                "techlevel", "2.0"
                "unitgroup", "buildert2"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "1024.0"
            ] }

    type Corap =
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

    let corap : Corap =
        { name = "corap"
          subfolder = "CorBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 630.0
          energyCost = ValueOrExpr.Concrete 1100.0
          buildTime = ValueOrExpr.Concrete 5380.0
          health = ValueOrExpr.Concrete 2150.0
          sightDistance = ValueOrExpr.Concrete 273.0
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
          buildOptions = ["corca"; "corfink"; "corveng"; "corshad"; "corvalk"; "corbw"; "corhvytrans"]
          terraformSpeed = 500.0
          energyStorage = 100.0
          metalStorage = 100.0
          yardMap = "ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo"
          activateWhenBuilt = true
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -14 -23"
                  collisionVolumeScales = Some "110 33 50"
                  collisionVolumeType = Some "Box"
                  damage = Some 1155.0
                  featureDead = Some "HEAP"
                  footprintX = Some 12.0
                  footprintZ = Some 9.0
                  height = Some 20.0
                  metal = Some 540.0
                  object_ = Some "Units/corap_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 578.0
                  featureDead = None
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 4.0
                  metal = Some 216.0
                  object_ = Some "Units/cor6X6B.s3o"
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
                "buildinggrounddecalsizex", "11.0"
                "buildinggrounddecalsizey", "9.0"
                "buildinggrounddecaltype", "decals/corap_aoplane.dds"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBuildings/LandFactories"
                "unitgroup", "builder"
                "restrictions_inclusion", "_noair_"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "radardistance", "510.0"
                "radaremitheight", "40.0"
                "sightemitheight", "40.0"
            ] }

    type Coravp =
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

    let coravp : Coravp =
        { name = "coravp"
          subfolder = "CorBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 2600.0
          energyCost = ValueOrExpr.Concrete 16000.0
          buildTime = ValueOrExpr.Concrete 28000.0
          health = ValueOrExpr.Concrete 5100.0
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
          buildOptions = ["coracv"; "corsala"; "correap"; "corparrow"; "corgol"; "corban"; "cormart"; "corvroc"; "cortrem"; "corsent"; "cormabm"; "coreter"; "corvrad"]
          terraformSpeed = 1000.0
          energyStorage = 200.0
          metalStorage = 200.0
          yardMap = "ooooooooo ooooooooo ooooooooo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -6 0"
                  collisionVolumeScales = Some "124 30 104"
                  collisionVolumeType = Some "Box"
                  damage = Some 2777.0
                  featureDead = Some "HEAP"
                  footprintX = Some 9.0
                  footprintZ = Some 9.0
                  height = Some 20.0
                  metal = Some 1721.0
                  object_ = Some "Units/coravp_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 1389.0
                  featureDead = None
                  footprintX = Some 9.0
                  footprintZ = Some 9.0
                  height = Some 4.0
                  metal = Some 860.0
                  object_ = Some "Units/cor6X6C.s3o"
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
                "buildinggrounddecaldecayspeed", "0.01"
                "buildinggrounddecalsizex", "12.0"
                "buildinggrounddecalsizey", "12.0"
                "buildinggrounddecaltype", "decals/coravp_aoplane.dds"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBuildings/LandFactories"
                "techlevel", "2.0"
                "unitgroup", "buildert2"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "1024.0"
                "levelground", "false"
            ] }

    type Corgant =
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

    let corgant : Corgant =
        { name = "corgant"
          subfolder = "CorBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 8400.0
          energyCost = ValueOrExpr.Concrete 62000.0
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
          maxWaterDepth = 0.0
          canMove = true
          workerTime = ValueOrExpr.Concrete 1800.0
          buildOptions = ["corkorg"; "corkarg"; "corjugg"; "corshiva"; "corcat"; "corsok"; "cordemon"]
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
                  footprintX = Some 12.0
                  footprintZ = Some 12.0
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
                  footprintX = Some 12.0
                  footprintZ = Some 12.0
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
                "buildinggrounddecalsizex", "15.0"
                "buildinggrounddecalsizey", "15.0"
                "buildinggrounddecaltype", "decals/corgant_aoplane.dds"
                "model_author", "Mr Bob, Tharsis"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBuildings/LandFactories"
                "techlevel", "3.0"
                "unitgroup", "buildert3"
                "usebuildinggrounddecal", "true"
            ] }

    type Corhaap =
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

    let corhaap : Corhaap =
        { name = "corhaap"
          subfolder = "CorBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 4700.0
          energyCost = ValueOrExpr.Concrete 65000.0
          buildTime = ValueOrExpr.Concrete 92000.0
          health = ValueOrExpr.Concrete 17800.0
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
          buildOptions = ["corhaca"; "corape"; "corhurc"; "cortitan"; "corvamp"; "corseah"; "corawac"; "corcrwh"]
          terraformSpeed = 3000.0
          energyStorage = 1400.0
          metalStorage = 800.0
          yardMap = "oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo"
          activateWhenBuilt = true
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "5 0.0 -0.0"
                  collisionVolumeScales = Some "235 82.5 225"
                  collisionVolumeType = Some "Box"
                  damage = Some 9600.0
                  featureDead = Some "HEAP"
                  footprintX = Some 12.0
                  footprintZ = Some 12.0
                  height = Some 20.0
                  metal = Some 5101.0
                  object_ = Some "Units/corhaap_dead.s3o"
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
                  footprintX = Some 12.0
                  footprintZ = Some 12.0
                  height = Some 4.0
                  metal = Some 2040.0
                  object_ = Some "Units/cor7X7B.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
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
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "12.0"
                "buildinggrounddecalsizey", "12.0"
                "buildinggrounddecaltype", "decals/coraap_aoplane.dds"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBuildings/LandFactories"
                "techlevel", "3.0"
                "unitgroup", "buildert3"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "radardistance", "750.0"
                "radaremitheight", "50.0"
            ] }

    type Corhaapuw =
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

    let corhaapuw : Corhaapuw =
        { name = "corhaapuw"
          subfolder = "CorBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 1900.0
          energyCost = ValueOrExpr.Concrete 23000.0
          buildTime = ValueOrExpr.Concrete 42000.0
          health = ValueOrExpr.Concrete 3900.0
          sightDistance = ValueOrExpr.Concrete 305.5
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
          buildOptions = ["coraca"; "corhunt"; "corcut"; "corsb"; "corseap"; "corsfig"; "corhvytrans"]
          terraformSpeed = 1000.0
          energyStorage = 200.0
          metalStorage = 200.0
          yardMap = "ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo"
          activateWhenBuilt = true
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -12 -22"
                  collisionVolumeScales = Some "98 32 52"
                  collisionVolumeType = Some "Box"
                  damage = Some 2112.0
                  featureDead = Some "HEAP"
                  footprintX = Some 9.0
                  footprintZ = Some 9.0
                  height = Some 20.0
                  metal = Some 1936.0
                  object_ = Some "Units/coraaplat_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 1056.0
                  featureDead = None
                  footprintX = Some 9.0
                  footprintZ = Some 9.0
                  height = Some 4.0
                  metal = Some 968.0
                  object_ = Some "Units/cor6X6A.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
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
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "12.0"
                "buildinggrounddecalsizey", "12.0"
                "buildinggrounddecaltype", "decals/coraap_aoplane.dds"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBuildings/LandFactories"
                "techlevel", "2.0"
                "unitgroup", "buildert2"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "radardistance", "1000.0"
                "radaremitheight", "50.0"
            ] }

    type Corhalab =
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

    let corhalab : Corhalab =
        { name = "corhalab"
          subfolder = "CorBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 4900.0
          energyCost = ValueOrExpr.Concrete 52200.0
          buildTime = ValueOrExpr.Concrete 92000.0
          health = ValueOrExpr.Concrete 17800.0
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
          workerTime = ValueOrExpr.Concrete 1200.0
          buildOptions = ["coraak"; "corshiva"; "corpyro"; "corhack"; "corsumo"; "cordecom"; "corsktl"; "corspec"]
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
                  footprintX = Some 12.0
                  footprintZ = Some 12.0
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
                  footprintX = Some 12.0
                  footprintZ = Some 12.0
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
                "buildinggrounddecalsizex", "15.0"
                "buildinggrounddecalsizey", "15.0"
                "buildinggrounddecaltype", "decals/corgant_aoplane.dds"
                "model_author", "Mr Bob, Tharsis"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBuildings/LandFactories"
                "techlevel", "3.0"
                "unitgroup", "buildert3"
                "usebuildinggrounddecal", "true"
            ] }

    type Corhavp =
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

    let corhavp : Corhavp =
        { name = "corhavp"
          subfolder = "CorBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 4900.0
          energyCost = ValueOrExpr.Concrete 46000.0
          buildTime = ValueOrExpr.Concrete 92000.0
          health = ValueOrExpr.Concrete 17800.0
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
          workerTime = ValueOrExpr.Concrete 1200.0
          buildOptions = ["corhacv"; "corgol"; "corvroc"; "cortrem"; "corsent"; "cormabm"; "coreter"; "corsok"; "corparrow"; "corsala"]
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
                  footprintX = Some 12.0
                  footprintZ = Some 12.0
                  height = Some 20.0
                  metal = Some 5101.0
                  object_ = Some "Units/corhavp_dead.s3o"
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
                  footprintX = Some 12.0
                  footprintZ = Some 12.0
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
                "buildinggrounddecalsizex", "18.0"
                "buildinggrounddecalsizey", "18.0"
                "buildinggrounddecaltype", "decals/coramsub_aoplane.dds"
                "model_author", "Mr Bob, Tharsis"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBuildings/LandFactories"
                "techlevel", "3.0"
                "unitgroup", "buildert3"
                "usebuildinggrounddecal", "true"
            ] }

    type Corhp =
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

    let corhp : Corhp =
        { name = "corhp"
          subfolder = "CorBuildings/LandFactories"
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
          maxSlope = 15.0
          maxWaterDepth = 0.0
          canMove = true
          workerTime = ValueOrExpr.Concrete 150.0
          buildOptions = ["corch"; "corsh"; "corsnap"; "corah"; "cormh"; "corhal"]
          terraformSpeed = 1000.0
          energyStorage = 200.0
          metalStorage = 200.0
          yardMap = "oeeeeo oeeeeo oeeeeo oeeeeo oeeeeo oeeeeo"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "120 26 108"
                  collisionVolumeType = Some "Box"
                  damage = Some 2014.0
                  featureDead = Some "HEAP"
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 20.0
                  metal = Some 662.0
                  object_ = Some "Units/corhp_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 1007.0
                  featureDead = None
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 4.0
                  metal = Some 265.0
                  object_ = Some "Units/cor7X7D.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
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
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "9.0"
                "buildinggrounddecalsizey", "9.0"
                "buildinggrounddecaltype", "decals/corhp_aoplane.dds"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBuildings/LandFactories"
                "unitgroup", "builder"
                "usebuildinggrounddecal", "true"
                "techlevel", "1.5"
            ] }

    type Corlab =
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

    let corlab : Corlab =
        { name = "corlab"
          subfolder = "CorBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 470.0
          energyCost = ValueOrExpr.Concrete 1050.0
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
          buildOptions = ["corck"; "corak"; "cornecro"; "corstorm"; "corthud"; "corcrash"]
          terraformSpeed = 500.0
          energyStorage = 100.0
          metalStorage = 100.0
          yardMap = "oeeeeooeeeeooeeeeooeeeeooeeeeooeeeeo"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "88 28 88"
                  collisionVolumeType = Some "Box"
                  damage = Some 1560.0
                  featureDead = Some "HEAP"
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 20.0
                  metal = Some 442.0
                  object_ = Some "Units/corlab_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 780.0
                  featureDead = None
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 4.0
                  metal = Some 177.0
                  object_ = Some "Units/cor6X6B.s3o"
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
                "buildinggrounddecalsizex", "8.0"
                "buildinggrounddecalsizey", "8.0"
                "buildinggrounddecaltype", "decals/corlab_aoplane.dds"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBuildings/LandFactories"
                "unitgroup", "builder"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "1024.0"
            ] }

    type Corsaap =
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

    let corsaap : Corsaap =
        { name = "corsaap"
          subfolder = "CorBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 3500.0
          energyCost = ValueOrExpr.Concrete 35000.0
          buildTime = ValueOrExpr.Concrete 51000.0
          health = ValueOrExpr.Concrete 3900.0
          sightDistance = ValueOrExpr.Concrete 305.5
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
          buildOptions = ["corcsa"; "corape"; "corhurc"; "cortitan"; "corvamp"; "corseah"; "corcrwh"; "corhunt"]
          terraformSpeed = 1000.0
          energyStorage = 200.0
          metalStorage = 200.0
          yardMap = "ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo"
          activateWhenBuilt = true
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -12 -22"
                  collisionVolumeScales = Some "98 32 52"
                  collisionVolumeType = Some "Box"
                  damage = Some 2112.0
                  featureDead = Some "HEAP"
                  footprintX = Some 9.0
                  footprintZ = Some 9.0
                  height = Some 20.0
                  metal = Some 1936.0
                  object_ = Some "Units/legaap_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 1056.0
                  featureDead = None
                  footprintX = Some 9.0
                  footprintZ = Some 9.0
                  height = Some 4.0
                  metal = Some 968.0
                  object_ = Some "Units/cor6X6A.s3o"
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
                "buildinggrounddecaltype", "decals/coraap_aoplane.dds"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBuildings/LandFactories"
                "techlevel", "2.0"
                "unitgroup", "buildert2"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "radardistance", "1000.0"
                "radaremitheight", "50.0"
            ] }

    type Corsalab =
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

    let corsalab : Corsalab =
        { name = "corsalab"
          subfolder = "CorBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 3500.0
          energyCost = ValueOrExpr.Concrete 35000.0
          buildTime = ValueOrExpr.Concrete 51000.0
          health = ValueOrExpr.Concrete 4500.0
          sightDistance = ValueOrExpr.Concrete 288.60001
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
          buildOptions = ["corsack"; "corsumo"; "corhrk"; "corsktl"; "corvoyr"; "corspec"; "cormando"]
          terraformSpeed = 1000.0
          energyStorage = 200.0
          metalStorage = 200.0
          yardMap = "ooooooooo ooooooooo oooeeeooo oooeeeooo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -16 0"
                  collisionVolumeScales = Some "100 34 90"
                  collisionVolumeType = Some "Box"
                  damage = Some 2443.0
                  featureDead = Some "HEAP"
                  footprintX = Some 9.0
                  footprintZ = Some 9.0
                  height = Some 20.0
                  metal = Some 1743.0
                  object_ = Some "Units/legalab_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 1222.0
                  featureDead = None
                  footprintX = Some 9.0
                  footprintZ = Some 9.0
                  height = Some 4.0
                  metal = Some 872.0
                  object_ = Some "Units/cor5X5A.s3o"
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
                "buildinggrounddecaltype", "decals/coralab_aoplane.dds"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBuildings/LandFactories"
                "techlevel", "2.0"
                "unitgroup", "buildert2"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "1024.0"
            ] }

    type Corsavp =
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

    let corsavp : Corsavp =
        { name = "corsavp"
          subfolder = "CorBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 3500.0
          energyCost = ValueOrExpr.Concrete 35000.0
          buildTime = ValueOrExpr.Concrete 51000.0
          health = ValueOrExpr.Concrete 5100.0
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
          buildOptions = ["corsacv"; "corparrow"; "corgol"; "corban"; "corvroc"; "cortrem"; "coreter"; "corvrad"]
          terraformSpeed = 1000.0
          energyStorage = 200.0
          metalStorage = 200.0
          yardMap = "ooooooooo ooooooooo ooooooooo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -6 0"
                  collisionVolumeScales = Some "124 30 104"
                  collisionVolumeType = Some "Box"
                  damage = Some 2777.0
                  featureDead = Some "HEAP"
                  footprintX = Some 9.0
                  footprintZ = Some 9.0
                  height = Some 20.0
                  metal = Some 1721.0
                  object_ = Some "Units/legavp_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 1389.0
                  featureDead = None
                  footprintX = Some 9.0
                  footprintZ = Some 9.0
                  height = Some 4.0
                  metal = Some 860.0
                  object_ = Some "Units/cor6X6C.s3o"
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
                "buildinggrounddecaldecayspeed", "0.01"
                "buildinggrounddecalsizex", "12.0"
                "buildinggrounddecalsizey", "12.0"
                "buildinggrounddecaltype", "decals/coravp_aoplane.dds"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBuildings/LandFactories"
                "techlevel", "2.0"
                "unitgroup", "buildert2"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "1024.0"
                "levelground", "false"
            ] }

    type Corvp =
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

    let corvp : Corvp =
        { name = "corvp"
          subfolder = "CorBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 570.0
          energyCost = ValueOrExpr.Concrete 1550.0
          buildTime = ValueOrExpr.Concrete 5650.0
          health = ValueOrExpr.Concrete 3000.0
          sightDistance = ValueOrExpr.Concrete 279.0
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
          buildOptions = ["corcv"; "cormuskrat"; "cormlv"; "corfav"; "corgator"; "corgarp"; "corraid"; "corlevlr"; "corwolv"; "cormist"]
          terraformSpeed = 500.0
          energyStorage = 100.0
          metalStorage = 100.0
          yardMap = "oooooo oooooo oeeeeo oeeeeo oeeeeo oeeeeo"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -13 0"
                  collisionVolumeScales = Some "101 40 106"
                  collisionVolumeType = Some "BOX"
                  damage = Some 1590.0
                  featureDead = Some "HEAP"
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 20.0
                  metal = Some 470.0
                  object_ = Some "Units/corvp_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 795.0
                  featureDead = None
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 4.0
                  metal = Some 188.0
                  object_ = Some "Units/cor7X7B.s3o"
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
                "buildinggrounddecaltype", "decals/corvp_aoplane.dds"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBuildings/LandFactories"
                "unitgroup", "builder"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "2048.0"
                "levelground", "false"
            ] }

    type Leghaap =
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

    let leghaap : Leghaap =
        { name = "leghaap"
          subfolder = "CorBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 4700.0
          energyCost = ValueOrExpr.Concrete 62000.0
          buildTime = ValueOrExpr.Concrete 92000.0
          health = ValueOrExpr.Concrete 17800.0
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
          buildOptions = ["leghaca"; "legstronghold"; "legmineb"; "legatorpbomber"; "legafigdef"; "legwhisper"; "legfort"; "legphoenix"; "legvenator"]
          terraformSpeed = 3000.0
          energyStorage = 1400.0
          metalStorage = 800.0
          yardMap = "ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo"
          activateWhenBuilt = true
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "2.5 0.0 -0.0"
                  collisionVolumeScales = Some "117.5 41.25 112.5"
                  collisionVolumeType = Some "Box"
                  damage = Some 9600.0
                  featureDead = Some "HEAP"
                  footprintX = Some 12.0
                  footprintZ = Some 12.0
                  height = Some 20.0
                  metal = Some 5101.0
                  object_ = Some "Units/corplat_dead.s3o"
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
                  footprintX = Some 12.0
                  footprintZ = Some 12.0
                  height = Some 4.0
                  metal = Some 2040.0
                  object_ = Some "Units/cor7X7B.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
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
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "9.0"
                "buildinggrounddecalsizey", "9.0"
                "buildinggrounddecaltype", "decals/coraap_aoplane.dds"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBuildings/LandFactories"
                "techlevel", "3.0"
                "unitgroup", "buildert3"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "radardistance", "750.0"
                "radaremitheight", "50.0"
            ] }

