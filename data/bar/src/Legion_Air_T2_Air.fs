// Auto-generated BAR unit data: Legion/Air/T2 Air
namespace BarData.Units

open BarData

module Legion_Air_T2_Air =

    let legafigdef =
        LuaValue.Table [
            LuaKey.String "airsightdistance", LuaValue.Number 1100.0
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "maxdec", LuaValue.Number 0.0875
            LuaKey.String "energycost", LuaValue.Number 6200.0
            LuaKey.String "metalcost", LuaValue.Number 180.0
            LuaKey.String "buildpic", LuaValue.String "legafigdef.DDS"
            LuaKey.String "buildtime", LuaValue.Number 11850.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collide", LuaValue.Bool false
            LuaKey.String "cruisealtitude", LuaValue.Number 160.0
            LuaKey.String "explodeas", LuaValue.String "smallExplosionGenericAir"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "maxacc", LuaValue.Number 0.4
            LuaKey.String "maxaileron", LuaValue.Number 0.016
            LuaKey.String "maxbank", LuaValue.Number 0.72
            LuaKey.String "health", LuaValue.Number 480.0
            LuaKey.String "maxelevator", LuaValue.Number 0.013
            LuaKey.String "maxpitch", LuaValue.Number 0.745
            LuaKey.String "maxrudder", LuaValue.Number 0.015
            LuaKey.String "maxslope", LuaValue.Number 15.0
            LuaKey.String "speed", LuaValue.Number 270.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "NOTAIR"
            LuaKey.String "objectname", LuaValue.String "Units/legafigdef.s3o"
            LuaKey.String "script", LuaValue.String "Units/legafigdef.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "smallExplosionGenericAir"
            LuaKey.String "sightdistance", LuaValue.Number 430.0
            LuaKey.String "speedtofront", LuaValue.Number 0.06475
            LuaKey.String "stealth", LuaValue.Bool false
            LuaKey.String "turnradius", LuaValue.Number 32.0
            LuaKey.String "turnrate", LuaValue.Number 1500.0
            LuaKey.String "usesmoothmesh", LuaValue.Bool true
            LuaKey.String "wingangle", LuaValue.Number 0.06363
            LuaKey.String "wingdrag", LuaValue.Number 0.21
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "aa"
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Legion/Air/T2 Air"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "attacksafetydistance", LuaValue.Number 300.0
                    LuaKey.String "fighter", LuaValue.Number 1.0
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
                            LuaKey.Int 1, LuaValue.String "vtolcrmv"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "vtolcrac"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "leggun", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 5.0
                            LuaKey.String "areaofeffect", LuaValue.Number 2.0
                            LuaKey.String "avoidfeature", LuaValue.Bool true
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 10.0
                            LuaKey.String "burstrate", LuaValue.Number 0.04
                            LuaKey.String "burnblow", LuaValue.Bool false
                            LuaKey.String "collideFriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.05
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.85
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:plasmahit-sparkonly"
                            LuaKey.String "fallOffRate", LuaValue.Number 0.0
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "impulsefactor", LuaValue.Number 1.5
                            LuaKey.String "intensity", LuaValue.Number 0.8
                            LuaKey.String "minIntensity", LuaValue.Number 0.8
                            LuaKey.String "name", LuaValue.String "Heavy A2A Gatling Guns"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "ownerExpAccWeight", LuaValue.Number 8.0
                            LuaKey.String "predictboost", LuaValue.Number 1.0
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 600.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.0
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.4 0.95"
                            LuaKey.String "soundhit", LuaValue.String "bimpact3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "minigun3"
                            LuaKey.String "soundstartvolume", LuaValue.Number 2.0
                            LuaKey.String "soundTrigger", LuaValue.Bool true
                            LuaKey.String "sprayangle", LuaValue.Number 125.0
                            LuaKey.String "texture1", LuaValue.String "shot"
                            LuaKey.String "texture2", LuaValue.String "empty"
                            LuaKey.String "thickness", LuaValue.Number 3.0
                            LuaKey.String "tolerance", LuaValue.Number 2400.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 1.0
                                    LuaKey.String "default", LuaValue.Number 2.0
                                    LuaKey.String "vtol", LuaValue.Number 80.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "noattackrangearc", LuaValue.Number 1.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR"
                            LuaKey.String "def", LuaValue.String "leggun"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 18.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "weaponAimAdjustPriority", LuaValue.Number 20.0
                            LuaKey.String "fastAutoRetargeting", LuaValue.Bool true
                        ]
                ]
        ]

    let legatorpbomber =
        LuaValue.Table [
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "LEGATORPBOMBER.DDS"
            LuaKey.String "buildtime", LuaValue.Number 21970.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collide", LuaValue.Bool true
            LuaKey.String "cruisealtitude", LuaValue.Number 90.0
            LuaKey.String "energycost", LuaValue.Number 9480.0
            LuaKey.String "explodeas", LuaValue.String "mediumexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 1900.0
            LuaKey.String "maxacc", LuaValue.Number 0.1325
            LuaKey.String "maxaileron", LuaValue.Number 0.01347
            LuaKey.String "maxbank", LuaValue.Number 0.8
            LuaKey.String "maxdec", LuaValue.Number 0.0725
            LuaKey.String "maxelevator", LuaValue.Number 0.00972
            LuaKey.String "maxpitch", LuaValue.Number 0.625
            LuaKey.String "maxrudder", LuaValue.Number 0.00522
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 480.0
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/LEGATORPBOMBER.s3o"
            LuaKey.String "radardistance", LuaValue.Number 800.0
            LuaKey.String "script", LuaValue.String "Units/LEGATORPBOMBER.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 500.0
            LuaKey.String "sonardistance", LuaValue.Number 800.0
            LuaKey.String "speed", LuaValue.Number 290.0
            LuaKey.String "speedtofront", LuaValue.Number 0.063
            LuaKey.String "turnradius", LuaValue.Number 64.0
            LuaKey.String "usesmoothmesh", LuaValue.Bool true
            LuaKey.String "wingangle", LuaValue.Number 0.06222
            LuaKey.String "wingdrag", LuaValue.Number 0.18
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Legion/Air/T2 Air"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "sub"
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
                    LuaKey.String "legair_torp", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
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
                            LuaKey.String "flighttime", LuaValue.Number 4.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "legmediumtorpedo.s3o"
                            LuaKey.String "mygravity", LuaValue.Number 0.1
                            LuaKey.String "name", LuaValue.String "Medium Homing Torpedo Launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 400.0
                            LuaKey.String "reloadtime", LuaValue.Number 7.0
                            LuaKey.String "soundhit", LuaValue.String "xplodep2"
                            LuaKey.String "soundhitvolume", LuaValue.Number 3.5
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundhitwetvolume", LuaValue.Number 14.0
                            LuaKey.String "soundstart", LuaValue.String "bombrel"
                            LuaKey.String "startvelocity", LuaValue.Number 35.0
                            LuaKey.String "tolerance", LuaValue.Number 2000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 17000.0
                            LuaKey.String "turret", LuaValue.Bool false
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 35.0
                            LuaKey.String "weapontimer", LuaValue.Number 6.0
                            LuaKey.String "weapontype", LuaValue.String "TorpedoLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 200.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "speceffect", LuaValue.String "torpwaterpen"
                                    LuaKey.String "norangering", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 750.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTSHIP"
                            LuaKey.String "def", LuaValue.String "LEGAIR_TORP"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTHOVER"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTSHIP"
                            LuaKey.String "def", LuaValue.String "LEGAIR_TORP"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTHOVER"
                        ]
                ]
        ]

    let legfort =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.09
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "blocking", LuaValue.Bool true
            LuaKey.String "bankingallowed", LuaValue.Bool false
            LuaKey.String "maxdec", LuaValue.Number 0.09
            LuaKey.String "energycost", LuaValue.Number 79000.0
            LuaKey.String "metalcost", LuaValue.Number 5600.0
            LuaKey.String "buildpic", LuaValue.String "LEGFORT.DDS"
            LuaKey.String "buildtime", LuaValue.Number 119750.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collide", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 1 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "70 40 110"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "cruisealtitude", LuaValue.Number 100.0
            LuaKey.String "explodeas", LuaValue.String "largeexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "hoverattack", LuaValue.Bool true
            LuaKey.String "health", LuaValue.Number 16700.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "speed", LuaValue.Number 93.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/LEGFORT.s3o"
            LuaKey.String "radardistance", LuaValue.Number 1000.0
            LuaKey.String "script", LuaValue.String "Units/legfort.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 600.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 360.0
            LuaKey.String "turnrate", LuaValue.Number 240.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "tHARSIS"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/LEG_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorAircraft/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-small"
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
                            LuaKey.String "burst", LuaValue.Number 3.0
                            LuaKey.String "burstrate", LuaValue.Number 0.066
                            LuaKey.String "burnblow", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.05
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.5
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:plasmahit-sparkonly"
                            LuaKey.String "impulsefactor", LuaValue.Number 1.5
                            LuaKey.String "intensity", LuaValue.Number 0.8
                            LuaKey.String "name", LuaValue.String "Burst-fire Machine Gun"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "ownerExpAccWeight", LuaValue.Number 4.0
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 650.0
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
                            LuaKey.String "weaponvelocity", LuaValue.Number 970.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 36.0
                                    LuaKey.String "vtol", LuaValue.Number 18.0
                                ]
                        ]
                    LuaKey.String "plasma", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 960.0
                            LuaKey.String "areaofeffect", LuaValue.Number 160.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "arty-heavy"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.65
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-bomb"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 1.25
                            LuaKey.String "name", LuaValue.String "PlasmaCannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 915.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.7
                            LuaKey.String "soundhit", LuaValue.String "xplomed4"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy2"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 400.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 166.0
                                    LuaKey.String "subs", LuaValue.Number 50.0
                                    LuaKey.String "vtol", LuaValue.Number 30.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "noattackrangearc", LuaValue.Number 1.0
                                ]
                        ]
                    LuaKey.String "aa_missiles", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "missiletrailaa"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-tiny-aa"
                            LuaKey.String "firestarter", LuaValue.Number 72.0
                            LuaKey.String "fixedLauncher", LuaValue.Bool true
                            LuaKey.String "flighttime", LuaValue.Number 2.5
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "legsmallrocket.s3o"
                            LuaKey.String "name", LuaValue.String "Advanced d2a rapid missile launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 840.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.8
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 5.0
                            LuaKey.String "smoketime", LuaValue.Number 8.0
                            LuaKey.String "smokesize", LuaValue.Number 4.2
                            LuaKey.String "smokecolor", LuaValue.Number 1.0
                            LuaKey.String "smokeTrailCastShadow", LuaValue.Bool false
                            LuaKey.String "castshadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "packohit"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "packolau"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "startvelocity", LuaValue.Number 175.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailaa"
                            LuaKey.String "tolerance", LuaValue.Number 9950.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "trajectoryHeight", LuaValue.Number 1.0
                            LuaKey.String "turnrate", LuaValue.Number 58000.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 800.0
                            LuaKey.String "weapontype", LuaValue.String "StarburstLauncher"
                            LuaKey.String "weapontimer", LuaValue.Number 0.28
                            LuaKey.String "weaponvelocity", LuaValue.Number 1200.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "vtol", LuaValue.Number 76.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTLAND"
                            LuaKey.String "def", LuaValue.String "PLASMA"
                            LuaKey.String "maindir", LuaValue.String "-1 0 0"
                            LuaKey.String "maxangledif", LuaValue.Number 210.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTLAND"
                            LuaKey.String "def", LuaValue.String "PLASMA"
                            LuaKey.String "maindir", LuaValue.String "1 0 0"
                            LuaKey.String "maxangledif", LuaValue.Number 210.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "SEMIAUTO"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 240.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "SEMIAUTO"
                            LuaKey.String "maindir", LuaValue.String "-1 0 0"
                            LuaKey.String "maxangledif", LuaValue.Number 190.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "SEMIAUTO"
                            LuaKey.String "maindir", LuaValue.String "1 0 0"
                            LuaKey.String "maxangledif", LuaValue.Number 190.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 6, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "AA_MISSILES"
                            LuaKey.String "maindir", LuaValue.String "0 1 0"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let legheavydrone =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.15
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "maxdec", LuaValue.Number 0.35
            LuaKey.String "energycost", LuaValue.Number 1000.0
            LuaKey.String "metalcost", LuaValue.Number 90.0
            LuaKey.String "buildpic", LuaValue.String "legheavydrone.DDS"
            LuaKey.String "buildtime", LuaValue.Number 5820.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "cantbetransported", LuaValue.Bool false
            LuaKey.String "collide", LuaValue.Bool true
            LuaKey.String "cruisealtitude", LuaValue.Number 68.0
            LuaKey.String "explodeas", LuaValue.String "tinyExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hoverattack", LuaValue.Bool true
            LuaKey.String "health", LuaValue.Number 1650.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "speed", LuaValue.Number 180.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "COMMANDER VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/LEGHEAVYDRONE.s3o"
            LuaKey.String "repairable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "Units/LEGHEAVYDRONE.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "tinyExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 750.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 360.0
            LuaKey.String "turnrate", LuaValue.Number 750.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorAircraft"
                    LuaKey.String "drone", LuaValue.Number 1.0
                    LuaKey.String "nohealthbars", LuaValue.Number 1.0
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
                    LuaKey.String "heat_ray", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 8.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamburst", LuaValue.Bool true
                            LuaKey.String "burst", LuaValue.Number 10.0
                            LuaKey.String "burstrate", LuaValue.Number 0.03
                            LuaKey.String "corethickness", LuaValue.Number 0.23
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small"
                            LuaKey.String "firestarter", LuaValue.Number 30.0
                            LuaKey.String "fireTolerance", LuaValue.Number 4400.0
                            LuaKey.String "tolerance", LuaValue.Number 4400.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 10.0
                            LuaKey.String "name", LuaValue.String "a2g Heat Ray"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 430.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.8
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.55 0"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.9 1.0 0.5"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "heliosfire"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 2.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 950.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 10.0
                                    LuaKey.String "vtol", LuaValue.Number 2.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "noattackrangearc", LuaValue.Number 1.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "HEAT_RAY"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 270.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                            LuaKey.String "burstControlWhenOutOfArc", LuaValue.Number 1.0
                        ]
                ]
        ]

    let legheavydronesmall =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.15
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "maxdec", LuaValue.Number 0.35
            LuaKey.String "energycost", LuaValue.Number 1000.0
            LuaKey.String "metalcost", LuaValue.Number 90.0
            LuaKey.String "buildpic", LuaValue.String "legheavydrone.DDS"
            LuaKey.String "buildtime", LuaValue.Number 5820.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "cantbetransported", LuaValue.Bool false
            LuaKey.String "collide", LuaValue.Bool true
            LuaKey.String "cruisealtitude", LuaValue.Number 68.0
            LuaKey.String "explodeas", LuaValue.String "tinyExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hoverattack", LuaValue.Bool true
            LuaKey.String "health", LuaValue.Number 1650.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "speed", LuaValue.Number 180.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "COMMANDER VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/legheavydronesmall.s3o"
            LuaKey.String "repairable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "Units/legheavydrone.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "tinyExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 750.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 360.0
            LuaKey.String "turnrate", LuaValue.Number 750.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorAircraft"
                    LuaKey.String "drone", LuaValue.Number 1.0
                    LuaKey.String "nohealthbars", LuaValue.Number 1.0
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
                    LuaKey.String "heat_ray", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 8.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamburst", LuaValue.Bool true
                            LuaKey.String "burst", LuaValue.Number 10.0
                            LuaKey.String "burstrate", LuaValue.Number 0.03
                            LuaKey.String "corethickness", LuaValue.Number 0.23
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small"
                            LuaKey.String "firestarter", LuaValue.Number 30.0
                            LuaKey.String "fireTolerance", LuaValue.Number 4400.0
                            LuaKey.String "tolerance", LuaValue.Number 4400.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 10.0
                            LuaKey.String "name", LuaValue.String "a2g Heat Ray"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 430.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.8
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.55 0"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.9 1.0 0.5"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "heliosfire"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 2.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 950.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 10.0
                                    LuaKey.String "vtol", LuaValue.Number 2.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "noattackrangearc", LuaValue.Number 1.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "HEAT_RAY"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 270.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                            LuaKey.String "burstControlWhenOutOfArc", LuaValue.Number 1.0
                        ]
                ]
        ]

    let legionnaire =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.35
            LuaKey.String "airsightdistance", LuaValue.Number 1100.0
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "maxdec", LuaValue.Number 0.0875
            LuaKey.String "energycost", LuaValue.Number 6200.0
            LuaKey.String "metalcost", LuaValue.Number 180.0
            LuaKey.String "buildpic", LuaValue.String "legionnaire.DDS"
            LuaKey.String "buildtime", LuaValue.Number 11850.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collide", LuaValue.Bool false
            LuaKey.String "cruisealtitude", LuaValue.Number 160.0
            LuaKey.String "explodeas", LuaValue.String "smallExplosionGenericAir"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "maxacc", LuaValue.Number 0.4
            LuaKey.String "maxaileron", LuaValue.Number 0.016
            LuaKey.String "maxbank", LuaValue.Number 0.72
            LuaKey.String "health", LuaValue.Number 480.0
            LuaKey.String "maxelevator", LuaValue.Number 0.013
            LuaKey.String "maxpitch", LuaValue.Number 0.745
            LuaKey.String "maxrudder", LuaValue.Number 0.015
            LuaKey.String "maxslope", LuaValue.Number 15.0
            LuaKey.String "speed", LuaValue.Number 270.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "NOTAIR"
            LuaKey.String "objectname", LuaValue.String "Units/legionnaire.s3o"
            LuaKey.String "script", LuaValue.String "Units/legionnaire.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "smallExplosionGenericAir"
            LuaKey.String "sightdistance", LuaValue.Number 430.0
            LuaKey.String "speedtofront", LuaValue.Number 0.06475
            LuaKey.String "stealth", LuaValue.Bool false
            LuaKey.String "turnradius", LuaValue.Number 32.0
            LuaKey.String "turnrate", LuaValue.Number 1500.0
            LuaKey.String "usesmoothmesh", LuaValue.Bool true
            LuaKey.String "wingangle", LuaValue.Number 0.06363
            LuaKey.String "wingdrag", LuaValue.Number 0.21
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "aa"
                    LuaKey.String "model_author", LuaValue.String "Hornet"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorAircraft/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
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
                            LuaKey.Int 1, LuaValue.String "vtolcrmv"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "vtolcrac"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "leggun", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 5.0
                            LuaKey.String "areaofeffect", LuaValue.Number 2.0
                            LuaKey.String "avoidfeature", LuaValue.Bool true
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 10.0
                            LuaKey.String "burstrate", LuaValue.Number 0.04
                            LuaKey.String "burnblow", LuaValue.Bool false
                            LuaKey.String "collideFriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.02
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.85
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:plasmahit-sparkonly"
                            LuaKey.String "fallOffRate", LuaValue.Number 0.0
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "impulsefactor", LuaValue.Number 1.5
                            LuaKey.String "intensity", LuaValue.Number 0.8
                            LuaKey.String "minIntensity", LuaValue.Number 0.8
                            LuaKey.String "name", LuaValue.String "Rapid-fire dual A2A machine guns"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "ownerExpAccWeight", LuaValue.Number 8.0
                            LuaKey.String "predictboost", LuaValue.Number 1.0
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 600.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.0
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.4 0.95"
                            LuaKey.String "soundhit", LuaValue.String "bimpact3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "minigun3"
                            LuaKey.String "soundstartvolume", LuaValue.Number 2.0
                            LuaKey.String "sprayangle", LuaValue.Number 125.0
                            LuaKey.String "thickness", LuaValue.Number 0.6
                            LuaKey.String "tolerance", LuaValue.Number 2400.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 1.0
                                    LuaKey.String "default", LuaValue.Number 2.0
                                    LuaKey.String "vtol", LuaValue.Number 80.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "noattackrangearc", LuaValue.Number 1.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR"
                            LuaKey.String "def", LuaValue.String "leggun"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 18.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "weaponAimAdjustPriority", LuaValue.Number 20.0
                            LuaKey.String "fastAutoRetargeting", LuaValue.Bool true
                        ]
                ]
        ]

    let legmineb =
        LuaValue.Table [
            LuaKey.String "acceleration", LuaValue.Number 0.055
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "maxdec", LuaValue.Number 0.045
            LuaKey.String "energycost", LuaValue.Number 21000.0
            LuaKey.String "metalcost", LuaValue.Number 300.0
            LuaKey.String "buildpic", LuaValue.String "LEGMINEB.DDS"
            LuaKey.String "buildtime", LuaValue.Number 30550.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collide", LuaValue.Bool false
            LuaKey.String "cruisealtitude", LuaValue.Number 150.0
            LuaKey.String "explodeas", LuaValue.String "mediumExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "maxacc", LuaValue.Number 0.06
            LuaKey.String "maxaileron", LuaValue.Number 0.01347
            LuaKey.String "maxbank", LuaValue.Number 0.8
            LuaKey.String "health", LuaValue.Number 1110.0
            LuaKey.String "maxelevator", LuaValue.Number 0.00972
            LuaKey.String "maxpitch", LuaValue.Number 0.625
            LuaKey.String "maxrudder", LuaValue.Number 0.00522
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "speed", LuaValue.Number 210.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "noautofire", LuaValue.Bool true
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/legmineb.s3o"
            LuaKey.String "script", LuaValue.String "Units/legmineb.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 455.0
            LuaKey.String "speedtofront", LuaValue.Number 0.07
            LuaKey.String "turnradius", LuaValue.Number 64.0
            LuaKey.String "turnrate", LuaValue.Number 600.0
            LuaKey.String "usesmoothmesh", LuaValue.Bool true
            LuaKey.String "wingangle", LuaValue.Number 0.06222
            LuaKey.String "wingdrag", LuaValue.Number 0.125
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Legion/Air/T2 Air"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
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
                            LuaKey.Int 1, LuaValue.String "seapsel2"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "cor_seaadvbomb", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 500.0
                            LuaKey.String "areaofeffect", LuaValue.Number 40.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "bounceexplosiongenerator", LuaValue.String "custom:dirt"
                            LuaKey.String "bouncerebound", LuaValue.Number 0.15
                            LuaKey.String "bounceslip", LuaValue.Number 0.75
                            LuaKey.String "burst", LuaValue.Number 6.0
                            LuaKey.String "burstrate", LuaValue.Number 0.25
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "commandfire", LuaValue.Bool false
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.65
                            LuaKey.String "metalpershot", LuaValue.Number 30.0
                            LuaKey.String "energypershot", LuaValue.Number 1620.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:dirtpopup"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "intensity", LuaValue.Number 0.01
                            LuaKey.String "model", LuaValue.String "leglmineproj.s3o"
                            LuaKey.String "mygravity", LuaValue.Number 0.07
                            LuaKey.String "name", LuaValue.String "LegionMineBomb"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "numbounce", LuaValue.Number 3.0
                            LuaKey.String "range", LuaValue.Number 1600.0
                            LuaKey.String "reloadtime", LuaValue.Number 10.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.8 0.8 0.25"
                            LuaKey.String "size", LuaValue.Number 8.0
                            LuaKey.String "soundhitdry", LuaValue.String "xplodragconcrete"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "bombrel"
                            LuaKey.String "sprayangle", LuaValue.Number 300.0
                            LuaKey.String "stockpile", LuaValue.Bool true
                            LuaKey.String "stockpiletime", LuaValue.Number 10.0
                            LuaKey.String "waterbounce", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "AircraftBomb"
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "bogus", LuaValue.Number 1.0
                                    LuaKey.String "spawns_name", LuaValue.String "legmine1"
                                    LuaKey.String "spawns_surface", LuaValue.String "LAND"
                                    LuaKey.String "stockpilelimit", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "COR_SEAADVBOMB"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let legnap =
        LuaValue.Table [
            LuaKey.String "acceleration", LuaValue.Number 0.04
            LuaKey.String "airsightdistance", LuaValue.Number 800.0
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "maxdec", LuaValue.Number 0.045
            LuaKey.String "energycost", LuaValue.Number 21000.0
            LuaKey.String "metalcost", LuaValue.Number 420.0
            LuaKey.String "buildpic", LuaValue.String "LEGNAP.DDS"
            LuaKey.String "buildtime", LuaValue.Number 41910.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collide", LuaValue.Bool false
            LuaKey.String "cruisealtitude", LuaValue.Number 180.0
            LuaKey.String "explodeas", LuaValue.String "largeexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "maxacc", LuaValue.Number 0.0525
            LuaKey.String "maxaileron", LuaValue.Number 0.01273
            LuaKey.String "maxbank", LuaValue.Number 0.8
            LuaKey.String "health", LuaValue.Number 2900.0
            LuaKey.String "maxelevator", LuaValue.Number 0.00898
            LuaKey.String "maxpitch", LuaValue.Number 0.625
            LuaKey.String "maxrudder", LuaValue.Number 0.00448
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "speed", LuaValue.Number 215.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "noautofire", LuaValue.Bool true
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/LEGNAP.s3o"
            LuaKey.String "script", LuaValue.String "Units/CORHURC.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 430.0
            LuaKey.String "speedtofront", LuaValue.Number 0.063
            LuaKey.String "turnradius", LuaValue.Number 64.0
            LuaKey.String "turnrate", LuaValue.Number 400.0
            LuaKey.String "usesmoothmesh", LuaValue.Bool true
            LuaKey.String "wingangle", LuaValue.Number 0.06148
            LuaKey.String "wingdrag", LuaValue.Number 0.125
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorAircraft/T2"
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
                            LuaKey.Int 1, LuaValue.String "vtolcrmv"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "vtolcrac"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "napalmbombs", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 300.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 4.0
                            LuaKey.String "burstrate", LuaValue.Number 0.6
                            LuaKey.String "craterareaofeffect", LuaValue.Number 180.0
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "commandfire", LuaValue.Bool false
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.85
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:burnfire-bomb"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "legbomb.s3o"
                            LuaKey.String "mygravity", LuaValue.Number 0.4
                            LuaKey.String "name", LuaValue.String "Heavy a2g napalm warheads"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1280.0
                            LuaKey.String "reloadtime", LuaValue.Number 10.0
                            LuaKey.String "soundhit", LuaValue.String "bombsmed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundstart", LuaValue.String "bombrelxl"
                            LuaKey.String "weapontype", LuaValue.String "AircraftBomb"
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "area_onhit_ceg", LuaValue.String "fire-area-150-repeat"
                                    LuaKey.String "area_onhit_damageCeg", LuaValue.String "burnflamexl-gen"
                                    LuaKey.String "area_onhit_resistance", LuaValue.String "fire"
                                    LuaKey.String "area_onhit_damage", LuaValue.Number 30.0
                                    LuaKey.String "area_onhit_range", LuaValue.Number 150.0
                                    LuaKey.String "area_onhit_time", LuaValue.Number 15.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 50.0
                                    LuaKey.String "subs", LuaValue.Number 20.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "MOBILE"
                            LuaKey.String "def", LuaValue.String "NAPALMBOMBS"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let legphoenix =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.05
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "maxdec", LuaValue.Number 0.025
            LuaKey.String "energycost", LuaValue.Number 25000.0
            LuaKey.String "metalcost", LuaValue.Number 450.0
            LuaKey.String "buildpic", LuaValue.String "LEGPHOENIX.DDS"
            LuaKey.String "buildtime", LuaValue.Number 46600.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collide", LuaValue.Bool false
            LuaKey.String "cruisealtitude", LuaValue.Number 220.0
            LuaKey.String "explodeas", LuaValue.String "largeexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "maxacc", LuaValue.Number 0.0525
            LuaKey.String "maxaileron", LuaValue.Number 0.01273
            LuaKey.String "maxbank", LuaValue.Number 0.6
            LuaKey.String "health", LuaValue.Number 2000.0
            LuaKey.String "maxelevator", LuaValue.Number 0.00898
            LuaKey.String "maxpitch", LuaValue.Number 0.625
            LuaKey.String "maxrudder", LuaValue.Number 0.01
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "speed", LuaValue.Number 270.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "noautofire", LuaValue.Bool true
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/legphoenix.s3o"
            LuaKey.String "script", LuaValue.String "Units/legphoenix.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 430.0
            LuaKey.String "speedtofront", LuaValue.Number 0.063
            LuaKey.String "turnradius", LuaValue.Number 64.0
            LuaKey.String "turnrate", LuaValue.Number 400.0
            LuaKey.String "usesmoothmesh", LuaValue.Bool true
            LuaKey.String "wingangle", LuaValue.Number 0.06148
            LuaKey.String "wingdrag", LuaValue.Number 0.125
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "Protar/Hornet"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Legionaircraft/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "damage", LuaValue.Number 1200.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 200.0
                            LuaKey.String "object", LuaValue.String "Units/legphoenix_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 600.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 110.0
                            LuaKey.String "object", LuaValue.String "Units/cor3X3A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table []
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
                    LuaKey.String "skybeam", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 120.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.033
                            LuaKey.String "beamttl", LuaValue.Number 0.099
                            LuaKey.String "camerashake", LuaValue.Number 0.1
                            LuaKey.String "corethickness", LuaValue.Number 0.4
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 120.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.45
                            LuaKey.String "energypershot", LuaValue.Number 17.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:heatray-huge"
                            LuaKey.String "firestarter", LuaValue.Number 90.0
                            LuaKey.String "firetolerance", LuaValue.Number 300.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 6.0
                            LuaKey.String "name", LuaValue.String "Heavy a2g Phoenix Flame Heat Ray"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 1.0
                            LuaKey.String "proximitypriority", LuaValue.Number -1.0
                            LuaKey.String "range", LuaValue.Number 950.0
                            LuaKey.String "reloadtime", LuaValue.Number 8.0
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.5 0"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.9 1.0 0.5"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String ""
                            LuaKey.String "soundstartvolume", LuaValue.Number 0.0
                            LuaKey.String "soundtrigger", LuaValue.Number 0.0
                            LuaKey.String "thickness", LuaValue.Number 4.5
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 125.0
                                    LuaKey.String "default", LuaValue.Number 145.0
                                    LuaKey.String "vtol", LuaValue.Number 5.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "sweepfire", LuaValue.Number 7.0
                                ]
                        ]
                    LuaKey.String "legphtarg", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 121.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 5.0
                            LuaKey.String "burstrate", LuaValue.Number 0.4
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "commandfire", LuaValue.Bool false
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number -0.99
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:noexplosion"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "empty.s3o"
                            LuaKey.String "mygravity", LuaValue.Number 0.4
                            LuaKey.String "name", LuaValue.String "Targetting System"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1280.0
                            LuaKey.String "reloadtime", LuaValue.Number 7.0
                            LuaKey.String "weapontype", LuaValue.String "AircraftBomb"
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 0.0
                                    LuaKey.String "subs", LuaValue.Number 0.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "bogus", LuaValue.Number 1.0
                                    LuaKey.String "nodecal", LuaValue.Number 1.0
                                    LuaKey.String "water_splash", LuaValue.Number 0.0
                                ]
                        ]
                    LuaKey.String "legphsound", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 0.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "name", LuaValue.String "PhoenixBlast"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "SoundHitDry", LuaValue.String "heatray3lp"
                            LuaKey.String "SoundHitDryVolume", LuaValue.Number 18.0
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "noexplosionlight", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 0.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "bogus", LuaValue.Number 1.0
                                    LuaKey.String "nodecal", LuaValue.Number 1.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "MOBILE"
                            LuaKey.String "def", LuaValue.String "legphtarg"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "MOBILE"
                            LuaKey.String "def", LuaValue.String "skybeam"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "LEGPHSOUND"
                        ]
                ]
        ]

    let legstronghold =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.12
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "maxdec", LuaValue.Number 0.6
            LuaKey.String "energycost", LuaValue.Number 11000.0
            LuaKey.String "metalcost", LuaValue.Number 550.0
            LuaKey.String "buildpic", LuaValue.String "legstronghold.DDS"
            LuaKey.String "buildtime", LuaValue.Number 24200.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collide", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "1 -3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "52 21 52"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "cruisealtitude", LuaValue.Number 135.0
            LuaKey.String "explodeas", LuaValue.String "hugeExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "hoverattack", LuaValue.Bool true
            LuaKey.String "health", LuaValue.Number 2600.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "speed", LuaValue.Number 175.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/legstronghold.s3o"
            LuaKey.String "releaseheld", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Units/legstronghold.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "hugeExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 430.0
            LuaKey.String "transportcapacity", LuaValue.Number 1.0
            LuaKey.String "transportsize", LuaValue.Number 4.0
            LuaKey.String "transportunloadmethod", LuaValue.Number 0.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 360.0
            LuaKey.String "turnrate", LuaValue.Number 380.0
            LuaKey.String "unloadspread", LuaValue.Number 0.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.025
                    LuaKey.String "subfolder", LuaValue.String "CorAircraft/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "crashable", LuaValue.Number 0.0
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-small"
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
                    LuaKey.String "shotgun", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 7.0
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "projectiles", LuaValue.Number 8.0
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
                            LuaKey.String "name", LuaValue.String "Medium Shotgun"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "ownerExpAccWeight", LuaValue.Number 4.0
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 450.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.6
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.95 0.4"
                            LuaKey.String "soundhit", LuaValue.String "bimpact3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "kroggie2xs"
                            LuaKey.String "soundstartvolume", LuaValue.Number 1.0
                            LuaKey.String "sprayangle", LuaValue.Number 1000.0
                            LuaKey.String "thickness", LuaValue.Number 0.75
                            LuaKey.String "tolerance", LuaValue.Number 6000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 960.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 30.0
                                    LuaKey.String "vtol", LuaValue.Number 12.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "SHOTGUN"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 160.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let legvenator =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.6
            LuaKey.String "airsightdistance", LuaValue.Number 1100.0
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "maxdec", LuaValue.Number 0.0675
            LuaKey.String "energycost", LuaValue.Number 3200.0
            LuaKey.String "metalcost", LuaValue.Number 110.0
            LuaKey.String "buildpic", LuaValue.String "legvenator.DDS"
            LuaKey.String "buildtime", LuaValue.Number 9730.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collide", LuaValue.Bool false
            LuaKey.String "cruisealtitude", LuaValue.Number 160.0
            LuaKey.String "explodeas", LuaValue.String "smallExplosionGenericAir"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "maxaileron", LuaValue.Number 0.01488
            LuaKey.String "maxbank", LuaValue.Number 0.7
            LuaKey.String "health", LuaValue.Number 210.0
            LuaKey.String "maxelevator", LuaValue.Number 0.01113
            LuaKey.String "maxpitch", LuaValue.Number 0.525
            LuaKey.String "maxrudder", LuaValue.Number 0.00463
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "speed", LuaValue.Number 450.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "NOTAIR"
            LuaKey.String "objectname", LuaValue.String "Units/legvenator.s3o"
            LuaKey.String "script", LuaValue.String "Units/legvenator.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "smallExplosionGenericAir"
            LuaKey.String "sightdistance", LuaValue.Number 430.0
            LuaKey.String "speedtofront", LuaValue.Number 0.06475
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "turnradius", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 700.0
            LuaKey.String "usesmoothmesh", LuaValue.Bool true
            LuaKey.String "wingangle", LuaValue.Number 0.06363
            LuaKey.String "wingdrag", LuaValue.Number 0.21
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "aa"
                    LuaKey.String "model_author", LuaValue.String "Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Legion/Air/T2 Air"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
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
                            LuaKey.Int 1, LuaValue.String "vtolcrmv"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "vtolcrac"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "birdshot", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 100.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.65
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-small"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.2
                            LuaKey.String "intensity", LuaValue.Number 3.0
                            LuaKey.String "name", LuaValue.String "Birdshot Cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 1.0
                            LuaKey.String "projectiles", LuaValue.Number 3.0
                            LuaKey.String "range", LuaValue.Number 700.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.5
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.75 0.25"
                            LuaKey.String "size", LuaValue.Number 2.0
                            LuaKey.String "soundhit", LuaValue.String "flakhit"
                            LuaKey.String "soundhitwet", LuaValue.String "splshsml"
                            LuaKey.String "soundstart", LuaValue.String "flakfire"
                            LuaKey.String "soundstartvolume", LuaValue.Number 6.0
                            LuaKey.String "sprayangle", LuaValue.Number 200.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 1.0
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1600.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 8.0
                                    LuaKey.String "default", LuaValue.Number 24.0
                                    LuaKey.String "vtol", LuaValue.Number 480.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "noattackrangearc", LuaValue.Number 1.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR"
                            LuaKey.String "def", LuaValue.String "birdshot"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 25.0
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                            LuaKey.String "weaponAimAdjustPriority", LuaValue.Number 20.0
                        ]
                ]
        ]

    let legwhisper =
        LuaValue.Table [
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "maxdec", LuaValue.Number 0.0375
            LuaKey.String "energycost", LuaValue.Number 9000.0
            LuaKey.String "metalcost", LuaValue.Number 210.0
            LuaKey.String "buildpic", LuaValue.String "legwhisper.DDS"
            LuaKey.String "buildtime", LuaValue.Number 16480.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collide", LuaValue.Bool false
            LuaKey.String "cruisealtitude", LuaValue.Number 130.0
            LuaKey.String "explodeas", LuaValue.String "mediumexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "maxacc", LuaValue.Number 0.1575
            LuaKey.String "maxaileron", LuaValue.Number 0.01366
            LuaKey.String "maxbank", LuaValue.Number 0.8
            LuaKey.String "health", LuaValue.Number 990.0
            LuaKey.String "maxelevator", LuaValue.Number 0.00991
            LuaKey.String "maxpitch", LuaValue.Number 0.625
            LuaKey.String "maxrudder", LuaValue.Number 0.00541
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "speed", LuaValue.Number 321.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "objectname", LuaValue.String "Units/legwhisper.s3o"
            LuaKey.String "radardistance", LuaValue.Number 2400.0
            LuaKey.String "script", LuaValue.String "Units/legwhisper.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 1250.0
            LuaKey.String "sonardistance", LuaValue.Number 1200.0
            LuaKey.String "speedtofront", LuaValue.Number 0.06417
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "turnradius", LuaValue.Number 64.0
            LuaKey.String "turnrate", LuaValue.Number 650.0
            LuaKey.String "usesmoothmesh", LuaValue.Bool true
            LuaKey.String "wingangle", LuaValue.Number 0.06241
            LuaKey.String "wingdrag", LuaValue.Number 0.11
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "util"
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Legion/Air/T2 Air"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
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
                            LuaKey.Int 1, LuaValue.String "vtolcrmv"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "caradsel"
                        ]
                ]
        ]

    let all : (string * LuaValue) list =
        [
            "legafigdef", legafigdef
            "legatorpbomber", legatorpbomber
            "legfort", legfort
            "legheavydrone", legheavydrone
            "legheavydronesmall", legheavydronesmall
            "legionnaire", legionnaire
            "legmineb", legmineb
            "legnap", legnap
            "legphoenix", legphoenix
            "legstronghold", legstronghold
            "legvenator", legvenator
            "legwhisper", legwhisper
        ]
