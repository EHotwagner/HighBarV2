// Auto-generated BAR unit data: other/raptors/Arty (flat per-unit types)
namespace BarData.Units

open BarData

module other_raptors_Arty =

    type Raptor_allterrain_arty_basic_t2_v1 =
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

    let raptor_allterrain_arty_basic_t2_v1 : Raptor_allterrain_arty_basic_t2_v1 =
        { name = "raptor_allterrain_arty_basic_t2_v1"
          subfolder = "other/raptors/Arty"
          metalCost = ValueOrExpr.Concrete 396.0
          energyCost = ValueOrExpr.Concrete 12320.0
          buildTime = ValueOrExpr.Concrete 6750.0
          health = ValueOrExpr.Concrete 2000.0
          sightDistance = ValueOrExpr.Concrete 750.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 42.0
          maxAcc = 0.115
          maxDec = 0.414
          turnRate = 1840.0
          movementClass = "RAPTORALLTERRAINBIGHOVER"
          maxSlope = 18.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 10.0
          weapons = [
                { name = "goolauncher"
                  displayName = Some "GOOLAUNCHER"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 1280.0
                      "shields", 320.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1500.0)
                  reloadTime = Some (ValueOrExpr.Concrete 20.0)
                  weaponVelocity = Some 520.0
                  areaOfEffect = Some 256.0
                  accuracy = Some 1024.0
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.63
                  impulseFactor = Some 0.4
                  noSelfDamage = Some true
                  soundStart = Some "bugarty"
                  soundHit = Some "bombsmed2"
                  explosiongenerator = Some "custom:genericshellexplosion-huge"
                  rgbColor = Some "1 0.5 0.1"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "MOBILE"
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "50.0"
                      "mount_onlytargetcategory", "NOTAIR"
                      "collidefriendly", "0.0"
                      "collidefeature", "0.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "burst", "1.0"
                      "burstrate", "0.001"
                      "cegtag", "blob_trail_red"
                      "craterareaofeffect", "256.0"
                      "craterboost", "0.2"
                      "cratermult", "0.2"
                      "intensity", "0.7"
                      "interceptedbyshieldtype", "1.0"
                      "proximitypriority", "-1.0"
                      "size", "5.5"
                      "sizedecay", "0.09"
                      "sprayangle", "1024.0"
                      "weapontimer", "0.2"
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
                "hidedamage", "1.0"
                "leavetracks", "true"
                "maneuverleashlength", "640"
                "mass", "4000.0"
                "noautofire", "false"
                "nochasecategory", "VTOL"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "trackoffset", "6.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrack"
                "trackwidth", "30.0"
                "unitname", "raptorr1"
                "upright", "false"
            ] }

    type Raptor_allterrain_arty_basic_t4_v1 =
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

    let raptor_allterrain_arty_basic_t4_v1 : Raptor_allterrain_arty_basic_t4_v1 =
        { name = "raptor_allterrain_arty_basic_t4_v1"
          subfolder = "other/raptors/Arty"
          metalCost = ValueOrExpr.Concrete 396.0
          energyCost = ValueOrExpr.Concrete 12320.0
          buildTime = ValueOrExpr.Concrete 270000.0
          health = ValueOrExpr.Concrete 8000.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 4.0
          footprintZ = 4.0
          speed = ValueOrExpr.Concrete 84.0
          maxAcc = 1.15
          maxDec = 9.2
          turnRate = 600.0
          movementClass = "RAPTORALLTERRAINBIG2HOVER"
          maxSlope = 18.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 10.0
          weapons = [
                { name = "goolauncher"
                  displayName = Some "GOOLAUNCHER"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 1280.0
                      "shields", 320.0
                  ]
                  range = Some (ValueOrExpr.Concrete 2000.0)
                  reloadTime = Some (ValueOrExpr.Concrete 20.0)
                  weaponVelocity = Some 520.0
                  areaOfEffect = Some 256.0
                  accuracy = Some 2048.0
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.63
                  impulseFactor = Some 0.4
                  noSelfDamage = Some true
                  soundStart = Some "bugarty"
                  soundHit = Some "bombsmed2"
                  explosiongenerator = Some "custom:genericshellexplosion-huge"
                  rgbColor = Some "1 0.5 0.1"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "MOBILE"
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "50.0"
                      "mount_onlytargetcategory", "NOTAIR"
                      "collidefriendly", "0.0"
                      "collidefeature", "0.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "burst", "4.0"
                      "burstrate", "0.001"
                      "cegtag", "blob_trail_red"
                      "craterareaofeffect", "256.0"
                      "craterboost", "0.2"
                      "cratermult", "0.2"
                      "intensity", "0.7"
                      "interceptedbyshieldtype", "1.0"
                      "proximitypriority", "-1.0"
                      "size", "5.5"
                      "sizedecay", "0.09"
                      "sprayangle", "2048.0"
                      "weapontimer", "0.2"
                  ] }
            ]
          customParams = Map.ofList [
                "subfolder", "other/raptors"
                "model_author", "KDR_11k, Beherith"
                "normalmaps", "yes"
                "normaltex", "unittextures/chicken_l_normals.png"
            ]
          extras = Map.ofList [
                "canattack", "true"
                "canguard", "true"
                "canpatrol", "true"
                "canstop", "1"
                "capturable", "false"
                "collisionvolumetest", "1.0"
                "defaultmissiontype", "Standby"
                "hidedamage", "1.0"
                "leavetracks", "true"
                "maneuverleashlength", "640"
                "mass", "40000.0"
                "noautofire", "false"
                "nochasecategory", "VTOL"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "trackoffset", "6.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrack"
                "trackwidth", "100.0"
                "unitname", "raptorr2"
                "upright", "false"
            ] }

    type Raptorartillery =
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

    let raptorartillery : Raptorartillery =
        { name = "raptorartillery"
          subfolder = "other/raptors/Arty"
          metalCost = ValueOrExpr.Concrete 396.0
          energyCost = ValueOrExpr.Concrete 12320.0
          buildTime = ValueOrExpr.Concrete 6750.0
          health = ValueOrExpr.Concrete 2000.0
          sightDistance = ValueOrExpr.Concrete 750.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 42.0
          maxAcc = 0.115
          maxDec = 0.414
          turnRate = 1840.0
          movementClass = "RAPTORALLTERRAINBIGHOVER"
          maxSlope = 18.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 10.0
          weapons = [
                { name = "goolauncher"
                  displayName = Some "GOOLAUNCHER"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 1280.0
                      "shields", 320.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1500.0)
                  reloadTime = Some (ValueOrExpr.Concrete 20.0)
                  weaponVelocity = Some 520.0
                  areaOfEffect = Some 256.0
                  accuracy = Some 1024.0
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.63
                  impulseFactor = Some 0.4
                  noSelfDamage = Some true
                  soundStart = Some "bugarty"
                  soundHit = Some "bombsmed2"
                  explosiongenerator = Some "custom:genericshellexplosion-huge"
                  rgbColor = Some "1 0.5 0.1"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "MOBILE"
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "50.0"
                      "mount_onlytargetcategory", "NOTAIR"
                      "collidefriendly", "0.0"
                      "collidefeature", "0.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "burst", "1.0"
                      "burstrate", "0.001"
                      "cegtag", "blob_trail_red"
                      "craterareaofeffect", "256.0"
                      "craterboost", "0.2"
                      "cratermult", "0.2"
                      "intensity", "0.7"
                      "interceptedbyshieldtype", "1.0"
                      "proximitypriority", "-1.0"
                      "size", "5.5"
                      "sizedecay", "0.09"
                      "sprayangle", "1024.0"
                      "weapontimer", "0.2"
                  ] }
            ]
          customParams = Map.ofList [
                "subfolder", "other/raptors"
                "model_author", "Rubus"
                "normalmaps", "yes"
                "normaltex", "unittextures/raptorArtillery_n.png"
                "useskinning", "yes"
            ]
          extras = Map.ofList [
                "canattack", "true"
                "canguard", "true"
                "canpatrol", "true"
                "canstop", "1"
                "capturable", "false"
                "defaultmissiontype", "Standby"
                "hidedamage", "1.0"
                "leavetracks", "true"
                "maneuverleashlength", "640"
                "mass", "4000.0"
                "noautofire", "false"
                "nochasecategory", "VTOL"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "trackoffset", "6.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrack"
                "trackwidth", "30.0"
                "unitname", "raptorartillery"
                "upright", "false"
            ] }

