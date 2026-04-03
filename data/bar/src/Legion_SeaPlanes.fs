// Auto-generated BAR unit data: Legion/SeaPlanes
namespace BarData.Units

open BarData

module Legion_SeaPlanes =

    let legspbomber =
        LuaValue.Table [
            LuaKey.String "buildpic", LuaValue.String "legspbomber.DDS"
            LuaKey.String "buildtime", LuaValue.Number 9890.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "cansubmerge", LuaValue.Bool true
            LuaKey.String "collide", LuaValue.Bool false
            LuaKey.String "cruisealtitude", LuaValue.Number 210.0
            LuaKey.String "energycost", LuaValue.Number 7500.0
            LuaKey.String "explodeas", LuaValue.String "mediumexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 1170.0
            LuaKey.String "maxacc", LuaValue.Number 0.06
            LuaKey.String "maxaileron", LuaValue.Number 0.01347
            LuaKey.String "maxbank", LuaValue.Number 0.8
            LuaKey.String "maxdec", LuaValue.Number 0.045
            LuaKey.String "maxelevator", LuaValue.Number 0.00972
            LuaKey.String "maxpitch", LuaValue.Number 0.625
            LuaKey.String "maxrudder", LuaValue.Number 0.00522
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 255.0
            LuaKey.String "metalcost", LuaValue.Number 240.0
            LuaKey.String "noautofire", LuaValue.Bool true
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/legspbomber.s3o"
            LuaKey.String "script", LuaValue.String "Units/legspbomber.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 455.0
            LuaKey.String "speed", LuaValue.Number 267.29999
            LuaKey.String "speedtofront", LuaValue.Number 0.07
            LuaKey.String "turnradius", LuaValue.Number 64.0
            LuaKey.String "usesmoothmesh", LuaValue.Bool true
            LuaKey.String "wingangle", LuaValue.Number 0.06222
            LuaKey.String "wingdrag", LuaValue.Number 3.035
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Legion/SeaPlanes"
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
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
                            LuaKey.Int 1, LuaValue.String "vtolcrmv"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "seapsel1"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "leg_seaplane_bomb", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 100.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "bounceexplosiongenerator", LuaValue.String "custom:genericshellexplosion-small"
                            LuaKey.String "bouncerebound", LuaValue.Number 0.15
                            LuaKey.String "bounceslip", LuaValue.Number 0.75
                            LuaKey.String "burst", LuaValue.Number 3.0
                            LuaKey.String "burstrate", LuaValue.Number 0.13333
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "commandfire", LuaValue.Bool false
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.65
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-small-bomb"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "intensity", LuaValue.Number 0.01
                            LuaKey.String "model", LuaValue.String "legkambomb.s3o"
                            LuaKey.String "mygravity", LuaValue.Number 0.4
                            LuaKey.String "name", LuaValue.String "Advanced Scatterfire Warheads"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "numbounce", LuaValue.Number 3.0
                            LuaKey.String "projectiles", LuaValue.Number 8.0
                            LuaKey.String "range", LuaValue.Number 1280.0
                            LuaKey.String "reloadtime", LuaValue.Number 8.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.8 0.8 0.25"
                            LuaKey.String "size", LuaValue.Number 8.0
                            LuaKey.String "soundhitdry", LuaValue.String "bombsmed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "bombrel"
                            LuaKey.String "sprayangle", LuaValue.Number 6000.0
                            LuaKey.String "waterbounce", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "AircraftBomb"
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "water_splash", LuaValue.Number 0.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 50.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "leg_seaplane_bomb"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let legspfighter =
        LuaValue.Table [
            LuaKey.String "airsightdistance", LuaValue.Number 950.0
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "legspfighter.DDS"
            LuaKey.String "buildtime", LuaValue.Number 6540.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "cansubmerge", LuaValue.Bool true
            LuaKey.String "collide", LuaValue.Bool false
            LuaKey.String "cruisealtitude", LuaValue.Number 140.0
            LuaKey.String "energycost", LuaValue.Number 4500.0
            LuaKey.String "explodeas", LuaValue.String "smallExplosionGenericAir"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "health", LuaValue.Number 220.0
            LuaKey.String "maxacc", LuaValue.Number 0.2075
            LuaKey.String "maxaileron", LuaValue.Number 0.01403
            LuaKey.String "maxbank", LuaValue.Number 0.8
            LuaKey.String "maxdec", LuaValue.Number 0.1
            LuaKey.String "maxelevator", LuaValue.Number 0.01028
            LuaKey.String "maxpitch", LuaValue.Number 0.625
            LuaKey.String "maxrudder", LuaValue.Number 0.00578
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 255.0
            LuaKey.String "metalcost", LuaValue.Number 90.0
            LuaKey.String "nochasecategory", LuaValue.String "NOTAIR"
            LuaKey.String "objectname", LuaValue.String "Units/legspfighter.s3o"
            LuaKey.String "script", LuaValue.String "Units/legspfighter.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "smallExplosionGenericAir"
            LuaKey.String "sightdistance", LuaValue.Number 430.0
            LuaKey.String "speed", LuaValue.Number 310.79999
            LuaKey.String "speedtofront", LuaValue.Number 0.07
            LuaKey.String "turnradius", LuaValue.Number 64.0
            LuaKey.String "usesmoothmesh", LuaValue.Bool true
            LuaKey.String "wingangle", LuaValue.Number 0.06278
            LuaKey.String "wingdrag", LuaValue.Number 0.235
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "attacksafetydistance", LuaValue.Number 300.0
                    LuaKey.String "fighter", LuaValue.Number 1.0
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Legion/SeaPlanes"
                    LuaKey.String "unitgroup", LuaValue.String "aa"
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 0, LuaValue.String "custom:barrelshot-tiny-aa"
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
                            LuaKey.Int 1, LuaValue.String "vtolcrmv"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "seapsel1"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "leg_light_antiair_missile", LuaValue.Table [
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
                            LuaKey.String "name", LuaValue.String "Light Salvo Missile Launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 760.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.8
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
                            LuaKey.String "tolerance", LuaValue.Number 12000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 68000.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 300.0
                            LuaKey.String "weapontimer", LuaValue.Number 2.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "vtol", LuaValue.Number 37.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR"
                            LuaKey.String "def", LuaValue.String "leg_light_antiair_missile"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let legspradarsonarplane =
        LuaValue.Table [
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "legspradarsonarplane.DDS"
            LuaKey.String "buildtime", LuaValue.Number 10680.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "cansubmerge", LuaValue.Bool true
            LuaKey.String "collide", LuaValue.Bool false
            LuaKey.String "cruisealtitude", LuaValue.Number 220.0
            LuaKey.String "energycost", LuaValue.Number 7000.0
            LuaKey.String "explodeas", LuaValue.String "mediumexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 580.0
            LuaKey.String "maxacc", LuaValue.Number 0.1325
            LuaKey.String "maxaileron", LuaValue.Number 0.01403
            LuaKey.String "maxbank", LuaValue.Number 0.8
            LuaKey.String "maxdec", LuaValue.Number 0.05
            LuaKey.String "maxelevator", LuaValue.Number 0.01028
            LuaKey.String "maxpitch", LuaValue.Number 0.625
            LuaKey.String "maxrudder", LuaValue.Number 0.00578
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 255.0
            LuaKey.String "metalcost", LuaValue.Number 125.0
            LuaKey.String "objectname", LuaValue.String "Units/legspradarsonarplane.s3o"
            LuaKey.String "radardistance", LuaValue.Number 2250.0
            LuaKey.String "script", LuaValue.String "Units/legspradarsonarplane.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 1100.0
            LuaKey.String "sonardistance", LuaValue.Number 900.0
            LuaKey.String "speed", LuaValue.Number 338.10001
            LuaKey.String "speedtofront", LuaValue.Number 0.07
            LuaKey.String "turnradius", LuaValue.Number 64.0
            LuaKey.String "usesmoothmesh", LuaValue.Bool true
            LuaKey.String "wingangle", LuaValue.Number 0.06278
            LuaKey.String "wingdrag", LuaValue.Number 0.135
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Legion/SeaPlanes"
                    LuaKey.String "unitgroup", LuaValue.String "util"
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:radarpulse_t2"
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
                            LuaKey.Int 1, LuaValue.String "vtolarmv"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "seasonr2"
                        ]
                ]
        ]

    let legspsurfacegunship =
        LuaValue.Table [
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "legspsurfacegunship.DDS"
            LuaKey.String "buildtime", LuaValue.Number 12140.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "cansubmerge", LuaValue.Bool true
            LuaKey.String "collide", LuaValue.Bool true
            LuaKey.String "cruisealtitude", LuaValue.Number 85.0
            LuaKey.String "energycost", LuaValue.Number 6700.0
            LuaKey.String "explodeas", LuaValue.String "mediumexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 1200.0
            LuaKey.String "hoverattack", LuaValue.Bool true
            LuaKey.String "maxacc", LuaValue.Number 0.17
            LuaKey.String "maxdec", LuaValue.Number 0.38
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 255.0
            LuaKey.String "metalcost", LuaValue.Number 270.0
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/legspsurfacegunship.s3o"
            LuaKey.String "script", LuaValue.String "Units/legspsurfacegunship.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 595.0
            LuaKey.String "speed", LuaValue.Number 148.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 360.0
            LuaKey.String "turnrate", LuaValue.Number 720.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Legion/SeaPlanes"
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 0, LuaValue.String "custom:barrelshot-small"
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
                            LuaKey.Int 1, LuaValue.String "vtolcrmv"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "seapsel1"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "leg_riot_cannon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 140.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.9
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large"
                            LuaKey.String "impulsefactor", LuaValue.Number 2.0
                            LuaKey.String "name", LuaValue.String "Area Control Riot Cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 400.0
                            LuaKey.String "reloadtime", LuaValue.Number 3.5
                            LuaKey.String "soundhit", LuaValue.String "corlevlrhit"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "largegun"
                            LuaKey.String "soundhitvolume", LuaValue.Number 12.0
                            LuaKey.String "soundstartvolume", LuaValue.Number 14.0
                            LuaKey.String "separation", LuaValue.Number 2.0
                            LuaKey.String "nogap", LuaValue.Bool false
                            LuaKey.String "size", LuaValue.Number 3.0
                            LuaKey.String "sizeDecay", LuaValue.Number 0.07
                            LuaKey.String "stages", LuaValue.Number 10.0
                            LuaKey.String "alphaDecay", LuaValue.Number 0.1
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 600.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 200.0
                                    LuaKey.String "subs", LuaValue.Number 45.0
                                    LuaKey.String "vtol", LuaValue.Number 10.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "leg_riot_cannon"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let legsptorpgunship =
        LuaValue.Table [
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "legsptorpgunship.DDS"
            LuaKey.String "buildtime", LuaValue.Number 10720.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "cansubmerge", LuaValue.Bool true
            LuaKey.String "collide", LuaValue.Bool true
            LuaKey.String "cruisealtitude", LuaValue.Number 100.0
            LuaKey.String "energycost", LuaValue.Number 5000.0
            LuaKey.String "explodeas", LuaValue.String "mediumexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 900.0
            LuaKey.String "hoverattack", LuaValue.Bool true
            LuaKey.String "maxacc", LuaValue.Number 0.24
            LuaKey.String "maxdec", LuaValue.Number 0.4
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 255.0
            LuaKey.String "metalcost", LuaValue.Number 190.0
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/legsptorpgunship.s3o"
            LuaKey.String "script", LuaValue.String "Units/legsptorpgunship.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 535.0
            LuaKey.String "sonardistance", LuaValue.Number 535.0
            LuaKey.String "speed", LuaValue.Number 273.0
            LuaKey.String "turnrate", LuaValue.Number 720.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Legion/Seaplanes"
                    LuaKey.String "unitgroup", LuaValue.String "sub"
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 0, LuaValue.String "custom:barrelshot-tiny"
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
                            LuaKey.Int 1, LuaValue.String "vtolcrmv"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "seapsel1"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "leg_torpedo_launcher", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool true
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "burst", LuaValue.Number 2.0
                            LuaKey.String "burstrate", LuaValue.Number 0.3
                            LuaKey.String "cegtag", LuaValue.String "torpedotrail-tiny"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.25
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium"
                            LuaKey.String "flighttime", LuaValue.Number 3.0
                            LuaKey.String "gravityaffected", LuaValue.String "false"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "legtorpedomini.s3o"
                            LuaKey.String "name", LuaValue.String "VTOL Torpedo Launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 0.3
                            LuaKey.String "range", LuaValue.Number 460.0
                            LuaKey.String "reloadtime", LuaValue.Number 4.5
                            LuaKey.String "soundhit", LuaValue.String "splsmed"
                            LuaKey.String "soundhitwet", LuaValue.String "xplodep1"
                            LuaKey.String "soundstart", LuaValue.String "torpedo1"
                            LuaKey.String "soundhitvolume", LuaValue.Number 1.5
                            LuaKey.String "soundhitwetvolume", LuaValue.Number 3.0
                            LuaKey.String "startvelocity", LuaValue.Number 200.0
                            LuaKey.String "tolerance", LuaValue.Number 12000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 8000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 2.0
                            LuaKey.String "weapontimer", LuaValue.Number 4.0
                            LuaKey.String "weapontype", LuaValue.String "TorpedoLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 250.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 70.0
                                    LuaKey.String "default", LuaValue.Number 140.0
                                    LuaKey.String "vtol", LuaValue.Number 15.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "speceffect", LuaValue.String "torpwaterpen"
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTSHIP"
                            LuaKey.String "def", LuaValue.String "leg_torpedo_launcher"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 120.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTHOVER"
                        ]
                ]
        ]

    let all : (string * LuaValue) list =
        [
            "legspbomber", legspbomber
            "legspfighter", legspfighter
            "legspradarsonarplane", legspradarsonarplane
            "legspsurfacegunship", legspsurfacegunship
            "legsptorpgunship", legsptorpgunship
        ]
