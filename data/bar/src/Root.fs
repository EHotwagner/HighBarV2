// Auto-generated BAR unit data: Root (flat per-unit types)
namespace BarData.Units

open BarData

module Root =

    type Armassistdrone_land =
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
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armassistdrone_land : Armassistdrone_land =
        { name = "armassistdrone_land"
          subfolder = "Root"
          metalCost = ValueOrExpr.Concrete 1.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 500.0
          health = ValueOrExpr.Concrete 2000.0
          sightDistance = ValueOrExpr.Concrete 150.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 37.5
          maxAcc = 1.0
          maxDec = 1.0
          turnRate = 1000.0
          movementClass = "ATANK3"
          maxSlope = 16.0
          maxWaterDepth = 255.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 0.9834
          workerTime = ValueOrExpr.Expr "100*Spring.GetModOptions().assistdronesbuildpowermultiplier"
          buildDistance = 150.0
          buildOptions = ["armsolar"; "armwin"; "armmstor"; "armestor"; "armmex"; "armmakr"; "armlab"; "armvp"; "armap"; "armeyes"; "armrad"; "armdrag"; "armllt"; "armrl"; "armdl"; "armtide"; "armuwms"; "armuwes"; "armfmkr"; "armsy"; "armfdrag"; "armtl"; "armfrt"; "armfrad"; "armhp"; "armfhp"]
          terraformSpeed = 400.0
          sounds =
              { build = Some "nanlath1"
                repair = Some "repair1"
                working = Some "reclaim1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["tnkt1canamphok"]
                select = ["tnkt1canamphsel"] }
          customParams = Map.ofList [
                "unitgroup", "builder"
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmVehicles"
            ]
          extras = Map.ofList [
                "cancapture", "true"
                "leavetracks", "true"
                "trackstrength", "5.0"
                "tracktype", "armpincer_tracks"
                "trackwidth", "17.0"
            ] }

    type Armcom =
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
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          energyMake: ValueOrExpr<float>
          metalMake: ValueOrExpr<float>
          energyStorage: float
          metalStorage: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armcom : Armcom =
        { name = "armcom"
          subfolder = "Root"
          metalCost = ValueOrExpr.Concrete 2700.0
          energyCost = ValueOrExpr.Concrete 26000.0
          buildTime = ValueOrExpr.Concrete 75000.0
          health = ValueOrExpr.Concrete 3700.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 37.5
          maxAcc = 0.18
          maxDec = 1.125
          turnRate = 1148.0
          movementClass = "COMMANDERBOT"
          maxSlope = 20.0
          maxWaterDepth = 35.0
          canMove = true
          turnInPlaceAngleLimit = 140.0
          turnInPlaceSpeedLimit = 0.825
          workerTime = ValueOrExpr.Concrete 300.0
          buildDistance = 145.0
          buildOptions = ["armsolar"; "armwin"; "armmstor"; "armestor"; "armmex"; "armmakr"; "armlab"; "armvp"; "armap"; "armeyes"; "armrad"; "armdrag"; "armllt"; "armrl"; "armdl"; "armtide"; "armuwms"; "armuwes"; "armfmkr"; "armsy"; "armfdrag"; "armtl"; "armfrt"; "armfrad"; "armhp"; "armfhp"]
          terraformSpeed = 1500.0
          energyMake = ValueOrExpr.Concrete 30.0
          metalMake = ValueOrExpr.Concrete 2.0
          energyStorage = 500.0
          metalStorage = 500.0
          weapons = [
                { name = "armcomlaser"
                  displayName = Some "Light close-quarters g2g/g2a laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 75.0
                      "subs", 5.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.4)
                  weaponVelocity = Some 900.0
                  areaOfEffect = Some 12.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrfir1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small-red"
                  rgbColor = Some "1 0 0"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_fastautoretargeting", "true"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "beamtime", "0.1"
                      "corethickness", "0.1"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "70.0"
                      "impactonly", "1.0"
                      "laserflaresize", "7.7"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "2.0"
                  ] }
                { name = "armcomsealaser"
                  displayName = Some "Light underwater-combat laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 200.0
                      "subs", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.0)
                  weaponVelocity = Some 900.0
                  areaOfEffect = Some 12.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "uwlasrfir1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small-blue"
                  rgbColor = Some "0.2 0.2 0.6"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTAIR"
                      "avoidfeature", "false"
                      "beamtime", "0.3"
                      "corethickness", "0.4"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "35.0"
                      "firesubmersed", "true"
                      "impactonly", "1.0"
                      "intensity", "0.3"
                      "laserflaresize", "7.7"
                      "rgbcolor2", "0.2 0.2 0.2"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "5.0"
                      "waterweapon", "true"
                  ] }
                { name = "disintegrator"
                  displayName = Some "Disintegrator"
                  weaponType = Some "DGun"
                  damage = Map.ofList [
                      "commanders", 0.0
                      "default", 99999.0
                      "scavboss", 1000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 250.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.9)
                  weaponVelocity = Some 300.0
                  areaOfEffect = Some 36.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 20000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "disigun1"
                  soundHit = Some "xplomas2"
                  explosiongenerator = Some "custom:expldgun"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "avoidground", "false"
                      "bouncerebound", "0.0"
                      "cegtag", "dgunprojectile"
                      "commandfire", "true"
                      "craterboost", "0.0"
                      "cratermult", "0.15"
                      "energypershot", "500.0"
                      "firestarter", "100.0"
                      "firesubmersed", "false"
                      "noexplode", "true"
                      "soundhitvolume", "36.0"
                      "soundhitwet", "sizzlexs"
                      "soundstartvolume", "96.0"
                      "soundtrigger", "true"
                      "waterweapon", "true"
                      "weapontimer", "4.2"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "35 12 54"
                  collisionVolumeType = Some "CylY"
                  damage = Some 10000.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 1250.0
                  object_ = Some "Units/armcom_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35 12 54"
                  collisionVolumeType = Some "cylY"
                  damage = Some 5000.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 500.0
                  object_ = Some "Units/arm2X2F.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = Some "nanlath1"
                repair = Some "repair1"
                working = Some "reclaim1"
                underAttack = Some "warning2"
                cancelDestruct = Some "cancel2"
                capture = Some "capture1"
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["armcom1"; "armcom2"; "armcom3"; "armcom4"]
                select = ["armcomsel"] }
          customParams = Map.ofList [
                "iscommander", "true"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "paralyzemultiplier", "0.0"
                "subfolder", ""
                "unitgroup", "builder"
            ]
          extras = Map.ofList [
                "autoheal", "5.0"
                "cancapture", "true"
                "cancloak", "true"
                "canmanualfire", "true"
                "capturable", "false"
                "capturespeed", "1800.0"
                "cloakcost", "100.0"
                "cloakcostmoving", "1000.0"
                "hidedamage", "true"
                "holdsteady", "true"
                "mincloakdistance", "50.0"
                "movestate", "0.0"
                "nochasecategory", "ALL"
                "radardistance", "700.0"
                "radaremitheight", "40.0"
                "reclaimable", "false"
                "releaseheld", "true"
                "selfdestructcountdown", "5.0"
                "showplayername", "true"
                "sightemitheight", "40.0"
                "sonardistance", "450.0"
                "upright", "true"
            ] }

    type Armcomcon =
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
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          energyMake: ValueOrExpr<float>
          metalMake: ValueOrExpr<float>
          energyStorage: float
          metalStorage: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armcomcon : Armcomcon =
        { name = "armcomcon"
          subfolder = "Root"
          metalCost = ValueOrExpr.Concrete 2700.0
          energyCost = ValueOrExpr.Concrete 26000.0
          buildTime = ValueOrExpr.Concrete 75000.0
          health = ValueOrExpr.Concrete 3350.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 37.5
          maxAcc = 0.18
          maxDec = 1.125
          turnRate = 1148.0
          movementClass = "COMMANDERBOT"
          maxSlope = 20.0
          maxWaterDepth = 35.0
          canMove = true
          turnInPlaceAngleLimit = 140.0
          turnInPlaceSpeedLimit = 0.825
          workerTime = ValueOrExpr.Concrete 300.0
          buildDistance = 145.0
          buildOptions = ["armrectr"; "armca"; "armck"; "armch"; "armcsa"; "armcs"; "armcv"]
          terraformSpeed = 1500.0
          energyMake = ValueOrExpr.Concrete 30.0
          metalMake = ValueOrExpr.Concrete 2.0
          energyStorage = 500.0
          metalStorage = 500.0
          weapons = [
                { name = "armcomlaser"
                  displayName = Some "Light close-quarters g2g/g2a laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 75.0
                      "subs", 5.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.4)
                  weaponVelocity = Some 900.0
                  areaOfEffect = Some 12.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrfir1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small-red"
                  rgbColor = Some "1 0 0"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "beamtime", "0.1"
                      "corethickness", "0.1"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "70.0"
                      "impactonly", "1.0"
                      "laserflaresize", "7.7"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "2.0"
                  ] }
                { name = "armcomsealaser"
                  displayName = Some "Light underwater-combat laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 200.0
                      "subs", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.0)
                  weaponVelocity = Some 900.0
                  areaOfEffect = Some 12.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "uwlasrfir1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small-blue"
                  rgbColor = Some "0.2 0.2 0.6"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTAIR"
                      "avoidfeature", "false"
                      "beamtime", "0.3"
                      "corethickness", "0.4"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "35.0"
                      "firesubmersed", "true"
                      "impactonly", "1.0"
                      "intensity", "0.3"
                      "laserflaresize", "7.7"
                      "rgbcolor2", "0.2 0.2 0.2"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "5.0"
                      "waterweapon", "true"
                  ] }
                { name = "disintegrator"
                  displayName = Some "Disintegrator"
                  weaponType = Some "DGun"
                  damage = Map.ofList [
                      "default", 99999.0
                      "scavboss", 1000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 250.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.9)
                  weaponVelocity = Some 300.0
                  areaOfEffect = Some 36.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 20000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "disigun1"
                  soundHit = Some "xplomas2"
                  explosiongenerator = Some "custom:expldgun"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "avoidground", "false"
                      "bouncerebound", "0.0"
                      "cegtag", "dgunprojectile"
                      "commandfire", "true"
                      "craterboost", "0.0"
                      "cratermult", "0.6"
                      "energypershot", "500.0"
                      "firestarter", "100.0"
                      "firesubmersed", "false"
                      "noexplode", "true"
                      "soundhitvolume", "36.0"
                      "soundhitwet", "sizzle"
                      "soundstartvolume", "96.0"
                      "soundtrigger", "true"
                      "waterweapon", "true"
                      "weapontimer", "4.2"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "47 10 47"
                  collisionVolumeType = Some "CylY"
                  damage = Some 10000.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 2000.0
                  object_ = Some "Units/armcom_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 5000.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 1000.0
                  object_ = Some "Units/arm2X2F.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = Some "nanlath1"
                repair = Some "repair1"
                working = Some "reclaim1"
                underAttack = Some "warning2"
                cancelDestruct = Some "cancel2"
                capture = Some "capture1"
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["armcom1"; "armcom2"; "armcom3"; "armcom4"]
                select = ["armcomsel"] }
          customParams = Map.ofList [
                "i18nfromunit", "armcom"
                "iscommander", "true"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "paralyzemultiplier", "0.0"
                "subfolder", ""
                "unitgroup", "builder"
            ]
          extras = Map.ofList [
                "autoheal", "5.0"
                "cancapture", "true"
                "cancloak", "true"
                "canmanualfire", "true"
                "capturable", "false"
                "capturespeed", "1800.0"
                "cloakcost", "100.0"
                "cloakcostmoving", "1000.0"
                "hidedamage", "true"
                "holdsteady", "true"
                "mincloakdistance", "50.0"
                "nochasecategory", "ALL"
                "radardistance", "700.0"
                "radaremitheight", "40.0"
                "reclaimable", "false"
                "releaseheld", "true"
                "selfdestructcountdown", "5.0"
                "showplayername", "true"
                "sightemitheight", "40.0"
                "sonardistance", "450.0"
                "upright", "true"
            ] }

    type Armcomnew =
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
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          energyMake: ValueOrExpr<float>
          metalMake: ValueOrExpr<float>
          energyStorage: float
          metalStorage: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armcomnew : Armcomnew =
        { name = "armcomnew"
          subfolder = "Root"
          metalCost = ValueOrExpr.Concrete 2700.0
          energyCost = ValueOrExpr.Concrete 26000.0
          buildTime = ValueOrExpr.Concrete 75000.0
          health = ValueOrExpr.Concrete 3700.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 37.5
          maxAcc = 0.18
          maxDec = 1.125
          turnRate = 1148.0
          movementClass = "COMMANDERBOT"
          maxSlope = 20.0
          maxWaterDepth = 35.0
          canMove = true
          turnInPlaceAngleLimit = 140.0
          turnInPlaceSpeedLimit = 0.825
          workerTime = ValueOrExpr.Concrete 300.0
          buildDistance = 145.0
          buildOptions = ["armsolar"; "armwin"; "armmstor"; "armestor"; "armmex"; "armmakr"; "armlab"; "armvp"; "armap"; "armeyes"; "armrad"; "armdrag"; "armllt"; "armrl"; "armdl"; "armtide"; "armuwms"; "armuwes"; "armfmkr"; "armsy"; "armfdrag"; "armtl"; "armfrt"; "armfrad"; "armhp"; "armfhp"]
          terraformSpeed = 1500.0
          energyMake = ValueOrExpr.Concrete 30.0
          metalMake = ValueOrExpr.Concrete 2.0
          energyStorage = 500.0
          metalStorage = 500.0
          weapons = [
                { name = "armcomlaser"
                  displayName = Some "Light close-quarters g2g/g2a laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 75.0
                      "subs", 5.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.4)
                  weaponVelocity = Some 900.0
                  areaOfEffect = Some 12.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrfir1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small-red"
                  rgbColor = Some "1 0 0"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_fastautoretargeting", "true"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "beamtime", "0.1"
                      "corethickness", "0.1"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "70.0"
                      "impactonly", "1.0"
                      "laserflaresize", "7.7"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "2.0"
                  ] }
                { name = "armcomsealaser"
                  displayName = Some "Light underwater-combat laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 200.0
                      "subs", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.0)
                  weaponVelocity = Some 900.0
                  areaOfEffect = Some 12.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "uwlasrfir1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small-blue"
                  rgbColor = Some "0.2 0.2 0.6"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTAIR"
                      "avoidfeature", "false"
                      "beamtime", "0.3"
                      "corethickness", "0.4"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "35.0"
                      "firesubmersed", "true"
                      "impactonly", "1.0"
                      "intensity", "0.3"
                      "laserflaresize", "7.7"
                      "rgbcolor2", "0.2 0.2 0.2"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "5.0"
                      "waterweapon", "true"
                  ] }
                { name = "disintegrator"
                  displayName = Some "Disintegrator"
                  weaponType = Some "DGun"
                  damage = Map.ofList [
                      "commanders", 0.0
                      "default", 99999.0
                      "scavboss", 1000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 250.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.9)
                  weaponVelocity = Some 300.0
                  areaOfEffect = Some 36.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 20000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "disigun1"
                  soundHit = Some "xplomas2"
                  explosiongenerator = Some "custom:expldgun"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "avoidground", "false"
                      "bouncerebound", "0.0"
                      "cegtag", "dgunprojectile"
                      "commandfire", "true"
                      "craterboost", "0.0"
                      "cratermult", "0.15"
                      "energypershot", "500.0"
                      "firestarter", "100.0"
                      "firesubmersed", "false"
                      "noexplode", "true"
                      "soundhitvolume", "36.0"
                      "soundhitwet", "sizzlexs"
                      "soundstartvolume", "96.0"
                      "soundtrigger", "true"
                      "waterweapon", "true"
                      "weapontimer", "4.2"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "35 12 54"
                  collisionVolumeType = Some "CylY"
                  damage = Some 10000.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 1250.0
                  object_ = Some "Units/armcom_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35 12 54"
                  collisionVolumeType = Some "cylY"
                  damage = Some 5000.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 500.0
                  object_ = Some "Units/arm2X2F.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = Some "nanlath1"
                repair = Some "repair1"
                working = Some "reclaim1"
                underAttack = Some "warning2"
                cancelDestruct = Some "cancel2"
                capture = Some "capture1"
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["armcom1"; "armcom2"; "armcom3"; "armcom4"]
                select = ["armcomsel"] }
          customParams = Map.ofList [
                "iscommander", "true"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "paralyzemultiplier", "0.0"
                "subfolder", ""
                "unitgroup", "builder"
            ]
          extras = Map.ofList [
                "autoheal", "5.0"
                "cancapture", "true"
                "cancloak", "true"
                "canmanualfire", "true"
                "capturable", "false"
                "capturespeed", "1800.0"
                "cloakcost", "100.0"
                "cloakcostmoving", "1000.0"
                "hidedamage", "true"
                "holdsteady", "true"
                "mincloakdistance", "50.0"
                "movestate", "0.0"
                "nochasecategory", "ALL"
                "radardistance", "700.0"
                "radaremitheight", "40.0"
                "reclaimable", "false"
                "releaseheld", "true"
                "selfdestructcountdown", "5.0"
                "showplayername", "true"
                "sightemitheight", "40.0"
                "sonardistance", "450.0"
                "upright", "true"
            ] }

    type Corassistdrone_land =
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
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corassistdrone_land : Corassistdrone_land =
        { name = "corassistdrone_land"
          subfolder = "Root"
          metalCost = ValueOrExpr.Concrete 1.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 500.0
          health = ValueOrExpr.Concrete 2000.0
          sightDistance = ValueOrExpr.Concrete 150.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 37.5
          maxAcc = 1.0
          maxDec = 1.0
          turnRate = 1000.0
          movementClass = "ATANK3"
          maxSlope = 16.0
          maxWaterDepth = 255.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 0.9504
          workerTime = ValueOrExpr.Expr "100*Spring.GetModOptions().assistdronesbuildpowermultiplier"
          buildDistance = 150.0
          buildOptions = ["corsolar"; "corwin"; "cormstor"; "corestor"; "cormex"; "cormakr"; "corlab"; "corvp"; "corap"; "coreyes"; "corrad"; "cordrag"; "corllt"; "corrl"; "cordl"; "cortide"; "coruwms"; "coruwes"; "corfmkr"; "corsy"; "corfdrag"; "cortl"; "corfrt"; "corfrad"; "corhp"; "corfhp"]
          terraformSpeed = 400.0
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
                "unitgroup", "builder"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorVehicles"
            ]
          extras = Map.ofList [
                "cancapture", "true"
                "leavetracks", "true"
                "trackoffset", "8.0"
                "trackstrength", "5.0"
                "tracktype", "corwidetracks"
                "trackwidth", "12.0"
            ] }

    type Corcom =
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
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          energyMake: ValueOrExpr<float>
          metalMake: ValueOrExpr<float>
          energyStorage: float
          metalStorage: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corcom : Corcom =
        { name = "corcom"
          subfolder = "Root"
          metalCost = ValueOrExpr.Concrete 2700.0
          energyCost = ValueOrExpr.Concrete 26000.0
          buildTime = ValueOrExpr.Concrete 75000.0
          health = ValueOrExpr.Concrete 3700.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 37.5
          maxAcc = 0.18
          maxDec = 1.125
          turnRate = 1133.0
          movementClass = "COMMANDERBOT"
          maxSlope = 20.0
          maxWaterDepth = 35.0
          canMove = true
          turnInPlaceAngleLimit = 140.0
          turnInPlaceSpeedLimit = 0.825
          workerTime = ValueOrExpr.Concrete 300.0
          buildDistance = 145.0
          buildOptions = ["corsolar"; "corwin"; "cormstor"; "corestor"; "cormex"; "cormakr"; "corlab"; "corvp"; "corap"; "coreyes"; "corrad"; "cordrag"; "corllt"; "corrl"; "cordl"; "cortide"; "coruwms"; "coruwes"; "corfmkr"; "corsy"; "corfdrag"; "cortl"; "corfrt"; "corfrad"; "corhp"; "corfhp"]
          terraformSpeed = 1500.0
          energyMake = ValueOrExpr.Concrete 30.0
          metalMake = ValueOrExpr.Concrete 2.0
          energyStorage = 500.0
          metalStorage = 500.0
          weapons = [
                { name = "corcomlaser"
                  displayName = Some "J7Laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 75.0
                      "subs", 5.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.4)
                  weaponVelocity = Some 900.0
                  areaOfEffect = Some 12.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrfir1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small-red"
                  rgbColor = Some "1 0 0"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_fastautoretargeting", "true"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "beamtime", "0.1"
                      "corethickness", "0.1"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "70.0"
                      "impactonly", "1.0"
                      "laserflaresize", "5.5"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "2.0"
                  ] }
                { name = "corcomsealaser"
                  displayName = Some "J7NSLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 200.0
                      "subs", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.0)
                  weaponVelocity = Some 900.0
                  areaOfEffect = Some 12.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "uwlasrfir1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small-blue"
                  rgbColor = Some "0.2 0.2 0.6"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTAIR"
                      "avoidfeature", "false"
                      "beamtime", "0.3"
                      "corethickness", "0.1"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "35.0"
                      "firesubmersed", "true"
                      "impactonly", "1.0"
                      "intensity", "0.3"
                      "laserflaresize", "5.5"
                      "rgbcolor2", "0.2 0.2 0.2"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "5.0"
                      "waterweapon", "true"
                  ] }
                { name = "disintegrator"
                  displayName = Some "Disintegrator"
                  weaponType = Some "DGun"
                  damage = Map.ofList [
                      "commanders", 0.0
                      "default", 99999.0
                      "scavboss", 1000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 262.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.9)
                  weaponVelocity = Some 300.0
                  areaOfEffect = Some 36.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "disigun1"
                  soundHit = Some "xplomas2s"
                  explosiongenerator = Some "custom:expldgun"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "avoidground", "false"
                      "bouncerebound", "0.0"
                      "cegtag", "dgunprojectile"
                      "commandfire", "true"
                      "craterboost", "0.0"
                      "cratermult", "0.15"
                      "energypershot", "500.0"
                      "firestarter", "100.0"
                      "firesubmersed", "false"
                      "noexplode", "true"
                      "soundhitvolume", "36.0"
                      "soundhitwet", "sizzlexs"
                      "soundstartvolume", "96.0"
                      "soundtrigger", "true"
                      "waterweapon", "true"
                      "weapontimer", "4.2"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "35 12 54"
                  collisionVolumeType = Some "cylY"
                  damage = Some 10000.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 1250.0
                  object_ = Some "Units/corcom_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35 12 54"
                  collisionVolumeType = Some "cylY"
                  damage = Some 5000.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 500.0
                  object_ = Some "Units/cor2X2C.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = Some "nanlath2"
                repair = Some "repair2"
                working = Some "reclaim1"
                underAttack = Some "warning2"
                cancelDestruct = Some "cancel2"
                capture = Some "capture2"
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["corcom1"; "corcom2"; "corcom3"; "corcom4"; "corcom5"]
                select = ["corcomsel"] }
          customParams = Map.ofList [
                "iscommander", "true"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "paralyzemultiplier", "0.0"
                "subfolder", ""
                "unitgroup", "builder"
            ]
          extras = Map.ofList [
                "autoheal", "5.0"
                "cancapture", "true"
                "cancloak", "true"
                "canmanualfire", "true"
                "capturable", "false"
                "capturespeed", "1800.0"
                "cloakcost", "100.0"
                "cloakcostmoving", "1000.0"
                "hidedamage", "true"
                "holdsteady", "true"
                "mincloakdistance", "50.0"
                "movestate", "0.0"
                "nochasecategory", "ALL"
                "radardistance", "700.0"
                "radaremitheight", "40.0"
                "reclaimable", "false"
                "releaseheld", "true"
                "selfdestructcountdown", "5.0"
                "showplayername", "true"
                "sightemitheight", "40.0"
                "sonardistance", "450.0"
                "upright", "true"
            ] }

    type Corcomcon =
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
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          energyMake: ValueOrExpr<float>
          metalMake: ValueOrExpr<float>
          energyStorage: float
          metalStorage: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corcomcon : Corcomcon =
        { name = "corcomcon"
          subfolder = "Root"
          metalCost = ValueOrExpr.Concrete 2700.0
          energyCost = ValueOrExpr.Concrete 26000.0
          buildTime = ValueOrExpr.Concrete 75000.0
          health = ValueOrExpr.Concrete 3350.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 37.5
          maxAcc = 0.18
          maxDec = 1.125
          turnRate = 1133.0
          movementClass = "COMMANDERBOT"
          maxSlope = 20.0
          maxWaterDepth = 35.0
          canMove = true
          turnInPlaceAngleLimit = 140.0
          turnInPlaceSpeedLimit = 0.825
          workerTime = ValueOrExpr.Concrete 300.0
          buildDistance = 145.0
          buildOptions = ["cornecro"; "corca"; "corck"; "corch"; "corcsa"; "corcs"; "corcv"]
          terraformSpeed = 1500.0
          energyMake = ValueOrExpr.Concrete 30.0
          metalMake = ValueOrExpr.Concrete 2.0
          energyStorage = 500.0
          metalStorage = 500.0
          weapons = [
                { name = "corcomlaser"
                  displayName = Some "J7Laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 75.0
                      "subs", 5.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.4)
                  weaponVelocity = Some 900.0
                  areaOfEffect = Some 12.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrfir1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small-red"
                  rgbColor = Some "1 0 0"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "beamtime", "0.1"
                      "corethickness", "0.1"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "70.0"
                      "impactonly", "1.0"
                      "laserflaresize", "5.5"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "2.0"
                  ] }
                { name = "corcomsealaser"
                  displayName = Some "J7NSLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 200.0
                      "subs", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.0)
                  weaponVelocity = Some 900.0
                  areaOfEffect = Some 12.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "uwlasrfir1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small-blue"
                  rgbColor = Some "0.2 0.2 0.6"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTAIR"
                      "avoidfeature", "false"
                      "beamtime", "0.3"
                      "corethickness", "0.1"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "35.0"
                      "firesubmersed", "true"
                      "impactonly", "1.0"
                      "intensity", "0.3"
                      "laserflaresize", "5.5"
                      "rgbcolor2", "0.2 0.2 0.2"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "5.0"
                      "waterweapon", "true"
                  ] }
                { name = "disintegrator"
                  displayName = Some "Disintegrator"
                  weaponType = Some "DGun"
                  damage = Map.ofList [
                      "default", 99999.0
                      "scavboss", 1000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 250.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.9)
                  weaponVelocity = Some 300.0
                  areaOfEffect = Some 36.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "disigun1"
                  soundHit = Some "xplomas2s"
                  explosiongenerator = Some "custom:expldgun"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "avoidground", "false"
                      "bouncerebound", "0.0"
                      "cegtag", "dgunprojectile"
                      "commandfire", "true"
                      "craterboost", "0.0"
                      "cratermult", "0.6"
                      "energypershot", "500.0"
                      "firestarter", "100.0"
                      "firesubmersed", "false"
                      "noexplode", "true"
                      "soundhitvolume", "36.0"
                      "soundhitwet", "sizzle"
                      "soundstartvolume", "96.0"
                      "soundtrigger", "true"
                      "waterweapon", "true"
                      "weapontimer", "4.2"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "35 12 54"
                  collisionVolumeType = Some "cylY"
                  damage = Some 10000.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 2000.0
                  object_ = Some "Units/corcom_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 5000.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 1000.0
                  object_ = Some "Units/cor2X2C.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = Some "nanlath2"
                repair = Some "repair2"
                working = Some "reclaim1"
                underAttack = Some "warning2"
                cancelDestruct = Some "cancel2"
                capture = Some "capture2"
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["corcom1"; "corcom2"; "corcom3"; "corcom4"; "corcom5"]
                select = ["corcomsel"] }
          customParams = Map.ofList [
                "i18nfromunit", "corcom"
                "iscommander", "true"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "paralyzemultiplier", "0.0"
                "subfolder", ""
                "unitgroup", "builder"
            ]
          extras = Map.ofList [
                "autoheal", "5.0"
                "cancapture", "true"
                "cancloak", "true"
                "canmanualfire", "true"
                "capturable", "false"
                "capturespeed", "1800.0"
                "cloakcost", "100.0"
                "cloakcostmoving", "1000.0"
                "hidedamage", "true"
                "holdsteady", "true"
                "mincloakdistance", "50.0"
                "nochasecategory", "ALL"
                "radardistance", "700.0"
                "radaremitheight", "40.0"
                "reclaimable", "false"
                "selfdestructcountdown", "5.0"
                "showplayername", "true"
                "sightemitheight", "40.0"
                "sonardistance", "450.0"
                "upright", "true"
            ] }

