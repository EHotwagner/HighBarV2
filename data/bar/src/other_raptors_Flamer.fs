// Auto-generated BAR unit data: other/raptors/Flamer (flat per-unit types)
namespace BarData.Units

open BarData

module other_raptors_Flamer =

    type Raptor_allterrain_swarmer_fire_t2_v1 =
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
          waterline: float
          weapons: WeaponDef list
          customParams: Map<string, string>
          extras: Map<string, string> }

    let raptor_allterrain_swarmer_fire_t2_v1 : Raptor_allterrain_swarmer_fire_t2_v1 =
        { name = "raptor_allterrain_swarmer_fire_t2_v1"
          subfolder = "other/raptors/Flamer"
          metalCost = ValueOrExpr.Concrete 99.0
          energyCost = ValueOrExpr.Concrete 5280.0
          buildTime = ValueOrExpr.Concrete 2250.0
          health = ValueOrExpr.Concrete 2000.0
          sightDistance = ValueOrExpr.Concrete 300.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 97.5
          maxAcc = 1.4375
          maxDec = 2.3
          turnRate = 1840.0
          movementClass = "RAPTORALLTERRAINHOVER"
          maxSlope = 18.0
          maxWaterDepth = 15.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 10.0
          weapons = [
                { name = "flamer"
                  displayName = Some "FlameThrower"
                  weaponType = Some "Flame"
                  damage = Map.ofList [
                      "default", 16.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.0)
                  weaponVelocity = Some 265.0
                  areaOfEffect = Some 64.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 2500.0
                  edgeEffectiveness = Some 0.3
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "cflamhvy1"
                  soundHit = None
                  explosiongenerator = Some "custom:burnthermite"
                  rgbColor = Some "1 0.94 0.88"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "110.0"
                      "collidefriendly", "0.0"
                      "collidefeature", "0.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "avoidground", "false"
                      "bounceSlip", "1.0"
                      "burst", "12.0"
                      "burstrate", "0.03333"
                      "cegtag", "burnflamethermite"
                      "colormap", "1 0.95 0.9 0.032   0.55 0.55 0.40 0.028   0.40 0.28 0.19 0.024   0.033 0.018 0.011 0.04   0.0 0.0 0.0 0.01"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "100.0"
                      "flamegfxtime", "1.0"
                      "intensity", "0.65"
                      "proximitypriority", "1.0"
                      "rgbcolor2", "0.9 0.83 0.77"
                      "sizegrowth", "2.0"
                      "soundhitwet", "sizzle"
                      "soundtrigger", "false"
                      "sprayangle", "100.0"
                      "targetmoveerror", "0.001"
                      "weapontimer", "1.0"
                  ] }
            ]
          customParams = Map.ofList [
                "subfolder", "other/raptors"
                "model_author", "KDR_11k, Beherith"
                "normalmaps", "yes"
                "normaltex", "unittextures/chicken_s_normals.png"
            ]
          extras = Map.ofList [
                "canattack", "true"
                "canguard", "true"
                "canpatrol", "true"
                "canstop", "1"
                "capturable", "false"
                "defaultmissiontype", "Standby"
                "leavetracks", "true"
                "maneuverleashlength", "640"
                "mass", "89.0"
                "maxreversevelocity", "3.0"
                "noautofire", "false"
                "nochasecategory", "VTOL"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "sonardistance", "450.0"
                "trackoffset", "0.5"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrackPointy"
                "trackwidth", "35.0"
                "unitname", "raptorc3"
                "upright", "false"
            ] }

    type Raptor_land_swarmer_fire_t2_v1 =
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
          maxWaterDepth: float
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          waterline: float
          weapons: WeaponDef list
          customParams: Map<string, string>
          extras: Map<string, string> }

    let raptor_land_swarmer_fire_t2_v1 : Raptor_land_swarmer_fire_t2_v1 =
        { name = "raptor_land_swarmer_fire_t2_v1"
          subfolder = "other/raptors/Flamer"
          metalCost = ValueOrExpr.Concrete 250.0
          energyCost = ValueOrExpr.Concrete 15000.0
          buildTime = ValueOrExpr.Concrete 4500.0
          health = ValueOrExpr.Concrete 500.0
          sightDistance = ValueOrExpr.Concrete 300.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 135.0
          maxAcc = 1.035
          maxDec = 0.805
          turnRate = 1840.0
          movementClass = "RAPTORSMALLHOVER"
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 24.0
          weapons = [
                { name = "chaseweapon"
                  displayName = Some "Claws"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 0.001
                  ]
                  range = Some (ValueOrExpr.Concrete 200.0)
                  reloadTime = Some (ValueOrExpr.Concrete 30.0)
                  weaponVelocity = Some 500.0
                  areaOfEffect = None
                  accuracy = None
                  turret = None
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.3
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = None
                  soundHit = None
                  explosiongenerator = Some "custom:raptorspike-large-sparks-burn"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_maindir", "0 0 1"
                      "mount_onlytargetcategory", "NOTAIR"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "interceptedbyshieldtype", "4.0"
                      "proximitypriority", "-1.0"
                      "size", "0.001"
                  ] }
                { name = "flamer"
                  displayName = Some "FlameThrower"
                  weaponType = Some "Flame"
                  damage = Map.ofList [
                      "default", 16.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.0)
                  weaponVelocity = Some 265.0
                  areaOfEffect = Some 64.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 2500.0
                  edgeEffectiveness = Some 0.3
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "cflamhvy1"
                  soundHit = None
                  explosiongenerator = Some "custom:burnthermite"
                  rgbColor = Some "1 0.94 0.88"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "270.0"
                      "mount_onlytargetcategory", "NOTAIR"
                      "collidefriendly", "0.0"
                      "collidefeature", "0.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "avoidground", "false"
                      "bounceSlip", "1.0"
                      "burst", "12.0"
                      "burstrate", "0.03333"
                      "cegtag", "burnflamethermite"
                      "colormap", "1 0.95 0.9 0.032   0.55 0.55 0.40 0.028   0.40 0.28 0.19 0.024   0.033 0.018 0.011 0.04   0.0 0.0 0.0 0.01"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "100.0"
                      "flamegfxtime", "1.0"
                      "intensity", "0.65"
                      "proximitypriority", "1.0"
                      "rgbcolor2", "0.9 0.83 0.77"
                      "sizegrowth", "2.0"
                      "soundhitwet", "sizzle"
                      "soundtrigger", "false"
                      "sprayangle", "100.0"
                      "targetmoveerror", "0.001"
                      "weapontimer", "1.0"
                  ] }
            ]
          customParams = Map.ofList [
                "maxrange", "200"
                "subfolder", "other/raptors"
                "model_author", "KDR_11k, Beherith"
                "normalmaps", "yes"
                "normaltex", "unittextures/chicken_s_normals.png"
            ]
          extras = Map.ofList [
                "autoheal", "50.0"
                "canguard", "true"
                "canpatrol", "true"
                "canstop", "1"
                "capturable", "false"
                "defaultmissiontype", "Standby"
                "leavetracks", "true"
                "maneuverleashlength", "640"
                "mass", "600.0"
                "noautofire", "false"
                "nochasecategory", "VTOL"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "trackoffset", "0.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrack"
                "trackwidth", "35.0"
                "unitname", "raptorp2"
                "upright", "false"
            ] }

    type Raptor_land_swarmer_fire_t4_v1 =
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
          maxWaterDepth: float
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          waterline: float
          weapons: WeaponDef list
          customParams: Map<string, string>
          extras: Map<string, string> }

    let raptor_land_swarmer_fire_t4_v1 : Raptor_land_swarmer_fire_t4_v1 =
        { name = "raptor_land_swarmer_fire_t4_v1"
          subfolder = "other/raptors/Flamer"
          metalCost = ValueOrExpr.Concrete 200.0
          energyCost = ValueOrExpr.Concrete 6000.0
          buildTime = ValueOrExpr.Concrete 7500.0
          health = ValueOrExpr.Concrete 5000.0
          sightDistance = ValueOrExpr.Concrete 410.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 105.0
          maxAcc = 1.15
          maxDec = 0.69
          turnRate = 920.0
          movementClass = "RAPTORSMALLHOVER"
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 42.0
          weapons = [
                { name = "chaseweapon"
                  displayName = Some "Claws"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 0.001
                  ]
                  range = Some (ValueOrExpr.Concrete 200.0)
                  reloadTime = Some (ValueOrExpr.Concrete 30.0)
                  weaponVelocity = Some 500.0
                  areaOfEffect = None
                  accuracy = None
                  turret = None
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.3
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = None
                  soundHit = None
                  explosiongenerator = Some "custom:raptorspike-large-sparks-burn"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "0 0 1"
                      "mount_onlytargetcategory", "NOTAIR"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "interceptedbyshieldtype", "4.0"
                      "proximitypriority", "-1.0"
                      "size", "1E-05"
                  ] }
                { name = "flamethrower"
                  displayName = Some "FlameThrower"
                  weaponType = Some "Flame"
                  damage = Map.ofList [
                      "default", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 410.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.0)
                  weaponVelocity = Some 265.0
                  areaOfEffect = Some 64.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 2500.0
                  edgeEffectiveness = Some 0.3
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "cflamhvy1"
                  soundHit = None
                  explosiongenerator = Some "custom:burnthermite"
                  rgbColor = Some "1 0.94 0.88"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "collidefriendly", "0.0"
                      "collidefeature", "0.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "avoidground", "false"
                      "bounceSlip", "1.0"
                      "burst", "12.0"
                      "burstrate", "0.03333"
                      "cegtag", "burnflamethermite"
                      "colormap", "1 0.95 0.9 0.032   0.55 0.55 0.40 0.028   0.40 0.28 0.19 0.024   0.033 0.018 0.011 0.04   0.0 0.0 0.0 0.01"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "100.0"
                      "flamegfxtime", "1.0"
                      "intensity", "0.65"
                      "proximitypriority", "1.0"
                      "rgbcolor2", "0.9 0.83 0.77"
                      "sizegrowth", "1.5"
                      "soundhitwet", "sizzle"
                      "soundtrigger", "false"
                      "sprayangle", "100.0"
                      "targetmoveerror", "0.001"
                      "weapontimer", "1.0"
                  ] }
            ]
          customParams = Map.ofList [
                "maxrange", "200"
                "subfolder", "other/raptors"
                "model_author", "KDR_11k, Beherith"
                "normalmaps", "yes"
                "normaltex", "unittextures/chicken_m_normals.png"
            ]
          extras = Map.ofList [
                "autoheal", "27.0"
                "canguard", "true"
                "canpatrol", "true"
                "canstop", "1"
                "capturable", "false"
                "defaultmissiontype", "Standby"
                "leavetracks", "true"
                "maneuverleashlength", "640"
                "mass", "1800.0"
                "noautofire", "false"
                "nochasecategory", "VTOL"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "trackoffset", "0.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrack"
                "trackwidth", "50.0"
                "unitname", "raptorp1"
                "upright", "false"
            ] }

