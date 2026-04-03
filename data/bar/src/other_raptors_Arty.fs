// Auto-generated BAR unit data: other/raptors/Arty
namespace BarData.Units

open BarData

module other_raptors_Arty =

    let raptor_allterrain_arty_basic_t2_v1 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.115
            LuaKey.String "maxdec", LuaValue.Number 0.414
            LuaKey.String "energycost", LuaValue.Number 12320.0
            LuaKey.String "metalcost", LuaValue.Number 396.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptorr1.DDS"
            LuaKey.String "buildtime", LuaValue.Number 6750.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 1 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "25 34 44"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "explodeas", LuaValue.String "BIGBUG_DEATH"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "hidedamage", LuaValue.Number 1.0
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "maneuverleashlength", LuaValue.String "640"
            LuaKey.String "mass", LuaValue.Number 4000.0
            LuaKey.String "health", LuaValue.Number 2000.0
            LuaKey.String "maxslope", LuaValue.Number 18.0
            LuaKey.String "speed", LuaValue.Number 42.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "RAPTORALLTERRAINBIGHOVER"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor_artillery_v2.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptor_artillery_v2.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "BIGBUG_DEATH"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 750.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "trackoffset", LuaValue.Number 6.0
            LuaKey.String "trackstrength", LuaValue.Number 3.0
            LuaKey.String "trackstretch", LuaValue.Number 1.0
            LuaKey.String "tracktype", LuaValue.String "RaptorTrack"
            LuaKey.String "trackwidth", LuaValue.Number 30.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 1840.0
            LuaKey.String "unitname", LuaValue.String "raptorr1"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "workertime", LuaValue.Number 0.0
            LuaKey.String "waterline", LuaValue.Number 10.0
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
                    LuaKey.String "goolauncher", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 1024.0
                            LuaKey.String "areaofeffect", LuaValue.Number 256.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "burst", LuaValue.Number 1.0
                            LuaKey.String "burstrate", LuaValue.Number 0.001
                            LuaKey.String "cegtag", LuaValue.String "blob_trail_red"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 256.0
                            LuaKey.String "craterboost", LuaValue.Number 0.2
                            LuaKey.String "cratermult", LuaValue.Number 0.2
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.63
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-huge"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.4
                            LuaKey.String "intensity", LuaValue.Number 0.7
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 1.0
                            LuaKey.String "name", LuaValue.String "GOOLAUNCHER"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number -1.0
                            LuaKey.String "range", LuaValue.Number 1500.0
                            LuaKey.String "reloadtime", LuaValue.Number 20.0
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.5 0.1"
                            LuaKey.String "size", LuaValue.Number 5.5
                            LuaKey.String "sizedecay", LuaValue.Number 0.09
                            LuaKey.String "soundhit", LuaValue.String "bombsmed2"
                            LuaKey.String "soundstart", LuaValue.String "bugarty"
                            LuaKey.String "sprayangle", LuaValue.Number 1024.0
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weapontimer", LuaValue.Number 0.2
                            LuaKey.String "weaponvelocity", LuaValue.Number 520.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1280.0
                                    LuaKey.String "shields", LuaValue.Number 320.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "MOBILE"
                            LuaKey.String "def", LuaValue.String "GOOLAUNCHER"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 50.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                ]
        ]

    let raptor_allterrain_arty_basic_t4_v1 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 1.15
            LuaKey.String "maxdec", LuaValue.Number 9.2
            LuaKey.String "energycost", LuaValue.Number 12320.0
            LuaKey.String "metalcost", LuaValue.Number 396.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptorr2.DDS"
            LuaKey.String "buildtime", LuaValue.Number 270000.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -1 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "120 80 120"
            LuaKey.String "collisionvolumetest", LuaValue.Number 1.0
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "explodeas", LuaValue.String "LOBBER_MORPH"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "hidedamage", LuaValue.Number 1.0
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "maneuverleashlength", LuaValue.String "640"
            LuaKey.String "mass", LuaValue.Number 40000.0
            LuaKey.String "health", LuaValue.Number 8000.0
            LuaKey.String "maxslope", LuaValue.Number 18.0
            LuaKey.String "speed", LuaValue.Number 84.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "RAPTORALLTERRAINBIG2HOVER"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor_artillery_meteor_v2.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptor_artillery_v2.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "LOBBER_MORPH"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 1000.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "trackoffset", LuaValue.Number 6.0
            LuaKey.String "trackstrength", LuaValue.Number 3.0
            LuaKey.String "trackstretch", LuaValue.Number 1.0
            LuaKey.String "tracktype", LuaValue.String "RaptorTrack"
            LuaKey.String "trackwidth", LuaValue.Number 100.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 600.0
            LuaKey.String "unitname", LuaValue.String "raptorr2"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 10.0
            LuaKey.String "workertime", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
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
                        ]
                    LuaKey.String "pieceexplosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "blood_spray"
                            LuaKey.Int 2, LuaValue.String "blood_spray"
                            LuaKey.Int 3, LuaValue.String "blood_spray"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "goolauncher", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 2048.0
                            LuaKey.String "areaofeffect", LuaValue.Number 256.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "burst", LuaValue.Number 4.0
                            LuaKey.String "burstrate", LuaValue.Number 0.001
                            LuaKey.String "cegtag", LuaValue.String "blob_trail_red"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 256.0
                            LuaKey.String "craterboost", LuaValue.Number 0.2
                            LuaKey.String "cratermult", LuaValue.Number 0.2
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.63
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-huge"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.4
                            LuaKey.String "intensity", LuaValue.Number 0.7
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 1.0
                            LuaKey.String "name", LuaValue.String "GOOLAUNCHER"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number -1.0
                            LuaKey.String "range", LuaValue.Number 2000.0
                            LuaKey.String "reloadtime", LuaValue.Number 20.0
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.5 0.1"
                            LuaKey.String "size", LuaValue.Number 5.5
                            LuaKey.String "sizedecay", LuaValue.Number 0.09
                            LuaKey.String "soundhit", LuaValue.String "bombsmed2"
                            LuaKey.String "soundstart", LuaValue.String "bugarty"
                            LuaKey.String "sprayangle", LuaValue.Number 2048.0
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weapontimer", LuaValue.Number 0.2
                            LuaKey.String "weaponvelocity", LuaValue.Number 520.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1280.0
                                    LuaKey.String "shields", LuaValue.Number 320.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "MOBILE"
                            LuaKey.String "def", LuaValue.String "GOOLAUNCHER"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 50.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                ]
        ]

    let raptorartillery =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.115
            LuaKey.String "maxdec", LuaValue.Number 0.414
            LuaKey.String "energycost", LuaValue.Number 12320.0
            LuaKey.String "metalcost", LuaValue.Number 396.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptorr1.DDS"
            LuaKey.String "buildtime", LuaValue.Number 6750.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 1 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "25 34 44"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "explodeas", LuaValue.String "BIGBUG_DEATH"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "hidedamage", LuaValue.Number 1.0
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "maneuverleashlength", LuaValue.String "640"
            LuaKey.String "mass", LuaValue.Number 4000.0
            LuaKey.String "health", LuaValue.Number 2000.0
            LuaKey.String "maxslope", LuaValue.Number 18.0
            LuaKey.String "speed", LuaValue.Number 42.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "RAPTORALLTERRAINBIGHOVER"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptorartillery.dae"
            LuaKey.String "script", LuaValue.String "Raptors/raptorartillery.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "BIGBUG_DEATH"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 750.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "trackoffset", LuaValue.Number 6.0
            LuaKey.String "trackstrength", LuaValue.Number 3.0
            LuaKey.String "trackstretch", LuaValue.Number 1.0
            LuaKey.String "tracktype", LuaValue.String "RaptorTrack"
            LuaKey.String "trackwidth", LuaValue.Number 30.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 1840.0
            LuaKey.String "unitname", LuaValue.String "raptorartillery"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "workertime", LuaValue.Number 0.0
            LuaKey.String "waterline", LuaValue.Number 10.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "Rubus"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/raptorArtillery_n.png"
                    LuaKey.String "useskinning", LuaValue.String "yes"
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
                    LuaKey.String "goolauncher", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 1024.0
                            LuaKey.String "areaofeffect", LuaValue.Number 256.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "burst", LuaValue.Number 1.0
                            LuaKey.String "burstrate", LuaValue.Number 0.001
                            LuaKey.String "cegtag", LuaValue.String "blob_trail_red"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 256.0
                            LuaKey.String "craterboost", LuaValue.Number 0.2
                            LuaKey.String "cratermult", LuaValue.Number 0.2
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.63
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-huge"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.4
                            LuaKey.String "intensity", LuaValue.Number 0.7
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 1.0
                            LuaKey.String "name", LuaValue.String "GOOLAUNCHER"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number -1.0
                            LuaKey.String "range", LuaValue.Number 1500.0
                            LuaKey.String "reloadtime", LuaValue.Number 20.0
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.5 0.1"
                            LuaKey.String "size", LuaValue.Number 5.5
                            LuaKey.String "sizedecay", LuaValue.Number 0.09
                            LuaKey.String "soundhit", LuaValue.String "bombsmed2"
                            LuaKey.String "soundstart", LuaValue.String "bugarty"
                            LuaKey.String "sprayangle", LuaValue.Number 1024.0
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weapontimer", LuaValue.Number 0.2
                            LuaKey.String "weaponvelocity", LuaValue.Number 520.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1280.0
                                    LuaKey.String "shields", LuaValue.Number 320.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "MOBILE"
                            LuaKey.String "def", LuaValue.String "GOOLAUNCHER"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 50.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                ]
        ]

    let all : (string * LuaValue) list =
        [
            "raptor_allterrain_arty_basic_t2_v1", raptor_allterrain_arty_basic_t2_v1
            "raptor_allterrain_arty_basic_t4_v1", raptor_allterrain_arty_basic_t4_v1
            "raptorartillery", raptorartillery
        ]
