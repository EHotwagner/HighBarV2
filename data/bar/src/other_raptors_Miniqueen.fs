// Auto-generated BAR unit data: other/raptors/Miniqueen (flat per-unit types)
namespace BarData.Units

open BarData

module other_raptors_Miniqueen =

    type Raptor_matriarch_acid =
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

    let raptor_matriarch_acid : Raptor_matriarch_acid =
        { name = "raptor_matriarch_acid"
          subfolder = "other/raptors/Miniqueen"
          metalCost = ValueOrExpr.Concrete 50000.0
          energyCost = ValueOrExpr.Concrete 2000000.0
          buildTime = ValueOrExpr.Concrete 1500000.0
          health = ValueOrExpr.Concrete 60000.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 67.5
          maxAcc = 0.1
          maxDec = 0.1
          turnRate = 100.0
          movementClass = "RAPTORQUEENHOVER"
          maxSlope = 40.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 1.0
          waterline = 40.0
          weapons = [
                { name = "melee"
                  displayName = Some "RaptorClaws"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 500.0
                  ]
                  range = Some (ValueOrExpr.Concrete 400.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.0)
                  weaponVelocity = Some 2500.0
                  areaOfEffect = Some 60.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.3
                  impulseFactor = Some 1.5
                  noSelfDamage = Some true
                  soundStart = Some "bigraptorbreath"
                  soundHit = None
                  explosiongenerator = Some "custom:raptorspike-large-sparks-burn"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "155.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "camerashake", "0.0"
                      "collidefriendly", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firesubmersed", "true"
                      "interceptedbyshieldtype", "4.0"
                      "model", "Raptors/spike.s3o"
                      "waterweapon", "true"
                  ] }
                { name = "spike_acid_blob"
                  displayName = Some "GOOLAUNCHER"
                  weaponType = None
                  damage = Map.ofList [
                      "default", 1.0
                      "shields", 800.0
                  ]
                  range = Some (ValueOrExpr.Concrete 750.0)
                  reloadTime = Some (ValueOrExpr.Concrete 10.0)
                  weaponVelocity = Some 520.0
                  areaOfEffect = Some 150.0
                  accuracy = Some 256.0
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.63
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "alien_bombrel"
                  soundHit = Some "bloodsplash3"
                  explosiongenerator = Some "custom:acid-explosion-xl"
                  rgbColor = Some "0.8 0.99 0.11"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.ofList [
                      "area_onhit_ceg", "acid-area-75-repeat"
                      "area_onhit_damageCeg", "acid-damage-gen"
                      "area_onhit_resistance", "_RAPTORACID_"
                  ]
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTAIR"
                      "collidefriendly", "0.0"
                      "collidefeature", "0.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "burstrate", "0.03333"
                      "cegtag", "blob_trail_green"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "intensity", "0.7"
                      "interceptedbyshieldtype", "1.0"
                      "nogap", "false"
                      "size", "9.0"
                      "sizedecay", "0.04"
                      "alphaDecay", "0.18"
                      "stages", "8.0"
                      "proximitypriority", "-1.0"
                      "sprayangle", "256.0"
                      "weapontimer", "0.2"
                  ] }
                { name = "spike_acid_blob"
                  displayName = Some "GOOLAUNCHER"
                  weaponType = None
                  damage = Map.ofList [
                      "default", 1.0
                      "shields", 800.0
                  ]
                  range = Some (ValueOrExpr.Concrete 750.0)
                  reloadTime = Some (ValueOrExpr.Concrete 10.0)
                  weaponVelocity = Some 520.0
                  areaOfEffect = Some 150.0
                  accuracy = Some 256.0
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.63
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "alien_bombrel"
                  soundHit = Some "bloodsplash3"
                  explosiongenerator = Some "custom:acid-explosion-xl"
                  rgbColor = Some "0.8 0.99 0.11"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.ofList [
                      "area_onhit_ceg", "acid-area-75-repeat"
                      "area_onhit_damageCeg", "acid-damage-gen"
                      "area_onhit_resistance", "_RAPTORACID_"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "WEAPON"
                      "mount_onlytargetcategory", "NOTAIR"
                      "collidefriendly", "0.0"
                      "collidefeature", "0.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "burstrate", "0.03333"
                      "cegtag", "blob_trail_green"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "intensity", "0.7"
                      "interceptedbyshieldtype", "1.0"
                      "nogap", "false"
                      "size", "9.0"
                      "sizedecay", "0.04"
                      "alphaDecay", "0.18"
                      "stages", "8.0"
                      "proximitypriority", "-1.0"
                      "sprayangle", "256.0"
                      "weapontimer", "0.2"
                  ] }
                { name = "spike_acid_blob"
                  displayName = Some "GOOLAUNCHER"
                  weaponType = None
                  damage = Map.ofList [
                      "default", 1.0
                      "shields", 800.0
                  ]
                  range = Some (ValueOrExpr.Concrete 750.0)
                  reloadTime = Some (ValueOrExpr.Concrete 10.0)
                  weaponVelocity = Some 520.0
                  areaOfEffect = Some 150.0
                  accuracy = Some 256.0
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.63
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "alien_bombrel"
                  soundHit = Some "bloodsplash3"
                  explosiongenerator = Some "custom:acid-explosion-xl"
                  rgbColor = Some "0.8 0.99 0.11"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.ofList [
                      "area_onhit_ceg", "acid-area-75-repeat"
                      "area_onhit_damageCeg", "acid-damage-gen"
                      "area_onhit_resistance", "_RAPTORACID_"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "NOWEAPON"
                      "mount_onlytargetcategory", "NOTAIR"
                      "collidefriendly", "0.0"
                      "collidefeature", "0.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "burstrate", "0.03333"
                      "cegtag", "blob_trail_green"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "intensity", "0.7"
                      "interceptedbyshieldtype", "1.0"
                      "nogap", "false"
                      "size", "9.0"
                      "sizedecay", "0.04"
                      "alphaDecay", "0.18"
                      "stages", "8.0"
                      "proximitypriority", "-1.0"
                      "sprayangle", "256.0"
                      "weapontimer", "0.2"
                  ] }
                { name = "acidgoo"
                  displayName = Some "GOOLAUNCHER"
                  weaponType = None
                  damage = Map.ofList [
                      "default", 1.0
                      "shields", 800.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1000.0)
                  reloadTime = Some (ValueOrExpr.Concrete 30.0)
                  weaponVelocity = Some 520.0
                  areaOfEffect = Some 150.0
                  accuracy = Some 256.0
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.63
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "alien_bombrel"
                  soundHit = Some "bloodsplash3"
                  explosiongenerator = Some "custom:acid-explosion-xl"
                  rgbColor = Some "0.8 0.99 0.11"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.ofList [
                      "area_onhit_ceg", "acid-area-75-repeat"
                      "area_onhit_damageCeg", "acid-damage-gen"
                      "area_onhit_resistance", "_RAPTORACID_"
                  ]
                  extras = Map.ofList [
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "180.0"
                      "mount_onlytargetcategory", "NOTAIR"
                      "collidefriendly", "0.0"
                      "collidefeature", "0.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "burst", "5.0"
                      "burstrate", "0.03333"
                      "cegtag", "blob_trail_green"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "intensity", "0.7"
                      "interceptedbyshieldtype", "1.0"
                      "nogap", "false"
                      "size", "9.0"
                      "sizedecay", "0.04"
                      "alphaDecay", "0.18"
                      "stages", "8.0"
                      "proximitypriority", "-1.0"
                      "sprayangle", "2000.0"
                      "weapontimer", "0.2"
                  ] }
            ]
          customParams = Map.ofList [
                "subfolder", "other/raptors"
                "normaltex", "unittextures/chicken_l_normals.png"
            ]
          extras = Map.ofList [
                "airsightdistance", "2400.0"
                "autoheal", "5.0"
                "canattack", "true"
                "canguard", "true"
                "canpatrol", "true"
                "canstop", "1"
                "cantbetransported", "true"
                "capturable", "false"
                "collisionspherescale", "1.75"
                "collisionvolumetest", "1.0"
                "defaultmissiontype", "Standby"
                "leavetracks", "true"
                "maneuverleashlength", "2000.0"
                "mass", "2000000.0"
                "noautofire", "false"
                "nochasecategory", "VTOL"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "trackoffset", "18.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrack"
                "trackwidth", "80.0"
                "unitname", "raptor_matriarch_acid"
                "upright", "false"
            ] }

    type Raptor_matriarch_basic =
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

    let raptor_matriarch_basic : Raptor_matriarch_basic =
        { name = "raptor_matriarch_basic"
          subfolder = "other/raptors/Miniqueen"
          metalCost = ValueOrExpr.Concrete 50000.0
          energyCost = ValueOrExpr.Concrete 2000000.0
          buildTime = ValueOrExpr.Concrete 1500000.0
          health = ValueOrExpr.Concrete 60000.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 67.5
          maxAcc = 0.1
          maxDec = 0.1
          turnRate = 100.0
          movementClass = "RAPTORQUEENHOVER"
          maxSlope = 40.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 1.0
          waterline = 40.0
          weapons = [
                { name = "melee"
                  displayName = Some "RaptorClaws"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 150.0
                  ]
                  range = Some (ValueOrExpr.Concrete 400.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.0)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 60.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.3
                  impulseFactor = Some 1.5
                  noSelfDamage = Some true
                  soundStart = Some "bigraptorbreath"
                  soundHit = None
                  explosiongenerator = Some "custom:raptorspike-large-sparks-burn"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "155.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "camerashake", "0.0"
                      "collidefriendly", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firesubmersed", "true"
                      "interceptedbyshieldtype", "4.0"
                      "model", "Raptors/spike.s3o"
                      "waterweapon", "true"
                  ] }
                { name = "yellow_missile"
                  displayName = Some "Deadly Defensive Spores"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "default", 1.0
                      "vtol", 1000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 750.0)
                  reloadTime = Some (ValueOrExpr.Concrete 10.0)
                  weaponVelocity = Some 2000.0
                  areaOfEffect = Some 256.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 60000.0
                  edgeEffectiveness = Some 0.35
                  impulseFactor = Some 0.4
                  noSelfDamage = Some true
                  soundStart = Some "spore_xl"
                  soundHit = Some "spore_explo"
                  explosiongenerator = Some "custom:genericshellexplosion-huge-bomb"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfriendly", "false"
                      "burnblow", "true"
                      "collidefriendly", "false"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cameraShake", "700.0"
                      "dance", "20.0"
                      "firestarter", "0.0"
                      "flighttime", "5.0"
                      "firesubmersed", "true"
                      "interceptedbyshieldtype", "4.0"
                      "metalpershot", "0.0"
                      "model", "SimpleFlareXL.s3o"
                      "smoketrail", "true"
                      "smokePeriod", "2.0"
                      "smoketime", "45.0"
                      "smokesize", "10.5"
                      "smokecolor", "1.0"
                      "soundstartvolume", "9.0"
                      "startvelocity", "1000.0"
                      "texture1", "orangenovaexplo"
                      "texture2", "sporetrail_xl"
                      "tracks", "true"
                      "trajectoryheight", "2.0"
                      "turnrate", "60000.0"
                      "waterweapon", "true"
                      "weaponacceleration", "40.0"
                      "wobble", "32000.0"
                  ] }
                { name = "yellow_missile"
                  displayName = Some "Deadly Defensive Spores"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "default", 1.0
                      "vtol", 1000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 750.0)
                  reloadTime = Some (ValueOrExpr.Concrete 10.0)
                  weaponVelocity = Some 2000.0
                  areaOfEffect = Some 256.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 60000.0
                  edgeEffectiveness = Some 0.35
                  impulseFactor = Some 0.4
                  noSelfDamage = Some true
                  soundStart = Some "spore_xl"
                  soundHit = Some "spore_explo"
                  explosiongenerator = Some "custom:genericshellexplosion-huge-bomb"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfriendly", "false"
                      "burnblow", "true"
                      "collidefriendly", "false"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cameraShake", "700.0"
                      "dance", "20.0"
                      "firestarter", "0.0"
                      "flighttime", "5.0"
                      "firesubmersed", "true"
                      "interceptedbyshieldtype", "4.0"
                      "metalpershot", "0.0"
                      "model", "SimpleFlareXL.s3o"
                      "smoketrail", "true"
                      "smokePeriod", "2.0"
                      "smoketime", "45.0"
                      "smokesize", "10.5"
                      "smokecolor", "1.0"
                      "soundstartvolume", "9.0"
                      "startvelocity", "1000.0"
                      "texture1", "orangenovaexplo"
                      "texture2", "sporetrail_xl"
                      "tracks", "true"
                      "trajectoryheight", "2.0"
                      "turnrate", "60000.0"
                      "waterweapon", "true"
                      "weaponacceleration", "40.0"
                      "wobble", "32000.0"
                  ] }
                { name = "yellow_missile"
                  displayName = Some "Deadly Defensive Spores"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "default", 1.0
                      "vtol", 1000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 750.0)
                  reloadTime = Some (ValueOrExpr.Concrete 10.0)
                  weaponVelocity = Some 2000.0
                  areaOfEffect = Some 256.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 60000.0
                  edgeEffectiveness = Some 0.35
                  impulseFactor = Some 0.4
                  noSelfDamage = Some true
                  soundStart = Some "spore_xl"
                  soundHit = Some "spore_explo"
                  explosiongenerator = Some "custom:genericshellexplosion-huge-bomb"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfriendly", "false"
                      "burnblow", "true"
                      "collidefriendly", "false"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cameraShake", "700.0"
                      "dance", "20.0"
                      "firestarter", "0.0"
                      "flighttime", "5.0"
                      "firesubmersed", "true"
                      "interceptedbyshieldtype", "4.0"
                      "metalpershot", "0.0"
                      "model", "SimpleFlareXL.s3o"
                      "smoketrail", "true"
                      "smokePeriod", "2.0"
                      "smoketime", "45.0"
                      "smokesize", "10.5"
                      "smokecolor", "1.0"
                      "soundstartvolume", "9.0"
                      "startvelocity", "1000.0"
                      "texture1", "orangenovaexplo"
                      "texture2", "sporetrail_xl"
                      "tracks", "true"
                      "trajectoryheight", "2.0"
                      "turnrate", "60000.0"
                      "waterweapon", "true"
                      "weaponacceleration", "40.0"
                      "wobble", "32000.0"
                  ] }
                { name = "goo"
                  displayName = Some "Blob"
                  weaponType = None
                  damage = Map.ofList [
                      "default", 500.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1000.0)
                  reloadTime = Some (ValueOrExpr.Concrete 10.0)
                  weaponVelocity = Some 400.0
                  areaOfEffect = Some 300.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.63
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "bigraptorroar"
                  soundHit = Some "e16"
                  explosiongenerator = Some "custom:genericshellexplosion-large"
                  rgbColor = Some "0.1 0.6 1"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maxangledif", "180.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "burst", "3.0"
                      "burstrate", "0.03333"
                      "cegtag", "nuketrail-roost"
                      "collidefriendly", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firesubmersed", "true"
                      "intensity", "0.7"
                      "interceptedbyshieldtype", "1.0"
                      "model", "Raptors/SGreyRock1.S3O"
                      "proximitypriority", "-1.0"
                      "size", "8.0"
                      "sizedecay", "0.0"
                      "sprayangle", "1024.0"
                      "weapontimer", "0.2"
                  ] }
            ]
          customParams = Map.ofList [
                "subfolder", "other/raptors"
                "normaltex", "unittextures/chicken_m_normals.png"
            ]
          extras = Map.ofList [
                "airsightdistance", "2400.0"
                "autoheal", "5.0"
                "canattack", "true"
                "canguard", "true"
                "canpatrol", "true"
                "canstop", "1"
                "canrepair", "0.0"
                "canreclaim", "0.0"
                "cantbetransported", "true"
                "capturable", "false"
                "collisionspherescale", "1.75"
                "collisionvolumetest", "1.0"
                "defaultmissiontype", "Standby"
                "leavetracks", "true"
                "maneuverleashlength", "2000.0"
                "mass", "2000000.0"
                "noautofire", "false"
                "nochasecategory", "VTOL"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "trackoffset", "18.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrack"
                "trackwidth", "80.0"
                "unitname", "raptor_matriarch_basic"
                "upright", "false"
            ] }

    type Raptor_matriarch_electric =
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

    let raptor_matriarch_electric : Raptor_matriarch_electric =
        { name = "raptor_matriarch_electric"
          subfolder = "other/raptors/Miniqueen"
          metalCost = ValueOrExpr.Concrete 50000.0
          energyCost = ValueOrExpr.Concrete 2000000.0
          buildTime = ValueOrExpr.Concrete 1500000.0
          health = ValueOrExpr.Concrete 60000.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 67.5
          maxAcc = 0.1
          maxDec = 0.1
          turnRate = 100.0
          movementClass = "RAPTORQUEENHOVER"
          maxSlope = 40.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 1.0
          waterline = 40.0
          weapons = [
                { name = "melee"
                  displayName = Some "Close-quarters g2g lightning rifle"
                  weaponType = Some "LightningCannon"
                  damage = Map.ofList [
                      "default", 1400.0
                  ]
                  range = Some (ValueOrExpr.Concrete 400.0)
                  reloadTime = Some (ValueOrExpr.Concrete 15.0)
                  weaponVelocity = Some 400.0
                  areaOfEffect = Some 30.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "alien_electric_xl"
                  soundHit = None
                  explosiongenerator = Some "custom:genericshellexplosion-medium-lightning2"
                  rgbColor = Some "0.5 0.5 1"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "155.0"
                      "collidefriendly", "false"
                      "collidefeature", "0.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "beamttl", "1.0"
                      "burst", "20.0"
                      "burstrate", "0.03333"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "1.0"
                      "energypershot", "0.0"
                      "firestarter", "50.0"
                      "firesubmersed", "true"
                      "impactonly", "0.0"
                      "intensity", "24.0"
                      "laserFlareSize", "5.0"
                      "paralyzer", "true"
                      "paralyzetime", "20.0"
                      "soundstartvolume", "65.0"
                      "soundtrigger", "true"
                      "targetmoveerror", "0.15"
                      "thickness", "1.5"
                      "waterweapon", "true"
                  ] }
                { name = "melee"
                  displayName = Some "Close-quarters g2g lightning rifle"
                  weaponType = Some "LightningCannon"
                  damage = Map.ofList [
                      "default", 1400.0
                  ]
                  range = Some (ValueOrExpr.Concrete 400.0)
                  reloadTime = Some (ValueOrExpr.Concrete 15.0)
                  weaponVelocity = Some 400.0
                  areaOfEffect = Some 30.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "alien_electric_xl"
                  soundHit = None
                  explosiongenerator = Some "custom:genericshellexplosion-medium-lightning2"
                  rgbColor = Some "0.5 0.5 1"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "collidefriendly", "false"
                      "collidefeature", "0.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "beamttl", "1.0"
                      "burst", "20.0"
                      "burstrate", "0.03333"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "1.0"
                      "energypershot", "0.0"
                      "firestarter", "50.0"
                      "firesubmersed", "true"
                      "impactonly", "0.0"
                      "intensity", "24.0"
                      "laserFlareSize", "5.0"
                      "paralyzer", "true"
                      "paralyzetime", "20.0"
                      "soundstartvolume", "65.0"
                      "soundtrigger", "true"
                      "targetmoveerror", "0.15"
                      "thickness", "1.5"
                      "waterweapon", "true"
                  ] }
                { name = "melee"
                  displayName = Some "Close-quarters g2g lightning rifle"
                  weaponType = Some "LightningCannon"
                  damage = Map.ofList [
                      "default", 1400.0
                  ]
                  range = Some (ValueOrExpr.Concrete 400.0)
                  reloadTime = Some (ValueOrExpr.Concrete 15.0)
                  weaponVelocity = Some 400.0
                  areaOfEffect = Some 30.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "alien_electric_xl"
                  soundHit = None
                  explosiongenerator = Some "custom:genericshellexplosion-medium-lightning2"
                  rgbColor = Some "0.5 0.5 1"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "WEAPON"
                      "collidefriendly", "false"
                      "collidefeature", "0.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "beamttl", "1.0"
                      "burst", "20.0"
                      "burstrate", "0.03333"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "1.0"
                      "energypershot", "0.0"
                      "firestarter", "50.0"
                      "firesubmersed", "true"
                      "impactonly", "0.0"
                      "intensity", "24.0"
                      "laserFlareSize", "5.0"
                      "paralyzer", "true"
                      "paralyzetime", "20.0"
                      "soundstartvolume", "65.0"
                      "soundtrigger", "true"
                      "targetmoveerror", "0.15"
                      "thickness", "1.5"
                      "waterweapon", "true"
                  ] }
                { name = "melee"
                  displayName = Some "Close-quarters g2g lightning rifle"
                  weaponType = Some "LightningCannon"
                  damage = Map.ofList [
                      "default", 1400.0
                  ]
                  range = Some (ValueOrExpr.Concrete 400.0)
                  reloadTime = Some (ValueOrExpr.Concrete 15.0)
                  weaponVelocity = Some 400.0
                  areaOfEffect = Some 30.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "alien_electric_xl"
                  soundHit = None
                  explosiongenerator = Some "custom:genericshellexplosion-medium-lightning2"
                  rgbColor = Some "0.5 0.5 1"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "NOWEAPON"
                      "collidefriendly", "false"
                      "collidefeature", "0.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "beamttl", "1.0"
                      "burst", "20.0"
                      "burstrate", "0.03333"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "1.0"
                      "energypershot", "0.0"
                      "firestarter", "50.0"
                      "firesubmersed", "true"
                      "impactonly", "0.0"
                      "intensity", "24.0"
                      "laserFlareSize", "5.0"
                      "paralyzer", "true"
                      "paralyzetime", "20.0"
                      "soundstartvolume", "65.0"
                      "soundtrigger", "true"
                      "targetmoveerror", "0.15"
                      "thickness", "1.5"
                      "waterweapon", "true"
                  ] }
                { name = "goo"
                  displayName = Some "GOOLAUNCHER"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 9000.0
                      "shields", 1000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1000.0)
                  reloadTime = Some (ValueOrExpr.Concrete 30.0)
                  weaponVelocity = Some 520.0
                  areaOfEffect = Some 220.0
                  accuracy = Some 256.0
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.63
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "bugarty"
                  soundHit = Some "empbomb"
                  explosiongenerator = Some "custom:genericshellexplosion-large-lightning"
                  rgbColor = Some "0.2 0.5 0.9"
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
                      "burst", "5.0"
                      "burstrate", "0.03333"
                      "cegtag", "blob_trail_blue"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firesubmersed", "true"
                      "gravityaffected", "true"
                      "intensity", "0.8"
                      "interceptedbyshieldtype", "1.0"
                      "paralyzer", "true"
                      "paralyzetime", "20.0"
                      "proximitypriority", "-1.0"
                      "size", "5.5"
                      "sizedecay", "0.09"
                      "sprayangle", "2000.0"
                      "weapontimer", "0.2"
                  ] }
            ]
          customParams = Map.ofList [
                "subfolder", "other/raptors"
                "normaltex", "unittextures/chicken_l_normals.png"
                "paralyzemultiplier", "0.0"
            ]
          extras = Map.ofList [
                "airsightdistance", "2400.0"
                "autoheal", "5.0"
                "canattack", "true"
                "canguard", "true"
                "canpatrol", "true"
                "canstop", "1"
                "cantbetransported", "true"
                "capturable", "false"
                "collisionspherescale", "1.75"
                "collisionvolumetest", "1.0"
                "defaultmissiontype", "Standby"
                "leavetracks", "true"
                "maneuverleashlength", "2000.0"
                "mass", "2000000.0"
                "noautofire", "false"
                "nochasecategory", "VTOL"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "trackoffset", "18.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrack"
                "trackwidth", "80.0"
                "unitname", "raptor_matriarch_electric"
                "upright", "false"
            ] }

    type Raptor_matriarch_fire =
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

    let raptor_matriarch_fire : Raptor_matriarch_fire =
        { name = "raptor_matriarch_fire"
          subfolder = "other/raptors/Miniqueen"
          metalCost = ValueOrExpr.Concrete 50000.0
          energyCost = ValueOrExpr.Concrete 2000000.0
          buildTime = ValueOrExpr.Concrete 1500000.0
          health = ValueOrExpr.Concrete 60000.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 67.5
          maxAcc = 0.1
          maxDec = 0.1
          turnRate = 100.0
          movementClass = "RAPTORQUEENHOVER"
          maxSlope = 40.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 1.0
          waterline = 40.0
          weapons = [
                { name = "flamethrowerspike"
                  displayName = Some "FlameThrower"
                  weaponType = Some "Flame"
                  damage = Map.ofList [
                      "default", 20.0
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
                      "mount_maxangledif", "155.0"
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
                { name = "flamethrowerspike"
                  displayName = Some "FlameThrower"
                  weaponType = Some "Flame"
                  damage = Map.ofList [
                      "default", 20.0
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
                      "mount_badtargetcategory", "NOTAIR"
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
                { name = "flamethrowerspike"
                  displayName = Some "FlameThrower"
                  weaponType = Some "Flame"
                  damage = Map.ofList [
                      "default", 20.0
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
                      "mount_badtargetcategory", "WEAPON"
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
                { name = "flamethrowerspike"
                  displayName = Some "FlameThrower"
                  weaponType = Some "Flame"
                  damage = Map.ofList [
                      "default", 20.0
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
                      "mount_badtargetcategory", "NOWEAPON"
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
                { name = "flamethrowermain"
                  displayName = Some "FlameThrower"
                  weaponType = Some "Flame"
                  damage = Map.ofList [
                      "default", 40.0
                  ]
                  range = Some (ValueOrExpr.Concrete 500.0)
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
                      "mount_maxangledif", "180.0"
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
                      "sizegrowth", "1.25"
                      "soundhitwet", "sizzle"
                      "soundtrigger", "false"
                      "sprayangle", "100.0"
                      "targetmoveerror", "0.001"
                      "weapontimer", "1.0"
                  ] }
            ]
          customParams = Map.ofList [
                "subfolder", "other/raptors"
                "normaltex", "unittextures/chicken_l_normals.png"
            ]
          extras = Map.ofList [
                "airsightdistance", "2400.0"
                "autoheal", "5.0"
                "canattack", "true"
                "canguard", "true"
                "canpatrol", "true"
                "canstop", "1"
                "canrepair", "0.0"
                "canreclaim", "0.0"
                "cantbetransported", "true"
                "capturable", "false"
                "collisionspherescale", "1.75"
                "collisionvolumetest", "1.0"
                "defaultmissiontype", "Standby"
                "leavetracks", "true"
                "maneuverleashlength", "2000.0"
                "mass", "2000000.0"
                "noautofire", "false"
                "nochasecategory", "VTOL"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "trackoffset", "18.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrack"
                "trackwidth", "80.0"
                "unitname", "raptor_matriarch_basic"
                "upright", "false"
            ] }

    type Raptor_matriarch_healer =
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
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          weapons: WeaponDef list
          customParams: Map<string, string>
          extras: Map<string, string> }

    let raptor_matriarch_healer : Raptor_matriarch_healer =
        { name = "raptor_matriarch_healer"
          subfolder = "other/raptors/Miniqueen"
          metalCost = ValueOrExpr.Concrete 50000.0
          energyCost = ValueOrExpr.Concrete 2000000.0
          buildTime = ValueOrExpr.Concrete 1500000.0
          health = ValueOrExpr.Concrete 60000.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 67.5
          maxAcc = 0.1
          maxDec = 0.1
          turnRate = 100.0
          movementClass = "RAPTORQUEENHOVER"
          maxSlope = 40.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 1.0
          waterline = 40.0
          workerTime = ValueOrExpr.Concrete 2500.0
          buildDistance = 500.0
          buildOptions = []
          weapons = [
                { name = "melee"
                  displayName = Some "RaptorClaws"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 50.0
                  ]
                  range = Some (ValueOrExpr.Concrete 400.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.0)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 60.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.3
                  impulseFactor = Some 1.5
                  noSelfDamage = Some true
                  soundStart = Some "bigraptorbreath"
                  soundHit = None
                  explosiongenerator = Some "custom:raptorspike-large-sparks-burn"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "155.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "camerashake", "0.0"
                      "collidefriendly", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firesubmersed", "true"
                      "interceptedbyshieldtype", "4.0"
                      "model", "Raptors/spike.s3o"
                      "waterweapon", "true"
                  ] }
                { name = "yellow_missile"
                  displayName = Some "Deadly Defensive Spores"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "default", 5.0
                      "vtol", 500.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1000.0)
                  reloadTime = Some (ValueOrExpr.Concrete 10.0)
                  weaponVelocity = Some 2000.0
                  areaOfEffect = Some 128.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 60000.0
                  edgeEffectiveness = Some 0.35
                  impulseFactor = Some 0.4
                  noSelfDamage = Some true
                  soundStart = Some "spore_xl"
                  soundHit = Some "spore_explo"
                  explosiongenerator = Some "custom:genericshellexplosion-huge-bomb"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfriendly", "false"
                      "burnblow", "true"
                      "collidefriendly", "false"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cameraShake", "700.0"
                      "dance", "20.0"
                      "firestarter", "0.0"
                      "flighttime", "2.0"
                      "firesubmersed", "true"
                      "interceptedbyshieldtype", "4.0"
                      "metalpershot", "0.0"
                      "model", "SimpleFlareXL.s3o"
                      "smoketrail", "true"
                      "smokePeriod", "2.0"
                      "smoketime", "45.0"
                      "smokesize", "10.5"
                      "smokecolor", "1.0"
                      "soundstartvolume", "9.0"
                      "startvelocity", "1000.0"
                      "texture1", "orangenovaexplo"
                      "texture2", "sporetrail_xl"
                      "tracks", "true"
                      "trajectoryheight", "2.0"
                      "turnrate", "60000.0"
                      "waterweapon", "true"
                      "weaponacceleration", "40.0"
                      "wobble", "32000.0"
                  ] }
                { name = "yellow_missile"
                  displayName = Some "Deadly Defensive Spores"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "default", 5.0
                      "vtol", 500.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1000.0)
                  reloadTime = Some (ValueOrExpr.Concrete 10.0)
                  weaponVelocity = Some 2000.0
                  areaOfEffect = Some 128.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 60000.0
                  edgeEffectiveness = Some 0.35
                  impulseFactor = Some 0.4
                  noSelfDamage = Some true
                  soundStart = Some "spore_xl"
                  soundHit = Some "spore_explo"
                  explosiongenerator = Some "custom:genericshellexplosion-huge-bomb"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfriendly", "false"
                      "burnblow", "true"
                      "collidefriendly", "false"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cameraShake", "700.0"
                      "dance", "20.0"
                      "firestarter", "0.0"
                      "flighttime", "2.0"
                      "firesubmersed", "true"
                      "interceptedbyshieldtype", "4.0"
                      "metalpershot", "0.0"
                      "model", "SimpleFlareXL.s3o"
                      "smoketrail", "true"
                      "smokePeriod", "2.0"
                      "smoketime", "45.0"
                      "smokesize", "10.5"
                      "smokecolor", "1.0"
                      "soundstartvolume", "9.0"
                      "startvelocity", "1000.0"
                      "texture1", "orangenovaexplo"
                      "texture2", "sporetrail_xl"
                      "tracks", "true"
                      "trajectoryheight", "2.0"
                      "turnrate", "60000.0"
                      "waterweapon", "true"
                      "weaponacceleration", "40.0"
                      "wobble", "32000.0"
                  ] }
                { name = "yellow_missile"
                  displayName = Some "Deadly Defensive Spores"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "default", 5.0
                      "vtol", 500.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1000.0)
                  reloadTime = Some (ValueOrExpr.Concrete 10.0)
                  weaponVelocity = Some 2000.0
                  areaOfEffect = Some 128.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 60000.0
                  edgeEffectiveness = Some 0.35
                  impulseFactor = Some 0.4
                  noSelfDamage = Some true
                  soundStart = Some "spore_xl"
                  soundHit = Some "spore_explo"
                  explosiongenerator = Some "custom:genericshellexplosion-huge-bomb"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfriendly", "false"
                      "burnblow", "true"
                      "collidefriendly", "false"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cameraShake", "700.0"
                      "dance", "20.0"
                      "firestarter", "0.0"
                      "flighttime", "2.0"
                      "firesubmersed", "true"
                      "interceptedbyshieldtype", "4.0"
                      "metalpershot", "0.0"
                      "model", "SimpleFlareXL.s3o"
                      "smoketrail", "true"
                      "smokePeriod", "2.0"
                      "smoketime", "45.0"
                      "smokesize", "10.5"
                      "smokecolor", "1.0"
                      "soundstartvolume", "9.0"
                      "startvelocity", "1000.0"
                      "texture1", "orangenovaexplo"
                      "texture2", "sporetrail_xl"
                      "tracks", "true"
                      "trajectoryheight", "2.0"
                      "turnrate", "60000.0"
                      "waterweapon", "true"
                      "weaponacceleration", "40.0"
                      "wobble", "32000.0"
                  ] }
                { name = "meleebig"
                  displayName = Some "RaptorClaws"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 500.0
                  ]
                  range = Some (ValueOrExpr.Concrete 600.0)
                  reloadTime = Some (ValueOrExpr.Concrete 10.0)
                  weaponVelocity = Some 2500.0
                  areaOfEffect = Some 128.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.3
                  impulseFactor = Some 1.5
                  noSelfDamage = Some true
                  soundStart = Some "bigraptorbreath"
                  soundHit = None
                  explosiongenerator = Some "custom:raptorspike-large-sparks-burn"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maxangledif", "180.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "camerashake", "0.0"
                      "collidefriendly", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firesubmersed", "true"
                      "interceptedbyshieldtype", "4.0"
                      "model", "Raptors/spike.s3o"
                      "waterweapon", "true"
                  ] }
            ]
          customParams = Map.ofList [
                "subfolder", "other/raptors"
                "normaltex", "unittextures/chicken_l_normals.png"
            ]
          extras = Map.ofList [
                "airsightdistance", "2400.0"
                "autoheal", "5.0"
                "canattack", "false"
                "canguard", "true"
                "canpatrol", "true"
                "canstop", "1"
                "canrepair", "1.0"
                "canreclaim", "0.0"
                "cantbetransported", "true"
                "capturable", "false"
                "collisionspherescale", "1.75"
                "collisionvolumetest", "1.0"
                "defaultmissiontype", "Standby"
                "leavetracks", "true"
                "maneuverleashlength", "2000.0"
                "mass", "2000000.0"
                "noautofire", "false"
                "nochasecategory", "VTOL"
                "repairable", "false"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "trackoffset", "18.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrack"
                "trackwidth", "80.0"
                "unitname", "raptor_matriarch_healer"
                "upright", "false"
            ] }

    type Raptor_matriarch_spectre =
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

    let raptor_matriarch_spectre : Raptor_matriarch_spectre =
        { name = "raptor_matriarch_spectre"
          subfolder = "other/raptors/Miniqueen"
          metalCost = ValueOrExpr.Concrete 50000.0
          energyCost = ValueOrExpr.Concrete 2000000.0
          buildTime = ValueOrExpr.Concrete 1500000.0
          health = ValueOrExpr.Concrete 30000.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 67.5
          maxAcc = 0.1
          maxDec = 0.1
          turnRate = 100.0
          movementClass = "RAPTORQUEENHOVER"
          maxSlope = 40.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 1.0
          waterline = 40.0
          weapons = [
                { name = "melee"
                  displayName = Some "RaptorClaws"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 150.0
                  ]
                  range = Some (ValueOrExpr.Concrete 400.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.0)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 60.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.3
                  impulseFactor = Some 1.5
                  noSelfDamage = Some true
                  soundStart = Some "bigraptorbreath"
                  soundHit = None
                  explosiongenerator = Some "custom:raptorspike-large-sparks-burn"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "155.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "camerashake", "0.0"
                      "collidefriendly", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firesubmersed", "true"
                      "interceptedbyshieldtype", "4.0"
                      "model", "Raptors/spike.s3o"
                      "waterweapon", "true"
                  ] }
                { name = "yellow_missile"
                  displayName = Some "Deadly Defensive Spores"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "default", 1.0
                      "vtol", 2000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 750.0)
                  reloadTime = Some (ValueOrExpr.Concrete 20.0)
                  weaponVelocity = Some 2000.0
                  areaOfEffect = Some 256.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 60000.0
                  edgeEffectiveness = Some 0.35
                  impulseFactor = Some 0.4
                  noSelfDamage = Some true
                  soundStart = Some "spore_xl"
                  soundHit = Some "spore_explo"
                  explosiongenerator = Some "custom:genericshellexplosion-huge-bomb"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfriendly", "false"
                      "burnblow", "true"
                      "collidefriendly", "false"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cameraShake", "700.0"
                      "dance", "20.0"
                      "firestarter", "0.0"
                      "flighttime", "5.0"
                      "firesubmersed", "true"
                      "interceptedbyshieldtype", "4.0"
                      "metalpershot", "0.0"
                      "model", "SimpleFlareXL.s3o"
                      "smoketrail", "true"
                      "smokePeriod", "2.0"
                      "smoketime", "45.0"
                      "smokesize", "10.5"
                      "smokecolor", "1.0"
                      "soundstartvolume", "9.0"
                      "startvelocity", "1000.0"
                      "texture1", "orangenovaexplo"
                      "texture2", "sporetrail_xl"
                      "tracks", "true"
                      "trajectoryheight", "2.0"
                      "turnrate", "60000.0"
                      "waterweapon", "true"
                      "weaponacceleration", "40.0"
                      "wobble", "32000.0"
                  ] }
                { name = "yellow_missile"
                  displayName = Some "Deadly Defensive Spores"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "default", 1.0
                      "vtol", 2000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 750.0)
                  reloadTime = Some (ValueOrExpr.Concrete 20.0)
                  weaponVelocity = Some 2000.0
                  areaOfEffect = Some 256.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 60000.0
                  edgeEffectiveness = Some 0.35
                  impulseFactor = Some 0.4
                  noSelfDamage = Some true
                  soundStart = Some "spore_xl"
                  soundHit = Some "spore_explo"
                  explosiongenerator = Some "custom:genericshellexplosion-huge-bomb"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfriendly", "false"
                      "burnblow", "true"
                      "collidefriendly", "false"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cameraShake", "700.0"
                      "dance", "20.0"
                      "firestarter", "0.0"
                      "flighttime", "5.0"
                      "firesubmersed", "true"
                      "interceptedbyshieldtype", "4.0"
                      "metalpershot", "0.0"
                      "model", "SimpleFlareXL.s3o"
                      "smoketrail", "true"
                      "smokePeriod", "2.0"
                      "smoketime", "45.0"
                      "smokesize", "10.5"
                      "smokecolor", "1.0"
                      "soundstartvolume", "9.0"
                      "startvelocity", "1000.0"
                      "texture1", "orangenovaexplo"
                      "texture2", "sporetrail_xl"
                      "tracks", "true"
                      "trajectoryheight", "2.0"
                      "turnrate", "60000.0"
                      "waterweapon", "true"
                      "weaponacceleration", "40.0"
                      "wobble", "32000.0"
                  ] }
                { name = "yellow_missile"
                  displayName = Some "Deadly Defensive Spores"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "default", 1.0
                      "vtol", 2000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 750.0)
                  reloadTime = Some (ValueOrExpr.Concrete 20.0)
                  weaponVelocity = Some 2000.0
                  areaOfEffect = Some 256.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 60000.0
                  edgeEffectiveness = Some 0.35
                  impulseFactor = Some 0.4
                  noSelfDamage = Some true
                  soundStart = Some "spore_xl"
                  soundHit = Some "spore_explo"
                  explosiongenerator = Some "custom:genericshellexplosion-huge-bomb"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfriendly", "false"
                      "burnblow", "true"
                      "collidefriendly", "false"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cameraShake", "700.0"
                      "dance", "20.0"
                      "firestarter", "0.0"
                      "flighttime", "5.0"
                      "firesubmersed", "true"
                      "interceptedbyshieldtype", "4.0"
                      "metalpershot", "0.0"
                      "model", "SimpleFlareXL.s3o"
                      "smoketrail", "true"
                      "smokePeriod", "2.0"
                      "smoketime", "45.0"
                      "smokesize", "10.5"
                      "smokecolor", "1.0"
                      "soundstartvolume", "9.0"
                      "startvelocity", "1000.0"
                      "texture1", "orangenovaexplo"
                      "texture2", "sporetrail_xl"
                      "tracks", "true"
                      "trajectoryheight", "2.0"
                      "turnrate", "60000.0"
                      "waterweapon", "true"
                      "weaponacceleration", "40.0"
                      "wobble", "32000.0"
                  ] }
                { name = "goo"
                  displayName = Some "Blob"
                  weaponType = None
                  damage = Map.ofList [
                      "default", 500.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1000.0)
                  reloadTime = Some (ValueOrExpr.Concrete 20.0)
                  weaponVelocity = Some 400.0
                  areaOfEffect = Some 300.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.63
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "bigraptorroar"
                  soundHit = Some "e16"
                  explosiongenerator = Some "custom:genericshellexplosion-large"
                  rgbColor = Some "0.1 0.6 1"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maxangledif", "180.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "burst", "3.0"
                      "burstrate", "0.03333"
                      "cegtag", "nuketrail-roost"
                      "collidefriendly", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firesubmersed", "true"
                      "intensity", "0.7"
                      "interceptedbyshieldtype", "1.0"
                      "model", "Raptors/SGreyRock1.S3O"
                      "proximitypriority", "-1.0"
                      "size", "8.0"
                      "sizedecay", "0.0"
                      "sprayangle", "1024.0"
                      "weapontimer", "0.2"
                  ] }
            ]
          customParams = Map.ofList [
                "subfolder", "other/raptors"
                "normaltex", "unittextures/chicken_l_normals.png"
            ]
          extras = Map.ofList [
                "airsightdistance", "2400.0"
                "autoheal", "5.0"
                "canattack", "true"
                "canguard", "true"
                "canpatrol", "true"
                "canstop", "1"
                "canrepair", "0.0"
                "canreclaim", "0.0"
                "cantbetransported", "true"
                "capturable", "false"
                "cancloak", "true"
                "cloakcost", "0.0"
                "cloakcostmoving", "0.0"
                "collisionspherescale", "1.75"
                "collisionvolumetest", "1.0"
                "defaultmissiontype", "Standby"
                "initcloak", "true"
                "leavetracks", "true"
                "maneuverleashlength", "2000.0"
                "mass", "2000000.0"
                "mincloakdistance", "200.0"
                "noautofire", "false"
                "nochasecategory", "VTOL"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "stealth", "1.0"
                "trackoffset", "18.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrack"
                "trackwidth", "80.0"
                "unitname", "raptor_matriarch_basic"
                "upright", "false"
            ] }

