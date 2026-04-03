// Auto-generated BAR unit data: ArmShips/T2
namespace BarData.Units

open BarData

module ArmShips_T2 =

    let armaas =
        LuaValue.Table [
            LuaKey.String "airsightdistance", LuaValue.Number 900.0
            LuaKey.String "buildangle", LuaValue.Number 16384.0
            LuaKey.String "buildpic", LuaValue.String "ARMAAS.DDS"
            LuaKey.String "buildtime", LuaValue.Number 21000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -5 -1"
            LuaKey.String "collisionvolumescales", LuaValue.String "31 31 74"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylZ"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 12000.0
            LuaKey.String "explodeas", LuaValue.String "largeExplosionGeneric-uw"
            LuaKey.String "floater", LuaValue.Bool true
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 3900.0
            LuaKey.String "maxacc", LuaValue.Number 0.03875
            LuaKey.String "maxdec", LuaValue.Number 0.03875
            LuaKey.String "metalcost", LuaValue.Number 1000.0
            LuaKey.String "minwaterdepth", LuaValue.Number 30.0
            LuaKey.String "movementclass", LuaValue.String "BOAT4"
            LuaKey.String "movestate", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "NOTAIR"
            LuaKey.String "objectname", LuaValue.String "Units/ARMAAS.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMAAS.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeExplosionGenericSelfd-uw"
            LuaKey.String "sightdistance", LuaValue.Number 475.0
            LuaKey.String "speed", LuaValue.Number 63.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.344
            LuaKey.String "turnrate", LuaValue.Number 405.0
            LuaKey.String "waterline", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmShips/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "aa"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "-1.40724182129 -7.7758789061e-06 -0.172019958496"
                            LuaKey.String "collisionvolumescales", LuaValue.String "36.1561584473 29.9421844482 83.5312347412"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 8320.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 500.0
                            LuaKey.String "object", LuaValue.String "Units/armaas_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 4032.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 250.0
                            LuaKey.String "object", LuaValue.String "Units/arm2X2B.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-flak"
                            LuaKey.Int 2, LuaValue.String "custom:waterwake-medium-splash"
                        ]
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
                            LuaKey.Int 1, LuaValue.String "sharmmov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "sharmsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "bogus_missile", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 48.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "name", LuaValue.String "Missiles"
                            LuaKey.String "range", LuaValue.Number 800.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.5
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "startvelocity", LuaValue.Number 450.0
                            LuaKey.String "tolerance", LuaValue.Number 9000.0
                            LuaKey.String "turnrate", LuaValue.Number 49500.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 101.0
                            LuaKey.String "weapontimer", LuaValue.Number 0.1
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 650.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "bogus", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 0.0
                                ]
                        ]
                    LuaKey.String "ga2", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 64.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "burst", LuaValue.Number 2.0
                            LuaKey.String "burstrate", LuaValue.Number 0.4
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "castshadow", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "missiletrailaa"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 0.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-tiny-aa"
                            LuaKey.String "firestarter", LuaValue.Number 72.0
                            LuaKey.String "flighttime", LuaValue.Number 1.75
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "cormissile.s3o"
                            LuaKey.String "name", LuaValue.String "Long-range g2a guided missile launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 840.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.8
                            LuaKey.String "smokecolor", LuaValue.Number 0.95
                            LuaKey.String "smokeperiod", LuaValue.Number 6.0
                            LuaKey.String "smokesize", LuaValue.Number 4.2
                            LuaKey.String "smoketime", LuaValue.Number 11.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smoketrailcastshadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "packohit"
                            LuaKey.String "soundhitwet", LuaValue.String "splssml"
                            LuaKey.String "soundstart", LuaValue.String "packolau"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "startvelocity", LuaValue.Number 200.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailaa"
                            LuaKey.String "tolerance", LuaValue.Number 9950.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 68000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 500.0
                            LuaKey.String "weapontimer", LuaValue.Number 5.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 880.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "vtol", LuaValue.Number 63.0
                                ]
                        ]
                    LuaKey.String "mobileflak", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 1000.0
                            LuaKey.String "areaofeffect", LuaValue.Number 140.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "flaktrailaa"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 140.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 1.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:flak"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "name", LuaValue.String "Heavy g2a flak cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 790.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.73333
                            LuaKey.String "soundhit", LuaValue.String "flakhit"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "flakfire"
                            LuaKey.String "stages", LuaValue.Number 0.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 1.0
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1300.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "norangering", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "vtol", LuaValue.Number 200.0
                                ]
                            LuaKey.String "rgbcolor", LuaValue.Table [
                                    LuaKey.Int 1, LuaValue.Number 1.0
                                    LuaKey.Int 2, LuaValue.Number 0.33
                                    LuaKey.Int 3, LuaValue.Number 0.7
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR LIGHTAIRSCOUT"
                            LuaKey.String "def", LuaValue.String "BOGUS_MISSILE"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR LIGHTAIRSCOUT"
                            LuaKey.String "def", LuaValue.String "GA2"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR LIGHTAIRSCOUT"
                            LuaKey.String "def", LuaValue.String "MOBILEFLAK"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let armacsub =
        LuaValue.Table [
            LuaKey.String "builddistance", LuaValue.Number 180.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMACSUB.DDS"
            LuaKey.String "buildtime", LuaValue.Number 23000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 -1"
            LuaKey.String "collisionvolumescales", LuaValue.String "38 38 63"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylZ"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 9000.0
            LuaKey.String "energymake", LuaValue.Number 30.0
            LuaKey.String "energystorage", LuaValue.Number 150.0
            LuaKey.String "explodeas", LuaValue.String "smallExplosionGeneric-uw"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 1110.0
            LuaKey.String "maxacc", LuaValue.Number 0.04428
            LuaKey.String "maxdec", LuaValue.Number 0.04428
            LuaKey.String "metalcost", LuaValue.Number 700.0
            LuaKey.String "minwaterdepth", LuaValue.Number 20.0
            LuaKey.String "movementclass", LuaValue.String "UBOAT4"
            LuaKey.String "objectname", LuaValue.String "Units/ARMACSUB.s3o"
            LuaKey.String "radardistance", LuaValue.Number 50.0
            LuaKey.String "script", LuaValue.String "Units/ARMACSUB.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "smallExplosionGenericSelfd-uw"
            LuaKey.String "sightdistance", LuaValue.Number 156.0
            LuaKey.String "speed", LuaValue.Number 72.0
            LuaKey.String "terraformspeed", LuaValue.Number 1500.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 405.0
            LuaKey.String "waterline", LuaValue.Number 80.0
            LuaKey.String "workertime", LuaValue.Number 350.0
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "armuwfus"
                    LuaKey.Int 2, LuaValue.String "armuwmmm"
                    LuaKey.Int 3, LuaValue.String "armuwmme"
                    LuaKey.Int 4, LuaValue.String "armuwadves"
                    LuaKey.Int 5, LuaValue.String "armuwadvms"
                    LuaKey.Int 6, LuaValue.String "armshltxuw"
                    LuaKey.Int 7, LuaValue.String "armasy"
                    LuaKey.Int 8, LuaValue.String "armsy"
                    LuaKey.Int 9, LuaValue.String "armason"
                    LuaKey.Int 10, LuaValue.String "armfatf"
                    LuaKey.Int 11, LuaValue.String "armatl"
                    LuaKey.Int 12, LuaValue.String "armfflak"
                    LuaKey.Int 13, LuaValue.String "armkraken"
                    LuaKey.Int 14, LuaValue.String "armuwageo"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmShips/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "buildert2"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.0 2.5122070312e-05 0.236854553223"
                            LuaKey.String "collisionvolumescales", LuaValue.String "49.0049743652 25.7252502441 71.2612762451"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 432.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 350.0
                            LuaKey.String "object", LuaValue.String "Units/armacsub_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 4032.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 175.0
                            LuaKey.String "object", LuaValue.String "Units/arm2X2A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "nanlath1"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "capture", LuaValue.String "capture1"
                    LuaKey.String "repair", LuaValue.String "repair1"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "working", LuaValue.String "reclaim1"
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
                            LuaKey.Int 1, LuaValue.String "suarmmov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "suarmsel"
                        ]
                ]
        ]

    let armantiship =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildangle", LuaValue.Number 16384.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMANTISHIP.DDS"
            LuaKey.String "buildtime", LuaValue.Number 27000.0
            LuaKey.String "canassist", LuaValue.Bool false
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canreclaim", LuaValue.Bool false
            LuaKey.String "canrepair", LuaValue.Bool false
            LuaKey.String "canrestore", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 2"
            LuaKey.String "collisionvolumescales", LuaValue.String "48 48 140"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylZ"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 12000.0
            LuaKey.String "energymake", LuaValue.Number 300.0
            LuaKey.String "energypershot", LuaValue.Number 7500.0
            LuaKey.String "energystorage", LuaValue.Number 1500.0
            LuaKey.String "explodeas", LuaValue.String "minifusionExplosion"
            LuaKey.String "floater", LuaValue.Bool true
            LuaKey.String "footprintx", LuaValue.Number 7.0
            LuaKey.String "footprintz", LuaValue.Number 7.0
            LuaKey.String "health", LuaValue.Number 5000.0
            LuaKey.String "mass", LuaValue.Number 10000.0
            LuaKey.String "maxacc", LuaValue.Number 0.01722
            LuaKey.String "maxdec", LuaValue.Number 0.01722
            LuaKey.String "metalcost", LuaValue.Number 1400.0
            LuaKey.String "minwaterdepth", LuaValue.Number 15.0
            LuaKey.String "movementclass", LuaValue.String "BOAT5"
            LuaKey.String "movestate", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/ARMANTISHIP.s3o"
            LuaKey.String "radardistance", LuaValue.Number 2950.0
            LuaKey.String "radaremitheight", LuaValue.Number 56.0
            LuaKey.String "script", LuaValue.String "Units/ARMANTISHIP.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "minifusionExplosion"
            LuaKey.String "sightdistance", LuaValue.Number 1000.0
            LuaKey.String "sightemitheight", LuaValue.Number 56.0
            LuaKey.String "sonardistance", LuaValue.Number 760.0
            LuaKey.String "speed", LuaValue.Number 63.0
            LuaKey.String "terraformspeed", LuaValue.Number 5000.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 180.0
            LuaKey.String "waterline", LuaValue.Number 0.0
            LuaKey.String "workertime", LuaValue.Number 1000.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmShips/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "antinuke"
                    LuaKey.String "restrictions_exclusion", LuaValue.String "_noantinuke_"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "-0.0550308227539 1.52587890767e-06 4.55026245117"
                            LuaKey.String "collisionvolumescales", LuaValue.String "61.8225860596 60.9250030518 154.450805664"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 9168.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 700.0
                            LuaKey.String "object", LuaValue.String "Units/armantiship_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 4032.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 350.0
                            LuaKey.String "object", LuaValue.String "Units/arm6X6C.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:radarpulse_t2"
                            LuaKey.Int 2, LuaValue.String "custom:waterwake-large"
                            LuaKey.Int 3, LuaValue.String "custom:bowsplash-huge"
                        ]
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
                            LuaKey.Int 1, LuaValue.String "sharmmov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "sharmsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "amd_rocket", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 420.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "antimissiletrail"
                            LuaKey.String "collideenemy", LuaValue.Bool false
                            LuaKey.String "collidefeature", LuaValue.Bool false
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "coverage", LuaValue.Number 1600.0
                            LuaKey.String "craterareaofeffect", LuaValue.Number 420.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 7500.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:antinuke"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "flighttime", LuaValue.Number 20.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "interceptor", LuaValue.Number 1.0
                            LuaKey.String "metalpershot", LuaValue.Number 150.0
                            LuaKey.String "model", LuaValue.String "fmdmissile.s3o"
                            LuaKey.String "name", LuaValue.String "ICBM intercepting missile launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 72000.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.0
                            LuaKey.String "smokecolor", LuaValue.Number 0.7
                            LuaKey.String "smokeperiod", LuaValue.Number 10.0
                            LuaKey.String "smokesize", LuaValue.Number 27.0
                            LuaKey.String "smoketime", LuaValue.Number 110.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smoketrailcastshadow", LuaValue.Bool true
                            LuaKey.String "soundhit", LuaValue.String "xplomed4"
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundstart", LuaValue.String "antinukelaunch"
                            LuaKey.String "stockpile", LuaValue.Bool true
                            LuaKey.String "stockpiletime", LuaValue.Number 90.0
                            LuaKey.String "texture1", LuaValue.String "bluenovaexplo"
                            LuaKey.String "texture2", LuaValue.String "smoketrailbar"
                            LuaKey.String "texture3", LuaValue.String "null"
                            LuaKey.String "tolerance", LuaValue.Number 7000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 10000.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 150.0
                            LuaKey.String "weapontimer", LuaValue.Number 2.5
                            LuaKey.String "weapontype", LuaValue.String "StarburstLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 6000.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "stockpilelimit", LuaValue.Number 20.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1500.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "ALL"
                            LuaKey.String "def", LuaValue.String "AMD_ROCKET"
                        ]
                ]
        ]

    let armbats =
        LuaValue.Table [
            LuaKey.String "buildangle", LuaValue.Number 16384.0
            LuaKey.String "buildpic", LuaValue.String "ARMBATS.DDS"
            LuaKey.String "buildtime", LuaValue.Number 50000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "-1 -10 4"
            LuaKey.String "collisionvolumescales", LuaValue.String "63 63 144"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylZ"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 22000.0
            LuaKey.String "explodeas", LuaValue.String "hugeexplosiongeneric"
            LuaKey.String "floater", LuaValue.Bool true
            LuaKey.String "footprintx", LuaValue.Number 6.0
            LuaKey.String "footprintz", LuaValue.Number 6.0
            LuaKey.String "health", LuaValue.Number 9800.0
            LuaKey.String "maxacc", LuaValue.Number 0.01583
            LuaKey.String "maxdec", LuaValue.Number 0.01583
            LuaKey.String "metalcost", LuaValue.Number 3300.0
            LuaKey.String "minwaterdepth", LuaValue.Number 15.0
            LuaKey.String "movementclass", LuaValue.String "BOAT9"
            LuaKey.String "movestate", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/ARMBATS.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMBATS.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "hugeexplosiongenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 600.0
            LuaKey.String "speed", LuaValue.Number 57.9
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 180.0
            LuaKey.String "waterline", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmShips/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "-16.0281448364 -3.59007536621 -2.5637588501"
                            LuaKey.String "collisionvolumescales", LuaValue.String "74.9459686279 67.6992492676 151.322341919"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 12972.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 1650.0
                            LuaKey.String "object", LuaValue.String "Units/armbats_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 4032.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 825.0
                            LuaKey.String "object", LuaValue.String "Units/arm6X6D.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-large"
                            LuaKey.Int 2, LuaValue.String "custom:waterwake-large"
                            LuaKey.Int 3, LuaValue.String "custom:bowsplash-large"
                        ]
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
                            LuaKey.Int 1, LuaValue.String "sharmmov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "sharmsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "arm_bats", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 350.0
                            LuaKey.String "areaofeffect", LuaValue.Number 140.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "name", LuaValue.String "Heavy long-range g2g plasma cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 880.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.0
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy1"
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 470.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "noattackrangearc", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 300.0
                                    LuaKey.String "vtol", LuaValue.Number 65.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "ARM_BATS"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "ARM_BATS"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 270.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let armcarry =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildangle", LuaValue.Number 16384.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMCARRY.DDS"
            LuaKey.String "buildtime", LuaValue.Number 27000.0
            LuaKey.String "canassist", LuaValue.Bool false
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canreclaim", LuaValue.Bool false
            LuaKey.String "canrepair", LuaValue.Bool false
            LuaKey.String "canrestore", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "-1 -7 2"
            LuaKey.String "collisionvolumescales", LuaValue.String "64 64 159"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylZ"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 12000.0
            LuaKey.String "energymake", LuaValue.Number 300.0
            LuaKey.String "energypershot", LuaValue.Number 7500.0
            LuaKey.String "energystorage", LuaValue.Number 1500.0
            LuaKey.String "energyupkeep", LuaValue.Number 25.0
            LuaKey.String "explodeas", LuaValue.String "minifusionExplosion"
            LuaKey.String "floater", LuaValue.Bool true
            LuaKey.String "footprintx", LuaValue.Number 7.0
            LuaKey.String "footprintz", LuaValue.Number 7.0
            LuaKey.String "health", LuaValue.Number 5000.0
            LuaKey.String "mass", LuaValue.Number 10000.0
            LuaKey.String "maxacc", LuaValue.Number 0.01722
            LuaKey.String "maxdec", LuaValue.Number 0.01722
            LuaKey.String "metalcost", LuaValue.Number 1400.0
            LuaKey.String "minwaterdepth", LuaValue.Number 15.0
            LuaKey.String "movementclass", LuaValue.String "BOAT9"
            LuaKey.String "movestate", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/ARMCARRY.s3o"
            LuaKey.String "radardistance", LuaValue.Number 2950.0
            LuaKey.String "radaremitheight", LuaValue.Number 56.0
            LuaKey.String "script", LuaValue.String "Units/ARMCARRY.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "minifusionExplosion"
            LuaKey.String "sightdistance", LuaValue.Number 1105.0
            LuaKey.String "sightemitheight", LuaValue.Number 56.0
            LuaKey.String "sonardistance", LuaValue.Number 760.0
            LuaKey.String "speed", LuaValue.Number 63.0
            LuaKey.String "terraformspeed", LuaValue.Number 5000.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 180.0
            LuaKey.String "waterline", LuaValue.Number 0.0
            LuaKey.String "workertime", LuaValue.Number 1000.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "isairbase", LuaValue.Bool true
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmShips/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "antinuke"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "-0.0550308227539 1.52587890767e-06 4.55026245117"
                            LuaKey.String "collisionvolumescales", LuaValue.String "61.8225860596 60.9250030518 154.450805664"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 9168.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 700.0
                            LuaKey.String "object", LuaValue.String "Units/armcarry_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 4032.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 350.0
                            LuaKey.String "object", LuaValue.String "Units/arm6X6C.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:radarpulse_t2"
                            LuaKey.Int 2, LuaValue.String "custom:waterwake-large"
                            LuaKey.Int 3, LuaValue.String "custom:bowsplash-huge"
                        ]
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
                            LuaKey.Int 1, LuaValue.String "sharmmov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "sharmsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "amd_rocket", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 420.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "antimissiletrail"
                            LuaKey.String "collideenemy", LuaValue.Bool false
                            LuaKey.String "collidefeature", LuaValue.Bool false
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "coverage", LuaValue.Number 1600.0
                            LuaKey.String "craterareaofeffect", LuaValue.Number 420.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 7500.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:antinuke"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "flighttime", LuaValue.Number 20.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "interceptor", LuaValue.Number 1.0
                            LuaKey.String "metalpershot", LuaValue.Number 150.0
                            LuaKey.String "model", LuaValue.String "fmdmissile.s3o"
                            LuaKey.String "name", LuaValue.String "ICBM intercepting missile launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 72000.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.0
                            LuaKey.String "smokecolor", LuaValue.Number 0.7
                            LuaKey.String "smokeperiod", LuaValue.Number 10.0
                            LuaKey.String "smokesize", LuaValue.Number 27.0
                            LuaKey.String "smoketime", LuaValue.Number 110.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smoketrailcastshadow", LuaValue.Bool true
                            LuaKey.String "soundhit", LuaValue.String "xplomed4"
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundstart", LuaValue.String "antinukelaunch"
                            LuaKey.String "stockpile", LuaValue.Bool true
                            LuaKey.String "stockpiletime", LuaValue.Number 90.0
                            LuaKey.String "texture1", LuaValue.String "bluenovaexplo"
                            LuaKey.String "texture2", LuaValue.String "smoketrailbar"
                            LuaKey.String "texture3", LuaValue.String "null"
                            LuaKey.String "tolerance", LuaValue.Number 7000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 10000.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 150.0
                            LuaKey.String "weapontimer", LuaValue.Number 2.5
                            LuaKey.String "weapontype", LuaValue.String "StarburstLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 6000.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "stockpilelimit", LuaValue.Number 20.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1500.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "ALL"
                            LuaKey.String "def", LuaValue.String "AMD_ROCKET"
                        ]
                ]
        ]

    let armcrus =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildangle", LuaValue.Number 16384.0
            LuaKey.String "buildpic", LuaValue.String "ARMCRUS.DDS"
            LuaKey.String "buildtime", LuaValue.Number 23000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -8 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "32 32 112"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylZ"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 12000.0
            LuaKey.String "explodeas", LuaValue.String "largeexplosiongeneric"
            LuaKey.String "floater", LuaValue.Bool true
            LuaKey.String "footprintx", LuaValue.Number 5.0
            LuaKey.String "footprintz", LuaValue.Number 5.0
            LuaKey.String "health", LuaValue.Number 5600.0
            LuaKey.String "maxacc", LuaValue.Number 0.02952
            LuaKey.String "maxdec", LuaValue.Number 0.02952
            LuaKey.String "metalcost", LuaValue.Number 1000.0
            LuaKey.String "minwaterdepth", LuaValue.Number 30.0
            LuaKey.String "movementclass", LuaValue.String "BOAT5"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/ARMCRUS.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMCRUS.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeexplosiongenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 600.0
            LuaKey.String "sonardistance", LuaValue.Number 375.0
            LuaKey.String "speed", LuaValue.Number 60.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 270.0
            LuaKey.String "waterline", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmShips/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "weaponsub"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "-3.49415588379 -0.469155969238 -4.06915588379"
                            LuaKey.String "collisionvolumescales", LuaValue.String "48.6282958984 40.4258880615 146.154632568"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 5408.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 5.0
                            LuaKey.String "footprintz", LuaValue.Number 5.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 500.0
                            LuaKey.String "object", LuaValue.String "Units/armcrus_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 4032.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 250.0
                            LuaKey.String "object", LuaValue.String "Units/arm2X2A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-medium"
                            LuaKey.Int 2, LuaValue.String "custom:waterwake-medium"
                            LuaKey.Int 3, LuaValue.String "custom:bowsplash-medium"
                        ]
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
                            LuaKey.Int 1, LuaValue.String "sharmmov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "sharmsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "depthcharge", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 32.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.95
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-uw"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "cordepthcharge.s3o"
                            LuaKey.String "name", LuaValue.String "Medium depthcharge launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 450.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.8
                            LuaKey.String "soundhit", LuaValue.String "xplodep2"
                            LuaKey.String "soundstart", LuaValue.String "torpedo1"
                            LuaKey.String "startvelocity", LuaValue.Number 150.0
                            LuaKey.String "tolerance", LuaValue.Number 32767.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 9800.0
                            LuaKey.String "turret", LuaValue.Bool false
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 25.0
                            LuaKey.String "weapontimer", LuaValue.Number 10.0
                            LuaKey.String "weapontype", LuaValue.String "TorpedoLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 225.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 225.0
                                ]
                        ]
                    LuaKey.String "gauss", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "name", LuaValue.String "Long-range g2g gauss cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 500.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.666
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy1"
                            LuaKey.String "targetmoveerror", LuaValue.Number 0.1
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 550.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 220.0
                                    LuaKey.String "subs", LuaValue.Number 220.0
                                    LuaKey.String "vtol", LuaValue.Number 40.0
                                ]
                        ]
                    LuaKey.String "laser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 8.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.15
                            LuaKey.String "corethickness", LuaValue.Number 0.175
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 15.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small-red"
                            LuaKey.String "firestarter", LuaValue.Number 30.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 9.35
                            LuaKey.String "name", LuaValue.String "Light close-quarters g2g laser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 430.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.333
                            LuaKey.String "rgbcolor", LuaValue.String "1 0 0"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrfir3"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 2.5
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 800.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "norangering", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 75.0
                                    LuaKey.String "vtol", LuaValue.Number 8.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "GAUSS"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "LASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "DEPTHCHARGE"
                            LuaKey.String "onlytargetcategory", LuaValue.String "CANBEUW UNDERWATER"
                        ]
                ]
        ]

    let armdronecarry =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.01722
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "maxdec", LuaValue.Number 0.01722
            LuaKey.String "buildangle", LuaValue.Number 16384.0
            LuaKey.String "energycost", LuaValue.Number 17000.0
            LuaKey.String "metalcost", LuaValue.Number 1700.0
            LuaKey.String "buildpic", LuaValue.String "ARMDRONECARRY.DDS"
            LuaKey.String "buildtime", LuaValue.Number 24000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canreclaim", LuaValue.Bool false
            LuaKey.String "canrepair", LuaValue.Bool false
            LuaKey.String "canrestore", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "3 -7 -3"
            LuaKey.String "collisionvolumescales", LuaValue.String "48 48 140"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylZ"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energymake", LuaValue.Number 25.0
            LuaKey.String "energystorage", LuaValue.Number 1500.0
            LuaKey.String "energyupkeep", LuaValue.Number 25.0
            LuaKey.String "explodeas", LuaValue.String "hugeexplosiongeneric"
            LuaKey.String "floater", LuaValue.Bool true
            LuaKey.String "footprintx", LuaValue.Number 6.0
            LuaKey.String "footprintz", LuaValue.Number 6.0
            LuaKey.String "sightemitheight", LuaValue.Number 56.0
            LuaKey.String "mass", LuaValue.Number 10000.0
            LuaKey.String "health", LuaValue.Number 3500.0
            LuaKey.String "speed", LuaValue.Number 63.0
            LuaKey.String "minwaterdepth", LuaValue.Number 15.0
            LuaKey.String "movementclass", LuaValue.String "BOAT9"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/ARMDRONECARRY.s3o"
            LuaKey.String "radardistance", LuaValue.Number 1500.0
            LuaKey.String "radaremitheight", LuaValue.Number 56.0
            LuaKey.String "script", LuaValue.String "Units/ARMDRONECARRY.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "hugeexplosiongenericSelfD"
            LuaKey.String "sightdistance", LuaValue.Number 700.0
            LuaKey.String "sonardistance", LuaValue.Number 700.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 180.0
            LuaKey.String "waterline", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Odin"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmShips/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "inheritxpratemultiplier", LuaValue.Number 1.0
                    LuaKey.String "childreninheritxp", LuaValue.String "DRONE"
                    LuaKey.String "parentsinheritxp", LuaValue.String "DRONE"
                    LuaKey.String "restrictions_inclusion", LuaValue.String "_noair_"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "-0.0550308227539 1.52587890767e-06 4.55026245117"
                            LuaKey.String "collisionvolumescales", LuaValue.String "61.8225860596 60.9250030518 154.450805664"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 9168.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 700.0
                            LuaKey.String "object", LuaValue.String "Units/armdronecarry_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 4032.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 350.0
                            LuaKey.String "object", LuaValue.String "Units/arm6X6C.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:radarpulse_t1_slow"
                            LuaKey.Int 2, LuaValue.String "custom:waterwake-large"
                            LuaKey.Int 3, LuaValue.String "custom:bowsplash-huge"
                        ]
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
                            LuaKey.Int 1, LuaValue.String "sharmmov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "sharmsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "plasma", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 4.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String ""
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "hightrajectory", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "name", LuaValue.String "HeavyCannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "metalpershot", LuaValue.Number 25.0
                            LuaKey.String "energypershot", LuaValue.Number 600.0
                            LuaKey.String "range", LuaValue.Number 1300.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.5
                            LuaKey.String "size", LuaValue.Number 0.0
                            LuaKey.String "soundhit", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String ""
                            LuaKey.String "soundstart", LuaValue.String ""
                            LuaKey.String "stockpile", LuaValue.Bool true
                            LuaKey.String "stockpiletime", LuaValue.Number 4.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 800.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 0.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "carried_unit", LuaValue.String "armdrone"
                                    LuaKey.String "engagementrange", LuaValue.Number 1350.0
                                    LuaKey.String "spawns_surface", LuaValue.String "SEA"
                                    LuaKey.String "spawnrate", LuaValue.Number 4.0
                                    LuaKey.String "maxunits", LuaValue.Number 16.0
                                    LuaKey.String "startingdronecount", LuaValue.Number 8.0
                                    LuaKey.String "energycost", LuaValue.Number 600.0
                                    LuaKey.String "metalcost", LuaValue.Number 25.0
                                    LuaKey.String "controlradius", LuaValue.Number 1200.0
                                    LuaKey.String "decayrate", LuaValue.Number 6.0
                                    LuaKey.String "attackformationspread", LuaValue.Number 120.0
                                    LuaKey.String "attackformationoffset", LuaValue.Number 30.0
                                    LuaKey.String "carrierdeaththroe", LuaValue.String "release"
                                    LuaKey.String "dockingarmor", LuaValue.Number 0.2
                                    LuaKey.String "dockinghealrate", LuaValue.Number 24.0
                                    LuaKey.String "docktohealthreshold", LuaValue.Number 65.0
                                    LuaKey.String "enabledocking", LuaValue.Bool true
                                    LuaKey.String "dockingHelperSpeed", LuaValue.Number 5.0
                                    LuaKey.String "dockingpieces", LuaValue.String "11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27"
                                    LuaKey.String "dockingradius", LuaValue.Number 300.0
                                    LuaKey.String "stockpilelimit", LuaValue.Number 16.0
                                    LuaKey.String "stockpilemetal", LuaValue.Number 25.0
                                    LuaKey.String "stockpileenergy", LuaValue.Number 600.0
                                    LuaKey.String "dronesusestockpile", LuaValue.Bool true
                                    LuaKey.String "dronedocktime", LuaValue.Number 2.0
                                    LuaKey.String "droneairtime", LuaValue.Number 60.0
                                    LuaKey.String "droneammo", LuaValue.Number 9.0
                                ]
                        ]
                    LuaKey.String "aamissile", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 48.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "missiletrailaa"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-air"
                            LuaKey.String "firestarter", LuaValue.Number 70.0
                            LuaKey.String "flighttime", LuaValue.Number 1.75
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "cormissile.s3o"
                            LuaKey.String "name", LuaValue.String "Missiles"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 710.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 7.0
                            LuaKey.String "smoketime", LuaValue.Number 13.0
                            LuaKey.String "smokesize", LuaValue.Number 5.4
                            LuaKey.String "smokecolor", LuaValue.Number 0.95
                            LuaKey.String "smokeTrailCastShadow", LuaValue.Bool false
                            LuaKey.String "castshadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "rockhvy2"
                            LuaKey.String "startvelocity", LuaValue.Number 430.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailaa3"
                            LuaKey.String "tolerance", LuaValue.Number 8000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 30000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 90.0
                            LuaKey.String "weapontimer", LuaValue.Number 5.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 450.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "vtol", LuaValue.Number 138.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "PLASMA"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "AAMISSILE"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let armepoch =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildangle", LuaValue.Number 16384.0
            LuaKey.String "buildpic", LuaValue.String "ARMEPOCH.DDS"
            LuaKey.String "buildtime", LuaValue.Number 290000.0
            LuaKey.String "canattackground", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -6 3"
            LuaKey.String "collisionvolumescales", LuaValue.String "71 71 180"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylZ"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 190000.0
            LuaKey.String "explodeas", LuaValue.String "flagshipExplosion"
            LuaKey.String "floater", LuaValue.Bool true
            LuaKey.String "footprintx", LuaValue.Number 8.0
            LuaKey.String "footprintz", LuaValue.Number 8.0
            LuaKey.String "health", LuaValue.Number 50000.0
            LuaKey.String "mass", LuaValue.Number 9999999.0
            LuaKey.String "maxacc", LuaValue.Number 0.01104
            LuaKey.String "maxdec", LuaValue.Number 0.01104
            LuaKey.String "metalcost", LuaValue.Number 20000.0
            LuaKey.String "minwaterdepth", LuaValue.Number 15.0
            LuaKey.String "movementclass", LuaValue.String "BOAT9"
            LuaKey.String "movestate", LuaValue.Number 0.0
            LuaKey.String "objectname", LuaValue.String "Units/ARMEPOCH.s3o"
            LuaKey.String "radardistance", LuaValue.Number 1530.0
            LuaKey.String "radaremitheight", LuaValue.Number 52.0
            LuaKey.String "script", LuaValue.String "Units/ARMEPOCH.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "flagshipExplosionSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 689.0
            LuaKey.String "sightemitheight", LuaValue.Number 52.0
            LuaKey.String "speed", LuaValue.Number 53.85
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 135.0
            LuaKey.String "waterline", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.0
                    LuaKey.String "subfolder", LuaValue.String "ArmShips/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.439918518066 -4.07348632798e-05 0.367340087891"
                            LuaKey.String "collisionvolumescales", LuaValue.String "75.0081939697 51.5621185303 178.425750732"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 85500.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 18.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 8500.0
                            LuaKey.String "object", LuaValue.String "Units/armepoch_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 40032.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 4250.0
                            LuaKey.String "object", LuaValue.String "Units/arm6X6A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-large"
                            LuaKey.Int 2, LuaValue.String "custom:barrelshot-larger"
                            LuaKey.Int 3, LuaValue.String "custom:barrelshot-medium-aa"
                            LuaKey.Int 4, LuaValue.String "custom:waterwake-huge"
                            LuaKey.Int 5, LuaValue.String "custom:bowsplash-huge"
                            LuaKey.Int 6, LuaValue.String "custom:enginespurt-huge"
                        ]
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
                            LuaKey.Int 1, LuaValue.String "sharmmov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "sharmsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "ferret_missile", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "burst", LuaValue.Number 2.0
                            LuaKey.String "burstrate", LuaValue.Number 0.2
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "castshadow", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "missiletrailaa"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 0.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-tiny-aa"
                            LuaKey.String "firestarter", LuaValue.Number 72.0
                            LuaKey.String "flighttime", LuaValue.Number 2.5
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "cormissile.s3o"
                            LuaKey.String "name", LuaValue.String "Pop-up rapid-fire g2a missile launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 840.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.7
                            LuaKey.String "smokecolor", LuaValue.Number 0.95
                            LuaKey.String "smokeperiod", LuaValue.Number 6.0
                            LuaKey.String "smokesize", LuaValue.Number 4.6
                            LuaKey.String "smoketime", LuaValue.Number 12.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smoketrailcastshadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "packohit"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "packolau"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "startvelocity", LuaValue.Number 1.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailaa3"
                            LuaKey.String "tolerance", LuaValue.Number 9950.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 68000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 1200.0
                            LuaKey.String "weapontimer", LuaValue.Number 2.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1000.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "noattackrangearc", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 1.0
                                    LuaKey.String "vtol", LuaValue.Number 150.0
                                ]
                        ]
                    LuaKey.String "flak", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 1000.0
                            LuaKey.String "areaofeffect", LuaValue.Number 128.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "flaktrailaa"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 1.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large-air"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "name", LuaValue.String "Heavy g2a flak cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 775.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.53333
                            LuaKey.String "size", LuaValue.Number 4.5
                            LuaKey.String "sizedecay", LuaValue.Number 0.08
                            LuaKey.String "soundhit", LuaValue.String "flakhit"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "flakfire"
                            LuaKey.String "stages", LuaValue.Number 8.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 1.0
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1550.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "noattackrangearc", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "vtol", LuaValue.Number 250.0
                                ]
                            LuaKey.String "rgbcolor", LuaValue.Table [
                                    LuaKey.Int 1, LuaValue.Number 1.0
                                    LuaKey.Int 2, LuaValue.Number 0.33
                                    LuaKey.Int 3, LuaValue.Number 0.7
                                ]
                        ]
                    LuaKey.String "heavyplasma", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 600.0
                            LuaKey.String "areaofeffect", LuaValue.Number 160.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 2.0
                            LuaKey.String "burstrate", LuaValue.Number 0.8
                            LuaKey.String "cegtag", LuaValue.String "arty-heavy"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large-aoe"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 1.0
                            LuaKey.String "name", LuaValue.String "Primary rapid-fire heavy long-range plasma cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 2450.0
                            LuaKey.String "reloadtime", LuaValue.Number 3.5
                            LuaKey.String "soundhit", LuaValue.String "bertha6"
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundstart", LuaValue.String "BERTHA1"
                            LuaKey.String "sprayangle", LuaValue.Number 650.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 600.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "noattackrangearc", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 500.0
                                    LuaKey.String "subs", LuaValue.Number 100.0
                                    LuaKey.String "vtol", LuaValue.Number 200.0
                                ]
                        ]
                    LuaKey.String "mediumplasma", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 350.0
                            LuaKey.String "areaofeffect", LuaValue.Number 128.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "arty-fast"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "name", LuaValue.String "Secondary rapid-fire heavy plasma cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 830.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.2
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy1"
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 570.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "noattackrangearc", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 270.0
                                    LuaKey.String "vtol", LuaValue.Number 65.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "HEAVYPLASMA"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "MEDIUMPLASMA"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 320.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "HEAVYPLASMA"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 240.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "MEDIUMPLASMA"
                            LuaKey.String "maindir", LuaValue.String "-4 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 180.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "MEDIUMPLASMA"
                            LuaKey.String "maindir", LuaValue.String "4 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 180.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 6, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "FERRET_MISSILE"
                            LuaKey.String "maindir", LuaValue.String "0 -1 -2"
                            LuaKey.String "maxangledif", LuaValue.Number 270.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL T4AIR"
                        ]
                    LuaKey.Int 7, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "FERRET_MISSILE"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL T4AIR"
                        ]
                ]
        ]

    let armexcalibur =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool false
            LuaKey.String "buildcostenergy", LuaValue.Number 16000.0
            LuaKey.String "buildcostmetal", LuaValue.Number 900.0
            LuaKey.String "buildpic", LuaValue.String "armexcalibur.DDS"
            LuaKey.String "buildtime", LuaValue.Number 18000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collide", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 1 -4"
            LuaKey.String "collisionvolumescales", LuaValue.String "20 15 52"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "mediumExplosionGeneric-uw"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 1200.0
            LuaKey.String "maxacc", LuaValue.Number 0.03
            LuaKey.String "maxdec", LuaValue.Number 0.05
            LuaKey.String "minwaterdepth", LuaValue.Number 15.0
            LuaKey.String "movementclass", LuaValue.String "BOAT3"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/armexcalibur.s3o"
            LuaKey.String "script", LuaValue.String "Units/armexcalibur.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumExplosionGenericSelfd-uw"
            LuaKey.String "sightdistance", LuaValue.Number 500.0
            LuaKey.String "sonardistance", LuaValue.Number 200.0
            LuaKey.String "speed", LuaValue.Number 60.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 540.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "waterline", LuaValue.Number 25.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Hornet"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmShips/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "sub"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 -4"
                            LuaKey.String "collisionvolumescales", LuaValue.String "20 15 52"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1362.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 375.0
                            LuaKey.String "object", LuaValue.String "Units/armexcalibur_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 4032.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 187.0
                            LuaKey.String "object", LuaValue.String "Units/cor2X2A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 0, LuaValue.String "custom:subbubbles"
                            LuaKey.Int 1, LuaValue.String "custom:subwake"
                            LuaKey.Int 2, LuaValue.String "custom:tachyonshot"
                        ]
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
                            LuaKey.Int 1, LuaValue.String "sucormov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "sucorsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "exata", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 1.0
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "corethickness", LuaValue.Number 0.15
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 400.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-large-blue"
                            LuaKey.String "firestarter", LuaValue.Number 45.0
                            LuaKey.String "firetolerance", LuaValue.Number 1000.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "largebeamlaser", LuaValue.Bool true
                            LuaKey.String "laserflaresize", LuaValue.Number 3.5
                            LuaKey.String "name", LuaValue.String "Caliburn s2g tachyon accelerator beam"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 600.0
                            LuaKey.String "reloadtime", LuaValue.Number 6.0
                            LuaKey.String "rgbcolor", LuaValue.String "0 0 1"
                            LuaKey.String "scrollspeed", LuaValue.Number 5.0
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "annigun1"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "texture3", LuaValue.String "largebeam"
                            LuaKey.String "thickness", LuaValue.Number 1.5
                            LuaKey.String "tilelength", LuaValue.Number 150.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1400.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 400.0
                                    LuaKey.String "default", LuaValue.Number 800.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "UNDERWATER"
                            LuaKey.String "def", LuaValue.String "EXATA"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let armhacs =
        LuaValue.Table [
            LuaKey.String "builddistance", LuaValue.Number 250.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMMLS.DDS"
            LuaKey.String "buildtime", LuaValue.Number 60000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -7 2"
            LuaKey.String "collisionvolumescales", LuaValue.String "25 25 70"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 25600.0
            LuaKey.String "explodeas", LuaValue.String "mediumexplosiongeneric"
            LuaKey.String "floater", LuaValue.Bool true
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 2460.0
            LuaKey.String "mass", LuaValue.Number 2700.0
            LuaKey.String "maxacc", LuaValue.Number 0.04059
            LuaKey.String "maxdec", LuaValue.Number 0.04059
            LuaKey.String "metalcost", LuaValue.Number 1140.0
            LuaKey.String "minwaterdepth", LuaValue.Number 15.0
            LuaKey.String "movementclass", LuaValue.String "BOAT4"
            LuaKey.String "movestate", LuaValue.Number 0.0
            LuaKey.String "objectname", LuaValue.String "Units/ARMMLS.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMMLS.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumexplosiongenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 300.0
            LuaKey.String "speed", LuaValue.Number 66.0
            LuaKey.String "terraformspeed", LuaValue.Number 2000.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 405.0
            LuaKey.String "waterline", LuaValue.Number 2.0
            LuaKey.String "workertime", LuaValue.Number 600.0
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "armuwfus"
                    LuaKey.Int 2, LuaValue.String "armuwmmm"
                    LuaKey.Int 3, LuaValue.String "armuwmme"
                    LuaKey.Int 4, LuaValue.String "armuwadves"
                    LuaKey.Int 5, LuaValue.String "armuwadvms"
                    LuaKey.Int 6, LuaValue.String "armasy"
                    LuaKey.Int 7, LuaValue.String "armhasy"
                    LuaKey.Int 8, LuaValue.String "armfatf"
                    LuaKey.Int 9, LuaValue.String "armatl"
                    LuaKey.Int 10, LuaValue.String "armfflak"
                    LuaKey.Int 11, LuaValue.String "armkraken"
                    LuaKey.Int 12, LuaValue.String "armuwageo"
                    LuaKey.Int 13, LuaValue.String "armbanth"
                    LuaKey.Int 14, LuaValue.String "armafus"
                    LuaKey.Int 15, LuaValue.String "armtide"
                    LuaKey.Int 20, LuaValue.String "armanni"
                    LuaKey.Int 21, LuaValue.String "armpb"
                    LuaKey.Int 22, LuaValue.String "armmercury"
                    LuaKey.Int 23, LuaValue.String "armfdrag"
                    LuaKey.Int 24, LuaValue.String "armgate"
                    LuaKey.Int 25, LuaValue.String "armsd"
                    LuaKey.Int 26, LuaValue.String "armlab"
                    LuaKey.Int 27, LuaValue.String "armvp"
                    LuaKey.Int 28, LuaValue.String "armap"
                    LuaKey.Int 29, LuaValue.String "armsy"
                    LuaKey.Int 31, LuaValue.String "armbrtha"
                    LuaKey.Int 32, LuaValue.String "armsilo"
                    LuaKey.Int 33, LuaValue.String "armvulc"
                    LuaKey.Int 34, LuaValue.String "armshltxuw"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "minesweeper", LuaValue.Number 600.0
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmShips/T2"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                    LuaKey.String "unitgroup", LuaValue.String "buildert2"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.0 -1.85327148436e-05 2.73946380615"
                            LuaKey.String "collisionvolumescales", LuaValue.String "37.140838623 18.7893829346 66.6114349365"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1576.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 95.0
                            LuaKey.String "object", LuaValue.String "Units/armmls_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "85.0 14.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 4032.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 47.5
                            LuaKey.String "object", LuaValue.String "Units/arm4X4A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:waterwake-small"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "nanlath1"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "repair", LuaValue.String "repair1"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "working", LuaValue.String "reclaim1"
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
                            LuaKey.Int 1, LuaValue.String "sharmmov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "sharmsel"
                        ]
                ]
        ]

    let armlship =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "blocking", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMLSHIP.DDS"
            LuaKey.String "buildtime", LuaValue.Number 15000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 4"
            LuaKey.String "collisionvolumescales", LuaValue.String "28 30 82"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 11400.0
            LuaKey.String "explodeas", LuaValue.String "mediumExplosionGeneric"
            LuaKey.String "floater", LuaValue.Bool true
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 2200.0
            LuaKey.String "maxacc", LuaValue.Number 0.065
            LuaKey.String "maxdec", LuaValue.Number 0.065
            LuaKey.String "metalcost", LuaValue.Number 570.0
            LuaKey.String "minwaterdepth", LuaValue.Number 6.0
            LuaKey.String "movementclass", LuaValue.String "BOAT4"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL UNDERWATER"
            LuaKey.String "objectname", LuaValue.String "Units/ARMLSHIP.s3o"
            LuaKey.String "radardistance", LuaValue.Number 750.0
            LuaKey.String "radaremitheight", LuaValue.Number 52.0
            LuaKey.String "script", LuaValue.String "Units/ARMLSHIP.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 500.0
            LuaKey.String "speed", LuaValue.Number 99.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 450.0
            LuaKey.String "waterline", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "mightyodin01"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmShips/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.255500793457 0.0 -1.26264953613"
                            LuaKey.String "collisionvolumescales", LuaValue.String "20.0704803467 16.0 67.0992736816"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 500.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 390.0
                            LuaKey.String "object", LuaValue.String "Units/armlship_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 1032.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 195.0
                            LuaKey.String "object", LuaValue.String "Units/arm3X3A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:waterwake-medium"
                            LuaKey.Int 2, LuaValue.String "custom:bowsplash-small"
                            LuaKey.Int 3, LuaValue.String "custom:barrelshot-lightning"
                        ]
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
                            LuaKey.Int 1, LuaValue.String "sharmmov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "sharmsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "armamph_missile", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 48.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "castshadow", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "missiletrailaa"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-tiny-aa"
                            LuaKey.String "firestarter", LuaValue.Number 70.0
                            LuaKey.String "flighttime", LuaValue.Number 1.75
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "cormissile.s3o"
                            LuaKey.String "name", LuaValue.String "Light g2a missile launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 710.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.0
                            LuaKey.String "smokecolor", LuaValue.Number 0.95
                            LuaKey.String "smokeperiod", LuaValue.Number 5.0
                            LuaKey.String "smokesize", LuaValue.Number 4.4
                            LuaKey.String "smoketime", LuaValue.Number 12.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smoketrailcastshadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "rockhvy2"
                            LuaKey.String "startvelocity", LuaValue.Number 430.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailaa3"
                            LuaKey.String "tolerance", LuaValue.Number 9000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 48000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 90.0
                            LuaKey.String "weapontimer", LuaValue.Number 5.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 850.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "vtol", LuaValue.Number 138.0
                                ]
                        ]
                    LuaKey.String "lightning", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 8.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamttl", LuaValue.Number 1.0
                            LuaKey.String "burst", LuaValue.Number 10.0
                            LuaKey.String "burstrate", LuaValue.Number 0.03333
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 10.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-lightning2"
                            LuaKey.String "firestarter", LuaValue.Number 50.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 24.0
                            LuaKey.String "laserflaresize", LuaValue.Number 5.0
                            LuaKey.String "name", LuaValue.String "Close-quarters lightning turret"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 400.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.4
                            LuaKey.String "rgbcolor", LuaValue.String "0.5 0.5 1"
                            LuaKey.String "soundhit", LuaValue.String "lashit"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lghthvy1"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "thickness", LuaValue.Number 2.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LightningCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 400.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "noattackrangearc", LuaValue.Number 1.0
                                    LuaKey.String "spark_ceg", LuaValue.String "genericshellexplosion-splash-lightning"
                                    LuaKey.String "spark_forkdamage", LuaValue.String "0.5"
                                    LuaKey.String "spark_maxunits", LuaValue.String "2"
                                    LuaKey.String "spark_range", LuaValue.String "100"
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 35.0
                                    LuaKey.String "subs", LuaValue.Number 10.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "LIGHTNING"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 330.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "ARMAMPH_MISSILE"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let armmls =
        LuaValue.Table [
            LuaKey.String "builddistance", LuaValue.Number 250.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMMLS.DDS"
            LuaKey.String "buildtime", LuaValue.Number 6000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -7 2"
            LuaKey.String "collisionvolumescales", LuaValue.String "25 25 70"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 3200.0
            LuaKey.String "explodeas", LuaValue.String "mediumexplosiongeneric"
            LuaKey.String "floater", LuaValue.Bool true
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 1460.0
            LuaKey.String "maxacc", LuaValue.Number 0.04059
            LuaKey.String "maxdec", LuaValue.Number 0.04059
            LuaKey.String "metalcost", LuaValue.Number 190.0
            LuaKey.String "minwaterdepth", LuaValue.Number 15.0
            LuaKey.String "movementclass", LuaValue.String "BOAT4"
            LuaKey.String "movestate", LuaValue.Number 0.0
            LuaKey.String "objectname", LuaValue.String "Units/ARMMLS.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMMLS.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumexplosiongenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 300.0
            LuaKey.String "speed", LuaValue.Number 66.0
            LuaKey.String "terraformspeed", LuaValue.Number 2000.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 405.0
            LuaKey.String "waterline", LuaValue.Number 2.0
            LuaKey.String "workertime", LuaValue.Number 200.0
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "armtide"
                    LuaKey.Int 2, LuaValue.String "armmex"
                    LuaKey.Int 3, LuaValue.String "armfrad"
                    LuaKey.Int 4, LuaValue.String "armarad"
                    LuaKey.Int 5, LuaValue.String "armnanotcplat"
                    LuaKey.Int 6, LuaValue.String "armsy"
                    LuaKey.Int 7, LuaValue.String "armcs"
                    LuaKey.Int 8, LuaValue.String "armtl"
                    LuaKey.Int 9, LuaValue.String "armfhlt"
                    LuaKey.Int 10, LuaValue.String "armfflak"
                    LuaKey.Int 11, LuaValue.String "armpt"
                    LuaKey.Int 12, LuaValue.String "armdecade"
                    LuaKey.Int 13, LuaValue.String "armroy"
                    LuaKey.Int 14, LuaValue.String "armamph"
                    LuaKey.Int 15, LuaValue.String "armfmine3"
                    LuaKey.Int 16, LuaValue.String "armamb"
                    LuaKey.Int 17, LuaValue.String "armkraken"
                    LuaKey.Int 18, LuaValue.String "armfdrag"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "minesweeper", LuaValue.Number 600.0
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmShips/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "buildert2"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.0 -1.85327148436e-05 2.73946380615"
                            LuaKey.String "collisionvolumescales", LuaValue.String "37.140838623 18.7893829346 66.6114349365"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1576.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 95.0
                            LuaKey.String "object", LuaValue.String "Units/armmls_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "85.0 14.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 4032.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 47.5
                            LuaKey.String "object", LuaValue.String "Units/arm4X4A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:waterwake-small"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "nanlath1"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "repair", LuaValue.String "repair1"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "working", LuaValue.String "reclaim1"
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
                            LuaKey.Int 1, LuaValue.String "sharmmov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "sharmsel"
                        ]
                ]
        ]

    let armmship =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMMSHIP.DDS"
            LuaKey.String "buildtime", LuaValue.Number 24000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -5 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "44 44 80"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylZ"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 10000.0
            LuaKey.String "explodeas", LuaValue.String "largeExplosionGeneric"
            LuaKey.String "floater", LuaValue.Bool true
            LuaKey.String "footprintx", LuaValue.Number 5.0
            LuaKey.String "footprintz", LuaValue.Number 5.0
            LuaKey.String "health", LuaValue.Number 3350.0
            LuaKey.String "maxacc", LuaValue.Number 0.0287
            LuaKey.String "maxdec", LuaValue.Number 0.0387
            LuaKey.String "metalcost", LuaValue.Number 2000.0
            LuaKey.String "minwaterdepth", LuaValue.Number 12.0
            LuaKey.String "movementclass", LuaValue.String "BOAT5"
            LuaKey.String "movestate", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/ARMMSHIP.s3o"
            LuaKey.String "radardistance", LuaValue.Number 1000.0
            LuaKey.String "script", LuaValue.String "Units/ARMMSHIP.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 318.5
            LuaKey.String "speed", LuaValue.Number 63.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 350.0
            LuaKey.String "waterline", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "maxrange", LuaValue.String "1650"
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmShips/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "-1.52864837646 2.44506835934e-05 -1.26249694824"
                            LuaKey.String "collisionvolumescales", LuaValue.String "46.7322845459 37.6582489014 110.324981689"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 2640.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 5.0
                            LuaKey.String "footprintz", LuaValue.Number 5.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 1000.0
                            LuaKey.String "object", LuaValue.String "Units/armmship_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "85.0 14.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 4032.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 500.0
                            LuaKey.String "object", LuaValue.String "Units/arm4X4B.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:waterwake-medium"
                            LuaKey.Int 2, LuaValue.String "custom:bowsplash-medium"
                        ]
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
                            LuaKey.Int 1, LuaValue.String "sharmmov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "sharmsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "missile", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 48.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "castshadow", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "missiletrailaa"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-air"
                            LuaKey.String "firestarter", LuaValue.Number 70.0
                            LuaKey.String "flighttime", LuaValue.Number 1.75
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "cormissile.s3o"
                            LuaKey.String "name", LuaValue.String "Medium Range g2a AA Missiles"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 710.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.0
                            LuaKey.String "smokecolor", LuaValue.Number 0.95
                            LuaKey.String "smokeperiod", LuaValue.Number 7.0
                            LuaKey.String "smokesize", LuaValue.Number 5.4
                            LuaKey.String "smoketime", LuaValue.Number 13.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smoketrailcastshadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "rockhvy2"
                            LuaKey.String "startvelocity", LuaValue.Number 430.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailaa3"
                            LuaKey.String "tolerance", LuaValue.Number 8000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 30000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 90.0
                            LuaKey.String "weapontimer", LuaValue.Number 5.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 450.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "vtol", LuaValue.Number 138.0
                                ]
                        ]
                    LuaKey.String "rocket", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 300.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "missiletrailmship"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 300.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.65
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large-bomb"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "flighttime", LuaValue.Number 15.0
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "hightrajectory", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 1.4
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 1024.0
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "corshiprocket.s3o"
                            LuaKey.String "name", LuaValue.String "Heavy long-range g2g starburst rocket launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1550.0
                            LuaKey.String "reloadtime", LuaValue.Number 6.0
                            LuaKey.String "smoketrail", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "xplomed4"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "Rockhvy1"
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailbar"
                            LuaKey.String "texture3", LuaValue.String "null"
                            LuaKey.String "tolerance", LuaValue.Number 4000.0
                            LuaKey.String "turnrate", LuaValue.Number 24384.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 80.0
                            LuaKey.String "weapontimer", LuaValue.Number 5.0
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 450.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "cegtag", LuaValue.String "missiletrailcorroyspecial"
                                    LuaKey.String "model", LuaValue.String "airbomb"
                                    LuaKey.String "noattackrangearc", LuaValue.Number 1.0
                                    LuaKey.String "number", LuaValue.String "6"
                                    LuaKey.String "speceffect", LuaValue.String "split"
                                    LuaKey.String "speceffect_def", LuaValue.String "armmship_rocket_split"
                                    LuaKey.String "splitexplosionceg", LuaValue.String "genericshellexplosion-medium"
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 350.0
                                    LuaKey.String "default", LuaValue.Number 650.0
                                    LuaKey.String "subs", LuaValue.Number 5.0
                                ]
                        ]
                    LuaKey.String "rocket_split", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 75.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "burst", LuaValue.Number 6.0
                            LuaKey.String "burstrate", LuaValue.Number 0.1
                            LuaKey.String "cegtag", LuaValue.String "missiletrailcorroyspecial"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 75.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.65
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-bomb"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "flighttime", LuaValue.Number 15.0
                            LuaKey.String "hightrajectory", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 8.0
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "airbomb.s3o"
                            LuaKey.String "name", LuaValue.String "Heavy long-range g2g ballistic missile launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1550.0
                            LuaKey.String "reloadtime", LuaValue.Number 6.0
                            LuaKey.String "smoketrail", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "xplomed4"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "Rockhvy1"
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "null"
                            LuaKey.String "texture3", LuaValue.String "null"
                            LuaKey.String "tolerance", LuaValue.Number 4000.0
                            LuaKey.String "turnrate", LuaValue.Number 24384.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 80.0
                            LuaKey.String "weapontimer", LuaValue.Number 5.0
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 400.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 223.0
                                    LuaKey.String "default", LuaValue.Number 350.0
                                    LuaKey.String "subs", LuaValue.Number 5.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "MOBILE"
                            LuaKey.String "def", LuaValue.String "ROCKET"
                            LuaKey.String "maindir", LuaValue.String "0 .5 1"
                            LuaKey.String "maxangledif", LuaValue.Number 60.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "MISSILE"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let armsacsub =
        LuaValue.Table [
            LuaKey.String "builddistance", LuaValue.Number 180.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMACSUB.DDS"
            LuaKey.String "buildtime", LuaValue.Number 22000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 -1"
            LuaKey.String "collisionvolumescales", LuaValue.String "38 38 63"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylZ"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 9000.0
            LuaKey.String "energymake", LuaValue.Number 30.0
            LuaKey.String "energystorage", LuaValue.Number 150.0
            LuaKey.String "explodeas", LuaValue.String "smallExplosionGeneric-uw"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 1110.0
            LuaKey.String "maxacc", LuaValue.Number 0.04428
            LuaKey.String "maxdec", LuaValue.Number 0.04428
            LuaKey.String "metalcost", LuaValue.Number 500.0
            LuaKey.String "minwaterdepth", LuaValue.Number 20.0
            LuaKey.String "movementclass", LuaValue.String "UBOAT4"
            LuaKey.String "objectname", LuaValue.String "Units/ARMACSUB.s3o"
            LuaKey.String "radardistance", LuaValue.Number 50.0
            LuaKey.String "script", LuaValue.String "Units/ARMACSUB.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "smallExplosionGenericSelfd-uw"
            LuaKey.String "sightdistance", LuaValue.Number 156.0
            LuaKey.String "speed", LuaValue.Number 72.0
            LuaKey.String "terraformspeed", LuaValue.Number 1500.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 405.0
            LuaKey.String "waterline", LuaValue.Number 80.0
            LuaKey.String "workertime", LuaValue.Number 300.0
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "armuwmmm"
                    LuaKey.Int 2, LuaValue.String "armshltxuw"
                    LuaKey.Int 3, LuaValue.String "armatl"
                    LuaKey.Int 4, LuaValue.String "armasy"
                    LuaKey.Int 5, LuaValue.String "armsy"
                    LuaKey.Int 6, LuaValue.String "armuwageo"
                    LuaKey.Int 7, LuaValue.String "armsasy"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmShips/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "buildert2"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.0 2.5122070312e-05 0.236854553223"
                            LuaKey.String "collisionvolumescales", LuaValue.String "49.0049743652 25.7252502441 71.2612762451"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 432.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 350.0
                            LuaKey.String "object", LuaValue.String "Units/armacsub_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 4032.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 175.0
                            LuaKey.String "object", LuaValue.String "Units/arm2X2A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "nanlath1"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "capture", LuaValue.String "capture1"
                    LuaKey.String "repair", LuaValue.String "repair1"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "working", LuaValue.String "reclaim1"
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
                            LuaKey.Int 1, LuaValue.String "suarmmov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "suarmsel"
                        ]
                ]
        ]

    let armseadragon =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildangle", LuaValue.Number 8192.0
            LuaKey.String "buildpic", LuaValue.String "armseadragon.DDS"
            LuaKey.String "buildtime", LuaValue.Number 190000.0
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -3 -5"
            LuaKey.String "collisionvolumescales", LuaValue.String "32 29 110"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 85000.0
            LuaKey.String "explodeas", LuaValue.String "nukeSub"
            LuaKey.String "firestate", LuaValue.Number 2.0
            LuaKey.String "footprintx", LuaValue.Number 7.0
            LuaKey.String "footprintz", LuaValue.Number 7.0
            LuaKey.String "health", LuaValue.Number 2400.0
            LuaKey.String "maxacc", LuaValue.Number 0.03
            LuaKey.String "maxdec", LuaValue.Number 0.05
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 9999.0
            LuaKey.String "metalcost", LuaValue.Number 8000.0
            LuaKey.String "minwaterdepth", LuaValue.Number 20.0
            LuaKey.String "movementclass", LuaValue.String "UBOAT4"
            LuaKey.String "objectname", LuaValue.String "Units/armseadragon.s3o"
            LuaKey.String "radardistance", LuaValue.Number 50.0
            LuaKey.String "script", LuaValue.String "Units/armseadragon.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "nukeBuildingSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 400.0
            LuaKey.String "sonardistance", LuaValue.Number 1000.0
            LuaKey.String "speed", LuaValue.Number 48.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 340.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "waterline", LuaValue.Number 40.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "maxrange", LuaValue.String "720"
                    LuaKey.String "model_author", LuaValue.String "Hornet"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/arm_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "ArmShips/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "nuke"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -3 -5"
                            LuaKey.String "collisionvolumescales", LuaValue.String "34 31 110"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1362.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 375.0
                            LuaKey.String "object", LuaValue.String "Units/armseadragon_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 4032.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 187.0
                            LuaKey.String "object", LuaValue.String "Units/cor2X2A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 0, LuaValue.String "custom:subbubbles"
                            LuaKey.Int 1, LuaValue.String "custom:subwake"
                        ]
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
                            LuaKey.Int 1, LuaValue.String "servroc1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "servroc1"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "nuclear_launch", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "commandfire", LuaValue.Bool true
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "name", LuaValue.String "Nuclear Launch"
                            LuaKey.String "range", LuaValue.Number 0.0
                            LuaKey.String "reloadtime", LuaValue.Number 30.0
                            LuaKey.String "soundhit", LuaValue.String "nukelaunchalarm"
                            LuaKey.String "soundhitvolume", LuaValue.Number 50.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turnrate", LuaValue.Number 10000.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 101.0
                            LuaKey.String "weapontimer", LuaValue.Number 0.1
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 100.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "scavforcecommandfire", LuaValue.Bool true
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 0.0
                                ]
                        ]
                    LuaKey.String "sdmssl", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 1280.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "NUKETRAIL"
                            LuaKey.String "collideenemy", LuaValue.Bool false
                            LuaKey.String "collidefeature", LuaValue.Bool false
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "commandfire", LuaValue.Bool true
                            LuaKey.String "craterareaofeffect", LuaValue.Number 1280.0
                            LuaKey.String "craterboost", LuaValue.Number 2.4
                            LuaKey.String "cratermult", LuaValue.Number 1.2
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.45
                            LuaKey.String "energypershot", LuaValue.Number 125000.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:newnuke"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "flighttime", LuaValue.Number 400.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "metalpershot", LuaValue.Number 1000.0
                            LuaKey.String "model", LuaValue.String "cortronmissile.s3o"
                            LuaKey.String "name", LuaValue.String "Intercontinental ballistic nuclear warhead"
                            LuaKey.String "range", LuaValue.Number 72000.0
                            LuaKey.String "reloadtime", LuaValue.Number 30.0
                            LuaKey.String "smokecolor", LuaValue.Number 0.85
                            LuaKey.String "smokeperiod", LuaValue.Number 10.0
                            LuaKey.String "smokesize", LuaValue.Number 28.0
                            LuaKey.String "smoketime", LuaValue.Number 130.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smoketrailcastshadow", LuaValue.Bool true
                            LuaKey.String "soundhit", LuaValue.String "nukearm"
                            LuaKey.String "soundhitwet", LuaValue.String "nukewater"
                            LuaKey.String "soundhitwetvolume", LuaValue.Number 53.0
                            LuaKey.String "soundstart", LuaValue.String "nukelaunch"
                            LuaKey.String "soundstartvolume", LuaValue.Number 20.0
                            LuaKey.String "stockpile", LuaValue.Bool true
                            LuaKey.String "stockpiletime", LuaValue.Number 140.0
                            LuaKey.String "targetable", LuaValue.Number 1.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "railguntrail"
                            LuaKey.String "texture3", LuaValue.String "null"
                            LuaKey.String "tolerance", LuaValue.Number 4000.0
                            LuaKey.String "turnrate", LuaValue.Number 5500.0
                            LuaKey.String "waterweapon", LuaValue.Number 1.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 100.0
                            LuaKey.String "weapontimer", LuaValue.Number 5.5
                            LuaKey.String "weapontype", LuaValue.String "StarburstLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1600.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "place_target_on_ground", LuaValue.String "true"
                                    LuaKey.String "scavforcecommandfire", LuaValue.Bool true
                                    LuaKey.String "stockpilelimit", LuaValue.Number 10.0
                                    LuaKey.String "nuclear", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 2500.0
                                    LuaKey.String "default", LuaValue.Number 9500.0
                                ]
                        ]
                    LuaKey.String "waterballon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 12.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "torpedotrail-small"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-uw"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "torpedo.s3o"
                            LuaKey.String "name", LuaValue.String "Torpedo launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 720.0
                            LuaKey.String "reloadtime", LuaValue.Number 8.0
                            LuaKey.String "soundhit", LuaValue.String "xplodep1"
                            LuaKey.String "soundhitvolume", LuaValue.Number 22.0
                            LuaKey.String "soundstart", LuaValue.String "torpedo1"
                            LuaKey.String "startvelocity", LuaValue.Number 150.0
                            LuaKey.String "tolerance", LuaValue.Number 8000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 2250.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 20.0
                            LuaKey.String "weapontimer", LuaValue.Number 3.0
                            LuaKey.String "weapontype", LuaValue.String "TorpedoLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 290.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 340.0
                                    LuaKey.String "default", LuaValue.Number 800.0
                                    LuaKey.String "subs", LuaValue.Number 500.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "HOVER NOTSHIP"
                            LuaKey.String "def", LuaValue.String "waterballon"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 35.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTHOVER"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "SDMSSL"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "NUCLEAR_LAUNCH"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let armserp =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMSERP.DDS"
            LuaKey.String "buildtime", LuaValue.Number 32000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "52 30 57"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 27000.0
            LuaKey.String "explodeas", LuaValue.String "mediumExplosionGeneric-uw"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 3550.0
            LuaKey.String "maxacc", LuaValue.Number 0.02
            LuaKey.String "maxdec", LuaValue.Number 0.02
            LuaKey.String "metalcost", LuaValue.Number 1800.0
            LuaKey.String "minwaterdepth", LuaValue.Number 20.0
            LuaKey.String "movementclass", LuaValue.String "UBOAT4"
            LuaKey.String "movestate", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/ARMSERP.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMSERP.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumExplosionGenericSelfd-uw"
            LuaKey.String "sightdistance", LuaValue.Number 550.0
            LuaKey.String "sonardistance", LuaValue.Number 400.0
            LuaKey.String "speed", LuaValue.Number 45.0
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 400.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "waterline", LuaValue.Number 80.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmShips/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "sub"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "6.17767333984 -3.80371093733e-06 -10.6119995117"
                            LuaKey.String "collisionvolumescales", LuaValue.String "42.614654541 20.1074523926 56.7760009766"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 2000.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 10.0
                            LuaKey.String "metal", LuaValue.Number 1000.0
                            LuaKey.String "object", LuaValue.String "Units/armserp_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 4000.0
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 505.0
                            LuaKey.String "object", LuaValue.String "Units/arm3X3F.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 0, LuaValue.String "custom:subbubbles"
                            LuaKey.Int 1, LuaValue.String "custom:subwake"
                            LuaKey.Int 2, LuaValue.String "custom:subtorpfire-medium"
                        ]
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
                            LuaKey.Int 1, LuaValue.String "suarmmov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "suarmsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "armserp_weapon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 120.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "torpedotrail-large"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large-uw"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "torpedo.s3o"
                            LuaKey.String "name", LuaValue.String "Heavy guided torpedo launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 800.0
                            LuaKey.String "reloadtime", LuaValue.Number 8.0
                            LuaKey.String "soundhit", LuaValue.String "xplodep1"
                            LuaKey.String "soundhitvolume", LuaValue.Number 14.0
                            LuaKey.String "soundstart", LuaValue.String "torpedo1"
                            LuaKey.String "startvelocity", LuaValue.Number 150.0
                            LuaKey.String "tolerance", LuaValue.Number 8000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 1750.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 25.0
                            LuaKey.String "weapontimer", LuaValue.Number 3.0
                            LuaKey.String "weapontype", LuaValue.String "TorpedoLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 220.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 375.0
                                    LuaKey.String "default", LuaValue.Number 825.0
                                    LuaKey.String "subs", LuaValue.Number 555.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "HOVER NOTSHIP"
                            LuaKey.String "def", LuaValue.String "ARMSERP_WEAPON"
                            LuaKey.String "maindir", LuaValue.String "0 0.2 1"
                            LuaKey.String "maxangledif", LuaValue.Number 80.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTHOVER"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "HOVER NOTSHIP"
                            LuaKey.String "def", LuaValue.String "ARMSERP_WEAPON"
                            LuaKey.String "maindir", LuaValue.String "0 0.2 1"
                            LuaKey.String "maxangledif", LuaValue.Number 80.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTHOVER"
                            LuaKey.String "slaveto", LuaValue.Number 1.0
                        ]
                ]
        ]

    let armsjam =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMSJAM.DDS"
            LuaKey.String "buildtime", LuaValue.Number 20000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "28 32 64"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 5000.0
            LuaKey.String "energyupkeep", LuaValue.Number 90.0
            LuaKey.String "explodeas", LuaValue.String "mediumexplosiongeneric"
            LuaKey.String "floater", LuaValue.Bool true
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 1350.0
            LuaKey.String "maxacc", LuaValue.Number 0.04059
            LuaKey.String "maxdec", LuaValue.Number 0.04059
            LuaKey.String "metalcost", LuaValue.Number 310.0
            LuaKey.String "minwaterdepth", LuaValue.Number 6.0
            LuaKey.String "movementclass", LuaValue.String "BOAT3"
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Units/ARMSJAM.s3o"
            LuaKey.String "onoffable", LuaValue.Bool true
            LuaKey.String "radardistancejam", LuaValue.Number 980.0
            LuaKey.String "script", LuaValue.String "Units/ARMSJAM.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumexplosiongenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 390.0
            LuaKey.String "speed", LuaValue.Number 45.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 405.0
            LuaKey.String "waterline", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "off_on_stun", LuaValue.String "true"
                    LuaKey.String "subfolder", LuaValue.String "ArmShips/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "util"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "-0.304229736328 -7.05566407078e-07 -0.0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "28.1084594727 19.4736785889 64.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 612.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 40.0
                            LuaKey.String "metal", LuaValue.Number 55.0
                            LuaKey.String "object", LuaValue.String "Units/armsjam_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "85.0 14.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 4032.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 27.5
                            LuaKey.String "object", LuaValue.String "Units/arm4X4A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:waterwake-tiny"
                        ]
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
                            LuaKey.Int 1, LuaValue.String "sharmmov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "radjam1"
                        ]
                ]
        ]

    let armsubk =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMSUBK.DDS"
            LuaKey.String "buildtime", LuaValue.Number 28000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 5 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "30 30 64"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 17000.0
            LuaKey.String "explodeas", LuaValue.String "mediumExplosionGeneric-uw"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 2350.0
            LuaKey.String "maxacc", LuaValue.Number 0.05
            LuaKey.String "maxdec", LuaValue.Number 0.05
            LuaKey.String "metalcost", LuaValue.Number 950.0
            LuaKey.String "minwaterdepth", LuaValue.Number 15.0
            LuaKey.String "movementclass", LuaValue.String "UBOAT4"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/ARMSUBK.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMSUBK.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumExplosionGenericSelfd-uw"
            LuaKey.String "sightdistance", LuaValue.Number 390.0
            LuaKey.String "sonardistance", LuaValue.Number 525.0
            LuaKey.String "speed", LuaValue.Number 81.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 540.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "waterline", LuaValue.Number 40.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmShips/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "sub"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.712867736816 -4.88281237665e-09 -0.00479125976563"
                            LuaKey.String "collisionvolumescales", LuaValue.String "19.7231903076 16.8272399902 61.3809509277"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1434.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 475.0
                            LuaKey.String "object", LuaValue.String "Units/armsubk_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 4032.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 240.0
                            LuaKey.String "object", LuaValue.String "Units/arm2X2A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 0, LuaValue.String "custom:subbubbles"
                            LuaKey.Int 1, LuaValue.String "custom:subwake"
                            LuaKey.Int 2, LuaValue.String "custom:subtorpfire"
                        ]
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
                            LuaKey.Int 1, LuaValue.String "suarmmov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "suarmsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "armsmart_torpedo", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "torpedotrail-small"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-uw"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "torpedo.s3o"
                            LuaKey.String "name", LuaValue.String "Rapid armor-piercing torpedoes"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 400.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.0
                            LuaKey.String "soundhit", LuaValue.String "xplodep1"
                            LuaKey.String "soundhitvolume", LuaValue.Number 18.0
                            LuaKey.String "soundstart", LuaValue.String "torpedo1"
                            LuaKey.String "startvelocity", LuaValue.Number 150.0
                            LuaKey.String "tolerance", LuaValue.Number 9000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 1000.0
                            LuaKey.String "turret", LuaValue.Bool false
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 10.0
                            LuaKey.String "weapontimer", LuaValue.Number 3.0
                            LuaKey.String "weapontype", LuaValue.String "TorpedoLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 200.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 350.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "HOVER NOTSHIP"
                            LuaKey.String "def", LuaValue.String "ARMSMART_TORPEDO"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 180.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTHOVER"
                        ]
                ]
        ]

    let armtdrone =
        LuaValue.Table [
            LuaKey.String "acceleration", LuaValue.Number 0.22
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "brakerate", LuaValue.Number 0.5
            LuaKey.String "buildcostenergy", LuaValue.Number 750.0
            LuaKey.String "buildcostmetal", LuaValue.Number 30.0
            LuaKey.String "buildpic", LuaValue.String "ARMKAM.DDS"
            LuaKey.String "buildtime", LuaValue.Number 1500.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collide", LuaValue.Bool true
            LuaKey.String "cruisealt", LuaValue.Number 40.0
            LuaKey.String "explodeas", LuaValue.String "smallExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 1.0
            LuaKey.String "footprintz", LuaValue.Number 1.0
            LuaKey.String "hoverattack", LuaValue.Bool true
            LuaKey.String "maxdamage", LuaValue.Number 300.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxvelocity", LuaValue.Number 11.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/ARMDRONE.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMDRONE.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "smallExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 500.0
            LuaKey.String "sonardistance", LuaValue.Number 400.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 360.0
            LuaKey.String "turnrate", LuaValue.Number 1000.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "drone", LuaValue.Number 1.0
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "nohealthbars", LuaValue.Number 1.0
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmShips/T2"
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
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
                            LuaKey.Int 1, LuaValue.String "vtolarmv"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "vtolarac"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "atdronewep", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "torpedotrail-tiny"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.25
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-small-uw"
                            LuaKey.String "flighttime", LuaValue.Number 3.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "torpedo.s3o"
                            LuaKey.String "name", LuaValue.String "Homing depth charge launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 600.0
                            LuaKey.String "reloadtime", LuaValue.Number 3.0
                            LuaKey.String "soundhit", LuaValue.String "xplodep1"
                            LuaKey.String "soundhitvolume", LuaValue.Number 3.0
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundhitwetvolume", LuaValue.Number 12.0
                            LuaKey.String "soundstart", LuaValue.String "bombrel"
                            LuaKey.String "startvelocity", LuaValue.Number 130.0
                            LuaKey.String "tolerance", LuaValue.Number 12000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 7000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 15.0
                            LuaKey.String "weapontimer", LuaValue.Number 4.0
                            LuaKey.String "weapontype", LuaValue.String "TorpedoLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 200.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "speceffect", LuaValue.String "torpwaterpen"
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 30.0
                                    LuaKey.String "default", LuaValue.Number 45.0
                                ]
                        ]
                    LuaKey.String "td_depthcharge", LuaValue.Table [
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "bouncerebound", LuaValue.Number 0.6
                            LuaKey.String "bounceslip", LuaValue.Number 0.6
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-small-uw"
                            LuaKey.String "flighttime", LuaValue.Number 1.75
                            LuaKey.String "groundbounce", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "cordepthcharge.s3o"
                            LuaKey.String "name", LuaValue.String "Depthcharge launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "numbounce", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 200.0
                            LuaKey.String "reloadtime", LuaValue.Number 6.0
                            LuaKey.String "soundhit", LuaValue.String "xplodep2"
                            LuaKey.String "soundhitvolume", LuaValue.Number 3.0
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundhitwetvolume", LuaValue.Number 12.0
                            LuaKey.String "soundstart", LuaValue.String "torpedo1"
                            LuaKey.String "startvelocity", LuaValue.Number 150.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 64000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "TorpedoLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 200.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 215.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "td_depthcharge"
                            LuaKey.String "maindir", LuaValue.String "0 -2 1"
                            LuaKey.String "maxangledif", LuaValue.Number 120.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "CANBEUW UNDERWATER"
                        ]
                ]
        ]

    let armtrident =
        LuaValue.Table [
            LuaKey.String "acceleration", LuaValue.Number 0.01722
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "brakerate", LuaValue.Number 0.01722
            LuaKey.String "buildangle", LuaValue.Number 16384.0
            LuaKey.String "buildcostenergy", LuaValue.Number 10500.0
            LuaKey.String "buildcostmetal", LuaValue.Number 1050.0
            LuaKey.String "buildpic", LuaValue.String "armtrident.dds"
            LuaKey.String "buildtime", LuaValue.Number 18000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canreclaim", LuaValue.Bool false
            LuaKey.String "canrepair", LuaValue.Bool false
            LuaKey.String "canrestore", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "42 42 84"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylZ"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "hugeexplosiongeneric"
            LuaKey.String "floater", LuaValue.Bool true
            LuaKey.String "footprintx", LuaValue.Number 6.0
            LuaKey.String "footprintz", LuaValue.Number 6.0
            LuaKey.String "losemitheight", LuaValue.Number 56.0
            LuaKey.String "mass", LuaValue.Number 10000.0
            LuaKey.String "maxdamage", LuaValue.Number 3400.0
            LuaKey.String "maxvelocity", LuaValue.Number 2.25
            LuaKey.String "minwaterdepth", LuaValue.Number 15.0
            LuaKey.String "movementclass", LuaValue.String "BOAT9"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/armtrident.s3o"
            LuaKey.String "script", LuaValue.String "Units/armtrident_clean.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "hugeexplosiongenericSelfD"
            LuaKey.String "sightdistance", LuaValue.Number 600.0
            LuaKey.String "sonardistance", LuaValue.Number 620.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 180.0
            LuaKey.String "waterline", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Odin, Hornet"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmShips/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "inheritxpratemultiplier", LuaValue.Number 1.0
                    LuaKey.String "childreninheritxp", LuaValue.String "DRONE"
                    LuaKey.String "parentsinheritxp", LuaValue.String "DRONE"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "-0.0550308227539 1.52587890767e-06 4.55026245117"
                            LuaKey.String "collisionvolumescales", LuaValue.String "61.8225860596 60.9250030518 154.450805664"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 9168.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 700.0
                            LuaKey.String "object", LuaValue.String "Units/armtrident_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 4032.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 350.0
                            LuaKey.String "object", LuaValue.String "Units/arm6X6C.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:radarpulse_t1_slow"
                            LuaKey.Int 2, LuaValue.String "custom:waterwake-large"
                            LuaKey.Int 3, LuaValue.String "custom:bowsplash-huge"
                        ]
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
                            LuaKey.Int 1, LuaValue.String "sharmmov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "sharmsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "plasma", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 4.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String ""
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "hightrajectory", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "name", LuaValue.String "Depth Charge Drones"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "metalpershot", LuaValue.Number 30.0
                            LuaKey.String "energypershot", LuaValue.Number 750.0
                            LuaKey.String "range", LuaValue.Number 1300.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.5
                            LuaKey.String "size", LuaValue.Number 0.0
                            LuaKey.String "soundhit", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String ""
                            LuaKey.String "soundstart", LuaValue.String ""
                            LuaKey.String "stockpile", LuaValue.Bool true
                            LuaKey.String "stockpiletime", LuaValue.Number 5.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 800.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 0.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "carried_unit", LuaValue.String "armtdrone"
                                    LuaKey.String "engagementrange", LuaValue.Number 1300.0
                                    LuaKey.String "spawns_surface", LuaValue.String "SEA"
                                    LuaKey.String "spawnrate", LuaValue.Number 5.0
                                    LuaKey.String "maxunits", LuaValue.Number 4.0
                                    LuaKey.String "startingdronecount", LuaValue.Number 2.0
                                    LuaKey.String "buildcostenergy", LuaValue.Number 750.0
                                    LuaKey.String "buildcostmetal", LuaValue.Number 30.0
                                    LuaKey.String "controlradius", LuaValue.Number 1400.0
                                    LuaKey.String "decayrate", LuaValue.Number 3.0
                                    LuaKey.String "attackformationspread", LuaValue.Number 120.0
                                    LuaKey.String "attackformationoffset", LuaValue.Number 30.0
                                    LuaKey.String "carrierdeaththroe", LuaValue.String "release"
                                    LuaKey.String "dockingarmor", LuaValue.Number 0.2
                                    LuaKey.String "dockinghealrate", LuaValue.Number 36.0
                                    LuaKey.String "docktohealthreshold", LuaValue.Number 50.0
                                    LuaKey.String "enabledocking", LuaValue.Bool true
                                    LuaKey.String "dockingHelperSpeed", LuaValue.Number 5.0
                                    LuaKey.String "dockingpieces", LuaValue.String "10 11 12 13 14"
                                    LuaKey.String "dockingradius", LuaValue.Number 300.0
                                    LuaKey.String "stockpilelimit", LuaValue.Number 4.0
                                    LuaKey.String "stockpilemetal", LuaValue.Number 30.0
                                    LuaKey.String "stockpileenergy", LuaValue.Number 750.0
                                    LuaKey.String "dronesusestockpile", LuaValue.Bool true
                                    LuaKey.String "dronedocktime", LuaValue.Number 2.0
                                    LuaKey.String "droneairtime", LuaValue.Number 60.0
                                    LuaKey.String "droneammo", LuaValue.Number 3.0
                                ]
                        ]
                    LuaKey.String "trident_depthcharge", LuaValue.Table [
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "bouncerebound", LuaValue.Number 0.6
                            LuaKey.String "bounceslip", LuaValue.Number 0.6
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-small-uw"
                            LuaKey.String "flighttime", LuaValue.Number 1.75
                            LuaKey.String "groundbounce", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "cordepthcharge.s3o"
                            LuaKey.String "name", LuaValue.String "Depthcharge launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "numbounce", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 600.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.5
                            LuaKey.String "soundhit", LuaValue.String "xplodep2"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "torpedo1"
                            LuaKey.String "soundhitvolume", LuaValue.Number 3.0
                            LuaKey.String "soundhitwetvolume", LuaValue.Number 12.0
                            LuaKey.String "startvelocity", LuaValue.Number 300.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 64000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "TorpedoLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 200.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 255.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "PLASMA"
                            LuaKey.String "onlytargetcategory", LuaValue.String "CANBEUW UNDERWATER"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "TRIDENT_DEPTHCHARGE"
                            LuaKey.String "onlytargetcategory", LuaValue.String "CANBEUW UNDERWATER"
                        ]
                ]
        ]

    let all : (string * LuaValue) list =
        [
            "armaas", armaas
            "armacsub", armacsub
            "armantiship", armantiship
            "armbats", armbats
            "armcarry", armcarry
            "armcrus", armcrus
            "armdronecarry", armdronecarry
            "armepoch", armepoch
            "armexcalibur", armexcalibur
            "armhacs", armhacs
            "armlship", armlship
            "armmls", armmls
            "armmship", armmship
            "armsacsub", armsacsub
            "armseadragon", armseadragon
            "armserp", armserp
            "armsjam", armsjam
            "armsubk", armsubk
            "armtdrone", armtdrone
            "armtrident", armtrident
        ]
