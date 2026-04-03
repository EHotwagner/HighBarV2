// Auto-generated BAR unit data: ArmBuildings/LandEconomy (unified)
namespace BarData.Units

open BarData

module ArmBuildings_LandEconomy =

    type Armadvsol =
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
          energyMake: ValueOrExpr<float>
          energyStorage: float
          yardMap: string
          activateWhenBuilt: bool
          canRepeat: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armadvsol : Armadvsol =
        { name = "armadvsol"
          subfolder = "ArmBuildings/LandEconomy"
          metalCost = ValueOrExpr.Concrete 350.0
          energyCost = ValueOrExpr.Concrete 5000.0
          buildTime = ValueOrExpr.Concrete 7950.0
          health = ValueOrExpr.Concrete 1130.0
          sightDistance = ValueOrExpr.Concrete 260.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMADVSOL.s3o"
          buildPic = Some "ARMADVSOL.DDS"
          script = Some "Units/ARMADVSOL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallBuildingExplosionGeneric"
          selfDestructAs = Some "smallBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "46 34 46"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          energyMake = ValueOrExpr.Concrete 80.0
          energyStorage = 100.0
          yardMap = "oooo oooo oooo oooo"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -3 -1"
                  collisionVolumeScales = Some "49 7 49"
                  collisionVolumeType = Some "CylY"
                  damage = Some 612.0
                  featureDead = Some "HEAP"
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 12.0
                  metal = Some 223.0
                  object_ = Some "Units/armadvsol_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 306.0
                  featureDead = None
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = None
                  metal = Some 89.0
                  object_ = Some "Units/arm4X4A.s3o"
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
                select = ["solar1"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "6.0"
                "buildinggrounddecalsizey", "6.0"
                "buildinggrounddecaltype", "decals/armadvsol_aoplane.dds"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "solar", "true"
                "subfolder", "ArmBuildings/LandEconomy"
                "unitgroup", "energy"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "4096.0"
                "damagemodifier", "0.9"
            ] }

    let armadvsolDef : UnitDef =
        { name = "armadvsol"
          subfolder = "ArmBuildings/LandEconomy"
          metalCost = ValueOrExpr.Concrete 350.0
          energyCost = ValueOrExpr.Concrete 5000.0
          buildTime = ValueOrExpr.Concrete 7950.0
          health = ValueOrExpr.Concrete 1130.0
          sightDistance = ValueOrExpr.Concrete 260.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMADVSOL.s3o"
          buildPic = Some "ARMADVSOL.DDS"
          script = Some "Units/ARMADVSOL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallBuildingExplosionGeneric"
          selfDestructAs = Some "smallBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "46 34 46"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 80.0)
              metalMake = None
              energyStorage = Some 100.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooo oooo oooo oooo"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -3 -1"
                collisionVolumeScales = Some "49 7 49"
                collisionVolumeType = Some "CylY"
                damage = Some 612.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 12.0
                metal = Some 223.0
                object_ = Some "Units/armadvsol_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 306.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = None
                metal = Some 89.0
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
              select = ["solar1"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "6.0"
              "buildinggrounddecalsizey", "6.0"
              "buildinggrounddecaltype", "decals/armadvsol_aoplane.dds"
              "model_author", "Cremuss"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "solar", "true"
              "subfolder", "ArmBuildings/LandEconomy"
              "unitgroup", "energy"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "4096.0"
              "damagemodifier", "0.9"
          ] }

    let armadvsolToFlat (def: UnitDef) : Armadvsol =
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
          energyMake = def.economy.Value.energyMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          yardMap = def.building.Value.yardMap.Value
          activateWhenBuilt = def.building.Value.activateWhenBuilt.Value
          canRepeat = def.building.Value.canRepeat.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armadvsolToUnitDef (flat: Armadvsol) : UnitDef =
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
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = None
              energyStorage = Some flat.energyStorage
              metalStorage = None
              extractsMetal = None
            }
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = Some flat.activateWhenBuilt
              canRepeat = Some flat.canRepeat
            }
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armafus =
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
          energyMake: ValueOrExpr<float>
          energyStorage: float
          yardMap: string
          canRepeat: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armafus : Armafus =
        { name = "armafus"
          subfolder = "ArmBuildings/LandEconomy"
          metalCost = ValueOrExpr.Concrete 9700.0
          energyCost = ValueOrExpr.Concrete 69000.0
          buildTime = ValueOrExpr.Concrete 312500.0
          health = ValueOrExpr.Concrete 7900.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/ARMAFUS.s3o"
          buildPic = Some "ARMAFUS.DDS"
          script = Some "Units/ARMAFUS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "customfusionexplo"
          selfDestructAs = Some "advancedFusionExplosionSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "96 96 96"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          energyMake = ValueOrExpr.Concrete 3000.0
          energyStorage = 9000.0
          yardMap = "oooooooooooooooooooooooooooooooooooo"
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "96 96 96"
                  collisionVolumeType = Some "Box"
                  damage = Some 16290.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 4.0
                  height = Some 40.0
                  metal = Some 6441.0
                  object_ = Some "Units/armafus_dead.s3o"
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
                  metal = Some 2576.0
                  object_ = Some "Units/arm4X4A.s3o"
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
                select = ["fusion1"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "9.0"
                "buildinggrounddecalsizey", "9.0"
                "buildinggrounddecaltype", "decals/armafus_aoplane.dds"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandEconomy"
                "techlevel", "2.0"
                "unitgroup", "energy"
                "restrictions_inclusion", "_nofusion_"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "4096.0"
                "damagemodifier", "0.95"
            ] }

    let armafusDef : UnitDef =
        { name = "armafus"
          subfolder = "ArmBuildings/LandEconomy"
          metalCost = ValueOrExpr.Concrete 9700.0
          energyCost = ValueOrExpr.Concrete 69000.0
          buildTime = ValueOrExpr.Concrete 312500.0
          health = ValueOrExpr.Concrete 7900.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/ARMAFUS.s3o"
          buildPic = Some "ARMAFUS.DDS"
          script = Some "Units/ARMAFUS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "customfusionexplo"
          selfDestructAs = Some "advancedFusionExplosionSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "96 96 96"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 3000.0)
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
                collisionVolumeScales = Some "96 96 96"
                collisionVolumeType = Some "Box"
                damage = Some 16290.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 4.0
                height = Some 40.0
                metal = Some 6441.0
                object_ = Some "Units/armafus_dead.s3o"
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
              "buildinggrounddecalsizex", "9.0"
              "buildinggrounddecalsizey", "9.0"
              "buildinggrounddecaltype", "decals/armafus_aoplane.dds"
              "model_author", "Cremuss"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/LandEconomy"
              "techlevel", "2.0"
              "unitgroup", "energy"
              "restrictions_inclusion", "_nofusion_"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "4096.0"
              "damagemodifier", "0.95"
          ] }

    let armafusToFlat (def: UnitDef) : Armafus =
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
          energyMake = def.economy.Value.energyMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          yardMap = def.building.Value.yardMap.Value
          canRepeat = def.building.Value.canRepeat.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armafusToUnitDef (flat: Armafus) : UnitDef =
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
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = None
              energyStorage = Some flat.energyStorage
              metalStorage = None
              extractsMetal = None
            }
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = None
              canRepeat = Some flat.canRepeat
            }
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armageo =
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
          energyMake: ValueOrExpr<float>
          energyStorage: float
          yardMap: string
          activateWhenBuilt: bool
          canRepeat: bool
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armageo : Armageo =
        { name = "armageo"
          subfolder = "ArmBuildings/LandEconomy"
          metalCost = ValueOrExpr.Concrete 1600.0
          energyCost = ValueOrExpr.Concrete 27000.0
          buildTime = ValueOrExpr.Concrete 50000.0
          health = ValueOrExpr.Concrete 3600.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/ARMAGEO.s3o"
          buildPic = Some "ARMAGEO.DDS"
          script = Some "Units/ARMAGEO.cob"
          corpse = None
          explodeAs = Some "customfusionexplo"
          selfDestructAs = Some "advgeo"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "107 77 107"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          energyMake = ValueOrExpr.Concrete 1250.0
          energyStorage = 12000.0
          yardMap = "h cbgybsyybc bsbssbbssb ysbsbssbbg ybsssbsssy sbsbsssbsb bsbsssbsbs ysssbsssby gbbssbsbsy bssbbssbsb cbyysbygbc"
          activateWhenBuilt = true
          canRepeat = false
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
                select = ["geothrm1"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "11.0"
                "buildinggrounddecalsizey", "11.0"
                "buildinggrounddecaltype", "decals/armageo_aoplane.dds"
                "cvbuildable", "true"
                "geothermal", "1.0"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandEconomy"
                "techlevel", "2.0"
                "unitgroup", "energy"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "0.0"
            ] }

    let armageoDef : UnitDef =
        { name = "armageo"
          subfolder = "ArmBuildings/LandEconomy"
          metalCost = ValueOrExpr.Concrete 1600.0
          energyCost = ValueOrExpr.Concrete 27000.0
          buildTime = ValueOrExpr.Concrete 50000.0
          health = ValueOrExpr.Concrete 3600.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/ARMAGEO.s3o"
          buildPic = Some "ARMAGEO.DDS"
          script = Some "Units/ARMAGEO.cob"
          corpse = None
          explodeAs = Some "customfusionexplo"
          selfDestructAs = Some "advgeo"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "107 77 107"
          collisionVolumeType = Some "CylY"
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
              select = ["geothrm1"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "11.0"
              "buildinggrounddecalsizey", "11.0"
              "buildinggrounddecaltype", "decals/armageo_aoplane.dds"
              "cvbuildable", "true"
              "geothermal", "1.0"
              "model_author", "Cremuss"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/LandEconomy"
              "techlevel", "2.0"
              "unitgroup", "energy"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "0.0"
          ] }

    let armageoToFlat (def: UnitDef) : Armageo =
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
          energyMake = def.economy.Value.energyMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          yardMap = def.building.Value.yardMap.Value
          activateWhenBuilt = def.building.Value.activateWhenBuilt.Value
          canRepeat = def.building.Value.canRepeat.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armageoToUnitDef (flat: Armageo) : UnitDef =
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
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = None
              energyStorage = Some flat.energyStorage
              metalStorage = None
              extractsMetal = None
            }
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = Some flat.activateWhenBuilt
              canRepeat = Some flat.canRepeat
            }
          featureDefs = None
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armamex =
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
          metalStorage: float
          extractsMetal: float
          yardMap: string
          activateWhenBuilt: bool
          canRepeat: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armamex : Armamex =
        { name = "armamex"
          subfolder = "ArmBuildings/LandEconomy"
          metalCost = ValueOrExpr.Concrete 200.0
          energyCost = ValueOrExpr.Concrete 1500.0
          buildTime = ValueOrExpr.Concrete 1800.0
          health = ValueOrExpr.Concrete 1610.0
          sightDistance = ValueOrExpr.Concrete 286.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMAMEX.s3o"
          buildPic = Some "ARMAMEX.DDS"
          script = Some "Units/ARMAMEX.cob"
          corpse = Some "DEAD"
          explodeAs = Some "empblast"
          selfDestructAs = Some "empblast"
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "70 38 60"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          metalStorage = 75.0
          extractsMetal = 0.001
          yardMap = "h cbbbbbbc bssssosb bosbbssb bsbbbbsb bsbbbbsb bssbbsob bsossssb cbbbbbbc"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "70 50 70"
                  collisionVolumeType = Some "CylY"
                  damage = Some 870.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 9.0
                  metal = Some 103.0
                  object_ = Some "Units/armamex_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 435.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = None
                  metal = Some 41.0
                  object_ = Some "Units/arm3X3A.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = Some "mexrun2"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["servmed2"]
                select = ["mexon2"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "5.0"
                "buildinggrounddecalsizey", "5.0"
                "buildinggrounddecaltype", "decals/armamex_aoplane.dds"
                "cvbuildable", "true"
                "metal_extractor", "1.0"
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandEconomy"
                "unitgroup", "metal"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "6092.0"
                "cloakcost", "12.0"
                "energyupkeep", "3.0"
                "mincloakdistance", "66.0"
                "onoffable", "true"
                "selfdestructcountdown", "1.0"
                "stealth", "true"
            ] }

    let armamexDef : UnitDef =
        { name = "armamex"
          subfolder = "ArmBuildings/LandEconomy"
          metalCost = ValueOrExpr.Concrete 200.0
          energyCost = ValueOrExpr.Concrete 1500.0
          buildTime = ValueOrExpr.Concrete 1800.0
          health = ValueOrExpr.Concrete 1610.0
          sightDistance = ValueOrExpr.Concrete 286.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMAMEX.s3o"
          buildPic = Some "ARMAMEX.DDS"
          script = Some "Units/ARMAMEX.cob"
          corpse = Some "DEAD"
          explodeAs = Some "empblast"
          selfDestructAs = Some "empblast"
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "70 38 60"
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
              metalStorage = Some 75.0
              extractsMetal = Some 0.001 })
          building = Some (
            { yardMap = Some "h cbbbbbbc bssssosb bosbbssb bsbbbbsb bsbbbbsb bssbbsob bsossssb cbbbbbbc"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "70 50 70"
                collisionVolumeType = Some "CylY"
                damage = Some 870.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 9.0
                metal = Some 103.0
                object_ = Some "Units/armamex_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 435.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = None
                metal = Some 41.0
                object_ = Some "Units/arm3X3A.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = None
              repair = None
              working = Some "mexrun2"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["servmed2"]
              select = ["mexon2"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecaltype", "decals/armamex_aoplane.dds"
              "cvbuildable", "true"
              "metal_extractor", "1.0"
              "model_author", "Beherith"
              "normaltex", "unittextures/Arm_normal.dds"
              "removewait", "true"
              "subfolder", "ArmBuildings/LandEconomy"
              "unitgroup", "metal"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "6092.0"
              "cloakcost", "12.0"
              "energyupkeep", "3.0"
              "mincloakdistance", "66.0"
              "onoffable", "true"
              "selfdestructcountdown", "1.0"
              "stealth", "true"
          ] }

    let armamexToFlat (def: UnitDef) : Armamex =
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
          metalStorage = def.economy.Value.metalStorage.Value
          extractsMetal = def.economy.Value.extractsMetal.Value
          yardMap = def.building.Value.yardMap.Value
          activateWhenBuilt = def.building.Value.activateWhenBuilt.Value
          canRepeat = def.building.Value.canRepeat.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armamexToUnitDef (flat: Armamex) : UnitDef =
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
          economy = Some {
              energyMake = None
              metalMake = None
              energyStorage = None
              metalStorage = Some flat.metalStorage
              extractsMetal = Some flat.extractsMetal
            }
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = Some flat.activateWhenBuilt
              canRepeat = Some flat.canRepeat
            }
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armckfus =
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
          energyMake: ValueOrExpr<float>
          energyStorage: float
          yardMap: string
          canRepeat: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armckfus : Armckfus =
        { name = "armckfus"
          subfolder = "ArmBuildings/LandEconomy"
          metalCost = ValueOrExpr.Concrete 3650.0
          energyCost = ValueOrExpr.Concrete 22000.0
          buildTime = ValueOrExpr.Concrete 65000.0
          health = ValueOrExpr.Concrete 3800.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 6.0
          footprintZ = 5.0
          objectName = Some "Units/ARMCKFUS.s3o"
          buildPic = Some "ARMCKFUS.DDS"
          script = Some "Units/ARMCKFUS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "fusionExplosion"
          selfDestructAs = Some "fusionExplosionSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "97 42 51"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          energyMake = ValueOrExpr.Concrete 750.0
          energyStorage = 2500.0
          yardMap = "oooooo oooooo oooooo oooooo oooooo"
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-1.82577514648 0.0764762817383 -0.28246307373"
                  collisionVolumeScales = Some "83.349395752 31.1307525635 52.6837921143"
                  collisionVolumeType = Some "Box"
                  damage = Some 2880.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 4.0
                  height = Some 40.0
                  metal = Some 3100.0
                  object_ = Some "Units/armckfus_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 1440.0
                  featureDead = None
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 4.0
                  metal = Some 1240.0
                  object_ = Some "Units/arm4X4A.s3o"
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
                select = ["fusion1"] }
          customParams = Map.ofList [
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandEconomy"
                "techlevel", "2.0"
                "unitgroup", "energy"
                "restrictions_inclusion", "_nofusion_"
            ]
          extras = Map.ofList [
                "buildangle", "4096.0"
                "cloakcost", "75.0"
                "mincloakdistance", "100.0"
            ] }

    let armckfusDef : UnitDef =
        { name = "armckfus"
          subfolder = "ArmBuildings/LandEconomy"
          metalCost = ValueOrExpr.Concrete 3650.0
          energyCost = ValueOrExpr.Concrete 22000.0
          buildTime = ValueOrExpr.Concrete 65000.0
          health = ValueOrExpr.Concrete 3800.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 6.0
          footprintZ = 5.0
          objectName = Some "Units/ARMCKFUS.s3o"
          buildPic = Some "ARMCKFUS.DDS"
          script = Some "Units/ARMCKFUS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "fusionExplosion"
          selfDestructAs = Some "fusionExplosionSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "97 42 51"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 750.0)
              metalMake = None
              energyStorage = Some 2500.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooooo oooooo oooooo oooooo oooooo"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "-1.82577514648 0.0764762817383 -0.28246307373"
                collisionVolumeScales = Some "83.349395752 31.1307525635 52.6837921143"
                collisionVolumeType = Some "Box"
                damage = Some 2880.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 4.0
                height = Some 40.0
                metal = Some 3100.0
                object_ = Some "Units/armckfus_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 1440.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 4.0
                metal = Some 1240.0
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
              "model_author", "Cremuss"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/LandEconomy"
              "techlevel", "2.0"
              "unitgroup", "energy"
              "restrictions_inclusion", "_nofusion_"
          ]
          extras = Map.ofList [
              "buildangle", "4096.0"
              "cloakcost", "75.0"
              "mincloakdistance", "100.0"
          ] }

    let armckfusToFlat (def: UnitDef) : Armckfus =
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
          energyMake = def.economy.Value.energyMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          yardMap = def.building.Value.yardMap.Value
          canRepeat = def.building.Value.canRepeat.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armckfusToUnitDef (flat: Armckfus) : UnitDef =
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
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = None
              energyStorage = Some flat.energyStorage
              metalStorage = None
              extractsMetal = None
            }
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = None
              canRepeat = Some flat.canRepeat
            }
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armestor =
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
          energyStorage: float
          yardMap: string
          activateWhenBuilt: bool
          canRepeat: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armestor : Armestor =
        { name = "armestor"
          subfolder = "ArmBuildings/LandEconomy"
          metalCost = ValueOrExpr.Concrete 170.0
          energyCost = ValueOrExpr.Concrete 1700.0
          buildTime = ValueOrExpr.Concrete 4110.0
          health = ValueOrExpr.Concrete 1890.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMESTOR.s3o"
          buildPic = Some "ARMESTOR.DDS"
          script = Some "Units/ARMESTOR.cob"
          corpse = Some "DEAD"
          explodeAs = Some "energystorage"
          selfDestructAs = Some "energystorageSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "42 34 42"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          energyStorage = 6000.0
          yardMap = "ooooooooo"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0361251831055 -3.17626953112e-05 -0.330192565918"
                  collisionVolumeScales = Some "39.6697540283 34.9461364746 42.0973052979"
                  collisionVolumeType = Some "Box"
                  damage = Some 1020.0
                  featureDead = Some "HEAP"
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 40.0
                  metal = Some 103.0
                  object_ = Some "Units/armestor_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 510.0
                  featureDead = None
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 4.0
                  metal = Some 41.0
                  object_ = Some "Units/arm4X4C.s3o"
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
                select = ["storngy1"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "5.0"
                "buildinggrounddecalsizey", "5.0"
                "buildinggrounddecaltype", "decals/armestor_aoplane.dds"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandEconomy"
                "unitgroup", "energy"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "4096.0"
            ] }

    let armestorDef : UnitDef =
        { name = "armestor"
          subfolder = "ArmBuildings/LandEconomy"
          metalCost = ValueOrExpr.Concrete 170.0
          energyCost = ValueOrExpr.Concrete 1700.0
          buildTime = ValueOrExpr.Concrete 4110.0
          health = ValueOrExpr.Concrete 1890.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMESTOR.s3o"
          buildPic = Some "ARMESTOR.DDS"
          script = Some "Units/ARMESTOR.cob"
          corpse = Some "DEAD"
          explodeAs = Some "energystorage"
          selfDestructAs = Some "energystorageSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "42 34 42"
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
            { yardMap = Some "ooooooooo"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0361251831055 -3.17626953112e-05 -0.330192565918"
                collisionVolumeScales = Some "39.6697540283 34.9461364746 42.0973052979"
                collisionVolumeType = Some "Box"
                damage = Some 1020.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 40.0
                metal = Some 103.0
                object_ = Some "Units/armestor_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 510.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 4.0
                metal = Some 41.0
                object_ = Some "Units/arm4X4C.s3o"
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
              select = ["storngy1"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecaltype", "decals/armestor_aoplane.dds"
              "model_author", "Cremuss"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/LandEconomy"
              "unitgroup", "energy"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "4096.0"
          ] }

    let armestorToFlat (def: UnitDef) : Armestor =
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
          energyStorage = def.economy.Value.energyStorage.Value
          yardMap = def.building.Value.yardMap.Value
          activateWhenBuilt = def.building.Value.activateWhenBuilt.Value
          canRepeat = def.building.Value.canRepeat.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armestorToUnitDef (flat: Armestor) : UnitDef =
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
          economy = Some {
              energyMake = None
              metalMake = None
              energyStorage = Some flat.energyStorage
              metalStorage = None
              extractsMetal = None
            }
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = Some flat.activateWhenBuilt
              canRepeat = Some flat.canRepeat
            }
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armfus =
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
          energyMake: ValueOrExpr<float>
          energyStorage: float
          yardMap: string
          activateWhenBuilt: bool
          canRepeat: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armfus : Armfus =
        { name = "armfus"
          subfolder = "ArmBuildings/LandEconomy"
          metalCost = ValueOrExpr.Concrete 3350.0
          energyCost = ValueOrExpr.Concrete 18000.0
          buildTime = ValueOrExpr.Concrete 54000.0
          health = ValueOrExpr.Concrete 3800.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 6.0
          footprintZ = 5.0
          objectName = Some "Units/ARMFUS.s3o"
          buildPic = Some "ARMFUS.DDS"
          script = Some "Units/ARMFUS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "fusionExplosion"
          selfDestructAs = Some "fusionExplosionSelfd"
          collisionVolumeOffsets = Some "0 0 -2"
          collisionVolumeScales = Some "91 57 59"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          energyMake = ValueOrExpr.Concrete 750.0
          energyStorage = 2500.0
          yardMap = "oooooo oooooo oooooo oooooo oooooo"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.420112609863 0.0956184448242 -0.353080749512"
                  collisionVolumeScales = Some "98.7820892334 38.6634368896 65.8547515869"
                  collisionVolumeType = Some "Box"
                  damage = Some 2700.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 4.0
                  height = Some 40.0
                  metal = Some 2603.0
                  object_ = Some "Units/armfus_dead.s3o"
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
                select = ["fusion1"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "8.0"
                "buildinggrounddecalsizey", "8.0"
                "buildinggrounddecaltype", "decals/armfus_aoplane.dds"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandEconomy"
                "techlevel", "2.0"
                "unitgroup", "energy"
                "restrictions_inclusion", "_nofusion_"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "4096.0"
                "hidedamage", "true"
            ] }

    let armfusDef : UnitDef =
        { name = "armfus"
          subfolder = "ArmBuildings/LandEconomy"
          metalCost = ValueOrExpr.Concrete 3350.0
          energyCost = ValueOrExpr.Concrete 18000.0
          buildTime = ValueOrExpr.Concrete 54000.0
          health = ValueOrExpr.Concrete 3800.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 6.0
          footprintZ = 5.0
          objectName = Some "Units/ARMFUS.s3o"
          buildPic = Some "ARMFUS.DDS"
          script = Some "Units/ARMFUS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "fusionExplosion"
          selfDestructAs = Some "fusionExplosionSelfd"
          collisionVolumeOffsets = Some "0 0 -2"
          collisionVolumeScales = Some "91 57 59"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 750.0)
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
                collisionVolumeOffsets = Some "0.420112609863 0.0956184448242 -0.353080749512"
                collisionVolumeScales = Some "98.7820892334 38.6634368896 65.8547515869"
                collisionVolumeType = Some "Box"
                damage = Some 2700.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 4.0
                height = Some 40.0
                metal = Some 2603.0
                object_ = Some "Units/armfus_dead.s3o"
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
              "buildinggrounddecalsizex", "8.0"
              "buildinggrounddecalsizey", "8.0"
              "buildinggrounddecaltype", "decals/armfus_aoplane.dds"
              "model_author", "Cremuss"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/LandEconomy"
              "techlevel", "2.0"
              "unitgroup", "energy"
              "restrictions_inclusion", "_nofusion_"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "4096.0"
              "hidedamage", "true"
          ] }

    let armfusToFlat (def: UnitDef) : Armfus =
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
          energyMake = def.economy.Value.energyMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          yardMap = def.building.Value.yardMap.Value
          activateWhenBuilt = def.building.Value.activateWhenBuilt.Value
          canRepeat = def.building.Value.canRepeat.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armfusToUnitDef (flat: Armfus) : UnitDef =
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
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = None
              energyStorage = Some flat.energyStorage
              metalStorage = None
              extractsMetal = None
            }
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = Some flat.activateWhenBuilt
              canRepeat = Some flat.canRepeat
            }
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armgeo =
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
          energyMake: ValueOrExpr<float>
          energyStorage: float
          yardMap: string
          activateWhenBuilt: bool
          canRepeat: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armgeo : Armgeo =
        { name = "armgeo"
          subfolder = "ArmBuildings/LandEconomy"
          metalCost = ValueOrExpr.Concrete 560.0
          energyCost = ValueOrExpr.Concrete 13000.0
          buildTime = ValueOrExpr.Concrete 13100.0
          health = ValueOrExpr.Concrete 1940.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/ARMGEO.s3o"
          buildPic = Some "ARMGEO.DDS"
          script = Some "Units/ARMGEO.cob"
          corpse = Some "dead"
          explodeAs = Some "geo"
          selfDestructAs = Some "geo"
          collisionVolumeOffsets = Some "0 -4 0"
          collisionVolumeScales = Some "60 70 60"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          energyMake = ValueOrExpr.Concrete 300.0
          energyStorage = 1000.0
          yardMap = "h cbbbbgbbbc bgbggbbggb bgbgbggbbb bbgggbgggb gbgbgggbgb bgbgggbgbg bgggbgggbb bbbggbgbgb bggbbggbgb cbbbgbbbbc"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "60 70 60"
                  collisionVolumeType = Some "Box"
                  damage = Some 1050.0
                  featureDead = Some "HEAP"
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 40.0
                  metal = Some 338.0
                  object_ = Some "Units/armgeo_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 525.0
                  featureDead = None
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 4.0
                  metal = Some 135.0
                  object_ = Some "Units/arm4X4B.s3o"
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
                select = ["geothrm1"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "7.0"
                "buildinggrounddecalsizey", "7.0"
                "buildinggrounddecaltype", "decals/armgeo_aoplane.dds"
                "cvbuildable", "true"
                "geothermal", "1.0"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandEconomy"
                "unitgroup", "energy"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "2048.0"
            ] }

    let armgeoDef : UnitDef =
        { name = "armgeo"
          subfolder = "ArmBuildings/LandEconomy"
          metalCost = ValueOrExpr.Concrete 560.0
          energyCost = ValueOrExpr.Concrete 13000.0
          buildTime = ValueOrExpr.Concrete 13100.0
          health = ValueOrExpr.Concrete 1940.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/ARMGEO.s3o"
          buildPic = Some "ARMGEO.DDS"
          script = Some "Units/ARMGEO.cob"
          corpse = Some "dead"
          explodeAs = Some "geo"
          selfDestructAs = Some "geo"
          collisionVolumeOffsets = Some "0 -4 0"
          collisionVolumeScales = Some "60 70 60"
          collisionVolumeType = Some "Box"
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
                collisionVolumeScales = Some "60 70 60"
                collisionVolumeType = Some "Box"
                damage = Some 1050.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 40.0
                metal = Some 338.0
                object_ = Some "Units/armgeo_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 525.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 4.0
                metal = Some 135.0
                object_ = Some "Units/arm4X4B.s3o"
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
              select = ["geothrm1"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "7.0"
              "buildinggrounddecalsizey", "7.0"
              "buildinggrounddecaltype", "decals/armgeo_aoplane.dds"
              "cvbuildable", "true"
              "geothermal", "1.0"
              "model_author", "Cremuss"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/LandEconomy"
              "unitgroup", "energy"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "2048.0"
          ] }

    let armgeoToFlat (def: UnitDef) : Armgeo =
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
          energyMake = def.economy.Value.energyMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          yardMap = def.building.Value.yardMap.Value
          activateWhenBuilt = def.building.Value.activateWhenBuilt.Value
          canRepeat = def.building.Value.canRepeat.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armgeoToUnitDef (flat: Armgeo) : UnitDef =
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
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = None
              energyStorage = Some flat.energyStorage
              metalStorage = None
              extractsMetal = None
            }
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = Some flat.activateWhenBuilt
              canRepeat = Some flat.canRepeat
            }
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armgmm =
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
          energyMake: ValueOrExpr<float>
          energyStorage: float
          yardMap: string
          activateWhenBuilt: bool
          canRepeat: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armgmm : Armgmm =
        { name = "armgmm"
          subfolder = "ArmBuildings/LandEconomy"
          metalCost = ValueOrExpr.Concrete 1150.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 41500.0
          health = ValueOrExpr.Concrete 13900.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/ARMGMM.s3o"
          buildPic = Some "ARMGMM.DDS"
          script = Some "Units/ARMGMM.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingExplosionGeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 6 0"
          collisionVolumeScales = Some "72 33 72"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          energyMake = ValueOrExpr.Concrete 750.0
          energyStorage = 1500.0
          yardMap = "h cbygbsyybc bsbssbbssb ysbsbssbby ybsssbsssg sbsbsssbsb bsbsssbsbs gsssbsssby ybbssbsbsy bssbbssbsb cbyysbgybc"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.420112609863 0.0956184448242 -0.353080749512"
                  collisionVolumeScales = Some "72 33 72"
                  collisionVolumeType = Some "CylY"
                  damage = Some 7000.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 40.0
                  metal = Some 600.0
                  object_ = Some "Units/armgmm_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 2000.0
                  featureDead = None
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 4.0
                  metal = Some 300.0
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
                select = ["geothrm1"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "8.0"
                "buildinggrounddecalsizey", "8.0"
                "buildinggrounddecaltype", "decals/armgmm_aoplane.dds"
                "cvbuildable", "true"
                "geothermal", "1.0"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandEconomy"
                "techlevel", "2.0"
                "unitgroup", "energy"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "16384.0"
            ] }

    let armgmmDef : UnitDef =
        { name = "armgmm"
          subfolder = "ArmBuildings/LandEconomy"
          metalCost = ValueOrExpr.Concrete 1150.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 41500.0
          health = ValueOrExpr.Concrete 13900.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/ARMGMM.s3o"
          buildPic = Some "ARMGMM.DDS"
          script = Some "Units/ARMGMM.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingExplosionGeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 6 0"
          collisionVolumeScales = Some "72 33 72"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 750.0)
              metalMake = None
              energyStorage = Some 1500.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "h cbygbsyybc bsbssbbssb ysbsbssbby ybsssbsssg sbsbsssbsb bsbsssbsbs gsssbsssby ybbssbsbsy bssbbssbsb cbyysbgybc"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.420112609863 0.0956184448242 -0.353080749512"
                collisionVolumeScales = Some "72 33 72"
                collisionVolumeType = Some "CylY"
                damage = Some 7000.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 40.0
                metal = Some 600.0
                object_ = Some "Units/armgmm_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 2000.0
                featureDead = None
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 4.0
                metal = Some 300.0
                object_ = Some "Units/arm5X5A.s3o"
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
              select = ["geothrm1"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "8.0"
              "buildinggrounddecalsizey", "8.0"
              "buildinggrounddecaltype", "decals/armgmm_aoplane.dds"
              "cvbuildable", "true"
              "geothermal", "1.0"
              "model_author", "Cremuss"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/LandEconomy"
              "techlevel", "2.0"
              "unitgroup", "energy"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "16384.0"
          ] }

    let armgmmToFlat (def: UnitDef) : Armgmm =
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
          energyMake = def.economy.Value.energyMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          yardMap = def.building.Value.yardMap.Value
          activateWhenBuilt = def.building.Value.activateWhenBuilt.Value
          canRepeat = def.building.Value.canRepeat.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armgmmToUnitDef (flat: Armgmm) : UnitDef =
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
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = None
              energyStorage = Some flat.energyStorage
              metalStorage = None
              extractsMetal = None
            }
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = Some flat.activateWhenBuilt
              canRepeat = Some flat.canRepeat
            }
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armmakr =
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
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armmakr : Armmakr =
        { name = "armmakr"
          subfolder = "ArmBuildings/LandEconomy"
          metalCost = ValueOrExpr.Concrete 1.0
          energyCost = ValueOrExpr.Concrete 1150.0
          buildTime = ValueOrExpr.Concrete 2600.0
          health = ValueOrExpr.Concrete 167.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMMAKR.s3o"
          buildPic = Some "ARMMAKR.DDS"
          script = Some "Units/ARMMAKR.cob"
          corpse = None
          explodeAs = Some "metalmaker"
          selfDestructAs = Some "metalmakerSelfd"
          collisionVolumeOffsets = Some "0 -3 0"
          collisionVolumeScales = Some "40 40 40"
          collisionVolumeType = Some "CYLY"
          seismicSignature = Some 0.0
          category = None
          yardMap = "ooooooooo"
          activateWhenBuilt = true
          canRepeat = false
          sounds =
              { build = None
                repair = None
                working = Some "arm-bld-metalmaker"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["metlon1"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "5.0"
                "buildinggrounddecalsizey", "5.0"
                "buildinggrounddecaltype", "decals/armmakr_aoplane.dds"
                "energyconv_capacity", "70.0"
                "energyconv_efficiency", "0.01429"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandEconomy"
                "unitgroup", "metal"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "8192.0"
            ] }

    let armmakrDef : UnitDef =
        { name = "armmakr"
          subfolder = "ArmBuildings/LandEconomy"
          metalCost = ValueOrExpr.Concrete 1.0
          energyCost = ValueOrExpr.Concrete 1150.0
          buildTime = ValueOrExpr.Concrete 2600.0
          health = ValueOrExpr.Concrete 167.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMMAKR.s3o"
          buildPic = Some "ARMMAKR.DDS"
          script = Some "Units/ARMMAKR.cob"
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
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecaltype", "decals/armmakr_aoplane.dds"
              "energyconv_capacity", "70.0"
              "energyconv_efficiency", "0.01429"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/LandEconomy"
              "unitgroup", "metal"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
          ] }

    let armmakrToFlat (def: UnitDef) : Armmakr =
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
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armmakrToUnitDef (flat: Armmakr) : UnitDef =
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
          featureDefs = None
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armmex =
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
          metalStorage: float
          extractsMetal: float
          yardMap: string
          activateWhenBuilt: bool
          canRepeat: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armmex : Armmex =
        { name = "armmex"
          subfolder = "ArmBuildings/LandEconomy"
          metalCost = ValueOrExpr.Concrete 50.0
          energyCost = ValueOrExpr.Concrete 500.0
          buildTime = ValueOrExpr.Concrete 1800.0
          health = ValueOrExpr.Concrete 270.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMMEX.s3o"
          buildPic = Some "ARMMEX.DDS"
          script = Some "Units/ARMMEX.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallBuildingExplosionGeneric"
          selfDestructAs = Some "smallMex"
          collisionVolumeOffsets = Some "0 -2 0"
          collisionVolumeScales = Some "48 33 48"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = Some "CANBEUW"
          metalStorage = 50.0
          extractsMetal = 0.001
          yardMap = "h cbbbbbbc bsossbsb bbsbbsob bsbbbbsb bsbbbbsb bosbbsbb bsbssosb cbbbbbbc"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.510162353516 -0.044793737793 0.21223449707"
                  collisionVolumeScales = Some "52.280090332 25.2522125244 52.9224243164"
                  collisionVolumeType = Some "Box"
                  damage = Some 102.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 33.0
                  object_ = Some "Units/armmex_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 51.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 13.0
                  object_ = Some "Units/arm3X3B.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = Some "mexworking"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["mexselect"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "5.0"
                "buildinggrounddecalsizey", "5.0"
                "buildinggrounddecaltype", "decals/armmex_aoplane.dds"
                "cvbuildable", "true"
                "metal_extractor", "1.0"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandEconomy"
                "unitgroup", "metal"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "8192.0"
                "energyupkeep", "3.0"
                "onoffable", "true"
                "selfdestructcountdown", "1.0"
            ] }

    let armmexDef : UnitDef =
        { name = "armmex"
          subfolder = "ArmBuildings/LandEconomy"
          metalCost = ValueOrExpr.Concrete 50.0
          energyCost = ValueOrExpr.Concrete 500.0
          buildTime = ValueOrExpr.Concrete 1800.0
          health = ValueOrExpr.Concrete 270.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMMEX.s3o"
          buildPic = Some "ARMMEX.DDS"
          script = Some "Units/ARMMEX.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallBuildingExplosionGeneric"
          selfDestructAs = Some "smallMex"
          collisionVolumeOffsets = Some "0 -2 0"
          collisionVolumeScales = Some "48 33 48"
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
              extractsMetal = Some 0.001 })
          building = Some (
            { yardMap = Some "h cbbbbbbc bsossbsb bbsbbsob bsbbbbsb bsbbbbsb bosbbsbb bsbssosb cbbbbbbc"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.510162353516 -0.044793737793 0.21223449707"
                collisionVolumeScales = Some "52.280090332 25.2522125244 52.9224243164"
                collisionVolumeType = Some "Box"
                damage = Some 102.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 33.0
                object_ = Some "Units/armmex_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 51.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 13.0
                object_ = Some "Units/arm3X3B.s3o"
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
              cant = []
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = []
              select = ["mexselect"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecaltype", "decals/armmex_aoplane.dds"
              "cvbuildable", "true"
              "metal_extractor", "1.0"
              "model_author", "Cremuss"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/LandEconomy"
              "unitgroup", "metal"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
              "energyupkeep", "3.0"
              "onoffable", "true"
              "selfdestructcountdown", "1.0"
          ] }

    let armmexToFlat (def: UnitDef) : Armmex =
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
          metalStorage = def.economy.Value.metalStorage.Value
          extractsMetal = def.economy.Value.extractsMetal.Value
          yardMap = def.building.Value.yardMap.Value
          activateWhenBuilt = def.building.Value.activateWhenBuilt.Value
          canRepeat = def.building.Value.canRepeat.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armmexToUnitDef (flat: Armmex) : UnitDef =
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
          economy = Some {
              energyMake = None
              metalMake = None
              energyStorage = None
              metalStorage = Some flat.metalStorage
              extractsMetal = Some flat.extractsMetal
            }
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = Some flat.activateWhenBuilt
              canRepeat = Some flat.canRepeat
            }
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armmmkr =
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

    let armmmkr : Armmmkr =
        { name = "armmmkr"
          subfolder = "ArmBuildings/LandEconomy"
          metalCost = ValueOrExpr.Concrete 380.0
          energyCost = ValueOrExpr.Concrete 21000.0
          buildTime = ValueOrExpr.Concrete 35000.0
          health = ValueOrExpr.Concrete 445.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMMMKR.s3o"
          buildPic = Some "ARMMMKR.DDS"
          script = Some "Units/ARMMMKR.cob"
          corpse = Some "DEAD"
          explodeAs = Some "advmetalmaker"
          selfDestructAs = Some "advmetalmakerSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          yardMap = "oooooooooooooooo"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-0.574371337891 -11.1292811768 1.24842834473"
                  collisionVolumeScales = Some "60.6127624512 52.6148376465 60.6127624512"
                  collisionVolumeType = Some "Box"
                  damage = Some 240.0
                  featureDead = Some "HEAP"
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 20.0
                  metal = Some 233.0
                  object_ = Some "Units/armmmkr_dead.s3o"
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
            ]
          sounds =
              { build = None
                repair = None
                working = Some "arm-bld-metalmaker"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["metlon1"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "6.0"
                "buildinggrounddecalsizey", "6.0"
                "buildinggrounddecaltype", "decals/armmmkr_aoplane.dds"
                "energyconv_capacity", "600.0"
                "energyconv_efficiency", "0.01724"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandEconomy"
                "techlevel", "2.0"
                "unitgroup", "metal"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "8192.0"
            ] }

    let armmmkrDef : UnitDef =
        { name = "armmmkr"
          subfolder = "ArmBuildings/LandEconomy"
          metalCost = ValueOrExpr.Concrete 380.0
          energyCost = ValueOrExpr.Concrete 21000.0
          buildTime = ValueOrExpr.Concrete 35000.0
          health = ValueOrExpr.Concrete 445.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMMMKR.s3o"
          buildPic = Some "ARMMMKR.DDS"
          script = Some "Units/ARMMMKR.cob"
          corpse = Some "DEAD"
          explodeAs = Some "advmetalmaker"
          selfDestructAs = Some "advmetalmakerSelfd"
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
            { yardMap = Some "oooooooooooooooo"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "-0.574371337891 -11.1292811768 1.24842834473"
                collisionVolumeScales = Some "60.6127624512 52.6148376465 60.6127624512"
                collisionVolumeType = Some "Box"
                damage = Some 240.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 233.0
                object_ = Some "Units/armmmkr_dead.s3o"
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
              "buildinggrounddecalsizex", "6.0"
              "buildinggrounddecalsizey", "6.0"
              "buildinggrounddecaltype", "decals/armmmkr_aoplane.dds"
              "energyconv_capacity", "600.0"
              "energyconv_efficiency", "0.01724"
              "model_author", "Cremuss"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/LandEconomy"
              "techlevel", "2.0"
              "unitgroup", "metal"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
          ] }

    let armmmkrToFlat (def: UnitDef) : Armmmkr =
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

    let armmmkrToUnitDef (flat: Armmmkr) : UnitDef =
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

    type Armmoho =
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
          metalStorage: float
          extractsMetal: float
          yardMap: string
          activateWhenBuilt: bool
          canRepeat: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armmoho : Armmoho =
        { name = "armmoho"
          subfolder = "ArmBuildings/LandEconomy"
          metalCost = ValueOrExpr.Concrete 620.0
          energyCost = ValueOrExpr.Concrete 7700.0
          buildTime = ValueOrExpr.Concrete 14900.0
          health = ValueOrExpr.Concrete 2800.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMMOHO.s3o"
          buildPic = Some "ARMMOHO.DDS"
          script = Some "Units/ARMMOHO.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "70 70 70"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          metalStorage = 600.0
          extractsMetal = 0.004
          yardMap = "h cbbbbbbc bssssssb bsssossb bsobbssb bssbbosb bssosssb bssssssb cbbbbbbc"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "70 70 70"
                  collisionVolumeType = Some "cylY"
                  damage = Some 1500.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 40.0
                  metal = Some 378.0
                  object_ = Some "Units/armmoho_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 750.0
                  featureDead = None
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 4.0
                  metal = Some 151.0
                  object_ = Some "Units/arm5X5A.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = Some "mohorun1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["twractv2"]
                select = ["mohoon1"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "7.4"
                "buildinggrounddecalsizey", "7.4"
                "buildinggrounddecaltype", "decals/armmoho_aoplane.dds"
                "cvbuildable", "true"
                "metal_extractor", "4.0"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandEconomy"
                "techlevel", "2.0"
                "unitgroup", "metal"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "2048.0"
                "energyupkeep", "20.0"
                "onoffable", "true"
            ] }

    let armmohoDef : UnitDef =
        { name = "armmoho"
          subfolder = "ArmBuildings/LandEconomy"
          metalCost = ValueOrExpr.Concrete 620.0
          energyCost = ValueOrExpr.Concrete 7700.0
          buildTime = ValueOrExpr.Concrete 14900.0
          health = ValueOrExpr.Concrete 2800.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMMOHO.s3o"
          buildPic = Some "ARMMOHO.DDS"
          script = Some "Units/ARMMOHO.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "70 70 70"
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
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "70 70 70"
                collisionVolumeType = Some "cylY"
                damage = Some 1500.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 40.0
                metal = Some 378.0
                object_ = Some "Units/armmoho_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 750.0
                featureDead = None
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 4.0
                metal = Some 151.0
                object_ = Some "Units/arm5X5A.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = None
              repair = None
              working = Some "mohorun1"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = []
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["twractv2"]
              select = ["mohoon1"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "7.4"
              "buildinggrounddecalsizey", "7.4"
              "buildinggrounddecaltype", "decals/armmoho_aoplane.dds"
              "cvbuildable", "true"
              "metal_extractor", "4.0"
              "model_author", "Cremuss"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/LandEconomy"
              "techlevel", "2.0"
              "unitgroup", "metal"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "2048.0"
              "energyupkeep", "20.0"
              "onoffable", "true"
          ] }

    let armmohoToFlat (def: UnitDef) : Armmoho =
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
          metalStorage = def.economy.Value.metalStorage.Value
          extractsMetal = def.economy.Value.extractsMetal.Value
          yardMap = def.building.Value.yardMap.Value
          activateWhenBuilt = def.building.Value.activateWhenBuilt.Value
          canRepeat = def.building.Value.canRepeat.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armmohoToUnitDef (flat: Armmoho) : UnitDef =
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
          economy = Some {
              energyMake = None
              metalMake = None
              energyStorage = None
              metalStorage = Some flat.metalStorage
              extractsMetal = Some flat.extractsMetal
            }
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = Some flat.activateWhenBuilt
              canRepeat = Some flat.canRepeat
            }
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armmstor =
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
          metalStorage: float
          yardMap: string
          activateWhenBuilt: bool
          canRepeat: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armmstor : Armmstor =
        { name = "armmstor"
          subfolder = "ArmBuildings/LandEconomy"
          metalCost = ValueOrExpr.Concrete 330.0
          energyCost = ValueOrExpr.Concrete 570.0
          buildTime = ValueOrExpr.Concrete 2920.0
          health = ValueOrExpr.Concrete 2100.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMMSTOR.s3o"
          buildPic = Some "ARMMSTOR.DDS"
          script = Some "Units/ARMMSTOR.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingExplosionGeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "56 61 56"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          metalStorage = 3000.0
          yardMap = "oooooooooooooooo"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.224998474121 -2.43896484378e-05 0.229019165039"
                  collisionVolumeScales = Some "55.897567749 35.6887512207 72.7919311523"
                  collisionVolumeType = Some "Box"
                  damage = Some 1595.0
                  featureDead = Some "HEAP"
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 40.0
                  metal = Some 198.0
                  object_ = Some "Units/armmstor_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 798.0
                  featureDead = None
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 4.0
                  metal = Some 79.0
                  object_ = Some "Units/arm4X4E.s3o"
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
                select = ["stormtl1"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "6.0"
                "buildinggrounddecalsizey", "6.0"
                "buildinggrounddecaltype", "decals/armmstor_aoplane.dds"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandEconomy"
                "unitgroup", "metal"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "4096.0"
            ] }

    let armmstorDef : UnitDef =
        { name = "armmstor"
          subfolder = "ArmBuildings/LandEconomy"
          metalCost = ValueOrExpr.Concrete 330.0
          energyCost = ValueOrExpr.Concrete 570.0
          buildTime = ValueOrExpr.Concrete 2920.0
          health = ValueOrExpr.Concrete 2100.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMMSTOR.s3o"
          buildPic = Some "ARMMSTOR.DDS"
          script = Some "Units/ARMMSTOR.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingExplosionGeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "56 61 56"
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
              metalStorage = Some 3000.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooooooooooooooo"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.224998474121 -2.43896484378e-05 0.229019165039"
                collisionVolumeScales = Some "55.897567749 35.6887512207 72.7919311523"
                collisionVolumeType = Some "Box"
                damage = Some 1595.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 40.0
                metal = Some 198.0
                object_ = Some "Units/armmstor_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 798.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 4.0
                metal = Some 79.0
                object_ = Some "Units/arm4X4E.s3o"
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
              select = ["stormtl1"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "6.0"
              "buildinggrounddecalsizey", "6.0"
              "buildinggrounddecaltype", "decals/armmstor_aoplane.dds"
              "model_author", "Cremuss"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/LandEconomy"
              "unitgroup", "metal"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "4096.0"
          ] }

    let armmstorToFlat (def: UnitDef) : Armmstor =
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
          metalStorage = def.economy.Value.metalStorage.Value
          yardMap = def.building.Value.yardMap.Value
          activateWhenBuilt = def.building.Value.activateWhenBuilt.Value
          canRepeat = def.building.Value.canRepeat.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armmstorToUnitDef (flat: Armmstor) : UnitDef =
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
          economy = Some {
              energyMake = None
              metalMake = None
              energyStorage = None
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = Some flat.activateWhenBuilt
              canRepeat = Some flat.canRepeat
            }
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armsolar =
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
          energyStorage: float
          yardMap: string
          activateWhenBuilt: bool
          canRepeat: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armsolar : Armsolar =
        { name = "armsolar"
          subfolder = "ArmBuildings/LandEconomy"
          metalCost = ValueOrExpr.Concrete 155.0
          energyCost = ValueOrExpr.Concrete 0.0
          buildTime = ValueOrExpr.Concrete 2600.0
          health = ValueOrExpr.Concrete 340.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/ARMSOLAR.s3o"
          buildPic = Some "ARMSOLAR.DDS"
          script = Some "Units/ARMSOLAR.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallBuildingexplosiongeneric"
          selfDestructAs = Some "smallBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0.0 -18.0 1.0"
          collisionVolumeScales = Some "50.0 76.0 50.0"
          collisionVolumeType = Some "Ell"
          seismicSignature = Some 0.0
          category = None
          energyStorage = 50.0
          yardMap = "yyoyy yoooy ooooo yoooy yyoyy"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -18 1"
                  collisionVolumeScales = Some "50 76 50"
                  collisionVolumeType = Some "Ell"
                  damage = Some 184.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 20.0
                  metal = Some 75.0
                  object_ = Some "Units/armsolar_dead.s3o"
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
                select = ["solar1"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "8.0"
                "buildinggrounddecalsizey", "8.0"
                "buildinggrounddecaltype", "decals/armsolar_aoplane.dds"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "solar", "true"
                "subfolder", "ArmBuildings/LandEconomy"
                "unitgroup", "energy"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "4000.0"
                "damagemodifier", "0.5"
                "energyupkeep", "-20.0"
                "onoffable", "true"
            ] }

    let armsolarDef : UnitDef =
        { name = "armsolar"
          subfolder = "ArmBuildings/LandEconomy"
          metalCost = ValueOrExpr.Concrete 155.0
          energyCost = ValueOrExpr.Concrete 0.0
          buildTime = ValueOrExpr.Concrete 2600.0
          health = ValueOrExpr.Concrete 340.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/ARMSOLAR.s3o"
          buildPic = Some "ARMSOLAR.DDS"
          script = Some "Units/ARMSOLAR.cob"
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
            { yardMap = Some "yyoyy yoooy ooooo yoooy yyoyy"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -18 1"
                collisionVolumeScales = Some "50 76 50"
                collisionVolumeType = Some "Ell"
                damage = Some 184.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 20.0
                metal = Some 75.0
                object_ = Some "Units/armsolar_dead.s3o"
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
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "8.0"
              "buildinggrounddecalsizey", "8.0"
              "buildinggrounddecaltype", "decals/armsolar_aoplane.dds"
              "model_author", "Cremuss"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "solar", "true"
              "subfolder", "ArmBuildings/LandEconomy"
              "unitgroup", "energy"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "4000.0"
              "damagemodifier", "0.5"
              "energyupkeep", "-20.0"
              "onoffable", "true"
          ] }

    let armsolarToFlat (def: UnitDef) : Armsolar =
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
          energyStorage = def.economy.Value.energyStorage.Value
          yardMap = def.building.Value.yardMap.Value
          activateWhenBuilt = def.building.Value.activateWhenBuilt.Value
          canRepeat = def.building.Value.canRepeat.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armsolarToUnitDef (flat: Armsolar) : UnitDef =
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
          economy = Some {
              energyMake = None
              metalMake = None
              energyStorage = Some flat.energyStorage
              metalStorage = None
              extractsMetal = None
            }
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = Some flat.activateWhenBuilt
              canRepeat = Some flat.canRepeat
            }
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armwin =
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
          energyStorage: float
          yardMap: string
          activateWhenBuilt: bool
          canRepeat: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armwin : Armwin =
        { name = "armwin"
          subfolder = "ArmBuildings/LandEconomy"
          metalCost = ValueOrExpr.Concrete 40.0
          energyCost = ValueOrExpr.Concrete 175.0
          buildTime = ValueOrExpr.Concrete 1600.0
          health = ValueOrExpr.Concrete 196.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMWIN.s3o"
          buildPic = Some "ARMWIN.DDS"
          script = Some "Units/ARMWIN.cob"
          corpse = Some "DEAD"
          explodeAs = Some "windboom"
          selfDestructAs = Some "windboom"
          collisionVolumeOffsets = Some "0 1 0"
          collisionVolumeScales = Some "34 87 34"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          energyStorage = 0.5
          yardMap = "ooo ooo ooo"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.407234191895 -7.26560776367 -4.28938293457"
                  collisionVolumeScales = Some "41.3442230225 45.3115844727 37.0443725586"
                  collisionVolumeType = Some "Box"
                  damage = Some 106.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 40.0
                  metal = Some 23.0
                  object_ = Some "Units/armwin_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 53.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 9.0
                  object_ = Some "Units/arm4X4A.s3o"
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
                select = ["windgen"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "5.0"
                "buildinggrounddecalsizey", "5.0"
                "buildinggrounddecaltype", "decals/armwin_aoplane.dds"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandEconomy"
                "unitgroup", "energy"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "windgenerator", "25.0"
            ] }

    let armwinDef : UnitDef =
        { name = "armwin"
          subfolder = "ArmBuildings/LandEconomy"
          metalCost = ValueOrExpr.Concrete 40.0
          energyCost = ValueOrExpr.Concrete 175.0
          buildTime = ValueOrExpr.Concrete 1600.0
          health = ValueOrExpr.Concrete 196.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMWIN.s3o"
          buildPic = Some "ARMWIN.DDS"
          script = Some "Units/ARMWIN.cob"
          corpse = Some "DEAD"
          explodeAs = Some "windboom"
          selfDestructAs = Some "windboom"
          collisionVolumeOffsets = Some "0 1 0"
          collisionVolumeScales = Some "34 87 34"
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
                collisionVolumeOffsets = Some "0.407234191895 -7.26560776367 -4.28938293457"
                collisionVolumeScales = Some "41.3442230225 45.3115844727 37.0443725586"
                collisionVolumeType = Some "Box"
                damage = Some 106.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 40.0
                metal = Some 23.0
                object_ = Some "Units/armwin_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 53.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 9.0
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
              select = ["windgen"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecaltype", "decals/armwin_aoplane.dds"
              "model_author", "Cremuss"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/LandEconomy"
              "unitgroup", "energy"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "windgenerator", "25.0"
          ] }

    let armwinToFlat (def: UnitDef) : Armwin =
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
          energyStorage = def.economy.Value.energyStorage.Value
          yardMap = def.building.Value.yardMap.Value
          activateWhenBuilt = def.building.Value.activateWhenBuilt.Value
          canRepeat = def.building.Value.canRepeat.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armwinToUnitDef (flat: Armwin) : UnitDef =
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
          economy = Some {
              energyMake = None
              metalMake = None
              energyStorage = Some flat.energyStorage
              metalStorage = None
              extractsMetal = None
            }
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = Some flat.activateWhenBuilt
              canRepeat = Some flat.canRepeat
            }
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

