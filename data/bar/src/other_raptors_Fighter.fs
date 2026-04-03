// Auto-generated BAR unit data: other/raptors/Fighter
namespace BarData.Units

open BarData

module other_raptors_Fighter =

    let raptor_air_fighter_basic_t1_v1 =
        LuaValue.Table [
            LuaKey.String "acceleration", LuaValue.Number 2.0
            LuaKey.String "airsightdistance", LuaValue.Number 600.0
            LuaKey.String "amphibious", LuaValue.Bool true
            LuaKey.String "bankscale", LuaValue.String "1"
            LuaKey.String "maxdec", LuaValue.Number 0.2
            LuaKey.String "energycost", LuaValue.Number 2200.0
            LuaKey.String "metalcost", LuaValue.Number 72.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptorw1_mini.DDS"
            LuaKey.String "buildtime", LuaValue.Number 1950.0
            LuaKey.String "cancrash", LuaValue.Bool false
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canland", LuaValue.Bool true
            LuaKey.String "canloopbackattack", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.Bool true
            LuaKey.String "cansubmerge", LuaValue.Bool false
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collide", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "58 58 58"
            LuaKey.String "collisionvolumetype", LuaValue.String "sphere"
            LuaKey.String "cruisealtitude", LuaValue.Number 220.0
            LuaKey.String "defaultmissiontype", LuaValue.String "VTOL_standby"
            LuaKey.String "explodeas", LuaValue.String "TALON_DEATH"
            LuaKey.String "floater", LuaValue.Bool true
            LuaKey.String "footprintx", LuaValue.Number 1.0
            LuaKey.String "footprintz", LuaValue.Number 1.0
            LuaKey.String "hidedamage", LuaValue.Number 1.0
            LuaKey.String "maneuverleashlength", LuaValue.String "1280"
            LuaKey.String "mass", LuaValue.Number 90.0
            LuaKey.String "maxacc", LuaValue.Number 0.25
            LuaKey.String "maxaileron", LuaValue.Number 0.025
            LuaKey.String "maxbank", LuaValue.Number 0.8
            LuaKey.String "health", LuaValue.Number 85.0
            LuaKey.String "maxelevator", LuaValue.Number 0.025
            LuaKey.String "maxpitch", LuaValue.Number 0.75
            LuaKey.String "maxrudder", LuaValue.Number 0.025
            LuaKey.String "speed", LuaValue.Number 360.0
            LuaKey.String "moverate1", LuaValue.String "32"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "NOTAIR"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptorw1_mini.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptorw1.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "TALON_DEATH"
            LuaKey.String "separation", LuaValue.String "0.2"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 400.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "speedtofront", LuaValue.Number 0.07
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turnradius", LuaValue.Number 64.0
            LuaKey.String "turnrate", LuaValue.Number 1600.0
            LuaKey.String "unitname", LuaValue.String "raptor_air_fighter_basic_t1_v1"
            LuaKey.String "usesmoothmesh", LuaValue.Bool true
            LuaKey.String "wingangle", LuaValue.Number 0.06593
            LuaKey.String "wingdrag", LuaValue.Number 0.435
            LuaKey.String "workertime", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "KDR_11k, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_m_normals.png"
                    LuaKey.String "treeshader", LuaValue.String "yes"
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:blood_spray"
                            LuaKey.Int 2, LuaValue.String "custom:blood_explode"
                            LuaKey.Int 3, LuaValue.String "custom:dirt"
                        ]
                    LuaKey.String "pieceexplosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "blood_spray"
                            LuaKey.Int 2, LuaValue.String "blood_spray"
                            LuaKey.Int 3, LuaValue.String "blood_spray"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "weapon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 256.0
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cameraShake", LuaValue.Number 700.0
                            LuaKey.String "dance", LuaValue.Number 20.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.35
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-huge-bomb"
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "flighttime", LuaValue.Number 4.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.4
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 4.0
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "SimpleFlareXL.s3o"
                            LuaKey.String "name", LuaValue.String "Deadly Defensive Spores"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 750.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 2.0
                            LuaKey.String "smoketime", LuaValue.Number 45.0
                            LuaKey.String "smokesize", LuaValue.Number 10.5
                            LuaKey.String "smokecolor", LuaValue.Number 1.0
                            LuaKey.String "soundhit", LuaValue.String "spore_explo"
                            LuaKey.String "soundstart", LuaValue.String "spore_xl"
                            LuaKey.String "soundstartvolume", LuaValue.Number 9.0
                            LuaKey.String "startvelocity", LuaValue.Number 1000.0
                            LuaKey.String "texture1", LuaValue.String "orangenovaexplo"
                            LuaKey.String "texture2", LuaValue.String "sporetrail_xl"
                            LuaKey.String "tolerance", LuaValue.Number 60000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 60000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 40.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2000.0
                            LuaKey.String "wobble", LuaValue.Number 32000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1.0
                                    LuaKey.String "vtol", LuaValue.Number 100.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "WEAPON"
                            LuaKey.String "def", LuaValue.String "WEAPON"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 180.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let raptor_air_fighter_basic_t2_v1 =
        LuaValue.Table [
            LuaKey.String "acceleration", LuaValue.Number 2.0
            LuaKey.String "airsightdistance", LuaValue.Number 600.0
            LuaKey.String "amphibious", LuaValue.Bool true
            LuaKey.String "bankscale", LuaValue.String "1"
            LuaKey.String "maxdec", LuaValue.Number 0.2
            LuaKey.String "energycost", LuaValue.Number 2200.0
            LuaKey.String "metalcost", LuaValue.Number 72.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptorw1.DDS"
            LuaKey.String "buildtime", LuaValue.Number 1950.0
            LuaKey.String "cancrash", LuaValue.Bool false
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canland", LuaValue.Bool true
            LuaKey.String "canloopbackattack", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.Bool true
            LuaKey.String "cansubmerge", LuaValue.Bool false
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collide", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "58 58 58"
            LuaKey.String "collisionvolumetype", LuaValue.String "sphere"
            LuaKey.String "cruisealtitude", LuaValue.Number 220.0
            LuaKey.String "defaultmissiontype", LuaValue.String "VTOL_standby"
            LuaKey.String "explodeas", LuaValue.String "TALON_DEATH"
            LuaKey.String "floater", LuaValue.Bool true
            LuaKey.String "footprintx", LuaValue.Number 1.0
            LuaKey.String "footprintz", LuaValue.Number 1.0
            LuaKey.String "hidedamage", LuaValue.Number 1.0
            LuaKey.String "maneuverleashlength", LuaValue.String "1280"
            LuaKey.String "mass", LuaValue.Number 90.0
            LuaKey.String "maxacc", LuaValue.Number 0.25
            LuaKey.String "maxaileron", LuaValue.Number 0.025
            LuaKey.String "maxbank", LuaValue.Number 0.8
            LuaKey.String "health", LuaValue.Number 350.0
            LuaKey.String "maxelevator", LuaValue.Number 0.025
            LuaKey.String "maxpitch", LuaValue.Number 0.75
            LuaKey.String "maxrudder", LuaValue.Number 0.025
            LuaKey.String "speed", LuaValue.Number 360.0
            LuaKey.String "moverate1", LuaValue.String "32"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "NOTAIR"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor_pidgeon.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptorw1.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "TALON_DEATH"
            LuaKey.String "separation", LuaValue.String "0.2"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 400.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "speedtofront", LuaValue.Number 0.07
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turnradius", LuaValue.Number 64.0
            LuaKey.String "turnrate", LuaValue.Number 1600.0
            LuaKey.String "unitname", LuaValue.String "raptor_air_fighter_basic_t2_v1"
            LuaKey.String "usesmoothmesh", LuaValue.Bool true
            LuaKey.String "wingangle", LuaValue.Number 0.06593
            LuaKey.String "wingdrag", LuaValue.Number 0.435
            LuaKey.String "workertime", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "KDR_11k, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_m_normals.png"
                    LuaKey.String "treeshader", LuaValue.String "yes"
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:blood_spray"
                            LuaKey.Int 2, LuaValue.String "custom:blood_explode"
                            LuaKey.Int 3, LuaValue.String "custom:dirt"
                        ]
                    LuaKey.String "pieceexplosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "blood_spray"
                            LuaKey.Int 2, LuaValue.String "blood_spray"
                            LuaKey.Int 3, LuaValue.String "blood_spray"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "weapon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 256.0
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cameraShake", LuaValue.Number 700.0
                            LuaKey.String "dance", LuaValue.Number 20.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.35
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-huge-bomb"
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "flighttime", LuaValue.Number 6.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.4
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 4.0
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "SimpleFlareXL.s3o"
                            LuaKey.String "name", LuaValue.String "Deadly Defensive Spores"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1000.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.5
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 2.0
                            LuaKey.String "smoketime", LuaValue.Number 45.0
                            LuaKey.String "smokesize", LuaValue.Number 10.5
                            LuaKey.String "smokecolor", LuaValue.Number 1.0
                            LuaKey.String "soundhit", LuaValue.String "spore_explo"
                            LuaKey.String "soundstart", LuaValue.String "spore_xl"
                            LuaKey.String "soundstartvolume", LuaValue.Number 9.0
                            LuaKey.String "startvelocity", LuaValue.Number 1000.0
                            LuaKey.String "texture1", LuaValue.String "orangenovaexplo"
                            LuaKey.String "texture2", LuaValue.String "sporetrail_xl"
                            LuaKey.String "tolerance", LuaValue.Number 60000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 60000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 40.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2000.0
                            LuaKey.String "wobble", LuaValue.Number 32000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1.0
                                    LuaKey.String "vtol", LuaValue.Number 500.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "WEAPON"
                            LuaKey.String "def", LuaValue.String "WEAPON"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 180.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let raptor_air_fighter_basic_t2_v2 =
        LuaValue.Table [
            LuaKey.String "acceleration", LuaValue.Number 2.0
            LuaKey.String "airsightdistance", LuaValue.Number 600.0
            LuaKey.String "amphibious", LuaValue.Bool true
            LuaKey.String "bankscale", LuaValue.String "1"
            LuaKey.String "maxdec", LuaValue.Number 0.2
            LuaKey.String "energycost", LuaValue.Number 2200.0
            LuaKey.String "metalcost", LuaValue.Number 72.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptorw1b.DDS"
            LuaKey.String "buildtime", LuaValue.Number 2025.0
            LuaKey.String "cancrash", LuaValue.Bool false
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canland", LuaValue.Bool true
            LuaKey.String "canloopbackattack", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.Bool true
            LuaKey.String "cansubmerge", LuaValue.Bool false
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collide", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "58 58 58"
            LuaKey.String "collisionvolumetype", LuaValue.String "sphere"
            LuaKey.String "cruisealtitude", LuaValue.Number 220.0
            LuaKey.String "defaultmissiontype", LuaValue.String "VTOL_standby"
            LuaKey.String "explodeas", LuaValue.String "TALON_DEATH"
            LuaKey.String "floater", LuaValue.Bool true
            LuaKey.String "footprintx", LuaValue.Number 1.0
            LuaKey.String "footprintz", LuaValue.Number 1.0
            LuaKey.String "hidedamage", LuaValue.Number 1.0
            LuaKey.String "maneuverleashlength", LuaValue.String "1280"
            LuaKey.String "mass", LuaValue.Number 90.0
            LuaKey.String "maxacc", LuaValue.Number 0.25
            LuaKey.String "maxaileron", LuaValue.Number 0.025
            LuaKey.String "maxbank", LuaValue.Number 0.8
            LuaKey.String "health", LuaValue.Number 350.0
            LuaKey.String "maxelevator", LuaValue.Number 0.025
            LuaKey.String "maxpitch", LuaValue.Number 0.75
            LuaKey.String "maxrudder", LuaValue.Number 0.025
            LuaKey.String "speed", LuaValue.Number 360.0
            LuaKey.String "moverate1", LuaValue.String "32"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "NOTAIR"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor_pidgeonb.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptorw1b.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "TALON_DEATH"
            LuaKey.String "separation", LuaValue.String "0.2"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 400.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "speedtofront", LuaValue.Number 0.07
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turnradius", LuaValue.Number 64.0
            LuaKey.String "turnrate", LuaValue.Number 1600.0
            LuaKey.String "unitname", LuaValue.String "raptor_air_fighter_basic_t2_v2"
            LuaKey.String "usesmoothmesh", LuaValue.Bool true
            LuaKey.String "wingangle", LuaValue.Number 0.06593
            LuaKey.String "wingdrag", LuaValue.Number 0.435
            LuaKey.String "workertime", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "KDR_11k, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_m_normals.png"
                    LuaKey.String "treeshader", LuaValue.String "yes"
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:blood_spray"
                            LuaKey.Int 2, LuaValue.String "custom:blood_explode"
                            LuaKey.Int 3, LuaValue.String "custom:dirt"
                        ]
                    LuaKey.String "pieceexplosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "blood_spray"
                            LuaKey.Int 2, LuaValue.String "blood_spray"
                            LuaKey.Int 3, LuaValue.String "blood_spray"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "weapon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 256.0
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cameraShake", LuaValue.Number 700.0
                            LuaKey.String "dance", LuaValue.Number 20.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.35
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-huge-bomb"
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "flighttime", LuaValue.Number 6.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.4
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 4.0
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "SimpleFlareXL.s3o"
                            LuaKey.String "name", LuaValue.String "Deadly Defensive Spores"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1000.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 2.0
                            LuaKey.String "smoketime", LuaValue.Number 45.0
                            LuaKey.String "smokesize", LuaValue.Number 10.5
                            LuaKey.String "smokecolor", LuaValue.Number 1.0
                            LuaKey.String "soundhit", LuaValue.String "spore_explo"
                            LuaKey.String "soundstart", LuaValue.String "spore_xl"
                            LuaKey.String "soundstartvolume", LuaValue.Number 9.0
                            LuaKey.String "startvelocity", LuaValue.Number 1000.0
                            LuaKey.String "texture1", LuaValue.String "orangenovaexplo"
                            LuaKey.String "texture2", LuaValue.String "sporetrail_xl"
                            LuaKey.String "tolerance", LuaValue.Number 60000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 60000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 40.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2000.0
                            LuaKey.String "wobble", LuaValue.Number 32000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1.0
                                    LuaKey.String "vtol", LuaValue.Number 500.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "WEAPON"
                            LuaKey.String "def", LuaValue.String "WEAPON"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 180.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let raptor_air_fighter_basic_t2_v3 =
        LuaValue.Table [
            LuaKey.String "acceleration", LuaValue.Number 2.0
            LuaKey.String "airsightdistance", LuaValue.Number 600.0
            LuaKey.String "amphibious", LuaValue.Bool true
            LuaKey.String "bankscale", LuaValue.String "1"
            LuaKey.String "maxdec", LuaValue.Number 0.2
            LuaKey.String "energycost", LuaValue.Number 2200.0
            LuaKey.String "metalcost", LuaValue.Number 72.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptorw1c.DDS"
            LuaKey.String "buildtime", LuaValue.Number 1875.0
            LuaKey.String "cancrash", LuaValue.Bool false
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canland", LuaValue.Bool true
            LuaKey.String "canloopbackattack", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.Bool true
            LuaKey.String "cansubmerge", LuaValue.Bool false
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collide", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "58 58 58"
            LuaKey.String "collisionvolumetype", LuaValue.String "sphere"
            LuaKey.String "cruisealtitude", LuaValue.Number 220.0
            LuaKey.String "defaultmissiontype", LuaValue.String "VTOL_standby"
            LuaKey.String "explodeas", LuaValue.String "TALON_DEATH"
            LuaKey.String "floater", LuaValue.Bool true
            LuaKey.String "footprintx", LuaValue.Number 1.0
            LuaKey.String "footprintz", LuaValue.Number 1.0
            LuaKey.String "hidedamage", LuaValue.Number 1.0
            LuaKey.String "maneuverleashlength", LuaValue.String "1280"
            LuaKey.String "mass", LuaValue.Number 90.0
            LuaKey.String "maxacc", LuaValue.Number 0.25
            LuaKey.String "maxaileron", LuaValue.Number 0.025
            LuaKey.String "maxbank", LuaValue.Number 0.8
            LuaKey.String "health", LuaValue.Number 350.0
            LuaKey.String "maxelevator", LuaValue.Number 0.025
            LuaKey.String "maxpitch", LuaValue.Number 0.75
            LuaKey.String "maxrudder", LuaValue.Number 0.025
            LuaKey.String "speed", LuaValue.Number 360.0
            LuaKey.String "moverate1", LuaValue.String "32"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "NOTAIR"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor_pidgeonc.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptorw1c.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "TALON_DEATH"
            LuaKey.String "separation", LuaValue.String "0.2"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 400.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "speedtofront", LuaValue.Number 0.07
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turnradius", LuaValue.Number 64.0
            LuaKey.String "turnrate", LuaValue.Number 1600.0
            LuaKey.String "unitname", LuaValue.String "raptor_air_fighter_basic_t2_v3"
            LuaKey.String "usesmoothmesh", LuaValue.Bool true
            LuaKey.String "wingangle", LuaValue.Number 0.06593
            LuaKey.String "wingdrag", LuaValue.Number 0.435
            LuaKey.String "workertime", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "KDR_11k, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_m_normals.png"
                    LuaKey.String "treeshader", LuaValue.String "yes"
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:blood_spray"
                            LuaKey.Int 2, LuaValue.String "custom:blood_explode"
                            LuaKey.Int 3, LuaValue.String "custom:dirt"
                        ]
                    LuaKey.String "pieceexplosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "blood_spray"
                            LuaKey.Int 2, LuaValue.String "blood_spray"
                            LuaKey.Int 3, LuaValue.String "blood_spray"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "weapon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 256.0
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cameraShake", LuaValue.Number 700.0
                            LuaKey.String "dance", LuaValue.Number 20.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.35
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-huge-bomb"
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "flighttime", LuaValue.Number 6.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.4
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 4.0
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "SimpleFlareXL.s3o"
                            LuaKey.String "name", LuaValue.String "Deadly Defensive Spores"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1000.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.75
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 2.0
                            LuaKey.String "smoketime", LuaValue.Number 45.0
                            LuaKey.String "smokesize", LuaValue.Number 10.5
                            LuaKey.String "smokecolor", LuaValue.Number 1.0
                            LuaKey.String "soundhit", LuaValue.String "spore_explo"
                            LuaKey.String "soundstart", LuaValue.String "spore_xl"
                            LuaKey.String "soundstartvolume", LuaValue.Number 9.0
                            LuaKey.String "startvelocity", LuaValue.Number 1000.0
                            LuaKey.String "texture1", LuaValue.String "orangenovaexplo"
                            LuaKey.String "texture2", LuaValue.String "sporetrail_xl"
                            LuaKey.String "tolerance", LuaValue.Number 60000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 60000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 40.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2000.0
                            LuaKey.String "wobble", LuaValue.Number 32000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1.0
                                    LuaKey.String "vtol", LuaValue.Number 500.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "WEAPON"
                            LuaKey.String "def", LuaValue.String "WEAPON"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 180.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let raptor_air_fighter_basic_t2_v4 =
        LuaValue.Table [
            LuaKey.String "acceleration", LuaValue.Number 2.0
            LuaKey.String "airsightdistance", LuaValue.Number 600.0
            LuaKey.String "amphibious", LuaValue.Bool true
            LuaKey.String "bankscale", LuaValue.String "1"
            LuaKey.String "maxdec", LuaValue.Number 0.2
            LuaKey.String "energycost", LuaValue.Number 2200.0
            LuaKey.String "metalcost", LuaValue.Number 72.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptorw1d.DDS"
            LuaKey.String "buildtime", LuaValue.Number 1650.0
            LuaKey.String "cancrash", LuaValue.Bool false
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canland", LuaValue.Bool true
            LuaKey.String "canloopbackattack", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.Bool true
            LuaKey.String "cansubmerge", LuaValue.Bool false
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collide", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "22 22 22"
            LuaKey.String "collisionvolumetype", LuaValue.String "sphere"
            LuaKey.String "cruisealtitude", LuaValue.Number 220.0
            LuaKey.String "defaultmissiontype", LuaValue.String "VTOL_standby"
            LuaKey.String "explodeas", LuaValue.String "TALON_DEATH"
            LuaKey.String "floater", LuaValue.Bool true
            LuaKey.String "footprintx", LuaValue.Number 1.0
            LuaKey.String "footprintz", LuaValue.Number 1.0
            LuaKey.String "hidedamage", LuaValue.Number 1.0
            LuaKey.String "maneuverleashlength", LuaValue.String "1280"
            LuaKey.String "mass", LuaValue.Number 90.0
            LuaKey.String "maxacc", LuaValue.Number 0.25
            LuaKey.String "maxaileron", LuaValue.Number 0.025
            LuaKey.String "maxbank", LuaValue.Number 0.8
            LuaKey.String "health", LuaValue.Number 350.0
            LuaKey.String "maxelevator", LuaValue.Number 0.025
            LuaKey.String "maxpitch", LuaValue.Number 0.75
            LuaKey.String "maxrudder", LuaValue.Number 0.025
            LuaKey.String "speed", LuaValue.Number 360.0
            LuaKey.String "moverate1", LuaValue.String "32"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "NOTAIR"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor_pidgeond.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptorw1d.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "TALON_DEATH"
            LuaKey.String "separation", LuaValue.String "0.2"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 400.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "speedtofront", LuaValue.Number 0.07
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turnradius", LuaValue.Number 64.0
            LuaKey.String "turnrate", LuaValue.Number 1600.0
            LuaKey.String "unitname", LuaValue.String "raptor_air_fighter_basic_t2_v4"
            LuaKey.String "usesmoothmesh", LuaValue.Bool true
            LuaKey.String "wingangle", LuaValue.Number 0.06593
            LuaKey.String "wingdrag", LuaValue.Number 0.435
            LuaKey.String "workertime", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "KDR_11k, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_m_normals.png"
                    LuaKey.String "treeshader", LuaValue.String "yes"
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:blood_spray"
                            LuaKey.Int 2, LuaValue.String "custom:blood_explode"
                            LuaKey.Int 3, LuaValue.String "custom:dirt"
                        ]
                    LuaKey.String "pieceexplosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "blood_spray"
                            LuaKey.Int 2, LuaValue.String "blood_spray"
                            LuaKey.Int 3, LuaValue.String "blood_spray"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "weapon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 256.0
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cameraShake", LuaValue.Number 700.0
                            LuaKey.String "dance", LuaValue.Number 20.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.35
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-huge-bomb"
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "flighttime", LuaValue.Number 6.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.4
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 4.0
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "SimpleFlareXL.s3o"
                            LuaKey.String "name", LuaValue.String "Deadly Defensive Spores"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1000.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.5
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 2.0
                            LuaKey.String "smoketime", LuaValue.Number 45.0
                            LuaKey.String "smokesize", LuaValue.Number 10.5
                            LuaKey.String "smokecolor", LuaValue.Number 1.0
                            LuaKey.String "soundhit", LuaValue.String "spore_explo"
                            LuaKey.String "soundstart", LuaValue.String "spore_xl"
                            LuaKey.String "soundstartvolume", LuaValue.Number 9.0
                            LuaKey.String "startvelocity", LuaValue.Number 1000.0
                            LuaKey.String "texture1", LuaValue.String "orangenovaexplo"
                            LuaKey.String "texture2", LuaValue.String "sporetrail_xl"
                            LuaKey.String "tolerance", LuaValue.Number 60000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 60000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 40.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2000.0
                            LuaKey.String "wobble", LuaValue.Number 32000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1.0
                                    LuaKey.String "vtol", LuaValue.Number 500.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "WEAPON"
                            LuaKey.String "def", LuaValue.String "WEAPON"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 180.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let raptor_air_fighter_basic_t4_v1 =
        LuaValue.Table [
            LuaKey.String "acceleration", LuaValue.Number 2.0
            LuaKey.String "airsightdistance", LuaValue.Number 1500.0
            LuaKey.String "amphibious", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 10.0
            LuaKey.String "bankscale", LuaValue.String "1"
            LuaKey.String "maxdec", LuaValue.Number 0.2
            LuaKey.String "energycost", LuaValue.Number 2200.0
            LuaKey.String "metalcost", LuaValue.Number 72.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptorw2.DDS"
            LuaKey.String "buildtime", LuaValue.Number 1950.0
            LuaKey.String "cancrash", LuaValue.Bool false
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canland", LuaValue.Bool true
            LuaKey.String "canloopbackattack", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.Bool true
            LuaKey.String "cansubmerge", LuaValue.Bool false
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collide", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "58 58 58"
            LuaKey.String "collisionvolumetype", LuaValue.String "sphere"
            LuaKey.String "cruisealtitude", LuaValue.Number 220.0
            LuaKey.String "defaultmissiontype", LuaValue.String "VTOL_standby"
            LuaKey.String "explodeas", LuaValue.String "TALON_DEATH"
            LuaKey.String "floater", LuaValue.Bool true
            LuaKey.String "footprintx", LuaValue.Number 1.0
            LuaKey.String "footprintz", LuaValue.Number 1.0
            LuaKey.String "hidedamage", LuaValue.Number 1.0
            LuaKey.String "maneuverleashlength", LuaValue.String "1280"
            LuaKey.String "mass", LuaValue.Number 200.0
            LuaKey.String "maxacc", LuaValue.Number 0.25
            LuaKey.String "maxaileron", LuaValue.Number 0.025
            LuaKey.String "maxbank", LuaValue.Number 0.8
            LuaKey.String "health", LuaValue.Number 1000.0
            LuaKey.String "maxelevator", LuaValue.Number 0.025
            LuaKey.String "maxpitch", LuaValue.Number 0.75
            LuaKey.String "maxrudder", LuaValue.Number 0.025
            LuaKey.String "speed", LuaValue.Number 450.0
            LuaKey.String "moverate1", LuaValue.String "32"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "NOTAIR"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor_crow.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptorw2.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "TALON_DEATH"
            LuaKey.String "separation", LuaValue.String "0.2"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 600.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "speedtofront", LuaValue.Number 0.07
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turnradius", LuaValue.Number 64.0
            LuaKey.String "turnrate", LuaValue.Number 1600.0
            LuaKey.String "unitname", LuaValue.String "raptor_air_fighter_basic_t4_v1"
            LuaKey.String "usesmoothmesh", LuaValue.Bool true
            LuaKey.String "wingangle", LuaValue.Number 0.06593
            LuaKey.String "wingdrag", LuaValue.Number 0.435
            LuaKey.String "workertime", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "KDR_11k, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_m_normals.png"
                    LuaKey.String "treeshader", LuaValue.String "yes"
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:blood_spray"
                            LuaKey.Int 2, LuaValue.String "custom:blood_explode"
                            LuaKey.Int 3, LuaValue.String "custom:dirt"
                        ]
                    LuaKey.String "pieceexplosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "blood_spray"
                            LuaKey.Int 2, LuaValue.String "blood_spray"
                            LuaKey.Int 3, LuaValue.String "blood_spray"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "weapon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 256.0
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cameraShake", LuaValue.Number 700.0
                            LuaKey.String "dance", LuaValue.Number 20.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.35
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-huge-bomb"
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "flighttime", LuaValue.Number 8.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.4
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 4.0
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "SimpleFlareXL.s3o"
                            LuaKey.String "name", LuaValue.String "Deadly Defensive Spores"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1500.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.5
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 2.0
                            LuaKey.String "smoketime", LuaValue.Number 45.0
                            LuaKey.String "smokesize", LuaValue.Number 10.5
                            LuaKey.String "smokecolor", LuaValue.Number 1.0
                            LuaKey.String "soundhit", LuaValue.String "spore_explo"
                            LuaKey.String "soundstart", LuaValue.String "spore_xl"
                            LuaKey.String "soundstartvolume", LuaValue.Number 9.0
                            LuaKey.String "startvelocity", LuaValue.Number 1000.0
                            LuaKey.String "texture1", LuaValue.String "orangenovaexplo"
                            LuaKey.String "texture2", LuaValue.String "sporetrail_xl"
                            LuaKey.String "tolerance", LuaValue.Number 60000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 60000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 40.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2000.0
                            LuaKey.String "wobble", LuaValue.Number 32000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1.0
                                    LuaKey.String "vtol", LuaValue.Number 1250.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR"
                            LuaKey.String "def", LuaValue.String "WEAPON"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 90.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let all : (string * LuaValue) list =
        [
            "raptor_air_fighter_basic_t1_v1", raptor_air_fighter_basic_t1_v1
            "raptor_air_fighter_basic_t2_v1", raptor_air_fighter_basic_t2_v1
            "raptor_air_fighter_basic_t2_v2", raptor_air_fighter_basic_t2_v2
            "raptor_air_fighter_basic_t2_v3", raptor_air_fighter_basic_t2_v3
            "raptor_air_fighter_basic_t2_v4", raptor_air_fighter_basic_t2_v4
            "raptor_air_fighter_basic_t4_v1", raptor_air_fighter_basic_t4_v1
        ]
