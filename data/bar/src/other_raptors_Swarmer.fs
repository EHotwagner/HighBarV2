// Auto-generated BAR unit data: other/raptors/Swarmer (flat per-unit types)
namespace BarData.Units

open BarData

module other_raptors_Swarmer =

    type Raptor_land_swarmer_basic_t1_v1 =
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

    let raptor_land_swarmer_basic_t1_v1 : Raptor_land_swarmer_basic_t1_v1 =
        { name = "raptor_land_swarmer_basic_t1_v1"
          subfolder = "other/raptors/Swarmer"
          metalCost = ValueOrExpr.Concrete 25.0
          energyCost = ValueOrExpr.Concrete 53.0
          buildTime = ValueOrExpr.Concrete 900.0
          health = ValueOrExpr.Concrete 167.0
          sightDistance = ValueOrExpr.Concrete 150.0
          footprintX = 1.5
          footprintZ = 1.5
          speed = ValueOrExpr.Concrete 105.0
          maxAcc = 0.1725
          maxDec = 0.345
          turnRate = 1840.0
          movementClass = "RAPTORSMALLHOVER"
          maxSlope = 18.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 9.5
          weapons = [
                { name = "weapon"
                  displayName = Some "Claws"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 75.0
                  ]
                  range = Some (ValueOrExpr.Concrete 150.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.0)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 24.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.3
                  impulseFactor = Some 1.0
                  noSelfDamage = Some true
                  soundStart = Some "smallraptorattack"
                  soundHit = None
                  explosiongenerator = Some "custom:raptorspike-small-sparks-burn"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "180.0"
                      "collidefriendly", "0.0"
                      "collidefeature", "0.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firesubmersed", "true"
                      "interceptedbyshieldtype", "0.0"
                      "model", "Raptors/spike.s3o"
                      "waterweapon", "true"
                      "weapontimer", "0.1"
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
                "maneuverleashlength", "640.0"
                "mass", "30.0"
                "noautofire", "false"
                "nochasecategory", "VTOL"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "trackoffset", "0.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrack"
                "trackwidth", "18.0"
                "unitname", "raptor1"
                "upright", "false"
            ] }

    type Raptor_land_swarmer_basic_t2_v1 =
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

    let raptor_land_swarmer_basic_t2_v1 : Raptor_land_swarmer_basic_t2_v1 =
        { name = "raptor_land_swarmer_basic_t2_v1"
          subfolder = "other/raptors/Swarmer"
          metalCost = ValueOrExpr.Concrete 25.0
          energyCost = ValueOrExpr.Concrete 53.0
          buildTime = ValueOrExpr.Concrete 900.0
          health = ValueOrExpr.Concrete 530.0
          sightDistance = ValueOrExpr.Concrete 200.0
          footprintX = 1.5
          footprintZ = 1.5
          speed = ValueOrExpr.Concrete 105.0
          maxAcc = 0.1725
          maxDec = 0.345
          turnRate = 1840.0
          movementClass = "RAPTORSMALLHOVER"
          maxSlope = 18.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 19.0
          weapons = [
                { name = "weapon"
                  displayName = Some "Claws"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 200.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.2)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 24.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.3
                  impulseFactor = Some 1.0
                  noSelfDamage = Some true
                  soundStart = Some "smallraptorattack"
                  soundHit = None
                  explosiongenerator = Some "custom:raptorspike-small-sparks-burn"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "180.0"
                      "collidefriendly", "0.0"
                      "collidefeature", "0.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firesubmersed", "true"
                      "interceptedbyshieldtype", "0.0"
                      "model", "Raptors/spike.s3o"
                      "waterweapon", "true"
                      "weapontimer", "0.1"
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
                "maneuverleashlength", "640.0"
                "mass", "30.0"
                "noautofire", "false"
                "nochasecategory", "VTOL"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "trackoffset", "0.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrack"
                "trackwidth", "18.0"
                "unitname", "raptor_land_swarmer_basic_t2_v1"
                "upright", "false"
            ] }

    type Raptor_land_swarmer_basic_t2_v2 =
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

    let raptor_land_swarmer_basic_t2_v2 : Raptor_land_swarmer_basic_t2_v2 =
        { name = "raptor_land_swarmer_basic_t2_v2"
          subfolder = "other/raptors/Swarmer"
          metalCost = ValueOrExpr.Concrete 25.0
          energyCost = ValueOrExpr.Concrete 53.0
          buildTime = ValueOrExpr.Concrete 1050.0
          health = ValueOrExpr.Concrete 495.0
          sightDistance = ValueOrExpr.Concrete 200.0
          footprintX = 1.0
          footprintZ = 1.0
          speed = ValueOrExpr.Concrete 105.0
          maxAcc = 0.345
          maxDec = 0.345
          turnRate = 1840.0
          movementClass = "RAPTORSMALLHOVER"
          maxSlope = 18.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 19.0
          weapons = [
                { name = "weapon"
                  displayName = Some "Claws"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 80.0
                  ]
                  range = Some (ValueOrExpr.Concrete 200.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.2)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 24.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.3
                  impulseFactor = Some 1.0
                  noSelfDamage = Some true
                  soundStart = Some "smallraptorattack"
                  soundHit = None
                  explosiongenerator = Some "custom:raptorspike-small-sparks-burn"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "180.0"
                      "collidefriendly", "0.0"
                      "collidefeature", "0.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firesubmersed", "true"
                      "interceptedbyshieldtype", "0.0"
                      "model", "Raptors/spike.s3o"
                      "waterweapon", "true"
                      "weapontimer", "0.1"
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
                "maneuverleashlength", "640.0"
                "mass", "35.0"
                "noautofire", "false"
                "nochasecategory", "VTOL"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "trackoffset", "0.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrack"
                "trackwidth", "18.0"
                "unitname", "raptor_land_swarmer_basic_t2_v2"
                "upright", "false"
            ] }

    type Raptor_land_swarmer_basic_t2_v3 =
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

    let raptor_land_swarmer_basic_t2_v3 : Raptor_land_swarmer_basic_t2_v3 =
        { name = "raptor_land_swarmer_basic_t2_v3"
          subfolder = "other/raptors/Swarmer"
          metalCost = ValueOrExpr.Concrete 25.0
          energyCost = ValueOrExpr.Concrete 53.0
          buildTime = ValueOrExpr.Concrete 1200.0
          health = ValueOrExpr.Concrete 470.0
          sightDistance = ValueOrExpr.Concrete 200.0
          footprintX = 1.0
          footprintZ = 1.0
          speed = ValueOrExpr.Concrete 105.0
          maxAcc = 0.1725
          maxDec = 0.575
          turnRate = 1840.0
          movementClass = "RAPTORSMALLHOVER"
          maxSlope = 18.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 19.0
          weapons = [
                { name = "weapon"
                  displayName = Some "Claws"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 90.0
                  ]
                  range = Some (ValueOrExpr.Concrete 200.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.2)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 24.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.3
                  impulseFactor = Some 1.0
                  noSelfDamage = Some true
                  soundStart = Some "smallraptorattack"
                  soundHit = None
                  explosiongenerator = Some "custom:raptorspike-small-sparks-burn"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "180.0"
                      "collidefriendly", "0.0"
                      "collidefeature", "0.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firesubmersed", "true"
                      "interceptedbyshieldtype", "0.0"
                      "model", "Raptors/spike.s3o"
                      "waterweapon", "true"
                      "weapontimer", "0.1"
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
                "maneuverleashlength", "640.0"
                "mass", "40.0"
                "noautofire", "false"
                "nochasecategory", "VTOL"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "trackoffset", "0.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrack"
                "trackwidth", "18.0"
                "unitname", "raptor_land_swarmer_basic_t2_v3"
                "upright", "false"
            ] }

    type Raptor_land_swarmer_basic_t2_v4 =
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

    let raptor_land_swarmer_basic_t2_v4 : Raptor_land_swarmer_basic_t2_v4 =
        { name = "raptor_land_swarmer_basic_t2_v4"
          subfolder = "other/raptors/Swarmer"
          metalCost = ValueOrExpr.Concrete 25.0
          energyCost = ValueOrExpr.Concrete 53.0
          buildTime = ValueOrExpr.Concrete 1350.0
          health = ValueOrExpr.Concrete 430.0
          sightDistance = ValueOrExpr.Concrete 200.0
          footprintX = 1.0
          footprintZ = 1.0
          speed = ValueOrExpr.Concrete 105.0
          maxAcc = 0.345
          maxDec = 0.345
          turnRate = 1840.0
          movementClass = "RAPTORSMALLHOVER"
          maxSlope = 18.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 19.0
          weapons = [
                { name = "weapon"
                  displayName = Some "Claws"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 120.0
                  ]
                  range = Some (ValueOrExpr.Concrete 200.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.13333)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 24.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.3
                  impulseFactor = Some 1.0
                  noSelfDamage = Some true
                  soundStart = Some "smallraptorattack"
                  soundHit = None
                  explosiongenerator = Some "custom:raptorspike-small-sparks-burn"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "180.0"
                      "collidefriendly", "0.0"
                      "collidefeature", "0.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firesubmersed", "true"
                      "interceptedbyshieldtype", "0.0"
                      "model", "Raptors/spike.s3o"
                      "waterweapon", "true"
                      "weapontimer", "0.1"
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
                "maneuverleashlength", "640.0"
                "mass", "45.0"
                "noautofire", "false"
                "nochasecategory", "VTOL"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "trackoffset", "0.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrack"
                "trackwidth", "18.0"
                "unitname", "raptor_land_swarmer_basic_t2_v4"
                "upright", "false"
            ] }

    type Raptor_land_swarmer_basic_t3_v1 =
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

    let raptor_land_swarmer_basic_t3_v1 : Raptor_land_swarmer_basic_t3_v1 =
        { name = "raptor_land_swarmer_basic_t3_v1"
          subfolder = "other/raptors/Swarmer"
          metalCost = ValueOrExpr.Concrete 79.0
          energyCost = ValueOrExpr.Concrete 79.0
          buildTime = ValueOrExpr.Concrete 1500.0
          health = ValueOrExpr.Concrete 1110.0
          sightDistance = ValueOrExpr.Concrete 200.0
          footprintX = 1.0
          footprintZ = 1.0
          speed = ValueOrExpr.Concrete 150.0
          maxAcc = 0.345
          maxDec = 0.345
          turnRate = 1840.0
          movementClass = "RAPTORSMALLHOVER"
          maxSlope = 18.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 19.0
          weapons = [
                { name = "weapon"
                  displayName = Some "Claws"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 120.0
                  ]
                  range = Some (ValueOrExpr.Concrete 200.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.9)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 24.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.3
                  impulseFactor = Some 1.0
                  noSelfDamage = Some true
                  soundStart = Some "smallraptorattack"
                  soundHit = None
                  explosiongenerator = Some "custom:raptorspike-small-sparks-burn"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "180.0"
                      "collidefriendly", "0.0"
                      "collidefeature", "0.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firesubmersed", "true"
                      "interceptedbyshieldtype", "0.0"
                      "model", "Raptors/spike.s3o"
                      "waterweapon", "true"
                      "weapontimer", "0.1"
                  ] }
            ]
          customParams = Map.ofList [
                "subfolder", "other/raptors"
                "model_author", "KDR_11k, Beherith"
                "normalmaps", "yes"
                "normaltex", "unittextures/chicken_s_normals.png"
            ]
          extras = Map.ofList [
                "autoheal", "3.0"
                "canattack", "true"
                "canguard", "true"
                "canpatrol", "true"
                "canstop", "1"
                "capturable", "false"
                "defaultmissiontype", "Standby"
                "leavetracks", "true"
                "maneuverleashlength", "640.0"
                "mass", "90.0"
                "noautofire", "false"
                "nochasecategory", "VTOL"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "trackoffset", "0.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrack"
                "trackwidth", "18.0"
                "unitname", "raptor_land_swarmer_basic_t3_v1"
                "upright", "false"
            ] }

    type Raptor_land_swarmer_basic_t3_v2 =
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

    let raptor_land_swarmer_basic_t3_v2 : Raptor_land_swarmer_basic_t3_v2 =
        { name = "raptor_land_swarmer_basic_t3_v2"
          subfolder = "other/raptors/Swarmer"
          metalCost = ValueOrExpr.Concrete 79.0
          energyCost = ValueOrExpr.Concrete 79.0
          buildTime = ValueOrExpr.Concrete 1650.0
          health = ValueOrExpr.Concrete 1080.0
          sightDistance = ValueOrExpr.Concrete 200.0
          footprintX = 1.0
          footprintZ = 1.0
          speed = ValueOrExpr.Concrete 150.0
          maxAcc = 0.345
          maxDec = 0.345
          turnRate = 1840.0
          movementClass = "RAPTORSMALLHOVER"
          maxSlope = 18.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 19.0
          weapons = [
                { name = "weapon"
                  displayName = Some "Claws"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 110.0
                  ]
                  range = Some (ValueOrExpr.Concrete 200.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.86667)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 24.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.3
                  impulseFactor = Some 1.0
                  noSelfDamage = Some true
                  soundStart = Some "smallraptorattack"
                  soundHit = None
                  explosiongenerator = Some "custom:raptorspike-small-sparks-burn"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "180.0"
                      "collidefriendly", "0.0"
                      "collidefeature", "0.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firesubmersed", "true"
                      "interceptedbyshieldtype", "0.0"
                      "model", "Raptors/spike.s3o"
                      "waterweapon", "true"
                      "weapontimer", "0.1"
                  ] }
            ]
          customParams = Map.ofList [
                "subfolder", "other/raptors"
                "model_author", "KDR_11k, Beherith"
                "normalmaps", "yes"
                "normaltex", "unittextures/chicken_s_normals.png"
            ]
          extras = Map.ofList [
                "autoheal", "3.0"
                "canattack", "true"
                "canguard", "true"
                "canpatrol", "true"
                "canstop", "1"
                "capturable", "false"
                "defaultmissiontype", "Standby"
                "leavetracks", "true"
                "maneuverleashlength", "640.0"
                "mass", "80.0"
                "noautofire", "false"
                "nochasecategory", "VTOL"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "trackoffset", "0.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrack"
                "trackwidth", "18.0"
                "unitname", "raptor_land_swarmer_basic_t3_v2"
                "upright", "false"
            ] }

    type Raptor_land_swarmer_basic_t3_v3 =
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

    let raptor_land_swarmer_basic_t3_v3 : Raptor_land_swarmer_basic_t3_v3 =
        { name = "raptor_land_swarmer_basic_t3_v3"
          subfolder = "other/raptors/Swarmer"
          metalCost = ValueOrExpr.Concrete 79.0
          energyCost = ValueOrExpr.Concrete 79.0
          buildTime = ValueOrExpr.Concrete 1800.0
          health = ValueOrExpr.Concrete 1060.0
          sightDistance = ValueOrExpr.Concrete 200.0
          footprintX = 1.0
          footprintZ = 1.0
          speed = ValueOrExpr.Concrete 150.0
          maxAcc = 0.575
          maxDec = 0.345
          turnRate = 1840.0
          movementClass = "RAPTORSMALLHOVER"
          maxSlope = 18.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 19.0
          weapons = [
                { name = "weapon"
                  displayName = Some "Claws"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 200.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.8)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 24.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.3
                  impulseFactor = Some 1.0
                  noSelfDamage = Some true
                  soundStart = Some "smallraptorattack"
                  soundHit = None
                  explosiongenerator = Some "custom:raptorspike-small-sparks-burn"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "180.0"
                      "collidefriendly", "0.0"
                      "collidefeature", "0.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firesubmersed", "true"
                      "interceptedbyshieldtype", "0.0"
                      "model", "Raptors/spike.s3o"
                      "waterweapon", "true"
                      "weapontimer", "0.1"
                  ] }
            ]
          customParams = Map.ofList [
                "subfolder", "other/raptors"
                "model_author", "KDR_11k, Beherith"
                "normalmaps", "yes"
                "normaltex", "unittextures/chicken_s_normals.png"
            ]
          extras = Map.ofList [
                "autoheal", "3.0"
                "canattack", "true"
                "canguard", "true"
                "canpatrol", "true"
                "canstop", "1"
                "capturable", "false"
                "defaultmissiontype", "Standby"
                "leavetracks", "true"
                "maneuverleashlength", "640.0"
                "mass", "70.0"
                "noautofire", "false"
                "nochasecategory", "VTOL"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "trackoffset", "0.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrack"
                "trackwidth", "18.0"
                "unitname", "raptor_land_swarmer_basic_t3_v3"
                "upright", "false"
            ] }

