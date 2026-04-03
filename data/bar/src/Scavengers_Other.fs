// Auto-generated BAR unit data: Scavengers/Other
namespace BarData.Units

open BarData

module Scavengers_Other =

    let scavempspawner =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 1.8
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "energycost", LuaValue.Number 10.0
            LuaKey.String "metalcost", LuaValue.Number 10.0
            LuaKey.String "buildpic", LuaValue.String "other/nuketest.dds"
            LuaKey.String "buildtime", LuaValue.Number 10.0
            LuaKey.String "craterboost", LuaValue.Number 0.0
            LuaKey.String "cratermult", LuaValue.Number 0.0
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "footprintx", LuaValue.Number 0.0
            LuaKey.String "footprintz", LuaValue.Number 0.0
            LuaKey.String "impulsefactor", LuaValue.Number 0.0
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 10.0
            LuaKey.String "health", LuaValue.Number 11.0
            LuaKey.String "speed", LuaValue.Number 0.0
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "objectname", LuaValue.String "scavs/cube.s3o"
            LuaKey.String "script", LuaValue.String "scavs/droppod.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 4.0
            LuaKey.String "selfdestructas", LuaValue.String "custom:newnuke-cor"
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 0.0
            LuaKey.String "unitname", LuaValue.String "nukedroppod"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "yardmap", LuaValue.String ""
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other"
                ]
            LuaKey.String "featuredefs", LuaValue.Table []
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:dirt"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "weapon", LuaValue.Table [
                            LuaKey.String "alwaysvisible", LuaValue.Bool true
                            LuaKey.String "areaofeffect", LuaValue.Number 312.0
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "cruisemissiletrail-emp"
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.45
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-huge-lightning"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "flighttime", LuaValue.Number 100.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "cortronmissile.s3o"
                            LuaKey.String "name", LuaValue.String "Heavy long-range g2g EMP starburst rocket"
                            LuaKey.String "paralyzer", LuaValue.Bool true
                            LuaKey.String "paralyzetime", LuaValue.Number 35.0
                            LuaKey.String "range", LuaValue.Number 29999.0
                            LuaKey.String "reloadtime", LuaValue.Number 5.0
                            LuaKey.String "smoketrail", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "emgpuls1"
                            LuaKey.String "soundstart", LuaValue.String "mismed1emp1"
                            LuaKey.String "startvelocity", LuaValue.Number 1.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "turret", LuaValue.Number 1.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 1800.0
                            LuaKey.String "weapontimer", LuaValue.Number 2.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1200.0
                            LuaKey.String "wobble", LuaValue.Number 50.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 50000.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "WEAPON"
                        ]
                ]
        ]

    let scavengerdroppod =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 1.8
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "energycost", LuaValue.Number 10.0
            LuaKey.String "metalcost", LuaValue.Number 10.0
            LuaKey.String "buildpic", LuaValue.String "scavengers/scavengerdroppod.DDS"
            LuaKey.String "buildtime", LuaValue.Number 10.0
            LuaKey.String "canmove", LuaValue.Bool false
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "explodeas", LuaValue.String ""
            LuaKey.String "footprintx", LuaValue.Number 0.0
            LuaKey.String "footprintz", LuaValue.Number 0.0
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 10.0
            LuaKey.String "health", LuaValue.Number 11.0
            LuaKey.String "speed", LuaValue.Number 0.0
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "objectname", LuaValue.String "scavs/cube.s3o"
            LuaKey.String "script", LuaValue.String "scavs/droppod.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 4.0
            LuaKey.String "selfdestructcountdown", LuaValue.Number 5.0
            LuaKey.String "selfdestructas", LuaValue.String ""
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 0.0
            LuaKey.String "unitname", LuaValue.String "scavengerdroppod"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 0.0
            LuaKey.String "yardmap", LuaValue.String ""
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "Scavengers"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                ]
            LuaKey.String "featuredefs", LuaValue.Table []
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:dirtpoof"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "weapon", LuaValue.Table [
                            LuaKey.String "alwaysVisible", LuaValue.Bool true
                            LuaKey.String "areaofeffect", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "cegtag", LuaValue.String "scaspawn-trail"
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.3
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:dirtpoof"
                            LuaKey.String "firestarter", LuaValue.Number 70.0
                            LuaKey.String "flighttime", LuaValue.Number 100.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.1
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 4.0
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "scavs/scavbeacondroppodbyar.s3o"
                            LuaKey.String "name", LuaValue.String "Droppod"
                            LuaKey.String "range", LuaValue.Number 29999.0
                            LuaKey.String "reloadtime", LuaValue.Number 5.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.85 0 1"
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 9.0
                            LuaKey.String "smoketime", LuaValue.Number 25.0
                            LuaKey.String "smokesize", LuaValue.Number 10.0
                            LuaKey.String "smokecolor", LuaValue.Number 0.9
                            LuaKey.String "smokeTrailCastShadow", LuaValue.Bool true
                            LuaKey.String "castshadow", LuaValue.Bool true
                            LuaKey.String "soundstart", LuaValue.String "scavspawn"
                            LuaKey.String "soundhit", LuaValue.String "scavdropspawn"
                            LuaKey.String "startvelocity", LuaValue.Number 1.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailaaflak"
                            LuaKey.String "turret", LuaValue.Number 1.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 1800.0
                            LuaKey.String "weapontimer", LuaValue.Number 2.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1500.0
                            LuaKey.String "wobble", LuaValue.Number 50.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "raptor", LuaValue.Number 0.0
                                    LuaKey.String "default", LuaValue.Number 0.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "WEAPON"
                        ]
                ]
        ]

    let scavengerdroppodfriendly =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 1.8
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "energycost", LuaValue.Number 10.0
            LuaKey.String "metalcost", LuaValue.Number 10.0
            LuaKey.String "buildpic", LuaValue.String "scavengers/SCAVBEACON.DDS"
            LuaKey.String "buildtime", LuaValue.Number 10.0
            LuaKey.String "canmove", LuaValue.Bool false
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "explodeas", LuaValue.String ""
            LuaKey.String "footprintx", LuaValue.Number 0.0
            LuaKey.String "footprintz", LuaValue.Number 0.0
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 10.0
            LuaKey.String "health", LuaValue.Number 11.0
            LuaKey.String "speed", LuaValue.Number 0.0
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "objectname", LuaValue.String "scavs/cube.s3o"
            LuaKey.String "script", LuaValue.String "scavs/droppod.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 4.0
            LuaKey.String "selfdestructas", LuaValue.String ""
            LuaKey.String "selfdestructcountdown", LuaValue.Number 0.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 0.0
            LuaKey.String "unitname", LuaValue.String "scavengerfriendlydroppod"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 0.0
            LuaKey.String "yardmap", LuaValue.String ""
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "isairbase", LuaValue.Bool true
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "other/scavengers"
                ]
            LuaKey.String "featuredefs", LuaValue.Table []
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:dirtpoof"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "weapon", LuaValue.Table [
                            LuaKey.String "alwaysvisible", LuaValue.Bool true
                            LuaKey.String "areaofeffect", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "cegtag", LuaValue.String "scaspawn-greentrail"
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.3
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:dirtpoof"
                            LuaKey.String "firestarter", LuaValue.Number 70.0
                            LuaKey.String "flighttime", LuaValue.Number 250.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.1
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 4.0
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "scavs/scavbeacondroppodbyar.s3o"
                            LuaKey.String "mygravity", LuaValue.Number 0.1
                            LuaKey.String "name", LuaValue.String "Droppod"
                            LuaKey.String "range", LuaValue.Number 29999.0
                            LuaKey.String "reloadtime", LuaValue.Number 5.0
                            LuaKey.String "rgbcolor", LuaValue.String "0 1 0"
                            LuaKey.String "smoketrail", LuaValue.Number 1.0
                            LuaKey.String "soundhit", LuaValue.String "scavspawn"
                            LuaKey.String "startvelocity", LuaValue.Number 2000.0
                            LuaKey.String "turret", LuaValue.Number 1.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 450.0
                            LuaKey.String "weapontimer", LuaValue.Number 2.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2000.0
                            LuaKey.String "wobble", LuaValue.Number 50.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "raptor", LuaValue.Number 0.0
                                    LuaKey.String "default", LuaValue.Number 0.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "WEAPON"
                        ]
                ]
        ]

    let scavtacnukespawner =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 1.8
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "energycost", LuaValue.Number 10.0
            LuaKey.String "metalcost", LuaValue.Number 10.0
            LuaKey.String "builddistance", LuaValue.Number 90.0
            LuaKey.String "buildpic", LuaValue.String "other/nuketest.dds"
            LuaKey.String "buildtime", LuaValue.Number 10.0
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "footprintx", LuaValue.Number 0.0
            LuaKey.String "footprintz", LuaValue.Number 0.0
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 10.0
            LuaKey.String "health", LuaValue.Number 11.0
            LuaKey.String "speed", LuaValue.Number 0.0
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "objectname", LuaValue.String "scavs/cube.s3o"
            LuaKey.String "script", LuaValue.String "scavs/droppod.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 4.0
            LuaKey.String "selfdestructas", LuaValue.String "custom:newnuke-cor"
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 0.0
            LuaKey.String "unitname", LuaValue.String "nukedroppod"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "yardmap", LuaValue.String ""
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other"
                ]
            LuaKey.String "featuredefs", LuaValue.Table []
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:dirt"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "weapon", LuaValue.Table [
                            LuaKey.String "alwaysvisible", LuaValue.Bool true
                            LuaKey.String "areaofeffect", LuaValue.Number 512.0
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "cruisemissiletrail-tacnuke"
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "craterareaofeffect", LuaValue.Number 512.0
                            LuaKey.String "craterboost", LuaValue.Number 1.6
                            LuaKey.String "cratermult", LuaValue.Number 0.7
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.45
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:newnuketac"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "flighttime", LuaValue.Number 100.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 4.0
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "cortronmissile.s3o"
                            LuaKey.String "name", LuaValue.String "Long range tactical g2g nuclear warheads"
                            LuaKey.String "range", LuaValue.Number 29999.0
                            LuaKey.String "reloadtime", LuaValue.Number 5.0
                            LuaKey.String "smoketrail", LuaValue.Number 1.0
                            LuaKey.String "soundhit", LuaValue.String "xplomed4"
                            LuaKey.String "soundstart", LuaValue.String "mismed1"
                            LuaKey.String "startvelocity", LuaValue.Number 1.0
                            LuaKey.String "texture1", LuaValue.String "flare2"
                            LuaKey.String "turret", LuaValue.Number 1.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 1800.0
                            LuaKey.String "weapontimer", LuaValue.Number 2.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1500.0
                            LuaKey.String "wobble", LuaValue.Number 50.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 500.0
                                    LuaKey.String "scavboss", LuaValue.Number 1.0
                                    LuaKey.String "default", LuaValue.Number 2500.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "nuclear", LuaValue.Number 1.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "WEAPON"
                        ]
                ]
        ]

    let all : (string * LuaValue) list =
        [
            "scavempspawner", scavempspawner
            "scavengerdroppod", scavengerdroppod
            "scavengerdroppodfriendly", scavengerdroppodfriendly
            "scavtacnukespawner", scavtacnukespawner
        ]
