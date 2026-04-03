// Auto-generated BAR unit data: Scavengers/Buildings/Utility (unified)
namespace BarData.Units

open BarData

module Scavengers_Buildings_Utility =

    type Armgatet3 =
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
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armgatet3 : Armgatet3 =
        { name = "armgatet3"
          subfolder = "Scavengers/Buildings/Utility"
          metalCost = ValueOrExpr.Concrete 12000.0
          energyCost = ValueOrExpr.Concrete 216000.0
          buildTime = ValueOrExpr.Concrete 220000.0
          health = ValueOrExpr.Concrete 10250.0
          sightDistance = ValueOrExpr.Concrete 350.0
          footprintX = 5.0
          footprintZ = 6.0
          objectName = Some "Units/ARMGATET3.s3o"
          buildPic = Some "ARMGATET3.DDS"
          script = Some "Units/ARMGATET3.cob"
          corpse = Some "DEAD"
          explodeAs = Some "fusionExplosion"
          selfDestructAs = Some "fusionExplosionSelfd"
          collisionVolumeOffsets = Some "0 0 3"
          collisionVolumeScales = Some "91 85 91"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = Some "NOWEAPON"
          energyStorage = 4000.0
          weapons = [
                { name = "repulsor"
                  displayName = "PlasmaRepulsor"
                  weaponType = Some "Shield"
                  damage = Map.ofList [
                      "default", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 710.0)
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
                  collisionVolumeOffsets = Some "0 0 3"
                  collisionVolumeScales = Some "91 67 91"
                  collisionVolumeType = Some "CylY"
                  damage = Some 7500.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 6.0
                  height = Some 20.0
                  metal = Some 7500.0
                  object_ = Some "Units/armgatet3_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 3750.0
                  featureDead = None
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 4.0
                  metal = Some 3200.0
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
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["drone1"]
                select = ["drone1"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "9.0"
                "buildinggrounddecalsizey", "9.0"
                "buildinggrounddecaltype", "decals/armgate_aoplane.dds"
                "model_author", "Beherith/Protar"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "shield_color_mult", "25.0"
                "shield_power", "24700.0"
                "shield_radius", "710.0"
                "subfolder", "ArmBuildings/LandUtil"
                "techlevel", "3.0"
                "unitgroup", "util"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "2048.0"
                "onoffable", "true"
                "canattack", "false"
                "exemptcategory", "WEAPON"
                "noautofire", "true"
            ] }

    let armgatet3Def : UnitDef =
        { name = "armgatet3"
          subfolder = "Scavengers/Buildings/Utility"
          metalCost = ValueOrExpr.Concrete 12000.0
          energyCost = ValueOrExpr.Concrete 216000.0
          buildTime = ValueOrExpr.Concrete 220000.0
          health = ValueOrExpr.Concrete 10250.0
          sightDistance = ValueOrExpr.Concrete 350.0
          footprintX = 5.0
          footprintZ = 6.0
          objectName = Some "Units/ARMGATET3.s3o"
          buildPic = Some "ARMGATET3.DDS"
          script = Some "Units/ARMGATET3.cob"
          corpse = Some "DEAD"
          explodeAs = Some "fusionExplosion"
          selfDestructAs = Some "fusionExplosionSelfd"
          collisionVolumeOffsets = Some "0 0 3"
          collisionVolumeScales = Some "91 85 91"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = Some "NOWEAPON"
          movement = None
          builder = None
          weapons = Some [
              { name = "repulsor"
                displayName = "PlasmaRepulsor"
                weaponType = Some "Shield"
                damage = Map.ofList [
                    "default", 100.0
                ]
                range = Some (ValueOrExpr.Concrete 710.0)
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
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 4000.0
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 3"
                collisionVolumeScales = Some "91 67 91"
                collisionVolumeType = Some "CylY"
                damage = Some 7500.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 6.0
                height = Some 20.0
                metal = Some 7500.0
                object_ = Some "Units/armgatet3_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 3750.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 4.0
                metal = Some 3200.0
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
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["drone1"]
              select = ["drone1"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "9.0"
              "buildinggrounddecalsizey", "9.0"
              "buildinggrounddecaltype", "decals/armgate_aoplane.dds"
              "model_author", "Beherith/Protar"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "shield_color_mult", "25.0"
              "shield_power", "24700.0"
              "shield_radius", "710.0"
              "subfolder", "ArmBuildings/LandUtil"
              "techlevel", "3.0"
              "unitgroup", "util"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "2048.0"
              "onoffable", "true"
              "canattack", "false"
              "exemptcategory", "WEAPON"
              "noautofire", "true"
          ] }

    let armgatet3ToFlat (def: UnitDef) : Armgatet3 =
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
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armgatet3ToUnitDef (flat: Armgatet3) : UnitDef =
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
          economy = Some {
              energyMake = None
              metalMake = None
              energyStorage = Some flat.energyStorage
              metalStorage = None
              extractsMetal = None
            }
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corgatet3 =
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
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corgatet3 : Corgatet3 =
        { name = "corgatet3"
          subfolder = "Scavengers/Buildings/Utility"
          metalCost = ValueOrExpr.Concrete 16000.0
          energyCost = ValueOrExpr.Concrete 275000.0
          buildTime = ValueOrExpr.Concrete 275000.0
          health = ValueOrExpr.Concrete 12500.0
          sightDistance = ValueOrExpr.Concrete 350.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/CORGATET3.s3o"
          buildPic = Some "CORGATET3.DDS"
          script = Some "Units/CORGATET3.cob"
          corpse = Some "DEAD"
          explodeAs = Some "customfusionexplo"
          selfDestructAs = Some "advancedFusionExplosionSelfd"
          collisionVolumeOffsets = Some "0 -4 0"
          collisionVolumeScales = Some "96 143 96"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = Some "NOWEAPON"
          energyStorage = 5000.0
          weapons = [
                { name = "repulsor"
                  displayName = "PlasmaRepulsor"
                  weaponType = Some "Shield"
                  damage = Map.ofList [
                      "default", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 825.0)
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
                  collisionVolumeOffsets = Some "0 -4 0"
                  collisionVolumeScales = Some "96 115 96"
                  collisionVolumeType = Some "CylY"
                  damage = Some 8500.0
                  featureDead = Some "HEAP"
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 20.0
                  metal = Some 10000.0
                  object_ = Some "Units/corgatet3_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 4250.0
                  featureDead = None
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 4.0
                  metal = Some 4000.0
                  object_ = Some "Units/cor5X5D.s3o"
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
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "9.0"
                "buildinggrounddecalsizey", "9.0"
                "buildinggrounddecaltype", "decals/corgate_aoplane.dds"
                "model_author", "Mr Bob/Protar"
                "normaltex", "unittextures/cor_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "shield_color_mult", "25.0"
                "shield_power", "66500.0"
                "shield_radius", "825.0"
                "subfolder", "CorBuildings/LandUtil"
                "techlevel", "3.0"
                "unitgroup", "util"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "4096.0"
                "onoffable", "true"
                "canattack", "false"
                "exemptcategory", "WEAPON"
                "noautofire", "true"
            ] }

    let corgatet3Def : UnitDef =
        { name = "corgatet3"
          subfolder = "Scavengers/Buildings/Utility"
          metalCost = ValueOrExpr.Concrete 16000.0
          energyCost = ValueOrExpr.Concrete 275000.0
          buildTime = ValueOrExpr.Concrete 275000.0
          health = ValueOrExpr.Concrete 12500.0
          sightDistance = ValueOrExpr.Concrete 350.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/CORGATET3.s3o"
          buildPic = Some "CORGATET3.DDS"
          script = Some "Units/CORGATET3.cob"
          corpse = Some "DEAD"
          explodeAs = Some "customfusionexplo"
          selfDestructAs = Some "advancedFusionExplosionSelfd"
          collisionVolumeOffsets = Some "0 -4 0"
          collisionVolumeScales = Some "96 143 96"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = Some "NOWEAPON"
          movement = None
          builder = None
          weapons = Some [
              { name = "repulsor"
                displayName = "PlasmaRepulsor"
                weaponType = Some "Shield"
                damage = Map.ofList [
                    "default", 100.0
                ]
                range = Some (ValueOrExpr.Concrete 825.0)
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
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 5000.0
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -4 0"
                collisionVolumeScales = Some "96 115 96"
                collisionVolumeType = Some "CylY"
                damage = Some 8500.0
                featureDead = Some "HEAP"
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 20.0
                metal = Some 10000.0
                object_ = Some "Units/corgatet3_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 4250.0
                featureDead = None
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 4.0
                metal = Some 4000.0
                object_ = Some "Units/cor5X5D.s3o"
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
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "9.0"
              "buildinggrounddecalsizey", "9.0"
              "buildinggrounddecaltype", "decals/corgate_aoplane.dds"
              "model_author", "Mr Bob/Protar"
              "normaltex", "unittextures/cor_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "shield_color_mult", "25.0"
              "shield_power", "66500.0"
              "shield_radius", "825.0"
              "subfolder", "CorBuildings/LandUtil"
              "techlevel", "3.0"
              "unitgroup", "util"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "4096.0"
              "onoffable", "true"
              "canattack", "false"
              "exemptcategory", "WEAPON"
              "noautofire", "true"
          ] }

    let corgatet3ToFlat (def: UnitDef) : Corgatet3 =
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
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corgatet3ToUnitDef (flat: Corgatet3) : UnitDef =
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
          economy = Some {
              energyMake = None
              metalMake = None
              energyStorage = Some flat.energyStorage
              metalStorage = None
              extractsMetal = None
            }
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Scavbeacon_t1 =
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
          metalMake: ValueOrExpr<float>
          energyStorage: float
          metalStorage: float
          yardMap: string
          activateWhenBuilt: bool
          weapons: WeaponDef list
          customParams: Map<string, string>
          extras: Map<string, string> }

    let scavbeacon_t1 : Scavbeacon_t1 =
        { name = "scavbeacon_t1"
          subfolder = "Scavengers/Buildings/Utility"
          metalCost = ValueOrExpr.Concrete 500.0
          energyCost = ValueOrExpr.Concrete 5000.0
          buildTime = ValueOrExpr.Concrete 5000.0
          health = ValueOrExpr.Concrete 5000.0
          sightDistance = ValueOrExpr.Concrete 750.0
          footprintX = 0.0
          footprintZ = 0.0
          objectName = Some "scavs/scavbeacon_t1.s3o"
          buildPic = Some "scavengers/SCAVBEACON.DDS"
          script = Some "scavs/scavbeacon.cob"
          corpse = None
          explodeAs = Some "advmetalmaker"
          selfDestructAs = None
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "32 32 32"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 4.0
          category = Some "CANBEUW"
          energyMake = ValueOrExpr.Concrete 200.0
          metalMake = ValueOrExpr.Concrete 2.0
          energyStorage = 20000.0
          metalStorage = 2000.0
          yardMap = ""
          activateWhenBuilt = true
          weapons = [
                { name = "weapon"
                  displayName = "Armageddon Heat Ray"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "commanders", 83.25
                      "default", 250.0
                      "vtol", 250.0
                  ]
                  range = Some (ValueOrExpr.Concrete 450.0)
                  reloadTime = Some (ValueOrExpr.Concrete 3.75)
                  weaponVelocity = Some 1800.0
                  areaOfEffect = Some 72.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "Lasrmas2"
                  soundHit = None
                  explosiongenerator = Some "custom:genericshellexplosion-medium-beam"
                  rgbColor = Some "1 0.8 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "avoidfeature", "false"
                      "beamtime", "1.0"
                      "cameraShake", "350.0"
                      "corethickness", "0.4"
                      "craterareaofeffect", "72.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "1200.0"
                      "largebeamlaser", "true"
                      "laserflaresize", "8.8"
                      "rgbcolor2", "0.8 0 0"
                      "scrollspeed", "5.0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "2.0"
                  ] }
            ]
          customParams = Map.ofList [
                "subfolder", "Scavengers"
                "normaltex", "unittextures/cor_normal.dds"
                "paratrooper", "true"
            ]
          extras = Map.ofList [
                "autoheal", "10.0"
                "blocking", "false"
                "canSelfDestruct", "false"
                "capturable", "true"
                "cantbetransported", "true"
                "hidedamage", "true"
                "levelground", "false"
                "mass", "10000.0"
                "noautofire", "false"
                "selfdestructcountdown", "1.0"
                "smoothanim", "true"
                "transportByEnemy", "true"
                "unitname", "scavengerbeacon"
                "upright", "false"
                "reclaimable", "true"
            ] }

    let scavbeacon_t1Def : UnitDef =
        { name = "scavbeacon_t1"
          subfolder = "Scavengers/Buildings/Utility"
          metalCost = ValueOrExpr.Concrete 500.0
          energyCost = ValueOrExpr.Concrete 5000.0
          buildTime = ValueOrExpr.Concrete 5000.0
          health = ValueOrExpr.Concrete 5000.0
          sightDistance = ValueOrExpr.Concrete 750.0
          footprintX = 0.0
          footprintZ = 0.0
          objectName = Some "scavs/scavbeacon_t1.s3o"
          buildPic = Some "scavengers/SCAVBEACON.DDS"
          script = Some "scavs/scavbeacon.cob"
          corpse = None
          explodeAs = Some "advmetalmaker"
          selfDestructAs = None
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "32 32 32"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 4.0
          category = Some "CANBEUW"
          movement = None
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = "Armageddon Heat Ray"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 83.25
                    "default", 250.0
                    "vtol", 250.0
                ]
                range = Some (ValueOrExpr.Concrete 450.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.75)
                weaponVelocity = Some 1800.0
                areaOfEffect = Some 72.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "Lasrmas2"
                soundHit = None
                explosiongenerator = Some "custom:genericshellexplosion-medium-beam"
                rgbColor = Some "1 0.8 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "avoidfeature", "false"
                    "beamtime", "1.0"
                    "cameraShake", "350.0"
                    "corethickness", "0.4"
                    "craterareaofeffect", "72.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "1200.0"
                    "largebeamlaser", "true"
                    "laserflaresize", "8.8"
                    "rgbcolor2", "0.8 0 0"
                    "scrollspeed", "5.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.0"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 200.0)
              metalMake = Some (ValueOrExpr.Concrete 2.0)
              energyStorage = Some 20000.0
              metalStorage = Some 2000.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some ""
              activateWhenBuilt = Some true
              canRepeat = None })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "Scavengers"
              "normaltex", "unittextures/cor_normal.dds"
              "paratrooper", "true"
          ]
          extras = Map.ofList [
              "autoheal", "10.0"
              "blocking", "false"
              "canSelfDestruct", "false"
              "capturable", "true"
              "cantbetransported", "true"
              "hidedamage", "true"
              "levelground", "false"
              "mass", "10000.0"
              "noautofire", "false"
              "selfdestructcountdown", "1.0"
              "smoothanim", "true"
              "transportByEnemy", "true"
              "unitname", "scavengerbeacon"
              "upright", "false"
              "reclaimable", "true"
          ] }

    let scavbeacon_t1ToFlat (def: UnitDef) : Scavbeacon_t1 =
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
          metalMake = def.economy.Value.metalMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          yardMap = def.building.Value.yardMap.Value
          activateWhenBuilt = def.building.Value.activateWhenBuilt.Value
          weapons = def.weapons.Value
          customParams = def.customParams
          extras = def.extras }

    let scavbeacon_t1ToUnitDef (flat: Scavbeacon_t1) : UnitDef =
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
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = Some flat.metalMake
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = Some flat.activateWhenBuilt
              canRepeat = None
            }
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Scavbeacon_t2 =
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
          metalMake: ValueOrExpr<float>
          energyStorage: float
          metalStorage: float
          yardMap: string
          activateWhenBuilt: bool
          weapons: WeaponDef list
          customParams: Map<string, string>
          extras: Map<string, string> }

    let scavbeacon_t2 : Scavbeacon_t2 =
        { name = "scavbeacon_t2"
          subfolder = "Scavengers/Buildings/Utility"
          metalCost = ValueOrExpr.Concrete 2500.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 25000.0
          health = ValueOrExpr.Concrete 25000.0
          sightDistance = ValueOrExpr.Concrete 750.0
          footprintX = 0.0
          footprintZ = 0.0
          objectName = Some "scavs/scavbeacon_t2.s3o"
          buildPic = Some "scavengers/SCAVBEACON.DDS"
          script = Some "scavs/scavbeacon.cob"
          corpse = None
          explodeAs = Some "advmetalmaker"
          selfDestructAs = None
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "48 48 48"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 4.0
          category = Some "CANBEUW"
          energyMake = ValueOrExpr.Concrete 400.0
          metalMake = ValueOrExpr.Concrete 4.0
          energyStorage = 60000.0
          metalStorage = 6000.0
          yardMap = ""
          activateWhenBuilt = true
          weapons = [
                { name = "weapon"
                  displayName = "Armageddon Heat Ray"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "commanders", 250.0
                      "default", 750.0
                  ]
                  range = Some (ValueOrExpr.Concrete 600.0)
                  reloadTime = Some (ValueOrExpr.Concrete 3.75)
                  weaponVelocity = Some 1800.0
                  areaOfEffect = Some 72.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrhvy3"
                  soundHit = None
                  explosiongenerator = Some "custom:genericshellexplosion-medium-beam"
                  rgbColor = Some "1 0.8 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "avoidfeature", "false"
                      "beamtime", "1.0"
                      "cameraShake", "350.0"
                      "corethickness", "0.4"
                      "craterareaofeffect", "72.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "1200.0"
                      "largebeamlaser", "true"
                      "laserflaresize", "8.8"
                      "rgbcolor2", "0.8 0 0"
                      "scrollspeed", "5.0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "4.0"
                  ] }
            ]
          customParams = Map.ofList [
                "subfolder", "Scavengers"
                "normaltex", "unittextures/cor_normal.dds"
                "paratrooper", "true"
            ]
          extras = Map.ofList [
                "autoheal", "10.0"
                "blocking", "false"
                "canSelfDestruct", "false"
                "capturable", "true"
                "cantbetransported", "true"
                "hidedamage", "true"
                "levelground", "false"
                "mass", "10000.0"
                "noautofire", "false"
                "selfdestructcountdown", "1.0"
                "smoothanim", "true"
                "transportByEnemy", "true"
                "unitname", "scavengerbeacon"
                "upright", "false"
                "reclaimable", "true"
            ] }

    let scavbeacon_t2Def : UnitDef =
        { name = "scavbeacon_t2"
          subfolder = "Scavengers/Buildings/Utility"
          metalCost = ValueOrExpr.Concrete 2500.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 25000.0
          health = ValueOrExpr.Concrete 25000.0
          sightDistance = ValueOrExpr.Concrete 750.0
          footprintX = 0.0
          footprintZ = 0.0
          objectName = Some "scavs/scavbeacon_t2.s3o"
          buildPic = Some "scavengers/SCAVBEACON.DDS"
          script = Some "scavs/scavbeacon.cob"
          corpse = None
          explodeAs = Some "advmetalmaker"
          selfDestructAs = None
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "48 48 48"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 4.0
          category = Some "CANBEUW"
          movement = None
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = "Armageddon Heat Ray"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 250.0
                    "default", 750.0
                ]
                range = Some (ValueOrExpr.Concrete 600.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.75)
                weaponVelocity = Some 1800.0
                areaOfEffect = Some 72.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrhvy3"
                soundHit = None
                explosiongenerator = Some "custom:genericshellexplosion-medium-beam"
                rgbColor = Some "1 0.8 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "avoidfeature", "false"
                    "beamtime", "1.0"
                    "cameraShake", "350.0"
                    "corethickness", "0.4"
                    "craterareaofeffect", "72.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "1200.0"
                    "largebeamlaser", "true"
                    "laserflaresize", "8.8"
                    "rgbcolor2", "0.8 0 0"
                    "scrollspeed", "5.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "4.0"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 400.0)
              metalMake = Some (ValueOrExpr.Concrete 4.0)
              energyStorage = Some 60000.0
              metalStorage = Some 6000.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some ""
              activateWhenBuilt = Some true
              canRepeat = None })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "Scavengers"
              "normaltex", "unittextures/cor_normal.dds"
              "paratrooper", "true"
          ]
          extras = Map.ofList [
              "autoheal", "10.0"
              "blocking", "false"
              "canSelfDestruct", "false"
              "capturable", "true"
              "cantbetransported", "true"
              "hidedamage", "true"
              "levelground", "false"
              "mass", "10000.0"
              "noautofire", "false"
              "selfdestructcountdown", "1.0"
              "smoothanim", "true"
              "transportByEnemy", "true"
              "unitname", "scavengerbeacon"
              "upright", "false"
              "reclaimable", "true"
          ] }

    let scavbeacon_t2ToFlat (def: UnitDef) : Scavbeacon_t2 =
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
          metalMake = def.economy.Value.metalMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          yardMap = def.building.Value.yardMap.Value
          activateWhenBuilt = def.building.Value.activateWhenBuilt.Value
          weapons = def.weapons.Value
          customParams = def.customParams
          extras = def.extras }

    let scavbeacon_t2ToUnitDef (flat: Scavbeacon_t2) : UnitDef =
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
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = Some flat.metalMake
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = Some flat.activateWhenBuilt
              canRepeat = None
            }
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Scavbeacon_t3 =
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
          metalMake: ValueOrExpr<float>
          energyStorage: float
          metalStorage: float
          yardMap: string
          activateWhenBuilt: bool
          weapons: WeaponDef list
          customParams: Map<string, string>
          extras: Map<string, string> }

    let scavbeacon_t3 : Scavbeacon_t3 =
        { name = "scavbeacon_t3"
          subfolder = "Scavengers/Buildings/Utility"
          metalCost = ValueOrExpr.Concrete 5000.0
          energyCost = ValueOrExpr.Concrete 50000.0
          buildTime = ValueOrExpr.Concrete 50000.0
          health = ValueOrExpr.Concrete 50000.0
          sightDistance = ValueOrExpr.Concrete 750.0
          footprintX = 0.0
          footprintZ = 0.0
          objectName = Some "scavs/scavbeacon_t3.s3o"
          buildPic = Some "scavengers/SCAVBEACON.DDS"
          script = Some "scavs/scavbeacon.cob"
          corpse = None
          explodeAs = Some "commanderExplosion"
          selfDestructAs = None
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "64 64 64"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 4.0
          category = Some "CANBEUW"
          energyMake = ValueOrExpr.Concrete 800.0
          metalMake = ValueOrExpr.Concrete 8.0
          energyStorage = 100000.0
          metalStorage = 10000.0
          yardMap = ""
          activateWhenBuilt = true
          weapons = [
                { name = "weapon"
                  displayName = "Armageddon Heat Ray"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "commanders", 750.0
                      "default", 2500.0
                  ]
                  range = Some (ValueOrExpr.Concrete 750.0)
                  reloadTime = Some (ValueOrExpr.Concrete 3.75)
                  weaponVelocity = Some 1800.0
                  areaOfEffect = Some 72.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "heatray2xl"
                  soundHit = None
                  explosiongenerator = Some "custom:genericshellexplosion-medium-beam"
                  rgbColor = Some "1 0.8 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "avoidfeature", "false"
                      "beamtime", "1.0"
                      "cameraShake", "350.0"
                      "corethickness", "0.4"
                      "craterareaofeffect", "72.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "1200.0"
                      "largebeamlaser", "true"
                      "laserflaresize", "8.8"
                      "rgbcolor2", "0.8 0 0"
                      "scrollspeed", "5.0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "6.0"
                  ] }
            ]
          customParams = Map.ofList [
                "subfolder", "Scavengers"
                "normaltex", "unittextures/cor_normal.dds"
                "paratrooper", "true"
            ]
          extras = Map.ofList [
                "autoheal", "10.0"
                "blocking", "false"
                "canSelfDestruct", "false"
                "capturable", "true"
                "cantbetransported", "true"
                "hidedamage", "true"
                "levelground", "false"
                "mass", "10000.0"
                "noautofire", "false"
                "selfdestructcountdown", "1.0"
                "smoothanim", "true"
                "transportByEnemy", "true"
                "unitname", "scavengerbeacon"
                "upright", "false"
                "reclaimable", "true"
            ] }

    let scavbeacon_t3Def : UnitDef =
        { name = "scavbeacon_t3"
          subfolder = "Scavengers/Buildings/Utility"
          metalCost = ValueOrExpr.Concrete 5000.0
          energyCost = ValueOrExpr.Concrete 50000.0
          buildTime = ValueOrExpr.Concrete 50000.0
          health = ValueOrExpr.Concrete 50000.0
          sightDistance = ValueOrExpr.Concrete 750.0
          footprintX = 0.0
          footprintZ = 0.0
          objectName = Some "scavs/scavbeacon_t3.s3o"
          buildPic = Some "scavengers/SCAVBEACON.DDS"
          script = Some "scavs/scavbeacon.cob"
          corpse = None
          explodeAs = Some "commanderExplosion"
          selfDestructAs = None
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "64 64 64"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 4.0
          category = Some "CANBEUW"
          movement = None
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = "Armageddon Heat Ray"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 750.0
                    "default", 2500.0
                ]
                range = Some (ValueOrExpr.Concrete 750.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.75)
                weaponVelocity = Some 1800.0
                areaOfEffect = Some 72.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "heatray2xl"
                soundHit = None
                explosiongenerator = Some "custom:genericshellexplosion-medium-beam"
                rgbColor = Some "1 0.8 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "avoidfeature", "false"
                    "beamtime", "1.0"
                    "cameraShake", "350.0"
                    "corethickness", "0.4"
                    "craterareaofeffect", "72.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "1200.0"
                    "largebeamlaser", "true"
                    "laserflaresize", "8.8"
                    "rgbcolor2", "0.8 0 0"
                    "scrollspeed", "5.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "6.0"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 800.0)
              metalMake = Some (ValueOrExpr.Concrete 8.0)
              energyStorage = Some 100000.0
              metalStorage = Some 10000.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some ""
              activateWhenBuilt = Some true
              canRepeat = None })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "Scavengers"
              "normaltex", "unittextures/cor_normal.dds"
              "paratrooper", "true"
          ]
          extras = Map.ofList [
              "autoheal", "10.0"
              "blocking", "false"
              "canSelfDestruct", "false"
              "capturable", "true"
              "cantbetransported", "true"
              "hidedamage", "true"
              "levelground", "false"
              "mass", "10000.0"
              "noautofire", "false"
              "selfdestructcountdown", "1.0"
              "smoothanim", "true"
              "transportByEnemy", "true"
              "unitname", "scavengerbeacon"
              "upright", "false"
              "reclaimable", "true"
          ] }

    let scavbeacon_t3ToFlat (def: UnitDef) : Scavbeacon_t3 =
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
          metalMake = def.economy.Value.metalMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          yardMap = def.building.Value.yardMap.Value
          activateWhenBuilt = def.building.Value.activateWhenBuilt.Value
          weapons = def.weapons.Value
          customParams = def.customParams
          extras = def.extras }

    let scavbeacon_t3ToUnitDef (flat: Scavbeacon_t3) : UnitDef =
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
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = Some flat.metalMake
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = Some flat.activateWhenBuilt
              canRepeat = None
            }
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Scavbeacon_t4 =
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
          metalMake: ValueOrExpr<float>
          energyStorage: float
          metalStorage: float
          yardMap: string
          activateWhenBuilt: bool
          weapons: WeaponDef list
          customParams: Map<string, string>
          extras: Map<string, string> }

    let scavbeacon_t4 : Scavbeacon_t4 =
        { name = "scavbeacon_t4"
          subfolder = "Scavengers/Buildings/Utility"
          metalCost = ValueOrExpr.Concrete 10000.0
          energyCost = ValueOrExpr.Concrete 100000.0
          buildTime = ValueOrExpr.Concrete 100000.0
          health = ValueOrExpr.Concrete 100000.0
          sightDistance = ValueOrExpr.Concrete 750.0
          footprintX = 0.0
          footprintZ = 0.0
          objectName = Some "scavs/scavbeacon_t4.s3o"
          buildPic = Some "scavengers/SCAVBEACON.DDS"
          script = Some "scavs/scavbeacon.cob"
          corpse = None
          explodeAs = Some "commanderExplosion"
          selfDestructAs = None
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "85 85 85"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 4.0
          category = Some "CANBEUW"
          energyMake = ValueOrExpr.Concrete 1600.0
          metalMake = ValueOrExpr.Concrete 16.0
          energyStorage = 200000.0
          metalStorage = 20000.0
          yardMap = ""
          activateWhenBuilt = true
          weapons = [
                { name = "weapon"
                  displayName = "Armageddon Heat Ray"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "commanders", 4125.0
                      "default", 12500.0
                  ]
                  range = Some (ValueOrExpr.Concrete 750.0)
                  reloadTime = Some (ValueOrExpr.Concrete 3.75)
                  weaponVelocity = Some 1800.0
                  areaOfEffect = Some 72.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "heatray2xl"
                  soundHit = None
                  explosiongenerator = Some "custom:genericshellexplosion-medium-beam"
                  rgbColor = Some "1 0.8 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "avoidfeature", "false"
                      "beamtime", "1.0"
                      "cameraShake", "350.0"
                      "corethickness", "0.4"
                      "craterareaofeffect", "72.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "1200.0"
                      "largebeamlaser", "true"
                      "laserflaresize", "8.8"
                      "rgbcolor2", "0.8 0 0"
                      "scrollspeed", "5.0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "8.0"
                  ] }
            ]
          customParams = Map.ofList [
                "subfolder", "Scavengers"
                "normaltex", "unittextures/cor_normal.dds"
                "paratrooper", "true"
            ]
          extras = Map.ofList [
                "autoheal", "10.0"
                "blocking", "false"
                "canSelfDestruct", "false"
                "capturable", "true"
                "cantbetransported", "true"
                "hidedamage", "true"
                "levelground", "false"
                "mass", "10000.0"
                "noautofire", "false"
                "selfdestructcountdown", "1.0"
                "smoothanim", "true"
                "transportByEnemy", "true"
                "unitname", "scavengerbeacon"
                "upright", "false"
                "reclaimable", "true"
            ] }

    let scavbeacon_t4Def : UnitDef =
        { name = "scavbeacon_t4"
          subfolder = "Scavengers/Buildings/Utility"
          metalCost = ValueOrExpr.Concrete 10000.0
          energyCost = ValueOrExpr.Concrete 100000.0
          buildTime = ValueOrExpr.Concrete 100000.0
          health = ValueOrExpr.Concrete 100000.0
          sightDistance = ValueOrExpr.Concrete 750.0
          footprintX = 0.0
          footprintZ = 0.0
          objectName = Some "scavs/scavbeacon_t4.s3o"
          buildPic = Some "scavengers/SCAVBEACON.DDS"
          script = Some "scavs/scavbeacon.cob"
          corpse = None
          explodeAs = Some "commanderExplosion"
          selfDestructAs = None
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "85 85 85"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 4.0
          category = Some "CANBEUW"
          movement = None
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = "Armageddon Heat Ray"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 4125.0
                    "default", 12500.0
                ]
                range = Some (ValueOrExpr.Concrete 750.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.75)
                weaponVelocity = Some 1800.0
                areaOfEffect = Some 72.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "heatray2xl"
                soundHit = None
                explosiongenerator = Some "custom:genericshellexplosion-medium-beam"
                rgbColor = Some "1 0.8 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "avoidfeature", "false"
                    "beamtime", "1.0"
                    "cameraShake", "350.0"
                    "corethickness", "0.4"
                    "craterareaofeffect", "72.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "1200.0"
                    "largebeamlaser", "true"
                    "laserflaresize", "8.8"
                    "rgbcolor2", "0.8 0 0"
                    "scrollspeed", "5.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "8.0"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 1600.0)
              metalMake = Some (ValueOrExpr.Concrete 16.0)
              energyStorage = Some 200000.0
              metalStorage = Some 20000.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some ""
              activateWhenBuilt = Some true
              canRepeat = None })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "Scavengers"
              "normaltex", "unittextures/cor_normal.dds"
              "paratrooper", "true"
          ]
          extras = Map.ofList [
              "autoheal", "10.0"
              "blocking", "false"
              "canSelfDestruct", "false"
              "capturable", "true"
              "cantbetransported", "true"
              "hidedamage", "true"
              "levelground", "false"
              "mass", "10000.0"
              "noautofire", "false"
              "selfdestructcountdown", "1.0"
              "smoothanim", "true"
              "transportByEnemy", "true"
              "unitname", "scavengerbeacon"
              "upright", "false"
              "reclaimable", "true"
          ] }

    let scavbeacon_t4ToFlat (def: UnitDef) : Scavbeacon_t4 =
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
          metalMake = def.economy.Value.metalMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          yardMap = def.building.Value.yardMap.Value
          activateWhenBuilt = def.building.Value.activateWhenBuilt.Value
          weapons = def.weapons.Value
          customParams = def.customParams
          extras = def.extras }

    let scavbeacon_t4ToUnitDef (flat: Scavbeacon_t4) : UnitDef =
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
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = Some flat.metalMake
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = Some flat.activateWhenBuilt
              canRepeat = None
            }
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Scavsafeareabeacon =
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

    let scavsafeareabeacon : Scavsafeareabeacon =
        { name = "scavsafeareabeacon"
          subfolder = "Scavengers/Buildings/Utility"
          metalCost = ValueOrExpr.Concrete 10000.0
          energyCost = ValueOrExpr.Concrete 100000.0
          buildTime = ValueOrExpr.Concrete 100000.0
          health = ValueOrExpr.Concrete 2800.0
          sightDistance = ValueOrExpr.Concrete 1560.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "scavs/scavsafeareabeacon.s3o"
          buildPic = Some "scavengers/scavsafeareabeacon.DDS"
          script = Some "Units/ARMEYES.cob"
          corpse = None
          explodeAs = Some "scavcomexplosion"
          selfDestructAs = None
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          yardMap = ""
          activateWhenBuilt = true
          canRepeat = false
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
                select = ["minesel1"] }
          customParams = Map.ofList [
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandUtil"
            ]
          extras = Map.ofList [
                "buildangle", "8192.0"
                "blocking", "false"
                "cloakcost", "10.0"
                "initcloaked", "true"
                "levelground", "false"
                "mincloakdistance", "250.0"
                "stealth", "true"
                "reclaimable", "false"
            ] }

    let scavsafeareabeaconDef : UnitDef =
        { name = "scavsafeareabeacon"
          subfolder = "Scavengers/Buildings/Utility"
          metalCost = ValueOrExpr.Concrete 10000.0
          energyCost = ValueOrExpr.Concrete 100000.0
          buildTime = ValueOrExpr.Concrete 100000.0
          health = ValueOrExpr.Concrete 2800.0
          sightDistance = ValueOrExpr.Concrete 1560.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "scavs/scavsafeareabeacon.s3o"
          buildPic = Some "scavengers/scavsafeareabeacon.DDS"
          script = Some "Units/ARMEYES.cob"
          corpse = None
          explodeAs = Some "scavcomexplosion"
          selfDestructAs = None
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
            { yardMap = Some ""
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
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["servsml6"]
              select = ["minesel1"] })
          customParams = Map.ofList [
              "model_author", "Beherith"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/LandUtil"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
              "blocking", "false"
              "cloakcost", "10.0"
              "initcloaked", "true"
              "levelground", "false"
              "mincloakdistance", "250.0"
              "stealth", "true"
              "reclaimable", "false"
          ] }

    let scavsafeareabeaconToFlat (def: UnitDef) : Scavsafeareabeacon =
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

    let scavsafeareabeaconToUnitDef (flat: Scavsafeareabeacon) : UnitDef =
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

