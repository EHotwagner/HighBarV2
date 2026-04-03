// Auto-generated BAR unit data: other/raptors/Flamer
namespace BarData.Units

open BarData

module other_raptors_Flamer =

    let raptor_allterrain_swarmer_fire_t2_v1 =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "maxacc", LuaValue.Number 1.4375
            LuaKey.String "maxdec", LuaValue.Number 2.3
            LuaKey.String "energycost", LuaValue.Number 5280.0
            LuaKey.String "metalcost", LuaValue.Number 99.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptorpyroallterrain.DDS"
            LuaKey.String "buildtime", LuaValue.Number 2250.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -3 -3"
            LuaKey.String "collisionvolumescales", LuaValue.String "18 28 40"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "explodeas", LuaValue.String "BUG_DEATH"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "maneuverleashlength", LuaValue.String "640"
            LuaKey.String "mass", LuaValue.Number 89.0
            LuaKey.String "health", LuaValue.Number 2000.0
            LuaKey.String "maxreversevelocity", LuaValue.Number 3.0
            LuaKey.String "maxslope", LuaValue.Number 18.0
            LuaKey.String "speed", LuaValue.Number 97.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 15.0
            LuaKey.String "movementclass", LuaValue.String "RAPTORALLTERRAINHOVER"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptorpyroallterrain.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptorpyroallterrain.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "BIGBUG_DEATH"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 300.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "sonardistance", LuaValue.Number 450.0
            LuaKey.String "trackoffset", LuaValue.Number 0.5
            LuaKey.String "trackstrength", LuaValue.Number 3.0
            LuaKey.String "trackstretch", LuaValue.Number 1.0
            LuaKey.String "tracktype", LuaValue.String "RaptorTrackPointy"
            LuaKey.String "trackwidth", LuaValue.Number 35.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 1840.0
            LuaKey.String "unitname", LuaValue.String "raptorc3"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 10.0
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
                    LuaKey.String "flamer", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 64.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "avoidground", LuaValue.Bool false
                            LuaKey.String "bounceSlip", LuaValue.Number 1.0
                            LuaKey.String "burst", LuaValue.Number 12.0
                            LuaKey.String "burstrate", LuaValue.Number 0.03333
                            LuaKey.String "cegtag", LuaValue.String "burnflamethermite"
                            LuaKey.String "colormap", LuaValue.String "1 0.95 0.9 0.032   0.55 0.55 0.40 0.028   0.40 0.28 0.19 0.024   0.033 0.018 0.011 0.04   0.0 0.0 0.0 0.01"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.3
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:burnthermite"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "flamegfxtime", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.65
                            LuaKey.String "name", LuaValue.String "FlameThrower"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 300.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.0
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.94 0.88"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.9 0.83 0.77"
                            LuaKey.String "sizegrowth", LuaValue.Number 2.0
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "cflamhvy1"
                            LuaKey.String "soundtrigger", LuaValue.Bool false
                            LuaKey.String "sprayangle", LuaValue.Number 100.0
                            LuaKey.String "targetmoveerror", LuaValue.Number 0.001
                            LuaKey.String "tolerance", LuaValue.Number 2500.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 1.0
                            LuaKey.String "weapontype", LuaValue.String "Flame"
                            LuaKey.String "weaponvelocity", LuaValue.Number 265.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 16.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "flamer"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 110.0
                        ]
                ]
        ]

    let raptor_land_swarmer_fire_t2_v1 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 1.035
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 50.0
            LuaKey.String "maxdec", LuaValue.Number 0.805
            LuaKey.String "energycost", LuaValue.Number 15000.0
            LuaKey.String "metalcost", LuaValue.Number 250.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptorp1.DDS"
            LuaKey.String "buildtime", LuaValue.Number 4500.0
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -2 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "25 31 44"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "explodeas", LuaValue.String "flamebug_death"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "maneuverleashlength", LuaValue.String "640"
            LuaKey.String "mass", LuaValue.Number 600.0
            LuaKey.String "health", LuaValue.Number 500.0
            LuaKey.String "speed", LuaValue.Number 135.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "RAPTORSMALLHOVER"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptorp2.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptorr2.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "flamebug_death"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 300.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "trackoffset", LuaValue.Number 0.0
            LuaKey.String "trackstrength", LuaValue.Number 3.0
            LuaKey.String "trackstretch", LuaValue.Number 1.0
            LuaKey.String "tracktype", LuaValue.String "RaptorTrack"
            LuaKey.String "trackwidth", LuaValue.Number 35.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 1840.0
            LuaKey.String "unitname", LuaValue.String "raptorp2"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "workertime", LuaValue.Number 0.0
            LuaKey.String "waterline", LuaValue.Number 24.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "maxrange", LuaValue.String "200"
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
                    LuaKey.String "chaseweapon", LuaValue.Table [
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.3
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:raptorspike-large-sparks-burn"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 4.0
                            LuaKey.String "name", LuaValue.String "Claws"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number -1.0
                            LuaKey.String "range", LuaValue.Number 200.0
                            LuaKey.String "reloadtime", LuaValue.Number 30.0
                            LuaKey.String "size", LuaValue.Number 0.001
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.String "true"
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 0.001
                                ]
                        ]
                    LuaKey.String "flamer", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 64.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "avoidground", LuaValue.Bool false
                            LuaKey.String "bounceSlip", LuaValue.Number 1.0
                            LuaKey.String "burst", LuaValue.Number 12.0
                            LuaKey.String "burstrate", LuaValue.Number 0.03333
                            LuaKey.String "cegtag", LuaValue.String "burnflamethermite"
                            LuaKey.String "colormap", LuaValue.String "1 0.95 0.9 0.032   0.55 0.55 0.40 0.028   0.40 0.28 0.19 0.024   0.033 0.018 0.011 0.04   0.0 0.0 0.0 0.01"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.3
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:burnthermite"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "flamegfxtime", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.65
                            LuaKey.String "name", LuaValue.String "FlameThrower"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 300.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.0
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.94 0.88"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.9 0.83 0.77"
                            LuaKey.String "sizegrowth", LuaValue.Number 2.0
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "cflamhvy1"
                            LuaKey.String "soundtrigger", LuaValue.Bool false
                            LuaKey.String "sprayangle", LuaValue.Number 100.0
                            LuaKey.String "targetmoveerror", LuaValue.Number 0.001
                            LuaKey.String "tolerance", LuaValue.Number 2500.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 1.0
                            LuaKey.String "weapontype", LuaValue.String "Flame"
                            LuaKey.String "weaponvelocity", LuaValue.Number 265.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 16.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "CHASEWEAPON"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "FLAMER"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 270.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                ]
        ]

    let raptor_land_swarmer_fire_t4_v1 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 1.15
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 27.0
            LuaKey.String "maxdec", LuaValue.Number 0.69
            LuaKey.String "energycost", LuaValue.Number 6000.0
            LuaKey.String "metalcost", LuaValue.Number 200.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptorp2.DDS"
            LuaKey.String "buildtime", LuaValue.Number 7500.0
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 2 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "40 48 70"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "explodeas", LuaValue.String "FLAMEBUG_DEATH"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "maneuverleashlength", LuaValue.String "640"
            LuaKey.String "mass", LuaValue.Number 1800.0
            LuaKey.String "health", LuaValue.Number 5000.0
            LuaKey.String "speed", LuaValue.Number 105.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "RAPTORSMALLHOVER"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor_listener.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptorp1.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "FLAMEBUG_DEATH"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 410.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "trackoffset", LuaValue.Number 0.0
            LuaKey.String "trackstrength", LuaValue.Number 3.0
            LuaKey.String "trackstretch", LuaValue.Number 1.0
            LuaKey.String "tracktype", LuaValue.String "RaptorTrack"
            LuaKey.String "trackwidth", LuaValue.Number 50.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 920.0
            LuaKey.String "unitname", LuaValue.String "raptorp1"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "workertime", LuaValue.Number 0.0
            LuaKey.String "waterline", LuaValue.Number 42.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "maxrange", LuaValue.String "200"
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
                            LuaKey.Int 4, LuaValue.String "custom:flamestreamxl"
                        ]
                    LuaKey.String "pieceexplosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "blood_spray"
                            LuaKey.Int 2, LuaValue.String "blood_spray"
                            LuaKey.Int 3, LuaValue.String "blood_spray"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "chaseweapon", LuaValue.Table [
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.3
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:raptorspike-large-sparks-burn"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 4.0
                            LuaKey.String "name", LuaValue.String "Claws"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number -1.0
                            LuaKey.String "range", LuaValue.Number 200.0
                            LuaKey.String "reloadtime", LuaValue.Number 30.0
                            LuaKey.String "size", LuaValue.Number 1E-05
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.String "true"
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 0.001
                                ]
                        ]
                    LuaKey.String "flamethrower", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 64.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "avoidground", LuaValue.Bool false
                            LuaKey.String "bounceSlip", LuaValue.Number 1.0
                            LuaKey.String "burst", LuaValue.Number 12.0
                            LuaKey.String "burstrate", LuaValue.Number 0.03333
                            LuaKey.String "cegtag", LuaValue.String "burnflamethermite"
                            LuaKey.String "colormap", LuaValue.String "1 0.95 0.9 0.032   0.55 0.55 0.40 0.028   0.40 0.28 0.19 0.024   0.033 0.018 0.011 0.04   0.0 0.0 0.0 0.01"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.3
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:burnthermite"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "flamegfxtime", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.65
                            LuaKey.String "name", LuaValue.String "FlameThrower"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 410.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.0
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.94 0.88"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.9 0.83 0.77"
                            LuaKey.String "sizegrowth", LuaValue.Number 1.5
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "cflamhvy1"
                            LuaKey.String "soundtrigger", LuaValue.Bool false
                            LuaKey.String "sprayangle", LuaValue.Number 100.0
                            LuaKey.String "targetmoveerror", LuaValue.Number 0.001
                            LuaKey.String "tolerance", LuaValue.Number 2500.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 1.0
                            LuaKey.String "weapontype", LuaValue.String "Flame"
                            LuaKey.String "weaponvelocity", LuaValue.Number 265.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 100.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "CHASEWEAPON"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "FLAMETHROWER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let all : (string * LuaValue) list =
        [
            "raptor_allterrain_swarmer_fire_t2_v1", raptor_allterrain_swarmer_fire_t2_v1
            "raptor_land_swarmer_fire_t2_v1", raptor_land_swarmer_fire_t2_v1
            "raptor_land_swarmer_fire_t4_v1", raptor_land_swarmer_fire_t4_v1
        ]
