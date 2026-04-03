// Auto-generated BAR unit data: other/raptors/Structures
namespace BarData.Units

open BarData

module other_raptors_Structures =

    let raptor_antinuke =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "buildangle", LuaValue.Number 4096.0
            LuaKey.String "energycost", LuaValue.Number 40000.0
            LuaKey.String "metalcost", LuaValue.Number 1500.0
            LuaKey.String "buildpic", LuaValue.String "raptors/raptor_hive.DDS"
            LuaKey.String "buildtime", LuaValue.Number 60000.0
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "SURFACE"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "1 1 1"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "explodeas", LuaValue.String "largeexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "health", LuaValue.Number 10000.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "noautofire", LuaValue.Bool true
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor_antinuke.s3o"
            LuaKey.String "radardistance", LuaValue.Number 50.0
            LuaKey.String "repairable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "Raptors/raptor_antinuke.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 195.0
            LuaKey.String "yardmap", LuaValue.String "oooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "antinuke"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_l_normals.png"
                    LuaKey.String "removestop", LuaValue.Bool true
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandDefenceOffence"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "cant", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "cantdo4"
                        ]
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "ok", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "loadwtr1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "loadwtr1"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "fmd_rocket", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 420.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "antimissiletrail"
                            LuaKey.String "collideenemy", LuaValue.Bool false
                            LuaKey.String "collidefeature", LuaValue.Bool false
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "coverage", LuaValue.Number 72000.0
                            LuaKey.String "craterareaofeffect", LuaValue.Number 420.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "dance", LuaValue.Number 20.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:antinuke"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "flighttime", LuaValue.Number 30.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "interceptor", LuaValue.Number 1.0
                            LuaKey.String "model", LuaValue.String "SimpleFlareXL.s3o"
                            LuaKey.String "name", LuaValue.String "ICBM intercepting missile launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 72000.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 10.0
                            LuaKey.String "smoketime", LuaValue.Number 110.0
                            LuaKey.String "smokesize", LuaValue.Number 27.0
                            LuaKey.String "smokecolor", LuaValue.Number 0.7
                            LuaKey.String "smokeTrailCastShadow", LuaValue.Bool true
                            LuaKey.String "soundhit", LuaValue.String "xplomed4"
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundstart", LuaValue.String "antinukelaunch"
                            LuaKey.String "stockpile", LuaValue.Bool true
                            LuaKey.String "stockpiletime", LuaValue.Number 60.0
                            LuaKey.String "texture1", LuaValue.String "bluenovaexplo"
                            LuaKey.String "texture2", LuaValue.String "smoketrailbar"
                            LuaKey.String "texture3", LuaValue.String "null"
                            LuaKey.String "tolerance", LuaValue.Number 7000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 120000.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 150.0
                            LuaKey.String "weapontimer", LuaValue.Number 5.0
                            LuaKey.String "weapontype", LuaValue.String "StarburstLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 6000.0
                            LuaKey.String "wobble", LuaValue.Number 32000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1500.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "ALL"
                            LuaKey.String "def", LuaValue.String "FMD_ROCKET"
                        ]
                ]
        ]

    let raptor_hive =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 1.8
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "energycost", LuaValue.Number 25000.0
            LuaKey.String "metalcost", LuaValue.Number 400.0
            LuaKey.String "builddistance", LuaValue.Number 90.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "raptors/raptor_hive.DDS"
            LuaKey.String "buildtime", LuaValue.Number 10500.0
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "84 150 84"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "metalmake", LuaValue.Number 100.0
            LuaKey.String "energymake", LuaValue.Number 1000.0
            LuaKey.String "energystorage", LuaValue.Number 10000.0
            LuaKey.String "explodeas", LuaValue.String "ROOST_DEATH"
            LuaKey.String "footprintx", LuaValue.Number 6.0
            LuaKey.String "footprintz", LuaValue.Number 6.0
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 165.75
            LuaKey.String "health", LuaValue.Number 50000.0
            LuaKey.String "speed", LuaValue.Number 0.0
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor_hive.s3o"
            LuaKey.String "radardistance", LuaValue.Number 900.0
            LuaKey.String "script", LuaValue.String "Raptors/raptor_hive2_l.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "ROOST_DEATH"
            LuaKey.String "sightdistance", LuaValue.Number 750.0
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 0.0
            LuaKey.String "unitname", LuaValue.String "roost"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 0.0
            LuaKey.String "workertime", LuaValue.Number 1500.0
            LuaKey.String "yardmap", LuaValue.String "oooooo oooooo oooooo oooooo oooooo oooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "isairbase", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "FireStorm, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_l_normals.png"
                ]
            LuaKey.String "featuredefs", LuaValue.Table []
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
                    LuaKey.String "antiground", LuaValue.Table [
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
                            LuaKey.String "range", LuaValue.Number 1000.0
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
                    LuaKey.String "antiair", LuaValue.Table [
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
                            LuaKey.String "reloadtime", LuaValue.Number 2.5
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
                                    LuaKey.String "vtol", LuaValue.Number 1000.0
                                ]
                        ]
                    LuaKey.String "spawnmeteor", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 144.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "cegtag", LuaValue.String "nuketrail-roost"
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.3
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-meteor"
                            LuaKey.String "firestarter", LuaValue.Number 70.0
                            LuaKey.String "flighttime", LuaValue.Number 100.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 4.0
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "Raptors/greyrock2.s3o"
                            LuaKey.String "name", LuaValue.String "Asteroid"
                            LuaKey.String "range", LuaValue.Number 100.0
                            LuaKey.String "reloadtime", LuaValue.Number 5.0
                            LuaKey.String "smoketrail", LuaValue.Number 1.0
                            LuaKey.String "soundhit", LuaValue.String "nuke4"
                            LuaKey.String "soundhitvolume", LuaValue.Number 10.0
                            LuaKey.String "startvelocity", LuaValue.Number 2000.0
                            LuaKey.String "turret", LuaValue.Number 1.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 120.0
                            LuaKey.String "weapontimer", LuaValue.Number 10.0
                            LuaKey.String "weaponvelocity", LuaValue.Number 2000.0
                            LuaKey.String "wobble", LuaValue.Number 0.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "raptor", LuaValue.Number 0.1
                                    LuaKey.String "default", LuaValue.Number 50000.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "ANTIGROUND"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "ANTIAIR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "SPAWNMETEOR"
                        ]
                ]
        ]

    let raptor_turret_acid_t2_v1 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0115
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 1.0
            LuaKey.String "maxdec", LuaValue.Number 0.0115
            LuaKey.String "energycost", LuaValue.Number 3000.0
            LuaKey.String "metalcost", LuaValue.Number 120.0
            LuaKey.String "builddistance", LuaValue.Number 500.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptor_turrets_acid.DDS"
            LuaKey.String "buildtime", LuaValue.Number 2700.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canreclaim", LuaValue.Bool false
            LuaKey.String "canrestore", LuaValue.Bool false
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -15 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "20 50 20"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "energystorage", LuaValue.Number 500.0
            LuaKey.String "explodeas", LuaValue.String "bug_death"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 700.0
            LuaKey.String "health", LuaValue.Number 1670.0
            LuaKey.String "maxslope", LuaValue.Number 255.0
            LuaKey.String "speed", LuaValue.Number 0.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "NANO"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor_turrets_acid_v2.s3o"
            LuaKey.String "repairable", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Raptors/raptor_turrets_v2.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "bug_death"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 750.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 1840.0
            LuaKey.String "unitname", LuaValue.String "raptord1"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 1.0
            LuaKey.String "workertime", LuaValue.Number 200.0
            LuaKey.String "yardmap", LuaValue.String "oo oo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "LathanStanley, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_l_normals.png"
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
                            LuaKey.String "range", LuaValue.Number 750.0
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
                            LuaKey.String "def", LuaValue.String "acidspit"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                ]
        ]

    let raptor_turret_acid_t3_v1 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0115
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 1.0
            LuaKey.String "maxdec", LuaValue.Number 0.0115
            LuaKey.String "energycost", LuaValue.Number 6000.0
            LuaKey.String "metalcost", LuaValue.Number 240.0
            LuaKey.String "builddistance", LuaValue.Number 500.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptor_turretl_acid.DDS"
            LuaKey.String "buildtime", LuaValue.Number 5200.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canreclaim", LuaValue.Bool false
            LuaKey.String "canrestore", LuaValue.Bool false
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -15 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "40 50 40"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "explodeas", LuaValue.String "tentacle_death"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 1400.0
            LuaKey.String "health", LuaValue.Number 11100.0
            LuaKey.String "maxslope", LuaValue.Number 255.0
            LuaKey.String "speed", LuaValue.Number 0.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "NANO"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor_turretl_acid_v2.s3o"
            LuaKey.String "repairable", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Raptors/raptor_turretl_v2.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "tentacle_death"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 1000.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 1840.0
            LuaKey.String "unitname", LuaValue.String "raptord2"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 1.0
            LuaKey.String "workertime", LuaValue.Number 100.0
            LuaKey.String "yardmap", LuaValue.String "oooo oooo oooo oooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "LathanStanley, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_l_normals.png"
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
                            LuaKey.String "reloadtime", LuaValue.Number 40.0
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
                            LuaKey.String "def", LuaValue.String "acidspit"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                ]
        ]

    let raptor_turret_acid_t4_v1 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0115
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 1.0
            LuaKey.String "maxdec", LuaValue.Number 0.0115
            LuaKey.String "energycost", LuaValue.Number 6000.0
            LuaKey.String "metalcost", LuaValue.Number 240.0
            LuaKey.String "builddistance", LuaValue.Number 500.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptor_turretl_acid.DDS"
            LuaKey.String "buildtime", LuaValue.Number 5200.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canreclaim", LuaValue.Bool false
            LuaKey.String "canrestore", LuaValue.Bool false
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -15 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "40 50 40"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "explodeas", LuaValue.String "tentacle_death"
            LuaKey.String "footprintx", LuaValue.Number 8.0
            LuaKey.String "footprintz", LuaValue.Number 8.0
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 1400.0
            LuaKey.String "health", LuaValue.Number 30000.0
            LuaKey.String "maxslope", LuaValue.Number 255.0
            LuaKey.String "speed", LuaValue.Number 0.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "NANO"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor_turretxl_acid_v2.s3o"
            LuaKey.String "repairable", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Raptors/raptor_turretxl_v2.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "tentacle_death"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 250.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 1840.0
            LuaKey.String "unitname", LuaValue.String "raptord2"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 1.0
            LuaKey.String "workertime", LuaValue.Number 100.0
            LuaKey.String "yardmap", LuaValue.String "oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "LathanStanley, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_l_normals.png"
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
                    LuaKey.String "acidspit", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 2048.0
                            LuaKey.String "areaofeffect", LuaValue.Number 150.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "burst", LuaValue.Number 16.0
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
                            LuaKey.String "range", LuaValue.Number 5000.0
                            LuaKey.String "reloadtime", LuaValue.Number 240.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.8 0.99 0.11"
                            LuaKey.String "soundhit", LuaValue.String "bloodsplash3"
                            LuaKey.String "soundstart", LuaValue.String "alien_bombrel"
                            LuaKey.String "sprayangle", LuaValue.Number 2048.0
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weapontimer", LuaValue.Number 0.2
                            LuaKey.String "weaponvelocity", LuaValue.Number 800.0
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
                            LuaKey.String "def", LuaValue.String "acidspit"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                ]
        ]

    let raptor_turret_antiair_t2_v1 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0115
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 1.0
            LuaKey.String "maxdec", LuaValue.Number 0.0115
            LuaKey.String "energycost", LuaValue.Number 3000.0
            LuaKey.String "metalcost", LuaValue.Number 120.0
            LuaKey.String "builddistance", LuaValue.Number 500.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptor_turrets_antiair.DDS"
            LuaKey.String "buildtime", LuaValue.Number 2700.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canreclaim", LuaValue.Bool false
            LuaKey.String "canrestore", LuaValue.Bool false
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -15 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "20 50 20"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "energystorage", LuaValue.Number 500.0
            LuaKey.String "explodeas", LuaValue.String "bug_death"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 700.0
            LuaKey.String "health", LuaValue.Number 1670.0
            LuaKey.String "maxslope", LuaValue.Number 255.0
            LuaKey.String "speed", LuaValue.Number 0.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "NANO"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor_turrets_red_v2.s3o"
            LuaKey.String "repairable", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Raptors/raptor_turrets_v2.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "bug_death"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 500.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 1840.0
            LuaKey.String "unitname", LuaValue.String "raptord1"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 1.0
            LuaKey.String "workertime", LuaValue.Number 200.0
            LuaKey.String "yardmap", LuaValue.String "oo oo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "LathanStanley, Beherith"
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
                            LuaKey.String "flighttime", LuaValue.Number 5.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.4
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 4.0
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "SimpleFlareXL.s3o"
                            LuaKey.String "name", LuaValue.String "Deadly Defensive Spores"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 750.0
                            LuaKey.String "reloadtime", LuaValue.Number 10.0
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
                                    LuaKey.String "vtol", LuaValue.Number 1000.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "WEAPON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let raptor_turret_antiair_t3_v1 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0115
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 1.0
            LuaKey.String "maxdec", LuaValue.Number 0.0115
            LuaKey.String "energycost", LuaValue.Number 6000.0
            LuaKey.String "metalcost", LuaValue.Number 240.0
            LuaKey.String "builddistance", LuaValue.Number 500.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptor_turretl_antiair.DDS"
            LuaKey.String "buildtime", LuaValue.Number 5200.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canreclaim", LuaValue.Bool false
            LuaKey.String "canrestore", LuaValue.Bool false
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -15 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "40 50 40"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "explodeas", LuaValue.String "tentacle_death"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 1400.0
            LuaKey.String "health", LuaValue.Number 11100.0
            LuaKey.String "maxslope", LuaValue.Number 255.0
            LuaKey.String "speed", LuaValue.Number 0.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "NANO"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor_turretl_red_v2.s3o"
            LuaKey.String "repairable", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Raptors/raptor_turretl_v2.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "tentacle_death"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 500.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 1840.0
            LuaKey.String "unitname", LuaValue.String "raptord2"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 1.0
            LuaKey.String "workertime", LuaValue.Number 100.0
            LuaKey.String "yardmap", LuaValue.String "oooo oooo oooo oooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "LathanStanley, Beherith"
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
                            LuaKey.String "flighttime", LuaValue.Number 5.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.4
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 4.0
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "SimpleFlareXL.s3o"
                            LuaKey.String "name", LuaValue.String "Deadly Defensive Spores"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1000.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.5
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
                                    LuaKey.String "vtol", LuaValue.Number 1000.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "WEAPON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let raptor_turret_antiair_t4_v1 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0115
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 1.0
            LuaKey.String "maxdec", LuaValue.Number 0.0115
            LuaKey.String "energycost", LuaValue.Number 6000.0
            LuaKey.String "metalcost", LuaValue.Number 240.0
            LuaKey.String "builddistance", LuaValue.Number 500.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptor_turretl_antiair.DDS"
            LuaKey.String "buildtime", LuaValue.Number 5200.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canreclaim", LuaValue.Bool false
            LuaKey.String "canrestore", LuaValue.Bool false
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -15 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "80 50 80"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "explodeas", LuaValue.String "tentacle_death"
            LuaKey.String "footprintx", LuaValue.Number 8.0
            LuaKey.String "footprintz", LuaValue.Number 8.0
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 1400.0
            LuaKey.String "health", LuaValue.Number 30000.0
            LuaKey.String "maxslope", LuaValue.Number 255.0
            LuaKey.String "speed", LuaValue.Number 0.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "NANO"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor_turretxl_red_v2.s3o"
            LuaKey.String "repairable", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Raptors/raptor_turretxl_v2.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "tentacle_death"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 750.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 1840.0
            LuaKey.String "unitname", LuaValue.String "raptord2"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 1.0
            LuaKey.String "workertime", LuaValue.Number 100.0
            LuaKey.String "yardmap", LuaValue.String "oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "LathanStanley, Beherith"
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
                            LuaKey.String "flighttime", LuaValue.Number 5.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.4
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 4.0
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "SimpleFlareXL.s3o"
                            LuaKey.String "name", LuaValue.String "Deadly Defensive Spores"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1250.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.25
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
                                    LuaKey.String "vtol", LuaValue.Number 1000.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "WEAPON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let raptor_turret_antinuke_t2_v1 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0115
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 1.0
            LuaKey.String "maxdec", LuaValue.Number 0.0115
            LuaKey.String "energycost", LuaValue.Number 3000.0
            LuaKey.String "metalcost", LuaValue.Number 120.0
            LuaKey.String "builddistance", LuaValue.Number 500.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptor_turrets_antinuke.DDS"
            LuaKey.String "buildtime", LuaValue.Number 2700.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canreclaim", LuaValue.Bool false
            LuaKey.String "canrestore", LuaValue.Bool false
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -15 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "20 50 20"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "energystorage", LuaValue.Number 500.0
            LuaKey.String "explodeas", LuaValue.String "bug_death"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 700.0
            LuaKey.String "health", LuaValue.Number 1670.0
            LuaKey.String "maxslope", LuaValue.Number 255.0
            LuaKey.String "speed", LuaValue.Number 0.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "NANO"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor_turrets_antinuke_v2.s3o"
            LuaKey.String "repairable", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Raptors/raptor_turrets_v2.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "bug_death"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 500.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 1840.0
            LuaKey.String "unitname", LuaValue.String "raptord1"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 1.0
            LuaKey.String "workertime", LuaValue.Number 200.0
            LuaKey.String "yardmap", LuaValue.String "oo oo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "LathanStanley, Beherith"
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
                    LuaKey.String "fmd_rocket", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 128.0
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "antimissiletrail"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "coverage", LuaValue.Number 1500.0
                            LuaKey.String "cameraShake", LuaValue.Number 700.0
                            LuaKey.String "dance", LuaValue.Number 20.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.35
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-huge-bomb"
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "flighttime", LuaValue.Number 60.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.4
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 4.0
                            LuaKey.String "interceptor", LuaValue.Number 1.0
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "SimpleFlareXL.s3o"
                            LuaKey.String "name", LuaValue.String "ICBM intercepting missile launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 72000.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 2.0
                            LuaKey.String "smoketime", LuaValue.Number 45.0
                            LuaKey.String "smokesize", LuaValue.Number 10.5
                            LuaKey.String "smokecolor", LuaValue.Number 1.0
                            LuaKey.String "soundhit", LuaValue.String "spore_explo"
                            LuaKey.String "soundstart", LuaValue.String "spore_xl"
                            LuaKey.String "soundstartvolume", LuaValue.Number 9.0
                            LuaKey.String "stockpile", LuaValue.Bool true
                            LuaKey.String "stockpiletime", LuaValue.Number 80.0
                            LuaKey.String "startvelocity", LuaValue.Number 1000.0
                            LuaKey.String "texture1", LuaValue.String "bluenovaexplo"
                            LuaKey.String "texture2", LuaValue.String "smoketrailbar"
                            LuaKey.String "texture3", LuaValue.String "null"
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
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "stockpilelimit", LuaValue.Number 5.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1500.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "ALL"
                            LuaKey.String "def", LuaValue.String "FMD_ROCKET"
                        ]
                ]
        ]

    let raptor_turret_antinuke_t3_v1 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0115
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 1.0
            LuaKey.String "maxdec", LuaValue.Number 0.0115
            LuaKey.String "energycost", LuaValue.Number 6000.0
            LuaKey.String "metalcost", LuaValue.Number 240.0
            LuaKey.String "builddistance", LuaValue.Number 500.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptor_turretl_antinuke.DDS"
            LuaKey.String "buildtime", LuaValue.Number 5200.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canreclaim", LuaValue.Bool false
            LuaKey.String "canrestore", LuaValue.Bool false
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -15 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "40 50 40"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "explodeas", LuaValue.String "tentacle_death"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 1400.0
            LuaKey.String "health", LuaValue.Number 11100.0
            LuaKey.String "maxslope", LuaValue.Number 255.0
            LuaKey.String "speed", LuaValue.Number 0.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "NANO"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor_turretl_antinuke_v2.s3o"
            LuaKey.String "repairable", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Raptors/raptor_turretl_v2.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "tentacle_death"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 1000.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 1840.0
            LuaKey.String "unitname", LuaValue.String "raptord2"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "turret", LuaValue.Bool true
            LuaKey.String "waterline", LuaValue.Number 1.0
            LuaKey.String "workertime", LuaValue.Number 100.0
            LuaKey.String "yardmap", LuaValue.String "oooo oooo oooo oooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "LathanStanley, Beherith"
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
                    LuaKey.String "fmd_rocket", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 128.0
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "antimissiletrail"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "coverage", LuaValue.Number 2500.0
                            LuaKey.String "cameraShake", LuaValue.Number 700.0
                            LuaKey.String "dance", LuaValue.Number 20.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.35
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-huge-bomb"
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "flighttime", LuaValue.Number 60.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.4
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 4.0
                            LuaKey.String "interceptor", LuaValue.Number 1.0
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "SimpleFlareXL.s3o"
                            LuaKey.String "name", LuaValue.String "ICBM intercepting missile launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 72000.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.5
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 2.0
                            LuaKey.String "smoketime", LuaValue.Number 45.0
                            LuaKey.String "smokesize", LuaValue.Number 10.5
                            LuaKey.String "smokecolor", LuaValue.Number 1.0
                            LuaKey.String "soundhit", LuaValue.String "spore_explo"
                            LuaKey.String "soundstart", LuaValue.String "spore_xl"
                            LuaKey.String "soundstartvolume", LuaValue.Number 9.0
                            LuaKey.String "stockpile", LuaValue.Bool true
                            LuaKey.String "stockpiletime", LuaValue.Number 40.0
                            LuaKey.String "startvelocity", LuaValue.Number 1000.0
                            LuaKey.String "texture1", LuaValue.String "bluenovaexplo"
                            LuaKey.String "texture2", LuaValue.String "smoketrailbar"
                            LuaKey.String "texture3", LuaValue.String "null"
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
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "stockpilelimit", LuaValue.Number 10.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1500.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "ALL"
                            LuaKey.String "def", LuaValue.String "FMD_ROCKET"
                        ]
                ]
        ]

    let raptor_turret_basic_t2_v1 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0115
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 1.0
            LuaKey.String "maxdec", LuaValue.Number 0.0115
            LuaKey.String "energycost", LuaValue.Number 3000.0
            LuaKey.String "metalcost", LuaValue.Number 120.0
            LuaKey.String "builddistance", LuaValue.Number 500.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptor_turrets.DDS"
            LuaKey.String "buildtime", LuaValue.Number 2700.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canreclaim", LuaValue.Bool false
            LuaKey.String "canrestore", LuaValue.Bool false
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -15 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "20 50 20"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "energystorage", LuaValue.Number 500.0
            LuaKey.String "explodeas", LuaValue.String "bug_death"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 700.0
            LuaKey.String "health", LuaValue.Number 1670.0
            LuaKey.String "maxslope", LuaValue.Number 255.0
            LuaKey.String "speed", LuaValue.Number 0.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "NANO"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor_turrets_v2.s3o"
            LuaKey.String "repairable", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Raptors/raptor_turrets_v2.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "bug_death"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 750.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 1840.0
            LuaKey.String "unitname", LuaValue.String "raptord1"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 1.0
            LuaKey.String "workertime", LuaValue.Number 200.0
            LuaKey.String "yardmap", LuaValue.String "oo oo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "LathanStanley, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_l_normals.png"
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
                            LuaKey.String "range", LuaValue.Number 750.0
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
                            LuaKey.String "def", LuaValue.String "WEAPON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                ]
        ]

    let raptor_turret_basic_t3_v1 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0115
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 1.0
            LuaKey.String "maxdec", LuaValue.Number 0.0115
            LuaKey.String "energycost", LuaValue.Number 6000.0
            LuaKey.String "metalcost", LuaValue.Number 240.0
            LuaKey.String "builddistance", LuaValue.Number 500.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptor_turretl.DDS"
            LuaKey.String "buildtime", LuaValue.Number 5200.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canreclaim", LuaValue.Bool false
            LuaKey.String "canrestore", LuaValue.Bool false
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -15 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "40 50 40"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "explodeas", LuaValue.String "tentacle_death"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 1400.0
            LuaKey.String "health", LuaValue.Number 11100.0
            LuaKey.String "maxslope", LuaValue.Number 255.0
            LuaKey.String "speed", LuaValue.Number 0.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "NANO"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor_turretl_v2.s3o"
            LuaKey.String "repairable", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Raptors/raptor_turretl_v2.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "tentacle_death"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 1000.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 1840.0
            LuaKey.String "unitname", LuaValue.String "raptord2"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 1.0
            LuaKey.String "workertime", LuaValue.Number 100.0
            LuaKey.String "yardmap", LuaValue.String "oooo oooo oooo oooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "LathanStanley, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_l_normals.png"
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
                            LuaKey.String "reloadtime", LuaValue.Number 40.0
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
                            LuaKey.String "def", LuaValue.String "WEAPON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                ]
        ]

    let raptor_turret_basic_t4_v1 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0115
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 1.0
            LuaKey.String "maxdec", LuaValue.Number 0.0115
            LuaKey.String "energycost", LuaValue.Number 6000.0
            LuaKey.String "metalcost", LuaValue.Number 240.0
            LuaKey.String "builddistance", LuaValue.Number 500.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptor_turretl.DDS"
            LuaKey.String "buildtime", LuaValue.Number 5200.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canreclaim", LuaValue.Bool false
            LuaKey.String "canrestore", LuaValue.Bool false
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -15 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "40 50 40"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "explodeas", LuaValue.String "tentacle_death"
            LuaKey.String "footprintx", LuaValue.Number 8.0
            LuaKey.String "footprintz", LuaValue.Number 8.0
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 1400.0
            LuaKey.String "health", LuaValue.Number 30000.0
            LuaKey.String "maxslope", LuaValue.Number 255.0
            LuaKey.String "speed", LuaValue.Number 0.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "NANO"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor_turretxl_v2.s3o"
            LuaKey.String "repairable", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Raptors/raptor_turretxl_v2.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "tentacle_death"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 250.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 1840.0
            LuaKey.String "unitname", LuaValue.String "raptord2"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 1.0
            LuaKey.String "workertime", LuaValue.Number 100.0
            LuaKey.String "yardmap", LuaValue.String "oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "LathanStanley, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_l_normals.png"
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
                            LuaKey.String "accuracy", LuaValue.Number 2048.0
                            LuaKey.String "areaofeffect", LuaValue.Number 256.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "burst", LuaValue.Number 16.0
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
                            LuaKey.String "range", LuaValue.Number 5000.0
                            LuaKey.String "reloadtime", LuaValue.Number 240.0
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
                            LuaKey.String "weaponvelocity", LuaValue.Number 800.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1280.0
                                    LuaKey.String "shields", LuaValue.Number 320.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "WEAPON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                ]
        ]

    let raptor_turret_burrow_t2_v1 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0115
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 1.0
            LuaKey.String "maxdec", LuaValue.Number 0.0115
            LuaKey.String "energycost", LuaValue.Number 3000.0
            LuaKey.String "metalcost", LuaValue.Number 120.0
            LuaKey.String "builddistance", LuaValue.Number 500.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptor_turrets_burrow.DDS"
            LuaKey.String "buildtime", LuaValue.Number 2700.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canreclaim", LuaValue.Bool false
            LuaKey.String "canrestore", LuaValue.Bool false
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -15 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "20 50 20"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "energystorage", LuaValue.Number 500.0
            LuaKey.String "explodeas", LuaValue.String "bug_death"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 700.0
            LuaKey.String "health", LuaValue.Number 1670.0
            LuaKey.String "maxslope", LuaValue.Number 255.0
            LuaKey.String "speed", LuaValue.Number 0.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "NANO"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor_turrets_v2.s3o"
            LuaKey.String "repairable", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Raptors/raptor_turrets_v2.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "bug_death"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 500.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 1840.0
            LuaKey.String "unitname", LuaValue.String "raptord1"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 1.0
            LuaKey.String "workertime", LuaValue.Number 200.0
            LuaKey.String "yardmap", LuaValue.String "oo oo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "LathanStanley, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_l_normals.png"
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
                            LuaKey.String "accuracy", LuaValue.Number 256.0
                            LuaKey.String "areaofeffect", LuaValue.Number 256.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "burst", LuaValue.Number 1.0
                            LuaKey.String "burstrate", LuaValue.Number 0.5
                            LuaKey.String "cegtag", LuaValue.String "blob_trail_red"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.63
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-huge"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.4
                            LuaKey.String "intensity", LuaValue.Number 0.7
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 1.0
                            LuaKey.String "name", LuaValue.String "GOOLAUNCHER"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number -1.0
                            LuaKey.String "range", LuaValue.Number 750.0
                            LuaKey.String "reloadtime", LuaValue.Number 8.0
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.5 0.1"
                            LuaKey.String "size", LuaValue.Number 3.0
                            LuaKey.String "sizedecay", LuaValue.Number 0.09
                            LuaKey.String "soundhit", LuaValue.String "bombsmed2"
                            LuaKey.String "soundstart", LuaValue.String "bugarty"
                            LuaKey.String "sprayangle", LuaValue.Number 512.0
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 0.2
                            LuaKey.String "weaponvelocity", LuaValue.Number 500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1600.0
                                    LuaKey.String "shields", LuaValue.Number 800.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "WEAPON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                ]
        ]

    let raptor_turret_emp_t2_v1 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0115
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 1.0
            LuaKey.String "maxdec", LuaValue.Number 0.0115
            LuaKey.String "energycost", LuaValue.Number 3000.0
            LuaKey.String "metalcost", LuaValue.Number 120.0
            LuaKey.String "builddistance", LuaValue.Number 500.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptor_turrets_electric.DDS"
            LuaKey.String "buildtime", LuaValue.Number 2700.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canreclaim", LuaValue.Bool false
            LuaKey.String "canrestore", LuaValue.Bool false
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -15 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "20 50 20"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "energystorage", LuaValue.Number 500.0
            LuaKey.String "explodeas", LuaValue.String "bug_death"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 700.0
            LuaKey.String "health", LuaValue.Number 1670.0
            LuaKey.String "maxslope", LuaValue.Number 255.0
            LuaKey.String "speed", LuaValue.Number 0.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "NANO"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor_turrets_electric_v2.s3o"
            LuaKey.String "repairable", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Raptors/raptor_turrets_v2.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "bug_death"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 750.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 1840.0
            LuaKey.String "unitname", LuaValue.String "raptord1"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 1.0
            LuaKey.String "workertime", LuaValue.Number 200.0
            LuaKey.String "yardmap", LuaValue.String "oo oo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "LathanStanley, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_l_normals.png"
                    LuaKey.String "treeshader", LuaValue.String "yes"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.0
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
                    LuaKey.String "raptorparalyzersmall", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 1024.0
                            LuaKey.String "areaofeffect", LuaValue.Number 220.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "burst", LuaValue.Number 2.0
                            LuaKey.String "burstrate", LuaValue.Number 0.001
                            LuaKey.String "cegtag", LuaValue.String "blob_trail_blue"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.63
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large-lightning"
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.8
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 1.0
                            LuaKey.String "name", LuaValue.String "GOOLAUNCHER"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "paralyzer", LuaValue.Bool true
                            LuaKey.String "paralyzetime", LuaValue.Number 20.0
                            LuaKey.String "proximitypriority", LuaValue.Number -1.0
                            LuaKey.String "range", LuaValue.Number 750.0
                            LuaKey.String "reloadtime", LuaValue.Number 40.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.2 0.5 0.9"
                            LuaKey.String "size", LuaValue.Number 5.5
                            LuaKey.String "sizedecay", LuaValue.Number 0.09
                            LuaKey.String "soundhit", LuaValue.String "empbomb"
                            LuaKey.String "soundstart", LuaValue.String "bugarty"
                            LuaKey.String "sprayangle", LuaValue.Number 1024.0
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weapontimer", LuaValue.Number 0.2
                            LuaKey.String "weaponvelocity", LuaValue.Number 520.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 3600.0
                                    LuaKey.String "shields", LuaValue.Number 800.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "raptorparalyzersmall"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                ]
        ]

    let raptor_turret_emp_t3_v1 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0115
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 1.0
            LuaKey.String "maxdec", LuaValue.Number 0.0115
            LuaKey.String "energycost", LuaValue.Number 6000.0
            LuaKey.String "metalcost", LuaValue.Number 240.0
            LuaKey.String "builddistance", LuaValue.Number 500.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptor_turretl_electric.DDS"
            LuaKey.String "buildtime", LuaValue.Number 5200.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canreclaim", LuaValue.Bool false
            LuaKey.String "canrestore", LuaValue.Bool false
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -15 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "40 50 40"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "explodeas", LuaValue.String "tentacle_death"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 1400.0
            LuaKey.String "health", LuaValue.Number 11100.0
            LuaKey.String "maxslope", LuaValue.Number 255.0
            LuaKey.String "speed", LuaValue.Number 0.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "NANO"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor_turretl_electric_v2.s3o"
            LuaKey.String "repairable", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Raptors/raptor_turretl_v2.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "tentacle_death"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 1000.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 1840.0
            LuaKey.String "unitname", LuaValue.String "raptord2"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 1.0
            LuaKey.String "workertime", LuaValue.Number 100.0
            LuaKey.String "yardmap", LuaValue.String "oooo oooo oooo oooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "LathanStanley, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_l_normals.png"
                    LuaKey.String "treeshader", LuaValue.String "yes"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.0
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
                    LuaKey.String "raptorparalyzerbig", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 2048.0
                            LuaKey.String "areaofeffect", LuaValue.Number 220.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "burst", LuaValue.Number 8.0
                            LuaKey.String "burstrate", LuaValue.Number 0.001
                            LuaKey.String "cegtag", LuaValue.String "blob_trail_blue"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.63
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large-lightning"
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.8
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 1.0
                            LuaKey.String "name", LuaValue.String "GOOLAUNCHER"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "paralyzer", LuaValue.Bool true
                            LuaKey.String "paralyzetime", LuaValue.Number 20.0
                            LuaKey.String "proximitypriority", LuaValue.Number -1.0
                            LuaKey.String "range", LuaValue.Number 2000.0
                            LuaKey.String "reloadtime", LuaValue.Number 80.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.2 0.5 0.9"
                            LuaKey.String "size", LuaValue.Number 5.5
                            LuaKey.String "sizedecay", LuaValue.Number 0.09
                            LuaKey.String "soundhit", LuaValue.String "empbomb"
                            LuaKey.String "soundstart", LuaValue.String "bugarty"
                            LuaKey.String "sprayangle", LuaValue.Number 2048.0
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weapontimer", LuaValue.Number 0.2
                            LuaKey.String "weaponvelocity", LuaValue.Number 520.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 3600.0
                                    LuaKey.String "shields", LuaValue.Number 800.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "raptorparalyzerbig"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                ]
        ]

    let raptor_turret_emp_t4_v1 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0115
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 1.0
            LuaKey.String "maxdec", LuaValue.Number 0.0115
            LuaKey.String "energycost", LuaValue.Number 6000.0
            LuaKey.String "metalcost", LuaValue.Number 240.0
            LuaKey.String "builddistance", LuaValue.Number 500.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptor_turretl_electric.DDS"
            LuaKey.String "buildtime", LuaValue.Number 5200.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canreclaim", LuaValue.Bool false
            LuaKey.String "canrestore", LuaValue.Bool false
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -15 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "40 50 40"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "explodeas", LuaValue.String "tentacle_death"
            LuaKey.String "footprintx", LuaValue.Number 8.0
            LuaKey.String "footprintz", LuaValue.Number 8.0
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 1400.0
            LuaKey.String "health", LuaValue.Number 30000.0
            LuaKey.String "maxslope", LuaValue.Number 255.0
            LuaKey.String "speed", LuaValue.Number 0.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "NANO"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor_turretxl_electric_v2.s3o"
            LuaKey.String "repairable", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Raptors/raptor_turretxl_v2.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "tentacle_death"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 250.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 1840.0
            LuaKey.String "unitname", LuaValue.String "raptord2"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 1.0
            LuaKey.String "workertime", LuaValue.Number 100.0
            LuaKey.String "yardmap", LuaValue.String "oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "LathanStanley, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_l_normals.png"
                    LuaKey.String "treeshader", LuaValue.String "yes"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.0
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
                    LuaKey.String "raptorparalyzerbig", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 2048.0
                            LuaKey.String "areaofeffect", LuaValue.Number 220.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "burst", LuaValue.Number 32.0
                            LuaKey.String "burstrate", LuaValue.Number 0.001
                            LuaKey.String "cegtag", LuaValue.String "blob_trail_blue"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.63
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large-lightning"
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.8
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 1.0
                            LuaKey.String "name", LuaValue.String "GOOLAUNCHER"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "paralyzer", LuaValue.Bool true
                            LuaKey.String "paralyzetime", LuaValue.Number 20.0
                            LuaKey.String "proximitypriority", LuaValue.Number -1.0
                            LuaKey.String "range", LuaValue.Number 5000.0
                            LuaKey.String "reloadtime", LuaValue.Number 480.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.2 0.5 0.9"
                            LuaKey.String "size", LuaValue.Number 5.5
                            LuaKey.String "sizedecay", LuaValue.Number 0.09
                            LuaKey.String "soundhit", LuaValue.String "empbomb"
                            LuaKey.String "soundstart", LuaValue.String "bugarty"
                            LuaKey.String "sprayangle", LuaValue.Number 2048.0
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weapontimer", LuaValue.Number 0.2
                            LuaKey.String "weaponvelocity", LuaValue.Number 800.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 3600.0
                                    LuaKey.String "shields", LuaValue.Number 800.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "raptorparalyzerbig"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                ]
        ]

    let raptor_turret_meteor_t4_v1 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0115
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 1.0
            LuaKey.String "maxdec", LuaValue.Number 0.0115
            LuaKey.String "energycost", LuaValue.Number 6000.0
            LuaKey.String "metalcost", LuaValue.Number 240.0
            LuaKey.String "builddistance", LuaValue.Number 500.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptor_turretxl_meteor.DDS"
            LuaKey.String "buildtime", LuaValue.Number 5200.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canreclaim", LuaValue.Bool false
            LuaKey.String "canrestore", LuaValue.Bool false
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -15 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "80 50 80"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "explodeas", LuaValue.String "tentacle_death"
            LuaKey.String "footprintx", LuaValue.Number 8.0
            LuaKey.String "footprintz", LuaValue.Number 8.0
            LuaKey.String "hightrajectory", LuaValue.Number 1.0
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 1400.0
            LuaKey.String "health", LuaValue.Number 30000.0
            LuaKey.String "maxslope", LuaValue.Number 255.0
            LuaKey.String "speed", LuaValue.Number 0.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "NANO"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor_turretxl_meteor_v2.s3o"
            LuaKey.String "repairable", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Raptors/raptor_turretxl_v2.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "tentacle_death"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 500.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 1840.0
            LuaKey.String "unitname", LuaValue.String "raptord2"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 1.0
            LuaKey.String "workertime", LuaValue.Number 100.0
            LuaKey.String "yardmap", LuaValue.String "oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "LathanStanley, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_l_normals.png"
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
                            LuaKey.String "areaofeffect", LuaValue.Number 1920.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "cegtag", LuaValue.String "nuketrail-roost"
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "commandfire", LuaValue.Bool true
                            LuaKey.String "craterareaofeffect", LuaValue.Number 1920.0
                            LuaKey.String "craterboost", LuaValue.Number 2.4
                            LuaKey.String "cratermult", LuaValue.Number 1.2
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.5
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:newnukecor"
                            LuaKey.String "firestarter", LuaValue.Number 70.0
                            LuaKey.String "hightrajectory", LuaValue.Number 1.0
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "Raptors/greyrock2.s3o"
                            LuaKey.String "name", LuaValue.String "METEORLAUNCHER"
                            LuaKey.String "proximitypriority", LuaValue.Number -1.0
                            LuaKey.String "range", LuaValue.Number 72000.0
                            LuaKey.String "reloadtime", LuaValue.Number 30.0
                            LuaKey.String "soundhit", LuaValue.String "nukecor"
                            LuaKey.String "soundhitwet", LuaValue.String "nukewater"
                            LuaKey.String "soundstart", LuaValue.String "bugarty"
                            LuaKey.String "targetable", LuaValue.Number 1.0
                            LuaKey.String "turret", LuaValue.Number 1.0
                            LuaKey.String "weaponvelocity", LuaValue.Number 1500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 30000.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "shield_aoe_penetration", LuaValue.Bool true
                                    LuaKey.String "nuclear", LuaValue.Number 1.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "WEAPON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NONE"
                        ]
                ]
        ]

    let raptor_worm_green =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0115
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 1.0
            LuaKey.String "maxdec", LuaValue.Number 0.0115
            LuaKey.String "energycost", LuaValue.Number 6000.0
            LuaKey.String "metalcost", LuaValue.Number 240.0
            LuaKey.String "builddistance", LuaValue.Number 500.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptor_worm_green.DDS"
            LuaKey.String "buildtime", LuaValue.Number 5200.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canreclaim", LuaValue.Bool false
            LuaKey.String "canrestore", LuaValue.Bool false
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 15 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "35 50 35"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "explodeas", LuaValue.String "tentacle_death"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 1400.0
            LuaKey.String "health", LuaValue.Number 11100.0
            LuaKey.String "maxslope", LuaValue.Number 255.0
            LuaKey.String "speed", LuaValue.Number 0.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "NANO"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor_worm_green.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptor_worm_m.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "tentacle_death"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 1000.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 1840.0
            LuaKey.String "unitname", LuaValue.String "raptord2"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 1.0
            LuaKey.String "workertime", LuaValue.Number 100.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "LathanStanley, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_l_normals.png"
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
                    LuaKey.String "acidspit", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 1024.0
                            LuaKey.String "areaofeffect", LuaValue.Number 150.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
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
                            LuaKey.String "range", LuaValue.Number 1000.0
                            LuaKey.String "reloadtime", LuaValue.Number 4.5
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
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "acidspit"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                ]
        ]

    let all : (string * LuaValue) list =
        [
            "raptor_antinuke", raptor_antinuke
            "raptor_hive", raptor_hive
            "raptor_turret_acid_t2_v1", raptor_turret_acid_t2_v1
            "raptor_turret_acid_t3_v1", raptor_turret_acid_t3_v1
            "raptor_turret_acid_t4_v1", raptor_turret_acid_t4_v1
            "raptor_turret_antiair_t2_v1", raptor_turret_antiair_t2_v1
            "raptor_turret_antiair_t3_v1", raptor_turret_antiair_t3_v1
            "raptor_turret_antiair_t4_v1", raptor_turret_antiair_t4_v1
            "raptor_turret_antinuke_t2_v1", raptor_turret_antinuke_t2_v1
            "raptor_turret_antinuke_t3_v1", raptor_turret_antinuke_t3_v1
            "raptor_turret_basic_t2_v1", raptor_turret_basic_t2_v1
            "raptor_turret_basic_t3_v1", raptor_turret_basic_t3_v1
            "raptor_turret_basic_t4_v1", raptor_turret_basic_t4_v1
            "raptor_turret_burrow_t2_v1", raptor_turret_burrow_t2_v1
            "raptor_turret_emp_t2_v1", raptor_turret_emp_t2_v1
            "raptor_turret_emp_t3_v1", raptor_turret_emp_t3_v1
            "raptor_turret_emp_t4_v1", raptor_turret_emp_t4_v1
            "raptor_turret_meteor_t4_v1", raptor_turret_meteor_t4_v1
            "raptor_worm_green", raptor_worm_green
        ]
