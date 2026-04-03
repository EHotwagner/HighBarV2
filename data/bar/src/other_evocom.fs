// Auto-generated BAR unit data: other/evocom (unified)
namespace BarData.Units

open BarData

module other_evocom =

    type Armcomlvl10 =
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

    let armcomlvl10 : Armcomlvl10 =
        { name = "armcomlvl10"
          subfolder = "other/evocom"
          metalCost = ValueOrExpr.Concrete 11000.0
          energyCost = ValueOrExpr.Concrete 110000.0
          buildTime = ValueOrExpr.Concrete 195600.0
          health = ValueOrExpr.Concrete 13200.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMCOMHILVL.s3o"
          buildPic = Some "ARMCOM.DDS"
          script = Some "Units/ARMCOMHILVL.lua"
          corpse = Some "DEAD"
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderexplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
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
          workerTime = ValueOrExpr.Concrete 1800.0
          buildDistance = 217.0
          buildOptions = []
          terraformSpeed = 1500.0
          energyMake = ValueOrExpr.Concrete 2000.0
          metalMake = ValueOrExpr.Concrete 50.0
          energyStorage = 10000.0
          metalStorage = 500.0
          weapons = [
                { name = "backlauncher"
                  displayName = "HeavyRockets"
                  weaponType = Some "StarburstLauncher"
                  damage = Map.ofList [
                      "default", 4400.0
                  ]
                  range = Some (ValueOrExpr.Concrete 870.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.0)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 121.0
                  accuracy = None
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.61
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "Rockhvy1"
                  soundHit = Some "xplomed4"
                  explosiongenerator = Some "custom:genericshellexplosion-large-bomb"
                  rgbColor = None
                  customParams = Map.ofList [
                      "projectile_destruction_method", "descend"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "MOBILE"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "cegtag", "missiletrailmedium-starburst"
                      "craterareaofeffect", "70.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "100.0"
                      "flighttime", "7.4"
                      "model", "corkbmissl1.s3o"
                      "smoketrail", "true"
                      "smokePeriod", "8.0"
                      "smoketime", "30.0"
                      "smokesize", "12.0"
                      "smokecolor", "0.7"
                      "smokeTrailCastShadow", "true"
                      "soundhitwet", "splssml"
                      "stockpile", "true"
                      "stockpiletime", "10.0"
                      "texture1", "null"
                      "texture2", "smoketrailbar"
                      "texture3", "null"
                      "turnrate", "15000.0"
                      "weaponacceleration", "250.0"
                      "weapontimer", "1.9"
                  ] }
                { name = "armcomsealaser"
                  displayName = "UWSupernovaBeam"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 1400.0
                      "subs", 700.0
                  ]
                  range = Some (ValueOrExpr.Concrete 500.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.28)
                  weaponVelocity = Some 700.0
                  areaOfEffect = Some 70.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "uwlasrfir1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-medium-blue"
                  rgbColor = Some "0.5 0.7 0.10"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTAIR"
                      "avoidfeature", "false"
                      "beamtime", "0.16"
                      "camerashake", "0.0"
                      "corethickness", "0.6"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "90.0"
                      "firesubmersed", "true"
                      "intensity", "0.6"
                      "laserflaresize", "5.5"
                      "rgbcolor2", "1 1 1"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "3.5"
                      "waterweapon", "true"
                  ] }
                { name = "disintegrator"
                  displayName = "Disintegrator"
                  weaponType = Some "DGun"
                  damage = Map.ofList [
                      "commanders", 0.0
                      "default", 99999.0
                      "scavboss", 1000.0
                      "raptorqueen", 1000.0
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
                      "soundhitwet", "sizzlexs"
                      "soundhitvolume", "36.0"
                      "soundstartvolume", "96.0"
                      "soundtrigger", "true"
                      "waterweapon", "true"
                      "weapontimer", "4.2"
                  ] }
                { name = "longgun"
                  displayName = "Arcing Stun Beam"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 60000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 600.0)
                  reloadTime = Some (ValueOrExpr.Concrete 8.0)
                  weaponVelocity = Some 1500.0
                  areaOfEffect = Some 60.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrcrw2"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-emp"
                  rgbColor = Some "0.7 0.7 1"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "GROUNDSCOUT"
                      "mount_onlytargetcategory", "EMPABLE"
                      "beamtime", "0.15"
                      "collidefriendly", "false"
                      "corethickness", "0.23"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "largebeamlaser", "true"
                      "laserflaresize", "5.05"
                      "paralyzer", "true"
                      "paralyzetime", "7.0"
                      "scrollspeed", "5.0"
                      "soundhitdry", "hackshot"
                      "soundhitwet", "sizzle"
                      "soundstartvolume", "30.0"
                      "soundhitdryvolume", "40.0"
                      "soundhitwetvolume", "30.0"
                      "soundtrigger", "1.0"
                      "texture3", "largebeam"
                      "thickness", "3.0"
                      "tilelength", "150.0"
                  ] }
                { name = "shortgun"
                  displayName = "Short-Range Lightening Discharge"
                  weaponType = Some "LightningCannon"
                  damage = Map.ofList [
                      "default", 118.0
                  ]
                  range = Some (ValueOrExpr.Concrete 500.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.1)
                  weaponVelocity = Some 400.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lghthvy2"
                  soundHit = Some ""
                  explosiongenerator = Some "custom:genericshellexplosion-medium-lightning2"
                  rgbColor = Some "1.0, 0.7, 0.0"
                  customParams = Map.ofList [
                      "spark_ceg", "genericshellexplosion-splash-lightning"
                      "spark_forkdamage", "0.33"
                      "spark_maxunits", "12"
                      "spark_range", "100"
                  ]
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "mount_fastautoretargeting", "true"
                      "avoidfeature", "false"
                      "beamttl", "1.0"
                      "burst", "3.0"
                      "burstrate", "0.03333"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "1.0"
                      "energypershot", "5.0"
                      "firestarter", "50.0"
                      "intensity", "24.0"
                      "soundhitwet", ""
                      "soundtrigger", "true"
                      "thickness", "1.5"
                  ] }
                { name = "empflashbang"
                  displayName = "EMP Damage-Mitigating Flashbang"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "default", 20000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 3.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.25)
                  weaponVelocity = Some 1.0
                  areaOfEffect = Some 50.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.001
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "xplosml5"
                  soundHit = None
                  explosiongenerator = Some "custom:genericshellexplosion-huge-lightning"
                  rgbColor = Some "1 1 1"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "COMMANDER"
                      "avoidfeature", "false"
                      "beamdecay", ".8"
                      "beamttl", "0.8"
                      "burnblow", "true"
                      "collideenemy", "false"
                      "collidefeature", "false"
                      "collidefriendly", "false"
                      "collideground", "false"
                      "collideneutral", "false"
                      "corethickness", "1.0"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "falloffrate", "0.0"
                      "impactonly", "1.0"
                      "laserflaresize", "8.8"
                      "paralyzer", "true"
                      "paralyzetime", "8.0"
                      "soundhitdry", ""
                      "soundhitwet", ""
                      "soundtrigger", "1.0"
                      "thickness", "6.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "35 12 54"
                  collisionVolumeType = Some "CylY"
                  damage = Some 44000.0
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
                "unitgroup", "builder"
                "area_mex_def", "armmex"
                "iscommander", "true"
                "effigy_offset", "1.0"
                "evocomlvl", "10.0"
                "inheritxpratemultiplier", "0.5"
                "childreninheritxp", "TURRET MOBILEBUILT"
                "parentsinheritxp", "TURRET MOBILEBUILT"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "paralyzemultiplier", "0.025"
                "subfolder", ""
                "workertimeboost", "3.5"
                "wtboostunittype", "TURRET MOBILE"
                "effigy", "comeffigylvl5"
                "minimum_respawn_stun", "5.0"
                "distance_stun_multiplier", "1.0"
                "fall_damage_multiplier", "5.0"
            ]
          extras = Map.ofList [
                "autoheal", "5.0"
                "cancapture", "true"
                "cancloak", "true"
                "canmanualfire", "true"
                "canselfrepair", "true"
                "capturable", "false"
                "capturespeed", "1800.0"
                "cloakcost", "100.0"
                "cloakcostmoving", "1000.0"
                "damagemodifier", "0.1"
                "hidedamage", "true"
                "holdsteady", "true"
                "icontype", "armcom"
                "sightemitheight", "40.0"
                "mass", "4900.0"
                "mincloakdistance", "50.0"
                "nochasecategory", "ALL"
                "radardistance", "1200.0"
                "radaremitheight", "40.0"
                "reclaimable", "false"
                "releaseheld", "true"
                "selfdestructcountdown", "5.0"
                "showplayername", "true"
                "sonardistance", "600.0"
                "upright", "true"
            ] }

    let armcomlvl10Def : UnitDef =
        { name = "armcomlvl10"
          subfolder = "other/evocom"
          metalCost = ValueOrExpr.Concrete 11000.0
          energyCost = ValueOrExpr.Concrete 110000.0
          buildTime = ValueOrExpr.Concrete 195600.0
          health = ValueOrExpr.Concrete 13200.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMCOMHILVL.s3o"
          buildPic = Some "ARMCOM.DDS"
          script = Some "Units/ARMCOMHILVL.lua"
          corpse = Some "DEAD"
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderexplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 37.5
              maxAcc = 0.18
              maxDec = 1.125
              turnRate = 1148.0
              movementClass = Some "COMMANDERBOT"
              maxSlope = Some 20.0
              maxWaterDepth = Some 35.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 140.0
              turnInPlaceSpeedLimit = Some 0.825
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 1800.0
              buildDistance = Some 217.0
              buildOptions = []
              terraformSpeed = Some 1500.0 })
          weapons = Some [
              { name = "backlauncher"
                displayName = "HeavyRockets"
                weaponType = Some "StarburstLauncher"
                damage = Map.ofList [
                    "default", 4400.0
                ]
                range = Some (ValueOrExpr.Concrete 870.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.0)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 121.0
                accuracy = None
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.61
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "Rockhvy1"
                soundHit = Some "xplomed4"
                explosiongenerator = Some "custom:genericshellexplosion-large-bomb"
                rgbColor = None
                customParams = Map.ofList [
                    "projectile_destruction_method", "descend"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "cegtag", "missiletrailmedium-starburst"
                    "craterareaofeffect", "70.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "100.0"
                    "flighttime", "7.4"
                    "model", "corkbmissl1.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "8.0"
                    "smoketime", "30.0"
                    "smokesize", "12.0"
                    "smokecolor", "0.7"
                    "smokeTrailCastShadow", "true"
                    "soundhitwet", "splssml"
                    "stockpile", "true"
                    "stockpiletime", "10.0"
                    "texture1", "null"
                    "texture2", "smoketrailbar"
                    "texture3", "null"
                    "turnrate", "15000.0"
                    "weaponacceleration", "250.0"
                    "weapontimer", "1.9"
                ] }
              { name = "armcomsealaser"
                displayName = "UWSupernovaBeam"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 1400.0
                    "subs", 700.0
                ]
                range = Some (ValueOrExpr.Concrete 500.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.28)
                weaponVelocity = Some 700.0
                areaOfEffect = Some 70.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "uwlasrfir1"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-medium-blue"
                rgbColor = Some "0.5 0.7 0.10"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTAIR"
                    "avoidfeature", "false"
                    "beamtime", "0.16"
                    "camerashake", "0.0"
                    "corethickness", "0.6"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "firestarter", "90.0"
                    "firesubmersed", "true"
                    "intensity", "0.6"
                    "laserflaresize", "5.5"
                    "rgbcolor2", "1 1 1"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "3.5"
                    "waterweapon", "true"
                ] }
              { name = "disintegrator"
                displayName = "Disintegrator"
                weaponType = Some "DGun"
                damage = Map.ofList [
                    "commanders", 0.0
                    "default", 99999.0
                    "scavboss", 1000.0
                    "raptorqueen", 1000.0
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
                    "soundhitwet", "sizzlexs"
                    "soundhitvolume", "36.0"
                    "soundstartvolume", "96.0"
                    "soundtrigger", "true"
                    "waterweapon", "true"
                    "weapontimer", "4.2"
                ] }
              { name = "longgun"
                displayName = "Arcing Stun Beam"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 60000.0
                ]
                range = Some (ValueOrExpr.Concrete 600.0)
                reloadTime = Some (ValueOrExpr.Concrete 8.0)
                weaponVelocity = Some 1500.0
                areaOfEffect = Some 60.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrcrw2"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-emp"
                rgbColor = Some "0.7 0.7 1"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "GROUNDSCOUT"
                    "mount_onlytargetcategory", "EMPABLE"
                    "beamtime", "0.15"
                    "collidefriendly", "false"
                    "corethickness", "0.23"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "largebeamlaser", "true"
                    "laserflaresize", "5.05"
                    "paralyzer", "true"
                    "paralyzetime", "7.0"
                    "scrollspeed", "5.0"
                    "soundhitdry", "hackshot"
                    "soundhitwet", "sizzle"
                    "soundstartvolume", "30.0"
                    "soundhitdryvolume", "40.0"
                    "soundhitwetvolume", "30.0"
                    "soundtrigger", "1.0"
                    "texture3", "largebeam"
                    "thickness", "3.0"
                    "tilelength", "150.0"
                ] }
              { name = "shortgun"
                displayName = "Short-Range Lightening Discharge"
                weaponType = Some "LightningCannon"
                damage = Map.ofList [
                    "default", 118.0
                ]
                range = Some (ValueOrExpr.Concrete 500.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.1)
                weaponVelocity = Some 400.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lghthvy2"
                soundHit = Some ""
                explosiongenerator = Some "custom:genericshellexplosion-medium-lightning2"
                rgbColor = Some "1.0, 0.7, 0.0"
                customParams = Map.ofList [
                    "spark_ceg", "genericshellexplosion-splash-lightning"
                    "spark_forkdamage", "0.33"
                    "spark_maxunits", "12"
                    "spark_range", "100"
                ]
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "mount_fastautoretargeting", "true"
                    "avoidfeature", "false"
                    "beamttl", "1.0"
                    "burst", "3.0"
                    "burstrate", "0.03333"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "1.0"
                    "energypershot", "5.0"
                    "firestarter", "50.0"
                    "intensity", "24.0"
                    "soundhitwet", ""
                    "soundtrigger", "true"
                    "thickness", "1.5"
                ] }
              { name = "empflashbang"
                displayName = "EMP Damage-Mitigating Flashbang"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 20000.0
                ]
                range = Some (ValueOrExpr.Concrete 3.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.25)
                weaponVelocity = Some 1.0
                areaOfEffect = Some 50.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.001
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "xplosml5"
                soundHit = None
                explosiongenerator = Some "custom:genericshellexplosion-huge-lightning"
                rgbColor = Some "1 1 1"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "COMMANDER"
                    "avoidfeature", "false"
                    "beamdecay", ".8"
                    "beamttl", "0.8"
                    "burnblow", "true"
                    "collideenemy", "false"
                    "collidefeature", "false"
                    "collidefriendly", "false"
                    "collideground", "false"
                    "collideneutral", "false"
                    "corethickness", "1.0"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "falloffrate", "0.0"
                    "impactonly", "1.0"
                    "laserflaresize", "8.8"
                    "paralyzer", "true"
                    "paralyzetime", "8.0"
                    "soundhitdry", ""
                    "soundhitwet", ""
                    "soundtrigger", "1.0"
                    "thickness", "6.0"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 2000.0)
              metalMake = Some (ValueOrExpr.Concrete 50.0)
              energyStorage = Some 10000.0
              metalStorage = Some 500.0
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "35 12 54"
                collisionVolumeType = Some "CylY"
                damage = Some 44000.0
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
          ])
          sounds = Some (
            { build = Some "nanlath1"
              repair = Some "repair1"
              working = Some "reclaim1"
              underAttack = Some "warning2"
              cancelDestruct = Some "cancel2"
              capture = Some "capture1"
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["armcom1"; "armcom2"; "armcom3"; "armcom4"]
              select = ["armcomsel"] })
          customParams = Map.ofList [
              "unitgroup", "builder"
              "area_mex_def", "armmex"
              "iscommander", "true"
              "effigy_offset", "1.0"
              "evocomlvl", "10.0"
              "inheritxpratemultiplier", "0.5"
              "childreninheritxp", "TURRET MOBILEBUILT"
              "parentsinheritxp", "TURRET MOBILEBUILT"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "paralyzemultiplier", "0.025"
              "subfolder", ""
              "workertimeboost", "3.5"
              "wtboostunittype", "TURRET MOBILE"
              "effigy", "comeffigylvl5"
              "minimum_respawn_stun", "5.0"
              "distance_stun_multiplier", "1.0"
              "fall_damage_multiplier", "5.0"
          ]
          extras = Map.ofList [
              "autoheal", "5.0"
              "cancapture", "true"
              "cancloak", "true"
              "canmanualfire", "true"
              "canselfrepair", "true"
              "capturable", "false"
              "capturespeed", "1800.0"
              "cloakcost", "100.0"
              "cloakcostmoving", "1000.0"
              "damagemodifier", "0.1"
              "hidedamage", "true"
              "holdsteady", "true"
              "icontype", "armcom"
              "sightemitheight", "40.0"
              "mass", "4900.0"
              "mincloakdistance", "50.0"
              "nochasecategory", "ALL"
              "radardistance", "1200.0"
              "radaremitheight", "40.0"
              "reclaimable", "false"
              "releaseheld", "true"
              "selfdestructcountdown", "5.0"
              "showplayername", "true"
              "sonardistance", "600.0"
              "upright", "true"
          ] }

    let armcomlvl10ToFlat (def: UnitDef) : Armcomlvl10 =
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
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          workerTime = def.builder.Value.workerTime
          buildDistance = def.builder.Value.buildDistance.Value
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyMake = def.economy.Value.energyMake.Value
          metalMake = def.economy.Value.metalMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armcomlvl10ToUnitDef (flat: Armcomlvl10) : UnitDef =
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
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = Some flat.movementClass
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = Some flat.buildDistance
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = Some flat.weapons
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = Some flat.metalMake
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armcomlvl2 =
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

    let armcomlvl2 : Armcomlvl2 =
        { name = "armcomlvl2"
          subfolder = "other/evocom"
          metalCost = ValueOrExpr.Concrete 3000.0
          energyCost = ValueOrExpr.Concrete 30000.0
          buildTime = ValueOrExpr.Concrete 75000.0
          health = ValueOrExpr.Concrete 6000.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = None
          buildPic = Some "ARMCOM.DDS"
          script = Some "Units/ARMCOM_lus.lua"
          corpse = Some "DEAD"
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderexplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
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
          workerTime = ValueOrExpr.Concrete 324.0
          buildDistance = 153.0
          buildOptions = []
          terraformSpeed = 1500.0
          energyMake = ValueOrExpr.Concrete 50.0
          metalMake = ValueOrExpr.Concrete 3.0
          energyStorage = 1000.0
          metalStorage = 500.0
          weapons = [
                { name = "shortgun"
                  displayName = "Scatter Beamer"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 14.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.1)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 10.0
                  accuracy = Some 50.0
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "beamershot2"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-beamer"
                  rgbColor = Some "0 0 1"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "mount_fastautoretargeting", "true"
                      "allowNonBlockingAim", "true"
                      "avoidfeature", "false"
                      "beamdecay", "0.05"
                      "beamtime", "0.1"
                      "beamttl", "1.0"
                      "corethickness", "0.233"
                      "burnblow", "true"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "explosionscar", "false"
                      "firestarter", "100.0"
                      "intensity", "0.7"
                      "laserflaresize", "9.35"
                      "projectiles", "9.0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "sprayangle", "2500.0"
                  ] }
                { name = "armcomsealaser"
                  displayName = "Light underwater-combat laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 400.0
                      "subs", 200.0
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
                  rgbColor = Some "0 0 0.8"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTAIR"
                      "avoidfeature", "false"
                      "beamtime", "0.3"
                      "camerashake", "0.0"
                      "corethickness", "0.4"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "35.0"
                      "firesubmersed", "true"
                      "intensity", "0.3"
                      "laserflaresize", "7.7"
                      "rgbcolor2", "0.0 0.0 0.2"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "5.0"
                      "waterweapon", "true"
                  ] }
                { name = "disintegrator"
                  displayName = "Disintegrator"
                  weaponType = Some "DGun"
                  damage = Map.ofList [
                      "commanders", 0.0
                      "default", 99999.0
                      "scavboss", 1000.0
                      "raptorqueen", 1000.0
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
                      "soundhitwet", "sizzlexs"
                      "soundhitvolume", "36.0"
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
                  damage = Some 12000.0
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
                "unitgroup", "builder"
                "area_mex_def", "armmex"
                "iscommander", "true"
                "effigy_offset", "1.0"
                "evocomlvl", "2.0"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "paralyzemultiplier", "0.025"
                "subfolder", ""
                "combatradius", "0.0"
                "workertimeboost", "2.0"
                "wtboostunittype", "TURRET"
                "inheritxpratemultiplier", "0.5"
                "childreninheritxp", "TURRET MOBILEBUILT"
                "parentsinheritxp", "TURRET MOBILEBUILT"
                "evolution_health_transfer", "percentage"
                "evolution_target", "armcomlvl3"
                "evolution_condition", "timer"
                "evolution_timer", "99999.0"
                "evolution_power_threshold", "22000.0"
                "evolution_power_multiplier", "1.0"
                "effigy", "comeffigylvl1"
                "minimum_respawn_stun", "5.0"
                "distance_stun_multiplier", "1.0"
                "fall_damage_multiplier", "5.0"
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
                "icontype", "armcom"
                "sightemitheight", "40.0"
                "mass", "4900.0"
                "mincloakdistance", "50.0"
                "nochasecategory", "ALL"
                "radardistance", "700.0"
                "radaremitheight", "40.0"
                "reclaimable", "false"
                "releaseheld", "true"
                "selfdestructcountdown", "5.0"
                "showplayername", "true"
                "sonardistance", "450.0"
                "upright", "true"
            ] }

    let armcomlvl2Def : UnitDef =
        { name = "armcomlvl2"
          subfolder = "other/evocom"
          metalCost = ValueOrExpr.Concrete 3000.0
          energyCost = ValueOrExpr.Concrete 30000.0
          buildTime = ValueOrExpr.Concrete 75000.0
          health = ValueOrExpr.Concrete 6000.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = None
          buildPic = Some "ARMCOM.DDS"
          script = Some "Units/ARMCOM_lus.lua"
          corpse = Some "DEAD"
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderexplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 37.5
              maxAcc = 0.18
              maxDec = 1.125
              turnRate = 1148.0
              movementClass = Some "COMMANDERBOT"
              maxSlope = Some 20.0
              maxWaterDepth = Some 35.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 140.0
              turnInPlaceSpeedLimit = Some 0.825
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 324.0
              buildDistance = Some 153.0
              buildOptions = []
              terraformSpeed = Some 1500.0 })
          weapons = Some [
              { name = "shortgun"
                displayName = "Scatter Beamer"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 14.0
                ]
                range = Some (ValueOrExpr.Concrete 300.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.1)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 10.0
                accuracy = Some 50.0
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "beamershot2"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-beamer"
                rgbColor = Some "0 0 1"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "mount_fastautoretargeting", "true"
                    "allowNonBlockingAim", "true"
                    "avoidfeature", "false"
                    "beamdecay", "0.05"
                    "beamtime", "0.1"
                    "beamttl", "1.0"
                    "corethickness", "0.233"
                    "burnblow", "true"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "explosionscar", "false"
                    "firestarter", "100.0"
                    "intensity", "0.7"
                    "laserflaresize", "9.35"
                    "projectiles", "9.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "sprayangle", "2500.0"
                ] }
              { name = "armcomsealaser"
                displayName = "Light underwater-combat laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 400.0
                    "subs", 200.0
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
                rgbColor = Some "0 0 0.8"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTAIR"
                    "avoidfeature", "false"
                    "beamtime", "0.3"
                    "camerashake", "0.0"
                    "corethickness", "0.4"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "firestarter", "35.0"
                    "firesubmersed", "true"
                    "intensity", "0.3"
                    "laserflaresize", "7.7"
                    "rgbcolor2", "0.0 0.0 0.2"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "5.0"
                    "waterweapon", "true"
                ] }
              { name = "disintegrator"
                displayName = "Disintegrator"
                weaponType = Some "DGun"
                damage = Map.ofList [
                    "commanders", 0.0
                    "default", 99999.0
                    "scavboss", 1000.0
                    "raptorqueen", 1000.0
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
                    "soundhitwet", "sizzlexs"
                    "soundhitvolume", "36.0"
                    "soundstartvolume", "96.0"
                    "soundtrigger", "true"
                    "waterweapon", "true"
                    "weapontimer", "4.2"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 50.0)
              metalMake = Some (ValueOrExpr.Concrete 3.0)
              energyStorage = Some 1000.0
              metalStorage = Some 500.0
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "35 12 54"
                collisionVolumeType = Some "CylY"
                damage = Some 12000.0
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
          ])
          sounds = Some (
            { build = Some "nanlath1"
              repair = Some "repair1"
              working = Some "reclaim1"
              underAttack = Some "warning2"
              cancelDestruct = Some "cancel2"
              capture = Some "capture1"
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["armcom1"; "armcom2"; "armcom3"; "armcom4"]
              select = ["armcomsel"] })
          customParams = Map.ofList [
              "unitgroup", "builder"
              "area_mex_def", "armmex"
              "iscommander", "true"
              "effigy_offset", "1.0"
              "evocomlvl", "2.0"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "paralyzemultiplier", "0.025"
              "subfolder", ""
              "combatradius", "0.0"
              "workertimeboost", "2.0"
              "wtboostunittype", "TURRET"
              "inheritxpratemultiplier", "0.5"
              "childreninheritxp", "TURRET MOBILEBUILT"
              "parentsinheritxp", "TURRET MOBILEBUILT"
              "evolution_health_transfer", "percentage"
              "evolution_target", "armcomlvl3"
              "evolution_condition", "timer"
              "evolution_timer", "99999.0"
              "evolution_power_threshold", "22000.0"
              "evolution_power_multiplier", "1.0"
              "effigy", "comeffigylvl1"
              "minimum_respawn_stun", "5.0"
              "distance_stun_multiplier", "1.0"
              "fall_damage_multiplier", "5.0"
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
              "icontype", "armcom"
              "sightemitheight", "40.0"
              "mass", "4900.0"
              "mincloakdistance", "50.0"
              "nochasecategory", "ALL"
              "radardistance", "700.0"
              "radaremitheight", "40.0"
              "reclaimable", "false"
              "releaseheld", "true"
              "selfdestructcountdown", "5.0"
              "showplayername", "true"
              "sonardistance", "450.0"
              "upright", "true"
          ] }

    let armcomlvl2ToFlat (def: UnitDef) : Armcomlvl2 =
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
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          workerTime = def.builder.Value.workerTime
          buildDistance = def.builder.Value.buildDistance.Value
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyMake = def.economy.Value.energyMake.Value
          metalMake = def.economy.Value.metalMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armcomlvl2ToUnitDef (flat: Armcomlvl2) : UnitDef =
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
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = Some flat.movementClass
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = Some flat.buildDistance
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = Some flat.weapons
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = Some flat.metalMake
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armcomlvl3 =
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

    let armcomlvl3 : Armcomlvl3 =
        { name = "armcomlvl3"
          subfolder = "other/evocom"
          metalCost = ValueOrExpr.Concrete 4000.0
          energyCost = ValueOrExpr.Concrete 40000.0
          buildTime = ValueOrExpr.Concrete 85000.0
          health = ValueOrExpr.Concrete 6900.0
          sightDistance = ValueOrExpr.Concrete 550.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMCOMHILVL.s3o"
          buildPic = Some "ARMCOM.DDS"
          script = Some "Units/ARMCOMHILVL.lua"
          corpse = Some "DEAD"
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderexplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
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
          workerTime = ValueOrExpr.Concrete 447.0
          buildDistance = 161.0
          buildOptions = []
          terraformSpeed = 1500.0
          energyMake = ValueOrExpr.Concrete 75.0
          metalMake = ValueOrExpr.Concrete 5.0
          energyStorage = 1500.0
          metalStorage = 500.0
          weapons = [
                { name = "backlauncher"
                  displayName = "HeavyRockets"
                  weaponType = Some "StarburstLauncher"
                  damage = Map.ofList [
                      "default", 550.0
                  ]
                  range = Some (ValueOrExpr.Concrete 435.0)
                  reloadTime = Some (ValueOrExpr.Concrete 3.33)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 55.0
                  accuracy = None
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.61
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "Rockhvy1"
                  soundHit = Some "xplomed4"
                  explosiongenerator = Some "custom:genericshellexplosion-large-bomb"
                  rgbColor = None
                  customParams = Map.ofList [
                      "projectile_destruction_method", "descend"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "MOBILE"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "cegtag", "missiletrailmedium-starburst"
                      "craterareaofeffect", "70.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "100.0"
                      "flighttime", "7.4"
                      "model", "corkbmissl1.s3o"
                      "smoketrail", "true"
                      "smokePeriod", "8.0"
                      "smoketime", "30.0"
                      "smokesize", "12.0"
                      "smokecolor", "0.7"
                      "smokeTrailCastShadow", "true"
                      "soundhitwet", "splssml"
                      "stockpile", "true"
                      "stockpiletime", "10.0"
                      "texture1", "null"
                      "texture2", "smoketrailbar"
                      "texture3", "null"
                      "turnrate", "15000.0"
                      "weaponacceleration", "250.0"
                      "weapontimer", "0.87"
                  ] }
                { name = "armcomsealaser"
                  displayName = "J7NSLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 300.0
                      "subs", 150.0
                  ]
                  range = Some (ValueOrExpr.Concrete 450.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.44)
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
                  rgbColor = Some "0.2 0.8 0.3"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTAIR"
                      "avoidfeature", "false"
                      "beamtime", "0.16"
                      "beamttl", "2.4"
                      "camerashake", "0.0"
                      "corethickness", "0.1"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "35.0"
                      "firesubmersed", "true"
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
                  displayName = "Disintegrator"
                  weaponType = Some "DGun"
                  damage = Map.ofList [
                      "commanders", 0.0
                      "default", 99999.0
                      "scavboss", 1000.0
                      "raptorqueen", 1000.0
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
                      "soundhitwet", "sizzlexs"
                      "soundhitvolume", "36.0"
                      "soundstartvolume", "96.0"
                      "soundtrigger", "true"
                      "waterweapon", "true"
                      "weapontimer", "4.2"
                  ] }
                { name = "longgun"
                  displayName = "Arcing Stun Beam"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 16000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 410.0)
                  reloadTime = Some (ValueOrExpr.Concrete 8.0)
                  weaponVelocity = Some 1500.0
                  areaOfEffect = Some 60.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrcrw2"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-emp"
                  rgbColor = Some "0.7 0.7 1"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "GROUNDSCOUT"
                      "mount_onlytargetcategory", "EMPABLE"
                      "beamtime", "0.1"
                      "collidefriendly", "false"
                      "corethickness", "0.23"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "largebeamlaser", "true"
                      "laserflaresize", "3.05"
                      "paralyzer", "true"
                      "paralyzetime", "7.0"
                      "scrollspeed", "5.0"
                      "soundhitdry", "hackshot"
                      "soundhitwet", "sizzle"
                      "soundstartvolume", "30.0"
                      "soundhitdryvolume", "40.0"
                      "soundhitwetvolume", "30.0"
                      "soundtrigger", "1.0"
                      "texture3", "largebeam"
                      "thickness", "1.5"
                      "tilelength", "150.0"
                  ] }
                { name = "shortgun"
                  displayName = "Scatter Beamer"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 15.0
                  ]
                  range = Some (ValueOrExpr.Concrete 350.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.1)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 10.0
                  accuracy = Some 50.0
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "beamershot2"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-beamer"
                  rgbColor = Some "0 0 1"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "mount_fastautoretargeting", "true"
                      "allowNonBlockingAim", "true"
                      "avoidfeature", "false"
                      "beamdecay", "0.05"
                      "beamtime", "0.1"
                      "beamttl", "1.0"
                      "corethickness", "0.233"
                      "burnblow", "true"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "explosionscar", "false"
                      "firestarter", "100.0"
                      "intensity", "0.7"
                      "laserflaresize", "9.35"
                      "projectiles", "12.0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "sprayangle", "3000.0"
                  ] }
                { name = "empflashbang"
                  displayName = "EMP Damage-Mitigating Flashbang"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "default", 20000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 3.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.25)
                  weaponVelocity = Some 1.0
                  areaOfEffect = Some 50.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.001
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "xplosml5"
                  soundHit = None
                  explosiongenerator = Some "custom:genericshellexplosion-huge-lightning"
                  rgbColor = Some "1 1 1"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "COMMANDER"
                      "avoidfeature", "false"
                      "beamdecay", ".8"
                      "beamttl", "0.8"
                      "burnblow", "true"
                      "collideenemy", "false"
                      "collidefeature", "false"
                      "collidefriendly", "false"
                      "collideground", "false"
                      "collideneutral", "false"
                      "corethickness", "1.0"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "falloffrate", "0.0"
                      "impactonly", "1.0"
                      "laserflaresize", "8.8"
                      "paralyzer", "true"
                      "paralyzetime", "8.0"
                      "soundhitdry", ""
                      "soundhitwet", ""
                      "soundtrigger", "1.0"
                      "thickness", "6.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "35 12 54"
                  collisionVolumeType = Some "CylY"
                  damage = Some 16000.0
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
                "unitgroup", "builder"
                "area_mex_def", "armmex"
                "iscommander", "true"
                "effigy_offset", "1.0"
                "evocomlvl", "3.0"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "paralyzemultiplier", "0.025"
                "subfolder", ""
                "evolution_health_transfer", "percentage"
                "evolution_target", "armcomlvl4"
                "evolution_condition", "timer"
                "evolution_timer", "99999.0"
                "evolution_power_threshold", "53000.0"
                "evolution_power_multiplier", "1.0"
                "combatradius", "0.0"
                "workertimeboost", "3.5"
                "wtboostunittype", "TURRET"
                "inheritxpratemultiplier", "0.5"
                "childreninheritxp", "TURRET MOBILEBUILT"
                "parentsinheritxp", "TURRET MOBILEBUILT"
                "effigy", "comeffigylvl2"
                "minimum_respawn_stun", "5.0"
                "distance_stun_multiplier", "1.0"
                "fall_damage_multiplier", "5.0"
            ]
          extras = Map.ofList [
                "autoheal", "5.0"
                "cancapture", "true"
                "cancloak", "true"
                "canmanualfire", "true"
                "canselfrepair", "true"
                "capturable", "false"
                "capturespeed", "1800.0"
                "cloakcost", "100.0"
                "cloakcostmoving", "1000.0"
                "damagemodifier", "0.1"
                "hidedamage", "true"
                "holdsteady", "true"
                "icontype", "armcom"
                "sightemitheight", "40.0"
                "mass", "4900.0"
                "mincloakdistance", "50.0"
                "nochasecategory", "ALL"
                "radardistance", "1100.0"
                "radaremitheight", "40.0"
                "reclaimable", "false"
                "releaseheld", "true"
                "selfdestructcountdown", "5.0"
                "showplayername", "true"
                "sonardistance", "550.0"
                "upright", "true"
            ] }

    let armcomlvl3Def : UnitDef =
        { name = "armcomlvl3"
          subfolder = "other/evocom"
          metalCost = ValueOrExpr.Concrete 4000.0
          energyCost = ValueOrExpr.Concrete 40000.0
          buildTime = ValueOrExpr.Concrete 85000.0
          health = ValueOrExpr.Concrete 6900.0
          sightDistance = ValueOrExpr.Concrete 550.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMCOMHILVL.s3o"
          buildPic = Some "ARMCOM.DDS"
          script = Some "Units/ARMCOMHILVL.lua"
          corpse = Some "DEAD"
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderexplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 37.5
              maxAcc = 0.18
              maxDec = 1.125
              turnRate = 1148.0
              movementClass = Some "COMMANDERBOT"
              maxSlope = Some 20.0
              maxWaterDepth = Some 35.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 140.0
              turnInPlaceSpeedLimit = Some 0.825
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 447.0
              buildDistance = Some 161.0
              buildOptions = []
              terraformSpeed = Some 1500.0 })
          weapons = Some [
              { name = "backlauncher"
                displayName = "HeavyRockets"
                weaponType = Some "StarburstLauncher"
                damage = Map.ofList [
                    "default", 550.0
                ]
                range = Some (ValueOrExpr.Concrete 435.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.33)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 55.0
                accuracy = None
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.61
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "Rockhvy1"
                soundHit = Some "xplomed4"
                explosiongenerator = Some "custom:genericshellexplosion-large-bomb"
                rgbColor = None
                customParams = Map.ofList [
                    "projectile_destruction_method", "descend"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "cegtag", "missiletrailmedium-starburst"
                    "craterareaofeffect", "70.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "100.0"
                    "flighttime", "7.4"
                    "model", "corkbmissl1.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "8.0"
                    "smoketime", "30.0"
                    "smokesize", "12.0"
                    "smokecolor", "0.7"
                    "smokeTrailCastShadow", "true"
                    "soundhitwet", "splssml"
                    "stockpile", "true"
                    "stockpiletime", "10.0"
                    "texture1", "null"
                    "texture2", "smoketrailbar"
                    "texture3", "null"
                    "turnrate", "15000.0"
                    "weaponacceleration", "250.0"
                    "weapontimer", "0.87"
                ] }
              { name = "armcomsealaser"
                displayName = "J7NSLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 300.0
                    "subs", 150.0
                ]
                range = Some (ValueOrExpr.Concrete 450.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.44)
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
                rgbColor = Some "0.2 0.8 0.3"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTAIR"
                    "avoidfeature", "false"
                    "beamtime", "0.16"
                    "beamttl", "2.4"
                    "camerashake", "0.0"
                    "corethickness", "0.1"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "firestarter", "35.0"
                    "firesubmersed", "true"
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
                displayName = "Disintegrator"
                weaponType = Some "DGun"
                damage = Map.ofList [
                    "commanders", 0.0
                    "default", 99999.0
                    "scavboss", 1000.0
                    "raptorqueen", 1000.0
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
                    "soundhitwet", "sizzlexs"
                    "soundhitvolume", "36.0"
                    "soundstartvolume", "96.0"
                    "soundtrigger", "true"
                    "waterweapon", "true"
                    "weapontimer", "4.2"
                ] }
              { name = "longgun"
                displayName = "Arcing Stun Beam"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 16000.0
                ]
                range = Some (ValueOrExpr.Concrete 410.0)
                reloadTime = Some (ValueOrExpr.Concrete 8.0)
                weaponVelocity = Some 1500.0
                areaOfEffect = Some 60.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrcrw2"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-emp"
                rgbColor = Some "0.7 0.7 1"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "GROUNDSCOUT"
                    "mount_onlytargetcategory", "EMPABLE"
                    "beamtime", "0.1"
                    "collidefriendly", "false"
                    "corethickness", "0.23"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "largebeamlaser", "true"
                    "laserflaresize", "3.05"
                    "paralyzer", "true"
                    "paralyzetime", "7.0"
                    "scrollspeed", "5.0"
                    "soundhitdry", "hackshot"
                    "soundhitwet", "sizzle"
                    "soundstartvolume", "30.0"
                    "soundhitdryvolume", "40.0"
                    "soundhitwetvolume", "30.0"
                    "soundtrigger", "1.0"
                    "texture3", "largebeam"
                    "thickness", "1.5"
                    "tilelength", "150.0"
                ] }
              { name = "shortgun"
                displayName = "Scatter Beamer"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 15.0
                ]
                range = Some (ValueOrExpr.Concrete 350.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.1)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 10.0
                accuracy = Some 50.0
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "beamershot2"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-beamer"
                rgbColor = Some "0 0 1"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "mount_fastautoretargeting", "true"
                    "allowNonBlockingAim", "true"
                    "avoidfeature", "false"
                    "beamdecay", "0.05"
                    "beamtime", "0.1"
                    "beamttl", "1.0"
                    "corethickness", "0.233"
                    "burnblow", "true"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "explosionscar", "false"
                    "firestarter", "100.0"
                    "intensity", "0.7"
                    "laserflaresize", "9.35"
                    "projectiles", "12.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "sprayangle", "3000.0"
                ] }
              { name = "empflashbang"
                displayName = "EMP Damage-Mitigating Flashbang"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 20000.0
                ]
                range = Some (ValueOrExpr.Concrete 3.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.25)
                weaponVelocity = Some 1.0
                areaOfEffect = Some 50.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.001
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "xplosml5"
                soundHit = None
                explosiongenerator = Some "custom:genericshellexplosion-huge-lightning"
                rgbColor = Some "1 1 1"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "COMMANDER"
                    "avoidfeature", "false"
                    "beamdecay", ".8"
                    "beamttl", "0.8"
                    "burnblow", "true"
                    "collideenemy", "false"
                    "collidefeature", "false"
                    "collidefriendly", "false"
                    "collideground", "false"
                    "collideneutral", "false"
                    "corethickness", "1.0"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "falloffrate", "0.0"
                    "impactonly", "1.0"
                    "laserflaresize", "8.8"
                    "paralyzer", "true"
                    "paralyzetime", "8.0"
                    "soundhitdry", ""
                    "soundhitwet", ""
                    "soundtrigger", "1.0"
                    "thickness", "6.0"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 75.0)
              metalMake = Some (ValueOrExpr.Concrete 5.0)
              energyStorage = Some 1500.0
              metalStorage = Some 500.0
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "35 12 54"
                collisionVolumeType = Some "CylY"
                damage = Some 16000.0
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
          ])
          sounds = Some (
            { build = Some "nanlath1"
              repair = Some "repair1"
              working = Some "reclaim1"
              underAttack = Some "warning2"
              cancelDestruct = Some "cancel2"
              capture = Some "capture1"
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["armcom1"; "armcom2"; "armcom3"; "armcom4"]
              select = ["armcomsel"] })
          customParams = Map.ofList [
              "unitgroup", "builder"
              "area_mex_def", "armmex"
              "iscommander", "true"
              "effigy_offset", "1.0"
              "evocomlvl", "3.0"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "paralyzemultiplier", "0.025"
              "subfolder", ""
              "evolution_health_transfer", "percentage"
              "evolution_target", "armcomlvl4"
              "evolution_condition", "timer"
              "evolution_timer", "99999.0"
              "evolution_power_threshold", "53000.0"
              "evolution_power_multiplier", "1.0"
              "combatradius", "0.0"
              "workertimeboost", "3.5"
              "wtboostunittype", "TURRET"
              "inheritxpratemultiplier", "0.5"
              "childreninheritxp", "TURRET MOBILEBUILT"
              "parentsinheritxp", "TURRET MOBILEBUILT"
              "effigy", "comeffigylvl2"
              "minimum_respawn_stun", "5.0"
              "distance_stun_multiplier", "1.0"
              "fall_damage_multiplier", "5.0"
          ]
          extras = Map.ofList [
              "autoheal", "5.0"
              "cancapture", "true"
              "cancloak", "true"
              "canmanualfire", "true"
              "canselfrepair", "true"
              "capturable", "false"
              "capturespeed", "1800.0"
              "cloakcost", "100.0"
              "cloakcostmoving", "1000.0"
              "damagemodifier", "0.1"
              "hidedamage", "true"
              "holdsteady", "true"
              "icontype", "armcom"
              "sightemitheight", "40.0"
              "mass", "4900.0"
              "mincloakdistance", "50.0"
              "nochasecategory", "ALL"
              "radardistance", "1100.0"
              "radaremitheight", "40.0"
              "reclaimable", "false"
              "releaseheld", "true"
              "selfdestructcountdown", "5.0"
              "showplayername", "true"
              "sonardistance", "550.0"
              "upright", "true"
          ] }

    let armcomlvl3ToFlat (def: UnitDef) : Armcomlvl3 =
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
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          workerTime = def.builder.Value.workerTime
          buildDistance = def.builder.Value.buildDistance.Value
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyMake = def.economy.Value.energyMake.Value
          metalMake = def.economy.Value.metalMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armcomlvl3ToUnitDef (flat: Armcomlvl3) : UnitDef =
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
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = Some flat.movementClass
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = Some flat.buildDistance
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = Some flat.weapons
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = Some flat.metalMake
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armcomlvl4 =
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

    let armcomlvl4 : Armcomlvl4 =
        { name = "armcomlvl4"
          subfolder = "other/evocom"
          metalCost = ValueOrExpr.Concrete 5000.0
          energyCost = ValueOrExpr.Concrete 50000.0
          buildTime = ValueOrExpr.Concrete 94800.0
          health = ValueOrExpr.Concrete 7800.0
          sightDistance = ValueOrExpr.Concrete 550.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMCOMHILVL.s3o"
          buildPic = Some "ARMCOM.DDS"
          script = Some "Units/ARMCOMHILVL.lua"
          corpse = Some "DEAD"
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderexplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
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
          workerTime = ValueOrExpr.Concrete 545.0
          buildDistance = 169.0
          buildOptions = []
          terraformSpeed = 1500.0
          energyMake = ValueOrExpr.Concrete 125.0
          metalMake = ValueOrExpr.Concrete 9.0
          energyStorage = 2000.0
          metalStorage = 500.0
          weapons = [
                { name = "backlauncher"
                  displayName = "HeavyRockets"
                  weaponType = Some "StarburstLauncher"
                  damage = Map.ofList [
                      "default", 800.0
                  ]
                  range = Some (ValueOrExpr.Concrete 550.0)
                  reloadTime = Some (ValueOrExpr.Concrete 3.33)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 70.0
                  accuracy = None
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.61
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "Rockhvy1"
                  soundHit = Some "xplomed4"
                  explosiongenerator = Some "custom:genericshellexplosion-large-bomb"
                  rgbColor = None
                  customParams = Map.ofList [
                      "projectile_destruction_method", "descend"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "MOBILE"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "cegtag", "missiletrailmedium-starburst"
                      "craterareaofeffect", "70.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "100.0"
                      "flighttime", "7.4"
                      "model", "corkbmissl1.s3o"
                      "smoketrail", "true"
                      "smokePeriod", "8.0"
                      "smoketime", "30.0"
                      "smokesize", "12.0"
                      "smokecolor", "0.7"
                      "smokeTrailCastShadow", "true"
                      "soundhitwet", "splssml"
                      "stockpile", "true"
                      "stockpiletime", "10.0"
                      "texture1", "null"
                      "texture2", "smoketrailbar"
                      "texture3", "null"
                      "turnrate", "15000.0"
                      "weaponacceleration", "250.0"
                      "weapontimer", "1.1"
                  ] }
                { name = "armcomsealaser"
                  displayName = "J7NSLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 400.0
                      "subs", 200.0
                  ]
                  range = Some (ValueOrExpr.Concrete 450.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.36)
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
                  rgbColor = Some "0.2 0.8 0.3"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTAIR"
                      "avoidfeature", "false"
                      "beamtime", "0.16"
                      "beamttl", "2.4"
                      "camerashake", "0.0"
                      "corethickness", "0.1"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "35.0"
                      "firesubmersed", "true"
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
                  displayName = "Disintegrator"
                  weaponType = Some "DGun"
                  damage = Map.ofList [
                      "commanders", 0.0
                      "default", 99999.0
                      "scavboss", 1000.0
                      "raptorqueen", 1000.0
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
                      "soundhitwet", "sizzlexs"
                      "soundhitvolume", "36.0"
                      "soundstartvolume", "96.0"
                      "soundtrigger", "true"
                      "waterweapon", "true"
                      "weapontimer", "4.2"
                  ] }
                { name = "longgun"
                  displayName = "Arcing Stun Beam"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 22000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 500.0)
                  reloadTime = Some (ValueOrExpr.Concrete 8.0)
                  weaponVelocity = Some 1500.0
                  areaOfEffect = Some 60.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrcrw2"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-emp"
                  rgbColor = Some "0.7 0.7 1"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "GROUNDSCOUT"
                      "mount_onlytargetcategory", "EMPABLE"
                      "beamtime", "0.1"
                      "collidefriendly", "false"
                      "corethickness", "0.23"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "largebeamlaser", "true"
                      "laserflaresize", "3.05"
                      "paralyzer", "true"
                      "paralyzetime", "7.0"
                      "scrollspeed", "5.0"
                      "soundhitdry", "hackshot"
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "soundstartvolume", "30.0"
                      "soundhitdryvolume", "40.0"
                      "soundhitwetvolume", "30.0"
                      "texture3", "largebeam"
                      "thickness", "1.5"
                      "tilelength", "150.0"
                  ] }
                { name = "shortgun"
                  displayName = "Scatter Beamer"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 25.0
                  ]
                  range = Some (ValueOrExpr.Concrete 350.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.1)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 10.0
                  accuracy = Some 50.0
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "beamershot2"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-beamer"
                  rgbColor = Some "0 0 1"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "mount_fastautoretargeting", "true"
                      "allowNonBlockingAim", "true"
                      "avoidfeature", "false"
                      "beamdecay", "0.05"
                      "beamtime", "0.1"
                      "beamttl", "1.0"
                      "corethickness", "0.233"
                      "burnblow", "true"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "explosionscar", "false"
                      "firestarter", "100.0"
                      "intensity", "0.7"
                      "laserflaresize", "9.35"
                      "projectiles", "16.0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "sprayangle", "3500.0"
                  ] }
                { name = "empflashbang"
                  displayName = "EMP Damage-Mitigating Flashbang"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "default", 20000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 3.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.25)
                  weaponVelocity = Some 1.0
                  areaOfEffect = Some 50.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.001
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "xplosml5"
                  soundHit = None
                  explosiongenerator = Some "custom:genericshellexplosion-huge-lightning"
                  rgbColor = Some "1 1 1"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "COMMANDER"
                      "avoidfeature", "false"
                      "beamdecay", ".8"
                      "beamttl", "0.8"
                      "burnblow", "true"
                      "collideenemy", "false"
                      "collidefeature", "false"
                      "collidefriendly", "false"
                      "collideground", "false"
                      "collideneutral", "false"
                      "corethickness", "1.0"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "falloffrate", "0.0"
                      "impactonly", "1.0"
                      "laserflaresize", "8.8"
                      "paralyzer", "true"
                      "paralyzetime", "8.0"
                      "soundhitdry", ""
                      "soundhitwet", ""
                      "soundtrigger", "1.0"
                      "thickness", "6.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "35 12 54"
                  collisionVolumeType = Some "CylY"
                  damage = Some 20000.0
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
                "unitgroup", "builder"
                "area_mex_def", "armmex"
                "iscommander", "true"
                "effigy_offset", "1.0"
                "evocomlvl", "4.0"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "paralyzemultiplier", "0.025"
                "subfolder", ""
                "evolution_health_transfer", "percentage"
                "evolution_target", "armcomlvl5"
                "evolution_condition", "timer"
                "evolution_timer", "99999.0"
                "evolution_power_threshold", "105000.0"
                "evolution_power_multiplier", "1.0"
                "combatradius", "0.0"
                "workertimeboost", "3.5"
                "wtboostunittype", "TURRET"
                "inheritxpratemultiplier", "0.5"
                "childreninheritxp", "TURRET MOBILEBUILT"
                "parentsinheritxp", "TURRET MOBILEBUILT"
                "effigy", "comeffigylvl2"
                "minimum_respawn_stun", "5.0"
                "distance_stun_multiplier", "1.0"
                "fall_damage_multiplier", "5.0"
            ]
          extras = Map.ofList [
                "autoheal", "5.0"
                "cancapture", "true"
                "cancloak", "true"
                "canmanualfire", "true"
                "canselfrepair", "true"
                "capturable", "false"
                "capturespeed", "1800.0"
                "cloakcost", "100.0"
                "cloakcostmoving", "1000.0"
                "damagemodifier", "0.1"
                "hidedamage", "true"
                "holdsteady", "true"
                "icontype", "armcom"
                "sightemitheight", "40.0"
                "mass", "4900.0"
                "mincloakdistance", "50.0"
                "nochasecategory", "ALL"
                "radardistance", "1100.0"
                "radaremitheight", "40.0"
                "reclaimable", "false"
                "releaseheld", "true"
                "selfdestructcountdown", "5.0"
                "showplayername", "true"
                "sonardistance", "550.0"
                "upright", "true"
            ] }

    let armcomlvl4Def : UnitDef =
        { name = "armcomlvl4"
          subfolder = "other/evocom"
          metalCost = ValueOrExpr.Concrete 5000.0
          energyCost = ValueOrExpr.Concrete 50000.0
          buildTime = ValueOrExpr.Concrete 94800.0
          health = ValueOrExpr.Concrete 7800.0
          sightDistance = ValueOrExpr.Concrete 550.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMCOMHILVL.s3o"
          buildPic = Some "ARMCOM.DDS"
          script = Some "Units/ARMCOMHILVL.lua"
          corpse = Some "DEAD"
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderexplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 37.5
              maxAcc = 0.18
              maxDec = 1.125
              turnRate = 1148.0
              movementClass = Some "COMMANDERBOT"
              maxSlope = Some 20.0
              maxWaterDepth = Some 35.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 140.0
              turnInPlaceSpeedLimit = Some 0.825
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 545.0
              buildDistance = Some 169.0
              buildOptions = []
              terraformSpeed = Some 1500.0 })
          weapons = Some [
              { name = "backlauncher"
                displayName = "HeavyRockets"
                weaponType = Some "StarburstLauncher"
                damage = Map.ofList [
                    "default", 800.0
                ]
                range = Some (ValueOrExpr.Concrete 550.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.33)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 70.0
                accuracy = None
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.61
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "Rockhvy1"
                soundHit = Some "xplomed4"
                explosiongenerator = Some "custom:genericshellexplosion-large-bomb"
                rgbColor = None
                customParams = Map.ofList [
                    "projectile_destruction_method", "descend"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "cegtag", "missiletrailmedium-starburst"
                    "craterareaofeffect", "70.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "100.0"
                    "flighttime", "7.4"
                    "model", "corkbmissl1.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "8.0"
                    "smoketime", "30.0"
                    "smokesize", "12.0"
                    "smokecolor", "0.7"
                    "smokeTrailCastShadow", "true"
                    "soundhitwet", "splssml"
                    "stockpile", "true"
                    "stockpiletime", "10.0"
                    "texture1", "null"
                    "texture2", "smoketrailbar"
                    "texture3", "null"
                    "turnrate", "15000.0"
                    "weaponacceleration", "250.0"
                    "weapontimer", "1.1"
                ] }
              { name = "armcomsealaser"
                displayName = "J7NSLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 400.0
                    "subs", 200.0
                ]
                range = Some (ValueOrExpr.Concrete 450.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.36)
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
                rgbColor = Some "0.2 0.8 0.3"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTAIR"
                    "avoidfeature", "false"
                    "beamtime", "0.16"
                    "beamttl", "2.4"
                    "camerashake", "0.0"
                    "corethickness", "0.1"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "firestarter", "35.0"
                    "firesubmersed", "true"
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
                displayName = "Disintegrator"
                weaponType = Some "DGun"
                damage = Map.ofList [
                    "commanders", 0.0
                    "default", 99999.0
                    "scavboss", 1000.0
                    "raptorqueen", 1000.0
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
                    "soundhitwet", "sizzlexs"
                    "soundhitvolume", "36.0"
                    "soundstartvolume", "96.0"
                    "soundtrigger", "true"
                    "waterweapon", "true"
                    "weapontimer", "4.2"
                ] }
              { name = "longgun"
                displayName = "Arcing Stun Beam"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 22000.0
                ]
                range = Some (ValueOrExpr.Concrete 500.0)
                reloadTime = Some (ValueOrExpr.Concrete 8.0)
                weaponVelocity = Some 1500.0
                areaOfEffect = Some 60.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrcrw2"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-emp"
                rgbColor = Some "0.7 0.7 1"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "GROUNDSCOUT"
                    "mount_onlytargetcategory", "EMPABLE"
                    "beamtime", "0.1"
                    "collidefriendly", "false"
                    "corethickness", "0.23"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "largebeamlaser", "true"
                    "laserflaresize", "3.05"
                    "paralyzer", "true"
                    "paralyzetime", "7.0"
                    "scrollspeed", "5.0"
                    "soundhitdry", "hackshot"
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "soundstartvolume", "30.0"
                    "soundhitdryvolume", "40.0"
                    "soundhitwetvolume", "30.0"
                    "texture3", "largebeam"
                    "thickness", "1.5"
                    "tilelength", "150.0"
                ] }
              { name = "shortgun"
                displayName = "Scatter Beamer"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 25.0
                ]
                range = Some (ValueOrExpr.Concrete 350.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.1)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 10.0
                accuracy = Some 50.0
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "beamershot2"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-beamer"
                rgbColor = Some "0 0 1"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "mount_fastautoretargeting", "true"
                    "allowNonBlockingAim", "true"
                    "avoidfeature", "false"
                    "beamdecay", "0.05"
                    "beamtime", "0.1"
                    "beamttl", "1.0"
                    "corethickness", "0.233"
                    "burnblow", "true"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "explosionscar", "false"
                    "firestarter", "100.0"
                    "intensity", "0.7"
                    "laserflaresize", "9.35"
                    "projectiles", "16.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "sprayangle", "3500.0"
                ] }
              { name = "empflashbang"
                displayName = "EMP Damage-Mitigating Flashbang"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 20000.0
                ]
                range = Some (ValueOrExpr.Concrete 3.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.25)
                weaponVelocity = Some 1.0
                areaOfEffect = Some 50.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.001
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "xplosml5"
                soundHit = None
                explosiongenerator = Some "custom:genericshellexplosion-huge-lightning"
                rgbColor = Some "1 1 1"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "COMMANDER"
                    "avoidfeature", "false"
                    "beamdecay", ".8"
                    "beamttl", "0.8"
                    "burnblow", "true"
                    "collideenemy", "false"
                    "collidefeature", "false"
                    "collidefriendly", "false"
                    "collideground", "false"
                    "collideneutral", "false"
                    "corethickness", "1.0"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "falloffrate", "0.0"
                    "impactonly", "1.0"
                    "laserflaresize", "8.8"
                    "paralyzer", "true"
                    "paralyzetime", "8.0"
                    "soundhitdry", ""
                    "soundhitwet", ""
                    "soundtrigger", "1.0"
                    "thickness", "6.0"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 125.0)
              metalMake = Some (ValueOrExpr.Concrete 9.0)
              energyStorage = Some 2000.0
              metalStorage = Some 500.0
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "35 12 54"
                collisionVolumeType = Some "CylY"
                damage = Some 20000.0
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
          ])
          sounds = Some (
            { build = Some "nanlath1"
              repair = Some "repair1"
              working = Some "reclaim1"
              underAttack = Some "warning2"
              cancelDestruct = Some "cancel2"
              capture = Some "capture1"
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["armcom1"; "armcom2"; "armcom3"; "armcom4"]
              select = ["armcomsel"] })
          customParams = Map.ofList [
              "unitgroup", "builder"
              "area_mex_def", "armmex"
              "iscommander", "true"
              "effigy_offset", "1.0"
              "evocomlvl", "4.0"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "paralyzemultiplier", "0.025"
              "subfolder", ""
              "evolution_health_transfer", "percentage"
              "evolution_target", "armcomlvl5"
              "evolution_condition", "timer"
              "evolution_timer", "99999.0"
              "evolution_power_threshold", "105000.0"
              "evolution_power_multiplier", "1.0"
              "combatradius", "0.0"
              "workertimeboost", "3.5"
              "wtboostunittype", "TURRET"
              "inheritxpratemultiplier", "0.5"
              "childreninheritxp", "TURRET MOBILEBUILT"
              "parentsinheritxp", "TURRET MOBILEBUILT"
              "effigy", "comeffigylvl2"
              "minimum_respawn_stun", "5.0"
              "distance_stun_multiplier", "1.0"
              "fall_damage_multiplier", "5.0"
          ]
          extras = Map.ofList [
              "autoheal", "5.0"
              "cancapture", "true"
              "cancloak", "true"
              "canmanualfire", "true"
              "canselfrepair", "true"
              "capturable", "false"
              "capturespeed", "1800.0"
              "cloakcost", "100.0"
              "cloakcostmoving", "1000.0"
              "damagemodifier", "0.1"
              "hidedamage", "true"
              "holdsteady", "true"
              "icontype", "armcom"
              "sightemitheight", "40.0"
              "mass", "4900.0"
              "mincloakdistance", "50.0"
              "nochasecategory", "ALL"
              "radardistance", "1100.0"
              "radaremitheight", "40.0"
              "reclaimable", "false"
              "releaseheld", "true"
              "selfdestructcountdown", "5.0"
              "showplayername", "true"
              "sonardistance", "550.0"
              "upright", "true"
          ] }

    let armcomlvl4ToFlat (def: UnitDef) : Armcomlvl4 =
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
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          workerTime = def.builder.Value.workerTime
          buildDistance = def.builder.Value.buildDistance.Value
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyMake = def.economy.Value.energyMake.Value
          metalMake = def.economy.Value.metalMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armcomlvl4ToUnitDef (flat: Armcomlvl4) : UnitDef =
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
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = Some flat.movementClass
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = Some flat.buildDistance
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = Some flat.weapons
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = Some flat.metalMake
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armcomlvl5 =
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

    let armcomlvl5 : Armcomlvl5 =
        { name = "armcomlvl5"
          subfolder = "other/evocom"
          metalCost = ValueOrExpr.Concrete 6000.0
          energyCost = ValueOrExpr.Concrete 60000.0
          buildTime = ValueOrExpr.Concrete 111600.0
          health = ValueOrExpr.Concrete 8700.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMCOMHILVL.s3o"
          buildPic = Some "ARMCOM.DDS"
          script = Some "Units/ARMCOMHILVL.lua"
          corpse = Some "DEAD"
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderexplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
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
          workerTime = ValueOrExpr.Concrete 665.0
          buildDistance = 177.0
          buildOptions = []
          terraformSpeed = 1500.0
          energyMake = ValueOrExpr.Concrete 200.0
          metalMake = ValueOrExpr.Concrete 14.0
          energyStorage = 2500.0
          metalStorage = 500.0
          weapons = [
                { name = "backlauncher"
                  displayName = "HeavyRockets"
                  weaponType = Some "StarburstLauncher"
                  damage = Map.ofList [
                      "default", 1200.0
                  ]
                  range = Some (ValueOrExpr.Concrete 620.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.5)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 79.0
                  accuracy = None
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.61
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "Rockhvy1"
                  soundHit = Some "xplomed4"
                  explosiongenerator = Some "custom:genericshellexplosion-large-bomb"
                  rgbColor = None
                  customParams = Map.ofList [
                      "projectile_destruction_method", "descend"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "MOBILE"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "cegtag", "missiletrailmedium-starburst"
                      "craterareaofeffect", "70.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "100.0"
                      "flighttime", "7.4"
                      "model", "corkbmissl1.s3o"
                      "smoketrail", "true"
                      "smokePeriod", "8.0"
                      "smoketime", "30.0"
                      "smokesize", "12.0"
                      "smokecolor", "0.7"
                      "smokeTrailCastShadow", "true"
                      "soundhitwet", "splssml"
                      "stockpile", "true"
                      "stockpiletime", "10.0"
                      "texture1", "null"
                      "texture2", "smoketrailbar"
                      "texture3", "null"
                      "turnrate", "15000.0"
                      "weaponacceleration", "250.0"
                      "weapontimer", "1.24"
                  ] }
                { name = "armcomsealaser"
                  displayName = "UltravioletRayBeam"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 1200.0
                      "subs", 600.0
                  ]
                  range = Some (ValueOrExpr.Concrete 475.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.74)
                  weaponVelocity = Some 700.0
                  areaOfEffect = Some 42.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "uwlasrfir1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-medium-blue"
                  rgbColor = Some "0.6 0.2 0.6"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTAIR"
                      "avoidfeature", "false"
                      "beamtime", "0.16"
                      "camerashake", "0.0"
                      "corethickness", "0.2"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "90.0"
                      "firesubmersed", "true"
                      "intensity", "0.6"
                      "laserflaresize", "5.5"
                      "rgbcolor2", "0.2 0.2 0.2"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "3.5"
                      "waterweapon", "true"
                  ] }
                { name = "disintegrator"
                  displayName = "Disintegrator"
                  weaponType = Some "DGun"
                  damage = Map.ofList [
                      "commanders", 0.0
                      "default", 99999.0
                      "scavboss", 1000.0
                      "raptorqueen", 1000.0
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
                      "soundhitwet", "sizzlexs"
                      "soundhitvolume", "36.0"
                      "soundstartvolume", "96.0"
                      "soundtrigger", "true"
                      "waterweapon", "true"
                      "weapontimer", "4.2"
                  ] }
                { name = "longgun"
                  displayName = "Arcing Stun Beam"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 30000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 550.0)
                  reloadTime = Some (ValueOrExpr.Concrete 8.0)
                  weaponVelocity = Some 1500.0
                  areaOfEffect = Some 60.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrcrw2"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-emp"
                  rgbColor = Some "0.7 0.7 1"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "GROUNDSCOUT"
                      "mount_onlytargetcategory", "EMPABLE"
                      "beamtime", "0.1"
                      "collidefriendly", "false"
                      "corethickness", "0.23"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "largebeamlaser", "true"
                      "laserflaresize", "4.05"
                      "paralyzer", "true"
                      "paralyzetime", "7.0"
                      "scrollspeed", "5.0"
                      "soundhitdry", "hackshot"
                      "soundhitwet", "sizzle"
                      "soundstartvolume", "30.0"
                      "soundhitdryvolume", "40.0"
                      "soundhitwetvolume", "30.0"
                      "soundtrigger", "1.0"
                      "texture3", "largebeam"
                      "thickness", "2.25"
                      "tilelength", "150.0"
                  ] }
                { name = "shortgun"
                  displayName = "Short-Range Lightening Discharge"
                  weaponType = Some "LightningCannon"
                  damage = Map.ofList [
                      "default", 42.0
                  ]
                  range = Some (ValueOrExpr.Concrete 425.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.1)
                  weaponVelocity = Some 400.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lghthvy2"
                  soundHit = Some ""
                  explosiongenerator = Some "custom:genericshellexplosion-medium-lightning2"
                  rgbColor = Some "0.5 0.5 1"
                  customParams = Map.ofList [
                      "spark_ceg", "genericshellexplosion-splash-lightning"
                      "spark_forkdamage", "0.33"
                      "spark_maxunits", "6"
                      "spark_range", "75"
                  ]
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "mount_fastautoretargeting", "true"
                      "avoidfeature", "false"
                      "beamttl", "1.0"
                      "burst", "3.0"
                      "burstrate", "0.03333"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "1.0"
                      "energypershot", "5.0"
                      "firestarter", "50.0"
                      "intensity", "24.0"
                      "soundhitwet", ""
                      "soundtrigger", "true"
                      "thickness", "1.5"
                  ] }
                { name = "empflashbang"
                  displayName = "EMP Damage-Mitigating Flashbang"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "default", 20000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 3.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.25)
                  weaponVelocity = Some 1.0
                  areaOfEffect = Some 50.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.001
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "xplosml5"
                  soundHit = None
                  explosiongenerator = Some "custom:genericshellexplosion-huge-lightning"
                  rgbColor = Some "1 1 1"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "COMMANDER"
                      "avoidfeature", "false"
                      "beamdecay", ".8"
                      "beamttl", "0.8"
                      "burnblow", "true"
                      "collideenemy", "false"
                      "collidefeature", "false"
                      "collidefriendly", "false"
                      "collideground", "false"
                      "collideneutral", "false"
                      "corethickness", "1.0"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "falloffrate", "0.0"
                      "impactonly", "1.0"
                      "laserflaresize", "8.8"
                      "paralyzer", "true"
                      "paralyzetime", "8.0"
                      "soundhitdry", ""
                      "soundhitwet", ""
                      "soundtrigger", "1.0"
                      "thickness", "6.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "35 12 54"
                  collisionVolumeType = Some "CylY"
                  damage = Some 24000.0
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
                "unitgroup", "builder"
                "area_mex_def", "armmex"
                "iscommander", "true"
                "effigy_offset", "1.0"
                "evocomlvl", "5.0"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "paralyzemultiplier", "0.025"
                "subfolder", ""
                "evolution_health_transfer", "percentage"
                "evolution_target", "armcomlvl6"
                "evolution_condition", "timer"
                "evolution_timer", "99999.0"
                "evolution_power_threshold", "260000.0"
                "evolution_power_multiplier", "1.0"
                "combatradius", "0.0"
                "inheritxpratemultiplier", "0.5"
                "childreninheritxp", "TURRET MOBILEBUILT"
                "parentsinheritxp", "TURRET MOBILEBUILT"
                "workertimeboost", "3.5"
                "wtboostunittype", "TURRET MOBILE"
                "effigy", "comeffigylvl3"
                "minimum_respawn_stun", "5.0"
                "distance_stun_multiplier", "1.0"
                "fall_damage_multiplier", "5.0"
            ]
          extras = Map.ofList [
                "autoheal", "5.0"
                "cancapture", "true"
                "cancloak", "true"
                "canselfrepair", "true"
                "canmanualfire", "true"
                "capturable", "false"
                "capturespeed", "1800.0"
                "cloakcost", "100.0"
                "cloakcostmoving", "1000.0"
                "damagemodifier", "0.1"
                "hidedamage", "true"
                "holdsteady", "true"
                "icontype", "armcom"
                "sightemitheight", "40.0"
                "mass", "4900.0"
                "mincloakdistance", "50.0"
                "nochasecategory", "ALL"
                "radardistance", "1200.0"
                "radaremitheight", "40.0"
                "reclaimable", "false"
                "releaseheld", "true"
                "selfdestructcountdown", "5.0"
                "showplayername", "true"
                "sonardistance", "600.0"
                "upright", "true"
            ] }

    let armcomlvl5Def : UnitDef =
        { name = "armcomlvl5"
          subfolder = "other/evocom"
          metalCost = ValueOrExpr.Concrete 6000.0
          energyCost = ValueOrExpr.Concrete 60000.0
          buildTime = ValueOrExpr.Concrete 111600.0
          health = ValueOrExpr.Concrete 8700.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMCOMHILVL.s3o"
          buildPic = Some "ARMCOM.DDS"
          script = Some "Units/ARMCOMHILVL.lua"
          corpse = Some "DEAD"
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderexplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 37.5
              maxAcc = 0.18
              maxDec = 1.125
              turnRate = 1148.0
              movementClass = Some "COMMANDERBOT"
              maxSlope = Some 20.0
              maxWaterDepth = Some 35.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 140.0
              turnInPlaceSpeedLimit = Some 0.825
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 665.0
              buildDistance = Some 177.0
              buildOptions = []
              terraformSpeed = Some 1500.0 })
          weapons = Some [
              { name = "backlauncher"
                displayName = "HeavyRockets"
                weaponType = Some "StarburstLauncher"
                damage = Map.ofList [
                    "default", 1200.0
                ]
                range = Some (ValueOrExpr.Concrete 620.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.5)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 79.0
                accuracy = None
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.61
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "Rockhvy1"
                soundHit = Some "xplomed4"
                explosiongenerator = Some "custom:genericshellexplosion-large-bomb"
                rgbColor = None
                customParams = Map.ofList [
                    "projectile_destruction_method", "descend"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "cegtag", "missiletrailmedium-starburst"
                    "craterareaofeffect", "70.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "100.0"
                    "flighttime", "7.4"
                    "model", "corkbmissl1.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "8.0"
                    "smoketime", "30.0"
                    "smokesize", "12.0"
                    "smokecolor", "0.7"
                    "smokeTrailCastShadow", "true"
                    "soundhitwet", "splssml"
                    "stockpile", "true"
                    "stockpiletime", "10.0"
                    "texture1", "null"
                    "texture2", "smoketrailbar"
                    "texture3", "null"
                    "turnrate", "15000.0"
                    "weaponacceleration", "250.0"
                    "weapontimer", "1.24"
                ] }
              { name = "armcomsealaser"
                displayName = "UltravioletRayBeam"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 1200.0
                    "subs", 600.0
                ]
                range = Some (ValueOrExpr.Concrete 475.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.74)
                weaponVelocity = Some 700.0
                areaOfEffect = Some 42.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "uwlasrfir1"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-medium-blue"
                rgbColor = Some "0.6 0.2 0.6"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTAIR"
                    "avoidfeature", "false"
                    "beamtime", "0.16"
                    "camerashake", "0.0"
                    "corethickness", "0.2"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "firestarter", "90.0"
                    "firesubmersed", "true"
                    "intensity", "0.6"
                    "laserflaresize", "5.5"
                    "rgbcolor2", "0.2 0.2 0.2"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "3.5"
                    "waterweapon", "true"
                ] }
              { name = "disintegrator"
                displayName = "Disintegrator"
                weaponType = Some "DGun"
                damage = Map.ofList [
                    "commanders", 0.0
                    "default", 99999.0
                    "scavboss", 1000.0
                    "raptorqueen", 1000.0
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
                    "soundhitwet", "sizzlexs"
                    "soundhitvolume", "36.0"
                    "soundstartvolume", "96.0"
                    "soundtrigger", "true"
                    "waterweapon", "true"
                    "weapontimer", "4.2"
                ] }
              { name = "longgun"
                displayName = "Arcing Stun Beam"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 30000.0
                ]
                range = Some (ValueOrExpr.Concrete 550.0)
                reloadTime = Some (ValueOrExpr.Concrete 8.0)
                weaponVelocity = Some 1500.0
                areaOfEffect = Some 60.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrcrw2"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-emp"
                rgbColor = Some "0.7 0.7 1"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "GROUNDSCOUT"
                    "mount_onlytargetcategory", "EMPABLE"
                    "beamtime", "0.1"
                    "collidefriendly", "false"
                    "corethickness", "0.23"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "largebeamlaser", "true"
                    "laserflaresize", "4.05"
                    "paralyzer", "true"
                    "paralyzetime", "7.0"
                    "scrollspeed", "5.0"
                    "soundhitdry", "hackshot"
                    "soundhitwet", "sizzle"
                    "soundstartvolume", "30.0"
                    "soundhitdryvolume", "40.0"
                    "soundhitwetvolume", "30.0"
                    "soundtrigger", "1.0"
                    "texture3", "largebeam"
                    "thickness", "2.25"
                    "tilelength", "150.0"
                ] }
              { name = "shortgun"
                displayName = "Short-Range Lightening Discharge"
                weaponType = Some "LightningCannon"
                damage = Map.ofList [
                    "default", 42.0
                ]
                range = Some (ValueOrExpr.Concrete 425.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.1)
                weaponVelocity = Some 400.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lghthvy2"
                soundHit = Some ""
                explosiongenerator = Some "custom:genericshellexplosion-medium-lightning2"
                rgbColor = Some "0.5 0.5 1"
                customParams = Map.ofList [
                    "spark_ceg", "genericshellexplosion-splash-lightning"
                    "spark_forkdamage", "0.33"
                    "spark_maxunits", "6"
                    "spark_range", "75"
                ]
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "mount_fastautoretargeting", "true"
                    "avoidfeature", "false"
                    "beamttl", "1.0"
                    "burst", "3.0"
                    "burstrate", "0.03333"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "1.0"
                    "energypershot", "5.0"
                    "firestarter", "50.0"
                    "intensity", "24.0"
                    "soundhitwet", ""
                    "soundtrigger", "true"
                    "thickness", "1.5"
                ] }
              { name = "empflashbang"
                displayName = "EMP Damage-Mitigating Flashbang"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 20000.0
                ]
                range = Some (ValueOrExpr.Concrete 3.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.25)
                weaponVelocity = Some 1.0
                areaOfEffect = Some 50.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.001
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "xplosml5"
                soundHit = None
                explosiongenerator = Some "custom:genericshellexplosion-huge-lightning"
                rgbColor = Some "1 1 1"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "COMMANDER"
                    "avoidfeature", "false"
                    "beamdecay", ".8"
                    "beamttl", "0.8"
                    "burnblow", "true"
                    "collideenemy", "false"
                    "collidefeature", "false"
                    "collidefriendly", "false"
                    "collideground", "false"
                    "collideneutral", "false"
                    "corethickness", "1.0"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "falloffrate", "0.0"
                    "impactonly", "1.0"
                    "laserflaresize", "8.8"
                    "paralyzer", "true"
                    "paralyzetime", "8.0"
                    "soundhitdry", ""
                    "soundhitwet", ""
                    "soundtrigger", "1.0"
                    "thickness", "6.0"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 200.0)
              metalMake = Some (ValueOrExpr.Concrete 14.0)
              energyStorage = Some 2500.0
              metalStorage = Some 500.0
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "35 12 54"
                collisionVolumeType = Some "CylY"
                damage = Some 24000.0
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
          ])
          sounds = Some (
            { build = Some "nanlath1"
              repair = Some "repair1"
              working = Some "reclaim1"
              underAttack = Some "warning2"
              cancelDestruct = Some "cancel2"
              capture = Some "capture1"
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["armcom1"; "armcom2"; "armcom3"; "armcom4"]
              select = ["armcomsel"] })
          customParams = Map.ofList [
              "unitgroup", "builder"
              "area_mex_def", "armmex"
              "iscommander", "true"
              "effigy_offset", "1.0"
              "evocomlvl", "5.0"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "paralyzemultiplier", "0.025"
              "subfolder", ""
              "evolution_health_transfer", "percentage"
              "evolution_target", "armcomlvl6"
              "evolution_condition", "timer"
              "evolution_timer", "99999.0"
              "evolution_power_threshold", "260000.0"
              "evolution_power_multiplier", "1.0"
              "combatradius", "0.0"
              "inheritxpratemultiplier", "0.5"
              "childreninheritxp", "TURRET MOBILEBUILT"
              "parentsinheritxp", "TURRET MOBILEBUILT"
              "workertimeboost", "3.5"
              "wtboostunittype", "TURRET MOBILE"
              "effigy", "comeffigylvl3"
              "minimum_respawn_stun", "5.0"
              "distance_stun_multiplier", "1.0"
              "fall_damage_multiplier", "5.0"
          ]
          extras = Map.ofList [
              "autoheal", "5.0"
              "cancapture", "true"
              "cancloak", "true"
              "canselfrepair", "true"
              "canmanualfire", "true"
              "capturable", "false"
              "capturespeed", "1800.0"
              "cloakcost", "100.0"
              "cloakcostmoving", "1000.0"
              "damagemodifier", "0.1"
              "hidedamage", "true"
              "holdsteady", "true"
              "icontype", "armcom"
              "sightemitheight", "40.0"
              "mass", "4900.0"
              "mincloakdistance", "50.0"
              "nochasecategory", "ALL"
              "radardistance", "1200.0"
              "radaremitheight", "40.0"
              "reclaimable", "false"
              "releaseheld", "true"
              "selfdestructcountdown", "5.0"
              "showplayername", "true"
              "sonardistance", "600.0"
              "upright", "true"
          ] }

    let armcomlvl5ToFlat (def: UnitDef) : Armcomlvl5 =
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
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          workerTime = def.builder.Value.workerTime
          buildDistance = def.builder.Value.buildDistance.Value
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyMake = def.economy.Value.energyMake.Value
          metalMake = def.economy.Value.metalMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armcomlvl5ToUnitDef (flat: Armcomlvl5) : UnitDef =
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
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = Some flat.movementClass
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = Some flat.buildDistance
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = Some flat.weapons
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = Some flat.metalMake
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armcomlvl6 =
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

    let armcomlvl6 : Armcomlvl6 =
        { name = "armcomlvl6"
          subfolder = "other/evocom"
          metalCost = ValueOrExpr.Concrete 7000.0
          energyCost = ValueOrExpr.Concrete 70000.0
          buildTime = ValueOrExpr.Concrete 128400.0
          health = ValueOrExpr.Concrete 9600.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMCOMHILVL.s3o"
          buildPic = Some "ARMCOM.DDS"
          script = Some "Units/ARMCOMHILVL.lua"
          corpse = Some "DEAD"
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderexplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
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
          workerTime = ValueOrExpr.Concrete 811.0
          buildDistance = 185.0
          buildOptions = []
          terraformSpeed = 1500.0
          energyMake = ValueOrExpr.Concrete 325.0
          metalMake = ValueOrExpr.Concrete 20.0
          energyStorage = 3000.0
          metalStorage = 500.0
          weapons = [
                { name = "backlauncher"
                  displayName = "HeavyRockets"
                  weaponType = Some "StarburstLauncher"
                  damage = Map.ofList [
                      "default", 1350.0
                  ]
                  range = Some (ValueOrExpr.Concrete 730.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.5)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 93.0
                  accuracy = None
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.61
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "Rockhvy1"
                  soundHit = Some "xplomed4"
                  explosiongenerator = Some "custom:genericshellexplosion-large-bomb"
                  rgbColor = None
                  customParams = Map.ofList [
                      "projectile_destruction_method", "descend"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "MOBILE"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "cegtag", "missiletrailmedium-starburst"
                      "craterareaofeffect", "70.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "100.0"
                      "flighttime", "7.4"
                      "model", "corkbmissl1.s3o"
                      "smoketrail", "true"
                      "smokePeriod", "8.0"
                      "smoketime", "30.0"
                      "smokesize", "12.0"
                      "smokecolor", "0.7"
                      "smokeTrailCastShadow", "true"
                      "soundhitwet", "splssml"
                      "stockpile", "true"
                      "stockpiletime", "10.0"
                      "texture1", "null"
                      "texture2", "smoketrailbar"
                      "texture3", "null"
                      "turnrate", "15000.0"
                      "weaponacceleration", "250.0"
                      "weapontimer", "1.46"
                  ] }
                { name = "armcomsealaser"
                  displayName = "UltravioletRayBeam"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 1200.0
                      "subs", 600.0
                  ]
                  range = Some (ValueOrExpr.Concrete 475.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.54)
                  weaponVelocity = Some 700.0
                  areaOfEffect = Some 42.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "uwlasrfir1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-medium-blue"
                  rgbColor = Some "0.6 0.2 0.6"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTAIR"
                      "avoidfeature", "false"
                      "beamtime", "0.16"
                      "camerashake", "0.0"
                      "corethickness", "0.2"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "90.0"
                      "firesubmersed", "true"
                      "intensity", "0.6"
                      "laserflaresize", "5.5"
                      "rgbcolor2", "0.2 0.2 0.2"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "3.5"
                      "waterweapon", "true"
                  ] }
                { name = "disintegrator"
                  displayName = "Disintegrator"
                  weaponType = Some "DGun"
                  damage = Map.ofList [
                      "commanders", 0.0
                      "default", 99999.0
                      "scavboss", 1000.0
                      "raptorqueen", 1000.0
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
                      "soundhitwet", "sizzlexs"
                      "soundhitvolume", "36.0"
                      "soundstartvolume", "96.0"
                      "soundtrigger", "true"
                      "waterweapon", "true"
                      "weapontimer", "4.2"
                  ] }
                { name = "longgun"
                  displayName = "Arcing Stun Beam"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 40000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 550.0)
                  reloadTime = Some (ValueOrExpr.Concrete 8.0)
                  weaponVelocity = Some 1500.0
                  areaOfEffect = Some 60.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrcrw2"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-emp"
                  rgbColor = Some "0.7 0.7 1"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "GROUNDSCOUT"
                      "mount_onlytargetcategory", "EMPABLE"
                      "beamtime", "0.1"
                      "collidefriendly", "false"
                      "corethickness", "0.23"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "largebeamlaser", "true"
                      "laserflaresize", "4.05"
                      "paralyzer", "true"
                      "paralyzetime", "7.0"
                      "scrollspeed", "5.0"
                      "soundhitdry", "hackshot"
                      "soundhitwet", "sizzle"
                      "soundstartvolume", "30.0"
                      "soundhitdryvolume", "40.0"
                      "soundhitwetvolume", "30.0"
                      "soundtrigger", "1.0"
                      "texture3", "largebeam"
                      "thickness", "2.25"
                      "tilelength", "150.0"
                  ] }
                { name = "shortgun"
                  displayName = "Short-Range Lightening Discharge"
                  weaponType = Some "LightningCannon"
                  damage = Map.ofList [
                      "default", 50.0
                  ]
                  range = Some (ValueOrExpr.Concrete 425.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.1)
                  weaponVelocity = Some 400.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lghthvy2"
                  soundHit = Some ""
                  explosiongenerator = Some "custom:genericshellexplosion-medium-lightning2"
                  rgbColor = Some "0.5 0.5 1"
                  customParams = Map.ofList [
                      "spark_ceg", "genericshellexplosion-splash-lightning"
                      "spark_forkdamage", "0.33"
                      "spark_maxunits", "6"
                      "spark_range", "75"
                  ]
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "mount_fastautoretargeting", "true"
                      "avoidfeature", "false"
                      "beamttl", "1.0"
                      "burst", "3.0"
                      "burstrate", "0.03333"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "1.0"
                      "energypershot", "5.0"
                      "firestarter", "50.0"
                      "intensity", "24.0"
                      "soundhitwet", ""
                      "soundtrigger", "true"
                      "thickness", "1.5"
                  ] }
                { name = "empflashbang"
                  displayName = "EMP Damage-Mitigating Flashbang"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "default", 20000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 3.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.25)
                  weaponVelocity = Some 1.0
                  areaOfEffect = Some 50.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.001
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "xplosml5"
                  soundHit = None
                  explosiongenerator = Some "custom:genericshellexplosion-huge-lightning"
                  rgbColor = Some "1 1 1"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "COMMANDER"
                      "avoidfeature", "false"
                      "beamdecay", ".8"
                      "beamttl", "0.8"
                      "burnblow", "true"
                      "collideenemy", "false"
                      "collidefeature", "false"
                      "collidefriendly", "false"
                      "collideground", "false"
                      "collideneutral", "false"
                      "corethickness", "1.0"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "falloffrate", "0.0"
                      "impactonly", "1.0"
                      "laserflaresize", "8.8"
                      "paralyzer", "true"
                      "paralyzetime", "8.0"
                      "soundhitdry", ""
                      "soundhitwet", ""
                      "soundtrigger", "1.0"
                      "thickness", "6.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "35 12 54"
                  collisionVolumeType = Some "CylY"
                  damage = Some 28000.0
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
                "unitgroup", "builder"
                "area_mex_def", "armmex"
                "iscommander", "true"
                "effigy_offset", "1.0"
                "evocomlvl", "6.0"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "paralyzemultiplier", "0.025"
                "subfolder", ""
                "evolution_health_transfer", "percentage"
                "evolution_target", "armcomlvl7"
                "evolution_condition", "timer"
                "evolution_timer", "99999.0"
                "evolution_power_threshold", "390000.0"
                "evolution_power_multiplier", "1.0"
                "combatradius", "0.0"
                "inheritxpratemultiplier", "0.5"
                "childreninheritxp", "TURRET MOBILEBUILT"
                "parentsinheritxp", "TURRET MOBILEBUILT"
                "workertimeboost", "3.5"
                "wtboostunittype", "TURRET MOBILE"
                "effigy", "comeffigylvl3"
                "minimum_respawn_stun", "5.0"
                "distance_stun_multiplier", "1.0"
                "fall_damage_multiplier", "5.0"
            ]
          extras = Map.ofList [
                "autoheal", "5.0"
                "cancapture", "true"
                "cancloak", "true"
                "canmanualfire", "true"
                "canselfrepair", "true"
                "capturable", "false"
                "capturespeed", "1800.0"
                "cloakcost", "100.0"
                "cloakcostmoving", "1000.0"
                "damagemodifier", "0.1"
                "hidedamage", "true"
                "holdsteady", "true"
                "icontype", "armcom"
                "sightemitheight", "40.0"
                "mass", "4900.0"
                "mincloakdistance", "50.0"
                "nochasecategory", "ALL"
                "radardistance", "1200.0"
                "radaremitheight", "40.0"
                "reclaimable", "false"
                "releaseheld", "true"
                "selfdestructcountdown", "5.0"
                "showplayername", "true"
                "sonardistance", "600.0"
                "upright", "true"
            ] }

    let armcomlvl6Def : UnitDef =
        { name = "armcomlvl6"
          subfolder = "other/evocom"
          metalCost = ValueOrExpr.Concrete 7000.0
          energyCost = ValueOrExpr.Concrete 70000.0
          buildTime = ValueOrExpr.Concrete 128400.0
          health = ValueOrExpr.Concrete 9600.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMCOMHILVL.s3o"
          buildPic = Some "ARMCOM.DDS"
          script = Some "Units/ARMCOMHILVL.lua"
          corpse = Some "DEAD"
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderexplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 37.5
              maxAcc = 0.18
              maxDec = 1.125
              turnRate = 1148.0
              movementClass = Some "COMMANDERBOT"
              maxSlope = Some 20.0
              maxWaterDepth = Some 35.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 140.0
              turnInPlaceSpeedLimit = Some 0.825
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 811.0
              buildDistance = Some 185.0
              buildOptions = []
              terraformSpeed = Some 1500.0 })
          weapons = Some [
              { name = "backlauncher"
                displayName = "HeavyRockets"
                weaponType = Some "StarburstLauncher"
                damage = Map.ofList [
                    "default", 1350.0
                ]
                range = Some (ValueOrExpr.Concrete 730.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.5)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 93.0
                accuracy = None
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.61
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "Rockhvy1"
                soundHit = Some "xplomed4"
                explosiongenerator = Some "custom:genericshellexplosion-large-bomb"
                rgbColor = None
                customParams = Map.ofList [
                    "projectile_destruction_method", "descend"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "cegtag", "missiletrailmedium-starburst"
                    "craterareaofeffect", "70.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "100.0"
                    "flighttime", "7.4"
                    "model", "corkbmissl1.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "8.0"
                    "smoketime", "30.0"
                    "smokesize", "12.0"
                    "smokecolor", "0.7"
                    "smokeTrailCastShadow", "true"
                    "soundhitwet", "splssml"
                    "stockpile", "true"
                    "stockpiletime", "10.0"
                    "texture1", "null"
                    "texture2", "smoketrailbar"
                    "texture3", "null"
                    "turnrate", "15000.0"
                    "weaponacceleration", "250.0"
                    "weapontimer", "1.46"
                ] }
              { name = "armcomsealaser"
                displayName = "UltravioletRayBeam"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 1200.0
                    "subs", 600.0
                ]
                range = Some (ValueOrExpr.Concrete 475.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.54)
                weaponVelocity = Some 700.0
                areaOfEffect = Some 42.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "uwlasrfir1"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-medium-blue"
                rgbColor = Some "0.6 0.2 0.6"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTAIR"
                    "avoidfeature", "false"
                    "beamtime", "0.16"
                    "camerashake", "0.0"
                    "corethickness", "0.2"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "firestarter", "90.0"
                    "firesubmersed", "true"
                    "intensity", "0.6"
                    "laserflaresize", "5.5"
                    "rgbcolor2", "0.2 0.2 0.2"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "3.5"
                    "waterweapon", "true"
                ] }
              { name = "disintegrator"
                displayName = "Disintegrator"
                weaponType = Some "DGun"
                damage = Map.ofList [
                    "commanders", 0.0
                    "default", 99999.0
                    "scavboss", 1000.0
                    "raptorqueen", 1000.0
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
                    "soundhitwet", "sizzlexs"
                    "soundhitvolume", "36.0"
                    "soundstartvolume", "96.0"
                    "soundtrigger", "true"
                    "waterweapon", "true"
                    "weapontimer", "4.2"
                ] }
              { name = "longgun"
                displayName = "Arcing Stun Beam"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 40000.0
                ]
                range = Some (ValueOrExpr.Concrete 550.0)
                reloadTime = Some (ValueOrExpr.Concrete 8.0)
                weaponVelocity = Some 1500.0
                areaOfEffect = Some 60.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrcrw2"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-emp"
                rgbColor = Some "0.7 0.7 1"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "GROUNDSCOUT"
                    "mount_onlytargetcategory", "EMPABLE"
                    "beamtime", "0.1"
                    "collidefriendly", "false"
                    "corethickness", "0.23"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "largebeamlaser", "true"
                    "laserflaresize", "4.05"
                    "paralyzer", "true"
                    "paralyzetime", "7.0"
                    "scrollspeed", "5.0"
                    "soundhitdry", "hackshot"
                    "soundhitwet", "sizzle"
                    "soundstartvolume", "30.0"
                    "soundhitdryvolume", "40.0"
                    "soundhitwetvolume", "30.0"
                    "soundtrigger", "1.0"
                    "texture3", "largebeam"
                    "thickness", "2.25"
                    "tilelength", "150.0"
                ] }
              { name = "shortgun"
                displayName = "Short-Range Lightening Discharge"
                weaponType = Some "LightningCannon"
                damage = Map.ofList [
                    "default", 50.0
                ]
                range = Some (ValueOrExpr.Concrete 425.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.1)
                weaponVelocity = Some 400.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lghthvy2"
                soundHit = Some ""
                explosiongenerator = Some "custom:genericshellexplosion-medium-lightning2"
                rgbColor = Some "0.5 0.5 1"
                customParams = Map.ofList [
                    "spark_ceg", "genericshellexplosion-splash-lightning"
                    "spark_forkdamage", "0.33"
                    "spark_maxunits", "6"
                    "spark_range", "75"
                ]
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "mount_fastautoretargeting", "true"
                    "avoidfeature", "false"
                    "beamttl", "1.0"
                    "burst", "3.0"
                    "burstrate", "0.03333"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "1.0"
                    "energypershot", "5.0"
                    "firestarter", "50.0"
                    "intensity", "24.0"
                    "soundhitwet", ""
                    "soundtrigger", "true"
                    "thickness", "1.5"
                ] }
              { name = "empflashbang"
                displayName = "EMP Damage-Mitigating Flashbang"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 20000.0
                ]
                range = Some (ValueOrExpr.Concrete 3.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.25)
                weaponVelocity = Some 1.0
                areaOfEffect = Some 50.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.001
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "xplosml5"
                soundHit = None
                explosiongenerator = Some "custom:genericshellexplosion-huge-lightning"
                rgbColor = Some "1 1 1"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "COMMANDER"
                    "avoidfeature", "false"
                    "beamdecay", ".8"
                    "beamttl", "0.8"
                    "burnblow", "true"
                    "collideenemy", "false"
                    "collidefeature", "false"
                    "collidefriendly", "false"
                    "collideground", "false"
                    "collideneutral", "false"
                    "corethickness", "1.0"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "falloffrate", "0.0"
                    "impactonly", "1.0"
                    "laserflaresize", "8.8"
                    "paralyzer", "true"
                    "paralyzetime", "8.0"
                    "soundhitdry", ""
                    "soundhitwet", ""
                    "soundtrigger", "1.0"
                    "thickness", "6.0"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 325.0)
              metalMake = Some (ValueOrExpr.Concrete 20.0)
              energyStorage = Some 3000.0
              metalStorage = Some 500.0
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "35 12 54"
                collisionVolumeType = Some "CylY"
                damage = Some 28000.0
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
          ])
          sounds = Some (
            { build = Some "nanlath1"
              repair = Some "repair1"
              working = Some "reclaim1"
              underAttack = Some "warning2"
              cancelDestruct = Some "cancel2"
              capture = Some "capture1"
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["armcom1"; "armcom2"; "armcom3"; "armcom4"]
              select = ["armcomsel"] })
          customParams = Map.ofList [
              "unitgroup", "builder"
              "area_mex_def", "armmex"
              "iscommander", "true"
              "effigy_offset", "1.0"
              "evocomlvl", "6.0"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "paralyzemultiplier", "0.025"
              "subfolder", ""
              "evolution_health_transfer", "percentage"
              "evolution_target", "armcomlvl7"
              "evolution_condition", "timer"
              "evolution_timer", "99999.0"
              "evolution_power_threshold", "390000.0"
              "evolution_power_multiplier", "1.0"
              "combatradius", "0.0"
              "inheritxpratemultiplier", "0.5"
              "childreninheritxp", "TURRET MOBILEBUILT"
              "parentsinheritxp", "TURRET MOBILEBUILT"
              "workertimeboost", "3.5"
              "wtboostunittype", "TURRET MOBILE"
              "effigy", "comeffigylvl3"
              "minimum_respawn_stun", "5.0"
              "distance_stun_multiplier", "1.0"
              "fall_damage_multiplier", "5.0"
          ]
          extras = Map.ofList [
              "autoheal", "5.0"
              "cancapture", "true"
              "cancloak", "true"
              "canmanualfire", "true"
              "canselfrepair", "true"
              "capturable", "false"
              "capturespeed", "1800.0"
              "cloakcost", "100.0"
              "cloakcostmoving", "1000.0"
              "damagemodifier", "0.1"
              "hidedamage", "true"
              "holdsteady", "true"
              "icontype", "armcom"
              "sightemitheight", "40.0"
              "mass", "4900.0"
              "mincloakdistance", "50.0"
              "nochasecategory", "ALL"
              "radardistance", "1200.0"
              "radaremitheight", "40.0"
              "reclaimable", "false"
              "releaseheld", "true"
              "selfdestructcountdown", "5.0"
              "showplayername", "true"
              "sonardistance", "600.0"
              "upright", "true"
          ] }

    let armcomlvl6ToFlat (def: UnitDef) : Armcomlvl6 =
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
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          workerTime = def.builder.Value.workerTime
          buildDistance = def.builder.Value.buildDistance.Value
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyMake = def.economy.Value.energyMake.Value
          metalMake = def.economy.Value.metalMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armcomlvl6ToUnitDef (flat: Armcomlvl6) : UnitDef =
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
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = Some flat.movementClass
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = Some flat.buildDistance
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = Some flat.weapons
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = Some flat.metalMake
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armcomlvl7 =
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

    let armcomlvl7 : Armcomlvl7 =
        { name = "armcomlvl7"
          subfolder = "other/evocom"
          metalCost = ValueOrExpr.Concrete 8000.0
          energyCost = ValueOrExpr.Concrete 80000.0
          buildTime = ValueOrExpr.Concrete 145200.0
          health = ValueOrExpr.Concrete 10500.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMCOMHILVL.s3o"
          buildPic = Some "ARMCOM.DDS"
          script = Some "Units/ARMCOMHILVL.lua"
          corpse = Some "DEAD"
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderexplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
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
          workerTime = ValueOrExpr.Concrete 989.0
          buildDistance = 193.0
          buildOptions = []
          terraformSpeed = 1500.0
          energyMake = ValueOrExpr.Concrete 525.0
          metalMake = ValueOrExpr.Concrete 27.0
          energyStorage = 3500.0
          metalStorage = 500.0
          weapons = [
                { name = "backlauncher"
                  displayName = "HeavyRockets"
                  weaponType = Some "StarburstLauncher"
                  damage = Map.ofList [
                      "default", 1800.0
                  ]
                  range = Some (ValueOrExpr.Concrete 730.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.5)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 93.0
                  accuracy = None
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.61
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "Rockhvy1"
                  soundHit = Some "xplomed4"
                  explosiongenerator = Some "custom:genericshellexplosion-large-bomb"
                  rgbColor = None
                  customParams = Map.ofList [
                      "projectile_destruction_method", "descend"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "MOBILE"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "cegtag", "missiletrailmedium-starburst"
                      "craterareaofeffect", "70.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "100.0"
                      "flighttime", "7.4"
                      "model", "corkbmissl1.s3o"
                      "smoketrail", "true"
                      "smokePeriod", "8.0"
                      "smoketime", "30.0"
                      "smokesize", "12.0"
                      "smokecolor", "0.7"
                      "smokeTrailCastShadow", "true"
                      "soundhitwet", "splssml"
                      "stockpile", "true"
                      "stockpiletime", "10.0"
                      "texture1", "null"
                      "texture2", "smoketrailbar"
                      "texture3", "null"
                      "turnrate", "15000.0"
                      "weaponacceleration", "250.0"
                      "weapontimer", "1.46"
                  ] }
                { name = "armcomsealaser"
                  displayName = "UltravioletRayBeam"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 1200.0
                      "subs", 600.0
                  ]
                  range = Some (ValueOrExpr.Concrete 500.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.43)
                  weaponVelocity = Some 700.0
                  areaOfEffect = Some 42.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "uwlasrfir1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-medium-blue"
                  rgbColor = Some "0.6 0.2 0.6"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTAIR"
                      "avoidfeature", "false"
                      "beamtime", "0.16"
                      "camerashake", "0.0"
                      "corethickness", "0.2"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "90.0"
                      "firesubmersed", "true"
                      "intensity", "0.6"
                      "laserflaresize", "5.5"
                      "rgbcolor2", "0.2 0.2 0.2"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "3.5"
                      "waterweapon", "true"
                  ] }
                { name = "disintegrator"
                  displayName = "Disintegrator"
                  weaponType = Some "DGun"
                  damage = Map.ofList [
                      "commanders", 0.0
                      "default", 99999.0
                      "scavboss", 1000.0
                      "raptorqueen", 1000.0
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
                      "groundbounce", "true"
                      "noexplode", "true"
                      "soundhitwet", "sizzlexs"
                      "soundhitvolume", "36.0"
                      "soundstartvolume", "96.0"
                      "soundtrigger", "true"
                      "waterweapon", "true"
                      "weapontimer", "4.2"
                  ] }
                { name = "longgun"
                  displayName = "Arcing Stun Beam"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 56000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 550.0)
                  reloadTime = Some (ValueOrExpr.Concrete 8.0)
                  weaponVelocity = Some 1500.0
                  areaOfEffect = Some 60.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrcrw2"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-emp"
                  rgbColor = Some "0.7 0.7 1"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "GROUNDSCOUT"
                      "mount_onlytargetcategory", "EMPABLE"
                      "beamtime", "0.1"
                      "collidefriendly", "false"
                      "corethickness", "0.23"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "largebeamlaser", "true"
                      "laserflaresize", "4.05"
                      "paralyzer", "true"
                      "paralyzetime", "7.0"
                      "scrollspeed", "5.0"
                      "soundhitdry", "hackshot"
                      "soundhitwet", "sizzle"
                      "soundstartvolume", "30.0"
                      "soundhitdryvolume", "40.0"
                      "soundhitwetvolume", "30.0"
                      "soundtrigger", "1.0"
                      "texture3", "largebeam"
                      "thickness", "2.25"
                      "tilelength", "150.0"
                  ] }
                { name = "shortgun"
                  displayName = "Short-Range Lightening Discharge"
                  weaponType = Some "LightningCannon"
                  damage = Map.ofList [
                      "default", 57.0
                  ]
                  range = Some (ValueOrExpr.Concrete 425.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.1)
                  weaponVelocity = Some 400.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lghthvy2"
                  soundHit = Some ""
                  explosiongenerator = Some "custom:genericshellexplosion-medium-lightning2"
                  rgbColor = Some "0.5 0.5 1"
                  customParams = Map.ofList [
                      "spark_ceg", "genericshellexplosion-splash-lightning"
                      "spark_forkdamage", "0.33"
                      "spark_maxunits", "8"
                      "spark_range", "75"
                  ]
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "mount_fastautoretargeting", "true"
                      "avoidfeature", "false"
                      "beamttl", "1.0"
                      "burst", "3.0"
                      "burstrate", "0.03333"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "1.0"
                      "energypershot", "5.0"
                      "firestarter", "50.0"
                      "intensity", "24.0"
                      "soundhitwet", ""
                      "soundtrigger", "true"
                      "thickness", "1.5"
                  ] }
                { name = "empflashbang"
                  displayName = "EMP Damage-Mitigating Flashbang"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "default", 20000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 3.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.25)
                  weaponVelocity = Some 1.0
                  areaOfEffect = Some 50.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.001
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "xplosml5"
                  soundHit = None
                  explosiongenerator = Some "custom:genericshellexplosion-huge-lightning"
                  rgbColor = Some "1 1 1"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "COMMANDER"
                      "avoidfeature", "false"
                      "beamdecay", ".8"
                      "beamttl", "0.8"
                      "burnblow", "true"
                      "collideenemy", "false"
                      "collidefeature", "false"
                      "collidefriendly", "false"
                      "collideground", "false"
                      "collideneutral", "false"
                      "corethickness", "1.0"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "falloffrate", "0.0"
                      "impactonly", "1.0"
                      "laserflaresize", "8.8"
                      "paralyzer", "true"
                      "paralyzetime", "8.0"
                      "soundhitdry", ""
                      "soundhitwet", ""
                      "soundtrigger", "1.0"
                      "thickness", "6.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "35 12 54"
                  collisionVolumeType = Some "CylY"
                  damage = Some 32000.0
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
                "unitgroup", "builder"
                "area_mex_def", "armmex"
                "iscommander", "true"
                "effigy_offset", "1.0"
                "evocomlvl", "7.0"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "paralyzemultiplier", "0.025"
                "subfolder", ""
                "evolution_health_transfer", "percentage"
                "evolution_target", "armcomlvl8"
                "evolution_condition", "timer"
                "evolution_timer", "99999.0"
                "evolution_power_threshold", "520000.0"
                "evolution_power_multiplier", "1.0"
                "combatradius", "0.0"
                "inheritxpratemultiplier", "0.5"
                "childreninheritxp", "TURRET MOBILEBUILT"
                "parentsinheritxp", "TURRET MOBILEBUILT"
                "workertimeboost", "3.5"
                "wtboostunittype", "TURRET MOBILE"
                "effigy", "comeffigylvl4"
                "minimum_respawn_stun", "5.0"
                "distance_stun_multiplier", "1.0"
                "fall_damage_multiplier", "5.0"
            ]
          extras = Map.ofList [
                "autoheal", "5.0"
                "cancapture", "true"
                "cancloak", "true"
                "canmanualfire", "true"
                "canselfrepair", "true"
                "capturable", "false"
                "capturespeed", "1800.0"
                "cloakcost", "100.0"
                "cloakcostmoving", "1000.0"
                "damagemodifier", "0.1"
                "hidedamage", "true"
                "holdsteady", "true"
                "icontype", "armcom"
                "sightemitheight", "40.0"
                "mass", "4900.0"
                "mincloakdistance", "50.0"
                "nochasecategory", "ALL"
                "radardistance", "1200.0"
                "radaremitheight", "40.0"
                "reclaimable", "false"
                "releaseheld", "true"
                "selfdestructcountdown", "5.0"
                "showplayername", "true"
                "sonardistance", "600.0"
                "upright", "true"
            ] }

    let armcomlvl7Def : UnitDef =
        { name = "armcomlvl7"
          subfolder = "other/evocom"
          metalCost = ValueOrExpr.Concrete 8000.0
          energyCost = ValueOrExpr.Concrete 80000.0
          buildTime = ValueOrExpr.Concrete 145200.0
          health = ValueOrExpr.Concrete 10500.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMCOMHILVL.s3o"
          buildPic = Some "ARMCOM.DDS"
          script = Some "Units/ARMCOMHILVL.lua"
          corpse = Some "DEAD"
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderexplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 37.5
              maxAcc = 0.18
              maxDec = 1.125
              turnRate = 1148.0
              movementClass = Some "COMMANDERBOT"
              maxSlope = Some 20.0
              maxWaterDepth = Some 35.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 140.0
              turnInPlaceSpeedLimit = Some 0.825
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 989.0
              buildDistance = Some 193.0
              buildOptions = []
              terraformSpeed = Some 1500.0 })
          weapons = Some [
              { name = "backlauncher"
                displayName = "HeavyRockets"
                weaponType = Some "StarburstLauncher"
                damage = Map.ofList [
                    "default", 1800.0
                ]
                range = Some (ValueOrExpr.Concrete 730.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.5)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 93.0
                accuracy = None
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.61
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "Rockhvy1"
                soundHit = Some "xplomed4"
                explosiongenerator = Some "custom:genericshellexplosion-large-bomb"
                rgbColor = None
                customParams = Map.ofList [
                    "projectile_destruction_method", "descend"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "cegtag", "missiletrailmedium-starburst"
                    "craterareaofeffect", "70.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "100.0"
                    "flighttime", "7.4"
                    "model", "corkbmissl1.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "8.0"
                    "smoketime", "30.0"
                    "smokesize", "12.0"
                    "smokecolor", "0.7"
                    "smokeTrailCastShadow", "true"
                    "soundhitwet", "splssml"
                    "stockpile", "true"
                    "stockpiletime", "10.0"
                    "texture1", "null"
                    "texture2", "smoketrailbar"
                    "texture3", "null"
                    "turnrate", "15000.0"
                    "weaponacceleration", "250.0"
                    "weapontimer", "1.46"
                ] }
              { name = "armcomsealaser"
                displayName = "UltravioletRayBeam"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 1200.0
                    "subs", 600.0
                ]
                range = Some (ValueOrExpr.Concrete 500.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.43)
                weaponVelocity = Some 700.0
                areaOfEffect = Some 42.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "uwlasrfir1"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-medium-blue"
                rgbColor = Some "0.6 0.2 0.6"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTAIR"
                    "avoidfeature", "false"
                    "beamtime", "0.16"
                    "camerashake", "0.0"
                    "corethickness", "0.2"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "firestarter", "90.0"
                    "firesubmersed", "true"
                    "intensity", "0.6"
                    "laserflaresize", "5.5"
                    "rgbcolor2", "0.2 0.2 0.2"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "3.5"
                    "waterweapon", "true"
                ] }
              { name = "disintegrator"
                displayName = "Disintegrator"
                weaponType = Some "DGun"
                damage = Map.ofList [
                    "commanders", 0.0
                    "default", 99999.0
                    "scavboss", 1000.0
                    "raptorqueen", 1000.0
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
                    "groundbounce", "true"
                    "noexplode", "true"
                    "soundhitwet", "sizzlexs"
                    "soundhitvolume", "36.0"
                    "soundstartvolume", "96.0"
                    "soundtrigger", "true"
                    "waterweapon", "true"
                    "weapontimer", "4.2"
                ] }
              { name = "longgun"
                displayName = "Arcing Stun Beam"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 56000.0
                ]
                range = Some (ValueOrExpr.Concrete 550.0)
                reloadTime = Some (ValueOrExpr.Concrete 8.0)
                weaponVelocity = Some 1500.0
                areaOfEffect = Some 60.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrcrw2"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-emp"
                rgbColor = Some "0.7 0.7 1"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "GROUNDSCOUT"
                    "mount_onlytargetcategory", "EMPABLE"
                    "beamtime", "0.1"
                    "collidefriendly", "false"
                    "corethickness", "0.23"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "largebeamlaser", "true"
                    "laserflaresize", "4.05"
                    "paralyzer", "true"
                    "paralyzetime", "7.0"
                    "scrollspeed", "5.0"
                    "soundhitdry", "hackshot"
                    "soundhitwet", "sizzle"
                    "soundstartvolume", "30.0"
                    "soundhitdryvolume", "40.0"
                    "soundhitwetvolume", "30.0"
                    "soundtrigger", "1.0"
                    "texture3", "largebeam"
                    "thickness", "2.25"
                    "tilelength", "150.0"
                ] }
              { name = "shortgun"
                displayName = "Short-Range Lightening Discharge"
                weaponType = Some "LightningCannon"
                damage = Map.ofList [
                    "default", 57.0
                ]
                range = Some (ValueOrExpr.Concrete 425.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.1)
                weaponVelocity = Some 400.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lghthvy2"
                soundHit = Some ""
                explosiongenerator = Some "custom:genericshellexplosion-medium-lightning2"
                rgbColor = Some "0.5 0.5 1"
                customParams = Map.ofList [
                    "spark_ceg", "genericshellexplosion-splash-lightning"
                    "spark_forkdamage", "0.33"
                    "spark_maxunits", "8"
                    "spark_range", "75"
                ]
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "mount_fastautoretargeting", "true"
                    "avoidfeature", "false"
                    "beamttl", "1.0"
                    "burst", "3.0"
                    "burstrate", "0.03333"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "1.0"
                    "energypershot", "5.0"
                    "firestarter", "50.0"
                    "intensity", "24.0"
                    "soundhitwet", ""
                    "soundtrigger", "true"
                    "thickness", "1.5"
                ] }
              { name = "empflashbang"
                displayName = "EMP Damage-Mitigating Flashbang"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 20000.0
                ]
                range = Some (ValueOrExpr.Concrete 3.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.25)
                weaponVelocity = Some 1.0
                areaOfEffect = Some 50.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.001
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "xplosml5"
                soundHit = None
                explosiongenerator = Some "custom:genericshellexplosion-huge-lightning"
                rgbColor = Some "1 1 1"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "COMMANDER"
                    "avoidfeature", "false"
                    "beamdecay", ".8"
                    "beamttl", "0.8"
                    "burnblow", "true"
                    "collideenemy", "false"
                    "collidefeature", "false"
                    "collidefriendly", "false"
                    "collideground", "false"
                    "collideneutral", "false"
                    "corethickness", "1.0"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "falloffrate", "0.0"
                    "impactonly", "1.0"
                    "laserflaresize", "8.8"
                    "paralyzer", "true"
                    "paralyzetime", "8.0"
                    "soundhitdry", ""
                    "soundhitwet", ""
                    "soundtrigger", "1.0"
                    "thickness", "6.0"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 525.0)
              metalMake = Some (ValueOrExpr.Concrete 27.0)
              energyStorage = Some 3500.0
              metalStorage = Some 500.0
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "35 12 54"
                collisionVolumeType = Some "CylY"
                damage = Some 32000.0
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
          ])
          sounds = Some (
            { build = Some "nanlath1"
              repair = Some "repair1"
              working = Some "reclaim1"
              underAttack = Some "warning2"
              cancelDestruct = Some "cancel2"
              capture = Some "capture1"
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["armcom1"; "armcom2"; "armcom3"; "armcom4"]
              select = ["armcomsel"] })
          customParams = Map.ofList [
              "unitgroup", "builder"
              "area_mex_def", "armmex"
              "iscommander", "true"
              "effigy_offset", "1.0"
              "evocomlvl", "7.0"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "paralyzemultiplier", "0.025"
              "subfolder", ""
              "evolution_health_transfer", "percentage"
              "evolution_target", "armcomlvl8"
              "evolution_condition", "timer"
              "evolution_timer", "99999.0"
              "evolution_power_threshold", "520000.0"
              "evolution_power_multiplier", "1.0"
              "combatradius", "0.0"
              "inheritxpratemultiplier", "0.5"
              "childreninheritxp", "TURRET MOBILEBUILT"
              "parentsinheritxp", "TURRET MOBILEBUILT"
              "workertimeboost", "3.5"
              "wtboostunittype", "TURRET MOBILE"
              "effigy", "comeffigylvl4"
              "minimum_respawn_stun", "5.0"
              "distance_stun_multiplier", "1.0"
              "fall_damage_multiplier", "5.0"
          ]
          extras = Map.ofList [
              "autoheal", "5.0"
              "cancapture", "true"
              "cancloak", "true"
              "canmanualfire", "true"
              "canselfrepair", "true"
              "capturable", "false"
              "capturespeed", "1800.0"
              "cloakcost", "100.0"
              "cloakcostmoving", "1000.0"
              "damagemodifier", "0.1"
              "hidedamage", "true"
              "holdsteady", "true"
              "icontype", "armcom"
              "sightemitheight", "40.0"
              "mass", "4900.0"
              "mincloakdistance", "50.0"
              "nochasecategory", "ALL"
              "radardistance", "1200.0"
              "radaremitheight", "40.0"
              "reclaimable", "false"
              "releaseheld", "true"
              "selfdestructcountdown", "5.0"
              "showplayername", "true"
              "sonardistance", "600.0"
              "upright", "true"
          ] }

    let armcomlvl7ToFlat (def: UnitDef) : Armcomlvl7 =
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
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          workerTime = def.builder.Value.workerTime
          buildDistance = def.builder.Value.buildDistance.Value
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyMake = def.economy.Value.energyMake.Value
          metalMake = def.economy.Value.metalMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armcomlvl7ToUnitDef (flat: Armcomlvl7) : UnitDef =
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
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = Some flat.movementClass
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = Some flat.buildDistance
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = Some flat.weapons
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = Some flat.metalMake
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armcomlvl8 =
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

    let armcomlvl8 : Armcomlvl8 =
        { name = "armcomlvl8"
          subfolder = "other/evocom"
          metalCost = ValueOrExpr.Concrete 9000.0
          energyCost = ValueOrExpr.Concrete 90000.0
          buildTime = ValueOrExpr.Concrete 162000.0
          health = ValueOrExpr.Concrete 11400.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMCOMHILVL.s3o"
          buildPic = Some "ARMCOM.DDS"
          script = Some "Units/ARMCOMHILVL.lua"
          corpse = Some "DEAD"
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderexplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
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
          workerTime = ValueOrExpr.Concrete 1207.0
          buildDistance = 201.0
          buildOptions = []
          terraformSpeed = 1500.0
          energyMake = ValueOrExpr.Concrete 850.0
          metalMake = ValueOrExpr.Concrete 34.0
          energyStorage = 5000.0
          metalStorage = 500.0
          weapons = [
                { name = "backlauncher"
                  displayName = "HeavyRockets"
                  weaponType = Some "StarburstLauncher"
                  damage = Map.ofList [
                      "default", 2300.0
                  ]
                  range = Some (ValueOrExpr.Concrete 800.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.0)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 102.0
                  accuracy = None
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.61
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "Rockhvy1"
                  soundHit = Some "xplomed4"
                  explosiongenerator = Some "custom:genericshellexplosion-large-bomb"
                  rgbColor = None
                  customParams = Map.ofList [
                      "projectile_destruction_method", "descend"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "MOBILE"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "cegtag", "missiletrailmedium-starburst"
                      "craterareaofeffect", "70.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "100.0"
                      "flighttime", "7.4"
                      "model", "corkbmissl1.s3o"
                      "smoketrail", "true"
                      "smokePeriod", "8.0"
                      "smoketime", "30.0"
                      "smokesize", "12.0"
                      "smokecolor", "0.7"
                      "smokeTrailCastShadow", "true"
                      "soundhitwet", "splssml"
                      "stockpile", "true"
                      "stockpiletime", "10.0"
                      "texture1", "null"
                      "texture2", "smoketrailbar"
                      "texture3", "null"
                      "turnrate", "15000.0"
                      "weaponacceleration", "250.0"
                      "weapontimer", "1.6"
                  ] }
                { name = "armcomsealaser"
                  displayName = "UWSupernovaBeam"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 1400.0
                      "subs", 700.0
                  ]
                  range = Some (ValueOrExpr.Concrete 500.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.4)
                  weaponVelocity = Some 700.0
                  areaOfEffect = Some 70.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "uwlasrfir1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-medium-blue"
                  rgbColor = Some "0.1 0.2 0.7"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTAIR"
                      "avoidfeature", "false"
                      "beamtime", "0.16"
                      "camerashake", "0.0"
                      "corethickness", "0.5"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "90.0"
                      "firesubmersed", "true"
                      "intensity", "0.6"
                      "laserflaresize", "5.5"
                      "rgbcolor2", "0.9 0.9 0.9"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "3.5"
                      "waterweapon", "true"
                  ] }
                { name = "disintegrator"
                  displayName = "Disintegrator"
                  weaponType = Some "DGun"
                  damage = Map.ofList [
                      "commanders", 0.0
                      "default", 99999.0
                      "scavboss", 1000.0
                      "raptorqueen", 1000.0
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
                      "soundhitwet", "sizzlexs"
                      "soundhitvolume", "36.0"
                      "soundstartvolume", "96.0"
                      "soundtrigger", "true"
                      "waterweapon", "true"
                      "weapontimer", "4.2"
                  ] }
                { name = "longgun"
                  displayName = "Arcing Stun Beam"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 60000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 600.0)
                  reloadTime = Some (ValueOrExpr.Concrete 8.0)
                  weaponVelocity = Some 1500.0
                  areaOfEffect = Some 60.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrcrw2"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-emp"
                  rgbColor = Some "0.7 0.7 1"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "GROUNDSCOUT"
                      "mount_onlytargetcategory", "EMPABLE"
                      "beamtime", "0.15"
                      "collidefriendly", "false"
                      "corethickness", "0.23"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "largebeamlaser", "true"
                      "laserflaresize", "5.05"
                      "paralyzer", "true"
                      "paralyzetime", "7.0"
                      "scrollspeed", "5.0"
                      "soundhitdry", "hackshot"
                      "soundhitwet", "sizzle"
                      "soundstartvolume", "30.0"
                      "soundhitdryvolume", "40.0"
                      "soundhitwetvolume", "30.0"
                      "soundtrigger", "1.0"
                      "texture3", "largebeam"
                      "thickness", "3.0"
                      "tilelength", "150.0"
                  ] }
                { name = "shortgun"
                  displayName = "Short-Range Lightening Discharge"
                  weaponType = Some "LightningCannon"
                  damage = Map.ofList [
                      "default", 72.0
                  ]
                  range = Some (ValueOrExpr.Concrete 500.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.1)
                  weaponVelocity = Some 400.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lghthvy2"
                  soundHit = Some ""
                  explosiongenerator = Some "custom:genericshellexplosion-medium-lightning2"
                  rgbColor = Some "1.0, 0.7, 0.0"
                  customParams = Map.ofList [
                      "spark_ceg", "genericshellexplosion-splash-lightning"
                      "spark_forkdamage", "0.33"
                      "spark_maxunits", "8"
                      "spark_range", "100"
                  ]
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "mount_fastautoretargeting", "true"
                      "avoidfeature", "false"
                      "beamttl", "1.0"
                      "burst", "3.0"
                      "burstrate", "0.03333"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "1.0"
                      "energypershot", "5.0"
                      "firestarter", "50.0"
                      "intensity", "24.0"
                      "soundhitwet", ""
                      "soundtrigger", "true"
                      "thickness", "1.5"
                  ] }
                { name = "empflashbang"
                  displayName = "EMP Damage-Mitigating Flashbang"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "default", 20000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 3.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.25)
                  weaponVelocity = Some 1.0
                  areaOfEffect = Some 50.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.001
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "xplosml5"
                  soundHit = None
                  explosiongenerator = Some "custom:genericshellexplosion-huge-lightning"
                  rgbColor = Some "1 1 1"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "COMMANDER"
                      "avoidfeature", "false"
                      "beamdecay", ".8"
                      "beamttl", "0.8"
                      "burnblow", "true"
                      "collideenemy", "false"
                      "collidefeature", "false"
                      "collidefriendly", "false"
                      "collideground", "false"
                      "collideneutral", "false"
                      "corethickness", "1.0"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "falloffrate", "0.0"
                      "impactonly", "1.0"
                      "laserflaresize", "8.8"
                      "paralyzer", "true"
                      "paralyzetime", "8.0"
                      "soundhitdry", ""
                      "soundhitwet", ""
                      "soundtrigger", "1.0"
                      "thickness", "6.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "35 12 54"
                  collisionVolumeType = Some "CylY"
                  damage = Some 36000.0
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
                "unitgroup", "builder"
                "area_mex_def", "armmex"
                "iscommander", "true"
                "effigy_offset", "1.0"
                "evocomlvl", "8.0"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "paralyzemultiplier", "0.025"
                "subfolder", ""
                "evolution_health_transfer", "percentage"
                "evolution_target", "armcomlvl9"
                "evolution_condition", "timer"
                "evolution_timer", "99999.0"
                "evolution_power_threshold", "660000.0"
                "evolution_power_multiplier", "1.0"
                "combatradius", "0.0"
                "inheritxpratemultiplier", "0.5"
                "childreninheritxp", "TURRET MOBILEBUILT"
                "parentsinheritxp", "TURRET MOBILEBUILT"
                "workertimeboost", "3.5"
                "wtboostunittype", "TURRET MOBILE"
                "effigy", "comeffigylvl4"
                "minimum_respawn_stun", "5.0"
                "distance_stun_multiplier", "1.0"
                "fall_damage_multiplier", "5.0"
            ]
          extras = Map.ofList [
                "autoheal", "5.0"
                "cancapture", "true"
                "cancloak", "true"
                "canmanualfire", "true"
                "canselfrepair", "true"
                "capturable", "false"
                "capturespeed", "1800.0"
                "cloakcost", "100.0"
                "cloakcostmoving", "1000.0"
                "damagemodifier", "0.1"
                "hidedamage", "true"
                "holdsteady", "true"
                "icontype", "armcom"
                "sightemitheight", "40.0"
                "mass", "4900.0"
                "mincloakdistance", "50.0"
                "nochasecategory", "ALL"
                "radardistance", "1200.0"
                "radaremitheight", "40.0"
                "reclaimable", "false"
                "releaseheld", "true"
                "selfdestructcountdown", "5.0"
                "showplayername", "true"
                "sonardistance", "600.0"
                "upright", "true"
            ] }

    let armcomlvl8Def : UnitDef =
        { name = "armcomlvl8"
          subfolder = "other/evocom"
          metalCost = ValueOrExpr.Concrete 9000.0
          energyCost = ValueOrExpr.Concrete 90000.0
          buildTime = ValueOrExpr.Concrete 162000.0
          health = ValueOrExpr.Concrete 11400.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMCOMHILVL.s3o"
          buildPic = Some "ARMCOM.DDS"
          script = Some "Units/ARMCOMHILVL.lua"
          corpse = Some "DEAD"
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderexplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 37.5
              maxAcc = 0.18
              maxDec = 1.125
              turnRate = 1148.0
              movementClass = Some "COMMANDERBOT"
              maxSlope = Some 20.0
              maxWaterDepth = Some 35.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 140.0
              turnInPlaceSpeedLimit = Some 0.825
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 1207.0
              buildDistance = Some 201.0
              buildOptions = []
              terraformSpeed = Some 1500.0 })
          weapons = Some [
              { name = "backlauncher"
                displayName = "HeavyRockets"
                weaponType = Some "StarburstLauncher"
                damage = Map.ofList [
                    "default", 2300.0
                ]
                range = Some (ValueOrExpr.Concrete 800.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.0)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 102.0
                accuracy = None
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.61
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "Rockhvy1"
                soundHit = Some "xplomed4"
                explosiongenerator = Some "custom:genericshellexplosion-large-bomb"
                rgbColor = None
                customParams = Map.ofList [
                    "projectile_destruction_method", "descend"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "cegtag", "missiletrailmedium-starburst"
                    "craterareaofeffect", "70.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "100.0"
                    "flighttime", "7.4"
                    "model", "corkbmissl1.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "8.0"
                    "smoketime", "30.0"
                    "smokesize", "12.0"
                    "smokecolor", "0.7"
                    "smokeTrailCastShadow", "true"
                    "soundhitwet", "splssml"
                    "stockpile", "true"
                    "stockpiletime", "10.0"
                    "texture1", "null"
                    "texture2", "smoketrailbar"
                    "texture3", "null"
                    "turnrate", "15000.0"
                    "weaponacceleration", "250.0"
                    "weapontimer", "1.6"
                ] }
              { name = "armcomsealaser"
                displayName = "UWSupernovaBeam"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 1400.0
                    "subs", 700.0
                ]
                range = Some (ValueOrExpr.Concrete 500.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.4)
                weaponVelocity = Some 700.0
                areaOfEffect = Some 70.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "uwlasrfir1"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-medium-blue"
                rgbColor = Some "0.1 0.2 0.7"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTAIR"
                    "avoidfeature", "false"
                    "beamtime", "0.16"
                    "camerashake", "0.0"
                    "corethickness", "0.5"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "firestarter", "90.0"
                    "firesubmersed", "true"
                    "intensity", "0.6"
                    "laserflaresize", "5.5"
                    "rgbcolor2", "0.9 0.9 0.9"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "3.5"
                    "waterweapon", "true"
                ] }
              { name = "disintegrator"
                displayName = "Disintegrator"
                weaponType = Some "DGun"
                damage = Map.ofList [
                    "commanders", 0.0
                    "default", 99999.0
                    "scavboss", 1000.0
                    "raptorqueen", 1000.0
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
                    "soundhitwet", "sizzlexs"
                    "soundhitvolume", "36.0"
                    "soundstartvolume", "96.0"
                    "soundtrigger", "true"
                    "waterweapon", "true"
                    "weapontimer", "4.2"
                ] }
              { name = "longgun"
                displayName = "Arcing Stun Beam"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 60000.0
                ]
                range = Some (ValueOrExpr.Concrete 600.0)
                reloadTime = Some (ValueOrExpr.Concrete 8.0)
                weaponVelocity = Some 1500.0
                areaOfEffect = Some 60.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrcrw2"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-emp"
                rgbColor = Some "0.7 0.7 1"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "GROUNDSCOUT"
                    "mount_onlytargetcategory", "EMPABLE"
                    "beamtime", "0.15"
                    "collidefriendly", "false"
                    "corethickness", "0.23"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "largebeamlaser", "true"
                    "laserflaresize", "5.05"
                    "paralyzer", "true"
                    "paralyzetime", "7.0"
                    "scrollspeed", "5.0"
                    "soundhitdry", "hackshot"
                    "soundhitwet", "sizzle"
                    "soundstartvolume", "30.0"
                    "soundhitdryvolume", "40.0"
                    "soundhitwetvolume", "30.0"
                    "soundtrigger", "1.0"
                    "texture3", "largebeam"
                    "thickness", "3.0"
                    "tilelength", "150.0"
                ] }
              { name = "shortgun"
                displayName = "Short-Range Lightening Discharge"
                weaponType = Some "LightningCannon"
                damage = Map.ofList [
                    "default", 72.0
                ]
                range = Some (ValueOrExpr.Concrete 500.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.1)
                weaponVelocity = Some 400.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lghthvy2"
                soundHit = Some ""
                explosiongenerator = Some "custom:genericshellexplosion-medium-lightning2"
                rgbColor = Some "1.0, 0.7, 0.0"
                customParams = Map.ofList [
                    "spark_ceg", "genericshellexplosion-splash-lightning"
                    "spark_forkdamage", "0.33"
                    "spark_maxunits", "8"
                    "spark_range", "100"
                ]
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "mount_fastautoretargeting", "true"
                    "avoidfeature", "false"
                    "beamttl", "1.0"
                    "burst", "3.0"
                    "burstrate", "0.03333"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "1.0"
                    "energypershot", "5.0"
                    "firestarter", "50.0"
                    "intensity", "24.0"
                    "soundhitwet", ""
                    "soundtrigger", "true"
                    "thickness", "1.5"
                ] }
              { name = "empflashbang"
                displayName = "EMP Damage-Mitigating Flashbang"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 20000.0
                ]
                range = Some (ValueOrExpr.Concrete 3.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.25)
                weaponVelocity = Some 1.0
                areaOfEffect = Some 50.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.001
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "xplosml5"
                soundHit = None
                explosiongenerator = Some "custom:genericshellexplosion-huge-lightning"
                rgbColor = Some "1 1 1"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "COMMANDER"
                    "avoidfeature", "false"
                    "beamdecay", ".8"
                    "beamttl", "0.8"
                    "burnblow", "true"
                    "collideenemy", "false"
                    "collidefeature", "false"
                    "collidefriendly", "false"
                    "collideground", "false"
                    "collideneutral", "false"
                    "corethickness", "1.0"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "falloffrate", "0.0"
                    "impactonly", "1.0"
                    "laserflaresize", "8.8"
                    "paralyzer", "true"
                    "paralyzetime", "8.0"
                    "soundhitdry", ""
                    "soundhitwet", ""
                    "soundtrigger", "1.0"
                    "thickness", "6.0"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 850.0)
              metalMake = Some (ValueOrExpr.Concrete 34.0)
              energyStorage = Some 5000.0
              metalStorage = Some 500.0
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "35 12 54"
                collisionVolumeType = Some "CylY"
                damage = Some 36000.0
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
          ])
          sounds = Some (
            { build = Some "nanlath1"
              repair = Some "repair1"
              working = Some "reclaim1"
              underAttack = Some "warning2"
              cancelDestruct = Some "cancel2"
              capture = Some "capture1"
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["armcom1"; "armcom2"; "armcom3"; "armcom4"]
              select = ["armcomsel"] })
          customParams = Map.ofList [
              "unitgroup", "builder"
              "area_mex_def", "armmex"
              "iscommander", "true"
              "effigy_offset", "1.0"
              "evocomlvl", "8.0"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "paralyzemultiplier", "0.025"
              "subfolder", ""
              "evolution_health_transfer", "percentage"
              "evolution_target", "armcomlvl9"
              "evolution_condition", "timer"
              "evolution_timer", "99999.0"
              "evolution_power_threshold", "660000.0"
              "evolution_power_multiplier", "1.0"
              "combatradius", "0.0"
              "inheritxpratemultiplier", "0.5"
              "childreninheritxp", "TURRET MOBILEBUILT"
              "parentsinheritxp", "TURRET MOBILEBUILT"
              "workertimeboost", "3.5"
              "wtboostunittype", "TURRET MOBILE"
              "effigy", "comeffigylvl4"
              "minimum_respawn_stun", "5.0"
              "distance_stun_multiplier", "1.0"
              "fall_damage_multiplier", "5.0"
          ]
          extras = Map.ofList [
              "autoheal", "5.0"
              "cancapture", "true"
              "cancloak", "true"
              "canmanualfire", "true"
              "canselfrepair", "true"
              "capturable", "false"
              "capturespeed", "1800.0"
              "cloakcost", "100.0"
              "cloakcostmoving", "1000.0"
              "damagemodifier", "0.1"
              "hidedamage", "true"
              "holdsteady", "true"
              "icontype", "armcom"
              "sightemitheight", "40.0"
              "mass", "4900.0"
              "mincloakdistance", "50.0"
              "nochasecategory", "ALL"
              "radardistance", "1200.0"
              "radaremitheight", "40.0"
              "reclaimable", "false"
              "releaseheld", "true"
              "selfdestructcountdown", "5.0"
              "showplayername", "true"
              "sonardistance", "600.0"
              "upright", "true"
          ] }

    let armcomlvl8ToFlat (def: UnitDef) : Armcomlvl8 =
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
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          workerTime = def.builder.Value.workerTime
          buildDistance = def.builder.Value.buildDistance.Value
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyMake = def.economy.Value.energyMake.Value
          metalMake = def.economy.Value.metalMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armcomlvl8ToUnitDef (flat: Armcomlvl8) : UnitDef =
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
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = Some flat.movementClass
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = Some flat.buildDistance
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = Some flat.weapons
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = Some flat.metalMake
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armcomlvl9 =
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

    let armcomlvl9 : Armcomlvl9 =
        { name = "armcomlvl9"
          subfolder = "other/evocom"
          metalCost = ValueOrExpr.Concrete 10000.0
          energyCost = ValueOrExpr.Concrete 100000.0
          buildTime = ValueOrExpr.Concrete 178000.0
          health = ValueOrExpr.Concrete 12300.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMCOMHILVL.s3o"
          buildPic = Some "ARMCOM.DDS"
          script = Some "Units/ARMCOMHILVL.lua"
          corpse = Some "DEAD"
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderexplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
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
          workerTime = ValueOrExpr.Concrete 1472.0
          buildDistance = 209.0
          buildOptions = []
          terraformSpeed = 1500.0
          energyMake = ValueOrExpr.Concrete 1375.0
          metalMake = ValueOrExpr.Concrete 42.0
          energyStorage = 7500.0
          metalStorage = 500.0
          weapons = [
                { name = "backlauncher"
                  displayName = "HeavyRockets"
                  weaponType = Some "StarburstLauncher"
                  damage = Map.ofList [
                      "default", 3600.0
                  ]
                  range = Some (ValueOrExpr.Concrete 870.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.0)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 111.0
                  accuracy = None
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.61
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "Rockhvy1"
                  soundHit = Some "xplomed4"
                  explosiongenerator = Some "custom:genericshellexplosion-large-bomb"
                  rgbColor = None
                  customParams = Map.ofList [
                      "projectile_destruction_method", "descend"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "MOBILE"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "cegtag", "missiletrailmedium-starburst"
                      "craterareaofeffect", "70.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "100.0"
                      "flighttime", "7.4"
                      "model", "corkbmissl1.s3o"
                      "smoketrail", "true"
                      "smokePeriod", "8.0"
                      "smoketime", "30.0"
                      "smokesize", "12.0"
                      "smokecolor", "0.7"
                      "smokeTrailCastShadow", "true"
                      "soundhitwet", "splssml"
                      "stockpile", "true"
                      "stockpiletime", "10.0"
                      "texture1", "null"
                      "texture2", "smoketrailbar"
                      "texture3", "null"
                      "turnrate", "15000.0"
                      "weaponacceleration", "250.0"
                      "weapontimer", "1.74"
                  ] }
                { name = "armcomsealaser"
                  displayName = "UWSupernovaBeam"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 1400.0
                      "subs", 700.0
                  ]
                  range = Some (ValueOrExpr.Concrete 500.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.33)
                  weaponVelocity = Some 700.0
                  areaOfEffect = Some 70.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "uwlasrfir1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-medium-blue"
                  rgbColor = Some "0.2 0.3 0.8"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTAIR"
                      "avoidfeature", "false"
                      "beamtime", "0.16"
                      "camerashake", "0.0"
                      "corethickness", "0.4"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "90.0"
                      "firesubmersed", "true"
                      "intensity", "0.6"
                      "laserflaresize", "5.5"
                      "rgbcolor2", "1 1 1"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "3.5"
                      "waterweapon", "true"
                  ] }
                { name = "disintegrator"
                  displayName = "Disintegrator"
                  weaponType = Some "DGun"
                  damage = Map.ofList [
                      "commanders", 0.0
                      "default", 99999.0
                      "scavboss", 1000.0
                      "raptorqueen", 1000.0
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
                      "soundhitwet", "sizzlexs"
                      "soundhitvolume", "36.0"
                      "soundstartvolume", "96.0"
                      "soundtrigger", "true"
                      "waterweapon", "true"
                      "weapontimer", "4.2"
                  ] }
                { name = "longgun"
                  displayName = "Arcing Stun Beam"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 60000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 600.0)
                  reloadTime = Some (ValueOrExpr.Concrete 8.0)
                  weaponVelocity = Some 1500.0
                  areaOfEffect = Some 60.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrcrw2"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-emp"
                  rgbColor = Some "0.7 0.7 1"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "GROUNDSCOUT"
                      "mount_onlytargetcategory", "EMPABLE"
                      "beamtime", "0.15"
                      "collidefriendly", "false"
                      "corethickness", "0.23"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "largebeamlaser", "true"
                      "laserflaresize", "5.05"
                      "paralyzer", "true"
                      "paralyzetime", "7.0"
                      "scrollspeed", "5.0"
                      "soundhitdry", "hackshot"
                      "soundhitwet", "sizzle"
                      "soundstartvolume", "30.0"
                      "soundhitdryvolume", "40.0"
                      "soundhitwetvolume", "30.0"
                      "soundtrigger", "1.0"
                      "texture3", "largebeam"
                      "thickness", "3.0"
                      "tilelength", "150.0"
                  ] }
                { name = "shortgun"
                  displayName = "Short-Range Lightening Discharge"
                  weaponType = Some "LightningCannon"
                  damage = Map.ofList [
                      "default", 88.0
                  ]
                  range = Some (ValueOrExpr.Concrete 500.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.1)
                  weaponVelocity = Some 400.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lghthvy2"
                  soundHit = Some ""
                  explosiongenerator = Some "custom:genericshellexplosion-medium-lightning2"
                  rgbColor = Some "1.0, 0.7, 0.0"
                  customParams = Map.ofList [
                      "spark_ceg", "genericshellexplosion-splash-lightning"
                      "spark_forkdamage", "0.33"
                      "spark_maxunits", "12"
                      "spark_range", "100"
                  ]
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "mount_fastautoretargeting", "true"
                      "avoidfeature", "false"
                      "beamttl", "1.0"
                      "burst", "3.0"
                      "burstrate", "0.03333"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "1.0"
                      "energypershot", "5.0"
                      "firestarter", "50.0"
                      "intensity", "24.0"
                      "soundhitwet", ""
                      "soundtrigger", "true"
                      "thickness", "1.5"
                  ] }
                { name = "empflashbang"
                  displayName = "EMP Damage-Mitigating Flashbang"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "default", 20000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 3.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.25)
                  weaponVelocity = Some 1.0
                  areaOfEffect = Some 50.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.001
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "xplosml5"
                  soundHit = None
                  explosiongenerator = Some "custom:genericshellexplosion-huge-lightning"
                  rgbColor = Some "1 1 1"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "COMMANDER"
                      "avoidfeature", "false"
                      "beamdecay", ".8"
                      "beamttl", "0.8"
                      "burnblow", "true"
                      "collideenemy", "false"
                      "collidefeature", "false"
                      "collidefriendly", "false"
                      "collideground", "false"
                      "collideneutral", "false"
                      "corethickness", "1.0"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "falloffrate", "0.0"
                      "impactonly", "1.0"
                      "laserflaresize", "8.8"
                      "paralyzer", "true"
                      "paralyzetime", "8.0"
                      "soundhitdry", ""
                      "soundhitwet", ""
                      "soundtrigger", "1.0"
                      "thickness", "6.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "35 12 54"
                  collisionVolumeType = Some "CylY"
                  damage = Some 40000.0
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
                "unitgroup", "builder"
                "area_mex_def", "armmex"
                "iscommander", "true"
                "effigy_offset", "1.0"
                "evocomlvl", "9.0"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "paralyzemultiplier", "0.025"
                "subfolder", ""
                "evolution_health_transfer", "percentage"
                "evolution_target", "armcomlvl10"
                "evolution_condition", "timer"
                "evolution_timer", "99999.0"
                "evolution_power_threshold", "800000.0"
                "evolution_power_multiplier", "1.0"
                "combatradius", "0.0"
                "inheritxpratemultiplier", "0.5"
                "childreninheritxp", "TURRET MOBILEBUILT"
                "parentsinheritxp", "TURRET MOBILEBUILT"
                "workertimeboost", "3.5"
                "wtboostunittype", "TURRET MOBILE"
                "effigy", "comeffigylvl5"
                "minimum_respawn_stun", "5.0"
                "distance_stun_multiplier", "1.0"
                "fall_damage_multiplier", "5.0"
            ]
          extras = Map.ofList [
                "autoheal", "5.0"
                "cancapture", "true"
                "cancloak", "true"
                "canmanualfire", "true"
                "canselfrepair", "true"
                "capturable", "false"
                "capturespeed", "1800.0"
                "cloakcost", "100.0"
                "cloakcostmoving", "1000.0"
                "damagemodifier", "0.1"
                "hidedamage", "true"
                "holdsteady", "true"
                "icontype", "armcom"
                "sightemitheight", "40.0"
                "mass", "4900.0"
                "mincloakdistance", "50.0"
                "nochasecategory", "ALL"
                "radardistance", "1200.0"
                "radaremitheight", "40.0"
                "reclaimable", "false"
                "releaseheld", "true"
                "selfdestructcountdown", "5.0"
                "showplayername", "true"
                "sonardistance", "600.0"
                "upright", "true"
            ] }

    let armcomlvl9Def : UnitDef =
        { name = "armcomlvl9"
          subfolder = "other/evocom"
          metalCost = ValueOrExpr.Concrete 10000.0
          energyCost = ValueOrExpr.Concrete 100000.0
          buildTime = ValueOrExpr.Concrete 178000.0
          health = ValueOrExpr.Concrete 12300.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMCOMHILVL.s3o"
          buildPic = Some "ARMCOM.DDS"
          script = Some "Units/ARMCOMHILVL.lua"
          corpse = Some "DEAD"
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderexplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 37.5
              maxAcc = 0.18
              maxDec = 1.125
              turnRate = 1148.0
              movementClass = Some "COMMANDERBOT"
              maxSlope = Some 20.0
              maxWaterDepth = Some 35.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 140.0
              turnInPlaceSpeedLimit = Some 0.825
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 1472.0
              buildDistance = Some 209.0
              buildOptions = []
              terraformSpeed = Some 1500.0 })
          weapons = Some [
              { name = "backlauncher"
                displayName = "HeavyRockets"
                weaponType = Some "StarburstLauncher"
                damage = Map.ofList [
                    "default", 3600.0
                ]
                range = Some (ValueOrExpr.Concrete 870.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.0)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 111.0
                accuracy = None
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.61
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "Rockhvy1"
                soundHit = Some "xplomed4"
                explosiongenerator = Some "custom:genericshellexplosion-large-bomb"
                rgbColor = None
                customParams = Map.ofList [
                    "projectile_destruction_method", "descend"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "cegtag", "missiletrailmedium-starburst"
                    "craterareaofeffect", "70.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "100.0"
                    "flighttime", "7.4"
                    "model", "corkbmissl1.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "8.0"
                    "smoketime", "30.0"
                    "smokesize", "12.0"
                    "smokecolor", "0.7"
                    "smokeTrailCastShadow", "true"
                    "soundhitwet", "splssml"
                    "stockpile", "true"
                    "stockpiletime", "10.0"
                    "texture1", "null"
                    "texture2", "smoketrailbar"
                    "texture3", "null"
                    "turnrate", "15000.0"
                    "weaponacceleration", "250.0"
                    "weapontimer", "1.74"
                ] }
              { name = "armcomsealaser"
                displayName = "UWSupernovaBeam"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 1400.0
                    "subs", 700.0
                ]
                range = Some (ValueOrExpr.Concrete 500.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.33)
                weaponVelocity = Some 700.0
                areaOfEffect = Some 70.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "uwlasrfir1"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-medium-blue"
                rgbColor = Some "0.2 0.3 0.8"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTAIR"
                    "avoidfeature", "false"
                    "beamtime", "0.16"
                    "camerashake", "0.0"
                    "corethickness", "0.4"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "firestarter", "90.0"
                    "firesubmersed", "true"
                    "intensity", "0.6"
                    "laserflaresize", "5.5"
                    "rgbcolor2", "1 1 1"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "3.5"
                    "waterweapon", "true"
                ] }
              { name = "disintegrator"
                displayName = "Disintegrator"
                weaponType = Some "DGun"
                damage = Map.ofList [
                    "commanders", 0.0
                    "default", 99999.0
                    "scavboss", 1000.0
                    "raptorqueen", 1000.0
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
                    "soundhitwet", "sizzlexs"
                    "soundhitvolume", "36.0"
                    "soundstartvolume", "96.0"
                    "soundtrigger", "true"
                    "waterweapon", "true"
                    "weapontimer", "4.2"
                ] }
              { name = "longgun"
                displayName = "Arcing Stun Beam"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 60000.0
                ]
                range = Some (ValueOrExpr.Concrete 600.0)
                reloadTime = Some (ValueOrExpr.Concrete 8.0)
                weaponVelocity = Some 1500.0
                areaOfEffect = Some 60.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrcrw2"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-emp"
                rgbColor = Some "0.7 0.7 1"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "GROUNDSCOUT"
                    "mount_onlytargetcategory", "EMPABLE"
                    "beamtime", "0.15"
                    "collidefriendly", "false"
                    "corethickness", "0.23"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "largebeamlaser", "true"
                    "laserflaresize", "5.05"
                    "paralyzer", "true"
                    "paralyzetime", "7.0"
                    "scrollspeed", "5.0"
                    "soundhitdry", "hackshot"
                    "soundhitwet", "sizzle"
                    "soundstartvolume", "30.0"
                    "soundhitdryvolume", "40.0"
                    "soundhitwetvolume", "30.0"
                    "soundtrigger", "1.0"
                    "texture3", "largebeam"
                    "thickness", "3.0"
                    "tilelength", "150.0"
                ] }
              { name = "shortgun"
                displayName = "Short-Range Lightening Discharge"
                weaponType = Some "LightningCannon"
                damage = Map.ofList [
                    "default", 88.0
                ]
                range = Some (ValueOrExpr.Concrete 500.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.1)
                weaponVelocity = Some 400.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lghthvy2"
                soundHit = Some ""
                explosiongenerator = Some "custom:genericshellexplosion-medium-lightning2"
                rgbColor = Some "1.0, 0.7, 0.0"
                customParams = Map.ofList [
                    "spark_ceg", "genericshellexplosion-splash-lightning"
                    "spark_forkdamage", "0.33"
                    "spark_maxunits", "12"
                    "spark_range", "100"
                ]
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "mount_fastautoretargeting", "true"
                    "avoidfeature", "false"
                    "beamttl", "1.0"
                    "burst", "3.0"
                    "burstrate", "0.03333"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "1.0"
                    "energypershot", "5.0"
                    "firestarter", "50.0"
                    "intensity", "24.0"
                    "soundhitwet", ""
                    "soundtrigger", "true"
                    "thickness", "1.5"
                ] }
              { name = "empflashbang"
                displayName = "EMP Damage-Mitigating Flashbang"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 20000.0
                ]
                range = Some (ValueOrExpr.Concrete 3.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.25)
                weaponVelocity = Some 1.0
                areaOfEffect = Some 50.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.001
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "xplosml5"
                soundHit = None
                explosiongenerator = Some "custom:genericshellexplosion-huge-lightning"
                rgbColor = Some "1 1 1"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "COMMANDER"
                    "avoidfeature", "false"
                    "beamdecay", ".8"
                    "beamttl", "0.8"
                    "burnblow", "true"
                    "collideenemy", "false"
                    "collidefeature", "false"
                    "collidefriendly", "false"
                    "collideground", "false"
                    "collideneutral", "false"
                    "corethickness", "1.0"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "falloffrate", "0.0"
                    "impactonly", "1.0"
                    "laserflaresize", "8.8"
                    "paralyzer", "true"
                    "paralyzetime", "8.0"
                    "soundhitdry", ""
                    "soundhitwet", ""
                    "soundtrigger", "1.0"
                    "thickness", "6.0"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 1375.0)
              metalMake = Some (ValueOrExpr.Concrete 42.0)
              energyStorage = Some 7500.0
              metalStorage = Some 500.0
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "35 12 54"
                collisionVolumeType = Some "CylY"
                damage = Some 40000.0
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
          ])
          sounds = Some (
            { build = Some "nanlath1"
              repair = Some "repair1"
              working = Some "reclaim1"
              underAttack = Some "warning2"
              cancelDestruct = Some "cancel2"
              capture = Some "capture1"
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["armcom1"; "armcom2"; "armcom3"; "armcom4"]
              select = ["armcomsel"] })
          customParams = Map.ofList [
              "unitgroup", "builder"
              "area_mex_def", "armmex"
              "iscommander", "true"
              "effigy_offset", "1.0"
              "evocomlvl", "9.0"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "paralyzemultiplier", "0.025"
              "subfolder", ""
              "evolution_health_transfer", "percentage"
              "evolution_target", "armcomlvl10"
              "evolution_condition", "timer"
              "evolution_timer", "99999.0"
              "evolution_power_threshold", "800000.0"
              "evolution_power_multiplier", "1.0"
              "combatradius", "0.0"
              "inheritxpratemultiplier", "0.5"
              "childreninheritxp", "TURRET MOBILEBUILT"
              "parentsinheritxp", "TURRET MOBILEBUILT"
              "workertimeboost", "3.5"
              "wtboostunittype", "TURRET MOBILE"
              "effigy", "comeffigylvl5"
              "minimum_respawn_stun", "5.0"
              "distance_stun_multiplier", "1.0"
              "fall_damage_multiplier", "5.0"
          ]
          extras = Map.ofList [
              "autoheal", "5.0"
              "cancapture", "true"
              "cancloak", "true"
              "canmanualfire", "true"
              "canselfrepair", "true"
              "capturable", "false"
              "capturespeed", "1800.0"
              "cloakcost", "100.0"
              "cloakcostmoving", "1000.0"
              "damagemodifier", "0.1"
              "hidedamage", "true"
              "holdsteady", "true"
              "icontype", "armcom"
              "sightemitheight", "40.0"
              "mass", "4900.0"
              "mincloakdistance", "50.0"
              "nochasecategory", "ALL"
              "radardistance", "1200.0"
              "radaremitheight", "40.0"
              "reclaimable", "false"
              "releaseheld", "true"
              "selfdestructcountdown", "5.0"
              "showplayername", "true"
              "sonardistance", "600.0"
              "upright", "true"
          ] }

    let armcomlvl9ToFlat (def: UnitDef) : Armcomlvl9 =
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
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          workerTime = def.builder.Value.workerTime
          buildDistance = def.builder.Value.buildDistance.Value
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyMake = def.economy.Value.energyMake.Value
          metalMake = def.economy.Value.metalMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armcomlvl9ToUnitDef (flat: Armcomlvl9) : UnitDef =
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
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = Some flat.movementClass
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = Some flat.buildDistance
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = Some flat.weapons
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = Some flat.metalMake
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corcomlvl10 =
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

    let corcomlvl10 : Corcomlvl10 =
        { name = "corcomlvl10"
          subfolder = "other/evocom"
          metalCost = ValueOrExpr.Concrete 11000.0
          energyCost = ValueOrExpr.Concrete 110000.0
          buildTime = ValueOrExpr.Concrete 240000.0
          health = ValueOrExpr.Concrete 20000.0
          sightDistance = ValueOrExpr.Concrete 700.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORCOMHILVL.s3o"
          buildPic = Some "CORCOM.DDS"
          script = Some "Units/CORCOMHILVL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "commanderexplosion"
          selfDestructAs = Some "commanderExplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 47.0
          maxAcc = 0.18
          maxDec = 1.125
          turnRate = 1133.0
          movementClass = "COMMANDERBOT"
          maxSlope = 20.0
          maxWaterDepth = 35.0
          canMove = true
          turnInPlaceAngleLimit = 140.0
          turnInPlaceSpeedLimit = 0.825
          workerTime = ValueOrExpr.Concrete 1800.0
          buildDistance = 217.0
          buildOptions = []
          terraformSpeed = 1500.0
          energyMake = ValueOrExpr.Concrete 2000.0
          metalMake = ValueOrExpr.Concrete 50.0
          energyStorage = 10000.0
          metalStorage = 500.0
          weapons = [
                { name = "corcomlaser"
                  displayName = "Long range AoE flamethrower"
                  weaponType = Some "Flame"
                  damage = Map.ofList [
                      "default", 120.0
                      "subs", 49.0
                  ]
                  range = Some (ValueOrExpr.Concrete 475.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.39996)
                  weaponVelocity = Some 500.0
                  areaOfEffect = Some 128.0
                  accuracy = Some 0.0
                  turret = Some true
                  tolerance = Some 20000.0
                  edgeEffectiveness = Some 0.01
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "Flamhvy1"
                  soundHit = None
                  explosiongenerator = Some "custom:burnblackxl"
                  rgbColor = Some "1 0.94 0.88"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_fastautoretargeting", "true"
                      "allowNonBlockingAim", "true"
                      "avoidfeature", "false"
                      "avoidfriendly", "true"
                      "burst", "12.0"
                      "burstrate", "0.03333"
                      "burnblow", "true"
                      "bouncerebound", "1.0"
                      "cegtag", "demonflame"
                      "colormap", "1 0.95 0.9 0.032   0.55 0.55 0.40 0.028   0.40 0.28 0.19 0.024   0.033 0.018 0.011 0.04   0.0 0.0 0.0 0.01"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "bounceSlip", "1.0"
                      "firestarter", "100.0"
                      "firesubmersed", "false"
                      "flameGFXTime", "1.0"
                      "intensity", "0.85"
                      "noexplode", "false"
                      "predictboost", "1.0"
                      "rgbcolor2", "0.9 0.84 0.8"
                      "sizegrowth", "1.1"
                      "soundhitdry", "flamhit1"
                      "soundhitwet", "sizzle"
                      "soundhitvolume", "9.5"
                      "soundstartvolume", "7.3"
                      "soundtrigger", "false"
                      "waterweapon", "false"
                  ] }
                { name = "corcomsealaser"
                  displayName = "UWSupernovaBeam"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 1400.0
                      "subs", 700.0
                  ]
                  range = Some (ValueOrExpr.Concrete 500.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.4)
                  weaponVelocity = Some 700.0
                  areaOfEffect = Some 70.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "uwlasrfir1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-medium-blue"
                  rgbColor = Some "0.5 0.7 0.10"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTAIR"
                      "avoidfeature", "false"
                      "beamtime", "0.16"
                      "camerashake", "0.0"
                      "corethickness", "0.6"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "90.0"
                      "firesubmersed", "true"
                      "intensity", "0.6"
                      "laserflaresize", "5.5"
                      "rgbcolor2", "1 1 1"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "3.5"
                      "waterweapon", "true"
                  ] }
                { name = "disintegrator"
                  displayName = "Disintegrator"
                  weaponType = Some "DGun"
                  damage = Map.ofList [
                      "commanders", 0.0
                      "default", 99999.0
                      "scavboss", 1000.0
                      "raptorqueen", 1000.0
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
                      "soundhitwet", "sizzlexs"
                      "soundhitvolume", "36.0"
                      "soundstartvolume", "96.0"
                      "soundtrigger", "true"
                      "waterweapon", "true"
                      "weapontimer", "4.2"
                  ] }
                { name = "repulsor"
                  displayName = "PlasmaRepulsor"
                  weaponType = Some "Shield"
                  damage = Map.ofList [
                      "default", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 100.0)
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
                { name = "corcomeyelaser"
                  displayName = "EyeLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 80.0
                  ]
                  range = Some (ValueOrExpr.Concrete 870.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.033)
                  weaponVelocity = Some 1500.0
                  areaOfEffect = Some 72.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "heatray3burn"
                  soundHit = None
                  explosiongenerator = Some "custom:genericshellexplosion-medium-beam"
                  rgbColor = Some "1 0.8 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "commander"
                      "mount_onlytargetcategory", "NOTSUB"
                      "mount_fastautoretargeting", "true"
                      "allowNonBlockingAim", "true"
                      "avoidfeature", "false"
                      "beamtime", "0.033"
                      "camerashake", "0.1"
                      "collidefriendly", "false"
                      "corethickness", "0.35"
                      "craterareaofeffect", "72.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "0.0"
                      "firestarter", "90.0"
                      "firetolerance", "300.0"
                      "laserflaresize", "8.0"
                      "proximitypriority", "1.0"
                      "rgbcolor2", "0.8 0 0"
                      "scrollspeed", "5.0"
                      "soundhitdry", "flamhit1"
                      "soundhitwet", "sizzle"
                      "soundstartvolume", "11.0"
                      "soundtrigger", "1.0"
                      "thickness", "4.5"
                  ] }
                { name = "armcannon"
                  displayName = "HeavyCannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 2000.0
                      "subs", 400.0
                      "vtol", 150.0
                  ]
                  range = Some (ValueOrExpr.Concrete 750.0)
                  reloadTime = Some (ValueOrExpr.Concrete 3.0)
                  weaponVelocity = Some 310.0
                  areaOfEffect = Some 292.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "cannhvy2"
                  soundHit = Some "xplomed4"
                  explosiongenerator = Some "custom:genericshellexplosion-large-aoe"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_fastautoretargeting", "true"
                      "avoidfeature", "false"
                      "craterareaofeffect", "292.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "soundhitwet", "splslrg"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "35 12 54"
                  collisionVolumeType = Some "cylY"
                  damage = Some 44000.0
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
                "unitgroup", "builder"
                "area_mex_def", "cormoho"
                "iscommander", "true"
                "effigy_offset", "1.0"
                "evocomlvl", "10.0"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "paralyzemultiplier", "0.025"
                "subfolder", ""
                "shield_color_mult", "0.8"
                "shield_power", "57000.0"
                "shield_radius", "100.0"
                "maxrange", "500"
                "effigy", "comeffigylvl5"
                "minimum_respawn_stun", "5.0"
                "distance_stun_multiplier", "1.0"
                "fall_damage_multiplier", "5.0"
            ]
          extras = Map.ofList [
                "autoheal", "5.0"
                "onoffable", "true"
                "cancapture", "true"
                "cancloak", "true"
                "canmanualfire", "true"
                "capturable", "false"
                "capturespeed", "1800.0"
                "cloakcost", "100.0"
                "cloakcostmoving", "1000.0"
                "damagemodifier", "0.1"
                "hidedamage", "true"
                "holdsteady", "true"
                "icontype", "corcom"
                "sightemitheight", "40.0"
                "mass", "4900.0"
                "mincloakdistance", "50.0"
                "nochasecategory", "ALL"
                "radardistance", "1500.0"
                "radaremitheight", "40.0"
                "reclaimable", "false"
                "selfdestructcountdown", "5.0"
                "showplayername", "true"
                "sonardistance", "700.0"
                "upright", "true"
            ] }

    let corcomlvl10Def : UnitDef =
        { name = "corcomlvl10"
          subfolder = "other/evocom"
          metalCost = ValueOrExpr.Concrete 11000.0
          energyCost = ValueOrExpr.Concrete 110000.0
          buildTime = ValueOrExpr.Concrete 240000.0
          health = ValueOrExpr.Concrete 20000.0
          sightDistance = ValueOrExpr.Concrete 700.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORCOMHILVL.s3o"
          buildPic = Some "CORCOM.DDS"
          script = Some "Units/CORCOMHILVL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "commanderexplosion"
          selfDestructAs = Some "commanderExplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 47.0
              maxAcc = 0.18
              maxDec = 1.125
              turnRate = 1133.0
              movementClass = Some "COMMANDERBOT"
              maxSlope = Some 20.0
              maxWaterDepth = Some 35.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 140.0
              turnInPlaceSpeedLimit = Some 0.825
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 1800.0
              buildDistance = Some 217.0
              buildOptions = []
              terraformSpeed = Some 1500.0 })
          weapons = Some [
              { name = "corcomlaser"
                displayName = "Long range AoE flamethrower"
                weaponType = Some "Flame"
                damage = Map.ofList [
                    "default", 120.0
                    "subs", 49.0
                ]
                range = Some (ValueOrExpr.Concrete 475.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.39996)
                weaponVelocity = Some 500.0
                areaOfEffect = Some 128.0
                accuracy = Some 0.0
                turret = Some true
                tolerance = Some 20000.0
                edgeEffectiveness = Some 0.01
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "Flamhvy1"
                soundHit = None
                explosiongenerator = Some "custom:burnblackxl"
                rgbColor = Some "1 0.94 0.88"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_fastautoretargeting", "true"
                    "allowNonBlockingAim", "true"
                    "avoidfeature", "false"
                    "avoidfriendly", "true"
                    "burst", "12.0"
                    "burstrate", "0.03333"
                    "burnblow", "true"
                    "bouncerebound", "1.0"
                    "cegtag", "demonflame"
                    "colormap", "1 0.95 0.9 0.032   0.55 0.55 0.40 0.028   0.40 0.28 0.19 0.024   0.033 0.018 0.011 0.04   0.0 0.0 0.0 0.01"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "bounceSlip", "1.0"
                    "firestarter", "100.0"
                    "firesubmersed", "false"
                    "flameGFXTime", "1.0"
                    "intensity", "0.85"
                    "noexplode", "false"
                    "predictboost", "1.0"
                    "rgbcolor2", "0.9 0.84 0.8"
                    "sizegrowth", "1.1"
                    "soundhitdry", "flamhit1"
                    "soundhitwet", "sizzle"
                    "soundhitvolume", "9.5"
                    "soundstartvolume", "7.3"
                    "soundtrigger", "false"
                    "waterweapon", "false"
                ] }
              { name = "corcomsealaser"
                displayName = "UWSupernovaBeam"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 1400.0
                    "subs", 700.0
                ]
                range = Some (ValueOrExpr.Concrete 500.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.4)
                weaponVelocity = Some 700.0
                areaOfEffect = Some 70.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "uwlasrfir1"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-medium-blue"
                rgbColor = Some "0.5 0.7 0.10"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTAIR"
                    "avoidfeature", "false"
                    "beamtime", "0.16"
                    "camerashake", "0.0"
                    "corethickness", "0.6"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "firestarter", "90.0"
                    "firesubmersed", "true"
                    "intensity", "0.6"
                    "laserflaresize", "5.5"
                    "rgbcolor2", "1 1 1"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "3.5"
                    "waterweapon", "true"
                ] }
              { name = "disintegrator"
                displayName = "Disintegrator"
                weaponType = Some "DGun"
                damage = Map.ofList [
                    "commanders", 0.0
                    "default", 99999.0
                    "scavboss", 1000.0
                    "raptorqueen", 1000.0
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
                    "soundhitwet", "sizzlexs"
                    "soundhitvolume", "36.0"
                    "soundstartvolume", "96.0"
                    "soundtrigger", "true"
                    "waterweapon", "true"
                    "weapontimer", "4.2"
                ] }
              { name = "repulsor"
                displayName = "PlasmaRepulsor"
                weaponType = Some "Shield"
                damage = Map.ofList [
                    "default", 100.0
                ]
                range = Some (ValueOrExpr.Concrete 100.0)
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
              { name = "corcomeyelaser"
                displayName = "EyeLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 80.0
                ]
                range = Some (ValueOrExpr.Concrete 870.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.033)
                weaponVelocity = Some 1500.0
                areaOfEffect = Some 72.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "heatray3burn"
                soundHit = None
                explosiongenerator = Some "custom:genericshellexplosion-medium-beam"
                rgbColor = Some "1 0.8 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "commander"
                    "mount_onlytargetcategory", "NOTSUB"
                    "mount_fastautoretargeting", "true"
                    "allowNonBlockingAim", "true"
                    "avoidfeature", "false"
                    "beamtime", "0.033"
                    "camerashake", "0.1"
                    "collidefriendly", "false"
                    "corethickness", "0.35"
                    "craterareaofeffect", "72.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "0.0"
                    "firestarter", "90.0"
                    "firetolerance", "300.0"
                    "laserflaresize", "8.0"
                    "proximitypriority", "1.0"
                    "rgbcolor2", "0.8 0 0"
                    "scrollspeed", "5.0"
                    "soundhitdry", "flamhit1"
                    "soundhitwet", "sizzle"
                    "soundstartvolume", "11.0"
                    "soundtrigger", "1.0"
                    "thickness", "4.5"
                ] }
              { name = "armcannon"
                displayName = "HeavyCannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 2000.0
                    "subs", 400.0
                    "vtol", 150.0
                ]
                range = Some (ValueOrExpr.Concrete 750.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.0)
                weaponVelocity = Some 310.0
                areaOfEffect = Some 292.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "cannhvy2"
                soundHit = Some "xplomed4"
                explosiongenerator = Some "custom:genericshellexplosion-large-aoe"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_fastautoretargeting", "true"
                    "avoidfeature", "false"
                    "craterareaofeffect", "292.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splslrg"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 2000.0)
              metalMake = Some (ValueOrExpr.Concrete 50.0)
              energyStorage = Some 10000.0
              metalStorage = Some 500.0
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "35 12 54"
                collisionVolumeType = Some "cylY"
                damage = Some 44000.0
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
          ])
          sounds = Some (
            { build = Some "nanlath2"
              repair = Some "repair2"
              working = Some "reclaim1"
              underAttack = Some "warning2"
              cancelDestruct = Some "cancel2"
              capture = Some "capture2"
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["corcom1"; "corcom2"; "corcom3"; "corcom4"; "corcom5"]
              select = ["corcomsel"] })
          customParams = Map.ofList [
              "unitgroup", "builder"
              "area_mex_def", "cormoho"
              "iscommander", "true"
              "effigy_offset", "1.0"
              "evocomlvl", "10.0"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "paralyzemultiplier", "0.025"
              "subfolder", ""
              "shield_color_mult", "0.8"
              "shield_power", "57000.0"
              "shield_radius", "100.0"
              "maxrange", "500"
              "effigy", "comeffigylvl5"
              "minimum_respawn_stun", "5.0"
              "distance_stun_multiplier", "1.0"
              "fall_damage_multiplier", "5.0"
          ]
          extras = Map.ofList [
              "autoheal", "5.0"
              "onoffable", "true"
              "cancapture", "true"
              "cancloak", "true"
              "canmanualfire", "true"
              "capturable", "false"
              "capturespeed", "1800.0"
              "cloakcost", "100.0"
              "cloakcostmoving", "1000.0"
              "damagemodifier", "0.1"
              "hidedamage", "true"
              "holdsteady", "true"
              "icontype", "corcom"
              "sightemitheight", "40.0"
              "mass", "4900.0"
              "mincloakdistance", "50.0"
              "nochasecategory", "ALL"
              "radardistance", "1500.0"
              "radaremitheight", "40.0"
              "reclaimable", "false"
              "selfdestructcountdown", "5.0"
              "showplayername", "true"
              "sonardistance", "700.0"
              "upright", "true"
          ] }

    let corcomlvl10ToFlat (def: UnitDef) : Corcomlvl10 =
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
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          workerTime = def.builder.Value.workerTime
          buildDistance = def.builder.Value.buildDistance.Value
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyMake = def.economy.Value.energyMake.Value
          metalMake = def.economy.Value.metalMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corcomlvl10ToUnitDef (flat: Corcomlvl10) : UnitDef =
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
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = Some flat.movementClass
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = Some flat.buildDistance
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = Some flat.weapons
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = Some flat.metalMake
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corcomlvl2 =
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

    let corcomlvl2 : Corcomlvl2 =
        { name = "corcomlvl2"
          subfolder = "other/evocom"
          metalCost = ValueOrExpr.Concrete 3000.0
          energyCost = ValueOrExpr.Concrete 30000.0
          buildTime = ValueOrExpr.Concrete 112500.0
          health = ValueOrExpr.Concrete 6000.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = None
          buildPic = Some "CORCOM.DDS"
          script = Some "Units/CORCOM.cob"
          corpse = Some "DEAD"
          explodeAs = Some "commanderexplosion"
          selfDestructAs = Some "commanderExplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
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
          workerTime = ValueOrExpr.Concrete 366.0
          buildDistance = 153.0
          buildOptions = ["corsolar"; "corwin"; "cormstor"; "corestor"; "cormex"; "cormakr"; "corlab"; "corvp"; "corap"; "coreyes"; "corrad"; "cordrag"; "corllt"; "corrl"; "cordl"; "cortide"; "coruwms"; "coruwes"; "corfmkr"; "corsy"; "corfdrag"; "cortl"; "corfrt"; "corfrad"; "corhp"; "corfhp"]
          terraformSpeed = 1500.0
          energyMake = ValueOrExpr.Concrete 50.0
          metalMake = ValueOrExpr.Concrete 3.0
          energyStorage = 1000.0
          metalStorage = 500.0
          weapons = [
                { name = "corcomlaser"
                  displayName = "HighEnergyLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 215.0
                      "subs", 85.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.5)
                  weaponVelocity = Some 700.0
                  areaOfEffect = Some 16.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "Lasrmas2"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-medium-green"
                  rgbColor = Some "0.027 0.40 0.027"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "mount_fastautoretargeting", "true"
                      "allowNonBlockingAim", "true"
                      "avoidfeature", "false"
                      "beamtime", "0.16"
                      "beamttl", "2.4"
                      "collidefeature", "false"
                      "collidefriendly", "false"
                      "corethickness", "0.21"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "90.0"
                      "impactonly", "1.0"
                      "laserflaresize", "5.5"
                      "rgbcolor2", "0.9 1 0.9"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "4.0"
                  ] }
                { name = "corcomsealaser"
                  displayName = "J7NSLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 200.0
                      "subs", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.5)
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
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTAIR"
                      "avoidfeature", "false"
                      "beamtime", "0.3"
                      "camerashake", "0.0"
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
                  displayName = "Disintegrator"
                  weaponType = Some "DGun"
                  damage = Map.ofList [
                      "commanders", 0.0
                      "default", 99999.0
                      "scavboss", 1000.0
                      "raptorqueen", 1000.0
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
                      "soundhitwet", "sizzlexs"
                      "soundhitvolume", "36.0"
                      "soundstartvolume", "96.0"
                      "soundtrigger", "true"
                      "waterweapon", "true"
                      "weapontimer", "4.2"
                  ] }
                { name = "repulsor"
                  displayName = "PlasmaRepulsor"
                  weaponType = Some "Shield"
                  damage = Map.ofList [
                      "default", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 100.0)
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
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "35 12 54"
                  collisionVolumeType = Some "cylY"
                  damage = Some 12000.0
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
                "unitgroup", "builder"
                "area_mex_def", "cormex"
                "iscommander", "true"
                "effigy_offset", "1.0"
                "evocomlvl", "2.0"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "paralyzemultiplier", "0.025"
                "subfolder", ""
                "evolution_health_transfer", "percentage"
                "evolution_target", "corcomlvl3"
                "evolution_condition", "timer"
                "evolution_timer", "99999.0"
                "evolution_power_threshold", "22000.0"
                "evolution_power_multiplier", "1.0"
                "combatradius", "0.0"
                "shield_color_mult", "0.8"
                "shield_power", "1900.0"
                "shield_radius", "100.0"
                "effigy", "comeffigylvl1"
                "minimum_respawn_stun", "5.0"
                "distance_stun_multiplier", "1.0"
                "fall_damage_multiplier", "5.0"
            ]
          extras = Map.ofList [
                "autoheal", "5.0"
                "onoffable", "true"
                "cancapture", "true"
                "cancloak", "true"
                "canmanualfire", "true"
                "capturable", "false"
                "capturespeed", "1800.0"
                "cloakcost", "100.0"
                "cloakcostmoving", "1000.0"
                "hidedamage", "true"
                "holdsteady", "true"
                "icontype", "corcom"
                "sightemitheight", "40.0"
                "mass", "4900.0"
                "mincloakdistance", "50.0"
                "nochasecategory", "ALL"
                "radardistance", "700.0"
                "radaremitheight", "40.0"
                "reclaimable", "false"
                "selfdestructcountdown", "5.0"
                "showplayername", "true"
                "sonardistance", "450.0"
                "upright", "true"
            ] }

    let corcomlvl2Def : UnitDef =
        { name = "corcomlvl2"
          subfolder = "other/evocom"
          metalCost = ValueOrExpr.Concrete 3000.0
          energyCost = ValueOrExpr.Concrete 30000.0
          buildTime = ValueOrExpr.Concrete 112500.0
          health = ValueOrExpr.Concrete 6000.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = None
          buildPic = Some "CORCOM.DDS"
          script = Some "Units/CORCOM.cob"
          corpse = Some "DEAD"
          explodeAs = Some "commanderexplosion"
          selfDestructAs = Some "commanderExplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 37.5
              maxAcc = 0.18
              maxDec = 1.125
              turnRate = 1133.0
              movementClass = Some "COMMANDERBOT"
              maxSlope = Some 20.0
              maxWaterDepth = Some 35.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 140.0
              turnInPlaceSpeedLimit = Some 0.825
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 366.0
              buildDistance = Some 153.0
              buildOptions = ["corsolar"; "corwin"; "cormstor"; "corestor"; "cormex"; "cormakr"; "corlab"; "corvp"; "corap"; "coreyes"; "corrad"; "cordrag"; "corllt"; "corrl"; "cordl"; "cortide"; "coruwms"; "coruwes"; "corfmkr"; "corsy"; "corfdrag"; "cortl"; "corfrt"; "corfrad"; "corhp"; "corfhp"]
              terraformSpeed = Some 1500.0 })
          weapons = Some [
              { name = "corcomlaser"
                displayName = "HighEnergyLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 215.0
                    "subs", 85.0
                ]
                range = Some (ValueOrExpr.Concrete 300.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.5)
                weaponVelocity = Some 700.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "Lasrmas2"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-medium-green"
                rgbColor = Some "0.027 0.40 0.027"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "mount_fastautoretargeting", "true"
                    "allowNonBlockingAim", "true"
                    "avoidfeature", "false"
                    "beamtime", "0.16"
                    "beamttl", "2.4"
                    "collidefeature", "false"
                    "collidefriendly", "false"
                    "corethickness", "0.21"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "90.0"
                    "impactonly", "1.0"
                    "laserflaresize", "5.5"
                    "rgbcolor2", "0.9 1 0.9"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "4.0"
                ] }
              { name = "corcomsealaser"
                displayName = "J7NSLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 200.0
                    "subs", 100.0
                ]
                range = Some (ValueOrExpr.Concrete 300.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.5)
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
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTAIR"
                    "avoidfeature", "false"
                    "beamtime", "0.3"
                    "camerashake", "0.0"
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
                displayName = "Disintegrator"
                weaponType = Some "DGun"
                damage = Map.ofList [
                    "commanders", 0.0
                    "default", 99999.0
                    "scavboss", 1000.0
                    "raptorqueen", 1000.0
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
                    "soundhitwet", "sizzlexs"
                    "soundhitvolume", "36.0"
                    "soundstartvolume", "96.0"
                    "soundtrigger", "true"
                    "waterweapon", "true"
                    "weapontimer", "4.2"
                ] }
              { name = "repulsor"
                displayName = "PlasmaRepulsor"
                weaponType = Some "Shield"
                damage = Map.ofList [
                    "default", 100.0
                ]
                range = Some (ValueOrExpr.Concrete 100.0)
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
            { energyMake = Some (ValueOrExpr.Concrete 50.0)
              metalMake = Some (ValueOrExpr.Concrete 3.0)
              energyStorage = Some 1000.0
              metalStorage = Some 500.0
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "35 12 54"
                collisionVolumeType = Some "cylY"
                damage = Some 12000.0
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
          ])
          sounds = Some (
            { build = Some "nanlath2"
              repair = Some "repair2"
              working = Some "reclaim1"
              underAttack = Some "warning2"
              cancelDestruct = Some "cancel2"
              capture = Some "capture2"
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["corcom1"; "corcom2"; "corcom3"; "corcom4"; "corcom5"]
              select = ["corcomsel"] })
          customParams = Map.ofList [
              "unitgroup", "builder"
              "area_mex_def", "cormex"
              "iscommander", "true"
              "effigy_offset", "1.0"
              "evocomlvl", "2.0"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "paralyzemultiplier", "0.025"
              "subfolder", ""
              "evolution_health_transfer", "percentage"
              "evolution_target", "corcomlvl3"
              "evolution_condition", "timer"
              "evolution_timer", "99999.0"
              "evolution_power_threshold", "22000.0"
              "evolution_power_multiplier", "1.0"
              "combatradius", "0.0"
              "shield_color_mult", "0.8"
              "shield_power", "1900.0"
              "shield_radius", "100.0"
              "effigy", "comeffigylvl1"
              "minimum_respawn_stun", "5.0"
              "distance_stun_multiplier", "1.0"
              "fall_damage_multiplier", "5.0"
          ]
          extras = Map.ofList [
              "autoheal", "5.0"
              "onoffable", "true"
              "cancapture", "true"
              "cancloak", "true"
              "canmanualfire", "true"
              "capturable", "false"
              "capturespeed", "1800.0"
              "cloakcost", "100.0"
              "cloakcostmoving", "1000.0"
              "hidedamage", "true"
              "holdsteady", "true"
              "icontype", "corcom"
              "sightemitheight", "40.0"
              "mass", "4900.0"
              "mincloakdistance", "50.0"
              "nochasecategory", "ALL"
              "radardistance", "700.0"
              "radaremitheight", "40.0"
              "reclaimable", "false"
              "selfdestructcountdown", "5.0"
              "showplayername", "true"
              "sonardistance", "450.0"
              "upright", "true"
          ] }

    let corcomlvl2ToFlat (def: UnitDef) : Corcomlvl2 =
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
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          workerTime = def.builder.Value.workerTime
          buildDistance = def.builder.Value.buildDistance.Value
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyMake = def.economy.Value.energyMake.Value
          metalMake = def.economy.Value.metalMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corcomlvl2ToUnitDef (flat: Corcomlvl2) : UnitDef =
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
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = Some flat.movementClass
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = Some flat.buildDistance
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = Some flat.weapons
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = Some flat.metalMake
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corcomlvl3 =
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

    let corcomlvl3 : Corcomlvl3 =
        { name = "corcomlvl3"
          subfolder = "other/evocom"
          metalCost = ValueOrExpr.Concrete 4000.0
          energyCost = ValueOrExpr.Concrete 40000.0
          buildTime = ValueOrExpr.Concrete 120000.0
          health = ValueOrExpr.Concrete 6000.0
          sightDistance = ValueOrExpr.Concrete 550.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORCOMHILVL.s3o"
          buildPic = Some "CORCOM.DDS"
          script = Some "Units/CORCOMHILVL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "commanderexplosion"
          selfDestructAs = Some "commanderExplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
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
          workerTime = ValueOrExpr.Concrete 450.0
          buildDistance = 161.0
          buildOptions = ["cormex"; "corsolar"; "corwin"; "coradvsol"; "corgeo"; "cormakr"; "corestor"; "coruwms"; "cortide"; "corexp"; "cormstor"; "coruwes"; "corfmkr"; "coreyes"; "corrad"; "cordrag"; "cormaw"; "corllt"; "corhllt"; "corhlt"; "corpun"; "corfrock"; "cormadsam"; "corerad"; "cordl"; "corjamt"; "corjuno"; "corlab"; "corvp"; "corap"; "cortl"; "corfrt"; "corfrad"; "corsy"; "cornanotc"; "corhp"; "corfdrag"; "cornanotcplat"; "corfhp"]
          terraformSpeed = 1500.0
          energyMake = ValueOrExpr.Concrete 75.0
          metalMake = ValueOrExpr.Concrete 5.0
          energyStorage = 1500.0
          metalStorage = 500.0
          weapons = [
                { name = "corcomlaser"
                  displayName = "HighEnergyLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 380.0
                      "subs", 125.0
                  ]
                  range = Some (ValueOrExpr.Concrete 350.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.4)
                  weaponVelocity = Some 700.0
                  areaOfEffect = Some 16.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "Lasrmas2"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-medium-green"
                  rgbColor = Some "0.027 0.40 0.027"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_fastautoretargeting", "true"
                      "allowNonBlockingAim", "true"
                      "avoidfeature", "false"
                      "beamtime", "0.16"
                      "beamttl", "2.4"
                      "collidefeature", "false"
                      "collidefriendly", "false"
                      "corethickness", "0.21"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "90.0"
                      "impactonly", "1.0"
                      "laserflaresize", "5.5"
                      "rgbcolor2", "0.9 1 0.9"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "4.0"
                  ] }
                { name = "corcomsealaser"
                  displayName = "J7NSLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 300.0
                      "subs", 150.0
                  ]
                  range = Some (ValueOrExpr.Concrete 450.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.46)
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
                  rgbColor = Some "0.2 0.8 0.3"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTAIR"
                      "avoidfeature", "false"
                      "beamtime", "0.16"
                      "beamttl", "2.4"
                      "camerashake", "0.0"
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
                  displayName = "Disintegrator"
                  weaponType = Some "DGun"
                  damage = Map.ofList [
                      "commanders", 0.0
                      "default", 99999.0
                      "scavboss", 1000.0
                      "raptorqueen", 1000.0
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
                      "soundhitwet", "sizzlexs"
                      "soundhitvolume", "36.0"
                      "soundstartvolume", "96.0"
                      "soundtrigger", "true"
                      "waterweapon", "true"
                      "weapontimer", "4.2"
                  ] }
                { name = "repulsor"
                  displayName = "PlasmaRepulsor"
                  weaponType = Some "Shield"
                  damage = Map.ofList [
                      "default", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 100.0)
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
                { name = "corcomeyelaser"
                  displayName = "Eye laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 75.0
                      "subs", 18.0
                  ]
                  range = Some (ValueOrExpr.Concrete 435.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.46667)
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
                      "mount_onlytargetcategory", "NOTSUB"
                      "mount_fastautoretargeting", "true"
                      "avoidfeature", "false"
                      "beamtime", "0.12"
                      "corethickness", "0.175"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "0.0"
                      "firestarter", "100.0"
                      "impactonly", "1.0"
                      "laserflaresize", "20.0"
                      "proximitypriority", "1.0"
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
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "35 12 54"
                  collisionVolumeType = Some "cylY"
                  damage = Some 16000.0
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
                "unitgroup", "builder"
                "area_mex_def", "cormex"
                "iscommander", "true"
                "effigy_offset", "1.0"
                "evocomlvl", "3.0"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "paralyzemultiplier", "0.025"
                "subfolder", ""
                "evolution_health_transfer", "percentage"
                "evolution_target", "corcomlvl4"
                "evolution_condition", "timer"
                "evolution_timer", "99999.0"
                "evolution_power_threshold", "53000.0"
                "evolution_power_multiplier", "1.0"
                "combatradius", "0.0"
                "shield_color_mult", "0.8"
                "shield_power", "6270.0"
                "shield_radius", "100.0"
                "effigy", "comeffigylvl2"
                "minimum_respawn_stun", "5.0"
                "distance_stun_multiplier", "1.0"
                "fall_damage_multiplier", "5.0"
            ]
          extras = Map.ofList [
                "autoheal", "5.0"
                "onoffable", "true"
                "cancapture", "true"
                "cancloak", "true"
                "canmanualfire", "true"
                "capturable", "false"
                "capturespeed", "1800.0"
                "cloakcost", "100.0"
                "cloakcostmoving", "1000.0"
                "damagemodifier", "0.1"
                "hidedamage", "true"
                "holdsteady", "true"
                "icontype", "corcom"
                "sightemitheight", "40.0"
                "mass", "4900.0"
                "mincloakdistance", "50.0"
                "nochasecategory", "ALL"
                "radardistance", "700.0"
                "radaremitheight", "40.0"
                "reclaimable", "false"
                "selfdestructcountdown", "5.0"
                "showplayername", "true"
                "sonardistance", "550.0"
                "upright", "true"
            ] }

    let corcomlvl3Def : UnitDef =
        { name = "corcomlvl3"
          subfolder = "other/evocom"
          metalCost = ValueOrExpr.Concrete 4000.0
          energyCost = ValueOrExpr.Concrete 40000.0
          buildTime = ValueOrExpr.Concrete 120000.0
          health = ValueOrExpr.Concrete 6000.0
          sightDistance = ValueOrExpr.Concrete 550.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORCOMHILVL.s3o"
          buildPic = Some "CORCOM.DDS"
          script = Some "Units/CORCOMHILVL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "commanderexplosion"
          selfDestructAs = Some "commanderExplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 37.5
              maxAcc = 0.18
              maxDec = 1.125
              turnRate = 1133.0
              movementClass = Some "COMMANDERBOT"
              maxSlope = Some 20.0
              maxWaterDepth = Some 35.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 140.0
              turnInPlaceSpeedLimit = Some 0.825
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 450.0
              buildDistance = Some 161.0
              buildOptions = ["cormex"; "corsolar"; "corwin"; "coradvsol"; "corgeo"; "cormakr"; "corestor"; "coruwms"; "cortide"; "corexp"; "cormstor"; "coruwes"; "corfmkr"; "coreyes"; "corrad"; "cordrag"; "cormaw"; "corllt"; "corhllt"; "corhlt"; "corpun"; "corfrock"; "cormadsam"; "corerad"; "cordl"; "corjamt"; "corjuno"; "corlab"; "corvp"; "corap"; "cortl"; "corfrt"; "corfrad"; "corsy"; "cornanotc"; "corhp"; "corfdrag"; "cornanotcplat"; "corfhp"]
              terraformSpeed = Some 1500.0 })
          weapons = Some [
              { name = "corcomlaser"
                displayName = "HighEnergyLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 380.0
                    "subs", 125.0
                ]
                range = Some (ValueOrExpr.Concrete 350.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.4)
                weaponVelocity = Some 700.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "Lasrmas2"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-medium-green"
                rgbColor = Some "0.027 0.40 0.027"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_fastautoretargeting", "true"
                    "allowNonBlockingAim", "true"
                    "avoidfeature", "false"
                    "beamtime", "0.16"
                    "beamttl", "2.4"
                    "collidefeature", "false"
                    "collidefriendly", "false"
                    "corethickness", "0.21"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "90.0"
                    "impactonly", "1.0"
                    "laserflaresize", "5.5"
                    "rgbcolor2", "0.9 1 0.9"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "4.0"
                ] }
              { name = "corcomsealaser"
                displayName = "J7NSLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 300.0
                    "subs", 150.0
                ]
                range = Some (ValueOrExpr.Concrete 450.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.46)
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
                rgbColor = Some "0.2 0.8 0.3"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTAIR"
                    "avoidfeature", "false"
                    "beamtime", "0.16"
                    "beamttl", "2.4"
                    "camerashake", "0.0"
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
                displayName = "Disintegrator"
                weaponType = Some "DGun"
                damage = Map.ofList [
                    "commanders", 0.0
                    "default", 99999.0
                    "scavboss", 1000.0
                    "raptorqueen", 1000.0
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
                    "soundhitwet", "sizzlexs"
                    "soundhitvolume", "36.0"
                    "soundstartvolume", "96.0"
                    "soundtrigger", "true"
                    "waterweapon", "true"
                    "weapontimer", "4.2"
                ] }
              { name = "repulsor"
                displayName = "PlasmaRepulsor"
                weaponType = Some "Shield"
                damage = Map.ofList [
                    "default", 100.0
                ]
                range = Some (ValueOrExpr.Concrete 100.0)
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
              { name = "corcomeyelaser"
                displayName = "Eye laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 75.0
                    "subs", 18.0
                ]
                range = Some (ValueOrExpr.Concrete 435.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.46667)
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
                    "mount_onlytargetcategory", "NOTSUB"
                    "mount_fastautoretargeting", "true"
                    "avoidfeature", "false"
                    "beamtime", "0.12"
                    "corethickness", "0.175"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "0.0"
                    "firestarter", "100.0"
                    "impactonly", "1.0"
                    "laserflaresize", "20.0"
                    "proximitypriority", "1.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.0"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 75.0)
              metalMake = Some (ValueOrExpr.Concrete 5.0)
              energyStorage = Some 1500.0
              metalStorage = Some 500.0
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "35 12 54"
                collisionVolumeType = Some "cylY"
                damage = Some 16000.0
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
          ])
          sounds = Some (
            { build = Some "nanlath2"
              repair = Some "repair2"
              working = Some "reclaim1"
              underAttack = Some "warning2"
              cancelDestruct = Some "cancel2"
              capture = Some "capture2"
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["corcom1"; "corcom2"; "corcom3"; "corcom4"; "corcom5"]
              select = ["corcomsel"] })
          customParams = Map.ofList [
              "unitgroup", "builder"
              "area_mex_def", "cormex"
              "iscommander", "true"
              "effigy_offset", "1.0"
              "evocomlvl", "3.0"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "paralyzemultiplier", "0.025"
              "subfolder", ""
              "evolution_health_transfer", "percentage"
              "evolution_target", "corcomlvl4"
              "evolution_condition", "timer"
              "evolution_timer", "99999.0"
              "evolution_power_threshold", "53000.0"
              "evolution_power_multiplier", "1.0"
              "combatradius", "0.0"
              "shield_color_mult", "0.8"
              "shield_power", "6270.0"
              "shield_radius", "100.0"
              "effigy", "comeffigylvl2"
              "minimum_respawn_stun", "5.0"
              "distance_stun_multiplier", "1.0"
              "fall_damage_multiplier", "5.0"
          ]
          extras = Map.ofList [
              "autoheal", "5.0"
              "onoffable", "true"
              "cancapture", "true"
              "cancloak", "true"
              "canmanualfire", "true"
              "capturable", "false"
              "capturespeed", "1800.0"
              "cloakcost", "100.0"
              "cloakcostmoving", "1000.0"
              "damagemodifier", "0.1"
              "hidedamage", "true"
              "holdsteady", "true"
              "icontype", "corcom"
              "sightemitheight", "40.0"
              "mass", "4900.0"
              "mincloakdistance", "50.0"
              "nochasecategory", "ALL"
              "radardistance", "700.0"
              "radaremitheight", "40.0"
              "reclaimable", "false"
              "selfdestructcountdown", "5.0"
              "showplayername", "true"
              "sonardistance", "550.0"
              "upright", "true"
          ] }

    let corcomlvl3ToFlat (def: UnitDef) : Corcomlvl3 =
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
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          workerTime = def.builder.Value.workerTime
          buildDistance = def.builder.Value.buildDistance.Value
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyMake = def.economy.Value.energyMake.Value
          metalMake = def.economy.Value.metalMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corcomlvl3ToUnitDef (flat: Corcomlvl3) : UnitDef =
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
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = Some flat.movementClass
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = Some flat.buildDistance
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = Some flat.weapons
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = Some flat.metalMake
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corcomlvl4 =
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

    let corcomlvl4 : Corcomlvl4 =
        { name = "corcomlvl4"
          subfolder = "other/evocom"
          metalCost = ValueOrExpr.Concrete 5000.0
          energyCost = ValueOrExpr.Concrete 50000.0
          buildTime = ValueOrExpr.Concrete 140000.0
          health = ValueOrExpr.Concrete 8000.0
          sightDistance = ValueOrExpr.Concrete 550.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORCOMHILVL.s3o"
          buildPic = Some "CORCOM.DDS"
          script = Some "Units/CORCOMHILVL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "commanderexplosion"
          selfDestructAs = Some "commanderExplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
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
          workerTime = ValueOrExpr.Concrete 545.0
          buildDistance = 169.0
          buildOptions = ["cormex"; "corsolar"; "corwin"; "coradvsol"; "corgeo"; "cormakr"; "corestor"; "coruwms"; "cortide"; "corexp"; "cormstor"; "coruwes"; "corfmkr"; "coreyes"; "corrad"; "cordrag"; "cormaw"; "corllt"; "corhllt"; "corhlt"; "corpun"; "corfrock"; "cormadsam"; "corerad"; "cordl"; "corjamt"; "corjuno"; "corlab"; "corvp"; "corap"; "cortl"; "corfrt"; "corfrad"; "corsy"; "cornanotc"; "corhp"; "corfdrag"; "cornanotcplat"; "corfhp"]
          terraformSpeed = 1500.0
          energyMake = ValueOrExpr.Concrete 125.0
          metalMake = ValueOrExpr.Concrete 9.0
          energyStorage = 2000.0
          metalStorage = 500.0
          weapons = [
                { name = "corcomlaser"
                  displayName = "HighEnergyLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 550.0
                      "subs", 275.0
                  ]
                  range = Some (ValueOrExpr.Concrete 350.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.33)
                  weaponVelocity = Some 700.0
                  areaOfEffect = Some 16.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "Lasrmas2"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-medium-green"
                  rgbColor = Some "0.027 0.40 0.027"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_fastautoretargeting", "true"
                      "allowNonBlockingAim", "true"
                      "avoidfeature", "false"
                      "beamtime", "0.16"
                      "collidefeature", "false"
                      "collidefriendly", "false"
                      "corethickness", "0.21"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "90.0"
                      "impactonly", "1.0"
                      "laserflaresize", "5.5"
                      "rgbcolor2", "0.9 1 0.9"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "4.0"
                  ] }
                { name = "corcomsealaser"
                  displayName = "J7NSLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 400.0
                      "subs", 200.0
                  ]
                  range = Some (ValueOrExpr.Concrete 450.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.42)
                  weaponVelocity = Some 900.0
                  areaOfEffect = Some 16.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "uwlasrfir1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small-blue"
                  rgbColor = Some "0.2 0.8 0.3"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTAIR"
                      "avoidfeature", "false"
                      "beamtime", "0.16"
                      "beamttl", "2.4"
                      "camerashake", "0.0"
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
                  displayName = "Disintegrator"
                  weaponType = Some "DGun"
                  damage = Map.ofList [
                      "commanders", 0.0
                      "default", 99999.0
                      "scavboss", 1000.0
                      "raptorqueen", 1000.0
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
                      "soundhitwet", "sizzlexs"
                      "soundhitvolume", "36.0"
                      "soundstartvolume", "96.0"
                      "soundtrigger", "true"
                      "waterweapon", "true"
                      "weapontimer", "4.2"
                  ] }
                { name = "repulsor"
                  displayName = "PlasmaRepulsor"
                  weaponType = Some "Shield"
                  damage = Map.ofList [
                      "default", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 100.0)
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
                { name = "corcomeyelaser"
                  displayName = "Eye laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 85.0
                      "subs", 22.0
                  ]
                  range = Some (ValueOrExpr.Concrete 550.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.306)
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
                      "mount_onlytargetcategory", "NOTSUB"
                      "mount_fastautoretargeting", "true"
                      "avoidfeature", "false"
                      "beamtime", "0.12"
                      "corethickness", "0.175"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "0.0"
                      "firestarter", "100.0"
                      "impactonly", "1.0"
                      "laserflaresize", "20.0"
                      "proximitypriority", "1.0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "2.0"
                  ] }
                { name = "armcannon"
                  displayName = "HeavyCannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 450.0
                      "subs", 225.0
                      "vtol", 45.0
                  ]
                  range = Some (ValueOrExpr.Concrete 500.0)
                  reloadTime = Some (ValueOrExpr.Concrete 3.0)
                  weaponVelocity = Some 310.0
                  areaOfEffect = Some 144.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "corlevlr"
                  soundHit = Some "corlevlrhit"
                  explosiongenerator = Some "custom:genericshellexplosion-medium"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_fastautoretargeting", "true"
                      "avoidfeature", "false"
                      "craterareaofeffect", "292.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "soundhitwet", "splslrg"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "35 12 54"
                  collisionVolumeType = Some "cylY"
                  damage = Some 20000.0
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
                "unitgroup", "builder"
                "area_mex_def", "cormex"
                "iscommander", "true"
                "effigy_offset", "1.0"
                "evocomlvl", "4.0"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "paralyzemultiplier", "0.025"
                "subfolder", ""
                "shield_color_mult", "0.8"
                "shield_power", "10450.0"
                "shield_radius", "100.0"
                "evolution_health_transfer", "percentage"
                "evolution_target", "corcomlvl5"
                "evolution_condition", "timer"
                "evolution_timer", "99999.0"
                "evolution_power_threshold", "105000.0"
                "evolution_power_multiplier", "1.0"
                "combatradius", "0.0"
                "effigy", "comeffigylvl2"
                "minimum_respawn_stun", "5.0"
                "distance_stun_multiplier", "1.0"
                "fall_damage_multiplier", "5.0"
            ]
          extras = Map.ofList [
                "autoheal", "5.0"
                "onoffable", "true"
                "cancapture", "true"
                "cancloak", "true"
                "canmanualfire", "true"
                "capturable", "false"
                "capturespeed", "1800.0"
                "cloakcost", "100.0"
                "cloakcostmoving", "1000.0"
                "damagemodifier", "0.1"
                "hidedamage", "true"
                "holdsteady", "true"
                "icontype", "corcom"
                "sightemitheight", "40.0"
                "mass", "4900.0"
                "mincloakdistance", "50.0"
                "nochasecategory", "ALL"
                "radardistance", "700.0"
                "radaremitheight", "40.0"
                "reclaimable", "false"
                "selfdestructcountdown", "5.0"
                "showplayername", "true"
                "sonardistance", "550.0"
                "upright", "true"
            ] }

    let corcomlvl4Def : UnitDef =
        { name = "corcomlvl4"
          subfolder = "other/evocom"
          metalCost = ValueOrExpr.Concrete 5000.0
          energyCost = ValueOrExpr.Concrete 50000.0
          buildTime = ValueOrExpr.Concrete 140000.0
          health = ValueOrExpr.Concrete 8000.0
          sightDistance = ValueOrExpr.Concrete 550.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORCOMHILVL.s3o"
          buildPic = Some "CORCOM.DDS"
          script = Some "Units/CORCOMHILVL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "commanderexplosion"
          selfDestructAs = Some "commanderExplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 37.5
              maxAcc = 0.18
              maxDec = 1.125
              turnRate = 1133.0
              movementClass = Some "COMMANDERBOT"
              maxSlope = Some 20.0
              maxWaterDepth = Some 35.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 140.0
              turnInPlaceSpeedLimit = Some 0.825
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 545.0
              buildDistance = Some 169.0
              buildOptions = ["cormex"; "corsolar"; "corwin"; "coradvsol"; "corgeo"; "cormakr"; "corestor"; "coruwms"; "cortide"; "corexp"; "cormstor"; "coruwes"; "corfmkr"; "coreyes"; "corrad"; "cordrag"; "cormaw"; "corllt"; "corhllt"; "corhlt"; "corpun"; "corfrock"; "cormadsam"; "corerad"; "cordl"; "corjamt"; "corjuno"; "corlab"; "corvp"; "corap"; "cortl"; "corfrt"; "corfrad"; "corsy"; "cornanotc"; "corhp"; "corfdrag"; "cornanotcplat"; "corfhp"]
              terraformSpeed = Some 1500.0 })
          weapons = Some [
              { name = "corcomlaser"
                displayName = "HighEnergyLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 550.0
                    "subs", 275.0
                ]
                range = Some (ValueOrExpr.Concrete 350.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.33)
                weaponVelocity = Some 700.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "Lasrmas2"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-medium-green"
                rgbColor = Some "0.027 0.40 0.027"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_fastautoretargeting", "true"
                    "allowNonBlockingAim", "true"
                    "avoidfeature", "false"
                    "beamtime", "0.16"
                    "collidefeature", "false"
                    "collidefriendly", "false"
                    "corethickness", "0.21"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "90.0"
                    "impactonly", "1.0"
                    "laserflaresize", "5.5"
                    "rgbcolor2", "0.9 1 0.9"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "4.0"
                ] }
              { name = "corcomsealaser"
                displayName = "J7NSLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 400.0
                    "subs", 200.0
                ]
                range = Some (ValueOrExpr.Concrete 450.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.42)
                weaponVelocity = Some 900.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 1.0
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "uwlasrfir1"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-small-blue"
                rgbColor = Some "0.2 0.8 0.3"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTAIR"
                    "avoidfeature", "false"
                    "beamtime", "0.16"
                    "beamttl", "2.4"
                    "camerashake", "0.0"
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
                displayName = "Disintegrator"
                weaponType = Some "DGun"
                damage = Map.ofList [
                    "commanders", 0.0
                    "default", 99999.0
                    "scavboss", 1000.0
                    "raptorqueen", 1000.0
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
                    "soundhitwet", "sizzlexs"
                    "soundhitvolume", "36.0"
                    "soundstartvolume", "96.0"
                    "soundtrigger", "true"
                    "waterweapon", "true"
                    "weapontimer", "4.2"
                ] }
              { name = "repulsor"
                displayName = "PlasmaRepulsor"
                weaponType = Some "Shield"
                damage = Map.ofList [
                    "default", 100.0
                ]
                range = Some (ValueOrExpr.Concrete 100.0)
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
              { name = "corcomeyelaser"
                displayName = "Eye laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 85.0
                    "subs", 22.0
                ]
                range = Some (ValueOrExpr.Concrete 550.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.306)
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
                    "mount_onlytargetcategory", "NOTSUB"
                    "mount_fastautoretargeting", "true"
                    "avoidfeature", "false"
                    "beamtime", "0.12"
                    "corethickness", "0.175"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "0.0"
                    "firestarter", "100.0"
                    "impactonly", "1.0"
                    "laserflaresize", "20.0"
                    "proximitypriority", "1.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.0"
                ] }
              { name = "armcannon"
                displayName = "HeavyCannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 450.0
                    "subs", 225.0
                    "vtol", 45.0
                ]
                range = Some (ValueOrExpr.Concrete 500.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.0)
                weaponVelocity = Some 310.0
                areaOfEffect = Some 144.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "corlevlr"
                soundHit = Some "corlevlrhit"
                explosiongenerator = Some "custom:genericshellexplosion-medium"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_fastautoretargeting", "true"
                    "avoidfeature", "false"
                    "craterareaofeffect", "292.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splslrg"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 125.0)
              metalMake = Some (ValueOrExpr.Concrete 9.0)
              energyStorage = Some 2000.0
              metalStorage = Some 500.0
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "35 12 54"
                collisionVolumeType = Some "cylY"
                damage = Some 20000.0
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
          ])
          sounds = Some (
            { build = Some "nanlath2"
              repair = Some "repair2"
              working = Some "reclaim1"
              underAttack = Some "warning2"
              cancelDestruct = Some "cancel2"
              capture = Some "capture2"
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["corcom1"; "corcom2"; "corcom3"; "corcom4"; "corcom5"]
              select = ["corcomsel"] })
          customParams = Map.ofList [
              "unitgroup", "builder"
              "area_mex_def", "cormex"
              "iscommander", "true"
              "effigy_offset", "1.0"
              "evocomlvl", "4.0"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "paralyzemultiplier", "0.025"
              "subfolder", ""
              "shield_color_mult", "0.8"
              "shield_power", "10450.0"
              "shield_radius", "100.0"
              "evolution_health_transfer", "percentage"
              "evolution_target", "corcomlvl5"
              "evolution_condition", "timer"
              "evolution_timer", "99999.0"
              "evolution_power_threshold", "105000.0"
              "evolution_power_multiplier", "1.0"
              "combatradius", "0.0"
              "effigy", "comeffigylvl2"
              "minimum_respawn_stun", "5.0"
              "distance_stun_multiplier", "1.0"
              "fall_damage_multiplier", "5.0"
          ]
          extras = Map.ofList [
              "autoheal", "5.0"
              "onoffable", "true"
              "cancapture", "true"
              "cancloak", "true"
              "canmanualfire", "true"
              "capturable", "false"
              "capturespeed", "1800.0"
              "cloakcost", "100.0"
              "cloakcostmoving", "1000.0"
              "damagemodifier", "0.1"
              "hidedamage", "true"
              "holdsteady", "true"
              "icontype", "corcom"
              "sightemitheight", "40.0"
              "mass", "4900.0"
              "mincloakdistance", "50.0"
              "nochasecategory", "ALL"
              "radardistance", "700.0"
              "radaremitheight", "40.0"
              "reclaimable", "false"
              "selfdestructcountdown", "5.0"
              "showplayername", "true"
              "sonardistance", "550.0"
              "upright", "true"
          ] }

    let corcomlvl4ToFlat (def: UnitDef) : Corcomlvl4 =
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
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          workerTime = def.builder.Value.workerTime
          buildDistance = def.builder.Value.buildDistance.Value
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyMake = def.economy.Value.energyMake.Value
          metalMake = def.economy.Value.metalMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corcomlvl4ToUnitDef (flat: Corcomlvl4) : UnitDef =
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
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = Some flat.movementClass
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = Some flat.buildDistance
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = Some flat.weapons
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = Some flat.metalMake
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corcomlvl5 =
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

    let corcomlvl5 : Corcomlvl5 =
        { name = "corcomlvl5"
          subfolder = "other/evocom"
          metalCost = ValueOrExpr.Concrete 6000.0
          energyCost = ValueOrExpr.Concrete 60000.0
          buildTime = ValueOrExpr.Concrete 154800.0
          health = ValueOrExpr.Concrete 10000.0
          sightDistance = ValueOrExpr.Concrete 550.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORCOMHILVL.s3o"
          buildPic = Some "CORCOM.DDS"
          script = Some "Units/CORCOMHILVL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "commanderexplosion"
          selfDestructAs = Some "commanderExplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 39.0
          maxAcc = 0.18
          maxDec = 1.125
          turnRate = 1133.0
          movementClass = "COMMANDERBOT"
          maxSlope = 20.0
          maxWaterDepth = 35.0
          canMove = true
          turnInPlaceAngleLimit = 140.0
          turnInPlaceSpeedLimit = 0.825
          workerTime = ValueOrExpr.Concrete 665.0
          buildDistance = 177.0
          buildOptions = []
          terraformSpeed = 1500.0
          energyMake = ValueOrExpr.Concrete 200.0
          metalMake = ValueOrExpr.Concrete 14.0
          energyStorage = 2500.0
          metalStorage = 500.0
          weapons = [
                { name = "corcomlaser"
                  displayName = "Anti-swarm AoE flamethrower"
                  weaponType = Some "Flame"
                  damage = Map.ofList [
                      "default", 90.0
                      "subs", 25.0
                  ]
                  range = Some (ValueOrExpr.Concrete 400.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.1)
                  weaponVelocity = Some 500.0
                  areaOfEffect = Some 80.0
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
                      "mount_fastautoretargeting", "true"
                      "avoidfeature", "false"
                      "burst", "16.0"
                      "burstrate", "0.05"
                      "cegtag", "burnflame-anim"
                      "colormap", "1 0.95 0.82 0.03   0.65 0.4 0.35 0.030   0.44 0.25 0.20 0.028   0.033 0.018 0.012 0.03   0.0 0.0 0.0 0.01"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "100.0"
                      "flamegfxtime", "1.0"
                      "intensity", "0.68"
                      "rgbcolor2", "0.9 0.84 0.8"
                      "sizegrowth", "0.5"
                      "soundhitdry", "flamhit1"
                      "soundhitwet", "sizzle"
                      "soundhitvolume", "7.5"
                      "soundstartvolume", "5.3"
                      "soundtrigger", "false"
                      "sprayangle", "100.0"
                      "targetmoveerror", "0.001"
                      "texture1", "flame"
                      "weapontimer", "1.0"
                  ] }
                { name = "corcomsealaser"
                  displayName = "UltravioletRayBeam"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 1200.0
                      "subs", 600.0
                  ]
                  range = Some (ValueOrExpr.Concrete 475.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.92)
                  weaponVelocity = Some 700.0
                  areaOfEffect = Some 42.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "uwlasrfir1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-medium-blue"
                  rgbColor = Some "0.6 0.2 0.6"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTAIR"
                      "avoidfeature", "false"
                      "beamtime", "0.16"
                      "camerashake", "0.0"
                      "corethickness", "0.2"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "90.0"
                      "firesubmersed", "true"
                      "intensity", "0.6"
                      "laserflaresize", "5.5"
                      "rgbcolor2", "0.2 0.2 0.2"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "3.5"
                      "waterweapon", "true"
                  ] }
                { name = "disintegrator"
                  displayName = "Disintegrator"
                  weaponType = Some "DGun"
                  damage = Map.ofList [
                      "commanders", 0.0
                      "default", 99999.0
                      "scavboss", 1000.0
                      "raptorqueen", 1000.0
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
                      "soundhitwet", "sizzlexs"
                      "soundhitvolume", "36.0"
                      "soundstartvolume", "96.0"
                      "soundtrigger", "true"
                      "waterweapon", "true"
                      "weapontimer", "4.2"
                  ] }
                { name = "repulsor"
                  displayName = "PlasmaRepulsor"
                  weaponType = Some "Shield"
                  damage = Map.ofList [
                      "default", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 100.0)
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
                { name = "corcomeyelaser"
                  displayName = "Eye laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 120.0
                      "subs", 30.0
                  ]
                  range = Some (ValueOrExpr.Concrete 620.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.19)
                  weaponVelocity = Some 2250.0
                  areaOfEffect = Some 16.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "beamershot2"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small-red"
                  rgbColor = Some "1 0 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "commander"
                      "mount_onlytargetcategory", "NOTSUB"
                      "mount_fastautoretargeting", "true"
                      "avoidfeature", "false"
                      "beamtime", "0.2"
                      "corethickness", "0.175"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "0.0"
                      "firestarter", "100.0"
                      "impactonly", "1.0"
                      "laserflaresize", "20.0"
                      "proximitypriority", "1.0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "2.0"
                  ] }
                { name = "armcannon"
                  displayName = "HeavyCannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 450.0
                      "subs", 150.0
                      "vtol", 30.0
                  ]
                  range = Some (ValueOrExpr.Concrete 600.0)
                  reloadTime = Some (ValueOrExpr.Concrete 3.0)
                  weaponVelocity = Some 310.0
                  areaOfEffect = Some 144.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "corlevlr"
                  soundHit = Some "corlevlrhit"
                  explosiongenerator = Some "custom:genericshellexplosion-medium"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_fastautoretargeting", "true"
                      "avoidfeature", "false"
                      "craterareaofeffect", "292.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "soundhitwet", "splslrg"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "35 12 54"
                  collisionVolumeType = Some "cylY"
                  damage = Some 24000.0
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
                "unitgroup", "builder"
                "area_mex_def", "cormex"
                "iscommander", "true"
                "effigy_offset", "1.0"
                "evocomlvl", "5.0"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "paralyzemultiplier", "0.025"
                "subfolder", ""
                "shield_color_mult", "0.8"
                "shield_power", "13300.0"
                "shield_radius", "100.0"
                "evolution_health_transfer", "percentage"
                "evolution_target", "corcomlvl6"
                "evolution_condition", "timer"
                "evolution_timer", "99999.0"
                "evolution_power_threshold", "260000.0"
                "evolution_power_multiplier", "1.0"
                "combatradius", "0.0"
                "effigy", "comeffigylvl3"
                "minimum_respawn_stun", "5.0"
                "distance_stun_multiplier", "1.0"
                "fall_damage_multiplier", "5.0"
            ]
          extras = Map.ofList [
                "autoheal", "5.0"
                "onoffable", "true"
                "cancapture", "true"
                "cancloak", "true"
                "canmanualfire", "true"
                "capturable", "false"
                "capturespeed", "1800.0"
                "cloakcost", "100.0"
                "cloakcostmoving", "1000.0"
                "damagemodifier", "0.1"
                "hidedamage", "true"
                "holdsteady", "true"
                "icontype", "corcom"
                "sightemitheight", "40.0"
                "mass", "4900.0"
                "mincloakdistance", "50.0"
                "nochasecategory", "ALL"
                "radardistance", "1000.0"
                "radaremitheight", "40.0"
                "reclaimable", "false"
                "selfdestructcountdown", "5.0"
                "showplayername", "true"
                "sonardistance", "550.0"
                "upright", "true"
            ] }

    let corcomlvl5Def : UnitDef =
        { name = "corcomlvl5"
          subfolder = "other/evocom"
          metalCost = ValueOrExpr.Concrete 6000.0
          energyCost = ValueOrExpr.Concrete 60000.0
          buildTime = ValueOrExpr.Concrete 154800.0
          health = ValueOrExpr.Concrete 10000.0
          sightDistance = ValueOrExpr.Concrete 550.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORCOMHILVL.s3o"
          buildPic = Some "CORCOM.DDS"
          script = Some "Units/CORCOMHILVL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "commanderexplosion"
          selfDestructAs = Some "commanderExplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 39.0
              maxAcc = 0.18
              maxDec = 1.125
              turnRate = 1133.0
              movementClass = Some "COMMANDERBOT"
              maxSlope = Some 20.0
              maxWaterDepth = Some 35.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 140.0
              turnInPlaceSpeedLimit = Some 0.825
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 665.0
              buildDistance = Some 177.0
              buildOptions = []
              terraformSpeed = Some 1500.0 })
          weapons = Some [
              { name = "corcomlaser"
                displayName = "Anti-swarm AoE flamethrower"
                weaponType = Some "Flame"
                damage = Map.ofList [
                    "default", 90.0
                    "subs", 25.0
                ]
                range = Some (ValueOrExpr.Concrete 400.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.1)
                weaponVelocity = Some 500.0
                areaOfEffect = Some 80.0
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
                    "mount_fastautoretargeting", "true"
                    "avoidfeature", "false"
                    "burst", "16.0"
                    "burstrate", "0.05"
                    "cegtag", "burnflame-anim"
                    "colormap", "1 0.95 0.82 0.03   0.65 0.4 0.35 0.030   0.44 0.25 0.20 0.028   0.033 0.018 0.012 0.03   0.0 0.0 0.0 0.01"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "100.0"
                    "flamegfxtime", "1.0"
                    "intensity", "0.68"
                    "rgbcolor2", "0.9 0.84 0.8"
                    "sizegrowth", "0.5"
                    "soundhitdry", "flamhit1"
                    "soundhitwet", "sizzle"
                    "soundhitvolume", "7.5"
                    "soundstartvolume", "5.3"
                    "soundtrigger", "false"
                    "sprayangle", "100.0"
                    "targetmoveerror", "0.001"
                    "texture1", "flame"
                    "weapontimer", "1.0"
                ] }
              { name = "corcomsealaser"
                displayName = "UltravioletRayBeam"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 1200.0
                    "subs", 600.0
                ]
                range = Some (ValueOrExpr.Concrete 475.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.92)
                weaponVelocity = Some 700.0
                areaOfEffect = Some 42.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "uwlasrfir1"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-medium-blue"
                rgbColor = Some "0.6 0.2 0.6"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTAIR"
                    "avoidfeature", "false"
                    "beamtime", "0.16"
                    "camerashake", "0.0"
                    "corethickness", "0.2"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "firestarter", "90.0"
                    "firesubmersed", "true"
                    "intensity", "0.6"
                    "laserflaresize", "5.5"
                    "rgbcolor2", "0.2 0.2 0.2"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "3.5"
                    "waterweapon", "true"
                ] }
              { name = "disintegrator"
                displayName = "Disintegrator"
                weaponType = Some "DGun"
                damage = Map.ofList [
                    "commanders", 0.0
                    "default", 99999.0
                    "scavboss", 1000.0
                    "raptorqueen", 1000.0
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
                    "soundhitwet", "sizzlexs"
                    "soundhitvolume", "36.0"
                    "soundstartvolume", "96.0"
                    "soundtrigger", "true"
                    "waterweapon", "true"
                    "weapontimer", "4.2"
                ] }
              { name = "repulsor"
                displayName = "PlasmaRepulsor"
                weaponType = Some "Shield"
                damage = Map.ofList [
                    "default", 100.0
                ]
                range = Some (ValueOrExpr.Concrete 100.0)
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
              { name = "corcomeyelaser"
                displayName = "Eye laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 120.0
                    "subs", 30.0
                ]
                range = Some (ValueOrExpr.Concrete 620.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.19)
                weaponVelocity = Some 2250.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "beamershot2"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-small-red"
                rgbColor = Some "1 0 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "commander"
                    "mount_onlytargetcategory", "NOTSUB"
                    "mount_fastautoretargeting", "true"
                    "avoidfeature", "false"
                    "beamtime", "0.2"
                    "corethickness", "0.175"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "0.0"
                    "firestarter", "100.0"
                    "impactonly", "1.0"
                    "laserflaresize", "20.0"
                    "proximitypriority", "1.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.0"
                ] }
              { name = "armcannon"
                displayName = "HeavyCannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 450.0
                    "subs", 150.0
                    "vtol", 30.0
                ]
                range = Some (ValueOrExpr.Concrete 600.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.0)
                weaponVelocity = Some 310.0
                areaOfEffect = Some 144.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "corlevlr"
                soundHit = Some "corlevlrhit"
                explosiongenerator = Some "custom:genericshellexplosion-medium"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_fastautoretargeting", "true"
                    "avoidfeature", "false"
                    "craterareaofeffect", "292.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splslrg"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 200.0)
              metalMake = Some (ValueOrExpr.Concrete 14.0)
              energyStorage = Some 2500.0
              metalStorage = Some 500.0
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "35 12 54"
                collisionVolumeType = Some "cylY"
                damage = Some 24000.0
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
          ])
          sounds = Some (
            { build = Some "nanlath2"
              repair = Some "repair2"
              working = Some "reclaim1"
              underAttack = Some "warning2"
              cancelDestruct = Some "cancel2"
              capture = Some "capture2"
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["corcom1"; "corcom2"; "corcom3"; "corcom4"; "corcom5"]
              select = ["corcomsel"] })
          customParams = Map.ofList [
              "unitgroup", "builder"
              "area_mex_def", "cormex"
              "iscommander", "true"
              "effigy_offset", "1.0"
              "evocomlvl", "5.0"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "paralyzemultiplier", "0.025"
              "subfolder", ""
              "shield_color_mult", "0.8"
              "shield_power", "13300.0"
              "shield_radius", "100.0"
              "evolution_health_transfer", "percentage"
              "evolution_target", "corcomlvl6"
              "evolution_condition", "timer"
              "evolution_timer", "99999.0"
              "evolution_power_threshold", "260000.0"
              "evolution_power_multiplier", "1.0"
              "combatradius", "0.0"
              "effigy", "comeffigylvl3"
              "minimum_respawn_stun", "5.0"
              "distance_stun_multiplier", "1.0"
              "fall_damage_multiplier", "5.0"
          ]
          extras = Map.ofList [
              "autoheal", "5.0"
              "onoffable", "true"
              "cancapture", "true"
              "cancloak", "true"
              "canmanualfire", "true"
              "capturable", "false"
              "capturespeed", "1800.0"
              "cloakcost", "100.0"
              "cloakcostmoving", "1000.0"
              "damagemodifier", "0.1"
              "hidedamage", "true"
              "holdsteady", "true"
              "icontype", "corcom"
              "sightemitheight", "40.0"
              "mass", "4900.0"
              "mincloakdistance", "50.0"
              "nochasecategory", "ALL"
              "radardistance", "1000.0"
              "radaremitheight", "40.0"
              "reclaimable", "false"
              "selfdestructcountdown", "5.0"
              "showplayername", "true"
              "sonardistance", "550.0"
              "upright", "true"
          ] }

    let corcomlvl5ToFlat (def: UnitDef) : Corcomlvl5 =
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
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          workerTime = def.builder.Value.workerTime
          buildDistance = def.builder.Value.buildDistance.Value
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyMake = def.economy.Value.energyMake.Value
          metalMake = def.economy.Value.metalMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corcomlvl5ToUnitDef (flat: Corcomlvl5) : UnitDef =
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
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = Some flat.movementClass
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = Some flat.buildDistance
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = Some flat.weapons
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = Some flat.metalMake
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corcomlvl6 =
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

    let corcomlvl6 : Corcomlvl6 =
        { name = "corcomlvl6"
          subfolder = "other/evocom"
          metalCost = ValueOrExpr.Concrete 7000.0
          energyCost = ValueOrExpr.Concrete 70000.0
          buildTime = ValueOrExpr.Concrete 182000.0
          health = ValueOrExpr.Concrete 12000.0
          sightDistance = ValueOrExpr.Concrete 550.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORCOMHILVL.s3o"
          buildPic = Some "CORCOM.DDS"
          script = Some "Units/CORCOMHILVL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "commanderexplosion"
          selfDestructAs = Some "commanderExplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 40.5
          maxAcc = 0.18
          maxDec = 1.125
          turnRate = 1133.0
          movementClass = "COMMANDERBOT"
          maxSlope = 20.0
          maxWaterDepth = 35.0
          canMove = true
          turnInPlaceAngleLimit = 140.0
          turnInPlaceSpeedLimit = 0.825
          workerTime = ValueOrExpr.Concrete 810.0
          buildDistance = 185.0
          buildOptions = []
          terraformSpeed = 1500.0
          energyMake = ValueOrExpr.Concrete 325.0
          metalMake = ValueOrExpr.Concrete 20.0
          energyStorage = 3000.0
          metalStorage = 500.0
          weapons = [
                { name = "corcomlaser"
                  displayName = "Anti-swarm AoE flamethrower"
                  weaponType = Some "Flame"
                  damage = Map.ofList [
                      "default", 90.0
                      "subs", 25.0
                  ]
                  range = Some (ValueOrExpr.Concrete 400.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.95)
                  weaponVelocity = Some 500.0
                  areaOfEffect = Some 80.0
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
                      "mount_fastautoretargeting", "true"
                      "avoidfeature", "false"
                      "burst", "16.0"
                      "burstrate", "0.05"
                      "cegtag", "burnflame-anim"
                      "colormap", "1 0.95 0.82 0.03   0.65 0.4 0.35 0.030   0.44 0.25 0.20 0.028   0.033 0.018 0.012 0.03   0.0 0.0 0.0 0.01"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "100.0"
                      "flamegfxtime", "1.0"
                      "intensity", "0.68"
                      "rgbcolor2", "0.9 0.84 0.8"
                      "sizegrowth", "0.75"
                      "soundhitdry", "flamhit1"
                      "soundhitwet", "sizzle"
                      "soundhitvolume", "7.5"
                      "soundstartvolume", "5.3"
                      "soundtrigger", "false"
                      "sprayangle", "100.0"
                      "targetmoveerror", "0.001"
                      "texture1", "flame"
                      "weapontimer", "1.0"
                  ] }
                { name = "corcomsealaser"
                  displayName = "UltravioletRayBeam"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 1200.0
                      "subs", 600.0
                  ]
                  range = Some (ValueOrExpr.Concrete 475.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.7)
                  weaponVelocity = Some 700.0
                  areaOfEffect = Some 42.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "uwlasrfir1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-medium-blue"
                  rgbColor = Some "0.6 0.2 0.6"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTAIR"
                      "avoidfeature", "false"
                      "beamtime", "0.16"
                      "camerashake", "0.0"
                      "corethickness", "0.2"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "90.0"
                      "firesubmersed", "true"
                      "intensity", "0.6"
                      "laserflaresize", "5.5"
                      "rgbcolor2", "0.2 0.2 0.2"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "3.5"
                      "waterweapon", "true"
                  ] }
                { name = "disintegrator"
                  displayName = "Disintegrator"
                  weaponType = Some "DGun"
                  damage = Map.ofList [
                      "commanders", 0.0
                      "default", 99999.0
                      "scavboss", 1000.0
                      "raptorqueen", 1000.0
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
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "avoidfriendly", "true"
                      "bouncerebound", "0.0"
                      "cegtag", "dgunprojectile"
                      "commandfire", "true"
                      "craterboost", "0.0"
                      "cratermult", "0.15"
                      "energypershot", "500.0"
                      "firestarter", "100.0"
                      "firesubmersed", "false"
                      "noexplode", "true"
                      "soundhitwet", "sizzlexs"
                      "soundhitvolume", "36.0"
                      "soundstartvolume", "96.0"
                      "soundtrigger", "true"
                      "waterweapon", "true"
                      "weapontimer", "4.2"
                  ] }
                { name = "repulsor"
                  displayName = "PlasmaRepulsor"
                  weaponType = Some "Shield"
                  damage = Map.ofList [
                      "default", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 100.0)
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
                { name = "corcomeyelaser"
                  displayName = "EyeLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 26.0
                  ]
                  range = Some (ValueOrExpr.Concrete 730.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.033)
                  weaponVelocity = Some 900.0
                  areaOfEffect = Some 50.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "heatray3burn"
                  soundHit = None
                  explosiongenerator = Some "custom:genericshellexplosion-medium-beam"
                  rgbColor = Some "1 0.2 0.2"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "mount_fastautoretargeting", "true"
                      "allowNonBlockingAim", "true"
                      "avoidfeature", "false"
                      "beamtime", "0.033"
                      "camerashake", "0.1"
                      "collidefriendly", "false"
                      "corethickness", "0.3"
                      "craterareaofeffect", "72.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "0.0"
                      "firestarter", "90.0"
                      "firetolerance", "300.0"
                      "intensity", "5.0"
                      "laserflaresize", "6.0"
                      "proximitypriority", "1.0"
                      "rgbcolor2", "0.8 0.1 0.1"
                      "scrollspeed", "5.0"
                      "soundhitdry", "flamhit1"
                      "soundhitwet", "sizzle"
                      "soundstartvolume", "11.0"
                      "soundtrigger", "1.0"
                      "thickness", "4.5"
                  ] }
                { name = "armcannon"
                  displayName = "HeavyCannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 675.0
                      "subs", 180.0
                      "vtol", 60.0
                  ]
                  range = Some (ValueOrExpr.Concrete 600.0)
                  reloadTime = Some (ValueOrExpr.Concrete 3.0)
                  weaponVelocity = Some 310.0
                  areaOfEffect = Some 144.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "corlevlr"
                  soundHit = Some "corlevlrhit"
                  explosiongenerator = Some "custom:genericshellexplosion-medium"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_fastautoretargeting", "true"
                      "avoidfeature", "false"
                      "craterareaofeffect", "292.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "soundhitwet", "splslrg"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "35 12 54"
                  collisionVolumeType = Some "cylY"
                  damage = Some 28000.0
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
                "unitgroup", "builder"
                "area_mex_def", "cormex"
                "iscommander", "true"
                "effigy_offset", "1.0"
                "evocomlvl", "6.0"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "paralyzemultiplier", "0.025"
                "subfolder", ""
                "shield_color_mult", "0.8"
                "shield_power", "19000.0"
                "shield_radius", "100.0"
                "evolution_health_transfer", "percentage"
                "evolution_target", "corcomlvl7"
                "evolution_condition", "timer"
                "evolution_timer", "99999.0"
                "evolution_power_threshold", "390000.0"
                "evolution_power_multiplier", "1.0"
                "combatradius", "0.0"
                "effigy", "comeffigylvl3"
                "minimum_respawn_stun", "5.0"
                "distance_stun_multiplier", "1.0"
                "fall_damage_multiplier", "5.0"
            ]
          extras = Map.ofList [
                "autoheal", "5.0"
                "onoffable", "true"
                "cancapture", "true"
                "cancloak", "true"
                "canmanualfire", "true"
                "capturable", "false"
                "capturespeed", "1800.0"
                "cloakcost", "100.0"
                "cloakcostmoving", "1000.0"
                "damagemodifier", "0.1"
                "hidedamage", "true"
                "holdsteady", "true"
                "icontype", "corcom"
                "sightemitheight", "40.0"
                "mass", "4900.0"
                "mincloakdistance", "50.0"
                "nochasecategory", "ALL"
                "radardistance", "1000.0"
                "radaremitheight", "40.0"
                "reclaimable", "false"
                "selfdestructcountdown", "5.0"
                "showplayername", "true"
                "sonardistance", "550.0"
                "upright", "true"
            ] }

    let corcomlvl6Def : UnitDef =
        { name = "corcomlvl6"
          subfolder = "other/evocom"
          metalCost = ValueOrExpr.Concrete 7000.0
          energyCost = ValueOrExpr.Concrete 70000.0
          buildTime = ValueOrExpr.Concrete 182000.0
          health = ValueOrExpr.Concrete 12000.0
          sightDistance = ValueOrExpr.Concrete 550.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORCOMHILVL.s3o"
          buildPic = Some "CORCOM.DDS"
          script = Some "Units/CORCOMHILVL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "commanderexplosion"
          selfDestructAs = Some "commanderExplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 40.5
              maxAcc = 0.18
              maxDec = 1.125
              turnRate = 1133.0
              movementClass = Some "COMMANDERBOT"
              maxSlope = Some 20.0
              maxWaterDepth = Some 35.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 140.0
              turnInPlaceSpeedLimit = Some 0.825
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 810.0
              buildDistance = Some 185.0
              buildOptions = []
              terraformSpeed = Some 1500.0 })
          weapons = Some [
              { name = "corcomlaser"
                displayName = "Anti-swarm AoE flamethrower"
                weaponType = Some "Flame"
                damage = Map.ofList [
                    "default", 90.0
                    "subs", 25.0
                ]
                range = Some (ValueOrExpr.Concrete 400.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.95)
                weaponVelocity = Some 500.0
                areaOfEffect = Some 80.0
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
                    "mount_fastautoretargeting", "true"
                    "avoidfeature", "false"
                    "burst", "16.0"
                    "burstrate", "0.05"
                    "cegtag", "burnflame-anim"
                    "colormap", "1 0.95 0.82 0.03   0.65 0.4 0.35 0.030   0.44 0.25 0.20 0.028   0.033 0.018 0.012 0.03   0.0 0.0 0.0 0.01"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "100.0"
                    "flamegfxtime", "1.0"
                    "intensity", "0.68"
                    "rgbcolor2", "0.9 0.84 0.8"
                    "sizegrowth", "0.75"
                    "soundhitdry", "flamhit1"
                    "soundhitwet", "sizzle"
                    "soundhitvolume", "7.5"
                    "soundstartvolume", "5.3"
                    "soundtrigger", "false"
                    "sprayangle", "100.0"
                    "targetmoveerror", "0.001"
                    "texture1", "flame"
                    "weapontimer", "1.0"
                ] }
              { name = "corcomsealaser"
                displayName = "UltravioletRayBeam"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 1200.0
                    "subs", 600.0
                ]
                range = Some (ValueOrExpr.Concrete 475.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.7)
                weaponVelocity = Some 700.0
                areaOfEffect = Some 42.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "uwlasrfir1"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-medium-blue"
                rgbColor = Some "0.6 0.2 0.6"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTAIR"
                    "avoidfeature", "false"
                    "beamtime", "0.16"
                    "camerashake", "0.0"
                    "corethickness", "0.2"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "firestarter", "90.0"
                    "firesubmersed", "true"
                    "intensity", "0.6"
                    "laserflaresize", "5.5"
                    "rgbcolor2", "0.2 0.2 0.2"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "3.5"
                    "waterweapon", "true"
                ] }
              { name = "disintegrator"
                displayName = "Disintegrator"
                weaponType = Some "DGun"
                damage = Map.ofList [
                    "commanders", 0.0
                    "default", 99999.0
                    "scavboss", 1000.0
                    "raptorqueen", 1000.0
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
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "avoidfriendly", "true"
                    "bouncerebound", "0.0"
                    "cegtag", "dgunprojectile"
                    "commandfire", "true"
                    "craterboost", "0.0"
                    "cratermult", "0.15"
                    "energypershot", "500.0"
                    "firestarter", "100.0"
                    "firesubmersed", "false"
                    "noexplode", "true"
                    "soundhitwet", "sizzlexs"
                    "soundhitvolume", "36.0"
                    "soundstartvolume", "96.0"
                    "soundtrigger", "true"
                    "waterweapon", "true"
                    "weapontimer", "4.2"
                ] }
              { name = "repulsor"
                displayName = "PlasmaRepulsor"
                weaponType = Some "Shield"
                damage = Map.ofList [
                    "default", 100.0
                ]
                range = Some (ValueOrExpr.Concrete 100.0)
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
              { name = "corcomeyelaser"
                displayName = "EyeLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 26.0
                ]
                range = Some (ValueOrExpr.Concrete 730.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.033)
                weaponVelocity = Some 900.0
                areaOfEffect = Some 50.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "heatray3burn"
                soundHit = None
                explosiongenerator = Some "custom:genericshellexplosion-medium-beam"
                rgbColor = Some "1 0.2 0.2"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "mount_fastautoretargeting", "true"
                    "allowNonBlockingAim", "true"
                    "avoidfeature", "false"
                    "beamtime", "0.033"
                    "camerashake", "0.1"
                    "collidefriendly", "false"
                    "corethickness", "0.3"
                    "craterareaofeffect", "72.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "0.0"
                    "firestarter", "90.0"
                    "firetolerance", "300.0"
                    "intensity", "5.0"
                    "laserflaresize", "6.0"
                    "proximitypriority", "1.0"
                    "rgbcolor2", "0.8 0.1 0.1"
                    "scrollspeed", "5.0"
                    "soundhitdry", "flamhit1"
                    "soundhitwet", "sizzle"
                    "soundstartvolume", "11.0"
                    "soundtrigger", "1.0"
                    "thickness", "4.5"
                ] }
              { name = "armcannon"
                displayName = "HeavyCannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 675.0
                    "subs", 180.0
                    "vtol", 60.0
                ]
                range = Some (ValueOrExpr.Concrete 600.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.0)
                weaponVelocity = Some 310.0
                areaOfEffect = Some 144.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "corlevlr"
                soundHit = Some "corlevlrhit"
                explosiongenerator = Some "custom:genericshellexplosion-medium"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_fastautoretargeting", "true"
                    "avoidfeature", "false"
                    "craterareaofeffect", "292.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splslrg"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 325.0)
              metalMake = Some (ValueOrExpr.Concrete 20.0)
              energyStorage = Some 3000.0
              metalStorage = Some 500.0
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "35 12 54"
                collisionVolumeType = Some "cylY"
                damage = Some 28000.0
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
          ])
          sounds = Some (
            { build = Some "nanlath2"
              repair = Some "repair2"
              working = Some "reclaim1"
              underAttack = Some "warning2"
              cancelDestruct = Some "cancel2"
              capture = Some "capture2"
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["corcom1"; "corcom2"; "corcom3"; "corcom4"; "corcom5"]
              select = ["corcomsel"] })
          customParams = Map.ofList [
              "unitgroup", "builder"
              "area_mex_def", "cormex"
              "iscommander", "true"
              "effigy_offset", "1.0"
              "evocomlvl", "6.0"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "paralyzemultiplier", "0.025"
              "subfolder", ""
              "shield_color_mult", "0.8"
              "shield_power", "19000.0"
              "shield_radius", "100.0"
              "evolution_health_transfer", "percentage"
              "evolution_target", "corcomlvl7"
              "evolution_condition", "timer"
              "evolution_timer", "99999.0"
              "evolution_power_threshold", "390000.0"
              "evolution_power_multiplier", "1.0"
              "combatradius", "0.0"
              "effigy", "comeffigylvl3"
              "minimum_respawn_stun", "5.0"
              "distance_stun_multiplier", "1.0"
              "fall_damage_multiplier", "5.0"
          ]
          extras = Map.ofList [
              "autoheal", "5.0"
              "onoffable", "true"
              "cancapture", "true"
              "cancloak", "true"
              "canmanualfire", "true"
              "capturable", "false"
              "capturespeed", "1800.0"
              "cloakcost", "100.0"
              "cloakcostmoving", "1000.0"
              "damagemodifier", "0.1"
              "hidedamage", "true"
              "holdsteady", "true"
              "icontype", "corcom"
              "sightemitheight", "40.0"
              "mass", "4900.0"
              "mincloakdistance", "50.0"
              "nochasecategory", "ALL"
              "radardistance", "1000.0"
              "radaremitheight", "40.0"
              "reclaimable", "false"
              "selfdestructcountdown", "5.0"
              "showplayername", "true"
              "sonardistance", "550.0"
              "upright", "true"
          ] }

    let corcomlvl6ToFlat (def: UnitDef) : Corcomlvl6 =
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
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          workerTime = def.builder.Value.workerTime
          buildDistance = def.builder.Value.buildDistance.Value
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyMake = def.economy.Value.energyMake.Value
          metalMake = def.economy.Value.metalMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corcomlvl6ToUnitDef (flat: Corcomlvl6) : UnitDef =
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
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = Some flat.movementClass
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = Some flat.buildDistance
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = Some flat.weapons
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = Some flat.metalMake
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corcomlvl7 =
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

    let corcomlvl7 : Corcomlvl7 =
        { name = "corcomlvl7"
          subfolder = "other/evocom"
          metalCost = ValueOrExpr.Concrete 8000.0
          energyCost = ValueOrExpr.Concrete 80000.0
          buildTime = ValueOrExpr.Concrete 210000.0
          health = ValueOrExpr.Concrete 14000.0
          sightDistance = ValueOrExpr.Concrete 550.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORCOMHILVL.s3o"
          buildPic = Some "CORCOM.DDS"
          script = Some "Units/CORCOMHILVL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "commanderexplosion"
          selfDestructAs = Some "commanderExplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 42.0
          maxAcc = 0.18
          maxDec = 1.125
          turnRate = 1133.0
          movementClass = "COMMANDERBOT"
          maxSlope = 20.0
          maxWaterDepth = 35.0
          canMove = true
          turnInPlaceAngleLimit = 140.0
          turnInPlaceSpeedLimit = 0.825
          workerTime = ValueOrExpr.Concrete 990.0
          buildDistance = 193.0
          buildOptions = []
          terraformSpeed = 1500.0
          energyMake = ValueOrExpr.Concrete 525.0
          metalMake = ValueOrExpr.Concrete 27.0
          energyStorage = 3500.0
          metalStorage = 500.0
          weapons = [
                { name = "corcomlaser"
                  displayName = "Anti-swarm AoE flamethrower"
                  weaponType = Some "Flame"
                  damage = Map.ofList [
                      "default", 90.0
                      "subs", 25.0
                  ]
                  range = Some (ValueOrExpr.Concrete 400.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.8)
                  weaponVelocity = Some 500.0
                  areaOfEffect = Some 80.0
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
                      "mount_fastautoretargeting", "true"
                      "avoidfeature", "false"
                      "burst", "16.0"
                      "burstrate", "0.05"
                      "cegtag", "burnflame-anim"
                      "colormap", "1 0.95 0.82 0.03   0.65 0.4 0.35 0.030   0.44 0.25 0.20 0.028   0.033 0.018 0.012 0.03   0.0 0.0 0.0 0.01"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "100.0"
                      "flamegfxtime", "1.0"
                      "intensity", "0.68"
                      "rgbcolor2", "0.9 0.84 0.8"
                      "sizegrowth", "0.8"
                      "soundhitdry", "flamhit1"
                      "soundhitwet", "sizzle"
                      "soundhitvolume", "7.5"
                      "soundstartvolume", "5.3"
                      "soundtrigger", "false"
                      "sprayangle", "100.0"
                      "targetmoveerror", "0.001"
                      "texture1", "flame"
                      "weapontimer", "1.0"
                  ] }
                { name = "corcomsealaser"
                  displayName = "UltravioletRayBeam"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 1200.0
                      "subs", 600.0
                  ]
                  range = Some (ValueOrExpr.Concrete 500.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.55)
                  weaponVelocity = Some 700.0
                  areaOfEffect = Some 42.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "uwlasrfir1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-medium-blue"
                  rgbColor = Some "0.6 0.2 0.6"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTAIR"
                      "avoidfeature", "false"
                      "beamtime", "0.16"
                      "camerashake", "0.0"
                      "corethickness", "0.2"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "90.0"
                      "firesubmersed", "true"
                      "intensity", "0.6"
                      "laserflaresize", "5.5"
                      "rgbcolor2", "0.2 0.2 0.2"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "3.5"
                      "waterweapon", "true"
                  ] }
                { name = "disintegrator"
                  displayName = "Disintegrator"
                  weaponType = Some "DGun"
                  damage = Map.ofList [
                      "commanders", 0.0
                      "default", 99999.0
                      "scavboss", 1000.0
                      "raptorqueen", 1000.0
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
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "avoidfriendly", "true"
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
                      "soundhitwet", "sizzlexs"
                      "soundhitvolume", "36.0"
                      "soundstartvolume", "96.0"
                      "soundtrigger", "true"
                      "waterweapon", "true"
                      "weapontimer", "4.2"
                  ] }
                { name = "repulsor"
                  displayName = "PlasmaRepulsor"
                  weaponType = Some "Shield"
                  damage = Map.ofList [
                      "default", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 100.0)
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
                { name = "corcomeyelaser"
                  displayName = "EyeLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 34.0
                  ]
                  range = Some (ValueOrExpr.Concrete 730.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.033)
                  weaponVelocity = Some 900.0
                  areaOfEffect = Some 50.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "heatray3burn"
                  soundHit = None
                  explosiongenerator = Some "custom:genericshellexplosion-medium-beam"
                  rgbColor = Some "1 0.2 0.2"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "mount_fastautoretargeting", "true"
                      "allowNonBlockingAim", "true"
                      "avoidfeature", "false"
                      "beamtime", "0.033"
                      "camerashake", "0.1"
                      "collidefriendly", "false"
                      "corethickness", "0.3"
                      "craterareaofeffect", "72.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "0.0"
                      "firestarter", "90.0"
                      "firetolerance", "300.0"
                      "intensity", "5.0"
                      "laserflaresize", "6.0"
                      "proximitypriority", "1.0"
                      "rgbcolor2", "0.8 0.1 0.1"
                      "scrollspeed", "5.0"
                      "soundhitdry", "flamhit1"
                      "soundhitwet", "sizzle"
                      "soundstartvolume", "11.0"
                      "soundtrigger", "1.0"
                      "thickness", "4.5"
                  ] }
                { name = "armcannon"
                  displayName = "HeavyCannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 900.0
                      "subs", 200.0
                      "vtol", 50.0
                  ]
                  range = Some (ValueOrExpr.Concrete 700.0)
                  reloadTime = Some (ValueOrExpr.Concrete 3.0)
                  weaponVelocity = Some 310.0
                  areaOfEffect = Some 210.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "largegun"
                  soundHit = Some "xplomed4"
                  explosiongenerator = Some "custom:genericshellexplosion-large-aoe"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_fastautoretargeting", "true"
                      "avoidfeature", "false"
                      "craterareaofeffect", "292.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "soundhitwet", "splslrg"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "35 12 54"
                  collisionVolumeType = Some "cylY"
                  damage = Some 32000.0
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
                "unitgroup", "builder"
                "area_mex_def", "cormex"
                "iscommander", "true"
                "effigy_offset", "1.0"
                "evocomlvl", "7.0"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "paralyzemultiplier", "0.025"
                "subfolder", ""
                "shield_color_mult", "0.8"
                "shield_power", "24700.0"
                "shield_radius", "100.0"
                "evolution_health_transfer", "percentage"
                "evolution_target", "corcomlvl8"
                "evolution_condition", "timer"
                "evolution_timer", "99999.0"
                "evolution_power_threshold", "520000.0"
                "evolution_power_multiplier", "1.0"
                "combatradius", "0.0"
                "effigy", "comeffigylvl4"
                "minimum_respawn_stun", "5.0"
                "distance_stun_multiplier", "1.0"
                "fall_damage_multiplier", "5.0"
            ]
          extras = Map.ofList [
                "autoheal", "5.0"
                "onoffable", "true"
                "cancapture", "true"
                "cancloak", "true"
                "canmanualfire", "true"
                "capturable", "false"
                "capturespeed", "1800.0"
                "cloakcost", "100.0"
                "cloakcostmoving", "1000.0"
                "damagemodifier", "0.1"
                "hidedamage", "true"
                "holdsteady", "true"
                "icontype", "corcom"
                "sightemitheight", "40.0"
                "mass", "4900.0"
                "mincloakdistance", "50.0"
                "nochasecategory", "ALL"
                "radardistance", "1000.0"
                "radaremitheight", "40.0"
                "reclaimable", "false"
                "selfdestructcountdown", "5.0"
                "showplayername", "true"
                "sonardistance", "550.0"
                "upright", "true"
            ] }

    let corcomlvl7Def : UnitDef =
        { name = "corcomlvl7"
          subfolder = "other/evocom"
          metalCost = ValueOrExpr.Concrete 8000.0
          energyCost = ValueOrExpr.Concrete 80000.0
          buildTime = ValueOrExpr.Concrete 210000.0
          health = ValueOrExpr.Concrete 14000.0
          sightDistance = ValueOrExpr.Concrete 550.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORCOMHILVL.s3o"
          buildPic = Some "CORCOM.DDS"
          script = Some "Units/CORCOMHILVL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "commanderexplosion"
          selfDestructAs = Some "commanderExplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 42.0
              maxAcc = 0.18
              maxDec = 1.125
              turnRate = 1133.0
              movementClass = Some "COMMANDERBOT"
              maxSlope = Some 20.0
              maxWaterDepth = Some 35.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 140.0
              turnInPlaceSpeedLimit = Some 0.825
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 990.0
              buildDistance = Some 193.0
              buildOptions = []
              terraformSpeed = Some 1500.0 })
          weapons = Some [
              { name = "corcomlaser"
                displayName = "Anti-swarm AoE flamethrower"
                weaponType = Some "Flame"
                damage = Map.ofList [
                    "default", 90.0
                    "subs", 25.0
                ]
                range = Some (ValueOrExpr.Concrete 400.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.8)
                weaponVelocity = Some 500.0
                areaOfEffect = Some 80.0
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
                    "mount_fastautoretargeting", "true"
                    "avoidfeature", "false"
                    "burst", "16.0"
                    "burstrate", "0.05"
                    "cegtag", "burnflame-anim"
                    "colormap", "1 0.95 0.82 0.03   0.65 0.4 0.35 0.030   0.44 0.25 0.20 0.028   0.033 0.018 0.012 0.03   0.0 0.0 0.0 0.01"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "100.0"
                    "flamegfxtime", "1.0"
                    "intensity", "0.68"
                    "rgbcolor2", "0.9 0.84 0.8"
                    "sizegrowth", "0.8"
                    "soundhitdry", "flamhit1"
                    "soundhitwet", "sizzle"
                    "soundhitvolume", "7.5"
                    "soundstartvolume", "5.3"
                    "soundtrigger", "false"
                    "sprayangle", "100.0"
                    "targetmoveerror", "0.001"
                    "texture1", "flame"
                    "weapontimer", "1.0"
                ] }
              { name = "corcomsealaser"
                displayName = "UltravioletRayBeam"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 1200.0
                    "subs", 600.0
                ]
                range = Some (ValueOrExpr.Concrete 500.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.55)
                weaponVelocity = Some 700.0
                areaOfEffect = Some 42.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "uwlasrfir1"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-medium-blue"
                rgbColor = Some "0.6 0.2 0.6"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTAIR"
                    "avoidfeature", "false"
                    "beamtime", "0.16"
                    "camerashake", "0.0"
                    "corethickness", "0.2"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "firestarter", "90.0"
                    "firesubmersed", "true"
                    "intensity", "0.6"
                    "laserflaresize", "5.5"
                    "rgbcolor2", "0.2 0.2 0.2"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "3.5"
                    "waterweapon", "true"
                ] }
              { name = "disintegrator"
                displayName = "Disintegrator"
                weaponType = Some "DGun"
                damage = Map.ofList [
                    "commanders", 0.0
                    "default", 99999.0
                    "scavboss", 1000.0
                    "raptorqueen", 1000.0
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
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "avoidfriendly", "true"
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
                    "soundhitwet", "sizzlexs"
                    "soundhitvolume", "36.0"
                    "soundstartvolume", "96.0"
                    "soundtrigger", "true"
                    "waterweapon", "true"
                    "weapontimer", "4.2"
                ] }
              { name = "repulsor"
                displayName = "PlasmaRepulsor"
                weaponType = Some "Shield"
                damage = Map.ofList [
                    "default", 100.0
                ]
                range = Some (ValueOrExpr.Concrete 100.0)
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
              { name = "corcomeyelaser"
                displayName = "EyeLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 34.0
                ]
                range = Some (ValueOrExpr.Concrete 730.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.033)
                weaponVelocity = Some 900.0
                areaOfEffect = Some 50.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "heatray3burn"
                soundHit = None
                explosiongenerator = Some "custom:genericshellexplosion-medium-beam"
                rgbColor = Some "1 0.2 0.2"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "mount_fastautoretargeting", "true"
                    "allowNonBlockingAim", "true"
                    "avoidfeature", "false"
                    "beamtime", "0.033"
                    "camerashake", "0.1"
                    "collidefriendly", "false"
                    "corethickness", "0.3"
                    "craterareaofeffect", "72.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "0.0"
                    "firestarter", "90.0"
                    "firetolerance", "300.0"
                    "intensity", "5.0"
                    "laserflaresize", "6.0"
                    "proximitypriority", "1.0"
                    "rgbcolor2", "0.8 0.1 0.1"
                    "scrollspeed", "5.0"
                    "soundhitdry", "flamhit1"
                    "soundhitwet", "sizzle"
                    "soundstartvolume", "11.0"
                    "soundtrigger", "1.0"
                    "thickness", "4.5"
                ] }
              { name = "armcannon"
                displayName = "HeavyCannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 900.0
                    "subs", 200.0
                    "vtol", 50.0
                ]
                range = Some (ValueOrExpr.Concrete 700.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.0)
                weaponVelocity = Some 310.0
                areaOfEffect = Some 210.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "largegun"
                soundHit = Some "xplomed4"
                explosiongenerator = Some "custom:genericshellexplosion-large-aoe"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_fastautoretargeting", "true"
                    "avoidfeature", "false"
                    "craterareaofeffect", "292.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splslrg"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 525.0)
              metalMake = Some (ValueOrExpr.Concrete 27.0)
              energyStorage = Some 3500.0
              metalStorage = Some 500.0
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "35 12 54"
                collisionVolumeType = Some "cylY"
                damage = Some 32000.0
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
          ])
          sounds = Some (
            { build = Some "nanlath2"
              repair = Some "repair2"
              working = Some "reclaim1"
              underAttack = Some "warning2"
              cancelDestruct = Some "cancel2"
              capture = Some "capture2"
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["corcom1"; "corcom2"; "corcom3"; "corcom4"; "corcom5"]
              select = ["corcomsel"] })
          customParams = Map.ofList [
              "unitgroup", "builder"
              "area_mex_def", "cormex"
              "iscommander", "true"
              "effigy_offset", "1.0"
              "evocomlvl", "7.0"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "paralyzemultiplier", "0.025"
              "subfolder", ""
              "shield_color_mult", "0.8"
              "shield_power", "24700.0"
              "shield_radius", "100.0"
              "evolution_health_transfer", "percentage"
              "evolution_target", "corcomlvl8"
              "evolution_condition", "timer"
              "evolution_timer", "99999.0"
              "evolution_power_threshold", "520000.0"
              "evolution_power_multiplier", "1.0"
              "combatradius", "0.0"
              "effigy", "comeffigylvl4"
              "minimum_respawn_stun", "5.0"
              "distance_stun_multiplier", "1.0"
              "fall_damage_multiplier", "5.0"
          ]
          extras = Map.ofList [
              "autoheal", "5.0"
              "onoffable", "true"
              "cancapture", "true"
              "cancloak", "true"
              "canmanualfire", "true"
              "capturable", "false"
              "capturespeed", "1800.0"
              "cloakcost", "100.0"
              "cloakcostmoving", "1000.0"
              "damagemodifier", "0.1"
              "hidedamage", "true"
              "holdsteady", "true"
              "icontype", "corcom"
              "sightemitheight", "40.0"
              "mass", "4900.0"
              "mincloakdistance", "50.0"
              "nochasecategory", "ALL"
              "radardistance", "1000.0"
              "radaremitheight", "40.0"
              "reclaimable", "false"
              "selfdestructcountdown", "5.0"
              "showplayername", "true"
              "sonardistance", "550.0"
              "upright", "true"
          ] }

    let corcomlvl7ToFlat (def: UnitDef) : Corcomlvl7 =
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
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          workerTime = def.builder.Value.workerTime
          buildDistance = def.builder.Value.buildDistance.Value
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyMake = def.economy.Value.energyMake.Value
          metalMake = def.economy.Value.metalMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corcomlvl7ToUnitDef (flat: Corcomlvl7) : UnitDef =
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
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = Some flat.movementClass
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = Some flat.buildDistance
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = Some flat.weapons
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = Some flat.metalMake
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corcomlvl8 =
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

    let corcomlvl8 : Corcomlvl8 =
        { name = "corcomlvl8"
          subfolder = "other/evocom"
          metalCost = ValueOrExpr.Concrete 9000.0
          energyCost = ValueOrExpr.Concrete 90000.0
          buildTime = ValueOrExpr.Concrete 230000.0
          health = ValueOrExpr.Concrete 16000.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORCOMHILVL.s3o"
          buildPic = Some "CORCOM.DDS"
          script = Some "Units/CORCOMHILVL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "commanderexplosion"
          selfDestructAs = Some "commanderExplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 43.5
          maxAcc = 0.18
          maxDec = 1.125
          turnRate = 1133.0
          movementClass = "COMMANDERBOT"
          maxSlope = 20.0
          maxWaterDepth = 35.0
          canMove = true
          turnInPlaceAngleLimit = 140.0
          turnInPlaceSpeedLimit = 0.825
          workerTime = ValueOrExpr.Concrete 1200.0
          buildDistance = 201.0
          buildOptions = []
          terraformSpeed = 1500.0
          energyMake = ValueOrExpr.Concrete 850.0
          metalMake = ValueOrExpr.Concrete 34.0
          energyStorage = 5000.0
          metalStorage = 500.0
          weapons = [
                { name = "corcomlaser"
                  displayName = "Long range AoE flamethrower"
                  weaponType = Some "Flame"
                  damage = Map.ofList [
                      "default", 80.0
                      "subs", 25.0
                  ]
                  range = Some (ValueOrExpr.Concrete 475.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.39996)
                  weaponVelocity = Some 500.0
                  areaOfEffect = Some 128.0
                  accuracy = Some 0.0
                  turret = Some true
                  tolerance = Some 20000.0
                  edgeEffectiveness = Some 0.01
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "Flamhvy1"
                  soundHit = None
                  explosiongenerator = Some "custom:burnblackxl"
                  rgbColor = Some "1 0.94 0.88"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_fastautoretargeting", "true"
                      "allowNonBlockingAim", "true"
                      "avoidfeature", "false"
                      "avoidfriendly", "true"
                      "burst", "12.0"
                      "burstrate", "0.03333"
                      "burnblow", "true"
                      "bouncerebound", "1.0"
                      "cegtag", "demonflame"
                      "colormap", "1 0.95 0.9 0.032   0.55 0.55 0.40 0.028   0.40 0.28 0.19 0.024   0.033 0.018 0.011 0.04   0.0 0.0 0.0 0.01"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "bounceSlip", "1.0"
                      "firestarter", "100.0"
                      "firesubmersed", "false"
                      "flameGFXTime", "1.0"
                      "intensity", "0.85"
                      "noexplode", "false"
                      "predictboost", "1.0"
                      "rgbcolor2", "0.9 0.84 0.8"
                      "sizegrowth", "1.1"
                      "soundhitdry", "flamhit1"
                      "soundhitwet", "sizzle"
                      "soundhitvolume", "9.5"
                      "soundstartvolume", "7.3"
                      "soundtrigger", "false"
                      "waterweapon", "false"
                  ] }
                { name = "corcomsealaser"
                  displayName = "UWSupernovaBeam"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 1400.0
                      "subs", 700.0
                  ]
                  range = Some (ValueOrExpr.Concrete 500.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.54)
                  weaponVelocity = Some 700.0
                  areaOfEffect = Some 70.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "uwlasrfir1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-medium-blue"
                  rgbColor = Some "0.1 0.2 0.7"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTAIR"
                      "avoidfeature", "false"
                      "beamtime", "0.16"
                      "camerashake", "0.0"
                      "corethickness", "0.5"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "90.0"
                      "firesubmersed", "true"
                      "intensity", "0.6"
                      "laserflaresize", "5.5"
                      "rgbcolor2", "0.9 0.9 0.9"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "3.5"
                      "waterweapon", "true"
                  ] }
                { name = "disintegrator"
                  displayName = "Disintegrator"
                  weaponType = Some "DGun"
                  damage = Map.ofList [
                      "commanders", 0.0
                      "default", 99999.0
                      "scavboss", 1000.0
                      "raptorqueen", 1000.0
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
                      "soundhitwet", "sizzlexs"
                      "soundhitvolume", "36.0"
                      "soundstartvolume", "96.0"
                      "soundtrigger", "true"
                      "waterweapon", "true"
                      "weapontimer", "4.2"
                  ] }
                { name = "repulsor"
                  displayName = "PlasmaRepulsor"
                  weaponType = Some "Shield"
                  damage = Map.ofList [
                      "default", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 100.0)
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
                { name = "corcomeyelaser"
                  displayName = "EyeLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 42.0
                  ]
                  range = Some (ValueOrExpr.Concrete 800.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.033)
                  weaponVelocity = Some 900.0
                  areaOfEffect = Some 50.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "heatray3burn"
                  soundHit = None
                  explosiongenerator = Some "custom:genericshellexplosion-medium-beam"
                  rgbColor = Some "1 0.2 0.2"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "mount_fastautoretargeting", "true"
                      "allowNonBlockingAim", "true"
                      "avoidfeature", "false"
                      "beamtime", "0.033"
                      "camerashake", "0.1"
                      "collidefriendly", "false"
                      "corethickness", "0.3"
                      "craterareaofeffect", "72.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "0.0"
                      "firestarter", "90.0"
                      "firetolerance", "300.0"
                      "intensity", "5.0"
                      "laserflaresize", "6.0"
                      "proximitypriority", "1.0"
                      "rgbcolor2", "0.8 0.1 0.1"
                      "scrollspeed", "5.0"
                      "soundhitdry", "flamhit1"
                      "soundhitwet", "sizzle"
                      "soundstartvolume", "11.0"
                      "soundtrigger", "1.0"
                      "thickness", "4.5"
                  ] }
                { name = "armcannon"
                  displayName = "HeavyCannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 1050.0
                      "subs", 250.0
                      "vtol", 75.0
                  ]
                  range = Some (ValueOrExpr.Concrete 700.0)
                  reloadTime = Some (ValueOrExpr.Concrete 3.0)
                  weaponVelocity = Some 310.0
                  areaOfEffect = Some 210.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "largegun"
                  soundHit = Some "xplomed4"
                  explosiongenerator = Some "custom:genericshellexplosion-large-aoe"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_fastautoretargeting", "true"
                      "avoidfeature", "false"
                      "craterareaofeffect", "292.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "soundhitwet", "splslrg"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "35 12 54"
                  collisionVolumeType = Some "cylY"
                  damage = Some 36000.0
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
                "unitgroup", "builder"
                "area_mex_def", "cormoho"
                "iscommander", "true"
                "effigy_offset", "1.0"
                "evocomlvl", "8.0"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "paralyzemultiplier", "0.025"
                "subfolder", ""
                "shield_color_mult", "0.8"
                "shield_power", "32300.0"
                "shield_radius", "100.0"
                "evolution_health_transfer", "percentage"
                "evolution_target", "corcomlvl9"
                "evolution_condition", "timer"
                "evolution_timer", "99999.0"
                "evolution_power_threshold", "660000.0"
                "evolution_power_multiplier", "1.0"
                "combatradius", "0.0"
                "maxrange", "500"
                "effigy", "comeffigylvl4"
                "minimum_respawn_stun", "5.0"
                "distance_stun_multiplier", "1.0"
                "fall_damage_multiplier", "5.0"
            ]
          extras = Map.ofList [
                "autoheal", "5.0"
                "onoffable", "true"
                "cancapture", "true"
                "cancloak", "true"
                "canmanualfire", "true"
                "capturable", "false"
                "capturespeed", "1800.0"
                "cloakcost", "100.0"
                "cloakcostmoving", "1000.0"
                "damagemodifier", "0.1"
                "hidedamage", "true"
                "holdsteady", "true"
                "icontype", "corcom"
                "sightemitheight", "40.0"
                "mass", "4900.0"
                "mincloakdistance", "50.0"
                "nochasecategory", "ALL"
                "radardistance", "1500.0"
                "radaremitheight", "40.0"
                "reclaimable", "false"
                "selfdestructcountdown", "5.0"
                "showplayername", "true"
                "sonardistance", "600.0"
                "upright", "true"
            ] }

    let corcomlvl8Def : UnitDef =
        { name = "corcomlvl8"
          subfolder = "other/evocom"
          metalCost = ValueOrExpr.Concrete 9000.0
          energyCost = ValueOrExpr.Concrete 90000.0
          buildTime = ValueOrExpr.Concrete 230000.0
          health = ValueOrExpr.Concrete 16000.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORCOMHILVL.s3o"
          buildPic = Some "CORCOM.DDS"
          script = Some "Units/CORCOMHILVL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "commanderexplosion"
          selfDestructAs = Some "commanderExplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 43.5
              maxAcc = 0.18
              maxDec = 1.125
              turnRate = 1133.0
              movementClass = Some "COMMANDERBOT"
              maxSlope = Some 20.0
              maxWaterDepth = Some 35.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 140.0
              turnInPlaceSpeedLimit = Some 0.825
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 1200.0
              buildDistance = Some 201.0
              buildOptions = []
              terraformSpeed = Some 1500.0 })
          weapons = Some [
              { name = "corcomlaser"
                displayName = "Long range AoE flamethrower"
                weaponType = Some "Flame"
                damage = Map.ofList [
                    "default", 80.0
                    "subs", 25.0
                ]
                range = Some (ValueOrExpr.Concrete 475.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.39996)
                weaponVelocity = Some 500.0
                areaOfEffect = Some 128.0
                accuracy = Some 0.0
                turret = Some true
                tolerance = Some 20000.0
                edgeEffectiveness = Some 0.01
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "Flamhvy1"
                soundHit = None
                explosiongenerator = Some "custom:burnblackxl"
                rgbColor = Some "1 0.94 0.88"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_fastautoretargeting", "true"
                    "allowNonBlockingAim", "true"
                    "avoidfeature", "false"
                    "avoidfriendly", "true"
                    "burst", "12.0"
                    "burstrate", "0.03333"
                    "burnblow", "true"
                    "bouncerebound", "1.0"
                    "cegtag", "demonflame"
                    "colormap", "1 0.95 0.9 0.032   0.55 0.55 0.40 0.028   0.40 0.28 0.19 0.024   0.033 0.018 0.011 0.04   0.0 0.0 0.0 0.01"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "bounceSlip", "1.0"
                    "firestarter", "100.0"
                    "firesubmersed", "false"
                    "flameGFXTime", "1.0"
                    "intensity", "0.85"
                    "noexplode", "false"
                    "predictboost", "1.0"
                    "rgbcolor2", "0.9 0.84 0.8"
                    "sizegrowth", "1.1"
                    "soundhitdry", "flamhit1"
                    "soundhitwet", "sizzle"
                    "soundhitvolume", "9.5"
                    "soundstartvolume", "7.3"
                    "soundtrigger", "false"
                    "waterweapon", "false"
                ] }
              { name = "corcomsealaser"
                displayName = "UWSupernovaBeam"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 1400.0
                    "subs", 700.0
                ]
                range = Some (ValueOrExpr.Concrete 500.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.54)
                weaponVelocity = Some 700.0
                areaOfEffect = Some 70.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "uwlasrfir1"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-medium-blue"
                rgbColor = Some "0.1 0.2 0.7"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTAIR"
                    "avoidfeature", "false"
                    "beamtime", "0.16"
                    "camerashake", "0.0"
                    "corethickness", "0.5"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "firestarter", "90.0"
                    "firesubmersed", "true"
                    "intensity", "0.6"
                    "laserflaresize", "5.5"
                    "rgbcolor2", "0.9 0.9 0.9"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "3.5"
                    "waterweapon", "true"
                ] }
              { name = "disintegrator"
                displayName = "Disintegrator"
                weaponType = Some "DGun"
                damage = Map.ofList [
                    "commanders", 0.0
                    "default", 99999.0
                    "scavboss", 1000.0
                    "raptorqueen", 1000.0
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
                    "soundhitwet", "sizzlexs"
                    "soundhitvolume", "36.0"
                    "soundstartvolume", "96.0"
                    "soundtrigger", "true"
                    "waterweapon", "true"
                    "weapontimer", "4.2"
                ] }
              { name = "repulsor"
                displayName = "PlasmaRepulsor"
                weaponType = Some "Shield"
                damage = Map.ofList [
                    "default", 100.0
                ]
                range = Some (ValueOrExpr.Concrete 100.0)
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
              { name = "corcomeyelaser"
                displayName = "EyeLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 42.0
                ]
                range = Some (ValueOrExpr.Concrete 800.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.033)
                weaponVelocity = Some 900.0
                areaOfEffect = Some 50.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "heatray3burn"
                soundHit = None
                explosiongenerator = Some "custom:genericshellexplosion-medium-beam"
                rgbColor = Some "1 0.2 0.2"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "mount_fastautoretargeting", "true"
                    "allowNonBlockingAim", "true"
                    "avoidfeature", "false"
                    "beamtime", "0.033"
                    "camerashake", "0.1"
                    "collidefriendly", "false"
                    "corethickness", "0.3"
                    "craterareaofeffect", "72.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "0.0"
                    "firestarter", "90.0"
                    "firetolerance", "300.0"
                    "intensity", "5.0"
                    "laserflaresize", "6.0"
                    "proximitypriority", "1.0"
                    "rgbcolor2", "0.8 0.1 0.1"
                    "scrollspeed", "5.0"
                    "soundhitdry", "flamhit1"
                    "soundhitwet", "sizzle"
                    "soundstartvolume", "11.0"
                    "soundtrigger", "1.0"
                    "thickness", "4.5"
                ] }
              { name = "armcannon"
                displayName = "HeavyCannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 1050.0
                    "subs", 250.0
                    "vtol", 75.0
                ]
                range = Some (ValueOrExpr.Concrete 700.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.0)
                weaponVelocity = Some 310.0
                areaOfEffect = Some 210.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "largegun"
                soundHit = Some "xplomed4"
                explosiongenerator = Some "custom:genericshellexplosion-large-aoe"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_fastautoretargeting", "true"
                    "avoidfeature", "false"
                    "craterareaofeffect", "292.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splslrg"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 850.0)
              metalMake = Some (ValueOrExpr.Concrete 34.0)
              energyStorage = Some 5000.0
              metalStorage = Some 500.0
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "35 12 54"
                collisionVolumeType = Some "cylY"
                damage = Some 36000.0
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
          ])
          sounds = Some (
            { build = Some "nanlath2"
              repair = Some "repair2"
              working = Some "reclaim1"
              underAttack = Some "warning2"
              cancelDestruct = Some "cancel2"
              capture = Some "capture2"
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["corcom1"; "corcom2"; "corcom3"; "corcom4"; "corcom5"]
              select = ["corcomsel"] })
          customParams = Map.ofList [
              "unitgroup", "builder"
              "area_mex_def", "cormoho"
              "iscommander", "true"
              "effigy_offset", "1.0"
              "evocomlvl", "8.0"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "paralyzemultiplier", "0.025"
              "subfolder", ""
              "shield_color_mult", "0.8"
              "shield_power", "32300.0"
              "shield_radius", "100.0"
              "evolution_health_transfer", "percentage"
              "evolution_target", "corcomlvl9"
              "evolution_condition", "timer"
              "evolution_timer", "99999.0"
              "evolution_power_threshold", "660000.0"
              "evolution_power_multiplier", "1.0"
              "combatradius", "0.0"
              "maxrange", "500"
              "effigy", "comeffigylvl4"
              "minimum_respawn_stun", "5.0"
              "distance_stun_multiplier", "1.0"
              "fall_damage_multiplier", "5.0"
          ]
          extras = Map.ofList [
              "autoheal", "5.0"
              "onoffable", "true"
              "cancapture", "true"
              "cancloak", "true"
              "canmanualfire", "true"
              "capturable", "false"
              "capturespeed", "1800.0"
              "cloakcost", "100.0"
              "cloakcostmoving", "1000.0"
              "damagemodifier", "0.1"
              "hidedamage", "true"
              "holdsteady", "true"
              "icontype", "corcom"
              "sightemitheight", "40.0"
              "mass", "4900.0"
              "mincloakdistance", "50.0"
              "nochasecategory", "ALL"
              "radardistance", "1500.0"
              "radaremitheight", "40.0"
              "reclaimable", "false"
              "selfdestructcountdown", "5.0"
              "showplayername", "true"
              "sonardistance", "600.0"
              "upright", "true"
          ] }

    let corcomlvl8ToFlat (def: UnitDef) : Corcomlvl8 =
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
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          workerTime = def.builder.Value.workerTime
          buildDistance = def.builder.Value.buildDistance.Value
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyMake = def.economy.Value.energyMake.Value
          metalMake = def.economy.Value.metalMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corcomlvl8ToUnitDef (flat: Corcomlvl8) : UnitDef =
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
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = Some flat.movementClass
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = Some flat.buildDistance
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = Some flat.weapons
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = Some flat.metalMake
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corcomlvl9 =
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

    let corcomlvl9 : Corcomlvl9 =
        { name = "corcomlvl9"
          subfolder = "other/evocom"
          metalCost = ValueOrExpr.Concrete 10000.0
          energyCost = ValueOrExpr.Concrete 100000.0
          buildTime = ValueOrExpr.Concrete 240000.0
          health = ValueOrExpr.Concrete 18000.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORCOMHILVL.s3o"
          buildPic = Some "CORCOM.DDS"
          script = Some "Units/CORCOMHILVL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "commanderexplosion"
          selfDestructAs = Some "commanderExplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 45.0
          maxAcc = 0.18
          maxDec = 1.125
          turnRate = 1133.0
          movementClass = "COMMANDERBOT"
          maxSlope = 20.0
          maxWaterDepth = 35.0
          canMove = true
          turnInPlaceAngleLimit = 140.0
          turnInPlaceSpeedLimit = 0.825
          workerTime = ValueOrExpr.Concrete 1472.0
          buildDistance = 209.0
          buildOptions = []
          terraformSpeed = 1500.0
          energyMake = ValueOrExpr.Concrete 1375.0
          metalMake = ValueOrExpr.Concrete 42.0
          energyStorage = 7500.0
          metalStorage = 500.0
          weapons = [
                { name = "corcomlaser"
                  displayName = "Long range AoE flamethrower"
                  weaponType = Some "Flame"
                  damage = Map.ofList [
                      "default", 96.0
                      "subs", 38.0
                  ]
                  range = Some (ValueOrExpr.Concrete 475.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.39996)
                  weaponVelocity = Some 500.0
                  areaOfEffect = Some 128.0
                  accuracy = Some 0.0
                  turret = Some true
                  tolerance = Some 20000.0
                  edgeEffectiveness = Some 0.01
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "Flamhvy1"
                  soundHit = None
                  explosiongenerator = Some "custom:burnblackxl"
                  rgbColor = Some "1 0.94 0.88"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_fastautoretargeting", "true"
                      "allowNonBlockingAim", "true"
                      "avoidfeature", "false"
                      "avoidfriendly", "true"
                      "burst", "12.0"
                      "burstrate", "0.03333"
                      "burnblow", "true"
                      "bouncerebound", "1.0"
                      "cegtag", "demonflame"
                      "colormap", "1 0.95 0.9 0.032   0.55 0.55 0.40 0.028   0.40 0.28 0.19 0.024   0.033 0.018 0.011 0.04   0.0 0.0 0.0 0.01"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "bounceSlip", "1.0"
                      "firestarter", "100.0"
                      "firesubmersed", "false"
                      "flameGFXTime", "1.0"
                      "intensity", "0.85"
                      "noexplode", "false"
                      "predictboost", "1.0"
                      "rgbcolor2", "0.9 0.84 0.8"
                      "sizegrowth", "1.1"
                      "soundhitdry", "flamhit1"
                      "soundhitwet", "sizzle"
                      "soundhitvolume", "9.5"
                      "soundstartvolume", "7.3"
                      "soundtrigger", "false"
                      "waterweapon", "false"
                  ] }
                { name = "corcomsealaser"
                  displayName = "UWSupernovaBeam"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 1400.0
                      "subs", 700.0
                  ]
                  range = Some (ValueOrExpr.Concrete 500.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.46)
                  weaponVelocity = Some 700.0
                  areaOfEffect = Some 70.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "uwlasrfir1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-medium-blue"
                  rgbColor = Some "0.2 0.3 0.8"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTAIR"
                      "avoidfeature", "false"
                      "beamtime", "0.16"
                      "camerashake", "0.0"
                      "corethickness", "0.4"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "90.0"
                      "firesubmersed", "true"
                      "intensity", "0.6"
                      "laserflaresize", "5.5"
                      "rgbcolor2", "1 1 1"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "3.5"
                      "waterweapon", "true"
                  ] }
                { name = "disintegrator"
                  displayName = "Disintegrator"
                  weaponType = Some "DGun"
                  damage = Map.ofList [
                      "commanders", 0.0
                      "default", 99999.0
                      "scavboss", 1000.0
                      "raptorqueen", 1000.0
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
                      "soundhitwet", "sizzlexs"
                      "soundhitvolume", "36.0"
                      "soundstartvolume", "96.0"
                      "soundtrigger", "true"
                      "waterweapon", "true"
                      "weapontimer", "4.2"
                  ] }
                { name = "repulsor"
                  displayName = "PlasmaRepulsor"
                  weaponType = Some "Shield"
                  damage = Map.ofList [
                      "default", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 100.0)
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
                { name = "corcomeyelaser"
                  displayName = "EyeLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 58.0
                  ]
                  range = Some (ValueOrExpr.Concrete 870.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.033)
                  weaponVelocity = Some 1500.0
                  areaOfEffect = Some 72.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "heatray3burn"
                  soundHit = None
                  explosiongenerator = Some "custom:genericshellexplosion-medium-beam"
                  rgbColor = Some "1 0.8 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "mount_fastautoretargeting", "true"
                      "allowNonBlockingAim", "true"
                      "avoidfeature", "false"
                      "beamtime", "0.033"
                      "camerashake", "0.1"
                      "collidefriendly", "false"
                      "corethickness", "0.35"
                      "craterareaofeffect", "72.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "0.0"
                      "firestarter", "90.0"
                      "firetolerance", "300.0"
                      "laserflaresize", "8.0"
                      "proximitypriority", "1.0"
                      "rgbcolor2", "0.8 0 0"
                      "scrollspeed", "5.0"
                      "soundhitdry", "flamhit1"
                      "soundhitwet", "sizzle"
                      "soundstartvolume", "11.0"
                      "soundtrigger", "1.0"
                      "thickness", "4.5"
                  ] }
                { name = "armcannon"
                  displayName = "HeavyCannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 1350.0
                      "subs", 300.0
                      "vtol", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 750.0)
                  reloadTime = Some (ValueOrExpr.Concrete 3.0)
                  weaponVelocity = Some 310.0
                  areaOfEffect = Some 292.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "cannhvy2"
                  soundHit = Some "xplomed4"
                  explosiongenerator = Some "custom:genericshellexplosion-large-aoe"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_fastautoretargeting", "true"
                      "avoidfeature", "false"
                      "craterareaofeffect", "292.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "soundhitwet", "splslrg"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "35 12 54"
                  collisionVolumeType = Some "cylY"
                  damage = Some 40000.0
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
                "unitgroup", "builder"
                "area_mex_def", "cormoho"
                "iscommander", "true"
                "effigy_offset", "1.0"
                "evocomlvl", "9.0"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "paralyzemultiplier", "0.025"
                "subfolder", ""
                "shield_color_mult", "0.8"
                "shield_power", "43700.0"
                "shield_radius", "100.0"
                "evolution_health_transfer", "percentage"
                "evolution_target", "corcomlvl10"
                "evolution_condition", "timer"
                "evolution_timer", "99999.0"
                "evolution_power_threshold", "800000.0"
                "evolution_power_multiplier", "1.0"
                "combatradius", "0.0"
                "maxrange", "500"
                "effigy", "comeffigylvl5"
                "minimum_respawn_stun", "5.0"
                "distance_stun_multiplier", "1.0"
                "fall_damage_multiplier", "5.0"
            ]
          extras = Map.ofList [
                "autoheal", "5.0"
                "onoffable", "true"
                "cancapture", "true"
                "cancloak", "true"
                "canmanualfire", "true"
                "capturable", "false"
                "capturespeed", "1800.0"
                "cloakcost", "100.0"
                "cloakcostmoving", "1000.0"
                "damagemodifier", "0.1"
                "hidedamage", "true"
                "holdsteady", "true"
                "icontype", "corcom"
                "sightemitheight", "40.0"
                "mass", "4900.0"
                "mincloakdistance", "50.0"
                "nochasecategory", "ALL"
                "radardistance", "1500.0"
                "radaremitheight", "40.0"
                "reclaimable", "false"
                "selfdestructcountdown", "5.0"
                "showplayername", "true"
                "sonardistance", "600.0"
                "upright", "true"
            ] }

    let corcomlvl9Def : UnitDef =
        { name = "corcomlvl9"
          subfolder = "other/evocom"
          metalCost = ValueOrExpr.Concrete 10000.0
          energyCost = ValueOrExpr.Concrete 100000.0
          buildTime = ValueOrExpr.Concrete 240000.0
          health = ValueOrExpr.Concrete 18000.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORCOMHILVL.s3o"
          buildPic = Some "CORCOM.DDS"
          script = Some "Units/CORCOMHILVL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "commanderexplosion"
          selfDestructAs = Some "commanderExplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 45.0
              maxAcc = 0.18
              maxDec = 1.125
              turnRate = 1133.0
              movementClass = Some "COMMANDERBOT"
              maxSlope = Some 20.0
              maxWaterDepth = Some 35.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 140.0
              turnInPlaceSpeedLimit = Some 0.825
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 1472.0
              buildDistance = Some 209.0
              buildOptions = []
              terraformSpeed = Some 1500.0 })
          weapons = Some [
              { name = "corcomlaser"
                displayName = "Long range AoE flamethrower"
                weaponType = Some "Flame"
                damage = Map.ofList [
                    "default", 96.0
                    "subs", 38.0
                ]
                range = Some (ValueOrExpr.Concrete 475.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.39996)
                weaponVelocity = Some 500.0
                areaOfEffect = Some 128.0
                accuracy = Some 0.0
                turret = Some true
                tolerance = Some 20000.0
                edgeEffectiveness = Some 0.01
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "Flamhvy1"
                soundHit = None
                explosiongenerator = Some "custom:burnblackxl"
                rgbColor = Some "1 0.94 0.88"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_fastautoretargeting", "true"
                    "allowNonBlockingAim", "true"
                    "avoidfeature", "false"
                    "avoidfriendly", "true"
                    "burst", "12.0"
                    "burstrate", "0.03333"
                    "burnblow", "true"
                    "bouncerebound", "1.0"
                    "cegtag", "demonflame"
                    "colormap", "1 0.95 0.9 0.032   0.55 0.55 0.40 0.028   0.40 0.28 0.19 0.024   0.033 0.018 0.011 0.04   0.0 0.0 0.0 0.01"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "bounceSlip", "1.0"
                    "firestarter", "100.0"
                    "firesubmersed", "false"
                    "flameGFXTime", "1.0"
                    "intensity", "0.85"
                    "noexplode", "false"
                    "predictboost", "1.0"
                    "rgbcolor2", "0.9 0.84 0.8"
                    "sizegrowth", "1.1"
                    "soundhitdry", "flamhit1"
                    "soundhitwet", "sizzle"
                    "soundhitvolume", "9.5"
                    "soundstartvolume", "7.3"
                    "soundtrigger", "false"
                    "waterweapon", "false"
                ] }
              { name = "corcomsealaser"
                displayName = "UWSupernovaBeam"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 1400.0
                    "subs", 700.0
                ]
                range = Some (ValueOrExpr.Concrete 500.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.46)
                weaponVelocity = Some 700.0
                areaOfEffect = Some 70.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "uwlasrfir1"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-medium-blue"
                rgbColor = Some "0.2 0.3 0.8"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTAIR"
                    "avoidfeature", "false"
                    "beamtime", "0.16"
                    "camerashake", "0.0"
                    "corethickness", "0.4"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "firestarter", "90.0"
                    "firesubmersed", "true"
                    "intensity", "0.6"
                    "laserflaresize", "5.5"
                    "rgbcolor2", "1 1 1"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "3.5"
                    "waterweapon", "true"
                ] }
              { name = "disintegrator"
                displayName = "Disintegrator"
                weaponType = Some "DGun"
                damage = Map.ofList [
                    "commanders", 0.0
                    "default", 99999.0
                    "scavboss", 1000.0
                    "raptorqueen", 1000.0
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
                    "soundhitwet", "sizzlexs"
                    "soundhitvolume", "36.0"
                    "soundstartvolume", "96.0"
                    "soundtrigger", "true"
                    "waterweapon", "true"
                    "weapontimer", "4.2"
                ] }
              { name = "repulsor"
                displayName = "PlasmaRepulsor"
                weaponType = Some "Shield"
                damage = Map.ofList [
                    "default", 100.0
                ]
                range = Some (ValueOrExpr.Concrete 100.0)
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
              { name = "corcomeyelaser"
                displayName = "EyeLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 58.0
                ]
                range = Some (ValueOrExpr.Concrete 870.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.033)
                weaponVelocity = Some 1500.0
                areaOfEffect = Some 72.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "heatray3burn"
                soundHit = None
                explosiongenerator = Some "custom:genericshellexplosion-medium-beam"
                rgbColor = Some "1 0.8 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "mount_fastautoretargeting", "true"
                    "allowNonBlockingAim", "true"
                    "avoidfeature", "false"
                    "beamtime", "0.033"
                    "camerashake", "0.1"
                    "collidefriendly", "false"
                    "corethickness", "0.35"
                    "craterareaofeffect", "72.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "0.0"
                    "firestarter", "90.0"
                    "firetolerance", "300.0"
                    "laserflaresize", "8.0"
                    "proximitypriority", "1.0"
                    "rgbcolor2", "0.8 0 0"
                    "scrollspeed", "5.0"
                    "soundhitdry", "flamhit1"
                    "soundhitwet", "sizzle"
                    "soundstartvolume", "11.0"
                    "soundtrigger", "1.0"
                    "thickness", "4.5"
                ] }
              { name = "armcannon"
                displayName = "HeavyCannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 1350.0
                    "subs", 300.0
                    "vtol", 100.0
                ]
                range = Some (ValueOrExpr.Concrete 750.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.0)
                weaponVelocity = Some 310.0
                areaOfEffect = Some 292.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "cannhvy2"
                soundHit = Some "xplomed4"
                explosiongenerator = Some "custom:genericshellexplosion-large-aoe"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_fastautoretargeting", "true"
                    "avoidfeature", "false"
                    "craterareaofeffect", "292.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splslrg"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 1375.0)
              metalMake = Some (ValueOrExpr.Concrete 42.0)
              energyStorage = Some 7500.0
              metalStorage = Some 500.0
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "35 12 54"
                collisionVolumeType = Some "cylY"
                damage = Some 40000.0
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
          ])
          sounds = Some (
            { build = Some "nanlath2"
              repair = Some "repair2"
              working = Some "reclaim1"
              underAttack = Some "warning2"
              cancelDestruct = Some "cancel2"
              capture = Some "capture2"
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["corcom1"; "corcom2"; "corcom3"; "corcom4"; "corcom5"]
              select = ["corcomsel"] })
          customParams = Map.ofList [
              "unitgroup", "builder"
              "area_mex_def", "cormoho"
              "iscommander", "true"
              "effigy_offset", "1.0"
              "evocomlvl", "9.0"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "paralyzemultiplier", "0.025"
              "subfolder", ""
              "shield_color_mult", "0.8"
              "shield_power", "43700.0"
              "shield_radius", "100.0"
              "evolution_health_transfer", "percentage"
              "evolution_target", "corcomlvl10"
              "evolution_condition", "timer"
              "evolution_timer", "99999.0"
              "evolution_power_threshold", "800000.0"
              "evolution_power_multiplier", "1.0"
              "combatradius", "0.0"
              "maxrange", "500"
              "effigy", "comeffigylvl5"
              "minimum_respawn_stun", "5.0"
              "distance_stun_multiplier", "1.0"
              "fall_damage_multiplier", "5.0"
          ]
          extras = Map.ofList [
              "autoheal", "5.0"
              "onoffable", "true"
              "cancapture", "true"
              "cancloak", "true"
              "canmanualfire", "true"
              "capturable", "false"
              "capturespeed", "1800.0"
              "cloakcost", "100.0"
              "cloakcostmoving", "1000.0"
              "damagemodifier", "0.1"
              "hidedamage", "true"
              "holdsteady", "true"
              "icontype", "corcom"
              "sightemitheight", "40.0"
              "mass", "4900.0"
              "mincloakdistance", "50.0"
              "nochasecategory", "ALL"
              "radardistance", "1500.0"
              "radaremitheight", "40.0"
              "reclaimable", "false"
              "selfdestructcountdown", "5.0"
              "showplayername", "true"
              "sonardistance", "600.0"
              "upright", "true"
          ] }

    let corcomlvl9ToFlat (def: UnitDef) : Corcomlvl9 =
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
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          workerTime = def.builder.Value.workerTime
          buildDistance = def.builder.Value.buildDistance.Value
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyMake = def.economy.Value.energyMake.Value
          metalMake = def.economy.Value.metalMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corcomlvl9ToUnitDef (flat: Corcomlvl9) : UnitDef =
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
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = Some flat.movementClass
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = Some flat.buildDistance
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = Some flat.weapons
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = Some flat.metalMake
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

