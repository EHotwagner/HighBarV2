// Auto-generated BAR unit data: other/raptors/Acid
namespace BarData.Units

open BarData

module other_raptors_Acid =

    let raptor_air_bomber_acid_t2_v1 =
        LuaValue.Table [
            LuaKey.String "acceleration", LuaValue.Number 1.0
            LuaKey.String "airhoverfactor", LuaValue.Number 0.0
            LuaKey.String "attackrunlength", LuaValue.Number 32.0
            LuaKey.String "maxdec", LuaValue.Number 0.1
            LuaKey.String "energycost", LuaValue.Number 50.0
            LuaKey.String "metalcost", LuaValue.Number 50.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptoracidbomber.DDS"
            LuaKey.String "buildtime", LuaValue.Number 6000.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canland", LuaValue.Bool true
            LuaKey.String "canloopbackattack", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "cansubmerge", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collide", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "70 14 48"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "cruisealtitude", LuaValue.Number 220.0
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "explodeas", LuaValue.String "TALON_DEATH"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "hidedamage", LuaValue.Number 1.0
            LuaKey.String "maneuverleashlength", LuaValue.String "20000"
            LuaKey.String "mass", LuaValue.Number 227.5
            LuaKey.String "maxacc", LuaValue.Number 0.25
            LuaKey.String "maxaileron", LuaValue.Number 0.025
            LuaKey.String "maxbank", LuaValue.Number 0.8
            LuaKey.String "health", LuaValue.Number 835.0
            LuaKey.String "maxelevator", LuaValue.Number 0.025
            LuaKey.String "maxpitch", LuaValue.Number 0.75
            LuaKey.String "maxrudder", LuaValue.Number 0.025
            LuaKey.String "speed", LuaValue.Number 210.0
            LuaKey.String "moverate1", LuaValue.String "32"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptoracidbomber.s3o"
            LuaKey.String "radardistance", LuaValue.Number 500.0
            LuaKey.String "script", LuaValue.String "Raptors/raptorf2.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "TALON_DEATH"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 1000.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "speedtofront", LuaValue.Number 0.07
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turnradius", LuaValue.Number 64.0
            LuaKey.String "turnrate", LuaValue.Number 1600.0
            LuaKey.String "unitname", LuaValue.String "raptorebomber1"
            LuaKey.String "usesmoothmesh", LuaValue.Bool true
            LuaKey.String "wingangle", LuaValue.Number 0.06593
            LuaKey.String "wingdrag", LuaValue.Number 0.835
            LuaKey.String "workertime", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
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
                    LuaKey.String "acidbomb", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 10000.0
                            LuaKey.String "areaofeffect", LuaValue.Number 75.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "burst", LuaValue.Number 8.0
                            LuaKey.String "burstrate", LuaValue.Number 0.1
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.3
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:acid-explosion-xl"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "Raptors/raptoregg_l_green.s3o"
                            LuaKey.String "mygravity", LuaValue.Number 0.5
                            LuaKey.String "name", LuaValue.String "GooBombs"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "paralyzetime", LuaValue.Number 20.0
                            LuaKey.String "range", LuaValue.Number 1500.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.5
                            LuaKey.String "soundhit", LuaValue.String "bloodsplash3"
                            LuaKey.String "soundstart", LuaValue.String "alien_bombrel"
                            LuaKey.String "sprayangle", LuaValue.Number 20000.0
                            LuaKey.String "weapontype", LuaValue.String "AircraftBomb"
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "area_onhit_ceg", LuaValue.String "acid-area-150-repeat"
                                    LuaKey.String "area_onhit_damageCeg", LuaValue.String "acid-damage-gen"
                                    LuaKey.String "area_onhit_time", LuaValue.Number 10.0
                                    LuaKey.String "area_onhit_damage", LuaValue.Number 100.0
                                    LuaKey.String "area_onhit_range", LuaValue.Number 150.0
                                    LuaKey.String "area_onhit_resistance", LuaValue.String "_RAPTORACID_"
                                    LuaKey.String "nofire", LuaValue.Bool true
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "acidbomb"
                        ]
                ]
        ]

    let raptor_allterrain_arty_acid_t2_v1 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.115
            LuaKey.String "maxdec", LuaValue.Number 0.414
            LuaKey.String "energycost", LuaValue.Number 12320.0
            LuaKey.String "metalcost", LuaValue.Number 396.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptoracidarty.DDS"
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
            LuaKey.String "explodeas", LuaValue.String "LOBBER_MORPH"
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
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor_artillery_acid_v2.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptor_artillery_v2.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "LOBBER_MORPH"
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
            LuaKey.String "unitname", LuaValue.String "raptorearty1"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "workertime", LuaValue.Number 0.0
            LuaKey.String "waterline", LuaValue.Number 10.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "KDR_11k, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_s_normals.png"
                    LuaKey.String "area_ondeath_ceg", LuaValue.String "acid-area-150-repeat"
                    LuaKey.String "area_ondeath_damageCeg", LuaValue.String "acid-damage-gen"
                    LuaKey.String "area_ondeath_time", LuaValue.Number 10.0
                    LuaKey.String "area_ondeath_damage", LuaValue.Number 100.0
                    LuaKey.String "area_ondeath_range", LuaValue.Number 150.0
                    LuaKey.String "area_ondeath_resistance", LuaValue.String "_RAPTORACID_"
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
                    LuaKey.String "acidspit", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 1024.0
                            LuaKey.String "areaofeffect", LuaValue.Number 150.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "burst", LuaValue.Number 1.0
                            LuaKey.String "burstrate", LuaValue.Number 0.001
                            LuaKey.String "cegtag", LuaValue.String "blob_trail_green"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.63
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:acid-explosion-xl"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.7
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 1.0
                            LuaKey.String "name", LuaValue.String "GOOLAUNCHER"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "nogap", LuaValue.Bool false
                            LuaKey.String "size", LuaValue.Number 9.0
                            LuaKey.String "sizedecay", LuaValue.Number 0.04
                            LuaKey.String "alphaDecay", LuaValue.Number 0.18
                            LuaKey.String "stages", LuaValue.Number 8.0
                            LuaKey.String "proximitypriority", LuaValue.Number -1.0
                            LuaKey.String "range", LuaValue.Number 1500.0
                            LuaKey.String "reloadtime", LuaValue.Number 20.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.8 0.99 0.11"
                            LuaKey.String "soundhit", LuaValue.String "bloodsplash3"
                            LuaKey.String "soundstart", LuaValue.String "alien_bombrel"
                            LuaKey.String "sprayangle", LuaValue.Number 1024.0
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weapontimer", LuaValue.Number 0.2
                            LuaKey.String "weaponvelocity", LuaValue.Number 520.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "area_onhit_ceg", LuaValue.String "acid-area-150-repeat"
                                    LuaKey.String "area_onhit_damageCeg", LuaValue.String "acid-damage-gen"
                                    LuaKey.String "area_onhit_time", LuaValue.Number 10.0
                                    LuaKey.String "area_onhit_damage", LuaValue.Number 200.0
                                    LuaKey.String "area_onhit_range", LuaValue.Number 150.0
                                    LuaKey.String "area_onhit_resistance", LuaValue.String "_RAPTORACID_"
                                    LuaKey.String "nofire", LuaValue.Bool true
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1.0
                                    LuaKey.String "shields", LuaValue.Number 320.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "MOBILE"
                            LuaKey.String "def", LuaValue.String "acidspit"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 50.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                ]
        ]

    let raptor_allterrain_arty_acid_t4_v1 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.115
            LuaKey.String "maxdec", LuaValue.Number 0.414
            LuaKey.String "energycost", LuaValue.Number 12320.0
            LuaKey.String "metalcost", LuaValue.Number 396.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptoracidartyxl.DDS"
            LuaKey.String "buildtime", LuaValue.Number 6750.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 1 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "60 34 80"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "explodeas", LuaValue.String "LOBBER_MORPH"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "hidedamage", LuaValue.Number 1.0
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "maneuverleashlength", LuaValue.String "640"
            LuaKey.String "mass", LuaValue.Number 4000.0
            LuaKey.String "health", LuaValue.Number 8000.0
            LuaKey.String "maxslope", LuaValue.Number 18.0
            LuaKey.String "speed", LuaValue.Number 84.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "RAPTORALLTERRAINBIGHOVER"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor_artillery_meteor_v2_acid.s3o"
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
            LuaKey.String "trackwidth", LuaValue.Number 30.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 1840.0
            LuaKey.String "unitname", LuaValue.String "raptor_allterrain_arty_acid_t4_v1"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "workertime", LuaValue.Number 0.0
            LuaKey.String "waterline", LuaValue.Number 10.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "KDR_11k, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_s_normals.png"
                    LuaKey.String "area_ondeath_ceg", LuaValue.String "acid-area-150-repeat"
                    LuaKey.String "area_ondeath_damageCeg", LuaValue.String "acid-damage-gen"
                    LuaKey.String "area_ondeath_time", LuaValue.Number 10.0
                    LuaKey.String "area_ondeath_damage", LuaValue.Number 100.0
                    LuaKey.String "area_ondeath_range", LuaValue.Number 150.0
                    LuaKey.String "area_ondeath_resistance", LuaValue.String "_RAPTORACID_"
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
                    LuaKey.String "acidspit", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 2048.0
                            LuaKey.String "areaofeffect", LuaValue.Number 150.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "burst", LuaValue.Number 4.0
                            LuaKey.String "burstrate", LuaValue.Number 0.001
                            LuaKey.String "cegtag", LuaValue.String "blob_trail_green"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.63
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:acid-explosion-xl"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.7
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 1.0
                            LuaKey.String "name", LuaValue.String "GOOLAUNCHER"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "nogap", LuaValue.Bool false
                            LuaKey.String "size", LuaValue.Number 9.0
                            LuaKey.String "sizedecay", LuaValue.Number 0.04
                            LuaKey.String "alphaDecay", LuaValue.Number 0.18
                            LuaKey.String "stages", LuaValue.Number 8.0
                            LuaKey.String "proximitypriority", LuaValue.Number -1.0
                            LuaKey.String "range", LuaValue.Number 2000.0
                            LuaKey.String "reloadtime", LuaValue.Number 20.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.8 0.99 0.11"
                            LuaKey.String "soundhit", LuaValue.String "bloodsplash3"
                            LuaKey.String "soundstart", LuaValue.String "alien_bombrel"
                            LuaKey.String "sprayangle", LuaValue.Number 2048.0
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weapontimer", LuaValue.Number 0.2
                            LuaKey.String "weaponvelocity", LuaValue.Number 520.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "area_onhit_ceg", LuaValue.String "acid-area-150-repeat"
                                    LuaKey.String "area_onhit_damageCeg", LuaValue.String "acid-damage-gen"
                                    LuaKey.String "area_onhit_time", LuaValue.Number 10.0
                                    LuaKey.String "area_onhit_damage", LuaValue.Number 200.0
                                    LuaKey.String "area_onhit_range", LuaValue.Number 150.0
                                    LuaKey.String "area_onhit_resistance", LuaValue.String "_RAPTORACID_"
                                    LuaKey.String "nofire", LuaValue.Bool true
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1.0
                                    LuaKey.String "shields", LuaValue.Number 320.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "MOBILE"
                            LuaKey.String "def", LuaValue.String "acidspit"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 50.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                ]
        ]

    let raptor_allterrain_assault_acid_t2_v1 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.414
            LuaKey.String "airsightdistance", LuaValue.Number 650.0
            LuaKey.String "maxdec", LuaValue.Number 0.46
            LuaKey.String "energycost", LuaValue.Number 3520.0
            LuaKey.String "metalcost", LuaValue.Number 152.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptoracidallterrainassault.DDS"
            LuaKey.String "buildtime", LuaValue.Number 9000.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 2 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "27 38 60"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "explodeas", LuaValue.String "BIGBUG_DEATH_ACID"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "maneuverleashlength", LuaValue.String "640"
            LuaKey.String "mass", LuaValue.Number 1500.0
            LuaKey.String "health", LuaValue.Number 11100.0
            LuaKey.String "maxslope", LuaValue.Number 18.0
            LuaKey.String "speed", LuaValue.Number 33.75
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "RAPTORALLTERRAINBIGHOVER"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptoracidallterrainassault.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptorallterraina1.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "BIGBUG_DEATH_ACID"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 500.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "trackoffset", LuaValue.Number 7.0
            LuaKey.String "trackstrength", LuaValue.Number 3.0
            LuaKey.String "trackstretch", LuaValue.Number 1.0
            LuaKey.String "tracktype", LuaValue.String "RaptorTrack"
            LuaKey.String "trackwidth", LuaValue.Number 34.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 920.0
            LuaKey.String "unitname", LuaValue.String "raptore2"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 24.0
            LuaKey.String "workertime", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "maxrange", LuaValue.String "200"
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "KDR_11k, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_l_normals.png"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.0
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
                    LuaKey.String "acidspit", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 1024.0
                            LuaKey.String "areaofeffect", LuaValue.Number 150.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "burst", LuaValue.Number 2.0
                            LuaKey.String "burstrate", LuaValue.Number 0.5
                            LuaKey.String "cegtag", LuaValue.String "blob_trail_green"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.63
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:acid-explosion-xl"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.4
                            LuaKey.String "intensity", LuaValue.Number 0.7
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 1.0
                            LuaKey.String "name", LuaValue.String "GOOLAUNCHER"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 500.0
                            LuaKey.String "reloadtime", LuaValue.Number 3.6
                            LuaKey.String "rgbcolor", LuaValue.String "0.8 0.99 0.11"
                            LuaKey.String "nogap", LuaValue.Bool false
                            LuaKey.String "size", LuaValue.Number 8.0
                            LuaKey.String "sizedecay", LuaValue.Number 0.03
                            LuaKey.String "alphaDecay", LuaValue.Number 0.14
                            LuaKey.String "stages", LuaValue.Number 9.0
                            LuaKey.String "soundhit", LuaValue.String "bloodsplash3"
                            LuaKey.String "soundstart", LuaValue.String "alien_bombrel"
                            LuaKey.String "sprayangle", LuaValue.Number 92.0
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 0.2
                            LuaKey.String "weaponvelocity", LuaValue.Number 520.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "area_onhit_ceg", LuaValue.String "acid-area-150-repeat"
                                    LuaKey.String "area_onhit_damageCeg", LuaValue.String "acid-damage-gen"
                                    LuaKey.String "area_onhit_time", LuaValue.Number 10.0
                                    LuaKey.String "area_onhit_damage", LuaValue.Number 100.0
                                    LuaKey.String "area_onhit_range", LuaValue.Number 150.0
                                    LuaKey.String "area_onhit_resistance", LuaValue.String "_RAPTORACID_"
                                    LuaKey.String "nofire", LuaValue.Bool true
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1.0
                                    LuaKey.String "shields", LuaValue.Number 160.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "acidspit"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 125.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                ]
        ]

    let raptor_allterrain_swarmer_acid_t2_v1 =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "maxacc", LuaValue.Number 1.4375
            LuaKey.String "maxdec", LuaValue.Number 2.3
            LuaKey.String "energycost", LuaValue.Number 5280.0
            LuaKey.String "metalcost", LuaValue.Number 99.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptoracidallterrain.DDS"
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
            LuaKey.String "explodeas", LuaValue.String "BUG_DEATH_ACID"
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
            LuaKey.String "objectname", LuaValue.String "Raptors/raptoracidallterrain.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptorc3.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "BIGBUG_DEATH_ACID"
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
            LuaKey.String "workertime", LuaValue.Number 0.0
            LuaKey.String "waterline", LuaValue.Number 12.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "KDR_11k, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_s_normals.png"
                    LuaKey.String "area_ondeath_ceg", LuaValue.String "acid-area-75-repeat"
                    LuaKey.String "area_ondeath_damageCeg", LuaValue.String "acid-damage-gen"
                    LuaKey.String "area_ondeath_time", LuaValue.Number 10.0
                    LuaKey.String "area_ondeath_damage", LuaValue.Number 40.0
                    LuaKey.String "area_ondeath_range", LuaValue.Number 75.0
                    LuaKey.String "area_ondeath_resistance", LuaValue.String "_RAPTORACID_"
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
                    LuaKey.String "acidspit", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 1024.0
                            LuaKey.String "areaofeffect", LuaValue.Number 75.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "burst", LuaValue.Number 2.0
                            LuaKey.String "burstrate", LuaValue.Number 0.3
                            LuaKey.String "cegtag", LuaValue.String "blob_trail_green"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.63
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:acid-explosion-small"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.4
                            LuaKey.String "intensity", LuaValue.Number 0.7
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 1.0
                            LuaKey.String "name", LuaValue.String "GOOLAUNCHER"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 300.0
                            LuaKey.String "reloadtime", LuaValue.Number 5.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.8 0.99 0.11"
                            LuaKey.String "nogap", LuaValue.Bool false
                            LuaKey.String "size", LuaValue.Number 7.0
                            LuaKey.String "sizedecay", LuaValue.Number 0.05
                            LuaKey.String "alphaDecay", LuaValue.Number 0.15
                            LuaKey.String "stages", LuaValue.Number 7.0
                            LuaKey.String "soundhit", LuaValue.String "bloodsplash3"
                            LuaKey.String "soundstart", LuaValue.String "alien_bombrel"
                            LuaKey.String "sprayangle", LuaValue.Number 128.0
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 0.2
                            LuaKey.String "weaponvelocity", LuaValue.Number 520.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "area_onhit_ceg", LuaValue.String "acid-area-75-repeat"
                                    LuaKey.String "area_onhit_damageCeg", LuaValue.String "acid-damage-gen"
                                    LuaKey.String "area_onhit_time", LuaValue.Number 10.0
                                    LuaKey.String "area_onhit_damage", LuaValue.Number 40.0
                                    LuaKey.String "area_onhit_range", LuaValue.Number 75.0
                                    LuaKey.String "area_onhit_resistance", LuaValue.String "_RAPTORACID_"
                                    LuaKey.String "nofire", LuaValue.Bool true
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1.0
                                    LuaKey.String "shields", LuaValue.Number 80.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "acidspit"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 110.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                ]
        ]

    let raptor_land_assault_acid_t2_v1 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.414
            LuaKey.String "airsightdistance", LuaValue.Number 650.0
            LuaKey.String "maxdec", LuaValue.Number 0.46
            LuaKey.String "energycost", LuaValue.Number 3520.0
            LuaKey.String "metalcost", LuaValue.Number 152.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptoracidassault.DDS"
            LuaKey.String "buildtime", LuaValue.Number 9000.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -5 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "27 48 60"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "explodeas", LuaValue.String "BIGBUG_DEATH_ACID"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "maneuverleashlength", LuaValue.String "640"
            LuaKey.String "mass", LuaValue.Number 1500.0
            LuaKey.String "health", LuaValue.Number 11100.0
            LuaKey.String "maxslope", LuaValue.Number 18.0
            LuaKey.String "speed", LuaValue.Number 33.75
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "RAPTORBIGHOVER"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptoracidassault.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptora1.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "BIGBUG_DEATH_ACID"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 500.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "trackoffset", LuaValue.Number 7.0
            LuaKey.String "trackstrength", LuaValue.Number 3.0
            LuaKey.String "trackstretch", LuaValue.Number 1.0
            LuaKey.String "tracktype", LuaValue.String "RaptorTrack"
            LuaKey.String "trackwidth", LuaValue.Number 34.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 920.0
            LuaKey.String "unitname", LuaValue.String "raptore2"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 20.0
            LuaKey.String "workertime", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "maxrange", LuaValue.String "200"
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "KDR_11k, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_l_normals.png"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.0
                    LuaKey.String "area_ondeath_ceg", LuaValue.String "acid-area-150-repeat"
                    LuaKey.String "area_ondeath_damageCeg", LuaValue.String "acid-damage-gen"
                    LuaKey.String "area_ondeath_time", LuaValue.Number 10.0
                    LuaKey.String "area_ondeath_damage", LuaValue.Number 100.0
                    LuaKey.String "area_ondeath_range", LuaValue.Number 150.0
                    LuaKey.String "area_ondeath_resistance", LuaValue.String "_RAPTORACID_"
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
                    LuaKey.String "acidspit", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 1024.0
                            LuaKey.String "areaofeffect", LuaValue.Number 150.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "burst", LuaValue.Number 2.0
                            LuaKey.String "burstrate", LuaValue.Number 0.5
                            LuaKey.String "cegtag", LuaValue.String "blob_trail_green"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.63
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:acid-explosion-xl"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.4
                            LuaKey.String "intensity", LuaValue.Number 0.7
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 1.0
                            LuaKey.String "name", LuaValue.String "GOOLAUNCHER"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 500.0
                            LuaKey.String "reloadtime", LuaValue.Number 3.6
                            LuaKey.String "rgbcolor", LuaValue.String "0.8 0.99 0.11"
                            LuaKey.String "nogap", LuaValue.Bool false
                            LuaKey.String "size", LuaValue.Number 8.0
                            LuaKey.String "sizedecay", LuaValue.Number 0.03
                            LuaKey.String "alphaDecay", LuaValue.Number 0.14
                            LuaKey.String "stages", LuaValue.Number 9.0
                            LuaKey.String "soundhit", LuaValue.String "bloodsplash3"
                            LuaKey.String "soundstart", LuaValue.String "alien_bombrel"
                            LuaKey.String "sprayangle", LuaValue.Number 92.0
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 0.2
                            LuaKey.String "weaponvelocity", LuaValue.Number 520.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "area_onhit_ceg", LuaValue.String "acid-area-150-repeat"
                                    LuaKey.String "area_onhit_damageCeg", LuaValue.String "acid-damage-gen"
                                    LuaKey.String "area_onhit_time", LuaValue.Number 10.0
                                    LuaKey.String "area_onhit_damage", LuaValue.Number 100.0
                                    LuaKey.String "area_onhit_range", LuaValue.Number 150.0
                                    LuaKey.String "area_onhit_resistance", LuaValue.String "_RAPTORACID_"
                                    LuaKey.String "nofire", LuaValue.Bool true
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1.0
                                    LuaKey.String "shields", LuaValue.Number 160.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "acidspit"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 125.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                ]
        ]

    let raptor_land_swarmer_acids_t2_v1 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.1725
            LuaKey.String "maxdec", LuaValue.Number 0.345
            LuaKey.String "energycost", LuaValue.Number 53.0
            LuaKey.String "metalcost", LuaValue.Number 25.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptoracidswarmer.DDS"
            LuaKey.String "buildtime", LuaValue.Number 900.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -3 -3"
            LuaKey.String "collisionvolumescales", LuaValue.String "18 40 40"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "explodeas", LuaValue.String "BUG_DEATH_ACID"
            LuaKey.String "floater", LuaValue.Bool false
            LuaKey.String "footprintx", LuaValue.Number 1.5
            LuaKey.String "footprintz", LuaValue.Number 1.5
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "maneuverleashlength", LuaValue.Number 640.0
            LuaKey.String "mass", LuaValue.Number 30.0
            LuaKey.String "health", LuaValue.Number 1110.0
            LuaKey.String "maxslope", LuaValue.Number 18.0
            LuaKey.String "speed", LuaValue.Number 81.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "RAPTORSMALLHOVER"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptoracidswarmer.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptor1.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "BUG_DEATH_ACID"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 300.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "trackoffset", LuaValue.Number 0.0
            LuaKey.String "trackstrength", LuaValue.Number 3.0
            LuaKey.String "trackstretch", LuaValue.Number 1.0
            LuaKey.String "tracktype", LuaValue.String "RaptorTrack"
            LuaKey.String "trackwidth", LuaValue.Number 18.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 1840.0
            LuaKey.String "unitname", LuaValue.String "raptore1"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 16.0
            LuaKey.String "workertime", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "KDR_11k, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_s_normals.png"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.0
                    LuaKey.String "area_ondeath_ceg", LuaValue.String "acid-area-75-repeat"
                    LuaKey.String "area_ondeath_damageCeg", LuaValue.String "acid-damage-gen"
                    LuaKey.String "area_ondeath_time", LuaValue.Number 10.0
                    LuaKey.String "area_ondeath_damage", LuaValue.Number 40.0
                    LuaKey.String "area_ondeath_range", LuaValue.Number 75.0
                    LuaKey.String "area_ondeath_resistance", LuaValue.String "_RAPTORACID_"
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
                    LuaKey.String "acidspit", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 1024.0
                            LuaKey.String "areaofeffect", LuaValue.Number 75.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "burst", LuaValue.Number 2.0
                            LuaKey.String "burstrate", LuaValue.Number 0.3
                            LuaKey.String "cegtag", LuaValue.String "blob_trail_green"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.63
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:acid-explosion-small"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.4
                            LuaKey.String "intensity", LuaValue.Number 0.7
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 1.0
                            LuaKey.String "name", LuaValue.String "GOOLAUNCHER"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 300.0
                            LuaKey.String "reloadtime", LuaValue.Number 5.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.8 0.99 0.11"
                            LuaKey.String "nogap", LuaValue.Bool false
                            LuaKey.String "size", LuaValue.Number 7.0
                            LuaKey.String "sizedecay", LuaValue.Number 0.05
                            LuaKey.String "alphaDecay", LuaValue.Number 0.15
                            LuaKey.String "stages", LuaValue.Number 7.0
                            LuaKey.String "soundhit", LuaValue.String "bloodsplash3"
                            LuaKey.String "soundstart", LuaValue.String "alien_bombrel"
                            LuaKey.String "sprayangle", LuaValue.Number 128.0
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 0.2
                            LuaKey.String "weaponvelocity", LuaValue.Number 520.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "area_onhit_ceg", LuaValue.String "acid-area-75-repeat"
                                    LuaKey.String "area_onhit_damageCeg", LuaValue.String "acid-damage-gen"
                                    LuaKey.String "area_onhit_time", LuaValue.Number 10.0
                                    LuaKey.String "area_onhit_damage", LuaValue.Number 40.0
                                    LuaKey.String "area_onhit_range", LuaValue.Number 75.0
                                    LuaKey.String "area_onhit_resistance", LuaValue.String "_RAPTORACID_"
                                    LuaKey.String "nofire", LuaValue.Bool true
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1.0
                                    LuaKey.String "shields", LuaValue.Number 80.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "acidspit"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 180.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                ]
        ]

    let all : (string * LuaValue) list =
        [
            "raptor_air_bomber_acid_t2_v1", raptor_air_bomber_acid_t2_v1
            "raptor_allterrain_arty_acid_t2_v1", raptor_allterrain_arty_acid_t2_v1
            "raptor_allterrain_arty_acid_t4_v1", raptor_allterrain_arty_acid_t4_v1
            "raptor_allterrain_assault_acid_t2_v1", raptor_allterrain_assault_acid_t2_v1
            "raptor_allterrain_swarmer_acid_t2_v1", raptor_allterrain_swarmer_acid_t2_v1
            "raptor_land_assault_acid_t2_v1", raptor_land_assault_acid_t2_v1
            "raptor_land_swarmer_acids_t2_v1", raptor_land_swarmer_acids_t2_v1
        ]
