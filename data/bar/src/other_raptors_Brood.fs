// Auto-generated BAR unit data: other/raptors/Brood
namespace BarData.Units

open BarData

module other_raptors_Brood =

    let raptor_air_bomber_brood_t4_v2 =
        LuaValue.Table [
            LuaKey.String "acceleration", LuaValue.Number 0.8
            LuaKey.String "airhoverfactor", LuaValue.Number 0.0
            LuaKey.String "attackrunlength", LuaValue.Number 32.0
            LuaKey.String "maxdec", LuaValue.Number 0.1
            LuaKey.String "energycost", LuaValue.Number 4550.0
            LuaKey.String "metalcost", LuaValue.Number 212.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptorbroodbomber.DDS"
            LuaKey.String "buildtime", LuaValue.Number 9375.0
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
            LuaKey.String "collisionvolumescales", LuaValue.String "70 70 70"
            LuaKey.String "collisionvolumetype", LuaValue.String "sphere"
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
            LuaKey.String "health", LuaValue.Number 1500.0
            LuaKey.String "maxelevator", LuaValue.Number 0.025
            LuaKey.String "maxpitch", LuaValue.Number 0.75
            LuaKey.String "maxrudder", LuaValue.Number 0.025
            LuaKey.String "speed", LuaValue.Number 240.0
            LuaKey.String "moverate1", LuaValue.String "32"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptorbroodbomber.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptorf1.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "TALON_DEATH"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 1000.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "speedtofront", LuaValue.Number 0.07
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turnradius", LuaValue.Number 64.0
            LuaKey.String "turnrate", LuaValue.Number 1600.0
            LuaKey.String "unitname", LuaValue.String "raptorbroodbomber"
            LuaKey.String "usesmoothmesh", LuaValue.Bool true
            LuaKey.String "wingangle", LuaValue.Number 0.06593
            LuaKey.String "wingdrag", LuaValue.Number 0.835
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
                    LuaKey.String "bloodyeggs", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 500000.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "areaofeffect", LuaValue.Number 128.0
                            LuaKey.String "burst", LuaValue.Number 1.0
                            LuaKey.String "burstrate", LuaValue.Number 0.033
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.45
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:dirt"
                            LuaKey.String "impulsefactor", LuaValue.Number 1.0
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "Raptors/s_raptorboss_white.s3o"
                            LuaKey.String "mygravity", LuaValue.Number 0.5
                            LuaKey.String "name", LuaValue.String "GooBombs"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1500.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.1
                            LuaKey.String "soundhit", LuaValue.String "smallraptorattack"
                            LuaKey.String "soundstart", LuaValue.String "alien_bombrel"
                            LuaKey.String "sprayangle", LuaValue.Number 1000000.0
                            LuaKey.String "weapontype", LuaValue.String "AircraftBomb"
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "spawns_name", LuaValue.String "raptor_land_swarmer_brood_t4_v1"
                                    LuaKey.String "spawns_surface", LuaValue.String "LAND SEA"
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "bloodyeggs"
                        ]
                ]
        ]

    let raptor_air_bomber_brood_t4_v3 =
        LuaValue.Table [
            LuaKey.String "acceleration", LuaValue.Number 0.8
            LuaKey.String "airhoverfactor", LuaValue.Number 0.0
            LuaKey.String "attackrunlength", LuaValue.Number 32.0
            LuaKey.String "maxdec", LuaValue.Number 0.1
            LuaKey.String "energycost", LuaValue.Number 4550.0
            LuaKey.String "metalcost", LuaValue.Number 212.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptorbroodbomber.DDS"
            LuaKey.String "buildtime", LuaValue.Number 9375.0
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
            LuaKey.String "collisionvolumescales", LuaValue.String "70 70 70"
            LuaKey.String "collisionvolumetype", LuaValue.String "sphere"
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
            LuaKey.String "health", LuaValue.Number 1500.0
            LuaKey.String "maxelevator", LuaValue.Number 0.025
            LuaKey.String "maxpitch", LuaValue.Number 0.75
            LuaKey.String "maxrudder", LuaValue.Number 0.025
            LuaKey.String "speed", LuaValue.Number 240.0
            LuaKey.String "moverate1", LuaValue.String "32"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptorbroodbomber.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptorf1.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "TALON_DEATH"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 1000.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "speedtofront", LuaValue.Number 0.07
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turnradius", LuaValue.Number 64.0
            LuaKey.String "turnrate", LuaValue.Number 1600.0
            LuaKey.String "unitname", LuaValue.String "raptorbroodbomber"
            LuaKey.String "usesmoothmesh", LuaValue.Bool true
            LuaKey.String "wingangle", LuaValue.Number 0.06593
            LuaKey.String "wingdrag", LuaValue.Number 0.835
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
                    LuaKey.String "bloodyeggs", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 500000.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "areaofeffect", LuaValue.Number 128.0
                            LuaKey.String "burst", LuaValue.Number 2.0
                            LuaKey.String "burstrate", LuaValue.Number 0.5
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.45
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:dirt"
                            LuaKey.String "impulsefactor", LuaValue.Number 1.0
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "Raptors/s_raptorboss2_white.s3o"
                            LuaKey.String "mygravity", LuaValue.Number 0.5
                            LuaKey.String "name", LuaValue.String "GooBombs"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1500.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.1
                            LuaKey.String "soundhit", LuaValue.String "smallraptorattack"
                            LuaKey.String "soundstart", LuaValue.String "alien_bombrel"
                            LuaKey.String "sprayangle", LuaValue.Number 1000000.0
                            LuaKey.String "weapontype", LuaValue.String "AircraftBomb"
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "spawns_name", LuaValue.String "raptor_land_swarmer_brood_t3_v1"
                                    LuaKey.String "spawns_surface", LuaValue.String "LAND SEA"
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "bloodyeggs"
                        ]
                ]
        ]

    let raptor_air_bomber_brood_t4_v4 =
        LuaValue.Table [
            LuaKey.String "acceleration", LuaValue.Number 0.8
            LuaKey.String "airhoverfactor", LuaValue.Number 0.0
            LuaKey.String "attackrunlength", LuaValue.Number 32.0
            LuaKey.String "maxdec", LuaValue.Number 0.1
            LuaKey.String "energycost", LuaValue.Number 4550.0
            LuaKey.String "metalcost", LuaValue.Number 212.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptorbroodbomber.DDS"
            LuaKey.String "buildtime", LuaValue.Number 9375.0
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
            LuaKey.String "collisionvolumescales", LuaValue.String "70 70 70"
            LuaKey.String "collisionvolumetype", LuaValue.String "sphere"
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
            LuaKey.String "health", LuaValue.Number 1500.0
            LuaKey.String "maxelevator", LuaValue.Number 0.025
            LuaKey.String "maxpitch", LuaValue.Number 0.75
            LuaKey.String "maxrudder", LuaValue.Number 0.025
            LuaKey.String "speed", LuaValue.Number 240.0
            LuaKey.String "moverate1", LuaValue.String "32"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptorbroodbomber.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptorf1.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "TALON_DEATH"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 1000.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "speedtofront", LuaValue.Number 0.07
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turnradius", LuaValue.Number 64.0
            LuaKey.String "turnrate", LuaValue.Number 1600.0
            LuaKey.String "unitname", LuaValue.String "raptorbroodbomber"
            LuaKey.String "usesmoothmesh", LuaValue.Bool true
            LuaKey.String "wingangle", LuaValue.Number 0.06593
            LuaKey.String "wingdrag", LuaValue.Number 0.835
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
                    LuaKey.String "bloodyeggs", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 500000.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "areaofeffect", LuaValue.Number 128.0
                            LuaKey.String "burst", LuaValue.Number 8.0
                            LuaKey.String "burstrate", LuaValue.Number 0.033
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.45
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:dirt"
                            LuaKey.String "impulsefactor", LuaValue.Number 1.0
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "Raptors/s_raptor_white.s3o"
                            LuaKey.String "mygravity", LuaValue.Number 0.5
                            LuaKey.String "name", LuaValue.String "GooBombs"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1500.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.1
                            LuaKey.String "soundhit", LuaValue.String "smallraptorattack"
                            LuaKey.String "soundstart", LuaValue.String "alien_bombrel"
                            LuaKey.String "sprayangle", LuaValue.Number 1000000.0
                            LuaKey.String "weapontype", LuaValue.String "AircraftBomb"
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "spawns_name", LuaValue.String "raptor_land_swarmer_brood_t2_v1"
                                    LuaKey.String "spawns_surface", LuaValue.String "LAND SEA"
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "bloodyeggs"
                        ]
                ]
        ]

    let raptor_allterrain_arty_brood_t2_v1 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.115
            LuaKey.String "maxdec", LuaValue.Number 0.414
            LuaKey.String "energycost", LuaValue.Number 12320.0
            LuaKey.String "metalcost", LuaValue.Number 396.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptorbroodarty.DDS"
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
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor_artillery_brood_small.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptor_artillery_v2.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "BIGBUG_DEATH"
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
            LuaKey.String "unitname", LuaValue.String "raptor_allterrain_arty_brood_t2_v1"
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
                    LuaKey.String "bloodyeggs", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 512.0
                            LuaKey.String "areaofeffect", LuaValue.Number 128.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "burst", LuaValue.Number 1.0
                            LuaKey.String "burstrate", LuaValue.Number 0.01
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "arty-heavy-purple"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 128.0
                            LuaKey.String "craterboost", LuaValue.Number 0.2
                            LuaKey.String "cratermult", LuaValue.Number 0.2
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.63
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:dirt"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.4
                            LuaKey.String "intensity", LuaValue.Number 0.7
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "Raptors/s_raptor_white.s3o"
                            LuaKey.String "name", LuaValue.String "GOOLAUNCHER"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number -1.0
                            LuaKey.String "range", LuaValue.Number 1500.0
                            LuaKey.String "reloadtime", LuaValue.Number 10.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.5 0 1"
                            LuaKey.String "size", LuaValue.Number 5.5
                            LuaKey.String "sizedecay", LuaValue.Number 0.09
                            LuaKey.String "soundhit", LuaValue.String "smallraptorattack"
                            LuaKey.String "soundstart", LuaValue.String "bugarty"
                            LuaKey.String "sprayangle", LuaValue.Number 512.0
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 0.2
                            LuaKey.String "weaponvelocity", LuaValue.Number 520.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1.0
                                    LuaKey.String "shields", LuaValue.Number 200.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "spawns_name", LuaValue.String "raptor_land_swarmer_brood_t2_v1"
                                    LuaKey.String "spawns_surface", LuaValue.String "LAND SEA"
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "MOBILE"
                            LuaKey.String "def", LuaValue.String "bloodyeggs"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 50.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                ]
        ]

    let raptor_allterrain_arty_brood_t4_v1 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 1.15
            LuaKey.String "maxdec", LuaValue.Number 9.2
            LuaKey.String "energycost", LuaValue.Number 12320.0
            LuaKey.String "metalcost", LuaValue.Number 396.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptorbroodarty.DDS"
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
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor_artillery_brood_big.s3o"
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
            LuaKey.String "unitname", LuaValue.String "raptor_allterrain_arty_brood_t4_v1"
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
                    LuaKey.String "bloodyeggs", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 1024.0
                            LuaKey.String "areaofeffect", LuaValue.Number 128.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "burst", LuaValue.Number 4.0
                            LuaKey.String "burstrate", LuaValue.Number 0.001
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "arty-heavy-purple"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 128.0
                            LuaKey.String "craterboost", LuaValue.Number 0.2
                            LuaKey.String "cratermult", LuaValue.Number 0.2
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.63
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:dirt"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.4
                            LuaKey.String "intensity", LuaValue.Number 0.7
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "Raptors/s_raptor_white.s3o"
                            LuaKey.String "name", LuaValue.String "GOOLAUNCHER"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number -1.0
                            LuaKey.String "range", LuaValue.Number 2000.0
                            LuaKey.String "reloadtime", LuaValue.Number 10.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.5 0 1"
                            LuaKey.String "size", LuaValue.Number 5.5
                            LuaKey.String "sizedecay", LuaValue.Number 0.09
                            LuaKey.String "soundhit", LuaValue.String "smallraptorattack"
                            LuaKey.String "soundstart", LuaValue.String "bugarty"
                            LuaKey.String "sprayangle", LuaValue.Number 1024.0
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 0.2
                            LuaKey.String "weaponvelocity", LuaValue.Number 520.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1.0
                                    LuaKey.String "shields", LuaValue.Number 200.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "spawns_name", LuaValue.String "raptor_land_swarmer_brood_t2_v1"
                                    LuaKey.String "spawns_surface", LuaValue.String "LAND SEA"
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "MOBILE"
                            LuaKey.String "def", LuaValue.String "bloodyeggs"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 50.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                ]
        ]

    let raptor_land_swarmer_brood_t2_v1 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.644
            LuaKey.String "maxdec", LuaValue.Number 0.23
            LuaKey.String "energycost", LuaValue.Number 250.0
            LuaKey.String "metalcost", LuaValue.Number 20.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptorh4.DDS"
            LuaKey.String "buildtime", LuaValue.Number 2250.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collide", LuaValue.Number 0.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "13 20 22"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "explodeas", LuaValue.String "BUG_DEATH"
            LuaKey.String "floater", LuaValue.Bool false
            LuaKey.String "footprintx", LuaValue.Number 1.0
            LuaKey.String "footprintz", LuaValue.Number 1.0
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "maneuverleashlength", LuaValue.Number 640.0
            LuaKey.String "mass", LuaValue.Number 100.0
            LuaKey.String "health", LuaValue.Number 540.0
            LuaKey.String "maxslope", LuaValue.Number 18.0
            LuaKey.String "speed", LuaValue.Number 245.999
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "RAPTORSMALLHOVER"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/s_raptor_white.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptorh4.cob"
            LuaKey.String "selfdestructas", LuaValue.String "BUG_DEATH"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 200.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "trackoffset", LuaValue.Number 0.0
            LuaKey.String "trackstrength", LuaValue.Number 3.0
            LuaKey.String "trackstretch", LuaValue.Number 1.0
            LuaKey.String "tracktype", LuaValue.String "RaptorTrack"
            LuaKey.String "trackwidth", LuaValue.Number 18.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 1840.0
            LuaKey.String "unitname", LuaValue.String "raptor_land_swarmer_brood_t2_v1"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 15.0
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
                            LuaKey.String "reloadtime", LuaValue.Number 1.0
                            LuaKey.String "soundstart", LuaValue.String "smallraptorattack"
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 0.1
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 100.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "WEAPON"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 180.0
                        ]
                ]
        ]

    let raptor_land_swarmer_brood_t3_v1 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.414
            LuaKey.String "maxdec", LuaValue.Number 0.23
            LuaKey.String "energycost", LuaValue.Number 2326.0
            LuaKey.String "metalcost", LuaValue.Number 123.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptorh3.DDS"
            LuaKey.String "buildtime", LuaValue.Number 4500.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 2 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "30 38 60"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "explodeas", LuaValue.String "BUG_DEATH"
            LuaKey.String "floater", LuaValue.Bool false
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Number 1.0
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "maneuverleashlength", LuaValue.Number 640.0
            LuaKey.String "mass", LuaValue.Number 700.0
            LuaKey.String "health", LuaValue.Number 2000.0
            LuaKey.String "maxslope", LuaValue.Number 18.0
            LuaKey.String "speed", LuaValue.Number 135.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "RAPTORSMALLHOVER"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/s_raptorboss2_white.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptorh3.cob"
            LuaKey.String "selfdestructas", LuaValue.String "BUG_DEATH"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 300.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "trackoffset", LuaValue.Number 4.0
            LuaKey.String "trackstrength", LuaValue.Number 3.0
            LuaKey.String "trackstretch", LuaValue.Number 1.0
            LuaKey.String "tracktype", LuaValue.String "RaptorTrack"
            LuaKey.String "trackwidth", LuaValue.Number 22.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 1840.0
            LuaKey.String "unitname", LuaValue.String "raptor_land_swarmer_brood_t3_v1"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 29.0
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
                            LuaKey.String "range", LuaValue.Number 300.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.0
                            LuaKey.String "soundstart", LuaValue.String "smallraptorattack"
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 0.1
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 200.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "WEAPON"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 180.0
                        ]
                ]
        ]

    let raptor_land_swarmer_brood_t4_v1 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.644
            LuaKey.String "maxdec", LuaValue.Number 0.23
            LuaKey.String "energycost", LuaValue.Number 5201.0
            LuaKey.String "metalcost", LuaValue.Number 251.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptorh2.DDS"
            LuaKey.String "buildtime", LuaValue.Number 9000.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 2"
            LuaKey.String "collisionvolumescales", LuaValue.String "37 70 90"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "explodeas", LuaValue.String "BIGBUG_DEATH"
            LuaKey.String "floater", LuaValue.Bool false
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Number 1.0
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "maneuverleashlength", LuaValue.Number 640.0
            LuaKey.String "mass", LuaValue.Number 1500.0
            LuaKey.String "health", LuaValue.Number 6700.0
            LuaKey.String "maxslope", LuaValue.Number 18.0
            LuaKey.String "speed", LuaValue.Number 90.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "RAPTORSMALLHOVER"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/s_raptorboss_white.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptorh2.cob"
            LuaKey.String "selfdestructas", LuaValue.String "BUG_DEATH"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 400.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "trackoffset", LuaValue.Number 7.0
            LuaKey.String "trackstrength", LuaValue.Number 3.0
            LuaKey.String "trackstretch", LuaValue.Number 1.0
            LuaKey.String "tracktype", LuaValue.String "RaptorTrack"
            LuaKey.String "trackwidth", LuaValue.Number 30.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 920.0
            LuaKey.String "unitname", LuaValue.String "raptor_land_swarmer_brood_t4_v1"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 42.0
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
                    LuaKey.String "weapon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 24.0
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
                            LuaKey.String "reloadtime", LuaValue.Number 1.0
                            LuaKey.String "soundstart", LuaValue.String "smallraptorattack"
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 0.1
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 400.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "WEAPON"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 180.0
                        ]
                ]
        ]

    let all : (string * LuaValue) list =
        [
            "raptor_air_bomber_brood_t4_v2", raptor_air_bomber_brood_t4_v2
            "raptor_air_bomber_brood_t4_v3", raptor_air_bomber_brood_t4_v3
            "raptor_air_bomber_brood_t4_v4", raptor_air_bomber_brood_t4_v4
            "raptor_allterrain_arty_brood_t2_v1", raptor_allterrain_arty_brood_t2_v1
            "raptor_allterrain_arty_brood_t4_v1", raptor_allterrain_arty_brood_t4_v1
            "raptor_land_swarmer_brood_t2_v1", raptor_land_swarmer_brood_t2_v1
            "raptor_land_swarmer_brood_t3_v1", raptor_land_swarmer_brood_t3_v1
            "raptor_land_swarmer_brood_t4_v1", raptor_land_swarmer_brood_t4_v1
        ]
