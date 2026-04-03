// Auto-generated BAR unit data: ArmBots/T2
namespace BarData.Units

open BarData

module ArmBots_T2 =

    let armaak =
        LuaValue.Table [
            LuaKey.String "airsightdistance", LuaValue.Number 1200.0
            LuaKey.String "buildpic", LuaValue.String "ARMAAK.DDS"
            LuaKey.String "buildtime", LuaValue.Number 10000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -1 1"
            LuaKey.String "collisionvolumescales", LuaValue.String "25 32 16"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 5600.0
            LuaKey.String "explodeas", LuaValue.String "mediumexplosiongeneric-phib"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "health", LuaValue.Number 2200.0
            LuaKey.String "maxacc", LuaValue.Number 0.138
            LuaKey.String "maxdec", LuaValue.Number 0.6486
            LuaKey.String "maxslope", LuaValue.Number 14.0
            LuaKey.String "metalcost", LuaValue.Number 520.0
            LuaKey.String "movementclass", LuaValue.String "ABOT3"
            LuaKey.String "movestate", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "NOTAIR"
            LuaKey.String "objectname", LuaValue.String "Units/ARMAAK.s3o"
            LuaKey.String "script", LuaValue.String "Units/armaak_clean.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumExplosionGenericSelfd-phib"
            LuaKey.String "sightdistance", LuaValue.Number 400.0
            LuaKey.String "speed", LuaValue.Number 47.4
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.0428
            LuaKey.String "turnrate", LuaValue.Number 1174.15002
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Kaiser"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmBots/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "aa"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.0 -1.2425585791 1.2922744751"
                            LuaKey.String "collisionvolumescales", LuaValue.String "30.0 14.3981628418 32.5845489502"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1212.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 15.0
                            LuaKey.String "metal", LuaValue.Number 314.0
                            LuaKey.String "object", LuaValue.String "Units/armaak_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "85.0 14.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 606.0
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 126.0
                            LuaKey.String "object", LuaValue.String "Units/arm4X4A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-medium-aa"
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
                            LuaKey.Int 1, LuaValue.String "kbarmmov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "kbarmsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "longrangemissile", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 24.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "castshadow", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "missiletrailaa"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-tiny-aa"
                            LuaKey.String "firestarter", LuaValue.Number 70.0
                            LuaKey.String "fixedlauncher", LuaValue.Bool true
                            LuaKey.String "flighttime", LuaValue.Number 1.8
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "cormissile.s3o"
                            LuaKey.String "name", LuaValue.String "Long-Range Anti-Air Missile Launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number -1.0
                            LuaKey.String "range", LuaValue.Number 1200.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.5
                            LuaKey.String "smokecolor", LuaValue.Number 1.0
                            LuaKey.String "smokeperiod", LuaValue.Number 6.0
                            LuaKey.String "smokesize", LuaValue.Number 5.5
                            LuaKey.String "smoketime", LuaValue.Number 11.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smoketrailcastshadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "xplosml2"
                            LuaKey.String "soundhitvolume", LuaValue.Number 7.5
                            LuaKey.String "soundhitwet", LuaValue.String "splssml"
                            LuaKey.String "soundstart", LuaValue.String "rocklit1"
                            LuaKey.String "soundstartvolume", LuaValue.Number 7.5
                            LuaKey.String "startvelocity", LuaValue.Number 590.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailaa3"
                            LuaKey.String "tolerance", LuaValue.Number 15000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 30000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 150.0
                            LuaKey.String "weapontimer", LuaValue.Number 6.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "vtol", LuaValue.Number 150.0
                                ]
                        ]
                    LuaKey.String "shortrangemissile", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 24.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "castshadow", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "missiletrailaa"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-tiny-aa"
                            LuaKey.String "firestarter", LuaValue.Number 70.0
                            LuaKey.String "fixedlauncher", LuaValue.Bool true
                            LuaKey.String "flighttime", LuaValue.Number 1.85
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "cormissile.s3o"
                            LuaKey.String "name", LuaValue.String "Medium-Range Anti-Air Missile Launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 880.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.7
                            LuaKey.String "smokecolor", LuaValue.Number 1.0
                            LuaKey.String "smokeperiod", LuaValue.Number 6.0
                            LuaKey.String "smokesize", LuaValue.Number 2.0
                            LuaKey.String "smoketime", LuaValue.Number 11.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smoketrailcastshadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "xplosml2"
                            LuaKey.String "soundhitvolume", LuaValue.Number 7.5
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "rocklit1"
                            LuaKey.String "soundstartvolume", LuaValue.Number 7.5
                            LuaKey.String "startvelocity", LuaValue.Number 100.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailaa"
                            LuaKey.String "tolerance", LuaValue.Number 26000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 30000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 400.0
                            LuaKey.String "weapontimer", LuaValue.Number 5.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 800.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "vtol", LuaValue.Number 100.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR LIGHTAIRSCOUT"
                            LuaKey.String "def", LuaValue.String "LONGRANGEMISSILE"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR LIGHTAIRSCOUT"
                            LuaKey.String "def", LuaValue.String "SHORTRANGEMISSILE"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let armack =
        LuaValue.Table [
            LuaKey.String "builddistance", LuaValue.Number 136.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMACK.DDS"
            LuaKey.String "buildtime", LuaValue.Number 12500.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "27 35 23"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 6900.0
            LuaKey.String "energymake", LuaValue.Number 14.0
            LuaKey.String "energystorage", LuaValue.Number 100.0
            LuaKey.String "explodeas", LuaValue.String "mediumexplosiongeneric-builder"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "health", LuaValue.Number 930.0
            LuaKey.String "maxacc", LuaValue.Number 0.4968
            LuaKey.String "maxdec", LuaValue.Number 3.105
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 25.0
            LuaKey.String "metalcost", LuaValue.Number 430.0
            LuaKey.String "movementclass", LuaValue.String "BOT2"
            LuaKey.String "objectname", LuaValue.String "Units/ARMACK.s3o"
            LuaKey.String "radardistance", LuaValue.Number 50.0
            LuaKey.String "script", LuaValue.String "Units/ARMACK.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumExplosionGenericSelfd-builder"
            LuaKey.String "sightdistance", LuaValue.Number 323.70001
            LuaKey.String "speed", LuaValue.Number 33.0
            LuaKey.String "terraformspeed", LuaValue.Number 900.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.759
            LuaKey.String "turnrate", LuaValue.Number 1138.5
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "workertime", LuaValue.Number 210.0
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "armfus"
                    LuaKey.Int 2, LuaValue.String "armafus"
                    LuaKey.Int 3, LuaValue.String "armckfus"
                    LuaKey.Int 4, LuaValue.String "armshltx"
                    LuaKey.Int 5, LuaValue.String "armageo"
                    LuaKey.Int 6, LuaValue.String "armgmm"
                    LuaKey.Int 7, LuaValue.String "armmoho"
                    LuaKey.Int 8, LuaValue.String "armmmkr"
                    LuaKey.Int 9, LuaValue.String "armuwadves"
                    LuaKey.Int 10, LuaValue.String "armuwadvms"
                    LuaKey.Int 11, LuaValue.String "armarad"
                    LuaKey.Int 12, LuaValue.String "armveil"
                    LuaKey.Int 13, LuaValue.String "armfort"
                    LuaKey.Int 14, LuaValue.String "armtarg"
                    LuaKey.Int 15, LuaValue.String "armsd"
                    LuaKey.Int 16, LuaValue.String "armgate"
                    LuaKey.Int 17, LuaValue.String "armamb"
                    LuaKey.Int 18, LuaValue.String "armpb"
                    LuaKey.Int 19, LuaValue.String "armanni"
                    LuaKey.Int 20, LuaValue.String "armflak"
                    LuaKey.Int 21, LuaValue.String "armmercury"
                    LuaKey.Int 22, LuaValue.String "armemp"
                    LuaKey.Int 23, LuaValue.String "armamd"
                    LuaKey.Int 24, LuaValue.String "armsilo"
                    LuaKey.Int 25, LuaValue.String "armbrtha"
                    LuaKey.Int 26, LuaValue.String "armvulc"
                    LuaKey.Int 27, LuaValue.String "armdf"
                    LuaKey.Int 28, LuaValue.String "armlab"
                    LuaKey.Int 29, LuaValue.String "armalab"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Kaiser"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmBots/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "buildert2"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "1.64561462402 6.61621093734e-06 -1.44562530518"
                            LuaKey.String "collisionvolumescales", LuaValue.String "29.6044616699 29.4648132324 28.049697876"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 700.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 189.0
                            LuaKey.String "object", LuaValue.String "Units/armack_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 500.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 76.0
                            LuaKey.String "object", LuaValue.String "Units/arm2X2B.s3o"
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
                            LuaKey.Int 1, LuaValue.String "kbarmmov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "kbarmsel"
                        ]
                ]
        ]

    let armamph =
        LuaValue.Table [
            LuaKey.String "buildpic", LuaValue.String "ARMAMPH.DDS"
            LuaKey.String "buildtime", LuaValue.Number 7000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 -1"
            LuaKey.String "collisionvolumescales", LuaValue.String "27 35 21"
            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 2700.0
            LuaKey.String "explodeas", LuaValue.String "smallExplosionGeneric-phib"
            LuaKey.String "floater", LuaValue.Bool false
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 1170.0
            LuaKey.String "maxacc", LuaValue.Number 0.138
            LuaKey.String "maxdec", LuaValue.Number 0.6486
            LuaKey.String "maxslope", LuaValue.Number 14.0
            LuaKey.String "metalcost", LuaValue.Number 260.0
            LuaKey.String "movementclass", LuaValue.String "AHOVER2"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/ARMAMPH.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMAMPH.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "smallExplosionGenericSelfd-phib"
            LuaKey.String "sightdistance", LuaValue.Number 377.0
            LuaKey.String "speed", LuaValue.Number 90.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.98
            LuaKey.String "turnrate", LuaValue.Number 506.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmBots/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "weaponaa"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "-1.16748809814 -0.254996625977 -1"
                            LuaKey.String "collisionvolumescales", LuaValue.String "27 10 35"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 800.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 159.0
                            LuaKey.String "object", LuaValue.String "Units/armamph_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 500.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 64.0
                            LuaKey.String "object", LuaValue.String "Units/arm3X3D.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
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
                            LuaKey.Int 1, LuaValue.String "amphok1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "amphsel1"
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
                            LuaKey.String "range", LuaValue.Number 600.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.1
                            LuaKey.String "smokecolor", LuaValue.Number 0.95
                            LuaKey.String "smokeperiod", LuaValue.Number 5.0
                            LuaKey.String "smokesize", LuaValue.Number 4.4
                            LuaKey.String "smoketime", LuaValue.Number 12.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smoketrailcastshadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "xplosml2"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "rocklit1"
                            LuaKey.String "startvelocity", LuaValue.Number 650.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailaa"
                            LuaKey.String "tolerance", LuaValue.Number 9000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 48000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 141.0
                            LuaKey.String "weapontimer", LuaValue.Number 5.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 850.0
                            LuaKey.String "customparams", LuaValue.Table []
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "vtol", LuaValue.Number 90.0
                                ]
                        ]
                    LuaKey.String "armamph_weapon1", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 8.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.1
                            LuaKey.String "corethickness", LuaValue.Number 0.175
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 2.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small-red"
                            LuaKey.String "firestarter", LuaValue.Number 20.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "name", LuaValue.String "Light close-quarters laser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 275.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.73333
                            LuaKey.String "rgbcolor", LuaValue.String "1 0 0"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrfir3"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 2.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 80.0
                                    LuaKey.String "vtol", LuaValue.Number 15.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "ARMAMPH_WEAPON1"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR"
                            LuaKey.String "def", LuaValue.String "ARMAMPH_MISSILE"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let armaser =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMASER.DDS"
            LuaKey.String "buildtime", LuaValue.Number 6000.0
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -7 2"
            LuaKey.String "collisionvolumescales", LuaValue.String "26 48 24"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 1400.0
            LuaKey.String "energyupkeep", LuaValue.Number 80.0
            LuaKey.String "explodeas", LuaValue.String "smallexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "health", LuaValue.Number 340.0
            LuaKey.String "maxacc", LuaValue.Number 0.138
            LuaKey.String "maxdec", LuaValue.Number 0.5175
            LuaKey.String "maxslope", LuaValue.Number 32.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 112.0
            LuaKey.String "metalcost", LuaValue.Number 78.0
            LuaKey.String "movementclass", LuaValue.String "BOT2"
            LuaKey.String "movestate", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Units/ARMASER.s3o"
            LuaKey.String "onoffable", LuaValue.Bool true
            LuaKey.String "radardistancejam", LuaValue.Number 450.0
            LuaKey.String "script", LuaValue.String "Units/ARMASER.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "smallExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 260.0
            LuaKey.String "speed", LuaValue.Number 48.3
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.0626
            LuaKey.String "turnrate", LuaValue.Number 1201.75
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "off_on_stun", LuaValue.String "true"
                    LuaKey.String "subfolder", LuaValue.String "ArmBots/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "util"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.136978149414 4.50317382814e-05 -6.27960205078"
                            LuaKey.String "collisionvolumescales", LuaValue.String "28.490814209 34.7166900635 16.3992004395"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 250.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 1.0
                            LuaKey.String "footprintz", LuaValue.Number 1.0
                            LuaKey.String "height", LuaValue.Number 40.0
                            LuaKey.String "metal", LuaValue.Number 47.0
                            LuaKey.String "object", LuaValue.String "Units/armaser_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "21.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 150.0
                            LuaKey.String "footprintx", LuaValue.Number 1.0
                            LuaKey.String "footprintz", LuaValue.Number 1.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 19.0
                            LuaKey.String "object", LuaValue.String "Units/arm1X1A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
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
                            LuaKey.Int 1, LuaValue.String "kbarmmov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "radjam1"
                        ]
                ]
        ]

    let armdecom =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 0.0
            LuaKey.String "builddistance", LuaValue.Number 145.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMDECOM.DDS"
            LuaKey.String "buildtime", LuaValue.Number 30000.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "candgun", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "capturespeed", LuaValue.Number 900.0
            LuaKey.String "cloakcost", LuaValue.Number 30.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 180.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "28 52 28"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "decoyfor", LuaValue.String "armcom"
            LuaKey.String "energycost", LuaValue.Number 12000.0
            LuaKey.String "energymake", LuaValue.Number 15.0
            LuaKey.String "energystorage", LuaValue.Number 50.0
            LuaKey.String "explodeas", LuaValue.String "decoycommander"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 3700.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "holdsteady", LuaValue.Bool true
            LuaKey.String "maxacc", LuaValue.Number 0.18
            LuaKey.String "maxdec", LuaValue.Number 1.125
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 35.0
            LuaKey.String "metalcost", LuaValue.Number 770.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "COMMANDERBOT"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/ARMCOM.s3o"
            LuaKey.String "radardistance", LuaValue.Number 700.0
            LuaKey.String "radaremitheight", LuaValue.Number 40.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "releaseheld", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Units/ARMCOM_lus.lua"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "decoycommanderSelfd"
            LuaKey.String "showplayername", LuaValue.Bool true
            LuaKey.String "sightdistance", LuaValue.Number 450.0
            LuaKey.String "sonardistance", LuaValue.Number 450.0
            LuaKey.String "speed", LuaValue.Number 37.5
            LuaKey.String "terraformspeed", LuaValue.Number 750.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 140.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.825
            LuaKey.String "turnrate", LuaValue.Number 1148.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "workertime", LuaValue.Number 300.0
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "armmine1"
                    LuaKey.Int 2, LuaValue.String "armmine2"
                    LuaKey.Int 3, LuaValue.String "armmine3"
                    LuaKey.Int 4, LuaValue.String "armsolar"
                    LuaKey.Int 5, LuaValue.String "armwin"
                    LuaKey.Int 6, LuaValue.String "armmstor"
                    LuaKey.Int 7, LuaValue.String "armestor"
                    LuaKey.Int 8, LuaValue.String "armmex"
                    LuaKey.Int 9, LuaValue.String "armmakr"
                    LuaKey.Int 10, LuaValue.String "armrad"
                    LuaKey.Int 11, LuaValue.String "armllt"
                    LuaKey.Int 12, LuaValue.String "armrl"
                    LuaKey.Int 13, LuaValue.String "armtide"
                    LuaKey.Int 14, LuaValue.String "armuwms"
                    LuaKey.Int 15, LuaValue.String "armuwes"
                    LuaKey.Int 16, LuaValue.String "armfmkr"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "decoyfor", LuaValue.String "armcom"
                    LuaKey.String "isdecoycommander", LuaValue.Bool true
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.0
                    LuaKey.String "subfolder", LuaValue.String "ArmBots/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "buildert2"
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:com_sea_laser_bubbles"
                            LuaKey.Int 2, LuaValue.String "custom:barrelshot-medium"
                            LuaKey.Int 3, LuaValue.String "custom:footstep-medium"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "nanlath1"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "capture", LuaValue.String "capture1"
                    LuaKey.String "cloak", LuaValue.String "kloak1"
                    LuaKey.String "repair", LuaValue.String "repair1"
                    LuaKey.String "uncloak", LuaValue.String "kloak1un"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "unitcomplete", LuaValue.String "kcarmmov"
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
                            LuaKey.Int 1, LuaValue.String "kcarmmov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "kcarmsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "armcomlaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 12.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.1
                            LuaKey.String "corethickness", LuaValue.Number 0.1
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 1.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small-red"
                            LuaKey.String "firestarter", LuaValue.Number 70.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 5.5
                            LuaKey.String "name", LuaValue.String "Light close-quarters g2g laser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 300.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.4
                            LuaKey.String "rgbcolor", LuaValue.String "1 0 0"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrfir1"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 2.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 900.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 75.0
                                    LuaKey.String "subs", LuaValue.Number 5.0
                                ]
                        ]
                    LuaKey.String "armcomsealaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 12.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.3
                            LuaKey.String "corethickness", LuaValue.Number 0.4
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 1.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small-blue"
                            LuaKey.String "firestarter", LuaValue.Number 35.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.3
                            LuaKey.String "laserflaresize", LuaValue.Number 5.5
                            LuaKey.String "name", LuaValue.String "J7NSLaser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 260.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.2 0.2 0.6"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.2 0.2 0.2"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "uwlasrfir1"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 5.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 900.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 62.5
                                    LuaKey.String "subs", LuaValue.Number 18.75
                                ]
                        ]
                    LuaKey.String "disintegrator", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 36.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "avoidground", LuaValue.Bool false
                            LuaKey.String "bouncerebound", LuaValue.Number 0.0
                            LuaKey.String "cegtag", LuaValue.String "dgunprojectile"
                            LuaKey.String "commandfire", LuaValue.Bool true
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.6
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 150.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:expldgun"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "firesubmersed", LuaValue.Bool false
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "name", LuaValue.String "Decoy-disintegrator"
                            LuaKey.String "noexplode", LuaValue.Bool true
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 250.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.9
                            LuaKey.String "soundhit", LuaValue.String "xplomas2"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "disigun1"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 4.2
                            LuaKey.String "weapontype", LuaValue.String "DGun"
                            LuaKey.String "weaponvelocity", LuaValue.Number 300.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 40.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "ARMCOMLASER"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "ARMCOMSEALASER"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "DISINTEGRATOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let armfark =
        LuaValue.Table [
            LuaKey.String "autoheal", LuaValue.Number 5.0
            LuaKey.String "builddistance", LuaValue.Number 136.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMFARK.DDS"
            LuaKey.String "buildtime", LuaValue.Number 6000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 -1"
            LuaKey.String "collisionvolumescales", LuaValue.String "21 26 17"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 3000.0
            LuaKey.String "energymake", LuaValue.Number 12.0
            LuaKey.String "energystorage", LuaValue.Number 25.0
            LuaKey.String "explodeas", LuaValue.String "smallbuilder"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "health", LuaValue.Number 335.0
            LuaKey.String "maxacc", LuaValue.Number 0.4968
            LuaKey.String "maxdec", LuaValue.Number 5.175
            LuaKey.String "maxslope", LuaValue.Number 14.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 22.0
            LuaKey.String "metalcost", LuaValue.Number 210.0
            LuaKey.String "movementclass", LuaValue.String "BOT2"
            LuaKey.String "objectname", LuaValue.String "Units/ARMFARK.s3o"
            LuaKey.String "radardistance", LuaValue.Number 50.0
            LuaKey.String "script", LuaValue.String "Units/ARMFARK.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "smallbuilderSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 377.0
            LuaKey.String "speed", LuaValue.Number 75.0
            LuaKey.String "terraformspeed", LuaValue.Number 600.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.7424
            LuaKey.String "turnrate", LuaValue.Number 1265.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "workertime", LuaValue.Number 140.0
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "armsolar"
                    LuaKey.Int 2, LuaValue.String "armwin"
                    LuaKey.Int 3, LuaValue.String "armmex"
                    LuaKey.Int 4, LuaValue.String "armmakr"
                    LuaKey.Int 5, LuaValue.String "armeyes"
                    LuaKey.Int 6, LuaValue.String "armmark"
                    LuaKey.Int 7, LuaValue.String "armaser"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmBots/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "buildert2"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "21 5 17"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 250.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 131.0
                            LuaKey.String "object", LuaValue.String "Units/armfark_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 150.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 52.0
                            LuaKey.String "object", LuaValue.String "Units/arm2X2D.s3o"
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
                            LuaKey.Int 1, LuaValue.String "kbarmmov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "kbarmsel"
                        ]
                ]
        ]

    let armfast =
        LuaValue.Table [
            LuaKey.String "buildpic", LuaValue.String "ARMFAST.DDS"
            LuaKey.String "buildtime", LuaValue.Number 5000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -2 1"
            LuaKey.String "collisionvolumescales", LuaValue.String "28 40 28"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 3800.0
            LuaKey.String "explodeas", LuaValue.String "tinyExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 690.0
            LuaKey.String "maxacc", LuaValue.Number 0.414
            LuaKey.String "maxdec", LuaValue.Number 1.29375
            LuaKey.String "maxslope", LuaValue.Number 17.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 12.0
            LuaKey.String "metalcost", LuaValue.Number 160.0
            LuaKey.String "movementclass", LuaValue.String "BOT3"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/ARMFAST.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMFAST.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "tinyExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 351.0
            LuaKey.String "speed", LuaValue.Number 111.3
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 2.4486
            LuaKey.String "turnrate", LuaValue.Number 1644.5
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "FireStorm, PtaQ"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmBots/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "weapon1turretx", LuaValue.Number 400.0
                    LuaKey.String "weapon1turrety", LuaValue.Number 500.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "-2.49777984619 -2.74520318604 -3.11322021484"
                            LuaKey.String "collisionvolumescales", LuaValue.String "50.1881866455 6.02409362793 37.503112793"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 500.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 105.0
                            LuaKey.String "object", LuaValue.String "Units/armfast_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 300.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 42.0
                            LuaKey.String "object", LuaValue.String "Units/arm2X2E.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-tiny"
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
                            LuaKey.Int 1, LuaValue.String "kbarmmov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "kbarmsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "arm_fast", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 5.0
                            LuaKey.String "burstrate", LuaValue.Number 0.1
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:plasmahit-small"
                            LuaKey.String "flighttime", LuaValue.Number 0.47
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "intensity", LuaValue.Number 0.7
                            LuaKey.String "name", LuaValue.String "Rapid-firing close-quarters g2g plasma guns"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 230.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.5
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.95 0.4"
                            LuaKey.String "size", LuaValue.Number 2.05
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "fastemg"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 0.6
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 600.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 12.0
                                    LuaKey.String "vtol", LuaValue.Number 4.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "ARM_FAST"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let armfboy =
        LuaValue.Table [
            LuaKey.String "buildpic", LuaValue.String "ARMFBOY.DDS"
            LuaKey.String "buildtime", LuaValue.Number 32000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "34 40 42"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 20000.0
            LuaKey.String "explodeas", LuaValue.String "largeExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 7800.0
            LuaKey.String "maxacc", LuaValue.Number 0.138
            LuaKey.String "maxdec", LuaValue.Number 0.43125
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 25.0
            LuaKey.String "metalcost", LuaValue.Number 1400.0
            LuaKey.String "movementclass", LuaValue.String "HBOT4"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/ARMFBOY.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMFBOY.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 510.0
            LuaKey.String "speed", LuaValue.Number 30.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.66
            LuaKey.String "turnrate", LuaValue.Number 368.0
            LuaKey.String "usepiececollisionvolumes", LuaValue.Number 1.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Kaiser, PtaQ"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmBots/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "1.35855102539 -5.79698309326 2.2872467041"
                            LuaKey.String "collisionvolumescales", LuaValue.String "33.431427002 25.3690338135 53.5839233398"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 5000.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 9.0
                            LuaKey.String "metal", LuaValue.Number 1008.0
                            LuaKey.String "object", LuaValue.String "Units/armfboy_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 3500.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "metal", LuaValue.Number 403.0
                            LuaKey.String "object", LuaValue.String "Units/arm2X2A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-large"
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
                            LuaKey.Int 1, LuaValue.String "mavbot1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "capture2"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "arm_fatboy_notalaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 300.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "Heavy-Plasma"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 240.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 0.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large-aoe"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.9
                            LuaKey.String "name", LuaValue.String "Heavy AoE g2g plasma cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 700.0
                            LuaKey.String "reloadtime", LuaValue.Number 7.0
                            LuaKey.String "soundhit", LuaValue.String "bertha6"
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundstart", LuaValue.String "BERTHA1"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 307.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 800.0
                                    LuaKey.String "subs", LuaValue.Number 100.0
                                    LuaKey.String "vtol", LuaValue.Number 111.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "ARM_FATBOY_NOTALASER"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let armfido =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMFIDO.DDS"
            LuaKey.String "buildtime", LuaValue.Number 6500.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 1"
            LuaKey.String "collisionvolumescales", LuaValue.String "26 32 28"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 6300.0
            LuaKey.String "explodeas", LuaValue.String "mediumExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "health", LuaValue.Number 1280.0
            LuaKey.String "maxacc", LuaValue.Number 0.138
            LuaKey.String "maxdec", LuaValue.Number 1.29375
            LuaKey.String "maxslope", LuaValue.Number 14.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 12.0
            LuaKey.String "metalcost", LuaValue.Number 285.0
            LuaKey.String "movementclass", LuaValue.String "BOT3"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/ARMFIDO.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMFIDO.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 400.0
            LuaKey.String "speed", LuaValue.Number 69.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.518
            LuaKey.String "turnrate", LuaValue.Number 1138.5
            LuaKey.String "usepiececollisionvolumes", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Flaka"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmBots/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "-2.33637237549 -5.01163688965 -4.31414794922"
                            LuaKey.String "collisionvolumescales", LuaValue.String "32.719619751 19.6731262207 35.1108398438"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1000.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 164.0
                            LuaKey.String "object", LuaValue.String "Units/armfido_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 600.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 66.0
                            LuaKey.String "object", LuaValue.String "Units/arm2X2A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-medium-impulse"
                            LuaKey.Int 2, LuaValue.String "custom:barrelshot-medium"
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
                            LuaKey.Int 1, LuaValue.String "kbarmmov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "kbarmsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "bfido", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 72.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 72.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-small"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "name", LuaValue.String "Ballistic g2g AoE plasma cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 650.0
                            LuaKey.String "reloadtime", LuaValue.Number 3.16667
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splssml"
                            LuaKey.String "soundstart", LuaValue.String "cannon1"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 340.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 255.0
                                    LuaKey.String "vtol", LuaValue.Number 35.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "BFIDO"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let armhack =
        LuaValue.Table [
            LuaKey.String "autoheal", LuaValue.Number 5.0
            LuaKey.String "builddistance", LuaValue.Number 136.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMFARK.DDS"
            LuaKey.String "buildtime", LuaValue.Number 37000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 -1"
            LuaKey.String "collisionvolumescales", LuaValue.String "21 26 17"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 18000.0
            LuaKey.String "energymake", LuaValue.Number 12.0
            LuaKey.String "energystorage", LuaValue.Number 25.0
            LuaKey.String "explodeas", LuaValue.String "smallbuilder"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "health", LuaValue.Number 1335.0
            LuaKey.String "mass", LuaValue.Number 2700.0
            LuaKey.String "maxacc", LuaValue.Number 0.4968
            LuaKey.String "maxdec", LuaValue.Number 5.175
            LuaKey.String "maxslope", LuaValue.Number 14.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 22.0
            LuaKey.String "metalcost", LuaValue.Number 1260.0
            LuaKey.String "movementclass", LuaValue.String "BOT3"
            LuaKey.String "objectname", LuaValue.String "Units/ARMFARK.s3o"
            LuaKey.String "radardistance", LuaValue.Number 50.0
            LuaKey.String "script", LuaValue.String "Units/ARMFARK.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "smallbuilderSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 377.0
            LuaKey.String "speed", LuaValue.Number 75.0
            LuaKey.String "terraformspeed", LuaValue.Number 600.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.7424
            LuaKey.String "turnrate", LuaValue.Number 1265.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "workertime", LuaValue.Number 600.0
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "armafus"
                    LuaKey.Int 2, LuaValue.String "armfus"
                    LuaKey.Int 3, LuaValue.String "armckfus"
                    LuaKey.Int 4, LuaValue.String "armageo"
                    LuaKey.Int 5, LuaValue.String "armgmm"
                    LuaKey.Int 6, LuaValue.String "armmoho"
                    LuaKey.Int 7, LuaValue.String "armmmkr"
                    LuaKey.Int 8, LuaValue.String "armuwadves"
                    LuaKey.Int 9, LuaValue.String "armuwadvms"
                    LuaKey.Int 10, LuaValue.String "armfort"
                    LuaKey.Int 11, LuaValue.String "armtarg"
                    LuaKey.Int 12, LuaValue.String "armgate"
                    LuaKey.Int 13, LuaValue.String "armamb"
                    LuaKey.Int 14, LuaValue.String "armpb"
                    LuaKey.Int 15, LuaValue.String "armanni"
                    LuaKey.Int 16, LuaValue.String "armflak"
                    LuaKey.Int 17, LuaValue.String "armmercury"
                    LuaKey.Int 18, LuaValue.String "armemp"
                    LuaKey.Int 19, LuaValue.String "armamd"
                    LuaKey.Int 20, LuaValue.String "armsilo"
                    LuaKey.Int 21, LuaValue.String "armbrtha"
                    LuaKey.Int 22, LuaValue.String "armvulc"
                    LuaKey.Int 23, LuaValue.String "armdf"
                    LuaKey.Int 24, LuaValue.String "armbanth"
                    LuaKey.Int 25, LuaValue.String "armalab"
                    LuaKey.Int 26, LuaValue.String "armhalab"
                    LuaKey.Int 27, LuaValue.String "armlab"
                    LuaKey.Int 28, LuaValue.String "armvp"
                    LuaKey.Int 29, LuaValue.String "armap"
                    LuaKey.Int 30, LuaValue.String "armsy"
                    LuaKey.Int 31, LuaValue.String "armsd"
                    LuaKey.Int 32, LuaValue.String "armshltx"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmBots/T2"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                    LuaKey.String "unitgroup", LuaValue.String "buildert2"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "21 5 17"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 250.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 131.0
                            LuaKey.String "object", LuaValue.String "Units/armfark_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 150.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 52.0
                            LuaKey.String "object", LuaValue.String "Units/arm2X2D.s3o"
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
                            LuaKey.Int 1, LuaValue.String "kbarmmov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "kbarmsel"
                        ]
                ]
        ]

    let armmark =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMMARK.DDS"
            LuaKey.String "buildtime", LuaValue.Number 5000.0
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 -1"
            LuaKey.String "collisionvolumescales", LuaValue.String "26 24 16"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "corpse", LuaValue.String "dead"
            LuaKey.String "energycost", LuaValue.Number 1250.0
            LuaKey.String "explodeas", LuaValue.String "smallexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "health", LuaValue.Number 355.0
            LuaKey.String "maxacc", LuaValue.Number 0.05175
            LuaKey.String "maxdec", LuaValue.Number 0.0621
            LuaKey.String "maxslope", LuaValue.Number 16.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 100.0
            LuaKey.String "movementclass", LuaValue.String "BOT2"
            LuaKey.String "movestate", LuaValue.Number 0.0
            LuaKey.String "objectname", LuaValue.String "Units/ARMMARK.s3o"
            LuaKey.String "onoffable", LuaValue.Bool false
            LuaKey.String "radardistance", LuaValue.Number 2200.0
            LuaKey.String "script", LuaValue.String "Units/ARMMARK.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "smallExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 900.0
            LuaKey.String "sonardistance", LuaValue.Number 0.0
            LuaKey.String "speed", LuaValue.Number 40.5
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.891
            LuaKey.String "turnrate", LuaValue.Number 580.75
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmBots/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "util"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "-2.9700012207 0.0 2.42810058594"
                            LuaKey.String "collisionvolumescales", LuaValue.String "23.0599975586 13.375 26.6004943848"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 280.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 76.0
                            LuaKey.String "object", LuaValue.String "Units/armmark_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 256.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 38.0
                            LuaKey.String "object", LuaValue.String "Units/arm2X2A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:radarpulse_t2"
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
                            LuaKey.Int 1, LuaValue.String "kbarmmov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "akradsel"
                        ]
                ]
        ]

    let armmav =
        LuaValue.Table [
            LuaKey.String "autoheal", LuaValue.Number 50.0
            LuaKey.String "buildpic", LuaValue.String "ARMMAV.DDS"
            LuaKey.String "buildtime", LuaValue.Number 17000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "36 48 36"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 11000.0
            LuaKey.String "explodeas", LuaValue.String "mediumExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 1560.0
            LuaKey.String "maxacc", LuaValue.Number 0.138
            LuaKey.String "maxdec", LuaValue.Number 0.43125
            LuaKey.String "maxslope", LuaValue.Number 14.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 650.0
            LuaKey.String "movementclass", LuaValue.String "BOT3"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/ARMMAV.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMMAV.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 550.0
            LuaKey.String "speed", LuaValue.Number 49.5
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.089
            LuaKey.String "turnrate", LuaValue.Number 1285.69995
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Flaka"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "rangexpscale", LuaValue.Number 0.6
                    LuaKey.String "subfolder", LuaValue.String "ArmBots/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "50.6378936768 10.4806671143 38.4813079834"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 900.0
                            LuaKey.String "featuredead", LuaValue.String "heap"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 394.0
                            LuaKey.String "object", LuaValue.String "Units/armmav_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 696.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 196.0
                            LuaKey.String "object", LuaValue.String "Units/arm2x2e.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-small-impulse"
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
                            LuaKey.Int 1, LuaValue.String "mavbok1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "mavbsel1"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "armmav_weapon", LuaValue.Table [
                            LuaKey.String "alphadecay", LuaValue.Number 0.1
                            LuaKey.String "areaofeffect", LuaValue.Number 8.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "impulse-trail"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-small"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 1.1
                            LuaKey.String "name", LuaValue.String "Anti-swarm g2g gauss-impulse guns"
                            LuaKey.String "nogap", LuaValue.Bool false
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 0.3
                            LuaKey.String "range", LuaValue.Number 365.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.0
                            LuaKey.String "separation", LuaValue.Number 1.0
                            LuaKey.String "sizedecay", LuaValue.Number 0.01
                            LuaKey.String "soundhit", LuaValue.String "xplomed5"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "mavgun4"
                            LuaKey.String "stages", LuaValue.Number 12.0
                            LuaKey.String "tolerance", LuaValue.Number 4000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 265.0
                                    LuaKey.String "vtol", LuaValue.Number 65.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "ARMMAV_WEAPON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let armsack =
        LuaValue.Table [
            LuaKey.String "builddistance", LuaValue.Number 136.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "LEGACK.DDS"
            LuaKey.String "buildtime", LuaValue.Number 12000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "27 35 23"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 6900.0
            LuaKey.String "energymake", LuaValue.Number 14.0
            LuaKey.String "energystorage", LuaValue.Number 100.0
            LuaKey.String "explodeas", LuaValue.String "mediumexplosiongeneric-builder"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "health", LuaValue.Number 930.0
            LuaKey.String "maxacc", LuaValue.Number 0.4968
            LuaKey.String "maxdec", LuaValue.Number 3.105
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 25.0
            LuaKey.String "metalcost", LuaValue.Number 400.0
            LuaKey.String "movementclass", LuaValue.String "BOT2"
            LuaKey.String "objectname", LuaValue.String "Units/LEGACK.s3o"
            LuaKey.String "radardistance", LuaValue.Number 50.0
            LuaKey.String "script", LuaValue.String "Units/LEGACK.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumExplosionGenericSelfd-builder"
            LuaKey.String "sightdistance", LuaValue.Number 323.70001
            LuaKey.String "speed", LuaValue.Number 33.0
            LuaKey.String "terraformspeed", LuaValue.Number 900.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.759
            LuaKey.String "turnrate", LuaValue.Number 1138.5
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "workertime", LuaValue.Number 180.0
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "armafus"
                    LuaKey.Int 2, LuaValue.String "armageo"
                    LuaKey.Int 4, LuaValue.String "armmoho"
                    LuaKey.Int 5, LuaValue.String "armmmkr"
                    LuaKey.Int 6, LuaValue.String "armanni"
                    LuaKey.Int 7, LuaValue.String "armmercury"
                    LuaKey.Int 8, LuaValue.String "armsilo"
                    LuaKey.Int 9, LuaValue.String "armbrtha"
                    LuaKey.Int 10, LuaValue.String "armvulc"
                    LuaKey.Int 11, LuaValue.String "armlab"
                    LuaKey.Int 12, LuaValue.String "armalab"
                    LuaKey.Int 13, LuaValue.String "armsalab"
                    LuaKey.Int 14, LuaValue.String "armshltx"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Kaiser"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmBots/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "buildert2"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "1.64561462402 6.61621093734e-06 -1.44562530518"
                            LuaKey.String "collisionvolumescales", LuaValue.String "29.6044616699 29.4648132324 28.049697876"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 700.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 189.0
                            LuaKey.String "object", LuaValue.String "Units/armack_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 500.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 76.0
                            LuaKey.String "object", LuaValue.String "Units/arm2X2B.s3o"
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
                            LuaKey.Int 1, LuaValue.String "kbarmmov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "kbarmsel"
                        ]
                ]
        ]

    let armscab =
        LuaValue.Table [
            LuaKey.String "buildpic", LuaValue.String "ARMSCAB.DDS"
            LuaKey.String "buildtime", LuaValue.Number 49000.0
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 3 -1"
            LuaKey.String "collisionvolumescales", LuaValue.String "43 23 49"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "damagemodifier", LuaValue.Number 0.5
            LuaKey.String "energycost", LuaValue.Number 30000.0
            LuaKey.String "explodeas", LuaValue.String "largeexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 870.0
            LuaKey.String "maxacc", LuaValue.Number 0.03663
            LuaKey.String "maxdec", LuaValue.Number 0.07326
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 1150.0
            LuaKey.String "movementclass", LuaValue.String "TBOT3"
            LuaKey.String "movestate", LuaValue.Number 0.0
            LuaKey.String "noautofire", LuaValue.Bool true
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/ARMSCAB.s3o"
            LuaKey.String "radardistance", LuaValue.Number 50.0
            LuaKey.String "script", LuaValue.String "Units/ARMSCAB.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 450.0
            LuaKey.String "speed", LuaValue.Number 51.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.122
            LuaKey.String "turnrate", LuaValue.Number 473.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmBots/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "antinuke"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.0 -0.208756103516 6.21000671387"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.2154541016 21.362487793 50.6700134277"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 600.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 934.0
                            LuaKey.String "object", LuaValue.String "Units/armscab_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 500.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 374.0
                            LuaKey.String "object", LuaValue.String "Units/arm3X3D.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
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
                            LuaKey.Int 1, LuaValue.String "kbarmmov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "kbarmsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "armscab_weapon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 420.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "antimissiletrail"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "coverage", LuaValue.Number 1400.0
                            LuaKey.String "craterareaofeffect", LuaValue.Number 420.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 6500.0
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
                            LuaKey.String "smokeperiod", LuaValue.Number 9.0
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
                            LuaKey.String "weapontimer", LuaValue.Number 2.0
                            LuaKey.String "weapontype", LuaValue.String "StarburstLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 7000.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "stockpilelimit", LuaValue.Number 20.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 500.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "ALL"
                            LuaKey.String "def", LuaValue.String "ARMSCAB_WEAPON"
                        ]
                ]
        ]

    let armsnipe =
        LuaValue.Table [
            LuaKey.String "buildpic", LuaValue.String "ARMSNIPE.DDS"
            LuaKey.String "buildtime", LuaValue.Number 24000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "cloakcost", LuaValue.Number 75.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 200.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "30 44 30"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 20000.0
            LuaKey.String "explodeas", LuaValue.String "mediumexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "health", LuaValue.Number 580.0
            LuaKey.String "maxacc", LuaValue.Number 0.138
            LuaKey.String "maxdec", LuaValue.Number 0.6486
            LuaKey.String "maxslope", LuaValue.Number 14.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 22.0
            LuaKey.String "metalcost", LuaValue.Number 680.0
            LuaKey.String "mincloakdistance", LuaValue.Number 80.0
            LuaKey.String "movementclass", LuaValue.String "BOT2"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/ARMSNIPE.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMSNIPE.cob"
            LuaKey.String "selfdestructas", LuaValue.String "mediumExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 455.0
            LuaKey.String "speed", LuaValue.Number 33.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.7788
            LuaKey.String "turnrate", LuaValue.Number 1538.69995
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Kaiser"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmBots/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "30 12 44"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 400.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 322.0
                            LuaKey.String "object", LuaValue.String "Units/armsnipe_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 20"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 300.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 129.0
                            LuaKey.String "object", LuaValue.String "Units/arm2X2D.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-sniper"
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
                            LuaKey.Int 1, LuaValue.String "kbarmmov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "kbarmsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "armsnipe_weapon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool true
                            LuaKey.String "avoidfriendly", LuaValue.Bool true
                            LuaKey.String "beamtime", LuaValue.Number 0.1
                            LuaKey.String "collidefeature", LuaValue.Bool true
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "corethickness", LuaValue.Number 0.1
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.1
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 500.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-sniper"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.234
                            LuaKey.String "minintensity", LuaValue.Number 1.0
                            LuaKey.String "name", LuaValue.String "Long-range g2g armor-piercing rifle"
                            LuaKey.String "range", LuaValue.Number 900.0
                            LuaKey.String "reloadtime", LuaValue.Number 10.0
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.2 0"
                            LuaKey.String "rgbcolor2", LuaValue.String "1 1 1"
                            LuaKey.String "soundhit", LuaValue.String "sniperhit"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "sniper3"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "texture1", LuaValue.String "shot"
                            LuaKey.String "texture2", LuaValue.String "empty"
                            LuaKey.String "thickness", LuaValue.Number 0.0
                            LuaKey.String "tolerance", LuaValue.Number 1000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 3000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 1025.0
                                    LuaKey.String "default", LuaValue.Number 2500.0
                                ]
                        ]
                    LuaKey.String "old_armsnipe_weapon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.0025
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 500.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-sniper"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impactonly", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.234
                            LuaKey.String "intensity", LuaValue.Number 0.75
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 0.0
                            LuaKey.String "name", LuaValue.String "SniperWeapon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 900.0
                            LuaKey.String "reloadtime", LuaValue.Number 10.0
                            LuaKey.String "rgbcolor", LuaValue.String "1 1 0"
                            LuaKey.String "size", LuaValue.Number 0.1
                            LuaKey.String "soundhit", LuaValue.String "sniperhit"
                            LuaKey.String "soundhitvolume", LuaValue.Number 10.0
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "sniper3"
                            LuaKey.String "soundstartvolume", LuaValue.Number 20.0
                            LuaKey.String "thickness", LuaValue.Number 0.5
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 3000.0
                            LuaKey.String "customparams", LuaValue.Table []
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 1025.0
                                    LuaKey.String "default", LuaValue.Number 2500.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "OLD_ARMSNIPE_WEAPON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let armspid =
        LuaValue.Table [
            LuaKey.String "autoheal", LuaValue.Number 15.0
            LuaKey.String "builddistance", LuaValue.Number 150.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMSPID.DDS"
            LuaKey.String "buildtime", LuaValue.Number 7000.0
            LuaKey.String "canassist", LuaValue.Bool false
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canrepair", LuaValue.Bool false
            LuaKey.String "canrestore", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "28 15 28"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 5000.0
            LuaKey.String "explodeas", LuaValue.String "smallexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "health", LuaValue.Number 1110.0
            LuaKey.String "maxacc", LuaValue.Number 0.207
            LuaKey.String "maxdec", LuaValue.Number 0.6486
            LuaKey.String "maxwaterdepth", LuaValue.Number 16.0
            LuaKey.String "metalcost", LuaValue.Number 250.0
            LuaKey.String "movementclass", LuaValue.String "TBOT3"
            LuaKey.String "mygravity", LuaValue.Number 10000.0
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/ARMSPID.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMSPID.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "smallExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 550.0
            LuaKey.String "speed", LuaValue.Number 71.55
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "strafetoattack", LuaValue.Bool true
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.749
            LuaKey.String "turnrate", LuaValue.Number 1290.29993
            LuaKey.String "workertime", LuaValue.Number 150.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Kaiser"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.2
                    LuaKey.String "selectable_as_combat_unit", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "ArmBots/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "emp"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.0926513671875 -4.24316406278e-06 -0.909057617188"
                            LuaKey.String "collisionvolumescales", LuaValue.String "31.362487793 12.4340515137 31.2150268555"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 600.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 40.0
                            LuaKey.String "metal", LuaValue.Number 108.0
                            LuaKey.String "object", LuaValue.String "Units/armspid_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 400.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 43.0
                            LuaKey.String "object", LuaValue.String "Units/arm2X2A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
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
                            LuaKey.Int 1, LuaValue.String "spider2"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "spider"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "spider", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 8.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamdecay", LuaValue.Number 0.5
                            LuaKey.String "beamtime", LuaValue.Number 0.2
                            LuaKey.String "beamttl", LuaValue.Number 1.0
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "corethickness", LuaValue.Number 0.2
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.01
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-emp"
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 8.8
                            LuaKey.String "name", LuaValue.String "Close-quarters light EMP laser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "paralyzer", LuaValue.Bool true
                            LuaKey.String "paralyzetime", LuaValue.Number 9.0
                            LuaKey.String "range", LuaValue.Number 280.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.73333
                            LuaKey.String "rgbcolor", LuaValue.String "0.7 0.7 1"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "hackshot"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 1.2
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 800.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 850.0
                                    LuaKey.String "vtol", LuaValue.Number 225.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "SPIDER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "EMPABLE"
                        ]
                ]
        ]

    let armsptk =
        LuaValue.Table [
            LuaKey.String "buildpic", LuaValue.String "ARMSPTK.DDS"
            LuaKey.String "buildtime", LuaValue.Number 11500.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -2 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "42 28 42"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 4500.0
            LuaKey.String "explodeas", LuaValue.String "mediumexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 1390.0
            LuaKey.String "maxacc", LuaValue.Number 0.207
            LuaKey.String "maxdec", LuaValue.Number 0.6486
            LuaKey.String "maxwaterdepth", LuaValue.Number 12.0
            LuaKey.String "metalcost", LuaValue.Number 400.0
            LuaKey.String "movementclass", LuaValue.String "TBOT3"
            LuaKey.String "mygravity", LuaValue.Number 10000.0
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/ARMSPTK.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMSPTK.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 440.0
            LuaKey.String "speed", LuaValue.Number 47.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.1352
            LuaKey.String "turnrate", LuaValue.Number 1290.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.2
                    LuaKey.String "subfolder", LuaValue.String "ArmBots/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.13973236084 -4.67773437585e-06 -1.37111663818"
                            LuaKey.String "collisionvolumescales", LuaValue.String "47.3038787842 18.2459106445 47.0814971924"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 800.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 40.0
                            LuaKey.String "metal", LuaValue.Number 244.0
                            LuaKey.String "object", LuaValue.String "Units/armsptk_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 500.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 98.0
                            LuaKey.String "object", LuaValue.String "Units/arm3X3A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
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
                            LuaKey.Int 1, LuaValue.String "spider2"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "spider3"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "adv_rocket", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 90.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 3.0
                            LuaKey.String "burstrate", LuaValue.Number 0.3
                            LuaKey.String "castshadow", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "missiletrailsmall-simple"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.65
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-small-bomb"
                            LuaKey.String "firestarter", LuaValue.Number 70.0
                            LuaKey.String "flighttime", LuaValue.Number 3.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "cormissile2.s3o"
                            LuaKey.String "name", LuaValue.String "Parabolic trajectory g2g multi-rocket launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 575.0
                            LuaKey.String "reloadtime", LuaValue.Number 3.75
                            LuaKey.String "smokecolor", LuaValue.Number 0.5
                            LuaKey.String "smokeperiod", LuaValue.Number 7.0
                            LuaKey.String "smokesize", LuaValue.Number 6.5
                            LuaKey.String "smoketime", LuaValue.Number 21.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smoketrailcastshadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "rockhit3"
                            LuaKey.String "soundhitwet", LuaValue.String "splssml"
                            LuaKey.String "soundstart", LuaValue.String "rocksalvo"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "startvelocity", LuaValue.Number 80.0
                            LuaKey.String "targetmoveerror", LuaValue.Number 0.2
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailbar"
                            LuaKey.String "trajectoryheight", LuaValue.Number 0.5
                            LuaKey.String "turnrate", LuaValue.Number 6000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 70.0
                            LuaKey.String "weapontimer", LuaValue.Number 6.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 450.0
                            LuaKey.String "wobble", LuaValue.Number 2500.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "cruise_max_height", LuaValue.String "20"
                                    LuaKey.String "cruise_min_height", LuaValue.String "15"
                                    LuaKey.String "lockon_dist", LuaValue.String "150"
                                    LuaKey.String "overrange_distance", LuaValue.Number 600.0
                                    LuaKey.String "projectile_destruction_method", LuaValue.String "descend"
                                    LuaKey.String "speceffect", LuaValue.String "cruise"
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 200.0
                                    LuaKey.String "subs", LuaValue.Number 100.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "ADV_ROCKET"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let armspy =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "builddistance", LuaValue.Number 136.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMSPY.DDS"
            LuaKey.String "buildtime", LuaValue.Number 12000.0
            LuaKey.String "canassist", LuaValue.Bool false
            LuaKey.String "canguard", LuaValue.Bool false
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canrepair", LuaValue.Bool false
            LuaKey.String "canrestore", LuaValue.Bool false
            LuaKey.String "cloakcost", LuaValue.Number 15.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 40.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "26 28 15"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 8800.0
            LuaKey.String "explodeas", LuaValue.String "smallExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "health", LuaValue.Number 300.0
            LuaKey.String "maxacc", LuaValue.Number 0.276
            LuaKey.String "maxdec", LuaValue.Number 0.69
            LuaKey.String "maxslope", LuaValue.Number 32.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 112.0
            LuaKey.String "metalcost", LuaValue.Number 135.0
            LuaKey.String "mincloakdistance", LuaValue.Number 75.0
            LuaKey.String "movementclass", LuaValue.String "BOT2"
            LuaKey.String "movestate", LuaValue.Number 0.0
            LuaKey.String "objectname", LuaValue.String "Units/ARMSPY.s3o"
            LuaKey.String "onoffable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "Units/ARMSPY.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 2.0
            LuaKey.String "selfdestructas", LuaValue.String "SPYBOMBX"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 0.0
            LuaKey.String "sightdistance", LuaValue.Number 550.0
            LuaKey.String "sonarstealth", LuaValue.Bool true
            LuaKey.String "speed", LuaValue.Number 65.4
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.4388
            LuaKey.String "turnrate", LuaValue.Number 1581.25
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "workertime", LuaValue.Number 50.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.0
                    LuaKey.String "subfolder", LuaValue.String "ArmBots/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "buildert2"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "-0.497138977051 -0.20779847168 -1.07509613037"
                            LuaKey.String "collisionvolumescales", LuaValue.String "31.7495880127 18.5738830566 32.936630249"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 250.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 83.0
                            LuaKey.String "object", LuaValue.String "Units/armspy_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 150.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 33.0
                            LuaKey.String "object", LuaValue.String "Units/arm2X2D.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
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
                            LuaKey.Int 1, LuaValue.String "kbarmmov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "kbarmsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "crawl_dummy", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidground", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 128.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String ""
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "name", LuaValue.String "Dummy Weapon"
                            LuaKey.String "range", LuaValue.Number 100.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.1
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "tolerance", LuaValue.Number 100000.0
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Melee"
                            LuaKey.String "weaponvelocity", LuaValue.Number 100000.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "bogus", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 0.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "CRAWL_DUMMY"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let armvader =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMVADER.DDS"
            LuaKey.String "buildtime", LuaValue.Number 8000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 2 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "17 13 17"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "corpse", LuaValue.String "CORPSE"
            LuaKey.String "energycost", LuaValue.Number 5800.0
            LuaKey.String "explodeas", LuaValue.String "crawl_blastsml"
            LuaKey.String "firestate", LuaValue.Number 0.0
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "health", LuaValue.Number 445.0
            LuaKey.String "mass", LuaValue.Number 749.0
            LuaKey.String "maxacc", LuaValue.Number 0.1518
            LuaKey.String "maxdec", LuaValue.Number 0.5589
            LuaKey.String "maxslope", LuaValue.Number 32.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 112.0
            LuaKey.String "metalcost", LuaValue.Number 65.0
            LuaKey.String "movementclass", LuaValue.String "ABOTBOMB2"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/ARMVADER.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMVADER.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "crawl_blast"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 0.0
            LuaKey.String "sightdistance", LuaValue.Number 273.0
            LuaKey.String "speed", LuaValue.Number 84.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.848
            LuaKey.String "turnrate", LuaValue.Number 1771.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "instantselfd", LuaValue.Bool true
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmBots/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "explo"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "corpse", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "damage", LuaValue.Number 300.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 1.0
                            LuaKey.String "footprintz", LuaValue.Number 1.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 49.0
                            LuaKey.String "object", LuaValue.String "Units/armvader_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "21.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 200.0
                            LuaKey.String "footprintx", LuaValue.Number 1.0
                            LuaKey.String "footprintz", LuaValue.Number 1.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 12.0
                            LuaKey.String "object", LuaValue.String "Units/arm1X1B.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
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
                            LuaKey.Int 1, LuaValue.String "servsml5"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "servsml5"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "crawl_detonator", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 5.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String ""
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "name", LuaValue.String "Self-destruction"
                            LuaKey.String "range", LuaValue.Number 1.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.1
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "crawlingbombs", LuaValue.Number 1000.0
                                    LuaKey.String "default", LuaValue.Number 1000.0
                                ]
                        ]
                    LuaKey.String "crawl_dummy", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidground", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 128.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String ""
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "name", LuaValue.String "Crawlingbomb Dummy Weapon"
                            LuaKey.String "range", LuaValue.Number 42.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.1
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "tolerance", LuaValue.Number 100000.0
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Melee"
                            LuaKey.String "weaponvelocity", LuaValue.Number 100000.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "bogus", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 0.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "CRAWL_DUMMY"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "CRAWL_DETONATOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let armzeus =
        LuaValue.Table [
            LuaKey.String "buildpic", LuaValue.String "ARMZEUS.DDS"
            LuaKey.String "buildtime", LuaValue.Number 9500.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "35 36 35"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 6100.0
            LuaKey.String "explodeas", LuaValue.String "mediumexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 2950.0
            LuaKey.String "maxacc", LuaValue.Number 0.138
            LuaKey.String "maxdec", LuaValue.Number 0.8625
            LuaKey.String "maxslope", LuaValue.Number 15.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 23.0
            LuaKey.String "metalcost", LuaValue.Number 350.0
            LuaKey.String "movementclass", LuaValue.String "BOT3"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/ARMZEUS.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMZEUS.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 331.5
            LuaKey.String "speed", LuaValue.Number 47.4
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.0428
            LuaKey.String "turnrate", LuaValue.Number 1214.40002
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "FireStorm, FLaka"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmBots/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "39.0425720215 11.3397369385 32.5729980469"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1300.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 214.0
                            LuaKey.String "object", LuaValue.String "Units/armzeus_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 800.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 86.0
                            LuaKey.String "object", LuaValue.String "Units/arm2X2E.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-lightning"
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
                            LuaKey.Int 1, LuaValue.String "kbarmmov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "kbarmsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
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
                            LuaKey.String "name", LuaValue.String "Close-quarters g2g lightning rifle"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 280.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.7
                            LuaKey.String "rgbcolor", LuaValue.String "0.5 0.5 1"
                            LuaKey.String "soundhit", LuaValue.String "xplomed3"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lghthvy1"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "thickness", LuaValue.Number 1.5
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LightningCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 400.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "spark_ceg", LuaValue.String "genericshellexplosion-splash-lightning"
                                    LuaKey.String "spark_forkdamage", LuaValue.String "0.33"
                                    LuaKey.String "spark_maxunits", LuaValue.String "2"
                                    LuaKey.String "spark_range", LuaValue.String "60"
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 22.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "LIGHTNING"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let all : (string * LuaValue) list =
        [
            "armaak", armaak
            "armack", armack
            "armamph", armamph
            "armaser", armaser
            "armdecom", armdecom
            "armfark", armfark
            "armfast", armfast
            "armfboy", armfboy
            "armfido", armfido
            "armhack", armhack
            "armmark", armmark
            "armmav", armmav
            "armsack", armsack
            "armscab", armscab
            "armsnipe", armsnipe
            "armspid", armspid
            "armsptk", armsptk
            "armspy", armspy
            "armvader", armvader
            "armzeus", armzeus
        ]
