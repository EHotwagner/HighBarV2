// Auto-generated BAR unit data: CorBuildings/SeaUtil (unified)
namespace BarData.Units

open BarData

module CorBuildings_SeaUtil =

    type Corason =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          objectName: string option
          buildPic: string option
          script: string option
          corpse: string option
          explodeAs: string option
          selfDestructAs: string option
          collisionVolumeOffsets: string option
          collisionVolumeScales: string option
          collisionVolumeType: string option
          seismicSignature: float option
          category: string option
          yardMap: string
          activateWhenBuilt: bool
          canRepeat: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corason : Corason =
        { name = "corason"
          subfolder = "CorBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 160.0
          energyCost = ValueOrExpr.Concrete 2400.0
          buildTime = ValueOrExpr.Concrete 6100.0
          health = ValueOrExpr.Concrete 2400.0
          sightDistance = ValueOrExpr.Concrete 210.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORASON.s3o"
          buildPic = Some "CORASON.DDS"
          script = Some "Units/CORASON.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingexplosiongeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 1 0"
          collisionVolumeScales = Some "45 28 45"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          yardMap = "ooooooooo"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-2.39038085938 -9.06459454346 0.315093994141"
                  collisionVolumeScales = Some "43.173828125 10.1218109131 43.7690734863"
                  collisionVolumeType = Some "Box"
                  damage = Some 1284.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 99.0
                  object_ = Some "Units/corason_dead.s3o"
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
                select = ["sonar2"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "5.0"
                "buildinggrounddecalsizey", "5.0"
                "buildinggrounddecaltype", "decals/corason_aoplane.dds"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/SeaUtil"
                "techlevel", "2.0"
                "unitgroup", "util"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "8192.0"
                "canattack", "false"
                "onoffable", "false"
                "sonardistance", "1600.0"
            ] }

    let corasonDef : UnitDef =
        { name = "corason"
          subfolder = "CorBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 160.0
          energyCost = ValueOrExpr.Concrete 2400.0
          buildTime = ValueOrExpr.Concrete 6100.0
          health = ValueOrExpr.Concrete 2400.0
          sightDistance = ValueOrExpr.Concrete 210.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORASON.s3o"
          buildPic = Some "CORASON.DDS"
          script = Some "Units/CORASON.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingexplosiongeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 1 0"
          collisionVolumeScales = Some "45 28 45"
          collisionVolumeType = Some "CylY"
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
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "-2.39038085938 -9.06459454346 0.315093994141"
                collisionVolumeScales = Some "43.173828125 10.1218109131 43.7690734863"
                collisionVolumeType = Some "Box"
                damage = Some 1284.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 99.0
                object_ = Some "Units/corason_dead.s3o"
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
              select = ["sonar2"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecaltype", "decals/corason_aoplane.dds"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "CorBuildings/SeaUtil"
              "techlevel", "2.0"
              "unitgroup", "util"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
              "canattack", "false"
              "onoffable", "false"
              "sonardistance", "1600.0"
          ] }

    let corasonToFlat (def: UnitDef) : Corason =
        { name = def.name
          subfolder = def.subfolder
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          yardMap = def.building.Value.yardMap.Value
          activateWhenBuilt = def.building.Value.activateWhenBuilt.Value
          canRepeat = def.building.Value.canRepeat.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corasonToUnitDef (flat: Corason) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = None
          builder = None
          weapons = None
          economy = None
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = Some flat.activateWhenBuilt
              canRepeat = Some flat.canRepeat
            }
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corfatf =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          objectName: string option
          buildPic: string option
          script: string option
          corpse: string option
          explodeAs: string option
          selfDestructAs: string option
          collisionVolumeOffsets: string option
          collisionVolumeScales: string option
          collisionVolumeType: string option
          seismicSignature: float option
          category: string option
          yardMap: string
          activateWhenBuilt: bool
          canRepeat: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corfatf : Corfatf =
        { name = "corfatf"
          subfolder = "CorBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 800.0
          energyCost = ValueOrExpr.Concrete 7500.0
          buildTime = ValueOrExpr.Concrete 10300.0
          health = ValueOrExpr.Concrete 1530.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/CORFATF.s3o"
          buildPic = Some "CORFATF.DDS"
          script = Some "Units/CORFATF.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -5 -3.5"
          collisionVolumeScales = Some "60 30 60"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          yardMap = "wwwwwwwwwwwwwwww"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-1.11164093018 -5.62302210693 3.14508056641"
                  collisionVolumeScales = Some "61.8861541748 21.1415557861 54.7463684082"
                  collisionVolumeType = Some "Box"
                  damage = Some 825.0
                  featureDead = Some "HEAP"
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 20.0
                  metal = Some 447.0
                  object_ = Some "Units/corfatf_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 413.0
                  featureDead = None
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 4.0
                  metal = Some 179.0
                  object_ = Some "Units/cor4X4D.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = Some "targsel2"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["targsel2"] }
          customParams = Map.ofList [
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/SeaUtil"
                "techlevel", "2.0"
                "unitgroup", "util"
            ]
          extras = Map.ofList [
                "buildangle", "16384.0"
                "energyupkeep", "150.0"
                "istargetingupgrade", "true"
                "onoffable", "true"
            ] }

    let corfatfDef : UnitDef =
        { name = "corfatf"
          subfolder = "CorBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 800.0
          energyCost = ValueOrExpr.Concrete 7500.0
          buildTime = ValueOrExpr.Concrete 10300.0
          health = ValueOrExpr.Concrete 1530.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/CORFATF.s3o"
          buildPic = Some "CORFATF.DDS"
          script = Some "Units/CORFATF.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -5 -3.5"
          collisionVolumeScales = Some "60 30 60"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "wwwwwwwwwwwwwwww"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "-1.11164093018 -5.62302210693 3.14508056641"
                collisionVolumeScales = Some "61.8861541748 21.1415557861 54.7463684082"
                collisionVolumeType = Some "Box"
                damage = Some 825.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 447.0
                object_ = Some "Units/corfatf_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 413.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 4.0
                metal = Some 179.0
                object_ = Some "Units/cor4X4D.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = None
              repair = None
              working = Some "targsel2"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = []
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = []
              select = ["targsel2"] })
          customParams = Map.ofList [
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "CorBuildings/SeaUtil"
              "techlevel", "2.0"
              "unitgroup", "util"
          ]
          extras = Map.ofList [
              "buildangle", "16384.0"
              "energyupkeep", "150.0"
              "istargetingupgrade", "true"
              "onoffable", "true"
          ] }

    let corfatfToFlat (def: UnitDef) : Corfatf =
        { name = def.name
          subfolder = def.subfolder
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          yardMap = def.building.Value.yardMap.Value
          activateWhenBuilt = def.building.Value.activateWhenBuilt.Value
          canRepeat = def.building.Value.canRepeat.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corfatfToUnitDef (flat: Corfatf) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = None
          builder = None
          weapons = None
          economy = None
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = Some flat.activateWhenBuilt
              canRepeat = Some flat.canRepeat
            }
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corfdrag =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          objectName: string option
          buildPic: string option
          script: string option
          corpse: string option
          explodeAs: string option
          selfDestructAs: string option
          collisionVolumeOffsets: string option
          collisionVolumeScales: string option
          collisionVolumeType: string option
          seismicSignature: float option
          category: string option
          yardMap: string
          canRepeat: bool
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corfdrag : Corfdrag =
        { name = "corfdrag"
          subfolder = "CorBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 15.0
          energyCost = ValueOrExpr.Concrete 0.0
          buildTime = ValueOrExpr.Concrete 400.0
          health = ValueOrExpr.Concrete 4450.0
          sightDistance = ValueOrExpr.Concrete 1.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORFDRAG.s3o"
          buildPic = Some "CORFDRAG.DDS"
          script = Some "Units/CORFDRAG.cob"
          corpse = None
          explodeAs = Some "WallExplosionWater"
          selfDestructAs = Some "WallExplosionWater"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "36 14 36"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          yardMap = "oooo"
          canRepeat = false
          customParams = Map.ofList [
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "objectify", "true"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/SeaUtil"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "buildangle", "8192.0"
                "canattack", "false"
                "crushresistance", "250.0"
                "hidedamage", "true"
                "repairable", "false"
                "selfdestructcountdown", "1.0"
            ] }

    let corfdragDef : UnitDef =
        { name = "corfdrag"
          subfolder = "CorBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 15.0
          energyCost = ValueOrExpr.Concrete 0.0
          buildTime = ValueOrExpr.Concrete 400.0
          health = ValueOrExpr.Concrete 4450.0
          sightDistance = ValueOrExpr.Concrete 1.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORFDRAG.s3o"
          buildPic = Some "CORFDRAG.DDS"
          script = Some "Units/CORFDRAG.cob"
          corpse = None
          explodeAs = Some "WallExplosionWater"
          selfDestructAs = Some "WallExplosionWater"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "36 14 36"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "oooo"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "objectify", "true"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "CorBuildings/SeaUtil"
          ]
          extras = Map.ofList [
              "blocking", "true"
              "buildangle", "8192.0"
              "canattack", "false"
              "crushresistance", "250.0"
              "hidedamage", "true"
              "repairable", "false"
              "selfdestructcountdown", "1.0"
          ] }

    let corfdragToFlat (def: UnitDef) : Corfdrag =
        { name = def.name
          subfolder = def.subfolder
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          yardMap = def.building.Value.yardMap.Value
          canRepeat = def.building.Value.canRepeat.Value
          customParams = def.customParams
          extras = def.extras }

    let corfdragToUnitDef (flat: Corfdrag) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = None
          builder = None
          weapons = None
          economy = None
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = None
              canRepeat = Some flat.canRepeat
            }
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Corfgate =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          objectName: string option
          buildPic: string option
          script: string option
          corpse: string option
          explodeAs: string option
          selfDestructAs: string option
          collisionVolumeOffsets: string option
          collisionVolumeScales: string option
          collisionVolumeType: string option
          seismicSignature: float option
          category: string option
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          maxSlope: float
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          minWaterDepth: float
          waterline: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corfgate : Corfgate =
        { name = "corfgate"
          subfolder = "CorBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 4100.0
          energyCost = ValueOrExpr.Concrete 74000.0
          buildTime = ValueOrExpr.Concrete 59000.0
          health = ValueOrExpr.Concrete 4100.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/corfgate.s3o"
          buildPic = Some "CORFGATE.DDS"
          script = Some "Units/corfgate.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -25 0"
          collisionVolumeScales = Some "60 70 60"
          collisionVolumeType = Some "cyly"
          seismicSignature = Some 0.0
          category = Some "NOWEAPON"
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          maxSlope = 10.0
          turnInPlaceAngleLimit = 140.0
          turnInPlaceSpeedLimit = 0.0
          minWaterDepth = 16.0
          waterline = 0.0
          weapons = [
                { name = "sea_repulsor"
                  displayName = "NavalPlasmaRepulsor"
                  weaponType = Some "Shield"
                  damage = Map.empty
                  range = None
                  reloadTime = None
                  weaponVelocity = None
                  areaOfEffect = None
                  accuracy = None
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = None
                  noSelfDamage = None
                  soundStart = None
                  soundHit = None
                  explosiongenerator = None
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "soundhitwet", "sizzle"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 -2.91625976558e-05 -0.414924621582"
                  collisionVolumeScales = Some "57.2399902344 32.5033416748 63.3298492432"
                  collisionVolumeType = Some "Box"
                  damage = Some 1800.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 2296.0
                  object_ = Some "Units/corfgate_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 900.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 918.0
                  object_ = Some "Units/cor2X2D.s3o"
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
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["drone1"]
                select = ["drone1"] }
          customParams = Map.ofList [
                "normaltex", "unittextures/cor_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "shield_color_mult", "0.8"
                "shield_power", "9500.0"
                "shield_radius", "600.0"
                "subfolder", "CorBuildings/SeaUtil"
                "techlevel", "2.0"
                "unitgroup", "util"
            ]
          extras = Map.ofList [
                "buildangle", "2048.0"
                "onoffable", "true"
                "canattack", "false"
                "exemptcategory", "WEAPON"
                "noautofire", "true"
                "norestrict", "1.0"
                "unitname", "corfgate"
            ] }

    let corfgateDef : UnitDef =
        { name = "corfgate"
          subfolder = "CorBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 4100.0
          energyCost = ValueOrExpr.Concrete 74000.0
          buildTime = ValueOrExpr.Concrete 59000.0
          health = ValueOrExpr.Concrete 4100.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/corfgate.s3o"
          buildPic = Some "CORFGATE.DDS"
          script = Some "Units/corfgate.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -25 0"
          collisionVolumeScales = Some "60 70 60"
          collisionVolumeType = Some "cyly"
          seismicSignature = Some 0.0
          category = Some "NOWEAPON"
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.0
              maxAcc = 0.0
              maxDec = 0.0
              turnRate = 0.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = None
              canFly = false
              canMove = false
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 140.0
              turnInPlaceSpeedLimit = Some 0.0
              cruiseAltitude = None
              minWaterDepth = Some 16.0
              waterline = Some 0.0 })
          builder = None
          weapons = Some [
              { name = "sea_repulsor"
                displayName = "NavalPlasmaRepulsor"
                weaponType = Some "Shield"
                damage = Map.empty
                range = None
                reloadTime = None
                weaponVelocity = None
                areaOfEffect = None
                accuracy = None
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = None
                noSelfDamage = None
                soundStart = None
                soundHit = None
                explosiongenerator = None
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "soundhitwet", "sizzle"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0 -2.91625976558e-05 -0.414924621582"
                collisionVolumeScales = Some "57.2399902344 32.5033416748 63.3298492432"
                collisionVolumeType = Some "Box"
                damage = Some 1800.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 2296.0
                object_ = Some "Units/corfgate_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 900.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 918.0
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
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["drone1"]
              select = ["drone1"] })
          customParams = Map.ofList [
              "normaltex", "unittextures/cor_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "shield_color_mult", "0.8"
              "shield_power", "9500.0"
              "shield_radius", "600.0"
              "subfolder", "CorBuildings/SeaUtil"
              "techlevel", "2.0"
              "unitgroup", "util"
          ]
          extras = Map.ofList [
              "buildangle", "2048.0"
              "onoffable", "true"
              "canattack", "false"
              "exemptcategory", "WEAPON"
              "noautofire", "true"
              "norestrict", "1.0"
              "unitname", "corfgate"
          ] }

    let corfgateToFlat (def: UnitDef) : Corfgate =
        { name = def.name
          subfolder = def.subfolder
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          maxSlope = def.movement.Value.maxSlope.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          minWaterDepth = def.movement.Value.minWaterDepth.Value
          waterline = def.movement.Value.waterline.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corfgateToUnitDef (flat: Corfgate) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = None
              maxSlope = Some flat.maxSlope
              maxWaterDepth = None
              canFly = false
              canMove = false
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit
              cruiseAltitude = None
              minWaterDepth = Some flat.minWaterDepth
              waterline = Some flat.waterline
            }
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corfmine3 =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          objectName: string option
          buildPic: string option
          script: string option
          corpse: string option
          explodeAs: string option
          selfDestructAs: string option
          collisionVolumeOffsets: string option
          collisionVolumeScales: string option
          collisionVolumeType: string option
          seismicSignature: float option
          category: string option
          yardMap: string
          canRepeat: bool
          weapons: WeaponDef list
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corfmine3 : Corfmine3 =
        { name = "corfmine3"
          subfolder = "CorBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 32.0
          energyCost = ValueOrExpr.Concrete 1600.0
          buildTime = ValueOrExpr.Concrete 400.0
          health = ValueOrExpr.Concrete 11.0
          sightDistance = ValueOrExpr.Concrete 71.5
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Units/CORFMINE3.s3o"
          buildPic = Some "CORFMINE3.DDS"
          script = Some "mines_lus.lua"
          corpse = None
          explodeAs = Some "FMINE_HEAVY"
          selfDestructAs = Some "FMINE_HEAVY"
          collisionVolumeOffsets = Some "0 -0.5 0"
          collisionVolumeScales = Some "20 5 20"
          collisionVolumeType = Some "Ell"
          seismicSignature = Some 0.0
          category = None
          yardMap = "w"
          canRepeat = false
          weapons = [
                { name = "minerange"
                  displayName = "Crawlingbomb Dummy Weapon"
                  weaponType = Some "Melee"
                  damage = Map.ofList [
                      "default", 0.0
                  ]
                  range = Some (ValueOrExpr.Concrete 64.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.0)
                  weaponVelocity = Some 100000.0
                  areaOfEffect = Some 0.0
                  accuracy = None
                  turret = None
                  tolerance = Some 1000000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = None
                  soundStart = None
                  soundHit = None
                  explosiongenerator = Some ""
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firesubmersed", "false"
                      "soundhitwet", ""
                      "soundhitwetvolume", "0.0"
                  ] }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["servsml6"]
                select = ["minesel2"] }
          customParams = Map.ofList [
                "detonaterange", "64"
                "instantselfd", "true"
                "mine", "true"
                "model_author", "Tristan"
                "normaltex", "unittextures/cor_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/SeaUtil"
                "unitgroup", "explo"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "canattack", "false"
                "canguard", "false"
                "canpatrol", "false"
                "cloakcost", "4.0"
                "collide", "false"
                "firestate", "2.0"
                "initcloaked", "true"
                "mincloakdistance", "8.0"
                "nochasecategory", "VTOL"
                "selfdestructcountdown", "0.0"
                "sonarstealth", "true"
                "stealth", "true"
            ] }

    let corfmine3Def : UnitDef =
        { name = "corfmine3"
          subfolder = "CorBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 32.0
          energyCost = ValueOrExpr.Concrete 1600.0
          buildTime = ValueOrExpr.Concrete 400.0
          health = ValueOrExpr.Concrete 11.0
          sightDistance = ValueOrExpr.Concrete 71.5
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Units/CORFMINE3.s3o"
          buildPic = Some "CORFMINE3.DDS"
          script = Some "mines_lus.lua"
          corpse = None
          explodeAs = Some "FMINE_HEAVY"
          selfDestructAs = Some "FMINE_HEAVY"
          collisionVolumeOffsets = Some "0 -0.5 0"
          collisionVolumeScales = Some "20 5 20"
          collisionVolumeType = Some "Ell"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "minerange"
                displayName = "Crawlingbomb Dummy Weapon"
                weaponType = Some "Melee"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = Some (ValueOrExpr.Concrete 64.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
                weaponVelocity = Some 100000.0
                areaOfEffect = Some 0.0
                accuracy = None
                turret = None
                tolerance = Some 1000000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = None
                soundStart = None
                soundHit = None
                explosiongenerator = Some ""
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firesubmersed", "false"
                    "soundhitwet", ""
                    "soundhitwetvolume", "0.0"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "w"
              activateWhenBuilt = None
              canRepeat = Some false })
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
              ok = ["servsml6"]
              select = ["minesel2"] })
          customParams = Map.ofList [
              "detonaterange", "64"
              "instantselfd", "true"
              "mine", "true"
              "model_author", "Tristan"
              "normaltex", "unittextures/cor_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "CorBuildings/SeaUtil"
              "unitgroup", "explo"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "canattack", "false"
              "canguard", "false"
              "canpatrol", "false"
              "cloakcost", "4.0"
              "collide", "false"
              "firestate", "2.0"
              "initcloaked", "true"
              "mincloakdistance", "8.0"
              "nochasecategory", "VTOL"
              "selfdestructcountdown", "0.0"
              "sonarstealth", "true"
              "stealth", "true"
          ] }

    let corfmine3ToFlat (def: UnitDef) : Corfmine3 =
        { name = def.name
          subfolder = def.subfolder
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          yardMap = def.building.Value.yardMap.Value
          canRepeat = def.building.Value.canRepeat.Value
          weapons = def.weapons.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corfmine3ToUnitDef (flat: Corfmine3) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = None
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = None
              canRepeat = Some flat.canRepeat
            }
          featureDefs = None
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corfrad =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          objectName: string option
          buildPic: string option
          script: string option
          corpse: string option
          explodeAs: string option
          selfDestructAs: string option
          collisionVolumeOffsets: string option
          collisionVolumeScales: string option
          collisionVolumeType: string option
          seismicSignature: float option
          category: string option
          yardMap: string
          activateWhenBuilt: bool
          canRepeat: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corfrad : Corfrad =
        { name = "corfrad"
          subfolder = "CorBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 130.0
          energyCost = ValueOrExpr.Concrete 1000.0
          buildTime = ValueOrExpr.Concrete 1800.0
          health = ValueOrExpr.Concrete 114.0
          sightDistance = ValueOrExpr.Concrete 740.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORFRAD.s3o"
          buildPic = Some "CORFRAD.DDS"
          script = Some "Units/CORFRAD.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingexplosiongeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -15 0"
          collisionVolumeScales = Some "32 95 32"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          yardMap = "wwwwwwwww"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-1.90951538086 -2.08381778564 1.08252716064"
                  collisionVolumeScales = Some "41.2277526855 50.2841644287 42.4677886963"
                  collisionVolumeType = Some "Box"
                  damage = Some 62.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 80.0
                  object_ = Some "Units/corfrad_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
            ]
          sounds =
              { build = None
                repair = None
                working = Some "cmd-on"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["radarselect"] }
          customParams = Map.ofList [
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/SeaUtil"
                "unitgroup", "util"
            ]
          extras = Map.ofList [
                "buildangle", "16384.0"
                "canattack", "false"
                "onoffable", "false"
                "radardistance", "2100.0"
                "radaremitheight", "72.0"
                "sightemitheight", "72.0"
                "sonardistance", "900.0"
            ] }

    let corfradDef : UnitDef =
        { name = "corfrad"
          subfolder = "CorBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 130.0
          energyCost = ValueOrExpr.Concrete 1000.0
          buildTime = ValueOrExpr.Concrete 1800.0
          health = ValueOrExpr.Concrete 114.0
          sightDistance = ValueOrExpr.Concrete 740.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORFRAD.s3o"
          buildPic = Some "CORFRAD.DDS"
          script = Some "Units/CORFRAD.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingexplosiongeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -15 0"
          collisionVolumeScales = Some "32 95 32"
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
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "-1.90951538086 -2.08381778564 1.08252716064"
                collisionVolumeScales = Some "41.2277526855 50.2841644287 42.4677886963"
                collisionVolumeType = Some "Box"
                damage = Some 62.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 80.0
                object_ = Some "Units/corfrad_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
          ])
          sounds = Some (
            { build = None
              repair = None
              working = Some "cmd-on"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = []
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = []
              select = ["radarselect"] })
          customParams = Map.ofList [
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "CorBuildings/SeaUtil"
              "unitgroup", "util"
          ]
          extras = Map.ofList [
              "buildangle", "16384.0"
              "canattack", "false"
              "onoffable", "false"
              "radardistance", "2100.0"
              "radaremitheight", "72.0"
              "sightemitheight", "72.0"
              "sonardistance", "900.0"
          ] }

    let corfradToFlat (def: UnitDef) : Corfrad =
        { name = def.name
          subfolder = def.subfolder
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          yardMap = def.building.Value.yardMap.Value
          activateWhenBuilt = def.building.Value.activateWhenBuilt.Value
          canRepeat = def.building.Value.canRepeat.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corfradToUnitDef (flat: Corfrad) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = None
          builder = None
          weapons = None
          economy = None
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = Some flat.activateWhenBuilt
              canRepeat = Some flat.canRepeat
            }
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Cornanotc2plat =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          objectName: string option
          buildPic: string option
          script: string option
          corpse: string option
          explodeAs: string option
          selfDestructAs: string option
          collisionVolumeOffsets: string option
          collisionVolumeScales: string option
          collisionVolumeType: string option
          seismicSignature: float option
          category: string option
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let cornanotc2plat : Cornanotc2plat =
        { name = "cornanotc2plat"
          subfolder = "CorBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 840.0
          energyCost = ValueOrExpr.Concrete 12800.0
          buildTime = ValueOrExpr.Concrete 21000.0
          health = ValueOrExpr.Concrete 2200.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/cornanotc2plat.s3o"
          buildPic = Some "cornanotc2plat.DDS"
          script = Some "Units/CORNANOT2.cob"
          corpse = None
          explodeAs = Some "nanoboom"
          selfDestructAs = Some "nanoselfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "46 80 46"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          sounds =
              { build = Some "nanlath1"
                repair = Some "repair1"
                working = Some "reclaim1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["varmmove"]
                select = ["varmsel"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "5.0"
                "buildinggrounddecalsizey", "5.0"
                "buildinggrounddecaltype", "decals/cornanotc_aoplane.dds"
                "model_author", "Beherith, Hornet"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBuildings/SeaUtil"
                "unitgroup", "builder"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "canassist", "true"
                "canfight", "true"
                "canguard", "true"
                "canpatrol", "true"
                "canreclaim", "true"
                "canstop", "true"
                "cantbetransported", "false"
                "leavesghost", "true"
                "mass", "5100.0"
                "upright", "true"
            ] }

    let cornanotc2platDef : UnitDef =
        { name = "cornanotc2plat"
          subfolder = "CorBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 840.0
          energyCost = ValueOrExpr.Concrete 12800.0
          buildTime = ValueOrExpr.Concrete 21000.0
          health = ValueOrExpr.Concrete 2200.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/cornanotc2plat.s3o"
          buildPic = Some "cornanotc2plat.DDS"
          script = Some "Units/CORNANOT2.cob"
          corpse = None
          explodeAs = Some "nanoboom"
          selfDestructAs = Some "nanoselfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "46 80 46"
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
            { build = Some "nanlath1"
              repair = Some "repair1"
              working = Some "reclaim1"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["varmmove"]
              select = ["varmsel"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecaltype", "decals/cornanotc_aoplane.dds"
              "model_author", "Beherith, Hornet"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorBuildings/SeaUtil"
              "unitgroup", "builder"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "canassist", "true"
              "canfight", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canreclaim", "true"
              "canstop", "true"
              "cantbetransported", "false"
              "leavesghost", "true"
              "mass", "5100.0"
              "upright", "true"
          ] }

    let cornanotc2platToFlat (def: UnitDef) : Cornanotc2plat =
        { name = def.name
          subfolder = def.subfolder
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let cornanotc2platToUnitDef (flat: Cornanotc2plat) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = None
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Cornanotcplat =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          objectName: string option
          buildPic: string option
          script: string option
          corpse: string option
          explodeAs: string option
          selfDestructAs: string option
          collisionVolumeOffsets: string option
          collisionVolumeScales: string option
          collisionVolumeType: string option
          seismicSignature: float option
          category: string option
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let cornanotcplat : Cornanotcplat =
        { name = "cornanotcplat"
          subfolder = "CorBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 230.0
          energyCost = ValueOrExpr.Concrete 3200.0
          buildTime = ValueOrExpr.Concrete 5300.0
          health = ValueOrExpr.Concrete 560.0
          sightDistance = ValueOrExpr.Concrete 380.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORNANOTCPLAT.s3o"
          buildPic = Some "CORNANOTCPLAT.DDS"
          script = Some "Units/CORNANOTCPLAT.cob"
          corpse = None
          explodeAs = Some "nanoboom"
          selfDestructAs = Some "nanoselfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "31 50 31"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          sounds =
              { build = Some "nanlath2"
                repair = Some "repair2"
                working = Some "reclaim1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = Some "capture1"
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["vcormove"]
                select = ["vcorsel"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "5.0"
                "buildinggrounddecalsizey", "5.0"
                "buildinggrounddecaltype", "decals/cornanotc_aoplane.dds"
                "model_author", "Beherith"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBuildings/SeaUtil"
                "unitgroup", "builder"
                "usebuildinggrounddecal", "false"
            ]
          extras = Map.ofList [
                "canassist", "true"
                "canfight", "true"
                "canguard", "true"
                "canpatrol", "true"
                "canreclaim", "true"
                "canstop", "true"
                "cantbetransported", "true"
                "leavesghost", "true"
                "mass", "700.0"
                "upright", "true"
            ] }

    let cornanotcplatDef : UnitDef =
        { name = "cornanotcplat"
          subfolder = "CorBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 230.0
          energyCost = ValueOrExpr.Concrete 3200.0
          buildTime = ValueOrExpr.Concrete 5300.0
          health = ValueOrExpr.Concrete 560.0
          sightDistance = ValueOrExpr.Concrete 380.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORNANOTCPLAT.s3o"
          buildPic = Some "CORNANOTCPLAT.DDS"
          script = Some "Units/CORNANOTCPLAT.cob"
          corpse = None
          explodeAs = Some "nanoboom"
          selfDestructAs = Some "nanoselfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "31 50 31"
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
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecaltype", "decals/cornanotc_aoplane.dds"
              "model_author", "Beherith"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorBuildings/SeaUtil"
              "unitgroup", "builder"
              "usebuildinggrounddecal", "false"
          ]
          extras = Map.ofList [
              "canassist", "true"
              "canfight", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canreclaim", "true"
              "canstop", "true"
              "cantbetransported", "true"
              "leavesghost", "true"
              "mass", "700.0"
              "upright", "true"
          ] }

    let cornanotcplatToFlat (def: UnitDef) : Cornanotcplat =
        { name = def.name
          subfolder = def.subfolder
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let cornanotcplatToUnitDef (flat: Cornanotcplat) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = None
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corsonar =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          objectName: string option
          buildPic: string option
          script: string option
          corpse: string option
          explodeAs: string option
          selfDestructAs: string option
          collisionVolumeOffsets: string option
          collisionVolumeScales: string option
          collisionVolumeType: string option
          seismicSignature: float option
          category: string option
          yardMap: string
          activateWhenBuilt: bool
          canRepeat: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corsonar : Corsonar =
        { name = "corsonar"
          subfolder = "CorBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 20.0
          energyCost = ValueOrExpr.Concrete 450.0
          buildTime = ValueOrExpr.Concrete 900.0
          health = ValueOrExpr.Concrete 58.0
          sightDistance = ValueOrExpr.Concrete 485.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORSONAR.s3o"
          buildPic = Some "CORSONAR.DDS"
          script = Some "Units/CORSONAR.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallBuildingexplosiongeneric-uw"
          selfDestructAs = Some "smallBuildingExplosionGenericSelfd-uw"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "30 33 30"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          yardMap = "oooo"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-0.230186462402 -5.31005859372e-06 -1.15662384033"
                  collisionVolumeScales = Some "32.5395965576 31.6859893799 26.2655792236"
                  collisionVolumeType = Some "Box"
                  damage = Some 31.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 13.0
                  object_ = Some "Units/corsonar_dead.s3o"
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
                select = ["sonar2"] }
          customParams = Map.ofList [
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/SeaUtil"
                "unitgroup", "util"
            ]
          extras = Map.ofList [
                "buildangle", "8192.0"
                "canattack", "false"
                "onoffable", "false"
                "sonardistance", "1200.0"
            ] }

    let corsonarDef : UnitDef =
        { name = "corsonar"
          subfolder = "CorBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 20.0
          energyCost = ValueOrExpr.Concrete 450.0
          buildTime = ValueOrExpr.Concrete 900.0
          health = ValueOrExpr.Concrete 58.0
          sightDistance = ValueOrExpr.Concrete 485.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORSONAR.s3o"
          buildPic = Some "CORSONAR.DDS"
          script = Some "Units/CORSONAR.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallBuildingexplosiongeneric-uw"
          selfDestructAs = Some "smallBuildingExplosionGenericSelfd-uw"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "30 33 30"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "oooo"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "-0.230186462402 -5.31005859372e-06 -1.15662384033"
                collisionVolumeScales = Some "32.5395965576 31.6859893799 26.2655792236"
                collisionVolumeType = Some "Box"
                damage = Some 31.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 13.0
                object_ = Some "Units/corsonar_dead.s3o"
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
              select = ["sonar2"] })
          customParams = Map.ofList [
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "CorBuildings/SeaUtil"
              "unitgroup", "util"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
              "canattack", "false"
              "onoffable", "false"
              "sonardistance", "1200.0"
          ] }

    let corsonarToFlat (def: UnitDef) : Corsonar =
        { name = def.name
          subfolder = def.subfolder
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          yardMap = def.building.Value.yardMap.Value
          activateWhenBuilt = def.building.Value.activateWhenBuilt.Value
          canRepeat = def.building.Value.canRepeat.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corsonarToUnitDef (flat: Corsonar) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = None
          builder = None
          weapons = None
          economy = None
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = Some flat.activateWhenBuilt
              canRepeat = Some flat.canRepeat
            }
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

