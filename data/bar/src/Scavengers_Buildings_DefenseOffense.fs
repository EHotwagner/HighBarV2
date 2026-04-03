// Auto-generated BAR unit data: Scavengers/Buildings/DefenseOffense (unified)
namespace BarData.Units

open BarData

module Scavengers_Buildings_DefenseOffense =

    type Armannit3 =
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
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armannit3 : Armannit3 =
        { name = "armannit3"
          subfolder = "Scavengers/Buildings/DefenseOffense"
          metalCost = ValueOrExpr.Concrete 13500.0
          energyCost = ValueOrExpr.Concrete 450000.0
          buildTime = ValueOrExpr.Concrete 190000.0
          health = ValueOrExpr.Concrete 28000.0
          sightDistance = ValueOrExpr.Concrete 900.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/scavbuildings/ARMANNIT3.s3o"
          buildPic = Some "ARMANNIT3.DDS"
          script = Some "Units/ARMANNI.cob"
          corpse = Some "DEAD"
          explodeAs = Some "fusionExplosion"
          selfDestructAs = Some "fusionExplosion"
          collisionVolumeOffsets = Some "0 15 0"
          collisionVolumeScales = Some "81 122 81"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          energyStorage = 3000.0
          yardMap = "oooooo oooooo oooooo oooooo oooooo oooooo"
          activateWhenBuilt = true
          canRepeat = false
          weapons = [
                { name = "ata"
                  displayName = "Heavy long-range g2g tachyon accelerator beam"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "commanders", 480.0
                      "default", 48000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1800.0)
                  reloadTime = Some (ValueOrExpr.Concrete 15.0)
                  weaponVelocity = Some 3100.0
                  areaOfEffect = Some 16.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.3
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "annigun1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-large-blue"
                  rgbColor = Some "0 0 1"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "beamtime", "1.0"
                      "collidefriendly", "false"
                      "corethickness", "0.5"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "7000.0"
                      "firestarter", "90.0"
                      "largebeamlaser", "true"
                      "laserflaresize", "8.0"
                      "scrollspeed", "5.0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "texture3", "largebeam"
                      "thickness", "10.0"
                      "tilelength", "150.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 1.06567382829e-05 -0.0"
                  collisionVolumeScales = Some "62.5 81.7362213135 62.5"
                  collisionVolumeType = Some "Box"
                  damage = Some 1800.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 20.0
                  metal = Some 5820.0
                  object_ = Some "Units/scavbuildings/armannit3_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 900.0
                  featureDead = None
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 4.0
                  metal = Some 2328.0
                  object_ = Some "Units/arm3X3B.s3o"
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
                ok = ["obli"]
                select = ["obli"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/armannit3_aoplane.dds"
                "buildinggrounddecalsizey", "9.0"
                "buildinggrounddecalsizex", "9.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "weapon"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandDefenceOffence"
                "techlevel", "3.0"
            ]
          extras = Map.ofList [
                "buildangle", "4096.0"
                "damagemodifier", "0.25"
                "sightemitheight", "72.0"
                "nochasecategory", "MOBILE"
                "onoffable", "true"
                "radardistance", "1500.0"
                "radaremitheight", "72.0"
                "usePieceCollisionVolumes", "1.0"
            ] }

    let armannit3Def : UnitDef =
        { name = "armannit3"
          subfolder = "Scavengers/Buildings/DefenseOffense"
          metalCost = ValueOrExpr.Concrete 13500.0
          energyCost = ValueOrExpr.Concrete 450000.0
          buildTime = ValueOrExpr.Concrete 190000.0
          health = ValueOrExpr.Concrete 28000.0
          sightDistance = ValueOrExpr.Concrete 900.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/scavbuildings/ARMANNIT3.s3o"
          buildPic = Some "ARMANNIT3.DDS"
          script = Some "Units/ARMANNI.cob"
          corpse = Some "DEAD"
          explodeAs = Some "fusionExplosion"
          selfDestructAs = Some "fusionExplosion"
          collisionVolumeOffsets = Some "0 15 0"
          collisionVolumeScales = Some "81 122 81"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "ata"
                displayName = "Heavy long-range g2g tachyon accelerator beam"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 480.0
                    "default", 48000.0
                ]
                range = Some (ValueOrExpr.Concrete 1800.0)
                reloadTime = Some (ValueOrExpr.Concrete 15.0)
                weaponVelocity = Some 3100.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.3
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "annigun1"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-large-blue"
                rgbColor = Some "0 0 1"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "beamtime", "1.0"
                    "collidefriendly", "false"
                    "corethickness", "0.5"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "7000.0"
                    "firestarter", "90.0"
                    "largebeamlaser", "true"
                    "laserflaresize", "8.0"
                    "scrollspeed", "5.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "texture3", "largebeam"
                    "thickness", "10.0"
                    "tilelength", "150.0"
                ] }
          ]
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 3000.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooooo oooooo oooooo oooooo oooooo oooooo"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0 1.06567382829e-05 -0.0"
                collisionVolumeScales = Some "62.5 81.7362213135 62.5"
                collisionVolumeType = Some "Box"
                damage = Some 1800.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 20.0
                metal = Some 5820.0
                object_ = Some "Units/scavbuildings/armannit3_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 900.0
                featureDead = None
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 4.0
                metal = Some 2328.0
                object_ = Some "Units/arm3X3B.s3o"
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
              ok = ["obli"]
              select = ["obli"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/armannit3_aoplane.dds"
              "buildinggrounddecalsizey", "9.0"
              "buildinggrounddecalsizex", "9.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "weapon"
              "model_author", "Cremuss"
              "normaltex", "unittextures/Arm_normal.dds"
              "removewait", "true"
              "subfolder", "ArmBuildings/LandDefenceOffence"
              "techlevel", "3.0"
          ]
          extras = Map.ofList [
              "buildangle", "4096.0"
              "damagemodifier", "0.25"
              "sightemitheight", "72.0"
              "nochasecategory", "MOBILE"
              "onoffable", "true"
              "radardistance", "1500.0"
              "radaremitheight", "72.0"
              "usePieceCollisionVolumes", "1.0"
          ] }

    let armannit3ToFlat (def: UnitDef) : Armannit3 =
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
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armannit3ToUnitDef (flat: Armannit3) : UnitDef =
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
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = Some flat.activateWhenBuilt
              canRepeat = Some flat.canRepeat
            }
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armbotrail =
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
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armbotrail : Armbotrail =
        { name = "armbotrail"
          subfolder = "Scavengers/Buildings/DefenseOffense"
          metalCost = ValueOrExpr.Concrete 13500.0
          energyCost = ValueOrExpr.Concrete 192000.0
          buildTime = ValueOrExpr.Concrete 255000.0
          health = ValueOrExpr.Concrete 4450.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 8.0
          footprintZ = 8.0
          objectName = Some "scavs/armbotrail.s3o"
          buildPic = Some "ARMBOTRAIL.DDS"
          script = Some "scavs/armbotrail.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeBuildingExplosionGeneric"
          selfDestructAs = Some "hugeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 -20"
          collisionVolumeScales = Some "48 90 48"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          yardMap = "oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo "
          canRepeat = false
          weapons = [
                { name = "arm_botrail"
                  displayName = "Long range bot cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 10.0
                      "shields", 150.0
                  ]
                  range = Some (ValueOrExpr.Concrete 5250.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.5)
                  weaponVelocity = Some 1250.0
                  areaOfEffect = Some 10.0
                  accuracy = Some 1.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.5
                  noSelfDamage = Some true
                  soundStart = Some "lrpcshot3"
                  soundHit = Some "xplonuk1xs"
                  explosiongenerator = Some "custom:botrailspawn"
                  rgbColor = None
                  customParams = Map.ofList [
                      "spawns_name", "armpw"
                      "spawns_surface", "LAND"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "MOBILE"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "cegtag", "arty-botrail"
                      "collidefriendly", "false"
                      "craterareaofeffect", "116.0"
                      "craterboost", "0.1"
                      "cratermult", "0.1"
                      "energypershot", "2880.0"
                      "gravityaffected", "true"
                      "heightboostfactor", "8.0"
                      "hightrajectory", "0.0"
                      "leadbonus", "0.0"
                      "metalpershot", "96.0"
                      "model", "armpw_anim_projectile.s3o"
                      "mygravity", "0.22"
                      "sprayangle", "720.0"
                      "stockpile", "true"
                      "stockpiletime", "3.0"
                      "soundhitwet", "splshbig"
                      "soundstartvolume", "50.0"
                      "waterbounce", "true"
                      "bounceSlip", "0.74"
                      "bouncerebound", "0.5"
                      "numbounce", "10.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "3.15924835205 -0.787798413086 6.6563873291"
                  collisionVolumeScales = Some "81.6838531494 113.772003174 72.5632324219"
                  collisionVolumeType = Some "Box"
                  damage = Some 2520.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 40.0
                  metal = Some 2720.0
                  object_ = Some "Units/armbrtha_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 1260.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 1088.0
                  object_ = Some "Units/arm3X3E.s3o"
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
                ok = ["servlrg3"]
                select = ["servlrg3"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/armbotrail_aoplane.dds"
                "buildinggrounddecalsizey", "12.0"
                "buildinggrounddecalsizex", "12.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "weapon"
                "restrictions_inclusion", "_nolrpc_"
                "canareaattack", "1.0"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBuildings/LandDefenceOffence"
                "techlevel", "2.0"
                "inheritxpratemultiplier", "1.0"
                "childreninheritxp", "BOTCANNON"
                "parentsinheritxp", "BOTCANNON"
            ]
          extras = Map.ofList [
                "buildangle", "32700.0"
                "firestate", "0.0"
                "usepiececollisionvolumes", "1.0"
            ] }

    let armbotrailDef : UnitDef =
        { name = "armbotrail"
          subfolder = "Scavengers/Buildings/DefenseOffense"
          metalCost = ValueOrExpr.Concrete 13500.0
          energyCost = ValueOrExpr.Concrete 192000.0
          buildTime = ValueOrExpr.Concrete 255000.0
          health = ValueOrExpr.Concrete 4450.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 8.0
          footprintZ = 8.0
          objectName = Some "scavs/armbotrail.s3o"
          buildPic = Some "ARMBOTRAIL.DDS"
          script = Some "scavs/armbotrail.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeBuildingExplosionGeneric"
          selfDestructAs = Some "hugeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 -20"
          collisionVolumeScales = Some "48 90 48"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "arm_botrail"
                displayName = "Long range bot cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 10.0
                    "shields", 150.0
                ]
                range = Some (ValueOrExpr.Concrete 5250.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.5)
                weaponVelocity = Some 1250.0
                areaOfEffect = Some 10.0
                accuracy = Some 1.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.5
                noSelfDamage = Some true
                soundStart = Some "lrpcshot3"
                soundHit = Some "xplonuk1xs"
                explosiongenerator = Some "custom:botrailspawn"
                rgbColor = None
                customParams = Map.ofList [
                    "spawns_name", "armpw"
                    "spawns_surface", "LAND"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "cegtag", "arty-botrail"
                    "collidefriendly", "false"
                    "craterareaofeffect", "116.0"
                    "craterboost", "0.1"
                    "cratermult", "0.1"
                    "energypershot", "2880.0"
                    "gravityaffected", "true"
                    "heightboostfactor", "8.0"
                    "hightrajectory", "0.0"
                    "leadbonus", "0.0"
                    "metalpershot", "96.0"
                    "model", "armpw_anim_projectile.s3o"
                    "mygravity", "0.22"
                    "sprayangle", "720.0"
                    "stockpile", "true"
                    "stockpiletime", "3.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "50.0"
                    "waterbounce", "true"
                    "bounceSlip", "0.74"
                    "bouncerebound", "0.5"
                    "numbounce", "10.0"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo "
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "3.15924835205 -0.787798413086 6.6563873291"
                collisionVolumeScales = Some "81.6838531494 113.772003174 72.5632324219"
                collisionVolumeType = Some "Box"
                damage = Some 2520.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 40.0
                metal = Some 2720.0
                object_ = Some "Units/armbrtha_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 1260.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 1088.0
                object_ = Some "Units/arm3X3E.s3o"
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
              ok = ["servlrg3"]
              select = ["servlrg3"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/armbotrail_aoplane.dds"
              "buildinggrounddecalsizey", "12.0"
              "buildinggrounddecalsizex", "12.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "weapon"
              "restrictions_inclusion", "_nolrpc_"
              "canareaattack", "1.0"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmBuildings/LandDefenceOffence"
              "techlevel", "2.0"
              "inheritxpratemultiplier", "1.0"
              "childreninheritxp", "BOTCANNON"
              "parentsinheritxp", "BOTCANNON"
          ]
          extras = Map.ofList [
              "buildangle", "32700.0"
              "firestate", "0.0"
              "usepiececollisionvolumes", "1.0"
          ] }

    let armbotrailToFlat (def: UnitDef) : Armbotrail =
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
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armbotrailToUnitDef (flat: Armbotrail) : UnitDef =
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
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armlwall =
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
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armlwall : Armlwall =
        { name = "armlwall"
          subfolder = "Scavengers/Buildings/DefenseOffense"
          metalCost = ValueOrExpr.Concrete 1020.0
          energyCost = ValueOrExpr.Concrete 4800.0
          buildTime = ValueOrExpr.Concrete 14000.0
          health = ValueOrExpr.Concrete 5320.0
          sightDistance = ValueOrExpr.Concrete 330.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMLWALL.s3o"
          buildPic = Some "ARMLWALL.DDS"
          script = Some "Units/ARMLWALL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallBuildingexplosiongeneric"
          selfDestructAs = Some "tinyBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -3 0"
          collisionVolumeScales = Some "32 50 32"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          yardMap = "ffff"
          canRepeat = false
          weapons = [
                { name = "lightning"
                  displayName = "Medium Lightning Cannon"
                  weaponType = Some "LightningCannon"
                  damage = Map.ofList [
                      "default", 64.0
                  ]
                  range = Some (ValueOrExpr.Concrete 315.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.33)
                  weaponVelocity = Some 400.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lghthvy1"
                  soundHit = Some "lashit"
                  explosiongenerator = Some "custom:genericshellexplosion-medium-lightning2"
                  rgbColor = Some "0.5 0.5 1"
                  customParams = Map.ofList [
                      "spark_ceg", "genericshellexplosion-splash-lightning"
                      "spark_forkdamage", "0.3"
                      "spark_maxunits", "3"
                      "spark_range", "80"
                  ]
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_fastautoretargeting", "true"
                      "avoidfeature", "false"
                      "beamttl", "1.0"
                      "burst", "10.0"
                      "burstrate", "0.03333"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "1.0"
                      "energypershot", "5.0"
                      "firestarter", "50.0"
                      "impactonly", "1.0"
                      "intensity", "28.0"
                      "soundhitwet", "sizzle"
                      "soundtrigger", "true"
                      "thickness", "2.2"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -3 0"
                  collisionVolumeScales = Some "32 50 32"
                  collisionVolumeType = Some "CylY"
                  damage = Some 540.0
                  featureDead = Some "ROCKTEETH"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 205.0
                  object_ = Some "Units/armfort.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "rockteeth",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 500.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 2.0
                  object_ = Some "Units/arm1X1A.s3o"
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
                ok = ["servmed2"]
                select = ["servmed2"] }
          customParams = Map.ofList [
                "neutral_when_closed", "true"
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/armfort_aoplane.dds"
                "buildinggrounddecalsizey", "4.0"
                "buildinggrounddecalsizex", "4.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "weapon"
                "decoyfor", "armfort"
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandDefenceOffence"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "crushresistance", "1000.0"
                "damagemodifier", "0.25"
                "decoyfor", "armfort"
                "hidedamage", "true"
                "levelground", "false"
                "mass", "10000000000.0"
                "nochasecategory", "MOBILE"
                "stealth", "true"
                "upright", "true"
            ] }

    let armlwallDef : UnitDef =
        { name = "armlwall"
          subfolder = "Scavengers/Buildings/DefenseOffense"
          metalCost = ValueOrExpr.Concrete 1020.0
          energyCost = ValueOrExpr.Concrete 4800.0
          buildTime = ValueOrExpr.Concrete 14000.0
          health = ValueOrExpr.Concrete 5320.0
          sightDistance = ValueOrExpr.Concrete 330.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMLWALL.s3o"
          buildPic = Some "ARMLWALL.DDS"
          script = Some "Units/ARMLWALL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallBuildingexplosiongeneric"
          selfDestructAs = Some "tinyBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -3 0"
          collisionVolumeScales = Some "32 50 32"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "lightning"
                displayName = "Medium Lightning Cannon"
                weaponType = Some "LightningCannon"
                damage = Map.ofList [
                    "default", 64.0
                ]
                range = Some (ValueOrExpr.Concrete 315.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.33)
                weaponVelocity = Some 400.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lghthvy1"
                soundHit = Some "lashit"
                explosiongenerator = Some "custom:genericshellexplosion-medium-lightning2"
                rgbColor = Some "0.5 0.5 1"
                customParams = Map.ofList [
                    "spark_ceg", "genericshellexplosion-splash-lightning"
                    "spark_forkdamage", "0.3"
                    "spark_maxunits", "3"
                    "spark_range", "80"
                ]
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_fastautoretargeting", "true"
                    "avoidfeature", "false"
                    "beamttl", "1.0"
                    "burst", "10.0"
                    "burstrate", "0.03333"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "1.0"
                    "energypershot", "5.0"
                    "firestarter", "50.0"
                    "impactonly", "1.0"
                    "intensity", "28.0"
                    "soundhitwet", "sizzle"
                    "soundtrigger", "true"
                    "thickness", "2.2"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "ffff"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -3 0"
                collisionVolumeScales = Some "32 50 32"
                collisionVolumeType = Some "CylY"
                damage = Some 540.0
                featureDead = Some "ROCKTEETH"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 205.0
                object_ = Some "Units/armfort.s3o"
                reclaimable = Some true
                resurrectable = None }
              "rockteeth",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 500.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 2.0
                object_ = Some "Units/arm1X1A.s3o"
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
              ok = ["servmed2"]
              select = ["servmed2"] })
          customParams = Map.ofList [
              "neutral_when_closed", "true"
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/armfort_aoplane.dds"
              "buildinggrounddecalsizey", "4.0"
              "buildinggrounddecalsizex", "4.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "weapon"
              "decoyfor", "armfort"
              "model_author", "Beherith"
              "normaltex", "unittextures/Arm_normal.dds"
              "removewait", "true"
              "subfolder", "ArmBuildings/LandDefenceOffence"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "crushresistance", "1000.0"
              "damagemodifier", "0.25"
              "decoyfor", "armfort"
              "hidedamage", "true"
              "levelground", "false"
              "mass", "10000000000.0"
              "nochasecategory", "MOBILE"
              "stealth", "true"
              "upright", "true"
          ] }

    let armlwallToFlat (def: UnitDef) : Armlwall =
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
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armlwallToUnitDef (flat: Armlwall) : UnitDef =
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
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armminivulc =
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
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armminivulc : Armminivulc =
        { name = "armminivulc"
          subfolder = "Scavengers/Buildings/DefenseOffense"
          metalCost = ValueOrExpr.Concrete 2000.0
          energyCost = ValueOrExpr.Concrete 60000.0
          buildTime = ValueOrExpr.Concrete 65000.0
          health = ValueOrExpr.Concrete 6700.0
          sightDistance = ValueOrExpr.Concrete 700.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/scavbuildings/armminivulc.s3o"
          buildPic = Some "ARMMINIVULC.DDS"
          script = Some "Units/scavbuildings/armminivulc.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeBuildingexplosiongeneric"
          selfDestructAs = Some "hugeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -6 0"
          collisionVolumeScales = Some "32 64 32"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          yardMap = "ooo ooo ooo"
          canRepeat = false
          weapons = [
                { name = "armminivulc_weapon"
                  displayName = "Mini Rapid-fire long-range plasma cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 210.0
                      "shields", 105.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.4)
                  weaponVelocity = Some 660.0
                  areaOfEffect = Some 44.8
                  accuracy = Some 700.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.9
                  impulseFactor = Some 0.1
                  noSelfDamage = Some true
                  soundStart = Some "cannon2"
                  soundHit = Some "xplomed3"
                  explosiongenerator = Some "custom:genericshellexplosion-medium-bomb"
                  rgbColor = Some "1, 0.4, 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "MOBILE"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "avoidfriendly", "true"
                      "avoidground", "true"
                      "cegtag", "arty-heavy"
                      "collidefriendly", "false"
                      "craterboost", "0.02"
                      "cratermult", "0.02"
                      "energypershot", "1000.0"
                      "gravityaffected", "true"
                      "soundhitwet", "splshbig"
                      "weapontimer", "14.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "32 64 32"
                  collisionVolumeType = Some "Box"
                  damage = Some 3000.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 6000.0
                  object_ = Some "Units/scavbuildings/armminivulc_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 1500.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 3000.0
                  object_ = Some "Units/arm3X3A.s3o"
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
                ok = ["servlrg3"]
                select = ["servlrg3"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "false"
                "buildinggrounddecaltype", "decals/armminivulc_aoplane.dds"
                "buildinggrounddecalsizey", "6.0"
                "buildinggrounddecalsizex", "6.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "weapon"
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandDefenceOffence"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "buildangle", "29096.0"
            ] }

    let armminivulcDef : UnitDef =
        { name = "armminivulc"
          subfolder = "Scavengers/Buildings/DefenseOffense"
          metalCost = ValueOrExpr.Concrete 2000.0
          energyCost = ValueOrExpr.Concrete 60000.0
          buildTime = ValueOrExpr.Concrete 65000.0
          health = ValueOrExpr.Concrete 6700.0
          sightDistance = ValueOrExpr.Concrete 700.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/scavbuildings/armminivulc.s3o"
          buildPic = Some "ARMMINIVULC.DDS"
          script = Some "Units/scavbuildings/armminivulc.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeBuildingexplosiongeneric"
          selfDestructAs = Some "hugeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -6 0"
          collisionVolumeScales = Some "32 64 32"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "armminivulc_weapon"
                displayName = "Mini Rapid-fire long-range plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 210.0
                    "shields", 105.0
                ]
                range = Some (ValueOrExpr.Concrete 1300.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.4)
                weaponVelocity = Some 660.0
                areaOfEffect = Some 44.8
                accuracy = Some 700.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.9
                impulseFactor = Some 0.1
                noSelfDamage = Some true
                soundStart = Some "cannon2"
                soundHit = Some "xplomed3"
                explosiongenerator = Some "custom:genericshellexplosion-medium-bomb"
                rgbColor = Some "1, 0.4, 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "avoidfriendly", "true"
                    "avoidground", "true"
                    "cegtag", "arty-heavy"
                    "collidefriendly", "false"
                    "craterboost", "0.02"
                    "cratermult", "0.02"
                    "energypershot", "1000.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splshbig"
                    "weapontimer", "14.0"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "ooo ooo ooo"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "32 64 32"
                collisionVolumeType = Some "Box"
                damage = Some 3000.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 6000.0
                object_ = Some "Units/scavbuildings/armminivulc_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 1500.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 3000.0
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
              ok = ["servlrg3"]
              select = ["servlrg3"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "false"
              "buildinggrounddecaltype", "decals/armminivulc_aoplane.dds"
              "buildinggrounddecalsizey", "6.0"
              "buildinggrounddecalsizex", "6.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "weapon"
              "model_author", "Beherith"
              "normaltex", "unittextures/Arm_normal.dds"
              "removewait", "true"
              "subfolder", "ArmBuildings/LandDefenceOffence"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "buildangle", "29096.0"
          ] }

    let armminivulcToFlat (def: UnitDef) : Armminivulc =
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
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armminivulcToUnitDef (flat: Armminivulc) : UnitDef =
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
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Cordoomt3 =
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
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let cordoomt3 : Cordoomt3 =
        { name = "cordoomt3"
          subfolder = "Scavengers/Buildings/DefenseOffense"
          metalCost = ValueOrExpr.Concrete 12000.0
          energyCost = ValueOrExpr.Concrete 400000.0
          buildTime = ValueOrExpr.Concrete 170000.0
          health = ValueOrExpr.Concrete 39000.0
          sightDistance = ValueOrExpr.Concrete 900.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/scavbuildings/CORDOOMT3.s3o"
          buildPic = Some "CORDOOMT3.DDS"
          script = Some "Units/CORDOOM.cob"
          corpse = Some "DEAD"
          explodeAs = Some "fusionExplosion"
          selfDestructAs = Some "fusionExplosion"
          collisionVolumeOffsets = Some "0.0 -7.5 0.0"
          collisionVolumeScales = Some "72.0 165.0 72.0"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          energyStorage = 1000.0
          yardMap = "yyooyy oooooo oooooo oooooo oooooo yyooyy"
          activateWhenBuilt = true
          canRepeat = false
          weapons = [
                { name = "armagmheat"
                  displayName = "Armageddon Heat Ray"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "commanders", 1350.0
                      "default", 7500.0
                      "vtol", 3000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1350.0)
                  reloadTime = Some (ValueOrExpr.Concrete 4.0)
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
                      "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "beamtime", "0.6"
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
                      "thickness", "7.0"
                  ] }
                { name = "armageddon_blue_laser"
                  displayName = "Long-range g2g tachyon accelerator"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "commanders", 999.0
                      "default", 4500.0
                  ]
                  range = Some (ValueOrExpr.Concrete 950.0)
                  reloadTime = Some (ValueOrExpr.Concrete 6.0)
                  weaponVelocity = Some 1500.0
                  areaOfEffect = Some 12.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "annigun1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-large-blue"
                  rgbColor = Some "0 0 1"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "beamtime", "0.3"
                      "corethickness", "0.32"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "500.0"
                      "firestarter", "90.0"
                      "impactonly", "1.0"
                      "largebeamlaser", "true"
                      "laserflaresize", "8.8"
                      "proximitypriority", "0.0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "texture3", "largebeam"
                      "thickness", "5.5"
                      "tilelength", "150.0"
                  ] }
                { name = "armageddon_green_laser"
                  displayName = "High energy g2g laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 247.0
                      "vtol", 65.0
                  ]
                  range = Some (ValueOrExpr.Concrete 650.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.26)
                  weaponVelocity = Some 800.0
                  areaOfEffect = Some 12.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrhvy3"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-medium-green"
                  rgbColor = Some "0 1 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "beamtime", "0.25"
                      "corethickness", "0.2"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "50.0"
                      "firestarter", "90.0"
                      "impactonly", "1.0"
                      "laserflaresize", "7.7"
                      "proximitypriority", "0.0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "2.6"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.281730651855 -0.153618286133 3.57356262207"
                  collisionVolumeScales = Some "80.6815948486 91.7637634277 82.1471252441"
                  collisionVolumeType = Some "Box"
                  damage = Some 5400.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 20.0
                  metal = Some 4833.0
                  object_ = Some "Units/scavbuildings/cordoomt3_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 2700.0
                  featureDead = None
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 4.0
                  metal = Some 1932.0
                  object_ = Some "Units/cor3X3E.s3o"
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
                ok = ["armag"]
                select = ["armag"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/cordoomt3_aoplane.dds"
                "buildinggrounddecalsizey", "9.0"
                "buildinggrounddecalsizex", "9.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "weapon"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "removewait", "true"
                "paralyzemultiplier", "0.4"
                "subfolder", "CorBuildings/LandDefenceOffence"
                "techlevel", "3.0"
            ]
          extras = Map.ofList [
                "buildangle", "4096.0"
                "damagemodifier", "0.25"
                "sightemitheight", "80.0"
                "nochasecategory", "VTOL"
                "usePieceCollisionVolumes", "1.0"
                "onoffable", "true"
                "radardistance", "1200.0"
                "radaremitheight", "80.0"
            ] }

    let cordoomt3Def : UnitDef =
        { name = "cordoomt3"
          subfolder = "Scavengers/Buildings/DefenseOffense"
          metalCost = ValueOrExpr.Concrete 12000.0
          energyCost = ValueOrExpr.Concrete 400000.0
          buildTime = ValueOrExpr.Concrete 170000.0
          health = ValueOrExpr.Concrete 39000.0
          sightDistance = ValueOrExpr.Concrete 900.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/scavbuildings/CORDOOMT3.s3o"
          buildPic = Some "CORDOOMT3.DDS"
          script = Some "Units/CORDOOM.cob"
          corpse = Some "DEAD"
          explodeAs = Some "fusionExplosion"
          selfDestructAs = Some "fusionExplosion"
          collisionVolumeOffsets = Some "0.0 -7.5 0.0"
          collisionVolumeScales = Some "72.0 165.0 72.0"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "armagmheat"
                displayName = "Armageddon Heat Ray"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 1350.0
                    "default", 7500.0
                    "vtol", 3000.0
                ]
                range = Some (ValueOrExpr.Concrete 1350.0)
                reloadTime = Some (ValueOrExpr.Concrete 4.0)
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
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "beamtime", "0.6"
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
                    "thickness", "7.0"
                ] }
              { name = "armageddon_blue_laser"
                displayName = "Long-range g2g tachyon accelerator"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 999.0
                    "default", 4500.0
                ]
                range = Some (ValueOrExpr.Concrete 950.0)
                reloadTime = Some (ValueOrExpr.Concrete 6.0)
                weaponVelocity = Some 1500.0
                areaOfEffect = Some 12.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "annigun1"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-large-blue"
                rgbColor = Some "0 0 1"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamtime", "0.3"
                    "corethickness", "0.32"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "500.0"
                    "firestarter", "90.0"
                    "impactonly", "1.0"
                    "largebeamlaser", "true"
                    "laserflaresize", "8.8"
                    "proximitypriority", "0.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "texture3", "largebeam"
                    "thickness", "5.5"
                    "tilelength", "150.0"
                ] }
              { name = "armageddon_green_laser"
                displayName = "High energy g2g laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 247.0
                    "vtol", 65.0
                ]
                range = Some (ValueOrExpr.Concrete 650.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.26)
                weaponVelocity = Some 800.0
                areaOfEffect = Some 12.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrhvy3"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-medium-green"
                rgbColor = Some "0 1 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamtime", "0.25"
                    "corethickness", "0.2"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "50.0"
                    "firestarter", "90.0"
                    "impactonly", "1.0"
                    "laserflaresize", "7.7"
                    "proximitypriority", "0.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.6"
                ] }
          ]
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 1000.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "yyooyy oooooo oooooo oooooo oooooo yyooyy"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.281730651855 -0.153618286133 3.57356262207"
                collisionVolumeScales = Some "80.6815948486 91.7637634277 82.1471252441"
                collisionVolumeType = Some "Box"
                damage = Some 5400.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 20.0
                metal = Some 4833.0
                object_ = Some "Units/scavbuildings/cordoomt3_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 2700.0
                featureDead = None
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 4.0
                metal = Some 1932.0
                object_ = Some "Units/cor3X3E.s3o"
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
              ok = ["armag"]
              select = ["armag"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/cordoomt3_aoplane.dds"
              "buildinggrounddecalsizey", "9.0"
              "buildinggrounddecalsizex", "9.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "weapon"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
              "paralyzemultiplier", "0.4"
              "subfolder", "CorBuildings/LandDefenceOffence"
              "techlevel", "3.0"
          ]
          extras = Map.ofList [
              "buildangle", "4096.0"
              "damagemodifier", "0.25"
              "sightemitheight", "80.0"
              "nochasecategory", "VTOL"
              "usePieceCollisionVolumes", "1.0"
              "onoffable", "true"
              "radardistance", "1200.0"
              "radaremitheight", "80.0"
          ] }

    let cordoomt3ToFlat (def: UnitDef) : Cordoomt3 =
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
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let cordoomt3ToUnitDef (flat: Cordoomt3) : UnitDef =
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
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = Some flat.activateWhenBuilt
              canRepeat = Some flat.canRepeat
            }
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corhllllt =
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
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corhllllt : Corhllllt =
        { name = "corhllllt"
          subfolder = "Scavengers/Buildings/DefenseOffense"
          metalCost = ValueOrExpr.Concrete 300.0
          energyCost = ValueOrExpr.Concrete 7000.0
          buildTime = ValueOrExpr.Concrete 8800.0
          health = ValueOrExpr.Concrete 1670.0
          sightDistance = ValueOrExpr.Concrete 475.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/scavbuildings/CORHLLLLT.s3o"
          buildPic = Some "CORHLLLLT.DDS"
          script = Some "Units/scavbuildings/CORHLLLLT.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingexplosiongeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0-20 0"
          collisionVolumeScales = Some "32 160 32"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          yardMap = "oooo"
          canRepeat = false
          weapons = [
                { name = "hllt_1"
                  displayName = "Close-quarters light g2g laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "commanders", 100.0
                      "default", 75.0
                      "vtol", 5.0
                  ]
                  range = Some (ValueOrExpr.Concrete 475.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.2)
                  weaponVelocity = Some 2250.0
                  areaOfEffect = Some 12.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrfir3"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small-red"
                  rgbColor = Some "1 0 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "beamtime", "0.05"
                      "corethickness", "0.175"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "15.0"
                      "firestarter", "30.0"
                      "impactonly", "1.0"
                      "laserflaresize", "8.8"
                      "proximitypriority", "-1.0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "2.0"
                  ] }
                { name = "hllt_2"
                  displayName = "Close-quarters light g2g laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "commanders", 100.0
                      "default", 75.0
                      "vtol", 5.0
                  ]
                  range = Some (ValueOrExpr.Concrete 475.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.3)
                  weaponVelocity = Some 2250.0
                  areaOfEffect = Some 12.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrfir3"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small-red"
                  rgbColor = Some "1 0 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "beamtime", "0.1"
                      "corethickness", "0.175"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "15.0"
                      "firestarter", "30.0"
                      "impactonly", "1.0"
                      "laserflaresize", "8.8"
                      "proximitypriority", "-1.0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "2.0"
                  ] }
                { name = "hllt_3"
                  displayName = "Close-quarters light g2g laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "commanders", 100.0
                      "default", 75.0
                      "vtol", 5.0
                  ]
                  range = Some (ValueOrExpr.Concrete 475.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.4)
                  weaponVelocity = Some 2250.0
                  areaOfEffect = Some 12.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrfir3"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small-red"
                  rgbColor = Some "1 0 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "beamtime", "0.15"
                      "corethickness", "0.175"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "15.0"
                      "firestarter", "30.0"
                      "impactonly", "1.0"
                      "laserflaresize", "8.8"
                      "proximitypriority", "-1.0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "2.0"
                  ] }
                { name = "hllt_4"
                  displayName = "Close-quarters light g2g laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "commanders", 100.0
                      "default", 75.0
                      "vtol", 5.0
                  ]
                  range = Some (ValueOrExpr.Concrete 475.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.5)
                  weaponVelocity = Some 2250.0
                  areaOfEffect = Some 12.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrfir3"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small-red"
                  rgbColor = Some "1 0 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "beamtime", "0.2"
                      "corethickness", "0.175"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "15.0"
                      "firestarter", "30.0"
                      "impactonly", "1.0"
                      "laserflaresize", "8.8"
                      "proximitypriority", "-1.0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "2.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 35 0"
                  collisionVolumeScales = Some "32 140 32"
                  collisionVolumeType = Some "Box"
                  damage = Some 900.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 6.5
                  metal = Some 180.0
                  object_ = Some "Units/scavbuildings/corhllllt_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 450.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 1.0
                  metal = Some 72.0
                  object_ = Some "Units/cor4X4D.s3o"
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
                ok = ["lltok"]
                select = ["hlltselect"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/corhllt_aoplane.dds"
                "buildinggrounddecalsizey", "4.0"
                "buildinggrounddecalsizex", "4.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "weapon"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "removewait", "true"
                "subfolder", "CorBuildings/LandDefenceOffence"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "buildangle", "32768.0"
                "cantbetransported", "false"
                "mass", "10200.0"
            ] }

    let corhlllltDef : UnitDef =
        { name = "corhllllt"
          subfolder = "Scavengers/Buildings/DefenseOffense"
          metalCost = ValueOrExpr.Concrete 300.0
          energyCost = ValueOrExpr.Concrete 7000.0
          buildTime = ValueOrExpr.Concrete 8800.0
          health = ValueOrExpr.Concrete 1670.0
          sightDistance = ValueOrExpr.Concrete 475.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/scavbuildings/CORHLLLLT.s3o"
          buildPic = Some "CORHLLLLT.DDS"
          script = Some "Units/scavbuildings/CORHLLLLT.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingexplosiongeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0-20 0"
          collisionVolumeScales = Some "32 160 32"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "hllt_1"
                displayName = "Close-quarters light g2g laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 100.0
                    "default", 75.0
                    "vtol", 5.0
                ]
                range = Some (ValueOrExpr.Concrete 475.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.2)
                weaponVelocity = Some 2250.0
                areaOfEffect = Some 12.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrfir3"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-small-red"
                rgbColor = Some "1 0 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamtime", "0.05"
                    "corethickness", "0.175"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "15.0"
                    "firestarter", "30.0"
                    "impactonly", "1.0"
                    "laserflaresize", "8.8"
                    "proximitypriority", "-1.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.0"
                ] }
              { name = "hllt_2"
                displayName = "Close-quarters light g2g laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 100.0
                    "default", 75.0
                    "vtol", 5.0
                ]
                range = Some (ValueOrExpr.Concrete 475.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.3)
                weaponVelocity = Some 2250.0
                areaOfEffect = Some 12.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrfir3"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-small-red"
                rgbColor = Some "1 0 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamtime", "0.1"
                    "corethickness", "0.175"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "15.0"
                    "firestarter", "30.0"
                    "impactonly", "1.0"
                    "laserflaresize", "8.8"
                    "proximitypriority", "-1.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.0"
                ] }
              { name = "hllt_3"
                displayName = "Close-quarters light g2g laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 100.0
                    "default", 75.0
                    "vtol", 5.0
                ]
                range = Some (ValueOrExpr.Concrete 475.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.4)
                weaponVelocity = Some 2250.0
                areaOfEffect = Some 12.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrfir3"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-small-red"
                rgbColor = Some "1 0 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamtime", "0.15"
                    "corethickness", "0.175"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "15.0"
                    "firestarter", "30.0"
                    "impactonly", "1.0"
                    "laserflaresize", "8.8"
                    "proximitypriority", "-1.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.0"
                ] }
              { name = "hllt_4"
                displayName = "Close-quarters light g2g laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 100.0
                    "default", 75.0
                    "vtol", 5.0
                ]
                range = Some (ValueOrExpr.Concrete 475.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.5)
                weaponVelocity = Some 2250.0
                areaOfEffect = Some 12.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrfir3"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-small-red"
                rgbColor = Some "1 0 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamtime", "0.2"
                    "corethickness", "0.175"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "15.0"
                    "firestarter", "30.0"
                    "impactonly", "1.0"
                    "laserflaresize", "8.8"
                    "proximitypriority", "-1.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.0"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "oooo"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 35 0"
                collisionVolumeScales = Some "32 140 32"
                collisionVolumeType = Some "Box"
                damage = Some 900.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 6.5
                metal = Some 180.0
                object_ = Some "Units/scavbuildings/corhllllt_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 450.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 1.0
                metal = Some 72.0
                object_ = Some "Units/cor4X4D.s3o"
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
              ok = ["lltok"]
              select = ["hlltselect"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/corhllt_aoplane.dds"
              "buildinggrounddecalsizey", "4.0"
              "buildinggrounddecalsizex", "4.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "weapon"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
              "subfolder", "CorBuildings/LandDefenceOffence"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "buildangle", "32768.0"
              "cantbetransported", "false"
              "mass", "10200.0"
          ] }

    let corhlllltToFlat (def: UnitDef) : Corhllllt =
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
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corhlllltToUnitDef (flat: Corhllllt) : UnitDef =
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
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corminibuzz =
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
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corminibuzz : Corminibuzz =
        { name = "corminibuzz"
          subfolder = "Scavengers/Buildings/DefenseOffense"
          metalCost = ValueOrExpr.Concrete 2000.0
          energyCost = ValueOrExpr.Concrete 60000.0
          buildTime = ValueOrExpr.Concrete 65000.0
          health = ValueOrExpr.Concrete 6700.0
          sightDistance = ValueOrExpr.Concrete 700.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/scavbuildings/CORMINIBUZZ.s3o"
          buildPic = Some "CORMINIBUZZ.DDS"
          script = Some "Units/scavbuildings/CORMINIBUZZ.lua"
          corpse = Some "DEAD"
          explodeAs = Some "hugeBuildingexplosiongeneric"
          selfDestructAs = Some "hugeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -6 0"
          collisionVolumeScales = Some "32 64 32"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          yardMap = "ooo ooo ooo"
          canRepeat = false
          weapons = [
                { name = "corminibuzz_weapon"
                  displayName = "Mini Rapid-fire long-range plasma cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 210.0
                      "shields", 105.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1450.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.4)
                  weaponVelocity = Some 660.0
                  areaOfEffect = Some 44.8
                  accuracy = Some 700.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.9
                  impulseFactor = Some 0.1
                  noSelfDamage = Some true
                  soundStart = Some "cannon2"
                  soundHit = Some "xplomed3"
                  explosiongenerator = Some "custom:genericshellexplosion-medium-bomb"
                  rgbColor = Some "1, 0.4, 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "MOBILE"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "avoidfriendly", "true"
                      "avoidground", "true"
                      "cegtag", "arty-heavy"
                      "collidefriendly", "false"
                      "craterboost", "0.02"
                      "cratermult", "0.02"
                      "energypershot", "1000.0"
                      "gravityaffected", "true"
                      "soundhitwet", "splshbig"
                      "weapontimer", "14.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "32 64 32"
                  collisionVolumeType = Some "Box"
                  damage = Some 3000.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 10.0
                  metal = Some 6000.0
                  object_ = Some "Units/scavbuildings/corminibuzz_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 1500.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 2.0
                  metal = Some 3000.0
                  object_ = Some "Units/cor3X3A.s3o"
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
                ok = ["servlrg4"]
                select = ["servlrg4"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "false"
                "buildinggrounddecaltype", "decals/corminibuzz_aoplane.dds"
                "buildinggrounddecalsizey", "6.0"
                "buildinggrounddecalsizex", "6.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "weapon"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "removewait", "true"
                "subfolder", "CorBuildings/LandDefenceOffence"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "buildangle", "29096.0"
            ] }

    let corminibuzzDef : UnitDef =
        { name = "corminibuzz"
          subfolder = "Scavengers/Buildings/DefenseOffense"
          metalCost = ValueOrExpr.Concrete 2000.0
          energyCost = ValueOrExpr.Concrete 60000.0
          buildTime = ValueOrExpr.Concrete 65000.0
          health = ValueOrExpr.Concrete 6700.0
          sightDistance = ValueOrExpr.Concrete 700.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/scavbuildings/CORMINIBUZZ.s3o"
          buildPic = Some "CORMINIBUZZ.DDS"
          script = Some "Units/scavbuildings/CORMINIBUZZ.lua"
          corpse = Some "DEAD"
          explodeAs = Some "hugeBuildingexplosiongeneric"
          selfDestructAs = Some "hugeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -6 0"
          collisionVolumeScales = Some "32 64 32"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "corminibuzz_weapon"
                displayName = "Mini Rapid-fire long-range plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 210.0
                    "shields", 105.0
                ]
                range = Some (ValueOrExpr.Concrete 1450.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.4)
                weaponVelocity = Some 660.0
                areaOfEffect = Some 44.8
                accuracy = Some 700.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.9
                impulseFactor = Some 0.1
                noSelfDamage = Some true
                soundStart = Some "cannon2"
                soundHit = Some "xplomed3"
                explosiongenerator = Some "custom:genericshellexplosion-medium-bomb"
                rgbColor = Some "1, 0.4, 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "avoidfriendly", "true"
                    "avoidground", "true"
                    "cegtag", "arty-heavy"
                    "collidefriendly", "false"
                    "craterboost", "0.02"
                    "cratermult", "0.02"
                    "energypershot", "1000.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splshbig"
                    "weapontimer", "14.0"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "ooo ooo ooo"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "32 64 32"
                collisionVolumeType = Some "Box"
                damage = Some 3000.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 10.0
                metal = Some 6000.0
                object_ = Some "Units/scavbuildings/corminibuzz_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 1500.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 2.0
                metal = Some 3000.0
                object_ = Some "Units/cor3X3A.s3o"
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
              ok = ["servlrg4"]
              select = ["servlrg4"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "false"
              "buildinggrounddecaltype", "decals/corminibuzz_aoplane.dds"
              "buildinggrounddecalsizey", "6.0"
              "buildinggrounddecalsizex", "6.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "weapon"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
              "subfolder", "CorBuildings/LandDefenceOffence"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "buildangle", "29096.0"
          ] }

    let corminibuzzToFlat (def: UnitDef) : Corminibuzz =
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
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corminibuzzToUnitDef (flat: Corminibuzz) : UnitDef =
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
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Cormwall =
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
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let cormwall : Cormwall =
        { name = "cormwall"
          subfolder = "Scavengers/Buildings/DefenseOffense"
          metalCost = ValueOrExpr.Concrete 1020.0
          energyCost = ValueOrExpr.Concrete 4800.0
          buildTime = ValueOrExpr.Concrete 14000.0
          health = ValueOrExpr.Concrete 5320.0
          sightDistance = ValueOrExpr.Concrete 330.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORMWALL.s3o"
          buildPic = Some "CORMWALL.DDS"
          script = Some "Units/CORMWALL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallBuildingexplosiongeneric"
          selfDestructAs = Some "tinyBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -3 0"
          collisionVolumeScales = Some "32 50 32"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          yardMap = "ffff"
          canRepeat = false
          weapons = [
                { name = "exp_heavyrocket"
                  displayName = "CatapultRockets"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "default", 450.0
                  ]
                  range = Some (ValueOrExpr.Concrete 675.0)
                  reloadTime = Some (ValueOrExpr.Concrete 15.0)
                  weaponVelocity = Some 530.0
                  areaOfEffect = Some 96.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.65
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "rapidrocket3"
                  soundHit = Some "rockhit"
                  explosiongenerator = Some "custom:genericshellexplosion-catapult"
                  rgbColor = None
                  customParams = Map.ofList [
                      "projectile_destruction_method", "descend"
                  ]
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_fastautoretargeting", "true"
                      "avoidfeature", "false"
                      "burst", "7.0"
                      "burstrate", "0.1"
                      "cegtag", "missiletrailsmall-red"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "dance", "24.0"
                      "firestarter", "70.0"
                      "flighttime", "3.2"
                      "metalpershot", "0.0"
                      "model", "catapultmissile.s3o"
                      "movingaccuracy", "600.0"
                      "proximitypriority", "-1.0"
                      "smoketrail", "true"
                      "smokePeriod", "4.0"
                      "smoketime", "16.0"
                      "smokesize", "8.5"
                      "smokecolor", "0.5"
                      "smokeTrailCastShadow", "false"
                      "soundhitwet", "splsmed"
                      "startvelocity", "165.0"
                      "texture1", "null"
                      "texture2", "smoketrailbar"
                      "trajectoryheight", "3.0"
                      "turnrate", "5000.0"
                      "weaponacceleration", "100.0"
                      "weapontimer", "6.0"
                      "wobble", "2000.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -3 0"
                  collisionVolumeScales = Some "32 50 32"
                  collisionVolumeType = Some "CylY"
                  damage = Some 540.0
                  featureDead = Some "ROCKTEETH"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 205.0
                  object_ = Some "Units/corfort.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "rockteeth",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 500.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 2.0
                  object_ = Some "Units/cor1X1A.s3o"
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
                ok = ["servmed2"]
                select = ["servmed2"] }
          customParams = Map.ofList [
                "neutral_when_closed", "true"
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/corfort_aoplane.dds"
                "buildinggrounddecalsizey", "4.0"
                "buildinggrounddecalsizex", "4.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "weapon"
                "decoyfor", "armfort"
                "model_author", "Beherith"
                "normaltex", "unittextures/cor_normal.dds"
                "removewait", "true"
                "subfolder", "CorBuildings/LandDefenceOffence"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "damagemodifier", "0.25"
                "decoyfor", "corfort"
                "hidedamage", "true"
                "levelground", "false"
                "mass", "10000000000.0"
                "nochasecategory", "MOBILE"
                "stealth", "true"
                "upright", "true"
            ] }

    let cormwallDef : UnitDef =
        { name = "cormwall"
          subfolder = "Scavengers/Buildings/DefenseOffense"
          metalCost = ValueOrExpr.Concrete 1020.0
          energyCost = ValueOrExpr.Concrete 4800.0
          buildTime = ValueOrExpr.Concrete 14000.0
          health = ValueOrExpr.Concrete 5320.0
          sightDistance = ValueOrExpr.Concrete 330.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORMWALL.s3o"
          buildPic = Some "CORMWALL.DDS"
          script = Some "Units/CORMWALL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallBuildingexplosiongeneric"
          selfDestructAs = Some "tinyBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -3 0"
          collisionVolumeScales = Some "32 50 32"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "exp_heavyrocket"
                displayName = "CatapultRockets"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 450.0
                ]
                range = Some (ValueOrExpr.Concrete 675.0)
                reloadTime = Some (ValueOrExpr.Concrete 15.0)
                weaponVelocity = Some 530.0
                areaOfEffect = Some 96.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.65
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "rapidrocket3"
                soundHit = Some "rockhit"
                explosiongenerator = Some "custom:genericshellexplosion-catapult"
                rgbColor = None
                customParams = Map.ofList [
                    "projectile_destruction_method", "descend"
                ]
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_fastautoretargeting", "true"
                    "avoidfeature", "false"
                    "burst", "7.0"
                    "burstrate", "0.1"
                    "cegtag", "missiletrailsmall-red"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "dance", "24.0"
                    "firestarter", "70.0"
                    "flighttime", "3.2"
                    "metalpershot", "0.0"
                    "model", "catapultmissile.s3o"
                    "movingaccuracy", "600.0"
                    "proximitypriority", "-1.0"
                    "smoketrail", "true"
                    "smokePeriod", "4.0"
                    "smoketime", "16.0"
                    "smokesize", "8.5"
                    "smokecolor", "0.5"
                    "smokeTrailCastShadow", "false"
                    "soundhitwet", "splsmed"
                    "startvelocity", "165.0"
                    "texture1", "null"
                    "texture2", "smoketrailbar"
                    "trajectoryheight", "3.0"
                    "turnrate", "5000.0"
                    "weaponacceleration", "100.0"
                    "weapontimer", "6.0"
                    "wobble", "2000.0"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "ffff"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -3 0"
                collisionVolumeScales = Some "32 50 32"
                collisionVolumeType = Some "CylY"
                damage = Some 540.0
                featureDead = Some "ROCKTEETH"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 205.0
                object_ = Some "Units/corfort.s3o"
                reclaimable = Some true
                resurrectable = None }
              "rockteeth",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 500.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 2.0
                object_ = Some "Units/cor1X1A.s3o"
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
              ok = ["servmed2"]
              select = ["servmed2"] })
          customParams = Map.ofList [
              "neutral_when_closed", "true"
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/corfort_aoplane.dds"
              "buildinggrounddecalsizey", "4.0"
              "buildinggrounddecalsizex", "4.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "weapon"
              "decoyfor", "armfort"
              "model_author", "Beherith"
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
              "subfolder", "CorBuildings/LandDefenceOffence"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "damagemodifier", "0.25"
              "decoyfor", "corfort"
              "hidedamage", "true"
              "levelground", "false"
              "mass", "10000000000.0"
              "nochasecategory", "MOBILE"
              "stealth", "true"
              "upright", "true"
          ] }

    let cormwallToFlat (def: UnitDef) : Cormwall =
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
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let cormwallToUnitDef (flat: Cormwall) : UnitDef =
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
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corscavdrag =
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
          featureDefs: Map<string, FeatureDef>
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corscavdrag : Corscavdrag =
        { name = "corscavdrag"
          subfolder = "Scavengers/Buildings/DefenseOffense"
          metalCost = ValueOrExpr.Concrete 8.0
          energyCost = ValueOrExpr.Concrete 0.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 2800.0
          sightDistance = ValueOrExpr.Concrete 1.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "scavs/scavdrag.s3o"
          buildPic = Some "scavengers/CORSCAVDRAG.DDS"
          script = Some "Units/cordrag.cob"
          corpse = Some "ROCKTEETH"
          explodeAs = Some "WallExplosionConcrete"
          selfDestructAs = Some "WallExplosionConcrete"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "32 22 32"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          yardMap = "ffff"
          canRepeat = false
          featureDefs = Map.ofList [
                "rockteeth",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 500.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 2.0
                  object_ = Some "Units/cor1X1A.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          customParams = Map.ofList [
                "usebuildinggrounddecal", "false"
                "buildinggrounddecaltype", "decals/scavdtf_aoplane.dds"
                "buildinggrounddecalsizey", "4.0"
                "buildinggrounddecalsizex", "4.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "objectify", "true"
                "paralyzemultiplier", "0.0"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/LandUtil"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "canattack", "false"
                "crushresistance", "250.0"
                "hidedamage", "true"
                "levelground", "false"
                "repairable", "false"
                "selfdestructcountdown", "1.0"
            ] }

    let corscavdragDef : UnitDef =
        { name = "corscavdrag"
          subfolder = "Scavengers/Buildings/DefenseOffense"
          metalCost = ValueOrExpr.Concrete 8.0
          energyCost = ValueOrExpr.Concrete 0.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 2800.0
          sightDistance = ValueOrExpr.Concrete 1.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "scavs/scavdrag.s3o"
          buildPic = Some "scavengers/CORSCAVDRAG.DDS"
          script = Some "Units/cordrag.cob"
          corpse = Some "ROCKTEETH"
          explodeAs = Some "WallExplosionConcrete"
          selfDestructAs = Some "WallExplosionConcrete"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "32 22 32"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "ffff"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "rockteeth",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 500.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 2.0
                object_ = Some "Units/cor1X1A.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = None
          customParams = Map.ofList [
              "usebuildinggrounddecal", "false"
              "buildinggrounddecaltype", "decals/scavdtf_aoplane.dds"
              "buildinggrounddecalsizey", "4.0"
              "buildinggrounddecalsizex", "4.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "objectify", "true"
              "paralyzemultiplier", "0.0"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "CorBuildings/LandUtil"
          ]
          extras = Map.ofList [
              "blocking", "true"
              "canattack", "false"
              "crushresistance", "250.0"
              "hidedamage", "true"
              "levelground", "false"
              "repairable", "false"
              "selfdestructcountdown", "1.0"
          ] }

    let corscavdragToFlat (def: UnitDef) : Corscavdrag =
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
          featureDefs = def.featureDefs.Value
          customParams = def.customParams
          extras = def.extras }

    let corscavdragToUnitDef (flat: Corscavdrag) : UnitDef =
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
          featureDefs = Some flat.featureDefs
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Corscavdtf =
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
          canRepeat: bool
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corscavdtf : Corscavdtf =
        { name = "corscavdtf"
          subfolder = "Scavengers/Buildings/DefenseOffense"
          metalCost = ValueOrExpr.Concrete 290.0
          energyCost = ValueOrExpr.Concrete 1550.0
          buildTime = ValueOrExpr.Concrete 4400.0
          health = ValueOrExpr.Concrete 1610.0
          sightDistance = ValueOrExpr.Concrete 422.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "scavs/SCAVDTF.s3o"
          buildPic = Some "CORSCAVDTF.DDS"
          script = Some "units/scavbuildings/SCAVDTF.cob"
          corpse = Some "DEAD"
          explodeAs = Some "flamethrower"
          selfDestructAs = Some "flamethrowerSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          energyStorage = 15.0
          yardMap = "ffff"
          canRepeat = false
          weapons = [
                { name = "dmaw"
                  displayName = "Pop-up anti-swarm AoE flamethrower"
                  weaponType = Some "Flame"
                  damage = Map.ofList [
                      "commanders", 12.0
                      "default", 16.0
                      "subs", 5.0
                  ]
                  range = Some (ValueOrExpr.Concrete 410.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.1)
                  weaponVelocity = Some 300.0
                  areaOfEffect = Some 64.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 2500.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "Flamhvy1"
                  soundHit = None
                  explosiongenerator = Some "custom:burnblack"
                  rgbColor = Some "1 0.94 0.88"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "burst", "22.0"
                      "burstrate", "0.03333"
                      "cegtag", "burnflame"
                      "colormap", "1 0.95 0.82 0.03   0.7 0.4 0.25 0.027   0.44 0.25 0.15 0.024   0.033 0.018 0.011 0.02   0.0 0.0 0.0 0.01"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "100.0"
                      "flamegfxtime", "1.0"
                      "intensity", "0.75"
                      "proximitypriority", "1.0"
                      "rgbcolor2", "0.9 0.84 0.8"
                      "sizegrowth", "0.7"
                      "soundhitdry", "flamhit1"
                      "soundhitwet", "sizzle"
                      "soundhitvolume", "7.5"
                      "soundstartvolume", "5.3"
                      "soundtrigger", "false"
                      "sprayangle", "100.0"
                      "targetmoveerror", "0.001"
                      "weapontimer", "1.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 0.0149960864258 0.116882324219"
                  collisionVolumeScales = Some "32.042388916 19.5953521729 32.6287231445"
                  collisionVolumeType = Some "Box"
                  damage = Some 600.0
                  featureDead = Some "ROCKTEETH"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 177.0
                  object_ = Some "scavs/scavdrag.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "rockteeth",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 500.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 2.0
                  object_ = Some "Units/cor1X1B.s3o"
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
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["servmed2"]
                select = ["servmed2"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "false"
                "buildinggrounddecaltype", "decals/scavdtf_aoplane.dds"
                "buildinggrounddecalsizey", "4.0"
                "buildinggrounddecalsizex", "4.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "weapon"
                "decoyfor", "corscavdrag"
                "model_author", "FireStorm"
                "normaltex", "unittextures/cor_normal.dds"
                "removewait", "true"
            ]
          extras = Map.ofList [
                "buildangle", "8192.0"
                "damagemodifier", "0.25"
                "decoyfor", "scavdrag"
                "hidedamage", "true"
                "levelground", "false"
                "mass", "10000000000.0"
                "nochasecategory", "MOBILE"
                "radardistancejam", "8.0"
                "stealth", "true"
                "upright", "true"
            ] }

    let corscavdtfDef : UnitDef =
        { name = "corscavdtf"
          subfolder = "Scavengers/Buildings/DefenseOffense"
          metalCost = ValueOrExpr.Concrete 290.0
          energyCost = ValueOrExpr.Concrete 1550.0
          buildTime = ValueOrExpr.Concrete 4400.0
          health = ValueOrExpr.Concrete 1610.0
          sightDistance = ValueOrExpr.Concrete 422.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "scavs/SCAVDTF.s3o"
          buildPic = Some "CORSCAVDTF.DDS"
          script = Some "units/scavbuildings/SCAVDTF.cob"
          corpse = Some "DEAD"
          explodeAs = Some "flamethrower"
          selfDestructAs = Some "flamethrowerSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "dmaw"
                displayName = "Pop-up anti-swarm AoE flamethrower"
                weaponType = Some "Flame"
                damage = Map.ofList [
                    "commanders", 12.0
                    "default", 16.0
                    "subs", 5.0
                ]
                range = Some (ValueOrExpr.Concrete 410.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.1)
                weaponVelocity = Some 300.0
                areaOfEffect = Some 64.0
                accuracy = None
                turret = Some true
                tolerance = Some 2500.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "Flamhvy1"
                soundHit = None
                explosiongenerator = Some "custom:burnblack"
                rgbColor = Some "1 0.94 0.88"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "burst", "22.0"
                    "burstrate", "0.03333"
                    "cegtag", "burnflame"
                    "colormap", "1 0.95 0.82 0.03   0.7 0.4 0.25 0.027   0.44 0.25 0.15 0.024   0.033 0.018 0.011 0.02   0.0 0.0 0.0 0.01"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "100.0"
                    "flamegfxtime", "1.0"
                    "intensity", "0.75"
                    "proximitypriority", "1.0"
                    "rgbcolor2", "0.9 0.84 0.8"
                    "sizegrowth", "0.7"
                    "soundhitdry", "flamhit1"
                    "soundhitwet", "sizzle"
                    "soundhitvolume", "7.5"
                    "soundstartvolume", "5.3"
                    "soundtrigger", "false"
                    "sprayangle", "100.0"
                    "targetmoveerror", "0.001"
                    "weapontimer", "1.0"
                ] }
          ]
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 15.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "ffff"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0 0.0149960864258 0.116882324219"
                collisionVolumeScales = Some "32.042388916 19.5953521729 32.6287231445"
                collisionVolumeType = Some "Box"
                damage = Some 600.0
                featureDead = Some "ROCKTEETH"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 177.0
                object_ = Some "scavs/scavdrag.s3o"
                reclaimable = Some true
                resurrectable = None }
              "rockteeth",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 500.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 2.0
                object_ = Some "Units/cor1X1B.s3o"
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
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["servmed2"]
              select = ["servmed2"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "false"
              "buildinggrounddecaltype", "decals/scavdtf_aoplane.dds"
              "buildinggrounddecalsizey", "4.0"
              "buildinggrounddecalsizex", "4.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "weapon"
              "decoyfor", "corscavdrag"
              "model_author", "FireStorm"
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
              "damagemodifier", "0.25"
              "decoyfor", "scavdrag"
              "hidedamage", "true"
              "levelground", "false"
              "mass", "10000000000.0"
              "nochasecategory", "MOBILE"
              "radardistancejam", "8.0"
              "stealth", "true"
              "upright", "true"
          ] }

    let corscavdtfToFlat (def: UnitDef) : Corscavdtf =
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
          canRepeat = def.building.Value.canRepeat.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corscavdtfToUnitDef (flat: Corscavdtf) : UnitDef =
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
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = None
              canRepeat = Some flat.canRepeat
            }
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corscavdtl =
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
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corscavdtl : Corscavdtl =
        { name = "corscavdtl"
          subfolder = "Scavengers/Buildings/DefenseOffense"
          metalCost = ValueOrExpr.Concrete 340.0
          energyCost = ValueOrExpr.Concrete 1600.0
          buildTime = ValueOrExpr.Concrete 4600.0
          health = ValueOrExpr.Concrete 1330.0
          sightDistance = ValueOrExpr.Concrete 440.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "scavs/SCAVDTL.s3o"
          buildPic = Some "CORSCAVDTL.DDS"
          script = Some "units/scavbuildings/SCAVDTL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallBuildingexplosiongeneric"
          selfDestructAs = Some "tinyBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -24 0"
          collisionVolumeScales = Some "30 51 30"
          collisionVolumeType = Some "Ell"
          seismicSignature = Some 0.0
          category = None
          yardMap = "ffff"
          canRepeat = false
          weapons = [
                { name = "dclaw"
                  displayName = "Close-quarters g2g lightning turret"
                  weaponType = Some "LightningCannon"
                  damage = Map.ofList [
                      "commanders", 39.0
                      "default", 21.0
                      "vtol", 2.5
                  ]
                  range = Some (ValueOrExpr.Concrete 440.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.13333)
                  weaponVelocity = Some 450.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lghthvy1"
                  soundHit = Some "lashit"
                  explosiongenerator = Some "custom:genericshellexplosion-medium-lightning2"
                  rgbColor = Some "0.5 0.5 1"
                  customParams = Map.ofList [
                      "spark_ceg", "genericshellexplosion-splash-lightning"
                      "spark_forkdamage", "0.33"
                      "spark_maxunits", "2"
                      "spark_range", "60"
                  ]
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "beamttl", "1.0"
                      "burst", "10.0"
                      "burstrate", "0.03333"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "1.0"
                      "firestarter", "50.0"
                      "impactonly", "1.0"
                      "intensity", "24.0"
                      "soundhitwet", "sizzle"
                      "soundtrigger", "true"
                      "thickness", "1.5"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 2.37060546837e-06 -0.0625"
                  collisionVolumeScales = Some "32.0 17.7499847412 31.375"
                  collisionVolumeType = Some "Box"
                  damage = Some 540.0
                  featureDead = Some "ROCKTEETH"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 205.0
                  object_ = Some "scavs/scavdrag.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "rockteeth",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 500.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 2.0
                  object_ = Some "Units/cor1X1A.s3o"
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
                ok = ["servmed2"]
                select = ["servmed2"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "false"
                "buildinggrounddecaltype", "decals/scavdtf_aoplane.dds"
                "buildinggrounddecalsizey", "4.0"
                "buildinggrounddecalsizex", "4.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "weapon"
                "decoyfor", "corscavdrag"
                "model_author", "FireStorm"
                "normaltex", "unittextures/cor_normal.dds"
                "removewait", "true"
            ]
          extras = Map.ofList [
                "buildangle", "8192.0"
                "damagemodifier", "0.25"
                "decoyfor", "scavdrag"
                "hidedamage", "true"
                "levelground", "false"
                "mass", "10000000000.0"
                "nochasecategory", "MOBILE"
                "radardistancejam", "8.0"
                "stealth", "true"
                "upright", "true"
            ] }

    let corscavdtlDef : UnitDef =
        { name = "corscavdtl"
          subfolder = "Scavengers/Buildings/DefenseOffense"
          metalCost = ValueOrExpr.Concrete 340.0
          energyCost = ValueOrExpr.Concrete 1600.0
          buildTime = ValueOrExpr.Concrete 4600.0
          health = ValueOrExpr.Concrete 1330.0
          sightDistance = ValueOrExpr.Concrete 440.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "scavs/SCAVDTL.s3o"
          buildPic = Some "CORSCAVDTL.DDS"
          script = Some "units/scavbuildings/SCAVDTL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallBuildingexplosiongeneric"
          selfDestructAs = Some "tinyBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -24 0"
          collisionVolumeScales = Some "30 51 30"
          collisionVolumeType = Some "Ell"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "dclaw"
                displayName = "Close-quarters g2g lightning turret"
                weaponType = Some "LightningCannon"
                damage = Map.ofList [
                    "commanders", 39.0
                    "default", 21.0
                    "vtol", 2.5
                ]
                range = Some (ValueOrExpr.Concrete 440.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.13333)
                weaponVelocity = Some 450.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lghthvy1"
                soundHit = Some "lashit"
                explosiongenerator = Some "custom:genericshellexplosion-medium-lightning2"
                rgbColor = Some "0.5 0.5 1"
                customParams = Map.ofList [
                    "spark_ceg", "genericshellexplosion-splash-lightning"
                    "spark_forkdamage", "0.33"
                    "spark_maxunits", "2"
                    "spark_range", "60"
                ]
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "beamttl", "1.0"
                    "burst", "10.0"
                    "burstrate", "0.03333"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "1.0"
                    "firestarter", "50.0"
                    "impactonly", "1.0"
                    "intensity", "24.0"
                    "soundhitwet", "sizzle"
                    "soundtrigger", "true"
                    "thickness", "1.5"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "ffff"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0 2.37060546837e-06 -0.0625"
                collisionVolumeScales = Some "32.0 17.7499847412 31.375"
                collisionVolumeType = Some "Box"
                damage = Some 540.0
                featureDead = Some "ROCKTEETH"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 205.0
                object_ = Some "scavs/scavdrag.s3o"
                reclaimable = Some true
                resurrectable = None }
              "rockteeth",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 500.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 2.0
                object_ = Some "Units/cor1X1A.s3o"
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
              ok = ["servmed2"]
              select = ["servmed2"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "false"
              "buildinggrounddecaltype", "decals/scavdtf_aoplane.dds"
              "buildinggrounddecalsizey", "4.0"
              "buildinggrounddecalsizex", "4.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "weapon"
              "decoyfor", "corscavdrag"
              "model_author", "FireStorm"
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
              "damagemodifier", "0.25"
              "decoyfor", "scavdrag"
              "hidedamage", "true"
              "levelground", "false"
              "mass", "10000000000.0"
              "nochasecategory", "MOBILE"
              "radardistancejam", "8.0"
              "stealth", "true"
              "upright", "true"
          ] }

    let corscavdtlToFlat (def: UnitDef) : Corscavdtl =
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
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corscavdtlToUnitDef (flat: Corscavdtl) : UnitDef =
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
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corscavdtm =
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
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corscavdtm : Corscavdtm =
        { name = "corscavdtm"
          subfolder = "Scavengers/Buildings/DefenseOffense"
          metalCost = ValueOrExpr.Concrete 290.0
          energyCost = ValueOrExpr.Concrete 1550.0
          buildTime = ValueOrExpr.Concrete 4400.0
          health = ValueOrExpr.Concrete 1610.0
          sightDistance = ValueOrExpr.Concrete 422.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "scavs/SCAVDTM.s3o"
          buildPic = Some "CORSCAVDTM.DDS"
          script = Some "units/scavbuildings/SCAVDTM.cob"
          corpse = Some "DEAD"
          explodeAs = Some "flamethrower"
          selfDestructAs = Some "flamethrowerSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          yardMap = "ffff"
          canRepeat = false
          weapons = [
                { name = "cormh_weapon"
                  displayName = "Rocket"
                  weaponType = Some "StarburstLauncher"
                  damage = Map.ofList [
                      "default", 550.0
                      "subs", 200.0
                  ]
                  range = Some (ValueOrExpr.Concrete 500.0)
                  reloadTime = Some (ValueOrExpr.Concrete 5.0)
                  weaponVelocity = Some 480.0
                  areaOfEffect = Some 80.0
                  accuracy = None
                  turret = None
                  tolerance = Some 4000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "Rockhvy1"
                  soundHit = Some "xplomed4"
                  explosiongenerator = Some "custom:genericshellexplosion-medium-bomb"
                  rgbColor = None
                  customParams = Map.ofList [
                      "projectile_destruction_method", "descend"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "MOBILE"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "cegtag", "missiletrailsmall-starburst"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "100.0"
                      "firesubmersed", "true"
                      "flighttime", "10.0"
                      "metalpershot", "0.0"
                      "model", "corkbmissl1.s3o"
                      "smoketrail", "false"
                      "soundhitwet", "splssml"
                      "texture1", "null"
                      "texture2", "null"
                      "texture3", "null"
                      "turnrate", "15000.0"
                      "weaponacceleration", "70.0"
                      "weapontimer", "2.9"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 0.0149960864258 0.116882324219"
                  collisionVolumeScales = Some "32.042388916 19.5953521729 32.6287231445"
                  collisionVolumeType = Some "Box"
                  damage = Some 600.0
                  featureDead = Some "ROCKTEETH"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 177.0
                  object_ = Some "scavs/scavdrag.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "rockteeth",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 500.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 2.0
                  object_ = Some "Units/cor1X1A.s3o"
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
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["servmed2"]
                select = ["servmed2"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "false"
                "buildinggrounddecaltype", "decals/scavdtf_aoplane.dds"
                "buildinggrounddecalsizey", "4.0"
                "buildinggrounddecalsizex", "4.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "weapon"
                "decoyfor", "corscavdrag"
                "model_author", "FireStorm"
                "normaltex", "unittextures/cor_normal.dds"
                "removewait", "true"
            ]
          extras = Map.ofList [
                "buildangle", "8192.0"
                "damagemodifier", "0.25"
                "decoyfor", "scavdrag"
                "hidedamage", "true"
                "levelground", "false"
                "mass", "10000000000.0"
                "nochasecategory", "MOBILE"
                "radardistancejam", "8.0"
                "stealth", "true"
                "upright", "true"
            ] }

    let corscavdtmDef : UnitDef =
        { name = "corscavdtm"
          subfolder = "Scavengers/Buildings/DefenseOffense"
          metalCost = ValueOrExpr.Concrete 290.0
          energyCost = ValueOrExpr.Concrete 1550.0
          buildTime = ValueOrExpr.Concrete 4400.0
          health = ValueOrExpr.Concrete 1610.0
          sightDistance = ValueOrExpr.Concrete 422.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "scavs/SCAVDTM.s3o"
          buildPic = Some "CORSCAVDTM.DDS"
          script = Some "units/scavbuildings/SCAVDTM.cob"
          corpse = Some "DEAD"
          explodeAs = Some "flamethrower"
          selfDestructAs = Some "flamethrowerSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "cormh_weapon"
                displayName = "Rocket"
                weaponType = Some "StarburstLauncher"
                damage = Map.ofList [
                    "default", 550.0
                    "subs", 200.0
                ]
                range = Some (ValueOrExpr.Concrete 500.0)
                reloadTime = Some (ValueOrExpr.Concrete 5.0)
                weaponVelocity = Some 480.0
                areaOfEffect = Some 80.0
                accuracy = None
                turret = None
                tolerance = Some 4000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "Rockhvy1"
                soundHit = Some "xplomed4"
                explosiongenerator = Some "custom:genericshellexplosion-medium-bomb"
                rgbColor = None
                customParams = Map.ofList [
                    "projectile_destruction_method", "descend"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "cegtag", "missiletrailsmall-starburst"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "100.0"
                    "firesubmersed", "true"
                    "flighttime", "10.0"
                    "metalpershot", "0.0"
                    "model", "corkbmissl1.s3o"
                    "smoketrail", "false"
                    "soundhitwet", "splssml"
                    "texture1", "null"
                    "texture2", "null"
                    "texture3", "null"
                    "turnrate", "15000.0"
                    "weaponacceleration", "70.0"
                    "weapontimer", "2.9"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "ffff"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0 0.0149960864258 0.116882324219"
                collisionVolumeScales = Some "32.042388916 19.5953521729 32.6287231445"
                collisionVolumeType = Some "Box"
                damage = Some 600.0
                featureDead = Some "ROCKTEETH"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 177.0
                object_ = Some "scavs/scavdrag.s3o"
                reclaimable = Some true
                resurrectable = None }
              "rockteeth",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 500.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 2.0
                object_ = Some "Units/cor1X1A.s3o"
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
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["servmed2"]
              select = ["servmed2"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "false"
              "buildinggrounddecaltype", "decals/scavdtf_aoplane.dds"
              "buildinggrounddecalsizey", "4.0"
              "buildinggrounddecalsizex", "4.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "weapon"
              "decoyfor", "corscavdrag"
              "model_author", "FireStorm"
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
              "damagemodifier", "0.25"
              "decoyfor", "scavdrag"
              "hidedamage", "true"
              "levelground", "false"
              "mass", "10000000000.0"
              "nochasecategory", "MOBILE"
              "radardistancejam", "8.0"
              "stealth", "true"
              "upright", "true"
          ] }

    let corscavdtmToFlat (def: UnitDef) : Corscavdtm =
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
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corscavdtmToUnitDef (flat: Corscavdtm) : UnitDef =
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
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corscavfort =
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
          featureDefs: Map<string, FeatureDef>
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corscavfort : Corscavfort =
        { name = "corscavfort"
          subfolder = "Scavengers/Buildings/DefenseOffense"
          metalCost = ValueOrExpr.Concrete 40.0
          energyCost = ValueOrExpr.Concrete 500.0
          buildTime = ValueOrExpr.Concrete 1000.0
          health = ValueOrExpr.Concrete 8900.0
          sightDistance = ValueOrExpr.Concrete 1.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "scavs/SCAVFORT.s3o"
          buildPic = Some "scavengers/SCAVFORT.DDS"
          script = Some "scavs/SCAVFORT.cob"
          corpse = Some "ROCKTEETHX"
          explodeAs = Some "WallExplosionConcreteXL"
          selfDestructAs = Some "WallExplosionConcrete"
          collisionVolumeOffsets = Some "0 -3 0"
          collisionVolumeScales = Some "32 50 32"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          yardMap = "ffff"
          canRepeat = false
          featureDefs = Map.ofList [
                "rockteethx",
                { blocking = Some true
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 3000.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 7.0
                  object_ = Some "Units/cor1X1A.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          customParams = Map.ofList [
                "usebuildinggrounddecal", "false"
                "buildinggrounddecaltype", "decals/corscavfort_aoplane.dds"
                "buildinggrounddecalsizey", "4.0"
                "buildinggrounddecalsizex", "4.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "model_author", "FireStorm"
                "normaltex", "unittextures/cor_normal.dds"
                "objectify", "true"
                "paralyzemultiplier", "0.0"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "other/scavengers"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "buildangle", "0.0"
                "canattack", "false"
                "crushresistance", "1000.0"
                "hidedamage", "true"
                "levelground", "false"
                "repairable", "false"
                "selfdestructcountdown", "1.0"
            ] }

    let corscavfortDef : UnitDef =
        { name = "corscavfort"
          subfolder = "Scavengers/Buildings/DefenseOffense"
          metalCost = ValueOrExpr.Concrete 40.0
          energyCost = ValueOrExpr.Concrete 500.0
          buildTime = ValueOrExpr.Concrete 1000.0
          health = ValueOrExpr.Concrete 8900.0
          sightDistance = ValueOrExpr.Concrete 1.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "scavs/SCAVFORT.s3o"
          buildPic = Some "scavengers/SCAVFORT.DDS"
          script = Some "scavs/SCAVFORT.cob"
          corpse = Some "ROCKTEETHX"
          explodeAs = Some "WallExplosionConcreteXL"
          selfDestructAs = Some "WallExplosionConcrete"
          collisionVolumeOffsets = Some "0 -3 0"
          collisionVolumeScales = Some "32 50 32"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "ffff"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "rockteethx",
              { blocking = Some true
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 3000.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 7.0
                object_ = Some "Units/cor1X1A.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = None
          customParams = Map.ofList [
              "usebuildinggrounddecal", "false"
              "buildinggrounddecaltype", "decals/corscavfort_aoplane.dds"
              "buildinggrounddecalsizey", "4.0"
              "buildinggrounddecalsizex", "4.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "model_author", "FireStorm"
              "normaltex", "unittextures/cor_normal.dds"
              "objectify", "true"
              "paralyzemultiplier", "0.0"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "other/scavengers"
          ]
          extras = Map.ofList [
              "blocking", "true"
              "buildangle", "0.0"
              "canattack", "false"
              "crushresistance", "1000.0"
              "hidedamage", "true"
              "levelground", "false"
              "repairable", "false"
              "selfdestructcountdown", "1.0"
          ] }

    let corscavfortToFlat (def: UnitDef) : Corscavfort =
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
          featureDefs = def.featureDefs.Value
          customParams = def.customParams
          extras = def.extras }

    let corscavfortToUnitDef (flat: Corscavfort) : UnitDef =
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
          featureDefs = Some flat.featureDefs
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Legdtf =
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
          canRepeat: bool
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legdtf : Legdtf =
        { name = "legdtf"
          subfolder = "Scavengers/Buildings/DefenseOffense"
          metalCost = ValueOrExpr.Concrete 290.0
          energyCost = ValueOrExpr.Concrete 1550.0
          buildTime = ValueOrExpr.Concrete 4400.0
          health = ValueOrExpr.Concrete 1610.0
          sightDistance = ValueOrExpr.Concrete 422.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "scavs/SCAVDTF.s3o"
          buildPic = Some "CORSCAVDTF.DDS"
          script = Some "units/scavbuildings/SCAVDTF.cob"
          corpse = Some "DEAD"
          explodeAs = Some "flamethrower"
          selfDestructAs = Some "flamethrowerSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          energyStorage = 15.0
          yardMap = "ffff"
          canRepeat = false
          weapons = [
                { name = "dmaw"
                  displayName = "Pop-up anti-swarm AoE flamethrower"
                  weaponType = Some "Flame"
                  damage = Map.ofList [
                      "commanders", 12.0
                      "default", 16.0
                      "subs", 5.0
                  ]
                  range = Some (ValueOrExpr.Concrete 410.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.1)
                  weaponVelocity = Some 300.0
                  areaOfEffect = Some 64.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 2500.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "Flamhvy1"
                  soundHit = None
                  explosiongenerator = Some "custom:burnblack"
                  rgbColor = Some "1 0.94 0.88"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "burst", "22.0"
                      "burstrate", "0.03333"
                      "cegtag", "burnflame"
                      "colormap", "1 0.95 0.82 0.03   0.7 0.4 0.25 0.027   0.44 0.25 0.15 0.024   0.033 0.018 0.011 0.02   0.0 0.0 0.0 0.01"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "100.0"
                      "flamegfxtime", "1.0"
                      "intensity", "0.75"
                      "proximitypriority", "1.0"
                      "rgbcolor2", "0.9 0.84 0.8"
                      "sizegrowth", "0.7"
                      "soundhitdry", "flamhit1"
                      "soundhitwet", "sizzle"
                      "soundhitvolume", "7.5"
                      "soundstartvolume", "5.3"
                      "soundtrigger", "false"
                      "sprayangle", "100.0"
                      "targetmoveerror", "0.001"
                      "weapontimer", "1.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 0.0149960864258 0.116882324219"
                  collisionVolumeScales = Some "32.042388916 19.5953521729 32.6287231445"
                  collisionVolumeType = Some "Box"
                  damage = Some 600.0
                  featureDead = Some "ROCKTEETH"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 177.0
                  object_ = Some "scavs/scavdrag.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "rockteeth",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 500.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 2.0
                  object_ = Some "Units/cor1X1B.s3o"
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
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["servmed2"]
                select = ["servmed2"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "false"
                "buildinggrounddecaltype", "decals/scavdtf_aoplane.dds"
                "buildinggrounddecalsizey", "4.0"
                "buildinggrounddecalsizex", "4.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "weapon"
                "decoyfor", "corscavdrag"
                "model_author", "FireStorm"
                "normaltex", "unittextures/cor_normal.dds"
                "removewait", "true"
            ]
          extras = Map.ofList [
                "buildangle", "8192.0"
                "damagemodifier", "0.33"
                "decoyfor", "scavdrag"
                "hidedamage", "true"
                "levelground", "false"
                "mass", "10000000000.0"
                "nochasecategory", "MOBILE"
                "radardistancejam", "8.0"
                "stealth", "true"
                "upright", "true"
            ] }

    let legdtfDef : UnitDef =
        { name = "legdtf"
          subfolder = "Scavengers/Buildings/DefenseOffense"
          metalCost = ValueOrExpr.Concrete 290.0
          energyCost = ValueOrExpr.Concrete 1550.0
          buildTime = ValueOrExpr.Concrete 4400.0
          health = ValueOrExpr.Concrete 1610.0
          sightDistance = ValueOrExpr.Concrete 422.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "scavs/SCAVDTF.s3o"
          buildPic = Some "CORSCAVDTF.DDS"
          script = Some "units/scavbuildings/SCAVDTF.cob"
          corpse = Some "DEAD"
          explodeAs = Some "flamethrower"
          selfDestructAs = Some "flamethrowerSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "dmaw"
                displayName = "Pop-up anti-swarm AoE flamethrower"
                weaponType = Some "Flame"
                damage = Map.ofList [
                    "commanders", 12.0
                    "default", 16.0
                    "subs", 5.0
                ]
                range = Some (ValueOrExpr.Concrete 410.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.1)
                weaponVelocity = Some 300.0
                areaOfEffect = Some 64.0
                accuracy = None
                turret = Some true
                tolerance = Some 2500.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "Flamhvy1"
                soundHit = None
                explosiongenerator = Some "custom:burnblack"
                rgbColor = Some "1 0.94 0.88"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "burst", "22.0"
                    "burstrate", "0.03333"
                    "cegtag", "burnflame"
                    "colormap", "1 0.95 0.82 0.03   0.7 0.4 0.25 0.027   0.44 0.25 0.15 0.024   0.033 0.018 0.011 0.02   0.0 0.0 0.0 0.01"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "100.0"
                    "flamegfxtime", "1.0"
                    "intensity", "0.75"
                    "proximitypriority", "1.0"
                    "rgbcolor2", "0.9 0.84 0.8"
                    "sizegrowth", "0.7"
                    "soundhitdry", "flamhit1"
                    "soundhitwet", "sizzle"
                    "soundhitvolume", "7.5"
                    "soundstartvolume", "5.3"
                    "soundtrigger", "false"
                    "sprayangle", "100.0"
                    "targetmoveerror", "0.001"
                    "weapontimer", "1.0"
                ] }
          ]
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 15.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "ffff"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0 0.0149960864258 0.116882324219"
                collisionVolumeScales = Some "32.042388916 19.5953521729 32.6287231445"
                collisionVolumeType = Some "Box"
                damage = Some 600.0
                featureDead = Some "ROCKTEETH"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 177.0
                object_ = Some "scavs/scavdrag.s3o"
                reclaimable = Some true
                resurrectable = None }
              "rockteeth",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 500.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 2.0
                object_ = Some "Units/cor1X1B.s3o"
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
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["servmed2"]
              select = ["servmed2"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "false"
              "buildinggrounddecaltype", "decals/scavdtf_aoplane.dds"
              "buildinggrounddecalsizey", "4.0"
              "buildinggrounddecalsizex", "4.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "weapon"
              "decoyfor", "corscavdrag"
              "model_author", "FireStorm"
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
              "damagemodifier", "0.33"
              "decoyfor", "scavdrag"
              "hidedamage", "true"
              "levelground", "false"
              "mass", "10000000000.0"
              "nochasecategory", "MOBILE"
              "radardistancejam", "8.0"
              "stealth", "true"
              "upright", "true"
          ] }

    let legdtfToFlat (def: UnitDef) : Legdtf =
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
          canRepeat = def.building.Value.canRepeat.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let legdtfToUnitDef (flat: Legdtf) : UnitDef =
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
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = None
              canRepeat = Some flat.canRepeat
            }
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Legdtl =
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
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legdtl : Legdtl =
        { name = "legdtl"
          subfolder = "Scavengers/Buildings/DefenseOffense"
          metalCost = ValueOrExpr.Concrete 340.0
          energyCost = ValueOrExpr.Concrete 1600.0
          buildTime = ValueOrExpr.Concrete 4600.0
          health = ValueOrExpr.Concrete 1330.0
          sightDistance = ValueOrExpr.Concrete 440.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "scavs/SCAVDTL.s3o"
          buildPic = Some "CORSCAVDTL.DDS"
          script = Some "units/scavbuildings/SCAVDTL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallBuildingexplosiongeneric"
          selfDestructAs = Some "tinyBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -24 0"
          collisionVolumeScales = Some "30 51 30"
          collisionVolumeType = Some "Ell"
          seismicSignature = Some 0.0
          category = None
          yardMap = "ffff"
          canRepeat = false
          weapons = [
                { name = "dclaw"
                  displayName = "Close-quarters g2g lightning turret"
                  weaponType = Some "LightningCannon"
                  damage = Map.ofList [
                      "commanders", 39.0
                      "default", 21.0
                      "vtol", 2.5
                  ]
                  range = Some (ValueOrExpr.Concrete 440.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.13333)
                  weaponVelocity = Some 450.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lghthvy1"
                  soundHit = Some "lashit"
                  explosiongenerator = Some "custom:genericshellexplosion-medium-lightning2"
                  rgbColor = Some "0.5 0.5 1"
                  customParams = Map.ofList [
                      "spark_ceg", "genericshellexplosion-splash-lightning"
                      "spark_forkdamage", "0.33"
                      "spark_maxunits", "2"
                      "spark_range", "60"
                  ]
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "beamttl", "1.0"
                      "burst", "10.0"
                      "burstrate", "0.03333"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "1.0"
                      "firestarter", "50.0"
                      "impactonly", "1.0"
                      "intensity", "24.0"
                      "soundhitwet", "sizzle"
                      "soundtrigger", "true"
                      "thickness", "1.5"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 2.37060546837e-06 -0.0625"
                  collisionVolumeScales = Some "32.0 17.7499847412 31.375"
                  collisionVolumeType = Some "Box"
                  damage = Some 540.0
                  featureDead = Some "ROCKTEETH"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 205.0
                  object_ = Some "scavs/scavdrag.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "rockteeth",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 500.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 2.0
                  object_ = Some "Units/cor1X1A.s3o"
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
                ok = ["servmed2"]
                select = ["servmed2"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "false"
                "buildinggrounddecaltype", "decals/scavdtf_aoplane.dds"
                "buildinggrounddecalsizey", "4.0"
                "buildinggrounddecalsizex", "4.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "weapon"
                "decoyfor", "corscavdrag"
                "model_author", "FireStorm"
                "normaltex", "unittextures/cor_normal.dds"
                "removewait", "true"
            ]
          extras = Map.ofList [
                "buildangle", "8192.0"
                "damagemodifier", "0.33"
                "decoyfor", "scavdrag"
                "hidedamage", "true"
                "levelground", "false"
                "mass", "10000000000.0"
                "nochasecategory", "MOBILE"
                "radardistancejam", "8.0"
                "stealth", "true"
                "upright", "true"
            ] }

    let legdtlDef : UnitDef =
        { name = "legdtl"
          subfolder = "Scavengers/Buildings/DefenseOffense"
          metalCost = ValueOrExpr.Concrete 340.0
          energyCost = ValueOrExpr.Concrete 1600.0
          buildTime = ValueOrExpr.Concrete 4600.0
          health = ValueOrExpr.Concrete 1330.0
          sightDistance = ValueOrExpr.Concrete 440.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "scavs/SCAVDTL.s3o"
          buildPic = Some "CORSCAVDTL.DDS"
          script = Some "units/scavbuildings/SCAVDTL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallBuildingexplosiongeneric"
          selfDestructAs = Some "tinyBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -24 0"
          collisionVolumeScales = Some "30 51 30"
          collisionVolumeType = Some "Ell"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "dclaw"
                displayName = "Close-quarters g2g lightning turret"
                weaponType = Some "LightningCannon"
                damage = Map.ofList [
                    "commanders", 39.0
                    "default", 21.0
                    "vtol", 2.5
                ]
                range = Some (ValueOrExpr.Concrete 440.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.13333)
                weaponVelocity = Some 450.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lghthvy1"
                soundHit = Some "lashit"
                explosiongenerator = Some "custom:genericshellexplosion-medium-lightning2"
                rgbColor = Some "0.5 0.5 1"
                customParams = Map.ofList [
                    "spark_ceg", "genericshellexplosion-splash-lightning"
                    "spark_forkdamage", "0.33"
                    "spark_maxunits", "2"
                    "spark_range", "60"
                ]
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "beamttl", "1.0"
                    "burst", "10.0"
                    "burstrate", "0.03333"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "1.0"
                    "firestarter", "50.0"
                    "impactonly", "1.0"
                    "intensity", "24.0"
                    "soundhitwet", "sizzle"
                    "soundtrigger", "true"
                    "thickness", "1.5"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "ffff"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0 2.37060546837e-06 -0.0625"
                collisionVolumeScales = Some "32.0 17.7499847412 31.375"
                collisionVolumeType = Some "Box"
                damage = Some 540.0
                featureDead = Some "ROCKTEETH"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 205.0
                object_ = Some "scavs/scavdrag.s3o"
                reclaimable = Some true
                resurrectable = None }
              "rockteeth",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 500.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 2.0
                object_ = Some "Units/cor1X1A.s3o"
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
              ok = ["servmed2"]
              select = ["servmed2"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "false"
              "buildinggrounddecaltype", "decals/scavdtf_aoplane.dds"
              "buildinggrounddecalsizey", "4.0"
              "buildinggrounddecalsizex", "4.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "weapon"
              "decoyfor", "corscavdrag"
              "model_author", "FireStorm"
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
              "damagemodifier", "0.33"
              "decoyfor", "scavdrag"
              "hidedamage", "true"
              "levelground", "false"
              "mass", "10000000000.0"
              "nochasecategory", "MOBILE"
              "radardistancejam", "8.0"
              "stealth", "true"
              "upright", "true"
          ] }

    let legdtlToFlat (def: UnitDef) : Legdtl =
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
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let legdtlToUnitDef (flat: Legdtl) : UnitDef =
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
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Legdtm =
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
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legdtm : Legdtm =
        { name = "legdtm"
          subfolder = "Scavengers/Buildings/DefenseOffense"
          metalCost = ValueOrExpr.Concrete 290.0
          energyCost = ValueOrExpr.Concrete 1550.0
          buildTime = ValueOrExpr.Concrete 4400.0
          health = ValueOrExpr.Concrete 1610.0
          sightDistance = ValueOrExpr.Concrete 422.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "scavs/SCAVDTM.s3o"
          buildPic = Some "CORSCAVDTM.DDS"
          script = Some "units/scavbuildings/SCAVDTM.cob"
          corpse = Some "DEAD"
          explodeAs = Some "flamethrower"
          selfDestructAs = Some "flamethrowerSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          yardMap = "ffff"
          canRepeat = false
          weapons = [
                { name = "cormh_weapon"
                  displayName = "Rocket"
                  weaponType = Some "StarburstLauncher"
                  damage = Map.ofList [
                      "default", 550.0
                      "subs", 200.0
                  ]
                  range = Some (ValueOrExpr.Concrete 500.0)
                  reloadTime = Some (ValueOrExpr.Concrete 5.0)
                  weaponVelocity = Some 480.0
                  areaOfEffect = Some 80.0
                  accuracy = None
                  turret = None
                  tolerance = Some 4000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "Rockhvy1"
                  soundHit = Some "xplomed4"
                  explosiongenerator = Some "custom:genericshellexplosion-medium-bomb"
                  rgbColor = None
                  customParams = Map.ofList [
                      "projectile_destruction_method", "descend"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "MOBILE"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "cegtag", "missiletrailsmall-starburst"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "100.0"
                      "firesubmersed", "true"
                      "flighttime", "10.0"
                      "metalpershot", "0.0"
                      "model", "corkbmissl1.s3o"
                      "smoketrail", "false"
                      "soundhitwet", "splssml"
                      "texture1", "null"
                      "texture2", "null"
                      "texture3", "null"
                      "turnrate", "15000.0"
                      "weaponacceleration", "70.0"
                      "weapontimer", "2.9"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 0.0149960864258 0.116882324219"
                  collisionVolumeScales = Some "32.042388916 19.5953521729 32.6287231445"
                  collisionVolumeType = Some "Box"
                  damage = Some 600.0
                  featureDead = Some "ROCKTEETH"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 177.0
                  object_ = Some "scavs/scavdrag.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "rockteeth",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 500.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 2.0
                  object_ = Some "Units/cor1X1A.s3o"
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
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["servmed2"]
                select = ["servmed2"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "false"
                "buildinggrounddecaltype", "decals/scavdtf_aoplane.dds"
                "buildinggrounddecalsizey", "4.0"
                "buildinggrounddecalsizex", "4.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "weapon"
                "decoyfor", "corscavdrag"
                "model_author", "FireStorm"
                "normaltex", "unittextures/cor_normal.dds"
                "removewait", "true"
            ]
          extras = Map.ofList [
                "buildangle", "8192.0"
                "damagemodifier", "0.33"
                "decoyfor", "scavdrag"
                "hidedamage", "true"
                "levelground", "false"
                "mass", "10000000000.0"
                "nochasecategory", "MOBILE"
                "radardistancejam", "8.0"
                "stealth", "true"
                "upright", "true"
            ] }

    let legdtmDef : UnitDef =
        { name = "legdtm"
          subfolder = "Scavengers/Buildings/DefenseOffense"
          metalCost = ValueOrExpr.Concrete 290.0
          energyCost = ValueOrExpr.Concrete 1550.0
          buildTime = ValueOrExpr.Concrete 4400.0
          health = ValueOrExpr.Concrete 1610.0
          sightDistance = ValueOrExpr.Concrete 422.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "scavs/SCAVDTM.s3o"
          buildPic = Some "CORSCAVDTM.DDS"
          script = Some "units/scavbuildings/SCAVDTM.cob"
          corpse = Some "DEAD"
          explodeAs = Some "flamethrower"
          selfDestructAs = Some "flamethrowerSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "cormh_weapon"
                displayName = "Rocket"
                weaponType = Some "StarburstLauncher"
                damage = Map.ofList [
                    "default", 550.0
                    "subs", 200.0
                ]
                range = Some (ValueOrExpr.Concrete 500.0)
                reloadTime = Some (ValueOrExpr.Concrete 5.0)
                weaponVelocity = Some 480.0
                areaOfEffect = Some 80.0
                accuracy = None
                turret = None
                tolerance = Some 4000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "Rockhvy1"
                soundHit = Some "xplomed4"
                explosiongenerator = Some "custom:genericshellexplosion-medium-bomb"
                rgbColor = None
                customParams = Map.ofList [
                    "projectile_destruction_method", "descend"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "cegtag", "missiletrailsmall-starburst"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "100.0"
                    "firesubmersed", "true"
                    "flighttime", "10.0"
                    "metalpershot", "0.0"
                    "model", "corkbmissl1.s3o"
                    "smoketrail", "false"
                    "soundhitwet", "splssml"
                    "texture1", "null"
                    "texture2", "null"
                    "texture3", "null"
                    "turnrate", "15000.0"
                    "weaponacceleration", "70.0"
                    "weapontimer", "2.9"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "ffff"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0 0.0149960864258 0.116882324219"
                collisionVolumeScales = Some "32.042388916 19.5953521729 32.6287231445"
                collisionVolumeType = Some "Box"
                damage = Some 600.0
                featureDead = Some "ROCKTEETH"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 177.0
                object_ = Some "scavs/scavdrag.s3o"
                reclaimable = Some true
                resurrectable = None }
              "rockteeth",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 500.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 2.0
                object_ = Some "Units/cor1X1A.s3o"
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
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["servmed2"]
              select = ["servmed2"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "false"
              "buildinggrounddecaltype", "decals/scavdtf_aoplane.dds"
              "buildinggrounddecalsizey", "4.0"
              "buildinggrounddecalsizex", "4.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "weapon"
              "decoyfor", "corscavdrag"
              "model_author", "FireStorm"
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
              "damagemodifier", "0.33"
              "decoyfor", "scavdrag"
              "hidedamage", "true"
              "levelground", "false"
              "mass", "10000000000.0"
              "nochasecategory", "MOBILE"
              "radardistancejam", "8.0"
              "stealth", "true"
              "upright", "true"
          ] }

    let legdtmToFlat (def: UnitDef) : Legdtm =
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
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let legdtmToUnitDef (flat: Legdtm) : UnitDef =
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
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Legministarfall =
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
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legministarfall : Legministarfall =
        { name = "legministarfall"
          subfolder = "Scavengers/Buildings/DefenseOffense"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 0.0
          buildTime = ValueOrExpr.Concrete 65000.0
          health = ValueOrExpr.Concrete 0.0
          sightDistance = ValueOrExpr.Concrete 700.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/scavbuildings/legministarfall.s3o"
          buildPic = Some "LEGSTARFALL.DDS"
          script = Some "Units/scavbuildings/legministarfall.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeBuildingexplosiongeneric"
          selfDestructAs = Some "hugeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -3 0"
          collisionVolumeScales = Some "52 65 52"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          yardMap = "ooo ooo ooo"
          canRepeat = false
          weapons = [
                { name = "starfire"
                  displayName = "Long-Range High-Trajectory 63-Salvo Plasma Launcher"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 125.0
                      "shields", 110.0
                      "subs", 10.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1400.0)
                  reloadTime = Some (ValueOrExpr.Concrete 7.0)
                  weaponVelocity = Some 500.0
                  areaOfEffect = Some 55.0
                  accuracy = Some 0.0
                  turret = Some true
                  tolerance = Some 364.0
                  edgeEffectiveness = Some 0.95
                  impulseFactor = Some 0.5
                  noSelfDamage = Some true
                  soundStart = Some "cannon2"
                  soundHit = Some "xplomed3"
                  explosiongenerator = Some "custom:ministarfire-explosion"
                  rgbColor = Some "0.7 0.7 1.0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "MOBILE"
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_burstControlWhenOutOfArc", "1.0"
                      "mount_maindir", "0 0 1"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "avoidground", "false"
                      "burst", "63.0"
                      "burstrate", "0.03"
                      "sprayangle", "400.0"
                      "highTrajectory", "1.0"
                      "cegtag", "ministarfire"
                      "collidefriendly", "false"
                      "craterboost", "0.1"
                      "cratermult", "0.1"
                      "energypershot", "20000.0"
                      "fireTolerance", "364.0"
                      "gravityaffected", "true"
                      "soundhitwet", "splshbig"
                      "soundhitvolume", "20.0"
                      "weapontimer", "14.0"
                      "windup", "2.5"
                  ] }
                { name = "energycharger"
                  displayName = "Mini Plasma Volley Energy Charger (supplies energy to Mini Starfall cannon)"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 0.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.0)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 0.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "ministarfallchargup"
                  soundHit = Some "ministarfallchargup"
                  explosiongenerator = Some ""
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "hightrajectory", "1.0"
                      "metalpershot", "0.0"
                      "energypershot", "0.0"
                      "size", "0.0"
                      "soundhitwet", "ministarfallchargup"
                      "soundstartvolume", "124.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "45 60 45"
                  collisionVolumeType = Some "Box"
                  damage = Some 3000.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 6000.0
                  object_ = Some "Units/scavbuildings/legministarfall_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 1500.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 3000.0
                  object_ = Some "Units/arm3X3A.s3o"
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
                ok = ["servlrg3"]
                select = ["servlrg3"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "false"
                "unitgroup", "weapon"
                "model_author", "ZephyrSkies"
                "normaltex", "unittextures/leg_normal.dds"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandDefenceOffence"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "acceleration", "0.0"
                "brakerate", "0.0"
                "buildangle", "29096.0"
                "buildcostenergy", "60000.0"
                "buildcostmetal", "2000.0"
                "maxdamage", "7000.0"
            ] }

    let legministarfallDef : UnitDef =
        { name = "legministarfall"
          subfolder = "Scavengers/Buildings/DefenseOffense"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 0.0
          buildTime = ValueOrExpr.Concrete 65000.0
          health = ValueOrExpr.Concrete 0.0
          sightDistance = ValueOrExpr.Concrete 700.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/scavbuildings/legministarfall.s3o"
          buildPic = Some "LEGSTARFALL.DDS"
          script = Some "Units/scavbuildings/legministarfall.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeBuildingexplosiongeneric"
          selfDestructAs = Some "hugeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -3 0"
          collisionVolumeScales = Some "52 65 52"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "starfire"
                displayName = "Long-Range High-Trajectory 63-Salvo Plasma Launcher"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 125.0
                    "shields", 110.0
                    "subs", 10.0
                ]
                range = Some (ValueOrExpr.Concrete 1400.0)
                reloadTime = Some (ValueOrExpr.Concrete 7.0)
                weaponVelocity = Some 500.0
                areaOfEffect = Some 55.0
                accuracy = Some 0.0
                turret = Some true
                tolerance = Some 364.0
                edgeEffectiveness = Some 0.95
                impulseFactor = Some 0.5
                noSelfDamage = Some true
                soundStart = Some "cannon2"
                soundHit = Some "xplomed3"
                explosiongenerator = Some "custom:ministarfire-explosion"
                rgbColor = Some "0.7 0.7 1.0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_burstControlWhenOutOfArc", "1.0"
                    "mount_maindir", "0 0 1"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "avoidground", "false"
                    "burst", "63.0"
                    "burstrate", "0.03"
                    "sprayangle", "400.0"
                    "highTrajectory", "1.0"
                    "cegtag", "ministarfire"
                    "collidefriendly", "false"
                    "craterboost", "0.1"
                    "cratermult", "0.1"
                    "energypershot", "20000.0"
                    "fireTolerance", "364.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splshbig"
                    "soundhitvolume", "20.0"
                    "weapontimer", "14.0"
                    "windup", "2.5"
                ] }
              { name = "energycharger"
                displayName = "Mini Plasma Volley Energy Charger (supplies energy to Mini Starfall cannon)"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = Some (ValueOrExpr.Concrete 1.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 0.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "ministarfallchargup"
                soundHit = Some "ministarfallchargup"
                explosiongenerator = Some ""
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "hightrajectory", "1.0"
                    "metalpershot", "0.0"
                    "energypershot", "0.0"
                    "size", "0.0"
                    "soundhitwet", "ministarfallchargup"
                    "soundstartvolume", "124.0"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "ooo ooo ooo"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "45 60 45"
                collisionVolumeType = Some "Box"
                damage = Some 3000.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 6000.0
                object_ = Some "Units/scavbuildings/legministarfall_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 1500.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 3000.0
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
              ok = ["servlrg3"]
              select = ["servlrg3"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "false"
              "unitgroup", "weapon"
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "removewait", "true"
              "subfolder", "ArmBuildings/LandDefenceOffence"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "acceleration", "0.0"
              "brakerate", "0.0"
              "buildangle", "29096.0"
              "buildcostenergy", "60000.0"
              "buildcostmetal", "2000.0"
              "maxdamage", "7000.0"
          ] }

    let legministarfallToFlat (def: UnitDef) : Legministarfall =
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
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let legministarfallToUnitDef (flat: Legministarfall) : UnitDef =
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
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Legrwall =
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
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legrwall : Legrwall =
        { name = "legrwall"
          subfolder = "Scavengers/Buildings/DefenseOffense"
          metalCost = ValueOrExpr.Concrete 1250.0
          energyCost = ValueOrExpr.Concrete 6000.0
          buildTime = ValueOrExpr.Concrete 12000.0
          health = ValueOrExpr.Concrete 9600.0
          sightDistance = ValueOrExpr.Concrete 330.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/legrwall.s3o"
          buildPic = Some "legrwall.DDS"
          script = Some "Units/legrwall.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallBuildingexplosiongeneric"
          selfDestructAs = Some "tinyBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -8 0"
          collisionVolumeScales = Some "32 42 32"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          yardMap = "ffff"
          canRepeat = false
          weapons = [
                { name = "railgunt2"
                  displayName = "Compact Railgun"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "commanders", 250.0
                      "default", 1000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 950.0)
                  reloadTime = Some (ValueOrExpr.Concrete 4.0)
                  weaponVelocity = Some 3000.0
                  areaOfEffect = Some 16.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 6000.0
                  edgeEffectiveness = Some 0.85
                  impulseFactor = Some 1.0
                  noSelfDamage = Some true
                  soundStart = Some "lancefire"
                  soundHit = Some "mavgun3"
                  explosiongenerator = Some "custom:plasmahit-sparkonly"
                  rgbColor = Some "0.34 0.64 0.94"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "mount_badtargetcategory", "VTOL"
                      "avoidfeature", "false"
                      "burnblow", "false"
                      "cegtag", "railgun"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "0.12"
                      "energypershot", "250.0"
                      "fallOffRate", "0.2"
                      "firestarter", "0.0"
                      "hardstop", "true"
                      "impactonly", "true"
                      "impulseboost", "0.4"
                      "intensity", "0.8"
                      "noexplode", "true"
                      "ownerExpAccWeight", "4.0"
                      "proximitypriority", "1.0"
                      "soundhitwet", "splshbig"
                      "soundstartvolume", "26.0"
                      "thickness", "3.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -3 0"
                  collisionVolumeScales = Some "32 50 32"
                  collisionVolumeType = Some "CylY"
                  damage = Some 540.0
                  featureDead = Some "ROCKTEETH"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 205.0
                  object_ = Some "Units/legforti.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "rockteeth",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 500.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 2.0
                  object_ = Some "Units/cor1X1A.s3o"
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
                ok = ["servmed2"]
                select = ["servmed2"] }
          customParams = Map.ofList [
                "neutral_when_closed", "true"
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/legforti_aoplane.dds"
                "buildinggrounddecalsizey", "5.0"
                "buildinggrounddecalsizex", "5.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "weapon"
                "decoyfor", "armfort"
                "model_author", "Tharsis"
                "normaltex", "unittextures/leg_normal.dds"
                "removewait", "true"
                "subfolder", "CorBuildings/LandDefenceOffence"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "damagemodifier", "0.25"
                "decoyfor", "corfort"
                "hidedamage", "true"
                "levelground", "false"
                "mass", "10000000000.0"
                "nochasecategory", "MOBILE"
                "stealth", "true"
                "upright", "true"
            ] }

    let legrwallDef : UnitDef =
        { name = "legrwall"
          subfolder = "Scavengers/Buildings/DefenseOffense"
          metalCost = ValueOrExpr.Concrete 1250.0
          energyCost = ValueOrExpr.Concrete 6000.0
          buildTime = ValueOrExpr.Concrete 12000.0
          health = ValueOrExpr.Concrete 9600.0
          sightDistance = ValueOrExpr.Concrete 330.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/legrwall.s3o"
          buildPic = Some "legrwall.DDS"
          script = Some "Units/legrwall.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallBuildingexplosiongeneric"
          selfDestructAs = Some "tinyBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -8 0"
          collisionVolumeScales = Some "32 42 32"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "railgunt2"
                displayName = "Compact Railgun"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "commanders", 250.0
                    "default", 1000.0
                ]
                range = Some (ValueOrExpr.Concrete 950.0)
                reloadTime = Some (ValueOrExpr.Concrete 4.0)
                weaponVelocity = Some 3000.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = Some 6000.0
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 1.0
                noSelfDamage = Some true
                soundStart = Some "lancefire"
                soundHit = Some "mavgun3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "0.34 0.64 0.94"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "mount_badtargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "burnblow", "false"
                    "cegtag", "railgun"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.12"
                    "energypershot", "250.0"
                    "fallOffRate", "0.2"
                    "firestarter", "0.0"
                    "hardstop", "true"
                    "impactonly", "true"
                    "impulseboost", "0.4"
                    "intensity", "0.8"
                    "noexplode", "true"
                    "ownerExpAccWeight", "4.0"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "26.0"
                    "thickness", "3.0"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "ffff"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -3 0"
                collisionVolumeScales = Some "32 50 32"
                collisionVolumeType = Some "CylY"
                damage = Some 540.0
                featureDead = Some "ROCKTEETH"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 205.0
                object_ = Some "Units/legforti.s3o"
                reclaimable = Some true
                resurrectable = None }
              "rockteeth",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 500.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 2.0
                object_ = Some "Units/cor1X1A.s3o"
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
              ok = ["servmed2"]
              select = ["servmed2"] })
          customParams = Map.ofList [
              "neutral_when_closed", "true"
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/legforti_aoplane.dds"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "weapon"
              "decoyfor", "armfort"
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "removewait", "true"
              "subfolder", "CorBuildings/LandDefenceOffence"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "damagemodifier", "0.25"
              "decoyfor", "corfort"
              "hidedamage", "true"
              "levelground", "false"
              "mass", "10000000000.0"
              "nochasecategory", "MOBILE"
              "stealth", "true"
              "upright", "true"
          ] }

    let legrwallToFlat (def: UnitDef) : Legrwall =
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
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let legrwallToUnitDef (flat: Legrwall) : UnitDef =
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
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

