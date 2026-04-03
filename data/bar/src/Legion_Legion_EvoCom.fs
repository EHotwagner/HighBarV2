// Auto-generated BAR unit data: Legion/Legion EvoCom
namespace BarData.Units

open BarData

module Legion_Legion_EvoCom =

    let legcomlvl10 : UnitDef =
        { name = "legcomlvl10"
          subfolder = "Legion/Legion EvoCom"
          metalCost = ValueOrExpr.Concrete 11000.0
          energyCost = ValueOrExpr.Concrete 110000.0
          buildTime = ValueOrExpr.Concrete 264000.0
          health = ValueOrExpr.Concrete 22000.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/legevocom3.s3o"
          buildPic = Some "LEGCOM.DDS"
          script = Some "Units/legevocom3.cob"
          corpse = Some "DEAD"
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderexplosion"
          collisionVolumeOffsets = Some "0 4 0"
          collisionVolumeScales = Some "37 69 37"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 49.5
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
            { workerTime = ValueOrExpr.Concrete 1796.0
              buildDistance = Some 600.0
              buildOptions = []
              terraformSpeed = Some 1500.0 })
          weapons = Some [
              { name = "armmg_weapon"
                displayName = Some "Rapid-Fire Plasma Cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 500.0
                    "vtol", 250.0
                ]
                range = Some (ValueOrExpr.Concrete 500.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.3)
                weaponVelocity = Some 600.0
                areaOfEffect = Some 110.0
                accuracy = Some 100.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 1.8
                noSelfDamage = Some true
                soundStart = Some "cannon3"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:genericshellexplosion-small-t2"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "mount_fastautoretargeting", "true"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "burst", "2.0"
                    "burstrate", "0.15"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splssml"
                    "sprayangle", "500.0"
                ] }
              { name = "torpedo"
                displayName = Some "MK-X Torpedo Launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 400.0
                    "subs", 200.0
                ]
                range = Some (ValueOrExpr.Concrete 600.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.8)
                weaponVelocity = Some 425.0
                areaOfEffect = Some 75.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.55
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "torpedo1"
                soundHit = Some "xplodep2"
                explosiongenerator = Some "custom:genericshellexplosion-small-uw"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTAIR"
                    "avoidfeature", "false"
                    "avoidfriendly", "true"
                    "burnblow", "true"
                    "burst", "4.0"
                    "burstrate", "0.15"
                    "cegtag", "torpedotrail-tiny"
                    "collidefriendly", "true"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "flighttime", "1.8"
                    "model", "legtorpedo.s3o"
                    "predictboost", "1.0"
                    "startvelocity", "230.0"
                    "tracks", "false"
                    "turnrate", "2500.0"
                    "waterweapon", "true"
                    "weaponacceleration", "50.0"
                    "weapontimer", "3.0"
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
                    "soundhitwet", "sizzlexs"
                    "soundhitvolume", "36.0"
                    "soundstartvolume", "96.0"
                    "soundtrigger", "true"
                    "waterweapon", "true"
                    "weapontimer", "4.2"
                ] }
              { name = "railgunt2"
                displayName = Some "Railgun"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 500.0
                ]
                range = Some (ValueOrExpr.Concrete 950.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.0)
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
                rgbColor = Some "0.74 0.64 0.94"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "burnblow", "false"
                    "burst", "4.0"
                    "burstrate", "0.12"
                    "cegtag", "railgun"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.12"
                    "fallOffRate", "0.2"
                    "firestarter", "0.0"
                    "intensity", "0.8"
                    "minintensity", "1.0"
                    "ownerExpAccWeight", "4.0"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "26.0"
                    "thickness", "3.0"
                ] }
              { name = "botcannon"
                displayName = Some "Long range bot cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                    "shields", 250.0
                ]
                range = Some (ValueOrExpr.Concrete 700.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.9)
                weaponVelocity = Some 2000.0
                areaOfEffect = Some 10.0
                accuracy = Some 0.2
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.5
                noSelfDamage = Some true
                soundStart = Some "lrpcshot3"
                soundHit = Some "xplonuk1xs"
                explosiongenerator = Some "custom:botrailspawn"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "spawns_name", "babylegshot babylegheavydrone babylegdrone babylegdrone babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob"
                    "spawns_surface", "LAND"
                    "spawns_mode", "random"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT SHIP"
                    "mount_onlytargetcategory", "NOTSHIP"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burst", "9.0"
                    "burstrate", "0.025"
                    "collidefriendly", "false"
                    "craterareaofeffect", "116.0"
                    "craterboost", "0.1"
                    "cratermult", "0.1"
                    "energypershot", "5400.0"
                    "gravityaffected", "true"
                    "heightboostfactor", "8.0"
                    "hightrajectory", "1.0"
                    "leadbonus", "0.0"
                    "model", "LegionUnitCapsule.s3o"
                    "movingaccuracy", "600.0"
                    "mygravity", "4.8"
                    "projectiles", "2.0"
                    "sprayangle", "2800.0"
                    "stockpile", "true"
                    "stockpiletime", "10.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "50.0"
                    "trajectoryheight", "1.0"
                    "waterbounce", "true"
                    "bounceSlip", "0.74"
                    "bouncerebound", "0.5"
                    "numbounce", "10.0"
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
                collisionVolumeScales = Some "47 10 47"
                collisionVolumeType = Some "CylY"
                damage = Some 44000.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 3500.0
                object_ = Some "Units/legcom_dead.s3o"
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
                metal = Some 1750.0
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
              "area_mex_def", "legmex"
              "iscommander", "true"
              "effigy_offset", "1.0"
              "evocomlvl", "10.0"
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "paralyzemultiplier", "0.025"
              "subfolder", ""
              "workertimeboost", "6.0"
              "wtboostunittype", "MOBILE"
              "inheritxpratemultiplier", "0.25"
              "childreninheritxp", "DRONE BOTCANNON"
              "parentsinheritxp", "MOBILEBUILT DRONE BOTCANNON"
              "respawn_announcement", "A Commander Effigy was sacrificed."
              "effigy", "comeffigylvl5"
              "minimum_respawn_stun", "5.0"
              "distance_stun_multiplier", "1.0"
              "fall_damage_multiplier", "5.0"
          ]
          extras = Map.ofList [
              "autoheal", "40.0"
              "cancloak", "true"
              "cloakcost", "100.0"
              "cloakcostmoving", "1000.0"
              "cancapture", "true"
              "canmanualfire", "true"
              "capturable", "false"
              "capturespeed", "1800.0"
              "hidedamage", "true"
              "holdsteady", "true"
              "icontype", "legcomlvl4"
              "sightemitheight", "40.0"
              "mass", "4900.0"
              "mincloakdistance", "50.0"
              "nochasecategory", "ALL"
              "pushresistant", "Spring.GetModOptions().pushresistant"
              "radardistance", "1200.0"
              "radaremitheight", "54.0"
              "reclaimable", "false"
              "reclaimspeed", "5388.0"
              "releaseheld", "true"
              "selfdestructcountdown", "5.0"
              "showplayername", "true"
              "sonardistance", "600.0"
              "upright", "true"
          ] }

    let legcomlvl2 : UnitDef =
        { name = "legcomlvl2"
          subfolder = "Legion/Legion EvoCom"
          metalCost = ValueOrExpr.Concrete 3000.0
          energyCost = ValueOrExpr.Concrete 30000.0
          buildTime = ValueOrExpr.Concrete 112500.0
          health = ValueOrExpr.Concrete 6000.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/legevocom1.s3o"
          buildPic = Some "LEGCOM.DDS"
          script = Some "Units/legevocom1.cob"
          corpse = Some "DEAD"
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderexplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "31 57 31"
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
            { workerTime = ValueOrExpr.Concrete 350.0
              buildDistance = Some 250.0
              buildOptions = []
              terraformSpeed = Some 1500.0 })
          weapons = Some [
              { name = "armmg_weapon"
                displayName = Some "Rapid-Fire Machine Gun"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 25.0
                ]
                range = Some (ValueOrExpr.Concrete 300.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.4)
                weaponVelocity = Some 950.0
                areaOfEffect = Some 16.0
                accuracy = Some 7.0
                turret = Some true
                tolerance = Some 6000.0
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 1.5
                noSelfDamage = Some true
                soundStart = Some "mgun6"
                soundHit = Some "bimpact3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "1 0.95 0.4"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "burst", "6.0"
                    "burstrate", "0.066"
                    "burnblow", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.03"
                    "fallOffRate", "0.2"
                    "firestarter", "0.0"
                    "intensity", "0.8"
                    "minintensity", "1.0"
                    "ownerExpAccWeight", "4.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "4.5"
                    "soundtrigger", "true"
                    "sprayangle", "968.0"
                    "texture1", "shot"
                    "texture2", "empty"
                    "thickness", "3.0"
                ] }
              { name = "torpedo"
                displayName = Some "MK-II Torpedo Launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 250.0
                    "subs", 125.0
                ]
                range = Some (ValueOrExpr.Concrete 350.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.6)
                weaponVelocity = Some 200.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.55
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "torpedo1"
                soundHit = Some "xplodep2"
                explosiongenerator = Some "custom:genericshellexplosion-small-uw"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTAIR"
                    "avoidfeature", "false"
                    "avoidfriendly", "true"
                    "burnblow", "true"
                    "cegtag", "torpedotrail-tiny"
                    "collidefriendly", "true"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "flighttime", "1.8"
                    "model", "legtorpedo.s3o"
                    "predictboost", "1.0"
                    "startvelocity", "230.0"
                    "tracks", "false"
                    "turnrate", "2500.0"
                    "waterweapon", "true"
                    "weaponacceleration", "50.0"
                    "weapontimer", "3.0"
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
                    "soundhitwet", "sizzlexs"
                    "soundhitvolume", "36.0"
                    "soundstartvolume", "96.0"
                    "soundtrigger", "true"
                    "waterweapon", "true"
                    "weapontimer", "4.2"
                ] }
              { name = "aa_missile"
                displayName = Some "Anti Air Missile Launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 150.0
                    "commanders", 1.0
                ]
                range = Some (ValueOrExpr.Concrete 450.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.2)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = Some 9950.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "packolau"
                soundHit = Some "packohit"
                explosiongenerator = Some "custom:genericshellexplosion-tiny-aa"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "cegtag", "missiletrailaa"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "0.0"
                    "firestarter", "72.0"
                    "flighttime", "2.5"
                    "metalpershot", "0.0"
                    "model", "legsmallrocket.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "6.0"
                    "smoketime", "12.0"
                    "smokesize", "4.6"
                    "smokecolor", "0.95"
                    "smokeTrailCastShadow", "false"
                    "castshadow", "false"
                    "soundhitwet", "splshbig"
                    "soundtrigger", "true"
                    "startvelocity", "1.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa3"
                    "tracks", "true"
                    "turnrate", "68000.0"
                    "weaponacceleration", "1200.0"
                    "weapontimer", "2.0"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 25.0)
              metalMake = Some (ValueOrExpr.Concrete 2.0)
              energyStorage = Some 1000.0
              metalStorage = Some 500.0
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
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
                object_ = Some "Units/legcom_dead.s3o"
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
              "iscommander", "true"
              "effigy_offset", "1.0"
              "evocomlvl", "2.0"
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "paralyzemultiplier", "0.025"
              "subfolder", ""
              "evolution_health_transfer", "percentage"
              "evolution_target", "legcomlvl3"
              "evolution_condition", "timer"
              "evolution_timer", "99999.0"
              "evolution_power_threshold", "22000.0"
              "evolution_power_multiplier", "1.0"
              "combatradius", "0.0"
              "workertimeboost", "3.0"
              "wtboostunittype", "MOBILE"
              "effigy", "comeffigylvl1"
              "minimum_respawn_stun", "5.0"
              "distance_stun_multiplier", "1.0"
              "fall_damage_multiplier", "5.0"
          ]
          extras = Map.ofList [
              "autoheal", "5.0"
              "cancapture", "true"
              "cancloak", "true"
              "cloakcost", "100.0"
              "cloakcostmoving", "1000.0"
              "canmanualfire", "true"
              "capturable", "false"
              "capturespeed", "2100.0"
              "hidedamage", "true"
              "holdsteady", "true"
              "sightemitheight", "40.0"
              "mass", "4999.0"
              "mincloakdistance", "50.0"
              "nochasecategory", "ALL"
              "pushresistant", "Spring.GetModOptions().pushresistant"
              "radardistance", "800.0"
              "radaremitheight", "44.0"
              "reclaimable", "false"
              "releaseheld", "true"
              "selfdestructcountdown", "5.0"
              "showplayername", "true"
              "sonardistance", "500.0"
              "upright", "true"
          ] }

    let legcomlvl3 : UnitDef =
        { name = "legcomlvl3"
          subfolder = "Legion/Legion EvoCom"
          metalCost = ValueOrExpr.Concrete 4000.0
          energyCost = ValueOrExpr.Concrete 40000.0
          buildTime = ValueOrExpr.Concrete 150000.0
          health = ValueOrExpr.Concrete 8000.0
          sightDistance = ValueOrExpr.Concrete 550.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/legevocom1.s3o"
          buildPic = Some "LEGCOM.DDS"
          script = Some "Units/legevocom1.cob"
          corpse = Some "DEAD"
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderexplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "34 63 34"
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
            { workerTime = ValueOrExpr.Concrete 400.0
              buildDistance = Some 175.0
              buildOptions = []
              terraformSpeed = Some 1500.0 })
          weapons = Some [
              { name = "armmg_weapon"
                displayName = Some "Rapid-Fire Machine Gun"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 30.0
                ]
                range = Some (ValueOrExpr.Concrete 350.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.4)
                weaponVelocity = Some 921.0
                areaOfEffect = Some 16.0
                accuracy = Some 7.0
                turret = Some true
                tolerance = Some 6000.0
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 1.5
                noSelfDamage = Some true
                soundStart = Some "mgun6"
                soundHit = Some "bimpact3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "1 0.95 0.4"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "burst", "6.0"
                    "burstrate", "0.066"
                    "burnblow", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.035"
                    "fallOffRate", "0.2"
                    "firestarter", "0.0"
                    "intensity", "0.8"
                    "minintensity", "1.0"
                    "ownerExpAccWeight", "4.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "4.5"
                    "soundtrigger", "true"
                    "sprayangle", "968.0"
                    "texture1", "shot"
                    "texture2", "empty"
                    "thickness", "3.0"
                ] }
              { name = "torpedo"
                displayName = Some "MK-III Torpedo Launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 250.0
                    "subs", 125.0
                ]
                range = Some (ValueOrExpr.Concrete 500.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.2)
                weaponVelocity = Some 425.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.55
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "torpedo1"
                soundHit = Some "xplodep2"
                explosiongenerator = Some "custom:genericshellexplosion-small-uw"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTAIR"
                    "avoidfeature", "false"
                    "avoidfriendly", "true"
                    "burnblow", "true"
                    "cegtag", "torpedotrail-tiny"
                    "collidefriendly", "true"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "flighttime", "1.8"
                    "model", "legtorpedo.s3o"
                    "predictboost", "1.0"
                    "startvelocity", "230.0"
                    "tracks", "false"
                    "turnrate", "2500.0"
                    "waterweapon", "true"
                    "weaponacceleration", "50.0"
                    "weapontimer", "3.0"
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
                    "soundhitwet", "sizzlexs"
                    "soundhitvolume", "36.0"
                    "soundstartvolume", "96.0"
                    "soundtrigger", "true"
                    "waterweapon", "true"
                    "weapontimer", "4.2"
                ] }
              { name = "aa_missile"
                displayName = Some "Anti Air Missile Launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 150.0
                    "commanders", 1.0
                ]
                range = Some (ValueOrExpr.Concrete 400.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.2)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = Some 9950.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "packolau"
                soundHit = Some "packohit"
                explosiongenerator = Some "custom:genericshellexplosion-tiny-aa"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "cegtag", "missiletrailaa"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "0.0"
                    "firestarter", "72.0"
                    "flighttime", "2.5"
                    "metalpershot", "0.0"
                    "model", "legsmallrocket.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "6.0"
                    "smoketime", "12.0"
                    "smokesize", "4.6"
                    "smokecolor", "0.95"
                    "smokeTrailCastShadow", "false"
                    "castshadow", "false"
                    "soundhitwet", "splshbig"
                    "soundtrigger", "true"
                    "startvelocity", "1.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa3"
                    "tracks", "true"
                    "turnrate", "68000.0"
                    "weaponacceleration", "1200.0"
                    "weapontimer", "2.0"
                ] }
              { name = "botcannon"
                displayName = Some "Long range bot cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                    "shields", 250.0
                ]
                range = Some (ValueOrExpr.Concrete 400.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.9)
                weaponVelocity = Some 2000.0
                areaOfEffect = Some 10.0
                accuracy = Some 0.2
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.5
                noSelfDamage = Some true
                soundStart = Some "lrpcshot3"
                soundHit = Some "xplonuk1xs"
                explosiongenerator = Some "custom:botrailspawn"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "spawns_name", "babyleggob babyleggob babyleggob babyleggob babyleggob babyleggob babyleggob babyleggob babyleggob babyleggob babyleggob babyleggob babyleggob babyleggob babyleggob babyleglob babyleglob babyleglob babyleglob babyleglob"
                    "spawns_surface", "LAND"
                    "spawns_mode", "random"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT SHIP"
                    "mount_onlytargetcategory", "NOTSHIP"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burst", "3.0"
                    "burstrate", "0.1"
                    "collidefriendly", "false"
                    "craterareaofeffect", "116.0"
                    "craterboost", "0.1"
                    "cratermult", "0.1"
                    "energypershot", "900.0"
                    "gravityaffected", "true"
                    "heightboostfactor", "8.0"
                    "hightrajectory", "1.0"
                    "leadbonus", "0.0"
                    "model", "LegionUnitCapsule.s3o"
                    "movingaccuracy", "600.0"
                    "mygravity", "4.8"
                    "sprayangle", "2800.0"
                    "stockpile", "true"
                    "stockpiletime", "13.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "50.0"
                    "trajectoryheight", "1.0"
                    "waterbounce", "true"
                    "bounceSlip", "0.74"
                    "bouncerebound", "0.5"
                    "numbounce", "10.0"
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
                collisionVolumeScales = Some "47 10 47"
                collisionVolumeType = Some "CylY"
                damage = Some 10000.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 2750.0
                object_ = Some "Units/legcom_dead.s3o"
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
                metal = Some 1375.0
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
              "iscommander", "true"
              "effigy_offset", "1.0"
              "evocomlvl", "3.0"
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "paralyzemultiplier", "0.025"
              "subfolder", ""
              "workertimeboost", "3.0"
              "wtboostunittype", "MOBILE"
              "evolution_health_transfer", "percentage"
              "evolution_target", "legcomlvl4"
              "evolution_condition", "timer"
              "evolution_timer", "99999.0"
              "evolution_power_threshold", "53000.0"
              "evolution_power_multiplier", "1.0"
              "combatradius", "0.0"
              "inheritxpratemultiplier", "0.25"
              "childreninheritxp", "DRONE BOTCANNON"
              "parentsinheritxp", "MOBILEBUILT DRONE BOTCANNON"
              "effigy", "comeffigylvl2"
              "minimum_respawn_stun", "5.0"
              "distance_stun_multiplier", "1.0"
              "fall_damage_multiplier", "5.0"
          ]
          extras = Map.ofList [
              "autoheal", "5.0"
              "cancapture", "true"
              "cancloak", "true"
              "cloakcost", "100.0"
              "cloakcostmoving", "1000.0"
              "canmanualfire", "true"
              "capturable", "false"
              "capturespeed", "1800.0"
              "hidedamage", "true"
              "holdsteady", "true"
              "sightemitheight", "40.0"
              "mass", "4900.0"
              "mincloakdistance", "50.0"
              "nochasecategory", "ALL"
              "pushresistant", "Spring.GetModOptions().pushresistant"
              "radardistance", "900.0"
              "radaremitheight", "49.0"
              "reclaimable", "false"
              "releaseheld", "true"
              "selfdestructcountdown", "5.0"
              "showplayername", "true"
              "sonardistance", "550.0"
              "upright", "true"
          ] }

    let legcomlvl4 : UnitDef =
        { name = "legcomlvl4"
          subfolder = "Legion/Legion EvoCom"
          metalCost = ValueOrExpr.Concrete 5000.0
          energyCost = ValueOrExpr.Concrete 50000.0
          buildTime = ValueOrExpr.Concrete 187500.0
          health = ValueOrExpr.Concrete 10000.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/legevocom2.s3o"
          buildPic = Some "LEGCOM.DDS"
          script = Some "Units/legevocom2.cob"
          corpse = Some "DEAD"
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderexplosion"
          collisionVolumeOffsets = Some "0 4 0"
          collisionVolumeScales = Some "37 69 37"
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
            { workerTime = ValueOrExpr.Concrete 500.0
              buildDistance = Some 350.0
              buildOptions = []
              terraformSpeed = Some 1500.0 })
          weapons = Some [
              { name = "armmg_weapon"
                displayName = Some "Rapid-Fire Machine Gun"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 40.0
                ]
                range = Some (ValueOrExpr.Concrete 350.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.4)
                weaponVelocity = Some 999.0
                areaOfEffect = Some 16.0
                accuracy = Some 7.0
                turret = Some true
                tolerance = Some 6000.0
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 1.5
                noSelfDamage = Some true
                soundStart = Some "mgun6heavy"
                soundHit = Some "bimpact3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "1 0.95 0.4"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "burst", "6.0"
                    "burstrate", "0.066"
                    "burnblow", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.04"
                    "fallOffRate", "0.2"
                    "firestarter", "0.0"
                    "intensity", "0.8"
                    "minintensity", "1.0"
                    "ownerExpAccWeight", "4.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "4.5"
                    "soundtrigger", "true"
                    "sprayangle", "968.0"
                    "texture1", "shot"
                    "texture2", "empty"
                    "thickness", "3.0"
                ] }
              { name = "torpedo"
                displayName = Some "MK-IV Torpedo Launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 250.0
                    "subs", 125.0
                ]
                range = Some (ValueOrExpr.Concrete 450.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.8)
                weaponVelocity = Some 200.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.55
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "torpedo1"
                soundHit = Some "xplodep2"
                explosiongenerator = Some "custom:genericshellexplosion-small-uw"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTAIR"
                    "avoidfeature", "false"
                    "avoidfriendly", "true"
                    "burnblow", "true"
                    "cegtag", "torpedotrail-tiny"
                    "collidefriendly", "true"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "flighttime", "1.8"
                    "model", "legtorpedo.s3o"
                    "predictboost", "1.0"
                    "startvelocity", "230.0"
                    "tracks", "false"
                    "turnrate", "2500.0"
                    "waterweapon", "true"
                    "weaponacceleration", "50.0"
                    "weapontimer", "3.0"
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
                    "soundhitwet", "sizzlexs"
                    "soundhitvolume", "36.0"
                    "soundstartvolume", "96.0"
                    "soundtrigger", "true"
                    "waterweapon", "true"
                    "weapontimer", "4.2"
                ] }
              { name = "railgunt2"
                displayName = Some "Railgun"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 250.0
                ]
                range = Some (ValueOrExpr.Concrete 550.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.7)
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
                rgbColor = Some "0.74 0.64 0.94"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "burnblow", "false"
                    "cegtag", "railgun"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.12"
                    "fallOffRate", "0.2"
                    "firestarter", "0.0"
                    "intensity", "0.8"
                    "minintensity", "1.0"
                    "ownerExpAccWeight", "4.0"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "26.0"
                    "thickness", "3.0"
                ] }
              { name = "botcannon"
                displayName = Some "Long range bot cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                    "shields", 250.0
                ]
                range = Some (ValueOrExpr.Concrete 500.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.9)
                weaponVelocity = Some 2000.0
                areaOfEffect = Some 10.0
                accuracy = Some 0.2
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.5
                noSelfDamage = Some true
                soundStart = Some "lrpcshot3"
                soundHit = Some "xplonuk1xs"
                explosiongenerator = Some "custom:botrailspawn"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "spawns_name", "babylegdrone babyleggob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob"
                    "spawns_surface", "LAND"
                    "spawns_mode", "random"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT SHIP"
                    "mount_onlytargetcategory", "NOTSHIP"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burst", "4.0"
                    "burstrate", "0.1"
                    "collidefriendly", "false"
                    "craterareaofeffect", "116.0"
                    "craterboost", "0.1"
                    "cratermult", "0.1"
                    "energypershot", "1200.0"
                    "gravityaffected", "true"
                    "heightboostfactor", "8.0"
                    "hightrajectory", "1.0"
                    "leadbonus", "0.0"
                    "model", "LegionUnitCapsule.s3o"
                    "movingaccuracy", "600.0"
                    "mygravity", "4.8"
                    "sprayangle", "2800.0"
                    "stockpile", "true"
                    "stockpiletime", "12.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "50.0"
                    "trajectoryheight", "1.0"
                    "waterbounce", "true"
                    "bounceSlip", "0.74"
                    "bouncerebound", "0.5"
                    "numbounce", "10.0"
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
                collisionVolumeScales = Some "47 10 47"
                collisionVolumeType = Some "CylY"
                damage = Some 10000.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 3500.0
                object_ = Some "Units/legcom_dead.s3o"
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
                metal = Some 1750.0
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
              "iscommander", "true"
              "effigy_offset", "1.0"
              "evocomlvl", "4.0"
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "paralyzemultiplier", "0.025"
              "subfolder", ""
              "workertimeboost", "3.0"
              "wtboostunittype", "MOBILE"
              "evolution_health_transfer", "percentage"
              "evolution_target", "legcomlvl5"
              "evolution_condition", "timer"
              "evolution_timer", "99999.0"
              "evolution_power_threshold", "105000.0"
              "evolution_power_multiplier", "1.0"
              "combatradius", "0.0"
              "inheritxpratemultiplier", "0.25"
              "childreninheritxp", "DRONE BOTCANNON"
              "parentsinheritxp", "MOBILEBUILT DRONE BOTCANNON"
              "effigy", "comeffigylvl2"
              "minimum_respawn_stun", "5.0"
              "distance_stun_multiplier", "1.0"
              "fall_damage_multiplier", "5.0"
          ]
          extras = Map.ofList [
              "autoheal", "10.0"
              "cancloak", "true"
              "cloakcost", "100.0"
              "cloakcostmoving", "1000.0"
              "cancapture", "true"
              "canmanualfire", "true"
              "capturable", "false"
              "capturespeed", "1800.0"
              "hidedamage", "true"
              "holdsteady", "true"
              "sightemitheight", "40.0"
              "mass", "4900.0"
              "mincloakdistance", "50.0"
              "nochasecategory", "ALL"
              "pushresistant", "Spring.GetModOptions().pushresistant"
              "radardistance", "1000.0"
              "radaremitheight", "54.0"
              "reclaimable", "false"
              "releaseheld", "true"
              "selfdestructcountdown", "5.0"
              "showplayername", "true"
              "sonardistance", "600.0"
              "upright", "true"
          ] }

    let legcomlvl5 : UnitDef =
        { name = "legcomlvl5"
          subfolder = "Legion/Legion EvoCom"
          metalCost = ValueOrExpr.Concrete 6000.0
          energyCost = ValueOrExpr.Concrete 60000.0
          buildTime = ValueOrExpr.Concrete 187500.0
          health = ValueOrExpr.Concrete 12000.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/legevocom2.s3o"
          buildPic = Some "LEGCOM.DDS"
          script = Some "Units/legevocom2.cob"
          corpse = Some "DEAD"
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderexplosion"
          collisionVolumeOffsets = Some "0 4 0"
          collisionVolumeScales = Some "37 69 37"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 39.5
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
              buildDistance = Some 400.0
              buildOptions = []
              terraformSpeed = Some 1500.0 })
          weapons = Some [
              { name = "armmg_weapon"
                displayName = Some "Rapid-Fire Machine Gun"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 50.0
                ]
                range = Some (ValueOrExpr.Concrete 350.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.4)
                weaponVelocity = Some 999.0
                areaOfEffect = Some 16.0
                accuracy = Some 7.0
                turret = Some true
                tolerance = Some 6000.0
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 1.5
                noSelfDamage = Some true
                soundStart = Some "mgun6heavy"
                soundHit = Some "bimpact3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "1 0.95 0.4"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "mount_fastautoretargeting", "true"
                    "avoidfeature", "false"
                    "burst", "6.0"
                    "burstrate", "0.066"
                    "burnblow", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.04"
                    "fallOffRate", "0.2"
                    "firestarter", "0.0"
                    "impulseboost", "0.4"
                    "intensity", "0.8"
                    "minintensity", "1.0"
                    "ownerExpAccWeight", "4.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "4.5"
                    "soundtrigger", "true"
                    "sprayangle", "968.0"
                    "texture1", "shot"
                    "texture2", "empty"
                    "thickness", "3.0"
                ] }
              { name = "torpedo"
                displayName = Some "MK-V Torpedo Launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 250.0
                    "subs", 125.0
                ]
                range = Some (ValueOrExpr.Concrete 500.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.8)
                weaponVelocity = Some 425.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.55
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "torpedo1"
                soundHit = Some "xplodep2"
                explosiongenerator = Some "custom:genericshellexplosion-small-uw"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTAIR"
                    "avoidfeature", "false"
                    "avoidfriendly", "true"
                    "burnblow", "true"
                    "burst", "2.0"
                    "burstrate", "0.2"
                    "cegtag", "torpedotrail-tiny"
                    "collidefriendly", "true"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "flighttime", "1.8"
                    "model", "legtorpedo.s3o"
                    "predictboost", "1.0"
                    "startvelocity", "230.0"
                    "tracks", "false"
                    "turnrate", "2500.0"
                    "waterweapon", "true"
                    "weaponacceleration", "50.0"
                    "weapontimer", "3.0"
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
                    "soundhitwet", "sizzlexs"
                    "soundhitvolume", "36.0"
                    "soundstartvolume", "96.0"
                    "soundtrigger", "true"
                    "waterweapon", "true"
                    "weapontimer", "4.2"
                ] }
              { name = "railgunt2"
                displayName = Some "Railgun"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 250.0
                ]
                range = Some (ValueOrExpr.Concrete 620.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.7)
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
                rgbColor = Some "0.74 0.64 0.94"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "burnblow", "false"
                    "burst", "2.0"
                    "burstrate", "0.2"
                    "cegtag", "railgun"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.12"
                    "fallOffRate", "0.2"
                    "firestarter", "0.0"
                    "intensity", "0.8"
                    "minintensity", "1.0"
                    "ownerExpAccWeight", "4.0"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "26.0"
                    "thickness", "3.0"
                ] }
              { name = "botcannon"
                displayName = Some "Long range bot cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                    "shields", 250.0
                ]
                range = Some (ValueOrExpr.Concrete 600.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.9)
                weaponVelocity = Some 2000.0
                areaOfEffect = Some 10.0
                accuracy = Some 0.2
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.5
                noSelfDamage = Some true
                soundStart = Some "lrpcshot3"
                soundHit = Some "xplonuk1xs"
                explosiongenerator = Some "custom:botrailspawn"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "spawns_name", "babylegshot babylegdrone babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob"
                    "spawns_surface", "LAND"
                    "spawns_mode", "random"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT SHIP"
                    "mount_onlytargetcategory", "NOTSHIP"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burst", "6.0"
                    "burstrate", "0.1"
                    "collidefriendly", "false"
                    "craterareaofeffect", "116.0"
                    "craterboost", "0.1"
                    "cratermult", "0.1"
                    "energypershot", "1800.0"
                    "gravityaffected", "true"
                    "heightboostfactor", "8.0"
                    "hightrajectory", "1.0"
                    "leadbonus", "0.0"
                    "model", "LegionUnitCapsule.s3o"
                    "movingaccuracy", "600.0"
                    "mygravity", "4.8"
                    "sprayangle", "2800.0"
                    "stockpile", "true"
                    "stockpiletime", "11.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "50.0"
                    "trajectoryheight", "1.0"
                    "waterbounce", "true"
                    "bounceSlip", "0.74"
                    "bouncerebound", "0.5"
                    "numbounce", "10.0"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 200.0)
              metalMake = Some (ValueOrExpr.Concrete 14.0)
              energyStorage = Some 3000.0
              metalStorage = Some 500.0
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "47 10 47"
                collisionVolumeType = Some "CylY"
                damage = Some 24000.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 3500.0
                object_ = Some "Units/legcom_dead.s3o"
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
                metal = Some 1750.0
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
              "area_mex_def", "legmex"
              "iscommander", "true"
              "effigy_offset", "1.0"
              "evocomlvl", "5.0"
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "paralyzemultiplier", "0.025"
              "subfolder", ""
              "workertimeboost", "4.0"
              "wtboostunittype", "MOBILE"
              "evolution_health_transfer", "percentage"
              "evolution_target", "legcomlvl6"
              "evolution_condition", "timer"
              "evolution_timer", "99999.0"
              "evolution_power_threshold", "260000.0"
              "evolution_power_multiplier", "1.0"
              "combatradius", "0.0"
              "inheritxpratemultiplier", "0.25"
              "childreninheritxp", "DRONE BOTCANNON"
              "parentsinheritxp", "MOBILEBUILT DRONE BOTCANNON"
              "effigy", "comeffigylvl3"
              "minimum_respawn_stun", "5.0"
              "distance_stun_multiplier", "1.0"
              "fall_damage_multiplier", "5.0"
          ]
          extras = Map.ofList [
              "autoheal", "15.0"
              "cancloak", "true"
              "cloakcost", "100.0"
              "cloakcostmoving", "1000.0"
              "cancapture", "true"
              "canmanualfire", "true"
              "capturable", "false"
              "capturespeed", "1800.0"
              "hidedamage", "true"
              "holdsteady", "true"
              "icontype", "legcomlvl4"
              "sightemitheight", "40.0"
              "mass", "4900.0"
              "mincloakdistance", "50.0"
              "nochasecategory", "ALL"
              "pushresistant", "Spring.GetModOptions().pushresistant"
              "radardistance", "1000.0"
              "radaremitheight", "54.0"
              "reclaimable", "false"
              "reclaimspeed", "1995.0"
              "releaseheld", "true"
              "selfdestructcountdown", "5.0"
              "showplayername", "true"
              "sonardistance", "600.0"
              "upright", "true"
          ] }

    let legcomlvl6 : UnitDef =
        { name = "legcomlvl6"
          subfolder = "Legion/Legion EvoCom"
          metalCost = ValueOrExpr.Concrete 7000.0
          energyCost = ValueOrExpr.Concrete 70000.0
          buildTime = ValueOrExpr.Concrete 187500.0
          health = ValueOrExpr.Concrete 14000.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/legevocom3.s3o"
          buildPic = Some "LEGCOM.DDS"
          script = Some "Units/legevocom3.cob"
          corpse = Some "DEAD"
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderexplosion"
          collisionVolumeOffsets = Some "0 4 0"
          collisionVolumeScales = Some "37 69 37"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 41.5
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
              buildDistance = Some 400.0
              buildOptions = []
              terraformSpeed = Some 1500.0 })
          weapons = Some [
              { name = "armmg_weapon"
                displayName = Some "Rapid-Fire Plasma Cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 360.0
                    "vtol", 200.0
                ]
                range = Some (ValueOrExpr.Concrete 425.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.35)
                weaponVelocity = Some 600.0
                areaOfEffect = Some 90.0
                accuracy = Some 100.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 1.8
                noSelfDamage = Some true
                soundStart = Some "cannon3"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:genericshellexplosion-small-t2"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "mount_fastautoretargeting", "true"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splssml"
                ] }
              { name = "torpedo"
                displayName = Some "MK-VI Torpedo Launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 300.0
                    "subs", 150.0
                ]
                range = Some (ValueOrExpr.Concrete 500.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.8)
                weaponVelocity = Some 425.0
                areaOfEffect = Some 75.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.55
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "torpedo1"
                soundHit = Some "xplodep2"
                explosiongenerator = Some "custom:genericshellexplosion-small-uw"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTAIR"
                    "avoidfeature", "false"
                    "avoidfriendly", "true"
                    "burnblow", "true"
                    "burst", "2.0"
                    "burstrate", "0.2"
                    "cegtag", "torpedotrail-tiny"
                    "collidefriendly", "true"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "flighttime", "1.8"
                    "model", "legtorpedo.s3o"
                    "predictboost", "1.0"
                    "startvelocity", "230.0"
                    "tracks", "false"
                    "turnrate", "2500.0"
                    "waterweapon", "true"
                    "weaponacceleration", "50.0"
                    "weapontimer", "3.0"
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
                    "soundhitwet", "sizzlexs"
                    "soundhitvolume", "36.0"
                    "soundstartvolume", "96.0"
                    "soundtrigger", "true"
                    "waterweapon", "true"
                    "weapontimer", "4.2"
                ] }
              { name = "railgunt2"
                displayName = Some "Railgun"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 250.0
                ]
                range = Some (ValueOrExpr.Concrete 730.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.7)
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
                rgbColor = Some "0.74 0.64 0.94"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "burnblow", "false"
                    "burst", "3.0"
                    "burstrate", "0.15"
                    "cegtag", "railgun"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.12"
                    "fallOffRate", "0.2"
                    "firestarter", "0.0"
                    "intensity", "0.8"
                    "minintensity", "1.0"
                    "ownerExpAccWeight", "4.0"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "26.0"
                    "thickness", "3.0"
                ] }
              { name = "botcannon"
                displayName = Some "Long range bot cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                    "shields", 250.0
                ]
                range = Some (ValueOrExpr.Concrete 600.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.9)
                weaponVelocity = Some 2000.0
                areaOfEffect = Some 10.0
                accuracy = Some 0.2
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.5
                noSelfDamage = Some true
                soundStart = Some "lrpcshot3"
                soundHit = Some "xplonuk1xs"
                explosiongenerator = Some "custom:botrailspawn"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "spawns_name", "babylegshot babylegdrone babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob"
                    "spawns_surface", "LAND"
                    "spawns_mode", "random"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT SHIP"
                    "mount_onlytargetcategory", "NOTSHIP"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burst", "7.0"
                    "burstrate", "0.05"
                    "collidefriendly", "false"
                    "craterareaofeffect", "116.0"
                    "craterboost", "0.1"
                    "cratermult", "0.1"
                    "energypershot", "2100.0"
                    "gravityaffected", "true"
                    "heightboostfactor", "8.0"
                    "hightrajectory", "1.0"
                    "leadbonus", "0.0"
                    "model", "LegionUnitCapsule.s3o"
                    "movingaccuracy", "600.0"
                    "mygravity", "4.8"
                    "sprayangle", "2800.0"
                    "stockpile", "true"
                    "stockpiletime", "10.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "50.0"
                    "trajectoryheight", "1.0"
                    "waterbounce", "true"
                    "bounceSlip", "0.74"
                    "bouncerebound", "0.5"
                    "numbounce", "10.0"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 325.0)
              metalMake = Some (ValueOrExpr.Concrete 20.0)
              energyStorage = Some 4000.0
              metalStorage = Some 500.0
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "47 10 47"
                collisionVolumeType = Some "CylY"
                damage = Some 28000.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 3500.0
                object_ = Some "Units/legcom_dead.s3o"
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
                metal = Some 1750.0
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
              "area_mex_def", "legmex"
              "iscommander", "true"
              "effigy_offset", "1.0"
              "evocomlvl", "6.0"
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "paralyzemultiplier", "0.025"
              "subfolder", ""
              "workertimeboost", "4.0"
              "wtboostunittype", "MOBILE"
              "evolution_health_transfer", "percentage"
              "evolution_target", "legcomlvl7"
              "evolution_condition", "timer"
              "evolution_timer", "99999.0"
              "evolution_power_threshold", "390000.0"
              "evolution_power_multiplier", "1.0"
              "combatradius", "0.0"
              "inheritxpratemultiplier", "0.25"
              "childreninheritxp", "DRONE BOTCANNON"
              "parentsinheritxp", "MOBILEBUILT DRONE BOTCANNON"
              "effigy", "comeffigylvl3"
              "minimum_respawn_stun", "5.0"
              "distance_stun_multiplier", "1.0"
              "fall_damage_multiplier", "5.0"
          ]
          extras = Map.ofList [
              "autoheal", "15.0"
              "cancloak", "true"
              "cloakcost", "100.0"
              "cloakcostmoving", "1000.0"
              "cancapture", "true"
              "canmanualfire", "true"
              "capturable", "false"
              "capturespeed", "1800.0"
              "hidedamage", "true"
              "holdsteady", "true"
              "icontype", "legcomlvl4"
              "sightemitheight", "40.0"
              "mass", "4900.0"
              "mincloakdistance", "50.0"
              "nochasecategory", "ALL"
              "pushresistant", "Spring.GetModOptions().pushresistant"
              "radardistance", "1000.0"
              "radaremitheight", "54.0"
              "reclaimable", "false"
              "reclaimspeed", "2433.0"
              "releaseheld", "true"
              "selfdestructcountdown", "5.0"
              "showplayername", "true"
              "sonardistance", "600.0"
              "upright", "true"
          ] }

    let legcomlvl7 : UnitDef =
        { name = "legcomlvl7"
          subfolder = "Legion/Legion EvoCom"
          metalCost = ValueOrExpr.Concrete 8000.0
          energyCost = ValueOrExpr.Concrete 80000.0
          buildTime = ValueOrExpr.Concrete 192000.0
          health = ValueOrExpr.Concrete 16000.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/legevocom3.s3o"
          buildPic = Some "LEGCOM.DDS"
          script = Some "Units/legevocom3.cob"
          corpse = Some "DEAD"
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderexplosion"
          collisionVolumeOffsets = Some "0 4 0"
          collisionVolumeScales = Some "37 69 37"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 43.5
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
              buildDistance = Some 500.0
              buildOptions = []
              terraformSpeed = Some 1500.0 })
          weapons = Some [
              { name = "armmg_weapon"
                displayName = Some "Rapid-Fire Plasma Cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 400.0
                    "vtol", 225.0
                ]
                range = Some (ValueOrExpr.Concrete 425.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.3)
                weaponVelocity = Some 600.0
                areaOfEffect = Some 90.0
                accuracy = Some 100.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 1.8
                noSelfDamage = Some true
                soundStart = Some "cannon3"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:genericshellexplosion-small-t2"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "mount_fastautoretargeting", "true"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splssml"
                ] }
              { name = "torpedo"
                displayName = Some "MK-VII Torpedo Launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 300.0
                    "subs", 150.0
                ]
                range = Some (ValueOrExpr.Concrete 550.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.8)
                weaponVelocity = Some 425.0
                areaOfEffect = Some 75.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.55
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "torpedo1"
                soundHit = Some "xplodep2"
                explosiongenerator = Some "custom:genericshellexplosion-small-uw"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTAIR"
                    "avoidfeature", "false"
                    "avoidfriendly", "true"
                    "burnblow", "true"
                    "burst", "3.0"
                    "burstrate", "0.2"
                    "cegtag", "torpedotrail-tiny"
                    "collidefriendly", "true"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "flighttime", "1.8"
                    "model", "legtorpedo.s3o"
                    "predictboost", "1.0"
                    "startvelocity", "230.0"
                    "tracks", "false"
                    "turnrate", "2500.0"
                    "waterweapon", "true"
                    "weaponacceleration", "50.0"
                    "weapontimer", "3.0"
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
                    "soundhitwet", "sizzlexs"
                    "soundhitvolume", "36.0"
                    "soundstartvolume", "96.0"
                    "soundtrigger", "true"
                    "waterweapon", "true"
                    "weapontimer", "4.2"
                ] }
              { name = "railgunt2"
                displayName = Some "Railgun"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 250.0
                ]
                range = Some (ValueOrExpr.Concrete 730.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.6)
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
                rgbColor = Some "0.74 0.64 0.94"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "burnblow", "false"
                    "burst", "4.0"
                    "burstrate", "0.12"
                    "cegtag", "railgun"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.12"
                    "fallOffRate", "0.2"
                    "firestarter", "0.0"
                    "intensity", "0.8"
                    "minintensity", "1.0"
                    "ownerExpAccWeight", "4.0"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "26.0"
                    "thickness", "3.0"
                ] }
              { name = "botcannon"
                displayName = Some "Long range bot cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                    "shields", 250.0
                ]
                range = Some (ValueOrExpr.Concrete 700.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.9)
                weaponVelocity = Some 2000.0
                areaOfEffect = Some 10.0
                accuracy = Some 0.2
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.5
                noSelfDamage = Some true
                soundStart = Some "lrpcshot3"
                soundHit = Some "xplonuk1xs"
                explosiongenerator = Some "custom:botrailspawn"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "spawns_name", "babylegshot babylegdrone babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob"
                    "spawns_surface", "LAND"
                    "spawns_mode", "random"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT SHIP"
                    "mount_onlytargetcategory", "NOTSHIP"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burst", "8.0"
                    "burstrate", "0.05"
                    "collidefriendly", "false"
                    "craterareaofeffect", "116.0"
                    "craterboost", "0.1"
                    "cratermult", "0.1"
                    "energypershot", "2400.0"
                    "gravityaffected", "true"
                    "heightboostfactor", "8.0"
                    "hightrajectory", "1.0"
                    "leadbonus", "0.0"
                    "model", "LegionUnitCapsule.s3o"
                    "movingaccuracy", "600.0"
                    "mygravity", "4.8"
                    "sprayangle", "2800.0"
                    "stockpile", "true"
                    "stockpiletime", "10.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "50.0"
                    "trajectoryheight", "1.0"
                    "waterbounce", "true"
                    "bounceSlip", "0.74"
                    "bouncerebound", "0.5"
                    "numbounce", "10.0"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 525.0)
              metalMake = Some (ValueOrExpr.Concrete 27.0)
              energyStorage = Some 5000.0
              metalStorage = Some 500.0
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "47 10 47"
                collisionVolumeType = Some "CylY"
                damage = Some 32000.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 3500.0
                object_ = Some "Units/legcom_dead.s3o"
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
                metal = Some 1750.0
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
              "area_mex_def", "legmex"
              "iscommander", "true"
              "effigy_offset", "1.0"
              "evocomlvl", "7.0"
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "paralyzemultiplier", "0.025"
              "subfolder", ""
              "workertimeboost", "5.0"
              "wtboostunittype", "MOBILE"
              "evolution_health_transfer", "percentage"
              "evolution_target", "legcomlvl8"
              "evolution_condition", "timer"
              "evolution_timer", "99999.0"
              "evolution_power_threshold", "520000.0"
              "evolution_power_multiplier", "1.0"
              "combatradius", "0.0"
              "inheritxpratemultiplier", "0.25"
              "childreninheritxp", "DRONE BOTCANNON"
              "parentsinheritxp", "MOBILEBUILT DRONE BOTCANNON"
              "effigy", "comeffigylvl4"
              "minimum_respawn_stun", "5.0"
              "distance_stun_multiplier", "1.0"
              "fall_damage_multiplier", "5.0"
          ]
          extras = Map.ofList [
              "autoheal", "20.0"
              "cancloak", "true"
              "cloakcost", "100.0"
              "cloakcostmoving", "1000.0"
              "cancapture", "true"
              "canmanualfire", "true"
              "capturable", "false"
              "capturespeed", "1800.0"
              "hidedamage", "true"
              "holdsteady", "true"
              "icontype", "legcomlvl4"
              "sightemitheight", "40.0"
              "mass", "4900.0"
              "mincloakdistance", "50.0"
              "nochasecategory", "ALL"
              "pushresistant", "Spring.GetModOptions().pushresistant"
              "radardistance", "1200.0"
              "radaremitheight", "54.0"
              "reclaimable", "false"
              "reclaimspeed", "2967.0"
              "releaseheld", "true"
              "selfdestructcountdown", "5.0"
              "showplayername", "true"
              "sonardistance", "600.0"
              "upright", "true"
          ] }

    let legcomlvl8 : UnitDef =
        { name = "legcomlvl8"
          subfolder = "Legion/Legion EvoCom"
          metalCost = ValueOrExpr.Concrete 9000.0
          energyCost = ValueOrExpr.Concrete 90000.0
          buildTime = ValueOrExpr.Concrete 216000.0
          health = ValueOrExpr.Concrete 18000.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/legevocom3.s3o"
          buildPic = Some "LEGCOM.DDS"
          script = Some "Units/legevocom3.cob"
          corpse = Some "DEAD"
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderexplosion"
          collisionVolumeOffsets = Some "0 4 0"
          collisionVolumeScales = Some "37 69 37"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 45.5
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
              buildDistance = Some 500.0
              buildOptions = []
              terraformSpeed = Some 1500.0 })
          weapons = Some [
              { name = "armmg_weapon"
                displayName = Some "Rapid-Fire Plasma Cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 475.0
                    "vtol", 235.0
                ]
                range = Some (ValueOrExpr.Concrete 500.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.25)
                weaponVelocity = Some 600.0
                areaOfEffect = Some 100.0
                accuracy = Some 100.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 1.8
                noSelfDamage = Some true
                soundStart = Some "cannon3"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:genericshellexplosion-small-t2"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "mount_fastautoretargeting", "true"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splssml"
                ] }
              { name = "torpedo"
                displayName = Some "MK-VIII Torpedo Launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 350.0
                    "subs", 175.0
                ]
                range = Some (ValueOrExpr.Concrete 550.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.8)
                weaponVelocity = Some 425.0
                areaOfEffect = Some 75.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.55
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "torpedo1"
                soundHit = Some "xplodep2"
                explosiongenerator = Some "custom:genericshellexplosion-small-uw"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTAIR"
                    "avoidfeature", "false"
                    "avoidfriendly", "true"
                    "burnblow", "true"
                    "burst", "3.0"
                    "burstrate", "0.2"
                    "cegtag", "torpedotrail-tiny"
                    "collidefriendly", "true"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "flighttime", "1.8"
                    "model", "legtorpedo.s3o"
                    "predictboost", "1.0"
                    "startvelocity", "230.0"
                    "tracks", "false"
                    "turnrate", "2500.0"
                    "waterweapon", "true"
                    "weaponacceleration", "50.0"
                    "weapontimer", "3.0"
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
                    "soundhitwet", "sizzlexs"
                    "soundhitvolume", "36.0"
                    "soundstartvolume", "96.0"
                    "soundtrigger", "true"
                    "waterweapon", "true"
                    "weapontimer", "4.2"
                ] }
              { name = "railgunt2"
                displayName = Some "Railgun"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 300.0
                ]
                range = Some (ValueOrExpr.Concrete 800.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.4)
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
                rgbColor = Some "0.74 0.64 0.94"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "burnblow", "false"
                    "burst", "4.0"
                    "burstrate", "0.12"
                    "cegtag", "railgun"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.12"
                    "fallOffRate", "0.2"
                    "firestarter", "0.0"
                    "intensity", "0.8"
                    "minintensity", "1.0"
                    "ownerExpAccWeight", "4.0"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "26.0"
                    "thickness", "3.0"
                ] }
              { name = "botcannon"
                displayName = Some "Long range bot cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                    "shields", 250.0
                ]
                range = Some (ValueOrExpr.Concrete 700.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.9)
                weaponVelocity = Some 2000.0
                areaOfEffect = Some 10.0
                accuracy = Some 0.2
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.5
                noSelfDamage = Some true
                soundStart = Some "lrpcshot3"
                soundHit = Some "xplonuk1xs"
                explosiongenerator = Some "custom:botrailspawn"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "spawns_name", "babylegshot babylegdrone babylegdrone babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob"
                    "spawns_surface", "LAND"
                    "spawns_mode", "random"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT SHIP"
                    "mount_onlytargetcategory", "NOTSHIP"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burst", "5.0"
                    "burstrate", "0.025"
                    "collidefriendly", "false"
                    "craterareaofeffect", "116.0"
                    "craterboost", "0.1"
                    "cratermult", "0.1"
                    "energypershot", "3000.0"
                    "gravityaffected", "true"
                    "heightboostfactor", "8.0"
                    "hightrajectory", "1.0"
                    "leadbonus", "0.0"
                    "model", "LegionUnitCapsule.s3o"
                    "movingaccuracy", "600.0"
                    "mygravity", "4.8"
                    "projectiles", "2.0"
                    "sprayangle", "2800.0"
                    "stockpile", "true"
                    "stockpiletime", "10.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "50.0"
                    "trajectoryheight", "1.0"
                    "waterbounce", "true"
                    "bounceSlip", "0.74"
                    "bouncerebound", "0.5"
                    "numbounce", "10.0"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 850.0)
              metalMake = Some (ValueOrExpr.Concrete 34.0)
              energyStorage = Some 6500.0
              metalStorage = Some 500.0
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "47 10 47"
                collisionVolumeType = Some "CylY"
                damage = Some 36000.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 3500.0
                object_ = Some "Units/legcom_dead.s3o"
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
                metal = Some 1750.0
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
              "area_mex_def", "legmex"
              "iscommander", "true"
              "effigy_offset", "1.0"
              "evocomlvl", "8.0"
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "paralyzemultiplier", "0.025"
              "subfolder", ""
              "workertimeboost", "5.0"
              "wtboostunittype", "MOBILE"
              "evolution_health_transfer", "percentage"
              "evolution_target", "legcomlvl9"
              "evolution_condition", "timer"
              "evolution_timer", "99999.0"
              "evolution_power_threshold", "660000.0"
              "evolution_power_multiplier", "1.0"
              "combatradius", "0.0"
              "inheritxpratemultiplier", "0.25"
              "childreninheritxp", "DRONE BOTCANNON"
              "parentsinheritxp", "MOBILEBUILT DRONE BOTCANNON"
              "effigy", "comeffigylvl4"
              "minimum_respawn_stun", "5.0"
              "distance_stun_multiplier", "1.0"
              "fall_damage_multiplier", "5.0"
          ]
          extras = Map.ofList [
              "autoheal", "25.0"
              "cancloak", "true"
              "cloakcost", "100.0"
              "cloakcostmoving", "1000.0"
              "cancapture", "true"
              "canmanualfire", "true"
              "capturable", "false"
              "capturespeed", "1800.0"
              "hidedamage", "true"
              "holdsteady", "true"
              "icontype", "legcomlvl4"
              "sightemitheight", "40.0"
              "mass", "4900.0"
              "mincloakdistance", "50.0"
              "nochasecategory", "ALL"
              "pushresistant", "Spring.GetModOptions().pushresistant"
              "radardistance", "1200.0"
              "radaremitheight", "54.0"
              "reclaimable", "false"
              "reclaimspeed", "3621.0"
              "releaseheld", "true"
              "selfdestructcountdown", "5.0"
              "showplayername", "true"
              "sonardistance", "600.0"
              "upright", "true"
          ] }

    let legcomlvl9 : UnitDef =
        { name = "legcomlvl9"
          subfolder = "Legion/Legion EvoCom"
          metalCost = ValueOrExpr.Concrete 10000.0
          energyCost = ValueOrExpr.Concrete 100000.0
          buildTime = ValueOrExpr.Concrete 240000.0
          health = ValueOrExpr.Concrete 20000.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/legevocom3.s3o"
          buildPic = Some "LEGCOM.DDS"
          script = Some "Units/legevocom3.cob"
          corpse = Some "DEAD"
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderexplosion"
          collisionVolumeOffsets = Some "0 4 0"
          collisionVolumeScales = Some "37 69 37"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 47.5
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
              buildDistance = Some 600.0
              buildOptions = []
              terraformSpeed = Some 1500.0 })
          weapons = Some [
              { name = "armmg_weapon"
                displayName = Some "Rapid-Fire Plasma Cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 500.0
                    "vtol", 250.0
                ]
                range = Some (ValueOrExpr.Concrete 500.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.4)
                weaponVelocity = Some 600.0
                areaOfEffect = Some 110.0
                accuracy = Some 100.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 1.8
                noSelfDamage = Some true
                soundStart = Some "cannon3"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:genericshellexplosion-small-t2"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "mount_fastautoretargeting", "true"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "burst", "2.0"
                    "burstrate", "0.2"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splssml"
                    "sprayangle", "500.0"
                ] }
              { name = "torpedo"
                displayName = Some "MK-IX Torpedo Launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 350.0
                    "subs", 175.0
                ]
                range = Some (ValueOrExpr.Concrete 550.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.8)
                weaponVelocity = Some 425.0
                areaOfEffect = Some 75.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.55
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "torpedo1"
                soundHit = Some "xplodep2"
                explosiongenerator = Some "custom:genericshellexplosion-small-uw"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTAIR"
                    "avoidfeature", "false"
                    "avoidfriendly", "true"
                    "burnblow", "true"
                    "burst", "4.0"
                    "burstrate", "0.15"
                    "cegtag", "torpedotrail-tiny"
                    "collidefriendly", "true"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "flighttime", "1.8"
                    "model", "legtorpedo.s3o"
                    "predictboost", "1.0"
                    "startvelocity", "230.0"
                    "tracks", "false"
                    "turnrate", "2500.0"
                    "waterweapon", "true"
                    "weaponacceleration", "50.0"
                    "weapontimer", "3.0"
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
                    "soundhitwet", "sizzlexs"
                    "soundhitvolume", "36.0"
                    "soundstartvolume", "96.0"
                    "soundtrigger", "true"
                    "waterweapon", "true"
                    "weapontimer", "4.2"
                ] }
              { name = "railgunt2"
                displayName = Some "Railgun"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 400.0
                ]
                range = Some (ValueOrExpr.Concrete 870.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.2)
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
                rgbColor = Some "0.74 0.64 0.94"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "burnblow", "false"
                    "burst", "4.0"
                    "burstrate", "0.12"
                    "cegtag", "railgun"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.12"
                    "fallOffRate", "0.2"
                    "firestarter", "0.0"
                    "intensity", "0.8"
                    "minintensity", "1.0"
                    "ownerExpAccWeight", "4.0"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "26.0"
                    "thickness", "3.0"
                ] }
              { name = "botcannon"
                displayName = Some "Long range bot cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                    "shields", 250.0
                ]
                range = Some (ValueOrExpr.Concrete 700.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.9)
                weaponVelocity = Some 2000.0
                areaOfEffect = Some 10.0
                accuracy = Some 0.2
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.5
                noSelfDamage = Some true
                soundStart = Some "lrpcshot3"
                soundHit = Some "xplonuk1xs"
                explosiongenerator = Some "custom:botrailspawn"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "spawns_name", "babylegshot babylegheavydrone babylegdrone babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob"
                    "spawns_surface", "LAND"
                    "spawns_mode", "random"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT SHIP"
                    "mount_onlytargetcategory", "NOTSHIP"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burst", "7.0"
                    "burstrate", "0.025"
                    "collidefriendly", "false"
                    "craterareaofeffect", "116.0"
                    "craterboost", "0.1"
                    "cratermult", "0.1"
                    "energypershot", "4200.0"
                    "gravityaffected", "true"
                    "heightboostfactor", "8.0"
                    "hightrajectory", "1.0"
                    "leadbonus", "0.0"
                    "model", "LegionUnitCapsule.s3o"
                    "movingaccuracy", "600.0"
                    "mygravity", "4.8"
                    "projectiles", "2.0"
                    "sprayangle", "2800.0"
                    "stockpile", "true"
                    "stockpiletime", "10.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "50.0"
                    "trajectoryheight", "1.0"
                    "waterbounce", "true"
                    "bounceSlip", "0.74"
                    "bouncerebound", "0.5"
                    "numbounce", "10.0"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 1375.0)
              metalMake = Some (ValueOrExpr.Concrete 42.0)
              energyStorage = Some 8000.0
              metalStorage = Some 500.0
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "47 10 47"
                collisionVolumeType = Some "CylY"
                damage = Some 40000.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 3500.0
                object_ = Some "Units/legcom_dead.s3o"
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
                metal = Some 1750.0
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
              "area_mex_def", "legmex"
              "iscommander", "true"
              "effigy_offset", "1.0"
              "evocomlvl", "9.0"
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "paralyzemultiplier", "0.025"
              "subfolder", ""
              "workertimeboost", "6.0"
              "wtboostunittype", "MOBILE"
              "evolution_health_transfer", "percentage"
              "evolution_target", "legcomlvl10"
              "evolution_condition", "timer"
              "evolution_timer", "99999.0"
              "evolution_power_threshold", "800000.0"
              "evolution_power_multiplier", "1.0"
              "combatradius", "0.0"
              "inheritxpratemultiplier", "0.25"
              "childreninheritxp", "DRONE BOTCANNON"
              "parentsinheritxp", "MOBILEBUILT DRONE BOTCANNON"
              "effigy", "comeffigylvl5"
              "minimum_respawn_stun", "5.0"
              "distance_stun_multiplier", "1.0"
              "fall_damage_multiplier", "5.0"
          ]
          extras = Map.ofList [
              "autoheal", "30.0"
              "cancloak", "true"
              "cloakcost", "100.0"
              "cloakcostmoving", "1000.0"
              "cancapture", "true"
              "canmanualfire", "true"
              "capturable", "false"
              "capturespeed", "1800.0"
              "hidedamage", "true"
              "holdsteady", "true"
              "icontype", "legcomlvl4"
              "sightemitheight", "40.0"
              "mass", "4900.0"
              "mincloakdistance", "50.0"
              "nochasecategory", "ALL"
              "pushresistant", "Spring.GetModOptions().pushresistant"
              "radardistance", "1200.0"
              "radaremitheight", "54.0"
              "reclaimable", "false"
              "reclaimspeed", "4416.0"
              "releaseheld", "true"
              "selfdestructcountdown", "5.0"
              "showplayername", "true"
              "sonardistance", "600.0"
              "upright", "true"
          ] }

    let all : (string * UnitDef) list =
        [
            "legcomlvl10", legcomlvl10
            "legcomlvl2", legcomlvl2
            "legcomlvl3", legcomlvl3
            "legcomlvl4", legcomlvl4
            "legcomlvl5", legcomlvl5
            "legcomlvl6", legcomlvl6
            "legcomlvl7", legcomlvl7
            "legcomlvl8", legcomlvl8
            "legcomlvl9", legcomlvl9
        ]
