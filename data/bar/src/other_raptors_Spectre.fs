// Auto-generated BAR unit data: other/raptors/Spectre
namespace BarData.Units

open BarData

module other_raptors_Spectre =

    let raptor_land_assault_spectre_t2_v1 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.414
            LuaKey.String "airsightdistance", LuaValue.Number 650.0
            LuaKey.String "maxdec", LuaValue.Number 0.46
            LuaKey.String "energycost", LuaValue.Number 3520.0
            LuaKey.String "metalcost", LuaValue.Number 152.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptora1_spectre.DDS"
            LuaKey.String "buildtime", LuaValue.Number 9000.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "cancloak", LuaValue.Bool true
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "cloakcost", LuaValue.Number 0.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 0.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -10 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "27 48 60"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "explodeas", LuaValue.String "BIGBUG_DEATH"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "initcloak", LuaValue.Bool true
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "maneuverleashlength", LuaValue.String "640"
            LuaKey.String "mass", LuaValue.Number 100000.0
            LuaKey.String "health", LuaValue.Number 2500.0
            LuaKey.String "maxslope", LuaValue.Number 18.0
            LuaKey.String "speed", LuaValue.Number 39.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "RAPTORBIGHOVER"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptora_spectre.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptora1.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 3.0
            LuaKey.String "selfdestructas", LuaValue.String "BIGBUG_DEATH"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 300.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "stealth", LuaValue.Number 1.0
            LuaKey.String "trackoffset", LuaValue.Number 7.0
            LuaKey.String "trackstrength", LuaValue.Number 3.0
            LuaKey.String "trackstretch", LuaValue.Number 1.0
            LuaKey.String "tracktype", LuaValue.String "RaptorTrack"
            LuaKey.String "trackwidth", LuaValue.Number 34.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 920.0
            LuaKey.String "unitname", LuaValue.String "raptor_land_assault_spectre_t2_v1"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 24.0
            LuaKey.String "workertime", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "maxrange", LuaValue.String "200"
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "KDR_11k, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_l_normals.png"
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:blood_spray"
                            LuaKey.Int 2, LuaValue.String "custom:blood_explode"
                            LuaKey.Int 3, LuaValue.String "custom:dirt"
                            LuaKey.Int 4, LuaValue.String "custom:blob_fire"
                            LuaKey.Int 5, LuaValue.String "custom:blood_explode"
                            LuaKey.Int 6, LuaValue.String "custom:blood_spray"
                            LuaKey.Int 7, LuaValue.String "custom:dirt"
                        ]
                    LuaKey.String "pieceexplosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "blood_spray"
                            LuaKey.Int 2, LuaValue.String "blood_spray"
                            LuaKey.Int 3, LuaValue.String "blood_spray"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "aaweapon", LuaValue.Table [
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
                            LuaKey.String "flighttime", LuaValue.Number 5.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.4
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 4.0
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "SimpleFlareXL.s3o"
                            LuaKey.String "name", LuaValue.String "Deadly Defensive Spores"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 750.0
                            LuaKey.String "reloadtime", LuaValue.Number 20.0
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
                            LuaKey.String "trajectoryheight", LuaValue.Number 2.0
                            LuaKey.String "turnrate", LuaValue.Number 60000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 40.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2000.0
                            LuaKey.String "wobble", LuaValue.Number 32000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1.0
                                    LuaKey.String "vtol", LuaValue.Number 2000.0
                                ]
                        ]
                    LuaKey.String "weapon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 42.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.3
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:raptorspike-medium-sparks-burn"
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 1.0
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "Raptors/spike.s3o"
                            LuaKey.String "name", LuaValue.String "Claws"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 200.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.0
                            LuaKey.String "soundstart", LuaValue.String "smallraptorattack"
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 200.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "WEAPON"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 125.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "AAWEAPON"
                        ]
                ]
        ]

    let raptor_land_assault_spectre_t4_v1 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.414
            LuaKey.String "airsightdistance", LuaValue.Number 1800.0
            LuaKey.String "autoheal", LuaValue.Number 25.0
            LuaKey.String "maxdec", LuaValue.Number 0.46
            LuaKey.String "energycost", LuaValue.Number 3520.0
            LuaKey.String "metalcost", LuaValue.Number 302.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptora2_spectre.DDS"
            LuaKey.String "buildtime", LuaValue.Number 30000.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "cancloak", LuaValue.Bool true
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "cloakcost", LuaValue.Number 0.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 0.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 2"
            LuaKey.String "collisionvolumescales", LuaValue.String "37 75 130"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "explodeas", LuaValue.String "MEGABUG_DEATH"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "initcloak", LuaValue.Bool true
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "maneuverleashlength", LuaValue.String "640"
            LuaKey.String "mass", LuaValue.Number 200000.0
            LuaKey.String "health", LuaValue.Number 10000.0
            LuaKey.String "maxslope", LuaValue.Number 18.0
            LuaKey.String "speed", LuaValue.Number 30.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "RAPTORBIG2HOVER"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptora2_spectre.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptora2.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 4.0
            LuaKey.String "selfdestructas", LuaValue.String "MEGABUG_DEATH"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 400.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "stealth", LuaValue.Number 1.0
            LuaKey.String "trackoffset", LuaValue.Number 7.0
            LuaKey.String "trackstrength", LuaValue.Number 3.0
            LuaKey.String "trackstretch", LuaValue.Number 1.0
            LuaKey.String "tracktype", LuaValue.String "RaptorTrack"
            LuaKey.String "trackwidth", LuaValue.Number 38.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 920.0
            LuaKey.String "unitname", LuaValue.String "raptor_land_assault_spectre_t4_v1"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 40.0
            LuaKey.String "workertime", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "maxrange", LuaValue.String "200"
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "KDR_11k, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_l_normals.png"
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:blood_spray"
                            LuaKey.Int 2, LuaValue.String "custom:blood_explode"
                            LuaKey.Int 3, LuaValue.String "custom:dirt"
                            LuaKey.Int 4, LuaValue.String "custom:blob_fire"
                        ]
                    LuaKey.String "pieceexplosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "blood_spray"
                            LuaKey.Int 2, LuaValue.String "blood_spray"
                            LuaKey.Int 3, LuaValue.String "blood_spray"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "aaweapon", LuaValue.Table [
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
                            LuaKey.String "flighttime", LuaValue.Number 5.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.4
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 4.0
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "SimpleFlareXL.s3o"
                            LuaKey.String "name", LuaValue.String "Deadly Defensive Spores"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1000.0
                            LuaKey.String "reloadtime", LuaValue.Number 5.0
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
                            LuaKey.String "trajectoryheight", LuaValue.Number 2.0
                            LuaKey.String "turnrate", LuaValue.Number 60000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 40.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2000.0
                            LuaKey.String "wobble", LuaValue.Number 32000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1.0
                                    LuaKey.String "vtol", LuaValue.Number 2000.0
                                ]
                        ]
                    LuaKey.String "weapon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 42.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.3
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:raptorspike-large-sparks-burn"
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 1.0
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "Raptors/spike.s3o"
                            LuaKey.String "name", LuaValue.String "Claws"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 400.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.6
                            LuaKey.String "soundstart", LuaValue.String "smallraptorattack"
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 550.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "WEAPON"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 125.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "AAWEAPON"
                        ]
                ]
        ]

    let raptor_land_spiker_spectre_t4_v1 =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "maxacc", LuaValue.Number 3.45
            LuaKey.String "maxdec", LuaValue.Number 3.45
            LuaKey.String "energycost", LuaValue.Number 174.0
            LuaKey.String "metalcost", LuaValue.Number 174.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptors2_spectre.DDS"
            LuaKey.String "buildtime", LuaValue.Number 10500.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "cancloak", LuaValue.Bool true
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "cloakcost", LuaValue.Number 0.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 0.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -1 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "24 34 53"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "explodeas", LuaValue.String "BUG_DEATH"
            LuaKey.String "floater", LuaValue.Bool false
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "initcloaked", LuaValue.Number 1.0
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "maneuverleashlength", LuaValue.String "750"
            LuaKey.String "mass", LuaValue.Number 300.0
            LuaKey.String "health", LuaValue.Number 1250.0
            LuaKey.String "maxslope", LuaValue.Number 18.0
            LuaKey.String "speed", LuaValue.Number 270.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "RAPTORSMALLHOVER"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptors2_spectre.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptors2.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 2.0
            LuaKey.String "selfdestructas", LuaValue.String "BUG_DEATH"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 950.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "sonardistance", LuaValue.Number 720.0
            LuaKey.String "stealth", LuaValue.Number 1.0
            LuaKey.String "trackoffset", LuaValue.Number 6.0
            LuaKey.String "trackstrength", LuaValue.Number 3.0
            LuaKey.String "trackstretch", LuaValue.Number 1.0
            LuaKey.String "tracktype", LuaValue.String "RaptorTrack"
            LuaKey.String "trackwidth", LuaValue.Number 30.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 1840.0
            LuaKey.String "unitname", LuaValue.String "raptor_land_spiker_spectre_t4_v1"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "workertime", LuaValue.Number 0.0
            LuaKey.String "waterline", LuaValue.Number 29.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "maxrange", LuaValue.String "375"
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "KDR_11k, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_m_normals.png"
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
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "cegtag", LuaValue.String "sporetrail-large"
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "collidefeature", LuaValue.Bool true
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.3
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:raptorspike-huge-sparks-burn"
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.4
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "Raptors/spike.s3o"
                            LuaKey.String "name", LuaValue.String "Spike"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 950.0
                            LuaKey.String "reloadtime", LuaValue.Number 6.0
                            LuaKey.String "soundstart", LuaValue.String "smallraptorattack"
                            LuaKey.String "startvelocity", LuaValue.Number 600.0
                            LuaKey.String "texture1", LuaValue.String ""
                            LuaKey.String "texture2", LuaValue.String "sporetrail"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool false
                            LuaKey.String "weapontimer", LuaValue.Number 1.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 600.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "WEAPON"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 180.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                ]
        ]

    let raptor_land_swarmer_spectre_t3_v1 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.345
            LuaKey.String "autoheal", LuaValue.Number 3.0
            LuaKey.String "maxdec", LuaValue.Number 0.345
            LuaKey.String "energycost", LuaValue.Number 79.0
            LuaKey.String "metalcost", LuaValue.Number 79.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptor1x_spectre.DDS"
            LuaKey.String "buildtime", LuaValue.Number 1500.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "cancloak", LuaValue.Bool true
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "cloakcost", LuaValue.Number 0.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 0.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -3 -3"
            LuaKey.String "collisionvolumescales", LuaValue.String "18 40 40"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "explodeas", LuaValue.String "BUG_DEATH"
            LuaKey.String "floater", LuaValue.Bool false
            LuaKey.String "footprintx", LuaValue.Number 1.0
            LuaKey.String "footprintz", LuaValue.Number 1.0
            LuaKey.String "initcloak", LuaValue.Bool true
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "maneuverleashlength", LuaValue.Number 640.0
            LuaKey.String "mass", LuaValue.Number 90.0
            LuaKey.String "health", LuaValue.Number 500.0
            LuaKey.String "maxslope", LuaValue.Number 18.0
            LuaKey.String "speed", LuaValue.Number 150.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "RAPTORSMALLHOVER"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor1x_spectre.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptor1x.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 2.0
            LuaKey.String "selfdestructas", LuaValue.String "BUG_DEATH"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 200.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "stealth", LuaValue.Number 1.0
            LuaKey.String "trackoffset", LuaValue.Number 0.0
            LuaKey.String "trackstrength", LuaValue.Number 3.0
            LuaKey.String "trackstretch", LuaValue.Number 1.0
            LuaKey.String "tracktype", LuaValue.String "RaptorTrack"
            LuaKey.String "trackwidth", LuaValue.Number 18.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 1840.0
            LuaKey.String "unitname", LuaValue.String "raptor_land_swarmer_spectre_t3_v1"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 19.0
            LuaKey.String "workertime", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "KDR_11k, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_s_normals.png"
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
                            LuaKey.String "areaofeffect", LuaValue.Number 24.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.3
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:raptorspike-small-sparks-burn"
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 1.0
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "Raptors/spike.s3o"
                            LuaKey.String "name", LuaValue.String "Claws"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 200.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.8
                            LuaKey.String "soundstart", LuaValue.String "smallraptorattack"
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 0.1
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 120.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "WEAPON"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 180.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                ]
        ]

    let raptor_land_swarmer_spectre_t4_v1 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.4025
            LuaKey.String "maxdec", LuaValue.Number 0.345
            LuaKey.String "energycost", LuaValue.Number 1000.0
            LuaKey.String "metalcost", LuaValue.Number 100.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptor2_spectre.DDS"
            LuaKey.String "buildtime", LuaValue.Number 7500.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "cancloak", LuaValue.Bool true
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "cloakcost", LuaValue.Number 0.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 0.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -1 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "20 40 44"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "explodeas", LuaValue.String "BUG_DEATH"
            LuaKey.String "floater", LuaValue.Bool false
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "initcloak", LuaValue.Bool true
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "maneuverleashlength", LuaValue.Number 640.0
            LuaKey.String "mass", LuaValue.Number 200.0
            LuaKey.String "health", LuaValue.Number 1300.0
            LuaKey.String "maxslope", LuaValue.Number 18.0
            LuaKey.String "speed", LuaValue.Number 180.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "RAPTORSMALLHOVER"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor2_spectre.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptor2.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 2.0
            LuaKey.String "selfdestructas", LuaValue.String "BUG_DEATH"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 200.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "stealth", LuaValue.Number 1.0
            LuaKey.String "trackoffset", LuaValue.Number 0.0
            LuaKey.String "trackstrength", LuaValue.Number 3.0
            LuaKey.String "trackstretch", LuaValue.Number 1.0
            LuaKey.String "tracktype", LuaValue.String "RaptorTrack"
            LuaKey.String "trackwidth", LuaValue.Number 18.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 1840.0
            LuaKey.String "unitname", LuaValue.String "raptor_land_swarmer_spectre_t4_v1"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 22.0
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
                            LuaKey.String "areaofeffect", LuaValue.Number 24.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.3
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:raptorspike-medium-sparks-burn"
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 1.0
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "Raptors/spike.s3o"
                            LuaKey.String "name", LuaValue.String "Claws"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 200.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.4
                            LuaKey.String "soundstart", LuaValue.String "smallraptorattack"
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 0.1
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 300.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "WEAPON"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 180.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                ]
        ]

    let all : (string * LuaValue) list =
        [
            "raptor_land_assault_spectre_t2_v1", raptor_land_assault_spectre_t2_v1
            "raptor_land_assault_spectre_t4_v1", raptor_land_assault_spectre_t4_v1
            "raptor_land_spiker_spectre_t4_v1", raptor_land_spiker_spectre_t4_v1
            "raptor_land_swarmer_spectre_t3_v1", raptor_land_swarmer_spectre_t3_v1
            "raptor_land_swarmer_spectre_t4_v1", raptor_land_swarmer_spectre_t4_v1
        ]
