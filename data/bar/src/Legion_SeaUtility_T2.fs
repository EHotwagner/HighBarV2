// Auto-generated BAR unit data: Legion/SeaUtility/T2 (unified)
namespace BarData.Units

open BarData

module Legion_SeaUtility_T2 =

    type Leganavalpinpointer =
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

    let leganavalpinpointer : Leganavalpinpointer =
        { name = "leganavalpinpointer"
          subfolder = "Legion/SeaUtility/T2"
          metalCost = ValueOrExpr.Concrete 800.0
          energyCost = ValueOrExpr.Concrete 7500.0
          buildTime = ValueOrExpr.Concrete 10300.0
          health = ValueOrExpr.Concrete 1530.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/leganavalpinpointer.s3o"
          buildPic = Some "leganavalpinpointer.DDS"
          script = Some "Units/leganavalpinpointer.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "69 95 58"
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
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "69 85 58"
                  collisionVolumeType = Some "Box"
                  damage = Some 825.0
                  featureDead = Some "HEAP"
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 20.0
                  metal = Some 447.0
                  object_ = Some "Units/leganavalpinpointer_dead.s3o"
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
                "model_author", "Protar, ZephyrSkies"
                "normaltex", "unittextures/leg_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "Legion/SeaUtility/T2"
                "techlevel", "2.0"
                "unitgroup", "util"
            ]
          extras = Map.ofList [
                "buildangle", "16384.0"
                "energyupkeep", "150.0"
                "istargetingupgrade", "true"
                "onoffable", "true"
            ] }

    let leganavalpinpointerDef : UnitDef =
        { name = "leganavalpinpointer"
          subfolder = "Legion/SeaUtility/T2"
          metalCost = ValueOrExpr.Concrete 800.0
          energyCost = ValueOrExpr.Concrete 7500.0
          buildTime = ValueOrExpr.Concrete 10300.0
          health = ValueOrExpr.Concrete 1530.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/leganavalpinpointer.s3o"
          buildPic = Some "leganavalpinpointer.DDS"
          script = Some "Units/leganavalpinpointer.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "69 95 58"
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
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "69 85 58"
                collisionVolumeType = Some "Box"
                damage = Some 825.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 447.0
                object_ = Some "Units/leganavalpinpointer_dead.s3o"
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
              "model_author", "Protar, ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "Legion/SeaUtility/T2"
              "techlevel", "2.0"
              "unitgroup", "util"
          ]
          extras = Map.ofList [
              "buildangle", "16384.0"
              "energyupkeep", "150.0"
              "istargetingupgrade", "true"
              "onoffable", "true"
          ] }

    let leganavalpinpointerToFlat (def: UnitDef) : Leganavalpinpointer =
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

    let leganavalpinpointerToUnitDef (flat: Leganavalpinpointer) : UnitDef =
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

    type Leganavalsonarstation =
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

    let leganavalsonarstation : Leganavalsonarstation =
        { name = "leganavalsonarstation"
          subfolder = "Legion/SeaUtility/T2"
          metalCost = ValueOrExpr.Concrete 160.0
          energyCost = ValueOrExpr.Concrete 2400.0
          buildTime = ValueOrExpr.Concrete 6100.0
          health = ValueOrExpr.Concrete 2400.0
          sightDistance = ValueOrExpr.Concrete 210.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/leganavalsonarstation.s3o"
          buildPic = Some "leganavalsonarstation.DDS"
          script = Some "Units/leganavalsonarstation.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingexplosiongeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 30 0"
          collisionVolumeScales = Some "59 48 32"
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
                  collisionVolumeOffsets = Some "0 30 0"
                  collisionVolumeScales = Some "59 38 32"
                  collisionVolumeType = Some "Box"
                  damage = Some 1284.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 99.0
                  object_ = Some "Units/leganavalsonarstation_dead.s3o"
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
                "buildinggrounddecaltype", "decals/leganavalsonarstation_aoplane.dds"
                "model_author", "ZephyrSkies (Model), JjackVII (Concept Art)"
                "normaltex", "unittextures/leg_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "Legion/SeaUtility/T2"
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

    let leganavalsonarstationDef : UnitDef =
        { name = "leganavalsonarstation"
          subfolder = "Legion/SeaUtility/T2"
          metalCost = ValueOrExpr.Concrete 160.0
          energyCost = ValueOrExpr.Concrete 2400.0
          buildTime = ValueOrExpr.Concrete 6100.0
          health = ValueOrExpr.Concrete 2400.0
          sightDistance = ValueOrExpr.Concrete 210.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/leganavalsonarstation.s3o"
          buildPic = Some "leganavalsonarstation.DDS"
          script = Some "Units/leganavalsonarstation.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingexplosiongeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 30 0"
          collisionVolumeScales = Some "59 48 32"
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
                collisionVolumeOffsets = Some "0 30 0"
                collisionVolumeScales = Some "59 38 32"
                collisionVolumeType = Some "Box"
                damage = Some 1284.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 99.0
                object_ = Some "Units/leganavalsonarstation_dead.s3o"
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
              "buildinggrounddecaltype", "decals/leganavalsonarstation_aoplane.dds"
              "model_author", "ZephyrSkies (Model), JjackVII (Concept Art)"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "Legion/SeaUtility/T2"
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

    let leganavalsonarstationToFlat (def: UnitDef) : Leganavalsonarstation =
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

    let leganavalsonarstationToUnitDef (flat: Leganavalsonarstation) : UnitDef =
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

