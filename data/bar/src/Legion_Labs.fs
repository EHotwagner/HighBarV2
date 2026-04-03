// Auto-generated BAR unit data: Legion/Labs (flat per-unit types)
namespace BarData.Units

open BarData

module Legion_Labs =

    type Legaap =
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

    let legaap : Legaap =
        { name = "legaap"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 2900.0
          energyCost = ValueOrExpr.Concrete 28000.0
          buildTime = ValueOrExpr.Concrete 31050.0
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
          buildOptions = ["legaca"; "legstronghold"; "legmineb"; "legatorpbomber"; "legafigdef"; "legwhisper"; "legfort"; "legphoenix"; "legvenator"]
          terraformSpeed = 1000.0
          energyStorage = 200.0
          metalStorage = 200.0
          yardMap = "ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo"
          activateWhenBuilt = true
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "142 50 142"
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
                  object_ = Some "Units/cor7X7A.s3o"
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
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/legaap_aoplane.dds"
                "buildinggrounddecalsizey", "12.0"
                "buildinggrounddecalsizex", "12.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "buildert2"
                "restrictions_inclusion", "_noair_"
                "airfactory", "true"
                "model_author", "Protar/Ghoulish"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Labs"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "radardistance", "1000.0"
                "radaremitheight", "50.0"
            ] }

    type Legadvshipyard =
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

    let legadvshipyard : Legadvshipyard =
        { name = "legadvshipyard"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 2800.0
          energyCost = ValueOrExpr.Concrete 10000.0
          buildTime = ValueOrExpr.Concrete 23550.0
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
          buildOptions = []
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
                  object_ = Some "Units/legadvshipyard_dead.s3o"
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
                "model_author", "Tharsis"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Labs"
                "techlevel", "2.0"
                "unitgroup", "buildert2"
            ] }

    type Legalab =
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

    let legalab : Legalab =
        { name = "legalab"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 2600.0
          energyCost = ValueOrExpr.Concrete 16000.0
          buildTime = ValueOrExpr.Concrete 25200.0
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
          buildOptions = []
          terraformSpeed = 1000.0
          energyStorage = 200.0
          metalStorage = 200.0
          yardMap = "ooooooooo ooooooooo oooeeeooo oooeeeooo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "140 52 140"
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
                  object_ = Some "Units/cor7X7A.s3o"
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
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/legalab_aoplane.dds"
                "buildinggrounddecalsizey", "12.0"
                "buildinggrounddecalsizex", "12.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "buildert2"
                "model_author", "Protar/Ghoulish"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Labs"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "buildangle", "1024.0"
                "radardistance", "50.0"
            ] }

    type Legamphlab =
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

    let legamphlab : Legamphlab =
        { name = "legamphlab"
          subfolder = "Legion/Labs"
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
          workerTime = ValueOrExpr.Concrete 150.0
          buildOptions = ["legotter"; "legamphtank"; "legfloat"; "legamph"; "legaabot"; "legadvaabot"; "legdecom"]
          terraformSpeed = 750.0
          energyStorage = 160.0
          yardMap = "oooooo oooooo oeeeeo oeeeeo oeeeeo oeeeeo"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "96 44 89"
                  collisionVolumeType = Some "Box"
                  damage = Some 1500.0
                  featureDead = None
                  footprintX = Some 7.0
                  footprintZ = Some 7.0
                  height = Some 5.0
                  metal = Some 800.0
                  object_ = Some "Units/legamphlab_dead.s3o"
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
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/legamphlab_aoplane.dds"
                "buildinggrounddecalsizey", "9.0"
                "buildinggrounddecalsizex", "9.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "builder"
                "model_author", "ZephyrSkies, Tharsis"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Labs"
                "techlevel", "1.5"
            ] }

    type Legap =
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

    let legap : Legap =
        { name = "legap"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 430.0
          energyCost = ValueOrExpr.Concrete 1100.0
          buildTime = ValueOrExpr.Concrete 6380.0
          health = ValueOrExpr.Concrete 1780.0
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
          buildOptions = ["legca"; "legfig"; "legkam"; "legcib"; "legmos"; "leglts"; "legatrans"]
          terraformSpeed = 500.0
          energyStorage = 100.0
          metalStorage = 100.0
          yardMap = "oooooo oooooo oooooo oooooo oooooo oooooo"
          activateWhenBuilt = true
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "96 45 96"
                  collisionVolumeType = Some "Box"
                  damage = Some 1155.0
                  featureDead = Some "HEAP"
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 20.0
                  metal = Some 540.0
                  object_ = Some "Units/legap_dead.s3o"
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
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/legap_aoplane.dds"
                "buildinggrounddecalsizey", "9.0"
                "buildinggrounddecalsizex", "9.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "builder"
                "restrictions_inclusion", "_noair_"
                "airfactory", "true"
                "model_author", "Protar/Ghoulish"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Labs"
            ]
          extras = Map.ofList [
                "sightemitheight", "40.0"
                "radardistance", "510.0"
                "radaremitheight", "40.0"
            ] }

    type Legavp =
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

    let legavp : Legavp =
        { name = "legavp"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 2500.0
          energyCost = ValueOrExpr.Concrete 16000.0
          buildTime = ValueOrExpr.Concrete 27750.0
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
          buildOptions = []
          terraformSpeed = 1000.0
          energyStorage = 200.0
          metalStorage = 200.0
          yardMap = "h\r\n        oo oo oo oo oo oo oo oo oo\r\n        oo oo oo oo oo oo oo oo oo\r\n        oo oo oo oo oo oo oo oo oo\r\n        oo oo oo oo oo oo oo oo oo\r\n        oo oo oo oo oo oo oo oo oo\r\n        oo oo oo oo oo oo oo oo oo\r\n        oo oo oo oo oo oo oo oo oo\r\n        oo oo oo oo oo oo oo oo oo\r\n        oo oo oo oo oo oo oo oo oo\r\n        oo oo oe ee ee ee eo oo oo\r\n        oo oo oe ee ee ee eo oo oo\r\n        oo oo oe ee ee ee eo oo oo\r\n        oo oo oe ee ee ee eo oo oo\r\n        oo oo oe ee ee ee eo oo oo\r\n        oo oo oe ee ee ee eo oo oo\r\n        oo oo oe ee ee ee eo oo oo\r\n        oo oo oe ee ee ee eo oo oo\r\n        oo oo oe ee ee ee eo oo oo\r\n        "
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 5"
                  collisionVolumeScales = Some "144 70 144"
                  collisionVolumeType = Some "Box"
                  damage = Some 2777.0
                  featureDead = Some "HEAP"
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
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
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
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
                "usebuildinggrounddecal", "false"
                "buildinggrounddecaltype", "decals/legavp_aoplane.dds"
                "buildinggrounddecalsizey", "12.0"
                "buildinggrounddecalsizex", "12.0"
                "buildinggrounddecaldecayspeed", "0.01"
                "unitgroup", "buildert2"
                "model_author", "ZephyrSkies"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Labs"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "buildangle", "1024.0"
                "levelground", "false"
                "radardistance", "50.0"
            ] }

    type Legfhp =
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

    let legfhp : Legfhp =
        { name = "legfhp"
          subfolder = "Legion/Labs"
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
          buildOptions = ["legch"; "legsh"; "legner"; "legah"; "legmh"; "legcar"]
          terraformSpeed = 1000.0
          energyStorage = 200.0
          metalStorage = 200.0
          yardMap = "weeeew weeeew weeeew weeeew weeeew weeeew"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "96 35 96"
                  collisionVolumeType = Some "Box"
                  damage = Some 2014.0
                  featureDead = None
                  footprintX = Some 8.0
                  footprintZ = Some 7.0
                  height = Some 20.0
                  metal = Some 715.0
                  object_ = Some "Units/legfhp_dead.s3o"
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
                "unitgroup", "builder"
                "model_author", "Protar, ZephyrSkies"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Labs"
                "techlevel", "1.5"
            ] }

    type Leggant =
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

    let leggant : Leggant =
        { name = "leggant"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 8400.0
          energyCost = ValueOrExpr.Concrete 62000.0
          buildTime = ValueOrExpr.Concrete 67300.0
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
          buildOptions = []
          terraformSpeed = 3000.0
          energyStorage = 1400.0
          metalStorage = 800.0
          yardMap = "oooooooooooo oooooooooooo oooooooooooo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo yoeeeeeeeeoy"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 12 0"
                  collisionVolumeScales = Some "190 100 190"
                  collisionVolumeType = Some "Box"
                  damage = Some 9600.0
                  featureDead = Some "HEAP"
                  footprintX = Some 9.0
                  footprintZ = Some 9.0
                  height = Some 20.0
                  metal = Some 5101.0
                  object_ = Some "Units/leggant_dead.s3o"
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
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/leggant_aoplane.dds"
                "buildinggrounddecalsizey", "15.0"
                "buildinggrounddecalsizex", "15.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "buildert3"
                "model_author", "Protar"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Labs"
                "techlevel", "3.0"
            ]
          extras = Map.ofList [
                "radardistance", "50.0"
            ] }

    type Leggantuw =
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
          customParams: Map<string, string>
          extras: Map<string, string> }

    let leggantuw : Leggantuw =
        { name = "leggantuw"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 8400.0
          energyCost = ValueOrExpr.Concrete 62000.0
          buildTime = ValueOrExpr.Concrete 67300.0
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
          buildOptions = []
          terraformSpeed = 3000.0
          energyStorage = 1400.0
          metalStorage = 800.0
          yardMap = "oooooooooooo oooooooooooo oooooooooooo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo yoeeeeeeeeoy"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 12 0"
                  collisionVolumeScales = Some "190 100 190"
                  collisionVolumeType = Some "Box"
                  damage = Some 9600.0
                  featureDead = Some "HEAP"
                  footprintX = Some 9.0
                  footprintZ = Some 9.0
                  height = Some 20.0
                  metal = Some 5101.0
                  object_ = Some "Units/leggant_dead.s3o"
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
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/leggant_aoplane.dds"
                "buildinggrounddecalsizey", "15.0"
                "buildinggrounddecalsizex", "15.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "buildert3"
                "model_author", "Protar"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Labs"
                "techlevel", "3.0"
            ]
          extras = Map.ofList [
                "radardistance", "50.0"
            ] }

    type Leghalab =
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

    let leghalab : Leghalab =
        { name = "leghalab"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 4900.0
          energyCost = ValueOrExpr.Concrete 62000.0
          buildTime = ValueOrExpr.Concrete 67300.0
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
          buildOptions = ["leghack"; "leginc"; "legsrail"; "legajamk"; "legdecom"; "legadvaabot"; "legjav"; "legshot"; "legamph"; "legaspy"]
          terraformSpeed = 3000.0
          energyStorage = 1400.0
          metalStorage = 800.0
          yardMap = "oooooooooooo oooooooooooo oooooooooooo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo yoeeeeeeeeoy"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 12 0"
                  collisionVolumeScales = Some "190 100 190"
                  collisionVolumeType = Some "Box"
                  damage = Some 9600.0
                  featureDead = Some "HEAP"
                  footprintX = Some 9.0
                  footprintZ = Some 9.0
                  height = Some 20.0
                  metal = Some 5101.0
                  object_ = Some "Units/leggant_dead.s3o"
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
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/leggant_aoplane.dds"
                "buildinggrounddecalsizey", "15.0"
                "buildinggrounddecalsizex", "15.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "buildert3"
                "model_author", "Protar"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Labs"
                "techlevel", "3.0"
            ]
          extras = Map.ofList [
                "radardistance", "50.0"
            ] }

    type Leghavp =
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

    let leghavp : Leghavp =
        { name = "leghavp"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 4900.0
          energyCost = ValueOrExpr.Concrete 46000.0
          buildTime = ValueOrExpr.Concrete 67300.0
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
          buildOptions = ["leghacv"; "legaheattank"; "legmed"; "legavroc"; "leginf"; "legvflak"; "legavantinuke"; "legavjam"; "legmrv"; "legehovertank"]
          terraformSpeed = 3000.0
          energyStorage = 1400.0
          metalStorage = 800.0
          yardMap = "oooooooooooo oooooooooooo oooooooooooo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo yoeeeeeeeeoy"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 12 0"
                  collisionVolumeScales = Some "190 100 190"
                  collisionVolumeType = Some "Box"
                  damage = Some 9600.0
                  featureDead = Some "HEAP"
                  footprintX = Some 9.0
                  footprintZ = Some 9.0
                  height = Some 20.0
                  metal = Some 5101.0
                  object_ = Some "Units/leghavp_dead.s3o"
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
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/legamphlab_aoplane.dds"
                "buildinggrounddecalsizey", "15.0"
                "buildinggrounddecalsizex", "15.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "buildert3"
                "model_author", "Protar"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Labs"
                "techlevel", "3.0"
            ]
          extras = Map.ofList [
                "radardistance", "50.0"
            ] }

    type Leghp =
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

    let leghp : Leghp =
        { name = "leghp"
          subfolder = "Legion/Labs"
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
          buildOptions = ["legch"; "legsh"; "legner"; "legah"; "legmh"; "legcar"]
          terraformSpeed = 1000.0
          energyStorage = 200.0
          metalStorage = 200.0
          yardMap = "oeeeeo oeeeeo oeeeeo oeeeeo oeeeeo oeeeeo"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "96 35 96"
                  collisionVolumeType = Some "Box"
                  damage = Some 2014.0
                  featureDead = Some "HEAP"
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 20.0
                  metal = Some 662.0
                  object_ = Some "Units/leghp_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = Some "0 5 0"
                  collisionVolumeScales = Some "96 12 96"
                  collisionVolumeType = Some "Box"
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
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/leghp_aoplane.dds"
                "buildinggrounddecalsizey", "8.0"
                "buildinggrounddecalsizex", "8.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "builder"
                "model_author", "Protar"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Labs"
                "techlevel", "1.5"
            ] }

    type Leglab =
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

    let leglab : Leglab =
        { name = "leglab"
          subfolder = "Legion/Labs"
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
          buildOptions = ["legck"; "legrezbot"; "leggob"; "leglob"; "legcen"; "legbal"; "legkark"; "legaabot"]
          terraformSpeed = 500.0
          energyStorage = 100.0
          metalStorage = 100.0
          yardMap = "oooooo oooooo oeeeeo oeeeeo oeeeeo oeeeeo"
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
                  object_ = Some "Units/leglab_dead.s3o"
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
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/leglab_aoplane.dds"
                "buildinggrounddecalsizey", "9.0"
                "buildinggrounddecalsizex", "9.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "builder"
                "model_author", "Tharsis"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "CorBuildings/LandFactories"
            ]
          extras = Map.ofList [
                "buildangle", "1024.0"
                "radardistance", "50.0"
            ] }

    type Legsplab =
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

    let legsplab : Legsplab =
        { name = "legsplab"
          subfolder = "Legion/Labs"
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
          waterline = 0.0
          workerTime = ValueOrExpr.Concrete 300.0
          buildOptions = []
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
                  object_ = Some "Units/legsplab_dead.s3o"
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
                "model_author", "ZephyrSkies"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Labs"
                "unitgroup", "builder"
                "restrictions_inclusion", "_noair_"
                "techlevel", "1.5"
            ]
          extras = Map.ofList [
                "sonardistance", "800.0"
            ] }

    type Legsy =
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

    let legsy : Legsy =
        { name = "legsy"
          subfolder = "Legion/Labs"
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
          buildOptions = ["legnavyconship"; "legnavyrezsub"; "legnavyscout"; "legnavyaaship"; "legnavyfrigate"; "legnavydestro"; "legnavysub"; "legnavyartyship"]
          terraformSpeed = 500.0
          energyStorage = 100.0
          metalStorage = 100.0
          yardMap = "oyyyyo oeeeeo oeeeeo oeeeeo oeeeeo oyyyyo"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "103 42 103"
                  collisionVolumeType = Some "Box"
                  damage = Some 1794.0
                  featureDead = None
                  footprintX = Some 7.0
                  footprintZ = Some 7.0
                  height = Some 4.0
                  metal = Some 400.0
                  object_ = Some "Units/legsy_dead.s3o"
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
                "model_author", "Tharsis"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Labs"
                "unitgroup", "builder"
            ] }

    type Legvp =
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

    let legvp : Legvp =
        { name = "legvp"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 570.0
          energyCost = ValueOrExpr.Concrete 1650.0
          buildTime = ValueOrExpr.Concrete 5700.0
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
          buildOptions = ["legscout"; "legcv"; "legotter"; "leghades"; "leghelios"; "leggat"; "legbar"; "legrail"; "legmlv"; "legamphtank"]
          terraformSpeed = 500.0
          energyStorage = 100.0
          metalStorage = 100.0
          yardMap = "h\r\n    oo oo oo oo oo oo\r\n    oo oo oo oo oo oo\r\n    oo oo oo oo oo oo\r\n    oo oo oo oo oo oo\r\n    oe ee ee ee oo oo\r\n    oe ee ee ee oo oo\r\n    oe ee ee ee oo oo\r\n    oe ee ee ee oo oo\r\n    oe ee ee ee oo oo\r\n    oe ee ee ee oo oo\r\n    oe ee ee ee oo oo\r\n    oe ee ee ee oo oo\r\n    "
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
                  object_ = Some "Units/legvp_dead.s3o"
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
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/legvp_aoplane.dds"
                "buildinggrounddecalsizey", "9.0"
                "buildinggrounddecalsizex", "9.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "builder"
                "model_author", "Protar/Ghoulish"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Labs"
            ]
          extras = Map.ofList [
                "buildangle", "2048.0"
                "levelground", "true"
                "radardistance", "50.0"
            ] }

