// Auto-generated BAR unit data: other/raptors/Swarmer/AllTerrain (flat per-unit types)
namespace BarData.Units

open BarData

module other_raptors_Swarmer_AllTerrain =

    type Raptor_6legged_l =
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

    let raptor_6legged_l : Raptor_6legged_l =
        { name = "raptor_6legged_l"
          subfolder = "other/raptors/Swarmer/AllTerrain"
          metalCost = ValueOrExpr.Concrete 99.0
          energyCost = ValueOrExpr.Concrete 5280.0
          buildTime = ValueOrExpr.Concrete 1875.0
          health = ValueOrExpr.Concrete 2650.0
          sightDistance = ValueOrExpr.Concrete 200.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 63.0
          maxAcc = 1.4375
          maxDec = 2.3
          turnRate = 1840.0
          movementClass = "RAPTORALLTERRAINHOVER"
          maxSlope = 18.0
          maxWaterDepth = 15.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 16.0
          weapons = [
                { name = "weapon"
                  displayName = Some "Claws"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 700.0
                  ]
                  range = Some (ValueOrExpr.Concrete 200.0)
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
                      "mount_maxangledif", "110.0"
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
                "model_author", "Kremenchuk, Beherith"
                "normalmaps", "yes"
                "normaltex", "unittextures/chicken_l_normals.png"
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
                "unitname", "raptor_6legged_l"
                "upright", "false"
            ] }

    type Raptor_allterrain_swarmer_basic_t2_v1 =
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

    let raptor_allterrain_swarmer_basic_t2_v1 : Raptor_allterrain_swarmer_basic_t2_v1 =
        { name = "raptor_allterrain_swarmer_basic_t2_v1"
          subfolder = "other/raptors/Swarmer/AllTerrain"
          metalCost = ValueOrExpr.Concrete 99.0
          energyCost = ValueOrExpr.Concrete 5280.0
          buildTime = ValueOrExpr.Concrete 2250.0
          health = ValueOrExpr.Concrete 890.0
          sightDistance = ValueOrExpr.Concrete 200.0
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
                { name = "weapon"
                  displayName = Some "Claws"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 150.0
                  ]
                  range = Some (ValueOrExpr.Concrete 200.0)
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
                      "mount_maxangledif", "110.0"
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
                "unitname", "raptor_allterrain_swarmer_basic_t2_v1"
                "upright", "false"
            ] }

    type Raptor_allterrain_swarmer_basic_t3_v1 =
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

    let raptor_allterrain_swarmer_basic_t3_v1 : Raptor_allterrain_swarmer_basic_t3_v1 =
        { name = "raptor_allterrain_swarmer_basic_t3_v1"
          subfolder = "other/raptors/Swarmer/AllTerrain"
          metalCost = ValueOrExpr.Concrete 99.0
          energyCost = ValueOrExpr.Concrete 5280.0
          buildTime = ValueOrExpr.Concrete 2625.0
          health = ValueOrExpr.Concrete 1780.0
          sightDistance = ValueOrExpr.Concrete 200.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 105.0
          maxAcc = 1.4375
          maxDec = 2.3
          turnRate = 1840.0
          movementClass = "RAPTORALLTERRAINHOVER"
          maxSlope = 18.0
          maxWaterDepth = 15.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 13.0
          weapons = [
                { name = "weapon"
                  displayName = Some "Claws"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 250.0
                  ]
                  range = Some (ValueOrExpr.Concrete 200.0)
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
                      "mount_maxangledif", "110.0"
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
                "unitname", "raptor_allterrain_swarmer_basic_t3_v1"
                "upright", "false"
            ] }

    type Raptor_allterrain_swarmer_basic_t4_v1 =
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

    let raptor_allterrain_swarmer_basic_t4_v1 : Raptor_allterrain_swarmer_basic_t4_v1 =
        { name = "raptor_allterrain_swarmer_basic_t4_v1"
          subfolder = "other/raptors/Swarmer/AllTerrain"
          metalCost = ValueOrExpr.Concrete 99.0
          energyCost = ValueOrExpr.Concrete 5280.0
          buildTime = ValueOrExpr.Concrete 1875.0
          health = ValueOrExpr.Concrete 2650.0
          sightDistance = ValueOrExpr.Concrete 200.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 96.0
          maxAcc = 1.4375
          maxDec = 2.3
          turnRate = 1840.0
          movementClass = "RAPTORALLTERRAINHOVER"
          maxSlope = 18.0
          maxWaterDepth = 15.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 16.0
          weapons = [
                { name = "weapon"
                  displayName = Some "Claws"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 350.0
                  ]
                  range = Some (ValueOrExpr.Concrete 200.0)
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
                      "mount_maxangledif", "110.0"
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
                "unitname", "raptor_allterrain_swarmer_basic_t4_v1"
                "upright", "false"
            ] }

