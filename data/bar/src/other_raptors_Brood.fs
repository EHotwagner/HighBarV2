// Auto-generated BAR unit data: other/raptors/Brood (flat per-unit types)
namespace BarData.Units

open BarData

module other_raptors_Brood =

    type Raptor_air_bomber_brood_t4_v2 =
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
          canFly: bool
          canMove: bool
          turnInPlace: bool
          cruiseAltitude: float
          weapons: WeaponDef list
          customParams: Map<string, string>
          extras: Map<string, string> }

    let raptor_air_bomber_brood_t4_v2 : Raptor_air_bomber_brood_t4_v2 =
        { name = "raptor_air_bomber_brood_t4_v2"
          subfolder = "other/raptors/Brood"
          metalCost = ValueOrExpr.Concrete 212.0
          energyCost = ValueOrExpr.Concrete 4550.0
          buildTime = ValueOrExpr.Concrete 9375.0
          health = ValueOrExpr.Concrete 1500.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 240.0
          maxAcc = 0.25
          maxDec = 0.1
          turnRate = 1600.0
          canFly = true
          canMove = true
          turnInPlace = true
          cruiseAltitude = 220.0
          weapons = [
                { name = "bloodyeggs"
                  displayName = Some "GooBombs"
                  weaponType = Some "AircraftBomb"
                  damage = Map.ofList [
                      "default", 1.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1500.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.1)
                  weaponVelocity = None
                  areaOfEffect = Some 128.0
                  accuracy = Some 500000.0
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.45
                  impulseFactor = Some 1.0
                  noSelfDamage = Some true
                  soundStart = Some "alien_bombrel"
                  soundHit = Some "smallraptorattack"
                  explosiongenerator = Some "custom:dirt"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.ofList [
                      "spawns_name", "raptor_land_swarmer_brood_t4_v1"
                      "spawns_surface", "LAND SEA"
                  ]
                  extras = Map.ofList [
                      "collidefriendly", "0.0"
                      "collidefeature", "0.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "burst", "1.0"
                      "burstrate", "0.033"
                      "canattackground", "false"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "interceptedbyshieldtype", "0.0"
                      "model", "Raptors/s_raptorboss_white.s3o"
                      "mygravity", "0.5"
                      "sprayangle", "1000000.0"
                  ] }
            ]
          customParams = Map.ofList [
                "subfolder", "other/raptors"
                "model_author", "KDR_11k, Beherith"
                "normalmaps", "yes"
                "normaltex", "unittextures/chicken_l_normals.png"
            ]
          extras = Map.ofList [
                "acceleration", "0.8"
                "airhoverfactor", "0.0"
                "attackrunlength", "32.0"
                "canattack", "true"
                "canguard", "true"
                "canland", "true"
                "canloopbackattack", "true"
                "canpatrol", "true"
                "canstop", "1"
                "cansubmerge", "true"
                "capturable", "false"
                "collide", "true"
                "defaultmissiontype", "Standby"
                "hidedamage", "1.0"
                "maneuverleashlength", "20000"
                "mass", "227.5"
                "maxaileron", "0.025"
                "maxbank", "0.8"
                "maxelevator", "0.025"
                "maxpitch", "0.75"
                "maxrudder", "0.025"
                "moverate1", "32"
                "noautofire", "false"
                "nochasecategory", "VTOL"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "speedtofront", "0.07"
                "turnradius", "64.0"
                "unitname", "raptorbroodbomber"
                "usesmoothmesh", "true"
                "wingangle", "0.06593"
                "wingdrag", "0.835"
            ] }

    type Raptor_air_bomber_brood_t4_v3 =
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
          canFly: bool
          canMove: bool
          turnInPlace: bool
          cruiseAltitude: float
          weapons: WeaponDef list
          customParams: Map<string, string>
          extras: Map<string, string> }

    let raptor_air_bomber_brood_t4_v3 : Raptor_air_bomber_brood_t4_v3 =
        { name = "raptor_air_bomber_brood_t4_v3"
          subfolder = "other/raptors/Brood"
          metalCost = ValueOrExpr.Concrete 212.0
          energyCost = ValueOrExpr.Concrete 4550.0
          buildTime = ValueOrExpr.Concrete 9375.0
          health = ValueOrExpr.Concrete 1500.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 240.0
          maxAcc = 0.25
          maxDec = 0.1
          turnRate = 1600.0
          canFly = true
          canMove = true
          turnInPlace = true
          cruiseAltitude = 220.0
          weapons = [
                { name = "bloodyeggs"
                  displayName = Some "GooBombs"
                  weaponType = Some "AircraftBomb"
                  damage = Map.ofList [
                      "default", 1.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1500.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.1)
                  weaponVelocity = None
                  areaOfEffect = Some 128.0
                  accuracy = Some 500000.0
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.45
                  impulseFactor = Some 1.0
                  noSelfDamage = Some true
                  soundStart = Some "alien_bombrel"
                  soundHit = Some "smallraptorattack"
                  explosiongenerator = Some "custom:dirt"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.ofList [
                      "spawns_name", "raptor_land_swarmer_brood_t3_v1"
                      "spawns_surface", "LAND SEA"
                  ]
                  extras = Map.ofList [
                      "collidefriendly", "0.0"
                      "collidefeature", "0.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "burst", "2.0"
                      "burstrate", "0.5"
                      "canattackground", "false"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "interceptedbyshieldtype", "0.0"
                      "model", "Raptors/s_raptorboss2_white.s3o"
                      "mygravity", "0.5"
                      "sprayangle", "1000000.0"
                  ] }
            ]
          customParams = Map.ofList [
                "subfolder", "other/raptors"
                "model_author", "KDR_11k, Beherith"
                "normalmaps", "yes"
                "normaltex", "unittextures/chicken_l_normals.png"
            ]
          extras = Map.ofList [
                "acceleration", "0.8"
                "airhoverfactor", "0.0"
                "attackrunlength", "32.0"
                "canattack", "true"
                "canguard", "true"
                "canland", "true"
                "canloopbackattack", "true"
                "canpatrol", "true"
                "canstop", "1"
                "cansubmerge", "true"
                "capturable", "false"
                "collide", "true"
                "defaultmissiontype", "Standby"
                "hidedamage", "1.0"
                "maneuverleashlength", "20000"
                "mass", "227.5"
                "maxaileron", "0.025"
                "maxbank", "0.8"
                "maxelevator", "0.025"
                "maxpitch", "0.75"
                "maxrudder", "0.025"
                "moverate1", "32"
                "noautofire", "false"
                "nochasecategory", "VTOL"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "speedtofront", "0.07"
                "turnradius", "64.0"
                "unitname", "raptorbroodbomber"
                "usesmoothmesh", "true"
                "wingangle", "0.06593"
                "wingdrag", "0.835"
            ] }

    type Raptor_air_bomber_brood_t4_v4 =
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
          canFly: bool
          canMove: bool
          turnInPlace: bool
          cruiseAltitude: float
          weapons: WeaponDef list
          customParams: Map<string, string>
          extras: Map<string, string> }

    let raptor_air_bomber_brood_t4_v4 : Raptor_air_bomber_brood_t4_v4 =
        { name = "raptor_air_bomber_brood_t4_v4"
          subfolder = "other/raptors/Brood"
          metalCost = ValueOrExpr.Concrete 212.0
          energyCost = ValueOrExpr.Concrete 4550.0
          buildTime = ValueOrExpr.Concrete 9375.0
          health = ValueOrExpr.Concrete 1500.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 240.0
          maxAcc = 0.25
          maxDec = 0.1
          turnRate = 1600.0
          canFly = true
          canMove = true
          turnInPlace = true
          cruiseAltitude = 220.0
          weapons = [
                { name = "bloodyeggs"
                  displayName = Some "GooBombs"
                  weaponType = Some "AircraftBomb"
                  damage = Map.ofList [
                      "default", 1.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1500.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.1)
                  weaponVelocity = None
                  areaOfEffect = Some 128.0
                  accuracy = Some 500000.0
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.45
                  impulseFactor = Some 1.0
                  noSelfDamage = Some true
                  soundStart = Some "alien_bombrel"
                  soundHit = Some "smallraptorattack"
                  explosiongenerator = Some "custom:dirt"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.ofList [
                      "spawns_name", "raptor_land_swarmer_brood_t2_v1"
                      "spawns_surface", "LAND SEA"
                  ]
                  extras = Map.ofList [
                      "collidefriendly", "0.0"
                      "collidefeature", "0.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "burst", "8.0"
                      "burstrate", "0.033"
                      "canattackground", "false"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "interceptedbyshieldtype", "0.0"
                      "model", "Raptors/s_raptor_white.s3o"
                      "mygravity", "0.5"
                      "sprayangle", "1000000.0"
                  ] }
            ]
          customParams = Map.ofList [
                "subfolder", "other/raptors"
                "model_author", "KDR_11k, Beherith"
                "normalmaps", "yes"
                "normaltex", "unittextures/chicken_l_normals.png"
            ]
          extras = Map.ofList [
                "acceleration", "0.8"
                "airhoverfactor", "0.0"
                "attackrunlength", "32.0"
                "canattack", "true"
                "canguard", "true"
                "canland", "true"
                "canloopbackattack", "true"
                "canpatrol", "true"
                "canstop", "1"
                "cansubmerge", "true"
                "capturable", "false"
                "collide", "true"
                "defaultmissiontype", "Standby"
                "hidedamage", "1.0"
                "maneuverleashlength", "20000"
                "mass", "227.5"
                "maxaileron", "0.025"
                "maxbank", "0.8"
                "maxelevator", "0.025"
                "maxpitch", "0.75"
                "maxrudder", "0.025"
                "moverate1", "32"
                "noautofire", "false"
                "nochasecategory", "VTOL"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "speedtofront", "0.07"
                "turnradius", "64.0"
                "unitname", "raptorbroodbomber"
                "usesmoothmesh", "true"
                "wingangle", "0.06593"
                "wingdrag", "0.835"
            ] }

    type Raptor_allterrain_arty_brood_t2_v1 =
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

    let raptor_allterrain_arty_brood_t2_v1 : Raptor_allterrain_arty_brood_t2_v1 =
        { name = "raptor_allterrain_arty_brood_t2_v1"
          subfolder = "other/raptors/Brood"
          metalCost = ValueOrExpr.Concrete 396.0
          energyCost = ValueOrExpr.Concrete 12320.0
          buildTime = ValueOrExpr.Concrete 6750.0
          health = ValueOrExpr.Concrete 2000.0
          sightDistance = ValueOrExpr.Concrete 1000.0
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
                { name = "bloodyeggs"
                  displayName = Some "GOOLAUNCHER"
                  weaponType = None
                  damage = Map.ofList [
                      "default", 1.0
                      "shields", 200.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1500.0)
                  reloadTime = Some (ValueOrExpr.Concrete 10.0)
                  weaponVelocity = Some 520.0
                  areaOfEffect = Some 128.0
                  accuracy = Some 512.0
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.63
                  impulseFactor = Some 0.4
                  noSelfDamage = Some true
                  soundStart = Some "bugarty"
                  soundHit = Some "smallraptorattack"
                  explosiongenerator = Some "custom:dirt"
                  rgbColor = Some "0.5 0 1"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.ofList [
                      "spawns_name", "raptor_land_swarmer_brood_t2_v1"
                      "spawns_surface", "LAND SEA"
                  ]
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
                      "burstrate", "0.01"
                      "canattackground", "false"
                      "cegtag", "arty-heavy-purple"
                      "craterareaofeffect", "128.0"
                      "craterboost", "0.2"
                      "cratermult", "0.2"
                      "intensity", "0.7"
                      "interceptedbyshieldtype", "0.0"
                      "model", "Raptors/s_raptor_white.s3o"
                      "proximitypriority", "-1.0"
                      "size", "5.5"
                      "sizedecay", "0.09"
                      "sprayangle", "512.0"
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
                "unitname", "raptor_allterrain_arty_brood_t2_v1"
                "upright", "false"
            ] }

    type Raptor_allterrain_arty_brood_t4_v1 =
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

    let raptor_allterrain_arty_brood_t4_v1 : Raptor_allterrain_arty_brood_t4_v1 =
        { name = "raptor_allterrain_arty_brood_t4_v1"
          subfolder = "other/raptors/Brood"
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
                { name = "bloodyeggs"
                  displayName = Some "GOOLAUNCHER"
                  weaponType = None
                  damage = Map.ofList [
                      "default", 1.0
                      "shields", 200.0
                  ]
                  range = Some (ValueOrExpr.Concrete 2000.0)
                  reloadTime = Some (ValueOrExpr.Concrete 10.0)
                  weaponVelocity = Some 520.0
                  areaOfEffect = Some 128.0
                  accuracy = Some 1024.0
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.63
                  impulseFactor = Some 0.4
                  noSelfDamage = Some true
                  soundStart = Some "bugarty"
                  soundHit = Some "smallraptorattack"
                  explosiongenerator = Some "custom:dirt"
                  rgbColor = Some "0.5 0 1"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.ofList [
                      "spawns_name", "raptor_land_swarmer_brood_t2_v1"
                      "spawns_surface", "LAND SEA"
                  ]
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
                      "canattackground", "false"
                      "cegtag", "arty-heavy-purple"
                      "craterareaofeffect", "128.0"
                      "craterboost", "0.2"
                      "cratermult", "0.2"
                      "intensity", "0.7"
                      "interceptedbyshieldtype", "0.0"
                      "model", "Raptors/s_raptor_white.s3o"
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
                "unitname", "raptor_allterrain_arty_brood_t4_v1"
                "upright", "false"
            ] }

    type Raptor_land_swarmer_brood_t2_v1 =
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

    let raptor_land_swarmer_brood_t2_v1 : Raptor_land_swarmer_brood_t2_v1 =
        { name = "raptor_land_swarmer_brood_t2_v1"
          subfolder = "other/raptors/Brood"
          metalCost = ValueOrExpr.Concrete 20.0
          energyCost = ValueOrExpr.Concrete 250.0
          buildTime = ValueOrExpr.Concrete 2250.0
          health = ValueOrExpr.Concrete 540.0
          sightDistance = ValueOrExpr.Concrete 200.0
          footprintX = 1.0
          footprintZ = 1.0
          speed = ValueOrExpr.Concrete 245.999
          maxAcc = 0.644
          maxDec = 0.23
          turnRate = 1840.0
          movementClass = "RAPTORSMALLHOVER"
          maxSlope = 18.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 15.0
          weapons = [
                { name = "weapon"
                  displayName = Some "Claws"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 100.0
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
                "collide", "0.0"
                "defaultmissiontype", "Standby"
                "leavetracks", "true"
                "maneuverleashlength", "640.0"
                "mass", "100.0"
                "noautofire", "false"
                "nochasecategory", "VTOL"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "trackoffset", "0.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrack"
                "trackwidth", "18.0"
                "unitname", "raptor_land_swarmer_brood_t2_v1"
                "upright", "false"
            ] }

    type Raptor_land_swarmer_brood_t3_v1 =
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

    let raptor_land_swarmer_brood_t3_v1 : Raptor_land_swarmer_brood_t3_v1 =
        { name = "raptor_land_swarmer_brood_t3_v1"
          subfolder = "other/raptors/Brood"
          metalCost = ValueOrExpr.Concrete 123.0
          energyCost = ValueOrExpr.Concrete 2326.0
          buildTime = ValueOrExpr.Concrete 4500.0
          health = ValueOrExpr.Concrete 2000.0
          sightDistance = ValueOrExpr.Concrete 300.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 135.0
          maxAcc = 0.414
          maxDec = 0.23
          turnRate = 1840.0
          movementClass = "RAPTORSMALLHOVER"
          maxSlope = 18.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 29.0
          weapons = [
                { name = "weapon"
                  displayName = Some "Claws"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 200.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
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
                  explosiongenerator = Some "custom:raptorspike-medium-sparks-burn"
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
                "normaltex", "unittextures/chicken_l_normals.png"
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
                "maneuverleashlength", "640.0"
                "mass", "700.0"
                "noautofire", "false"
                "nochasecategory", "VTOL"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "trackoffset", "4.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrack"
                "trackwidth", "22.0"
                "unitname", "raptor_land_swarmer_brood_t3_v1"
                "upright", "false"
            ] }

    type Raptor_land_swarmer_brood_t4_v1 =
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

    let raptor_land_swarmer_brood_t4_v1 : Raptor_land_swarmer_brood_t4_v1 =
        { name = "raptor_land_swarmer_brood_t4_v1"
          subfolder = "other/raptors/Brood"
          metalCost = ValueOrExpr.Concrete 251.0
          energyCost = ValueOrExpr.Concrete 5201.0
          buildTime = ValueOrExpr.Concrete 9000.0
          health = ValueOrExpr.Concrete 6700.0
          sightDistance = ValueOrExpr.Concrete 400.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 90.0
          maxAcc = 0.644
          maxDec = 0.23
          turnRate = 920.0
          movementClass = "RAPTORSMALLHOVER"
          maxSlope = 18.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 42.0
          weapons = [
                { name = "weapon"
                  displayName = Some "Claws"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 400.0
                  ]
                  range = Some (ValueOrExpr.Concrete 400.0)
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
                  explosiongenerator = Some "custom:raptorspike-large-sparks-burn"
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
                "normaltex", "unittextures/chicken_l_normals.png"
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
                "maneuverleashlength", "640.0"
                "mass", "1500.0"
                "noautofire", "false"
                "nochasecategory", "VTOL"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "trackoffset", "7.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrack"
                "trackwidth", "30.0"
                "unitname", "raptor_land_swarmer_brood_t4_v1"
                "upright", "false"
            ] }

