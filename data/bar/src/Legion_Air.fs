// Auto-generated BAR unit data: Legion/Air
namespace BarData.Units

open BarData

module Legion_Air =

    let legatrans =
        LuaValue.Table [
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "LEGATRANS.DDS"
            LuaKey.String "buildtime", LuaValue.Number 8500.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "category", LuaValue.String "ALL MOBILE WEAPON NOTLAND VTOL NOTSUB NOTSHIP NOTHOVER"
            LuaKey.String "collide", LuaValue.Bool false
            LuaKey.String "cruisealtitude", LuaValue.Number 100.0
            LuaKey.String "energycost", LuaValue.Number 4000.0
            LuaKey.String "explodeas", LuaValue.String "mediumexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 800.0
            LuaKey.String "loadingradius", LuaValue.Number 300.0
            LuaKey.String "maxacc", LuaValue.Number 0.09
            LuaKey.String "maxdec", LuaValue.Number 0.75
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 190.0
            LuaKey.String "objectname", LuaValue.String "Units/LEGATRANS.s3o"
            LuaKey.String "releaseheld", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Units/LEGATRANS.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 430.0
            LuaKey.String "speed", LuaValue.Number 100.0
            LuaKey.String "transportcapacity", LuaValue.Number 1.0
            LuaKey.String "transportsize", LuaValue.Number 4.0
            LuaKey.String "transportunloadmethod", LuaValue.Number 0.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 360.0
            LuaKey.String "turnrate", LuaValue.Number 550.0
            LuaKey.String "verticalspeed", LuaValue.Number 3.75
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.0
                    LuaKey.String "subfolder", LuaValue.String "Legion/Air"
                    LuaKey.String "crashable", LuaValue.Number 0.0
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
                            LuaKey.Int 1, LuaValue.String "vtolcrmv"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "vtolcrac"
                        ]
                ]
        ]

    let legcib =
        LuaValue.Table [
            LuaKey.String "acceleration", LuaValue.Number 0.2
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "maxdec", LuaValue.Number 0.055
            LuaKey.String "energycost", LuaValue.Number 3500.0
            LuaKey.String "metalcost", LuaValue.Number 100.0
            LuaKey.String "buildpic", LuaValue.String "LEGCIB.DDS"
            LuaKey.String "buildtime", LuaValue.Number 4200.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collide", LuaValue.Bool true
            LuaKey.String "cruisealtitude", LuaValue.Number 130.0
            LuaKey.String "explodeas", LuaValue.String "mediumexplosiongeneric"
            LuaKey.String "firestate", LuaValue.Number 0.0
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "maxacc", LuaValue.Number 0.1825
            LuaKey.String "maxaileron", LuaValue.Number 0.0144
            LuaKey.String "maxbank", LuaValue.Number 0.8
            LuaKey.String "health", LuaValue.Number 890.0
            LuaKey.String "maxelevator", LuaValue.Number 0.01065
            LuaKey.String "maxpitch", LuaValue.Number 0.625
            LuaKey.String "maxrudder", LuaValue.Number 0.00615
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "speed", LuaValue.Number 300.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/LEGCIB.s3o"
            LuaKey.String "script", LuaValue.String "Units/LEGCIB.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 835.0
            LuaKey.String "speedtofront", LuaValue.Number 0.06183
            LuaKey.String "turnradius", LuaValue.Number 64.0
            LuaKey.String "turnrate", LuaValue.Number 800.0
            LuaKey.String "usesmoothmesh", LuaValue.Bool true
            LuaKey.String "wingangle", LuaValue.Number 0.06296
            LuaKey.String "wingdrag", LuaValue.Number 0.08
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorAircraft"
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
                            LuaKey.Int 1, LuaValue.String "vtolcrmv"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "vtolcrac"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "juno_pulse_mini", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 500.0
                            LuaKey.String "areaofeffect", LuaValue.Number 700.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "missiletrail-juno"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "commandfire", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 600.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 1.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:juno-explo-mini"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "epulse_mini.s3o"
                            LuaKey.String "model", LuaValue.String "legmediumrocket.s3o"
                            LuaKey.String "mygravity", LuaValue.Number 0.2
                            LuaKey.String "name", LuaValue.String "Anti radar/minefield/jammer magnetic impulse bomb"
                            LuaKey.String "range", LuaValue.Number 450.0
                            LuaKey.String "reloadtime", LuaValue.Number 10.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 8.0
                            LuaKey.String "smoketime", LuaValue.Number 45.0
                            LuaKey.String "smokesize", LuaValue.Number 14.0
                            LuaKey.String "smokecolor", LuaValue.Number 0.7
                            LuaKey.String "smokeTrailCastShadow", LuaValue.Bool false
                            LuaKey.String "castshadow", LuaValue.Bool true
                            LuaKey.String "soundhit", LuaValue.String "junohit2"
                            LuaKey.String "soundstart", LuaValue.String "bombrel"
                            LuaKey.String "tolerance", LuaValue.Number 16000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 10000.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 300.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "nofire", LuaValue.Bool true
                                    LuaKey.String "junotype", LuaValue.String "mini"
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1.0
                                    LuaKey.String "mines", LuaValue.Number 1000.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "MOBILE"
                            LuaKey.String "def", LuaValue.String "JUNO_PULSE_MINI"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let legdrone =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.35
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "maxdec", LuaValue.Number 0.7
            LuaKey.String "energycost", LuaValue.Number 500.0
            LuaKey.String "metalcost", LuaValue.Number 15.0
            LuaKey.String "buildpic", LuaValue.String "legdrone.DDS"
            LuaKey.String "buildtime", LuaValue.Number 1000.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "cantbetransported", LuaValue.Bool false
            LuaKey.String "collide", LuaValue.Bool true
            LuaKey.String "cruisealtitude", LuaValue.Number 78.0
            LuaKey.String "explodeas", LuaValue.String "tinyExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 1.0
            LuaKey.String "footprintz", LuaValue.Number 1.0
            LuaKey.String "hoverattack", LuaValue.Bool true
            LuaKey.String "health", LuaValue.Number 325.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "speed", LuaValue.Number 280.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "COMMANDER VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/LEGDRONE.s3o"
            LuaKey.String "repairable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "Units/LEGDRONE.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "tinyExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 600.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 360.0
            LuaKey.String "turnrate", LuaValue.Number 1100.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "usesmoothmesh", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorAircraft"
                    LuaKey.String "drone", LuaValue.Number 1.0
                    LuaKey.String "nohealthbars", LuaValue.Number 1.0
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
                            LuaKey.Int 1, LuaValue.String "vtolcrmv"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "vtolcrac"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "semiauto", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 7.0
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 2.0
                            LuaKey.String "burstrate", LuaValue.Number 0.066
                            LuaKey.String "burnblow", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.05
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.5
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:plasmahit-sparkonly"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "intensity", LuaValue.Number 0.8
                            LuaKey.String "name", LuaValue.String "Burst-fire Machine Gun"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "ownerExpAccWeight", LuaValue.Number 4.0
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 300.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.9
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.95 0.4"
                            LuaKey.String "soundhit", LuaValue.String "bimpact3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "mgun3"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "sprayangle", LuaValue.Number 1024.0
                            LuaKey.String "texture1", LuaValue.String "shot"
                            LuaKey.String "texture2", LuaValue.String "empty"
                            LuaKey.String "thickness", LuaValue.Number 2.0
                            LuaKey.String "tolerance", LuaValue.Number 6000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 692.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 12.0
                                    LuaKey.String "vtol", LuaValue.Number 6.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "SEMIAUTO"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 90.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let legfig =
        LuaValue.Table [
            LuaKey.String "acceleration", LuaValue.Number 0.35
            LuaKey.String "airsightdistance", LuaValue.Number 950.0
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "maxdec", LuaValue.Number 0.075
            LuaKey.String "energycost", LuaValue.Number 1600.0
            LuaKey.String "metalcost", LuaValue.Number 40.0
            LuaKey.String "buildpic", LuaValue.String "LEGFIG.DDS"
            LuaKey.String "buildtime", LuaValue.Number 2000.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collide", LuaValue.Bool false
            LuaKey.String "cruisealtitude", LuaValue.Number 125.0
            LuaKey.String "explodeas", LuaValue.String "smallExplosionGenericAir"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "maxacc", LuaValue.Number 0.2
            LuaKey.String "maxaileron", LuaValue.Number 0.0144
            LuaKey.String "maxbank", LuaValue.Number 0.8
            LuaKey.String "health", LuaValue.Number 220.0
            LuaKey.String "maxelevator", LuaValue.Number 0.01065
            LuaKey.String "maxpitch", LuaValue.Number 0.625
            LuaKey.String "maxrudder", LuaValue.Number 0.00615
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "speed", LuaValue.Number 270.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "NOTAIR"
            LuaKey.String "objectname", LuaValue.String "Units/LEGFIG.s3o"
            LuaKey.String "radardistance", LuaValue.Number 400.0
            LuaKey.String "script", LuaValue.String "Units/LEGFIG.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "smallExplosionGenericAir"
            LuaKey.String "sightdistance", LuaValue.Number 700.0
            LuaKey.String "speedtofront", LuaValue.Number 0.06417
            LuaKey.String "turnradius", LuaValue.Number 48.0
            LuaKey.String "turnrate", LuaValue.Number 950.0
            LuaKey.String "usesmoothmesh", LuaValue.Bool true
            LuaKey.String "wingangle", LuaValue.Number 0.06315
            LuaKey.String "wingdrag", LuaValue.Number 0.185
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "aa"
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Legion/Air"
                    LuaKey.String "attacksafetydistance", LuaValue.Number 300.0
                    LuaKey.String "fighter", LuaValue.Number 1.0
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
                    LuaKey.String "semiauto", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 7.0
                            LuaKey.String "areaofeffect", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Bool true
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 2.0
                            LuaKey.String "burstrate", LuaValue.Number 0.1
                            LuaKey.String "burnblow", LuaValue.Bool false
                            LuaKey.String "collideFriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.05
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.85
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:plasmahit-sparkonly"
                            LuaKey.String "fallOffRate", LuaValue.Number 0.2
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "impulsefactor", LuaValue.Number 1.5
                            LuaKey.String "intensity", LuaValue.Number 0.8
                            LuaKey.String "name", LuaValue.String "Burst-Fire A2A Machine Gun"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "ownerExpAccWeight", LuaValue.Number 4.0
                            LuaKey.String "predictboost", LuaValue.Number 0.5
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 600.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.6
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.4 0.95"
                            LuaKey.String "soundhit", LuaValue.String "bimpact3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "mgun3"
                            LuaKey.String "soundstartvolume", LuaValue.Number 3.0
                            LuaKey.String "soundTrigger", LuaValue.Bool true
                            LuaKey.String "sprayangle", LuaValue.Number 500.0
                            LuaKey.String "texture1", LuaValue.String "shot"
                            LuaKey.String "texture2", LuaValue.String "empty"
                            LuaKey.String "thickness", LuaValue.Number 3.0
                            LuaKey.String "tolerance", LuaValue.Number 2400.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 1.0
                                    LuaKey.String "default", LuaValue.Number 2.0
                                    LuaKey.String "vtol", LuaValue.Number 36.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR"
                            LuaKey.String "def", LuaValue.String "SEMIAUTO"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 20.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let legkam =
        LuaValue.Table [
            LuaKey.String "acceleration", LuaValue.Number 0.3
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "maxdec", LuaValue.Number 0.1
            LuaKey.String "energycost", LuaValue.Number 2000.0
            LuaKey.String "metalcost", LuaValue.Number 65.0
            LuaKey.String "buildpic", LuaValue.String "LEGKAM.DDS"
            LuaKey.String "buildtime", LuaValue.Number 2200.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collide", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 5 12"
            LuaKey.String "collisionvolumescales", LuaValue.String "15 15 40"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylZ"
            LuaKey.String "cruisealtitude", LuaValue.Number 50.0
            LuaKey.String "explodeas", LuaValue.String "tinyExplosionGeneric"
            LuaKey.String "firestate", LuaValue.Number 0.0
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "maxacc", LuaValue.Number 0.6
            LuaKey.String "maxaileron", LuaValue.Number 0.028
            LuaKey.String "maxbank", LuaValue.Number 0.8
            LuaKey.String "health", LuaValue.Number 160.0
            LuaKey.String "maxelevator", LuaValue.Number 0.01
            LuaKey.String "maxpitch", LuaValue.Number 0.625
            LuaKey.String "maxrudder", LuaValue.Number 0.015
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "speed", LuaValue.Number 220.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/legkam.s3o"
            LuaKey.String "script", LuaValue.String "Units/legkam.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String ""
            LuaKey.String "selfdestructcountdown", LuaValue.Number 0.0
            LuaKey.String "sightdistance", LuaValue.Number 430.0
            LuaKey.String "speedtofront", LuaValue.Number 0.06183
            LuaKey.String "turnradius", LuaValue.Number 48.0
            LuaKey.String "turnrate", LuaValue.Number 750.0
            LuaKey.String "usesmoothmesh", LuaValue.Bool true
            LuaKey.String "wingangle", LuaValue.Number 0.06296
            LuaKey.String "wingdrag", LuaValue.Number 0.06
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "Protar"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Legion/Air"
                    LuaKey.String "crashable", LuaValue.Number 0.0
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:genericunitexplosion-large"
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
                            LuaKey.Int 1, LuaValue.String "vtolcrmv"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "vtolcrac"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "trigger", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 3.0
                            LuaKey.String "burstrate", LuaValue.Number 0.5
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "commandfire", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "legnade.s3o"
                            LuaKey.String "mygravity", LuaValue.Number 0.23
                            LuaKey.String "name", LuaValue.String "Martyr trigger"
                            LuaKey.String "range", LuaValue.Number 1280.0
                            LuaKey.String "reloadtime", LuaValue.Number 10.0
                            LuaKey.String "weapontype", LuaValue.String "AircraftBomb"
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "bogus", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1.0
                                ]
                        ]
                    LuaKey.String "crawl_detonator", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 10.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String ""
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "name", LuaValue.String "Mine Detonator"
                            LuaKey.String "range", LuaValue.Number 1.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.5
                            LuaKey.String "soundhit", LuaValue.String "bombdropxx"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "bombdropxx"
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1000.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "bogus", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "vtol", LuaValue.Number 1000.0
                                    LuaKey.String "default", LuaValue.Number 1.0
                                ]
                        ]
                    LuaKey.String "martyrbomb", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 200.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericunitexplosion-medium-dirty"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "metalpershot", LuaValue.Number 1000000000.0
                            LuaKey.String "model", LuaValue.String "Units/legkam.s3o"
                            LuaKey.String "mygravity", LuaValue.Number 0.2
                            LuaKey.String "name", LuaValue.String "Crawlingbomb Dummy Weapon"
                            LuaKey.String "range", LuaValue.Number 500.0
                            LuaKey.String "reloadtime", LuaValue.Number 10.0
                            LuaKey.String "soundhit", LuaValue.String "xplomed4"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "bombdropxx"
                            LuaKey.String "weapontype", LuaValue.String "AircraftBomb"
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "spawns_name", LuaValue.String "legvision"
                                    LuaKey.String "spawns_surface", LuaValue.String "LAND SEA"
                                    LuaKey.String "spawns_expire", LuaValue.Number 10.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 220.0
                                    LuaKey.String "default", LuaValue.Number 440.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "TRIGGER"
                            LuaKey.String "maindir", LuaValue.String "0 -1 1"
                            LuaKey.String "maxangledif", LuaValue.Number 150.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "CRAWL_DETONATOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "MARTYRBOMB"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let leglts =
        LuaValue.Table [
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "leglts.DDS"
            LuaKey.String "buildtime", LuaValue.Number 3850.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collide", LuaValue.Bool false
            LuaKey.String "cruisealtitude", LuaValue.Number 100.0
            LuaKey.String "energycost", LuaValue.Number 1300.0
            LuaKey.String "explodeas", LuaValue.String "mediumexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 265.0
            LuaKey.String "loadingradius", LuaValue.Number 300.0
            LuaKey.String "maxacc", LuaValue.Number 0.1
            LuaKey.String "maxdec", LuaValue.Number 0.75
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 68.0
            LuaKey.String "objectname", LuaValue.String "Units/leglts.s3o"
            LuaKey.String "releaseheld", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Units/leglts.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 430.0
            LuaKey.String "speed", LuaValue.Number 207.0
            LuaKey.String "transportcapacity", LuaValue.Number 1.0
            LuaKey.String "transportmass", LuaValue.Number 750.0
            LuaKey.String "transportsize", LuaValue.Number 3.0
            LuaKey.String "transportunloadmethod", LuaValue.Number 0.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 360.0
            LuaKey.String "turnrate", LuaValue.Number 550.0
            LuaKey.String "verticalspeed", LuaValue.Number 3.75
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.0
                    LuaKey.String "subfolder", LuaValue.String "Legion/Air"
                    LuaKey.String "crashable", LuaValue.Number 0.0
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
        ]

    let legmos =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.3
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "maxdec", LuaValue.Number 0.75
            LuaKey.String "energycost", LuaValue.Number 2000.0
            LuaKey.String "metalcost", LuaValue.Number 110.0
            LuaKey.String "buildpic", LuaValue.String "LEGMOS.DDS"
            LuaKey.String "buildtime", LuaValue.Number 4000.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collide", LuaValue.Bool true
            LuaKey.String "cruisealtitude", LuaValue.Number 70.0
            LuaKey.String "explodeas", LuaValue.String "smallExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hoverattack", LuaValue.Bool true
            LuaKey.String "health", LuaValue.Number 415.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "speed", LuaValue.Number 165.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/legmos.s3o"
            LuaKey.String "script", LuaValue.String "Units/legmos.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "smallExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 520.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 360.0
            LuaKey.String "turnrate", LuaValue.Number 1400.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmAircraft"
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
                    LuaKey.String "cor_bot_rocket", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 72.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "collideFriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-small"
                            LuaKey.String "firestarter", LuaValue.Number 70.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "intensity", LuaValue.Number 1.5
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "legsmallrocket.s3o"
                            LuaKey.String "name", LuaValue.String "Rockets"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 380.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.8
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 7.0
                            LuaKey.String "smoketime", LuaValue.Number 20.0
                            LuaKey.String "smokesize", LuaValue.Number 2.2
                            LuaKey.String "smokecolor", LuaValue.Number 1.0
                            LuaKey.String "smokeTrailCastShadow", LuaValue.Bool false
                            LuaKey.String "castshadow", LuaValue.Bool true
                            LuaKey.String "soundhit", LuaValue.String "xplosml2"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "rocklit1"
                            LuaKey.String "startvelocity", LuaValue.Number 300.0
                            LuaKey.String "stockpile", LuaValue.Bool true
                            LuaKey.String "stockpiletime", LuaValue.Number 1.8
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketraildark"
                            LuaKey.String "tolerance", LuaValue.Number 4000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 20000.0
                            LuaKey.String "turret", LuaValue.Bool false
                            LuaKey.String "weaponacceleration", LuaValue.Number 160.0
                            LuaKey.String "weapontimer", LuaValue.Number 2.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 400.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "stockpilelimit", LuaValue.Number 4.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 44.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "COR_BOT_ROCKET"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let all : (string * LuaValue) list =
        [
            "legatrans", legatrans
            "legcib", legcib
            "legdrone", legdrone
            "legfig", legfig
            "legkam", legkam
            "leglts", leglts
            "legmos", legmos
        ]
