// Auto-generated BAR unit data: Scavengers/Air
namespace BarData.Units

open BarData

module Scavengers_Air =

    let armfepocht4 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.015
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "bankingallowed", LuaValue.Bool false
            LuaKey.String "maxdec", LuaValue.Number 0.05
            LuaKey.String "buildangle", LuaValue.Number 16384.0
            LuaKey.String "energycost", LuaValue.Number 250000.0
            LuaKey.String "metalcost", LuaValue.Number 25000.0
            LuaKey.String "buildpic", LuaValue.String "armfepocht4.DDS"
            LuaKey.String "buildtime", LuaValue.Number 250000.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "category", LuaValue.String "T4AIR"
            LuaKey.String "collide", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -14 10"
            LuaKey.String "collisionvolumescales", LuaValue.String "70 70 170"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylZ"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "cruisealtitude", LuaValue.Number 100.0
            LuaKey.String "explodeas", LuaValue.String "flagshipExplosion"
            LuaKey.String "footprintx", LuaValue.Number 6.0
            LuaKey.String "footprintz", LuaValue.Number 6.0
            LuaKey.String "hoverattack", LuaValue.Bool true
            LuaKey.String "sightemitheight", LuaValue.Number 52.0
            LuaKey.String "mass", LuaValue.Number 1000000.0
            LuaKey.String "health", LuaValue.Number 67000.0
            LuaKey.String "speed", LuaValue.Number 36.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 15.0
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/scavboss/armfepocht4.s3o"
            LuaKey.String "script", LuaValue.String "Units/scavboss/armfepocht4.cob"
            LuaKey.String "radardistance", LuaValue.Number 1530.0
            LuaKey.String "radaremitheight", LuaValue.Number 52.0
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "flagshipExplosionSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 689.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 135.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.0
                    LuaKey.String "subfolder", LuaValue.String "ArmShips/T2"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.439918518066 -4.07348632798e-05 0.367340087891"
                            LuaKey.String "collisionvolumescales", LuaValue.String "75.0081939697 51.5621185303 178.425750732"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 30000.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 18.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 17000.0
                            LuaKey.String "object", LuaValue.String "Units/scavboss/armfepocht4_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 15000.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 8500.0
                            LuaKey.String "object", LuaValue.String "Units/arm6X6A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-medium"
                            LuaKey.Int 2, LuaValue.String "custom:barrelshot-large"
                            LuaKey.Int 3, LuaValue.String "custom:barrelshot-medium-aa"
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
                    LuaKey.String "flak", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 1000.0
                            LuaKey.String "areaofeffect", LuaValue.Number 128.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "flaktrailaa"
                            LuaKey.String "canattackground", LuaValue.Bool false
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
                            LuaKey.String "reloadtime", LuaValue.Number 1.0
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
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "vtol", LuaValue.Number 100.0
                                ]
                            LuaKey.String "rgbcolor", LuaValue.Table [
                                    LuaKey.Int 1, LuaValue.Number 1.0
                                    LuaKey.Int 2, LuaValue.Number 0.33
                                    LuaKey.Int 3, LuaValue.Number 0.7
                                ]
                        ]
                    LuaKey.String "heavyplasma", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 1200.0
                            LuaKey.String "areaofeffect", LuaValue.Number 64.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "arty-heavy"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "name", LuaValue.String "Primary rapid-fire heavy long-range plasma cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1500.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.0
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splssml"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy1"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 600.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 290.0
                                    LuaKey.String "subs", LuaValue.Number 100.0
                                    LuaKey.String "vtol", LuaValue.Number 130.0
                                ]
                        ]
                    LuaKey.String "mediumplasma", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 500.0
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
                            LuaKey.String "reloadtime", LuaValue.Number 1.5
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy1"
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 570.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 270.0
                                    LuaKey.String "subs", LuaValue.Number 65.0
                                    LuaKey.String "vtol", LuaValue.Number 65.0
                                ]
                        ]
                    LuaKey.String "ferret_missile", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 2.0
                            LuaKey.String "burstrate", LuaValue.Number 0.2
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "canattackground", LuaValue.Bool false
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
                            LuaKey.String "reloadtime", LuaValue.Number 3.4
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 5.0
                            LuaKey.String "smoketime", LuaValue.Number 12.0
                            LuaKey.String "smokesize", LuaValue.Number 4.8
                            LuaKey.String "smokecolor", LuaValue.Number 0.95
                            LuaKey.String "smokeTrailCastShadow", LuaValue.Bool false
                            LuaKey.String "castshadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "packohit"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "packolau"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "startvelocity", LuaValue.Number 1.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailaa"
                            LuaKey.String "tolerance", LuaValue.Number 9950.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 68000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 1500.0
                            LuaKey.String "weapontimer", LuaValue.Number 2.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1200.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "vtol", LuaValue.Number 50.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "HEAVYPLASMA"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE T4AIR"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "MEDIUMPLASMA"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 320.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE T4AIR"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "HEAVYPLASMA"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 240.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE T4AIR"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "MEDIUMPLASMA"
                            LuaKey.String "maindir", LuaValue.String "-4 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 180.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE T4AIR"
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "MEDIUMPLASMA"
                            LuaKey.String "maindir", LuaValue.String "4 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 180.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE T4AIR"
                        ]
                    LuaKey.Int 6, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR GROUNDSCOUT"
                            LuaKey.String "maindir", LuaValue.String "0 -1 -2"
                            LuaKey.String "maxangledif", LuaValue.Number 270.0
                            LuaKey.String "def", LuaValue.String "FERRET_MISSILE"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                    LuaKey.Int 7, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "FERRET_MISSILE"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let armfify =
        LuaValue.Table [
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "ARMFIFY.DDS"
            LuaKey.String "builddistance", LuaValue.Number 150.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildtime", LuaValue.Number 3800.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canassist", LuaValue.Bool false
            LuaKey.String "canrepair", LuaValue.Bool true
            LuaKey.String "canrestore", LuaValue.Bool true
            LuaKey.String "canresurrect", LuaValue.Bool true
            LuaKey.String "cantbetransported", LuaValue.Bool false
            LuaKey.String "collide", LuaValue.Bool true
            LuaKey.String "cruisealtitude", LuaValue.Number 78.0
            LuaKey.String "energycost", LuaValue.Number 2900.0
            LuaKey.String "explodeas", LuaValue.String "tinyExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "health", LuaValue.Number 83.0
            LuaKey.String "hoverattack", LuaValue.Bool true
            LuaKey.String "maxacc", LuaValue.Number 0.25
            LuaKey.String "maxdec", LuaValue.Number 0.55
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 58.0
            LuaKey.String "nochasecategory", LuaValue.String "COMMANDER VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/ARMFIFY.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMFIFY.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "tinyExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 364.0
            LuaKey.String "speed", LuaValue.Number 208.0
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 360.0
            LuaKey.String "turnrate", LuaValue.Number 1100.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "usesmoothmesh", LuaValue.Number 0.0
            LuaKey.String "workertime", LuaValue.Number 75.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Darknagura, Fritman"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmAircraft"
                    LuaKey.String "unitgroup", LuaValue.String "builder"
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

    let armlichet4 =
        LuaValue.Table [
            LuaKey.String "acceleration", LuaValue.Number 0.15
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "maxdec", LuaValue.Number 0.05
            LuaKey.String "energycost", LuaValue.Number 240000.0
            LuaKey.String "metalcost", LuaValue.Number 18000.0
            LuaKey.String "buildpic", LuaValue.String "ARMLICHE.DDS"
            LuaKey.String "buildtime", LuaValue.Number 240000.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "category", LuaValue.String "T4AIR"
            LuaKey.String "collide", LuaValue.Bool false
            LuaKey.String "cruisealtitude", LuaValue.Number 150.0
            LuaKey.String "explodeas", LuaValue.String "hugeexplosiongeneric"
            LuaKey.String "firestate", LuaValue.Number 0.0
            LuaKey.String "footprintx", LuaValue.Number 6.0
            LuaKey.String "footprintz", LuaValue.Number 6.0
            LuaKey.String "maxacc", LuaValue.Number 0.1075
            LuaKey.String "maxaileron", LuaValue.Number 0.01325
            LuaKey.String "maxbank", LuaValue.Number 0.3
            LuaKey.String "health", LuaValue.Number 10000.0
            LuaKey.String "maxelevator", LuaValue.Number 0.0095
            LuaKey.String "maxpitch", LuaValue.Number 0.3
            LuaKey.String "maxrudder", LuaValue.Number 0.005
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "speed", LuaValue.Number 180.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/scavboss/ARMLICHET4.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMLICHE.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "hugeExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 455.0
            LuaKey.String "speedtofront", LuaValue.Number 0.06767
            LuaKey.String "turnradius", LuaValue.Number 256.0
            LuaKey.String "turnrate", LuaValue.Number 256.0
            LuaKey.String "usesmoothmesh", LuaValue.Bool true
            LuaKey.String "wingangle", LuaValue.Number 0.062
            LuaKey.String "wingdrag", LuaValue.Number 0.135
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "lumamult", LuaValue.String "1.7"
                    LuaKey.String "model_author", LuaValue.String "Flaka"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmAircraft/T2"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                    LuaKey.String "attacksafetydistance", LuaValue.Number 20000.0
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
                    LuaKey.String "nuclear_missile", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 1280.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "collideenemy", LuaValue.Bool false
                            LuaKey.String "collidefeature", LuaValue.Bool false
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "craterareaofeffect", LuaValue.Number 1280.0
                            LuaKey.String "craterboost", LuaValue.Number 2.4
                            LuaKey.String "cratermult", LuaValue.Number 1.2
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.45
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:newnuke"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "flighttime", LuaValue.Number 400.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "model", LuaValue.String "crblmssl.s3o"
                            LuaKey.String "name", LuaValue.String "Intercontinental ballistic nuclear warhead"
                            LuaKey.String "range", LuaValue.Number 800.0
                            LuaKey.String "reloadtime", LuaValue.Number 120.0
                            LuaKey.String "mygravity", LuaValue.Number 0.4
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 10.0
                            LuaKey.String "smoketime", LuaValue.Number 130.0
                            LuaKey.String "smokesize", LuaValue.Number 280.0
                            LuaKey.String "smokecolor", LuaValue.Number 0.85
                            LuaKey.String "smokeTrailCastShadow", LuaValue.Bool true
                            LuaKey.String "soundhit", LuaValue.String "nukearm"
                            LuaKey.String "soundhitwet", LuaValue.String "nukewater"
                            LuaKey.String "soundstart", LuaValue.String "nukelaunch"
                            LuaKey.String "soundhitwetvolume", LuaValue.Number 53.0
                            LuaKey.String "soundstartvolume", LuaValue.Number 20.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "railguntrail"
                            LuaKey.String "texture3", LuaValue.String "null"
                            LuaKey.String "tolerance", LuaValue.Number 4000.0
                            LuaKey.String "turnrate", LuaValue.Number 5500.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 100.0
                            LuaKey.String "weapontimer", LuaValue.Number 5.0
                            LuaKey.String "weapontype", LuaValue.String "AircraftBomb"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1600.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 2500.0
                                    LuaKey.String "default", LuaValue.Number 9500.0
                                    LuaKey.String "vtol", LuaValue.Number 2000.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "nuclear", LuaValue.Number 1.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "nuclear_missile"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let armminebomber =
        LuaValue.Table [
            LuaKey.String "acceleration", LuaValue.Number 0.05
            LuaKey.String "maxdec", LuaValue.Number 0.05
            LuaKey.String "energycost", LuaValue.Number 4200.0
            LuaKey.String "metalcost", LuaValue.Number 145.0
            LuaKey.String "buildpic", LuaValue.String "ARMTHUND.DDS"
            LuaKey.String "buildtime", LuaValue.Number 4800.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collide", LuaValue.Bool false
            LuaKey.String "cruisealtitude", LuaValue.Number 165.0
            LuaKey.String "explodeas", LuaValue.String "mediumexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "maxacc", LuaValue.Number 0.0575
            LuaKey.String "maxaileron", LuaValue.Number 0.0144
            LuaKey.String "maxbank", LuaValue.Number 0.8
            LuaKey.String "health", LuaValue.Number 670.0
            LuaKey.String "maxelevator", LuaValue.Number 0.01065
            LuaKey.String "maxpitch", LuaValue.Number 0.625
            LuaKey.String "maxrudder", LuaValue.Number 0.00615
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "speed", LuaValue.Number 255.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "noautofire", LuaValue.Bool true
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Units/scavboss/ARMMINEBOMBER.s3o"
            LuaKey.String "script", LuaValue.String "Units/scavboss/ARMMINEBOMBER.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 195.0
            LuaKey.String "speedtofront", LuaValue.Number 0.063
            LuaKey.String "turnradius", LuaValue.Number 64.0
            LuaKey.String "turnrate", LuaValue.Number 850.0
            LuaKey.String "usesmoothmesh", LuaValue.Bool true
            LuaKey.String "wingangle", LuaValue.Number 0.06315
            LuaKey.String "wingdrag", LuaValue.Number 0.135
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
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
                    LuaKey.String "armbomb", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 500.0
                            LuaKey.String "areaofeffect", LuaValue.Number 144.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 5.0
                            LuaKey.String "burstrate", LuaValue.Number 0.3
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "commandfire", LuaValue.Bool false
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "craterareaofeffect", LuaValue.Number 144.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.55
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-bomb"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "model", LuaValue.String "airbomb.s3o"
                            LuaKey.String "name", LuaValue.String "Light a2g impulse warheads"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1280.0
                            LuaKey.String "reloadtime", LuaValue.Number 6.0
                            LuaKey.String "soundhit", LuaValue.String "bombssml1"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "bombrel"
                            LuaKey.String "sprayangle", LuaValue.Number 300.0
                            LuaKey.String "weapontype", LuaValue.String "AircraftBomb"
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 105.0
                                    LuaKey.String "subs", LuaValue.Number 35.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "MOBILE"
                            LuaKey.String "def", LuaValue.String "ARMBOMB"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let armthundt4 =
        LuaValue.Table [
            LuaKey.String "acceleration", LuaValue.Number 0.02
            LuaKey.String "maxdec", LuaValue.Number 0.01
            LuaKey.String "energycost", LuaValue.Number 150000.0
            LuaKey.String "metalcost", LuaValue.Number 15000.0
            LuaKey.String "buildpic", LuaValue.String "ARMTHUNDT4.DDS"
            LuaKey.String "buildtime", LuaValue.Number 150000.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "category", LuaValue.String "T4AIR"
            LuaKey.String "collide", LuaValue.Bool false
            LuaKey.String "cruisealtitude", LuaValue.Number 190.0
            LuaKey.String "explodeas", LuaValue.String "explosiont3xl"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "maxacc", LuaValue.Number 0.032
            LuaKey.String "maxaileron", LuaValue.Number 0.003
            LuaKey.String "maxbank", LuaValue.Number 0.33
            LuaKey.String "health", LuaValue.Number 16700.0
            LuaKey.String "maxelevator", LuaValue.Number 0.0033
            LuaKey.String "maxpitch", LuaValue.Number 0.3
            LuaKey.String "maxrudder", LuaValue.Number 0.0052
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "speed", LuaValue.Number 367.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "noautofire", LuaValue.Bool true
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Units/scavboss/ARMTHUNDT4.s3o"
            LuaKey.String "script", LuaValue.String "Units/scavboss/ARMTHUNDT4.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "explosiont3xxl"
            LuaKey.String "sightdistance", LuaValue.Number 2500.0
            LuaKey.String "speedtofront", LuaValue.Number 0.041
            LuaKey.String "turnradius", LuaValue.Number 256.0
            LuaKey.String "turnrate", LuaValue.Number 212.0
            LuaKey.String "usesmoothmesh", LuaValue.Bool true
            LuaKey.String "wingangle", LuaValue.Number 0.045
            LuaKey.String "wingdrag", LuaValue.Number 0.135
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmAircraft"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
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
                    LuaKey.String "armbomb", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 10000.0
                            LuaKey.String "areaofeffect", LuaValue.Number 280.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 28.0
                            LuaKey.String "burstrate", LuaValue.Number 0.1
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "commandfire", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 280.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.75
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-huge-bomb"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 2.5
                            LuaKey.String "model", LuaValue.String "units/armvader.s3o"
                            LuaKey.String "name", LuaValue.String "Ultra Heavy Bombs"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 2480.0
                            LuaKey.String "reloadtime", LuaValue.Number 4.0
                            LuaKey.String "soundhit", LuaValue.String "xplolrg4"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "bombrelxl"
                            LuaKey.String "sprayangle", LuaValue.Number 8000.0
                            LuaKey.String "weapontype", LuaValue.String "AircraftBomb"
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 150.0
                                    LuaKey.String "default", LuaValue.Number 900.0
                                    LuaKey.String "subs", LuaValue.Number 100.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "MOBILE"
                            LuaKey.String "def", LuaValue.String "ARMBOMB"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let corcrw =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.15
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "blocking", LuaValue.Bool true
            LuaKey.String "bankingallowed", LuaValue.Bool false
            LuaKey.String "maxdec", LuaValue.Number 0.15
            LuaKey.String "energycost", LuaValue.Number 72000.0
            LuaKey.String "metalcost", LuaValue.Number 5100.0
            LuaKey.String "buildpic", LuaValue.String "CORCRW.DDS"
            LuaKey.String "buildtime", LuaValue.Number 84200.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collide", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 1 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "64 24 64"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "cruisealtitude", LuaValue.Number 75.0
            LuaKey.String "explodeas", LuaValue.String "largeexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "hoverattack", LuaValue.Bool true
            LuaKey.String "health", LuaValue.Number 16700.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "speed", LuaValue.Number 114.9
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/CORCRW.s3o"
            LuaKey.String "script", LuaValue.String "Units/CORCRW.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 494.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 360.0
            LuaKey.String "turnrate", LuaValue.Number 300.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
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
                    LuaKey.String "krowlaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 8.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.1
                            LuaKey.String "beamttl", LuaValue.Number 1.0
                            LuaKey.String "corethickness", LuaValue.Number 0.13
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 50.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small-green"
                            LuaKey.String "firestarter", LuaValue.Number 90.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 6.05
                            LuaKey.String "name", LuaValue.String "HighEnergyLaser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 575.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.63333
                            LuaKey.String "rgbcolor", LuaValue.String "0 1 0"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrcrw1"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 2.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 800.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 90.0
                                ]
                        ]
                    LuaKey.String "krowlaser2", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 32.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.25
                            LuaKey.String "beamttl", LuaValue.Number 1.0
                            LuaKey.String "corethickness", LuaValue.Number 0.2
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 100.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-large-green"
                            LuaKey.String "firestarter", LuaValue.Number 90.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 7.7
                            LuaKey.String "name", LuaValue.String "High energy a2g laser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 525.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.3
                            LuaKey.String "rgbcolor", LuaValue.String "0 1 0"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrcrw2"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 2.7
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 800.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 250.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "KROWLASER2"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "KROWLASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "KROWLASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let corcrwt4 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.08
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "bankingallowed", LuaValue.Bool false
            LuaKey.String "maxdec", LuaValue.Number 0.275
            LuaKey.String "energycost", LuaValue.Number 150000.0
            LuaKey.String "metalcost", LuaValue.Number 15000.0
            LuaKey.String "buildpic", LuaValue.String "scavengers/corcrwt4.DDS"
            LuaKey.String "buildtime", LuaValue.Number 150000.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "category", LuaValue.String "T4AIR"
            LuaKey.String "collide", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 10 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "80 51 120"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "cruisealtitude", LuaValue.Number 110.0
            LuaKey.String "explodeas", LuaValue.String "bantha"
            LuaKey.String "footprintx", LuaValue.Number 5.0
            LuaKey.String "footprintz", LuaValue.Number 5.0
            LuaKey.String "hoverattack", LuaValue.Bool true
            LuaKey.String "health", LuaValue.Number 22000.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "speed", LuaValue.Number 114.9
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/scavboss/corcrwt4.s3o"
            LuaKey.String "script", LuaValue.String "Units/scavboss/corcrwt4.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "bantha"
            LuaKey.String "sightdistance", LuaValue.Number 675.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 360.0
            LuaKey.String "turnrate", LuaValue.Number 200.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "maxrange", LuaValue.String "450"
                    LuaKey.String "unitgroup", LuaValue.String "aa"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob, Hornet"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "other/scavengers"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
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
                    LuaKey.String "kmaw", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 0.0
                            LuaKey.String "areaofeffect", LuaValue.Number 128.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool true
                            LuaKey.String "avoidground", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 12.0
                            LuaKey.String "burstrate", LuaValue.Number 0.03333
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "bouncerebound", LuaValue.Number 1.0
                            LuaKey.String "cegtag", LuaValue.String "burnflamethermite"
                            LuaKey.String "colormap", LuaValue.String "1 0.95 0.9 0.032   0.55 0.55 0.40 0.028   0.40 0.28 0.19 0.024   0.033 0.018 0.011 0.04   0.0 0.0 0.0 0.01"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.01
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:burnthermite"
                            LuaKey.String "bounceSlip", LuaValue.Number 1.0
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "firesubmersed", LuaValue.Bool false
                            LuaKey.String "flameGFXTime", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.85
                            LuaKey.String "name", LuaValue.String "Demon's Maw; Heavy long range AoE flamethrower"
                            LuaKey.String "noexplode", LuaValue.Bool false
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 500.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.39996
                            LuaKey.String "sizegrowth", LuaValue.Number 2.25
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "Flamhvy1"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "soundstartvolume", LuaValue.Number 25.0
                            LuaKey.String "soundhitvolume", LuaValue.Number 25.0
                            LuaKey.String "soundhitwetvolume", LuaValue.Number 34.0
                            LuaKey.String "tolerance", LuaValue.Number 20000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool false
                            LuaKey.String "weapontype", LuaValue.String "Flame"
                            LuaKey.String "weaponvelocity", LuaValue.Number 500.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "noattackrangearc", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 40.0
                                    LuaKey.String "subs", LuaValue.Number 10.0
                                ]
                        ]
                    LuaKey.String "edragon_missile", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "missiletrailaa-medium"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-aa"
                            LuaKey.String "firestarter", LuaValue.Number 72.0
                            LuaKey.String "flighttime", LuaValue.Number 2.5
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "cormissile.s3o"
                            LuaKey.String "name", LuaValue.String "Advanced antiair rapid missile launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 840.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.4
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 7.0
                            LuaKey.String "smoketime", LuaValue.Number 10.0
                            LuaKey.String "smokesize", LuaValue.Number 4.2
                            LuaKey.String "smokecolor", LuaValue.Number 1.0
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
                            LuaKey.String "weaponacceleration", LuaValue.Number 160.0
                            LuaKey.String "weapontimer", LuaValue.Number 2.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1250.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "bombers", LuaValue.Number 400.0
                                    LuaKey.String "fighters", LuaValue.Number 400.0
                                    LuaKey.String "vtol", LuaValue.Number 400.0
                                ]
                        ]
                    LuaKey.String "krowbosslaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 8.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.25
                            LuaKey.String "beamttl", LuaValue.Number 1.75
                            LuaKey.String "corethickness", LuaValue.Number 0.13
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 50.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-large-green"
                            LuaKey.String "firestarter", LuaValue.Number 90.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 6.05
                            LuaKey.String "name", LuaValue.String "Ultra HighEnergyLaser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 625.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.5
                            LuaKey.String "rgbcolor", LuaValue.String "0 1 0"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrhvy3"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "targetmoveerror", LuaValue.Number 0.3
                            LuaKey.String "thickness", LuaValue.Number 4.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 800.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "noattackrangearc", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 200.0
                                    LuaKey.String "default", LuaValue.Number 2000.0
                                    LuaKey.String "vtol", LuaValue.Number 200.0
                                    LuaKey.String "subs", LuaValue.Number 200.0
                                ]
                        ]
                    LuaKey.String "krowbosslaser2", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 32.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.5
                            LuaKey.String "beamttl", LuaValue.Number 2.5
                            LuaKey.String "corethickness", LuaValue.Number 0.2
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 100.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-beam"
                            LuaKey.String "firestarter", LuaValue.Number 90.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 7.7
                            LuaKey.String "name", LuaValue.String "Ultra High energy a2g laser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 680.0
                            LuaKey.String "reloadtime", LuaValue.Number 5.2
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.8 0"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.8 0 0"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrhvy3"
                            LuaKey.String "soundstartvolume", LuaValue.Number 35.0
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 6.7
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 800.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "noattackrangearc", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 500.0
                                    LuaKey.String "default", LuaValue.Number 5000.0
                                    LuaKey.String "vtol", LuaValue.Number 500.0
                                    LuaKey.String "subs", LuaValue.Number 500.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "kmaw"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                            LuaKey.String "maindir", LuaValue.String "0 -1 1"
                            LuaKey.String "maxangledif", LuaValue.Number 180.0
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "edragon_missile"
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "KROWBOSSLASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                            LuaKey.String "maindir", LuaValue.String "1 -1 0"
                            LuaKey.String "maxangledif", LuaValue.Number 180.0
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "KROWBOSSLASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                            LuaKey.String "maindir", LuaValue.String "1 -1 0"
                            LuaKey.String "maxangledif", LuaValue.Number 180.0
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "KROWBOSSLASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                            LuaKey.String "maindir", LuaValue.String "-1 -1 0"
                            LuaKey.String "maxangledif", LuaValue.Number 180.0
                        ]
                    LuaKey.Int 6, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "KROWBOSSLASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                            LuaKey.String "maindir", LuaValue.String "-1 -1 0"
                            LuaKey.String "maxangledif", LuaValue.Number 180.0
                        ]
                ]
        ]

    let cordronecarryair =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.018
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "maxdec", LuaValue.Number 0.01722
            LuaKey.String "buildangle", LuaValue.Number 16384.0
            LuaKey.String "energycost", LuaValue.Number 17000.0
            LuaKey.String "metalcost", LuaValue.Number 1700.0
            LuaKey.String "buildpic", LuaValue.String "CORDRONECARRY.DDS"
            LuaKey.String "buildtime", LuaValue.Number 24000.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canreclaim", LuaValue.Bool false
            LuaKey.String "canrepair", LuaValue.Bool false
            LuaKey.String "canrestore", LuaValue.Bool false
            LuaKey.String "collide", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "-1 5 2"
            LuaKey.String "collisionvolumescales", LuaValue.String "48 48 136"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylZ"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "cruisealtitude", LuaValue.Number 100.0
            LuaKey.String "energymake", LuaValue.Number 25.0
            LuaKey.String "energystorage", LuaValue.Number 1500.0
            LuaKey.String "energyupkeep", LuaValue.Number 25.0
            LuaKey.String "explodeas", LuaValue.String "hugeexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 6.0
            LuaKey.String "footprintz", LuaValue.Number 6.0
            LuaKey.String "hoverattack", LuaValue.Bool true
            LuaKey.String "sightemitheight", LuaValue.Number 56.0
            LuaKey.String "mass", LuaValue.Number 10000.0
            LuaKey.String "health", LuaValue.Number 3500.0
            LuaKey.String "speed", LuaValue.Number 34.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 15.0
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/CORDRONECARRYAIR.s3o"
            LuaKey.String "radardistance", LuaValue.Number 1500.0
            LuaKey.String "radaremitheight", LuaValue.Number 56.0
            LuaKey.String "script", LuaValue.String "Units/CORDRONECARRYAIR.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "hugeexplosiongenericSelfD"
            LuaKey.String "sightdistance", LuaValue.Number 700.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 135.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Odin"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Scavengers/air"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
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
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 700.0
                            LuaKey.String "object", LuaValue.String "Units/cordronecarry_dead.s3o"
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
                            LuaKey.String "metalpershot", LuaValue.Number 40.0
                            LuaKey.String "energypershot", LuaValue.Number 1000.0
                            LuaKey.String "range", LuaValue.Number 1200.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.5
                            LuaKey.String "size", LuaValue.Number 0.0
                            LuaKey.String "soundhit", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String ""
                            LuaKey.String "soundstart", LuaValue.String ""
                            LuaKey.String "stockpile", LuaValue.Bool true
                            LuaKey.String "stockpiletime", LuaValue.Number 6.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 800.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 0.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "carried_unit", LuaValue.String "cordrone"
                                    LuaKey.String "engagementrange", LuaValue.Number 1300.0
                                    LuaKey.String "spawnrate", LuaValue.Number 6.0
                                    LuaKey.String "maxunits", LuaValue.Number 10.0
                                    LuaKey.String "startingdronecount", LuaValue.Number 5.0
                                    LuaKey.String "energycost", LuaValue.Number 1000.0
                                    LuaKey.String "metalcost", LuaValue.Number 40.0
                                    LuaKey.String "controlradius", LuaValue.Number 1100.0
                                    LuaKey.String "decayrate", LuaValue.Number 9.0
                                    LuaKey.String "attackformationspread", LuaValue.Number 200.0
                                    LuaKey.String "attackformationoffset", LuaValue.Number 30.0
                                    LuaKey.String "carrierdeaththroe", LuaValue.String "release"
                                    LuaKey.String "dockingarmor", LuaValue.Number 0.2
                                    LuaKey.String "dockinghealrate", LuaValue.Number 36.0
                                    LuaKey.String "docktohealthreshold", LuaValue.Number 50.0
                                    LuaKey.String "enabledocking", LuaValue.Bool true
                                    LuaKey.String "dockingHelperSpeed", LuaValue.Number 5.0
                                    LuaKey.String "dockingpieces", LuaValue.String "9 10 11 12 13 14 15 16 17 18 19"
                                    LuaKey.String "dockingradius", LuaValue.Number 300.0
                                    LuaKey.String "stockpilelimit", LuaValue.Number 10.0
                                    LuaKey.String "stockpilemetal", LuaValue.Number 40.0
                                    LuaKey.String "stockpileenergy", LuaValue.Number 1000.0
                                    LuaKey.String "dronesusestockpile", LuaValue.Bool true
                                    LuaKey.String "dronedocktime", LuaValue.Number 2.0
                                    LuaKey.String "droneairtime", LuaValue.Number 30.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "PLASMA"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let cords =
        LuaValue.Table [
            LuaKey.String "acceleration", LuaValue.Number 0.05
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "maxdec", LuaValue.Number 0.055
            LuaKey.String "energycost", LuaValue.Number 14600.0
            LuaKey.String "metalcost", LuaValue.Number 1000.0
            LuaKey.String "buildpic", LuaValue.String "CORSHAD.DDS"
            LuaKey.String "buildtime", LuaValue.Number 5000.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collide", LuaValue.Bool true
            LuaKey.String "cruisealtitude", LuaValue.Number 165.0
            LuaKey.String "explodeas", LuaValue.String "mediumexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "maxacc", LuaValue.Number 0.0575
            LuaKey.String "maxaileron", LuaValue.Number 0.01421
            LuaKey.String "maxbank", LuaValue.Number 0.66
            LuaKey.String "health", LuaValue.Number 680.0
            LuaKey.String "maxelevator", LuaValue.Number 0.01046
            LuaKey.String "maxpitch", LuaValue.Number 0.625
            LuaKey.String "maxrudder", LuaValue.Number 0.00596
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "speed", LuaValue.Number 234.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "noautofire", LuaValue.Bool true
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "scavs/CORDS.s3o"
            LuaKey.String "script", LuaValue.String "scavs/CORDS.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 169.0
            LuaKey.String "speedtofront", LuaValue.Number 0.06183
            LuaKey.String "turnradius", LuaValue.Number 256.0
            LuaKey.String "turnrate", LuaValue.Number 500.0
            LuaKey.String "usesmoothmesh", LuaValue.Bool true
            LuaKey.String "wingangle", LuaValue.Number 0.16296
            LuaKey.String "wingdrag", LuaValue.Number 0.145
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Scavengers"
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
                    LuaKey.String "corbomb", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 500.0
                            LuaKey.String "areaofeffect", LuaValue.Number 100.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 6.0
                            LuaKey.String "burstrate", LuaValue.Number 0.26667
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "commandfire", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 100.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.4
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-bomb"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.3
                            LuaKey.String "model", LuaValue.String "akbomb.s3o"
                            LuaKey.String "name", LuaValue.String "AK Bomb"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1280.0
                            LuaKey.String "reloadtime", LuaValue.Number 10.0
                            LuaKey.String "soundhit", LuaValue.String "bombssml1"
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundstart", LuaValue.String "bombrel"
                            LuaKey.String "sprayangle", LuaValue.Number 300.0
                            LuaKey.String "weapontype", LuaValue.String "AircraftBomb"
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "spawns_name", LuaValue.String "corak"
                                    LuaKey.String "spawns_surface", LuaValue.String "LAND"
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 100.0
                                    LuaKey.String "subs", LuaValue.Number 30.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "MOBILE"
                            LuaKey.String "def", LuaValue.String "CORBOMB"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let corfblackhyt4 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.015
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "bankingallowed", LuaValue.Bool false
            LuaKey.String "maxdec", LuaValue.Number 0.05
            LuaKey.String "buildangle", LuaValue.Number 16384.0
            LuaKey.String "energycost", LuaValue.Number 250000.0
            LuaKey.String "metalcost", LuaValue.Number 25000.0
            LuaKey.String "buildpic", LuaValue.String "corfblackhyt4.DDS"
            LuaKey.String "buildtime", LuaValue.Number 250000.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "category", LuaValue.String "T4AIR"
            LuaKey.String "collide", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -14 10"
            LuaKey.String "collisionvolumescales", LuaValue.String "70 70 170"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylZ"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "cruisealtitude", LuaValue.Number 100.0
            LuaKey.String "explodeas", LuaValue.String "FlagshipExplosion"
            LuaKey.String "footprintx", LuaValue.Number 6.0
            LuaKey.String "footprintz", LuaValue.Number 6.0
            LuaKey.String "hoverattack", LuaValue.Bool true
            LuaKey.String "sightemitheight", LuaValue.Number 64.0
            LuaKey.String "mass", LuaValue.Number 1000000.0
            LuaKey.String "health", LuaValue.Number 67000.0
            LuaKey.String "speed", LuaValue.Number 36.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 15.0
            LuaKey.String "objectname", LuaValue.String "Units/scavboss/corfblackhyt4.s3o"
            LuaKey.String "script", LuaValue.String "Units/scavboss/corfblackhyt4.cob"
            LuaKey.String "radardistance", LuaValue.Number 1510.0
            LuaKey.String "radaremitheight", LuaValue.Number 64.0
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "FlagshipExplosionSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 650.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 129.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "Beherith"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.0
                    LuaKey.String "subfolder", LuaValue.String "CorShips/T2"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "17.3217697144 -6.85541303711 2.43087005615"
                            LuaKey.String "collisionvolumescales", LuaValue.String "88.47706604 56.7307739258 178.029220581"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 30000.0
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 18.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 18000.0
                            LuaKey.String "object", LuaValue.String "Units/scavboss/corfblackhyt4_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
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
                            LuaKey.Int 1, LuaValue.String "sharmmov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "sharmsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "aamissile", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 64.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 1.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-tiny-aa"
                            LuaKey.String "firestarter", LuaValue.Number 70.0
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "cormissile.s3o"
                            LuaKey.String "name", LuaValue.String "RapidSamMissile"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 950.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.6
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splssml"
                            LuaKey.String "soundstart", LuaValue.String "Rocklit3"
                            LuaKey.String "startvelocity", LuaValue.Number 650.0
                            LuaKey.String "tolerance", LuaValue.Number 8000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 72000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 150.0
                            LuaKey.String "weapontimer", LuaValue.Number 7.0
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 950.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 75.0
                                ]
                        ]
                    LuaKey.String "heavylaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 8.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.2
                            LuaKey.String "corethickness", LuaValue.Number 0.2
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 125.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-medium-green"
                            LuaKey.String "firestarter", LuaValue.Number 90.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 12.1
                            LuaKey.String "name", LuaValue.String "HighEnergyLaser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 830.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.0
                            LuaKey.String "rgbcolor", LuaValue.String "0 1 0"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "Lasrmas2"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 3.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 700.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 270.0
                                    LuaKey.String "vtol", LuaValue.Number 65.0
                                ]
                        ]
                    LuaKey.String "heavyplasma", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 1200.0
                            LuaKey.String "areaofeffect", LuaValue.Number 128.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "arty-heavy"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "intensity", LuaValue.Number 1.1
                            LuaKey.String "name", LuaValue.String "BattleshipCannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1500.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.0
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy1"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 600.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 465.0
                                    LuaKey.String "subs", LuaValue.Number 100.0
                                    LuaKey.String "vtol", LuaValue.Number 130.0
                                ]
                        ]
                    LuaKey.String "ferret_missile", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 2.0
                            LuaKey.String "burstrate", LuaValue.Number 0.2
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "canattackground", LuaValue.Bool false
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
                            LuaKey.String "reloadtime", LuaValue.Number 3.4
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 5.0
                            LuaKey.String "smoketime", LuaValue.Number 12.0
                            LuaKey.String "smokesize", LuaValue.Number 4.4
                            LuaKey.String "smokecolor", LuaValue.Number 0.95
                            LuaKey.String "smokeTrailCastShadow", LuaValue.Bool false
                            LuaKey.String "castshadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "packohit"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "packolau"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "startvelocity", LuaValue.Number 1.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailaa"
                            LuaKey.String "tolerance", LuaValue.Number 9950.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 68000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 1500.0
                            LuaKey.String "weapontimer", LuaValue.Number 2.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1200.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "vtol", LuaValue.Number 50.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "HEAVYPLASMA"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE T4AIR"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "HEAVYLASER"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 300.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE T4AIR"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR GROUNDSCOUT"
                            LuaKey.String "maindir", LuaValue.String "-1.5 0 2"
                            LuaKey.String "maxangledif", LuaValue.Number 300.0
                            LuaKey.String "def", LuaValue.String "FERRET_MISSILE"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "HEAVYLASER"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 300.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE T4AIR"
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "HEAVYLASER"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 300.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE T4AIR"
                        ]
                    LuaKey.Int 6, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR GROUNDSCOUT"
                            LuaKey.String "maindir", LuaValue.String "1.5 0 2"
                            LuaKey.String "maxangledif", LuaValue.Number 300.0
                            LuaKey.String "def", LuaValue.String "FERRET_MISSILE"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let legfortt4 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.02
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "blocking", LuaValue.Bool true
            LuaKey.String "bankingallowed", LuaValue.Bool false
            LuaKey.String "maxdec", LuaValue.Number 0.02
            LuaKey.String "energycost", LuaValue.Number 790000.0
            LuaKey.String "metalcost", LuaValue.Number 56000.0
            LuaKey.String "buildpic", LuaValue.String "LEGFORT.DDS"
            LuaKey.String "buildtime", LuaValue.Number 900000.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "category", LuaValue.String "ALL WEAPON VTOL NOTSUB NOTHOVER"
            LuaKey.String "collide", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 1 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "140 80 220"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "cruisealtitude", LuaValue.Number 250.0
            LuaKey.String "explodeas", LuaValue.String "korgExplosion"
            LuaKey.String "footprintx", LuaValue.Number 8.0
            LuaKey.String "footprintz", LuaValue.Number 8.0
            LuaKey.String "hoverattack", LuaValue.Bool true
            LuaKey.String "health", LuaValue.Number 167000.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "speed", LuaValue.Number 30.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/scavboss/LEGFORTT4.s3o"
            LuaKey.String "radardistance", LuaValue.Number 1000.0
            LuaKey.String "script", LuaValue.String "Units/scavboss/legfortt4.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "korgExplosionSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 1200.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 360.0
            LuaKey.String "turnrate", LuaValue.Number 120.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "tHARSIS"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/LEG_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorAircraft/T2"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
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
                            LuaKey.String "accuracy", LuaValue.Number 250.0
                            LuaKey.String "areaofeffect", LuaValue.Number 25.0
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "collidefeature", LuaValue.Bool true
                            LuaKey.String "beamtime", LuaValue.Number 0.07
                            LuaKey.String "corethickness", LuaValue.Number 0.45
                            LuaKey.String "duration", LuaValue.Number 0.07
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-tiny-aa"
                            LuaKey.String "energypershot", LuaValue.Number 0.0
                            LuaKey.String "falloffrate", LuaValue.Number 0.0
                            LuaKey.String "firestarter", LuaValue.Number 50.0
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 4.0
                            LuaKey.String "minintensity", LuaValue.String "1"
                            LuaKey.String "name", LuaValue.String "scav rapid fire plasma gun"
                            LuaKey.String "range", LuaValue.Number 800.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.1
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "rgbcolor", LuaValue.String "0.7 0.7 0.0"
                            LuaKey.String "rgbcolor2", LuaValue.String "1 1 1"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "soundstart", LuaValue.String "tgunshipfire"
                            LuaKey.String "texture1", LuaValue.String "shot"
                            LuaKey.String "texture2", LuaValue.String "empty"
                            LuaKey.String "thickness", LuaValue.Number 7.5
                            LuaKey.String "tolerance", LuaValue.Number 3000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponvelocity", LuaValue.Number 1000.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "noattackrangearc", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 50.0
                                    LuaKey.String "vtol", LuaValue.Number 100.0
                                ]
                        ]
                    LuaKey.String "plasma", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 960.0
                            LuaKey.String "areaofeffect", LuaValue.Number 160.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "starfire_arty"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.65
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:ministarfire-explosion"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 1.25
                            LuaKey.String "name", LuaValue.String "PlasmaCannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1200.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.0
                            LuaKey.String "projectiles", LuaValue.Number 3.0
                            LuaKey.String "sprayangle", LuaValue.Number 2500.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.7 0.7 1.0"
                            LuaKey.String "soundhit", LuaValue.String "xplomed4"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy2"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 650.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "noattackrangearc", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 480.0
                                    LuaKey.String "subs", LuaValue.Number 50.0
                                    LuaKey.String "vtol", LuaValue.Number 30.0
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
                            LuaKey.String "flighttime", LuaValue.Number 7.5
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "legsmallrocket.s3o"
                            LuaKey.String "name", LuaValue.String "Advanced d2a rapid missile launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1240.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.2
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 5.0
                            LuaKey.String "smoketime", LuaValue.Number 8.0
                            LuaKey.String "smokesize", LuaValue.Number 4.2
                            LuaKey.String "smokecolor", LuaValue.Number 1.0
                            LuaKey.String "smokeTrailCastShadow", LuaValue.Bool false
                            LuaKey.String "castshadow", LuaValue.Bool false
                            LuaKey.String "startvelocity", LuaValue.Number 150.0
                            LuaKey.String "soundhit", LuaValue.String "packohit"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "packolau"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "startvelocity", LuaValue.Number 150.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailaa"
                            LuaKey.String "tolerance", LuaValue.Number 9950.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "trajectoryHeight", LuaValue.Number 1.0
                            LuaKey.String "turnrate", LuaValue.Number 52000.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 800.0
                            LuaKey.String "weapontype", LuaValue.String "StarburstLauncher"
                            LuaKey.String "weapontimer", LuaValue.Number 0.32
                            LuaKey.String "weaponvelocity", LuaValue.Number 1200.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "vtol", LuaValue.Number 154.0
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
                            LuaKey.String "maindir", LuaValue.String "1 0 0"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let legmost3 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.15
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "maxdec", LuaValue.Number 0.375
            LuaKey.String "energycost", LuaValue.Number 42000.0
            LuaKey.String "metalcost", LuaValue.Number 3000.0
            LuaKey.String "buildpic", LuaValue.String "LEGMOS.DDS"
            LuaKey.String "buildtime", LuaValue.Number 42000.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collide", LuaValue.Bool true
            LuaKey.String "cruisealtitude", LuaValue.Number 150.0
            LuaKey.String "explodeas", LuaValue.String "smallExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "hoverattack", LuaValue.Bool true
            LuaKey.String "health", LuaValue.Number 9000.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "speed", LuaValue.Number 130.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/legmost3.s3o"
            LuaKey.String "script", LuaValue.String "Units/legmost3.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "smallExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 800.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 360.0
            LuaKey.String "turnrate", LuaValue.Number 500.0
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
                    LuaKey.String "exp_heavyrocket", LuaValue.Table [
                            LuaKey.String "movingaccuracy", LuaValue.Number 3000.0
                            LuaKey.String "areaofeffect", LuaValue.Number 96.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 6.0
                            LuaKey.String "burstrate", LuaValue.Number 0.2
                            LuaKey.String "cegtag", LuaValue.String "missiletrailsmall-simple"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "dance", LuaValue.Number 25.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.65
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-catapult"
                            LuaKey.String "firestarter", LuaValue.Number 70.0
                            LuaKey.String "flighttime", LuaValue.Number 3.2
                            LuaKey.String "impulseboost", LuaValue.Number 0.123
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "legmediumrocket.s3o"
                            LuaKey.String "name", LuaValue.String "CatapultRockets"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number -1.0
                            LuaKey.String "range", LuaValue.Number 700.0
                            LuaKey.String "reloadtime", LuaValue.Number 3.0
                            LuaKey.String "smokecolor", LuaValue.Number 0.5
                            LuaKey.String "smokeperiod", LuaValue.Number 4.0
                            LuaKey.String "smokesize", LuaValue.Number 8.5
                            LuaKey.String "smoketime", LuaValue.Number 16.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smoketrailcastshadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "rockhit"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "rapidrocket3"
                            LuaKey.String "startvelocity", LuaValue.Number 300.0
                            LuaKey.String "stockpile", LuaValue.Bool true
                            LuaKey.String "stockpiletime", LuaValue.Number 6.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailbar"
                            LuaKey.String "tolerance", LuaValue.Number 4000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 5000.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 200.0
                            LuaKey.String "weapontimer", LuaValue.Number 6.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 700.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "stockpilelimit", LuaValue.Number 8.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 200.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "exp_heavyrocket"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let all : (string * LuaValue) list =
        [
            "armfepocht4", armfepocht4
            "armfify", armfify
            "armlichet4", armlichet4
            "armminebomber", armminebomber
            "armthundt4", armthundt4
            "corcrw", corcrw
            "corcrwt4", corcrwt4
            "cordronecarryair", cordronecarryair
            "cords", cords
            "corfblackhyt4", corfblackhyt4
            "legfortt4", legfortt4
            "legmost3", legmost3
        ]
