// Auto-generated BAR unit data: Legion/Ships/T2
namespace BarData.Units

open BarData

module Legion_Ships_T2 =

    let leganavyaaship =
        LuaValue.Table [
            LuaKey.String "airsightdistance", LuaValue.Number 900.0
            LuaKey.String "buildangle", LuaValue.Number 16384.0
            LuaKey.String "buildpic", LuaValue.String "leganavyaaship.DDS"
            LuaKey.String "buildtime", LuaValue.Number 20100.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "38 35 85"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylZ"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 12000.0
            LuaKey.String "explodeas", LuaValue.String "mediumexplosiongeneric"
            LuaKey.String "floater", LuaValue.Bool true
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 3900.0
            LuaKey.String "maxacc", LuaValue.Number 0.03
            LuaKey.String "maxdec", LuaValue.Number 0.03
            LuaKey.String "metalcost", LuaValue.Number 1000.0
            LuaKey.String "minwaterdepth", LuaValue.Number 30.0
            LuaKey.String "movementclass", LuaValue.String "BOAT4"
            LuaKey.String "movestate", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "NOTAIR"
            LuaKey.String "objectname", LuaValue.String "Units/leganavyaaship.s3o"
            LuaKey.String "script", LuaValue.String "Units/leganavyaaship.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumexplosiongenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 465.0
            LuaKey.String "speed", LuaValue.Number 57.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 320.0
            LuaKey.String "waterline", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies, Tharsis (AA Guns)"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Legion/Ships/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "aa"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "38 25 85"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 2940.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 500.0
                            LuaKey.String "object", LuaValue.String "Units/leganavyaaship_dead.s3o"
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
                            LuaKey.String "metal", LuaValue.Number 250.0
                            LuaKey.String "object", LuaValue.String "Units/cor4X4A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-flak"
                            LuaKey.Int 2, LuaValue.String "custom:waterwake-medium"
                            LuaKey.Int 3, LuaValue.String "custom:bowsplash-medium"
                            LuaKey.Int 4, LuaValue.String "custom:barrelshot-tiny-aa"
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
                            LuaKey.Int 1, LuaValue.String "shcormov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "shcorsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "light_antiair_missile", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 3.0
                            LuaKey.String "burstrate", LuaValue.Number 0.005
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "dance", LuaValue.Number 150.0
                            LuaKey.String "cegtag", LuaValue.String "missiletrailaa"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-tiny-aa"
                            LuaKey.String "firestarter", LuaValue.Number 72.0
                            LuaKey.String "flighttime", LuaValue.Number 2.5
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "legsmallrocket.s3o"
                            LuaKey.String "name", LuaValue.String "Advanced Anti-Air Salvo Missile Launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 860.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokecolor", LuaValue.Number 0.95
                            LuaKey.String "smokeperiod", LuaValue.Number 5.0
                            LuaKey.String "smokesize", LuaValue.Number 0.5
                            LuaKey.String "smoketime", LuaValue.Number 5.0
                            LuaKey.String "smokeTrailCastShadow", LuaValue.Bool false
                            LuaKey.String "castshadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "packohit"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "packolau"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "startvelocity", LuaValue.Number 800.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailaa"
                            LuaKey.String "tolerance", LuaValue.Number 9950.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 68000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "fixedlauncher", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 300.0
                            LuaKey.String "weapontimer", LuaValue.Number 2.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "vtol", LuaValue.Number 20.0
                                ]
                        ]
                    LuaKey.String "leg_t2_microflak_mobile", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 1000.0
                            LuaKey.String "areaofeffect", LuaValue.Number 35.0
                            LuaKey.String "burst", LuaValue.Number 3.0
                            LuaKey.String "burstrate", LuaValue.Number 0.02
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "flaktrailaamg"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 35.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 1.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:flakshard"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "name", LuaValue.String "Dual Rotary Microflak Cannons"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 800.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.166
                            LuaKey.String "size", LuaValue.Number 0.0
                            LuaKey.String "sizedecay", LuaValue.Number 0.08
                            LuaKey.String "soundhit", LuaValue.String "flakhit"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "flakfire"
                            LuaKey.String "stages", LuaValue.Number 0.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 1.0
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1900.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "norangering", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "vtol", LuaValue.Number 40.0
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
                            LuaKey.String "badtargetcategory", LuaValue.String "LIGHTAIRSCOUT"
                            LuaKey.String "burstcontrolwhenoutofarc", LuaValue.Number 2.0
                            LuaKey.String "def", LuaValue.String "leg_t2_microflak_mobile"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR"
                            LuaKey.String "def", LuaValue.String "light_antiair_missile"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR"
                            LuaKey.String "def", LuaValue.String "light_antiair_missile"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                ]
        ]

    let leganavyantinukecarrier =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildangle", LuaValue.Number 16384.0
            LuaKey.String "buildpic", LuaValue.String "leganavyantinukecarrier.DDS"
            LuaKey.String "buildtime", LuaValue.Number 26800.0
            LuaKey.String "canassist", LuaValue.Bool false
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canreclaim", LuaValue.Bool false
            LuaKey.String "canrepair", LuaValue.Bool false
            LuaKey.String "canrestore", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "59 52 154"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylZ"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 13000.0
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
            LuaKey.String "metalcost", LuaValue.Number 1600.0
            LuaKey.String "minwaterdepth", LuaValue.Number 15.0
            LuaKey.String "movementclass", LuaValue.String "BOAT5"
            LuaKey.String "movestate", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/leganavyantinukecarrier.s3o"
            LuaKey.String "radardistance", LuaValue.Number 1500.0
            LuaKey.String "radaremitheight", LuaValue.Number 56.0
            LuaKey.String "script", LuaValue.String "Units/leganavyantinukecarrier.cob"
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
                    LuaKey.String "maxrange", LuaValue.Number 1300.0
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Legion/Ships/T2"
                    LuaKey.String "inheritxpratemultiplier", LuaValue.Number 1.0
                    LuaKey.String "childreninheritxp", LuaValue.String "DRONE"
                    LuaKey.String "parentsinheritxp", LuaValue.String "DRONE"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "antinuke"
                    LuaKey.String "restrictions_exclusion", LuaValue.String "_noantinuke_"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "59 42 154"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 9168.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 700.0
                            LuaKey.String "object", LuaValue.String "Units/leganavyantinukecarrier_dead.s3o"
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
                    LuaKey.String "leg_drone_controller", LuaValue.Table [
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
                            LuaKey.String "name", LuaValue.String "Multi-Drone Control Matrix"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "metalpershot", LuaValue.Number 15.0
                            LuaKey.String "energypershot", LuaValue.Number 500.0
                            LuaKey.String "range", LuaValue.Number 1300.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.5
                            LuaKey.String "size", LuaValue.Number 0.0
                            LuaKey.String "soundhit", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String ""
                            LuaKey.String "soundstart", LuaValue.String ""
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 0.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "carried_unit", LuaValue.String "legdrone"
                                    LuaKey.String "engagementrange", LuaValue.Number 1350.0
                                    LuaKey.String "spawnrate", LuaValue.Number 7.0
                                    LuaKey.String "maxunits", LuaValue.Number 6.0
                                    LuaKey.String "startingdronecount", LuaValue.Number 3.0
                                    LuaKey.String "energycost", LuaValue.Number 500.0
                                    LuaKey.String "metalcost", LuaValue.Number 15.0
                                    LuaKey.String "controlradius", LuaValue.Number 1200.0
                                    LuaKey.String "deathdecayrate", LuaValue.Number 20.0
                                    LuaKey.String "carrierdeaththroe", LuaValue.String "release"
                                    LuaKey.String "dockingarmor", LuaValue.Number 0.2
                                    LuaKey.String "dockinghealrate", LuaValue.Number 30.0
                                    LuaKey.String "docktohealthreshold", LuaValue.Number 75.0
                                    LuaKey.String "enabledocking", LuaValue.Bool true
                                    LuaKey.String "dockingHelperSpeed", LuaValue.Number 5.0
                                    LuaKey.String "dockingpieces", LuaValue.String "16 17 18 19 20 21"
                                    LuaKey.String "dockingradius", LuaValue.Number 80.0
                                    LuaKey.String "dronedocktime", LuaValue.Number 2.0
                                    LuaKey.String "droneairtime", LuaValue.Number 60.0
                                    LuaKey.String "droneammo", LuaValue.Number 12.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "ALL"
                            LuaKey.String "def", LuaValue.String "amd_rocket"
                        ]
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "leg_drone_controller"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let leganavyantiswarm =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "blocking", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "leganavyantiswarm.DDS"
            LuaKey.String "buildtime", LuaValue.Number 11270.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 4"
            LuaKey.String "collisionvolumescales", LuaValue.String "28 30 82"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 8500.0
            LuaKey.String "explodeas", LuaValue.String "mediumExplosionGeneric"
            LuaKey.String "floater", LuaValue.Bool true
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 2300.0
            LuaKey.String "maxacc", LuaValue.Number 0.07
            LuaKey.String "maxdec", LuaValue.Number 0.07
            LuaKey.String "metalcost", LuaValue.Number 500.0
            LuaKey.String "minwaterdepth", LuaValue.Number 6.0
            LuaKey.String "movementclass", LuaValue.String "BOAT4"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL UNDERWATER"
            LuaKey.String "objectname", LuaValue.String "Units/leganavyantiswarm.s3o"
            LuaKey.String "radardistance", LuaValue.Number 750.0
            LuaKey.String "radaremitheight", LuaValue.Number 52.0
            LuaKey.String "script", LuaValue.String "Units/leganavyantiswarm.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 500.0
            LuaKey.String "speed", LuaValue.Number 105.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 500.0
            LuaKey.String "waterline", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "EnderRobo"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Legion/Ships/T2"
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
                            LuaKey.String "object", LuaValue.String "Units/leganavyantiswarm_dead.s3o"
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
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-small-impulse"
                            LuaKey.Int 2, LuaValue.String "custom:barrelshot-tiny-aa"
                            LuaKey.Int 3, LuaValue.String "custom:waterwake-small"
                            LuaKey.Int 4, LuaValue.String "custom:bowsplash-small"
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
                    LuaKey.String "legion_riot_cannon_t2", LuaValue.Table [
                            LuaKey.String "tolerace", LuaValue.Number 3000.0
                            LuaKey.String "firetolerance", LuaValue.Number 3000.0
                            LuaKey.String "areaofeffect", LuaValue.Number 144.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.9
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large"
                            LuaKey.String "impulsefactor", LuaValue.Number 2.5
                            LuaKey.String "name", LuaValue.String "Medium Blast Riot Cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 350.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.1
                            LuaKey.String "soundhit", LuaValue.String "corlevlrhit"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "largegun"
                            LuaKey.String "soundhitvolume", LuaValue.Number 12.0
                            LuaKey.String "soundstartvolume", LuaValue.Number 14.0
                            LuaKey.String "separation", LuaValue.Number 2.0
                            LuaKey.String "nogap", LuaValue.Bool false
                            LuaKey.String "size", LuaValue.Number 4.0
                            LuaKey.String "sizeDecay", LuaValue.Number 0.07
                            LuaKey.String "stages", LuaValue.Number 10.0
                            LuaKey.String "alphaDecay", LuaValue.Number 0.1
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 700.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 210.0
                                    LuaKey.String "subs", LuaValue.Number 90.0
                                    LuaKey.String "vtol", LuaValue.Number 35.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table []
                        ]
                    LuaKey.String "light_antiair_missile", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 3.0
                            LuaKey.String "burstrate", LuaValue.Number 0.005
                            LuaKey.String "dance", LuaValue.Number 150.0
                            LuaKey.String "cegtag", LuaValue.String "missiletrailaa"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-tiny-aa"
                            LuaKey.String "firestarter", LuaValue.Number 72.0
                            LuaKey.String "flighttime", LuaValue.Number 2.5
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "legsmallrocket.s3o"
                            LuaKey.String "name", LuaValue.String "Advanced g2a Salvo Missile Launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 760.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.2
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokecolor", LuaValue.Number 0.95
                            LuaKey.String "smokeperiod", LuaValue.Number 5.0
                            LuaKey.String "smokesize", LuaValue.Number 0.5
                            LuaKey.String "smoketime", LuaValue.Number 5.0
                            LuaKey.String "smokeTrailCastShadow", LuaValue.Bool false
                            LuaKey.String "castshadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "packohit"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "packolau"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "startvelocity", LuaValue.Number 800.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailaa"
                            LuaKey.String "tolerance", LuaValue.Number 9950.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 68000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 300.0
                            LuaKey.String "weapontimer", LuaValue.Number 2.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "vtol", LuaValue.Number 24.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "legion_riot_cannon_t2"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "light_antiair_missile"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let leganavyartyship =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildangle", LuaValue.Number 16384.0
            LuaKey.String "buildpic", LuaValue.String "leganavyartyship.DDS"
            LuaKey.String "buildtime", LuaValue.Number 204750.0
            LuaKey.String "canattackground", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "79 80 200"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylZ"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 125000.0
            LuaKey.String "explodeas", LuaValue.String "flagshipExplosion"
            LuaKey.String "floater", LuaValue.Bool true
            LuaKey.String "footprintx", LuaValue.Number 8.0
            LuaKey.String "footprintz", LuaValue.Number 8.0
            LuaKey.String "health", LuaValue.Number 22000.0
            LuaKey.String "mass", LuaValue.Number 9999999.0
            LuaKey.String "maxacc", LuaValue.Number 0.01
            LuaKey.String "maxdec", LuaValue.Number 0.01
            LuaKey.String "metalcost", LuaValue.Number 13000.0
            LuaKey.String "minwaterdepth", LuaValue.Number 15.0
            LuaKey.String "movementclass", LuaValue.String "BOAT9"
            LuaKey.String "movestate", LuaValue.Number 0.0
            LuaKey.String "objectname", LuaValue.String "Units/leganavyartyship.s3o"
            LuaKey.String "radardistance", LuaValue.Number 1530.0
            LuaKey.String "radaremitheight", LuaValue.Number 52.0
            LuaKey.String "script", LuaValue.String "Units/leganavyartyship.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "flagshipExplosionSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 689.0
            LuaKey.String "sightemitheight", LuaValue.Number 52.0
            LuaKey.String "speed", LuaValue.Number 48.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 125.0
            LuaKey.String "waterline", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Legion/Ships/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "79 65 200"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 85500.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 18.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 8500.0
                            LuaKey.String "object", LuaValue.String "Units/leganavyartyship_dead.s3o"
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
                            LuaKey.Int 0, LuaValue.String "custom:barrelshot-medium"
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-larger"
                            LuaKey.Int 2, LuaValue.String "custom:waterwake-huge"
                            LuaKey.Int 3, LuaValue.String "custom:bowsplash-huge"
                            LuaKey.Int 4, LuaValue.String "custom:enginespurt-huge"
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
                    LuaKey.String "leg_mobile_cluster_lrpc_cannon", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 300.0
                            LuaKey.String "sprayangle", LuaValue.Number 600.0
                            LuaKey.String "areaofeffect", LuaValue.Number 150.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "starfire_arty"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 116.0
                            LuaKey.String "craterboost", LuaValue.Number 0.1
                            LuaKey.String "cratermult", LuaValue.Number 0.1
                            LuaKey.String "burst", LuaValue.Number 4.0
                            LuaKey.String "burstrate", LuaValue.Number 0.2
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 2500.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:starfire-explosion"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "heightboostfactor", LuaValue.Number 8.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "leadbonus", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "legbomb.s3o"
                            LuaKey.String "name", LuaValue.String "Dual Quad-Barrelled Long-Range Cluster Plasma Cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 2100.0
                            LuaKey.String "reloadtime", LuaValue.Number 8.4
                            LuaKey.String "soundhit", LuaValue.String "lrpcexplo"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "lrpcshot3"
                            LuaKey.String "soundhitvolume", LuaValue.Number 38.0
                            LuaKey.String "soundstartvolume", LuaValue.Number 24.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 600.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "cluster_def", LuaValue.String "cluster_munition_main"
                                    LuaKey.String "cluster_number", LuaValue.Number 5.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 350.0
                                    LuaKey.String "subs", LuaValue.Number 50.0
                                ]
                        ]
                    LuaKey.String "cluster_munition_main", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 115.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "ministarfire"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.3
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:ministarfire-explosion"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "name", LuaValue.String "Plasma Cluster Burst"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "maxvelocity", LuaValue.Number 720.0
                            LuaKey.String "range", LuaValue.Number 110.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.7 0.7 1.0"
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy5"
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "reloadtime", LuaValue.Number 11.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 105.0
                                    LuaKey.String "subs", LuaValue.Number 25.0
                                    LuaKey.String "vtol", LuaValue.Number 25.0
                                ]
                        ]
                    LuaKey.String "leg_mobile_cluster_plasma", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 50.0
                            LuaKey.String "areaofeffect", LuaValue.Number 120.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidneutral", LuaValue.Bool true
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "starfire_tiny"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.4
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:ministarfire-explosion"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "name", LuaValue.String "Heavy Artillery Cluster Plasma Cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1600.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.8
                            LuaKey.String "rgbcolor", LuaValue.String "0.7 0.7 1.0"
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy5"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 500.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "cluster_def", LuaValue.String "cluster_munition_secondary"
                                    LuaKey.String "cluster_number", LuaValue.Number 4.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 250.0
                                    LuaKey.String "lboats", LuaValue.Number 250.0
                                    LuaKey.String "subs", LuaValue.Number 55.0
                                    LuaKey.String "vtol", LuaValue.Number 55.0
                                ]
                        ]
                    LuaKey.String "cluster_munition_secondary", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 115.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "ministarfire"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.3
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:ministarfire-explosion"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "name", LuaValue.String "Plasma Cluster Burst"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 100.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.7 0.7 1.0"
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy5"
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 105.0
                                    LuaKey.String "lboats", LuaValue.Number 105.0
                                    LuaKey.String "subs", LuaValue.Number 15.0
                                    LuaKey.String "vtol", LuaValue.Number 15.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "MOBILE"
                            LuaKey.String "def", LuaValue.String "leg_mobile_cluster_lrpc_cannon"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "leg_mobile_cluster_plasma"
                            LuaKey.String "maindir", LuaValue.String "-0.342 0 0.940"
                            LuaKey.String "maxangledif", LuaValue.Number 280.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "leg_mobile_cluster_plasma"
                            LuaKey.String "maindir", LuaValue.String "0.259 0 0.966"
                            LuaKey.String "maxangledif", LuaValue.Number 320.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "leg_mobile_cluster_plasma"
                            LuaKey.String "maindir", LuaValue.String "-0.174 0 0.985"
                            LuaKey.String "maxangledif", LuaValue.Number 330.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let leganavybattleship =
        LuaValue.Table [
            LuaKey.String "buildangle", LuaValue.Number 16000.0
            LuaKey.String "buildpic", LuaValue.String "leganavybattleship.DDS"
            LuaKey.String "buildtime", LuaValue.Number 49350.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -15 -2"
            LuaKey.String "collisionvolumescales", LuaValue.String "48 48 120"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylZ"
            LuaKey.String "usePieceCollisionVolumes", LuaValue.Bool true
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 21000.0
            LuaKey.String "explodeas", LuaValue.String "hugeexplosiongeneric"
            LuaKey.String "floater", LuaValue.Bool true
            LuaKey.String "footprintx", LuaValue.Number 7.0
            LuaKey.String "footprintz", LuaValue.Number 7.0
            LuaKey.String "health", LuaValue.Number 10350.0
            LuaKey.String "maxacc", LuaValue.Number 0.005
            LuaKey.String "maxdec", LuaValue.Number 0.005
            LuaKey.String "metalcost", LuaValue.Number 2900.0
            LuaKey.String "minwaterdepth", LuaValue.Number 15.0
            LuaKey.String "movementclass", LuaValue.String "HOVER7"
            LuaKey.String "movestate", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/leganavybattleship.s3o"
            LuaKey.String "script", LuaValue.String "Units/leganavybattleship.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "hugeexplosiongenericSelfD"
            LuaKey.String "sightdistance", LuaValue.Number 600.0
            LuaKey.String "speed", LuaValue.Number 25.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 90.0
            LuaKey.String "waterline", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Legion/Ships/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "speedfactorinwater", LuaValue.Number 2.6
                    LuaKey.String "speedfactoratdepth", LuaValue.Number 15.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -15 -2"
                            LuaKey.String "collisionvolumescales", LuaValue.String "48 38 120"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylZ"
                            LuaKey.String "damage", LuaValue.Number 13662.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 1650.0
                            LuaKey.String "object", LuaValue.String "Units/leganavybattleship_dead.s3o"
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
                            LuaKey.String "object", LuaValue.String "Units/cor6X6C.s3o"
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
                            LuaKey.Int 1, LuaValue.String "shcormov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "shcorsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "burst_plasma_t2", LuaValue.Table [
                            LuaKey.String "burstrate", LuaValue.Number 0.066
                            LuaKey.String "burst", LuaValue.Number 3.0
                            LuaKey.String "areaofeffect", LuaValue.Number 200.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "name", LuaValue.String "Heavy long-range g2g plasma cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 750.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.7
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy1"
                            LuaKey.String "sprayangle", LuaValue.Number 750.0
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 440.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 270.0
                                    LuaKey.String "vtol", LuaValue.Number 65.0
                                ]
                        ]
                    LuaKey.String "land_burst_plasma_t2", LuaValue.Table [
                            LuaKey.String "burstrate", LuaValue.Number 0.066
                            LuaKey.String "burst", LuaValue.Number 3.0
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
                            LuaKey.String "range", LuaValue.Number 700.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.4
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy1"
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 470.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 300.0
                                    LuaKey.String "vtol", LuaValue.Number 65.0
                                ]
                        ]
                    LuaKey.String "legion_shotgun", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 7.0
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "projectiles", LuaValue.Number 10.0
                            LuaKey.String "burnblow", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.015
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.85
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:plasmahit-sparkonly"
                            LuaKey.String "fallOffRate", LuaValue.Number 0.2
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "impulsefactor", LuaValue.Number 2.9
                            LuaKey.String "intensity", LuaValue.Number 1.0
                            LuaKey.String "name", LuaValue.String "Medium Shotgun"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "ownerExpAccWeight", LuaValue.Number 4.0
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 500.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.0
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.95 0.4"
                            LuaKey.String "soundhit", LuaValue.String "bimpact3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "kroggie2xs"
                            LuaKey.String "soundstartvolume", LuaValue.Number 3.0
                            LuaKey.String "sprayangle", LuaValue.Number 950.0
                            LuaKey.String "texture1", LuaValue.String "shot"
                            LuaKey.String "texture2", LuaValue.String "empty"
                            LuaKey.String "thickness", LuaValue.Number 2.0
                            LuaKey.String "tolerance", LuaValue.Number 6000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "cylindertargeting", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 800.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 20.0
                                    LuaKey.String "vtol", LuaValue.Number 6.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "burst_plasma_t2"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                            LuaKey.String "burstControlWhenOutOfArc", LuaValue.Number 2.0
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "burst_plasma_t2"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                            LuaKey.String "burstControlWhenOutOfArc", LuaValue.Number 2.0
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "LEGION_SHOTGUN"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "LEGION_SHOTGUN"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let leganavybattlesub =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "leganavybattlesub.DDS"
            LuaKey.String "buildtime", LuaValue.Number 25000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 5 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "40 26 64"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 16000.0
            LuaKey.String "explodeas", LuaValue.String "mediumExplosionGeneric-uw"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 2350.0
            LuaKey.String "maxacc", LuaValue.Number 0.0425
            LuaKey.String "maxdec", LuaValue.Number 0.0425
            LuaKey.String "metalcost", LuaValue.Number 1100.0
            LuaKey.String "minwaterdepth", LuaValue.Number 15.0
            LuaKey.String "movementclass", LuaValue.String "UBOAT4"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/leganavybattlesub.s3o"
            LuaKey.String "script", LuaValue.String "Units/leganavybattlesub.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumExplosionGenericSelfd-uw"
            LuaKey.String "sightdistance", LuaValue.Number 450.0
            LuaKey.String "sonardistance", LuaValue.Number 500.0
            LuaKey.String "speed", LuaValue.Number 72.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 360.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "waterline", LuaValue.Number 40.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Model by Tharsis, Concept by Chris/Airnac"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "legion/Navy/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "sub"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "1.25 0.0 0.0374984741211"
                            LuaKey.String "collisionvolumescales", LuaValue.String "20.0 15.5 55.0749969482"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1362.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 375.0
                            LuaKey.String "object", LuaValue.String "Units/leganavybattlesub_dead.s3o"
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
                            LuaKey.String "metal", LuaValue.Number 187.0
                            LuaKey.String "object", LuaValue.String "Units/cor2X2A.s3o"
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
                            LuaKey.Int 1, LuaValue.String "sucormov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "sucorsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "torpedo_swarm", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "burst", LuaValue.Number 3.0
                            LuaKey.String "burstrate", LuaValue.Number 0.33
                            LuaKey.String "cegtag", LuaValue.String "torpedotrail-small"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-uw"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "legtorpedomini.s3o"
                            LuaKey.String "name", LuaValue.String "Packhound Torpedo System"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 600.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.5
                            LuaKey.String "soundhit", LuaValue.String "xplodep1"
                            LuaKey.String "soundhitvolume", LuaValue.Number 18.0
                            LuaKey.String "soundstart", LuaValue.String "torpedo1"
                            LuaKey.String "startvelocity", LuaValue.Number 200.0
                            LuaKey.String "tolerance", LuaValue.Number 9000.0
                            LuaKey.String "tracks", LuaValue.Bool false
                            LuaKey.String "turret", LuaValue.Bool false
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 10.0
                            LuaKey.String "weapontimer", LuaValue.Number 2.0
                            LuaKey.String "weapontype", LuaValue.String "TorpedoLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 250.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 150.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "HOVER NOTSHIP"
                            LuaKey.String "def", LuaValue.String "TORPEDO_SWARM"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 180.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTHOVER"
                        ]
                ]
        ]

    let leganavycruiser =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildangle", LuaValue.Number 16384.0
            LuaKey.String "buildpic", LuaValue.String "leganavycruiser.DDS"
            LuaKey.String "buildtime", LuaValue.Number 20290.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "38 55 100"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 10800.0
            LuaKey.String "explodeas", LuaValue.String "largeexplosiongeneric"
            LuaKey.String "floater", LuaValue.Bool true
            LuaKey.String "footprintx", LuaValue.Number 5.0
            LuaKey.String "footprintz", LuaValue.Number 5.0
            LuaKey.String "health", LuaValue.Number 5600.0
            LuaKey.String "maxacc", LuaValue.Number 0.028
            LuaKey.String "maxdec", LuaValue.Number 0.028
            LuaKey.String "metalcost", LuaValue.Number 900.0
            LuaKey.String "minwaterdepth", LuaValue.Number 30.0
            LuaKey.String "movementclass", LuaValue.String "BOAT5"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/leganavycruiser.s3o"
            LuaKey.String "script", LuaValue.String "Units/leganavycruiser.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeexplosiongenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 600.0
            LuaKey.String "sonardistance", LuaValue.Number 375.0
            LuaKey.String "speed", LuaValue.Number 57.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 270.0
            LuaKey.String "waterline", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Legion/Ships/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "weaponsub"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "38 45 100"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 5578.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 5.0
                            LuaKey.String "footprintz", LuaValue.Number 5.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 500.0
                            LuaKey.String "object", LuaValue.String "Units/leganavycruiser_dead.s3o"
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
                            LuaKey.String "object", LuaValue.String "Units/cor2X2A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:waterwake-medium"
                            LuaKey.Int 2, LuaValue.String "custom:bowsplash-medium"
                            LuaKey.Int 3, LuaValue.String "custom:barrelshot-small"
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
                            LuaKey.Int 1, LuaValue.String "shcormov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "shcorsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "advanced_shotgun", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 7.0
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "projectiles", LuaValue.Number 10.0
                            LuaKey.String "burnblow", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.015
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.85
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:plasmahit-sparkonly"
                            LuaKey.String "fallOffRate", LuaValue.Number 0.2
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "impulsefactor", LuaValue.Number 1.5
                            LuaKey.String "intensity", LuaValue.Number 0.8
                            LuaKey.String "name", LuaValue.String "Dual Heavy Assault Kinetic Shotgun"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "ownerExpAccWeight", LuaValue.Number 4.0
                            LuaKey.String "proximitypriority", LuaValue.Number 10.0
                            LuaKey.String "range", LuaValue.Number 420.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.2
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.95 0.4"
                            LuaKey.String "soundhit", LuaValue.String "bimpact3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "kroggie2xs"
                            LuaKey.String "soundstartvolume", LuaValue.Number 3.0
                            LuaKey.String "sprayangle", LuaValue.Number 1900.0
                            LuaKey.String "thickness", LuaValue.Number 0.6
                            LuaKey.String "tolerance", LuaValue.Number 6000.0
                            LuaKey.String "firetolerance", LuaValue.Number 6000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 969.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 50.0
                                    LuaKey.String "vtol", LuaValue.Number 25.0
                                ]
                        ]
                    LuaKey.String "standard_minigun", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 2.0
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 6.0
                            LuaKey.String "burstrate", LuaValue.Number 0.066
                            LuaKey.String "burnblow", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.038
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.85
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:plasmahit-sparkonly"
                            LuaKey.String "fallOffRate", LuaValue.Number 0.2
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "impulsefactor", LuaValue.Number 1.5
                            LuaKey.String "intensity", LuaValue.Number 0.8
                            LuaKey.String "name", LuaValue.String "Dual Rotary Machine Guns"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "ownerExpAccWeight", LuaValue.Number 4.0
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 600.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.4
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.95 0.4"
                            LuaKey.String "soundhit", LuaValue.String "bimpact3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "mgun6heavy"
                            LuaKey.String "soundstartvolume", LuaValue.Number 4.5
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "sprayangle", LuaValue.Number 650.0
                            LuaKey.String "texture1", LuaValue.String "shot"
                            LuaKey.String "texture2", LuaValue.String "empty"
                            LuaKey.String "thickness", LuaValue.Number 3.0
                            LuaKey.String "tolerance", LuaValue.Number 3000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1100.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 10.0
                                    LuaKey.String "vtol", LuaValue.Number 10.0
                                ]
                        ]
                    LuaKey.String "mg_guns", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 7.0
                            LuaKey.String "areaofeffect", LuaValue.Number 32.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 6.0
                            LuaKey.String "burstrate", LuaValue.Number 0.066
                            LuaKey.String "burnblow", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.06
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.5
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:plasmahit-sparkonly"
                            LuaKey.String "fallOffRate", LuaValue.Number 0.2
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "impulsefactor", LuaValue.Number 1.5
                            LuaKey.String "intensity", LuaValue.Number 0.8
                            LuaKey.String "name", LuaValue.String "Twin Rapid-fire Machine Guns"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "ownerExpAccWeight", LuaValue.Number 4.0
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 450.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.4
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.95 0.4"
                            LuaKey.String "soundhit", LuaValue.String "bimpact3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "mgun12"
                            LuaKey.String "soundstartvolume", LuaValue.Number 6.0
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "sprayangle", LuaValue.Number 1024.0
                            LuaKey.String "texture1", LuaValue.String "shot"
                            LuaKey.String "texture2", LuaValue.String "empty"
                            LuaKey.String "thickness", LuaValue.Number 3.0
                            LuaKey.String "tolerance", LuaValue.Number 16000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 958.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 24.0
                                ]
                        ]
                    LuaKey.String "advdepthcharge", LuaValue.Table [
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
                            LuaKey.String "model", LuaValue.String "legbasictorpedo.s3o"
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
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 25.0
                            LuaKey.String "weapontimer", LuaValue.Number 10.0
                            LuaKey.String "weapontype", LuaValue.String "TorpedoLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 225.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 225.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "mg_guns"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                            LuaKey.String "burstControlWhenOutOfArc", LuaValue.Number 2.0
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTSUB"
                            LuaKey.String "def", LuaValue.String "advdepthcharge"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 300.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "CANBEUW UNDERWATER"
                        ]
                ]
        ]

    let leganavyflagship =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildangle", LuaValue.Number 16384.0
            LuaKey.String "buildpic", LuaValue.String "leganavyflagship.DDS"
            LuaKey.String "buildtime", LuaValue.Number 269000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "72 95 208"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylZ"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 240000.0
            LuaKey.String "energymake", LuaValue.Number 500.0
            LuaKey.String "explodeas", LuaValue.String "FlagshipExplosion"
            LuaKey.String "floater", LuaValue.Bool true
            LuaKey.String "footprintx", LuaValue.Number 8.0
            LuaKey.String "footprintz", LuaValue.Number 8.0
            LuaKey.String "health", LuaValue.Number 48000.0
            LuaKey.String "mass", LuaValue.Number 9999999.0
            LuaKey.String "maxacc", LuaValue.Number 0.012
            LuaKey.String "maxdec", LuaValue.Number 0.012
            LuaKey.String "metalcost", LuaValue.Number 16000.0
            LuaKey.String "minwaterdepth", LuaValue.Number 15.0
            LuaKey.String "movementclass", LuaValue.String "BOAT9"
            LuaKey.String "movestate", LuaValue.Number 0.0
            LuaKey.String "objectname", LuaValue.String "Units/leganavyflagship.s3o"
            LuaKey.String "radardistance", LuaValue.Number 1000.0
            LuaKey.String "radaremitheight", LuaValue.Number 64.0
            LuaKey.String "script", LuaValue.String "Units/leganavyflagship.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "FlagshipExplosionSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 650.0
            LuaKey.String "sightemitheight", LuaValue.Number 64.0
            LuaKey.String "speed", LuaValue.Number 63.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 150.0
            LuaKey.String "waterline", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.0
                    LuaKey.String "subfolder", LuaValue.String "Legion/Ships/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "72 95 208"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 93000.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 18.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 9450.0
                            LuaKey.String "object", LuaValue.String "Units/leganavyflagship_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 40032.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 4725.0
                            LuaKey.String "object", LuaValue.String "Units/cor6X6A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-medium-impulse"
                            LuaKey.Int 2, LuaValue.String "custom:waterwake-huge"
                            LuaKey.Int 3, LuaValue.String "custom:bowsplash-huge"
                            LuaKey.Int 4, LuaValue.String "custom:enginespurt-huge"
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
                    LuaKey.String "targeting_system", LuaValue.Table [
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
                            LuaKey.String "name", LuaValue.String "Targeting System"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 700.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.5
                            LuaKey.String "size", LuaValue.Number 0.0
                            LuaKey.String "soundhit", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String ""
                            LuaKey.String "soundstart", LuaValue.String ""
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 360.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "norangering", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 0.0
                                ]
                        ]
                    LuaKey.String "leg_experimental_heatray", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 90.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.033
                            LuaKey.String "beamttl", LuaValue.Number 0.033
                            LuaKey.String "camerashake", LuaValue.Number 0.1
                            LuaKey.String "corethickness", LuaValue.Number 0.3
                            LuaKey.String "craterareaofeffect", LuaValue.Number 72.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 17.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:heatray-large"
                            LuaKey.String "firestarter", LuaValue.Number 90.0
                            LuaKey.String "firetolerance", LuaValue.Number 50.0
                            LuaKey.String "largebeamlaser", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 5.0
                            LuaKey.String "laserflaresize", LuaValue.Number 6.5
                            LuaKey.String "name", LuaValue.String "Dual Experimental Thermal Ordnance Generators"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 0.0
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 700.0
                            LuaKey.String "reloadtime", LuaValue.Expr ".033"
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.3 0"
                            LuaKey.String "rgbcolor2", LuaValue.String "1 0.8 0.5"
                            LuaKey.String "soundhitdry", LuaValue.String "flamhit1"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "heatray4burn"
                            LuaKey.String "scrollspeed", LuaValue.Number 5.0
                            LuaKey.String "soundstartvolume", LuaValue.Number 11.0
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "texture3", LuaValue.String "largebeam"
                            LuaKey.String "thickness", LuaValue.Number 6.5
                            LuaKey.String "tilelength", LuaValue.Number 500.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 17.0
                                    LuaKey.String "default", LuaValue.Number 33.0
                                    LuaKey.String "vtol", LuaValue.Number 14.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "exclude_preaim", LuaValue.Bool true
                                ]
                        ]
                    LuaKey.String "leg_experimental_railgun", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 80.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "railgun"
                            LuaKey.String "collisionSize", LuaValue.Number 0.667
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.12
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.9
                            LuaKey.String "energypershot", LuaValue.Number 600.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:plasmahit-sparkonly"
                            LuaKey.String "firestarter", LuaValue.Number 1.0
                            LuaKey.String "hardstop", LuaValue.Bool true
                            LuaKey.String "impactonly", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 1.0
                            LuaKey.String "intensity", LuaValue.Number 0.8
                            LuaKey.String "name", LuaValue.String "Dual Naval-Series Rail Accelerators"
                            LuaKey.String "noexplode", LuaValue.Bool true
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "ownerExpAccWeight", LuaValue.Number 4.0
                            LuaKey.String "proximitypriority", LuaValue.Number 0.0
                            LuaKey.String "range", LuaValue.Number 1000.0
                            LuaKey.String "reloadtime", LuaValue.Number 3.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.34 0.64 0.94"
                            LuaKey.String "soundhit", LuaValue.String "mavgun3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "railgunxl"
                            LuaKey.String "soundstartvolume", LuaValue.Number 30.0
                            LuaKey.String "thickness", LuaValue.Number 4.0
                            LuaKey.String "firetolerance", LuaValue.Number 7000.0
                            LuaKey.String "tolerance", LuaValue.Number 7000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2850.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 300.0
                                    LuaKey.String "default", LuaValue.Number 800.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "overpenetrate", LuaValue.Bool true
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "targeting_system"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "leg_experimental_heatray"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                            LuaKey.String "burstControlWhenOutOfArc", LuaValue.Number 2.0
                            LuaKey.String "slaveto", LuaValue.Number 1.0
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "leg_experimental_heatray"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                            LuaKey.String "burstControlWhenOutOfArc", LuaValue.Number 2.0
                            LuaKey.String "slaveto", LuaValue.Number 1.0
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "leg_experimental_railgun"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                            LuaKey.String "maindir", LuaValue.String "0.966 0 0.259"
                            LuaKey.String "burstControlWhenOutOfArc", LuaValue.Number 2.0
                            LuaKey.String "maxangledif", LuaValue.Number 180.0
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "leg_experimental_railgun"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                            LuaKey.String "maindir", LuaValue.String "-0.966 0 0.259"
                            LuaKey.String "burstControlWhenOutOfArc", LuaValue.Number 2.0
                            LuaKey.String "maxangledif", LuaValue.Number 180.0
                        ]
                    LuaKey.Int 6, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "leg_experimental_railgun"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                            LuaKey.String "maindir", LuaValue.String "0.966 0 -0.259"
                            LuaKey.String "burstControlWhenOutOfArc", LuaValue.Number 2.0
                            LuaKey.String "maxangledif", LuaValue.Number 180.0
                        ]
                    LuaKey.Int 7, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "leg_experimental_railgun"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                            LuaKey.String "maindir", LuaValue.String "-0.966 0 -0.259"
                            LuaKey.String "burstControlWhenOutOfArc", LuaValue.Number 2.0
                            LuaKey.String "maxangledif", LuaValue.Number 180.0
                        ]
                ]
        ]

    let leganavyheavysub =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "leganavyheavysub.DDS"
            LuaKey.String "buildtime", LuaValue.Number 34370.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "52 25 60"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 29000.0
            LuaKey.String "explodeas", LuaValue.String "largeexplosiongeneric-uw"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 3900.0
            LuaKey.String "maxacc", LuaValue.Number 0.018
            LuaKey.String "maxdec", LuaValue.Number 0.018
            LuaKey.String "metalcost", LuaValue.Number 1900.0
            LuaKey.String "minwaterdepth", LuaValue.Number 20.0
            LuaKey.String "movementclass", LuaValue.String "UBOAT4"
            LuaKey.String "movestate", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/leganavyheavysub.s3o"
            LuaKey.String "script", LuaValue.String "Units/leganavyheavysub.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeexplosiongenericSelfd-uw"
            LuaKey.String "sightdistance", LuaValue.Number 570.0
            LuaKey.String "sonardistance", LuaValue.Number 400.0
            LuaKey.String "speed", LuaValue.Number 39.0
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 320.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "waterline", LuaValue.Number 80.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Model by Tharsis, Concept by Chris/Airnac"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "legion/Navy/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "sub"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "-6.04158782959 -4.50195312496e-06 -0.0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "39.0926055908 13.0902709961 63.9697265625"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 2200.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 1050.0
                            LuaKey.String "object", LuaValue.String "Units/leganavyheavysub_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 4400.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 525.0
                            LuaKey.String "object", LuaValue.String "Units/cor2X2A.s3o"
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
                            LuaKey.Int 1, LuaValue.String "sucormov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "sucorsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "torpedo_large", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 160.0
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
                            LuaKey.String "model", LuaValue.String "legfattorpedo.s3o"
                            LuaKey.String "name", LuaValue.String "Long-Range Heavy Torpedo"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 850.0
                            LuaKey.String "reloadtime", LuaValue.Number 8.0
                            LuaKey.String "soundhit", LuaValue.String "xplodep1"
                            LuaKey.String "soundhitvolume", LuaValue.Number 22.0
                            LuaKey.String "soundstart", LuaValue.String "torpedo1"
                            LuaKey.String "startvelocity", LuaValue.Number 150.0
                            LuaKey.String "tolerance", LuaValue.Number 8000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 1500.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 25.0
                            LuaKey.String "weapontimer", LuaValue.Number 4.0
                            LuaKey.String "weapontype", LuaValue.String "TorpedoLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 220.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 750.0
                                    LuaKey.String "default", LuaValue.Number 1650.0
                                    LuaKey.String "subs", LuaValue.Number 1110.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "HOVER NOTSHIP"
                            LuaKey.String "def", LuaValue.String "TORPEDO_LARGE"
                            LuaKey.String "maindir", LuaValue.String "0 0.2 1"
                            LuaKey.String "maxangledif", LuaValue.Number 80.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTHOVER"
                        ]
                ]
        ]

    let leganavymissileship =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "leganavymissileship.DDS"
            LuaKey.String "buildtime", LuaValue.Number 23000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "38 40 95"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylZ"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 10000.0
            LuaKey.String "explodeas", LuaValue.String "largeexplosiongeneric"
            LuaKey.String "floater", LuaValue.Bool true
            LuaKey.String "footprintx", LuaValue.Number 6.0
            LuaKey.String "footprintz", LuaValue.Number 6.0
            LuaKey.String "health", LuaValue.Number 3350.0
            LuaKey.String "maxacc", LuaValue.Number 0.02799
            LuaKey.String "maxdec", LuaValue.Number 0.03799
            LuaKey.String "metalcost", LuaValue.Number 2000.0
            LuaKey.String "minwaterdepth", LuaValue.Number 12.0
            LuaKey.String "movementclass", LuaValue.String "BOAT5"
            LuaKey.String "movestate", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/leganavymissileship.s3o"
            LuaKey.String "radardistance", LuaValue.Number 1000.0
            LuaKey.String "script", LuaValue.String "Units/leganavymissileship.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeexplosiongenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 318.5
            LuaKey.String "speed", LuaValue.Number 61.44
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 350.0
            LuaKey.String "waterline", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "maxrange", LuaValue.String "1650"
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorShips/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "38 30 95"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 2700.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 1000.0
                            LuaKey.String "object", LuaValue.String "Units/leganavymissileship_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 4032.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 500.0
                            LuaKey.String "object", LuaValue.String "Units/cor6X6B.s3o"
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
                            LuaKey.Int 1, LuaValue.String "shcormov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "shcorsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "leg_light_aa_missile", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 3.0
                            LuaKey.String "burstrate", LuaValue.Number 0.005
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "dance", LuaValue.Number 150.0
                            LuaKey.String "cegtag", LuaValue.String "missiletrailaa"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-tiny-aa"
                            LuaKey.String "firestarter", LuaValue.Number 72.0
                            LuaKey.String "flighttime", LuaValue.Number 2.5
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "legsmallrocket.s3o"
                            LuaKey.String "name", LuaValue.String "Anti-Air Salvo Missile Launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 760.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokecolor", LuaValue.Number 0.95
                            LuaKey.String "smokeperiod", LuaValue.Number 5.0
                            LuaKey.String "smokesize", LuaValue.Number 0.5
                            LuaKey.String "smoketime", LuaValue.Number 5.0
                            LuaKey.String "smokeTrailCastShadow", LuaValue.Bool false
                            LuaKey.String "castshadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "packohit"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "packolau"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "startvelocity", LuaValue.Number 800.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailaa"
                            LuaKey.String "tolerance", LuaValue.Number 9950.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 68000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "fixedlauncher", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 300.0
                            LuaKey.String "weapontimer", LuaValue.Number 2.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "vtol", LuaValue.Number 20.0
                                ]
                        ]
                    LuaKey.String "leg_salvo_vertical_rocket", LuaValue.Table [
                            LuaKey.String "burst", LuaValue.Number 6.0
                            LuaKey.String "burstrate", LuaValue.Number 0.12
                            LuaKey.String "sprayangle", LuaValue.Number 450.0
                            LuaKey.String "areaofeffect", LuaValue.Number 80.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "missiletrailmship"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 68.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large-bomb"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "flighttime", LuaValue.Number 15.0
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "hightrajectory", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 8.0
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "legmediumrocket.s3o"
                            LuaKey.String "mygravity", LuaValue.Number 0.08
                            LuaKey.String "name", LuaValue.String "Heavy Long-Range Vertical Salvo Rocket Launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 1550.0
                            LuaKey.String "reloadtime", LuaValue.Number 9.0
                            LuaKey.String "smoketrail", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "xplomed4"
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundstart", LuaValue.String "Rockhvy1"
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "null"
                            LuaKey.String "texture3", LuaValue.String "null"
                            LuaKey.String "tolerance", LuaValue.Number 4000.0
                            LuaKey.String "turnrate", LuaValue.Number 24384.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 80.0
                            LuaKey.String "weapontimer", LuaValue.Number 1.5
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 450.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "noattackrangearc", LuaValue.Number 1.0
                                    LuaKey.String "projectile_destruction_method", LuaValue.String "descend"
                                    LuaKey.String "overrange_distance", LuaValue.Number 3000.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 300.0
                                    LuaKey.String "default", LuaValue.Number 450.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "MOBILE"
                            LuaKey.String "def", LuaValue.String "leg_salvo_vertical_rocket"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "leg_light_aa_missile"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let leganavyradjamship =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "leganavyradjamship.DDS"
            LuaKey.String "buildtime", LuaValue.Number 19800.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "34 40 90"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 6000.0
            LuaKey.String "energyupkeep", LuaValue.Number 120.0
            LuaKey.String "explodeas", LuaValue.String "mediumexplosiongeneric"
            LuaKey.String "floater", LuaValue.Bool true
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 1700.0
            LuaKey.String "maxacc", LuaValue.Number 0.042
            LuaKey.String "maxdec", LuaValue.Number 0.042
            LuaKey.String "metalcost", LuaValue.Number 450.0
            LuaKey.String "minwaterdepth", LuaValue.Number 6.0
            LuaKey.String "movementclass", LuaValue.String "BOAT3"
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Units/leganavyradjamship.s3o"
            LuaKey.String "onoffable", LuaValue.Bool true
            LuaKey.String "radardistancejam", LuaValue.Number 650.0
            LuaKey.String "radardistance", LuaValue.Number 1850.0
            LuaKey.String "script", LuaValue.String "Units/leganavyradjamship.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumexplosiongenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 600.0
            LuaKey.String "speed", LuaValue.Number 42.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 350.0
            LuaKey.String "waterline", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Beherith"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "off_on_stun", LuaValue.String "true"
                    LuaKey.String "subfolder", LuaValue.String "Legion/Ships/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "util"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "-3.9418182373 0.0506627246094 -0.0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "41.9625549316 13.4625854492 69.8010559082"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 684.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 60.0
                            LuaKey.String "object", LuaValue.String "Units/leganavyradjamship_dead.s3o"
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
                            LuaKey.String "metal", LuaValue.Number 30.0
                            LuaKey.String "object", LuaValue.String "Units/cor4X4A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:bowsplash-small"
                            LuaKey.Int 2, LuaValue.String "custom:waterwake-small"
                            LuaKey.Int 3, LuaValue.String "custom:radarpulse_t2"
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
                            LuaKey.Int 1, LuaValue.String "shcormov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "radjam2"
                        ]
                ]
        ]

    let all : (string * LuaValue) list =
        [
            "leganavyaaship", leganavyaaship
            "leganavyantinukecarrier", leganavyantinukecarrier
            "leganavyantiswarm", leganavyantiswarm
            "leganavyartyship", leganavyartyship
            "leganavybattleship", leganavybattleship
            "leganavybattlesub", leganavybattlesub
            "leganavycruiser", leganavycruiser
            "leganavyflagship", leganavyflagship
            "leganavyheavysub", leganavyheavysub
            "leganavymissileship", leganavymissileship
            "leganavyradjamship", leganavyradjamship
        ]
