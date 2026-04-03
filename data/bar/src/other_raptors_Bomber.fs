// Auto-generated BAR unit data: other/raptors/Bomber
namespace BarData.Units

open BarData

module other_raptors_Bomber =

    let raptor_air_bomber_basic_t1_v1 =
        LuaValue.Table [
            LuaKey.String "acceleration", LuaValue.Number 0.8
            LuaKey.String "airhoverfactor", LuaValue.Number 0.0
            LuaKey.String "attackrunlength", LuaValue.Number 32.0
            LuaKey.String "maxdec", LuaValue.Number 0.1
            LuaKey.String "energycost", LuaValue.Number 4550.0
            LuaKey.String "metalcost", LuaValue.Number 212.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptorf1_mini.DDS"
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
            LuaKey.String "collisionvolumescales", LuaValue.String "35 35 35"
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
            LuaKey.String "health", LuaValue.Number 85.0
            LuaKey.String "maxelevator", LuaValue.Number 0.025
            LuaKey.String "maxpitch", LuaValue.Number 0.75
            LuaKey.String "maxrudder", LuaValue.Number 0.025
            LuaKey.String "speed", LuaValue.Number 240.0
            LuaKey.String "moverate1", LuaValue.String "32"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptorf1_mini.s3o"
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
            LuaKey.String "unitname", LuaValue.String "raptor_air_bomber_basic_t1_v1"
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
                            LuaKey.String "accuracy", LuaValue.Number 10000.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "areaofeffect", LuaValue.Number 128.0
                            LuaKey.String "burst", LuaValue.Number 1.0
                            LuaKey.String "burstrate", LuaValue.Number 0.1
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.45
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:blood_explode_xl"
                            LuaKey.String "impulsefactor", LuaValue.Number 1.0
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "Raptors/raptoregg_s_darkgreen.s3o"
                            LuaKey.String "mygravity", LuaValue.Number 0.5
                            LuaKey.String "name", LuaValue.String "GooBombs"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1500.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.1
                            LuaKey.String "soundhit", LuaValue.String "bloodsplash3"
                            LuaKey.String "soundstart", LuaValue.String "alien_bombrel"
                            LuaKey.String "sprayangle", LuaValue.Number 20000.0
                            LuaKey.String "weapontype", LuaValue.String "AircraftBomb"
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 720.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "bloodyeggs"
                        ]
                ]
        ]

    let raptor_air_bomber_basic_t2_v1 =
        LuaValue.Table [
            LuaKey.String "acceleration", LuaValue.Number 0.8
            LuaKey.String "airhoverfactor", LuaValue.Number 0.0
            LuaKey.String "attackrunlength", LuaValue.Number 32.0
            LuaKey.String "maxdec", LuaValue.Number 0.1
            LuaKey.String "energycost", LuaValue.Number 4550.0
            LuaKey.String "metalcost", LuaValue.Number 212.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptorf1.DDS"
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
            LuaKey.String "health", LuaValue.Number 350.0
            LuaKey.String "maxelevator", LuaValue.Number 0.025
            LuaKey.String "maxpitch", LuaValue.Number 0.75
            LuaKey.String "maxrudder", LuaValue.Number 0.025
            LuaKey.String "speed", LuaValue.Number 240.0
            LuaKey.String "moverate1", LuaValue.String "32"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptorf1.s3o"
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
            LuaKey.String "unitname", LuaValue.String "raptor_air_bomber_basic_t2_v1"
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
                            LuaKey.String "accuracy", LuaValue.Number 10000.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "areaofeffect", LuaValue.Number 128.0
                            LuaKey.String "burst", LuaValue.Number 4.0
                            LuaKey.String "burstrate", LuaValue.Number 0.1
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.45
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:blood_explode_xl"
                            LuaKey.String "impulsefactor", LuaValue.Number 1.0
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "Raptors/raptoregg_m_darkgreen.s3o"
                            LuaKey.String "mygravity", LuaValue.Number 0.5
                            LuaKey.String "name", LuaValue.String "GooBombs"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1500.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.1
                            LuaKey.String "soundhit", LuaValue.String "bloodsplash3"
                            LuaKey.String "soundstart", LuaValue.String "alien_bombrel"
                            LuaKey.String "sprayangle", LuaValue.Number 20000.0
                            LuaKey.String "weapontype", LuaValue.String "AircraftBomb"
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1440.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "bloodyeggs"
                        ]
                ]
        ]

    let raptor_air_bomber_basic_t2_v2 =
        LuaValue.Table [
            LuaKey.String "acceleration", LuaValue.Number 0.8
            LuaKey.String "airhoverfactor", LuaValue.Number 0.0
            LuaKey.String "attackrunlength", LuaValue.Number 32.0
            LuaKey.String "maxdec", LuaValue.Number 0.1
            LuaKey.String "energycost", LuaValue.Number 4550.0
            LuaKey.String "metalcost", LuaValue.Number 212.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptorf1b.DDS"
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
            LuaKey.String "collisionvolumescales", LuaValue.String "65 65 65"
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
            LuaKey.String "health", LuaValue.Number 450.0
            LuaKey.String "maxelevator", LuaValue.Number 0.025
            LuaKey.String "maxpitch", LuaValue.Number 0.75
            LuaKey.String "maxrudder", LuaValue.Number 0.025
            LuaKey.String "speed", LuaValue.Number 180.0
            LuaKey.String "moverate1", LuaValue.String "32"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptorf1b.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptorf1b.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "TALON_DEATH"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 1000.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "speedtofront", LuaValue.Number 0.07
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turnradius", LuaValue.Number 64.0
            LuaKey.String "turnrate", LuaValue.Number 1600.0
            LuaKey.String "unitname", LuaValue.String "raptor_air_bomber_basic_t2_v2"
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
                            LuaKey.String "accuracy", LuaValue.Number 10000.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "areaofeffect", LuaValue.Number 150.0
                            LuaKey.String "burst", LuaValue.Number 3.0
                            LuaKey.String "burstrate", LuaValue.Number 0.2
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.4
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:blood_explode_xl"
                            LuaKey.String "impulsefactor", LuaValue.Number 1.0
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "Raptors/raptoregg_m_darkgreen.s3o"
                            LuaKey.String "mygravity", LuaValue.Number 0.5
                            LuaKey.String "name", LuaValue.String "GooBombs"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1500.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.1
                            LuaKey.String "soundhit", LuaValue.String "bloodsplash3"
                            LuaKey.String "soundstart", LuaValue.String "alien_bombrel"
                            LuaKey.String "sprayangle", LuaValue.Number 20000.0
                            LuaKey.String "weapontype", LuaValue.String "AircraftBomb"
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1680.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "bloodyeggs"
                        ]
                ]
        ]

    let raptor_air_bomber_basic_t4_v1 =
        LuaValue.Table [
            LuaKey.String "acceleration", LuaValue.Number 0.8
            LuaKey.String "airhoverfactor", LuaValue.Number 0.0
            LuaKey.String "attackrunlength", LuaValue.Number 32.0
            LuaKey.String "maxdec", LuaValue.Number 0.1
            LuaKey.String "energycost", LuaValue.Number 4550.0
            LuaKey.String "metalcost", LuaValue.Number 212.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptorf1.DDS"
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
            LuaKey.String "objectname", LuaValue.String "Raptors/raptorf1apex.s3o"
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
            LuaKey.String "unitname", LuaValue.String "raptorf1"
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
                            LuaKey.String "accuracy", LuaValue.Number 10000.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "areaofeffect", LuaValue.Number 128.0
                            LuaKey.String "burst", LuaValue.Number 7.0
                            LuaKey.String "burstrate", LuaValue.Number 0.2
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.45
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:blood_explode_xl"
                            LuaKey.String "impulsefactor", LuaValue.Number 1.0
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "Raptors/raptoregg_l_darkgreen.s3o"
                            LuaKey.String "mygravity", LuaValue.Number 0.5
                            LuaKey.String "name", LuaValue.String "GooBombs"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1500.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.1
                            LuaKey.String "soundhit", LuaValue.String "bloodsplash3"
                            LuaKey.String "soundstart", LuaValue.String "alien_bombrel"
                            LuaKey.String "sprayangle", LuaValue.Number 20000.0
                            LuaKey.String "weapontype", LuaValue.String "AircraftBomb"
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 4320.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "bloodyeggs"
                        ]
                ]
        ]

    let raptor_air_bomber_basic_t4_v2 =
        LuaValue.Table [
            LuaKey.String "acceleration", LuaValue.Number 0.8
            LuaKey.String "airhoverfactor", LuaValue.Number 0.0
            LuaKey.String "attackrunlength", LuaValue.Number 32.0
            LuaKey.String "maxdec", LuaValue.Number 0.1
            LuaKey.String "energycost", LuaValue.Number 4550.0
            LuaKey.String "metalcost", LuaValue.Number 212.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptorf1b.DDS"
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
            LuaKey.String "health", LuaValue.Number 1700.0
            LuaKey.String "maxelevator", LuaValue.Number 0.025
            LuaKey.String "maxpitch", LuaValue.Number 0.75
            LuaKey.String "maxrudder", LuaValue.Number 0.025
            LuaKey.String "speed", LuaValue.Number 180.0
            LuaKey.String "moverate1", LuaValue.String "32"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptorf1apexb.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptorf1b.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "TALON_DEATH"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 1000.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "speedtofront", LuaValue.Number 0.07
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turnradius", LuaValue.Number 64.0
            LuaKey.String "turnrate", LuaValue.Number 1600.0
            LuaKey.String "unitname", LuaValue.String "raptorf1b"
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
                            LuaKey.String "accuracy", LuaValue.Number 10000.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "areaofeffect", LuaValue.Number 150.0
                            LuaKey.String "burst", LuaValue.Number 6.0
                            LuaKey.String "burstrate", LuaValue.Number 0.1
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.4
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:blood_explode_xl"
                            LuaKey.String "impulsefactor", LuaValue.Number 1.0
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "Raptors/raptoregg_l_darkgreen.s3o"
                            LuaKey.String "mygravity", LuaValue.Number 0.5
                            LuaKey.String "name", LuaValue.String "GooBombs"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1500.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.1
                            LuaKey.String "soundhit", LuaValue.String "bloodsplash3"
                            LuaKey.String "soundstart", LuaValue.String "alien_bombrel"
                            LuaKey.String "sprayangle", LuaValue.Number 20000.0
                            LuaKey.String "weapontype", LuaValue.String "AircraftBomb"
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 4320.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "bloodyeggs"
                        ]
                ]
        ]

    let all : (string * LuaValue) list =
        [
            "raptor_air_bomber_basic_t1_v1", raptor_air_bomber_basic_t1_v1
            "raptor_air_bomber_basic_t2_v1", raptor_air_bomber_basic_t2_v1
            "raptor_air_bomber_basic_t2_v2", raptor_air_bomber_basic_t2_v2
            "raptor_air_bomber_basic_t4_v1", raptor_air_bomber_basic_t4_v1
            "raptor_air_bomber_basic_t4_v2", raptor_air_bomber_basic_t4_v2
        ]
